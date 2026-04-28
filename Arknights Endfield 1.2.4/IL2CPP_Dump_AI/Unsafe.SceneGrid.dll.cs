// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.SceneGrid.dll
// Classes:  26
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

CLASS: FDictionaryEnumerator
TYPE:  sealed struct
TOKEN: 0x200000B
FIELDS:
  public            Beyond.Gameplay.Core.FDictionary4<Tk,Tv>*ptr  // 0x0
  private           System.Int32                    m_pos  // 0x0
PROPERTIES:
  Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000013  System.Void .ctor(Beyond.Gameplay.Core.FDictionary4<Tk,Tv>* initPtr)
  RVA=-1  // not resolved  token=0x6000014  System.Boolean MoveNext()
END_CLASS

CLASS: FDictionaryEnumerator
TYPE:  sealed struct
TOKEN: 0x200000D
FIELDS:
  public            Beyond.Gameplay.Core.FDictionary16<Tk,Tv>*ptr  // 0x0
  private           System.Int32                    m_pos  // 0x0
PROPERTIES:
  Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000020  System.Void .ctor(Beyond.Gameplay.Core.FDictionary16<Tk,Tv>* initPtr)
  RVA=-1  // not resolved  token=0x6000021  System.Boolean MoveNext()
END_CLASS

CLASS: Beyond.Gameplay.Core.FDictionary4`2
TYPE:  sealed struct
TOKEN: 0x200000A
FIELDS:
  public            Beyond.FArray4<Tk>              kArray  // 0x0
  public            Beyond.FArray4<Tv>              vArray  // 0x0
  public            System.UInt32                   bitArray  // 0x0
  public    static readonly System.Int32                    CAPACITY  // static @ 0x0
PROPERTIES:
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000009  Beyond.Gameplay.Core.FDictionary4.FDictionaryEnumerator<Tk,Tv> GetEnumerator()
  RVA=-1  // not resolved  token=0x600000A  System.Void .ctor(System.Int32 len)
  RVA=-1  // not resolved  token=0x600000B  System.Void SetBitEnable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x600000C  System.Void SetBitDisable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x600000D  System.Boolean IsBitEnable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x600000E  System.Boolean TryGetValue(Tk k, Tv& v)
  RVA=-1  // not resolved  token=0x600000F  System.Boolean TryRemove(Tk k)
  RVA=-1  // not resolved  token=0x6000012  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.FDictionary16`2
TYPE:  sealed struct
TOKEN: 0x200000C
FIELDS:
  public            Beyond.FArray16<Tk>             kArray  // 0x0
  public            Beyond.FArray16<Tv>             vArray  // 0x0
  public            System.UInt32                   bitArray  // 0x0
  public    static readonly System.Int32                    CAPACITY  // static @ 0x0
PROPERTIES:
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000016  Beyond.Gameplay.Core.FDictionary16.FDictionaryEnumerator<Tk,Tv> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000017  System.Void .ctor(System.Int32 len)
  RVA=-1  // not resolved  token=0x6000018  System.Void SetBitEnable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x6000019  System.Void SetBitDisable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x600001A  System.Boolean IsBitEnable(System.Int32 bit)
  RVA=-1  // not resolved  token=0x600001B  System.Boolean TryGetValue(Tk k, Tv& v)
  RVA=-1  // not resolved  token=0x600001C  System.Boolean TryRemove(Tk k)
  RVA=-1  // not resolved  token=0x600001F  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSetContextManager`1
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static  System.Int32                    ARRAY_CACHE_SIZE  // const
  private   static  System.Int32                    SEQ_SET_MAX  // const
  private   static  System.Int32                    INIT_SET_CAP  // const
  private   static  System.Int32                    MAX_SET_CAP  // const
  private   static  System.Int32                    INIT_MIN_CAP  // const
  public    static  System.Int32                    MAX_CONTENT_SIZE  // const
  public    readonly System.Int32                    minCapSize  // 0x0
  public    readonly System.Int32                    initContentSize  // 0x0
  public    readonly System.Int32                    freeListPointerSize  // 0x0
  private   readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T>[]m_setContexts  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Gameplay.Core.MemFriendSetContextBase<T>>m_setContextsMap  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000023  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000024  Beyond.Gameplay.Core.MemFriendSetContextBase<T> _GetContext(System.Int32 cap)
  RVA=-1  // not resolved  token=0x6000025  Beyond.Gameplay.Core.MemFriendSetContextBase<T> _CreateContext(System.Int32 cap)
  RVA=-1  // not resolved  token=0x6000026  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x6000027  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x6000028  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x6000029  Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // not resolved  token=0x600002A  System.Void AddToMonoSet(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.HashSet<T> monoSet)
  RVA=-1  // not resolved  token=0x600002B  System.Void AddToMonoList(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Collections.Generic.List<T> monoList)
  RVA=-1  // not resolved  token=0x600002C  Beyond.Gameplay.Core.MemFriendHashSet AllocateSet(System.Int32 cap)
  RVA=-1  // not resolved  token=0x600002D  System.Void Recycle(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // not resolved  token=0x600002E  System.Int32 GetContextSize(System.Int32 cap)
  RVA=-1  // not resolved  token=0x600002F  System.Void OnRelease()
END_CLASS

CLASS: Beyond.Gameplay.Core.PureEnumerator`1
TYPE:  sealed struct
TOKEN: 0x200000F
FIELDS:
  private           System.Int32                    m_index  // 0x0
  private           System.Int32                    m_validCnt  // 0x0
  private           Beyond.Gameplay.Core.MemFriendHashSetm_set  // 0x0
  private   readonly Beyond.Gameplay.Core.MemFriendSetContextBase<T>m_context  // 0x0
PROPERTIES:
  current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000031  System.Void .ctor(Beyond.Gameplay.Core.MemFriendHashSet set, Beyond.Gameplay.Core.MemFriendSetContextBase<T> context)
  RVA=-1  // not resolved  token=0x6000032  System.Boolean MoveNext()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendHashSet
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x20
FIELDS:
  public            System.Int32                    start  // 0x10
  public            System.Int32                    cap  // 0x14
  public            System.Int32                    count  // 0x18
  public            System.Int32                    bitStart  // 0x1c
METHODS:
  RVA=0x02A251A0  token=0x6000033  System.Void CopyFrom(Beyond.Gameplay.Core.MemFriendHashSet& other)
  RVA=0x02A243A0  token=0x6000034  System.Void Clear()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSetContextBase`1
TYPE:  abstract class
TOKEN: 0x2000011
IMPLEMENTS: System.IDisposable
FIELDS:
  protected         Unity.Collections.NativeArray<T>m_content  // 0x0
  protected readonly System.Int32                    m_singleElementSize  // 0x0
  public    static  System.Int32                    INVALID_CONTENT_INDEX  // const
  public    readonly System.Int32                    typeSize  // 0x0
  public    readonly System.Int32                    stride  // 0x0
  public    readonly Beyond.Gameplay.Core.MemFriendSetContextManager<T>contextManager  // 0x0
  private           System.Int32                    m_freeListHead  // 0x0
  private           System.Int32                    m_freeListTail  // 0x0
  private           System.Byte*                    m_ptr  // 0x0
  public            System.Int32                    currentCount  // 0x0
PROPERTIES:
  singleElementSize  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000036  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  RVA=-1  // not resolved  token=0x6000037  System.Void InitArrayFreeList(System.Int32 baseIndex, System.Int32 size)
  RVA=-1  // not resolved  token=0x6000038  System.Void _ReplaceWithNewCap(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 newCap)
  RVA=-1  // not resolved  token=0x6000039  System.Void _TryShrink(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // not resolved  token=0x600003A  System.Boolean _TryEnLarge(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x600003B  System.Void EnLarge()
  RVA=-1  // not resolved  token=0x600003C  Beyond.Gameplay.Core.MemFriendHashSet Allocate()
  RVA=-1  // not resolved  token=0x600003D  System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // not resolved  token=0x600003E  System.Void CopyFromAnother(Beyond.Gameplay.Core.MemFriendHashSet& desSet, Beyond.Gameplay.Core.MemFriendHashSet& srcSet)
  RVA=-1  // not resolved  token=0x600003F  T GetElement(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000040  System.Boolean IsEqual(System.Int32 index, T item)
  RVA=-1  // not resolved  token=0x6000041  System.Int32 GetHashCodeOfElement(T item)
  RVA=-1  // not resolved  token=0x6000042  Beyond.Gameplay.Core.PureEnumerator<T> GetEnumerator(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // abstract  token=0x6000043  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  RVA=-1  // abstract  token=0x6000044  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // abstract  token=0x6000045  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // abstract  token=0x6000046  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // abstract  token=0x6000047  System.Boolean ShouldEnLarge(System.Int32 count)
  RVA=-1  // not resolved  token=0x6000048  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Core.BitContext
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  public            Unity.Collections.NativeArray<System.Byte>bits  // 0x10
  public    static  System.Int32                    ONE_SLOT_BIT_NUM  // const
  public    static  System.Int32                    ONE_STATE_BIT_NUM  // const
  public    static  System.Int32                    ONE_SLOT_ELEMENT_NUM  // const
  public    static  System.Byte                     MASK  // const
  public    static  System.Byte                     FREE  // const
  public    static  System.Byte                     OCCUPIED  // const
  public    static  System.Byte                     USED  // const
  private   readonly System.Int32                    m_elementBitSlot  // 0x20
  private           System.Byte*                    m_ptr  // 0x28
METHODS:
  RVA=0x0370C650  token=0x6000049  System.Void .ctor(System.Int32 initSize, System.Int32 singleElementSize)
  RVA=0x0370C700  token=0x600004A  System.Int32 _ComputePropBitArrayLength(System.Int32 contentLength)
  RVA=0x09FA5CB8  token=0x600004B  System.Void EnLarge(System.Int32 contentSize)
  RVA=0x02514A80  token=0x600004C  System.Void Recycle(System.Int32 bitIndex)
  RVA=0x09FA5DAC  token=0x600004D  System.Int32 GetBitStartIndex(System.Int32 index)
  RVA=0x03D8A000  token=0x600004E  System.Void _CalculateBitIndexAndMask(System.Int32 bitStateStartIndex, System.Int32 index, System.Int32& finalIndex, System.Int32& offsetInternal)
  RVA=0x02A25060  token=0x600004F  System.Byte GetState(System.Int32 bitStateStartIndex, System.Int32 index)
  RVA=0x02A24CF0  token=0x6000050  System.Void SetState(System.Int32 bitStateStartIndex, System.Int32 index, System.Byte state)
  RVA=0x09FA5C2C  token=0x6000051  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendNormalSetContext`1
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Beyond.Gameplay.Core.MemFriendSetContextBase`1
FIELDS:
  private   readonly Beyond.Gameplay.Core.BitContext m_bitContext  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000052  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  RVA=-1  // not resolved  token=0x6000053  System.Void EnLarge()
  RVA=-1  // not resolved  token=0x6000054  System.Void Dispose()
  RVA=-1  // not resolved  token=0x6000055  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  RVA=-1  // not resolved  token=0x6000056  Beyond.Gameplay.Core.MemFriendHashSet Allocate()
  RVA=-1  // not resolved  token=0x6000057  System.Void Free(Beyond.Gameplay.Core.MemFriendHashSet& set)
  RVA=-1  // not resolved  token=0x6000058  System.Boolean ShouldEnLarge(System.Int32 count)
  RVA=-1  // not resolved  token=0x6000059  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x600005A  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x600005B  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
END_CLASS

CLASS: Beyond.Gameplay.Core.MemFriendSeqSetContext`1
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Beyond.Gameplay.Core.MemFriendSetContextBase`1
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x600005C  System.Void .ctor(Beyond.Gameplay.Core.MemFriendSetContextManager<T> contextManager, System.Int32 initSize, System.Int32 singleElementSize)
  RVA=-1  // not resolved  token=0x600005D  System.Int32 GetNextValidIndex(Beyond.Gameplay.Core.MemFriendHashSet& set, System.Int32 index, System.Int32 validCnt)
  RVA=-1  // not resolved  token=0x600005E  System.Boolean ShouldEnLarge(System.Int32 count)
  RVA=-1  // not resolved  token=0x600005F  System.Boolean Insert(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x6000060  System.Boolean Remove(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
  RVA=-1  // not resolved  token=0x6000061  System.Boolean Contains(Beyond.Gameplay.Core.MemFriendHashSet& set, T item)
END_CLASS

CLASS: Beyond.Gameplay.Core.GameplayUnsafeUtil
TYPE:  static class
TOKEN: 0x2000015
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000062  System.Byte[] NativeArrayToBytes(Unity.Collections.NativeArray<T> nativeArray)
  RVA=0x09FA5DB8  token=0x6000063  Unity.Collections.NativeArray<System.Byte> GetNativeArrayFromStream(System.IO.Stream stream)
END_CLASS

CLASS: Beyond.Gameplay.Core.SparseNativeArray`1
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           Unity.Collections.NativeArray<T>m_rawArray  // 0x0
  private           System.Int32                    m_currentCount  // 0x0
  private           System.Int32                    m_emptyStartPos  // 0x0
  private           System.Int32                    m_marker  // 0x0
  public    readonly System.Int32                    typeSize  // 0x0
  private           System.Byte*                    m_ptr  // 0x0
  private           T*                              m_validPtr  // 0x0
PROPERTIES:
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000064  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000065  System.Void Init(System.Int32 initCap)
  RVA=-1  // not resolved  token=0x6000066  System.Boolean IsEmpty()
  RVA=-1  // not resolved  token=0x6000067  T& ElementAt(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000068  System.Int32 InsertValue(T v)
  RVA=-1  // not resolved  token=0x6000069  System.Void Clear()
  RVA=-1  // not resolved  token=0x600006A  System.Int32 Allocate()
  RVA=-1  // not resolved  token=0x600006B  System.Void Remove(System.Int32 v)
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000005  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000007  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000008  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000003  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x600006E  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x09FA5EE8  token=0x600006F  System.Void __Gen_Wrap_0(Beyond.Gameplay.Core.MemFriendHashSet& P0, Beyond.Gameplay.Core.MemFriendHashSet& P1)
  RVA=0x09FA6080  token=0x6000070  System.Void __Gen_Wrap_1(Beyond.Gameplay.Core.MemFriendHashSet& P0)
  RVA=0x054761A8  token=0x6000071  System.Int32 __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  RVA=0x0549D548  token=0x6000072  System.Void __Gen_Wrap_3(System.Object P0, System.Int32 P1)
  RVA=0x05645B10  token=0x6000073  System.Byte __Gen_Wrap_4(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x09FA61B4  token=0x6000074  System.Void __Gen_Wrap_5(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte P3)
  RVA=0x050EE850  token=0x6000075  System.Void __Gen_Wrap_6(System.Object P0)
  RVA=0x09FA62BC  token=0x6000076  Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_7(System.Object P0)
  RVA=0x03D05870  token=0x6000077  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x40
EXTENDS: IFix.Core.AnonymousStorey
FIELDS:
METHODS:
  RVA=0x09FA63B4  token=0x6000078  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x6000079  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x600007A  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x09FA6630  token=0x600007B  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x02A25130  token=0x600007C  System.Boolean IsPatched(System.Int32 id)
  RVA=0x09FA64EC  token=0x600007D  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x09FA65B8  token=0x600007E  System.Object CreateWrapper(System.Int32 id)
  RVA=0x09FA6694  token=0x600007F  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x09FA6448  token=0x6000080  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-MemFriendHashSet-CopyFrom0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-MemFriendHashSet-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-_ComputePropBitArrayLength0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-EnLarge0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-Recycle0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-GetState0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-SetState0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-BitContext-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-GameplayUnsafeUtil-GetNativeArrayFromStream0  // const
METHODS:
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

