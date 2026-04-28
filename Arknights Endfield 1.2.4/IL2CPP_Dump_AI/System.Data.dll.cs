// ========================================================
// Dumped by @desirepro
// Assembly: System.Data.dll
// Classes:  230
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
  RVA=0x0339AE90  token=0x6000001  System.String GetString(System.String name)
  RVA=0x0976B7EC  token=0x6000002  System.String Format(System.String resourceFormat, System.Object p1)
  RVA=0x0976B77C  token=0x6000003  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2)
  RVA=0x0976B6FC  token=0x6000004  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3)
END_CLASS

CLASS: ColumnError
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x20
FIELDS:
  private           System.Data.DataColumn          _column  // 0x10
  private           System.String                   _error  // 0x18
METHODS:
END_CLASS

CLASS: DataTableRelationCollection
TYPE:  sealed class
TOKEN: 0x2000027
SIZE:  0x58
EXTENDS: System.Data.DataRelationCollection
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x38
  private   readonly System.Collections.ArrayList    _relations  // 0x40
  private   readonly System.Boolean                  _fParentCollection  // 0x48
  private           System.ComponentModel.CollectionChangeEventHandlerRelationPropertyChanged  // 0x50
PROPERTIES:
  List  get=0x03D4E2B0
  Item  get=0x09794034
  Item  get=0x09794034
EVENTS:
  RelationPropertyChanged  add=add_RelationPropertyChanged  remove=remove_RelationPropertyChanged
METHODS:
  RVA=0x09793E30  token=0x60002B4  System.Void .ctor(System.Data.DataTable table, System.Boolean fParentCollection)
  RVA=0x09793C44  token=0x60002B6  System.Void EnsureDataSet()
  RVA=0x09793C90  token=0x60002B7  System.Data.DataSet GetDataSet()
  RVA=0x09793B44  token=0x60002BC  System.Void AddCache(System.Data.DataRelation relation)
  RVA=0x09793B88  token=0x60002BD  System.Void AddCore(System.Data.DataRelation relation)
  RVA=0x09793CBC  token=0x60002BE  System.Void RemoveCache(System.Data.DataRelation relation)
  RVA=0x09793D74  token=0x60002BF  System.Void RemoveCore(System.Data.DataRelation relation)
END_CLASS

CLASS: DataSetRelationCollection
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x50
EXTENDS: System.Data.DataRelationCollection
FIELDS:
  private   readonly System.Data.DataSet             _dataSet  // 0x38
  private   readonly System.Collections.ArrayList    _relations  // 0x40
  private           System.Data.DataRelation[]      _delayLoadingRelations  // 0x48
PROPERTIES:
  List  get=0x03D4E2B0
  Item  get=0x097872D0
  Item  get=0x097872D0
METHODS:
  RVA=0x09787170  token=0x60002C0  System.Void .ctor(System.Data.DataSet dataSet)
  RVA=0x09786EEC  token=0x60002C2  System.Void Clear()
  RVA=0x03D4E2A0  token=0x60002C3  System.Data.DataSet GetDataSet()
  RVA=0x09786974  token=0x60002C6  System.Void AddCore(System.Data.DataRelation relation)
  RVA=0x09786F34  token=0x60002C7  System.Void RemoveCore(System.Data.DataRelation relation)
END_CLASS

CLASS: DataRowTree
TYPE:  sealed class
TOKEN: 0x2000030
SIZE:  0x40
EXTENDS: System.Data.RBTree`1
FIELDS:
METHODS:
  RVA=0x097831F4  token=0x6000328  System.Void .ctor()
  RVA=0x09783194  token=0x6000329  System.Int32 CompareNode(System.Data.DataRow record1, System.Data.DataRow record2)
  RVA=0x097831C4  token=0x600032A  System.Int32 CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2)
END_CLASS

CLASS: RowDiffIdUsageSection
TYPE:  sealed struct
TOKEN: 0x200003A
SIZE:  0x18
FIELDS:
  private           System.Data.DataTable           _targetTable  // 0x10
METHODS:
  RVA=0x09796B10  token=0x600046C  System.Void Prepare(System.Data.DataTable table)
END_CLASS

CLASS: DSRowDiffIdUsageSection
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x18
FIELDS:
  private           System.Data.DataSet             _targetDS  // 0x10
METHODS:
  RVA=0x0978132C  token=0x600046D  System.Void Prepare(System.Data.DataSet ds)
END_CLASS

CLASS: DataRowReferenceComparer
TYPE:  sealed class
TOKEN: 0x2000043
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
  private   static readonly System.Data.DataView.DataRowReferenceComparers_default  // static @ 0x0
METHODS:
  RVA=0x0350B670  token=0x60004D1  System.Void .ctor()
  RVA=0x06DDEAAC  token=0x60004D2  System.Boolean Equals(System.Data.DataRow x, System.Data.DataRow y)
  RVA=0x09783118  token=0x60004D3  System.Int32 GetHashCode(System.Data.DataRow obj)
  RVA=0x09783130  token=0x60004D4  System.Void .cctor()
END_CLASS

CLASS: DataTypePrecedence
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDateTime  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceDateTimeOffset  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceDateTime  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceTimeSpan  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDouble  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceDouble  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlSingle  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSingle  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDecimal  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceDecimal  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlMoney  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt64  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt64  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt64  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt32  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt32  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt32  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt16  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt16  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt16  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceByte  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlByte  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSByte  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceError  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBoolean  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceBoolean  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlGuid  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlString  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceString  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlXml  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlChars  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceChar  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBytes  // const
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBinary  // const
METHODS:
END_CLASS

CLASS: ReservedWords
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x20
FIELDS:
  private   readonly System.String                   _word  // 0x10
  private   readonly System.Data.Tokens              _token  // 0x18
  private   readonly System.Int32                    _op  // 0x1c
METHODS:
  RVA=0x0426FA34  token=0x6000569  System.Void .ctor(System.String word, System.Data.Tokens token, System.Int32 op)
END_CLASS

CLASS: NodeColor
TYPE:  sealed struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  System.Data.RBTree.NodeColor<K> red  // const
  public    static  System.Data.RBTree.NodeColor<K> black  // const
METHODS:
END_CLASS

CLASS: Node
TYPE:  sealed struct
TOKEN: 0x2000072
FIELDS:
  private           System.Int32                    _selfId  // 0x0
  private           System.Int32                    _leftId  // 0x0
  private           System.Int32                    _rightId  // 0x0
  private           System.Int32                    _parentId  // 0x0
  private           System.Int32                    _nextId  // 0x0
  private           System.Int32                    _subTreeSize  // 0x0
  private           K                               _keyOfNode  // 0x0
  private           System.Data.RBTree.NodeColor<K> _nodeColor  // 0x0
METHODS:
END_CLASS

CLASS: NodePath
TYPE:  sealed struct
TOKEN: 0x2000073
FIELDS:
  private   readonly System.Int32                    _nodeID  // 0x0
  private   readonly System.Int32                    _mainTreeNodeID  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000677  System.Void .ctor(System.Int32 nodeID, System.Int32 mainTreeNodeID)
END_CLASS

CLASS: TreePage
TYPE:  sealed class
TOKEN: 0x2000074
FIELDS:
  private   readonly System.Data.RBTree.Node<K>[]    _slots  // 0x0
  private   readonly System.Int32[]                  _slotMap  // 0x0
  private           System.Int32                    _inUseCount  // 0x0
  private           System.Int32                    _pageId  // 0x0
  private           System.Int32                    _nextFreeSlotLine  // 0x0
PROPERTIES:
  InUseCount  get=-1  // not resolved  set=-1  // not resolved
  PageId  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000678  System.Void .ctor(System.Int32 size)
  RVA=-1  // not resolved  token=0x6000679  System.Int32 AllocSlot(System.Data.RBTree<K> tree)
END_CLASS

CLASS: RBTreeEnumerator
TYPE:  sealed struct
TOKEN: 0x2000075
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.IDisposable System.Collections.IEnumerator
FIELDS:
  private   readonly System.Data.RBTree<K>           _tree  // 0x0
  private   readonly System.Int32                    _version  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _mainTreeNodeId  // 0x0
  private           K                               _current  // 0x0
PROPERTIES:
  Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600067E  System.Void .ctor(System.Data.RBTree<K> tree)
  RVA=-1  // not resolved  token=0x600067F  System.Void .ctor(System.Data.RBTree<K> tree, System.Int32 position)
  RVA=-1  // not resolved  token=0x6000680  System.Void Dispose()
  RVA=-1  // not resolved  token=0x6000681  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000684  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ColumnInfo
TYPE:  sealed class
TOKEN: 0x200007C
SIZE:  0x20
FIELDS:
  public            System.Boolean                  flag  // 0x10
  public            System.Boolean                  equalsOperator  // 0x11
  public            System.Data.BinaryNode          expr  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60006B7  System.Void .ctor()
END_CLASS

CLASS: IndexTree
TYPE:  sealed class
TOKEN: 0x200007F
SIZE:  0x48
EXTENDS: System.Data.RBTree`1
FIELDS:
  private   readonly System.Data.Index               _index  // 0x40
METHODS:
  RVA=0x097AB17C  token=0x60006FC  System.Void .ctor(System.Data.Index index)
  RVA=0x097AB13C  token=0x60006FD  System.Int32 CompareNode(System.Int32 record1, System.Int32 record2)
  RVA=0x097AB15C  token=0x60006FE  System.Int32 CompareSateliteTreeNode(System.Int32 record1, System.Int32 record2)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000080
SIZE:  0x10
FIELDS:
  public    static readonly System.Data.Index.<>c           <>9  // static @ 0x0
  public    static  System.Data.Listeners.Func<System.Data.DataViewListener,System.Data.DataViewListener,System.Boolean><>9__22_0  // static @ 0x8
  public    static  System.Data.Listeners.Action<System.Data.DataViewListener,System.Data.DataViewListener,System.ComponentModel.ListChangedEventArgs,System.Boolean,System.Boolean><>9__85_0  // static @ 0x10
METHODS:
  RVA=0x097B6DC0  token=0x60006FF  System.Void .cctor()
  RVA=0x0350B670  token=0x6000700  System.Void .ctor()
  RVA=0x0686B910  token=0x6000701  System.Boolean <.ctor>b__22_0(System.Data.DataViewListener listener)
  RVA=0x097B6D60  token=0x6000702  System.Void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, System.Boolean arg2, System.Boolean arg3)
END_CLASS

CLASS: <>c__DisplayClass86_0
TYPE:  sealed class
TOKEN: 0x2000081
SIZE:  0x18
FIELDS:
  public            System.ComponentModel.ListChangedTypechangedType  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000703  System.Void .ctor()
  RVA=0x097B6D88  token=0x6000704  System.Void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, System.Boolean track)
END_CLASS

CLASS: Action`4
TYPE:  sealed class
TOKEN: 0x2000083
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600070C  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600070D  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
END_CLASS

CLASS: Func`2
TYPE:  sealed class
TOKEN: 0x2000084
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600070E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600070F  TResult Invoke(T1 arg1)
END_CLASS

CLASS: NameType
TYPE:  sealed class
TOKEN: 0x2000088
SIZE:  0x20
IMPLEMENTS: System.IComparable
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Type                     type  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000754  System.Void .ctor(System.String n, System.Type t)
  RVA=0x097BBAEC  token=0x6000755  System.Int32 CompareTo(System.Object obj)
END_CLASS

CLASS: NameType
TYPE:  sealed class
TOKEN: 0x200008D
SIZE:  0x20
IMPLEMENTS: System.IComparable
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly System.Type                     type  // 0x18
METHODS:
  RVA=0x02676770  token=0x600079F  System.Void .ctor(System.String n, System.Type t)
  RVA=0x097BBB60  token=0x60007A0  System.Int32 CompareTo(System.Object obj)
END_CLASS

CLASS: XmlNodeIdentety
TYPE:  sealed class
TOKEN: 0x2000092
SIZE:  0x20
FIELDS:
  public            System.String                   LocalName  // 0x10
  public            System.String                   NamespaceURI  // 0x18
METHODS:
  RVA=0x02676770  token=0x60007D3  System.Void .ctor(System.String localName, System.String namespaceURI)
  RVA=0x06FAB9A8  token=0x60007D4  System.Int32 GetHashCode()
  RVA=0x097DB534  token=0x60007D5  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: XmlNodeIdHashtable
TYPE:  sealed class
TOKEN: 0x2000093
SIZE:  0x58
EXTENDS: System.Collections.Hashtable
FIELDS:
  private           System.Data.XmlToDatasetMap.XmlNodeIdentety_id  // 0x50
PROPERTIES:
  Item  get=0x097DB42C
  Item  get=0x097DB42C
  Item  get=0x097DB42C
  Item  get=0x097DB42C
METHODS:
  RVA=0x097DB268  token=0x60007D6  System.Void .ctor(System.Int32 capacity)
END_CLASS

CLASS: TableSchemaInfo
TYPE:  sealed class
TOKEN: 0x2000094
SIZE:  0x20
FIELDS:
  public            System.Data.DataTable           TableSchema  // 0x10
  public            System.Data.XmlToDatasetMap.XmlNodeIdHashtableColumnsSchemaMap  // 0x18
METHODS:
  RVA=0x097D74F0  token=0x60007DB  System.Void .ctor(System.Data.DataTable tableSchema)
END_CLASS

CLASS: Families
TYPE:  sealed struct
TOKEN: 0x20000C5
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Common.ObjectStorage.FamiliesDATETIME  // const
  public    static  System.Data.Common.ObjectStorage.FamiliesNUMBER  // const
  public    static  System.Data.Common.ObjectStorage.FamiliesSTRING  // const
  public    static  System.Data.Common.ObjectStorage.FamiliesBOOLEAN  // const
  public    static  System.Data.Common.ObjectStorage.FamiliesARRAY  // const
METHODS:
END_CLASS

CLASS: TempAssemblyComparer
TYPE:  class
TOKEN: 0x20000C6
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
  private   static readonly System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>>s_default  // static @ 0x0
METHODS:
  RVA=0x0350B670  token=0x6000B64  System.Void .ctor()
  RVA=0x09819CCC  token=0x6000B65  System.Boolean Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y)
  RVA=0x09819E10  token=0x6000B66  System.Int32 GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj)
  RVA=0x09819E90  token=0x6000B67  System.Void .cctor()
END_CLASS

CLASS: <>c__DisplayClass6_0
TYPE:  sealed class
TOKEN: 0x20000DA
SIZE:  0x18
FIELDS:
  public            System.Type                     type  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000C8B  System.Void .ctor()
  RVA=0x0982B500  token=0x6000C8C  System.Object <GetStaticNullForUdtType>b__0(System.Type t)
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  sealed struct
TOKEN: 0x20000E1
SIZE:  0x34
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=38
TYPE:  sealed struct
TOKEN: 0x20000E2
SIZE:  0x36
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  sealed struct
TOKEN: 0x20000E3
SIZE:  0x44
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=64
TYPE:  sealed struct
TOKEN: 0x20000E4
SIZE:  0x50
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=152
TYPE:  sealed struct
TOKEN: 0x20000E5
SIZE:  0xA8
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=176
TYPE:  sealed struct
TOKEN: 0x20000E6
SIZE:  0xC0
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x20000E0
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15239A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D  // static @ 0x98
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=525857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA  // static @ 0xbe
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=368D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD  // static @ 0xf2
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226  // static @ 0x116
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E  // static @ 0x1ae
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939  // static @ 0x246
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6  // static @ 0x2de
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591  // static @ 0x38e
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315  // static @ 0x3ce
METHODS:
END_CLASS

CLASS: System.Data.AcceptRejectRule
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.AcceptRejectRule    None  // const
  public    static  System.Data.AcceptRejectRule    Cascade  // const
METHODS:
END_CLASS

CLASS: System.Data.AggregateType
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.AggregateType       None  // const
  public    static  System.Data.AggregateType       Sum  // const
  public    static  System.Data.AggregateType       Mean  // const
  public    static  System.Data.AggregateType       Min  // const
  public    static  System.Data.AggregateType       Max  // const
  public    static  System.Data.AggregateType       First  // const
  public    static  System.Data.AggregateType       Count  // const
  public    static  System.Data.AggregateType       Var  // const
  public    static  System.Data.AggregateType       StDev  // const
METHODS:
END_CLASS

CLASS: System.Data.InternalDataCollectionBase
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
IMPLEMENTS: System.Collections.ICollection System.Collections.IEnumerable
FIELDS:
  private   static readonly System.ComponentModel.CollectionChangeEventArgss_refreshEventArgs  // static @ 0x0
PROPERTIES:
  Count  get=0x0976B4BC
  IsSynchronized  get=0x0115F4C0
  SyncRoot  get=0x0339AE90
  List  get=0x01002730
METHODS:
  RVA=0x0976B324  token=0x6000006  System.Void CopyTo(System.Array ar, System.Int32 index)
  RVA=0x0976B364  token=0x6000007  System.Collections.IEnumerator GetEnumerator()
  RVA=0x0976B38C  token=0x6000009  System.Int32 NamesEqual(System.String s1, System.String s2, System.Boolean fCaseSensitive, System.Globalization.CultureInfo locale)
  RVA=0x0350B670  token=0x600000C  System.Void .ctor()
  RVA=0x0976B438  token=0x600000D  System.Void .cctor()
END_CLASS

CLASS: System.Data.ColumnTypeConverter
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x18
EXTENDS: System.ComponentModel.TypeConverter
FIELDS:
  private   static readonly System.Type[]                   s_types  // static @ 0x0
  private           System.ComponentModel.TypeConverter.StandardValuesCollection_values  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600000E  System.Void .ctor()
  RVA=0x09756694  token=0x600000F  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  RVA=0x097568D4  token=0x6000010  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  RVA=0x09756600  token=0x6000011  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  RVA=0x09756728  token=0x6000012  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  RVA=0x09756CDC  token=0x6000013  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  RVA=0x0232EB60  token=0x6000014  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  RVA=0x0232EB60  token=0x6000015  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  RVA=0x09756E00  token=0x6000016  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataCommonEventSource
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x18
EXTENDS: System.Diagnostics.Tracing.EventSource
FIELDS:
  private   static readonly System.Data.DataCommonEventSourceLog  // static @ 0x0
  private   static  System.Int64                    s_nextScopeId  // static @ 0x8
METHODS:
  RVA=0x09762800  token=0x6000017  System.Void Trace(System.String message)
  RVA=-1  // generic def  token=0x6000018  System.Void Trace(System.String format, T0 arg0)
  RVA=-1  // generic def  token=0x6000019  System.Void Trace(System.String format, T0 arg0, T1 arg1)
  RVA=-1  // generic def  token=0x600001A  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x600001B  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x600001C  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x600001D  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  RVA=0x09762794  token=0x600001E  System.Int64 EnterScope(System.String message)
  RVA=-1  // generic def  token=0x600001F  System.Int64 EnterScope(System.String format, T1 arg1)
  RVA=-1  // generic def  token=0x6000020  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x6000021  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x6000022  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=0x097627F0  token=0x6000023  System.Void ExitScope(System.Int64 scopeId)
  RVA=0x04277134  token=0x6000024  System.Void .ctor()
  RVA=0x09762810  token=0x6000025  System.Void .cctor()
END_CLASS

CLASS: System.Data.Constraint
TYPE:  abstract class
TOKEN: 0x2000008
SIZE:  0x38
FIELDS:
  private           System.String                   _schemaName  // 0x10
  private           System.Boolean                  _inCollection  // 0x18
  private           System.Data.DataSet             _dataSet  // 0x20
  private           System.String                   _name  // 0x28
  private           System.Data.PropertyCollection  _extendedProperties  // 0x30
PROPERTIES:
  ConstraintName  get=0x03D4EAC0  set=0x09759EC4
  SchemaName  get=0x09759EB0  set=0x0975A0A0
  InCollection  get=0x01002A50  set=0x0975A05C
  Table  get=-1  // abstract
  ExtendedProperties  get=0x09759E3C
  _DataSet  get=0x03D4EB40
METHODS:
  RVA=-1  // abstract  token=0x600002E  System.Boolean ContainsColumn(System.Data.DataColumn column)
  RVA=-1  // abstract  token=0x600002F  System.Boolean CanEnableConstraint()
  RVA=-1  // abstract  token=0x6000030  System.Data.Constraint Clone(System.Data.DataSet destination)
  RVA=-1  // abstract  token=0x6000031  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignoreNSforTableLookup)
  RVA=0x09759C70  token=0x6000032  System.Void CheckConstraint()
  RVA=-1  // abstract  token=0x6000033  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraint)
  RVA=-1  // abstract  token=0x6000034  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, System.Boolean fThrowException)
  RVA=-1  // abstract  token=0x6000035  System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=-1  // abstract  token=0x6000036  System.Void CheckState()
  RVA=0x09759CB8  token=0x6000037  System.Void CheckStateForProperty()
  RVA=-1  // abstract  token=0x6000039  System.Boolean IsConstraintViolated()
  RVA=0x03D4EAC0  token=0x600003A  System.String ToString()
  RVA=0x09759DD4  token=0x600003B  System.Void .ctor()
END_CLASS

CLASS: System.Data.ConstraintCollection
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x40
EXTENDS: System.Data.InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChanged  // 0x28
  private           System.Data.Constraint[]        _delayLoadingConstraints  // 0x30
  private           System.Boolean                  _fLoadForeignKeyConstraintsOnly  // 0x38
PROPERTIES:
  List  get=0x01041090
  Item  get=0x097590A0
  Table  get=0x020B7B20
  Item  get=0x097590A0
METHODS:
  RVA=0x09759000  token=0x600003C  System.Void .ctor(System.Data.DataTable table)
  RVA=0x0975777C  token=0x6000041  System.Void Add(System.Data.Constraint constraint)
  RVA=0x0975783C  token=0x6000042  System.Void Add(System.Data.Constraint constraint, System.Boolean addUniqueWhenAddingForeign)
  RVA=0x09757788  token=0x6000043  System.Data.Constraint Add(System.String name, System.Data.DataColumn[] columns, System.Boolean primaryKey)
  RVA=0x097576B8  token=0x6000044  System.Void AddUniqueConstraint(System.Data.UniqueConstraint constraint)
  RVA=0x09757644  token=0x6000045  System.Void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint)
  RVA=0x09757CCC  token=0x6000046  System.Boolean AutoGenerated(System.Data.Constraint constraint)
  RVA=0x09757C44  token=0x6000047  System.Void ArrayAdd(System.Data.Constraint constraint)
  RVA=0x09757C78  token=0x6000048  System.Void ArrayRemove(System.Data.Constraint constraint)
  RVA=0x09757CAC  token=0x6000049  System.String AssignName()
  RVA=0x09757D44  token=0x600004A  System.Void BaseAdd(System.Data.Constraint constraint)
  RVA=0x09757DD0  token=0x600004B  System.Void BaseGroupSwitch(System.Data.Constraint[] oldArray, System.Int32 oldLength, System.Data.Constraint[] newArray, System.Int32 newLength)
  RVA=0x09757F48  token=0x600004C  System.Void BaseRemove(System.Data.Constraint constraint)
  RVA=0x09758198  token=0x600004D  System.Boolean CanRemove(System.Data.Constraint constraint, System.Boolean fThrowException)
  RVA=0x097581F4  token=0x600004E  System.Void Clear()
  RVA=0x09758604  token=0x600004F  System.Boolean Contains(System.String name)
  RVA=0x0975861C  token=0x6000050  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  RVA=0x097586DC  token=0x6000051  System.Data.Constraint FindConstraint(System.Data.Constraint constraint)
  RVA=0x097588EC  token=0x6000052  System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns)
  RVA=0x097589C4  token=0x6000053  System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column)
  RVA=0x097587EC  token=0x6000054  System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  RVA=0x09758594  token=0x6000055  System.Boolean CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2)
  RVA=0x09758A88  token=0x6000056  System.Int32 InternalIndexOf(System.String constraintName)
  RVA=0x09758BB0  token=0x6000057  System.String MakeName(System.Int32 index)
  RVA=0x09758C3C  token=0x6000058  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x09758C58  token=0x6000059  System.Void RegisterName(System.String name)
  RVA=0x09758E28  token=0x600005A  System.Void Remove(System.Data.Constraint constraint)
  RVA=0x09758F78  token=0x600005B  System.Void UnregisterName(System.String name)
END_CLASS

CLASS: System.Data.ConstraintConverter
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x10
EXTENDS: System.ComponentModel.ExpandableObjectConverter
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600005C  System.Void .ctor()
  RVA=0x09759208  token=0x600005D  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  RVA=0x0975929C  token=0x600005E  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.ConstraintEnumerator
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x28
FIELDS:
  private           System.Collections.IEnumerator  _tables  // 0x10
  private           System.Collections.IEnumerator  _constraints  // 0x18
  private           System.Data.Constraint          _currentObject  // 0x20
PROPERTIES:
  CurrentObject  get=0x03D4EB40
METHODS:
  RVA=0x09759BBC  token=0x600005F  System.Void .ctor(System.Data.DataSet dataSet)
  RVA=0x097599FC  token=0x6000060  System.Boolean GetNext()
  RVA=0x03D4EB40  token=0x6000061  System.Data.Constraint GetConstraint()
  RVA=0x0232EB60  token=0x6000062  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
END_CLASS

CLASS: System.Data.ForeignKeyConstraintEnumerator
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x28
EXTENDS: System.Data.ConstraintEnumerator
FIELDS:
METHODS:
  RVA=0x0976B2B8  token=0x6000064  System.Void .ctor(System.Data.DataSet dataSet)
  RVA=0x0976B278  token=0x6000065  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
  RVA=0x0976B23C  token=0x6000066  System.Data.ForeignKeyConstraint GetForeignKeyConstraint()
END_CLASS

CLASS: System.Data.ChildForeignKeyConstraintEnumerator
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x30
EXTENDS: System.Data.ForeignKeyConstraintEnumerator
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x28
METHODS:
  RVA=0x097565D0  token=0x6000067  System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable)
  RVA=0x09756548  token=0x6000068  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
END_CLASS

CLASS: System.Data.ParentForeignKeyConstraintEnumerator
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x30
EXTENDS: System.Data.ForeignKeyConstraintEnumerator
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x28
METHODS:
  RVA=0x097565D0  token=0x6000069  System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable)
  RVA=0x0976B5AC  token=0x600006A  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
END_CLASS

CLASS: System.Data.DataColumn
TYPE:  class
TOKEN: 0x200000F
SIZE:  0xF0
EXTENDS: System.ComponentModel.MarshalByValueComponent
FIELDS:
  private           System.Boolean                  _allowNull  // 0x20
  private           System.String                   _caption  // 0x28
  private           System.String                   _columnName  // 0x30
  private           System.Type                     _dataType  // 0x38
  private           System.Data.Common.StorageType  _storageType  // 0x40
  private           System.Object                   _defaultValue  // 0x48
  private           System.Data.DataSetDateTime     _dateTimeMode  // 0x50
  private           System.Data.DataExpression      _expression  // 0x58
  private           System.Int32                    _maxLength  // 0x60
  private           System.Int32                    _ordinal  // 0x64
  private           System.Boolean                  _readOnly  // 0x68
  private           System.Data.Index               _sortIndex  // 0x70
  private           System.Data.DataTable           _table  // 0x78
  private           System.Boolean                  _unique  // 0x80
  private           System.Data.MappingType         _columnMapping  // 0x84
  private           System.Int32                    _hashCode  // 0x88
  private           System.Int32                    _errors  // 0x8c
  private           System.Boolean                  _isSqlType  // 0x90
  private           System.Boolean                  _implementsINullable  // 0x91
  private           System.Boolean                  _implementsIChangeTracking  // 0x92
  private           System.Boolean                  _implementsIRevertibleChangeTracking  // 0x93
  private           System.Boolean                  _implementsIXMLSerializable  // 0x94
  private           System.Boolean                  _defaultValueIsNull  // 0x95
  private           System.Collections.Generic.List<System.Data.DataColumn>_dependentColumns  // 0x98
  private           System.Data.PropertyCollection  _extendedProperties  // 0xa0
  private           System.Data.Common.DataStorage  _storage  // 0xa8
  private           System.Data.AutoIncrementValue  _autoInc  // 0xb0
  private           System.String                   _columnUri  // 0xb8
  private           System.String                   _columnPrefix  // 0xc0
  private           System.String                   _encodedColumnName  // 0xc8
  private           System.Data.SimpleType          _simpleType  // 0xd0
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0xd8
  private           System.String                   <XmlDataType>k__BackingField  // 0xe0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0xe8
PROPERTIES:
  AllowDBNull  get=0x03D4EF90  set=0x0975F9D0
  AutoIncrement  get=0x0975F4A8  set=0x0975FDA8
  AutoIncrementCurrent  get=0x0975F3E0  set=0x0975FB28
  AutoInc  get=0x0975F2F4
  AutoIncrementSeed  get=0x0975F44C  set=0x0975FC18
  AutoIncrementStep  get=0x0975F478  set=0x0975FCE0
  Caption  get=0x0975F4C4  set=0x0975FF6C
  ColumnName  get=0x01003830  set=0x0976027C
  EncodedColumnName  get=0x0975F5FC
  FormatProvider  get=0x0975F738
  Locale  get=0x0975F834
  ObjectID  get=0x03D50EE0
  Prefix  get=0x03D50E60  set=0x0976221C
  Computed  get=0x05C72CF8
  DataExpression  get=0x03D4EAA0
  DataType  get=0x03D4E2A0  set=0x097607EC
  DateTimeMode  get=0x03D4EED0  set=0x09761018
  DefaultValue  get=0x0975F4D8  set=0x09761174
  DefaultValueIsNull  get=0x03D52050
  Expression  get=0x0975F670  set=0x09761468
  ExtendedProperties  get=0x0975F6BC
  HasData  get=0x05D62028
  ImplementsINullable  get=0x03D50B80
  ImplementsIChangeTracking  get=0x03D50B90
  ImplementsIRevertibleChangeTracking  get=0x03D75420
  IsValueType  get=0x0975F7EC
  IsSqlType  get=0x03D58A70
  MaxLength  get=0x03D4F050  set=0x09761E6C
  Namespace  get=0x0975F88C  set=0x097620F4
  Ordinal  get=0x03D50B30
  ReadOnly  get=0x03D4F3F0  set=0x0976236C
  SortIndex  get=0x0975F8FC
  Table  get=0x03D4EB20
  Item  get=0x0975F80C  set=0x09761CDC
  Unique  get=0x03D4F360  set=0x09762490
  XmlDataType  get=0x03D51140  set=0x0589D964
  SimpleType  get=0x03D50050  set=0x09762440
  ColumnMapping  get=0x03D4F370  set=0x09760000
  IsCustomType  get=0x0975F78C
  ImplementsIXMLSerializable  get=0x03D6CD80
METHODS:
  RVA=0x0975EF70  token=0x600006B  System.Void .ctor()
  RVA=0x0975EF4C  token=0x600006C  System.Void .ctor(System.String columnName, System.Type dataType)
  RVA=0x0975EFEC  token=0x600006D  System.Void .ctor(System.String columnName, System.Type dataType, System.String expr, System.Data.MappingType type)
  RVA=0x0975EE68  token=0x600006E  System.Void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode)
  RVA=0x0975DD24  token=0x6000084  System.String GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0975E9E8  token=0x6000097  System.Void SetMaxLengthSimpleType()
  RVA=0x0975EAA0  token=0x600009D  System.Void SetOrdinalInternal(System.Int32 ordinal)
  RVA=0x0975EC28  token=0x60000A2  System.Void SetTable(System.Data.DataTable table)
  RVA=0x0975DDBC  token=0x60000A3  System.Data.DataRow GetDataRow(System.Int32 index)
  RVA=0x0975E004  token=0x60000A6  System.Void InitializeRecord(System.Int32 record)
  RVA=0x0975ECF4  token=0x60000A7  System.Void SetValue(System.Int32 record, System.Object value)
  RVA=0x0975DC30  token=0x60000A8  System.Void FreeRecord(System.Int32 record)
  RVA=0x03D4F380  token=0x60000AB  System.Void InternalUnique(System.Boolean value)
  RVA=0x0975CE44  token=0x60000B2  System.Void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=0x0975CF08  token=0x60000B3  System.Boolean CheckMaxLength()
  RVA=0x0975CE98  token=0x60000B4  System.Void CheckMaxLength(System.Data.DataRow dr)
  RVA=0x0975D118  token=0x60000B5  System.Void CheckNotAllowNull()
  RVA=0x0975D400  token=0x60000B6  System.Void CheckNullable(System.Data.DataRow row)
  RVA=0x0975D47C  token=0x60000B7  System.Void CheckUnique()
  RVA=0x0975DA28  token=0x60000B8  System.Int32 Compare(System.Int32 record1, System.Int32 record2)
  RVA=0x0975D874  token=0x60000B9  System.Boolean CompareValueTo(System.Int32 record1, System.Object value, System.Boolean checkType)
  RVA=0x0975D9FC  token=0x60000BA  System.Int32 CompareValueTo(System.Int32 record1, System.Object value)
  RVA=0x0975DB0C  token=0x60000BB  System.Object ConvertValue(System.Object value)
  RVA=0x0975DC04  token=0x60000BC  System.Void Copy(System.Int32 srcRecordNo, System.Int32 dstRecordNo)
  RVA=0x0975D4D4  token=0x60000BD  System.Data.DataColumn Clone()
  RVA=0x0975DC60  token=0x60000BE  System.Object GetAggregateValue(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0975DE20  token=0x60000BF  System.Int32 GetStringLength(System.Int32 record)
  RVA=0x0975DF70  token=0x60000C0  System.Void Init(System.Int32 record)
  RVA=0x0975E0C8  token=0x60000C1  System.Boolean IsAutoIncrementType(System.Type dataType)
  RVA=0x0975E7E8  token=0x60000C3  System.Boolean IsValueCustomTypeInstance(System.Object value)
  RVA=0x0975E2B4  token=0x60000C5  System.Boolean IsInRelation()
  RVA=0x0975E3B4  token=0x60000C6  System.Boolean IsMaxLengthViolated()
  RVA=0x0975E6C8  token=0x60000C7  System.Boolean IsNotAllowDBNullViolated()
  RVA=0x0975E874  token=0x60000C8  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  RVA=0x0975E894  token=0x60000C9  System.Void RaisePropertyChanging(System.String name)
  RVA=0x0975E048  token=0x60000CA  System.Void InsureStorage()
  RVA=0x0975E9A8  token=0x60000CB  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0350B670  token=0x60000CC  System.Void OnSetDataSet()
  RVA=0x0975EE04  token=0x60000CD  System.String ToString()
  RVA=0x0975DB34  token=0x60000CE  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0975DB74  token=0x60000CF  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x0975DA54  token=0x60000D0  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0975DA94  token=0x60000D1  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x0975DDE4  token=0x60000D2  System.Object GetEmptyColumnStore(System.Int32 recordCount)
  RVA=0x0975DBDC  token=0x60000D3  System.Void CopyValueIntoStore(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0975EBD8  token=0x60000D4  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x0975CD74  token=0x60000D5  System.Void AddDependentColumn(System.Data.DataColumn expressionColumn)
  RVA=0x0975E90C  token=0x60000D6  System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn)
  RVA=0x0975DE48  token=0x60000D7  System.Void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression)
END_CLASS

CLASS: System.Data.AutoIncrementValue
TYPE:  abstract class
TOKEN: 0x2000010
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <Auto>k__BackingField  // 0x10
PROPERTIES:
  Auto  get=0x011797F0  set=0x03D4E960
  Current  get=-1  // abstract  set=-1  // abstract
  Seed  get=-1  // abstract  set=-1  // abstract
  Step  get=-1  // abstract  set=-1  // abstract
  DataType  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60000E1  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  RVA=-1  // abstract  token=0x60000E2  System.Void SetCurrentAndIncrement(System.Object value)
  RVA=-1  // abstract  token=0x60000E3  System.Void MoveAfter()
  RVA=0x09756458  token=0x60000E4  System.Data.AutoIncrementValue Clone()
  RVA=0x0350B670  token=0x60000E5  System.Void .ctor()
END_CLASS

CLASS: System.Data.AutoIncrementInt64
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x30
EXTENDS: System.Data.AutoIncrementValue
FIELDS:
  private           System.Int64                    _current  // 0x18
  private           System.Int64                    _seed  // 0x20
  private           System.Int64                    _step  // 0x28
PROPERTIES:
  Current  get=0x09756270  set=0x09756308
  DataType  get=0x097562B8
  Seed  get=0x03D4EB40  set=0x09756358
  Step  get=0x03D4EAC0  set=0x097563DC
METHODS:
  RVA=0x03D75400  token=0x60000ED  System.Void MoveAfter()
  RVA=0x0975620C  token=0x60000EE  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  RVA=0x097560F8  token=0x60000EF  System.Void SetCurrentAndIncrement(System.Object value)
  RVA=0x09756048  token=0x60000F0  System.Boolean BoundaryCheck(System.Numerics.BigInteger value)
  RVA=0x03D75410  token=0x60000F1  System.Void .ctor()
END_CLASS

CLASS: System.Data.AutoIncrementBigInteger
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x40
EXTENDS: System.Data.AutoIncrementValue
FIELDS:
  private           System.Numerics.BigInteger      _current  // 0x18
  private           System.Int64                    _seed  // 0x28
  private           System.Numerics.BigInteger      _step  // 0x30
PROPERTIES:
  Current  get=0x09755C80  set=0x09755D78
  DataType  get=0x09755CC8
  Seed  get=0x03D4EAC0  set=0x09755DD0
  Step  get=0x09755D18  set=0x09755EB4
METHODS:
  RVA=0x09755AB4  token=0x60000F9  System.Void MoveAfter()
  RVA=0x09755BFC  token=0x60000FA  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  RVA=0x09755B3C  token=0x60000FB  System.Void SetCurrentAndIncrement(System.Object value)
  RVA=0x097559B4  token=0x60000FC  System.Boolean BoundaryCheck(System.Numerics.BigInteger value)
  RVA=0x09755C28  token=0x60000FD  System.Void .ctor()
END_CLASS

CLASS: System.Data.DataColumnChangeEventArgs
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x28
EXTENDS: System.EventArgs
FIELDS:
  private           System.Data.DataColumn          _column  // 0x10
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x18
  private           System.Object                   <ProposedValue>k__BackingField  // 0x20
PROPERTIES:
  ProposedValue  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0975A0BC  token=0x60000FE  System.Void .ctor(System.Data.DataRow row)
  RVA=0x0975A114  token=0x60000FF  System.Void .ctor(System.Data.DataRow row, System.Data.DataColumn column, System.Object value)
  RVA=0x02CC1260  token=0x6000102  System.Void InitializeColumnChangeEvent(System.Data.DataColumn column, System.Object value)
END_CLASS

CLASS: System.Data.DataColumnChangeEventHandler
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x6000103  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000104  System.Void Invoke(System.Object sender, System.Data.DataColumnChangeEventArgs e)
END_CLASS

CLASS: System.Data.DataColumnCollection
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x68
EXTENDS: System.Data.InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.Data.DataColumn[]        _delayedAddRangeColumns  // 0x28
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Data.DataColumn>_columnFromName  // 0x30
  private           System.Boolean                  _fInClear  // 0x38
  private           System.Data.DataColumn[]        _columnsImplementingIChangeTracking  // 0x40
  private           System.Int32                    _nColumnsImplementingIChangeTracking  // 0x48
  private           System.Int32                    _nColumnsImplementingIRevertibleChangeTracking  // 0x4c
  private           System.ComponentModel.CollectionChangeEventHandlerCollectionChanged  // 0x50
  private           System.ComponentModel.CollectionChangeEventHandlerCollectionChanging  // 0x58
  private           System.ComponentModel.CollectionChangeEventHandlerColumnPropertyChanged  // 0x60
PROPERTIES:
  List  get=0x01041090
  ColumnsImplementingIChangeTracking  get=0x03D4E2B0
  ColumnsImplementingIChangeTrackingCount  get=0x03D4EC50
  ColumnsImplementingIRevertibleChangeTrackingCount  get=0x03D4EDF0
  Item  get=0x0975C4B4
  Item  get=0x0975C4B4
  Item  get=0x0975C4B4
EVENTS:
  CollectionChanged  add=add_CollectionChanged  remove=remove_CollectionChanged
  ColumnPropertyChanged  add=add_ColumnPropertyChanged  remove=remove_ColumnPropertyChanged
METHODS:
  RVA=0x0975C1DC  token=0x6000105  System.Void .ctor(System.Data.DataTable table)
  RVA=0x0975A49C  token=0x600010D  System.Void Add(System.Data.DataColumn column)
  RVA=0x0975A198  token=0x600010E  System.Void AddAt(System.Int32 index, System.Data.DataColumn column)
  RVA=0x0975A4F4  token=0x6000113  System.Void ArrayAdd(System.Data.DataColumn column)
  RVA=0x0975A4AC  token=0x6000114  System.Void ArrayAdd(System.Int32 index, System.Data.DataColumn column)
  RVA=0x0975A560  token=0x6000115  System.Void ArrayRemove(System.Data.DataColumn column)
  RVA=0x0975A674  token=0x6000116  System.String AssignName()
  RVA=0x0975A6E4  token=0x6000117  System.Void BaseAdd(System.Data.DataColumn column)
  RVA=0x0975A9C4  token=0x6000118  System.Void BaseGroupSwitch(System.Data.DataColumn[] oldArray, System.Int32 oldLength, System.Data.DataColumn[] newArray, System.Int32 newLength)
  RVA=0x0975ABB0  token=0x6000119  System.Void BaseRemove(System.Data.DataColumn column)
  RVA=0x0975ACCC  token=0x600011A  System.Boolean CanRemove(System.Data.DataColumn column, System.Boolean fThrowException)
  RVA=0x0975B59C  token=0x600011B  System.Void CheckIChangeTracking(System.Data.DataColumn column)
  RVA=0x0975B5D4  token=0x600011C  System.Void Clear()
  RVA=0x0975B93C  token=0x600011D  System.Boolean Contains(System.String name)
  RVA=0x0975B8A0  token=0x600011E  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  RVA=0x0975BAF8  token=0x600011F  System.Int32 IndexOf(System.String columnName)
  RVA=0x0975B9C0  token=0x6000120  System.Int32 IndexOfCaseInsensitive(System.String name)
  RVA=0x0975BBEC  token=0x6000121  System.String MakeName(System.Int32 index)
  RVA=0x0975BC78  token=0x6000122  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x0975BCEC  token=0x6000123  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x0975BD08  token=0x6000124  System.Void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x0975BD54  token=0x6000125  System.Void RegisterColumnName(System.String name, System.Data.DataColumn column)
  RVA=0x0975AC74  token=0x6000126  System.Boolean CanRegisterName(System.String name)
  RVA=0x0975C024  token=0x6000127  System.Void Remove(System.Data.DataColumn column)
  RVA=0x0975C118  token=0x6000128  System.Void UnregisterName(System.String name)
  RVA=0x0975A3F0  token=0x6000129  System.Void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn)
  RVA=0x0975BF48  token=0x600012A  System.Void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn)
END_CLASS

CLASS: System.Data.DataColumnPropertyDescriptor
TYPE:  sealed class
TOKEN: 0x2000016
SIZE:  0x90
EXTENDS: System.ComponentModel.PropertyDescriptor
FIELDS:
  private   readonly System.Data.DataColumn          <Column>k__BackingField  // 0x88
PROPERTIES:
  Attributes  get=0x0975CB74
  Column  get=0x03D4EA60
  ComponentType  get=0x0975CCE4
  IsReadOnly  get=0x0975CD34
  PropertyType  get=0x0975CD54
METHODS:
  RVA=0x0975CB2C  token=0x600012B  System.Void .ctor(System.Data.DataColumn dataColumn)
  RVA=0x0975C8C4  token=0x6000131  System.Boolean Equals(System.Object other)
  RVA=0x0975C924  token=0x6000132  System.Int32 GetHashCode()
  RVA=0x0975C7E8  token=0x6000133  System.Boolean CanResetValue(System.Object component)
  RVA=0x0975C948  token=0x6000134  System.Object GetValue(System.Object component)
  RVA=0x0975C9BC  token=0x6000135  System.Void ResetValue(System.Object component)
  RVA=0x0975CA68  token=0x6000136  System.Void SetValue(System.Object component, System.Object value)
  RVA=0x0115F4C0  token=0x6000137  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: System.Data.DataError
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x28
FIELDS:
  private           System.String                   _rowError  // 0x10
  private           System.Int32                    _count  // 0x18
  private           System.Data.DataError.ColumnError[]_errorList  // 0x20
PROPERTIES:
  Text  get=0x020B7B20  set=0x09762E5C
  HasErrors  get=0x09762E30
METHODS:
  RVA=0x09762DE8  token=0x6000138  System.Void .ctor()
  RVA=0x09762D84  token=0x6000139  System.Void .ctor(System.String rowError)
  RVA=0x09762C04  token=0x600013D  System.Void SetColumnError(System.Data.DataColumn column, System.String error)
  RVA=0x097629A4  token=0x600013E  System.String GetColumnError(System.Data.DataColumn column)
  RVA=0x09762894  token=0x600013F  System.Void Clear(System.Data.DataColumn column)
  RVA=0x0976291C  token=0x6000140  System.Void Clear()
  RVA=0x09762A38  token=0x6000141  System.Data.DataColumn[] GetColumnsInError()
  RVA=0x09762D28  token=0x6000142  System.Void SetText(System.String errorText)
  RVA=0x09762ADC  token=0x6000143  System.Int32 IndexOf(System.Data.DataColumn column)
END_CLASS

CLASS: System.Data.DataException
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x90
EXTENDS: System.SystemException
FIELDS:
METHODS:
  RVA=0x09166FDC  token=0x6000144  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09762E84  token=0x6000145  System.Void .ctor()
  RVA=0x09762E64  token=0x6000146  System.Void .ctor(System.String s)
  RVA=0x091A5918  token=0x6000147  System.Void .ctor(System.String s, System.Exception innerException)
END_CLASS

CLASS: System.Data.ConstraintException
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x6000148  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09759C0C  token=0x6000149  System.Void .ctor()
  RVA=0x09759C50  token=0x600014A  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.DeletedRowInaccessibleException
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x600014B  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x097666A8  token=0x600014C  System.Void .ctor()
  RVA=0x097666EC  token=0x600014D  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.DuplicateNameException
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x600014E  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976672C  token=0x600014F  System.Void .ctor()
  RVA=0x0976670C  token=0x6000150  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.InRowChangingEventException
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x6000151  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B2C0  token=0x6000152  System.Void .ctor()
  RVA=0x0976B304  token=0x6000153  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.InvalidConstraintException
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x6000154  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B504  token=0x6000155  System.Void .ctor()
  RVA=0x0976B4E4  token=0x6000156  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.NoNullAllowedException
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x6000157  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B568  token=0x6000158  System.Void .ctor()
  RVA=0x0976B548  token=0x6000159  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ReadOnlyException
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x600015A  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B634  token=0x600015B  System.Void .ctor()
  RVA=0x0976B678  token=0x600015C  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.RowNotInTableException
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x600015D  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B698  token=0x600015E  System.Void .ctor()
  RVA=0x0976B6DC  token=0x600015F  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.VersionNotFoundException
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x6000160  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0976B848  token=0x6000161  System.Void .ctor()
  RVA=0x0976B88C  token=0x6000162  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ExceptionBuilder
TYPE:  static class
TOKEN: 0x2000023
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0976A818  token=0x6000163  System.Void TraceException(System.String trace, System.Exception e)
  RVA=0x0976A758  token=0x6000164  System.Exception TraceExceptionAsReturnValue(System.Exception e)
  RVA=0x0976A798  token=0x6000165  System.Exception TraceExceptionForCapture(System.Exception e)
  RVA=0x0976A7D8  token=0x6000166  System.Exception TraceExceptionWithoutRethrow(System.Exception e)
  RVA=0x0976AC8C  token=0x6000167  System.Exception _Argument(System.String error)
  RVA=0x0976AC14  token=0x6000168  System.Exception _Argument(System.String error, System.Exception innerException)
  RVA=0x0976AB24  token=0x6000169  System.Exception _ArgumentNull(System.String paramName, System.String msg)
  RVA=0x0976AB9C  token=0x600016A  System.Exception _ArgumentOutOfRange(System.String paramName, System.String msg)
  RVA=0x0976AEFC  token=0x600016B  System.Exception _IndexOutOfRange(System.String error)
  RVA=0x0976B034  token=0x600016C  System.Exception _InvalidOperation(System.String error)
  RVA=0x0976AFCC  token=0x600016D  System.Exception _InvalidEnumArgumentException(System.String error)
  RVA=-1  // generic def  token=0x600016E  System.Exception _InvalidEnumArgumentException(T value)
  RVA=0x0976A664  token=0x600016F  System.Void ThrowDataException(System.String error, System.Exception innerException)
  RVA=0x0976AD5C  token=0x6000170  System.Exception _Data(System.String error)
  RVA=0x0976ACF4  token=0x6000171  System.Exception _Constraint(System.String error)
  RVA=0x0976AF64  token=0x6000172  System.Exception _InvalidConstraint(System.String error)
  RVA=0x0976ADC4  token=0x6000173  System.Exception _DeletedRowInaccessible(System.String error)
  RVA=0x0976AE2C  token=0x6000174  System.Exception _DuplicateName(System.String error)
  RVA=0x0976AE94  token=0x6000175  System.Exception _InRowChangingEvent(System.String error)
  RVA=0x0976B09C  token=0x6000176  System.Exception _NoNullAllowed(System.String error)
  RVA=0x0976B104  token=0x6000177  System.Exception _ReadOnly(System.String error)
  RVA=0x0976B16C  token=0x6000178  System.Exception _RowNotInTable(System.String error)
  RVA=0x0976B1D4  token=0x6000179  System.Exception _VersionNotFound(System.String error)
  RVA=0x097668AC  token=0x600017A  System.Exception ArgumentNull(System.String paramName)
  RVA=0x097668F8  token=0x600017B  System.Exception ArgumentOutOfRange(System.String paramName)
  RVA=0x09766A90  token=0x600017C  System.Exception BadObjectPropertyAccess(System.String error)
  RVA=0x09767490  token=0x600017D  System.Exception CaseInsensitiveNameConflict(System.String name)
  RVA=0x09769200  token=0x600017E  System.Exception NamespaceNameConflict(System.String name)
  RVA=0x09768960  token=0x600017F  System.Exception InvalidOffsetLength()
  RVA=0x097675F0  token=0x6000180  System.Exception ColumnNotInTheTable(System.String column, System.String table)
  RVA=0x097675BC  token=0x6000181  System.Exception ColumnNotInAnyTable()
  RVA=0x09767648  token=0x6000182  System.Exception ColumnOutOfRange(System.Int32 index)
  RVA=0x097676BC  token=0x6000183  System.Exception ColumnOutOfRange(System.String column)
  RVA=0x09766CE0  token=0x6000184  System.Exception CannotAddColumn1(System.String column)
  RVA=0x09766D28  token=0x6000185  System.Exception CannotAddColumn2(System.String column)
  RVA=0x09766D70  token=0x6000186  System.Exception CannotAddColumn3()
  RVA=0x09766DA4  token=0x6000187  System.Exception CannotAddColumn4(System.String column)
  RVA=0x09766E7C  token=0x6000188  System.Exception CannotAddDuplicate(System.String column)
  RVA=0x09766DEC  token=0x6000189  System.Exception CannotAddDuplicate2(System.String table)
  RVA=0x09766E34  token=0x600018A  System.Exception CannotAddDuplicate3(System.String table)
  RVA=0x0976703C  token=0x600018B  System.Exception CannotRemoveColumn()
  RVA=0x09767120  token=0x600018C  System.Exception CannotRemovePrimaryKey()
  RVA=0x09766FF4  token=0x600018D  System.Exception CannotRemoveChildKey(System.String relation)
  RVA=0x09767070  token=0x600018E  System.Exception CannotRemoveConstraint(System.String constraint, System.String table)
  RVA=0x097670C8  token=0x600018F  System.Exception CannotRemoveExpression(System.String column, System.String expression)
  RVA=0x097667D8  token=0x6000190  System.Exception AddPrimaryKeyConstraint()
  RVA=0x0976932C  token=0x6000191  System.Exception NoConstraintName()
  RVA=0x09767958  token=0x6000192  System.Exception ConstraintViolation(System.String constraint)
  RVA=0x09768DF4  token=0x6000193  System.String KeysToString(System.Object[] keys)
  RVA=0x0976A960  token=0x6000194  System.String UniqueConstraintViolationText(System.Data.DataColumn[] columns, System.Object[] values)
  RVA=0x0976793C  token=0x6000195  System.Exception ConstraintViolation(System.Data.DataColumn[] columns, System.Object[] values)
  RVA=0x09767860  token=0x6000196  System.Exception ConstraintOutOfRange(System.Int32 index)
  RVA=0x09767E98  token=0x6000197  System.Exception DuplicateConstraint(System.String constraint)
  RVA=0x09767E08  token=0x6000198  System.Exception DuplicateConstraintName(System.String constraint)
  RVA=0x09769248  token=0x6000199  System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk)
  RVA=0x0976AABC  token=0x600019A  System.Exception UniqueConstraintViolation()
  RVA=0x0976782C  token=0x600019B  System.Exception ConstraintForeignTable()
  RVA=0x097678D4  token=0x600019C  System.Exception ConstraintParentValues()
  RVA=0x097677D4  token=0x600019D  System.Exception ConstraintAddFailed(System.Data.DataTable table)
  RVA=0x09767908  token=0x600019E  System.Exception ConstraintRemoveFailed()
  RVA=0x09768280  token=0x600019F  System.Exception FailedCascadeDelete(System.String constraint)
  RVA=0x097682C8  token=0x60001A0  System.Exception FailedCascadeUpdate(System.String constraint)
  RVA=0x09768310  token=0x60001A1  System.Exception FailedClearParentTable(System.String table, System.String constraint, System.String childTable)
  RVA=0x09768378  token=0x60001A2  System.Exception ForeignKeyViolation(System.String constraint, System.Object[] keys)
  RVA=0x09769CEC  token=0x60001A3  System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint)
  RVA=0x09768F80  token=0x60001A4  System.String MaxLengthViolationText(System.String columnName)
  RVA=0x09769478  token=0x60001A5  System.String NotAllowDBNullViolationText(System.String columnName)
  RVA=0x0976736C  token=0x60001A6  System.Exception CantAddConstraintToMultipleNestedTable(System.String tableName)
  RVA=0x097669E0  token=0x60001A7  System.Exception AutoIncrementAndExpression()
  RVA=0x097669AC  token=0x60001A8  System.Exception AutoIncrementAndDefaultValue()
  RVA=0x09766A5C  token=0x60001A9  System.Exception AutoIncrementSeed()
  RVA=0x097673B4  token=0x60001AA  System.Exception CantChangeDataType()
  RVA=0x097694E8  token=0x60001AB  System.Exception NullDataType()
  RVA=0x09767588  token=0x60001AC  System.Exception ColumnNameRequired()
  RVA=0x09767B50  token=0x60001AD  System.Exception DefaultValueAndAutoIncrement()
  RVA=0x09767C2C  token=0x60001AE  System.Exception DefaultValueDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner)
  RVA=0x09767B84  token=0x60001AF  System.Exception DefaultValueColumnDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner)
  RVA=0x097681C4  token=0x60001B0  System.Exception ExpressionAndUnique()
  RVA=0x09768190  token=0x60001B1  System.Exception ExpressionAndReadOnly()
  RVA=0x09768128  token=0x60001B2  System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint)
  RVA=0x0976822C  token=0x60001B3  System.Exception ExpressionInConstraint(System.Data.DataColumn column)
  RVA=0x097681F8  token=0x60001B4  System.Exception ExpressionCircular()
  RVA=0x09769430  token=0x60001B5  System.Exception NonUniqueValues(System.String column)
  RVA=0x0976951C  token=0x60001B6  System.Exception NullKeyValues(System.String column)
  RVA=0x09769598  token=0x60001B7  System.Exception NullValues(System.String column)
  RVA=0x097697D4  token=0x60001B8  System.Exception ReadOnlyAndExpression()
  RVA=0x09769808  token=0x60001B9  System.Exception ReadOnly(System.String column)
  RVA=0x0976A92C  token=0x60001BA  System.Exception UniqueAndExpression()
  RVA=0x0976A154  token=0x60001BB  System.Exception SetFailed(System.Object value, System.Data.DataColumn column, System.Type type, System.Exception innerException)
  RVA=0x09767318  token=0x60001BC  System.Exception CannotSetToNull(System.Data.DataColumn column)
  RVA=0x09768EE4  token=0x60001BD  System.Exception LongerThanMaxLength(System.Data.DataColumn column)
  RVA=0x097671DC  token=0x60001BE  System.Exception CannotSetMaxLength(System.Data.DataColumn column, System.Int32 value)
  RVA=0x09767188  token=0x60001BF  System.Exception CannotSetMaxLength2(System.Data.DataColumn column)
  RVA=0x09767268  token=0x60001C0  System.Exception CannotSetSimpleContentType(System.String columnName, System.Type type)
  RVA=0x097672C0  token=0x60001C1  System.Exception CannotSetSimpleContent(System.String columnName, System.Type type)
  RVA=0x09766F0C  token=0x60001C2  System.Exception CannotChangeNamespace(System.String columnName)
  RVA=0x0976850C  token=0x60001C3  System.Exception HasToBeStringType(System.Data.DataColumn column)
  RVA=0x09766A14  token=0x60001C4  System.Exception AutoIncrementCannotSetIfHasData(System.String typeName)
  RVA=0x097685A8  token=0x60001C5  System.Exception INullableUDTwithoutStaticNull(System.String typeName)
  RVA=0x09768560  token=0x60001C6  System.Exception IComparableNotImplemented(System.String typeName)
  RVA=0x0976A89C  token=0x60001C7  System.Exception UDTImplementsIChangeTrackingButnotIRevertible(System.String typeName)
  RVA=0x097687E0  token=0x60001C8  System.Exception InvalidDataColumnMapping(System.Type type)
  RVA=0x09767154  token=0x60001C9  System.Exception CannotSetDateTimeModeForNonDateTimeColumns()
  RVA=0x09768840  token=0x60001CA  System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode)
  RVA=0x097673E8  token=0x60001CB  System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue)
  RVA=0x0976774C  token=0x60001CC  System.Exception ColumnTypeNotSupported()
  RVA=0x0976A238  token=0x60001CD  System.Exception SetFailed(System.String name)
  RVA=0x09766C78  token=0x60001CE  System.Exception CanNotUse()
  RVA=0x0976A280  token=0x60001CF  System.Exception SetIListObject()
  RVA=0x097667A4  token=0x60001D0  System.Exception AddNewNotAllowNull()
  RVA=0x097694B4  token=0x60001D1  System.Exception NotOpen()
  RVA=0x09767A24  token=0x60001D2  System.Exception CreateChildView()
  RVA=0x09766B40  token=0x60001D3  System.Exception CanNotDelete()
  RVA=0x09768440  token=0x60001D4  System.Exception GetElementIndex(System.Int32 index)
  RVA=0x09766770  token=0x60001D5  System.Exception AddExternalObject()
  RVA=0x09766B0C  token=0x60001D6  System.Exception CanNotClear()
  RVA=0x097686EC  token=0x60001D7  System.Exception InsertExternalObject()
  RVA=0x09769CB8  token=0x60001D8  System.Exception RemoveExternalObject()
  RVA=0x09768D4C  token=0x60001D9  System.Exception KeyTableMismatch()
  RVA=0x09768D18  token=0x60001DA  System.Exception KeyNoColumns()
  RVA=0x09768D80  token=0x60001DB  System.Exception KeyTooManyColumns(System.Int32 cols)
  RVA=0x09768C68  token=0x60001DC  System.Exception KeyDuplicateColumns(System.String columnName)
  RVA=0x097699B0  token=0x60001DD  System.Exception RelationDataSetMismatch()
  RVA=0x097677A0  token=0x60001DE  System.Exception ColumnsTypeMismatch()
  RVA=0x09768CB0  token=0x60001DF  System.Exception KeyLengthMismatch()
  RVA=0x09768CE4  token=0x60001E0  System.Exception KeyLengthZero()
  RVA=0x097683D8  token=0x60001E1  System.Exception ForeignRelation()
  RVA=0x09768C34  token=0x60001E2  System.Exception KeyColumnsIdentical()
  RVA=0x09769A80  token=0x60001E3  System.Exception RelationForeignTable(System.String t1, System.String t2)
  RVA=0x097684B4  token=0x60001E4  System.Exception GetParentRowTableMismatch(System.String t1, System.String t2)
  RVA=0x0976A2B4  token=0x60001E5  System.Exception SetParentRowTableMismatch(System.String t1, System.String t2)
  RVA=0x09769A4C  token=0x60001E6  System.Exception RelationForeignRow()
  RVA=0x09769AD8  token=0x60001E7  System.Exception RelationNestedReadOnly()
  RVA=0x0976A410  token=0x60001E8  System.Exception TableCantBeNestedInTwoTables(System.String tableName)
  RVA=0x09768F38  token=0x60001E9  System.Exception LoopInNestedRelations(System.String tableName)
  RVA=0x09769A18  token=0x60001EA  System.Exception RelationDoesNotExist()
  RVA=0x097695E0  token=0x60001EB  System.Exception ParentOrChildColumnsDoNotHaveDataSet()
  RVA=0x097685F0  token=0x60001EC  System.Exception InValidNestedRelation(System.String childTableName)
  RVA=0x09768994  token=0x60001ED  System.Exception InvalidParentNamespaceinNestedRelation(System.String childTableName)
  RVA=0x09769F80  token=0x60001EE  System.Exception RowNotInTheDataSet()
  RVA=0x09769FB4  token=0x60001EF  System.Exception RowNotInTheTable()
  RVA=0x09768010  token=0x60001F0  System.Exception EditInRowChanging()
  RVA=0x0976808C  token=0x60001F1  System.Exception EndEditInRowChanging()
  RVA=0x09766AD8  token=0x60001F2  System.Exception BeginEditInRowChanging()
  RVA=0x09766CAC  token=0x60001F3  System.Exception CancelEditInRowChanging()
  RVA=0x09767D24  token=0x60001F4  System.Exception DeleteInRowDeleting()
  RVA=0x0976AAF0  token=0x60001F5  System.Exception ValueArrayLength()
  RVA=0x09769360  token=0x60001F6  System.Exception NoCurrentData()
  RVA=0x09769394  token=0x60001F7  System.Exception NoOriginalData()
  RVA=0x097693C8  token=0x60001F8  System.Exception NoProposedData()
  RVA=0x0976A05C  token=0x60001F9  System.Exception RowRemovedFromTheTable()
  RVA=0x09767D58  token=0x60001FA  System.Exception DeletedRowInaccessible()
  RVA=0x09769DB8  token=0x60001FB  System.Exception RowAlreadyDeleted()
  RVA=0x09769E88  token=0x60001FC  System.Exception RowEmpty()
  RVA=0x09768AC8  token=0x60001FD  System.Exception InvalidRowVersion()
  RVA=0x09769FE8  token=0x60001FE  System.Exception RowOutOfRange(System.Int32 index)
  RVA=0x09769F04  token=0x60001FF  System.Exception RowInsertTwice(System.Int32 index, System.String tableName)
  RVA=0x09769EBC  token=0x6000200  System.Exception RowInsertMissing(System.String tableName)
  RVA=0x09769E54  token=0x6000201  System.Exception RowAlreadyRemoved()
  RVA=0x09769198  token=0x6000202  System.Exception MultipleParents()
  RVA=0x09768A90  token=0x6000203  System.Exception InvalidRowState(System.Data.DataRowState state)
  RVA=0x09768A5C  token=0x6000204  System.Exception InvalidRowBitPattern()
  RVA=0x0976A120  token=0x6000205  System.Exception SetDataSetNameToEmpty()
  RVA=0x0976A0D8  token=0x6000206  System.Exception SetDataSetNameConflicting(System.String name)
  RVA=0x09767A58  token=0x6000207  System.Exception DataSetUnsupportedSchema(System.String ns)
  RVA=0x09768FC4  token=0x6000208  System.Exception MergeMissingDefinition(System.String obj)
  RVA=0x0976A630  token=0x6000209  System.Exception TablesInDifferentSets()
  RVA=0x09769884  token=0x600020A  System.Exception RelationAlreadyExists()
  RVA=0x09769DEC  token=0x600020B  System.Exception RowAlreadyInOtherCollection()
  RVA=0x09769E20  token=0x600020C  System.Exception RowAlreadyInTheCollection()
  RVA=0x09769850  token=0x600020D  System.Exception RecordStateRange()
  RVA=0x09768638  token=0x600020E  System.Exception IndexKeyLength(System.Int32 length, System.Int32 keyLength)
  RVA=0x09769D40  token=0x600020F  System.Exception RemovePrimaryKey(System.Data.DataTable table)
  RVA=0x097698B8  token=0x6000210  System.Exception RelationAlreadyInOtherDataSet()
  RVA=0x097698EC  token=0x6000211  System.Exception RelationAlreadyInTheDataSet()
  RVA=0x09769B0C  token=0x6000212  System.Exception RelationNotInTheDataSet(System.String relation)
  RVA=0x09769B54  token=0x6000213  System.Exception RelationOutOfRange(System.Object index)
  RVA=0x09767F28  token=0x6000214  System.Exception DuplicateRelation(System.String relation)
  RVA=0x09769C50  token=0x6000215  System.Exception RelationTableNull()
  RVA=0x097699E4  token=0x6000216  System.Exception RelationDataSetNull()
  RVA=0x09769C84  token=0x6000217  System.Exception RelationTableWasRemoved()
  RVA=0x09769614  token=0x6000218  System.Exception ParentTableMismatch()
  RVA=0x0976750C  token=0x6000219  System.Exception ChildTableMismatch()
  RVA=0x097680C0  token=0x600021A  System.Exception EnforceConstraint()
  RVA=0x097674D8  token=0x600021B  System.Exception CaseLocaleMismatch()
  RVA=0x09766EC4  token=0x600021C  System.Exception CannotChangeCaseLocale()
  RVA=0x09766ED0  token=0x600021D  System.Exception CannotChangeCaseLocale(System.Exception innerException)
  RVA=0x09768A24  token=0x600021E  System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode)
  RVA=0x0976A458  token=0x600021F  System.Exception TableForeignPrimaryKey()
  RVA=0x0976A3DC  token=0x6000220  System.Exception TableCannotAddToSimpleContent()
  RVA=0x097693FC  token=0x6000221  System.Exception NoTableName()
  RVA=0x097691CC  token=0x6000222  System.Exception MultipleTextOnlyColumns()
  RVA=0x09768B44  token=0x6000223  System.Exception InvalidSortString(System.String sort)
  RVA=0x09767FC8  token=0x6000224  System.Exception DuplicateTableName(System.String table)
  RVA=0x09767F70  token=0x6000225  System.Exception DuplicateTableName2(System.String table, System.String ns)
  RVA=0x0976A090  token=0x6000226  System.Exception SelfnestedDatasetConflictingName(System.String table)
  RVA=0x09767AD4  token=0x6000227  System.Exception DatasetConflictingName(System.String table)
  RVA=0x0976A374  token=0x6000228  System.Exception TableAlreadyInOtherDataSet()
  RVA=0x0976A3A8  token=0x6000229  System.Exception TableAlreadyInTheDataSet()
  RVA=0x0976A5BC  token=0x600022A  System.Exception TableOutOfRange(System.Int32 index)
  RVA=0x0976A574  token=0x600022B  System.Exception TableNotInTheDataSet(System.String table)
  RVA=0x0976A4F8  token=0x600022C  System.Exception TableInRelation()
  RVA=0x0976A48C  token=0x600022D  System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint)
  RVA=0x09766BDC  token=0x600022E  System.Exception CanNotSerializeDataTableHierarchy()
  RVA=0x09766BA8  token=0x600022F  System.Exception CanNotRemoteDataTable()
  RVA=0x09766C44  token=0x6000230  System.Exception CanNotSetRemotingFormat()
  RVA=0x09766C10  token=0x6000231  System.Exception CanNotSerializeDataTableWithEmptyName()
  RVA=0x0976A52C  token=0x6000232  System.Exception TableNotFound(System.String tableName)
  RVA=0x0976680C  token=0x6000233  System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type)
  RVA=0x09768B8C  token=0x6000234  System.Exception InvalidStorageType(System.TypeCode typecode)
  RVA=0x0976973C  token=0x6000235  System.Exception RangeArgument(System.Int32 min, System.Int32 max)
  RVA=0x09769564  token=0x6000236  System.Exception NullRange()
  RVA=0x097692B0  token=0x6000237  System.Exception NegativeMinimumCapacity()
  RVA=0x09769690  token=0x6000238  System.Exception ProblematicChars(System.Char charValue)
  RVA=0x0976A340  token=0x6000239  System.Exception StorageSetFailed()
  RVA=0x0976A30C  token=0x600023A  System.Exception SimpleTypeNotSupported()
  RVA=0x09769098  token=0x600023B  System.Exception MissingAttribute(System.String attribute)
  RVA=0x09769040  token=0x600023C  System.Exception MissingAttribute(System.String element, System.String attribute)
  RVA=0x09768788  token=0x600023D  System.Exception InvalidAttributeValue(System.String name, System.String value)
  RVA=0x09766944  token=0x600023E  System.Exception AttributeValues(System.String name, System.String value1, System.String value2)
  RVA=0x09768044  token=0x600023F  System.Exception ElementTypeNotFound(System.String name)
  RVA=0x09769BC0  token=0x6000240  System.Exception RelationParentNameMissing(System.String rel)
  RVA=0x09769968  token=0x6000241  System.Exception RelationChildNameMissing(System.String rel)
  RVA=0x09769C08  token=0x6000242  System.Exception RelationTableKeyMissing(System.String rel)
  RVA=0x09769920  token=0x6000243  System.Exception RelationChildKeyMissing(System.String rel)
  RVA=0x0976A8E4  token=0x6000244  System.Exception UndefinedDatatype(System.String name)
  RVA=0x09767B1C  token=0x6000245  System.Exception DatatypeNotDefined()
  RVA=0x0976900C  token=0x6000246  System.Exception MismatchKeyLength()
  RVA=0x097688D0  token=0x6000247  System.Exception InvalidField(System.String name)
  RVA=0x09768AFC  token=0x6000248  System.Exception InvalidSelector(System.String name)
  RVA=0x09767540  token=0x6000249  System.Exception CircularComplexType(System.String name)
  RVA=0x09766FAC  token=0x600024A  System.Exception CannotInstantiateAbstract(System.String name)
  RVA=0x09768918  token=0x600024B  System.Exception InvalidKey(System.String name)
  RVA=0x09767DC0  token=0x600024C  System.Exception DiffgramMissingTable(System.String name)
  RVA=0x09767D8C  token=0x600024D  System.Exception DiffgramMissingSQL()
  RVA=0x09767E50  token=0x600024E  System.Exception DuplicateConstraintRead(System.String str)
  RVA=0x09767704  token=0x600024F  System.Exception ColumnTypeConflict(System.String name)
  RVA=0x09766F54  token=0x6000250  System.Exception CannotConvert(System.String name, System.String type)
  RVA=0x097690E0  token=0x6000251  System.Exception MissingRefer(System.String name)
  RVA=0x097689DC  token=0x6000252  System.Exception InvalidPrefix(System.String name)
  RVA=0x09766B74  token=0x6000253  System.Exception CanNotDeserializeObjectType()
  RVA=0x09768C00  token=0x6000254  System.Exception IsDataSetAttributeMissingInSchema()
  RVA=0x0976A724  token=0x6000255  System.Exception TooManyIsDataSetAtributeInSchema()
  RVA=0x097692E4  token=0x6000256  System.Exception NestedCircular(System.String name)
  RVA=0x09769150  token=0x6000257  System.Exception MultipleParentRows(System.String tableQName)
  RVA=0x09769648  token=0x6000258  System.Exception PolymorphismNotSupported(System.String typeName)
  RVA=0x09767AA0  token=0x6000259  System.Exception DataTableInferenceNotSupported()
  RVA=0x0976A6D4  token=0x600025A  System.Void ThrowMultipleTargetConverter(System.Exception innerException)
  RVA=0x09767EE0  token=0x600025B  System.Exception DuplicateDeclaration(System.String name)
  RVA=0x0976840C  token=0x600025C  System.Exception FoundEntity()
  RVA=0x09768FBC  token=0x600025D  System.Exception MergeFailed(System.String name)
  RVA=0x097679A0  token=0x600025E  System.Exception ConvertFailed(System.Type type1, System.Type type2)
  RVA=0x09768878  token=0x600025F  System.Exception InvalidDuplicateNamedSimpleTypeDelaration(System.String stName, System.String errorStr)
  RVA=0x09768720  token=0x6000260  System.Exception InternalRBTreeError(System.Data.RBTreeError internalError)
  RVA=0x097680F4  token=0x6000261  System.Exception EnumeratorModified()
END_CLASS

CLASS: System.Data.DataKey
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x18
FIELDS:
  private   readonly System.Data.DataColumn[]        _columns  // 0x10
PROPERTIES:
  ColumnsReference  get=0x020C61B0
  HasValue  get=0x022B4F90
  Table  get=0x097637C8
METHODS:
  RVA=0x097635A0  token=0x6000262  System.Void .ctor(System.Data.DataColumn[] columns, System.Boolean copyColumns)
  RVA=0x09762EC8  token=0x6000266  System.Void CheckState()
  RVA=0x09763050  token=0x6000267  System.Boolean ColumnsEqual(System.Data.DataKey key)
  RVA=0x09762FB8  token=0x6000268  System.Boolean ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2)
  RVA=0x0976305C  token=0x6000269  System.Boolean ContainsColumn(System.Data.DataColumn column)
  RVA=0x09763214  token=0x600026A  System.Int32 GetHashCode()
  RVA=0x09763120  token=0x600026B  System.Boolean Equals(System.Object value)
  RVA=0x097630A0  token=0x600026C  System.Boolean Equals(System.Data.DataKey value)
  RVA=0x09763174  token=0x600026D  System.String[] GetColumnNames()
  RVA=0x09763264  token=0x600026E  System.Data.IndexField[] GetIndexDesc()
  RVA=0x0976332C  token=0x600026F  System.Object[] GetKeyValues(System.Int32 record)
  RVA=0x09763464  token=0x6000270  System.Data.Index GetSortIndex()
  RVA=0x09763400  token=0x6000271  System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates)
  RVA=0x09763474  token=0x6000272  System.Boolean RecordsEqual(System.Int32 record1, System.Int32 record2)
  RVA=0x097634F0  token=0x6000273  System.Data.DataColumn[] ToArray()
END_CLASS

CLASS: System.Data.DataRelation
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x88
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.PropertyCollection  _extendedProperties  // 0x18
  private           System.String                   _relationName  // 0x20
  private           System.Data.DataKey             _childKey  // 0x28
  private           System.Data.DataKey             _parentKey  // 0x30
  private           System.Data.UniqueConstraint    _parentKeyConstraint  // 0x38
  private           System.Data.ForeignKeyConstraint_childKeyConstraint  // 0x40
  private           System.String[]                 _parentColumnNames  // 0x48
  private           System.String[]                 _childColumnNames  // 0x50
  private           System.String                   _parentTableName  // 0x58
  private           System.String                   _childTableName  // 0x60
  private           System.String                   _parentTableNamespace  // 0x68
  private           System.String                   _childTableNamespace  // 0x70
  private           System.Boolean                  _nested  // 0x78
  private           System.Boolean                  _createConstraints  // 0x79
  private           System.Boolean                  _checkMultipleNested  // 0x7a
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x7c
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0x80
PROPERTIES:
  ChildColumns  get=0x09765904
  ChildColumnsReference  get=0x097658E8
  ChildKey  get=0x097658E8
  ChildTable  get=0x09765940
  DataSet  get=0x09765960
  ParentColumnNames  get=0x09765A0C
  ChildColumnNames  get=0x097658DC
  ParentColumns  get=0x09765A18
  ParentColumnsReference  get=0x01003830
  ParentKey  get=0x09765A54
  ParentTable  get=0x09765A70
  RelationName  get=0x0976504C
  Nested  get=0x097659F0  set=0x09765A90
  ParentKeyConstraint  get=0x09765A38
  ChildKeyConstraint  get=0x09765924
  ExtendedProperties  get=0x0976597C
  CheckMultipleNested  get=0x03D51AF0  set=0x03D51B50
  ObjectID  get=0x03D4EC90
METHODS:
  RVA=0x09765408  token=0x6000274  System.Void .ctor(System.String relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, System.Boolean createConstraints)
  RVA=0x097656A4  token=0x6000275  System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  RVA=0x097655E0  token=0x6000276  System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints)
  RVA=0x097657E0  token=0x6000277  System.Void .ctor(System.String relationName, System.String parentTableName, System.String childTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested)
  RVA=0x097656C0  token=0x6000278  System.Void .ctor(System.String relationName, System.String parentTableName, System.String parentTableNamespace, System.String childTableName, System.String childTableNamespace, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested)
  RVA=0x09764E84  token=0x6000280  System.Boolean IsKeyNull(System.Object[] values)
  RVA=0x09764A54  token=0x6000281  System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version)
  RVA=0x09764C48  token=0x6000282  System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version)
  RVA=0x09764AF0  token=0x6000283  System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version)
  RVA=0x09765038  token=0x6000284  System.Void SetDataSet(System.Data.DataSet dataSet)
  RVA=0x097637F8  token=0x600028A  System.Void CheckNamespaceValidityForNestedRelations(System.String ns)
  RVA=0x09763A34  token=0x600028B  System.Void CheckNestedRelations()
  RVA=0x0388FF30  token=0x600028F  System.Void SetParentKeyConstraint(System.Data.UniqueConstraint value)
  RVA=0x03CB2D80  token=0x6000294  System.Void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value)
  RVA=0x09763E7C  token=0x6000295  System.Void CheckState()
  RVA=0x09763D64  token=0x6000296  System.Void CheckStateForProperty()
  RVA=0x097646C4  token=0x6000297  System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints)
  RVA=0x097640F0  token=0x6000298  System.Data.DataRelation Clone(System.Data.DataSet destination)
  RVA=0x09764F08  token=0x6000299  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  RVA=0x09764FC0  token=0x600029A  System.Void RaisePropertyChanging(System.String name)
  RVA=0x0976504C  token=0x600029B  System.String ToString()
  RVA=0x09765068  token=0x600029C  System.Void ValidateMultipleNestedRelations()
  RVA=0x09764CE0  token=0x600029D  System.Boolean IsAutoGenerated(System.Data.DataColumn col)
END_CLASS

CLASS: System.Data.DataRelationCollection
TYPE:  abstract class
TOKEN: 0x2000026
SIZE:  0x38
EXTENDS: System.Data.InternalDataCollectionBase
FIELDS:
  private           System.Data.DataRelation        _inTransition  // 0x10
  private           System.Int32                    _defaultNameIndex  // 0x18
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangedDelegate  // 0x20
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangingDelegate  // 0x28
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x30
PROPERTIES:
  ObjectID  get=0x03D4ED20
  Item  get=-1  // abstract
  Item  get=-1  // abstract
EVENTS:
  CollectionChanged  add=add_CollectionChanged  remove=remove_CollectionChanged
METHODS:
  RVA=0x0978160C  token=0x60002A2  System.Void Add(System.Data.DataRelation relation)
  RVA=0x097813A0  token=0x60002A3  System.Void AddCore(System.Data.DataRelation relation)
  RVA=0x097818AC  token=0x60002A6  System.String AssignName()
  RVA=0x097818CC  token=0x60002A7  System.Void Clear()
  RVA=0x09781B08  token=0x60002A8  System.Boolean Contains(System.String name)
  RVA=0x09781B20  token=0x60002A9  System.Int32 InternalIndexOf(System.String name)
  RVA=-1  // abstract  token=0x60002AA  System.Data.DataSet GetDataSet()
  RVA=0x09781C50  token=0x60002AB  System.String MakeName(System.Int32 index)
  RVA=0x09781CDC  token=0x60002AC  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x09781D8C  token=0x60002AD  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x09781E3C  token=0x60002AE  System.Void RegisterName(System.String name)
  RVA=0x097821E4  token=0x60002AF  System.Void Remove(System.Data.DataRelation relation)
  RVA=0x09781FD4  token=0x60002B0  System.Void RemoveAt(System.Int32 index)
  RVA=0x09782050  token=0x60002B1  System.Void RemoveCore(System.Data.DataRelation relation)
  RVA=0x097824AC  token=0x60002B2  System.Void UnregisterName(System.String name)
  RVA=0x097825C0  token=0x60002B3  System.Void .ctor()
END_CLASS

CLASS: System.Data.DataRelationPropertyDescriptor
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x90
EXTENDS: System.ComponentModel.PropertyDescriptor
FIELDS:
  private   readonly System.Data.DataRelation        <Relation>k__BackingField  // 0x88
PROPERTIES:
  Relation  get=0x03D4EA60
  ComponentType  get=0x09782938
  IsReadOnly  get=0x0115F4C0
  PropertyType  get=0x09782988
METHODS:
  RVA=0x097828E4  token=0x60002C8  System.Void .ctor(System.Data.DataRelation dataRelation)
  RVA=0x0978280C  token=0x60002CD  System.Boolean Equals(System.Object other)
  RVA=0x0975C924  token=0x60002CE  System.Int32 GetHashCode()
  RVA=0x0115F4C0  token=0x60002CF  System.Boolean CanResetValue(System.Object component)
  RVA=0x0978286C  token=0x60002D0  System.Object GetValue(System.Object component)
  RVA=0x0350B670  token=0x60002D1  System.Void ResetValue(System.Object component)
  RVA=0x0350B670  token=0x60002D2  System.Void SetValue(System.Object component, System.Object value)
  RVA=0x0115F4C0  token=0x60002D3  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: System.Data.DataRow
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x60
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.DataColumnCollection_columns  // 0x18
  private           System.Int32                    _oldRecord  // 0x20
  private           System.Int32                    _newRecord  // 0x24
  private           System.Int32                    _tempRecord  // 0x28
  private           System.Int64                    _rowID  // 0x30
  private           System.Data.DataRowAction       _action  // 0x38
  private           System.Boolean                  _inChangingEvent  // 0x3c
  private           System.Boolean                  _inDeletingEvent  // 0x3d
  private           System.Boolean                  _inCascade  // 0x3e
  private           System.Data.DataColumn          _lastChangedColumn  // 0x40
  private           System.Int32                    _countColumnChange  // 0x48
  private           System.Data.DataError           _error  // 0x50
  private           System.Int32                    _rbTreeNodeId  // 0x58
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x5c
PROPERTIES:
  LastChangedColumn  get=0x09785E0C  set=0x0978677C
  HasPropertyChanged  get=0x09785D6C
  RBTreeNodeId  get=0x03D4EF00  set=0x0978678C
  RowError  get=0x09785E1C  set=0x09786824
  rowID  get=0x01003830  set=0x0978694C
  RowState  get=0x09785E6C
  Table  get=0x020B7B20
  Item  set=0x097863FC
  Item  get=0x09785DC8  set=0x097863FC
  Item  get=0x09785DC8
  ItemArray  set=0x09785FB8
  HasErrors  get=0x09785D54
METHODS:
  RVA=0x09785CAC  token=0x60002D4  System.Void .ctor(System.Data.DataRowBuilder builder)
  RVA=0x09785398  token=0x60002DC  System.Void RowErrorChanged()
  RVA=0x09783DB8  token=0x60002E1  System.Void CheckForLoops(System.Data.DataRelation rel)
  RVA=0x09784734  token=0x60002E2  System.Int32 GetNestedParentCount()
  RVA=0x097838C4  token=0x60002E8  System.Void AcceptChanges()
  RVA=0x09783CC8  token=0x60002E9  System.Void BeginEdit()
  RVA=0x09783C0C  token=0x60002EA  System.Boolean BeginEditInternal()
  RVA=0x09783CD0  token=0x60002EB  System.Void CancelEdit()
  RVA=0x09783D2C  token=0x60002EC  System.Void CheckColumn(System.Data.DataColumn column)
  RVA=0x09783E90  token=0x60002ED  System.Void CheckInTable()
  RVA=0x09784208  token=0x60002EE  System.Void Delete()
  RVA=0x09784260  token=0x60002EF  System.Void EndEdit()
  RVA=0x09785600  token=0x60002F0  System.Void SetColumnError(System.Int32 columnIndex, System.String error)
  RVA=0x097853E4  token=0x60002F1  System.Void SetColumnError(System.Data.DataColumn column, System.String error)
  RVA=0x09784470  token=0x60002F2  System.String GetColumnError(System.Data.DataColumn column)
  RVA=0x09783F00  token=0x60002F3  System.Void ClearErrors()
  RVA=0x09783ECC  token=0x60002F4  System.Void ClearError(System.Data.DataColumn column)
  RVA=0x09784564  token=0x60002F6  System.Data.DataColumn[] GetColumnsInError()
  RVA=0x09784334  token=0x60002F7  System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation)
  RVA=0x09784344  token=0x60002F8  System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  RVA=0x097845FC  token=0x60002F9  System.Data.DataColumn GetDataColumn(System.String columnName)
  RVA=0x097849E8  token=0x60002FA  System.Data.DataRow GetParentRow(System.Data.DataRelation relation)
  RVA=0x097848CC  token=0x60002FB  System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  RVA=0x097847E0  token=0x60002FC  System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version)
  RVA=0x09784B24  token=0x60002FD  System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation)
  RVA=0x097849F8  token=0x60002FE  System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  RVA=0x09784554  token=0x60002FF  System.Object[] GetColumnValues(System.Data.DataColumn[] columns)
  RVA=0x0978450C  token=0x6000300  System.Object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version)
  RVA=0x097846E8  token=0x6000301  System.Object[] GetKeyValues(System.Data.DataKey key)
  RVA=0x0978470C  token=0x6000302  System.Object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version)
  RVA=0x097845BC  token=0x6000303  System.Int32 GetCurrentRecordNo()
  RVA=0x0978466C  token=0x6000304  System.Int32 GetDefaultRecord()
  RVA=0x0978488C  token=0x6000305  System.Int32 GetOriginalRecordNo()
  RVA=0x09784B34  token=0x6000306  System.Int32 GetProposedRecordNo()
  RVA=0x09784B74  token=0x6000307  System.Int32 GetRecordFromVersion(System.Data.DataRowVersion version)
  RVA=0x097846C0  token=0x6000308  System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState)
  RVA=0x09784BF4  token=0x6000309  System.Data.DataViewRowState GetRecordState(System.Int32 record)
  RVA=0x09784C38  token=0x600030A  System.Boolean HasKeyChanged(System.Data.DataKey key)
  RVA=0x09784C5C  token=0x600030B  System.Boolean HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2)
  RVA=0x09784CDC  token=0x600030C  System.Boolean HasVersion(System.Data.DataRowVersion version)
  RVA=0x09784D4C  token=0x600030D  System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns)
  RVA=0x09784D70  token=0x600030E  System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2)
  RVA=0x09784E04  token=0x600030F  System.Void RejectChanges()
  RVA=0x09785378  token=0x6000310  System.Void ResetLastChangedColumn()
  RVA=0x09785678  token=0x6000311  System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues)
  RVA=0x09785770  token=0x6000312  System.Void SetNestedParentRow(System.Data.DataRow parentRow, System.Boolean setNonNested)
  RVA=0x097859E0  token=0x6000313  System.Void SetParentRowToDBNull()
  RVA=0x09785B58  token=0x6000314  System.Void SetParentRowToDBNull(System.Data.DataRelation relation)
  RVA=0x09783F30  token=0x6000315  System.Int32 CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, System.Int32 storeIndex)
END_CLASS

CLASS: System.Data.DataRowBuilder
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x20
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private           System.Int32                    _record  // 0x18
METHODS:
  RVA=0x02738A30  token=0x6000316  System.Void .ctor(System.Data.DataTable table, System.Int32 record)
END_CLASS

CLASS: System.Data.DataRowAction
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowAction       Nothing  // const
  public    static  System.Data.DataRowAction       Delete  // const
  public    static  System.Data.DataRowAction       Change  // const
  public    static  System.Data.DataRowAction       Rollback  // const
  public    static  System.Data.DataRowAction       Commit  // const
  public    static  System.Data.DataRowAction       Add  // const
  public    static  System.Data.DataRowAction       ChangeOriginal  // const
  public    static  System.Data.DataRowAction       ChangeCurrentAndOriginal  // const
METHODS:
END_CLASS

CLASS: System.Data.DataRowChangeEventArgs
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x20
EXTENDS: System.EventArgs
FIELDS:
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x10
  private   readonly System.Data.DataRowAction       <Action>k__BackingField  // 0x18
METHODS:
  RVA=0x097829D8  token=0x6000317  System.Void .ctor(System.Data.DataRow row, System.Data.DataRowAction action)
END_CLASS

CLASS: System.Data.DataRowChangeEventHandler
TYPE:  sealed class
TOKEN: 0x200002E
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x6000318  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000319  System.Void Invoke(System.Object sender, System.Data.DataRowChangeEventArgs e)
END_CLASS

CLASS: System.Data.DataRowCollection
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x28
EXTENDS: System.Data.InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.DataRowCollection.DataRowTree_list  // 0x18
  private           System.Int32                    _nullInList  // 0x20
PROPERTIES:
  Count  get=0x09783084
  Item  get=0x097830C4
METHODS:
  RVA=0x09782FEC  token=0x600031A  System.Void .ctor(System.Data.DataTable table)
  RVA=0x09782AA8  token=0x600031D  System.Void Add(System.Data.DataRow row)
  RVA=0x09782D54  token=0x600031E  System.Void DiffInsertAt(System.Data.DataRow row, System.Int32 pos)
  RVA=0x09782F68  token=0x600031F  System.Int32 IndexOf(System.Data.DataRow row)
  RVA=0x09782A38  token=0x6000320  System.Data.DataRow AddWithColumnEvents(System.Object[] values)
  RVA=0x09782AD0  token=0x6000321  System.Void ArrayAdd(System.Data.DataRow row)
  RVA=0x09782B80  token=0x6000322  System.Void ArrayInsert(System.Data.DataRow row, System.Int32 pos)
  RVA=0x09782B38  token=0x6000323  System.Void ArrayClear()
  RVA=0x09782BF8  token=0x6000324  System.Void ArrayRemove(System.Data.DataRow row)
  RVA=0x09782CF0  token=0x6000325  System.Void CopyTo(System.Array ar, System.Int32 index)
  RVA=0x09782C8C  token=0x6000326  System.Void CopyTo(System.Data.DataRow[] array, System.Int32 index)
  RVA=0x09782F20  token=0x6000327  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: System.Data.DataRowCreatedEventHandler
TYPE:  sealed class
TOKEN: 0x2000031
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x600032B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x600032C  System.Void Invoke(System.Object sender, System.Data.DataRow r)
END_CLASS

CLASS: System.Data.DataSetClearEventhandler
TYPE:  sealed class
TOKEN: 0x2000032
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x600032D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x600032E  System.Void Invoke(System.Object sender, System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DataRowState
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowState        Detached  // const
  public    static  System.Data.DataRowState        Unchanged  // const
  public    static  System.Data.DataRowState        Added  // const
  public    static  System.Data.DataRowState        Deleted  // const
  public    static  System.Data.DataRowState        Modified  // const
METHODS:
END_CLASS

CLASS: System.Data.DataRowVersion
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowVersion      Original  // const
  public    static  System.Data.DataRowVersion      Current  // const
  public    static  System.Data.DataRowVersion      Proposed  // const
  public    static  System.Data.DataRowVersion      Default  // const
METHODS:
END_CLASS

CLASS: System.Data.DataRowView
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x30
IMPLEMENTS: System.ComponentModel.ICustomTypeDescriptor System.ComponentModel.INotifyPropertyChanged
FIELDS:
  private   readonly System.Data.DataView            _dataView  // 0x10
  private   readonly System.Data.DataRow             _row  // 0x18
  private           System.Boolean                  _delayBeginEdit  // 0x20
  private   static readonly System.ComponentModel.PropertyDescriptorCollections_zeroPropertyDescriptorCollection  // static @ 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x28
PROPERTIES:
  DataView  get=0x020B7B20
  RowVersionDefault  get=0x09783800
  Row  get=0x01041090
  IsNew  get=0x097837DC
EVENTS:
  PropertyChanged  add=add_PropertyChanged  remove=remove_PropertyChanged
METHODS:
  RVA=0x02676770  token=0x600032F  System.Void .ctor(System.Data.DataView dataView, System.Data.DataRow row)
  RVA=0x0232CE30  token=0x6000330  System.Boolean Equals(System.Object other)
  RVA=0x03D4A220  token=0x6000331  System.Int32 GetHashCode()
  RVA=0x0978346C  token=0x6000334  System.Int32 GetRecord()
  RVA=0x0978349C  token=0x6000335  System.Boolean HasRecord()
  RVA=0x0978342C  token=0x6000336  System.Object GetColumnValue(System.Data.DataColumn column)
  RVA=0x0978355C  token=0x6000337  System.Void SetColumnValue(System.Data.DataColumn column, System.Object value)
  RVA=0x09783234  token=0x6000338  System.Data.DataView CreateChildView(System.Data.DataRelation relation, System.Boolean followParent)
  RVA=0x097833D4  token=0x6000339  System.Data.DataView CreateChildView(System.Data.DataRelation relation)
  RVA=0x097833E0  token=0x600033B  System.Void EndEdit()
  RVA=0x097834CC  token=0x600033F  System.Void RaisePropertyChangedEvent(System.String propName)
  RVA=0x097835F8  token=0x6000340  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  RVA=0x01002730  token=0x6000341  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  RVA=0x092D18EC  token=0x6000342  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  RVA=0x0978364C  token=0x6000343  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  RVA=0x0339AE90  token=0x6000344  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
  RVA=0x097836C8  token=0x6000345  System.Void .cctor()
END_CLASS

CLASS: System.Data.SerializationFormat
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SerializationFormat Xml  // const
  public    static  System.Data.SerializationFormat Binary  // const
METHODS:
END_CLASS

CLASS: System.Data.DataSet
TYPE:  class
TOKEN: 0x2000037
SIZE:  0xB0
EXTENDS: System.ComponentModel.MarshalByValueComponent
IMPLEMENTS: System.Xml.Serialization.IXmlSerializable System.Runtime.Serialization.ISerializable
FIELDS:
  private           System.Data.DataViewManager     _defaultViewManager  // 0x20
  private   readonly System.Data.DataTableCollection _tableCollection  // 0x28
  private   readonly System.Data.DataRelationCollection_relationCollection  // 0x30
  private           System.Data.PropertyCollection  _extendedProperties  // 0x38
  private           System.String                   _dataSetName  // 0x40
  private           System.String                   _datasetPrefix  // 0x48
  private           System.String                   _namespaceURI  // 0x50
  private           System.Boolean                  _enforceConstraints  // 0x58
  private           System.Boolean                  _caseSensitive  // 0x59
  private           System.Globalization.CultureInfo_culture  // 0x60
  private           System.Boolean                  _cultureUserSet  // 0x68
  private           System.Boolean                  _fInReadXml  // 0x69
  private           System.Boolean                  _fInLoadDiffgram  // 0x6a
  private           System.Boolean                  _fTopLevelTable  // 0x6b
  private           System.Boolean                  _fInitInProgress  // 0x6c
  private           System.Boolean                  _fEnableCascading  // 0x6d
  private           System.Boolean                  _fIsSchemaLoading  // 0x6e
  private           System.String                   _mainTableName  // 0x70
  private           System.Data.SerializationFormat _remotingFormat  // 0x78
  private           System.Object                   _defaultViewManagerLock  // 0x80
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x88
  private   static  System.Xml.Schema.XmlSchemaComplexTypes_schemaTypeForWSDL  // static @ 0x8
  private           System.Boolean                  _useDataSetSchemaOnly  // 0x8c
  private           System.Boolean                  _udtIsWrapped  // 0x8d
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0x90
  private           System.Data.MergeFailedEventHandlerMergeFailed  // 0x98
  private           System.Data.DataRowCreatedEventHandlerDataRowCreated  // 0xa0
  private           System.Data.DataSetClearEventhandlerClearFunctionCalled  // 0xa8
PROPERTIES:
  RemotingFormat  get=0x03D4EC40  set=0x09791670
  SchemaSerializationMode  get=0x01168950
  CaseSensitive  get=0x03D589D0  set=0x09790A94
  EnforceConstraints  get=0x03D4F7E0  set=0x09790ED0
  DataSetName  get=0x03D4E2B0  set=0x09790D78
  Namespace  get=0x03D4EAF0  set=0x09791170
  Prefix  get=0x03D4EA70  set=0x09791564
  ExtendedProperties  get=0x09790A20
  Locale  get=0x03D4EB00  set=0x09791014
  Site  get=0x020B7B20
  Relations  get=0x01003830
  Tables  get=0x03D4EAC0
  MainTableName  get=0x03D4EB30  set=0x0519C3C8
  ObjectID  get=0x03D4F0B0
METHODS:
  RVA=0x097905F4  token=0x6000346  System.Void .ctor()
  RVA=0x097909F0  token=0x6000347  System.Void .ctor(System.String dataSetName)
  RVA=0x097909C8  token=0x600034B  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09790854  token=0x600034C  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean ConstructSchema)
  RVA=0x097897C8  token=0x600034D  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0350B670  token=0x600034E  System.Void InitializeDerivedDataSet()
  RVA=0x0978E144  token=0x600034F  System.Void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat)
  RVA=0x097888C4  token=0x6000350  System.Void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode)
  RVA=0x09788474  token=0x6000351  System.Void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode)
  RVA=0x09788084  token=0x6000352  System.Void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat)
  RVA=0x0978E008  token=0x6000353  System.Void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09788230  token=0x6000354  System.Void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0978E6B4  token=0x6000355  System.Void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0978893C  token=0x6000356  System.Void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09789518  token=0x6000357  System.Void FailedEnableConstraints()
  RVA=0x03D4F7F0  token=0x600035C  System.Void RestoreEnforceConstraints(System.Boolean value)
  RVA=0x09788F64  token=0x600035D  System.Void EnableConstraints()
  RVA=0x0978ECB0  token=0x6000367  System.Void SetLocaleValue(System.Globalization.CultureInfo value, System.Boolean userSet)
  RVA=0x03D4F3F0  token=0x6000368  System.Boolean ShouldSerializeLocale()
  RVA=0x09787390  token=0x600036C  System.Void Clear()
  RVA=0x09787528  token=0x600036D  System.Data.DataSet Clone()
  RVA=0x097893E8  token=0x600036E  System.Int32 EstimatedXmlStringSize()
  RVA=0x097897F4  token=0x600036F  System.String GetRemotingDiffGram(System.Data.DataTable table)
  RVA=0x09789914  token=0x6000370  System.String GetXmlSchemaForRemoting(System.Data.DataTable table)
  RVA=0x0978B4D4  token=0x6000371  System.Void ReadXmlSchema(System.Xml.XmlReader reader)
  RVA=0x0978B4E0  token=0x6000372  System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  RVA=0x09775878  token=0x6000373  System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth)
  RVA=0x0978A280  token=0x6000374  System.Void MoveToElement(System.Xml.XmlReader reader)
  RVA=0x09776FF8  token=0x6000375  System.Void ReadEndElement(System.Xml.XmlReader reader)
  RVA=0x0978A61C  token=0x6000376  System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  RVA=0x0978A500  token=0x6000377  System.Void ReadXDRSchema(System.Xml.XmlReader reader)
  RVA=0x097900C4  token=0x6000378  System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter)
  RVA=0x0978DDD8  token=0x6000379  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader)
  RVA=0x0978CD98  token=0x600037A  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Boolean denyResolving)
  RVA=0x09789A70  token=0x600037B  System.Void InferSchema(System.Xml.XmlDocument xdoc, System.String[] excludedNamespaces, System.Data.XmlReadMode mode)
  RVA=0x09789D5C  token=0x600037C  System.Boolean IsEmpty()
  RVA=0x0978A84C  token=0x600037D  System.Void ReadXmlDiffgram(System.Xml.XmlReader reader)
  RVA=0x0978BEF0  token=0x600037E  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode)
  RVA=0x0978BF0C  token=0x600037F  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving)
  RVA=0x09790338  token=0x6000380  System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode)
  RVA=0x09789EEC  token=0x6000381  System.Void Merge(System.Data.DataSet dataSet)
  RVA=0x0978A04C  token=0x6000382  System.Void Merge(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  RVA=0x0978A384  token=0x6000383  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  RVA=0x0978A320  token=0x6000384  System.Void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent)
  RVA=0x0978A3D4  token=0x6000385  System.Void RaiseMergeFailed(System.Data.DataTable table, System.String conflict, System.Data.MissingSchemaAction missingSchemaAction)
  RVA=0x0978A300  token=0x6000386  System.Void OnDataRowCreated(System.Data.DataRow row)
  RVA=0x0978A2E0  token=0x6000387  System.Void OnClearFunctionCalled(System.Data.DataTable table)
  RVA=0x0350B670  token=0x6000388  System.Void OnRemoveTable(System.Data.DataTable table)
  RVA=0x0978A3A4  token=0x6000389  System.Void OnRemovedTable(System.Data.DataTable table)
  RVA=0x0350B670  token=0x600038A  System.Void OnRemoveRelation(System.Data.DataRelation relation)
  RVA=0x0350B670  token=0x600038B  System.Void OnRemoveRelationHack(System.Data.DataRelation relation)
  RVA=0x0978A488  token=0x600038C  System.Void RaisePropertyChanging(System.String name)
  RVA=0x0978F7FC  token=0x600038D  System.Data.DataTable[] TopLevelTables()
  RVA=0x0978F808  token=0x600038E  System.Data.DataTable[] TopLevelTables(System.Boolean forSchema)
  RVA=0x0978DDE4  token=0x600038F  System.Void Reset()
  RVA=0x0978F9DC  token=0x6000390  System.Boolean ValidateCaseConstraint()
  RVA=0x0978FD28  token=0x6000391  System.Boolean ValidateLocaleConstraint()
  RVA=0x0978BC0C  token=0x6000392  System.Void ReadXmlSerializable(System.Xml.XmlReader reader)
  RVA=0x0978954C  token=0x6000393  System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x0978F4FC  token=0x6000394  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x0978F698  token=0x6000395  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x0978F7B4  token=0x6000396  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
END_CLASS

CLASS: System.Data.DataSetDateTime
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataSetDateTime     Local  // const
  public    static  System.Data.DataSetDateTime     Unspecified  // const
  public    static  System.Data.DataSetDateTime     UnspecifiedLocal  // const
  public    static  System.Data.DataSetDateTime     Utc  // const
METHODS:
END_CLASS

CLASS: System.Data.DataTable
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x228
EXTENDS: System.ComponentModel.MarshalByValueComponent
IMPLEMENTS: System.Runtime.Serialization.ISerializable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x20
  private           System.Data.DataView            _defaultView  // 0x28
  private           System.Int64                    _nextRowID  // 0x30
  private   readonly System.Data.DataRowCollection   _rowCollection  // 0x38
  private   readonly System.Data.DataColumnCollection_columnCollection  // 0x40
  private   readonly System.Data.ConstraintCollection_constraintCollection  // 0x48
  private           System.Int32                    _elementColumnCount  // 0x50
  private           System.Data.DataRelationCollection_parentRelationsCollection  // 0x58
  private           System.Data.DataRelationCollection_childRelationsCollection  // 0x60
  private   readonly System.Data.RecordManager       _recordManager  // 0x68
  private   readonly System.Collections.Generic.List<System.Data.Index>_indexes  // 0x70
  private           System.Collections.Generic.List<System.Data.Index>_shadowIndexes  // 0x78
  private           System.Int32                    _shadowCount  // 0x80
  private           System.Data.PropertyCollection  _extendedProperties  // 0x88
  private           System.String                   _tableName  // 0x90
  private           System.String                   _tableNamespace  // 0x98
  private           System.String                   _tablePrefix  // 0xa0
  private           System.Data.DataExpression      _displayExpression  // 0xa8
  private           System.Boolean                  _fNestedInDataset  // 0xb0
  private           System.Globalization.CultureInfo_culture  // 0xb8
  private           System.Boolean                  _cultureUserSet  // 0xc0
  private           System.Globalization.CompareInfo_compareInfo  // 0xc8
  private           System.Globalization.CompareOptions_compareFlags  // 0xd0
  private           System.IFormatProvider          _formatProvider  // 0xd8
  private           System.StringComparer           _hashCodeProvider  // 0xe0
  private           System.Boolean                  _caseSensitive  // 0xe8
  private           System.Boolean                  _caseSensitiveUserSet  // 0xe9
  private           System.String                   _encodedTableName  // 0xf0
  private           System.Data.DataColumn          _xmlText  // 0xf8
  private           System.Data.DataColumn          _colUnique  // 0x100
  private           System.Decimal                  _minOccurs  // 0x108
  private           System.Decimal                  _maxOccurs  // 0x118
  private           System.Boolean                  _repeatableElement  // 0x128
  private           System.Object                   _typeName  // 0x130
  private           System.Data.UniqueConstraint    _primaryKey  // 0x138
  private           System.Data.IndexField[]        _primaryIndex  // 0x140
  private           System.Data.DataColumn[]        _delayedSetPrimaryKey  // 0x148
  private           System.Data.Index               _loadIndex  // 0x150
  private           System.Data.Index               _loadIndexwithOriginalAdded  // 0x158
  private           System.Data.Index               _loadIndexwithCurrentDeleted  // 0x160
  private           System.Int32                    _suspendIndexEvents  // 0x168
  private           System.Boolean                  _inDataLoad  // 0x16c
  private           System.Boolean                  _schemaLoading  // 0x16d
  private           System.Boolean                  _enforceConstraints  // 0x16e
  private           System.Boolean                  _suspendEnforceConstraints  // 0x16f
  protected internal        System.Boolean                  fInitInProgress  // 0x170
  private           System.Boolean                  _inLoad  // 0x171
  private           System.Boolean                  _fInLoadDiffgram  // 0x172
  private           System.Byte                     _isTypedDataTable  // 0x173
  private           System.Data.DataRow[]           _emptyDataRowArray  // 0x178
  private           System.ComponentModel.PropertyDescriptorCollection_propertyDescriptorCollectionCache  // 0x180
  private           System.Data.DataRelation[]      _nestedParentRelations  // 0x188
  private           System.Collections.Generic.List<System.Data.DataColumn>_dependentColumns  // 0x190
  private           System.Boolean                  _mergingData  // 0x198
  private           System.Data.DataRowChangeEventHandler_onRowChangedDelegate  // 0x1a0
  private           System.Data.DataRowChangeEventHandler_onRowChangingDelegate  // 0x1a8
  private           System.Data.DataRowChangeEventHandler_onRowDeletingDelegate  // 0x1b0
  private           System.Data.DataRowChangeEventHandler_onRowDeletedDelegate  // 0x1b8
  private           System.Data.DataColumnChangeEventHandler_onColumnChangedDelegate  // 0x1c0
  private           System.Data.DataColumnChangeEventHandler_onColumnChangingDelegate  // 0x1c8
  private           System.Data.DataTableClearEventHandler_onTableClearingDelegate  // 0x1d0
  private           System.Data.DataTableClearEventHandler_onTableClearedDelegate  // 0x1d8
  private           System.Data.DataTableNewRowEventHandler_onTableNewRowDelegate  // 0x1e0
  private           System.ComponentModel.PropertyChangedEventHandler_onPropertyChangingDelegate  // 0x1e8
  private   readonly System.Data.DataRowBuilder      _rowBuilder  // 0x1f0
  private   readonly System.Collections.Generic.List<System.Data.DataView>_delayedViews  // 0x1f8
  private   readonly System.Collections.Generic.List<System.Data.DataViewListener>_dataViewListeners  // 0x200
  private           System.Collections.Hashtable    _rowDiffId  // 0x208
  private   readonly System.Threading.ReaderWriterLockSlim_indexesLock  // 0x210
  private           System.Int32                    _ukColumnPositionForInference  // 0x218
  private           System.Data.SerializationFormat _remotingFormat  // 0x21c
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x220
PROPERTIES:
  CaseSensitive  get=0x03D554A0  set=0x0977FE94
  AreIndexEventsSuspended  get=0x0977F288
  IsTypedDataTable  get=0x0977F560
  SelfNested  get=0x0977FB80
  LiveIndexes  get=0x0977F5F4
  RemotingFormat  get=0x03D75460  set=0x09780C08
  UKColumnPositionForInference  get=0x03D5A730  set=0x03D5A740
  ChildRelations  get=0x0977F294
  Columns  get=0x03D4E2B0
  CompareInfo  get=0x0977F30C
  Constraints  get=0x03D4EA70
  DataSet  get=0x03D4EB40
  DisplayExpressionInternal  get=0x0977F35C
  EnforceConstraints  get=0x0977F430  set=0x0977FF94
  SuspendEnforceConstraints  get=0x03D75480  set=0x03D754B0
  ExtendedProperties  get=0x0977F454
  FormatProvider  get=0x0977F4D0
  Locale  get=0x03D4E750  set=0x0977FFD0
  MinimumCapacity  get=0x0977F688  set=0x0978044C
  RecordCapacity  get=0x0977FAE8
  ElementColumnCount  get=0x03D4EED0  set=0x0977FF4C
  ParentRelations  get=0x0977FA10
  MergingData  get=0x03D5AF90  set=0x03D5B0F0
  NestedParentRelations  get=0x03D56AF0
  SchemaLoading  get=0x03D75470
  NestedParentsCount  get=0x0977F75C
  PrimaryKey  get=0x0977FA88  set=0x09780870
  Rows  get=0x03D4E2A0
  TableName  get=0x03D4EA90  set=0x09780C7C
  EncodedTableName  get=0x0977F3B8
  Namespace  get=0x0977F6A4  set=0x09780478
  Prefix  get=0x03D4EA80  set=0x09780720
  XmlText  get=0x03D50160  set=0x09781270
  MaxOccurs  get=0x03D75430  set=0x03D75490
  MinOccurs  get=0x03D75440  set=0x03D754A0
  Site  get=0x020B7B20
  NeedColumnChangeEvents  get=0x0977F728
  TypeName  get=0x0977FE28  set=0x04275CCC
  RowDiffId  get=0x0977FB04
  ObjectID  get=0x03D75450
METHODS:
  RVA=0x0977EC04  token=0x600039A  System.Void .ctor()
  RVA=0x0977F0C0  token=0x600039B  System.Void .ctor(System.String tableName)
  RVA=0x0977F12C  token=0x600039C  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09773860  token=0x600039D  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0977B1FC  token=0x600039E  System.Void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat)
  RVA=0x0976F820  token=0x600039F  System.Void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat)
  RVA=0x0977BBB0  token=0x60003A0  System.Void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable)
  RVA=0x097704C8  token=0x60003A1  System.Void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable)
  RVA=0x0977AC60  token=0x60003A2  System.Void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints)
  RVA=0x0976EF08  token=0x60003A3  System.Void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints)
  RVA=0x0977B4D8  token=0x60003A4  System.Void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  RVA=0x0976FB68  token=0x60003A5  System.Void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  RVA=0x0977B614  token=0x60003A6  System.Void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  RVA=0x0976FCB0  token=0x60003A7  System.Void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  RVA=0x0976E638  token=0x60003A8  System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, System.Int32 bitIndex)
  RVA=0x09773B34  token=0x60003A9  System.Void GetRowAndColumnErrors(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors)
  RVA=0x0976E410  token=0x60003AA  System.Void ConvertToRowError(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors)
  RVA=0x0977A794  token=0x60003AE  System.Void RestoreIndexEvents(System.Boolean forceReset)
  RVA=0x0977E21C  token=0x60003AF  System.Void SuspendIndexEvents()
  RVA=0x0977C7C0  token=0x60003B1  System.Boolean SetCaseSensitiveValue(System.Boolean isCaseSensitive, System.Boolean userSet, System.Boolean resetIndexes)
  RVA=0x03D58EB0  token=0x60003B2  System.Boolean ShouldSerializeCaseSensitive()
  RVA=0x0977A3C8  token=0x60003BD  System.Void ResetConstraints()
  RVA=0x0977CA98  token=0x60003BF  System.Void SetDataSet(System.Data.DataSet dataSet)
  RVA=0x097714D8  token=0x60003C5  System.Void EnableConstraints()
  RVA=0x0977CBB4  token=0x60003CA  System.Boolean SetLocaleValue(System.Globalization.CultureInfo culture, System.Boolean userSet, System.Boolean resetIndexes)
  RVA=0x03D583F0  token=0x60003CB  System.Boolean ShouldSerializeLocale()
  RVA=0x0976BCF4  token=0x60003D6  System.Void CacheNestedParent()
  RVA=0x09772DA0  token=0x60003D7  System.Data.DataRelation[] FindNestedParentRelations()
  RVA=0x0977367C  token=0x60003DF  System.String GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables)
  RVA=0x09774EB8  token=0x60003E2  System.Boolean IsNamespaceInherited()
  RVA=0x0976BDE4  token=0x60003E3  System.Void CheckCascadingNamespaceConflict(System.String realNamespace)
  RVA=0x0976C774  token=0x60003E4  System.Void CheckNamespaceValidityForNestedRelations(System.String realNamespace)
  RVA=0x0976C56C  token=0x60003E5  System.Void CheckNamespaceValidityForNestedParentRelations(System.String ns, System.Data.DataTable parentTable)
  RVA=0x09771198  token=0x60003E6  System.Void DoRaiseNamespaceChange()
  RVA=0x0977CB38  token=0x60003EF  System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues, System.Int32 record)
  RVA=0x09772CC4  token=0x60003F0  System.Data.DataRow FindByIndex(System.Data.Index ndx, System.Object[] key)
  RVA=0x09772D40  token=0x60003F1  System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx)
  RVA=0x0977D11C  token=0x60003F2  System.Void SetMergeRecords(System.Data.DataRow row, System.Int32 newRecord, System.Int32 oldRecord, System.Data.DataRowAction action)
  RVA=0x09774F1C  token=0x60003F3  System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, System.Boolean preserveChanges, System.Data.Index idxSearch)
  RVA=0x0976E914  token=0x60003F4  System.Data.DataTable CreateInstance()
  RVA=0x0976E164  token=0x60003F5  System.Data.DataTable Clone()
  RVA=0x0976DFA8  token=0x60003F6  System.Data.DataTable Clone(System.Data.DataSet cloneDS)
  RVA=0x09774010  token=0x60003F7  System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable)
  RVA=0x0976D13C  token=0x60003F8  System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap)
  RVA=0x0976D4C8  token=0x60003F9  System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, System.Boolean skipExpressionColumns)
  RVA=0x0976BA4C  token=0x60003FB  System.Void AddRow(System.Data.DataRow row, System.Int32 proposedID)
  RVA=0x09774CF4  token=0x60003FC  System.Void InsertRow(System.Data.DataRow row, System.Int32 proposedID, System.Int32 pos)
  RVA=0x09774844  token=0x60003FD  System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID, System.Int32 pos, System.Boolean fireEvent)
  RVA=0x0976CB04  token=0x60003FE  System.Void CheckNotModifying(System.Data.DataRow row)
  RVA=0x0976CB30  token=0x60003FF  System.Void Clear()
  RVA=0x0976CB3C  token=0x6000400  System.Void Clear(System.Boolean clearAll)
  RVA=0x0976BD1C  token=0x6000401  System.Void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=0x0976E170  token=0x6000402  System.Void CommitRow(System.Data.DataRow row)
  RVA=0x0976E340  token=0x6000403  System.Int32 Compare(System.String s1, System.String s2)
  RVA=0x0976E200  token=0x6000404  System.Int32 Compare(System.String s1, System.String s2, System.Globalization.CompareInfo comparer)
  RVA=0x09774204  token=0x6000405  System.Int32 IndexOf(System.String s1, System.String s2)
  RVA=0x09774EC4  token=0x6000406  System.Boolean IsSuffix(System.String s1, System.String s2)
  RVA=0x0976E35C  token=0x6000407  System.Object Compute(System.String expression, System.String filter)
  RVA=0x0976EEA4  token=0x6000408  System.Void DeleteRow(System.Data.DataRow row)
  RVA=0x09772FFC  token=0x6000409  System.String FormatSortString(System.Data.IndexField[] indexDesc)
  RVA=0x097730F8  token=0x600040A  System.Void FreeRecord(System.Int32& record)
  RVA=0x09773630  token=0x600040B  System.Data.Index GetIndex(System.String sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x09773334  token=0x600040C  System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x03D56BB0  token=0x600040D  System.Collections.Generic.List<System.Data.DataViewListener> GetListeners()
  RVA=0x09773F3C  token=0x600040E  System.Int32 GetSpecialHashCode(System.String name)
  RVA=0x097743D0  token=0x600040F  System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID)
  RVA=0x09775964  token=0x6000410  System.Int32 NewRecord()
  RVA=0x09775D08  token=0x6000411  System.Int32 NewUninitializedRecord()
  RVA=0x09775974  token=0x6000412  System.Int32 NewRecord(System.Int32 sourceRecord)
  RVA=0x09775908  token=0x6000413  System.Data.DataRow NewEmptyRow()
  RVA=0x09775D28  token=0x6000414  System.Data.DataRow NewUninitializedRow()
  RVA=0x09775CCC  token=0x6000415  System.Data.DataRow NewRow()
  RVA=0x0976E6E0  token=0x6000416  System.Data.DataRow CreateEmptyRow()
  RVA=0x09775B58  token=0x6000417  System.Void NewRowCreated(System.Data.DataRow row)
  RVA=0x09775C3C  token=0x6000418  System.Data.DataRow NewRow(System.Int32 record)
  RVA=0x09775BDC  token=0x6000419  System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder)
  RVA=0x09773D50  token=0x600041A  System.Type GetRowType()
  RVA=0x09775A54  token=0x600041B  System.Data.DataRow[] NewRowArray(System.Int32 size)
  RVA=0x09775E04  token=0x600041D  System.Void OnColumnChanging(System.Data.DataColumnChangeEventArgs e)
  RVA=0x09775D4C  token=0x600041E  System.Void OnColumnChanged(System.Data.DataColumnChangeEventArgs e)
  RVA=0x09775EBC  token=0x600041F  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  RVA=0x0350B670  token=0x6000420  System.Void OnRemoveColumnInternal(System.Data.DataColumn column)
  RVA=0x0350B670  token=0x6000421  System.Void OnRemoveColumn(System.Data.DataColumn column)
  RVA=0x09775F74  token=0x6000422  System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  RVA=0x097760D8  token=0x6000423  System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  RVA=0x09776020  token=0x6000424  System.Void OnRowChanged(System.Data.DataRowChangeEventArgs e)
  RVA=0x09776184  token=0x6000425  System.Void OnRowChanging(System.Data.DataRowChangeEventArgs e)
  RVA=0x097762F4  token=0x6000426  System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs e)
  RVA=0x0977623C  token=0x6000427  System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs e)
  RVA=0x097763AC  token=0x6000428  System.Void OnTableCleared(System.Data.DataTableClearEventArgs e)
  RVA=0x09776464  token=0x6000429  System.Void OnTableClearing(System.Data.DataTableClearEventArgs e)
  RVA=0x0977651C  token=0x600042A  System.Void OnTableNewRow(System.Data.DataTableNewRowEventArgs e)
  RVA=0x097765D4  token=0x600042B  System.Data.IndexField[] ParseSortString(System.String sortString)
  RVA=0x097768E4  token=0x600042C  System.Void RaisePropertyChanging(System.String name)
  RVA=0x09779A84  token=0x600042D  System.Void RecordChanged(System.Int32 record)
  RVA=0x09779B9C  token=0x600042E  System.Void RecordChanged(System.Int32[] oldIndex, System.Int32[] newIndex)
  RVA=0x09779EB8  token=0x600042F  System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  RVA=0x09779D00  token=0x6000430  System.Void RecordStateChanged(System.Int32 record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, System.Int32 record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2)
  RVA=0x0977A078  token=0x6000431  System.Int32[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0977425C  token=0x6000432  System.Int32[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0977E090  token=0x6000433  System.Void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, System.Object newValue)
  RVA=0x0977A22C  token=0x6000434  System.Void RemoveRow(System.Data.DataRow row, System.Boolean check)
  RVA=0x0977A578  token=0x6000435  System.Void Reset()
  RVA=0x0977A3E8  token=0x6000436  System.Void ResetIndexes()
  RVA=0x0977A3F4  token=0x6000437  System.Void ResetInternalIndexes(System.Data.DataColumn column)
  RVA=0x0977AAF8  token=0x6000438  System.Void RollbackRow(System.Data.DataRow row)
  RVA=0x0977695C  token=0x6000439  System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  RVA=0x09776CC0  token=0x600043A  System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  RVA=0x09776B34  token=0x600043B  System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, System.Boolean fireEvent)
  RVA=0x0977AB54  token=0x600043C  System.Data.DataRow[] Select(System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates)
  RVA=0x0977DC68  token=0x600043D  System.Void SetNewRecord(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean fireEvent, System.Boolean suppressEnsurePropertyChanged)
  RVA=0x0977D1C4  token=0x600043E  System.Void SetNewRecordWorker(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean suppressEnsurePropertyChanged, System.Int32 position, System.Boolean fireEvent, System.Exception& deferredException)
  RVA=0x0977DCD8  token=0x600043F  System.Void SetOldRecord(System.Data.DataRow row, System.Int32 proposedRecord)
  RVA=0x0977AADC  token=0x6000440  System.Void RestoreShadowIndexes()
  RVA=0x0977DFC4  token=0x6000441  System.Void SetShadowIndexes()
  RVA=0x0977E000  token=0x6000442  System.Void ShadowIndexCopy()
  RVA=0x0977E3BC  token=0x6000443  System.String ToString()
  RVA=0x0977E428  token=0x6000444  System.Boolean UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=0x0976BA7C  token=0x6000445  System.Data.DataColumn AddUniqueKey(System.Int32 position)
  RVA=0x0976BA6C  token=0x6000446  System.Data.DataColumn AddUniqueKey()
  RVA=0x0976B994  token=0x6000447  System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey)
  RVA=0x05BB11D8  token=0x6000448  System.Void UpdatePropertyDescriptorCollectionCache()
  RVA=0x0977392C  token=0x6000449  System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes)
  RVA=0x09775624  token=0x600044C  System.Void Merge(System.Data.DataTable table)
  RVA=0x09775644  token=0x600044D  System.Void Merge(System.Data.DataTable table, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  RVA=0x0977E774  token=0x600044E  System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, System.Boolean writeHierarchy)
  RVA=0x0976C4A8  token=0x600044F  System.Boolean CheckForClosureOnExpressions(System.Data.DataTable dt, System.Boolean writeHierarchy)
  RVA=0x0976C054  token=0x6000450  System.Boolean CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList)
  RVA=0x0977E44C  token=0x6000451  System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Boolean writeHierarchy)
  RVA=0x0977A75C  token=0x6000452  System.Void RestoreConstraint(System.Boolean originalEnforceConstraint)
  RVA=0x09774D14  token=0x6000453  System.Boolean IsEmptyXml(System.Xml.XmlReader reader)
  RVA=0x09778B98  token=0x6000454  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving)
  RVA=0x09776FF8  token=0x6000455  System.Void ReadEndElement(System.Xml.XmlReader reader)
  RVA=0x09777064  token=0x6000456  System.Void ReadXDRSchema(System.Xml.XmlReader reader)
  RVA=0x09775878  token=0x6000457  System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth)
  RVA=0x09777218  token=0x6000458  System.Void ReadXmlDiffgram(System.Xml.XmlReader reader)
  RVA=0x097770CC  token=0x6000459  System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  RVA=0x09777BB0  token=0x600045A  System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  RVA=0x0976EC90  token=0x600045B  System.Void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList)
  RVA=0x0976E968  token=0x600045C  System.Void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList)
  RVA=0x09773118  token=0x600045D  System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x0977E2B4  token=0x600045E  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x09773DA0  token=0x600045F  System.Xml.Schema.XmlSchema GetSchema()
  RVA=0x0977E2BC  token=0x6000460  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x0977E378  token=0x6000461  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x09778B78  token=0x6000462  System.Void ReadXmlSerializable(System.Xml.XmlReader reader)
  RVA=0x0976B8AC  token=0x6000465  System.Void AddDependentColumn(System.Data.DataColumn expressionColumn)
  RVA=0x09779FF0  token=0x6000466  System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn)
  RVA=0x097724A0  token=0x6000467  System.Void EvaluateExpressions()
  RVA=0x097726C8  token=0x6000468  System.Void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows)
  RVA=0x09772254  token=0x6000469  System.Void EvaluateExpressions(System.Data.DataColumn column)
  RVA=0x09772118  token=0x600046A  System.Void EvaluateDependentExpressions(System.Data.DataColumn column)
  RVA=0x0977186C  token=0x600046B  System.Void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows)
END_CLASS

CLASS: System.Data.DataTableClearEventArgs
TYPE:  sealed class
TOKEN: 0x200003C
SIZE:  0x18
EXTENDS: System.EventArgs
FIELDS:
  private   readonly System.Data.DataTable           <Table>k__BackingField  // 0x10
METHODS:
  RVA=0x09791708  token=0x600046E  System.Void .ctor(System.Data.DataTable dataTable)
END_CLASS

CLASS: System.Data.DataTableClearEventHandler
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x600046F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000470  System.Void Invoke(System.Object sender, System.Data.DataTableClearEventArgs e)
END_CLASS

CLASS: System.Data.DataTableCollection
TYPE:  sealed class
TOKEN: 0x200003E
SIZE:  0x48
EXTENDS: System.Data.InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataSet             _dataSet  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.Data.DataTable[]         _delayedAddRangeTables  // 0x28
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangedDelegate  // 0x30
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangingDelegate  // 0x38
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x40
PROPERTIES:
  List  get=0x01041090
  ObjectID  get=0x03D4ED80
  Item  get=0x09793918
  Item  get=0x09793918
  Item  get=0x09793918
METHODS:
  RVA=0x09793708  token=0x6000471  System.Void .ctor(System.Data.DataSet dataSet)
  RVA=0x097929B4  token=0x6000477  System.Data.DataTable GetTable(System.String name, System.String ns)
  RVA=0x097928A8  token=0x6000478  System.Data.DataTable GetTableSmart(System.String name, System.String ns)
  RVA=0x09791760  token=0x6000479  System.Void Add(System.Data.DataTable table)
  RVA=0x09791A94  token=0x600047A  System.Void ArrayAdd(System.Data.DataTable table)
  RVA=0x09791AB8  token=0x600047B  System.String AssignName()
  RVA=0x09791B00  token=0x600047C  System.Void BaseAdd(System.Data.DataTable table)
  RVA=0x09791C8C  token=0x600047D  System.Void BaseGroupSwitch(System.Data.DataTable[] oldArray, System.Int32 oldLength, System.Data.DataTable[] newArray, System.Int32 newLength)
  RVA=0x09791DFC  token=0x600047E  System.Void BaseRemove(System.Data.DataTable table)
  RVA=0x09791E7C  token=0x600047F  System.Boolean CanRemove(System.Data.DataTable table, System.Boolean fThrowException)
  RVA=0x097923C4  token=0x6000480  System.Void Clear()
  RVA=0x09792740  token=0x6000481  System.Boolean Contains(System.String name)
  RVA=0x09792758  token=0x6000482  System.Boolean Contains(System.String name, System.String tableNamespace, System.Boolean checkProperty, System.Boolean caseSensitive)
  RVA=0x09792648  token=0x6000483  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  RVA=0x09792B50  token=0x6000484  System.Int32 IndexOf(System.Data.DataTable table)
  RVA=0x09792AA4  token=0x6000485  System.Int32 IndexOf(System.String tableName)
  RVA=0x09792AC0  token=0x6000486  System.Int32 IndexOf(System.String tableName, System.String tableNamespace, System.Boolean chekforNull)
  RVA=0x097935B8  token=0x6000487  System.Void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList)
  RVA=0x09792BF4  token=0x6000488  System.Int32 InternalIndexOf(System.String tableName)
  RVA=0x09792D8C  token=0x6000489  System.Int32 InternalIndexOf(System.String tableName, System.String tableNamespace)
  RVA=0x09792EF4  token=0x600048A  System.String MakeName(System.Int32 index)
  RVA=0x09792F80  token=0x600048B  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x09793030  token=0x600048C  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  RVA=0x097930E0  token=0x600048D  System.Void RegisterName(System.String name, System.String tbNamespace)
  RVA=0x09793308  token=0x600048E  System.Void Remove(System.Data.DataTable table)
  RVA=0x09793604  token=0x600048F  System.Void UnregisterName(System.String name)
END_CLASS

CLASS: System.Data.DataTableNewRowEventArgs
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x18
EXTENDS: System.EventArgs
FIELDS:
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x10
METHODS:
  RVA=0x09793AEC  token=0x6000490  System.Void .ctor(System.Data.DataRow dataRow)
END_CLASS

CLASS: System.Data.DataTableNewRowEventHandler
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x6000491  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000492  System.Void Invoke(System.Object sender, System.Data.DataTableNewRowEventArgs e)
END_CLASS

CLASS: System.Data.DataTableTypeConverter
TYPE:  sealed class
TOKEN: 0x2000041
SIZE:  0x18
EXTENDS: System.ComponentModel.ReferenceConverter
FIELDS:
METHODS:
  RVA=0x09794188  token=0x6000493  System.Void .ctor()
  RVA=0x0115F4C0  token=0x6000494  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
END_CLASS

CLASS: System.Data.DataView
TYPE:  class
TOKEN: 0x2000042
SIZE:  0xB0
EXTENDS: System.ComponentModel.MarshalByValueComponent
IMPLEMENTS: System.ComponentModel.IBindingList System.Collections.IList System.Collections.ICollection System.Collections.IEnumerable
FIELDS:
  private           System.Data.DataViewManager     _dataViewManager  // 0x20
  private           System.Data.DataTable           _table  // 0x28
  private           System.Boolean                  _locked  // 0x30
  private           System.Data.Index               _index  // 0x38
  private           System.Collections.Generic.Dictionary<System.String,System.Data.Index>_findIndexes  // 0x40
  private           System.String                   _sort  // 0x48
  private           System.Comparison<System.Data.DataRow>_comparison  // 0x50
  private           System.Data.IFilter             _rowFilter  // 0x58
  private           System.Data.DataViewRowState    _recordStates  // 0x60
  private           System.Boolean                  _shouldOpen  // 0x64
  private           System.Boolean                  _open  // 0x65
  private           System.Boolean                  _allowNew  // 0x66
  private           System.Boolean                  _allowEdit  // 0x67
  private           System.Boolean                  _allowDelete  // 0x68
  private           System.Boolean                  _applyDefaultSort  // 0x69
  private           System.Data.DataRow             _addNewRow  // 0x70
  private           System.ComponentModel.ListChangedEventArgs_addNewMoved  // 0x78
  private           System.ComponentModel.ListChangedEventHandler_onListChanged  // 0x80
  private   static  System.ComponentModel.ListChangedEventArgss_resetEventArgs  // static @ 0x0
  private           System.Data.DataViewRowState    _delayedRecordStates  // 0x88
  private           System.Boolean                  _fEndInitInProgress  // 0x8c
  private           System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView>_rowViewCache  // 0x90
  private   readonly System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView>_rowViewBuffer  // 0x98
  private           System.Data.DataViewListener    _dvListener  // 0xa0
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x8
  private   readonly System.Int32                    _objectID  // 0xa8
PROPERTIES:
  AllowDelete  get=0x03D4F3F0
  AllowNew  get=0x03D5CAA0
  Count  get=0x09796A54
  CountFromIndex  get=0x09796A30
  DataViewManager  get=0x03D4EB40
  IsOpen  get=0x03D5CA70
  System.Collections.ICollection.IsSynchronized  get=0x0115F4C0
  RowStateFilter  get=0x03D4F050
  Sort  get=0x09796ABC
  SortComparison  get=0x03D4EAF0
  System.Collections.ICollection.SyncRoot  get=0x0339AE90
  Table  get=0x03D4EAC0
  System.Collections.IList.Item  get=0x09796378  set=0x09796380
  Item  get=0x09796A98
  System.Collections.IList.IsReadOnly  get=0x0115F4C0
  System.Collections.IList.IsFixedSize  get=0x0115F4C0
  ObjectID  get=0x03D51860
METHODS:
  RVA=0x0979676C  token=0x6000495  System.Void .ctor(System.Data.DataTable table, System.Boolean locked)
  RVA=0x09794210  token=0x60004A5  System.Data.DataRowView AddNew()
  RVA=0x097945E4  token=0x60004A6  System.Void CheckOpen()
  RVA=0x09794790  token=0x60004A7  System.Void Close()
  RVA=0x09794944  token=0x60004A8  System.Void CopyTo(System.Array array, System.Int32 index)
  RVA=0x09794A7C  token=0x60004A9  System.Void CopyTo(System.Data.DataRowView[] array, System.Int32 index)
  RVA=0x09794D68  token=0x60004AA  System.Void Delete(System.Int32 index)
  RVA=0x09794BD4  token=0x60004AB  System.Void Delete(System.Data.DataRow row)
  RVA=0x09794D8C  token=0x60004AC  System.Void Dispose(System.Boolean disposing)
  RVA=0x09794DC0  token=0x60004AD  System.Void FinishAddNew(System.Boolean success)
  RVA=0x09794F60  token=0x60004AE  System.Collections.IEnumerator GetEnumerator()
  RVA=0x09796188  token=0x60004B1  System.Int32 System.Collections.IList.Add(System.Object value)
  RVA=0x097961E8  token=0x60004B2  System.Void System.Collections.IList.Clear()
  RVA=0x09796210  token=0x60004B3  System.Boolean System.Collections.IList.Contains(System.Object value)
  RVA=0x0979626C  token=0x60004B4  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  RVA=0x097952FC  token=0x60004B5  System.Int32 IndexOf(System.Data.DataRowView rowview)
  RVA=0x0979529C  token=0x60004B6  System.Int32 IndexOfDataRowView(System.Data.DataRowView rowview)
  RVA=0x097962C0  token=0x60004B7  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  RVA=0x097962F0  token=0x60004B8  System.Void System.Collections.IList.Remove(System.Object value)
  RVA=0x097962E8  token=0x60004B9  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  RVA=0x03D4EAA0  token=0x60004BA  System.Data.IFilter GetFilter()
  RVA=0x09794FD4  token=0x60004BB  System.Int32 GetRecord(System.Int32 recordIndex)
  RVA=0x097950EC  token=0x60004BC  System.Data.DataRow GetRow(System.Int32 index)
  RVA=0x097950B0  token=0x60004BD  System.Data.DataRowView GetRowView(System.Int32 record)
  RVA=0x09795058  token=0x60004BE  System.Data.DataRowView GetRowView(System.Data.DataRow dr)
  RVA=0x0979522C  token=0x60004BF  System.Void IndexListChanged(System.Object sender, System.ComponentModel.ListChangedEventArgs e)
  RVA=0x09795184  token=0x60004C0  System.Void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e)
  RVA=0x097953B8  token=0x60004C1  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove)
  RVA=0x09795660  token=0x60004C2  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  RVA=0x09795D08  token=0x60004C3  System.Void Reset()
  RVA=0x09795AD8  token=0x60004C4  System.Void ResetRowViewCache()
  RVA=0x09795D34  token=0x60004C5  System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager)
  RVA=0x0979616C  token=0x60004C6  System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter)
  RVA=0x09795F40  token=0x60004C7  System.Void SetIndex2(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, System.Boolean fireEvent)
  RVA=0x097966CC  token=0x60004C8  System.Void UpdateIndex()
  RVA=0x097966DC  token=0x60004C9  System.Void UpdateIndex(System.Boolean force)
  RVA=0x097963A8  token=0x60004CA  System.Void UpdateIndex(System.Boolean force, System.Boolean fireEvent)
  RVA=0x09794620  token=0x60004CB  System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x09795968  token=0x60004CC  System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x097947D4  token=0x60004CD  System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x097947CC  token=0x60004CE  System.Void ColumnCollectionChangedInternal(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x097966E8  token=0x60004D0  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataViewListener
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x30
FIELDS:
  private   readonly System.WeakReference            _dvWeak  // 0x10
  private           System.Data.DataTable           _table  // 0x18
  private           System.Data.Index               _index  // 0x20
  private   readonly System.Int32                    _objectID  // 0x28
METHODS:
  RVA=0x0979F1F8  token=0x60004D5  System.Void .ctor(System.Data.DataView dv)
  RVA=0x0979E6B8  token=0x60004D6  System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x0979E914  token=0x60004D7  System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x0979E768  token=0x60004D8  System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  RVA=0x0979E874  token=0x60004D9  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove)
  RVA=0x0979E7F8  token=0x60004DA  System.Void IndexListChanged(System.ComponentModel.ListChangedEventArgs e)
  RVA=0x0979EC08  token=0x60004DB  System.Void RegisterMetaDataEvents(System.Data.DataTable table)
  RVA=0x0979F1EC  token=0x60004DC  System.Void UnregisterMetaDataEvents()
  RVA=0x0979EEDC  token=0x60004DD  System.Void UnregisterMetaDataEvents(System.Boolean updateListeners)
  RVA=0x0979E9A4  token=0x60004DE  System.Void RegisterListChangedEvent(System.Data.Index index)
  RVA=0x0979EDF8  token=0x60004DF  System.Void UnregisterListChangedEvent()
  RVA=0x0979E748  token=0x60004E0  System.Void CleanUp(System.Boolean updateListeners)
  RVA=0x0979EA78  token=0x60004E1  System.Void RegisterListener(System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DataViewManager
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x30
EXTENDS: System.ComponentModel.MarshalByValueComponent
FIELDS:
  private           System.Data.DataViewSettingCollection_dataViewSettingsCollection  // 0x20
  private           System.Int32                    _nViews  // 0x28
  private   static  System.NotSupportedException    s_notSupported  // static @ 0x0
PROPERTIES:
  DataViewSettings  get=0x03D4EB40
METHODS:
  RVA=0x0979F280  token=0x60004E3  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataViewRowState
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataViewRowState    None  // const
  public    static  System.Data.DataViewRowState    Unchanged  // const
  public    static  System.Data.DataViewRowState    Added  // const
  public    static  System.Data.DataViewRowState    Deleted  // const
  public    static  System.Data.DataViewRowState    ModifiedCurrent  // const
  public    static  System.Data.DataViewRowState    ModifiedOriginal  // const
  public    static  System.Data.DataViewRowState    OriginalRows  // const
  public    static  System.Data.DataViewRowState    CurrentRows  // const
METHODS:
END_CLASS

CLASS: System.Data.DataViewSetting
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x38
FIELDS:
  private           System.Data.DataViewManager     _dataViewManager  // 0x10
  private           System.Data.DataTable           _table  // 0x18
  private           System.String                   _sort  // 0x20
  private           System.String                   _rowFilter  // 0x28
  private           System.Data.DataViewRowState    _rowStateFilter  // 0x30
  private           System.Boolean                  _applyDefaultSort  // 0x34
PROPERTIES:
  ApplyDefaultSort  get=0x03D4F570
  RowFilter  get=0x03D4EAC0
  RowStateFilter  get=0x03D4ED20
  Sort  get=0x03D4EB40
METHODS:
  RVA=0x0979F4B0  token=0x60004E4  System.Void .ctor()
  RVA=0x09765038  token=0x60004E6  System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager)
  RVA=0x0979F49C  token=0x60004E7  System.Void SetDataTable(System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DataViewSettingCollection
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x20
FIELDS:
  private   readonly System.Data.DataViewManager     _dataViewManager  // 0x10
  private   readonly System.Collections.Hashtable    _list  // 0x18
PROPERTIES:
  Item  get=0x0979F320  set=0x0979F3FC
METHODS:
  RVA=0x0979F2FC  token=0x60004ED  System.Void Remove(System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DefaultValueTypeConverter
TYPE:  sealed class
TOKEN: 0x2000049
SIZE:  0x10
EXTENDS: System.ComponentModel.StringConverter
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60004EE  System.Void .ctor()
  RVA=0x0979F670  token=0x60004EF  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  RVA=0x0979F520  token=0x60004F0  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
END_CLASS

CLASS: System.Data.Aggregate
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Aggregate           None  // const
  public    static  System.Data.Aggregate           Sum  // const
  public    static  System.Data.Aggregate           Avg  // const
  public    static  System.Data.Aggregate           Min  // const
  public    static  System.Data.Aggregate           Max  // const
  public    static  System.Data.Aggregate           Count  // const
  public    static  System.Data.Aggregate           StDev  // const
  public    static  System.Data.Aggregate           Var  // const
METHODS:
END_CLASS

CLASS: System.Data.AggregateNode
TYPE:  sealed class
TOKEN: 0x200004B
SIZE:  0x50
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.Data.AggregateType       _type  // 0x18
  private   readonly System.Data.Aggregate           _aggregate  // 0x1c
  private   readonly System.Boolean                  _local  // 0x20
  private   readonly System.String                   _relationName  // 0x28
  private   readonly System.String                   _columnName  // 0x30
  private           System.Data.DataTable           _childTable  // 0x38
  private           System.Data.DataColumn          _column  // 0x40
  private           System.Data.DataRelation        _relation  // 0x48
METHODS:
  RVA=0x097973EC  token=0x60004F1  System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName)
  RVA=0x097972B8  token=0x60004F2  System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName, System.Boolean local, System.String relationName)
  RVA=0x09796B48  token=0x60004F3  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x09796DC8  token=0x60004F4  System.Void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x09796F28  token=0x60004F5  System.Object Eval()
  RVA=0x09796FD8  token=0x60004F6  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x09796F3C  token=0x60004F7  System.Object Eval(System.Int32[] records)
  RVA=0x0115F4C0  token=0x60004F8  System.Boolean IsConstant()
  RVA=0x03D4EF90  token=0x60004F9  System.Boolean IsTableConstant()
  RVA=0x03D4EF90  token=0x60004FA  System.Boolean HasLocalAggregate()
  RVA=0x097972B0  token=0x60004FB  System.Boolean HasRemoteAggregate()
  RVA=0x09796EEC  token=0x60004FC  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x0339AE90  token=0x60004FD  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.BinaryNode
TYPE:  class
TOKEN: 0x200004C
SIZE:  0x30
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private           System.Int32                    _op  // 0x18
  private           System.Data.ExpressionNode      _left  // 0x20
  private           System.Data.ExpressionNode      _right  // 0x28
METHODS:
  RVA=0x0979CFEC  token=0x60004FE  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right)
  RVA=0x09798170  token=0x60004FF  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x09796F28  token=0x6000500  System.Object Eval()
  RVA=0x0979C168  token=0x6000501  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0979C0F8  token=0x6000502  System.Object Eval(System.Int32[] recordNos)
  RVA=0x0979C554  token=0x6000503  System.Boolean IsConstant()
  RVA=0x0979C638  token=0x6000504  System.Boolean IsTableConstant()
  RVA=0x0979C4C4  token=0x6000505  System.Boolean HasLocalAggregate()
  RVA=0x0979C50C  token=0x6000506  System.Boolean HasRemoteAggregate()
  RVA=0x097981D4  token=0x6000507  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x0979C67C  token=0x6000508  System.Data.ExpressionNode Optimize()
  RVA=0x0979CEBC  token=0x6000509  System.Void SetTypeMismatchError(System.Int32 op, System.Type left, System.Type right)
  RVA=0x0979C12C  token=0x600050A  System.Object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos)
  RVA=0x0979740C  token=0x600050B  System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op)
  RVA=0x09797430  token=0x600050C  System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op, System.Globalization.CompareInfo comparer)
  RVA=0x0979822C  token=0x600050D  System.Object EvalBinaryOp(System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos)
  RVA=0x0979C324  token=0x600050E  System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType)
  RVA=0x0979C198  token=0x600050F  System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code)
  RVA=0x0979C5E8  token=0x6000510  System.Boolean IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right)
  RVA=0x0979C598  token=0x6000511  System.Boolean IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right)
  RVA=0x0979CBFC  token=0x6000512  System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op)
  RVA=0x0979C928  token=0x6000513  System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op)
  RVA=0x0979CEF4  token=0x6000514  System.Int32 SqlResultType(System.Int32 typeCode)
END_CLASS

CLASS: System.Data.LikeNode
TYPE:  sealed class
TOKEN: 0x200004E
SIZE:  0x40
EXTENDS: System.Data.BinaryNode
FIELDS:
  private           System.Int32                    _kind  // 0x30
  private           System.String                   _pattern  // 0x38
METHODS:
  RVA=0x097A7AE4  token=0x6000515  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right)
  RVA=0x097A7644  token=0x6000516  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097A7334  token=0x6000517  System.String AnalyzePattern(System.String pat)
END_CLASS

CLASS: System.Data.ConstNode
TYPE:  sealed class
TOKEN: 0x200004F
SIZE:  0x20
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.Object                   _val  // 0x18
METHODS:
  RVA=0x0979DC30  token=0x6000518  System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant)
  RVA=0x0979D97C  token=0x6000519  System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant, System.Boolean fParseQuotes)
  RVA=0x0426FEE0  token=0x600051A  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x01041090  token=0x600051B  System.Object Eval()
  RVA=0x0979D02C  token=0x600051C  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0979D02C  token=0x600051D  System.Object Eval(System.Int32[] recordNos)
  RVA=0x0232EB60  token=0x600051E  System.Boolean IsConstant()
  RVA=0x0232EB60  token=0x600051F  System.Boolean IsTableConstant()
  RVA=0x0115F4C0  token=0x6000520  System.Boolean HasLocalAggregate()
  RVA=0x0115F4C0  token=0x6000521  System.Boolean HasRemoteAggregate()
  RVA=0x0339AE90  token=0x6000522  System.Data.ExpressionNode Optimize()
  RVA=0x0979D03C  token=0x6000523  System.Object SmallestDecimal(System.Object constant)
  RVA=0x0979D434  token=0x6000524  System.Object SmallestNumeric(System.Object constant)
END_CLASS

CLASS: System.Data.DataExpression
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x48
IMPLEMENTS: System.Data.IFilter
FIELDS:
  private           System.String                   _originalExpression  // 0x10
  private           System.Boolean                  _parsed  // 0x18
  private           System.Boolean                  _bound  // 0x19
  private           System.Data.ExpressionNode      _expr  // 0x20
  private           System.Data.DataTable           _table  // 0x28
  private   readonly System.Data.Common.StorageType  _storageType  // 0x30
  private   readonly System.Type                     _dataType  // 0x38
  private           System.Data.DataColumn[]        _dependency  // 0x40
PROPERTIES:
  Expression  get=0x0979E678
  ExpressionNode  get=0x03D4EB40
  HasValue  get=0x08571E40
METHODS:
  RVA=0x0979E4EC  token=0x6000525  System.Void .ctor(System.Data.DataTable table, System.String expression)
  RVA=0x0979E508  token=0x6000526  System.Void .ctor(System.Data.DataTable table, System.String expression, System.Type type)
  RVA=0x0979DC4C  token=0x600052A  System.Void Bind(System.Data.DataTable table)
  RVA=0x0979DD48  token=0x600052B  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x0979DF5C  token=0x600052C  System.Object Evaluate()
  RVA=0x0979DD68  token=0x600052D  System.Object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0979DF4C  token=0x600052E  System.Object Evaluate(System.Data.DataRow[] rows)
  RVA=0x0979DF6C  token=0x600052F  System.Object Evaluate(System.Data.DataRow[] rows, System.Data.DataRowVersion version)
  RVA=0x0979E124  token=0x6000530  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x03D4E2B0  token=0x6000531  System.Data.DataColumn[] GetDependency()
  RVA=0x0979E214  token=0x6000532  System.Boolean IsTableAggregate()
  RVA=0x0979E234  token=0x6000533  System.Boolean IsUnknown(System.Object value)
  RVA=0x0979E0E4  token=0x6000534  System.Boolean HasLocalAggregate()
  RVA=0x0979E104  token=0x6000535  System.Boolean HasRemoteAggregate()
  RVA=0x0979E280  token=0x6000536  System.Boolean ToBoolean(System.Object value)
END_CLASS

CLASS: System.Data.ExpressionNode
TYPE:  abstract class
TOKEN: 0x2000051
SIZE:  0x18
FIELDS:
  private           System.Data.DataTable           _table  // 0x10
PROPERTIES:
  FormatProvider  get=0x097A0B0C
  IsSqlColumn  get=0x0115F4C0
  table  get=0x020B7B20
METHODS:
  RVA=0x0426FEE0  token=0x6000537  System.Void .ctor(System.Data.DataTable table)
  RVA=0x0426FEE0  token=0x600053B  System.Void BindTable(System.Data.DataTable table)
  RVA=-1  // abstract  token=0x600053C  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=-1  // abstract  token=0x600053D  System.Object Eval()
  RVA=-1  // abstract  token=0x600053E  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=-1  // abstract  token=0x600053F  System.Object Eval(System.Int32[] recordNos)
  RVA=-1  // abstract  token=0x6000540  System.Boolean IsConstant()
  RVA=-1  // abstract  token=0x6000541  System.Boolean IsTableConstant()
  RVA=-1  // abstract  token=0x6000542  System.Boolean HasLocalAggregate()
  RVA=-1  // abstract  token=0x6000543  System.Boolean HasRemoteAggregate()
  RVA=-1  // abstract  token=0x6000544  System.Data.ExpressionNode Optimize()
  RVA=0x0115F4C0  token=0x6000545  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x097A0A28  token=0x6000546  System.Boolean IsInteger(System.Data.Common.StorageType type)
  RVA=0x097A0A0C  token=0x6000547  System.Boolean IsIntegerSql(System.Data.Common.StorageType type)
  RVA=0x097A0ABC  token=0x6000548  System.Boolean IsSigned(System.Data.Common.StorageType type)
  RVA=0x097A0A9C  token=0x6000549  System.Boolean IsSignedSql(System.Data.Common.StorageType type)
  RVA=0x097A0AF0  token=0x600054A  System.Boolean IsUnsigned(System.Data.Common.StorageType type)
  RVA=0x097A0AD4  token=0x600054B  System.Boolean IsUnsignedSql(System.Data.Common.StorageType type)
  RVA=0x097A0A70  token=0x600054C  System.Boolean IsNumeric(System.Data.Common.StorageType type)
  RVA=0x097A0A44  token=0x600054D  System.Boolean IsNumericSql(System.Data.Common.StorageType type)
  RVA=0x097A09F8  token=0x600054E  System.Boolean IsFloat(System.Data.Common.StorageType type)
  RVA=0x097A09D8  token=0x600054F  System.Boolean IsFloatSql(System.Data.Common.StorageType type)
END_CLASS

CLASS: System.Data.ValueType
TYPE:  sealed struct
TOKEN: 0x2000052
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.ValueType           Unknown  // const
  public    static  System.Data.ValueType           Null  // const
  public    static  System.Data.ValueType           Bool  // const
  public    static  System.Data.ValueType           Numeric  // const
  public    static  System.Data.ValueType           Str  // const
  public    static  System.Data.ValueType           Float  // const
  public    static  System.Data.ValueType           Decimal  // const
  public    static  System.Data.ValueType           Object  // const
  public    static  System.Data.ValueType           Date  // const
METHODS:
END_CLASS

CLASS: System.Data.Nodes
TYPE:  sealed struct
TOKEN: 0x2000053
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Nodes               Noop  // const
  public    static  System.Data.Nodes               Unop  // const
  public    static  System.Data.Nodes               UnopSpec  // const
  public    static  System.Data.Nodes               Binop  // const
  public    static  System.Data.Nodes               BinopSpec  // const
  public    static  System.Data.Nodes               Zop  // const
  public    static  System.Data.Nodes               Call  // const
  public    static  System.Data.Nodes               Const  // const
  public    static  System.Data.Nodes               Name  // const
  public    static  System.Data.Nodes               Paren  // const
  public    static  System.Data.Nodes               Conv  // const
METHODS:
END_CLASS

CLASS: System.Data.ExpressionParser
TYPE:  sealed class
TOKEN: 0x2000054
SIZE:  0x68
FIELDS:
  private   static readonly System.Data.ExpressionParser.ReservedWords[]s_reservedwords  // static @ 0x0
  private           System.Char                     _escape  // 0x10
  private           System.Char                     _decimalSeparator  // 0x12
  private           System.Char                     _listSeparator  // 0x14
  private           System.Char                     _exponentL  // 0x16
  private           System.Char                     _exponentU  // 0x18
  private           System.Char[]                   _text  // 0x20
  private           System.Int32                    _pos  // 0x28
  private           System.Int32                    _start  // 0x2c
  private           System.Data.Tokens              _token  // 0x30
  private           System.Int32                    _op  // 0x34
  private           System.Data.OperatorInfo[]      _ops  // 0x38
  private           System.Int32                    _topOperator  // 0x40
  private           System.Int32                    _topNode  // 0x44
  private   readonly System.Data.DataTable           _table  // 0x48
  private           System.Data.ExpressionNode[]    _nodeStack  // 0x50
  private           System.Int32                    _prevOperand  // 0x58
  private           System.Data.ExpressionNode      _expression  // 0x60
METHODS:
  RVA=0x097A3318  token=0x6000550  System.Void .ctor(System.Data.DataTable table)
  RVA=0x097A1050  token=0x6000551  System.Void LoadExpression(System.String data)
  RVA=0x097A2E70  token=0x6000552  System.Void StartScan()
  RVA=0x097A14B4  token=0x6000553  System.Data.ExpressionNode Parse()
  RVA=0x097A1224  token=0x6000554  System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate)
  RVA=0x097A1174  token=0x6000555  System.Data.ExpressionNode NodePop()
  RVA=0x097A113C  token=0x6000556  System.Data.ExpressionNode NodePeek()
  RVA=0x097A11AC  token=0x6000557  System.Void NodePush(System.Data.ExpressionNode node)
  RVA=0x097A0B60  token=0x6000558  System.Void BuildExpression(System.Int32 pri)
  RVA=0x097A0DDC  token=0x6000559  System.Void CheckToken(System.Data.Tokens token)
  RVA=0x097A29FC  token=0x600055A  System.Data.Tokens Scan()
  RVA=0x097A2578  token=0x600055B  System.Void ScanNumeric()
  RVA=0x097A240C  token=0x600055C  System.Void ScanName()
  RVA=0x097A2464  token=0x600055D  System.Void ScanName(System.Char chEnd, System.Char esc, System.String charsToEscape)
  RVA=0x097A234C  token=0x600055E  System.Void ScanDate()
  RVA=0x0350B670  token=0x600055F  System.Void ScanBinaryConstant()
  RVA=0x097A26DC  token=0x6000560  System.Void ScanReserved()
  RVA=0x097A28C0  token=0x6000561  System.Void ScanString(System.Char escape)
  RVA=0x097A2974  token=0x6000562  System.Void ScanToken(System.Data.Tokens token)
  RVA=0x097A29A4  token=0x6000563  System.Void ScanWhite()
  RVA=0x097A1040  token=0x6000564  System.Boolean IsWhiteSpace(System.Char ch)
  RVA=0x097A0E1C  token=0x6000565  System.Boolean IsAlphaNumeric(System.Char ch)
  RVA=0x097A1010  token=0x6000566  System.Boolean IsDigit(System.Char ch)
  RVA=0x097A0F70  token=0x6000567  System.Boolean IsAlpha(System.Char ch)
  RVA=0x097A2EF0  token=0x6000568  System.Void .cctor()
END_CLASS

CLASS: System.Data.Tokens
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Tokens              None  // const
  public    static  System.Data.Tokens              Name  // const
  public    static  System.Data.Tokens              Numeric  // const
  public    static  System.Data.Tokens              Decimal  // const
  public    static  System.Data.Tokens              Float  // const
  public    static  System.Data.Tokens              BinaryConst  // const
  public    static  System.Data.Tokens              StringConst  // const
  public    static  System.Data.Tokens              Date  // const
  public    static  System.Data.Tokens              ListSeparator  // const
  public    static  System.Data.Tokens              LeftParen  // const
  public    static  System.Data.Tokens              RightParen  // const
  public    static  System.Data.Tokens              ZeroOp  // const
  public    static  System.Data.Tokens              UnaryOp  // const
  public    static  System.Data.Tokens              BinaryOp  // const
  public    static  System.Data.Tokens              Child  // const
  public    static  System.Data.Tokens              Parent  // const
  public    static  System.Data.Tokens              Dot  // const
  public    static  System.Data.Tokens              Unknown  // const
  public    static  System.Data.Tokens              EOS  // const
METHODS:
END_CLASS

CLASS: System.Data.OperatorInfo
TYPE:  sealed class
TOKEN: 0x2000057
SIZE:  0x20
FIELDS:
  private           System.Data.Nodes               _type  // 0x10
  private           System.Int32                    _op  // 0x14
  private           System.Int32                    _priority  // 0x18
METHODS:
  RVA=0x03D51130  token=0x600056A  System.Void .ctor(System.Data.Nodes type, System.Int32 op, System.Int32 pri)
END_CLASS

CLASS: System.Data.InvalidExpressionException
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x90
EXTENDS: System.Data.DataException
FIELDS:
METHODS:
  RVA=0x091672B8  token=0x600056B  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0979F7DC  token=0x600056C  System.Void .ctor()
  RVA=0x09762E64  token=0x600056D  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.EvaluateException
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x90
EXTENDS: System.Data.InvalidExpressionException
FIELDS:
METHODS:
  RVA=0x0979F7E4  token=0x600056E  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0979F7DC  token=0x600056F  System.Void .ctor()
  RVA=0x09762E64  token=0x6000570  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.SyntaxErrorException
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x90
EXTENDS: System.Data.InvalidExpressionException
FIELDS:
METHODS:
  RVA=0x0979F7E4  token=0x6000571  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x0979F7DC  token=0x6000572  System.Void .ctor()
  RVA=0x09762E64  token=0x6000573  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ExprException
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x097A0900  token=0x6000574  System.OverflowException _Overflow(System.String error)
  RVA=0x097A0894  token=0x6000575  System.Data.InvalidExpressionException _Expr(System.String error)
  RVA=0x097A096C  token=0x6000576  System.Data.SyntaxErrorException _Syntax(System.String error)
  RVA=0x097A0828  token=0x6000577  System.Data.EvaluateException _Eval(System.String error)
  RVA=0x097A07BC  token=0x6000578  System.Data.EvaluateException _Eval(System.String error, System.Exception innerException)
  RVA=0x097A0090  token=0x6000579  System.Exception InvokeArgument()
  RVA=0x097A0268  token=0x600057A  System.Exception NYI(System.String moreinfo)
  RVA=0x097A0174  token=0x600057B  System.Exception MissingOperand(System.Data.OperatorInfo before)
  RVA=0x097A01EC  token=0x600057C  System.Exception MissingOperator(System.String token)
  RVA=0x097A0464  token=0x600057D  System.Exception TypeMismatch(System.String expr)
  RVA=0x0979FD50  token=0x600057E  System.Exception FunctionArgumentOutOfRange(System.String arg, System.String func)
  RVA=0x0979FC44  token=0x600057F  System.Exception ExpressionTooComplex()
  RVA=0x097A04AC  token=0x6000580  System.Exception UnboundName(System.String name)
  RVA=0x0979FFCC  token=0x6000581  System.Exception InvalidString(System.String str)
  RVA=0x097A04F4  token=0x6000582  System.Exception UndefinedFunction(System.String name)
  RVA=0x097A0344  token=0x6000583  System.Exception SyntaxError()
  RVA=0x0979FD08  token=0x6000584  System.Exception FunctionArgumentCount(System.String name)
  RVA=0x097A0234  token=0x6000585  System.Exception MissingRightParen()
  RVA=0x097A0620  token=0x6000586  System.Exception UnknownToken(System.String token, System.Int32 position)
  RVA=0x097A053C  token=0x6000587  System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, System.Int32 position)
  RVA=0x0979FAF8  token=0x6000588  System.Exception DatatypeConvertion(System.Type type1, System.Type type2)
  RVA=0x0979FB7C  token=0x6000589  System.Exception DatavalueConvertion(System.Object value, System.Type type, System.Exception innerException)
  RVA=0x0979FF3C  token=0x600058A  System.Exception InvalidName(System.String name)
  RVA=0x0979FE10  token=0x600058B  System.Exception InvalidDate(System.String date)
  RVA=0x097A02B0  token=0x600058C  System.Exception NonConstantArgument()
  RVA=0x0979FF84  token=0x600058D  System.Exception InvalidPattern(System.String pat)
  RVA=0x0979FDDC  token=0x600058E  System.Exception InWithoutParentheses()
  RVA=0x0979FDA8  token=0x600058F  System.Exception InWithoutList()
  RVA=0x0979FE8C  token=0x6000590  System.Exception InvalidIsSyntax()
  RVA=0x097A02E4  token=0x6000591  System.Exception Overflow(System.Type type)
  RVA=0x0979F9B4  token=0x6000592  System.Exception ArgumentType(System.String function, System.Int32 arg, System.Type type)
  RVA=0x0979F938  token=0x6000593  System.Exception ArgumentTypeInteger(System.String function, System.Int32 arg)
  RVA=0x097A03AC  token=0x6000594  System.Exception TypeMismatchInBinop(System.Int32 op, System.Type type1, System.Type type2)
  RVA=0x0979F880  token=0x6000595  System.Exception AmbiguousBinop(System.Int32 op, System.Type type1, System.Type type2)
  RVA=0x097A0754  token=0x6000596  System.Exception UnsupportedOperator(System.Int32 op)
  RVA=0x0979FEF4  token=0x6000597  System.Exception InvalidNameBracketing(System.String name)
  RVA=0x097A012C  token=0x6000598  System.Exception MissingOperandBefore(System.String op)
  RVA=0x097A0378  token=0x6000599  System.Exception TooManyRightParentheses()
  RVA=0x097A069C  token=0x600059A  System.Exception UnresolvedRelation(System.String name, System.String expr)
  RVA=0x0979FA68  token=0x600059B  System.Data.EvaluateException BindFailure(System.String relationName)
  RVA=0x0979F804  token=0x600059C  System.Exception AggregateArgument()
  RVA=0x0979F838  token=0x600059D  System.Exception AggregateUnbound(System.String expr)
  RVA=0x0979FC10  token=0x600059E  System.Exception EvalNoContext()
  RVA=0x0979FC78  token=0x600059F  System.Exception ExpressionUnbound(System.String expr)
  RVA=0x0979FAB0  token=0x60005A0  System.Exception ComputeNotAggregate(System.String expr)
  RVA=0x0979FCC0  token=0x60005A1  System.Exception FilterConvertion(System.String expr)
  RVA=0x097A00C4  token=0x60005A2  System.Exception LookupArgument()
  RVA=0x097A0048  token=0x60005A3  System.Exception InvalidType(System.String typeName)
  RVA=0x0979FE58  token=0x60005A4  System.Exception InvalidHoursArgument()
  RVA=0x0979FEC0  token=0x60005A5  System.Exception InvalidMinutesArgument()
  RVA=0x097A0014  token=0x60005A6  System.Exception InvalidTimeZoneRange()
  RVA=0x097A00F8  token=0x60005A7  System.Exception MismatchKindandTimeSpan()
  RVA=0x097A06F4  token=0x60005A8  System.Exception UnsupportedDataType(System.Type type)
END_CLASS

CLASS: System.Data.FunctionNode
TYPE:  sealed class
TOKEN: 0x200005C
SIZE:  0x30
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.String                   _name  // 0x18
  private   readonly System.Int32                    _info  // 0x20
  private           System.Int32                    _argumentCount  // 0x24
  private           System.Data.ExpressionNode[]    _arguments  // 0x28
  private   static readonly System.Data.Function[]          s_funcs  // static @ 0x0
PROPERTIES:
  Aggregate  get=0x097A69F4
  IsAggregate  get=0x097A6A78
METHODS:
  RVA=0x097A68E0  token=0x60005A9  System.Void .ctor(System.Data.DataTable table, System.String name)
  RVA=0x097A33B8  token=0x60005AA  System.Void AddArgument(System.Data.ExpressionNode argument)
  RVA=0x097A3560  token=0x60005AB  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x09796F28  token=0x60005AC  System.Object Eval()
  RVA=0x097A5030  token=0x60005AD  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097A593C  token=0x60005AE  System.Object Eval(System.Int32[] recordNos)
  RVA=0x097A5C78  token=0x60005AF  System.Boolean IsConstant()
  RVA=0x097A5CD8  token=0x60005B0  System.Boolean IsTableConstant()
  RVA=0x097A5BB0  token=0x60005B1  System.Boolean HasLocalAggregate()
  RVA=0x097A5C14  token=0x60005B2  System.Boolean HasRemoteAggregate()
  RVA=0x097A3A28  token=0x60005B3  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x097A5D3C  token=0x60005B4  System.Data.ExpressionNode Optimize()
  RVA=0x097A5974  token=0x60005B5  System.Type GetDataType(System.Data.ExpressionNode node)
  RVA=0x097A3A9C  token=0x60005B6  System.Object EvalFunction(System.Data.FunctionId id, System.Object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097A3800  token=0x60005B9  System.Void Check()
  RVA=0x097A5EBC  token=0x60005BA  System.Void .cctor()
END_CLASS

CLASS: System.Data.FunctionId
TYPE:  sealed struct
TOKEN: 0x200005D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.FunctionId          none  // const
  public    static  System.Data.FunctionId          Ascii  // const
  public    static  System.Data.FunctionId          Char  // const
  public    static  System.Data.FunctionId          Charindex  // const
  public    static  System.Data.FunctionId          Difference  // const
  public    static  System.Data.FunctionId          Len  // const
  public    static  System.Data.FunctionId          Lower  // const
  public    static  System.Data.FunctionId          LTrim  // const
  public    static  System.Data.FunctionId          Patindex  // const
  public    static  System.Data.FunctionId          Replicate  // const
  public    static  System.Data.FunctionId          Reverse  // const
  public    static  System.Data.FunctionId          Right  // const
  public    static  System.Data.FunctionId          RTrim  // const
  public    static  System.Data.FunctionId          Soundex  // const
  public    static  System.Data.FunctionId          Space  // const
  public    static  System.Data.FunctionId          Str  // const
  public    static  System.Data.FunctionId          Stuff  // const
  public    static  System.Data.FunctionId          Substring  // const
  public    static  System.Data.FunctionId          Upper  // const
  public    static  System.Data.FunctionId          IsNull  // const
  public    static  System.Data.FunctionId          Iif  // const
  public    static  System.Data.FunctionId          Convert  // const
  public    static  System.Data.FunctionId          cInt  // const
  public    static  System.Data.FunctionId          cBool  // const
  public    static  System.Data.FunctionId          cDate  // const
  public    static  System.Data.FunctionId          cDbl  // const
  public    static  System.Data.FunctionId          cStr  // const
  public    static  System.Data.FunctionId          Abs  // const
  public    static  System.Data.FunctionId          Acos  // const
  public    static  System.Data.FunctionId          In  // const
  public    static  System.Data.FunctionId          Trim  // const
  public    static  System.Data.FunctionId          Sum  // const
  public    static  System.Data.FunctionId          Avg  // const
  public    static  System.Data.FunctionId          Min  // const
  public    static  System.Data.FunctionId          Max  // const
  public    static  System.Data.FunctionId          Count  // const
  public    static  System.Data.FunctionId          StDev  // const
  public    static  System.Data.FunctionId          Var  // const
  public    static  System.Data.FunctionId          DateTimeOffset  // const
METHODS:
END_CLASS

CLASS: System.Data.Function
TYPE:  sealed class
TOKEN: 0x200005E
SIZE:  0x38
FIELDS:
  private   readonly System.String                   _name  // 0x10
  private   readonly System.Data.FunctionId          _id  // 0x18
  private   readonly System.Type                     _result  // 0x20
  private   readonly System.Boolean                  _isValidateArguments  // 0x28
  private   readonly System.Boolean                  _isVariantArgumentList  // 0x29
  private   readonly System.Int32                    _argumentCount  // 0x2c
  private   readonly System.Type[]                   _parameters  // 0x30
  private   static  System.String[]                 s_functionName  // static @ 0x0
METHODS:
  RVA=0x097A71D4  token=0x60005BB  System.Void .ctor(System.String name, System.Data.FunctionId id, System.Type result, System.Boolean IsValidateArguments, System.Boolean IsVariantArgumentList, System.Int32 argumentCount, System.Type a1, System.Type a2, System.Type a3)
  RVA=0x097A6C7C  token=0x60005BC  System.Void .cctor()
END_CLASS

CLASS: System.Data.IFilter
TYPE:  interface
TOKEN: 0x200005F
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60005BD  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
END_CLASS

CLASS: System.Data.LookupNode
TYPE:  sealed class
TOKEN: 0x2000060
SIZE:  0x38
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.String                   _relationName  // 0x18
  private   readonly System.String                   _columnName  // 0x20
  private           System.Data.DataColumn          _column  // 0x28
  private           System.Data.DataRelation        _relation  // 0x30
METHODS:
  RVA=0x097A7EB4  token=0x60005BE  System.Void .ctor(System.Data.DataTable table, System.String columnName, System.String relationName)
  RVA=0x097A7AF4  token=0x60005BF  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x097A7D58  token=0x60005C0  System.Object Eval()
  RVA=0x097A7DB8  token=0x60005C1  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097A7D80  token=0x60005C2  System.Object Eval(System.Int32[] recordNos)
  RVA=0x0115F4C0  token=0x60005C3  System.Boolean IsConstant()
  RVA=0x0115F4C0  token=0x60005C4  System.Boolean IsTableConstant()
  RVA=0x0115F4C0  token=0x60005C5  System.Boolean HasLocalAggregate()
  RVA=0x0115F4C0  token=0x60005C6  System.Boolean HasRemoteAggregate()
  RVA=0x097A7D50  token=0x60005C7  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x0339AE90  token=0x60005C8  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.NameNode
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x30
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private           System.String                   _name  // 0x18
  private           System.Boolean                  _found  // 0x20
  private           System.Data.DataColumn          _column  // 0x28
PROPERTIES:
  IsSqlColumn  get=0x097A8544
METHODS:
  RVA=0x097A8500  token=0x60005C9  System.Void .ctor(System.Data.DataTable table, System.Char[] text, System.Int32 start, System.Int32 pos)
  RVA=0x02676770  token=0x60005CA  System.Void .ctor(System.Data.DataTable table, System.String name)
  RVA=0x097A7EEC  token=0x60005CC  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x097A8238  token=0x60005CD  System.Object Eval()
  RVA=0x097A8138  token=0x60005CE  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097A8200  token=0x60005CF  System.Object Eval(System.Int32[] records)
  RVA=0x0115F4C0  token=0x60005D0  System.Boolean IsConstant()
  RVA=0x097A82A0  token=0x60005D1  System.Boolean IsTableConstant()
  RVA=0x097A8260  token=0x60005D2  System.Boolean HasLocalAggregate()
  RVA=0x097A8280  token=0x60005D3  System.Boolean HasRemoteAggregate()
  RVA=0x097A80FC  token=0x60005D4  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x0339AE90  token=0x60005D5  System.Data.ExpressionNode Optimize()
  RVA=0x097A82C0  token=0x60005D6  System.String ParseName(System.Char[] text, System.Int32 start, System.Int32 pos)
END_CLASS

CLASS: System.Data.Operators
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x10
FIELDS:
  private   static readonly System.Int32[]                  s_priority  // static @ 0x0
  private   static readonly System.String[]                 s_looks  // static @ 0x8
METHODS:
  RVA=0x097B07A8  token=0x60005D7  System.Boolean IsArithmetical(System.Int32 op)
  RVA=0x097B07BC  token=0x60005D8  System.Boolean IsLogical(System.Int32 op)
  RVA=0x097B07D8  token=0x60005D9  System.Boolean IsRelational(System.Int32 op)
  RVA=0x097B07E8  token=0x60005DA  System.Int32 Priority(System.Int32 op)
  RVA=0x097B0874  token=0x60005DB  System.String ToString(System.Int32 op)
  RVA=0x097B0914  token=0x60005DC  System.Void .cctor()
END_CLASS

CLASS: System.Data.UnaryNode
TYPE:  sealed class
TOKEN: 0x2000063
SIZE:  0x28
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.Int32                    _op  // 0x18
  private           System.Data.ExpressionNode      _right  // 0x20
METHODS:
  RVA=0x03020510  token=0x60005DD  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode right)
  RVA=0x097B6E24  token=0x60005DE  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x09796F28  token=0x60005DF  System.Object Eval()
  RVA=0x097B75C0  token=0x60005E0  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097B75A0  token=0x60005E1  System.Object Eval(System.Int32[] recordNos)
  RVA=0x097B6E80  token=0x60005E2  System.Object EvalUnaryOp(System.Int32 op, System.Object vl)
  RVA=0x097B7650  token=0x60005E3  System.Boolean IsConstant()
  RVA=0x097B7674  token=0x60005E4  System.Boolean IsTableConstant()
  RVA=0x097B7608  token=0x60005E5  System.Boolean HasLocalAggregate()
  RVA=0x097B762C  token=0x60005E6  System.Boolean HasRemoteAggregate()
  RVA=0x097B6E5C  token=0x60005E7  System.Boolean DependsOn(System.Data.DataColumn column)
  RVA=0x097B7698  token=0x60005E8  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.ZeroOpNode
TYPE:  sealed class
TOKEN: 0x2000064
SIZE:  0x20
EXTENDS: System.Data.ExpressionNode
FIELDS:
  private   readonly System.Int32                    _op  // 0x18
METHODS:
  RVA=0x097BBAC8  token=0x60005E9  System.Void .ctor(System.Int32 op)
  RVA=0x0350B670  token=0x60005EA  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  RVA=0x097BBA40  token=0x60005EB  System.Object Eval()
  RVA=0x0979D02C  token=0x60005EC  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0979D02C  token=0x60005ED  System.Object Eval(System.Int32[] recordNos)
  RVA=0x0232EB60  token=0x60005EE  System.Boolean IsConstant()
  RVA=0x0232EB60  token=0x60005EF  System.Boolean IsTableConstant()
  RVA=0x0115F4C0  token=0x60005F0  System.Boolean HasLocalAggregate()
  RVA=0x0115F4C0  token=0x60005F1  System.Boolean HasRemoteAggregate()
  RVA=0x0339AE90  token=0x60005F2  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.ForeignKeyConstraint
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x78
EXTENDS: System.Data.Constraint
FIELDS:
  private           System.Data.Rule                _deleteRule  // 0x38
  private           System.Data.Rule                _updateRule  // 0x3c
  private           System.Data.AcceptRejectRule    _acceptRejectRule  // 0x40
  private           System.Data.DataKey             _childKey  // 0x48
  private           System.Data.DataKey             _parentKey  // 0x50
  private           System.String                   _constraintName  // 0x58
  private           System.String[]                 _parentColumnNames  // 0x60
  private           System.String[]                 _childColumnNames  // 0x68
  private           System.String                   _parentTableName  // 0x70
PROPERTIES:
  ChildKey  get=0x097AAE40
  Columns  get=0x097AAE5C
  Table  get=0x097AAF00
  ParentColumnNames  get=0x097AAE98
  ChildColumnNames  get=0x097AAE34
  AcceptRejectRule  get=0x097AAE18  set=0x097AAF3C
  DeleteRule  get=0x097AAE7C  set=0x097AAF8C
  RelatedColumns  get=0x097AAEC0
  RelatedColumnsReference  get=0x097AAEA4
  ParentKey  get=0x097AAEA4
  RelatedTable  get=0x097AAEE0
  UpdateRule  get=0x097AAF20  set=0x097AAFDC
METHODS:
  RVA=0x097AAD94  token=0x60005F3  System.Void .ctor(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  RVA=0x097AADB4  token=0x60005F4  System.Void .ctor(System.String constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  RVA=0x097AACFC  token=0x60005F5  System.Void .ctor(System.String constraintName, System.String parentTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule)
  RVA=0x097A92CC  token=0x60005FB  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints)
  RVA=0x0232EB60  token=0x60005FC  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException)
  RVA=0x097AAA08  token=0x60005FD  System.Boolean IsKeyNull(System.Object[] values)
  RVA=0x097AA868  token=0x60005FE  System.Boolean IsConstraintViolated()
  RVA=0x097A85F8  token=0x60005FF  System.Boolean CanEnableConstraint()
  RVA=0x097A8724  token=0x6000600  System.Void CascadeCommit(System.Data.DataRow row)
  RVA=0x097A887C  token=0x6000601  System.Void CascadeDelete(System.Data.DataRow row)
  RVA=0x097A8CD4  token=0x6000602  System.Void CascadeRollback(System.Data.DataRow row)
  RVA=0x097A8EC4  token=0x6000603  System.Void CascadeUpdate(System.Data.DataRow row)
  RVA=0x097A93C4  token=0x6000604  System.Void CheckCanClearParentTable(System.Data.DataTable table)
  RVA=0x097A9480  token=0x6000605  System.Void CheckCanRemoveParentRow(System.Data.DataRow row)
  RVA=0x097A952C  token=0x6000606  System.Void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=0x097A969C  token=0x6000607  System.Void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action)
  RVA=0x097AAA8C  token=0x6000608  System.Void NonVirtualCheckState()
  RVA=0x097A9944  token=0x6000609  System.Void CheckState()
  RVA=0x097AA510  token=0x600060C  System.Boolean ContainsColumn(System.Data.DataColumn column)
  RVA=0x097AA500  token=0x600060D  System.Data.Constraint Clone(System.Data.DataSet destination)
  RVA=0x097A994C  token=0x600060E  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup)
  RVA=0x097AA024  token=0x600060F  System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination)
  RVA=0x097AA550  token=0x6000610  System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  RVA=0x097AA718  token=0x6000613  System.Boolean Equals(System.Object key)
  RVA=0x03D4F970  token=0x6000614  System.Int32 GetHashCode()
  RVA=0x097AA7DC  token=0x6000618  System.Data.DataRelation FindParentRelation()
END_CLASS

CLASS: System.Data.MappingType
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.MappingType         Element  // const
  public    static  System.Data.MappingType         Attribute  // const
  public    static  System.Data.MappingType         SimpleContent  // const
  public    static  System.Data.MappingType         Hidden  // const
METHODS:
END_CLASS

CLASS: System.Data.MergeFailedEventArgs
TYPE:  class
TOKEN: 0x2000067
SIZE:  0x20
EXTENDS: System.EventArgs
FIELDS:
  private   readonly System.Data.DataTable           <Table>k__BackingField  // 0x10
  private   readonly System.String                   <Conflict>k__BackingField  // 0x18
PROPERTIES:
  Conflict  get=0x01041090
METHODS:
  RVA=0x097AE1A8  token=0x600061C  System.Void .ctor(System.Data.DataTable table, System.String conflict)
END_CLASS

CLASS: System.Data.MergeFailedEventHandler
TYPE:  sealed class
TOKEN: 0x2000068
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x071EA4CC  token=0x600061E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x600061F  System.Void Invoke(System.Object sender, System.Data.MergeFailedEventArgs e)
END_CLASS

CLASS: System.Data.Merger
TYPE:  sealed class
TOKEN: 0x2000069
SIZE:  0x30
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.DataTable           _dataTable  // 0x18
  private           System.Boolean                  _preserveChanges  // 0x20
  private           System.Data.MissingSchemaAction _missingSchemaAction  // 0x24
  private           System.Boolean                  _isStandAlonetable  // 0x28
  private           System.Boolean                  _IgnoreNSforTableLookup  // 0x29
METHODS:
  RVA=0x097B0774  token=0x6000620  System.Void .ctor(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  RVA=0x097B073C  token=0x6000621  System.Void .ctor(System.Data.DataTable dataTable, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  RVA=0x097AE650  token=0x6000622  System.Void MergeDataSet(System.Data.DataSet source)
  RVA=0x097B00E4  token=0x6000623  System.Void MergeTable(System.Data.DataTable src)
  RVA=0x097B0380  token=0x6000624  System.Void MergeTable(System.Data.DataTable src, System.Data.DataTable dst)
  RVA=0x097AF900  token=0x6000625  System.Data.DataTable MergeSchema(System.Data.DataTable table)
  RVA=0x097B0040  token=0x6000626  System.Void MergeTableData(System.Data.DataTable src)
  RVA=0x097AE34C  token=0x6000627  System.Void MergeConstraints(System.Data.DataSet source)
  RVA=0x097AE3BC  token=0x6000628  System.Void MergeConstraints(System.Data.DataTable table)
  RVA=0x097AF120  token=0x6000629  System.Void MergeRelation(System.Data.DataRelation relation)
  RVA=0x097AF03C  token=0x600062A  System.Void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst)
  RVA=0x097AE214  token=0x600062B  System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst)
END_CLASS

CLASS: System.Data.MissingSchemaAction
TYPE:  sealed struct
TOKEN: 0x200006A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.MissingSchemaAction Add  // const
  public    static  System.Data.MissingSchemaAction Ignore  // const
  public    static  System.Data.MissingSchemaAction Error  // const
  public    static  System.Data.MissingSchemaAction AddWithKey  // const
METHODS:
END_CLASS

CLASS: System.Data.PrimaryKeyTypeConverter
TYPE:  sealed class
TOKEN: 0x200006B
SIZE:  0x18
EXTENDS: System.ComponentModel.ReferenceConverter
FIELDS:
METHODS:
  RVA=0x097B10B0  token=0x600062C  System.Void .ctor()
  RVA=0x0115F4C0  token=0x600062D  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  RVA=0x097B0ED0  token=0x600062E  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  RVA=0x097B0F64  token=0x600062F  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.PropertyCollection
TYPE:  class
TOKEN: 0x200006C
SIZE:  0x50
EXTENDS: System.Collections.Hashtable
IMPLEMENTS: System.ICloneable
FIELDS:
METHODS:
  RVA=0x04270E50  token=0x6000630  System.Void .ctor()
  RVA=0x097B12F8  token=0x6000631  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x097B1138  token=0x6000632  System.Object Clone()
END_CLASS

CLASS: System.Data.Range
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x1C
FIELDS:
  private           System.Int32                    _min  // 0x10
  private           System.Int32                    _max  // 0x14
  private           System.Boolean                  _isNotNull  // 0x18
PROPERTIES:
  Count  get=0x097B139C
  IsNull  get=0x057FD3F0
  Min  get=0x097B13B0
METHODS:
  RVA=0x097B1354  token=0x6000633  System.Void .ctor(System.Int32 min, System.Int32 max)
  RVA=0x097B1318  token=0x6000637  System.Void CheckNull()
END_CLASS

CLASS: System.Data.RBTreeError
TYPE:  sealed struct
TOKEN: 0x200006E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.RBTreeError         InvalidPageSize  // const
  public    static  System.Data.RBTreeError         PagePositionInSlotInUse  // const
  public    static  System.Data.RBTreeError         NoFreeSlots  // const
  public    static  System.Data.RBTreeError         InvalidStateinInsert  // const
  public    static  System.Data.RBTreeError         InvalidNextSizeInDelete  // const
  public    static  System.Data.RBTreeError         InvalidStateinDelete  // const
  public    static  System.Data.RBTreeError         InvalidNodeSizeinDelete  // const
  public    static  System.Data.RBTreeError         InvalidStateinEndDelete  // const
  public    static  System.Data.RBTreeError         CannotRotateInvalidsuccessorNodeinDelete  // const
  public    static  System.Data.RBTreeError         IndexOutOFRangeinGetNodeByIndex  // const
  public    static  System.Data.RBTreeError         RBDeleteFixup  // const
  public    static  System.Data.RBTreeError         UnsupportedAccessMethod1  // const
  public    static  System.Data.RBTreeError         UnsupportedAccessMethod2  // const
  public    static  System.Data.RBTreeError         UnsupportedAccessMethodInNonNillRootSubtree  // const
  public    static  System.Data.RBTreeError         AttachedNodeWithZerorbTreeNodeId  // const
  public    static  System.Data.RBTreeError         CompareNodeInDataRowTree  // const
  public    static  System.Data.RBTreeError         CompareSateliteTreeNodeInDataRowTree  // const
  public    static  System.Data.RBTreeError         NestedSatelliteTreeEnumerator  // const
METHODS:
END_CLASS

CLASS: System.Data.TreeAccessMethod
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.TreeAccessMethod    KEY_SEARCH_AND_INDEX  // const
  public    static  System.Data.TreeAccessMethod    INDEX_ONLY  // const
METHODS:
END_CLASS

CLASS: System.Data.RBTree`1
TYPE:  abstract class
TOKEN: 0x2000070
IMPLEMENTS: System.Collections.IEnumerable
FIELDS:
  private           System.Data.RBTree.TreePage<K>[]_pageTable  // 0x0
  private           System.Int32[]                  _pageTableMap  // 0x0
  private           System.Int32                    _inUsePageCount  // 0x0
  private           System.Int32                    _nextFreePageLine  // 0x0
  public            System.Int32                    root  // 0x0
  private           System.Int32                    _version  // 0x0
  private           System.Int32                    _inUseNodeCount  // 0x0
  private           System.Int32                    _inUseSatelliteTreeCount  // 0x0
  private   readonly System.Data.TreeAccessMethod    _accessMethod  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
  HasDuplicates  get=-1  // not resolved
  Item  get=-1  // not resolved
METHODS:
  RVA=-1  // abstract  token=0x6000638  System.Int32 CompareNode(K record1, K record2)
  RVA=-1  // abstract  token=0x6000639  System.Int32 CompareSateliteTreeNode(K record1, K record2)
  RVA=-1  // not resolved  token=0x600063A  System.Void .ctor(System.Data.TreeAccessMethod accessMethod)
  RVA=-1  // not resolved  token=0x600063B  System.Void InitTree()
  RVA=-1  // not resolved  token=0x600063C  System.Void FreePage(System.Data.RBTree.TreePage<K> page)
  RVA=-1  // not resolved  token=0x600063D  System.Data.RBTree.TreePage<K> AllocPage(System.Int32 size)
  RVA=-1  // not resolved  token=0x600063E  System.Void MarkPageFull(System.Data.RBTree.TreePage<K> page)
  RVA=-1  // not resolved  token=0x600063F  System.Void MarkPageFree(System.Data.RBTree.TreePage<K> page)
  RVA=-1  // not resolved  token=0x6000640  System.Int32 GetIntValueFromBitMap(System.UInt32 bitMap)
  RVA=-1  // not resolved  token=0x6000641  System.Void FreeNode(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000642  System.Int32 GetIndexOfPageWithFreeSlot(System.Boolean allocatedPage)
  RVA=-1  // not resolved  token=0x6000645  System.Int32 GetNewNode(K key)
  RVA=-1  // not resolved  token=0x6000646  System.Int32 Successor(System.Int32 x_id)
  RVA=-1  // not resolved  token=0x6000647  System.Boolean Successor(System.Int32& nodeId, System.Int32& mainTreeNodeId)
  RVA=-1  // not resolved  token=0x6000648  System.Int32 Minimum(System.Int32 x_id)
  RVA=-1  // not resolved  token=0x6000649  System.Int32 LeftRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode)
  RVA=-1  // not resolved  token=0x600064A  System.Int32 RightRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode)
  RVA=-1  // not resolved  token=0x600064B  System.Int32 RBInsert(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNodeID, System.Int32 position, System.Boolean append)
  RVA=-1  // not resolved  token=0x600064C  System.Void UpdateNodeKey(K currentKey, K newKey)
  RVA=-1  // not resolved  token=0x600064D  K DeleteByIndex(System.Int32 i)
  RVA=-1  // not resolved  token=0x600064E  System.Int32 RBDelete(System.Int32 z_id)
  RVA=-1  // not resolved  token=0x600064F  System.Int32 RBDeleteX(System.Int32 root_id, System.Int32 z_id, System.Int32 mainTreeNodeID)
  RVA=-1  // not resolved  token=0x6000650  System.Int32 RBDeleteFixup(System.Int32 root_id, System.Int32 x_id, System.Int32 px_id, System.Int32 mainTreeNodeID)
  RVA=-1  // not resolved  token=0x6000651  System.Int32 SearchSubTree(System.Int32 root_id, K key)
  RVA=-1  // not resolved  token=0x6000653  System.Data.RBTree.NodePath<K> GetNodeByKey(K key)
  RVA=-1  // not resolved  token=0x6000654  System.Int32 GetIndexByKey(K key)
  RVA=-1  // not resolved  token=0x6000655  System.Int32 GetIndexByNode(System.Int32 node)
  RVA=-1  // not resolved  token=0x6000656  System.Int32 GetIndexByNodePath(System.Data.RBTree.NodePath<K> path)
  RVA=-1  // not resolved  token=0x6000657  System.Int32 ComputeIndexByNode(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000658  System.Int32 ComputeIndexWithSatelliteByNode(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000659  System.Data.RBTree.NodePath<K> GetNodeByIndex(System.Int32 userIndex)
  RVA=-1  // not resolved  token=0x600065A  System.Int32 ComputeNodeByIndex(System.Int32 index, System.Int32& satelliteRootId)
  RVA=-1  // not resolved  token=0x600065B  System.Int32 ComputeNodeByIndex(System.Int32 x_id, System.Int32 index)
  RVA=-1  // not resolved  token=0x600065C  System.Int32 Insert(K item)
  RVA=-1  // not resolved  token=0x600065D  System.Int32 Add(K item)
  RVA=-1  // not resolved  token=0x600065E  System.Collections.IEnumerator GetEnumerator()
  RVA=-1  // not resolved  token=0x600065F  System.Int32 IndexOf(System.Int32 nodeId, K item)
  RVA=-1  // not resolved  token=0x6000660  System.Int32 Insert(System.Int32 position, K item)
  RVA=-1  // not resolved  token=0x6000661  System.Int32 InsertAt(System.Int32 position, K item, System.Boolean append)
  RVA=-1  // not resolved  token=0x6000662  System.Void RemoveAt(System.Int32 position)
  RVA=-1  // not resolved  token=0x6000663  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000664  System.Void CopyTo(System.Array array, System.Int32 index)
  RVA=-1  // not resolved  token=0x6000665  System.Void CopyTo(K[] array, System.Int32 index)
  RVA=-1  // not resolved  token=0x6000666  System.Void SetRight(System.Int32 nodeId, System.Int32 rightNodeId)
  RVA=-1  // not resolved  token=0x6000667  System.Void SetLeft(System.Int32 nodeId, System.Int32 leftNodeId)
  RVA=-1  // not resolved  token=0x6000668  System.Void SetParent(System.Int32 nodeId, System.Int32 parentNodeId)
  RVA=-1  // not resolved  token=0x6000669  System.Void SetColor(System.Int32 nodeId, System.Data.RBTree.NodeColor<K> color)
  RVA=-1  // not resolved  token=0x600066A  System.Void SetKey(System.Int32 nodeId, K key)
  RVA=-1  // not resolved  token=0x600066B  System.Void SetNext(System.Int32 nodeId, System.Int32 nextNodeId)
  RVA=-1  // not resolved  token=0x600066C  System.Void SetSubTreeSize(System.Int32 nodeId, System.Int32 size)
  RVA=-1  // not resolved  token=0x600066D  System.Void IncreaseSize(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x600066E  System.Void RecomputeSize(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x600066F  System.Void DecreaseSize(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000670  System.Int32 Right(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000671  System.Int32 Left(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000672  System.Int32 Parent(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000673  System.Data.RBTree.NodeColor<K> color(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000674  System.Int32 Next(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000675  System.Int32 SubTreeSize(System.Int32 nodeId)
  RVA=-1  // not resolved  token=0x6000676  K Key(System.Int32 nodeId)
END_CLASS

CLASS: System.Data.RecordManager
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x38
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private           System.Int32                    _lastFreeRecord  // 0x18
  private           System.Int32                    _minimumCapacity  // 0x1c
  private           System.Int32                    _recordCapacity  // 0x20
  private   readonly System.Collections.Generic.List<System.Int32>_freeRecordList  // 0x28
  private           System.Data.DataRow[]           _rows  // 0x30
PROPERTIES:
  LastFreeRecord  get=0x020D1AC0
  MinimumCapacity  get=0x03D4EBB0  set=0x097B1CB8
  RecordCapacity  get=0x01003B50  set=0x097B1CF4
  Item  get=0x097B1C40  set=0x097B1C6C
METHODS:
  RVA=0x097B1B74  token=0x6000685  System.Void .ctor(System.Data.DataTable table)
  RVA=0x097B191C  token=0x6000686  System.Void GrowRecordCapacity()
  RVA=0x097B1A40  token=0x600068C  System.Int32 NewCapacity(System.Int32 capacity)
  RVA=0x097B1B08  token=0x600068D  System.Int32 NormalizedMinimumCapacity(System.Int32 capacity)
  RVA=0x097B1A50  token=0x600068E  System.Int32 NewRecordBase()
  RVA=0x097B1820  token=0x600068F  System.Void FreeRecord(System.Int32& record)
  RVA=0x097B13C8  token=0x6000690  System.Void Clear(System.Boolean clearAll)
  RVA=0x097B1A20  token=0x6000693  System.Int32 ImportRecord(System.Data.DataTable src, System.Int32 record)
  RVA=0x097B157C  token=0x6000694  System.Int32 CopyRecord(System.Data.DataTable src, System.Int32 record, System.Int32 copy)
  RVA=0x097B1B40  token=0x6000695  System.Void SetRowCache(System.Data.DataRow[] newRows)
END_CLASS

CLASS: System.Data.RelatedView
TYPE:  sealed class
TOKEN: 0x2000077
SIZE:  0xD8
EXTENDS: System.Data.DataView
IMPLEMENTS: System.Data.IFilter
FIELDS:
  private   readonly System.Nullable<System.Data.DataKey>_parentKey  // 0xb0
  private   readonly System.Data.DataKey             _childKey  // 0xc0
  private   readonly System.Data.DataRowView         _parentRowView  // 0xc8
  private   readonly System.Object[]                 _filterValues  // 0xd0
METHODS:
  RVA=0x097B1F9C  token=0x6000696  System.Void .ctor(System.Data.DataColumn[] columns, System.Object[] values)
  RVA=0x097B20E8  token=0x6000697  System.Void .ctor(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns)
  RVA=0x097B1DEC  token=0x6000698  System.Object[] GetParentValues()
  RVA=0x097B1E88  token=0x6000699  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x0339AE90  token=0x600069A  System.Data.IFilter GetFilter()
  RVA=0x097B1D7C  token=0x600069B  System.Data.DataRowView AddNew()
  RVA=0x097B1F70  token=0x600069C  System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter)
END_CLASS

CLASS: System.Data.RelationshipConverter
TYPE:  sealed class
TOKEN: 0x2000078
SIZE:  0x10
EXTENDS: System.ComponentModel.ExpandableObjectConverter
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600069D  System.Void .ctor()
  RVA=0x097B2224  token=0x600069E  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  RVA=0x097B22B8  token=0x600069F  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.Rule
TYPE:  sealed struct
TOKEN: 0x2000079
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Rule                None  // const
  public    static  System.Data.Rule                Cascade  // const
  public    static  System.Data.Rule                SetNull  // const
  public    static  System.Data.Rule                SetDefault  // const
METHODS:
END_CLASS

CLASS: System.Data.SchemaSerializationMode
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SchemaSerializationModeIncludeSchema  // const
  public    static  System.Data.SchemaSerializationModeExcludeSchema  // const
METHODS:
END_CLASS

CLASS: System.Data.Select
TYPE:  sealed class
TOKEN: 0x200007B
SIZE:  0x70
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.IndexField[]        _indexFields  // 0x18
  private           System.Data.DataViewRowState    _recordStates  // 0x20
  private           System.Data.DataExpression      _rowFilter  // 0x28
  private           System.Data.ExpressionNode      _expression  // 0x30
  private           System.Data.Index               _index  // 0x38
  private           System.Int32[]                  _records  // 0x40
  private           System.Int32                    _recordCount  // 0x48
  private           System.Data.ExpressionNode      _linearExpression  // 0x50
  private           System.Boolean                  _candidatesForBinarySearch  // 0x58
  private           System.Data.Select.ColumnInfo[] _candidateColumns  // 0x60
  private           System.Int32                    _nCandidates  // 0x68
  private           System.Int32                    _matchedCandidates  // 0x6c
METHODS:
  RVA=0x097B5674  token=0x60006A0  System.Void .ctor(System.Data.DataTable table, System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates)
  RVA=0x097B5234  token=0x60006A1  System.Boolean IsSupportedOperator(System.Int32 op)
  RVA=0x097B2CE4  token=0x60006A2  System.Void AnalyzeExpression(System.Data.BinaryNode expr)
  RVA=0x097B35C8  token=0x60006A3  System.Boolean CompareSortIndexDesc(System.Data.IndexField[] fields)
  RVA=0x097B4900  token=0x60006A4  System.Boolean FindSortIndex()
  RVA=0x097B32B8  token=0x60006A5  System.Int32 CompareClosestCandidateIndexDesc(System.Data.IndexField[] fields)
  RVA=0x097B453C  token=0x60006A6  System.Boolean FindClosestCandidateIndex()
  RVA=0x097B5088  token=0x60006A7  System.Void InitCandidateColumns()
  RVA=0x097B36FC  token=0x60006A8  System.Void CreateIndex()
  RVA=0x097B51B0  token=0x60006A9  System.Boolean IsOperatorIn(System.Data.ExpressionNode enode)
  RVA=0x097B30FC  token=0x60006AA  System.Void BuildLinearExpression()
  RVA=0x097B524C  token=0x60006AB  System.Data.DataRow[] SelectRows()
  RVA=0x097B4FD4  token=0x60006AC  System.Data.DataRow[] GetRows()
  RVA=0x097B2B5C  token=0x60006AD  System.Boolean AcceptRecord(System.Int32 record)
  RVA=0x097B3D54  token=0x60006AE  System.Int32 Eval(System.Data.BinaryNode expr, System.Data.DataRow row, System.Data.DataRowVersion version)
  RVA=0x097B4408  token=0x60006AF  System.Int32 Evaluate(System.Int32 record)
  RVA=0x097B47CC  token=0x60006B0  System.Int32 FindFirstMatchingRecord()
  RVA=0x097B4868  token=0x60006B1  System.Int32 FindLastMatchingRecord(System.Int32 lo)
  RVA=0x097B4B24  token=0x60006B2  System.Data.Range GetBinaryFilteredRecords()
  RVA=0x097B4BD4  token=0x60006B3  System.Int32[] GetLinearFilteredRecords(System.Data.Range range)
  RVA=0x097B4DFC  token=0x60006B4  System.Data.DataRow[] GetLinearFilteredRows(System.Data.Range range)
  RVA=0x097B3360  token=0x60006B5  System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2)
  RVA=0x097B5524  token=0x60006B6  System.Void Sort(System.Int32 left, System.Int32 right)
END_CLASS

CLASS: System.Data.IndexField
TYPE:  sealed struct
TOKEN: 0x200007D
SIZE:  0x20
FIELDS:
  public    readonly System.Data.DataColumn          Column  // 0x10
  public    readonly System.Boolean                  IsDescending  // 0x18
METHODS:
  RVA=0x071B198C  token=0x60006B8  System.Void .ctor(System.Data.DataColumn column, System.Boolean isDescending)
  RVA=0x097AB124  token=0x60006B9  System.Boolean op_Equality(System.Data.IndexField if1, System.Data.IndexField if2)
  RVA=0x097AB02C  token=0x60006BA  System.Boolean Equals(System.Object obj)
  RVA=0x097AB0B0  token=0x60006BB  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Data.Index
TYPE:  sealed class
TOKEN: 0x200007E
SIZE:  0x58
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.IndexField[]        _indexFields  // 0x18
  private   readonly System.Comparison<System.Data.DataRow>_comparison  // 0x20
  private   readonly System.Data.DataViewRowState    _recordStates  // 0x28
  private           System.WeakReference            _rowFilter  // 0x30
  private           System.Data.Index.IndexTree     _records  // 0x38
  private           System.Int32                    _recordCount  // 0x40
  private           System.Int32                    _refCount  // 0x44
  private           System.Data.Listeners<System.Data.DataViewListener>_listeners  // 0x48
  private           System.Boolean                  _suspendEvents  // 0x50
  private   readonly System.Boolean                  _isSharable  // 0x51
  private   readonly System.Boolean                  _hasRemoteAggregate  // 0x52
  private   static  System.Int32                    s_objectTypeCount  // static @ 0x0
  private   readonly System.Int32                    _objectID  // 0x54
PROPERTIES:
  HasRemoteAggregate  get=0x03D58990
  ObjectID  get=0x03D4EEC0
  RecordStates  get=0x03D4EB90
  RowFilter  get=0x097AE150
  HasDuplicates  get=0x097AE10C
  RecordCount  get=0x03D4ED80
  IsSharable  get=0x03D518F0
  RefCount  get=0x03D4EE80
  DoListChanged  get=0x097AE0A4
  Table  get=0x020B7B20
METHODS:
  RVA=0x097AE078  token=0x60006BC  System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x097ADCFC  token=0x60006BD  System.Void .ctor(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x097AC15C  token=0x60006BE  System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns)
  RVA=0x097ADD6C  token=0x60006BF  System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x097ABA84  token=0x60006C0  System.Boolean Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  RVA=0x097AC5E4  token=0x60006C5  System.Int32 GetRecord(System.Int32 recordIndex)
  RVA=0x097AB2DC  token=0x60006C9  System.Boolean AcceptRecord(System.Int32 record)
  RVA=0x097AB1D4  token=0x60006CA  System.Boolean AcceptRecord(System.Int32 record, System.Data.IFilter filter)
  RVA=0x097AD060  token=0x60006CB  System.Void ListChangedAdd(System.Data.DataViewListener listener)
  RVA=0x097AD0B4  token=0x60006CC  System.Void ListChangedRemove(System.Data.DataViewListener listener)
  RVA=0x097AB30C  token=0x60006CE  System.Void AddRef()
  RVA=0x097ADAA0  token=0x60006CF  System.Int32 RemoveRef()
  RVA=0x097AB4A0  token=0x60006D0  System.Void ApplyChangeAction(System.Int32 record, System.Int32 action, System.Int32 changeRecord)
  RVA=0x097AB518  token=0x60006D1  System.Boolean CheckUnique()
  RVA=0x097AB814  token=0x60006D2  System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2)
  RVA=0x097AB52C  token=0x60006D3  System.Int32 CompareDataRows(System.Int32 record1, System.Int32 record2)
  RVA=0x097AB5B4  token=0x60006D4  System.Int32 CompareDuplicateRecords(System.Int32 record1, System.Int32 record2)
  RVA=0x097AB758  token=0x60006D5  System.Int32 CompareRecordToKey(System.Int32 record1, System.Object[] vals)
  RVA=0x097AB960  token=0x60006D6  System.Void DeleteRecordFromIndex(System.Int32 recordIndex)
  RVA=0x097ABA78  token=0x60006D7  System.Void DeleteRecord(System.Int32 recordIndex)
  RVA=0x097AB96C  token=0x60006D8  System.Void DeleteRecord(System.Int32 recordIndex, System.Boolean fireEvent)
  RVA=0x097AC238  token=0x60006D9  System.Data.RBTree.RBTreeEnumerator<System.Int32> GetEnumerator(System.Int32 startIndex)
  RVA=0x097AC2A4  token=0x60006DA  System.Int32 GetIndex(System.Int32 record)
  RVA=0x097AC2F8  token=0x60006DB  System.Int32 GetIndex(System.Int32 record, System.Int32 changeRecord)
  RVA=0x097AC7F0  token=0x60006DC  System.Object[] GetUniqueKeyValues()
  RVA=0x097ABC18  token=0x60006DD  System.Int32 FindNodeByKey(System.Object originalKey)
  RVA=0x097ABE10  token=0x60006DE  System.Int32 FindNodeByKeys(System.Object[] originalKey)
  RVA=0x097ABB40  token=0x60006DF  System.Int32 FindNodeByKeyRecord(System.Int32 record)
  RVA=0x097AC4B8  token=0x60006E0  System.Data.Range GetRangeFromNode(System.Int32 nodeId)
  RVA=0x097AC048  token=0x60006E1  System.Data.Range FindRecords(System.Object key)
  RVA=0x097ABFF8  token=0x60006E2  System.Data.Range FindRecords(System.Object[] key)
  RVA=0x097AC098  token=0x60006E3  System.Void FireResetEvent()
  RVA=0x097AC21C  token=0x60006E4  System.Int32 GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  RVA=0x097AC638  token=0x60006E5  System.Int32 GetReplaceAction(System.Data.DataViewRowState oldState)
  RVA=0x097AC650  token=0x60006E6  System.Data.DataRow GetRow(System.Int32 i)
  RVA=0x097AC7AC  token=0x60006E7  System.Data.DataRow[] GetRows(System.Object[] values)
  RVA=0x097AC688  token=0x60006E8  System.Data.DataRow[] GetRows(System.Data.Range range)
  RVA=0x097ACA50  token=0x60006E9  System.Void InitRecords(System.Data.IFilter filter)
  RVA=0x097ACDE0  token=0x60006EA  System.Int32 InsertRecordToIndex(System.Int32 record)
  RVA=0x097ACE20  token=0x60006EB  System.Int32 InsertRecord(System.Int32 record, System.Boolean fireEvent)
  RVA=0x097AD018  token=0x60006EC  System.Boolean IsKeyInIndex(System.Object key)
  RVA=0x097AD030  token=0x60006ED  System.Boolean IsKeyInIndex(System.Object[] key)
  RVA=0x097AD048  token=0x60006EE  System.Boolean IsKeyRecordInIndex(System.Int32 record)
  RVA=0x097AD2BC  token=0x60006F0  System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 newIndex, System.Int32 oldIndex)
  RVA=0x097AD228  token=0x60006F1  System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 index)
  RVA=0x097AD368  token=0x60006F2  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  RVA=0x097AD108  token=0x60006F3  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Int32 record, System.Boolean trackAddRemove)
  RVA=0x097ADC40  token=0x60006F4  System.Void Reset()
  RVA=0x097AD5F0  token=0x60006F5  System.Void RecordChanged(System.Int32 record)
  RVA=0x097AD4F4  token=0x60006F6  System.Void RecordChanged(System.Int32 oldIndex, System.Int32 newIndex)
  RVA=0x097AD9B0  token=0x60006F7  System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  RVA=0x097AD6B8  token=0x60006F8  System.Void RecordStateChanged(System.Int32 oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, System.Int32 newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState)
  RVA=0x097AC8BC  token=0x60006FA  System.Void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, System.Int32 curNodeId)
  RVA=-1  // generic def  token=0x60006FB  System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item)
END_CLASS

CLASS: System.Data.Listeners`1
TYPE:  sealed class
TOKEN: 0x2000082
FIELDS:
  private   readonly System.Collections.Generic.List<TElem>_listeners  // 0x0
  private   readonly System.Data.Listeners.Func<TElem,TElem,System.Boolean>_filter  // 0x0
  private   readonly System.Int32                    _objectID  // 0x0
  private           System.Int32                    _listenerReaderCount  // 0x0
PROPERTIES:
  HasListeners  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000705  System.Void .ctor(System.Int32 ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter)
  RVA=-1  // not resolved  token=0x6000707  System.Void Add(TElem listener)
  RVA=-1  // not resolved  token=0x6000708  System.Int32 IndexOfReference(TElem listener)
  RVA=-1  // not resolved  token=0x6000709  System.Void Remove(TElem listener)
  RVA=-1  // generic def  token=0x600070A  System.Void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action)
  RVA=-1  // not resolved  token=0x600070B  System.Void RemoveNullListeners(System.Int32 nullIndex)
END_CLASS

CLASS: System.Data.SimpleType
TYPE:  sealed class
TOKEN: 0x2000085
SIZE:  0x78
IMPLEMENTS: System.Runtime.Serialization.ISerializable
FIELDS:
  private           System.String                   _baseType  // 0x10
  private           System.Data.SimpleType          _baseSimpleType  // 0x18
  private           System.Xml.XmlQualifiedName     _xmlBaseType  // 0x20
  private           System.String                   _name  // 0x28
  private           System.Int32                    _length  // 0x30
  private           System.Int32                    _minLength  // 0x34
  private           System.Int32                    _maxLength  // 0x38
  private           System.String                   _pattern  // 0x40
  private           System.String                   _ns  // 0x48
  private           System.String                   _maxExclusive  // 0x50
  private           System.String                   _maxInclusive  // 0x58
  private           System.String                   _minExclusive  // 0x60
  private           System.String                   _minInclusive  // 0x68
  private           System.String                   _enumeration  // 0x70
PROPERTIES:
  BaseType  get=0x020B7B20
  XmlBaseType  get=0x03D4EB40
  Name  get=0x03D4EAC0
  Namespace  get=0x03D4EA70
  Length  get=0x03D4ED20
  MaxLength  get=0x03D4EC30  set=0x03D4ECB0
  BaseSimpleType  get=0x01041090
  SimpleTypeQualifiedName  get=0x097B6D00
METHODS:
  RVA=0x097B69E0  token=0x6000710  System.Void .ctor(System.String baseType)
  RVA=0x097B6B24  token=0x6000711  System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType node)
  RVA=0x097B65BC  token=0x6000712  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x097B5C68  token=0x6000713  System.Void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node)
  RVA=0x097B5B60  token=0x6000714  System.Boolean IsPlainString()
  RVA=0x097B6554  token=0x600071E  System.String QualifiedName(System.String name)
  RVA=0x097B6608  token=0x600071F  System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, System.Boolean inRemoting)
  RVA=0x097B58C4  token=0x6000720  System.Data.SimpleType CreateEnumeratedType(System.String values)
  RVA=0x097B5860  token=0x6000721  System.Data.SimpleType CreateByteArrayType(System.String encoding)
  RVA=0x097B5940  token=0x6000722  System.Data.SimpleType CreateLimitedStringType(System.Int32 length)
  RVA=0x097B59B4  token=0x6000723  System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type)
  RVA=0x097B5A70  token=0x6000724  System.String HasConflictingDefinition(System.Data.SimpleType otherSimpleType)
  RVA=0x097B5760  token=0x6000725  System.Boolean CanHaveMaxLength()
  RVA=0x097B57BC  token=0x6000726  System.Void ConvertToAnnonymousSimpleType()
END_CLASS

CLASS: System.Data.UniqueConstraint
TYPE:  class
TOKEN: 0x2000086
SIZE:  0x60
EXTENDS: System.Data.Constraint
FIELDS:
  private           System.Data.DataKey             _key  // 0x38
  private           System.Data.Index               _constraintIndex  // 0x40
  private           System.Boolean                  _bPrimaryKey  // 0x48
  private           System.String                   _constraintName  // 0x50
  private           System.String[]                 _columnNames  // 0x58
PROPERTIES:
  ColumnNames  get=0x097B876C
  ConstraintIndex  get=0x03D4E2B0
  Columns  get=0x097B8778
  ColumnsReference  get=0x03D4E2A0
  IsPrimaryKey  get=0x097B8784
  InCollection  set=0x097B87D8
  Key  get=0x03D4E2A0
  Table  get=0x097B87C0
METHODS:
  RVA=0x097B85EC  token=0x6000727  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x097B8680  token=0x6000728  System.Void .ctor(System.String name, System.Data.DataColumn[] columns)
  RVA=0x097B85B8  token=0x6000729  System.Void .ctor(System.Data.DataColumn[] columns)
  RVA=0x097B8710  token=0x600072A  System.Void .ctor(System.String name, System.String[] columnNames, System.Boolean isPrimaryKey)
  RVA=0x097B86C0  token=0x600072B  System.Void .ctor(System.String name, System.Data.DataColumn[] columns, System.Boolean isPrimaryKey)
  RVA=0x097B81F8  token=0x600072E  System.Void ConstraintIndexClear()
  RVA=0x097B8230  token=0x600072F  System.Void ConstraintIndexInitialize()
  RVA=0x097B79F8  token=0x6000730  System.Void CheckState()
  RVA=0x097B79F8  token=0x6000731  System.Void NonVirtualCheckState()
  RVA=0x0350B670  token=0x6000732  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints)
  RVA=0x097B7754  token=0x6000733  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException)
  RVA=0x097B78CC  token=0x6000734  System.Boolean CanEnableConstraint()
  RVA=0x097B83D4  token=0x6000735  System.Boolean IsConstraintViolated()
  RVA=0x097B7914  token=0x6000736  System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  RVA=0x097B8274  token=0x6000737  System.Boolean ContainsColumn(System.Data.DataColumn column)
  RVA=0x097AA500  token=0x6000738  System.Data.Constraint Clone(System.Data.DataSet destination)
  RVA=0x097B7D84  token=0x6000739  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup)
  RVA=0x097B7A04  token=0x600073A  System.Data.UniqueConstraint Clone(System.Data.DataTable table)
  RVA=0x097B8280  token=0x600073E  System.Void Create(System.String constraintName, System.Data.DataColumn[] columns)
  RVA=0x097B834C  token=0x600073F  System.Boolean Equals(System.Object key2)
  RVA=0x03D4F970  token=0x6000740  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Data.XDRSchema
TYPE:  sealed class
TOKEN: 0x2000087
SIZE:  0x30
EXTENDS: System.Data.XMLSchema
FIELDS:
  private           System.String                   _schemaName  // 0x10
  private           System.String                   _schemaUri  // 0x18
  private           System.Xml.XmlElement           _schemaRoot  // 0x20
  private           System.Data.DataSet             _ds  // 0x28
  private   static readonly System.Char[]                   s_colonArray  // static @ 0x0
  private   static  System.Data.XDRSchema.NameType[]s_mapNameTypeXdr  // static @ 0x8
  private   static  System.Data.XDRSchema.NameType  s_enumerationNameType  // static @ 0x10
METHODS:
  RVA=0x097BB9B0  token=0x6000744  System.Void .ctor(System.Data.DataSet ds, System.Boolean fInline)
  RVA=0x097BA7B0  token=0x6000745  System.Void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds)
  RVA=0x097B88E4  token=0x6000746  System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node)
  RVA=0x097BA4DC  token=0x6000747  System.Boolean IsTextOnlyContent(System.Xml.XmlElement node)
  RVA=0x097BA67C  token=0x6000748  System.Boolean IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode)
  RVA=0x097B9928  token=0x6000749  System.Data.DataTable HandleTable(System.Xml.XmlElement node)
  RVA=0x097B8820  token=0x600074A  System.Data.XDRSchema.NameType FindNameType(System.String name)
  RVA=0x097BA9AC  token=0x600074B  System.Type ParseDataType(System.String dt, System.String dtValues)
  RVA=0x097B8BAC  token=0x600074C  System.String GetInstanceName(System.Xml.XmlElement node)
  RVA=0x097B90D8  token=0x600074D  System.Void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table)
  RVA=0x097B90B4  token=0x600074E  System.Void GetMinMax(System.Xml.XmlElement elNode, System.Int32& minOccurs, System.Int32& maxOccurs)
  RVA=0x097B8D1C  token=0x600074F  System.Void GetMinMax(System.Xml.XmlElement elNode, System.Boolean isAttribute, System.Int32& minOccurs, System.Int32& maxOccurs)
  RVA=0x097B9AAC  token=0x6000750  System.Void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren)
  RVA=0x097B9E90  token=0x6000751  System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode)
  RVA=0x097B9C24  token=0x6000752  System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node)
  RVA=0x097BAAEC  token=0x6000753  System.Void .cctor()
END_CLASS

CLASS: System.Data.XMLDiffLoader
TYPE:  sealed class
TOKEN: 0x2000089
SIZE:  0x28
FIELDS:
  private           System.Collections.ArrayList    _tables  // 0x10
  private           System.Data.DataSet             _dataSet  // 0x18
  private           System.Data.DataTable           _dataTable  // 0x20
METHODS:
  RVA=0x097BBF40  token=0x6000756  System.Void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader)
  RVA=0x097BBBD4  token=0x6000757  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  RVA=0x097BC094  token=0x6000758  System.Void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader)
  RVA=0x097BC250  token=0x6000759  System.Void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync)
  RVA=0x097BC4FC  token=0x600075A  System.Void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync)
  RVA=0x097BCB2C  token=0x600075B  System.Void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync)
  RVA=0x097BC798  token=0x600075C  System.Void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync)
  RVA=0x097BBDD8  token=0x600075D  System.Data.DataTable GetTable(System.String tableName, System.String ns)
  RVA=0x097BCE0C  token=0x600075E  System.Int32 ReadOldRowData(System.Data.DataSet ds, System.Data.DataTable& table, System.Int32& pos, System.Xml.XmlReader row)
  RVA=0x097BE114  token=0x600075F  System.Void SkipWhitespaces(System.Xml.XmlReader reader)
  RVA=0x0350B670  token=0x6000760  System.Void .ctor()
END_CLASS

CLASS: System.Data.XMLSchema
TYPE:  class
TOKEN: 0x200008A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x097BE410  token=0x6000761  System.ComponentModel.TypeConverter GetConverter(System.Type type)
  RVA=0x097BE45C  token=0x6000762  System.Void SetProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs)
  RVA=0x097BE164  token=0x6000763  System.Boolean FEqualIdentity(System.Xml.XmlNode node, System.String name, System.String ns)
  RVA=0x097BE2DC  token=0x6000764  System.Boolean GetBooleanAttribute(System.Xml.XmlElement element, System.String attrName, System.String attrNS, System.Boolean defVal)
  RVA=0x097BE1D4  token=0x6000765  System.String GenUniqueColumnName(System.String proposedName, System.Data.DataTable table)
  RVA=0x0350B670  token=0x6000766  System.Void .ctor()
END_CLASS

CLASS: System.Data.ConstraintTable
TYPE:  sealed class
TOKEN: 0x200008B
SIZE:  0x20
FIELDS:
  public            System.Data.DataTable           table  // 0x10
  public            System.Xml.Schema.XmlSchemaIdentityConstraintconstraint  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000767  System.Void .ctor(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c)
END_CLASS

CLASS: System.Data.XSDSchema
TYPE:  sealed class
TOKEN: 0x200008C
SIZE:  0xA8
EXTENDS: System.Data.XMLSchema
FIELDS:
  private           System.Xml.Schema.XmlSchemaSet  _schemaSet  // 0x10
  private           System.Xml.Schema.XmlSchemaElement_dsElement  // 0x18
  private           System.Data.DataSet             _ds  // 0x20
  private           System.String                   _schemaName  // 0x28
  private           System.Collections.ArrayList    _columnExpressions  // 0x30
  private           System.Collections.Hashtable    _constraintNodes  // 0x38
  private           System.Collections.ArrayList    _refTables  // 0x40
  private           System.Collections.ArrayList    _complexTypes  // 0x48
  private           System.Xml.Schema.XmlSchemaObjectCollection_annotations  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollection_elements  // 0x58
  private           System.Collections.Hashtable    _attributes  // 0x60
  private           System.Collections.Hashtable    _elementsTable  // 0x68
  private           System.Collections.Hashtable    _attributeGroups  // 0x70
  private           System.Collections.Hashtable    _schemaTypes  // 0x78
  private           System.Collections.Hashtable    _expressions  // 0x80
  private           System.Collections.Generic.Dictionary<System.Data.DataTable,System.Collections.Generic.List<System.Data.DataTable>>_tableDictionary  // 0x88
  private           System.Collections.Hashtable    _udSimpleTypes  // 0x90
  private           System.Collections.Hashtable    _existingSimpleTypeMap  // 0x98
  private           System.Boolean                  _fromInference  // 0xa0
  private   static readonly System.Data.XSDSchema.NameType[]s_mapNameTypeXsd  // static @ 0x0
PROPERTIES:
  FromInference  get=0x03D50A40  set=0x03D50A60
METHODS:
  RVA=0x097BF334  token=0x600076A  System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema)
  RVA=0x097BEBC4  token=0x600076B  System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList)
  RVA=0x097CE520  token=0x600076C  System.String QualifiedName(System.String name)
  RVA=0x097CEA08  token=0x600076D  System.Void SetProperties(System.Object instance, System.Xml.XmlAttribute[] attrs)
  RVA=0x097CE74C  token=0x600076E  System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttribute[] attrs)
  RVA=0x097C1A28  token=0x600076F  System.Void HandleColumnExpression(System.Object instance, System.Xml.XmlAttribute[] attrs)
  RVA=0x097BFF88  token=0x6000770  System.String GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, System.String ln)
  RVA=0x097CE588  token=0x6000771  System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs)
  RVA=0x097C657C  token=0x6000772  System.Void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element)
  RVA=0x097C6660  token=0x6000773  System.Void HandleRelation(System.Xml.XmlElement node, System.Boolean fNested)
  RVA=0x097C8254  token=0x6000774  System.Boolean HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes)
  RVA=0x097CAD64  token=0x6000775  System.Boolean IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt)
  RVA=0x097BF3B8  token=0x6000776  System.Int32 DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements)
  RVA=0x097BF548  token=0x6000777  System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements)
  RVA=0x097CE3B8  token=0x6000778  System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt)
  RVA=0x097CB48C  token=0x6000779  System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds)
  RVA=0x097C6E74  token=0x600077A  System.Void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, System.Boolean fNested)
  RVA=0x097C02E8  token=0x600077B  System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt)
  RVA=0x097C5C60  token=0x600077C  System.Void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isBase)
  RVA=0x097C1814  token=0x600077D  System.Void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, System.Boolean isBase)
  RVA=0x097C1530  token=0x600077E  System.Void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, System.Boolean isBase)
  RVA=0x097C1BE8  token=0x600077F  System.Void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isNillable)
  RVA=0x097C04C4  token=0x6000780  System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct)
  RVA=0x097BF8F0  token=0x6000781  System.Data.DataColumn FindField(System.Data.DataTable table, System.String field)
  RVA=0x097BE998  token=0x6000782  System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table)
  RVA=0x097BFD8C  token=0x6000783  System.Boolean GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.Boolean defVal)
  RVA=0x097C082C  token=0x6000784  System.String GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.String defVal)
  RVA=0x097CEE44  token=0x6000785  System.Data.AcceptRejectRule TranslateAcceptRejectRule(System.String strRule)
  RVA=0x097CEEAC  token=0x6000786  System.Data.Rule TranslateRule(System.String strRule)
  RVA=0x097C54A4  token=0x6000787  System.Void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref)
  RVA=0x097C21BC  token=0x6000788  System.Void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode)
  RVA=0x097C83E8  token=0x6000789  System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node)
  RVA=0x097BFEBC  token=0x600078A  System.String GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node)
  RVA=0x097C8B44  token=0x600078B  System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, System.Boolean isRef)
  RVA=0x097CEF6C  token=0x600078C  System.Type XsdtoClr(System.String xsdTypeName)
  RVA=0x097BFA70  token=0x600078D  System.Data.XSDSchema.NameType FindNameType(System.String name)
  RVA=0x097CE3E4  token=0x600078E  System.Type ParseDataType(System.String dt)
  RVA=0x097CB434  token=0x600078F  System.Boolean IsXsdType(System.String name)
  RVA=0x097BFB30  token=0x6000790  System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node)
  RVA=0x097C77CC  token=0x6000791  System.Void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable)
  RVA=0x097C70AC  token=0x6000792  System.Void HandleSimpleContentColumn(System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable)
  RVA=0x097C0B28  token=0x6000793  System.Void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, System.Boolean isBase)
  RVA=0x097C47BC  token=0x6000794  System.Void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, System.Boolean isBase)
  RVA=0x097C2608  token=0x6000795  System.Void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, System.Boolean isNewDataSet)
  RVA=0x097BE7CC  token=0x6000796  System.Void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt)
  RVA=0x097C05D0  token=0x6000797  System.String GetPrefix(System.String ns)
  RVA=0x097C0080  token=0x6000798  System.String GetNamespaceFromPrefix(System.String prefix)
  RVA=0x097C09A8  token=0x6000799  System.String GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key)
  RVA=0x097C089C  token=0x600079A  System.String GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key)
  RVA=0x097CB1D4  token=0x600079B  System.Boolean IsTable(System.Xml.Schema.XmlSchemaElement node)
  RVA=0x097C8100  token=0x600079C  System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node)
  RVA=0x0350B670  token=0x600079D  System.Void .ctor()
  RVA=0x097CF038  token=0x600079E  System.Void .cctor()
END_CLASS

CLASS: System.Data.XmlIgnoreNamespaceReader
TYPE:  sealed class
TOKEN: 0x200008E
SIZE:  0x38
EXTENDS: System.Xml.XmlNodeReader
FIELDS:
  private           System.Collections.Generic.List<System.String>_namespacesToIgnore  // 0x30
METHODS:
  RVA=0x097D4AB4  token=0x60007A1  System.Void .ctor(System.Xml.XmlDocument xdoc, System.String[] namespacesToIgnore)
  RVA=0x097D48DC  token=0x60007A2  System.Boolean MoveToFirstAttribute()
  RVA=0x097D49C4  token=0x60007A3  System.Boolean MoveToNextAttribute()
END_CLASS

CLASS: System.Data.XmlDataLoader
TYPE:  sealed class
TOKEN: 0x200008F
SIZE:  0xC8
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.XmlToDatasetMap     _nodeToSchemaMap  // 0x18
  private           System.Collections.Hashtable    _nodeToRowMap  // 0x20
  private           System.Collections.Stack        _childRowsStack  // 0x28
  private           System.Collections.Hashtable    _htableExcludedNS  // 0x30
  private           System.Boolean                  _fIsXdr  // 0x38
  private           System.Boolean                  _isDiffgram  // 0x39
  private           System.Xml.XmlElement           _topMostNode  // 0x40
  private           System.Boolean                  _ignoreSchema  // 0x48
  private           System.Data.DataTable           _dataTable  // 0x50
  private           System.Boolean                  _isTableLevel  // 0x58
  private           System.Boolean                  _fromInference  // 0x59
  private           System.Xml.XmlReader            _dataReader  // 0x60
  private           System.Object                   _XSD_XMLNS_NS  // 0x68
  private           System.Object                   _XDR_SCHEMA  // 0x70
  private           System.Object                   _XDRNS  // 0x78
  private           System.Object                   _SQL_SYNC  // 0x80
  private           System.Object                   _UPDGNS  // 0x88
  private           System.Object                   _XSD_SCHEMA  // 0x90
  private           System.Object                   _XSDNS  // 0x98
  private           System.Object                   _DFFNS  // 0xa0
  private           System.Object                   _MSDNS  // 0xa8
  private           System.Object                   _DIFFID  // 0xb0
  private           System.Object                   _HASCHANGES  // 0xb8
  private           System.Object                   _ROWORDER  // 0xc0
PROPERTIES:
  FromInference  get=0x03D589D0  set=0x03D5B3E0
METHODS:
  RVA=0x097D45B8  token=0x60007A4  System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Boolean ignoreSchema)
  RVA=0x097D47F4  token=0x60007A5  System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema)
  RVA=0x097D4650  token=0x60007A6  System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Boolean ignoreSchema)
  RVA=0x097D46FC  token=0x60007A7  System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema)
  RVA=0x097D013C  token=0x60007AA  System.Void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement)
  RVA=0x097D0264  token=0x60007AB  System.Int32 CountNonNSAttributes(System.Xml.XmlNode node)
  RVA=0x097D08B4  token=0x60007AC  System.String GetValueForTextOnlyColums(System.Xml.XmlNode n)
  RVA=0x097D05BC  token=0x60007AD  System.String GetInitialTextFromNodes(System.Xml.XmlNode& n)
  RVA=0x097D081C  token=0x60007AE  System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row)
  RVA=0x097D07B8  token=0x60007AF  System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e)
  RVA=0x097D0330  token=0x60007B0  System.Boolean FColumnElement(System.Xml.XmlElement e)
  RVA=0x097D03FC  token=0x60007B1  System.Boolean FExcludedNamespace(System.String ns)
  RVA=0x097D04F0  token=0x60007B2  System.Boolean FIgnoreNamespace(System.Xml.XmlNode node)
  RVA=0x097D0474  token=0x60007B3  System.Boolean FIgnoreNamespace(System.Xml.XmlReader node)
  RVA=0x097D0CF0  token=0x60007B4  System.Boolean IsTextLikeNode(System.Xml.XmlNodeType n)
  RVA=0x097D0D38  token=0x60007B5  System.Boolean IsTextOnly(System.Data.DataColumn c)
  RVA=0x097D1594  token=0x60007B6  System.Void LoadData(System.Xml.XmlDocument xdoc)
  RVA=0x097D1B88  token=0x60007B7  System.Void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement)
  RVA=0x097D2500  token=0x60007B8  System.Void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement)
  RVA=0x097D456C  token=0x60007B9  System.Void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, System.String xmlText)
  RVA=0x097D0A5C  token=0x60007BA  System.Void InitNameTable()
  RVA=0x097D1834  token=0x60007BB  System.Void LoadData(System.Xml.XmlReader reader)
  RVA=0x097D32CC  token=0x60007BC  System.Void LoadTopMostTable(System.Data.DataTable table)
  RVA=0x097D27D0  token=0x60007BD  System.Void LoadTable(System.Data.DataTable table, System.Boolean isNested)
  RVA=0x097D0D58  token=0x60007BE  System.Void LoadColumn(System.Data.DataColumn column, System.Object[] foundColumns)
  RVA=0x097D4378  token=0x60007BF  System.Boolean ProcessXsdSchema()
END_CLASS

CLASS: System.Data.XmlReadMode
TYPE:  sealed struct
TOKEN: 0x2000090
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.XmlReadMode         Auto  // const
  public    static  System.Data.XmlReadMode         ReadSchema  // const
  public    static  System.Data.XmlReadMode         IgnoreSchema  // const
  public    static  System.Data.XmlReadMode         InferSchema  // const
  public    static  System.Data.XmlReadMode         DiffGram  // const
  public    static  System.Data.XmlReadMode         Fragment  // const
  public    static  System.Data.XmlReadMode         InferTypedSchema  // const
METHODS:
END_CLASS

CLASS: System.Data.XmlToDatasetMap
TYPE:  sealed class
TOKEN: 0x2000091
SIZE:  0x20
FIELDS:
  private           System.Data.XmlToDatasetMap.XmlNodeIdHashtable_tableSchemaMap  // 0x10
  private           System.Data.XmlToDatasetMap.TableSchemaInfo_lastTableSchemaInfo  // 0x18
METHODS:
  RVA=0x097DD8F8  token=0x60007C0  System.Void .ctor(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable)
  RVA=0x097DD8E8  token=0x60007C1  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet)
  RVA=0x097DD900  token=0x60007C2  System.Void .ctor(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable)
  RVA=0x097DD8F0  token=0x60007C3  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable)
  RVA=0x097DD8C8  token=0x60007C4  System.Boolean IsMappedColumn(System.Data.DataColumn c)
  RVA=0x097DB8CC  token=0x60007C5  System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable)
  RVA=0x097DB9F8  token=0x60007C6  System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table)
  RVA=0x097DB5C0  token=0x60007C7  System.Boolean AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
  RVA=0x097DB708  token=0x60007C8  System.Boolean AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
  RVA=0x097DBB84  token=0x60007C9  System.Void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable)
  RVA=0x097DC108  token=0x60007CA  System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet)
  RVA=0x097DBEF8  token=0x60007CB  System.Void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable)
  RVA=0x097DC8B8  token=0x60007CC  System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable)
  RVA=0x097DD3E8  token=0x60007CD  System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt)
  RVA=0x097DD008  token=0x60007CE  System.Object GetColumnSchema(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace)
  RVA=0x097DD1AC  token=0x60007CF  System.Object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, System.Boolean fIgnoreNamespace)
  RVA=0x097DD30C  token=0x60007D0  System.Object GetSchemaForNode(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace)
  RVA=0x097DD694  token=0x60007D1  System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, System.Boolean fIgnoreNamespace)
  RVA=0x097DD768  token=0x60007D2  System.Void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
END_CLASS

CLASS: System.Data.XmlWriteMode
TYPE:  sealed struct
TOKEN: 0x2000095
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.XmlWriteMode        WriteSchema  // const
  public    static  System.Data.XmlWriteMode        IgnoreSchema  // const
  public    static  System.Data.XmlWriteMode        DiffGram  // const
METHODS:
END_CLASS

CLASS: System.Data.SchemaFormat
TYPE:  sealed struct
TOKEN: 0x2000096
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SchemaFormat        Public  // const
  public    static  System.Data.SchemaFormat        Remoting  // const
  public    static  System.Data.SchemaFormat        WebService  // const
  public    static  System.Data.SchemaFormat        RemotingSkipSchema  // const
  public    static  System.Data.SchemaFormat        WebServiceSkipSchema  // const
METHODS:
END_CLASS

CLASS: System.Data.XmlTreeGen
TYPE:  sealed class
TOKEN: 0x2000097
SIZE:  0x90
FIELDS:
  private           System.Collections.ArrayList    _constraintNames  // 0x10
  private           System.Collections.Hashtable    _namespaces  // 0x18
  private           System.Collections.Hashtable    _autogenerated  // 0x20
  private           System.Collections.Hashtable    _prefixes  // 0x28
  private           System.Data.DataSet             _ds  // 0x30
  private           System.Collections.ArrayList    _tables  // 0x38
  private           System.Collections.ArrayList    _relations  // 0x40
  private           System.Xml.XmlDocument          _dc  // 0x48
  private           System.Xml.XmlElement           _sRoot  // 0x50
  private           System.Int32                    _prefixCount  // 0x58
  private           System.Data.SchemaFormat        _schFormat  // 0x5c
  private           System.String                   _filePath  // 0x60
  private           System.String                   _fileName  // 0x68
  private           System.String                   _fileExt  // 0x70
  private           System.Xml.XmlElement           _dsElement  // 0x78
  private           System.Xml.XmlElement           _constraintSeparator  // 0x80
  private           System.Converter<System.Type,System.String>_targetConverter  // 0x88
METHODS:
  RVA=0x097EA504  token=0x60007DC  System.Void .ctor(System.Data.SchemaFormat format)
  RVA=0x097DDE60  token=0x60007DD  System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node)
  RVA=0x097DDE6C  token=0x60007DE  System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type)
  RVA=0x097DE42C  token=0x60007DF  System.Void AddXdoProperties(System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd)
  RVA=0x097DE568  token=0x60007E0  System.Void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd)
  RVA=0x097E9B84  token=0x60007E1  System.String XmlDataTypeName(System.Type type)
  RVA=0x097E0910  token=0x60007E2  System.Void GenerateConstraintNames(System.Data.DataTable table, System.Boolean fromTable)
  RVA=0x097E0600  token=0x60007E3  System.Void GenerateConstraintNames(System.Collections.ArrayList tables)
  RVA=0x097E0694  token=0x60007E4  System.Void GenerateConstraintNames(System.Data.DataSet ds)
  RVA=0x097EA4E0  token=0x60007E5  System.Boolean _PropsNotEmpty(System.Data.PropertyCollection props)
  RVA=0x097E470C  token=0x60007E6  System.Boolean HaveExtendedProperties(System.Data.DataSet ds)
  RVA=0x097E99AC  token=0x60007E7  System.Void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, System.String targetNamespace)
  RVA=0x097E9940  token=0x60007E8  System.Void ValidateColumnMapping(System.Type columnType)
  RVA=0x097E8BC8  token=0x60007E9  System.Void SetupAutoGenerated(System.Data.DataSet ds)
  RVA=0x097E97CC  token=0x60007EA  System.Void SetupAutoGenerated(System.Collections.ArrayList dt)
  RVA=0x097E8E40  token=0x60007EB  System.Void SetupAutoGenerated(System.Data.DataTable dt)
  RVA=0x097DF7C0  token=0x60007EC  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  RVA=0x097DF4B0  token=0x60007ED  System.Void CreateRelations(System.Data.DataTable dt)
  RVA=0x097DFAEC  token=0x60007EE  System.Data.DataTable[] CreateToplevelTables()
  RVA=0x097E4F7C  token=0x60007EF  System.Void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, System.Boolean writeHierarchy)
  RVA=0x097E4AF4  token=0x60007F0  System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt)
  RVA=0x097DFD14  token=0x60007F1  System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt)
  RVA=0x097E8A60  token=0x60007F2  System.Void SetPath(System.Xml.XmlWriter xw)
  RVA=0x097E4A20  token=0x60007F3  System.Void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw)
  RVA=0x097E4A40  token=0x60007F4  System.Void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw)
  RVA=0x097E48B0  token=0x60007F5  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw)
  RVA=0x097E488C  token=0x60007F6  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy)
  RVA=0x097E48CC  token=0x60007F7  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter)
  RVA=0x097E1C3C  token=0x60007F8  System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc)
  RVA=0x097E0298  token=0x60007F9  System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, System.String name)
  RVA=0x097E0DD0  token=0x60007FA  System.Xml.XmlElement GetSchema(System.String NamespaceURI)
  RVA=0x097E0FE8  token=0x60007FB  System.Void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema)
  RVA=0x097DD908  token=0x60007FC  System.Void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root)
  RVA=0x097E036C  token=0x60007FD  System.String FindTargetNamespace(System.Data.DataTable table)
  RVA=0x097E13C0  token=0x60007FE  System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean fWriteOrdinal)
  RVA=0x097E985C  token=0x60007FF  System.String TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule)
  RVA=0x097E98B8  token=0x6000800  System.String TranslateRule(System.Data.Rule rule)
  RVA=0x097DECB0  token=0x6000801  System.Void AppendChildWithoutRef(System.Xml.XmlElement node, System.String Namespace, System.Xml.XmlElement el, System.String refString)
  RVA=0x097E0470  token=0x6000802  System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, System.String strType)
  RVA=0x097E4408  token=0x6000803  System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema)
  RVA=0x097E4424  token=0x6000804  System.Boolean HasMixedColumns(System.Data.DataTable table)
  RVA=0x097DEFEC  token=0x6000805  System.Boolean AutoGenerated(System.Data.DataColumn col)
  RVA=0x097DEF18  token=0x6000806  System.Boolean AutoGenerated(System.Data.DataRelation rel)
  RVA=0x097DED4C  token=0x6000807  System.Boolean AutoGenerated(System.Data.UniqueConstraint unique)
  RVA=0x097DEDF8  token=0x6000808  System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk)
  RVA=0x097DEE08  token=0x6000809  System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk, System.Boolean checkRelation)
  RVA=0x097E4854  token=0x600080A  System.Boolean IsAutoGenerated(System.Object o)
  RVA=0x097E219C  token=0x600080B  System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean genNested)
  RVA=0x097E88BC  token=0x600080C  System.Void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type)
END_CLASS

CLASS: System.Data.NewDiffgramGen
TYPE:  sealed class
TOKEN: 0x2000098
SIZE:  0x50
FIELDS:
  private           System.Xml.XmlDocument          _doc  // 0x10
  private           System.Data.DataSet             _ds  // 0x18
  private           System.Data.DataTable           _dt  // 0x20
  private           System.Xml.XmlWriter            _xmlw  // 0x28
  private           System.Boolean                  _fBefore  // 0x30
  private           System.Boolean                  _fErrors  // 0x31
  private           System.Collections.Hashtable    _rowsOrder  // 0x38
  private           System.Collections.ArrayList    _tables  // 0x40
  private           System.Boolean                  _writeHierarchy  // 0x48
METHODS:
  RVA=0x097D73BC  token=0x600080D  System.Void .ctor(System.Data.DataSet ds)
  RVA=0x097D72AC  token=0x600080E  System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy)
  RVA=0x097D5570  token=0x600080F  System.Void CreateTableHierarchy(System.Data.DataTable dt)
  RVA=0x097D589C  token=0x6000810  System.Void DoAssignments(System.Collections.ArrayList tables)
  RVA=0x097D5A84  token=0x6000811  System.Boolean EmptyData()
  RVA=0x097D72A0  token=0x6000812  System.Void Save(System.Xml.XmlWriter xmlw)
  RVA=0x097D6F20  token=0x6000813  System.Void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table)
  RVA=0x097D6E4C  token=0x6000814  System.Void GenerateTable(System.Data.DataTable table)
  RVA=0x097D68FC  token=0x6000815  System.Void GenerateTableErrors(System.Data.DataTable table)
  RVA=0x097D6350  token=0x6000816  System.Void GenerateRow(System.Data.DataRow row)
  RVA=0x097D5B40  token=0x6000817  System.Void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version)
  RVA=0x097D6EC8  token=0x6000818  System.String QualifiedName(System.String prefix, System.String name)
END_CLASS

CLASS: System.Data.XmlDataTreeWriter
TYPE:  sealed class
TOKEN: 0x2000099
SIZE:  0x50
FIELDS:
  private           System.Xml.XmlWriter            _xmlw  // 0x10
  private           System.Data.DataSet             _ds  // 0x18
  private           System.Data.DataTable           _dt  // 0x20
  private           System.Collections.ArrayList    _dTables  // 0x28
  private           System.Data.DataTable[]         _topLevelTables  // 0x30
  private           System.Boolean                  _fFromTable  // 0x38
  private           System.Boolean                  _isDiffgram  // 0x39
  private           System.Collections.Hashtable    _rowsOrder  // 0x40
  private           System.Boolean                  _writeHierarchy  // 0x48
METHODS:
  RVA=0x097DAF44  token=0x6000819  System.Void .ctor(System.Data.DataSet ds)
  RVA=0x097DADD4  token=0x600081A  System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy)
  RVA=0x097D78B8  token=0x600081B  System.Data.DataTable[] CreateToplevelTables()
  RVA=0x097D758C  token=0x600081C  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  RVA=0x097D7E88  token=0x600081D  System.Boolean RowHasErrors(System.Data.DataRow row)
  RVA=0x097D7F4C  token=0x600081E  System.Void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder)
  RVA=0x097D85BC  token=0x600081F  System.Void Save(System.Xml.XmlWriter xw, System.Boolean writeSchema)
  RVA=0x097D7AE0  token=0x6000820  System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row)
  RVA=0x097D8EEC  token=0x6000821  System.Void XmlDataRowWriter(System.Data.DataRow row, System.String encodedTableName)
  RVA=0x097D7E00  token=0x6000822  System.Boolean PreserveSpace(System.Object value)
END_CLASS

CLASS: System.Data.DataTextWriter
TYPE:  sealed class
TOKEN: 0x200009A
SIZE:  0x20
EXTENDS: System.Xml.XmlWriter
FIELDS:
  private           System.Xml.XmlWriter            _xmltextWriter  // 0x18
PROPERTIES:
  BaseStream  get=0x097D54FC
  WriteState  get=0x097D554C
METHODS:
  RVA=0x097D50EC  token=0x6000823  System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw)
  RVA=0x022C3A90  token=0x6000824  System.Void .ctor(System.Xml.XmlWriter w)
  RVA=0x097D5410  token=0x6000826  System.Void WriteStartDocument()
  RVA=0x097D5434  token=0x6000827  System.Void WriteStartDocument(System.Boolean standalone)
  RVA=0x0922E594  token=0x6000828  System.Void WriteEndDocument()
  RVA=0x097D5294  token=0x6000829  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  RVA=0x097D545C  token=0x600082A  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  RVA=0x097D52F4  token=0x600082B  System.Void WriteEndElement()
  RVA=0x097D533C  token=0x600082C  System.Void WriteFullEndElement()
  RVA=0x097D53E0  token=0x600082D  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  RVA=0x097D52D0  token=0x600082E  System.Void WriteEndAttribute()
  RVA=0x097D51F4  token=0x600082F  System.Void WriteCData(System.String text)
  RVA=0x097D5270  token=0x6000830  System.Void WriteComment(System.String text)
  RVA=0x097D5360  token=0x6000831  System.Void WriteProcessingInstruction(System.String name, System.String text)
  RVA=0x097D5318  token=0x6000832  System.Void WriteEntityRef(System.String name)
  RVA=0x097D5218  token=0x6000833  System.Void WriteCharEntity(System.Char ch)
  RVA=0x097D54D8  token=0x6000834  System.Void WriteWhitespace(System.String ws)
  RVA=0x097D548C  token=0x6000835  System.Void WriteString(System.String text)
  RVA=0x097D54B0  token=0x6000836  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  RVA=0x097D5240  token=0x6000837  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x097D538C  token=0x6000838  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x097D53BC  token=0x6000839  System.Void WriteRaw(System.String data)
  RVA=0x097D5194  token=0x600083A  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x097D51C4  token=0x600083B  System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  RVA=0x097D50C8  token=0x600083D  System.Void Close()
  RVA=0x097D514C  token=0x600083E  System.Void Flush()
  RVA=0x097D5170  token=0x600083F  System.String LookupPrefix(System.String ns)
END_CLASS

CLASS: System.Data.DataTextReader
TYPE:  sealed class
TOKEN: 0x200009B
SIZE:  0x18
EXTENDS: System.Xml.XmlReader
FIELDS:
  private           System.Xml.XmlReader            _xmlreader  // 0x10
PROPERTIES:
  Settings  get=0x097D5040
  NodeType  get=0x097D4FB0
  Name  get=0x097D4F8C
  LocalName  get=0x093B57E4
  NamespaceURI  get=0x092EFBE8
  Prefix  get=0x097D4FD4
  HasValue  get=0x097D4EFC
  Value  get=0x097D505C
  Depth  get=0x097D4EB4
  BaseURI  get=0x097D4E48
  IsEmptyElement  get=0x097D4F44
  IsDefault  get=0x097D4F20
  QuoteChar  get=0x097D4FF8
  XmlSpace  get=0x097D50A4
  XmlLang  get=0x097D5080
  AttributeCount  get=0x097D4E24
  EOF  get=0x097D4ED8
  ReadState  get=0x097D501C
  NameTable  get=0x097D4F68
  CanResolveEntity  get=0x097D4E90
  CanReadValueChunk  get=0x097D4E6C
METHODS:
  RVA=0x097D4B70  token=0x6000840  System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr)
  RVA=0x097D4DCC  token=0x6000841  System.Void .ctor(System.Xml.XmlReader input)
  RVA=0x097D4BF8  token=0x6000852  System.String GetAttribute(System.String name)
  RVA=0x097D4BD0  token=0x6000853  System.String GetAttribute(System.String localName, System.String namespaceURI)
  RVA=0x097D4C1C  token=0x6000854  System.String GetAttribute(System.Int32 i)
  RVA=0x097D4C64  token=0x6000855  System.Boolean MoveToAttribute(System.String name)
  RVA=0x097D4C88  token=0x6000856  System.Void MoveToAttribute(System.Int32 i)
  RVA=0x097D4CD0  token=0x6000857  System.Boolean MoveToFirstAttribute()
  RVA=0x097D4CF4  token=0x6000858  System.Boolean MoveToNextAttribute()
  RVA=0x097D4CAC  token=0x6000859  System.Boolean MoveToElement()
  RVA=0x097D4D18  token=0x600085A  System.Boolean ReadAttributeValue()
  RVA=0x097D4D60  token=0x600085B  System.Boolean Read()
  RVA=0x097D4B4C  token=0x600085D  System.Void Close()
  RVA=0x097D4DA8  token=0x600085F  System.Void Skip()
  RVA=0x097D4C40  token=0x6000861  System.String LookupNamespace(System.String prefix)
  RVA=0x097D4D84  token=0x6000863  System.Void ResolveEntity()
  RVA=0x097D4D3C  token=0x6000865  System.String ReadString()
END_CLASS

CLASS: System.Data.Common.ADP
TYPE:  static class
TOKEN: 0x20000B6
SIZE:  0x10
FIELDS:
  private   static readonly System.Type                     s_stackOverflowType  // static @ 0x0
  private   static readonly System.Type                     s_outOfMemoryType  // static @ 0x8
  private   static readonly System.Type                     s_threadAbortType  // static @ 0x10
  private   static readonly System.Type                     s_nullReferenceType  // static @ 0x18
  private   static readonly System.Type                     s_accessViolationType  // static @ 0x20
  private   static readonly System.Type                     s_securityType  // static @ 0x28
  private   static readonly System.String                   StrEmpty  // static @ 0x30
  private   static readonly System.String[]                 AzureSqlServerEndpoints  // static @ 0x38
  private   static readonly System.IntPtr                   PtrZero  // static @ 0x40
  private   static readonly System.Int32                    PtrSize  // static @ 0x48
METHODS:
  RVA=0x09802654  token=0x6000A6E  System.Void TraceException(System.String trace, System.Exception e)
  RVA=0x098025AC  token=0x6000A6F  System.Void TraceExceptionAsReturnValue(System.Exception e)
  RVA=0x09802600  token=0x6000A70  System.Void TraceExceptionWithoutRethrow(System.Exception e)
  RVA=0x09801E8C  token=0x6000A71  System.ArgumentException Argument(System.String error)
  RVA=0x09801D74  token=0x6000A72  System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String parameterName)
  RVA=0x09801DF8  token=0x6000A73  System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String message, System.String parameterName)
  RVA=0x098020F4  token=0x6000A74  System.InvalidOperationException InvalidOperation(System.String error)
  RVA=0x09802528  token=0x6000A75  System.NotSupportedException NotSupported(System.String error)
  RVA=0x09802250  token=0x6000A76  System.Boolean IsCatchableExceptionType(System.Exception e)
  RVA=0x098023D8  token=0x6000A77  System.Boolean IsCatchableOrSecurityExceptionType(System.Exception e)
  RVA=0x09801F94  token=0x6000A78  System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, System.Int32 value)
  RVA=0x098021FC  token=0x6000A79  System.Exception InvalidSeekOrigin(System.String parameterName)
  RVA=0x09801F10  token=0x6000A7A  System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value)
  RVA=0x09802070  token=0x6000A7B  System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value)
  RVA=0x09802178  token=0x6000A7C  System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value)
  RVA=0x098026D8  token=0x6000A7D  System.Exception WrongType(System.Type got, System.Type expected)
  RVA=0x09802778  token=0x6000A7E  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.BigIntegerStorage
TYPE:  sealed class
TOKEN: 0x20000B7
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Numerics.BigInteger[]    _values  // 0x50
METHODS:
  RVA=0x09803E50  token=0x6000A7F  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09802A84  token=0x6000A80  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09802BB8  token=0x6000A81  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09802AB8  token=0x6000A82  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09803378  token=0x6000A83  System.Numerics.BigInteger ConvertToBigInteger(System.Object value, System.IFormatProvider formatProvider)
  RVA=0x09802CB0  token=0x6000A84  System.Object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider)
  RVA=0x098038F0  token=0x6000A85  System.Object ConvertValue(System.Object value)
  RVA=0x09803AE0  token=0x6000A86  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09803B94  token=0x6000A87  System.Object Get(System.Int32 record)
  RVA=0x09803D6C  token=0x6000A88  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09803C28  token=0x6000A89  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09803978  token=0x6000A8A  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098032E4  token=0x6000A8B  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09803B5C  token=0x6000A8C  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09803A08  token=0x6000A8D  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09803CF0  token=0x6000A8E  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.BooleanStorage
TYPE:  sealed class
TOKEN: 0x20000B8
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Boolean[]                _values  // 0x50
METHODS:
  RVA=0x0980494C  token=0x6000A8F  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09803F40  token=0x6000A90  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x098042FC  token=0x6000A91  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09804220  token=0x6000A92  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09804420  token=0x6000A93  System.Object ConvertValue(System.Object value)
  RVA=0x09804614  token=0x6000A94  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098046AC  token=0x6000A95  System.Object Get(System.Int32 record)
  RVA=0x09804870  token=0x6000A96  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980472C  token=0x6000A97  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x098044D0  token=0x6000A98  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098043C4  token=0x6000A99  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09804674  token=0x6000A9A  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09804534  token=0x6000A9B  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x098047F4  token=0x6000A9C  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.ByteStorage
TYPE:  sealed class
TOKEN: 0x20000B9
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Byte[]                   _values  // 0x50
METHODS:
  RVA=0x098057D0  token=0x6000A9D  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09804A20  token=0x6000A9E  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x098051EC  token=0x6000A9F  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09805120  token=0x6000AA0  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x098052AC  token=0x6000AA1  System.Object ConvertValue(System.Object value)
  RVA=0x09805498  token=0x6000AA2  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09805530  token=0x6000AA3  System.Object Get(System.Int32 record)
  RVA=0x098056F4  token=0x6000AA4  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x098055B0  token=0x6000AA5  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980535C  token=0x6000AA6  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09805250  token=0x6000AA7  System.String ConvertObjectToXml(System.Object value)
  RVA=0x098054F8  token=0x6000AA8  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x098053C0  token=0x6000AA9  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09805678  token=0x6000AAA  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.CharStorage
TYPE:  sealed class
TOKEN: 0x20000BA
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Char[]                   _values  // 0x50
METHODS:
  RVA=0x0980634C  token=0x6000AAB  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x098058A4  token=0x6000AAC  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09805CA0  token=0x6000AAD  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09805BC4  token=0x6000AAE  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09805DB4  token=0x6000AAF  System.Object ConvertValue(System.Object value)
  RVA=0x09805FA4  token=0x6000AB0  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980603C  token=0x6000AB1  System.Object Get(System.Int32 record)
  RVA=0x09806210  token=0x6000AB2  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x098060CC  token=0x6000AB3  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09805E68  token=0x6000AB4  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09805D58  token=0x6000AB5  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09806004  token=0x6000AB6  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09805ECC  token=0x6000AB7  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09806194  token=0x6000AB8  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.StorageType
TYPE:  sealed struct
TOKEN: 0x20000BB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Common.StorageType  Empty  // const
  public    static  System.Data.Common.StorageType  Object  // const
  public    static  System.Data.Common.StorageType  DBNull  // const
  public    static  System.Data.Common.StorageType  Boolean  // const
  public    static  System.Data.Common.StorageType  Char  // const
  public    static  System.Data.Common.StorageType  SByte  // const
  public    static  System.Data.Common.StorageType  Byte  // const
  public    static  System.Data.Common.StorageType  Int16  // const
  public    static  System.Data.Common.StorageType  UInt16  // const
  public    static  System.Data.Common.StorageType  Int32  // const
  public    static  System.Data.Common.StorageType  UInt32  // const
  public    static  System.Data.Common.StorageType  Int64  // const
  public    static  System.Data.Common.StorageType  UInt64  // const
  public    static  System.Data.Common.StorageType  Single  // const
  public    static  System.Data.Common.StorageType  Double  // const
  public    static  System.Data.Common.StorageType  Decimal  // const
  public    static  System.Data.Common.StorageType  DateTime  // const
  public    static  System.Data.Common.StorageType  TimeSpan  // const
  public    static  System.Data.Common.StorageType  String  // const
  public    static  System.Data.Common.StorageType  Guid  // const
  public    static  System.Data.Common.StorageType  ByteArray  // const
  public    static  System.Data.Common.StorageType  CharArray  // const
  public    static  System.Data.Common.StorageType  Type  // const
  public    static  System.Data.Common.StorageType  DateTimeOffset  // const
  public    static  System.Data.Common.StorageType  BigInteger  // const
  public    static  System.Data.Common.StorageType  Uri  // const
  public    static  System.Data.Common.StorageType  SqlBinary  // const
  public    static  System.Data.Common.StorageType  SqlBoolean  // const
  public    static  System.Data.Common.StorageType  SqlByte  // const
  public    static  System.Data.Common.StorageType  SqlBytes  // const
  public    static  System.Data.Common.StorageType  SqlChars  // const
  public    static  System.Data.Common.StorageType  SqlDateTime  // const
  public    static  System.Data.Common.StorageType  SqlDecimal  // const
  public    static  System.Data.Common.StorageType  SqlDouble  // const
  public    static  System.Data.Common.StorageType  SqlGuid  // const
  public    static  System.Data.Common.StorageType  SqlInt16  // const
  public    static  System.Data.Common.StorageType  SqlInt32  // const
  public    static  System.Data.Common.StorageType  SqlInt64  // const
  public    static  System.Data.Common.StorageType  SqlMoney  // const
  public    static  System.Data.Common.StorageType  SqlSingle  // const
  public    static  System.Data.Common.StorageType  SqlString  // const
METHODS:
END_CLASS

CLASS: System.Data.Common.DataStorage
TYPE:  abstract class
TOKEN: 0x20000BC
SIZE:  0x50
FIELDS:
  private   static readonly System.Type[]                   s_storageClassType  // static @ 0x0
  private   readonly System.Data.DataColumn          _column  // 0x10
  private   readonly System.Data.DataTable           _table  // 0x18
  private   readonly System.Type                     _dataType  // 0x20
  private   readonly System.Data.Common.StorageType  _storageTypeCode  // 0x28
  private           System.Collections.BitArray     _dbNullBits  // 0x30
  private   readonly System.Object                   _defaultValue  // 0x38
  private   readonly System.Object                   _nullValue  // 0x40
  private   readonly System.Boolean                  _isCloneable  // 0x48
  private   readonly System.Boolean                  _isCustomDefinedType  // 0x49
  private   readonly System.Boolean                  _isStringType  // 0x4a
  private   readonly System.Boolean                  _isValueType  // 0x4b
  private   static readonly System.Func<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>>s_inspectTypeForInterfaces  // static @ 0x8
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>>s_typeImplementsInterface  // static @ 0x10
PROPERTIES:
  DateTimeMode  get=0x060927C0
  FormatProvider  get=0x09808664
METHODS:
  RVA=0x098085CC  token=0x6000AB9  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Data.Common.StorageType storageType)
  RVA=0x09808488  token=0x6000ABA  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Data.Common.StorageType storageType)
  RVA=0x098084B8  token=0x6000ABB  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Boolean isICloneable, System.Data.Common.StorageType storageType)
  RVA=0x098064C4  token=0x6000ABE  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  RVA=0x09806420  token=0x6000ABF  System.Object AggregateCount(System.Int32[] recordNos)
  RVA=0x098064D8  token=0x6000AC0  System.Int32 CompareBits(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=-1  // abstract  token=0x6000AC1  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=-1  // abstract  token=0x6000AC2  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  RVA=0x03D51810  token=0x6000AC3  System.Object ConvertValue(System.Object value)
  RVA=0x098065AC  token=0x6000AC4  System.Void CopyBits(System.Int32 srcRecordNo, System.Int32 dstRecordNo)
  RVA=-1  // abstract  token=0x6000AC5  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=-1  // abstract  token=0x6000AC6  System.Object Get(System.Int32 recordNo)
  RVA=0x09807104  token=0x6000AC7  System.Object GetBits(System.Int32 recordNo)
  RVA=0x03D56910  token=0x6000AC8  System.Int32 GetStringLength(System.Int32 record)
  RVA=0x098073D4  token=0x6000AC9  System.Boolean HasValue(System.Int32 recordNo)
  RVA=0x09807748  token=0x6000ACA  System.Boolean IsNull(System.Int32 recordNo)
  RVA=-1  // abstract  token=0x6000ACB  System.Void Set(System.Int32 recordNo, System.Object value)
  RVA=0x098079E8  token=0x6000ACC  System.Void SetNullBit(System.Int32 recordNo, System.Boolean flag)
  RVA=0x09807958  token=0x6000ACD  System.Void SetCapacity(System.Int32 capacity)
  RVA=-1  // abstract  token=0x6000ACE  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09806578  token=0x6000ACF  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=-1  // abstract  token=0x6000AD0  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980653C  token=0x6000AD1  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x09806650  token=0x6000AD2  System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode)
  RVA=0x098071A4  token=0x6000AD3  System.Data.Common.StorageType GetStorageType(System.Type dataType)
  RVA=0x0980728C  token=0x6000AD4  System.Type GetTypeStorage(System.Data.Common.StorageType storageType)
  RVA=0x0980790C  token=0x6000AD5  System.Boolean IsTypeCustomType(System.Type type)
  RVA=0x098078FC  token=0x6000AD6  System.Boolean IsTypeCustomType(System.Data.Common.StorageType typeCode)
  RVA=0x098078F4  token=0x6000AD7  System.Boolean IsSqlType(System.Data.Common.StorageType storageType)
  RVA=0x0980782C  token=0x6000AD8  System.Boolean IsSqlType(System.Type dataType)
  RVA=0x0980700C  token=0x6000AD9  System.Boolean DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType)
  RVA=0x09807494  token=0x6000ADA  System.Void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, System.Boolean& sqlType, System.Boolean& nullable, System.Boolean& xmlSerializable, System.Boolean& changeTracking, System.Boolean& revertibleChangeTracking)
  RVA=0x098075E0  token=0x6000ADB  System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(System.Type dataType)
  RVA=0x098073F8  token=0x6000ADC  System.Boolean ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType)
  RVA=0x09807768  token=0x6000ADD  System.Boolean IsObjectNull(System.Object value)
  RVA=0x098077E0  token=0x6000ADE  System.Boolean IsObjectSqlNull(System.Object value)
  RVA=0x09807138  token=0x6000ADF  System.Object GetEmptyStorageInternal(System.Int32 recordCount)
  RVA=0x098065F0  token=0x6000AE0  System.Void CopyValueInternal(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09807A08  token=0x6000AE1  System.Void SetStorageInternal(System.Object store, System.Collections.BitArray nullbits)
  RVA=-1  // abstract  token=0x6000AE2  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=-1  // abstract  token=0x6000AE3  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=-1  // abstract  token=0x6000AE4  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x04270470  token=0x6000AE5  System.Void SetNullStorage(System.Collections.BitArray nullbits)
  RVA=0x098072F0  token=0x6000AE6  System.Type GetType(System.String value)
  RVA=0x0980714C  token=0x6000AE7  System.String GetQualifiedName(System.Type type)
  RVA=0x09807A54  token=0x6000AE8  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DateTimeOffsetStorage
TYPE:  sealed class
TOKEN: 0x20000BD
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.DateTimeOffset           s_defaultValue  // static @ 0x0
  private           System.DateTimeOffset[]         _values  // 0x50
METHODS:
  RVA=0x098093DC  token=0x6000AE9  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09808684  token=0x6000AEA  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09808C04  token=0x6000AEB  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09808AB8  token=0x6000AEC  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09808DF8  token=0x6000AED  System.Object ConvertValue(System.Object value)
  RVA=0x09808FB8  token=0x6000AEE  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980906C  token=0x6000AEF  System.Object Get(System.Int32 record)
  RVA=0x09809298  token=0x6000AF0  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09809154  token=0x6000AF1  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09808E70  token=0x6000AF2  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09808D90  token=0x6000AF3  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09809034  token=0x6000AF4  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09808EE0  token=0x6000AF5  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980921C  token=0x6000AF6  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x0980937C  token=0x6000AF7  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DateTimeStorage
TYPE:  sealed class
TOKEN: 0x20000BE
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.DateTime                 s_defaultValue  // static @ 0x0
  private           System.DateTime[]               _values  // 0x50
METHODS:
  RVA=0x0980A4C8  token=0x6000AF8  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x098094DC  token=0x6000AF9  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x098099E4  token=0x6000AFA  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098098D0  token=0x6000AFB  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09809BBC  token=0x6000AFC  System.Object ConvertValue(System.Object value)
  RVA=0x09809E20  token=0x6000AFD  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09809ECC  token=0x6000AFE  System.Object Get(System.Int32 record)
  RVA=0x0980A20C  token=0x6000AFF  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09809FA4  token=0x6000B00  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09809C70  token=0x6000B01  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09809B24  token=0x6000B02  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09809E94  token=0x6000B03  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09809D00  token=0x6000B04  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980A06C  token=0x6000B05  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x0980A468  token=0x6000B06  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DecimalStorage
TYPE:  sealed class
TOKEN: 0x20000BF
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.Decimal                  s_defaultValue  // static @ 0x0
  private           System.Decimal[]                _values  // 0x50
METHODS:
  RVA=0x0980B74C  token=0x6000B07  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0980A5C4  token=0x6000B08  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980AFD8  token=0x6000B09  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980AE98  token=0x6000B0A  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0980B1B4  token=0x6000B0B  System.Object ConvertValue(System.Object value)
  RVA=0x0980B3B8  token=0x6000B0C  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980B46C  token=0x6000B0D  System.Object Get(System.Int32 record)
  RVA=0x0980B638  token=0x6000B0E  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980B4F4  token=0x6000B0F  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980B270  token=0x6000B10  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0980B14C  token=0x6000B11  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980B434  token=0x6000B12  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0980B2E0  token=0x6000B13  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980B5BC  token=0x6000B14  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.DoubleStorage
TYPE:  sealed class
TOKEN: 0x20000C0
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Double[]                 _values  // 0x50
METHODS:
  RVA=0x0980C564  token=0x6000B15  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0980B840  token=0x6000B16  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980BF48  token=0x6000B17  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980BE70  token=0x6000B18  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0980C02C  token=0x6000B19  System.Object ConvertValue(System.Object value)
  RVA=0x0980C21C  token=0x6000B1A  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980C2B4  token=0x6000B1B  System.Object Get(System.Int32 record)
  RVA=0x0980C484  token=0x6000B1C  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980C340  token=0x6000B1D  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980C0E0  token=0x6000B1E  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0980BFD0  token=0x6000B1F  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980C27C  token=0x6000B20  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0980C144  token=0x6000B21  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980C408  token=0x6000B22  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int16Storage
TYPE:  sealed class
TOKEN: 0x20000C1
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Int16[]                  _values  // 0x50
METHODS:
  RVA=0x0980D400  token=0x6000B23  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0980C63C  token=0x6000B24  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980CE5C  token=0x6000B25  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980CD94  token=0x6000B26  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0980CF24  token=0x6000B27  System.Object ConvertValue(System.Object value)
  RVA=0x09805FA4  token=0x6000B28  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980D14C  token=0x6000B29  System.Object Get(System.Int32 record)
  RVA=0x0980D320  token=0x6000B2A  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980D1DC  token=0x6000B2B  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980CFD8  token=0x6000B2C  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0980CEC8  token=0x6000B2D  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980D114  token=0x6000B2E  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0980D03C  token=0x6000B2F  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980D2A4  token=0x6000B30  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int32Storage
TYPE:  sealed class
TOKEN: 0x20000C2
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Int32[]                  _values  // 0x50
METHODS:
  RVA=0x0980E2C0  token=0x6000B31  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0980D4D4  token=0x6000B32  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980DCC8  token=0x6000B33  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980DC00  token=0x6000B34  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0980DD9C  token=0x6000B35  System.Object ConvertValue(System.Object value)
  RVA=0x0980DF88  token=0x6000B36  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980E020  token=0x6000B37  System.Object Get(System.Int32 record)
  RVA=0x0980E1E4  token=0x6000B38  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980E0A0  token=0x6000B39  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980DE4C  token=0x6000B3A  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0980DD40  token=0x6000B3B  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980DFE8  token=0x6000B3C  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0980DEB0  token=0x6000B3D  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980E168  token=0x6000B3E  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int64Storage
TYPE:  sealed class
TOKEN: 0x20000C3
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Int64[]                  _values  // 0x50
METHODS:
  RVA=0x0980F184  token=0x6000B3F  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0980E394  token=0x6000B40  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980EB7C  token=0x6000B41  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980EAB0  token=0x6000B42  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0980EC54  token=0x6000B43  System.Object ConvertValue(System.Object value)
  RVA=0x0980EE44  token=0x6000B44  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980EEDC  token=0x6000B45  System.Object Get(System.Int32 record)
  RVA=0x0980F0A4  token=0x6000B46  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0980EF60  token=0x6000B47  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980ED08  token=0x6000B48  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0980EBF8  token=0x6000B49  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980EEA4  token=0x6000B4A  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0980ED6C  token=0x6000B4B  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0980F028  token=0x6000B4C  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.ObjectStorage
TYPE:  sealed class
TOKEN: 0x20000C4
SIZE:  0x60
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.Object                   s_defaultValue  // static @ 0x0
  private           System.Object[]                 _values  // 0x50
  private   readonly System.Boolean                  _implementsIXmlSerializable  // 0x58
  private   static readonly System.Object                   s_tempAssemblyCacheLock  // static @ 0x8
  private   static  System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>,System.Xml.Serialization.XmlSerializer>s_tempAssemblyCache  // static @ 0x10
  private   static readonly System.Xml.Serialization.XmlSerializerFactorys_serializerFactory  // static @ 0x18
METHODS:
  RVA=0x09811E1C  token=0x6000B4D  System.Void .ctor(System.Data.DataColumn column, System.Type type)
  RVA=0x0980F258  token=0x6000B4E  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0980F89C  token=0x6000B4F  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0980F3E8  token=0x6000B50  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  RVA=0x0980F28C  token=0x6000B51  System.Int32 CompareTo(System.Object valueNo1, System.Object valueNo2)
  RVA=0x0980F520  token=0x6000B52  System.Int32 CompareWithFamilies(System.Object valueNo1, System.Object valueNo2)
  RVA=0x098109D0  token=0x6000B53  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09811300  token=0x6000B54  System.Object Get(System.Int32 recordNo)
  RVA=0x09810A64  token=0x6000B55  System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType)
  RVA=0x09811338  token=0x6000B56  System.Boolean IsNull(System.Int32 record)
  RVA=0x09811590  token=0x6000B57  System.Void Set(System.Int32 recordNo, System.Object value)
  RVA=0x09811368  token=0x6000B58  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0980FF40  token=0x6000B59  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981034C  token=0x6000B5A  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x0980FAE4  token=0x6000B5B  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0980FA0C  token=0x6000B5C  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x09810A2C  token=0x6000B5D  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981082C  token=0x6000B5E  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09811420  token=0x6000B5F  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x09811C34  token=0x6000B60  System.Void VerifyIDynamicMetaObjectProvider(System.Type type)
  RVA=0x09810B74  token=0x6000B61  System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type)
  RVA=0x09810BDC  token=0x6000B62  System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute)
  RVA=0x09811D40  token=0x6000B63  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.SByteStorage
TYPE:  sealed class
TOKEN: 0x20000C7
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.SByte[]                  _values  // 0x50
METHODS:
  RVA=0x09812CE0  token=0x6000B68  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09811F88  token=0x6000B69  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981275C  token=0x6000B6A  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09812690  token=0x6000B6B  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981281C  token=0x6000B6C  System.Object ConvertValue(System.Object value)
  RVA=0x09805498  token=0x6000B6D  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09812A40  token=0x6000B6E  System.Object Get(System.Int32 record)
  RVA=0x09812C04  token=0x6000B6F  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09812AC0  token=0x6000B70  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x098128CC  token=0x6000B71  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098127C0  token=0x6000B72  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09812A08  token=0x6000B73  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09812930  token=0x6000B74  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09812B88  token=0x6000B75  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlConvert
TYPE:  static class
TOKEN: 0x20000C8
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0981786C  token=0x6000B76  System.Data.SqlTypes.SqlByte ConvertToSqlByte(System.Object value)
  RVA=0x098189AC  token=0x6000B77  System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(System.Object value)
  RVA=0x09818B94  token=0x6000B78  System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(System.Object value)
  RVA=0x09818E3C  token=0x6000B79  System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(System.Object value)
  RVA=0x098182A4  token=0x6000B7A  System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(System.Object value)
  RVA=0x09817DA0  token=0x6000B7B  System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(System.Object value)
  RVA=0x0981965C  token=0x6000B7C  System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(System.Object value)
  RVA=0x098191E4  token=0x6000B7D  System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(System.Object value)
  RVA=0x09817C10  token=0x6000B7E  System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(System.Object value)
  RVA=0x0981770C  token=0x6000B7F  System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(System.Object value)
  RVA=0x0981883C  token=0x6000B80  System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(System.Object value)
  RVA=0x098175A8  token=0x6000B81  System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(System.Object value)
  RVA=0x09819B3C  token=0x6000B82  System.Data.SqlTypes.SqlString ConvertToSqlString(System.Object value)
  RVA=0x09817AF4  token=0x6000B83  System.Data.SqlTypes.SqlChars ConvertToSqlChars(System.Object value)
  RVA=0x098179D8  token=0x6000B84  System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(System.Object value)
  RVA=0x09817538  token=0x6000B85  System.DateTimeOffset ConvertStringToDateTimeOffset(System.String value, System.IFormatProvider formatProvider)
  RVA=0x09815D24  token=0x6000B86  System.Object ChangeTypeForDefaultValue(System.Object value, System.Type type, System.IFormatProvider formatProvider)
  RVA=0x09814DE8  token=0x6000B87  System.Object ChangeType2(System.Object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider)
  RVA=0x09815E98  token=0x6000B88  System.Object ChangeTypeForXML(System.Object value, System.Type type)
END_CLASS

CLASS: System.Data.Common.SqlBinaryStorage
TYPE:  sealed class
TOKEN: 0x20000C9
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBinary[]_values  // 0x50
METHODS:
  RVA=0x098137F4  token=0x6000B89  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09812DB4  token=0x6000B8A  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09813040  token=0x6000B8B  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09812FB0  token=0x6000B8C  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09813260  token=0x6000B8D  System.Object ConvertValue(System.Object value)
  RVA=0x09813540  token=0x6000B8E  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098135C0  token=0x6000B8F  System.Object Get(System.Int32 record)
  RVA=0x09813630  token=0x6000B90  System.Boolean IsNull(System.Int32 record)
  RVA=0x098137B4  token=0x6000B91  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09813698  token=0x6000B92  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x098132C4  token=0x6000B93  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098130D8  token=0x6000B94  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09813588  token=0x6000B95  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09813478  token=0x6000B96  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09813750  token=0x6000B97  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlByteStorage
TYPE:  sealed class
TOKEN: 0x20000CA
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlByte[]  _values  // 0x50
METHODS:
  RVA=0x09814CD4  token=0x6000B98  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09813904  token=0x6000B99  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09814508  token=0x6000B9A  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09814478  token=0x6000B9B  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09814728  token=0x6000B9C  System.Object ConvertValue(System.Object value)
  RVA=0x09814A18  token=0x6000B9D  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09814A9C  token=0x6000B9E  System.Object Get(System.Int32 record)
  RVA=0x09814B0C  token=0x6000B9F  System.Boolean IsNull(System.Int32 record)
  RVA=0x09814C90  token=0x6000BA0  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09814B74  token=0x6000BA1  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981478C  token=0x6000BA2  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098145A0  token=0x6000BA3  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09814A64  token=0x6000BA4  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09814940  token=0x6000BA5  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09814C2C  token=0x6000BA6  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlBytesStorage
TYPE:  sealed class
TOKEN: 0x20000CB
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBytes[] _values  // 0x50
METHODS:
  RVA=0x0981C324  token=0x6000BA7  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981BA68  token=0x6000BA8  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x01002730  token=0x6000BA9  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x01002730  token=0x6000BAA  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981C074  token=0x6000BAB  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981C0E8  token=0x6000BAC  System.Object Get(System.Int32 record)
  RVA=0x0981C114  token=0x6000BAD  System.Boolean IsNull(System.Int32 record)
  RVA=0x0981C268  token=0x6000BAE  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981C14C  token=0x6000BAF  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981BDC4  token=0x6000BB0  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981BC3C  token=0x6000BB1  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981C0B0  token=0x6000BB2  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981BF98  token=0x6000BB3  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981C204  token=0x6000BB4  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlCharsStorage
TYPE:  sealed class
TOKEN: 0x20000CC
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlChars[] _values  // 0x50
METHODS:
  RVA=0x0981CC30  token=0x6000BB5  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981C3F8  token=0x6000BB6  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x01002730  token=0x6000BB7  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x01002730  token=0x6000BB8  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981C074  token=0x6000BB9  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981C0E8  token=0x6000BBA  System.Object Get(System.Int32 record)
  RVA=0x0981C114  token=0x6000BBB  System.Boolean IsNull(System.Int32 record)
  RVA=0x0981CB74  token=0x6000BBC  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981CA58  token=0x6000BBD  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981C754  token=0x6000BBE  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981C5CC  token=0x6000BBF  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981CA20  token=0x6000BC0  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981C944  token=0x6000BC1  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981CB10  token=0x6000BC2  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDateTimeStorage
TYPE:  sealed class
TOKEN: 0x20000CD
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDateTime[]_values  // 0x50
METHODS:
  RVA=0x0981DAC0  token=0x6000BC3  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981CD04  token=0x6000BC4  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981D284  token=0x6000BC5  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981D1DC  token=0x6000BC6  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981D4B4  token=0x6000BC7  System.Object ConvertValue(System.Object value)
  RVA=0x0981D7D8  token=0x6000BC8  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981D86C  token=0x6000BC9  System.Object Get(System.Int32 record)
  RVA=0x0981D8E4  token=0x6000BCA  System.Boolean IsNull(System.Int32 record)
  RVA=0x0981DA64  token=0x6000BCB  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981D948  token=0x6000BCC  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981D528  token=0x6000BCD  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981D32C  token=0x6000BCE  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981D834  token=0x6000BCF  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981D6F8  token=0x6000BD0  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981DA00  token=0x6000BD1  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDecimalStorage
TYPE:  sealed class
TOKEN: 0x20000CE
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDecimal[]_values  // 0x50
METHODS:
  RVA=0x0981F0C4  token=0x6000BD2  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981DBFC  token=0x6000BD3  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981E888  token=0x6000BD4  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981E7E4  token=0x6000BD5  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981EAB8  token=0x6000BD6  System.Object ConvertValue(System.Object value)
  RVA=0x0981EDD8  token=0x6000BD7  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981EE6C  token=0x6000BD8  System.Object Get(System.Int32 record)
  RVA=0x0981EEE4  token=0x6000BD9  System.Boolean IsNull(System.Int32 record)
  RVA=0x0981F068  token=0x6000BDA  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981EF4C  token=0x6000BDB  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981EB2C  token=0x6000BDC  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981E930  token=0x6000BDD  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981EE34  token=0x6000BDE  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981ECF0  token=0x6000BDF  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981F004  token=0x6000BE0  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDoubleStorage
TYPE:  sealed class
TOKEN: 0x20000CF
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDouble[]_values  // 0x50
METHODS:
  RVA=0x09820580  token=0x6000BE1  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981F1FC  token=0x6000BE2  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981FD80  token=0x6000BE3  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981FCE4  token=0x6000BE4  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981FFA8  token=0x6000BE5  System.Object ConvertValue(System.Object value)
  RVA=0x098202B0  token=0x6000BE6  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982033C  token=0x6000BE7  System.Object Get(System.Int32 record)
  RVA=0x098203AC  token=0x6000BE8  System.Boolean IsNull(System.Int32 record)
  RVA=0x0982052C  token=0x6000BE9  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09820410  token=0x6000BEA  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09820014  token=0x6000BEB  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981FE20  token=0x6000BEC  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09820304  token=0x6000BED  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x098201D8  token=0x6000BEE  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x098204C8  token=0x6000BEF  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlGuidStorage
TYPE:  sealed class
TOKEN: 0x20000D0
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlGuid[]  _values  // 0x50
METHODS:
  RVA=0x09821098  token=0x6000BF0  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x098206A0  token=0x6000BF1  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982092C  token=0x6000BF2  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982089C  token=0x6000BF3  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09820B4C  token=0x6000BF4  System.Object ConvertValue(System.Object value)
  RVA=0x09813540  token=0x6000BF5  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09820E64  token=0x6000BF6  System.Object Get(System.Int32 record)
  RVA=0x09820ED4  token=0x6000BF7  System.Boolean IsNull(System.Int32 record)
  RVA=0x09821058  token=0x6000BF8  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09820F3C  token=0x6000BF9  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09820BB0  token=0x6000BFA  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098209C4  token=0x6000BFB  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09820E2C  token=0x6000BFC  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09820D64  token=0x6000BFD  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09820FF4  token=0x6000BFE  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt16Storage
TYPE:  sealed class
TOKEN: 0x20000D1
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt16[] _values  // 0x50
METHODS:
  RVA=0x0982255C  token=0x6000BFF  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x098211A8  token=0x6000C00  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09821D9C  token=0x6000C01  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09821D0C  token=0x6000C02  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09821FBC  token=0x6000C03  System.Object ConvertValue(System.Object value)
  RVA=0x098222A8  token=0x6000C04  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982232C  token=0x6000C05  System.Object Get(System.Int32 record)
  RVA=0x09822398  token=0x6000C06  System.Boolean IsNull(System.Int32 record)
  RVA=0x0982251C  token=0x6000C07  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09822400  token=0x6000C08  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09822020  token=0x6000C09  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09821E34  token=0x6000C0A  System.String ConvertObjectToXml(System.Object value)
  RVA=0x098222F4  token=0x6000C0B  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x098221D4  token=0x6000C0C  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x098224B8  token=0x6000C0D  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt32Storage
TYPE:  sealed class
TOKEN: 0x20000D2
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt32[] _values  // 0x50
METHODS:
  RVA=0x09823A0C  token=0x6000C0E  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0982266C  token=0x6000C0F  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09823240  token=0x6000C10  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098231B0  token=0x6000C11  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09823460  token=0x6000C12  System.Object ConvertValue(System.Object value)
  RVA=0x09823750  token=0x6000C13  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098237D4  token=0x6000C14  System.Object Get(System.Int32 record)
  RVA=0x09823844  token=0x6000C15  System.Boolean IsNull(System.Int32 record)
  RVA=0x098239C8  token=0x6000C16  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x098238AC  token=0x6000C17  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x098234C4  token=0x6000C18  System.Object ConvertXmlToObject(System.String s)
  RVA=0x098232D8  token=0x6000C19  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0982379C  token=0x6000C1A  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09823678  token=0x6000C1B  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09823964  token=0x6000C1C  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt64Storage
TYPE:  sealed class
TOKEN: 0x20000D3
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt64[] _values  // 0x50
METHODS:
  RVA=0x09824F38  token=0x6000C1D  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09823B1C  token=0x6000C1E  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982478C  token=0x6000C1F  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098246F0  token=0x6000C20  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x098249B4  token=0x6000C21  System.Object ConvertValue(System.Object value)
  RVA=0x098202B0  token=0x6000C22  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09824CF4  token=0x6000C23  System.Object Get(System.Int32 record)
  RVA=0x09824D64  token=0x6000C24  System.Boolean IsNull(System.Int32 record)
  RVA=0x09824EE4  token=0x6000C25  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09824DC8  token=0x6000C26  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09824A20  token=0x6000C27  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982482C  token=0x6000C28  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09824CBC  token=0x6000C29  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09824BE4  token=0x6000C2A  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09824E80  token=0x6000C2B  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlMoneyStorage
TYPE:  sealed class
TOKEN: 0x20000D4
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlMoney[] _values  // 0x50
METHODS:
  RVA=0x098264BC  token=0x6000C2C  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09825058  token=0x6000C2D  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09825D10  token=0x6000C2E  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09825C74  token=0x6000C2F  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09825F38  token=0x6000C30  System.Object ConvertValue(System.Object value)
  RVA=0x098202B0  token=0x6000C31  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09826278  token=0x6000C32  System.Object Get(System.Int32 record)
  RVA=0x098262E8  token=0x6000C33  System.Boolean IsNull(System.Int32 record)
  RVA=0x09826468  token=0x6000C34  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0982634C  token=0x6000C35  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09825FA4  token=0x6000C36  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09825DB0  token=0x6000C37  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09826240  token=0x6000C38  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09826168  token=0x6000C39  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09826404  token=0x6000C3A  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlSingleStorage
TYPE:  sealed class
TOKEN: 0x20000D5
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlSingle[]_values  // 0x50
METHODS:
  RVA=0x098278F4  token=0x6000C3B  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x098265DC  token=0x6000C3C  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09827174  token=0x6000C3D  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098270E4  token=0x6000C3E  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09827394  token=0x6000C3F  System.Object ConvertValue(System.Object value)
  RVA=0x09823750  token=0x6000C40  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x098276BC  token=0x6000C41  System.Object Get(System.Int32 record)
  RVA=0x0982772C  token=0x6000C42  System.Boolean IsNull(System.Int32 record)
  RVA=0x098278B0  token=0x6000C43  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09827794  token=0x6000C44  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x098273F8  token=0x6000C45  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982720C  token=0x6000C46  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09827684  token=0x6000C47  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x098275AC  token=0x6000C48  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982784C  token=0x6000C49  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlStringStorage
TYPE:  sealed class
TOKEN: 0x20000D6
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlString[]_values  // 0x50
METHODS:
  RVA=0x098287A8  token=0x6000C4A  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09827A04  token=0x6000C4B  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  RVA=0x09827DF0  token=0x6000C4C  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09827E84  token=0x6000C4D  System.Int32 Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2)
  RVA=0x09827D3C  token=0x6000C4E  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x098280EC  token=0x6000C4F  System.Object ConvertValue(System.Object value)
  RVA=0x0982840C  token=0x6000C50  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982854C  token=0x6000C51  System.Object Get(System.Int32 record)
  RVA=0x098284A0  token=0x6000C52  System.Int32 GetStringLength(System.Int32 record)
  RVA=0x098285C4  token=0x6000C53  System.Boolean IsNull(System.Int32 record)
  RVA=0x0982874C  token=0x6000C54  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09828630  token=0x6000C55  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09828160  token=0x6000C56  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09827F64  token=0x6000C57  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09828468  token=0x6000C58  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09828324  token=0x6000C59  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x098286E8  token=0x6000C5A  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlBooleanStorage
TYPE:  sealed class
TOKEN: 0x20000D7
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBoolean[]_values  // 0x50
METHODS:
  RVA=0x0981B958  token=0x6000C5B  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0981AD94  token=0x6000C5C  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981B198  token=0x6000C5D  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981B10C  token=0x6000C5E  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981B3B8  token=0x6000C5F  System.Object ConvertValue(System.Object value)
  RVA=0x0981B6A4  token=0x6000C60  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981B728  token=0x6000C61  System.Object Get(System.Int32 record)
  RVA=0x0981B794  token=0x6000C62  System.Boolean IsNull(System.Int32 record)
  RVA=0x0981B918  token=0x6000C63  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981B7FC  token=0x6000C64  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981B41C  token=0x6000C65  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981B230  token=0x6000C66  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981B6F0  token=0x6000C67  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981B5D0  token=0x6000C68  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981B8B4  token=0x6000C69  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SingleStorage
TYPE:  sealed class
TOKEN: 0x20000D8
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Single[]                 _values  // 0x50
METHODS:
  RVA=0x0981ACC0  token=0x6000C6A  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09819F60  token=0x6000C6B  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0981A6A8  token=0x6000C6C  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981A5D0  token=0x6000C6D  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0981A788  token=0x6000C6E  System.Object ConvertValue(System.Object value)
  RVA=0x0981A978  token=0x6000C6F  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981AA10  token=0x6000C70  System.Object Get(System.Int32 record)
  RVA=0x0981ABE0  token=0x6000C71  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0981AA9C  token=0x6000C72  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0981A83C  token=0x6000C73  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0981A72C  token=0x6000C74  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0981A9D8  token=0x6000C75  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0981A8A0  token=0x6000C76  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0981AB64  token=0x6000C77  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlUdtStorage
TYPE:  sealed class
TOKEN: 0x20000D9
SIZE:  0x60
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.Object[]                 _values  // 0x50
  private   readonly System.Boolean                  _implementsIXmlSerializable  // 0x58
  private   readonly System.Boolean                  _implementsIComparable  // 0x59
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Object>s_typeToNull  // static @ 0x0
METHODS:
  RVA=0x098299C0  token=0x6000C78  System.Void .ctor(System.Data.DataColumn column, System.Type type)
  RVA=0x09829870  token=0x6000C79  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object nullValue)
  RVA=0x098293F0  token=0x6000C7A  System.Object GetStaticNullForUdtType(System.Type type)
  RVA=0x098294F8  token=0x6000C7B  System.Boolean IsNull(System.Int32 record)
  RVA=0x098288DC  token=0x6000C7C  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x09828A80  token=0x6000C7D  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09828910  token=0x6000C7E  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  RVA=0x09829340  token=0x6000C7F  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0981C0E8  token=0x6000C80  System.Object Get(System.Int32 recordNo)
  RVA=0x098296A4  token=0x6000C81  System.Void Set(System.Int32 recordNo, System.Object value)
  RVA=0x09829578  token=0x6000C82  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x09828F50  token=0x6000C83  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09828D7C  token=0x6000C84  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x09828B8C  token=0x6000C85  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09828AC0  token=0x6000C86  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  RVA=0x098293B8  token=0x6000C87  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0982924C  token=0x6000C88  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x09829640  token=0x6000C89  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x098297E4  token=0x6000C8A  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.StringStorage
TYPE:  sealed class
TOKEN: 0x20000DB
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private           System.String[]                 _values  // 0x50
METHODS:
  RVA=0x0982A124  token=0x6000C8D  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x09829A34  token=0x6000C8E  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  RVA=0x09829D40  token=0x6000C8F  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09829C7C  token=0x6000C90  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x09829E00  token=0x6000C91  System.Object ConvertValue(System.Object value)
  RVA=0x09829F08  token=0x6000C92  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x09811300  token=0x6000C93  System.Object Get(System.Int32 recordNo)
  RVA=0x09829F7C  token=0x6000C94  System.Int32 GetStringLength(System.Int32 record)
  RVA=0x09811338  token=0x6000C95  System.Boolean IsNull(System.Int32 record)
  RVA=0x0982A0CC  token=0x6000C96  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x09829FB0  token=0x6000C97  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x03D51810  token=0x6000C98  System.Object ConvertXmlToObject(System.String s)
  RVA=0x09829DB8  token=0x6000C99  System.String ConvertObjectToXml(System.Object value)
  RVA=0x09829F44  token=0x6000C9A  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x09829E2C  token=0x6000C9B  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982A068  token=0x6000C9C  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.TimeSpanStorage
TYPE:  sealed class
TOKEN: 0x20000DC
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.TimeSpan                 s_defaultValue  // static @ 0x0
  private           System.TimeSpan[]               _values  // 0x50
METHODS:
  RVA=0x0982B404  token=0x6000C9D  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0982A1F0  token=0x6000C9E  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982ABF0  token=0x6000C9F  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982AAD0  token=0x6000CA0  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0982AD74  token=0x6000CA1  System.TimeSpan ConvertToTimeSpan(System.Object value)
  RVA=0x0982AEE0  token=0x6000CA2  System.Object ConvertValue(System.Object value)
  RVA=0x09809E20  token=0x6000CA3  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982B0DC  token=0x6000CA4  System.Object Get(System.Int32 record)
  RVA=0x0982B2E4  token=0x6000CA5  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0982B1A0  token=0x6000CA6  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0982AF68  token=0x6000CA7  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982AD18  token=0x6000CA8  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0982B0A4  token=0x6000CA9  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0982AFCC  token=0x6000CAA  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982B268  token=0x6000CAB  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  RVA=0x0982B3A4  token=0x6000CAC  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.UInt16Storage
TYPE:  sealed class
TOKEN: 0x20000DD
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.UInt16                   s_defaultValue  // static @ 0x0
  private           System.UInt16[]                 _values  // 0x50
METHODS:
  RVA=0x0982C480  token=0x6000CAD  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0982B608  token=0x6000CAE  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982BE68  token=0x6000CAF  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982BD80  token=0x6000CB0  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0982BF7C  token=0x6000CB1  System.Object ConvertValue(System.Object value)
  RVA=0x09805FA4  token=0x6000CB2  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982C1A4  token=0x6000CB3  System.Object Get(System.Int32 record)
  RVA=0x0982C384  token=0x6000CB4  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0982C240  token=0x6000CB5  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0982C030  token=0x6000CB6  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982BF20  token=0x6000CB7  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0982C16C  token=0x6000CB8  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0982C094  token=0x6000CB9  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982C308  token=0x6000CBA  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.UInt32Storage
TYPE:  sealed class
TOKEN: 0x20000DE
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.UInt32                   s_defaultValue  // static @ 0x0
  private           System.UInt32[]                 _values  // 0x50
METHODS:
  RVA=0x0982D3C4  token=0x6000CBB  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0982C570  token=0x6000CBC  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982CDB0  token=0x6000CBD  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982CCD0  token=0x6000CBE  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0982CEC8  token=0x6000CBF  System.Object ConvertValue(System.Object value)
  RVA=0x0980DF88  token=0x6000CC0  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982D0EC  token=0x6000CC1  System.Object Get(System.Int32 record)
  RVA=0x0982D2CC  token=0x6000CC2  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0982D188  token=0x6000CC3  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0982CF78  token=0x6000CC4  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982CE6C  token=0x6000CC5  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0982D0B4  token=0x6000CC6  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0982CFDC  token=0x6000CC7  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982D250  token=0x6000CC8  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.UInt64Storage
TYPE:  sealed class
TOKEN: 0x20000DF
SIZE:  0x58
EXTENDS: System.Data.Common.DataStorage
FIELDS:
  private   static readonly System.UInt64                   s_defaultValue  // static @ 0x0
  private           System.UInt64[]                 _values  // 0x50
METHODS:
  RVA=0x0982E37C  token=0x6000CC9  System.Void .ctor(System.Data.DataColumn column)
  RVA=0x0982D4B4  token=0x6000CCA  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  RVA=0x0982DD5C  token=0x6000CCB  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982DC78  token=0x6000CCC  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  RVA=0x0982DE78  token=0x6000CCD  System.Object ConvertValue(System.Object value)
  RVA=0x0980EE44  token=0x6000CCE  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  RVA=0x0982E0A0  token=0x6000CCF  System.Object Get(System.Int32 record)
  RVA=0x0982E280  token=0x6000CD0  System.Void Set(System.Int32 record, System.Object value)
  RVA=0x0982E13C  token=0x6000CD1  System.Void SetCapacity(System.Int32 capacity)
  RVA=0x0982DF2C  token=0x6000CD2  System.Object ConvertXmlToObject(System.String s)
  RVA=0x0982DE1C  token=0x6000CD3  System.String ConvertObjectToXml(System.Object value)
  RVA=0x0982E068  token=0x6000CD4  System.Object GetEmptyStorage(System.Int32 recordCount)
  RVA=0x0982DF90  token=0x6000CD5  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  RVA=0x0982E204  token=0x6000CD6  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.SqlTypes.SQLResource
TYPE:  static class
TOKEN: 0x200009C
SIZE:  0x10
FIELDS:
PROPERTIES:
  NullString  get=0x097EA7F4
  ArithOverflowMessage  get=0x097EA694
  DivideByZeroMessage  get=0x097EA770
  NullValueMessage  get=0x097EA820
  TruncationMessage  get=0x097EA878
  DateTimeOverflowMessage  get=0x097EA744
  ConcatDiffCollationMessage  get=0x097EA6EC
  CompareDiffCollationMessage  get=0x097EA6C0
  ConversionOverflowMessage  get=0x097EA718
  TimeZoneSpecifiedMessage  get=0x097EA84C
  InvalidPrecScaleMessage  get=0x097EA7C8
  FormatMessage  get=0x097EA79C
METHODS:
  RVA=0x097EA5A4  token=0x6000872  System.String InvalidOpStreamClosed(System.String method)
  RVA=0x097EA658  token=0x6000873  System.String InvalidOpStreamNonWritable(System.String method)
  RVA=0x097EA5E0  token=0x6000874  System.String InvalidOpStreamNonReadable(System.String method)
  RVA=0x097EA61C  token=0x6000875  System.String InvalidOpStreamNonSeekable(System.String method)
END_CLASS

CLASS: System.Data.SqlTypes.INullable
TYPE:  interface
TOKEN: 0x200009D
FIELDS:
PROPERTIES:
  IsNull  get=-1  // abstract
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlBinary
TYPE:  sealed struct
TOKEN: 0x200009E
SIZE:  0x18
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Byte[]                   _value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlBinary  Null  // static @ 0x0
PROPERTIES:
  IsNull  get=0x02361C20
  Value  get=0x097EB168
METHODS:
  RVA=0x0426F744  token=0x6000877  System.Void .ctor(System.Boolean fNull)
  RVA=0x097EB0F0  token=0x6000878  System.Void .ctor(System.Byte[] value)
  RVA=0x097EB3C4  token=0x600087B  System.Data.SqlTypes.SqlBinary op_Implicit(System.Byte[] x)
  RVA=0x097EAFD0  token=0x600087C  System.String ToString()
  RVA=0x097EACF0  token=0x600087D  System.Data.SqlTypes.EComparison PerformCompareByte(System.Byte[] x, System.Byte[] y)
  RVA=0x097EB22C  token=0x600087E  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  RVA=0x097EB3EC  token=0x600087F  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  RVA=0x097EB2F8  token=0x6000880  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  RVA=0x097EA9A0  token=0x6000881  System.Int32 CompareTo(System.Object value)
  RVA=0x097EA8A4  token=0x6000882  System.Int32 CompareTo(System.Data.SqlTypes.SqlBinary value)
  RVA=0x097EAA90  token=0x6000883  System.Boolean Equals(System.Object value)
  RVA=0x097EAC94  token=0x6000884  System.Int32 HashByteArray(System.Byte[] rgbValue, System.Int32 length)
  RVA=0x097EAB88  token=0x6000885  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000886  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097EADBC  token=0x6000887  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097EAEE0  token=0x6000888  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097EAC1C  token=0x6000889  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097EB090  token=0x600088A  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlBoolean
TYPE:  sealed struct
TOKEN: 0x200009F
SIZE:  0x11
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Byte                     m_value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlBoolean True  // static @ 0x0
  public    static readonly System.Data.SqlTypes.SqlBoolean False  // static @ 0x1
  public    static readonly System.Data.SqlTypes.SqlBoolean Null  // static @ 0x2
  public    static readonly System.Data.SqlTypes.SqlBoolean Zero  // static @ 0x3
  public    static readonly System.Data.SqlTypes.SqlBoolean One  // static @ 0x4
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097EBCD8
  IsTrue  get=0x097EBCD0
  IsFalse  get=0x097EBCC8
  ByteValue  get=0x097EBC40
METHODS:
  RVA=0x097EBC38  token=0x600088B  System.Void .ctor(System.Boolean value)
  RVA=0x097EBBD8  token=0x600088C  System.Void .ctor(System.Int32 value)
  RVA=0x097EBC24  token=0x600088D  System.Void .ctor(System.Int32 value, System.Boolean fNull)
  RVA=0x097EBF08  token=0x6000892  System.Data.SqlTypes.SqlBoolean op_Implicit(System.Boolean x)
  RVA=0x097EBF10  token=0x6000893  System.Boolean op_True(System.Data.SqlTypes.SqlBoolean x)
  RVA=0x097EBD38  token=0x6000894  System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  RVA=0x097EBDE0  token=0x6000895  System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  RVA=0x097EBAA0  token=0x6000897  System.String ToString()
  RVA=0x097EBE88  token=0x6000898  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  RVA=0x097EB4B8  token=0x6000899  System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  RVA=0x097EB888  token=0x600089A  System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  RVA=0x097EB5D8  token=0x600089B  System.Int32 CompareTo(System.Object value)
  RVA=0x097EB514  token=0x600089C  System.Int32 CompareTo(System.Data.SqlTypes.SqlBoolean value)
  RVA=0x097EB6C4  token=0x600089D  System.Boolean Equals(System.Object value)
  RVA=0x097EB79C  token=0x600089E  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x600089F  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097EB8E4  token=0x60008A0  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097EB9BC  token=0x60008A1  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097EB810  token=0x60008A2  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097EBB28  token=0x60008A3  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlByte
TYPE:  sealed struct
TOKEN: 0x20000A0
SIZE:  0x12
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Byte                     m_value  // 0x11
  private   static readonly System.Int32                    s_iBitNotByteMax  // static @ 0x0
  public    static readonly System.Data.SqlTypes.SqlByte    Null  // static @ 0x4
  public    static readonly System.Data.SqlTypes.SqlByte    Zero  // static @ 0x6
  public    static readonly System.Data.SqlTypes.SqlByte    MinValue  // static @ 0x8
  public    static readonly System.Data.SqlTypes.SqlByte    MaxValue  // static @ 0xa
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097EC75C
METHODS:
  RVA=0x03D754C0  token=0x60008A4  System.Void .ctor(System.Boolean fNull)
  RVA=0x03D685E0  token=0x60008A5  System.Void .ctor(System.Byte value)
  RVA=0x03D754D0  token=0x60008A8  System.Data.SqlTypes.SqlByte op_Implicit(System.Byte x)
  RVA=0x097EC654  token=0x60008A9  System.String ToString()
  RVA=0x097EC7B4  token=0x60008AA  System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097ECDE4  token=0x60008AB  System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097ECCCC  token=0x60008AC  System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097EC8C8  token=0x60008AD  System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097ECA5C  token=0x60008AE  System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097EC9C0  token=0x60008AF  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097ECC30  token=0x60008B0  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097ECB94  token=0x60008B1  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097EC36C  token=0x60008B2  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097EC310  token=0x60008B3  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  RVA=0x097EC594  token=0x60008B4  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097EC5F4  token=0x60008B5  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  RVA=0x097EC054  token=0x60008B6  System.Int32 CompareTo(System.Object value)
  RVA=0x097EBF58  token=0x60008B7  System.Int32 CompareTo(System.Data.SqlTypes.SqlByte value)
  RVA=0x097EC144  token=0x60008B8  System.Boolean Equals(System.Object value)
  RVA=0x097EC23C  token=0x60008B9  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x60008BA  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097EC3C8  token=0x60008BB  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097EC4A4  token=0x60008BC  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097EC298  token=0x60008BD  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097EC6AC  token=0x60008BE  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlBytesCharsState
TYPE:  sealed struct
TOKEN: 0x20000A1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.SqlBytesCharsStateNull  // const
  public    static  System.Data.SqlTypes.SqlBytesCharsStateBuffer  // const
  public    static  System.Data.SqlTypes.SqlBytesCharsStateStream  // const
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlBytes
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x38
IMPLEMENTS: System.Data.SqlTypes.INullable System.Xml.Serialization.IXmlSerializable System.Runtime.Serialization.ISerializable
FIELDS:
  private           System.Byte[]                   _rgbBuf  // 0x10
  private           System.Int64                    _lCurLen  // 0x18
  private           System.IO.Stream                _stream  // 0x20
  private           System.Data.SqlTypes.SqlBytesCharsState_state  // 0x28
  private           System.Byte[]                   _rgbWorkBuf  // 0x30
PROPERTIES:
  IsNull  get=0x0564D8A8
  Buffer  get=0x097ED4C0
  Length  get=0x097ED4E8
  Value  get=0x097ED5B4
  Null  get=0x097ED560
METHODS:
  RVA=0x097ED3D0  token=0x60008BF  System.Void .ctor()
  RVA=0x097ED45C  token=0x60008C0  System.Void .ctor(System.Byte[] buffer)
  RVA=0x097ED3D8  token=0x60008C1  System.Void .ctor(System.Data.SqlTypes.SqlBinary value)
  RVA=0x097ED120  token=0x60008C6  System.Void SetNull()
  RVA=0x097ECEF8  token=0x60008C7  System.Void CopyStreamToBuffer()
  RVA=0x056B0004  token=0x60008C8  System.Boolean FStream()
  RVA=0x097ED0D0  token=0x60008C9  System.Void SetBuffer(System.Byte[] buffer)
  RVA=0x01002730  token=0x60008CA  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097ED194  token=0x60008CB  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  RVA=0x097ED2D0  token=0x60008CC  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097ED058  token=0x60008CD  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097ED148  token=0x60008CE  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: System.Data.SqlTypes.SqlChars
TYPE:  sealed class
TOKEN: 0x20000A3
SIZE:  0x38
IMPLEMENTS: System.Data.SqlTypes.INullable System.Xml.Serialization.IXmlSerializable System.Runtime.Serialization.ISerializable
FIELDS:
  private           System.Char[]                   _rgchBuf  // 0x10
  private           System.Int64                    _lCurLen  // 0x18
  private           System.Data.SqlTypes.SqlStreamChars_stream  // 0x20
  private           System.Data.SqlTypes.SqlBytesCharsState_state  // 0x28
  private           System.Char[]                   _rgchWorkBuf  // 0x30
PROPERTIES:
  IsNull  get=0x0564D8A8
  Buffer  get=0x097EDC34
  Length  get=0x097EDC5C
  Value  get=0x097EDD28
  Null  get=0x097EDCD4
METHODS:
  RVA=0x097ED3D0  token=0x60008D0  System.Void .ctor()
  RVA=0x097ED45C  token=0x60008D1  System.Void .ctor(System.Char[] buffer)
  RVA=0x097EDBA4  token=0x60008D2  System.Void .ctor(System.Data.SqlTypes.SqlString value)
  RVA=0x097ED120  token=0x60008D7  System.Void SetNull()
  RVA=0x056B0004  token=0x60008D8  System.Boolean FStream()
  RVA=0x097ED7B0  token=0x60008D9  System.Void CopyStreamToBuffer()
  RVA=0x097ED0D0  token=0x60008DA  System.Void SetBuffer(System.Char[] buffer)
  RVA=0x01002730  token=0x60008DB  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097ED9D4  token=0x60008DC  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  RVA=0x097EDAB8  token=0x60008DD  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097ED910  token=0x60008DE  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097ED988  token=0x60008DF  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: System.Data.SqlTypes.SqlDateTime
TYPE:  sealed struct
TOKEN: 0x20000A4
SIZE:  0x1C
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int32                    m_day  // 0x14
  private           System.Int32                    m_time  // 0x18
  private   static readonly System.Double                   s_SQLTicksPerMillisecond  // static @ 0x0
  public    static readonly System.Int32                    SQLTicksPerSecond  // static @ 0x8
  public    static readonly System.Int32                    SQLTicksPerMinute  // static @ 0xc
  public    static readonly System.Int32                    SQLTicksPerHour  // static @ 0x10
  private   static readonly System.Int32                    s_SQLTicksPerDay  // static @ 0x14
  private   static readonly System.Int64                    s_ticksPerSecond  // static @ 0x18
  private   static readonly System.DateTime                 s_SQLBaseDate  // static @ 0x20
  private   static readonly System.Int64                    s_SQLBaseDateTicks  // static @ 0x28
  private   static readonly System.Int32                    s_minYear  // static @ 0x30
  private   static readonly System.Int32                    s_maxYear  // static @ 0x34
  private   static readonly System.Int32                    s_minDay  // static @ 0x38
  private   static readonly System.Int32                    s_maxDay  // static @ 0x3c
  private   static readonly System.Int32                    s_minTime  // static @ 0x40
  private   static readonly System.Int32                    s_maxTime  // static @ 0x44
  private   static readonly System.Int32                    s_dayBase  // static @ 0x48
  private   static readonly System.Int32[]                  s_daysToMonth365  // static @ 0x50
  private   static readonly System.Int32[]                  s_daysToMonth366  // static @ 0x58
  private   static readonly System.DateTime                 s_minDateTime  // static @ 0x60
  private   static readonly System.DateTime                 s_maxDateTime  // static @ 0x68
  private   static readonly System.TimeSpan                 s_minTimeSpan  // static @ 0x70
  private   static readonly System.TimeSpan                 s_maxTimeSpan  // static @ 0x78
  private   static readonly System.String                   s_ISO8601_DateTimeFormat  // static @ 0x80
  private   static readonly System.String[]                 s_dateTimeFormats  // static @ 0x88
  public    static readonly System.Data.SqlTypes.SqlDateTimeMinValue  // static @ 0x90
  public    static readonly System.Data.SqlTypes.SqlDateTimeMaxValue  // static @ 0x9c
  public    static readonly System.Data.SqlTypes.SqlDateTimeNull  // static @ 0xa8
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097EF3C0
  DayTicks  get=0x097EF310
  TimeTicks  get=0x097EF368
METHODS:
  RVA=0x03D754E0  token=0x60008E1  System.Void .ctor(System.Boolean fNull)
  RVA=0x097EF1A4  token=0x60008E2  System.Void .ctor(System.DateTime value)
  RVA=0x097EF208  token=0x60008E3  System.Void .ctor(System.Int32 dayTicks, System.Int32 timeTicks)
  RVA=0x097EEB80  token=0x60008E5  System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value)
  RVA=0x097EEA48  token=0x60008E6  System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value)
  RVA=0x097EE3BC  token=0x60008E7  System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value)
  RVA=0x097EE2C8  token=0x60008E8  System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value)
  RVA=0x097EF5B8  token=0x60008EC  System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value)
  RVA=0x097EEAD4  token=0x60008ED  System.String ToString()
  RVA=0x097EF46C  token=0x60008EE  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  RVA=0x097EF5DC  token=0x60008EF  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  RVA=0x097EF510  token=0x60008F0  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  RVA=0x097EE6EC  token=0x60008F1  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  RVA=0x097EE674  token=0x60008F2  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  RVA=0x097EDF24  token=0x60008F3  System.Int32 CompareTo(System.Object value)
  RVA=0x097EE030  token=0x60008F4  System.Int32 CompareTo(System.Data.SqlTypes.SqlDateTime value)
  RVA=0x097EE194  token=0x60008F5  System.Boolean Equals(System.Object value)
  RVA=0x097EE57C  token=0x60008F6  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x60008F7  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097EE764  token=0x60008F8  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097EE920  token=0x60008F9  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097EE5FC  token=0x60008FA  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097EEBF4  token=0x60008FB  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlDecimal
TYPE:  sealed struct
TOKEN: 0x20000A5
SIZE:  0x24
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Byte                     _bStatus  // 0x10
  private           System.Byte                     _bLen  // 0x11
  private           System.Byte                     _bPrec  // 0x12
  private           System.Byte                     _bScale  // 0x13
  private           System.UInt32                   _data1  // 0x14
  private           System.UInt32                   _data2  // 0x18
  private           System.UInt32                   _data3  // 0x1c
  private           System.UInt32                   _data4  // 0x20
  private   static readonly System.Byte                     s_NUMERIC_MAX_PRECISION  // static @ 0x0
  public    static readonly System.Byte                     MaxPrecision  // static @ 0x1
  public    static readonly System.Byte                     MaxScale  // static @ 0x2
  private   static readonly System.Byte                     s_bNullMask  // static @ 0x3
  private   static readonly System.Byte                     s_bIsNull  // static @ 0x4
  private   static readonly System.Byte                     s_bNotNull  // static @ 0x5
  private   static readonly System.Byte                     s_bReverseNullMask  // static @ 0x6
  private   static readonly System.Byte                     s_bSignMask  // static @ 0x7
  private   static readonly System.Byte                     s_bPositive  // static @ 0x8
  private   static readonly System.Byte                     s_bNegative  // static @ 0x9
  private   static readonly System.Byte                     s_bReverseSignMask  // static @ 0xa
  private   static readonly System.UInt32                   s_uiZero  // static @ 0xc
  private   static readonly System.Int32                    s_cNumeMax  // static @ 0x10
  private   static readonly System.Int64                    s_lInt32Base  // static @ 0x18
  private   static readonly System.UInt64                   s_ulInt32Base  // static @ 0x20
  private   static readonly System.UInt64                   s_ulInt32BaseForMod  // static @ 0x28
  private   static readonly System.UInt64                   s_llMax  // static @ 0x30
  private   static readonly System.UInt32                   s_ulBase10  // static @ 0x38
  private   static readonly System.Double                   s_DUINT_BASE  // static @ 0x40
  private   static readonly System.Double                   s_DUINT_BASE2  // static @ 0x48
  private   static readonly System.Double                   s_DUINT_BASE3  // static @ 0x50
  private   static readonly System.Double                   s_DMAX_NUME  // static @ 0x58
  private   static readonly System.UInt32                   s_DBL_DIG  // static @ 0x60
  private   static readonly System.Byte                     s_cNumeDivScaleMin  // static @ 0x64
  private   static readonly System.UInt32[]                 s_rgulShiftBase  // static @ 0x68
  private   static readonly System.UInt32[]                 s_decimalHelpersLo  // static @ 0x70
  private   static readonly System.UInt32[]                 s_decimalHelpersMid  // static @ 0x78
  private   static readonly System.UInt32[]                 s_decimalHelpersHi  // static @ 0x80
  private   static readonly System.UInt32[]                 s_decimalHelpersHiHi  // static @ 0x88
  private   static readonly System.Byte[]                   s_rgCLenFromPrec  // static @ 0x90
  private   static readonly System.UInt32                   s_ulT1  // static @ 0x98
  private   static readonly System.UInt32                   s_ulT2  // static @ 0x9c
  private   static readonly System.UInt32                   s_ulT3  // static @ 0xa0
  private   static readonly System.UInt32                   s_ulT4  // static @ 0xa4
  private   static readonly System.UInt32                   s_ulT5  // static @ 0xa8
  private   static readonly System.UInt32                   s_ulT6  // static @ 0xac
  private   static readonly System.UInt32                   s_ulT7  // static @ 0xb0
  private   static readonly System.UInt32                   s_ulT8  // static @ 0xb4
  private   static readonly System.UInt32                   s_ulT9  // static @ 0xb8
  private   static readonly System.UInt64                   s_dwlT10  // static @ 0xc0
  private   static readonly System.UInt64                   s_dwlT11  // static @ 0xc8
  private   static readonly System.UInt64                   s_dwlT12  // static @ 0xd0
  private   static readonly System.UInt64                   s_dwlT13  // static @ 0xd8
  private   static readonly System.UInt64                   s_dwlT14  // static @ 0xe0
  private   static readonly System.UInt64                   s_dwlT15  // static @ 0xe8
  private   static readonly System.UInt64                   s_dwlT16  // static @ 0xf0
  private   static readonly System.UInt64                   s_dwlT17  // static @ 0xf8
  private   static readonly System.UInt64                   s_dwlT18  // static @ 0x100
  private   static readonly System.UInt64                   s_dwlT19  // static @ 0x108
  public    static readonly System.Data.SqlTypes.SqlDecimal Null  // static @ 0x110
  public    static readonly System.Data.SqlTypes.SqlDecimal MinValue  // static @ 0x124
  public    static readonly System.Data.SqlTypes.SqlDecimal MaxValue  // static @ 0x138
PROPERTIES:
  IsNull  get=0x097F3970
  Value  get=0x097F3B00
  IsPositive  get=0x097F39C4
  Scale  get=0x097F3A74
  Data  get=0x097F388C
METHODS:
  RVA=0x097EFF1C  token=0x60008FC  System.Byte CalculatePrecision()
  RVA=0x097F2A58  token=0x60008FD  System.Boolean VerifyPrecision(System.Byte precision)
  RVA=0x097F34C8  token=0x60008FE  System.Void .ctor(System.Boolean fNull)
  RVA=0x097F3738  token=0x60008FF  System.Void .ctor(System.Decimal value)
  RVA=0x097F33F8  token=0x6000900  System.Void .ctor(System.Int32 value)
  RVA=0x097F3520  token=0x6000901  System.Void .ctor(System.Int64 value)
  RVA=0x097F35F8  token=0x6000902  System.Void .ctor(System.UInt32[] rglData, System.Byte bLen, System.Byte bPrec, System.Byte bScale, System.Boolean fPositive)
  RVA=0x097F1FB4  token=0x6000906  System.Void SetPositive()
  RVA=0x097F200C  token=0x6000907  System.Void SetSignBit(System.Boolean fPositive)
  RVA=0x097F27BC  token=0x600090A  System.String ToString()
  RVA=0x097F1A40  token=0x600090B  System.Data.SqlTypes.SqlDecimal Parse(System.String s)
  RVA=0x097F24D4  token=0x600090C  System.Double ToDouble()
  RVA=0x097F2378  token=0x600090D  System.Decimal ToDecimal()
  RVA=0x097F47C0  token=0x600090E  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Decimal x)
  RVA=0x097F47F4  token=0x600090F  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Int64 x)
  RVA=0x097F56D4  token=0x6000910  System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x)
  RVA=0x097F3B60  token=0x6000911  System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F5614  token=0x6000912  System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F4CC0  token=0x6000913  System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F419C  token=0x6000914  System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F49B8  token=0x6000915  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097F4844  token=0x6000916  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097F4B3C  token=0x6000917  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097F4900  token=0x6000918  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097F4A74  token=0x6000919  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x)
  RVA=0x097F2C40  token=0x600091A  System.Void ZeroToMaxLen(System.UInt32[] rgulData, System.Int32 cUI4sCur)
  RVA=0x097F0A34  token=0x600091B  System.Boolean FZero()
  RVA=0x097F09B4  token=0x600091C  System.Boolean FGt10_38()
  RVA=0x097F09E8  token=0x600091D  System.Boolean FGt10_38(System.UInt32[] rglData)
  RVA=0x097EFB4C  token=0x600091E  System.Byte BGetPrecUI4(System.UInt32 value)
  RVA=0x097EFC90  token=0x600091F  System.Byte BGetPrecUI8(System.UInt64 dwlVal)
  RVA=0x097EF684  token=0x6000920  System.Void AddULong(System.UInt32 ulAdd)
  RVA=0x097F1804  token=0x6000921  System.Void MultByULong(System.UInt32 uiMultiplier)
  RVA=0x097F06BC  token=0x6000922  System.UInt32 DivByULong(System.UInt32 iDivisor)
  RVA=0x097EF884  token=0x6000923  System.Void AdjustScale(System.Int32 digits, System.Boolean fRound)
  RVA=0x097F0C40  token=0x6000924  System.Int32 LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp)
  RVA=0x097F1690  token=0x6000925  System.Void MpMove(System.UInt32[] rgulS, System.Int32 ciulS, System.UInt32[] rgulD, System.Int32& ciulD)
  RVA=0x097F17D8  token=0x6000926  System.Void MpSet(System.UInt32[] rgulD, System.Int32& ciulD, System.UInt32 iulN)
  RVA=0x097F17A0  token=0x6000927  System.Void MpNormalize(System.UInt32[] rgulU, System.Int32& ciulU)
  RVA=0x097F16E0  token=0x6000928  System.Void MpMul1(System.UInt32[] piulD, System.Int32& ciulD, System.UInt32 iulX)
  RVA=0x097F0E24  token=0x6000929  System.Void MpDiv1(System.UInt32[] rgulU, System.Int32& ciulU, System.UInt32 iulD, System.UInt32& iulR)
  RVA=0x03D75500  token=0x600092A  System.UInt64 DWL(System.UInt32 lo, System.UInt32 hi)
  RVA=0x03D68B20  token=0x600092B  System.UInt32 HI(System.UInt64 x)
  RVA=0x03D517B0  token=0x600092C  System.UInt32 LO(System.UInt64 x)
  RVA=0x097F0EFC  token=0x600092D  System.Void MpDiv(System.UInt32[] rgulU, System.Int32 ciulU, System.UInt32[] rgulD, System.Int32 ciulD, System.UInt32[] rgulQ, System.Int32& ciulQ, System.UInt32[] rgulR, System.Int32& ciulR)
  RVA=0x097F01CC  token=0x600092E  System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp)
  RVA=0x097F00FC  token=0x600092F  System.Void CheckValidPrecScale(System.Byte bPrec, System.Byte bScale)
  RVA=0x097F4628  token=0x6000930  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F4BF8  token=0x6000931  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F46F4  token=0x6000932  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F0DB0  token=0x6000933  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F0BCC  token=0x6000934  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  RVA=0x097F2654  token=0x6000935  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097F26CC  token=0x6000936  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  RVA=0x097F2744  token=0x6000937  System.Data.SqlTypes.SqlMoney ToSqlMoney()
  RVA=0x03D754F0  token=0x6000938  System.Char ChFromDigit(System.UInt32 uiDigit)
  RVA=0x097F20E4  token=0x6000939  System.Void StoreFromWorkingArray(System.UInt32[] rguiData)
  RVA=0x097F2080  token=0x600093A  System.Void SetToZero()
  RVA=0x097F05B4  token=0x600093B  System.Int32 CompareTo(System.Object value)
  RVA=0x097F0444  token=0x600093C  System.Int32 CompareTo(System.Data.SqlTypes.SqlDecimal value)
  RVA=0x097F0864  token=0x600093D  System.Boolean Equals(System.Object value)
  RVA=0x097F0A48  token=0x600093E  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x600093F  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097F2130  token=0x6000940  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097F2290  token=0x6000941  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F0B54  token=0x6000942  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097F2CB0  token=0x6000943  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlDouble
TYPE:  sealed struct
TOKEN: 0x20000A6
SIZE:  0x20
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Double                   m_value  // 0x18
  public    static readonly System.Data.SqlTypes.SqlDouble  Null  // static @ 0x0
  public    static readonly System.Data.SqlTypes.SqlDouble  Zero  // static @ 0x10
  public    static readonly System.Data.SqlTypes.SqlDouble  MinValue  // static @ 0x20
  public    static readonly System.Data.SqlTypes.SqlDouble  MaxValue  // static @ 0x30
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097F60B4
METHODS:
  RVA=0x03D75510  token=0x6000944  System.Void .ctor(System.Boolean fNull)
  RVA=0x097F6028  token=0x6000945  System.Void .ctor(System.Double value)
  RVA=0x097F66DC  token=0x6000948  System.Data.SqlTypes.SqlDouble op_Implicit(System.Double x)
  RVA=0x097F5EF0  token=0x6000949  System.String ToString()
  RVA=0x097F6C84  token=0x600094A  System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x)
  RVA=0x097F6110  token=0x600094B  System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F6B6C  token=0x600094C  System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F6A54  token=0x600094D  System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F6228  token=0x600094E  System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F690C  token=0x600094F  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097F685C  token=0x6000950  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097F66FC  token=0x6000951  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097F64DC  token=0x6000952  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097F67AC  token=0x6000953  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x)
  RVA=0x097F6638  token=0x6000954  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x)
  RVA=0x097F6588  token=0x6000955  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x)
  RVA=0x097F63A4  token=0x6000956  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F69C0  token=0x6000957  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F6448  token=0x6000958  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F5C50  token=0x6000959  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F5BE8  token=0x600095A  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  RVA=0x097F5E90  token=0x600095B  System.Data.SqlTypes.SqlSingle ToSqlSingle()
  RVA=0x097F57C0  token=0x600095C  System.Int32 CompareTo(System.Object value)
  RVA=0x097F58C0  token=0x600095D  System.Int32 CompareTo(System.Data.SqlTypes.SqlDouble value)
  RVA=0x097F59F8  token=0x600095E  System.Boolean Equals(System.Object value)
  RVA=0x097F5B08  token=0x600095F  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000960  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097F5CB8  token=0x6000961  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097F5D94  token=0x6000962  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F5B70  token=0x6000963  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097F5F48  token=0x6000964  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlGuid
TYPE:  sealed struct
TOKEN: 0x20000A7
SIZE:  0x18
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private   static readonly System.Int32                    s_sizeOfGuid  // static @ 0x0
  private   static readonly System.Int32[]                  s_rgiGuidOrder  // static @ 0x8
  private           System.Byte[]                   m_value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlGuid    Null  // static @ 0x10
PROPERTIES:
  IsNull  get=0x02361C20
  Value  get=0x097F756C
METHODS:
  RVA=0x0426F744  token=0x6000965  System.Void .ctor(System.Boolean fNull)
  RVA=0x097F7544  token=0x6000966  System.Void .ctor(System.Guid g)
  RVA=0x097F7760  token=0x6000969  System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x)
  RVA=0x097F73F4  token=0x600096A  System.String ToString()
  RVA=0x097F6EFC  token=0x600096B  System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  RVA=0x097F7610  token=0x600096C  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  RVA=0x097F7794  token=0x600096D  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  RVA=0x097F76B8  token=0x600096E  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  RVA=0x097F6D10  token=0x600096F  System.Int32 CompareTo(System.Object value)
  RVA=0x097F6E00  token=0x6000970  System.Int32 CompareTo(System.Data.SqlTypes.SqlGuid value)
  RVA=0x097F6FF4  token=0x6000971  System.Boolean Equals(System.Object value)
  RVA=0x097F70EC  token=0x6000972  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000973  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097F71E4  token=0x6000974  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097F72DC  token=0x6000975  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F716C  token=0x6000976  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097F7460  token=0x6000977  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt16
TYPE:  sealed struct
TOKEN: 0x20000A8
SIZE:  0x14
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int16                    m_value  // 0x12
  private   static readonly System.Int32                    s_MASKI2  // static @ 0x0
  public    static readonly System.Data.SqlTypes.SqlInt16   Null  // static @ 0x4
  public    static readonly System.Data.SqlTypes.SqlInt16   Zero  // static @ 0x8
  public    static readonly System.Data.SqlTypes.SqlInt16   MinValue  // static @ 0xc
  public    static readonly System.Data.SqlTypes.SqlInt16   MaxValue  // static @ 0x10
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097F8030
METHODS:
  RVA=0x03D75520  token=0x6000978  System.Void .ctor(System.Boolean fNull)
  RVA=0x03D68620  token=0x6000979  System.Void .ctor(System.Int16 value)
  RVA=0x03D75530  token=0x600097C  System.Data.SqlTypes.SqlInt16 op_Implicit(System.Int16 x)
  RVA=0x097F7F20  token=0x600097D  System.String ToString()
  RVA=0x097F8878  token=0x600097E  System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097F808C  token=0x600097F  System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F8778  token=0x6000980  System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F8648  token=0x6000981  System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F818C  token=0x6000982  System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F8518  token=0x6000983  System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097F8380  token=0x6000984  System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097F82E8  token=0x6000985  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F85B0  token=0x6000986  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F8480  token=0x6000987  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F7C3C  token=0x6000988  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F7BE4  token=0x6000989  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  RVA=0x097F7E60  token=0x600098A  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097F7EC0  token=0x600098B  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  RVA=0x097F7838  token=0x600098C  System.Int32 CompareTo(System.Object value)
  RVA=0x097F7924  token=0x600098D  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt16 value)
  RVA=0x097F7A14  token=0x600098E  System.Boolean Equals(System.Object value)
  RVA=0x097F7B08  token=0x600098F  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000990  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097F7C94  token=0x6000991  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097F7D70  token=0x6000992  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F7B6C  token=0x6000993  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097F7F78  token=0x6000994  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt32
TYPE:  sealed struct
TOKEN: 0x20000A9
SIZE:  0x18
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int32                    m_value  // 0x14
  private   static readonly System.Int64                    s_iIntMin  // static @ 0x0
  private   static readonly System.Int64                    s_lBitNotIntMax  // static @ 0x8
  public    static readonly System.Data.SqlTypes.SqlInt32   Null  // static @ 0x10
  public    static readonly System.Data.SqlTypes.SqlInt32   Zero  // static @ 0x18
  public    static readonly System.Data.SqlTypes.SqlInt32   MinValue  // static @ 0x20
  public    static readonly System.Data.SqlTypes.SqlInt32   MaxValue  // static @ 0x28
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097F9128
METHODS:
  RVA=0x03D75550  token=0x6000995  System.Void .ctor(System.Boolean fNull)
  RVA=0x03D68530  token=0x6000996  System.Void .ctor(System.Int32 value)
  RVA=0x03D75560  token=0x6000999  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Int32 x)
  RVA=0x097F8FFC  token=0x600099A  System.String ToString()
  RVA=0x097F9AAC  token=0x600099B  System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097F91AC  token=0x600099C  System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F998C  token=0x600099D  System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F9850  token=0x600099E  System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F92D0  token=0x600099F  System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F9680  token=0x60009A0  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097F971C  token=0x60009A1  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097F94E0  token=0x60009A2  System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097F8D60  token=0x60009A3  System.Boolean SameSignInt(System.Int32 x, System.Int32 y)
  RVA=0x097F9444  token=0x60009A4  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F97B4  token=0x60009A5  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F95E4  token=0x60009A6  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F8D04  token=0x60009A7  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F8CA8  token=0x60009A8  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  RVA=0x097F8F3C  token=0x60009A9  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097F8F9C  token=0x60009AA  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  RVA=0x097F89EC  token=0x60009AB  System.Int32 CompareTo(System.Object value)
  RVA=0x097F88F0  token=0x60009AC  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt32 value)
  RVA=0x097F8ADC  token=0x60009AD  System.Boolean Equals(System.Object value)
  RVA=0x097F8BD4  token=0x60009AE  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x60009AF  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097F8D70  token=0x60009B0  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097F8E4C  token=0x60009B1  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F8C30  token=0x60009B2  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097F9054  token=0x60009B3  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt64
TYPE:  sealed struct
TOKEN: 0x20000AA
SIZE:  0x20
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int64                    m_value  // 0x18
  private   static readonly System.Int64                    s_lLowIntMask  // static @ 0x0
  private   static readonly System.Int64                    s_lHighIntMask  // static @ 0x8
  public    static readonly System.Data.SqlTypes.SqlInt64   Null  // static @ 0x10
  public    static readonly System.Data.SqlTypes.SqlInt64   Zero  // static @ 0x20
  public    static readonly System.Data.SqlTypes.SqlInt64   MinValue  // static @ 0x30
  public    static readonly System.Data.SqlTypes.SqlInt64   MaxValue  // static @ 0x40
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097FA550
METHODS:
  RVA=0x03D75510  token=0x60009B4  System.Void .ctor(System.Boolean fNull)
  RVA=0x03D68540  token=0x60009B5  System.Void .ctor(System.Int64 value)
  RVA=0x03D75580  token=0x60009B8  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Int64 x)
  RVA=0x097FA404  token=0x60009B9  System.String ToString()
  RVA=0x097FB3DC  token=0x60009BA  System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097FA5AC  token=0x60009BB  System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FB2A8  token=0x60009BC  System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FAF98  token=0x60009BD  System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FA6E0  token=0x60009BE  System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FAE30  token=0x60009BF  System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FACF4  token=0x60009C0  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097FAC4C  token=0x60009C1  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097FABA4  token=0x60009C2  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097FA8DC  token=0x60009C3  System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x)
  RVA=0x097FA018  token=0x60009C4  System.Boolean SameSignLong(System.Int64 x, System.Int64 y)
  RVA=0x097FA848  token=0x60009C5  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FAD9C  token=0x60009C6  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FAB10  token=0x60009C7  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097F9FB0  token=0x60009C8  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097F9F48  token=0x60009C9  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  RVA=0x097FA1F8  token=0x60009CA  System.Data.SqlTypes.SqlByte ToSqlByte()
  RVA=0x097FA2D0  token=0x60009CB  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097FA344  token=0x60009CC  System.Data.SqlTypes.SqlInt16 ToSqlInt16()
  RVA=0x097FA3A4  token=0x60009CD  System.Data.SqlTypes.SqlInt32 ToSqlInt32()
  RVA=0x097FA258  token=0x60009CE  System.Data.SqlTypes.SqlDecimal ToSqlDecimal()
  RVA=0x097F9C60  token=0x60009CF  System.Int32 CompareTo(System.Object value)
  RVA=0x097F9B28  token=0x60009D0  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt64 value)
  RVA=0x097F9D60  token=0x60009D1  System.Boolean Equals(System.Object value)
  RVA=0x097F9E70  token=0x60009D2  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x60009D3  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097FA02C  token=0x60009D4  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097FA108  token=0x60009D5  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097F9ED0  token=0x60009D6  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097FA45C  token=0x60009D7  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlMoney
TYPE:  sealed struct
TOKEN: 0x20000AB
SIZE:  0x20
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  _fNotNull  // 0x10
  private           System.Int64                    _value  // 0x18
  private   static readonly System.Int32                    s_iMoneyScale  // static @ 0x0
  private   static readonly System.Int64                    s_lTickBase  // static @ 0x8
  private   static readonly System.Double                   s_dTickBase  // static @ 0x10
  private   static readonly System.Int64                    s_minLong  // static @ 0x18
  private   static readonly System.Int64                    s_maxLong  // static @ 0x20
  public    static readonly System.Data.SqlTypes.SqlMoney   Null  // static @ 0x28
  public    static readonly System.Data.SqlTypes.SqlMoney   Zero  // static @ 0x38
  public    static readonly System.Data.SqlTypes.SqlMoney   MinValue  // static @ 0x48
  public    static readonly System.Data.SqlTypes.SqlMoney   MaxValue  // static @ 0x58
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097FC2FC
METHODS:
  RVA=0x03D75510  token=0x60009D8  System.Void .ctor(System.Boolean fNull)
  RVA=0x03D68540  token=0x60009D9  System.Void .ctor(System.Int64 value, System.Int32 ignored)
  RVA=0x097FC0D0  token=0x60009DA  System.Void .ctor(System.Int32 value)
  RVA=0x097FBFEC  token=0x60009DB  System.Void .ctor(System.Int64 value)
  RVA=0x097FC130  token=0x60009DC  System.Void .ctor(System.Decimal value)
  RVA=0x097FBB88  token=0x60009DF  System.Decimal ToDecimal()
  RVA=0x097FBC84  token=0x60009E0  System.Double ToDouble()
  RVA=0x097FC908  token=0x60009E1  System.Data.SqlTypes.SqlMoney op_Implicit(System.Decimal x)
  RVA=0x097FCA90  token=0x60009E2  System.Data.SqlTypes.SqlMoney op_Implicit(System.Int64 x)
  RVA=0x097FBDF0  token=0x60009E3  System.String ToString()
  RVA=0x097FCEE0  token=0x60009E4  System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x)
  RVA=0x097FC3A4  token=0x60009E5  System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FCD4C  token=0x60009E6  System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FCC14  token=0x60009E7  System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FC53C  token=0x60009E8  System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FC9E4  token=0x60009E9  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097FC85C  token=0x60009EA  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097FC938  token=0x60009EB  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097FCAD8  token=0x60009EC  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097FC708  token=0x60009ED  System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x)
  RVA=0x097FC674  token=0x60009EE  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FCB80  token=0x60009EF  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FC7C8  token=0x60009F0  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FB8D4  token=0x60009F1  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FB86C  token=0x60009F2  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  RVA=0x097FBD7C  token=0x60009F3  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097FBD04  token=0x60009F4  System.Data.SqlTypes.SqlDecimal ToSqlDecimal()
  RVA=0x097FB598  token=0x60009F5  System.Int32 CompareTo(System.Object value)
  RVA=0x097FB460  token=0x60009F6  System.Int32 CompareTo(System.Data.SqlTypes.SqlMoney value)
  RVA=0x097FB698  token=0x60009F7  System.Boolean Equals(System.Object value)
  RVA=0x097FB7A8  token=0x60009F8  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x60009F9  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097FB93C  token=0x60009FA  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097FBA6C  token=0x60009FB  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097FB7F4  token=0x60009FC  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097FBE98  token=0x60009FD  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlSingle
TYPE:  sealed struct
TOKEN: 0x20000AC
SIZE:  0x18
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.Boolean                  _fNotNull  // 0x10
  private           System.Single                   _value  // 0x14
  public    static readonly System.Data.SqlTypes.SqlSingle  Null  // static @ 0x0
  public    static readonly System.Data.SqlTypes.SqlSingle  Zero  // static @ 0x8
  public    static readonly System.Data.SqlTypes.SqlSingle  MinValue  // static @ 0x10
  public    static readonly System.Data.SqlTypes.SqlSingle  MaxValue  // static @ 0x18
PROPERTIES:
  IsNull  get=0x080712C4
  Value  get=0x097FD9F4
METHODS:
  RVA=0x03D75550  token=0x60009FE  System.Void .ctor(System.Boolean fNull)
  RVA=0x097FD968  token=0x60009FF  System.Void .ctor(System.Single value)
  RVA=0x097FD910  token=0x6000A00  System.Void .ctor(System.Double value)
  RVA=0x097FE1E4  token=0x6000A03  System.Data.SqlTypes.SqlSingle op_Implicit(System.Single x)
  RVA=0x097FD7E0  token=0x6000A04  System.String ToString()
  RVA=0x097FE580  token=0x6000A05  System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x)
  RVA=0x097FDA50  token=0x6000A06  System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FE468  token=0x6000A07  System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FE350  token=0x6000A08  System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FDB68  token=0x6000A09  System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FE140  token=0x6000A0A  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x)
  RVA=0x097FE0A0  token=0x6000A0B  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  RVA=0x097FE20C  token=0x6000A0C  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  RVA=0x097FE000  token=0x6000A0D  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  RVA=0x097FDEC4  token=0x6000A0E  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x)
  RVA=0x097FDF5C  token=0x6000A0F  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x)
  RVA=0x097FDD8C  token=0x6000A10  System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x)
  RVA=0x097FDCE0  token=0x6000A11  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FE2B0  token=0x6000A12  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FDE24  token=0x6000A13  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FD54C  token=0x6000A14  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FD4F0  token=0x6000A15  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  RVA=0x097FD780  token=0x6000A16  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  RVA=0x097FD228  token=0x6000A17  System.Int32 CompareTo(System.Object value)
  RVA=0x097FD12C  token=0x6000A18  System.Int32 CompareTo(System.Data.SqlTypes.SqlSingle value)
  RVA=0x097FD318  token=0x6000A19  System.Boolean Equals(System.Object value)
  RVA=0x097FD410  token=0x6000A1A  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000A1B  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097FD5A8  token=0x6000A1C  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097FD684  token=0x6000A1D  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097FD478  token=0x6000A1E  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097FD838  token=0x6000A1F  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlCompareOptions
TYPE:  sealed struct
TOKEN: 0x20000AD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.SqlCompareOptionsNone  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreCase  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreNonSpace  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreKanaType  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreWidth  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsBinarySort  // const
  public    static  System.Data.SqlTypes.SqlCompareOptionsBinarySort2  // const
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlString
TYPE:  sealed struct
TOKEN: 0x20000AE
SIZE:  0x30
IMPLEMENTS: System.Data.SqlTypes.INullable System.IComparable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private           System.String                   m_value  // 0x10
  private           System.Globalization.CompareInfom_cmpInfo  // 0x18
  private           System.Int32                    m_lcid  // 0x20
  private           System.Data.SqlTypes.SqlCompareOptionsm_flag  // 0x24
  private           System.Boolean                  m_fNotNull  // 0x28
  public    static readonly System.Data.SqlTypes.SqlString  Null  // static @ 0x0
  private   static readonly System.Text.UnicodeEncoding     s_unicodeEncoding  // static @ 0x20
  public    static readonly System.Int32                    IgnoreCase  // static @ 0x28
  public    static readonly System.Int32                    IgnoreWidth  // static @ 0x2c
  public    static readonly System.Int32                    IgnoreNonSpace  // static @ 0x30
  public    static readonly System.Int32                    IgnoreKanaType  // static @ 0x34
  public    static readonly System.Int32                    BinarySort  // static @ 0x38
  public    static readonly System.Int32                    BinarySort2  // static @ 0x3c
  private   static readonly System.Data.SqlTypes.SqlCompareOptionss_iDefaultFlag  // static @ 0x40
  private   static readonly System.Globalization.CompareOptionss_iValidCompareOptionMask  // static @ 0x44
  private   static readonly System.Data.SqlTypes.SqlCompareOptionss_iValidSqlCompareOptionMask  // static @ 0x48
  private   static readonly System.Int32                    s_lcidUSEnglish  // static @ 0x4c
  private   static readonly System.Int32                    s_lcidBinary  // static @ 0x50
PROPERTIES:
  IsNull  get=0x03D032E0
  Value  get=0x097FFA4C
METHODS:
  RVA=0x097FFA20  token=0x6000A20  System.Void .ctor(System.Boolean fNull)
  RVA=0x097FF840  token=0x6000A21  System.Void .ctor(System.String data, System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions)
  RVA=0x097FF8D0  token=0x6000A22  System.Void .ctor(System.String data)
  RVA=0x097FF970  token=0x6000A23  System.Void .ctor(System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.String data, System.Globalization.CompareInfo cmpInfo)
  RVA=0x097FF0C4  token=0x6000A26  System.Void SetCompareInfo()
  RVA=0x097FFCC4  token=0x6000A27  System.Data.SqlTypes.SqlString op_Implicit(System.String x)
  RVA=0x097FF598  token=0x6000A28  System.String ToString()
  RVA=0x097FFAD0  token=0x6000A29  System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  RVA=0x097FF13C  token=0x6000A2A  System.Int32 StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  RVA=0x097FEBAC  token=0x6000A2B  System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult)
  RVA=0x097FFC48  token=0x6000A2C  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  RVA=0x097FF5E4  token=0x6000A2D  System.Void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions)
  RVA=0x097FE90C  token=0x6000A2E  System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions)
  RVA=0x097FEE14  token=0x6000A2F  System.Boolean FBinarySort()
  RVA=0x097FE74C  token=0x6000A30  System.Int32 CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  RVA=0x097FE604  token=0x6000A31  System.Int32 CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  RVA=0x097FE9C0  token=0x6000A32  System.Int32 CompareTo(System.Object value)
  RVA=0x097FEAD4  token=0x6000A33  System.Int32 CompareTo(System.Data.SqlTypes.SqlString value)
  RVA=0x097FECC0  token=0x6000A34  System.Boolean Equals(System.Object value)
  RVA=0x097FEE60  token=0x6000A35  System.Int32 GetHashCode()
  RVA=0x01002730  token=0x6000A36  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x097FF400  token=0x6000A37  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  RVA=0x097FF4CC  token=0x6000A38  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x097FF04C  token=0x6000A39  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x097FF688  token=0x6000A3A  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.EComparison
TYPE:  sealed struct
TOKEN: 0x20000AF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.EComparisonLT  // const
  public    static  System.Data.SqlTypes.EComparisonLE  // const
  public    static  System.Data.SqlTypes.EComparisonEQ  // const
  public    static  System.Data.SqlTypes.EComparisonGE  // const
  public    static  System.Data.SqlTypes.EComparisonGT  // const
  public    static  System.Data.SqlTypes.EComparisonNE  // const
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlTypeException
TYPE:  class
TOKEN: 0x20000B0
SIZE:  0x90
EXTENDS: System.SystemException
FIELDS:
METHODS:
  RVA=0x097FFF44  token=0x6000A3B  System.Void .ctor()
  RVA=0x097FFF38  token=0x6000A3C  System.Void .ctor(System.String message)
  RVA=0x097FFF18  token=0x6000A3D  System.Void .ctor(System.String message, System.Exception e)
  RVA=0x097FFF84  token=0x6000A3E  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  RVA=0x097FFE54  token=0x6000A3F  System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlNullValueException
TYPE:  sealed class
TOKEN: 0x20000B1
SIZE:  0x90
EXTENDS: System.Data.SqlTypes.SqlTypeException
FIELDS:
METHODS:
  RVA=0x097FD084  token=0x6000A40  System.Void .ctor()
  RVA=0x097FD120  token=0x6000A41  System.Void .ctor(System.String message)
  RVA=0x097FD0AC  token=0x6000A42  System.Void .ctor(System.String message, System.Exception e)
  RVA=0x097FD0CC  token=0x6000A43  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  RVA=0x097FCFC0  token=0x6000A44  System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlTruncateException
TYPE:  sealed class
TOKEN: 0x20000B2
SIZE:  0x90
EXTENDS: System.Data.SqlTypes.SqlTypeException
FIELDS:
METHODS:
  RVA=0x097FFDCC  token=0x6000A45  System.Void .ctor()
  RVA=0x097FFE48  token=0x6000A46  System.Void .ctor(System.String message)
  RVA=0x097FFDAC  token=0x6000A47  System.Void .ctor(System.String message, System.Exception e)
  RVA=0x097FFDF4  token=0x6000A48  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  RVA=0x097FFCE8  token=0x6000A49  System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlStreamChars
TYPE:  abstract class
TOKEN: 0x20000B3
SIZE:  0x10
FIELDS:
PROPERTIES:
  Length  get=-1  // abstract
  Position  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000A4C  System.Int32 Read(System.Char[] buffer, System.Int32 offset, System.Int32 count)
  RVA=-1  // abstract  token=0x6000A4D  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
END_CLASS

CLASS: System.Data.SqlTypes.SqlXml
TYPE:  sealed class
TOKEN: 0x20000B4
SIZE:  0x30
IMPLEMENTS: System.Data.SqlTypes.INullable System.Xml.Serialization.IXmlSerializable
FIELDS:
  private   static readonly System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader>s_sqlReaderDelegate  // static @ 0x0
  private   static readonly System.Xml.XmlReaderSettings    s_defaultXmlReaderSettings  // static @ 0x8
  private   static readonly System.Xml.XmlReaderSettings    s_defaultXmlReaderSettingsCloseInput  // static @ 0x10
  private   static  System.Reflection.MethodInfo    s_createSqlReaderMethodInfo  // static @ 0x18
  private           System.Reflection.MethodInfo    _createSqlReaderMethodInfo  // 0x10
  private           System.Boolean                  _fNotNull  // 0x18
  private           System.IO.Stream                _stream  // 0x20
  private           System.Boolean                  _firstCreateReader  // 0x28
PROPERTIES:
  CreateSqlReaderMethodInfo  get=0x09801604
  IsNull  get=0x03D032E0
METHODS:
  RVA=0x098015FC  token=0x6000A4E  System.Void .ctor()
  RVA=0x09800E08  token=0x6000A4F  System.Xml.XmlReader CreateReader()
  RVA=0x09801004  token=0x6000A50  System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, System.Boolean closeInput, System.Boolean throwTargetInvocationExceptions)
  RVA=0x09800F50  token=0x6000A51  System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate()
  RVA=0x09801204  token=0x6000A54  System.Void SetNull()
  RVA=0x01002730  token=0x6000A55  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  RVA=0x0980122C  token=0x6000A56  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  RVA=0x098013C8  token=0x6000A57  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  RVA=0x0980118C  token=0x6000A58  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  RVA=0x098014D4  token=0x6000A59  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlXmlStreamWrapper
TYPE:  sealed class
TOKEN: 0x20000B5
SIZE:  0x40
EXTENDS: System.IO.Stream
FIELDS:
  private           System.IO.Stream                _stream  // 0x28
  private           System.Int64                    _lPosition  // 0x30
  private           System.Boolean                  _isClosed  // 0x38
PROPERTIES:
  CanRead  get=0x09800BD4
  CanSeek  get=0x09800C0C
  CanWrite  get=0x09800C44
  Length  get=0x09800C7C
  Position  get=0x09800CE4  set=0x09800D38
METHODS:
  RVA=0x09800B78  token=0x6000A5A  System.Void .ctor(System.IO.Stream stream)
  RVA=0x098003CC  token=0x6000A61  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  RVA=0x098001B4  token=0x6000A62  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  RVA=0x09800964  token=0x6000A63  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  RVA=0x098000B4  token=0x6000A64  System.Int32 ReadByte()
  RVA=0x0980089C  token=0x6000A65  System.Void WriteByte(System.Byte value)
  RVA=0x09800614  token=0x6000A66  System.Void SetLength(System.Int64 value)
  RVA=0x0980002C  token=0x6000A67  System.Void Flush()
  RVA=0x097FFFD8  token=0x6000A68  System.Void Dispose(System.Boolean disposing)
  RVA=0x0980071C  token=0x6000A69  System.Void ThrowIfStreamCannotSeek(System.String method)
  RVA=0x09800698  token=0x6000A6A  System.Void ThrowIfStreamCannotRead(System.String method)
  RVA=0x098007A0  token=0x6000A6B  System.Void ThrowIfStreamCannotWrite(System.String method)
  RVA=0x09800824  token=0x6000A6C  System.Void ThrowIfStreamClosed(System.String method)
  RVA=0x09800048  token=0x6000A6D  System.Boolean IsStreamClosed()
END_CLASS

