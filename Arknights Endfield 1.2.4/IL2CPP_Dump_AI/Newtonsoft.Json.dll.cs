// ========================================================
// Dumped by @desirepro
// Assembly: Newtonsoft.Json.dll
// Classes:  309
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

CLASS: Entry
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x28
FIELDS:
  private   readonly System.String                   Value  // 0x10
  private   readonly System.Int32                    HashCode  // 0x18
  private           Newtonsoft.Json.DefaultJsonNameTable.EntryNext  // 0x20
METHODS:
  RVA=0x03020510  token=0x600000F  System.Void .ctor(System.String value, System.Int32 hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next)
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonReader.StateStart  // const
  public    static  Newtonsoft.Json.JsonReader.StateComplete  // const
  public    static  Newtonsoft.Json.JsonReader.StateProperty  // const
  public    static  Newtonsoft.Json.JsonReader.StateObjectStart  // const
  public    static  Newtonsoft.Json.JsonReader.StateObject  // const
  public    static  Newtonsoft.Json.JsonReader.StateArrayStart  // const
  public    static  Newtonsoft.Json.JsonReader.StateArray  // const
  public    static  Newtonsoft.Json.JsonReader.StateClosed  // const
  public    static  Newtonsoft.Json.JsonReader.StatePostValue  // const
  public    static  Newtonsoft.Json.JsonReader.StateConstructorStart  // const
  public    static  Newtonsoft.Json.JsonReader.StateConstructor  // const
  public    static  Newtonsoft.Json.JsonReader.StateError  // const
  public    static  Newtonsoft.Json.JsonReader.StateFinished  // const
METHODS:
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonWriter.StateStart  // const
  public    static  Newtonsoft.Json.JsonWriter.StateProperty  // const
  public    static  Newtonsoft.Json.JsonWriter.StateObjectStart  // const
  public    static  Newtonsoft.Json.JsonWriter.StateObject  // const
  public    static  Newtonsoft.Json.JsonWriter.StateArrayStart  // const
  public    static  Newtonsoft.Json.JsonWriter.StateArray  // const
  public    static  Newtonsoft.Json.JsonWriter.StateConstructorStart  // const
  public    static  Newtonsoft.Json.JsonWriter.StateConstructor  // const
  public    static  Newtonsoft.Json.JsonWriter.StateClosed  // const
  public    static  Newtonsoft.Json.JsonWriter.StateError  // const
METHODS:
END_CLASS

CLASS: <>c__2`1
TYPE:  sealed class
TOKEN: 0x2000040
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.AotHelper.<>c__2<T><>9  // static @ 0x0
  public    static  System.Action                   <>9__2_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000209  System.Void .cctor()
  RVA=-1  // not resolved  token=0x600020A  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600020B  System.Void <EnsureList>b__2_0()
END_CLASS

CLASS: EmptyArrayContainer`1
TYPE:  static class
TOKEN: 0x2000045
FIELDS:
  public    static readonly T[]                             Empty  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600022B  System.Void .cctor()
END_CLASS

CLASS: ConvertResult
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultSuccess  // const
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultCannotConvertNull  // const
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultNotInstantiableType  // const
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultNoValidConversion  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass8_0
TYPE:  sealed class
TOKEN: 0x200004D
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>call  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600025F  System.Void .ctor()
  RVA=0x092C44B0  token=0x6000260  System.Object <CreateCastConverter>b__0(System.Object o)
END_CLASS

CLASS: DictionaryEnumerator`2
TYPE:  sealed struct
TOKEN: 0x2000053
IMPLEMENTS: System.Collections.IDictionaryEnumerator System.Collections.IEnumerator
FIELDS:
  private   readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>>_e  // 0x0
PROPERTIES:
  Entry  get=-1  // not resolved
  Key  get=-1  // not resolved
  Value  get=-1  // not resolved
  Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60002AB  System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e)
  RVA=-1  // not resolved  token=0x60002B0  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60002B1  System.Void Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000054
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey,TValue><>9  // static @ 0x0
  public    static  System.Func<System.Collections.DictionaryEntry,System.Collections.Generic.KeyValuePair<TKey,TValue>><>9__29_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002B2  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60002B3  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002B4  System.Collections.Generic.KeyValuePair<TKey,TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de)
END_CLASS

CLASS: Fallback
TYPE:  sealed class
TOKEN: 0x2000057
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60002DC  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60002DD  System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: GetBinderAdapter
TYPE:  sealed class
TOKEN: 0x2000058
EXTENDS: System.Dynamic.GetMemberBinder
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60002DE  System.Void .ctor(System.Dynamic.InvokeMemberBinder binder)
  RVA=-1  // not resolved  token=0x60002DF  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000059
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T><>9  // static @ 0x0
  public    static  System.Func<System.Dynamic.DynamicMetaObject,System.Linq.Expressions.Expression><>9__18_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002E0  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60002E1  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002E2  System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg)
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x200005A
FIELDS:
  public            System.Dynamic.BinaryOperationBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObjectarg  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002E3  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002E4  System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass11_0
TYPE:  sealed class
TOKEN: 0x200005B
FIELDS:
  public            System.Dynamic.UnaryOperationBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002E5  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002E6  System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x200005C
FIELDS:
  public            System.Dynamic.GetIndexBinder   binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]indexes  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002E7  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002E8  System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x200005D
FIELDS:
  public            System.Dynamic.SetIndexBinder   binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]indexes  // 0x0
  public            System.Dynamic.DynamicMetaObjectvalue  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002E9  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002EA  System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass14_0
TYPE:  sealed class
TOKEN: 0x200005E
FIELDS:
  public            System.Dynamic.DeleteIndexBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]indexes  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002EB  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002EC  System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200005F
FIELDS:
  public            System.Dynamic.GetMemberBinder  binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002ED  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002EE  System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000060
FIELDS:
  public            System.Dynamic.SetMemberBinder  binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObjectvalue  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002EF  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002F0  System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass5_0
TYPE:  sealed class
TOKEN: 0x2000061
FIELDS:
  public            System.Dynamic.DeleteMemberBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002F1  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002F2  System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass6_0
TYPE:  sealed class
TOKEN: 0x2000062
FIELDS:
  public            System.Dynamic.ConvertBinder    binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002F3  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002F4  System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000063
FIELDS:
  public            System.Dynamic.InvokeMemberBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]args  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002F5  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002F6  System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e)
  RVA=-1  // not resolved  token=0x60002F7  System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass8_0
TYPE:  sealed class
TOKEN: 0x2000064
FIELDS:
  public            System.Dynamic.CreateInstanceBinderbinder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]args  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002F8  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002F9  System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: <>c__DisplayClass9_0
TYPE:  sealed class
TOKEN: 0x2000065
FIELDS:
  public            System.Dynamic.InvokeBinder     binder  // 0x0
  public            Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T><>4__this  // 0x0
  public            System.Dynamic.DynamicMetaObject[]args  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002FA  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002FB  System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e)
END_CLASS

CLASS: BinderWrapper
TYPE:  static class
TOKEN: 0x2000067
SIZE:  0x10
FIELDS:
  private   static  System.Object                   _getCSharpArgumentInfoArray  // static @ 0x0
  private   static  System.Object                   _setCSharpArgumentInfoArray  // static @ 0x8
  private   static  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_getMemberCall  // static @ 0x10
  private   static  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_setMemberCall  // static @ 0x18
  private   static  System.Boolean                  _init  // static @ 0x20
METHODS:
  RVA=0x092B92D4  token=0x60002FD  System.Void Init()
  RVA=0x092B8F38  token=0x60002FE  System.Object CreateSharpArgumentInfoArray(System.Int32[] values)
  RVA=0x092B8B6C  token=0x60002FF  System.Void CreateMemberCalls()
  RVA=0x092B9174  token=0x6000300  System.Runtime.CompilerServices.CallSiteBinder GetMember(System.String name, System.Type context)
  RVA=0x092B94D0  token=0x6000301  System.Runtime.CompilerServices.CallSiteBinder SetMember(System.String name, System.Type context)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200006D
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.EnumUtils.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Runtime.Serialization.EnumMemberAttribute,System.String><>9__3_0  // static @ 0x8
METHODS:
  RVA=0x03D187D0  token=0x6000313  System.Void .cctor()
  RVA=0x0350B670  token=0x6000314  System.Void .ctor()
  RVA=0x059311D0  token=0x6000315  System.String <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a)
END_CLASS

CLASS: <>c__55`2
TYPE:  sealed class
TOKEN: 0x2000070
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey,TValue><>9  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Tuple<TKey,TValue>><>9__55_1  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000334  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000335  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000336  System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv)
END_CLASS

CLASS: <>c__DisplayClass52_0
TYPE:  sealed class
TOKEN: 0x2000071
SIZE:  0x20
FIELDS:
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>call  // 0x10
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>invoke  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000337  System.Void .ctor()
  RVA=0x092C4418  token=0x6000338  System.Object <CreateFSharpFuncCall>b__0(System.Object target, System.Object[] args)
END_CLASS

CLASS: <>c__DisplayClass55_0`2
TYPE:  sealed class
TOKEN: 0x2000072
FIELDS:
  public            Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>ctorDelegate  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000339  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600033A  System.Object <BuildMapCreator>b__0(System.Object[] args)
END_CLASS

CLASS: ImmutableCollectionTypeInfo
TYPE:  class
TOKEN: 0x2000074
SIZE:  0x28
FIELDS:
  private           System.String                   <ContractTypeName>k__BackingField  // 0x10
  private           System.String                   <CreatedTypeName>k__BackingField  // 0x18
  private           System.String                   <BuilderTypeName>k__BackingField  // 0x20
PROPERTIES:
  ContractTypeName  get=0x020B7B20  set=0x0426FEE0
  CreatedTypeName  get=0x01041090  set=0x022C3A90
  BuilderTypeName  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0285BDC0  token=0x600033E  System.Void .ctor(System.String contractTypeName, System.String createdTypeName, System.String builderTypeName)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000075
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Reflection.MethodInfo,System.Boolean><>9__24_1  // static @ 0x8
  public    static  System.Func<System.Reflection.MethodInfo,System.Boolean><>9__25_1  // static @ 0x10
METHODS:
  RVA=0x092C4544  token=0x6000345  System.Void .cctor()
  RVA=0x0350B670  token=0x6000346  System.Void .ctor()
  RVA=0x092C4094  token=0x6000347  System.Boolean <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m)
  RVA=0x092C4108  token=0x6000348  System.Boolean <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m)
END_CLASS

CLASS: <>c__DisplayClass24_0
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000349  System.Void .ctor()
  RVA=0x03472150  token=0x600034A  System.Boolean <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
END_CLASS

CLASS: <>c__DisplayClass25_0
TYPE:  sealed class
TOKEN: 0x2000077
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600034B  System.Void .ctor()
  RVA=0x03472150  token=0x600034C  System.Boolean <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200007C
SIZE:  0x20
FIELDS:
  public            System.Reflection.ConstructorInfoc  // 0x10
  public            System.Reflection.MethodBase    method  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000365  System.Void .ctor()
  RVA=0x029D5B10  token=0x6000366  System.Object <CreateParameterizedConstructor>b__0(System.Object[] a)
  RVA=0x092C4318  token=0x6000367  System.Object <CreateParameterizedConstructor>b__1(System.Object[] a)
END_CLASS

CLASS: <>c__DisplayClass4_0`1
TYPE:  sealed class
TOKEN: 0x200007D
FIELDS:
  public            System.Reflection.ConstructorInfoc  // 0x0
  public            System.Reflection.MethodBase    method  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000368  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000369  System.Object <CreateMethodCall>b__0(T o, System.Object[] a)
  RVA=-1  // not resolved  token=0x600036A  System.Object <CreateMethodCall>b__1(T o, System.Object[] a)
END_CLASS

CLASS: <>c__DisplayClass5_0`1
TYPE:  sealed class
TOKEN: 0x200007E
FIELDS:
  public            System.Type                     type  // 0x0
  public            System.Reflection.ConstructorInfoconstructorInfo  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600036B  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600036C  T <CreateDefaultConstructor>b__0()
  RVA=-1  // not resolved  token=0x600036D  T <CreateDefaultConstructor>b__1()
END_CLASS

CLASS: <>c__DisplayClass6_0`1
TYPE:  sealed class
TOKEN: 0x200007F
FIELDS:
  public            System.Reflection.PropertyInfo  propertyInfo  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600036E  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600036F  System.Object <CreateGet>b__0(T o)
END_CLASS

CLASS: <>c__DisplayClass7_0`1
TYPE:  sealed class
TOKEN: 0x2000080
FIELDS:
  public            System.Reflection.FieldInfo     fieldInfo  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000370  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000371  System.Object <CreateGet>b__0(T o)
END_CLASS

CLASS: <>c__DisplayClass8_0`1
TYPE:  sealed class
TOKEN: 0x2000081
FIELDS:
  public            System.Reflection.FieldInfo     fieldInfo  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000372  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000373  System.Void <CreateSet>b__0(T o, System.Object v)
END_CLASS

CLASS: <>c__DisplayClass9_0`1
TYPE:  sealed class
TOKEN: 0x2000082
FIELDS:
  public            System.Reflection.PropertyInfo  propertyInfo  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000374  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000375  System.Void <CreateSet>b__0(T o, System.Object v)
END_CLASS

CLASS: <>c__DisplayClass11_0
TYPE:  sealed class
TOKEN: 0x2000089
SIZE:  0x18
FIELDS:
  public            System.Func<System.Object>      ctor  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600039C  System.Void .ctor()
  RVA=0x08551BB0  token=0x600039D  System.Object <Create>b__0(System.Object[] args)
END_CLASS

CLASS: <>c__DisplayClass11_1
TYPE:  sealed class
TOKEN: 0x200008A
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>call  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600039E  System.Void .ctor()
  RVA=0x092C420C  token=0x600039F  System.Object <Create>b__1(System.Object target)
END_CLASS

CLASS: <>c__DisplayClass11_2
TYPE:  sealed class
TOKEN: 0x200008B
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>call  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003A0  System.Void .ctor()
  RVA=0x092C4274  token=0x60003A1  System.Void <Create>b__2(System.Object target, System.Object arg)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200008D
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Utilities.ReflectionUtils.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Reflection.ConstructorInfo,System.Boolean><>9__11_0  // static @ 0x8
  public    static  System.Func<System.Reflection.MemberInfo,System.String><>9__31_0  // static @ 0x10
  public    static  System.Func<System.Reflection.ParameterInfo,System.Type><>9__39_0  // static @ 0x18
  public    static  System.Func<System.Reflection.FieldInfo,System.Boolean><>9__41_0  // static @ 0x20
METHODS:
  RVA=0x03D19550  token=0x60003D0  System.Void .cctor()
  RVA=0x0350B670  token=0x60003D1  System.Void .ctor()
  RVA=0x02479F50  token=0x60003D2  System.Boolean <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c)
  RVA=0x03133E50  token=0x60003D3  System.String <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m)
  RVA=0x059311B8  token=0x60003D4  System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p)
  RVA=0x024788C0  token=0x60003D5  System.Boolean <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f)
END_CLASS

CLASS: <>c__DisplayClass31_0
TYPE:  sealed class
TOKEN: 0x200008E
SIZE:  0x18
FIELDS:
  public            System.Reflection.MemberInfo    memberInfo  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003D6  System.Void .ctor()
  RVA=0x03B71DD0  token=0x60003D7  System.Boolean <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m)
END_CLASS

CLASS: <>c__DisplayClass44_0
TYPE:  sealed class
TOKEN: 0x200008F
SIZE:  0x18
FIELDS:
  public            System.Reflection.PropertyInfo  subTypeProperty  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003D8  System.Void .ctor()
  RVA=0x03927260  token=0x60003D9  System.Boolean <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p)
  RVA=0x02479A20  token=0x60003DA  System.Boolean <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p)
END_CLASS

CLASS: <>c__DisplayClass44_1
TYPE:  sealed class
TOKEN: 0x2000090
SIZE:  0x20
FIELDS:
  public            System.Type                     subTypePropertyDeclaringType  // 0x10
  public            Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60003DB  System.Void .ctor()
  RVA=0x024798A0  token=0x60003DC  System.Boolean <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p)
END_CLASS

CLASS: <>c__DisplayClass45_0
TYPE:  sealed class
TOKEN: 0x2000091
SIZE:  0x20
FIELDS:
  public            System.String                   method  // 0x10
  public            System.Type                     methodDeclaringType  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60003DD  System.Void .ctor()
  RVA=0x092C433C  token=0x60003DE  System.Boolean <IsMethodOverridden>b__0(System.Reflection.MethodInfo info)
END_CLASS

CLASS: SeparatedCaseState
TYPE:  sealed struct
TOKEN: 0x2000096
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateStart  // const
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateLower  // const
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateUpper  // const
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateNewWord  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass14_0`1
TYPE:  sealed class
TOKEN: 0x2000097
FIELDS:
  public            System.Func<TSource,System.String>valueSelector  // 0x0
  public            System.String                   testValue  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000408  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000409  System.Boolean <ForgivingCaseSensitiveFind>b__0(TSource s)
  RVA=-1  // not resolved  token=0x600040A  System.Boolean <ForgivingCaseSensitiveFind>b__1(TSource s)
END_CLASS

CLASS: <GetEnumerator>d__2
TYPE:  sealed class
TOKEN: 0x20000A0
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Collections.Generic.KeyValuePair<System.Object,System.Object><>2__current  // 0x0
  public            Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey,TEnumeratorValue><>4__this  // 0x0
  private           System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>><>7__wrap1  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000467  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000468  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000469  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x600046A  System.Void <>m__Finally1()
  RVA=-1  // not resolved  token=0x600046C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: EnumerableDictionaryWrapper`2
TYPE:  class
TOKEN: 0x200009F
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>>_e  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000464  System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e)
  RVA=-1  // not resolved  token=0x6000465  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000466  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A1
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Serialization.DefaultContractResolver.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Reflection.MemberInfo,System.Boolean><>9__40_0  // static @ 0x8
  public    static  System.Func<System.Reflection.MemberInfo,System.Boolean><>9__40_1  // static @ 0x10
  public    static  System.Func<System.Type,System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>><>9__44_0  // static @ 0x18
  public    static  System.Func<System.Reflection.MemberInfo,System.Boolean><>9__44_1  // static @ 0x20
  public    static  System.Func<System.Reflection.ConstructorInfo,System.Boolean><>9__47_0  // static @ 0x28
  public    static  System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.Int32><>9__75_0  // static @ 0x30
METHODS:
  RVA=0x03D0FBF0  token=0x600046E  System.Void .cctor()
  RVA=0x0350B670  token=0x600046F  System.Void .ctor()
  RVA=0x02479D50  token=0x6000470  System.Boolean <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m)
  RVA=0x092CD60C  token=0x6000471  System.Boolean <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m)
  RVA=0x02477D90  token=0x6000472  System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType)
  RVA=0x02479B30  token=0x6000473  System.Boolean <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m)
  RVA=0x02478910  token=0x6000474  System.Boolean <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c)
  RVA=0x031913D0  token=0x6000475  System.Int32 <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p)
END_CLASS

CLASS: <>c__DisplayClass42_0
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Serialization.NamingStrategynamingStrategy  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000476  System.Void .ctor()
  RVA=0x092CD688  token=0x6000477  System.String <CreateObjectContract>b__0(System.String s)
END_CLASS

CLASS: <>c__DisplayClass45_0
TYPE:  sealed class
TOKEN: 0x20000A3
SIZE:  0x20
FIELDS:
  public            System.Func<System.Object,System.Object>getExtensionDataDictionary  // 0x10
  public            System.Reflection.MemberInfo    member  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000478  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass45_1
TYPE:  sealed class
TOKEN: 0x20000A4
SIZE:  0x30
FIELDS:
  public            System.Action<System.Object,System.Object>setExtensionDataDictionary  // 0x10
  public            System.Func<System.Object>      createExtensionDataDictionary  // 0x18
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>setExtensionDataDictionaryValue  // 0x20
  public            Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0CS$<>8__locals1  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000479  System.Void .ctor()
  RVA=0x092CD6A8  token=0x600047A  System.Void <SetExtensionDataDelegates>b__0(System.Object o, System.String key, System.Object value)
END_CLASS

CLASS: <>c__DisplayClass45_2
TYPE:  sealed class
TOKEN: 0x20000A5
SIZE:  0x20
FIELDS:
  public            Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>createEnumerableWrapper  // 0x10
  public            Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0CS$<>8__locals2  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600047B  System.Void .ctor()
  RVA=0x092CD884  token=0x600047C  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(System.Object o)
END_CLASS

CLASS: <>c__DisplayClass62_0
TYPE:  sealed class
TOKEN: 0x20000A6
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Serialization.NamingStrategynamingStrategy  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600047D  System.Void .ctor()
  RVA=0x092CD688  token=0x600047E  System.String <CreateDictionaryContract>b__0(System.String s)
END_CLASS

CLASS: <>c__DisplayClass67_0
TYPE:  sealed class
TOKEN: 0x20000A7
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Serialization.NamingStrategynamingStrategy  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600047F  System.Void .ctor()
  RVA=0x092CD688  token=0x6000480  System.String <CreateDynamicContract>b__0(System.String s)
END_CLASS

CLASS: <>c__DisplayClass80_0
TYPE:  sealed class
TOKEN: 0x20000A8
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>shouldSerializeCall  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000481  System.Void .ctor()
  RVA=0x092CDA50  token=0x6000482  System.Boolean <CreateShouldSerializeTest>b__0(System.Object o)
END_CLASS

CLASS: <>c__DisplayClass81_0
TYPE:  sealed class
TOKEN: 0x20000A9
SIZE:  0x18
FIELDS:
  public            System.Func<System.Object,System.Object>specifiedPropertyGet  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000483  System.Void .ctor()
  RVA=0x092CDAD4  token=0x6000484  System.Boolean <SetIsSpecifiedActions>b__0(System.Object o)
END_CLASS

CLASS: <>c__DisplayClass57_0
TYPE:  sealed class
TOKEN: 0x20000BD
SIZE:  0x18
FIELDS:
  public            System.Reflection.MethodInfo    callbackMethodInfo  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60004E3  System.Void .ctor()
  RVA=0x0312B410  token=0x60004E4  System.Void <CreateSerializationCallback>b__0(System.Object o, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: <>c__DisplayClass58_0
TYPE:  sealed class
TOKEN: 0x20000BE
SIZE:  0x18
FIELDS:
  public            System.Reflection.MethodInfo    callbackMethodInfo  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60004E5  System.Void .ctor()
  RVA=0x092CD95C  token=0x60004E6  System.Void <CreateSerializationErrorCallback>b__0(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext)
END_CLASS

CLASS: ReferenceEqualsEqualityComparer
TYPE:  class
TOKEN: 0x20000C9
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
METHODS:
  RVA=0x06DDEAAC  token=0x600056E  System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y)
  RVA=0x03D6E640  token=0x600056F  System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj)
  RVA=0x0350B670  token=0x6000570  System.Void .ctor()
END_CLASS

CLASS: PropertyPresence
TYPE:  sealed struct
TOKEN: 0x20000CB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceNone  // const
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceNull  // const
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceValue  // const
METHODS:
END_CLASS

CLASS: CreatorPropertyContext
TYPE:  class
TOKEN: 0x20000CC
SIZE:  0x40
FIELDS:
  public    readonly System.String                   Name  // 0x10
  public            Newtonsoft.Json.Serialization.JsonPropertyProperty  // 0x18
  public            Newtonsoft.Json.Serialization.JsonPropertyConstructorProperty  // 0x20
  public            System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence>Presence  // 0x28
  public            System.Object                   Value  // 0x30
  public            System.Boolean                  Used  // 0x38
METHODS:
  RVA=0x0426FEE0  token=0x60005A1  System.Void .ctor(System.String name)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000CD
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<>c<>9  // static @ 0x0
  public    static  System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String><>9__38_0  // static @ 0x8
  public    static  System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String><>9__38_2  // static @ 0x10
  public    static  System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonProperty><>9__42_0  // static @ 0x18
  public    static  System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence><>9__42_1  // static @ 0x20
METHODS:
  RVA=0x03D0D5B0  token=0x60005A2  System.Void .cctor()
  RVA=0x0350B670  token=0x60005A3  System.Void .ctor()
  RVA=0x092CD5F4  token=0x60005A4  System.String <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p)
  RVA=0x092CD5F4  token=0x60005A5  System.String <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p)
  RVA=0x03D51810  token=0x60005A6  Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m)
  RVA=0x01002730  token=0x60005A7  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m)
END_CLASS

CLASS: <>c__DisplayClass38_0
TYPE:  sealed class
TOKEN: 0x20000CE
SIZE:  0x18
FIELDS:
  public            Newtonsoft.Json.Serialization.JsonPropertyproperty  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60005A8  System.Void .ctor()
  RVA=0x092CD668  token=0x60005A9  System.Boolean <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000D3
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Serialization.JsonTypeReflector.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Object,System.Type><>9__22_1  // static @ 0x8
METHODS:
  RVA=0x092DF40C  token=0x600060A  System.Void .cctor()
  RVA=0x0350B670  token=0x600060B  System.Void .ctor()
  RVA=0x092DEF38  token=0x600060C  System.Type <GetCreator>b__22_1(System.Object param)
END_CLASS

CLASS: <>c__DisplayClass22_0
TYPE:  sealed class
TOKEN: 0x20000D4
SIZE:  0x20
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Func<System.Object>      defaultConstructor  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600060D  System.Void .ctor()
  RVA=0x092DEFC4  token=0x600060E  System.Object <GetCreator>b__0(System.Object[] parameters)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000E7
SIZE:  0x10
FIELDS:
  public    static readonly Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<>c<>9  // static @ 0x0
  public    static  System.Func<Newtonsoft.Json.Linq.JProperty,System.String><>9__2_0  // static @ 0x8
METHODS:
  RVA=0x092DF3A8  token=0x6000710  System.Void .cctor()
  RVA=0x0350B670  token=0x6000711  System.Void .ctor()
  RVA=0x092DEFAC  token=0x6000712  System.String <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p)
END_CLASS

CLASS: JObjectDynamicProxy
TYPE:  class
TOKEN: 0x20000E6
SIZE:  0x10
EXTENDS: Newtonsoft.Json.Utilities.DynamicProxy`1
FIELDS:
METHODS:
  RVA=0x092D0B1C  token=0x600070C  System.Boolean TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, System.Object& result)
  RVA=0x092D0B5C  token=0x600070D  System.Boolean TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, System.Object value)
  RVA=0x092D09FC  token=0x600070E  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance)
  RVA=0x092D0C14  token=0x600070F  System.Void .ctor()
END_CLASS

CLASS: <GetEnumerator>d__64
TYPE:  sealed class
TOKEN: 0x20000E8
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken><>2__current  // 0x18
  public            Newtonsoft.Json.Linq.JObject    <>4__this  // 0x28
  private           System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current  get=0x03D51D80
  System.Collections.IEnumerator.Current  get=0x092DEE30
METHODS:
  RVA=0x010410F0  token=0x6000713  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x092DEE78  token=0x6000714  System.Void System.IDisposable.Dispose()
  RVA=0x092DEAC8  token=0x6000715  System.Boolean MoveNext()
  RVA=0x092DEEF0  token=0x6000716  System.Void <>m__Finally1()
  RVA=0x092DEDE4  token=0x6000718  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <GetEnumerator>d__1
TYPE:  sealed class
TOKEN: 0x20000EB
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           Newtonsoft.Json.Linq.JToken     <>2__current  // 0x18
  public            Newtonsoft.Json.Linq.JProperty.JPropertyList<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600073C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600073D  System.Void System.IDisposable.Dispose()
  RVA=0x092DEA24  token=0x600073E  System.Boolean MoveNext()
  RVA=0x092DEA7C  token=0x6000740  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: JPropertyList
TYPE:  class
TOKEN: 0x20000EA
SIZE:  0x18
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           Newtonsoft.Json.Linq.JToken     _token  // 0x10
PROPERTIES:
  Count  get=0x03676D20
  IsReadOnly  get=0x0115F4C0
  Item  get=0x03B5B050  set=0x03D4B920
METHODS:
  RVA=0x092D218C  token=0x600072D  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator()
  RVA=0x092D2238  token=0x600072E  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x0426FEE0  token=0x600072F  System.Void Add(Newtonsoft.Json.Linq.JToken item)
  RVA=0x035ACAA0  token=0x6000730  System.Void Clear()
  RVA=0x092D211C  token=0x6000731  System.Boolean Contains(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D2124  token=0x6000732  System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  RVA=0x092D2210  token=0x6000733  System.Boolean Remove(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D21E8  token=0x6000736  System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item)
  RVA=0x0381BD20  token=0x6000737  System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D21F8  token=0x6000738  System.Void RemoveAt(System.Int32 index)
  RVA=0x0350B670  token=0x600073B  System.Void .ctor()
END_CLASS

CLASS: LineInfoAnnotation
TYPE:  class
TOKEN: 0x20000F2
SIZE:  0x18
FIELDS:
  private   readonly System.Int32                    LineNumber  // 0x10
  private   readonly System.Int32                    LinePosition  // 0x14
METHODS:
  RVA=0x03D50CB0  token=0x60007BD  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: JValueDynamicProxy
TYPE:  class
TOKEN: 0x20000F7
SIZE:  0x10
EXTENDS: Newtonsoft.Json.Utilities.DynamicProxy`1
FIELDS:
METHODS:
  RVA=0x092D99A4  token=0x6000829  System.Boolean TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, System.Object& result)
  RVA=0x092D96F8  token=0x600082A  System.Boolean TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result)
  RVA=0x092D9B20  token=0x600082B  System.Void .ctor()
END_CLASS

CLASS: Union
TYPE:  class
TOKEN: 0x2000100
SIZE:  0x20
FIELDS:
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionTagReader  // 0x10
  public    readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase>Cases  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000850  System.Void .ctor(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases)
END_CLASS

CLASS: UnionCase
TYPE:  class
TOKEN: 0x2000101
SIZE:  0x38
FIELDS:
  public    readonly System.Int32                    Tag  // 0x10
  public    readonly System.String                   Name  // 0x18
  public    readonly System.Reflection.PropertyInfo[]Fields  // 0x20
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionFieldReader  // 0x28
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionConstructor  // 0x30
METHODS:
  RVA=0x092E5FE0  token=0x6000851  System.Void .ctor(System.Int32 tag, System.String name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor)
END_CLASS

CLASS: <>c__DisplayClass8_0
TYPE:  sealed class
TOKEN: 0x2000102
SIZE:  0x18
FIELDS:
  public            System.Int32                    tag  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000852  System.Void .ctor()
  RVA=0x059517DC  token=0x6000853  System.Boolean <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c)
END_CLASS

CLASS: <>c__DisplayClass9_0
TYPE:  sealed class
TOKEN: 0x2000103
SIZE:  0x20
FIELDS:
  public            System.String                   caseName  // 0x10
  public            System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean><>9__0  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000854  System.Void .ctor()
  RVA=0x092E5FB8  token=0x6000855  System.Boolean <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c)
END_CLASS

CLASS: __StaticArrayInitTypeSize=10
TYPE:  sealed struct
TOKEN: 0x200012D
SIZE:  0x1A
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=16
TYPE:  sealed struct
TOKEN: 0x200012E
SIZE:  0x20
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  sealed struct
TOKEN: 0x200012F
SIZE:  0x24
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  sealed struct
TOKEN: 0x2000130
SIZE:  0x28
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=28
TYPE:  sealed struct
TOKEN: 0x2000131
SIZE:  0x2C
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  sealed struct
TOKEN: 0x2000132
SIZE:  0x34
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=40
TYPE:  sealed struct
TOKEN: 0x2000133
SIZE:  0x38
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  sealed struct
TOKEN: 0x2000134
SIZE:  0x3C
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  sealed struct
TOKEN: 0x2000135
SIZE:  0x44
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200012C
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=440698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1019AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994  // static @ 0x2c
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570  // static @ 0x36
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2033350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE  // static @ 0x5e
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4038809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63  // static @ 0x72
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6  // static @ 0x9a
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=164EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF  // static @ 0xb6
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=525857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA  // static @ 0xc6
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=285ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2  // static @ 0xfa
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=245DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9  // static @ 0x116
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04  // static @ 0x12e
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=367367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62  // static @ 0x13e
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=407439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1  // static @ 0x162
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5  // static @ 0x18a
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89  // static @ 0x1b2
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122  // static @ 0x1c2
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326  // static @ 0x1d6
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A  // static @ 0x1ea
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7  // static @ 0x212
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315  // static @ 0x23a
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A  // static @ 0x26e
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.ConstructorHandling
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ConstructorHandlingDefault  // const
  public    static  Newtonsoft.Json.ConstructorHandlingAllowNonPublicDefaultConstructor  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateFormatHandling
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateFormatHandlingIsoDateFormat  // const
  public    static  Newtonsoft.Json.DateFormatHandlingMicrosoftDateFormat  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateParseHandling
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateParseHandlingNone  // const
  public    static  Newtonsoft.Json.DateParseHandlingDateTime  // const
  public    static  Newtonsoft.Json.DateParseHandlingDateTimeOffset  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateTimeZoneHandling
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateTimeZoneHandlingLocal  // const
  public    static  Newtonsoft.Json.DateTimeZoneHandlingUtc  // const
  public    static  Newtonsoft.Json.DateTimeZoneHandlingUnspecified  // const
  public    static  Newtonsoft.Json.DateTimeZoneHandlingRoundtripKind  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DefaultJsonNameTable
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x28
EXTENDS: Newtonsoft.Json.JsonNameTable
FIELDS:
  private   static readonly System.Int32                    HashCodeRandomizer  // static @ 0x0
  private           System.Int32                    _count  // 0x10
  private           Newtonsoft.Json.DefaultJsonNameTable.Entry[]_entries  // 0x18
  private           System.Int32                    _mask  // 0x20
METHODS:
  RVA=0x03D41660  token=0x6000008  System.Void .cctor()
  RVA=0x03702F40  token=0x6000009  System.Void .ctor()
  RVA=0x0236C9E0  token=0x600000A  System.String Get(System.Char[] key, System.Int32 start, System.Int32 length)
  RVA=0x024E67F0  token=0x600000B  System.String Add(System.String key)
  RVA=0x03020400  token=0x600000C  System.String AddEntry(System.String str, System.Int32 hashCode)
  RVA=0x03020540  token=0x600000D  System.Void Grow()
  RVA=0x0236C960  token=0x600000E  System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length)
END_CLASS

CLASS: Newtonsoft.Json.DefaultValueHandling
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DefaultValueHandlingInclude  // const
  public    static  Newtonsoft.Json.DefaultValueHandlingIgnore  // const
  public    static  Newtonsoft.Json.DefaultValueHandlingPopulate  // const
  public    static  Newtonsoft.Json.DefaultValueHandlingIgnoreAndPopulate  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.FloatFormatHandling
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.FloatFormatHandlingString  // const
  public    static  Newtonsoft.Json.FloatFormatHandlingSymbol  // const
  public    static  Newtonsoft.Json.FloatFormatHandlingDefaultValue  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.FloatParseHandling
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.FloatParseHandlingDouble  // const
  public    static  Newtonsoft.Json.FloatParseHandlingDecimal  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Formatting
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Formatting      None  // const
  public    static  Newtonsoft.Json.Formatting      Indented  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.IArrayPool`1
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000010  T[] Rent(System.Int32 minimumLength)
  RVA=-1  // abstract  token=0x6000011  System.Void Return(T[] array)
END_CLASS

CLASS: Newtonsoft.Json.IJsonLineInfo
TYPE:  interface
TOKEN: 0x2000013
FIELDS:
PROPERTIES:
  LineNumber  get=-1  // abstract
  LinePosition  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000012  System.Boolean HasLineInfo()
END_CLASS

CLASS: Newtonsoft.Json.JsonArrayAttribute
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x50
EXTENDS: Newtonsoft.Json.JsonContainerAttribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonConstructorAttribute
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000015  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonContainerAttribute
TYPE:  abstract class
TOKEN: 0x2000016
SIZE:  0x50
EXTENDS: System.Attribute
FIELDS:
  private           System.Type                     <ItemConverterType>k__BackingField  // 0x10
  private           System.Object[]                 <ItemConverterParameters>k__BackingField  // 0x18
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategyInstance>k__BackingField  // 0x20
  private           System.Nullable<System.Boolean> _isReference  // 0x28
  private           System.Nullable<System.Boolean> _itemIsReference  // 0x2a
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_itemReferenceLoopHandling  // 0x2c
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_itemTypeNameHandling  // 0x34
  private           System.Type                     _namingStrategyType  // 0x40
  private           System.Object[]                 _namingStrategyParameters  // 0x48
PROPERTIES:
  ItemConverterType  get=0x020B7B20
  ItemConverterParameters  get=0x01041090
  NamingStrategyType  get=0x03D4E2B0
  NamingStrategyParameters  get=0x03D4EA70
  NamingStrategyInstance  get=0x03D4EB40  set=0x04271930
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonConvert
TYPE:  static class
TOKEN: 0x2000017
SIZE:  0x10
FIELDS:
  private   static  System.Func<Newtonsoft.Json.JsonSerializerSettings><DefaultSettings>k__BackingField  // static @ 0x0
  public    static readonly System.String                   True  // static @ 0x8
  public    static readonly System.String                   False  // static @ 0x10
  public    static readonly System.String                   Null  // static @ 0x18
  public    static readonly System.String                   Undefined  // static @ 0x20
  public    static readonly System.String                   PositiveInfinity  // static @ 0x28
  public    static readonly System.String                   NegativeInfinity  // static @ 0x30
  public    static readonly System.String                   NaN  // static @ 0x38
PROPERTIES:
  DefaultSettings  get=0x092B06F8
METHODS:
  RVA=0x02905B90  token=0x600001D  System.String ToString(System.Boolean value)
  RVA=0x092B0350  token=0x600001E  System.String ToString(System.Char value)
  RVA=0x092B0538  token=0x600001F  System.String ToString(System.Single value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  RVA=0x092AFEFC  token=0x6000020  System.String EnsureFloatFormat(System.Double value, System.String text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  RVA=0x092B061C  token=0x6000021  System.String ToString(System.Double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  RVA=0x092AFDF8  token=0x6000022  System.String EnsureDecimalPlace(System.Double value, System.String text)
  RVA=0x092AFEA0  token=0x6000023  System.String EnsureDecimalPlace(System.String text)
  RVA=0x092B02B8  token=0x6000024  System.String ToString(System.Decimal value)
  RVA=0x092B04E8  token=0x6000025  System.String ToString(System.String value)
  RVA=0x092B0494  token=0x6000026  System.String ToString(System.String value, System.Char delimiter)
  RVA=0x092B03B8  token=0x6000027  System.String ToString(System.String value, System.Char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  RVA=0x02696450  token=0x6000028  System.String SerializeObject(System.Object value)
  RVA=0x092B0210  token=0x6000029  System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting)
  RVA=0x092B0264  token=0x600002A  System.String SerializeObject(System.Object value, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x026963D0  token=0x600002B  System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x035A1D80  token=0x600002C  System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x035A1E00  token=0x600002D  System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x02696B20  token=0x600002E  System.String SerializeObjectInternal(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer)
  RVA=0x03C8F4B0  token=0x600002F  System.Object DeserializeObject(System.String value)
  RVA=0x02694430  token=0x6000030  System.Object DeserializeObject(System.String value, System.Type type)
  RVA=-1  // generic def  token=0x6000031  T DeserializeObject(System.String value)
  RVA=-1  // generic def  token=0x6000032  T DeserializeObject(System.String value, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x02695B30  token=0x6000033  System.Object DeserializeObject(System.String value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x092AFFF0  token=0x6000034  System.Void PopulateObject(System.String value, System.Object target, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x03A2D920  token=0x6000035  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverter
TYPE:  abstract class
TOKEN: 0x2000018
SIZE:  0x10
FIELDS:
PROPERTIES:
  CanRead  get=0x0232EB60
  CanWrite  get=0x0232EB60
METHODS:
  RVA=-1  // abstract  token=0x6000036  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // abstract  token=0x6000037  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // abstract  token=0x6000038  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x600003B  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverter`1
TYPE:  abstract class
TOKEN: 0x2000019
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x600003C  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // abstract  token=0x600003D  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // not resolved  token=0x600003E  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // abstract  token=0x600003F  T ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, T existingValue, System.Boolean hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // not resolved  token=0x6000040  System.Boolean CanConvert(System.Type objectType)
  RVA=-1  // not resolved  token=0x6000041  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverterAttribute
TYPE:  sealed class
TOKEN: 0x200001A
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.Type                     _converterType  // 0x10
  private   readonly System.Object[]                 <ConverterParameters>k__BackingField  // 0x18
PROPERTIES:
  ConverterType  get=0x020B7B20
  ConverterParameters  get=0x01041090
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonConverterCollection
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x18
EXTENDS: System.Collections.ObjectModel.Collection`1
FIELDS:
METHODS:
  RVA=0x03043740  token=0x6000044  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonDictionaryAttribute
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x50
EXTENDS: Newtonsoft.Json.JsonContainerAttribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonException
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x092B0748  token=0x6000045  System.Void .ctor()
  RVA=0x092B0794  token=0x6000046  System.Void .ctor(System.String message)
  RVA=0x092B07F0  token=0x6000047  System.Void .ctor(System.String message, System.Exception innerException)
  RVA=0x092B0850  token=0x6000048  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: Newtonsoft.Json.JsonExtensionDataAttribute
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.Boolean                  <WriteData>k__BackingField  // 0x10
  private           System.Boolean                  <ReadData>k__BackingField  // 0x11
PROPERTIES:
  WriteData  get=0x011797F0
  ReadData  get=0x03D510E0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonIgnoreAttribute
TYPE:  sealed class
TOKEN: 0x200001F
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600004B  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonNameTable
TYPE:  abstract class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600004C  System.String Get(System.Char[] key, System.Int32 start, System.Int32 length)
  RVA=0x0350B670  token=0x600004D  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonObjectAttribute
TYPE:  sealed class
TOKEN: 0x2000021
SIZE:  0x70
EXTENDS: Newtonsoft.Json.JsonContainerAttribute
FIELDS:
  private           Newtonsoft.Json.MemberSerialization_memberSerialization  // 0x50
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling>_missingMemberHandling  // 0x54
  private           System.Nullable<Newtonsoft.Json.Required>_itemRequired  // 0x5c
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_itemNullValueHandling  // 0x64
PROPERTIES:
  MemberSerialization  get=0x03D4EED0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonContainerType
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonContainerTypeNone  // const
  public    static  Newtonsoft.Json.JsonContainerTypeObject  // const
  public    static  Newtonsoft.Json.JsonContainerTypeArray  // const
  public    static  Newtonsoft.Json.JsonContainerTypeConstructor  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonPosition
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x28
FIELDS:
  private   static readonly System.Char[]                   SpecialCharacters  // static @ 0x0
  private           Newtonsoft.Json.JsonContainerTypeType  // 0x10
  private           System.Int32                    Position  // 0x14
  private           System.String                   PropertyName  // 0x18
  private           System.Boolean                  HasIndex  // 0x20
METHODS:
  RVA=0x02907480  token=0x600004F  System.Void .ctor(Newtonsoft.Json.JsonContainerType type)
  RVA=0x092B0BF0  token=0x6000050  System.Int32 CalculateLength()
  RVA=0x092B0E5C  token=0x6000051  System.Void WriteTo(System.Text.StringBuilder sb, System.IO.StringWriter& writer, System.Char[]& buffer)
  RVA=0x02907530  token=0x6000052  System.Boolean TypeHasIndex(Newtonsoft.Json.JsonContainerType type)
  RVA=0x092B08BC  token=0x6000053  System.String BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition)
  RVA=0x092B0C80  token=0x6000054  System.String FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message)
  RVA=0x03CE3DC0  token=0x6000055  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonPropertyAttribute
TYPE:  sealed class
TOKEN: 0x2000024
SIZE:  0x88
EXTENDS: System.Attribute
FIELDS:
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_nullValueHandling  // 0x10
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling>_defaultValueHandling  // 0x18
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_referenceLoopHandling  // 0x20
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling>_objectCreationHandling  // 0x28
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_typeNameHandling  // 0x30
  private           System.Nullable<System.Boolean> _isReference  // 0x38
  private           System.Nullable<System.Int32>   _order  // 0x3c
  private           System.Nullable<Newtonsoft.Json.Required>_required  // 0x44
  private           System.Nullable<System.Boolean> _itemIsReference  // 0x4c
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_itemReferenceLoopHandling  // 0x50
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_itemTypeNameHandling  // 0x58
  private           System.Type                     <ItemConverterType>k__BackingField  // 0x60
  private           System.Object[]                 <ItemConverterParameters>k__BackingField  // 0x68
  private           System.Type                     <NamingStrategyType>k__BackingField  // 0x70
  private           System.Object[]                 <NamingStrategyParameters>k__BackingField  // 0x78
  private           System.String                   <PropertyName>k__BackingField  // 0x80
PROPERTIES:
  ItemConverterType  get=0x03D4EB00
  ItemConverterParameters  get=0x03D4EAB0
  NamingStrategyType  get=0x03D4EB30
  NamingStrategyParameters  get=0x03D4EB20
  DefaultValueHandling  set=0x0381E590
  Order  set=0x033DA250
  PropertyName  get=0x03D4EAE0  set=0x051DFC94
METHODS:
  RVA=0x0350B670  token=0x600005E  System.Void .ctor()
  RVA=0x051DFC94  token=0x600005F  System.Void .ctor(System.String propertyName)
END_CLASS

CLASS: Newtonsoft.Json.JsonReader
TYPE:  abstract class
TOKEN: 0x2000025
SIZE:  0x78
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Newtonsoft.Json.JsonToken       _tokenType  // 0x10
  private           System.Object                   _value  // 0x18
  private           System.Char                     _quoteChar  // 0x20
  private           Newtonsoft.Json.JsonReader.State_currentState  // 0x24
  private           Newtonsoft.Json.JsonPosition    _currentPosition  // 0x28
  private           System.Globalization.CultureInfo_culture  // 0x40
  private           Newtonsoft.Json.DateTimeZoneHandling_dateTimeZoneHandling  // 0x48
  private           System.Nullable<System.Int32>   _maxDepth  // 0x4c
  private           System.Boolean                  _hasExceededMaxDepth  // 0x54
  private           Newtonsoft.Json.DateParseHandling_dateParseHandling  // 0x58
  private           Newtonsoft.Json.FloatParseHandling_floatParseHandling  // 0x5c
  private           System.String                   _dateFormatString  // 0x60
  private           System.Collections.Generic.List<Newtonsoft.Json.JsonPosition>_stack  // 0x68
  private           System.Boolean                  <CloseInput>k__BackingField  // 0x70
  private           System.Boolean                  <SupportMultipleContent>k__BackingField  // 0x71
PROPERTIES:
  CurrentState  get=0x03D4E2E0
  CloseInput  get=0x03D4F260  set=0x03D4F290
  SupportMultipleContent  get=0x03D51CF0  set=0x03D51D00
  DateTimeZoneHandling  get=0x03D4EC50  set=0x092B35E4
  DateParseHandling  get=0x03D4EF00  set=0x092B357C
  FloatParseHandling  get=0x03D4EEF0  set=0x092B364C
  DateFormatString  get=0x03D4EB00  set=0x039274B0
  MaxDepth  get=0x03D56700  set=0x027BC040
  TokenType  get=0x03D4E340
  Value  get=0x01041090
  ValueType  get=0x092B3558
  Depth  get=0x0269A890
  Path  get=0x092B3464
  Culture  get=0x027BC3A0  set=0x03CB2D80
METHODS:
  RVA=0x092B129C  token=0x6000076  Newtonsoft.Json.JsonPosition GetPosition(System.Int32 depth)
  RVA=0x02696330  token=0x6000077  System.Void .ctor()
  RVA=0x02906EF0  token=0x6000078  System.Void Push(Newtonsoft.Json.JsonContainerType value)
  RVA=0x0247C880  token=0x6000079  Newtonsoft.Json.JsonContainerType Pop()
  RVA=0x03D4EB90  token=0x600007A  Newtonsoft.Json.JsonContainerType Peek()
  RVA=-1  // abstract  token=0x600007B  System.Boolean Read()
  RVA=0x092B23F0  token=0x600007C  System.Nullable<System.Int32> ReadAsInt32()
  RVA=0x092B30CC  token=0x600007D  System.Nullable<System.Int32> ReadInt32String(System.String s)
  RVA=0x03B23610  token=0x600007E  System.String ReadAsString()
  RVA=0x092B15C8  token=0x600007F  System.Byte[] ReadAsBytes()
  RVA=0x092B14F4  token=0x6000080  System.Byte[] ReadArrayIntoByteArray()
  RVA=0x092B1340  token=0x6000081  System.Boolean ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer)
  RVA=0x092B214C  token=0x6000082  System.Nullable<System.Double> ReadAsDouble()
  RVA=0x092B2EEC  token=0x6000083  System.Nullable<System.Double> ReadDoubleString(System.String s)
  RVA=0x03B23540  token=0x6000084  System.Nullable<System.Boolean> ReadAsBoolean()
  RVA=0x092B277C  token=0x6000085  System.Nullable<System.Boolean> ReadBooleanString(System.String s)
  RVA=0x092B1D74  token=0x6000086  System.Nullable<System.Decimal> ReadAsDecimal()
  RVA=0x092B2CDC  token=0x6000087  System.Nullable<System.Decimal> ReadDecimalString(System.String s)
  RVA=0x092B1B4C  token=0x6000088  System.Nullable<System.DateTime> ReadAsDateTime()
  RVA=0x092B2AEC  token=0x6000089  System.Nullable<System.DateTime> ReadDateTimeString(System.String s)
  RVA=0x092B1914  token=0x600008A  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  RVA=0x092B28E4  token=0x600008B  System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(System.String s)
  RVA=0x092B341C  token=0x600008C  System.Void ReaderReadAndAssert()
  RVA=0x092B125C  token=0x600008D  Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException()
  RVA=0x092B3238  token=0x600008E  System.Void ReadIntoWrappedTypeObject()
  RVA=0x0269A0F0  token=0x600008F  System.Void Skip()
  RVA=0x0426FA14  token=0x6000090  System.Void SetToken(Newtonsoft.Json.JsonToken newToken)
  RVA=0x042702E0  token=0x6000091  System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value)
  RVA=0x0247E340  token=0x6000092  System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value, System.Boolean updateIndex)
  RVA=0x0247E590  token=0x6000093  System.Void SetPostValueState(System.Boolean updateIndex)
  RVA=0x0247E5D0  token=0x6000094  System.Void UpdateScopeWithFinishedValue()
  RVA=0x0247C400  token=0x6000095  System.Void ValidateEnd(Newtonsoft.Json.JsonToken endToken)
  RVA=0x0236AC80  token=0x6000096  System.Void SetStateBasedOnCurrent()
  RVA=0x032FF660  token=0x6000097  System.Void SetFinished()
  RVA=0x0247C840  token=0x6000098  Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token)
  RVA=0x0289C760  token=0x6000099  System.Void System.IDisposable.Dispose()
  RVA=0x0289C800  token=0x600009A  System.Void Dispose(System.Boolean disposing)
  RVA=0x030AB570  token=0x600009B  System.Void Close()
  RVA=0x024E8B90  token=0x600009C  System.Void ReadAndAssert()
  RVA=0x092B3078  token=0x600009D  System.Void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter)
  RVA=0x024EC430  token=0x600009E  System.Boolean ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter)
  RVA=0x024EC680  token=0x600009F  System.Boolean ReadAndMoveToContent()
  RVA=0x024EC6D0  token=0x60000A0  System.Boolean MoveToContent()
  RVA=0x03B236C0  token=0x60000A1  Newtonsoft.Json.JsonToken GetContentToken()
END_CLASS

CLASS: Newtonsoft.Json.JsonReaderException
TYPE:  class
TOKEN: 0x2000027
SIZE:  0xA0
EXTENDS: Newtonsoft.Json.JsonException
FIELDS:
  private   readonly System.Int32                    <LineNumber>k__BackingField  // 0x90
  private   readonly System.Int32                    <LinePosition>k__BackingField  // 0x94
  private   readonly System.String                   <Path>k__BackingField  // 0x98
METHODS:
  RVA=0x092B11D4  token=0x60000A2  System.Void .ctor()
  RVA=0x092B1254  token=0x60000A3  System.Void .ctor(System.String message)
  RVA=0x092B1234  token=0x60000A4  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x092B11DC  token=0x60000A5  System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException)
  RVA=0x092B11C8  token=0x60000A6  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message)
  RVA=0x092B1138  token=0x60000A7  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex)
  RVA=0x092B1048  token=0x60000A8  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.JsonRequiredAttribute
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializationException
TYPE:  class
TOKEN: 0x2000029
SIZE:  0xA0
EXTENDS: Newtonsoft.Json.JsonException
FIELDS:
  private   readonly System.Int32                    <LineNumber>k__BackingField  // 0x90
  private   readonly System.Int32                    <LinePosition>k__BackingField  // 0x94
  private   readonly System.String                   <Path>k__BackingField  // 0x98
METHODS:
  RVA=0x092B11D4  token=0x60000A9  System.Void .ctor()
  RVA=0x092B1254  token=0x60000AA  System.Void .ctor(System.String message)
  RVA=0x092B3840  token=0x60000AB  System.Void .ctor(System.String message, System.Exception innerException)
  RVA=0x092B1234  token=0x60000AC  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x092B11DC  token=0x60000AD  System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException)
  RVA=0x092B36B4  token=0x60000AE  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message)
  RVA=0x092B36C0  token=0x60000AF  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex)
  RVA=0x092B3750  token=0x60000B0  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializer
TYPE:  class
TOKEN: 0x200002A
SIZE:  0xE0
FIELDS:
  private           Newtonsoft.Json.TypeNameHandling_typeNameHandling  // 0x10
  private           Newtonsoft.Json.TypeNameAssemblyFormatHandling_typeNameAssemblyFormatHandling  // 0x14
  private           Newtonsoft.Json.PreserveReferencesHandling_preserveReferencesHandling  // 0x18
  private           Newtonsoft.Json.ReferenceLoopHandling_referenceLoopHandling  // 0x1c
  private           Newtonsoft.Json.MissingMemberHandling_missingMemberHandling  // 0x20
  private           Newtonsoft.Json.ObjectCreationHandling_objectCreationHandling  // 0x24
  private           Newtonsoft.Json.NullValueHandling_nullValueHandling  // 0x28
  private           Newtonsoft.Json.DefaultValueHandling_defaultValueHandling  // 0x2c
  private           Newtonsoft.Json.ConstructorHandling_constructorHandling  // 0x30
  private           Newtonsoft.Json.MetadataPropertyHandling_metadataPropertyHandling  // 0x34
  private           Newtonsoft.Json.JsonConverterCollection_converters  // 0x38
  private           Newtonsoft.Json.Serialization.IContractResolver_contractResolver  // 0x40
  private           Newtonsoft.Json.Serialization.ITraceWriter_traceWriter  // 0x48
  private           System.Collections.IEqualityComparer_equalityComparer  // 0x50
  private           Newtonsoft.Json.Serialization.ISerializationBinder_serializationBinder  // 0x58
  private           System.Runtime.Serialization.StreamingContext_context  // 0x60
  private           Newtonsoft.Json.Serialization.IReferenceResolver_referenceResolver  // 0x70
  private           System.Nullable<Newtonsoft.Json.Formatting>_formatting  // 0x78
  private           System.Nullable<Newtonsoft.Json.DateFormatHandling>_dateFormatHandling  // 0x80
  private           System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>_dateTimeZoneHandling  // 0x88
  private           System.Nullable<Newtonsoft.Json.DateParseHandling>_dateParseHandling  // 0x90
  private           System.Nullable<Newtonsoft.Json.FloatFormatHandling>_floatFormatHandling  // 0x98
  private           System.Nullable<Newtonsoft.Json.FloatParseHandling>_floatParseHandling  // 0xa0
  private           System.Nullable<Newtonsoft.Json.StringEscapeHandling>_stringEscapeHandling  // 0xa8
  private           System.Globalization.CultureInfo_culture  // 0xb0
  private           System.Nullable<System.Int32>   _maxDepth  // 0xb8
  private           System.Boolean                  _maxDepthSet  // 0xc0
  private           System.Nullable<System.Boolean> _checkAdditionalContent  // 0xc1
  private           System.String                   _dateFormatString  // 0xc8
  private           System.Boolean                  _dateFormatStringSet  // 0xd0
  private           System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>Error  // 0xd8
PROPERTIES:
  ReferenceResolver  set=0x092B4004
  SerializationBinder  set=0x092B4090
  TraceWriter  get=0x03D4EA70  set=0x02692290
  EqualityComparer  set=0x02C926C0
  TypeNameHandling  set=0x033008C0
  TypeNameAssemblyFormatHandling  set=0x03D4B8E0
  PreserveReferencesHandling  set=0x092B3F9C
  ReferenceLoopHandling  set=0x03D4B900
  MissingMemberHandling  set=0x092B3F34
  NullValueHandling  get=0x03D4EB90  set=0x03300DA0
  DefaultValueHandling  set=0x03300DC0
  ObjectCreationHandling  set=0x03B45E20
  ConstructorHandling  set=0x03B45E40
  MetadataPropertyHandling  get=0x03D4EE00  set=0x092B3ECC
  Converters  get=0x030436A0
  ContractResolver  get=0x03D4E2B0  set=0x03B368B0
  Context  get=0x03D5A130  set=0x05A9EA30
  Formatting  get=0x03CF50D0  set=0x03CF9A40
  MaxDepth  get=0x03D4E750
  CheckAdditionalContent  get=0x03366F90  set=0x0323E420
EVENTS:
  Error  add=add_Error  remove=remove_Error
METHODS:
  RVA=0x02696160  token=0x60000CE  System.Boolean IsCheckAdditionalContentSet()
  RVA=0x02695FD0  token=0x60000CF  System.Void .ctor()
  RVA=0x02695F70  token=0x60000D0  Newtonsoft.Json.JsonSerializer Create()
  RVA=0x02695EE0  token=0x60000D1  Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x02695E50  token=0x60000D2  Newtonsoft.Json.JsonSerializer CreateDefault()
  RVA=0x02695E10  token=0x60000D3  Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x024B38D0  token=0x60000D4  System.Void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings)
  RVA=0x092B3D60  token=0x60000D5  System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target)
  RVA=0x092B3ACC  token=0x60000D6  System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target)
  RVA=-1  // generic def  token=0x60000D7  T Deserialize(Newtonsoft.Json.JsonReader reader)
  RVA=0x04271114  token=0x60000D8  System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  RVA=0x027BC5C0  token=0x60000D9  System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  RVA=0x027BC0B0  token=0x60000DA  System.Void SetupReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo& previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, System.String& previousDateFormatString)
  RVA=0x027BC400  token=0x60000DB  System.Void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, System.String previousDateFormatString)
  RVA=0x04271160  token=0x60000DC  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  RVA=0x042710E8  token=0x60000DD  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value)
  RVA=0x092B39D0  token=0x60000DE  Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader)
  RVA=0x031637E0  token=0x60000DF  System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  RVA=0x092B3A50  token=0x60000E0  Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver()
  RVA=0x042702D4  token=0x60000E1  Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type)
  RVA=0x02415890  token=0x60000E2  Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType)
  RVA=0x092B3AAC  token=0x60000E3  System.Void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializerSettings
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x110
FIELDS:
  private   static  Newtonsoft.Json.ReferenceLoopHandlingDefaultReferenceLoopHandling  // const
  private   static  Newtonsoft.Json.MissingMemberHandlingDefaultMissingMemberHandling  // const
  private   static  Newtonsoft.Json.NullValueHandlingDefaultNullValueHandling  // const
  private   static  Newtonsoft.Json.DefaultValueHandlingDefaultDefaultValueHandling  // const
  private   static  Newtonsoft.Json.ObjectCreationHandlingDefaultObjectCreationHandling  // const
  private   static  Newtonsoft.Json.PreserveReferencesHandlingDefaultPreserveReferencesHandling  // const
  private   static  Newtonsoft.Json.ConstructorHandlingDefaultConstructorHandling  // const
  private   static  Newtonsoft.Json.TypeNameHandlingDefaultTypeNameHandling  // const
  private   static  Newtonsoft.Json.MetadataPropertyHandlingDefaultMetadataPropertyHandling  // const
  private   static readonly System.Runtime.Serialization.StreamingContextDefaultContext  // static @ 0x0
  private   static  Newtonsoft.Json.Formatting      DefaultFormatting  // const
  private   static  Newtonsoft.Json.DateFormatHandlingDefaultDateFormatHandling  // const
  private   static  Newtonsoft.Json.DateTimeZoneHandlingDefaultDateTimeZoneHandling  // const
  private   static  Newtonsoft.Json.DateParseHandlingDefaultDateParseHandling  // const
  private   static  Newtonsoft.Json.FloatParseHandlingDefaultFloatParseHandling  // const
  private   static  Newtonsoft.Json.FloatFormatHandlingDefaultFloatFormatHandling  // const
  private   static  Newtonsoft.Json.StringEscapeHandlingDefaultStringEscapeHandling  // const
  private   static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingDefaultTypeNameAssemblyFormatHandling  // const
  private   static readonly System.Globalization.CultureInfoDefaultCulture  // static @ 0x10
  private   static  System.Boolean                  DefaultCheckAdditionalContent  // const
  private   static  System.String                   DefaultDateFormatString  // const
  private   static  System.Int32                    DefaultMaxDepth  // const
  private           System.Nullable<Newtonsoft.Json.Formatting>_formatting  // 0x10
  private           System.Nullable<Newtonsoft.Json.DateFormatHandling>_dateFormatHandling  // 0x18
  private           System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>_dateTimeZoneHandling  // 0x20
  private           System.Nullable<Newtonsoft.Json.DateParseHandling>_dateParseHandling  // 0x28
  private           System.Nullable<Newtonsoft.Json.FloatFormatHandling>_floatFormatHandling  // 0x30
  private           System.Nullable<Newtonsoft.Json.FloatParseHandling>_floatParseHandling  // 0x38
  private           System.Nullable<Newtonsoft.Json.StringEscapeHandling>_stringEscapeHandling  // 0x40
  private           System.Globalization.CultureInfo_culture  // 0x48
  private           System.Nullable<System.Boolean> _checkAdditionalContent  // 0x50
  private           System.Nullable<System.Int32>   _maxDepth  // 0x54
  private           System.Boolean                  _maxDepthSet  // 0x5c
  private           System.String                   _dateFormatString  // 0x60
  private           System.Boolean                  _dateFormatStringSet  // 0x68
  private           System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling>_typeNameAssemblyFormatHandling  // 0x6c
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling>_defaultValueHandling  // 0x74
  private           System.Nullable<Newtonsoft.Json.PreserveReferencesHandling>_preserveReferencesHandling  // 0x7c
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_nullValueHandling  // 0x84
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling>_objectCreationHandling  // 0x8c
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling>_missingMemberHandling  // 0x94
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_referenceLoopHandling  // 0x9c
  private           System.Nullable<System.Runtime.Serialization.StreamingContext>_context  // 0xa8
  private           System.Nullable<Newtonsoft.Json.ConstructorHandling>_constructorHandling  // 0xc0
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_typeNameHandling  // 0xc8
  private           System.Nullable<Newtonsoft.Json.MetadataPropertyHandling>_metadataPropertyHandling  // 0xd0
  private           System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter><Converters>k__BackingField  // 0xd8
  private           Newtonsoft.Json.Serialization.IContractResolver<ContractResolver>k__BackingField  // 0xe0
  private           System.Collections.IEqualityComparer<EqualityComparer>k__BackingField  // 0xe8
  private           System.Func<Newtonsoft.Json.Serialization.IReferenceResolver><ReferenceResolverProvider>k__BackingField  // 0xf0
  private           Newtonsoft.Json.Serialization.ITraceWriter<TraceWriter>k__BackingField  // 0xf8
  private           Newtonsoft.Json.Serialization.ISerializationBinder<SerializationBinder>k__BackingField  // 0x100
  private           System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs><Error>k__BackingField  // 0x108
PROPERTIES:
  ReferenceLoopHandling  get=0x03D46F50  set=0x03D29B60
  MissingMemberHandling  get=0x092B3958
  ObjectCreationHandling  get=0x03C90470  set=0x03D29BC0
  NullValueHandling  get=0x033696A0  set=0x03CF9AA0
  DefaultValueHandling  get=0x033696E0  set=0x03CF9B00
  Converters  get=0x03D4E7B0  set=0x05142FC4
  PreserveReferencesHandling  get=0x092B3994
  TypeNameHandling  get=0x03367F30  set=0x03C8FD90
  MetadataPropertyHandling  get=0x092B391C
  TypeNameAssemblyFormatHandling  get=0x03D46F10  set=0x03D29B00
  ConstructorHandling  get=0x03C904B0  set=0x03D29C80
  ContractResolver  get=0x03D51140  set=0x0589D964
  EqualityComparer  get=0x03D50EA0  set=0x056A2B64
  ReferenceResolverProvider  get=0x03D51950  set=0x058B408C
  TraceWriter  get=0x03D50160  set=0x0554D2E0
  SerializationBinder  get=0x03D50770  set=0x055631FC
  Error  get=0x03D56D30  set=0x0589D950
  Context  get=0x092B3880
  MaxDepth  set=0x03C801B0
  Formatting  set=0x03D29C20
  CheckAdditionalContent  get=0x092B3848
METHODS:
  RVA=0x03CF1A70  token=0x6000107  System.Void .cctor()
  RVA=0x035A2350  token=0x6000108  System.Void .ctor()
  RVA=0x035A23D0  token=0x6000109  System.Void .ctor(Newtonsoft.Json.JsonSerializerSettings original)
END_CLASS

CLASS: Newtonsoft.Json.JsonTextReader
TYPE:  class
TOKEN: 0x200002C
SIZE:  0xD8
EXTENDS: Newtonsoft.Json.JsonReader
IMPLEMENTS: Newtonsoft.Json.IJsonLineInfo
FIELDS:
  private   readonly System.Boolean                  _safeAsync  // 0x78
  private   readonly System.IO.TextReader            _reader  // 0x80
  private           System.Char[]                   _chars  // 0x88
  private           System.Int32                    _charsUsed  // 0x90
  private           System.Int32                    _charPos  // 0x94
  private           System.Int32                    _lineStartPos  // 0x98
  private           System.Int32                    _lineNumber  // 0x9c
  private           System.Boolean                  _isEndOfFile  // 0xa0
  private           Newtonsoft.Json.Utilities.StringBuffer_stringBuffer  // 0xa8
  private           Newtonsoft.Json.Utilities.StringReference_stringReference  // 0xb8
  private           Newtonsoft.Json.IArrayPool<System.Char>_arrayPool  // 0xc8
  private           Newtonsoft.Json.JsonNameTable   <PropertyNameTable>k__BackingField  // 0xd0
PROPERTIES:
  PropertyNameTable  get=0x03D50050  set=0x0554A7E0
  LineNumber  get=0x02698E90
  LinePosition  get=0x03D71450
METHODS:
  RVA=0x02696210  token=0x600010A  System.Void .ctor(System.IO.TextReader reader)
  RVA=0x029057F0  token=0x600010D  System.Void EnsureBufferNotEmpty()
  RVA=0x0236BEC0  token=0x600010E  System.Void SetNewLine(System.Boolean hasNextChar)
  RVA=0x03D71420  token=0x600010F  System.Void OnNewLine(System.Int32 pos)
  RVA=0x023692D0  token=0x6000110  System.Void ParseString(System.Char quote, Newtonsoft.Json.ReadType readType)
  RVA=0x02368A90  token=0x6000111  System.Void ParseReadString(System.Char quote, Newtonsoft.Json.ReadType readType)
  RVA=0x02462430  token=0x6000112  System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count)
  RVA=0x0236AAA0  token=0x6000113  System.Void ShiftBufferIfNeeded()
  RVA=0x042726CC  token=0x6000114  System.Int32 ReadData(System.Boolean append)
  RVA=0x02B46370  token=0x6000115  System.Void PrepareBufferForReadData(System.Boolean append, System.Int32 charsRequired)
  RVA=0x02B461E0  token=0x6000116  System.Int32 ReadData(System.Boolean append, System.Int32 charsRequired)
  RVA=0x0236BBA0  token=0x6000117  System.Boolean EnsureChars(System.Int32 relativePosition, System.Boolean append)
  RVA=0x02B46090  token=0x6000118  System.Boolean ReadChars(System.Int32 relativePosition, System.Boolean append)
  RVA=0x022A7F70  token=0x6000119  System.Boolean Read()
  RVA=0x029DEEF0  token=0x600011A  System.Nullable<System.Int32> ReadAsInt32()
  RVA=0x092B5A64  token=0x600011B  System.Nullable<System.DateTime> ReadAsDateTime()
  RVA=0x0247E2E0  token=0x600011C  System.String ReadAsString()
  RVA=0x092B551C  token=0x600011D  System.Byte[] ReadAsBytes()
  RVA=0x0247D000  token=0x600011E  System.Object ReadStringValue(Newtonsoft.Json.ReadType readType)
  RVA=0x0247C2A0  token=0x600011F  System.Object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType)
  RVA=0x092B4308  token=0x6000120  Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(System.Char c)
  RVA=0x024EC700  token=0x6000121  System.Nullable<System.Boolean> ReadAsBoolean()
  RVA=0x092B54B4  token=0x6000122  System.Void ProcessValueComma()
  RVA=0x029DEFE0  token=0x6000123  System.Object ReadNumberValue(Newtonsoft.Json.ReadType readType)
  RVA=0x092B43F0  token=0x6000124  System.Object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType)
  RVA=0x092B59D8  token=0x6000125  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  RVA=0x092B5AE8  token=0x6000126  System.Nullable<System.Decimal> ReadAsDecimal()
  RVA=0x029DEE00  token=0x6000127  System.Nullable<System.Double> ReadAsDouble()
  RVA=0x092B4550  token=0x6000128  System.Void HandleNull()
  RVA=0x092B5B74  token=0x6000129  System.Void ReadFinished()
  RVA=0x029DF620  token=0x600012A  System.Boolean ReadNullChar()
  RVA=0x022A8130  token=0x600012B  System.Void EnsureBuffer()
  RVA=0x0236D260  token=0x600012C  System.Void ReadStringIntoBuffer(System.Char quote)
  RVA=0x0236B970  token=0x600012D  System.Void FinishReadStringIntoBuffer(System.Int32 charPos, System.Int32 initialPosition, System.Int32 lastWritePosition)
  RVA=0x033B9C90  token=0x600012E  System.Void WriteCharToBuffer(System.Char writeChar, System.Int32 lastWritePosition, System.Int32 writeToPosition)
  RVA=0x092B418C  token=0x600012F  System.Char ConvertUnicode(System.Boolean enoughChars)
  RVA=0x092B5378  token=0x6000130  System.Char ParseUnicode()
  RVA=0x0236BFD0  token=0x6000131  System.Void ReadNumberIntoBuffer()
  RVA=0x0236DD30  token=0x6000132  System.Boolean ReadNumberCharIntoBuffer(System.Char currentChar, System.Int32 charPos)
  RVA=0x03D71400  token=0x6000133  System.Void ClearRecentString()
  RVA=0x0236C050  token=0x6000134  System.Boolean ParsePostValue(System.Boolean ignoreComments)
  RVA=0x0236CBD0  token=0x6000135  System.Boolean ParseObject()
  RVA=0x0236DEF0  token=0x6000136  System.Boolean ParseProperty()
  RVA=0x092B5E70  token=0x6000137  System.Boolean ValidIdentifierChar(System.Char value)
  RVA=0x092B53A4  token=0x6000138  System.Void ParseUnquotedProperty()
  RVA=0x092B5CC0  token=0x6000139  System.Boolean ReadUnquotedPropertyReportIfDone(System.Char currentChar, System.Int32 initialPosition)
  RVA=0x02369400  token=0x600013A  System.Boolean ParseValue()
  RVA=0x03D71430  token=0x600013B  System.Void ProcessLineFeed()
  RVA=0x0236BD20  token=0x600013C  System.Void ProcessCarriageReturn(System.Boolean append)
  RVA=0x0236B220  token=0x600013D  System.Void EatWhitespace()
  RVA=0x092B4948  token=0x600013E  System.Void ParseConstructor()
  RVA=0x0236A8F0  token=0x600013F  System.Void ParseNumber(Newtonsoft.Json.ReadType readType)
  RVA=0x0247E5E0  token=0x6000140  System.Void ParseReadNumber(Newtonsoft.Json.ReadType readType, System.Char firstChar, System.Int32 initialPosition)
  RVA=0x092B5E1C  token=0x6000141  Newtonsoft.Json.JsonReaderException ThrowReaderError(System.String message, System.Exception ex)
  RVA=0x092B411C  token=0x6000142  System.Object BigIntegerParse(System.String number, System.Globalization.CultureInfo culture)
  RVA=0x092B462C  token=0x6000143  System.Void ParseComment(System.Boolean setToken)
  RVA=0x092B43B4  token=0x6000144  System.Void EndComment(System.Boolean setToken, System.Int32 initialPosition, System.Int32 endPosition)
  RVA=0x024EDAE0  token=0x6000145  System.Boolean MatchValue(System.String value)
  RVA=0x024EDCD0  token=0x6000146  System.Boolean MatchValue(System.Boolean enoughChars, System.String value)
  RVA=0x024ED700  token=0x6000147  System.Boolean MatchValueWithTrailingSeparator(System.String value)
  RVA=0x024EDA70  token=0x6000148  System.Boolean IsSeparator(System.Char c)
  RVA=0x03A2C3D0  token=0x6000149  System.Void ParseTrue()
  RVA=0x03C85E30  token=0x600014A  System.Void ParseNull()
  RVA=0x092B52D8  token=0x600014B  System.Void ParseUndefined()
  RVA=0x038C6C60  token=0x600014C  System.Void ParseFalse()
  RVA=0x092B5080  token=0x600014D  System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType)
  RVA=0x092B4F08  token=0x600014E  System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  RVA=0x092B5268  token=0x600014F  System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType)
  RVA=0x092B50F0  token=0x6000150  System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  RVA=0x092B4D20  token=0x6000151  System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType)
  RVA=0x092B4D90  token=0x6000152  System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  RVA=0x030AB480  token=0x6000153  System.Void Close()
  RVA=0x0232EB60  token=0x6000154  System.Boolean HasLineInfo()
END_CLASS

CLASS: Newtonsoft.Json.ReadType
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ReadType        Read  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsInt32  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsInt64  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsBytes  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsString  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsDecimal  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsDateTime  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsDateTimeOffset  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsDouble  // const
  public    static  Newtonsoft.Json.ReadType        ReadAsBoolean  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonTextWriter
TYPE:  class
TOKEN: 0x200002E
SIZE:  0xA8
EXTENDS: Newtonsoft.Json.JsonWriter
FIELDS:
  private   readonly System.Boolean                  _safeAsync  // 0x60
  private   readonly System.IO.TextWriter            _writer  // 0x68
  private           Newtonsoft.Json.Utilities.Base64Encoder_base64Encoder  // 0x70
  private           System.Char                     _indentChar  // 0x78
  private           System.Int32                    _indentation  // 0x7c
  private           System.Char                     _quoteChar  // 0x80
  private           System.Boolean                  _quoteName  // 0x82
  private           System.Boolean[]                _charEscapeFlags  // 0x88
  private           System.Char[]                   _writeBuffer  // 0x90
  private           Newtonsoft.Json.IArrayPool<System.Char>_arrayPool  // 0x98
  private           System.Char[]                   _indentChars  // 0xa0
PROPERTIES:
  Base64Encoder  get=0x092B6F30
  QuoteChar  get=0x03D71460
METHODS:
  RVA=0x02697830  token=0x6000159  System.Void .ctor(System.IO.TextWriter textWriter)
  RVA=0x030AB3E0  token=0x600015A  System.Void Close()
  RVA=0x030AB410  token=0x600015B  System.Void CloseBufferAndWriter()
  RVA=0x02905C80  token=0x600015C  System.Void WriteStartObject()
  RVA=0x02905510  token=0x600015D  System.Void WriteStartArray()
  RVA=0x092B606C  token=0x600015E  System.Void WriteStartConstructor(System.String name)
  RVA=0x02905CC0  token=0x600015F  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  RVA=0x02905C20  token=0x6000160  System.Void WritePropertyName(System.String name)
  RVA=0x029060B0  token=0x6000161  System.Void WritePropertyName(System.String name, System.Boolean escape)
  RVA=0x092B5EC8  token=0x6000162  System.Void OnStringEscapeHandlingChanged()
  RVA=0x02697940  token=0x6000163  System.Void UpdateCharEscapeFlags()
  RVA=0x025EE550  token=0x6000164  System.Void WriteIndent()
  RVA=0x025EE6F0  token=0x6000165  System.Int32 SetIndentChars()
  RVA=0x02905D20  token=0x6000166  System.Void WriteValueDelimiter()
  RVA=0x02905EC0  token=0x6000167  System.Void WriteIndentSpace()
  RVA=0x02907540  token=0x6000168  System.Void WriteValueInternal(System.String value, Newtonsoft.Json.JsonToken token)
  RVA=0x092B64B0  token=0x6000169  System.Void WriteValue(System.Object value)
  RVA=0x092B5FE0  token=0x600016A  System.Void WriteNull()
  RVA=0x092B6104  token=0x600016B  System.Void WriteUndefined()
  RVA=0x092B6048  token=0x600016C  System.Void WriteRaw(System.String json)
  RVA=0x02905A90  token=0x600016D  System.Void WriteValue(System.String value)
  RVA=0x02905D90  token=0x600016E  System.Void WriteEscapedString(System.String value, System.Boolean quote)
  RVA=0x029054A0  token=0x600016F  System.Void WriteValue(System.Int32 value)
  RVA=0x092B6778  token=0x6000170  System.Void WriteValue(System.UInt32 value)
  RVA=0x02905A50  token=0x6000171  System.Void WriteValue(System.Int64 value)
  RVA=0x092B6D9C  token=0x6000172  System.Void WriteValue(System.UInt64 value)
  RVA=0x092B6DD4  token=0x6000173  System.Void WriteValue(System.Single value)
  RVA=0x092B6E6C  token=0x6000174  System.Void WriteValue(System.Nullable<System.Single> value)
  RVA=0x092B6D04  token=0x6000175  System.Void WriteValue(System.Double value)
  RVA=0x092B6578  token=0x6000176  System.Void WriteValue(System.Nullable<System.Double> value)
  RVA=0x02905B00  token=0x6000177  System.Void WriteValue(System.Boolean value)
  RVA=0x092B6640  token=0x6000178  System.Void WriteValue(System.Int16 value)
  RVA=0x092B6744  token=0x6000179  System.Void WriteValue(System.UInt16 value)
  RVA=0x092B6C94  token=0x600017A  System.Void WriteValue(System.Char value)
  RVA=0x092B6C60  token=0x600017B  System.Void WriteValue(System.Byte value)
  RVA=0x092B69F8  token=0x600017C  System.Void WriteValue(System.SByte value)
  RVA=0x092B68E8  token=0x600017D  System.Void WriteValue(System.Decimal value)
  RVA=0x092B6A2C  token=0x600017E  System.Void WriteValue(System.DateTime value)
  RVA=0x092B62D0  token=0x600017F  System.Int32 WriteValueToBuffer(System.DateTime value)
  RVA=0x092B63F4  token=0x6000180  System.Void WriteValue(System.Byte[] value)
  RVA=0x092B67AC  token=0x6000181  System.Void WriteValue(System.DateTimeOffset value)
  RVA=0x092B616C  token=0x6000182  System.Int32 WriteValueToBuffer(System.DateTimeOffset value)
  RVA=0x092B6674  token=0x6000183  System.Void WriteValue(System.Guid value)
  RVA=0x092B6B84  token=0x6000184  System.Void WriteValue(System.TimeSpan value)
  RVA=0x092B6960  token=0x6000185  System.Void WriteValue(System.Uri value)
  RVA=0x092B5ED0  token=0x6000186  System.Void WriteComment(System.String text)
  RVA=0x02905E70  token=0x6000187  System.Void EnsureWriteBuffer()
  RVA=0x02907570  token=0x6000188  System.Void WriteIntegerValue(System.Int64 value)
  RVA=0x029058A0  token=0x6000189  System.Void WriteIntegerValue(System.UInt64 value, System.Boolean negative)
  RVA=0x02905930  token=0x600018A  System.Int32 WriteNumberToBuffer(System.UInt64 value, System.Boolean negative)
  RVA=0x02905450  token=0x600018B  System.Void WriteIntegerValue(System.Int32 value)
  RVA=0x092B5F6C  token=0x600018C  System.Void WriteIntegerValue(System.UInt32 value, System.Boolean negative)
  RVA=0x02905970  token=0x600018D  System.Int32 WriteNumberToBuffer(System.UInt32 value, System.Boolean negative)
END_CLASS

CLASS: Newtonsoft.Json.JsonToken
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonToken       None  // const
  public    static  Newtonsoft.Json.JsonToken       StartObject  // const
  public    static  Newtonsoft.Json.JsonToken       StartArray  // const
  public    static  Newtonsoft.Json.JsonToken       StartConstructor  // const
  public    static  Newtonsoft.Json.JsonToken       PropertyName  // const
  public    static  Newtonsoft.Json.JsonToken       Comment  // const
  public    static  Newtonsoft.Json.JsonToken       Raw  // const
  public    static  Newtonsoft.Json.JsonToken       Integer  // const
  public    static  Newtonsoft.Json.JsonToken       Float  // const
  public    static  Newtonsoft.Json.JsonToken       String  // const
  public    static  Newtonsoft.Json.JsonToken       Boolean  // const
  public    static  Newtonsoft.Json.JsonToken       Null  // const
  public    static  Newtonsoft.Json.JsonToken       Undefined  // const
  public    static  Newtonsoft.Json.JsonToken       EndObject  // const
  public    static  Newtonsoft.Json.JsonToken       EndArray  // const
  public    static  Newtonsoft.Json.JsonToken       EndConstructor  // const
  public    static  Newtonsoft.Json.JsonToken       Date  // const
  public    static  Newtonsoft.Json.JsonToken       Bytes  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonWriter
TYPE:  abstract class
TOKEN: 0x2000030
SIZE:  0x60
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly Newtonsoft.Json.JsonWriter.State[][]StateArray  // static @ 0x0
  private   static readonly Newtonsoft.Json.JsonWriter.State[][]StateArrayTemplate  // static @ 0x8
  private           System.Collections.Generic.List<Newtonsoft.Json.JsonPosition>_stack  // 0x10
  private           Newtonsoft.Json.JsonPosition    _currentPosition  // 0x18
  private           Newtonsoft.Json.JsonWriter.State_currentState  // 0x30
  private           Newtonsoft.Json.Formatting      _formatting  // 0x34
  private           System.Boolean                  <CloseOutput>k__BackingField  // 0x38
  private           System.Boolean                  <AutoCompleteOnClose>k__BackingField  // 0x39
  private           Newtonsoft.Json.DateFormatHandling_dateFormatHandling  // 0x3c
  private           Newtonsoft.Json.DateTimeZoneHandling_dateTimeZoneHandling  // 0x40
  private           Newtonsoft.Json.StringEscapeHandling_stringEscapeHandling  // 0x44
  private           Newtonsoft.Json.FloatFormatHandling_floatFormatHandling  // 0x48
  private           System.String                   _dateFormatString  // 0x50
  private           System.Globalization.CultureInfo_culture  // 0x58
PROPERTIES:
  CloseOutput  get=0x03D4F190  set=0x03D4E280
  AutoCompleteOnClose  get=0x03D4F300  set=0x03D4F330
  Top  get=0x025EE690
  WriteState  get=0x092B7FA0
  ContainerPath  get=0x092B7E28
  Path  get=0x092B7EAC
  Formatting  get=0x03D4EE00  set=0x02697660
  DateFormatHandling  get=0x03D4ED90  set=0x092B80A4
  DateTimeZoneHandling  get=0x03D4ED80  set=0x092B810C
  StringEscapeHandling  get=0x03D4EE80  set=0x092B81DC
  FloatFormatHandling  get=0x03D4EC50  set=0x092B8174
  DateFormatString  get=0x03D4EAF0  set=0x02C926C0
  Culture  get=0x03163B30  set=0x03081D30
METHODS:
  RVA=0x02905610  token=0x600018E  Newtonsoft.Json.JsonWriter.State[][] BuildStateArray()
  RVA=0x02563190  token=0x600018F  System.Void .cctor()
  RVA=0x0350B670  token=0x60001A0  System.Void OnStringEscapeHandlingChanged()
  RVA=0x03D71470  token=0x60001A7  System.Void .ctor()
  RVA=0x02906C00  token=0x60001A8  System.Void UpdateScopeWithFinishedValue()
  RVA=0x02906DD0  token=0x60001A9  System.Void Push(Newtonsoft.Json.JsonContainerType value)
  RVA=0x03437BF0  token=0x60001AA  Newtonsoft.Json.JsonContainerType Pop()
  RVA=0x020D1AC0  token=0x60001AB  Newtonsoft.Json.JsonContainerType Peek()
  RVA=0x025EE630  token=0x60001AC  System.Void Close()
  RVA=0x04271184  token=0x60001AD  System.Void WriteStartObject()
  RVA=0x038936C0  token=0x60001AE  System.Void WriteEndObject()
  RVA=0x04271194  token=0x60001AF  System.Void WriteStartArray()
  RVA=0x038936B0  token=0x60001B0  System.Void WriteEndArray()
  RVA=0x092B753C  token=0x60001B1  System.Void WriteStartConstructor(System.String name)
  RVA=0x092B7410  token=0x60001B2  System.Void WriteEndConstructor()
  RVA=0x042711A4  token=0x60001B3  System.Void WritePropertyName(System.String name)
  RVA=0x03B45E00  token=0x60001B4  System.Void WritePropertyName(System.String name, System.Boolean escape)
  RVA=0x092B7420  token=0x60001B5  System.Void WriteEnd()
  RVA=0x04271108  token=0x60001B6  System.Void WriteToken(Newtonsoft.Json.JsonReader reader)
  RVA=0x0269A170  token=0x60001B7  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren)
  RVA=0x0269A500  token=0x60001B8  System.Void WriteToken(Newtonsoft.Json.JsonToken token, System.Object value)
  RVA=0x0269A370  token=0x60001B9  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments)
  RVA=0x0269A2C0  token=0x60001BA  System.Boolean IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Int32 initialDepth)
  RVA=0x0269A840  token=0x60001BB  System.Int32 CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader)
  RVA=0x0269A310  token=0x60001BC  System.Int32 CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader)
  RVA=0x092B7368  token=0x60001BD  System.Void WriteConstructorDate(Newtonsoft.Json.JsonReader reader)
  RVA=0x092B742C  token=0x60001BE  System.Void WriteEnd(Newtonsoft.Json.JsonContainerType type)
  RVA=0x025EE640  token=0x60001BF  System.Void AutoCompleteAll()
  RVA=0x03437B50  token=0x60001C0  Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type)
  RVA=0x03437AB0  token=0x60001C1  System.Void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type)
  RVA=0x03437B90  token=0x60001C2  System.Int32 CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type)
  RVA=0x03437CE0  token=0x60001C3  System.Void UpdateCurrentState()
  RVA=0x0350B670  token=0x60001C4  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  RVA=0x0350B670  token=0x60001C5  System.Void WriteIndent()
  RVA=0x0350B670  token=0x60001C6  System.Void WriteValueDelimiter()
  RVA=0x0350B670  token=0x60001C7  System.Void WriteIndentSpace()
  RVA=0x02906C10  token=0x60001C8  System.Void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten)
  RVA=0x092B74EC  token=0x60001C9  System.Void WriteNull()
  RVA=0x092B754C  token=0x60001CA  System.Void WriteUndefined()
  RVA=0x0350B670  token=0x60001CB  System.Void WriteRaw(System.String json)
  RVA=0x092B74FC  token=0x60001CC  System.Void WriteRawValue(System.String json)
  RVA=0x042711D8  token=0x60001CD  System.Void WriteValue(System.String value)
  RVA=0x042711E8  token=0x60001CE  System.Void WriteValue(System.Int32 value)
  RVA=0x042711E8  token=0x60001CF  System.Void WriteValue(System.UInt32 value)
  RVA=0x042711E8  token=0x60001D0  System.Void WriteValue(System.Int64 value)
  RVA=0x042711E8  token=0x60001D1  System.Void WriteValue(System.UInt64 value)
  RVA=0x092B7718  token=0x60001D2  System.Void WriteValue(System.Single value)
  RVA=0x092B7718  token=0x60001D3  System.Void WriteValue(System.Double value)
  RVA=0x04276B00  token=0x60001D4  System.Void WriteValue(System.Boolean value)
  RVA=0x042711E8  token=0x60001D5  System.Void WriteValue(System.Int16 value)
  RVA=0x042711E8  token=0x60001D6  System.Void WriteValue(System.UInt16 value)
  RVA=0x042711D8  token=0x60001D7  System.Void WriteValue(System.Char value)
  RVA=0x042711E8  token=0x60001D8  System.Void WriteValue(System.Byte value)
  RVA=0x042711E8  token=0x60001D9  System.Void WriteValue(System.SByte value)
  RVA=0x092B7718  token=0x60001DA  System.Void WriteValue(System.Decimal value)
  RVA=0x092B75C8  token=0x60001DB  System.Void WriteValue(System.DateTime value)
  RVA=0x092B75C8  token=0x60001DC  System.Void WriteValue(System.DateTimeOffset value)
  RVA=0x042711D8  token=0x60001DD  System.Void WriteValue(System.Guid value)
  RVA=0x042711D8  token=0x60001DE  System.Void WriteValue(System.TimeSpan value)
  RVA=0x092B7CEC  token=0x60001DF  System.Void WriteValue(System.Nullable<System.Int32> value)
  RVA=0x092B77F4  token=0x60001E0  System.Void WriteValue(System.Nullable<System.UInt32> value)
  RVA=0x092B7A74  token=0x60001E1  System.Void WriteValue(System.Nullable<System.Int64> value)
  RVA=0x092B7934  token=0x60001E2  System.Void WriteValue(System.Nullable<System.UInt64> value)
  RVA=0x092B7728  token=0x60001E3  System.Void WriteValue(System.Nullable<System.Single> value)
  RVA=0x092B7860  token=0x60001E4  System.Void WriteValue(System.Nullable<System.Double> value)
  RVA=0x092B7C4C  token=0x60001E5  System.Void WriteValue(System.Nullable<System.Boolean> value)
  RVA=0x092B799C  token=0x60001E6  System.Void WriteValue(System.Nullable<System.Int16> value)
  RVA=0x092B7DC4  token=0x60001E7  System.Void WriteValue(System.Nullable<System.UInt16> value)
  RVA=0x092B755C  token=0x60001E8  System.Void WriteValue(System.Nullable<System.Char> value)
  RVA=0x092B78C8  token=0x60001E9  System.Void WriteValue(System.Nullable<System.Byte> value)
  RVA=0x092B76B0  token=0x60001EA  System.Void WriteValue(System.Nullable<System.SByte> value)
  RVA=0x092B7640  token=0x60001EB  System.Void WriteValue(System.Nullable<System.Decimal> value)
  RVA=0x092B75D8  token=0x60001EC  System.Void WriteValue(System.Nullable<System.DateTime> value)
  RVA=0x092B7A08  token=0x60001ED  System.Void WriteValue(System.Nullable<System.DateTimeOffset> value)
  RVA=0x092B7D58  token=0x60001EE  System.Void WriteValue(System.Nullable<System.Guid> value)
  RVA=0x092B7794  token=0x60001EF  System.Void WriteValue(System.Nullable<System.TimeSpan> value)
  RVA=0x092B7CB8  token=0x60001F0  System.Void WriteValue(System.Byte[] value)
  RVA=0x092B7ADC  token=0x60001F1  System.Void WriteValue(System.Uri value)
  RVA=0x092B7B50  token=0x60001F2  System.Void WriteValue(System.Object value)
  RVA=0x092B7054  token=0x60001F3  System.Void WriteComment(System.String text)
  RVA=0x0341A550  token=0x60001F4  System.Void System.IDisposable.Dispose()
  RVA=0x0341A5B0  token=0x60001F5  System.Void Dispose(System.Boolean disposing)
  RVA=0x027BB550  token=0x60001F6  System.Void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, System.Object value)
  RVA=0x092B7064  token=0x60001F7  System.Void ResolveConvertibleValue(System.IConvertible convertible, Newtonsoft.Json.Utilities.PrimitiveTypeCode& typeCode, System.Object& value)
  RVA=0x092B6FB4  token=0x60001F8  Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, System.Object value)
  RVA=0x092B715C  token=0x60001F9  System.Void SetWriteState(Newtonsoft.Json.JsonToken token, System.Object value)
  RVA=0x04276BEC  token=0x60001FA  System.Void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container)
  RVA=0x02906BB0  token=0x60001FB  System.Void InternalWritePropertyName(System.String name)
  RVA=0x0350B670  token=0x60001FC  System.Void InternalWriteRaw()
  RVA=0x02905D50  token=0x60001FD  System.Void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container)
  RVA=0x02906BE0  token=0x60001FE  System.Void InternalWriteValue(Newtonsoft.Json.JsonToken token)
  RVA=0x092B7054  token=0x60001FF  System.Void InternalWriteComment()
END_CLASS

CLASS: Newtonsoft.Json.JsonWriterException
TYPE:  class
TOKEN: 0x2000032
SIZE:  0x98
EXTENDS: Newtonsoft.Json.JsonException
FIELDS:
  private   readonly System.String                   <Path>k__BackingField  // 0x90
METHODS:
  RVA=0x092B11D4  token=0x6000200  System.Void .ctor()
  RVA=0x092B1234  token=0x6000201  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x092C15B4  token=0x6000202  System.Void .ctor(System.String message, System.String path, System.Exception innerException)
  RVA=0x092C1574  token=0x6000203  Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, System.String message, System.Exception ex)
  RVA=0x092C14C4  token=0x6000204  Newtonsoft.Json.JsonWriterException Create(System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.MemberSerialization
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MemberSerializationOptOut  // const
  public    static  Newtonsoft.Json.MemberSerializationOptIn  // const
  public    static  Newtonsoft.Json.MemberSerializationFields  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.MetadataPropertyHandling
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MetadataPropertyHandlingDefault  // const
  public    static  Newtonsoft.Json.MetadataPropertyHandlingReadAhead  // const
  public    static  Newtonsoft.Json.MetadataPropertyHandlingIgnore  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.MissingMemberHandling
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MissingMemberHandlingIgnore  // const
  public    static  Newtonsoft.Json.MissingMemberHandlingError  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.NullValueHandling
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.NullValueHandlingInclude  // const
  public    static  Newtonsoft.Json.NullValueHandlingIgnore  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.ObjectCreationHandling
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ObjectCreationHandlingAuto  // const
  public    static  Newtonsoft.Json.ObjectCreationHandlingReuse  // const
  public    static  Newtonsoft.Json.ObjectCreationHandlingReplace  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.PreserveReferencesHandling
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.PreserveReferencesHandlingNone  // const
  public    static  Newtonsoft.Json.PreserveReferencesHandlingObjects  // const
  public    static  Newtonsoft.Json.PreserveReferencesHandlingArrays  // const
  public    static  Newtonsoft.Json.PreserveReferencesHandlingAll  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.ReferenceLoopHandling
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ReferenceLoopHandlingError  // const
  public    static  Newtonsoft.Json.ReferenceLoopHandlingIgnore  // const
  public    static  Newtonsoft.Json.ReferenceLoopHandlingSerialize  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Required
TYPE:  sealed struct
TOKEN: 0x200003A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Required        Default  // const
  public    static  Newtonsoft.Json.Required        AllowNull  // const
  public    static  Newtonsoft.Json.Required        Always  // const
  public    static  Newtonsoft.Json.Required        DisallowNull  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.StringEscapeHandling
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.StringEscapeHandlingDefault  // const
  public    static  Newtonsoft.Json.StringEscapeHandlingEscapeNonAscii  // const
  public    static  Newtonsoft.Json.StringEscapeHandlingEscapeHtml  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.TypeNameAssemblyFormatHandling
TYPE:  sealed struct
TOKEN: 0x200003C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingSimple  // const
  public    static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingFull  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.TypeNameHandling
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.TypeNameHandlingNone  // const
  public    static  Newtonsoft.Json.TypeNameHandlingObjects  // const
  public    static  Newtonsoft.Json.TypeNameHandlingArrays  // const
  public    static  Newtonsoft.Json.TypeNameHandlingAll  // const
  public    static  Newtonsoft.Json.TypeNameHandlingAuto  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.WriteState
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.WriteState      Error  // const
  public    static  Newtonsoft.Json.WriteState      Closed  // const
  public    static  Newtonsoft.Json.WriteState      Object  // const
  public    static  Newtonsoft.Json.WriteState      Array  // const
  public    static  Newtonsoft.Json.WriteState      Constructor  // const
  public    static  Newtonsoft.Json.WriteState      Property  // const
  public    static  Newtonsoft.Json.WriteState      Start  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonObjectId
TYPE:  class
TOKEN: 0x2000122
SIZE:  0x18
FIELDS:
  private   readonly System.Byte[]                   <Value>k__BackingField  // 0x10
PROPERTIES:
  Value  get=0x020B7B20
METHODS:
  RVA=0x092E059C  token=0x6000958  System.Void .ctor(System.Byte[] value)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonToken
TYPE:  abstract class
TOKEN: 0x2000123
SIZE:  0x18
FIELDS:
  private           Newtonsoft.Json.Bson.BsonToken  <Parent>k__BackingField  // 0x10
PROPERTIES:
  Type  get=-1  // abstract
  Parent  set=0x0426FEE0
METHODS:
  RVA=0x0350B670  token=0x600095B  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonObject
TYPE:  class
TOKEN: 0x2000124
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Bson.BsonToken
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty>_children  // 0x18
PROPERTIES:
  Type  get=0x03D51050
METHODS:
  RVA=0x092E069C  token=0x600095C  System.Void Add(System.String name, Newtonsoft.Json.Bson.BsonToken token)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonArray
TYPE:  class
TOKEN: 0x2000125
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Bson.BsonToken
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken>_children  // 0x18
PROPERTIES:
  Type  get=0x03D51040
METHODS:
  RVA=0x092E0534  token=0x600095E  System.Void Add(Newtonsoft.Json.Bson.BsonToken token)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonValue
TYPE:  class
TOKEN: 0x2000126
SIZE:  0x28
EXTENDS: Newtonsoft.Json.Bson.BsonToken
FIELDS:
  private   readonly System.Object                   _value  // 0x18
  private   readonly Newtonsoft.Json.Bson.BsonType   _type  // 0x20
PROPERTIES:
  Type  get=0x03D4EF90
METHODS:
  RVA=0x07F33C78  token=0x6000960  System.Void .ctor(System.Object value, Newtonsoft.Json.Bson.BsonType type)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonString
TYPE:  class
TOKEN: 0x2000127
SIZE:  0x30
EXTENDS: Newtonsoft.Json.Bson.BsonValue
FIELDS:
  private   readonly System.Boolean                  <IncludeLength>k__BackingField  // 0x28
METHODS:
  RVA=0x092E084C  token=0x6000962  System.Void .ctor(System.Object value, System.Boolean includeLength)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonRegex
TYPE:  class
TOKEN: 0x2000128
SIZE:  0x28
EXTENDS: Newtonsoft.Json.Bson.BsonToken
FIELDS:
  private           Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField  // 0x18
  private           Newtonsoft.Json.Bson.BsonString <Options>k__BackingField  // 0x20
PROPERTIES:
  Pattern  set=0x022C3A90
  Options  set=0x04271930
  Type  get=0x03D5C650
METHODS:
  RVA=0x092E0794  token=0x6000965  System.Void .ctor(System.String pattern, System.String options)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonProperty
TYPE:  class
TOKEN: 0x2000129
SIZE:  0x20
FIELDS:
  private           Newtonsoft.Json.Bson.BsonString <Name>k__BackingField  // 0x10
  private           Newtonsoft.Json.Bson.BsonToken  <Value>k__BackingField  // 0x18
PROPERTIES:
  Name  set=0x0426FEE0
  Value  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x6000969  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonType
TYPE:  sealed struct
TOKEN: 0x200012A
SIZE:  0x11
FIELDS:
  public            System.SByte                    value__  // 0x10
  public    static  Newtonsoft.Json.Bson.BsonType   Number  // const
  public    static  Newtonsoft.Json.Bson.BsonType   String  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Object  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Array  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Binary  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Undefined  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Oid  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Boolean  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Date  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Null  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Regex  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Reference  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Code  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Symbol  // const
  public    static  Newtonsoft.Json.Bson.BsonType   CodeWScope  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Integer  // const
  public    static  Newtonsoft.Json.Bson.BsonType   TimeStamp  // const
  public    static  Newtonsoft.Json.Bson.BsonType   Long  // const
  public    static  Newtonsoft.Json.Bson.BsonType   MinKey  // const
  public    static  Newtonsoft.Json.Bson.BsonType   MaxKey  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonWriter
TYPE:  class
TOKEN: 0x200012B
SIZE:  0x78
EXTENDS: Newtonsoft.Json.JsonWriter
FIELDS:
  private           Newtonsoft.Json.Bson.BsonToken  _root  // 0x60
  private           Newtonsoft.Json.Bson.BsonToken  _parent  // 0x68
  private           System.String                   _propertyName  // 0x70
METHODS:
  RVA=0x092E0A10  token=0x600096A  System.Void AddValue(System.Object value, Newtonsoft.Json.Bson.BsonType type)
  RVA=0x092E0874  token=0x600096B  System.Void AddToken(Newtonsoft.Json.Bson.BsonToken token)
  RVA=0x092E0A98  token=0x600096C  System.Void WriteObjectId(System.Byte[] value)
  RVA=0x092E0B84  token=0x600096D  System.Void WriteRegex(System.String pattern, System.String options)
END_CLASS

CLASS: Newtonsoft.Json.Converters.BinaryConverter
TYPE:  class
TOKEN: 0x20000F9
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static  System.String                   BinaryTypeName  // const
  private   static  System.String                   BinaryToArrayName  // const
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_reflectionObject  // static @ 0x0
METHODS:
  RVA=0x092CE610  token=0x600082C  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092CDE50  token=0x600082D  System.Byte[] GetByteArray(System.Object value)
  RVA=0x092CDCE8  token=0x600082E  System.Void EnsureReflectionObject(System.Type t)
  RVA=0x092CE22C  token=0x600082F  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092CE014  token=0x6000830  System.Byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader)
  RVA=0x0323F3B0  token=0x6000831  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000832  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.BsonObjectIdConverter
TYPE:  class
TOKEN: 0x20000FA
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=0x092CE7B4  token=0x6000833  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092CE660  token=0x6000834  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x033B3D50  token=0x6000835  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000836  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.CustomCreationConverter`1
TYPE:  abstract class
TOKEN: 0x20000FB
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
PROPERTIES:
  CanWrite  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000837  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // not resolved  token=0x6000838  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=-1  // abstract  token=0x6000839  T Create(System.Type objectType)
  RVA=-1  // not resolved  token=0x600083A  System.Boolean CanConvert(System.Type objectType)
  RVA=-1  // not resolved  token=0x600083C  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DataSetConverter
TYPE:  class
TOKEN: 0x20000FC
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=0x092E0E98  token=0x600083D  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E0C78  token=0x600083E  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x03365BE0  token=0x600083F  System.Boolean CanConvert(System.Type valueType)
  RVA=0x0350B670  token=0x6000840  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DataTableConverter
TYPE:  class
TOKEN: 0x20000FD
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=0x092E19AC  token=0x6000841  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E1754  token=0x6000842  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E1194  token=0x6000843  System.Void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E1580  token=0x6000844  System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader)
  RVA=0x03365B50  token=0x6000845  System.Boolean CanConvert(System.Type valueType)
  RVA=0x0350B670  token=0x6000846  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DateTimeConverterBase
TYPE:  abstract class
TOKEN: 0x20000FE
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=0x092E1E5C  token=0x6000847  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000848  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DiscriminatedUnionConverter
TYPE:  class
TOKEN: 0x20000FF
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static  System.String                   CasePropertyName  // const
  private   static  System.String                   FieldsPropertyName  // const
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union>UnionCache  // static @ 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type>UnionTypeLookupCache  // static @ 0x8
METHODS:
  RVA=0x092E1F50  token=0x6000849  System.Type CreateUnionTypeLookup(System.Type t)
  RVA=0x092E2074  token=0x600084A  Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t)
  RVA=0x092E2B94  token=0x600084B  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E24FC  token=0x600084C  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x0283D120  token=0x600084D  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x600084E  System.Void .ctor()
  RVA=0x038CEDA0  token=0x600084F  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.EntityKeyMemberConverter
TYPE:  class
TOKEN: 0x2000104
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static  System.String                   EntityKeyMemberFullTypeName  // const
  private   static  System.String                   KeyPropertyName  // const
  private   static  System.String                   TypePropertyName  // const
  private   static  System.String                   ValuePropertyName  // const
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_reflectionObject  // static @ 0x0
METHODS:
  RVA=0x092E3384  token=0x6000856  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E3044  token=0x6000857  System.Void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, System.String propertyName)
  RVA=0x092E3140  token=0x6000858  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E2F60  token=0x6000859  System.Void EnsureReflectionObject(System.Type objectType)
  RVA=0x03269D90  token=0x600085A  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x600085B  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.ExpandoObjectConverter
TYPE:  class
TOKEN: 0x2000105
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
PROPERTIES:
  CanWrite  get=0x0115F4C0
METHODS:
  RVA=0x0350B670  token=0x600085C  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E3644  token=0x600085D  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E3900  token=0x600085E  System.Object ReadValue(Newtonsoft.Json.JsonReader reader)
  RVA=0x092E364C  token=0x600085F  System.Object ReadList(Newtonsoft.Json.JsonReader reader)
  RVA=0x092E3768  token=0x6000860  System.Object ReadObject(Newtonsoft.Json.JsonReader reader)
  RVA=0x033B3CE0  token=0x6000861  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000863  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IsoDateTimeConverter
TYPE:  class
TOKEN: 0x2000106
SIZE:  0x28
EXTENDS: Newtonsoft.Json.Converters.DateTimeConverterBase
FIELDS:
  private   static  System.String                   DefaultDateTimeFormat  // const
  private           System.Globalization.DateTimeStyles_dateTimeStyles  // 0x10
  private           System.String                   _dateTimeFormat  // 0x18
  private           System.Globalization.CultureInfo_culture  // 0x20
PROPERTIES:
  DateTimeStyles  get=0x03D4E340  set=0x010410F0
  DateTimeFormat  get=0x092E4138  set=0x092E4180
  Culture  get=0x092E40E4  set=0x04271930
METHODS:
  RVA=0x092E3EA8  token=0x600086A  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E3A70  token=0x600086B  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x03D71650  token=0x600086C  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.JavaScriptDateTimeConverter
TYPE:  class
TOKEN: 0x2000107
SIZE:  0x10
EXTENDS: Newtonsoft.Json.Converters.DateTimeConverterBase
FIELDS:
METHODS:
  RVA=0x092E44E4  token=0x600086D  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E41C8  token=0x600086E  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x0350B670  token=0x600086F  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.KeyValuePairConverter
TYPE:  class
TOKEN: 0x2000108
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static  System.String                   KeyName  // const
  private   static  System.String                   ValueName  // const
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject>ReflectionObjectPerType  // static @ 0x0
METHODS:
  RVA=0x092E467C  token=0x6000870  Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t)
  RVA=0x092E4B58  token=0x6000871  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E47FC  token=0x6000872  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x024768F0  token=0x6000873  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000874  System.Void .ctor()
  RVA=0x03C83B50  token=0x6000875  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.RegexConverter
TYPE:  class
TOKEN: 0x2000109
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static  System.String                   PatternName  // const
  private   static  System.String                   OptionsName  // const
METHODS:
  RVA=0x092E54E0  token=0x6000876  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x02325BB0  token=0x6000877  System.Boolean HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag)
  RVA=0x092E5250  token=0x6000878  System.Void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex)
  RVA=0x092E536C  token=0x6000879  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E4DD0  token=0x600087A  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E5100  token=0x600087B  System.Object ReadRegexString(Newtonsoft.Json.JsonReader reader)
  RVA=0x092E4E70  token=0x600087C  System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x03365C70  token=0x600087D  System.Boolean CanConvert(System.Type objectType)
  RVA=0x092E4D6C  token=0x600087E  System.Boolean IsRegex(System.Type objectType)
  RVA=0x0350B670  token=0x600087F  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.StringEnumConverter
TYPE:  class
TOKEN: 0x200010A
SIZE:  0x20
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategy>k__BackingField  // 0x10
  private           System.Boolean                  <AllowIntegerValues>k__BackingField  // 0x18
PROPERTIES:
  CamelCaseText  get=0x092E5EF0  set=0x092E5F34
  NamingStrategy  get=0x020B7B20  set=0x0426FEE0
  AllowIntegerValues  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x03D587A0  token=0x6000886  System.Void .ctor()
  RVA=0x092E5C1C  token=0x6000887  System.Void .ctor(System.Boolean camelCaseText)
  RVA=0x092E5BF4  token=0x6000888  System.Void .ctor(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.Boolean allowIntegerValues)
  RVA=0x092E5C80  token=0x6000889  System.Void .ctor(System.Type namingStrategyType)
  RVA=0x092E5D40  token=0x600088A  System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters)
  RVA=0x092E5E10  token=0x600088B  System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters, System.Boolean allowIntegerValues)
  RVA=0x092E5A38  token=0x600088C  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E5604  token=0x600088D  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E55A8  token=0x600088E  System.Boolean CanConvert(System.Type objectType)
END_CLASS

CLASS: Newtonsoft.Json.Converters.UnixDateTimeConverter
TYPE:  class
TOKEN: 0x200010B
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Converters.DateTimeConverterBase
FIELDS:
  private   static readonly System.DateTime                 UnixEpoch  // static @ 0x0
  private           System.Boolean                  <AllowPreEpoch>k__BackingField  // 0x10
PROPERTIES:
  AllowPreEpoch  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x03D557C0  token=0x6000891  System.Void .ctor()
  RVA=0x03D4E960  token=0x6000892  System.Void .ctor(System.Boolean allowPreEpoch)
  RVA=0x092E6458  token=0x6000893  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E602C  token=0x6000894  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E66AC  token=0x6000895  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.VersionConverter
TYPE:  class
TOKEN: 0x200010C
SIZE:  0x10
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
METHODS:
  RVA=0x092E6A00  token=0x6000896  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E6788  token=0x6000897  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092E6724  token=0x6000898  System.Boolean CanConvert(System.Type objectType)
  RVA=0x0350B670  token=0x6000899  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDocumentWrapper
TYPE:  class
TOKEN: 0x200010D
SIZE:  0x30
EXTENDS: Newtonsoft.Json.Converters.XmlNodeWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDocument Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.XmlDocument          _document  // 0x28
PROPERTIES:
  DocumentElement  get=0x092E9160
METHODS:
  RVA=0x092E8A00  token=0x600089A  System.Void .ctor(System.Xml.XmlDocument document)
  RVA=0x092E8C9C  token=0x600089B  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String data)
  RVA=0x092E8F28  token=0x600089C  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  RVA=0x092E8C20  token=0x600089D  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  RVA=0x092E8FA4  token=0x600089E  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  RVA=0x092E8EAC  token=0x600089F  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  RVA=0x092E9020  token=0x60008A0  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  RVA=0x092E90BC  token=0x60008A1  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  RVA=0x092E8E20  token=0x60008A2  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  RVA=0x092E8D18  token=0x60008A3  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  RVA=0x092E8D94  token=0x60008A4  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  RVA=0x092E8AE8  token=0x60008A5  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  RVA=0x092E8B7C  token=0x60008A6  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlElementWrapper
TYPE:  class
TOKEN: 0x200010E
SIZE:  0x30
EXTENDS: Newtonsoft.Json.Converters.XmlNodeWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlElement Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.XmlElement           _element  // 0x28
PROPERTIES:
  IsEmpty  get=0x092E9290
METHODS:
  RVA=0x092E8A00  token=0x60008A8  System.Void .ctor(System.Xml.XmlElement element)
  RVA=0x092E920C  token=0x60008A9  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  RVA=0x092E91EC  token=0x60008AA  System.String GetPrefixOfNamespace(System.String namespaceUri)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDeclarationWrapper
TYPE:  class
TOKEN: 0x200010F
SIZE:  0x30
EXTENDS: Newtonsoft.Json.Converters.XmlNodeWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDeclaration Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.XmlDeclaration       _declaration  // 0x28
PROPERTIES:
  Version  get=0x092E8A60
  Encoding  get=0x092E8A28
  Standalone  get=0x092E8A44
METHODS:
  RVA=0x092E8A00  token=0x60008AC  System.Void .ctor(System.Xml.XmlDeclaration declaration)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDocumentTypeWrapper
TYPE:  class
TOKEN: 0x2000110
SIZE:  0x30
EXTENDS: Newtonsoft.Json.Converters.XmlNodeWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDocumentType Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.XmlDocumentType      _documentType  // 0x28
PROPERTIES:
  Name  get=0x092E8AC4
  System  get=0x092E8A44
  Public  get=0x092E8A28
  InternalSubset  get=0x092E8A7C
  LocalName  get=0x092E8A98
METHODS:
  RVA=0x092E8A00  token=0x60008B0  System.Void .ctor(System.Xml.XmlDocumentType documentType)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlNodeWrapper
TYPE:  class
TOKEN: 0x2000111
SIZE:  0x28
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.XmlNode              _node  // 0x10
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_childNodes  // 0x18
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_attributes  // 0x20
PROPERTIES:
  WrappedNode  get=0x020B7B20
  NodeType  get=0x092EFB48
  LocalName  get=0x092EFB00
  ChildNodes  get=0x092EF7C8
  Attributes  get=0x092EF52C
  HasAttributes  get=0x092EFA80
  ParentNode  get=0x092EFB6C
  Value  get=0x092EFBE8  set=0x092EFC0C
  NamespaceUri  get=0x092EFB24
METHODS:
  RVA=0x0426FEE0  token=0x60008B6  System.Void .ctor(System.Xml.XmlNode node)
  RVA=0x092EF3C0  token=0x60008BB  Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node)
  RVA=0x092EF338  token=0x60008C1  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDocument
TYPE:  interface
TOKEN: 0x2000112
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
PROPERTIES:
  DocumentElement  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60008C3  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text)
  RVA=-1  // abstract  token=0x60008C4  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  RVA=-1  // abstract  token=0x60008C5  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  RVA=-1  // abstract  token=0x60008C6  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  RVA=-1  // abstract  token=0x60008C7  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  RVA=-1  // abstract  token=0x60008C8  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  RVA=-1  // abstract  token=0x60008C9  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  RVA=-1  // abstract  token=0x60008CA  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  RVA=-1  // abstract  token=0x60008CB  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  RVA=-1  // abstract  token=0x60008CC  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  RVA=-1  // abstract  token=0x60008CD  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  RVA=-1  // abstract  token=0x60008CE  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDeclaration
TYPE:  interface
TOKEN: 0x2000113
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
PROPERTIES:
  Version  get=-1  // abstract
  Encoding  get=-1  // abstract
  Standalone  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDocumentType
TYPE:  interface
TOKEN: 0x2000114
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
PROPERTIES:
  Name  get=-1  // abstract
  System  get=-1  // abstract
  Public  get=-1  // abstract
  InternalSubset  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlElement
TYPE:  interface
TOKEN: 0x2000115
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
PROPERTIES:
  IsEmpty  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60008D7  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  RVA=-1  // abstract  token=0x60008D8  System.String GetPrefixOfNamespace(System.String namespaceUri)
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlNode
TYPE:  interface
TOKEN: 0x2000116
FIELDS:
PROPERTIES:
  NodeType  get=-1  // abstract
  LocalName  get=-1  // abstract
  ChildNodes  get=-1  // abstract
  Attributes  get=-1  // abstract
  ParentNode  get=-1  // abstract
  Value  get=-1  // abstract
  NamespaceUri  get=-1  // abstract
  WrappedNode  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60008E0  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDeclarationWrapper
TYPE:  class
TOKEN: 0x2000117
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDeclaration Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.Linq.XDeclaration    <Declaration>k__BackingField  // 0x18
PROPERTIES:
  Declaration  get=0x01041090
  NodeType  get=0x03D55F90
  Version  get=0x092E734C
  Encoding  get=0x06179578
  Standalone  get=0x05F986E4
METHODS:
  RVA=0x092E7320  token=0x60008E4  System.Void .ctor(System.Xml.Linq.XDeclaration declaration)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDocumentTypeWrapper
TYPE:  class
TOKEN: 0x2000118
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDocumentType Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.Linq.XDocumentType   _documentType  // 0x18
PROPERTIES:
  Name  get=0x05F9871C
  System  get=0x05F407B4
  Public  get=0x06177C5C
  InternalSubset  get=0x092E7390
  LocalName  get=0x092E73AC
METHODS:
  RVA=0x092E7368  token=0x60008E9  System.Void .ctor(System.Xml.Linq.XDocumentType documentType)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDocumentWrapper
TYPE:  class
TOKEN: 0x2000119
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Converters.XContainerWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlDocument Newtonsoft.Json.Converters.IXmlNode
FIELDS:
PROPERTIES:
  Document  get=0x092E7DA0
  ChildNodes  get=0x092E7BF4
  HasChildNodes  get=0x092E7DDC
  DocumentElement  get=0x092E7D04
METHODS:
  RVA=0x0426FEE0  token=0x60008F0  System.Void .ctor(System.Xml.Linq.XDocument document)
  RVA=0x092E7660  token=0x60008F3  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text)
  RVA=0x092E7968  token=0x60008F4  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  RVA=0x092E75D0  token=0x60008F5  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  RVA=0x092E79F8  token=0x60008F6  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  RVA=0x092E78D8  token=0x60008F7  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  RVA=0x092E7A88  token=0x60008F8  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  RVA=0x092E7B38  token=0x60008F9  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  RVA=0x092E7838  token=0x60008FA  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  RVA=0x092E76F0  token=0x60008FB  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  RVA=0x092E778C  token=0x60008FC  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  RVA=0x092E7468  token=0x60008FD  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  RVA=0x092E7514  token=0x60008FE  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
  RVA=0x092E73D8  token=0x6000900  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XTextWrapper
TYPE:  class
TOKEN: 0x200011A
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
FIELDS:
PROPERTIES:
  Text  get=0x092E89A4
  Value  get=0x092E89E0
  ParentNode  get=0x092E894C
METHODS:
  RVA=0x0426FEE0  token=0x6000902  System.Void .ctor(System.Xml.Linq.XText text)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XCommentWrapper
TYPE:  class
TOKEN: 0x200011B
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
FIELDS:
PROPERTIES:
  Text  get=0x092E6C34
  Value  get=0x092E6C70
  ParentNode  get=0x092E6BDC
METHODS:
  RVA=0x0426FEE0  token=0x6000906  System.Void .ctor(System.Xml.Linq.XComment text)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XProcessingInstructionWrapper
TYPE:  class
TOKEN: 0x200011C
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
FIELDS:
PROPERTIES:
  ProcessingInstruction  get=0x092E88F0
  LocalName  get=0x092E88D0
  Value  get=0x092E892C
METHODS:
  RVA=0x0426FEE0  token=0x600090A  System.Void .ctor(System.Xml.Linq.XProcessingInstruction processingInstruction)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XContainerWrapper
TYPE:  class
TOKEN: 0x200011D
SIZE:  0x20
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
FIELDS:
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_childNodes  // 0x18
PROPERTIES:
  Container  get=0x092E7260
  ChildNodes  get=0x092E7034
  HasChildNodes  get=0x092E729C
  ParentNode  get=0x092E72C8
METHODS:
  RVA=0x0426FEE0  token=0x600090E  System.Void .ctor(System.Xml.Linq.XContainer container)
  RVA=0x092E6CF8  token=0x6000912  Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node)
  RVA=0x092E6C90  token=0x6000913  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XObjectWrapper
TYPE:  class
TOKEN: 0x200011E
SIZE:  0x18
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private   readonly System.Xml.Linq.XObject         _xmlObject  // 0x10
PROPERTIES:
  WrappedNode  get=0x020B7B20
  NodeType  get=0x092E88B0
  LocalName  get=0x01002730
  ChildNodes  get=0x092E8860
  Attributes  get=0x092E8810
  ParentNode  get=0x01002730
  Value  get=0x01002730
  NamespaceUri  get=0x01002730
METHODS:
  RVA=0x0426FEE0  token=0x6000914  System.Void .ctor(System.Xml.Linq.XObject xmlObject)
  RVA=0x092E87C4  token=0x600091C  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XAttributeWrapper
TYPE:  class
TOKEN: 0x200011F
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Converters.XObjectWrapper
FIELDS:
PROPERTIES:
  Attribute  get=0x092E6AD4
  Value  get=0x092E6BBC
  LocalName  get=0x092E6B10
  NamespaceUri  get=0x092E6B38
  ParentNode  get=0x092E6B64
METHODS:
  RVA=0x0426FEE0  token=0x600091F  System.Void .ctor(System.Xml.Linq.XAttribute attribute)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XElementWrapper
TYPE:  class
TOKEN: 0x2000120
SIZE:  0x28
EXTENDS: Newtonsoft.Json.Converters.XContainerWrapper
IMPLEMENTS: Newtonsoft.Json.Converters.IXmlElement Newtonsoft.Json.Converters.IXmlNode
FIELDS:
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_attributes  // 0x20
PROPERTIES:
  Element  get=0x092E86EC
  Attributes  get=0x092E8184
  Value  get=0x092E87A0
  LocalName  get=0x092E874C
  NamespaceUri  get=0x092E8774
  IsEmpty  get=0x092E8728
METHODS:
  RVA=0x0426FEE0  token=0x6000925  System.Void .ctor(System.Xml.Linq.XElement element)
  RVA=0x092E8104  token=0x6000926  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  RVA=0x092E7E8C  token=0x6000928  System.Boolean HasImplicitNamespaceAttribute(System.String namespaceUri)
  RVA=0x092E7E18  token=0x6000929  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
  RVA=0x092E7E48  token=0x600092D  System.String GetPrefixOfNamespace(System.String namespaceUri)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlNodeConverter
TYPE:  class
TOKEN: 0x2000121
SIZE:  0x20
EXTENDS: Newtonsoft.Json.JsonConverter
FIELDS:
  private   static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>EmptyChildNodes  // static @ 0x0
  private   static  System.String                   TextName  // const
  private   static  System.String                   CommentName  // const
  private   static  System.String                   CDataName  // const
  private   static  System.String                   WhitespaceName  // const
  private   static  System.String                   SignificantWhitespaceName  // const
  private   static  System.String                   DeclarationName  // const
  private   static  System.String                   JsonNamespaceUri  // const
  private           System.String                   <DeserializeRootElementName>k__BackingField  // 0x10
  private           System.Boolean                  <WriteArrayAttribute>k__BackingField  // 0x18
  private           System.Boolean                  <OmitRootObject>k__BackingField  // 0x19
  private           System.Boolean                  <EncodeSpecialCharacters>k__BackingField  // 0x1a
PROPERTIES:
  DeserializeRootElementName  get=0x020B7B20  set=0x0426FEE0
  WriteArrayAttribute  get=0x01002A50  set=0x01002B40
  OmitRootObject  get=0x03D4EF80  set=0x03D4EFB0
  EncodeSpecialCharacters  get=0x03D4EFA0  set=0x03D4EFD0
METHODS:
  RVA=0x092EF200  token=0x6000937  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092EEF04  token=0x6000938  Newtonsoft.Json.Converters.IXmlNode WrapXml(System.Object value)
  RVA=0x092EB864  token=0x6000939  System.Void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  RVA=0x092ECD38  token=0x600093A  System.String ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  RVA=0x092EB210  token=0x600093B  System.String GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  RVA=0x092EB4F0  token=0x600093C  System.Boolean IsArray(Newtonsoft.Json.Converters.IXmlNode node)
  RVA=0x092ECE78  token=0x600093D  System.Void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName)
  RVA=0x092EEFEC  token=0x600093E  System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, System.String elementNames)
  RVA=0x092EF138  token=0x600093F  System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, System.String elementNames)
  RVA=0x092ED614  token=0x6000940  System.Void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName)
  RVA=0x092E95E0  token=0x6000941  System.Boolean AllSameName(Newtonsoft.Json.Converters.IXmlNode node)
  RVA=0x092EC75C  token=0x6000942  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092EAE50  token=0x6000943  System.Void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode)
  RVA=0x092EC450  token=0x6000944  System.Void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.Xml.XmlNamespaceManager manager)
  RVA=0x092E9F20  token=0x6000945  System.Void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String elementName, System.Xml.XmlNamespaceManager manager, System.String elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues)
  RVA=0x092E92B0  token=0x6000946  System.Void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.String attributeName, System.Xml.XmlNamespaceManager manager, System.String attributePrefix)
  RVA=0x092E973C  token=0x6000947  System.String ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader)
  RVA=0x092EBBE4  token=0x6000948  System.Void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager)
  RVA=0x092E9468  token=0x6000949  System.Void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document)
  RVA=0x092EED04  token=0x600094A  System.Boolean ShouldReadInto(Newtonsoft.Json.JsonReader reader)
  RVA=0x092EBE70  token=0x600094B  System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager)
  RVA=0x092EA4D8  token=0x600094C  System.Void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName)
  RVA=0x092E9C44  token=0x600094D  System.Void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode)
  RVA=0x092EA374  token=0x600094E  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName, Newtonsoft.Json.Converters.IXmlDocument document, System.String elementPrefix, System.Xml.XmlNamespaceManager manager)
  RVA=0x092EA7D0  token=0x600094F  System.Void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode)
  RVA=0x092EB6A8  token=0x6000950  System.Boolean IsNamespaceAttribute(System.String attributeName, System.String& prefix)
  RVA=0x092EED70  token=0x6000951  System.Boolean ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c)
  RVA=0x03269DE0  token=0x6000952  System.Boolean CanConvert(System.Type valueType)
  RVA=0x092EB774  token=0x6000953  System.Boolean IsXObject(System.Type valueType)
  RVA=0x092EB7EC  token=0x6000954  System.Boolean IsXmlNode(System.Type valueType)
  RVA=0x0350B670  token=0x6000955  System.Void .ctor()
  RVA=0x03CE2A10  token=0x6000956  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.CommentHandling
TYPE:  sealed struct
TOKEN: 0x20000DE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.CommentHandlingIgnore  // const
  public    static  Newtonsoft.Json.Linq.CommentHandlingLoad  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.DuplicatePropertyNameHandling
TYPE:  sealed struct
TOKEN: 0x20000DF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingReplace  // const
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingIgnore  // const
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingError  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.Extensions
TYPE:  static class
TOKEN: 0x20000E0
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000676  U Value(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value)
  RVA=-1  // generic def  token=0x6000677  U Value(System.Collections.Generic.IEnumerable<T> value)
  RVA=-1  // generic def  token=0x6000678  U Convert(T token)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JArray
TYPE:  class
TOKEN: 0x20000E1
SIZE:  0x58
EXTENDS: Newtonsoft.Json.Linq.JContainer
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken>_values  // 0x50
PROPERTIES:
  ChildrenTokens  get=0x03D4EAF0
  Type  get=0x02102C70
  Item  get=0x092CEDB4
  Item  get=0x092CEDB4  set=0x092CEF08
  IsReadOnly  get=0x0115F4C0
METHODS:
  RVA=0x02697BA0  token=0x600067B  System.Void .ctor()
  RVA=0x092CED14  token=0x600067C  System.Void .ctor(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092CEC78  token=0x600067D  System.Void .ctor(System.Object content)
  RVA=0x092CE86C  token=0x600067E  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092CE9E0  token=0x600067F  Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x092CEBC0  token=0x6000680  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092CE95C  token=0x6000684  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE9B0  token=0x6000685  System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE9BC  token=0x6000686  System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CEB98  token=0x6000687  System.Void RemoveAt(System.Int32 index)
  RVA=0x092CE8F8  token=0x6000688  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator()
  RVA=0x092CE854  token=0x6000689  System.Void Add(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE85C  token=0x600068A  System.Void Clear()
  RVA=0x092CE8DC  token=0x600068B  System.Boolean Contains(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE8F0  token=0x600068C  System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  RVA=0x092CEBAC  token=0x600068E  System.Boolean Remove(Newtonsoft.Json.Linq.JToken item)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JConstructor
TYPE:  class
TOKEN: 0x20000E2
SIZE:  0x60
EXTENDS: Newtonsoft.Json.Linq.JContainer
FIELDS:
  private           System.String                   _name  // 0x50
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken>_values  // 0x58
PROPERTIES:
  ChildrenTokens  get=0x03D4EAA0
  Name  get=0x03D4EAF0
  Type  get=0x03D555E0
  Item  get=0x092CF4C0
METHODS:
  RVA=0x092CEF88  token=0x6000690  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CF408  token=0x6000693  System.Void .ctor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092CF2A8  token=0x6000694  System.Void .ctor(System.String name)
  RVA=0x092CEF18  token=0x6000695  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092CF1D8  token=0x6000696  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092CEFDC  token=0x6000698  Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JContainer
TYPE:  abstract class
TOKEN: 0x20000E3
SIZE:  0x50
EXTENDS: Newtonsoft.Json.Linq.JToken
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.ComponentModel.IBindingList System.Collections.ICollection System.Collections.IList System.Collections.Specialized.INotifyCollectionChanged
FIELDS:
  private           System.ComponentModel.ListChangedEventHandler_listChanged  // 0x30
  private           System.Collections.Specialized.NotifyCollectionChangedEventHandler_collectionChanged  // 0x38
  private           System.Object                   _syncRoot  // 0x40
  private           System.Boolean                  _busy  // 0x48
PROPERTIES:
  ChildrenTokens  get=-1  // abstract
  HasValues  get=0x03609800
  First  get=0x03C79F60
  Last  get=0x02698290
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item  get=0x092CEEFC  set=0x092CEF08
  System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly  get=0x0115F4C0
  System.Collections.IList.IsFixedSize  get=0x0115F4C0
  System.Collections.IList.IsReadOnly  get=0x0115F4C0
  System.Collections.IList.Item  get=0x092CEEFC  set=0x092D0654
  Count  get=0x092D091C
  System.Collections.ICollection.IsSynchronized  get=0x0115F4C0
  System.Collections.ICollection.SyncRoot  get=0x092D050C
EVENTS:
  CollectionChanged  add=add_CollectionChanged  remove=remove_CollectionChanged
METHODS:
  RVA=0x02699D40  token=0x600069C  System.Void .ctor()
  RVA=0x092D068C  token=0x600069D  System.Void .ctor(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x02698B10  token=0x600069E  System.Void CheckReentrancy()
  RVA=0x092D0118  token=0x600069F  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  RVA=0x092D007C  token=0x60006A0  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  RVA=0x092CF60C  token=0x60006A4  Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
  RVA=0x02699C20  token=0x60006A5  System.Boolean IsMultiContent(System.Object content)
  RVA=0x02698A70  token=0x60006A6  Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  RVA=-1  // abstract  token=0x60006A7  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x026988B0  token=0x60006A8  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  RVA=0x092D01B4  token=0x60006A9  System.Void RemoveItemAt(System.Int32 index)
  RVA=0x092D0490  token=0x60006AA  System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D001C  token=0x60006AB  Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index)
  RVA=0x037AE600  token=0x60006AC  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CF664  token=0x60006AD  System.Void ClearItems()
  RVA=0x092D04CC  token=0x60006AE  System.Void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement)
  RVA=0x092CFBC8  token=0x60006AF  System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CFBE4  token=0x60006B0  System.Void CopyItemsTo(System.Array array, System.Int32 arrayIndex)
  RVA=0x037AE960  token=0x60006B1  System.Boolean IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue)
  RVA=0x03603760  token=0x60006B2  System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
  RVA=0x02699010  token=0x60006B3  System.Void Add(System.Object content)
  RVA=0x02698130  token=0x60006B4  System.Boolean TryAdd(System.Object content)
  RVA=0x02697D70  token=0x60006B5  System.Void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token)
  RVA=0x02699090  token=0x60006B6  System.Boolean TryAddInternal(System.Int32 index, System.Object content, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  RVA=0x02699BC0  token=0x60006B7  Newtonsoft.Json.Linq.JToken CreateFromContent(System.Object content)
  RVA=0x092CE85C  token=0x60006B8  System.Void RemoveAll()
  RVA=0x038C3470  token=0x60006B9  System.Void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options)
  RVA=0x026985D0  token=0x60006BA  System.Void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x02698390  token=0x60006BB  Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent)
  RVA=0x092CE9B0  token=0x60006BC  System.Int32 System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE9BC  token=0x60006BD  System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CEB98  token=0x60006BE  System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(System.Int32 index)
  RVA=0x092CE854  token=0x60006C1  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE85C  token=0x60006C2  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear()
  RVA=0x092CE8DC  token=0x60006C3  System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CE8F0  token=0x60006C4  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  RVA=0x092CEBAC  token=0x60006C6  System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092CFF80  token=0x60006C7  Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value)
  RVA=0x092D056C  token=0x60006C8  System.Int32 System.Collections.IList.Add(System.Object value)
  RVA=0x092CE85C  token=0x60006C9  System.Void System.Collections.IList.Clear()
  RVA=0x092D05A0  token=0x60006CA  System.Boolean System.Collections.IList.Contains(System.Object value)
  RVA=0x092D05C8  token=0x60006CB  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  RVA=0x092D05EC  token=0x60006CC  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  RVA=0x092D062C  token=0x60006CF  System.Void System.Collections.IList.Remove(System.Object value)
  RVA=0x092CEB98  token=0x60006D0  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  RVA=0x092CE8F0  token=0x60006D3  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JEnumerable`1
TYPE:  sealed struct
TOKEN: 0x20000E4
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.IEquatable`1
FIELDS:
  public    static readonly Newtonsoft.Json.Linq.JEnumerable<T>Empty  // static @ 0x0
  private   readonly System.Collections.Generic.IEnumerable<T>_enumerable  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60006D7  System.Void .ctor(System.Collections.Generic.IEnumerable<T> enumerable)
  RVA=-1  // not resolved  token=0x60006D8  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x60006D9  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x60006DA  System.Boolean Equals(Newtonsoft.Json.Linq.JEnumerable<T> other)
  RVA=-1  // not resolved  token=0x60006DB  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x60006DC  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x60006DD  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JObject
TYPE:  class
TOKEN: 0x20000E5
SIZE:  0x68
EXTENDS: Newtonsoft.Json.Linq.JContainer
IMPLEMENTS: System.Collections.Generic.IDictionary`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.ComponentModel.INotifyPropertyChanged System.ComponentModel.ICustomTypeDescriptor
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JPropertyKeyedCollection_properties  // 0x50
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x58
  private           System.ComponentModel.PropertyChangingEventHandlerPropertyChanging  // 0x60
PROPERTIES:
  ChildrenTokens  get=0x03D4EAF0
  Type  get=0x01168950
  Item  get=0x032F7BD0
  Item  get=0x032F7BD0  set=0x037AE510
  System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys  get=0x092D145C
  System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values  get=0x092D147C
  System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly  get=0x0115F4C0
EVENTS:
  PropertyChanged  add=add_PropertyChanged  remove=remove_PropertyChanged
METHODS:
  RVA=0x02697DF0  token=0x60006E1  System.Void .ctor()
  RVA=0x092D1944  token=0x60006E2  System.Void .ctor(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092D0EA0  token=0x60006E3  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x026984E0  token=0x60006E4  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  RVA=0x02698B30  token=0x60006E5  System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
  RVA=0x037AE9C0  token=0x60006E6  System.Void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty)
  RVA=0x037AE8F0  token=0x60006E7  System.Void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty)
  RVA=0x092D0C3C  token=0x60006E8  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092D0ECC  token=0x60006EA  System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties()
  RVA=0x02698C10  token=0x60006EB  Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison)
  RVA=0x038C3370  token=0x60006EF  Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x04276080  token=0x60006F0  Newtonsoft.Json.Linq.JObject Parse(System.String json)
  RVA=0x038C3210  token=0x60006F1  Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x02694400  token=0x60006F2  Newtonsoft.Json.Linq.JObject FromObject(System.Object o)
  RVA=0x02693920  token=0x60006F3  Newtonsoft.Json.Linq.JObject FromObject(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer)
  RVA=0x026981B0  token=0x60006F4  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092D0E90  token=0x60006F5  Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName)
  RVA=0x092D0E64  token=0x60006F6  Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName, System.StringComparison comparison)
  RVA=0x037AEAA0  token=0x60006F7  System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D0CAC  token=0x60006F8  System.Boolean ContainsKey(System.String propertyName)
  RVA=0x02697CF0  token=0x60006FA  System.Boolean Remove(System.String propertyName)
  RVA=0x02697340  token=0x60006FB  System.Boolean TryGetValue(System.String propertyName, Newtonsoft.Json.Linq.JToken& value)
  RVA=0x092D0F08  token=0x60006FD  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  RVA=0x092CE85C  token=0x60006FE  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear()
  RVA=0x092D0F9C  token=0x60006FF  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  RVA=0x092D1008  token=0x6000700  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, System.Int32 arrayIndex)
  RVA=0x092D13D4  token=0x6000702  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  RVA=0x092D0D4C  token=0x6000703  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator()
  RVA=0x037AEA50  token=0x6000704  System.Void OnPropertyChanged(System.String propertyName)
  RVA=0x037AE910  token=0x6000705  System.Void OnPropertyChanging(System.String propertyName)
  RVA=0x092D18EC  token=0x6000706  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  RVA=0x092D1554  token=0x6000707  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  RVA=0x092D14C8  token=0x6000708  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  RVA=0x092D1518  token=0x6000709  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  RVA=0x092D18F4  token=0x600070A  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
  RVA=0x092D0DA8  token=0x600070B  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JProperty
TYPE:  class
TOKEN: 0x20000E9
SIZE:  0x60
EXTENDS: Newtonsoft.Json.Linq.JContainer
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JProperty.JPropertyList_content  // 0x50
  private   readonly System.String                   _name  // 0x58
PROPERTIES:
  ChildrenTokens  get=0x03D4EAF0
  Name  get=0x03D4EAA0
  Value  get=0x042711AC  set=0x037AE5A0
  Type  get=0x03D50CD0
METHODS:
  RVA=0x092D2794  token=0x600071E  System.Void .ctor(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092D238C  token=0x600071F  Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index)
  RVA=0x037AE830  token=0x6000720  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D26D4  token=0x6000721  System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D2614  token=0x6000722  System.Void RemoveItemAt(System.Int32 index)
  RVA=0x092D23E8  token=0x6000723  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x02698560  token=0x6000724  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  RVA=0x092D2370  token=0x6000725  System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D2240  token=0x6000726  System.Void ClearItems()
  RVA=0x092D2300  token=0x6000727  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x02699CB0  token=0x6000729  System.Void .ctor(System.String name)
  RVA=0x037AE440  token=0x600072A  System.Void .ctor(System.String name, System.Object content)
  RVA=0x02698320  token=0x600072B  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092D2418  token=0x600072C  Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JPropertyDescriptor
TYPE:  class
TOKEN: 0x20000EC
SIZE:  0x88
EXTENDS: System.ComponentModel.PropertyDescriptor
FIELDS:
PROPERTIES:
  ComponentType  get=0x092D1C48
  IsReadOnly  get=0x0115F4C0
  PropertyType  get=0x092D1C98
  NameHashCode  get=0x01003B50
METHODS:
  RVA=0x092D1C3C  token=0x6000742  System.Void .ctor(System.String name)
  RVA=0x0115F4C0  token=0x6000743  System.Boolean CanResetValue(System.Object component)
  RVA=0x092D1AFC  token=0x6000744  System.Object GetValue(System.Object component)
  RVA=0x0350B670  token=0x6000745  System.Void ResetValue(System.Object component)
  RVA=0x092D1B64  token=0x6000746  System.Void SetValue(System.Object component, System.Object value)
  RVA=0x0115F4C0  token=0x6000747  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JPropertyKeyedCollection
TYPE:  class
TOKEN: 0x20000ED
SIZE:  0x20
EXTENDS: System.Collections.ObjectModel.Collection`1
FIELDS:
  private   static readonly System.Collections.Generic.IEqualityComparer<System.String>Comparer  // static @ 0x0
  private           System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken>_dictionary  // 0x18
PROPERTIES:
  Keys  get=0x092D20CC
METHODS:
  RVA=0x02697E60  token=0x600074C  System.Void .ctor()
  RVA=0x034B7D50  token=0x600074D  System.Void AddKey(System.String key, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D1CE8  token=0x600074E  System.Void ClearItems()
  RVA=0x092D1D44  token=0x600074F  System.Boolean Contains(System.String key)
  RVA=0x034B7DC0  token=0x6000750  System.Void EnsureDictionary()
  RVA=0x034B7CF0  token=0x6000751  System.String GetKeyForItem(Newtonsoft.Json.Linq.JToken item)
  RVA=0x034B7C70  token=0x6000752  System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x092D1E74  token=0x6000753  System.Void RemoveItem(System.Int32 index)
  RVA=0x092D1F0C  token=0x6000754  System.Void RemoveKey(System.String key)
  RVA=0x092D1F5C  token=0x6000755  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  RVA=0x02698CF0  token=0x6000756  System.Boolean TryGetValue(System.String key, Newtonsoft.Json.Linq.JToken& value)
  RVA=0x092D1DF4  token=0x6000758  System.Int32 IndexOfReference(Newtonsoft.Json.Linq.JToken t)
  RVA=0x03D05430  token=0x6000759  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JRaw
TYPE:  class
TOKEN: 0x20000EE
SIZE:  0x40
EXTENDS: Newtonsoft.Json.Linq.JValue
FIELDS:
METHODS:
  RVA=0x092D2BD4  token=0x600075A  System.Void .ctor(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092D2BC4  token=0x600075B  System.Void .ctor(System.Object rawJson)
  RVA=0x092D2894  token=0x600075C  Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader)
  RVA=0x092D2824  token=0x600075D  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JsonCloneSettings
TYPE:  class
TOKEN: 0x20000EF
SIZE:  0x18
FIELDS:
  private   static readonly Newtonsoft.Json.Linq.JsonCloneSettingsSkipCopyAnnotations  // static @ 0x0
  private           System.Boolean                  <CopyAnnotations>k__BackingField  // 0x10
PROPERTIES:
  CopyAnnotations  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x01168960  token=0x600075E  System.Void .ctor()
  RVA=0x092DBBF8  token=0x6000761  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JsonLoadSettings
TYPE:  class
TOKEN: 0x20000F0
SIZE:  0x20
FIELDS:
  private           Newtonsoft.Json.Linq.CommentHandling_commentHandling  // 0x10
  private           Newtonsoft.Json.Linq.LineInfoHandling_lineInfoHandling  // 0x14
  private           Newtonsoft.Json.Linq.DuplicatePropertyNameHandling_duplicatePropertyNameHandling  // 0x18
PROPERTIES:
  CommentHandling  get=0x03D4E340
  LineInfoHandling  get=0x03D50CC0
  DuplicatePropertyNameHandling  get=0x020D1AC0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.JToken
TYPE:  abstract class
TOKEN: 0x20000F1
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable Newtonsoft.Json.IJsonLineInfo System.ICloneable System.Dynamic.IDynamicMetaObjectProvider
FIELDS:
  private           Newtonsoft.Json.Linq.JContainer _parent  // 0x10
  private           Newtonsoft.Json.Linq.JToken     _previous  // 0x18
  private           Newtonsoft.Json.Linq.JToken     _next  // 0x20
  private           System.Object                   _annotations  // 0x28
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BooleanTypes  // static @ 0x0
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]NumberTypes  // static @ 0x8
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BigIntegerTypes  // static @ 0x10
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]StringTypes  // static @ 0x18
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]GuidTypes  // static @ 0x20
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]TimeSpanTypes  // static @ 0x28
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]UriTypes  // static @ 0x30
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]CharTypes  // static @ 0x38
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]DateTimeTypes  // static @ 0x40
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BytesTypes  // static @ 0x48
PROPERTIES:
  Parent  get=0x020B7B20  set=0x0426FEE0
  Root  get=0x03D2ACF0
  Type  get=-1  // abstract
  HasValues  get=-1  // abstract
  Next  get=0x03D4EB40  set=0x04271930
  Previous  get=0x01041090  set=0x022C3A90
  Path  get=0x092D4BFC
  Item  get=0x092D4ABC
  First  get=0x092D4A1C
  Last  get=0x092D4B5C
  Newtonsoft.Json.IJsonLineInfo.LineNumber  get=0x092D3E74
  Newtonsoft.Json.IJsonLineInfo.LinePosition  get=0x092D3EB8
METHODS:
  RVA=-1  // abstract  token=0x6000768  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x0350B670  token=0x6000770  System.Void .ctor()
  RVA=0x092D39BC  token=0x6000774  Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
  RVA=0x092D4470  token=0x6000775  System.Void Remove()
  RVA=0x092D44EC  token=0x6000776  System.Void Replace(Newtonsoft.Json.Linq.JToken value)
  RVA=-1  // abstract  token=0x6000777  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x02697410  token=0x6000778  System.String ToString()
  RVA=0x02697460  token=0x6000779  System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092D3B04  token=0x600077A  Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D3CDC  token=0x600077B  System.String GetType(Newtonsoft.Json.Linq.JToken token)
  RVA=0x092D4978  token=0x600077C  System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable)
  RVA=0x092D6CCC  token=0x600077D  System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D5E40  token=0x600077E  System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D81AC  token=0x600077F  System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D8B80  token=0x6000780  System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D7D50  token=0x6000781  System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D5BA8  token=0x6000782  System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D78E4  token=0x6000783  System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D9304  token=0x6000784  System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D624C  token=0x6000785  System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D6868  token=0x6000786  System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D70FC  token=0x6000787  System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D83CC  token=0x6000788  System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D859C  token=0x6000789  System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D9528  token=0x600078A  System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D74F0  token=0x600078B  System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D7B44  token=0x600078C  System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D6454  token=0x600078D  System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D876C  token=0x600078E  System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D55C4  token=0x600078F  System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D8974  token=0x6000790  System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D59E4  token=0x6000791  System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D76C0  token=0x6000792  System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D51E8  token=0x6000793  System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D4FF4  token=0x6000794  System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D665C  token=0x6000795  System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D72CC  token=0x6000796  System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D8F6C  token=0x6000797  System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D607C  token=0x6000798  System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D7F6C  token=0x6000799  System.String op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D53F4  token=0x600079A  System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D4E24  token=0x600079B  System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D57D0  token=0x600079C  System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D6A38  token=0x600079D  System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D913C  token=0x600079E  System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D8D50  token=0x600079F  System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D6EB0  token=0x60007A0  System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D480C  token=0x60007A1  System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D4640  token=0x60007A2  System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value)
  RVA=0x092D45C8  token=0x60007A3  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x092D4564  token=0x60007A4  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
  RVA=0x092D3A98  token=0x60007A5  Newtonsoft.Json.JsonReader CreateReader()
  RVA=0x02692F80  token=0x60007A6  Newtonsoft.Json.Linq.JToken FromObjectInternal(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer)
  RVA=0x092D3BC4  token=0x60007A7  Newtonsoft.Json.Linq.JToken FromObject(System.Object o)
  RVA=-1  // generic def  token=0x60007A8  T ToObject()
  RVA=0x03973740  token=0x60007A9  System.Object ToObject(System.Type objectType)
  RVA=0x039739E0  token=0x60007AA  System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer)
  RVA=0x092D4424  token=0x60007AB  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader)
  RVA=0x092D40D0  token=0x60007AC  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x092D4084  token=0x60007AD  Newtonsoft.Json.Linq.JToken Parse(System.String json)
  RVA=0x092D3EFC  token=0x60007AE  Newtonsoft.Json.Linq.JToken Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x092D3DD8  token=0x60007AF  Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x02698D70  token=0x60007B0  System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  RVA=0x02698F00  token=0x60007B1  System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  RVA=0x092D3E34  token=0x60007B2  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
  RVA=0x092D3C1C  token=0x60007B5  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
  RVA=0x092D4604  token=0x60007B6  System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter)
  RVA=0x092D3AF8  token=0x60007B7  System.Object System.ICloneable.Clone()
  RVA=0x092D3AF8  token=0x60007B8  Newtonsoft.Json.Linq.JToken DeepClone()
  RVA=0x02698F70  token=0x60007B9  System.Void AddAnnotation(System.Object annotation)
  RVA=-1  // generic def  token=0x60007BA  T Annotation()
  RVA=0x092D3A0C  token=0x60007BB  System.Void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source)
  RVA=0x025634E0  token=0x60007BC  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenReader
TYPE:  class
TOKEN: 0x20000F3
SIZE:  0x98
EXTENDS: Newtonsoft.Json.JsonReader
IMPLEMENTS: Newtonsoft.Json.IJsonLineInfo
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JToken     _root  // 0x78
  private           System.String                   _initialPath  // 0x80
  private           Newtonsoft.Json.Linq.JToken     _parent  // 0x88
  private           Newtonsoft.Json.Linq.JToken     _current  // 0x90
PROPERTIES:
  CurrentToken  get=0x03D4EA90
  Newtonsoft.Json.IJsonLineInfo.LineNumber  get=0x092D2C04
  Newtonsoft.Json.IJsonLineInfo.LinePosition  get=0x092D2C2C
  Path  get=0x092D2CA4
METHODS:
  RVA=0x03973EF0  token=0x60007BF  System.Void .ctor(Newtonsoft.Json.Linq.JToken token)
  RVA=0x036E2930  token=0x60007C0  System.Boolean Read()
  RVA=0x036E2C70  token=0x60007C1  System.Boolean ReadOver(Newtonsoft.Json.Linq.JToken t)
  RVA=0x092D2C54  token=0x60007C2  System.Boolean ReadToEnd()
  RVA=0x036E2DD0  token=0x60007C3  System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c)
  RVA=0x036E2A00  token=0x60007C4  System.Boolean ReadInto(Newtonsoft.Json.Linq.JContainer c)
  RVA=0x036E2D30  token=0x60007C5  System.Boolean SetEnd(Newtonsoft.Json.Linq.JContainer c)
  RVA=0x036E2A80  token=0x60007C6  System.Void SetToken(Newtonsoft.Json.Linq.JToken token)
  RVA=0x092D2C88  token=0x60007C7  System.String SafeToString(System.Object value)
  RVA=0x092D2BDC  token=0x60007C8  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenType
TYPE:  sealed struct
TOKEN: 0x20000F4
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.JTokenType None  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Object  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Array  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Constructor  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Property  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Comment  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Integer  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Float  // const
  public    static  Newtonsoft.Json.Linq.JTokenType String  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Boolean  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Null  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Undefined  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Date  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Raw  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Bytes  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Guid  // const
  public    static  Newtonsoft.Json.Linq.JTokenType Uri  // const
  public    static  Newtonsoft.Json.Linq.JTokenType TimeSpan  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenWriter
TYPE:  class
TOKEN: 0x20000F5
SIZE:  0x80
EXTENDS: Newtonsoft.Json.JsonWriter
FIELDS:
  private           Newtonsoft.Json.Linq.JContainer _token  // 0x60
  private           Newtonsoft.Json.Linq.JContainer _parent  // 0x68
  private           Newtonsoft.Json.Linq.JValue     _value  // 0x70
  private           Newtonsoft.Json.Linq.JToken     _current  // 0x78
PROPERTIES:
  Token  get=0x026938A0
METHODS:
  RVA=0x026938C0  token=0x60007CD  System.Void .ctor()
  RVA=0x025EE630  token=0x60007CE  System.Void Close()
  RVA=0x02697390  token=0x60007CF  System.Void WriteStartObject()
  RVA=0x02697D10  token=0x60007D0  System.Void AddParent(Newtonsoft.Json.Linq.JContainer container)
  RVA=0x037B8D90  token=0x60007D1  System.Void RemoveParent()
  RVA=0x02697B20  token=0x60007D2  System.Void WriteStartArray()
  RVA=0x092D2F18  token=0x60007D3  System.Void WriteStartConstructor(System.String name)
  RVA=0x037B8D80  token=0x60007D4  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  RVA=0x02697C30  token=0x60007D5  System.Void WritePropertyName(System.String name)
  RVA=0x092D2D84  token=0x60007D6  System.Void AddRawValue(System.Object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token)
  RVA=0x0269A9B0  token=0x60007D7  System.Void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token)
  RVA=0x092D3368  token=0x60007D8  System.Void WriteValue(System.Object value)
  RVA=0x092D2E64  token=0x60007D9  System.Void WriteNull()
  RVA=0x092D2F9C  token=0x60007DA  System.Void WriteUndefined()
  RVA=0x092D2E9C  token=0x60007DB  System.Void WriteRaw(System.String json)
  RVA=0x092D2E1C  token=0x60007DC  System.Void WriteComment(System.String text)
  RVA=0x0269A910  token=0x60007DD  System.Void WriteValue(System.String value)
  RVA=0x092D33EC  token=0x60007DE  System.Void WriteValue(System.Int32 value)
  RVA=0x092D30BC  token=0x60007DF  System.Void WriteValue(System.UInt32 value)
  RVA=0x0269AA70  token=0x60007E0  System.Void WriteValue(System.Int64 value)
  RVA=0x092D3258  token=0x60007E1  System.Void WriteValue(System.UInt64 value)
  RVA=0x092D31D0  token=0x60007E2  System.Void WriteValue(System.Single value)
  RVA=0x092D3880  token=0x60007E3  System.Void WriteValue(System.Double value)
  RVA=0x03741100  token=0x60007E4  System.Void WriteValue(System.Boolean value)
  RVA=0x092D372C  token=0x60007E5  System.Void WriteValue(System.Int16 value)
  RVA=0x092D362C  token=0x60007E6  System.Void WriteValue(System.UInt16 value)
  RVA=0x092D37A4  token=0x60007E7  System.Void WriteValue(System.Char value)
  RVA=0x092D3048  token=0x60007E8  System.Void WriteValue(System.Byte value)
  RVA=0x092D2FD4  token=0x60007E9  System.Void WriteValue(System.SByte value)
  RVA=0x092D3130  token=0x60007EA  System.Void WriteValue(System.Decimal value)
  RVA=0x092D3908  token=0x60007EB  System.Void WriteValue(System.DateTime value)
  RVA=0x092D358C  token=0x60007EC  System.Void WriteValue(System.DateTimeOffset value)
  RVA=0x092D3460  token=0x60007ED  System.Void WriteValue(System.Byte[] value)
  RVA=0x092D36A4  token=0x60007EE  System.Void WriteValue(System.TimeSpan value)
  RVA=0x092D34EC  token=0x60007EF  System.Void WriteValue(System.Guid value)
  RVA=0x092D32E0  token=0x60007F0  System.Void WriteValue(System.Uri value)
  RVA=0x0269A1E0  token=0x60007F1  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JValue
TYPE:  class
TOKEN: 0x20000F6
SIZE:  0x40
EXTENDS: Newtonsoft.Json.Linq.JToken
IMPLEMENTS: System.IEquatable`1 System.IFormattable System.IComparable System.IComparable`1 System.IConvertible
FIELDS:
  private           Newtonsoft.Json.Linq.JTokenType _valueType  // 0x30
  private           System.Object                   _value  // 0x38
PROPERTIES:
  HasValues  get=0x0115F4C0
  Type  get=0x03D4ED20
  Value  get=0x03D4E2A0
METHODS:
  RVA=0x0269AB80  token=0x60007F2  System.Void .ctor(System.Object value, Newtonsoft.Json.Linq.JTokenType type)
  RVA=0x092DB950  token=0x60007F3  System.Void .ctor(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x0269AB10  token=0x60007F4  System.Void .ctor(System.Int64 value)
  RVA=0x092DBB28  token=0x60007F5  System.Void .ctor(System.Decimal value)
  RVA=0x092DB7D0  token=0x60007F6  System.Void .ctor(System.UInt64 value)
  RVA=0x092DB830  token=0x60007F7  System.Void .ctor(System.Double value)
  RVA=0x092DBA00  token=0x60007F8  System.Void .ctor(System.Single value)
  RVA=0x092DB890  token=0x60007F9  System.Void .ctor(System.DateTime value)
  RVA=0x092DBB94  token=0x60007FA  System.Void .ctor(System.DateTimeOffset value)
  RVA=0x037411A0  token=0x60007FB  System.Void .ctor(System.Boolean value)
  RVA=0x042711C8  token=0x60007FC  System.Void .ctor(System.String value)
  RVA=0x092DBAC4  token=0x60007FD  System.Void .ctor(System.Guid value)
  RVA=0x092DBA60  token=0x60007FE  System.Void .ctor(System.Uri value)
  RVA=0x092DB8F0  token=0x60007FF  System.Void .ctor(System.TimeSpan value)
  RVA=0x02699D80  token=0x6000800  System.Void .ctor(System.Object value)
  RVA=0x092D9BB8  token=0x6000802  System.Int32 CompareBigInteger(System.Numerics.BigInteger i1, System.Object i2)
  RVA=0x092D9EF0  token=0x6000803  System.Int32 Compare(Newtonsoft.Json.Linq.JTokenType valueType, System.Object objA, System.Object objB)
  RVA=0x092D9DE4  token=0x6000804  System.Int32 CompareFloat(System.Object objA, System.Object objB)
  RVA=0x092DAA5C  token=0x6000805  System.Boolean Operation(System.Linq.Expressions.ExpressionType operation, System.Object objA, System.Object objB, System.Object& result)
  RVA=0x092D9B48  token=0x6000806  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  RVA=0x092DA7EC  token=0x6000807  Newtonsoft.Json.Linq.JValue CreateComment(System.String value)
  RVA=0x092DA850  token=0x6000808  Newtonsoft.Json.Linq.JValue CreateNull()
  RVA=0x092DA8A8  token=0x6000809  Newtonsoft.Json.Linq.JValue CreateUndefined()
  RVA=0x02699DC0  token=0x600080A  Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, System.Object value)
  RVA=0x038BA8D0  token=0x600080B  Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current)
  RVA=0x02697EF0  token=0x600080E  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  RVA=0x092DB788  token=0x600080F  System.Boolean ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2)
  RVA=0x092DA95C  token=0x6000810  System.Boolean Equals(Newtonsoft.Json.Linq.JValue other)
  RVA=0x092DA900  token=0x6000811  System.Boolean Equals(System.Object obj)
  RVA=0x092DA978  token=0x6000812  System.Int32 GetHashCode()
  RVA=0x03D1E910  token=0x6000813  System.String ToString()
  RVA=0x092DB778  token=0x6000814  System.String ToString(System.IFormatProvider formatProvider)
  RVA=0x092DB6CC  token=0x6000815  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x092DA9A0  token=0x6000816  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
  RVA=0x092DB1A4  token=0x6000817  System.Int32 System.IComparable.CompareTo(System.Object obj)
  RVA=0x092D9EBC  token=0x6000818  System.Int32 CompareTo(Newtonsoft.Json.Linq.JValue obj)
  RVA=0x092DB228  token=0x6000819  System.TypeCode System.IConvertible.GetTypeCode()
  RVA=0x092DB288  token=0x600081A  System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider)
  RVA=0x092DB320  token=0x600081B  System.Char System.IConvertible.ToChar(System.IFormatProvider provider)
  RVA=0x092DB548  token=0x600081C  System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider)
  RVA=0x092DB2D4  token=0x600081D  System.Byte System.IConvertible.ToByte(System.IFormatProvider provider)
  RVA=0x092DB464  token=0x600081E  System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider)
  RVA=0x092DB5E8  token=0x600081F  System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider)
  RVA=0x092DB4B0  token=0x6000820  System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider)
  RVA=0x092DB634  token=0x6000821  System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider)
  RVA=0x092DB4FC  token=0x6000822  System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider)
  RVA=0x092DB680  token=0x6000823  System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider)
  RVA=0x092DB594  token=0x6000824  System.Single System.IConvertible.ToSingle(System.IFormatProvider provider)
  RVA=0x092DB418  token=0x6000825  System.Double System.IConvertible.ToDouble(System.IFormatProvider provider)
  RVA=0x092DB3B8  token=0x6000826  System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider)
  RVA=0x092DB36C  token=0x6000827  System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider)
  RVA=0x092DB5E0  token=0x6000828  System.Object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider)
END_CLASS

CLASS: Newtonsoft.Json.Linq.LineInfoHandling
TYPE:  sealed struct
TOKEN: 0x20000F8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.LineInfoHandlingIgnore  // const
  public    static  Newtonsoft.Json.Linq.LineInfoHandlingLoad  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.CachedAttributeGetter`1
TYPE:  static class
TOKEN: 0x200009C
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T>TypeAttributeCache  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000422  T GetAttribute(System.Object type)
  RVA=-1  // not resolved  token=0x6000423  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.CamelCaseNamingStrategy
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Serialization.NamingStrategy
FIELDS:
METHODS:
  RVA=0x03D714A0  token=0x6000424  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  RVA=0x03D71490  token=0x6000425  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  RVA=0x0350B670  token=0x6000426  System.Void .ctor()
  RVA=0x092B976C  token=0x6000427  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultContractResolver
TYPE:  class
TOKEN: 0x200009E
SIZE:  0x38
IMPLEMENTS: Newtonsoft.Json.Serialization.IContractResolver
FIELDS:
  private   static readonly Newtonsoft.Json.Serialization.IContractResolver_instance  // static @ 0x0
  private   static readonly System.String[]                 BlacklistedTypeNames  // static @ 0x8
  private   static readonly Newtonsoft.Json.JsonConverter[] BuiltInConverters  // static @ 0x10
  private   readonly Newtonsoft.Json.DefaultJsonNameTable_nameTable  // 0x10
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Serialization.JsonContract>_contractCache  // 0x18
  private           System.Reflection.BindingFlags  <DefaultMembersSearchFlags>k__BackingField  // 0x20
  private           System.Boolean                  <SerializeCompilerGeneratedMembers>k__BackingField  // 0x24
  private           System.Boolean                  <IgnoreSerializableInterface>k__BackingField  // 0x25
  private           System.Boolean                  <IgnoreSerializableAttribute>k__BackingField  // 0x26
  private           System.Boolean                  <IgnoreIsSpecifiedMembers>k__BackingField  // 0x27
  private           System.Boolean                  <IgnoreShouldSerializeMembers>k__BackingField  // 0x28
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategy>k__BackingField  // 0x30
PROPERTIES:
  Instance  get=0x092BFF8C
  DefaultMembersSearchFlags  get=0x01003B50  set=0x01003B60
  SerializeCompilerGeneratedMembers  get=0x03D4F090
  IgnoreSerializableInterface  get=0x03D4F130
  IgnoreSerializableAttribute  get=0x03D4F140  set=0x03D4F160
  IgnoreIsSpecifiedMembers  get=0x03D714B0
  IgnoreShouldSerializeMembers  get=0x03D4ED50
  NamingStrategy  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x03702E30  token=0x6000433  System.Void .ctor()
  RVA=0x027BE670  token=0x6000434  Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type)
  RVA=0x024789A0  token=0x6000435  System.Boolean FilterMembers(System.Reflection.MemberInfo member)
  RVA=0x025E2100  token=0x6000436  System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType)
  RVA=0x092BFE28  token=0x6000437  System.Boolean ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo)
  RVA=0x0283DAA0  token=0x6000438  Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType)
  RVA=0x092BFEE4  token=0x6000439  System.Void ThrowUnableToSerializeError(System.Object o, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0283DF90  token=0x600043A  System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type)
  RVA=0x092BF5F8  token=0x600043B  System.Void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member)
  RVA=0x0283D870  token=0x600043C  System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType)
  RVA=0x034F8430  token=0x600043D  System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
  RVA=0x03D1BC00  token=0x600043E  System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType)
  RVA=0x034F8300  token=0x600043F  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
  RVA=0x034F85B0  token=0x6000440  Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, System.String name, System.Type type)
  RVA=0x034F8660  token=0x6000441  Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo)
  RVA=0x02475BE0  token=0x6000442  Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType)
  RVA=0x02475E40  token=0x6000443  System.Func<System.Object> GetDefaultCreator(System.Type createdType)
  RVA=0x02475960  token=0x6000444  System.Void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract)
  RVA=0x02475C30  token=0x6000445  System.Void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t)
  RVA=0x0253F8D0  token=0x6000446  System.Void GetCallbackMethodsForType(System.Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError)
  RVA=0x024782C0  token=0x6000447  System.Boolean IsConcurrentOrObservableCollection(System.Type t)
  RVA=0x02478080  token=0x6000448  System.Boolean ShouldSkipDeserialized(System.Type t)
  RVA=0x024781A0  token=0x6000449  System.Boolean ShouldSkipSerializing(System.Type t)
  RVA=0x0283F850  token=0x600044A  System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type)
  RVA=0x0308E0C0  token=0x600044B  Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType)
  RVA=0x0308D520  token=0x600044C  Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType)
  RVA=0x03439DA0  token=0x600044D  Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType)
  RVA=0x03CF60E0  token=0x600044E  Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType)
  RVA=0x092BF324  token=0x600044F  Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType)
  RVA=0x092BF134  token=0x6000450  Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType)
  RVA=0x03439CB0  token=0x6000451  Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType)
  RVA=0x024772C0  token=0x6000452  Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType)
  RVA=0x02476C30  token=0x6000453  System.Boolean IsJsonPrimitiveType(System.Type t)
  RVA=0x033576D0  token=0x6000454  System.Boolean IsIConvertible(System.Type t)
  RVA=0x02475590  token=0x6000455  System.Boolean CanConvertToString(System.Type type)
  RVA=0x02540F30  token=0x6000456  System.Boolean IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, System.Type& prevAttributeType)
  RVA=0x092BF500  token=0x6000457  System.String GetClrTypeFullName(System.Type type)
  RVA=0x024E60C0  token=0x6000458  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization)
  RVA=0x020B7B20  token=0x6000459  Newtonsoft.Json.DefaultJsonNameTable GetNameTable()
  RVA=0x024E5770  token=0x600045A  Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member)
  RVA=0x024E5330  token=0x600045B  Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization)
  RVA=0x024E6AB0  token=0x600045C  System.Void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, System.Object attributeProvider, System.String name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, System.Boolean& allowNonPublicAccess)
  RVA=0x024E5960  token=0x600045D  System.Predicate<System.Object> CreateShouldSerializeTest(System.Reflection.MemberInfo member)
  RVA=0x024E4A20  token=0x600045E  System.Void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, System.Boolean allowNonPublicAccess)
  RVA=0x024E71A0  token=0x600045F  System.String ResolvePropertyName(System.String propertyName)
  RVA=0x092BF5DC  token=0x6000460  System.String ResolveExtensionDataName(System.String extensionDataName)
  RVA=0x039B9B50  token=0x6000461  System.String ResolveDictionaryKey(System.String dictionaryKey)
  RVA=0x092BF5D4  token=0x6000462  System.String GetResolvedPropertyName(System.String propertyName)
  RVA=0x037029F0  token=0x6000463  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultNamingStrategy
TYPE:  class
TOKEN: 0x20000AA
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Serialization.NamingStrategy
FIELDS:
METHODS:
  RVA=0x03D51810  token=0x6000485  System.String ResolvePropertyName(System.String name)
  RVA=0x0350B670  token=0x6000486  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultReferenceResolver
TYPE:  class
TOKEN: 0x20000AB
SIZE:  0x18
IMPLEMENTS: Newtonsoft.Json.Serialization.IReferenceResolver
FIELDS:
  private           System.Int32                    _referenceCount  // 0x10
METHODS:
  RVA=0x092C4774  token=0x6000487  Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(System.Object context)
  RVA=0x092C499C  token=0x6000488  System.Object ResolveReference(System.Object context, System.String reference)
  RVA=0x092C4840  token=0x6000489  System.String GetReference(System.Object context, System.Object value)
  RVA=0x092C46F4  token=0x600048A  System.Void AddReference(System.Object context, System.String reference, System.Object value)
  RVA=0x092C4920  token=0x600048B  System.Boolean IsReferenced(System.Object context, System.Object value)
  RVA=0x0350B670  token=0x600048C  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultSerializationBinder
TYPE:  class
TOKEN: 0x20000AC
SIZE:  0x18
EXTENDS: System.Runtime.Serialization.SerializationBinder
IMPLEMENTS: Newtonsoft.Json.Serialization.ISerializationBinder
FIELDS:
  private   static readonly Newtonsoft.Json.Serialization.DefaultSerializationBinderInstance  // static @ 0x0
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type>_typeCache  // 0x10
METHODS:
  RVA=0x03B38AE0  token=0x600048D  System.Void .ctor()
  RVA=0x02679EE0  token=0x600048E  System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey)
  RVA=0x092C4A90  token=0x600048F  System.Type GetGenericTypeFromTypeName(System.String typeName, System.Reflection.Assembly assembly)
  RVA=0x027BCF80  token=0x6000490  System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey)
  RVA=0x027BCEC0  token=0x6000491  System.Type BindToType(System.String assemblyName, System.String typeName)
  RVA=0x092C4A1C  token=0x6000492  System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName)
  RVA=0x03B38A70  token=0x6000493  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ErrorContext
TYPE:  class
TOKEN: 0x20000AD
SIZE:  0x40
FIELDS:
  private           System.Boolean                  <Traced>k__BackingField  // 0x10
  private   readonly System.Exception                <Error>k__BackingField  // 0x18
  private   readonly System.Object                   <OriginalObject>k__BackingField  // 0x20
  private   readonly System.Object                   <Member>k__BackingField  // 0x28
  private   readonly System.String                   <Path>k__BackingField  // 0x30
  private           System.Boolean                  <Handled>k__BackingField  // 0x38
PROPERTIES:
  Traced  get=0x011797F0  set=0x03D4E960
  Error  get=0x01041090
  Handled  get=0x03D4F190
METHODS:
  RVA=0x092C4CA0  token=0x6000494  System.Void .ctor(System.Object originalObject, System.Object member, System.String path, System.Exception error)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ErrorEventArgs
TYPE:  class
TOKEN: 0x20000AE
SIZE:  0x20
EXTENDS: System.EventArgs
FIELDS:
  private   readonly System.Object                   <CurrentObject>k__BackingField  // 0x10
  private   readonly Newtonsoft.Json.Serialization.ErrorContext<ErrorContext>k__BackingField  // 0x18
METHODS:
  RVA=0x092C4CE8  token=0x6000499  System.Void .ctor(System.Object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IAttributeProvider
TYPE:  interface
TOKEN: 0x20000AF
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IContractResolver
TYPE:  interface
TOKEN: 0x20000B0
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600049A  Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IReferenceResolver
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600049B  System.Object ResolveReference(System.Object context, System.String reference)
  RVA=-1  // abstract  token=0x600049C  System.String GetReference(System.Object context, System.Object value)
  RVA=-1  // abstract  token=0x600049D  System.Boolean IsReferenced(System.Object context, System.Object value)
  RVA=-1  // abstract  token=0x600049E  System.Void AddReference(System.Object context, System.String reference, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ISerializationBinder
TYPE:  interface
TOKEN: 0x20000B2
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600049F  System.Type BindToType(System.String assemblyName, System.String typeName)
  RVA=-1  // abstract  token=0x60004A0  System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ITraceWriter
TYPE:  interface
TOKEN: 0x20000B3
FIELDS:
PROPERTIES:
  LevelFilter  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60004A2  System.Void Trace(System.Diagnostics.TraceLevel level, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IValueProvider
TYPE:  interface
TOKEN: 0x20000B4
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60004A3  System.Void SetValue(System.Object target, System.Object value)
  RVA=-1  // abstract  token=0x60004A4  System.Object GetValue(System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonArrayContract
TYPE:  class
TOKEN: 0x20000B5
SIZE:  0x118
EXTENDS: Newtonsoft.Json.Serialization.JsonContainerContract
FIELDS:
  private   readonly System.Type                     <CollectionItemType>k__BackingField  // 0xc0
  private   readonly System.Boolean                  <IsMultidimensionalArray>k__BackingField  // 0xc8
  private   readonly System.Type                     _genericCollectionDefinitionType  // 0xd0
  private           System.Type                     _genericWrapperType  // 0xd8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_genericWrapperCreator  // 0xe0
  private           System.Func<System.Object>      _genericTemporaryCollectionCreator  // 0xe8
  private   readonly System.Boolean                  <IsArray>k__BackingField  // 0xf0
  private   readonly System.Boolean                  <ShouldCreateWrapper>k__BackingField  // 0xf1
  private           System.Boolean                  <CanDeserialize>k__BackingField  // 0xf2
  private   readonly System.Reflection.ConstructorInfo_parameterizedConstructor  // 0xf8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x100
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x108
  private           System.Boolean                  <HasParameterizedCreator>k__BackingField  // 0x110
PROPERTIES:
  CollectionItemType  get=0x03D50E60
  IsMultidimensionalArray  get=0x03D519D0
  IsArray  get=0x03D57D50
  ShouldCreateWrapper  get=0x03D57BD0
  CanDeserialize  get=0x03D714C0  set=0x03D714D0
  ParameterizedCreator  get=0x092C4F54
  OverrideCreator  get=0x03D56D30  set=0x092C500C
  HasParameterizedCreator  get=0x03D57AB0  set=0x03D5B8E0
  HasParameterizedCreatorInternal  get=0x0247A150
METHODS:
  RVA=0x0308D650  token=0x60004B1  System.Void .ctor(System.Type underlyingType)
  RVA=0x0308F160  token=0x60004B2  Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(System.Object list)
  RVA=0x024E7E80  token=0x60004B3  System.Collections.IList CreateTemporaryCollection()
  RVA=0x092C4E7C  token=0x60004B4  System.Void StoreFSharpListCreatorIfNecessary(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContainerContract
TYPE:  class
TOKEN: 0x20000B6
SIZE:  0xC0
EXTENDS: Newtonsoft.Json.Serialization.JsonContract
FIELDS:
  private           Newtonsoft.Json.Serialization.JsonContract_itemContract  // 0x90
  private           Newtonsoft.Json.Serialization.JsonContract_finalItemContract  // 0x98
  private           Newtonsoft.Json.JsonConverter   <ItemConverter>k__BackingField  // 0xa0
  private           System.Nullable<System.Boolean> <ItemIsReference>k__BackingField  // 0xa8
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ItemReferenceLoopHandling>k__BackingField  // 0xac
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><ItemTypeNameHandling>k__BackingField  // 0xb4
PROPERTIES:
  ItemContract  get=0x03D4EA90  set=0x02474FC0
  FinalItemContract  get=0x011AC510
  ItemConverter  get=0x03D4EA80  set=0x04270264
  ItemIsReference  get=0x03D714E0  set=0x03D71510
  ItemReferenceLoopHandling  get=0x03D714F0  set=0x03D71520
  ItemTypeNameHandling  get=0x03D71500  set=0x03D71530
METHODS:
  RVA=0x02475860  token=0x60004C0  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContractType
TYPE:  sealed struct
TOKEN: 0x20000B7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeNone  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeObject  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeArray  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypePrimitive  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeString  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeDictionary  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeDynamic  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeSerializable  // const
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeLinq  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SerializationCallback
TYPE:  sealed class
TOKEN: 0x20000B8
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x036E5EB0  token=0x60004C1  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x029CE1E0  token=0x60004C2  System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SerializationErrorCallback
TYPE:  sealed class
TOKEN: 0x20000B9
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x080B2174  token=0x60004C3  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0500800C  token=0x60004C4  System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ExtensionDataSetter
TYPE:  sealed class
TOKEN: 0x20000BA
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x092C4D54  token=0x60004C5  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x011360D0  token=0x60004C6  System.Void Invoke(System.Object o, System.String key, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ExtensionDataGetter
TYPE:  sealed class
TOKEN: 0x20000BB
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06E65E38  token=0x60004C7  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0102B410  token=0x60004C8  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(System.Object o)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContract
TYPE:  abstract class
TOKEN: 0x20000BC
SIZE:  0x90
FIELDS:
  private           System.Boolean                  IsNullable  // 0x10
  private           System.Boolean                  IsConvertable  // 0x11
  private           System.Boolean                  IsEnum  // 0x12
  private           System.Type                     NonNullableUnderlyingType  // 0x18
  private           Newtonsoft.Json.ReadType        InternalReadType  // 0x20
  private           Newtonsoft.Json.Serialization.JsonContractTypeContractType  // 0x24
  private           System.Boolean                  IsReadOnlyOrFixedSize  // 0x28
  private           System.Boolean                  IsSealed  // 0x29
  private           System.Boolean                  IsInstantiable  // 0x2a
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onDeserializedCallbacks  // 0x30
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onDeserializingCallbacks  // 0x38
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onSerializedCallbacks  // 0x40
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onSerializingCallbacks  // 0x48
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>_onErrorCallbacks  // 0x50
  private           System.Type                     _createdType  // 0x58
  private   readonly System.Type                     <UnderlyingType>k__BackingField  // 0x60
  private           System.Nullable<System.Boolean> <IsReference>k__BackingField  // 0x68
  private           Newtonsoft.Json.JsonConverter   <Converter>k__BackingField  // 0x70
  private           Newtonsoft.Json.JsonConverter   <InternalConverter>k__BackingField  // 0x78
  private           System.Func<System.Object>      <DefaultCreator>k__BackingField  // 0x80
  private           System.Boolean                  <DefaultCreatorNonPublic>k__BackingField  // 0x88
PROPERTIES:
  UnderlyingType  get=0x03D4EB00
  CreatedType  get=0x03D4EAA0  set=0x02476B80
  IsReference  get=0x03D71540  set=0x03D71550
  Converter  get=0x03D4EB30  set=0x0519C3C8
  InternalConverter  get=0x03D4EB20  set=0x051DFCA4
  OnDeserializedCallbacks  get=0x03152300
  OnDeserializingCallbacks  get=0x092C5234
  OnSerializedCallbacks  get=0x092C52B8
  OnSerializingCallbacks  get=0x03152270
  OnErrorCallbacks  get=0x031527C0
  DefaultCreator  get=0x03D4EAE0  set=0x051DFC94
  DefaultCreatorNonPublic  get=0x03D51D50  set=0x03D56D40
METHODS:
  RVA=0x024776F0  token=0x60004DB  System.Void .ctor(System.Type underlyingType)
  RVA=0x027B9260  token=0x60004DC  System.Void InvokeOnSerializing(System.Object o, System.Runtime.Serialization.StreamingContext context)
  RVA=0x027B9420  token=0x60004DD  System.Void InvokeOnSerialized(System.Object o, System.Runtime.Serialization.StreamingContext context)
  RVA=0x02B39290  token=0x60004DE  System.Void InvokeOnDeserializing(System.Object o, System.Runtime.Serialization.StreamingContext context)
  RVA=0x024E9D40  token=0x60004DF  System.Void InvokeOnDeserialized(System.Object o, System.Runtime.Serialization.StreamingContext context)
  RVA=0x092C50D4  token=0x60004E0  System.Void InvokeOnError(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext)
  RVA=0x036E5E00  token=0x60004E1  Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo)
  RVA=0x092C5034  token=0x60004E2  Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonDictionaryContract
TYPE:  class
TOKEN: 0x20000BF
SIZE:  0x128
EXTENDS: Newtonsoft.Json.Serialization.JsonContainerContract
FIELDS:
  private           System.Func<System.String,System.String><DictionaryKeyResolver>k__BackingField  // 0xc0
  private   readonly System.Type                     <DictionaryKeyType>k__BackingField  // 0xc8
  private   readonly System.Type                     <DictionaryValueType>k__BackingField  // 0xd0
  private           Newtonsoft.Json.Serialization.JsonContract<KeyContract>k__BackingField  // 0xd8
  private   readonly System.Type                     _genericCollectionDefinitionType  // 0xe0
  private           System.Type                     _genericWrapperType  // 0xe8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_genericWrapperCreator  // 0xf0
  private           System.Func<System.Object>      _genericTemporaryDictionaryCreator  // 0xf8
  private   readonly System.Boolean                  <ShouldCreateWrapper>k__BackingField  // 0x100
  private   readonly System.Reflection.ConstructorInfo_parameterizedConstructor  // 0x108
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x110
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x118
  private           System.Boolean                  <HasParameterizedCreator>k__BackingField  // 0x120
PROPERTIES:
  DictionaryKeyResolver  get=0x03D50E60  set=0x058B426C
  DictionaryKeyType  get=0x03D4E7C0
  DictionaryValueType  get=0x03D50050
  KeyContract  get=0x03D4E7B0  set=0x05142FC4
  ShouldCreateWrapper  get=0x03D56750
  ParameterizedCreator  get=0x092C5758
  OverrideCreator  get=0x03D56CF0  set=0x04275CF4
  HasParameterizedCreator  get=0x03D57B30  set=0x03D5A200
  HasParameterizedCreatorInternal  get=0x0308EDB0
METHODS:
  RVA=0x0308E2E0  token=0x60004F4  System.Void .ctor(System.Type underlyingType)
  RVA=0x092C5518  token=0x60004F5  Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(System.Object dictionary)
  RVA=0x092C533C  token=0x60004F6  System.Collections.IDictionary CreateTemporaryDictionary()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonDynamicContract
TYPE:  class
TOKEN: 0x20000C0
SIZE:  0xE0
EXTENDS: Newtonsoft.Json.Serialization.JsonContainerContract
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonPropertyCollection<Properties>k__BackingField  // 0xc0
  private           System.Func<System.String,System.String><PropertyNameResolver>k__BackingField  // 0xc8
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>>>_callSiteGetters  // 0xd0
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>>>_callSiteSetters  // 0xd8
PROPERTIES:
  Properties  get=0x03D50E60
  PropertyNameResolver  get=0x03D4E7C0  set=0x058B4280
METHODS:
  RVA=0x092C5810  token=0x60004FA  System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(System.String name)
  RVA=0x092C58E8  token=0x60004FB  System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(System.String name)
  RVA=0x092C5C18  token=0x60004FC  System.Void .ctor(System.Type underlyingType)
  RVA=0x092C59C0  token=0x60004FD  System.Boolean TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object& value)
  RVA=0x092C5AF4  token=0x60004FE  System.Boolean TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonFormatterConverter
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x28
IMPLEMENTS: System.Runtime.Serialization.IFormatterConverter
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader_reader  // 0x10
  private   readonly Newtonsoft.Json.Serialization.JsonISerializableContract_contract  // 0x18
  private   readonly Newtonsoft.Json.Serialization.JsonProperty_member  // 0x20
METHODS:
  RVA=0x092C6094  token=0x60004FF  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member)
  RVA=-1  // generic def  token=0x6000500  T GetTokenValue(System.Object value)
  RVA=0x092C5DE8  token=0x6000501  System.Object Convert(System.Object value, System.Type type)
  RVA=0x092C5F2C  token=0x6000502  System.Boolean ToBoolean(System.Object value)
  RVA=0x092C5F74  token=0x6000503  System.Int32 ToInt32(System.Object value)
  RVA=0x092C5FBC  token=0x6000504  System.Int64 ToInt64(System.Object value)
  RVA=0x092C6004  token=0x6000505  System.Single ToSingle(System.Object value)
  RVA=0x092C604C  token=0x6000506  System.String ToString(System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonISerializableContract
TYPE:  class
TOKEN: 0x20000C2
SIZE:  0xC8
EXTENDS: Newtonsoft.Json.Serialization.JsonContainerContract
FIELDS:
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object><ISerializableCreator>k__BackingField  // 0xc0
PROPERTIES:
  ISerializableCreator  get=0x03D50E60  set=0x058B426C
METHODS:
  RVA=0x092C61BC  token=0x6000509  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonLinqContract
TYPE:  class
TOKEN: 0x20000C3
SIZE:  0x90
EXTENDS: Newtonsoft.Json.Serialization.JsonContract
FIELDS:
METHODS:
  RVA=0x042770F8  token=0x600050A  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonObjectContract
TYPE:  class
TOKEN: 0x20000C4
SIZE:  0x128
EXTENDS: Newtonsoft.Json.Serialization.JsonContainerContract
FIELDS:
  private           Newtonsoft.Json.MemberSerialization<MemberSerialization>k__BackingField  // 0xc0
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling><MissingMemberHandling>k__BackingField  // 0xc4
  private           System.Nullable<Newtonsoft.Json.Required><ItemRequired>k__BackingField  // 0xcc
  private           System.Nullable<Newtonsoft.Json.NullValueHandling><ItemNullValueHandling>k__BackingField  // 0xd4
  private   readonly Newtonsoft.Json.Serialization.JsonPropertyCollection<Properties>k__BackingField  // 0xe0
  private           Newtonsoft.Json.Serialization.ExtensionDataSetter<ExtensionDataSetter>k__BackingField  // 0xe8
  private           Newtonsoft.Json.Serialization.ExtensionDataGetter<ExtensionDataGetter>k__BackingField  // 0xf0
  private           System.Func<System.String,System.String><ExtensionDataNameResolver>k__BackingField  // 0xf8
  private           System.Boolean                  ExtensionDataIsJToken  // 0x100
  private           System.Nullable<System.Boolean> _hasRequiredOrDefaultValueProperties  // 0x101
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x108
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x110
  private           Newtonsoft.Json.Serialization.JsonPropertyCollection_creatorParameters  // 0x118
  private           System.Type                     _extensionDataValueType  // 0x120
PROPERTIES:
  MemberSerialization  get=0x03D57EF0  set=0x03D57F70
  MissingMemberHandling  get=0x03D71580  set=0x03D69470
  ItemRequired  get=0x03D71570  set=0x03D715A0
  ItemNullValueHandling  get=0x03D71560  set=0x03D71590
  Properties  get=0x03D51140
  CreatorParameters  get=0x03CF5EA0
  OverrideCreator  get=0x03D56D30  set=0x0589D950
  ParameterizedCreator  get=0x03D56CF0  set=0x04275CF4
  ExtensionDataSetter  get=0x03D50EA0  set=0x056A2B64
  ExtensionDataGetter  get=0x03D51950  set=0x058B408C
  ExtensionDataValueType  set=0x092C62D8
  ExtensionDataNameResolver  get=0x03D50160  set=0x0554D2E0
  HasRequiredOrDefaultValueProperties  get=0x02D73000
METHODS:
  RVA=0x024754F0  token=0x6000521  System.Void .ctor(System.Type underlyingType)
  RVA=0x092C61DC  token=0x6000522  System.Object GetUninitializedObject()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonPrimitiveContract
TYPE:  class
TOKEN: 0x20000C5
SIZE:  0x98
EXTENDS: Newtonsoft.Json.Serialization.JsonContract
FIELDS:
  private           Newtonsoft.Json.Utilities.PrimitiveTypeCode<TypeCode>k__BackingField  // 0x90
  private   static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType>ReadTypeMap  // static @ 0x0
PROPERTIES:
  TypeCode  get=0x03D4FB60  set=0x03D4FB70
METHODS:
  RVA=0x03439E20  token=0x6000525  System.Void .ctor(System.Type underlyingType)
  RVA=0x03875BF0  token=0x6000526  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonProperty
TYPE:  class
TOKEN: 0x20000C6
SIZE:  0xF0
FIELDS:
  private           System.Nullable<Newtonsoft.Json.Required>_required  // 0x10
  private           System.Boolean                  _hasExplicitDefaultValue  // 0x18
  private           System.Object                   _defaultValue  // 0x20
  private           System.Boolean                  _hasGeneratedDefaultValue  // 0x28
  private           System.String                   _propertyName  // 0x30
  private           System.Boolean                  _skipPropertyNameEscape  // 0x38
  private           System.Type                     _propertyType  // 0x40
  private           Newtonsoft.Json.Serialization.JsonContract<PropertyContract>k__BackingField  // 0x48
  private           System.Type                     <DeclaringType>k__BackingField  // 0x50
  private           System.Nullable<System.Int32>   <Order>k__BackingField  // 0x58
  private           System.String                   <UnderlyingName>k__BackingField  // 0x60
  private           Newtonsoft.Json.Serialization.IValueProvider<ValueProvider>k__BackingField  // 0x68
  private           Newtonsoft.Json.Serialization.IAttributeProvider<AttributeProvider>k__BackingField  // 0x70
  private           Newtonsoft.Json.JsonConverter   <Converter>k__BackingField  // 0x78
  private           System.Boolean                  <Ignored>k__BackingField  // 0x80
  private           System.Boolean                  <Readable>k__BackingField  // 0x81
  private           System.Boolean                  <Writable>k__BackingField  // 0x82
  private           System.Boolean                  <HasMemberAttribute>k__BackingField  // 0x83
  private           System.Nullable<System.Boolean> <IsReference>k__BackingField  // 0x84
  private           System.Nullable<Newtonsoft.Json.NullValueHandling><NullValueHandling>k__BackingField  // 0x88
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling><DefaultValueHandling>k__BackingField  // 0x90
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ReferenceLoopHandling>k__BackingField  // 0x98
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling><ObjectCreationHandling>k__BackingField  // 0xa0
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><TypeNameHandling>k__BackingField  // 0xa8
  private           System.Predicate<System.Object> <ShouldSerialize>k__BackingField  // 0xb0
  private           System.Predicate<System.Object> <ShouldDeserialize>k__BackingField  // 0xb8
  private           System.Predicate<System.Object> <GetIsSpecified>k__BackingField  // 0xc0
  private           System.Action<System.Object,System.Object><SetIsSpecified>k__BackingField  // 0xc8
  private           Newtonsoft.Json.JsonConverter   <ItemConverter>k__BackingField  // 0xd0
  private           System.Nullable<System.Boolean> <ItemIsReference>k__BackingField  // 0xd8
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><ItemTypeNameHandling>k__BackingField  // 0xdc
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ItemReferenceLoopHandling>k__BackingField  // 0xe4
PROPERTIES:
  PropertyContract  get=0x03D4EA70  set=0x02692290
  PropertyName  get=0x01003830  set=0x024E6960
  DeclaringType  get=0x03D4EAF0  set=0x02C926C0
  Order  get=0x03D4EAA0  set=0x03D4F270
  UnderlyingName  get=0x03D4EB00  set=0x039274B0
  ValueProvider  get=0x03D4EAB0  set=0x038C5570
  AttributeProvider  set=0x0519C3C8
  PropertyType  get=0x03D4E2B0  set=0x024E5C60
  Converter  get=0x03D4EB20  set=0x051DFCA4
  Ignored  get=0x03D4F360  set=0x03D4F380
  Readable  get=0x03D5A210  set=0x03D5A220
  Writable  get=0x03D6C200  set=0x03D71640
  HasMemberAttribute  get=0x03D715D0  set=0x03D71610
  DefaultValue  get=0x092C63E0  set=0x092C63F0
  Required  get=0x02D735B0
  IsReference  get=0x03D67F10  set=0x03D67F20
  NullValueHandling  get=0x03D4EA60  set=0x03D4E740
  DefaultValueHandling  get=0x03D4EA90  set=0x03D5D630
  ReferenceLoopHandling  get=0x011AC510  set=0x03D50F10
  ObjectCreationHandling  get=0x03D4EA80  set=0x03D71630
  TypeNameHandling  get=0x03D4EB10  set=0x03D4EB70
  ShouldSerialize  get=0x03D4EAD0  set=0x02B47080
  ShouldDeserialize  get=0x03D4E750
  GetIsSpecified  get=0x03D50E60  set=0x058B426C
  SetIsSpecified  get=0x03D4E7C0  set=0x058B4280
  ItemConverter  get=0x03D50050  set=0x0554A7E0
  ItemIsReference  get=0x03D715E0  set=0x03D71620
  ItemTypeNameHandling  get=0x03D71600  set=0x03D68FA0
  ItemReferenceLoopHandling  get=0x03D715F0  set=0x03D68F90
METHODS:
  RVA=0x027BBFC0  token=0x6000542  System.Object GetResolvedDefaultValue()
  RVA=0x092C6398  token=0x6000557  System.String ToString()
  RVA=0x027BAAA0  token=0x6000560  System.Void WritePropertyName(Newtonsoft.Json.JsonWriter writer)
  RVA=0x0350B670  token=0x6000561  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonPropertyCollection
TYPE:  class
TOKEN: 0x20000C7
SIZE:  0x40
EXTENDS: System.Collections.ObjectModel.KeyedCollection`2
FIELDS:
  private   readonly System.Type                     _type  // 0x30
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty>_list  // 0x38
METHODS:
  RVA=0x024753A0  token=0x6000562  System.Void .ctor(System.Type type)
  RVA=0x03D715B0  token=0x6000563  System.String GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item)
  RVA=0x024E5F60  token=0x6000564  System.Void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property)
  RVA=0x023236D0  token=0x6000565  Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(System.String propertyName)
  RVA=0x02323BF0  token=0x6000566  System.Boolean TryGetProperty(System.String key, Newtonsoft.Json.Serialization.JsonProperty& item)
  RVA=0x02323910  token=0x6000567  Newtonsoft.Json.Serialization.JsonProperty GetProperty(System.String propertyName, System.StringComparison comparisonType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalBase
TYPE:  abstract class
TOKEN: 0x20000C8
SIZE:  0x38
FIELDS:
  private           Newtonsoft.Json.Serialization.ErrorContext_currentErrorContext  // 0x10
  private           Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object>_mappings  // 0x18
  private   readonly Newtonsoft.Json.JsonSerializer  Serializer  // 0x20
  private   readonly Newtonsoft.Json.Serialization.ITraceWriterTraceWriter  // 0x28
  protected         Newtonsoft.Json.Serialization.JsonSerializerProxyInternalSerializer  // 0x30
PROPERTIES:
  DefaultReferenceMappings  get=0x092C68DC
METHODS:
  RVA=0x03163C30  token=0x6000568  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092C6850  token=0x600056A  Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property)
  RVA=0x092C6478  token=0x600056B  Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(System.Object currentObject, System.Object member, System.String path, System.Exception error)
  RVA=0x092C6404  token=0x600056C  System.Void ClearErrorContext()
  RVA=0x092C6584  token=0x600056D  System.Boolean IsErrorHandled(System.Object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, System.Object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalReader
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0x38
EXTENDS: Newtonsoft.Json.Serialization.JsonSerializerInternalBase
FIELDS:
METHODS:
  RVA=0x042719A0  token=0x6000571  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x092C9CF0  token=0x6000572  System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target)
  RVA=0x027BC960  token=0x6000573  Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type)
  RVA=0x027BDC20  token=0x6000574  Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type)
  RVA=0x027BC7E0  token=0x6000575  System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Boolean checkAdditionalContent)
  RVA=0x024DF020  token=0x6000576  Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
  RVA=0x02693190  token=0x6000577  Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract)
  RVA=0x03A378D0  token=0x6000578  Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader)
  RVA=0x02323E60  token=0x6000579  System.Object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue)
  RVA=0x02906460  token=0x600057A  System.Boolean CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, System.String s)
  RVA=0x092C94D8  token=0x600057B  System.String GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract)
  RVA=0x024EA550  token=0x600057C  Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x024E8590  token=0x600057D  System.Object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue)
  RVA=0x092CA278  token=0x600057E  System.Boolean ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id)
  RVA=0x024E8D50  token=0x600057F  System.Boolean ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id)
  RVA=0x027BC9D0  token=0x6000580  System.Void ResolveTypeName(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.String qualifiedTypeName)
  RVA=0x024EA4E0  token=0x6000581  Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract)
  RVA=0x024E9EC0  token=0x6000582  System.Object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Object existingValue, System.String id)
  RVA=0x024E8BC0  token=0x6000583  System.Boolean HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract)
  RVA=0x02417B90  token=0x6000584  System.Object EnsureType(Newtonsoft.Json.JsonReader reader, System.Object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType)
  RVA=0x02325070  token=0x6000585  System.Boolean SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target)
  RVA=0x023253A0  token=0x6000586  System.Boolean CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter& propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target, System.Boolean& useExistingValue, System.Object& currentValue, Newtonsoft.Json.Serialization.JsonContract& propertyContract, System.Boolean& gottenCurrentValue, System.Boolean& ignoredValue)
  RVA=0x092C69E4  token=0x6000587  System.Void AddReference(Newtonsoft.Json.JsonReader reader, System.String id, System.Object value)
  RVA=0x02325BB0  token=0x6000588  System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag)
  RVA=0x02324F90  token=0x6000589  System.Boolean ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Object value)
  RVA=0x024E8160  token=0x600058A  System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, System.Boolean& createdFromNonDefaultCreator)
  RVA=0x03241110  token=0x600058B  System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, System.Boolean& createdFromNonDefaultCreator)
  RVA=0x02B391C0  token=0x600058C  System.Void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  RVA=0x024E9C70  token=0x600058D  System.Void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  RVA=0x024EDD60  token=0x600058E  System.Object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  RVA=0x092C9628  token=0x600058F  System.Object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  RVA=0x092CAFB0  token=0x6000590  System.Void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object currentObject, System.String message)
  RVA=0x024EBC20  token=0x6000591  System.Object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  RVA=0x092C74AC  token=0x6000592  System.Object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  RVA=0x092C7390  token=0x6000593  System.Object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member)
  RVA=0x092C6CA0  token=0x6000594  System.Object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  RVA=0x092C7B00  token=0x6000595  System.Object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, System.String id)
  RVA=0x024DEEB0  token=0x6000596  System.Object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue)
  RVA=0x092CA870  token=0x6000597  System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType)
  RVA=0x024E9BA0  token=0x6000598  System.Object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id, System.Boolean& createdFromNonDefaultCreator)
  RVA=0x02321C70  token=0x6000599  System.Object PopulateObject(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  RVA=0x02B0FC70  token=0x600059A  System.Boolean ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
  RVA=0x024EE3E0  token=0x600059B  System.Boolean CheckPropertyName(Newtonsoft.Json.JsonReader reader, System.String memberName)
  RVA=0x0269A0A0  token=0x600059C  System.Void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, System.String memberName, System.Object o)
  RVA=0x092CA1CC  token=0x600059D  System.Object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader)
  RVA=0x027BBCC0  token=0x600059E  System.Void EndProcessProperty(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Int32 initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, System.Boolean setDefaultValue)
  RVA=0x02906310  token=0x600059F  System.Void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties)
  RVA=0x092C95BC  token=0x60005A0  System.Void HandleError(Newtonsoft.Json.JsonReader reader, System.Boolean readPastError, System.Int32 initialDepth)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalWriter
TYPE:  class
TOKEN: 0x20000CF
SIZE:  0x50
EXTENDS: Newtonsoft.Json.Serialization.JsonSerializerInternalBase
FIELDS:
  private           System.Type                     _rootType  // 0x38
  private           System.Int32                    _rootLevel  // 0x40
  private   readonly System.Collections.Generic.List<System.Object>_serializeStack  // 0x48
METHODS:
  RVA=0x03163B90  token=0x60005AA  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  RVA=0x03163CA0  token=0x60005AB  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  RVA=0x092CB0F8  token=0x60005AC  Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
  RVA=0x027BEC50  token=0x60005AD  Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Object value)
  RVA=0x027BEC70  token=0x60005AE  Newtonsoft.Json.Serialization.JsonContract GetContract(System.Object value)
  RVA=0x027BB4A0  token=0x60005AF  System.Void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BB160  token=0x60005B0  System.Void SerializeValue(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BB940  token=0x60005B1  System.Nullable<System.Boolean> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BAED0  token=0x60005B2  System.Boolean ShouldWriteReference(System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BAE20  token=0x60005B3  System.Boolean ShouldWriteProperty(System.Object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property)
  RVA=0x027BAFD0  token=0x60005B4  System.Boolean CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CD2AC  token=0x60005B5  System.Void WriteReference(Newtonsoft.Json.JsonWriter writer, System.Object value)
  RVA=0x092CB16C  token=0x60005B6  System.String GetReference(Newtonsoft.Json.JsonWriter writer, System.Object value)
  RVA=0x092CD068  token=0x60005B7  System.Boolean TryConvertToString(System.Object value, System.Type type, System.String& s)
  RVA=0x092CCF38  token=0x60005B8  System.Void SerializeString(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonStringContract contract)
  RVA=0x027B91B0  token=0x60005B9  System.Void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  RVA=0x027B9370  token=0x60005BA  System.Void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  RVA=0x027B9530  token=0x60005BB  System.Void SerializeObject(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BAAD0  token=0x60005BC  System.Boolean CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract& memberContract, System.Object& memberValue)
  RVA=0x027BB9D0  token=0x60005BD  System.Void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CB36C  token=0x60005BE  System.Boolean HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property)
  RVA=0x092CD138  token=0x60005BF  System.Void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, System.Object value)
  RVA=0x092CD450  token=0x60005C0  System.Void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type)
  RVA=0x027BAEC0  token=0x60005C1  System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag)
  RVA=0x027BAEC0  token=0x60005C2  System.Boolean HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag)
  RVA=0x02325BB0  token=0x60005C3  System.Boolean HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag)
  RVA=0x092CB3F4  token=0x60005C4  System.Void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027B8270  token=0x60005C5  System.Void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CCDA8  token=0x60005C6  System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CC9CC  token=0x60005C7  System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Int32 initialDepth, System.Int32[] indices)
  RVA=0x027B8110  token=0x60005C8  System.Boolean WriteStartArray(Newtonsoft.Json.JsonWriter writer, System.Object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CC5C8  token=0x60005C9  System.Void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CB734  token=0x60005CA  System.Void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x092CCFD0  token=0x60005CB  System.Boolean ShouldWriteDynamicProperty(System.Object memberValue)
  RVA=0x027BBB00  token=0x60005CC  System.Boolean ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027BECB0  token=0x60005CD  System.Void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  RVA=0x027C05A0  token=0x60005CE  System.String GetPropertyName(Newtonsoft.Json.JsonWriter writer, System.Object name, Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean& escape)
  RVA=0x092CB304  token=0x60005CF  System.Void HandleError(Newtonsoft.Json.JsonWriter writer, System.Int32 initialDepth)
  RVA=0x027BAD90  token=0x60005D0  System.Boolean ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
  RVA=0x027BAD00  token=0x60005D1  System.Boolean IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerProxy
TYPE:  class
TOKEN: 0x20000D0
SIZE:  0xF8
EXTENDS: Newtonsoft.Json.JsonSerializer
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader_serializerReader  // 0xe0
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalWriter_serializerWriter  // 0xe8
  private   readonly Newtonsoft.Json.JsonSerializer  _serializer  // 0xf0
PROPERTIES:
  ReferenceResolver  set=0x092DC1CC
  TraceWriter  get=0x092DBF68  set=0x092DC21C
  EqualityComparer  set=0x092DC08C
  Converters  get=0x092DBEB8
  DefaultValueHandling  set=0x092DC064
  ContractResolver  get=0x092DBE94  set=0x092DC03C
  MissingMemberHandling  set=0x092DC104
  NullValueHandling  get=0x092DBF44  set=0x092DC12C
  ObjectCreationHandling  set=0x092DC154
  ReferenceLoopHandling  set=0x092DC1A4
  PreserveReferencesHandling  set=0x092DC17C
  TypeNameHandling  set=0x092DC26C
  MetadataPropertyHandling  get=0x092DBF20  set=0x092DC0DC
  TypeNameAssemblyFormatHandling  set=0x092DC244
  ConstructorHandling  set=0x092DBFDC
  SerializationBinder  set=0x092DC1F4
  Context  get=0x092DBE60  set=0x092DC004
  Formatting  get=0x092DBED8  set=0x092DC0B4
  MaxDepth  get=0x092DBEFC
  CheckAdditionalContent  get=0x092DBE3C  set=0x092DBFB4
EVENTS:
  Error  add=add_Error  remove=remove_Error
METHODS:
  RVA=0x092DBCAC  token=0x60005EF  Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer()
  RVA=0x02695990  token=0x60005F0  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader)
  RVA=0x092DBD54  token=0x60005F1  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter)
  RVA=0x092DBC60  token=0x60005F2  System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  RVA=0x092DBCC8  token=0x60005F3  System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target)
  RVA=0x092DBD0C  token=0x60005F4  System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type rootType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonStringContract
TYPE:  class
TOKEN: 0x20000D1
SIZE:  0x98
EXTENDS: Newtonsoft.Json.Serialization.JsonPrimitiveContract
FIELDS:
METHODS:
  RVA=0x03439D30  token=0x60005F5  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonTypeReflector
TYPE:  static class
TOKEN: 0x20000D2
SIZE:  0x10
FIELDS:
  private   static  System.Nullable<System.Boolean> _fullyTrusted  // static @ 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Func<System.Object[],System.Object>>CreatorCache  // static @ 0x8
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type>AssociatedMetadataTypesCache  // static @ 0x10
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_metadataTypeAttributeReflectionObject  // static @ 0x18
PROPERTIES:
  FullyTrusted  get=0x092DC7C8
  ReflectionDelegateFactory  get=0x02476090
METHODS:
  RVA=-1  // generic def  token=0x60005F6  T GetCachedAttribute(System.Object attributeProvider)
  RVA=0x025E6FD0  token=0x60005F7  System.Boolean CanTypeDescriptorConvertString(System.Type type, System.ComponentModel.TypeConverter& typeConverter)
  RVA=0x024E7560  token=0x60005F8  System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type)
  RVA=0x092DC5AC  token=0x60005F9  System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo)
  RVA=0x0283DEE0  token=0x60005FA  Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, System.Boolean ignoreSerializableAttribute)
  RVA=0x024E71C0  token=0x60005FB  Newtonsoft.Json.JsonConverter GetJsonConverter(System.Object attributeProvider)
  RVA=0x092DC294  token=0x60005FC  Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, System.Object[] args)
  RVA=0x092DC33C  token=0x60005FD  Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, System.Object[] args)
  RVA=0x092DC3E4  token=0x60005FE  Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute)
  RVA=0x092DC48C  token=0x60005FF  System.Func<System.Object[],System.Object> GetCreator(System.Type type)
  RVA=0x02303720  token=0x6000600  System.Type GetAssociatedMetadataType(System.Type type)
  RVA=0x030ED130  token=0x6000601  System.Type GetAssociateMetadataTypeFromAttribute(System.Type type)
  RVA=-1  // generic def  token=0x6000602  T GetAttribute(System.Type type)
  RVA=-1  // generic def  token=0x6000603  T GetAttribute(System.Reflection.MemberInfo memberInfo)
  RVA=0x03132B60  token=0x6000604  System.Boolean IsNonSerializable(System.Object provider)
  RVA=0x092DC76C  token=0x6000605  System.Boolean IsSerializable(System.Object provider)
  RVA=-1  // generic def  token=0x6000606  T GetAttribute(System.Object provider)
  RVA=0x038CEC10  token=0x6000609  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.KebabCaseNamingStrategy
TYPE:  class
TOKEN: 0x20000D5
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Serialization.NamingStrategy
FIELDS:
METHODS:
  RVA=0x03D714A0  token=0x600060F  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  RVA=0x03D71490  token=0x6000610  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  RVA=0x0350B670  token=0x6000611  System.Void .ctor()
  RVA=0x092DC888  token=0x6000612  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.NamingStrategy
TYPE:  abstract class
TOKEN: 0x20000D6
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <ProcessDictionaryKeys>k__BackingField  // 0x10
  private           System.Boolean                  <ProcessExtensionDataNames>k__BackingField  // 0x11
  private           System.Boolean                  <OverrideSpecifiedNames>k__BackingField  // 0x12
PROPERTIES:
  ProcessDictionaryKeys  get=0x011797F0  set=0x03D4E960
  ProcessExtensionDataNames  get=0x03D510E0  set=0x03D510F0
  OverrideSpecifiedNames  get=0x03D519E0  set=0x03D6B770
METHODS:
  RVA=0x092DCA80  token=0x6000619  System.String GetPropertyName(System.String name, System.Boolean hasSpecifiedName)
  RVA=0x092DC9A8  token=0x600061A  System.String GetExtensionDataName(System.String name)
  RVA=0x092DC980  token=0x600061B  System.String GetDictionaryKey(System.String key)
  RVA=-1  // abstract  token=0x600061C  System.String ResolvePropertyName(System.String name)
  RVA=0x092DC9D0  token=0x600061D  System.Int32 GetHashCode()
  RVA=0x092DC92C  token=0x600061E  System.Boolean Equals(System.Object obj)
  RVA=0x092DC894  token=0x600061F  System.Boolean Equals(Newtonsoft.Json.Serialization.NamingStrategy other)
  RVA=0x0350B670  token=0x6000620  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ObjectConstructor`1
TYPE:  sealed class
TOKEN: 0x20000D7
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000621  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000622  System.Object Invoke(System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.OnErrorAttribute
TYPE:  sealed class
TOKEN: 0x20000D8
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ReflectionAttributeProvider
TYPE:  class
TOKEN: 0x20000D9
SIZE:  0x18
IMPLEMENTS: Newtonsoft.Json.Serialization.IAttributeProvider
FIELDS:
  private   readonly System.Object                   _attributeProvider  // 0x10
METHODS:
  RVA=0x024E5C10  token=0x6000623  System.Void .ctor(System.Object attributeProvider)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ReflectionValueProvider
TYPE:  class
TOKEN: 0x20000DA
SIZE:  0x18
IMPLEMENTS: Newtonsoft.Json.Serialization.IValueProvider
FIELDS:
  private   readonly System.Reflection.MemberInfo    _memberInfo  // 0x10
METHODS:
  RVA=0x024E5BC0  token=0x6000624  System.Void .ctor(System.Reflection.MemberInfo memberInfo)
  RVA=0x02325C30  token=0x6000625  System.Void SetValue(System.Object target, System.Object value)
  RVA=0x0232C920  token=0x6000626  System.Object GetValue(System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy
TYPE:  class
TOKEN: 0x20000DB
SIZE:  0x18
EXTENDS: Newtonsoft.Json.Serialization.NamingStrategy
FIELDS:
METHODS:
  RVA=0x03D714A0  token=0x6000627  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  RVA=0x03D71490  token=0x6000628  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  RVA=0x0350B670  token=0x6000629  System.Void .ctor()
  RVA=0x092DCAA4  token=0x600062A  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.TraceJsonReader
TYPE:  class
TOKEN: 0x20000DC
SIZE:  0x90
EXTENDS: Newtonsoft.Json.JsonReader
IMPLEMENTS: Newtonsoft.Json.IJsonLineInfo
FIELDS:
  private   readonly Newtonsoft.Json.JsonReader      _innerReader  // 0x78
  private   readonly Newtonsoft.Json.JsonTextWriter  _textWriter  // 0x80
  private   readonly System.IO.StringWriter          _sw  // 0x88
PROPERTIES:
  Depth  get=0x092DD008
  Path  get=0x092DD02C
  TokenType  get=0x092DD050
  Value  get=0x092DD098
  ValueType  get=0x092DD074
  Newtonsoft.Json.IJsonLineInfo.LineNumber  get=0x092DCB48
  Newtonsoft.Json.IJsonLineInfo.LinePosition  get=0x092DCB98
METHODS:
  RVA=0x092DCEB0  token=0x600062B  System.Void .ctor(Newtonsoft.Json.JsonReader innerReader)
  RVA=0x092DCAD4  token=0x600062C  System.String GetDeserializedJsonMessage()
  RVA=0x092DCE38  token=0x600062D  System.Boolean Read()
  RVA=0x092DCDB0  token=0x600062E  System.Nullable<System.Int32> ReadAsInt32()
  RVA=0x092DCDF4  token=0x600062F  System.String ReadAsString()
  RVA=0x092DCC2C  token=0x6000630  System.Byte[] ReadAsBytes()
  RVA=0x092DCD0C  token=0x6000631  System.Nullable<System.Decimal> ReadAsDecimal()
  RVA=0x092DCD60  token=0x6000632  System.Nullable<System.Double> ReadAsDouble()
  RVA=0x092DCBE8  token=0x6000633  System.Nullable<System.Boolean> ReadAsBoolean()
  RVA=0x092DCCC4  token=0x6000634  System.Nullable<System.DateTime> ReadAsDateTime()
  RVA=0x092DCC70  token=0x6000635  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  RVA=0x092DCE7C  token=0x6000636  System.Void WriteCurrentToken()
  RVA=0x092DCAB0  token=0x600063C  System.Void Close()
  RVA=0x092DCAF8  token=0x600063D  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.TraceJsonWriter
TYPE:  class
TOKEN: 0x20000DD
SIZE:  0x78
EXTENDS: Newtonsoft.Json.JsonWriter
FIELDS:
  private   readonly Newtonsoft.Json.JsonWriter      _innerWriter  // 0x60
  private   readonly Newtonsoft.Json.JsonTextWriter  _textWriter  // 0x68
  private   readonly System.IO.StringWriter          _sw  // 0x70
METHODS:
  RVA=0x092DE82C  token=0x6000640  System.Void .ctor(Newtonsoft.Json.JsonWriter innerWriter)
  RVA=0x092DD100  token=0x6000641  System.String GetSerializedJsonMessage()
  RVA=0x092DD878  token=0x6000642  System.Void WriteValue(System.Decimal value)
  RVA=0x092DDAC8  token=0x6000643  System.Void WriteValue(System.Nullable<System.Decimal> value)
  RVA=0x092DDA6C  token=0x6000644  System.Void WriteValue(System.Boolean value)
  RVA=0x092DDCA4  token=0x6000645  System.Void WriteValue(System.Nullable<System.Boolean> value)
  RVA=0x092DD608  token=0x6000646  System.Void WriteValue(System.Byte value)
  RVA=0x092DDF74  token=0x6000647  System.Void WriteValue(System.Nullable<System.Byte> value)
  RVA=0x092DDC48  token=0x6000648  System.Void WriteValue(System.Char value)
  RVA=0x092DE004  token=0x6000649  System.Void WriteValue(System.Nullable<System.Char> value)
  RVA=0x092DE6CC  token=0x600064A  System.Void WriteValue(System.Byte[] value)
  RVA=0x092DE4D4  token=0x600064B  System.Void WriteValue(System.DateTime value)
  RVA=0x092DD664  token=0x600064C  System.Void WriteValue(System.Nullable<System.DateTime> value)
  RVA=0x092DD8F4  token=0x600064D  System.Void WriteValue(System.DateTimeOffset value)
  RVA=0x092DDB88  token=0x600064E  System.Void WriteValue(System.Nullable<System.DateTimeOffset> value)
  RVA=0x092DD968  token=0x600064F  System.Void WriteValue(System.Double value)
  RVA=0x092DDE24  token=0x6000650  System.Void WriteValue(System.Nullable<System.Double> value)
  RVA=0x092DD4DC  token=0x6000651  System.Void WriteUndefined()
  RVA=0x092DD24C  token=0x6000652  System.Void WriteNull()
  RVA=0x092DE238  token=0x6000653  System.Void WriteValue(System.Single value)
  RVA=0x092DE5D8  token=0x6000654  System.Void WriteValue(System.Nullable<System.Single> value)
  RVA=0x092DE130  token=0x6000655  System.Void WriteValue(System.Guid value)
  RVA=0x092DE294  token=0x6000656  System.Void WriteValue(System.Nullable<System.Guid> value)
  RVA=0x092DD820  token=0x6000657  System.Void WriteValue(System.Int32 value)
  RVA=0x092DD520  token=0x6000658  System.Void WriteValue(System.Nullable<System.Int32> value)
  RVA=0x092DE3A4  token=0x6000659  System.Void WriteValue(System.Int64 value)
  RVA=0x092DD9C4  token=0x600065A  System.Void WriteValue(System.Nullable<System.Int64> value)
  RVA=0x092DE400  token=0x600065B  System.Void WriteValue(System.Object value)
  RVA=0x092DD5B8  token=0x600065C  System.Void WriteValue(System.SByte value)
  RVA=0x092DD704  token=0x600065D  System.Void WriteValue(System.Nullable<System.SByte> value)
  RVA=0x092DE738  token=0x600065E  System.Void WriteValue(System.Int16 value)
  RVA=0x092DD794  token=0x600065F  System.Void WriteValue(System.Nullable<System.Int16> value)
  RVA=0x092DDDC8  token=0x6000660  System.Void WriteValue(System.String value)
  RVA=0x092DDED0  token=0x6000661  System.Void WriteValue(System.TimeSpan value)
  RVA=0x092DE090  token=0x6000662  System.Void WriteValue(System.Nullable<System.TimeSpan> value)
  RVA=0x092DE34C  token=0x6000663  System.Void WriteValue(System.UInt32 value)
  RVA=0x092DE794  token=0x6000664  System.Void WriteValue(System.Nullable<System.UInt32> value)
  RVA=0x092DE670  token=0x6000665  System.Void WriteValue(System.UInt64 value)
  RVA=0x092DE530  token=0x6000666  System.Void WriteValue(System.Nullable<System.UInt64> value)
  RVA=0x092DE1A4  token=0x6000667  System.Void WriteValue(System.Uri value)
  RVA=0x092DDF20  token=0x6000668  System.Void WriteValue(System.UInt16 value)
  RVA=0x092DDD3C  token=0x6000669  System.Void WriteValue(System.Nullable<System.UInt16> value)
  RVA=0x092DD124  token=0x600066A  System.Void WriteComment(System.String text)
  RVA=0x092DD3F8  token=0x600066B  System.Void WriteStartArray()
  RVA=0x092DD180  token=0x600066C  System.Void WriteEndArray()
  RVA=0x092DD43C  token=0x600066D  System.Void WriteStartConstructor(System.String name)
  RVA=0x092DD1C4  token=0x600066E  System.Void WriteEndConstructor()
  RVA=0x092DD290  token=0x600066F  System.Void WritePropertyName(System.String name)
  RVA=0x092DD2EC  token=0x6000670  System.Void WritePropertyName(System.String name, System.Boolean escape)
  RVA=0x092DD498  token=0x6000671  System.Void WriteStartObject()
  RVA=0x092DD208  token=0x6000672  System.Void WriteEndObject()
  RVA=0x092DD350  token=0x6000673  System.Void WriteRawValue(System.String json)
  RVA=0x092DD3AC  token=0x6000674  System.Void WriteRaw(System.String json)
  RVA=0x092DD0BC  token=0x6000675  System.Void Close()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.AotHelper
TYPE:  static class
TOKEN: 0x200003F
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_alwaysFalse  // static @ 0x0
METHODS:
  RVA=0x03A28210  token=0x6000205  System.Void Ensure(System.Action action)
  RVA=-1  // generic def  token=0x6000206  System.Void EnsureList()
  RVA=0x092B8530  token=0x6000207  System.Boolean IsFalse()
  RVA=0x03CF5C20  token=0x6000208  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.Base64Encoder
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x30
FIELDS:
  private   readonly System.Char[]                   _charsLine  // 0x10
  private   readonly System.IO.TextWriter            _writer  // 0x18
  private           System.Byte[]                   _leftOverBytes  // 0x20
  private           System.Int32                    _leftOverBytesCount  // 0x28
METHODS:
  RVA=0x092B8AA8  token=0x600020C  System.Void .ctor(System.IO.TextWriter writer)
  RVA=0x092B8900  token=0x600020D  System.Void ValidateEncode(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x092B8580  token=0x600020E  System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x092B8818  token=0x600020F  System.Void StoreLeftOverBytes(System.Byte[] buffer, System.Int32 index, System.Int32& count)
  RVA=0x092B8788  token=0x6000210  System.Boolean FulfillFromLeftover(System.Byte[] buffer, System.Int32 index, System.Int32& count)
  RVA=0x092B86EC  token=0x6000211  System.Void Flush()
  RVA=0x092B8A78  token=0x6000212  System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BidirectionalDictionary`2
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<TFirst,TSecond>_firstToSecond  // 0x0
  private   readonly System.Collections.Generic.IDictionary<TSecond,TFirst>_secondToFirst  // 0x0
  private   readonly System.String                   _duplicateFirstErrorMessage  // 0x0
  private   readonly System.String                   _duplicateSecondErrorMessage  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000213  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, System.String duplicateFirstErrorMessage, System.String duplicateSecondErrorMessage)
  RVA=-1  // not resolved  token=0x6000214  System.Void Set(TFirst first, TSecond second)
  RVA=-1  // not resolved  token=0x6000215  System.Boolean TryGetByFirst(TFirst first, TSecond& second)
  RVA=-1  // not resolved  token=0x6000216  System.Boolean TryGetBySecond(TSecond second, TFirst& first)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BoxedPrimitives
TYPE:  static class
TOKEN: 0x2000043
SIZE:  0x10
FIELDS:
  private   static readonly System.Object                   BooleanTrue  // static @ 0x0
  private   static readonly System.Object                   BooleanFalse  // static @ 0x8
  private   static readonly System.Object                   Int32_M1  // static @ 0x10
  private   static readonly System.Object                   Int32_0  // static @ 0x18
  private   static readonly System.Object                   Int32_1  // static @ 0x20
  private   static readonly System.Object                   Int32_2  // static @ 0x28
  private   static readonly System.Object                   Int32_3  // static @ 0x30
  private   static readonly System.Object                   Int32_4  // static @ 0x38
  private   static readonly System.Object                   Int32_5  // static @ 0x40
  private   static readonly System.Object                   Int32_6  // static @ 0x48
  private   static readonly System.Object                   Int32_7  // static @ 0x50
  private   static readonly System.Object                   Int32_8  // static @ 0x58
  private   static readonly System.Object                   Int64_M1  // static @ 0x60
  private   static readonly System.Object                   Int64_0  // static @ 0x68
  private   static readonly System.Object                   Int64_1  // static @ 0x70
  private   static readonly System.Object                   Int64_2  // static @ 0x78
  private   static readonly System.Object                   Int64_3  // static @ 0x80
  private   static readonly System.Object                   Int64_4  // static @ 0x88
  private   static readonly System.Object                   Int64_5  // static @ 0x90
  private   static readonly System.Object                   Int64_6  // static @ 0x98
  private   static readonly System.Object                   Int64_7  // static @ 0xa0
  private   static readonly System.Object                   Int64_8  // static @ 0xa8
  private   static readonly System.Object                   DecimalZero  // static @ 0xb0
  private   static readonly System.Object                   DoubleNaN  // static @ 0xb8
  private   static readonly System.Object                   DoublePositiveInfinity  // static @ 0xc0
  private   static readonly System.Object                   DoubleNegativeInfinity  // static @ 0xc8
  private   static readonly System.Object                   DoubleZero  // static @ 0xd0
METHODS:
  RVA=0x024ED670  token=0x6000217  System.Object Get(System.Boolean value)
  RVA=0x024E3FE0  token=0x6000218  System.Object Get(System.Int32 value)
  RVA=0x024E3CF0  token=0x6000219  System.Object Get(System.Int64 value)
  RVA=0x092B9634  token=0x600021A  System.Object Get(System.Decimal value)
  RVA=0x02E869B0  token=0x600021B  System.Object Get(System.Double value)
  RVA=0x02C2B4A0  token=0x600021C  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.CollectionUtils
TYPE:  static class
TOKEN: 0x2000044
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x600021D  System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection)
  RVA=-1  // generic def  token=0x600021E  System.Void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection)
  RVA=0x02477E60  token=0x600021F  System.Boolean IsDictionaryType(System.Type type)
  RVA=0x0308DFC0  token=0x6000220  System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType)
  RVA=0x0308E930  token=0x6000221  System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType)
  RVA=-1  // generic def  token=0x6000222  System.Int32 IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate)
  RVA=-1  // generic def  token=0x6000223  System.Boolean Contains(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer)
  RVA=-1  // generic def  token=0x6000224  System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item)
  RVA=-1  // generic def  token=0x6000225  System.Void FastReverse(System.Collections.Generic.List<T> list)
  RVA=0x092B994C  token=0x6000226  System.Collections.Generic.IList<System.Int32> GetDimensions(System.Collections.IList values, System.Int32 dimensionsCount)
  RVA=0x092B9778  token=0x6000227  System.Void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, System.Int32[] indices)
  RVA=0x092B9A50  token=0x6000228  System.Object JaggedArrayGetValue(System.Collections.IList values, System.Int32[] indices)
  RVA=0x092B9AEC  token=0x6000229  System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, System.Int32 rank)
  RVA=-1  // generic def  token=0x600022A  T[] ArrayEmpty()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.IWrappedCollection
TYPE:  interface
TOKEN: 0x2000046
IMPLEMENTS: System.Collections.IList System.Collections.ICollection System.Collections.IEnumerable
FIELDS:
PROPERTIES:
  UnderlyingCollection  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.CollectionWrapper`1
TYPE:  class
TOKEN: 0x2000047
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable Newtonsoft.Json.Utilities.IWrappedCollection System.Collections.IList System.Collections.ICollection
FIELDS:
  private   readonly System.Collections.IList        _list  // 0x0
  private   readonly System.Collections.Generic.ICollection<T>_genericCollection  // 0x0
  private           System.Object                   _syncRoot  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  System.Collections.IList.IsFixedSize  get=-1  // not resolved
  System.Collections.IList.Item  get=-1  // not resolved  set=-1  // not resolved
  System.Collections.ICollection.IsSynchronized  get=-1  // not resolved
  System.Collections.ICollection.SyncRoot  get=-1  // not resolved
  UnderlyingCollection  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600022D  System.Void .ctor(System.Collections.IList list)
  RVA=-1  // not resolved  token=0x600022E  System.Void .ctor(System.Collections.Generic.ICollection<T> list)
  RVA=-1  // not resolved  token=0x600022F  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000230  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000231  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000232  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000235  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x6000236  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000237  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000238  System.Int32 System.Collections.IList.Add(System.Object value)
  RVA=-1  // not resolved  token=0x6000239  System.Boolean System.Collections.IList.Contains(System.Object value)
  RVA=-1  // not resolved  token=0x600023A  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  RVA=-1  // not resolved  token=0x600023B  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  RVA=-1  // not resolved  token=0x600023C  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  RVA=-1  // not resolved  token=0x600023E  System.Void System.Collections.IList.Remove(System.Object value)
  RVA=-1  // not resolved  token=0x6000241  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000244  System.Void VerifyValueType(System.Object value)
  RVA=-1  // not resolved  token=0x6000245  System.Boolean IsCompatibleObject(System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.PrimitiveTypeCode
TYPE:  sealed struct
TOKEN: 0x2000048
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeEmpty  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeObject  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeChar  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeCharNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBoolean  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBooleanNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSByte  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSByteNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt16  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt16Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt16  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt16Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt32  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt32Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeByte  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeByteNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt32  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt32Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt64  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt64Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt64  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt64Nullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSingle  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSingleNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDouble  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDoubleNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTime  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeOffset  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeOffsetNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDecimal  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDecimalNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeGuid  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeGuidNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeTimeSpan  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeTimeSpanNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBigInteger  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBigIntegerNullable  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUri  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeString  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBytes  // const
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDBNull  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.TypeInformation
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x20
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly Newtonsoft.Json.Utilities.PrimitiveTypeCode<TypeCode>k__BackingField  // 0x18
PROPERTIES:
  Type  get=0x020B7B20
  TypeCode  get=0x020D1AC0
METHODS:
  RVA=0x02738A30  token=0x6000249  System.Void .ctor(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ParseResult
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ParseResultNone  // const
  public    static  Newtonsoft.Json.Utilities.ParseResultSuccess  // const
  public    static  Newtonsoft.Json.Utilities.ParseResultOverflow  // const
  public    static  Newtonsoft.Json.Utilities.ParseResultInvalid  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ConvertUtils
TYPE:  static class
TOKEN: 0x200004B
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode>TypeCodeMap  // static @ 0x0
  private   static readonly Newtonsoft.Json.Utilities.TypeInformation[]PrimitiveTypeCodes  // static @ 0x8
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>>CastConverters  // static @ 0x10
METHODS:
  RVA=0x02476D60  token=0x600024A  Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t)
  RVA=0x02476FF0  token=0x600024B  Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, System.Boolean& isEnum)
  RVA=0x092BAE94  token=0x600024C  Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable)
  RVA=0x024769F0  token=0x600024D  System.Boolean IsConvertible(System.Type t)
  RVA=0x092BAF10  token=0x600024E  System.TimeSpan ParseTimeSpan(System.String input)
  RVA=0x092B9E98  token=0x600024F  System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t)
  RVA=0x092BAF80  token=0x6000250  System.Numerics.BigInteger ToBigInteger(System.Object value)
  RVA=0x092BAA54  token=0x6000251  System.Object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType)
  RVA=0x092B9BE0  token=0x6000252  System.Object Convert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType)
  RVA=0x092BBB60  token=0x6000253  System.Boolean TryConvert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value)
  RVA=0x092BB33C  token=0x6000254  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value)
  RVA=0x03CEDFA0  token=0x6000255  System.Object ConvertOrCast(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType)
  RVA=0x092BA844  token=0x6000256  System.Object EnsureTypeAssignable(System.Object value, System.Type initialType, System.Type targetType)
  RVA=0x092BBCF8  token=0x6000257  System.Boolean VersionTryParse(System.String input, System.Version& result)
  RVA=0x02476C90  token=0x6000258  System.Boolean IsInteger(System.Object value)
  RVA=0x02BAF140  token=0x6000259  Newtonsoft.Json.Utilities.ParseResult Int32TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int32& value)
  RVA=0x02B390D0  token=0x600025A  Newtonsoft.Json.Utilities.ParseResult Int64TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int64& value)
  RVA=0x092BA058  token=0x600025B  Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Decimal& value)
  RVA=0x092BB2F0  token=0x600025C  System.Boolean TryConvertGuid(System.String s, System.Guid& g)
  RVA=0x092BBC60  token=0x600025D  System.Boolean TryHexTextToInt(System.Char[] text, System.Int32 start, System.Int32 end, System.Int32& value)
  RVA=0x035D3A50  token=0x600025E  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ParserTimeZone
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneUnspecified  // const
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneUtc  // const
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneLocalWestOfUtc  // const
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneLocalEastOfUtc  // const
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DateTimeParser
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x48
FIELDS:
  public            System.Int32                    Year  // 0x10
  public            System.Int32                    Month  // 0x14
  public            System.Int32                    Day  // 0x18
  public            System.Int32                    Hour  // 0x1c
  public            System.Int32                    Minute  // 0x20
  public            System.Int32                    Second  // 0x24
  public            System.Int32                    Fraction  // 0x28
  public            System.Int32                    ZoneHour  // 0x2c
  public            System.Int32                    ZoneMinute  // 0x30
  public            Newtonsoft.Json.Utilities.ParserTimeZoneZone  // 0x34
  private           System.Char[]                   _text  // 0x38
  private           System.Int32                    _end  // 0x40
  private   static readonly System.Int32[]                  Power10  // static @ 0x0
  private   static readonly System.Int32                    Lzyyyy  // static @ 0x8
  private   static readonly System.Int32                    Lzyyyy_  // static @ 0xc
  private   static readonly System.Int32                    Lzyyyy_MM  // static @ 0x10
  private   static readonly System.Int32                    Lzyyyy_MM_  // static @ 0x14
  private   static readonly System.Int32                    Lzyyyy_MM_dd  // static @ 0x18
  private   static readonly System.Int32                    Lzyyyy_MM_ddT  // static @ 0x1c
  private   static readonly System.Int32                    LzHH  // static @ 0x20
  private   static readonly System.Int32                    LzHH_  // static @ 0x24
  private   static readonly System.Int32                    LzHH_mm  // static @ 0x28
  private   static readonly System.Int32                    LzHH_mm_  // static @ 0x2c
  private   static readonly System.Int32                    LzHH_mm_ss  // static @ 0x30
  private   static readonly System.Int32                    Lz_  // static @ 0x34
  private   static readonly System.Int32                    Lz_zz  // static @ 0x38
METHODS:
  RVA=0x092BC54C  token=0x6000261  System.Void .cctor()
  RVA=0x092BC460  token=0x6000262  System.Boolean Parse(System.Char[] text, System.Int32 startIndex, System.Int32 length)
  RVA=0x092BBE74  token=0x6000263  System.Boolean ParseDate(System.Int32 start)
  RVA=0x092BC004  token=0x6000264  System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start)
  RVA=0x092BC074  token=0x6000265  System.Boolean ParseTime(System.Int32& start)
  RVA=0x092BC2F4  token=0x6000266  System.Boolean ParseZone(System.Int32 start)
  RVA=0x092BBD70  token=0x6000267  System.Boolean Parse4Digit(System.Int32 start, System.Int32& num)
  RVA=0x092BBD00  token=0x6000268  System.Boolean Parse2Digit(System.Int32 start, System.Int32& num)
  RVA=0x092BBE3C  token=0x6000269  System.Boolean ParseChar(System.Int32 start, System.Char ch)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DateTimeUtils
TYPE:  static class
TOKEN: 0x2000050
SIZE:  0x10
FIELDS:
  private   static readonly System.Int64                    InitialJavaScriptDateTicks  // static @ 0x0
  private   static readonly System.Int32[]                  DaysToMonth365  // static @ 0x8
  private   static readonly System.Int32[]                  DaysToMonth366  // static @ 0x10
METHODS:
  RVA=0x02562620  token=0x600026A  System.Void .cctor()
  RVA=0x092BCE94  token=0x600026B  System.TimeSpan GetUtcOffset(System.DateTime d)
  RVA=0x092BD044  token=0x600026C  System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind)
  RVA=0x092BCBB8  token=0x600026D  System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone)
  RVA=0x092BCEEC  token=0x600026E  System.DateTime SwitchToLocalTime(System.DateTime value)
  RVA=0x092BCF98  token=0x600026F  System.DateTime SwitchToUtcTime(System.DateTime value)
  RVA=0x092BD20C  token=0x6000270  System.Int64 ToUniversalTicks(System.DateTime dateTime)
  RVA=0x092BD0E0  token=0x6000271  System.Int64 ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset)
  RVA=0x092BC844  token=0x6000272  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset)
  RVA=0x092BC8A0  token=0x6000273  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime)
  RVA=0x092BC8EC  token=0x6000274  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.Boolean convertToUtc)
  RVA=0x092BE694  token=0x6000275  System.Int64 UniversalTicksToJavaScriptTicks(System.Int64 universalTicks)
  RVA=0x092BC984  token=0x6000276  System.DateTime ConvertJavaScriptTicksToDateTime(System.Int64 javaScriptTicks)
  RVA=0x092BD374  token=0x6000277  System.Boolean TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt)
  RVA=0x092BD954  token=0x6000278  System.Boolean TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt)
  RVA=0x092BCA7C  token=0x6000279  System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser)
  RVA=0x02906190  token=0x600027A  System.Boolean TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  RVA=0x092BE15C  token=0x600027B  System.Boolean TryParseDateTime(System.String s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  RVA=0x092BDCD0  token=0x600027C  System.Boolean TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  RVA=0x092BDEB4  token=0x600027D  System.Boolean TryParseDateTimeOffset(System.String s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  RVA=0x092BE3E0  token=0x600027E  System.Boolean TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, System.Int64& ticks, System.TimeSpan& offset, System.DateTimeKind& kind)
  RVA=0x092BD784  token=0x600027F  System.Boolean TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt)
  RVA=0x092BD2A8  token=0x6000280  System.Boolean TryParseDateTimeExact(System.String text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  RVA=0x092BDBA8  token=0x6000281  System.Boolean TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt)
  RVA=0x092BD8B4  token=0x6000282  System.Boolean TryParseDateTimeOffsetExact(System.String text, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  RVA=0x092BE550  token=0x6000283  System.Boolean TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, System.Int32 startIndex, System.TimeSpan& offset)
  RVA=0x092BEA5C  token=0x6000284  System.Void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture)
  RVA=0x092BEBB0  token=0x6000285  System.Int32 WriteDateTimeString(System.Char[] chars, System.Int32 start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format)
  RVA=0x092BEEA0  token=0x6000286  System.Int32 WriteDefaultIsoDate(System.Char[] chars, System.Int32 start, System.DateTime dt)
  RVA=0x092BC9F0  token=0x6000287  System.Void CopyIntToCharArray(System.Char[] chars, System.Int32 start, System.Int32 value, System.Int32 digits)
  RVA=0x092BE888  token=0x6000288  System.Int32 WriteDateTimeOffset(System.Char[] chars, System.Int32 start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format)
  RVA=0x092BE6F8  token=0x6000289  System.Void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture)
  RVA=0x092BCCD8  token=0x600028A  System.Void GetDateValues(System.DateTime td, System.Int32& year, System.Int32& month, System.Int32& day)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.IWrappedDictionary
TYPE:  interface
TOKEN: 0x2000051
IMPLEMENTS: System.Collections.IDictionary System.Collections.ICollection System.Collections.IEnumerable
FIELDS:
PROPERTIES:
  UnderlyingDictionary  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DictionaryWrapper`2
TYPE:  class
TOKEN: 0x2000052
IMPLEMENTS: System.Collections.Generic.IDictionary`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable Newtonsoft.Json.Utilities.IWrappedDictionary System.Collections.IDictionary System.Collections.ICollection
FIELDS:
  private   readonly System.Collections.IDictionary  _dictionary  // 0x0
  private   readonly System.Collections.Generic.IDictionary<TKey,TValue>_genericDictionary  // 0x0
  private   readonly System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>_readOnlyDictionary  // 0x0
  private           System.Object                   _syncRoot  // 0x0
PROPERTIES:
  GenericDictionary  get=-1  // not resolved
  Keys  get=-1  // not resolved
  Values  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  System.Collections.IDictionary.Item  get=-1  // not resolved  set=-1  // not resolved
  System.Collections.IDictionary.IsFixedSize  get=-1  // not resolved
  System.Collections.IDictionary.Keys  get=-1  // not resolved
  System.Collections.IDictionary.Values  get=-1  // not resolved
  System.Collections.ICollection.IsSynchronized  get=-1  // not resolved
  System.Collections.ICollection.SyncRoot  get=-1  // not resolved
  UnderlyingDictionary  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600028D  System.Void Add(TKey key, TValue value)
  RVA=-1  // not resolved  token=0x600028E  System.Boolean ContainsKey(TKey key)
  RVA=-1  // not resolved  token=0x6000290  System.Boolean Remove(TKey key)
  RVA=-1  // not resolved  token=0x6000291  System.Boolean TryGetValue(TKey key, TValue& value)
  RVA=-1  // not resolved  token=0x6000295  System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000296  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000297  System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000298  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x600029B  System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x600029C  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  RVA=-1  // not resolved  token=0x600029D  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x600029E  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  RVA=-1  // not resolved  token=0x60002A1  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  RVA=-1  // not resolved  token=0x60002A2  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  RVA=-1  // not resolved  token=0x60002A5  System.Void Remove(System.Object key)
  RVA=-1  // not resolved  token=0x60002A7  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicProxy`1
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60002B5  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance)
  RVA=-1  // not resolved  token=0x60002B6  System.Boolean TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result)
  RVA=-1  // not resolved  token=0x60002B7  System.Boolean TryConvert(T instance, System.Dynamic.ConvertBinder binder, System.Object& result)
  RVA=-1  // not resolved  token=0x60002B8  System.Boolean TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, System.Object[] args, System.Object& result)
  RVA=-1  // not resolved  token=0x60002B9  System.Boolean TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, System.Object[] indexes)
  RVA=-1  // not resolved  token=0x60002BA  System.Boolean TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder)
  RVA=-1  // not resolved  token=0x60002BB  System.Boolean TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, System.Object[] indexes, System.Object& result)
  RVA=-1  // not resolved  token=0x60002BC  System.Boolean TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, System.Object& result)
  RVA=-1  // not resolved  token=0x60002BD  System.Boolean TryInvoke(T instance, System.Dynamic.InvokeBinder binder, System.Object[] args, System.Object& result)
  RVA=-1  // not resolved  token=0x60002BE  System.Boolean TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, System.Object[] args, System.Object& result)
  RVA=-1  // not resolved  token=0x60002BF  System.Boolean TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, System.Object[] indexes, System.Object value)
  RVA=-1  // not resolved  token=0x60002C0  System.Boolean TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, System.Object value)
  RVA=-1  // not resolved  token=0x60002C1  System.Boolean TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, System.Object& result)
  RVA=-1  // not resolved  token=0x60002C2  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1
TYPE:  sealed class
TOKEN: 0x2000056
EXTENDS: System.Dynamic.DynamicMetaObject
FIELDS:
  private   readonly Newtonsoft.Json.Utilities.DynamicProxy<T>_proxy  // 0x0
PROPERTIES:
  NoArgs  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60002C3  System.Void .ctor(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy)
  RVA=-1  // not resolved  token=0x60002C4  System.Boolean IsOverridden(System.String method)
  RVA=-1  // not resolved  token=0x60002C5  System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder)
  RVA=-1  // not resolved  token=0x60002C6  System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value)
  RVA=-1  // not resolved  token=0x60002C7  System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder)
  RVA=-1  // not resolved  token=0x60002C8  System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder)
  RVA=-1  // not resolved  token=0x60002C9  System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args)
  RVA=-1  // not resolved  token=0x60002CA  System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args)
  RVA=-1  // not resolved  token=0x60002CB  System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args)
  RVA=-1  // not resolved  token=0x60002CC  System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg)
  RVA=-1  // not resolved  token=0x60002CD  System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder)
  RVA=-1  // not resolved  token=0x60002CE  System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  RVA=-1  // not resolved  token=0x60002CF  System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value)
  RVA=-1  // not resolved  token=0x60002D0  System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  RVA=-1  // not resolved  token=0x60002D2  System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args)
  RVA=-1  // not resolved  token=0x60002D3  System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args)
  RVA=-1  // not resolved  token=0x60002D4  System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value)
  RVA=-1  // not resolved  token=0x60002D5  System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder)
  RVA=-1  // not resolved  token=0x60002D6  System.Dynamic.DynamicMetaObject CallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke)
  RVA=-1  // not resolved  token=0x60002D7  System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke)
  RVA=-1  // not resolved  token=0x60002D8  System.Dynamic.DynamicMetaObject CallMethodReturnLast(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback)
  RVA=-1  // not resolved  token=0x60002D9  System.Dynamic.DynamicMetaObject CallMethodNoResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback)
  RVA=-1  // not resolved  token=0x60002DA  System.Dynamic.BindingRestrictions GetRestrictions()
  RVA=-1  // not resolved  token=0x60002DB  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicUtils
TYPE:  static class
TOKEN: 0x2000066
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x092BFFDC  token=0x60002FC  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowGetBinderMember
TYPE:  class
TOKEN: 0x2000068
SIZE:  0x30
EXTENDS: System.Dynamic.GetMemberBinder
FIELDS:
  private   readonly System.Dynamic.GetMemberBinder  _innerBinder  // 0x28
METHODS:
  RVA=0x092C1C78  token=0x6000302  System.Void .ctor(System.Dynamic.GetMemberBinder innerBinder)
  RVA=0x092C1B9C  token=0x6000303  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowSetBinderMember
TYPE:  class
TOKEN: 0x2000069
SIZE:  0x30
EXTENDS: System.Dynamic.SetMemberBinder
FIELDS:
  private   readonly System.Dynamic.SetMemberBinder  _innerBinder  // 0x28
METHODS:
  RVA=0x092C1DCC  token=0x6000304  System.Void .ctor(System.Dynamic.SetMemberBinder innerBinder)
  RVA=0x092C1CBC  token=0x6000305  System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowExpressionVisitor
TYPE:  class
TOKEN: 0x200006A
SIZE:  0x10
EXTENDS: System.Linq.Expressions.ExpressionVisitor
FIELDS:
  private   static readonly System.Object                   ErrorResult  // static @ 0x0
METHODS:
  RVA=0x092C1A50  token=0x6000306  System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node)
  RVA=0x0350B670  token=0x6000307  System.Void .ctor()
  RVA=0x092C1B2C  token=0x6000308  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.EnumInfo
TYPE:  class
TOKEN: 0x200006B
SIZE:  0x30
FIELDS:
  public    readonly System.Boolean                  IsFlags  // 0x10
  public    readonly System.UInt64[]                 Values  // 0x18
  public    readonly System.String[]                 Names  // 0x20
  public    readonly System.String[]                 ResolvedNames  // 0x28
METHODS:
  RVA=0x026BCEF0  token=0x6000309  System.Void .ctor(System.Boolean isFlags, System.UInt64[] values, System.String[] names, System.String[] resolvedNames)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.EnumUtils
TYPE:  static class
TOKEN: 0x200006C
SIZE:  0x10
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo>ValuesAndNamesPerEnum  // static @ 0x0
  private   static  Newtonsoft.Json.Serialization.CamelCaseNamingStrategy_camelCaseNamingStrategy  // static @ 0x8
METHODS:
  RVA=0x026BB510  token=0x600030A  Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key)
  RVA=0x092C0280  token=0x600030B  System.Boolean TryToString(System.Type enumType, System.Object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String& name)
  RVA=0x092C0044  token=0x600030C  System.String InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, System.UInt64 result)
  RVA=0x02905550  token=0x600030D  Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType)
  RVA=0x026BB950  token=0x600030E  System.UInt64 ToUInt64(System.Object value)
  RVA=0x02476130  token=0x600030F  System.Object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String value, System.Boolean disallowNumber)
  RVA=0x092C01BC  token=0x6000310  System.Nullable<System.Int32> MatchName(System.String value, System.String[] enumNames, System.String[] resolvedNames, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison)
  RVA=0x02476360  token=0x6000311  System.Nullable<System.Int32> FindIndexByName(System.String[] enumNames, System.String value, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison)
  RVA=0x03B37790  token=0x6000312  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.FSharpFunction
TYPE:  class
TOKEN: 0x200006E
SIZE:  0x20
FIELDS:
  private   readonly System.Object                   _instance  // 0x10
  private   readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_invoker  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000316  System.Void .ctor(System.Object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker)
  RVA=0x092C0408  token=0x6000317  System.Object Invoke(System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.FSharpUtils
TYPE:  class
TOKEN: 0x200006F
SIZE:  0x70
FIELDS:
  private   static readonly System.Object                   Lock  // static @ 0x0
  private   static  Newtonsoft.Json.Utilities.FSharpUtils_instance  // static @ 0x8
  private           System.Reflection.MethodInfo    _ofSeq  // 0x10
  private           System.Type                     _mapType  // 0x18
  private           System.Reflection.Assembly      <FSharpCoreAssembly>k__BackingField  // 0x20
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><IsUnion>k__BackingField  // 0x28
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><GetUnionCases>k__BackingField  // 0x30
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionTagReader>k__BackingField  // 0x38
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionReader>k__BackingField  // 0x40
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionConstructor>k__BackingField  // 0x48
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoDeclaringType>k__BackingField  // 0x50
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoName>k__BackingField  // 0x58
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoTag>k__BackingField  // 0x60
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><GetUnionCaseInfoFields>k__BackingField  // 0x68
PROPERTIES:
  Instance  get=0x092C0E28
  FSharpCoreAssembly  set=0x04271930
  IsUnion  get=0x03D4EAC0  set=0x02C92F10
  GetUnionCases  get=0x01003830  set=0x04270470
  PreComputeUnionTagReader  get=0x03D4E2A0  set=0x0388FF30
  PreComputeUnionReader  get=0x03D4E2B0  set=0x03CB2D80
  PreComputeUnionConstructor  get=0x03D4EA70  set=0x02692290
  GetUnionCaseInfoDeclaringType  get=0x03D4EAF0  set=0x02C926C0
  GetUnionCaseInfoName  get=0x03D4EAA0  set=0x03081D30
  GetUnionCaseInfoTag  get=0x03D4EB00  set=0x039274B0
  GetUnionCaseInfoFields  get=0x03D4EAB0  set=0x038C5570
METHODS:
  RVA=0x092C0A48  token=0x6000318  System.Void .ctor(System.Reflection.Assembly fsharpCoreAssembly)
  RVA=0x092C07C8  token=0x600032D  System.Void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly)
  RVA=0x092C097C  token=0x600032E  System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, System.String methodName, System.Reflection.BindingFlags bindingFlags)
  RVA=0x092C0438  token=0x600032F  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(System.Type type, System.String methodName)
  RVA=0x092C0708  token=0x6000330  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(System.Type t)
  RVA=0x092C05B8  token=0x6000331  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(System.Type keyType, System.Type valueType)
  RVA=-1  // generic def  token=0x6000332  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator()
  RVA=0x092C09D8  token=0x6000333  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ImmutableCollectionsUtils
TYPE:  static class
TOKEN: 0x2000073
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>ArrayContractImmutableCollectionDefinitions  // static @ 0x0
  private   static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>DictionaryContractImmutableCollectionDefinitions  // static @ 0x8
METHODS:
  RVA=0x0308DDD0  token=0x600033B  System.Boolean TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator)
  RVA=0x0308EEC0  token=0x600033C  System.Boolean TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator)
  RVA=0x03704CB0  token=0x600033D  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BufferUtils
TYPE:  static class
TOKEN: 0x2000078
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x029075A0  token=0x600034D  System.Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 minSize)
  RVA=0x030AB590  token=0x600034E  System.Void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer)
  RVA=0x092B96EC  token=0x600034F  System.Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 size, System.Char[] buffer)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.JavaScriptUtils
TYPE:  static class
TOKEN: 0x2000079
SIZE:  0x10
FIELDS:
  private   static readonly System.Boolean[]                SingleQuoteCharEscapeFlags  // static @ 0x0
  private   static readonly System.Boolean[]                DoubleQuoteCharEscapeFlags  // static @ 0x8
  private   static readonly System.Boolean[]                HtmlCharEscapeFlags  // static @ 0x10
METHODS:
  RVA=0x03216A60  token=0x6000350  System.Void .cctor()
  RVA=0x026979C0  token=0x6000351  System.Boolean[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, System.Char quoteChar)
  RVA=0x024E6A40  token=0x6000352  System.Boolean ShouldEscapeJavaScriptString(System.String s, System.Boolean[] charEscapeFlags)
  RVA=0x02905EF0  token=0x6000353  System.Void WriteEscapedJavaScriptString(System.IO.TextWriter writer, System.String s, System.Char delimiter, System.Boolean appendDelimiters, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[]& writeBuffer)
  RVA=0x092C0E78  token=0x6000354  System.String ToEscapedJavaScriptString(System.String value, System.Char delimiter, System.Boolean appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  RVA=0x02906D50  token=0x6000355  System.Int32 FirstCharToEscape(System.String s, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  RVA=0x092C115C  token=0x6000356  System.Boolean TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, System.DateTime& dateTime, System.String& errorMessage)
  RVA=0x092C1000  token=0x6000357  System.Boolean TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, System.Nullable<System.Int64>& integer, System.String& errorMessage)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.JsonTokenUtils
TYPE:  static class
TOKEN: 0x200007A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0269A4F0  token=0x6000358  System.Boolean IsEndToken(Newtonsoft.Json.JsonToken token)
  RVA=0x0269A900  token=0x6000359  System.Boolean IsStartToken(Newtonsoft.Json.JsonToken token)
  RVA=0x037E7D50  token=0x600035A  System.Boolean IsPrimitiveToken(Newtonsoft.Json.JsonToken token)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory
TYPE:  class
TOKEN: 0x200007B
SIZE:  0x10
EXTENDS: Newtonsoft.Json.Utilities.ReflectionDelegateFactory
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory_instance  // static @ 0x0
PROPERTIES:
  Instance  get=0x092C15F0
METHODS:
  RVA=0x038DD3E0  token=0x600035C  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method)
  RVA=-1  // generic def  token=0x600035D  Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method)
  RVA=-1  // generic def  token=0x600035E  System.Func<T> CreateDefaultConstructor(System.Type type)
  RVA=-1  // generic def  token=0x600035F  System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo)
  RVA=-1  // generic def  token=0x6000360  System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo)
  RVA=-1  // generic def  token=0x6000361  System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo)
  RVA=-1  // generic def  token=0x6000362  System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo)
  RVA=0x0350B670  token=0x6000363  System.Void .ctor()
  RVA=0x03D1B4D0  token=0x6000364  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MathUtils
TYPE:  static class
TOKEN: 0x2000083
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02905A20  token=0x6000376  System.Int32 IntLength(System.UInt64 i)
  RVA=0x092C16E0  token=0x6000377  System.Char IntToHex(System.Int32 n)
  RVA=0x092C1640  token=0x6000378  System.Boolean ApproxEquals(System.Double d1, System.Double d2)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MethodCall`2
TYPE:  sealed class
TOKEN: 0x2000084
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000379  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600037A  TResult Invoke(T target, System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MiscellaneousUtils
TYPE:  static class
TOKEN: 0x2000085
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03387590  token=0x600037B  System.Boolean ValueEquals(System.Object objA, System.Object objB)
  RVA=0x092C1778  token=0x600037C  System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(System.String paramName, System.Object actualValue, System.String message)
  RVA=0x092C19CC  token=0x600037D  System.String ToString(System.Object value)
  RVA=0x092C16F0  token=0x600037E  System.Int32 ByteArrayCompare(System.Byte[] a1, System.Byte[] a2)
  RVA=0x092C1880  token=0x600037F  System.String GetPrefix(System.String qualifiedName)
  RVA=0x092C1854  token=0x6000380  System.String GetLocalName(System.String qualifiedName)
  RVA=0x092C18AC  token=0x6000381  System.Void GetQualifiedNameParts(System.String qualifiedName, System.String& prefix, System.String& localName)
  RVA=0x092C1950  token=0x6000382  System.Text.RegularExpressions.RegexOptions GetRegexOptions(System.String optionsText)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionDelegateFactory
TYPE:  abstract class
TOKEN: 0x2000086
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000383  System.Func<T,System.Object> CreateGet(System.Reflection.MemberInfo memberInfo)
  RVA=-1  // generic def  token=0x6000384  System.Action<T,System.Object> CreateSet(System.Reflection.MemberInfo memberInfo)
  RVA=-1  // abstract  token=0x6000385  Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method)
  RVA=-1  // abstract  token=0x6000386  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method)
  RVA=-1  // abstract  token=0x6000387  System.Func<T> CreateDefaultConstructor(System.Type type)
  RVA=-1  // abstract  token=0x6000388  System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo)
  RVA=-1  // abstract  token=0x6000389  System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo)
  RVA=-1  // abstract  token=0x600038A  System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo)
  RVA=-1  // abstract  token=0x600038B  System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo)
  RVA=0x0350B670  token=0x600038C  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionMember
TYPE:  class
TOKEN: 0x2000087
SIZE:  0x28
FIELDS:
  private           System.Type                     <MemberType>k__BackingField  // 0x10
  private           System.Func<System.Object,System.Object><Getter>k__BackingField  // 0x18
  private           System.Action<System.Object,System.Object><Setter>k__BackingField  // 0x20
PROPERTIES:
  MemberType  get=0x020B7B20  set=0x0426FEE0
  Getter  get=0x01041090  set=0x022C3A90
  Setter  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0350B670  token=0x6000393  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionObject
TYPE:  class
TOKEN: 0x2000088
SIZE:  0x20
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object><Creator>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember><Members>k__BackingField  // 0x18
PROPERTIES:
  Creator  get=0x020B7B20
  Members  get=0x01041090
METHODS:
  RVA=0x092C266C  token=0x6000396  System.Void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator)
  RVA=0x092C2574  token=0x6000397  System.Object GetValue(System.Object target, System.String member)
  RVA=0x092C25E8  token=0x6000398  System.Void SetValue(System.Object target, System.String member, System.Object value)
  RVA=0x092C251C  token=0x6000399  System.Type GetType(System.String member)
  RVA=0x092C1E10  token=0x600039A  Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.String[] memberNames)
  RVA=0x092C1E20  token=0x600039B  Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, System.String[] memberNames)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionUtils
TYPE:  static class
TOKEN: 0x200008C
SIZE:  0x10
FIELDS:
  public    static readonly System.Type[]                   EmptyTypes  // static @ 0x0
METHODS:
  RVA=0x03CFF250  token=0x60003A2  System.Void .cctor()
  RVA=0x02541360  token=0x60003A3  System.Boolean IsVirtual(System.Reflection.PropertyInfo propertyInfo)
  RVA=0x02479E00  token=0x60003A4  System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo)
  RVA=0x02479FB0  token=0x60003A5  System.Boolean IsPublic(System.Reflection.PropertyInfo property)
  RVA=0x02419740  token=0x60003A6  System.Type GetObjectType(System.Object v)
  RVA=0x092C2DB8  token=0x60003A7  System.String GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder)
  RVA=0x092C2CA8  token=0x60003A8  System.String GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder)
  RVA=0x092C2F74  token=0x60003A9  System.String RemoveAssemblyDetails(System.String fullyQualifiedTypeName)
  RVA=0x02475D80  token=0x60003AA  System.Boolean HasDefaultConstructor(System.Type t, System.Boolean nonPublic)
  RVA=0x024756B0  token=0x60003AB  System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t)
  RVA=0x02475700  token=0x60003AC  System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, System.Boolean nonPublic)
  RVA=0x02476A80  token=0x60003AD  System.Boolean IsNullable(System.Type t)
  RVA=0x02478570  token=0x60003AE  System.Boolean IsNullableType(System.Type t)
  RVA=0x02475900  token=0x60003AF  System.Type EnsureNotNullableType(System.Type t)
  RVA=0x02477850  token=0x60003B0  System.Type EnsureNotByRefType(System.Type t)
  RVA=0x0308EE30  token=0x60003B1  System.Boolean IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition)
  RVA=0x02478010  token=0x60003B2  System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition)
  RVA=0x02478400  token=0x60003B3  System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, System.Type& implementingType)
  RVA=0x0308EB80  token=0x60003B4  System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition)
  RVA=0x0308EBF0  token=0x60003B5  System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, System.Type& implementingType)
  RVA=0x0308ECD0  token=0x60003B6  System.Boolean InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, System.Type& implementingType)
  RVA=0x0308F0C0  token=0x60003B7  System.Type GetCollectionItemType(System.Type type)
  RVA=0x092C29C0  token=0x60003B8  System.Void GetDictionaryKeyValueTypes(System.Type dictionaryType, System.Type& keyType, System.Type& valueType)
  RVA=0x024E5800  token=0x60003B9  System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member)
  RVA=0x024E7370  token=0x60003BA  System.Boolean IsByRefLikeType(System.Type type)
  RVA=0x02478AE0  token=0x60003BB  System.Boolean IsIndexedProperty(System.Reflection.PropertyInfo property)
  RVA=0x0232C7D0  token=0x60003BC  System.Object GetMemberValue(System.Reflection.MemberInfo member, System.Object target)
  RVA=0x023279A0  token=0x60003BD  System.Void SetMemberValue(System.Reflection.MemberInfo member, System.Object target, System.Object value)
  RVA=0x024E5CE0  token=0x60003BE  System.Boolean CanReadMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic)
  RVA=0x024E5E10  token=0x60003BF  System.Boolean CanSetMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic, System.Boolean canSetReadOnly)
  RVA=0x025E1470  token=0x60003C0  System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr)
  RVA=0x03C85780  token=0x60003C1  System.Boolean IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr)
  RVA=-1  // generic def  token=0x60003C2  T GetAttribute(System.Object attributeProvider)
  RVA=-1  // generic def  token=0x60003C3  T GetAttribute(System.Object attributeProvider, System.Boolean inherit)
  RVA=-1  // generic def  token=0x60003C4  T[] GetAttributes(System.Object attributeProvider, System.Boolean inherit)
  RVA=0x024E32B0  token=0x60003C5  System.Attribute[] GetAttributes(System.Object attributeProvider, System.Type attributeType, System.Boolean inherit)
  RVA=0x027BCFF0  token=0x60003C6  Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(System.String fullyQualifiedTypeName)
  RVA=0x027BEBA0  token=0x60003C7  System.Nullable<System.Int32> GetAssemblyDelimiterIndex(System.String fullyQualifiedTypeName)
  RVA=0x024E2400  token=0x60003C8  System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo)
  RVA=0x025E1360  token=0x60003C9  System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr)
  RVA=0x025E1160  token=0x60003CA  System.Void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr)
  RVA=0x02478680  token=0x60003CB  System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr)
  RVA=0x034EF0B0  token=0x60003CC  System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag)
  RVA=0x02478B40  token=0x60003CD  System.Void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr)
  RVA=0x092C2E7C  token=0x60003CE  System.Boolean IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, System.String method)
  RVA=0x092C26FC  token=0x60003CF  System.Object GetDefaultValue(System.Type type)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringBuffer
TYPE:  sealed struct
TOKEN: 0x2000092
SIZE:  0x20
FIELDS:
  private           System.Char[]                   _buffer  // 0x10
  private           System.Int32                    _position  // 0x18
PROPERTIES:
  Position  get=0x03D516F0  set=0x03D51710
  IsEmpty  get=0x02361C20
  InternalBuffer  get=0x020C61B0
METHODS:
  RVA=0x02905860  token=0x60003E2  System.Void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 initalSize)
  RVA=0x04271F74  token=0x60003E3  System.Void .ctor(System.Char[] buffer)
  RVA=0x033B9D00  token=0x60003E4  System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char value)
  RVA=0x033B9D60  token=0x60003E5  System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer, System.Int32 startIndex, System.Int32 count)
  RVA=0x030AB5E0  token=0x60003E6  System.Void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool)
  RVA=0x092C3090  token=0x60003E7  System.Void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 appendLength)
  RVA=0x092C30FC  token=0x60003E8  System.String ToString()
  RVA=0x092C310C  token=0x60003E9  System.String ToString(System.Int32 start, System.Int32 length)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringReference
TYPE:  sealed struct
TOKEN: 0x2000093
SIZE:  0x20
FIELDS:
  private   readonly System.Char[]                   _chars  // 0x10
  private   readonly System.Int32                    _startIndex  // 0x18
  private   readonly System.Int32                    _length  // 0x1c
PROPERTIES:
  Item  get=0x029062E0
  Chars  get=0x020C61B0
  StartIndex  get=0x03D516F0
  Length  get=0x03D4FBF0
METHODS:
  RVA=0x0426FA34  token=0x60003EF  System.Void .ctor(System.Char[] chars, System.Int32 startIndex, System.Int32 length)
  RVA=0x0426F9F0  token=0x60003F0  System.String ToString()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringReferenceExtensions
TYPE:  static class
TOKEN: 0x2000094
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x092C31BC  token=0x60003F1  System.Int32 IndexOf(Newtonsoft.Json.Utilities.StringReference s, System.Char c, System.Int32 startIndex, System.Int32 length)
  RVA=0x092C323C  token=0x60003F2  System.Boolean StartsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text)
  RVA=0x092C3130  token=0x60003F3  System.Boolean EndsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringUtils
TYPE:  static class
TOKEN: 0x2000095
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x04271F60  token=0x60003F4  System.Boolean IsNullOrEmpty(System.String value)
  RVA=0x092C363C  token=0x60003F5  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0)
  RVA=0x092C36D4  token=0x60003F6  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1)
  RVA=0x092C355C  token=0x60003F7  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2)
  RVA=0x092C3460  token=0x60003F8  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3)
  RVA=0x092C33B8  token=0x60003F9  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object[] args)
  RVA=0x092C32C4  token=0x60003FA  System.IO.StringWriter CreateStringWriter(System.Int32 capacity)
  RVA=0x092C3A28  token=0x60003FB  System.Void ToCharAsUnicode(System.Char c, System.Char[] buffer)
  RVA=-1  // generic def  token=0x60003FC  TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, System.String testValue)
  RVA=0x092C387C  token=0x60003FD  System.String ToCamelCase(System.String s)
  RVA=0x092C3B08  token=0x60003FE  System.Char ToLower(System.Char c)
  RVA=0x092C3DC0  token=0x60003FF  System.String ToSnakeCase(System.String s)
  RVA=0x092C3AF8  token=0x6000400  System.String ToKebabCase(System.String s)
  RVA=0x092C3B78  token=0x6000401  System.String ToSeparatedCase(System.String s, System.Char separator)
  RVA=0x092C37B0  token=0x6000402  System.Boolean IsHighSurrogate(System.Char c)
  RVA=0x092C37FC  token=0x6000403  System.Boolean IsLowSurrogate(System.Char c)
  RVA=0x092C3794  token=0x6000404  System.Int32 IndexOf(System.String s, System.Char c)
  RVA=0x092C3848  token=0x6000405  System.Boolean StartsWith(System.String source, System.Char value)
  RVA=0x092C3380  token=0x6000406  System.Boolean EndsWith(System.String source, System.Char value)
  RVA=0x027BD180  token=0x6000407  System.String Trim(System.String s, System.Int32 start, System.Int32 length)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StructMultiKey`2
TYPE:  sealed struct
TOKEN: 0x2000098
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public    readonly T1                              Value1  // 0x0
  public    readonly T2                              Value2  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600040B  System.Void .ctor(T1 v1, T2 v2)
  RVA=-1  // not resolved  token=0x600040C  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x600040D  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x600040E  System.Boolean Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ThreadSafeStore`2
TYPE:  class
TOKEN: 0x2000099
FIELDS:
  private   readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue>_concurrentStore  // 0x0
  private   readonly System.Func<TKey,TValue>        _creator  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600040F  System.Void .ctor(System.Func<TKey,TValue> creator)
  RVA=-1  // not resolved  token=0x6000410  TValue Get(TKey key)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.TypeExtensions
TYPE:  static class
TOKEN: 0x200009A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x023206F0  token=0x6000411  System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo)
  RVA=0x092C3DF0  token=0x6000412  System.Boolean ContainsGenericParameters(System.Type type)
  RVA=0x02478640  token=0x6000413  System.Boolean IsInterface(System.Type type)
  RVA=0x02478620  token=0x6000414  System.Boolean IsGenericType(System.Type type)
  RVA=0x02478660  token=0x6000415  System.Boolean IsGenericTypeDefinition(System.Type type)
  RVA=0x024E7600  token=0x6000416  System.Type BaseType(System.Type type)
  RVA=0x092C3DD0  token=0x6000417  System.Reflection.Assembly Assembly(System.Type type)
  RVA=0x02477240  token=0x6000418  System.Boolean IsEnum(System.Type type)
  RVA=0x0308ECB0  token=0x6000419  System.Boolean IsClass(System.Type type)
  RVA=0x02476B00  token=0x600041A  System.Boolean IsSealed(System.Type type)
  RVA=0x02476B50  token=0x600041B  System.Boolean IsAbstract(System.Type type)
  RVA=0x092C4078  token=0x600041C  System.Boolean IsVisible(System.Type type)
  RVA=0x0247C260  token=0x600041D  System.Boolean IsValueType(System.Type type)
  RVA=0x024E7480  token=0x600041E  System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces, System.Type& match)
  RVA=0x04275F58  token=0x600041F  System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces)
  RVA=0x092C3E10  token=0x6000420  System.Boolean ImplementInterface(System.Type type, System.Type interfaceType)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ValidationUtils
TYPE:  static class
TOKEN: 0x200009B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02327960  token=0x6000421  System.Void ArgumentNotNull(System.Object value, System.String parameterName)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.NotNullAttribute
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.NotNullWhenAttribute
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.Boolean                  <ReturnValue>k__BackingField  // 0x10
METHODS:
  RVA=0x03D4E960  token=0x6000007  System.Void .ctor(System.Boolean returnValue)
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableAttribute
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Byte[]                   NullableFlags  // 0x10
METHODS:
  RVA=0x03134A00  token=0x6000003  System.Void .ctor(System.Byte )
  RVA=0x0426FEE0  token=0x6000004  System.Void .ctor(System.Byte[] )
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableContextAttribute
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Byte                     Flag  // 0x10
METHODS:
  RVA=0x03D4E960  token=0x6000005  System.Void .ctor(System.Byte )
END_CLASS

