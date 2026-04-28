// ========================================================
// Dumped by @desirepro
// Assembly: ZSimpleJSON.dll
// Classes:  23
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

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeNone  // const
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeArray  // const
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeObject  // const
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x58
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator.Typetype  // 0x10
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode>m_Object  // 0x18
  private           System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode>m_Array  // 0x40
PROPERTIES:
  IsValid  get=0x0426F724
  Current  get=0x025F6B90
METHODS:
  RVA=0x08854824  token=0x60000C1  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  RVA=0x03B109F0  token=0x60000C2  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  RVA=0x025F6930  token=0x60000C4  System.Boolean MoveNext()
END_CLASS

CLASS: ValueEnumerator
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x58
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x10
PROPERTIES:
  Current  get=0x0A2BDE64
METHODS:
  RVA=0x0885EBAC  token=0x60000C5  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  RVA=0x0885EAD8  token=0x60000C6  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  RVA=0x0885EB78  token=0x60000C7  System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator)
  RVA=0x0A2BCC00  token=0x60000C9  System.Boolean MoveNext()
  RVA=0x03D6D9B0  token=0x60000CA  ZSimpleJSON.JSONNode.ValueEnumerator GetEnumerator()
END_CLASS

CLASS: KeyEnumerator
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x58
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x10
PROPERTIES:
  Current  get=0x0A2BCC08
METHODS:
  RVA=0x0885EBAC  token=0x60000CB  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  RVA=0x0885EAD8  token=0x60000CC  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  RVA=0x0885EB78  token=0x60000CD  System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator)
  RVA=0x0A2BCC00  token=0x60000CF  System.Boolean MoveNext()
  RVA=0x03D6D9B0  token=0x60000D0  ZSimpleJSON.JSONNode.KeyEnumerator GetEnumerator()
END_CLASS

CLASS: LinqEnumerator
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x60
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           ZSimpleJSON.JSONNode            m_Node  // 0x10
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x18
PROPERTIES:
  Current  get=0x0A2BCECC
  System.Collections.IEnumerator.Current  get=0x0A2BCDC0
METHODS:
  RVA=0x0A2BCE18  token=0x60000D1  System.Void .ctor(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BCCAC  token=0x60000D4  System.Boolean MoveNext()
  RVA=0x0885EC84  token=0x60000D5  System.Void Dispose()
  RVA=0x0A2BCC48  token=0x60000D6  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> GetEnumerator()
  RVA=0x0A2BCCB8  token=0x60000D7  System.Void Reset()
  RVA=0x0A2BCD5C  token=0x60000D8  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_Children>d__181
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           ZSimpleJSON.JSONNode            <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x60000D9  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000DA  System.Void System.IDisposable.Dispose()
  RVA=0x03D4C410  token=0x60000DB  System.Boolean MoveNext()
  RVA=0x0A2BCFDC  token=0x60000DD  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x0A2BCF5C  token=0x60000DF  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator()
  RVA=0x0A2BCFD4  token=0x60000E0  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_DeepChildren>d__183
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           ZSimpleJSON.JSONNode            <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            ZSimpleJSON.JSONNode            <>4__this  // 0x28
  private           System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode><>7__wrap1  // 0x30
  private           System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode><>7__wrap2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x60000E1  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0A2BDCE4  token=0x60000E2  System.Void System.IDisposable.Dispose()
  RVA=0x0A2BD80C  token=0x60000E3  System.Boolean MoveNext()
  RVA=0x0A2BDDD0  token=0x60000E4  System.Void <>m__Finally1()
  RVA=0x0A2BDE18  token=0x60000E5  System.Void <>m__Finally2()
  RVA=0x0A2BDC98  token=0x60000E7  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x0A2BDC04  token=0x60000E9  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator()
  RVA=0x0A2BDC90  token=0x60000EA  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_Children>d__24
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           ZSimpleJSON.JSONNode            <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            ZSimpleJSON.JSONArray           <>4__this  // 0x28
  private           System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x60000FD  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0A2BD350  token=0x60000FE  System.Void System.IDisposable.Dispose()
  RVA=0x0A2BD028  token=0x60000FF  System.Boolean MoveNext()
  RVA=0x0A2BD3C8  token=0x6000100  System.Void <>m__Finally1()
  RVA=0x0A2BD304  token=0x6000102  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x0A2BD270  token=0x6000104  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator()
  RVA=0x0A2BD2FC  token=0x6000105  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c__DisplayClass21_0
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x18
FIELDS:
  public            ZSimpleJSON.JSONNode            aNode  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600011B  System.Void .ctor()
  RVA=0x0A2BCEF8  token=0x600011C  System.Boolean <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> k)
END_CLASS

CLASS: <get_Children>d__27
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           ZSimpleJSON.JSONNode            <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            ZSimpleJSON.JSONObject          <>4__this  // 0x28
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x600011D  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0A2BD758  token=0x600011E  System.Void System.IDisposable.Dispose()
  RVA=0x0A2BD404  token=0x600011F  System.Boolean MoveNext()
  RVA=0x0A2BD7D0  token=0x6000120  System.Void <>m__Finally1()
  RVA=0x0A2BD70C  token=0x6000122  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x0A2BD678  token=0x6000124  System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator()
  RVA=0x0A2BD704  token=0x6000125  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ZSimpleJSON.JSONNode
TYPE:  abstract class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
  public    static  System.Byte                     Color32DefaultAlpha  // static @ 0x0
  public    static  System.Single                   ColorDefaultAlpha  // static @ 0x4
  public    static  ZSimpleJSON.JSONContainerType   VectorContainerType  // static @ 0x8
  public    static  ZSimpleJSON.JSONContainerType   QuaternionContainerType  // static @ 0xc
  public    static  ZSimpleJSON.JSONContainerType   RectContainerType  // static @ 0x10
  public    static  ZSimpleJSON.JSONContainerType   ColorContainerType  // static @ 0x14
  public    static  System.Boolean                  forceASCII  // static @ 0x18
  public    static  System.Boolean                  longAsString  // static @ 0x19
  public    static  System.Boolean                  allowLineComments  // static @ 0x1a
  private   static  System.Text.StringBuilder       m_EscapeBuilder  // static @ 0xffffffff
PROPERTIES:
  AsDecimal  get=0x0A2B9774  set=0x0A2BBA90
  AsChar  get=0x0A2B9638  set=0x0A2BB970
  AsUInt  get=0x0A2B9C1C  set=0x0A2BBE00
  AsByte  get=0x0A2B9628  set=0x0A2BB95C
  AsSByte  get=0x0A2B9628  set=0x0A2BBC0C
  AsShort  get=0x0A2B9628  set=0x0A2BBC20
  AsUShort  get=0x0A2B9628  set=0x0A2BBE80
  AsDateTime  get=0x0A2B96C0  set=0x0A2BBA08
  AsTimeSpan  get=0x0A2B9B6C  set=0x0A2BBDA8
  AsGuid  get=0x0A2B9890  set=0x0A2BBB64
  AsByteArray  get=0x0A2B9454  set=0x0A2BB7F0
  AsByteList  get=0x0A2B9528  set=0x0A2BB898
  AsUlongArray  get=0x0A2B9CB4  set=0x0A2BBE94
  AsStringArray  get=0x0A2B9994  set=0x0A2BBC34
  AsStringList  get=0x0A2B9A68  set=0x0A2BBCE0
  Tag  get=-1  // abstract
  Item  get=0x01002730  set=0x0350B670
  Item  get=0x01002730  set=0x0350B670
  Value  get=0x0A2B9F64  set=0x0350B670
  Count  get=0x01002730
  IsNumber  get=0x0115F4C0
  IsString  get=0x0115F4C0
  IsBoolean  get=0x0115F4C0
  IsNull  get=0x0115F4C0
  IsArray  get=0x0115F4C0
  IsObject  get=0x0115F4C0
  Inline  get=0x0115F4C0  set=0x0350B670
  Children  get=0x0A2B9D8C
  DeepChildren  get=0x0A2B9DE0
  Linq  get=0x0A2B9F04
  Keys  get=0x0A2B9E50
  Values  get=0x0A2B9E50
  AsDouble  get=0x0A2B97E8  set=0x0A2BBAEC
  AsInt  get=0x0A2B98C0  set=0x0A2BBB90
  AsFloat  get=0x0A2B9874  set=0x0A2BBB50
  AsBool  get=0x0A2B93B8  set=0x0A2BB784
  AsLong  get=0x0A2B98DC  set=0x0A2BBBA8
  AsULong  get=0x0A2B9C38  set=0x0A2BBE1C
  AsArray  get=0x0A2B937C
  AsObject  get=0x0A2B9958
  EscapeBuilder  get=0x025F39E0
METHODS:
  RVA=0x0A2BA6F0  token=0x6000003  ZSimpleJSON.JSONNode op_Implicit(System.Decimal aDecimal)
  RVA=0x0A2BACB4  token=0x6000004  System.Decimal op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB3FC  token=0x6000007  ZSimpleJSON.JSONNode op_Implicit(System.Char aChar)
  RVA=0x0A2BB3C4  token=0x6000008  System.Char op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x03B33880  token=0x600000B  ZSimpleJSON.JSONNode op_Implicit(System.UInt32 aUInt)
  RVA=0x0A2BB324  token=0x600000C  System.UInt32 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BAEB4  token=0x600000F  ZSimpleJSON.JSONNode op_Implicit(System.Byte aByte)
  RVA=0x0A2BA410  token=0x6000010  System.Byte op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB654  token=0x6000013  ZSimpleJSON.JSONNode op_Implicit(System.SByte aSByte)
  RVA=0x0A2BA410  token=0x6000014  System.SByte op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA3AC  token=0x6000017  ZSimpleJSON.JSONNode op_Implicit(System.Int16 aShort)
  RVA=0x0A2BA410  token=0x6000018  System.Int16 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB208  token=0x600001B  ZSimpleJSON.JSONNode op_Implicit(System.UInt16 aUShort)
  RVA=0x0A2BA410  token=0x600001C  System.UInt16 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA1BC  token=0x600001F  ZSimpleJSON.JSONNode op_Implicit(System.DateTime aDateTime)
  RVA=0x0A2BAD4C  token=0x6000020  System.DateTime op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA324  token=0x6000023  ZSimpleJSON.JSONNode op_Implicit(System.TimeSpan aTimeSpan)
  RVA=0x0A2BAC7C  token=0x6000024  System.TimeSpan op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA150  token=0x6000027  ZSimpleJSON.JSONNode op_Implicit(System.Guid aGuid)
  RVA=0x0A2BAE84  token=0x6000028  System.Guid op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA684  token=0x600002B  ZSimpleJSON.JSONNode op_Implicit(System.Byte[] aByteArray)
  RVA=0x0A2BAE00  token=0x600002C  System.Byte[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB19C  token=0x600002F  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.Byte> aByteList)
  RVA=0x0A2BA42C  token=0x6000030  System.Collections.Generic.List<System.Byte> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB4FC  token=0x6000033  ZSimpleJSON.JSONNode op_Implicit(System.UInt64[] aStringArray)
  RVA=0x0A2BAAC0  token=0x6000034  System.UInt64[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA508  token=0x6000037  ZSimpleJSON.JSONNode op_Implicit(System.String[] aStringArray)
  RVA=0x0A2BAC98  token=0x6000038  System.String[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BAF80  token=0x600003B  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.String> aStringList)
  RVA=0x0A2BB080  token=0x600003C  System.Collections.Generic.List<System.String> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x03B36560  token=0x600003D  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int32> aValue)
  RVA=0x0A2BAD68  token=0x600003E  System.Nullable<System.Int32> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BAA04  token=0x600003F  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Single> aValue)
  RVA=0x0A2BB104  token=0x6000040  System.Nullable<System.Single> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA954  token=0x6000041  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Double> aValue)
  RVA=0x0A2BA820  token=0x6000042  System.Nullable<System.Double> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA068  token=0x6000043  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Boolean> aValue)
  RVA=0x0A2BB26C  token=0x6000044  System.Nullable<System.Boolean> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BAB44  token=0x6000045  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int64> aValue)
  RVA=0x0A2BA774  token=0x6000046  System.Nullable<System.Int64> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA26C  token=0x6000047  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int16> aValue)
  RVA=0x0A2BAFEC  token=0x6000048  System.Nullable<System.Int16> op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2B722C  token=0x6000049  ZSimpleJSON.JSONNode GetContainer(ZSimpleJSON.JSONContainerType aType)
  RVA=0x0A2BA574  token=0x600004A  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector2 aVec)
  RVA=0x0A2BB6B8  token=0x600004B  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector3 aVec)
  RVA=0x0A2BB568  token=0x600004C  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector4 aVec)
  RVA=0x0A2BABF8  token=0x600004D  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color aCol)
  RVA=0x0A2B9FC0  token=0x600004E  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color32 aCol)
  RVA=0x0A2BA8D0  token=0x600004F  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Quaternion aRot)
  RVA=0x0A2BB340  token=0x6000050  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Rect aRect)
  RVA=0x0A2BB484  token=0x6000051  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.RectOffset aRect)
  RVA=0x0A2BB3E0  token=0x6000052  UnityEngine.Vector2 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA4D0  token=0x6000053  UnityEngine.Vector3 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BAF18  token=0x6000054  UnityEngine.Vector4 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2B9F90  token=0x6000055  UnityEngine.Color op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA4B0  token=0x6000056  UnityEngine.Color32 op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA038  token=0x6000057  UnityEngine.Quaternion op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BA120  token=0x6000058  UnityEngine.Rect op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2BB308  token=0x6000059  UnityEngine.RectOffset op_Implicit(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2B7F3C  token=0x600005A  UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
  RVA=0x0A2B7E9C  token=0x600005B  UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName)
  RVA=0x0A2B7E84  token=0x600005C  UnityEngine.Vector2 ReadVector2()
  RVA=0x0A2B8F78  token=0x600005D  ZSimpleJSON.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName)
  RVA=0x0A2B815C  token=0x600005E  UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
  RVA=0x0A2B8074  token=0x600005F  UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName)
  RVA=0x0A2B8024  token=0x6000060  UnityEngine.Vector3 ReadVector3()
  RVA=0x0A2B9070  token=0x6000061  ZSimpleJSON.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName)
  RVA=0x0A2B82D8  token=0x6000062  UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
  RVA=0x0A2B84B4  token=0x6000063  UnityEngine.Vector4 ReadVector4()
  RVA=0x0A2B91B0  token=0x6000064  ZSimpleJSON.JSONNode WriteVector4(UnityEngine.Vector4 aVec)
  RVA=0x0A2B74C8  token=0x6000065  UnityEngine.Color ReadColor(UnityEngine.Color aDefault)
  RVA=0x0A2B76FC  token=0x6000066  UnityEngine.Color ReadColor()
  RVA=0x0A2B8748  token=0x6000067  ZSimpleJSON.JSONNode WriteColor(UnityEngine.Color aCol)
  RVA=0x0A2B72BC  token=0x6000068  UnityEngine.Color32 ReadColor32(UnityEngine.Color32 aDefault)
  RVA=0x0A2B72B0  token=0x6000069  UnityEngine.Color32 ReadColor32()
  RVA=0x0A2B8580  token=0x600006A  ZSimpleJSON.JSONNode WriteColor32(UnityEngine.Color32 aCol)
  RVA=0x0A2B77E0  token=0x600006B  UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
  RVA=0x0A2B79BC  token=0x600006C  UnityEngine.Quaternion ReadQuaternion()
  RVA=0x0A2B89A8  token=0x600006D  ZSimpleJSON.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
  RVA=0x0A2B7C74  token=0x600006E  UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault)
  RVA=0x0A2B7E50  token=0x600006F  UnityEngine.Rect ReadRect()
  RVA=0x0A2B8DAC  token=0x6000070  ZSimpleJSON.JSONNode WriteRect(UnityEngine.Rect aRect)
  RVA=0x0A2B7A60  token=0x6000071  UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault)
  RVA=0x0A2B79F8  token=0x6000072  UnityEngine.RectOffset ReadRectOffset()
  RVA=0x0A2B8B74  token=0x6000073  ZSimpleJSON.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect)
  RVA=0x0A2B7738  token=0x6000074  UnityEngine.Matrix4x4 ReadMatrix()
  RVA=0x0A2B8914  token=0x6000075  ZSimpleJSON.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
  RVA=0x0350B670  token=0x6000086  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  RVA=0x0299FA70  token=0x6000087  System.Void Add(ZSimpleJSON.JSONNode aItem)
  RVA=0x01002730  token=0x6000088  ZSimpleJSON.JSONNode Remove(System.String aKey)
  RVA=0x01002730  token=0x6000089  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  RVA=0x03D51810  token=0x600008A  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  RVA=0x0350B670  token=0x600008B  System.Void Clear()
  RVA=0x01002730  token=0x600008C  ZSimpleJSON.JSONNode Clone()
  RVA=0x0115F4C0  token=0x600008F  System.Boolean HasKey(System.String aKey)
  RVA=0x03D553C0  token=0x6000090  ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault)
  RVA=0x037078B0  token=0x6000091  System.String ToString()
  RVA=0x0A2B84F0  token=0x6000092  System.String ToString(System.Int32 aIndent)
  RVA=0x0267F1C0  token=0x6000093  System.Void ToStringBuild(System.Text.StringBuilder& sb)
  RVA=-1  // abstract  token=0x6000094  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=-1  // abstract  token=0x6000095  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x029A38F0  token=0x60000A7  ZSimpleJSON.JSONNode op_Implicit(System.String s)
  RVA=0x0A2BA61C  token=0x60000A8  System.String op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x0268C840  token=0x60000A9  ZSimpleJSON.JSONNode op_Implicit(System.Double n)
  RVA=0x0A2BAADC  token=0x60000AA  System.Double op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x0299F790  token=0x60000AB  ZSimpleJSON.JSONNode op_Implicit(System.Single n)
  RVA=0x0A2BACE4  token=0x60000AC  System.Single op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x0299F800  token=0x60000AD  ZSimpleJSON.JSONNode op_Implicit(System.Int32 n)
  RVA=0x0A2BAE1C  token=0x60000AE  System.Int32 op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x0299F6C0  token=0x60000AF  ZSimpleJSON.JSONNode op_Implicit(System.Int64 n)
  RVA=0x0A2BB09C  token=0x60000B0  System.Int64 op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x02BFEFD0  token=0x60000B1  ZSimpleJSON.JSONNode op_Implicit(System.UInt64 n)
  RVA=0x0A2BA448  token=0x60000B2  System.UInt64 op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x029A6DA0  token=0x60000B3  ZSimpleJSON.JSONNode op_Implicit(System.Boolean b)
  RVA=0x0A2BB5EC  token=0x60000B4  System.Boolean op_Implicit(ZSimpleJSON.JSONNode d)
  RVA=0x0A2BAF48  token=0x60000B5  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> aKeyValue)
  RVA=0x030467A0  token=0x60000B6  System.Boolean op_Equality(ZSimpleJSON.JSONNode a, System.Object b)
  RVA=0x03046600  token=0x60000B7  System.Boolean op_Inequality(ZSimpleJSON.JSONNode a, System.Object b)
  RVA=0x030465F0  token=0x60000B8  System.Boolean Equals(System.Object obj)
  RVA=0x03D4F970  token=0x60000B9  System.Int32 GetHashCode()
  RVA=0x025F3500  token=0x60000BB  System.String Escape(System.String aText)
  RVA=0x029A3840  token=0x60000BC  ZSimpleJSON.JSONNode ParseElement(System.String token, System.Boolean quoted)
  RVA=0x029A3260  token=0x60000BD  ZSimpleJSON.JSONNode Parse(System.String aJSON)
  RVA=0x0350B670  token=0x60000BE  System.Void .ctor()
  RVA=0x03CA8AC0  token=0x60000BF  System.Void .cctor()
END_CLASS

CLASS: ZSimpleJSON.JSONContainerType
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONContainerType   Array  // const
  public    static  ZSimpleJSON.JSONContainerType   Object  // const
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONNodeType
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONNodeType        Array  // const
  public    static  ZSimpleJSON.JSONNodeType        Object  // const
  public    static  ZSimpleJSON.JSONNodeType        String  // const
  public    static  ZSimpleJSON.JSONNodeType        Number  // const
  public    static  ZSimpleJSON.JSONNodeType        NullValue  // const
  public    static  ZSimpleJSON.JSONNodeType        Boolean  // const
  public    static  ZSimpleJSON.JSONNodeType        None  // const
  public    static  ZSimpleJSON.JSONNodeType        Custom  // const
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONTextMode
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONTextMode        Compact  // const
  public    static  ZSimpleJSON.JSONTextMode        Indent  // const
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONArray
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x20
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           System.Collections.Generic.List<ZSimpleJSON.JSONNode>m_List  // 0x10
  private           System.Boolean                  inline  // 0x18
PROPERTIES:
  Inline  get=0x01002A50  set=0x01002B40
  Tag  get=0x01168950
  IsArray  get=0x0232EB60
  Item  get=0x0A2B614C  set=0x03046420
  Item  get=0x0A2B614C  set=0x03046420
  Count  get=0x0A2B60AC
  Children  get=0x0A2B603C
METHODS:
  RVA=0x0A2B5EB0  token=0x60000EF  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x03046380  token=0x60000F5  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  RVA=0x0A2B5F40  token=0x60000F6  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  RVA=0x0A2B5FE4  token=0x60000F7  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2B5C38  token=0x60000F8  System.Void Clear()
  RVA=0x0A2B5C80  token=0x60000F9  ZSimpleJSON.JSONNode Clone()
  RVA=0x025F6160  token=0x60000FB  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x029A5A60  token=0x60000FC  System.Void .ctor()
END_CLASS

CLASS: ZSimpleJSON.JSONObject
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x20
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,ZSimpleJSON.JSONNode>m_Dict  // 0x10
  private           System.Boolean                  inline  // 0x18
PROPERTIES:
  Inline  get=0x01002A50  set=0x01002B40
  Tag  get=0x02102C70
  IsObject  get=0x0232EB60
  Item  get=0x0A2BC998  set=0x03046660
  Item  get=0x0A2BC998  set=0x03046660
  Count  get=0x0A2BC8CC
  Children  get=0x0A2BC85C
METHODS:
  RVA=0x03B10940  token=0x600010A  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x03046260  token=0x6000110  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  RVA=0x0A2BC538  token=0x6000111  ZSimpleJSON.JSONNode Remove(System.String aKey)
  RVA=0x0A2BC5F0  token=0x6000112  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  RVA=0x0A2BC6B0  token=0x6000113  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  RVA=0x0368EAF0  token=0x6000114  System.Void Clear()
  RVA=0x0A2BC29C  token=0x6000115  ZSimpleJSON.JSONNode Clone()
  RVA=0x0A2BC4E4  token=0x6000116  System.Boolean HasKey(System.String aKey)
  RVA=0x0A2BC468  token=0x6000117  ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault)
  RVA=0x025F52C0  token=0x6000119  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x0299F420  token=0x600011A  System.Void .ctor()
END_CLASS

CLASS: ZSimpleJSON.JSONString
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x18
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           System.String                   m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D555E0
  IsString  get=0x0232EB60
  Value  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x03D60600  token=0x6000128  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x029A3990  token=0x600012B  System.Void .ctor(System.String aData)
  RVA=0x0A2BCB9C  token=0x600012C  ZSimpleJSON.JSONNode Clone()
  RVA=0x025EF9D0  token=0x600012D  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x03046520  token=0x600012E  System.Boolean Equals(System.Object obj)
  RVA=0x06FAB9A8  token=0x600012F  System.Int32 GetHashCode()
  RVA=0x0A2BCB5C  token=0x6000130  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONNumber
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x18
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           System.Double                   m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D50CD0
  IsNumber  get=0x0232EB60
  Value  get=0x022FC830  set=0x0A2BC21C
  AsDouble  get=0x03D61CF0  set=0x03D4E410
  AsLong  get=0x03D6D990  set=0x03D6D9A0
  AsULong  get=0x0A2BC210  set=0x03D8A1F0
METHODS:
  RVA=0x03D60600  token=0x6000133  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x0299F870  token=0x600013C  System.Void .ctor(System.Double aData)
  RVA=0x0A2BC1B4  token=0x600013D  System.Void .ctor(System.String aData)
  RVA=0x0A2BC004  token=0x600013E  ZSimpleJSON.JSONNode Clone()
  RVA=0x025EF5D0  token=0x600013F  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x0A2BC06C  token=0x6000140  System.Boolean IsNumeric(System.Object value)
  RVA=0x0343A070  token=0x6000141  System.Boolean Equals(System.Object obj)
  RVA=0x0885DAE0  token=0x6000142  System.Int32 GetHashCode()
  RVA=0x03D735B0  token=0x6000143  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONBool
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x18
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           System.Boolean                  m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D51110
  IsBoolean  get=0x0232EB60
  Value  get=0x0A2B6394  set=0x0A2B63E0
  AsBool  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x03D60600  token=0x6000146  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x029A6E10  token=0x600014B  System.Void .ctor(System.Boolean aData)
  RVA=0x0A2B6338  token=0x600014C  System.Void .ctor(System.String aData)
  RVA=0x0A2B628C  token=0x600014D  ZSimpleJSON.JSONNode Clone()
  RVA=0x0367B270  token=0x600014E  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x0371BBB0  token=0x600014F  System.Boolean Equals(System.Object obj)
  RVA=0x0A2B62F0  token=0x6000150  System.Int32 GetHashCode()
  RVA=0x03D557C0  token=0x6000151  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONNull
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x10
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private   static  ZSimpleJSON.JSONNull            m_StaticInstance  // static @ 0x0
  public    static  System.Boolean                  reuseSameInstance  // static @ 0x8
PROPERTIES:
  Tag  get=0x03D51100
  IsNull  get=0x0232EB60
  Value  get=0x0A2BBFD8  set=0x0350B670
  AsBool  get=0x0115F4C0  set=0x0350B670
METHODS:
  RVA=0x03046880  token=0x6000152  ZSimpleJSON.JSONNull CreateOrGet()
  RVA=0x03CB7240  token=0x6000153  System.Void .ctor()
  RVA=0x03D60600  token=0x6000156  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x0A2BBF40  token=0x600015B  ZSimpleJSON.JSONNode Clone()
  RVA=0x0A2BBF80  token=0x600015C  System.Boolean Equals(System.Object obj)
  RVA=0x01002730  token=0x600015D  System.Int32 GetHashCode()
  RVA=0x037904F0  token=0x600015E  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  RVA=0x03CB71B0  token=0x600015F  System.Void .cctor()
END_CLASS

CLASS: ZSimpleJSON.JSONLazyCreator
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x20
EXTENDS: ZSimpleJSON.JSONNode
FIELDS:
  private           ZSimpleJSON.JSONNode            m_Node  // 0x10
  private           System.String                   m_Key  // 0x18
PROPERTIES:
  Tag  get=0x03D55AA0
  Item  get=0x0A2B6B74  set=0x0A2B7198
  Item  get=0x0A2B6B74  set=0x0A2B7198
  AsInt  get=0x0A2B6888  set=0x0A2B6DE0
  AsFloat  get=0x0A2B6808  set=0x0A2B6D54
  AsDouble  get=0x0A2B6788  set=0x0A2B6CCC
  AsLong  get=0x0A2B6904  set=0x0A2B6E6C
  AsULong  get=0x0A2B6A78  set=0x0A2B6FA0
  AsBool  get=0x0A2B670C  set=0x0A2B6C44
  AsArray  get=0x0A2B6694
  AsObject  get=0x0A2B6A00
METHODS:
  RVA=0x03D60600  token=0x6000161  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  RVA=0x0A2B65C8  token=0x6000162  System.Void .ctor(ZSimpleJSON.JSONNode aNode)
  RVA=0x0A2B6628  token=0x6000163  System.Void .ctor(ZSimpleJSON.JSONNode aNode, System.String aKey)
  RVA=-1  // generic def  token=0x6000164  T Set(T aVal)
  RVA=0x0A2B6444  token=0x6000169  System.Void Add(ZSimpleJSON.JSONNode aItem)
  RVA=0x0A2B64D8  token=0x600016A  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  RVA=0x0885CFA4  token=0x600016B  System.Boolean op_Equality(ZSimpleJSON.JSONLazyCreator a, System.Object b)
  RVA=0x0885D444  token=0x600016C  System.Boolean op_Inequality(ZSimpleJSON.JSONLazyCreator a, System.Object b)
  RVA=0x0885CFA4  token=0x600016D  System.Boolean Equals(System.Object obj)
  RVA=0x01002730  token=0x600016E  System.Int32 GetHashCode()
  RVA=0x0A2B6580  token=0x600017D  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
END_CLASS

CLASS: ZSimpleJSON.JSON
TYPE:  static class
TOKEN: 0x2000017
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D2C120  token=0x600017E  ZSimpleJSON.JSONNode Parse(System.String aJSON)
END_CLASS

