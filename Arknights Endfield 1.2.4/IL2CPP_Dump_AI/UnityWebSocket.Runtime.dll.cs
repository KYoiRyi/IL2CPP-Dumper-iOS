// ========================================================
// Dumped by @desirepro
// Assembly: UnityWebSocket.Runtime.dll
// Classes:  16
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

CLASS: SendBuffer
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x20
FIELDS:
  public            System.Byte[]                   data  // 0x10
  public            System.Net.WebSockets.WebSocketMessageTypetype  // 0x18
METHODS:
  RVA=0x02738A30  token=0x6000052  System.Void .ctor(System.Byte[] data, System.Net.WebSockets.WebSocketMessageType type)
END_CLASS

CLASS: <ConnectTask>d__36
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x40
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            UnityWebSocket.WebSocket        <>4__this  // 0x30
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x38
METHODS:
  RVA=0x09F8D200  token=0x6000053  System.Void MoveNext()
  RVA=0x09F8D62C  token=0x6000054  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <SendTask>d__42
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x40
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            UnityWebSocket.WebSocket        <>4__this  // 0x30
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x38
METHODS:
  RVA=0x09F8E088  token=0x6000055  System.Void MoveNext()
  RVA=0x09F8E760  token=0x6000056  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <ReceiveTask>d__43
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x68
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            UnityWebSocket.WebSocket        <>4__this  // 0x30
  private           System.String                   <closeReason>5__2  // 0x38
  private           System.UInt16                   <closeCode>5__3  // 0x40
  private           System.Boolean                  <isClosed>5__4  // 0x42
  private           System.ArraySegment<System.Byte><segment>5__5  // 0x48
  private           System.IO.MemoryStream          <ms>5__6  // 0x58
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebSockets.WebSocketReceiveResult><>u__1  // 0x60
METHODS:
  RVA=0x09F8D688  token=0x6000057  System.Void MoveNext()
  RVA=0x09F8E02C  token=0x6000058  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: UnityWebSocket.CloseEventArgs
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x28
EXTENDS: System.EventArgs
FIELDS:
  private           System.UInt16                   <Code>k__BackingField  // 0x10
  private           System.String                   <Reason>k__BackingField  // 0x18
  private           System.Boolean                  <WasClean>k__BackingField  // 0x20
PROPERTIES:
  Code  get=0x03D61390  set=0x03D60960
  Reason  get=0x01041090  set=0x022C3A90
  WasClean  get=0x03D4EF90  set=0x03D4EFC0
  StatusCode  get=0x09F8CEC0
METHODS:
  RVA=0x09F8CE80  token=0x6000001  System.Void .ctor()
  RVA=0x09F8CE6C  token=0x6000002  System.Void .ctor(System.UInt16 code)
  RVA=0x09F8CE6C  token=0x6000003  System.Void .ctor(UnityWebSocket.CloseStatusCode code)
  RVA=0x09F8CE78  token=0x6000004  System.Void .ctor(UnityWebSocket.CloseStatusCode code, System.String reason)
  RVA=0x09F8CE0C  token=0x6000005  System.Void .ctor(System.UInt16 code, System.String reason)
END_CLASS

CLASS: UnityWebSocket.CloseStatusCode
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x12
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityWebSocket.CloseStatusCode  Unknown  // const
  public    static  UnityWebSocket.CloseStatusCode  Normal  // const
  public    static  UnityWebSocket.CloseStatusCode  Away  // const
  public    static  UnityWebSocket.CloseStatusCode  ProtocolError  // const
  public    static  UnityWebSocket.CloseStatusCode  UnsupportedData  // const
  public    static  UnityWebSocket.CloseStatusCode  Undefined  // const
  public    static  UnityWebSocket.CloseStatusCode  NoStatus  // const
  public    static  UnityWebSocket.CloseStatusCode  Abnormal  // const
  public    static  UnityWebSocket.CloseStatusCode  InvalidData  // const
  public    static  UnityWebSocket.CloseStatusCode  PolicyViolation  // const
  public    static  UnityWebSocket.CloseStatusCode  TooBig  // const
  public    static  UnityWebSocket.CloseStatusCode  MandatoryExtension  // const
  public    static  UnityWebSocket.CloseStatusCode  ServerError  // const
  public    static  UnityWebSocket.CloseStatusCode  TlsHandshakeFailure  // const
METHODS:
END_CLASS

CLASS: UnityWebSocket.ErrorEventArgs
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x20
EXTENDS: System.EventArgs
FIELDS:
  private           System.Exception                <Exception>k__BackingField  // 0x10
  private           System.String                   <Message>k__BackingField  // 0x18
PROPERTIES:
  Exception  get=0x020B7B20  set=0x0426FEE0
  Message  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09F8CFF4  token=0x600000D  System.Void .ctor(System.String message)
  RVA=0x09F8CF88  token=0x600000E  System.Void .ctor(System.String message, System.Exception exception)
END_CLASS

CLASS: UnityWebSocket.IWebSocket
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
PROPERTIES:
  Address  get=-1  // abstract
  SubProtocols  get=-1  // abstract
  ReadyState  get=-1  // abstract
  BinaryType  get=-1  // abstract  set=-1  // abstract
EVENTS:
  OnOpen  add=add_OnOpen  remove=remove_OnOpen
  OnClose  add=add_OnClose  remove=remove_OnClose
  OnError  add=add_OnError  remove=remove_OnError
  OnMessage  add=add_OnMessage  remove=remove_OnMessage
METHODS:
  RVA=-1  // abstract  token=0x6000013  System.Void ConnectAsync()
  RVA=-1  // abstract  token=0x6000014  System.Void CloseAsync()
  RVA=-1  // abstract  token=0x6000015  System.Void SendAsync(System.Byte[] data)
  RVA=-1  // abstract  token=0x6000016  System.Void SendAsync(System.String text)
END_CLASS

CLASS: UnityWebSocket.MessageEventArgs
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x28
EXTENDS: System.EventArgs
FIELDS:
  private           System.Byte[]                   _rawData  // 0x10
  private           System.String                   _data  // 0x18
  private           UnityWebSocket.Opcode           <Opcode>k__BackingField  // 0x20
PROPERTIES:
  Opcode  get=0x03D4EF90  set=0x03D4EFC0
  Data  get=0x09F8D178
  RawData  get=0x09F8D1A4
  IsBinary  get=0x09F8D194
  IsText  get=0x09F8D19C
METHODS:
  RVA=0x09F8D0B8  token=0x6000024  System.Void .ctor(UnityWebSocket.Opcode opcode, System.Byte[] rawData)
  RVA=0x09F8D118  token=0x6000025  System.Void .ctor(UnityWebSocket.Opcode opcode, System.String data)
  RVA=0x09F8D000  token=0x600002C  System.Void SetData()
  RVA=0x09F8D068  token=0x600002D  System.Void SetRawData()
END_CLASS

CLASS: UnityWebSocket.Opcode
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityWebSocket.Opcode           Text  // const
  public    static  UnityWebSocket.Opcode           Binary  // const
  public    static  UnityWebSocket.Opcode           Close  // const
METHODS:
END_CLASS

CLASS: UnityWebSocket.OpenEventArgs
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
EXTENDS: System.EventArgs
FIELDS:
METHODS:
  RVA=0x09F8D1C0  token=0x600002E  System.Void .ctor()
END_CLASS

CLASS: UnityWebSocket.Settings
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
  public    static  System.String                   GITHUB  // const
  public    static  System.String                   QQ_GROUP  // const
  public    static  System.String                   QQ_GROUP_LINK  // const
  public    static  System.String                   EMAIL  // const
  public    static  System.String                   AUHTOR  // const
  public    static  System.String                   VERSION  // const
METHODS:
END_CLASS

CLASS: UnityWebSocket.WebSocketState
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x12
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityWebSocket.WebSocketState   Connecting  // const
  public    static  UnityWebSocket.WebSocketState   Open  // const
  public    static  UnityWebSocket.WebSocketState   Closing  // const
  public    static  UnityWebSocket.WebSocketState   Closed  // const
METHODS:
END_CLASS

CLASS: UnityWebSocket.WebSocket
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x78
IMPLEMENTS: UnityWebSocket.IWebSocket
FIELDS:
  private           System.String                   <Address>k__BackingField  // 0x10
  private           System.String[]                 <SubProtocols>k__BackingField  // 0x18
  private           System.String                   <BinaryType>k__BackingField  // 0x20
  private           System.EventHandler<UnityWebSocket.OpenEventArgs>OnOpen  // 0x28
  private           System.EventHandler<UnityWebSocket.CloseEventArgs>OnClose  // 0x30
  private           System.EventHandler<UnityWebSocket.ErrorEventArgs>OnError  // 0x38
  private           System.EventHandler<UnityWebSocket.MessageEventArgs>OnMessage  // 0x40
  private           System.Net.WebSockets.ClientWebSocketsocket  // 0x48
  private           System.Object                   sendQueueLock  // 0x50
  private           System.Collections.Generic.Queue<UnityWebSocket.WebSocket.SendBuffer>sendQueue  // 0x58
  private           System.Boolean                  isSendTaskRunning  // 0x60
  private   readonly System.Collections.Generic.Queue<System.EventArgs>eventQueue  // 0x68
  private   readonly System.Object                   eventQueueLock  // 0x70
PROPERTIES:
  Address  get=0x020B7B20  set=0x0426FEE0
  SubProtocols  get=0x01041090  set=0x022C3A90
  ReadyState  get=0x09F90250
  BinaryType  get=0x03D4EB40  set=0x04271930
  isOpening  get=0x09F902A8
EVENTS:
  OnOpen  add=add_OnOpen  remove=remove_OnOpen
  OnClose  add=add_OnClose  remove=remove_OnClose
  OnError  add=add_OnError  remove=remove_OnError
  OnMessage  add=add_OnMessage  remove=remove_OnMessage
METHODS:
  RVA=0x09F8FED8  token=0x600003F  System.Void .ctor(System.String address)
  RVA=0x09F8FBDC  token=0x6000040  System.Void .ctor(System.String address, System.String subProtocol)
  RVA=0x09F8FD74  token=0x6000041  System.Void .ctor(System.String address, System.String[] subProtocols)
  RVA=0x09F8EC7C  token=0x6000042  System.Void ConnectAsync()
  RVA=0x09F8EC00  token=0x6000043  System.Void CloseAsync()
  RVA=0x09F8F434  token=0x6000044  System.Void SendAsync(System.Byte[] data)
  RVA=0x09F8F4C0  token=0x6000045  System.Void SendAsync(System.String text)
  RVA=0x09F8EE1C  token=0x6000046  System.Threading.Tasks.Task ConnectTask()
  RVA=0x09F8F568  token=0x6000047  System.Void SendBufferAsync(UnityWebSocket.WebSocket.SendBuffer buffer)
  RVA=0x09F8F848  token=0x6000048  System.Threading.Tasks.Task SendTask()
  RVA=0x09F8F378  token=0x6000049  System.Threading.Tasks.Task ReceiveTask()
  RVA=0x09F8F8F8  token=0x600004A  System.Void SocketDispose()
  RVA=0x09F8F154  token=0x600004B  System.Void HandleOpen()
  RVA=0x09F8F0CC  token=0x600004C  System.Void HandleMessage(UnityWebSocket.Opcode opcode, System.Byte[] rawData)
  RVA=0x09F8EECC  token=0x600004D  System.Void HandleClose(System.UInt16 code, System.String reason)
  RVA=0x09F8EF54  token=0x600004E  System.Void HandleError(System.Exception exception)
  RVA=0x09F8EFE4  token=0x600004F  System.Void HandleEventSync(System.EventArgs eventArgs)
  RVA=0x09F8F960  token=0x6000050  System.Void Update()
  RVA=0x09F8F1BC  token=0x6000051  System.Void Log(System.String msg)
END_CLASS

CLASS: UnityWebSocket.WebSocketManager
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.String                   rootName  // const
  private   static  UnityWebSocket.WebSocketManager _instance  // static @ 0x0
  private   readonly System.Collections.Generic.List<UnityWebSocket.WebSocket>sockets  // 0x18
PROPERTIES:
  Instance  get=0x09F8EB88
METHODS:
  RVA=0x09F8E83C  token=0x600005A  System.Void Awake()
  RVA=0x09F8E88C  token=0x600005B  System.Void CreateInstance()
  RVA=0x09F8E7BC  token=0x600005C  System.Void Add(UnityWebSocket.WebSocket socket)
  RVA=0x09F8EA00  token=0x600005D  System.Void Remove(UnityWebSocket.WebSocket socket)
  RVA=0x09F8EA80  token=0x600005E  System.Void Update()
  RVA=0x09F8EB08  token=0x600005F  System.Void .ctor()
END_CLASS

