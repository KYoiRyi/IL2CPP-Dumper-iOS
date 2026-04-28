// ========================================================
// Dumped by @desirepro
// Assembly: Google.FlatBuffers.dll
// Classes:  17
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

CLASS: UnionForShort
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x12
FIELDS:
  public            System.Int16                    shortVal  // 0x10
  public            System.UInt16                   ushortVal  // 0x10
METHODS:
END_CLASS

CLASS: UnionForLong
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x18
FIELDS:
  public            System.Int64                    longVal  // 0x10
  public            System.Single                   floatValLow  // 0x10
  public            System.Single                   floatValHigh  // 0x14
METHODS:
END_CLASS

CLASS: Google.FlatBuffers.ByteData
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x20
FIELDS:
  private           System.Byte*                    _buffer  // 0x10
  private           System.Int32                    _length  // 0x18
PROPERTIES:
  Buffer  get=0x020C61B0
  Length  get=0x03D516F0
  Span  get=0x0853ABBC
  ReadOnlySpan  get=0x023327B0
METHODS:
  RVA=0x022B9B50  token=0x6000005  System.Boolean IsCreated()
  RVA=0x02F46190  token=0x6000006  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer)
  RVA=-1  // generic def  token=0x6000009  System.Span<T> ToSpan(T* ptr, System.Int32 length)
  RVA=-1  // generic def  token=0x600000A  System.ReadOnlySpan<T> ToReadOnlySpan(T* ptr, System.Int32 length)
END_CLASS

CLASS: Google.FlatBuffers.ByteBuffer
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x28
FIELDS:
  private           Google.FlatBuffers.ByteData     _buffer  // 0x10
  private           System.Int32                    _pos  // 0x20
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>genericSizes  // static @ 0x0
PROPERTIES:
  Position  get=0x03D4E340  set=0x010410F0
  Length  get=0x03D516F0
METHODS:
  RVA=0x03D675E0  token=0x600000B  System.Void .ctor(Google.FlatBuffers.ByteData allocator, System.Int32 position)
  RVA=0x02F460A0  token=0x600000C  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer)
  RVA=0x02F46110  token=0x600000D  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, System.Int32 pos)
  RVA=0x022B9B50  token=0x600000E  System.Boolean IsCreated()
  RVA=0x03D58F70  token=0x6000012  System.Void Reset()
  RVA=0x08539B40  token=0x6000013  Google.FlatBuffers.ByteBuffer Duplicate()
  RVA=0x0853A964  token=0x6000014  System.Byte[] ToArray(System.Int32 pos, System.Int32 len)
  RVA=-1  // generic def  token=0x6000015  System.Int32 SizeOf()
  RVA=-1  // generic def  token=0x6000016  System.Boolean IsSupportedType()
  RVA=-1  // generic def  token=0x6000017  System.Int32 ArraySize(T[] x)
  RVA=-1  // generic def  token=0x6000018  System.Int32 ArraySize(System.ArraySegment<T> x)
  RVA=-1  // generic def  token=0x6000019  System.Int32 ArraySize(System.Span<T> x)
  RVA=-1  // generic def  token=0x600001A  System.ReadOnlySpan<T> ToSpanSlice(System.Int32 pos, System.Int32 count)
  RVA=-1  // generic def  token=0x600001B  T[] ToArray(System.Int32 pos, System.Int32 count)
  RVA=-1  // generic def  token=0x600001C  Unity.Collections.NativeArray<T> ToNativeArray(System.Int32 pos, System.Int32 count)
  RVA=0x0853AA2C  token=0x600001D  System.Byte[] ToSizedArray()
  RVA=0x0853A9D4  token=0x600001E  System.Byte[] ToFullArray()
  RVA=0x0853AA88  token=0x600001F  System.Span<System.Byte> ToSpan(System.Int32 pos, System.Int32 len)
  RVA=0x020C61B0  token=0x6000020  System.Byte* GetUnsafePtr()
  RVA=0x0853AB20  token=0x6000021  System.Void WriteLittleEndian(System.Int32 offset, System.Int32 count, System.UInt64 data)
  RVA=0x0853A8A4  token=0x6000022  System.UInt64 ReadLittleEndian(System.Int32 offset, System.Int32 count)
  RVA=0x0350B670  token=0x6000023  System.Void AssertOffsetAndLength(System.Int32 offset, System.Int32 length)
  RVA=0x0853A434  token=0x6000024  System.Void PutSbyte(System.Int32 offset, System.SByte value)
  RVA=0x0853A104  token=0x6000025  System.Void PutByte(System.Int32 offset, System.Byte value)
  RVA=0x0853A17C  token=0x6000026  System.Void PutByte(System.Int32 offset, System.Byte value, System.Int32 count)
  RVA=0x0853A844  token=0x6000027  System.Void Put(System.Int32 offset, System.Byte value)
  RVA=0x0853A50C  token=0x6000028  System.Void PutStringUTF8(System.Int32 offset, System.String value)
  RVA=0x0853A4AC  token=0x6000029  System.Void PutShort(System.Int32 offset, System.Int16 value)
  RVA=0x0853A744  token=0x600002A  System.Void PutUshort(System.Int32 offset, System.UInt16 value)
  RVA=0x0853A374  token=0x600002B  System.Void PutInt(System.Int32 offset, System.Int32 value)
  RVA=0x0853A5F8  token=0x600002C  System.Void PutUint(System.Int32 offset, System.UInt32 value)
  RVA=0x0853A3D4  token=0x600002D  System.Void PutLong(System.Int32 offset, System.Int64 value)
  RVA=0x0853A69C  token=0x600002E  System.Void PutUlong(System.Int32 offset, System.UInt64 value)
  RVA=0x0853A2E8  token=0x600002F  System.Void PutFloat(System.Int32 offset, System.Single value)
  RVA=0x0853A25C  token=0x6000030  System.Void PutDouble(System.Int32 offset, System.Double value)
  RVA=0x08539D4C  token=0x6000031  System.SByte GetSbyte(System.Int32 index)
  RVA=0x0853A098  token=0x6000032  System.Byte Get(System.Int32 index)
  RVA=0x08539E0C  token=0x6000033  System.String GetStringUTF8(System.Int32 startPos, System.Int32 len)
  RVA=0x08539DB8  token=0x6000034  System.Int16 GetShort(System.Int32 offset)
  RVA=0x0853A000  token=0x6000035  System.UInt16 GetUshort(System.Int32 offset)
  RVA=0x08539CA4  token=0x6000036  System.Int32 GetInt(System.Int32 offset)
  RVA=0x08539ED0  token=0x6000037  System.UInt32 GetUint(System.Int32 offset)
  RVA=0x08539CF8  token=0x6000038  System.Int64 GetLong(System.Int32 offset)
  RVA=0x08539F68  token=0x6000039  System.UInt64 GetUlong(System.Int32 offset)
  RVA=0x08539C24  token=0x600003A  System.Single GetFloat(System.Int32 offset)
  RVA=0x08539BA4  token=0x600003B  System.Double GetDouble(System.Int32 offset)
  RVA=-1  // generic def  token=0x600003C  System.Int32 Put(System.Int32 offset, T[] x)
  RVA=-1  // generic def  token=0x600003D  System.Int32 Put(System.Int32 offset, System.ArraySegment<T> x)
  RVA=-1  // generic def  token=0x600003E  System.Int32 Put(System.Int32 offset, System.IntPtr ptr, System.Int32 sizeInBytes)
  RVA=-1  // generic def  token=0x600003F  System.Int32 Put(System.Int32 offset, System.Span<T> x)
  RVA=0x037060D0  token=0x6000040  System.Void .cctor()
END_CLASS

CLASS: Google.FlatBuffers.ByteBufferUtil
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08539A7C  token=0x6000041  System.Int32 GetSizePrefix(Google.FlatBuffers.ByteBuffer bb)
  RVA=0x08539AC8  token=0x6000042  Google.FlatBuffers.ByteBuffer RemoveSizePrefix(Google.FlatBuffers.ByteBuffer bb)
  RVA=0x0350B670  token=0x6000043  System.Void .ctor()
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferBuilder
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x78
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Int32                    _space  // 0x10
  private           Unity.Collections.NativeArray<System.Byte>_data  // 0x18
  private           Google.FlatBuffers.ByteBuffer   _bb  // 0x28
  private           System.Int32                    _minAlign  // 0x40
  private           System.Int32[]                  _vtable  // 0x48
  private           System.Int32                    _vtableSize  // 0x50
  private           System.Int32                    _objectStart  // 0x54
  private           System.Int32[]                  _vtables  // 0x58
  private           System.Int32                    _numVtables  // 0x60
  private           System.Int32                    _vectorNumElems  // 0x64
  private           System.Collections.Generic.Dictionary<System.String,Google.FlatBuffers.StringOffset>_sharedStringMap  // 0x68
  private           System.Boolean                  <ForceDefaults>k__BackingField  // 0x70
PROPERTIES:
  ForceDefaults  get=0x03D4F260  set=0x03D4F290
  Offset  get=0x0853CDDC
  DataBuffer  get=0x03D67F30
METHODS:
  RVA=0x0853CC48  token=0x6000044  System.Void .ctor(System.Int32 initialSize)
  RVA=0x0853BB98  token=0x6000045  System.Void Dispose()
  RVA=0x0853B81C  token=0x6000046  System.Void Clear()
  RVA=0x0853C394  token=0x600004A  System.Void Pad(System.Int32 size)
  RVA=0x0853C12C  token=0x600004B  System.Void GrowBuffer()
  RVA=0x0853C400  token=0x600004C  System.Void Prep(System.Int32 size, System.Int32 additionalBytes)
  RVA=0x0853C4AC  token=0x600004D  System.Void PutBool(System.Boolean x)
  RVA=0x0853C71C  token=0x600004E  System.Void PutSbyte(System.SByte x)
  RVA=0x0853C514  token=0x600004F  System.Void PutByte(System.Byte x)
  RVA=0x0853C784  token=0x6000050  System.Void PutShort(System.Int16 x)
  RVA=0x0853C8BC  token=0x6000051  System.Void PutUshort(System.UInt16 x)
  RVA=0x0853C64C  token=0x6000052  System.Void PutInt(System.Int32 x)
  RVA=0x0853C7EC  token=0x6000053  System.Void PutUint(System.UInt32 x)
  RVA=0x0853C6B4  token=0x6000054  System.Void PutLong(System.Int64 x)
  RVA=0x0853C854  token=0x6000055  System.Void PutUlong(System.UInt64 x)
  RVA=0x0853C5E4  token=0x6000056  System.Void PutFloat(System.Single x)
  RVA=-1  // generic def  token=0x6000057  System.Void Put(T[] x)
  RVA=-1  // generic def  token=0x6000058  System.Void Put(System.ArraySegment<T> x)
  RVA=-1  // generic def  token=0x6000059  System.Void Put(System.IntPtr ptr, System.Int32 sizeInBytes)
  RVA=-1  // generic def  token=0x600005A  System.Void Put(System.Span<T> x)
  RVA=0x0853C57C  token=0x600005B  System.Void PutDouble(System.Double x)
  RVA=0x0853ACA0  token=0x600005C  System.Void AddBool(System.Boolean x)
  RVA=0x0853B2E8  token=0x600005D  System.Void AddSbyte(System.SByte x)
  RVA=0x0853AD1C  token=0x600005E  System.Void AddByte(System.Byte x)
  RVA=0x0853B4B4  token=0x600005F  System.Void AddShort(System.Int16 x)
  RVA=0x0853B7E4  token=0x6000060  System.Void AddUshort(System.UInt16 x)
  RVA=0x0853B024  token=0x6000061  System.Void AddInt(System.Int32 x)
  RVA=0x0853B568  token=0x6000062  System.Void AddUint(System.UInt32 x)
  RVA=0x0853B120  token=0x6000063  System.Void AddLong(System.Int64 x)
  RVA=0x0853B6E4  token=0x6000064  System.Void AddUlong(System.UInt64 x)
  RVA=0x0853AF64  token=0x6000065  System.Void AddFloat(System.Single x)
  RVA=-1  // generic def  token=0x6000066  System.Void Add(T[] x)
  RVA=-1  // generic def  token=0x6000067  System.Void Add(System.ArraySegment<T> x)
  RVA=-1  // generic def  token=0x6000068  System.Void Add(System.IntPtr ptr, System.Int32 sizeInBytes)
  RVA=-1  // generic def  token=0x6000069  System.Void Add(System.Span<T> x)
  RVA=0x0853AEE0  token=0x600006A  System.Void AddDouble(System.Double x)
  RVA=0x0853B218  token=0x600006B  System.Void AddOffset(System.Int32 off)
  RVA=0x0853CBE0  token=0x600006C  System.Void StartVector(System.Int32 elemSize, System.Int32 count, System.Int32 alignment)
  RVA=0x0853BF08  token=0x600006D  Google.FlatBuffers.VectorOffset EndVector()
  RVA=-1  // generic def  token=0x600006E  Google.FlatBuffers.VectorOffset CreateVectorOfTables(Google.FlatBuffers.Offset<T>[] offsets)
  RVA=0x0853C2BC  token=0x600006F  System.Void Nested(System.Int32 obj)
  RVA=0x0853C32C  token=0x6000070  System.Void NotNested()
  RVA=0x0853CB0C  token=0x6000071  System.Void StartTable(System.Int32 numfields)
  RVA=0x0853CA7C  token=0x6000072  System.Void Slot(System.Int32 voffset)
  RVA=0x0853ACD8  token=0x6000073  System.Void AddBool(System.Int32 o, System.Boolean x, System.Boolean d)
  RVA=0x0853AC18  token=0x6000074  System.Void AddBool(System.Int32 o, System.Nullable<System.Boolean> x)
  RVA=0x0853B3A8  token=0x6000075  System.Void AddSbyte(System.Int32 o, System.SByte x, System.SByte d)
  RVA=0x0853B320  token=0x6000076  System.Void AddSbyte(System.Int32 o, System.Nullable<System.SByte> x)
  RVA=0x0853ADDC  token=0x6000077  System.Void AddByte(System.Int32 o, System.Byte x, System.Byte d)
  RVA=0x0853AD54  token=0x6000078  System.Void AddByte(System.Int32 o, System.Nullable<System.Byte> x)
  RVA=0x0853B3EC  token=0x6000079  System.Void AddShort(System.Int32 o, System.Int16 x, System.Int32 d)
  RVA=0x0853B430  token=0x600007A  System.Void AddShort(System.Int32 o, System.Nullable<System.Int16> x)
  RVA=0x0853B7A0  token=0x600007B  System.Void AddUshort(System.Int32 o, System.UInt16 x, System.UInt16 d)
  RVA=0x0853B71C  token=0x600007C  System.Void AddUshort(System.Int32 o, System.Nullable<System.UInt16> x)
  RVA=0x0853B05C  token=0x600007D  System.Void AddInt(System.Int32 o, System.Int32 x, System.Int32 d)
  RVA=0x0853B09C  token=0x600007E  System.Void AddInt(System.Int32 o, System.Nullable<System.Int32> x)
  RVA=0x0853B528  token=0x600007F  System.Void AddUint(System.Int32 o, System.UInt32 x, System.UInt32 d)
  RVA=0x0853B5A0  token=0x6000080  System.Void AddUint(System.Int32 o, System.Nullable<System.UInt32> x)
  RVA=0x0853B1D8  token=0x6000081  System.Void AddLong(System.Int32 o, System.Int64 x, System.Int64 d)
  RVA=0x0853B158  token=0x6000082  System.Void AddLong(System.Int32 o, System.Nullable<System.Int64> x)
  RVA=0x0853B6A4  token=0x6000083  System.Void AddUlong(System.Int32 o, System.UInt64 x, System.UInt64 d)
  RVA=0x0853B624  token=0x6000084  System.Void AddUlong(System.Int32 o, System.Nullable<System.UInt64> x)
  RVA=0x0853AF1C  token=0x6000085  System.Void AddFloat(System.Int32 o, System.Single x, System.Double d)
  RVA=0x0853AFA0  token=0x6000086  System.Void AddFloat(System.Int32 o, System.Nullable<System.Single> x)
  RVA=0x0853AEA0  token=0x6000087  System.Void AddDouble(System.Int32 o, System.Double x, System.Double d)
  RVA=0x0853AE20  token=0x6000088  System.Void AddDouble(System.Int32 o, System.Nullable<System.Double> x)
  RVA=0x0853B2AC  token=0x6000089  System.Void AddOffset(System.Int32 o, System.Int32 x, System.Int32 d)
  RVA=0x0853B9F0  token=0x600008A  Google.FlatBuffers.StringOffset CreateString(System.String s)
  RVA=0x0853BAD0  token=0x600008B  Google.FlatBuffers.StringOffset CreateUTF8String(System.Span<System.Byte> chars)
  RVA=0x0853B8CC  token=0x600008C  Google.FlatBuffers.StringOffset CreateSharedString(System.String s)
  RVA=0x0853B4EC  token=0x600008D  System.Void AddStruct(System.Int32 voffset, System.Int32 x, System.Int32 d)
  RVA=0x0853BBD4  token=0x600008E  System.Int32 EndTable()
  RVA=0x0853C924  token=0x600008F  System.Void Required(System.Int32 table, System.Int32 field)
  RVA=0x0853BF54  token=0x6000090  System.Void Finish(System.Int32 rootTable, System.Boolean sizePrefix)
  RVA=0x0853C104  token=0x6000091  System.Void Finish(System.Int32 rootTable)
  RVA=0x0853BF48  token=0x6000092  System.Void FinishSizePrefixed(System.Int32 rootTable)
  RVA=0x0853CA30  token=0x6000094  System.Byte[] SizedByteArray()
  RVA=0x0853BFF0  token=0x6000095  System.Void Finish(System.Int32 rootTable, System.String fileIdentifier, System.Boolean sizePrefix)
  RVA=0x0853C110  token=0x6000096  System.Void Finish(System.Int32 rootTable, System.String fileIdentifier)
  RVA=0x0853BF2C  token=0x6000097  System.Void FinishSizePrefixed(System.Int32 rootTable, System.String fileIdentifier)
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferConstants
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    FileIdentifierLength  // const
  public    static  System.Int32                    SizePrefixLength  // const
METHODS:
  RVA=0x0350B670  token=0x6000098  System.Void FLATBUFFERS_23_1_21()
END_CLASS

CLASS: Google.FlatBuffers.FlatBufferUtils
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D4FEA0  token=0x6000099  System.Int16 ReinterpretAsShort(System.UInt16 val)
  RVA=0x03D4FEA0  token=0x600009A  System.UInt16 ReinterpretAsUShort(System.Int16 val)
  RVA=0x03D6BAE0  token=0x600009B  System.Void ReinterpretAsFloat(System.Int64 val, System.Single& floatValLow, System.Single& floatValHigh)
  RVA=-1  // generic def  token=0x600009C  System.Span<T> AsSpan(Unity.Collections.NativeArray<T> nativeArray)
  RVA=-1  // generic def  token=0x600009D  System.ReadOnlySpan<T> AsReadOnlySpan(Unity.Collections.NativeArray<T> nativeArray)
END_CLASS

CLASS: Google.FlatBuffers.IFlatbufferObject
TYPE:  interface
TOKEN: 0x200000C
FIELDS:
PROPERTIES:
  ByteBuffer  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600009E  System.Void __init(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
END_CLASS

CLASS: Google.FlatBuffers.Offset`1
TYPE:  sealed struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    Value  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60000A0  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.StringOffset
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x14
FIELDS:
  public            System.Int32                    Value  // 0x10
METHODS:
  RVA=0x03D4E970  token=0x60000A1  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.VectorOffset
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  public            System.Int32                    Value  // 0x10
METHODS:
  RVA=0x03D4E970  token=0x60000A2  System.Void .ctor(System.Int32 value)
END_CLASS

CLASS: Google.FlatBuffers.Struct
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x30
FIELDS:
  private           System.Int32                    <bb_pos>k__BackingField  // 0x10
  private           Google.FlatBuffers.ByteBuffer   <bb>k__BackingField  // 0x18
PROPERTIES:
  bb_pos  get=0x03D4E980  set=0x03D4E970
  bb  get=0x03D5C760  set=0x03D6BB20
METHODS:
  RVA=0x03D6BB00  token=0x60000A7  System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
END_CLASS

CLASS: Google.FlatBuffers.Table
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x30
FIELDS:
  private           System.Int32                    <bb_pos>k__BackingField  // 0x10
  private           Google.FlatBuffers.ByteBuffer   <bb>k__BackingField  // 0x18
PROPERTIES:
  bb_pos  get=0x03D4E980  set=0x03D4E970
  bb  get=0x03D5C760  set=0x03D6BB20
  ByteBuffer  get=0x03D5C760
METHODS:
  RVA=0x03D6BB00  token=0x60000AD  System.Void .ctor(System.Int32 _i, Google.FlatBuffers.ByteBuffer _bb)
  RVA=0x0853D2A0  token=0x60000AE  System.Int32 __offset(System.Int32 vtableOffset)
  RVA=0x0853D228  token=0x60000AF  System.Int32 __offset(System.Int32 vtableOffset, System.Int32 offset, Google.FlatBuffers.ByteBuffer bb)
  RVA=0x0853D1C4  token=0x60000B0  System.Int32 __indirect(System.Int32 offset)
  RVA=0x0853D16C  token=0x60000B1  System.Int32 __indirect(System.Int32 offset, Google.FlatBuffers.ByteBuffer bb)
  RVA=0x026F65A0  token=0x60000B2  System.String __string(System.Int32 offset)
  RVA=0x0853D37C  token=0x60000B3  System.Int32 __vector_len(System.Int32 offset)
  RVA=0x0853D404  token=0x60000B4  System.Int32 __vector(System.Int32 offset)
  RVA=-1  // generic def  token=0x60000B5  System.Span<T> __vector_as_span(System.Int32 offset, System.Int32 elementSize)
  RVA=-1  // generic def  token=0x60000B6  T[] __vector_as_array(System.Int32 offset)
  RVA=-1  // generic def  token=0x60000B7  T __union(System.Int32 offset)
  RVA=0x0853D044  token=0x60000B8  System.Boolean __has_identifier(Google.FlatBuffers.ByteBuffer bb, System.String ident)
  RVA=0x0853CF2C  token=0x60000B9  System.Int32 CompareStrings(System.Int32 offset_1, System.Int32 offset_2, Google.FlatBuffers.ByteBuffer bb)
  RVA=0x0853CE24  token=0x60000BA  System.Int32 CompareStrings(System.Int32 offset_1, System.Byte[] key, Google.FlatBuffers.ByteBuffer bb)
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

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

