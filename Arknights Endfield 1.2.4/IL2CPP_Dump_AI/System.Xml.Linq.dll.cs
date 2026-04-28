// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.Linq.dll
// Classes:  38
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

CLASS: SR
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x098687C0  token=0x6000001  System.String Format(System.String resourceFormat, System.Object p1)
  RVA=0x09868750  token=0x6000002  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2)
END_CLASS

CLASS: ContentReader
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x48
FIELDS:
  private   readonly System.Xml.Linq.NamespaceCache  _eCache  // 0x10
  private   readonly System.Xml.Linq.NamespaceCache  _aCache  // 0x20
  private   readonly System.Xml.IXmlLineInfo         _lineInfo  // 0x30
  private           System.Xml.Linq.XContainer      _currentContainer  // 0x38
  private           System.String                   _baseUri  // 0x40
METHODS:
  RVA=0x0388FF30  token=0x6000031  System.Void .ctor(System.Xml.Linq.XContainer rootContainer)
  RVA=0x09867CDC  token=0x6000032  System.Void .ctor(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  RVA=0x098676CC  token=0x6000033  System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r)
  RVA=0x09866E68  token=0x6000034  System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
END_CLASS

CLASS: <Nodes>d__18
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.IDisposable System.Collections.IEnumerator
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Xml.Linq.XNode           <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            System.Xml.Linq.XContainer      <>4__this  // 0x28
  private           System.Xml.Linq.XNode           <n>5__2  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000035  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000036  System.Void System.IDisposable.Dispose()
  RVA=0x09868BB4  token=0x6000037  System.Boolean MoveNext()
  RVA=0x09868CF0  token=0x6000039  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09868C5C  token=0x600003B  System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator()
  RVA=0x09868CE8  token=0x600003C  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <GetAttributes>d__116
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.IDisposable System.Collections.IEnumerator
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Xml.Linq.XAttribute      <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            System.Xml.Linq.XElement        <>4__this  // 0x28
  private           System.Xml.Linq.XName           name  // 0x30
  public            System.Xml.Linq.XName           <>3__name  // 0x38
  private           System.Xml.Linq.XAttribute      <a>5__2  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000075  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000076  System.Void System.IDisposable.Dispose()
  RVA=0x098689FC  token=0x6000077  System.Boolean MoveNext()
  RVA=0x09868B68  token=0x6000079  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09868ABC  token=0x600007B  System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator()
  RVA=0x09868B60  token=0x600007C  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ExtractKeyDelegate
TYPE:  sealed class
TOKEN: 0x2000012
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000080  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000081  System.String Invoke(TValue value)
END_CLASS

CLASS: Entry
TYPE:  sealed struct
TOKEN: 0x2000014
FIELDS:
  public            TValue                          Value  // 0x0
  public            System.Int32                    HashCode  // 0x0
  public            System.Int32                    Next  // 0x0
METHODS:
END_CLASS

CLASS: XHashtableState
TYPE:  sealed class
TOKEN: 0x2000013
FIELDS:
  private           System.Int32[]                  _buckets  // 0x0
  private           System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue>[]_entries  // 0x0
  private           System.Int32                    _numEntries  // 0x0
  private           System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue>_extractKey  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000082  System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity)
  RVA=-1  // not resolved  token=0x6000083  System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize()
  RVA=-1  // not resolved  token=0x6000084  System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value)
  RVA=-1  // not resolved  token=0x6000085  System.Boolean TryAdd(TValue value, TValue& newValue)
  RVA=-1  // not resolved  token=0x6000086  System.Boolean FindEntry(System.Int32 hashCode, System.String key, System.Int32 index, System.Int32 count, System.Int32& entryIndex)
  RVA=-1  // not resolved  token=0x6000087  System.Int32 ComputeHashCode(System.String key, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: NamespaceDeclaration
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x30
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.Xml.Linq.XNamespace      ns  // 0x18
  public            System.Int32                    scope  // 0x20
  public            System.Xml.Linq.NamespaceResolver.NamespaceDeclarationprev  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000096  System.Void .ctor()
END_CLASS

CLASS: System.Text.StringBuilderCache
TYPE:  static class
TOKEN: 0x2000025
SIZE:  0x10
FIELDS:
  private   static  System.Text.StringBuilder       t_cachedInstance  // static @ 0xffffffff
METHODS:
  RVA=0x0986881C  token=0x60000E1  System.Text.StringBuilder Acquire(System.Int32 capacity)
  RVA=0x09868938  token=0x60000E2  System.Void Release(System.Text.StringBuilder sb)
  RVA=0x098688F4  token=0x60000E3  System.String GetStringAndRelease(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Linq.BaseUriAnnotation
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
FIELDS:
  private           System.String                   baseUri  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000003  System.Void .ctor(System.String baseUri)
END_CLASS

CLASS: System.Xml.Linq.LineInfoAnnotation
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x18
FIELDS:
  private           System.Int32                    lineNumber  // 0x10
  private           System.Int32                    linePosition  // 0x14
METHODS:
  RVA=0x03D50CB0  token=0x6000004  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Linq.LineInfoEndElementAnnotation
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x18
EXTENDS: System.Xml.Linq.LineInfoAnnotation
FIELDS:
METHODS:
  RVA=0x03D50CB0  token=0x6000005  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Linq.XAttribute
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x38
EXTENDS: System.Xml.Linq.XObject
FIELDS:
  private           System.Xml.Linq.XAttribute      next  // 0x20
  private           System.Xml.Linq.XName           name  // 0x28
  private           System.String                   value  // 0x30
PROPERTIES:
  IsNamespaceDeclaration  get=0x0986963C
  Name  get=0x03D4EAC0
  NodeType  get=0x02102C70
  Value  get=0x01003830
METHODS:
  RVA=0x098694A4  token=0x6000006  System.Void .ctor(System.Xml.Linq.XName name, System.Object value)
  RVA=0x098695B0  token=0x6000007  System.Void .ctor(System.Xml.Linq.XAttribute other)
  RVA=0x09868E50  token=0x600000C  System.String ToString()
  RVA=0x09868D3C  token=0x600000D  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns)
  RVA=0x098690E0  token=0x600000E  System.Void ValidateAttribute(System.Xml.Linq.XName name, System.String value)
END_CLASS

CLASS: System.Xml.Linq.XCData
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x30
EXTENDS: System.Xml.Linq.XText
FIELDS:
PROPERTIES:
  NodeType  get=0x03D50CD0
METHODS:
  RVA=0x09869798  token=0x600000F  System.Void .ctor(System.String value)
  RVA=0x098697A0  token=0x6000010  System.Void .ctor(System.Xml.Linq.XCData other)
  RVA=0x09869720  token=0x6000012  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x098696C0  token=0x6000013  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XComment
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x30
EXTENDS: System.Xml.Linq.XNode
FIELDS:
  private           System.String                   value  // 0x28
PROPERTIES:
  NodeType  get=0x03D55800
  Value  get=0x03D4EAC0
METHODS:
  RVA=0x098698F8  token=0x6000014  System.Void .ctor(System.String value)
  RVA=0x09869880  token=0x6000015  System.Void .ctor(System.Xml.Linq.XComment other)
  RVA=0x09869808  token=0x6000018  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x098697A8  token=0x6000019  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XContainer
TYPE:  abstract class
TOKEN: 0x2000009
SIZE:  0x30
EXTENDS: System.Xml.Linq.XNode
FIELDS:
  private           System.Object                   content  // 0x28
PROPERTIES:
  LastNode  get=0x0986AFD8
METHODS:
  RVA=0x0350B670  token=0x600001A  System.Void .ctor()
  RVA=0x0986AED4  token=0x600001B  System.Void .ctor(System.Xml.Linq.XContainer other)
  RVA=0x0986A05C  token=0x600001D  System.Void Add(System.Object content)
  RVA=0x0986A9C4  token=0x600001E  System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes()
  RVA=0x0350B670  token=0x600001F  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  RVA=0x0350B670  token=0x6000020  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  RVA=0x0986996C  token=0x6000021  System.Void AddContentSkipNotify(System.Object content)
  RVA=0x09869CAC  token=0x6000022  System.Void AddNode(System.Xml.Linq.XNode n)
  RVA=0x09869C34  token=0x6000023  System.Void AddNodeSkipNotify(System.Xml.Linq.XNode n)
  RVA=0x09869E54  token=0x6000024  System.Void AddString(System.String s)
  RVA=0x09869D24  token=0x6000025  System.Void AddStringSkipNotify(System.String s)
  RVA=0x0986A420  token=0x6000026  System.Void AppendNode(System.Xml.Linq.XNode n)
  RVA=0x0986A364  token=0x6000027  System.Void AppendNodeSkipNotify(System.Xml.Linq.XNode n)
  RVA=0x0986A534  token=0x6000028  System.Void AppendText(System.Text.StringBuilder sb)
  RVA=0x0986A5E8  token=0x6000029  System.Void ConvertTextToNode()
  RVA=0x0986A69C  token=0x600002A  System.String GetStringValue(System.Object value)
  RVA=0x0986AA34  token=0x600002B  System.Void ReadContentFrom(System.Xml.XmlReader r)
  RVA=0x0986AB30  token=0x600002C  System.Void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  RVA=0x0986AC64  token=0x600002D  System.Void RemoveNode(System.Xml.Linq.XNode n)
  RVA=0x0350B670  token=0x600002E  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
  RVA=0x0350B670  token=0x600002F  System.Void ValidateString(System.String s)
  RVA=0x0986ADF0  token=0x6000030  System.Void WriteContentTo(System.Xml.XmlWriter writer)
END_CLASS

CLASS: System.Xml.Linq.XDeclaration
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x28
FIELDS:
  private           System.String                   _version  // 0x10
  private           System.String                   _encoding  // 0x18
  private           System.String                   _standalone  // 0x20
PROPERTIES:
  Encoding  get=0x01041090
  Standalone  get=0x03D4EB40
  Version  get=0x020B7B20
METHODS:
  RVA=0x0285BDC0  token=0x600003D  System.Void .ctor(System.String version, System.String encoding, System.String standalone)
  RVA=0x0986B228  token=0x600003E  System.Void .ctor(System.Xml.Linq.XDeclaration other)
  RVA=0x0986B0D4  token=0x6000042  System.String ToString()
END_CLASS

CLASS: System.Xml.Linq.XDocument
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x38
EXTENDS: System.Xml.Linq.XContainer
FIELDS:
  private           System.Xml.Linq.XDeclaration    _declaration  // 0x30
PROPERTIES:
  Declaration  get=0x01003830  set=0x04270470
  NodeType  get=0x03D55810
  Root  get=0x0986BBA0
METHODS:
  RVA=0x0350B670  token=0x6000043  System.Void .ctor()
  RVA=0x0986BB0C  token=0x6000044  System.Void .ctor(System.Xml.Linq.XDocument other)
  RVA=0x0986B9E8  token=0x6000049  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x0986B560  token=0x600004A  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  RVA=0x0986B504  token=0x600004B  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  RVA=0x0986B5BC  token=0x600004C  System.Xml.Linq.XNode CloneNode()
  RVA=-1  // generic def  token=0x600004D  T GetFirstNode()
  RVA=0x0986B61C  token=0x600004E  System.Boolean IsWhitespace(System.String s)
  RVA=0x0986B778  token=0x600004F  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
  RVA=0x0986B674  token=0x6000050  System.Void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter)
  RVA=0x0986B978  token=0x6000051  System.Void ValidateString(System.String s)
END_CLASS

CLASS: System.Xml.Linq.XDocumentType
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x48
EXTENDS: System.Xml.Linq.XNode
FIELDS:
  private           System.String                   _name  // 0x28
  private           System.String                   _publicId  // 0x30
  private           System.String                   _systemId  // 0x38
  private           System.String                   _internalSubset  // 0x40
PROPERTIES:
  InternalSubset  get=0x03D4E2B0
  Name  get=0x03D4EAC0
  NodeType  get=0x03D55730
  PublicId  get=0x01003830
  SystemId  get=0x03D4E2A0
METHODS:
  RVA=0x0986B464  token=0x6000052  System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  RVA=0x0986B3B4  token=0x6000053  System.Void .ctor(System.Xml.Linq.XDocumentType other)
  RVA=0x0986B328  token=0x6000059  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x0986B2C8  token=0x600005A  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XElement
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x40
EXTENDS: System.Xml.Linq.XContainer
IMPLEMENTS: System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Xml.Linq.XName           name  // 0x30
  private           System.Xml.Linq.XAttribute      lastAttr  // 0x38
PROPERTIES:
  HasAttributes  get=0x060DAC58
  IsEmpty  get=0x0986CCA4
  Name  get=0x01003830
  NodeType  get=0x01168950
  Value  get=0x0986CCB0
METHODS:
  RVA=0x0986CC30  token=0x600005B  System.Void .ctor(System.Xml.Linq.XName name)
  RVA=0x0986CAE4  token=0x600005C  System.Void .ctor(System.Xml.Linq.XElement other)
  RVA=0x0986CBA4  token=0x600005D  System.Void .ctor(System.Xml.Linq.XStreamingElement other)
  RVA=0x0986BF38  token=0x6000063  System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name)
  RVA=0x0986BF6C  token=0x6000064  System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes()
  RVA=0x0986C120  token=0x6000065  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns)
  RVA=0x0986CA3C  token=0x6000066  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x01002730  token=0x6000067  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x0986C6D4  token=0x6000068  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x0986C8A8  token=0x6000069  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x0986BCC8  token=0x600006A  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  RVA=0x0986BBDC  token=0x600006B  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  RVA=0x0986BE24  token=0x600006C  System.Void AppendAttribute(System.Xml.Linq.XAttribute a)
  RVA=0x0986BDB4  token=0x600006D  System.Void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  RVA=0x0986BF78  token=0x600006E  System.Xml.Linq.XNode CloneNode()
  RVA=0x0986BFD8  token=0x600006F  System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name)
  RVA=0x0986C060  token=0x6000070  System.String GetNamespaceOfPrefixInScope(System.String prefix, System.Xml.Linq.XElement outOfScope)
  RVA=0x0986C5EC  token=0x6000071  System.Void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  RVA=0x0986C328  token=0x6000072  System.Void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  RVA=0x0986C664  token=0x6000073  System.Void SetEndElementLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  RVA=0x0986C8BC  token=0x6000074  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
END_CLASS

CLASS: System.Xml.Linq.XHashtable`1
TYPE:  sealed class
TOKEN: 0x2000011
FIELDS:
  private           System.Xml.Linq.XHashtable.XHashtableState<TValue>_state  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600007D  System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600007E  System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value)
  RVA=-1  // not resolved  token=0x600007F  TValue Add(TValue value)
END_CLASS

CLASS: System.Xml.Linq.NamespaceCache
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x20
FIELDS:
  private           System.Xml.Linq.XNamespace      _ns  // 0x10
  private           System.String                   _namespaceName  // 0x18
METHODS:
  RVA=0x09868400  token=0x6000088  System.Xml.Linq.XNamespace Get(System.String namespaceName)
END_CLASS

CLASS: System.Xml.Linq.ElementWriter
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x30
FIELDS:
  private           System.Xml.XmlWriter            _writer  // 0x10
  private           System.Xml.Linq.NamespaceResolver_resolver  // 0x18
METHODS:
  RVA=0x098683DC  token=0x6000089  System.Void .ctor(System.Xml.XmlWriter writer)
  RVA=0x0986807C  token=0x600008A  System.Void WriteElement(System.Xml.Linq.XElement e)
  RVA=0x09867D9C  token=0x600008B  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace)
  RVA=0x09867E90  token=0x600008C  System.Void PushAncestors(System.Xml.Linq.XElement e)
  RVA=0x09867F98  token=0x600008D  System.Void PushElement(System.Xml.Linq.XElement e)
  RVA=0x098681E4  token=0x600008E  System.Void WriteEndElement()
  RVA=0x09868218  token=0x600008F  System.Void WriteFullEndElement()
  RVA=0x0986824C  token=0x6000090  System.Void WriteStartElement(System.Xml.Linq.XElement e)
END_CLASS

CLASS: System.Xml.Linq.NamespaceResolver
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x28
FIELDS:
  private           System.Int32                    _scope  // 0x10
  private           System.Xml.Linq.NamespaceResolver.NamespaceDeclaration_declaration  // 0x18
  private           System.Xml.Linq.NamespaceResolver.NamespaceDeclaration_rover  // 0x20
METHODS:
  RVA=0x03D75730  token=0x6000091  System.Void PushScope()
  RVA=0x098686DC  token=0x6000092  System.Void PopScope()
  RVA=0x0986851C  token=0x6000093  System.Void Add(System.String prefix, System.Xml.Linq.XNamespace ns)
  RVA=0x09868444  token=0x6000094  System.Void AddFirst(System.String prefix, System.Xml.Linq.XNamespace ns)
  RVA=0x098685E4  token=0x6000095  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace)
END_CLASS

CLASS: System.Xml.Linq.XObjectChange
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.XObjectChange   Add  // const
  public    static  System.Xml.Linq.XObjectChange   Remove  // const
  public    static  System.Xml.Linq.XObjectChange   Name  // const
  public    static  System.Xml.Linq.XObjectChange   Value  // const
METHODS:
END_CLASS

CLASS: System.Xml.Linq.LoadOptions
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.LoadOptions     None  // const
  public    static  System.Xml.Linq.LoadOptions     PreserveWhitespace  // const
  public    static  System.Xml.Linq.LoadOptions     SetBaseUri  // const
  public    static  System.Xml.Linq.LoadOptions     SetLineInfo  // const
METHODS:
END_CLASS

CLASS: System.Xml.Linq.SaveOptions
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.SaveOptions     None  // const
  public    static  System.Xml.Linq.SaveOptions     DisableFormatting  // const
  public    static  System.Xml.Linq.SaveOptions     OmitDuplicateNamespaces  // const
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XName
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.Runtime.Serialization.ISerializable
FIELDS:
  private           System.Xml.Linq.XNamespace      _ns  // 0x10
  private           System.String                   _localName  // 0x18
  private           System.Int32                    _hashCode  // 0x20
PROPERTIES:
  LocalName  get=0x01041090
  Namespace  get=0x020B7B20
  NamespaceName  get=0x04270688
METHODS:
  RVA=0x0986D000  token=0x6000097  System.Void .ctor(System.Xml.Linq.XNamespace ns, System.String localName)
  RVA=0x0986CF84  token=0x600009B  System.String ToString()
  RVA=0x0986CD38  token=0x600009C  System.Xml.Linq.XName Get(System.String expandedName)
  RVA=0x0986CF04  token=0x600009D  System.Xml.Linq.XName Get(System.String localName, System.String namespaceName)
  RVA=0x0986D0D8  token=0x600009E  System.Xml.Linq.XName op_Implicit(System.String expandedName)
  RVA=0x0232CE30  token=0x600009F  System.Boolean Equals(System.Object obj)
  RVA=0x01003B50  token=0x60000A0  System.Int32 GetHashCode()
  RVA=0x0232CE30  token=0x60000A1  System.Boolean op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right)
  RVA=0x0232CE30  token=0x60000A2  System.Boolean System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other)
  RVA=0x0986CF38  token=0x60000A3  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0986D0A8  token=0x60000A4  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Linq.XNamespace
TYPE:  sealed class
TOKEN: 0x200001D
SIZE:  0x28
FIELDS:
  private   static  System.Xml.Linq.XHashtable<System.WeakReference>s_namespaces  // static @ 0x0
  private   static  System.WeakReference            s_refNone  // static @ 0x8
  private   static  System.WeakReference            s_refXml  // static @ 0x10
  private   static  System.WeakReference            s_refXmlns  // static @ 0x18
  private           System.String                   _namespaceName  // 0x10
  private           System.Int32                    _hashCode  // 0x18
  private           System.Xml.Linq.XHashtable<System.Xml.Linq.XName>_names  // 0x20
PROPERTIES:
  NamespaceName  get=0x020B7B20
  None  get=0x0986D82C
  Xml  get=0x0986D888
  Xmlns  get=0x0986D8DC
METHODS:
  RVA=0x0986D738  token=0x60000A5  System.Void .ctor(System.String namespaceName)
  RVA=0x0986D34C  token=0x60000A7  System.Xml.Linq.XName GetName(System.String localName)
  RVA=0x020B7B20  token=0x60000A8  System.String ToString()
  RVA=0x0986D6C4  token=0x60000AC  System.Xml.Linq.XNamespace Get(System.String namespaceName)
  RVA=0x0986D930  token=0x60000AD  System.Xml.Linq.XNamespace op_Implicit(System.String namespaceName)
  RVA=0x0232CE30  token=0x60000AE  System.Boolean Equals(System.Object obj)
  RVA=0x020D1AC0  token=0x60000AF  System.Int32 GetHashCode()
  RVA=0x0232CE30  token=0x60000B0  System.Boolean op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right)
  RVA=0x022E54C0  token=0x60000B1  System.Boolean op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right)
  RVA=0x0986D244  token=0x60000B2  System.Xml.Linq.XName GetName(System.String localName, System.Int32 index, System.Int32 count)
  RVA=0x0986D3C4  token=0x60000B3  System.Xml.Linq.XNamespace Get(System.String namespaceName, System.Int32 index, System.Int32 count)
  RVA=0x042C4004  token=0x60000B4  System.String ExtractLocalName(System.Xml.Linq.XName n)
  RVA=0x0986D1E8  token=0x60000B5  System.String ExtractNamespace(System.WeakReference r)
  RVA=0x0986D0F4  token=0x60000B6  System.Xml.Linq.XNamespace EnsureNamespace(System.WeakReference& refNmsp, System.String namespaceName)
END_CLASS

CLASS: System.Xml.Linq.XNode
TYPE:  abstract class
TOKEN: 0x200001E
SIZE:  0x28
EXTENDS: System.Xml.Linq.XObject
FIELDS:
  private           System.Xml.Linq.XNode           next  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60000B7  System.Void .ctor()
  RVA=0x0986DBEC  token=0x60000B8  System.Void Remove()
  RVA=0x0986DC64  token=0x60000B9  System.String ToString()
  RVA=-1  // abstract  token=0x60000BA  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x0350B670  token=0x60000BB  System.Void AppendText(System.Text.StringBuilder sb)
  RVA=-1  // abstract  token=0x60000BC  System.Xml.Linq.XNode CloneNode()
  RVA=0x0986D94C  token=0x60000BD  System.String GetXmlString(System.Xml.Linq.SaveOptions o)
END_CLASS

CLASS: System.Xml.Linq.XObject
TYPE:  abstract class
TOKEN: 0x200001F
SIZE:  0x20
IMPLEMENTS: System.Xml.IXmlLineInfo
FIELDS:
  private           System.Xml.Linq.XContainer      parent  // 0x10
  private           System.Object                   annotations  // 0x18
PROPERTIES:
  BaseUri  get=0x0986E50C
  NodeType  get=-1  // abstract
  Parent  get=0x0986E5C0
  System.Xml.IXmlLineInfo.LineNumber  get=0x0986E484
  System.Xml.IXmlLineInfo.LinePosition  get=0x0986E4C8
  HasBaseUri  get=0x0986E580
METHODS:
  RVA=0x0350B670  token=0x60000BE  System.Void .ctor()
  RVA=0x0986DE3C  token=0x60000C2  System.Void AddAnnotation(System.Object annotation)
  RVA=0x0986E02C  token=0x60000C3  System.Object AnnotationForSealedType(System.Type type)
  RVA=-1  // generic def  token=0x60000C4  T Annotation()
  RVA=0x0986E444  token=0x60000C5  System.Boolean System.Xml.IXmlLineInfo.HasLineInfo()
  RVA=0x0986E1CC  token=0x60000C9  System.Boolean NotifyChanged(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e)
  RVA=0x0986E268  token=0x60000CA  System.Boolean NotifyChanging(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e)
  RVA=0x0986E304  token=0x60000CB  System.Void SetBaseUri(System.String baseUri)
  RVA=0x0986E37C  token=0x60000CC  System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  RVA=0x0986E3EC  token=0x60000CD  System.Boolean SkipNotify()
  RVA=0x0986E128  token=0x60000CE  System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations()
END_CLASS

CLASS: System.Xml.Linq.XObjectChangeAnnotation
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x20
FIELDS:
  private           System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs>changing  // 0x10
  private           System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs>changed  // 0x18
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XObjectChangeEventArgs
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x18
EXTENDS: System.EventArgs
FIELDS:
  private           System.Xml.Linq.XObjectChange   _objectChange  // 0x10
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsAdd  // static @ 0x0
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsRemove  // static @ 0x8
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsName  // static @ 0x10
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsValue  // static @ 0x18
METHODS:
  RVA=0x0986DDEC  token=0x60000CF  System.Void .ctor(System.Xml.Linq.XObjectChange objectChange)
  RVA=0x0986DC88  token=0x60000D0  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Linq.XProcessingInstruction
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x38
EXTENDS: System.Xml.Linq.XNode
FIELDS:
  private           System.String                   target  // 0x28
  private           System.String                   data  // 0x30
PROPERTIES:
  Data  get=0x01003830
  NodeType  get=0x03D55AA0
  Target  get=0x03D4EAC0
METHODS:
  RVA=0x0986E7B0  token=0x60000D1  System.Void .ctor(System.String target, System.String data)
  RVA=0x0986E854  token=0x60000D2  System.Void .ctor(System.Xml.Linq.XProcessingInstruction other)
  RVA=0x0986E734  token=0x60000D6  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x0986E5FC  token=0x60000D7  System.Xml.Linq.XNode CloneNode()
  RVA=0x0986E65C  token=0x60000D8  System.Void ValidateName(System.String name)
END_CLASS

CLASS: System.Xml.Linq.XStreamingElement
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x20
FIELDS:
  private           System.Xml.Linq.XName           name  // 0x10
  private           System.Object                   content  // 0x18
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XText
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x30
EXTENDS: System.Xml.Linq.XNode
FIELDS:
  private           System.String                   text  // 0x28
PROPERTIES:
  NodeType  get=0x03D555E0
  Value  get=0x03D4EAC0  set=0x0986EB10
METHODS:
  RVA=0x0986EA24  token=0x60000D9  System.Void .ctor(System.String value)
  RVA=0x0986EA98  token=0x60000DA  System.Void .ctor(System.Xml.Linq.XText other)
  RVA=0x0986E968  token=0x60000DE  System.Void WriteTo(System.Xml.XmlWriter writer)
  RVA=0x0986E8E0  token=0x60000DF  System.Void AppendText(System.Text.StringBuilder sb)
  RVA=0x0986E908  token=0x60000E0  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: Unity.ThrowStub
TYPE:  sealed class
TOKEN: 0x2000026
SIZE:  0x98
EXTENDS: System.ObjectDisposedException
FIELDS:
METHODS:
  RVA=0x098689B0  token=0x60000E4  System.Void ThrowNotSupportedException()
END_CLASS

