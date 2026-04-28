// ========================================================
// Dumped by @desirepro
// Assembly: ZString.dll
// Classes:  32
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000A  // size: 0x18
    public class HgStringBlock : System.IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Stack<Beyond.UnSafeString> m_stack;  // 0x10

        // Methods
        // RVA: 0x03A24E30  token: 0x600002E
        private System.Void .ctor(System.Int32 capacity) { }
        // RVA: 0x023AB0E0  token: 0x600002F
        private System.Void Push(Beyond.UnSafeString str) { }
        // RVA: 0x023A6C90  token: 0x6000030
        private virtual System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class HgThreadStringBlock : System.IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Stack<Beyond.UnSafeString> m_stack;  // 0x10

        // Methods
        // RVA: 0x0A2BE318  token: 0x6000031
        private virtual System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed struct UnSafeStringHandle : System.IDisposable
    {
        // Fields
        private System.Runtime.InteropServices.GCHandle m_stringHandler;  // 0x10

        // Methods
        // RVA: 0x02BDCD80  token: 0x6000032
        public static Beyond.UnSafeString.UnSafeStringHandle CreateHandle(System.Int32 count) { }
        // RVA: 0x04272C70  token: 0x6000033
        private System.Void .ctor(Beyond.UnSafeString unSafeString) { }
        // RVA: 0x0A2BFA24  token: 0x6000034
        public virtual System.Void Dispose() { }
        // RVA: 0x0A2BFAD4  token: 0x6000035
        public Beyond.UnSafeString Get() { }

    }

    // TypeToken: 0x200000D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.UnSafeString.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x03D0EED0  token: 0x6000036
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000037
        public System.Void .ctor() { }
        // RVA: 0x0A2BF964  token: 0x6000038
        private System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock> <.cctor>b__43_0() { }
        // RVA: 0x0A2BF9C4  token: 0x6000039
        private System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock> <.cctor>b__43_1() { }

    }

    // TypeToken: 0x2000013  // size: 0x30
    public sealed struct ParseResult
    {
        // Fields
        public readonly System.Int32 Index;  // 0x10
        public readonly System.ReadOnlySpan<System.Char> FormatString;  // 0x18
        public readonly System.Int32 LastIndex;  // 0x28
        public readonly System.Int32 Alignment;  // 0x2c

        // Methods
        // RVA: 0x03D8A220  token: 0x6000048
        public System.Void .ctor(System.Int32 index, System.ReadOnlySpan<System.Char> formatString, System.Int32 lastIndex, System.Int32 alignment) { }

    }

    // TypeToken: 0x2000017
    public sealed class TryFormat`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x600007D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x600007E
        public virtual System.Boolean Invoke(T value, System.Span<System.Char> destination, System.Int32& charsWritten, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x2000018
    public static class FormatterCache`1
    {
        // Fields
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<T> TryFormatDelegate;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600007F
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000080
        private static System.Boolean TryFormatString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: -1  // not resolved  token: 0x6000081
        private static System.Boolean TryFormatUnsafeString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: -1  // not resolved  token: 0x6000082
        private static System.Boolean TryFormatDefault(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x2000019  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cysharp.Text.Utf16ValueStringBuilder.<>c <>9;  // static @ 0x0
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Boolean> <>9__52_0;  // static @ 0x8
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.SByte> <>9__52_1;  // static @ 0x10
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int16> <>9__52_2;  // static @ 0x18
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int32> <>9__52_3;  // static @ 0x20
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int64> <>9__52_4;  // static @ 0x28
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Byte> <>9__52_5;  // static @ 0x30
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt16> <>9__52_6;  // static @ 0x38
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt32> <>9__52_7;  // static @ 0x40
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt64> <>9__52_8;  // static @ 0x48
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Single> <>9__52_9;  // static @ 0x50
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Double> <>9__52_10;  // static @ 0x58
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.TimeSpan> <>9__52_11;  // static @ 0x60
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.DateTime> <>9__52_12;  // static @ 0x68
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.DateTimeOffset> <>9__52_13;  // static @ 0x70
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Decimal> <>9__52_14;  // static @ 0x78
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Guid> <>9__52_15;  // static @ 0x80
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.IntPtr> <>9__52_16;  // static @ 0x88
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UIntPtr> <>9__52_17;  // static @ 0x90

        // Methods
        // RVA: 0x03D0DAF0  token: 0x6000083
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000084
        public System.Void .ctor() { }
        // RVA: 0x031937F0  token: 0x6000085
        private System.Boolean <CreateFormatter>b__52_0(System.Boolean x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF6B4  token: 0x6000086
        private System.Boolean <CreateFormatter>b__52_1(System.SByte x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF760  token: 0x6000087
        private System.Boolean <CreateFormatter>b__52_2(System.Int16 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x02D74AF0  token: 0x6000088
        private System.Boolean <CreateFormatter>b__52_3(System.Int32 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x02D74A70  token: 0x6000089
        private System.Boolean <CreateFormatter>b__52_4(System.Int64 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF80C  token: 0x600008A
        private System.Boolean <CreateFormatter>b__52_5(System.Byte x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF8B8  token: 0x600008B
        private System.Boolean <CreateFormatter>b__52_6(System.UInt16 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x02E57E70  token: 0x600008C
        private System.Boolean <CreateFormatter>b__52_7(System.UInt32 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x02E57DF0  token: 0x600008D
        private System.Boolean <CreateFormatter>b__52_8(System.UInt64 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x038ECCA0  token: 0x600008E
        private System.Boolean <CreateFormatter>b__52_9(System.Single x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x022FB710  token: 0x600008F
        private System.Boolean <CreateFormatter>b__52_10(System.Double x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF3E4  token: 0x6000090
        private System.Boolean <CreateFormatter>b__52_11(System.TimeSpan x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0267D730  token: 0x6000091
        private System.Boolean <CreateFormatter>b__52_12(System.DateTime x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF46C  token: 0x6000092
        private System.Boolean <CreateFormatter>b__52_13(System.DateTimeOffset x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF4F8  token: 0x6000093
        private System.Boolean <CreateFormatter>b__52_14(System.Decimal x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF584  token: 0x6000094
        private System.Boolean <CreateFormatter>b__52_15(System.Guid x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF5C8  token: 0x6000095
        private System.Boolean <CreateFormatter>b__52_16(System.IntPtr x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        // RVA: 0x0A2BF614  token: 0x6000096
        private System.Boolean <CreateFormatter>b__52_17(System.UIntPtr x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x200001A
    public sealed class <>c__170`1
    {
        // Fields
        public static readonly Cysharp.Text.Utf16ValueStringBuilder.<>c__170<T> <>9;  // static @ 0x0
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>> <>9__170_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000097
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000098
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000099
        private System.Boolean <CreateNullableFormatter>b__170_0(System.Nullable<T> x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x200001D  // size: 0x30
    public sealed struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x200001E  // size: 0x110
    public sealed struct __StaticArrayInitTypeSize=256
    {
    }

    // TypeToken: 0x200001C  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 1861BF4EAE96D61721D493270BADE6B1F1FFEB0A6BCA271EE90DC9B33E918625;  // static @ 0x0
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 3BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076;  // static @ 0x100
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652;  // static @ 0x120
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 E14330899333C68046C96292E14EF1B988B41F2809D50D9C2D5A83F2E83BF2AA;  // static @ 0x140

    }

namespace Beyond
{

    // TypeToken: 0x2000005  // size: 0x20
    public sealed struct MonoObject_64
    {
        // Fields
        public System.Void* p1;  // 0x10
        public System.Void* p2;  // 0x18

    }

    // TypeToken: 0x2000006  // size: 0x20
    public sealed struct MonoObject_32
    {
        // Fields
        public System.Void* p1;  // 0x10
        public System.Void* p2;  // 0x14

    }

    // TypeToken: 0x2000007  // size: 0x28
    public sealed struct MonoString_64
    {
        // Fields
        public Beyond.MonoObject_64 obj;  // 0x10
        public System.Int32 length;  // 0x20
        public System.Char firstChar;  // 0x24

    }

    // TypeToken: 0x2000008  // size: 0x20
    public sealed struct MonoString_32
    {
        // Fields
        public Beyond.MonoObject_32 obj;  // 0x10
        public System.Int32 length;  // 0x18
        public System.Char firstChar;  // 0x1c

    }

    // TypeToken: 0x2000009  // size: 0x30
    public class UnSafeString
    {
        // Fields
        private static System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock> s_blocks;  // static @ 0x0
        private static System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock> s_stackBlocks;  // static @ 0x8
        private static Beyond.UnSafeString.HgStringBlock s_currentBlock;  // static @ 0x10
        private static System.Threading.ThreadLocal<System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock>> s_threadBlockPool;  // static @ 0x18
        private static System.Threading.ThreadLocal<System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock>> s_threadStackBlocks;  // static @ 0x20
        private static System.Threading.ThreadLocal<Beyond.UnSafeString.HgThreadStringBlock> s_threadCurrentBlock;  // static @ 0x28
        private static System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString> s_threadSharedStringPool;  // static @ 0x30
        private static readonly System.Char[] UP_TABLE;  // static @ 0x38
        private static readonly System.Char[] LOW_TABLE;  // static @ 0x40
        private System.String m_buffer;  // 0x10
        private System.UInt64 m_handler;  // 0x18
        private System.Int32* m_strCount;  // 0x20
        private System.Int32 m_length;  // 0x28
        private System.Boolean m_resizeFlag;  // 0x2c
        public static Beyond.UnSafeString Empty;  // static @ 0x48
        public static System.Int32 s_mainThread;  // static @ 0x50
        private static System.Collections.Generic.Queue<Beyond.UnSafeString>[] s_freeListPool;  // static @ 0x58
        private static System.Collections.Generic.Queue<Beyond.UnSafeString>[] s_secondFreeListPool;  // static @ 0x60
        private static System.Collections.Generic.Dictionary<Unity.Mathematics.uint2,System.String> s_sharedStringPool;  // static @ 0x68

        // Properties
        System.Int32 Length { get; /* RVA: 0x03D8A240 */ set; /* RVA: 0x03D8A250 */ }

        // Methods
        // RVA: 0x023A8410  token: 0x6000005
        public System.Void Append(System.Char value) { }
        // RVA: 0x023A67B0  token: 0x6000006
        public System.Void Append(System.Char* value, System.Int32 count) { }
        // RVA: 0x02CB51F0  token: 0x6000007
        public System.Void Append(System.Int32 value) { }
        // RVA: 0x023A8F70  token: 0x6000008
        public System.Void Append(System.String value) { }
        // RVA: 0x0267F210  token: 0x6000009
        public System.Void Append(System.Span<System.Char> value) { }
        // RVA: 0x026F1E30  token: 0x600000A
        public System.Void Replace(System.Char newChar, System.Int32 Index) { }
        // RVA: 0x028DA400  token: 0x600000B
        public System.Void Append(Beyond.UnSafeString value) { }
        // RVA: 0x0A2BFB44  token: 0x600000C
        public System.Void Append(System.Byte* value, System.Int32 count) { }
        // RVA: 0x0A2C00D0  token: 0x600000D
        private System.Int32 _GetUTF8ByteCnt(System.Byte bt) { }
        // RVA: 0x023A68D0  token: 0x600000E
        public static System.IDisposable Scope() { }
        // RVA: -1  // generic def  token: 0x600000F
        public static Beyond.UnSafeString Concat(T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x6000010
        public static Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x6000011
        public static Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: 0x03802010  token: 0x6000014
        private static System.Void .cctor() { }
        // RVA: 0x026808F0  token: 0x6000015
        private System.Void .ctor(System.Int32 count) { }
        // RVA: 0x023AB380  token: 0x6000016
        public static Beyond.UnSafeString Create(System.Int32 count) { }
        // RVA: 0x02680870  token: 0x6000017
        public static Beyond.UnSafeString CreateRaw(System.Int32 count) { }
        // RVA: 0x030CE230  token: 0x6000018
        public System.Void Dispose() { }
        // RVA: 0x023AA3F0  token: 0x6000019
        public System.Int32 GetStringBufferSize() { }
        // RVA: 0x023AB2E0  token: 0x600001A
        public System.Void Clear() { }
        // RVA: 0x0268C6B0  token: 0x600001B
        public System.String CloneString() { }
        // RVA: 0x0A2BFDAC  token: 0x600001C
        public System.Void CloneToBytes(System.Span<System.Byte> bytes) { }
        // RVA: 0x023A9D90  token: 0x600001D
        public virtual System.String ToString() { }
        // RVA: 0x0A2C0168  token: 0x600001E
        private System.Void _Resize(System.Int32 size) { }
        // RVA: 0x0A2BFEDC  token: 0x600001F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x028DBFB0  token: 0x6000020
        public System.Void ToLow() { }
        // RVA: 0x0A2C0054  token: 0x6000021
        public static Beyond.UnSafeString GetUnsafeString(System.Char* ptr, System.Int32 length) { }
        // RVA: 0x0A2BFF84  token: 0x6000022
        public static Beyond.UnSafeString GetUnsafeStringUTF8(System.Span<System.Byte> span) { }
        // RVA: -1  // generic def  token: 0x6000023
        public static Beyond.UnSafeString Format(System.String formatString, T arg) { }
        // RVA: -1  // generic def  token: 0x6000024
        public static Beyond.UnSafeString Format(System.String formatString, T1 arg, T2 arg1) { }
        // RVA: -1  // generic def  token: 0x6000025
        public static Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x6000026
        public static Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: -1  // generic def  token: 0x6000027
        public static Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        // RVA: 0x024BCCB0  token: 0x6000028
        public static System.String op_Implicit(Beyond.UnSafeString value) { }
        // RVA: 0x0A2C0250  token: 0x6000029
        public static Beyond.UnSafeString op_Implicit(System.String value) { }
        // RVA: 0x023AA470  token: 0x600002A
        public static Beyond.UnSafeString TryGetUnSafeStringFromPool(System.Int32 requestStringLength, System.Boolean inScope) { }
        // RVA: 0x023A9E10  token: 0x600002B
        private static System.Void _RecycleString(Beyond.UnSafeString uString) { }
        // RVA: 0x030CDFB0  token: 0x600002C
        public static System.Void FreeCacheMemory() { }
        // RVA: 0x02815240  token: 0x600002D
        public System.Void Split(System.Char separator, System.Collections.Generic.List<Beyond.UnSafeString>& list) { }

    }

}

namespace Cysharp.Text
{

    // TypeToken: 0x200000F
    public static class EnumUtil`1
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<T,System.String> names;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<T,System.Byte[]> utf8names;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000040
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x6000041
        public static System.Boolean TryFormatUtf16(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> _) { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class ExceptionUtil
    {
        // Methods
        // RVA: 0x0A2BE06C  token: 0x6000042
        private static System.Void ThrowFormatException() { }
        // RVA: 0x0A2BE010  token: 0x6000043
        private static System.Void ThrowFormatError() { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public static class FastNumberWriter
    {
        // Methods
        // RVA: 0x02D74B70  token: 0x6000044
        public static System.Boolean TryWriteInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.Int64 value) { }
        // RVA: 0x02E57EF0  token: 0x6000045
        public static System.Boolean TryWriteUInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.UInt64 value) { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public static class FormatParser
    {
        // Methods
        // RVA: 0x0A2BE0C8  token: 0x6000046
        private static System.Boolean IsDigit(System.Char c) { }
        // RVA: 0x0A2BE0E0  token: 0x6000047
        public static Cysharp.Text.FormatParser.ParseResult Parse(System.String format, System.Int32 i) { }

    }

    // TypeToken: 0x2000014  // size: 0x90
    public class NestedStringBuilderCreationException : System.InvalidOperationException
    {
        // Methods
        // RVA: 0x0A2BF2F8  token: 0x6000049
        protected internal System.Void .ctor(System.String typeName, System.String extraMessage) { }

    }

    // TypeToken: 0x2000015
    public sealed struct ReadOnlyListAdaptor`1 : System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private readonly System.Collections.Generic.IList<T> _list;  // 0x0

        // Properties
        T Item { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600004A
        public System.Void .ctor(System.Collections.Generic.IList<T> list) { }
        // RVA: -1  // not resolved  token: 0x600004D
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600004E
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public sealed struct Utf16ValueStringBuilder : System.IDisposable, System.Buffers.IBufferWriter`1
    {
        // Fields
        private static System.Char newLine1;  // static @ 0x0
        private static System.Char newLine2;  // static @ 0x2
        private static System.Boolean crlf;  // static @ 0x4
        private static System.Char[] scratchBuffer;  // static @ 0xffffffff
        private static System.Boolean scratchBufferUsed;  // static @ 0xffffffff
        private System.Char[] buffer;  // 0x10
        private System.Int32 index;  // 0x18
        private System.Boolean disposeImmediately;  // 0x1c

        // Properties
        System.Int32 Length { get; /* RVA: 0x03D516F0 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x600004F
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        // RVA: -1  // generic def  token: 0x6000050
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values) { }
        // RVA: -1  // generic def  token: 0x6000051
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // generic def  token: 0x6000052
        public System.Void AppendFormat(System.String format, T1 arg1) { }
        // RVA: -1  // generic def  token: 0x6000053
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x6000054
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x6000055
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: -1  // generic def  token: 0x6000056
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        // RVA: -1  // generic def  token: 0x6000057
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        // RVA: -1  // generic def  token: 0x6000058
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        // RVA: -1  // generic def  token: 0x6000059
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        // RVA: -1  // generic def  token: 0x600005A
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        // RVA: -1  // generic def  token: 0x600005B
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        // RVA: -1  // generic def  token: 0x600005C
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        // RVA: -1  // generic def  token: 0x600005D
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        // RVA: -1  // generic def  token: 0x600005E
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        // RVA: -1  // generic def  token: 0x600005F
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        // RVA: -1  // generic def  token: 0x6000060
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        // RVA: -1  // generic def  token: 0x6000061
        public System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
        // RVA: 0x0332A040  token: 0x6000062
        private static System.Object CreateFormatter(System.Type type) { }
        // RVA: 0x0A2C0598  token: 0x6000063
        public System.Void Append(System.Int32 value) { }
        // RVA: 0x031EDB90  token: 0x6000064
        private static System.Void .cctor() { }
        // RVA: 0x0A2C09DC  token: 0x6000066
        public System.ReadOnlySpan<System.Char> AsSpan() { }
        // RVA: 0x0A2C097C  token: 0x6000067
        public System.ArraySegment<System.Char> AsArraySegment() { }
        // RVA: 0x0A2C0EB4  token: 0x6000068
        public System.Void .ctor(System.Boolean disposeImmediately) { }
        // RVA: 0x0A2C0A6C  token: 0x6000069
        public virtual System.Void Dispose() { }
        // RVA: 0x0A2C0C6C  token: 0x600006A
        public System.Void Grow(System.Int32 sizeHint) { }
        // RVA: 0x0A2C034C  token: 0x600006B
        public System.Void AppendLine() { }
        // RVA: 0x0A2C078C  token: 0x600006C
        public System.Void Append(System.Char value) { }
        // RVA: 0x0A2C04B0  token: 0x600006D
        public System.Void Append(System.Char value, System.Int32 repeatCount) { }
        // RVA: 0x0A2C081C  token: 0x600006E
        public System.Void Append(System.String value) { }
        // RVA: 0x0A2C02F4  token: 0x600006F
        public System.Void AppendLine(System.String value) { }
        // RVA: 0x0A2C088C  token: 0x6000070
        public System.Void Append(System.String value, System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x0A2C06C4  token: 0x6000071
        public System.Void Append(System.ReadOnlySpan<System.Char> value) { }
        // RVA: -1  // generic def  token: 0x6000072
        public System.Void Append(T value) { }
        // RVA: 0x023AE130  token: 0x6000073
        public virtual System.String ToString() { }
        // RVA: 0x0A2C0B28  token: 0x6000074
        public virtual System.Memory<System.Char> GetMemory(System.Int32 sizeHint) { }
        // RVA: 0x0A2C0BD0  token: 0x6000075
        public virtual System.Span<System.Char> GetSpan(System.Int32 sizeHint) { }
        // RVA: 0x03D6E610  token: 0x6000076
        public virtual System.Void Advance(System.Int32 count) { }
        // RVA: 0x0A2C0D84  token: 0x6000077
        private System.Void ThrowArgumentException(System.String paramName) { }
        // RVA: 0x0A2C0DE8  token: 0x6000078
        private static System.Void ThrowFormatException() { }
        // RVA: -1  // generic def  token: 0x6000079
        private System.Void AppendFormatInternal(T arg, System.Int32 width, System.ReadOnlySpan<System.Char> format, System.String argName) { }
        // RVA: 0x0A2C0E44  token: 0x600007A
        private static System.Void ThrowNestedException() { }
        // RVA: -1  // generic def  token: 0x600007B
        private static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>> CreateNullableFormatter() { }
        // RVA: 0x023ABD30  token: 0x600007C
        public System.Char& GetPinnableReference() { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public static class ZString
    {
        // Fields
        private static System.Text.Encoding UTF8NoBom;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x600009A
        public static System.String Concat(T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x600009B
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x600009C
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: -1  // generic def  token: 0x600009D
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        // RVA: -1  // generic def  token: 0x600009E
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        // RVA: -1  // generic def  token: 0x600009F
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        // RVA: -1  // generic def  token: 0x60000A0
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        // RVA: -1  // generic def  token: 0x60000A1
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        // RVA: -1  // generic def  token: 0x60000A2
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        // RVA: -1  // generic def  token: 0x60000A3
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        // RVA: -1  // generic def  token: 0x60000A4
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        // RVA: -1  // generic def  token: 0x60000A5
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        // RVA: -1  // generic def  token: 0x60000A6
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        // RVA: -1  // generic def  token: 0x60000A7
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        // RVA: -1  // generic def  token: 0x60000A8
        public static System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
        // RVA: 0x0284E090  token: 0x60000A9
        public static Cysharp.Text.Utf16ValueStringBuilder CreateStringBuilder() { }
        // RVA: -1  // generic def  token: 0x60000AA
        public static System.String Join(System.Char separator, T[] values) { }
        // RVA: -1  // generic def  token: 0x60000AB
        public static System.String Join(System.Char separator, System.Collections.Generic.List<T> values) { }
        // RVA: -1  // generic def  token: 0x60000AC
        public static System.String Join(System.Char separator, System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // generic def  token: 0x60000AD
        public static System.String Join(System.Char separator, System.Collections.Generic.ICollection<T> values) { }
        // RVA: -1  // generic def  token: 0x60000AE
        public static System.String Join(System.Char separator, System.Collections.Generic.IList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000AF
        public static System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B0
        public static System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B1
        public static System.String Join(System.String separator, System.Collections.Generic.List<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B2
        public static System.String Join(System.String separator, System.Collections.Generic.ICollection<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B3
        public static System.String Join(System.String separator, System.Collections.Generic.IList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B4
        public static System.String Join(System.String separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B5
        public static System.String Join(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B6
        public static System.String Join(System.String separator, System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B7
        private static System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B8
        private static System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        // RVA: -1  // generic def  token: 0x60000B9
        private static System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values) { }
        // RVA: -1  // generic def  token: 0x60000BA
        private static System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values) { }
        // RVA: -1  // generic def  token: 0x60000BB
        public static System.String Format(System.String format, T1 arg1) { }
        // RVA: -1  // generic def  token: 0x60000BC
        public static System.String Format(System.String format, T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x60000BD
        public static System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x60000BE
        public static System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: -1  // generic def  token: 0x60000BF
        public static System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        // RVA: -1  // generic def  token: 0x60000C0
        public static System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        // RVA: 0x03A28DB0  token: 0x60000C1
        private static System.Void .cctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200001F  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x0A2BE548  token: 0x60000C2
        public System.Void __Gen_Wrap_0(System.Object P0, System.Char P1) { }
        // RVA: 0x0549D548  token: 0x60000C3
        public System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        // RVA: 0x05163BA0  token: 0x60000C4
        public System.Void __Gen_Wrap_3(System.Object P0, System.Object P1) { }
        // RVA: 0x0A2BF014  token: 0x60000C5
        public System.Void __Gen_Wrap_5(System.Object P0, System.Span<System.Char> P1) { }
        // RVA: 0x0A2BF128  token: 0x60000C6
        public System.Void __Gen_Wrap_6(System.Object P0, System.Char P1, System.Int32 P2) { }
        // RVA: 0x0A2BF220  token: 0x60000C7
        public System.Int32 __Gen_Wrap_8(System.Object P0, System.Byte P1) { }
        // RVA: 0x04274234  token: 0x60000C8
        public System.Void __Gen_Wrap_9(System.Object P0) { }
        // RVA: 0x050F3444  token: 0x60000C9
        public System.Void __Gen_Wrap_10() { }
        // RVA: 0x0A2BE624  token: 0x60000CA
        public System.IDisposable __Gen_Wrap_11() { }
        // RVA: 0x0A2BE6F0  token: 0x60000CB
        public Beyond.UnSafeString __Gen_Wrap_12(System.Int32 P0, System.Boolean P1) { }
        // RVA: 0x0A2BE7FC  token: 0x60000CC
        public Beyond.UnSafeString __Gen_Wrap_13(System.Int32 P0) { }
        // RVA: 0x050EF614  token: 0x60000CD
        public System.Int32 __Gen_Wrap_14(System.Object P0) { }
        // RVA: 0x0A2BE8E8  token: 0x60000CE
        public System.String __Gen_Wrap_15(System.Object P0) { }
        // RVA: 0x0A2BE9D8  token: 0x60000CF
        public System.Void __Gen_Wrap_16(System.Object P0, System.Span<System.Byte> P1) { }
        // RVA: 0x0A2BEAD8  token: 0x60000D0
        public Beyond.UnSafeString __Gen_Wrap_23(System.Span<System.Byte> P0) { }
        // RVA: 0x0A2BEBD8  token: 0x60000D1
        public Beyond.UnSafeString __Gen_Wrap_24(System.Object P0) { }
        // RVA: 0x0A2BECC8  token: 0x60000D2
        public System.Void __Gen_Wrap_31(System.Object P0, System.Char P1, System.Collections.Generic.List<Beyond.UnSafeString>& P2) { }
        // RVA: 0x0A2BEE0C  token: 0x60000D3
        public Beyond.UnSafeString.UnSafeStringHandle __Gen_Wrap_32(System.Int32 P0) { }
        // RVA: 0x0A2BEEF8  token: 0x60000D4
        public System.Void __Gen_Wrap_33(Beyond.UnSafeString.UnSafeStringHandle& P0) { }
        // RVA: 0x03D05B80  token: 0x60000D5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public class WrappersManagerImpl
    {
        // Methods
        // RVA: 0x0A2C1038  token: 0x60000D6
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x023A8500  token: 0x60000D7
        public static System.Boolean IsPatched(System.Int32 id) { }

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

namespace System.Numerics
{

    // TypeToken: 0x200000E  // size: 0x10
    public static class BitOperations
    {
        // Properties
        System.ReadOnlySpan<System.Byte> TrailingZeroCountDeBruijn { get; /* RVA: 0x023DE440 */ }
        System.ReadOnlySpan<System.Byte> Log2DeBruijn { get; /* RVA: 0x0A2BDFB4 */ }

        // Methods
        // RVA: 0x0473A550  token: 0x600003C
        public static System.Int32 LeadingZeroCount(System.UInt32 value) { }
        // RVA: 0x0A2BDEA4  token: 0x600003D
        private static System.Int32 Log2SoftwareFallback(System.UInt32 value) { }
        // RVA: 0x0A2BDF24  token: 0x600003E
        public static System.Int32 TrailingZeroCount(System.UInt32 value) { }
        // RVA: 0x0A2BDF94  token: 0x600003F
        public static System.Int32 TrailingZeroCount(System.UInt64 value) { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x18
    public sealed class NullableAttribute : System.Attribute
    {
        // Fields
        public readonly System.Byte[] NullableFlags;  // 0x10

        // Methods
        // RVA: 0x0A2BF374  token: 0x6000002
        public System.Void .ctor(System.Byte ) { }
        // RVA: 0x0426FEE0  token: 0x6000003
        public System.Void .ctor(System.Byte[] ) { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class NullableContextAttribute : System.Attribute
    {
        // Fields
        public readonly System.Byte Flag;  // 0x10

        // Methods
        // RVA: 0x03D4E960  token: 0x6000004
        public System.Void .ctor(System.Byte ) { }

    }

}

