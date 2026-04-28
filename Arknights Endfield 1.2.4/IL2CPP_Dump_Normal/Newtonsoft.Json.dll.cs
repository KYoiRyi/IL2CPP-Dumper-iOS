// ========================================================
// Dumped by @desirepro
// Assembly: Newtonsoft.Json.dll
// Classes:  309
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000D  // size: 0x28
    public class Entry
    {
        // Fields
        private readonly System.String Value;  // 0x10
        private readonly System.Int32 HashCode;  // 0x18
        private Newtonsoft.Json.DefaultJsonNameTable.Entry Next;  // 0x20

        // Methods
        // RVA: 0x03020510  token: 0x600000F
        private System.Void .ctor(System.String value, System.Int32 hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next) { }

    }

    // TypeToken: 0x2000026  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.JsonReader.State Start;  // const
        public static Newtonsoft.Json.JsonReader.State Complete;  // const
        public static Newtonsoft.Json.JsonReader.State Property;  // const
        public static Newtonsoft.Json.JsonReader.State ObjectStart;  // const
        public static Newtonsoft.Json.JsonReader.State Object;  // const
        public static Newtonsoft.Json.JsonReader.State ArrayStart;  // const
        public static Newtonsoft.Json.JsonReader.State Array;  // const
        public static Newtonsoft.Json.JsonReader.State Closed;  // const
        public static Newtonsoft.Json.JsonReader.State PostValue;  // const
        public static Newtonsoft.Json.JsonReader.State ConstructorStart;  // const
        public static Newtonsoft.Json.JsonReader.State Constructor;  // const
        public static Newtonsoft.Json.JsonReader.State Error;  // const
        public static Newtonsoft.Json.JsonReader.State Finished;  // const

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.JsonWriter.State Start;  // const
        public static Newtonsoft.Json.JsonWriter.State Property;  // const
        public static Newtonsoft.Json.JsonWriter.State ObjectStart;  // const
        public static Newtonsoft.Json.JsonWriter.State Object;  // const
        public static Newtonsoft.Json.JsonWriter.State ArrayStart;  // const
        public static Newtonsoft.Json.JsonWriter.State Array;  // const
        public static Newtonsoft.Json.JsonWriter.State ConstructorStart;  // const
        public static Newtonsoft.Json.JsonWriter.State Constructor;  // const
        public static Newtonsoft.Json.JsonWriter.State Closed;  // const
        public static Newtonsoft.Json.JsonWriter.State Error;  // const

    }

    // TypeToken: 0x2000040
    public sealed class <>c__2`1
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.AotHelper.<>c__2<T> <>9;  // static @ 0x0
        public static System.Action <>9__2_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000209
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x600020A
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600020B
        private System.Void <EnsureList>b__2_0() { }

    }

    // TypeToken: 0x2000045
    public static class EmptyArrayContainer`1
    {
        // Fields
        public static readonly T[] Empty;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600022B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct ConvertResult
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult Success;  // const
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult CannotConvertNull;  // const
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult NotInstantiableType;  // const
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult NoValidConversion;  // const

    }

    // TypeToken: 0x200004D  // size: 0x18
    public sealed class <>c__DisplayClass8_0
    {
        // Fields
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600025F
        public System.Void .ctor() { }
        // RVA: 0x092C44B0  token: 0x6000260
        private System.Object <CreateCastConverter>b__0(System.Object o) { }

    }

    // TypeToken: 0x2000053
    public sealed struct DictionaryEnumerator`2 : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e;  // 0x0

        // Properties
        System.Collections.DictionaryEntry Entry { get; /* RVA: -1  // not resolved */ }
        System.Object Key { get; /* RVA: -1  // not resolved */ }
        System.Object Value { get; /* RVA: -1  // not resolved */ }
        System.Object Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002AB
        public System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }
        // RVA: -1  // not resolved  token: 0x60002B0
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60002B1
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000054
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey,TValue> <>9;  // static @ 0x0
        public static System.Func<System.Collections.DictionaryEntry,System.Collections.Generic.KeyValuePair<TKey,TValue>> <>9__29_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002B2
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x60002B3
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002B4
        private System.Collections.Generic.KeyValuePair<TKey,TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de) { }

    }

    // TypeToken: 0x2000057
    public sealed class Fallback : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x60002DC
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x60002DD
        public virtual System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000058
    public sealed class GetBinderAdapter : System.Dynamic.GetMemberBinder
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60002DE
        private System.Void .ctor(System.Dynamic.InvokeMemberBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002DF
        public virtual System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000059
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9;  // static @ 0x0
        public static System.Func<System.Dynamic.DynamicMetaObject,System.Linq.Expressions.Expression> <>9__18_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E0
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x60002E1
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002E2
        private System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg) { }

    }

    // TypeToken: 0x200005A
    public sealed class <>c__DisplayClass10_0
    {
        // Fields
        public System.Dynamic.BinaryOperationBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject arg;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E3
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002E4
        private System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x200005B
    public sealed class <>c__DisplayClass11_0
    {
        // Fields
        public System.Dynamic.UnaryOperationBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E5
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002E6
        private System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x200005C
    public sealed class <>c__DisplayClass12_0
    {
        // Fields
        public System.Dynamic.GetIndexBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] indexes;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E7
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002E8
        private System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x200005D
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public System.Dynamic.SetIndexBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] indexes;  // 0x0
        public System.Dynamic.DynamicMetaObject value;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E9
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002EA
        private System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x200005E
    public sealed class <>c__DisplayClass14_0
    {
        // Fields
        public System.Dynamic.DeleteIndexBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] indexes;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002EB
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002EC
        private System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x200005F
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Dynamic.GetMemberBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002ED
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002EE
        private System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000060
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.Dynamic.SetMemberBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject value;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002EF
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002F0
        private System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000061
    public sealed class <>c__DisplayClass5_0
    {
        // Fields
        public System.Dynamic.DeleteMemberBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002F1
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002F2
        private System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000062
    public sealed class <>c__DisplayClass6_0
    {
        // Fields
        public System.Dynamic.ConvertBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002F3
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002F4
        private System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000063
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public System.Dynamic.InvokeMemberBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] args;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002F5
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002F6
        private System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e) { }
        // RVA: -1  // not resolved  token: 0x60002F7
        private System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000064
    public sealed class <>c__DisplayClass8_0
    {
        // Fields
        public System.Dynamic.CreateInstanceBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] args;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002F8
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002F9
        private System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000065
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public System.Dynamic.InvokeBinder binder;  // 0x0
        public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;  // 0x0
        public System.Dynamic.DynamicMetaObject[] args;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002FA
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002FB
        private System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e) { }

    }

    // TypeToken: 0x2000067  // size: 0x10
    public static class BinderWrapper
    {
        // Fields
        private static System.Object _getCSharpArgumentInfoArray;  // static @ 0x0
        private static System.Object _setCSharpArgumentInfoArray;  // static @ 0x8
        private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _getMemberCall;  // static @ 0x10
        private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _setMemberCall;  // static @ 0x18
        private static System.Boolean _init;  // static @ 0x20

        // Methods
        // RVA: 0x092B92D4  token: 0x60002FD
        private static System.Void Init() { }
        // RVA: 0x092B8F38  token: 0x60002FE
        private static System.Object CreateSharpArgumentInfoArray(System.Int32[] values) { }
        // RVA: 0x092B8B6C  token: 0x60002FF
        private static System.Void CreateMemberCalls() { }
        // RVA: 0x092B9174  token: 0x6000300
        public static System.Runtime.CompilerServices.CallSiteBinder GetMember(System.String name, System.Type context) { }
        // RVA: 0x092B94D0  token: 0x6000301
        public static System.Runtime.CompilerServices.CallSiteBinder SetMember(System.String name, System.Type context) { }

    }

    // TypeToken: 0x200006D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.EnumUtils.<>c <>9;  // static @ 0x0
        public static System.Func<System.Runtime.Serialization.EnumMemberAttribute,System.String> <>9__3_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D187D0  token: 0x6000313
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000314
        public System.Void .ctor() { }
        // RVA: 0x059311D0  token: 0x6000315
        private System.String <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a) { }

    }

    // TypeToken: 0x2000070
    public sealed class <>c__55`2
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey,TValue> <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Tuple<TKey,TValue>> <>9__55_1;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000334
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000335
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000336
        private System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

    }

    // TypeToken: 0x2000071  // size: 0x20
    public sealed class <>c__DisplayClass52_0
    {
        // Fields
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call;  // 0x10
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000337
        public System.Void .ctor() { }
        // RVA: 0x092C4418  token: 0x6000338
        private System.Object <CreateFSharpFuncCall>b__0(System.Object target, System.Object[] args) { }

    }

    // TypeToken: 0x2000072
    public sealed class <>c__DisplayClass55_0`2
    {
        // Fields
        public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000339
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600033A
        private System.Object <BuildMapCreator>b__0(System.Object[] args) { }

    }

    // TypeToken: 0x2000074  // size: 0x28
    public class ImmutableCollectionTypeInfo
    {
        // Fields
        private System.String <ContractTypeName>k__BackingField;  // 0x10
        private System.String <CreatedTypeName>k__BackingField;  // 0x18
        private System.String <BuilderTypeName>k__BackingField;  // 0x20

        // Properties
        System.String ContractTypeName { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String CreatedTypeName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String BuilderTypeName { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0285BDC0  token: 0x600033E
        public System.Void .ctor(System.String contractTypeName, System.String createdTypeName, System.String builderTypeName) { }

    }

    // TypeToken: 0x2000075  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<>c <>9;  // static @ 0x0
        public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__24_1;  // static @ 0x8
        public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__25_1;  // static @ 0x10

        // Methods
        // RVA: 0x092C4544  token: 0x6000345
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000346
        public System.Void .ctor() { }
        // RVA: 0x092C4094  token: 0x6000347
        private System.Boolean <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m) { }
        // RVA: 0x092C4108  token: 0x6000348
        private System.Boolean <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m) { }

    }

    // TypeToken: 0x2000076  // size: 0x18
    public sealed class <>c__DisplayClass24_0
    {
        // Fields
        public System.String name;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000349
        public System.Void .ctor() { }
        // RVA: 0x03472150  token: 0x600034A
        private System.Boolean <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }

    }

    // TypeToken: 0x2000077  // size: 0x18
    public sealed class <>c__DisplayClass25_0
    {
        // Fields
        public System.String name;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600034B
        public System.Void .ctor() { }
        // RVA: 0x03472150  token: 0x600034C
        private System.Boolean <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }

    }

    // TypeToken: 0x200007C  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Reflection.ConstructorInfo c;  // 0x10
        public System.Reflection.MethodBase method;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000365
        public System.Void .ctor() { }
        // RVA: 0x029D5B10  token: 0x6000366
        private System.Object <CreateParameterizedConstructor>b__0(System.Object[] a) { }
        // RVA: 0x092C4318  token: 0x6000367
        private System.Object <CreateParameterizedConstructor>b__1(System.Object[] a) { }

    }

    // TypeToken: 0x200007D
    public sealed class <>c__DisplayClass4_0`1
    {
        // Fields
        public System.Reflection.ConstructorInfo c;  // 0x0
        public System.Reflection.MethodBase method;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000368
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000369
        private System.Object <CreateMethodCall>b__0(T o, System.Object[] a) { }
        // RVA: -1  // not resolved  token: 0x600036A
        private System.Object <CreateMethodCall>b__1(T o, System.Object[] a) { }

    }

    // TypeToken: 0x200007E
    public sealed class <>c__DisplayClass5_0`1
    {
        // Fields
        public System.Type type;  // 0x0
        public System.Reflection.ConstructorInfo constructorInfo;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600036B
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600036C
        private T <CreateDefaultConstructor>b__0() { }
        // RVA: -1  // not resolved  token: 0x600036D
        private T <CreateDefaultConstructor>b__1() { }

    }

    // TypeToken: 0x200007F
    public sealed class <>c__DisplayClass6_0`1
    {
        // Fields
        public System.Reflection.PropertyInfo propertyInfo;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600036E
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600036F
        private System.Object <CreateGet>b__0(T o) { }

    }

    // TypeToken: 0x2000080
    public sealed class <>c__DisplayClass7_0`1
    {
        // Fields
        public System.Reflection.FieldInfo fieldInfo;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000370
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000371
        private System.Object <CreateGet>b__0(T o) { }

    }

    // TypeToken: 0x2000081
    public sealed class <>c__DisplayClass8_0`1
    {
        // Fields
        public System.Reflection.FieldInfo fieldInfo;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000372
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000373
        private System.Void <CreateSet>b__0(T o, System.Object v) { }

    }

    // TypeToken: 0x2000082
    public sealed class <>c__DisplayClass9_0`1
    {
        // Fields
        public System.Reflection.PropertyInfo propertyInfo;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000374
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000375
        private System.Void <CreateSet>b__0(T o, System.Object v) { }

    }

    // TypeToken: 0x2000089  // size: 0x18
    public sealed class <>c__DisplayClass11_0
    {
        // Fields
        public System.Func<System.Object> ctor;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600039C
        public System.Void .ctor() { }
        // RVA: 0x08551BB0  token: 0x600039D
        private System.Object <Create>b__0(System.Object[] args) { }

    }

    // TypeToken: 0x200008A  // size: 0x18
    public sealed class <>c__DisplayClass11_1
    {
        // Fields
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600039E
        public System.Void .ctor() { }
        // RVA: 0x092C420C  token: 0x600039F
        private System.Object <Create>b__1(System.Object target) { }

    }

    // TypeToken: 0x200008B  // size: 0x18
    public sealed class <>c__DisplayClass11_2
    {
        // Fields
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003A0
        public System.Void .ctor() { }
        // RVA: 0x092C4274  token: 0x60003A1
        private System.Void <Create>b__2(System.Object target, System.Object arg) { }

    }

    // TypeToken: 0x200008D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Utilities.ReflectionUtils.<>c <>9;  // static @ 0x0
        public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__11_0;  // static @ 0x8
        public static System.Func<System.Reflection.MemberInfo,System.String> <>9__31_0;  // static @ 0x10
        public static System.Func<System.Reflection.ParameterInfo,System.Type> <>9__39_0;  // static @ 0x18
        public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__41_0;  // static @ 0x20

        // Methods
        // RVA: 0x03D19550  token: 0x60003D0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60003D1
        public System.Void .ctor() { }
        // RVA: 0x02479F50  token: 0x60003D2
        private System.Boolean <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c) { }
        // RVA: 0x03133E50  token: 0x60003D3
        private System.String <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m) { }
        // RVA: 0x059311B8  token: 0x60003D4
        private System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p) { }
        // RVA: 0x024788C0  token: 0x60003D5
        private System.Boolean <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f) { }

    }

    // TypeToken: 0x200008E  // size: 0x18
    public sealed class <>c__DisplayClass31_0
    {
        // Fields
        public System.Reflection.MemberInfo memberInfo;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003D6
        public System.Void .ctor() { }
        // RVA: 0x03B71DD0  token: 0x60003D7
        private System.Boolean <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m) { }

    }

    // TypeToken: 0x200008F  // size: 0x18
    public sealed class <>c__DisplayClass44_0
    {
        // Fields
        public System.Reflection.PropertyInfo subTypeProperty;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003D8
        public System.Void .ctor() { }
        // RVA: 0x03927260  token: 0x60003D9
        private System.Boolean <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p) { }
        // RVA: 0x02479A20  token: 0x60003DA
        private System.Boolean <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p) { }

    }

    // TypeToken: 0x2000090  // size: 0x20
    public sealed class <>c__DisplayClass44_1
    {
        // Fields
        public System.Type subTypePropertyDeclaringType;  // 0x10
        public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60003DB
        public System.Void .ctor() { }
        // RVA: 0x024798A0  token: 0x60003DC
        private System.Boolean <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p) { }

    }

    // TypeToken: 0x2000091  // size: 0x20
    public sealed class <>c__DisplayClass45_0
    {
        // Fields
        public System.String method;  // 0x10
        public System.Type methodDeclaringType;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60003DD
        public System.Void .ctor() { }
        // RVA: 0x092C433C  token: 0x60003DE
        private System.Boolean <IsMethodOverridden>b__0(System.Reflection.MethodInfo info) { }

    }

    // TypeToken: 0x2000096  // size: 0x14
    public sealed struct SeparatedCaseState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Start;  // const
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Lower;  // const
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Upper;  // const
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState NewWord;  // const

    }

    // TypeToken: 0x2000097
    public sealed class <>c__DisplayClass14_0`1
    {
        // Fields
        public System.Func<TSource,System.String> valueSelector;  // 0x0
        public System.String testValue;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000408
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000409
        private System.Boolean <ForgivingCaseSensitiveFind>b__0(TSource s) { }
        // RVA: -1  // not resolved  token: 0x600040A
        private System.Boolean <ForgivingCaseSensitiveFind>b__1(TSource s) { }

    }

    // TypeToken: 0x20000A0
    public sealed class <GetEnumerator>d__2 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Collections.Generic.KeyValuePair<System.Object,System.Object> <>2__current;  // 0x0
        public Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey,TEnumeratorValue> <>4__this;  // 0x0
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> <>7__wrap1;  // 0x0

        // Properties
        System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000467
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x6000468
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000469
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600046A
        private System.Void <>m__Finally1() { }
        // RVA: -1  // not resolved  token: 0x600046C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200009F
    public class EnumerableDictionaryWrapper`2 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000464
        public System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }
        // RVA: -1  // not resolved  token: 0x6000465
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000466
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20000A1  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Serialization.DefaultContractResolver.<>c <>9;  // static @ 0x0
        public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__40_0;  // static @ 0x8
        public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__40_1;  // static @ 0x10
        public static System.Func<System.Type,System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>> <>9__44_0;  // static @ 0x18
        public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__44_1;  // static @ 0x20
        public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__47_0;  // static @ 0x28
        public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.Int32> <>9__75_0;  // static @ 0x30

        // Methods
        // RVA: 0x03D0FBF0  token: 0x600046E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600046F
        public System.Void .ctor() { }
        // RVA: 0x02479D50  token: 0x6000470
        private System.Boolean <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m) { }
        // RVA: 0x092CD60C  token: 0x6000471
        private System.Boolean <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m) { }
        // RVA: 0x02477D90  token: 0x6000472
        private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType) { }
        // RVA: 0x02479B30  token: 0x6000473
        private System.Boolean <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m) { }
        // RVA: 0x02478910  token: 0x6000474
        private System.Boolean <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c) { }
        // RVA: 0x031913D0  token: 0x6000475
        private System.Int32 <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p) { }

    }

    // TypeToken: 0x20000A2  // size: 0x18
    public sealed class <>c__DisplayClass42_0
    {
        // Fields
        public Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000476
        public System.Void .ctor() { }
        // RVA: 0x092CD688  token: 0x6000477
        private System.String <CreateObjectContract>b__0(System.String s) { }

    }

    // TypeToken: 0x20000A3  // size: 0x20
    public sealed class <>c__DisplayClass45_0
    {
        // Fields
        public System.Func<System.Object,System.Object> getExtensionDataDictionary;  // 0x10
        public System.Reflection.MemberInfo member;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000478
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4  // size: 0x30
    public sealed class <>c__DisplayClass45_1
    {
        // Fields
        public System.Action<System.Object,System.Object> setExtensionDataDictionary;  // 0x10
        public System.Func<System.Object> createExtensionDataDictionary;  // 0x18
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> setExtensionDataDictionaryValue;  // 0x20
        public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals1;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000479
        public System.Void .ctor() { }
        // RVA: 0x092CD6A8  token: 0x600047A
        private System.Void <SetExtensionDataDelegates>b__0(System.Object o, System.String key, System.Object value) { }

    }

    // TypeToken: 0x20000A5  // size: 0x20
    public sealed class <>c__DisplayClass45_2
    {
        // Fields
        public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper;  // 0x10
        public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600047B
        public System.Void .ctor() { }
        // RVA: 0x092CD884  token: 0x600047C
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(System.Object o) { }

    }

    // TypeToken: 0x20000A6  // size: 0x18
    public sealed class <>c__DisplayClass62_0
    {
        // Fields
        public Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600047D
        public System.Void .ctor() { }
        // RVA: 0x092CD688  token: 0x600047E
        private System.String <CreateDictionaryContract>b__0(System.String s) { }

    }

    // TypeToken: 0x20000A7  // size: 0x18
    public sealed class <>c__DisplayClass67_0
    {
        // Fields
        public Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600047F
        public System.Void .ctor() { }
        // RVA: 0x092CD688  token: 0x6000480
        private System.String <CreateDynamicContract>b__0(System.String s) { }

    }

    // TypeToken: 0x20000A8  // size: 0x18
    public sealed class <>c__DisplayClass80_0
    {
        // Fields
        public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000481
        public System.Void .ctor() { }
        // RVA: 0x092CDA50  token: 0x6000482
        private System.Boolean <CreateShouldSerializeTest>b__0(System.Object o) { }

    }

    // TypeToken: 0x20000A9  // size: 0x18
    public sealed class <>c__DisplayClass81_0
    {
        // Fields
        public System.Func<System.Object,System.Object> specifiedPropertyGet;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000483
        public System.Void .ctor() { }
        // RVA: 0x092CDAD4  token: 0x6000484
        private System.Boolean <SetIsSpecifiedActions>b__0(System.Object o) { }

    }

    // TypeToken: 0x20000BD  // size: 0x18
    public sealed class <>c__DisplayClass57_0
    {
        // Fields
        public System.Reflection.MethodInfo callbackMethodInfo;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60004E3
        public System.Void .ctor() { }
        // RVA: 0x0312B410  token: 0x60004E4
        private System.Void <CreateSerializationCallback>b__0(System.Object o, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x20000BE  // size: 0x18
    public sealed class <>c__DisplayClass58_0
    {
        // Fields
        public System.Reflection.MethodInfo callbackMethodInfo;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60004E5
        public System.Void .ctor() { }
        // RVA: 0x092CD95C  token: 0x60004E6
        private System.Void <CreateSerializationErrorCallback>b__0(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext) { }

    }

    // TypeToken: 0x20000C9  // size: 0x10
    public class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer`1
    {
        // Methods
        // RVA: 0x06DDEAAC  token: 0x600056E
        private virtual System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y) { }
        // RVA: 0x03D6E640  token: 0x600056F
        private virtual System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj) { }
        // RVA: 0x0350B670  token: 0x6000570
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB  // size: 0x14
    public sealed struct PropertyPresence
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence None;  // const
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence Null;  // const
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence Value;  // const

    }

    // TypeToken: 0x20000CC  // size: 0x40
    public class CreatorPropertyContext
    {
        // Fields
        public readonly System.String Name;  // 0x10
        public Newtonsoft.Json.Serialization.JsonProperty Property;  // 0x18
        public Newtonsoft.Json.Serialization.JsonProperty ConstructorProperty;  // 0x20
        public System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> Presence;  // 0x28
        public System.Object Value;  // 0x30
        public System.Boolean Used;  // 0x38

        // Methods
        // RVA: 0x0426FEE0  token: 0x60005A1
        public System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20000CD  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<>c <>9;  // static @ 0x0
        public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_0;  // static @ 0x8
        public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_2;  // static @ 0x10
        public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;  // static @ 0x18
        public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;  // static @ 0x20

        // Methods
        // RVA: 0x03D0D5B0  token: 0x60005A2
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005A3
        public System.Void .ctor() { }
        // RVA: 0x092CD5F4  token: 0x60005A4
        private System.String <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p) { }
        // RVA: 0x092CD5F4  token: 0x60005A5
        private System.String <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p) { }
        // RVA: 0x03D51810  token: 0x60005A6
        private Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m) { }
        // RVA: 0x01002730  token: 0x60005A7
        private Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m) { }

    }

    // TypeToken: 0x20000CE  // size: 0x18
    public sealed class <>c__DisplayClass38_0
    {
        // Fields
        public Newtonsoft.Json.Serialization.JsonProperty property;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60005A8
        public System.Void .ctor() { }
        // RVA: 0x092CD668  token: 0x60005A9
        private System.Boolean <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p) { }

    }

    // TypeToken: 0x20000D3  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Serialization.JsonTypeReflector.<>c <>9;  // static @ 0x0
        public static System.Func<System.Object,System.Type> <>9__22_1;  // static @ 0x8

        // Methods
        // RVA: 0x092DF40C  token: 0x600060A
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600060B
        public System.Void .ctor() { }
        // RVA: 0x092DEF38  token: 0x600060C
        private System.Type <GetCreator>b__22_1(System.Object param) { }

    }

    // TypeToken: 0x20000D4  // size: 0x20
    public sealed class <>c__DisplayClass22_0
    {
        // Fields
        public System.Type type;  // 0x10
        public System.Func<System.Object> defaultConstructor;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600060D
        public System.Void .ctor() { }
        // RVA: 0x092DEFC4  token: 0x600060E
        private System.Object <GetCreator>b__0(System.Object[] parameters) { }

    }

    // TypeToken: 0x20000E7  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<>c <>9;  // static @ 0x0
        public static System.Func<Newtonsoft.Json.Linq.JProperty,System.String> <>9__2_0;  // static @ 0x8

        // Methods
        // RVA: 0x092DF3A8  token: 0x6000710
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000711
        public System.Void .ctor() { }
        // RVA: 0x092DEFAC  token: 0x6000712
        private System.String <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p) { }

    }

    // TypeToken: 0x20000E6  // size: 0x10
    public class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy`1
    {
        // Methods
        // RVA: 0x092D0B1C  token: 0x600070C
        public virtual System.Boolean TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, System.Object& result) { }
        // RVA: 0x092D0B5C  token: 0x600070D
        public virtual System.Boolean TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, System.Object value) { }
        // RVA: 0x092D09FC  token: 0x600070E
        public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance) { }
        // RVA: 0x092D0C14  token: 0x600070F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8  // size: 0x38
    public sealed class <GetEnumerator>d__64 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> <>2__current;  // 0x18
        public Newtonsoft.Json.Linq.JObject <>4__this;  // 0x28
        private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;  // 0x30

        // Properties
        System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; /* RVA: 0x03D51D80 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x092DEE30 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000713
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x092DEE78  token: 0x6000714
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x092DEAC8  token: 0x6000715
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092DEEF0  token: 0x6000716
        private System.Void <>m__Finally1() { }
        // RVA: 0x092DEDE4  token: 0x6000718
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000EB  // size: 0x28
    public sealed class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private Newtonsoft.Json.Linq.JToken <>2__current;  // 0x18
        public Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;  // 0x20

        // Properties
        Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600073C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600073D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x092DEA24  token: 0x600073E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092DEA7C  token: 0x6000740
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000EA  // size: 0x18
    public class JPropertyList : System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private Newtonsoft.Json.Linq.JToken _token;  // 0x10

        // Properties
        System.Int32 Count { get; /* RVA: 0x03676D20 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x03B5B050 */ set; /* RVA: 0x03D4B920 */ }

        // Methods
        // RVA: 0x092D218C  token: 0x600072D
        public virtual System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }
        // RVA: 0x092D2238  token: 0x600072E
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x0426FEE0  token: 0x600072F
        public virtual System.Void Add(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x035ACAA0  token: 0x6000730
        public virtual System.Void Clear() { }
        // RVA: 0x092D211C  token: 0x6000731
        public virtual System.Boolean Contains(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D2124  token: 0x6000732
        public virtual System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        // RVA: 0x092D2210  token: 0x6000733
        public virtual System.Boolean Remove(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D21E8  token: 0x6000736
        public virtual System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x0381BD20  token: 0x6000737
        public virtual System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D21F8  token: 0x6000738
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: 0x0350B670  token: 0x600073B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2  // size: 0x18
    public class LineInfoAnnotation
    {
        // Fields
        private readonly System.Int32 LineNumber;  // 0x10
        private readonly System.Int32 LinePosition;  // 0x14

        // Methods
        // RVA: 0x03D50CB0  token: 0x60007BD
        public System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x20000F7  // size: 0x10
    public class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy`1
    {
        // Methods
        // RVA: 0x092D99A4  token: 0x6000829
        public virtual System.Boolean TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, System.Object& result) { }
        // RVA: 0x092D96F8  token: 0x600082A
        public virtual System.Boolean TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result) { }
        // RVA: 0x092D9B20  token: 0x600082B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000100  // size: 0x20
    public class Union
    {
        // Fields
        public readonly Newtonsoft.Json.Utilities.FSharpFunction TagReader;  // 0x10
        public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;  // 0x18

        // Methods
        // RVA: 0x02676770  token: 0x6000850
        public System.Void .ctor(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases) { }

    }

    // TypeToken: 0x2000101  // size: 0x38
    public class UnionCase
    {
        // Fields
        public readonly System.Int32 Tag;  // 0x10
        public readonly System.String Name;  // 0x18
        public readonly System.Reflection.PropertyInfo[] Fields;  // 0x20
        public readonly Newtonsoft.Json.Utilities.FSharpFunction FieldReader;  // 0x28
        public readonly Newtonsoft.Json.Utilities.FSharpFunction Constructor;  // 0x30

        // Methods
        // RVA: 0x092E5FE0  token: 0x6000851
        public System.Void .ctor(System.Int32 tag, System.String name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor) { }

    }

    // TypeToken: 0x2000102  // size: 0x18
    public sealed class <>c__DisplayClass8_0
    {
        // Fields
        public System.Int32 tag;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000852
        public System.Void .ctor() { }
        // RVA: 0x059517DC  token: 0x6000853
        private System.Boolean <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c) { }

    }

    // TypeToken: 0x2000103  // size: 0x20
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public System.String caseName;  // 0x10
        public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000854
        public System.Void .ctor() { }
        // RVA: 0x092E5FB8  token: 0x6000855
        private System.Boolean <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c) { }

    }

    // TypeToken: 0x200012D  // size: 0x1A
    public sealed struct __StaticArrayInitTypeSize=10
    {
    }

    // TypeToken: 0x200012E  // size: 0x20
    public sealed struct __StaticArrayInitTypeSize=16
    {
    }

    // TypeToken: 0x200012F  // size: 0x24
    public sealed struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x2000130  // size: 0x28
    public sealed struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x2000131  // size: 0x2C
    public sealed struct __StaticArrayInitTypeSize=28
    {
    }

    // TypeToken: 0x2000132  // size: 0x34
    public sealed struct __StaticArrayInitTypeSize=36
    {
    }

    // TypeToken: 0x2000133  // size: 0x38
    public sealed struct __StaticArrayInitTypeSize=40
    {
    }

    // TypeToken: 0x2000134  // size: 0x3C
    public sealed struct __StaticArrayInitTypeSize=44
    {
    }

    // TypeToken: 0x2000135  // size: 0x44
    public sealed struct __StaticArrayInitTypeSize=52
    {
    }

    // TypeToken: 0x200012C  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 0698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139;  // static @ 0x0
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 19AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994;  // static @ 0x2c
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570;  // static @ 0x36
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 33350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE;  // static @ 0x5e
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 38809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63;  // static @ 0x72
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6;  // static @ 0x9a
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 4EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF;  // static @ 0xb6
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA;  // static @ 0xc6
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 5ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2;  // static @ 0xfa
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 5DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9;  // static @ 0x116
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04;  // static @ 0x12e
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62;  // static @ 0x13e
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1;  // static @ 0x162
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5;  // static @ 0x18a
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89;  // static @ 0x1b2
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122;  // static @ 0x1c2
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326;  // static @ 0x1d6
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A;  // static @ 0x1ea
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7;  // static @ 0x212
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;  // static @ 0x23a
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A;  // static @ 0x26e

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

namespace Newtonsoft.Json
{

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct ConstructorHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.ConstructorHandling Default;  // const
        public static Newtonsoft.Json.ConstructorHandling AllowNonPublicDefaultConstructor;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct DateFormatHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.DateFormatHandling IsoDateFormat;  // const
        public static Newtonsoft.Json.DateFormatHandling MicrosoftDateFormat;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct DateParseHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.DateParseHandling None;  // const
        public static Newtonsoft.Json.DateParseHandling DateTime;  // const
        public static Newtonsoft.Json.DateParseHandling DateTimeOffset;  // const

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct DateTimeZoneHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.DateTimeZoneHandling Local;  // const
        public static Newtonsoft.Json.DateTimeZoneHandling Utc;  // const
        public static Newtonsoft.Json.DateTimeZoneHandling Unspecified;  // const
        public static Newtonsoft.Json.DateTimeZoneHandling RoundtripKind;  // const

    }

    // TypeToken: 0x200000C  // size: 0x28
    public class DefaultJsonNameTable : Newtonsoft.Json.JsonNameTable
    {
        // Fields
        private static readonly System.Int32 HashCodeRandomizer;  // static @ 0x0
        private System.Int32 _count;  // 0x10
        private Newtonsoft.Json.DefaultJsonNameTable.Entry[] _entries;  // 0x18
        private System.Int32 _mask;  // 0x20

        // Methods
        // RVA: 0x03D41660  token: 0x6000008
        private static System.Void .cctor() { }
        // RVA: 0x03702F40  token: 0x6000009
        public System.Void .ctor() { }
        // RVA: 0x0236C9E0  token: 0x600000A
        public virtual System.String Get(System.Char[] key, System.Int32 start, System.Int32 length) { }
        // RVA: 0x024E67F0  token: 0x600000B
        public System.String Add(System.String key) { }
        // RVA: 0x03020400  token: 0x600000C
        private System.String AddEntry(System.String str, System.Int32 hashCode) { }
        // RVA: 0x03020540  token: 0x600000D
        private System.Void Grow() { }
        // RVA: 0x0236C960  token: 0x600000E
        private static System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length) { }

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct DefaultValueHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.DefaultValueHandling Include;  // const
        public static Newtonsoft.Json.DefaultValueHandling Ignore;  // const
        public static Newtonsoft.Json.DefaultValueHandling Populate;  // const
        public static Newtonsoft.Json.DefaultValueHandling IgnoreAndPopulate;  // const

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct FloatFormatHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.FloatFormatHandling String;  // const
        public static Newtonsoft.Json.FloatFormatHandling Symbol;  // const
        public static Newtonsoft.Json.FloatFormatHandling DefaultValue;  // const

    }

    // TypeToken: 0x2000010  // size: 0x14
    public sealed struct FloatParseHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.FloatParseHandling Double;  // const
        public static Newtonsoft.Json.FloatParseHandling Decimal;  // const

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct Formatting
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Formatting None;  // const
        public static Newtonsoft.Json.Formatting Indented;  // const

    }

    // TypeToken: 0x2000012
    public interface IArrayPool`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000010
        public virtual T[] Rent(System.Int32 minimumLength) { }
        // RVA: -1  // abstract  token: 0x6000011
        public virtual System.Void Return(T[] array) { }

    }

    // TypeToken: 0x2000013
    public interface IJsonLineInfo
    {
        // Properties
        System.Int32 LineNumber { get; /* RVA: -1  // abstract */ }
        System.Int32 LinePosition { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000012
        public virtual System.Boolean HasLineInfo() { }

    }

    // TypeToken: 0x2000014  // size: 0x50
    public sealed class JsonArrayAttribute : Newtonsoft.Json.JsonContainerAttribute
    {
    }

    // TypeToken: 0x2000015  // size: 0x10
    public sealed class JsonConstructorAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000015
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x50
    public abstract class JsonContainerAttribute : System.Attribute
    {
        // Fields
        private System.Type <ItemConverterType>k__BackingField;  // 0x10
        private System.Object[] <ItemConverterParameters>k__BackingField;  // 0x18
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategyInstance>k__BackingField;  // 0x20
        private System.Nullable<System.Boolean> _isReference;  // 0x28
        private System.Nullable<System.Boolean> _itemIsReference;  // 0x2a
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;  // 0x2c
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;  // 0x34
        private System.Type _namingStrategyType;  // 0x40
        private System.Object[] _namingStrategyParameters;  // 0x48

        // Properties
        System.Type ItemConverterType { get; /* RVA: 0x020B7B20 */ }
        System.Object[] ItemConverterParameters { get; /* RVA: 0x01041090 */ }
        System.Type NamingStrategyType { get; /* RVA: 0x03D4E2B0 */ }
        System.Object[] NamingStrategyParameters { get; /* RVA: 0x03D4EA70 */ }
        Newtonsoft.Json.Serialization.NamingStrategy NamingStrategyInstance { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

    }

    // TypeToken: 0x2000017  // size: 0x10
    public static class JsonConvert
    {
        // Fields
        private static System.Func<Newtonsoft.Json.JsonSerializerSettings> <DefaultSettings>k__BackingField;  // static @ 0x0
        public static readonly System.String True;  // static @ 0x8
        public static readonly System.String False;  // static @ 0x10
        public static readonly System.String Null;  // static @ 0x18
        public static readonly System.String Undefined;  // static @ 0x20
        public static readonly System.String PositiveInfinity;  // static @ 0x28
        public static readonly System.String NegativeInfinity;  // static @ 0x30
        public static readonly System.String NaN;  // static @ 0x38

        // Properties
        System.Func<Newtonsoft.Json.JsonSerializerSettings> DefaultSettings { get; /* RVA: 0x092B06F8 */ }

        // Methods
        // RVA: 0x02905B90  token: 0x600001D
        public static System.String ToString(System.Boolean value) { }
        // RVA: 0x092B0350  token: 0x600001E
        public static System.String ToString(System.Char value) { }
        // RVA: 0x092B0538  token: 0x600001F
        private static System.String ToString(System.Single value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        // RVA: 0x092AFEFC  token: 0x6000020
        private static System.String EnsureFloatFormat(System.Double value, System.String text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        // RVA: 0x092B061C  token: 0x6000021
        private static System.String ToString(System.Double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        // RVA: 0x092AFDF8  token: 0x6000022
        private static System.String EnsureDecimalPlace(System.Double value, System.String text) { }
        // RVA: 0x092AFEA0  token: 0x6000023
        private static System.String EnsureDecimalPlace(System.String text) { }
        // RVA: 0x092B02B8  token: 0x6000024
        public static System.String ToString(System.Decimal value) { }
        // RVA: 0x092B04E8  token: 0x6000025
        public static System.String ToString(System.String value) { }
        // RVA: 0x092B0494  token: 0x6000026
        public static System.String ToString(System.String value, System.Char delimiter) { }
        // RVA: 0x092B03B8  token: 0x6000027
        public static System.String ToString(System.String value, System.Char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        // RVA: 0x02696450  token: 0x6000028
        public static System.String SerializeObject(System.Object value) { }
        // RVA: 0x092B0210  token: 0x6000029
        public static System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting) { }
        // RVA: 0x092B0264  token: 0x600002A
        public static System.String SerializeObject(System.Object value, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x026963D0  token: 0x600002B
        public static System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x035A1D80  token: 0x600002C
        public static System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x035A1E00  token: 0x600002D
        public static System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x02696B20  token: 0x600002E
        private static System.String SerializeObjectInternal(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        // RVA: 0x03C8F4B0  token: 0x600002F
        public static System.Object DeserializeObject(System.String value) { }
        // RVA: 0x02694430  token: 0x6000030
        public static System.Object DeserializeObject(System.String value, System.Type type) { }
        // RVA: -1  // generic def  token: 0x6000031
        public static T DeserializeObject(System.String value) { }
        // RVA: -1  // generic def  token: 0x6000032
        public static T DeserializeObject(System.String value, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x02695B30  token: 0x6000033
        public static System.Object DeserializeObject(System.String value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x092AFFF0  token: 0x6000034
        public static System.Void PopulateObject(System.String value, System.Object target, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x03A2D920  token: 0x6000035
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x10
    public abstract class JsonConverter
    {
        // Properties
        System.Boolean CanRead { get; /* RVA: 0x0232EB60 */ }
        System.Boolean CanWrite { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000036
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // abstract  token: 0x6000037
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // abstract  token: 0x6000038
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x600003B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public abstract class JsonConverter`1 : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600003C
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // abstract  token: 0x600003D
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // not resolved  token: 0x600003E
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // abstract  token: 0x600003F
        public virtual T ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, T existingValue, System.Boolean hasExistingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // not resolved  token: 0x6000040
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: -1  // not resolved  token: 0x6000041
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x20
    public sealed class JsonConverterAttribute : System.Attribute
    {
        // Fields
        private readonly System.Type _converterType;  // 0x10
        private readonly System.Object[] <ConverterParameters>k__BackingField;  // 0x18

        // Properties
        System.Type ConverterType { get; /* RVA: 0x020B7B20 */ }
        System.Object[] ConverterParameters { get; /* RVA: 0x01041090 */ }

    }

    // TypeToken: 0x200001B  // size: 0x18
    public class JsonConverterCollection : System.Collections.ObjectModel.Collection`1
    {
        // Methods
        // RVA: 0x03043740  token: 0x6000044
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x50
    public sealed class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
    {
    }

    // TypeToken: 0x200001D  // size: 0x90
    public class JsonException : System.Exception
    {
        // Methods
        // RVA: 0x092B0748  token: 0x6000045
        public System.Void .ctor() { }
        // RVA: 0x092B0794  token: 0x6000046
        public System.Void .ctor(System.String message) { }
        // RVA: 0x092B07F0  token: 0x6000047
        public System.Void .ctor(System.String message, System.Exception innerException) { }
        // RVA: 0x092B0850  token: 0x6000048
        public System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x200001E  // size: 0x18
    public class JsonExtensionDataAttribute : System.Attribute
    {
        // Fields
        private System.Boolean <WriteData>k__BackingField;  // 0x10
        private System.Boolean <ReadData>k__BackingField;  // 0x11

        // Properties
        System.Boolean WriteData { get; /* RVA: 0x011797F0 */ }
        System.Boolean ReadData { get; /* RVA: 0x03D510E0 */ }

    }

    // TypeToken: 0x200001F  // size: 0x10
    public sealed class JsonIgnoreAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600004B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public abstract class JsonNameTable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600004C
        public virtual System.String Get(System.Char[] key, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0350B670  token: 0x600004D
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000021  // size: 0x70
    public sealed class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
    {
        // Fields
        private Newtonsoft.Json.MemberSerialization _memberSerialization;  // 0x50
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;  // 0x54
        private System.Nullable<Newtonsoft.Json.Required> _itemRequired;  // 0x5c
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;  // 0x64

        // Properties
        Newtonsoft.Json.MemberSerialization MemberSerialization { get; /* RVA: 0x03D4EED0 */ }

    }

    // TypeToken: 0x2000022  // size: 0x14
    public sealed struct JsonContainerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.JsonContainerType None;  // const
        public static Newtonsoft.Json.JsonContainerType Object;  // const
        public static Newtonsoft.Json.JsonContainerType Array;  // const
        public static Newtonsoft.Json.JsonContainerType Constructor;  // const

    }

    // TypeToken: 0x2000023  // size: 0x28
    public sealed struct JsonPosition
    {
        // Fields
        private static readonly System.Char[] SpecialCharacters;  // static @ 0x0
        private Newtonsoft.Json.JsonContainerType Type;  // 0x10
        private System.Int32 Position;  // 0x14
        private System.String PropertyName;  // 0x18
        private System.Boolean HasIndex;  // 0x20

        // Methods
        // RVA: 0x02907480  token: 0x600004F
        public System.Void .ctor(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x092B0BF0  token: 0x6000050
        private System.Int32 CalculateLength() { }
        // RVA: 0x092B0E5C  token: 0x6000051
        private System.Void WriteTo(System.Text.StringBuilder sb, System.IO.StringWriter& writer, System.Char[]& buffer) { }
        // RVA: 0x02907530  token: 0x6000052
        private static System.Boolean TypeHasIndex(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x092B08BC  token: 0x6000053
        private static System.String BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }
        // RVA: 0x092B0C80  token: 0x6000054
        private static System.String FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message) { }
        // RVA: 0x03CE3DC0  token: 0x6000055
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x88
    public sealed class JsonPropertyAttribute : System.Attribute
    {
        // Fields
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;  // 0x10
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;  // 0x18
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;  // 0x20
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;  // 0x28
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;  // 0x30
        private System.Nullable<System.Boolean> _isReference;  // 0x38
        private System.Nullable<System.Int32> _order;  // 0x3c
        private System.Nullable<Newtonsoft.Json.Required> _required;  // 0x44
        private System.Nullable<System.Boolean> _itemIsReference;  // 0x4c
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;  // 0x50
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;  // 0x58
        private System.Type <ItemConverterType>k__BackingField;  // 0x60
        private System.Object[] <ItemConverterParameters>k__BackingField;  // 0x68
        private System.Type <NamingStrategyType>k__BackingField;  // 0x70
        private System.Object[] <NamingStrategyParameters>k__BackingField;  // 0x78
        private System.String <PropertyName>k__BackingField;  // 0x80

        // Properties
        System.Type ItemConverterType { get; /* RVA: 0x03D4EB00 */ }
        System.Object[] ItemConverterParameters { get; /* RVA: 0x03D4EAB0 */ }
        System.Type NamingStrategyType { get; /* RVA: 0x03D4EB30 */ }
        System.Object[] NamingStrategyParameters { get; /* RVA: 0x03D4EB20 */ }
        Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { set; /* RVA: 0x0381E590 */ }
        System.Int32 Order { set; /* RVA: 0x033DA250 */ }
        System.String PropertyName { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600005E
        public System.Void .ctor() { }
        // RVA: 0x051DFC94  token: 0x600005F
        public System.Void .ctor(System.String propertyName) { }

    }

    // TypeToken: 0x2000025  // size: 0x78
    public abstract class JsonReader : System.IDisposable
    {
        // Fields
        private Newtonsoft.Json.JsonToken _tokenType;  // 0x10
        private System.Object _value;  // 0x18
        private System.Char _quoteChar;  // 0x20
        private Newtonsoft.Json.JsonReader.State _currentState;  // 0x24
        private Newtonsoft.Json.JsonPosition _currentPosition;  // 0x28
        private System.Globalization.CultureInfo _culture;  // 0x40
        private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;  // 0x48
        private System.Nullable<System.Int32> _maxDepth;  // 0x4c
        private System.Boolean _hasExceededMaxDepth;  // 0x54
        private Newtonsoft.Json.DateParseHandling _dateParseHandling;  // 0x58
        private Newtonsoft.Json.FloatParseHandling _floatParseHandling;  // 0x5c
        private System.String _dateFormatString;  // 0x60
        private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;  // 0x68
        private System.Boolean <CloseInput>k__BackingField;  // 0x70
        private System.Boolean <SupportMultipleContent>k__BackingField;  // 0x71

        // Properties
        Newtonsoft.Json.JsonReader.State CurrentState { get; /* RVA: 0x03D4E2E0 */ }
        System.Boolean CloseInput { get; /* RVA: 0x03D4F260 */ set; /* RVA: 0x03D4F290 */ }
        System.Boolean SupportMultipleContent { get; /* RVA: 0x03D51CF0 */ set; /* RVA: 0x03D51D00 */ }
        Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x092B35E4 */ }
        Newtonsoft.Json.DateParseHandling DateParseHandling { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x092B357C */ }
        Newtonsoft.Json.FloatParseHandling FloatParseHandling { get; /* RVA: 0x03D4EEF0 */ set; /* RVA: 0x092B364C */ }
        System.String DateFormatString { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        System.Nullable<System.Int32> MaxDepth { get; /* RVA: 0x03D56700 */ set; /* RVA: 0x027BC040 */ }
        Newtonsoft.Json.JsonToken TokenType { get; /* RVA: 0x03D4E340 */ }
        System.Object Value { get; /* RVA: 0x01041090 */ }
        System.Type ValueType { get; /* RVA: 0x092B3558 */ }
        System.Int32 Depth { get; /* RVA: 0x0269A890 */ }
        System.String Path { get; /* RVA: 0x092B3464 */ }
        System.Globalization.CultureInfo Culture { get; /* RVA: 0x027BC3A0 */ set; /* RVA: 0x03CB2D80 */ }

        // Methods
        // RVA: 0x092B129C  token: 0x6000076
        private Newtonsoft.Json.JsonPosition GetPosition(System.Int32 depth) { }
        // RVA: 0x02696330  token: 0x6000077
        protected System.Void .ctor() { }
        // RVA: 0x02906EF0  token: 0x6000078
        private System.Void Push(Newtonsoft.Json.JsonContainerType value) { }
        // RVA: 0x0247C880  token: 0x6000079
        private Newtonsoft.Json.JsonContainerType Pop() { }
        // RVA: 0x03D4EB90  token: 0x600007A
        private Newtonsoft.Json.JsonContainerType Peek() { }
        // RVA: -1  // abstract  token: 0x600007B
        public virtual System.Boolean Read() { }
        // RVA: 0x092B23F0  token: 0x600007C
        public virtual System.Nullable<System.Int32> ReadAsInt32() { }
        // RVA: 0x092B30CC  token: 0x600007D
        private System.Nullable<System.Int32> ReadInt32String(System.String s) { }
        // RVA: 0x03B23610  token: 0x600007E
        public virtual System.String ReadAsString() { }
        // RVA: 0x092B15C8  token: 0x600007F
        public virtual System.Byte[] ReadAsBytes() { }
        // RVA: 0x092B14F4  token: 0x6000080
        private System.Byte[] ReadArrayIntoByteArray() { }
        // RVA: 0x092B1340  token: 0x6000081
        private System.Boolean ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }
        // RVA: 0x092B214C  token: 0x6000082
        public virtual System.Nullable<System.Double> ReadAsDouble() { }
        // RVA: 0x092B2EEC  token: 0x6000083
        private System.Nullable<System.Double> ReadDoubleString(System.String s) { }
        // RVA: 0x03B23540  token: 0x6000084
        public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }
        // RVA: 0x092B277C  token: 0x6000085
        private System.Nullable<System.Boolean> ReadBooleanString(System.String s) { }
        // RVA: 0x092B1D74  token: 0x6000086
        public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }
        // RVA: 0x092B2CDC  token: 0x6000087
        private System.Nullable<System.Decimal> ReadDecimalString(System.String s) { }
        // RVA: 0x092B1B4C  token: 0x6000088
        public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }
        // RVA: 0x092B2AEC  token: 0x6000089
        private System.Nullable<System.DateTime> ReadDateTimeString(System.String s) { }
        // RVA: 0x092B1914  token: 0x600008A
        public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        // RVA: 0x092B28E4  token: 0x600008B
        private System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(System.String s) { }
        // RVA: 0x092B341C  token: 0x600008C
        private System.Void ReaderReadAndAssert() { }
        // RVA: 0x092B125C  token: 0x600008D
        private Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException() { }
        // RVA: 0x092B3238  token: 0x600008E
        private System.Void ReadIntoWrappedTypeObject() { }
        // RVA: 0x0269A0F0  token: 0x600008F
        public System.Void Skip() { }
        // RVA: 0x0426FA14  token: 0x6000090
        protected System.Void SetToken(Newtonsoft.Json.JsonToken newToken) { }
        // RVA: 0x042702E0  token: 0x6000091
        protected System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value) { }
        // RVA: 0x0247E340  token: 0x6000092
        protected System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value, System.Boolean updateIndex) { }
        // RVA: 0x0247E590  token: 0x6000093
        private System.Void SetPostValueState(System.Boolean updateIndex) { }
        // RVA: 0x0247E5D0  token: 0x6000094
        private System.Void UpdateScopeWithFinishedValue() { }
        // RVA: 0x0247C400  token: 0x6000095
        private System.Void ValidateEnd(Newtonsoft.Json.JsonToken endToken) { }
        // RVA: 0x0236AC80  token: 0x6000096
        protected System.Void SetStateBasedOnCurrent() { }
        // RVA: 0x032FF660  token: 0x6000097
        private System.Void SetFinished() { }
        // RVA: 0x0247C840  token: 0x6000098
        private Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x0289C760  token: 0x6000099
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0289C800  token: 0x600009A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x030AB570  token: 0x600009B
        public virtual System.Void Close() { }
        // RVA: 0x024E8B90  token: 0x600009C
        private System.Void ReadAndAssert() { }
        // RVA: 0x092B3078  token: 0x600009D
        private System.Void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter) { }
        // RVA: 0x024EC430  token: 0x600009E
        private System.Boolean ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter) { }
        // RVA: 0x024EC680  token: 0x600009F
        private System.Boolean ReadAndMoveToContent() { }
        // RVA: 0x024EC6D0  token: 0x60000A0
        private System.Boolean MoveToContent() { }
        // RVA: 0x03B236C0  token: 0x60000A1
        private Newtonsoft.Json.JsonToken GetContentToken() { }

    }

    // TypeToken: 0x2000027  // size: 0xA0
    public class JsonReaderException : Newtonsoft.Json.JsonException
    {
        // Fields
        private readonly System.Int32 <LineNumber>k__BackingField;  // 0x90
        private readonly System.Int32 <LinePosition>k__BackingField;  // 0x94
        private readonly System.String <Path>k__BackingField;  // 0x98

        // Methods
        // RVA: 0x092B11D4  token: 0x60000A2
        public System.Void .ctor() { }
        // RVA: 0x092B1254  token: 0x60000A3
        public System.Void .ctor(System.String message) { }
        // RVA: 0x092B1234  token: 0x60000A4
        public System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x092B11DC  token: 0x60000A5
        public System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException) { }
        // RVA: 0x092B11C8  token: 0x60000A6
        private static Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message) { }
        // RVA: 0x092B1138  token: 0x60000A7
        private static Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex) { }
        // RVA: 0x092B1048  token: 0x60000A8
        private static Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x2000028  // size: 0x10
    public sealed class JsonRequiredAttribute : System.Attribute
    {
    }

    // TypeToken: 0x2000029  // size: 0xA0
    public class JsonSerializationException : Newtonsoft.Json.JsonException
    {
        // Fields
        private readonly System.Int32 <LineNumber>k__BackingField;  // 0x90
        private readonly System.Int32 <LinePosition>k__BackingField;  // 0x94
        private readonly System.String <Path>k__BackingField;  // 0x98

        // Methods
        // RVA: 0x092B11D4  token: 0x60000A9
        public System.Void .ctor() { }
        // RVA: 0x092B1254  token: 0x60000AA
        public System.Void .ctor(System.String message) { }
        // RVA: 0x092B3840  token: 0x60000AB
        public System.Void .ctor(System.String message, System.Exception innerException) { }
        // RVA: 0x092B1234  token: 0x60000AC
        public System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x092B11DC  token: 0x60000AD
        public System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException) { }
        // RVA: 0x092B36B4  token: 0x60000AE
        private static Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message) { }
        // RVA: 0x092B36C0  token: 0x60000AF
        private static Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex) { }
        // RVA: 0x092B3750  token: 0x60000B0
        private static Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x200002A  // size: 0xE0
    public class JsonSerializer
    {
        // Fields
        private Newtonsoft.Json.TypeNameHandling _typeNameHandling;  // 0x10
        private Newtonsoft.Json.TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;  // 0x14
        private Newtonsoft.Json.PreserveReferencesHandling _preserveReferencesHandling;  // 0x18
        private Newtonsoft.Json.ReferenceLoopHandling _referenceLoopHandling;  // 0x1c
        private Newtonsoft.Json.MissingMemberHandling _missingMemberHandling;  // 0x20
        private Newtonsoft.Json.ObjectCreationHandling _objectCreationHandling;  // 0x24
        private Newtonsoft.Json.NullValueHandling _nullValueHandling;  // 0x28
        private Newtonsoft.Json.DefaultValueHandling _defaultValueHandling;  // 0x2c
        private Newtonsoft.Json.ConstructorHandling _constructorHandling;  // 0x30
        private Newtonsoft.Json.MetadataPropertyHandling _metadataPropertyHandling;  // 0x34
        private Newtonsoft.Json.JsonConverterCollection _converters;  // 0x38
        private Newtonsoft.Json.Serialization.IContractResolver _contractResolver;  // 0x40
        private Newtonsoft.Json.Serialization.ITraceWriter _traceWriter;  // 0x48
        private System.Collections.IEqualityComparer _equalityComparer;  // 0x50
        private Newtonsoft.Json.Serialization.ISerializationBinder _serializationBinder;  // 0x58
        private System.Runtime.Serialization.StreamingContext _context;  // 0x60
        private Newtonsoft.Json.Serialization.IReferenceResolver _referenceResolver;  // 0x70
        private System.Nullable<Newtonsoft.Json.Formatting> _formatting;  // 0x78
        private System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;  // 0x80
        private System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;  // 0x88
        private System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;  // 0x90
        private System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;  // 0x98
        private System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;  // 0xa0
        private System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;  // 0xa8
        private System.Globalization.CultureInfo _culture;  // 0xb0
        private System.Nullable<System.Int32> _maxDepth;  // 0xb8
        private System.Boolean _maxDepthSet;  // 0xc0
        private System.Nullable<System.Boolean> _checkAdditionalContent;  // 0xc1
        private System.String _dateFormatString;  // 0xc8
        private System.Boolean _dateFormatStringSet;  // 0xd0
        private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;  // 0xd8

        // Properties
        Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { set; /* RVA: 0x092B4004 */ }
        Newtonsoft.Json.Serialization.ISerializationBinder SerializationBinder { set; /* RVA: 0x092B4090 */ }
        Newtonsoft.Json.Serialization.ITraceWriter TraceWriter { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.Collections.IEqualityComparer EqualityComparer { set; /* RVA: 0x02C926C0 */ }
        Newtonsoft.Json.TypeNameHandling TypeNameHandling { set; /* RVA: 0x033008C0 */ }
        Newtonsoft.Json.TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; /* RVA: 0x03D4B8E0 */ }
        Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { set; /* RVA: 0x092B3F9C */ }
        Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { set; /* RVA: 0x03D4B900 */ }
        Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { set; /* RVA: 0x092B3F34 */ }
        Newtonsoft.Json.NullValueHandling NullValueHandling { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03300DA0 */ }
        Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { set; /* RVA: 0x03300DC0 */ }
        Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { set; /* RVA: 0x03B45E20 */ }
        Newtonsoft.Json.ConstructorHandling ConstructorHandling { set; /* RVA: 0x03B45E40 */ }
        Newtonsoft.Json.MetadataPropertyHandling MetadataPropertyHandling { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x092B3ECC */ }
        Newtonsoft.Json.JsonConverterCollection Converters { get; /* RVA: 0x030436A0 */ }
        Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03B368B0 */ }
        System.Runtime.Serialization.StreamingContext Context { get; /* RVA: 0x03D5A130 */ set; /* RVA: 0x05A9EA30 */ }
        Newtonsoft.Json.Formatting Formatting { get; /* RVA: 0x03CF50D0 */ set; /* RVA: 0x03CF9A40 */ }
        System.Nullable<System.Int32> MaxDepth { get; /* RVA: 0x03D4E750 */ }
        System.Boolean CheckAdditionalContent { get; /* RVA: 0x03366F90 */ set; /* RVA: 0x0323E420 */ }

        // Events
        event System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;

        // Methods
        // RVA: 0x02696160  token: 0x60000CE
        private System.Boolean IsCheckAdditionalContentSet() { }
        // RVA: 0x02695FD0  token: 0x60000CF
        public System.Void .ctor() { }
        // RVA: 0x02695F70  token: 0x60000D0
        public static Newtonsoft.Json.JsonSerializer Create() { }
        // RVA: 0x02695EE0  token: 0x60000D1
        public static Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x02695E50  token: 0x60000D2
        public static Newtonsoft.Json.JsonSerializer CreateDefault() { }
        // RVA: 0x02695E10  token: 0x60000D3
        public static Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x024B38D0  token: 0x60000D4
        private static System.Void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings) { }
        // RVA: 0x092B3D60  token: 0x60000D5
        public System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        // RVA: 0x092B3ACC  token: 0x60000D6
        private virtual System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        // RVA: -1  // generic def  token: 0x60000D7
        public T Deserialize(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x04271114  token: 0x60000D8
        public System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        // RVA: 0x027BC5C0  token: 0x60000D9
        private virtual System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        // RVA: 0x027BC0B0  token: 0x60000DA
        private System.Void SetupReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo& previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, System.String& previousDateFormatString) { }
        // RVA: 0x027BC400  token: 0x60000DB
        private System.Void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, System.String previousDateFormatString) { }
        // RVA: 0x04271160  token: 0x60000DC
        public System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        // RVA: 0x042710E8  token: 0x60000DD
        public System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value) { }
        // RVA: 0x092B39D0  token: 0x60000DE
        private Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x031637E0  token: 0x60000DF
        private virtual System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        // RVA: 0x092B3A50  token: 0x60000E0
        private Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver() { }
        // RVA: 0x042702D4  token: 0x60000E1
        private Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type) { }
        // RVA: 0x02415890  token: 0x60000E2
        private static Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType) { }
        // RVA: 0x092B3AAC  token: 0x60000E3
        private System.Void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e) { }

    }

    // TypeToken: 0x200002B  // size: 0x110
    public class JsonSerializerSettings
    {
        // Fields
        private static Newtonsoft.Json.ReferenceLoopHandling DefaultReferenceLoopHandling;  // const
        private static Newtonsoft.Json.MissingMemberHandling DefaultMissingMemberHandling;  // const
        private static Newtonsoft.Json.NullValueHandling DefaultNullValueHandling;  // const
        private static Newtonsoft.Json.DefaultValueHandling DefaultDefaultValueHandling;  // const
        private static Newtonsoft.Json.ObjectCreationHandling DefaultObjectCreationHandling;  // const
        private static Newtonsoft.Json.PreserveReferencesHandling DefaultPreserveReferencesHandling;  // const
        private static Newtonsoft.Json.ConstructorHandling DefaultConstructorHandling;  // const
        private static Newtonsoft.Json.TypeNameHandling DefaultTypeNameHandling;  // const
        private static Newtonsoft.Json.MetadataPropertyHandling DefaultMetadataPropertyHandling;  // const
        private static readonly System.Runtime.Serialization.StreamingContext DefaultContext;  // static @ 0x0
        private static Newtonsoft.Json.Formatting DefaultFormatting;  // const
        private static Newtonsoft.Json.DateFormatHandling DefaultDateFormatHandling;  // const
        private static Newtonsoft.Json.DateTimeZoneHandling DefaultDateTimeZoneHandling;  // const
        private static Newtonsoft.Json.DateParseHandling DefaultDateParseHandling;  // const
        private static Newtonsoft.Json.FloatParseHandling DefaultFloatParseHandling;  // const
        private static Newtonsoft.Json.FloatFormatHandling DefaultFloatFormatHandling;  // const
        private static Newtonsoft.Json.StringEscapeHandling DefaultStringEscapeHandling;  // const
        private static Newtonsoft.Json.TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling;  // const
        private static readonly System.Globalization.CultureInfo DefaultCulture;  // static @ 0x10
        private static System.Boolean DefaultCheckAdditionalContent;  // const
        private static System.String DefaultDateFormatString;  // const
        private static System.Int32 DefaultMaxDepth;  // const
        private System.Nullable<Newtonsoft.Json.Formatting> _formatting;  // 0x10
        private System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;  // 0x18
        private System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;  // 0x20
        private System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;  // 0x28
        private System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;  // 0x30
        private System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;  // 0x38
        private System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;  // 0x40
        private System.Globalization.CultureInfo _culture;  // 0x48
        private System.Nullable<System.Boolean> _checkAdditionalContent;  // 0x50
        private System.Nullable<System.Int32> _maxDepth;  // 0x54
        private System.Boolean _maxDepthSet;  // 0x5c
        private System.String _dateFormatString;  // 0x60
        private System.Boolean _dateFormatStringSet;  // 0x68
        private System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling;  // 0x6c
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;  // 0x74
        private System.Nullable<Newtonsoft.Json.PreserveReferencesHandling> _preserveReferencesHandling;  // 0x7c
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;  // 0x84
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;  // 0x8c
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;  // 0x94
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;  // 0x9c
        private System.Nullable<System.Runtime.Serialization.StreamingContext> _context;  // 0xa8
        private System.Nullable<Newtonsoft.Json.ConstructorHandling> _constructorHandling;  // 0xc0
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;  // 0xc8
        private System.Nullable<Newtonsoft.Json.MetadataPropertyHandling> _metadataPropertyHandling;  // 0xd0
        private System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField;  // 0xd8
        private Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField;  // 0xe0
        private System.Collections.IEqualityComparer <EqualityComparer>k__BackingField;  // 0xe8
        private System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField;  // 0xf0
        private Newtonsoft.Json.Serialization.ITraceWriter <TraceWriter>k__BackingField;  // 0xf8
        private Newtonsoft.Json.Serialization.ISerializationBinder <SerializationBinder>k__BackingField;  // 0x100
        private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField;  // 0x108

        // Properties
        Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get; /* RVA: 0x03D46F50 */ set; /* RVA: 0x03D29B60 */ }
        Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { get; /* RVA: 0x092B3958 */ }
        Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get; /* RVA: 0x03C90470 */ set; /* RVA: 0x03D29BC0 */ }
        Newtonsoft.Json.NullValueHandling NullValueHandling { get; /* RVA: 0x033696A0 */ set; /* RVA: 0x03CF9AA0 */ }
        Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get; /* RVA: 0x033696E0 */ set; /* RVA: 0x03CF9B00 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> Converters { get; /* RVA: 0x03D4E7B0 */ set; /* RVA: 0x05142FC4 */ }
        Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { get; /* RVA: 0x092B3994 */ }
        Newtonsoft.Json.TypeNameHandling TypeNameHandling { get; /* RVA: 0x03367F30 */ set; /* RVA: 0x03C8FD90 */ }
        Newtonsoft.Json.MetadataPropertyHandling MetadataPropertyHandling { get; /* RVA: 0x092B391C */ }
        Newtonsoft.Json.TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; /* RVA: 0x03D46F10 */ set; /* RVA: 0x03D29B00 */ }
        Newtonsoft.Json.ConstructorHandling ConstructorHandling { get; /* RVA: 0x03C904B0 */ set; /* RVA: 0x03D29C80 */ }
        Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get; /* RVA: 0x03D51140 */ set; /* RVA: 0x0589D964 */ }
        System.Collections.IEqualityComparer EqualityComparer { get; /* RVA: 0x03D50EA0 */ set; /* RVA: 0x056A2B64 */ }
        System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> ReferenceResolverProvider { get; /* RVA: 0x03D51950 */ set; /* RVA: 0x058B408C */ }
        Newtonsoft.Json.Serialization.ITraceWriter TraceWriter { get; /* RVA: 0x03D50160 */ set; /* RVA: 0x0554D2E0 */ }
        Newtonsoft.Json.Serialization.ISerializationBinder SerializationBinder { get; /* RVA: 0x03D50770 */ set; /* RVA: 0x055631FC */ }
        System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error { get; /* RVA: 0x03D56D30 */ set; /* RVA: 0x0589D950 */ }
        System.Runtime.Serialization.StreamingContext Context { get; /* RVA: 0x092B3880 */ }
        System.Nullable<System.Int32> MaxDepth { set; /* RVA: 0x03C801B0 */ }
        Newtonsoft.Json.Formatting Formatting { set; /* RVA: 0x03D29C20 */ }
        System.Boolean CheckAdditionalContent { get; /* RVA: 0x092B3848 */ }

        // Methods
        // RVA: 0x03CF1A70  token: 0x6000107
        private static System.Void .cctor() { }
        // RVA: 0x035A2350  token: 0x6000108
        public System.Void .ctor() { }
        // RVA: 0x035A23D0  token: 0x6000109
        public System.Void .ctor(Newtonsoft.Json.JsonSerializerSettings original) { }

    }

    // TypeToken: 0x200002C  // size: 0xD8
    public class JsonTextReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        // Fields
        private readonly System.Boolean _safeAsync;  // 0x78
        private readonly System.IO.TextReader _reader;  // 0x80
        private System.Char[] _chars;  // 0x88
        private System.Int32 _charsUsed;  // 0x90
        private System.Int32 _charPos;  // 0x94
        private System.Int32 _lineStartPos;  // 0x98
        private System.Int32 _lineNumber;  // 0x9c
        private System.Boolean _isEndOfFile;  // 0xa0
        private Newtonsoft.Json.Utilities.StringBuffer _stringBuffer;  // 0xa8
        private Newtonsoft.Json.Utilities.StringReference _stringReference;  // 0xb8
        private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool;  // 0xc8
        private Newtonsoft.Json.JsonNameTable <PropertyNameTable>k__BackingField;  // 0xd0

        // Properties
        Newtonsoft.Json.JsonNameTable PropertyNameTable { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        System.Int32 LineNumber { get; /* RVA: 0x02698E90 */ }
        System.Int32 LinePosition { get; /* RVA: 0x03D71450 */ }

        // Methods
        // RVA: 0x02696210  token: 0x600010A
        public System.Void .ctor(System.IO.TextReader reader) { }
        // RVA: 0x029057F0  token: 0x600010D
        private System.Void EnsureBufferNotEmpty() { }
        // RVA: 0x0236BEC0  token: 0x600010E
        private System.Void SetNewLine(System.Boolean hasNextChar) { }
        // RVA: 0x03D71420  token: 0x600010F
        private System.Void OnNewLine(System.Int32 pos) { }
        // RVA: 0x023692D0  token: 0x6000110
        private System.Void ParseString(System.Char quote, Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x02368A90  token: 0x6000111
        private System.Void ParseReadString(System.Char quote, Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x02462430  token: 0x6000112
        private static System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count) { }
        // RVA: 0x0236AAA0  token: 0x6000113
        private System.Void ShiftBufferIfNeeded() { }
        // RVA: 0x042726CC  token: 0x6000114
        private System.Int32 ReadData(System.Boolean append) { }
        // RVA: 0x02B46370  token: 0x6000115
        private System.Void PrepareBufferForReadData(System.Boolean append, System.Int32 charsRequired) { }
        // RVA: 0x02B461E0  token: 0x6000116
        private System.Int32 ReadData(System.Boolean append, System.Int32 charsRequired) { }
        // RVA: 0x0236BBA0  token: 0x6000117
        private System.Boolean EnsureChars(System.Int32 relativePosition, System.Boolean append) { }
        // RVA: 0x02B46090  token: 0x6000118
        private System.Boolean ReadChars(System.Int32 relativePosition, System.Boolean append) { }
        // RVA: 0x022A7F70  token: 0x6000119
        public virtual System.Boolean Read() { }
        // RVA: 0x029DEEF0  token: 0x600011A
        public virtual System.Nullable<System.Int32> ReadAsInt32() { }
        // RVA: 0x092B5A64  token: 0x600011B
        public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }
        // RVA: 0x0247E2E0  token: 0x600011C
        public virtual System.String ReadAsString() { }
        // RVA: 0x092B551C  token: 0x600011D
        public virtual System.Byte[] ReadAsBytes() { }
        // RVA: 0x0247D000  token: 0x600011E
        private System.Object ReadStringValue(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x0247C2A0  token: 0x600011F
        private System.Object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B4308  token: 0x6000120
        private Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(System.Char c) { }
        // RVA: 0x024EC700  token: 0x6000121
        public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }
        // RVA: 0x092B54B4  token: 0x6000122
        private System.Void ProcessValueComma() { }
        // RVA: 0x029DEFE0  token: 0x6000123
        private System.Object ReadNumberValue(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B43F0  token: 0x6000124
        private System.Object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B59D8  token: 0x6000125
        public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        // RVA: 0x092B5AE8  token: 0x6000126
        public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }
        // RVA: 0x029DEE00  token: 0x6000127
        public virtual System.Nullable<System.Double> ReadAsDouble() { }
        // RVA: 0x092B4550  token: 0x6000128
        private System.Void HandleNull() { }
        // RVA: 0x092B5B74  token: 0x6000129
        private System.Void ReadFinished() { }
        // RVA: 0x029DF620  token: 0x600012A
        private System.Boolean ReadNullChar() { }
        // RVA: 0x022A8130  token: 0x600012B
        private System.Void EnsureBuffer() { }
        // RVA: 0x0236D260  token: 0x600012C
        private System.Void ReadStringIntoBuffer(System.Char quote) { }
        // RVA: 0x0236B970  token: 0x600012D
        private System.Void FinishReadStringIntoBuffer(System.Int32 charPos, System.Int32 initialPosition, System.Int32 lastWritePosition) { }
        // RVA: 0x033B9C90  token: 0x600012E
        private System.Void WriteCharToBuffer(System.Char writeChar, System.Int32 lastWritePosition, System.Int32 writeToPosition) { }
        // RVA: 0x092B418C  token: 0x600012F
        private System.Char ConvertUnicode(System.Boolean enoughChars) { }
        // RVA: 0x092B5378  token: 0x6000130
        private System.Char ParseUnicode() { }
        // RVA: 0x0236BFD0  token: 0x6000131
        private System.Void ReadNumberIntoBuffer() { }
        // RVA: 0x0236DD30  token: 0x6000132
        private System.Boolean ReadNumberCharIntoBuffer(System.Char currentChar, System.Int32 charPos) { }
        // RVA: 0x03D71400  token: 0x6000133
        private System.Void ClearRecentString() { }
        // RVA: 0x0236C050  token: 0x6000134
        private System.Boolean ParsePostValue(System.Boolean ignoreComments) { }
        // RVA: 0x0236CBD0  token: 0x6000135
        private System.Boolean ParseObject() { }
        // RVA: 0x0236DEF0  token: 0x6000136
        private System.Boolean ParseProperty() { }
        // RVA: 0x092B5E70  token: 0x6000137
        private System.Boolean ValidIdentifierChar(System.Char value) { }
        // RVA: 0x092B53A4  token: 0x6000138
        private System.Void ParseUnquotedProperty() { }
        // RVA: 0x092B5CC0  token: 0x6000139
        private System.Boolean ReadUnquotedPropertyReportIfDone(System.Char currentChar, System.Int32 initialPosition) { }
        // RVA: 0x02369400  token: 0x600013A
        private System.Boolean ParseValue() { }
        // RVA: 0x03D71430  token: 0x600013B
        private System.Void ProcessLineFeed() { }
        // RVA: 0x0236BD20  token: 0x600013C
        private System.Void ProcessCarriageReturn(System.Boolean append) { }
        // RVA: 0x0236B220  token: 0x600013D
        private System.Void EatWhitespace() { }
        // RVA: 0x092B4948  token: 0x600013E
        private System.Void ParseConstructor() { }
        // RVA: 0x0236A8F0  token: 0x600013F
        private System.Void ParseNumber(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x0247E5E0  token: 0x6000140
        private System.Void ParseReadNumber(Newtonsoft.Json.ReadType readType, System.Char firstChar, System.Int32 initialPosition) { }
        // RVA: 0x092B5E1C  token: 0x6000141
        private Newtonsoft.Json.JsonReaderException ThrowReaderError(System.String message, System.Exception ex) { }
        // RVA: 0x092B411C  token: 0x6000142
        private static System.Object BigIntegerParse(System.String number, System.Globalization.CultureInfo culture) { }
        // RVA: 0x092B462C  token: 0x6000143
        private System.Void ParseComment(System.Boolean setToken) { }
        // RVA: 0x092B43B4  token: 0x6000144
        private System.Void EndComment(System.Boolean setToken, System.Int32 initialPosition, System.Int32 endPosition) { }
        // RVA: 0x024EDAE0  token: 0x6000145
        private System.Boolean MatchValue(System.String value) { }
        // RVA: 0x024EDCD0  token: 0x6000146
        private System.Boolean MatchValue(System.Boolean enoughChars, System.String value) { }
        // RVA: 0x024ED700  token: 0x6000147
        private System.Boolean MatchValueWithTrailingSeparator(System.String value) { }
        // RVA: 0x024EDA70  token: 0x6000148
        private System.Boolean IsSeparator(System.Char c) { }
        // RVA: 0x03A2C3D0  token: 0x6000149
        private System.Void ParseTrue() { }
        // RVA: 0x03C85E30  token: 0x600014A
        private System.Void ParseNull() { }
        // RVA: 0x092B52D8  token: 0x600014B
        private System.Void ParseUndefined() { }
        // RVA: 0x038C6C60  token: 0x600014C
        private System.Void ParseFalse() { }
        // RVA: 0x092B5080  token: 0x600014D
        private System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B4F08  token: 0x600014E
        private System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        // RVA: 0x092B5268  token: 0x600014F
        private System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B50F0  token: 0x6000150
        private System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        // RVA: 0x092B4D20  token: 0x6000151
        private System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType) { }
        // RVA: 0x092B4D90  token: 0x6000152
        private System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        // RVA: 0x030AB480  token: 0x6000153
        public virtual System.Void Close() { }
        // RVA: 0x0232EB60  token: 0x6000154
        public virtual System.Boolean HasLineInfo() { }

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct ReadType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.ReadType Read;  // const
        public static Newtonsoft.Json.ReadType ReadAsInt32;  // const
        public static Newtonsoft.Json.ReadType ReadAsInt64;  // const
        public static Newtonsoft.Json.ReadType ReadAsBytes;  // const
        public static Newtonsoft.Json.ReadType ReadAsString;  // const
        public static Newtonsoft.Json.ReadType ReadAsDecimal;  // const
        public static Newtonsoft.Json.ReadType ReadAsDateTime;  // const
        public static Newtonsoft.Json.ReadType ReadAsDateTimeOffset;  // const
        public static Newtonsoft.Json.ReadType ReadAsDouble;  // const
        public static Newtonsoft.Json.ReadType ReadAsBoolean;  // const

    }

    // TypeToken: 0x200002E  // size: 0xA8
    public class JsonTextWriter : Newtonsoft.Json.JsonWriter
    {
        // Fields
        private readonly System.Boolean _safeAsync;  // 0x60
        private readonly System.IO.TextWriter _writer;  // 0x68
        private Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder;  // 0x70
        private System.Char _indentChar;  // 0x78
        private System.Int32 _indentation;  // 0x7c
        private System.Char _quoteChar;  // 0x80
        private System.Boolean _quoteName;  // 0x82
        private System.Boolean[] _charEscapeFlags;  // 0x88
        private System.Char[] _writeBuffer;  // 0x90
        private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool;  // 0x98
        private System.Char[] _indentChars;  // 0xa0

        // Properties
        Newtonsoft.Json.Utilities.Base64Encoder Base64Encoder { get; /* RVA: 0x092B6F30 */ }
        System.Char QuoteChar { get; /* RVA: 0x03D71460 */ }

        // Methods
        // RVA: 0x02697830  token: 0x6000159
        public System.Void .ctor(System.IO.TextWriter textWriter) { }
        // RVA: 0x030AB3E0  token: 0x600015A
        public virtual System.Void Close() { }
        // RVA: 0x030AB410  token: 0x600015B
        private System.Void CloseBufferAndWriter() { }
        // RVA: 0x02905C80  token: 0x600015C
        public virtual System.Void WriteStartObject() { }
        // RVA: 0x02905510  token: 0x600015D
        public virtual System.Void WriteStartArray() { }
        // RVA: 0x092B606C  token: 0x600015E
        public virtual System.Void WriteStartConstructor(System.String name) { }
        // RVA: 0x02905CC0  token: 0x600015F
        protected virtual System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x02905C20  token: 0x6000160
        public virtual System.Void WritePropertyName(System.String name) { }
        // RVA: 0x029060B0  token: 0x6000161
        public virtual System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        // RVA: 0x092B5EC8  token: 0x6000162
        private virtual System.Void OnStringEscapeHandlingChanged() { }
        // RVA: 0x02697940  token: 0x6000163
        private System.Void UpdateCharEscapeFlags() { }
        // RVA: 0x025EE550  token: 0x6000164
        protected virtual System.Void WriteIndent() { }
        // RVA: 0x025EE6F0  token: 0x6000165
        private System.Int32 SetIndentChars() { }
        // RVA: 0x02905D20  token: 0x6000166
        protected virtual System.Void WriteValueDelimiter() { }
        // RVA: 0x02905EC0  token: 0x6000167
        protected virtual System.Void WriteIndentSpace() { }
        // RVA: 0x02907540  token: 0x6000168
        private System.Void WriteValueInternal(System.String value, Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x092B64B0  token: 0x6000169
        public virtual System.Void WriteValue(System.Object value) { }
        // RVA: 0x092B5FE0  token: 0x600016A
        public virtual System.Void WriteNull() { }
        // RVA: 0x092B6104  token: 0x600016B
        public virtual System.Void WriteUndefined() { }
        // RVA: 0x092B6048  token: 0x600016C
        public virtual System.Void WriteRaw(System.String json) { }
        // RVA: 0x02905A90  token: 0x600016D
        public virtual System.Void WriteValue(System.String value) { }
        // RVA: 0x02905D90  token: 0x600016E
        private System.Void WriteEscapedString(System.String value, System.Boolean quote) { }
        // RVA: 0x029054A0  token: 0x600016F
        public virtual System.Void WriteValue(System.Int32 value) { }
        // RVA: 0x092B6778  token: 0x6000170
        public virtual System.Void WriteValue(System.UInt32 value) { }
        // RVA: 0x02905A50  token: 0x6000171
        public virtual System.Void WriteValue(System.Int64 value) { }
        // RVA: 0x092B6D9C  token: 0x6000172
        public virtual System.Void WriteValue(System.UInt64 value) { }
        // RVA: 0x092B6DD4  token: 0x6000173
        public virtual System.Void WriteValue(System.Single value) { }
        // RVA: 0x092B6E6C  token: 0x6000174
        public virtual System.Void WriteValue(System.Nullable<System.Single> value) { }
        // RVA: 0x092B6D04  token: 0x6000175
        public virtual System.Void WriteValue(System.Double value) { }
        // RVA: 0x092B6578  token: 0x6000176
        public virtual System.Void WriteValue(System.Nullable<System.Double> value) { }
        // RVA: 0x02905B00  token: 0x6000177
        public virtual System.Void WriteValue(System.Boolean value) { }
        // RVA: 0x092B6640  token: 0x6000178
        public virtual System.Void WriteValue(System.Int16 value) { }
        // RVA: 0x092B6744  token: 0x6000179
        public virtual System.Void WriteValue(System.UInt16 value) { }
        // RVA: 0x092B6C94  token: 0x600017A
        public virtual System.Void WriteValue(System.Char value) { }
        // RVA: 0x092B6C60  token: 0x600017B
        public virtual System.Void WriteValue(System.Byte value) { }
        // RVA: 0x092B69F8  token: 0x600017C
        public virtual System.Void WriteValue(System.SByte value) { }
        // RVA: 0x092B68E8  token: 0x600017D
        public virtual System.Void WriteValue(System.Decimal value) { }
        // RVA: 0x092B6A2C  token: 0x600017E
        public virtual System.Void WriteValue(System.DateTime value) { }
        // RVA: 0x092B62D0  token: 0x600017F
        private System.Int32 WriteValueToBuffer(System.DateTime value) { }
        // RVA: 0x092B63F4  token: 0x6000180
        public virtual System.Void WriteValue(System.Byte[] value) { }
        // RVA: 0x092B67AC  token: 0x6000181
        public virtual System.Void WriteValue(System.DateTimeOffset value) { }
        // RVA: 0x092B616C  token: 0x6000182
        private System.Int32 WriteValueToBuffer(System.DateTimeOffset value) { }
        // RVA: 0x092B6674  token: 0x6000183
        public virtual System.Void WriteValue(System.Guid value) { }
        // RVA: 0x092B6B84  token: 0x6000184
        public virtual System.Void WriteValue(System.TimeSpan value) { }
        // RVA: 0x092B6960  token: 0x6000185
        public virtual System.Void WriteValue(System.Uri value) { }
        // RVA: 0x092B5ED0  token: 0x6000186
        public virtual System.Void WriteComment(System.String text) { }
        // RVA: 0x02905E70  token: 0x6000187
        private System.Void EnsureWriteBuffer() { }
        // RVA: 0x02907570  token: 0x6000188
        private System.Void WriteIntegerValue(System.Int64 value) { }
        // RVA: 0x029058A0  token: 0x6000189
        private System.Void WriteIntegerValue(System.UInt64 value, System.Boolean negative) { }
        // RVA: 0x02905930  token: 0x600018A
        private System.Int32 WriteNumberToBuffer(System.UInt64 value, System.Boolean negative) { }
        // RVA: 0x02905450  token: 0x600018B
        private System.Void WriteIntegerValue(System.Int32 value) { }
        // RVA: 0x092B5F6C  token: 0x600018C
        private System.Void WriteIntegerValue(System.UInt32 value, System.Boolean negative) { }
        // RVA: 0x02905970  token: 0x600018D
        private System.Int32 WriteNumberToBuffer(System.UInt32 value, System.Boolean negative) { }

    }

    // TypeToken: 0x200002F  // size: 0x14
    public sealed struct JsonToken
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.JsonToken None;  // const
        public static Newtonsoft.Json.JsonToken StartObject;  // const
        public static Newtonsoft.Json.JsonToken StartArray;  // const
        public static Newtonsoft.Json.JsonToken StartConstructor;  // const
        public static Newtonsoft.Json.JsonToken PropertyName;  // const
        public static Newtonsoft.Json.JsonToken Comment;  // const
        public static Newtonsoft.Json.JsonToken Raw;  // const
        public static Newtonsoft.Json.JsonToken Integer;  // const
        public static Newtonsoft.Json.JsonToken Float;  // const
        public static Newtonsoft.Json.JsonToken String;  // const
        public static Newtonsoft.Json.JsonToken Boolean;  // const
        public static Newtonsoft.Json.JsonToken Null;  // const
        public static Newtonsoft.Json.JsonToken Undefined;  // const
        public static Newtonsoft.Json.JsonToken EndObject;  // const
        public static Newtonsoft.Json.JsonToken EndArray;  // const
        public static Newtonsoft.Json.JsonToken EndConstructor;  // const
        public static Newtonsoft.Json.JsonToken Date;  // const
        public static Newtonsoft.Json.JsonToken Bytes;  // const

    }

    // TypeToken: 0x2000030  // size: 0x60
    public abstract class JsonWriter : System.IDisposable
    {
        // Fields
        private static readonly Newtonsoft.Json.JsonWriter.State[][] StateArray;  // static @ 0x0
        private static readonly Newtonsoft.Json.JsonWriter.State[][] StateArrayTemplate;  // static @ 0x8
        private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;  // 0x10
        private Newtonsoft.Json.JsonPosition _currentPosition;  // 0x18
        private Newtonsoft.Json.JsonWriter.State _currentState;  // 0x30
        private Newtonsoft.Json.Formatting _formatting;  // 0x34
        private System.Boolean <CloseOutput>k__BackingField;  // 0x38
        private System.Boolean <AutoCompleteOnClose>k__BackingField;  // 0x39
        private Newtonsoft.Json.DateFormatHandling _dateFormatHandling;  // 0x3c
        private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;  // 0x40
        private Newtonsoft.Json.StringEscapeHandling _stringEscapeHandling;  // 0x44
        private Newtonsoft.Json.FloatFormatHandling _floatFormatHandling;  // 0x48
        private System.String _dateFormatString;  // 0x50
        private System.Globalization.CultureInfo _culture;  // 0x58

        // Properties
        System.Boolean CloseOutput { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Boolean AutoCompleteOnClose { get; /* RVA: 0x03D4F300 */ set; /* RVA: 0x03D4F330 */ }
        System.Int32 Top { get; /* RVA: 0x025EE690 */ }
        Newtonsoft.Json.WriteState WriteState { get; /* RVA: 0x092B7FA0 */ }
        System.String ContainerPath { get; /* RVA: 0x092B7E28 */ }
        System.String Path { get; /* RVA: 0x092B7EAC */ }
        Newtonsoft.Json.Formatting Formatting { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x02697660 */ }
        Newtonsoft.Json.DateFormatHandling DateFormatHandling { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x092B80A4 */ }
        Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x092B810C */ }
        Newtonsoft.Json.StringEscapeHandling StringEscapeHandling { get; /* RVA: 0x03D4EE80 */ set; /* RVA: 0x092B81DC */ }
        Newtonsoft.Json.FloatFormatHandling FloatFormatHandling { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x092B8174 */ }
        System.String DateFormatString { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Globalization.CultureInfo Culture { get; /* RVA: 0x03163B30 */ set; /* RVA: 0x03081D30 */ }

        // Methods
        // RVA: 0x02905610  token: 0x600018E
        private static Newtonsoft.Json.JsonWriter.State[][] BuildStateArray() { }
        // RVA: 0x02563190  token: 0x600018F
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001A0
        private virtual System.Void OnStringEscapeHandlingChanged() { }
        // RVA: 0x03D71470  token: 0x60001A7
        protected System.Void .ctor() { }
        // RVA: 0x02906C00  token: 0x60001A8
        private System.Void UpdateScopeWithFinishedValue() { }
        // RVA: 0x02906DD0  token: 0x60001A9
        private System.Void Push(Newtonsoft.Json.JsonContainerType value) { }
        // RVA: 0x03437BF0  token: 0x60001AA
        private Newtonsoft.Json.JsonContainerType Pop() { }
        // RVA: 0x020D1AC0  token: 0x60001AB
        private Newtonsoft.Json.JsonContainerType Peek() { }
        // RVA: 0x025EE630  token: 0x60001AC
        public virtual System.Void Close() { }
        // RVA: 0x04271184  token: 0x60001AD
        public virtual System.Void WriteStartObject() { }
        // RVA: 0x038936C0  token: 0x60001AE
        public virtual System.Void WriteEndObject() { }
        // RVA: 0x04271194  token: 0x60001AF
        public virtual System.Void WriteStartArray() { }
        // RVA: 0x038936B0  token: 0x60001B0
        public virtual System.Void WriteEndArray() { }
        // RVA: 0x092B753C  token: 0x60001B1
        public virtual System.Void WriteStartConstructor(System.String name) { }
        // RVA: 0x092B7410  token: 0x60001B2
        public virtual System.Void WriteEndConstructor() { }
        // RVA: 0x042711A4  token: 0x60001B3
        public virtual System.Void WritePropertyName(System.String name) { }
        // RVA: 0x03B45E00  token: 0x60001B4
        public virtual System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        // RVA: 0x092B7420  token: 0x60001B5
        public virtual System.Void WriteEnd() { }
        // RVA: 0x04271108  token: 0x60001B6
        public System.Void WriteToken(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x0269A170  token: 0x60001B7
        public System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren) { }
        // RVA: 0x0269A500  token: 0x60001B8
        public System.Void WriteToken(Newtonsoft.Json.JsonToken token, System.Object value) { }
        // RVA: 0x0269A370  token: 0x60001B9
        private virtual System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments) { }
        // RVA: 0x0269A2C0  token: 0x60001BA
        private System.Boolean IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Int32 initialDepth) { }
        // RVA: 0x0269A840  token: 0x60001BB
        private System.Int32 CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x0269A310  token: 0x60001BC
        private System.Int32 CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092B7368  token: 0x60001BD
        private System.Void WriteConstructorDate(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092B742C  token: 0x60001BE
        private System.Void WriteEnd(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x025EE640  token: 0x60001BF
        private System.Void AutoCompleteAll() { }
        // RVA: 0x03437B50  token: 0x60001C0
        private Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x03437AB0  token: 0x60001C1
        private System.Void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x03437B90  token: 0x60001C2
        private System.Int32 CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type) { }
        // RVA: 0x03437CE0  token: 0x60001C3
        private System.Void UpdateCurrentState() { }
        // RVA: 0x0350B670  token: 0x60001C4
        protected virtual System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x0350B670  token: 0x60001C5
        protected virtual System.Void WriteIndent() { }
        // RVA: 0x0350B670  token: 0x60001C6
        protected virtual System.Void WriteValueDelimiter() { }
        // RVA: 0x0350B670  token: 0x60001C7
        protected virtual System.Void WriteIndentSpace() { }
        // RVA: 0x02906C10  token: 0x60001C8
        private System.Void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten) { }
        // RVA: 0x092B74EC  token: 0x60001C9
        public virtual System.Void WriteNull() { }
        // RVA: 0x092B754C  token: 0x60001CA
        public virtual System.Void WriteUndefined() { }
        // RVA: 0x0350B670  token: 0x60001CB
        public virtual System.Void WriteRaw(System.String json) { }
        // RVA: 0x092B74FC  token: 0x60001CC
        public virtual System.Void WriteRawValue(System.String json) { }
        // RVA: 0x042711D8  token: 0x60001CD
        public virtual System.Void WriteValue(System.String value) { }
        // RVA: 0x042711E8  token: 0x60001CE
        public virtual System.Void WriteValue(System.Int32 value) { }
        // RVA: 0x042711E8  token: 0x60001CF
        public virtual System.Void WriteValue(System.UInt32 value) { }
        // RVA: 0x042711E8  token: 0x60001D0
        public virtual System.Void WriteValue(System.Int64 value) { }
        // RVA: 0x042711E8  token: 0x60001D1
        public virtual System.Void WriteValue(System.UInt64 value) { }
        // RVA: 0x092B7718  token: 0x60001D2
        public virtual System.Void WriteValue(System.Single value) { }
        // RVA: 0x092B7718  token: 0x60001D3
        public virtual System.Void WriteValue(System.Double value) { }
        // RVA: 0x04276B00  token: 0x60001D4
        public virtual System.Void WriteValue(System.Boolean value) { }
        // RVA: 0x042711E8  token: 0x60001D5
        public virtual System.Void WriteValue(System.Int16 value) { }
        // RVA: 0x042711E8  token: 0x60001D6
        public virtual System.Void WriteValue(System.UInt16 value) { }
        // RVA: 0x042711D8  token: 0x60001D7
        public virtual System.Void WriteValue(System.Char value) { }
        // RVA: 0x042711E8  token: 0x60001D8
        public virtual System.Void WriteValue(System.Byte value) { }
        // RVA: 0x042711E8  token: 0x60001D9
        public virtual System.Void WriteValue(System.SByte value) { }
        // RVA: 0x092B7718  token: 0x60001DA
        public virtual System.Void WriteValue(System.Decimal value) { }
        // RVA: 0x092B75C8  token: 0x60001DB
        public virtual System.Void WriteValue(System.DateTime value) { }
        // RVA: 0x092B75C8  token: 0x60001DC
        public virtual System.Void WriteValue(System.DateTimeOffset value) { }
        // RVA: 0x042711D8  token: 0x60001DD
        public virtual System.Void WriteValue(System.Guid value) { }
        // RVA: 0x042711D8  token: 0x60001DE
        public virtual System.Void WriteValue(System.TimeSpan value) { }
        // RVA: 0x092B7CEC  token: 0x60001DF
        public virtual System.Void WriteValue(System.Nullable<System.Int32> value) { }
        // RVA: 0x092B77F4  token: 0x60001E0
        public virtual System.Void WriteValue(System.Nullable<System.UInt32> value) { }
        // RVA: 0x092B7A74  token: 0x60001E1
        public virtual System.Void WriteValue(System.Nullable<System.Int64> value) { }
        // RVA: 0x092B7934  token: 0x60001E2
        public virtual System.Void WriteValue(System.Nullable<System.UInt64> value) { }
        // RVA: 0x092B7728  token: 0x60001E3
        public virtual System.Void WriteValue(System.Nullable<System.Single> value) { }
        // RVA: 0x092B7860  token: 0x60001E4
        public virtual System.Void WriteValue(System.Nullable<System.Double> value) { }
        // RVA: 0x092B7C4C  token: 0x60001E5
        public virtual System.Void WriteValue(System.Nullable<System.Boolean> value) { }
        // RVA: 0x092B799C  token: 0x60001E6
        public virtual System.Void WriteValue(System.Nullable<System.Int16> value) { }
        // RVA: 0x092B7DC4  token: 0x60001E7
        public virtual System.Void WriteValue(System.Nullable<System.UInt16> value) { }
        // RVA: 0x092B755C  token: 0x60001E8
        public virtual System.Void WriteValue(System.Nullable<System.Char> value) { }
        // RVA: 0x092B78C8  token: 0x60001E9
        public virtual System.Void WriteValue(System.Nullable<System.Byte> value) { }
        // RVA: 0x092B76B0  token: 0x60001EA
        public virtual System.Void WriteValue(System.Nullable<System.SByte> value) { }
        // RVA: 0x092B7640  token: 0x60001EB
        public virtual System.Void WriteValue(System.Nullable<System.Decimal> value) { }
        // RVA: 0x092B75D8  token: 0x60001EC
        public virtual System.Void WriteValue(System.Nullable<System.DateTime> value) { }
        // RVA: 0x092B7A08  token: 0x60001ED
        public virtual System.Void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
        // RVA: 0x092B7D58  token: 0x60001EE
        public virtual System.Void WriteValue(System.Nullable<System.Guid> value) { }
        // RVA: 0x092B7794  token: 0x60001EF
        public virtual System.Void WriteValue(System.Nullable<System.TimeSpan> value) { }
        // RVA: 0x092B7CB8  token: 0x60001F0
        public virtual System.Void WriteValue(System.Byte[] value) { }
        // RVA: 0x092B7ADC  token: 0x60001F1
        public virtual System.Void WriteValue(System.Uri value) { }
        // RVA: 0x092B7B50  token: 0x60001F2
        public virtual System.Void WriteValue(System.Object value) { }
        // RVA: 0x092B7054  token: 0x60001F3
        public virtual System.Void WriteComment(System.String text) { }
        // RVA: 0x0341A550  token: 0x60001F4
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0341A5B0  token: 0x60001F5
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x027BB550  token: 0x60001F6
        private static System.Void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, System.Object value) { }
        // RVA: 0x092B7064  token: 0x60001F7
        private static System.Void ResolveConvertibleValue(System.IConvertible convertible, Newtonsoft.Json.Utilities.PrimitiveTypeCode& typeCode, System.Object& value) { }
        // RVA: 0x092B6FB4  token: 0x60001F8
        private static Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        // RVA: 0x092B715C  token: 0x60001F9
        protected System.Void SetWriteState(Newtonsoft.Json.JsonToken token, System.Object value) { }
        // RVA: 0x04276BEC  token: 0x60001FA
        private System.Void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container) { }
        // RVA: 0x02906BB0  token: 0x60001FB
        private System.Void InternalWritePropertyName(System.String name) { }
        // RVA: 0x0350B670  token: 0x60001FC
        private System.Void InternalWriteRaw() { }
        // RVA: 0x02905D50  token: 0x60001FD
        private System.Void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container) { }
        // RVA: 0x02906BE0  token: 0x60001FE
        private System.Void InternalWriteValue(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x092B7054  token: 0x60001FF
        private System.Void InternalWriteComment() { }

    }

    // TypeToken: 0x2000032  // size: 0x98
    public class JsonWriterException : Newtonsoft.Json.JsonException
    {
        // Fields
        private readonly System.String <Path>k__BackingField;  // 0x90

        // Methods
        // RVA: 0x092B11D4  token: 0x6000200
        public System.Void .ctor() { }
        // RVA: 0x092B1234  token: 0x6000201
        public System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x092C15B4  token: 0x6000202
        public System.Void .ctor(System.String message, System.String path, System.Exception innerException) { }
        // RVA: 0x092C1574  token: 0x6000203
        private static Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, System.String message, System.Exception ex) { }
        // RVA: 0x092C14C4  token: 0x6000204
        private static Newtonsoft.Json.JsonWriterException Create(System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct MemberSerialization
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.MemberSerialization OptOut;  // const
        public static Newtonsoft.Json.MemberSerialization OptIn;  // const
        public static Newtonsoft.Json.MemberSerialization Fields;  // const

    }

    // TypeToken: 0x2000034  // size: 0x14
    public sealed struct MetadataPropertyHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.MetadataPropertyHandling Default;  // const
        public static Newtonsoft.Json.MetadataPropertyHandling ReadAhead;  // const
        public static Newtonsoft.Json.MetadataPropertyHandling Ignore;  // const

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct MissingMemberHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.MissingMemberHandling Ignore;  // const
        public static Newtonsoft.Json.MissingMemberHandling Error;  // const

    }

    // TypeToken: 0x2000036  // size: 0x14
    public sealed struct NullValueHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.NullValueHandling Include;  // const
        public static Newtonsoft.Json.NullValueHandling Ignore;  // const

    }

    // TypeToken: 0x2000037  // size: 0x14
    public sealed struct ObjectCreationHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.ObjectCreationHandling Auto;  // const
        public static Newtonsoft.Json.ObjectCreationHandling Reuse;  // const
        public static Newtonsoft.Json.ObjectCreationHandling Replace;  // const

    }

    // TypeToken: 0x2000038  // size: 0x14
    public sealed struct PreserveReferencesHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.PreserveReferencesHandling None;  // const
        public static Newtonsoft.Json.PreserveReferencesHandling Objects;  // const
        public static Newtonsoft.Json.PreserveReferencesHandling Arrays;  // const
        public static Newtonsoft.Json.PreserveReferencesHandling All;  // const

    }

    // TypeToken: 0x2000039  // size: 0x14
    public sealed struct ReferenceLoopHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.ReferenceLoopHandling Error;  // const
        public static Newtonsoft.Json.ReferenceLoopHandling Ignore;  // const
        public static Newtonsoft.Json.ReferenceLoopHandling Serialize;  // const

    }

    // TypeToken: 0x200003A  // size: 0x14
    public sealed struct Required
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Required Default;  // const
        public static Newtonsoft.Json.Required AllowNull;  // const
        public static Newtonsoft.Json.Required Always;  // const
        public static Newtonsoft.Json.Required DisallowNull;  // const

    }

    // TypeToken: 0x200003B  // size: 0x14
    public sealed struct StringEscapeHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.StringEscapeHandling Default;  // const
        public static Newtonsoft.Json.StringEscapeHandling EscapeNonAscii;  // const
        public static Newtonsoft.Json.StringEscapeHandling EscapeHtml;  // const

    }

    // TypeToken: 0x200003C  // size: 0x14
    public sealed struct TypeNameAssemblyFormatHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.TypeNameAssemblyFormatHandling Simple;  // const
        public static Newtonsoft.Json.TypeNameAssemblyFormatHandling Full;  // const

    }

    // TypeToken: 0x200003D  // size: 0x14
    public sealed struct TypeNameHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.TypeNameHandling None;  // const
        public static Newtonsoft.Json.TypeNameHandling Objects;  // const
        public static Newtonsoft.Json.TypeNameHandling Arrays;  // const
        public static Newtonsoft.Json.TypeNameHandling All;  // const
        public static Newtonsoft.Json.TypeNameHandling Auto;  // const

    }

    // TypeToken: 0x200003E  // size: 0x14
    public sealed struct WriteState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.WriteState Error;  // const
        public static Newtonsoft.Json.WriteState Closed;  // const
        public static Newtonsoft.Json.WriteState Object;  // const
        public static Newtonsoft.Json.WriteState Array;  // const
        public static Newtonsoft.Json.WriteState Constructor;  // const
        public static Newtonsoft.Json.WriteState Property;  // const
        public static Newtonsoft.Json.WriteState Start;  // const

    }

}

namespace Newtonsoft.Json.Bson
{

    // TypeToken: 0x2000122  // size: 0x18
    public class BsonObjectId
    {
        // Fields
        private readonly System.Byte[] <Value>k__BackingField;  // 0x10

        // Properties
        System.Byte[] Value { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x092E059C  token: 0x6000958
        public System.Void .ctor(System.Byte[] value) { }

    }

    // TypeToken: 0x2000123  // size: 0x18
    public abstract class BsonToken
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;  // 0x10

        // Properties
        Newtonsoft.Json.Bson.BsonType Type { get; /* RVA: -1  // abstract */ }
        Newtonsoft.Json.Bson.BsonToken Parent { set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600095B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000124  // size: 0x20
    public class BsonObject : Newtonsoft.Json.Bson.BsonToken
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;  // 0x18

        // Properties
        Newtonsoft.Json.Bson.BsonType Type { get; /* RVA: 0x03D51050 */ }

        // Methods
        // RVA: 0x092E069C  token: 0x600095C
        public System.Void Add(System.String name, Newtonsoft.Json.Bson.BsonToken token) { }

    }

    // TypeToken: 0x2000125  // size: 0x20
    public class BsonArray : Newtonsoft.Json.Bson.BsonToken
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;  // 0x18

        // Properties
        Newtonsoft.Json.Bson.BsonType Type { get; /* RVA: 0x03D51040 */ }

        // Methods
        // RVA: 0x092E0534  token: 0x600095E
        public System.Void Add(Newtonsoft.Json.Bson.BsonToken token) { }

    }

    // TypeToken: 0x2000126  // size: 0x28
    public class BsonValue : Newtonsoft.Json.Bson.BsonToken
    {
        // Fields
        private readonly System.Object _value;  // 0x18
        private readonly Newtonsoft.Json.Bson.BsonType _type;  // 0x20

        // Properties
        Newtonsoft.Json.Bson.BsonType Type { get; /* RVA: 0x03D4EF90 */ }

        // Methods
        // RVA: 0x07F33C78  token: 0x6000960
        public System.Void .ctor(System.Object value, Newtonsoft.Json.Bson.BsonType type) { }

    }

    // TypeToken: 0x2000127  // size: 0x30
    public class BsonString : Newtonsoft.Json.Bson.BsonValue
    {
        // Fields
        private readonly System.Boolean <IncludeLength>k__BackingField;  // 0x28

        // Methods
        // RVA: 0x092E084C  token: 0x6000962
        public System.Void .ctor(System.Object value, System.Boolean includeLength) { }

    }

    // TypeToken: 0x2000128  // size: 0x28
    public class BsonRegex : Newtonsoft.Json.Bson.BsonToken
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;  // 0x18
        private Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;  // 0x20

        // Properties
        Newtonsoft.Json.Bson.BsonString Pattern { set; /* RVA: 0x022C3A90 */ }
        Newtonsoft.Json.Bson.BsonString Options { set; /* RVA: 0x04271930 */ }
        Newtonsoft.Json.Bson.BsonType Type { get; /* RVA: 0x03D5C650 */ }

        // Methods
        // RVA: 0x092E0794  token: 0x6000965
        public System.Void .ctor(System.String pattern, System.String options) { }

    }

    // TypeToken: 0x2000129  // size: 0x20
    public class BsonProperty
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;  // 0x10
        private Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;  // 0x18

        // Properties
        Newtonsoft.Json.Bson.BsonString Name { set; /* RVA: 0x0426FEE0 */ }
        Newtonsoft.Json.Bson.BsonToken Value { set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000969
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200012A  // size: 0x11
    public sealed struct BsonType
    {
        // Fields
        public System.SByte value__;  // 0x10
        public static Newtonsoft.Json.Bson.BsonType Number;  // const
        public static Newtonsoft.Json.Bson.BsonType String;  // const
        public static Newtonsoft.Json.Bson.BsonType Object;  // const
        public static Newtonsoft.Json.Bson.BsonType Array;  // const
        public static Newtonsoft.Json.Bson.BsonType Binary;  // const
        public static Newtonsoft.Json.Bson.BsonType Undefined;  // const
        public static Newtonsoft.Json.Bson.BsonType Oid;  // const
        public static Newtonsoft.Json.Bson.BsonType Boolean;  // const
        public static Newtonsoft.Json.Bson.BsonType Date;  // const
        public static Newtonsoft.Json.Bson.BsonType Null;  // const
        public static Newtonsoft.Json.Bson.BsonType Regex;  // const
        public static Newtonsoft.Json.Bson.BsonType Reference;  // const
        public static Newtonsoft.Json.Bson.BsonType Code;  // const
        public static Newtonsoft.Json.Bson.BsonType Symbol;  // const
        public static Newtonsoft.Json.Bson.BsonType CodeWScope;  // const
        public static Newtonsoft.Json.Bson.BsonType Integer;  // const
        public static Newtonsoft.Json.Bson.BsonType TimeStamp;  // const
        public static Newtonsoft.Json.Bson.BsonType Long;  // const
        public static Newtonsoft.Json.Bson.BsonType MinKey;  // const
        public static Newtonsoft.Json.Bson.BsonType MaxKey;  // const

    }

    // TypeToken: 0x200012B  // size: 0x78
    public class BsonWriter : Newtonsoft.Json.JsonWriter
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonToken _root;  // 0x60
        private Newtonsoft.Json.Bson.BsonToken _parent;  // 0x68
        private System.String _propertyName;  // 0x70

        // Methods
        // RVA: 0x092E0A10  token: 0x600096A
        private System.Void AddValue(System.Object value, Newtonsoft.Json.Bson.BsonType type) { }
        // RVA: 0x092E0874  token: 0x600096B
        private System.Void AddToken(Newtonsoft.Json.Bson.BsonToken token) { }
        // RVA: 0x092E0A98  token: 0x600096C
        public System.Void WriteObjectId(System.Byte[] value) { }
        // RVA: 0x092E0B84  token: 0x600096D
        public System.Void WriteRegex(System.String pattern, System.String options) { }

    }

}

namespace Newtonsoft.Json.Converters
{

    // TypeToken: 0x20000F9  // size: 0x10
    public class BinaryConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static System.String BinaryTypeName;  // const
        private static System.String BinaryToArrayName;  // const
        private static Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;  // static @ 0x0

        // Methods
        // RVA: 0x092CE610  token: 0x600082C
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092CDE50  token: 0x600082D
        private System.Byte[] GetByteArray(System.Object value) { }
        // RVA: 0x092CDCE8  token: 0x600082E
        private static System.Void EnsureReflectionObject(System.Type t) { }
        // RVA: 0x092CE22C  token: 0x600082F
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092CE014  token: 0x6000830
        private System.Byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x0323F3B0  token: 0x6000831
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000832
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA  // size: 0x10
    public class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: 0x092CE7B4  token: 0x6000833
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092CE660  token: 0x6000834
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x033B3D50  token: 0x6000835
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000836
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public abstract class CustomCreationConverter`1 : Newtonsoft.Json.JsonConverter
    {
        // Properties
        System.Boolean CanWrite { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000837
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // not resolved  token: 0x6000838
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: -1  // abstract  token: 0x6000839
        public virtual T Create(System.Type objectType) { }
        // RVA: -1  // not resolved  token: 0x600083A
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: -1  // not resolved  token: 0x600083C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC  // size: 0x10
    public class DataSetConverter : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: 0x092E0E98  token: 0x600083D
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E0C78  token: 0x600083E
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x03365BE0  token: 0x600083F
        public virtual System.Boolean CanConvert(System.Type valueType) { }
        // RVA: 0x0350B670  token: 0x6000840
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD  // size: 0x10
    public class DataTableConverter : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: 0x092E19AC  token: 0x6000841
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E1754  token: 0x6000842
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E1194  token: 0x6000843
        private static System.Void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E1580  token: 0x6000844
        private static System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x03365B50  token: 0x6000845
        public virtual System.Boolean CanConvert(System.Type valueType) { }
        // RVA: 0x0350B670  token: 0x6000846
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FE  // size: 0x10
    public abstract class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: 0x092E1E5C  token: 0x6000847
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000848
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF  // size: 0x10
    public class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static System.String CasePropertyName;  // const
        private static System.String FieldsPropertyName;  // const
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;  // static @ 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> UnionTypeLookupCache;  // static @ 0x8

        // Methods
        // RVA: 0x092E1F50  token: 0x6000849
        private static System.Type CreateUnionTypeLookup(System.Type t) { }
        // RVA: 0x092E2074  token: 0x600084A
        private static Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t) { }
        // RVA: 0x092E2B94  token: 0x600084B
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E24FC  token: 0x600084C
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x0283D120  token: 0x600084D
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x600084E
        public System.Void .ctor() { }
        // RVA: 0x038CEDA0  token: 0x600084F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000104  // size: 0x10
    public class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static System.String EntityKeyMemberFullTypeName;  // const
        private static System.String KeyPropertyName;  // const
        private static System.String TypePropertyName;  // const
        private static System.String ValuePropertyName;  // const
        private static Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;  // static @ 0x0

        // Methods
        // RVA: 0x092E3384  token: 0x6000856
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E3044  token: 0x6000857
        private static System.Void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, System.String propertyName) { }
        // RVA: 0x092E3140  token: 0x6000858
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E2F60  token: 0x6000859
        private static System.Void EnsureReflectionObject(System.Type objectType) { }
        // RVA: 0x03269D90  token: 0x600085A
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x600085B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000105  // size: 0x10
    public class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
    {
        // Properties
        System.Boolean CanWrite { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600085C
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E3644  token: 0x600085D
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E3900  token: 0x600085E
        private System.Object ReadValue(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092E364C  token: 0x600085F
        private System.Object ReadList(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092E3768  token: 0x6000860
        private System.Object ReadObject(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x033B3CE0  token: 0x6000861
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000863
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000106  // size: 0x28
    public class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        // Fields
        private static System.String DefaultDateTimeFormat;  // const
        private System.Globalization.DateTimeStyles _dateTimeStyles;  // 0x10
        private System.String _dateTimeFormat;  // 0x18
        private System.Globalization.CultureInfo _culture;  // 0x20

        // Properties
        System.Globalization.DateTimeStyles DateTimeStyles { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.String DateTimeFormat { get; /* RVA: 0x092E4138 */ set; /* RVA: 0x092E4180 */ }
        System.Globalization.CultureInfo Culture { get; /* RVA: 0x092E40E4 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x092E3EA8  token: 0x600086A
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E3A70  token: 0x600086B
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x03D71650  token: 0x600086C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000107  // size: 0x10
    public class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        // Methods
        // RVA: 0x092E44E4  token: 0x600086D
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E41C8  token: 0x600086E
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x0350B670  token: 0x600086F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000108  // size: 0x10
    public class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static System.String KeyName;  // const
        private static System.String ValueName;  // const
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;  // static @ 0x0

        // Methods
        // RVA: 0x092E467C  token: 0x6000870
        private static Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t) { }
        // RVA: 0x092E4B58  token: 0x6000871
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E47FC  token: 0x6000872
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x024768F0  token: 0x6000873
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000874
        public System.Void .ctor() { }
        // RVA: 0x03C83B50  token: 0x6000875
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000109  // size: 0x10
    public class RegexConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static System.String PatternName;  // const
        private static System.String OptionsName;  // const

        // Methods
        // RVA: 0x092E54E0  token: 0x6000876
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x02325BB0  token: 0x6000877
        private System.Boolean HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag) { }
        // RVA: 0x092E5250  token: 0x6000878
        private System.Void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex) { }
        // RVA: 0x092E536C  token: 0x6000879
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E4DD0  token: 0x600087A
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E5100  token: 0x600087B
        private System.Object ReadRegexString(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092E4E70  token: 0x600087C
        private System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x03365C70  token: 0x600087D
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x092E4D6C  token: 0x600087E
        private System.Boolean IsRegex(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x600087F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010A  // size: 0x20
    public class StringEnumConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;  // 0x10
        private System.Boolean <AllowIntegerValues>k__BackingField;  // 0x18

        // Properties
        System.Boolean CamelCaseText { get; /* RVA: 0x092E5EF0 */ set; /* RVA: 0x092E5F34 */ }
        Newtonsoft.Json.Serialization.NamingStrategy NamingStrategy { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean AllowIntegerValues { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x03D587A0  token: 0x6000886
        public System.Void .ctor() { }
        // RVA: 0x092E5C1C  token: 0x6000887
        public System.Void .ctor(System.Boolean camelCaseText) { }
        // RVA: 0x092E5BF4  token: 0x6000888
        public System.Void .ctor(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.Boolean allowIntegerValues) { }
        // RVA: 0x092E5C80  token: 0x6000889
        public System.Void .ctor(System.Type namingStrategyType) { }
        // RVA: 0x092E5D40  token: 0x600088A
        public System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters) { }
        // RVA: 0x092E5E10  token: 0x600088B
        public System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters, System.Boolean allowIntegerValues) { }
        // RVA: 0x092E5A38  token: 0x600088C
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E5604  token: 0x600088D
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E55A8  token: 0x600088E
        public virtual System.Boolean CanConvert(System.Type objectType) { }

    }

    // TypeToken: 0x200010B  // size: 0x18
    public class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        // Fields
        private static readonly System.DateTime UnixEpoch;  // static @ 0x0
        private System.Boolean <AllowPreEpoch>k__BackingField;  // 0x10

        // Properties
        System.Boolean AllowPreEpoch { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x03D557C0  token: 0x6000891
        public System.Void .ctor() { }
        // RVA: 0x03D4E960  token: 0x6000892
        public System.Void .ctor(System.Boolean allowPreEpoch) { }
        // RVA: 0x092E6458  token: 0x6000893
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E602C  token: 0x6000894
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E66AC  token: 0x6000895
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200010C  // size: 0x10
    public class VersionConverter : Newtonsoft.Json.JsonConverter
    {
        // Methods
        // RVA: 0x092E6A00  token: 0x6000896
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E6788  token: 0x6000897
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092E6724  token: 0x6000898
        public virtual System.Boolean CanConvert(System.Type objectType) { }
        // RVA: 0x0350B670  token: 0x6000899
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010D  // size: 0x30
    public class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDocument _document;  // 0x28

        // Properties
        Newtonsoft.Json.Converters.IXmlElement DocumentElement { get; /* RVA: 0x092E9160 */ }

        // Methods
        // RVA: 0x092E8A00  token: 0x600089A
        public System.Void .ctor(System.Xml.XmlDocument document) { }
        // RVA: 0x092E8C9C  token: 0x600089B
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String data) { }
        // RVA: 0x092E8F28  token: 0x600089C
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        // RVA: 0x092E8C20  token: 0x600089D
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        // RVA: 0x092E8FA4  token: 0x600089E
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        // RVA: 0x092E8EAC  token: 0x600089F
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        // RVA: 0x092E9020  token: 0x60008A0
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        // RVA: 0x092E90BC  token: 0x60008A1
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        // RVA: 0x092E8E20  token: 0x60008A2
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        // RVA: 0x092E8D18  token: 0x60008A3
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        // RVA: 0x092E8D94  token: 0x60008A4
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        // RVA: 0x092E8AE8  token: 0x60008A5
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        // RVA: 0x092E8B7C  token: 0x60008A6
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }

    }

    // TypeToken: 0x200010E  // size: 0x30
    public class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlElement _element;  // 0x28

        // Properties
        System.Boolean IsEmpty { get; /* RVA: 0x092E9290 */ }

        // Methods
        // RVA: 0x092E8A00  token: 0x60008A8
        public System.Void .ctor(System.Xml.XmlElement element) { }
        // RVA: 0x092E920C  token: 0x60008A9
        public virtual System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        // RVA: 0x092E91EC  token: 0x60008AA
        public virtual System.String GetPrefixOfNamespace(System.String namespaceUri) { }

    }

    // TypeToken: 0x200010F  // size: 0x30
    public class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDeclaration _declaration;  // 0x28

        // Properties
        System.String Version { get; /* RVA: 0x092E8A60 */ }
        System.String Encoding { get; /* RVA: 0x092E8A28 */ }
        System.String Standalone { get; /* RVA: 0x092E8A44 */ }

        // Methods
        // RVA: 0x092E8A00  token: 0x60008AC
        public System.Void .ctor(System.Xml.XmlDeclaration declaration) { }

    }

    // TypeToken: 0x2000110  // size: 0x30
    public class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDocumentType _documentType;  // 0x28

        // Properties
        System.String Name { get; /* RVA: 0x092E8AC4 */ }
        System.String System { get; /* RVA: 0x092E8A44 */ }
        System.String Public { get; /* RVA: 0x092E8A28 */ }
        System.String InternalSubset { get; /* RVA: 0x092E8A7C */ }
        System.String LocalName { get; /* RVA: 0x092E8A98 */ }

        // Methods
        // RVA: 0x092E8A00  token: 0x60008B0
        public System.Void .ctor(System.Xml.XmlDocumentType documentType) { }

    }

    // TypeToken: 0x2000111  // size: 0x28
    public class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlNode _node;  // 0x10
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;  // 0x18
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;  // 0x20

        // Properties
        System.Object WrappedNode { get; /* RVA: 0x020B7B20 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x092EFB48 */ }
        System.String LocalName { get; /* RVA: 0x092EFB00 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> ChildNodes { get; /* RVA: 0x092EF7C8 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> Attributes { get; /* RVA: 0x092EF52C */ }
        System.Boolean HasAttributes { get; /* RVA: 0x092EFA80 */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x092EFB6C */ }
        System.String Value { get; /* RVA: 0x092EFBE8 */ set; /* RVA: 0x092EFC0C */ }
        System.String NamespaceUri { get; /* RVA: 0x092EFB24 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60008B6
        public System.Void .ctor(System.Xml.XmlNode node) { }
        // RVA: 0x092EF3C0  token: 0x60008BB
        private static Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node) { }
        // RVA: 0x092EF338  token: 0x60008C1
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x2000112
    public interface IXmlDocument : Newtonsoft.Json.Converters.IXmlNode
    {
        // Properties
        Newtonsoft.Json.Converters.IXmlElement DocumentElement { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60008C3
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text) { }
        // RVA: -1  // abstract  token: 0x60008C4
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        // RVA: -1  // abstract  token: 0x60008C5
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        // RVA: -1  // abstract  token: 0x60008C6
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        // RVA: -1  // abstract  token: 0x60008C7
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        // RVA: -1  // abstract  token: 0x60008C8
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        // RVA: -1  // abstract  token: 0x60008C9
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        // RVA: -1  // abstract  token: 0x60008CA
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        // RVA: -1  // abstract  token: 0x60008CB
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        // RVA: -1  // abstract  token: 0x60008CC
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        // RVA: -1  // abstract  token: 0x60008CD
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        // RVA: -1  // abstract  token: 0x60008CE
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }

    }

    // TypeToken: 0x2000113
    public interface IXmlDeclaration : Newtonsoft.Json.Converters.IXmlNode
    {
        // Properties
        System.String Version { get; /* RVA: -1  // abstract */ }
        System.String Encoding { get; /* RVA: -1  // abstract */ }
        System.String Standalone { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000114
    public interface IXmlDocumentType : Newtonsoft.Json.Converters.IXmlNode
    {
        // Properties
        System.String Name { get; /* RVA: -1  // abstract */ }
        System.String System { get; /* RVA: -1  // abstract */ }
        System.String Public { get; /* RVA: -1  // abstract */ }
        System.String InternalSubset { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000115
    public interface IXmlElement : Newtonsoft.Json.Converters.IXmlNode
    {
        // Properties
        System.Boolean IsEmpty { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60008D7
        public virtual System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        // RVA: -1  // abstract  token: 0x60008D8
        public virtual System.String GetPrefixOfNamespace(System.String namespaceUri) { }

    }

    // TypeToken: 0x2000116
    public interface IXmlNode
    {
        // Properties
        System.Xml.XmlNodeType NodeType { get; /* RVA: -1  // abstract */ }
        System.String LocalName { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> ChildNodes { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> Attributes { get; /* RVA: -1  // abstract */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: -1  // abstract */ }
        System.String Value { get; /* RVA: -1  // abstract */ }
        System.String NamespaceUri { get; /* RVA: -1  // abstract */ }
        System.Object WrappedNode { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60008E0
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x2000117  // size: 0x20
    public class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XDeclaration <Declaration>k__BackingField;  // 0x18

        // Properties
        System.Xml.Linq.XDeclaration Declaration { get; /* RVA: 0x01041090 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D55F90 */ }
        System.String Version { get; /* RVA: 0x092E734C */ }
        System.String Encoding { get; /* RVA: 0x06179578 */ }
        System.String Standalone { get; /* RVA: 0x05F986E4 */ }

        // Methods
        // RVA: 0x092E7320  token: 0x60008E4
        public System.Void .ctor(System.Xml.Linq.XDeclaration declaration) { }

    }

    // TypeToken: 0x2000118  // size: 0x20
    public class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XDocumentType _documentType;  // 0x18

        // Properties
        System.String Name { get; /* RVA: 0x05F9871C */ }
        System.String System { get; /* RVA: 0x05F407B4 */ }
        System.String Public { get; /* RVA: 0x06177C5C */ }
        System.String InternalSubset { get; /* RVA: 0x092E7390 */ }
        System.String LocalName { get; /* RVA: 0x092E73AC */ }

        // Methods
        // RVA: 0x092E7368  token: 0x60008E9
        public System.Void .ctor(System.Xml.Linq.XDocumentType documentType) { }

    }

    // TypeToken: 0x2000119  // size: 0x20
    public class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
    {
        // Properties
        System.Xml.Linq.XDocument Document { get; /* RVA: 0x092E7DA0 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> ChildNodes { get; /* RVA: 0x092E7BF4 */ }
        System.Boolean HasChildNodes { get; /* RVA: 0x092E7DDC */ }
        Newtonsoft.Json.Converters.IXmlElement DocumentElement { get; /* RVA: 0x092E7D04 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60008F0
        public System.Void .ctor(System.Xml.Linq.XDocument document) { }
        // RVA: 0x092E7660  token: 0x60008F3
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text) { }
        // RVA: 0x092E7968  token: 0x60008F4
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        // RVA: 0x092E75D0  token: 0x60008F5
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        // RVA: 0x092E79F8  token: 0x60008F6
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        // RVA: 0x092E78D8  token: 0x60008F7
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        // RVA: 0x092E7A88  token: 0x60008F8
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        // RVA: 0x092E7B38  token: 0x60008F9
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        // RVA: 0x092E7838  token: 0x60008FA
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        // RVA: 0x092E76F0  token: 0x60008FB
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        // RVA: 0x092E778C  token: 0x60008FC
        public virtual Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        // RVA: 0x092E7468  token: 0x60008FD
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        // RVA: 0x092E7514  token: 0x60008FE
        public virtual Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }
        // RVA: 0x092E73D8  token: 0x6000900
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x200011A  // size: 0x18
    public class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
    {
        // Properties
        System.Xml.Linq.XText Text { get; /* RVA: 0x092E89A4 */ }
        System.String Value { get; /* RVA: 0x092E89E0 */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x092E894C */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000902
        public System.Void .ctor(System.Xml.Linq.XText text) { }

    }

    // TypeToken: 0x200011B  // size: 0x18
    public class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
    {
        // Properties
        System.Xml.Linq.XComment Text { get; /* RVA: 0x092E6C34 */ }
        System.String Value { get; /* RVA: 0x092E6C70 */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x092E6BDC */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000906
        public System.Void .ctor(System.Xml.Linq.XComment text) { }

    }

    // TypeToken: 0x200011C  // size: 0x18
    public class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
    {
        // Properties
        System.Xml.Linq.XProcessingInstruction ProcessingInstruction { get; /* RVA: 0x092E88F0 */ }
        System.String LocalName { get; /* RVA: 0x092E88D0 */ }
        System.String Value { get; /* RVA: 0x092E892C */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600090A
        public System.Void .ctor(System.Xml.Linq.XProcessingInstruction processingInstruction) { }

    }

    // TypeToken: 0x200011D  // size: 0x20
    public class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
    {
        // Fields
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;  // 0x18

        // Properties
        System.Xml.Linq.XContainer Container { get; /* RVA: 0x092E7260 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> ChildNodes { get; /* RVA: 0x092E7034 */ }
        System.Boolean HasChildNodes { get; /* RVA: 0x092E729C */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x092E72C8 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600090E
        public System.Void .ctor(System.Xml.Linq.XContainer container) { }
        // RVA: 0x092E6CF8  token: 0x6000912
        private static Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node) { }
        // RVA: 0x092E6C90  token: 0x6000913
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x200011E  // size: 0x18
    public class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XObject _xmlObject;  // 0x10

        // Properties
        System.Object WrappedNode { get; /* RVA: 0x020B7B20 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x092E88B0 */ }
        System.String LocalName { get; /* RVA: 0x01002730 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> ChildNodes { get; /* RVA: 0x092E8860 */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> Attributes { get; /* RVA: 0x092E8810 */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x01002730 */ }
        System.String Value { get; /* RVA: 0x01002730 */ }
        System.String NamespaceUri { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000914
        public System.Void .ctor(System.Xml.Linq.XObject xmlObject) { }
        // RVA: 0x092E87C4  token: 0x600091C
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x200011F  // size: 0x18
    public class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
    {
        // Properties
        System.Xml.Linq.XAttribute Attribute { get; /* RVA: 0x092E6AD4 */ }
        System.String Value { get; /* RVA: 0x092E6BBC */ }
        System.String LocalName { get; /* RVA: 0x092E6B10 */ }
        System.String NamespaceUri { get; /* RVA: 0x092E6B38 */ }
        Newtonsoft.Json.Converters.IXmlNode ParentNode { get; /* RVA: 0x092E6B64 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600091F
        public System.Void .ctor(System.Xml.Linq.XAttribute attribute) { }

    }

    // TypeToken: 0x2000120  // size: 0x28
    public class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
    {
        // Fields
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;  // 0x20

        // Properties
        System.Xml.Linq.XElement Element { get; /* RVA: 0x092E86EC */ }
        System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> Attributes { get; /* RVA: 0x092E8184 */ }
        System.String Value { get; /* RVA: 0x092E87A0 */ }
        System.String LocalName { get; /* RVA: 0x092E874C */ }
        System.String NamespaceUri { get; /* RVA: 0x092E8774 */ }
        System.Boolean IsEmpty { get; /* RVA: 0x092E8728 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000925
        public System.Void .ctor(System.Xml.Linq.XElement element) { }
        // RVA: 0x092E8104  token: 0x6000926
        public virtual System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        // RVA: 0x092E7E8C  token: 0x6000928
        private System.Boolean HasImplicitNamespaceAttribute(System.String namespaceUri) { }
        // RVA: 0x092E7E18  token: 0x6000929
        public virtual Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }
        // RVA: 0x092E7E48  token: 0x600092D
        public virtual System.String GetPrefixOfNamespace(System.String namespaceUri) { }

    }

    // TypeToken: 0x2000121  // size: 0x20
    public class XmlNodeConverter : Newtonsoft.Json.JsonConverter
    {
        // Fields
        private static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes;  // static @ 0x0
        private static System.String TextName;  // const
        private static System.String CommentName;  // const
        private static System.String CDataName;  // const
        private static System.String WhitespaceName;  // const
        private static System.String SignificantWhitespaceName;  // const
        private static System.String DeclarationName;  // const
        private static System.String JsonNamespaceUri;  // const
        private System.String <DeserializeRootElementName>k__BackingField;  // 0x10
        private System.Boolean <WriteArrayAttribute>k__BackingField;  // 0x18
        private System.Boolean <OmitRootObject>k__BackingField;  // 0x19
        private System.Boolean <EncodeSpecialCharacters>k__BackingField;  // 0x1a

        // Properties
        System.String DeserializeRootElementName { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean WriteArrayAttribute { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Boolean OmitRootObject { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean EncodeSpecialCharacters { get; /* RVA: 0x03D4EFA0 */ set; /* RVA: 0x03D4EFD0 */ }

        // Methods
        // RVA: 0x092EF200  token: 0x6000937
        public virtual System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092EEF04  token: 0x6000938
        private Newtonsoft.Json.Converters.IXmlNode WrapXml(System.Object value) { }
        // RVA: 0x092EB864  token: 0x6000939
        private System.Void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092ECD38  token: 0x600093A
        private System.String ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092EB210  token: 0x600093B
        private System.String GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092EB4F0  token: 0x600093C
        private System.Boolean IsArray(Newtonsoft.Json.Converters.IXmlNode node) { }
        // RVA: 0x092ECE78  token: 0x600093D
        private System.Void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName) { }
        // RVA: 0x092EEFEC  token: 0x600093E
        private System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, System.String elementNames) { }
        // RVA: 0x092EF138  token: 0x600093F
        private System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, System.String elementNames) { }
        // RVA: 0x092ED614  token: 0x6000940
        private System.Void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName) { }
        // RVA: 0x092E95E0  token: 0x6000941
        private static System.Boolean AllSameName(Newtonsoft.Json.Converters.IXmlNode node) { }
        // RVA: 0x092EC75C  token: 0x6000942
        public virtual System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092EAE50  token: 0x6000943
        private System.Void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        // RVA: 0x092EC450  token: 0x6000944
        private System.Void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092E9F20  token: 0x6000945
        private System.Void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String elementName, System.Xml.XmlNamespaceManager manager, System.String elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }
        // RVA: 0x092E92B0  token: 0x6000946
        private static System.Void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.String attributeName, System.Xml.XmlNamespaceManager manager, System.String attributePrefix) { }
        // RVA: 0x092E973C  token: 0x6000947
        private static System.String ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092EBBE4  token: 0x6000948
        private System.Void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092E9468  token: 0x6000949
        private System.Void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document) { }
        // RVA: 0x092EED04  token: 0x600094A
        private System.Boolean ShouldReadInto(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092EBE70  token: 0x600094B
        private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092EA4D8  token: 0x600094C
        private System.Void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName) { }
        // RVA: 0x092E9C44  token: 0x600094D
        private System.Void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        // RVA: 0x092EA374  token: 0x600094E
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName, Newtonsoft.Json.Converters.IXmlDocument document, System.String elementPrefix, System.Xml.XmlNamespaceManager manager) { }
        // RVA: 0x092EA7D0  token: 0x600094F
        private System.Void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        // RVA: 0x092EB6A8  token: 0x6000950
        private System.Boolean IsNamespaceAttribute(System.String attributeName, System.String& prefix) { }
        // RVA: 0x092EED70  token: 0x6000951
        private System.Boolean ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }
        // RVA: 0x03269DE0  token: 0x6000952
        public virtual System.Boolean CanConvert(System.Type valueType) { }
        // RVA: 0x092EB774  token: 0x6000953
        private System.Boolean IsXObject(System.Type valueType) { }
        // RVA: 0x092EB7EC  token: 0x6000954
        private System.Boolean IsXmlNode(System.Type valueType) { }
        // RVA: 0x0350B670  token: 0x6000955
        public System.Void .ctor() { }
        // RVA: 0x03CE2A10  token: 0x6000956
        private static System.Void .cctor() { }

    }

}

namespace Newtonsoft.Json.Linq
{

    // TypeToken: 0x20000DE  // size: 0x14
    public sealed struct CommentHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Linq.CommentHandling Ignore;  // const
        public static Newtonsoft.Json.Linq.CommentHandling Load;  // const

    }

    // TypeToken: 0x20000DF  // size: 0x14
    public sealed struct DuplicatePropertyNameHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Replace;  // const
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Ignore;  // const
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Error;  // const

    }

    // TypeToken: 0x20000E0  // size: 0x10
    public static class Extensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000676
        public static U Value(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value) { }
        // RVA: -1  // generic def  token: 0x6000677
        public static U Value(System.Collections.Generic.IEnumerable<T> value) { }
        // RVA: -1  // generic def  token: 0x6000678
        private static U Convert(T token) { }

    }

    // TypeToken: 0x20000E1  // size: 0x58
    public class JArray : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;  // 0x50

        // Properties
        System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; /* RVA: 0x03D4EAF0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: 0x02102C70 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x092CEDB4 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x092CEDB4 */ set; /* RVA: 0x092CEF08 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x02697BA0  token: 0x600067B
        public System.Void .ctor() { }
        // RVA: 0x092CED14  token: 0x600067C
        private System.Void .ctor(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092CEC78  token: 0x600067D
        public System.Void .ctor(System.Object content) { }
        // RVA: 0x092CE86C  token: 0x600067E
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092CE9E0  token: 0x600067F
        public static Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x092CEBC0  token: 0x6000680
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092CE95C  token: 0x6000684
        private virtual System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE9B0  token: 0x6000685
        public virtual System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE9BC  token: 0x6000686
        public virtual System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CEB98  token: 0x6000687
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: 0x092CE8F8  token: 0x6000688
        public virtual System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }
        // RVA: 0x092CE854  token: 0x6000689
        public virtual System.Void Add(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE85C  token: 0x600068A
        public virtual System.Void Clear() { }
        // RVA: 0x092CE8DC  token: 0x600068B
        public virtual System.Boolean Contains(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE8F0  token: 0x600068C
        public virtual System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        // RVA: 0x092CEBAC  token: 0x600068E
        public virtual System.Boolean Remove(Newtonsoft.Json.Linq.JToken item) { }

    }

    // TypeToken: 0x20000E2  // size: 0x60
    public class JConstructor : Newtonsoft.Json.Linq.JContainer
    {
        // Fields
        private System.String _name;  // 0x50
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;  // 0x58

        // Properties
        System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; /* RVA: 0x03D4EAA0 */ }
        System.String Name { get; /* RVA: 0x03D4EAF0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: 0x03D555E0 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x092CF4C0 */ }

        // Methods
        // RVA: 0x092CEF88  token: 0x6000690
        private virtual System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CF408  token: 0x6000693
        private System.Void .ctor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092CF2A8  token: 0x6000694
        public System.Void .ctor(System.String name) { }
        // RVA: 0x092CEF18  token: 0x6000695
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092CF1D8  token: 0x6000696
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092CEFDC  token: 0x6000698
        public static Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }

    }

    // TypeToken: 0x20000E3  // size: 0x50
    public abstract class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged
    {
        // Fields
        private System.ComponentModel.ListChangedEventHandler _listChanged;  // 0x30
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;  // 0x38
        private System.Object _syncRoot;  // 0x40
        private System.Boolean _busy;  // 0x48

        // Properties
        System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; /* RVA: -1  // abstract */ }
        System.Boolean HasValues { get; /* RVA: 0x03609800 */ }
        Newtonsoft.Json.Linq.JToken First { get; /* RVA: 0x03C79F60 */ }
        Newtonsoft.Json.Linq.JToken Last { get; /* RVA: 0x02698290 */ }
        Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; /* RVA: 0x092CEEFC */ set; /* RVA: 0x092CEF08 */ }
        System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean System.Collections.IList.IsFixedSize { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean System.Collections.IList.IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        System.Object System.Collections.IList.Item { get; /* RVA: 0x092CEEFC */ set; /* RVA: 0x092D0654 */ }
        System.Int32 Count { get; /* RVA: 0x092D091C */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: 0x0115F4C0 */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: 0x092D050C */ }

        // Events
        event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

        // Methods
        // RVA: 0x02699D40  token: 0x600069C
        private System.Void .ctor() { }
        // RVA: 0x092D068C  token: 0x600069D
        private System.Void .ctor(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x02698B10  token: 0x600069E
        private System.Void CheckReentrancy() { }
        // RVA: 0x092D0118  token: 0x600069F
        protected virtual System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        // RVA: 0x092D007C  token: 0x60006A0
        protected virtual System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        // RVA: 0x092CF60C  token: 0x60006A4
        public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }
        // RVA: 0x02699C20  token: 0x60006A5
        private System.Boolean IsMultiContent(System.Object content) { }
        // RVA: 0x02698A70  token: 0x60006A6
        private Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        // RVA: -1  // abstract  token: 0x60006A7
        private virtual System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x026988B0  token: 0x60006A8
        private virtual System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        // RVA: 0x092D01B4  token: 0x60006A9
        private virtual System.Void RemoveItemAt(System.Int32 index) { }
        // RVA: 0x092D0490  token: 0x60006AA
        private virtual System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D001C  token: 0x60006AB
        private virtual Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index) { }
        // RVA: 0x037AE600  token: 0x60006AC
        private virtual System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CF664  token: 0x60006AD
        private virtual System.Void ClearItems() { }
        // RVA: 0x092D04CC  token: 0x60006AE
        private virtual System.Void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement) { }
        // RVA: 0x092CFBC8  token: 0x60006AF
        private virtual System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CFBE4  token: 0x60006B0
        private virtual System.Void CopyItemsTo(System.Array array, System.Int32 arrayIndex) { }
        // RVA: 0x037AE960  token: 0x60006B1
        private static System.Boolean IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue) { }
        // RVA: 0x03603760  token: 0x60006B2
        private virtual System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing) { }
        // RVA: 0x02699010  token: 0x60006B3
        public virtual System.Void Add(System.Object content) { }
        // RVA: 0x02698130  token: 0x60006B4
        private System.Boolean TryAdd(System.Object content) { }
        // RVA: 0x02697D70  token: 0x60006B5
        private System.Void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token) { }
        // RVA: 0x02699090  token: 0x60006B6
        private System.Boolean TryAddInternal(System.Int32 index, System.Object content, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        // RVA: 0x02699BC0  token: 0x60006B7
        private static Newtonsoft.Json.Linq.JToken CreateFromContent(System.Object content) { }
        // RVA: 0x092CE85C  token: 0x60006B8
        public System.Void RemoveAll() { }
        // RVA: 0x038C3470  token: 0x60006B9
        private System.Void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options) { }
        // RVA: 0x026985D0  token: 0x60006BA
        private System.Void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x02698390  token: 0x60006BB
        private static Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent) { }
        // RVA: 0x092CE9B0  token: 0x60006BC
        private virtual System.Int32 System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE9BC  token: 0x60006BD
        private virtual System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CEB98  token: 0x60006BE
        private virtual System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(System.Int32 index) { }
        // RVA: 0x092CE854  token: 0x60006C1
        private virtual System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE85C  token: 0x60006C2
        private virtual System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }
        // RVA: 0x092CE8DC  token: 0x60006C3
        private virtual System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CE8F0  token: 0x60006C4
        private virtual System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        // RVA: 0x092CEBAC  token: 0x60006C6
        private virtual System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092CFF80  token: 0x60006C7
        private Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value) { }
        // RVA: 0x092D056C  token: 0x60006C8
        private virtual System.Int32 System.Collections.IList.Add(System.Object value) { }
        // RVA: 0x092CE85C  token: 0x60006C9
        private virtual System.Void System.Collections.IList.Clear() { }
        // RVA: 0x092D05A0  token: 0x60006CA
        private virtual System.Boolean System.Collections.IList.Contains(System.Object value) { }
        // RVA: 0x092D05C8  token: 0x60006CB
        private virtual System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        // RVA: 0x092D05EC  token: 0x60006CC
        private virtual System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        // RVA: 0x092D062C  token: 0x60006CF
        private virtual System.Void System.Collections.IList.Remove(System.Object value) { }
        // RVA: 0x092CEB98  token: 0x60006D0
        private virtual System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        // RVA: 0x092CE8F0  token: 0x60006D3
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }

    }

    // TypeToken: 0x20000E4
    public sealed struct JEnumerable`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.IEquatable`1
    {
        // Fields
        public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty;  // static @ 0x0
        private readonly System.Collections.Generic.IEnumerable<T> _enumerable;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60006D7
        public System.Void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }
        // RVA: -1  // not resolved  token: 0x60006D8
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60006D9
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60006DA
        public virtual System.Boolean Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }
        // RVA: -1  // not resolved  token: 0x60006DB
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: -1  // not resolved  token: 0x60006DC
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x60006DD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5  // size: 0x68
    public class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary`2, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ICustomTypeDescriptor
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;  // 0x50
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;  // 0x58
        private System.ComponentModel.PropertyChangingEventHandler PropertyChanging;  // 0x60

        // Properties
        System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; /* RVA: 0x03D4EAF0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: 0x01168950 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x032F7BD0 */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x032F7BD0 */ set; /* RVA: 0x037AE510 */ }
        System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; /* RVA: 0x092D145C */ }
        System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; /* RVA: 0x092D147C */ }
        System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; /* RVA: 0x0115F4C0 */ }

        // Events
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        // Methods
        // RVA: 0x02697DF0  token: 0x60006E1
        public System.Void .ctor() { }
        // RVA: 0x092D1944  token: 0x60006E2
        private System.Void .ctor(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092D0EA0  token: 0x60006E3
        private virtual System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x026984E0  token: 0x60006E4
        private virtual System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        // RVA: 0x02698B30  token: 0x60006E5
        private virtual System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing) { }
        // RVA: 0x037AE9C0  token: 0x60006E6
        private System.Void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty) { }
        // RVA: 0x037AE8F0  token: 0x60006E7
        private System.Void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty) { }
        // RVA: 0x092D0C3C  token: 0x60006E8
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092D0ECC  token: 0x60006EA
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }
        // RVA: 0x02698C10  token: 0x60006EB
        public Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison) { }
        // RVA: 0x038C3370  token: 0x60006EF
        public static Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x04276080  token: 0x60006F0
        public static Newtonsoft.Json.Linq.JObject Parse(System.String json) { }
        // RVA: 0x038C3210  token: 0x60006F1
        public static Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x02694400  token: 0x60006F2
        public static Newtonsoft.Json.Linq.JObject FromObject(System.Object o) { }
        // RVA: 0x02693920  token: 0x60006F3
        public static Newtonsoft.Json.Linq.JObject FromObject(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        // RVA: 0x026981B0  token: 0x60006F4
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092D0E90  token: 0x60006F5
        public Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName) { }
        // RVA: 0x092D0E64  token: 0x60006F6
        public Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName, System.StringComparison comparison) { }
        // RVA: 0x037AEAA0  token: 0x60006F7
        public virtual System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D0CAC  token: 0x60006F8
        public virtual System.Boolean ContainsKey(System.String propertyName) { }
        // RVA: 0x02697CF0  token: 0x60006FA
        public virtual System.Boolean Remove(System.String propertyName) { }
        // RVA: 0x02697340  token: 0x60006FB
        public virtual System.Boolean TryGetValue(System.String propertyName, Newtonsoft.Json.Linq.JToken& value) { }
        // RVA: 0x092D0F08  token: 0x60006FD
        private virtual System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        // RVA: 0x092CE85C  token: 0x60006FE
        private virtual System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }
        // RVA: 0x092D0F9C  token: 0x60006FF
        private virtual System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        // RVA: 0x092D1008  token: 0x6000700
        private virtual System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, System.Int32 arrayIndex) { }
        // RVA: 0x092D13D4  token: 0x6000702
        private virtual System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        // RVA: 0x092D0D4C  token: 0x6000703
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }
        // RVA: 0x037AEA50  token: 0x6000704
        protected virtual System.Void OnPropertyChanged(System.String propertyName) { }
        // RVA: 0x037AE910  token: 0x6000705
        protected virtual System.Void OnPropertyChanging(System.String propertyName) { }
        // RVA: 0x092D18EC  token: 0x6000706
        private virtual System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        // RVA: 0x092D1554  token: 0x6000707
        private virtual System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        // RVA: 0x092D14C8  token: 0x6000708
        private virtual System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        // RVA: 0x092D1518  token: 0x6000709
        private virtual System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        // RVA: 0x092D18F4  token: 0x600070A
        private virtual System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }
        // RVA: 0x092D0DA8  token: 0x600070B
        protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }

    }

    // TypeToken: 0x20000E9  // size: 0x60
    public class JProperty : Newtonsoft.Json.Linq.JContainer
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JProperty.JPropertyList _content;  // 0x50
        private readonly System.String _name;  // 0x58

        // Properties
        System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; /* RVA: 0x03D4EAF0 */ }
        System.String Name { get; /* RVA: 0x03D4EAA0 */ }
        Newtonsoft.Json.Linq.JToken Value { get; /* RVA: 0x042711AC */ set; /* RVA: 0x037AE5A0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: 0x03D50CD0 */ }

        // Methods
        // RVA: 0x092D2794  token: 0x600071E
        private System.Void .ctor(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092D238C  token: 0x600071F
        private virtual Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index) { }
        // RVA: 0x037AE830  token: 0x6000720
        private virtual System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D26D4  token: 0x6000721
        private virtual System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D2614  token: 0x6000722
        private virtual System.Void RemoveItemAt(System.Int32 index) { }
        // RVA: 0x092D23E8  token: 0x6000723
        private virtual System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x02698560  token: 0x6000724
        private virtual System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        // RVA: 0x092D2370  token: 0x6000725
        private virtual System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D2240  token: 0x6000726
        private virtual System.Void ClearItems() { }
        // RVA: 0x092D2300  token: 0x6000727
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x02699CB0  token: 0x6000729
        private System.Void .ctor(System.String name) { }
        // RVA: 0x037AE440  token: 0x600072A
        public System.Void .ctor(System.String name, System.Object content) { }
        // RVA: 0x02698320  token: 0x600072B
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092D2418  token: 0x600072C
        public static Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }

    }

    // TypeToken: 0x20000EC  // size: 0x88
    public class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
    {
        // Properties
        System.Type ComponentType { get; /* RVA: 0x092D1C48 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        System.Type PropertyType { get; /* RVA: 0x092D1C98 */ }
        System.Int32 NameHashCode { get; /* RVA: 0x01003B50 */ }

        // Methods
        // RVA: 0x092D1C3C  token: 0x6000742
        public System.Void .ctor(System.String name) { }
        // RVA: 0x0115F4C0  token: 0x6000743
        public virtual System.Boolean CanResetValue(System.Object component) { }
        // RVA: 0x092D1AFC  token: 0x6000744
        public virtual System.Object GetValue(System.Object component) { }
        // RVA: 0x0350B670  token: 0x6000745
        public virtual System.Void ResetValue(System.Object component) { }
        // RVA: 0x092D1B64  token: 0x6000746
        public virtual System.Void SetValue(System.Object component, System.Object value) { }
        // RVA: 0x0115F4C0  token: 0x6000747
        public virtual System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x20000ED  // size: 0x20
    public class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection`1
    {
        // Fields
        private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer;  // static @ 0x0
        private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary;  // 0x18

        // Properties
        System.Collections.Generic.ICollection<System.String> Keys { get; /* RVA: 0x092D20CC */ }

        // Methods
        // RVA: 0x02697E60  token: 0x600074C
        public System.Void .ctor() { }
        // RVA: 0x034B7D50  token: 0x600074D
        private System.Void AddKey(System.String key, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D1CE8  token: 0x600074E
        protected virtual System.Void ClearItems() { }
        // RVA: 0x092D1D44  token: 0x600074F
        public System.Boolean Contains(System.String key) { }
        // RVA: 0x034B7DC0  token: 0x6000750
        private System.Void EnsureDictionary() { }
        // RVA: 0x034B7CF0  token: 0x6000751
        private System.String GetKeyForItem(Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x034B7C70  token: 0x6000752
        protected virtual System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x092D1E74  token: 0x6000753
        protected virtual System.Void RemoveItem(System.Int32 index) { }
        // RVA: 0x092D1F0C  token: 0x6000754
        private System.Void RemoveKey(System.String key) { }
        // RVA: 0x092D1F5C  token: 0x6000755
        protected virtual System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        // RVA: 0x02698CF0  token: 0x6000756
        public System.Boolean TryGetValue(System.String key, Newtonsoft.Json.Linq.JToken& value) { }
        // RVA: 0x092D1DF4  token: 0x6000758
        public System.Int32 IndexOfReference(Newtonsoft.Json.Linq.JToken t) { }
        // RVA: 0x03D05430  token: 0x6000759
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000EE  // size: 0x40
    public class JRaw : Newtonsoft.Json.Linq.JValue
    {
        // Methods
        // RVA: 0x092D2BD4  token: 0x600075A
        private System.Void .ctor(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092D2BC4  token: 0x600075B
        public System.Void .ctor(System.Object rawJson) { }
        // RVA: 0x092D2894  token: 0x600075C
        public static Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092D2824  token: 0x600075D
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }

    }

    // TypeToken: 0x20000EF  // size: 0x18
    public class JsonCloneSettings
    {
        // Fields
        private static readonly Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;  // static @ 0x0
        private System.Boolean <CopyAnnotations>k__BackingField;  // 0x10

        // Properties
        System.Boolean CopyAnnotations { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x01168960  token: 0x600075E
        public System.Void .ctor() { }
        // RVA: 0x092DBBF8  token: 0x6000761
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000F0  // size: 0x20
    public class JsonLoadSettings
    {
        // Fields
        private Newtonsoft.Json.Linq.CommentHandling _commentHandling;  // 0x10
        private Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;  // 0x14
        private Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;  // 0x18

        // Properties
        Newtonsoft.Json.Linq.CommentHandling CommentHandling { get; /* RVA: 0x03D4E340 */ }
        Newtonsoft.Json.Linq.LineInfoHandling LineInfoHandling { get; /* RVA: 0x03D50CC0 */ }
        Newtonsoft.Json.Linq.DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get; /* RVA: 0x020D1AC0 */ }

    }

    // TypeToken: 0x20000F1  // size: 0x30
    public abstract class JToken : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, Newtonsoft.Json.IJsonLineInfo, System.ICloneable, System.Dynamic.IDynamicMetaObjectProvider
    {
        // Fields
        private Newtonsoft.Json.Linq.JContainer _parent;  // 0x10
        private Newtonsoft.Json.Linq.JToken _previous;  // 0x18
        private Newtonsoft.Json.Linq.JToken _next;  // 0x20
        private System.Object _annotations;  // 0x28
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BooleanTypes;  // static @ 0x0
        private static readonly Newtonsoft.Json.Linq.JTokenType[] NumberTypes;  // static @ 0x8
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes;  // static @ 0x10
        private static readonly Newtonsoft.Json.Linq.JTokenType[] StringTypes;  // static @ 0x18
        private static readonly Newtonsoft.Json.Linq.JTokenType[] GuidTypes;  // static @ 0x20
        private static readonly Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes;  // static @ 0x28
        private static readonly Newtonsoft.Json.Linq.JTokenType[] UriTypes;  // static @ 0x30
        private static readonly Newtonsoft.Json.Linq.JTokenType[] CharTypes;  // static @ 0x38
        private static readonly Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes;  // static @ 0x40
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BytesTypes;  // static @ 0x48

        // Properties
        Newtonsoft.Json.Linq.JContainer Parent { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        Newtonsoft.Json.Linq.JToken Root { get; /* RVA: 0x03D2ACF0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: -1  // abstract */ }
        System.Boolean HasValues { get; /* RVA: -1  // abstract */ }
        Newtonsoft.Json.Linq.JToken Next { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        Newtonsoft.Json.Linq.JToken Previous { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String Path { get; /* RVA: 0x092D4BFC */ }
        Newtonsoft.Json.Linq.JToken Item { get; /* RVA: 0x092D4ABC */ }
        Newtonsoft.Json.Linq.JToken First { get; /* RVA: 0x092D4A1C */ }
        Newtonsoft.Json.Linq.JToken Last { get; /* RVA: 0x092D4B5C */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LineNumber { get; /* RVA: 0x092D3E74 */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LinePosition { get; /* RVA: 0x092D3EB8 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000768
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000770
        private System.Void .ctor() { }
        // RVA: 0x092D39BC  token: 0x6000774
        public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }
        // RVA: 0x092D4470  token: 0x6000775
        public System.Void Remove() { }
        // RVA: 0x092D44EC  token: 0x6000776
        public System.Void Replace(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: -1  // abstract  token: 0x6000777
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x02697410  token: 0x6000778
        public virtual System.String ToString() { }
        // RVA: 0x02697460  token: 0x6000779
        public System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092D3B04  token: 0x600077A
        private static Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D3CDC  token: 0x600077B
        private static System.String GetType(Newtonsoft.Json.Linq.JToken token) { }
        // RVA: 0x092D4978  token: 0x600077C
        private static System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable) { }
        // RVA: 0x092D6CCC  token: 0x600077D
        public static System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D5E40  token: 0x600077E
        public static System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D81AC  token: 0x600077F
        public static System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D8B80  token: 0x6000780
        public static System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D7D50  token: 0x6000781
        public static System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D5BA8  token: 0x6000782
        public static System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D78E4  token: 0x6000783
        public static System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D9304  token: 0x6000784
        public static System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D624C  token: 0x6000785
        public static System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D6868  token: 0x6000786
        public static System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D70FC  token: 0x6000787
        public static System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D83CC  token: 0x6000788
        public static System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D859C  token: 0x6000789
        public static System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D9528  token: 0x600078A
        public static System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D74F0  token: 0x600078B
        public static System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D7B44  token: 0x600078C
        public static System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D6454  token: 0x600078D
        public static System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D876C  token: 0x600078E
        public static System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D55C4  token: 0x600078F
        public static System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D8974  token: 0x6000790
        public static System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D59E4  token: 0x6000791
        public static System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D76C0  token: 0x6000792
        public static System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D51E8  token: 0x6000793
        public static System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D4FF4  token: 0x6000794
        public static System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D665C  token: 0x6000795
        public static System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D72CC  token: 0x6000796
        public static System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D8F6C  token: 0x6000797
        public static System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D607C  token: 0x6000798
        public static System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D7F6C  token: 0x6000799
        public static System.String op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D53F4  token: 0x600079A
        public static System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D4E24  token: 0x600079B
        public static System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D57D0  token: 0x600079C
        public static System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D6A38  token: 0x600079D
        public static System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D913C  token: 0x600079E
        public static System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D8D50  token: 0x600079F
        public static System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D6EB0  token: 0x60007A0
        public static System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D480C  token: 0x60007A1
        private static System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D4640  token: 0x60007A2
        private static System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value) { }
        // RVA: 0x092D45C8  token: 0x60007A3
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x092D4564  token: 0x60007A4
        private virtual System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }
        // RVA: 0x092D3A98  token: 0x60007A5
        public Newtonsoft.Json.JsonReader CreateReader() { }
        // RVA: 0x02692F80  token: 0x60007A6
        private static Newtonsoft.Json.Linq.JToken FromObjectInternal(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        // RVA: 0x092D3BC4  token: 0x60007A7
        public static Newtonsoft.Json.Linq.JToken FromObject(System.Object o) { }
        // RVA: -1  // generic def  token: 0x60007A8
        public T ToObject() { }
        // RVA: 0x03973740  token: 0x60007A9
        public System.Object ToObject(System.Type objectType) { }
        // RVA: 0x039739E0  token: 0x60007AA
        public System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        // RVA: 0x092D4424  token: 0x60007AB
        public static Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x092D40D0  token: 0x60007AC
        public static Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x092D4084  token: 0x60007AD
        public static Newtonsoft.Json.Linq.JToken Parse(System.String json) { }
        // RVA: 0x092D3EFC  token: 0x60007AE
        public static Newtonsoft.Json.Linq.JToken Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x092D3DD8  token: 0x60007AF
        public static Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x02698D70  token: 0x60007B0
        private System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        // RVA: 0x02698F00  token: 0x60007B1
        private System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        // RVA: 0x092D3E34  token: 0x60007B2
        private virtual System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }
        // RVA: 0x092D3C1C  token: 0x60007B5
        protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        // RVA: 0x092D4604  token: 0x60007B6
        private virtual System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        // RVA: 0x092D3AF8  token: 0x60007B7
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x092D3AF8  token: 0x60007B8
        public Newtonsoft.Json.Linq.JToken DeepClone() { }
        // RVA: 0x02698F70  token: 0x60007B9
        public System.Void AddAnnotation(System.Object annotation) { }
        // RVA: -1  // generic def  token: 0x60007BA
        public T Annotation() { }
        // RVA: 0x092D3A0C  token: 0x60007BB
        private System.Void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source) { }
        // RVA: 0x025634E0  token: 0x60007BC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000F3  // size: 0x98
    public class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JToken _root;  // 0x78
        private System.String _initialPath;  // 0x80
        private Newtonsoft.Json.Linq.JToken _parent;  // 0x88
        private Newtonsoft.Json.Linq.JToken _current;  // 0x90

        // Properties
        Newtonsoft.Json.Linq.JToken CurrentToken { get; /* RVA: 0x03D4EA90 */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LineNumber { get; /* RVA: 0x092D2C04 */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LinePosition { get; /* RVA: 0x092D2C2C */ }
        System.String Path { get; /* RVA: 0x092D2CA4 */ }

        // Methods
        // RVA: 0x03973EF0  token: 0x60007BF
        public System.Void .ctor(Newtonsoft.Json.Linq.JToken token) { }
        // RVA: 0x036E2930  token: 0x60007C0
        public virtual System.Boolean Read() { }
        // RVA: 0x036E2C70  token: 0x60007C1
        private System.Boolean ReadOver(Newtonsoft.Json.Linq.JToken t) { }
        // RVA: 0x092D2C54  token: 0x60007C2
        private System.Boolean ReadToEnd() { }
        // RVA: 0x036E2DD0  token: 0x60007C3
        private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c) { }
        // RVA: 0x036E2A00  token: 0x60007C4
        private System.Boolean ReadInto(Newtonsoft.Json.Linq.JContainer c) { }
        // RVA: 0x036E2D30  token: 0x60007C5
        private System.Boolean SetEnd(Newtonsoft.Json.Linq.JContainer c) { }
        // RVA: 0x036E2A80  token: 0x60007C6
        private System.Void SetToken(Newtonsoft.Json.Linq.JToken token) { }
        // RVA: 0x092D2C88  token: 0x60007C7
        private System.String SafeToString(System.Object value) { }
        // RVA: 0x092D2BDC  token: 0x60007C8
        private virtual System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

    }

    // TypeToken: 0x20000F4  // size: 0x14
    public sealed struct JTokenType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Linq.JTokenType None;  // const
        public static Newtonsoft.Json.Linq.JTokenType Object;  // const
        public static Newtonsoft.Json.Linq.JTokenType Array;  // const
        public static Newtonsoft.Json.Linq.JTokenType Constructor;  // const
        public static Newtonsoft.Json.Linq.JTokenType Property;  // const
        public static Newtonsoft.Json.Linq.JTokenType Comment;  // const
        public static Newtonsoft.Json.Linq.JTokenType Integer;  // const
        public static Newtonsoft.Json.Linq.JTokenType Float;  // const
        public static Newtonsoft.Json.Linq.JTokenType String;  // const
        public static Newtonsoft.Json.Linq.JTokenType Boolean;  // const
        public static Newtonsoft.Json.Linq.JTokenType Null;  // const
        public static Newtonsoft.Json.Linq.JTokenType Undefined;  // const
        public static Newtonsoft.Json.Linq.JTokenType Date;  // const
        public static Newtonsoft.Json.Linq.JTokenType Raw;  // const
        public static Newtonsoft.Json.Linq.JTokenType Bytes;  // const
        public static Newtonsoft.Json.Linq.JTokenType Guid;  // const
        public static Newtonsoft.Json.Linq.JTokenType Uri;  // const
        public static Newtonsoft.Json.Linq.JTokenType TimeSpan;  // const

    }

    // TypeToken: 0x20000F5  // size: 0x80
    public class JTokenWriter : Newtonsoft.Json.JsonWriter
    {
        // Fields
        private Newtonsoft.Json.Linq.JContainer _token;  // 0x60
        private Newtonsoft.Json.Linq.JContainer _parent;  // 0x68
        private Newtonsoft.Json.Linq.JValue _value;  // 0x70
        private Newtonsoft.Json.Linq.JToken _current;  // 0x78

        // Properties
        Newtonsoft.Json.Linq.JToken Token { get; /* RVA: 0x026938A0 */ }

        // Methods
        // RVA: 0x026938C0  token: 0x60007CD
        public System.Void .ctor() { }
        // RVA: 0x025EE630  token: 0x60007CE
        public virtual System.Void Close() { }
        // RVA: 0x02697390  token: 0x60007CF
        public virtual System.Void WriteStartObject() { }
        // RVA: 0x02697D10  token: 0x60007D0
        private System.Void AddParent(Newtonsoft.Json.Linq.JContainer container) { }
        // RVA: 0x037B8D90  token: 0x60007D1
        private System.Void RemoveParent() { }
        // RVA: 0x02697B20  token: 0x60007D2
        public virtual System.Void WriteStartArray() { }
        // RVA: 0x092D2F18  token: 0x60007D3
        public virtual System.Void WriteStartConstructor(System.String name) { }
        // RVA: 0x037B8D80  token: 0x60007D4
        protected virtual System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x02697C30  token: 0x60007D5
        public virtual System.Void WritePropertyName(System.String name) { }
        // RVA: 0x092D2D84  token: 0x60007D6
        private System.Void AddRawValue(System.Object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x0269A9B0  token: 0x60007D7
        private System.Void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x092D3368  token: 0x60007D8
        public virtual System.Void WriteValue(System.Object value) { }
        // RVA: 0x092D2E64  token: 0x60007D9
        public virtual System.Void WriteNull() { }
        // RVA: 0x092D2F9C  token: 0x60007DA
        public virtual System.Void WriteUndefined() { }
        // RVA: 0x092D2E9C  token: 0x60007DB
        public virtual System.Void WriteRaw(System.String json) { }
        // RVA: 0x092D2E1C  token: 0x60007DC
        public virtual System.Void WriteComment(System.String text) { }
        // RVA: 0x0269A910  token: 0x60007DD
        public virtual System.Void WriteValue(System.String value) { }
        // RVA: 0x092D33EC  token: 0x60007DE
        public virtual System.Void WriteValue(System.Int32 value) { }
        // RVA: 0x092D30BC  token: 0x60007DF
        public virtual System.Void WriteValue(System.UInt32 value) { }
        // RVA: 0x0269AA70  token: 0x60007E0
        public virtual System.Void WriteValue(System.Int64 value) { }
        // RVA: 0x092D3258  token: 0x60007E1
        public virtual System.Void WriteValue(System.UInt64 value) { }
        // RVA: 0x092D31D0  token: 0x60007E2
        public virtual System.Void WriteValue(System.Single value) { }
        // RVA: 0x092D3880  token: 0x60007E3
        public virtual System.Void WriteValue(System.Double value) { }
        // RVA: 0x03741100  token: 0x60007E4
        public virtual System.Void WriteValue(System.Boolean value) { }
        // RVA: 0x092D372C  token: 0x60007E5
        public virtual System.Void WriteValue(System.Int16 value) { }
        // RVA: 0x092D362C  token: 0x60007E6
        public virtual System.Void WriteValue(System.UInt16 value) { }
        // RVA: 0x092D37A4  token: 0x60007E7
        public virtual System.Void WriteValue(System.Char value) { }
        // RVA: 0x092D3048  token: 0x60007E8
        public virtual System.Void WriteValue(System.Byte value) { }
        // RVA: 0x092D2FD4  token: 0x60007E9
        public virtual System.Void WriteValue(System.SByte value) { }
        // RVA: 0x092D3130  token: 0x60007EA
        public virtual System.Void WriteValue(System.Decimal value) { }
        // RVA: 0x092D3908  token: 0x60007EB
        public virtual System.Void WriteValue(System.DateTime value) { }
        // RVA: 0x092D358C  token: 0x60007EC
        public virtual System.Void WriteValue(System.DateTimeOffset value) { }
        // RVA: 0x092D3460  token: 0x60007ED
        public virtual System.Void WriteValue(System.Byte[] value) { }
        // RVA: 0x092D36A4  token: 0x60007EE
        public virtual System.Void WriteValue(System.TimeSpan value) { }
        // RVA: 0x092D34EC  token: 0x60007EF
        public virtual System.Void WriteValue(System.Guid value) { }
        // RVA: 0x092D32E0  token: 0x60007F0
        public virtual System.Void WriteValue(System.Uri value) { }
        // RVA: 0x0269A1E0  token: 0x60007F1
        private virtual System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments) { }

    }

    // TypeToken: 0x20000F6  // size: 0x40
    public class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable`1, System.IFormattable, System.IComparable, System.IComparable`1, System.IConvertible
    {
        // Fields
        private Newtonsoft.Json.Linq.JTokenType _valueType;  // 0x30
        private System.Object _value;  // 0x38

        // Properties
        System.Boolean HasValues { get; /* RVA: 0x0115F4C0 */ }
        Newtonsoft.Json.Linq.JTokenType Type { get; /* RVA: 0x03D4ED20 */ }
        System.Object Value { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x0269AB80  token: 0x60007F2
        private System.Void .ctor(System.Object value, Newtonsoft.Json.Linq.JTokenType type) { }
        // RVA: 0x092DB950  token: 0x60007F3
        private System.Void .ctor(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x0269AB10  token: 0x60007F4
        public System.Void .ctor(System.Int64 value) { }
        // RVA: 0x092DBB28  token: 0x60007F5
        public System.Void .ctor(System.Decimal value) { }
        // RVA: 0x092DB7D0  token: 0x60007F6
        public System.Void .ctor(System.UInt64 value) { }
        // RVA: 0x092DB830  token: 0x60007F7
        public System.Void .ctor(System.Double value) { }
        // RVA: 0x092DBA00  token: 0x60007F8
        public System.Void .ctor(System.Single value) { }
        // RVA: 0x092DB890  token: 0x60007F9
        public System.Void .ctor(System.DateTime value) { }
        // RVA: 0x092DBB94  token: 0x60007FA
        public System.Void .ctor(System.DateTimeOffset value) { }
        // RVA: 0x037411A0  token: 0x60007FB
        public System.Void .ctor(System.Boolean value) { }
        // RVA: 0x042711C8  token: 0x60007FC
        public System.Void .ctor(System.String value) { }
        // RVA: 0x092DBAC4  token: 0x60007FD
        public System.Void .ctor(System.Guid value) { }
        // RVA: 0x092DBA60  token: 0x60007FE
        public System.Void .ctor(System.Uri value) { }
        // RVA: 0x092DB8F0  token: 0x60007FF
        public System.Void .ctor(System.TimeSpan value) { }
        // RVA: 0x02699D80  token: 0x6000800
        public System.Void .ctor(System.Object value) { }
        // RVA: 0x092D9BB8  token: 0x6000802
        private static System.Int32 CompareBigInteger(System.Numerics.BigInteger i1, System.Object i2) { }
        // RVA: 0x092D9EF0  token: 0x6000803
        private static System.Int32 Compare(Newtonsoft.Json.Linq.JTokenType valueType, System.Object objA, System.Object objB) { }
        // RVA: 0x092D9DE4  token: 0x6000804
        private static System.Int32 CompareFloat(System.Object objA, System.Object objB) { }
        // RVA: 0x092DAA5C  token: 0x6000805
        private static System.Boolean Operation(System.Linq.Expressions.ExpressionType operation, System.Object objA, System.Object objB, System.Object& result) { }
        // RVA: 0x092D9B48  token: 0x6000806
        private virtual Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        // RVA: 0x092DA7EC  token: 0x6000807
        public static Newtonsoft.Json.Linq.JValue CreateComment(System.String value) { }
        // RVA: 0x092DA850  token: 0x6000808
        public static Newtonsoft.Json.Linq.JValue CreateNull() { }
        // RVA: 0x092DA8A8  token: 0x6000809
        public static Newtonsoft.Json.Linq.JValue CreateUndefined() { }
        // RVA: 0x02699DC0  token: 0x600080A
        private static Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, System.Object value) { }
        // RVA: 0x038BA8D0  token: 0x600080B
        private static Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }
        // RVA: 0x02697EF0  token: 0x600080E
        public virtual System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        // RVA: 0x092DB788  token: 0x600080F
        private static System.Boolean ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2) { }
        // RVA: 0x092DA95C  token: 0x6000810
        public virtual System.Boolean Equals(Newtonsoft.Json.Linq.JValue other) { }
        // RVA: 0x092DA900  token: 0x6000811
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x092DA978  token: 0x6000812
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x03D1E910  token: 0x6000813
        public virtual System.String ToString() { }
        // RVA: 0x092DB778  token: 0x6000814
        public virtual System.String ToString(System.IFormatProvider formatProvider) { }
        // RVA: 0x092DB6CC  token: 0x6000815
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x092DA9A0  token: 0x6000816
        protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        // RVA: 0x092DB1A4  token: 0x6000817
        private virtual System.Int32 System.IComparable.CompareTo(System.Object obj) { }
        // RVA: 0x092D9EBC  token: 0x6000818
        public virtual System.Int32 CompareTo(Newtonsoft.Json.Linq.JValue obj) { }
        // RVA: 0x092DB228  token: 0x6000819
        private virtual System.TypeCode System.IConvertible.GetTypeCode() { }
        // RVA: 0x092DB288  token: 0x600081A
        private virtual System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider) { }
        // RVA: 0x092DB320  token: 0x600081B
        private virtual System.Char System.IConvertible.ToChar(System.IFormatProvider provider) { }
        // RVA: 0x092DB548  token: 0x600081C
        private virtual System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider) { }
        // RVA: 0x092DB2D4  token: 0x600081D
        private virtual System.Byte System.IConvertible.ToByte(System.IFormatProvider provider) { }
        // RVA: 0x092DB464  token: 0x600081E
        private virtual System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider) { }
        // RVA: 0x092DB5E8  token: 0x600081F
        private virtual System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider) { }
        // RVA: 0x092DB4B0  token: 0x6000820
        private virtual System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider) { }
        // RVA: 0x092DB634  token: 0x6000821
        private virtual System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider) { }
        // RVA: 0x092DB4FC  token: 0x6000822
        private virtual System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider) { }
        // RVA: 0x092DB680  token: 0x6000823
        private virtual System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider) { }
        // RVA: 0x092DB594  token: 0x6000824
        private virtual System.Single System.IConvertible.ToSingle(System.IFormatProvider provider) { }
        // RVA: 0x092DB418  token: 0x6000825
        private virtual System.Double System.IConvertible.ToDouble(System.IFormatProvider provider) { }
        // RVA: 0x092DB3B8  token: 0x6000826
        private virtual System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { }
        // RVA: 0x092DB36C  token: 0x6000827
        private virtual System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { }
        // RVA: 0x092DB5E0  token: 0x6000828
        private virtual System.Object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider) { }

    }

    // TypeToken: 0x20000F8  // size: 0x14
    public sealed struct LineInfoHandling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Linq.LineInfoHandling Ignore;  // const
        public static Newtonsoft.Json.Linq.LineInfoHandling Load;  // const

    }

}

namespace Newtonsoft.Json.Serialization
{

    // TypeToken: 0x200009C
    public static class CachedAttributeGetter`1
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000422
        public static T GetAttribute(System.Object type) { }
        // RVA: -1  // not resolved  token: 0x6000423
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009D  // size: 0x18
    public class CamelCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
    {
        // Methods
        // RVA: 0x03D714A0  token: 0x6000424
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        // RVA: 0x03D71490  token: 0x6000425
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        // RVA: 0x0350B670  token: 0x6000426
        public System.Void .ctor() { }
        // RVA: 0x092B976C  token: 0x6000427
        protected virtual System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x200009E  // size: 0x38
    public class DefaultContractResolver : Newtonsoft.Json.Serialization.IContractResolver
    {
        // Fields
        private static readonly Newtonsoft.Json.Serialization.IContractResolver _instance;  // static @ 0x0
        private static readonly System.String[] BlacklistedTypeNames;  // static @ 0x8
        private static readonly Newtonsoft.Json.JsonConverter[] BuiltInConverters;  // static @ 0x10
        private readonly Newtonsoft.Json.DefaultJsonNameTable _nameTable;  // 0x10
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Serialization.JsonContract> _contractCache;  // 0x18
        private System.Reflection.BindingFlags <DefaultMembersSearchFlags>k__BackingField;  // 0x20
        private System.Boolean <SerializeCompilerGeneratedMembers>k__BackingField;  // 0x24
        private System.Boolean <IgnoreSerializableInterface>k__BackingField;  // 0x25
        private System.Boolean <IgnoreSerializableAttribute>k__BackingField;  // 0x26
        private System.Boolean <IgnoreIsSpecifiedMembers>k__BackingField;  // 0x27
        private System.Boolean <IgnoreShouldSerializeMembers>k__BackingField;  // 0x28
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;  // 0x30

        // Properties
        Newtonsoft.Json.Serialization.IContractResolver Instance { get; /* RVA: 0x092BFF8C */ }
        System.Reflection.BindingFlags DefaultMembersSearchFlags { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }
        System.Boolean SerializeCompilerGeneratedMembers { get; /* RVA: 0x03D4F090 */ }
        System.Boolean IgnoreSerializableInterface { get; /* RVA: 0x03D4F130 */ }
        System.Boolean IgnoreSerializableAttribute { get; /* RVA: 0x03D4F140 */ set; /* RVA: 0x03D4F160 */ }
        System.Boolean IgnoreIsSpecifiedMembers { get; /* RVA: 0x03D714B0 */ }
        System.Boolean IgnoreShouldSerializeMembers { get; /* RVA: 0x03D4ED50 */ }
        Newtonsoft.Json.Serialization.NamingStrategy NamingStrategy { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x03702E30  token: 0x6000433
        public System.Void .ctor() { }
        // RVA: 0x027BE670  token: 0x6000434
        public virtual Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { }
        // RVA: 0x024789A0  token: 0x6000435
        private static System.Boolean FilterMembers(System.Reflection.MemberInfo member) { }
        // RVA: 0x025E2100  token: 0x6000436
        protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType) { }
        // RVA: 0x092BFE28  token: 0x6000437
        private System.Boolean ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x0283DAA0  token: 0x6000438
        protected virtual Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType) { }
        // RVA: 0x092BFEE4  token: 0x6000439
        private static System.Void ThrowUnableToSerializeError(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x0283DF90  token: 0x600043A
        private System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type) { }
        // RVA: 0x092BF5F8  token: 0x600043B
        private static System.Void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member) { }
        // RVA: 0x0283D870  token: 0x600043C
        private System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType) { }
        // RVA: 0x034F8430  token: 0x600043D
        private System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { }
        // RVA: 0x03D1BC00  token: 0x600043E
        private System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType) { }
        // RVA: 0x034F8300  token: 0x600043F
        protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { }
        // RVA: 0x034F85B0  token: 0x6000440
        private Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, System.String name, System.Type type) { }
        // RVA: 0x034F8660  token: 0x6000441
        protected virtual Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo) { }
        // RVA: 0x02475BE0  token: 0x6000442
        protected virtual Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType) { }
        // RVA: 0x02475E40  token: 0x6000443
        private System.Func<System.Object> GetDefaultCreator(System.Type createdType) { }
        // RVA: 0x02475960  token: 0x6000444
        private System.Void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract) { }
        // RVA: 0x02475C30  token: 0x6000445
        private System.Void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t) { }
        // RVA: 0x0253F8D0  token: 0x6000446
        private System.Void GetCallbackMethodsForType(System.Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }
        // RVA: 0x024782C0  token: 0x6000447
        private static System.Boolean IsConcurrentOrObservableCollection(System.Type t) { }
        // RVA: 0x02478080  token: 0x6000448
        private static System.Boolean ShouldSkipDeserialized(System.Type t) { }
        // RVA: 0x024781A0  token: 0x6000449
        private static System.Boolean ShouldSkipSerializing(System.Type t) { }
        // RVA: 0x0283F850  token: 0x600044A
        private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type) { }
        // RVA: 0x0308E0C0  token: 0x600044B
        protected virtual Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType) { }
        // RVA: 0x0308D520  token: 0x600044C
        protected virtual Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType) { }
        // RVA: 0x03439DA0  token: 0x600044D
        protected virtual Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) { }
        // RVA: 0x03CF60E0  token: 0x600044E
        protected virtual Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType) { }
        // RVA: 0x092BF324  token: 0x600044F
        protected virtual Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType) { }
        // RVA: 0x092BF134  token: 0x6000450
        protected virtual Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType) { }
        // RVA: 0x03439CB0  token: 0x6000451
        protected virtual Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType) { }
        // RVA: 0x024772C0  token: 0x6000452
        protected virtual Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType) { }
        // RVA: 0x02476C30  token: 0x6000453
        private static System.Boolean IsJsonPrimitiveType(System.Type t) { }
        // RVA: 0x033576D0  token: 0x6000454
        private static System.Boolean IsIConvertible(System.Type t) { }
        // RVA: 0x02475590  token: 0x6000455
        private static System.Boolean CanConvertToString(System.Type type) { }
        // RVA: 0x02540F30  token: 0x6000456
        private static System.Boolean IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, System.Type& prevAttributeType) { }
        // RVA: 0x092BF500  token: 0x6000457
        private static System.String GetClrTypeFullName(System.Type type) { }
        // RVA: 0x024E60C0  token: 0x6000458
        protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization) { }
        // RVA: 0x020B7B20  token: 0x6000459
        private virtual Newtonsoft.Json.DefaultJsonNameTable GetNameTable() { }
        // RVA: 0x024E5770  token: 0x600045A
        protected virtual Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member) { }
        // RVA: 0x024E5330  token: 0x600045B
        protected virtual Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization) { }
        // RVA: 0x024E6AB0  token: 0x600045C
        private System.Void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, System.Object attributeProvider, System.String name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, System.Boolean& allowNonPublicAccess) { }
        // RVA: 0x024E5960  token: 0x600045D
        private System.Predicate<System.Object> CreateShouldSerializeTest(System.Reflection.MemberInfo member) { }
        // RVA: 0x024E4A20  token: 0x600045E
        private System.Void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, System.Boolean allowNonPublicAccess) { }
        // RVA: 0x024E71A0  token: 0x600045F
        protected virtual System.String ResolvePropertyName(System.String propertyName) { }
        // RVA: 0x092BF5DC  token: 0x6000460
        protected virtual System.String ResolveExtensionDataName(System.String extensionDataName) { }
        // RVA: 0x039B9B50  token: 0x6000461
        protected virtual System.String ResolveDictionaryKey(System.String dictionaryKey) { }
        // RVA: 0x092BF5D4  token: 0x6000462
        public System.String GetResolvedPropertyName(System.String propertyName) { }
        // RVA: 0x037029F0  token: 0x6000463
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AA  // size: 0x18
    public class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
    {
        // Methods
        // RVA: 0x03D51810  token: 0x6000485
        protected virtual System.String ResolvePropertyName(System.String name) { }
        // RVA: 0x0350B670  token: 0x6000486
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AB  // size: 0x18
    public class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
    {
        // Fields
        private System.Int32 _referenceCount;  // 0x10

        // Methods
        // RVA: 0x092C4774  token: 0x6000487
        private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(System.Object context) { }
        // RVA: 0x092C499C  token: 0x6000488
        public virtual System.Object ResolveReference(System.Object context, System.String reference) { }
        // RVA: 0x092C4840  token: 0x6000489
        public virtual System.String GetReference(System.Object context, System.Object value) { }
        // RVA: 0x092C46F4  token: 0x600048A
        public virtual System.Void AddReference(System.Object context, System.String reference, System.Object value) { }
        // RVA: 0x092C4920  token: 0x600048B
        public virtual System.Boolean IsReferenced(System.Object context, System.Object value) { }
        // RVA: 0x0350B670  token: 0x600048C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0x18
    public class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
    {
        // Fields
        private static readonly Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;  // static @ 0x0
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache;  // 0x10

        // Methods
        // RVA: 0x03B38AE0  token: 0x600048D
        public System.Void .ctor() { }
        // RVA: 0x02679EE0  token: 0x600048E
        private System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }
        // RVA: 0x092C4A90  token: 0x600048F
        private System.Type GetGenericTypeFromTypeName(System.String typeName, System.Reflection.Assembly assembly) { }
        // RVA: 0x027BCF80  token: 0x6000490
        private System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }
        // RVA: 0x027BCEC0  token: 0x6000491
        public virtual System.Type BindToType(System.String assemblyName, System.String typeName) { }
        // RVA: 0x092C4A1C  token: 0x6000492
        public virtual System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName) { }
        // RVA: 0x03B38A70  token: 0x6000493
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x40
    public class ErrorContext
    {
        // Fields
        private System.Boolean <Traced>k__BackingField;  // 0x10
        private readonly System.Exception <Error>k__BackingField;  // 0x18
        private readonly System.Object <OriginalObject>k__BackingField;  // 0x20
        private readonly System.Object <Member>k__BackingField;  // 0x28
        private readonly System.String <Path>k__BackingField;  // 0x30
        private System.Boolean <Handled>k__BackingField;  // 0x38

        // Properties
        System.Boolean Traced { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.Exception Error { get; /* RVA: 0x01041090 */ }
        System.Boolean Handled { get; /* RVA: 0x03D4F190 */ }

        // Methods
        // RVA: 0x092C4CA0  token: 0x6000494
        private System.Void .ctor(System.Object originalObject, System.Object member, System.String path, System.Exception error) { }

    }

    // TypeToken: 0x20000AE  // size: 0x20
    public class ErrorEventArgs : System.EventArgs
    {
        // Fields
        private readonly System.Object <CurrentObject>k__BackingField;  // 0x10
        private readonly Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;  // 0x18

        // Methods
        // RVA: 0x092C4CE8  token: 0x6000499
        public System.Void .ctor(System.Object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }

    }

    // TypeToken: 0x20000AF
    public interface IAttributeProvider
    {
    }

    // TypeToken: 0x20000B0
    public interface IContractResolver
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600049A
        public virtual Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { }

    }

    // TypeToken: 0x20000B1
    public interface IReferenceResolver
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600049B
        public virtual System.Object ResolveReference(System.Object context, System.String reference) { }
        // RVA: -1  // abstract  token: 0x600049C
        public virtual System.String GetReference(System.Object context, System.Object value) { }
        // RVA: -1  // abstract  token: 0x600049D
        public virtual System.Boolean IsReferenced(System.Object context, System.Object value) { }
        // RVA: -1  // abstract  token: 0x600049E
        public virtual System.Void AddReference(System.Object context, System.String reference, System.Object value) { }

    }

    // TypeToken: 0x20000B2
    public interface ISerializationBinder
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600049F
        public virtual System.Type BindToType(System.String assemblyName, System.String typeName) { }
        // RVA: -1  // abstract  token: 0x60004A0
        public virtual System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName) { }

    }

    // TypeToken: 0x20000B3
    public interface ITraceWriter
    {
        // Properties
        System.Diagnostics.TraceLevel LevelFilter { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60004A2
        public virtual System.Void Trace(System.Diagnostics.TraceLevel level, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x20000B4
    public interface IValueProvider
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60004A3
        public virtual System.Void SetValue(System.Object target, System.Object value) { }
        // RVA: -1  // abstract  token: 0x60004A4
        public virtual System.Object GetValue(System.Object target) { }

    }

    // TypeToken: 0x20000B5  // size: 0x118
    public class JsonArrayContract : Newtonsoft.Json.Serialization.JsonContainerContract
    {
        // Fields
        private readonly System.Type <CollectionItemType>k__BackingField;  // 0xc0
        private readonly System.Boolean <IsMultidimensionalArray>k__BackingField;  // 0xc8
        private readonly System.Type _genericCollectionDefinitionType;  // 0xd0
        private System.Type _genericWrapperType;  // 0xd8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator;  // 0xe0
        private System.Func<System.Object> _genericTemporaryCollectionCreator;  // 0xe8
        private readonly System.Boolean <IsArray>k__BackingField;  // 0xf0
        private readonly System.Boolean <ShouldCreateWrapper>k__BackingField;  // 0xf1
        private System.Boolean <CanDeserialize>k__BackingField;  // 0xf2
        private readonly System.Reflection.ConstructorInfo _parameterizedConstructor;  // 0xf8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;  // 0x100
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;  // 0x108
        private System.Boolean <HasParameterizedCreator>k__BackingField;  // 0x110

        // Properties
        System.Type CollectionItemType { get; /* RVA: 0x03D50E60 */ }
        System.Boolean IsMultidimensionalArray { get; /* RVA: 0x03D519D0 */ }
        System.Boolean IsArray { get; /* RVA: 0x03D57D50 */ }
        System.Boolean ShouldCreateWrapper { get; /* RVA: 0x03D57BD0 */ }
        System.Boolean CanDeserialize { get; /* RVA: 0x03D714C0 */ set; /* RVA: 0x03D714D0 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ParameterizedCreator { get; /* RVA: 0x092C4F54 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> OverrideCreator { get; /* RVA: 0x03D56D30 */ set; /* RVA: 0x092C500C */ }
        System.Boolean HasParameterizedCreator { get; /* RVA: 0x03D57AB0 */ set; /* RVA: 0x03D5B8E0 */ }
        System.Boolean HasParameterizedCreatorInternal { get; /* RVA: 0x0247A150 */ }

        // Methods
        // RVA: 0x0308D650  token: 0x60004B1
        public System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x0308F160  token: 0x60004B2
        private Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(System.Object list) { }
        // RVA: 0x024E7E80  token: 0x60004B3
        private System.Collections.IList CreateTemporaryCollection() { }
        // RVA: 0x092C4E7C  token: 0x60004B4
        private System.Void StoreFSharpListCreatorIfNecessary(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000B6  // size: 0xC0
    public class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
    {
        // Fields
        private Newtonsoft.Json.Serialization.JsonContract _itemContract;  // 0x90
        private Newtonsoft.Json.Serialization.JsonContract _finalItemContract;  // 0x98
        private Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;  // 0xa0
        private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField;  // 0xa8
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;  // 0xac
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;  // 0xb4

        // Properties
        Newtonsoft.Json.Serialization.JsonContract ItemContract { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x02474FC0 */ }
        Newtonsoft.Json.Serialization.JsonContract FinalItemContract { get; /* RVA: 0x011AC510 */ }
        Newtonsoft.Json.JsonConverter ItemConverter { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x04270264 */ }
        System.Nullable<System.Boolean> ItemIsReference { get; /* RVA: 0x03D714E0 */ set; /* RVA: 0x03D71510 */ }
        System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> ItemReferenceLoopHandling { get; /* RVA: 0x03D714F0 */ set; /* RVA: 0x03D71520 */ }
        System.Nullable<Newtonsoft.Json.TypeNameHandling> ItemTypeNameHandling { get; /* RVA: 0x03D71500 */ set; /* RVA: 0x03D71530 */ }

        // Methods
        // RVA: 0x02475860  token: 0x60004C0
        private System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000B7  // size: 0x14
    public sealed struct JsonContractType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Serialization.JsonContractType None;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Object;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Array;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Primitive;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType String;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Dictionary;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Dynamic;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Serializable;  // const
        public static Newtonsoft.Json.Serialization.JsonContractType Linq;  // const

    }

    // TypeToken: 0x20000B8  // size: 0x80
    public sealed class SerializationCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x036E5EB0  token: 0x60004C1
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x029CE1E0  token: 0x60004C2
        public virtual System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x20000B9  // size: 0x80
    public sealed class SerializationErrorCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x080B2174  token: 0x60004C3
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500800C  token: 0x60004C4
        public virtual System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }

    }

    // TypeToken: 0x20000BA  // size: 0x80
    public sealed class ExtensionDataSetter : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x092C4D54  token: 0x60004C5
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x60004C6
        public virtual System.Void Invoke(System.Object o, System.String key, System.Object value) { }

    }

    // TypeToken: 0x20000BB  // size: 0x80
    public sealed class ExtensionDataGetter : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06E65E38  token: 0x60004C7
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0102B410  token: 0x60004C8
        public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(System.Object o) { }

    }

    // TypeToken: 0x20000BC  // size: 0x90
    public abstract class JsonContract
    {
        // Fields
        private System.Boolean IsNullable;  // 0x10
        private System.Boolean IsConvertable;  // 0x11
        private System.Boolean IsEnum;  // 0x12
        private System.Type NonNullableUnderlyingType;  // 0x18
        private Newtonsoft.Json.ReadType InternalReadType;  // 0x20
        private Newtonsoft.Json.Serialization.JsonContractType ContractType;  // 0x24
        private System.Boolean IsReadOnlyOrFixedSize;  // 0x28
        private System.Boolean IsSealed;  // 0x29
        private System.Boolean IsInstantiable;  // 0x2a
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks;  // 0x30
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks;  // 0x38
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks;  // 0x40
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks;  // 0x48
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks;  // 0x50
        private System.Type _createdType;  // 0x58
        private readonly System.Type <UnderlyingType>k__BackingField;  // 0x60
        private System.Nullable<System.Boolean> <IsReference>k__BackingField;  // 0x68
        private Newtonsoft.Json.JsonConverter <Converter>k__BackingField;  // 0x70
        private Newtonsoft.Json.JsonConverter <InternalConverter>k__BackingField;  // 0x78
        private System.Func<System.Object> <DefaultCreator>k__BackingField;  // 0x80
        private System.Boolean <DefaultCreatorNonPublic>k__BackingField;  // 0x88

        // Properties
        System.Type UnderlyingType { get; /* RVA: 0x03D4EB00 */ }
        System.Type CreatedType { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x02476B80 */ }
        System.Nullable<System.Boolean> IsReference { get; /* RVA: 0x03D71540 */ set; /* RVA: 0x03D71550 */ }
        Newtonsoft.Json.JsonConverter Converter { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        Newtonsoft.Json.JsonConverter InternalConverter { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> OnDeserializedCallbacks { get; /* RVA: 0x03152300 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> OnDeserializingCallbacks { get; /* RVA: 0x092C5234 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> OnSerializedCallbacks { get; /* RVA: 0x092C52B8 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> OnSerializingCallbacks { get; /* RVA: 0x03152270 */ }
        System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> OnErrorCallbacks { get; /* RVA: 0x031527C0 */ }
        System.Func<System.Object> DefaultCreator { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }
        System.Boolean DefaultCreatorNonPublic { get; /* RVA: 0x03D51D50 */ set; /* RVA: 0x03D56D40 */ }

        // Methods
        // RVA: 0x024776F0  token: 0x60004DB
        private System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x027B9260  token: 0x60004DC
        private System.Void InvokeOnSerializing(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x027B9420  token: 0x60004DD
        private System.Void InvokeOnSerialized(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x02B39290  token: 0x60004DE
        private System.Void InvokeOnDeserializing(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x024E9D40  token: 0x60004DF
        private System.Void InvokeOnDeserialized(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x092C50D4  token: 0x60004E0
        private System.Void InvokeOnError(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }
        // RVA: 0x036E5E00  token: 0x60004E1
        private static Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo) { }
        // RVA: 0x092C5034  token: 0x60004E2
        private static Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo) { }

    }

    // TypeToken: 0x20000BF  // size: 0x128
    public class JsonDictionaryContract : Newtonsoft.Json.Serialization.JsonContainerContract
    {
        // Fields
        private System.Func<System.String,System.String> <DictionaryKeyResolver>k__BackingField;  // 0xc0
        private readonly System.Type <DictionaryKeyType>k__BackingField;  // 0xc8
        private readonly System.Type <DictionaryValueType>k__BackingField;  // 0xd0
        private Newtonsoft.Json.Serialization.JsonContract <KeyContract>k__BackingField;  // 0xd8
        private readonly System.Type _genericCollectionDefinitionType;  // 0xe0
        private System.Type _genericWrapperType;  // 0xe8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator;  // 0xf0
        private System.Func<System.Object> _genericTemporaryDictionaryCreator;  // 0xf8
        private readonly System.Boolean <ShouldCreateWrapper>k__BackingField;  // 0x100
        private readonly System.Reflection.ConstructorInfo _parameterizedConstructor;  // 0x108
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;  // 0x110
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;  // 0x118
        private System.Boolean <HasParameterizedCreator>k__BackingField;  // 0x120

        // Properties
        System.Func<System.String,System.String> DictionaryKeyResolver { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }
        System.Type DictionaryKeyType { get; /* RVA: 0x03D4E7C0 */ }
        System.Type DictionaryValueType { get; /* RVA: 0x03D50050 */ }
        Newtonsoft.Json.Serialization.JsonContract KeyContract { get; /* RVA: 0x03D4E7B0 */ set; /* RVA: 0x05142FC4 */ }
        System.Boolean ShouldCreateWrapper { get; /* RVA: 0x03D56750 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ParameterizedCreator { get; /* RVA: 0x092C5758 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> OverrideCreator { get; /* RVA: 0x03D56CF0 */ set; /* RVA: 0x04275CF4 */ }
        System.Boolean HasParameterizedCreator { get; /* RVA: 0x03D57B30 */ set; /* RVA: 0x03D5A200 */ }
        System.Boolean HasParameterizedCreatorInternal { get; /* RVA: 0x0308EDB0 */ }

        // Methods
        // RVA: 0x0308E2E0  token: 0x60004F4
        public System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x092C5518  token: 0x60004F5
        private Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(System.Object dictionary) { }
        // RVA: 0x092C533C  token: 0x60004F6
        private System.Collections.IDictionary CreateTemporaryDictionary() { }

    }

    // TypeToken: 0x20000C0  // size: 0xE0
    public class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;  // 0xc0
        private System.Func<System.String,System.String> <PropertyNameResolver>k__BackingField;  // 0xc8
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>>> _callSiteGetters;  // 0xd0
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>>> _callSiteSetters;  // 0xd8

        // Properties
        Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { get; /* RVA: 0x03D50E60 */ }
        System.Func<System.String,System.String> PropertyNameResolver { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x058B4280 */ }

        // Methods
        // RVA: 0x092C5810  token: 0x60004FA
        private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(System.String name) { }
        // RVA: 0x092C58E8  token: 0x60004FB
        private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(System.String name) { }
        // RVA: 0x092C5C18  token: 0x60004FC
        public System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x092C59C0  token: 0x60004FD
        private System.Boolean TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object& value) { }
        // RVA: 0x092C5AF4  token: 0x60004FE
        private System.Boolean TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object value) { }

    }

    // TypeToken: 0x20000C1  // size: 0x28
    public class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;  // 0x10
        private readonly Newtonsoft.Json.Serialization.JsonISerializableContract _contract;  // 0x18
        private readonly Newtonsoft.Json.Serialization.JsonProperty _member;  // 0x20

        // Methods
        // RVA: 0x092C6094  token: 0x60004FF
        public System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member) { }
        // RVA: -1  // generic def  token: 0x6000500
        private T GetTokenValue(System.Object value) { }
        // RVA: 0x092C5DE8  token: 0x6000501
        public virtual System.Object Convert(System.Object value, System.Type type) { }
        // RVA: 0x092C5F2C  token: 0x6000502
        public virtual System.Boolean ToBoolean(System.Object value) { }
        // RVA: 0x092C5F74  token: 0x6000503
        public virtual System.Int32 ToInt32(System.Object value) { }
        // RVA: 0x092C5FBC  token: 0x6000504
        public virtual System.Int64 ToInt64(System.Object value) { }
        // RVA: 0x092C6004  token: 0x6000505
        public virtual System.Single ToSingle(System.Object value) { }
        // RVA: 0x092C604C  token: 0x6000506
        public virtual System.String ToString(System.Object value) { }

    }

    // TypeToken: 0x20000C2  // size: 0xC8
    public class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
    {
        // Fields
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField;  // 0xc0

        // Properties
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ISerializableCreator { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }

        // Methods
        // RVA: 0x092C61BC  token: 0x6000509
        public System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000C3  // size: 0x90
    public class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
    {
        // Methods
        // RVA: 0x042770F8  token: 0x600050A
        public System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000C4  // size: 0x128
    public class JsonObjectContract : Newtonsoft.Json.Serialization.JsonContainerContract
    {
        // Fields
        private Newtonsoft.Json.MemberSerialization <MemberSerialization>k__BackingField;  // 0xc0
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> <MissingMemberHandling>k__BackingField;  // 0xc4
        private System.Nullable<Newtonsoft.Json.Required> <ItemRequired>k__BackingField;  // 0xcc
        private System.Nullable<Newtonsoft.Json.NullValueHandling> <ItemNullValueHandling>k__BackingField;  // 0xd4
        private readonly Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;  // 0xe0
        private Newtonsoft.Json.Serialization.ExtensionDataSetter <ExtensionDataSetter>k__BackingField;  // 0xe8
        private Newtonsoft.Json.Serialization.ExtensionDataGetter <ExtensionDataGetter>k__BackingField;  // 0xf0
        private System.Func<System.String,System.String> <ExtensionDataNameResolver>k__BackingField;  // 0xf8
        private System.Boolean ExtensionDataIsJToken;  // 0x100
        private System.Nullable<System.Boolean> _hasRequiredOrDefaultValueProperties;  // 0x101
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;  // 0x108
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;  // 0x110
        private Newtonsoft.Json.Serialization.JsonPropertyCollection _creatorParameters;  // 0x118
        private System.Type _extensionDataValueType;  // 0x120

        // Properties
        Newtonsoft.Json.MemberSerialization MemberSerialization { get; /* RVA: 0x03D57EF0 */ set; /* RVA: 0x03D57F70 */ }
        System.Nullable<Newtonsoft.Json.MissingMemberHandling> MissingMemberHandling { get; /* RVA: 0x03D71580 */ set; /* RVA: 0x03D69470 */ }
        System.Nullable<Newtonsoft.Json.Required> ItemRequired { get; /* RVA: 0x03D71570 */ set; /* RVA: 0x03D715A0 */ }
        System.Nullable<Newtonsoft.Json.NullValueHandling> ItemNullValueHandling { get; /* RVA: 0x03D71560 */ set; /* RVA: 0x03D71590 */ }
        Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { get; /* RVA: 0x03D51140 */ }
        Newtonsoft.Json.Serialization.JsonPropertyCollection CreatorParameters { get; /* RVA: 0x03CF5EA0 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> OverrideCreator { get; /* RVA: 0x03D56D30 */ set; /* RVA: 0x0589D950 */ }
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ParameterizedCreator { get; /* RVA: 0x03D56CF0 */ set; /* RVA: 0x04275CF4 */ }
        Newtonsoft.Json.Serialization.ExtensionDataSetter ExtensionDataSetter { get; /* RVA: 0x03D50EA0 */ set; /* RVA: 0x056A2B64 */ }
        Newtonsoft.Json.Serialization.ExtensionDataGetter ExtensionDataGetter { get; /* RVA: 0x03D51950 */ set; /* RVA: 0x058B408C */ }
        System.Type ExtensionDataValueType { set; /* RVA: 0x092C62D8 */ }
        System.Func<System.String,System.String> ExtensionDataNameResolver { get; /* RVA: 0x03D50160 */ set; /* RVA: 0x0554D2E0 */ }
        System.Boolean HasRequiredOrDefaultValueProperties { get; /* RVA: 0x02D73000 */ }

        // Methods
        // RVA: 0x024754F0  token: 0x6000521
        public System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x092C61DC  token: 0x6000522
        private System.Object GetUninitializedObject() { }

    }

    // TypeToken: 0x20000C5  // size: 0x98
    public class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
    {
        // Fields
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;  // 0x90
        private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap;  // static @ 0x0

        // Properties
        Newtonsoft.Json.Utilities.PrimitiveTypeCode TypeCode { get; /* RVA: 0x03D4FB60 */ set; /* RVA: 0x03D4FB70 */ }

        // Methods
        // RVA: 0x03439E20  token: 0x6000525
        public System.Void .ctor(System.Type underlyingType) { }
        // RVA: 0x03875BF0  token: 0x6000526
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C6  // size: 0xF0
    public class JsonProperty
    {
        // Fields
        private System.Nullable<Newtonsoft.Json.Required> _required;  // 0x10
        private System.Boolean _hasExplicitDefaultValue;  // 0x18
        private System.Object _defaultValue;  // 0x20
        private System.Boolean _hasGeneratedDefaultValue;  // 0x28
        private System.String _propertyName;  // 0x30
        private System.Boolean _skipPropertyNameEscape;  // 0x38
        private System.Type _propertyType;  // 0x40
        private Newtonsoft.Json.Serialization.JsonContract <PropertyContract>k__BackingField;  // 0x48
        private System.Type <DeclaringType>k__BackingField;  // 0x50
        private System.Nullable<System.Int32> <Order>k__BackingField;  // 0x58
        private System.String <UnderlyingName>k__BackingField;  // 0x60
        private Newtonsoft.Json.Serialization.IValueProvider <ValueProvider>k__BackingField;  // 0x68
        private Newtonsoft.Json.Serialization.IAttributeProvider <AttributeProvider>k__BackingField;  // 0x70
        private Newtonsoft.Json.JsonConverter <Converter>k__BackingField;  // 0x78
        private System.Boolean <Ignored>k__BackingField;  // 0x80
        private System.Boolean <Readable>k__BackingField;  // 0x81
        private System.Boolean <Writable>k__BackingField;  // 0x82
        private System.Boolean <HasMemberAttribute>k__BackingField;  // 0x83
        private System.Nullable<System.Boolean> <IsReference>k__BackingField;  // 0x84
        private System.Nullable<Newtonsoft.Json.NullValueHandling> <NullValueHandling>k__BackingField;  // 0x88
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> <DefaultValueHandling>k__BackingField;  // 0x90
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField;  // 0x98
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> <ObjectCreationHandling>k__BackingField;  // 0xa0
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <TypeNameHandling>k__BackingField;  // 0xa8
        private System.Predicate<System.Object> <ShouldSerialize>k__BackingField;  // 0xb0
        private System.Predicate<System.Object> <ShouldDeserialize>k__BackingField;  // 0xb8
        private System.Predicate<System.Object> <GetIsSpecified>k__BackingField;  // 0xc0
        private System.Action<System.Object,System.Object> <SetIsSpecified>k__BackingField;  // 0xc8
        private Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;  // 0xd0
        private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField;  // 0xd8
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;  // 0xdc
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;  // 0xe4

        // Properties
        Newtonsoft.Json.Serialization.JsonContract PropertyContract { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.String PropertyName { get; /* RVA: 0x01003830 */ set; /* RVA: 0x024E6960 */ }
        System.Type DeclaringType { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Nullable<System.Int32> Order { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03D4F270 */ }
        System.String UnderlyingName { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        Newtonsoft.Json.Serialization.IValueProvider ValueProvider { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        Newtonsoft.Json.Serialization.IAttributeProvider AttributeProvider { set; /* RVA: 0x0519C3C8 */ }
        System.Type PropertyType { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x024E5C60 */ }
        Newtonsoft.Json.JsonConverter Converter { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }
        System.Boolean Ignored { get; /* RVA: 0x03D4F360 */ set; /* RVA: 0x03D4F380 */ }
        System.Boolean Readable { get; /* RVA: 0x03D5A210 */ set; /* RVA: 0x03D5A220 */ }
        System.Boolean Writable { get; /* RVA: 0x03D6C200 */ set; /* RVA: 0x03D71640 */ }
        System.Boolean HasMemberAttribute { get; /* RVA: 0x03D715D0 */ set; /* RVA: 0x03D71610 */ }
        System.Object DefaultValue { get; /* RVA: 0x092C63E0 */ set; /* RVA: 0x092C63F0 */ }
        Newtonsoft.Json.Required Required { get; /* RVA: 0x02D735B0 */ }
        System.Nullable<System.Boolean> IsReference { get; /* RVA: 0x03D67F10 */ set; /* RVA: 0x03D67F20 */ }
        System.Nullable<Newtonsoft.Json.NullValueHandling> NullValueHandling { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x03D4E740 */ }
        System.Nullable<Newtonsoft.Json.DefaultValueHandling> DefaultValueHandling { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x03D5D630 */ }
        System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> ReferenceLoopHandling { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x03D50F10 */ }
        System.Nullable<Newtonsoft.Json.ObjectCreationHandling> ObjectCreationHandling { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x03D71630 */ }
        System.Nullable<Newtonsoft.Json.TypeNameHandling> TypeNameHandling { get; /* RVA: 0x03D4EB10 */ set; /* RVA: 0x03D4EB70 */ }
        System.Predicate<System.Object> ShouldSerialize { get; /* RVA: 0x03D4EAD0 */ set; /* RVA: 0x02B47080 */ }
        System.Predicate<System.Object> ShouldDeserialize { get; /* RVA: 0x03D4E750 */ }
        System.Predicate<System.Object> GetIsSpecified { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }
        System.Action<System.Object,System.Object> SetIsSpecified { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x058B4280 */ }
        Newtonsoft.Json.JsonConverter ItemConverter { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        System.Nullable<System.Boolean> ItemIsReference { get; /* RVA: 0x03D715E0 */ set; /* RVA: 0x03D71620 */ }
        System.Nullable<Newtonsoft.Json.TypeNameHandling> ItemTypeNameHandling { get; /* RVA: 0x03D71600 */ set; /* RVA: 0x03D68FA0 */ }
        System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> ItemReferenceLoopHandling { get; /* RVA: 0x03D715F0 */ set; /* RVA: 0x03D68F90 */ }

        // Methods
        // RVA: 0x027BBFC0  token: 0x6000542
        private System.Object GetResolvedDefaultValue() { }
        // RVA: 0x092C6398  token: 0x6000557
        public virtual System.String ToString() { }
        // RVA: 0x027BAAA0  token: 0x6000560
        private System.Void WritePropertyName(Newtonsoft.Json.JsonWriter writer) { }
        // RVA: 0x0350B670  token: 0x6000561
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7  // size: 0x40
    public class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection`2
    {
        // Fields
        private readonly System.Type _type;  // 0x30
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;  // 0x38

        // Methods
        // RVA: 0x024753A0  token: 0x6000562
        public System.Void .ctor(System.Type type) { }
        // RVA: 0x03D715B0  token: 0x6000563
        protected virtual System.String GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item) { }
        // RVA: 0x024E5F60  token: 0x6000564
        public System.Void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property) { }
        // RVA: 0x023236D0  token: 0x6000565
        public Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(System.String propertyName) { }
        // RVA: 0x02323BF0  token: 0x6000566
        private System.Boolean TryGetProperty(System.String key, Newtonsoft.Json.Serialization.JsonProperty& item) { }
        // RVA: 0x02323910  token: 0x6000567
        public Newtonsoft.Json.Serialization.JsonProperty GetProperty(System.String propertyName, System.StringComparison comparisonType) { }

    }

    // TypeToken: 0x20000C8  // size: 0x38
    public abstract class JsonSerializerInternalBase
    {
        // Fields
        private Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;  // 0x10
        private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> _mappings;  // 0x18
        private readonly Newtonsoft.Json.JsonSerializer Serializer;  // 0x20
        private readonly Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;  // 0x28
        protected Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;  // 0x30

        // Properties
        Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> DefaultReferenceMappings { get; /* RVA: 0x092C68DC */ }

        // Methods
        // RVA: 0x03163C30  token: 0x6000568
        protected System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092C6850  token: 0x600056A
        protected Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        // RVA: 0x092C6478  token: 0x600056B
        private Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(System.Object currentObject, System.Object member, System.String path, System.Exception error) { }
        // RVA: 0x092C6404  token: 0x600056C
        protected System.Void ClearErrorContext() { }
        // RVA: 0x092C6584  token: 0x600056D
        protected System.Boolean IsErrorHandled(System.Object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, System.Object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.Exception ex) { }

    }

    // TypeToken: 0x20000CA  // size: 0x38
    public class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
    {
        // Methods
        // RVA: 0x042719A0  token: 0x6000571
        public System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x092C9CF0  token: 0x6000572
        public System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        // RVA: 0x027BC960  token: 0x6000573
        private Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type) { }
        // RVA: 0x027BDC20  token: 0x6000574
        private Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type) { }
        // RVA: 0x027BC7E0  token: 0x6000575
        public System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Boolean checkAdditionalContent) { }
        // RVA: 0x024DF020  token: 0x6000576
        private Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer() { }
        // RVA: 0x02693190  token: 0x6000577
        private Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract) { }
        // RVA: 0x03A378D0  token: 0x6000578
        private Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x02323E60  token: 0x6000579
        private System.Object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue) { }
        // RVA: 0x02906460  token: 0x600057A
        private static System.Boolean CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, System.String s) { }
        // RVA: 0x092C94D8  token: 0x600057B
        private System.String GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract) { }
        // RVA: 0x024EA550  token: 0x600057C
        private Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x024E8590  token: 0x600057D
        private System.Object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue) { }
        // RVA: 0x092CA278  token: 0x600057E
        private System.Boolean ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id) { }
        // RVA: 0x024E8D50  token: 0x600057F
        private System.Boolean ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id) { }
        // RVA: 0x027BC9D0  token: 0x6000580
        private System.Void ResolveTypeName(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.String qualifiedTypeName) { }
        // RVA: 0x024EA4E0  token: 0x6000581
        private Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract) { }
        // RVA: 0x024E9EC0  token: 0x6000582
        private System.Object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Object existingValue, System.String id) { }
        // RVA: 0x024E8BC0  token: 0x6000583
        private System.Boolean HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract) { }
        // RVA: 0x02417B90  token: 0x6000584
        private System.Object EnsureType(Newtonsoft.Json.JsonReader reader, System.Object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType) { }
        // RVA: 0x02325070  token: 0x6000585
        private System.Boolean SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target) { }
        // RVA: 0x023253A0  token: 0x6000586
        private System.Boolean CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter& propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target, System.Boolean& useExistingValue, System.Object& currentValue, Newtonsoft.Json.Serialization.JsonContract& propertyContract, System.Boolean& gottenCurrentValue, System.Boolean& ignoredValue) { }
        // RVA: 0x092C69E4  token: 0x6000587
        private System.Void AddReference(Newtonsoft.Json.JsonReader reader, System.String id, System.Object value) { }
        // RVA: 0x02325BB0  token: 0x6000588
        private System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag) { }
        // RVA: 0x02324F90  token: 0x6000589
        private System.Boolean ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Object value) { }
        // RVA: 0x024E8160  token: 0x600058A
        private System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, System.Boolean& createdFromNonDefaultCreator) { }
        // RVA: 0x03241110  token: 0x600058B
        private System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, System.Boolean& createdFromNonDefaultCreator) { }
        // RVA: 0x02B391C0  token: 0x600058C
        private System.Void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        // RVA: 0x024E9C70  token: 0x600058D
        private System.Void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        // RVA: 0x024EDD60  token: 0x600058E
        private System.Object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        // RVA: 0x092C9628  token: 0x600058F
        private System.Object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        // RVA: 0x092CAFB0  token: 0x6000590
        private System.Void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object currentObject, System.String message) { }
        // RVA: 0x024EBC20  token: 0x6000591
        private System.Object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        // RVA: 0x092C74AC  token: 0x6000592
        private System.Object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        // RVA: 0x092C7390  token: 0x6000593
        private System.Object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member) { }
        // RVA: 0x092C6CA0  token: 0x6000594
        private System.Object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        // RVA: 0x092C7B00  token: 0x6000595
        private System.Object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, System.String id) { }
        // RVA: 0x024DEEB0  token: 0x6000596
        private System.Object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue) { }
        // RVA: 0x092CA870  token: 0x6000597
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        // RVA: 0x024E9BA0  token: 0x6000598
        public System.Object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id, System.Boolean& createdFromNonDefaultCreator) { }
        // RVA: 0x02321C70  token: 0x6000599
        private System.Object PopulateObject(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        // RVA: 0x02B0FC70  token: 0x600059A
        private System.Boolean ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }
        // RVA: 0x024EE3E0  token: 0x600059B
        private System.Boolean CheckPropertyName(Newtonsoft.Json.JsonReader reader, System.String memberName) { }
        // RVA: 0x0269A0A0  token: 0x600059C
        private System.Void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, System.String memberName, System.Object o) { }
        // RVA: 0x092CA1CC  token: 0x600059D
        private System.Object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader) { }
        // RVA: 0x027BBCC0  token: 0x600059E
        private System.Void EndProcessProperty(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Int32 initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, System.Boolean setDefaultValue) { }
        // RVA: 0x02906310  token: 0x600059F
        private System.Void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }
        // RVA: 0x092C95BC  token: 0x60005A0
        private System.Void HandleError(Newtonsoft.Json.JsonReader reader, System.Boolean readPastError, System.Int32 initialDepth) { }

    }

    // TypeToken: 0x20000CF  // size: 0x50
    public class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
    {
        // Fields
        private System.Type _rootType;  // 0x38
        private System.Int32 _rootLevel;  // 0x40
        private readonly System.Collections.Generic.List<System.Object> _serializeStack;  // 0x48

        // Methods
        // RVA: 0x03163B90  token: 0x60005AA
        public System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        // RVA: 0x03163CA0  token: 0x60005AB
        public System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        // RVA: 0x092CB0F8  token: 0x60005AC
        private Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer() { }
        // RVA: 0x027BEC50  token: 0x60005AD
        private Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Object value) { }
        // RVA: 0x027BEC70  token: 0x60005AE
        private Newtonsoft.Json.Serialization.JsonContract GetContract(System.Object value) { }
        // RVA: 0x027BB4A0  token: 0x60005AF
        private System.Void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BB160  token: 0x60005B0
        private System.Void SerializeValue(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BB940  token: 0x60005B1
        private System.Nullable<System.Boolean> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BAED0  token: 0x60005B2
        private System.Boolean ShouldWriteReference(System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BAE20  token: 0x60005B3
        private System.Boolean ShouldWriteProperty(System.Object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        // RVA: 0x027BAFD0  token: 0x60005B4
        private System.Boolean CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CD2AC  token: 0x60005B5
        private System.Void WriteReference(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        // RVA: 0x092CB16C  token: 0x60005B6
        private System.String GetReference(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        // RVA: 0x092CD068  token: 0x60005B7
        private static System.Boolean TryConvertToString(System.Object value, System.Type type, System.String& s) { }
        // RVA: 0x092CCF38  token: 0x60005B8
        private System.Void SerializeString(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonStringContract contract) { }
        // RVA: 0x027B91B0  token: 0x60005B9
        private System.Void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        // RVA: 0x027B9370  token: 0x60005BA
        private System.Void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        // RVA: 0x027B9530  token: 0x60005BB
        private System.Void SerializeObject(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BAAD0  token: 0x60005BC
        private System.Boolean CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract& memberContract, System.Object& memberValue) { }
        // RVA: 0x027BB9D0  token: 0x60005BD
        private System.Void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CB36C  token: 0x60005BE
        private System.Boolean HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        // RVA: 0x092CD138  token: 0x60005BF
        private System.Void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, System.Object value) { }
        // RVA: 0x092CD450  token: 0x60005C0
        private System.Void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type) { }
        // RVA: 0x027BAEC0  token: 0x60005C1
        private System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag) { }
        // RVA: 0x027BAEC0  token: 0x60005C2
        private System.Boolean HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag) { }
        // RVA: 0x02325BB0  token: 0x60005C3
        private System.Boolean HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag) { }
        // RVA: 0x092CB3F4  token: 0x60005C4
        private System.Void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027B8270  token: 0x60005C5
        private System.Void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CCDA8  token: 0x60005C6
        private System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CC9CC  token: 0x60005C7
        private System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Int32 initialDepth, System.Int32[] indices) { }
        // RVA: 0x027B8110  token: 0x60005C8
        private System.Boolean WriteStartArray(Newtonsoft.Json.JsonWriter writer, System.Object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CC5C8  token: 0x60005C9
        private System.Void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CB734  token: 0x60005CA
        private System.Void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x092CCFD0  token: 0x60005CB
        private System.Boolean ShouldWriteDynamicProperty(System.Object memberValue) { }
        // RVA: 0x027BBB00  token: 0x60005CC
        private System.Boolean ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027BECB0  token: 0x60005CD
        private System.Void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        // RVA: 0x027C05A0  token: 0x60005CE
        private System.String GetPropertyName(Newtonsoft.Json.JsonWriter writer, System.Object name, Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean& escape) { }
        // RVA: 0x092CB304  token: 0x60005CF
        private System.Void HandleError(Newtonsoft.Json.JsonWriter writer, System.Int32 initialDepth) { }
        // RVA: 0x027BAD90  token: 0x60005D0
        private System.Boolean ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }
        // RVA: 0x027BAD00  token: 0x60005D1
        private System.Boolean IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }

    }

    // TypeToken: 0x20000D0  // size: 0xF8
    public class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;  // 0xe0
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;  // 0xe8
        private readonly Newtonsoft.Json.JsonSerializer _serializer;  // 0xf0

        // Properties
        Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { set; /* RVA: 0x092DC1CC */ }
        Newtonsoft.Json.Serialization.ITraceWriter TraceWriter { get; /* RVA: 0x092DBF68 */ set; /* RVA: 0x092DC21C */ }
        System.Collections.IEqualityComparer EqualityComparer { set; /* RVA: 0x092DC08C */ }
        Newtonsoft.Json.JsonConverterCollection Converters { get; /* RVA: 0x092DBEB8 */ }
        Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { set; /* RVA: 0x092DC064 */ }
        Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get; /* RVA: 0x092DBE94 */ set; /* RVA: 0x092DC03C */ }
        Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { set; /* RVA: 0x092DC104 */ }
        Newtonsoft.Json.NullValueHandling NullValueHandling { get; /* RVA: 0x092DBF44 */ set; /* RVA: 0x092DC12C */ }
        Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { set; /* RVA: 0x092DC154 */ }
        Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { set; /* RVA: 0x092DC1A4 */ }
        Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { set; /* RVA: 0x092DC17C */ }
        Newtonsoft.Json.TypeNameHandling TypeNameHandling { set; /* RVA: 0x092DC26C */ }
        Newtonsoft.Json.MetadataPropertyHandling MetadataPropertyHandling { get; /* RVA: 0x092DBF20 */ set; /* RVA: 0x092DC0DC */ }
        Newtonsoft.Json.TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; /* RVA: 0x092DC244 */ }
        Newtonsoft.Json.ConstructorHandling ConstructorHandling { set; /* RVA: 0x092DBFDC */ }
        Newtonsoft.Json.Serialization.ISerializationBinder SerializationBinder { set; /* RVA: 0x092DC1F4 */ }
        System.Runtime.Serialization.StreamingContext Context { get; /* RVA: 0x092DBE60 */ set; /* RVA: 0x092DC004 */ }
        Newtonsoft.Json.Formatting Formatting { get; /* RVA: 0x092DBED8 */ set; /* RVA: 0x092DC0B4 */ }
        System.Nullable<System.Int32> MaxDepth { get; /* RVA: 0x092DBEFC */ }
        System.Boolean CheckAdditionalContent { get; /* RVA: 0x092DBE3C */ set; /* RVA: 0x092DBFB4 */ }

        // Events
        event System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;

        // Methods
        // RVA: 0x092DBCAC  token: 0x60005EF
        private Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer() { }
        // RVA: 0x02695990  token: 0x60005F0
        public System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader) { }
        // RVA: 0x092DBD54  token: 0x60005F1
        public System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter) { }
        // RVA: 0x092DBC60  token: 0x60005F2
        private virtual System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        // RVA: 0x092DBCC8  token: 0x60005F3
        private virtual System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        // RVA: 0x092DBD0C  token: 0x60005F4
        private virtual System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type rootType) { }

    }

    // TypeToken: 0x20000D1  // size: 0x98
    public class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
    {
        // Methods
        // RVA: 0x03439D30  token: 0x60005F5
        public System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000D2  // size: 0x10
    public static class JsonTypeReflector
    {
        // Fields
        private static System.Nullable<System.Boolean> _fullyTrusted;  // static @ 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Func<System.Object[],System.Object>> CreatorCache;  // static @ 0x8
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> AssociatedMetadataTypesCache;  // static @ 0x10
        private static Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;  // static @ 0x18

        // Properties
        System.Boolean FullyTrusted { get; /* RVA: 0x092DC7C8 */ }
        Newtonsoft.Json.Utilities.ReflectionDelegateFactory ReflectionDelegateFactory { get; /* RVA: 0x02476090 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x60005F6
        public static T GetCachedAttribute(System.Object attributeProvider) { }
        // RVA: 0x025E6FD0  token: 0x60005F7
        public static System.Boolean CanTypeDescriptorConvertString(System.Type type, System.ComponentModel.TypeConverter& typeConverter) { }
        // RVA: 0x024E7560  token: 0x60005F8
        public static System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type) { }
        // RVA: 0x092DC5AC  token: 0x60005F9
        public static System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x0283DEE0  token: 0x60005FA
        public static Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, System.Boolean ignoreSerializableAttribute) { }
        // RVA: 0x024E71C0  token: 0x60005FB
        public static Newtonsoft.Json.JsonConverter GetJsonConverter(System.Object attributeProvider) { }
        // RVA: 0x092DC294  token: 0x60005FC
        public static Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, System.Object[] args) { }
        // RVA: 0x092DC33C  token: 0x60005FD
        public static Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, System.Object[] args) { }
        // RVA: 0x092DC3E4  token: 0x60005FE
        public static Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute) { }
        // RVA: 0x092DC48C  token: 0x60005FF
        private static System.Func<System.Object[],System.Object> GetCreator(System.Type type) { }
        // RVA: 0x02303720  token: 0x6000600
        private static System.Type GetAssociatedMetadataType(System.Type type) { }
        // RVA: 0x030ED130  token: 0x6000601
        private static System.Type GetAssociateMetadataTypeFromAttribute(System.Type type) { }
        // RVA: -1  // generic def  token: 0x6000602
        private static T GetAttribute(System.Type type) { }
        // RVA: -1  // generic def  token: 0x6000603
        private static T GetAttribute(System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x03132B60  token: 0x6000604
        public static System.Boolean IsNonSerializable(System.Object provider) { }
        // RVA: 0x092DC76C  token: 0x6000605
        public static System.Boolean IsSerializable(System.Object provider) { }
        // RVA: -1  // generic def  token: 0x6000606
        public static T GetAttribute(System.Object provider) { }
        // RVA: 0x038CEC10  token: 0x6000609
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D5  // size: 0x18
    public class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
    {
        // Methods
        // RVA: 0x03D714A0  token: 0x600060F
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        // RVA: 0x03D71490  token: 0x6000610
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        // RVA: 0x0350B670  token: 0x6000611
        public System.Void .ctor() { }
        // RVA: 0x092DC888  token: 0x6000612
        protected virtual System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x20000D6  // size: 0x18
    public abstract class NamingStrategy
    {
        // Fields
        private System.Boolean <ProcessDictionaryKeys>k__BackingField;  // 0x10
        private System.Boolean <ProcessExtensionDataNames>k__BackingField;  // 0x11
        private System.Boolean <OverrideSpecifiedNames>k__BackingField;  // 0x12

        // Properties
        System.Boolean ProcessDictionaryKeys { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.Boolean ProcessExtensionDataNames { get; /* RVA: 0x03D510E0 */ set; /* RVA: 0x03D510F0 */ }
        System.Boolean OverrideSpecifiedNames { get; /* RVA: 0x03D519E0 */ set; /* RVA: 0x03D6B770 */ }

        // Methods
        // RVA: 0x092DCA80  token: 0x6000619
        public virtual System.String GetPropertyName(System.String name, System.Boolean hasSpecifiedName) { }
        // RVA: 0x092DC9A8  token: 0x600061A
        public virtual System.String GetExtensionDataName(System.String name) { }
        // RVA: 0x092DC980  token: 0x600061B
        public virtual System.String GetDictionaryKey(System.String key) { }
        // RVA: -1  // abstract  token: 0x600061C
        protected virtual System.String ResolvePropertyName(System.String name) { }
        // RVA: 0x092DC9D0  token: 0x600061D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x092DC92C  token: 0x600061E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x092DC894  token: 0x600061F
        protected System.Boolean Equals(Newtonsoft.Json.Serialization.NamingStrategy other) { }
        // RVA: 0x0350B670  token: 0x6000620
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public sealed class ObjectConstructor`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000621
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000622
        public virtual System.Object Invoke(System.Object[] args) { }

    }

    // TypeToken: 0x20000D8  // size: 0x10
    public sealed class OnErrorAttribute : System.Attribute
    {
    }

    // TypeToken: 0x20000D9  // size: 0x18
    public class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
    {
        // Fields
        private readonly System.Object _attributeProvider;  // 0x10

        // Methods
        // RVA: 0x024E5C10  token: 0x6000623
        public System.Void .ctor(System.Object attributeProvider) { }

    }

    // TypeToken: 0x20000DA  // size: 0x18
    public class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
    {
        // Fields
        private readonly System.Reflection.MemberInfo _memberInfo;  // 0x10

        // Methods
        // RVA: 0x024E5BC0  token: 0x6000624
        public System.Void .ctor(System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x02325C30  token: 0x6000625
        public virtual System.Void SetValue(System.Object target, System.Object value) { }
        // RVA: 0x0232C920  token: 0x6000626
        public virtual System.Object GetValue(System.Object target) { }

    }

    // TypeToken: 0x20000DB  // size: 0x18
    public class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
    {
        // Methods
        // RVA: 0x03D714A0  token: 0x6000627
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        // RVA: 0x03D71490  token: 0x6000628
        public System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        // RVA: 0x0350B670  token: 0x6000629
        public System.Void .ctor() { }
        // RVA: 0x092DCAA4  token: 0x600062A
        protected virtual System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x20000DC  // size: 0x90
    public class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        // Fields
        private readonly Newtonsoft.Json.JsonReader _innerReader;  // 0x78
        private readonly Newtonsoft.Json.JsonTextWriter _textWriter;  // 0x80
        private readonly System.IO.StringWriter _sw;  // 0x88

        // Properties
        System.Int32 Depth { get; /* RVA: 0x092DD008 */ }
        System.String Path { get; /* RVA: 0x092DD02C */ }
        Newtonsoft.Json.JsonToken TokenType { get; /* RVA: 0x092DD050 */ }
        System.Object Value { get; /* RVA: 0x092DD098 */ }
        System.Type ValueType { get; /* RVA: 0x092DD074 */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LineNumber { get; /* RVA: 0x092DCB48 */ }
        System.Int32 Newtonsoft.Json.IJsonLineInfo.LinePosition { get; /* RVA: 0x092DCB98 */ }

        // Methods
        // RVA: 0x092DCEB0  token: 0x600062B
        public System.Void .ctor(Newtonsoft.Json.JsonReader innerReader) { }
        // RVA: 0x092DCAD4  token: 0x600062C
        public System.String GetDeserializedJsonMessage() { }
        // RVA: 0x092DCE38  token: 0x600062D
        public virtual System.Boolean Read() { }
        // RVA: 0x092DCDB0  token: 0x600062E
        public virtual System.Nullable<System.Int32> ReadAsInt32() { }
        // RVA: 0x092DCDF4  token: 0x600062F
        public virtual System.String ReadAsString() { }
        // RVA: 0x092DCC2C  token: 0x6000630
        public virtual System.Byte[] ReadAsBytes() { }
        // RVA: 0x092DCD0C  token: 0x6000631
        public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }
        // RVA: 0x092DCD60  token: 0x6000632
        public virtual System.Nullable<System.Double> ReadAsDouble() { }
        // RVA: 0x092DCBE8  token: 0x6000633
        public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }
        // RVA: 0x092DCCC4  token: 0x6000634
        public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }
        // RVA: 0x092DCC70  token: 0x6000635
        public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        // RVA: 0x092DCE7C  token: 0x6000636
        public System.Void WriteCurrentToken() { }
        // RVA: 0x092DCAB0  token: 0x600063C
        public virtual System.Void Close() { }
        // RVA: 0x092DCAF8  token: 0x600063D
        private virtual System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

    }

    // TypeToken: 0x20000DD  // size: 0x78
    public class TraceJsonWriter : Newtonsoft.Json.JsonWriter
    {
        // Fields
        private readonly Newtonsoft.Json.JsonWriter _innerWriter;  // 0x60
        private readonly Newtonsoft.Json.JsonTextWriter _textWriter;  // 0x68
        private readonly System.IO.StringWriter _sw;  // 0x70

        // Methods
        // RVA: 0x092DE82C  token: 0x6000640
        public System.Void .ctor(Newtonsoft.Json.JsonWriter innerWriter) { }
        // RVA: 0x092DD100  token: 0x6000641
        public System.String GetSerializedJsonMessage() { }
        // RVA: 0x092DD878  token: 0x6000642
        public virtual System.Void WriteValue(System.Decimal value) { }
        // RVA: 0x092DDAC8  token: 0x6000643
        public virtual System.Void WriteValue(System.Nullable<System.Decimal> value) { }
        // RVA: 0x092DDA6C  token: 0x6000644
        public virtual System.Void WriteValue(System.Boolean value) { }
        // RVA: 0x092DDCA4  token: 0x6000645
        public virtual System.Void WriteValue(System.Nullable<System.Boolean> value) { }
        // RVA: 0x092DD608  token: 0x6000646
        public virtual System.Void WriteValue(System.Byte value) { }
        // RVA: 0x092DDF74  token: 0x6000647
        public virtual System.Void WriteValue(System.Nullable<System.Byte> value) { }
        // RVA: 0x092DDC48  token: 0x6000648
        public virtual System.Void WriteValue(System.Char value) { }
        // RVA: 0x092DE004  token: 0x6000649
        public virtual System.Void WriteValue(System.Nullable<System.Char> value) { }
        // RVA: 0x092DE6CC  token: 0x600064A
        public virtual System.Void WriteValue(System.Byte[] value) { }
        // RVA: 0x092DE4D4  token: 0x600064B
        public virtual System.Void WriteValue(System.DateTime value) { }
        // RVA: 0x092DD664  token: 0x600064C
        public virtual System.Void WriteValue(System.Nullable<System.DateTime> value) { }
        // RVA: 0x092DD8F4  token: 0x600064D
        public virtual System.Void WriteValue(System.DateTimeOffset value) { }
        // RVA: 0x092DDB88  token: 0x600064E
        public virtual System.Void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
        // RVA: 0x092DD968  token: 0x600064F
        public virtual System.Void WriteValue(System.Double value) { }
        // RVA: 0x092DDE24  token: 0x6000650
        public virtual System.Void WriteValue(System.Nullable<System.Double> value) { }
        // RVA: 0x092DD4DC  token: 0x6000651
        public virtual System.Void WriteUndefined() { }
        // RVA: 0x092DD24C  token: 0x6000652
        public virtual System.Void WriteNull() { }
        // RVA: 0x092DE238  token: 0x6000653
        public virtual System.Void WriteValue(System.Single value) { }
        // RVA: 0x092DE5D8  token: 0x6000654
        public virtual System.Void WriteValue(System.Nullable<System.Single> value) { }
        // RVA: 0x092DE130  token: 0x6000655
        public virtual System.Void WriteValue(System.Guid value) { }
        // RVA: 0x092DE294  token: 0x6000656
        public virtual System.Void WriteValue(System.Nullable<System.Guid> value) { }
        // RVA: 0x092DD820  token: 0x6000657
        public virtual System.Void WriteValue(System.Int32 value) { }
        // RVA: 0x092DD520  token: 0x6000658
        public virtual System.Void WriteValue(System.Nullable<System.Int32> value) { }
        // RVA: 0x092DE3A4  token: 0x6000659
        public virtual System.Void WriteValue(System.Int64 value) { }
        // RVA: 0x092DD9C4  token: 0x600065A
        public virtual System.Void WriteValue(System.Nullable<System.Int64> value) { }
        // RVA: 0x092DE400  token: 0x600065B
        public virtual System.Void WriteValue(System.Object value) { }
        // RVA: 0x092DD5B8  token: 0x600065C
        public virtual System.Void WriteValue(System.SByte value) { }
        // RVA: 0x092DD704  token: 0x600065D
        public virtual System.Void WriteValue(System.Nullable<System.SByte> value) { }
        // RVA: 0x092DE738  token: 0x600065E
        public virtual System.Void WriteValue(System.Int16 value) { }
        // RVA: 0x092DD794  token: 0x600065F
        public virtual System.Void WriteValue(System.Nullable<System.Int16> value) { }
        // RVA: 0x092DDDC8  token: 0x6000660
        public virtual System.Void WriteValue(System.String value) { }
        // RVA: 0x092DDED0  token: 0x6000661
        public virtual System.Void WriteValue(System.TimeSpan value) { }
        // RVA: 0x092DE090  token: 0x6000662
        public virtual System.Void WriteValue(System.Nullable<System.TimeSpan> value) { }
        // RVA: 0x092DE34C  token: 0x6000663
        public virtual System.Void WriteValue(System.UInt32 value) { }
        // RVA: 0x092DE794  token: 0x6000664
        public virtual System.Void WriteValue(System.Nullable<System.UInt32> value) { }
        // RVA: 0x092DE670  token: 0x6000665
        public virtual System.Void WriteValue(System.UInt64 value) { }
        // RVA: 0x092DE530  token: 0x6000666
        public virtual System.Void WriteValue(System.Nullable<System.UInt64> value) { }
        // RVA: 0x092DE1A4  token: 0x6000667
        public virtual System.Void WriteValue(System.Uri value) { }
        // RVA: 0x092DDF20  token: 0x6000668
        public virtual System.Void WriteValue(System.UInt16 value) { }
        // RVA: 0x092DDD3C  token: 0x6000669
        public virtual System.Void WriteValue(System.Nullable<System.UInt16> value) { }
        // RVA: 0x092DD124  token: 0x600066A
        public virtual System.Void WriteComment(System.String text) { }
        // RVA: 0x092DD3F8  token: 0x600066B
        public virtual System.Void WriteStartArray() { }
        // RVA: 0x092DD180  token: 0x600066C
        public virtual System.Void WriteEndArray() { }
        // RVA: 0x092DD43C  token: 0x600066D
        public virtual System.Void WriteStartConstructor(System.String name) { }
        // RVA: 0x092DD1C4  token: 0x600066E
        public virtual System.Void WriteEndConstructor() { }
        // RVA: 0x092DD290  token: 0x600066F
        public virtual System.Void WritePropertyName(System.String name) { }
        // RVA: 0x092DD2EC  token: 0x6000670
        public virtual System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        // RVA: 0x092DD498  token: 0x6000671
        public virtual System.Void WriteStartObject() { }
        // RVA: 0x092DD208  token: 0x6000672
        public virtual System.Void WriteEndObject() { }
        // RVA: 0x092DD350  token: 0x6000673
        public virtual System.Void WriteRawValue(System.String json) { }
        // RVA: 0x092DD3AC  token: 0x6000674
        public virtual System.Void WriteRaw(System.String json) { }
        // RVA: 0x092DD0BC  token: 0x6000675
        public virtual System.Void Close() { }

    }

}

namespace Newtonsoft.Json.Utilities
{

    // TypeToken: 0x200003F  // size: 0x10
    public static class AotHelper
    {
        // Fields
        private static System.Boolean s_alwaysFalse;  // static @ 0x0

        // Methods
        // RVA: 0x03A28210  token: 0x6000205
        public static System.Void Ensure(System.Action action) { }
        // RVA: -1  // generic def  token: 0x6000206
        public static System.Void EnsureList() { }
        // RVA: 0x092B8530  token: 0x6000207
        public static System.Boolean IsFalse() { }
        // RVA: 0x03CF5C20  token: 0x6000208
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000041  // size: 0x30
    public class Base64Encoder
    {
        // Fields
        private readonly System.Char[] _charsLine;  // 0x10
        private readonly System.IO.TextWriter _writer;  // 0x18
        private System.Byte[] _leftOverBytes;  // 0x20
        private System.Int32 _leftOverBytesCount;  // 0x28

        // Methods
        // RVA: 0x092B8AA8  token: 0x600020C
        public System.Void .ctor(System.IO.TextWriter writer) { }
        // RVA: 0x092B8900  token: 0x600020D
        private System.Void ValidateEncode(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        // RVA: 0x092B8580  token: 0x600020E
        public System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        // RVA: 0x092B8818  token: 0x600020F
        private System.Void StoreLeftOverBytes(System.Byte[] buffer, System.Int32 index, System.Int32& count) { }
        // RVA: 0x092B8788  token: 0x6000210
        private System.Boolean FulfillFromLeftover(System.Byte[] buffer, System.Int32 index, System.Int32& count) { }
        // RVA: 0x092B86EC  token: 0x6000211
        public System.Void Flush() { }
        // RVA: 0x092B8A78  token: 0x6000212
        private System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x2000042
    public class BidirectionalDictionary`2
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<TFirst,TSecond> _firstToSecond;  // 0x0
        private readonly System.Collections.Generic.IDictionary<TSecond,TFirst> _secondToFirst;  // 0x0
        private readonly System.String _duplicateFirstErrorMessage;  // 0x0
        private readonly System.String _duplicateSecondErrorMessage;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000213
        public System.Void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, System.String duplicateFirstErrorMessage, System.String duplicateSecondErrorMessage) { }
        // RVA: -1  // not resolved  token: 0x6000214
        public System.Void Set(TFirst first, TSecond second) { }
        // RVA: -1  // not resolved  token: 0x6000215
        public System.Boolean TryGetByFirst(TFirst first, TSecond& second) { }
        // RVA: -1  // not resolved  token: 0x6000216
        public System.Boolean TryGetBySecond(TSecond second, TFirst& first) { }

    }

    // TypeToken: 0x2000043  // size: 0x10
    public static class BoxedPrimitives
    {
        // Fields
        private static readonly System.Object BooleanTrue;  // static @ 0x0
        private static readonly System.Object BooleanFalse;  // static @ 0x8
        private static readonly System.Object Int32_M1;  // static @ 0x10
        private static readonly System.Object Int32_0;  // static @ 0x18
        private static readonly System.Object Int32_1;  // static @ 0x20
        private static readonly System.Object Int32_2;  // static @ 0x28
        private static readonly System.Object Int32_3;  // static @ 0x30
        private static readonly System.Object Int32_4;  // static @ 0x38
        private static readonly System.Object Int32_5;  // static @ 0x40
        private static readonly System.Object Int32_6;  // static @ 0x48
        private static readonly System.Object Int32_7;  // static @ 0x50
        private static readonly System.Object Int32_8;  // static @ 0x58
        private static readonly System.Object Int64_M1;  // static @ 0x60
        private static readonly System.Object Int64_0;  // static @ 0x68
        private static readonly System.Object Int64_1;  // static @ 0x70
        private static readonly System.Object Int64_2;  // static @ 0x78
        private static readonly System.Object Int64_3;  // static @ 0x80
        private static readonly System.Object Int64_4;  // static @ 0x88
        private static readonly System.Object Int64_5;  // static @ 0x90
        private static readonly System.Object Int64_6;  // static @ 0x98
        private static readonly System.Object Int64_7;  // static @ 0xa0
        private static readonly System.Object Int64_8;  // static @ 0xa8
        private static readonly System.Object DecimalZero;  // static @ 0xb0
        private static readonly System.Object DoubleNaN;  // static @ 0xb8
        private static readonly System.Object DoublePositiveInfinity;  // static @ 0xc0
        private static readonly System.Object DoubleNegativeInfinity;  // static @ 0xc8
        private static readonly System.Object DoubleZero;  // static @ 0xd0

        // Methods
        // RVA: 0x024ED670  token: 0x6000217
        private static System.Object Get(System.Boolean value) { }
        // RVA: 0x024E3FE0  token: 0x6000218
        private static System.Object Get(System.Int32 value) { }
        // RVA: 0x024E3CF0  token: 0x6000219
        private static System.Object Get(System.Int64 value) { }
        // RVA: 0x092B9634  token: 0x600021A
        private static System.Object Get(System.Decimal value) { }
        // RVA: 0x02E869B0  token: 0x600021B
        private static System.Object Get(System.Double value) { }
        // RVA: 0x02C2B4A0  token: 0x600021C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x10
    public static class CollectionUtils
    {
        // Methods
        // RVA: -1  // generic def  token: 0x600021D
        public static System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }
        // RVA: -1  // generic def  token: 0x600021E
        public static System.Void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }
        // RVA: 0x02477E60  token: 0x600021F
        public static System.Boolean IsDictionaryType(System.Type type) { }
        // RVA: 0x0308DFC0  token: 0x6000220
        public static System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType) { }
        // RVA: 0x0308E930  token: 0x6000221
        public static System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType) { }
        // RVA: -1  // generic def  token: 0x6000222
        public static System.Int32 IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }
        // RVA: -1  // generic def  token: 0x6000223
        public static System.Boolean Contains(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer) { }
        // RVA: -1  // generic def  token: 0x6000224
        public static System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item) { }
        // RVA: -1  // generic def  token: 0x6000225
        public static System.Void FastReverse(System.Collections.Generic.List<T> list) { }
        // RVA: 0x092B994C  token: 0x6000226
        private static System.Collections.Generic.IList<System.Int32> GetDimensions(System.Collections.IList values, System.Int32 dimensionsCount) { }
        // RVA: 0x092B9778  token: 0x6000227
        private static System.Void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, System.Int32[] indices) { }
        // RVA: 0x092B9A50  token: 0x6000228
        private static System.Object JaggedArrayGetValue(System.Collections.IList values, System.Int32[] indices) { }
        // RVA: 0x092B9AEC  token: 0x6000229
        public static System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, System.Int32 rank) { }
        // RVA: -1  // generic def  token: 0x600022A
        public static T[] ArrayEmpty() { }

    }

    // TypeToken: 0x2000046
    public interface IWrappedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
    {
        // Properties
        System.Object UnderlyingCollection { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000047
    public class CollectionWrapper`1 : System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedCollection, System.Collections.IList, System.Collections.ICollection
    {
        // Fields
        private readonly System.Collections.IList _list;  // 0x0
        private readonly System.Collections.Generic.ICollection<T> _genericCollection;  // 0x0
        private System.Object _syncRoot;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.IList.IsFixedSize { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IList.Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: -1  // not resolved */ }
        System.Object UnderlyingCollection { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600022D
        public System.Void .ctor(System.Collections.IList list) { }
        // RVA: -1  // not resolved  token: 0x600022E
        public System.Void .ctor(System.Collections.Generic.ICollection<T> list) { }
        // RVA: -1  // not resolved  token: 0x600022F
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000230
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000231
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000232
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000235
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x6000236
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000237
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000238
        private virtual System.Int32 System.Collections.IList.Add(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000239
        private virtual System.Boolean System.Collections.IList.Contains(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x600023A
        private virtual System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x600023B
        private virtual System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600023C
        private virtual System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x600023E
        private virtual System.Void System.Collections.IList.Remove(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000241
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000244
        private static System.Void VerifyValueType(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000245
        private static System.Boolean IsCompatibleObject(System.Object value) { }

    }

    // TypeToken: 0x2000048  // size: 0x14
    public sealed struct PrimitiveTypeCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Empty;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Object;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Char;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode CharNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Boolean;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BooleanNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SByte;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SByteNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int16;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int16Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt16;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt16Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int32;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int32Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Byte;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode ByteNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt32;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt32Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int64;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int64Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt64;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt64Nullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Single;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SingleNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Double;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DoubleNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTime;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeOffset;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeOffsetNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Decimal;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DecimalNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Guid;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode GuidNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode TimeSpan;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode TimeSpanNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BigInteger;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BigIntegerNullable;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Uri;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode String;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Bytes;  // const
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DBNull;  // const

    }

    // TypeToken: 0x2000049  // size: 0x20
    public class TypeInformation
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;  // 0x10
        private readonly Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;  // 0x18

        // Properties
        System.Type Type { get; /* RVA: 0x020B7B20 */ }
        Newtonsoft.Json.Utilities.PrimitiveTypeCode TypeCode { get; /* RVA: 0x020D1AC0 */ }

        // Methods
        // RVA: 0x02738A30  token: 0x6000249
        public System.Void .ctor(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode) { }

    }

    // TypeToken: 0x200004A  // size: 0x14
    public sealed struct ParseResult
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Utilities.ParseResult None;  // const
        public static Newtonsoft.Json.Utilities.ParseResult Success;  // const
        public static Newtonsoft.Json.Utilities.ParseResult Overflow;  // const
        public static Newtonsoft.Json.Utilities.ParseResult Invalid;  // const

    }

    // TypeToken: 0x200004B  // size: 0x10
    public static class ConvertUtils
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap;  // static @ 0x0
        private static readonly Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes;  // static @ 0x8
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>> CastConverters;  // static @ 0x10

        // Methods
        // RVA: 0x02476D60  token: 0x600024A
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t) { }
        // RVA: 0x02476FF0  token: 0x600024B
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, System.Boolean& isEnum) { }
        // RVA: 0x092BAE94  token: 0x600024C
        public static Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable) { }
        // RVA: 0x024769F0  token: 0x600024D
        public static System.Boolean IsConvertible(System.Type t) { }
        // RVA: 0x092BAF10  token: 0x600024E
        public static System.TimeSpan ParseTimeSpan(System.String input) { }
        // RVA: 0x092B9E98  token: 0x600024F
        private static System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }
        // RVA: 0x092BAF80  token: 0x6000250
        private static System.Numerics.BigInteger ToBigInteger(System.Object value) { }
        // RVA: 0x092BAA54  token: 0x6000251
        public static System.Object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType) { }
        // RVA: 0x092B9BE0  token: 0x6000252
        public static System.Object Convert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType) { }
        // RVA: 0x092BBB60  token: 0x6000253
        private static System.Boolean TryConvert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value) { }
        // RVA: 0x092BB33C  token: 0x6000254
        private static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value) { }
        // RVA: 0x03CEDFA0  token: 0x6000255
        public static System.Object ConvertOrCast(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType) { }
        // RVA: 0x092BA844  token: 0x6000256
        private static System.Object EnsureTypeAssignable(System.Object value, System.Type initialType, System.Type targetType) { }
        // RVA: 0x092BBCF8  token: 0x6000257
        public static System.Boolean VersionTryParse(System.String input, System.Version& result) { }
        // RVA: 0x02476C90  token: 0x6000258
        public static System.Boolean IsInteger(System.Object value) { }
        // RVA: 0x02BAF140  token: 0x6000259
        public static Newtonsoft.Json.Utilities.ParseResult Int32TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int32& value) { }
        // RVA: 0x02B390D0  token: 0x600025A
        public static Newtonsoft.Json.Utilities.ParseResult Int64TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int64& value) { }
        // RVA: 0x092BA058  token: 0x600025B
        public static Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Decimal& value) { }
        // RVA: 0x092BB2F0  token: 0x600025C
        public static System.Boolean TryConvertGuid(System.String s, System.Guid& g) { }
        // RVA: 0x092BBC60  token: 0x600025D
        public static System.Boolean TryHexTextToInt(System.Char[] text, System.Int32 start, System.Int32 end, System.Int32& value) { }
        // RVA: 0x035D3A50  token: 0x600025E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x14
    public sealed struct ParserTimeZone
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Newtonsoft.Json.Utilities.ParserTimeZone Unspecified;  // const
        public static Newtonsoft.Json.Utilities.ParserTimeZone Utc;  // const
        public static Newtonsoft.Json.Utilities.ParserTimeZone LocalWestOfUtc;  // const
        public static Newtonsoft.Json.Utilities.ParserTimeZone LocalEastOfUtc;  // const

    }

    // TypeToken: 0x200004F  // size: 0x48
    public sealed struct DateTimeParser
    {
        // Fields
        public System.Int32 Year;  // 0x10
        public System.Int32 Month;  // 0x14
        public System.Int32 Day;  // 0x18
        public System.Int32 Hour;  // 0x1c
        public System.Int32 Minute;  // 0x20
        public System.Int32 Second;  // 0x24
        public System.Int32 Fraction;  // 0x28
        public System.Int32 ZoneHour;  // 0x2c
        public System.Int32 ZoneMinute;  // 0x30
        public Newtonsoft.Json.Utilities.ParserTimeZone Zone;  // 0x34
        private System.Char[] _text;  // 0x38
        private System.Int32 _end;  // 0x40
        private static readonly System.Int32[] Power10;  // static @ 0x0
        private static readonly System.Int32 Lzyyyy;  // static @ 0x8
        private static readonly System.Int32 Lzyyyy_;  // static @ 0xc
        private static readonly System.Int32 Lzyyyy_MM;  // static @ 0x10
        private static readonly System.Int32 Lzyyyy_MM_;  // static @ 0x14
        private static readonly System.Int32 Lzyyyy_MM_dd;  // static @ 0x18
        private static readonly System.Int32 Lzyyyy_MM_ddT;  // static @ 0x1c
        private static readonly System.Int32 LzHH;  // static @ 0x20
        private static readonly System.Int32 LzHH_;  // static @ 0x24
        private static readonly System.Int32 LzHH_mm;  // static @ 0x28
        private static readonly System.Int32 LzHH_mm_;  // static @ 0x2c
        private static readonly System.Int32 LzHH_mm_ss;  // static @ 0x30
        private static readonly System.Int32 Lz_;  // static @ 0x34
        private static readonly System.Int32 Lz_zz;  // static @ 0x38

        // Methods
        // RVA: 0x092BC54C  token: 0x6000261
        private static System.Void .cctor() { }
        // RVA: 0x092BC460  token: 0x6000262
        public System.Boolean Parse(System.Char[] text, System.Int32 startIndex, System.Int32 length) { }
        // RVA: 0x092BBE74  token: 0x6000263
        private System.Boolean ParseDate(System.Int32 start) { }
        // RVA: 0x092BC004  token: 0x6000264
        private System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start) { }
        // RVA: 0x092BC074  token: 0x6000265
        private System.Boolean ParseTime(System.Int32& start) { }
        // RVA: 0x092BC2F4  token: 0x6000266
        private System.Boolean ParseZone(System.Int32 start) { }
        // RVA: 0x092BBD70  token: 0x6000267
        private System.Boolean Parse4Digit(System.Int32 start, System.Int32& num) { }
        // RVA: 0x092BBD00  token: 0x6000268
        private System.Boolean Parse2Digit(System.Int32 start, System.Int32& num) { }
        // RVA: 0x092BBE3C  token: 0x6000269
        private System.Boolean ParseChar(System.Int32 start, System.Char ch) { }

    }

    // TypeToken: 0x2000050  // size: 0x10
    public static class DateTimeUtils
    {
        // Fields
        private static readonly System.Int64 InitialJavaScriptDateTicks;  // static @ 0x0
        private static readonly System.Int32[] DaysToMonth365;  // static @ 0x8
        private static readonly System.Int32[] DaysToMonth366;  // static @ 0x10

        // Methods
        // RVA: 0x02562620  token: 0x600026A
        private static System.Void .cctor() { }
        // RVA: 0x092BCE94  token: 0x600026B
        public static System.TimeSpan GetUtcOffset(System.DateTime d) { }
        // RVA: 0x092BD044  token: 0x600026C
        public static System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind) { }
        // RVA: 0x092BCBB8  token: 0x600026D
        private static System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone) { }
        // RVA: 0x092BCEEC  token: 0x600026E
        private static System.DateTime SwitchToLocalTime(System.DateTime value) { }
        // RVA: 0x092BCF98  token: 0x600026F
        private static System.DateTime SwitchToUtcTime(System.DateTime value) { }
        // RVA: 0x092BD20C  token: 0x6000270
        private static System.Int64 ToUniversalTicks(System.DateTime dateTime) { }
        // RVA: 0x092BD0E0  token: 0x6000271
        private static System.Int64 ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset) { }
        // RVA: 0x092BC844  token: 0x6000272
        private static System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset) { }
        // RVA: 0x092BC8A0  token: 0x6000273
        private static System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime) { }
        // RVA: 0x092BC8EC  token: 0x6000274
        private static System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.Boolean convertToUtc) { }
        // RVA: 0x092BE694  token: 0x6000275
        private static System.Int64 UniversalTicksToJavaScriptTicks(System.Int64 universalTicks) { }
        // RVA: 0x092BC984  token: 0x6000276
        private static System.DateTime ConvertJavaScriptTicksToDateTime(System.Int64 javaScriptTicks) { }
        // RVA: 0x092BD374  token: 0x6000277
        private static System.Boolean TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt) { }
        // RVA: 0x092BD954  token: 0x6000278
        private static System.Boolean TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt) { }
        // RVA: 0x092BCA7C  token: 0x6000279
        private static System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser) { }
        // RVA: 0x02906190  token: 0x600027A
        private static System.Boolean TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        // RVA: 0x092BE15C  token: 0x600027B
        private static System.Boolean TryParseDateTime(System.String s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        // RVA: 0x092BDCD0  token: 0x600027C
        private static System.Boolean TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        // RVA: 0x092BDEB4  token: 0x600027D
        private static System.Boolean TryParseDateTimeOffset(System.String s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        // RVA: 0x092BE3E0  token: 0x600027E
        private static System.Boolean TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, System.Int64& ticks, System.TimeSpan& offset, System.DateTimeKind& kind) { }
        // RVA: 0x092BD784  token: 0x600027F
        private static System.Boolean TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt) { }
        // RVA: 0x092BD2A8  token: 0x6000280
        private static System.Boolean TryParseDateTimeExact(System.String text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        // RVA: 0x092BDBA8  token: 0x6000281
        private static System.Boolean TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt) { }
        // RVA: 0x092BD8B4  token: 0x6000282
        private static System.Boolean TryParseDateTimeOffsetExact(System.String text, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        // RVA: 0x092BE550  token: 0x6000283
        private static System.Boolean TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, System.Int32 startIndex, System.TimeSpan& offset) { }
        // RVA: 0x092BEA5C  token: 0x6000284
        private static System.Void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture) { }
        // RVA: 0x092BEBB0  token: 0x6000285
        private static System.Int32 WriteDateTimeString(System.Char[] chars, System.Int32 start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format) { }
        // RVA: 0x092BEEA0  token: 0x6000286
        private static System.Int32 WriteDefaultIsoDate(System.Char[] chars, System.Int32 start, System.DateTime dt) { }
        // RVA: 0x092BC9F0  token: 0x6000287
        private static System.Void CopyIntToCharArray(System.Char[] chars, System.Int32 start, System.Int32 value, System.Int32 digits) { }
        // RVA: 0x092BE888  token: 0x6000288
        private static System.Int32 WriteDateTimeOffset(System.Char[] chars, System.Int32 start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format) { }
        // RVA: 0x092BE6F8  token: 0x6000289
        private static System.Void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture) { }
        // RVA: 0x092BCCD8  token: 0x600028A
        private static System.Void GetDateValues(System.DateTime td, System.Int32& year, System.Int32& month, System.Int32& day) { }

    }

    // TypeToken: 0x2000051
    public interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
    {
        // Properties
        System.Object UnderlyingDictionary { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000052
    public class DictionaryWrapper`2 : System.Collections.Generic.IDictionary`2, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedDictionary, System.Collections.IDictionary, System.Collections.ICollection
    {
        // Fields
        private readonly System.Collections.IDictionary _dictionary;  // 0x0
        private readonly System.Collections.Generic.IDictionary<TKey,TValue> _genericDictionary;  // 0x0
        private readonly System.Collections.Generic.IReadOnlyDictionary<TKey,TValue> _readOnlyDictionary;  // 0x0
        private System.Object _syncRoot;  // 0x0

        // Properties
        System.Collections.Generic.IDictionary<TKey,TValue> GenericDictionary { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TKey> Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TValue> Values { get; /* RVA: -1  // not resolved */ }
        TValue Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IDictionary.Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.IDictionary.IsFixedSize { get; /* RVA: -1  // not resolved */ }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.ICollection System.Collections.IDictionary.Values { get; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: -1  // not resolved */ }
        System.Object UnderlyingDictionary { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600028D
        public virtual System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x600028E
        public virtual System.Boolean ContainsKey(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000290
        public virtual System.Boolean Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000291
        public virtual System.Boolean TryGetValue(TKey key, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x6000295
        public virtual System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000296
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000297
        public virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000298
        public virtual System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x600029B
        public virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x600029C
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600029D
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600029E
        private virtual System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x60002A1
        private virtual System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002A2
        private virtual System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        // RVA: -1  // not resolved  token: 0x60002A5
        public virtual System.Void Remove(System.Object key) { }
        // RVA: -1  // not resolved  token: 0x60002A7
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }

    }

    // TypeToken: 0x2000055
    public class DynamicProxy`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60002B5
        public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }
        // RVA: -1  // not resolved  token: 0x60002B6
        public virtual System.Boolean TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002B7
        public virtual System.Boolean TryConvert(T instance, System.Dynamic.ConvertBinder binder, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002B8
        public virtual System.Boolean TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, System.Object[] args, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002B9
        public virtual System.Boolean TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, System.Object[] indexes) { }
        // RVA: -1  // not resolved  token: 0x60002BA
        public virtual System.Boolean TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002BB
        public virtual System.Boolean TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, System.Object[] indexes, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002BC
        public virtual System.Boolean TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002BD
        public virtual System.Boolean TryInvoke(T instance, System.Dynamic.InvokeBinder binder, System.Object[] args, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002BE
        public virtual System.Boolean TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, System.Object[] args, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002BF
        public virtual System.Boolean TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, System.Object[] indexes, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x60002C0
        public virtual System.Boolean TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x60002C1
        public virtual System.Boolean TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, System.Object& result) { }
        // RVA: -1  // not resolved  token: 0x60002C2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public sealed class DynamicProxyMetaObject`1 : System.Dynamic.DynamicMetaObject
    {
        // Fields
        private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;  // 0x0

        // Properties
        System.Linq.Expressions.Expression[] NoArgs { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002C3
        private System.Void .ctor(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }
        // RVA: -1  // not resolved  token: 0x60002C4
        private System.Boolean IsOverridden(System.String method) { }
        // RVA: -1  // not resolved  token: 0x60002C5
        public virtual System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002C6
        public virtual System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) { }
        // RVA: -1  // not resolved  token: 0x60002C7
        public virtual System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002C8
        public virtual System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002C9
        public virtual System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        // RVA: -1  // not resolved  token: 0x60002CA
        public virtual System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        // RVA: -1  // not resolved  token: 0x60002CB
        public virtual System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        // RVA: -1  // not resolved  token: 0x60002CC
        public virtual System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg) { }
        // RVA: -1  // not resolved  token: 0x60002CD
        public virtual System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002CE
        public virtual System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        // RVA: -1  // not resolved  token: 0x60002CF
        public virtual System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { }
        // RVA: -1  // not resolved  token: 0x60002D0
        public virtual System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        // RVA: -1  // not resolved  token: 0x60002D2
        private static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args) { }
        // RVA: -1  // not resolved  token: 0x60002D3
        private static System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args) { }
        // RVA: -1  // not resolved  token: 0x60002D4
        private static System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value) { }
        // RVA: -1  // not resolved  token: 0x60002D5
        private static System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder) { }
        // RVA: -1  // not resolved  token: 0x60002D6
        private System.Dynamic.DynamicMetaObject CallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
        // RVA: -1  // not resolved  token: 0x60002D7
        private System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
        // RVA: -1  // not resolved  token: 0x60002D8
        private System.Dynamic.DynamicMetaObject CallMethodReturnLast(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback) { }
        // RVA: -1  // not resolved  token: 0x60002D9
        private System.Dynamic.DynamicMetaObject CallMethodNoResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback) { }
        // RVA: -1  // not resolved  token: 0x60002DA
        private System.Dynamic.BindingRestrictions GetRestrictions() { }
        // RVA: -1  // not resolved  token: 0x60002DB
        public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }

    }

    // TypeToken: 0x2000066  // size: 0x10
    public static class DynamicUtils
    {
        // Methods
        // RVA: 0x092BFFDC  token: 0x60002FC
        public static System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider) { }

    }

    // TypeToken: 0x2000068  // size: 0x30
    public class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
    {
        // Fields
        private readonly System.Dynamic.GetMemberBinder _innerBinder;  // 0x28

        // Methods
        // RVA: 0x092C1C78  token: 0x6000302
        public System.Void .ctor(System.Dynamic.GetMemberBinder innerBinder) { }
        // RVA: 0x092C1B9C  token: 0x6000303
        public virtual System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000069  // size: 0x30
    public class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
    {
        // Fields
        private readonly System.Dynamic.SetMemberBinder _innerBinder;  // 0x28

        // Methods
        // RVA: 0x092C1DCC  token: 0x6000304
        public System.Void .ctor(System.Dynamic.SetMemberBinder innerBinder) { }
        // RVA: 0x092C1CBC  token: 0x6000305
        public virtual System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x200006A  // size: 0x10
    public class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
    {
        // Fields
        private static readonly System.Object ErrorResult;  // static @ 0x0

        // Methods
        // RVA: 0x092C1A50  token: 0x6000306
        protected virtual System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) { }
        // RVA: 0x0350B670  token: 0x6000307
        public System.Void .ctor() { }
        // RVA: 0x092C1B2C  token: 0x6000308
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x30
    public class EnumInfo
    {
        // Fields
        public readonly System.Boolean IsFlags;  // 0x10
        public readonly System.UInt64[] Values;  // 0x18
        public readonly System.String[] Names;  // 0x20
        public readonly System.String[] ResolvedNames;  // 0x28

        // Methods
        // RVA: 0x026BCEF0  token: 0x6000309
        public System.Void .ctor(System.Boolean isFlags, System.UInt64[] values, System.String[] names, System.String[] resolvedNames) { }

    }

    // TypeToken: 0x200006C  // size: 0x10
    public static class EnumUtils
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;  // static @ 0x0
        private static Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;  // static @ 0x8

        // Methods
        // RVA: 0x026BB510  token: 0x600030A
        private static Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }
        // RVA: 0x092C0280  token: 0x600030B
        public static System.Boolean TryToString(System.Type enumType, System.Object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String& name) { }
        // RVA: 0x092C0044  token: 0x600030C
        private static System.String InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, System.UInt64 result) { }
        // RVA: 0x02905550  token: 0x600030D
        public static Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType) { }
        // RVA: 0x026BB950  token: 0x600030E
        private static System.UInt64 ToUInt64(System.Object value) { }
        // RVA: 0x02476130  token: 0x600030F
        public static System.Object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String value, System.Boolean disallowNumber) { }
        // RVA: 0x092C01BC  token: 0x6000310
        private static System.Nullable<System.Int32> MatchName(System.String value, System.String[] enumNames, System.String[] resolvedNames, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison) { }
        // RVA: 0x02476360  token: 0x6000311
        private static System.Nullable<System.Int32> FindIndexByName(System.String[] enumNames, System.String value, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison) { }
        // RVA: 0x03B37790  token: 0x6000312
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x20
    public class FSharpFunction
    {
        // Fields
        private readonly System.Object _instance;  // 0x10
        private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker;  // 0x18

        // Methods
        // RVA: 0x02676770  token: 0x6000316
        public System.Void .ctor(System.Object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }
        // RVA: 0x092C0408  token: 0x6000317
        public System.Object Invoke(System.Object[] args) { }

    }

    // TypeToken: 0x200006F  // size: 0x70
    public class FSharpUtils
    {
        // Fields
        private static readonly System.Object Lock;  // static @ 0x0
        private static Newtonsoft.Json.Utilities.FSharpUtils _instance;  // static @ 0x8
        private System.Reflection.MethodInfo _ofSeq;  // 0x10
        private System.Type _mapType;  // 0x18
        private System.Reflection.Assembly <FSharpCoreAssembly>k__BackingField;  // 0x20
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <IsUnion>k__BackingField;  // 0x28
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCases>k__BackingField;  // 0x30
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionTagReader>k__BackingField;  // 0x38
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionReader>k__BackingField;  // 0x40
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionConstructor>k__BackingField;  // 0x48
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoDeclaringType>k__BackingField;  // 0x50
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoName>k__BackingField;  // 0x58
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoTag>k__BackingField;  // 0x60
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCaseInfoFields>k__BackingField;  // 0x68

        // Properties
        Newtonsoft.Json.Utilities.FSharpUtils Instance { get; /* RVA: 0x092C0E28 */ }
        System.Reflection.Assembly FSharpCoreAssembly { set; /* RVA: 0x04271930 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> IsUnion { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> GetUnionCases { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> PreComputeUnionTagReader { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> PreComputeUnionReader { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> PreComputeUnionConstructor { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.Func<System.Object,System.Object> GetUnionCaseInfoDeclaringType { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Func<System.Object,System.Object> GetUnionCaseInfoName { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        System.Func<System.Object,System.Object> GetUnionCaseInfoTag { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> GetUnionCaseInfoFields { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }

        // Methods
        // RVA: 0x092C0A48  token: 0x6000318
        private System.Void .ctor(System.Reflection.Assembly fsharpCoreAssembly) { }
        // RVA: 0x092C07C8  token: 0x600032D
        public static System.Void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly) { }
        // RVA: 0x092C097C  token: 0x600032E
        private static System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, System.String methodName, System.Reflection.BindingFlags bindingFlags) { }
        // RVA: 0x092C0438  token: 0x600032F
        private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(System.Type type, System.String methodName) { }
        // RVA: 0x092C0708  token: 0x6000330
        public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(System.Type t) { }
        // RVA: 0x092C05B8  token: 0x6000331
        public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(System.Type keyType, System.Type valueType) { }
        // RVA: -1  // generic def  token: 0x6000332
        public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }
        // RVA: 0x092C09D8  token: 0x6000333
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000073  // size: 0x10
    public static class ImmutableCollectionsUtils
    {
        // Fields
        private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;  // static @ 0x0
        private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;  // static @ 0x8

        // Methods
        // RVA: 0x0308DDD0  token: 0x600033B
        private static System.Boolean TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }
        // RVA: 0x0308EEC0  token: 0x600033C
        private static System.Boolean TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }
        // RVA: 0x03704CB0  token: 0x600033D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000078  // size: 0x10
    public static class BufferUtils
    {
        // Methods
        // RVA: 0x029075A0  token: 0x600034D
        public static System.Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 minSize) { }
        // RVA: 0x030AB590  token: 0x600034E
        public static System.Void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer) { }
        // RVA: 0x092B96EC  token: 0x600034F
        public static System.Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 size, System.Char[] buffer) { }

    }

    // TypeToken: 0x2000079  // size: 0x10
    public static class JavaScriptUtils
    {
        // Fields
        private static readonly System.Boolean[] SingleQuoteCharEscapeFlags;  // static @ 0x0
        private static readonly System.Boolean[] DoubleQuoteCharEscapeFlags;  // static @ 0x8
        private static readonly System.Boolean[] HtmlCharEscapeFlags;  // static @ 0x10

        // Methods
        // RVA: 0x03216A60  token: 0x6000350
        private static System.Void .cctor() { }
        // RVA: 0x026979C0  token: 0x6000351
        public static System.Boolean[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, System.Char quoteChar) { }
        // RVA: 0x024E6A40  token: 0x6000352
        public static System.Boolean ShouldEscapeJavaScriptString(System.String s, System.Boolean[] charEscapeFlags) { }
        // RVA: 0x02905EF0  token: 0x6000353
        public static System.Void WriteEscapedJavaScriptString(System.IO.TextWriter writer, System.String s, System.Char delimiter, System.Boolean appendDelimiters, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[]& writeBuffer) { }
        // RVA: 0x092C0E78  token: 0x6000354
        public static System.String ToEscapedJavaScriptString(System.String value, System.Char delimiter, System.Boolean appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        // RVA: 0x02906D50  token: 0x6000355
        private static System.Int32 FirstCharToEscape(System.String s, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        // RVA: 0x092C115C  token: 0x6000356
        public static System.Boolean TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, System.DateTime& dateTime, System.String& errorMessage) { }
        // RVA: 0x092C1000  token: 0x6000357
        private static System.Boolean TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, System.Nullable<System.Int64>& integer, System.String& errorMessage) { }

    }

    // TypeToken: 0x200007A  // size: 0x10
    public static class JsonTokenUtils
    {
        // Methods
        // RVA: 0x0269A4F0  token: 0x6000358
        private static System.Boolean IsEndToken(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x0269A900  token: 0x6000359
        private static System.Boolean IsStartToken(Newtonsoft.Json.JsonToken token) { }
        // RVA: 0x037E7D50  token: 0x600035A
        private static System.Boolean IsPrimitiveToken(Newtonsoft.Json.JsonToken token) { }

    }

    // TypeToken: 0x200007B  // size: 0x10
    public class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;  // static @ 0x0

        // Properties
        Newtonsoft.Json.Utilities.ReflectionDelegateFactory Instance { get; /* RVA: 0x092C15F0 */ }

        // Methods
        // RVA: 0x038DD3E0  token: 0x600035C
        public virtual Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method) { }
        // RVA: -1  // generic def  token: 0x600035D
        public virtual Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method) { }
        // RVA: -1  // generic def  token: 0x600035E
        public virtual System.Func<T> CreateDefaultConstructor(System.Type type) { }
        // RVA: -1  // generic def  token: 0x600035F
        public virtual System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: -1  // generic def  token: 0x6000360
        public virtual System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo) { }
        // RVA: -1  // generic def  token: 0x6000361
        public virtual System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo) { }
        // RVA: -1  // generic def  token: 0x6000362
        public virtual System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: 0x0350B670  token: 0x6000363
        public System.Void .ctor() { }
        // RVA: 0x03D1B4D0  token: 0x6000364
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x10
    public static class MathUtils
    {
        // Methods
        // RVA: 0x02905A20  token: 0x6000376
        public static System.Int32 IntLength(System.UInt64 i) { }
        // RVA: 0x092C16E0  token: 0x6000377
        public static System.Char IntToHex(System.Int32 n) { }
        // RVA: 0x092C1640  token: 0x6000378
        public static System.Boolean ApproxEquals(System.Double d1, System.Double d2) { }

    }

    // TypeToken: 0x2000084
    public sealed class MethodCall`2 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000379
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x600037A
        public virtual TResult Invoke(T target, System.Object[] args) { }

    }

    // TypeToken: 0x2000085  // size: 0x10
    public static class MiscellaneousUtils
    {
        // Methods
        // RVA: 0x03387590  token: 0x600037B
        public static System.Boolean ValueEquals(System.Object objA, System.Object objB) { }
        // RVA: 0x092C1778  token: 0x600037C
        public static System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(System.String paramName, System.Object actualValue, System.String message) { }
        // RVA: 0x092C19CC  token: 0x600037D
        public static System.String ToString(System.Object value) { }
        // RVA: 0x092C16F0  token: 0x600037E
        public static System.Int32 ByteArrayCompare(System.Byte[] a1, System.Byte[] a2) { }
        // RVA: 0x092C1880  token: 0x600037F
        public static System.String GetPrefix(System.String qualifiedName) { }
        // RVA: 0x092C1854  token: 0x6000380
        public static System.String GetLocalName(System.String qualifiedName) { }
        // RVA: 0x092C18AC  token: 0x6000381
        public static System.Void GetQualifiedNameParts(System.String qualifiedName, System.String& prefix, System.String& localName) { }
        // RVA: 0x092C1950  token: 0x6000382
        private static System.Text.RegularExpressions.RegexOptions GetRegexOptions(System.String optionsText) { }

    }

    // TypeToken: 0x2000086  // size: 0x10
    public abstract class ReflectionDelegateFactory
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000383
        public System.Func<T,System.Object> CreateGet(System.Reflection.MemberInfo memberInfo) { }
        // RVA: -1  // generic def  token: 0x6000384
        public System.Action<T,System.Object> CreateSet(System.Reflection.MemberInfo memberInfo) { }
        // RVA: -1  // abstract  token: 0x6000385
        public virtual Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method) { }
        // RVA: -1  // abstract  token: 0x6000386
        public virtual Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method) { }
        // RVA: -1  // abstract  token: 0x6000387
        public virtual System.Func<T> CreateDefaultConstructor(System.Type type) { }
        // RVA: -1  // abstract  token: 0x6000388
        public virtual System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: -1  // abstract  token: 0x6000389
        public virtual System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo) { }
        // RVA: -1  // abstract  token: 0x600038A
        public virtual System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo) { }
        // RVA: -1  // abstract  token: 0x600038B
        public virtual System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: 0x0350B670  token: 0x600038C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000087  // size: 0x28
    public class ReflectionMember
    {
        // Fields
        private System.Type <MemberType>k__BackingField;  // 0x10
        private System.Func<System.Object,System.Object> <Getter>k__BackingField;  // 0x18
        private System.Action<System.Object,System.Object> <Setter>k__BackingField;  // 0x20

        // Properties
        System.Type MemberType { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Func<System.Object,System.Object> Getter { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Action<System.Object,System.Object> Setter { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000393
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x20
    public class ReflectionObject
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField;  // 0x10
        private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;  // 0x18

        // Properties
        Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> Creator { get; /* RVA: 0x020B7B20 */ }
        System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> Members { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x092C266C  token: 0x6000396
        private System.Void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }
        // RVA: 0x092C2574  token: 0x6000397
        public System.Object GetValue(System.Object target, System.String member) { }
        // RVA: 0x092C25E8  token: 0x6000398
        public System.Void SetValue(System.Object target, System.String member, System.Object value) { }
        // RVA: 0x092C251C  token: 0x6000399
        public System.Type GetType(System.String member) { }
        // RVA: 0x092C1E10  token: 0x600039A
        public static Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.String[] memberNames) { }
        // RVA: 0x092C1E20  token: 0x600039B
        public static Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, System.String[] memberNames) { }

    }

    // TypeToken: 0x200008C  // size: 0x10
    public static class ReflectionUtils
    {
        // Fields
        public static readonly System.Type[] EmptyTypes;  // static @ 0x0

        // Methods
        // RVA: 0x03CFF250  token: 0x60003A2
        private static System.Void .cctor() { }
        // RVA: 0x02541360  token: 0x60003A3
        public static System.Boolean IsVirtual(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: 0x02479E00  token: 0x60003A4
        public static System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo) { }
        // RVA: 0x02479FB0  token: 0x60003A5
        public static System.Boolean IsPublic(System.Reflection.PropertyInfo property) { }
        // RVA: 0x02419740  token: 0x60003A6
        public static System.Type GetObjectType(System.Object v) { }
        // RVA: 0x092C2DB8  token: 0x60003A7
        public static System.String GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder) { }
        // RVA: 0x092C2CA8  token: 0x60003A8
        private static System.String GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder) { }
        // RVA: 0x092C2F74  token: 0x60003A9
        private static System.String RemoveAssemblyDetails(System.String fullyQualifiedTypeName) { }
        // RVA: 0x02475D80  token: 0x60003AA
        public static System.Boolean HasDefaultConstructor(System.Type t, System.Boolean nonPublic) { }
        // RVA: 0x024756B0  token: 0x60003AB
        public static System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t) { }
        // RVA: 0x02475700  token: 0x60003AC
        public static System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, System.Boolean nonPublic) { }
        // RVA: 0x02476A80  token: 0x60003AD
        public static System.Boolean IsNullable(System.Type t) { }
        // RVA: 0x02478570  token: 0x60003AE
        public static System.Boolean IsNullableType(System.Type t) { }
        // RVA: 0x02475900  token: 0x60003AF
        public static System.Type EnsureNotNullableType(System.Type t) { }
        // RVA: 0x02477850  token: 0x60003B0
        public static System.Type EnsureNotByRefType(System.Type t) { }
        // RVA: 0x0308EE30  token: 0x60003B1
        public static System.Boolean IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) { }
        // RVA: 0x02478010  token: 0x60003B2
        public static System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) { }
        // RVA: 0x02478400  token: 0x60003B3
        public static System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, System.Type& implementingType) { }
        // RVA: 0x0308EB80  token: 0x60003B4
        public static System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition) { }
        // RVA: 0x0308EBF0  token: 0x60003B5
        public static System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, System.Type& implementingType) { }
        // RVA: 0x0308ECD0  token: 0x60003B6
        private static System.Boolean InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, System.Type& implementingType) { }
        // RVA: 0x0308F0C0  token: 0x60003B7
        public static System.Type GetCollectionItemType(System.Type type) { }
        // RVA: 0x092C29C0  token: 0x60003B8
        public static System.Void GetDictionaryKeyValueTypes(System.Type dictionaryType, System.Type& keyType, System.Type& valueType) { }
        // RVA: 0x024E5800  token: 0x60003B9
        public static System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member) { }
        // RVA: 0x024E7370  token: 0x60003BA
        public static System.Boolean IsByRefLikeType(System.Type type) { }
        // RVA: 0x02478AE0  token: 0x60003BB
        public static System.Boolean IsIndexedProperty(System.Reflection.PropertyInfo property) { }
        // RVA: 0x0232C7D0  token: 0x60003BC
        public static System.Object GetMemberValue(System.Reflection.MemberInfo member, System.Object target) { }
        // RVA: 0x023279A0  token: 0x60003BD
        public static System.Void SetMemberValue(System.Reflection.MemberInfo member, System.Object target, System.Object value) { }
        // RVA: 0x024E5CE0  token: 0x60003BE
        public static System.Boolean CanReadMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic) { }
        // RVA: 0x024E5E10  token: 0x60003BF
        public static System.Boolean CanSetMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic, System.Boolean canSetReadOnly) { }
        // RVA: 0x025E1470  token: 0x60003C0
        public static System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: 0x03C85780  token: 0x60003C1
        private static System.Boolean IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: -1  // generic def  token: 0x60003C2
        public static T GetAttribute(System.Object attributeProvider) { }
        // RVA: -1  // generic def  token: 0x60003C3
        public static T GetAttribute(System.Object attributeProvider, System.Boolean inherit) { }
        // RVA: -1  // generic def  token: 0x60003C4
        public static T[] GetAttributes(System.Object attributeProvider, System.Boolean inherit) { }
        // RVA: 0x024E32B0  token: 0x60003C5
        public static System.Attribute[] GetAttributes(System.Object attributeProvider, System.Type attributeType, System.Boolean inherit) { }
        // RVA: 0x027BCFF0  token: 0x60003C6
        public static Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(System.String fullyQualifiedTypeName) { }
        // RVA: 0x027BEBA0  token: 0x60003C7
        private static System.Nullable<System.Int32> GetAssemblyDelimiterIndex(System.String fullyQualifiedTypeName) { }
        // RVA: 0x024E2400  token: 0x60003C8
        public static System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x025E1360  token: 0x60003C9
        public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: 0x025E1160  token: 0x60003CA
        private static System.Void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: 0x02478680  token: 0x60003CB
        public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: 0x034EF0B0  token: 0x60003CC
        public static System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag) { }
        // RVA: 0x02478B40  token: 0x60003CD
        private static System.Void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        // RVA: 0x092C2E7C  token: 0x60003CE
        public static System.Boolean IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, System.String method) { }
        // RVA: 0x092C26FC  token: 0x60003CF
        public static System.Object GetDefaultValue(System.Type type) { }

    }

    // TypeToken: 0x2000092  // size: 0x20
    public sealed struct StringBuffer
    {
        // Fields
        private System.Char[] _buffer;  // 0x10
        private System.Int32 _position;  // 0x18

        // Properties
        System.Int32 Position { get; /* RVA: 0x03D516F0 */ set; /* RVA: 0x03D51710 */ }
        System.Boolean IsEmpty { get; /* RVA: 0x02361C20 */ }
        System.Char[] InternalBuffer { get; /* RVA: 0x020C61B0 */ }

        // Methods
        // RVA: 0x02905860  token: 0x60003E2
        public System.Void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 initalSize) { }
        // RVA: 0x04271F74  token: 0x60003E3
        private System.Void .ctor(System.Char[] buffer) { }
        // RVA: 0x033B9D00  token: 0x60003E4
        public System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char value) { }
        // RVA: 0x033B9D60  token: 0x60003E5
        public System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer, System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x030AB5E0  token: 0x60003E6
        public System.Void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }
        // RVA: 0x092C3090  token: 0x60003E7
        private System.Void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 appendLength) { }
        // RVA: 0x092C30FC  token: 0x60003E8
        public virtual System.String ToString() { }
        // RVA: 0x092C310C  token: 0x60003E9
        public System.String ToString(System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x2000093  // size: 0x20
    public sealed struct StringReference
    {
        // Fields
        private readonly System.Char[] _chars;  // 0x10
        private readonly System.Int32 _startIndex;  // 0x18
        private readonly System.Int32 _length;  // 0x1c

        // Properties
        System.Char Item { get; /* RVA: 0x029062E0 */ }
        System.Char[] Chars { get; /* RVA: 0x020C61B0 */ }
        System.Int32 StartIndex { get; /* RVA: 0x03D516F0 */ }
        System.Int32 Length { get; /* RVA: 0x03D4FBF0 */ }

        // Methods
        // RVA: 0x0426FA34  token: 0x60003EF
        public System.Void .ctor(System.Char[] chars, System.Int32 startIndex, System.Int32 length) { }
        // RVA: 0x0426F9F0  token: 0x60003F0
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000094  // size: 0x10
    public static class StringReferenceExtensions
    {
        // Methods
        // RVA: 0x092C31BC  token: 0x60003F1
        public static System.Int32 IndexOf(Newtonsoft.Json.Utilities.StringReference s, System.Char c, System.Int32 startIndex, System.Int32 length) { }
        // RVA: 0x092C323C  token: 0x60003F2
        public static System.Boolean StartsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text) { }
        // RVA: 0x092C3130  token: 0x60003F3
        public static System.Boolean EndsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text) { }

    }

    // TypeToken: 0x2000095  // size: 0x10
    public static class StringUtils
    {
        // Methods
        // RVA: 0x04271F60  token: 0x60003F4
        public static System.Boolean IsNullOrEmpty(System.String value) { }
        // RVA: 0x092C363C  token: 0x60003F5
        public static System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0) { }
        // RVA: 0x092C36D4  token: 0x60003F6
        public static System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1) { }
        // RVA: 0x092C355C  token: 0x60003F7
        public static System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2) { }
        // RVA: 0x092C3460  token: 0x60003F8
        public static System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3) { }
        // RVA: 0x092C33B8  token: 0x60003F9
        private static System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object[] args) { }
        // RVA: 0x092C32C4  token: 0x60003FA
        public static System.IO.StringWriter CreateStringWriter(System.Int32 capacity) { }
        // RVA: 0x092C3A28  token: 0x60003FB
        public static System.Void ToCharAsUnicode(System.Char c, System.Char[] buffer) { }
        // RVA: -1  // generic def  token: 0x60003FC
        public static TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, System.String testValue) { }
        // RVA: 0x092C387C  token: 0x60003FD
        public static System.String ToCamelCase(System.String s) { }
        // RVA: 0x092C3B08  token: 0x60003FE
        private static System.Char ToLower(System.Char c) { }
        // RVA: 0x092C3DC0  token: 0x60003FF
        public static System.String ToSnakeCase(System.String s) { }
        // RVA: 0x092C3AF8  token: 0x6000400
        public static System.String ToKebabCase(System.String s) { }
        // RVA: 0x092C3B78  token: 0x6000401
        private static System.String ToSeparatedCase(System.String s, System.Char separator) { }
        // RVA: 0x092C37B0  token: 0x6000402
        public static System.Boolean IsHighSurrogate(System.Char c) { }
        // RVA: 0x092C37FC  token: 0x6000403
        public static System.Boolean IsLowSurrogate(System.Char c) { }
        // RVA: 0x092C3794  token: 0x6000404
        public static System.Int32 IndexOf(System.String s, System.Char c) { }
        // RVA: 0x092C3848  token: 0x6000405
        public static System.Boolean StartsWith(System.String source, System.Char value) { }
        // RVA: 0x092C3380  token: 0x6000406
        public static System.Boolean EndsWith(System.String source, System.Char value) { }
        // RVA: 0x027BD180  token: 0x6000407
        public static System.String Trim(System.String s, System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x2000098
    public sealed struct StructMultiKey`2 : System.IEquatable`1
    {
        // Fields
        public readonly T1 Value1;  // 0x0
        public readonly T2 Value2;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600040B
        public System.Void .ctor(T1 v1, T2 v2) { }
        // RVA: -1  // not resolved  token: 0x600040C
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x600040D
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: -1  // not resolved  token: 0x600040E
        public virtual System.Boolean Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

    }

    // TypeToken: 0x2000099
    public class ThreadSafeStore`2
    {
        // Fields
        private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore;  // 0x0
        private readonly System.Func<TKey,TValue> _creator;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600040F
        public System.Void .ctor(System.Func<TKey,TValue> creator) { }
        // RVA: -1  // not resolved  token: 0x6000410
        public TValue Get(TKey key) { }

    }

    // TypeToken: 0x200009A  // size: 0x10
    public static class TypeExtensions
    {
        // Methods
        // RVA: 0x023206F0  token: 0x6000411
        public static System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo) { }
        // RVA: 0x092C3DF0  token: 0x6000412
        public static System.Boolean ContainsGenericParameters(System.Type type) { }
        // RVA: 0x02478640  token: 0x6000413
        public static System.Boolean IsInterface(System.Type type) { }
        // RVA: 0x02478620  token: 0x6000414
        public static System.Boolean IsGenericType(System.Type type) { }
        // RVA: 0x02478660  token: 0x6000415
        public static System.Boolean IsGenericTypeDefinition(System.Type type) { }
        // RVA: 0x024E7600  token: 0x6000416
        public static System.Type BaseType(System.Type type) { }
        // RVA: 0x092C3DD0  token: 0x6000417
        public static System.Reflection.Assembly Assembly(System.Type type) { }
        // RVA: 0x02477240  token: 0x6000418
        public static System.Boolean IsEnum(System.Type type) { }
        // RVA: 0x0308ECB0  token: 0x6000419
        public static System.Boolean IsClass(System.Type type) { }
        // RVA: 0x02476B00  token: 0x600041A
        public static System.Boolean IsSealed(System.Type type) { }
        // RVA: 0x02476B50  token: 0x600041B
        public static System.Boolean IsAbstract(System.Type type) { }
        // RVA: 0x092C4078  token: 0x600041C
        public static System.Boolean IsVisible(System.Type type) { }
        // RVA: 0x0247C260  token: 0x600041D
        public static System.Boolean IsValueType(System.Type type) { }
        // RVA: 0x024E7480  token: 0x600041E
        public static System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces, System.Type& match) { }
        // RVA: 0x04275F58  token: 0x600041F
        public static System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces) { }
        // RVA: 0x092C3E10  token: 0x6000420
        public static System.Boolean ImplementInterface(System.Type type, System.Type interfaceType) { }

    }

    // TypeToken: 0x200009B  // size: 0x10
    public static class ValidationUtils
    {
        // Methods
        // RVA: 0x02327960  token: 0x6000421
        public static System.Void ArgumentNotNull(System.Object value, System.String parameterName) { }

    }

}

namespace System.Diagnostics.CodeAnalysis
{

    // TypeToken: 0x2000006  // size: 0x10
    public sealed class NotNullAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public sealed class NotNullWhenAttribute : System.Attribute
    {
        // Fields
        private readonly System.Boolean <ReturnValue>k__BackingField;  // 0x10

        // Methods
        // RVA: 0x03D4E960  token: 0x6000007
        public System.Void .ctor(System.Boolean returnValue) { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsReadOnlyAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class NullableAttribute : System.Attribute
    {
        // Fields
        public readonly System.Byte[] NullableFlags;  // 0x10

        // Methods
        // RVA: 0x03134A00  token: 0x6000003
        public System.Void .ctor(System.Byte ) { }
        // RVA: 0x0426FEE0  token: 0x6000004
        public System.Void .ctor(System.Byte[] ) { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public sealed class NullableContextAttribute : System.Attribute
    {
        // Fields
        public readonly System.Byte Flag;  // 0x10

        // Methods
        // RVA: 0x03D4E960  token: 0x6000005
        public System.Void .ctor(System.Byte ) { }

    }

}

