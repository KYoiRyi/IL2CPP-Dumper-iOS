// ========================================================
// Dumped by @desirepro
// Assembly: Google.Protobuf.dll
// Classes:  318
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000009  // size: 0x50
    public sealed struct <FromStreamAsyncCore>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Google.Protobuf.ByteString> <>t__builder;  // 0x18
        public System.IO.Stream stream;  // 0x30
        public System.Threading.CancellationToken cancellationToken;  // 0x38
        private System.IO.MemoryStream <memoryStream>5__2;  // 0x40
        private System.Runtime.CompilerServices.TaskAwaiter <>u__1;  // 0x48

        // Methods
        // RVA: 0x0855372C  token: 0x6000035
        private virtual System.Void MoveNext() { }
        // RVA: 0x08553A98  token: 0x6000036
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200000C  // size: 0x90
    public sealed class OutOfSpaceException : System.IO.IOException
    {
        // Methods
        // RVA: 0x085528A4  token: 0x60000B7
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public sealed class ExtensionComparer : System.Collections.Generic.IEqualityComparer`1
    {
        // Fields
        private static Google.Protobuf.ExtensionRegistry.ExtensionComparer Instance;  // static @ 0x0

        // Methods
        // RVA: 0x08540FA4  token: 0x60000D4
        public virtual System.Boolean Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b) { }
        // RVA: 0x08541078  token: 0x60000D5
        public virtual System.Int32 GetHashCode(Google.Protobuf.Extension a) { }
        // RVA: 0x0350B670  token: 0x60000D6
        public System.Void .ctor() { }
        // RVA: 0x08541100  token: 0x60000D7
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.ExtensionRegistry.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>,Google.Protobuf.ObjectIntPair<System.Type>> <>9__3_0;  // static @ 0x8
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension>,Google.Protobuf.Extension> <>9__3_1;  // static @ 0x10

        // Methods
        // RVA: 0x08554394  token: 0x60000D8
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60000D9
        public System.Void .ctor() { }
        // RVA: 0x08554070  token: 0x60000DA
        private Google.Protobuf.ObjectIntPair<System.Type> <.ctor>b__3_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> k) { }
        // RVA: 0x085540B0  token: 0x60000DB
        private Google.Protobuf.Extension <.ctor>b__3_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> v) { }

    }

    // TypeToken: 0x2000015
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.ExtensionSet.<>c<TTarget> <>9;  // static @ 0x0
        public static System.Func<Google.Protobuf.IExtensionValue,System.Boolean> <>9__8_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60000F0
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x60000F1
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60000F2
        private System.Boolean <IsInitialized>b__8_0(Google.Protobuf.IExtensionValue v) { }

    }

    // TypeToken: 0x200001B
    public sealed class <>c__DisplayClass3_0`1
    {
        // Fields
        public Google.Protobuf.FieldCodec<T> nestedCoded;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600013A
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600013B
        private System.Nullable<T> <GetReader>b__0(Google.Protobuf.ParseContext& ctx) { }

    }

    // TypeToken: 0x200001A  // size: 0x10
    public static class WrapperCodecs
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Object> Codecs;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Object> Readers;  // static @ 0x8

        // Methods
        // RVA: -1  // generic def  token: 0x6000134
        private static Google.Protobuf.FieldCodec<T> GetCodec() { }
        // RVA: -1  // generic def  token: 0x6000135
        private static Google.Protobuf.ValueReader<System.Nullable<T>> GetReader() { }
        // RVA: -1  // generic def  token: 0x6000136
        private static T Read(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // generic def  token: 0x6000137
        private static System.Void Write(Google.Protobuf.WriteContext& ctx, T value, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // generic def  token: 0x6000138
        private static System.Int32 CalculateSize(T value, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: 0x0855445C  token: 0x6000139
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c <>9;  // static @ 0x0
        public static Google.Protobuf.ValueReader<System.String> <>9__16_0;  // static @ 0x8
        public static Google.Protobuf.ValueWriter<System.String> <>9__16_1;  // static @ 0x10
        public static Google.Protobuf.ValueReader<Google.Protobuf.ByteString> <>9__17_0;  // static @ 0x18
        public static Google.Protobuf.ValueWriter<Google.Protobuf.ByteString> <>9__17_1;  // static @ 0x20
        public static Google.Protobuf.ValueReader<System.Boolean> <>9__18_0;  // static @ 0x28
        public static Google.Protobuf.ValueWriter<System.Boolean> <>9__18_1;  // static @ 0x30
        public static Google.Protobuf.ValueReader<System.Int32> <>9__19_0;  // static @ 0x38
        public static Google.Protobuf.ValueWriter<System.Int32> <>9__19_1;  // static @ 0x40
        public static Google.Protobuf.ValueReader<System.Int32> <>9__20_0;  // static @ 0x48
        public static Google.Protobuf.ValueWriter<System.Int32> <>9__20_1;  // static @ 0x50
        public static Google.Protobuf.ValueReader<System.UInt32> <>9__21_0;  // static @ 0x58
        public static Google.Protobuf.ValueWriter<System.UInt32> <>9__21_1;  // static @ 0x60
        public static Google.Protobuf.ValueReader<System.Int32> <>9__22_0;  // static @ 0x68
        public static Google.Protobuf.ValueWriter<System.Int32> <>9__22_1;  // static @ 0x70
        public static Google.Protobuf.ValueReader<System.UInt32> <>9__23_0;  // static @ 0x78
        public static Google.Protobuf.ValueWriter<System.UInt32> <>9__23_1;  // static @ 0x80
        public static Google.Protobuf.ValueReader<System.Int64> <>9__24_0;  // static @ 0x88
        public static Google.Protobuf.ValueWriter<System.Int64> <>9__24_1;  // static @ 0x90
        public static Google.Protobuf.ValueReader<System.Int64> <>9__25_0;  // static @ 0x98
        public static Google.Protobuf.ValueWriter<System.Int64> <>9__25_1;  // static @ 0xa0
        public static Google.Protobuf.ValueReader<System.UInt64> <>9__26_0;  // static @ 0xa8
        public static Google.Protobuf.ValueWriter<System.UInt64> <>9__26_1;  // static @ 0xb0
        public static Google.Protobuf.ValueReader<System.Int64> <>9__27_0;  // static @ 0xb8
        public static Google.Protobuf.ValueWriter<System.Int64> <>9__27_1;  // static @ 0xc0
        public static Google.Protobuf.ValueReader<System.UInt64> <>9__28_0;  // static @ 0xc8
        public static Google.Protobuf.ValueWriter<System.UInt64> <>9__28_1;  // static @ 0xd0
        public static Google.Protobuf.ValueReader<System.Single> <>9__29_0;  // static @ 0xd8
        public static Google.Protobuf.ValueWriter<System.Single> <>9__29_1;  // static @ 0xe0
        public static Google.Protobuf.ValueReader<System.Double> <>9__30_0;  // static @ 0xe8
        public static Google.Protobuf.ValueWriter<System.Double> <>9__30_1;  // static @ 0xf0

        // Methods
        // RVA: 0x03D11570  token: 0x600013C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600013D
        public System.Void .ctor() { }
        // RVA: 0x023C3EC0  token: 0x600013E
        private System.String <ForString>b__16_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x03874840  token: 0x600013F
        private System.Void <ForString>b__16_1(Google.Protobuf.WriteContext& ctx, System.String value) { }
        // RVA: 0x08553B0C  token: 0x6000140
        private Google.Protobuf.ByteString <ForBytes>b__17_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553B18  token: 0x6000141
        private System.Void <ForBytes>b__17_1(Google.Protobuf.WriteContext& ctx, Google.Protobuf.ByteString value) { }
        // RVA: 0x023C4CD0  token: 0x6000142
        private System.Boolean <ForBool>b__18_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553AF8  token: 0x6000143
        private System.Void <ForBool>b__18_1(Google.Protobuf.WriteContext& ctx, System.Boolean value) { }
        // RVA: 0x023C0C70  token: 0x6000144
        private System.Int32 <ForInt32>b__19_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553BB0  token: 0x6000145
        private System.Void <ForInt32>b__19_1(Google.Protobuf.WriteContext& output, System.Int32 value) { }
        // RVA: 0x08553BE4  token: 0x6000146
        private System.Int32 <ForSInt32>b__20_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553C08  token: 0x6000147
        private System.Void <ForSInt32>b__20_1(Google.Protobuf.WriteContext& output, System.Int32 value) { }
        // RVA: 0x08553B4C  token: 0x6000148
        private System.UInt32 <ForFixed32>b__21_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553B5C  token: 0x6000149
        private System.Void <ForFixed32>b__21_1(Google.Protobuf.WriteContext& output, System.UInt32 value) { }
        // RVA: 0x08553B4C  token: 0x600014A
        private System.Int32 <ForSFixed32>b__22_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553BC0  token: 0x600014B
        private System.Void <ForSFixed32>b__22_1(Google.Protobuf.WriteContext& output, System.Int32 value) { }
        // RVA: 0x023C2480  token: 0x600014C
        private System.UInt32 <ForUInt32>b__23_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553C54  token: 0x600014D
        private System.Void <ForUInt32>b__23_1(Google.Protobuf.WriteContext& output, System.UInt32 value) { }
        // RVA: 0x023C4620  token: 0x600014E
        private System.Int64 <ForInt64>b__24_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x03D42A70  token: 0x600014F
        private System.Void <ForInt64>b__24_1(Google.Protobuf.WriteContext& output, System.Int64 value) { }
        // RVA: 0x08553C18  token: 0x6000150
        private System.Int64 <ForSInt64>b__25_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553C40  token: 0x6000151
        private System.Void <ForSInt64>b__25_1(Google.Protobuf.WriteContext& output, System.Int64 value) { }
        // RVA: 0x08553B6C  token: 0x6000152
        private System.UInt64 <ForFixed64>b__26_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553B7C  token: 0x6000153
        private System.Void <ForFixed64>b__26_1(Google.Protobuf.WriteContext& output, System.UInt64 value) { }
        // RVA: 0x08553B6C  token: 0x6000154
        private System.Int64 <ForSFixed64>b__27_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553BD0  token: 0x6000155
        private System.Void <ForSFixed64>b__27_1(Google.Protobuf.WriteContext& output, System.Int64 value) { }
        // RVA: 0x023C5470  token: 0x6000156
        private System.UInt64 <ForUInt64>b__28_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553C64  token: 0x6000157
        private System.Void <ForUInt64>b__28_1(Google.Protobuf.WriteContext& output, System.UInt64 value) { }
        // RVA: 0x08553B90  token: 0x6000158
        private System.Single <ForFloat>b__29_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553BA0  token: 0x6000159
        private System.Void <ForFloat>b__29_1(Google.Protobuf.WriteContext& output, System.Single value) { }
        // RVA: 0x08553B2C  token: 0x600015A
        private System.Double <ForDouble>b__30_0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08553B3C  token: 0x600015B
        private System.Void <ForDouble>b__30_1(Google.Protobuf.WriteContext& output, System.Double value) { }

    }

    // TypeToken: 0x200001D
    public sealed class <>c__DisplayClass31_0`1
    {
        // Fields
        public System.Func<System.Int32,T> fromInt32;  // 0x0
        public System.Func<T,System.Int32> toInt32;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600015C
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600015D
        private T <ForEnum>b__0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x600015E
        private System.Void <ForEnum>b__1(Google.Protobuf.WriteContext& output, T value) { }
        // RVA: -1  // not resolved  token: 0x600015F
        private System.Int32 <ForEnum>b__2(T value) { }

    }

    // TypeToken: 0x200001E
    public sealed class <>c__DisplayClass32_0`1
    {
        // Fields
        public Google.Protobuf.MessageParser<T> parser;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000160
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000161
        private T <ForMessage>b__0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x6000162
        private System.Void <ForMessage>b__2(Google.Protobuf.ParseContext& ctx, T& v) { }

    }

    // TypeToken: 0x200001F
    public sealed class <>c__32`1
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c__32<T> <>9;  // static @ 0x0
        public static Google.Protobuf.ValueWriter<T> <>9__32_1;  // static @ 0x0
        public static Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__32_3;  // static @ 0x0
        public static System.Func<T,System.Int32> <>9__32_4;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000163
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000164
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000165
        private System.Void <ForMessage>b__32_1(Google.Protobuf.WriteContext& output, T value) { }
        // RVA: -1  // not resolved  token: 0x6000166
        private System.Boolean <ForMessage>b__32_3(T& v, T v2) { }
        // RVA: -1  // not resolved  token: 0x6000167
        private System.Int32 <ForMessage>b__32_4(T message) { }

    }

    // TypeToken: 0x2000020
    public sealed class <>c__DisplayClass33_0`1
    {
        // Fields
        public Google.Protobuf.MessageParser<T> parser;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000168
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000169
        private T <ForGroup>b__0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x600016A
        private System.Void <ForGroup>b__2(Google.Protobuf.ParseContext& ctx, T& v) { }

    }

    // TypeToken: 0x2000021
    public sealed class <>c__33`1
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c__33<T> <>9;  // static @ 0x0
        public static Google.Protobuf.ValueWriter<T> <>9__33_1;  // static @ 0x0
        public static Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__33_3;  // static @ 0x0
        public static System.Func<T,System.Int32> <>9__33_4;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600016B
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x600016C
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600016D
        private System.Void <ForGroup>b__33_1(Google.Protobuf.WriteContext& output, T value) { }
        // RVA: -1  // not resolved  token: 0x600016E
        private System.Boolean <ForGroup>b__33_3(T& v, T v2) { }
        // RVA: -1  // not resolved  token: 0x600016F
        private System.Int32 <ForGroup>b__33_4(T message) { }

    }

    // TypeToken: 0x2000022
    public sealed class <>c__DisplayClass34_0`1
    {
        // Fields
        public Google.Protobuf.FieldCodec<T> nestedCodec;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000170
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000171
        private T <ForClassWrapper>b__0(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x6000172
        private System.Void <ForClassWrapper>b__1(Google.Protobuf.WriteContext& output, T value) { }
        // RVA: -1  // not resolved  token: 0x6000173
        private System.Void <ForClassWrapper>b__2(Google.Protobuf.ParseContext& ctx, T& v) { }
        // RVA: -1  // not resolved  token: 0x6000174
        private System.Int32 <ForClassWrapper>b__4(T value) { }

    }

    // TypeToken: 0x2000023
    public sealed class <>c__34`1
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c__34<T> <>9;  // static @ 0x0
        public static Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__34_3;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000175
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000176
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000177
        private System.Boolean <ForClassWrapper>b__34_3(T& v, T v2) { }

    }

    // TypeToken: 0x2000024
    public sealed class <>c__DisplayClass35_0`1
    {
        // Fields
        public Google.Protobuf.FieldCodec<T> nestedCodec;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000178
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000179
        private System.Void <ForStructWrapper>b__0(Google.Protobuf.WriteContext& output, System.Nullable<T> value) { }
        // RVA: -1  // not resolved  token: 0x600017A
        private System.Void <ForStructWrapper>b__1(Google.Protobuf.ParseContext& ctx, System.Nullable<T>& v) { }
        // RVA: -1  // not resolved  token: 0x600017B
        private System.Int32 <ForStructWrapper>b__3(System.Nullable<T> value) { }

    }

    // TypeToken: 0x2000025
    public sealed class <>c__35`1
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c__35<T> <>9;  // static @ 0x0
        public static Google.Protobuf.FieldCodec.ValuesMerger<System.Nullable<T>> <>9__35_2;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600017C
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x600017D
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600017E
        private System.Boolean <ForStructWrapper>b__35_2(System.Nullable<T>& v, System.Nullable<T> v2) { }

    }

    // TypeToken: 0x2000029
    public sealed class InputMerger : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x600019E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x600019F
        public virtual System.Void Invoke(Google.Protobuf.ParseContext& ctx, T& value) { }
        // RVA: -1  // runtime  token: 0x60001A0
        public virtual System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x60001A1
        public virtual System.Void EndInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002A
    public sealed class ValuesMerger : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x60001A2
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x60001A3
        public virtual System.Boolean Invoke(T& value, T other) { }
        // RVA: -1  // runtime  token: 0x60001A4
        public virtual System.IAsyncResult BeginInvoke(T& value, T other, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x60001A5
        public virtual System.Boolean EndInvoke(T& value, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002B
    public sealed class <>c__DisplayClass38_0
    {
        // Fields
        public System.Int32 fixedSize;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001A6
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001A7
        private System.Int32 <.ctor>b__0(T _) { }

    }

    // TypeToken: 0x200002C
    public sealed class <>c__DisplayClass39_0
    {
        // Fields
        public Google.Protobuf.ValueReader<T> reader;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001A8
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001A9
        private System.Void <.ctor>b__0(Google.Protobuf.ParseContext& ctx, T& v) { }

    }

    // TypeToken: 0x200002D
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.FieldCodec.<>c<T> <>9;  // static @ 0x0
        public static Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__39_1;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001AA
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x60001AB
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001AC
        private System.Boolean <.ctor>b__39_1(T& v, T v2) { }

    }

    // TypeToken: 0x200002F  // size: 0x18
    public sealed class Node
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node> <Children>k__BackingField;  // 0x10

        // Properties
        System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node> Children { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x08552240  token: 0x60001B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0x28
    public sealed class Settings
    {
        // Fields
        private static readonly Google.Protobuf.JsonFormatter.Settings <Default>k__BackingField;  // static @ 0x0
        private readonly System.Boolean <FormatDefaultValues>k__BackingField;  // 0x10
        private readonly Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;  // 0x18
        private readonly System.Boolean <FormatEnumsAsIntegers>k__BackingField;  // 0x20
        private readonly System.Boolean <PreserveProtoFieldNames>k__BackingField;  // 0x21

        // Properties
        Google.Protobuf.JsonFormatter.Settings Default { get; /* RVA: 0x0855368C */ }
        System.Boolean FormatDefaultValues { get; /* RVA: 0x011797F0 */ }
        Google.Protobuf.Reflection.TypeRegistry TypeRegistry { get; /* RVA: 0x01041090 */ }
        System.Boolean FormatEnumsAsIntegers { get; /* RVA: 0x03D4EF90 */ }
        System.Boolean PreserveProtoFieldNames { get; /* RVA: 0x03D4F070 */ }

        // Methods
        // RVA: 0x085533A8  token: 0x60001F6
        private static System.Void .cctor() { }
        // RVA: 0x08553490  token: 0x60001FB
        public System.Void .ctor(System.Boolean formatDefaultValues) { }
        // RVA: 0x0855355C  token: 0x60001FC
        public System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        // RVA: 0x0855357C  token: 0x60001FD
        private System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean formatEnumsAsIntegers, System.Boolean preserveProtoFieldNames) { }
        // RVA: 0x08552F70  token: 0x60001FE
        public Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(System.Boolean formatDefaultValues) { }
        // RVA: 0x08553254  token: 0x60001FF
        public Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        // RVA: 0x0855300C  token: 0x6000200
        public Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(System.Boolean formatEnumsAsIntegers) { }
        // RVA: 0x08553130  token: 0x6000201
        public Google.Protobuf.JsonFormatter.Settings WithPreserveProtoFieldNames(System.Boolean preserveProtoFieldNames) { }

    }

    // TypeToken: 0x200003C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.JsonFormatter.OriginalEnumValueHelper.<>c <>9;  // static @ 0x0
        public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__2_0;  // static @ 0x8
        public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__2_1;  // static @ 0x10
        public static System.Func<System.Reflection.FieldInfo,System.Object> <>9__2_2;  // static @ 0x18
        public static System.Func<System.Reflection.FieldInfo,System.String> <>9__2_3;  // static @ 0x20

        // Methods
        // RVA: 0x085543F8  token: 0x6000205
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000206
        public System.Void .ctor() { }
        // RVA: 0x08553C78  token: 0x6000207
        private System.Boolean <GetNameMapping>b__2_0(System.Reflection.FieldInfo f) { }
        // RVA: 0x08553C98  token: 0x6000208
        private System.Boolean <GetNameMapping>b__2_1(System.Reflection.FieldInfo f) { }
        // RVA: 0x08553CFC  token: 0x6000209
        private System.Object <GetNameMapping>b__2_2(System.Reflection.FieldInfo f) { }
        // RVA: 0x08553D1C  token: 0x600020A
        private System.String <GetNameMapping>b__2_3(System.Reflection.FieldInfo f) { }

    }

    // TypeToken: 0x200003B  // size: 0x10
    public static class OriginalEnumValueHelper
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Object,System.String>> dictionaries;  // static @ 0x0

        // Methods
        // RVA: 0x08552614  token: 0x6000202
        private static System.String GetOriginalName(System.Object value) { }
        // RVA: 0x085522B8  token: 0x6000203
        private static System.Collections.Generic.Dictionary<System.Object,System.String> GetNameMapping(System.Type enumType) { }
        // RVA: 0x08552818  token: 0x6000204
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x28
    public sealed class Settings
    {
        // Fields
        private static readonly Google.Protobuf.JsonParser.Settings <Default>k__BackingField;  // static @ 0x0
        private readonly System.Int32 <RecursionLimit>k__BackingField;  // 0x10
        private readonly Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;  // 0x18
        private readonly System.Boolean <IgnoreUnknownFields>k__BackingField;  // 0x20

        // Properties
        Google.Protobuf.JsonParser.Settings Default { get; /* RVA: 0x085536DC */ }
        System.Int32 RecursionLimit { get; /* RVA: 0x03D4E340 */ }
        Google.Protobuf.Reflection.TypeRegistry TypeRegistry { get; /* RVA: 0x01041090 */ }
        System.Boolean IgnoreUnknownFields { get; /* RVA: 0x03D4EF90 */ }

        // Methods
        // RVA: 0x0855341C  token: 0x600022C
        private static System.Void .cctor() { }
        // RVA: 0x08553604  token: 0x6000230
        private System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean ignoreUnknownFields) { }
        // RVA: 0x08553504  token: 0x6000231
        public System.Void .ctor(System.Int32 recursionLimit) { }
        // RVA: 0x085534E8  token: 0x6000232
        public System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        // RVA: 0x085530A8  token: 0x6000233
        public Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(System.Boolean ignoreUnknownFields) { }
        // RVA: 0x085531CC  token: 0x6000234
        public Google.Protobuf.JsonParser.Settings WithRecursionLimit(System.Int32 recursionLimit) { }
        // RVA: 0x085532F0  token: 0x6000235
        public Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }

    }

    // TypeToken: 0x200003F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.JsonParser.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08554330  token: 0x6000236
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000237
        public System.Void .ctor() { }
        // RVA: 0x08553D98  token: 0x6000238
        private System.Boolean <.cctor>b__41_0(Google.Protobuf.Reflection.EnumDescriptor ed) { }
        // RVA: 0x08553E0C  token: 0x6000239
        private System.Void <.cctor>b__41_1(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08553E74  token: 0x600023A
        private System.Void <.cctor>b__41_2(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08553EDC  token: 0x600023B
        private System.Void <.cctor>b__41_3(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08553F0C  token: 0x600023C
        private System.Void <.cctor>b__41_4(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08553FA8  token: 0x600023D
        private System.Void <.cctor>b__41_5(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08553FD8  token: 0x600023E
        private System.Void <.cctor>b__41_6(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08554008  token: 0x600023F
        private System.Void <.cctor>b__41_7(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }

    }

    // TypeToken: 0x2000041  // size: 0x14
    public sealed struct TokenType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.JsonToken.TokenType Null;  // const
        public static Google.Protobuf.JsonToken.TokenType False;  // const
        public static Google.Protobuf.JsonToken.TokenType True;  // const
        public static Google.Protobuf.JsonToken.TokenType StringValue;  // const
        public static Google.Protobuf.JsonToken.TokenType Number;  // const
        public static Google.Protobuf.JsonToken.TokenType Name;  // const
        public static Google.Protobuf.JsonToken.TokenType StartObject;  // const
        public static Google.Protobuf.JsonToken.TokenType EndObject;  // const
        public static Google.Protobuf.JsonToken.TokenType StartArray;  // const
        public static Google.Protobuf.JsonToken.TokenType EndArray;  // const
        public static Google.Protobuf.JsonToken.TokenType EndDocument;  // const

    }

    // TypeToken: 0x2000043  // size: 0x38
    public class JsonReplayTokenizer : Google.Protobuf.JsonTokenizer
    {
        // Fields
        private readonly System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens;  // 0x20
        private readonly Google.Protobuf.JsonTokenizer nextTokenizer;  // 0x28
        private System.Int32 nextTokenIndex;  // 0x30

        // Methods
        // RVA: 0x0854E740  token: 0x600025D
        private System.Void .ctor(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer) { }
        // RVA: 0x0854E6B0  token: 0x600025E
        protected virtual Google.Protobuf.JsonToken NextImpl() { }

    }

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct ContainerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Document;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Object;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Array;  // const

    }

    // TypeToken: 0x2000046  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State StartOfDocument;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ExpectedEndOfDocument;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ReaderExhausted;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectStart;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectBeforeColon;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterColon;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterProperty;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterComma;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayStart;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayAfterValue;  // const
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayAfterComma;  // const

    }

    // TypeToken: 0x2000047  // size: 0x20
    public class PushBackReader
    {
        // Fields
        private readonly System.IO.TextReader reader;  // 0x10
        private System.Nullable<System.Char> nextChar;  // 0x18

        // Methods
        // RVA: 0x0426FEE0  token: 0x600026E
        private System.Void .ctor(System.IO.TextReader reader) { }
        // RVA: 0x08552EF4  token: 0x600026F
        private System.Nullable<System.Char> Read() { }
        // RVA: 0x08552E64  token: 0x6000270
        private System.Char ReadOrFail(System.String messageOnFailure) { }
        // RVA: 0x08552DB0  token: 0x6000271
        private System.Void PushBack(System.Char c) { }
        // RVA: 0x08552D50  token: 0x6000272
        private Google.Protobuf.InvalidJsonException CreateException(System.String message) { }

    }

    // TypeToken: 0x2000044  // size: 0x38
    public sealed class JsonTextTokenizer : Google.Protobuf.JsonTokenizer
    {
        // Fields
        private static readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ValueStates;  // static @ 0x0
        private readonly System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;  // 0x20
        private readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReader reader;  // 0x28
        private Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State state;  // 0x30

        // Methods
        // RVA: 0x0854FF5C  token: 0x600025F
        private System.Void .ctor(System.IO.TextReader reader) { }
        // RVA: 0x0854E994  token: 0x6000260
        protected virtual Google.Protobuf.JsonToken NextImpl() { }
        // RVA: 0x0854FE84  token: 0x6000261
        private System.Void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, System.String errorPrefix) { }
        // RVA: 0x0854FA24  token: 0x6000262
        private System.String ReadString() { }
        // RVA: 0x0854F18C  token: 0x6000263
        private System.Char ReadEscapedCharacter() { }
        // RVA: 0x0854FC5C  token: 0x6000264
        private System.Char ReadUnicodeEscape() { }
        // RVA: 0x0854E840  token: 0x6000265
        private System.Void ConsumeLiteral(System.String text) { }
        // RVA: 0x0854F6A8  token: 0x6000266
        private System.Double ReadNumber(System.Char initialCharacter) { }
        // RVA: 0x0854F578  token: 0x6000267
        private System.Nullable<System.Char> ReadInt(System.Text.StringBuilder builder) { }
        // RVA: 0x0854F4E4  token: 0x6000268
        private System.Nullable<System.Char> ReadFrac(System.Text.StringBuilder builder) { }
        // RVA: 0x0854F2F8  token: 0x6000269
        private System.Nullable<System.Char> ReadExp(System.Text.StringBuilder builder) { }
        // RVA: 0x0854E768  token: 0x600026A
        private System.Nullable<System.Char> ConsumeDigits(System.Text.StringBuilder builder, System.Int32& count) { }
        // RVA: 0x0854FD94  token: 0x600026B
        private System.Void ValidateAndModifyStateForValue(System.String errorPrefix) { }
        // RVA: 0x0854F054  token: 0x600026C
        private System.Void PopContainer() { }
        // RVA: 0x0854FF20  token: 0x600026D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x18
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public Google.Protobuf.IMessage message;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000294
        public System.Void .ctor() { }
        // RVA: 0x085540E8  token: 0x6000295
        private System.Boolean <IsInitialized>b__0(Google.Protobuf.Reflection.FieldDescriptor f) { }

    }

    // TypeToken: 0x200004D
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public System.Func<T> factory;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002B4
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60002B5
        private Google.Protobuf.IMessage <.ctor>b__0() { }

    }

    // TypeToken: 0x200005A  // size: 0x14
    public sealed struct WireType
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static Google.Protobuf.WireFormat.WireType Varint;  // const
        public static Google.Protobuf.WireFormat.WireType Fixed64;  // const
        public static Google.Protobuf.WireFormat.WireType LengthDelimited;  // const
        public static Google.Protobuf.WireFormat.WireType StartGroup;  // const
        public static Google.Protobuf.WireFormat.WireType EndGroup;  // const
        public static Google.Protobuf.WireFormat.WireType Fixed32;  // const

    }

    // TypeToken: 0x2000062  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Any.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085623A0  token: 0x60003C6
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60003C7
        public System.Void .ctor() { }
        // RVA: 0x08561E8C  token: 0x60003C8
        private Google.Protobuf.WellKnownTypes.Any <.cctor>b__40_0() { }

    }

    // TypeToken: 0x2000065  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Api.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08562148  token: 0x60003E7
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60003E8
        public System.Void .ctor() { }
        // RVA: 0x08561FA4  token: 0x60003E9
        private Google.Protobuf.WellKnownTypes.Api <.cctor>b__57_0() { }

    }

    // TypeToken: 0x2000067  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Method.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08562404  token: 0x6000408
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000409
        public System.Void .ctor() { }
        // RVA: 0x08561FF4  token: 0x600040A
        private Google.Protobuf.WellKnownTypes.Method <.cctor>b__57_0() { }

    }

    // TypeToken: 0x2000069  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Mixin.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085620E4  token: 0x6000420
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000421
        public System.Void .ctor() { }
        // RVA: 0x08561E3C  token: 0x6000422
        private Google.Protobuf.WellKnownTypes.Mixin <.cctor>b__32_0() { }

    }

    // TypeToken: 0x200006C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Duration.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0856233C  token: 0x6000444
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000445
        public System.Void .ctor() { }
        // RVA: 0x08561F2C  token: 0x6000446
        private Google.Protobuf.WellKnownTypes.Duration <.cctor>b__48_0() { }

    }

    // TypeToken: 0x200006F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Empty.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08562210  token: 0x600045A
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600045B
        public System.Void .ctor() { }
        // RVA: 0x08561D10  token: 0x600045C
        private Google.Protobuf.WellKnownTypes.Empty <.cctor>b__22_0() { }

    }

    // TypeToken: 0x2000072  // size: 0x18
    public sealed class MergeOptions
    {
        // Fields
        private System.Boolean <ReplaceMessageFields>k__BackingField;  // 0x10
        private System.Boolean <ReplaceRepeatedFields>k__BackingField;  // 0x11
        private System.Boolean <ReplacePrimitiveFields>k__BackingField;  // 0x12

        // Properties
        System.Boolean ReplaceMessageFields { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.Boolean ReplaceRepeatedFields { get; /* RVA: 0x03D510E0 */ set; /* RVA: 0x03D510F0 */ }
        System.Boolean ReplacePrimitiveFields { get; /* RVA: 0x03D519E0 */ set; /* RVA: 0x03D6B770 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000488
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000073  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.FieldMask.<>c <>9;  // static @ 0x0
        public static System.Func<System.String,System.Boolean> <>9__29_0;  // static @ 0x8

        // Methods
        // RVA: 0x08562468  token: 0x6000489
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600048A
        public System.Void .ctor() { }
        // RVA: 0x08561CCC  token: 0x600048B
        private System.Boolean <ToJson>b__29_0(System.String p) { }
        // RVA: 0x08561EDC  token: 0x600048C
        private Google.Protobuf.WellKnownTypes.FieldMask <.cctor>b__47_0() { }

    }

    // TypeToken: 0x2000076  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.SourceContext.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085621AC  token: 0x60004A2
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60004A3
        public System.Void .ctor() { }
        // RVA: 0x08561DEC  token: 0x60004A4
        private Google.Protobuf.WellKnownTypes.SourceContext <.cctor>b__27_0() { }

    }

    // TypeToken: 0x200007A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Struct.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085622D8  token: 0x60004B9
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60004BA
        public System.Void .ctor() { }
        // RVA: 0x08561D4C  token: 0x60004BB
        private Google.Protobuf.WellKnownTypes.Struct <.cctor>b__27_0() { }

    }

    // TypeToken: 0x200007C  // size: 0x14
    public sealed struct KindOneofCase
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase None;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase NullValue;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase NumberValue;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase StringValue;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase BoolValue;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase StructValue;  // const
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase ListValue;  // const

    }

    // TypeToken: 0x200007D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Value.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08562080  token: 0x60004E1
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60004E2
        public System.Void .ctor() { }
        // RVA: 0x08562044  token: 0x60004E3
        private Google.Protobuf.WellKnownTypes.Value <.cctor>b__58_0() { }

    }

    // TypeToken: 0x200007F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.ListValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085624CC  token: 0x60004F6
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60004F7
        public System.Void .ctor() { }
        // RVA: 0x08561D9C  token: 0x60004F8
        private Google.Protobuf.WellKnownTypes.ListValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x2000083  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Timestamp.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08562274  token: 0x6000525
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000526
        public System.Void .ctor() { }
        // RVA: 0x08561F68  token: 0x6000527
        private Google.Protobuf.WellKnownTypes.Timestamp <.cctor>b__55_0() { }

    }

    // TypeToken: 0x2000087  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Type.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085798DC  token: 0x6000544
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000545
        public System.Void .ctor() { }
        // RVA: 0x085796D4  token: 0x6000546
        private Google.Protobuf.WellKnownTypes.Type <.cctor>b__52_0() { }

    }

    // TypeToken: 0x200008A  // size: 0x14
    public sealed struct Kind
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUnknown;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeDouble;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFloat;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeInt64;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUint64;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeInt32;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFixed64;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFixed32;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeBool;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeString;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeGroup;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeMessage;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeBytes;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUint32;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeEnum;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSfixed32;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSfixed64;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSint32;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSint64;  // const

    }

    // TypeToken: 0x200008B  // size: 0x14
    public sealed struct Cardinality
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Unknown;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Optional;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Required;  // const
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Repeated;  // const

    }

    // TypeToken: 0x2000089  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x200008C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Field.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579E54  token: 0x600056B
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600056C
        public System.Void .ctor() { }
        // RVA: 0x08579724  token: 0x600056D
        private Google.Protobuf.WellKnownTypes.Field <.cctor>b__73_0() { }

    }

    // TypeToken: 0x200008E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Enum.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579EB8  token: 0x6000587
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000588
        public System.Void .ctor() { }
        // RVA: 0x08579684  token: 0x6000589
        private Google.Protobuf.WellKnownTypes.Enum <.cctor>b__47_0() { }

    }

    // TypeToken: 0x2000090  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.EnumValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579D8C  token: 0x60005A0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005A1
        public System.Void .ctor() { }
        // RVA: 0x0857956C  token: 0x60005A2
        private Google.Protobuf.WellKnownTypes.EnumValue <.cctor>b__37_0() { }

    }

    // TypeToken: 0x2000092  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Option.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579AD0  token: 0x60005B8
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005B9
        public System.Void .ctor() { }
        // RVA: 0x085794E0  token: 0x60005BA
        private Google.Protobuf.WellKnownTypes.Option <.cctor>b__32_0() { }

    }

    // TypeToken: 0x2000095  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.DoubleValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579DF0  token: 0x60005D0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005D1
        public System.Void .ctor() { }
        // RVA: 0x085794A4  token: 0x60005D2
        private Google.Protobuf.WellKnownTypes.DoubleValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x2000097  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.FloatValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579D28  token: 0x60005E6
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005E7
        public System.Void .ctor() { }
        // RVA: 0x0857942C  token: 0x60005E8
        private Google.Protobuf.WellKnownTypes.FloatValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x2000099  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Int64Value.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579CC4  token: 0x60005FC
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60005FD
        public System.Void .ctor() { }
        // RVA: 0x08579468  token: 0x60005FE
        private Google.Protobuf.WellKnownTypes.Int64Value <.cctor>b__27_0() { }

    }

    // TypeToken: 0x200009B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.UInt64Value.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579C60  token: 0x6000612
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000613
        public System.Void .ctor() { }
        // RVA: 0x085792D8  token: 0x6000614
        private Google.Protobuf.WellKnownTypes.UInt64Value <.cctor>b__27_0() { }

    }

    // TypeToken: 0x200009D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.Int32Value.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579A6C  token: 0x6000628
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000629
        public System.Void .ctor() { }
        // RVA: 0x085793F0  token: 0x600062A
        private Google.Protobuf.WellKnownTypes.Int32Value <.cctor>b__27_0() { }

    }

    // TypeToken: 0x200009F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.UInt32Value.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579A08  token: 0x600063E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600063F
        public System.Void .ctor() { }
        // RVA: 0x0857929C  token: 0x6000640
        private Google.Protobuf.WellKnownTypes.UInt32Value <.cctor>b__27_0() { }

    }

    // TypeToken: 0x20000A1  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.BoolValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0857A048  token: 0x6000654
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000655
        public System.Void .ctor() { }
        // RVA: 0x08579314  token: 0x6000656
        private Google.Protobuf.WellKnownTypes.BoolValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x20000A3  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.StringValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579F1C  token: 0x600066A
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600066B
        public System.Void .ctor() { }
        // RVA: 0x085793A0  token: 0x600066C
        private Google.Protobuf.WellKnownTypes.StringValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x20000A5  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.WellKnownTypes.BytesValue.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579FE4  token: 0x6000680
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000681
        public System.Void .ctor() { }
        // RVA: 0x0857924C  token: 0x6000682
        private Google.Protobuf.WellKnownTypes.BytesValue <.cctor>b__27_0() { }

    }

    // TypeToken: 0x20000A7
    public sealed class <>c__19`1
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.CustomOptions.<>c__19<T> <>9;  // static @ 0x0
        public static System.Func<T,Google.Protobuf.ByteString> <>9__19_0;  // static @ 0x0
        public static System.Func<T,Google.Protobuf.ByteString,T> <>9__19_1;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000696
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000697
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000698
        private Google.Protobuf.ByteString <TryGetMessage>b__19_0(T v) { }
        // RVA: -1  // not resolved  token: 0x6000699
        private T <TryGetMessage>b__19_1(T t, Google.Protobuf.ByteString b) { }

    }

    // TypeToken: 0x20000AA  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FileDescriptorSet.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579F80  token: 0x60006AE
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60006AF
        public System.Void .ctor() { }
        // RVA: 0x08579350  token: 0x60006B0
        private Google.Protobuf.Reflection.FileDescriptorSet <.cctor>b__27_0() { }

    }

    // TypeToken: 0x20000AC  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FileDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x085799A4  token: 0x60006D9
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60006DA
        public System.Void .ctor() { }
        // RVA: 0x085797C4  token: 0x60006DB
        private Google.Protobuf.Reflection.FileDescriptorProto <.cctor>b__94_0() { }

    }

    // TypeToken: 0x20000B0  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579B34  token: 0x6000716
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000717
        public System.Void .ctor() { }
        // RVA: 0x08579648  token: 0x6000718
        private Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange <.cctor>b__46_0() { }

    }

    // TypeToken: 0x20000AF  // size: 0x30
    public sealed class ExtensionRange : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 StartFieldNumber;  // const
        private static readonly System.Int32 StartDefaultValue;  // static @ 0x8
        private System.Int32 start_;  // 0x1c
        public static System.Int32 EndFieldNumber;  // const
        private static readonly System.Int32 EndDefaultValue;  // static @ 0xc
        private System.Int32 end_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.ExtensionRangeOptions options_;  // 0x28

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> Parser { get; /* RVA: 0x08570E98 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08570DDC */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08571100 */ }
        System.Int32 Start { get; /* RVA: 0x08570EE8 */ set; /* RVA: 0x03D6BC70 */ }
        System.Boolean HasStart { get; /* RVA: 0x02461A70 */ }
        System.Int32 End { get; /* RVA: 0x08570E3C */ set; /* RVA: 0x03D6BC60 */ }
        System.Boolean HasEnd { get; /* RVA: 0x08570E90 */ }
        Google.Protobuf.Reflection.ExtensionRangeOptions Options { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60006FE
        public System.Void .ctor() { }
        // RVA: 0x08570D68  token: 0x60006FF
        public System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        // RVA: 0x08570944  token: 0x6000700
        public virtual Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone() { }
        // RVA: 0x03D4F650  token: 0x6000704
        public System.Void ClearStart() { }
        // RVA: 0x03D6BC50  token: 0x6000708
        public System.Void ClearEnd() { }
        // RVA: 0x08570A30  token: 0x600070B
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085709A4  token: 0x600070C
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        // RVA: 0x08570A94  token: 0x600070D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08570BF0  token: 0x600070E
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600070F
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08571058  token: 0x6000710
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08570874  token: 0x6000711
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08570B04  token: 0x6000712
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        // RVA: 0x03D47500  token: 0x6000713
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08570F3C  token: 0x6000714
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08570C3C  token: 0x6000715
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000B2  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579814  token: 0x6000732
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000733
        public System.Void .ctor() { }
        // RVA: 0x0857960C  token: 0x6000734
        private Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange <.cctor>b__41_0() { }

    }

    // TypeToken: 0x20000B1  // size: 0x28
    public sealed class ReservedRange : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 StartFieldNumber;  // const
        private static readonly System.Int32 StartDefaultValue;  // static @ 0x8
        private System.Int32 start_;  // 0x1c
        public static System.Int32 EndFieldNumber;  // const
        private static readonly System.Int32 EndDefaultValue;  // static @ 0xc
        private System.Int32 end_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> Parser { get; /* RVA: 0x08577B48 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08577A90 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08577D10 */ }
        System.Int32 Start { get; /* RVA: 0x08577B98 */ set; /* RVA: 0x03D6BC70 */ }
        System.Boolean HasStart { get; /* RVA: 0x02461A70 */ }
        System.Int32 End { get; /* RVA: 0x08577AF4 */ set; /* RVA: 0x03D6BC60 */ }
        System.Boolean HasEnd { get; /* RVA: 0x08570E90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600071C
        public System.Void .ctor() { }
        // RVA: 0x051669EC  token: 0x600071D
        public System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        // RVA: 0x08577718  token: 0x600071E
        public virtual Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone() { }
        // RVA: 0x03D4F650  token: 0x6000722
        public System.Void ClearStart() { }
        // RVA: 0x03D6BC50  token: 0x6000726
        public System.Void ClearEnd() { }
        // RVA: 0x08577778  token: 0x6000727
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085777DC  token: 0x6000728
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        // RVA: 0x08577854  token: 0x6000729
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08577918  token: 0x600072A
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600072B
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08577C88  token: 0x600072C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857766C  token: 0x600072D
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085778AC  token: 0x600072E
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        // RVA: 0x03D47500  token: 0x600072F
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08577BEC  token: 0x6000730
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08577964  token: 0x6000731
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AE  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000B3  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.DescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579878  token: 0x6000735
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000736
        public System.Void .ctor() { }
        // RVA: 0x08579774  token: 0x6000737
        private Google.Protobuf.Reflection.DescriptorProto <.cctor>b__77_0() { }

    }

    // TypeToken: 0x20000B5  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.ExtensionRangeOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579B98  token: 0x6000752
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000753
        public System.Void .ctor() { }
        // RVA: 0x085795BC  token: 0x6000754
        private Google.Protobuf.Reflection.ExtensionRangeOptions <.cctor>b__37_0() { }

    }

    // TypeToken: 0x20000B8  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Double;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Float;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Int64;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Uint64;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Int32;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Fixed64;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Fixed32;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Bool;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type String;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Group;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Message;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Bytes;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Uint32;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Enum;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sfixed32;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sfixed64;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sint32;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sint64;  // const

    }

    // TypeToken: 0x20000B9  // size: 0x14
    public sealed struct Label
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Optional;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Required;  // const
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Repeated;  // const

    }

    // TypeToken: 0x20000B7  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000BA  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FieldDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579BFC  token: 0x6000790
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000791
        public System.Void .ctor() { }
        // RVA: 0x08579210  token: 0x6000792
        private Google.Protobuf.Reflection.FieldDescriptorProto <.cctor>b__119_0() { }

    }

    // TypeToken: 0x20000BC  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.OneofDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x08579940  token: 0x60007AA
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60007AB
        public System.Void .ctor() { }
        // RVA: 0x08579530  token: 0x60007AC
        private Google.Protobuf.Reflection.OneofDescriptorProto <.cctor>b__36_0() { }

    }

    // TypeToken: 0x20000C0  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C1FC  token: 0x60007E0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60007E1
        public System.Void .ctor() { }
        // RVA: 0x0858B8C8  token: 0x60007E2
        private Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange <.cctor>b__41_0() { }

    }

    // TypeToken: 0x20000BF  // size: 0x28
    public sealed class EnumReservedRange : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 StartFieldNumber;  // const
        private static readonly System.Int32 StartDefaultValue;  // static @ 0x8
        private System.Int32 start_;  // 0x1c
        public static System.Int32 EndFieldNumber;  // const
        private static readonly System.Int32 EndDefaultValue;  // static @ 0xc
        private System.Int32 end_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> Parser { get; /* RVA: 0x0857ED08 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857EC54 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857EE34 */ }
        System.Int32 Start { get; /* RVA: 0x0857ED58 */ set; /* RVA: 0x03D6BC70 */ }
        System.Boolean HasStart { get; /* RVA: 0x02461A70 */ }
        System.Int32 End { get; /* RVA: 0x0857ECB4 */ set; /* RVA: 0x03D6BC60 */ }
        System.Boolean HasEnd { get; /* RVA: 0x08570E90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60007CA
        public System.Void .ctor() { }
        // RVA: 0x051669EC  token: 0x60007CB
        public System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        // RVA: 0x0857E8DC  token: 0x60007CC
        public virtual Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone() { }
        // RVA: 0x03D4F650  token: 0x60007D0
        public System.Void ClearStart() { }
        // RVA: 0x03D6BC50  token: 0x60007D4
        public System.Void ClearEnd() { }
        // RVA: 0x0857E93C  token: 0x60007D5
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857E9A0  token: 0x60007D6
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        // RVA: 0x0857EA18  token: 0x60007D7
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857EADC  token: 0x60007D8
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60007D9
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0857EDAC  token: 0x60007DA
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857E830  token: 0x60007DB
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0857EA70  token: 0x60007DC
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        // RVA: 0x03D47500  token: 0x60007DD
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08577BEC  token: 0x60007DE
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0857EB28  token: 0x60007DF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000C1  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.EnumDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BF40  token: 0x60007E3
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60007E4
        public System.Void .ctor() { }
        // RVA: 0x0858B9E0  token: 0x60007E5
        private Google.Protobuf.Reflection.EnumDescriptorProto <.cctor>b__52_0() { }

    }

    // TypeToken: 0x20000C3  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.EnumValueDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C134  token: 0x6000801
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000802
        public System.Void .ctor() { }
        // RVA: 0x0858B904  token: 0x6000803
        private Google.Protobuf.Reflection.EnumValueDescriptorProto <.cctor>b__46_0() { }

    }

    // TypeToken: 0x20000C5  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.ServiceDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C328  token: 0x600081C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600081D
        public System.Void .ctor() { }
        // RVA: 0x0858B83C  token: 0x600081E
        private Google.Protobuf.Reflection.ServiceDescriptorProto <.cctor>b__41_0() { }

    }

    // TypeToken: 0x20000C7  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.MethodDescriptorProto.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BCE8  token: 0x6000846
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000847
        public System.Void .ctor() { }
        // RVA: 0x0858BB70  token: 0x6000848
        private Google.Protobuf.Reflection.MethodDescriptorProto <.cctor>b__73_0() { }

    }

    // TypeToken: 0x20000CA  // size: 0x14
    public sealed struct OptimizeMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode Speed;  // const
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode CodeSize;  // const
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode LiteRuntime;  // const

    }

    // TypeToken: 0x20000C9  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000CB  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FileOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C260  token: 0x60008B3
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60008B4
        public System.Void .ctor() { }
        // RVA: 0x0858B6FC  token: 0x60008B5
        private Google.Protobuf.Reflection.FileOptions <.cctor>b__219_0() { }

    }

    // TypeToken: 0x20000CD  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.MessageOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C06C  token: 0x60008E0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60008E1
        public System.Void .ctor() { }
        // RVA: 0x0858BBAC  token: 0x60008E2
        private Google.Protobuf.Reflection.MessageOptions <.cctor>b__74_0() { }

    }

    // TypeToken: 0x20000D0  // size: 0x14
    public sealed struct CType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType String;  // const
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType Cord;  // const
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType StringPiece;  // const

    }

    // TypeToken: 0x20000D1  // size: 0x14
    public sealed struct JSType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsNormal;  // const
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsString;  // const
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsNumber;  // const

    }

    // TypeToken: 0x20000CF  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000D2  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FieldOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BEDC  token: 0x6000919
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600091A
        public System.Void .ctor() { }
        // RVA: 0x0858B6AC  token: 0x600091B
        private Google.Protobuf.Reflection.FieldOptions <.cctor>b__102_0() { }

    }

    // TypeToken: 0x20000D4  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.OneofOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C2C4  token: 0x6000936
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000937
        public System.Void .ctor() { }
        // RVA: 0x0858B7EC  token: 0x6000938
        private Google.Protobuf.Reflection.OneofOptions <.cctor>b__37_0() { }

    }

    // TypeToken: 0x20000D6  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.EnumOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BDB0  token: 0x600095B
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600095C
        public System.Void .ctor() { }
        // RVA: 0x0858BAD0  token: 0x600095D
        private Google.Protobuf.Reflection.EnumOptions <.cctor>b__56_0() { }

    }

    // TypeToken: 0x20000D8  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.EnumValueOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BE14  token: 0x600097C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600097D
        public System.Void .ctor() { }
        // RVA: 0x0858B990  token: 0x600097E
        private Google.Protobuf.Reflection.EnumValueOptions <.cctor>b__47_0() { }

    }

    // TypeToken: 0x20000DA  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.ServiceOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BE78  token: 0x600099D
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600099E
        public System.Void .ctor() { }
        // RVA: 0x0858B940  token: 0x600099F
        private Google.Protobuf.Reflection.ServiceOptions <.cctor>b__47_0() { }

    }

    // TypeToken: 0x20000DD  // size: 0x14
    public sealed struct IdempotencyLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyUnknown;  // const
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel NoSideEffects;  // const
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel Idempotent;  // const

    }

    // TypeToken: 0x20000DC  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000DE  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.MethodOptions.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C008  token: 0x60009C2
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60009C3
        public System.Void .ctor() { }
        // RVA: 0x0858BB20  token: 0x60009C4
        private Google.Protobuf.Reflection.MethodOptions <.cctor>b__57_0() { }

    }

    // TypeToken: 0x20000E2  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C38C  token: 0x6000A08
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A09
        public System.Void .ctor() { }
        // RVA: 0x0858B88C  token: 0x6000A0A
        private Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart <.cctor>b__41_0() { }

    }

    // TypeToken: 0x20000E1  // size: 0x30
    public sealed class NamePart : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 NamePart_FieldNumber;  // const
        private static readonly System.String NamePart_DefaultValue;  // static @ 0x8
        private System.String namePart_;  // 0x20
        public static System.Int32 IsExtensionFieldNumber;  // const
        private static readonly System.Boolean IsExtensionDefaultValue;  // static @ 0x10
        private System.Boolean isExtension_;  // 0x28

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> Parser { get; /* RVA: 0x08588FA4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08588E9C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08589110 */ }
        System.String NamePart_ { get; /* RVA: 0x08588F50 */ set; /* RVA: 0x08589150 */ }
        System.Boolean HasNamePart_ { get; /* RVA: 0x08571E40 */ }
        System.Boolean IsExtension { get; /* RVA: 0x08588EFC */ set; /* RVA: 0x03D6BF40 */ }
        System.Boolean HasIsExtension { get; /* RVA: 0x02461A70 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60009F2
        public System.Void .ctor() { }
        // RVA: 0x08588E48  token: 0x60009F3
        public System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        // RVA: 0x08588A34  token: 0x60009F4
        public virtual Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone() { }
        // RVA: 0x08571380  token: 0x60009F8
        public System.Void ClearNamePart_() { }
        // RVA: 0x03D4F650  token: 0x60009FC
        public System.Void ClearIsExtension() { }
        // RVA: 0x08588A94  token: 0x60009FD
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08588AF8  token: 0x60009FE
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        // RVA: 0x08588B80  token: 0x60009FF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08588CA0  token: 0x6000A00
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000A01
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08589088  token: 0x6000A02
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085889B0  token: 0x6000A03
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08588C2C  token: 0x6000A04
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        // RVA: 0x03D47500  token: 0x6000A05
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08588FF4  token: 0x6000A06
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08588CEC  token: 0x6000A07
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E0  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000E3  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.UninterpretedOption.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C0D0  token: 0x6000A0B
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A0C
        public System.Void .ctor() { }
        // RVA: 0x0858BBFC  token: 0x6000A0D
        private Google.Protobuf.Reflection.UninterpretedOption <.cctor>b__83_0() { }

    }

    // TypeToken: 0x20000E7  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.SourceCodeInfo.Types.Location.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BD4C  token: 0x6000A3C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A3D
        public System.Void .ctor() { }
        // RVA: 0x0858BA30  token: 0x6000A3E
        private Google.Protobuf.Reflection.SourceCodeInfo.Types.Location <.cctor>b__55_0() { }

    }

    // TypeToken: 0x20000E6  // size: 0x40
    public sealed class Location : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 PathFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_path_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> path_;  // 0x18
        public static System.Int32 SpanFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_span_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> span_;  // 0x20
        public static System.Int32 LeadingCommentsFieldNumber;  // const
        private static readonly System.String LeadingCommentsDefaultValue;  // static @ 0x18
        private System.String leadingComments_;  // 0x28
        public static System.Int32 TrailingCommentsFieldNumber;  // const
        private static readonly System.String TrailingCommentsDefaultValue;  // static @ 0x20
        private System.String trailingComments_;  // 0x30
        public static System.Int32 LeadingDetachedCommentsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_leadingDetachedComments_codec;  // static @ 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> leadingDetachedComments_;  // 0x38

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> Parser { get; /* RVA: 0x08585DB8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08585D04 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085861A8 */ }
        Google.Protobuf.Collections.RepeatedField<System.Int32> Path { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.Collections.RepeatedField<System.Int32> Span { get; /* RVA: 0x03D4EB40 */ }
        System.String LeadingComments { get; /* RVA: 0x08585D64 */ set; /* RVA: 0x085861E8 */ }
        System.Boolean HasLeadingComments { get; /* RVA: 0x05693D38 */ }
        System.String TrailingComments { get; /* RVA: 0x08585E08 */ set; /* RVA: 0x08586250 */ }
        System.Boolean HasTrailingComments { get; /* RVA: 0x085839D0 */ }
        Google.Protobuf.Collections.RepeatedField<System.String> LeadingDetachedComments { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x08585B10  token: 0x6000A23
        public System.Void .ctor() { }
        // RVA: 0x08585C04  token: 0x6000A24
        public System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        // RVA: 0x085854D0  token: 0x6000A25
        public virtual Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone() { }
        // RVA: 0x08254178  token: 0x6000A2B
        public System.Void ClearLeadingComments() { }
        // RVA: 0x05572920  token: 0x6000A2F
        public System.Void ClearTrailingComments() { }
        // RVA: 0x08585530  token: 0x6000A31
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08585594  token: 0x6000A32
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        // RVA: 0x085856CC  token: 0x6000A33
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085858AC  token: 0x6000A34
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000A35
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08586034  token: 0x6000A36
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08585354  token: 0x6000A37
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085857AC  token: 0x6000A38
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        // RVA: 0x03D47500  token: 0x6000A39
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08585E5C  token: 0x6000A3A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085858F8  token: 0x6000A3B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000E8  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.SourceCodeInfo.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858BFA4  token: 0x6000A3F
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A40
        public System.Void .ctor() { }
        // RVA: 0x0858B79C  token: 0x6000A41
        private Google.Protobuf.Reflection.SourceCodeInfo <.cctor>b__28_0() { }

    }

    // TypeToken: 0x20000EC  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C3F0  token: 0x6000A72
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A73
        public System.Void .ctor() { }
        // RVA: 0x0858BA80  token: 0x6000A74
        private Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation <.cctor>b__55_0() { }

    }

    // TypeToken: 0x20000EB  // size: 0x38
    public sealed class Annotation : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 PathFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_path_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> path_;  // 0x20
        public static System.Int32 SourceFileFieldNumber;  // const
        private static readonly System.String SourceFileDefaultValue;  // static @ 0x10
        private System.String sourceFile_;  // 0x28
        public static System.Int32 BeginFieldNumber;  // const
        private static readonly System.Int32 BeginDefaultValue;  // static @ 0x18
        private System.Int32 begin_;  // 0x30
        public static System.Int32 EndFieldNumber;  // const
        private static readonly System.Int32 EndDefaultValue;  // static @ 0x1c
        private System.Int32 end_;  // 0x34

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> Parser { get; /* RVA: 0x0857BD50 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857BC9C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857C06C */ }
        Google.Protobuf.Collections.RepeatedField<System.Int32> Path { get; /* RVA: 0x03D4EB40 */ }
        System.String SourceFile { get; /* RVA: 0x0857BDA0 */ set; /* RVA: 0x0857C0AC */ }
        System.Boolean HasSourceFile { get; /* RVA: 0x05693D38 */ }
        System.Int32 Begin { get; /* RVA: 0x0857BC48 */ set; /* RVA: 0x03D6BD00 */ }
        System.Boolean HasBegin { get; /* RVA: 0x02461A70 */ }
        System.Int32 End { get; /* RVA: 0x0857BCFC */ set; /* RVA: 0x03D6BD10 */ }
        System.Boolean HasEnd { get; /* RVA: 0x08570E90 */ }

        // Methods
        // RVA: 0x0857BBD0  token: 0x6000A57
        public System.Void .ctor() { }
        // RVA: 0x0857BB24  token: 0x6000A58
        public System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        // RVA: 0x0857B620  token: 0x6000A59
        public virtual Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone() { }
        // RVA: 0x08254178  token: 0x6000A5E
        public System.Void ClearSourceFile() { }
        // RVA: 0x03D4F650  token: 0x6000A62
        public System.Void ClearBegin() { }
        // RVA: 0x03D6BC50  token: 0x6000A66
        public System.Void ClearEnd() { }
        // RVA: 0x0857B76C  token: 0x6000A67
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857B680  token: 0x6000A68
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        // RVA: 0x0857B7D0  token: 0x6000A69
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857B934  token: 0x6000A6A
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000A6B
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0857BF44  token: 0x6000A6C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857B4EC  token: 0x6000A6D
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0857B868  token: 0x6000A6E
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        // RVA: 0x03D47500  token: 0x6000A6F
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0857BDF4  token: 0x6000A70
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0857B980  token: 0x6000A71
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000EA  // size: 0x10
    public static class Types
    {
    }

    // TypeToken: 0x20000ED  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.GeneratedCodeInfo.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0858C198  token: 0x6000A75
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000A76
        public System.Void .ctor() { }
        // RVA: 0x0858B74C  token: 0x6000A77
        private Google.Protobuf.Reflection.GeneratedCodeInfo <.cctor>b__28_0() { }

    }

    // TypeToken: 0x20000F2
    public sealed class IndexedConverter`2 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A96
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A97
        public virtual TOutput Invoke(TInput element, System.Int32 index) { }
        // RVA: -1  // runtime  token: 0x6000A98
        public virtual System.IAsyncResult BeginInvoke(TInput element, System.Int32 index, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A99
        public virtual TOutput EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000F5  // size: 0x20
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public Google.Protobuf.Reflection.FileDescriptor file;  // 0x10
        public Google.Protobuf.Reflection.EnumDescriptor <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000AAC
        public System.Void .ctor() { }
        // RVA: 0x0858BC4C  token: 0x6000AAD
        private Google.Protobuf.Reflection.EnumValueDescriptor <.ctor>b__0(Google.Protobuf.Reflection.EnumValueDescriptorProto value, System.Int32 i) { }

    }

    // TypeToken: 0x20000F9  // size: 0x20
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public Google.Protobuf.Extension[] extensions;  // 0x10
        public Google.Protobuf.Reflection.FileDescriptor file;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000AC4
        public System.Void .ctor() { }
        // RVA: 0x085971DC  token: 0x6000AC5
        private Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, System.Int32 i) { }

    }

    // TypeToken: 0x20000FA  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public Google.Protobuf.Extension[] extensions;  // 0x10
        public Google.Protobuf.Reflection.MessageDescriptor message;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000AC6
        public System.Void .ctor() { }
        // RVA: 0x085975F4  token: 0x6000AC7
        private Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, System.Int32 i) { }

    }

    // TypeToken: 0x20000FB  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.ExtensionCollection.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,Google.Protobuf.Reflection.MessageDescriptor> <>9__9_0;  // static @ 0x8
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_1;  // static @ 0x10
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,Google.Protobuf.Reflection.MessageDescriptor> <>9__9_2;  // static @ 0x18
        public static System.Func<Google.Protobuf.Reflection.FieldDescriptor,System.Int32> <>9__9_4;  // static @ 0x20
        public static System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_3;  // static @ 0x28

        // Methods
        // RVA: 0x08597C30  token: 0x6000AC8
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000AC9
        public System.Void .ctor() { }
        // RVA: 0x08596EB4  token: 0x6000ACA
        private Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp) { }
        // RVA: 0x08596EE8  token: 0x6000ACB
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp) { }
        // RVA: 0x08596F64  token: 0x6000ACC
        private Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_2(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp) { }
        // RVA: 0x08596F98  token: 0x6000ACD
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_3(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp) { }
        // RVA: 0x08597110  token: 0x6000ACE
        private System.Int32 <CrossLink>b__9_4(Google.Protobuf.Reflection.FieldDescriptor field) { }

    }

    // TypeToken: 0x2000101  // size: 0x20
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public Google.Protobuf.Reflection.FileDescriptor <>4__this;  // 0x10
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000B1C
        public System.Void .ctor() { }
        // RVA: 0x0859738C  token: 0x6000B1D
        private Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__0(Google.Protobuf.Reflection.DescriptorProto message, System.Int32 index) { }
        // RVA: 0x0859744C  token: 0x6000B1E
        private Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__1(Google.Protobuf.Reflection.EnumDescriptorProto enumType, System.Int32 index) { }
        // RVA: 0x0859750C  token: 0x6000B1F
        private Google.Protobuf.Reflection.ServiceDescriptor <.ctor>b__2(Google.Protobuf.Reflection.ServiceDescriptorProto service, System.Int32 index) { }

    }

    // TypeToken: 0x2000102  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.FileDescriptor.<>c <>9;  // static @ 0x0
        public static System.Func<Google.Protobuf.Reflection.FileDescriptor,System.String> <>9__9_0;  // static @ 0x8
        public static System.Func<Google.Protobuf.Reflection.GeneratedClrTypeInfo,System.Boolean> <>9__54_0;  // static @ 0x10
        public static System.Func<Google.Protobuf.Reflection.FieldDescriptor,Google.Protobuf.Extension> <>9__55_0;  // static @ 0x18
        public static System.Func<Google.Protobuf.Extension,System.Boolean> <>9__55_1;  // static @ 0x20
        public static System.Func<Google.Protobuf.Reflection.FieldDescriptor,Google.Protobuf.Extension> <>9__56_0;  // static @ 0x28
        public static System.Func<Google.Protobuf.Extension,System.Boolean> <>9__56_1;  // static @ 0x30

        // Methods
        // RVA: 0x08597DC0  token: 0x6000B20
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000B21
        public System.Void .ctor() { }
        // RVA: 0x08597130  token: 0x6000B22
        private System.String <DeterminePublicDependencies>b__9_0(Google.Protobuf.Reflection.FileDescriptor file) { }
        // RVA: 0x0686B910  token: 0x6000B23
        private System.Boolean <GetAllGeneratedExtensions>b__54_0(Google.Protobuf.Reflection.GeneratedClrTypeInfo t) { }
        // RVA: 0x08597168  token: 0x6000B24
        private Google.Protobuf.Extension <GetAllDependedExtensions>b__55_0(Google.Protobuf.Reflection.FieldDescriptor s) { }
        // RVA: 0x0686B910  token: 0x6000B25
        private System.Boolean <GetAllDependedExtensions>b__55_1(Google.Protobuf.Extension e) { }
        // RVA: 0x08597168  token: 0x6000B26
        private Google.Protobuf.Extension <GetAllDependedExtensionsFromMessage>b__56_0(Google.Protobuf.Reflection.FieldDescriptor s) { }
        // RVA: 0x0686B910  token: 0x6000B27
        private System.Boolean <GetAllDependedExtensionsFromMessage>b__56_1(Google.Protobuf.Extension e) { }

    }

    // TypeToken: 0x2000108  // size: 0x18
    public sealed class FieldCollection
    {
        // Fields
        private readonly Google.Protobuf.Reflection.MessageDescriptor messageDescriptor;  // 0x10

        // Properties
        Google.Protobuf.Reflection.FieldDescriptor Item { get; /* RVA: 0x0858E184 */ }
        Google.Protobuf.Reflection.FieldDescriptor Item { get; /* RVA: 0x0858E184 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000B5C
        private System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor) { }
        // RVA: 0x056B1D28  token: 0x6000B5D
        public System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder() { }
        // RVA: 0x056B1D0C  token: 0x6000B5E
        public System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder() { }
        // RVA: 0x06191144  token: 0x6000B5F
        private System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> ByJsonName() { }

    }

    // TypeToken: 0x2000109  // size: 0x28
    public sealed class <>c__DisplayClass5_0
    {
        // Fields
        public Google.Protobuf.Reflection.FileDescriptor file;  // 0x10
        public Google.Protobuf.Reflection.MessageDescriptor <>4__this;  // 0x18
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000B62
        public System.Void .ctor() { }
        // RVA: 0x0859791C  token: 0x6000B63
        private Google.Protobuf.Reflection.OneofDescriptor <.ctor>b__0(Google.Protobuf.Reflection.OneofDescriptorProto oneof, System.Int32 index) { }
        // RVA: 0x085979E0  token: 0x6000B64
        private Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__1(Google.Protobuf.Reflection.DescriptorProto type, System.Int32 index) { }
        // RVA: 0x08597AA4  token: 0x6000B65
        private Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__2(Google.Protobuf.Reflection.EnumDescriptorProto type, System.Int32 index) { }
        // RVA: 0x08597B68  token: 0x6000B66
        private Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__3(Google.Protobuf.Reflection.FieldDescriptorProto field, System.Int32 index) { }

    }

    // TypeToken: 0x200010A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.MessageDescriptor.<>c <>9;  // static @ 0x0
        public static System.Func<Google.Protobuf.Reflection.FieldDescriptor,System.Int32> <>9__5_4;  // static @ 0x8

        // Methods
        // RVA: 0x08597D5C  token: 0x6000B67
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000B68
        public System.Void .ctor() { }
        // RVA: 0x08597110  token: 0x6000B69
        private System.Int32 <.ctor>b__5_4(Google.Protobuf.Reflection.FieldDescriptor field) { }

    }

    // TypeToken: 0x200010D  // size: 0x18
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public Google.Protobuf.Reflection.OneofDescriptor descriptor;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000B7E
        public System.Void .ctor() { }
        // RVA: 0x08597818  token: 0x6000B7F
        private System.Int32 <ForSyntheticOneof>b__0(Google.Protobuf.IMessage message) { }
        // RVA: 0x085978B0  token: 0x6000B80
        private System.Void <ForSyntheticOneof>b__1(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200010F  // size: 0x18
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Int32 index;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000B8F
        public System.Void .ctor() { }
        // RVA: 0x08597594  token: 0x6000B90
        private System.Boolean <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto fieldProto) { }

    }

    // TypeToken: 0x2000113
    public interface IReflectionHelper
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000BA7
        public virtual System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        // RVA: -1  // abstract  token: 0x6000BA8
        public virtual System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        // RVA: -1  // abstract  token: 0x6000BA9
        public virtual System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: -1  // abstract  token: 0x6000BAA
        public virtual System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: -1  // abstract  token: 0x6000BAB
        public virtual System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000114
    public interface IExtensionReflectionHelper
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000BAC
        public virtual System.Object GetExtension(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000BAD
        public virtual System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value) { }
        // RVA: -1  // abstract  token: 0x6000BAE
        public virtual System.Boolean HasExtension(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000BAF
        public virtual System.Void ClearExtension(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000115
    public interface IExtensionSetReflector
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000BB0
        public virtual System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller() { }

    }

    // TypeToken: 0x2000117
    public sealed class <>c__DisplayClass0_0
    {
        // Fields
        public System.Func<T1,System.Int32> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BB7
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BB8
        private System.Int32 <CreateFuncIMessageInt32>b__0(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000118
    public sealed class <>c__DisplayClass0_1
    {
        // Fields
        public System.Func<T1,T2> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BB9
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BBA
        private System.Int32 <CreateFuncIMessageInt32>b__1(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000119
    public sealed class <>c__DisplayClass1_0
    {
        // Fields
        public System.Action<T1> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BBB
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BBC
        private System.Void <CreateActionIMessage>b__0(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200011A
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public System.Func<T1,T2> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BBD
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BBE
        private System.Object <CreateFuncIMessageObject>b__0(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200011B
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Action<T1,T2> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BBF
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BC0
        private System.Void <CreateActionIMessageObject>b__0(Google.Protobuf.IMessage message, System.Object arg) { }

    }

    // TypeToken: 0x200011C
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.Func<T1,System.Boolean> del;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BC1
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BC2
        private System.Boolean <CreateFuncIMessageBool>b__0(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000116
    public class ReflectionHelper`2 : IReflectionHelper
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000BB1
        public virtual System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        // RVA: -1  // not resolved  token: 0x6000BB2
        public virtual System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        // RVA: -1  // not resolved  token: 0x6000BB3
        public virtual System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: -1  // not resolved  token: 0x6000BB4
        public virtual System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: -1  // not resolved  token: 0x6000BB5
        public virtual System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }
        // RVA: -1  // not resolved  token: 0x6000BB6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class ExtensionReflectionHelper`2 : IExtensionReflectionHelper
    {
        // Fields
        private readonly Google.Protobuf.Extension extension;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BC3
        public System.Void .ctor(Google.Protobuf.Extension extension) { }
        // RVA: -1  // not resolved  token: 0x6000BC4
        public virtual System.Object GetExtension(Google.Protobuf.IMessage message) { }
        // RVA: -1  // not resolved  token: 0x6000BC5
        public virtual System.Boolean HasExtension(Google.Protobuf.IMessage message) { }
        // RVA: -1  // not resolved  token: 0x6000BC6
        public virtual System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000BC7
        public virtual System.Void ClearExtension(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200011F
    public sealed class <>c__DisplayClass0_0
    {
        // Fields
        public System.Func<T1,Google.Protobuf.ExtensionSet<T1>> getFunc;  // 0x0
        public System.Func<Google.Protobuf.ExtensionSet<T1>,System.Boolean> initializedFunc;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BCA
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000BCB
        private System.Boolean <CreateIsInitializedCaller>b__0(Google.Protobuf.IMessage m) { }

    }

    // TypeToken: 0x200011E
    public class ExtensionSetReflector`1 : IExtensionSetReflector
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000BC8
        public virtual System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller() { }
        // RVA: -1  // not resolved  token: 0x6000BC9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000120  // size: 0x14
    public sealed struct SampleEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.ReflectionUtil.SampleEnum X;  // const

    }

    // TypeToken: 0x2000123  // size: 0x20
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public Google.Protobuf.Reflection.FileDescriptor file;  // 0x10
        public Google.Protobuf.Reflection.ServiceDescriptor <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000BDC
        public System.Void .ctor() { }
        // RVA: 0x085972F0  token: 0x6000BDD
        private Google.Protobuf.Reflection.MethodDescriptor <.ctor>b__0(Google.Protobuf.Reflection.MethodDescriptorProto method, System.Int32 i) { }

    }

    // TypeToken: 0x2000125  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public Google.Protobuf.Reflection.SingleFieldAccessor <>4__this;  // 0x10
        public Google.Protobuf.Reflection.FieldDescriptor descriptor;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000BE3
        public System.Void .ctor() { }
        // RVA: 0x085975CC  token: 0x6000BE4
        private System.Boolean <.ctor>b__0(Google.Protobuf.IMessage message) { }
        // RVA: 0x0859772C  token: 0x6000BE5
        private System.Void <.ctor>b__1(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000126  // size: 0x20
    public sealed class <>c__DisplayClass3_1
    {
        // Fields
        public Google.Protobuf.Reflection.OneofAccessor oneofAccessor;  // 0x10
        public Google.Protobuf.Reflection.SingleFieldAccessor.<>c__DisplayClass3_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000BE6
        public System.Void .ctor() { }
        // RVA: 0x08597754  token: 0x6000BE7
        private System.Boolean <.ctor>b__2(Google.Protobuf.IMessage message) { }
        // RVA: 0x0859778C  token: 0x6000BE8
        private System.Void <.ctor>b__3(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000127  // size: 0x20
    public sealed class <>c__DisplayClass3_2
    {
        // Fields
        public System.Object defaultValue;  // 0x10
        public Google.Protobuf.Reflection.SingleFieldAccessor.<>c__DisplayClass3_0 CS$<>8__locals2;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000BE9
        public System.Void .ctor() { }
        // RVA: 0x085977E4  token: 0x6000BEA
        private System.Void <.ctor>b__5(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000128  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.SingleFieldAccessor.<>c <>9;  // static @ 0x0
        public static System.Func<Google.Protobuf.IMessage,System.Boolean> <>9__3_4;  // static @ 0x8

        // Methods
        // RVA: 0x08597CF8  token: 0x6000BEB
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000BEC
        public System.Void .ctor() { }
        // RVA: 0x08597180  token: 0x6000BED
        private System.Boolean <.ctor>b__3_4(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200012A  // size: 0x20
    public class Builder
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> types;  // 0x10
        private readonly System.Collections.Generic.HashSet<System.String> fileDescriptorNames;  // 0x18

        // Methods
        // RVA: 0x0858E018  token: 0x6000BF6
        private System.Void .ctor() { }
        // RVA: 0x0858DB70  token: 0x6000BF7
        private System.Void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor) { }
        // RVA: 0x0858DE30  token: 0x6000BF8
        private System.Void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor) { }
        // RVA: 0x0858DFB4  token: 0x6000BF9
        private Google.Protobuf.Reflection.TypeRegistry Build() { }

    }

    // TypeToken: 0x200012B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Reflection.TypeRegistry.<>c <>9;  // static @ 0x0
        public static System.Func<Google.Protobuf.Reflection.MessageDescriptor,Google.Protobuf.Reflection.FileDescriptor> <>9__9_0;  // static @ 0x8

        // Methods
        // RVA: 0x08597C94  token: 0x6000BFA
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000BFB
        public System.Void .ctor() { }
        // RVA: 0x08597150  token: 0x6000BFC
        private Google.Protobuf.Reflection.FileDescriptor <FromMessages>b__9_0(Google.Protobuf.Reflection.MessageDescriptor md) { }

    }

    // TypeToken: 0x2000130
    public class DictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator;  // 0x0

        // Properties
        System.Object Current { get; /* RVA: -1  // not resolved */ }
        System.Collections.DictionaryEntry Entry { get; /* RVA: -1  // not resolved */ }
        System.Object Key { get; /* RVA: -1  // not resolved */ }
        System.Object Value { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C32
        private System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator) { }
        // RVA: -1  // not resolved  token: 0x6000C33
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000C34
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000131
    public sealed class Codec
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TKey> keyCodec;  // 0x0
        private readonly Google.Protobuf.FieldCodec<TValue> valueCodec;  // 0x0
        private readonly System.UInt32 mapTag;  // 0x0

        // Properties
        Google.Protobuf.FieldCodec<TKey> KeyCodec { get; /* RVA: -1  // not resolved */ }
        Google.Protobuf.FieldCodec<TValue> ValueCodec { get; /* RVA: -1  // not resolved */ }
        System.UInt32 MapTag { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C39
        public System.Void .ctor(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, System.UInt32 mapTag) { }

    }

    // TypeToken: 0x2000132
    public class MapView`1 : System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.ICollection
    {
        // Fields
        private readonly Google.Protobuf.Collections.MapField<TKey,TValue> parent;  // 0x0
        private readonly System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection;  // 0x0
        private readonly System.Func<T,System.Boolean> containsCheck;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsSynchronized { get; /* RVA: -1  // not resolved */ }
        System.Object SyncRoot { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C3D
        private System.Void .ctor(Google.Protobuf.Collections.MapField<TKey,TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection, System.Func<T,System.Boolean> containsCheck) { }
        // RVA: -1  // not resolved  token: 0x6000C42
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C43
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000C44
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C45
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000C46
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C47
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C48
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C49
        public virtual System.Void CopyTo(System.Array array, System.Int32 index) { }

    }

    // TypeToken: 0x2000133
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public TValue value;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C4A
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000C4B
        private System.Boolean <ContainsValue>b__0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair) { }

    }

    // TypeToken: 0x2000134
    public sealed class <>c
    {
        // Fields
        public static readonly Google.Protobuf.Collections.MapField.<>c<TKey,TValue> <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> <>9__14_0;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> <>9__16_0;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Collections.DictionaryEntry> <>9__43_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C4C
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000C4D
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000C4E
        private TKey <get_Keys>b__14_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair) { }
        // RVA: -1  // not resolved  token: 0x6000C4F
        private TValue <get_Values>b__16_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair) { }
        // RVA: -1  // not resolved  token: 0x6000C50
        private System.Collections.DictionaryEntry <System.Collections.ICollection.CopyTo>b__43_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair) { }

    }

    // TypeToken: 0x2000136  // size: 0x10
    public class BitwiseDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer`1
    {
        // Methods
        // RVA: 0x0858D734  token: 0x6000C57
        public virtual System.Boolean Equals(System.Double x, System.Double y) { }
        // RVA: 0x0858D790  token: 0x6000C58
        public virtual System.Int32 GetHashCode(System.Double obj) { }
        // RVA: 0x039D7A80  token: 0x6000C59
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000137  // size: 0x10
    public class BitwiseSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer`1
    {
        // Methods
        // RVA: 0x0858DAB0  token: 0x6000C5A
        public virtual System.Boolean Equals(System.Single x, System.Single y) { }
        // RVA: 0x0858DB1C  token: 0x6000C5B
        public virtual System.Int32 GetHashCode(System.Single obj) { }
        // RVA: 0x039D7A50  token: 0x6000C5C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000138  // size: 0x10
    public class BitwiseNullableDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer`1
    {
        // Methods
        // RVA: 0x0858D7E8  token: 0x6000C5D
        public virtual System.Boolean Equals(System.Nullable<System.Double> x, System.Nullable<System.Double> y) { }
        // RVA: 0x0858D8B0  token: 0x6000C5E
        public virtual System.Int32 GetHashCode(System.Nullable<System.Double> obj) { }
        // RVA: 0x039D7A20  token: 0x6000C5F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000139  // size: 0x10
    public class BitwiseNullableSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer`1
    {
        // Methods
        // RVA: 0x0858D948  token: 0x6000C60
        public virtual System.Boolean Equals(System.Nullable<System.Single> x, System.Nullable<System.Single> y) { }
        // RVA: 0x0858DA18  token: 0x6000C61
        public virtual System.Int32 GetHashCode(System.Nullable<System.Single> obj) { }
        // RVA: 0x039D79F0  token: 0x6000C62
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public sealed class <GetEnumerator>d__29 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private T <>2__current;  // 0x0
        public Google.Protobuf.Collections.RepeatedField<T> <>4__this;  // 0x0
        private System.Int32 <i>5__2;  // 0x0

        // Properties
        T System.Collections.Generic.IEnumerator<T>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000CA5
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x6000CA6
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000CA7
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000CA9
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200013E  // size: 0x3C
    public sealed struct __StaticArrayInitTypeSize=44
    {
    }

    // TypeToken: 0x200013D  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 1EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300;  // static @ 0x0

    }

namespace Google.Protobuf
{

    // TypeToken: 0x2000006  // size: 0x10
    public static class ByteArray
    {
        // Fields
        private static System.Int32 CopyThreshold;  // const

        // Methods
        // RVA: 0x0229DBE0  token: 0x6000012
        private static System.Void Copy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count) { }
        // RVA: 0x0853DD10  token: 0x6000013
        private static System.Void Reverse(System.Byte[] bytes) { }

    }

    // TypeToken: 0x2000007  // size: 0x20
    public sealed class ByteString : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.IEquatable`1
    {
        // Fields
        private static readonly Google.Protobuf.ByteString empty;  // static @ 0x0
        private readonly System.ReadOnlyMemory<System.Byte> bytes;  // 0x10

        // Properties
        Google.Protobuf.ByteString Empty { get; /* RVA: 0x0853E9D0 */ }
        System.Int32 Length { get; /* RVA: 0x03543640 */ }
        System.Boolean IsEmpty { get; /* RVA: 0x0853EA20 */ }
        System.ReadOnlySpan<System.Byte> Span { get; /* RVA: 0x03543560 */ }
        System.ReadOnlyMemory<System.Byte> Memory { get; /* RVA: 0x020B7B30 */ }
        System.Byte Item { get; /* RVA: 0x0853EA38 */ }

        // Methods
        // RVA: 0x0229DA90  token: 0x6000014
        private static Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<System.Byte> bytes) { }
        // RVA: 0x0229DA00  token: 0x6000015
        private static Google.Protobuf.ByteString AttachBytes(System.Byte[] bytes) { }
        // RVA: 0x0229DBD0  token: 0x6000016
        private System.Void .ctor(System.ReadOnlyMemory<System.Byte> bytes) { }
        // RVA: 0x03187700  token: 0x600001C
        public System.Byte[] ToByteArray() { }
        // RVA: 0x0853E69C  token: 0x600001D
        public System.String ToBase64() { }
        // RVA: 0x0853E2C0  token: 0x600001E
        public static Google.Protobuf.ByteString FromBase64(System.String bytes) { }
        // RVA: 0x0853E408  token: 0x600001F
        public static Google.Protobuf.ByteString FromStream(System.IO.Stream stream) { }
        // RVA: 0x0853E3A0  token: 0x6000020
        public static System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0229D820  token: 0x6000021
        public static Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes) { }
        // RVA: 0x0229DAF0  token: 0x6000022
        public static Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes, System.Int32 offset, System.Int32 count) { }
        // RVA: 0x0853DF64  token: 0x6000023
        public static Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<System.Byte> bytes) { }
        // RVA: 0x0853DEC0  token: 0x6000024
        public static Google.Protobuf.ByteString CopyFrom(System.String text, System.Text.Encoding encoding) { }
        // RVA: 0x0853DE68  token: 0x6000025
        public static Google.Protobuf.ByteString CopyFromUtf8(System.String text) { }
        // RVA: 0x0853E7D4  token: 0x6000027
        public System.String ToString(System.Text.Encoding encoding) { }
        // RVA: 0x0853E7B0  token: 0x6000028
        public System.String ToStringUtf8() { }
        // RVA: 0x0853E598  token: 0x6000029
        public virtual System.Collections.Generic.IEnumerator<System.Byte> GetEnumerator() { }
        // RVA: 0x0853E694  token: 0x600002A
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x0853E08C  token: 0x600002B
        public Google.Protobuf.CodedInputStream CreateCodedInput() { }
        // RVA: 0x02F0E490  token: 0x600002C
        public static System.Boolean op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs) { }
        // RVA: 0x0853EA98  token: 0x600002D
        public static System.Boolean op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs) { }
        // RVA: 0x0853E1F4  token: 0x600002E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0853E608  token: 0x600002F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0853E264  token: 0x6000030
        public virtual System.Boolean Equals(Google.Protobuf.ByteString other) { }
        // RVA: 0x0853E004  token: 0x6000031
        public System.Void CopyTo(System.Byte[] array, System.Int32 position) { }
        // RVA: 0x0853E8D0  token: 0x6000032
        public System.Void WriteTo(System.IO.Stream outputStream) { }
        // RVA: 0x0229D8D0  token: 0x6000033
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class ByteStringAsync
    {
        // Methods
        // RVA: 0x0853DD78  token: 0x6000034
        private static System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x200000A  // size: 0xA8
    public sealed class CodedInputStream : System.IDisposable
    {
        // Fields
        private readonly System.Boolean leaveOpen;  // 0x10
        private readonly System.Byte[] buffer;  // 0x18
        private readonly System.IO.Stream input;  // 0x20
        private Google.Protobuf.ParserInternalState state;  // 0x28
        private static System.Int32 DefaultRecursionLimit;  // const
        private static System.Int32 DefaultSizeLimit;  // const
        private static System.Int32 BufferSize;  // const

        // Properties
        System.Int64 Position { get; /* RVA: 0x0853F8BC */ }
        System.UInt32 LastTag { get; /* RVA: 0x03D4F0B0 */ }
        System.Int32 SizeLimit { get; /* RVA: 0x03D5B3A0 */ }
        System.Int32 RecursionLimit { get; /* RVA: 0x03D4EB50 */ }
        System.Boolean DiscardUnknownFields { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        Google.Protobuf.ExtensionRegistry ExtensionRegistry { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x04270264 */ }
        System.Byte[] InternalBuffer { get; /* RVA: 0x01041090 */ }
        System.IO.Stream InternalInputStream { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.ParserInternalState& InternalState { get; /* RVA: 0x03D6BB40 */ }
        System.Boolean ReachedLimit { get; /* RVA: 0x0853F8F8 */ }
        System.Boolean IsAtEnd { get; /* RVA: 0x0853F858 */ }

        // Methods
        // RVA: 0x0853F7D0  token: 0x6000037
        public System.Void .ctor(System.Byte[] buffer) { }
        // RVA: 0x024D1940  token: 0x6000038
        public System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x0853F5FC  token: 0x6000039
        public System.Void .ctor(System.IO.Stream input) { }
        // RVA: 0x0853F728  token: 0x600003A
        public System.Void .ctor(System.IO.Stream input, System.Boolean leaveOpen) { }
        // RVA: 0x024D2150  token: 0x600003B
        private System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Boolean leaveOpen) { }
        // RVA: 0x0853F608  token: 0x600003C
        private System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Int32 sizeLimit, System.Int32 recursionLimit, System.Boolean leaveOpen) { }
        // RVA: 0x0853EAEC  token: 0x600003D
        public static Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, System.Int32 sizeLimit, System.Int32 recursionLimit) { }
        // RVA: 0x0853EBAC  token: 0x6000049
        public virtual System.Void Dispose() { }
        // RVA: 0x024D20F0  token: 0x600004A
        private System.Void CheckReadEndOfStreamTag() { }
        // RVA: 0x0853EC4C  token: 0x600004B
        public System.UInt32 PeekTag() { }
        // RVA: 0x0853F40C  token: 0x600004C
        public System.UInt32 ReadTag() { }
        // RVA: 0x0853F57C  token: 0x600004D
        public System.Void SkipLastField() { }
        // RVA: 0x0853F4F0  token: 0x600004E
        private System.Void SkipGroup(System.UInt32 startGroupTag) { }
        // RVA: 0x0853ED4C  token: 0x600004F
        public System.Double ReadDouble() { }
        // RVA: 0x0853EDCC  token: 0x6000050
        public System.Single ReadFloat() { }
        // RVA: 0x0853EF30  token: 0x6000051
        public System.UInt64 ReadUInt64() { }
        // RVA: 0x0853EF30  token: 0x6000052
        public System.Int64 ReadInt64() { }
        // RVA: 0x0853EDB4  token: 0x6000053
        public System.Int32 ReadInt32() { }
        // RVA: 0x0853EDC4  token: 0x6000054
        public System.UInt64 ReadFixed64() { }
        // RVA: 0x0853EDBC  token: 0x6000055
        public System.UInt32 ReadFixed32() { }
        // RVA: 0x0853ECD0  token: 0x6000056
        public System.Boolean ReadBool() { }
        // RVA: 0x0853F3A8  token: 0x6000057
        public System.String ReadString() { }
        // RVA: 0x0853EFA0  token: 0x6000058
        public System.Void ReadMessage(Google.Protobuf.IMessage builder) { }
        // RVA: 0x0853EE34  token: 0x6000059
        public System.Void ReadGroup(Google.Protobuf.IMessage builder) { }
        // RVA: 0x0853ECE8  token: 0x600005A
        public Google.Protobuf.ByteString ReadBytes() { }
        // RVA: 0x0853EDB4  token: 0x600005B
        public System.UInt32 ReadUInt32() { }
        // RVA: 0x0853EDB4  token: 0x600005C
        public System.Int32 ReadEnum() { }
        // RVA: 0x0853EDBC  token: 0x600005D
        public System.Int32 ReadSFixed32() { }
        // RVA: 0x0853EDC4  token: 0x600005E
        public System.Int64 ReadSFixed64() { }
        // RVA: 0x0853F36C  token: 0x600005F
        public System.Int32 ReadSInt32() { }
        // RVA: 0x0853F388  token: 0x6000060
        public System.Int64 ReadSInt64() { }
        // RVA: 0x0853EF38  token: 0x6000061
        public System.Int32 ReadLength() { }
        // RVA: 0x0853EBD8  token: 0x6000062
        public System.Boolean MaybeConsumeTag(System.UInt32 tag) { }
        // RVA: 0x0853F29C  token: 0x6000063
        private System.UInt32 ReadRawVarint32() { }
        // RVA: 0x0853F294  token: 0x6000064
        private static System.UInt32 ReadRawVarint32(System.IO.Stream input) { }
        // RVA: 0x0853F304  token: 0x6000065
        private System.UInt64 ReadRawVarint64() { }
        // RVA: 0x0853F1C4  token: 0x6000066
        private System.UInt32 ReadRawLittleEndian32() { }
        // RVA: 0x0853F22C  token: 0x6000067
        private System.UInt64 ReadRawLittleEndian64() { }
        // RVA: 0x0853ECC4  token: 0x6000068
        private System.Int32 PushLimit(System.Int32 byteLimit) { }
        // RVA: 0x0853ECB4  token: 0x6000069
        private System.Void PopLimit(System.Int32 oldLimit) { }
        // RVA: 0x0853F474  token: 0x600006C
        private System.Boolean RefillBuffer(System.Boolean mustSucceed) { }
        // RVA: 0x0853F150  token: 0x600006D
        private System.Byte[] ReadRawBytes(System.Int32 size) { }
        // RVA: 0x02942560  token: 0x600006E
        public System.Void ReadRawMessage(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200000B  // size: 0x40
    public sealed class CodedOutputStream : System.IDisposable
    {
        // Fields
        private static System.Int32 LittleEndian64Size;  // const
        private static System.Int32 LittleEndian32Size;  // const
        private static System.Int32 DoubleSize;  // const
        private static System.Int32 FloatSize;  // const
        private static System.Int32 BoolSize;  // const
        public static readonly System.Int32 DefaultBufferSize;  // static @ 0x0
        private readonly System.Boolean leaveOpen;  // 0x10
        private readonly System.Byte[] buffer;  // 0x18
        private Google.Protobuf.WriterInternalState state;  // 0x20
        private readonly System.IO.Stream output;  // 0x38

        // Properties
        System.Int64 Position { get; /* RVA: 0x08540F64 */ }
        System.Int32 NonOutputPosition { get; /* RVA: 0x03D4E2E0 */ }
        System.Int32 SpaceLeft { get; /* RVA: 0x08540F98 */ }
        System.Byte[] InternalBuffer { get; /* RVA: 0x01041090 */ }
        System.IO.Stream InternalOutputStream { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.WriterInternalState& InternalState { get; /* RVA: 0x03D69590 */ }

        // Methods
        // RVA: 0x03D55800  token: 0x600006F
        public static System.Int32 ComputeDoubleSize(System.Double value) { }
        // RVA: 0x03D50CD0  token: 0x6000070
        public static System.Int32 ComputeFloatSize(System.Single value) { }
        // RVA: 0x024D6680  token: 0x6000071
        public static System.Int32 ComputeUInt64Size(System.UInt64 value) { }
        // RVA: 0x024D6630  token: 0x6000072
        public static System.Int32 ComputeInt64Size(System.Int64 value) { }
        // RVA: 0x024D5F30  token: 0x6000073
        public static System.Int32 ComputeInt32Size(System.Int32 value) { }
        // RVA: 0x03D55800  token: 0x6000074
        public static System.Int32 ComputeFixed64Size(System.UInt64 value) { }
        // RVA: 0x03D50CD0  token: 0x6000075
        public static System.Int32 ComputeFixed32Size(System.UInt32 value) { }
        // RVA: 0x01168950  token: 0x6000076
        public static System.Int32 ComputeBoolSize(System.Boolean value) { }
        // RVA: 0x024D5730  token: 0x6000077
        public static System.Int32 ComputeStringSize(System.String value) { }
        // RVA: 0x0853F910  token: 0x6000078
        public static System.Int32 ComputeGroupSize(Google.Protobuf.IMessage value) { }
        // RVA: 0x024D5C70  token: 0x6000079
        public static System.Int32 ComputeMessageSize(Google.Protobuf.IMessage value) { }
        // RVA: 0x035435C0  token: 0x600007A
        public static System.Int32 ComputeBytesSize(Google.Protobuf.ByteString value) { }
        // RVA: 0x024D5CF0  token: 0x600007B
        public static System.Int32 ComputeUInt32Size(System.UInt32 value) { }
        // RVA: 0x024D5E30  token: 0x600007C
        public static System.Int32 ComputeEnumSize(System.Int32 value) { }
        // RVA: 0x03D50CD0  token: 0x600007D
        public static System.Int32 ComputeSFixed32Size(System.Int32 value) { }
        // RVA: 0x03D55800  token: 0x600007E
        public static System.Int32 ComputeSFixed64Size(System.Int64 value) { }
        // RVA: 0x0853F95C  token: 0x600007F
        public static System.Int32 ComputeSInt32Size(System.Int32 value) { }
        // RVA: 0x0853F9BC  token: 0x6000080
        public static System.Int32 ComputeSInt64Size(System.Int64 value) { }
        // RVA: 0x024D5D90  token: 0x6000081
        public static System.Int32 ComputeLengthSize(System.Int32 length) { }
        // RVA: 0x024D5FE0  token: 0x6000082
        public static System.Int32 ComputeRawVarint32Size(System.UInt32 value) { }
        // RVA: 0x024D66D0  token: 0x6000083
        public static System.Int32 ComputeRawVarint64Size(System.UInt64 value) { }
        // RVA: 0x0853FA20  token: 0x6000084
        public static System.Int32 ComputeTagSize(System.Int32 fieldNumber) { }
        // RVA: 0x08540D38  token: 0x6000085
        public System.Void .ctor(System.Byte[] flatArray) { }
        // RVA: 0x024D1FD0  token: 0x6000086
        public System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x08540DD0  token: 0x6000087
        private System.Void .ctor(System.IO.Stream output, System.Byte[] buffer, System.Boolean leaveOpen) { }
        // RVA: 0x08540EFC  token: 0x6000088
        public System.Void .ctor(System.IO.Stream output) { }
        // RVA: 0x08540D64  token: 0x6000089
        public System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize) { }
        // RVA: 0x08540CC0  token: 0x600008A
        public System.Void .ctor(System.IO.Stream output, System.Boolean leaveOpen) { }
        // RVA: 0x08540E84  token: 0x600008B
        public System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize, System.Boolean leaveOpen) { }
        // RVA: 0x0853FC04  token: 0x600008E
        public System.Void WriteDouble(System.Double value) { }
        // RVA: 0x0853FE08  token: 0x600008F
        public System.Void WriteFloat(System.Single value) { }
        // RVA: 0x08540C40  token: 0x6000090
        public System.Void WriteUInt64(System.UInt64 value) { }
        // RVA: 0x08540020  token: 0x6000091
        public System.Void WriteInt64(System.Int64 value) { }
        // RVA: 0x0853FFA0  token: 0x6000092
        public System.Void WriteInt32(System.Int32 value) { }
        // RVA: 0x0853FD88  token: 0x6000093
        public System.Void WriteFixed64(System.UInt64 value) { }
        // RVA: 0x0853FD08  token: 0x6000094
        public System.Void WriteFixed32(System.UInt32 value) { }
        // RVA: 0x0853FB04  token: 0x6000095
        public System.Void WriteBool(System.Boolean value) { }
        // RVA: 0x08540A2C  token: 0x6000096
        public System.Void WriteString(System.String value) { }
        // RVA: 0x08540120  token: 0x6000097
        public System.Void WriteMessage(Google.Protobuf.IMessage value) { }
        // RVA: 0x024D3B30  token: 0x6000098
        public System.Void WriteRawMessage(Google.Protobuf.IMessage value) { }
        // RVA: 0x0853FE8C  token: 0x6000099
        public System.Void WriteGroup(Google.Protobuf.IMessage value) { }
        // RVA: 0x0853FB84  token: 0x600009A
        public System.Void WriteBytes(Google.Protobuf.ByteString value) { }
        // RVA: 0x08540BC0  token: 0x600009B
        public System.Void WriteUInt32(System.UInt32 value) { }
        // RVA: 0x0853FC88  token: 0x600009C
        public System.Void WriteEnum(System.Int32 value) { }
        // RVA: 0x0854082C  token: 0x600009D
        public System.Void WriteSFixed32(System.Int32 value) { }
        // RVA: 0x085408AC  token: 0x600009E
        public System.Void WriteSFixed64(System.Int64 value) { }
        // RVA: 0x0854092C  token: 0x600009F
        public System.Void WriteSInt32(System.Int32 value) { }
        // RVA: 0x085409AC  token: 0x60000A0
        public System.Void WriteSInt64(System.Int64 value) { }
        // RVA: 0x085400A0  token: 0x60000A1
        public System.Void WriteLength(System.Int32 length) { }
        // RVA: 0x08540B2C  token: 0x60000A2
        public System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        // RVA: 0x08540AAC  token: 0x60000A3
        public System.Void WriteTag(System.UInt32 tag) { }
        // RVA: 0x085406AC  token: 0x60000A4
        public System.Void WriteRawTag(System.Byte b1) { }
        // RVA: 0x08540618  token: 0x60000A5
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2) { }
        // RVA: 0x085404C0  token: 0x60000A6
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3) { }
        // RVA: 0x08540568  token: 0x60000A7
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        // RVA: 0x08540404  token: 0x60000A8
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        // RVA: 0x0854072C  token: 0x60000A9
        private System.Void WriteRawVarint32(System.UInt32 value) { }
        // RVA: 0x085407AC  token: 0x60000AA
        private System.Void WriteRawVarint64(System.UInt64 value) { }
        // RVA: 0x08540304  token: 0x60000AB
        private System.Void WriteRawLittleEndian32(System.UInt32 value) { }
        // RVA: 0x08540384  token: 0x60000AC
        private System.Void WriteRawLittleEndian64(System.UInt64 value) { }
        // RVA: 0x08540234  token: 0x60000AD
        private System.Void WriteRawBytes(System.Byte[] value) { }
        // RVA: 0x08540260  token: 0x60000AE
        private System.Void WriteRawBytes(System.Byte[] value, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x0853FA70  token: 0x60000AF
        public virtual System.Void Dispose() { }
        // RVA: 0x0853FAAC  token: 0x60000B0
        public System.Void Flush() { }
        // RVA: 0x0853F904  token: 0x60000B1
        public System.Void CheckNoSpaceLeft() { }
        // RVA: 0x03D44A20  token: 0x60000B6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x18
    public abstract class Extension
    {
        // Fields
        private readonly System.Int32 <FieldNumber>k__BackingField;  // 0x10

        // Properties
        System.Type TargetType { get; /* RVA: -1  // abstract */ }
        System.Int32 FieldNumber { get; /* RVA: 0x03D4E340 */ }
        System.Boolean IsRepeated { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000B9
        protected System.Void .ctor(System.Int32 fieldNumber) { }
        // RVA: -1  // abstract  token: 0x60000BA
        private virtual Google.Protobuf.IExtensionValue CreateValue() { }

    }

    // TypeToken: 0x200000E
    public sealed class Extension`2 : Google.Protobuf.Extension
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TValue> codec;  // 0x0

        // Properties
        TValue DefaultValue { get; /* RVA: -1  // not resolved */ }
        System.Type TargetType { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsRepeated { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000BD
        public System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x60000C1
        private virtual Google.Protobuf.IExtensionValue CreateValue() { }

    }

    // TypeToken: 0x200000F
    public sealed class RepeatedExtension`2 : Google.Protobuf.Extension
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TValue> codec;  // 0x0

        // Properties
        System.Type TargetType { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsRepeated { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000C2
        public System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x60000C5
        private virtual Google.Protobuf.IExtensionValue CreateValue() { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public sealed class ExtensionRegistry : System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, Google.Protobuf.IDeepCloneable`1
    {
        // Fields
        private System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> extensions;  // 0x10

        // Properties
        System.Int32 Count { get; /* RVA: 0x08541B10 */ }
        System.Boolean System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x085418C0  token: 0x60000C6
        public System.Void .ctor() { }
        // RVA: 0x08541938  token: 0x60000C7
        private System.Void .ctor(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> collection) { }
        // RVA: 0x08541434  token: 0x60000CA
        private System.Boolean ContainsInputField(System.UInt32 lastTag, System.Type target, Google.Protobuf.Extension& extension) { }
        // RVA: 0x085412B8  token: 0x60000CB
        public virtual System.Void Add(Google.Protobuf.Extension extension) { }
        // RVA: 0x08541164  token: 0x60000CC
        public System.Void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions) { }
        // RVA: 0x08541384  token: 0x60000CD
        public virtual System.Void Clear() { }
        // RVA: 0x085414D8  token: 0x60000CE
        public virtual System.Boolean Contains(Google.Protobuf.Extension item) { }
        // RVA: 0x085416DC  token: 0x60000CF
        private virtual System.Void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, System.Int32 arrayIndex) { }
        // RVA: 0x085415A4  token: 0x60000D0
        public virtual System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator() { }
        // RVA: 0x08541610  token: 0x60000D1
        public virtual System.Boolean Remove(Google.Protobuf.Extension item) { }
        // RVA: 0x085418B8  token: 0x60000D2
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x085413D0  token: 0x60000D3
        public virtual Google.Protobuf.ExtensionRegistry Clone() { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class ExtensionSet
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000DC
        private static System.Boolean TryGetValue(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension extension, Google.Protobuf.IExtensionValue& value) { }
        // RVA: -1  // generic def  token: 0x60000DD
        public static TValue Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000DE
        public static Google.Protobuf.Collections.RepeatedField<TValue> Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000DF
        public static Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000E0
        public static System.Void Set(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x60000E1
        public static System.Boolean Has(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000E2
        public static System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000E3
        public static System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60000E4
        public static System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.CodedInputStream stream) { }
        // RVA: -1  // generic def  token: 0x60000E5
        public static System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // generic def  token: 0x60000E6
        public static System.Void MergeFrom(Google.Protobuf.ExtensionSet<TTarget>& first, Google.Protobuf.ExtensionSet<TTarget> second) { }
        // RVA: -1  // generic def  token: 0x60000E7
        public static Google.Protobuf.ExtensionSet<TTarget> Clone(Google.Protobuf.ExtensionSet<TTarget> set) { }

    }

    // TypeToken: 0x2000014
    public sealed class ExtensionSet`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue> <ValuesByNumber>k__BackingField;  // 0x0

        // Properties
        System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue> ValuesByNumber { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000E9
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x60000EA
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: -1  // not resolved  token: 0x60000EB
        public System.Int32 CalculateSize() { }
        // RVA: -1  // not resolved  token: 0x60000EC
        public System.Void WriteTo(Google.Protobuf.CodedOutputStream stream) { }
        // RVA: -1  // not resolved  token: 0x60000ED
        public System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x60000EE
        private System.Boolean IsInitialized() { }
        // RVA: -1  // not resolved  token: 0x60000EF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public interface IExtensionValue : System.IEquatable`1, Google.Protobuf.IDeepCloneable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60000F3
        public virtual System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // abstract  token: 0x60000F4
        public virtual System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        // RVA: -1  // abstract  token: 0x60000F5
        public virtual System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        // RVA: -1  // abstract  token: 0x60000F6
        public virtual System.Int32 CalculateSize() { }
        // RVA: -1  // abstract  token: 0x60000F7
        public virtual System.Boolean IsInitialized() { }
        // RVA: -1  // abstract  token: 0x60000F8
        public virtual System.Object GetValue() { }

    }

    // TypeToken: 0x2000017
    public sealed class ExtensionValue`1 : Google.Protobuf.IExtensionValue, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1
    {
        // Fields
        private T field;  // 0x0
        private Google.Protobuf.FieldCodec<T> codec;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60000F9
        private System.Void .ctor(Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x60000FA
        public virtual System.Int32 CalculateSize() { }
        // RVA: -1  // not resolved  token: 0x60000FB
        public virtual Google.Protobuf.IExtensionValue Clone() { }
        // RVA: -1  // not resolved  token: 0x60000FC
        public virtual System.Boolean Equals(Google.Protobuf.IExtensionValue other) { }
        // RVA: -1  // not resolved  token: 0x60000FD
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x60000FE
        public virtual System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x60000FF
        public virtual System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        // RVA: -1  // not resolved  token: 0x6000100
        public virtual System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x6000101
        public T GetValue() { }
        // RVA: -1  // not resolved  token: 0x6000102
        private virtual System.Object Google.Protobuf.IExtensionValue.GetValue() { }
        // RVA: -1  // not resolved  token: 0x6000103
        public System.Void SetValue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000104
        public virtual System.Boolean IsInitialized() { }

    }

    // TypeToken: 0x2000018
    public sealed class RepeatedExtensionValue`1 : Google.Protobuf.IExtensionValue, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1
    {
        // Fields
        private Google.Protobuf.Collections.RepeatedField<T> field;  // 0x0
        private readonly Google.Protobuf.FieldCodec<T> codec;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000105
        private System.Void .ctor(Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000106
        public virtual System.Int32 CalculateSize() { }
        // RVA: -1  // not resolved  token: 0x6000107
        public virtual Google.Protobuf.IExtensionValue Clone() { }
        // RVA: -1  // not resolved  token: 0x6000108
        public virtual System.Boolean Equals(Google.Protobuf.IExtensionValue other) { }
        // RVA: -1  // not resolved  token: 0x6000109
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x600010A
        public virtual System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x600010B
        public virtual System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        // RVA: -1  // not resolved  token: 0x600010C
        public virtual System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x600010D
        public Google.Protobuf.Collections.RepeatedField<T> GetValue() { }
        // RVA: -1  // not resolved  token: 0x600010E
        private virtual System.Object Google.Protobuf.IExtensionValue.GetValue() { }
        // RVA: -1  // not resolved  token: 0x600010F
        public virtual System.Boolean IsInitialized() { }

    }

    // TypeToken: 0x2000019  // size: 0x10
    public static class FieldCodec
    {
        // Methods
        // RVA: 0x032E9E90  token: 0x6000110
        public static Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag) { }
        // RVA: 0x08541B58  token: 0x6000111
        public static Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag) { }
        // RVA: 0x04276060  token: 0x6000112
        public static Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag) { }
        // RVA: 0x04276048  token: 0x6000113
        public static Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag) { }
        // RVA: 0x08542870  token: 0x6000114
        public static Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag) { }
        // RVA: 0x08541FCC  token: 0x6000115
        public static Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag) { }
        // RVA: 0x08542400  token: 0x6000116
        public static Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag) { }
        // RVA: 0x0427603C  token: 0x6000117
        public static Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag) { }
        // RVA: 0x0427606C  token: 0x6000118
        public static Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag) { }
        // RVA: 0x08542ACC  token: 0x6000119
        public static Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag) { }
        // RVA: 0x08541FD8  token: 0x600011A
        public static Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag) { }
        // RVA: 0x08542624  token: 0x600011B
        public static Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag) { }
        // RVA: 0x04276768  token: 0x600011C
        public static Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag) { }
        // RVA: 0x04276054  token: 0x600011D
        public static Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag) { }
        // RVA: 0x08541DBC  token: 0x600011E
        public static Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag) { }
        // RVA: -1  // generic def  token: 0x600011F
        public static Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32) { }
        // RVA: 0x032E9ED0  token: 0x6000120
        public static Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag, System.String defaultValue) { }
        // RVA: 0x02F0E210  token: 0x6000121
        public static Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag, Google.Protobuf.ByteString defaultValue) { }
        // RVA: 0x032E6A00  token: 0x6000122
        public static Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag, System.Boolean defaultValue) { }
        // RVA: 0x032E81E0  token: 0x6000123
        public static Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag, System.Int32 defaultValue) { }
        // RVA: 0x08542630  token: 0x6000124
        public static Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag, System.Int32 defaultValue) { }
        // RVA: 0x08541DC8  token: 0x6000125
        public static Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag, System.UInt32 defaultValue) { }
        // RVA: 0x085421FC  token: 0x6000126
        public static Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag, System.Int32 defaultValue) { }
        // RVA: 0x032E3E80  token: 0x6000127
        public static Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag, System.UInt32 defaultValue) { }
        // RVA: 0x032E6080  token: 0x6000128
        public static Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag, System.Int64 defaultValue) { }
        // RVA: 0x0854287C  token: 0x6000129
        public static Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag, System.Int64 defaultValue) { }
        // RVA: 0x08541FE4  token: 0x600012A
        public static Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag, System.UInt64 defaultValue) { }
        // RVA: 0x0854240C  token: 0x600012B
        public static Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag, System.Int64 defaultValue) { }
        // RVA: 0x035D0E10  token: 0x600012C
        public static Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag, System.UInt64 defaultValue) { }
        // RVA: 0x039DE5B0  token: 0x600012D
        public static Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag, System.Single defaultValue) { }
        // RVA: 0x08541BA8  token: 0x600012E
        public static Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag, System.Double defaultValue) { }
        // RVA: -1  // generic def  token: 0x600012F
        public static Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32, T defaultValue) { }
        // RVA: -1  // generic def  token: 0x6000130
        public static Google.Protobuf.FieldCodec<T> ForMessage(System.UInt32 tag, Google.Protobuf.MessageParser<T> parser) { }
        // RVA: -1  // generic def  token: 0x6000131
        public static Google.Protobuf.FieldCodec<T> ForGroup(System.UInt32 startTag, System.UInt32 endTag, Google.Protobuf.MessageParser<T> parser) { }
        // RVA: -1  // generic def  token: 0x6000132
        public static Google.Protobuf.FieldCodec<T> ForClassWrapper(System.UInt32 tag) { }
        // RVA: -1  // generic def  token: 0x6000133
        public static Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper(System.UInt32 tag) { }

    }

    // TypeToken: 0x2000026
    public sealed class ValueReader`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x600017F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000180
        public virtual TValue Invoke(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // runtime  token: 0x6000181
        public virtual System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000182
        public virtual TValue EndInvoke(Google.Protobuf.ParseContext& ctx, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000027
    public sealed class ValueWriter`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000183
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000184
        public virtual System.Void Invoke(Google.Protobuf.WriteContext& ctx, T value) { }
        // RVA: -1  // runtime  token: 0x6000185
        public virtual System.IAsyncResult BeginInvoke(Google.Protobuf.WriteContext& ctx, T value, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000186
        public virtual System.Void EndInvoke(Google.Protobuf.WriteContext& ctx, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000028
    public sealed class FieldCodec`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<T> EqualityComparer;  // static @ 0x0
        private static readonly T DefaultDefault;  // static @ 0x0
        private static readonly System.Boolean TypeSupportsPacking;  // static @ 0x0
        private readonly System.Boolean <PackedRepeatedField>k__BackingField;  // 0x0
        private readonly Google.Protobuf.ValueWriter<T> <ValueWriter>k__BackingField;  // 0x0
        private readonly System.Func<T,System.Int32> <ValueSizeCalculator>k__BackingField;  // 0x0
        private readonly Google.Protobuf.ValueReader<T> <ValueReader>k__BackingField;  // 0x0
        private readonly Google.Protobuf.FieldCodec.InputMerger<T> <ValueMerger>k__BackingField;  // 0x0
        private readonly Google.Protobuf.FieldCodec.ValuesMerger<T> <FieldMerger>k__BackingField;  // 0x0
        private readonly System.Int32 <FixedSize>k__BackingField;  // 0x0
        private readonly System.UInt32 <Tag>k__BackingField;  // 0x0
        private readonly System.UInt32 <EndTag>k__BackingField;  // 0x0
        private readonly T <DefaultValue>k__BackingField;  // 0x0
        private readonly System.Int32 tagSize;  // 0x0

        // Properties
        System.Boolean PackedRepeatedField { get; /* RVA: -1  // not resolved */ }
        Google.Protobuf.ValueWriter<T> ValueWriter { get; /* RVA: -1  // not resolved */ }
        System.Func<T,System.Int32> ValueSizeCalculator { get; /* RVA: -1  // not resolved */ }
        Google.Protobuf.ValueReader<T> ValueReader { get; /* RVA: -1  // not resolved */ }
        Google.Protobuf.FieldCodec.InputMerger<T> ValueMerger { get; /* RVA: -1  // not resolved */ }
        Google.Protobuf.FieldCodec.ValuesMerger<T> FieldMerger { get; /* RVA: -1  // not resolved */ }
        System.Int32 FixedSize { get; /* RVA: -1  // not resolved */ }
        System.UInt32 Tag { get; /* RVA: -1  // not resolved */ }
        System.UInt32 EndTag { get; /* RVA: -1  // not resolved */ }
        T DefaultValue { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000187
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000188
        private static System.Boolean IsPackedRepeatedField(System.UInt32 tag) { }
        // RVA: -1  // not resolved  token: 0x6000193
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Int32 fixedSize, System.UInt32 tag, T defaultValue) { }
        // RVA: -1  // not resolved  token: 0x6000194
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, T defaultValue) { }
        // RVA: -1  // not resolved  token: 0x6000195
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag) { }
        // RVA: -1  // not resolved  token: 0x6000196
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag, T defaultValue) { }
        // RVA: -1  // not resolved  token: 0x6000197
        public System.Void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value) { }
        // RVA: -1  // not resolved  token: 0x6000198
        public System.Void WriteTagAndValue(Google.Protobuf.WriteContext& ctx, T value) { }
        // RVA: -1  // not resolved  token: 0x6000199
        public T Read(Google.Protobuf.CodedInputStream input) { }
        // RVA: -1  // not resolved  token: 0x600019A
        public T Read(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // not resolved  token: 0x600019B
        public System.Int32 CalculateSizeWithTag(T value) { }
        // RVA: -1  // not resolved  token: 0x600019C
        private System.Int32 CalculateUnconditionalSizeWithTag(T value) { }
        // RVA: -1  // not resolved  token: 0x600019D
        private System.Boolean IsDefault(T value) { }

    }

    // TypeToken: 0x200002E  // size: 0x18
    public sealed class FieldMaskTree
    {
        // Fields
        private static System.Char FIELD_PATH_SEPARATOR;  // const
        private readonly Google.Protobuf.FieldMaskTree.Node root;  // 0x10

        // Methods
        // RVA: 0x08543E34  token: 0x60001AD
        public System.Void .ctor() { }
        // RVA: 0x08543E98  token: 0x60001AE
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask mask) { }
        // RVA: 0x08543E0C  token: 0x60001AF
        public virtual System.String ToString() { }
        // RVA: 0x08542AD8  token: 0x60001B0
        public Google.Protobuf.FieldMaskTree AddFieldPath(System.String path) { }
        // RVA: 0x085431A8  token: 0x60001B1
        public Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask) { }
        // RVA: 0x08543CF4  token: 0x60001B2
        public Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask() { }
        // RVA: 0x08542C84  token: 0x60001B3
        private System.Void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, System.String path, System.Collections.Generic.List<System.String> paths) { }
        // RVA: 0x08542EA0  token: 0x60001B4
        public System.Void IntersectFieldPath(System.String path, Google.Protobuf.FieldMaskTree output) { }
        // RVA: 0x085432F4  token: 0x60001B5
        public System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }
        // RVA: 0x08543448  token: 0x60001B6
        private System.Void Merge(Google.Protobuf.FieldMaskTree.Node node, System.String path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public static class FrameworkPortability
    {
        // Fields
        private static readonly System.Text.RegularExpressions.RegexOptions CompiledRegexWhereAvailable;  // static @ 0x0

        // Methods
        // RVA: 0x08543F18  token: 0x60001B9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public interface IBufferMessage : Google.Protobuf.IMessage
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001BA
        public virtual System.Void InternalMergeFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: -1  // abstract  token: 0x60001BB
        public virtual System.Void InternalWriteTo(Google.Protobuf.WriteContext& ctx) { }

    }

    // TypeToken: 0x2000032
    public interface ICustomDiagnosticMessage : Google.Protobuf.IMessage
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001BC
        public virtual System.String ToDiagnosticString() { }

    }

    // TypeToken: 0x2000033
    public interface IDeepCloneable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001BD
        public virtual T Clone() { }

    }

    // TypeToken: 0x2000034
    public interface IExtendableMessage`1 : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001BE
        public virtual TValue GetExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        // RVA: -1  // abstract  token: 0x60001BF
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }
        // RVA: -1  // abstract  token: 0x60001C0
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }
        // RVA: -1  // abstract  token: 0x60001C1
        public virtual System.Void SetExtension(Google.Protobuf.Extension<T,TValue> extension, TValue value) { }
        // RVA: -1  // abstract  token: 0x60001C2
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        // RVA: -1  // abstract  token: 0x60001C3
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        // RVA: -1  // abstract  token: 0x60001C4
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }

    }

    // TypeToken: 0x2000035
    public interface IMessage
    {
        // Properties
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60001C5
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: -1  // abstract  token: 0x60001C6
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: -1  // abstract  token: 0x60001C7
        public virtual System.Int32 CalculateSize() { }

    }

    // TypeToken: 0x2000036
    public interface IMessage`1 : Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001C9
        public virtual System.Void MergeFrom(T message) { }

    }

    // TypeToken: 0x2000037  // size: 0x90
    public sealed class InvalidJsonException : System.IO.IOException
    {
        // Methods
        // RVA: 0x08543FE8  token: 0x60001CA
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000038  // size: 0x90
    public sealed class InvalidProtocolBufferException : System.IO.IOException
    {
        // Methods
        // RVA: 0x08543FE8  token: 0x60001CB
        private System.Void .ctor(System.String message) { }
        // RVA: 0x0854452C  token: 0x60001CC
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        // RVA: 0x08544338  token: 0x60001CD
        private static Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable() { }
        // RVA: 0x085444C8  token: 0x60001CE
        private static Google.Protobuf.InvalidProtocolBufferException TruncatedMessage() { }
        // RVA: 0x0854439C  token: 0x60001CF
        private static Google.Protobuf.InvalidProtocolBufferException NegativeSize() { }
        // RVA: 0x08544270  token: 0x60001D0
        private static Google.Protobuf.InvalidProtocolBufferException MalformedVarint() { }
        // RVA: 0x08544144  token: 0x60001D1
        private static Google.Protobuf.InvalidProtocolBufferException InvalidTag() { }
        // RVA: 0x085441A8  token: 0x60001D2
        private static Google.Protobuf.InvalidProtocolBufferException InvalidWireType() { }
        // RVA: 0x08544008  token: 0x60001D3
        private static Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException) { }
        // RVA: 0x0854407C  token: 0x60001D4
        private static Google.Protobuf.InvalidProtocolBufferException InvalidEndTag() { }
        // RVA: 0x08544400  token: 0x60001D5
        private static Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded() { }
        // RVA: 0x0854420C  token: 0x60001D6
        private static Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded() { }
        // RVA: 0x08544464  token: 0x60001D7
        private static Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded() { }
        // RVA: 0x085440E0  token: 0x60001D8
        private static Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag() { }
        // RVA: 0x085442D4  token: 0x60001D9
        private static Google.Protobuf.InvalidProtocolBufferException MissingFields() { }

    }

    // TypeToken: 0x2000039  // size: 0x18
    public sealed class JsonFormatter
    {
        // Fields
        private static System.String AnyTypeUrlField;  // const
        private static System.String AnyDiagnosticValueField;  // const
        private static System.String AnyWellKnownTypeValueField;  // const
        private static System.String TypeUrlPrefix;  // const
        private static System.String NameValueSeparator;  // const
        private static System.String PropertySeparator;  // const
        private static readonly Google.Protobuf.JsonFormatter <Default>k__BackingField;  // static @ 0x0
        private static readonly Google.Protobuf.JsonFormatter diagnosticFormatter;  // static @ 0x8
        private static readonly System.String[] CommonRepresentations;  // static @ 0x10
        private readonly Google.Protobuf.JsonFormatter.Settings settings;  // 0x10
        private static System.String Hex;  // const

        // Properties
        Google.Protobuf.JsonFormatter Default { get; /* RVA: 0x0854975C */ }
        System.Boolean DiagnosticOnly { get; /* RVA: 0x085497AC */ }

        // Methods
        // RVA: 0x0854854C  token: 0x60001DB
        private static System.Void .cctor() { }
        // RVA: 0x085496F4  token: 0x60001DD
        public System.Void .ctor(Google.Protobuf.JsonFormatter.Settings settings) { }
        // RVA: 0x08544534  token: 0x60001DE
        public System.String Format(Google.Protobuf.IMessage message) { }
        // RVA: 0x085445B8  token: 0x60001DF
        public System.Void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer) { }
        // RVA: 0x08544CE0  token: 0x60001E0
        public static System.String ToDiagnosticString(Google.Protobuf.IMessage message) { }
        // RVA: 0x08546D4C  token: 0x60001E1
        private System.Void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        // RVA: 0x08546A28  token: 0x60001E2
        private System.Boolean WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, System.Boolean assumeFirstFieldWritten) { }
        // RVA: 0x08544C34  token: 0x60001E3
        private System.Boolean ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, System.Object value) { }
        // RVA: 0x08544D6C  token: 0x60001E4
        private static System.String ToJsonName(System.String name) { }
        // RVA: 0x085446C8  token: 0x60001E5
        private static System.String FromJsonName(System.String name) { }
        // RVA: 0x08546EE8  token: 0x60001E6
        private static System.Void WriteNull(System.IO.TextWriter writer) { }
        // RVA: 0x085448E8  token: 0x60001E7
        private static System.Boolean IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, System.Object value) { }
        // RVA: 0x08547A94  token: 0x60001E8
        public System.Void WriteValue(System.IO.TextWriter writer, System.Object value) { }
        // RVA: 0x085480DC  token: 0x60001E9
        private System.Void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, System.Object value) { }
        // RVA: 0x08547908  token: 0x60001EA
        private System.Void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        // RVA: 0x0854654C  token: 0x60001EB
        private System.Void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        // RVA: 0x085466D8  token: 0x60001EC
        private System.Void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        // RVA: 0x08544E78  token: 0x60001ED
        private System.Void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        // RVA: 0x08545234  token: 0x60001EE
        private System.Void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        // RVA: 0x085474D8  token: 0x60001EF
        private System.Void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        // RVA: 0x08547258  token: 0x60001F0
        private System.Void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        // RVA: 0x085467E4  token: 0x60001F1
        private System.Void WriteList(System.IO.TextWriter writer, System.Collections.IList list) { }
        // RVA: 0x085454C0  token: 0x60001F2
        private System.Void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary) { }
        // RVA: 0x08546F34  token: 0x60001F3
        private static System.Void WriteString(System.IO.TextWriter writer, System.String text) { }
        // RVA: 0x085447CC  token: 0x60001F4
        private static System.Void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, System.Char c) { }

    }

    // TypeToken: 0x200003D  // size: 0x18
    public sealed class JsonParser
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex TimestampRegex;  // static @ 0x0
        private static readonly System.Text.RegularExpressions.Regex DurationRegex;  // static @ 0x8
        private static readonly System.Int32[] SubsecondScalingFactors;  // static @ 0x10
        private static readonly System.Char[] FieldMaskPathSeparators;  // static @ 0x18
        private static readonly Google.Protobuf.Reflection.EnumDescriptor NullValueDescriptor;  // static @ 0x20
        private static readonly Google.Protobuf.JsonParser defaultInstance;  // static @ 0x28
        private static readonly System.Collections.Generic.Dictionary<System.String,System.Action<Google.Protobuf.JsonParser,Google.Protobuf.IMessage,Google.Protobuf.JsonTokenizer>> WellKnownTypeHandlers;  // static @ 0x30
        private readonly Google.Protobuf.JsonParser.Settings settings;  // 0x10

        // Properties
        Google.Protobuf.JsonParser Default { get; /* RVA: 0x0854E660 */ }

        // Methods
        // RVA: 0x0854BA38  token: 0x600020B
        private static System.Void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854E5F8  token: 0x600020D
        public System.Void .ctor(Google.Protobuf.JsonParser.Settings settings) { }
        // RVA: 0x0854C074  token: 0x600020E
        private System.Void Merge(Google.Protobuf.IMessage message, System.String json) { }
        // RVA: 0x0854BF94  token: 0x600020F
        private System.Void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader) { }
        // RVA: 0x0854BAD4  token: 0x6000210
        private System.Void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854A6A0  token: 0x6000211
        private System.Void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854AAB0  token: 0x6000212
        private System.Void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854A824  token: 0x6000213
        private System.Void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08549A0C  token: 0x6000214
        private static System.Boolean IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        // RVA: 0x08549984  token: 0x6000215
        private static System.Boolean IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        // RVA: 0x0854D24C  token: 0x6000216
        private System.Object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: -1  // generic def  token: 0x6000217
        public T Parse(System.String json) { }
        // RVA: -1  // generic def  token: 0x6000218
        public T Parse(System.IO.TextReader jsonReader) { }
        // RVA: 0x0854D680  token: 0x6000219
        public Google.Protobuf.IMessage Parse(System.String json, Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: 0x0854D5B8  token: 0x600021A
        public Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: 0x0854AC98  token: 0x600021B
        private System.Void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854AFBC  token: 0x600021C
        private System.Void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x08549A8C  token: 0x600021D
        private System.Void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854B8D4  token: 0x600021E
        private System.Void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer) { }
        // RVA: 0x0854C12C  token: 0x600021F
        private static System.Object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, System.String keyText) { }
        // RVA: 0x0854C598  token: 0x6000220
        private static System.Object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token) { }
        // RVA: 0x085497F8  token: 0x6000221
        private static System.Void CheckInteger(System.Double value) { }
        // RVA: 0x0854CB7C  token: 0x6000222
        private static System.Object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, System.String text) { }
        // RVA: 0x0854C0FC  token: 0x6000223
        private static Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        // RVA: -1  // generic def  token: 0x6000224
        private static T ParseNumericString(System.String text, System.Func<System.String,System.Globalization.NumberStyles,System.IFormatProvider,T> parser) { }
        // RVA: 0x0854D914  token: 0x6000225
        private static System.Void ValidateInfinityAndNan(System.String text, System.Boolean isPositiveInfinity, System.Boolean isNegativeInfinity, System.Boolean isNaN) { }
        // RVA: 0x0854B0DC  token: 0x6000226
        private static System.Void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        // RVA: 0x08549EB8  token: 0x6000227
        private static System.Void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        // RVA: 0x0854A4D8  token: 0x6000228
        private static System.Void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        // RVA: 0x0854D764  token: 0x6000229
        private static System.String ToSnakeCase(System.String text) { }
        // RVA: 0x0854DA34  token: 0x600022A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x28
    public sealed class JsonToken : System.IEquatable`1
    {
        // Fields
        private static readonly Google.Protobuf.JsonToken _true;  // static @ 0x0
        private static readonly Google.Protobuf.JsonToken _false;  // static @ 0x8
        private static readonly Google.Protobuf.JsonToken _null;  // static @ 0x10
        private static readonly Google.Protobuf.JsonToken startObject;  // static @ 0x18
        private static readonly Google.Protobuf.JsonToken endObject;  // static @ 0x20
        private static readonly Google.Protobuf.JsonToken startArray;  // static @ 0x28
        private static readonly Google.Protobuf.JsonToken endArray;  // static @ 0x30
        private static readonly Google.Protobuf.JsonToken endDocument;  // static @ 0x38
        private readonly Google.Protobuf.JsonToken.TokenType type;  // 0x10
        private readonly System.String stringValue;  // 0x18
        private readonly System.Double numberValue;  // 0x20

        // Properties
        Google.Protobuf.JsonToken Null { get; /* RVA: 0x08550938 */ }
        Google.Protobuf.JsonToken False { get; /* RVA: 0x085508E8 */ }
        Google.Protobuf.JsonToken True { get; /* RVA: 0x08550A28 */ }
        Google.Protobuf.JsonToken StartObject { get; /* RVA: 0x085509D8 */ }
        Google.Protobuf.JsonToken EndObject { get; /* RVA: 0x08550898 */ }
        Google.Protobuf.JsonToken StartArray { get; /* RVA: 0x08550988 */ }
        Google.Protobuf.JsonToken EndArray { get; /* RVA: 0x085507F8 */ }
        Google.Protobuf.JsonToken EndDocument { get; /* RVA: 0x08550848 */ }
        Google.Protobuf.JsonToken.TokenType Type { get; /* RVA: 0x03D4E340 */ }
        System.String StringValue { get; /* RVA: 0x01041090 */ }
        System.Double NumberValue { get; /* RVA: 0x03D4F1C0 */ }

        // Methods
        // RVA: 0x08550170  token: 0x6000248
        private static Google.Protobuf.JsonToken Name(System.String name) { }
        // RVA: 0x0855047C  token: 0x6000249
        private static Google.Protobuf.JsonToken Value(System.String value) { }
        // RVA: 0x08550410  token: 0x600024A
        private static Google.Protobuf.JsonToken Value(System.Double value) { }
        // RVA: 0x085507D4  token: 0x600024E
        private System.Void .ctor(Google.Protobuf.JsonToken.TokenType type, System.String stringValue, System.Double numberValue) { }
        // RVA: 0x08550098  token: 0x600024F
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x085500FC  token: 0x6000250
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085501DC  token: 0x6000251
        public virtual System.String ToString() { }
        // RVA: 0x08550044  token: 0x6000252
        public virtual System.Boolean Equals(Google.Protobuf.JsonToken other) { }
        // RVA: 0x085504E8  token: 0x6000253
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x20
    public abstract class JsonTokenizer
    {
        // Fields
        private Google.Protobuf.JsonToken bufferedToken;  // 0x10
        private System.Int32 <ObjectDepth>k__BackingField;  // 0x18

        // Properties
        System.Int32 ObjectDepth { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x08550AE8  token: 0x6000254
        private static Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader) { }
        // RVA: 0x08550A78  token: 0x6000255
        private static Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation) { }
        // RVA: 0x08550BB8  token: 0x6000258
        private System.Void PushBack(Google.Protobuf.JsonToken token) { }
        // RVA: 0x08550B48  token: 0x6000259
        private Google.Protobuf.JsonToken Next() { }
        // RVA: -1  // abstract  token: 0x600025A
        protected virtual Google.Protobuf.JsonToken NextImpl() { }
        // RVA: 0x08550C50  token: 0x600025B
        private System.Void SkipValue() { }
        // RVA: 0x0350B670  token: 0x600025C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000048  // size: 0x38
    public sealed class LimitedInputStream : System.IO.Stream
    {
        // Fields
        private readonly System.IO.Stream proxied;  // 0x28
        private System.Int32 bytesLeft;  // 0x30

        // Properties
        System.Boolean CanRead { get; /* RVA: 0x0232EB60 */ }
        System.Boolean CanSeek { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean CanWrite { get; /* RVA: 0x0115F4C0 */ }
        System.Int64 Length { get; /* RVA: 0x08550E84 */ }
        System.Int64 Position { get; /* RVA: 0x08550ED0 */ set; /* RVA: 0x08550F1C */ }

        // Methods
        // RVA: 0x08550E24  token: 0x6000273
        private System.Void .ctor(System.IO.Stream proxied, System.Int32 size) { }
        // RVA: 0x0350B670  token: 0x6000277
        public virtual System.Void Flush() { }
        // RVA: 0x08550CA0  token: 0x600027B
        public virtual System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        // RVA: 0x08550D40  token: 0x600027C
        public virtual System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        // RVA: 0x08550D8C  token: 0x600027D
        public virtual System.Void SetLength(System.Int64 value) { }
        // RVA: 0x08550DD8  token: 0x600027E
        public virtual System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }

    }

    // TypeToken: 0x2000049  // size: 0x10
    public static class MessageExtensions
    {
        // Methods
        // RVA: 0x08551348  token: 0x600027F
        public static System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data) { }
        // RVA: 0x04272670  token: 0x6000280
        public static System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x08551210  token: 0x6000281
        public static System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data) { }
        // RVA: 0x08551230  token: 0x6000282
        public static System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input) { }
        // RVA: 0x0427262C  token: 0x6000283
        public static System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> span) { }
        // RVA: 0x085511F0  token: 0x6000284
        public static System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input) { }
        // RVA: 0x08551670  token: 0x6000285
        public static System.Byte[] ToByteArray(Google.Protobuf.IMessage message) { }
        // RVA: 0x024D1E10  token: 0x6000286
        public static System.Int32 WriteToByteArray(Google.Protobuf.IMessage message, System.Byte[] buffer, System.Int32 pos) { }
        // RVA: 0x085518E8  token: 0x6000287
        public static System.Void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output) { }
        // RVA: 0x085517DC  token: 0x6000288
        public static System.Void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output) { }
        // RVA: 0x08551760  token: 0x6000289
        public static Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message) { }
        // RVA: 0x08551AA8  token: 0x600028A
        public static System.Void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<System.Byte> output) { }
        // RVA: 0x085519D4  token: 0x600028B
        public static System.Void WriteTo(Google.Protobuf.IMessage message, System.Span<System.Byte> output) { }
        // RVA: 0x08550F68  token: 0x600028C
        public static System.Boolean IsInitialized(Google.Protobuf.IMessage message) { }
        // RVA: 0x08551368  token: 0x600028D
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x024D1780  token: 0x600028E
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x08551250  token: 0x600028F
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x08551484  token: 0x6000290
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x085515A4  token: 0x6000291
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x0307A230  token: 0x6000292
        private static System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x085510EC  token: 0x6000293
        private static System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004B  // size: 0x28
    public class MessageParser
    {
        // Fields
        private System.Func<Google.Protobuf.IMessage> factory;  // 0x10
        private readonly System.Boolean <DiscardUnknownFields>k__BackingField;  // 0x18
        private readonly Google.Protobuf.ExtensionRegistry <Extensions>k__BackingField;  // 0x20

        // Properties
        System.Boolean DiscardUnknownFields { get; /* RVA: 0x01002A50 */ }
        Google.Protobuf.ExtensionRegistry Extensions { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x03240600  token: 0x6000298
        private System.Void .ctor(System.Func<Google.Protobuf.IMessage> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions) { }
        // RVA: 0x08551BB0  token: 0x6000299
        private Google.Protobuf.IMessage CreateTemplate() { }
        // RVA: 0x08551F2C  token: 0x600029A
        public Google.Protobuf.IMessage ParseFrom(System.Byte[] data) { }
        // RVA: 0x08551DF0  token: 0x600029B
        public Google.Protobuf.IMessage ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x08551ED0  token: 0x600029C
        public Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data) { }
        // RVA: 0x08551E74  token: 0x600029D
        public Google.Protobuf.IMessage ParseFrom(System.IO.Stream input) { }
        // RVA: 0x08551FF0  token: 0x600029E
        public Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data) { }
        // RVA: 0x08551F88  token: 0x600029F
        public Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<System.Byte> data) { }
        // RVA: 0x08551D94  token: 0x60002A0
        public Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input) { }
        // RVA: 0x08552060  token: 0x60002A1
        public Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085520B4  token: 0x60002A2
        public Google.Protobuf.IMessage ParseJson(System.String json) { }
        // RVA: 0x08551BD0  token: 0x60002A3
        private System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput) { }
        // RVA: 0x08552130  token: 0x60002A4
        public Google.Protobuf.MessageParser WithDiscardUnknownFields(System.Boolean discardUnknownFields) { }
        // RVA: 0x085521B8  token: 0x60002A5
        public Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004C
    public sealed class MessageParser`1 : Google.Protobuf.MessageParser
    {
        // Fields
        private readonly System.Func<T> factory;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002A6
        public System.Void .ctor(System.Func<T> factory) { }
        // RVA: -1  // not resolved  token: 0x60002A7
        private System.Void .ctor(System.Func<T> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions) { }
        // RVA: -1  // not resolved  token: 0x60002A8
        private T CreateTemplate() { }
        // RVA: -1  // not resolved  token: 0x60002A9
        public T ParseFrom(System.Byte[] data) { }
        // RVA: -1  // not resolved  token: 0x60002AA
        public T ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        // RVA: -1  // not resolved  token: 0x60002AB
        public T ParseFrom(Google.Protobuf.ByteString data) { }
        // RVA: -1  // not resolved  token: 0x60002AC
        public T ParseFrom(System.IO.Stream input) { }
        // RVA: -1  // not resolved  token: 0x60002AD
        public T ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data) { }
        // RVA: -1  // not resolved  token: 0x60002AE
        public T ParseFrom(System.ReadOnlySpan<System.Byte> data) { }
        // RVA: -1  // not resolved  token: 0x60002AF
        public T ParseDelimitedFrom(System.IO.Stream input) { }
        // RVA: -1  // not resolved  token: 0x60002B0
        public T ParseFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: -1  // not resolved  token: 0x60002B1
        public T ParseJson(System.String json) { }
        // RVA: -1  // not resolved  token: 0x60002B2
        public Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(System.Boolean discardUnknownFields) { }
        // RVA: -1  // not resolved  token: 0x60002B3
        public Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004E
    public sealed struct ObjectIntPair`1 : System.IEquatable`1
    {
        // Fields
        private readonly System.Int32 number;  // 0x0
        private readonly T obj;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60002B6
        private System.Void .ctor(T obj, System.Int32 number) { }
        // RVA: -1  // not resolved  token: 0x60002B7
        public virtual System.Boolean Equals(Google.Protobuf.ObjectIntPair<T> other) { }
        // RVA: -1  // not resolved  token: 0x60002B8
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: -1  // not resolved  token: 0x60002B9
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200004F  // size: 0xA0
    public sealed struct ParseContext
    {
        // Fields
        private static System.Int32 DefaultRecursionLimit;  // const
        private static System.Int32 DefaultSizeLimit;  // const
        private System.ReadOnlySpan<System.Byte> buffer;  // 0x10
        private Google.Protobuf.ParserInternalState state;  // 0x20

        // Properties
        System.UInt32 LastTag { get; /* RVA: 0x03D4F0C0 */ }
        System.Boolean DiscardUnknownFields { get; /* RVA: 0x03D51AD0 */ set; /* RVA: 0x03D51B30 */ }
        Google.Protobuf.ExtensionRegistry ExtensionRegistry { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }

        // Methods
        // RVA: 0x08552A94  token: 0x60002BA
        private static System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x03D6BB50  token: 0x60002BB
        private static System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParserInternalState& state, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x085529C8  token: 0x60002BC
        private static System.Void Initialize(Google.Protobuf.CodedInputStream input, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855299C  token: 0x60002BD
        private static System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x085528E8  token: 0x60002BE
        private static System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, System.Int32 recursionLimit, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08552D44  token: 0x60002C4
        public System.UInt32 ReadTag() { }
        // RVA: 0x08552BF4  token: 0x60002C5
        public System.Double ReadDouble() { }
        // RVA: 0x08552C24  token: 0x60002C6
        public System.Single ReadFloat() { }
        // RVA: 0x08552C8C  token: 0x60002C7
        public System.UInt64 ReadUInt64() { }
        // RVA: 0x08552C8C  token: 0x60002C8
        public System.Int64 ReadInt64() { }
        // RVA: 0x08552C00  token: 0x60002C9
        public System.Int32 ReadInt32() { }
        // RVA: 0x08552C18  token: 0x60002CA
        public System.UInt64 ReadFixed64() { }
        // RVA: 0x08552C0C  token: 0x60002CB
        public System.UInt32 ReadFixed32() { }
        // RVA: 0x08552BCC  token: 0x60002CC
        public System.Boolean ReadBool() { }
        // RVA: 0x08552D38  token: 0x60002CD
        public System.String ReadString() { }
        // RVA: 0x08552C98  token: 0x60002CE
        public System.Void ReadMessage(Google.Protobuf.IMessage message) { }
        // RVA: 0x08552C30  token: 0x60002CF
        public System.Void ReadGroup(Google.Protobuf.IMessage message) { }
        // RVA: 0x08552BE8  token: 0x60002D0
        public Google.Protobuf.ByteString ReadBytes() { }
        // RVA: 0x08552C00  token: 0x60002D1
        public System.UInt32 ReadUInt32() { }
        // RVA: 0x08552C00  token: 0x60002D2
        public System.Int32 ReadEnum() { }
        // RVA: 0x08552C0C  token: 0x60002D3
        public System.Int32 ReadSFixed32() { }
        // RVA: 0x08552C18  token: 0x60002D4
        public System.Int64 ReadSFixed64() { }
        // RVA: 0x08552CF4  token: 0x60002D5
        public System.Int32 ReadSInt32() { }
        // RVA: 0x08552D14  token: 0x60002D6
        public System.Int64 ReadSInt64() { }
        // RVA: 0x08552C00  token: 0x60002D7
        public System.Int32 ReadLength() { }
        // RVA: 0x03171C20  token: 0x60002D8
        private System.Void CopyStateTo(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08552B58  token: 0x60002D9
        private System.Void LoadStateFrom(Google.Protobuf.CodedInputStream input) { }

    }

    // TypeToken: 0x2000050  // size: 0x90
    public sealed struct ParserInternalState
    {
        // Fields
        private System.Int32 bufferPos;  // 0x10
        private System.Int32 bufferSize;  // 0x14
        private System.Int32 bufferSizeAfterLimit;  // 0x18
        private System.Int32 currentLimit;  // 0x1c
        private System.Int32 totalBytesRetired;  // 0x20
        private System.Int32 recursionDepth;  // 0x24
        private Google.Protobuf.SegmentedBufferHelper segmentedBufferHelper;  // 0x28
        private System.UInt32 lastTag;  // 0x70
        private System.UInt32 nextTag;  // 0x74
        private System.Boolean hasNextTag;  // 0x78
        private System.Int32 sizeLimit;  // 0x7c
        private System.Int32 recursionLimit;  // 0x80
        private System.Boolean <DiscardUnknownFields>k__BackingField;  // 0x84
        private Google.Protobuf.ExtensionRegistry <ExtensionRegistry>k__BackingField;  // 0x88

        // Properties
        Google.Protobuf.CodedInputStream CodedInputStream { get; /* RVA: 0x03D4EAA0 */ }
        System.Boolean DiscardUnknownFields { get; /* RVA: 0x03D58980 */ set; /* RVA: 0x03D5BFE0 */ }
        Google.Protobuf.ExtensionRegistry ExtensionRegistry { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }

    }

    // TypeToken: 0x2000051  // size: 0x10
    public static class ParsingPrimitives
    {
        // Fields
        private static System.Int32 StackallocThreshold;  // const

        // Methods
        // RVA: 0x0855D2E0  token: 0x60002DF
        public static System.Int32 ParseLength(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023A7E60  token: 0x60002E0
        public static System.UInt32 ParseTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x02BCF140  token: 0x60002E1
        public static System.Boolean MaybeConsumeTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 tag) { }
        // RVA: 0x02BCF1A0  token: 0x60002E2
        public static System.UInt32 PeekTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023C4190  token: 0x60002E3
        public static System.UInt64 ParseRawVarint64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023C4290  token: 0x60002E4
        private static System.UInt64 ParseRawVarint64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023A7F80  token: 0x60002E5
        public static System.UInt32 ParseRawVarint32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023A8E70  token: 0x60002E6
        private static System.UInt32 ParseRawVarint32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D374  token: 0x60002E7
        public static System.UInt32 ParseRawLittleEndian32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D2E8  token: 0x60002E8
        private static System.UInt32 ParseRawLittleEndian32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D4FC  token: 0x60002E9
        public static System.UInt64 ParseRawLittleEndian64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D400  token: 0x60002EA
        private static System.UInt64 ParseRawLittleEndian64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x030E8410  token: 0x60002EB
        public static System.Double ParseDouble(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x02F802D0  token: 0x60002EC
        public static System.Single ParseFloat(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D1BC  token: 0x60002ED
        private static System.Single ParseFloatSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023BD010  token: 0x60002EE
        public static System.Byte[] ReadRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x0855D760  token: 0x60002EF
        private static System.Byte[] ReadRawBytesSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x0855DCD0  token: 0x60002F0
        public static System.Void SkipRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x0855DC9C  token: 0x60002F1
        public static System.String ReadString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855D588  token: 0x60002F2
        public static Google.Protobuf.ByteString ReadBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023BE5C0  token: 0x60002F3
        public static System.String ReadRawString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length) { }
        // RVA: 0x023BD690  token: 0x60002F4
        private static System.String ReadStringSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length) { }
        // RVA: 0x02FC8D50  token: 0x60002F5
        private static System.Void ValidateCurrentLimit(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x023A7E20  token: 0x60002F6
        private static System.Byte ReadRawByte(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855DBAC  token: 0x60002F7
        public static System.UInt32 ReadRawVarint32(System.IO.Stream input) { }
        // RVA: 0x03D6BBC0  token: 0x60002F8
        public static System.Int32 DecodeZigZag32(System.UInt32 n) { }
        // RVA: 0x03D6BBD0  token: 0x60002F9
        public static System.Int64 DecodeZigZag64(System.UInt64 n) { }
        // RVA: 0x031AB850  token: 0x60002FA
        public static System.Boolean IsDataAvailable(Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x0855D110  token: 0x60002FB
        private static System.Boolean IsDataAvailableInSource(Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        // RVA: 0x0855D5F8  token: 0x60002FC
        private static System.Void ReadRawBytesIntoSpan(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length, System.Span<System.Byte> byteSpan) { }

    }

    // TypeToken: 0x2000052  // size: 0x10
    public static class ParsingPrimitivesMessages
    {
        // Fields
        private static readonly System.Byte[] ZeroLengthMessageStreamData;  // static @ 0x0

        // Methods
        // RVA: 0x0855C5C0  token: 0x60002FD
        public static System.Void SkipLastField(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855C434  token: 0x60002FE
        public static System.Void SkipGroup(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 startGroupTag) { }
        // RVA: 0x023BF4C0  token: 0x60002FF
        public static System.Void ReadMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        // RVA: -1  // generic def  token: 0x6000300
        public static System.Collections.Generic.KeyValuePair<TKey,TValue> ReadMapEntry(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: 0x0855C2D8  token: 0x6000301
        public static System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        // RVA: 0x0855C380  token: 0x6000302
        public static System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, System.Int32 fieldNumber, Google.Protobuf.UnknownFieldSet set) { }
        // RVA: 0x023BF6D0  token: 0x6000303
        public static System.Void ReadRawMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        // RVA: 0x023BF690  token: 0x6000304
        public static System.Void CheckReadEndOfStreamTag(Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855C29C  token: 0x6000305
        private static System.Void CheckLastTagWas(Google.Protobuf.ParserInternalState& state, System.UInt32 expectedTag) { }
        // RVA: 0x03D05200  token: 0x6000306
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x10
    public static class ParsingPrimitivesWrappers
    {
        // Methods
        // RVA: 0x0855CA0C  token: 0x6000307
        private static System.Nullable<System.Single> ReadFloatWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CAD4  token: 0x6000308
        private static System.Nullable<System.Single> ReadFloatWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855C828  token: 0x6000309
        private static System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855C924  token: 0x600030A
        private static System.Nullable<System.Double> ReadDoubleWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855C75C  token: 0x600030B
        private static System.Nullable<System.Boolean> ReadBoolWrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CDF0  token: 0x600030C
        private static System.Nullable<System.UInt32> ReadUInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CD18  token: 0x600030D
        private static System.Nullable<System.UInt32> ReadUInt32WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CBCC  token: 0x600030E
        private static System.Nullable<System.Int32> ReadInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CFF0  token: 0x600030F
        private static System.Nullable<System.UInt64> ReadUInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CF0C  token: 0x6000310
        private static System.Nullable<System.UInt64> ReadUInt64WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CC78  token: 0x6000311
        private static System.Nullable<System.Int64> ReadInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855CAC8  token: 0x6000312
        private static System.Nullable<System.Single> ReadFloatWrapperLittleEndian(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855CBB4  token: 0x6000313
        private static System.Nullable<System.Single> ReadFloatWrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855C7FC  token: 0x6000314
        private static System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855C8F8  token: 0x6000315
        private static System.Nullable<System.Double> ReadDoubleWrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855C7F0  token: 0x6000316
        private static System.Nullable<System.Boolean> ReadBoolWrapper(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855CED4  token: 0x6000317
        private static System.Nullable<System.UInt32> ReadUInt32Wrapper(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855CBC0  token: 0x6000318
        private static System.Nullable<System.Int32> ReadInt32Wrapper(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855D0E4  token: 0x6000319
        private static System.Nullable<System.UInt64> ReadUInt64Wrapper(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855CEE0  token: 0x600031A
        private static System.Nullable<System.UInt64> ReadUInt64WrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0855CC4C  token: 0x600031B
        private static System.Nullable<System.Int64> ReadInt64Wrapper(Google.Protobuf.ParseContext& ctx) { }

    }

    // TypeToken: 0x2000054  // size: 0x10
    public static class ProtoPreconditions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x600031C
        public static T CheckNotNull(T value, System.String name) { }
        // RVA: -1  // generic def  token: 0x600031D
        private static T CheckNotNullUnconstrained(T value, System.String name) { }

    }

    // TypeToken: 0x2000055  // size: 0x58
    public sealed struct SegmentedBufferHelper
    {
        // Fields
        private System.Nullable<System.Int32> totalLength;  // 0x10
        private System.Buffers.ReadOnlySequence.Enumerator<System.Byte> readOnlySequenceEnumerator;  // 0x18
        private Google.Protobuf.CodedInputStream codedInputStream;  // 0x50

        // Properties
        System.Nullable<System.Int32> TotalLength { get; /* RVA: 0x020C61B0 */ }
        Google.Protobuf.CodedInputStream CodedInputStream { get; /* RVA: 0x03D4E2B0 */ }

        // Methods
        // RVA: 0x0855DD84  token: 0x600031E
        public static System.Void Initialize(Google.Protobuf.CodedInputStream codedInputStream, Google.Protobuf.SegmentedBufferHelper& instance) { }
        // RVA: 0x0855DE1C  token: 0x600031F
        public static System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> sequence, Google.Protobuf.SegmentedBufferHelper& instance, System.ReadOnlySpan<System.Byte>& firstSpan) { }
        // RVA: 0x023A9A00  token: 0x6000320
        public System.Boolean RefillBuffer(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        // RVA: 0x023BF600  token: 0x6000323
        public static System.Int32 PushLimit(Google.Protobuf.ParserInternalState& state, System.Int32 byteLimit) { }
        // RVA: 0x0426FC34  token: 0x6000324
        public static System.Void PopLimit(Google.Protobuf.ParserInternalState& state, System.Int32 oldLimit) { }
        // RVA: 0x023BF6B0  token: 0x6000325
        public static System.Boolean IsReachedLimit(Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x0855E014  token: 0x6000326
        public static System.Boolean IsAtEnd(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x031267E0  token: 0x6000327
        private System.Boolean RefillFromReadOnlySequence(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        // RVA: 0x023A9CB0  token: 0x6000328
        private System.Boolean RefillFromCodedInputStream(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        // RVA: 0x023BF660  token: 0x6000329
        private static System.Void RecomputeBufferSizeAfterLimit(Google.Protobuf.ParserInternalState& state) { }
        // RVA: 0x023A9D70  token: 0x600032A
        private static System.Void CheckCurrentBufferIsEmpty(Google.Protobuf.ParserInternalState& state) { }

    }

    // TypeToken: 0x2000056  // size: 0x38
    public sealed class UnknownField
    {
        // Fields
        private System.Collections.Generic.List<System.UInt64> varintList;  // 0x10
        private System.Collections.Generic.List<System.UInt32> fixed32List;  // 0x18
        private System.Collections.Generic.List<System.UInt64> fixed64List;  // 0x20
        private System.Collections.Generic.List<Google.Protobuf.ByteString> lengthDelimitedList;  // 0x28
        private System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet> groupList;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x600032B
        public System.Void .ctor() { }
        // RVA: 0x085638B4  token: 0x600032C
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085639B8  token: 0x600032D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085640B4  token: 0x600032E
        private System.Void WriteTo(System.Int32 fieldNumber, Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08563AA0  token: 0x600032F
        private System.Int32 GetSerializedSize(System.Int32 fieldNumber) { }
        // RVA: 0x08563FA4  token: 0x6000330
        private Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other) { }
        // RVA: -1  // generic def  token: 0x6000331
        private static System.Collections.Generic.List<T> AddAll(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras) { }
        // RVA: 0x08563858  token: 0x6000332
        private Google.Protobuf.UnknownField AddVarint(System.UInt64 value) { }
        // RVA: 0x085636EC  token: 0x6000333
        private Google.Protobuf.UnknownField AddFixed32(System.UInt32 value) { }
        // RVA: 0x08563744  token: 0x6000334
        private Google.Protobuf.UnknownField AddFixed64(System.UInt64 value) { }
        // RVA: 0x085637FC  token: 0x6000335
        private Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value) { }
        // RVA: 0x085637A0  token: 0x6000336
        private Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value) { }
        // RVA: -1  // generic def  token: 0x6000337
        private static System.Collections.Generic.List<T> Add(System.Collections.Generic.List<T> list, T value) { }

    }

    // TypeToken: 0x2000057  // size: 0x28
    public sealed class UnknownFieldSet
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.UnknownField> fields;  // 0x10
        private System.Int32 lastFieldNumber;  // 0x18
        private Google.Protobuf.UnknownField lastField;  // 0x20

        // Methods
        // RVA: 0x08563674  token: 0x6000338
        private System.Void .ctor() { }
        // RVA: 0x08562C34  token: 0x6000339
        private System.Boolean HasField(System.Int32 field) { }
        // RVA: 0x085633D8  token: 0x600033A
        public System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0856349C  token: 0x600033B
        public System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        // RVA: 0x085625F8  token: 0x600033C
        public System.Int32 CalculateSize() { }
        // RVA: 0x0856275C  token: 0x600033D
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085629E8  token: 0x600033E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08562B74  token: 0x600033F
        private Google.Protobuf.UnknownField GetOrAddField(System.Int32 number) { }
        // RVA: 0x08562530  token: 0x6000340
        private Google.Protobuf.UnknownFieldSet AddOrReplaceField(System.Int32 number, Google.Protobuf.UnknownField field) { }
        // RVA: 0x08562E70  token: 0x6000341
        private System.Boolean MergeFieldFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x0856338C  token: 0x6000342
        private System.Void MergeGroupFrom(Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x08562D84  token: 0x6000343
        public static Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08562C8C  token: 0x6000344
        public static Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.ParseContext& ctx) { }
        // RVA: 0x085631AC  token: 0x6000345
        private Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other) { }
        // RVA: 0x08563134  token: 0x6000346
        public static Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other) { }
        // RVA: 0x08563064  token: 0x6000347
        private Google.Protobuf.UnknownFieldSet MergeField(System.Int32 number, Google.Protobuf.UnknownField field) { }
        // RVA: 0x02F0D8A0  token: 0x6000348
        public static Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other) { }

    }

    // TypeToken: 0x2000058  // size: 0x10
    public static class UnsafeByteOperations
    {
        // Methods
        // RVA: 0x08564684  token: 0x6000349
        public static Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<System.Byte> bytes) { }

    }

    // TypeToken: 0x2000059  // size: 0x10
    public static class WireFormat
    {
        // Fields
        private static System.Int32 TagTypeBits;  // const
        private static System.UInt32 TagTypeMask;  // const

        // Methods
        // RVA: 0x03D6BBF0  token: 0x600034A
        public static Google.Protobuf.WireFormat.WireType GetTagWireType(System.UInt32 tag) { }
        // RVA: 0x03D6BBE0  token: 0x600034B
        public static System.Int32 GetTagFieldNumber(System.UInt32 tag) { }
        // RVA: 0x03D6BC00  token: 0x600034C
        public static System.UInt32 MakeTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType wireType) { }

    }

    // TypeToken: 0x200005B  // size: 0x20
    public sealed struct WriteBufferHelper
    {
        // Fields
        private System.Buffers.IBufferWriter<System.Byte> bufferWriter;  // 0x10
        private Google.Protobuf.CodedOutputStream codedOutputStream;  // 0x18

        // Properties
        Google.Protobuf.CodedOutputStream CodedOutputStream { get; /* RVA: 0x03D50DE0 */ }

        // Methods
        // RVA: 0x024D20C0  token: 0x600034E
        public static System.Void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, Google.Protobuf.WriteBufferHelper& instance) { }
        // RVA: 0x0853DCDC  token: 0x600034F
        public static System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> bufferWriter, Google.Protobuf.WriteBufferHelper& instance, System.Span<System.Byte>& buffer) { }
        // RVA: 0x0853DCB8  token: 0x6000350
        public static System.Void InitializeNonRefreshable(Google.Protobuf.WriteBufferHelper& instance) { }
        // RVA: 0x0853DB28  token: 0x6000351
        public static System.Void CheckNoSpaceLeft(Google.Protobuf.WriterInternalState& state) { }
        // RVA: 0x0853DC3C  token: 0x6000352
        public static System.Int32 GetSpaceLeft(Google.Protobuf.WriterInternalState& state) { }
        // RVA: 0x08565BF4  token: 0x6000353
        public static System.Void RefreshBuffer(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state) { }
        // RVA: 0x08565B4C  token: 0x6000354
        public static System.Void Flush(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state) { }

    }

    // TypeToken: 0x200005C  // size: 0x38
    public sealed struct WriteContext
    {
        // Fields
        private System.Span<System.Byte> buffer;  // 0x10
        private Google.Protobuf.WriterInternalState state;  // 0x20

        // Methods
        // RVA: 0x03D6BC10  token: 0x6000355
        private static System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.WriteContext& ctx) { }
        // RVA: 0x08565D84  token: 0x6000356
        private static System.Void Initialize(Google.Protobuf.CodedOutputStream output, Google.Protobuf.WriteContext& ctx) { }
        // RVA: 0x08565E00  token: 0x6000357
        private static System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> output, Google.Protobuf.WriteContext& ctx) { }
        // RVA: 0x08565D28  token: 0x6000358
        private static System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriteContext& ctx) { }
        // RVA: 0x033C0400  token: 0x6000359
        public System.Void WriteDouble(System.Double value) { }
        // RVA: 0x024D4440  token: 0x600035A
        public System.Void WriteFloat(System.Single value) { }
        // RVA: 0x024D4FF0  token: 0x600035B
        public System.Void WriteUInt64(System.UInt64 value) { }
        // RVA: 0x024D5100  token: 0x600035C
        public System.Void WriteInt64(System.Int64 value) { }
        // RVA: 0x024D4610  token: 0x600035D
        public System.Void WriteInt32(System.Int32 value) { }
        // RVA: 0x08565EE4  token: 0x600035E
        public System.Void WriteFixed64(System.UInt64 value) { }
        // RVA: 0x08565E90  token: 0x600035F
        public System.Void WriteFixed32(System.UInt32 value) { }
        // RVA: 0x033C0870  token: 0x6000360
        public System.Void WriteBool(System.Boolean value) { }
        // RVA: 0x024D52F0  token: 0x6000361
        public System.Void WriteString(System.String value) { }
        // RVA: 0x04270278  token: 0x6000362
        public System.Void WriteMessage(Google.Protobuf.IMessage value) { }
        // RVA: 0x08565F38  token: 0x6000363
        public System.Void WriteGroup(Google.Protobuf.IMessage value) { }
        // RVA: 0x03543420  token: 0x6000364
        public System.Void WriteBytes(Google.Protobuf.ByteString value) { }
        // RVA: 0x024D4680  token: 0x6000365
        public System.Void WriteUInt32(System.UInt32 value) { }
        // RVA: 0x024D48E0  token: 0x6000366
        public System.Void WriteEnum(System.Int32 value) { }
        // RVA: 0x085660CC  token: 0x6000367
        public System.Void WriteSFixed32(System.Int32 value) { }
        // RVA: 0x08566120  token: 0x6000368
        public System.Void WriteSFixed64(System.Int64 value) { }
        // RVA: 0x08566174  token: 0x6000369
        public System.Void WriteSInt32(System.Int32 value) { }
        // RVA: 0x085661C8  token: 0x600036A
        public System.Void WriteSInt64(System.Int64 value) { }
        // RVA: 0x0397C1E0  token: 0x600036B
        public System.Void WriteLength(System.Int32 length) { }
        // RVA: 0x0856621C  token: 0x600036C
        public System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        // RVA: 0x024D3390  token: 0x600036D
        public System.Void WriteTag(System.UInt32 tag) { }
        // RVA: 0x024D4230  token: 0x600036E
        public System.Void WriteRawTag(System.Byte b1) { }
        // RVA: 0x024D4E60  token: 0x600036F
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2) { }
        // RVA: 0x08565FC4  token: 0x6000370
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3) { }
        // RVA: 0x08565F40  token: 0x6000371
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        // RVA: 0x08566040  token: 0x6000372
        public System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        // RVA: 0x08565D1C  token: 0x6000373
        private System.Void Flush() { }
        // RVA: 0x08565D10  token: 0x6000374
        private System.Void CheckNoSpaceLeft() { }
        // RVA: 0x031C0BC0  token: 0x6000375
        private System.Void CopyStateTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08565E68  token: 0x6000376
        private System.Void LoadStateFrom(Google.Protobuf.CodedOutputStream output) { }

    }

    // TypeToken: 0x200005D  // size: 0x28
    public sealed struct WriterInternalState
    {
        // Fields
        private System.Int32 limit;  // 0x10
        private System.Int32 position;  // 0x14
        private Google.Protobuf.WriteBufferHelper writeBufferHelper;  // 0x18

        // Properties
        Google.Protobuf.CodedOutputStream CodedOutputStream { get; /* RVA: 0x020B7B20 */ }

    }

    // TypeToken: 0x200005E  // size: 0x10
    public static class WritingPrimitives
    {
        // Fields
        private static readonly System.Text.Encoding Utf8Encoding;  // static @ 0x0

        // Methods
        // RVA: 0x033C0470  token: 0x6000378
        public static System.Void WriteDouble(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Double value) { }
        // RVA: 0x024D44B0  token: 0x6000379
        public static System.Void WriteFloat(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value) { }
        // RVA: 0x08566628  token: 0x600037A
        private static System.Void WriteFloatSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value) { }
        // RVA: 0x024D5090  token: 0x600037B
        public static System.Void WriteUInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        // RVA: 0x024D51A0  token: 0x600037C
        public static System.Void WriteInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        // RVA: 0x024D4C40  token: 0x600037D
        public static System.Void WriteInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        // RVA: 0x085665C8  token: 0x600037E
        public static System.Void WriteFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        // RVA: 0x08566568  token: 0x600037F
        public static System.Void WriteFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        // RVA: 0x033C08E0  token: 0x6000380
        public static System.Void WriteBool(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Boolean value) { }
        // RVA: 0x024D5360  token: 0x6000381
        public static System.Void WriteString(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.String value) { }
        // RVA: 0x02D4A540  token: 0x6000382
        private static System.Void WriteAsciiStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value, System.Int32 length) { }
        // RVA: 0x085664E0  token: 0x6000383
        private static System.Void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(System.Byte& outputBuffer, System.UInt64 value) { }
        // RVA: 0x024D55A0  token: 0x6000384
        private static System.Int32 WriteStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value) { }
        // RVA: 0x03543490  token: 0x6000385
        public static System.Void WriteBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.ByteString value) { }
        // RVA: 0x024D47D0  token: 0x6000386
        public static System.Void WriteUInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        // RVA: 0x024D4AB0  token: 0x6000387
        public static System.Void WriteEnum(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        // RVA: 0x085670D4  token: 0x6000388
        public static System.Void WriteSFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        // RVA: 0x08567134  token: 0x6000389
        public static System.Void WriteSFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        // RVA: 0x08567194  token: 0x600038A
        public static System.Void WriteSInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        // RVA: 0x08567200  token: 0x600038B
        public static System.Void WriteSInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        // RVA: 0x024D3DD0  token: 0x600038C
        public static System.Void WriteLength(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 length) { }
        // RVA: 0x024D4D90  token: 0x600038D
        public static System.Void WriteRawVarint32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        // RVA: 0x024D5210  token: 0x600038E
        public static System.Void WriteRawVarint64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        // RVA: 0x085669A4  token: 0x600038F
        public static System.Void WriteRawLittleEndian32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        // RVA: 0x08566904  token: 0x6000390
        private static System.Void WriteRawLittleEndian32SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        // RVA: 0x033C0510  token: 0x6000391
        public static System.Void WriteRawLittleEndian64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        // RVA: 0x08566A60  token: 0x6000392
        public static System.Void WriteRawLittleEndian64SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        // RVA: 0x024D43D0  token: 0x6000393
        private static System.Void WriteRawByte(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte value) { }
        // RVA: 0x085667BC  token: 0x6000394
        public static System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value) { }
        // RVA: 0x08566860  token: 0x6000395
        public static System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value, System.Int32 offset, System.Int32 length) { }
        // RVA: 0x03543680  token: 0x6000396
        public static System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.ReadOnlySpan<System.Byte> value) { }
        // RVA: 0x0856726C  token: 0x6000397
        public static System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        // RVA: 0x024D3400  token: 0x6000398
        public static System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 tag) { }
        // RVA: 0x024D4320  token: 0x6000399
        public static System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1) { }
        // RVA: 0x024D4F40  token: 0x600039A
        public static System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2) { }
        // RVA: 0x08566D44  token: 0x600039B
        private static System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2) { }
        // RVA: 0x08566FF4  token: 0x600039C
        public static System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3) { }
        // RVA: 0x08566C0C  token: 0x600039D
        private static System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3) { }
        // RVA: 0x08566DC4  token: 0x600039E
        public static System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        // RVA: 0x08566CA0  token: 0x600039F
        private static System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        // RVA: 0x08566EC8  token: 0x60003A0
        public static System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        // RVA: 0x08566B54  token: 0x60003A1
        private static System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        // RVA: 0x03D6BC30  token: 0x60003A2
        public static System.UInt32 EncodeZigZag32(System.Int32 n) { }
        // RVA: 0x03D6BC40  token: 0x60003A3
        public static System.UInt64 EncodeZigZag64(System.Int64 n) { }
        // RVA: 0x03D26FB0  token: 0x60003A4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x10
    public static class WritingPrimitivesMessages
    {
        // Methods
        // RVA: 0x08566284  token: 0x60003A5
        public static System.Void WriteMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value) { }
        // RVA: 0x08565F38  token: 0x60003A6
        public static System.Void WriteGroup(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value) { }
        // RVA: 0x0856631C  token: 0x60003A7
        public static System.Void WriteRawMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage message) { }

    }

}

namespace Google.Protobuf.Collections
{

    // TypeToken: 0x200012E  // size: 0x10
    public static class Lists
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000C02
        public static System.Boolean Equals(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right) { }
        // RVA: -1  // generic def  token: 0x6000C03
        public static System.Int32 GetHashCode(System.Collections.Generic.List<T> list) { }

    }

    // TypeToken: 0x200012F
    public sealed class MapField`2 : Google.Protobuf.IDeepCloneable`1, System.Collections.Generic.IDictionary`2, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.IEquatable`1, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary`2, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<TValue> ValueEqualityComparer;  // static @ 0x0
        private static readonly System.Collections.Generic.EqualityComparer<TKey> KeyEqualityComparer;  // static @ 0x0
        private readonly System.Collections.Generic.Dictionary<TKey,System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey,TValue>>> map;  // 0x0
        private readonly System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey,TValue>> list;  // 0x0

        // Properties
        TValue Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TKey> Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TValue> Values { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.IDictionary.IsFixedSize { get; /* RVA: -1  // not resolved */ }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.ICollection System.Collections.IDictionary.Values { get; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IDictionary.Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C04
        public virtual Google.Protobuf.Collections.MapField<TKey,TValue> Clone() { }
        // RVA: -1  // not resolved  token: 0x6000C05
        public virtual System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000C06
        public virtual System.Boolean ContainsKey(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000C07
        private System.Boolean ContainsValue(TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000C08
        public virtual System.Boolean Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000C09
        public virtual System.Boolean TryGetValue(TKey key, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x6000C0E
        public System.Void Add(System.Collections.Generic.IDictionary<TKey,TValue> entries) { }
        // RVA: -1  // not resolved  token: 0x6000C0F
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C10
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C11
        private virtual System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C12
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000C13
        private virtual System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C14
        private virtual System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000C15
        private virtual System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C18
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: -1  // not resolved  token: 0x6000C19
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x6000C1A
        public virtual System.Boolean Equals(Google.Protobuf.Collections.MapField<TKey,TValue> other) { }
        // RVA: -1  // not resolved  token: 0x6000C1B
        public System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C1C
        public System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C1D
        public System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C1E
        public System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C1F
        public System.Int32 CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C20
        private static System.Int32 CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec, System.Collections.Generic.KeyValuePair<TKey,TValue> entry) { }
        // RVA: -1  // not resolved  token: 0x6000C21
        public virtual System.String ToString() { }
        // RVA: -1  // not resolved  token: 0x6000C22
        private virtual System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000C23
        private virtual System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        // RVA: -1  // not resolved  token: 0x6000C24
        private virtual System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C25
        private virtual System.Void System.Collections.IDictionary.Remove(System.Object key) { }
        // RVA: -1  // not resolved  token: 0x6000C26
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C30
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000C31
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000135  // size: 0x10
    public static class ProtobufEqualityComparers
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<System.Double> <BitwiseDoubleEqualityComparer>k__BackingField;  // static @ 0x0
        private static readonly System.Collections.Generic.EqualityComparer<System.Single> <BitwiseSingleEqualityComparer>k__BackingField;  // static @ 0x8
        private static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField;  // static @ 0x10
        private static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>> <BitwiseNullableSingleEqualityComparer>k__BackingField;  // static @ 0x18

        // Properties
        System.Collections.Generic.EqualityComparer<System.Double> BitwiseDoubleEqualityComparer { get; /* RVA: 0x08594BD0 */ }
        System.Collections.Generic.EqualityComparer<System.Single> BitwiseSingleEqualityComparer { get; /* RVA: 0x08594CC0 */ }
        System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>> BitwiseNullableDoubleEqualityComparer { get; /* RVA: 0x08594C20 */ }
        System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>> BitwiseNullableSingleEqualityComparer { get; /* RVA: 0x08594C70 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x6000C51
        public static System.Collections.Generic.EqualityComparer<T> GetEqualityComparer() { }
        // RVA: 0x039D7870  token: 0x6000C56
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200013A
    public sealed class ReadOnlyDictionary`2 : System.Collections.Generic.IDictionary`2, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<TKey,TValue> wrapped;  // 0x0

        // Properties
        System.Collections.Generic.ICollection<TKey> Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TValue> Values { get; /* RVA: -1  // not resolved */ }
        TValue Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C63
        public System.Void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> wrapped) { }
        // RVA: -1  // not resolved  token: 0x6000C64
        public virtual System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000C65
        public virtual System.Boolean ContainsKey(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000C67
        public virtual System.Boolean Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000C68
        public virtual System.Boolean TryGetValue(TKey key, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x6000C6C
        public virtual System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C6D
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000C6E
        public virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C6F
        public virtual System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000C72
        public virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000C73
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C74
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C75
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: -1  // not resolved  token: 0x6000C76
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x6000C77
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200013B
    public sealed class RepeatedField`1 : System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, Google.Protobuf.IDeepCloneable`1, System.IEquatable`1, System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<T> EqualityComparer;  // static @ 0x0
        private static readonly T[] EmptyArray;  // static @ 0x0
        private static System.Int32 MinArraySize;  // const
        private T[] array;  // 0x0
        private System.Int32 count;  // 0x0

        // Properties
        System.Int32 Capacity { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.IList.IsFixedSize { get; /* RVA: -1  // not resolved */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IList.Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C78
        public virtual Google.Protobuf.Collections.RepeatedField<T> Clone() { }
        // RVA: -1  // not resolved  token: 0x6000C79
        public System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C7A
        public System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C7B
        public System.Int32 CalculateSize(Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C7C
        private System.Int32 CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C7D
        public System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C7E
        public System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        // RVA: -1  // not resolved  token: 0x6000C81
        private System.Void EnsureSize(System.Int32 size) { }
        // RVA: -1  // not resolved  token: 0x6000C82
        private System.Void SetSize(System.Int32 size) { }
        // RVA: -1  // not resolved  token: 0x6000C83
        public System.Void SetCount(System.Int32 newCount) { }
        // RVA: -1  // not resolved  token: 0x6000C84
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C85
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000C86
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C87
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000C88
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C8B
        public System.Void AddRange(System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // not resolved  token: 0x6000C8C
        public System.Void Add(System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // not resolved  token: 0x6000C8D
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C8E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: -1  // not resolved  token: 0x6000C8F
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C90
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x6000C91
        public virtual System.Boolean Equals(Google.Protobuf.Collections.RepeatedField<T> other) { }
        // RVA: -1  // not resolved  token: 0x6000C92
        public virtual System.Int32 IndexOf(T item) { }
        // RVA: -1  // not resolved  token: 0x6000C93
        public virtual System.Void Insert(System.Int32 index, T item) { }
        // RVA: -1  // not resolved  token: 0x6000C94
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C95
        public virtual System.String ToString() { }
        // RVA: -1  // not resolved  token: 0x6000C99
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C9E
        private virtual System.Int32 System.Collections.IList.Add(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000C9F
        private virtual System.Boolean System.Collections.IList.Contains(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000CA0
        private virtual System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000CA1
        private virtual System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000CA2
        private virtual System.Void System.Collections.IList.Remove(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000CA3
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000CA4
        private static System.Void .cctor() { }

    }

}

namespace Google.Protobuf.Compatibility
{

    // TypeToken: 0x200012C  // size: 0x10
    public static class PropertyInfoExtensions
    {
        // Methods
        // RVA: 0x08594B30  token: 0x6000BFD
        private static System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target) { }
        // RVA: 0x08594B80  token: 0x6000BFE
        private static System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target) { }

    }

    // TypeToken: 0x200012D  // size: 0x10
    public static class TypeExtensions
    {
        // Methods
        // RVA: 0x08596940  token: 0x6000BFF
        private static System.Boolean IsAssignableFrom(System.Type target, System.Type c) { }
        // RVA: 0x0859682C  token: 0x6000C00
        private static System.Reflection.PropertyInfo GetProperty(System.Type target, System.String name) { }
        // RVA: 0x08596774  token: 0x6000C01
        private static System.Reflection.MethodInfo GetMethod(System.Type target, System.String name) { }

    }

}

namespace Google.Protobuf.Reflection
{

    // TypeToken: 0x20000A6  // size: 0x18
    public sealed class CustomOptions
    {
        // Fields
        private static System.String UnreferencedCodeMessage;  // const
        private static readonly System.Object[] EmptyParameters;  // static @ 0x0
        private readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000683
        private System.Void .ctor(System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values) { }
        // RVA: 0x085681B4  token: 0x6000684
        public System.Boolean TryGetBool(System.Int32 field, System.Boolean& value) { }
        // RVA: 0x08568324  token: 0x6000685
        public System.Boolean TryGetInt32(System.Int32 field, System.Int32& value) { }
        // RVA: 0x0856837C  token: 0x6000686
        public System.Boolean TryGetInt64(System.Int32 field, System.Int64& value) { }
        // RVA: 0x085682BC  token: 0x6000687
        public System.Boolean TryGetFixed32(System.Int32 field, System.UInt32& value) { }
        // RVA: 0x085682C4  token: 0x6000688
        public System.Boolean TryGetFixed64(System.Int32 field, System.UInt64& value) { }
        // RVA: 0x085683D4  token: 0x6000689
        public System.Boolean TryGetSFixed32(System.Int32 field, System.Int32& value) { }
        // RVA: 0x085683DC  token: 0x600068A
        public System.Boolean TryGetSFixed64(System.Int32 field, System.Int64& value) { }
        // RVA: 0x085683E4  token: 0x600068B
        public System.Boolean TryGetSInt32(System.Int32 field, System.Int32& value) { }
        // RVA: 0x0856843C  token: 0x600068C
        public System.Boolean TryGetSInt64(System.Int32 field, System.Int64& value) { }
        // RVA: 0x085684EC  token: 0x600068D
        public System.Boolean TryGetUInt32(System.Int32 field, System.UInt32& value) { }
        // RVA: 0x08568544  token: 0x600068E
        public System.Boolean TryGetUInt64(System.Int32 field, System.UInt64& value) { }
        // RVA: 0x085682CC  token: 0x600068F
        public System.Boolean TryGetFloat(System.Int32 field, System.Single& value) { }
        // RVA: 0x08568264  token: 0x6000690
        public System.Boolean TryGetDouble(System.Int32 field, System.Double& value) { }
        // RVA: 0x08568494  token: 0x6000691
        public System.Boolean TryGetString(System.Int32 field, System.String& value) { }
        // RVA: 0x0856820C  token: 0x6000692
        public System.Boolean TryGetBytes(System.Int32 field, Google.Protobuf.ByteString& value) { }
        // RVA: -1  // generic def  token: 0x6000693
        public System.Boolean TryGetMessage(System.Int32 field, T& value) { }
        // RVA: -1  // generic def  token: 0x6000694
        private System.Boolean TryGetPrimitiveValue(System.Int32 field, T& value) { }
        // RVA: 0x0856859C  token: 0x6000695
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A8  // size: 0x10
    public static class DescriptorReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x0856D514 */ }

        // Methods
        // RVA: 0x08569F38  token: 0x600069B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A9  // size: 0x20
    public sealed class FileDescriptorSet : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 FileFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> file_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> Parser { get; /* RVA: 0x08575A54 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085759F4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08575C18 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> File { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0857597C  token: 0x600069F
        public System.Void .ctor() { }
        // RVA: 0x085758F4  token: 0x60006A0
        public System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        // RVA: 0x08575580  token: 0x60006A1
        public virtual Google.Protobuf.Reflection.FileDescriptorSet Clone() { }
        // RVA: 0x085755E0  token: 0x60006A3
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08575644  token: 0x60006A4
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        // RVA: 0x0517BB20  token: 0x60006A5
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08575738  token: 0x60006A6
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60006A7
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08575B74  token: 0x60006A8
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085754EC  token: 0x60006A9
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085756C0  token: 0x60006AA
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        // RVA: 0x03D47500  token: 0x60006AB
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08575AA4  token: 0x60006AC
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08575784  token: 0x60006AD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AB  // size: 0x78
    public sealed class FileDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x18
        public static System.Int32 PackageFieldNumber;  // const
        private static readonly System.String PackageDefaultValue;  // static @ 0x10
        private System.String package_;  // 0x20
        public static System.Int32 DependencyFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_dependency_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> dependency_;  // 0x28
        public static System.Int32 PublicDependencyFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_publicDependency_codec;  // static @ 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> publicDependency_;  // 0x30
        public static System.Int32 WeakDependencyFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_weakDependency_codec;  // static @ 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> weakDependency_;  // 0x38
        public static System.Int32 MessageTypeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec;  // static @ 0x30
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> messageType_;  // 0x40
        public static System.Int32 EnumTypeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;  // static @ 0x38
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;  // 0x48
        public static System.Int32 ServiceFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec;  // static @ 0x40
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> service_;  // 0x50
        public static System.Int32 ExtensionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;  // static @ 0x48
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;  // 0x58
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.FileOptions options_;  // 0x60
        public static System.Int32 SourceCodeInfoFieldNumber;  // const
        private Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_;  // 0x68
        public static System.Int32 SyntaxFieldNumber;  // const
        private static readonly System.String SyntaxDefaultValue;  // static @ 0x50
        private System.String syntax_;  // 0x70

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> Parser { get; /* RVA: 0x08574C24 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08574B10 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08575374 */ }
        System.String Name { get; /* RVA: 0x08574B7C */ set; /* RVA: 0x085753B4 */ }
        System.Boolean HasName { get; /* RVA: 0x02702DB0 */ }
        System.String Package { get; /* RVA: 0x08574BD0 */ set; /* RVA: 0x0857541C */ }
        System.Boolean HasPackage { get; /* RVA: 0x08571E40 */ }
        Google.Protobuf.Collections.RepeatedField<System.String> Dependency { get; /* RVA: 0x03D4EAC0 */ }
        Google.Protobuf.Collections.RepeatedField<System.Int32> PublicDependency { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Collections.RepeatedField<System.Int32> WeakDependency { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> MessageType { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> EnumType { get; /* RVA: 0x03D4EA70 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> Service { get; /* RVA: 0x03D4EAF0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> Extension { get; /* RVA: 0x03D4EAA0 */ }
        Google.Protobuf.Reflection.FileOptions Options { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        Google.Protobuf.Reflection.SourceCodeInfo SourceCodeInfo { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        System.String Syntax { get; /* RVA: 0x08574C74 */ set; /* RVA: 0x08575484 */ }
        System.Boolean HasSyntax { get; /* RVA: 0x08574B70 */ }

        // Methods
        // RVA: 0x085748E8  token: 0x60006B4
        public System.Void .ctor() { }
        // RVA: 0x085746B8  token: 0x60006B5
        public System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        // RVA: 0x08573B3C  token: 0x60006B6
        public virtual Google.Protobuf.Reflection.FileDescriptorProto Clone() { }
        // RVA: 0x0364B0F0  token: 0x60006BA
        public System.Void ClearName() { }
        // RVA: 0x08571380  token: 0x60006BE
        public System.Void ClearPackage() { }
        // RVA: 0x08573B28  token: 0x60006CD
        public System.Void ClearSyntax() { }
        // RVA: 0x08573B9C  token: 0x60006CE
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08573C00  token: 0x60006CF
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        // RVA: 0x08573E54  token: 0x60006D0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08574288  token: 0x60006D1
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60006D2
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x085750AC  token: 0x60006D3
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08573848  token: 0x60006D4
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08573FF8  token: 0x60006D5
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x60006D6
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08574CC8  token: 0x60006D7
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085742D4  token: 0x60006D8
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x68
    public sealed class DescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x18
        public static System.Int32 FieldFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_field_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> field_;  // 0x20
        public static System.Int32 ExtensionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;  // 0x28
        public static System.Int32 NestedTypeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_nestedType_codec;  // static @ 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> nestedType_;  // 0x30
        public static System.Int32 EnumTypeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;  // static @ 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;  // 0x38
        public static System.Int32 ExtensionRangeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;  // static @ 0x30
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> extensionRange_;  // 0x40
        public static System.Int32 OneofDeclFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto> _repeated_oneofDecl_codec;  // static @ 0x38
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> oneofDecl_;  // 0x48
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.MessageOptions options_;  // 0x50
        public static System.Int32 ReservedRangeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;  // static @ 0x40
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> reservedRange_;  // 0x58
        public static System.Int32 ReservedNameFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_reservedName_codec;  // static @ 0x48
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> reservedName_;  // 0x60

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> Parser { get; /* RVA: 0x0856985C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085697A8 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08569E90 */ }
        System.String Name { get; /* RVA: 0x08569808 */ set; /* RVA: 0x08569ED0 */ }
        System.Boolean HasName { get; /* RVA: 0x02702DB0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> Field { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> Extension { get; /* RVA: 0x03D4EAC0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> NestedType { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> EnumType { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> ExtensionRange { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> OneofDecl { get; /* RVA: 0x03D4EA70 */ }
        Google.Protobuf.Reflection.MessageOptions Options { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> ReservedRange { get; /* RVA: 0x03D4EAA0 */ }
        Google.Protobuf.Collections.RepeatedField<System.String> ReservedName { get; /* RVA: 0x03D4EB00 */ }

        // Methods
        // RVA: 0x08569534  token: 0x60006DF
        public System.Void .ctor() { }
        // RVA: 0x08569328  token: 0x60006E0
        public System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto other) { }
        // RVA: 0x085688A0  token: 0x60006E1
        public virtual Google.Protobuf.Reflection.DescriptorProto Clone() { }
        // RVA: 0x0364B0F0  token: 0x60006E5
        public System.Void ClearName() { }
        // RVA: 0x08568B0C  token: 0x60006F0
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08568900  token: 0x60006F1
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto other) { }
        // RVA: 0x08568B70  token: 0x60006F2
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08568ED0  token: 0x60006F3
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60006F4
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08569C0C  token: 0x60006F5
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08568600  token: 0x60006F6
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08568CBC  token: 0x60006F7
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x60006F8
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085698AC  token: 0x60006F9
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08568F1C  token: 0x60006FA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000B4  // size: 0x28
    public sealed class ExtensionRangeOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions;  // 0x18
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x20

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> Parser { get; /* RVA: 0x0857061C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085705BC */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08570834 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x08570544  token: 0x600073C
        public System.Void .ctor() { }
        // RVA: 0x08570494  token: 0x600073D
        public System.Void .ctor(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        // RVA: 0x08570084  token: 0x600073E
        public virtual Google.Protobuf.Reflection.ExtensionRangeOptions Clone() { }
        // RVA: 0x08570174  token: 0x6000740
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085700E4  token: 0x6000741
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        // RVA: 0x085701D8  token: 0x6000742
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085702D8  token: 0x6000743
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000744
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0857076C  token: 0x6000745
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0856FFC8  token: 0x6000746
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08570240  token: 0x6000747
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        // RVA: 0x03D47500  token: 0x6000748
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0857066C  token: 0x6000749
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x600074A
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600074B
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600074C
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600074D
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x600074E
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600074F
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000750
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        // RVA: 0x08570324  token: 0x6000751
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000B6  // size: 0x70
    public sealed class FieldDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x20
        public static System.Int32 NumberFieldNumber;  // const
        private static readonly System.Int32 NumberDefaultValue;  // static @ 0x10
        private System.Int32 number_;  // 0x28
        public static System.Int32 LabelFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label LabelDefaultValue;  // static @ 0x14
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label label_;  // 0x2c
        public static System.Int32 TypeFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type TypeDefaultValue;  // static @ 0x18
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type_;  // 0x30
        public static System.Int32 TypeNameFieldNumber;  // const
        private static readonly System.String TypeNameDefaultValue;  // static @ 0x20
        private System.String typeName_;  // 0x38
        public static System.Int32 ExtendeeFieldNumber;  // const
        private static readonly System.String ExtendeeDefaultValue;  // static @ 0x28
        private System.String extendee_;  // 0x40
        public static System.Int32 DefaultValueFieldNumber;  // const
        private static readonly System.String DefaultValueDefaultValue;  // static @ 0x30
        private System.String defaultValue_;  // 0x48
        public static System.Int32 OneofIndexFieldNumber;  // const
        private static readonly System.Int32 OneofIndexDefaultValue;  // static @ 0x38
        private System.Int32 oneofIndex_;  // 0x50
        public static System.Int32 JsonNameFieldNumber;  // const
        private static readonly System.String JsonNameDefaultValue;  // static @ 0x40
        private System.String jsonName_;  // 0x58
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.FieldOptions options_;  // 0x60
        public static System.Int32 Proto3OptionalFieldNumber;  // const
        private static readonly System.Boolean Proto3OptionalDefaultValue;  // static @ 0x48
        private System.Boolean proto3Optional_;  // 0x68

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> Parser { get; /* RVA: 0x08572008 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08571D8C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08572598 */ }
        System.String Name { get; /* RVA: 0x08571F0C */ set; /* RVA: 0x08572710 */ }
        System.Boolean HasName { get; /* RVA: 0x08571E40 */ }
        System.Int32 Number { get; /* RVA: 0x08571F60 */ set; /* RVA: 0x03D6BCC0 */ }
        System.Boolean HasNumber { get; /* RVA: 0x02461A70 */ }
        Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Label { get; /* RVA: 0x08571EB8 */ set; /* RVA: 0x03D6BCB0 */ }
        System.Boolean HasLabel { get; /* RVA: 0x08570E90 */ }
        Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Type { get; /* RVA: 0x08572100 */ set; /* RVA: 0x03D6BCF0 */ }
        System.Boolean HasType { get; /* RVA: 0x08571E5C */ }
        System.String TypeName { get; /* RVA: 0x085720AC */ set; /* RVA: 0x08572778 */ }
        System.Boolean HasTypeName { get; /* RVA: 0x060DAC58 */ }
        System.String Extendee { get; /* RVA: 0x08571DEC */ set; /* RVA: 0x08572640 */ }
        System.Boolean HasExtendee { get; /* RVA: 0x02A794C0 */ }
        System.String DefaultValue { get; /* RVA: 0x08571D38 */ set; /* RVA: 0x085725D8 */ }
        System.Boolean HasDefaultValue { get; /* RVA: 0x05ED8890 */ }
        System.Int32 OneofIndex { get; /* RVA: 0x08571FB4 */ set; /* RVA: 0x03D6BCD0 */ }
        System.Boolean HasOneofIndex { get; /* RVA: 0x08571E4C */ }
        System.String JsonName { get; /* RVA: 0x08571E64 */ set; /* RVA: 0x085726A8 */ }
        System.Boolean HasJsonName { get; /* RVA: 0x05C72CF8 */ }
        Google.Protobuf.Reflection.FieldOptions Options { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        System.Boolean Proto3Optional { get; /* RVA: 0x08572058 */ set; /* RVA: 0x03D6BCE0 */ }
        System.Boolean HasProto3Optional { get; /* RVA: 0x08571E54 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000758
        public System.Void .ctor() { }
        // RVA: 0x08571C54  token: 0x6000759
        public System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        // RVA: 0x08571394  token: 0x600075A
        public virtual Google.Protobuf.Reflection.FieldDescriptorProto Clone() { }
        // RVA: 0x08571380  token: 0x600075E
        public System.Void ClearName() { }
        // RVA: 0x03D4F650  token: 0x6000762
        public System.Void ClearNumber() { }
        // RVA: 0x03D6BC50  token: 0x6000766
        public System.Void ClearLabel() { }
        // RVA: 0x03D6BCA0  token: 0x600076A
        public System.Void ClearType() { }
        // RVA: 0x05D62B50  token: 0x600076E
        public System.Void ClearTypeName() { }
        // RVA: 0x08571358  token: 0x6000772
        public System.Void ClearExtendee() { }
        // RVA: 0x05D6CFCC  token: 0x6000776
        public System.Void ClearDefaultValue() { }
        // RVA: 0x03D6BC80  token: 0x600077A
        public System.Void ClearOneofIndex() { }
        // RVA: 0x0857136C  token: 0x600077E
        public System.Void ClearJsonName() { }
        // RVA: 0x03D6BC90  token: 0x6000784
        public System.Void ClearProto3Optional() { }
        // RVA: 0x085713F4  token: 0x6000785
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08571458  token: 0x6000786
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        // RVA: 0x08571624  token: 0x6000787
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085719A0  token: 0x6000788
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000789
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08572394  token: 0x600078A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08571140  token: 0x600078B
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085717D4  token: 0x600078C
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x600078D
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08572154  token: 0x600078E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085719EC  token: 0x600078F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB  // size: 0x28
    public sealed class OneofDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x18
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.OneofOptions options_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> Parser { get; /* RVA: 0x08576D5C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08576CA8 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08576F20 */ }
        System.String Name { get; /* RVA: 0x08576D08 */ set; /* RVA: 0x08576F60 */ }
        System.Boolean HasName { get; /* RVA: 0x02702DB0 */ }
        Google.Protobuf.Reflection.OneofOptions Options { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000796
        public System.Void .ctor() { }
        // RVA: 0x08576C34  token: 0x6000797
        public System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        // RVA: 0x0857680C  token: 0x6000798
        public virtual Google.Protobuf.Reflection.OneofDescriptorProto Clone() { }
        // RVA: 0x0364B0F0  token: 0x600079C
        public System.Void ClearName() { }
        // RVA: 0x085768F0  token: 0x600079F
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857686C  token: 0x60007A0
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        // RVA: 0x08576954  token: 0x60007A1
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08576AA4  token: 0x60007A2
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60007A3
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08576EA0  token: 0x60007A4
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08576764  token: 0x60007A5
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085769C8  token: 0x60007A6
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x60007A7
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08576DAC  token: 0x60007A8
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08576AF0  token: 0x60007A9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD  // size: 0x40
    public sealed class EnumDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x18
        public static System.Int32 ValueFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> value_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.EnumOptions options_;  // 0x28
        public static System.Int32 ReservedRangeFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;  // 0x30
        public static System.Int32 ReservedNameFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_reservedName_codec;  // static @ 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> reservedName_;  // 0x38

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> Parser { get; /* RVA: 0x0856E490 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0856E3DC */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0856E83C */ }
        System.String Name { get; /* RVA: 0x0856E43C */ set; /* RVA: 0x0856E87C */ }
        System.Boolean HasName { get; /* RVA: 0x02702DB0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> Value { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Reflection.EnumOptions Options { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> ReservedRange { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Collections.RepeatedField<System.String> ReservedName { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x0856E1B0  token: 0x60007B0
        public System.Void .ctor() { }
        // RVA: 0x0856E2BC  token: 0x60007B1
        public System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        // RVA: 0x0856DB10  token: 0x60007B2
        public virtual Google.Protobuf.Reflection.EnumDescriptorProto Clone() { }
        // RVA: 0x0364B0F0  token: 0x60007B6
        public System.Void ClearName() { }
        // RVA: 0x0856DB70  token: 0x60007BC
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0856DBD4  token: 0x60007BD
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        // RVA: 0x0856DCF8  token: 0x60007BE
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0856DF18  token: 0x60007BF
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60007C0
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0856E6CC  token: 0x60007C1
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0856D988  token: 0x60007C2
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0856DDC4  token: 0x60007C3
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x60007C4
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0856E4E0  token: 0x60007C5
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0856DF64  token: 0x60007C6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C2  // size: 0x38
    public sealed class EnumValueDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x20
        public static System.Int32 NumberFieldNumber;  // const
        private static readonly System.Int32 NumberDefaultValue;  // static @ 0x10
        private System.Int32 number_;  // 0x28
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.EnumValueOptions options_;  // 0x30

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> Parser { get; /* RVA: 0x0857F554 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857F44C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857F76C */ }
        System.String Name { get; /* RVA: 0x0857F4AC */ set; /* RVA: 0x0857F7AC */ }
        System.Boolean HasName { get; /* RVA: 0x08571E40 */ }
        System.Int32 Number { get; /* RVA: 0x0857F500 */ set; /* RVA: 0x03D6BCC0 */ }
        System.Boolean HasNumber { get; /* RVA: 0x02461A70 */ }
        Google.Protobuf.Reflection.EnumValueOptions Options { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60007E9
        public System.Void .ctor() { }
        // RVA: 0x0857F3CC  token: 0x60007EA
        public System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        // RVA: 0x0857EF48  token: 0x60007EB
        public virtual Google.Protobuf.Reflection.EnumValueDescriptorProto Clone() { }
        // RVA: 0x08571380  token: 0x60007EF
        public System.Void ClearName() { }
        // RVA: 0x03D4F650  token: 0x60007F3
        public System.Void ClearNumber() { }
        // RVA: 0x0857EFA8  token: 0x60007F6
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857F00C  token: 0x60007F7
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        // RVA: 0x0857F0A8  token: 0x60007F8
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857F224  token: 0x60007F9
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60007FA
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0857F6C4  token: 0x60007FB
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857EE74  token: 0x60007FC
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0857F130  token: 0x60007FD
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x60007FE
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0857F5A4  token: 0x60007FF
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0857F270  token: 0x6000800
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C4  // size: 0x30
    public sealed class ServiceDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x18
        public static System.Int32 MethodFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> method_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.ServiceOptions options_;  // 0x28

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> Parser { get; /* RVA: 0x0858A1F8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858A144 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0858A48C */ }
        System.String Name { get; /* RVA: 0x0858A1A4 */ set; /* RVA: 0x0858A4CC */ }
        System.Boolean HasName { get; /* RVA: 0x02702DB0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> Method { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Reflection.ServiceOptions Options { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x0858A008  token: 0x6000807
        public System.Void .ctor() { }
        // RVA: 0x0858A080  token: 0x6000808
        public System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        // RVA: 0x08589AFC  token: 0x6000809
        public virtual Google.Protobuf.Reflection.ServiceDescriptorProto Clone() { }
        // RVA: 0x0364B0F0  token: 0x600080D
        public System.Void ClearName() { }
        // RVA: 0x08589C20  token: 0x6000811
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08589B5C  token: 0x6000812
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        // RVA: 0x08589C84  token: 0x6000813
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08589E10  token: 0x6000814
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000815
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0858A39C  token: 0x6000816
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085899FC  token: 0x6000817
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08589D0C  token: 0x6000818
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x6000819
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0858A248  token: 0x600081A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08589E5C  token: 0x600081B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C6  // size: 0x48
    public sealed class MethodDescriptorProto : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 NameFieldNumber;  // const
        private static readonly System.String NameDefaultValue;  // static @ 0x8
        private System.String name_;  // 0x20
        public static System.Int32 InputTypeFieldNumber;  // const
        private static readonly System.String InputTypeDefaultValue;  // static @ 0x10
        private System.String inputType_;  // 0x28
        public static System.Int32 OutputTypeFieldNumber;  // const
        private static readonly System.String OutputTypeDefaultValue;  // static @ 0x18
        private System.String outputType_;  // 0x30
        public static System.Int32 OptionsFieldNumber;  // const
        private Google.Protobuf.Reflection.MethodOptions options_;  // 0x38
        public static System.Int32 ClientStreamingFieldNumber;  // const
        private static readonly System.Boolean ClientStreamingDefaultValue;  // static @ 0x20
        private System.Boolean clientStreaming_;  // 0x40
        public static System.Int32 ServerStreamingFieldNumber;  // const
        private static readonly System.Boolean ServerStreamingDefaultValue;  // static @ 0x21
        private System.Boolean serverStreaming_;  // 0x41

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> Parser { get; /* RVA: 0x085879A8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858784C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08587CF8 */ }
        System.String Name { get; /* RVA: 0x08587900 */ set; /* RVA: 0x08587DA0 */ }
        System.Boolean HasName { get; /* RVA: 0x08571E40 */ }
        System.String InputType { get; /* RVA: 0x085878AC */ set; /* RVA: 0x08587D38 */ }
        System.Boolean HasInputType { get; /* RVA: 0x05693D38 */ }
        System.String OutputType { get; /* RVA: 0x08587954 */ set; /* RVA: 0x08587E08 */ }
        System.Boolean HasOutputType { get; /* RVA: 0x085839D0 */ }
        Google.Protobuf.Reflection.MethodOptions Options { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        System.Boolean ClientStreaming { get; /* RVA: 0x085877F8 */ set; /* RVA: 0x03D6BF10 */ }
        System.Boolean HasClientStreaming { get; /* RVA: 0x02461A70 */ }
        System.Boolean ServerStreaming { get; /* RVA: 0x085879F8 */ set; /* RVA: 0x03D6BF20 */ }
        System.Boolean HasServerStreaming { get; /* RVA: 0x08570E90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000822
        public System.Void .ctor() { }
        // RVA: 0x0858774C  token: 0x6000823
        public System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        // RVA: 0x085870D4  token: 0x6000824
        public virtual Google.Protobuf.Reflection.MethodDescriptorProto Clone() { }
        // RVA: 0x08571380  token: 0x6000828
        public System.Void ClearName() { }
        // RVA: 0x08254178  token: 0x600082C
        public System.Void ClearInputType() { }
        // RVA: 0x05572920  token: 0x6000830
        public System.Void ClearOutputType() { }
        // RVA: 0x03D4F650  token: 0x6000836
        public System.Void ClearClientStreaming() { }
        // RVA: 0x03D6BC50  token: 0x600083A
        public System.Void ClearServerStreaming() { }
        // RVA: 0x0858724C  token: 0x600083B
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08587134  token: 0x600083C
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        // RVA: 0x085872B0  token: 0x600083D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08587538  token: 0x600083E
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600083F
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08587BCC  token: 0x6000840
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08586FBC  token: 0x6000841
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085873F0  token: 0x6000842
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        // RVA: 0x03D47500  token: 0x6000843
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08587A4C  token: 0x6000844
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08587584  token: 0x6000845
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C8  // size: 0x90
    public sealed class FileOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 JavaPackageFieldNumber;  // const
        private static readonly System.String JavaPackageDefaultValue;  // static @ 0x8
        private System.String javaPackage_;  // 0x28
        public static System.Int32 JavaOuterClassnameFieldNumber;  // const
        private static readonly System.String JavaOuterClassnameDefaultValue;  // static @ 0x10
        private System.String javaOuterClassname_;  // 0x30
        public static System.Int32 JavaMultipleFilesFieldNumber;  // const
        private static readonly System.Boolean JavaMultipleFilesDefaultValue;  // static @ 0x18
        private System.Boolean javaMultipleFiles_;  // 0x38
        public static System.Int32 JavaGenerateEqualsAndHashFieldNumber;  // const
        private static readonly System.Boolean JavaGenerateEqualsAndHashDefaultValue;  // static @ 0x19
        private System.Boolean javaGenerateEqualsAndHash_;  // 0x39
        public static System.Int32 JavaStringCheckUtf8FieldNumber;  // const
        private static readonly System.Boolean JavaStringCheckUtf8DefaultValue;  // static @ 0x1a
        private System.Boolean javaStringCheckUtf8_;  // 0x3a
        public static System.Int32 OptimizeForFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeForDefaultValue;  // static @ 0x1c
        private Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode optimizeFor_;  // 0x3c
        public static System.Int32 GoPackageFieldNumber;  // const
        private static readonly System.String GoPackageDefaultValue;  // static @ 0x20
        private System.String goPackage_;  // 0x40
        public static System.Int32 CcGenericServicesFieldNumber;  // const
        private static readonly System.Boolean CcGenericServicesDefaultValue;  // static @ 0x28
        private System.Boolean ccGenericServices_;  // 0x48
        public static System.Int32 JavaGenericServicesFieldNumber;  // const
        private static readonly System.Boolean JavaGenericServicesDefaultValue;  // static @ 0x29
        private System.Boolean javaGenericServices_;  // 0x49
        public static System.Int32 PyGenericServicesFieldNumber;  // const
        private static readonly System.Boolean PyGenericServicesDefaultValue;  // static @ 0x2a
        private System.Boolean pyGenericServices_;  // 0x4a
        public static System.Int32 PhpGenericServicesFieldNumber;  // const
        private static readonly System.Boolean PhpGenericServicesDefaultValue;  // static @ 0x2b
        private System.Boolean phpGenericServices_;  // 0x4b
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x2c
        private System.Boolean deprecated_;  // 0x4c
        public static System.Int32 CcEnableArenasFieldNumber;  // const
        private static readonly System.Boolean CcEnableArenasDefaultValue;  // static @ 0x2d
        private System.Boolean ccEnableArenas_;  // 0x4d
        public static System.Int32 ObjcClassPrefixFieldNumber;  // const
        private static readonly System.String ObjcClassPrefixDefaultValue;  // static @ 0x30
        private System.String objcClassPrefix_;  // 0x50
        public static System.Int32 CsharpNamespaceFieldNumber;  // const
        private static readonly System.String CsharpNamespaceDefaultValue;  // static @ 0x38
        private System.String csharpNamespace_;  // 0x58
        public static System.Int32 SwiftPrefixFieldNumber;  // const
        private static readonly System.String SwiftPrefixDefaultValue;  // static @ 0x40
        private System.String swiftPrefix_;  // 0x60
        public static System.Int32 PhpClassPrefixFieldNumber;  // const
        private static readonly System.String PhpClassPrefixDefaultValue;  // static @ 0x48
        private System.String phpClassPrefix_;  // 0x68
        public static System.Int32 PhpNamespaceFieldNumber;  // const
        private static readonly System.String PhpNamespaceDefaultValue;  // static @ 0x50
        private System.String phpNamespace_;  // 0x70
        public static System.Int32 PhpMetadataNamespaceFieldNumber;  // const
        private static readonly System.String PhpMetadataNamespaceDefaultValue;  // static @ 0x58
        private System.String phpMetadataNamespace_;  // 0x78
        public static System.Int32 RubyPackageFieldNumber;  // const
        private static readonly System.String RubyPackageDefaultValue;  // static @ 0x60
        private System.String rubyPackage_;  // 0x80
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x68
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x88

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> Parser { get; /* RVA: 0x08583CAC */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08583910 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08584794 */ }
        System.String JavaPackage { get; /* RVA: 0x08583B5C */ set; /* RVA: 0x0858490C */ }
        System.Boolean HasJavaPackage { get; /* RVA: 0x05693D38 */ }
        System.String JavaOuterClassname { get; /* RVA: 0x08583B08 */ set; /* RVA: 0x085848A4 */ }
        System.Boolean HasJavaOuterClassname { get; /* RVA: 0x085839D0 */ }
        System.Boolean JavaMultipleFiles { get; /* RVA: 0x08583AB4 */ set; /* RVA: 0x03D6BEA0 */ }
        System.Boolean HasJavaMultipleFiles { get; /* RVA: 0x0857E548 */ }
        System.Boolean JavaGenerateEqualsAndHash { get; /* RVA: 0x08583A0C */ set; /* RVA: 0x03D6BE80 */ }
        System.Boolean HasJavaGenerateEqualsAndHash { get; /* RVA: 0x08581D24 */ }
        System.Boolean JavaStringCheckUtf8 { get; /* RVA: 0x08583BB0 */ set; /* RVA: 0x03D6BEB0 */ }
        System.Boolean HasJavaStringCheckUtf8 { get; /* RVA: 0x085839DC */ }
        Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeFor { get; /* RVA: 0x08583C58 */ set; /* RVA: 0x03D6BEC0 */ }
        System.Boolean HasOptimizeFor { get; /* RVA: 0x0857E540 */ }
        System.String GoPackage { get; /* RVA: 0x08583970 */ set; /* RVA: 0x0858483C */ }
        System.Boolean HasGoPackage { get; /* RVA: 0x02A794C0 */ }
        System.Boolean CcGenericServices { get; /* RVA: 0x08583814 */ set; /* RVA: 0x03D6BE60 */ }
        System.Boolean HasCcGenericServices { get; /* RVA: 0x08581D04 */ }
        System.Boolean JavaGenericServices { get; /* RVA: 0x08583A60 */ set; /* RVA: 0x03D6BE90 */ }
        System.Boolean HasJavaGenericServices { get; /* RVA: 0x08581D14 */ }
        System.Boolean PyGenericServices { get; /* RVA: 0x08583E50 */ set; /* RVA: 0x03D6BEE0 */ }
        System.Boolean HasPyGenericServices { get; /* RVA: 0x08581D0C */ }
        System.Boolean PhpGenericServices { get; /* RVA: 0x08583D50 */ set; /* RVA: 0x03D6BED0 */ }
        System.Boolean HasPhpGenericServices { get; /* RVA: 0x03874860 */ }
        System.Boolean Deprecated { get; /* RVA: 0x085838BC */ set; /* RVA: 0x03D6BE70 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x08581D1C */ }
        System.Boolean CcEnableArenas { get; /* RVA: 0x085837BC */ set; /* RVA: 0x03D6BE50 */ }
        System.Boolean HasCcEnableArenas { get; /* RVA: 0x085839C4 */ }
        System.String ObjcClassPrefix { get; /* RVA: 0x08583C04 */ set; /* RVA: 0x08584974 */ }
        System.Boolean HasObjcClassPrefix { get; /* RVA: 0x02B84230 */ }
        System.String CsharpNamespace { get; /* RVA: 0x08583868 */ set; /* RVA: 0x085847D4 */ }
        System.Boolean HasCsharpNamespace { get; /* RVA: 0x05C72CF8 */ }
        System.String SwiftPrefix { get; /* RVA: 0x08583EFC */ set; /* RVA: 0x08584B80 */ }
        System.Boolean HasSwiftPrefix { get; /* RVA: 0x05B08B40 */ }
        System.String PhpClassPrefix { get; /* RVA: 0x08583CFC */ set; /* RVA: 0x085849DC */ }
        System.Boolean HasPhpClassPrefix { get; /* RVA: 0x085839E8 */ }
        System.String PhpNamespace { get; /* RVA: 0x08583DFC */ set; /* RVA: 0x08584AAC */ }
        System.Boolean HasPhpNamespace { get; /* RVA: 0x08574B70 */ }
        System.String PhpMetadataNamespace { get; /* RVA: 0x08583DA8 */ set; /* RVA: 0x08584A44 */ }
        System.Boolean HasPhpMetadataNamespace { get; /* RVA: 0x085839F4 */ }
        System.String RubyPackage { get; /* RVA: 0x08583EA4 */ set; /* RVA: 0x08584B14 */ }
        System.Boolean HasRubyPackage { get; /* RVA: 0x08583A00 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EA60 */ }

        // Methods
        // RVA: 0x0858358C  token: 0x600084D
        public System.Void .ctor() { }
        // RVA: 0x08583608  token: 0x600084E
        public System.Void .ctor(Google.Protobuf.Reflection.FileOptions other) { }
        // RVA: 0x085826A0  token: 0x600084F
        public virtual Google.Protobuf.Reflection.FileOptions Clone() { }
        // RVA: 0x08254178  token: 0x6000853
        public System.Void ClearJavaPackage() { }
        // RVA: 0x05572920  token: 0x6000857
        public System.Void ClearJavaOuterClassname() { }
        // RVA: 0x03D6BD30  token: 0x600085B
        public System.Void ClearJavaMultipleFiles() { }
        // RVA: 0x03D6BDA0  token: 0x600085F
        public System.Void ClearJavaGenerateEqualsAndHash() { }
        // RVA: 0x03D6BE30  token: 0x6000863
        public System.Void ClearJavaStringCheckUtf8() { }
        // RVA: 0x03D6BD20  token: 0x6000867
        public System.Void ClearOptimizeFor() { }
        // RVA: 0x08571358  token: 0x600086B
        public System.Void ClearGoPackage() { }
        // RVA: 0x03D6BD60  token: 0x600086F
        public System.Void ClearCcGenericServices() { }
        // RVA: 0x03D6BD80  token: 0x6000873
        public System.Void ClearJavaGenericServices() { }
        // RVA: 0x03D6BD70  token: 0x6000877
        public System.Void ClearPyGenericServices() { }
        // RVA: 0x03D6BE40  token: 0x600087B
        public System.Void ClearPhpGenericServices() { }
        // RVA: 0x03D6BD90  token: 0x600087F
        public System.Void ClearDeprecated() { }
        // RVA: 0x03D6BE20  token: 0x6000883
        public System.Void ClearCcEnableArenas() { }
        // RVA: 0x05D62B3C  token: 0x6000887
        public System.Void ClearObjcClassPrefix() { }
        // RVA: 0x0857136C  token: 0x600088B
        public System.Void ClearCsharpNamespace() { }
        // RVA: 0x05755F70  token: 0x600088F
        public System.Void ClearSwiftPrefix() { }
        // RVA: 0x08582664  token: 0x6000893
        public System.Void ClearPhpClassPrefix() { }
        // RVA: 0x08573B28  token: 0x6000897
        public System.Void ClearPhpNamespace() { }
        // RVA: 0x08582678  token: 0x600089B
        public System.Void ClearPhpMetadataNamespace() { }
        // RVA: 0x0858268C  token: 0x600089F
        public System.Void ClearRubyPackage() { }
        // RVA: 0x08582700  token: 0x60008A1
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08582764  token: 0x60008A2
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.FileOptions other) { }
        // RVA: 0x08582AF4  token: 0x60008A3
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0858312C  token: 0x60008A4
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60008A5
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08584334  token: 0x60008A6
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0858232C  token: 0x60008A7
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08582E5C  token: 0x60008A8
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.FileOptions other) { }
        // RVA: 0x03D47500  token: 0x60008A9
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08583F50  token: 0x60008AA
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x60008AB
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008AC
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008AD
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008AE
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x60008AF
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008B0
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008B1
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        // RVA: 0x08583178  token: 0x60008B2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC  // size: 0x30
    public sealed class MessageOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 MessageSetWireFormatFieldNumber;  // const
        private static readonly System.Boolean MessageSetWireFormatDefaultValue;  // static @ 0x8
        private System.Boolean messageSetWireFormat_;  // 0x24
        public static System.Int32 NoStandardDescriptorAccessorFieldNumber;  // const
        private static readonly System.Boolean NoStandardDescriptorAccessorDefaultValue;  // static @ 0x9
        private System.Boolean noStandardDescriptorAccessor_;  // 0x25
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0xa
        private System.Boolean deprecated_;  // 0x26
        public static System.Int32 MapEntryFieldNumber;  // const
        private static readonly System.Boolean MapEntryDefaultValue;  // static @ 0xb
        private System.Boolean mapEntry_;  // 0x27
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x28

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> Parser { get; /* RVA: 0x08586C54 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08586AF8 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08586F7C */ }
        System.Boolean MessageSetWireFormat { get; /* RVA: 0x08586BAC */ set; /* RVA: 0x03D6BD40 */ }
        System.Boolean HasMessageSetWireFormat { get; /* RVA: 0x0857E540 */ }
        System.Boolean NoStandardDescriptorAccessor { get; /* RVA: 0x08586C00 */ set; /* RVA: 0x03D6BD50 */ }
        System.Boolean HasNoStandardDescriptorAccessor { get; /* RVA: 0x0857E548 */ }
        System.Boolean Deprecated { get; /* RVA: 0x08586AA4 */ set; /* RVA: 0x03D6BEF0 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x08581D04 */ }
        System.Boolean MapEntry { get; /* RVA: 0x08586B58 */ set; /* RVA: 0x03D6BF00 */ }
        System.Boolean HasMapEntry { get; /* RVA: 0x08581D14 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x08586A2C  token: 0x60008BA
        public System.Void .ctor() { }
        // RVA: 0x08586960  token: 0x60008BB
        public System.Void .ctor(Google.Protobuf.Reflection.MessageOptions other) { }
        // RVA: 0x085863A0  token: 0x60008BC
        public virtual Google.Protobuf.Reflection.MessageOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x60008C0
        public System.Void ClearMessageSetWireFormat() { }
        // RVA: 0x03D6BD30  token: 0x60008C4
        public System.Void ClearNoStandardDescriptorAccessor() { }
        // RVA: 0x03D6BD60  token: 0x60008C8
        public System.Void ClearDeprecated() { }
        // RVA: 0x03D6BD80  token: 0x60008CC
        public System.Void ClearMapEntry() { }
        // RVA: 0x08586400  token: 0x60008CE
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08586464  token: 0x60008CF
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.MessageOptions other) { }
        // RVA: 0x08586578  token: 0x60008D0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08586784  token: 0x60008D1
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60008D2
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08586E0C  token: 0x60008D3
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085862B8  token: 0x60008D4
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0858668C  token: 0x60008D5
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.MessageOptions other) { }
        // RVA: 0x03D47500  token: 0x60008D6
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08586CA4  token: 0x60008D7
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x60008D8
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008D9
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008DA
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008DB
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x60008DC
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008DD
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60008DE
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        // RVA: 0x085867D0  token: 0x60008DF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000CE  // size: 0x40
    public sealed class FieldOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 CtypeFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.FieldOptions.Types.CType CtypeDefaultValue;  // static @ 0x8
        private Google.Protobuf.Reflection.FieldOptions.Types.CType ctype_;  // 0x24
        public static System.Int32 PackedFieldNumber;  // const
        private static readonly System.Boolean PackedDefaultValue;  // static @ 0xc
        private System.Boolean packed_;  // 0x28
        public static System.Int32 JstypeFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.FieldOptions.Types.JSType JstypeDefaultValue;  // static @ 0x10
        private Google.Protobuf.Reflection.FieldOptions.Types.JSType jstype_;  // 0x2c
        public static System.Int32 LazyFieldNumber;  // const
        private static readonly System.Boolean LazyDefaultValue;  // static @ 0x14
        private System.Boolean lazy_;  // 0x30
        public static System.Int32 UnverifiedLazyFieldNumber;  // const
        private static readonly System.Boolean UnverifiedLazyDefaultValue;  // static @ 0x15
        private System.Boolean unverifiedLazy_;  // 0x31
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x16
        private System.Boolean deprecated_;  // 0x32
        public static System.Int32 WeakFieldNumber;  // const
        private static readonly System.Boolean WeakDefaultValue;  // static @ 0x17
        private System.Boolean weak_;  // 0x33
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x38

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> Parser { get; /* RVA: 0x08581E28 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08581CA4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085822EC */ }
        Google.Protobuf.Reflection.FieldOptions.Types.CType Ctype { get; /* RVA: 0x08581BFC */ set; /* RVA: 0x03D6BDB0 */ }
        System.Boolean HasCtype { get; /* RVA: 0x0857E540 */ }
        System.Boolean Packed { get; /* RVA: 0x08581DD4 */ set; /* RVA: 0x03D6BDF0 */ }
        System.Boolean HasPacked { get; /* RVA: 0x0857E548 */ }
        Google.Protobuf.Reflection.FieldOptions.Types.JSType Jstype { get; /* RVA: 0x08581D2C */ set; /* RVA: 0x03D6BDD0 */ }
        System.Boolean HasJstype { get; /* RVA: 0x08581D0C */ }
        System.Boolean Lazy { get; /* RVA: 0x08581D80 */ set; /* RVA: 0x03D6BDE0 */ }
        System.Boolean HasLazy { get; /* RVA: 0x08581D14 */ }
        System.Boolean UnverifiedLazy { get; /* RVA: 0x08581E78 */ set; /* RVA: 0x03D6BE00 */ }
        System.Boolean HasUnverifiedLazy { get; /* RVA: 0x08581D1C */ }
        System.Boolean Deprecated { get; /* RVA: 0x08581C50 */ set; /* RVA: 0x03D6BDC0 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x08581D04 */ }
        System.Boolean Weak { get; /* RVA: 0x08581ECC */ set; /* RVA: 0x03D6BE10 */ }
        System.Boolean HasWeak { get; /* RVA: 0x08581D24 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x08581B84  token: 0x60008E7
        public System.Void .ctor() { }
        // RVA: 0x08581AA0  token: 0x60008E8
        public System.Void .ctor(Google.Protobuf.Reflection.FieldOptions other) { }
        // RVA: 0x085813C8  token: 0x60008E9
        public virtual Google.Protobuf.Reflection.FieldOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x60008ED
        public System.Void ClearCtype() { }
        // RVA: 0x03D6BD30  token: 0x60008F1
        public System.Void ClearPacked() { }
        // RVA: 0x03D6BD70  token: 0x60008F5
        public System.Void ClearJstype() { }
        // RVA: 0x03D6BD80  token: 0x60008F9
        public System.Void ClearLazy() { }
        // RVA: 0x03D6BD90  token: 0x60008FD
        public System.Void ClearUnverifiedLazy() { }
        // RVA: 0x03D6BD60  token: 0x6000901
        public System.Void ClearDeprecated() { }
        // RVA: 0x03D6BDA0  token: 0x6000905
        public System.Void ClearWeak() { }
        // RVA: 0x08581428  token: 0x6000907
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0858148C  token: 0x6000908
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.FieldOptions other) { }
        // RVA: 0x085815F8  token: 0x6000909
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08581890  token: 0x600090A
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600090B
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x085820FC  token: 0x600090C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08581260  token: 0x600090D
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08581750  token: 0x600090E
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.FieldOptions other) { }
        // RVA: 0x03D47500  token: 0x600090F
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08581F20  token: 0x6000910
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x6000911
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000912
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000913
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000914
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x6000915
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000916
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000917
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        // RVA: 0x085818DC  token: 0x6000918
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D3  // size: 0x28
    public sealed class OneofOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> _extensions;  // 0x18
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x20

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> Parser { get; /* RVA: 0x085897A4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08589744 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085899BC */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x085896CC  token: 0x6000920
        public System.Void .ctor() { }
        // RVA: 0x0858961C  token: 0x6000921
        public System.Void .ctor(Google.Protobuf.Reflection.OneofOptions other) { }
        // RVA: 0x08589274  token: 0x6000922
        public virtual Google.Protobuf.Reflection.OneofOptions Clone() { }
        // RVA: 0x08589364  token: 0x6000924
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085892D4  token: 0x6000925
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.OneofOptions other) { }
        // RVA: 0x085701D8  token: 0x6000926
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08589460  token: 0x6000927
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000928
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x085898F4  token: 0x6000929
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085891B8  token: 0x600092A
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085893C8  token: 0x600092B
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.OneofOptions other) { }
        // RVA: 0x03D47500  token: 0x600092C
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085897F4  token: 0x600092D
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x600092E
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600092F
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000930
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000931
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x6000932
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000933
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000934
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        // RVA: 0x085894AC  token: 0x6000935
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D5  // size: 0x30
    public sealed class EnumOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 AllowAliasFieldNumber;  // const
        private static readonly System.Boolean AllowAliasDefaultValue;  // static @ 0x8
        private System.Boolean allowAlias_;  // 0x24
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x9
        private System.Boolean deprecated_;  // 0x25
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x28

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> Parser { get; /* RVA: 0x0857E550 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857E4E0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857E7F0 */ }
        System.Boolean AllowAlias { get; /* RVA: 0x0857E438 */ set; /* RVA: 0x03D6BD40 */ }
        System.Boolean HasAllowAlias { get; /* RVA: 0x0857E540 */ }
        System.Boolean Deprecated { get; /* RVA: 0x0857E48C */ set; /* RVA: 0x03D6BD50 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x0857E548 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x0857E3C0  token: 0x600093D
        public System.Void .ctor() { }
        // RVA: 0x0857E300  token: 0x600093E
        public System.Void .ctor(Google.Protobuf.Reflection.EnumOptions other) { }
        // RVA: 0x0857DDF4  token: 0x600093F
        public virtual Google.Protobuf.Reflection.EnumOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x6000943
        public System.Void ClearAllowAlias() { }
        // RVA: 0x03D6BD30  token: 0x6000947
        public System.Void ClearDeprecated() { }
        // RVA: 0x0857DE54  token: 0x6000949
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857DEB8  token: 0x600094A
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.EnumOptions other) { }
        // RVA: 0x0857DF8C  token: 0x600094B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857E124  token: 0x600094C
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600094D
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0857E6D4  token: 0x600094E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857DD1C  token: 0x600094F
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0857E05C  token: 0x6000950
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.EnumOptions other) { }
        // RVA: 0x03D47500  token: 0x6000951
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0857E5A0  token: 0x6000952
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x6000953
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000954
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000955
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000956
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x6000957
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000958
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000959
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        // RVA: 0x0857E170  token: 0x600095A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D7  // size: 0x30
    public sealed class EnumValueOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x8
        private System.Boolean deprecated_;  // 0x24
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x28

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> Parser { get; /* RVA: 0x08580180 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08580120 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085803DC */ }
        System.Boolean Deprecated { get; /* RVA: 0x085800CC */ set; /* RVA: 0x03D6BD40 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x0857E540 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x08580054  token: 0x6000962
        public System.Void .ctor() { }
        // RVA: 0x0857FF98  token: 0x6000963
        public System.Void .ctor(Google.Protobuf.Reflection.EnumValueOptions other) { }
        // RVA: 0x0857FAF4  token: 0x6000964
        public virtual Google.Protobuf.Reflection.EnumValueOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x6000968
        public System.Void ClearDeprecated() { }
        // RVA: 0x0857FB54  token: 0x600096A
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0857FBB8  token: 0x600096B
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.EnumValueOptions other) { }
        // RVA: 0x0857FC6C  token: 0x600096C
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857FDC8  token: 0x600096D
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600096E
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x085802E8  token: 0x600096F
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857FA28  token: 0x6000970
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0857FD18  token: 0x6000971
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other) { }
        // RVA: 0x03D47500  token: 0x6000972
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085801D0  token: 0x6000973
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x6000974
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000975
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000976
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000977
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x6000978
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000979
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600097A
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        // RVA: 0x0857FE14  token: 0x600097B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D9  // size: 0x30
    public sealed class ServiceOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x8
        private System.Boolean deprecated_;  // 0x24
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x28

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> Parser { get; /* RVA: 0x0858AC9C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858AC3C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0858AF00 */ }
        System.Boolean Deprecated { get; /* RVA: 0x0858ABE8 */ set; /* RVA: 0x03D6BD40 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x0857E540 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x0858AAB4  token: 0x6000983
        public System.Void .ctor() { }
        // RVA: 0x0858AB2C  token: 0x6000984
        public System.Void .ctor(Google.Protobuf.Reflection.ServiceOptions other) { }
        // RVA: 0x0858A610  token: 0x6000985
        public virtual Google.Protobuf.Reflection.ServiceOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x6000989
        public System.Void ClearDeprecated() { }
        // RVA: 0x0858A724  token: 0x600098B
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0858A670  token: 0x600098C
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.ServiceOptions other) { }
        // RVA: 0x0858A788  token: 0x600098D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0858A8E4  token: 0x600098E
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600098F
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0858AE08  token: 0x6000990
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0858A534  token: 0x6000991
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0858A834  token: 0x6000992
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other) { }
        // RVA: 0x03D47500  token: 0x6000993
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0858ACEC  token: 0x6000994
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x6000995
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000996
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000997
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x6000998
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x6000999
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600099A
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x600099B
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        // RVA: 0x0858A930  token: 0x600099C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000DB  // size: 0x38
    public sealed class MethodOptions : Google.Protobuf.IExtendableMessage`1, Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> _extensions;  // 0x18
        private System.Int32 _hasBits0;  // 0x20
        public static System.Int32 DeprecatedFieldNumber;  // const
        private static readonly System.Boolean DeprecatedDefaultValue;  // static @ 0x8
        private System.Boolean deprecated_;  // 0x24
        public static System.Int32 IdempotencyLevelFieldNumber;  // const
        private static readonly Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue;  // static @ 0xc
        private Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel idempotencyLevel_;  // 0x28
        public static System.Int32 UninterpretedOptionFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;  // 0x30

        // Properties
        Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> _Extensions { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> Parser { get; /* RVA: 0x085886C0 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858860C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08588970 */ }
        System.Boolean Deprecated { get; /* RVA: 0x085885B8 */ set; /* RVA: 0x03D6BD40 */ }
        System.Boolean HasDeprecated { get; /* RVA: 0x0857E540 */ }
        Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyLevel { get; /* RVA: 0x0858866C */ set; /* RVA: 0x03D6BF30 */ }
        System.Boolean HasIdempotencyLevel { get; /* RVA: 0x0857E548 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption { get; /* RVA: 0x01003830 */ }

        // Methods
        // RVA: 0x08588540  token: 0x60009A4
        public System.Void .ctor() { }
        // RVA: 0x08588480  token: 0x60009A5
        public System.Void .ctor(Google.Protobuf.Reflection.MethodOptions other) { }
        // RVA: 0x08587F84  token: 0x60009A6
        public virtual Google.Protobuf.Reflection.MethodOptions Clone() { }
        // RVA: 0x03D6BD20  token: 0x60009AA
        public System.Void ClearDeprecated() { }
        // RVA: 0x03D6BD30  token: 0x60009AE
        public System.Void ClearIdempotencyLevel() { }
        // RVA: 0x08587FE4  token: 0x60009B0
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08588048  token: 0x60009B1
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.MethodOptions other) { }
        // RVA: 0x0858811C  token: 0x60009B2
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085882A0  token: 0x60009B3
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60009B4
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0858884C  token: 0x60009B5
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08587E70  token: 0x60009B6
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085881D8  token: 0x60009B7
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.MethodOptions other) { }
        // RVA: 0x03D47500  token: 0x60009B8
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08588710  token: 0x60009B9
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: -1  // generic def  token: 0x60009BA
        public virtual TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60009BB
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60009BC
        public virtual Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60009BD
        public virtual System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension, TValue value) { }
        // RVA: -1  // generic def  token: 0x60009BE
        public virtual System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60009BF
        public virtual System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: -1  // generic def  token: 0x60009C0
        public virtual System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        // RVA: 0x085882EC  token: 0x60009C1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000DF  // size: 0x58
    public sealed class UninterpretedOption : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        private System.Int32 _hasBits0;  // 0x18
        public static System.Int32 NameFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _repeated_name_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> name_;  // 0x20
        public static System.Int32 IdentifierValueFieldNumber;  // const
        private static readonly System.String IdentifierValueDefaultValue;  // static @ 0x10
        private System.String identifierValue_;  // 0x28
        public static System.Int32 PositiveIntValueFieldNumber;  // const
        private static readonly System.UInt64 PositiveIntValueDefaultValue;  // static @ 0x18
        private System.UInt64 positiveIntValue_;  // 0x30
        public static System.Int32 NegativeIntValueFieldNumber;  // const
        private static readonly System.Int64 NegativeIntValueDefaultValue;  // static @ 0x20
        private System.Int64 negativeIntValue_;  // 0x38
        public static System.Int32 DoubleValueFieldNumber;  // const
        private static readonly System.Double DoubleValueDefaultValue;  // static @ 0x28
        private System.Double doubleValue_;  // 0x40
        public static System.Int32 StringValueFieldNumber;  // const
        private static readonly Google.Protobuf.ByteString StringValueDefaultValue;  // static @ 0x30
        private Google.Protobuf.ByteString stringValue_;  // 0x48
        public static System.Int32 AggregateValueFieldNumber;  // const
        private static readonly System.String AggregateValueDefaultValue;  // static @ 0x38
        private System.String aggregateValue_;  // 0x50

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> Parser { get; /* RVA: 0x0858D144 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858CF90 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0858D5BC */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> Name { get; /* RVA: 0x03D4EB40 */ }
        System.String IdentifierValue { get; /* RVA: 0x0858D098 */ set; /* RVA: 0x0858D664 */ }
        System.Boolean HasIdentifierValue { get; /* RVA: 0x05693D38 */ }
        System.UInt64 PositiveIntValue { get; /* RVA: 0x0858D194 */ set; /* RVA: 0x03D6BF70 */ }
        System.Boolean HasPositiveIntValue { get; /* RVA: 0x02461A70 */ }
        System.Int64 NegativeIntValue { get; /* RVA: 0x0858D0EC */ set; /* RVA: 0x03D6BF60 */ }
        System.Boolean HasNegativeIntValue { get; /* RVA: 0x08570E90 */ }
        System.Double DoubleValue { get; /* RVA: 0x0858CFF0 */ set; /* RVA: 0x03D6BF50 */ }
        System.Boolean HasDoubleValue { get; /* RVA: 0x08571E5C */ }
        Google.Protobuf.ByteString StringValue { get; /* RVA: 0x0858D1EC */ set; /* RVA: 0x0858D6CC */ }
        System.Boolean HasStringValue { get; /* RVA: 0x0858D048 */ }
        System.String AggregateValue { get; /* RVA: 0x0858CF3C */ set; /* RVA: 0x0858D5FC */ }
        System.Boolean HasAggregateValue { get; /* RVA: 0x02B84230 */ }

        // Methods
        // RVA: 0x0858CEC4  token: 0x60009C8
        public System.Void .ctor() { }
        // RVA: 0x0858CDE4  token: 0x60009C9
        public System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption other) { }
        // RVA: 0x0858C604  token: 0x60009CA
        public virtual Google.Protobuf.Reflection.UninterpretedOption Clone() { }
        // RVA: 0x08254178  token: 0x60009CF
        public System.Void ClearIdentifierValue() { }
        // RVA: 0x03D4F650  token: 0x60009D3
        public System.Void ClearPositiveIntValue() { }
        // RVA: 0x03D6BC50  token: 0x60009D7
        public System.Void ClearNegativeIntValue() { }
        // RVA: 0x03D6BCA0  token: 0x60009DB
        public System.Void ClearDoubleValue() { }
        // RVA: 0x05D6CFCC  token: 0x60009DF
        public System.Void ClearStringValue() { }
        // RVA: 0x05D62B3C  token: 0x60009E3
        public System.Void ClearAggregateValue() { }
        // RVA: 0x0858C664  token: 0x60009E4
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0858C6C8  token: 0x60009E5
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption other) { }
        // RVA: 0x0858C8A0  token: 0x60009E6
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0858CB3C  token: 0x60009E7
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60009E8
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0858D408  token: 0x60009E9
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0858C454  token: 0x60009EA
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0858CA10  token: 0x60009EB
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other) { }
        // RVA: 0x03D47500  token: 0x60009EC
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0858D240  token: 0x60009ED
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0858CB88  token: 0x60009EE
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E4  // size: 0x20
    public sealed class SourceCodeInfo : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 LocationFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _repeated_location_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> location_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> Parser { get; /* RVA: 0x0858B4A8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0858B448 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0858B66C */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> Location { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0858B348  token: 0x6000A11
        public System.Void .ctor() { }
        // RVA: 0x0858B3C0  token: 0x6000A12
        public System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        // RVA: 0x0858AFD4  token: 0x6000A13
        public virtual Google.Protobuf.Reflection.SourceCodeInfo Clone() { }
        // RVA: 0x0858B0B0  token: 0x6000A15
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0858B034  token: 0x6000A16
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        // RVA: 0x0517BB20  token: 0x6000A17
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0858B18C  token: 0x6000A18
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000A19
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0858B5C8  token: 0x6000A1A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0858AF40  token: 0x6000A1B
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0858B114  token: 0x6000A1C
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        // RVA: 0x03D47500  token: 0x6000A1D
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0858B4F8  token: 0x6000A1E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0858B1D8  token: 0x6000A1F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E9  // size: 0x20
    public sealed class GeneratedCodeInfo : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 AnnotationFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _repeated_annotation_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> annotation_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> Parser { get; /* RVA: 0x08585150 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085850F0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08585314 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> Annotation { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x08585078  token: 0x6000A45
        public System.Void .ctor() { }
        // RVA: 0x08584FF0  token: 0x6000A46
        public System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        // RVA: 0x08584C7C  token: 0x6000A47
        public virtual Google.Protobuf.Reflection.GeneratedCodeInfo Clone() { }
        // RVA: 0x08584CDC  token: 0x6000A49
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08584D40  token: 0x6000A4A
        public virtual System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        // RVA: 0x0517BB20  token: 0x6000A4B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08584E34  token: 0x6000A4C
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000A4D
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08585270  token: 0x6000A4E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08584BE8  token: 0x6000A4F
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08584DBC  token: 0x6000A50
        public virtual System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        // RVA: 0x03D47500  token: 0x6000A51
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085851A0  token: 0x6000A52
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08584E80  token: 0x6000A53
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000EE  // size: 0x28
    public abstract class DescriptorBase : Google.Protobuf.Reflection.IDescriptor
    {
        // Fields
        private readonly System.Int32 <Index>k__BackingField;  // 0x10
        private readonly System.String <FullName>k__BackingField;  // 0x18
        private readonly Google.Protobuf.Reflection.FileDescriptor <File>k__BackingField;  // 0x20

        // Properties
        System.Int32 Index { get; /* RVA: 0x03D4E340 */ }
        System.String Name { get; /* RVA: -1  // abstract */ }
        System.String FullName { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.Reflection.FileDescriptor File { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Reflection.DescriptorDeclaration Declaration { get; /* RVA: 0x0857C144 */ }

        // Methods
        // RVA: 0x0857C114  token: 0x6000A78
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, System.String fullName, System.Int32 index) { }
        // RVA: 0x01002730  token: 0x6000A7E
        private virtual System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }

    }

    // TypeToken: 0x20000EF  // size: 0x40
    public sealed class DescriptorDeclaration
    {
        // Fields
        private readonly Google.Protobuf.Reflection.IDescriptor <Descriptor>k__BackingField;  // 0x10
        private readonly System.Int32 <StartLine>k__BackingField;  // 0x18
        private readonly System.Int32 <StartColumn>k__BackingField;  // 0x1c
        private readonly System.Int32 <EndLine>k__BackingField;  // 0x20
        private readonly System.Int32 <EndColumn>k__BackingField;  // 0x24
        private readonly System.String <LeadingComments>k__BackingField;  // 0x28
        private readonly System.String <TrailingComments>k__BackingField;  // 0x30
        private readonly System.Collections.Generic.IReadOnlyList<System.String> <LeadingDetachedComments>k__BackingField;  // 0x38

        // Properties
        Google.Protobuf.Reflection.IDescriptor Descriptor { get; /* RVA: 0x020B7B20 */ }
        System.Int32 StartLine { get; /* RVA: 0x020D1AC0 */ }
        System.Int32 StartColumn { get; /* RVA: 0x03D4EBB0 */ }
        System.Int32 EndLine { get; /* RVA: 0x01003B50 */ }
        System.Int32 EndColumn { get; /* RVA: 0x03D4E2E0 */ }
        System.String LeadingComments { get; /* RVA: 0x03D4EAC0 */ }
        System.String TrailingComments { get; /* RVA: 0x01003830 */ }
        System.Collections.Generic.IReadOnlyList<System.String> LeadingDetachedComments { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x0857C1DC  token: 0x6000A87
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location) { }
        // RVA: 0x0857C16C  token: 0x6000A88
        private static Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location) { }

    }

    // TypeToken: 0x20000F0  // size: 0x30
    public sealed class DescriptorPool
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.IDescriptor> descriptorsByName;  // 0x10
        private readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber;  // 0x18
        private readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber;  // 0x20
        private readonly System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor> dependencies;  // 0x28
        private static readonly System.Text.RegularExpressions.Regex ValidationRegex;  // static @ 0x0

        // Methods
        // RVA: 0x0857D3AC  token: 0x6000A89
        private System.Void .ctor(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles) { }
        // RVA: 0x0857CD24  token: 0x6000A8A
        private System.Void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file) { }
        // RVA: -1  // generic def  token: 0x6000A8B
        private T FindSymbol(System.String fullName) { }
        // RVA: 0x0857C678  token: 0x6000A8C
        private System.Void AddPackage(System.String fullName, Google.Protobuf.Reflection.FileDescriptor file) { }
        // RVA: 0x0857C8E0  token: 0x6000A8D
        private System.Void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        // RVA: 0x0857D158  token: 0x6000A8E
        private static System.Void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        // RVA: 0x0857CC80  token: 0x6000A8F
        private Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, System.Int32 number) { }
        // RVA: 0x0857CBDC  token: 0x6000A90
        private Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, System.Int32 number) { }
        // RVA: 0x0857C440  token: 0x6000A91
        private System.Void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field) { }
        // RVA: 0x0857C37C  token: 0x6000A92
        private System.Void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue) { }
        // RVA: 0x0857CE98  token: 0x6000A93
        private Google.Protobuf.Reflection.IDescriptor LookupSymbol(System.String name, Google.Protobuf.Reflection.IDescriptor relativeTo) { }
        // RVA: 0x0857D2E8  token: 0x6000A94
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000F1  // size: 0x10
    public static class DescriptorUtil
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000A95
        private static System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput,TOutput> converter) { }

    }

    // TypeToken: 0x20000F3  // size: 0xA0
    public sealed class DescriptorValidationException : System.Exception
    {
        // Fields
        private readonly System.String name;  // 0x90
        private readonly System.String description;  // 0x98

        // Properties
        System.String ProblemSymbolName { get; /* RVA: 0x03D4EA90 */ }
        System.String Description { get; /* RVA: 0x011AC510 */ }

        // Methods
        // RVA: 0x0857D75C  token: 0x6000A9C
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description) { }
        // RVA: 0x0857D828  token: 0x6000A9D
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description, System.Exception cause) { }

    }

    // TypeToken: 0x20000F4  // size: 0x48
    public sealed class EnumDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.EnumDescriptorProto proto;  // 0x28
        private readonly Google.Protobuf.Reflection.MessageDescriptor containingType;  // 0x30
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> values;  // 0x38
        private readonly System.Type clrType;  // 0x40

        // Properties
        Google.Protobuf.Reflection.EnumDescriptorProto Proto { get; /* RVA: 0x03D4EAC0 */ }
        System.String Name { get; /* RVA: 0x0857DCFC */ }
        System.Type ClrType { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.Reflection.MessageDescriptor ContainingType { get; /* RVA: 0x01003830 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> Values { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x0857DC6C */ }

        // Methods
        // RVA: 0x0857DA60  token: 0x6000A9E
        private System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.Type clrType) { }
        // RVA: 0x0857DA40  token: 0x6000AA0
        public Google.Protobuf.Reflection.EnumDescriptorProto ToProto() { }
        // RVA: 0x0857D9C4  token: 0x6000AA2
        private virtual System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        // RVA: 0x0857D994  token: 0x6000AA6
        public Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(System.Int32 number) { }
        // RVA: 0x0857D908  token: 0x6000AA7
        public Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(System.String name) { }
        // RVA: 0x0857DA14  token: 0x6000AA9
        public Google.Protobuf.Reflection.EnumOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000AAA
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000AAB
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,T> extension) { }

    }

    // TypeToken: 0x20000F6  // size: 0x38
    public sealed class EnumValueDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.EnumDescriptor enumDescriptor;  // 0x28
        private readonly Google.Protobuf.Reflection.EnumValueDescriptorProto proto;  // 0x30

        // Properties
        Google.Protobuf.Reflection.EnumValueDescriptorProto Proto { get; /* RVA: 0x01003830 */ }
        System.String Name { get; /* RVA: 0x0857F9E8 */ }
        System.Int32 Number { get; /* RVA: 0x0857FA08 */ }
        Google.Protobuf.Reflection.EnumDescriptor EnumDescriptor { get; /* RVA: 0x03D4EAC0 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x0857F958 */ }

        // Methods
        // RVA: 0x0857F860  token: 0x6000AAE
        private System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, System.Int32 index) { }
        // RVA: 0x0857F840  token: 0x6000AB0
        public Google.Protobuf.Reflection.EnumValueDescriptorProto ToProto() { }
        // RVA: 0x0857F814  token: 0x6000AB5
        public Google.Protobuf.Reflection.EnumValueOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000AB6
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000AB7
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,T> extension) { }

    }

    // TypeToken: 0x20000F7  // size: 0x28
    public sealed class ExtensionAccessor : Google.Protobuf.Reflection.IFieldAccessor
    {
        // Fields
        private readonly Google.Protobuf.Extension extension;  // 0x10
        private readonly Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper helper;  // 0x18
        private readonly Google.Protobuf.Reflection.FieldDescriptor <Descriptor>k__BackingField;  // 0x20

        // Properties
        Google.Protobuf.Reflection.FieldDescriptor Descriptor { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x085805D0  token: 0x6000AB8
        private System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x0858041C  token: 0x6000ABA
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: 0x0858052C  token: 0x6000ABB
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: 0x085804A4  token: 0x6000ABC
        public virtual System.Object GetValue(Google.Protobuf.IMessage message) { }
        // RVA: 0x085805B4  token: 0x6000ABD
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x20000F8  // size: 0x28
    public sealed class ExtensionCollection
    {
        // Fields
        private System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder;  // 0x10
        private System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInNumberOrder;  // 0x18
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <UnorderedExtensions>k__BackingField;  // 0x20

        // Properties
        System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> UnorderedExtensions { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x08581158  token: 0x6000ABE
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions) { }
        // RVA: 0x08581050  token: 0x6000ABF
        private System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions) { }
        // RVA: 0x08580FB0  token: 0x6000AC1
        public System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: 0x08581000  token: 0x6000AC2
        public System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: 0x08580658  token: 0x6000AC3
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x20000FC  // size: 0x20
    public abstract class FieldAccessorBase : Google.Protobuf.Reflection.IFieldAccessor
    {
        // Fields
        private readonly System.Func<Google.Protobuf.IMessage,System.Object> getValueDelegate;  // 0x10
        private readonly Google.Protobuf.Reflection.FieldDescriptor descriptor;  // 0x18

        // Properties
        Google.Protobuf.Reflection.FieldDescriptor Descriptor { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0858E0F8  token: 0x6000ACF
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x0858E0D8  token: 0x6000AD1
        public virtual System.Object GetValue(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000AD2
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000AD3
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000AD4
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x20000FD  // size: 0x80
    public sealed class FieldDescriptor : Google.Protobuf.Reflection.DescriptorBase, System.IComparable`1
    {
        // Fields
        private Google.Protobuf.Reflection.EnumDescriptor enumType;  // 0x28
        private Google.Protobuf.Reflection.MessageDescriptor extendeeType;  // 0x30
        private Google.Protobuf.Reflection.MessageDescriptor messageType;  // 0x38
        private Google.Protobuf.Reflection.FieldType fieldType;  // 0x40
        private Google.Protobuf.Reflection.IFieldAccessor accessor;  // 0x48
        private readonly Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;  // 0x50
        private readonly Google.Protobuf.Reflection.OneofDescriptor <ContainingOneof>k__BackingField;  // 0x58
        private readonly System.String <JsonName>k__BackingField;  // 0x60
        private readonly System.String <PropertyName>k__BackingField;  // 0x68
        private readonly Google.Protobuf.Reflection.FieldDescriptorProto <Proto>k__BackingField;  // 0x70
        private readonly Google.Protobuf.Extension <Extension>k__BackingField;  // 0x78

        // Properties
        Google.Protobuf.Reflection.MessageDescriptor ContainingType { get; /* RVA: 0x03D4EAF0 */ }
        Google.Protobuf.Reflection.OneofDescriptor ContainingOneof { get; /* RVA: 0x03D4EAA0 */ }
        Google.Protobuf.Reflection.OneofDescriptor RealContainingOneof { get; /* RVA: 0x0858F2E4 */ }
        System.String JsonName { get; /* RVA: 0x03D4EB00 */ }
        System.String PropertyName { get; /* RVA: 0x03D4EAB0 */ }
        System.Boolean HasPresence { get; /* RVA: 0x0858F0DC */ }
        Google.Protobuf.Reflection.FieldDescriptorProto Proto { get; /* RVA: 0x03D4EB30 */ }
        Google.Protobuf.Extension Extension { get; /* RVA: 0x03D4EB20 */ }
        System.String Name { get; /* RVA: 0x0858F2C4 */ }
        Google.Protobuf.Reflection.IFieldAccessor Accessor { get; /* RVA: 0x03D4EA70 */ }
        System.Boolean IsRepeated { get; /* RVA: 0x0858F204 */ }
        System.Boolean IsRequired { get; /* RVA: 0x0858F22C */ }
        System.Boolean IsMap { get; /* RVA: 0x0858F168 */ }
        System.Boolean IsPacked { get; /* RVA: 0x0858F1A8 */ }
        System.Boolean IsExtension { get; /* RVA: 0x0858F148 */ }
        Google.Protobuf.Reflection.FieldType FieldType { get; /* RVA: 0x03D4ED80 */ }
        System.Int32 FieldNumber { get; /* RVA: 0x0858F0BC */ }
        Google.Protobuf.Reflection.EnumDescriptor EnumType { get; /* RVA: 0x0858EFDC */ }
        Google.Protobuf.Reflection.MessageDescriptor MessageType { get; /* RVA: 0x0858F254 */ }
        Google.Protobuf.Reflection.MessageDescriptor ExtendeeType { get; /* RVA: 0x0858F048 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x0858EF4C */ }

        // Methods
        // RVA: 0x0858EC14  token: 0x6000ADC
        public Google.Protobuf.Reflection.FieldDescriptorProto ToProto() { }
        // RVA: 0x0858EC34  token: 0x6000ADE
        private System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String propertyName, Google.Protobuf.Extension extension) { }
        // RVA: 0x0858EA80  token: 0x6000AE1
        private static Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type) { }
        // RVA: 0x0858E274  token: 0x6000AE9
        public virtual System.Int32 CompareTo(Google.Protobuf.Reflection.FieldDescriptor other) { }
        // RVA: 0x0858EBE8  token: 0x6000AEE
        public Google.Protobuf.Reflection.FieldOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000AEF
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000AF0
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,T> extension) { }
        // RVA: 0x0858E50C  token: 0x6000AF1
        private System.Void CrossLink() { }
        // RVA: 0x0858E308  token: 0x6000AF2
        private Google.Protobuf.Reflection.IFieldAccessor CreateAccessor() { }

    }

    // TypeToken: 0x20000FE  // size: 0x14
    public sealed struct FieldType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.FieldType Double;  // const
        public static Google.Protobuf.Reflection.FieldType Float;  // const
        public static Google.Protobuf.Reflection.FieldType Int64;  // const
        public static Google.Protobuf.Reflection.FieldType UInt64;  // const
        public static Google.Protobuf.Reflection.FieldType Int32;  // const
        public static Google.Protobuf.Reflection.FieldType Fixed64;  // const
        public static Google.Protobuf.Reflection.FieldType Fixed32;  // const
        public static Google.Protobuf.Reflection.FieldType Bool;  // const
        public static Google.Protobuf.Reflection.FieldType String;  // const
        public static Google.Protobuf.Reflection.FieldType Group;  // const
        public static Google.Protobuf.Reflection.FieldType Message;  // const
        public static Google.Protobuf.Reflection.FieldType Bytes;  // const
        public static Google.Protobuf.Reflection.FieldType UInt32;  // const
        public static Google.Protobuf.Reflection.FieldType SFixed32;  // const
        public static Google.Protobuf.Reflection.FieldType SFixed64;  // const
        public static Google.Protobuf.Reflection.FieldType SInt32;  // const
        public static Google.Protobuf.Reflection.FieldType SInt64;  // const
        public static Google.Protobuf.Reflection.FieldType Enum;  // const

    }

    // TypeToken: 0x20000FF  // size: 0x14
    public sealed struct Syntax
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.Reflection.Syntax Proto2;  // const
        public static Google.Protobuf.Reflection.Syntax Proto3;  // const
        public static Google.Protobuf.Reflection.Syntax Unknown;  // const

    }

    // TypeToken: 0x2000100  // size: 0x68
    public sealed class FileDescriptor : Google.Protobuf.Reflection.IDescriptor
    {
        // Fields
        private readonly System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>> declarations;  // 0x10
        private readonly Google.Protobuf.Reflection.FileDescriptorProto <Proto>k__BackingField;  // 0x18
        private readonly Google.Protobuf.Reflection.Syntax <Syntax>k__BackingField;  // 0x20
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <MessageTypes>k__BackingField;  // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;  // 0x30
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> <Services>k__BackingField;  // 0x38
        private readonly Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;  // 0x40
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <Dependencies>k__BackingField;  // 0x48
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <PublicDependencies>k__BackingField;  // 0x50
        private readonly Google.Protobuf.ByteString <SerializedData>k__BackingField;  // 0x58
        private readonly Google.Protobuf.Reflection.DescriptorPool <DescriptorPool>k__BackingField;  // 0x60

        // Properties
        Google.Protobuf.Reflection.FileDescriptorProto Proto { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.Reflection.Syntax Syntax { get; /* RVA: 0x01003B50 */ }
        System.String Name { get; /* RVA: 0x08591B10 */ }
        System.String Package { get; /* RVA: 0x08591B30 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> MessageTypes { get; /* RVA: 0x03D4EAC0 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> EnumTypes { get; /* RVA: 0x01003830 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> Services { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Reflection.ExtensionCollection Extensions { get; /* RVA: 0x03D4E2B0 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> Dependencies { get; /* RVA: 0x03D4EA70 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> PublicDependencies { get; /* RVA: 0x03D4EAF0 */ }
        Google.Protobuf.ByteString SerializedData { get; /* RVA: 0x03D4EAA0 */ }
        System.String Google.Protobuf.Reflection.IDescriptor.FullName { get; /* RVA: 0x085914E4 */ }
        Google.Protobuf.Reflection.FileDescriptor Google.Protobuf.Reflection.IDescriptor.File { get; /* RVA: 0x0339AE90 */ }
        Google.Protobuf.Reflection.DescriptorPool DescriptorPool { get; /* RVA: 0x03D4EB00 */ }
        Google.Protobuf.Reflection.FileDescriptor DescriptorProtoFileDescriptor { get; /* RVA: 0x08591AD0 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x08591A40 */ }

        // Methods
        // RVA: 0x08591554  token: 0x6000AF3
        private static System.Void .cctor() { }
        // RVA: 0x085915E4  token: 0x6000AF4
        private System.Void .ctor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        // RVA: 0x0858FE74  token: 0x6000AF5
        private System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap() { }
        // RVA: 0x0859062C  token: 0x6000AF6
        private Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<System.Int32> path) { }
        // RVA: 0x0859138C  token: 0x6000AF7
        private Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, System.Int32 index) { }
        // RVA: 0x08591450  token: 0x6000AF8
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        // RVA: 0x08591304  token: 0x6000AF9
        private Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        // RVA: 0x0858FDE4  token: 0x6000AFA
        private System.String ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, System.String name) { }
        // RVA: 0x085902D8  token: 0x6000AFB
        private static System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, System.Boolean allowUnknownDependencies) { }
        // RVA: 0x085914EC  token: 0x6000AFD
        public Google.Protobuf.Reflection.FileDescriptorProto ToProto() { }
        // RVA: -1  // generic def  token: 0x6000B0B
        public T FindTypeByName(System.String name) { }
        // RVA: 0x0858FC5C  token: 0x6000B0C
        private static Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        // RVA: 0x08590088  token: 0x6000B0D
        private System.Void CrossLink() { }
        // RVA: 0x08590788  token: 0x6000B0E
        public static Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(System.Byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        // RVA: 0x0859103C  token: 0x6000B0F
        private static System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo) { }
        // RVA: 0x08591160  token: 0x6000B10
        private static System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated) { }
        // RVA: 0x08590D24  token: 0x6000B11
        private static System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor) { }
        // RVA: 0x08590AA4  token: 0x6000B12
        private static System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: 0x0858F344  token: 0x6000B13
        public static System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry) { }
        // RVA: 0x0858F2F8  token: 0x6000B14
        public static System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData) { }
        // RVA: 0x0859150C  token: 0x6000B15
        public virtual System.String ToString() { }
        // RVA: 0x085914B8  token: 0x6000B18
        public Google.Protobuf.Reflection.FileOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000B19
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000B1A
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000B1B
        public static System.Void ForceReflectionInitialization() { }

    }

    // TypeToken: 0x2000103  // size: 0x48
    public sealed class GeneratedClrTypeInfo
    {
        // Fields
        private static readonly System.String[] EmptyNames;  // static @ 0x0
        private static readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo;  // static @ 0x8
        private static readonly Google.Protobuf.Extension[] EmptyExtensions;  // static @ 0x10
        private static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes MessageAccessibility;  // const
        private System.Type <ClrType>k__BackingField;  // 0x10
        private readonly Google.Protobuf.MessageParser <Parser>k__BackingField;  // 0x18
        private readonly System.String[] <PropertyNames>k__BackingField;  // 0x20
        private readonly Google.Protobuf.Extension[] <Extensions>k__BackingField;  // 0x28
        private readonly System.String[] <OneofNames>k__BackingField;  // 0x30
        private readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[] <NestedTypes>k__BackingField;  // 0x38
        private readonly System.Type[] <NestedEnums>k__BackingField;  // 0x40

        // Properties
        System.Type ClrType { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        Google.Protobuf.MessageParser Parser { get; /* RVA: 0x01041090 */ }
        System.String[] PropertyNames { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Extension[] Extensions { get; /* RVA: 0x03D4EAC0 */ }
        System.String[] OneofNames { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Reflection.GeneratedClrTypeInfo[] NestedTypes { get; /* RVA: 0x03D4E2A0 */ }
        System.Type[] NestedEnums { get; /* RVA: 0x03D4E2B0 */ }

        // Methods
        // RVA: 0x08591C64  token: 0x6000B30
        public System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        // RVA: 0x08591E1C  token: 0x6000B31
        public System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        // RVA: 0x08591DE8  token: 0x6000B32
        public System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        // RVA: 0x08591C38  token: 0x6000B33
        public System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        // RVA: 0x08591B50  token: 0x6000B34
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000104
    public interface IDescriptor
    {
        // Properties
        System.String Name { get; /* RVA: -1  // abstract */ }
        System.String FullName { get; /* RVA: -1  // abstract */ }
        Google.Protobuf.Reflection.FileDescriptor File { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000105
    public interface IFieldAccessor
    {
        // Properties
        Google.Protobuf.Reflection.FieldDescriptor Descriptor { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000B39
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000B3A
        public virtual System.Object GetValue(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000B3B
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: -1  // abstract  token: 0x6000B3C
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000106  // size: 0x20
    public sealed class MapFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
    {
        // Methods
        // RVA: 0x08591F94  token: 0x6000B3D
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x08591E60  token: 0x6000B3E
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: 0x08591EDC  token: 0x6000B3F
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: 0x08591F38  token: 0x6000B40
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000107  // size: 0x98
    public sealed class MessageDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<System.String> WellKnownTypeNames;  // static @ 0x0
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder;  // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder;  // 0x30
        private readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap;  // 0x38
        private System.Func<Google.Protobuf.IMessage,System.Boolean> extensionSetIsInitialized;  // 0x40
        private readonly Google.Protobuf.Reflection.DescriptorProto <Proto>k__BackingField;  // 0x48
        private readonly System.Type <ClrType>k__BackingField;  // 0x50
        private readonly Google.Protobuf.MessageParser <Parser>k__BackingField;  // 0x58
        private readonly Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;  // 0x60
        private readonly Google.Protobuf.Reflection.MessageDescriptor.FieldCollection <Fields>k__BackingField;  // 0x68
        private readonly Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;  // 0x70
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <NestedTypes>k__BackingField;  // 0x78
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;  // 0x80
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> <Oneofs>k__BackingField;  // 0x88
        private readonly System.Int32 <RealOneofCount>k__BackingField;  // 0x90

        // Properties
        System.String Name { get; /* RVA: 0x08593AB0 */ }
        Google.Protobuf.Reflection.DescriptorProto Proto { get; /* RVA: 0x03D4EA70 */ }
        System.Type ClrType { get; /* RVA: 0x03D4EAF0 */ }
        Google.Protobuf.MessageParser Parser { get; /* RVA: 0x03D4EAA0 */ }
        System.Boolean IsWellKnownType { get; /* RVA: 0x08593964 */ }
        System.Boolean IsWrapperType { get; /* RVA: 0x08593A24 */ }
        Google.Protobuf.Reflection.MessageDescriptor ContainingType { get; /* RVA: 0x03D4EB00 */ }
        Google.Protobuf.Reflection.MessageDescriptor.FieldCollection Fields { get; /* RVA: 0x03D4EAB0 */ }
        Google.Protobuf.Reflection.ExtensionCollection Extensions { get; /* RVA: 0x03D4EB30 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> NestedTypes { get; /* RVA: 0x03D4EB20 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> EnumTypes { get; /* RVA: 0x03D4EAE0 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> Oneofs { get; /* RVA: 0x03D4EA60 */ }
        System.Int32 RealOneofCount { get; /* RVA: 0x03D4FB60 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x085938D4 */ }

        // Methods
        // RVA: 0x08592A90  token: 0x6000B41
        private System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        // RVA: 0x08591F9C  token: 0x6000B42
        private static System.Collections.ObjectModel.ReadOnlyDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields) { }
        // RVA: 0x08592734  token: 0x6000B44
        private virtual System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        // RVA: 0x08592880  token: 0x6000B46
        public Google.Protobuf.Reflection.DescriptorProto ToProto() { }
        // RVA: 0x085927CC  token: 0x6000B47
        private System.Boolean IsExtensionsInitialized(Google.Protobuf.IMessage message) { }
        // RVA: 0x08592678  token: 0x6000B53
        public Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(System.String name) { }
        // RVA: 0x08592704  token: 0x6000B54
        public Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(System.Int32 number) { }
        // RVA: -1  // generic def  token: 0x6000B55
        public T FindDescriptor(System.String name) { }
        // RVA: 0x085927A0  token: 0x6000B57
        public Google.Protobuf.Reflection.MessageOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000B58
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000B59
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,T> extension) { }
        // RVA: 0x08592328  token: 0x6000B5A
        private System.Void CrossLink() { }
        // RVA: 0x085928A0  token: 0x6000B5B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200010B  // size: 0x48
    public sealed class MethodDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.MethodDescriptorProto proto;  // 0x28
        private readonly Google.Protobuf.Reflection.ServiceDescriptor service;  // 0x30
        private Google.Protobuf.Reflection.MessageDescriptor inputType;  // 0x38
        private Google.Protobuf.Reflection.MessageDescriptor outputType;  // 0x40

        // Properties
        Google.Protobuf.Reflection.ServiceDescriptor Service { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Reflection.MessageDescriptor InputType { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Reflection.MessageDescriptor OutputType { get; /* RVA: 0x03D4E2B0 */ }
        System.Boolean IsClientStreaming { get; /* RVA: 0x08593ED8 */ }
        System.Boolean IsServerStreaming { get; /* RVA: 0x08593EF8 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x08593E48 */ }
        Google.Protobuf.Reflection.MethodDescriptorProto Proto { get; /* RVA: 0x03D4EAC0 */ }
        System.String Name { get; /* RVA: 0x08593F18 */ }

        // Methods
        // RVA: 0x08593D18  token: 0x6000B70
        public Google.Protobuf.Reflection.MethodOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000B71
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000B72
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,T> extension) { }
        // RVA: 0x08593D64  token: 0x6000B73
        private System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, System.Int32 index) { }
        // RVA: 0x08593D44  token: 0x6000B75
        public Google.Protobuf.Reflection.MethodDescriptorProto ToProto() { }
        // RVA: 0x08593AD0  token: 0x6000B77
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x200010C  // size: 0x28
    public sealed class OneofAccessor
    {
        // Fields
        private readonly System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate;  // 0x10
        private readonly System.Action<Google.Protobuf.IMessage> clearDelegate;  // 0x18
        private readonly Google.Protobuf.Reflection.OneofDescriptor <Descriptor>k__BackingField;  // 0x20

        // Properties
        Google.Protobuf.Reflection.OneofDescriptor Descriptor { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x085941A8  token: 0x6000B78
        private System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate) { }
        // RVA: 0x08593F58  token: 0x6000B79
        private static Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod) { }
        // RVA: 0x08594020  token: 0x6000B7A
        private static Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor) { }
        // RVA: 0x08593F38  token: 0x6000B7C
        public System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: 0x08594158  token: 0x6000B7D
        public Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200010E  // size: 0x50
    public sealed class OneofDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private Google.Protobuf.Reflection.MessageDescriptor containingType;  // 0x28
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields;  // 0x30
        private readonly Google.Protobuf.Reflection.OneofAccessor accessor;  // 0x38
        private readonly Google.Protobuf.Reflection.OneofDescriptorProto <Proto>k__BackingField;  // 0x40
        private readonly System.Boolean <IsSynthetic>k__BackingField;  // 0x48

        // Properties
        System.String Name { get; /* RVA: 0x08594AD4 */ }
        Google.Protobuf.Reflection.OneofDescriptorProto Proto { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.Reflection.MessageDescriptor ContainingType { get; /* RVA: 0x03D4EAC0 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> Fields { get; /* RVA: 0x01003830 */ }
        System.Boolean IsSynthetic { get; /* RVA: 0x03D4EFE0 */ }
        Google.Protobuf.Reflection.OneofAccessor Accessor { get; /* RVA: 0x03D4E2A0 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x08594A44 */ }

        // Methods
        // RVA: 0x085948A4  token: 0x6000B81
        private System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String clrName) { }
        // RVA: 0x08594884  token: 0x6000B84
        public Google.Protobuf.Reflection.OneofDescriptorProto ToProto() { }
        // RVA: 0x08594858  token: 0x6000B8A
        public Google.Protobuf.Reflection.OneofOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000B8B
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000B8C
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,T> extension) { }
        // RVA: 0x08594484  token: 0x6000B8D
        private System.Void CrossLink() { }
        // RVA: 0x085941E0  token: 0x6000B8E
        private Google.Protobuf.Reflection.OneofAccessor CreateAccessor(System.String clrName) { }

    }

    // TypeToken: 0x2000110  // size: 0x20
    public class OriginalNameAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.Boolean <PreferredAlias>k__BackingField;  // 0x18

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean PreferredAlias { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x023C46A0  token: 0x6000B95
        public System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x2000111  // size: 0x28
    public sealed class PackageDescriptor : Google.Protobuf.Reflection.IDescriptor
    {
        // Fields
        private readonly System.String name;  // 0x10
        private readonly System.String fullName;  // 0x18
        private readonly Google.Protobuf.Reflection.FileDescriptor file;  // 0x20

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ }
        System.String FullName { get; /* RVA: 0x01041090 */ }
        Google.Protobuf.Reflection.FileDescriptor File { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x08594AF4  token: 0x6000B96
        private System.Void .ctor(System.String name, System.String fullName, Google.Protobuf.Reflection.FileDescriptor file) { }

    }

    // TypeToken: 0x2000112  // size: 0x10
    public static class ReflectionUtil
    {
        // Fields
        private static readonly System.Type[] EmptyTypes;  // static @ 0x0
        private static readonly System.Boolean <CanConvertEnumFuncToInt32Func>k__BackingField;  // static @ 0x8

        // Properties
        System.Boolean CanConvertEnumFuncToInt32Func { get; /* RVA: 0x085958F4 */ }

        // Methods
        // RVA: 0x085956F4  token: 0x6000B9A
        private static System.Void .cctor() { }
        // RVA: -1  // generic def  token: 0x6000B9B
        private static System.Void ForceInitialize() { }
        // RVA: 0x085953B4  token: 0x6000B9C
        private static System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: 0x085952D0  token: 0x6000B9D
        private static System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        // RVA: 0x08594E3C  token: 0x6000B9E
        private static System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        // RVA: 0x08594F40  token: 0x6000B9F
        private static System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        // RVA: 0x085951EC  token: 0x6000BA0
        private static System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }
        // RVA: 0x08595498  token: 0x6000BA1
        private static System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller(System.Type msg) { }
        // RVA: 0x0859504C  token: 0x6000BA2
        private static Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension) { }
        // RVA: 0x085955E8  token: 0x6000BA3
        private static Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2) { }
        // RVA: 0x08594D10  token: 0x6000BA5
        private static System.Boolean CheckCanConvertEnumFuncToInt32Func() { }
        // RVA: 0x01002730  token: 0x6000BA6
        public static Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod() { }

    }

    // TypeToken: 0x2000121  // size: 0x20
    public sealed class RepeatedFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
    {
        // Methods
        // RVA: 0x08591F94  token: 0x6000BCC
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x08595944  token: 0x6000BCD
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: 0x085959C0  token: 0x6000BCE
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: 0x08595A1C  token: 0x6000BCF
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000122  // size: 0x38
    public sealed class ServiceDescriptor : Google.Protobuf.Reflection.DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.ServiceDescriptorProto proto;  // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> methods;  // 0x30

        // Properties
        System.String Name { get; /* RVA: 0x08595EC4 */ }
        Google.Protobuf.Reflection.ServiceDescriptorProto Proto { get; /* RVA: 0x03D4EAC0 */ }
        System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> Methods { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.Reflection.CustomOptions CustomOptions { get; /* RVA: 0x08595E34 */ }

        // Methods
        // RVA: 0x08595CC0  token: 0x6000BD0
        private System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, System.Int32 index) { }
        // RVA: 0x08595C24  token: 0x6000BD2
        private virtual System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        // RVA: 0x08595CA0  token: 0x6000BD4
        public Google.Protobuf.Reflection.ServiceDescriptorProto ToProto() { }
        // RVA: 0x08595B98  token: 0x6000BD6
        public Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(System.String name) { }
        // RVA: 0x08595C74  token: 0x6000BD8
        public Google.Protobuf.Reflection.ServiceOptions GetOptions() { }
        // RVA: -1  // generic def  token: 0x6000BD9
        public T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,T> extension) { }
        // RVA: -1  // generic def  token: 0x6000BDA
        public Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,T> extension) { }
        // RVA: 0x08595A78  token: 0x6000BDB
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x2000124  // size: 0x38
    public sealed class SingleFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
    {
        // Fields
        private readonly System.Action<Google.Protobuf.IMessage,System.Object> setValueDelegate;  // 0x20
        private readonly System.Action<Google.Protobuf.IMessage> clearDelegate;  // 0x28
        private readonly System.Func<Google.Protobuf.IMessage,System.Boolean> hasDelegate;  // 0x30

        // Methods
        // RVA: 0x08596154  token: 0x6000BDE
        private System.Void .ctor(System.Type messageType, System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x08595EE4  token: 0x6000BDF
        private static System.Object GetDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        // RVA: 0x057776CC  token: 0x6000BE0
        public virtual System.Void Clear(Google.Protobuf.IMessage message) { }
        // RVA: 0x08596114  token: 0x6000BE1
        public virtual System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        // RVA: 0x08596134  token: 0x6000BE2
        public virtual System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000129  // size: 0x18
    public sealed class TypeRegistry
    {
        // Fields
        private static readonly Google.Protobuf.Reflection.TypeRegistry <Empty>k__BackingField;  // static @ 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap;  // 0x10

        // Properties
        Google.Protobuf.Reflection.TypeRegistry Empty { get; /* RVA: 0x08596E64 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000BEF
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap) { }
        // RVA: 0x0859699C  token: 0x6000BF0
        public Google.Protobuf.Reflection.MessageDescriptor Find(System.String fullName) { }
        // RVA: 0x08596A04  token: 0x6000BF1
        public static Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors) { }
        // RVA: 0x08596A50  token: 0x6000BF2
        public static Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors) { }
        // RVA: 0x08596C08  token: 0x6000BF3
        public static Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors) { }
        // RVA: 0x08596C54  token: 0x6000BF4
        public static Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors) { }
        // RVA: 0x08596DAC  token: 0x6000BF5
        private static System.Void .cctor() { }

    }

}

namespace Google.Protobuf.WellKnownTypes
{

    // TypeToken: 0x2000060  // size: 0x10
    public static class AnyReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x08555208 */ }

        // Methods
        // RVA: 0x08554EB0  token: 0x60003A9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000061  // size: 0x28
    public sealed class Any : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 TypeUrlFieldNumber;  // const
        private System.String typeUrl_;  // 0x18
        public static System.Int32 ValueFieldNumber;  // const
        private Google.Protobuf.ByteString value_;  // 0x20
        private static System.String DefaultPrefix;  // const

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> Parser { get; /* RVA: 0x08555B44 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08555AE4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08555CD4 */ }
        System.String TypeUrl { get; /* RVA: 0x01041090 */ set; /* RVA: 0x08555D14 */ }
        Google.Protobuf.ByteString Value { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x08555D7C */ }

        // Methods
        // RVA: 0x08555A7C  token: 0x60003AD
        public System.Void .ctor() { }
        // RVA: 0x08555A14  token: 0x60003AE
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Any other) { }
        // RVA: 0x08555310  token: 0x60003AF
        public virtual Google.Protobuf.WellKnownTypes.Any Clone() { }
        // RVA: 0x08555370  token: 0x60003B4
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085553D4  token: 0x60003B5
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Any other) { }
        // RVA: 0x0855547C  token: 0x60003B6
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085558C4  token: 0x60003B7
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60003B8
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08555C40  token: 0x60003B9
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08555258  token: 0x60003BA
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085556B8  token: 0x60003BB
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Any other) { }
        // RVA: 0x03D47500  token: 0x60003BC
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08555B94  token: 0x60003BD
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08555594  token: 0x60003BE
        private static System.String GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String prefix) { }
        // RVA: 0x08555500  token: 0x60003BF
        public static System.String GetTypeName(System.String typeUrl) { }
        // RVA: 0x08555620  token: 0x60003C0
        public System.Boolean Is(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        // RVA: -1  // generic def  token: 0x60003C1
        public T Unpack() { }
        // RVA: -1  // generic def  token: 0x60003C2
        public System.Boolean TryUnpack(T& result) { }
        // RVA: 0x08555870  token: 0x60003C3
        public static Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message) { }
        // RVA: 0x08555738  token: 0x60003C4
        public static Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, System.String typeUrlPrefix) { }
        // RVA: 0x08555910  token: 0x60003C5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x10
    public static class ApiReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x085565E0 */ }

        // Methods
        // RVA: 0x08555DE4  token: 0x60003CA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x50
    public sealed class Api : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 MethodsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x28
        public static System.Int32 VersionFieldNumber;  // const
        private System.String version_;  // 0x30
        public static System.Int32 SourceContextFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;  // 0x38
        public static System.Int32 MixinsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin> _repeated_mixins_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> mixins_;  // 0x40
        public static System.Int32 SyntaxFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;  // 0x48

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> Parser { get; /* RVA: 0x085571D8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08557178 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08557638 */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x08557678 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> Methods { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x03D4EAC0 */ }
        System.String Version { get; /* RVA: 0x01003830 */ set; /* RVA: 0x085576E0 */ }
        Google.Protobuf.WellKnownTypes.SourceContext SourceContext { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> Mixins { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.WellKnownTypes.Syntax Syntax { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }

        // Methods
        // RVA: 0x08556EFC  token: 0x60003CE
        public System.Void .ctor() { }
        // RVA: 0x0855703C  token: 0x60003CF
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Api other) { }
        // RVA: 0x08556810  token: 0x60003D0
        public virtual Google.Protobuf.WellKnownTypes.Api Clone() { }
        // RVA: 0x08556870  token: 0x60003DC
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085568D4  token: 0x60003DD
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Api other) { }
        // RVA: 0x085569FC  token: 0x60003DE
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08556C70  token: 0x60003DF
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60003E0
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08557474  token: 0x60003E1
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08556630  token: 0x60003E2
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08556AF0  token: 0x60003E3
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Api other) { }
        // RVA: 0x03D47500  token: 0x60003E4
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08557228  token: 0x60003E5
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08556CBC  token: 0x60003E6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000066  // size: 0x50
    public sealed class Method : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 RequestTypeUrlFieldNumber;  // const
        private System.String requestTypeUrl_;  // 0x20
        public static System.Int32 RequestStreamingFieldNumber;  // const
        private System.Boolean requestStreaming_;  // 0x28
        public static System.Int32 ResponseTypeUrlFieldNumber;  // const
        private System.String responseTypeUrl_;  // 0x30
        public static System.Int32 ResponseStreamingFieldNumber;  // const
        private System.Boolean responseStreaming_;  // 0x38
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x40
        public static System.Int32 SyntaxFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;  // 0x48

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> Parser { get; /* RVA: 0x0855B72C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855B6CC */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855BAB8 */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0855BAF8 */ }
        System.String RequestTypeUrl { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x0855BB60 */ }
        System.Boolean RequestStreaming { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.String ResponseTypeUrl { get; /* RVA: 0x01003830 */ set; /* RVA: 0x0855BBC8 */ }
        System.Boolean ResponseStreaming { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x03D4E2B0 */ }
        Google.Protobuf.WellKnownTypes.Syntax Syntax { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }

        // Methods
        // RVA: 0x0855B60C  token: 0x60003ED
        public System.Void .ctor() { }
        // RVA: 0x0855B538  token: 0x60003EE
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Method other) { }
        // RVA: 0x0855AFD4  token: 0x60003EF
        public virtual Google.Protobuf.WellKnownTypes.Method Clone() { }
        // RVA: 0x0855B10C  token: 0x60003FD
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0855B034  token: 0x60003FE
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Method other) { }
        // RVA: 0x0855B170  token: 0x60003FF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855B37C  token: 0x6000400
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000401
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0855B924  token: 0x6000402
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855AE48  token: 0x6000403
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0855B27C  token: 0x6000404
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Method other) { }
        // RVA: 0x03D47500  token: 0x6000405
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855B77C  token: 0x6000406
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0855B3C8  token: 0x6000407
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000068  // size: 0x28
    public sealed class Mixin : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 RootFieldNumber;  // const
        private System.String root_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> Parser { get; /* RVA: 0x0855C090 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855C030 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855C18C */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0855C1CC */ }
        System.String Root { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x0855C234 */ }

        // Methods
        // RVA: 0x0855BFDC  token: 0x600040E
        public System.Void .ctor() { }
        // RVA: 0x0855BF74  token: 0x600040F
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Mixin other) { }
        // RVA: 0x0855BCE4  token: 0x6000410
        public virtual Google.Protobuf.WellKnownTypes.Mixin Clone() { }
        // RVA: 0x0855BD44  token: 0x6000415
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x051B1588  token: 0x6000416
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Mixin other) { }
        // RVA: 0x051B15F0  token: 0x6000417
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855BE24  token: 0x6000418
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000419
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x051B19A0  token: 0x600041A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855BC30  token: 0x600041B
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0855BDA8  token: 0x600041C
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other) { }
        // RVA: 0x03D47500  token: 0x600041D
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855C0E0  token: 0x600041E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0855BE70  token: 0x600041F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x10
    public static class DurationReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x08557AC0 */ }

        // Methods
        // RVA: 0x08557748  token: 0x6000424
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x28
    public sealed class Duration : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 SecondsFieldNumber;  // const
        private System.Int64 seconds_;  // 0x18
        public static System.Int32 NanosFieldNumber;  // const
        private System.Int32 nanos_;  // 0x20
        public static System.Int32 NanosecondsPerSecond;  // const
        public static System.Int32 NanosecondsPerTick;  // const
        public static System.Int64 MaxSeconds;  // const
        public static System.Int64 MinSeconds;  // const
        private static System.Int32 MaxNanoseconds;  // const
        private static System.Int32 MinNanoseconds;  // const

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> Parser { get; /* RVA: 0x08558664 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085585D0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08558A3C */ }
        System.Int64 Seconds { get; /* RVA: 0x01041090 */ set; /* RVA: 0x03D4EC10 */ }
        System.Int32 Nanos { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000428
        public System.Void .ctor() { }
        // RVA: 0x05167AFC  token: 0x6000429
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Duration other) { }
        // RVA: 0x08557CFC  token: 0x600042A
        public virtual Google.Protobuf.WellKnownTypes.Duration Clone() { }
        // RVA: 0x08557D5C  token: 0x600042F
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x05168418  token: 0x6000430
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Duration other) { }
        // RVA: 0x0516844C  token: 0x6000431
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08558318  token: 0x6000432
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000433
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x05168678  token: 0x6000434
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08557C60  token: 0x6000435
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x05168498  token: 0x6000436
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other) { }
        // RVA: 0x03D47500  token: 0x6000437
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x051685E0  token: 0x6000438
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08557F44  token: 0x6000439
        private static System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds) { }
        // RVA: 0x08558364  token: 0x600043A
        public System.TimeSpan ToTimeSpan() { }
        // RVA: 0x08557DC0  token: 0x600043B
        public static Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan) { }
        // RVA: 0x08558944  token: 0x600043C
        public static Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value) { }
        // RVA: 0x085586B4  token: 0x600043D
        public static Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        // RVA: 0x085587F8  token: 0x600043E
        public static Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        // RVA: 0x08557FD8  token: 0x600043F
        private static Google.Protobuf.WellKnownTypes.Duration Normalize(System.Int64 seconds, System.Int32 nanoseconds) { }
        // RVA: 0x085580CC  token: 0x6000440
        private static System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly) { }
        // RVA: 0x08558074  token: 0x6000441
        public virtual System.String ToDiagnosticString() { }
        // RVA: 0x08557B10  token: 0x6000442
        private static System.Void AppendNanoseconds(System.Text.StringBuilder builder, System.Int32 nanos) { }
        // RVA: 0x085584CC  token: 0x6000443
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x10
    public static class EmptyReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x08558D74 */ }

        // Methods
        // RVA: 0x08558A7C  token: 0x6000448
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x18
    public sealed class Empty : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> Parser { get; /* RVA: 0x0855906C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08558FD8 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085590BC */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600044C
        public System.Void .ctor() { }
        // RVA: 0x0518C054  token: 0x600044D
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Empty other) { }
        // RVA: 0x08558DC4  token: 0x600044E
        public virtual Google.Protobuf.WellKnownTypes.Empty Clone() { }
        // RVA: 0x08558E24  token: 0x600044F
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0518BE84  token: 0x6000450
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Empty other) { }
        // RVA: 0x0518BEA8  token: 0x6000451
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08558E88  token: 0x6000452
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000453
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0518C194  token: 0x6000454
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0518BDA0  token: 0x6000455
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0518BED4  token: 0x6000456
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other) { }
        // RVA: 0x03D47500  token: 0x6000457
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0518C138  token: 0x6000458
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08558ED4  token: 0x6000459
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x10
    public static class FieldMaskReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x08559434 */ }

        // Methods
        // RVA: 0x085590FC  token: 0x600045E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000071  // size: 0x20
    public sealed class FieldMask : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 PathsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_paths_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> paths_;  // 0x18
        private static System.Char FIELD_PATH_SEPARATOR;  // const
        private static System.Char FIELD_SEPARATOR_REGEX;  // const

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> Parser { get; /* RVA: 0x0855A4D8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855A444 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855A69C */ }
        Google.Protobuf.Collections.RepeatedField<System.String> Paths { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0855A3CC  token: 0x6000462
        public System.Void .ctor() { }
        // RVA: 0x0855A344  token: 0x6000463
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        // RVA: 0x08559518  token: 0x6000464
        public virtual Google.Protobuf.WellKnownTypes.FieldMask Clone() { }
        // RVA: 0x08559578  token: 0x6000466
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085595DC  token: 0x6000467
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        // RVA: 0x0517BB20  token: 0x6000468
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855A114  token: 0x6000469
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600046A
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0855A5F8  token: 0x600046B
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08559484  token: 0x600046C
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08559B88  token: 0x600046D
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        // RVA: 0x03D47500  token: 0x600046E
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855A528  token: 0x600046F
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08559DC8  token: 0x6000470
        private static System.String ToJson(System.Collections.Generic.IList<System.String> paths, System.Boolean diagnosticOnly) { }
        // RVA: 0x08559D78  token: 0x6000471
        public virtual System.String ToDiagnosticString() { }
        // RVA: 0x08559658  token: 0x6000472
        public static Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value) { }
        // RVA: -1  // generic def  token: 0x6000473
        public static Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value) { }
        // RVA: -1  // generic def  token: 0x6000474
        public static Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable(System.Collections.Generic.IEnumerable<System.String> paths) { }
        // RVA: -1  // generic def  token: 0x6000475
        public static Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Int32[] fieldNumbers) { }
        // RVA: -1  // generic def  token: 0x6000476
        public static Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Collections.Generic.IEnumerable<System.Int32> fieldNumbers) { }
        // RVA: 0x085598F0  token: 0x6000477
        private static System.Boolean IsPathValid(System.String input) { }
        // RVA: -1  // generic def  token: 0x6000478
        public static System.Boolean IsValid(Google.Protobuf.WellKnownTypes.FieldMask fieldMask) { }
        // RVA: 0x08559964  token: 0x6000479
        public static System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask) { }
        // RVA: -1  // generic def  token: 0x600047A
        public static System.Boolean IsValid(System.String path) { }
        // RVA: 0x08559AD4  token: 0x600047B
        public static System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String path) { }
        // RVA: 0x08559D10  token: 0x600047C
        public Google.Protobuf.WellKnownTypes.FieldMask Normalize() { }
        // RVA: 0x0855A160  token: 0x600047D
        public Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks) { }
        // RVA: 0x08559714  token: 0x600047E
        public Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask) { }
        // RVA: 0x08559C00  token: 0x600047F
        public System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }
        // RVA: 0x08559C9C  token: 0x6000480
        public System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination) { }
        // RVA: 0x0855A208  token: 0x6000481
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000074  // size: 0x10
    public static class SourceContextReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x0855E3A0 */ }

        // Methods
        // RVA: 0x0855E048  token: 0x600048E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000075  // size: 0x20
    public sealed class SourceContext : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 FileNameFieldNumber;  // const
        private System.String fileName_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> Parser { get; /* RVA: 0x0855E7D8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855E778 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855E8A4 */ }
        System.String FileName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0855E8E4 */ }

        // Methods
        // RVA: 0x0855E738  token: 0x6000492
        public System.Void .ctor() { }
        // RVA: 0x0855E6E0  token: 0x6000493
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        // RVA: 0x0855E46C  token: 0x6000494
        public virtual Google.Protobuf.WellKnownTypes.SourceContext Clone() { }
        // RVA: 0x0855E4CC  token: 0x6000497
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x05188EA8  token: 0x6000498
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        // RVA: 0x05188F60  token: 0x6000499
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855E590  token: 0x600049A
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600049B
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0518932C  token: 0x600049C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855E3F0  token: 0x600049D
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0855E530  token: 0x600049E
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        // RVA: 0x03D47500  token: 0x600049F
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855E828  token: 0x60004A0
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0855E5DC  token: 0x60004A1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x10
    public static class StructReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x0855F0BC */ }

        // Methods
        // RVA: 0x0855E94C  token: 0x60004A6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000078  // size: 0x14
    public sealed struct NullValue
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.WellKnownTypes.NullValue NullValue;  // const

    }

    // TypeToken: 0x2000079  // size: 0x20
    public sealed class Struct : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 FieldsFieldNumber;  // const
        private static readonly Google.Protobuf.Collections.MapField.Codec<System.String,Google.Protobuf.WellKnownTypes.Value> _map_fields_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value> fields_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> Parser { get; /* RVA: 0x0855F6F4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855F694 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855F8B8 */ }
        Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value> Fields { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0855F61C  token: 0x60004AA
        public System.Void .ctor() { }
        // RVA: 0x0855F594  token: 0x60004AB
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Struct other) { }
        // RVA: 0x0855F1A0  token: 0x60004AC
        public virtual Google.Protobuf.WellKnownTypes.Struct Clone() { }
        // RVA: 0x0855F200  token: 0x60004AE
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0855F264  token: 0x60004AF
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Struct other) { }
        // RVA: 0x0517BB20  token: 0x60004B0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855F358  token: 0x60004B1
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60004B2
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0855F814  token: 0x60004B3
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855F10C  token: 0x60004B4
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0855F2E0  token: 0x60004B5
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other) { }
        // RVA: 0x03D47500  token: 0x60004B6
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855F744  token: 0x60004B7
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0855F3A4  token: 0x60004B8
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x28
    public sealed class Value : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NullValueFieldNumber;  // const
        public static System.Int32 NumberValueFieldNumber;  // const
        public static System.Int32 StringValueFieldNumber;  // const
        public static System.Int32 BoolValueFieldNumber;  // const
        public static System.Int32 StructValueFieldNumber;  // const
        public static System.Int32 ListValueFieldNumber;  // const
        private System.Object kind_;  // 0x18
        private Google.Protobuf.WellKnownTypes.Value.KindOneofCase kindCase_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> Parser { get; /* RVA: 0x085654B4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0856536C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08565924 */ }
        Google.Protobuf.WellKnownTypes.NullValue NullValue { get; /* RVA: 0x08565420 */ set; /* RVA: 0x085659F0 */ }
        System.Double NumberValue { get; /* RVA: 0x08565468 */ set; /* RVA: 0x08565A50 */ }
        System.String StringValue { get; /* RVA: 0x08565504 */ set; /* RVA: 0x08565AB4 */ }
        System.Boolean BoolValue { get; /* RVA: 0x08565324 */ set; /* RVA: 0x08565964 */ }
        Google.Protobuf.WellKnownTypes.Struct StructValue { get; /* RVA: 0x08565578 */ set; /* RVA: 0x08565B24 */ }
        Google.Protobuf.WellKnownTypes.ListValue ListValue { get; /* RVA: 0x085653CC */ set; /* RVA: 0x085659C8 */ }
        Google.Protobuf.WellKnownTypes.Value.KindOneofCase KindCase { get; /* RVA: 0x01003B50 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60004BF
        public System.Void .ctor() { }
        // RVA: 0x085651E8  token: 0x60004C0
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Value other) { }
        // RVA: 0x085647FC  token: 0x60004C1
        public virtual Google.Protobuf.WellKnownTypes.Value Clone() { }
        // RVA: 0x051A6FE0  token: 0x60004CF
        public System.Void ClearKind() { }
        // RVA: 0x0856485C  token: 0x60004D0
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085648C0  token: 0x60004D1
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Value other) { }
        // RVA: 0x08564D5C  token: 0x60004D2
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08565098  token: 0x60004D3
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60004D4
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x085657F8  token: 0x60004D5
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085646D8  token: 0x60004D6
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08564EB0  token: 0x60004D7
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Value other) { }
        // RVA: 0x03D47500  token: 0x60004D8
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085655CC  token: 0x60004D9
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08564C3C  token: 0x60004DA
        public static Google.Protobuf.WellKnownTypes.Value ForString(System.String value) { }
        // RVA: 0x08564BDC  token: 0x60004DB
        public static Google.Protobuf.WellKnownTypes.Value ForNumber(System.Double value) { }
        // RVA: 0x08564A40  token: 0x60004DC
        public static Google.Protobuf.WellKnownTypes.Value ForBool(System.Boolean value) { }
        // RVA: 0x08564B88  token: 0x60004DD
        public static Google.Protobuf.WellKnownTypes.Value ForNull() { }
        // RVA: 0x08564AA0  token: 0x60004DE
        public static Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values) { }
        // RVA: 0x08564CCC  token: 0x60004DF
        public static Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value) { }
        // RVA: 0x085650E4  token: 0x60004E0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007E  // size: 0x20
    public sealed class ListValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValuesFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> Parser { get; /* RVA: 0x0855AC44 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0855ABE4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0855AE08 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> Values { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x0855AB6C  token: 0x60004E7
        public System.Void .ctor() { }
        // RVA: 0x0855AAE4  token: 0x60004E8
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.ListValue other) { }
        // RVA: 0x0855A770  token: 0x60004E9
        public virtual Google.Protobuf.WellKnownTypes.ListValue Clone() { }
        // RVA: 0x0855A7D0  token: 0x60004EB
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0855A834  token: 0x60004EC
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.ListValue other) { }
        // RVA: 0x0517BB20  token: 0x60004ED
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0855A928  token: 0x60004EE
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60004EF
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0855AD64  token: 0x60004F0
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855A6DC  token: 0x60004F1
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0855A8B0  token: 0x60004F2
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other) { }
        // RVA: 0x03D47500  token: 0x60004F3
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0855AC94  token: 0x60004F4
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0855A974  token: 0x60004F5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x10
    public static class TimeExtensions
    {
        // Methods
        // RVA: 0x0855F944  token: 0x60004F9
        public static Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime) { }
        // RVA: 0x0855F990  token: 0x60004FA
        public static Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset) { }
        // RVA: 0x0855F8F8  token: 0x60004FB
        public static Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan) { }

    }

    // TypeToken: 0x2000081  // size: 0x10
    public static class TimestampReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x0855FD5C */ }

        // Methods
        // RVA: 0x0855F9E4  token: 0x60004FD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000082  // size: 0x28
    public sealed class Timestamp : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage, System.IComparable`1
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 SecondsFieldNumber;  // const
        private System.Int64 seconds_;  // 0x18
        public static System.Int32 NanosFieldNumber;  // const
        private System.Int32 nanos_;  // 0x20
        private static readonly System.DateTime UnixEpoch;  // static @ 0x8
        private static System.Int64 BclSecondsAtUnixEpoch;  // const
        private static System.Int64 UnixSecondsAtBclMaxValue;  // const
        private static System.Int64 UnixSecondsAtBclMinValue;  // const
        private static System.Int32 MaxNanos;  // const

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> Parser { get; /* RVA: 0x08560968 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085608D4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08560EA8 */ }
        System.Int64 Seconds { get; /* RVA: 0x01041090 */ set; /* RVA: 0x03D4EC10 */ }
        System.Int32 Nanos { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000501
        public System.Void .ctor() { }
        // RVA: 0x05167AFC  token: 0x6000502
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        // RVA: 0x0855FE48  token: 0x6000503
        public virtual Google.Protobuf.WellKnownTypes.Timestamp Clone() { }
        // RVA: 0x0855FF3C  token: 0x6000508
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x05168418  token: 0x6000509
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        // RVA: 0x0516844C  token: 0x600050A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08560728  token: 0x600050B
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600050C
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x05168678  token: 0x600050D
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0855FDAC  token: 0x600050E
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0856019C  token: 0x600050F
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        // RVA: 0x03D47500  token: 0x6000510
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x051685E0  token: 0x6000511
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08560170  token: 0x6000512
        private static System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds) { }
        // RVA: 0x08560C04  token: 0x6000513
        public static Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs) { }
        // RVA: 0x085609B8  token: 0x6000514
        public static Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        // RVA: 0x08560D50  token: 0x6000515
        public static Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        // RVA: 0x08560338  token: 0x6000516
        public System.DateTime ToDateTime() { }
        // RVA: 0x085602C0  token: 0x6000517
        public System.DateTimeOffset ToDateTimeOffset() { }
        // RVA: 0x08560008  token: 0x6000518
        public static Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime) { }
        // RVA: 0x0855FFA0  token: 0x6000519
        public static Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset) { }
        // RVA: 0x08560234  token: 0x600051A
        private static Google.Protobuf.WellKnownTypes.Timestamp Normalize(System.Int64 seconds, System.Int32 nanoseconds) { }
        // RVA: 0x085604B8  token: 0x600051B
        private static System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly) { }
        // RVA: 0x0855FEA8  token: 0x600051C
        public virtual System.Int32 CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        // RVA: 0x08560BE4  token: 0x600051D
        public static System.Boolean op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560B48  token: 0x600051E
        public static System.Boolean op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560BC0  token: 0x600051F
        public static System.Boolean op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560B24  token: 0x6000520
        public static System.Boolean op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560B08  token: 0x6000521
        public static System.Boolean op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560B6C  token: 0x6000522
        public static System.Boolean op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        // RVA: 0x08560460  token: 0x6000523
        public virtual System.String ToDiagnosticString() { }
        // RVA: 0x08560774  token: 0x6000524
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000084  // size: 0x10
    public static class TypeReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x08561C7C */ }

        // Methods
        // RVA: 0x08560EE8  token: 0x6000529
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000085  // size: 0x14
    public sealed struct Syntax
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Google.Protobuf.WellKnownTypes.Syntax Proto2;  // const
        public static Google.Protobuf.WellKnownTypes.Syntax Proto3;  // const

    }

    // TypeToken: 0x2000086  // size: 0x48
    public sealed class Type : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 FieldsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_;  // 0x20
        public static System.Int32 OneofsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_oneofs_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> oneofs_;  // 0x28
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x30
        public static System.Int32 SourceContextFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;  // 0x38
        public static System.Int32 SyntaxFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;  // 0x40

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> Parser { get; /* RVA: 0x08578D70 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08578D10 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08579168 */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x085791A8 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> Fields { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Collections.RepeatedField<System.String> Oneofs { get; /* RVA: 0x03D4EAC0 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x01003830 */ }
        Google.Protobuf.WellKnownTypes.SourceContext SourceContext { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        Google.Protobuf.WellKnownTypes.Syntax Syntax { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x03D4EDB0 */ }

        // Methods
        // RVA: 0x08578AB0  token: 0x600052D
        public System.Void .ctor() { }
        // RVA: 0x08578BDC  token: 0x600052E
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Type other) { }
        // RVA: 0x08578444  token: 0x600052F
        public virtual Google.Protobuf.WellKnownTypes.Type Clone() { }
        // RVA: 0x085785B0  token: 0x6000539
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x085784A4  token: 0x600053A
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Type other) { }
        // RVA: 0x08578614  token: 0x600053B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08578858  token: 0x600053C
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600053D
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08578FE0  token: 0x600053E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085782AC  token: 0x600053F
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x085786F4  token: 0x6000540
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Type other) { }
        // RVA: 0x03D47500  token: 0x6000541
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08578DC0  token: 0x6000542
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085788A4  token: 0x6000543
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x58
    public sealed class Field : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 KindFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Field.Types.Kind kind_;  // 0x18
        public static System.Int32 CardinalityFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Field.Types.Cardinality cardinality_;  // 0x1c
        public static System.Int32 NumberFieldNumber;  // const
        private System.Int32 number_;  // 0x20
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x28
        public static System.Int32 TypeUrlFieldNumber;  // const
        private System.String typeUrl_;  // 0x30
        public static System.Int32 OneofIndexFieldNumber;  // const
        private System.Int32 oneofIndex_;  // 0x38
        public static System.Int32 PackedFieldNumber;  // const
        private System.Boolean packed_;  // 0x3c
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x40
        public static System.Int32 JsonNameFieldNumber;  // const
        private System.String jsonName_;  // 0x48
        public static System.Int32 DefaultValueFieldNumber;  // const
        private System.String defaultValue_;  // 0x50

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> Parser { get; /* RVA: 0x08573204 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085731A4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08573668 */ }
        Google.Protobuf.WellKnownTypes.Field.Types.Kind Kind { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Cardinality { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        System.Int32 Number { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }
        System.String Name { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x08573778 */ }
        System.String TypeUrl { get; /* RVA: 0x01003830 */ set; /* RVA: 0x085737E0 */ }
        System.Int32 OneofIndex { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.Boolean Packed { get; /* RVA: 0x03D4F460 */ set; /* RVA: 0x03D4F470 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x03D4E2B0 */ }
        System.String JsonName { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x08573710 */ }
        System.String DefaultValue { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x085736A8 */ }

        // Methods
        // RVA: 0x085730D0  token: 0x600054A
        public System.Void .ctor() { }
        // RVA: 0x08572FE0  token: 0x600054B
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Field other) { }
        // RVA: 0x085729F8  token: 0x600054C
        public virtual Google.Protobuf.WellKnownTypes.Field Clone() { }
        // RVA: 0x08572B64  token: 0x6000560
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08572A58  token: 0x6000561
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Field other) { }
        // RVA: 0x08572BC8  token: 0x6000562
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08572E24  token: 0x6000563
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000564
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x08573468  token: 0x6000565
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085727E0  token: 0x6000566
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08572CF0  token: 0x6000567
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Field other) { }
        // RVA: 0x03D47500  token: 0x6000568
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08573254  token: 0x6000569
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08572E70  token: 0x600056A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200008D  // size: 0x40
    public sealed class Enum : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 EnumvalueFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue> _repeated_enumvalue_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> enumvalue_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x28
        public static System.Int32 SourceContextFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;  // 0x30
        public static System.Int32 SyntaxFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;  // 0x38

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> Parser { get; /* RVA: 0x0856FBB4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0856FB54 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0856FF20 */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0856FF60 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> Enumvalue { get; /* RVA: 0x03D4EB40 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x03D4EAC0 */ }
        Google.Protobuf.WellKnownTypes.SourceContext SourceContext { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        Google.Protobuf.WellKnownTypes.Syntax Syntax { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }

        // Methods
        // RVA: 0x0856F970  token: 0x6000571
        public System.Void .ctor() { }
        // RVA: 0x0856FA50  token: 0x6000572
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Enum other) { }
        // RVA: 0x0856F3B0  token: 0x6000573
        public virtual Google.Protobuf.WellKnownTypes.Enum Clone() { }
        // RVA: 0x0856F410  token: 0x600057C
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0856F474  token: 0x600057D
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Enum other) { }
        // RVA: 0x0856F554  token: 0x600057E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0856F74C  token: 0x600057F
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000580
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0856FDD4  token: 0x6000581
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0856F244  token: 0x6000582
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0856F610  token: 0x6000583
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other) { }
        // RVA: 0x03D47500  token: 0x6000584
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0856FC04  token: 0x6000585
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0856F798  token: 0x6000586
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200008F  // size: 0x30
    public sealed class EnumValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 NumberFieldNumber;  // const
        private System.Int32 number_;  // 0x20
        public static System.Int32 OptionsFieldNumber;  // const
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;  // static @ 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;  // 0x28

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> Parser { get; /* RVA: 0x0856EF34 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0856EED4 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0856F19C */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0856F1DC */ }
        System.Int32 Number { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }
        Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x0856EE3C  token: 0x600058D
        public System.Void .ctor() { }
        // RVA: 0x0856ED9C  token: 0x600058E
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        // RVA: 0x0856E9E0  token: 0x600058F
        public virtual Google.Protobuf.WellKnownTypes.EnumValue Clone() { }
        // RVA: 0x0856EA40  token: 0x6000595
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0856EAA4  token: 0x6000596
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        // RVA: 0x051B8B70  token: 0x6000597
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0856EBE0  token: 0x6000598
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000599
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0856F0A8  token: 0x600059A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0856E8E4  token: 0x600059B
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0856EB3C  token: 0x600059C
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        // RVA: 0x03D47500  token: 0x600059D
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0856EF84  token: 0x600059E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0856EC2C  token: 0x600059F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000091  // size: 0x28
    public sealed class Option : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 NameFieldNumber;  // const
        private System.String name_;  // 0x18
        public static System.Int32 ValueFieldNumber;  // const
        private Google.Protobuf.WellKnownTypes.Any value_;  // 0x20

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> Parser { get; /* RVA: 0x08577480 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08577420 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085775C4 */ }
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x08577604 */ }
        Google.Protobuf.WellKnownTypes.Any Value { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x085773E0  token: 0x60005A6
        public System.Void .ctor() { }
        // RVA: 0x08577364  token: 0x60005A7
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Option other) { }
        // RVA: 0x08577074  token: 0x60005A8
        public virtual Google.Protobuf.WellKnownTypes.Option Clone() { }
        // RVA: 0x085770D4  token: 0x60005AD
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x051B076C  token: 0x60005AE
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Option other) { }
        // RVA: 0x051B07D4  token: 0x60005AF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08577214  token: 0x60005B0
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60005B1
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x051B0C24  token: 0x60005B2
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08576FC8  token: 0x60005B3
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08577138  token: 0x60005B4
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Option other) { }
        // RVA: 0x03D47500  token: 0x60005B5
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x085774D0  token: 0x60005B6
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08577260  token: 0x60005B7
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x10
    public static class WrappersReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;  // static @ 0x0
        private static System.Int32 WrapperValueFieldNumber;  // const

        // Properties
        Google.Protobuf.Reflection.FileDescriptor Descriptor { get; /* RVA: 0x0857B2F4 */ }

        // Methods
        // RVA: 0x0857A790  token: 0x60005BC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000094  // size: 0x20
    public sealed class DoubleValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.Double value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> Parser { get; /* RVA: 0x0856D8F8 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0856D898 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0856D948 */ }
        System.Double Value { get; /* RVA: 0x03D4EBD0 */ set; /* RVA: 0x03D4EBE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60005C0
        public System.Void .ctor() { }
        // RVA: 0x0517A59C  token: 0x60005C1
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        // RVA: 0x0856D564  token: 0x60005C2
        public virtual Google.Protobuf.WellKnownTypes.DoubleValue Clone() { }
        // RVA: 0x0856D650  token: 0x60005C5
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0856D5C4  token: 0x60005C6
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        // RVA: 0x0856D6B4  token: 0x60005C7
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0856D748  token: 0x60005C8
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60005C9
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x053CFAC8  token: 0x60005CA
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x053CF694  token: 0x60005CB
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x053CF8B4  token: 0x60005CC
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        // RVA: 0x03D47500  token: 0x60005CD
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x053CFA54  token: 0x60005CE
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0856D794  token: 0x60005CF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000096  // size: 0x20
    public sealed class FloatValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.Single value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> Parser { get; /* RVA: 0x08575FF0 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08575F90 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08576040 */ }
        System.Single Value { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x03D4EC00 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60005D6
        public System.Void .ctor() { }
        // RVA: 0x051AA354  token: 0x60005D7
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        // RVA: 0x08575C58  token: 0x60005D8
        public virtual Google.Protobuf.WellKnownTypes.FloatValue Clone() { }
        // RVA: 0x08575CB8  token: 0x60005DB
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08575D1C  token: 0x60005DC
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        // RVA: 0x08575DAC  token: 0x60005DD
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08575E40  token: 0x60005DE
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60005DF
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x053EFF04  token: 0x60005E0
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x053EFAD0  token: 0x60005E1
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x053EFCF4  token: 0x60005E2
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        // RVA: 0x03D47500  token: 0x60005E3
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x053EFE90  token: 0x60005E4
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08575E8C  token: 0x60005E5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000098  // size: 0x20
    public sealed class Int64Value : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.Int64 value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> Parser { get; /* RVA: 0x085766D4 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08576674 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08576724 */ }
        System.Int64 Value { get; /* RVA: 0x01041090 */ set; /* RVA: 0x03D4EC10 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60005EC
        public System.Void .ctor() { }
        // RVA: 0x0517A59C  token: 0x60005ED
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        // RVA: 0x08576460  token: 0x60005EE
        public virtual Google.Protobuf.WellKnownTypes.Int64Value Clone() { }
        // RVA: 0x085764C0  token: 0x60005F1
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0517A39C  token: 0x60005F2
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        // RVA: 0x0517A3C8  token: 0x60005F3
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08576524  token: 0x60005F4
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x60005F5
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0517A6FC  token: 0x60005F6
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x085763F0  token: 0x60005F7
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0517A40C  token: 0x60005F8
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        // RVA: 0x03D47500  token: 0x60005F9
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0517A688  token: 0x60005FA
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08576570  token: 0x60005FB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009A  // size: 0x20
    public sealed class UInt64Value : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.UInt64 value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> Parser { get; /* RVA: 0x0857A700 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857A6A0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857A750 */ }
        System.UInt64 Value { get; /* RVA: 0x01041090 */ set; /* RVA: 0x03D4EC10 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000602
        public System.Void .ctor() { }
        // RVA: 0x0517A59C  token: 0x6000603
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        // RVA: 0x0857A48C  token: 0x6000604
        public virtual Google.Protobuf.WellKnownTypes.UInt64Value Clone() { }
        // RVA: 0x0857A4EC  token: 0x6000607
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0517A39C  token: 0x6000608
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        // RVA: 0x0518F37C  token: 0x6000609
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857A550  token: 0x600060A
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600060B
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0518F5C0  token: 0x600060C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857A41C  token: 0x600060D
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0517A40C  token: 0x600060E
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        // RVA: 0x03D47500  token: 0x600060F
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0517A688  token: 0x6000610
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0857A59C  token: 0x6000611
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009C  // size: 0x20
    public sealed class Int32Value : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.Int32 value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> Parser { get; /* RVA: 0x08576360 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08576300 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x085763B0 */ }
        System.Int32 Value { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000618
        public System.Void .ctor() { }
        // RVA: 0x051AA354  token: 0x6000619
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        // RVA: 0x085760EC  token: 0x600061A
        public virtual Google.Protobuf.WellKnownTypes.Int32Value Clone() { }
        // RVA: 0x0857614C  token: 0x600061D
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x051AA14C  token: 0x600061E
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        // RVA: 0x051AA1DC  token: 0x600061F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x085761B0  token: 0x6000620
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000621
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x051AA450  token: 0x6000622
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08576080  token: 0x6000623
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x051AA214  token: 0x6000624
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        // RVA: 0x03D47500  token: 0x6000625
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x051AA3E0  token: 0x6000626
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085761FC  token: 0x6000627
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009E  // size: 0x20
    public sealed class UInt32Value : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.UInt32 value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> Parser { get; /* RVA: 0x0857A38C */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x0857A32C */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0857A3DC */ }
        System.UInt32 Value { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600062E
        public System.Void .ctor() { }
        // RVA: 0x051AA354  token: 0x600062F
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        // RVA: 0x0857A118  token: 0x6000630
        public virtual Google.Protobuf.WellKnownTypes.UInt32Value Clone() { }
        // RVA: 0x0857A178  token: 0x6000633
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x051AA14C  token: 0x6000634
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        // RVA: 0x051AA1DC  token: 0x6000635
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0857A1DC  token: 0x6000636
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000637
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0527B0C4  token: 0x6000638
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0857A0AC  token: 0x6000639
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x051AA214  token: 0x600063A
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        // RVA: 0x03D47500  token: 0x600063B
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x051AA3E0  token: 0x600063C
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x0857A228  token: 0x600063D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A0  // size: 0x20
    public sealed class BoolValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.Boolean value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> Parser { get; /* RVA: 0x08567B10 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08567AB0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08567B60 */ }
        System.Boolean Value { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000644
        public System.Void .ctor() { }
        // RVA: 0x0521BA50  token: 0x6000645
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        // RVA: 0x08567834  token: 0x6000646
        public virtual Google.Protobuf.WellKnownTypes.BoolValue Clone() { }
        // RVA: 0x08567894  token: 0x6000649
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x0521B818  token: 0x600064A
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        // RVA: 0x085678F8  token: 0x600064B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08567960  token: 0x600064C
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x600064D
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0521BB48  token: 0x600064E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x0521B788  token: 0x600064F
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x0521B910  token: 0x6000650
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        // RVA: 0x03D47500  token: 0x6000651
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x0521BADC  token: 0x6000652
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x085679AC  token: 0x6000653
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A2  // size: 0x20
    public sealed class StringValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private System.String value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> Parser { get; /* RVA: 0x08578138 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x085780D8 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x08578204 */ }
        System.String Value { get; /* RVA: 0x01041090 */ set; /* RVA: 0x08578244 */ }

        // Methods
        // RVA: 0x08578040  token: 0x600065A
        public System.Void .ctor() { }
        // RVA: 0x08578080  token: 0x600065B
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.StringValue other) { }
        // RVA: 0x08577DCC  token: 0x600065C
        public virtual Google.Protobuf.WellKnownTypes.StringValue Clone() { }
        // RVA: 0x08577E2C  token: 0x600065F
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x05188EA8  token: 0x6000660
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.StringValue other) { }
        // RVA: 0x05188F60  token: 0x6000661
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08577EF0  token: 0x6000662
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000663
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x0518932C  token: 0x6000664
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08577D50  token: 0x6000665
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08577E90  token: 0x6000666
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other) { }
        // RVA: 0x03D47500  token: 0x6000667
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08578188  token: 0x6000668
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08577F3C  token: 0x6000669
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A4  // size: 0x20
    public sealed class BytesValue : Google.Protobuf.IMessage`1, Google.Protobuf.IMessage, System.IEquatable`1, Google.Protobuf.IDeepCloneable`1, Google.Protobuf.IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> _parser;  // static @ 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;  // 0x10
        public static System.Int32 ValueFieldNumber;  // const
        private Google.Protobuf.ByteString value_;  // 0x18

        // Properties
        Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> Parser { get; /* RVA: 0x08568040 */ }
        Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; /* RVA: 0x08567FE0 */ }
        Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; /* RVA: 0x0856810C */ }
        Google.Protobuf.ByteString Value { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0856814C */ }

        // Methods
        // RVA: 0x08567F8C  token: 0x6000670
        public System.Void .ctor() { }
        // RVA: 0x08567F34  token: 0x6000671
        public System.Void .ctor(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        // RVA: 0x08567C24  token: 0x6000672
        public virtual Google.Protobuf.WellKnownTypes.BytesValue Clone() { }
        // RVA: 0x08567D18  token: 0x6000675
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x08567C84  token: 0x6000676
        public virtual System.Boolean Equals(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        // RVA: 0x051C30A0  token: 0x6000677
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x08567DE4  token: 0x6000678
        public virtual System.String ToString() { }
        // RVA: 0x03D47770  token: 0x6000679
        public virtual System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        // RVA: 0x051C33E8  token: 0x600067A
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        // RVA: 0x08567BA0  token: 0x600067B
        public virtual System.Int32 CalculateSize() { }
        // RVA: 0x08567D7C  token: 0x600067C
        public virtual System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        // RVA: 0x03D47500  token: 0x600067D
        public virtual System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        // RVA: 0x08568090  token: 0x600067E
        private virtual System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        // RVA: 0x08567E30  token: 0x600067F
        private static System.Void .cctor() { }

    }

}

namespace System.Diagnostics.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x18
    public sealed class DynamicallyAccessedMembersAttribute : System.Attribute
    {
        // Fields
        private readonly System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField;  // 0x10

        // Properties
        System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes MemberTypes { get; /* RVA: 0x03D4E340 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000001
        public System.Void .ctor(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes memberTypes) { }

    }

    // TypeToken: 0x2000003  // size: 0x14
    public sealed struct DynamicallyAccessedMemberTypes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes None;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicParameterlessConstructor;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicConstructors;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicConstructors;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicMethods;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicMethods;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicFields;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicFields;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicNestedTypes;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicNestedTypes;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicProperties;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicProperties;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicEvents;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicEvents;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes Interfaces;  // const
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes All;  // const

    }

    // TypeToken: 0x2000004  // size: 0x20
    public sealed class RequiresUnreferencedCodeAttribute : System.Attribute
    {
        // Fields
        private readonly System.String <Message>k__BackingField;  // 0x10
        private System.String <Url>k__BackingField;  // 0x18

        // Properties
        System.String Message { get; /* RVA: 0x020B7B20 */ }
        System.String Url { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000003
        public System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000005  // size: 0x40
    public sealed class UnconditionalSuppressMessageAttribute : System.Attribute
    {
        // Fields
        private readonly System.String <Category>k__BackingField;  // 0x10
        private readonly System.String <CheckId>k__BackingField;  // 0x18
        private System.String <Scope>k__BackingField;  // 0x20
        private System.String <Target>k__BackingField;  // 0x28
        private System.String <MessageId>k__BackingField;  // 0x30
        private System.String <Justification>k__BackingField;  // 0x38

        // Properties
        System.String Category { get; /* RVA: 0x020B7B20 */ }
        System.String CheckId { get; /* RVA: 0x01041090 */ }
        System.String Scope { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String Target { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        System.String MessageId { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        System.String Justification { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }

        // Methods
        // RVA: 0x02676770  token: 0x6000007
        public System.Void .ctor(System.String category, System.String checkId) { }

    }

}

