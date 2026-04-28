// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.Linq.dll
// Classes:  38
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x10
    public static class SR
    {
        // Methods
        // RVA: 0x098687C0  token: 0x6000001
        private static System.String Format(System.String resourceFormat, System.Object p1) { }
        // RVA: 0x09868750  token: 0x6000002
        private static System.String Format(System.String resourceFormat, System.Object p1, System.Object p2) { }

    }

    // TypeToken: 0x200000A  // size: 0x48
    public sealed class ContentReader
    {
        // Fields
        private readonly System.Xml.Linq.NamespaceCache _eCache;  // 0x10
        private readonly System.Xml.Linq.NamespaceCache _aCache;  // 0x20
        private readonly System.Xml.IXmlLineInfo _lineInfo;  // 0x30
        private System.Xml.Linq.XContainer _currentContainer;  // 0x38
        private System.String _baseUri;  // 0x40

        // Methods
        // RVA: 0x0388FF30  token: 0x6000031
        public System.Void .ctor(System.Xml.Linq.XContainer rootContainer) { }
        // RVA: 0x09867CDC  token: 0x6000032
        public System.Void .ctor(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        // RVA: 0x098676CC  token: 0x6000033
        public System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r) { }
        // RVA: 0x09866E68  token: 0x6000034
        public System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }

    }

    // TypeToken: 0x200000B  // size: 0x38
    public sealed class <Nodes>d__18 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.IDisposable, System.Collections.IEnumerator
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Xml.Linq.XNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public System.Xml.Linq.XContainer <>4__this;  // 0x28
        private System.Xml.Linq.XNode <n>5__2;  // 0x30

        // Properties
        System.Xml.Linq.XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000035
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000036
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09868BB4  token: 0x6000037
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09868CF0  token: 0x6000039
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09868C5C  token: 0x600003B
        private virtual System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }
        // RVA: 0x09868CE8  token: 0x600003C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000010  // size: 0x48
    public sealed class <GetAttributes>d__116 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.IDisposable, System.Collections.IEnumerator
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Xml.Linq.XAttribute <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public System.Xml.Linq.XElement <>4__this;  // 0x28
        private System.Xml.Linq.XName name;  // 0x30
        public System.Xml.Linq.XName <>3__name;  // 0x38
        private System.Xml.Linq.XAttribute <a>5__2;  // 0x40

        // Properties
        System.Xml.Linq.XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000075
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000076
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x098689FC  token: 0x6000077
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09868B68  token: 0x6000079
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09868ABC  token: 0x600007B
        private virtual System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }
        // RVA: 0x09868B60  token: 0x600007C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000012
    public sealed class ExtractKeyDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000080
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000081
        public virtual System.String Invoke(TValue value) { }

    }

    // TypeToken: 0x2000014
    public sealed struct Entry
    {
        // Fields
        public TValue Value;  // 0x0
        public System.Int32 HashCode;  // 0x0
        public System.Int32 Next;  // 0x0

    }

    // TypeToken: 0x2000013
    public sealed class XHashtableState
    {
        // Fields
        private System.Int32[] _buckets;  // 0x0
        private System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue>[] _entries;  // 0x0
        private System.Int32 _numEntries;  // 0x0
        private System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000082
        public System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x6000083
        public System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize() { }
        // RVA: -1  // not resolved  token: 0x6000084
        public System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x6000085
        public System.Boolean TryAdd(TValue value, TValue& newValue) { }
        // RVA: -1  // not resolved  token: 0x6000086
        private System.Boolean FindEntry(System.Int32 hashCode, System.String key, System.Int32 index, System.Int32 count, System.Int32& entryIndex) { }
        // RVA: -1  // not resolved  token: 0x6000087
        private static System.Int32 ComputeHashCode(System.String key, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x2000018  // size: 0x30
    public class NamespaceDeclaration
    {
        // Fields
        public System.String prefix;  // 0x10
        public System.Xml.Linq.XNamespace ns;  // 0x18
        public System.Int32 scope;  // 0x20
        public System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000096
        public System.Void .ctor() { }

    }

namespace System.Text
{

    // TypeToken: 0x2000025  // size: 0x10
    public static class StringBuilderCache
    {
        // Fields
        private static System.Text.StringBuilder t_cachedInstance;  // static @ 0xffffffff

        // Methods
        // RVA: 0x0986881C  token: 0x60000E1
        public static System.Text.StringBuilder Acquire(System.Int32 capacity) { }
        // RVA: 0x09868938  token: 0x60000E2
        public static System.Void Release(System.Text.StringBuilder sb) { }
        // RVA: 0x098688F4  token: 0x60000E3
        public static System.String GetStringAndRelease(System.Text.StringBuilder sb) { }

    }

}

namespace System.Xml.Linq
{

    // TypeToken: 0x2000003  // size: 0x18
    public class BaseUriAnnotation
    {
        // Fields
        private System.String baseUri;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000003
        public System.Void .ctor(System.String baseUri) { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public class LineInfoAnnotation
    {
        // Fields
        private System.Int32 lineNumber;  // 0x10
        private System.Int32 linePosition;  // 0x14

        // Methods
        // RVA: 0x03D50CB0  token: 0x6000004
        public System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public class LineInfoEndElementAnnotation : System.Xml.Linq.LineInfoAnnotation
    {
        // Methods
        // RVA: 0x03D50CB0  token: 0x6000005
        public System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x2000006  // size: 0x38
    public class XAttribute : System.Xml.Linq.XObject
    {
        // Fields
        private System.Xml.Linq.XAttribute next;  // 0x20
        private System.Xml.Linq.XName name;  // 0x28
        private System.String value;  // 0x30

        // Properties
        System.Boolean IsNamespaceDeclaration { get; /* RVA: 0x0986963C */ }
        System.Xml.Linq.XName Name { get; /* RVA: 0x03D4EAC0 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x02102C70 */ }
        System.String Value { get; /* RVA: 0x01003830 */ }

        // Methods
        // RVA: 0x098694A4  token: 0x6000006
        public System.Void .ctor(System.Xml.Linq.XName name, System.Object value) { }
        // RVA: 0x098695B0  token: 0x6000007
        public System.Void .ctor(System.Xml.Linq.XAttribute other) { }
        // RVA: 0x09868E50  token: 0x600000C
        public virtual System.String ToString() { }
        // RVA: 0x09868D3C  token: 0x600000D
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns) { }
        // RVA: 0x098690E0  token: 0x600000E
        private static System.Void ValidateAttribute(System.Xml.Linq.XName name, System.String value) { }

    }

    // TypeToken: 0x2000007  // size: 0x30
    public class XCData : System.Xml.Linq.XText
    {
        // Properties
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D50CD0 */ }

        // Methods
        // RVA: 0x09869798  token: 0x600000F
        public System.Void .ctor(System.String value) { }
        // RVA: 0x098697A0  token: 0x6000010
        public System.Void .ctor(System.Xml.Linq.XCData other) { }
        // RVA: 0x09869720  token: 0x6000012
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x098696C0  token: 0x6000013
        private virtual System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x2000008  // size: 0x30
    public class XComment : System.Xml.Linq.XNode
    {
        // Fields
        private System.String value;  // 0x28

        // Properties
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D55800 */ }
        System.String Value { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x098698F8  token: 0x6000014
        public System.Void .ctor(System.String value) { }
        // RVA: 0x09869880  token: 0x6000015
        public System.Void .ctor(System.Xml.Linq.XComment other) { }
        // RVA: 0x09869808  token: 0x6000018
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x098697A8  token: 0x6000019
        private virtual System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x2000009  // size: 0x30
    public abstract class XContainer : System.Xml.Linq.XNode
    {
        // Fields
        private System.Object content;  // 0x28

        // Properties
        System.Xml.Linq.XNode LastNode { get; /* RVA: 0x0986AFD8 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600001A
        private System.Void .ctor() { }
        // RVA: 0x0986AED4  token: 0x600001B
        private System.Void .ctor(System.Xml.Linq.XContainer other) { }
        // RVA: 0x0986A05C  token: 0x600001D
        public System.Void Add(System.Object content) { }
        // RVA: 0x0986A9C4  token: 0x600001E
        public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }
        // RVA: 0x0350B670  token: 0x600001F
        private virtual System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0350B670  token: 0x6000020
        private virtual System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986996C  token: 0x6000021
        private System.Void AddContentSkipNotify(System.Object content) { }
        // RVA: 0x09869CAC  token: 0x6000022
        private System.Void AddNode(System.Xml.Linq.XNode n) { }
        // RVA: 0x09869C34  token: 0x6000023
        private System.Void AddNodeSkipNotify(System.Xml.Linq.XNode n) { }
        // RVA: 0x09869E54  token: 0x6000024
        private System.Void AddString(System.String s) { }
        // RVA: 0x09869D24  token: 0x6000025
        private System.Void AddStringSkipNotify(System.String s) { }
        // RVA: 0x0986A420  token: 0x6000026
        private System.Void AppendNode(System.Xml.Linq.XNode n) { }
        // RVA: 0x0986A364  token: 0x6000027
        private System.Void AppendNodeSkipNotify(System.Xml.Linq.XNode n) { }
        // RVA: 0x0986A534  token: 0x6000028
        private virtual System.Void AppendText(System.Text.StringBuilder sb) { }
        // RVA: 0x0986A5E8  token: 0x6000029
        private System.Void ConvertTextToNode() { }
        // RVA: 0x0986A69C  token: 0x600002A
        private static System.String GetStringValue(System.Object value) { }
        // RVA: 0x0986AA34  token: 0x600002B
        private System.Void ReadContentFrom(System.Xml.XmlReader r) { }
        // RVA: 0x0986AB30  token: 0x600002C
        private System.Void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        // RVA: 0x0986AC64  token: 0x600002D
        private System.Void RemoveNode(System.Xml.Linq.XNode n) { }
        // RVA: 0x0350B670  token: 0x600002E
        private virtual System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }
        // RVA: 0x0350B670  token: 0x600002F
        private virtual System.Void ValidateString(System.String s) { }
        // RVA: 0x0986ADF0  token: 0x6000030
        private System.Void WriteContentTo(System.Xml.XmlWriter writer) { }

    }

    // TypeToken: 0x200000C  // size: 0x28
    public class XDeclaration
    {
        // Fields
        private System.String _version;  // 0x10
        private System.String _encoding;  // 0x18
        private System.String _standalone;  // 0x20

        // Properties
        System.String Encoding { get; /* RVA: 0x01041090 */ }
        System.String Standalone { get; /* RVA: 0x03D4EB40 */ }
        System.String Version { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x0285BDC0  token: 0x600003D
        public System.Void .ctor(System.String version, System.String encoding, System.String standalone) { }
        // RVA: 0x0986B228  token: 0x600003E
        public System.Void .ctor(System.Xml.Linq.XDeclaration other) { }
        // RVA: 0x0986B0D4  token: 0x6000042
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000D  // size: 0x38
    public class XDocument : System.Xml.Linq.XContainer
    {
        // Fields
        private System.Xml.Linq.XDeclaration _declaration;  // 0x30

        // Properties
        System.Xml.Linq.XDeclaration Declaration { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D55810 */ }
        System.Xml.Linq.XElement Root { get; /* RVA: 0x0986BBA0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000043
        public System.Void .ctor() { }
        // RVA: 0x0986BB0C  token: 0x6000044
        public System.Void .ctor(System.Xml.Linq.XDocument other) { }
        // RVA: 0x0986B9E8  token: 0x6000049
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986B560  token: 0x600004A
        private virtual System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986B504  token: 0x600004B
        private virtual System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986B5BC  token: 0x600004C
        private virtual System.Xml.Linq.XNode CloneNode() { }
        // RVA: -1  // generic def  token: 0x600004D
        private T GetFirstNode() { }
        // RVA: 0x0986B61C  token: 0x600004E
        private static System.Boolean IsWhitespace(System.String s) { }
        // RVA: 0x0986B778  token: 0x600004F
        private virtual System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }
        // RVA: 0x0986B674  token: 0x6000050
        private System.Void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter) { }
        // RVA: 0x0986B978  token: 0x6000051
        private virtual System.Void ValidateString(System.String s) { }

    }

    // TypeToken: 0x200000E  // size: 0x48
    public class XDocumentType : System.Xml.Linq.XNode
    {
        // Fields
        private System.String _name;  // 0x28
        private System.String _publicId;  // 0x30
        private System.String _systemId;  // 0x38
        private System.String _internalSubset;  // 0x40

        // Properties
        System.String InternalSubset { get; /* RVA: 0x03D4E2B0 */ }
        System.String Name { get; /* RVA: 0x03D4EAC0 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D55730 */ }
        System.String PublicId { get; /* RVA: 0x01003830 */ }
        System.String SystemId { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x0986B464  token: 0x6000052
        public System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        // RVA: 0x0986B3B4  token: 0x6000053
        public System.Void .ctor(System.Xml.Linq.XDocumentType other) { }
        // RVA: 0x0986B328  token: 0x6000059
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986B2C8  token: 0x600005A
        private virtual System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x200000F  // size: 0x40
    public class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable
    {
        // Fields
        private System.Xml.Linq.XName name;  // 0x30
        private System.Xml.Linq.XAttribute lastAttr;  // 0x38

        // Properties
        System.Boolean HasAttributes { get; /* RVA: 0x060DAC58 */ }
        System.Boolean IsEmpty { get; /* RVA: 0x0986CCA4 */ }
        System.Xml.Linq.XName Name { get; /* RVA: 0x01003830 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x01168950 */ }
        System.String Value { get; /* RVA: 0x0986CCB0 */ }

        // Methods
        // RVA: 0x0986CC30  token: 0x600005B
        public System.Void .ctor(System.Xml.Linq.XName name) { }
        // RVA: 0x0986CAE4  token: 0x600005C
        public System.Void .ctor(System.Xml.Linq.XElement other) { }
        // RVA: 0x0986CBA4  token: 0x600005D
        public System.Void .ctor(System.Xml.Linq.XStreamingElement other) { }
        // RVA: 0x0986BF38  token: 0x6000063
        public System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name) { }
        // RVA: 0x0986BF6C  token: 0x6000064
        public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }
        // RVA: 0x0986C120  token: 0x6000065
        public System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns) { }
        // RVA: 0x0986CA3C  token: 0x6000066
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x01002730  token: 0x6000067
        private virtual System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        // RVA: 0x0986C6D4  token: 0x6000068
        private virtual System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        // RVA: 0x0986C8A8  token: 0x6000069
        private virtual System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986BCC8  token: 0x600006A
        private virtual System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986BBDC  token: 0x600006B
        private virtual System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986BE24  token: 0x600006C
        private System.Void AppendAttribute(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986BDB4  token: 0x600006D
        private System.Void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        // RVA: 0x0986BF78  token: 0x600006E
        private virtual System.Xml.Linq.XNode CloneNode() { }
        // RVA: 0x0986BFD8  token: 0x600006F
        private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name) { }
        // RVA: 0x0986C060  token: 0x6000070
        private System.String GetNamespaceOfPrefixInScope(System.String prefix, System.Xml.Linq.XElement outOfScope) { }
        // RVA: 0x0986C5EC  token: 0x6000071
        private System.Void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        // RVA: 0x0986C328  token: 0x6000072
        private System.Void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        // RVA: 0x0986C664  token: 0x6000073
        private System.Void SetEndElementLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        // RVA: 0x0986C8BC  token: 0x6000074
        private virtual System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }

    }

    // TypeToken: 0x2000011
    public sealed class XHashtable`1
    {
        // Fields
        private System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600007D
        public System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x600007E
        public System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x600007F
        public TValue Add(TValue value) { }

    }

    // TypeToken: 0x2000015  // size: 0x20
    public sealed struct NamespaceCache
    {
        // Fields
        private System.Xml.Linq.XNamespace _ns;  // 0x10
        private System.String _namespaceName;  // 0x18

        // Methods
        // RVA: 0x09868400  token: 0x6000088
        public System.Xml.Linq.XNamespace Get(System.String namespaceName) { }

    }

    // TypeToken: 0x2000016  // size: 0x30
    public sealed struct ElementWriter
    {
        // Fields
        private System.Xml.XmlWriter _writer;  // 0x10
        private System.Xml.Linq.NamespaceResolver _resolver;  // 0x18

        // Methods
        // RVA: 0x098683DC  token: 0x6000089
        public System.Void .ctor(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986807C  token: 0x600008A
        public System.Void WriteElement(System.Xml.Linq.XElement e) { }
        // RVA: 0x09867D9C  token: 0x600008B
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace) { }
        // RVA: 0x09867E90  token: 0x600008C
        private System.Void PushAncestors(System.Xml.Linq.XElement e) { }
        // RVA: 0x09867F98  token: 0x600008D
        private System.Void PushElement(System.Xml.Linq.XElement e) { }
        // RVA: 0x098681E4  token: 0x600008E
        private System.Void WriteEndElement() { }
        // RVA: 0x09868218  token: 0x600008F
        private System.Void WriteFullEndElement() { }
        // RVA: 0x0986824C  token: 0x6000090
        private System.Void WriteStartElement(System.Xml.Linq.XElement e) { }

    }

    // TypeToken: 0x2000017  // size: 0x28
    public sealed struct NamespaceResolver
    {
        // Fields
        private System.Int32 _scope;  // 0x10
        private System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;  // 0x18
        private System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;  // 0x20

        // Methods
        // RVA: 0x03D75730  token: 0x6000091
        public System.Void PushScope() { }
        // RVA: 0x098686DC  token: 0x6000092
        public System.Void PopScope() { }
        // RVA: 0x0986851C  token: 0x6000093
        public System.Void Add(System.String prefix, System.Xml.Linq.XNamespace ns) { }
        // RVA: 0x09868444  token: 0x6000094
        public System.Void AddFirst(System.String prefix, System.Xml.Linq.XNamespace ns) { }
        // RVA: 0x098685E4  token: 0x6000095
        public System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace) { }

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct XObjectChange
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Xml.Linq.XObjectChange Add;  // const
        public static System.Xml.Linq.XObjectChange Remove;  // const
        public static System.Xml.Linq.XObjectChange Name;  // const
        public static System.Xml.Linq.XObjectChange Value;  // const

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct LoadOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Xml.Linq.LoadOptions None;  // const
        public static System.Xml.Linq.LoadOptions PreserveWhitespace;  // const
        public static System.Xml.Linq.LoadOptions SetBaseUri;  // const
        public static System.Xml.Linq.LoadOptions SetLineInfo;  // const

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct SaveOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Xml.Linq.SaveOptions None;  // const
        public static System.Xml.Linq.SaveOptions DisableFormatting;  // const
        public static System.Xml.Linq.SaveOptions OmitDuplicateNamespaces;  // const

    }

    // TypeToken: 0x200001C  // size: 0x28
    public sealed class XName : System.IEquatable`1, System.Runtime.Serialization.ISerializable
    {
        // Fields
        private System.Xml.Linq.XNamespace _ns;  // 0x10
        private System.String _localName;  // 0x18
        private System.Int32 _hashCode;  // 0x20

        // Properties
        System.String LocalName { get; /* RVA: 0x01041090 */ }
        System.Xml.Linq.XNamespace Namespace { get; /* RVA: 0x020B7B20 */ }
        System.String NamespaceName { get; /* RVA: 0x04270688 */ }

        // Methods
        // RVA: 0x0986D000  token: 0x6000097
        private System.Void .ctor(System.Xml.Linq.XNamespace ns, System.String localName) { }
        // RVA: 0x0986CF84  token: 0x600009B
        public virtual System.String ToString() { }
        // RVA: 0x0986CD38  token: 0x600009C
        public static System.Xml.Linq.XName Get(System.String expandedName) { }
        // RVA: 0x0986CF04  token: 0x600009D
        public static System.Xml.Linq.XName Get(System.String localName, System.String namespaceName) { }
        // RVA: 0x0986D0D8  token: 0x600009E
        public static System.Xml.Linq.XName op_Implicit(System.String expandedName) { }
        // RVA: 0x0232CE30  token: 0x600009F
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x01003B50  token: 0x60000A0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0232CE30  token: 0x60000A1
        public static System.Boolean op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right) { }
        // RVA: 0x0232CE30  token: 0x60000A2
        private virtual System.Boolean System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other) { }
        // RVA: 0x0986CF38  token: 0x60000A3
        private virtual System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x0986D0A8  token: 0x60000A4
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x28
    public sealed class XNamespace
    {
        // Fields
        private static System.Xml.Linq.XHashtable<System.WeakReference> s_namespaces;  // static @ 0x0
        private static System.WeakReference s_refNone;  // static @ 0x8
        private static System.WeakReference s_refXml;  // static @ 0x10
        private static System.WeakReference s_refXmlns;  // static @ 0x18
        private System.String _namespaceName;  // 0x10
        private System.Int32 _hashCode;  // 0x18
        private System.Xml.Linq.XHashtable<System.Xml.Linq.XName> _names;  // 0x20

        // Properties
        System.String NamespaceName { get; /* RVA: 0x020B7B20 */ }
        System.Xml.Linq.XNamespace None { get; /* RVA: 0x0986D82C */ }
        System.Xml.Linq.XNamespace Xml { get; /* RVA: 0x0986D888 */ }
        System.Xml.Linq.XNamespace Xmlns { get; /* RVA: 0x0986D8DC */ }

        // Methods
        // RVA: 0x0986D738  token: 0x60000A5
        private System.Void .ctor(System.String namespaceName) { }
        // RVA: 0x0986D34C  token: 0x60000A7
        public System.Xml.Linq.XName GetName(System.String localName) { }
        // RVA: 0x020B7B20  token: 0x60000A8
        public virtual System.String ToString() { }
        // RVA: 0x0986D6C4  token: 0x60000AC
        public static System.Xml.Linq.XNamespace Get(System.String namespaceName) { }
        // RVA: 0x0986D930  token: 0x60000AD
        public static System.Xml.Linq.XNamespace op_Implicit(System.String namespaceName) { }
        // RVA: 0x0232CE30  token: 0x60000AE
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x020D1AC0  token: 0x60000AF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0232CE30  token: 0x60000B0
        public static System.Boolean op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { }
        // RVA: 0x022E54C0  token: 0x60000B1
        public static System.Boolean op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { }
        // RVA: 0x0986D244  token: 0x60000B2
        private System.Xml.Linq.XName GetName(System.String localName, System.Int32 index, System.Int32 count) { }
        // RVA: 0x0986D3C4  token: 0x60000B3
        private static System.Xml.Linq.XNamespace Get(System.String namespaceName, System.Int32 index, System.Int32 count) { }
        // RVA: 0x042C4004  token: 0x60000B4
        private static System.String ExtractLocalName(System.Xml.Linq.XName n) { }
        // RVA: 0x0986D1E8  token: 0x60000B5
        private static System.String ExtractNamespace(System.WeakReference r) { }
        // RVA: 0x0986D0F4  token: 0x60000B6
        private static System.Xml.Linq.XNamespace EnsureNamespace(System.WeakReference& refNmsp, System.String namespaceName) { }

    }

    // TypeToken: 0x200001E  // size: 0x28
    public abstract class XNode : System.Xml.Linq.XObject
    {
        // Fields
        private System.Xml.Linq.XNode next;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000B7
        private System.Void .ctor() { }
        // RVA: 0x0986DBEC  token: 0x60000B8
        public System.Void Remove() { }
        // RVA: 0x0986DC64  token: 0x60000B9
        public virtual System.String ToString() { }
        // RVA: -1  // abstract  token: 0x60000BA
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x0350B670  token: 0x60000BB
        private virtual System.Void AppendText(System.Text.StringBuilder sb) { }
        // RVA: -1  // abstract  token: 0x60000BC
        private virtual System.Xml.Linq.XNode CloneNode() { }
        // RVA: 0x0986D94C  token: 0x60000BD
        private System.String GetXmlString(System.Xml.Linq.SaveOptions o) { }

    }

    // TypeToken: 0x200001F  // size: 0x20
    public abstract class XObject : System.Xml.IXmlLineInfo
    {
        // Fields
        private System.Xml.Linq.XContainer parent;  // 0x10
        private System.Object annotations;  // 0x18

        // Properties
        System.String BaseUri { get; /* RVA: 0x0986E50C */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: -1  // abstract */ }
        System.Xml.Linq.XElement Parent { get; /* RVA: 0x0986E5C0 */ }
        System.Int32 System.Xml.IXmlLineInfo.LineNumber { get; /* RVA: 0x0986E484 */ }
        System.Int32 System.Xml.IXmlLineInfo.LinePosition { get; /* RVA: 0x0986E4C8 */ }
        System.Boolean HasBaseUri { get; /* RVA: 0x0986E580 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000BE
        private System.Void .ctor() { }
        // RVA: 0x0986DE3C  token: 0x60000C2
        public System.Void AddAnnotation(System.Object annotation) { }
        // RVA: 0x0986E02C  token: 0x60000C3
        private System.Object AnnotationForSealedType(System.Type type) { }
        // RVA: -1  // generic def  token: 0x60000C4
        public T Annotation() { }
        // RVA: 0x0986E444  token: 0x60000C5
        private virtual System.Boolean System.Xml.IXmlLineInfo.HasLineInfo() { }
        // RVA: 0x0986E1CC  token: 0x60000C9
        private System.Boolean NotifyChanged(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e) { }
        // RVA: 0x0986E268  token: 0x60000CA
        private System.Boolean NotifyChanging(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e) { }
        // RVA: 0x0986E304  token: 0x60000CB
        private System.Void SetBaseUri(System.String baseUri) { }
        // RVA: 0x0986E37C  token: 0x60000CC
        private System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        // RVA: 0x0986E3EC  token: 0x60000CD
        private System.Boolean SkipNotify() { }
        // RVA: 0x0986E128  token: 0x60000CE
        private System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations() { }

    }

    // TypeToken: 0x2000020  // size: 0x20
    public class XObjectChangeAnnotation
    {
        // Fields
        private System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changing;  // 0x10
        private System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changed;  // 0x18

    }

    // TypeToken: 0x2000021  // size: 0x18
    public class XObjectChangeEventArgs : System.EventArgs
    {
        // Fields
        private System.Xml.Linq.XObjectChange _objectChange;  // 0x10
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Add;  // static @ 0x0
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Remove;  // static @ 0x8
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Name;  // static @ 0x10
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Value;  // static @ 0x18

        // Methods
        // RVA: 0x0986DDEC  token: 0x60000CF
        public System.Void .ctor(System.Xml.Linq.XObjectChange objectChange) { }
        // RVA: 0x0986DC88  token: 0x60000D0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x38
    public class XProcessingInstruction : System.Xml.Linq.XNode
    {
        // Fields
        private System.String target;  // 0x28
        private System.String data;  // 0x30

        // Properties
        System.String Data { get; /* RVA: 0x01003830 */ }
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D55AA0 */ }
        System.String Target { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x0986E7B0  token: 0x60000D1
        public System.Void .ctor(System.String target, System.String data) { }
        // RVA: 0x0986E854  token: 0x60000D2
        public System.Void .ctor(System.Xml.Linq.XProcessingInstruction other) { }
        // RVA: 0x0986E734  token: 0x60000D6
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986E5FC  token: 0x60000D7
        private virtual System.Xml.Linq.XNode CloneNode() { }
        // RVA: 0x0986E65C  token: 0x60000D8
        private static System.Void ValidateName(System.String name) { }

    }

    // TypeToken: 0x2000023  // size: 0x20
    public class XStreamingElement
    {
        // Fields
        private System.Xml.Linq.XName name;  // 0x10
        private System.Object content;  // 0x18

    }

    // TypeToken: 0x2000024  // size: 0x30
    public class XText : System.Xml.Linq.XNode
    {
        // Fields
        private System.String text;  // 0x28

        // Properties
        System.Xml.XmlNodeType NodeType { get; /* RVA: 0x03D555E0 */ }
        System.String Value { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x0986EB10 */ }

        // Methods
        // RVA: 0x0986EA24  token: 0x60000D9
        public System.Void .ctor(System.String value) { }
        // RVA: 0x0986EA98  token: 0x60000DA
        public System.Void .ctor(System.Xml.Linq.XText other) { }
        // RVA: 0x0986E968  token: 0x60000DE
        public virtual System.Void WriteTo(System.Xml.XmlWriter writer) { }
        // RVA: 0x0986E8E0  token: 0x60000DF
        private virtual System.Void AppendText(System.Text.StringBuilder sb) { }
        // RVA: 0x0986E908  token: 0x60000E0
        private virtual System.Xml.Linq.XNode CloneNode() { }

    }

}

namespace Unity
{

    // TypeToken: 0x2000026  // size: 0x98
    public sealed class ThrowStub : System.ObjectDisposedException
    {
        // Methods
        // RVA: 0x098689B0  token: 0x60000E4
        public static System.Void ThrowNotSupportedException() { }

    }

}

