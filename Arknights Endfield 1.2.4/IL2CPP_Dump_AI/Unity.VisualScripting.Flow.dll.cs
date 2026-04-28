// ========================================================
// Dumped by @desirepro
// Assembly: Unity.VisualScripting.Flow.dll
// Classes:  54
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

CLASS: DebugData
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x30
EXTENDS: Unity.VisualScripting.UnitConnectionDebugData
FIELDS:
  private           System.Object                   <lastValue>k__BackingField  // 0x20
  private           System.Boolean                  <assignedLastValue>k__BackingField  // 0x28
PROPERTIES:
  lastValue  set=0x04271930
  assignedLastValue  set=0x03D4ED60
METHODS:
END_CLASS

CLASS: RecursionNode
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   readonly Unity.VisualScripting.IUnitPort <port>k__BackingField  // 0x10
  private   readonly Unity.VisualScripting.IGraphParent<context>k__BackingField  // 0x18
PROPERTIES:
  port  get=0x020C61B0
  context  get=0x03D50DE0
METHODS:
  RVA=0x09D7B60C  token=0x6000056  System.Void .ctor(Unity.VisualScripting.IUnitPort port, Unity.VisualScripting.GraphPointer pointer)
  RVA=0x09D7B5B4  token=0x6000057  System.Boolean Equals(Unity.VisualScripting.Flow.RecursionNode other)
  RVA=0x09D7B544  token=0x6000058  System.Boolean Equals(System.Object obj)
  RVA=0x09D7B5CC  token=0x6000059  System.Int32 GetHashCode()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.Flow.<>c  <>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.Flow><>9__35_0  // static @ 0x8
METHODS:
  RVA=0x09D7B820  token=0x600005A  System.Void .cctor()
  RVA=0x0350B670  token=0x600005B  System.Void .ctor()
  RVA=0x09D7B648  token=0x600005C  Unity.VisualScripting.Flow <New>b__35_0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001A
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.ControlInput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput><>9__14_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort><>9__16_0  // static @ 0x10
METHODS:
  RVA=0x09D7B7BC  token=0x6000081  System.Void .cctor()
  RVA=0x0350B670  token=0x6000082  System.Void .ctor()
  RVA=0x09D7B6D8  token=0x6000083  Unity.VisualScripting.ControlOutput <get_validConnectedPorts>b__14_0(Unity.VisualScripting.ControlConnection c)
  RVA=0x09D7B698  token=0x6000084  Unity.VisualScripting.IUnitOutputPort <get_invalidConnectedPorts>b__16_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass25_0
TYPE:  sealed class
TOKEN: 0x200001B
SIZE:  0x18
FIELDS:
  public            Unity.VisualScripting.ControlOutputport  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000085  System.Void .ctor()
  RVA=0x09D7B730  token=0x6000086  System.Boolean <DisconnectFromValid>b__0(Unity.VisualScripting.ControlConnection c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001D
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.ControlOutput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlInput><>9__6_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitInputPort><>9__8_0  // static @ 0x10
METHODS:
  RVA=0x09D7B884  token=0x6000093  System.Void .cctor()
  RVA=0x0350B670  token=0x6000094  System.Void .ctor()
  RVA=0x09D7B6F0  token=0x6000095  Unity.VisualScripting.ControlInput <get_validConnectedPorts>b__6_0(Unity.VisualScripting.ControlConnection c)
  RVA=0x09D7B6B8  token=0x6000096  Unity.VisualScripting.IUnitInputPort <get_invalidConnectedPorts>b__8_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass21_0
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x18
FIELDS:
  public            Unity.VisualScripting.ControlInputport  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000097  System.Void .ctor()
  RVA=0x09D7B708  token=0x6000098  System.Boolean <DisconnectFromValid>b__0(Unity.VisualScripting.ControlConnection c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.InvalidInput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort><>9__6_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort><>9__8_0  // static @ 0x10
METHODS:
  RVA=0x09D7B758  token=0x60000A3  System.Void .cctor()
  RVA=0x0350B670  token=0x60000A4  System.Void .ctor()
  RVA=0x09D7B698  token=0x60000A5  Unity.VisualScripting.IUnitOutputPort <get_validConnectedPorts>b__6_0(Unity.VisualScripting.InvalidConnection c)
  RVA=0x09D7B698  token=0x60000A6  Unity.VisualScripting.IUnitOutputPort <get_invalidConnectedPorts>b__8_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000022
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.InvalidOutput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitInputPort><>9__6_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitInputPort><>9__8_0  // static @ 0x10
METHODS:
  RVA=0x09D7B94C  token=0x60000B1  System.Void .cctor()
  RVA=0x0350B670  token=0x60000B2  System.Void .ctor()
  RVA=0x09D7B6B8  token=0x60000B3  Unity.VisualScripting.IUnitInputPort <get_validConnectedPorts>b__6_0(Unity.VisualScripting.InvalidConnection c)
  RVA=0x09D7B6B8  token=0x60000B4  Unity.VisualScripting.IUnitInputPort <get_invalidConnectedPorts>b__8_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass45_0
TYPE:  sealed class
TOKEN: 0x200002A
FIELDS:
  public            Unity.VisualScripting.IUnitOutputPortsource  // 0x0
  public            Unity.VisualScripting.IUnitInputPortdestination  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60000D4  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60000D5  System.Boolean <ConnectInvalid>b__0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass46_0
TYPE:  sealed class
TOKEN: 0x200002B
FIELDS:
  public            Unity.VisualScripting.IUnitOutputPortsource  // 0x0
  public            Unity.VisualScripting.IUnitInputPortdestination  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60000D6  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60000D7  System.Boolean <DisconnectInvalid>b__0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200002E
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.ValueInput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput><>9__11_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort><>9__13_0  // static @ 0x10
METHODS:
  RVA=0x09D7B9B0  token=0x60000F6  System.Void .cctor()
  RVA=0x0350B670  token=0x60000F7  System.Void .ctor()
  RVA=0x09D7B6D8  token=0x60000F8  Unity.VisualScripting.ValueOutput <get_validConnectedPorts>b__11_0(Unity.VisualScripting.ValueConnection c)
  RVA=0x09D7B698  token=0x60000F9  Unity.VisualScripting.IUnitOutputPort <get_invalidConnectedPorts>b__13_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass33_0
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x18
FIELDS:
  public            Unity.VisualScripting.ValueOutputport  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000FA  System.Void .ctor()
  RVA=0x09D7B730  token=0x60000FB  System.Boolean <DisconnectFromValid>b__0(Unity.VisualScripting.ValueConnection c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000031
SIZE:  0x10
FIELDS:
  public    static readonly Unity.VisualScripting.ValueOutput.<>c<>9  // static @ 0x0
  public    static  System.Func<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueInput><>9__16_0  // static @ 0x8
  public    static  System.Func<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitInputPort><>9__18_0  // static @ 0x10
METHODS:
  RVA=0x09D7B8E8  token=0x6000108  System.Void .cctor()
  RVA=0x0350B670  token=0x6000109  System.Void .ctor()
  RVA=0x09D7B6F0  token=0x600010A  Unity.VisualScripting.ValueInput <get_validConnectedPorts>b__16_0(Unity.VisualScripting.ValueConnection c)
  RVA=0x09D7B6B8  token=0x600010B  Unity.VisualScripting.IUnitInputPort <get_invalidConnectedPorts>b__18_0(Unity.VisualScripting.InvalidConnection c)
END_CLASS

CLASS: <>c__DisplayClass22_0
TYPE:  sealed class
TOKEN: 0x2000032
SIZE:  0x18
FIELDS:
  public            Unity.VisualScripting.ValueInputport  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600010C  System.Void .ctor()
  RVA=0x09D7B708  token=0x600010D  System.Boolean <DisconnectFromValid>b__0(Unity.VisualScripting.ValueConnection c)
END_CLASS

CLASS: <>c__DisplayClass86_0`1
TYPE:  sealed class
TOKEN: 0x2000034
FIELDS:
  public            System.Func<Unity.VisualScripting.Flow,T>getValue  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000128  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000129  System.Object <ValueOutput>b__0(Unity.VisualScripting.Flow recursion)
END_CLASS

CLASS: Unity.VisualScripting.ControlConnection
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x48
EXTENDS: Unity.VisualScripting.UnitConnection`2
IMPLEMENTS: Unity.VisualScripting.IUnitConnection Unity.VisualScripting.IConnection`2 Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
PROPERTIES:
  source  get=0x09D77E9C
  destination  get=0x09D77DC0
  Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source  get=0x09D77C80
  Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination  get=0x09D77C78
  sourceExists  get=0x09D77E28
  destinationExists  get=0x09D77D4C
METHODS:
  RVA=0x09D77C88  token=0x6000001  System.Void .ctor(Unity.VisualScripting.ControlOutput source, Unity.VisualScripting.ControlInput destination)
END_CLASS

CLASS: Unity.VisualScripting.InvalidConnection
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x48
EXTENDS: Unity.VisualScripting.UnitConnection`2
IMPLEMENTS: Unity.VisualScripting.IUnitConnection Unity.VisualScripting.IConnection`2 Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
PROPERTIES:
  source  get=0x09D7A87C
  destination  get=0x09D7A714
  validSource  get=0x09D7AB4C
  validDestination  get=0x09D7A9E4
  sourceExists  get=0x09D7A7C8
  destinationExists  get=0x09D7A660
  validSourceExists  get=0x09D7AA98
  validDestinationExists  get=0x09D7A930
METHODS:
  RVA=0x09D7A608  token=0x6000008  System.Void .ctor(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
  RVA=0x09D7A16C  token=0x6000011  System.Boolean HandleDependencies()
  RVA=0x09D7A450  token=0x6000012  System.Boolean <get_source>b__4_0(Unity.VisualScripting.IUnitOutputPort p)
  RVA=0x09D7A3A0  token=0x6000013  System.Boolean <get_destination>b__6_0(Unity.VisualScripting.IUnitInputPort p)
  RVA=0x09D7A5B0  token=0x6000014  System.Boolean <get_validSource>b__8_0(Unity.VisualScripting.IUnitOutputPort p)
  RVA=0x09D7A500  token=0x6000015  System.Boolean <get_validDestination>b__10_0(Unity.VisualScripting.IUnitInputPort p)
  RVA=0x09D7A3F8  token=0x6000016  System.Boolean <get_sourceExists>b__12_0(Unity.VisualScripting.IUnitOutputPort p)
  RVA=0x09D7A348  token=0x6000017  System.Boolean <get_destinationExists>b__14_0(Unity.VisualScripting.IUnitInputPort p)
  RVA=0x09D7A558  token=0x6000018  System.Boolean <get_validSourceExists>b__16_0(Unity.VisualScripting.IUnitOutputPort p)
  RVA=0x09D7A4A8  token=0x6000019  System.Boolean <get_validDestinationExists>b__18_0(Unity.VisualScripting.IUnitInputPort p)
END_CLASS

CLASS: Unity.VisualScripting.IUnitConnection
TYPE:  interface
TOKEN: 0x2000004
IMPLEMENTS: Unity.VisualScripting.IConnection`2 Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitConnectionDebugData
TYPE:  interface
TOKEN: 0x2000005
IMPLEMENTS: Unity.VisualScripting.IGraphElementDebugData
FIELDS:
PROPERTIES:
  lastInvokeFrame  set=-1  // abstract
  lastInvokeTime  set=-1  // abstract
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitRelation
TYPE:  interface
TOKEN: 0x2000006
IMPLEMENTS: Unity.VisualScripting.IConnection`2
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.UnitConnection`2
TYPE:  abstract class
TOKEN: 0x2000007
EXTENDS: Unity.VisualScripting.GraphElement`1
IMPLEMENTS: Unity.VisualScripting.IConnection`2
FIELDS:
  private           Unity.VisualScripting.IUnit     <sourceUnit>k__BackingField  // 0x0
  private           System.String                   <sourceKey>k__BackingField  // 0x0
  private           Unity.VisualScripting.IUnit     <destinationUnit>k__BackingField  // 0x0
  private           System.String                   <destinationKey>k__BackingField  // 0x0
PROPERTIES:
  sourceUnit  get=-1  // not resolved  set=-1  // not resolved
  sourceKey  get=-1  // not resolved  set=-1  // not resolved
  destinationUnit  get=-1  // not resolved  set=-1  // not resolved
  destinationKey  get=-1  // not resolved  set=-1  // not resolved
  source  get=-1  // abstract
  destination  get=-1  // abstract
  dependencyOrder  get=-1  // not resolved
  sourceExists  get=-1  // abstract
  destinationExists  get=-1  // abstract
METHODS:
  RVA=-1  // not resolved  token=0x600001C  System.Void .ctor(TSourcePort source, TDestinationPort destination)
  RVA=-1  // not resolved  token=0x600002A  System.Boolean HandleDependencies()
END_CLASS

CLASS: Unity.VisualScripting.UnitConnectionDebugData
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x20
IMPLEMENTS: Unity.VisualScripting.IUnitConnectionDebugData
FIELDS:
  private           System.Int32                    <lastInvokeFrame>k__BackingField  // 0x10
  private           System.Single                   <lastInvokeTime>k__BackingField  // 0x14
  private           System.Exception                <runtimeException>k__BackingField  // 0x18
PROPERTIES:
  lastInvokeFrame  set=0x010410F0
  lastInvokeTime  set=0x03D51940
  runtimeException  set=0x022C3A90
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.ValueConnection
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x48
EXTENDS: Unity.VisualScripting.UnitConnection`2
IMPLEMENTS: Unity.VisualScripting.IUnitConnection Unity.VisualScripting.IConnection`2 Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
PROPERTIES:
  source  get=0x09D7CC1C
  destination  get=0x09D7CB40
  Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source  get=0x09D77C80
  Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination  get=0x09D77C78
  sourceExists  get=0x09D7CBA8
  destinationExists  get=0x09D7CACC
METHODS:
  RVA=0x09D7C948  token=0x600002E  System.Void .ctor(Unity.VisualScripting.ValueOutput source, Unity.VisualScripting.ValueInput destination)
END_CLASS

CLASS: Unity.VisualScripting.PortLabelHiddenAttribute
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000037  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.SpecialUnitAttribute
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000038  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.UnitHeaderInspectableAttribute
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000039  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.UnitShortTitleAttribute
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <title>k__BackingField  // 0x10
PROPERTIES:
  title  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x600003A  System.Void .ctor(System.String title)
END_CLASS

CLASS: Unity.VisualScripting.UnitTitleAttribute
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <title>k__BackingField  // 0x10
PROPERTIES:
  title  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x600003C  System.Void .ctor(System.String title)
END_CLASS

CLASS: Unity.VisualScripting.Flow
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x68
IMPLEMENTS: Unity.VisualScripting.IPoolable System.IDisposable
FIELDS:
  private           Unity.VisualScripting.GraphStack<stack>k__BackingField  // 0x10
  private           Unity.VisualScripting.Recursion<Unity.VisualScripting.Flow.RecursionNode>recursion  // 0x18
  private   readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.IUnitValuePort,System.Object>locals  // 0x20
  public    readonly Unity.VisualScripting.VariableDeclarationsvariables  // 0x28
  private   readonly System.Collections.Generic.Stack<System.Int32>loops  // 0x30
  private   readonly System.Collections.Generic.HashSet<Unity.VisualScripting.GraphStack>preservedStacks  // 0x38
  private           UnityEngine.MonoBehaviour       <coroutineRunner>k__BackingField  // 0x40
  private           System.Collections.Generic.ICollection<Unity.VisualScripting.Flow>activeCoroutinesRegistry  // 0x48
  private           System.Boolean                  coroutineStopRequested  // 0x50
  private           System.Boolean                  <isCoroutine>k__BackingField  // 0x51
  private           System.Collections.IEnumerator  coroutineEnumerator  // 0x58
  private           System.Boolean                  <isPrediction>k__BackingField  // 0x60
  private           System.Boolean                  disposed  // 0x61
  public            System.Int32                    loopIdentifier  // 0x64
PROPERTIES:
  stack  get=0x020B7B20  set=0x0426FEE0
  coroutineRunner  set=0x03CB2D80
  isCoroutine  set=0x03D51900
  isPrediction  get=0x03D519A0  set=0x03D519B0
  enableDebug  get=0x09D7A13C
METHODS:
  RVA=0x09D79FF0  token=0x6000045  System.Void .ctor()
  RVA=0x09D799A4  token=0x6000046  Unity.VisualScripting.Flow New(Unity.VisualScripting.GraphReference reference)
  RVA=0x09D79FA8  token=0x6000047  System.Void Unity.VisualScripting.IPoolable.New()
  RVA=0x09D78E40  token=0x6000048  System.Void Dispose()
  RVA=0x09D79C04  token=0x6000049  System.Void Unity.VisualScripting.IPoolable.Free()
  RVA=0x09D797A8  token=0x600004A  System.Void Invoke(Unity.VisualScripting.ControlOutput output)
  RVA=0x09D78BF0  token=0x600004B  Unity.VisualScripting.Flow.RecursionNode BeforeInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode)
  RVA=0x09D78B9C  token=0x600004C  System.Void AfterInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode)
  RVA=0x09D79638  token=0x600004D  Unity.VisualScripting.ControlOutput InvokeDelegate(Unity.VisualScripting.ControlInput input)
  RVA=0x09D793CC  token=0x600004E  System.Object GetValue(Unity.VisualScripting.ValueInput input)
  RVA=0x09D78FDC  token=0x600004F  System.Object GetValue(Unity.VisualScripting.ValueOutput output)
  RVA=0x09D795C8  token=0x6000050  System.Object GetValue(Unity.VisualScripting.ValueInput input, System.Type type)
  RVA=-1  // generic def  token=0x6000051  T GetValue(Unity.VisualScripting.ValueInput input)
  RVA=0x09D79B44  token=0x6000052  System.Boolean TryGetDefaultValue(Unity.VisualScripting.ValueInput input, System.Object& defaultValue)
  RVA=0x09D78EF8  token=0x6000053  System.Object GetValueDelegate(Unity.VisualScripting.ValueOutput output)
END_CLASS

CLASS: Unity.VisualScripting.FlowGraph
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x38
EXTENDS: Unity.VisualScripting.Graph
IMPLEMENTS: Unity.VisualScripting.IGraph System.IDisposable Unity.VisualScripting.ISerializationDepender UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput,Unity.VisualScripting.ControlInput><controlConnections>k__BackingField  // 0x20
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput,Unity.VisualScripting.ValueInput><valueConnections>k__BackingField  // 0x28
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort><invalidConnections>k__BackingField  // 0x30
PROPERTIES:
  controlConnections  get=0x03D4EB40
  valueConnections  get=0x03D4EAC0
  invalidConnections  get=0x01003830
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.EventUnit`1
TYPE:  abstract class
TOKEN: 0x2000014
EXTENDS: Unity.VisualScripting.Unit
IMPLEMENTS: Unity.VisualScripting.IUnit Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
  private           Unity.VisualScripting.ControlOutput<trigger>k__BackingField  // 0x0
PROPERTIES:
  trigger  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000062  System.Void Definition()
  RVA=-1  // not resolved  token=0x6000063  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000064  Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph()
END_CLASS

CLASS: Unity.VisualScripting.ManualEventUnit`1
TYPE:  abstract class
TOKEN: 0x2000015
EXTENDS: Unity.VisualScripting.EventUnit`1
FIELDS:
PROPERTIES:
  hookName  get=-1  // abstract
METHODS:
  RVA=-1  // not resolved  token=0x6000066  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.MissingType
TYPE:  sealed class
TOKEN: 0x2000016
SIZE:  0x78
EXTENDS: Unity.VisualScripting.Unit
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000067  System.Void Definition()
END_CLASS

CLASS: Unity.VisualScripting.IUnit
TYPE:  interface
TOKEN: 0x2000017
IMPLEMENTS: Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
PROPERTIES:
  graph  get=-1  // abstract
  defaultValues  get=-1  // abstract
  controlInputs  get=-1  // abstract
  controlOutputs  get=-1  // abstract
  valueInputs  get=-1  // abstract
  valueOutputs  get=-1  // abstract
  invalidInputs  get=-1  // abstract
  invalidOutputs  get=-1  // abstract
  inputs  get=-1  // abstract
  outputs  get=-1  // abstract
  validInputs  get=-1  // abstract
  validOutputs  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000074  System.Void PortsChanged()
END_CLASS

CLASS: Unity.VisualScripting.IUnitDebugData
TYPE:  interface
TOKEN: 0x2000018
IMPLEMENTS: Unity.VisualScripting.IGraphElementDebugData
FIELDS:
PROPERTIES:
  lastInvokeFrame  set=-1  // abstract
  lastInvokeTime  set=-1  // abstract
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.ControlInput
TYPE:  sealed class
TOKEN: 0x2000019
SIZE:  0x28
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitInputPort
FIELDS:
  private   readonly System.Func<Unity.VisualScripting.Flow,Unity.VisualScripting.ControlOutput>action  // 0x20
PROPERTIES:
  requiresCoroutine  get=0x092233D8
  validConnections  get=0x09D78460
  invalidConnections  get=0x09D782C0
  validConnectedPorts  get=0x09D78348
  invalidConnectedPorts  get=0x09D781A8
METHODS:
  RVA=0x0232EB60  token=0x600007C  System.Boolean CanConnectToValid(Unity.VisualScripting.ControlOutput port)
  RVA=0x09D77F50  token=0x600007D  System.Void ConnectToValid(Unity.VisualScripting.ControlOutput port)
  RVA=0x09D77F04  token=0x600007E  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D78078  token=0x600007F  System.Void DisconnectFromValid(Unity.VisualScripting.ControlOutput port)
  RVA=0x09D7802C  token=0x6000080  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
END_CLASS

CLASS: Unity.VisualScripting.ControlOutput
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x20
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitOutputPort
FIELDS:
PROPERTIES:
  validConnections  get=0x09D78B14
  invalidConnections  get=0x09D78974
  validConnectedPorts  get=0x09D789FC
  invalidConnectedPorts  get=0x09D7885C
  connection  get=0x09D787D4
  hasValidConnection  get=0x09D78844
METHODS:
  RVA=0x09D7878C  token=0x6000087  System.Void .ctor(System.String key)
  RVA=0x0232EB60  token=0x600008E  System.Boolean CanConnectToValid(Unity.VisualScripting.ControlInput port)
  RVA=0x09D78534  token=0x600008F  System.Void ConnectToValid(Unity.VisualScripting.ControlInput port)
  RVA=0x09D784E8  token=0x6000090  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7865C  token=0x6000091  System.Void DisconnectFromValid(Unity.VisualScripting.ControlInput port)
  RVA=0x09D78610  token=0x6000092  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.InvalidInput
TYPE:  sealed class
TOKEN: 0x200001F
SIZE:  0x20
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitInputPort
FIELDS:
PROPERTIES:
  validConnections  get=0x09D7AFD8
  invalidConnections  get=0x09D7AE90
  validConnectedPorts  get=0x09D7AEC0
  invalidConnectedPorts  get=0x09D7AD78
METHODS:
  RVA=0x09D7AD30  token=0x6000099  System.Void .ctor(System.String key)
  RVA=0x0115F4C0  token=0x600009E  System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7AC4C  token=0x600009F  System.Void ConnectToValid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7AC00  token=0x60000A0  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7ACE4  token=0x60000A1  System.Void DisconnectFromValid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7AC98  token=0x60000A2  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
END_CLASS

CLASS: Unity.VisualScripting.InvalidOutput
TYPE:  sealed class
TOKEN: 0x2000021
SIZE:  0x20
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitOutputPort
FIELDS:
PROPERTIES:
  validConnections  get=0x09D7B438
  invalidConnections  get=0x09D7B2F0
  validConnectedPorts  get=0x09D7B320
  invalidConnectedPorts  get=0x09D7B1D8
METHODS:
  RVA=0x09D7B190  token=0x60000A7  System.Void .ctor(System.String key)
  RVA=0x0115F4C0  token=0x60000AC  System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7B0AC  token=0x60000AD  System.Void ConnectToValid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7B060  token=0x60000AE  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7B144  token=0x60000AF  System.Void DisconnectFromValid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7B0F8  token=0x60000B0  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.IUnitInputPort
TYPE:  interface
TOKEN: 0x2000023
IMPLEMENTS: Unity.VisualScripting.IUnitPort
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitOutputPort
TYPE:  interface
TOKEN: 0x2000024
IMPLEMENTS: Unity.VisualScripting.IUnitPort
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitPort
TYPE:  interface
TOKEN: 0x2000025
FIELDS:
PROPERTIES:
  unit  get=-1  // abstract  set=-1  // abstract
  key  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60000B8  System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // abstract  token=0x60000B9  System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // abstract  token=0x60000BA  System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // abstract  token=0x60000BB  System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
END_CLASS

CLASS: Unity.VisualScripting.IUnitPortCollection`1
TYPE:  interface
TOKEN: 0x2000026
IMPLEMENTS: Unity.VisualScripting.IKeyedCollection`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitValuePort
TYPE:  interface
TOKEN: 0x2000027
IMPLEMENTS: Unity.VisualScripting.IUnitPort
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.MissingValuePortInputException
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x09D7B4C0  token=0x60000BC  System.Void .ctor(System.String key)
END_CLASS

CLASS: Unity.VisualScripting.UnitPort`3
TYPE:  abstract class
TOKEN: 0x2000029
IMPLEMENTS: Unity.VisualScripting.IUnitPort
FIELDS:
  private           Unity.VisualScripting.IUnit     <unit>k__BackingField  // 0x0
  private   readonly System.String                   <key>k__BackingField  // 0x0
PROPERTIES:
  unit  get=-1  // not resolved  set=-1  // not resolved
  key  get=-1  // not resolved
  validConnections  get=-1  // abstract
  invalidConnections  get=-1  // abstract
  validConnectedPorts  get=-1  // abstract
  invalidConnectedPorts  get=-1  // abstract
  hasValidConnection  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000BD  System.Void .ctor(System.String key)
  RVA=-1  // not resolved  token=0x60000C6  System.Boolean CanConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // not resolved  token=0x60000C7  System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // not resolved  token=0x60000C8  System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // not resolved  token=0x60000C9  System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // not resolved  token=0x60000CA  System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  RVA=-1  // not resolved  token=0x60000CB  System.Void Disconnect()
  RVA=-1  // abstract  token=0x60000CC  System.Boolean CanConnectToValid(TValidOther port)
  RVA=-1  // not resolved  token=0x60000CD  System.Boolean CanConnectToInvalid(TInvalidOther port)
  RVA=-1  // abstract  token=0x60000CE  System.Void ConnectToValid(TValidOther port)
  RVA=-1  // abstract  token=0x60000CF  System.Void ConnectToInvalid(TInvalidOther port)
  RVA=-1  // abstract  token=0x60000D0  System.Void DisconnectFromValid(TValidOther port)
  RVA=-1  // abstract  token=0x60000D1  System.Void DisconnectFromInvalid(TInvalidOther port)
  RVA=-1  // not resolved  token=0x60000D2  System.Void ConnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
  RVA=-1  // not resolved  token=0x60000D3  System.Void DisconnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
END_CLASS

CLASS: Unity.VisualScripting.UnitPortCollection`1
TYPE:  sealed class
TOKEN: 0x200002C
EXTENDS: System.Collections.ObjectModel.KeyedCollection`2
IMPLEMENTS: Unity.VisualScripting.IUnitPortCollection`1 Unity.VisualScripting.IKeyedCollection`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly Unity.VisualScripting.IUnit     <unit>k__BackingField  // 0x0
PROPERTIES:
  unit  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000D9  System.Void .ctor(Unity.VisualScripting.IUnit unit)
  RVA=-1  // not resolved  token=0x60000DA  System.Void BeforeAdd(TPort port)
  RVA=-1  // not resolved  token=0x60000DB  System.Void AfterAdd(TPort port)
  RVA=-1  // not resolved  token=0x60000DC  System.Void BeforeRemove(TPort port)
  RVA=-1  // not resolved  token=0x60000DD  System.Void AfterRemove(TPort port)
  RVA=-1  // not resolved  token=0x60000DE  System.String GetKeyForItem(TPort item)
  RVA=-1  // not resolved  token=0x60000DF  System.Void InsertItem(System.Int32 index, TPort item)
  RVA=-1  // not resolved  token=0x60000E0  System.Void RemoveItem(System.Int32 index)
  RVA=-1  // not resolved  token=0x60000E1  System.Void SetItem(System.Int32 index, TPort item)
  RVA=-1  // not resolved  token=0x60000E2  System.Void ClearItems()
  RVA=-1  // not resolved  token=0x60000E3  TPort Unity.VisualScripting.IKeyedCollection<System.String,TPort>.get_Item(System.String key)
  RVA=-1  // not resolved  token=0x60000E4  System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,TPort>.Contains(System.String key)
END_CLASS

CLASS: Unity.VisualScripting.ValueInput
TYPE:  sealed class
TOKEN: 0x200002D
SIZE:  0x30
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitValuePort Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitInputPort
FIELDS:
  private   readonly System.Type                     <type>k__BackingField  // 0x20
  private           System.Boolean                  <nullMeansSelf>k__BackingField  // 0x28
  private   static readonly System.Collections.Generic.HashSet<System.Type>typesWithDefaultValues  // static @ 0x0
PROPERTIES:
  type  get=0x03D4EB40
  validConnections  get=0x09D7D8D0
  invalidConnections  get=0x09D7D730
  validConnectedPorts  get=0x09D7D7B8
  invalidConnectedPorts  get=0x09D7D618
  nullMeansSelf  get=0x03D4ED50
  connection  get=0x09D7D590
  hasValidConnection  get=0x09D7D600
METHODS:
  RVA=0x09D7D4D0  token=0x60000E5  System.Void .ctor(System.String key, System.Type type)
  RVA=0x09D7CFA0  token=0x60000EE  System.Void SetDefaultValue(System.Object value)
  RVA=0x09D7CC84  token=0x60000EF  System.Boolean CanConnectToValid(Unity.VisualScripting.ValueOutput port)
  RVA=0x09D7CD48  token=0x60000F0  System.Void ConnectToValid(Unity.VisualScripting.ValueOutput port)
  RVA=0x09D7CCFC  token=0x60000F1  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7CE70  token=0x60000F2  System.Void DisconnectFromValid(Unity.VisualScripting.ValueOutput port)
  RVA=0x09D7CE24  token=0x60000F3  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
  RVA=0x09D7D11C  token=0x60000F4  System.Boolean SupportsDefaultValue(System.Type type)
  RVA=0x09D7D258  token=0x60000F5  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ValueOutput
TYPE:  sealed class
TOKEN: 0x2000030
SIZE:  0x30
EXTENDS: Unity.VisualScripting.UnitPort`3
IMPLEMENTS: Unity.VisualScripting.IUnitValuePort Unity.VisualScripting.IUnitPort Unity.VisualScripting.IUnitOutputPort
FIELDS:
  private   readonly System.Func<Unity.VisualScripting.Flow,System.Object>getValue  // 0x20
  private   readonly System.Type                     <type>k__BackingField  // 0x28
PROPERTIES:
  supportsFetch  get=0x08571E40
  type  get=0x03D4EAC0
  validConnections  get=0x09D7E030
  invalidConnections  get=0x09D7DE90
  validConnectedPorts  get=0x09D7DF18
  invalidConnectedPorts  get=0x09D7DD78
METHODS:
  RVA=0x09D7DC64  token=0x60000FC  System.Void .ctor(System.String key, System.Type type, System.Func<Unity.VisualScripting.Flow,System.Object> getValue)
  RVA=0x09D7D958  token=0x6000103  System.Boolean CanConnectToValid(Unity.VisualScripting.ValueInput port)
  RVA=0x09D7DA0C  token=0x6000104  System.Void ConnectToValid(Unity.VisualScripting.ValueInput port)
  RVA=0x09D7D9C0  token=0x6000105  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  RVA=0x09D7DB34  token=0x6000106  System.Void DisconnectFromValid(Unity.VisualScripting.ValueInput port)
  RVA=0x09D7DAE8  token=0x6000107  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.Unit
TYPE:  abstract class
TOKEN: 0x2000033
SIZE:  0x78
EXTENDS: Unity.VisualScripting.GraphElement`1
IMPLEMENTS: Unity.VisualScripting.IUnit Unity.VisualScripting.IGraphElementWithDebugData Unity.VisualScripting.IGraphElement System.IDisposable Unity.VisualScripting.IIdentifiable
FIELDS:
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput><controlInputs>k__BackingField  // 0x28
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput><controlOutputs>k__BackingField  // 0x30
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput><valueInputs>k__BackingField  // 0x38
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput><valueOutputs>k__BackingField  // 0x40
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput><invalidInputs>k__BackingField  // 0x48
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput><invalidOutputs>k__BackingField  // 0x50
  private           System.Action                   onPortsChanged  // 0x58
  private           System.Collections.Generic.Dictionary<System.String,System.Object><defaultValues>k__BackingField  // 0x60
  private           Unity.VisualScripting.IConnectionCollection<Unity.VisualScripting.IUnitRelation,Unity.VisualScripting.IUnitPort,Unity.VisualScripting.IUnitPort><relations>k__BackingField  // 0x68
  private           System.Boolean                  <isControlRoot>k__BackingField  // 0x70
PROPERTIES:
  controlInputs  get=0x03D4EAC0
  controlOutputs  get=0x01003830
  valueInputs  get=0x03D4E2A0
  valueOutputs  get=0x03D4E2B0
  invalidInputs  get=0x03D4EA70
  invalidOutputs  get=0x03D4EAF0
  inputs  get=0x09D7C638
  outputs  get=0x09D7C70C
  validInputs  get=0x09D7C7E0
  validOutputs  get=0x09D7C894
  defaultValues  get=0x03D4EB00  set=0x039274B0
  relations  set=0x038C5570
  isControlRoot  set=0x03D4F290
METHODS:
  RVA=0x09D7C388  token=0x600010E  System.Void .ctor()
  RVA=-1  // abstract  token=0x600010F  System.Void Definition()
  RVA=0x05DA555C  token=0x600011A  System.Void PortsChanged()
  RVA=0x09D7BF84  token=0x600011F  System.Void EnsureUniqueInput(System.String key)
  RVA=0x09D7C0B8  token=0x6000120  System.Void EnsureUniqueOutput(System.String key)
  RVA=0x09D7BEEC  token=0x6000121  Unity.VisualScripting.ControlOutput ControlOutput(System.String key)
  RVA=0x09D7C224  token=0x6000122  Unity.VisualScripting.ValueInput ValueInput(System.Type type, System.String key)
  RVA=-1  // generic def  token=0x6000123  Unity.VisualScripting.ValueInput ValueInput(System.String key)
  RVA=-1  // generic def  token=0x6000124  Unity.VisualScripting.ValueInput ValueInput(System.String key, T default)
  RVA=0x09D7C2CC  token=0x6000125  Unity.VisualScripting.ValueOutput ValueOutput(System.Type type, System.String key, System.Func<Unity.VisualScripting.Flow,System.Object> getValue)
  RVA=-1  // generic def  token=0x6000126  Unity.VisualScripting.ValueOutput ValueOutput(System.String key, System.Func<Unity.VisualScripting.Flow,T> getValue)
  RVA=0x09D7C1EC  token=0x6000127  Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph()
END_CLASS

CLASS: Unity.VisualScripting.UnitCategory
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x38
EXTENDS: System.Attribute
FIELDS:
  private   readonly Unity.VisualScripting.UnitCategory<root>k__BackingField  // 0x10
  private   readonly Unity.VisualScripting.UnitCategory<parent>k__BackingField  // 0x18
  private   readonly System.String                   <fullName>k__BackingField  // 0x20
  private   readonly System.String                   <name>k__BackingField  // 0x28
  private   readonly System.Boolean                  <isRoot>k__BackingField  // 0x30
PROPERTIES:
  fullName  get=0x03D4EB40
METHODS:
  RVA=0x09D7BD28  token=0x600012A  System.Void .ctor(System.String fullName)
  RVA=0x09D7BC7C  token=0x600012C  System.Boolean Equals(System.Object obj)
  RVA=0x09D7BD04  token=0x600012D  System.Int32 GetHashCode()
  RVA=0x03D4EB40  token=0x600012E  System.String ToString()
END_CLASS

CLASS: Unity.VisualScripting.UnitCategoryConverter
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x18
EXTENDS: Unity.VisualScripting.FullSerializer.fsDirectConverter
FIELDS:
PROPERTIES:
  ModelType  get=0x09D7BC2C
METHODS:
  RVA=0x09D7BB44  token=0x6000130  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  RVA=0x09D7BA14  token=0x6000131  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
END_CLASS

