// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.SpeedTest.dll
// Classes:  33
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

CLASS: <>c__DisplayClass11_0
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x20
FIELDS:
  public            Hypergryph.SpeedTest.EventLogWrapper<>4__this  // 0x10
  public            System.String                   region  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000007  System.Void .ctor()
  RVA=0x03B340B0  token=0x6000008  System.Boolean <init>b__0()
END_CLASS

CLASS: <init>d__11
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncVoidMethodBuilder<>t__builder  // 0x18
  public            Hypergryph.SpeedTest.EventLogWrapper<>4__this  // 0x38
  private           Hypergryph.SpeedTest.EventLogWrapper.<>c__DisplayClass11_0<>8__1  // 0x40
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x48
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__2  // 0x50
METHODS:
  RVA=0x032F75A0  token=0x6000009  System.Void MoveNext()
  RVA=0x042760AC  token=0x600000A  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <<EventTrack>b__0>d
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x40
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            Hypergryph.SpeedTest.EventLogWrapper.<>c__DisplayClass12_0<>4__this  // 0x30
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x38
METHODS:
  RVA=0x0887F850  token=0x600000D  System.Void MoveNext()
  RVA=0x0887FAE0  token=0x600000E  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x28
FIELDS:
  public            Hypergryph.SpeedTest.EventLogWrapper<>4__this  // 0x10
  public            System.String                   name  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.Object>data  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600000B  System.Void .ctor()
  RVA=0x0887FB3C  token=0x600000C  System.Threading.Tasks.Task <EventTrack>b__0()
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x28
FIELDS:
  public            Hypergryph.SpeedTest.EventLogWrapper<>4__this  // 0x10
  public            System.String                   name  // 0x18
  public            Newtonsoft.Json.Linq.JObject    properties  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600000F  System.Void .ctor()
  RVA=0x0887FBEC  token=0x6000010  System.Boolean <ExecuteEventTrackSafely>b__0()
END_CLASS

CLASS: <ExecuteEventTrackSafely>d__13
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            Hypergryph.SpeedTest.EventLogWrapper<>4__this  // 0x30
  public            System.String                   name  // 0x38
  public            System.Collections.Generic.Dictionary<System.String,System.Object>data  // 0x40
  private           Hypergryph.SpeedTest.EventLogWrapper.<>c__DisplayClass13_0<>8__1  // 0x48
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x50
METHODS:
  RVA=0x0887E72C  token=0x6000011  System.Void MoveNext()
  RVA=0x0887EC0C  token=0x6000012  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <OnApplicationPause>d__16
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x48
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            System.Boolean                  pauseStatus  // 0x30
  public            Hypergryph.SpeedTest.HGSpeedTestSDK<>4__this  // 0x38
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x40
METHODS:
  RVA=0x032F7180  token=0x6000026  System.Void MoveNext()
  RVA=0x036BB080  token=0x6000027  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass17_0
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x28
FIELDS:
  public            Hypergryph.SpeedTest.HGSpeedTestSDK<>4__this  // 0x10
  public            System.Action<Hypergryph.SpeedTest.SpeedTestResult>callback  // 0x18
  public            System.Int32                    round  // 0x20
  public            Hypergryph.SpeedTest.SpeedTestProtocolprotocol  // 0x24
METHODS:
  RVA=0x0350B670  token=0x6000028  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass17_1
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x20
FIELDS:
  public            Hypergryph.SpeedTest.SpeedTestServerInfoserver  // 0x10
  public            Hypergryph.SpeedTest.HGSpeedTestSDK.<>c__DisplayClass17_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000029  System.Void .ctor()
  RVA=0x0887FCFC  token=0x600002A  System.Void <StartSpeedTest>b__0()
END_CLASS

CLASS: <StartSpeedTest>d__17
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Hypergryph.SpeedTest.TaskResult><>t__builder  // 0x18
  public            Hypergryph.SpeedTest.HGSpeedTestSDK<>4__this  // 0x30
  public            System.Action<Hypergryph.SpeedTest.SpeedTestResult>callback  // 0x38
  public            System.Int32                    round  // 0x40
  public            Hypergryph.SpeedTest.SpeedTestProtocolprotocol  // 0x44
  public            System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo>serverList  // 0x48
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x50
METHODS:
  RVA=0x0887EC68  token=0x600002B  System.Void MoveNext()
  RVA=0x0887F7F0  token=0x600002C  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass20_0
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x20
FIELDS:
  public            System.Action<Hypergryph.SpeedTest.SpeedTestResult>callback  // 0x10
  public            Hypergryph.SpeedTest.SpeedTestResultresult  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600002D  System.Void .ctor()
  RVA=0x0887FD88  token=0x600002E  System.Void <NotifyRoundResult>b__0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x10
FIELDS:
  public    static readonly Hypergryph.SpeedTest.HGSpeedTestSDK.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Int64,System.Int64><>9__27_0  // static @ 0x8
METHODS:
  RVA=0x0887FE5C  token=0x600002F  System.Void .cctor()
  RVA=0x0350B670  token=0x6000030  System.Void .ctor()
  RVA=0x03D51810  token=0x6000031  System.Int64 <GetP50>b__27_0(System.Int64 x)
END_CLASS

CLASS: <init>d__7
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x40
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            Hypergryph.SpeedTest.NativeConfigLoader<>4__this  // 0x30
  private           System.Runtime.CompilerServices.TaskAwaiter<System.String><>u__1  // 0x38
METHODS:
  RVA=0x03159B30  token=0x600003B  System.Void MoveNext()
  RVA=0x036BB0E0  token=0x600003C  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000018
SIZE:  0x18
FIELDS:
  public            System.String                   logInfo  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000040  System.Void .ctor()
  RVA=0x0268EFD0  token=0x6000041  System.Void <PrintLogToView>b__0()
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200001A
SIZE:  0x18
FIELDS:
  public            System.Action                   action  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000046  System.Void .ctor()
  RVA=0x03C90750  token=0x6000047  System.Void <RunOnMainThread>b__0(System.Object _)
END_CLASS

CLASS: <>c__DisplayClass4_0`1
TYPE:  sealed class
TOKEN: 0x200001B
FIELDS:
  public            System.Threading.Tasks.TaskCompletionSource<T>tcs  // 0x0
  public            System.Func<T>                  func  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000048  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000049  System.Void <RunOnMainThread>b__0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x10
FIELDS:
  public    static readonly Hypergryph.SpeedTest.UnityMainThread.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Boolean>     <>9__5_0  // static @ 0x8
METHODS:
  RVA=0x03D0FA70  token=0x600004A  System.Void .cctor()
  RVA=0x0350B670  token=0x600004B  System.Void .ctor()
  RVA=0x042744F0  token=0x600004C  System.Boolean <isAppFocused>b__5_0()
END_CLASS

CLASS: <isAppFocused>d__5
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x38
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean><>t__builder  // 0x18
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x30
METHODS:
  RVA=0x032F7350  token=0x600004D  System.Void MoveNext()
  RVA=0x03891490  token=0x600004E  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: __StaticArrayInitTypeSize=16
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x20
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x30
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324DAABD10C615552E680FD1F3F9C9E1B1C74413B5F519EDE1335CD44C46B11EC8  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16701AA427DC569405D7608BAD336BBED96E382E97EE07C02CFED96D856E313AE5  // static @ 0x20
METHODS:
END_CLASS

CLASS: Hypergryph.SpeedTest.EventLogWrapper
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x20
FIELDS:
  private   static readonly Hypergryph.SpeedTest.EventLogWrapper_instance  // static @ 0x0
  private           System.String                   _appId  // 0x10
  private           System.String                   _gameVersion  // 0x18
PROPERTIES:
  Instance  get=0x0887C208
METHODS:
  RVA=0x03CA7860  token=0x6000001  System.Void .ctor()
  RVA=0x02D90E40  token=0x6000003  System.Void init()
  RVA=0x0887C030  token=0x6000004  System.Void EventTrack(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data)
  RVA=0x0887C11C  token=0x6000005  System.Threading.Tasks.Task ExecuteEventTrackSafely(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data)
  RVA=0x03CA77F0  token=0x6000006  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.HGSpeedTestSDKVersion
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   VERSION  // static @ 0x0
METHODS:
  RVA=0x0887C258  token=0x6000013  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestServerInfo
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x20
FIELDS:
  public            System.String                   host  // 0x10
  public            System.String                   name  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000014  System.Void .ctor(System.String host, System.String name)
END_CLASS

CLASS: Hypergryph.SpeedTest.TaskResult
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x20
FIELDS:
  public            System.Int32                    taskCode  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  RVA=0x04270E40  token=0x6000015  System.Void .ctor(System.Int32 code, System.String message)
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestResult
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x28
FIELDS:
  public            System.String                   host  // 0x10
  public            System.String                   name  // 0x18
  public            System.Int32                    latency  // 0x20
  public            System.Int32                    resultCode  // 0x24
METHODS:
  RVA=0x0887E6EC  token=0x6000016  System.Void .ctor(System.Int32 resultCode, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server)
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestProtocol
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Hypergryph.SpeedTest.SpeedTestProtocolTCP  // const
  public    static  Hypergryph.SpeedTest.SpeedTestProtocolUDP  // const
METHODS:
END_CLASS

CLASS: Hypergryph.SpeedTest.HGSpeedTestSDK
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x40
FIELDS:
  private   static readonly Hypergryph.SpeedTest.HGSpeedTestSDK_instance  // static @ 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.TcpClient>_connections  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.NetworkStream>_streams  // 0x18
  private   readonly System.Object                   _lockObject  // 0x20
  private           System.Threading.CancellationTokenSourcects  // 0x28
  private           System.Int64                    _packetIndex  // 0x30
  private           System.Boolean                  _isInSpeedTest  // 0x38
METHODS:
  RVA=0x02D90CD0  token=0x6000017  System.Void .ctor()
  RVA=0x0887CE48  token=0x6000018  Hypergryph.SpeedTest.HGSpeedTestSDK GetInstance()
  RVA=0x03134EB0  token=0x6000019  System.Threading.Tasks.Task OnApplicationPause(System.Boolean pauseStatus)
  RVA=0x0887D93C  token=0x600001A  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> StartSpeedTest(System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo> serverList, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol)
  RVA=0x0887D5A4  token=0x600001B  System.Void OnSpeedTestStart()
  RVA=0x0887D384  token=0x600001C  Hypergryph.SpeedTest.TaskResult OnSpeedTaskResult(System.Int32 code, System.String message)
  RVA=0x0887D04C  token=0x600001D  System.Void NotifyRoundResult(System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 code, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server)
  RVA=0x0887C2B4  token=0x600001E  System.Void CleanupConnections()
  RVA=0x0887DA58  token=0x600001F  System.Void TestServerLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol, System.Threading.CancellationToken cancellationToken)
  RVA=0x0887C84C  token=0x6000020  System.Int32 EstablishConnection(Hypergryph.SpeedTest.SpeedTestServerInfo server)
  RVA=0x0887E07C  token=0x6000021  Hypergryph.SpeedTest.SpeedTestResult TestTcpLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Collections.Generic.List<System.Int64> serverLatencyList, System.Threading.CancellationToken cancellationToken)
  RVA=0x0887D70C  token=0x6000022  System.Int64 SendTcpPackage(System.Net.Sockets.NetworkStream stream)
  RVA=0x0887C74C  token=0x6000023  System.Byte[] CreateTcpPacket()
  RVA=0x0887CE98  token=0x6000024  System.Int64 GetP50(System.Collections.Generic.List<System.Int64> latencies)
  RVA=0x02D90C60  token=0x6000025  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.NativeConfigLoader
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x28
FIELDS:
  private   static  Hypergryph.SpeedTest.NativeConfigLoaderinstance  // static @ 0x0
  private           System.String                   region  // 0x10
  private           System.String                   appDataPath  // 0x18
  private           System.String                   _gameVersion  // 0x20
METHODS:
  RVA=0x03CB7840  token=0x6000032  System.Void .ctor()
  RVA=0x032F7CB0  token=0x6000033  System.Threading.Tasks.Task init()
  RVA=0x0887E630  token=0x6000034  Hypergryph.SpeedTest.NativeConfigLoader GetInstance()
  RVA=0x03D4EB40  token=0x6000035  System.String GetGameVersion()
  RVA=0x032F7AE0  token=0x6000036  System.String GetRegion()
  RVA=0x032F7B20  token=0x6000037  System.String GetRegionFromConfig()
  RVA=0x02D7A560  token=0x6000038  System.String ReadWinConfig()
  RVA=0x03CB77D0  token=0x6000039  System.Void .cctor()
  RVA=0x0315C390  token=0x600003A  System.String <init>b__7_0()
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestLogger
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03158B70  token=0x600003D  System.Void Debug(System.String message)
  RVA=0x0887E680  token=0x600003E  System.Void Error(System.String message)
  RVA=0x03158BF0  token=0x600003F  System.Void PrintLogToView(System.String logInfo)
END_CLASS

CLASS: Hypergryph.SpeedTest.UnityMainThread
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
  private   static  System.Threading.SynchronizationContextMainContext  // static @ 0x0
  public    static  System.Boolean                  isDebug  // static @ 0x8
METHODS:
  RVA=0x0316FE90  token=0x6000042  System.Void Init()
  RVA=0x03158CA0  token=0x6000043  System.Void RunOnMainThread(System.Action action)
  RVA=-1  // generic def  token=0x6000044  System.Threading.Tasks.Task<T> RunOnMainThread(System.Func<T> func)
  RVA=0x032F7EA0  token=0x6000045  System.Threading.Tasks.Task<System.Boolean> isAppFocused()
END_CLASS

CLASS: Hypergryph.SpeedTest.WinConfigParser
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x10
FIELDS:
  private   static readonly System.Byte[]                   iv  // static @ 0x0
  private   static readonly System.Byte[]                   aes_key  // static @ 0x8
  private   static readonly System.String                   public_key_str  // static @ 0x10
METHODS:
  RVA=0x03157C50  token=0x600004F  System.String ParseEncryptionFile(System.String encryptionfile, System.String verifyfile)
  RVA=0x03188DE0  token=0x6000050  System.String DecryptConfig(System.Byte[] encryptedData, System.Byte[] key, System.Byte[] iv)
  RVA=0x03188250  token=0x6000051  System.Boolean VerifySignature(System.String data, System.String sign)
  RVA=0x023B04E0  token=0x6000052  System.Void ImportRsaPublicKeyManually(System.Security.Cryptography.RSACryptoServiceProvider rsa, System.Byte[] publicKeyBytes)
  RVA=0x03188C90  token=0x6000053  System.Byte[] ExtractPublicKeyFromPem(System.String pemString)
  RVA=0x03B3E930  token=0x6000054  System.Void .cctor()
END_CLASS

