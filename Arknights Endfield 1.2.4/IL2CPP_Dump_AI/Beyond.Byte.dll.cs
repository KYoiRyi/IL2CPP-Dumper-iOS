// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Byte.dll
// Classes:  8
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

CLASS: Beyond.Byte.UInt128
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x20
IMPLEMENTS: System.IComparable`1 System.IEquatable`1
FIELDS:
  public            System.UInt64                   high  // 0x10
  public            System.UInt64                   low  // 0x18
METHODS:
  RVA=0x05159ED4  token=0x6000001  System.Boolean Equals(System.Object obj)
  RVA=0x05159F78  token=0x6000002  System.Int32 GetHashCode()
  RVA=0x03D4EA10  token=0x6000003  System.Void .ctor(System.UInt64 high, System.UInt64 low)
  RVA=0x0515A1C4  token=0x6000004  System.Void .ctor(System.Byte[] bytes)
  RVA=0x0515A280  token=0x6000005  Beyond.Byte.UInt128 op_Implicit(System.Byte[] bytes)
  RVA=0x0515A014  token=0x6000006  System.Guid ToGuid()
  RVA=0x05159DE0  token=0x6000007  System.Int32 CompareTo(Beyond.Byte.UInt128 other)
  RVA=0x05159E60  token=0x6000008  System.Boolean Equals(Beyond.Byte.UInt128 other)
  RVA=0x0515A200  token=0x6000009  System.Boolean op_Equality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 b)
  RVA=0x0515A2F4  token=0x600000A  System.Boolean op_Inequality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 B)
  RVA=0x0515A114  token=0x600000B  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  RVA=0x0515A174  token=0x600000C  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Byte.ByteBufStream
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x20
FIELDS:
  public            System.Int32                    currentIdx  // 0x10
  public            System.Byte[]                   datas  // 0x18
METHODS:
  RVA=0x02431680  token=0x600000D  System.Int32 GetCurrentIdx()
  RVA=0x05154E1C  token=0x600000E  System.Byte[] GetRaw()
  RVA=0x05154D8C  token=0x600000F  System.Byte[] GetDataCopy()
  RVA=0x05154E68  token=0x6000010  System.UInt32 ReadUInt()
  RVA=0x0242F7E0  token=0x6000011  System.Int32 ReadInt()
  RVA=0x0242FDA0  token=0x6000012  System.Int32 ReadByte()
  RVA=0x05154EC4  token=0x6000013  System.UInt64 ReadULong()
  RVA=0x02431160  token=0x6000014  System.Int64 ReadLong()
  RVA=0x0242FF90  token=0x6000015  Beyond.Byte.UInt128 ReadUInt128()
  RVA=0x0242EE30  token=0x6000016  System.String ReadUTF8()
  RVA=0x02431700  token=0x6000017  System.Void SkipReadUTF8()
  RVA=0x05154F8C  token=0x6000018  System.Void WriteByte(System.Byte val)
  RVA=0x05155134  token=0x6000019  System.Void WriteUInt(System.UInt32 val)
  RVA=0x05154FF0  token=0x600001A  System.Void WriteInt(System.Int32 val)
  RVA=0x051551A0  token=0x600001B  System.Void WriteULong(System.UInt64 val)
  RVA=0x05155050  token=0x600001C  System.Void WriteLong(System.Int64 val)
  RVA=0x051550B0  token=0x600001D  System.Void WriteUInt128(Beyond.Byte.UInt128 val)
  RVA=0x0515520C  token=0x600001E  System.Void WriteUTF8(System.String val)
  RVA=0x05154F20  token=0x600001F  System.Void SkipBytes(System.Int32 offset)
  RVA=0x0242DDA0  token=0x6000020  System.Int32 RemainBytes()
  RVA=0x0242EDC0  token=0x6000021  Beyond.Byte.ByteBufStream CreateFromByte(System.Byte[] bs, System.Int32 startIdx)
  RVA=0x05154CE4  token=0x6000022  Beyond.Byte.ByteBufStream Create(System.Int32 cap)
END_CLASS

CLASS: Beyond.Byte.ByteHelper
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02431340  token=0x6000023  Beyond.Byte.UInt128 ReadUInt128(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x02431290  token=0x6000024  System.Int64 ReadLong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x02431430  token=0x6000025  System.UInt64 ReadULong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242FBA0  token=0x6000026  System.UInt32 ReadUInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242FA00  token=0x6000027  System.Int32 ReadInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242FCC0  token=0x6000028  System.UInt16 ReadUShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242F670  token=0x6000029  System.Int16 ReadShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242FEE0  token=0x600002A  System.Byte ReadByte(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x05155674  token=0x600002B  System.Single ReadFloat(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  RVA=0x0242EE80  token=0x600002C  System.String ReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len)
  RVA=0x0242F240  token=0x600002D  System.Void SkipReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len)
  RVA=0x051557C8  token=0x600002E  System.Byte[] WriteByte(System.Byte[] data, System.Int32 writerIndex, System.Byte value)
  RVA=0x024D2330  token=0x600002F  System.Byte[] WriteUShort(System.Byte[] data, System.Int32 writerIndex, System.UInt16 value, System.Boolean bIsLittle)
  RVA=0x0515595C  token=0x6000030  System.Byte[] WriteShort(System.Byte[] data, System.Int32 writerIndex, System.Int16 value, System.Boolean bIsLittle)
  RVA=0x024D23C0  token=0x6000031  System.Byte[] WriteUInt(System.Byte[] data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle)
  RVA=0x023A90D0  token=0x6000032  System.Span<System.Byte> WriteUInt(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle)
  RVA=0x024D22C0  token=0x6000033  System.Byte[] WriteInt(System.Byte[] data, System.Int32 writerIndex, System.Int32 value, System.Boolean bIsLittle)
  RVA=0x05155AA0  token=0x6000034  System.Byte[] WriteULong(System.Byte[] data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle)
  RVA=0x023A86A0  token=0x6000035  System.Span<System.Byte> WriteULong(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle)
  RVA=0x051558D0  token=0x6000036  System.Byte[] WriteLong(System.Byte[] data, System.Int32 writerIndex, System.Int64 value, System.Boolean bIsLittle)
  RVA=0x051559EC  token=0x6000037  System.Byte[] WriteUInt128(System.Byte[] data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle)
  RVA=0x024BEF20  token=0x6000038  System.Span<System.Byte> WriteUInt128(System.Span<System.Byte> data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle)
  RVA=0x05155844  token=0x6000039  System.Byte[] WriteFloat(System.Byte[] data, System.Int32 writerIndex, System.Single value)
  RVA=0x05155C98  token=0x600003A  System.Byte[] WriteUTF8(System.Byte[] data, System.Int32 writerIndex, System.String value, System.Int32& len)
  RVA=0x05155758  token=0x600003B  System.Void SplitLong(System.Int64 longValue, System.Int32& highInt, System.Int32& lowInt)
  RVA=0x05155618  token=0x600003C  System.Int64 MergeLong(System.Int32 highInt, System.Int32 lowInt)
  RVA=0x05155704  token=0x600003D  System.Int32 SingleToInt32Bits(System.Single value)
  RVA=0x051555D0  token=0x600003E  System.Single Int32BitsToSingle(System.Int32 value)
  RVA=0x05155404  token=0x600003F  System.String GetHexString(System.Byte[] byteArray)
  RVA=0x05155460  token=0x6000040  System.String GetHexString(System.Byte[] byteArray, System.Int32 startIdx, System.Int32 length)
  RVA=0x024C0770  token=0x6000041  System.String GetHexString(System.Span<System.Byte> byteArray)
  RVA=0x023A78E0  token=0x6000042  System.String GetHexString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  RVA=0x024BF050  token=0x6000043  System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray)
  RVA=0x023A80F0  token=0x6000044  System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  RVA=0x02E9CC10  token=0x6000045  System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray)
  RVA=0x02E9CDE0  token=0x6000046  System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  RVA=0x05155284  token=0x6000047  Beyond.Byte.UInt128 ComputeMD5Bytes(System.Byte[] bs, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000048  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x05155D80  token=0x6000049  System.Boolean __Gen_Wrap_0(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1)
  RVA=0x05156764  token=0x600004A  System.Boolean __Gen_Wrap_1(Beyond.Byte.UInt128& P0, System.Object P1)
  RVA=0x051573CC  token=0x600004B  System.Int32 __Gen_Wrap_2(Beyond.Byte.UInt128& P0)
  RVA=0x05158184  token=0x600004C  Beyond.Byte.UInt128 __Gen_Wrap_3(System.Object P0)
  RVA=0x05158D00  token=0x600004D  System.Guid __Gen_Wrap_4(Beyond.Byte.UInt128& P0)
  RVA=0x05159824  token=0x600004E  System.Int32 __Gen_Wrap_5(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1)
  RVA=0x0515998C  token=0x600004F  System.Boolean __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1)
  RVA=0x05159AB4  token=0x6000050  System.Int32 __Gen_Wrap_7(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05159C00  token=0x6000051  System.Byte[] __Gen_Wrap_8(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156024  token=0x6000052  System.UInt32 __Gen_Wrap_9(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05155EE8  token=0x6000053  System.UInt32 __Gen_Wrap_10(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156024  token=0x6000054  System.Int32 __Gen_Wrap_11(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05156024  token=0x6000055  System.Byte __Gen_Wrap_12(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05156128  token=0x6000056  System.UInt64 __Gen_Wrap_13(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x0515622C  token=0x6000057  System.UInt64 __Gen_Wrap_14(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156128  token=0x6000058  System.Int64 __Gen_Wrap_15(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05156368  token=0x6000059  System.Int64 __Gen_Wrap_16(Beyond.Byte.ByteBufStream& P0)
  RVA=0x051564B4  token=0x600005A  Beyond.Byte.UInt128 __Gen_Wrap_17(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x051565EC  token=0x600005B  Beyond.Byte.UInt128 __Gen_Wrap_18(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156024  token=0x600005C  System.UInt16 __Gen_Wrap_19(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05156024  token=0x600005D  System.Int16 __Gen_Wrap_20(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x051568B4  token=0x600005E  System.String __Gen_Wrap_21(System.Object P0, System.Int32 P1, System.Int16& P2)
  RVA=0x05156A00  token=0x600005F  System.String __Gen_Wrap_22(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156B60  token=0x6000060  System.Void __Gen_Wrap_23(System.Object P0, System.Int32 P1, System.Int16& P2)
  RVA=0x05156C78  token=0x6000061  System.Void __Gen_Wrap_24(Beyond.Byte.ByteBufStream& P0)
  RVA=0x05156DB4  token=0x6000062  System.Byte[] __Gen_Wrap_25(System.Object P0, System.Int32 P1, System.Byte P2)
  RVA=0x05156EC8  token=0x6000063  System.Void __Gen_Wrap_26(Beyond.Byte.ByteBufStream& P0, System.Byte P1)
  RVA=0x05157010  token=0x6000064  System.Byte[] __Gen_Wrap_27(System.Object P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3)
  RVA=0x05157144  token=0x6000065  System.Void __Gen_Wrap_28(Beyond.Byte.ByteBufStream& P0, System.UInt32 P1)
  RVA=0x05157288  token=0x6000066  System.Void __Gen_Wrap_29(Beyond.Byte.ByteBufStream& P0, System.Int32 P1)
  RVA=0x05157500  token=0x6000067  System.Byte[] __Gen_Wrap_30(System.Object P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3)
  RVA=0x05157628  token=0x6000068  System.Void __Gen_Wrap_31(Beyond.Byte.ByteBufStream& P0, System.UInt64 P1)
  RVA=0x05157770  token=0x6000069  System.Void __Gen_Wrap_32(Beyond.Byte.ByteBufStream& P0, System.Int64 P1)
  RVA=0x051578B8  token=0x600006A  System.Byte[] __Gen_Wrap_33(System.Object P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3)
  RVA=0x05157A00  token=0x600006B  System.Void __Gen_Wrap_34(Beyond.Byte.ByteBufStream& P0, Beyond.Byte.UInt128 P1)
  RVA=0x05157B6C  token=0x600006C  System.Byte[] __Gen_Wrap_35(System.Object P0, System.Int32 P1, System.UInt16 P2, System.Boolean P3)
  RVA=0x05157CA0  token=0x600006D  System.Byte[] __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.Int16 P2, System.Boolean P3)
  RVA=0x05157DC8  token=0x600006E  System.Byte[] __Gen_Wrap_37(System.Object P0, System.Int32 P1, System.Object P2, System.Int32& P3)
  RVA=0x05157F14  token=0x600006F  System.Void __Gen_Wrap_38(Beyond.Byte.ByteBufStream& P0, System.Object P1)
  RVA=0x0515805C  token=0x6000070  Beyond.Byte.ByteBufStream __Gen_Wrap_39(System.Object P0, System.Int32 P1)
  RVA=0x0515827C  token=0x6000071  Beyond.Byte.ByteBufStream __Gen_Wrap_40(System.Int32 P0)
  RVA=0x050F29AC  token=0x6000072  System.Single __Gen_Wrap_41(System.Int32 P0)
  RVA=0x05158374  token=0x6000073  System.Single __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x05158468  token=0x6000074  System.Span<System.Byte> __Gen_Wrap_43(System.Span<System.Byte> P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3)
  RVA=0x051585D4  token=0x6000075  System.Byte[] __Gen_Wrap_44(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3)
  RVA=0x05158708  token=0x6000076  System.Span<System.Byte> __Gen_Wrap_45(System.Span<System.Byte> P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3)
  RVA=0x05158874  token=0x6000077  System.Byte[] __Gen_Wrap_46(System.Object P0, System.Int32 P1, System.Int64 P2, System.Boolean P3)
  RVA=0x0515899C  token=0x6000078  System.Span<System.Byte> __Gen_Wrap_47(System.Span<System.Byte> P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3)
  RVA=0x05158B30  token=0x6000079  System.Int32 __Gen_Wrap_48(System.Single P0)
  RVA=0x05158BEC  token=0x600007A  System.Byte[] __Gen_Wrap_49(System.Object P0, System.Int32 P1, System.Single P2)
  RVA=0x05158E60  token=0x600007B  System.Void __Gen_Wrap_50(System.Int64 P0, System.Int32& P1, System.Int32& P2)
  RVA=0x05158F88  token=0x600007C  System.Int64 __Gen_Wrap_51(System.Int32 P0, System.Int32 P1)
  RVA=0x0515905C  token=0x600007D  System.String __Gen_Wrap_52(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x05159170  token=0x600007E  System.String __Gen_Wrap_53(System.Object P0)
  RVA=0x0515924C  token=0x600007F  System.String __Gen_Wrap_54(System.Span<System.Byte> P0, System.Int32 P1, System.Int32 P2)
  RVA=0x05159398  token=0x6000080  System.String __Gen_Wrap_55(System.Span<System.Byte> P0)
  RVA=0x051594B0  token=0x6000081  System.Void __Gen_Wrap_56(System.Object P0, System.Span<System.Byte> P1, System.Int32 P2, System.Int32 P3)
  RVA=0x051595EC  token=0x6000082  System.Void __Gen_Wrap_57(System.Object P0, System.Span<System.Byte> P1)
  RVA=0x05159700  token=0x6000083  Beyond.Byte.UInt128 __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x03D060C0  token=0x6000084  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x40
EXTENDS: IFix.Core.AnonymousStorey
FIELDS:
METHODS:
  RVA=0x05159D4C  token=0x6000085  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x6000086  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000087  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0515A56C  token=0x6000088  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x024315D0  token=0x6000089  System.Boolean IsPatched(System.Int32 id)
  RVA=0x0515A428  token=0x600008A  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x0515A4F4  token=0x600008B  System.Object CreateWrapper(System.Int32 id)
  RVA=0x0515A5D0  token=0x600008C  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x0515A384  token=0x600008D  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-Equals1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-GetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Implicit0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-ToGuid0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-CompareTo0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Equality0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Inequality0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetCurrentIdx0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetRaw0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetDataCopy0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadByte0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadByte0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadULong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadULong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUInt1280  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUInt1280  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUShort0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadShort0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SkipReadUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-SkipReadUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteByte0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteByte0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteULong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteULong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1280  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUInt1280  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUShort0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteShort0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUTF80  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-SkipBytes0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-RemainBytes0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-CreateFromByte0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-Create0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-Int32BitsToSingle0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteInt0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteULong1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1281  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SingleToInt32Bits0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SplitLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-MergeLong0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString2  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString3  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-AppendHexString0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-AppendHexString1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexStringUnsafeString0  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexStringUnsafeString1  // const
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ComputeMD5Bytes0  // const
METHODS:
END_CLASS

