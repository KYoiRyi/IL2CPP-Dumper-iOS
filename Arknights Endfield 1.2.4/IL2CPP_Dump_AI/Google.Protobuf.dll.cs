// ========================================================
// Dumped by @desirepro
// Assembly: Google.Protobuf.dll
// Classes:  318
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

CLASS: <FromStreamAsyncCore>d__0
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x50
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Google.Protobuf.ByteString><>t__builder  // 0x18
  public            System.IO.Stream                stream  // 0x30
  public            System.Threading.CancellationTokencancellationToken  // 0x38
  private           System.IO.MemoryStream          <memoryStream>5__2  // 0x40
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x48
METHODS:
  RVA=0x0855372C  token=0x6000035  System.Void MoveNext()
  RVA=0x08553A98  token=0x6000036  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: OutOfSpaceException
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x90
EXTENDS: System.IO.IOException
FIELDS:
METHODS:
  RVA=0x085528A4  token=0x60000B7  System.Void .ctor()
END_CLASS

CLASS: ExtensionComparer
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
  private   static  Google.Protobuf.ExtensionRegistry.ExtensionComparerInstance  // static @ 0x0
METHODS:
  RVA=0x08540FA4  token=0x60000D4  System.Boolean Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b)
  RVA=0x08541078  token=0x60000D5  System.Int32 GetHashCode(Google.Protobuf.Extension a)
  RVA=0x0350B670  token=0x60000D6  System.Void .ctor()
  RVA=0x08541100  token=0x60000D7  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.ExtensionRegistry.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>,Google.Protobuf.ObjectIntPair<System.Type>><>9__3_0  // static @ 0x8
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>,Google.Protobuf.Extension><>9__3_1  // static @ 0x10
METHODS:
  RVA=0x08554394  token=0x60000D8  System.Void .cctor()
  RVA=0x0350B670  token=0x60000D9  System.Void .ctor()
  RVA=0x08554070  token=0x60000DA  Google.Protobuf.ObjectIntPair<System.Type> <.ctor>b__3_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> k)
  RVA=0x085540B0  token=0x60000DB  Google.Protobuf.Extension <.ctor>b__3_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> v)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000015
FIELDS:
  public    static readonly Google.Protobuf.ExtensionSet.<>c<TTarget><>9  // static @ 0x0
  public    static  System.Func<Google.Protobuf.IExtensionValue,System.Boolean><>9__8_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60000F0  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60000F1  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60000F2  System.Boolean <IsInitialized>b__8_0(Google.Protobuf.IExtensionValue v)
END_CLASS

CLASS: <>c__DisplayClass3_0`1
TYPE:  sealed class
TOKEN: 0x200001B
FIELDS:
  public            Google.Protobuf.FieldCodec<T>   nestedCoded  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600013A  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600013B  System.Nullable<T> <GetReader>b__0(Google.Protobuf.ParseContext& ctx)
END_CLASS

CLASS: WrapperCodecs
TYPE:  static class
TOKEN: 0x200001A
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Object>Codecs  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Object>Readers  // static @ 0x8
METHODS:
  RVA=-1  // generic def  token=0x6000134  Google.Protobuf.FieldCodec<T> GetCodec()
  RVA=-1  // generic def  token=0x6000135  Google.Protobuf.ValueReader<System.Nullable<T>> GetReader()
  RVA=-1  // generic def  token=0x6000136  T Read(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // generic def  token=0x6000137  System.Void Write(Google.Protobuf.WriteContext& ctx, T value, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // generic def  token=0x6000138  System.Int32 CalculateSize(T value, Google.Protobuf.FieldCodec<T> codec)
  RVA=0x0855445C  token=0x6000139  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c  <>9  // static @ 0x0
  public    static  Google.Protobuf.ValueReader<System.String><>9__16_0  // static @ 0x8
  public    static  Google.Protobuf.ValueWriter<System.String><>9__16_1  // static @ 0x10
  public    static  Google.Protobuf.ValueReader<Google.Protobuf.ByteString><>9__17_0  // static @ 0x18
  public    static  Google.Protobuf.ValueWriter<Google.Protobuf.ByteString><>9__17_1  // static @ 0x20
  public    static  Google.Protobuf.ValueReader<System.Boolean><>9__18_0  // static @ 0x28
  public    static  Google.Protobuf.ValueWriter<System.Boolean><>9__18_1  // static @ 0x30
  public    static  Google.Protobuf.ValueReader<System.Int32><>9__19_0  // static @ 0x38
  public    static  Google.Protobuf.ValueWriter<System.Int32><>9__19_1  // static @ 0x40
  public    static  Google.Protobuf.ValueReader<System.Int32><>9__20_0  // static @ 0x48
  public    static  Google.Protobuf.ValueWriter<System.Int32><>9__20_1  // static @ 0x50
  public    static  Google.Protobuf.ValueReader<System.UInt32><>9__21_0  // static @ 0x58
  public    static  Google.Protobuf.ValueWriter<System.UInt32><>9__21_1  // static @ 0x60
  public    static  Google.Protobuf.ValueReader<System.Int32><>9__22_0  // static @ 0x68
  public    static  Google.Protobuf.ValueWriter<System.Int32><>9__22_1  // static @ 0x70
  public    static  Google.Protobuf.ValueReader<System.UInt32><>9__23_0  // static @ 0x78
  public    static  Google.Protobuf.ValueWriter<System.UInt32><>9__23_1  // static @ 0x80
  public    static  Google.Protobuf.ValueReader<System.Int64><>9__24_0  // static @ 0x88
  public    static  Google.Protobuf.ValueWriter<System.Int64><>9__24_1  // static @ 0x90
  public    static  Google.Protobuf.ValueReader<System.Int64><>9__25_0  // static @ 0x98
  public    static  Google.Protobuf.ValueWriter<System.Int64><>9__25_1  // static @ 0xa0
  public    static  Google.Protobuf.ValueReader<System.UInt64><>9__26_0  // static @ 0xa8
  public    static  Google.Protobuf.ValueWriter<System.UInt64><>9__26_1  // static @ 0xb0
  public    static  Google.Protobuf.ValueReader<System.Int64><>9__27_0  // static @ 0xb8
  public    static  Google.Protobuf.ValueWriter<System.Int64><>9__27_1  // static @ 0xc0
  public    static  Google.Protobuf.ValueReader<System.UInt64><>9__28_0  // static @ 0xc8
  public    static  Google.Protobuf.ValueWriter<System.UInt64><>9__28_1  // static @ 0xd0
  public    static  Google.Protobuf.ValueReader<System.Single><>9__29_0  // static @ 0xd8
  public    static  Google.Protobuf.ValueWriter<System.Single><>9__29_1  // static @ 0xe0
  public    static  Google.Protobuf.ValueReader<System.Double><>9__30_0  // static @ 0xe8
  public    static  Google.Protobuf.ValueWriter<System.Double><>9__30_1  // static @ 0xf0
METHODS:
  RVA=0x03D11570  token=0x600013C  System.Void .cctor()
  RVA=0x0350B670  token=0x600013D  System.Void .ctor()
  RVA=0x023C3EC0  token=0x600013E  System.String <ForString>b__16_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x03874840  token=0x600013F  System.Void <ForString>b__16_1(Google.Protobuf.WriteContext& ctx, System.String value)
  RVA=0x08553B0C  token=0x6000140  Google.Protobuf.ByteString <ForBytes>b__17_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553B18  token=0x6000141  System.Void <ForBytes>b__17_1(Google.Protobuf.WriteContext& ctx, Google.Protobuf.ByteString value)
  RVA=0x023C4CD0  token=0x6000142  System.Boolean <ForBool>b__18_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553AF8  token=0x6000143  System.Void <ForBool>b__18_1(Google.Protobuf.WriteContext& ctx, System.Boolean value)
  RVA=0x023C0C70  token=0x6000144  System.Int32 <ForInt32>b__19_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553BB0  token=0x6000145  System.Void <ForInt32>b__19_1(Google.Protobuf.WriteContext& output, System.Int32 value)
  RVA=0x08553BE4  token=0x6000146  System.Int32 <ForSInt32>b__20_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553C08  token=0x6000147  System.Void <ForSInt32>b__20_1(Google.Protobuf.WriteContext& output, System.Int32 value)
  RVA=0x08553B4C  token=0x6000148  System.UInt32 <ForFixed32>b__21_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553B5C  token=0x6000149  System.Void <ForFixed32>b__21_1(Google.Protobuf.WriteContext& output, System.UInt32 value)
  RVA=0x08553B4C  token=0x600014A  System.Int32 <ForSFixed32>b__22_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553BC0  token=0x600014B  System.Void <ForSFixed32>b__22_1(Google.Protobuf.WriteContext& output, System.Int32 value)
  RVA=0x023C2480  token=0x600014C  System.UInt32 <ForUInt32>b__23_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553C54  token=0x600014D  System.Void <ForUInt32>b__23_1(Google.Protobuf.WriteContext& output, System.UInt32 value)
  RVA=0x023C4620  token=0x600014E  System.Int64 <ForInt64>b__24_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x03D42A70  token=0x600014F  System.Void <ForInt64>b__24_1(Google.Protobuf.WriteContext& output, System.Int64 value)
  RVA=0x08553C18  token=0x6000150  System.Int64 <ForSInt64>b__25_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553C40  token=0x6000151  System.Void <ForSInt64>b__25_1(Google.Protobuf.WriteContext& output, System.Int64 value)
  RVA=0x08553B6C  token=0x6000152  System.UInt64 <ForFixed64>b__26_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553B7C  token=0x6000153  System.Void <ForFixed64>b__26_1(Google.Protobuf.WriteContext& output, System.UInt64 value)
  RVA=0x08553B6C  token=0x6000154  System.Int64 <ForSFixed64>b__27_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553BD0  token=0x6000155  System.Void <ForSFixed64>b__27_1(Google.Protobuf.WriteContext& output, System.Int64 value)
  RVA=0x023C5470  token=0x6000156  System.UInt64 <ForUInt64>b__28_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553C64  token=0x6000157  System.Void <ForUInt64>b__28_1(Google.Protobuf.WriteContext& output, System.UInt64 value)
  RVA=0x08553B90  token=0x6000158  System.Single <ForFloat>b__29_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553BA0  token=0x6000159  System.Void <ForFloat>b__29_1(Google.Protobuf.WriteContext& output, System.Single value)
  RVA=0x08553B2C  token=0x600015A  System.Double <ForDouble>b__30_0(Google.Protobuf.ParseContext& ctx)
  RVA=0x08553B3C  token=0x600015B  System.Void <ForDouble>b__30_1(Google.Protobuf.WriteContext& output, System.Double value)
END_CLASS

CLASS: <>c__DisplayClass31_0`1
TYPE:  sealed class
TOKEN: 0x200001D
FIELDS:
  public            System.Func<System.Int32,T>     fromInt32  // 0x0
  public            System.Func<T,System.Int32>     toInt32  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600015C  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600015D  T <ForEnum>b__0(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x600015E  System.Void <ForEnum>b__1(Google.Protobuf.WriteContext& output, T value)
  RVA=-1  // not resolved  token=0x600015F  System.Int32 <ForEnum>b__2(T value)
END_CLASS

CLASS: <>c__DisplayClass32_0`1
TYPE:  sealed class
TOKEN: 0x200001E
FIELDS:
  public            Google.Protobuf.MessageParser<T>parser  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000160  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000161  T <ForMessage>b__0(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x6000162  System.Void <ForMessage>b__2(Google.Protobuf.ParseContext& ctx, T& v)
END_CLASS

CLASS: <>c__32`1
TYPE:  sealed class
TOKEN: 0x200001F
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c__32<T><>9  // static @ 0x0
  public    static  Google.Protobuf.ValueWriter<T>  <>9__32_1  // static @ 0x0
  public    static  Google.Protobuf.FieldCodec.ValuesMerger<T><>9__32_3  // static @ 0x0
  public    static  System.Func<T,System.Int32>     <>9__32_4  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000163  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000164  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000165  System.Void <ForMessage>b__32_1(Google.Protobuf.WriteContext& output, T value)
  RVA=-1  // not resolved  token=0x6000166  System.Boolean <ForMessage>b__32_3(T& v, T v2)
  RVA=-1  // not resolved  token=0x6000167  System.Int32 <ForMessage>b__32_4(T message)
END_CLASS

CLASS: <>c__DisplayClass33_0`1
TYPE:  sealed class
TOKEN: 0x2000020
FIELDS:
  public            Google.Protobuf.MessageParser<T>parser  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000168  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000169  T <ForGroup>b__0(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x600016A  System.Void <ForGroup>b__2(Google.Protobuf.ParseContext& ctx, T& v)
END_CLASS

CLASS: <>c__33`1
TYPE:  sealed class
TOKEN: 0x2000021
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c__33<T><>9  // static @ 0x0
  public    static  Google.Protobuf.ValueWriter<T>  <>9__33_1  // static @ 0x0
  public    static  Google.Protobuf.FieldCodec.ValuesMerger<T><>9__33_3  // static @ 0x0
  public    static  System.Func<T,System.Int32>     <>9__33_4  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600016B  System.Void .cctor()
  RVA=-1  // not resolved  token=0x600016C  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600016D  System.Void <ForGroup>b__33_1(Google.Protobuf.WriteContext& output, T value)
  RVA=-1  // not resolved  token=0x600016E  System.Boolean <ForGroup>b__33_3(T& v, T v2)
  RVA=-1  // not resolved  token=0x600016F  System.Int32 <ForGroup>b__33_4(T message)
END_CLASS

CLASS: <>c__DisplayClass34_0`1
TYPE:  sealed class
TOKEN: 0x2000022
FIELDS:
  public            Google.Protobuf.FieldCodec<T>   nestedCodec  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000170  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000171  T <ForClassWrapper>b__0(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x6000172  System.Void <ForClassWrapper>b__1(Google.Protobuf.WriteContext& output, T value)
  RVA=-1  // not resolved  token=0x6000173  System.Void <ForClassWrapper>b__2(Google.Protobuf.ParseContext& ctx, T& v)
  RVA=-1  // not resolved  token=0x6000174  System.Int32 <ForClassWrapper>b__4(T value)
END_CLASS

CLASS: <>c__34`1
TYPE:  sealed class
TOKEN: 0x2000023
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c__34<T><>9  // static @ 0x0
  public    static  Google.Protobuf.FieldCodec.ValuesMerger<T><>9__34_3  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000175  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000176  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000177  System.Boolean <ForClassWrapper>b__34_3(T& v, T v2)
END_CLASS

CLASS: <>c__DisplayClass35_0`1
TYPE:  sealed class
TOKEN: 0x2000024
FIELDS:
  public            Google.Protobuf.FieldCodec<T>   nestedCodec  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000178  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000179  System.Void <ForStructWrapper>b__0(Google.Protobuf.WriteContext& output, System.Nullable<T> value)
  RVA=-1  // not resolved  token=0x600017A  System.Void <ForStructWrapper>b__1(Google.Protobuf.ParseContext& ctx, System.Nullable<T>& v)
  RVA=-1  // not resolved  token=0x600017B  System.Int32 <ForStructWrapper>b__3(System.Nullable<T> value)
END_CLASS

CLASS: <>c__35`1
TYPE:  sealed class
TOKEN: 0x2000025
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c__35<T><>9  // static @ 0x0
  public    static  Google.Protobuf.FieldCodec.ValuesMerger<System.Nullable<T>><>9__35_2  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600017C  System.Void .cctor()
  RVA=-1  // not resolved  token=0x600017D  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600017E  System.Boolean <ForStructWrapper>b__35_2(System.Nullable<T>& v, System.Nullable<T> v2)
END_CLASS

CLASS: InputMerger
TYPE:  sealed class
TOKEN: 0x2000029
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600019E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600019F  System.Void Invoke(Google.Protobuf.ParseContext& ctx, T& value)
  RVA=-1  // runtime  token=0x60001A0  System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60001A1  System.Void EndInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.IAsyncResult result)
END_CLASS

CLASS: ValuesMerger
TYPE:  sealed class
TOKEN: 0x200002A
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60001A2  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60001A3  System.Boolean Invoke(T& value, T other)
  RVA=-1  // runtime  token=0x60001A4  System.IAsyncResult BeginInvoke(T& value, T other, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60001A5  System.Boolean EndInvoke(T& value, System.IAsyncResult result)
END_CLASS

CLASS: <>c__DisplayClass38_0
TYPE:  sealed class
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    fixedSize  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001A6  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001A7  System.Int32 <.ctor>b__0(T _)
END_CLASS

CLASS: <>c__DisplayClass39_0
TYPE:  sealed class
TOKEN: 0x200002C
FIELDS:
  public            Google.Protobuf.ValueReader<T>  reader  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001A8  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001A9  System.Void <.ctor>b__0(Google.Protobuf.ParseContext& ctx, T& v)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200002D
FIELDS:
  public    static readonly Google.Protobuf.FieldCodec.<>c<T><>9  // static @ 0x0
  public    static  Google.Protobuf.FieldCodec.ValuesMerger<T><>9__39_1  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001AA  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60001AB  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001AC  System.Boolean <.ctor>b__39_1(T& v, T v2)
END_CLASS

CLASS: Node
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x18
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node><Children>k__BackingField  // 0x10
PROPERTIES:
  Children  get=0x020B7B20
METHODS:
  RVA=0x08552240  token=0x60001B8  System.Void .ctor()
END_CLASS

CLASS: Settings
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x28
FIELDS:
  private   static readonly Google.Protobuf.JsonFormatter.Settings<Default>k__BackingField  // static @ 0x0
  private   readonly System.Boolean                  <FormatDefaultValues>k__BackingField  // 0x10
  private   readonly Google.Protobuf.Reflection.TypeRegistry<TypeRegistry>k__BackingField  // 0x18
  private   readonly System.Boolean                  <FormatEnumsAsIntegers>k__BackingField  // 0x20
  private   readonly System.Boolean                  <PreserveProtoFieldNames>k__BackingField  // 0x21
PROPERTIES:
  Default  get=0x0855368C
  FormatDefaultValues  get=0x011797F0
  TypeRegistry  get=0x01041090
  FormatEnumsAsIntegers  get=0x03D4EF90
  PreserveProtoFieldNames  get=0x03D4F070
METHODS:
  RVA=0x085533A8  token=0x60001F6  System.Void .cctor()
  RVA=0x08553490  token=0x60001FB  System.Void .ctor(System.Boolean formatDefaultValues)
  RVA=0x0855355C  token=0x60001FC  System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  RVA=0x0855357C  token=0x60001FD  System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean formatEnumsAsIntegers, System.Boolean preserveProtoFieldNames)
  RVA=0x08552F70  token=0x60001FE  Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(System.Boolean formatDefaultValues)
  RVA=0x08553254  token=0x60001FF  Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  RVA=0x0855300C  token=0x6000200  Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(System.Boolean formatEnumsAsIntegers)
  RVA=0x08553130  token=0x6000201  Google.Protobuf.JsonFormatter.Settings WithPreserveProtoFieldNames(System.Boolean preserveProtoFieldNames)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200003C
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.JsonFormatter.OriginalEnumValueHelper.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Reflection.FieldInfo,System.Boolean><>9__2_0  // static @ 0x8
  public    static  System.Func<System.Reflection.FieldInfo,System.Boolean><>9__2_1  // static @ 0x10
  public    static  System.Func<System.Reflection.FieldInfo,System.Object><>9__2_2  // static @ 0x18
  public    static  System.Func<System.Reflection.FieldInfo,System.String><>9__2_3  // static @ 0x20
METHODS:
  RVA=0x085543F8  token=0x6000205  System.Void .cctor()
  RVA=0x0350B670  token=0x6000206  System.Void .ctor()
  RVA=0x08553C78  token=0x6000207  System.Boolean <GetNameMapping>b__2_0(System.Reflection.FieldInfo f)
  RVA=0x08553C98  token=0x6000208  System.Boolean <GetNameMapping>b__2_1(System.Reflection.FieldInfo f)
  RVA=0x08553CFC  token=0x6000209  System.Object <GetNameMapping>b__2_2(System.Reflection.FieldInfo f)
  RVA=0x08553D1C  token=0x600020A  System.String <GetNameMapping>b__2_3(System.Reflection.FieldInfo f)
END_CLASS

CLASS: OriginalEnumValueHelper
TYPE:  static class
TOKEN: 0x200003B
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Object,System.String>>dictionaries  // static @ 0x0
METHODS:
  RVA=0x08552614  token=0x6000202  System.String GetOriginalName(System.Object value)
  RVA=0x085522B8  token=0x6000203  System.Collections.Generic.Dictionary<System.Object,System.String> GetNameMapping(System.Type enumType)
  RVA=0x08552818  token=0x6000204  System.Void .cctor()
END_CLASS

CLASS: Settings
TYPE:  sealed class
TOKEN: 0x200003E
SIZE:  0x28
FIELDS:
  private   static readonly Google.Protobuf.JsonParser.Settings<Default>k__BackingField  // static @ 0x0
  private   readonly System.Int32                    <RecursionLimit>k__BackingField  // 0x10
  private   readonly Google.Protobuf.Reflection.TypeRegistry<TypeRegistry>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreUnknownFields>k__BackingField  // 0x20
PROPERTIES:
  Default  get=0x085536DC
  RecursionLimit  get=0x03D4E340
  TypeRegistry  get=0x01041090
  IgnoreUnknownFields  get=0x03D4EF90
METHODS:
  RVA=0x0855341C  token=0x600022C  System.Void .cctor()
  RVA=0x08553604  token=0x6000230  System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean ignoreUnknownFields)
  RVA=0x08553504  token=0x6000231  System.Void .ctor(System.Int32 recursionLimit)
  RVA=0x085534E8  token=0x6000232  System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry)
  RVA=0x085530A8  token=0x6000233  Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(System.Boolean ignoreUnknownFields)
  RVA=0x085531CC  token=0x6000234  Google.Protobuf.JsonParser.Settings WithRecursionLimit(System.Int32 recursionLimit)
  RVA=0x085532F0  token=0x6000235  Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.JsonParser.<>c  <>9  // static @ 0x0
METHODS:
  RVA=0x08554330  token=0x6000236  System.Void .cctor()
  RVA=0x0350B670  token=0x6000237  System.Void .ctor()
  RVA=0x08553D98  token=0x6000238  System.Boolean <.cctor>b__41_0(Google.Protobuf.Reflection.EnumDescriptor ed)
  RVA=0x08553E0C  token=0x6000239  System.Void <.cctor>b__41_1(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08553E74  token=0x600023A  System.Void <.cctor>b__41_2(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08553EDC  token=0x600023B  System.Void <.cctor>b__41_3(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08553F0C  token=0x600023C  System.Void <.cctor>b__41_4(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08553FA8  token=0x600023D  System.Void <.cctor>b__41_5(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08553FD8  token=0x600023E  System.Void <.cctor>b__41_6(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08554008  token=0x600023F  System.Void <.cctor>b__41_7(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
END_CLASS

CLASS: TokenType
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonToken.TokenTypeNull  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeFalse  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeTrue  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeStringValue  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeNumber  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeName  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeStartObject  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeEndObject  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeStartArray  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeEndArray  // const
  public    static  Google.Protobuf.JsonToken.TokenTypeEndDocument  // const
METHODS:
END_CLASS

CLASS: JsonReplayTokenizer
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x38
EXTENDS: Google.Protobuf.JsonTokenizer
FIELDS:
  private   readonly System.Collections.Generic.IList<Google.Protobuf.JsonToken>tokens  // 0x20
  private   readonly Google.Protobuf.JsonTokenizer   nextTokenizer  // 0x28
  private           System.Int32                    nextTokenIndex  // 0x30
METHODS:
  RVA=0x0854E740  token=0x600025D  System.Void .ctor(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer)
  RVA=0x0854E6B0  token=0x600025E  Google.Protobuf.JsonToken NextImpl()
END_CLASS

CLASS: ContainerType
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeDocument  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeObject  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerTypeArray  // const
METHODS:
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateStartOfDocument  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateExpectedEndOfDocument  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateReaderExhausted  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectStart  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectBeforeColon  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterColon  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterProperty  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateObjectAfterComma  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayStart  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayAfterValue  // const
  public    static  Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateArrayAfterComma  // const
METHODS:
END_CLASS

CLASS: PushBackReader
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x20
FIELDS:
  private   readonly System.IO.TextReader            reader  // 0x10
  private           System.Nullable<System.Char>    nextChar  // 0x18
METHODS:
  RVA=0x0426FEE0  token=0x600026E  System.Void .ctor(System.IO.TextReader reader)
  RVA=0x08552EF4  token=0x600026F  System.Nullable<System.Char> Read()
  RVA=0x08552E64  token=0x6000270  System.Char ReadOrFail(System.String messageOnFailure)
  RVA=0x08552DB0  token=0x6000271  System.Void PushBack(System.Char c)
  RVA=0x08552D50  token=0x6000272  Google.Protobuf.InvalidJsonException CreateException(System.String message)
END_CLASS

CLASS: JsonTextTokenizer
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x38
EXTENDS: Google.Protobuf.JsonTokenizer
FIELDS:
  private   static readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.StateValueStates  // static @ 0x0
  private   readonly System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType>containerStack  // 0x20
  private   readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReaderreader  // 0x28
  private           Google.Protobuf.JsonTokenizer.JsonTextTokenizer.Statestate  // 0x30
METHODS:
  RVA=0x0854FF5C  token=0x600025F  System.Void .ctor(System.IO.TextReader reader)
  RVA=0x0854E994  token=0x6000260  Google.Protobuf.JsonToken NextImpl()
  RVA=0x0854FE84  token=0x6000261  System.Void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, System.String errorPrefix)
  RVA=0x0854FA24  token=0x6000262  System.String ReadString()
  RVA=0x0854F18C  token=0x6000263  System.Char ReadEscapedCharacter()
  RVA=0x0854FC5C  token=0x6000264  System.Char ReadUnicodeEscape()
  RVA=0x0854E840  token=0x6000265  System.Void ConsumeLiteral(System.String text)
  RVA=0x0854F6A8  token=0x6000266  System.Double ReadNumber(System.Char initialCharacter)
  RVA=0x0854F578  token=0x6000267  System.Nullable<System.Char> ReadInt(System.Text.StringBuilder builder)
  RVA=0x0854F4E4  token=0x6000268  System.Nullable<System.Char> ReadFrac(System.Text.StringBuilder builder)
  RVA=0x0854F2F8  token=0x6000269  System.Nullable<System.Char> ReadExp(System.Text.StringBuilder builder)
  RVA=0x0854E768  token=0x600026A  System.Nullable<System.Char> ConsumeDigits(System.Text.StringBuilder builder, System.Int32& count)
  RVA=0x0854FD94  token=0x600026B  System.Void ValidateAndModifyStateForValue(System.String errorPrefix)
  RVA=0x0854F054  token=0x600026C  System.Void PopContainer()
  RVA=0x0854FF20  token=0x600026D  System.Void .cctor()
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x200004A
SIZE:  0x18
FIELDS:
  public            Google.Protobuf.IMessage        message  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000294  System.Void .ctor()
  RVA=0x085540E8  token=0x6000295  System.Boolean <IsInitialized>b__0(Google.Protobuf.Reflection.FieldDescriptor f)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x200004D
FIELDS:
  public            System.Func<T>                  factory  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002B4  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60002B5  Google.Protobuf.IMessage <.ctor>b__0()
END_CLASS

CLASS: WireType
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x14
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Google.Protobuf.WireFormat.WireTypeVarint  // const
  public    static  Google.Protobuf.WireFormat.WireTypeFixed64  // const
  public    static  Google.Protobuf.WireFormat.WireTypeLengthDelimited  // const
  public    static  Google.Protobuf.WireFormat.WireTypeStartGroup  // const
  public    static  Google.Protobuf.WireFormat.WireTypeEndGroup  // const
  public    static  Google.Protobuf.WireFormat.WireTypeFixed32  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Any.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085623A0  token=0x60003C6  System.Void .cctor()
  RVA=0x0350B670  token=0x60003C7  System.Void .ctor()
  RVA=0x08561E8C  token=0x60003C8  Google.Protobuf.WellKnownTypes.Any <.cctor>b__40_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000065
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Api.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08562148  token=0x60003E7  System.Void .cctor()
  RVA=0x0350B670  token=0x60003E8  System.Void .ctor()
  RVA=0x08561FA4  token=0x60003E9  Google.Protobuf.WellKnownTypes.Api <.cctor>b__57_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000067
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Method.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08562404  token=0x6000408  System.Void .cctor()
  RVA=0x0350B670  token=0x6000409  System.Void .ctor()
  RVA=0x08561FF4  token=0x600040A  Google.Protobuf.WellKnownTypes.Method <.cctor>b__57_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000069
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Mixin.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085620E4  token=0x6000420  System.Void .cctor()
  RVA=0x0350B670  token=0x6000421  System.Void .ctor()
  RVA=0x08561E3C  token=0x6000422  Google.Protobuf.WellKnownTypes.Mixin <.cctor>b__32_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200006C
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Duration.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0856233C  token=0x6000444  System.Void .cctor()
  RVA=0x0350B670  token=0x6000445  System.Void .ctor()
  RVA=0x08561F2C  token=0x6000446  Google.Protobuf.WellKnownTypes.Duration <.cctor>b__48_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200006F
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Empty.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08562210  token=0x600045A  System.Void .cctor()
  RVA=0x0350B670  token=0x600045B  System.Void .ctor()
  RVA=0x08561D10  token=0x600045C  Google.Protobuf.WellKnownTypes.Empty <.cctor>b__22_0()
END_CLASS

CLASS: MergeOptions
TYPE:  sealed class
TOKEN: 0x2000072
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <ReplaceMessageFields>k__BackingField  // 0x10
  private           System.Boolean                  <ReplaceRepeatedFields>k__BackingField  // 0x11
  private           System.Boolean                  <ReplacePrimitiveFields>k__BackingField  // 0x12
PROPERTIES:
  ReplaceMessageFields  get=0x011797F0  set=0x03D4E960
  ReplaceRepeatedFields  get=0x03D510E0  set=0x03D510F0
  ReplacePrimitiveFields  get=0x03D519E0  set=0x03D6B770
METHODS:
  RVA=0x0350B670  token=0x6000488  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000073
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.FieldMask.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Boolean><>9__29_0  // static @ 0x8
METHODS:
  RVA=0x08562468  token=0x6000489  System.Void .cctor()
  RVA=0x0350B670  token=0x600048A  System.Void .ctor()
  RVA=0x08561CCC  token=0x600048B  System.Boolean <ToJson>b__29_0(System.String p)
  RVA=0x08561EDC  token=0x600048C  Google.Protobuf.WellKnownTypes.FieldMask <.cctor>b__47_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.SourceContext.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085621AC  token=0x60004A2  System.Void .cctor()
  RVA=0x0350B670  token=0x60004A3  System.Void .ctor()
  RVA=0x08561DEC  token=0x60004A4  Google.Protobuf.WellKnownTypes.SourceContext <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200007A
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Struct.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085622D8  token=0x60004B9  System.Void .cctor()
  RVA=0x0350B670  token=0x60004BA  System.Void .ctor()
  RVA=0x08561D4C  token=0x60004BB  Google.Protobuf.WellKnownTypes.Struct <.cctor>b__27_0()
END_CLASS

CLASS: KindOneofCase
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNone  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNullValue  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseNumberValue  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseStringValue  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseBoolValue  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseStructValue  // const
  public    static  Google.Protobuf.WellKnownTypes.Value.KindOneofCaseListValue  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200007D
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Value.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08562080  token=0x60004E1  System.Void .cctor()
  RVA=0x0350B670  token=0x60004E2  System.Void .ctor()
  RVA=0x08562044  token=0x60004E3  Google.Protobuf.WellKnownTypes.Value <.cctor>b__58_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200007F
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.ListValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085624CC  token=0x60004F6  System.Void .cctor()
  RVA=0x0350B670  token=0x60004F7  System.Void .ctor()
  RVA=0x08561D9C  token=0x60004F8  Google.Protobuf.WellKnownTypes.ListValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000083
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Timestamp.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08562274  token=0x6000525  System.Void .cctor()
  RVA=0x0350B670  token=0x6000526  System.Void .ctor()
  RVA=0x08561F68  token=0x6000527  Google.Protobuf.WellKnownTypes.Timestamp <.cctor>b__55_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000087
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Type.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085798DC  token=0x6000544  System.Void .cctor()
  RVA=0x0350B670  token=0x6000545  System.Void .ctor()
  RVA=0x085796D4  token=0x6000546  Google.Protobuf.WellKnownTypes.Type <.cctor>b__52_0()
END_CLASS

CLASS: Kind
TYPE:  sealed struct
TOKEN: 0x200008A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUnknown  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeDouble  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFloat  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeInt64  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUint64  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeInt32  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFixed64  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeFixed32  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeBool  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeString  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeGroup  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeMessage  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeBytes  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeUint32  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeEnum  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSfixed32  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSfixed64  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSint32  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.KindTypeSint64  // const
METHODS:
END_CLASS

CLASS: Cardinality
TYPE:  sealed struct
TOKEN: 0x200008B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityUnknown  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityOptional  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityRequired  // const
  public    static  Google.Protobuf.WellKnownTypes.Field.Types.CardinalityRepeated  // const
METHODS:
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x2000089
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200008C
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Field.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579E54  token=0x600056B  System.Void .cctor()
  RVA=0x0350B670  token=0x600056C  System.Void .ctor()
  RVA=0x08579724  token=0x600056D  Google.Protobuf.WellKnownTypes.Field <.cctor>b__73_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200008E
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Enum.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579EB8  token=0x6000587  System.Void .cctor()
  RVA=0x0350B670  token=0x6000588  System.Void .ctor()
  RVA=0x08579684  token=0x6000589  Google.Protobuf.WellKnownTypes.Enum <.cctor>b__47_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000090
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.EnumValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579D8C  token=0x60005A0  System.Void .cctor()
  RVA=0x0350B670  token=0x60005A1  System.Void .ctor()
  RVA=0x0857956C  token=0x60005A2  Google.Protobuf.WellKnownTypes.EnumValue <.cctor>b__37_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000092
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Option.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579AD0  token=0x60005B8  System.Void .cctor()
  RVA=0x0350B670  token=0x60005B9  System.Void .ctor()
  RVA=0x085794E0  token=0x60005BA  Google.Protobuf.WellKnownTypes.Option <.cctor>b__32_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000095
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.DoubleValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579DF0  token=0x60005D0  System.Void .cctor()
  RVA=0x0350B670  token=0x60005D1  System.Void .ctor()
  RVA=0x085794A4  token=0x60005D2  Google.Protobuf.WellKnownTypes.DoubleValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000097
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.FloatValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579D28  token=0x60005E6  System.Void .cctor()
  RVA=0x0350B670  token=0x60005E7  System.Void .ctor()
  RVA=0x0857942C  token=0x60005E8  Google.Protobuf.WellKnownTypes.FloatValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000099
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Int64Value.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579CC4  token=0x60005FC  System.Void .cctor()
  RVA=0x0350B670  token=0x60005FD  System.Void .ctor()
  RVA=0x08579468  token=0x60005FE  Google.Protobuf.WellKnownTypes.Int64Value <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200009B
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.UInt64Value.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579C60  token=0x6000612  System.Void .cctor()
  RVA=0x0350B670  token=0x6000613  System.Void .ctor()
  RVA=0x085792D8  token=0x6000614  Google.Protobuf.WellKnownTypes.UInt64Value <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200009D
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.Int32Value.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579A6C  token=0x6000628  System.Void .cctor()
  RVA=0x0350B670  token=0x6000629  System.Void .ctor()
  RVA=0x085793F0  token=0x600062A  Google.Protobuf.WellKnownTypes.Int32Value <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200009F
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.UInt32Value.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579A08  token=0x600063E  System.Void .cctor()
  RVA=0x0350B670  token=0x600063F  System.Void .ctor()
  RVA=0x0857929C  token=0x6000640  Google.Protobuf.WellKnownTypes.UInt32Value <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A1
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.BoolValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0857A048  token=0x6000654  System.Void .cctor()
  RVA=0x0350B670  token=0x6000655  System.Void .ctor()
  RVA=0x08579314  token=0x6000656  Google.Protobuf.WellKnownTypes.BoolValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A3
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.StringValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579F1C  token=0x600066A  System.Void .cctor()
  RVA=0x0350B670  token=0x600066B  System.Void .ctor()
  RVA=0x085793A0  token=0x600066C  Google.Protobuf.WellKnownTypes.StringValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A5
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.WellKnownTypes.BytesValue.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579FE4  token=0x6000680  System.Void .cctor()
  RVA=0x0350B670  token=0x6000681  System.Void .ctor()
  RVA=0x0857924C  token=0x6000682  Google.Protobuf.WellKnownTypes.BytesValue <.cctor>b__27_0()
END_CLASS

CLASS: <>c__19`1
TYPE:  sealed class
TOKEN: 0x20000A7
FIELDS:
  public    static readonly Google.Protobuf.Reflection.CustomOptions.<>c__19<T><>9  // static @ 0x0
  public    static  System.Func<T,Google.Protobuf.ByteString><>9__19_0  // static @ 0x0
  public    static  System.Func<T,Google.Protobuf.ByteString,T><>9__19_1  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000696  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000697  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000698  Google.Protobuf.ByteString <TryGetMessage>b__19_0(T v)
  RVA=-1  // not resolved  token=0x6000699  T <TryGetMessage>b__19_1(T t, Google.Protobuf.ByteString b)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000AA
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FileDescriptorSet.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579F80  token=0x60006AE  System.Void .cctor()
  RVA=0x0350B670  token=0x60006AF  System.Void .ctor()
  RVA=0x08579350  token=0x60006B0  Google.Protobuf.Reflection.FileDescriptorSet <.cctor>b__27_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000AC
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FileDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x085799A4  token=0x60006D9  System.Void .cctor()
  RVA=0x0350B670  token=0x60006DA  System.Void .ctor()
  RVA=0x085797C4  token=0x60006DB  Google.Protobuf.Reflection.FileDescriptorProto <.cctor>b__94_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000B0
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579B34  token=0x6000716  System.Void .cctor()
  RVA=0x0350B670  token=0x6000717  System.Void .ctor()
  RVA=0x08579648  token=0x6000718  Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange <.cctor>b__46_0()
END_CLASS

CLASS: ExtensionRange
TYPE:  sealed class
TOKEN: 0x20000AF
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // const
  private   static readonly System.Int32                    StartDefaultValue  // static @ 0x8
  private           System.Int32                    start_  // 0x1c
  public    static  System.Int32                    EndFieldNumber  // const
  private   static readonly System.Int32                    EndDefaultValue  // static @ 0xc
  private           System.Int32                    end_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.ExtensionRangeOptionsoptions_  // 0x28
PROPERTIES:
  Parser  get=0x08570E98
  Descriptor  get=0x08570DDC
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08571100
  Start  get=0x08570EE8  set=0x03D6BC70
  HasStart  get=0x02461A70
  End  get=0x08570E3C  set=0x03D6BC60
  HasEnd  get=0x08570E90
  Options  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x0350B670  token=0x60006FE  System.Void .ctor()
  RVA=0x08570D68  token=0x60006FF  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  RVA=0x08570944  token=0x6000700  Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone()
  RVA=0x03D4F650  token=0x6000704  System.Void ClearStart()
  RVA=0x03D6BC50  token=0x6000708  System.Void ClearEnd()
  RVA=0x08570A30  token=0x600070B  System.Boolean Equals(System.Object other)
  RVA=0x085709A4  token=0x600070C  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  RVA=0x08570A94  token=0x600070D  System.Int32 GetHashCode()
  RVA=0x08570BF0  token=0x600070E  System.String ToString()
  RVA=0x03D47770  token=0x600070F  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08571058  token=0x6000710  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08570874  token=0x6000711  System.Int32 CalculateSize()
  RVA=0x08570B04  token=0x6000712  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other)
  RVA=0x03D47500  token=0x6000713  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08570F3C  token=0x6000714  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08570C3C  token=0x6000715  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000B2
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579814  token=0x6000732  System.Void .cctor()
  RVA=0x0350B670  token=0x6000733  System.Void .ctor()
  RVA=0x0857960C  token=0x6000734  Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange <.cctor>b__41_0()
END_CLASS

CLASS: ReservedRange
TYPE:  sealed class
TOKEN: 0x20000B1
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // const
  private   static readonly System.Int32                    StartDefaultValue  // static @ 0x8
  private           System.Int32                    start_  // 0x1c
  public    static  System.Int32                    EndFieldNumber  // const
  private   static readonly System.Int32                    EndDefaultValue  // static @ 0xc
  private           System.Int32                    end_  // 0x20
PROPERTIES:
  Parser  get=0x08577B48
  Descriptor  get=0x08577A90
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08577D10
  Start  get=0x08577B98  set=0x03D6BC70
  HasStart  get=0x02461A70
  End  get=0x08577AF4  set=0x03D6BC60
  HasEnd  get=0x08570E90
METHODS:
  RVA=0x0350B670  token=0x600071C  System.Void .ctor()
  RVA=0x051669EC  token=0x600071D  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  RVA=0x08577718  token=0x600071E  Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone()
  RVA=0x03D4F650  token=0x6000722  System.Void ClearStart()
  RVA=0x03D6BC50  token=0x6000726  System.Void ClearEnd()
  RVA=0x08577778  token=0x6000727  System.Boolean Equals(System.Object other)
  RVA=0x085777DC  token=0x6000728  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  RVA=0x08577854  token=0x6000729  System.Int32 GetHashCode()
  RVA=0x08577918  token=0x600072A  System.String ToString()
  RVA=0x03D47770  token=0x600072B  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08577C88  token=0x600072C  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857766C  token=0x600072D  System.Int32 CalculateSize()
  RVA=0x085778AC  token=0x600072E  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other)
  RVA=0x03D47500  token=0x600072F  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08577BEC  token=0x6000730  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08577964  token=0x6000731  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000AE
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000B3
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.DescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579878  token=0x6000735  System.Void .cctor()
  RVA=0x0350B670  token=0x6000736  System.Void .ctor()
  RVA=0x08579774  token=0x6000737  Google.Protobuf.Reflection.DescriptorProto <.cctor>b__77_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000B5
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.ExtensionRangeOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579B98  token=0x6000752  System.Void .cctor()
  RVA=0x0350B670  token=0x6000753  System.Void .ctor()
  RVA=0x085795BC  token=0x6000754  Google.Protobuf.Reflection.ExtensionRangeOptions <.cctor>b__37_0()
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x20000B8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeDouble  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFloat  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeInt64  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeUint64  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeInt32  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFixed64  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeFixed32  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeBool  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeString  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeGroup  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeMessage  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeBytes  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeUint32  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeEnum  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSfixed32  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSfixed64  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSint32  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeSint64  // const
METHODS:
END_CLASS

CLASS: Label
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelOptional  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelRequired  // const
  public    static  Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelRepeated  // const
METHODS:
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000B7
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000BA
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FieldDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579BFC  token=0x6000790  System.Void .cctor()
  RVA=0x0350B670  token=0x6000791  System.Void .ctor()
  RVA=0x08579210  token=0x6000792  Google.Protobuf.Reflection.FieldDescriptorProto <.cctor>b__119_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000BC
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.OneofDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x08579940  token=0x60007AA  System.Void .cctor()
  RVA=0x0350B670  token=0x60007AB  System.Void .ctor()
  RVA=0x08579530  token=0x60007AC  Google.Protobuf.Reflection.OneofDescriptorProto <.cctor>b__36_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C0
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C1FC  token=0x60007E0  System.Void .cctor()
  RVA=0x0350B670  token=0x60007E1  System.Void .ctor()
  RVA=0x0858B8C8  token=0x60007E2  Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange <.cctor>b__41_0()
END_CLASS

CLASS: EnumReservedRange
TYPE:  sealed class
TOKEN: 0x20000BF
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    StartFieldNumber  // const
  private   static readonly System.Int32                    StartDefaultValue  // static @ 0x8
  private           System.Int32                    start_  // 0x1c
  public    static  System.Int32                    EndFieldNumber  // const
  private   static readonly System.Int32                    EndDefaultValue  // static @ 0xc
  private           System.Int32                    end_  // 0x20
PROPERTIES:
  Parser  get=0x0857ED08
  Descriptor  get=0x0857EC54
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857EE34
  Start  get=0x0857ED58  set=0x03D6BC70
  HasStart  get=0x02461A70
  End  get=0x0857ECB4  set=0x03D6BC60
  HasEnd  get=0x08570E90
METHODS:
  RVA=0x0350B670  token=0x60007CA  System.Void .ctor()
  RVA=0x051669EC  token=0x60007CB  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  RVA=0x0857E8DC  token=0x60007CC  Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone()
  RVA=0x03D4F650  token=0x60007D0  System.Void ClearStart()
  RVA=0x03D6BC50  token=0x60007D4  System.Void ClearEnd()
  RVA=0x0857E93C  token=0x60007D5  System.Boolean Equals(System.Object other)
  RVA=0x0857E9A0  token=0x60007D6  System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  RVA=0x0857EA18  token=0x60007D7  System.Int32 GetHashCode()
  RVA=0x0857EADC  token=0x60007D8  System.String ToString()
  RVA=0x03D47770  token=0x60007D9  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0857EDAC  token=0x60007DA  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857E830  token=0x60007DB  System.Int32 CalculateSize()
  RVA=0x0857EA70  token=0x60007DC  System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
  RVA=0x03D47500  token=0x60007DD  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08577BEC  token=0x60007DE  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0857EB28  token=0x60007DF  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000BE
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C1
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.EnumDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BF40  token=0x60007E3  System.Void .cctor()
  RVA=0x0350B670  token=0x60007E4  System.Void .ctor()
  RVA=0x0858B9E0  token=0x60007E5  Google.Protobuf.Reflection.EnumDescriptorProto <.cctor>b__52_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C3
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.EnumValueDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C134  token=0x6000801  System.Void .cctor()
  RVA=0x0350B670  token=0x6000802  System.Void .ctor()
  RVA=0x0858B904  token=0x6000803  Google.Protobuf.Reflection.EnumValueDescriptorProto <.cctor>b__46_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C5
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.ServiceDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C328  token=0x600081C  System.Void .cctor()
  RVA=0x0350B670  token=0x600081D  System.Void .ctor()
  RVA=0x0858B83C  token=0x600081E  Google.Protobuf.Reflection.ServiceDescriptorProto <.cctor>b__41_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C7
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.MethodDescriptorProto.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BCE8  token=0x6000846  System.Void .cctor()
  RVA=0x0350B670  token=0x6000847  System.Void .ctor()
  RVA=0x0858BB70  token=0x6000848  Google.Protobuf.Reflection.MethodDescriptorProto <.cctor>b__73_0()
END_CLASS

CLASS: OptimizeMode
TYPE:  sealed struct
TOKEN: 0x20000CA
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeSpeed  // const
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeCodeSize  // const
  public    static  Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeLiteRuntime  // const
METHODS:
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000C9
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000CB
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FileOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C260  token=0x60008B3  System.Void .cctor()
  RVA=0x0350B670  token=0x60008B4  System.Void .ctor()
  RVA=0x0858B6FC  token=0x60008B5  Google.Protobuf.Reflection.FileOptions <.cctor>b__219_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000CD
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.MessageOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C06C  token=0x60008E0  System.Void .cctor()
  RVA=0x0350B670  token=0x60008E1  System.Void .ctor()
  RVA=0x0858BBAC  token=0x60008E2  Google.Protobuf.Reflection.MessageOptions <.cctor>b__74_0()
END_CLASS

CLASS: CType
TYPE:  sealed struct
TOKEN: 0x20000D0
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeString  // const
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeCord  // const
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.CTypeStringPiece  // const
METHODS:
END_CLASS

CLASS: JSType
TYPE:  sealed struct
TOKEN: 0x20000D1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsNormal  // const
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsString  // const
  public    static  Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJsNumber  // const
METHODS:
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000CF
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000D2
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FieldOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BEDC  token=0x6000919  System.Void .cctor()
  RVA=0x0350B670  token=0x600091A  System.Void .ctor()
  RVA=0x0858B6AC  token=0x600091B  Google.Protobuf.Reflection.FieldOptions <.cctor>b__102_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000D4
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.OneofOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C2C4  token=0x6000936  System.Void .cctor()
  RVA=0x0350B670  token=0x6000937  System.Void .ctor()
  RVA=0x0858B7EC  token=0x6000938  Google.Protobuf.Reflection.OneofOptions <.cctor>b__37_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000D6
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.EnumOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BDB0  token=0x600095B  System.Void .cctor()
  RVA=0x0350B670  token=0x600095C  System.Void .ctor()
  RVA=0x0858BAD0  token=0x600095D  Google.Protobuf.Reflection.EnumOptions <.cctor>b__56_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000D8
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.EnumValueOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BE14  token=0x600097C  System.Void .cctor()
  RVA=0x0350B670  token=0x600097D  System.Void .ctor()
  RVA=0x0858B990  token=0x600097E  Google.Protobuf.Reflection.EnumValueOptions <.cctor>b__47_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000DA
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.ServiceOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BE78  token=0x600099D  System.Void .cctor()
  RVA=0x0350B670  token=0x600099E  System.Void .ctor()
  RVA=0x0858B940  token=0x600099F  Google.Protobuf.Reflection.ServiceOptions <.cctor>b__47_0()
END_CLASS

CLASS: IdempotencyLevel
TYPE:  sealed struct
TOKEN: 0x20000DD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotencyUnknown  // const
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelNoSideEffects  // const
  public    static  Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotent  // const
METHODS:
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000DC
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000DE
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.MethodOptions.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C008  token=0x60009C2  System.Void .cctor()
  RVA=0x0350B670  token=0x60009C3  System.Void .ctor()
  RVA=0x0858BB20  token=0x60009C4  Google.Protobuf.Reflection.MethodOptions <.cctor>b__57_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000E2
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C38C  token=0x6000A08  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A09  System.Void .ctor()
  RVA=0x0858B88C  token=0x6000A0A  Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart <.cctor>b__41_0()
END_CLASS

CLASS: NamePart
TYPE:  sealed class
TOKEN: 0x20000E1
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NamePart_FieldNumber  // const
  private   static readonly System.String                   NamePart_DefaultValue  // static @ 0x8
  private           System.String                   namePart_  // 0x20
  public    static  System.Int32                    IsExtensionFieldNumber  // const
  private   static readonly System.Boolean                  IsExtensionDefaultValue  // static @ 0x10
  private           System.Boolean                  isExtension_  // 0x28
PROPERTIES:
  Parser  get=0x08588FA4
  Descriptor  get=0x08588E9C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08589110
  NamePart_  get=0x08588F50  set=0x08589150
  HasNamePart_  get=0x08571E40
  IsExtension  get=0x08588EFC  set=0x03D6BF40
  HasIsExtension  get=0x02461A70
METHODS:
  RVA=0x0350B670  token=0x60009F2  System.Void .ctor()
  RVA=0x08588E48  token=0x60009F3  System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  RVA=0x08588A34  token=0x60009F4  Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone()
  RVA=0x08571380  token=0x60009F8  System.Void ClearNamePart_()
  RVA=0x03D4F650  token=0x60009FC  System.Void ClearIsExtension()
  RVA=0x08588A94  token=0x60009FD  System.Boolean Equals(System.Object other)
  RVA=0x08588AF8  token=0x60009FE  System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  RVA=0x08588B80  token=0x60009FF  System.Int32 GetHashCode()
  RVA=0x08588CA0  token=0x6000A00  System.String ToString()
  RVA=0x03D47770  token=0x6000A01  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08589088  token=0x6000A02  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085889B0  token=0x6000A03  System.Int32 CalculateSize()
  RVA=0x08588C2C  token=0x6000A04  System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
  RVA=0x03D47500  token=0x6000A05  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08588FF4  token=0x6000A06  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08588CEC  token=0x6000A07  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000E0
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000E3
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.UninterpretedOption.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C0D0  token=0x6000A0B  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A0C  System.Void .ctor()
  RVA=0x0858BBFC  token=0x6000A0D  Google.Protobuf.Reflection.UninterpretedOption <.cctor>b__83_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000E7
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.SourceCodeInfo.Types.Location.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BD4C  token=0x6000A3C  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A3D  System.Void .ctor()
  RVA=0x0858BA30  token=0x6000A3E  Google.Protobuf.Reflection.SourceCodeInfo.Types.Location <.cctor>b__55_0()
END_CLASS

CLASS: Location
TYPE:  sealed class
TOKEN: 0x20000E6
SIZE:  0x40
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    PathFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_path_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>path_  // 0x18
  public    static  System.Int32                    SpanFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_span_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>span_  // 0x20
  public    static  System.Int32                    LeadingCommentsFieldNumber  // const
  private   static readonly System.String                   LeadingCommentsDefaultValue  // static @ 0x18
  private           System.String                   leadingComments_  // 0x28
  public    static  System.Int32                    TrailingCommentsFieldNumber  // const
  private   static readonly System.String                   TrailingCommentsDefaultValue  // static @ 0x20
  private           System.String                   trailingComments_  // 0x30
  public    static  System.Int32                    LeadingDetachedCommentsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_leadingDetachedComments_codec  // static @ 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>leadingDetachedComments_  // 0x38
PROPERTIES:
  Parser  get=0x08585DB8
  Descriptor  get=0x08585D04
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085861A8
  Path  get=0x01041090
  Span  get=0x03D4EB40
  LeadingComments  get=0x08585D64  set=0x085861E8
  HasLeadingComments  get=0x05693D38
  TrailingComments  get=0x08585E08  set=0x08586250
  HasTrailingComments  get=0x085839D0
  LeadingDetachedComments  get=0x03D4E2A0
METHODS:
  RVA=0x08585B10  token=0x6000A23  System.Void .ctor()
  RVA=0x08585C04  token=0x6000A24  System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  RVA=0x085854D0  token=0x6000A25  Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone()
  RVA=0x08254178  token=0x6000A2B  System.Void ClearLeadingComments()
  RVA=0x05572920  token=0x6000A2F  System.Void ClearTrailingComments()
  RVA=0x08585530  token=0x6000A31  System.Boolean Equals(System.Object other)
  RVA=0x08585594  token=0x6000A32  System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  RVA=0x085856CC  token=0x6000A33  System.Int32 GetHashCode()
  RVA=0x085858AC  token=0x6000A34  System.String ToString()
  RVA=0x03D47770  token=0x6000A35  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08586034  token=0x6000A36  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08585354  token=0x6000A37  System.Int32 CalculateSize()
  RVA=0x085857AC  token=0x6000A38  System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
  RVA=0x03D47500  token=0x6000A39  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08585E5C  token=0x6000A3A  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085858F8  token=0x6000A3B  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000E5
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000E8
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.SourceCodeInfo.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858BFA4  token=0x6000A3F  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A40  System.Void .ctor()
  RVA=0x0858B79C  token=0x6000A41  Google.Protobuf.Reflection.SourceCodeInfo <.cctor>b__28_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000EC
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C3F0  token=0x6000A72  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A73  System.Void .ctor()
  RVA=0x0858BA80  token=0x6000A74  Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation <.cctor>b__55_0()
END_CLASS

CLASS: Annotation
TYPE:  sealed class
TOKEN: 0x20000EB
SIZE:  0x38
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    PathFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_path_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>path_  // 0x20
  public    static  System.Int32                    SourceFileFieldNumber  // const
  private   static readonly System.String                   SourceFileDefaultValue  // static @ 0x10
  private           System.String                   sourceFile_  // 0x28
  public    static  System.Int32                    BeginFieldNumber  // const
  private   static readonly System.Int32                    BeginDefaultValue  // static @ 0x18
  private           System.Int32                    begin_  // 0x30
  public    static  System.Int32                    EndFieldNumber  // const
  private   static readonly System.Int32                    EndDefaultValue  // static @ 0x1c
  private           System.Int32                    end_  // 0x34
PROPERTIES:
  Parser  get=0x0857BD50
  Descriptor  get=0x0857BC9C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857C06C
  Path  get=0x03D4EB40
  SourceFile  get=0x0857BDA0  set=0x0857C0AC
  HasSourceFile  get=0x05693D38
  Begin  get=0x0857BC48  set=0x03D6BD00
  HasBegin  get=0x02461A70
  End  get=0x0857BCFC  set=0x03D6BD10
  HasEnd  get=0x08570E90
METHODS:
  RVA=0x0857BBD0  token=0x6000A57  System.Void .ctor()
  RVA=0x0857BB24  token=0x6000A58  System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  RVA=0x0857B620  token=0x6000A59  Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone()
  RVA=0x08254178  token=0x6000A5E  System.Void ClearSourceFile()
  RVA=0x03D4F650  token=0x6000A62  System.Void ClearBegin()
  RVA=0x03D6BC50  token=0x6000A66  System.Void ClearEnd()
  RVA=0x0857B76C  token=0x6000A67  System.Boolean Equals(System.Object other)
  RVA=0x0857B680  token=0x6000A68  System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  RVA=0x0857B7D0  token=0x6000A69  System.Int32 GetHashCode()
  RVA=0x0857B934  token=0x6000A6A  System.String ToString()
  RVA=0x03D47770  token=0x6000A6B  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0857BF44  token=0x6000A6C  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857B4EC  token=0x6000A6D  System.Int32 CalculateSize()
  RVA=0x0857B868  token=0x6000A6E  System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other)
  RVA=0x03D47500  token=0x6000A6F  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0857BDF4  token=0x6000A70  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0857B980  token=0x6000A71  System.Void .cctor()
END_CLASS

CLASS: Types
TYPE:  static class
TOKEN: 0x20000EA
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000ED
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.GeneratedCodeInfo.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0858C198  token=0x6000A75  System.Void .cctor()
  RVA=0x0350B670  token=0x6000A76  System.Void .ctor()
  RVA=0x0858B74C  token=0x6000A77  Google.Protobuf.Reflection.GeneratedCodeInfo <.cctor>b__28_0()
END_CLASS

CLASS: IndexedConverter`2
TYPE:  sealed class
TOKEN: 0x20000F2
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A96  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A97  TOutput Invoke(TInput element, System.Int32 index)
  RVA=-1  // runtime  token=0x6000A98  System.IAsyncResult BeginInvoke(TInput element, System.Int32 index, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A99  TOutput EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x20000F5
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Reflection.FileDescriptorfile  // 0x10
  public            Google.Protobuf.Reflection.EnumDescriptor<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000AAC  System.Void .ctor()
  RVA=0x0858BC4C  token=0x6000AAD  Google.Protobuf.Reflection.EnumValueDescriptor <.ctor>b__0(Google.Protobuf.Reflection.EnumValueDescriptorProto value, System.Int32 i)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x20000F9
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Extension[]     extensions  // 0x10
  public            Google.Protobuf.Reflection.FileDescriptorfile  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000AC4  System.Void .ctor()
  RVA=0x085971DC  token=0x6000AC5  Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, System.Int32 i)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x20000FA
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Extension[]     extensions  // 0x10
  public            Google.Protobuf.Reflection.MessageDescriptormessage  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000AC6  System.Void .ctor()
  RVA=0x085975F4  token=0x6000AC7  Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, System.Int32 i)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000FB
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.ExtensionCollection.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,Google.Protobuf.Reflection.MessageDescriptor><>9__9_0  // static @ 0x8
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>><>9__9_1  // static @ 0x10
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,Google.Protobuf.Reflection.MessageDescriptor><>9__9_2  // static @ 0x18
  public    static  System.Func<Google.Protobuf.Reflection.FieldDescriptor,System.Int32><>9__9_4  // static @ 0x20
  public    static  System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>><>9__9_3  // static @ 0x28
METHODS:
  RVA=0x08597C30  token=0x6000AC8  System.Void .cctor()
  RVA=0x0350B670  token=0x6000AC9  System.Void .ctor()
  RVA=0x08596EB4  token=0x6000ACA  Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp)
  RVA=0x08596EE8  token=0x6000ACB  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp)
  RVA=0x08596F64  token=0x6000ACC  Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_2(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp)
  RVA=0x08596F98  token=0x6000ACD  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_3(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp)
  RVA=0x08597110  token=0x6000ACE  System.Int32 <CrossLink>b__9_4(Google.Protobuf.Reflection.FieldDescriptor field)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x2000101
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Reflection.FileDescriptor<>4__this  // 0x10
  public            Google.Protobuf.Reflection.GeneratedClrTypeInfogeneratedCodeInfo  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000B1C  System.Void .ctor()
  RVA=0x0859738C  token=0x6000B1D  Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__0(Google.Protobuf.Reflection.DescriptorProto message, System.Int32 index)
  RVA=0x0859744C  token=0x6000B1E  Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__1(Google.Protobuf.Reflection.EnumDescriptorProto enumType, System.Int32 index)
  RVA=0x0859750C  token=0x6000B1F  Google.Protobuf.Reflection.ServiceDescriptor <.ctor>b__2(Google.Protobuf.Reflection.ServiceDescriptorProto service, System.Int32 index)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000102
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.FileDescriptor.<>c<>9  // static @ 0x0
  public    static  System.Func<Google.Protobuf.Reflection.FileDescriptor,System.String><>9__9_0  // static @ 0x8
  public    static  System.Func<Google.Protobuf.Reflection.GeneratedClrTypeInfo,System.Boolean><>9__54_0  // static @ 0x10
  public    static  System.Func<Google.Protobuf.Reflection.FieldDescriptor,Google.Protobuf.Extension><>9__55_0  // static @ 0x18
  public    static  System.Func<Google.Protobuf.Extension,System.Boolean><>9__55_1  // static @ 0x20
  public    static  System.Func<Google.Protobuf.Reflection.FieldDescriptor,Google.Protobuf.Extension><>9__56_0  // static @ 0x28
  public    static  System.Func<Google.Protobuf.Extension,System.Boolean><>9__56_1  // static @ 0x30
METHODS:
  RVA=0x08597DC0  token=0x6000B20  System.Void .cctor()
  RVA=0x0350B670  token=0x6000B21  System.Void .ctor()
  RVA=0x08597130  token=0x6000B22  System.String <DeterminePublicDependencies>b__9_0(Google.Protobuf.Reflection.FileDescriptor file)
  RVA=0x0686B910  token=0x6000B23  System.Boolean <GetAllGeneratedExtensions>b__54_0(Google.Protobuf.Reflection.GeneratedClrTypeInfo t)
  RVA=0x08597168  token=0x6000B24  Google.Protobuf.Extension <GetAllDependedExtensions>b__55_0(Google.Protobuf.Reflection.FieldDescriptor s)
  RVA=0x0686B910  token=0x6000B25  System.Boolean <GetAllDependedExtensions>b__55_1(Google.Protobuf.Extension e)
  RVA=0x08597168  token=0x6000B26  Google.Protobuf.Extension <GetAllDependedExtensionsFromMessage>b__56_0(Google.Protobuf.Reflection.FieldDescriptor s)
  RVA=0x0686B910  token=0x6000B27  System.Boolean <GetAllDependedExtensionsFromMessage>b__56_1(Google.Protobuf.Extension e)
END_CLASS

CLASS: FieldCollection
TYPE:  sealed class
TOKEN: 0x2000108
SIZE:  0x18
FIELDS:
  private   readonly Google.Protobuf.Reflection.MessageDescriptormessageDescriptor  // 0x10
PROPERTIES:
  Item  get=0x0858E184
  Item  get=0x0858E184
METHODS:
  RVA=0x0426FEE0  token=0x6000B5C  System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor)
  RVA=0x056B1D28  token=0x6000B5D  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder()
  RVA=0x056B1D0C  token=0x6000B5E  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder()
  RVA=0x06191144  token=0x6000B5F  System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> ByJsonName()
END_CLASS

CLASS: <>c__DisplayClass5_0
TYPE:  sealed class
TOKEN: 0x2000109
SIZE:  0x28
FIELDS:
  public            Google.Protobuf.Reflection.FileDescriptorfile  // 0x10
  public            Google.Protobuf.Reflection.MessageDescriptor<>4__this  // 0x18
  public            Google.Protobuf.Reflection.GeneratedClrTypeInfogeneratedCodeInfo  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000B62  System.Void .ctor()
  RVA=0x0859791C  token=0x6000B63  Google.Protobuf.Reflection.OneofDescriptor <.ctor>b__0(Google.Protobuf.Reflection.OneofDescriptorProto oneof, System.Int32 index)
  RVA=0x085979E0  token=0x6000B64  Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__1(Google.Protobuf.Reflection.DescriptorProto type, System.Int32 index)
  RVA=0x08597AA4  token=0x6000B65  Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__2(Google.Protobuf.Reflection.EnumDescriptorProto type, System.Int32 index)
  RVA=0x08597B68  token=0x6000B66  Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__3(Google.Protobuf.Reflection.FieldDescriptorProto field, System.Int32 index)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200010A
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.MessageDescriptor.<>c<>9  // static @ 0x0
  public    static  System.Func<Google.Protobuf.Reflection.FieldDescriptor,System.Int32><>9__5_4  // static @ 0x8
METHODS:
  RVA=0x08597D5C  token=0x6000B67  System.Void .cctor()
  RVA=0x0350B670  token=0x6000B68  System.Void .ctor()
  RVA=0x08597110  token=0x6000B69  System.Int32 <.ctor>b__5_4(Google.Protobuf.Reflection.FieldDescriptor field)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x200010D
SIZE:  0x18
FIELDS:
  public            Google.Protobuf.Reflection.OneofDescriptordescriptor  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000B7E  System.Void .ctor()
  RVA=0x08597818  token=0x6000B7F  System.Int32 <ForSyntheticOneof>b__0(Google.Protobuf.IMessage message)
  RVA=0x085978B0  token=0x6000B80  System.Void <ForSyntheticOneof>b__1(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200010F
SIZE:  0x18
FIELDS:
  public            System.Int32                    index  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000B8F  System.Void .ctor()
  RVA=0x08597594  token=0x6000B90  System.Boolean <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto fieldProto)
END_CLASS

CLASS: IReflectionHelper
TYPE:  interface
TOKEN: 0x2000113
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000BA7  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  RVA=-1  // abstract  token=0x6000BA8  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  RVA=-1  // abstract  token=0x6000BA9  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  RVA=-1  // abstract  token=0x6000BAA  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  RVA=-1  // abstract  token=0x6000BAB  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
END_CLASS

CLASS: IExtensionReflectionHelper
TYPE:  interface
TOKEN: 0x2000114
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000BAC  System.Object GetExtension(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000BAD  System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value)
  RVA=-1  // abstract  token=0x6000BAE  System.Boolean HasExtension(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000BAF  System.Void ClearExtension(Google.Protobuf.IMessage message)
END_CLASS

CLASS: IExtensionSetReflector
TYPE:  interface
TOKEN: 0x2000115
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000BB0  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller()
END_CLASS

CLASS: <>c__DisplayClass0_0
TYPE:  sealed class
TOKEN: 0x2000117
FIELDS:
  public            System.Func<T1,System.Int32>    del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BB7  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BB8  System.Int32 <CreateFuncIMessageInt32>b__0(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass0_1
TYPE:  sealed class
TOKEN: 0x2000118
FIELDS:
  public            System.Func<T1,T2>              del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BB9  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BBA  System.Int32 <CreateFuncIMessageInt32>b__1(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass1_0
TYPE:  sealed class
TOKEN: 0x2000119
FIELDS:
  public            System.Action<T1>               del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BBB  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BBC  System.Void <CreateActionIMessage>b__0(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x200011A
FIELDS:
  public            System.Func<T1,T2>              del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BBD  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BBE  System.Object <CreateFuncIMessageObject>b__0(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200011B
FIELDS:
  public            System.Action<T1,T2>            del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BBF  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BC0  System.Void <CreateActionIMessageObject>b__0(Google.Protobuf.IMessage message, System.Object arg)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x200011C
FIELDS:
  public            System.Func<T1,System.Boolean>  del  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BC1  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BC2  System.Boolean <CreateFuncIMessageBool>b__0(Google.Protobuf.IMessage message)
END_CLASS

CLASS: ReflectionHelper`2
TYPE:  class
TOKEN: 0x2000116
IMPLEMENTS: IReflectionHelper
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000BB1  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  RVA=-1  // not resolved  token=0x6000BB2  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  RVA=-1  // not resolved  token=0x6000BB3  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  RVA=-1  // not resolved  token=0x6000BB4  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  RVA=-1  // not resolved  token=0x6000BB5  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
  RVA=-1  // not resolved  token=0x6000BB6  System.Void .ctor()
END_CLASS

CLASS: ExtensionReflectionHelper`2
TYPE:  class
TOKEN: 0x200011D
IMPLEMENTS: IExtensionReflectionHelper
FIELDS:
  private   readonly Google.Protobuf.Extension       extension  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BC3  System.Void .ctor(Google.Protobuf.Extension extension)
  RVA=-1  // not resolved  token=0x6000BC4  System.Object GetExtension(Google.Protobuf.IMessage message)
  RVA=-1  // not resolved  token=0x6000BC5  System.Boolean HasExtension(Google.Protobuf.IMessage message)
  RVA=-1  // not resolved  token=0x6000BC6  System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value)
  RVA=-1  // not resolved  token=0x6000BC7  System.Void ClearExtension(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass0_0
TYPE:  sealed class
TOKEN: 0x200011F
FIELDS:
  public            System.Func<T1,Google.Protobuf.ExtensionSet<T1>>getFunc  // 0x0
  public            System.Func<Google.Protobuf.ExtensionSet<T1>,System.Boolean>initializedFunc  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BCA  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000BCB  System.Boolean <CreateIsInitializedCaller>b__0(Google.Protobuf.IMessage m)
END_CLASS

CLASS: ExtensionSetReflector`1
TYPE:  class
TOKEN: 0x200011E
IMPLEMENTS: IExtensionSetReflector
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000BC8  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller()
  RVA=-1  // not resolved  token=0x6000BC9  System.Void .ctor()
END_CLASS

CLASS: SampleEnum
TYPE:  sealed struct
TOKEN: 0x2000120
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.ReflectionUtil.SampleEnumX  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x2000123
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Reflection.FileDescriptorfile  // 0x10
  public            Google.Protobuf.Reflection.ServiceDescriptor<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000BDC  System.Void .ctor()
  RVA=0x085972F0  token=0x6000BDD  Google.Protobuf.Reflection.MethodDescriptor <.ctor>b__0(Google.Protobuf.Reflection.MethodDescriptorProto method, System.Int32 i)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000125
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Reflection.SingleFieldAccessor<>4__this  // 0x10
  public            Google.Protobuf.Reflection.FieldDescriptordescriptor  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000BE3  System.Void .ctor()
  RVA=0x085975CC  token=0x6000BE4  System.Boolean <.ctor>b__0(Google.Protobuf.IMessage message)
  RVA=0x0859772C  token=0x6000BE5  System.Void <.ctor>b__1(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass3_1
TYPE:  sealed class
TOKEN: 0x2000126
SIZE:  0x20
FIELDS:
  public            Google.Protobuf.Reflection.OneofAccessoroneofAccessor  // 0x10
  public            Google.Protobuf.Reflection.SingleFieldAccessor.<>c__DisplayClass3_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000BE6  System.Void .ctor()
  RVA=0x08597754  token=0x6000BE7  System.Boolean <.ctor>b__2(Google.Protobuf.IMessage message)
  RVA=0x0859778C  token=0x6000BE8  System.Void <.ctor>b__3(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c__DisplayClass3_2
TYPE:  sealed class
TOKEN: 0x2000127
SIZE:  0x20
FIELDS:
  public            System.Object                   defaultValue  // 0x10
  public            Google.Protobuf.Reflection.SingleFieldAccessor.<>c__DisplayClass3_0CS$<>8__locals2  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000BE9  System.Void .ctor()
  RVA=0x085977E4  token=0x6000BEA  System.Void <.ctor>b__5(Google.Protobuf.IMessage message)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000128
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.SingleFieldAccessor.<>c<>9  // static @ 0x0
  public    static  System.Func<Google.Protobuf.IMessage,System.Boolean><>9__3_4  // static @ 0x8
METHODS:
  RVA=0x08597CF8  token=0x6000BEB  System.Void .cctor()
  RVA=0x0350B670  token=0x6000BEC  System.Void .ctor()
  RVA=0x08597180  token=0x6000BED  System.Boolean <.ctor>b__3_4(Google.Protobuf.IMessage message)
END_CLASS

CLASS: Builder
TYPE:  class
TOKEN: 0x200012A
SIZE:  0x20
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor>types  // 0x10
  private   readonly System.Collections.Generic.HashSet<System.String>fileDescriptorNames  // 0x18
METHODS:
  RVA=0x0858E018  token=0x6000BF6  System.Void .ctor()
  RVA=0x0858DB70  token=0x6000BF7  System.Void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor)
  RVA=0x0858DE30  token=0x6000BF8  System.Void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor)
  RVA=0x0858DFB4  token=0x6000BF9  Google.Protobuf.Reflection.TypeRegistry Build()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200012B
SIZE:  0x10
FIELDS:
  public    static readonly Google.Protobuf.Reflection.TypeRegistry.<>c<>9  // static @ 0x0
  public    static  System.Func<Google.Protobuf.Reflection.MessageDescriptor,Google.Protobuf.Reflection.FileDescriptor><>9__9_0  // static @ 0x8
METHODS:
  RVA=0x08597C94  token=0x6000BFA  System.Void .cctor()
  RVA=0x0350B670  token=0x6000BFB  System.Void .ctor()
  RVA=0x08597150  token=0x6000BFC  Google.Protobuf.Reflection.FileDescriptor <FromMessages>b__9_0(Google.Protobuf.Reflection.MessageDescriptor md)
END_CLASS

CLASS: DictionaryEnumerator
TYPE:  class
TOKEN: 0x2000130
IMPLEMENTS: System.Collections.IDictionaryEnumerator System.Collections.IEnumerator
FIELDS:
  private   readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>enumerator  // 0x0
PROPERTIES:
  Current  get=-1  // not resolved
  Entry  get=-1  // not resolved
  Key  get=-1  // not resolved
  Value  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C32  System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator)
  RVA=-1  // not resolved  token=0x6000C33  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000C34  System.Void Reset()
END_CLASS

CLASS: Codec
TYPE:  sealed class
TOKEN: 0x2000131
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TKey>keyCodec  // 0x0
  private   readonly Google.Protobuf.FieldCodec<TValue>valueCodec  // 0x0
  private   readonly System.UInt32                   mapTag  // 0x0
PROPERTIES:
  KeyCodec  get=-1  // not resolved
  ValueCodec  get=-1  // not resolved
  MapTag  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C39  System.Void .ctor(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, System.UInt32 mapTag)
END_CLASS

CLASS: MapView`1
TYPE:  class
TOKEN: 0x2000132
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.ICollection
FIELDS:
  private   readonly Google.Protobuf.Collections.MapField<TKey,TValue>parent  // 0x0
  private   readonly System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T>projection  // 0x0
  private   readonly System.Func<T,System.Boolean>   containsCheck  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  IsSynchronized  get=-1  // not resolved
  SyncRoot  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C3D  System.Void .ctor(Google.Protobuf.Collections.MapField<TKey,TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection, System.Func<T,System.Boolean> containsCheck)
  RVA=-1  // not resolved  token=0x6000C42  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000C43  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000C44  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000C45  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000C46  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C47  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x6000C48  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C49  System.Void CopyTo(System.Array array, System.Int32 index)
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000133
FIELDS:
  public            TValue                          value  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000C4A  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000C4B  System.Boolean <ContainsValue>b__0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000134
FIELDS:
  public    static readonly Google.Protobuf.Collections.MapField.<>c<TKey,TValue><>9  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey><>9__14_0  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue><>9__16_0  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Collections.DictionaryEntry><>9__43_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000C4C  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000C4D  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000C4E  TKey <get_Keys>b__14_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair)
  RVA=-1  // not resolved  token=0x6000C4F  TValue <get_Values>b__16_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair)
  RVA=-1  // not resolved  token=0x6000C50  System.Collections.DictionaryEntry <System.Collections.ICollection.CopyTo>b__43_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair)
END_CLASS

CLASS: BitwiseDoubleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000136
SIZE:  0x10
EXTENDS: System.Collections.Generic.EqualityComparer`1
FIELDS:
METHODS:
  RVA=0x0858D734  token=0x6000C57  System.Boolean Equals(System.Double x, System.Double y)
  RVA=0x0858D790  token=0x6000C58  System.Int32 GetHashCode(System.Double obj)
  RVA=0x039D7A80  token=0x6000C59  System.Void .ctor()
END_CLASS

CLASS: BitwiseSingleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000137
SIZE:  0x10
EXTENDS: System.Collections.Generic.EqualityComparer`1
FIELDS:
METHODS:
  RVA=0x0858DAB0  token=0x6000C5A  System.Boolean Equals(System.Single x, System.Single y)
  RVA=0x0858DB1C  token=0x6000C5B  System.Int32 GetHashCode(System.Single obj)
  RVA=0x039D7A50  token=0x6000C5C  System.Void .ctor()
END_CLASS

CLASS: BitwiseNullableDoubleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000138
SIZE:  0x10
EXTENDS: System.Collections.Generic.EqualityComparer`1
FIELDS:
METHODS:
  RVA=0x0858D7E8  token=0x6000C5D  System.Boolean Equals(System.Nullable<System.Double> x, System.Nullable<System.Double> y)
  RVA=0x0858D8B0  token=0x6000C5E  System.Int32 GetHashCode(System.Nullable<System.Double> obj)
  RVA=0x039D7A20  token=0x6000C5F  System.Void .ctor()
END_CLASS

CLASS: BitwiseNullableSingleEqualityComparerImpl
TYPE:  class
TOKEN: 0x2000139
SIZE:  0x10
EXTENDS: System.Collections.Generic.EqualityComparer`1
FIELDS:
METHODS:
  RVA=0x0858D948  token=0x6000C60  System.Boolean Equals(System.Nullable<System.Single> x, System.Nullable<System.Single> y)
  RVA=0x0858DA18  token=0x6000C61  System.Int32 GetHashCode(System.Nullable<System.Single> obj)
  RVA=0x039D79F0  token=0x6000C62  System.Void .ctor()
END_CLASS

CLASS: <GetEnumerator>d__29
TYPE:  sealed class
TOKEN: 0x200013C
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           T                               <>2__current  // 0x0
  public            Google.Protobuf.Collections.RepeatedField<T><>4__this  // 0x0
  private           System.Int32                    <i>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<T>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000CA5  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000CA6  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000CA7  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000CA9  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  sealed struct
TOKEN: 0x200013E
SIZE:  0x3C
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200013D
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=441EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300  // static @ 0x0
METHODS:
END_CLASS

CLASS: Google.Protobuf.ByteArray
TYPE:  static class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    CopyThreshold  // const
METHODS:
  RVA=0x0229DBE0  token=0x6000012  System.Void Copy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count)
  RVA=0x0853DD10  token=0x6000013  System.Void Reverse(System.Byte[] bytes)
END_CLASS

CLASS: Google.Protobuf.ByteString
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.IEquatable`1
FIELDS:
  private   static readonly Google.Protobuf.ByteString      empty  // static @ 0x0
  private   readonly System.ReadOnlyMemory<System.Byte>bytes  // 0x10
PROPERTIES:
  Empty  get=0x0853E9D0
  Length  get=0x03543640
  IsEmpty  get=0x0853EA20
  Span  get=0x03543560
  Memory  get=0x020B7B30
  Item  get=0x0853EA38
METHODS:
  RVA=0x0229DA90  token=0x6000014  Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<System.Byte> bytes)
  RVA=0x0229DA00  token=0x6000015  Google.Protobuf.ByteString AttachBytes(System.Byte[] bytes)
  RVA=0x0229DBD0  token=0x6000016  System.Void .ctor(System.ReadOnlyMemory<System.Byte> bytes)
  RVA=0x03187700  token=0x600001C  System.Byte[] ToByteArray()
  RVA=0x0853E69C  token=0x600001D  System.String ToBase64()
  RVA=0x0853E2C0  token=0x600001E  Google.Protobuf.ByteString FromBase64(System.String bytes)
  RVA=0x0853E408  token=0x600001F  Google.Protobuf.ByteString FromStream(System.IO.Stream stream)
  RVA=0x0853E3A0  token=0x6000020  System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
  RVA=0x0229D820  token=0x6000021  Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes)
  RVA=0x0229DAF0  token=0x6000022  Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes, System.Int32 offset, System.Int32 count)
  RVA=0x0853DF64  token=0x6000023  Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<System.Byte> bytes)
  RVA=0x0853DEC0  token=0x6000024  Google.Protobuf.ByteString CopyFrom(System.String text, System.Text.Encoding encoding)
  RVA=0x0853DE68  token=0x6000025  Google.Protobuf.ByteString CopyFromUtf8(System.String text)
  RVA=0x0853E7D4  token=0x6000027  System.String ToString(System.Text.Encoding encoding)
  RVA=0x0853E7B0  token=0x6000028  System.String ToStringUtf8()
  RVA=0x0853E598  token=0x6000029  System.Collections.Generic.IEnumerator<System.Byte> GetEnumerator()
  RVA=0x0853E694  token=0x600002A  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x0853E08C  token=0x600002B  Google.Protobuf.CodedInputStream CreateCodedInput()
  RVA=0x02F0E490  token=0x600002C  System.Boolean op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs)
  RVA=0x0853EA98  token=0x600002D  System.Boolean op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs)
  RVA=0x0853E1F4  token=0x600002E  System.Boolean Equals(System.Object obj)
  RVA=0x0853E608  token=0x600002F  System.Int32 GetHashCode()
  RVA=0x0853E264  token=0x6000030  System.Boolean Equals(Google.Protobuf.ByteString other)
  RVA=0x0853E004  token=0x6000031  System.Void CopyTo(System.Byte[] array, System.Int32 position)
  RVA=0x0853E8D0  token=0x6000032  System.Void WriteTo(System.IO.Stream outputStream)
  RVA=0x0229D8D0  token=0x6000033  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.ByteStringAsync
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0853DD78  token=0x6000034  System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: Google.Protobuf.CodedInputStream
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0xA8
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Boolean                  leaveOpen  // 0x10
  private   readonly System.Byte[]                   buffer  // 0x18
  private   readonly System.IO.Stream                input  // 0x20
  private           Google.Protobuf.ParserInternalStatestate  // 0x28
  private   static  System.Int32                    DefaultRecursionLimit  // const
  private   static  System.Int32                    DefaultSizeLimit  // const
  private   static  System.Int32                    BufferSize  // const
PROPERTIES:
  Position  get=0x0853F8BC
  LastTag  get=0x03D4F0B0
  SizeLimit  get=0x03D5B3A0
  RecursionLimit  get=0x03D4EB50
  DiscardUnknownFields  get=0x03D5E1C0  set=0x03D5E200
  ExtensionRegistry  get=0x03D4EA80  set=0x04270264
  InternalBuffer  get=0x01041090
  InternalInputStream  get=0x03D4EB40
  InternalState  get=0x03D6BB40
  ReachedLimit  get=0x0853F8F8
  IsAtEnd  get=0x0853F858
METHODS:
  RVA=0x0853F7D0  token=0x6000037  System.Void .ctor(System.Byte[] buffer)
  RVA=0x024D1940  token=0x6000038  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length)
  RVA=0x0853F5FC  token=0x6000039  System.Void .ctor(System.IO.Stream input)
  RVA=0x0853F728  token=0x600003A  System.Void .ctor(System.IO.Stream input, System.Boolean leaveOpen)
  RVA=0x024D2150  token=0x600003B  System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Boolean leaveOpen)
  RVA=0x0853F608  token=0x600003C  System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Int32 sizeLimit, System.Int32 recursionLimit, System.Boolean leaveOpen)
  RVA=0x0853EAEC  token=0x600003D  Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, System.Int32 sizeLimit, System.Int32 recursionLimit)
  RVA=0x0853EBAC  token=0x6000049  System.Void Dispose()
  RVA=0x024D20F0  token=0x600004A  System.Void CheckReadEndOfStreamTag()
  RVA=0x0853EC4C  token=0x600004B  System.UInt32 PeekTag()
  RVA=0x0853F40C  token=0x600004C  System.UInt32 ReadTag()
  RVA=0x0853F57C  token=0x600004D  System.Void SkipLastField()
  RVA=0x0853F4F0  token=0x600004E  System.Void SkipGroup(System.UInt32 startGroupTag)
  RVA=0x0853ED4C  token=0x600004F  System.Double ReadDouble()
  RVA=0x0853EDCC  token=0x6000050  System.Single ReadFloat()
  RVA=0x0853EF30  token=0x6000051  System.UInt64 ReadUInt64()
  RVA=0x0853EF30  token=0x6000052  System.Int64 ReadInt64()
  RVA=0x0853EDB4  token=0x6000053  System.Int32 ReadInt32()
  RVA=0x0853EDC4  token=0x6000054  System.UInt64 ReadFixed64()
  RVA=0x0853EDBC  token=0x6000055  System.UInt32 ReadFixed32()
  RVA=0x0853ECD0  token=0x6000056  System.Boolean ReadBool()
  RVA=0x0853F3A8  token=0x6000057  System.String ReadString()
  RVA=0x0853EFA0  token=0x6000058  System.Void ReadMessage(Google.Protobuf.IMessage builder)
  RVA=0x0853EE34  token=0x6000059  System.Void ReadGroup(Google.Protobuf.IMessage builder)
  RVA=0x0853ECE8  token=0x600005A  Google.Protobuf.ByteString ReadBytes()
  RVA=0x0853EDB4  token=0x600005B  System.UInt32 ReadUInt32()
  RVA=0x0853EDB4  token=0x600005C  System.Int32 ReadEnum()
  RVA=0x0853EDBC  token=0x600005D  System.Int32 ReadSFixed32()
  RVA=0x0853EDC4  token=0x600005E  System.Int64 ReadSFixed64()
  RVA=0x0853F36C  token=0x600005F  System.Int32 ReadSInt32()
  RVA=0x0853F388  token=0x6000060  System.Int64 ReadSInt64()
  RVA=0x0853EF38  token=0x6000061  System.Int32 ReadLength()
  RVA=0x0853EBD8  token=0x6000062  System.Boolean MaybeConsumeTag(System.UInt32 tag)
  RVA=0x0853F29C  token=0x6000063  System.UInt32 ReadRawVarint32()
  RVA=0x0853F294  token=0x6000064  System.UInt32 ReadRawVarint32(System.IO.Stream input)
  RVA=0x0853F304  token=0x6000065  System.UInt64 ReadRawVarint64()
  RVA=0x0853F1C4  token=0x6000066  System.UInt32 ReadRawLittleEndian32()
  RVA=0x0853F22C  token=0x6000067  System.UInt64 ReadRawLittleEndian64()
  RVA=0x0853ECC4  token=0x6000068  System.Int32 PushLimit(System.Int32 byteLimit)
  RVA=0x0853ECB4  token=0x6000069  System.Void PopLimit(System.Int32 oldLimit)
  RVA=0x0853F474  token=0x600006C  System.Boolean RefillBuffer(System.Boolean mustSucceed)
  RVA=0x0853F150  token=0x600006D  System.Byte[] ReadRawBytes(System.Int32 size)
  RVA=0x02942560  token=0x600006E  System.Void ReadRawMessage(Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.CodedOutputStream
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x40
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.Int32                    LittleEndian64Size  // const
  private   static  System.Int32                    LittleEndian32Size  // const
  private   static  System.Int32                    DoubleSize  // const
  private   static  System.Int32                    FloatSize  // const
  private   static  System.Int32                    BoolSize  // const
  public    static readonly System.Int32                    DefaultBufferSize  // static @ 0x0
  private   readonly System.Boolean                  leaveOpen  // 0x10
  private   readonly System.Byte[]                   buffer  // 0x18
  private           Google.Protobuf.WriterInternalStatestate  // 0x20
  private   readonly System.IO.Stream                output  // 0x38
PROPERTIES:
  Position  get=0x08540F64
  NonOutputPosition  get=0x03D4E2E0
  SpaceLeft  get=0x08540F98
  InternalBuffer  get=0x01041090
  InternalOutputStream  get=0x03D4E2A0
  InternalState  get=0x03D69590
METHODS:
  RVA=0x03D55800  token=0x600006F  System.Int32 ComputeDoubleSize(System.Double value)
  RVA=0x03D50CD0  token=0x6000070  System.Int32 ComputeFloatSize(System.Single value)
  RVA=0x024D6680  token=0x6000071  System.Int32 ComputeUInt64Size(System.UInt64 value)
  RVA=0x024D6630  token=0x6000072  System.Int32 ComputeInt64Size(System.Int64 value)
  RVA=0x024D5F30  token=0x6000073  System.Int32 ComputeInt32Size(System.Int32 value)
  RVA=0x03D55800  token=0x6000074  System.Int32 ComputeFixed64Size(System.UInt64 value)
  RVA=0x03D50CD0  token=0x6000075  System.Int32 ComputeFixed32Size(System.UInt32 value)
  RVA=0x01168950  token=0x6000076  System.Int32 ComputeBoolSize(System.Boolean value)
  RVA=0x024D5730  token=0x6000077  System.Int32 ComputeStringSize(System.String value)
  RVA=0x0853F910  token=0x6000078  System.Int32 ComputeGroupSize(Google.Protobuf.IMessage value)
  RVA=0x024D5C70  token=0x6000079  System.Int32 ComputeMessageSize(Google.Protobuf.IMessage value)
  RVA=0x035435C0  token=0x600007A  System.Int32 ComputeBytesSize(Google.Protobuf.ByteString value)
  RVA=0x024D5CF0  token=0x600007B  System.Int32 ComputeUInt32Size(System.UInt32 value)
  RVA=0x024D5E30  token=0x600007C  System.Int32 ComputeEnumSize(System.Int32 value)
  RVA=0x03D50CD0  token=0x600007D  System.Int32 ComputeSFixed32Size(System.Int32 value)
  RVA=0x03D55800  token=0x600007E  System.Int32 ComputeSFixed64Size(System.Int64 value)
  RVA=0x0853F95C  token=0x600007F  System.Int32 ComputeSInt32Size(System.Int32 value)
  RVA=0x0853F9BC  token=0x6000080  System.Int32 ComputeSInt64Size(System.Int64 value)
  RVA=0x024D5D90  token=0x6000081  System.Int32 ComputeLengthSize(System.Int32 length)
  RVA=0x024D5FE0  token=0x6000082  System.Int32 ComputeRawVarint32Size(System.UInt32 value)
  RVA=0x024D66D0  token=0x6000083  System.Int32 ComputeRawVarint64Size(System.UInt64 value)
  RVA=0x0853FA20  token=0x6000084  System.Int32 ComputeTagSize(System.Int32 fieldNumber)
  RVA=0x08540D38  token=0x6000085  System.Void .ctor(System.Byte[] flatArray)
  RVA=0x024D1FD0  token=0x6000086  System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length)
  RVA=0x08540DD0  token=0x6000087  System.Void .ctor(System.IO.Stream output, System.Byte[] buffer, System.Boolean leaveOpen)
  RVA=0x08540EFC  token=0x6000088  System.Void .ctor(System.IO.Stream output)
  RVA=0x08540D64  token=0x6000089  System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize)
  RVA=0x08540CC0  token=0x600008A  System.Void .ctor(System.IO.Stream output, System.Boolean leaveOpen)
  RVA=0x08540E84  token=0x600008B  System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize, System.Boolean leaveOpen)
  RVA=0x0853FC04  token=0x600008E  System.Void WriteDouble(System.Double value)
  RVA=0x0853FE08  token=0x600008F  System.Void WriteFloat(System.Single value)
  RVA=0x08540C40  token=0x6000090  System.Void WriteUInt64(System.UInt64 value)
  RVA=0x08540020  token=0x6000091  System.Void WriteInt64(System.Int64 value)
  RVA=0x0853FFA0  token=0x6000092  System.Void WriteInt32(System.Int32 value)
  RVA=0x0853FD88  token=0x6000093  System.Void WriteFixed64(System.UInt64 value)
  RVA=0x0853FD08  token=0x6000094  System.Void WriteFixed32(System.UInt32 value)
  RVA=0x0853FB04  token=0x6000095  System.Void WriteBool(System.Boolean value)
  RVA=0x08540A2C  token=0x6000096  System.Void WriteString(System.String value)
  RVA=0x08540120  token=0x6000097  System.Void WriteMessage(Google.Protobuf.IMessage value)
  RVA=0x024D3B30  token=0x6000098  System.Void WriteRawMessage(Google.Protobuf.IMessage value)
  RVA=0x0853FE8C  token=0x6000099  System.Void WriteGroup(Google.Protobuf.IMessage value)
  RVA=0x0853FB84  token=0x600009A  System.Void WriteBytes(Google.Protobuf.ByteString value)
  RVA=0x08540BC0  token=0x600009B  System.Void WriteUInt32(System.UInt32 value)
  RVA=0x0853FC88  token=0x600009C  System.Void WriteEnum(System.Int32 value)
  RVA=0x0854082C  token=0x600009D  System.Void WriteSFixed32(System.Int32 value)
  RVA=0x085408AC  token=0x600009E  System.Void WriteSFixed64(System.Int64 value)
  RVA=0x0854092C  token=0x600009F  System.Void WriteSInt32(System.Int32 value)
  RVA=0x085409AC  token=0x60000A0  System.Void WriteSInt64(System.Int64 value)
  RVA=0x085400A0  token=0x60000A1  System.Void WriteLength(System.Int32 length)
  RVA=0x08540B2C  token=0x60000A2  System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  RVA=0x08540AAC  token=0x60000A3  System.Void WriteTag(System.UInt32 tag)
  RVA=0x085406AC  token=0x60000A4  System.Void WriteRawTag(System.Byte b1)
  RVA=0x08540618  token=0x60000A5  System.Void WriteRawTag(System.Byte b1, System.Byte b2)
  RVA=0x085404C0  token=0x60000A6  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3)
  RVA=0x08540568  token=0x60000A7  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  RVA=0x08540404  token=0x60000A8  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  RVA=0x0854072C  token=0x60000A9  System.Void WriteRawVarint32(System.UInt32 value)
  RVA=0x085407AC  token=0x60000AA  System.Void WriteRawVarint64(System.UInt64 value)
  RVA=0x08540304  token=0x60000AB  System.Void WriteRawLittleEndian32(System.UInt32 value)
  RVA=0x08540384  token=0x60000AC  System.Void WriteRawLittleEndian64(System.UInt64 value)
  RVA=0x08540234  token=0x60000AD  System.Void WriteRawBytes(System.Byte[] value)
  RVA=0x08540260  token=0x60000AE  System.Void WriteRawBytes(System.Byte[] value, System.Int32 offset, System.Int32 length)
  RVA=0x0853FA70  token=0x60000AF  System.Void Dispose()
  RVA=0x0853FAAC  token=0x60000B0  System.Void Flush()
  RVA=0x0853F904  token=0x60000B1  System.Void CheckNoSpaceLeft()
  RVA=0x03D44A20  token=0x60000B6  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Extension
TYPE:  abstract class
TOKEN: 0x200000D
SIZE:  0x18
FIELDS:
  private   readonly System.Int32                    <FieldNumber>k__BackingField  // 0x10
PROPERTIES:
  TargetType  get=-1  // abstract
  FieldNumber  get=0x03D4E340
  IsRepeated  get=-1  // abstract
METHODS:
  RVA=0x010410F0  token=0x60000B9  System.Void .ctor(System.Int32 fieldNumber)
  RVA=-1  // abstract  token=0x60000BA  Google.Protobuf.IExtensionValue CreateValue()
END_CLASS

CLASS: Google.Protobuf.Extension`2
TYPE:  sealed class
TOKEN: 0x200000E
EXTENDS: Google.Protobuf.Extension
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TValue>codec  // 0x0
PROPERTIES:
  DefaultValue  get=-1  // not resolved
  TargetType  get=-1  // not resolved
  IsRepeated  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000BD  System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec)
  RVA=-1  // not resolved  token=0x60000C1  Google.Protobuf.IExtensionValue CreateValue()
END_CLASS

CLASS: Google.Protobuf.RepeatedExtension`2
TYPE:  sealed class
TOKEN: 0x200000F
EXTENDS: Google.Protobuf.Extension
FIELDS:
  private   readonly Google.Protobuf.FieldCodec<TValue>codec  // 0x0
PROPERTIES:
  TargetType  get=-1  // not resolved
  IsRepeated  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000C2  System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec)
  RVA=-1  // not resolved  token=0x60000C5  Google.Protobuf.IExtensionValue CreateValue()
END_CLASS

CLASS: Google.Protobuf.ExtensionRegistry
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x18
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable Google.Protobuf.IDeepCloneable`1
FIELDS:
  private           System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>extensions  // 0x10
PROPERTIES:
  Count  get=0x08541B10
  System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly  get=0x0115F4C0
METHODS:
  RVA=0x085418C0  token=0x60000C6  System.Void .ctor()
  RVA=0x08541938  token=0x60000C7  System.Void .ctor(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> collection)
  RVA=0x08541434  token=0x60000CA  System.Boolean ContainsInputField(System.UInt32 lastTag, System.Type target, Google.Protobuf.Extension& extension)
  RVA=0x085412B8  token=0x60000CB  System.Void Add(Google.Protobuf.Extension extension)
  RVA=0x08541164  token=0x60000CC  System.Void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions)
  RVA=0x08541384  token=0x60000CD  System.Void Clear()
  RVA=0x085414D8  token=0x60000CE  System.Boolean Contains(Google.Protobuf.Extension item)
  RVA=0x085416DC  token=0x60000CF  System.Void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, System.Int32 arrayIndex)
  RVA=0x085415A4  token=0x60000D0  System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator()
  RVA=0x08541610  token=0x60000D1  System.Boolean Remove(Google.Protobuf.Extension item)
  RVA=0x085418B8  token=0x60000D2  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x085413D0  token=0x60000D3  Google.Protobuf.ExtensionRegistry Clone()
END_CLASS

CLASS: Google.Protobuf.ExtensionSet
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60000DC  System.Boolean TryGetValue(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension extension, Google.Protobuf.IExtensionValue& value)
  RVA=-1  // generic def  token=0x60000DD  TValue Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000DE  Google.Protobuf.Collections.RepeatedField<TValue> Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000DF  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000E0  System.Void Set(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x60000E1  System.Boolean Has(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000E2  System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000E3  System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension)
  RVA=-1  // generic def  token=0x60000E4  System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.CodedInputStream stream)
  RVA=-1  // generic def  token=0x60000E5  System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.ParseContext& ctx)
  RVA=-1  // generic def  token=0x60000E6  System.Void MergeFrom(Google.Protobuf.ExtensionSet<TTarget>& first, Google.Protobuf.ExtensionSet<TTarget> second)
  RVA=-1  // generic def  token=0x60000E7  Google.Protobuf.ExtensionSet<TTarget> Clone(Google.Protobuf.ExtensionSet<TTarget> set)
END_CLASS

CLASS: Google.Protobuf.ExtensionSet`1
TYPE:  sealed class
TOKEN: 0x2000014
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue><ValuesByNumber>k__BackingField  // 0x0
PROPERTIES:
  ValuesByNumber  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000E9  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x60000EA  System.Boolean Equals(System.Object other)
  RVA=-1  // not resolved  token=0x60000EB  System.Int32 CalculateSize()
  RVA=-1  // not resolved  token=0x60000EC  System.Void WriteTo(Google.Protobuf.CodedOutputStream stream)
  RVA=-1  // not resolved  token=0x60000ED  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  RVA=-1  // not resolved  token=0x60000EE  System.Boolean IsInitialized()
  RVA=-1  // not resolved  token=0x60000EF  System.Void .ctor()
END_CLASS

CLASS: Google.Protobuf.IExtensionValue
TYPE:  interface
TOKEN: 0x2000016
IMPLEMENTS: System.IEquatable`1 Google.Protobuf.IDeepCloneable`1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60000F3  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // abstract  token=0x60000F4  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  RVA=-1  // abstract  token=0x60000F5  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  RVA=-1  // abstract  token=0x60000F6  System.Int32 CalculateSize()
  RVA=-1  // abstract  token=0x60000F7  System.Boolean IsInitialized()
  RVA=-1  // abstract  token=0x60000F8  System.Object GetValue()
END_CLASS

CLASS: Google.Protobuf.ExtensionValue`1
TYPE:  sealed class
TOKEN: 0x2000017
IMPLEMENTS: Google.Protobuf.IExtensionValue System.IEquatable`1 Google.Protobuf.IDeepCloneable`1
FIELDS:
  private           T                               field  // 0x0
  private           Google.Protobuf.FieldCodec<T>   codec  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60000F9  System.Void .ctor(Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x60000FA  System.Int32 CalculateSize()
  RVA=-1  // not resolved  token=0x60000FB  Google.Protobuf.IExtensionValue Clone()
  RVA=-1  // not resolved  token=0x60000FC  System.Boolean Equals(Google.Protobuf.IExtensionValue other)
  RVA=-1  // not resolved  token=0x60000FD  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x60000FE  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x60000FF  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  RVA=-1  // not resolved  token=0x6000100  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  RVA=-1  // not resolved  token=0x6000101  T GetValue()
  RVA=-1  // not resolved  token=0x6000102  System.Object Google.Protobuf.IExtensionValue.GetValue()
  RVA=-1  // not resolved  token=0x6000103  System.Void SetValue(T value)
  RVA=-1  // not resolved  token=0x6000104  System.Boolean IsInitialized()
END_CLASS

CLASS: Google.Protobuf.RepeatedExtensionValue`1
TYPE:  sealed class
TOKEN: 0x2000018
IMPLEMENTS: Google.Protobuf.IExtensionValue System.IEquatable`1 Google.Protobuf.IDeepCloneable`1
FIELDS:
  private           Google.Protobuf.Collections.RepeatedField<T>field  // 0x0
  private   readonly Google.Protobuf.FieldCodec<T>   codec  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000105  System.Void .ctor(Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000106  System.Int32 CalculateSize()
  RVA=-1  // not resolved  token=0x6000107  Google.Protobuf.IExtensionValue Clone()
  RVA=-1  // not resolved  token=0x6000108  System.Boolean Equals(Google.Protobuf.IExtensionValue other)
  RVA=-1  // not resolved  token=0x6000109  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x600010A  System.Void MergeFrom(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x600010B  System.Void MergeFrom(Google.Protobuf.IExtensionValue value)
  RVA=-1  // not resolved  token=0x600010C  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  RVA=-1  // not resolved  token=0x600010D  Google.Protobuf.Collections.RepeatedField<T> GetValue()
  RVA=-1  // not resolved  token=0x600010E  System.Object Google.Protobuf.IExtensionValue.GetValue()
  RVA=-1  // not resolved  token=0x600010F  System.Boolean IsInitialized()
END_CLASS

CLASS: Google.Protobuf.FieldCodec
TYPE:  static class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x032E9E90  token=0x6000110  Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag)
  RVA=0x08541B58  token=0x6000111  Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag)
  RVA=0x04276060  token=0x6000112  Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag)
  RVA=0x04276048  token=0x6000113  Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag)
  RVA=0x08542870  token=0x6000114  Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag)
  RVA=0x08541FCC  token=0x6000115  Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag)
  RVA=0x08542400  token=0x6000116  Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag)
  RVA=0x0427603C  token=0x6000117  Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag)
  RVA=0x0427606C  token=0x6000118  Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag)
  RVA=0x08542ACC  token=0x6000119  Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag)
  RVA=0x08541FD8  token=0x600011A  Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag)
  RVA=0x08542624  token=0x600011B  Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag)
  RVA=0x04276768  token=0x600011C  Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag)
  RVA=0x04276054  token=0x600011D  Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag)
  RVA=0x08541DBC  token=0x600011E  Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag)
  RVA=-1  // generic def  token=0x600011F  Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32)
  RVA=0x032E9ED0  token=0x6000120  Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag, System.String defaultValue)
  RVA=0x02F0E210  token=0x6000121  Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag, Google.Protobuf.ByteString defaultValue)
  RVA=0x032E6A00  token=0x6000122  Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag, System.Boolean defaultValue)
  RVA=0x032E81E0  token=0x6000123  Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag, System.Int32 defaultValue)
  RVA=0x08542630  token=0x6000124  Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag, System.Int32 defaultValue)
  RVA=0x08541DC8  token=0x6000125  Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag, System.UInt32 defaultValue)
  RVA=0x085421FC  token=0x6000126  Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag, System.Int32 defaultValue)
  RVA=0x032E3E80  token=0x6000127  Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag, System.UInt32 defaultValue)
  RVA=0x032E6080  token=0x6000128  Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag, System.Int64 defaultValue)
  RVA=0x0854287C  token=0x6000129  Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag, System.Int64 defaultValue)
  RVA=0x08541FE4  token=0x600012A  Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag, System.UInt64 defaultValue)
  RVA=0x0854240C  token=0x600012B  Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag, System.Int64 defaultValue)
  RVA=0x035D0E10  token=0x600012C  Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag, System.UInt64 defaultValue)
  RVA=0x039DE5B0  token=0x600012D  Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag, System.Single defaultValue)
  RVA=0x08541BA8  token=0x600012E  Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag, System.Double defaultValue)
  RVA=-1  // generic def  token=0x600012F  Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32, T defaultValue)
  RVA=-1  // generic def  token=0x6000130  Google.Protobuf.FieldCodec<T> ForMessage(System.UInt32 tag, Google.Protobuf.MessageParser<T> parser)
  RVA=-1  // generic def  token=0x6000131  Google.Protobuf.FieldCodec<T> ForGroup(System.UInt32 startTag, System.UInt32 endTag, Google.Protobuf.MessageParser<T> parser)
  RVA=-1  // generic def  token=0x6000132  Google.Protobuf.FieldCodec<T> ForClassWrapper(System.UInt32 tag)
  RVA=-1  // generic def  token=0x6000133  Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper(System.UInt32 tag)
END_CLASS

CLASS: Google.Protobuf.ValueReader`1
TYPE:  sealed class
TOKEN: 0x2000026
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600017F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000180  TValue Invoke(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // runtime  token=0x6000181  System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000182  TValue EndInvoke(Google.Protobuf.ParseContext& ctx, System.IAsyncResult result)
END_CLASS

CLASS: Google.Protobuf.ValueWriter`1
TYPE:  sealed class
TOKEN: 0x2000027
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000183  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000184  System.Void Invoke(Google.Protobuf.WriteContext& ctx, T value)
  RVA=-1  // runtime  token=0x6000185  System.IAsyncResult BeginInvoke(Google.Protobuf.WriteContext& ctx, T value, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000186  System.Void EndInvoke(Google.Protobuf.WriteContext& ctx, System.IAsyncResult result)
END_CLASS

CLASS: Google.Protobuf.FieldCodec`1
TYPE:  sealed class
TOKEN: 0x2000028
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<T>EqualityComparer  // static @ 0x0
  private   static readonly T                               DefaultDefault  // static @ 0x0
  private   static readonly System.Boolean                  TypeSupportsPacking  // static @ 0x0
  private   readonly System.Boolean                  <PackedRepeatedField>k__BackingField  // 0x0
  private   readonly Google.Protobuf.ValueWriter<T>  <ValueWriter>k__BackingField  // 0x0
  private   readonly System.Func<T,System.Int32>     <ValueSizeCalculator>k__BackingField  // 0x0
  private   readonly Google.Protobuf.ValueReader<T>  <ValueReader>k__BackingField  // 0x0
  private   readonly Google.Protobuf.FieldCodec.InputMerger<T><ValueMerger>k__BackingField  // 0x0
  private   readonly Google.Protobuf.FieldCodec.ValuesMerger<T><FieldMerger>k__BackingField  // 0x0
  private   readonly System.Int32                    <FixedSize>k__BackingField  // 0x0
  private   readonly System.UInt32                   <Tag>k__BackingField  // 0x0
  private   readonly System.UInt32                   <EndTag>k__BackingField  // 0x0
  private   readonly T                               <DefaultValue>k__BackingField  // 0x0
  private   readonly System.Int32                    tagSize  // 0x0
PROPERTIES:
  PackedRepeatedField  get=-1  // not resolved
  ValueWriter  get=-1  // not resolved
  ValueSizeCalculator  get=-1  // not resolved
  ValueReader  get=-1  // not resolved
  ValueMerger  get=-1  // not resolved
  FieldMerger  get=-1  // not resolved
  FixedSize  get=-1  // not resolved
  Tag  get=-1  // not resolved
  EndTag  get=-1  // not resolved
  DefaultValue  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000187  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000188  System.Boolean IsPackedRepeatedField(System.UInt32 tag)
  RVA=-1  // not resolved  token=0x6000193  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Int32 fixedSize, System.UInt32 tag, T defaultValue)
  RVA=-1  // not resolved  token=0x6000194  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, T defaultValue)
  RVA=-1  // not resolved  token=0x6000195  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag)
  RVA=-1  // not resolved  token=0x6000196  System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag, T defaultValue)
  RVA=-1  // not resolved  token=0x6000197  System.Void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value)
  RVA=-1  // not resolved  token=0x6000198  System.Void WriteTagAndValue(Google.Protobuf.WriteContext& ctx, T value)
  RVA=-1  // not resolved  token=0x6000199  T Read(Google.Protobuf.CodedInputStream input)
  RVA=-1  // not resolved  token=0x600019A  T Read(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // not resolved  token=0x600019B  System.Int32 CalculateSizeWithTag(T value)
  RVA=-1  // not resolved  token=0x600019C  System.Int32 CalculateUnconditionalSizeWithTag(T value)
  RVA=-1  // not resolved  token=0x600019D  System.Boolean IsDefault(T value)
END_CLASS

CLASS: Google.Protobuf.FieldMaskTree
TYPE:  sealed class
TOKEN: 0x200002E
SIZE:  0x18
FIELDS:
  private   static  System.Char                     FIELD_PATH_SEPARATOR  // const
  private   readonly Google.Protobuf.FieldMaskTree.Noderoot  // 0x10
METHODS:
  RVA=0x08543E34  token=0x60001AD  System.Void .ctor()
  RVA=0x08543E98  token=0x60001AE  System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask mask)
  RVA=0x08543E0C  token=0x60001AF  System.String ToString()
  RVA=0x08542AD8  token=0x60001B0  Google.Protobuf.FieldMaskTree AddFieldPath(System.String path)
  RVA=0x085431A8  token=0x60001B1  Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask)
  RVA=0x08543CF4  token=0x60001B2  Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask()
  RVA=0x08542C84  token=0x60001B3  System.Void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, System.String path, System.Collections.Generic.List<System.String> paths)
  RVA=0x08542EA0  token=0x60001B4  System.Void IntersectFieldPath(System.String path, Google.Protobuf.FieldMaskTree output)
  RVA=0x085432F4  token=0x60001B5  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
  RVA=0x08543448  token=0x60001B6  System.Void Merge(Google.Protobuf.FieldMaskTree.Node node, System.String path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
END_CLASS

CLASS: Google.Protobuf.FrameworkPortability
TYPE:  static class
TOKEN: 0x2000030
SIZE:  0x10
FIELDS:
  private   static readonly System.Text.RegularExpressions.RegexOptionsCompiledRegexWhereAvailable  // static @ 0x0
METHODS:
  RVA=0x08543F18  token=0x60001B9  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.IBufferMessage
TYPE:  interface
TOKEN: 0x2000031
IMPLEMENTS: Google.Protobuf.IMessage
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001BA  System.Void InternalMergeFrom(Google.Protobuf.ParseContext& ctx)
  RVA=-1  // abstract  token=0x60001BB  System.Void InternalWriteTo(Google.Protobuf.WriteContext& ctx)
END_CLASS

CLASS: Google.Protobuf.ICustomDiagnosticMessage
TYPE:  interface
TOKEN: 0x2000032
IMPLEMENTS: Google.Protobuf.IMessage
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001BC  System.String ToDiagnosticString()
END_CLASS

CLASS: Google.Protobuf.IDeepCloneable`1
TYPE:  interface
TOKEN: 0x2000033
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001BD  T Clone()
END_CLASS

CLASS: Google.Protobuf.IExtendableMessage`1
TYPE:  interface
TOKEN: 0x2000034
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001BE  TValue GetExtension(Google.Protobuf.Extension<T,TValue> extension)
  RVA=-1  // abstract  token=0x60001BF  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
  RVA=-1  // abstract  token=0x60001C0  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
  RVA=-1  // abstract  token=0x60001C1  System.Void SetExtension(Google.Protobuf.Extension<T,TValue> extension, TValue value)
  RVA=-1  // abstract  token=0x60001C2  System.Boolean HasExtension(Google.Protobuf.Extension<T,TValue> extension)
  RVA=-1  // abstract  token=0x60001C3  System.Void ClearExtension(Google.Protobuf.Extension<T,TValue> extension)
  RVA=-1  // abstract  token=0x60001C4  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension)
END_CLASS

CLASS: Google.Protobuf.IMessage
TYPE:  interface
TOKEN: 0x2000035
FIELDS:
PROPERTIES:
  Descriptor  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60001C5  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=-1  // abstract  token=0x60001C6  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=-1  // abstract  token=0x60001C7  System.Int32 CalculateSize()
END_CLASS

CLASS: Google.Protobuf.IMessage`1
TYPE:  interface
TOKEN: 0x2000036
IMPLEMENTS: Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001C9  System.Void MergeFrom(T message)
END_CLASS

CLASS: Google.Protobuf.InvalidJsonException
TYPE:  sealed class
TOKEN: 0x2000037
SIZE:  0x90
EXTENDS: System.IO.IOException
FIELDS:
METHODS:
  RVA=0x08543FE8  token=0x60001CA  System.Void .ctor(System.String message)
END_CLASS

CLASS: Google.Protobuf.InvalidProtocolBufferException
TYPE:  sealed class
TOKEN: 0x2000038
SIZE:  0x90
EXTENDS: System.IO.IOException
FIELDS:
METHODS:
  RVA=0x08543FE8  token=0x60001CB  System.Void .ctor(System.String message)
  RVA=0x0854452C  token=0x60001CC  System.Void .ctor(System.String message, System.Exception innerException)
  RVA=0x08544338  token=0x60001CD  Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable()
  RVA=0x085444C8  token=0x60001CE  Google.Protobuf.InvalidProtocolBufferException TruncatedMessage()
  RVA=0x0854439C  token=0x60001CF  Google.Protobuf.InvalidProtocolBufferException NegativeSize()
  RVA=0x08544270  token=0x60001D0  Google.Protobuf.InvalidProtocolBufferException MalformedVarint()
  RVA=0x08544144  token=0x60001D1  Google.Protobuf.InvalidProtocolBufferException InvalidTag()
  RVA=0x085441A8  token=0x60001D2  Google.Protobuf.InvalidProtocolBufferException InvalidWireType()
  RVA=0x08544008  token=0x60001D3  Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException)
  RVA=0x0854407C  token=0x60001D4  Google.Protobuf.InvalidProtocolBufferException InvalidEndTag()
  RVA=0x08544400  token=0x60001D5  Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded()
  RVA=0x0854420C  token=0x60001D6  Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded()
  RVA=0x08544464  token=0x60001D7  Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded()
  RVA=0x085440E0  token=0x60001D8  Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag()
  RVA=0x085442D4  token=0x60001D9  Google.Protobuf.InvalidProtocolBufferException MissingFields()
END_CLASS

CLASS: Google.Protobuf.JsonFormatter
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x18
FIELDS:
  private   static  System.String                   AnyTypeUrlField  // const
  private   static  System.String                   AnyDiagnosticValueField  // const
  private   static  System.String                   AnyWellKnownTypeValueField  // const
  private   static  System.String                   TypeUrlPrefix  // const
  private   static  System.String                   NameValueSeparator  // const
  private   static  System.String                   PropertySeparator  // const
  private   static readonly Google.Protobuf.JsonFormatter   <Default>k__BackingField  // static @ 0x0
  private   static readonly Google.Protobuf.JsonFormatter   diagnosticFormatter  // static @ 0x8
  private   static readonly System.String[]                 CommonRepresentations  // static @ 0x10
  private   readonly Google.Protobuf.JsonFormatter.Settingssettings  // 0x10
  private   static  System.String                   Hex  // const
PROPERTIES:
  Default  get=0x0854975C
  DiagnosticOnly  get=0x085497AC
METHODS:
  RVA=0x0854854C  token=0x60001DB  System.Void .cctor()
  RVA=0x085496F4  token=0x60001DD  System.Void .ctor(Google.Protobuf.JsonFormatter.Settings settings)
  RVA=0x08544534  token=0x60001DE  System.String Format(Google.Protobuf.IMessage message)
  RVA=0x085445B8  token=0x60001DF  System.Void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer)
  RVA=0x08544CE0  token=0x60001E0  System.String ToDiagnosticString(Google.Protobuf.IMessage message)
  RVA=0x08546D4C  token=0x60001E1  System.Void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  RVA=0x08546A28  token=0x60001E2  System.Boolean WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, System.Boolean assumeFirstFieldWritten)
  RVA=0x08544C34  token=0x60001E3  System.Boolean ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, System.Object value)
  RVA=0x08544D6C  token=0x60001E4  System.String ToJsonName(System.String name)
  RVA=0x085446C8  token=0x60001E5  System.String FromJsonName(System.String name)
  RVA=0x08546EE8  token=0x60001E6  System.Void WriteNull(System.IO.TextWriter writer)
  RVA=0x085448E8  token=0x60001E7  System.Boolean IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, System.Object value)
  RVA=0x08547A94  token=0x60001E8  System.Void WriteValue(System.IO.TextWriter writer, System.Object value)
  RVA=0x085480DC  token=0x60001E9  System.Void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, System.Object value)
  RVA=0x08547908  token=0x60001EA  System.Void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  RVA=0x0854654C  token=0x60001EB  System.Void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  RVA=0x085466D8  token=0x60001EC  System.Void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  RVA=0x08544E78  token=0x60001ED  System.Void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  RVA=0x08545234  token=0x60001EE  System.Void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value)
  RVA=0x085474D8  token=0x60001EF  System.Void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  RVA=0x08547258  token=0x60001F0  System.Void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message)
  RVA=0x085467E4  token=0x60001F1  System.Void WriteList(System.IO.TextWriter writer, System.Collections.IList list)
  RVA=0x085454C0  token=0x60001F2  System.Void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary)
  RVA=0x08546F34  token=0x60001F3  System.Void WriteString(System.IO.TextWriter writer, System.String text)
  RVA=0x085447CC  token=0x60001F4  System.Void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, System.Char c)
END_CLASS

CLASS: Google.Protobuf.JsonParser
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x18
FIELDS:
  private   static readonly System.Text.RegularExpressions.RegexTimestampRegex  // static @ 0x0
  private   static readonly System.Text.RegularExpressions.RegexDurationRegex  // static @ 0x8
  private   static readonly System.Int32[]                  SubsecondScalingFactors  // static @ 0x10
  private   static readonly System.Char[]                   FieldMaskPathSeparators  // static @ 0x18
  private   static readonly Google.Protobuf.Reflection.EnumDescriptorNullValueDescriptor  // static @ 0x20
  private   static readonly Google.Protobuf.JsonParser      defaultInstance  // static @ 0x28
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.Action<Google.Protobuf.JsonParser,Google.Protobuf.IMessage,Google.Protobuf.JsonTokenizer>>WellKnownTypeHandlers  // static @ 0x30
  private   readonly Google.Protobuf.JsonParser.Settingssettings  // 0x10
PROPERTIES:
  Default  get=0x0854E660
METHODS:
  RVA=0x0854BA38  token=0x600020B  System.Void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854E5F8  token=0x600020D  System.Void .ctor(Google.Protobuf.JsonParser.Settings settings)
  RVA=0x0854C074  token=0x600020E  System.Void Merge(Google.Protobuf.IMessage message, System.String json)
  RVA=0x0854BF94  token=0x600020F  System.Void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader)
  RVA=0x0854BAD4  token=0x6000210  System.Void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854A6A0  token=0x6000211  System.Void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854AAB0  token=0x6000212  System.Void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854A824  token=0x6000213  System.Void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08549A0C  token=0x6000214  System.Boolean IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field)
  RVA=0x08549984  token=0x6000215  System.Boolean IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field)
  RVA=0x0854D24C  token=0x6000216  System.Object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=-1  // generic def  token=0x6000217  T Parse(System.String json)
  RVA=-1  // generic def  token=0x6000218  T Parse(System.IO.TextReader jsonReader)
  RVA=0x0854D680  token=0x6000219  Google.Protobuf.IMessage Parse(System.String json, Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=0x0854D5B8  token=0x600021A  Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=0x0854AC98  token=0x600021B  System.Void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854AFBC  token=0x600021C  System.Void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x08549A8C  token=0x600021D  System.Void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854B8D4  token=0x600021E  System.Void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer)
  RVA=0x0854C12C  token=0x600021F  System.Object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, System.String keyText)
  RVA=0x0854C598  token=0x6000220  System.Object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token)
  RVA=0x085497F8  token=0x6000221  System.Void CheckInteger(System.Double value)
  RVA=0x0854CB7C  token=0x6000222  System.Object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, System.String text)
  RVA=0x0854C0FC  token=0x6000223  Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field)
  RVA=-1  // generic def  token=0x6000224  T ParseNumericString(System.String text, System.Func<System.String,System.Globalization.NumberStyles,System.IFormatProvider,T> parser)
  RVA=0x0854D914  token=0x6000225  System.Void ValidateInfinityAndNan(System.String text, System.Boolean isPositiveInfinity, System.Boolean isNegativeInfinity, System.Boolean isNaN)
  RVA=0x0854B0DC  token=0x6000226  System.Void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  RVA=0x08549EB8  token=0x6000227  System.Void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  RVA=0x0854A4D8  token=0x6000228  System.Void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token)
  RVA=0x0854D764  token=0x6000229  System.String ToSnakeCase(System.String text)
  RVA=0x0854DA34  token=0x600022A  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.JsonToken
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   static readonly Google.Protobuf.JsonToken       _true  // static @ 0x0
  private   static readonly Google.Protobuf.JsonToken       _false  // static @ 0x8
  private   static readonly Google.Protobuf.JsonToken       _null  // static @ 0x10
  private   static readonly Google.Protobuf.JsonToken       startObject  // static @ 0x18
  private   static readonly Google.Protobuf.JsonToken       endObject  // static @ 0x20
  private   static readonly Google.Protobuf.JsonToken       startArray  // static @ 0x28
  private   static readonly Google.Protobuf.JsonToken       endArray  // static @ 0x30
  private   static readonly Google.Protobuf.JsonToken       endDocument  // static @ 0x38
  private   readonly Google.Protobuf.JsonToken.TokenTypetype  // 0x10
  private   readonly System.String                   stringValue  // 0x18
  private   readonly System.Double                   numberValue  // 0x20
PROPERTIES:
  Null  get=0x08550938
  False  get=0x085508E8
  True  get=0x08550A28
  StartObject  get=0x085509D8
  EndObject  get=0x08550898
  StartArray  get=0x08550988
  EndArray  get=0x085507F8
  EndDocument  get=0x08550848
  Type  get=0x03D4E340
  StringValue  get=0x01041090
  NumberValue  get=0x03D4F1C0
METHODS:
  RVA=0x08550170  token=0x6000248  Google.Protobuf.JsonToken Name(System.String name)
  RVA=0x0855047C  token=0x6000249  Google.Protobuf.JsonToken Value(System.String value)
  RVA=0x08550410  token=0x600024A  Google.Protobuf.JsonToken Value(System.Double value)
  RVA=0x085507D4  token=0x600024E  System.Void .ctor(Google.Protobuf.JsonToken.TokenType type, System.String stringValue, System.Double numberValue)
  RVA=0x08550098  token=0x600024F  System.Boolean Equals(System.Object obj)
  RVA=0x085500FC  token=0x6000250  System.Int32 GetHashCode()
  RVA=0x085501DC  token=0x6000251  System.String ToString()
  RVA=0x08550044  token=0x6000252  System.Boolean Equals(Google.Protobuf.JsonToken other)
  RVA=0x085504E8  token=0x6000253  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.JsonTokenizer
TYPE:  abstract class
TOKEN: 0x2000042
SIZE:  0x20
FIELDS:
  private           Google.Protobuf.JsonToken       bufferedToken  // 0x10
  private           System.Int32                    <ObjectDepth>k__BackingField  // 0x18
PROPERTIES:
  ObjectDepth  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x08550AE8  token=0x6000254  Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader)
  RVA=0x08550A78  token=0x6000255  Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation)
  RVA=0x08550BB8  token=0x6000258  System.Void PushBack(Google.Protobuf.JsonToken token)
  RVA=0x08550B48  token=0x6000259  Google.Protobuf.JsonToken Next()
  RVA=-1  // abstract  token=0x600025A  Google.Protobuf.JsonToken NextImpl()
  RVA=0x08550C50  token=0x600025B  System.Void SkipValue()
  RVA=0x0350B670  token=0x600025C  System.Void .ctor()
END_CLASS

CLASS: Google.Protobuf.LimitedInputStream
TYPE:  sealed class
TOKEN: 0x2000048
SIZE:  0x38
EXTENDS: System.IO.Stream
FIELDS:
  private   readonly System.IO.Stream                proxied  // 0x28
  private           System.Int32                    bytesLeft  // 0x30
PROPERTIES:
  CanRead  get=0x0232EB60
  CanSeek  get=0x0115F4C0
  CanWrite  get=0x0115F4C0
  Length  get=0x08550E84
  Position  get=0x08550ED0  set=0x08550F1C
METHODS:
  RVA=0x08550E24  token=0x6000273  System.Void .ctor(System.IO.Stream proxied, System.Int32 size)
  RVA=0x0350B670  token=0x6000277  System.Void Flush()
  RVA=0x08550CA0  token=0x600027B  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  RVA=0x08550D40  token=0x600027C  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  RVA=0x08550D8C  token=0x600027D  System.Void SetLength(System.Int64 value)
  RVA=0x08550DD8  token=0x600027E  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: Google.Protobuf.MessageExtensions
TYPE:  static class
TOKEN: 0x2000049
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08551348  token=0x600027F  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data)
  RVA=0x04272670  token=0x6000280  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length)
  RVA=0x08551210  token=0x6000281  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data)
  RVA=0x08551230  token=0x6000282  System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input)
  RVA=0x0427262C  token=0x6000283  System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> span)
  RVA=0x085511F0  token=0x6000284  System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input)
  RVA=0x08551670  token=0x6000285  System.Byte[] ToByteArray(Google.Protobuf.IMessage message)
  RVA=0x024D1E10  token=0x6000286  System.Int32 WriteToByteArray(Google.Protobuf.IMessage message, System.Byte[] buffer, System.Int32 pos)
  RVA=0x085518E8  token=0x6000287  System.Void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output)
  RVA=0x085517DC  token=0x6000288  System.Void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output)
  RVA=0x08551760  token=0x6000289  Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message)
  RVA=0x08551AA8  token=0x600028A  System.Void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<System.Byte> output)
  RVA=0x085519D4  token=0x600028B  System.Void WriteTo(Google.Protobuf.IMessage message, System.Span<System.Byte> output)
  RVA=0x08550F68  token=0x600028C  System.Boolean IsInitialized(Google.Protobuf.IMessage message)
  RVA=0x08551368  token=0x600028D  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x024D1780  token=0x600028E  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x08551250  token=0x600028F  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x08551484  token=0x6000290  System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x085515A4  token=0x6000291  System.Void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x0307A230  token=0x6000292  System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x085510EC  token=0x6000293  System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.MessageParser
TYPE:  class
TOKEN: 0x200004B
SIZE:  0x28
FIELDS:
  private           System.Func<Google.Protobuf.IMessage>factory  // 0x10
  private   readonly System.Boolean                  <DiscardUnknownFields>k__BackingField  // 0x18
  private   readonly Google.Protobuf.ExtensionRegistry<Extensions>k__BackingField  // 0x20
PROPERTIES:
  DiscardUnknownFields  get=0x01002A50
  Extensions  get=0x03D4EB40
METHODS:
  RVA=0x03240600  token=0x6000298  System.Void .ctor(System.Func<Google.Protobuf.IMessage> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions)
  RVA=0x08551BB0  token=0x6000299  Google.Protobuf.IMessage CreateTemplate()
  RVA=0x08551F2C  token=0x600029A  Google.Protobuf.IMessage ParseFrom(System.Byte[] data)
  RVA=0x08551DF0  token=0x600029B  Google.Protobuf.IMessage ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length)
  RVA=0x08551ED0  token=0x600029C  Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data)
  RVA=0x08551E74  token=0x600029D  Google.Protobuf.IMessage ParseFrom(System.IO.Stream input)
  RVA=0x08551FF0  token=0x600029E  Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data)
  RVA=0x08551F88  token=0x600029F  Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<System.Byte> data)
  RVA=0x08551D94  token=0x60002A0  Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input)
  RVA=0x08552060  token=0x60002A1  Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085520B4  token=0x60002A2  Google.Protobuf.IMessage ParseJson(System.String json)
  RVA=0x08551BD0  token=0x60002A3  System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput)
  RVA=0x08552130  token=0x60002A4  Google.Protobuf.MessageParser WithDiscardUnknownFields(System.Boolean discardUnknownFields)
  RVA=0x085521B8  token=0x60002A5  Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.MessageParser`1
TYPE:  sealed class
TOKEN: 0x200004C
EXTENDS: Google.Protobuf.MessageParser
FIELDS:
  private   readonly System.Func<T>                  factory  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002A6  System.Void .ctor(System.Func<T> factory)
  RVA=-1  // not resolved  token=0x60002A7  System.Void .ctor(System.Func<T> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions)
  RVA=-1  // not resolved  token=0x60002A8  T CreateTemplate()
  RVA=-1  // not resolved  token=0x60002A9  T ParseFrom(System.Byte[] data)
  RVA=-1  // not resolved  token=0x60002AA  T ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length)
  RVA=-1  // not resolved  token=0x60002AB  T ParseFrom(Google.Protobuf.ByteString data)
  RVA=-1  // not resolved  token=0x60002AC  T ParseFrom(System.IO.Stream input)
  RVA=-1  // not resolved  token=0x60002AD  T ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data)
  RVA=-1  // not resolved  token=0x60002AE  T ParseFrom(System.ReadOnlySpan<System.Byte> data)
  RVA=-1  // not resolved  token=0x60002AF  T ParseDelimitedFrom(System.IO.Stream input)
  RVA=-1  // not resolved  token=0x60002B0  T ParseFrom(Google.Protobuf.CodedInputStream input)
  RVA=-1  // not resolved  token=0x60002B1  T ParseJson(System.String json)
  RVA=-1  // not resolved  token=0x60002B2  Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(System.Boolean discardUnknownFields)
  RVA=-1  // not resolved  token=0x60002B3  Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry)
END_CLASS

CLASS: Google.Protobuf.ObjectIntPair`1
TYPE:  sealed struct
TOKEN: 0x200004E
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   readonly System.Int32                    number  // 0x0
  private   readonly T                               obj  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60002B6  System.Void .ctor(T obj, System.Int32 number)
  RVA=-1  // not resolved  token=0x60002B7  System.Boolean Equals(Google.Protobuf.ObjectIntPair<T> other)
  RVA=-1  // not resolved  token=0x60002B8  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x60002B9  System.Int32 GetHashCode()
END_CLASS

CLASS: Google.Protobuf.ParseContext
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0xA0
FIELDS:
  private   static  System.Int32                    DefaultRecursionLimit  // const
  private   static  System.Int32                    DefaultSizeLimit  // const
  private           System.ReadOnlySpan<System.Byte>buffer  // 0x10
  private           Google.Protobuf.ParserInternalStatestate  // 0x20
PROPERTIES:
  LastTag  get=0x03D4F0C0
  DiscardUnknownFields  get=0x03D51AD0  set=0x03D51B30
  ExtensionRegistry  get=0x03D4EA60  set=0x04274DA0
METHODS:
  RVA=0x08552A94  token=0x60002BA  System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParseContext& ctx)
  RVA=0x03D6BB50  token=0x60002BB  System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParserInternalState& state, Google.Protobuf.ParseContext& ctx)
  RVA=0x085529C8  token=0x60002BC  System.Void Initialize(Google.Protobuf.CodedInputStream input, Google.Protobuf.ParseContext& ctx)
  RVA=0x0855299C  token=0x60002BD  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, Google.Protobuf.ParseContext& ctx)
  RVA=0x085528E8  token=0x60002BE  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, System.Int32 recursionLimit, Google.Protobuf.ParseContext& ctx)
  RVA=0x08552D44  token=0x60002C4  System.UInt32 ReadTag()
  RVA=0x08552BF4  token=0x60002C5  System.Double ReadDouble()
  RVA=0x08552C24  token=0x60002C6  System.Single ReadFloat()
  RVA=0x08552C8C  token=0x60002C7  System.UInt64 ReadUInt64()
  RVA=0x08552C8C  token=0x60002C8  System.Int64 ReadInt64()
  RVA=0x08552C00  token=0x60002C9  System.Int32 ReadInt32()
  RVA=0x08552C18  token=0x60002CA  System.UInt64 ReadFixed64()
  RVA=0x08552C0C  token=0x60002CB  System.UInt32 ReadFixed32()
  RVA=0x08552BCC  token=0x60002CC  System.Boolean ReadBool()
  RVA=0x08552D38  token=0x60002CD  System.String ReadString()
  RVA=0x08552C98  token=0x60002CE  System.Void ReadMessage(Google.Protobuf.IMessage message)
  RVA=0x08552C30  token=0x60002CF  System.Void ReadGroup(Google.Protobuf.IMessage message)
  RVA=0x08552BE8  token=0x60002D0  Google.Protobuf.ByteString ReadBytes()
  RVA=0x08552C00  token=0x60002D1  System.UInt32 ReadUInt32()
  RVA=0x08552C00  token=0x60002D2  System.Int32 ReadEnum()
  RVA=0x08552C0C  token=0x60002D3  System.Int32 ReadSFixed32()
  RVA=0x08552C18  token=0x60002D4  System.Int64 ReadSFixed64()
  RVA=0x08552CF4  token=0x60002D5  System.Int32 ReadSInt32()
  RVA=0x08552D14  token=0x60002D6  System.Int64 ReadSInt64()
  RVA=0x08552C00  token=0x60002D7  System.Int32 ReadLength()
  RVA=0x03171C20  token=0x60002D8  System.Void CopyStateTo(Google.Protobuf.CodedInputStream input)
  RVA=0x08552B58  token=0x60002D9  System.Void LoadStateFrom(Google.Protobuf.CodedInputStream input)
END_CLASS

CLASS: Google.Protobuf.ParserInternalState
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x90
FIELDS:
  private           System.Int32                    bufferPos  // 0x10
  private           System.Int32                    bufferSize  // 0x14
  private           System.Int32                    bufferSizeAfterLimit  // 0x18
  private           System.Int32                    currentLimit  // 0x1c
  private           System.Int32                    totalBytesRetired  // 0x20
  private           System.Int32                    recursionDepth  // 0x24
  private           Google.Protobuf.SegmentedBufferHelpersegmentedBufferHelper  // 0x28
  private           System.UInt32                   lastTag  // 0x70
  private           System.UInt32                   nextTag  // 0x74
  private           System.Boolean                  hasNextTag  // 0x78
  private           System.Int32                    sizeLimit  // 0x7c
  private           System.Int32                    recursionLimit  // 0x80
  private           System.Boolean                  <DiscardUnknownFields>k__BackingField  // 0x84
  private           Google.Protobuf.ExtensionRegistry<ExtensionRegistry>k__BackingField  // 0x88
PROPERTIES:
  CodedInputStream  get=0x03D4EAA0
  DiscardUnknownFields  get=0x03D58980  set=0x03D5BFE0
  ExtensionRegistry  get=0x03D4EB20  set=0x051DFCA4
METHODS:
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitives
TYPE:  static class
TOKEN: 0x2000051
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    StackallocThreshold  // const
METHODS:
  RVA=0x0855D2E0  token=0x60002DF  System.Int32 ParseLength(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023A7E60  token=0x60002E0  System.UInt32 ParseTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x02BCF140  token=0x60002E1  System.Boolean MaybeConsumeTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 tag)
  RVA=0x02BCF1A0  token=0x60002E2  System.UInt32 PeekTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023C4190  token=0x60002E3  System.UInt64 ParseRawVarint64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023C4290  token=0x60002E4  System.UInt64 ParseRawVarint64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023A7F80  token=0x60002E5  System.UInt32 ParseRawVarint32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023A8E70  token=0x60002E6  System.UInt32 ParseRawVarint32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D374  token=0x60002E7  System.UInt32 ParseRawLittleEndian32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D2E8  token=0x60002E8  System.UInt32 ParseRawLittleEndian32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D4FC  token=0x60002E9  System.UInt64 ParseRawLittleEndian64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D400  token=0x60002EA  System.UInt64 ParseRawLittleEndian64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x030E8410  token=0x60002EB  System.Double ParseDouble(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x02F802D0  token=0x60002EC  System.Single ParseFloat(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D1BC  token=0x60002ED  System.Single ParseFloatSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023BD010  token=0x60002EE  System.Byte[] ReadRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x0855D760  token=0x60002EF  System.Byte[] ReadRawBytesSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x0855DCD0  token=0x60002F0  System.Void SkipRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x0855DC9C  token=0x60002F1  System.String ReadString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855D588  token=0x60002F2  Google.Protobuf.ByteString ReadBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x023BE5C0  token=0x60002F3  System.String ReadRawString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length)
  RVA=0x023BD690  token=0x60002F4  System.String ReadStringSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length)
  RVA=0x02FC8D50  token=0x60002F5  System.Void ValidateCurrentLimit(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x023A7E20  token=0x60002F6  System.Byte ReadRawByte(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855DBAC  token=0x60002F7  System.UInt32 ReadRawVarint32(System.IO.Stream input)
  RVA=0x03D6BBC0  token=0x60002F8  System.Int32 DecodeZigZag32(System.UInt32 n)
  RVA=0x03D6BBD0  token=0x60002F9  System.Int64 DecodeZigZag64(System.UInt64 n)
  RVA=0x031AB850  token=0x60002FA  System.Boolean IsDataAvailable(Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x0855D110  token=0x60002FB  System.Boolean IsDataAvailableInSource(Google.Protobuf.ParserInternalState& state, System.Int32 size)
  RVA=0x0855D5F8  token=0x60002FC  System.Void ReadRawBytesIntoSpan(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length, System.Span<System.Byte> byteSpan)
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitivesMessages
TYPE:  static class
TOKEN: 0x2000052
SIZE:  0x10
FIELDS:
  private   static readonly System.Byte[]                   ZeroLengthMessageStreamData  // static @ 0x0
METHODS:
  RVA=0x0855C5C0  token=0x60002FD  System.Void SkipLastField(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855C434  token=0x60002FE  System.Void SkipGroup(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 startGroupTag)
  RVA=0x023BF4C0  token=0x60002FF  System.Void ReadMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  RVA=-1  // generic def  token=0x6000300  System.Collections.Generic.KeyValuePair<TKey,TValue> ReadMapEntry(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=0x0855C2D8  token=0x6000301  System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  RVA=0x0855C380  token=0x6000302  System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, System.Int32 fieldNumber, Google.Protobuf.UnknownFieldSet set)
  RVA=0x023BF6D0  token=0x6000303  System.Void ReadRawMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message)
  RVA=0x023BF690  token=0x6000304  System.Void CheckReadEndOfStreamTag(Google.Protobuf.ParserInternalState& state)
  RVA=0x0855C29C  token=0x6000305  System.Void CheckLastTagWas(Google.Protobuf.ParserInternalState& state, System.UInt32 expectedTag)
  RVA=0x03D05200  token=0x6000306  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.ParsingPrimitivesWrappers
TYPE:  static class
TOKEN: 0x2000053
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0855CA0C  token=0x6000307  System.Nullable<System.Single> ReadFloatWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CAD4  token=0x6000308  System.Nullable<System.Single> ReadFloatWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855C828  token=0x6000309  System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855C924  token=0x600030A  System.Nullable<System.Double> ReadDoubleWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855C75C  token=0x600030B  System.Nullable<System.Boolean> ReadBoolWrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CDF0  token=0x600030C  System.Nullable<System.UInt32> ReadUInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CD18  token=0x600030D  System.Nullable<System.UInt32> ReadUInt32WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CBCC  token=0x600030E  System.Nullable<System.Int32> ReadInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CFF0  token=0x600030F  System.Nullable<System.UInt64> ReadUInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CF0C  token=0x6000310  System.Nullable<System.UInt64> ReadUInt64WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CC78  token=0x6000311  System.Nullable<System.Int64> ReadInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x0855CAC8  token=0x6000312  System.Nullable<System.Single> ReadFloatWrapperLittleEndian(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855CBB4  token=0x6000313  System.Nullable<System.Single> ReadFloatWrapperSlow(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855C7FC  token=0x6000314  System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855C8F8  token=0x6000315  System.Nullable<System.Double> ReadDoubleWrapperSlow(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855C7F0  token=0x6000316  System.Nullable<System.Boolean> ReadBoolWrapper(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855CED4  token=0x6000317  System.Nullable<System.UInt32> ReadUInt32Wrapper(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855CBC0  token=0x6000318  System.Nullable<System.Int32> ReadInt32Wrapper(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855D0E4  token=0x6000319  System.Nullable<System.UInt64> ReadUInt64Wrapper(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855CEE0  token=0x600031A  System.Nullable<System.UInt64> ReadUInt64WrapperSlow(Google.Protobuf.ParseContext& ctx)
  RVA=0x0855CC4C  token=0x600031B  System.Nullable<System.Int64> ReadInt64Wrapper(Google.Protobuf.ParseContext& ctx)
END_CLASS

CLASS: Google.Protobuf.ProtoPreconditions
TYPE:  static class
TOKEN: 0x2000054
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x600031C  T CheckNotNull(T value, System.String name)
  RVA=-1  // generic def  token=0x600031D  T CheckNotNullUnconstrained(T value, System.String name)
END_CLASS

CLASS: Google.Protobuf.SegmentedBufferHelper
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x58
FIELDS:
  private           System.Nullable<System.Int32>   totalLength  // 0x10
  private           System.Buffers.ReadOnlySequence.Enumerator<System.Byte>readOnlySequenceEnumerator  // 0x18
  private           Google.Protobuf.CodedInputStreamcodedInputStream  // 0x50
PROPERTIES:
  TotalLength  get=0x020C61B0
  CodedInputStream  get=0x03D4E2B0
METHODS:
  RVA=0x0855DD84  token=0x600031E  System.Void Initialize(Google.Protobuf.CodedInputStream codedInputStream, Google.Protobuf.SegmentedBufferHelper& instance)
  RVA=0x0855DE1C  token=0x600031F  System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> sequence, Google.Protobuf.SegmentedBufferHelper& instance, System.ReadOnlySpan<System.Byte>& firstSpan)
  RVA=0x023A9A00  token=0x6000320  System.Boolean RefillBuffer(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  RVA=0x023BF600  token=0x6000323  System.Int32 PushLimit(Google.Protobuf.ParserInternalState& state, System.Int32 byteLimit)
  RVA=0x0426FC34  token=0x6000324  System.Void PopLimit(Google.Protobuf.ParserInternalState& state, System.Int32 oldLimit)
  RVA=0x023BF6B0  token=0x6000325  System.Boolean IsReachedLimit(Google.Protobuf.ParserInternalState& state)
  RVA=0x0855E014  token=0x6000326  System.Boolean IsAtEnd(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state)
  RVA=0x031267E0  token=0x6000327  System.Boolean RefillFromReadOnlySequence(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  RVA=0x023A9CB0  token=0x6000328  System.Boolean RefillFromCodedInputStream(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed)
  RVA=0x023BF660  token=0x6000329  System.Void RecomputeBufferSizeAfterLimit(Google.Protobuf.ParserInternalState& state)
  RVA=0x023A9D70  token=0x600032A  System.Void CheckCurrentBufferIsEmpty(Google.Protobuf.ParserInternalState& state)
END_CLASS

CLASS: Google.Protobuf.UnknownField
TYPE:  sealed class
TOKEN: 0x2000056
SIZE:  0x38
FIELDS:
  private           System.Collections.Generic.List<System.UInt64>varintList  // 0x10
  private           System.Collections.Generic.List<System.UInt32>fixed32List  // 0x18
  private           System.Collections.Generic.List<System.UInt64>fixed64List  // 0x20
  private           System.Collections.Generic.List<Google.Protobuf.ByteString>lengthDelimitedList  // 0x28
  private           System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet>groupList  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600032B  System.Void .ctor()
  RVA=0x085638B4  token=0x600032C  System.Boolean Equals(System.Object other)
  RVA=0x085639B8  token=0x600032D  System.Int32 GetHashCode()
  RVA=0x085640B4  token=0x600032E  System.Void WriteTo(System.Int32 fieldNumber, Google.Protobuf.WriteContext& output)
  RVA=0x08563AA0  token=0x600032F  System.Int32 GetSerializedSize(System.Int32 fieldNumber)
  RVA=0x08563FA4  token=0x6000330  Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other)
  RVA=-1  // generic def  token=0x6000331  System.Collections.Generic.List<T> AddAll(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras)
  RVA=0x08563858  token=0x6000332  Google.Protobuf.UnknownField AddVarint(System.UInt64 value)
  RVA=0x085636EC  token=0x6000333  Google.Protobuf.UnknownField AddFixed32(System.UInt32 value)
  RVA=0x08563744  token=0x6000334  Google.Protobuf.UnknownField AddFixed64(System.UInt64 value)
  RVA=0x085637FC  token=0x6000335  Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value)
  RVA=0x085637A0  token=0x6000336  Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value)
  RVA=-1  // generic def  token=0x6000337  System.Collections.Generic.List<T> Add(System.Collections.Generic.List<T> list, T value)
END_CLASS

CLASS: Google.Protobuf.UnknownFieldSet
TYPE:  sealed class
TOKEN: 0x2000057
SIZE:  0x28
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.UnknownField>fields  // 0x10
  private           System.Int32                    lastFieldNumber  // 0x18
  private           Google.Protobuf.UnknownField    lastField  // 0x20
METHODS:
  RVA=0x08563674  token=0x6000338  System.Void .ctor()
  RVA=0x08562C34  token=0x6000339  System.Boolean HasField(System.Int32 field)
  RVA=0x085633D8  token=0x600033A  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0856349C  token=0x600033B  System.Void WriteTo(Google.Protobuf.WriteContext& ctx)
  RVA=0x085625F8  token=0x600033C  System.Int32 CalculateSize()
  RVA=0x0856275C  token=0x600033D  System.Boolean Equals(System.Object other)
  RVA=0x085629E8  token=0x600033E  System.Int32 GetHashCode()
  RVA=0x08562B74  token=0x600033F  Google.Protobuf.UnknownField GetOrAddField(System.Int32 number)
  RVA=0x08562530  token=0x6000340  Google.Protobuf.UnknownFieldSet AddOrReplaceField(System.Int32 number, Google.Protobuf.UnknownField field)
  RVA=0x08562E70  token=0x6000341  System.Boolean MergeFieldFrom(Google.Protobuf.ParseContext& ctx)
  RVA=0x0856338C  token=0x6000342  System.Void MergeGroupFrom(Google.Protobuf.ParseContext& ctx)
  RVA=0x08562D84  token=0x6000343  Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input)
  RVA=0x08562C8C  token=0x6000344  Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.ParseContext& ctx)
  RVA=0x085631AC  token=0x6000345  Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other)
  RVA=0x08563134  token=0x6000346  Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other)
  RVA=0x08563064  token=0x6000347  Google.Protobuf.UnknownFieldSet MergeField(System.Int32 number, Google.Protobuf.UnknownField field)
  RVA=0x02F0D8A0  token=0x6000348  Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other)
END_CLASS

CLASS: Google.Protobuf.UnsafeByteOperations
TYPE:  static class
TOKEN: 0x2000058
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08564684  token=0x6000349  Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<System.Byte> bytes)
END_CLASS

CLASS: Google.Protobuf.WireFormat
TYPE:  static class
TOKEN: 0x2000059
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    TagTypeBits  // const
  private   static  System.UInt32                   TagTypeMask  // const
METHODS:
  RVA=0x03D6BBF0  token=0x600034A  Google.Protobuf.WireFormat.WireType GetTagWireType(System.UInt32 tag)
  RVA=0x03D6BBE0  token=0x600034B  System.Int32 GetTagFieldNumber(System.UInt32 tag)
  RVA=0x03D6BC00  token=0x600034C  System.UInt32 MakeTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType wireType)
END_CLASS

CLASS: Google.Protobuf.WriteBufferHelper
TYPE:  sealed struct
TOKEN: 0x200005B
SIZE:  0x20
FIELDS:
  private           System.Buffers.IBufferWriter<System.Byte>bufferWriter  // 0x10
  private           Google.Protobuf.CodedOutputStreamcodedOutputStream  // 0x18
PROPERTIES:
  CodedOutputStream  get=0x03D50DE0
METHODS:
  RVA=0x024D20C0  token=0x600034E  System.Void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, Google.Protobuf.WriteBufferHelper& instance)
  RVA=0x0853DCDC  token=0x600034F  System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> bufferWriter, Google.Protobuf.WriteBufferHelper& instance, System.Span<System.Byte>& buffer)
  RVA=0x0853DCB8  token=0x6000350  System.Void InitializeNonRefreshable(Google.Protobuf.WriteBufferHelper& instance)
  RVA=0x0853DB28  token=0x6000351  System.Void CheckNoSpaceLeft(Google.Protobuf.WriterInternalState& state)
  RVA=0x0853DC3C  token=0x6000352  System.Int32 GetSpaceLeft(Google.Protobuf.WriterInternalState& state)
  RVA=0x08565BF4  token=0x6000353  System.Void RefreshBuffer(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state)
  RVA=0x08565B4C  token=0x6000354  System.Void Flush(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state)
END_CLASS

CLASS: Google.Protobuf.WriteContext
TYPE:  sealed struct
TOKEN: 0x200005C
SIZE:  0x38
FIELDS:
  private           System.Span<System.Byte>        buffer  // 0x10
  private           Google.Protobuf.WriterInternalStatestate  // 0x20
METHODS:
  RVA=0x03D6BC10  token=0x6000355  System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.WriteContext& ctx)
  RVA=0x08565D84  token=0x6000356  System.Void Initialize(Google.Protobuf.CodedOutputStream output, Google.Protobuf.WriteContext& ctx)
  RVA=0x08565E00  token=0x6000357  System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> output, Google.Protobuf.WriteContext& ctx)
  RVA=0x08565D28  token=0x6000358  System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriteContext& ctx)
  RVA=0x033C0400  token=0x6000359  System.Void WriteDouble(System.Double value)
  RVA=0x024D4440  token=0x600035A  System.Void WriteFloat(System.Single value)
  RVA=0x024D4FF0  token=0x600035B  System.Void WriteUInt64(System.UInt64 value)
  RVA=0x024D5100  token=0x600035C  System.Void WriteInt64(System.Int64 value)
  RVA=0x024D4610  token=0x600035D  System.Void WriteInt32(System.Int32 value)
  RVA=0x08565EE4  token=0x600035E  System.Void WriteFixed64(System.UInt64 value)
  RVA=0x08565E90  token=0x600035F  System.Void WriteFixed32(System.UInt32 value)
  RVA=0x033C0870  token=0x6000360  System.Void WriteBool(System.Boolean value)
  RVA=0x024D52F0  token=0x6000361  System.Void WriteString(System.String value)
  RVA=0x04270278  token=0x6000362  System.Void WriteMessage(Google.Protobuf.IMessage value)
  RVA=0x08565F38  token=0x6000363  System.Void WriteGroup(Google.Protobuf.IMessage value)
  RVA=0x03543420  token=0x6000364  System.Void WriteBytes(Google.Protobuf.ByteString value)
  RVA=0x024D4680  token=0x6000365  System.Void WriteUInt32(System.UInt32 value)
  RVA=0x024D48E0  token=0x6000366  System.Void WriteEnum(System.Int32 value)
  RVA=0x085660CC  token=0x6000367  System.Void WriteSFixed32(System.Int32 value)
  RVA=0x08566120  token=0x6000368  System.Void WriteSFixed64(System.Int64 value)
  RVA=0x08566174  token=0x6000369  System.Void WriteSInt32(System.Int32 value)
  RVA=0x085661C8  token=0x600036A  System.Void WriteSInt64(System.Int64 value)
  RVA=0x0397C1E0  token=0x600036B  System.Void WriteLength(System.Int32 length)
  RVA=0x0856621C  token=0x600036C  System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  RVA=0x024D3390  token=0x600036D  System.Void WriteTag(System.UInt32 tag)
  RVA=0x024D4230  token=0x600036E  System.Void WriteRawTag(System.Byte b1)
  RVA=0x024D4E60  token=0x600036F  System.Void WriteRawTag(System.Byte b1, System.Byte b2)
  RVA=0x08565FC4  token=0x6000370  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3)
  RVA=0x08565F40  token=0x6000371  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  RVA=0x08566040  token=0x6000372  System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  RVA=0x08565D1C  token=0x6000373  System.Void Flush()
  RVA=0x08565D10  token=0x6000374  System.Void CheckNoSpaceLeft()
  RVA=0x031C0BC0  token=0x6000375  System.Void CopyStateTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08565E68  token=0x6000376  System.Void LoadStateFrom(Google.Protobuf.CodedOutputStream output)
END_CLASS

CLASS: Google.Protobuf.WriterInternalState
TYPE:  sealed struct
TOKEN: 0x200005D
SIZE:  0x28
FIELDS:
  private           System.Int32                    limit  // 0x10
  private           System.Int32                    position  // 0x14
  private           Google.Protobuf.WriteBufferHelperwriteBufferHelper  // 0x18
PROPERTIES:
  CodedOutputStream  get=0x020B7B20
METHODS:
END_CLASS

CLASS: Google.Protobuf.WritingPrimitives
TYPE:  static class
TOKEN: 0x200005E
SIZE:  0x10
FIELDS:
  private   static readonly System.Text.Encoding            Utf8Encoding  // static @ 0x0
METHODS:
  RVA=0x033C0470  token=0x6000378  System.Void WriteDouble(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Double value)
  RVA=0x024D44B0  token=0x6000379  System.Void WriteFloat(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value)
  RVA=0x08566628  token=0x600037A  System.Void WriteFloatSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value)
  RVA=0x024D5090  token=0x600037B  System.Void WriteUInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  RVA=0x024D51A0  token=0x600037C  System.Void WriteInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  RVA=0x024D4C40  token=0x600037D  System.Void WriteInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  RVA=0x085665C8  token=0x600037E  System.Void WriteFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  RVA=0x08566568  token=0x600037F  System.Void WriteFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  RVA=0x033C08E0  token=0x6000380  System.Void WriteBool(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Boolean value)
  RVA=0x024D5360  token=0x6000381  System.Void WriteString(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.String value)
  RVA=0x02D4A540  token=0x6000382  System.Void WriteAsciiStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value, System.Int32 length)
  RVA=0x085664E0  token=0x6000383  System.Void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(System.Byte& outputBuffer, System.UInt64 value)
  RVA=0x024D55A0  token=0x6000384  System.Int32 WriteStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value)
  RVA=0x03543490  token=0x6000385  System.Void WriteBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.ByteString value)
  RVA=0x024D47D0  token=0x6000386  System.Void WriteUInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  RVA=0x024D4AB0  token=0x6000387  System.Void WriteEnum(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  RVA=0x085670D4  token=0x6000388  System.Void WriteSFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  RVA=0x08567134  token=0x6000389  System.Void WriteSFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  RVA=0x08567194  token=0x600038A  System.Void WriteSInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value)
  RVA=0x08567200  token=0x600038B  System.Void WriteSInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value)
  RVA=0x024D3DD0  token=0x600038C  System.Void WriteLength(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 length)
  RVA=0x024D4D90  token=0x600038D  System.Void WriteRawVarint32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  RVA=0x024D5210  token=0x600038E  System.Void WriteRawVarint64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  RVA=0x085669A4  token=0x600038F  System.Void WriteRawLittleEndian32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  RVA=0x08566904  token=0x6000390  System.Void WriteRawLittleEndian32SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value)
  RVA=0x033C0510  token=0x6000391  System.Void WriteRawLittleEndian64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  RVA=0x08566A60  token=0x6000392  System.Void WriteRawLittleEndian64SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value)
  RVA=0x024D43D0  token=0x6000393  System.Void WriteRawByte(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte value)
  RVA=0x085667BC  token=0x6000394  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value)
  RVA=0x08566860  token=0x6000395  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value, System.Int32 offset, System.Int32 length)
  RVA=0x03543680  token=0x6000396  System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.ReadOnlySpan<System.Byte> value)
  RVA=0x0856726C  token=0x6000397  System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type)
  RVA=0x024D3400  token=0x6000398  System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 tag)
  RVA=0x024D4320  token=0x6000399  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1)
  RVA=0x024D4F40  token=0x600039A  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2)
  RVA=0x08566D44  token=0x600039B  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2)
  RVA=0x08566FF4  token=0x600039C  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3)
  RVA=0x08566C0C  token=0x600039D  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3)
  RVA=0x08566DC4  token=0x600039E  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  RVA=0x08566CA0  token=0x600039F  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4)
  RVA=0x08566EC8  token=0x60003A0  System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  RVA=0x08566B54  token=0x60003A1  System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5)
  RVA=0x03D6BC30  token=0x60003A2  System.UInt32 EncodeZigZag32(System.Int32 n)
  RVA=0x03D6BC40  token=0x60003A3  System.UInt64 EncodeZigZag64(System.Int64 n)
  RVA=0x03D26FB0  token=0x60003A4  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WritingPrimitivesMessages
TYPE:  static class
TOKEN: 0x200005F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08566284  token=0x60003A5  System.Void WriteMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value)
  RVA=0x08565F38  token=0x60003A6  System.Void WriteGroup(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value)
  RVA=0x0856631C  token=0x60003A7  System.Void WriteRawMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.Collections.Lists
TYPE:  static class
TOKEN: 0x200012E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000C02  System.Boolean Equals(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right)
  RVA=-1  // generic def  token=0x6000C03  System.Int32 GetHashCode(System.Collections.Generic.List<T> list)
END_CLASS

CLASS: Google.Protobuf.Collections.MapField`2
TYPE:  sealed class
TOKEN: 0x200012F
IMPLEMENTS: Google.Protobuf.IDeepCloneable`1 System.Collections.Generic.IDictionary`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.IEquatable`1 System.Collections.IDictionary System.Collections.ICollection System.Collections.Generic.IReadOnlyDictionary`2 System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<TValue>ValueEqualityComparer  // static @ 0x0
  private   static readonly System.Collections.Generic.EqualityComparer<TKey>KeyEqualityComparer  // static @ 0x0
  private   readonly System.Collections.Generic.Dictionary<TKey,System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey,TValue>>>map  // 0x0
  private   readonly System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey,TValue>>list  // 0x0
PROPERTIES:
  Item  get=-1  // not resolved  set=-1  // not resolved
  Keys  get=-1  // not resolved
  Values  get=-1  // not resolved
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  System.Collections.IDictionary.IsFixedSize  get=-1  // not resolved
  System.Collections.IDictionary.Keys  get=-1  // not resolved
  System.Collections.IDictionary.Values  get=-1  // not resolved
  System.Collections.ICollection.IsSynchronized  get=-1  // not resolved
  System.Collections.ICollection.SyncRoot  get=-1  // not resolved
  System.Collections.IDictionary.Item  get=-1  // not resolved  set=-1  // not resolved
  System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys  get=-1  // not resolved
  System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C04  Google.Protobuf.Collections.MapField<TKey,TValue> Clone()
  RVA=-1  // not resolved  token=0x6000C05  System.Void Add(TKey key, TValue value)
  RVA=-1  // not resolved  token=0x6000C06  System.Boolean ContainsKey(TKey key)
  RVA=-1  // not resolved  token=0x6000C07  System.Boolean ContainsValue(TValue value)
  RVA=-1  // not resolved  token=0x6000C08  System.Boolean Remove(TKey key)
  RVA=-1  // not resolved  token=0x6000C09  System.Boolean TryGetValue(TKey key, TValue& value)
  RVA=-1  // not resolved  token=0x6000C0E  System.Void Add(System.Collections.Generic.IDictionary<TKey,TValue> entries)
  RVA=-1  // not resolved  token=0x6000C0F  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C10  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C11  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C12  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000C13  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C14  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000C15  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C18  System.Boolean Equals(System.Object other)
  RVA=-1  // not resolved  token=0x6000C19  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x6000C1A  System.Boolean Equals(Google.Protobuf.Collections.MapField<TKey,TValue> other)
  RVA=-1  // not resolved  token=0x6000C1B  System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=-1  // not resolved  token=0x6000C1C  System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=-1  // not resolved  token=0x6000C1D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=-1  // not resolved  token=0x6000C1E  System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=-1  // not resolved  token=0x6000C1F  System.Int32 CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec)
  RVA=-1  // not resolved  token=0x6000C20  System.Int32 CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec, System.Collections.Generic.KeyValuePair<TKey,TValue> entry)
  RVA=-1  // not resolved  token=0x6000C21  System.String ToString()
  RVA=-1  // not resolved  token=0x6000C22  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  RVA=-1  // not resolved  token=0x6000C23  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  RVA=-1  // not resolved  token=0x6000C24  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C25  System.Void System.Collections.IDictionary.Remove(System.Object key)
  RVA=-1  // not resolved  token=0x6000C26  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  RVA=-1  // not resolved  token=0x6000C30  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000C31  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Collections.ProtobufEqualityComparers
TYPE:  static class
TOKEN: 0x2000135
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<System.Double><BitwiseDoubleEqualityComparer>k__BackingField  // static @ 0x0
  private   static readonly System.Collections.Generic.EqualityComparer<System.Single><BitwiseSingleEqualityComparer>k__BackingField  // static @ 0x8
  private   static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>><BitwiseNullableDoubleEqualityComparer>k__BackingField  // static @ 0x10
  private   static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>><BitwiseNullableSingleEqualityComparer>k__BackingField  // static @ 0x18
PROPERTIES:
  BitwiseDoubleEqualityComparer  get=0x08594BD0
  BitwiseSingleEqualityComparer  get=0x08594CC0
  BitwiseNullableDoubleEqualityComparer  get=0x08594C20
  BitwiseNullableSingleEqualityComparer  get=0x08594C70
METHODS:
  RVA=-1  // generic def  token=0x6000C51  System.Collections.Generic.EqualityComparer<T> GetEqualityComparer()
  RVA=0x039D7870  token=0x6000C56  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Collections.ReadOnlyDictionary`2
TYPE:  sealed class
TOKEN: 0x200013A
IMPLEMENTS: System.Collections.Generic.IDictionary`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<TKey,TValue>wrapped  // 0x0
PROPERTIES:
  Keys  get=-1  // not resolved
  Values  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C63  System.Void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> wrapped)
  RVA=-1  // not resolved  token=0x6000C64  System.Void Add(TKey key, TValue value)
  RVA=-1  // not resolved  token=0x6000C65  System.Boolean ContainsKey(TKey key)
  RVA=-1  // not resolved  token=0x6000C67  System.Boolean Remove(TKey key)
  RVA=-1  // not resolved  token=0x6000C68  System.Boolean TryGetValue(TKey key, TValue& value)
  RVA=-1  // not resolved  token=0x6000C6C  System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C6D  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000C6E  System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C6F  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000C72  System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000C73  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C74  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C75  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x6000C76  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x6000C77  System.String ToString()
END_CLASS

CLASS: Google.Protobuf.Collections.RepeatedField`1
TYPE:  sealed class
TOKEN: 0x200013B
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.IList System.Collections.ICollection Google.Protobuf.IDeepCloneable`1 System.IEquatable`1 System.Collections.Generic.IReadOnlyList`1 System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  private   static readonly System.Collections.Generic.EqualityComparer<T>EqualityComparer  // static @ 0x0
  private   static readonly T[]                             EmptyArray  // static @ 0x0
  private   static  System.Int32                    MinArraySize  // const
  private           T[]                             array  // 0x0
  private           System.Int32                    count  // 0x0
PROPERTIES:
  Capacity  get=-1  // not resolved  set=-1  // not resolved
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
  System.Collections.IList.IsFixedSize  get=-1  // not resolved
  System.Collections.ICollection.IsSynchronized  get=-1  // not resolved
  System.Collections.ICollection.SyncRoot  get=-1  // not resolved
  System.Collections.IList.Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000C78  Google.Protobuf.Collections.RepeatedField<T> Clone()
  RVA=-1  // not resolved  token=0x6000C79  System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C7A  System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C7B  System.Int32 CalculateSize(Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C7C  System.Int32 CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C7D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C7E  System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.FieldCodec<T> codec)
  RVA=-1  // not resolved  token=0x6000C81  System.Void EnsureSize(System.Int32 size)
  RVA=-1  // not resolved  token=0x6000C82  System.Void SetSize(System.Int32 size)
  RVA=-1  // not resolved  token=0x6000C83  System.Void SetCount(System.Int32 newCount)
  RVA=-1  // not resolved  token=0x6000C84  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000C85  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000C86  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000C87  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000C88  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x6000C8B  System.Void AddRange(System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // not resolved  token=0x6000C8C  System.Void Add(System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // not resolved  token=0x6000C8D  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C8E  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x6000C8F  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000C90  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x6000C91  System.Boolean Equals(Google.Protobuf.Collections.RepeatedField<T> other)
  RVA=-1  // not resolved  token=0x6000C92  System.Int32 IndexOf(T item)
  RVA=-1  // not resolved  token=0x6000C93  System.Void Insert(System.Int32 index, T item)
  RVA=-1  // not resolved  token=0x6000C94  System.Void RemoveAt(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000C95  System.String ToString()
  RVA=-1  // not resolved  token=0x6000C99  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  RVA=-1  // not resolved  token=0x6000C9E  System.Int32 System.Collections.IList.Add(System.Object value)
  RVA=-1  // not resolved  token=0x6000C9F  System.Boolean System.Collections.IList.Contains(System.Object value)
  RVA=-1  // not resolved  token=0x6000CA0  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  RVA=-1  // not resolved  token=0x6000CA1  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  RVA=-1  // not resolved  token=0x6000CA2  System.Void System.Collections.IList.Remove(System.Object value)
  RVA=-1  // not resolved  token=0x6000CA3  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000CA4  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Compatibility.PropertyInfoExtensions
TYPE:  static class
TOKEN: 0x200012C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08594B30  token=0x6000BFD  System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target)
  RVA=0x08594B80  token=0x6000BFE  System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target)
END_CLASS

CLASS: Google.Protobuf.Compatibility.TypeExtensions
TYPE:  static class
TOKEN: 0x200012D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08596940  token=0x6000BFF  System.Boolean IsAssignableFrom(System.Type target, System.Type c)
  RVA=0x0859682C  token=0x6000C00  System.Reflection.PropertyInfo GetProperty(System.Type target, System.String name)
  RVA=0x08596774  token=0x6000C01  System.Reflection.MethodInfo GetMethod(System.Type target, System.String name)
END_CLASS

CLASS: Google.Protobuf.Reflection.CustomOptions
TYPE:  sealed class
TOKEN: 0x20000A6
SIZE:  0x18
FIELDS:
  private   static  System.String                   UnreferencedCodeMessage  // const
  private   static readonly System.Object[]                 EmptyParameters  // static @ 0x0
  private   readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue>values  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000683  System.Void .ctor(System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values)
  RVA=0x085681B4  token=0x6000684  System.Boolean TryGetBool(System.Int32 field, System.Boolean& value)
  RVA=0x08568324  token=0x6000685  System.Boolean TryGetInt32(System.Int32 field, System.Int32& value)
  RVA=0x0856837C  token=0x6000686  System.Boolean TryGetInt64(System.Int32 field, System.Int64& value)
  RVA=0x085682BC  token=0x6000687  System.Boolean TryGetFixed32(System.Int32 field, System.UInt32& value)
  RVA=0x085682C4  token=0x6000688  System.Boolean TryGetFixed64(System.Int32 field, System.UInt64& value)
  RVA=0x085683D4  token=0x6000689  System.Boolean TryGetSFixed32(System.Int32 field, System.Int32& value)
  RVA=0x085683DC  token=0x600068A  System.Boolean TryGetSFixed64(System.Int32 field, System.Int64& value)
  RVA=0x085683E4  token=0x600068B  System.Boolean TryGetSInt32(System.Int32 field, System.Int32& value)
  RVA=0x0856843C  token=0x600068C  System.Boolean TryGetSInt64(System.Int32 field, System.Int64& value)
  RVA=0x085684EC  token=0x600068D  System.Boolean TryGetUInt32(System.Int32 field, System.UInt32& value)
  RVA=0x08568544  token=0x600068E  System.Boolean TryGetUInt64(System.Int32 field, System.UInt64& value)
  RVA=0x085682CC  token=0x600068F  System.Boolean TryGetFloat(System.Int32 field, System.Single& value)
  RVA=0x08568264  token=0x6000690  System.Boolean TryGetDouble(System.Int32 field, System.Double& value)
  RVA=0x08568494  token=0x6000691  System.Boolean TryGetString(System.Int32 field, System.String& value)
  RVA=0x0856820C  token=0x6000692  System.Boolean TryGetBytes(System.Int32 field, Google.Protobuf.ByteString& value)
  RVA=-1  // generic def  token=0x6000693  System.Boolean TryGetMessage(System.Int32 field, T& value)
  RVA=-1  // generic def  token=0x6000694  System.Boolean TryGetPrimitiveValue(System.Int32 field, T& value)
  RVA=0x0856859C  token=0x6000695  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorReflection
TYPE:  static class
TOKEN: 0x20000A8
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x0856D514
METHODS:
  RVA=0x08569F38  token=0x600069B  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptorSet
TYPE:  sealed class
TOKEN: 0x20000A9
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FileFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto>_repeated_file_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto>file_  // 0x18
PROPERTIES:
  Parser  get=0x08575A54
  Descriptor  get=0x085759F4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08575C18
  File  get=0x01041090
METHODS:
  RVA=0x0857597C  token=0x600069F  System.Void .ctor()
  RVA=0x085758F4  token=0x60006A0  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorSet other)
  RVA=0x08575580  token=0x60006A1  Google.Protobuf.Reflection.FileDescriptorSet Clone()
  RVA=0x085755E0  token=0x60006A3  System.Boolean Equals(System.Object other)
  RVA=0x08575644  token=0x60006A4  System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorSet other)
  RVA=0x0517BB20  token=0x60006A5  System.Int32 GetHashCode()
  RVA=0x08575738  token=0x60006A6  System.String ToString()
  RVA=0x03D47770  token=0x60006A7  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08575B74  token=0x60006A8  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085754EC  token=0x60006A9  System.Int32 CalculateSize()
  RVA=0x085756C0  token=0x60006AA  System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other)
  RVA=0x03D47500  token=0x60006AB  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08575AA4  token=0x60006AC  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08575784  token=0x60006AD  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000AB
SIZE:  0x78
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    PackageFieldNumber  // const
  private   static readonly System.String                   PackageDefaultValue  // static @ 0x10
  private           System.String                   package_  // 0x20
  public    static  System.Int32                    DependencyFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_dependency_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>dependency_  // 0x28
  public    static  System.Int32                    PublicDependencyFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_publicDependency_codec  // static @ 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>publicDependency_  // 0x30
  public    static  System.Int32                    WeakDependencyFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.Int32>_repeated_weakDependency_codec  // static @ 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<System.Int32>weakDependency_  // 0x38
  public    static  System.Int32                    MessageTypeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto>_repeated_messageType_codec  // static @ 0x30
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto>messageType_  // 0x40
  public    static  System.Int32                    EnumTypeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto>_repeated_enumType_codec  // static @ 0x38
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto>enumType_  // 0x48
  public    static  System.Int32                    ServiceFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto>_repeated_service_codec  // static @ 0x40
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto>service_  // 0x50
  public    static  System.Int32                    ExtensionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_extension_codec  // static @ 0x48
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>extension_  // 0x58
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.FileOptionsoptions_  // 0x60
  public    static  System.Int32                    SourceCodeInfoFieldNumber  // const
  private           Google.Protobuf.Reflection.SourceCodeInfosourceCodeInfo_  // 0x68
  public    static  System.Int32                    SyntaxFieldNumber  // const
  private   static readonly System.String                   SyntaxDefaultValue  // static @ 0x50
  private           System.String                   syntax_  // 0x70
PROPERTIES:
  Parser  get=0x08574C24
  Descriptor  get=0x08574B10
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08575374
  Name  get=0x08574B7C  set=0x085753B4
  HasName  get=0x02702DB0
  Package  get=0x08574BD0  set=0x0857541C
  HasPackage  get=0x08571E40
  Dependency  get=0x03D4EAC0
  PublicDependency  get=0x01003830
  WeakDependency  get=0x03D4E2A0
  MessageType  get=0x03D4E2B0
  EnumType  get=0x03D4EA70
  Service  get=0x03D4EAF0
  Extension  get=0x03D4EAA0
  Options  get=0x03D4EB00  set=0x039274B0
  SourceCodeInfo  get=0x03D4EAB0  set=0x038C5570
  Syntax  get=0x08574C74  set=0x08575484
  HasSyntax  get=0x08574B70
METHODS:
  RVA=0x085748E8  token=0x60006B4  System.Void .ctor()
  RVA=0x085746B8  token=0x60006B5  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorProto other)
  RVA=0x08573B3C  token=0x60006B6  Google.Protobuf.Reflection.FileDescriptorProto Clone()
  RVA=0x0364B0F0  token=0x60006BA  System.Void ClearName()
  RVA=0x08571380  token=0x60006BE  System.Void ClearPackage()
  RVA=0x08573B28  token=0x60006CD  System.Void ClearSyntax()
  RVA=0x08573B9C  token=0x60006CE  System.Boolean Equals(System.Object other)
  RVA=0x08573C00  token=0x60006CF  System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorProto other)
  RVA=0x08573E54  token=0x60006D0  System.Int32 GetHashCode()
  RVA=0x08574288  token=0x60006D1  System.String ToString()
  RVA=0x03D47770  token=0x60006D2  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x085750AC  token=0x60006D3  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08573848  token=0x60006D4  System.Int32 CalculateSize()
  RVA=0x08573FF8  token=0x60006D5  System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other)
  RVA=0x03D47500  token=0x60006D6  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08574CC8  token=0x60006D7  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085742D4  token=0x60006D8  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorProto
TYPE:  sealed class
TOKEN: 0x20000AD
SIZE:  0x68
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    FieldFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_field_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>field_  // 0x20
  public    static  System.Int32                    ExtensionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto>_repeated_extension_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto>extension_  // 0x28
  public    static  System.Int32                    NestedTypeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto>_repeated_nestedType_codec  // static @ 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto>nestedType_  // 0x30
  public    static  System.Int32                    EnumTypeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto>_repeated_enumType_codec  // static @ 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto>enumType_  // 0x38
  public    static  System.Int32                    ExtensionRangeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>_repeated_extensionRange_codec  // static @ 0x30
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>extensionRange_  // 0x40
  public    static  System.Int32                    OneofDeclFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto>_repeated_oneofDecl_codec  // static @ 0x38
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto>oneofDecl_  // 0x48
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.MessageOptionsoptions_  // 0x50
  public    static  System.Int32                    ReservedRangeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>_repeated_reservedRange_codec  // static @ 0x40
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>reservedRange_  // 0x58
  public    static  System.Int32                    ReservedNameFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_reservedName_codec  // static @ 0x48
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>reservedName_  // 0x60
PROPERTIES:
  Parser  get=0x0856985C
  Descriptor  get=0x085697A8
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08569E90
  Name  get=0x08569808  set=0x08569ED0
  HasName  get=0x02702DB0
  Field  get=0x03D4EB40
  Extension  get=0x03D4EAC0
  NestedType  get=0x01003830
  EnumType  get=0x03D4E2A0
  ExtensionRange  get=0x03D4E2B0
  OneofDecl  get=0x03D4EA70
  Options  get=0x03D4EAF0  set=0x02C926C0
  ReservedRange  get=0x03D4EAA0
  ReservedName  get=0x03D4EB00
METHODS:
  RVA=0x08569534  token=0x60006DF  System.Void .ctor()
  RVA=0x08569328  token=0x60006E0  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto other)
  RVA=0x085688A0  token=0x60006E1  Google.Protobuf.Reflection.DescriptorProto Clone()
  RVA=0x0364B0F0  token=0x60006E5  System.Void ClearName()
  RVA=0x08568B0C  token=0x60006F0  System.Boolean Equals(System.Object other)
  RVA=0x08568900  token=0x60006F1  System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto other)
  RVA=0x08568B70  token=0x60006F2  System.Int32 GetHashCode()
  RVA=0x08568ED0  token=0x60006F3  System.String ToString()
  RVA=0x03D47770  token=0x60006F4  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08569C0C  token=0x60006F5  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08568600  token=0x60006F6  System.Int32 CalculateSize()
  RVA=0x08568CBC  token=0x60006F7  System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other)
  RVA=0x03D47500  token=0x60006F8  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085698AC  token=0x60006F9  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08568F1C  token=0x60006FA  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionRangeOptions
TYPE:  sealed class
TOKEN: 0x20000B4
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions>_extensions  // 0x18
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x20
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x0857061C
  Descriptor  get=0x085705BC
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08570834
  UninterpretedOption  get=0x03D4EB40
METHODS:
  RVA=0x08570544  token=0x600073C  System.Void .ctor()
  RVA=0x08570494  token=0x600073D  System.Void .ctor(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  RVA=0x08570084  token=0x600073E  Google.Protobuf.Reflection.ExtensionRangeOptions Clone()
  RVA=0x08570174  token=0x6000740  System.Boolean Equals(System.Object other)
  RVA=0x085700E4  token=0x6000741  System.Boolean Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  RVA=0x085701D8  token=0x6000742  System.Int32 GetHashCode()
  RVA=0x085702D8  token=0x6000743  System.String ToString()
  RVA=0x03D47770  token=0x6000744  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0857076C  token=0x6000745  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0856FFC8  token=0x6000746  System.Int32 CalculateSize()
  RVA=0x08570240  token=0x6000747  System.Void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other)
  RVA=0x03D47500  token=0x6000748  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0857066C  token=0x6000749  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x600074A  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600074B  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600074C  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600074D  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x600074E  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600074F  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000750  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension)
  RVA=0x08570324  token=0x6000751  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000B6
SIZE:  0x70
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    NumberFieldNumber  // const
  private   static readonly System.Int32                    NumberDefaultValue  // static @ 0x10
  private           System.Int32                    number_  // 0x28
  public    static  System.Int32                    LabelFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.LabelLabelDefaultValue  // static @ 0x14
  private           Google.Protobuf.Reflection.FieldDescriptorProto.Types.Labellabel_  // 0x2c
  public    static  System.Int32                    TypeFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.TypeTypeDefaultValue  // static @ 0x18
  private           Google.Protobuf.Reflection.FieldDescriptorProto.Types.Typetype_  // 0x30
  public    static  System.Int32                    TypeNameFieldNumber  // const
  private   static readonly System.String                   TypeNameDefaultValue  // static @ 0x20
  private           System.String                   typeName_  // 0x38
  public    static  System.Int32                    ExtendeeFieldNumber  // const
  private   static readonly System.String                   ExtendeeDefaultValue  // static @ 0x28
  private           System.String                   extendee_  // 0x40
  public    static  System.Int32                    DefaultValueFieldNumber  // const
  private   static readonly System.String                   DefaultValueDefaultValue  // static @ 0x30
  private           System.String                   defaultValue_  // 0x48
  public    static  System.Int32                    OneofIndexFieldNumber  // const
  private   static readonly System.Int32                    OneofIndexDefaultValue  // static @ 0x38
  private           System.Int32                    oneofIndex_  // 0x50
  public    static  System.Int32                    JsonNameFieldNumber  // const
  private   static readonly System.String                   JsonNameDefaultValue  // static @ 0x40
  private           System.String                   jsonName_  // 0x58
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.FieldOptionsoptions_  // 0x60
  public    static  System.Int32                    Proto3OptionalFieldNumber  // const
  private   static readonly System.Boolean                  Proto3OptionalDefaultValue  // static @ 0x48
  private           System.Boolean                  proto3Optional_  // 0x68
PROPERTIES:
  Parser  get=0x08572008
  Descriptor  get=0x08571D8C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08572598
  Name  get=0x08571F0C  set=0x08572710
  HasName  get=0x08571E40
  Number  get=0x08571F60  set=0x03D6BCC0
  HasNumber  get=0x02461A70
  Label  get=0x08571EB8  set=0x03D6BCB0
  HasLabel  get=0x08570E90
  Type  get=0x08572100  set=0x03D6BCF0
  HasType  get=0x08571E5C
  TypeName  get=0x085720AC  set=0x08572778
  HasTypeName  get=0x060DAC58
  Extendee  get=0x08571DEC  set=0x08572640
  HasExtendee  get=0x02A794C0
  DefaultValue  get=0x08571D38  set=0x085725D8
  HasDefaultValue  get=0x05ED8890
  OneofIndex  get=0x08571FB4  set=0x03D6BCD0
  HasOneofIndex  get=0x08571E4C
  JsonName  get=0x08571E64  set=0x085726A8
  HasJsonName  get=0x05C72CF8
  Options  get=0x03D4EB00  set=0x039274B0
  Proto3Optional  get=0x08572058  set=0x03D6BCE0
  HasProto3Optional  get=0x08571E54
METHODS:
  RVA=0x0350B670  token=0x6000758  System.Void .ctor()
  RVA=0x08571C54  token=0x6000759  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto other)
  RVA=0x08571394  token=0x600075A  Google.Protobuf.Reflection.FieldDescriptorProto Clone()
  RVA=0x08571380  token=0x600075E  System.Void ClearName()
  RVA=0x03D4F650  token=0x6000762  System.Void ClearNumber()
  RVA=0x03D6BC50  token=0x6000766  System.Void ClearLabel()
  RVA=0x03D6BCA0  token=0x600076A  System.Void ClearType()
  RVA=0x05D62B50  token=0x600076E  System.Void ClearTypeName()
  RVA=0x08571358  token=0x6000772  System.Void ClearExtendee()
  RVA=0x05D6CFCC  token=0x6000776  System.Void ClearDefaultValue()
  RVA=0x03D6BC80  token=0x600077A  System.Void ClearOneofIndex()
  RVA=0x0857136C  token=0x600077E  System.Void ClearJsonName()
  RVA=0x03D6BC90  token=0x6000784  System.Void ClearProto3Optional()
  RVA=0x085713F4  token=0x6000785  System.Boolean Equals(System.Object other)
  RVA=0x08571458  token=0x6000786  System.Boolean Equals(Google.Protobuf.Reflection.FieldDescriptorProto other)
  RVA=0x08571624  token=0x6000787  System.Int32 GetHashCode()
  RVA=0x085719A0  token=0x6000788  System.String ToString()
  RVA=0x03D47770  token=0x6000789  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08572394  token=0x600078A  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08571140  token=0x600078B  System.Int32 CalculateSize()
  RVA=0x085717D4  token=0x600078C  System.Void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other)
  RVA=0x03D47500  token=0x600078D  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08572154  token=0x600078E  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085719EC  token=0x600078F  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000BB
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.OneofOptionsoptions_  // 0x20
PROPERTIES:
  Parser  get=0x08576D5C
  Descriptor  get=0x08576CA8
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08576F20
  Name  get=0x08576D08  set=0x08576F60
  HasName  get=0x02702DB0
  Options  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0350B670  token=0x6000796  System.Void .ctor()
  RVA=0x08576C34  token=0x6000797  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto other)
  RVA=0x0857680C  token=0x6000798  Google.Protobuf.Reflection.OneofDescriptorProto Clone()
  RVA=0x0364B0F0  token=0x600079C  System.Void ClearName()
  RVA=0x085768F0  token=0x600079F  System.Boolean Equals(System.Object other)
  RVA=0x0857686C  token=0x60007A0  System.Boolean Equals(Google.Protobuf.Reflection.OneofDescriptorProto other)
  RVA=0x08576954  token=0x60007A1  System.Int32 GetHashCode()
  RVA=0x08576AA4  token=0x60007A2  System.String ToString()
  RVA=0x03D47770  token=0x60007A3  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08576EA0  token=0x60007A4  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08576764  token=0x60007A5  System.Int32 CalculateSize()
  RVA=0x085769C8  token=0x60007A6  System.Void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other)
  RVA=0x03D47500  token=0x60007A7  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08576DAC  token=0x60007A8  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08576AF0  token=0x60007A9  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000BD
SIZE:  0x40
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto>_repeated_value_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto>value_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.EnumOptionsoptions_  // 0x28
  public    static  System.Int32                    ReservedRangeFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>_repeated_reservedRange_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>reservedRange_  // 0x30
  public    static  System.Int32                    ReservedNameFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_reservedName_codec  // static @ 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>reservedName_  // 0x38
PROPERTIES:
  Parser  get=0x0856E490
  Descriptor  get=0x0856E3DC
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0856E83C
  Name  get=0x0856E43C  set=0x0856E87C
  HasName  get=0x02702DB0
  Value  get=0x03D4EB40
  Options  get=0x03D4EAC0  set=0x02C92F10
  ReservedRange  get=0x01003830
  ReservedName  get=0x03D4E2A0
METHODS:
  RVA=0x0856E1B0  token=0x60007B0  System.Void .ctor()
  RVA=0x0856E2BC  token=0x60007B1  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto other)
  RVA=0x0856DB10  token=0x60007B2  Google.Protobuf.Reflection.EnumDescriptorProto Clone()
  RVA=0x0364B0F0  token=0x60007B6  System.Void ClearName()
  RVA=0x0856DB70  token=0x60007BC  System.Boolean Equals(System.Object other)
  RVA=0x0856DBD4  token=0x60007BD  System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto other)
  RVA=0x0856DCF8  token=0x60007BE  System.Int32 GetHashCode()
  RVA=0x0856DF18  token=0x60007BF  System.String ToString()
  RVA=0x03D47770  token=0x60007C0  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0856E6CC  token=0x60007C1  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0856D988  token=0x60007C2  System.Int32 CalculateSize()
  RVA=0x0856DDC4  token=0x60007C3  System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other)
  RVA=0x03D47500  token=0x60007C4  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0856E4E0  token=0x60007C5  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0856DF64  token=0x60007C6  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000C2
SIZE:  0x38
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    NumberFieldNumber  // const
  private   static readonly System.Int32                    NumberDefaultValue  // static @ 0x10
  private           System.Int32                    number_  // 0x28
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.EnumValueOptionsoptions_  // 0x30
PROPERTIES:
  Parser  get=0x0857F554
  Descriptor  get=0x0857F44C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857F76C
  Name  get=0x0857F4AC  set=0x0857F7AC
  HasName  get=0x08571E40
  Number  get=0x0857F500  set=0x03D6BCC0
  HasNumber  get=0x02461A70
  Options  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x0350B670  token=0x60007E9  System.Void .ctor()
  RVA=0x0857F3CC  token=0x60007EA  System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  RVA=0x0857EF48  token=0x60007EB  Google.Protobuf.Reflection.EnumValueDescriptorProto Clone()
  RVA=0x08571380  token=0x60007EF  System.Void ClearName()
  RVA=0x03D4F650  token=0x60007F3  System.Void ClearNumber()
  RVA=0x0857EFA8  token=0x60007F6  System.Boolean Equals(System.Object other)
  RVA=0x0857F00C  token=0x60007F7  System.Boolean Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  RVA=0x0857F0A8  token=0x60007F8  System.Int32 GetHashCode()
  RVA=0x0857F224  token=0x60007F9  System.String ToString()
  RVA=0x03D47770  token=0x60007FA  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0857F6C4  token=0x60007FB  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857EE74  token=0x60007FC  System.Int32 CalculateSize()
  RVA=0x0857F130  token=0x60007FD  System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other)
  RVA=0x03D47500  token=0x60007FE  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0857F5A4  token=0x60007FF  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0857F270  token=0x6000800  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000C4
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    MethodFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto>_repeated_method_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto>method_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.ServiceOptionsoptions_  // 0x28
PROPERTIES:
  Parser  get=0x0858A1F8
  Descriptor  get=0x0858A144
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0858A48C
  Name  get=0x0858A1A4  set=0x0858A4CC
  HasName  get=0x02702DB0
  Method  get=0x03D4EB40
  Options  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x0858A008  token=0x6000807  System.Void .ctor()
  RVA=0x0858A080  token=0x6000808  System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  RVA=0x08589AFC  token=0x6000809  Google.Protobuf.Reflection.ServiceDescriptorProto Clone()
  RVA=0x0364B0F0  token=0x600080D  System.Void ClearName()
  RVA=0x08589C20  token=0x6000811  System.Boolean Equals(System.Object other)
  RVA=0x08589B5C  token=0x6000812  System.Boolean Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  RVA=0x08589C84  token=0x6000813  System.Int32 GetHashCode()
  RVA=0x08589E10  token=0x6000814  System.String ToString()
  RVA=0x03D47770  token=0x6000815  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0858A39C  token=0x6000816  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085899FC  token=0x6000817  System.Int32 CalculateSize()
  RVA=0x08589D0C  token=0x6000818  System.Void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other)
  RVA=0x03D47500  token=0x6000819  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0858A248  token=0x600081A  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08589E5C  token=0x600081B  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodDescriptorProto
TYPE:  sealed class
TOKEN: 0x20000C6
SIZE:  0x48
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly System.String                   NameDefaultValue  // static @ 0x8
  private           System.String                   name_  // 0x20
  public    static  System.Int32                    InputTypeFieldNumber  // const
  private   static readonly System.String                   InputTypeDefaultValue  // static @ 0x10
  private           System.String                   inputType_  // 0x28
  public    static  System.Int32                    OutputTypeFieldNumber  // const
  private   static readonly System.String                   OutputTypeDefaultValue  // static @ 0x18
  private           System.String                   outputType_  // 0x30
  public    static  System.Int32                    OptionsFieldNumber  // const
  private           Google.Protobuf.Reflection.MethodOptionsoptions_  // 0x38
  public    static  System.Int32                    ClientStreamingFieldNumber  // const
  private   static readonly System.Boolean                  ClientStreamingDefaultValue  // static @ 0x20
  private           System.Boolean                  clientStreaming_  // 0x40
  public    static  System.Int32                    ServerStreamingFieldNumber  // const
  private   static readonly System.Boolean                  ServerStreamingDefaultValue  // static @ 0x21
  private           System.Boolean                  serverStreaming_  // 0x41
PROPERTIES:
  Parser  get=0x085879A8
  Descriptor  get=0x0858784C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08587CF8
  Name  get=0x08587900  set=0x08587DA0
  HasName  get=0x08571E40
  InputType  get=0x085878AC  set=0x08587D38
  HasInputType  get=0x05693D38
  OutputType  get=0x08587954  set=0x08587E08
  HasOutputType  get=0x085839D0
  Options  get=0x03D4E2A0  set=0x0388FF30
  ClientStreaming  get=0x085877F8  set=0x03D6BF10
  HasClientStreaming  get=0x02461A70
  ServerStreaming  get=0x085879F8  set=0x03D6BF20
  HasServerStreaming  get=0x08570E90
METHODS:
  RVA=0x0350B670  token=0x6000822  System.Void .ctor()
  RVA=0x0858774C  token=0x6000823  System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto other)
  RVA=0x085870D4  token=0x6000824  Google.Protobuf.Reflection.MethodDescriptorProto Clone()
  RVA=0x08571380  token=0x6000828  System.Void ClearName()
  RVA=0x08254178  token=0x600082C  System.Void ClearInputType()
  RVA=0x05572920  token=0x6000830  System.Void ClearOutputType()
  RVA=0x03D4F650  token=0x6000836  System.Void ClearClientStreaming()
  RVA=0x03D6BC50  token=0x600083A  System.Void ClearServerStreaming()
  RVA=0x0858724C  token=0x600083B  System.Boolean Equals(System.Object other)
  RVA=0x08587134  token=0x600083C  System.Boolean Equals(Google.Protobuf.Reflection.MethodDescriptorProto other)
  RVA=0x085872B0  token=0x600083D  System.Int32 GetHashCode()
  RVA=0x08587538  token=0x600083E  System.String ToString()
  RVA=0x03D47770  token=0x600083F  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08587BCC  token=0x6000840  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08586FBC  token=0x6000841  System.Int32 CalculateSize()
  RVA=0x085873F0  token=0x6000842  System.Void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other)
  RVA=0x03D47500  token=0x6000843  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08587A4C  token=0x6000844  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08587584  token=0x6000845  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FileOptions
TYPE:  sealed class
TOKEN: 0x20000C8
SIZE:  0x90
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    JavaPackageFieldNumber  // const
  private   static readonly System.String                   JavaPackageDefaultValue  // static @ 0x8
  private           System.String                   javaPackage_  // 0x28
  public    static  System.Int32                    JavaOuterClassnameFieldNumber  // const
  private   static readonly System.String                   JavaOuterClassnameDefaultValue  // static @ 0x10
  private           System.String                   javaOuterClassname_  // 0x30
  public    static  System.Int32                    JavaMultipleFilesFieldNumber  // const
  private   static readonly System.Boolean                  JavaMultipleFilesDefaultValue  // static @ 0x18
  private           System.Boolean                  javaMultipleFiles_  // 0x38
  public    static  System.Int32                    JavaGenerateEqualsAndHashFieldNumber  // const
  private   static readonly System.Boolean                  JavaGenerateEqualsAndHashDefaultValue  // static @ 0x19
  private           System.Boolean                  javaGenerateEqualsAndHash_  // 0x39
  public    static  System.Int32                    JavaStringCheckUtf8FieldNumber  // const
  private   static readonly System.Boolean                  JavaStringCheckUtf8DefaultValue  // static @ 0x1a
  private           System.Boolean                  javaStringCheckUtf8_  // 0x3a
  public    static  System.Int32                    OptimizeForFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeOptimizeForDefaultValue  // static @ 0x1c
  private           Google.Protobuf.Reflection.FileOptions.Types.OptimizeModeoptimizeFor_  // 0x3c
  public    static  System.Int32                    GoPackageFieldNumber  // const
  private   static readonly System.String                   GoPackageDefaultValue  // static @ 0x20
  private           System.String                   goPackage_  // 0x40
  public    static  System.Int32                    CcGenericServicesFieldNumber  // const
  private   static readonly System.Boolean                  CcGenericServicesDefaultValue  // static @ 0x28
  private           System.Boolean                  ccGenericServices_  // 0x48
  public    static  System.Int32                    JavaGenericServicesFieldNumber  // const
  private   static readonly System.Boolean                  JavaGenericServicesDefaultValue  // static @ 0x29
  private           System.Boolean                  javaGenericServices_  // 0x49
  public    static  System.Int32                    PyGenericServicesFieldNumber  // const
  private   static readonly System.Boolean                  PyGenericServicesDefaultValue  // static @ 0x2a
  private           System.Boolean                  pyGenericServices_  // 0x4a
  public    static  System.Int32                    PhpGenericServicesFieldNumber  // const
  private   static readonly System.Boolean                  PhpGenericServicesDefaultValue  // static @ 0x2b
  private           System.Boolean                  phpGenericServices_  // 0x4b
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x2c
  private           System.Boolean                  deprecated_  // 0x4c
  public    static  System.Int32                    CcEnableArenasFieldNumber  // const
  private   static readonly System.Boolean                  CcEnableArenasDefaultValue  // static @ 0x2d
  private           System.Boolean                  ccEnableArenas_  // 0x4d
  public    static  System.Int32                    ObjcClassPrefixFieldNumber  // const
  private   static readonly System.String                   ObjcClassPrefixDefaultValue  // static @ 0x30
  private           System.String                   objcClassPrefix_  // 0x50
  public    static  System.Int32                    CsharpNamespaceFieldNumber  // const
  private   static readonly System.String                   CsharpNamespaceDefaultValue  // static @ 0x38
  private           System.String                   csharpNamespace_  // 0x58
  public    static  System.Int32                    SwiftPrefixFieldNumber  // const
  private   static readonly System.String                   SwiftPrefixDefaultValue  // static @ 0x40
  private           System.String                   swiftPrefix_  // 0x60
  public    static  System.Int32                    PhpClassPrefixFieldNumber  // const
  private   static readonly System.String                   PhpClassPrefixDefaultValue  // static @ 0x48
  private           System.String                   phpClassPrefix_  // 0x68
  public    static  System.Int32                    PhpNamespaceFieldNumber  // const
  private   static readonly System.String                   PhpNamespaceDefaultValue  // static @ 0x50
  private           System.String                   phpNamespace_  // 0x70
  public    static  System.Int32                    PhpMetadataNamespaceFieldNumber  // const
  private   static readonly System.String                   PhpMetadataNamespaceDefaultValue  // static @ 0x58
  private           System.String                   phpMetadataNamespace_  // 0x78
  public    static  System.Int32                    RubyPackageFieldNumber  // const
  private   static readonly System.String                   RubyPackageDefaultValue  // static @ 0x60
  private           System.String                   rubyPackage_  // 0x80
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x68
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x88
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x08583CAC
  Descriptor  get=0x08583910
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08584794
  JavaPackage  get=0x08583B5C  set=0x0858490C
  HasJavaPackage  get=0x05693D38
  JavaOuterClassname  get=0x08583B08  set=0x085848A4
  HasJavaOuterClassname  get=0x085839D0
  JavaMultipleFiles  get=0x08583AB4  set=0x03D6BEA0
  HasJavaMultipleFiles  get=0x0857E548
  JavaGenerateEqualsAndHash  get=0x08583A0C  set=0x03D6BE80
  HasJavaGenerateEqualsAndHash  get=0x08581D24
  JavaStringCheckUtf8  get=0x08583BB0  set=0x03D6BEB0
  HasJavaStringCheckUtf8  get=0x085839DC
  OptimizeFor  get=0x08583C58  set=0x03D6BEC0
  HasOptimizeFor  get=0x0857E540
  GoPackage  get=0x08583970  set=0x0858483C
  HasGoPackage  get=0x02A794C0
  CcGenericServices  get=0x08583814  set=0x03D6BE60
  HasCcGenericServices  get=0x08581D04
  JavaGenericServices  get=0x08583A60  set=0x03D6BE90
  HasJavaGenericServices  get=0x08581D14
  PyGenericServices  get=0x08583E50  set=0x03D6BEE0
  HasPyGenericServices  get=0x08581D0C
  PhpGenericServices  get=0x08583D50  set=0x03D6BED0
  HasPhpGenericServices  get=0x03874860
  Deprecated  get=0x085838BC  set=0x03D6BE70
  HasDeprecated  get=0x08581D1C
  CcEnableArenas  get=0x085837BC  set=0x03D6BE50
  HasCcEnableArenas  get=0x085839C4
  ObjcClassPrefix  get=0x08583C04  set=0x08584974
  HasObjcClassPrefix  get=0x02B84230
  CsharpNamespace  get=0x08583868  set=0x085847D4
  HasCsharpNamespace  get=0x05C72CF8
  SwiftPrefix  get=0x08583EFC  set=0x08584B80
  HasSwiftPrefix  get=0x05B08B40
  PhpClassPrefix  get=0x08583CFC  set=0x085849DC
  HasPhpClassPrefix  get=0x085839E8
  PhpNamespace  get=0x08583DFC  set=0x08584AAC
  HasPhpNamespace  get=0x08574B70
  PhpMetadataNamespace  get=0x08583DA8  set=0x08584A44
  HasPhpMetadataNamespace  get=0x085839F4
  RubyPackage  get=0x08583EA4  set=0x08584B14
  HasRubyPackage  get=0x08583A00
  UninterpretedOption  get=0x03D4EA60
METHODS:
  RVA=0x0858358C  token=0x600084D  System.Void .ctor()
  RVA=0x08583608  token=0x600084E  System.Void .ctor(Google.Protobuf.Reflection.FileOptions other)
  RVA=0x085826A0  token=0x600084F  Google.Protobuf.Reflection.FileOptions Clone()
  RVA=0x08254178  token=0x6000853  System.Void ClearJavaPackage()
  RVA=0x05572920  token=0x6000857  System.Void ClearJavaOuterClassname()
  RVA=0x03D6BD30  token=0x600085B  System.Void ClearJavaMultipleFiles()
  RVA=0x03D6BDA0  token=0x600085F  System.Void ClearJavaGenerateEqualsAndHash()
  RVA=0x03D6BE30  token=0x6000863  System.Void ClearJavaStringCheckUtf8()
  RVA=0x03D6BD20  token=0x6000867  System.Void ClearOptimizeFor()
  RVA=0x08571358  token=0x600086B  System.Void ClearGoPackage()
  RVA=0x03D6BD60  token=0x600086F  System.Void ClearCcGenericServices()
  RVA=0x03D6BD80  token=0x6000873  System.Void ClearJavaGenericServices()
  RVA=0x03D6BD70  token=0x6000877  System.Void ClearPyGenericServices()
  RVA=0x03D6BE40  token=0x600087B  System.Void ClearPhpGenericServices()
  RVA=0x03D6BD90  token=0x600087F  System.Void ClearDeprecated()
  RVA=0x03D6BE20  token=0x6000883  System.Void ClearCcEnableArenas()
  RVA=0x05D62B3C  token=0x6000887  System.Void ClearObjcClassPrefix()
  RVA=0x0857136C  token=0x600088B  System.Void ClearCsharpNamespace()
  RVA=0x05755F70  token=0x600088F  System.Void ClearSwiftPrefix()
  RVA=0x08582664  token=0x6000893  System.Void ClearPhpClassPrefix()
  RVA=0x08573B28  token=0x6000897  System.Void ClearPhpNamespace()
  RVA=0x08582678  token=0x600089B  System.Void ClearPhpMetadataNamespace()
  RVA=0x0858268C  token=0x600089F  System.Void ClearRubyPackage()
  RVA=0x08582700  token=0x60008A1  System.Boolean Equals(System.Object other)
  RVA=0x08582764  token=0x60008A2  System.Boolean Equals(Google.Protobuf.Reflection.FileOptions other)
  RVA=0x08582AF4  token=0x60008A3  System.Int32 GetHashCode()
  RVA=0x0858312C  token=0x60008A4  System.String ToString()
  RVA=0x03D47770  token=0x60008A5  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08584334  token=0x60008A6  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0858232C  token=0x60008A7  System.Int32 CalculateSize()
  RVA=0x08582E5C  token=0x60008A8  System.Void MergeFrom(Google.Protobuf.Reflection.FileOptions other)
  RVA=0x03D47500  token=0x60008A9  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08583F50  token=0x60008AA  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x60008AB  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008AC  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008AD  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008AE  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x60008AF  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008B0  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008B1  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension)
  RVA=0x08583178  token=0x60008B2  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MessageOptions
TYPE:  sealed class
TOKEN: 0x20000CC
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    MessageSetWireFormatFieldNumber  // const
  private   static readonly System.Boolean                  MessageSetWireFormatDefaultValue  // static @ 0x8
  private           System.Boolean                  messageSetWireFormat_  // 0x24
  public    static  System.Int32                    NoStandardDescriptorAccessorFieldNumber  // const
  private   static readonly System.Boolean                  NoStandardDescriptorAccessorDefaultValue  // static @ 0x9
  private           System.Boolean                  noStandardDescriptorAccessor_  // 0x25
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0xa
  private           System.Boolean                  deprecated_  // 0x26
  public    static  System.Int32                    MapEntryFieldNumber  // const
  private   static readonly System.Boolean                  MapEntryDefaultValue  // static @ 0xb
  private           System.Boolean                  mapEntry_  // 0x27
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x08586C54
  Descriptor  get=0x08586AF8
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08586F7C
  MessageSetWireFormat  get=0x08586BAC  set=0x03D6BD40
  HasMessageSetWireFormat  get=0x0857E540
  NoStandardDescriptorAccessor  get=0x08586C00  set=0x03D6BD50
  HasNoStandardDescriptorAccessor  get=0x0857E548
  Deprecated  get=0x08586AA4  set=0x03D6BEF0
  HasDeprecated  get=0x08581D04
  MapEntry  get=0x08586B58  set=0x03D6BF00
  HasMapEntry  get=0x08581D14
  UninterpretedOption  get=0x03D4EAC0
METHODS:
  RVA=0x08586A2C  token=0x60008BA  System.Void .ctor()
  RVA=0x08586960  token=0x60008BB  System.Void .ctor(Google.Protobuf.Reflection.MessageOptions other)
  RVA=0x085863A0  token=0x60008BC  Google.Protobuf.Reflection.MessageOptions Clone()
  RVA=0x03D6BD20  token=0x60008C0  System.Void ClearMessageSetWireFormat()
  RVA=0x03D6BD30  token=0x60008C4  System.Void ClearNoStandardDescriptorAccessor()
  RVA=0x03D6BD60  token=0x60008C8  System.Void ClearDeprecated()
  RVA=0x03D6BD80  token=0x60008CC  System.Void ClearMapEntry()
  RVA=0x08586400  token=0x60008CE  System.Boolean Equals(System.Object other)
  RVA=0x08586464  token=0x60008CF  System.Boolean Equals(Google.Protobuf.Reflection.MessageOptions other)
  RVA=0x08586578  token=0x60008D0  System.Int32 GetHashCode()
  RVA=0x08586784  token=0x60008D1  System.String ToString()
  RVA=0x03D47770  token=0x60008D2  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08586E0C  token=0x60008D3  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085862B8  token=0x60008D4  System.Int32 CalculateSize()
  RVA=0x0858668C  token=0x60008D5  System.Void MergeFrom(Google.Protobuf.Reflection.MessageOptions other)
  RVA=0x03D47500  token=0x60008D6  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08586CA4  token=0x60008D7  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x60008D8  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008D9  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008DA  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008DB  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x60008DC  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008DD  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60008DE  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension)
  RVA=0x085867D0  token=0x60008DF  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldOptions
TYPE:  sealed class
TOKEN: 0x20000CE
SIZE:  0x40
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    CtypeFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.FieldOptions.Types.CTypeCtypeDefaultValue  // static @ 0x8
  private           Google.Protobuf.Reflection.FieldOptions.Types.CTypectype_  // 0x24
  public    static  System.Int32                    PackedFieldNumber  // const
  private   static readonly System.Boolean                  PackedDefaultValue  // static @ 0xc
  private           System.Boolean                  packed_  // 0x28
  public    static  System.Int32                    JstypeFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.FieldOptions.Types.JSTypeJstypeDefaultValue  // static @ 0x10
  private           Google.Protobuf.Reflection.FieldOptions.Types.JSTypejstype_  // 0x2c
  public    static  System.Int32                    LazyFieldNumber  // const
  private   static readonly System.Boolean                  LazyDefaultValue  // static @ 0x14
  private           System.Boolean                  lazy_  // 0x30
  public    static  System.Int32                    UnverifiedLazyFieldNumber  // const
  private   static readonly System.Boolean                  UnverifiedLazyDefaultValue  // static @ 0x15
  private           System.Boolean                  unverifiedLazy_  // 0x31
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x16
  private           System.Boolean                  deprecated_  // 0x32
  public    static  System.Int32                    WeakFieldNumber  // const
  private   static readonly System.Boolean                  WeakDefaultValue  // static @ 0x17
  private           System.Boolean                  weak_  // 0x33
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x38
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x08581E28
  Descriptor  get=0x08581CA4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085822EC
  Ctype  get=0x08581BFC  set=0x03D6BDB0
  HasCtype  get=0x0857E540
  Packed  get=0x08581DD4  set=0x03D6BDF0
  HasPacked  get=0x0857E548
  Jstype  get=0x08581D2C  set=0x03D6BDD0
  HasJstype  get=0x08581D0C
  Lazy  get=0x08581D80  set=0x03D6BDE0
  HasLazy  get=0x08581D14
  UnverifiedLazy  get=0x08581E78  set=0x03D6BE00
  HasUnverifiedLazy  get=0x08581D1C
  Deprecated  get=0x08581C50  set=0x03D6BDC0
  HasDeprecated  get=0x08581D04
  Weak  get=0x08581ECC  set=0x03D6BE10
  HasWeak  get=0x08581D24
  UninterpretedOption  get=0x03D4E2A0
METHODS:
  RVA=0x08581B84  token=0x60008E7  System.Void .ctor()
  RVA=0x08581AA0  token=0x60008E8  System.Void .ctor(Google.Protobuf.Reflection.FieldOptions other)
  RVA=0x085813C8  token=0x60008E9  Google.Protobuf.Reflection.FieldOptions Clone()
  RVA=0x03D6BD20  token=0x60008ED  System.Void ClearCtype()
  RVA=0x03D6BD30  token=0x60008F1  System.Void ClearPacked()
  RVA=0x03D6BD70  token=0x60008F5  System.Void ClearJstype()
  RVA=0x03D6BD80  token=0x60008F9  System.Void ClearLazy()
  RVA=0x03D6BD90  token=0x60008FD  System.Void ClearUnverifiedLazy()
  RVA=0x03D6BD60  token=0x6000901  System.Void ClearDeprecated()
  RVA=0x03D6BDA0  token=0x6000905  System.Void ClearWeak()
  RVA=0x08581428  token=0x6000907  System.Boolean Equals(System.Object other)
  RVA=0x0858148C  token=0x6000908  System.Boolean Equals(Google.Protobuf.Reflection.FieldOptions other)
  RVA=0x085815F8  token=0x6000909  System.Int32 GetHashCode()
  RVA=0x08581890  token=0x600090A  System.String ToString()
  RVA=0x03D47770  token=0x600090B  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x085820FC  token=0x600090C  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08581260  token=0x600090D  System.Int32 CalculateSize()
  RVA=0x08581750  token=0x600090E  System.Void MergeFrom(Google.Protobuf.Reflection.FieldOptions other)
  RVA=0x03D47500  token=0x600090F  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08581F20  token=0x6000910  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x6000911  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000912  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000913  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000914  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x6000915  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000916  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000917  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension)
  RVA=0x085818DC  token=0x6000918  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofOptions
TYPE:  sealed class
TOKEN: 0x20000D3
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions>_extensions  // 0x18
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x20
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x085897A4
  Descriptor  get=0x08589744
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085899BC
  UninterpretedOption  get=0x03D4EB40
METHODS:
  RVA=0x085896CC  token=0x6000920  System.Void .ctor()
  RVA=0x0858961C  token=0x6000921  System.Void .ctor(Google.Protobuf.Reflection.OneofOptions other)
  RVA=0x08589274  token=0x6000922  Google.Protobuf.Reflection.OneofOptions Clone()
  RVA=0x08589364  token=0x6000924  System.Boolean Equals(System.Object other)
  RVA=0x085892D4  token=0x6000925  System.Boolean Equals(Google.Protobuf.Reflection.OneofOptions other)
  RVA=0x085701D8  token=0x6000926  System.Int32 GetHashCode()
  RVA=0x08589460  token=0x6000927  System.String ToString()
  RVA=0x03D47770  token=0x6000928  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x085898F4  token=0x6000929  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085891B8  token=0x600092A  System.Int32 CalculateSize()
  RVA=0x085893C8  token=0x600092B  System.Void MergeFrom(Google.Protobuf.Reflection.OneofOptions other)
  RVA=0x03D47500  token=0x600092C  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085897F4  token=0x600092D  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x600092E  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600092F  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000930  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000931  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x6000932  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000933  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000934  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension)
  RVA=0x085894AC  token=0x6000935  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumOptions
TYPE:  sealed class
TOKEN: 0x20000D5
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    AllowAliasFieldNumber  // const
  private   static readonly System.Boolean                  AllowAliasDefaultValue  // static @ 0x8
  private           System.Boolean                  allowAlias_  // 0x24
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x9
  private           System.Boolean                  deprecated_  // 0x25
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x0857E550
  Descriptor  get=0x0857E4E0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857E7F0
  AllowAlias  get=0x0857E438  set=0x03D6BD40
  HasAllowAlias  get=0x0857E540
  Deprecated  get=0x0857E48C  set=0x03D6BD50
  HasDeprecated  get=0x0857E548
  UninterpretedOption  get=0x03D4EAC0
METHODS:
  RVA=0x0857E3C0  token=0x600093D  System.Void .ctor()
  RVA=0x0857E300  token=0x600093E  System.Void .ctor(Google.Protobuf.Reflection.EnumOptions other)
  RVA=0x0857DDF4  token=0x600093F  Google.Protobuf.Reflection.EnumOptions Clone()
  RVA=0x03D6BD20  token=0x6000943  System.Void ClearAllowAlias()
  RVA=0x03D6BD30  token=0x6000947  System.Void ClearDeprecated()
  RVA=0x0857DE54  token=0x6000949  System.Boolean Equals(System.Object other)
  RVA=0x0857DEB8  token=0x600094A  System.Boolean Equals(Google.Protobuf.Reflection.EnumOptions other)
  RVA=0x0857DF8C  token=0x600094B  System.Int32 GetHashCode()
  RVA=0x0857E124  token=0x600094C  System.String ToString()
  RVA=0x03D47770  token=0x600094D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0857E6D4  token=0x600094E  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857DD1C  token=0x600094F  System.Int32 CalculateSize()
  RVA=0x0857E05C  token=0x6000950  System.Void MergeFrom(Google.Protobuf.Reflection.EnumOptions other)
  RVA=0x03D47500  token=0x6000951  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0857E5A0  token=0x6000952  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x6000953  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000954  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000955  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000956  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x6000957  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000958  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000959  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension)
  RVA=0x0857E170  token=0x600095A  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueOptions
TYPE:  sealed class
TOKEN: 0x20000D7
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x08580180
  Descriptor  get=0x08580120
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085803DC
  Deprecated  get=0x085800CC  set=0x03D6BD40
  HasDeprecated  get=0x0857E540
  UninterpretedOption  get=0x03D4EAC0
METHODS:
  RVA=0x08580054  token=0x6000962  System.Void .ctor()
  RVA=0x0857FF98  token=0x6000963  System.Void .ctor(Google.Protobuf.Reflection.EnumValueOptions other)
  RVA=0x0857FAF4  token=0x6000964  Google.Protobuf.Reflection.EnumValueOptions Clone()
  RVA=0x03D6BD20  token=0x6000968  System.Void ClearDeprecated()
  RVA=0x0857FB54  token=0x600096A  System.Boolean Equals(System.Object other)
  RVA=0x0857FBB8  token=0x600096B  System.Boolean Equals(Google.Protobuf.Reflection.EnumValueOptions other)
  RVA=0x0857FC6C  token=0x600096C  System.Int32 GetHashCode()
  RVA=0x0857FDC8  token=0x600096D  System.String ToString()
  RVA=0x03D47770  token=0x600096E  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x085802E8  token=0x600096F  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857FA28  token=0x6000970  System.Int32 CalculateSize()
  RVA=0x0857FD18  token=0x6000971  System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other)
  RVA=0x03D47500  token=0x6000972  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085801D0  token=0x6000973  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x6000974  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000975  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000976  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000977  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x6000978  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000979  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600097A  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension)
  RVA=0x0857FE14  token=0x600097B  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceOptions
TYPE:  sealed class
TOKEN: 0x20000D9
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x28
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x0858AC9C
  Descriptor  get=0x0858AC3C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0858AF00
  Deprecated  get=0x0858ABE8  set=0x03D6BD40
  HasDeprecated  get=0x0857E540
  UninterpretedOption  get=0x03D4EAC0
METHODS:
  RVA=0x0858AAB4  token=0x6000983  System.Void .ctor()
  RVA=0x0858AB2C  token=0x6000984  System.Void .ctor(Google.Protobuf.Reflection.ServiceOptions other)
  RVA=0x0858A610  token=0x6000985  Google.Protobuf.Reflection.ServiceOptions Clone()
  RVA=0x03D6BD20  token=0x6000989  System.Void ClearDeprecated()
  RVA=0x0858A724  token=0x600098B  System.Boolean Equals(System.Object other)
  RVA=0x0858A670  token=0x600098C  System.Boolean Equals(Google.Protobuf.Reflection.ServiceOptions other)
  RVA=0x0858A788  token=0x600098D  System.Int32 GetHashCode()
  RVA=0x0858A8E4  token=0x600098E  System.String ToString()
  RVA=0x03D47770  token=0x600098F  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0858AE08  token=0x6000990  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0858A534  token=0x6000991  System.Int32 CalculateSize()
  RVA=0x0858A834  token=0x6000992  System.Void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other)
  RVA=0x03D47500  token=0x6000993  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0858ACEC  token=0x6000994  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x6000995  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000996  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000997  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=-1  // generic def  token=0x6000998  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x6000999  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600099A  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=-1  // generic def  token=0x600099B  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension)
  RVA=0x0858A930  token=0x600099C  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodOptions
TYPE:  sealed class
TOKEN: 0x20000DB
SIZE:  0x38
IMPLEMENTS: Google.Protobuf.IExtendableMessage`1 Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions>_extensions  // 0x18
  private           System.Int32                    _hasBits0  // 0x20
  public    static  System.Int32                    DeprecatedFieldNumber  // const
  private   static readonly System.Boolean                  DeprecatedDefaultValue  // static @ 0x8
  private           System.Boolean                  deprecated_  // 0x24
  public    static  System.Int32                    IdempotencyLevelFieldNumber  // const
  private   static readonly Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelIdempotencyLevelDefaultValue  // static @ 0xc
  private           Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevelidempotencyLevel_  // 0x28
  public    static  System.Int32                    UninterpretedOptionFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption>_repeated_uninterpretedOption_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption>uninterpretedOption_  // 0x30
PROPERTIES:
  _Extensions  get=0x01041090
  Parser  get=0x085886C0
  Descriptor  get=0x0858860C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08588970
  Deprecated  get=0x085885B8  set=0x03D6BD40
  HasDeprecated  get=0x0857E540
  IdempotencyLevel  get=0x0858866C  set=0x03D6BF30
  HasIdempotencyLevel  get=0x0857E548
  UninterpretedOption  get=0x01003830
METHODS:
  RVA=0x08588540  token=0x60009A4  System.Void .ctor()
  RVA=0x08588480  token=0x60009A5  System.Void .ctor(Google.Protobuf.Reflection.MethodOptions other)
  RVA=0x08587F84  token=0x60009A6  Google.Protobuf.Reflection.MethodOptions Clone()
  RVA=0x03D6BD20  token=0x60009AA  System.Void ClearDeprecated()
  RVA=0x03D6BD30  token=0x60009AE  System.Void ClearIdempotencyLevel()
  RVA=0x08587FE4  token=0x60009B0  System.Boolean Equals(System.Object other)
  RVA=0x08588048  token=0x60009B1  System.Boolean Equals(Google.Protobuf.Reflection.MethodOptions other)
  RVA=0x0858811C  token=0x60009B2  System.Int32 GetHashCode()
  RVA=0x085882A0  token=0x60009B3  System.String ToString()
  RVA=0x03D47770  token=0x60009B4  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0858884C  token=0x60009B5  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08587E70  token=0x60009B6  System.Int32 CalculateSize()
  RVA=0x085881D8  token=0x60009B7  System.Void MergeFrom(Google.Protobuf.Reflection.MethodOptions other)
  RVA=0x03D47500  token=0x60009B8  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08588710  token=0x60009B9  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=-1  // generic def  token=0x60009BA  TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60009BB  Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60009BC  Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60009BD  System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension, TValue value)
  RVA=-1  // generic def  token=0x60009BE  System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60009BF  System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=-1  // generic def  token=0x60009C0  System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension)
  RVA=0x085882EC  token=0x60009C1  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.UninterpretedOption
TYPE:  sealed class
TOKEN: 0x20000DF
SIZE:  0x58
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  private           System.Int32                    _hasBits0  // 0x18
  public    static  System.Int32                    NameFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>_repeated_name_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>name_  // 0x20
  public    static  System.Int32                    IdentifierValueFieldNumber  // const
  private   static readonly System.String                   IdentifierValueDefaultValue  // static @ 0x10
  private           System.String                   identifierValue_  // 0x28
  public    static  System.Int32                    PositiveIntValueFieldNumber  // const
  private   static readonly System.UInt64                   PositiveIntValueDefaultValue  // static @ 0x18
  private           System.UInt64                   positiveIntValue_  // 0x30
  public    static  System.Int32                    NegativeIntValueFieldNumber  // const
  private   static readonly System.Int64                    NegativeIntValueDefaultValue  // static @ 0x20
  private           System.Int64                    negativeIntValue_  // 0x38
  public    static  System.Int32                    DoubleValueFieldNumber  // const
  private   static readonly System.Double                   DoubleValueDefaultValue  // static @ 0x28
  private           System.Double                   doubleValue_  // 0x40
  public    static  System.Int32                    StringValueFieldNumber  // const
  private   static readonly Google.Protobuf.ByteString      StringValueDefaultValue  // static @ 0x30
  private           Google.Protobuf.ByteString      stringValue_  // 0x48
  public    static  System.Int32                    AggregateValueFieldNumber  // const
  private   static readonly System.String                   AggregateValueDefaultValue  // static @ 0x38
  private           System.String                   aggregateValue_  // 0x50
PROPERTIES:
  Parser  get=0x0858D144
  Descriptor  get=0x0858CF90
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0858D5BC
  Name  get=0x03D4EB40
  IdentifierValue  get=0x0858D098  set=0x0858D664
  HasIdentifierValue  get=0x05693D38
  PositiveIntValue  get=0x0858D194  set=0x03D6BF70
  HasPositiveIntValue  get=0x02461A70
  NegativeIntValue  get=0x0858D0EC  set=0x03D6BF60
  HasNegativeIntValue  get=0x08570E90
  DoubleValue  get=0x0858CFF0  set=0x03D6BF50
  HasDoubleValue  get=0x08571E5C
  StringValue  get=0x0858D1EC  set=0x0858D6CC
  HasStringValue  get=0x0858D048
  AggregateValue  get=0x0858CF3C  set=0x0858D5FC
  HasAggregateValue  get=0x02B84230
METHODS:
  RVA=0x0858CEC4  token=0x60009C8  System.Void .ctor()
  RVA=0x0858CDE4  token=0x60009C9  System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption other)
  RVA=0x0858C604  token=0x60009CA  Google.Protobuf.Reflection.UninterpretedOption Clone()
  RVA=0x08254178  token=0x60009CF  System.Void ClearIdentifierValue()
  RVA=0x03D4F650  token=0x60009D3  System.Void ClearPositiveIntValue()
  RVA=0x03D6BC50  token=0x60009D7  System.Void ClearNegativeIntValue()
  RVA=0x03D6BCA0  token=0x60009DB  System.Void ClearDoubleValue()
  RVA=0x05D6CFCC  token=0x60009DF  System.Void ClearStringValue()
  RVA=0x05D62B3C  token=0x60009E3  System.Void ClearAggregateValue()
  RVA=0x0858C664  token=0x60009E4  System.Boolean Equals(System.Object other)
  RVA=0x0858C6C8  token=0x60009E5  System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption other)
  RVA=0x0858C8A0  token=0x60009E6  System.Int32 GetHashCode()
  RVA=0x0858CB3C  token=0x60009E7  System.String ToString()
  RVA=0x03D47770  token=0x60009E8  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0858D408  token=0x60009E9  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0858C454  token=0x60009EA  System.Int32 CalculateSize()
  RVA=0x0858CA10  token=0x60009EB  System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other)
  RVA=0x03D47500  token=0x60009EC  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0858D240  token=0x60009ED  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0858CB88  token=0x60009EE  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.SourceCodeInfo
TYPE:  sealed class
TOKEN: 0x20000E4
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    LocationFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>_repeated_location_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>location_  // 0x18
PROPERTIES:
  Parser  get=0x0858B4A8
  Descriptor  get=0x0858B448
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0858B66C
  Location  get=0x01041090
METHODS:
  RVA=0x0858B348  token=0x6000A11  System.Void .ctor()
  RVA=0x0858B3C0  token=0x6000A12  System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo other)
  RVA=0x0858AFD4  token=0x6000A13  Google.Protobuf.Reflection.SourceCodeInfo Clone()
  RVA=0x0858B0B0  token=0x6000A15  System.Boolean Equals(System.Object other)
  RVA=0x0858B034  token=0x6000A16  System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo other)
  RVA=0x0517BB20  token=0x6000A17  System.Int32 GetHashCode()
  RVA=0x0858B18C  token=0x6000A18  System.String ToString()
  RVA=0x03D47770  token=0x6000A19  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0858B5C8  token=0x6000A1A  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0858AF40  token=0x6000A1B  System.Int32 CalculateSize()
  RVA=0x0858B114  token=0x6000A1C  System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other)
  RVA=0x03D47500  token=0x6000A1D  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0858B4F8  token=0x6000A1E  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0858B1D8  token=0x6000A1F  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.GeneratedCodeInfo
TYPE:  sealed class
TOKEN: 0x20000E9
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    AnnotationFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>_repeated_annotation_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>annotation_  // 0x18
PROPERTIES:
  Parser  get=0x08585150
  Descriptor  get=0x085850F0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08585314
  Annotation  get=0x01041090
METHODS:
  RVA=0x08585078  token=0x6000A45  System.Void .ctor()
  RVA=0x08584FF0  token=0x6000A46  System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  RVA=0x08584C7C  token=0x6000A47  Google.Protobuf.Reflection.GeneratedCodeInfo Clone()
  RVA=0x08584CDC  token=0x6000A49  System.Boolean Equals(System.Object other)
  RVA=0x08584D40  token=0x6000A4A  System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  RVA=0x0517BB20  token=0x6000A4B  System.Int32 GetHashCode()
  RVA=0x08584E34  token=0x6000A4C  System.String ToString()
  RVA=0x03D47770  token=0x6000A4D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08585270  token=0x6000A4E  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08584BE8  token=0x6000A4F  System.Int32 CalculateSize()
  RVA=0x08584DBC  token=0x6000A50  System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other)
  RVA=0x03D47500  token=0x6000A51  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085851A0  token=0x6000A52  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08584E80  token=0x6000A53  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorBase
TYPE:  abstract class
TOKEN: 0x20000EE
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.Reflection.IDescriptor
FIELDS:
  private   readonly System.Int32                    <Index>k__BackingField  // 0x10
  private   readonly System.String                   <FullName>k__BackingField  // 0x18
  private   readonly Google.Protobuf.Reflection.FileDescriptor<File>k__BackingField  // 0x20
PROPERTIES:
  Index  get=0x03D4E340
  Name  get=-1  // abstract
  FullName  get=0x01041090
  File  get=0x03D4EB40
  Declaration  get=0x0857C144
METHODS:
  RVA=0x0857C114  token=0x6000A78  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, System.String fullName, System.Int32 index)
  RVA=0x01002730  token=0x6000A7E  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorDeclaration
TYPE:  sealed class
TOKEN: 0x20000EF
SIZE:  0x40
FIELDS:
  private   readonly Google.Protobuf.Reflection.IDescriptor<Descriptor>k__BackingField  // 0x10
  private   readonly System.Int32                    <StartLine>k__BackingField  // 0x18
  private   readonly System.Int32                    <StartColumn>k__BackingField  // 0x1c
  private   readonly System.Int32                    <EndLine>k__BackingField  // 0x20
  private   readonly System.Int32                    <EndColumn>k__BackingField  // 0x24
  private   readonly System.String                   <LeadingComments>k__BackingField  // 0x28
  private   readonly System.String                   <TrailingComments>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.IReadOnlyList<System.String><LeadingDetachedComments>k__BackingField  // 0x38
PROPERTIES:
  Descriptor  get=0x020B7B20
  StartLine  get=0x020D1AC0
  StartColumn  get=0x03D4EBB0
  EndLine  get=0x01003B50
  EndColumn  get=0x03D4E2E0
  LeadingComments  get=0x03D4EAC0
  TrailingComments  get=0x01003830
  LeadingDetachedComments  get=0x03D4E2A0
METHODS:
  RVA=0x0857C1DC  token=0x6000A87  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location)
  RVA=0x0857C16C  token=0x6000A88  Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorPool
TYPE:  sealed class
TOKEN: 0x20000F0
SIZE:  0x30
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.IDescriptor>descriptorsByName  // 0x10
  private   readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.FieldDescriptor>fieldsByNumber  // 0x18
  private   readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.EnumValueDescriptor>enumValuesByNumber  // 0x20
  private   readonly System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor>dependencies  // 0x28
  private   static readonly System.Text.RegularExpressions.RegexValidationRegex  // static @ 0x0
METHODS:
  RVA=0x0857D3AC  token=0x6000A89  System.Void .ctor(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles)
  RVA=0x0857CD24  token=0x6000A8A  System.Void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file)
  RVA=-1  // generic def  token=0x6000A8B  T FindSymbol(System.String fullName)
  RVA=0x0857C678  token=0x6000A8C  System.Void AddPackage(System.String fullName, Google.Protobuf.Reflection.FileDescriptor file)
  RVA=0x0857C8E0  token=0x6000A8D  System.Void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor)
  RVA=0x0857D158  token=0x6000A8E  System.Void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor)
  RVA=0x0857CC80  token=0x6000A8F  Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, System.Int32 number)
  RVA=0x0857CBDC  token=0x6000A90  Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, System.Int32 number)
  RVA=0x0857C440  token=0x6000A91  System.Void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field)
  RVA=0x0857C37C  token=0x6000A92  System.Void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue)
  RVA=0x0857CE98  token=0x6000A93  Google.Protobuf.Reflection.IDescriptor LookupSymbol(System.String name, Google.Protobuf.Reflection.IDescriptor relativeTo)
  RVA=0x0857D2E8  token=0x6000A94  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorUtil
TYPE:  static class
TOKEN: 0x20000F1
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000A95  System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput,TOutput> converter)
END_CLASS

CLASS: Google.Protobuf.Reflection.DescriptorValidationException
TYPE:  sealed class
TOKEN: 0x20000F3
SIZE:  0xA0
EXTENDS: System.Exception
FIELDS:
  private   readonly System.String                   name  // 0x90
  private   readonly System.String                   description  // 0x98
PROPERTIES:
  ProblemSymbolName  get=0x03D4EA90
  Description  get=0x011AC510
METHODS:
  RVA=0x0857D75C  token=0x6000A9C  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description)
  RVA=0x0857D828  token=0x6000A9D  System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description, System.Exception cause)
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumDescriptor
TYPE:  sealed class
TOKEN: 0x20000F4
SIZE:  0x48
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.EnumDescriptorProtoproto  // 0x28
  private   readonly Google.Protobuf.Reflection.MessageDescriptorcontainingType  // 0x30
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor>values  // 0x38
  private   readonly System.Type                     clrType  // 0x40
PROPERTIES:
  Proto  get=0x03D4EAC0
  Name  get=0x0857DCFC
  ClrType  get=0x03D4E2B0
  ContainingType  get=0x01003830
  Values  get=0x03D4E2A0
  CustomOptions  get=0x0857DC6C
METHODS:
  RVA=0x0857DA60  token=0x6000A9E  System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.Type clrType)
  RVA=0x0857DA40  token=0x6000AA0  Google.Protobuf.Reflection.EnumDescriptorProto ToProto()
  RVA=0x0857D9C4  token=0x6000AA2  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  RVA=0x0857D994  token=0x6000AA6  Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(System.Int32 number)
  RVA=0x0857D908  token=0x6000AA7  Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(System.String name)
  RVA=0x0857DA14  token=0x6000AA9  Google.Protobuf.Reflection.EnumOptions GetOptions()
  RVA=-1  // generic def  token=0x6000AAA  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,T> extension)
  RVA=-1  // generic def  token=0x6000AAB  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,T> extension)
END_CLASS

CLASS: Google.Protobuf.Reflection.EnumValueDescriptor
TYPE:  sealed class
TOKEN: 0x20000F6
SIZE:  0x38
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.EnumDescriptorenumDescriptor  // 0x28
  private   readonly Google.Protobuf.Reflection.EnumValueDescriptorProtoproto  // 0x30
PROPERTIES:
  Proto  get=0x01003830
  Name  get=0x0857F9E8
  Number  get=0x0857FA08
  EnumDescriptor  get=0x03D4EAC0
  CustomOptions  get=0x0857F958
METHODS:
  RVA=0x0857F860  token=0x6000AAE  System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, System.Int32 index)
  RVA=0x0857F840  token=0x6000AB0  Google.Protobuf.Reflection.EnumValueDescriptorProto ToProto()
  RVA=0x0857F814  token=0x6000AB5  Google.Protobuf.Reflection.EnumValueOptions GetOptions()
  RVA=-1  // generic def  token=0x6000AB6  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,T> extension)
  RVA=-1  // generic def  token=0x6000AB7  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,T> extension)
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionAccessor
TYPE:  sealed class
TOKEN: 0x20000F7
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.Reflection.IFieldAccessor
FIELDS:
  private   readonly Google.Protobuf.Extension       extension  // 0x10
  private   readonly Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelperhelper  // 0x18
  private   readonly Google.Protobuf.Reflection.FieldDescriptor<Descriptor>k__BackingField  // 0x20
PROPERTIES:
  Descriptor  get=0x03D4EB40
METHODS:
  RVA=0x085805D0  token=0x6000AB8  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x0858041C  token=0x6000ABA  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=0x0858052C  token=0x6000ABB  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=0x085804A4  token=0x6000ABC  System.Object GetValue(Google.Protobuf.IMessage message)
  RVA=0x085805B4  token=0x6000ABD  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.ExtensionCollection
TYPE:  sealed class
TOKEN: 0x20000F8
SIZE:  0x28
FIELDS:
  private           System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>extensionsByTypeInDeclarationOrder  // 0x10
  private           System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>extensionsByTypeInNumberOrder  // 0x18
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor><UnorderedExtensions>k__BackingField  // 0x20
PROPERTIES:
  UnorderedExtensions  get=0x03D4EB40
METHODS:
  RVA=0x08581158  token=0x6000ABE  System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions)
  RVA=0x08581050  token=0x6000ABF  System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions)
  RVA=0x08580FB0  token=0x6000AC1  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=0x08581000  token=0x6000AC2  System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=0x08580658  token=0x6000AC3  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldAccessorBase
TYPE:  abstract class
TOKEN: 0x20000FC
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.Reflection.IFieldAccessor
FIELDS:
  private   readonly System.Func<Google.Protobuf.IMessage,System.Object>getValueDelegate  // 0x10
  private   readonly Google.Protobuf.Reflection.FieldDescriptordescriptor  // 0x18
PROPERTIES:
  Descriptor  get=0x01041090
METHODS:
  RVA=0x0858E0F8  token=0x6000ACF  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x0858E0D8  token=0x6000AD1  System.Object GetValue(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000AD2  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000AD3  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000AD4  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldDescriptor
TYPE:  sealed class
TOKEN: 0x20000FD
SIZE:  0x80
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
IMPLEMENTS: System.IComparable`1
FIELDS:
  private           Google.Protobuf.Reflection.EnumDescriptorenumType  // 0x28
  private           Google.Protobuf.Reflection.MessageDescriptorextendeeType  // 0x30
  private           Google.Protobuf.Reflection.MessageDescriptormessageType  // 0x38
  private           Google.Protobuf.Reflection.FieldTypefieldType  // 0x40
  private           Google.Protobuf.Reflection.IFieldAccessoraccessor  // 0x48
  private   readonly Google.Protobuf.Reflection.MessageDescriptor<ContainingType>k__BackingField  // 0x50
  private   readonly Google.Protobuf.Reflection.OneofDescriptor<ContainingOneof>k__BackingField  // 0x58
  private   readonly System.String                   <JsonName>k__BackingField  // 0x60
  private   readonly System.String                   <PropertyName>k__BackingField  // 0x68
  private   readonly Google.Protobuf.Reflection.FieldDescriptorProto<Proto>k__BackingField  // 0x70
  private   readonly Google.Protobuf.Extension       <Extension>k__BackingField  // 0x78
PROPERTIES:
  ContainingType  get=0x03D4EAF0
  ContainingOneof  get=0x03D4EAA0
  RealContainingOneof  get=0x0858F2E4
  JsonName  get=0x03D4EB00
  PropertyName  get=0x03D4EAB0
  HasPresence  get=0x0858F0DC
  Proto  get=0x03D4EB30
  Extension  get=0x03D4EB20
  Name  get=0x0858F2C4
  Accessor  get=0x03D4EA70
  IsRepeated  get=0x0858F204
  IsRequired  get=0x0858F22C
  IsMap  get=0x0858F168
  IsPacked  get=0x0858F1A8
  IsExtension  get=0x0858F148
  FieldType  get=0x03D4ED80
  FieldNumber  get=0x0858F0BC
  EnumType  get=0x0858EFDC
  MessageType  get=0x0858F254
  ExtendeeType  get=0x0858F048
  CustomOptions  get=0x0858EF4C
METHODS:
  RVA=0x0858EC14  token=0x6000ADC  Google.Protobuf.Reflection.FieldDescriptorProto ToProto()
  RVA=0x0858EC34  token=0x6000ADE  System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String propertyName, Google.Protobuf.Extension extension)
  RVA=0x0858EA80  token=0x6000AE1  Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type)
  RVA=0x0858E274  token=0x6000AE9  System.Int32 CompareTo(Google.Protobuf.Reflection.FieldDescriptor other)
  RVA=0x0858EBE8  token=0x6000AEE  Google.Protobuf.Reflection.FieldOptions GetOptions()
  RVA=-1  // generic def  token=0x6000AEF  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,T> extension)
  RVA=-1  // generic def  token=0x6000AF0  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,T> extension)
  RVA=0x0858E50C  token=0x6000AF1  System.Void CrossLink()
  RVA=0x0858E308  token=0x6000AF2  Google.Protobuf.Reflection.IFieldAccessor CreateAccessor()
END_CLASS

CLASS: Google.Protobuf.Reflection.FieldType
TYPE:  sealed struct
TOKEN: 0x20000FE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.FieldTypeDouble  // const
  public    static  Google.Protobuf.Reflection.FieldTypeFloat  // const
  public    static  Google.Protobuf.Reflection.FieldTypeInt64  // const
  public    static  Google.Protobuf.Reflection.FieldTypeUInt64  // const
  public    static  Google.Protobuf.Reflection.FieldTypeInt32  // const
  public    static  Google.Protobuf.Reflection.FieldTypeFixed64  // const
  public    static  Google.Protobuf.Reflection.FieldTypeFixed32  // const
  public    static  Google.Protobuf.Reflection.FieldTypeBool  // const
  public    static  Google.Protobuf.Reflection.FieldTypeString  // const
  public    static  Google.Protobuf.Reflection.FieldTypeGroup  // const
  public    static  Google.Protobuf.Reflection.FieldTypeMessage  // const
  public    static  Google.Protobuf.Reflection.FieldTypeBytes  // const
  public    static  Google.Protobuf.Reflection.FieldTypeUInt32  // const
  public    static  Google.Protobuf.Reflection.FieldTypeSFixed32  // const
  public    static  Google.Protobuf.Reflection.FieldTypeSFixed64  // const
  public    static  Google.Protobuf.Reflection.FieldTypeSInt32  // const
  public    static  Google.Protobuf.Reflection.FieldTypeSInt64  // const
  public    static  Google.Protobuf.Reflection.FieldTypeEnum  // const
METHODS:
END_CLASS

CLASS: Google.Protobuf.Reflection.Syntax
TYPE:  sealed struct
TOKEN: 0x20000FF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.Reflection.SyntaxProto2  // const
  public    static  Google.Protobuf.Reflection.SyntaxProto3  // const
  public    static  Google.Protobuf.Reflection.SyntaxUnknown  // const
METHODS:
END_CLASS

CLASS: Google.Protobuf.Reflection.FileDescriptor
TYPE:  sealed class
TOKEN: 0x2000100
SIZE:  0x68
IMPLEMENTS: Google.Protobuf.Reflection.IDescriptor
FIELDS:
  private   readonly System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>>declarations  // 0x10
  private   readonly Google.Protobuf.Reflection.FileDescriptorProto<Proto>k__BackingField  // 0x18
  private   readonly Google.Protobuf.Reflection.Syntax<Syntax>k__BackingField  // 0x20
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor><MessageTypes>k__BackingField  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor><EnumTypes>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor><Services>k__BackingField  // 0x38
  private   readonly Google.Protobuf.Reflection.ExtensionCollection<Extensions>k__BackingField  // 0x40
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor><Dependencies>k__BackingField  // 0x48
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor><PublicDependencies>k__BackingField  // 0x50
  private   readonly Google.Protobuf.ByteString      <SerializedData>k__BackingField  // 0x58
  private   readonly Google.Protobuf.Reflection.DescriptorPool<DescriptorPool>k__BackingField  // 0x60
PROPERTIES:
  Proto  get=0x01041090
  Syntax  get=0x01003B50
  Name  get=0x08591B10
  Package  get=0x08591B30
  MessageTypes  get=0x03D4EAC0
  EnumTypes  get=0x01003830
  Services  get=0x03D4E2A0
  Extensions  get=0x03D4E2B0
  Dependencies  get=0x03D4EA70
  PublicDependencies  get=0x03D4EAF0
  SerializedData  get=0x03D4EAA0
  Google.Protobuf.Reflection.IDescriptor.FullName  get=0x085914E4
  Google.Protobuf.Reflection.IDescriptor.File  get=0x0339AE90
  DescriptorPool  get=0x03D4EB00
  DescriptorProtoFileDescriptor  get=0x08591AD0
  CustomOptions  get=0x08591A40
METHODS:
  RVA=0x08591554  token=0x6000AF3  System.Void .cctor()
  RVA=0x085915E4  token=0x6000AF4  System.Void .ctor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  RVA=0x0858FE74  token=0x6000AF5  System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap()
  RVA=0x0859062C  token=0x6000AF6  Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<System.Int32> path)
  RVA=0x0859138C  token=0x6000AF7  Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, System.Int32 index)
  RVA=0x08591450  token=0x6000AF8  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  RVA=0x08591304  token=0x6000AF9  Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor)
  RVA=0x0858FDE4  token=0x6000AFA  System.String ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, System.String name)
  RVA=0x085902D8  token=0x6000AFB  System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, System.Boolean allowUnknownDependencies)
  RVA=0x085914EC  token=0x6000AFD  Google.Protobuf.Reflection.FileDescriptorProto ToProto()
  RVA=-1  // generic def  token=0x6000B0B  T FindTypeByName(System.String name)
  RVA=0x0858FC5C  token=0x6000B0C  Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  RVA=0x08590088  token=0x6000B0D  System.Void CrossLink()
  RVA=0x08590788  token=0x6000B0E  Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(System.Byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  RVA=0x0859103C  token=0x6000B0F  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo)
  RVA=0x08591160  token=0x6000B10  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated)
  RVA=0x08590D24  token=0x6000B11  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor)
  RVA=0x08590AA4  token=0x6000B12  System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=0x0858F344  token=0x6000B13  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry)
  RVA=0x0858F2F8  token=0x6000B14  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData)
  RVA=0x0859150C  token=0x6000B15  System.String ToString()
  RVA=0x085914B8  token=0x6000B18  Google.Protobuf.Reflection.FileOptions GetOptions()
  RVA=-1  // generic def  token=0x6000B19  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,T> extension)
  RVA=-1  // generic def  token=0x6000B1A  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,T> extension)
  RVA=-1  // generic def  token=0x6000B1B  System.Void ForceReflectionInitialization()
END_CLASS

CLASS: Google.Protobuf.Reflection.GeneratedClrTypeInfo
TYPE:  sealed class
TOKEN: 0x2000103
SIZE:  0x48
FIELDS:
  private   static readonly System.String[]                 EmptyNames  // static @ 0x0
  private   static readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[]EmptyCodeInfo  // static @ 0x8
  private   static readonly Google.Protobuf.Extension[]     EmptyExtensions  // static @ 0x10
  private   static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesMessageAccessibility  // const
  private           System.Type                     <ClrType>k__BackingField  // 0x10
  private   readonly Google.Protobuf.MessageParser   <Parser>k__BackingField  // 0x18
  private   readonly System.String[]                 <PropertyNames>k__BackingField  // 0x20
  private   readonly Google.Protobuf.Extension[]     <Extensions>k__BackingField  // 0x28
  private   readonly System.String[]                 <OneofNames>k__BackingField  // 0x30
  private   readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[]<NestedTypes>k__BackingField  // 0x38
  private   readonly System.Type[]                   <NestedEnums>k__BackingField  // 0x40
PROPERTIES:
  ClrType  get=0x020B7B20  set=0x0426FEE0
  Parser  get=0x01041090
  PropertyNames  get=0x03D4EB40
  Extensions  get=0x03D4EAC0
  OneofNames  get=0x01003830
  NestedTypes  get=0x03D4E2A0
  NestedEnums  get=0x03D4E2B0
METHODS:
  RVA=0x08591C64  token=0x6000B30  System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  RVA=0x08591E1C  token=0x6000B31  System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  RVA=0x08591DE8  token=0x6000B32  System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  RVA=0x08591C38  token=0x6000B33  System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes)
  RVA=0x08591B50  token=0x6000B34  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.IDescriptor
TYPE:  interface
TOKEN: 0x2000104
FIELDS:
PROPERTIES:
  Name  get=-1  // abstract
  FullName  get=-1  // abstract
  File  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Google.Protobuf.Reflection.IFieldAccessor
TYPE:  interface
TOKEN: 0x2000105
FIELDS:
PROPERTIES:
  Descriptor  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000B39  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000B3A  System.Object GetValue(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000B3B  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=-1  // abstract  token=0x6000B3C  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.MapFieldAccessor
TYPE:  sealed class
TOKEN: 0x2000106
SIZE:  0x20
EXTENDS: Google.Protobuf.Reflection.FieldAccessorBase
FIELDS:
METHODS:
  RVA=0x08591F94  token=0x6000B3D  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x08591E60  token=0x6000B3E  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=0x08591EDC  token=0x6000B3F  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=0x08591F38  token=0x6000B40  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.MessageDescriptor
TYPE:  sealed class
TOKEN: 0x2000107
SIZE:  0x98
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<System.String>WellKnownTypeNames  // static @ 0x0
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fieldsInDeclarationOrder  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fieldsInNumberOrder  // 0x30
  private   readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor>jsonFieldMap  // 0x38
  private           System.Func<Google.Protobuf.IMessage,System.Boolean>extensionSetIsInitialized  // 0x40
  private   readonly Google.Protobuf.Reflection.DescriptorProto<Proto>k__BackingField  // 0x48
  private   readonly System.Type                     <ClrType>k__BackingField  // 0x50
  private   readonly Google.Protobuf.MessageParser   <Parser>k__BackingField  // 0x58
  private   readonly Google.Protobuf.Reflection.MessageDescriptor<ContainingType>k__BackingField  // 0x60
  private   readonly Google.Protobuf.Reflection.MessageDescriptor.FieldCollection<Fields>k__BackingField  // 0x68
  private   readonly Google.Protobuf.Reflection.ExtensionCollection<Extensions>k__BackingField  // 0x70
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor><NestedTypes>k__BackingField  // 0x78
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor><EnumTypes>k__BackingField  // 0x80
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor><Oneofs>k__BackingField  // 0x88
  private   readonly System.Int32                    <RealOneofCount>k__BackingField  // 0x90
PROPERTIES:
  Name  get=0x08593AB0
  Proto  get=0x03D4EA70
  ClrType  get=0x03D4EAF0
  Parser  get=0x03D4EAA0
  IsWellKnownType  get=0x08593964
  IsWrapperType  get=0x08593A24
  ContainingType  get=0x03D4EB00
  Fields  get=0x03D4EAB0
  Extensions  get=0x03D4EB30
  NestedTypes  get=0x03D4EB20
  EnumTypes  get=0x03D4EAE0
  Oneofs  get=0x03D4EA60
  RealOneofCount  get=0x03D4FB60
  CustomOptions  get=0x085938D4
METHODS:
  RVA=0x08592A90  token=0x6000B41  System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
  RVA=0x08591F9C  token=0x6000B42  System.Collections.ObjectModel.ReadOnlyDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields)
  RVA=0x08592734  token=0x6000B44  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  RVA=0x08592880  token=0x6000B46  Google.Protobuf.Reflection.DescriptorProto ToProto()
  RVA=0x085927CC  token=0x6000B47  System.Boolean IsExtensionsInitialized(Google.Protobuf.IMessage message)
  RVA=0x08592678  token=0x6000B53  Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(System.String name)
  RVA=0x08592704  token=0x6000B54  Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(System.Int32 number)
  RVA=-1  // generic def  token=0x6000B55  T FindDescriptor(System.String name)
  RVA=0x085927A0  token=0x6000B57  Google.Protobuf.Reflection.MessageOptions GetOptions()
  RVA=-1  // generic def  token=0x6000B58  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,T> extension)
  RVA=-1  // generic def  token=0x6000B59  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,T> extension)
  RVA=0x08592328  token=0x6000B5A  System.Void CrossLink()
  RVA=0x085928A0  token=0x6000B5B  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.Reflection.MethodDescriptor
TYPE:  sealed class
TOKEN: 0x200010B
SIZE:  0x48
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.MethodDescriptorProtoproto  // 0x28
  private   readonly Google.Protobuf.Reflection.ServiceDescriptorservice  // 0x30
  private           Google.Protobuf.Reflection.MessageDescriptorinputType  // 0x38
  private           Google.Protobuf.Reflection.MessageDescriptoroutputType  // 0x40
PROPERTIES:
  Service  get=0x01003830
  InputType  get=0x03D4E2A0
  OutputType  get=0x03D4E2B0
  IsClientStreaming  get=0x08593ED8
  IsServerStreaming  get=0x08593EF8
  CustomOptions  get=0x08593E48
  Proto  get=0x03D4EAC0
  Name  get=0x08593F18
METHODS:
  RVA=0x08593D18  token=0x6000B70  Google.Protobuf.Reflection.MethodOptions GetOptions()
  RVA=-1  // generic def  token=0x6000B71  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,T> extension)
  RVA=-1  // generic def  token=0x6000B72  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,T> extension)
  RVA=0x08593D64  token=0x6000B73  System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, System.Int32 index)
  RVA=0x08593D44  token=0x6000B75  Google.Protobuf.Reflection.MethodDescriptorProto ToProto()
  RVA=0x08593AD0  token=0x6000B77  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofAccessor
TYPE:  sealed class
TOKEN: 0x200010C
SIZE:  0x28
FIELDS:
  private   readonly System.Func<Google.Protobuf.IMessage,System.Int32>caseDelegate  // 0x10
  private   readonly System.Action<Google.Protobuf.IMessage>clearDelegate  // 0x18
  private   readonly Google.Protobuf.Reflection.OneofDescriptor<Descriptor>k__BackingField  // 0x20
PROPERTIES:
  Descriptor  get=0x03D4EB40
METHODS:
  RVA=0x085941A8  token=0x6000B78  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate)
  RVA=0x08593F58  token=0x6000B79  Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod)
  RVA=0x08594020  token=0x6000B7A  Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor)
  RVA=0x08593F38  token=0x6000B7C  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=0x08594158  token=0x6000B7D  Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message)
END_CLASS

CLASS: Google.Protobuf.Reflection.OneofDescriptor
TYPE:  sealed class
TOKEN: 0x200010E
SIZE:  0x50
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private           Google.Protobuf.Reflection.MessageDescriptorcontainingType  // 0x28
  private           System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>fields  // 0x30
  private   readonly Google.Protobuf.Reflection.OneofAccessoraccessor  // 0x38
  private   readonly Google.Protobuf.Reflection.OneofDescriptorProto<Proto>k__BackingField  // 0x40
  private   readonly System.Boolean                  <IsSynthetic>k__BackingField  // 0x48
PROPERTIES:
  Name  get=0x08594AD4
  Proto  get=0x03D4E2B0
  ContainingType  get=0x03D4EAC0
  Fields  get=0x01003830
  IsSynthetic  get=0x03D4EFE0
  Accessor  get=0x03D4E2A0
  CustomOptions  get=0x08594A44
METHODS:
  RVA=0x085948A4  token=0x6000B81  System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String clrName)
  RVA=0x08594884  token=0x6000B84  Google.Protobuf.Reflection.OneofDescriptorProto ToProto()
  RVA=0x08594858  token=0x6000B8A  Google.Protobuf.Reflection.OneofOptions GetOptions()
  RVA=-1  // generic def  token=0x6000B8B  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,T> extension)
  RVA=-1  // generic def  token=0x6000B8C  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,T> extension)
  RVA=0x08594484  token=0x6000B8D  System.Void CrossLink()
  RVA=0x085941E0  token=0x6000B8E  Google.Protobuf.Reflection.OneofAccessor CreateAccessor(System.String clrName)
END_CLASS

CLASS: Google.Protobuf.Reflection.OriginalNameAttribute
TYPE:  class
TOKEN: 0x2000110
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <PreferredAlias>k__BackingField  // 0x18
PROPERTIES:
  Name  get=0x020B7B20  set=0x0426FEE0
  PreferredAlias  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x023C46A0  token=0x6000B95  System.Void .ctor(System.String name)
END_CLASS

CLASS: Google.Protobuf.Reflection.PackageDescriptor
TYPE:  sealed class
TOKEN: 0x2000111
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.Reflection.IDescriptor
FIELDS:
  private   readonly System.String                   name  // 0x10
  private   readonly System.String                   fullName  // 0x18
  private   readonly Google.Protobuf.Reflection.FileDescriptorfile  // 0x20
PROPERTIES:
  Name  get=0x020B7B20
  FullName  get=0x01041090
  File  get=0x03D4EB40
METHODS:
  RVA=0x08594AF4  token=0x6000B96  System.Void .ctor(System.String name, System.String fullName, Google.Protobuf.Reflection.FileDescriptor file)
END_CLASS

CLASS: Google.Protobuf.Reflection.ReflectionUtil
TYPE:  static class
TOKEN: 0x2000112
SIZE:  0x10
FIELDS:
  private   static readonly System.Type[]                   EmptyTypes  // static @ 0x0
  private   static readonly System.Boolean                  <CanConvertEnumFuncToInt32Func>k__BackingField  // static @ 0x8
PROPERTIES:
  CanConvertEnumFuncToInt32Func  get=0x085958F4
METHODS:
  RVA=0x085956F4  token=0x6000B9A  System.Void .cctor()
  RVA=-1  // generic def  token=0x6000B9B  System.Void ForceInitialize()
  RVA=0x085953B4  token=0x6000B9C  System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method)
  RVA=0x085952D0  token=0x6000B9D  System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method)
  RVA=0x08594E3C  token=0x6000B9E  System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method)
  RVA=0x08594F40  token=0x6000B9F  System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method)
  RVA=0x085951EC  token=0x6000BA0  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method)
  RVA=0x08595498  token=0x6000BA1  System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller(System.Type msg)
  RVA=0x0859504C  token=0x6000BA2  Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension)
  RVA=0x085955E8  token=0x6000BA3  Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2)
  RVA=0x08594D10  token=0x6000BA5  System.Boolean CheckCanConvertEnumFuncToInt32Func()
  RVA=0x01002730  token=0x6000BA6  Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod()
END_CLASS

CLASS: Google.Protobuf.Reflection.RepeatedFieldAccessor
TYPE:  sealed class
TOKEN: 0x2000121
SIZE:  0x20
EXTENDS: Google.Protobuf.Reflection.FieldAccessorBase
FIELDS:
METHODS:
  RVA=0x08591F94  token=0x6000BCC  System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x08595944  token=0x6000BCD  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=0x085959C0  token=0x6000BCE  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=0x08595A1C  token=0x6000BCF  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.ServiceDescriptor
TYPE:  sealed class
TOKEN: 0x2000122
SIZE:  0x38
EXTENDS: Google.Protobuf.Reflection.DescriptorBase
FIELDS:
  private   readonly Google.Protobuf.Reflection.ServiceDescriptorProtoproto  // 0x28
  private   readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor>methods  // 0x30
PROPERTIES:
  Name  get=0x08595EC4
  Proto  get=0x03D4EAC0
  Methods  get=0x01003830
  CustomOptions  get=0x08595E34
METHODS:
  RVA=0x08595CC0  token=0x6000BD0  System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, System.Int32 index)
  RVA=0x08595C24  token=0x6000BD2  System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber)
  RVA=0x08595CA0  token=0x6000BD4  Google.Protobuf.Reflection.ServiceDescriptorProto ToProto()
  RVA=0x08595B98  token=0x6000BD6  Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(System.String name)
  RVA=0x08595C74  token=0x6000BD8  Google.Protobuf.Reflection.ServiceOptions GetOptions()
  RVA=-1  // generic def  token=0x6000BD9  T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,T> extension)
  RVA=-1  // generic def  token=0x6000BDA  Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,T> extension)
  RVA=0x08595A78  token=0x6000BDB  System.Void CrossLink()
END_CLASS

CLASS: Google.Protobuf.Reflection.SingleFieldAccessor
TYPE:  sealed class
TOKEN: 0x2000124
SIZE:  0x38
EXTENDS: Google.Protobuf.Reflection.FieldAccessorBase
FIELDS:
  private   readonly System.Action<Google.Protobuf.IMessage,System.Object>setValueDelegate  // 0x20
  private   readonly System.Action<Google.Protobuf.IMessage>clearDelegate  // 0x28
  private   readonly System.Func<Google.Protobuf.IMessage,System.Boolean>hasDelegate  // 0x30
METHODS:
  RVA=0x08596154  token=0x6000BDE  System.Void .ctor(System.Type messageType, System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x08595EE4  token=0x6000BDF  System.Object GetDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor)
  RVA=0x057776CC  token=0x6000BE0  System.Void Clear(Google.Protobuf.IMessage message)
  RVA=0x08596114  token=0x6000BE1  System.Boolean HasValue(Google.Protobuf.IMessage message)
  RVA=0x08596134  token=0x6000BE2  System.Void SetValue(Google.Protobuf.IMessage message, System.Object value)
END_CLASS

CLASS: Google.Protobuf.Reflection.TypeRegistry
TYPE:  sealed class
TOKEN: 0x2000129
SIZE:  0x18
FIELDS:
  private   static readonly Google.Protobuf.Reflection.TypeRegistry<Empty>k__BackingField  // static @ 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor>fullNameToMessageMap  // 0x10
PROPERTIES:
  Empty  get=0x08596E64
METHODS:
  RVA=0x0426FEE0  token=0x6000BEF  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap)
  RVA=0x0859699C  token=0x6000BF0  Google.Protobuf.Reflection.MessageDescriptor Find(System.String fullName)
  RVA=0x08596A04  token=0x6000BF1  Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors)
  RVA=0x08596A50  token=0x6000BF2  Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors)
  RVA=0x08596C08  token=0x6000BF3  Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors)
  RVA=0x08596C54  token=0x6000BF4  Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors)
  RVA=0x08596DAC  token=0x6000BF5  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.AnyReflection
TYPE:  static class
TOKEN: 0x2000060
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x08555208
METHODS:
  RVA=0x08554EB0  token=0x60003A9  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Any
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    TypeUrlFieldNumber  // const
  private           System.String                   typeUrl_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // const
  private           Google.Protobuf.ByteString      value_  // 0x20
  private   static  System.String                   DefaultPrefix  // const
PROPERTIES:
  Parser  get=0x08555B44
  Descriptor  get=0x08555AE4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08555CD4
  TypeUrl  get=0x01041090  set=0x08555D14
  Value  get=0x03D4EB40  set=0x08555D7C
METHODS:
  RVA=0x08555A7C  token=0x60003AD  System.Void .ctor()
  RVA=0x08555A14  token=0x60003AE  System.Void .ctor(Google.Protobuf.WellKnownTypes.Any other)
  RVA=0x08555310  token=0x60003AF  Google.Protobuf.WellKnownTypes.Any Clone()
  RVA=0x08555370  token=0x60003B4  System.Boolean Equals(System.Object other)
  RVA=0x085553D4  token=0x60003B5  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Any other)
  RVA=0x0855547C  token=0x60003B6  System.Int32 GetHashCode()
  RVA=0x085558C4  token=0x60003B7  System.String ToString()
  RVA=0x03D47770  token=0x60003B8  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08555C40  token=0x60003B9  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08555258  token=0x60003BA  System.Int32 CalculateSize()
  RVA=0x085556B8  token=0x60003BB  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Any other)
  RVA=0x03D47500  token=0x60003BC  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08555B94  token=0x60003BD  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08555594  token=0x60003BE  System.String GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String prefix)
  RVA=0x08555500  token=0x60003BF  System.String GetTypeName(System.String typeUrl)
  RVA=0x08555620  token=0x60003C0  System.Boolean Is(Google.Protobuf.Reflection.MessageDescriptor descriptor)
  RVA=-1  // generic def  token=0x60003C1  T Unpack()
  RVA=-1  // generic def  token=0x60003C2  System.Boolean TryUnpack(T& result)
  RVA=0x08555870  token=0x60003C3  Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message)
  RVA=0x08555738  token=0x60003C4  Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, System.String typeUrlPrefix)
  RVA=0x08555910  token=0x60003C5  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.ApiReflection
TYPE:  static class
TOKEN: 0x2000063
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x085565E0
METHODS:
  RVA=0x08555DE4  token=0x60003CA  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Api
TYPE:  sealed class
TOKEN: 0x2000064
SIZE:  0x50
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    MethodsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method>_repeated_methods_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method>methods_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
  public    static  System.Int32                    VersionFieldNumber  // const
  private           System.String                   version_  // 0x30
  public    static  System.Int32                    SourceContextFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x38
  public    static  System.Int32                    MixinsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin>_repeated_mixins_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin>mixins_  // 0x40
  public    static  System.Int32                    SyntaxFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x48
PROPERTIES:
  Parser  get=0x085571D8
  Descriptor  get=0x08557178
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08557638
  Name  get=0x01041090  set=0x08557678
  Methods  get=0x03D4EB40
  Options  get=0x03D4EAC0
  Version  get=0x01003830  set=0x085576E0
  SourceContext  get=0x03D4E2A0  set=0x0388FF30
  Mixins  get=0x03D4E2B0
  Syntax  get=0x03D4EC50  set=0x03D4ECD0
METHODS:
  RVA=0x08556EFC  token=0x60003CE  System.Void .ctor()
  RVA=0x0855703C  token=0x60003CF  System.Void .ctor(Google.Protobuf.WellKnownTypes.Api other)
  RVA=0x08556810  token=0x60003D0  Google.Protobuf.WellKnownTypes.Api Clone()
  RVA=0x08556870  token=0x60003DC  System.Boolean Equals(System.Object other)
  RVA=0x085568D4  token=0x60003DD  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Api other)
  RVA=0x085569FC  token=0x60003DE  System.Int32 GetHashCode()
  RVA=0x08556C70  token=0x60003DF  System.String ToString()
  RVA=0x03D47770  token=0x60003E0  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08557474  token=0x60003E1  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08556630  token=0x60003E2  System.Int32 CalculateSize()
  RVA=0x08556AF0  token=0x60003E3  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Api other)
  RVA=0x03D47500  token=0x60003E4  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08557228  token=0x60003E5  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08556CBC  token=0x60003E6  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Method
TYPE:  sealed class
TOKEN: 0x2000066
SIZE:  0x50
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    RequestTypeUrlFieldNumber  // const
  private           System.String                   requestTypeUrl_  // 0x20
  public    static  System.Int32                    RequestStreamingFieldNumber  // const
  private           System.Boolean                  requestStreaming_  // 0x28
  public    static  System.Int32                    ResponseTypeUrlFieldNumber  // const
  private           System.String                   responseTypeUrl_  // 0x30
  public    static  System.Int32                    ResponseStreamingFieldNumber  // const
  private           System.Boolean                  responseStreaming_  // 0x38
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x40
  public    static  System.Int32                    SyntaxFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x48
PROPERTIES:
  Parser  get=0x0855B72C
  Descriptor  get=0x0855B6CC
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855BAB8
  Name  get=0x01041090  set=0x0855BAF8
  RequestTypeUrl  get=0x03D4EB40  set=0x0855BB60
  RequestStreaming  get=0x03D4ED50  set=0x03D4ED60
  ResponseTypeUrl  get=0x01003830  set=0x0855BBC8
  ResponseStreaming  get=0x03D4F190  set=0x03D4E280
  Options  get=0x03D4E2B0
  Syntax  get=0x03D4EC50  set=0x03D4ECD0
METHODS:
  RVA=0x0855B60C  token=0x60003ED  System.Void .ctor()
  RVA=0x0855B538  token=0x60003EE  System.Void .ctor(Google.Protobuf.WellKnownTypes.Method other)
  RVA=0x0855AFD4  token=0x60003EF  Google.Protobuf.WellKnownTypes.Method Clone()
  RVA=0x0855B10C  token=0x60003FD  System.Boolean Equals(System.Object other)
  RVA=0x0855B034  token=0x60003FE  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Method other)
  RVA=0x0855B170  token=0x60003FF  System.Int32 GetHashCode()
  RVA=0x0855B37C  token=0x6000400  System.String ToString()
  RVA=0x03D47770  token=0x6000401  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0855B924  token=0x6000402  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855AE48  token=0x6000403  System.Int32 CalculateSize()
  RVA=0x0855B27C  token=0x6000404  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Method other)
  RVA=0x03D47500  token=0x6000405  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855B77C  token=0x6000406  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0855B3C8  token=0x6000407  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Mixin
TYPE:  sealed class
TOKEN: 0x2000068
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    RootFieldNumber  // const
  private           System.String                   root_  // 0x20
PROPERTIES:
  Parser  get=0x0855C090
  Descriptor  get=0x0855C030
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855C18C
  Name  get=0x01041090  set=0x0855C1CC
  Root  get=0x03D4EB40  set=0x0855C234
METHODS:
  RVA=0x0855BFDC  token=0x600040E  System.Void .ctor()
  RVA=0x0855BF74  token=0x600040F  System.Void .ctor(Google.Protobuf.WellKnownTypes.Mixin other)
  RVA=0x0855BCE4  token=0x6000410  Google.Protobuf.WellKnownTypes.Mixin Clone()
  RVA=0x0855BD44  token=0x6000415  System.Boolean Equals(System.Object other)
  RVA=0x051B1588  token=0x6000416  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Mixin other)
  RVA=0x051B15F0  token=0x6000417  System.Int32 GetHashCode()
  RVA=0x0855BE24  token=0x6000418  System.String ToString()
  RVA=0x03D47770  token=0x6000419  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x051B19A0  token=0x600041A  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855BC30  token=0x600041B  System.Int32 CalculateSize()
  RVA=0x0855BDA8  token=0x600041C  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other)
  RVA=0x03D47500  token=0x600041D  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855C0E0  token=0x600041E  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0855BE70  token=0x600041F  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.DurationReflection
TYPE:  static class
TOKEN: 0x200006A
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x08557AC0
METHODS:
  RVA=0x08557748  token=0x6000424  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Duration
TYPE:  sealed class
TOKEN: 0x200006B
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage Google.Protobuf.ICustomDiagnosticMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    SecondsFieldNumber  // const
  private           System.Int64                    seconds_  // 0x18
  public    static  System.Int32                    NanosFieldNumber  // const
  private           System.Int32                    nanos_  // 0x20
  public    static  System.Int32                    NanosecondsPerSecond  // const
  public    static  System.Int32                    NanosecondsPerTick  // const
  public    static  System.Int64                    MaxSeconds  // const
  public    static  System.Int64                    MinSeconds  // const
  private   static  System.Int32                    MaxNanoseconds  // const
  private   static  System.Int32                    MinNanoseconds  // const
PROPERTIES:
  Parser  get=0x08558664
  Descriptor  get=0x085585D0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08558A3C
  Seconds  get=0x01041090  set=0x03D4EC10
  Nanos  get=0x01003B50  set=0x01003B60
METHODS:
  RVA=0x0350B670  token=0x6000428  System.Void .ctor()
  RVA=0x05167AFC  token=0x6000429  System.Void .ctor(Google.Protobuf.WellKnownTypes.Duration other)
  RVA=0x08557CFC  token=0x600042A  Google.Protobuf.WellKnownTypes.Duration Clone()
  RVA=0x08557D5C  token=0x600042F  System.Boolean Equals(System.Object other)
  RVA=0x05168418  token=0x6000430  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Duration other)
  RVA=0x0516844C  token=0x6000431  System.Int32 GetHashCode()
  RVA=0x08558318  token=0x6000432  System.String ToString()
  RVA=0x03D47770  token=0x6000433  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x05168678  token=0x6000434  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08557C60  token=0x6000435  System.Int32 CalculateSize()
  RVA=0x05168498  token=0x6000436  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other)
  RVA=0x03D47500  token=0x6000437  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x051685E0  token=0x6000438  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08557F44  token=0x6000439  System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds)
  RVA=0x08558364  token=0x600043A  System.TimeSpan ToTimeSpan()
  RVA=0x08557DC0  token=0x600043B  Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan)
  RVA=0x08558944  token=0x600043C  Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value)
  RVA=0x085586B4  token=0x600043D  Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  RVA=0x085587F8  token=0x600043E  Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  RVA=0x08557FD8  token=0x600043F  Google.Protobuf.WellKnownTypes.Duration Normalize(System.Int64 seconds, System.Int32 nanoseconds)
  RVA=0x085580CC  token=0x6000440  System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly)
  RVA=0x08558074  token=0x6000441  System.String ToDiagnosticString()
  RVA=0x08557B10  token=0x6000442  System.Void AppendNanoseconds(System.Text.StringBuilder builder, System.Int32 nanos)
  RVA=0x085584CC  token=0x6000443  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.EmptyReflection
TYPE:  static class
TOKEN: 0x200006D
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x08558D74
METHODS:
  RVA=0x08558A7C  token=0x6000448  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Empty
TYPE:  sealed class
TOKEN: 0x200006E
SIZE:  0x18
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
PROPERTIES:
  Parser  get=0x0855906C
  Descriptor  get=0x08558FD8
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085590BC
METHODS:
  RVA=0x0350B670  token=0x600044C  System.Void .ctor()
  RVA=0x0518C054  token=0x600044D  System.Void .ctor(Google.Protobuf.WellKnownTypes.Empty other)
  RVA=0x08558DC4  token=0x600044E  Google.Protobuf.WellKnownTypes.Empty Clone()
  RVA=0x08558E24  token=0x600044F  System.Boolean Equals(System.Object other)
  RVA=0x0518BE84  token=0x6000450  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Empty other)
  RVA=0x0518BEA8  token=0x6000451  System.Int32 GetHashCode()
  RVA=0x08558E88  token=0x6000452  System.String ToString()
  RVA=0x03D47770  token=0x6000453  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0518C194  token=0x6000454  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0518BDA0  token=0x6000455  System.Int32 CalculateSize()
  RVA=0x0518BED4  token=0x6000456  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other)
  RVA=0x03D47500  token=0x6000457  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0518C138  token=0x6000458  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08558ED4  token=0x6000459  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FieldMaskReflection
TYPE:  static class
TOKEN: 0x2000070
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x08559434
METHODS:
  RVA=0x085590FC  token=0x600045E  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FieldMask
TYPE:  sealed class
TOKEN: 0x2000071
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage Google.Protobuf.ICustomDiagnosticMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    PathsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_paths_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>paths_  // 0x18
  private   static  System.Char                     FIELD_PATH_SEPARATOR  // const
  private   static  System.Char                     FIELD_SEPARATOR_REGEX  // const
PROPERTIES:
  Parser  get=0x0855A4D8
  Descriptor  get=0x0855A444
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855A69C
  Paths  get=0x01041090
METHODS:
  RVA=0x0855A3CC  token=0x6000462  System.Void .ctor()
  RVA=0x0855A344  token=0x6000463  System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask other)
  RVA=0x08559518  token=0x6000464  Google.Protobuf.WellKnownTypes.FieldMask Clone()
  RVA=0x08559578  token=0x6000466  System.Boolean Equals(System.Object other)
  RVA=0x085595DC  token=0x6000467  System.Boolean Equals(Google.Protobuf.WellKnownTypes.FieldMask other)
  RVA=0x0517BB20  token=0x6000468  System.Int32 GetHashCode()
  RVA=0x0855A114  token=0x6000469  System.String ToString()
  RVA=0x03D47770  token=0x600046A  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0855A5F8  token=0x600046B  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08559484  token=0x600046C  System.Int32 CalculateSize()
  RVA=0x08559B88  token=0x600046D  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other)
  RVA=0x03D47500  token=0x600046E  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855A528  token=0x600046F  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08559DC8  token=0x6000470  System.String ToJson(System.Collections.Generic.IList<System.String> paths, System.Boolean diagnosticOnly)
  RVA=0x08559D78  token=0x6000471  System.String ToDiagnosticString()
  RVA=0x08559658  token=0x6000472  Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value)
  RVA=-1  // generic def  token=0x6000473  Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value)
  RVA=-1  // generic def  token=0x6000474  Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable(System.Collections.Generic.IEnumerable<System.String> paths)
  RVA=-1  // generic def  token=0x6000475  Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Int32[] fieldNumbers)
  RVA=-1  // generic def  token=0x6000476  Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Collections.Generic.IEnumerable<System.Int32> fieldNumbers)
  RVA=0x085598F0  token=0x6000477  System.Boolean IsPathValid(System.String input)
  RVA=-1  // generic def  token=0x6000478  System.Boolean IsValid(Google.Protobuf.WellKnownTypes.FieldMask fieldMask)
  RVA=0x08559964  token=0x6000479  System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask)
  RVA=-1  // generic def  token=0x600047A  System.Boolean IsValid(System.String path)
  RVA=0x08559AD4  token=0x600047B  System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String path)
  RVA=0x08559D10  token=0x600047C  Google.Protobuf.WellKnownTypes.FieldMask Normalize()
  RVA=0x0855A160  token=0x600047D  Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks)
  RVA=0x08559714  token=0x600047E  Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask)
  RVA=0x08559C00  token=0x600047F  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options)
  RVA=0x08559C9C  token=0x6000480  System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination)
  RVA=0x0855A208  token=0x6000481  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.SourceContextReflection
TYPE:  static class
TOKEN: 0x2000074
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x0855E3A0
METHODS:
  RVA=0x0855E048  token=0x600048E  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.SourceContext
TYPE:  sealed class
TOKEN: 0x2000075
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FileNameFieldNumber  // const
  private           System.String                   fileName_  // 0x18
PROPERTIES:
  Parser  get=0x0855E7D8
  Descriptor  get=0x0855E778
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855E8A4
  FileName  get=0x01041090  set=0x0855E8E4
METHODS:
  RVA=0x0855E738  token=0x6000492  System.Void .ctor()
  RVA=0x0855E6E0  token=0x6000493  System.Void .ctor(Google.Protobuf.WellKnownTypes.SourceContext other)
  RVA=0x0855E46C  token=0x6000494  Google.Protobuf.WellKnownTypes.SourceContext Clone()
  RVA=0x0855E4CC  token=0x6000497  System.Boolean Equals(System.Object other)
  RVA=0x05188EA8  token=0x6000498  System.Boolean Equals(Google.Protobuf.WellKnownTypes.SourceContext other)
  RVA=0x05188F60  token=0x6000499  System.Int32 GetHashCode()
  RVA=0x0855E590  token=0x600049A  System.String ToString()
  RVA=0x03D47770  token=0x600049B  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0518932C  token=0x600049C  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855E3F0  token=0x600049D  System.Int32 CalculateSize()
  RVA=0x0855E530  token=0x600049E  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other)
  RVA=0x03D47500  token=0x600049F  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855E828  token=0x60004A0  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0855E5DC  token=0x60004A1  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.StructReflection
TYPE:  static class
TOKEN: 0x2000077
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x0855F0BC
METHODS:
  RVA=0x0855E94C  token=0x60004A6  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.NullValue
TYPE:  sealed struct
TOKEN: 0x2000078
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.NullValueNullValue  // const
METHODS:
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Struct
TYPE:  sealed class
TOKEN: 0x2000079
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    FieldsFieldNumber  // const
  private   static readonly Google.Protobuf.Collections.MapField.Codec<System.String,Google.Protobuf.WellKnownTypes.Value>_map_fields_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value>fields_  // 0x18
PROPERTIES:
  Parser  get=0x0855F6F4
  Descriptor  get=0x0855F694
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855F8B8
  Fields  get=0x01041090
METHODS:
  RVA=0x0855F61C  token=0x60004AA  System.Void .ctor()
  RVA=0x0855F594  token=0x60004AB  System.Void .ctor(Google.Protobuf.WellKnownTypes.Struct other)
  RVA=0x0855F1A0  token=0x60004AC  Google.Protobuf.WellKnownTypes.Struct Clone()
  RVA=0x0855F200  token=0x60004AE  System.Boolean Equals(System.Object other)
  RVA=0x0855F264  token=0x60004AF  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Struct other)
  RVA=0x0517BB20  token=0x60004B0  System.Int32 GetHashCode()
  RVA=0x0855F358  token=0x60004B1  System.String ToString()
  RVA=0x03D47770  token=0x60004B2  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0855F814  token=0x60004B3  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855F10C  token=0x60004B4  System.Int32 CalculateSize()
  RVA=0x0855F2E0  token=0x60004B5  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other)
  RVA=0x03D47500  token=0x60004B6  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855F744  token=0x60004B7  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0855F3A4  token=0x60004B8  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Value
TYPE:  sealed class
TOKEN: 0x200007B
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NullValueFieldNumber  // const
  public    static  System.Int32                    NumberValueFieldNumber  // const
  public    static  System.Int32                    StringValueFieldNumber  // const
  public    static  System.Int32                    BoolValueFieldNumber  // const
  public    static  System.Int32                    StructValueFieldNumber  // const
  public    static  System.Int32                    ListValueFieldNumber  // const
  private           System.Object                   kind_  // 0x18
  private           Google.Protobuf.WellKnownTypes.Value.KindOneofCasekindCase_  // 0x20
PROPERTIES:
  Parser  get=0x085654B4
  Descriptor  get=0x0856536C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08565924
  NullValue  get=0x08565420  set=0x085659F0
  NumberValue  get=0x08565468  set=0x08565A50
  StringValue  get=0x08565504  set=0x08565AB4
  BoolValue  get=0x08565324  set=0x08565964
  StructValue  get=0x08565578  set=0x08565B24
  ListValue  get=0x085653CC  set=0x085659C8
  KindCase  get=0x01003B50
METHODS:
  RVA=0x0350B670  token=0x60004BF  System.Void .ctor()
  RVA=0x085651E8  token=0x60004C0  System.Void .ctor(Google.Protobuf.WellKnownTypes.Value other)
  RVA=0x085647FC  token=0x60004C1  Google.Protobuf.WellKnownTypes.Value Clone()
  RVA=0x051A6FE0  token=0x60004CF  System.Void ClearKind()
  RVA=0x0856485C  token=0x60004D0  System.Boolean Equals(System.Object other)
  RVA=0x085648C0  token=0x60004D1  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Value other)
  RVA=0x08564D5C  token=0x60004D2  System.Int32 GetHashCode()
  RVA=0x08565098  token=0x60004D3  System.String ToString()
  RVA=0x03D47770  token=0x60004D4  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x085657F8  token=0x60004D5  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085646D8  token=0x60004D6  System.Int32 CalculateSize()
  RVA=0x08564EB0  token=0x60004D7  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Value other)
  RVA=0x03D47500  token=0x60004D8  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085655CC  token=0x60004D9  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08564C3C  token=0x60004DA  Google.Protobuf.WellKnownTypes.Value ForString(System.String value)
  RVA=0x08564BDC  token=0x60004DB  Google.Protobuf.WellKnownTypes.Value ForNumber(System.Double value)
  RVA=0x08564A40  token=0x60004DC  Google.Protobuf.WellKnownTypes.Value ForBool(System.Boolean value)
  RVA=0x08564B88  token=0x60004DD  Google.Protobuf.WellKnownTypes.Value ForNull()
  RVA=0x08564AA0  token=0x60004DE  Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values)
  RVA=0x08564CCC  token=0x60004DF  Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value)
  RVA=0x085650E4  token=0x60004E0  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.ListValue
TYPE:  sealed class
TOKEN: 0x200007E
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValuesFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value>_repeated_values_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value>values_  // 0x18
PROPERTIES:
  Parser  get=0x0855AC44
  Descriptor  get=0x0855ABE4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0855AE08
  Values  get=0x01041090
METHODS:
  RVA=0x0855AB6C  token=0x60004E7  System.Void .ctor()
  RVA=0x0855AAE4  token=0x60004E8  System.Void .ctor(Google.Protobuf.WellKnownTypes.ListValue other)
  RVA=0x0855A770  token=0x60004E9  Google.Protobuf.WellKnownTypes.ListValue Clone()
  RVA=0x0855A7D0  token=0x60004EB  System.Boolean Equals(System.Object other)
  RVA=0x0855A834  token=0x60004EC  System.Boolean Equals(Google.Protobuf.WellKnownTypes.ListValue other)
  RVA=0x0517BB20  token=0x60004ED  System.Int32 GetHashCode()
  RVA=0x0855A928  token=0x60004EE  System.String ToString()
  RVA=0x03D47770  token=0x60004EF  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0855AD64  token=0x60004F0  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855A6DC  token=0x60004F1  System.Int32 CalculateSize()
  RVA=0x0855A8B0  token=0x60004F2  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other)
  RVA=0x03D47500  token=0x60004F3  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0855AC94  token=0x60004F4  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0855A974  token=0x60004F5  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TimeExtensions
TYPE:  static class
TOKEN: 0x2000080
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0855F944  token=0x60004F9  Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime)
  RVA=0x0855F990  token=0x60004FA  Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset)
  RVA=0x0855F8F8  token=0x60004FB  Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan)
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TimestampReflection
TYPE:  static class
TOKEN: 0x2000081
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x0855FD5C
METHODS:
  RVA=0x0855F9E4  token=0x60004FD  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Timestamp
TYPE:  sealed class
TOKEN: 0x2000082
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage Google.Protobuf.ICustomDiagnosticMessage System.IComparable`1
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    SecondsFieldNumber  // const
  private           System.Int64                    seconds_  // 0x18
  public    static  System.Int32                    NanosFieldNumber  // const
  private           System.Int32                    nanos_  // 0x20
  private   static readonly System.DateTime                 UnixEpoch  // static @ 0x8
  private   static  System.Int64                    BclSecondsAtUnixEpoch  // const
  private   static  System.Int64                    UnixSecondsAtBclMaxValue  // const
  private   static  System.Int64                    UnixSecondsAtBclMinValue  // const
  private   static  System.Int32                    MaxNanos  // const
PROPERTIES:
  Parser  get=0x08560968
  Descriptor  get=0x085608D4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08560EA8
  Seconds  get=0x01041090  set=0x03D4EC10
  Nanos  get=0x01003B50  set=0x01003B60
METHODS:
  RVA=0x0350B670  token=0x6000501  System.Void .ctor()
  RVA=0x05167AFC  token=0x6000502  System.Void .ctor(Google.Protobuf.WellKnownTypes.Timestamp other)
  RVA=0x0855FE48  token=0x6000503  Google.Protobuf.WellKnownTypes.Timestamp Clone()
  RVA=0x0855FF3C  token=0x6000508  System.Boolean Equals(System.Object other)
  RVA=0x05168418  token=0x6000509  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Timestamp other)
  RVA=0x0516844C  token=0x600050A  System.Int32 GetHashCode()
  RVA=0x08560728  token=0x600050B  System.String ToString()
  RVA=0x03D47770  token=0x600050C  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x05168678  token=0x600050D  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0855FDAC  token=0x600050E  System.Int32 CalculateSize()
  RVA=0x0856019C  token=0x600050F  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other)
  RVA=0x03D47500  token=0x6000510  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x051685E0  token=0x6000511  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08560170  token=0x6000512  System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds)
  RVA=0x08560C04  token=0x6000513  Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs)
  RVA=0x085609B8  token=0x6000514  Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  RVA=0x08560D50  token=0x6000515  Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs)
  RVA=0x08560338  token=0x6000516  System.DateTime ToDateTime()
  RVA=0x085602C0  token=0x6000517  System.DateTimeOffset ToDateTimeOffset()
  RVA=0x08560008  token=0x6000518  Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime)
  RVA=0x0855FFA0  token=0x6000519  Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset)
  RVA=0x08560234  token=0x600051A  Google.Protobuf.WellKnownTypes.Timestamp Normalize(System.Int64 seconds, System.Int32 nanoseconds)
  RVA=0x085604B8  token=0x600051B  System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly)
  RVA=0x0855FEA8  token=0x600051C  System.Int32 CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other)
  RVA=0x08560BE4  token=0x600051D  System.Boolean op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560B48  token=0x600051E  System.Boolean op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560BC0  token=0x600051F  System.Boolean op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560B24  token=0x6000520  System.Boolean op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560B08  token=0x6000521  System.Boolean op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560B6C  token=0x6000522  System.Boolean op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b)
  RVA=0x08560460  token=0x6000523  System.String ToDiagnosticString()
  RVA=0x08560774  token=0x6000524  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.TypeReflection
TYPE:  static class
TOKEN: 0x2000084
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
PROPERTIES:
  Descriptor  get=0x08561C7C
METHODS:
  RVA=0x08560EE8  token=0x6000529  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Syntax
TYPE:  sealed struct
TOKEN: 0x2000085
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Google.Protobuf.WellKnownTypes.SyntaxProto2  // const
  public    static  Google.Protobuf.WellKnownTypes.SyntaxProto3  // const
METHODS:
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Type
TYPE:  sealed class
TOKEN: 0x2000086
SIZE:  0x48
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    FieldsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field>_repeated_fields_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field>fields_  // 0x20
  public    static  System.Int32                    OneofsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<System.String>_repeated_oneofs_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<System.String>oneofs_  // 0x28
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x30
  public    static  System.Int32                    SourceContextFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x38
  public    static  System.Int32                    SyntaxFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x40
PROPERTIES:
  Parser  get=0x08578D70
  Descriptor  get=0x08578D10
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08579168
  Name  get=0x01041090  set=0x085791A8
  Fields  get=0x03D4EB40
  Oneofs  get=0x03D4EAC0
  Options  get=0x01003830
  SourceContext  get=0x03D4E2A0  set=0x0388FF30
  Syntax  get=0x03D4ED80  set=0x03D4EDB0
METHODS:
  RVA=0x08578AB0  token=0x600052D  System.Void .ctor()
  RVA=0x08578BDC  token=0x600052E  System.Void .ctor(Google.Protobuf.WellKnownTypes.Type other)
  RVA=0x08578444  token=0x600052F  Google.Protobuf.WellKnownTypes.Type Clone()
  RVA=0x085785B0  token=0x6000539  System.Boolean Equals(System.Object other)
  RVA=0x085784A4  token=0x600053A  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Type other)
  RVA=0x08578614  token=0x600053B  System.Int32 GetHashCode()
  RVA=0x08578858  token=0x600053C  System.String ToString()
  RVA=0x03D47770  token=0x600053D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08578FE0  token=0x600053E  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085782AC  token=0x600053F  System.Int32 CalculateSize()
  RVA=0x085786F4  token=0x6000540  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Type other)
  RVA=0x03D47500  token=0x6000541  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08578DC0  token=0x6000542  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085788A4  token=0x6000543  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Field
TYPE:  sealed class
TOKEN: 0x2000088
SIZE:  0x58
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    KindFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Field.Types.Kindkind_  // 0x18
  public    static  System.Int32                    CardinalityFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Field.Types.Cardinalitycardinality_  // 0x1c
  public    static  System.Int32                    NumberFieldNumber  // const
  private           System.Int32                    number_  // 0x20
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x28
  public    static  System.Int32                    TypeUrlFieldNumber  // const
  private           System.String                   typeUrl_  // 0x30
  public    static  System.Int32                    OneofIndexFieldNumber  // const
  private           System.Int32                    oneofIndex_  // 0x38
  public    static  System.Int32                    PackedFieldNumber  // const
  private           System.Boolean                  packed_  // 0x3c
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x40
  public    static  System.Int32                    JsonNameFieldNumber  // const
  private           System.String                   jsonName_  // 0x48
  public    static  System.Int32                    DefaultValueFieldNumber  // const
  private           System.String                   defaultValue_  // 0x50
PROPERTIES:
  Parser  get=0x08573204
  Descriptor  get=0x085731A4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08573668
  Kind  get=0x020D1AC0  set=0x03D4E9C0
  Cardinality  get=0x03D4EBB0  set=0x03D4EBC0
  Number  get=0x01003B50  set=0x01003B60
  Name  get=0x03D4EAC0  set=0x08573778
  TypeUrl  get=0x01003830  set=0x085737E0
  OneofIndex  get=0x03D4EC30  set=0x03D4ECB0
  Packed  get=0x03D4F460  set=0x03D4F470
  Options  get=0x03D4E2B0
  JsonName  get=0x03D4EA70  set=0x08573710
  DefaultValue  get=0x03D4EAF0  set=0x085736A8
METHODS:
  RVA=0x085730D0  token=0x600054A  System.Void .ctor()
  RVA=0x08572FE0  token=0x600054B  System.Void .ctor(Google.Protobuf.WellKnownTypes.Field other)
  RVA=0x085729F8  token=0x600054C  Google.Protobuf.WellKnownTypes.Field Clone()
  RVA=0x08572B64  token=0x6000560  System.Boolean Equals(System.Object other)
  RVA=0x08572A58  token=0x6000561  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Field other)
  RVA=0x08572BC8  token=0x6000562  System.Int32 GetHashCode()
  RVA=0x08572E24  token=0x6000563  System.String ToString()
  RVA=0x03D47770  token=0x6000564  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x08573468  token=0x6000565  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085727E0  token=0x6000566  System.Int32 CalculateSize()
  RVA=0x08572CF0  token=0x6000567  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Field other)
  RVA=0x03D47500  token=0x6000568  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08573254  token=0x6000569  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08572E70  token=0x600056A  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Enum
TYPE:  sealed class
TOKEN: 0x200008D
SIZE:  0x40
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    EnumvalueFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue>_repeated_enumvalue_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue>enumvalue_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
  public    static  System.Int32                    SourceContextFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.SourceContextsourceContext_  // 0x30
  public    static  System.Int32                    SyntaxFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Syntaxsyntax_  // 0x38
PROPERTIES:
  Parser  get=0x0856FBB4
  Descriptor  get=0x0856FB54
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0856FF20
  Name  get=0x01041090  set=0x0856FF60
  Enumvalue  get=0x03D4EB40
  Options  get=0x03D4EAC0
  SourceContext  get=0x01003830  set=0x04270470
  Syntax  get=0x03D4EC30  set=0x03D4ECB0
METHODS:
  RVA=0x0856F970  token=0x6000571  System.Void .ctor()
  RVA=0x0856FA50  token=0x6000572  System.Void .ctor(Google.Protobuf.WellKnownTypes.Enum other)
  RVA=0x0856F3B0  token=0x6000573  Google.Protobuf.WellKnownTypes.Enum Clone()
  RVA=0x0856F410  token=0x600057C  System.Boolean Equals(System.Object other)
  RVA=0x0856F474  token=0x600057D  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Enum other)
  RVA=0x0856F554  token=0x600057E  System.Int32 GetHashCode()
  RVA=0x0856F74C  token=0x600057F  System.String ToString()
  RVA=0x03D47770  token=0x6000580  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0856FDD4  token=0x6000581  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0856F244  token=0x6000582  System.Int32 CalculateSize()
  RVA=0x0856F610  token=0x6000583  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other)
  RVA=0x03D47500  token=0x6000584  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0856FC04  token=0x6000585  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0856F798  token=0x6000586  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.EnumValue
TYPE:  sealed class
TOKEN: 0x200008F
SIZE:  0x30
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    NumberFieldNumber  // const
  private           System.Int32                    number_  // 0x20
  public    static  System.Int32                    OptionsFieldNumber  // const
  private   static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option>_repeated_options_codec  // static @ 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option>options_  // 0x28
PROPERTIES:
  Parser  get=0x0856EF34
  Descriptor  get=0x0856EED4
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0856F19C
  Name  get=0x01041090  set=0x0856F1DC
  Number  get=0x01003B50  set=0x01003B60
  Options  get=0x03D4EAC0
METHODS:
  RVA=0x0856EE3C  token=0x600058D  System.Void .ctor()
  RVA=0x0856ED9C  token=0x600058E  System.Void .ctor(Google.Protobuf.WellKnownTypes.EnumValue other)
  RVA=0x0856E9E0  token=0x600058F  Google.Protobuf.WellKnownTypes.EnumValue Clone()
  RVA=0x0856EA40  token=0x6000595  System.Boolean Equals(System.Object other)
  RVA=0x0856EAA4  token=0x6000596  System.Boolean Equals(Google.Protobuf.WellKnownTypes.EnumValue other)
  RVA=0x051B8B70  token=0x6000597  System.Int32 GetHashCode()
  RVA=0x0856EBE0  token=0x6000598  System.String ToString()
  RVA=0x03D47770  token=0x6000599  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0856F0A8  token=0x600059A  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0856E8E4  token=0x600059B  System.Int32 CalculateSize()
  RVA=0x0856EB3C  token=0x600059C  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other)
  RVA=0x03D47500  token=0x600059D  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0856EF84  token=0x600059E  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0856EC2C  token=0x600059F  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Option
TYPE:  sealed class
TOKEN: 0x2000091
SIZE:  0x28
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    NameFieldNumber  // const
  private           System.String                   name_  // 0x18
  public    static  System.Int32                    ValueFieldNumber  // const
  private           Google.Protobuf.WellKnownTypes.Anyvalue_  // 0x20
PROPERTIES:
  Parser  get=0x08577480
  Descriptor  get=0x08577420
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085775C4
  Name  get=0x01041090  set=0x08577604
  Value  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x085773E0  token=0x60005A6  System.Void .ctor()
  RVA=0x08577364  token=0x60005A7  System.Void .ctor(Google.Protobuf.WellKnownTypes.Option other)
  RVA=0x08577074  token=0x60005A8  Google.Protobuf.WellKnownTypes.Option Clone()
  RVA=0x085770D4  token=0x60005AD  System.Boolean Equals(System.Object other)
  RVA=0x051B076C  token=0x60005AE  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Option other)
  RVA=0x051B07D4  token=0x60005AF  System.Int32 GetHashCode()
  RVA=0x08577214  token=0x60005B0  System.String ToString()
  RVA=0x03D47770  token=0x60005B1  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x051B0C24  token=0x60005B2  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08576FC8  token=0x60005B3  System.Int32 CalculateSize()
  RVA=0x08577138  token=0x60005B4  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Option other)
  RVA=0x03D47500  token=0x60005B5  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x085774D0  token=0x60005B6  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08577260  token=0x60005B7  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.WrappersReflection
TYPE:  static class
TOKEN: 0x2000093
SIZE:  0x10
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // static @ 0x0
  private   static  System.Int32                    WrapperValueFieldNumber  // const
PROPERTIES:
  Descriptor  get=0x0857B2F4
METHODS:
  RVA=0x0857A790  token=0x60005BC  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.DoubleValue
TYPE:  sealed class
TOKEN: 0x2000094
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.Double                   value_  // 0x18
PROPERTIES:
  Parser  get=0x0856D8F8
  Descriptor  get=0x0856D898
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0856D948
  Value  get=0x03D4EBD0  set=0x03D4EBE0
METHODS:
  RVA=0x0350B670  token=0x60005C0  System.Void .ctor()
  RVA=0x0517A59C  token=0x60005C1  System.Void .ctor(Google.Protobuf.WellKnownTypes.DoubleValue other)
  RVA=0x0856D564  token=0x60005C2  Google.Protobuf.WellKnownTypes.DoubleValue Clone()
  RVA=0x0856D650  token=0x60005C5  System.Boolean Equals(System.Object other)
  RVA=0x0856D5C4  token=0x60005C6  System.Boolean Equals(Google.Protobuf.WellKnownTypes.DoubleValue other)
  RVA=0x0856D6B4  token=0x60005C7  System.Int32 GetHashCode()
  RVA=0x0856D748  token=0x60005C8  System.String ToString()
  RVA=0x03D47770  token=0x60005C9  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x053CFAC8  token=0x60005CA  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x053CF694  token=0x60005CB  System.Int32 CalculateSize()
  RVA=0x053CF8B4  token=0x60005CC  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other)
  RVA=0x03D47500  token=0x60005CD  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x053CFA54  token=0x60005CE  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0856D794  token=0x60005CF  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.FloatValue
TYPE:  sealed class
TOKEN: 0x2000096
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.Single                   value_  // 0x18
PROPERTIES:
  Parser  get=0x08575FF0
  Descriptor  get=0x08575F90
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08576040
  Value  get=0x03D4EBF0  set=0x03D4EC00
METHODS:
  RVA=0x0350B670  token=0x60005D6  System.Void .ctor()
  RVA=0x051AA354  token=0x60005D7  System.Void .ctor(Google.Protobuf.WellKnownTypes.FloatValue other)
  RVA=0x08575C58  token=0x60005D8  Google.Protobuf.WellKnownTypes.FloatValue Clone()
  RVA=0x08575CB8  token=0x60005DB  System.Boolean Equals(System.Object other)
  RVA=0x08575D1C  token=0x60005DC  System.Boolean Equals(Google.Protobuf.WellKnownTypes.FloatValue other)
  RVA=0x08575DAC  token=0x60005DD  System.Int32 GetHashCode()
  RVA=0x08575E40  token=0x60005DE  System.String ToString()
  RVA=0x03D47770  token=0x60005DF  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x053EFF04  token=0x60005E0  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x053EFAD0  token=0x60005E1  System.Int32 CalculateSize()
  RVA=0x053EFCF4  token=0x60005E2  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other)
  RVA=0x03D47500  token=0x60005E3  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x053EFE90  token=0x60005E4  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08575E8C  token=0x60005E5  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Int64Value
TYPE:  sealed class
TOKEN: 0x2000098
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.Int64                    value_  // 0x18
PROPERTIES:
  Parser  get=0x085766D4
  Descriptor  get=0x08576674
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08576724
  Value  get=0x01041090  set=0x03D4EC10
METHODS:
  RVA=0x0350B670  token=0x60005EC  System.Void .ctor()
  RVA=0x0517A59C  token=0x60005ED  System.Void .ctor(Google.Protobuf.WellKnownTypes.Int64Value other)
  RVA=0x08576460  token=0x60005EE  Google.Protobuf.WellKnownTypes.Int64Value Clone()
  RVA=0x085764C0  token=0x60005F1  System.Boolean Equals(System.Object other)
  RVA=0x0517A39C  token=0x60005F2  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int64Value other)
  RVA=0x0517A3C8  token=0x60005F3  System.Int32 GetHashCode()
  RVA=0x08576524  token=0x60005F4  System.String ToString()
  RVA=0x03D47770  token=0x60005F5  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0517A6FC  token=0x60005F6  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x085763F0  token=0x60005F7  System.Int32 CalculateSize()
  RVA=0x0517A40C  token=0x60005F8  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other)
  RVA=0x03D47500  token=0x60005F9  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0517A688  token=0x60005FA  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08576570  token=0x60005FB  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.UInt64Value
TYPE:  sealed class
TOKEN: 0x200009A
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.UInt64                   value_  // 0x18
PROPERTIES:
  Parser  get=0x0857A700
  Descriptor  get=0x0857A6A0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857A750
  Value  get=0x01041090  set=0x03D4EC10
METHODS:
  RVA=0x0350B670  token=0x6000602  System.Void .ctor()
  RVA=0x0517A59C  token=0x6000603  System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt64Value other)
  RVA=0x0857A48C  token=0x6000604  Google.Protobuf.WellKnownTypes.UInt64Value Clone()
  RVA=0x0857A4EC  token=0x6000607  System.Boolean Equals(System.Object other)
  RVA=0x0517A39C  token=0x6000608  System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt64Value other)
  RVA=0x0518F37C  token=0x6000609  System.Int32 GetHashCode()
  RVA=0x0857A550  token=0x600060A  System.String ToString()
  RVA=0x03D47770  token=0x600060B  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0518F5C0  token=0x600060C  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857A41C  token=0x600060D  System.Int32 CalculateSize()
  RVA=0x0517A40C  token=0x600060E  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other)
  RVA=0x03D47500  token=0x600060F  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0517A688  token=0x6000610  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0857A59C  token=0x6000611  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.Int32Value
TYPE:  sealed class
TOKEN: 0x200009C
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.Int32                    value_  // 0x18
PROPERTIES:
  Parser  get=0x08576360
  Descriptor  get=0x08576300
  pb::Google.Protobuf.IMessage.Descriptor  get=0x085763B0
  Value  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x0350B670  token=0x6000618  System.Void .ctor()
  RVA=0x051AA354  token=0x6000619  System.Void .ctor(Google.Protobuf.WellKnownTypes.Int32Value other)
  RVA=0x085760EC  token=0x600061A  Google.Protobuf.WellKnownTypes.Int32Value Clone()
  RVA=0x0857614C  token=0x600061D  System.Boolean Equals(System.Object other)
  RVA=0x051AA14C  token=0x600061E  System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int32Value other)
  RVA=0x051AA1DC  token=0x600061F  System.Int32 GetHashCode()
  RVA=0x085761B0  token=0x6000620  System.String ToString()
  RVA=0x03D47770  token=0x6000621  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x051AA450  token=0x6000622  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08576080  token=0x6000623  System.Int32 CalculateSize()
  RVA=0x051AA214  token=0x6000624  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other)
  RVA=0x03D47500  token=0x6000625  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x051AA3E0  token=0x6000626  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085761FC  token=0x6000627  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.UInt32Value
TYPE:  sealed class
TOKEN: 0x200009E
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.UInt32                   value_  // 0x18
PROPERTIES:
  Parser  get=0x0857A38C
  Descriptor  get=0x0857A32C
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0857A3DC
  Value  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x0350B670  token=0x600062E  System.Void .ctor()
  RVA=0x051AA354  token=0x600062F  System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt32Value other)
  RVA=0x0857A118  token=0x6000630  Google.Protobuf.WellKnownTypes.UInt32Value Clone()
  RVA=0x0857A178  token=0x6000633  System.Boolean Equals(System.Object other)
  RVA=0x051AA14C  token=0x6000634  System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt32Value other)
  RVA=0x051AA1DC  token=0x6000635  System.Int32 GetHashCode()
  RVA=0x0857A1DC  token=0x6000636  System.String ToString()
  RVA=0x03D47770  token=0x6000637  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0527B0C4  token=0x6000638  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0857A0AC  token=0x6000639  System.Int32 CalculateSize()
  RVA=0x051AA214  token=0x600063A  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other)
  RVA=0x03D47500  token=0x600063B  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x051AA3E0  token=0x600063C  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x0857A228  token=0x600063D  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.BoolValue
TYPE:  sealed class
TOKEN: 0x20000A0
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.Boolean                  value_  // 0x18
PROPERTIES:
  Parser  get=0x08567B10
  Descriptor  get=0x08567AB0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08567B60
  Value  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x0350B670  token=0x6000644  System.Void .ctor()
  RVA=0x0521BA50  token=0x6000645  System.Void .ctor(Google.Protobuf.WellKnownTypes.BoolValue other)
  RVA=0x08567834  token=0x6000646  Google.Protobuf.WellKnownTypes.BoolValue Clone()
  RVA=0x08567894  token=0x6000649  System.Boolean Equals(System.Object other)
  RVA=0x0521B818  token=0x600064A  System.Boolean Equals(Google.Protobuf.WellKnownTypes.BoolValue other)
  RVA=0x085678F8  token=0x600064B  System.Int32 GetHashCode()
  RVA=0x08567960  token=0x600064C  System.String ToString()
  RVA=0x03D47770  token=0x600064D  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0521BB48  token=0x600064E  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x0521B788  token=0x600064F  System.Int32 CalculateSize()
  RVA=0x0521B910  token=0x6000650  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other)
  RVA=0x03D47500  token=0x6000651  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x0521BADC  token=0x6000652  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x085679AC  token=0x6000653  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.StringValue
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           System.String                   value_  // 0x18
PROPERTIES:
  Parser  get=0x08578138
  Descriptor  get=0x085780D8
  pb::Google.Protobuf.IMessage.Descriptor  get=0x08578204
  Value  get=0x01041090  set=0x08578244
METHODS:
  RVA=0x08578040  token=0x600065A  System.Void .ctor()
  RVA=0x08578080  token=0x600065B  System.Void .ctor(Google.Protobuf.WellKnownTypes.StringValue other)
  RVA=0x08577DCC  token=0x600065C  Google.Protobuf.WellKnownTypes.StringValue Clone()
  RVA=0x08577E2C  token=0x600065F  System.Boolean Equals(System.Object other)
  RVA=0x05188EA8  token=0x6000660  System.Boolean Equals(Google.Protobuf.WellKnownTypes.StringValue other)
  RVA=0x05188F60  token=0x6000661  System.Int32 GetHashCode()
  RVA=0x08577EF0  token=0x6000662  System.String ToString()
  RVA=0x03D47770  token=0x6000663  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x0518932C  token=0x6000664  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08577D50  token=0x6000665  System.Int32 CalculateSize()
  RVA=0x08577E90  token=0x6000666  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other)
  RVA=0x03D47500  token=0x6000667  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08578188  token=0x6000668  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08577F3C  token=0x6000669  System.Void .cctor()
END_CLASS

CLASS: Google.Protobuf.WellKnownTypes.BytesValue
TYPE:  sealed class
TOKEN: 0x20000A4
SIZE:  0x20
IMPLEMENTS: Google.Protobuf.IMessage`1 Google.Protobuf.IMessage System.IEquatable`1 Google.Protobuf.IDeepCloneable`1 Google.Protobuf.IBufferMessage
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue>_parser  // static @ 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValueFieldNumber  // const
  private           Google.Protobuf.ByteString      value_  // 0x18
PROPERTIES:
  Parser  get=0x08568040
  Descriptor  get=0x08567FE0
  pb::Google.Protobuf.IMessage.Descriptor  get=0x0856810C
  Value  get=0x01041090  set=0x0856814C
METHODS:
  RVA=0x08567F8C  token=0x6000670  System.Void .ctor()
  RVA=0x08567F34  token=0x6000671  System.Void .ctor(Google.Protobuf.WellKnownTypes.BytesValue other)
  RVA=0x08567C24  token=0x6000672  Google.Protobuf.WellKnownTypes.BytesValue Clone()
  RVA=0x08567D18  token=0x6000675  System.Boolean Equals(System.Object other)
  RVA=0x08567C84  token=0x6000676  System.Boolean Equals(Google.Protobuf.WellKnownTypes.BytesValue other)
  RVA=0x051C30A0  token=0x6000677  System.Int32 GetHashCode()
  RVA=0x08567DE4  token=0x6000678  System.String ToString()
  RVA=0x03D47770  token=0x6000679  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  RVA=0x051C33E8  token=0x600067A  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  RVA=0x08567BA0  token=0x600067B  System.Int32 CalculateSize()
  RVA=0x08567D7C  token=0x600067C  System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other)
  RVA=0x03D47500  token=0x600067D  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  RVA=0x08568090  token=0x600067E  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  RVA=0x08567E30  token=0x600067F  System.Void .cctor()
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes<MemberTypes>k__BackingField  // 0x10
PROPERTIES:
  MemberTypes  get=0x03D4E340
METHODS:
  RVA=0x010410F0  token=0x6000001  System.Void .ctor(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes memberTypes)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNone  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicParameterlessConstructor  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicConstructors  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicConstructors  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicMethods  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicMethods  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicFields  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicFields  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicNestedTypes  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicNestedTypes  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicProperties  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicProperties  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesPublicEvents  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesNonPublicEvents  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesInterfaces  // const
  public    static  System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypesAll  // const
METHODS:
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.String                   <Message>k__BackingField  // 0x10
  private           System.String                   <Url>k__BackingField  // 0x18
PROPERTIES:
  Message  get=0x020B7B20
  Url  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0426FEE0  token=0x6000003  System.Void .ctor(System.String message)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessageAttribute
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x40
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.String                   <Category>k__BackingField  // 0x10
  private   readonly System.String                   <CheckId>k__BackingField  // 0x18
  private           System.String                   <Scope>k__BackingField  // 0x20
  private           System.String                   <Target>k__BackingField  // 0x28
  private           System.String                   <MessageId>k__BackingField  // 0x30
  private           System.String                   <Justification>k__BackingField  // 0x38
PROPERTIES:
  Category  get=0x020B7B20
  CheckId  get=0x01041090
  Scope  get=0x03D4EB40  set=0x04271930
  Target  get=0x03D4EAC0  set=0x02C92F10
  MessageId  get=0x01003830  set=0x04270470
  Justification  get=0x03D4E2A0  set=0x0388FF30
METHODS:
  RVA=0x02676770  token=0x6000007  System.Void .ctor(System.String category, System.String checkId)
END_CLASS

