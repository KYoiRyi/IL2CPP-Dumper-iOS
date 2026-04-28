// ========================================================
// Dumped by @desirepro
// Assembly: ZString.dll
// Classes:  32
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

CLASS: HgStringBlock
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Collections.Generic.Stack<Beyond.UnSafeString>m_stack  // 0x10
METHODS:
  RVA=0x03A24E30  token=0x600002E  System.Void .ctor(System.Int32 capacity)
  RVA=0x023AB0E0  token=0x600002F  System.Void Push(Beyond.UnSafeString str)
  RVA=0x023A6C90  token=0x6000030  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: HgThreadStringBlock
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Collections.Generic.Stack<Beyond.UnSafeString>m_stack  // 0x10
METHODS:
  RVA=0x0A2BE318  token=0x6000031  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: UnSafeStringHandle
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Runtime.InteropServices.GCHandlem_stringHandler  // 0x10
METHODS:
  RVA=0x02BDCD80  token=0x6000032  Beyond.UnSafeString.UnSafeStringHandle CreateHandle(System.Int32 count)
  RVA=0x04272C70  token=0x6000033  System.Void .ctor(Beyond.UnSafeString unSafeString)
  RVA=0x0A2BFA24  token=0x6000034  System.Void Dispose()
  RVA=0x0A2BFAD4  token=0x6000035  Beyond.UnSafeString Get()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.UnSafeString.<>c         <>9  // static @ 0x0
METHODS:
  RVA=0x03D0EED0  token=0x6000036  System.Void .cctor()
  RVA=0x0350B670  token=0x6000037  System.Void .ctor()
  RVA=0x0A2BF964  token=0x6000038  System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock> <.cctor>b__43_0()
  RVA=0x0A2BF9C4  token=0x6000039  System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock> <.cctor>b__43_1()
END_CLASS

CLASS: ParseResult
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x30
FIELDS:
  public    readonly System.Int32                    Index  // 0x10
  public    readonly System.ReadOnlySpan<System.Char>FormatString  // 0x18
  public    readonly System.Int32                    LastIndex  // 0x28
  public    readonly System.Int32                    Alignment  // 0x2c
METHODS:
  RVA=0x03D8A220  token=0x6000048  System.Void .ctor(System.Int32 index, System.ReadOnlySpan<System.Char> formatString, System.Int32 lastIndex, System.Int32 alignment)
END_CLASS

CLASS: TryFormat`1
TYPE:  sealed class
TOKEN: 0x2000017
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600007D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600007E  System.Boolean Invoke(T value, System.Span<System.Char> destination, System.Int32& charsWritten, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: FormatterCache`1
TYPE:  static class
TOKEN: 0x2000018
FIELDS:
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<T>TryFormatDelegate  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600007F  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000080  System.Boolean TryFormatString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=-1  // not resolved  token=0x6000081  System.Boolean TryFormatUnsafeString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=-1  // not resolved  token=0x6000082  System.Boolean TryFormatDefault(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
  public    static readonly Cysharp.Text.Utf16ValueStringBuilder.<>c<>9  // static @ 0x0
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Boolean><>9__52_0  // static @ 0x8
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.SByte><>9__52_1  // static @ 0x10
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int16><>9__52_2  // static @ 0x18
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int32><>9__52_3  // static @ 0x20
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Int64><>9__52_4  // static @ 0x28
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Byte><>9__52_5  // static @ 0x30
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt16><>9__52_6  // static @ 0x38
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt32><>9__52_7  // static @ 0x40
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UInt64><>9__52_8  // static @ 0x48
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Single><>9__52_9  // static @ 0x50
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Double><>9__52_10  // static @ 0x58
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.TimeSpan><>9__52_11  // static @ 0x60
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.DateTime><>9__52_12  // static @ 0x68
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.DateTimeOffset><>9__52_13  // static @ 0x70
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Decimal><>9__52_14  // static @ 0x78
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Guid><>9__52_15  // static @ 0x80
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.IntPtr><>9__52_16  // static @ 0x88
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.UIntPtr><>9__52_17  // static @ 0x90
METHODS:
  RVA=0x03D0DAF0  token=0x6000083  System.Void .cctor()
  RVA=0x0350B670  token=0x6000084  System.Void .ctor()
  RVA=0x031937F0  token=0x6000085  System.Boolean <CreateFormatter>b__52_0(System.Boolean x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF6B4  token=0x6000086  System.Boolean <CreateFormatter>b__52_1(System.SByte x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF760  token=0x6000087  System.Boolean <CreateFormatter>b__52_2(System.Int16 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x02D74AF0  token=0x6000088  System.Boolean <CreateFormatter>b__52_3(System.Int32 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x02D74A70  token=0x6000089  System.Boolean <CreateFormatter>b__52_4(System.Int64 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF80C  token=0x600008A  System.Boolean <CreateFormatter>b__52_5(System.Byte x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF8B8  token=0x600008B  System.Boolean <CreateFormatter>b__52_6(System.UInt16 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x02E57E70  token=0x600008C  System.Boolean <CreateFormatter>b__52_7(System.UInt32 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x02E57DF0  token=0x600008D  System.Boolean <CreateFormatter>b__52_8(System.UInt64 x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x038ECCA0  token=0x600008E  System.Boolean <CreateFormatter>b__52_9(System.Single x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x022FB710  token=0x600008F  System.Boolean <CreateFormatter>b__52_10(System.Double x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF3E4  token=0x6000090  System.Boolean <CreateFormatter>b__52_11(System.TimeSpan x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0267D730  token=0x6000091  System.Boolean <CreateFormatter>b__52_12(System.DateTime x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF46C  token=0x6000092  System.Boolean <CreateFormatter>b__52_13(System.DateTimeOffset x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF4F8  token=0x6000093  System.Boolean <CreateFormatter>b__52_14(System.Decimal x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF584  token=0x6000094  System.Boolean <CreateFormatter>b__52_15(System.Guid x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF5C8  token=0x6000095  System.Boolean <CreateFormatter>b__52_16(System.IntPtr x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  RVA=0x0A2BF614  token=0x6000096  System.Boolean <CreateFormatter>b__52_17(System.UIntPtr x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: <>c__170`1
TYPE:  sealed class
TOKEN: 0x200001A
FIELDS:
  public    static readonly Cysharp.Text.Utf16ValueStringBuilder.<>c__170<T><>9  // static @ 0x0
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>><>9__170_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000097  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000098  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000099  System.Boolean <CreateNullableFormatter>b__170_0(System.Nullable<T> x, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x30
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x110
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2561861BF4EAE96D61721D493270BADE6B1F1FFEB0A6BCA271EE90DC9B33E918625  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=323BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076  // static @ 0x100
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652  // static @ 0x120
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256E14330899333C68046C96292E14EF1B988B41F2809D50D9C2D5A83F2E83BF2AA  // static @ 0x140
METHODS:
END_CLASS

CLASS: Beyond.MonoObject_64
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x20
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.MonoObject_32
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x20
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.MonoString_64
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x28
FIELDS:
  public            Beyond.MonoObject_64            obj  // 0x10
  public            System.Int32                    length  // 0x20
  public            System.Char                     firstChar  // 0x24
METHODS:
END_CLASS

CLASS: Beyond.MonoString_32
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x20
FIELDS:
  public            Beyond.MonoObject_32            obj  // 0x10
  public            System.Int32                    length  // 0x18
  public            System.Char                     firstChar  // 0x1c
METHODS:
END_CLASS

CLASS: Beyond.UnSafeString
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x30
FIELDS:
  private   static  System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock>s_blocks  // static @ 0x0
  private   static  System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock>s_stackBlocks  // static @ 0x8
  private   static  Beyond.UnSafeString.HgStringBlocks_currentBlock  // static @ 0x10
  private   static  System.Threading.ThreadLocal<System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock>>s_threadBlockPool  // static @ 0x18
  private   static  System.Threading.ThreadLocal<System.Collections.Generic.Stack<Beyond.UnSafeString.HgThreadStringBlock>>s_threadStackBlocks  // static @ 0x20
  private   static  System.Threading.ThreadLocal<Beyond.UnSafeString.HgThreadStringBlock>s_threadCurrentBlock  // static @ 0x28
  private   static  System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString>s_threadSharedStringPool  // static @ 0x30
  private   static readonly System.Char[]                   UP_TABLE  // static @ 0x38
  private   static readonly System.Char[]                   LOW_TABLE  // static @ 0x40
  private           System.String                   m_buffer  // 0x10
  private           System.UInt64                   m_handler  // 0x18
  private           System.Int32*                   m_strCount  // 0x20
  private           System.Int32                    m_length  // 0x28
  private           System.Boolean                  m_resizeFlag  // 0x2c
  public    static  Beyond.UnSafeString             Empty  // static @ 0x48
  public    static  System.Int32                    s_mainThread  // static @ 0x50
  private   static  System.Collections.Generic.Queue<Beyond.UnSafeString>[]s_freeListPool  // static @ 0x58
  private   static  System.Collections.Generic.Queue<Beyond.UnSafeString>[]s_secondFreeListPool  // static @ 0x60
  private   static  System.Collections.Generic.Dictionary<Unity.Mathematics.uint2,System.String>s_sharedStringPool  // static @ 0x68
PROPERTIES:
  Length  get=0x03D8A240  set=0x03D8A250
METHODS:
  RVA=0x023A8410  token=0x6000005  System.Void Append(System.Char value)
  RVA=0x023A67B0  token=0x6000006  System.Void Append(System.Char* value, System.Int32 count)
  RVA=0x02CB51F0  token=0x6000007  System.Void Append(System.Int32 value)
  RVA=0x023A8F70  token=0x6000008  System.Void Append(System.String value)
  RVA=0x0267F210  token=0x6000009  System.Void Append(System.Span<System.Char> value)
  RVA=0x026F1E30  token=0x600000A  System.Void Replace(System.Char newChar, System.Int32 Index)
  RVA=0x028DA400  token=0x600000B  System.Void Append(Beyond.UnSafeString value)
  RVA=0x0A2BFB44  token=0x600000C  System.Void Append(System.Byte* value, System.Int32 count)
  RVA=0x0A2C00D0  token=0x600000D  System.Int32 _GetUTF8ByteCnt(System.Byte bt)
  RVA=0x023A68D0  token=0x600000E  System.IDisposable Scope()
  RVA=-1  // generic def  token=0x600000F  Beyond.UnSafeString Concat(T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x6000010  Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x6000011  Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=0x03802010  token=0x6000014  System.Void .cctor()
  RVA=0x026808F0  token=0x6000015  System.Void .ctor(System.Int32 count)
  RVA=0x023AB380  token=0x6000016  Beyond.UnSafeString Create(System.Int32 count)
  RVA=0x02680870  token=0x6000017  Beyond.UnSafeString CreateRaw(System.Int32 count)
  RVA=0x030CE230  token=0x6000018  System.Void Dispose()
  RVA=0x023AA3F0  token=0x6000019  System.Int32 GetStringBufferSize()
  RVA=0x023AB2E0  token=0x600001A  System.Void Clear()
  RVA=0x0268C6B0  token=0x600001B  System.String CloneString()
  RVA=0x0A2BFDAC  token=0x600001C  System.Void CloneToBytes(System.Span<System.Byte> bytes)
  RVA=0x023A9D90  token=0x600001D  System.String ToString()
  RVA=0x0A2C0168  token=0x600001E  System.Void _Resize(System.Int32 size)
  RVA=0x0A2BFEDC  token=0x600001F  System.Int32 GetHashCode()
  RVA=0x028DBFB0  token=0x6000020  System.Void ToLow()
  RVA=0x0A2C0054  token=0x6000021  Beyond.UnSafeString GetUnsafeString(System.Char* ptr, System.Int32 length)
  RVA=0x0A2BFF84  token=0x6000022  Beyond.UnSafeString GetUnsafeStringUTF8(System.Span<System.Byte> span)
  RVA=-1  // generic def  token=0x6000023  Beyond.UnSafeString Format(System.String formatString, T arg)
  RVA=-1  // generic def  token=0x6000024  Beyond.UnSafeString Format(System.String formatString, T1 arg, T2 arg1)
  RVA=-1  // generic def  token=0x6000025  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x6000026  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x6000027  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  RVA=0x024BCCB0  token=0x6000028  System.String op_Implicit(Beyond.UnSafeString value)
  RVA=0x0A2C0250  token=0x6000029  Beyond.UnSafeString op_Implicit(System.String value)
  RVA=0x023AA470  token=0x600002A  Beyond.UnSafeString TryGetUnSafeStringFromPool(System.Int32 requestStringLength, System.Boolean inScope)
  RVA=0x023A9E10  token=0x600002B  System.Void _RecycleString(Beyond.UnSafeString uString)
  RVA=0x030CDFB0  token=0x600002C  System.Void FreeCacheMemory()
  RVA=0x02815240  token=0x600002D  System.Void Split(System.Char separator, System.Collections.Generic.List<Beyond.UnSafeString>& list)
END_CLASS

CLASS: Cysharp.Text.EnumUtil`1
TYPE:  static class
TOKEN: 0x200000F
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<T,System.String>names  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<T,System.Byte[]>utf8names  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000040  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000041  System.Boolean TryFormatUtf16(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> _)
END_CLASS

CLASS: Cysharp.Text.ExceptionUtil
TYPE:  static class
TOKEN: 0x2000010
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0A2BE06C  token=0x6000042  System.Void ThrowFormatException()
  RVA=0x0A2BE010  token=0x6000043  System.Void ThrowFormatError()
END_CLASS

CLASS: Cysharp.Text.FastNumberWriter
TYPE:  static class
TOKEN: 0x2000011
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02D74B70  token=0x6000044  System.Boolean TryWriteInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.Int64 value)
  RVA=0x02E57EF0  token=0x6000045  System.Boolean TryWriteUInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.UInt64 value)
END_CLASS

CLASS: Cysharp.Text.FormatParser
TYPE:  static class
TOKEN: 0x2000012
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0A2BE0C8  token=0x6000046  System.Boolean IsDigit(System.Char c)
  RVA=0x0A2BE0E0  token=0x6000047  Cysharp.Text.FormatParser.ParseResult Parse(System.String format, System.Int32 i)
END_CLASS

CLASS: Cysharp.Text.NestedStringBuilderCreationException
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x90
EXTENDS: System.InvalidOperationException
FIELDS:
METHODS:
  RVA=0x0A2BF2F8  token=0x6000049  System.Void .ctor(System.String typeName, System.String extraMessage)
END_CLASS

CLASS: Cysharp.Text.ReadOnlyListAdaptor`1
TYPE:  sealed struct
TOKEN: 0x2000015
IMPLEMENTS: System.Collections.Generic.IReadOnlyList`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  private   readonly System.Collections.Generic.IList<T>_list  // 0x0
PROPERTIES:
  Item  get=-1  // not resolved
  Count  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600004A  System.Void .ctor(System.Collections.Generic.IList<T> list)
  RVA=-1  // not resolved  token=0x600004D  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x600004E  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Cysharp.Text.Utf16ValueStringBuilder
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x20
IMPLEMENTS: System.IDisposable System.Buffers.IBufferWriter`1
FIELDS:
  private   static  System.Char                     newLine1  // static @ 0x0
  private   static  System.Char                     newLine2  // static @ 0x2
  private   static  System.Boolean                  crlf  // static @ 0x4
  private   static  System.Char[]                   scratchBuffer  // static @ 0xffffffff
  private   static  System.Boolean                  scratchBufferUsed  // static @ 0xffffffff
  private           System.Char[]                   buffer  // 0x10
  private           System.Int32                    index  // 0x18
  private           System.Boolean                  disposeImmediately  // 0x1c
PROPERTIES:
  Length  get=0x03D516F0
METHODS:
  RVA=-1  // generic def  token=0x600004F  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values)
  RVA=-1  // generic def  token=0x6000050  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values)
  RVA=-1  // generic def  token=0x6000051  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // generic def  token=0x6000052  System.Void AppendFormat(System.String format, T1 arg1)
  RVA=-1  // generic def  token=0x6000053  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x6000054  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x6000055  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x6000056  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  RVA=-1  // generic def  token=0x6000057  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  RVA=-1  // generic def  token=0x6000058  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  RVA=-1  // generic def  token=0x6000059  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  RVA=-1  // generic def  token=0x600005A  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  RVA=-1  // generic def  token=0x600005B  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  RVA=-1  // generic def  token=0x600005C  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  RVA=-1  // generic def  token=0x600005D  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  RVA=-1  // generic def  token=0x600005E  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  RVA=-1  // generic def  token=0x600005F  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  RVA=-1  // generic def  token=0x6000060  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  RVA=-1  // generic def  token=0x6000061  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
  RVA=0x0332A040  token=0x6000062  System.Object CreateFormatter(System.Type type)
  RVA=0x0A2C0598  token=0x6000063  System.Void Append(System.Int32 value)
  RVA=0x031EDB90  token=0x6000064  System.Void .cctor()
  RVA=0x0A2C09DC  token=0x6000066  System.ReadOnlySpan<System.Char> AsSpan()
  RVA=0x0A2C097C  token=0x6000067  System.ArraySegment<System.Char> AsArraySegment()
  RVA=0x0A2C0EB4  token=0x6000068  System.Void .ctor(System.Boolean disposeImmediately)
  RVA=0x0A2C0A6C  token=0x6000069  System.Void Dispose()
  RVA=0x0A2C0C6C  token=0x600006A  System.Void Grow(System.Int32 sizeHint)
  RVA=0x0A2C034C  token=0x600006B  System.Void AppendLine()
  RVA=0x0A2C078C  token=0x600006C  System.Void Append(System.Char value)
  RVA=0x0A2C04B0  token=0x600006D  System.Void Append(System.Char value, System.Int32 repeatCount)
  RVA=0x0A2C081C  token=0x600006E  System.Void Append(System.String value)
  RVA=0x0A2C02F4  token=0x600006F  System.Void AppendLine(System.String value)
  RVA=0x0A2C088C  token=0x6000070  System.Void Append(System.String value, System.Int32 startIndex, System.Int32 count)
  RVA=0x0A2C06C4  token=0x6000071  System.Void Append(System.ReadOnlySpan<System.Char> value)
  RVA=-1  // generic def  token=0x6000072  System.Void Append(T value)
  RVA=0x023AE130  token=0x6000073  System.String ToString()
  RVA=0x0A2C0B28  token=0x6000074  System.Memory<System.Char> GetMemory(System.Int32 sizeHint)
  RVA=0x0A2C0BD0  token=0x6000075  System.Span<System.Char> GetSpan(System.Int32 sizeHint)
  RVA=0x03D6E610  token=0x6000076  System.Void Advance(System.Int32 count)
  RVA=0x0A2C0D84  token=0x6000077  System.Void ThrowArgumentException(System.String paramName)
  RVA=0x0A2C0DE8  token=0x6000078  System.Void ThrowFormatException()
  RVA=-1  // generic def  token=0x6000079  System.Void AppendFormatInternal(T arg, System.Int32 width, System.ReadOnlySpan<System.Char> format, System.String argName)
  RVA=0x0A2C0E44  token=0x600007A  System.Void ThrowNestedException()
  RVA=-1  // generic def  token=0x600007B  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>> CreateNullableFormatter()
  RVA=0x023ABD30  token=0x600007C  System.Char& GetPinnableReference()
END_CLASS

CLASS: Cysharp.Text.ZString
TYPE:  static class
TOKEN: 0x200001B
SIZE:  0x10
FIELDS:
  private   static  System.Text.Encoding            UTF8NoBom  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x600009A  System.String Concat(T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x600009B  System.String Concat(T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x600009C  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x600009D  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  RVA=-1  // generic def  token=0x600009E  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  RVA=-1  // generic def  token=0x600009F  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  RVA=-1  // generic def  token=0x60000A0  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  RVA=-1  // generic def  token=0x60000A1  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  RVA=-1  // generic def  token=0x60000A2  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  RVA=-1  // generic def  token=0x60000A3  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  RVA=-1  // generic def  token=0x60000A4  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  RVA=-1  // generic def  token=0x60000A5  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  RVA=-1  // generic def  token=0x60000A6  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  RVA=-1  // generic def  token=0x60000A7  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  RVA=-1  // generic def  token=0x60000A8  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
  RVA=0x0284E090  token=0x60000A9  Cysharp.Text.Utf16ValueStringBuilder CreateStringBuilder()
  RVA=-1  // generic def  token=0x60000AA  System.String Join(System.Char separator, T[] values)
  RVA=-1  // generic def  token=0x60000AB  System.String Join(System.Char separator, System.Collections.Generic.List<T> values)
  RVA=-1  // generic def  token=0x60000AC  System.String Join(System.Char separator, System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // generic def  token=0x60000AD  System.String Join(System.Char separator, System.Collections.Generic.ICollection<T> values)
  RVA=-1  // generic def  token=0x60000AE  System.String Join(System.Char separator, System.Collections.Generic.IList<T> values)
  RVA=-1  // generic def  token=0x60000AF  System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values)
  RVA=-1  // generic def  token=0x60000B0  System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  RVA=-1  // generic def  token=0x60000B1  System.String Join(System.String separator, System.Collections.Generic.List<T> values)
  RVA=-1  // generic def  token=0x60000B2  System.String Join(System.String separator, System.Collections.Generic.ICollection<T> values)
  RVA=-1  // generic def  token=0x60000B3  System.String Join(System.String separator, System.Collections.Generic.IList<T> values)
  RVA=-1  // generic def  token=0x60000B4  System.String Join(System.String separator, System.Collections.Generic.IReadOnlyList<T> values)
  RVA=-1  // generic def  token=0x60000B5  System.String Join(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  RVA=-1  // generic def  token=0x60000B6  System.String Join(System.String separator, System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // generic def  token=0x60000B7  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IList<T> values)
  RVA=-1  // generic def  token=0x60000B8  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values)
  RVA=-1  // generic def  token=0x60000B9  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values)
  RVA=-1  // generic def  token=0x60000BA  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values)
  RVA=-1  // generic def  token=0x60000BB  System.String Format(System.String format, T1 arg1)
  RVA=-1  // generic def  token=0x60000BC  System.String Format(System.String format, T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x60000BD  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x60000BE  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x60000BF  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  RVA=-1  // generic def  token=0x60000C0  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  RVA=0x03A28DB0  token=0x60000C1  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x0A2BE548  token=0x60000C2  System.Void __Gen_Wrap_0(System.Object P0, System.Char P1)
  RVA=0x0549D548  token=0x60000C3  System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  RVA=0x05163BA0  token=0x60000C4  System.Void __Gen_Wrap_3(System.Object P0, System.Object P1)
  RVA=0x0A2BF014  token=0x60000C5  System.Void __Gen_Wrap_5(System.Object P0, System.Span<System.Char> P1)
  RVA=0x0A2BF128  token=0x60000C6  System.Void __Gen_Wrap_6(System.Object P0, System.Char P1, System.Int32 P2)
  RVA=0x0A2BF220  token=0x60000C7  System.Int32 __Gen_Wrap_8(System.Object P0, System.Byte P1)
  RVA=0x04274234  token=0x60000C8  System.Void __Gen_Wrap_9(System.Object P0)
  RVA=0x050F3444  token=0x60000C9  System.Void __Gen_Wrap_10()
  RVA=0x0A2BE624  token=0x60000CA  System.IDisposable __Gen_Wrap_11()
  RVA=0x0A2BE6F0  token=0x60000CB  Beyond.UnSafeString __Gen_Wrap_12(System.Int32 P0, System.Boolean P1)
  RVA=0x0A2BE7FC  token=0x60000CC  Beyond.UnSafeString __Gen_Wrap_13(System.Int32 P0)
  RVA=0x050EF614  token=0x60000CD  System.Int32 __Gen_Wrap_14(System.Object P0)
  RVA=0x0A2BE8E8  token=0x60000CE  System.String __Gen_Wrap_15(System.Object P0)
  RVA=0x0A2BE9D8  token=0x60000CF  System.Void __Gen_Wrap_16(System.Object P0, System.Span<System.Byte> P1)
  RVA=0x0A2BEAD8  token=0x60000D0  Beyond.UnSafeString __Gen_Wrap_23(System.Span<System.Byte> P0)
  RVA=0x0A2BEBD8  token=0x60000D1  Beyond.UnSafeString __Gen_Wrap_24(System.Object P0)
  RVA=0x0A2BECC8  token=0x60000D2  System.Void __Gen_Wrap_31(System.Object P0, System.Char P1, System.Collections.Generic.List<Beyond.UnSafeString>& P2)
  RVA=0x0A2BEE0C  token=0x60000D3  Beyond.UnSafeString.UnSafeStringHandle __Gen_Wrap_32(System.Int32 P0)
  RVA=0x0A2BEEF8  token=0x60000D4  System.Void __Gen_Wrap_33(Beyond.UnSafeString.UnSafeStringHandle& P0)
  RVA=0x03D05B80  token=0x60000D5  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0A2C1038  token=0x60000D6  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x023A8500  token=0x60000D7  System.Boolean IsPatched(System.Int32 id)
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

CLASS: System.Numerics.BitOperations
TYPE:  static class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
PROPERTIES:
  TrailingZeroCountDeBruijn  get=0x023DE440
  Log2DeBruijn  get=0x0A2BDFB4
METHODS:
  RVA=0x0473A550  token=0x600003C  System.Int32 LeadingZeroCount(System.UInt32 value)
  RVA=0x0A2BDEA4  token=0x600003D  System.Int32 Log2SoftwareFallback(System.UInt32 value)
  RVA=0x0A2BDF24  token=0x600003E  System.Int32 TrailingZeroCount(System.UInt32 value)
  RVA=0x0A2BDF94  token=0x600003F  System.Int32 TrailingZeroCount(System.UInt64 value)
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Byte[]                   NullableFlags  // 0x10
METHODS:
  RVA=0x0A2BF374  token=0x6000002  System.Void .ctor(System.Byte )
  RVA=0x0426FEE0  token=0x6000003  System.Void .ctor(System.Byte[] )
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableContextAttribute
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Byte                     Flag  // 0x10
METHODS:
  RVA=0x03D4E960  token=0x6000004  System.Void .ctor(System.Byte )
END_CLASS

