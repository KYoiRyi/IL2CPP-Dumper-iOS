// ========================================================
// Dumped by @desirepro
// Assembly: Network.Beyond.dll
// Classes:  100
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

CLASS: HandlerEntry
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x18
FIELDS:
  public            Beyond.Network.NetResponseHandlerhandler  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600007A  System.Void .ctor()
END_CLASS

CLASS: ResultHandler
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x40
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Boolean                  m_ignoreSeq  // 0x10
  private           Beyond.ListDict<Proto.SCMessageID,System.Object>m_responseTokens  // 0x18
  private           Beyond.ListDict<Proto.SCMessageID,Beyond.Network.NetResponseHandler>m_responseHandlers  // 0x20
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x28
  private           System.UInt64                   <cachedSeqNum>k__BackingField  // 0x30
  private           System.Int32                    <sessionID>k__BackingField  // 0x38
PROPERTIES:
  isDisposed  get=0x03D4ED50  set=0x03D4ED60
  cachedSeqNum  get=0x01003830  set=0x01003840
  sessionID  get=0x03D4EC30  set=0x03D4ECB0
METHODS:
  RVA=0x092A6330  token=0x6000081  System.Void SetIgnoreSeq(System.Boolean ignoreSeq)
  RVA=0x02F113B0  token=0x6000082  Beyond.Network.NetBus.ResultHandler OnResponse(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  RVA=0x02F10A10  token=0x6000083  System.Void Dispose()
  RVA=0x02F106E0  token=0x6000084  System.Void _HandleMessage(Beyond.Network.NetResponse& msg)
  RVA=0x0350B670  token=0x6000085  System.Void .ctor()
END_CLASS

CLASS: Sender
TYPE:  abstract class
TOKEN: 0x2000016
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000086  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=-1  // abstract  token=0x6000087  System.Void OnNetShutDown()
  RVA=0x02946310  token=0x6000088  Beyond.Network.NetBus.ResultHandler DoSend(Google.Protobuf.IMessage message)
  RVA=0x092A6384  token=0x6000089  System.Void DoListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  RVA=0x092A6424  token=0x600008A  System.Void DoUnListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  RVA=0x0350B670  token=0x600008B  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x20
FIELDS:
  public            System.Int32                    key  // 0x10
  public            Beyond.Network.UIBusSender      <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60000AC  System.Void .ctor()
  RVA=0x092A6CB4  token=0x60000AD  System.Void <Send>b__0(Beyond.Network.NetResponse& resp)
  RVA=0x092A6DA0  token=0x60000AE  System.Void <Send>b__1(Beyond.Network.NetResponse& resp)
  RVA=0x092A6EFC  token=0x60000AF  System.Void <Send>b__2(Beyond.Network.NetResponse& resp)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x20
FIELDS:
  public            System.Int32                    key  // 0x10
  public            Beyond.Network.TeleportMaskSender<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60000B7  System.Void .ctor()
  RVA=0x092A6B20  token=0x60000B8  System.Void <Send>b__0(Beyond.Network.NetResponse& resp)
  RVA=0x030171F0  token=0x60000B9  System.Void <Send>b__1(Beyond.Network.NetResponse& resp)
  RVA=0x092A6B9C  token=0x60000BA  System.Void <Send>b__2(Beyond.Network.NetResponse& resp)
  RVA=0x092A6C18  token=0x60000BB  System.Void <Send>b__3(Beyond.Network.NetResponse& resp)
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000020
SIZE:  0x18
FIELDS:
  public            System.Action<System.Int32>     onError  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000C3  System.Void .ctor()
  RVA=0x092A6D30  token=0x60000C4  System.Void <Send>b__0(Beyond.Network.NetResponse& errorMsg)
  RVA=0x092A6E1C  token=0x60000C5  System.Void <Send>b__1(Beyond.Network.NetResponse& errorMsg)
  RVA=0x092A6E8C  token=0x60000C6  System.Void <Send>b__2(Beyond.Network.NetResponse& errorMsg)
END_CLASS

CLASS: <>c__DisplayClass18_0
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x18
FIELDS:
  public            System.Object                   target  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000DF  System.Void .ctor()
  RVA=0x026AD8D0  token=0x60000E0  System.Void <AutoRegisterMessageHandlers>b__0(System.Type msgType, System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200002A
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Network.NetUtil.<>c      <>9  // static @ 0x0
  public    static  System.Action<System.Type,System.Reflection.MethodInfo><>9__19_0  // static @ 0x8
METHODS:
  RVA=0x092A6F78  token=0x60000E1  System.Void .cctor()
  RVA=0x0350B670  token=0x60000E2  System.Void .ctor()
  RVA=0x092A6AAC  token=0x60000E3  System.Void <AutoUnRegisterMessageHandlers>b__19_0(System.Type msgType, System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: NetworkFrequency
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x20
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Single                   second  // 0x18
  public            System.Int32                    maxCount  // 0x1c
METHODS:
  RVA=0x0350B670  token=0x60000E5  System.Void .ctor()
END_CLASS

CLASS: MaskInfo
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x30
FIELDS:
  public            System.Int32                    key  // 0x10
  public            System.String                   name  // 0x18
  public            System.Single                   startTime  // 0x20
  public            System.Single                   delayTime  // 0x24
  public            System.Single                   timeoutTime  // 0x28
PROPERTIES:
  endTime  get=0x03D713D0
  showDecoTime  get=0x03D713E0
METHODS:
  RVA=0x03D713C0  token=0x60000FC  System.Void .ctor()
END_CLASS

CLASS: Config
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x20
FIELDS:
  public            System.String                   key  // 0x10
  public            Beyond.SerializeFieldDictionaryPaired<Proto.CSMessageID,Proto.SCMessageID>messages  // 0x18
METHODS:
  RVA=0x03CA7600  token=0x60000FE  System.Void .ctor()
END_CLASS

CLASS: EUrlType
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.NetworkUrls.EUrlTypeServerList  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGameLicense  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeAgeTips  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGateBulletin  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGameBulletin  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeLauncher  // const
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGov  // const
METHODS:
END_CLASS

CLASS: ErrorType
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HttpSender.ErrorTypeNONE  // const
  public    static  Beyond.Network.HttpSender.ErrorTypeTIMEOUT  // const
  public    static  Beyond.Network.HttpSender.ErrorTypeDNS_FAILED  // const
  public    static  Beyond.Network.HttpSender.ErrorTypeCANCELED  // const
  public    static  Beyond.Network.HttpSender.ErrorTypeINTERNAL  // const
METHODS:
END_CLASS

CLASS: Cancellation
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x20
FIELDS:
  private           System.Boolean                  m_isCancelled  // 0x10
  private           System.Action                   OnCancelInvoked  // 0x18
EVENTS:
  OnCancelInvoked  add=add_OnCancelInvoked  remove=remove_OnCancelInvoked
METHODS:
  RVA=0x0929F414  token=0x600013A  System.Void Cancel()
  RVA=0x0929F474  token=0x600013B  System.Boolean IsCanceled()
  RVA=0x0350B670  token=0x600013C  System.Void .ctor()
END_CLASS

CLASS: FGetOptions
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x30
FIELDS:
  public    static readonly Beyond.Network.HttpSender.FGetOptionsDEFAULT  // static @ 0x0
  public            System.Collections.Generic.Dictionary<System.String,System.String>headers  // 0x10
  public            System.String                   contentType  // 0x18
  public            System.Boolean                  headOnly  // 0x20
  public            Beyond.Network.HttpSender.Cancellationcancellation  // 0x28
METHODS:
  RVA=0x0350B670  token=0x600013D  System.Void .cctor()
END_CLASS

CLASS: FPostOptions
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x30
FIELDS:
  public    static readonly Beyond.Network.HttpSender.FPostOptionsDEFAULT  // static @ 0x0
  public            System.Collections.Generic.Dictionary<System.String,System.String>headers  // 0x10
  public            System.String                   textBody  // 0x18
  public            System.String                   contentType  // 0x20
  public            Beyond.Network.HttpSender.Cancellationcancellation  // 0x28
METHODS:
  RVA=0x0350B670  token=0x600013E  System.Void .cctor()
END_CLASS

CLASS: FSendFunc
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x68
FIELDS:
  public            System.String                   url  // 0x10
  public            System.Int32                    opt  // 0x18
  public            Beyond.Network.HttpSender.FGetOptionsoptionsGET  // 0x20
  public            Beyond.Network.HttpSender.FPostOptionsoptionsPOST  // 0x40
  public            System.Boolean                  editorOnly  // 0x60
METHODS:
  RVA=0x02C47510  token=0x600013F  UnityEngine.Networking.UnityWebRequest Invoke()
  RVA=0x02C474C0  token=0x6000140  Beyond.Network.HttpSender.Cancellation GetCancellation()
  RVA=0x0929F644  token=0x6000141  System.String GetOptMethod()
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x48
FIELDS:
  public            System.Int32                    respCode  // 0x10
  public            Beyond.Network.HttpSender.ErrorTypeerrorType  // 0x14
  public            System.Boolean                  isError  // 0x18
  public            System.Exception                exception  // 0x20
  public            System.String                   respText  // 0x28
  public            System.Byte[]                   respData  // 0x30
  public            System.String                   respError  // 0x38
  public            System.Boolean                  isServiceDone  // 0x40
METHODS:
  RVA=0x0350B670  token=0x6000142  System.Void .ctor()
END_CLASS

CLASS: TypedResult
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x60
EXTENDS: Result
FIELDS:
  private           System.Type                     <respType>k__BackingField  // 0x48
  public            System.Object                   respObject  // 0x50
  public            System.Boolean                  isDeserializeFailed  // 0x58
PROPERTIES:
  respType  get=0x03D4EA70  set=0x02692290
METHODS:
  RVA=0x02692290  token=0x6000145  System.Void .ctor(System.Type respType)
END_CLASS

CLASS: Result`1
TYPE:  class
TOKEN: 0x200003C
EXTENDS: TypedResult
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000146  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000147  TResp GetRespObject()
END_CLASS

CLASS: <YieldSendGet>d__16
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   url  // 0x20
  public            Beyond.Network.HttpSender.FGetOptionsoptions  // 0x28
  public            Beyond.Misc.ObjectRef           resultRef  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000148  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000149  System.Void System.IDisposable.Dispose()
  RVA=0x02F42B20  token=0x600014A  System.Boolean MoveNext()
  RVA=0x092A6FDC  token=0x600014C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <YieldSendGet>d__17`1
TYPE:  sealed class
TOKEN: 0x200003E
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            System.String                   url  // 0x0
  public            Beyond.Network.HttpSender.FGetOptionsoptions  // 0x0
  public            Beyond.Misc.ObjectRef           resultRef  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600014E  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x600014F  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000150  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000152  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <YieldSendGet>d__18
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Network.HttpSender.FGetOptionsoptions  // 0x20
  public            System.String                   url  // 0x40
  public            Beyond.Misc.ObjectRef           resultRef  // 0x48
  public            System.Type                     respType  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000154  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000155  System.Void System.IDisposable.Dispose()
  RVA=0x03765580  token=0x6000156  System.Boolean MoveNext()
  RVA=0x092A7028  token=0x6000158  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <YieldSendPost>d__19
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   url  // 0x20
  public            Beyond.Network.HttpSender.FPostOptionsoptions  // 0x28
  public            Beyond.Misc.ObjectRef           resultRef  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600015A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600015B  System.Void System.IDisposable.Dispose()
  RVA=0x092A7074  token=0x600015C  System.Boolean MoveNext()
  RVA=0x092A70DC  token=0x600015E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <YieldSendPost>d__20`1
TYPE:  sealed class
TOKEN: 0x2000041
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            System.String                   url  // 0x0
  public            Beyond.Network.HttpSender.FPostOptionsoptions  // 0x0
  public            Beyond.Misc.ObjectRef           resultRef  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000160  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000161  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000162  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000164  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <YieldSendPost>d__21
TYPE:  sealed class
TOKEN: 0x2000042
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Network.HttpSender.FPostOptionsoptions  // 0x20
  public            System.String                   url  // 0x40
  public            Beyond.Misc.ObjectRef           resultRef  // 0x48
  public            System.Type                     respType  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000166  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000167  System.Void System.IDisposable.Dispose()
  RVA=0x03765490  token=0x6000168  System.Boolean MoveNext()
  RVA=0x092A7128  token=0x600016A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_YieldSendHttpRequest>d__28
TYPE:  sealed class
TOKEN: 0x2000043
SIZE:  0xA0
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Network.HttpSender.FSendFuncsendFunc  // 0x20
  public            Beyond.Network.HttpSender.Resultresult  // 0x78
  private           Beyond.Network.HttpSender.Cancellation<cancelation>5__2  // 0x80
  private           System.Boolean                  <isCanceled>5__3  // 0x88
  private           UnityEngine.Networking.UnityWebRequest<request>5__4  // 0x90
  private           UnityEngine.Networking.UnityWebRequestAsyncOperation<sendOpt>5__5  // 0x98
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600016C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x092A71C0  token=0x600016D  System.Void System.IDisposable.Dispose()
  RVA=0x02C46410  token=0x600016E  System.Boolean MoveNext()
  RVA=0x02C47590  token=0x600016F  System.Void <>m__Finally1()
  RVA=0x092A7174  token=0x6000171  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_YieldSendHttpRequest>d__29
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x90
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Misc.ObjectRef           resultRef  // 0x20
  public            System.Type                     respType  // 0x28
  public            Beyond.Network.HttpSender.FSendFuncsendFunc  // 0x30
  private           Beyond.Network.HttpSender.Result<result>5__2  // 0x88
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000173  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000174  System.Void System.IDisposable.Dispose()
  RVA=0x02691FE0  token=0x6000175  System.Boolean MoveNext()
  RVA=0x092A7238  token=0x6000177  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass30_0
TYPE:  sealed class
TOKEN: 0x2000045
SIZE:  0x18
FIELDS:
  public            Beyond.Network.HttpSender.Resultresult  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000179  System.Void .ctor()
  RVA=0x092A6C94  token=0x600017A  Beyond.Network.HttpSender.Result <_WaitForSendHttpRequest>b__0()
END_CLASS

CLASS: <>c__DisplayClass31_0`1
TYPE:  sealed class
TOKEN: 0x2000046
FIELDS:
  public            Beyond.Network.HttpSender.Result<TResp>result  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600017B  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600017C  Beyond.Network.HttpSender.Result<TResp> <_WaitForSendHttpRequest>b__0()
END_CLASS

CLASS: <GetEnumerator>d__18
TYPE:  sealed class
TOKEN: 0x2000048
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           T                               <>2__current  // 0x0
  public            Beyond.Network.CircularBuffer<T><>4__this  // 0x0
  private           System.ArraySegment<T>[]        <>7__wrap1  // 0x0
  private           System.Int32                    <>7__wrap2  // 0x0
  private           System.ArraySegment<T>          <segment>5__4  // 0x0
  private           System.Int32                    <i>5__5  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<T>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000199  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x600019A  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x600019B  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x600019D  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass56_0
TYPE:  sealed class
TOKEN: 0x200004A
SIZE:  0x20
FIELDS:
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x10
  public            Beyond.Network.INetIO           tcpIO  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001D6  System.Void .ctor()
  RVA=0x038A22A0  token=0x60001D7  System.Void <ConnectAsync>b__0(System.Threading.Tasks.Task<System.Threading.Tasks.Task> task)
END_CLASS

CLASS: <>c__DisplayClass69_0
TYPE:  sealed class
TOKEN: 0x200004B
SIZE:  0x28
FIELDS:
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x10
  public            Beyond.Network.INetIO           tcp  // 0x18
  public            System.Int32                    nextid  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60001D8  System.Void .ctor()
  RVA=0x0397CEF0  token=0x60001D9  System.Threading.Tasks.Task <StartTCPMsgLoopThreadTask>b__0()
END_CLASS

CLASS: <_SessionThread>d__71
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x50
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x30
  public            Beyond.Network.INetIO           tcp  // 0x38
  public            System.Int32                    threadID  // 0x40
  private           System.Runtime.CompilerServices.TaskAwaiter<>u__1  // 0x48
METHODS:
  RVA=0x024C92A0  token=0x60001DA  System.Void MoveNext()
  RVA=0x036BB140  token=0x60001DB  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <_ReconnectCheckerTick>d__80
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x48
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x30
  public            Beyond.Network.INetIO           tcpIO  // 0x38
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x40
METHODS:
  RVA=0x02939C90  token=0x60001DC  System.Void MoveNext()
  RVA=0x036BB200  token=0x60001DD  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass81_0
TYPE:  sealed class
TOKEN: 0x200004E
SIZE:  0x30
FIELDS:
  public            Beyond.Network.INetIO           tcpIO  // 0x10
  public            System.String                   ip  // 0x18
  public            System.Int32                    port  // 0x20
  public            System.Int32                    sendTimeout  // 0x24
  public            System.Int32                    receiveBufferLen  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001DE  System.Void .ctor()
  RVA=0x0293E4A0  token=0x60001DF  System.Void <TryConnectWithTimeout>b__0()
END_CLASS

CLASS: <TryConnectWithTimeout>d__81
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x68
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean><>t__builder  // 0x18
  public            Beyond.Network.INetIO           tcpIO  // 0x30
  public            System.String                   ip  // 0x38
  public            System.Int32                    port  // 0x40
  public            System.Int32                    sendTimeout  // 0x44
  public            System.Int32                    receiveBufferLen  // 0x48
  public            System.Int32                    timeoutMilliseconds  // 0x4c
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x50
  private           System.Threading.Tasks.Task     <connectTask>5__2  // 0x58
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task><>u__1  // 0x60
METHODS:
  RVA=0x0293C4A0  token=0x60001E0  System.Void MoveNext()
  RVA=0x03891570  token=0x60001E1  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass82_0
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x18
FIELDS:
  public            Beyond.Network.INetIO           tcpIO  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001E2  System.Void .ctor()
  RVA=0x02943650  token=0x60001E3  System.Void <TryCloseTcpIOWithTimeout>b__0()
END_CLASS

CLASS: <TryCloseTcpIOWithTimeout>d__82
TYPE:  sealed struct
TOKEN: 0x2000051
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean><>t__builder  // 0x18
  public            Beyond.Network.INetIO           tcpIO  // 0x30
  public            System.Int32                    timeoutMilliseconds  // 0x38
  public            Beyond.Network.HGNetBaseSession <>4__this  // 0x40
  private           System.Threading.Tasks.Task     <closeTask>5__2  // 0x48
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task><>u__1  // 0x50
METHODS:
  RVA=0x0293C7D0  token=0x60001E4  System.Void MoveNext()
  RVA=0x03891500  token=0x60001E5  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: LoginErrorInfo
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x20
FIELDS:
  private           System.Int32                    <code>k__BackingField  // 0x10
  private           System.String                   <details>k__BackingField  // 0x18
PROPERTIES:
  code  get=0x03D4E340  set=0x010410F0
  details  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x02F0F020  token=0x600022A  System.Void SetErrorInvaild()
  RVA=0x092AF990  token=0x600022B  System.Void SetErrorConnectError()
  RVA=0x092AFA1C  token=0x600022C  System.Void SetErrorConnectTimeOut()
  RVA=0x02F0EAE0  token=0x600022D  System.Void Clear()
  RVA=0x092AFAA8  token=0x600022E  System.Void Set(System.Int32 code, System.String details)
  RVA=0x02F0EFD0  token=0x600022F  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.DoubleQueue`1
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Collections.Generic.Queue<T>m_readQueue  // 0x0
  private           System.Collections.Generic.Queue<T>m_writeQueue  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000007  System.Void LockingSwap()
  RVA=-1  // not resolved  token=0x6000008  System.Void TryLockingSwap()
  RVA=-1  // not resolved  token=0x6000009  System.Void Enqueue(T item)
  RVA=-1  // not resolved  token=0x600000A  System.Boolean TryDequeue(T& item)
  RVA=-1  // not resolved  token=0x600000B  System.Void EnqueueRange(System.Collections.Generic.List<T> list)
  RVA=-1  // not resolved  token=0x600000C  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.HGTcpClient
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Net.Sockets.Socket       m_ClientSocket  // 0x10
  private           System.Boolean                  m_Active  // 0x18
  private           System.Net.Sockets.NetworkStreamm_DataStream  // 0x20
  private           System.Net.Sockets.AddressFamilym_Family  // 0x28
  private           System.Boolean                  m_CleanedUp  // 0x2c
PROPERTIES:
  Client  get=0x020B7B20  set=0x0426FEE0
  Active  get=0x01002A50  set=0x01002B40
  Available  get=0x024CB8A0
  Connected  get=0x024CB510
  ExclusiveAddressUse  get=0x092A28D0  set=0x092A2964
  ReceiveBufferSize  get=0x092A2914  set=0x0293FA20
  SendBufferSize  get=0x092A293C  set=0x0293FA60
  ReceiveTimeout  get=0x092A2928  set=0x092A29B8
  SendTimeout  get=0x092A2950  set=0x0293FAA0
  LingerState  get=0x0293E810  set=0x092A2984
  NoDelay  get=0x092A28F0  set=0x0293FAE0
METHODS:
  RVA=0x0293F960  token=0x600000D  System.Void .ctor()
  RVA=0x092A273C  token=0x600000E  System.Void .ctor(System.String hostname, System.Int32 port)
  RVA=0x092A28A8  token=0x600000F  System.Void .ctor(System.Net.Sockets.Socket acceptedSocket)
  RVA=0x0293F080  token=0x6000018  System.Void Connect(System.String hostname, System.Int32 port)
  RVA=0x092A2494  token=0x6000019  System.Void Connect(System.Net.IPAddress address, System.Int32 port)
  RVA=0x0293E570  token=0x600001A  System.Void Connect(System.Net.IPEndPoint remoteEP)
  RVA=0x092A2414  token=0x600001B  System.Void Connect(System.Net.IPAddress[] ipAddresses, System.Int32 port)
  RVA=0x0295A810  token=0x600001C  System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  RVA=0x092A209C  token=0x600001D  System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  RVA=0x092A1FF4  token=0x600001E  System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  RVA=0x038A6D30  token=0x600001F  System.Void EndConnect(System.IAsyncResult asyncResult)
  RVA=0x092A2144  token=0x6000020  System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port)
  RVA=0x0293DA80  token=0x6000021  System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port)
  RVA=0x092A22AC  token=0x6000022  System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, System.Int32 port)
  RVA=0x024D1590  token=0x6000023  System.Net.Sockets.NetworkStream GetStream()
  RVA=0x02944150  token=0x6000024  System.Void Close()
  RVA=0x02943BC0  token=0x6000025  System.Void Dispose(System.Boolean disposing)
  RVA=0x02943B80  token=0x6000026  System.Void Dispose()
  RVA=0x092A2620  token=0x6000027  System.Void Finalize()
  RVA=0x0293F970  token=0x6000034  System.Void _Initialize()
  RVA=0x092A2694  token=0x6000035  System.Int32 _NumericOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName)
END_CLASS

CLASS: Beyond.Network.INetIO
TYPE:  interface
TOKEN: 0x200000A
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000036  System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  RVA=-1  // abstract  token=0x6000037  System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  RVA=-1  // abstract  token=0x6000038  System.Void Close()
  RVA=-1  // abstract  token=0x6000039  System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed)
  RVA=-1  // abstract  token=0x600003A  System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS)
  RVA=-1  // abstract  token=0x600003B  System.Boolean IsConnected()
  RVA=-1  // abstract  token=0x600003C  System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  RVA=-1  // abstract  token=0x600003D  System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  RVA=-1  // abstract  token=0x600003E  System.Boolean IsAuthed()
  RVA=-1  // abstract  token=0x600003F  System.Void MarkAuthed()
  RVA=-1  // abstract  token=0x6000040  System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv)
  RVA=-1  // abstract  token=0x6000041  System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  RVA=-1  // abstract  token=0x6000042  System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  RVA=-1  // abstract  token=0x6000043  System.Byte[] GetSendHeadBuffer()
  RVA=-1  // abstract  token=0x6000044  System.Byte[] GetSendBuffer()
  RVA=-1  // abstract  token=0x6000045  System.Byte[] GetReceiveBuffer()
  RVA=-1  // abstract  token=0x6000046  System.Int32 GetReceiveBufferOffset()
  RVA=-1  // abstract  token=0x6000047  System.Void ClearReceiveBufferOffset()
  RVA=-1  // abstract  token=0x6000048  System.Void SkipReceiveBufferOffset(System.Int32 len)
  RVA=-1  // abstract  token=0x6000049  System.Net.EndPoint GetEndPoint()
  RVA=-1  // abstract  token=0x600004A  System.Int32 Available()
END_CLASS

CLASS: Beyond.Network.NetMsgHandlerAttribute
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     msgType  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x600004B  System.Void .ctor(System.Type t)
  RVA=0x035ACAA0  token=0x600004C  System.Void .ctor()
  RVA=0x02D5B4A0  token=0x600004D  System.Type GetMsgType(System.Reflection.MethodInfo annotatedMethod)
END_CLASS

CLASS: Beyond.Network.NetResponseHandler
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x022B0690  token=0x600004E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600004F  System.Void Invoke(Beyond.Network.NetResponse& msg)
  RVA=0x092A3904  token=0x6000050  System.IAsyncResult BeginInvoke(Beyond.Network.NetResponse& msg, System.AsyncCallback callback, System.Object object)
  RVA=0x05B74E40  token=0x6000051  System.Void EndInvoke(Beyond.Network.NetResponse& msg, System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Network.NetMessageHandle`1
TYPE:  sealed class
TOKEN: 0x200000D
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000052  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000053  System.Void Invoke(T message)
  RVA=-1  // runtime  token=0x6000054  System.IAsyncResult BeginInvoke(T message, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000055  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Network.INetBusResponseListener
TYPE:  interface
TOKEN: 0x200000E
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000056  System.Void UpdateMsgTime(Beyond.Network.NetResponse resp)
END_CLASS

CLASS: Beyond.Network.NetRequest
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x28
FIELDS:
  public            System.UInt64                   csSeqID  // 0x10
  public            System.Int32                    mergeNum  // 0x18
  public            Google.Protobuf.IMessage        msg  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Network.NetResponse
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x30
FIELDS:
  public    static  Beyond.Network.NetResponse      EMPTY  // static @ 0x0
  public            Google.Protobuf.IMessage        headMsg  // 0x10
  public            Google.Protobuf.IMessage        msgBody  // 0x18
  public            System.Boolean                  isPacked  // 0x20
  public            System.Int64                    recvTimestamp  // 0x28
PROPERTIES:
  logHead  get=0x02944C20  set=0x042715A0
  csHead  get=0x024C8040  set=0x042715A0
  msgId  get=0x024C7FC0
  csSeqId  get=0x024C7260
  scSeqId  get=0x024C71E0
METHODS:
  RVA=0x0350B670  token=0x600005E  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.MessageHandleWrapper
TYPE:  abstract class
TOKEN: 0x2000011
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600005F  System.Void HandleMessage(Google.Protobuf.IMessage msg)
  RVA=0x0350B670  token=0x6000060  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.MessageHandleWrapper`1
TYPE:  class
TOKEN: 0x2000012
EXTENDS: Beyond.Network.MessageHandleWrapper
FIELDS:
  private   readonly Beyond.Network.NetMessageHandle<T>m_handle  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000061  System.Void .ctor(Beyond.Network.NetMessageHandle<T> handle)
  RVA=-1  // not resolved  token=0x6000062  System.Void HandleMessage(Google.Protobuf.IMessage msg)
END_CLASS

CLASS: Beyond.Network.NetBus
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x60
EXTENDS: Beyond.ExplicitSingleton`1
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.NetResponseHandler>m_msgHandlers  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Beyond.Network.NetBus.HandlerEntry>>m_msgWithSeqNumHandlers  // 0x18
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.MessageHandleWrapper>m_msgHdlWrappers  // 0x20
  private           Beyond.Network.HGNetSession     m_netSession  // 0x28
  private   static  System.Collections.Generic.List<Beyond.Network.NetResponseHandler>s_handlersToCall  // static @ 0x0
  private   readonly Beyond.Network.UIBusSender      <uiSender>k__BackingField  // 0x30
  private   readonly Beyond.Network.TeleportMaskSender<teleportMaskSender>k__BackingField  // 0x38
  private   readonly Beyond.Network.DisposableBusSender<defaultSender>k__BackingField  // 0x40
  private   readonly Beyond.Network.Special2BusSender<s2Sender>k__BackingField  // 0x48
  private   readonly Beyond.Network.InteractiveBusSender<interactiveSender>k__BackingField  // 0x50
  private   readonly Beyond.Network.FrequencyControlBusSender<frequencyControlSender>k__BackingField  // 0x58
PROPERTIES:
  uiSender  get=0x01003830
  teleportMaskSender  get=0x03D4E2A0
  defaultSender  get=0x03D4E2B0
  s2Sender  get=0x03D4EA70
  interactiveSender  get=0x03D4EAF0
  frequencyControlSender  get=0x03D4EAA0
  currentSessionID  get=0x092A3868
METHODS:
  RVA=0x0345E390  token=0x600006A  System.Void .ctor()
  RVA=0x092A3408  token=0x600006B  System.Boolean IsBusBusy()
  RVA=0x02F0F3C0  token=0x600006C  System.Void Setup(Beyond.Network.HGNetSession session)
  RVA=0x029464A0  token=0x600006D  System.Void Send(Google.Protobuf.IMessage msg)
  RVA=0x026AD5F0  token=0x600006E  System.Void RegisterMessageHandler(System.Int32 msgId, Beyond.Network.MessageHandleWrapper handler)
  RVA=0x092A3450  token=0x600006F  System.Void UnRegisterMessageHandler(System.Int32 msgId)
  RVA=0x092A30A0  token=0x6000070  System.Void HandleMessageTime(Beyond.Network.NetResponse response)
  RVA=0x092A3118  token=0x6000071  System.Void HandleMessage(Beyond.Network.NetResponse response)
  RVA=0x02946460  token=0x6000072  System.Boolean _ValidateSession()
  RVA=0x02F0F090  token=0x6000073  System.Void OnNetClientShutDown()
  RVA=0x029463A0  token=0x6000074  Beyond.Network.NetBus.ResultHandler _SendWithResult(Google.Protobuf.IMessage msg)
  RVA=0x092A3608  token=0x6000075  System.Void _Listen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler)
  RVA=0x092A373C  token=0x6000076  System.Void _UnListen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler)
  RVA=0x092A34D4  token=0x6000077  System.Object _ListenWithSeqNum(System.Int32 msgId, Beyond.Network.NetResponseHandler callback)
  RVA=0x02F11730  token=0x6000078  System.Void _UnListenWithSeqNum(System.Int32 msgId, System.Object token)
  RVA=0x03CE3790  token=0x6000079  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.Special2BusSender
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x38
EXTENDS: Beyond.Network.DisposableBusSender
IMPLEMENTS: Beyond.Network.INetBusResponseListener
FIELDS:
  public            System.Collections.Generic.Dictionary<System.UInt64,System.Double>sendedMsgWithTime  // 0x20
  public            System.Double                   minSendTime  // 0x28
  private           System.Single                   m_maxWaitTime  // 0x30
PROPERTIES:
  isBusBusy  get=0x02998950
METHODS:
  RVA=0x03924E20  token=0x600008D  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=0x092A6650  token=0x600008E  System.Void UpdateStartBlockTime()
  RVA=0x02F0FC70  token=0x600008F  System.Void OnNetShutDown()
  RVA=0x092A6544  token=0x6000090  System.Void Dispose()
  RVA=0x02F11860  token=0x6000091  System.Void _ClearSendTime()
  RVA=0x092A65A4  token=0x6000092  System.Void UpdateMsgTime(Beyond.Network.NetResponse resp)
  RVA=0x02DF5160  token=0x6000093  System.Void .ctor()
  RVA=0x0929FD28  token=0x6000094  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  RVA=0x092A659C  token=0x6000095  System.Void <>iFixBaseProxy_OnNetShutDown()
  RVA=0x0929FD20  token=0x6000096  System.Void <>iFixBaseProxy_Dispose()
END_CLASS

CLASS: Beyond.Network.InteractiveBusSender
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x40
EXTENDS: Beyond.Network.Special2BusSender
FIELDS:
  private           System.Single                   m_maxWaitTime  // 0x38
PROPERTIES:
  isBusBusy  get=0x02998920
METHODS:
  RVA=0x04276358  token=0x6000098  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.DisposableBusSender
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x20
EXTENDS: Sender
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Collections.Generic.HashSet<Beyond.Network.NetBus.ResultHandler>m_resultHandlers  // 0x10
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x18
PROPERTIES:
  isDisposed  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x02946270  token=0x600009B  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=0x02F10830  token=0x600009C  System.Void OnNetShutDown()
  RVA=0x0929F5F0  token=0x600009D  System.Void Dispose()
  RVA=0x02F10870  token=0x600009E  System.Void _Clear()
  RVA=0x02DF53B0  token=0x600009F  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetworkMaskConfigHolder
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.Dictionary<Proto.CSMessageID,Proto.SCMessageID>msgs  // 0x10
METHODS:
  RVA=0x0345E7E0  token=0x60000A0  System.Void Init()
  RVA=0x092A5A90  token=0x60000A1  System.Void Dispose()
  RVA=0x0345E760  token=0x60000A2  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.UIBusSender
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x30
EXTENDS: Beyond.Network.DisposableBusSender
FIELDS:
  private           Beyond.Network.NetworkMaskConfigHolder<config>k__BackingField  // 0x20
  private           System.Collections.Generic.HashSet<System.Int32>m_maskKeys  // 0x28
PROPERTIES:
  config  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0345E690  token=0x60000A5  System.Void .ctor()
  RVA=0x092A7284  token=0x60000A6  System.Void Dispose()
  RVA=0x092A7478  token=0x60000A7  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=0x02F0F540  token=0x60000A8  System.Void OnNetShutDown()
  RVA=0x0929FD20  token=0x60000A9  System.Void <>iFixBaseProxy_Dispose()
  RVA=0x0929FD28  token=0x60000AA  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  RVA=0x092A659C  token=0x60000AB  System.Void <>iFixBaseProxy_OnNetShutDown()
END_CLASS

CLASS: Beyond.Network.TeleportMaskSender
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x28
EXTENDS: Beyond.Network.DisposableBusSender
FIELDS:
  private           System.Collections.Generic.HashSet<System.Int32>m_maskKeys  // 0x20
METHODS:
  RVA=0x092A68D4  token=0x60000B0  System.Void Dispose()
  RVA=0x02F0FF40  token=0x60000B1  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=0x02F0F820  token=0x60000B2  System.Void OnNetShutDown()
  RVA=0x0345E610  token=0x60000B3  System.Void .ctor()
  RVA=0x0929FD20  token=0x60000B4  System.Void <>iFixBaseProxy_Dispose()
  RVA=0x0929FD28  token=0x60000B5  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  RVA=0x092A659C  token=0x60000B6  System.Void <>iFixBaseProxy_OnNetShutDown()
END_CLASS

CLASS: Beyond.Network.FrequencyControlBusSender
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x40
EXTENDS: Beyond.Network.DisposableBusSender
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<Proto.CSMessageID,System.Collections.Generic.Queue<System.Double>>m_lastSendTime  // 0x20
  private           System.Collections.Generic.List<Google.Protobuf.IMessage>m_waitingSendMsgs  // 0x28
  private           System.Collections.Generic.List<System.Action<System.Int32>>m_onError  // 0x30
  private           System.Int32                    m_loopId  // 0x38
METHODS:
  RVA=0x03238050  token=0x60000BC  System.Void .ctor()
  RVA=0x03456440  token=0x60000BD  System.Void _TrySendWaitingMsg()
  RVA=0x0929F7B0  token=0x60000BE  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  RVA=0x0929F820  token=0x60000BF  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg, System.Boolean needAddToWaitingList, System.Action<System.Int32> onError, System.Action onWait)
  RVA=0x0929F6F8  token=0x60000C0  System.Void Dispose()
  RVA=0x0929FD28  token=0x60000C1  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  RVA=0x0929FD20  token=0x60000C2  System.Void <>iFixBaseProxy_Dispose()
END_CLASS

CLASS: Beyond.Network.ServerDesc
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x28
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   addr  // 0x18
  public            System.Int32                    port  // 0x20
METHODS:
  RVA=0x0333BE60  token=0x60000C7  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.ServerList
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<Beyond.Network.ServerDesc>servers  // 0x10
METHODS:
  RVA=0x03CFC3F0  token=0x60000C8  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.ServerConfig
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x28
FIELDS:
  public            System.String                   serverName  // 0x10
  public            System.String                   uid  // 0x18
  public            System.Boolean                  checkDev  // 0x20
METHODS:
  RVA=0x092A64C4  token=0x60000C9  System.Boolean IsSame(Beyond.Network.ServerConfig other)
  RVA=0x03D21020  token=0x60000CA  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.HostData
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x28
FIELDS:
  public            System.String                   host  // 0x10
  public            System.Int32                    port  // 0x18
  public            System.Double                   delay  // 0x20
METHODS:
  RVA=0x0315C2B0  token=0x60000CB  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetConfig
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<Beyond.Network.HostData>hosts  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000CC  System.Void .ctor(System.Collections.Generic.List<Beyond.Network.HostData> hosts)
END_CLASS

CLASS: Beyond.Network.NetConsts
TYPE:  static class
TOKEN: 0x2000026
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   NETMASK_CONFIG_PATH  // static @ 0x0
  public    static readonly System.String                   NETMASK_PREFAB_PATH  // static @ 0x8
METHODS:
  RVA=0x03CDF500  token=0x60000CD  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.INetworkSystem
TYPE:  interface
TOKEN: 0x2000027
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60000CE  System.Void OnReConnect()
  RVA=-1  // abstract  token=0x60000CF  System.Void SendMsg(Google.Protobuf.IMessage msg, System.Action<System.Int32> onError)
END_CLASS

CLASS: Beyond.Network.NetUtil
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_isRegistedAllMessages  // static @ 0x0
  public    static readonly System.Int32                    MAX_RECEIVE_PACK_BODY_SIZE  // static @ 0x4
  public    static readonly System.Int32                    MAX_MERGE_PACK_BODY_SIZE  // static @ 0x8
  public    static readonly System.Int32                    MAX_SEND_PACK_BODY_SIZE  // static @ 0xc
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Type>s_sc_id2MessageType  // static @ 0x10
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>s_sc_messageType2Id  // static @ 0x18
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>s_cs_messageType2Id  // static @ 0x20
  private   static  System.Byte[]                   s_decompressedBuffer  // static @ 0x28
METHODS:
  RVA=0x02C34270  token=0x60000D0  System.Void RegisterSCMessage(System.Int32 msgId, System.Type msgType)
  RVA=0x02C33D50  token=0x60000D1  System.Void RegisterCSMessage(System.Int32 msgId, System.Type msgType)
  RVA=0x026AD6D0  token=0x60000D2  System.Int32 GetSCMsgIdByType(System.Type msgType)
  RVA=0x092A3AC4  token=0x60000D3  System.Type GetSCMsgTypeById(System.Int32 msgId)
  RVA=0x032BA2C0  token=0x60000D4  System.Int32 GetCSMsgIdByType(System.Type msgType)
  RVA=-1  // generic def  token=0x60000D5  System.Void _GenMessageName2ValuePair(System.Collections.Generic.Dictionary<System.String,System.Int32> dic)
  RVA=0x02C33E80  token=0x60000D6  System.Void FastRegisterMessage()
  RVA=0x029D2940  token=0x60000D7  System.Boolean GetNetMessageFromDataBytes(System.Span<System.Byte> headBytes, System.Byte[] bodyBuffer, System.Int32 offset, System.Int32 bodyLen, System.Byte[] packedbuffer, Beyond.Network.NetResponse& response)
  RVA=0x024D2BE0  token=0x60000D8  System.Int32 SerializeHeadMessage(Google.Protobuf.IMessage msg, System.UInt64 upSeqid, System.Int32 bodyLen, System.Int32 crc32, System.Byte[] buffer, System.Int32 offset)
  RVA=0x092A3B74  token=0x60000D9  System.Int32 SerializeBodyMessage(Google.Protobuf.IMessage msg, System.Byte[] buffer, System.Int32& crc32, System.Int32 offset)
  RVA=0x02D5B260  token=0x60000DA  System.Void AutoRegisterMessageHandlers(System.Object target)
  RVA=0x092A3984  token=0x60000DB  System.Void AutoUnRegisterMessageHandlers(System.Object target)
  RVA=0x02D5B360  token=0x60000DC  System.Void _ForeachMessageHandlers(System.Object target, System.Action<System.Type,System.Reflection.MethodInfo> doFunc)
  RVA=0x0350B670  token=0x60000DD  System.Void .ctor()
  RVA=0x037063D0  token=0x60000DE  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.NetworkFrequencyConfig
TYPE:  static class
TOKEN: 0x200002B
SIZE:  0x10
FIELDS:
  public    static  Beyond.SerializeFieldDictionary<System.Int32,Beyond.Network.NetworkFrequencyConfig.NetworkFrequency>msgs  // static @ 0x0
METHODS:
  RVA=0x092A3D64  token=0x60000E4  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.NetworkMask
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x60
EXTENDS: Beyond.Singleton`1
FIELDS:
  private           Beyond.TickFunction             m_preTickFunction  // 0x10
  private           System.Int32                    m_nextKey  // 0x18
  public            UnityEngine.GameObject          maskObj  // 0x20
  public            UnityEngine.GameObject          decoObj  // 0x28
  private           Beyond.Resource.FAssetProxyHandlem_handle  // 0x30
  private           System.Action<System.Boolean>   m_onNetMaskChanged  // 0x48
  private           System.Boolean                  <showingMask>k__BackingField  // 0x50
  private           System.Boolean                  <showingDeco>k__BackingField  // 0x51
  private           System.Boolean                  m_isNetReconnecting  // 0x52
  private   static  System.String                   DECO_NAME  // const
  private           System.Collections.Generic.List<Beyond.Network.NetworkMask.MaskInfo>m_masks  // 0x58
PROPERTIES:
  showingMask  get=0x03D4F000  set=0x03D4F030
  showingDeco  get=0x03D518F0  set=0x03D51900
METHODS:
  RVA=0x03807DC0  token=0x60000EA  System.Void .ctor()
  RVA=0x03807E60  token=0x60000EB  System.Void OnInit()
  RVA=0x092A5BC8  token=0x60000EC  System.Void OnUnInit()
  RVA=0x092A5C60  token=0x60000ED  System.Void Release()
  RVA=0x092A5E88  token=0x60000EE  System.Void _OnSwitchLanguage()
  RVA=0x038081A0  token=0x60000EF  System.Void _CreateTickFunction()
  RVA=0x092A5E24  token=0x60000F0  System.Void _ClearTickFunction()
  RVA=0x03017340  token=0x60000F1  System.Void PreTick(System.Single deltaTime)
  RVA=0x030171C0  token=0x60000F2  System.Int32 _GetKey()
  RVA=0x092A5B08  token=0x60000F3  System.Int32 AddMask(Proto.CSMessageID msgId, System.Single timeoutTime)
  RVA=0x030170C0  token=0x60000F4  System.Int32 AddMask(System.String name, System.Single timeoutTime, System.Single delayTime)
  RVA=0x03017270  token=0x60000F5  System.Void RemoveMask(System.Int32 key)
  RVA=0x03D713F0  token=0x60000F6  System.Void SetIsNetReconnecting(System.Boolean isReconnecting)
  RVA=0x03017410  token=0x60000F7  System.Void _UpdateMaskState()
  RVA=0x03A2FE20  token=0x60000F8  System.Void ListenOnNetMaskChanged(System.Action<System.Boolean> action)
  RVA=0x092A5D70  token=0x60000F9  System.Void UnListenOnNetMaskChanged(System.Action<System.Boolean> action)
END_CLASS

CLASS: Beyond.Network.NetworkMaskConfig
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            Beyond.SerializeFieldDictionary<Proto.CSMessageID,Proto.SCMessageID>msgs  // 0x18
  public            System.Collections.Generic.List<Beyond.Network.NetworkMaskConfig.Config>configs  // 0x20
METHODS:
  RVA=0x03C8A0F0  token=0x60000FD  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetworkUrls
TYPE:  static class
TOKEN: 0x2000031
SIZE:  0x10
FIELDS:
  public    static  System.String                   URL_GET_SPLIT  // const
METHODS:
  RVA=0x02C37520  token=0x60000FF  System.String RemoteConfigUrl()
  RVA=0x092A6288  token=0x6000100  System.String ResourceRootUrlDev(System.String version)
  RVA=0x02F42910  token=0x6000101  System.String ServerListUrl()
  RVA=0x092A6160  token=0x6000102  System.String AgeTipsUrl()
  RVA=0x092A61F4  token=0x6000103  System.String GovUrl()
  RVA=0x02C3DFE0  token=0x6000104  System.String LauncherUrl()
  RVA=0x02C3F990  token=0x6000105  System.String _SelectUrl(System.String urlInConfig, Beyond.Network.NetworkUrls.EUrlType urlType)
  RVA=0x02F42940  token=0x6000106  System.String _GetUrlFromLocal(Beyond.Network.NetworkUrls.EUrlType type)
END_CLASS

CLASS: Beyond.Network.TcpIO
TYPE:  class
TOKEN: 0x2000033
SIZE:  0x50
IMPLEMENTS: Beyond.Network.INetIO System.IDisposable
FIELDS:
  private           Beyond.Network.HGTcpClient      m_tcpClient  // 0x10
  protected         System.Byte[]                   m_recvBuffer  // 0x18
  protected         System.Byte[]                   m_sendHeadBuffer  // 0x20
  protected         System.Byte[]                   m_sendBuffer  // 0x28
  protected         System.Int32                    m_recvBufferOffset  // 0x30
  private           Beyond.XXEnc.XXE1               m_encryptor  // 0x38
  private           Beyond.XXEnc.XXE1               m_decryptor  // 0x40
  protected         System.Boolean                  m_isAuthed  // 0x48
  private           System.Boolean                  m_bIsTestDropSC  // 0x49
  private           System.Boolean                  m_bIsTestDropCS  // 0x4a
  private           System.Boolean                  m_bIsTestReconnectFailed  // 0x4b
  public    static  System.Int32                    SEND_HEAD_BUFFER_LENGTH  // const
  public    static  System.Int32                    s_MAX_SEND_SIZE  // static @ 0x0
METHODS:
  RVA=0x0293E650  token=0x6000107  System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  RVA=0x0293DC50  token=0x6000108  System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  RVA=0x024CC140  token=0x6000109  System.Boolean IsAuthed()
  RVA=0x02944CC0  token=0x600010A  System.Void MarkAuthed()
  RVA=0x039B3E60  token=0x600010B  System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv)
  RVA=0x092A6788  token=0x600010C  System.Net.EndPoint GetEndPoint()
  RVA=0x029436C0  token=0x600010D  System.Void Close()
  RVA=0x092A67F8  token=0x600010E  System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed)
  RVA=0x092A6864  token=0x600010F  System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS)
  RVA=0x024CB1A0  token=0x6000110  System.Boolean IsConnected()
  RVA=0x024D1080  token=0x6000111  System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  RVA=0x024D3190  token=0x6000112  System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  RVA=0x024D3160  token=0x6000113  System.Byte[] GetSendHeadBuffer()
  RVA=0x024D2290  token=0x6000114  System.Byte[] GetSendBuffer()
  RVA=0x024CBF80  token=0x6000115  System.Byte[] GetReceiveBuffer()
  RVA=0x03199FF0  token=0x6000116  System.Void ClearReceiveBufferOffset()
  RVA=0x024CB3A0  token=0x6000117  System.Int32 GetReceiveBufferOffset()
  RVA=0x031681D0  token=0x6000118  System.Void SkipReceiveBufferOffset(System.Int32 len)
  RVA=0x024D1450  token=0x6000119  System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  RVA=0x024D1320  token=0x600011A  System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  RVA=0x024CB700  token=0x600011B  System.Int32 Available()
  RVA=0x02943610  token=0x600011C  System.Void Dispose()
  RVA=0x02943480  token=0x600011D  System.Void Finalize()
  RVA=0x0350B670  token=0x600011E  System.Void .ctor()
  RVA=0x03D43AA0  token=0x600011F  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HttpSender
TYPE:  static class
TOKEN: 0x2000034
SIZE:  0x10
FIELDS:
  public    static  System.String                   CONTENT_TYPE_JSON  // const
  public    static  System.String                   CONTENT_ENCODING_GZIP  // const
  public    static  System.Int32                    ERROR_CODE_TIMEOUT  // const
  public    static  System.Int32                    ERROR_CODE_DNS_FAILED  // const
  public    static  System.Int32                    ERROR_CODE_DESERIALIZE  // const
  public    static  System.Single                   TIMEOUT_DEFAULT  // const
  private   static  System.Int32                    OPT_GET  // const
  private   static  System.Int32                    OPT_POST  // const
METHODS:
  RVA=0x02C36C00  token=0x6000120  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef)
  RVA=-1  // generic def  token=0x6000121  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef)
  RVA=0x02F42BA0  token=0x6000122  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef)
  RVA=0x092A2C84  token=0x6000123  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef)
  RVA=-1  // generic def  token=0x6000124  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef)
  RVA=0x039DC990  token=0x6000125  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef)
  RVA=0x092A2B88  token=0x6000126  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  RVA=0x092A29EC  token=0x6000127  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url)
  RVA=0x092A2A8C  token=0x6000128  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  RVA=-1  // generic def  token=0x6000129  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  RVA=-1  // generic def  token=0x600012A  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  RVA=0x02F429F0  token=0x600012B  System.Int32 GetGeneralErrorCode(Beyond.Network.HttpSender.Result result, System.Boolean& hasError)
  RVA=0x026921B0  token=0x600012C  System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  RVA=0x03765670  token=0x600012D  System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Misc.ObjectRef resultRef, Beyond.Network.HttpSender.FSendFunc sendFunc, System.Type respType)
  RVA=0x092A2ED8  token=0x600012E  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc)
  RVA=-1  // generic def  token=0x600012F  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc)
  RVA=0x038CEAA0  token=0x6000130  System.Void _StartWebRequestTask(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  RVA=0x03C90670  token=0x6000131  System.Void _WaitForServiceDone(Beyond.Network.HttpSender.Result result)
  RVA=0x02C47800  token=0x6000132  UnityEngine.Networking.UnityWebRequest _CreateWebRequestGET(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  RVA=0x02C47F30  token=0x6000133  UnityEngine.Networking.UnityWebRequest _CreateWebRequestPOST(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  RVA=0x02C47610  token=0x6000134  System.Void _SetHttpResult(Beyond.Network.HttpSender.Result result, UnityEngine.Networking.UnityWebRequest request)
  RVA=0x02692ED0  token=0x6000135  System.Void _DeserializeTypedResult(Beyond.Network.HttpSender.TypedResult result)
  RVA=0x092A2D6C  token=0x6000136  System.Void _DebugOnlyProfileResult(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  RVA=0x092A2E04  token=0x6000137  System.Void _MarkResultAsException(Beyond.Network.HttpSender.Result result, System.Exception ex)
END_CLASS

CLASS: Beyond.Network.CircularBuffer`1
TYPE:  class
TOKEN: 0x2000047
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IReadOnlyList`1 System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  private   readonly T[]                             m_buffer  // 0x0
  private           System.Int32                    m_end  // 0x0
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_start  // 0x0
PROPERTIES:
  Capacity  get=-1  // not resolved
  IsFull  get=-1  // not resolved
  IsEmpty  get=-1  // not resolved
  Count  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600017D  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600017E  System.Void .ctor(System.Int32 capacity, T[] items)
  RVA=-1  // not resolved  token=0x6000185  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000186  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000187  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000188  T Front()
  RVA=-1  // not resolved  token=0x6000189  System.Boolean TryFront(T& result)
  RVA=-1  // not resolved  token=0x600018A  T Back()
  RVA=-1  // not resolved  token=0x600018B  System.Boolean TryBack(T& result)
  RVA=-1  // not resolved  token=0x600018C  System.Void PushBack(T item)
  RVA=-1  // not resolved  token=0x600018D  System.Void PushFront(T item)
  RVA=-1  // not resolved  token=0x600018E  System.Void PopBack()
  RVA=-1  // not resolved  token=0x600018F  System.Void PopFront()
  RVA=-1  // not resolved  token=0x6000190  System.Boolean TryPopFront(T& result)
  RVA=-1  // not resolved  token=0x6000191  System.Boolean TryPopBack(T& result)
  RVA=-1  // not resolved  token=0x6000192  T[] ToArray()
  RVA=-1  // not resolved  token=0x6000193  System.Void _ThrowIfEmpty(System.String message)
  RVA=-1  // not resolved  token=0x6000194  System.Void _Increment(System.Int32& index)
  RVA=-1  // not resolved  token=0x6000195  System.Void _Decrement(System.Int32& index)
  RVA=-1  // not resolved  token=0x6000196  System.Int32 _InternalIndex(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000197  System.ArraySegment<T> _ArrayOne()
  RVA=-1  // not resolved  token=0x6000198  System.ArraySegment<T> _ArrayTwo()
END_CLASS

CLASS: Beyond.Network.HGNetBaseSession
TYPE:  abstract class
TOKEN: 0x2000049
SIZE:  0xC0
FIELDS:
  private           Beyond.Network.INetIO           m_tcpIO  // 0x10
  public    static  System.Int32                    s_recvBuffLen  // static @ 0x0
  public    static  System.Int32                    s_tcpSendTimeout  // static @ 0x4
  public    static  System.Int32                    s_sessionThreadSleepTimeMS  // static @ 0x8
  public    static  System.Int32                    s_sessionThreadPauseSleepTimeMS  // static @ 0xc
  public            System.Int32                    m_maxReconnectTimeout  // 0x18
  public            System.Int32                    m_maxReconnectTimes  // 0x1c
  public            System.Int32                    sendNumLimit  // 0x20
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse>m_recvQueue  // 0x28
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_sendQueue  // 0x30
  private   static  System.Int32                    MAX_RECYCLE_QUEUE_COUNT  // const
  protected         Beyond.Network.CircularBuffer<Beyond.Network.NetRequest>m_circularBuffer  // 0x38
  private           System.Int64                    m_csSeqId  // 0x40
  protected         System.Int64                    m_scSeqId  // 0x48
  protected         System.Threading.Tasks.Task     m_threadTask  // 0x50
  protected         System.Int32                    m_threadTaskSignalID  // 0x58
  protected         Beyond.ELogChannel              m_logChannel  // 0x5c
  protected         System.Boolean                  m_isSyncFullDataEnd  // 0x5d
  protected         Google.Protobuf.IMessage        m_lastLoginMsg  // 0x60
  private           System.String                   m_lastConnectServerIp  // 0x68
  private           System.Int32                    m_lastConnectServerPort  // 0x70
  protected         System.Int32                    m_tryReconnectTimes  // 0x74
  protected         System.Boolean                  m_isAutoReconnect  // 0x78
  protected         System.Int64                    m_startReconnectTimestampMS  // 0x80
  protected         System.Int32                    m_closeNetMsgID  // 0x88
  public    static  System.Int32                    INVALID_SESSION_ID  // static @ 0x10
  protected static  System.Int32                    s_sessionIDGenerator  // static @ 0x14
  private           System.Int32                    <sessionID>k__BackingField  // 0x8c
  protected         Beyond.Network.HGNetSessionConnectYieldm_lastAsyncConnectHandle  // 0x90
  protected         Beyond.Network.EHGNetSessionStatem_state  // 0x98
  private           Beyond.Network.EHGNetSessionReconnectStatem_reconnectState  // 0x99
  protected         System.Double                   m_startReconnectTimeMS  // 0xa0
  protected         System.Int32                    m_closeErrorCode  // 0xa8
  public    static  System.Boolean                  s_applicationIsPaused  // static @ 0x18
  private           System.Int64                    m_clientLastReceiveMsgMilliTs  // 0xb0
  private           System.Int64                    m_clientLastSendMsgMilliTs  // 0xb8
PROPERTIES:
  sessionID  get=0x03D4F3D0  set=0x03D4F420
  reconnectState  get=0x03D6E080  set=0x02944CF0
  isRunning  get=0x024C6600
  isConnecting  get=0x092A0130
  isRunningAndConnected  get=0x024C6690
  isReconnecting  get=0x024C6FA0
  closeErrorCode  get=0x03D51860
  isAutoReconnect  get=0x03D4F800
  maxRecycleQueueCount  get=0x03D5A950
METHODS:
  RVA=0x029430F0  token=0x60001AA  System.Void Start()
  RVA=0x0929FD30  token=0x60001AB  System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect)
  RVA=0x0293D1B0  token=0x60001AC  System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle)
  RVA=0x038A22D0  token=0x60001AD  System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, Beyond.Network.INetIO tcpIO)
  RVA=-1  // abstract  token=0x60001AE  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  RVA=0x0293DFE0  token=0x60001AF  System.Void _DNSCheck(System.String serverIp)
  RVA=0x0267B3E0  token=0x60001B0  System.Void Close(Beyond.Network.ENetCloseReason netCloseReason)
  RVA=0x092A00B4  token=0x60001B1  System.Void InternalClose(Beyond.Network.INetIO tcpIO, Beyond.Network.ENetCloseReason netCloseReason)
  RVA=0x029432A0  token=0x60001B2  System.Void InternalClose(Beyond.Network.INetIO tcpIO, System.Int32 netCloseReason)
  RVA=0x02947280  token=0x60001B3  System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg)
  RVA=0x024CCFD0  token=0x60001B4  System.Int32 GetSendQueueMsgCount()
  RVA=0x02947240  token=0x60001B5  System.Int64 IncrementCSSeqID()
  RVA=0x02F0D690  token=0x60001B6  System.Void SetCSSeqID(System.Int64 id)
  RVA=0x092A0064  token=0x60001B7  System.Int64 GetCSSeqID()
  RVA=0x02F0D630  token=0x60001B8  Beyond.Network.INetIO GetIO()
  RVA=0x0293D780  token=0x60001B9  System.Void StartTCPMsgLoopThreadTask()
  RVA=0x029441B0  token=0x60001BA  System.Void CloseTCPMsgThreadTask()
  RVA=0x0397CF20  token=0x60001BB  System.Threading.Tasks.Task _SessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID)
  RVA=0x024CC200  token=0x60001BC  System.Boolean _SendAndCheckMessage(Beyond.Network.INetIO tcp, System.Int32 threadID)
  RVA=0x024C8290  token=0x60001BD  System.Boolean _ReadAndCheckMessageInSessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID)
  RVA=-1  // abstract  token=0x60001BE  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  RVA=-1  // abstract  token=0x60001BF  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m)
  RVA=-1  // abstract  token=0x60001C0  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  RVA=0x024CAD30  token=0x60001C1  System.Void SessionCheckSignalAndSleep(System.Int32 threadID)
  RVA=0x02D75B70  token=0x60001C2  System.Void OpenAutoReconnect()
  RVA=0x02943450  token=0x60001C3  System.Void RemoveAutoReconnect()
  RVA=0x024C8FA0  token=0x60001C4  System.Threading.Tasks.Task _ReconnectCheckerTick(Beyond.Network.INetIO tcpIO)
  RVA=0x032F8460  token=0x60001C5  System.Threading.Tasks.Task<System.Boolean> TryConnectWithTimeout(Beyond.Network.INetIO tcpIO, System.String ip, System.Int32 port, System.Int32 sendTimeout, System.Int32 receiveBufferLen, System.Int32 timeoutMilliseconds)
  RVA=0x032F85D0  token=0x60001C6  System.Threading.Tasks.Task<System.Boolean> TryCloseTcpIOWithTimeout(Beyond.Network.INetIO tcpIO, System.Int32 timeoutMilliseconds)
  RVA=-1  // abstract  token=0x60001C7  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  RVA=-1  // abstract  token=0x60001C8  System.Boolean NeedKeepConnect()
  RVA=-1  // abstract  token=0x60001C9  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  RVA=-1  // abstract  token=0x60001CA  System.Void InitClientRSAKey()
  RVA=-1  // abstract  token=0x60001CB  System.Void ClearRSAKey()
  RVA=-1  // abstract  token=0x60001CC  System.Void ClearRecvQueue()
  RVA=-1  // abstract  token=0x60001CD  System.Void ClearSendQueue()
  RVA=0x024C8D50  token=0x60001CE  System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount)
  RVA=0x024CC720  token=0x60001CF  System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount)
  RVA=-1  // abstract  token=0x60001D0  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  RVA=-1  // abstract  token=0x60001D1  System.Void ClearPingWDG()
  RVA=-1  // abstract  token=0x60001D2  System.Boolean IsPingOut()
  RVA=-1  // abstract  token=0x60001D3  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  RVA=0x02F0EDC0  token=0x60001D4  System.Void .ctor()
  RVA=0x03CC52F0  token=0x60001D5  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetSession
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x168
EXTENDS: Beyond.Network.HGNetBaseSession
FIELDS:
  private           System.String                   m_uid  // 0xc0
  private           System.String                   m_token  // 0xc8
  private           System.Int32                    m_channel  // 0xd0
  public    static  System.Int32                    LOGIN_TIMEOUT  // static @ 0x0
  public    static  System.Int32                    MAX_CLIENT_RESEND_NUM  // static @ 0x4
  public    static  System.Single                   PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS  // static @ 0x8
  public    static  System.Single                   PER_FRAME_RECEIVED_MESSAGES_TIME  // static @ 0xc
  public    static  System.Single                   MESSAGE_MAX_DELAY_TIME  // static @ 0x10
  protected         System.Int32                    m_messageDelayCount  // 0xd4
  protected         System.Int64                    m_logCDTimestamp  // 0xd8
  private   static  System.Boolean                  s_HGNetSessionBurst  // static @ 0x14
  private   readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_frameSendQueue  // 0xe0
  private           System.Collections.Generic.Queue<Beyond.Network.NetRequest>m_mergeQueueCache  // 0xe8
  private           System.Object                   m_frameSendQueueLocker  // 0xf0
  private           System.Byte[]                   m_frameSendPacketBuffer  // 0xf8
  private           System.Byte[]                   m_frameSendPacketHeadBuffer  // 0x100
  private           System.Byte[]                   m_frameSendPacketTempBuffer  // 0x108
  private           System.Byte[]                   m_frameSendCryptoBuffer  // 0x110
  private           System.Byte[]                   m_frameReceivePacketBuffer  // 0x118
  public    static  System.Int64                    s_maxframeSendPacketBuffer  // static @ 0x18
  public    static  System.Int64                    s_maxPackedMessageNum  // static @ 0x20
  protected readonly System.Collections.Generic.Queue<Beyond.Network.NetResponse>m_callbackQueue  // 0x120
  private           Beyond.Network.HGNetSessionLoginYieldm_currLoginHandle  // 0x128
  private   static  System.Int32                    SEND_PING_DELTA_TICK_TIME_MS  // const
  private   static  System.Int32                    s_pingWdgOutTimes  // static @ 0x28
  private   static  System.Int32                    s_pingSyncFullEndBeforeTimes  // static @ 0x2c
  private           System.Int64                    m_needSendPingTimer  // 0x130
  private           System.Int32                    m_pingWDG  // 0x138
  private           System.Int64                    m_clientTsDelayms  // 0x140
  private           System.Int32                    m_pingValue  // 0x148
  private           System.Boolean                  m_isPingInProgress  // 0x14c
  private           System.Int64                    m_isPingInProgressStartTime  // 0x150
  private   static readonly System.String                   CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT  // static @ 0x30
  private   static readonly System.String                   CLIENT_NET_RSA_PUBLIC_KEY  // static @ 0x38
  private   static readonly System.String                   CLIENT_NET_RSA_PRIVATE_KEY  // static @ 0x40
  private   static  System.Byte[]                   s_clientPublicKeyBytes  // static @ 0x48
  private           System.Security.Cryptography.RSAm_rsaClientPrivateProvider  // 0x158
  private   static readonly System.Byte[]                   EMPTY_BYTES  // static @ 0x50
  private   static  System.Int32                    s_CacheLogLength  // static @ 0x58
  private           System.Text.StringBuilder       m_sbCache  // 0x160
METHODS:
  RVA=0x0229B650  token=0x60001E6  System.Void SetAutoReconnectToken(System.String uid, System.String token, System.Int32 channel)
  RVA=0x02FCABF0  token=0x60001E7  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  RVA=0x092A0204  token=0x60001E8  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  RVA=0x03A614C0  token=0x60001E9  System.Void Start()
  RVA=0x092A0938  token=0x60001EA  System.Void OnApplicationPause(System.Boolean pause)
  RVA=0x02946500  token=0x60001EB  System.UInt64 SendMessage(Google.Protobuf.IMessage msg)
  RVA=0x092A0A8C  token=0x60001EC  System.Void PackMessageToSendQueue()
  RVA=0x092A1204  token=0x60001ED  System.Void UpdateInGameThread()
  RVA=0x092A11E4  token=0x60001EE  System.Void TailLateUpdateInGameThread()
  RVA=0x092A1268  token=0x60001EF  System.Single _GetMessageTimeLimit()
  RVA=0x092A1C64  token=0x60001F0  System.Void _ProcessReceivedMessagesInGameThread(System.Boolean flushAll)
  RVA=0x0229CE50  token=0x60001F1  Beyond.Network.HGNetSessionLoginYield LoginAsync(System.String uid, System.String token, System.Int32 channel)
  RVA=0x02F42E90  token=0x60001F2  System.Void _CSLoginHelper_UpdateAppInfo(Proto.MSG_A1 msg)
  RVA=0x02F432D0  token=0x60001F3  System.String _GetOnlineResVersion()
  RVA=0x02F42650  token=0x60001F4  Proto.ENV_TYPE _GetSDKEnv()
  RVA=0x02F42AF0  token=0x60001F5  Proto.CLIENT_PLATFORM_TYPE _GetPlatformID()
  RVA=0x02F42A60  token=0x60001F6  System.Int32 _GetPayPlatform()
  RVA=0x02F0D2B0  token=0x60001F7  System.Void _SessionLoginThreadTask(System.Object handle)
  RVA=0x02D75AC0  token=0x60001F8  System.Void StartMsgLoop()
  RVA=0x03D48E60  token=0x60001F9  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  RVA=0x092A0A20  token=0x60001FA  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  RVA=0x02FCACE0  token=0x60001FB  System.Boolean NeedKeepConnect()
  RVA=0x032BA150  token=0x60001FC  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& req)
  RVA=0x024D2DD0  token=0x60001FD  System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& request, System.Boolean useSRSA)
  RVA=0x024CD2A0  token=0x60001FE  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  RVA=0x024CA720  token=0x60001FF  System.Boolean _ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp, System.Boolean useSRSA)
  RVA=0x024C6FB0  token=0x6000200  System.Void ClearRecvQueue()
  RVA=0x03D00680  token=0x6000201  System.Void ClearSendQueue()
  RVA=0x092A1190  token=0x6000202  System.Void SetBurstMode(System.Boolean val)
  RVA=0x03CFA670  token=0x6000203  System.Void Finalize()
  RVA=0x024C64F0  token=0x6000204  System.Int32 GetPing()
  RVA=0x092A08E8  token=0x6000205  System.Boolean IsPingInProgress()
  RVA=0x03559D50  token=0x6000206  System.Int64 GetPingPassedTime()
  RVA=0x034564F0  token=0x6000207  System.Void ClearPingWDG()
  RVA=0x02F0D6D0  token=0x6000208  System.Void _ApproximateLoginServerTime(System.Int64 serverTimeMS, System.Int32 serverZone)
  RVA=0x031DA430  token=0x6000209  System.Boolean _HandleSpecialMessagePing(Beyond.Network.NetResponse m)
  RVA=0x024CCE60  token=0x600020A  System.Boolean IsPingOut()
  RVA=0x024CD3A0  token=0x600020B  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  RVA=0x0229D780  token=0x600020C  System.Byte[] GetClientPublicKey()
  RVA=0x031854A0  token=0x600020D  System.Void InitClientRSAKey()
  RVA=0x03187930  token=0x600020E  System.Byte[] _RSADecrypt(System.Byte[] data)
  RVA=0x092A013C  token=0x600020F  System.Void ClearRSAKey()
  RVA=0x024C7660  token=0x6000210  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& msg)
  RVA=0x092A1570  token=0x6000211  System.Boolean _HandleSpecialMessageReconnectIncr(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  RVA=0x092A13C8  token=0x6000212  System.Boolean _HandleSpecialMessageReconnectFull(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  RVA=0x092A12E8  token=0x6000213  System.Boolean _HandleSpecialMessageErrorCode(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  RVA=0x092A1AC8  token=0x6000214  System.Boolean _HandleSpecialMessageReconnectLogin(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  RVA=0x03187610  token=0x6000215  System.Void _HandleLoginEncryp(Beyond.Network.INetIO netIO, Proto.MSG_B1 msg)
  RVA=0x02F0EB50  token=0x6000216  System.Void .ctor()
  RVA=0x03A27930  token=0x6000217  System.Void .cctor()
  RVA=0x092A11FC  token=0x6000218  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.Network.EHGNetSessionState
TYPE:  sealed struct
TOKEN: 0x2000053
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Network.EHGNetSessionStateClosed  // const
  public    static  Beyond.Network.EHGNetSessionStateOpened  // const
  public    static  Beyond.Network.EHGNetSessionStateConnecting  // const
  public    static  Beyond.Network.EHGNetSessionStateSessionRunning  // const
METHODS:
END_CLASS

CLASS: Beyond.Network.EHGNetSessionReconnectState
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Network.EHGNetSessionReconnectStateNone  // const
  public    static  Beyond.Network.EHGNetSessionReconnectStateReconnectingTcp  // const
  public    static  Beyond.Network.EHGNetSessionReconnectStateSendLogin  // const
  public    static  Beyond.Network.EHGNetSessionReconnectStateResendPack  // const
METHODS:
END_CLASS

CLASS: Beyond.Network.ENetCloseReason
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.ENetCloseReason  Invalid  // const
  public    static  Beyond.Network.ENetCloseReason  None  // const
  public    static  Beyond.Network.ENetCloseReason  ForServerErrorMax  // const
  public    static  Beyond.Network.ENetCloseReason  ConnectFailed  // const
  public    static  Beyond.Network.ENetCloseReason  ServerReconnectFailed  // const
  public    static  Beyond.Network.ENetCloseReason  TooMuchClientReconnectPack  // const
  public    static  Beyond.Network.ENetCloseReason  ServerReconnectFullPack  // const
  public    static  Beyond.Network.ENetCloseReason  ClientShutDown  // const
  public    static  Beyond.Network.ENetCloseReason  ClientLaunch  // const
  public    static  Beyond.Network.ENetCloseReason  ClientReconnectTooMuchTimes  // const
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetSessionUtils
TYPE:  static class
TOKEN: 0x2000056
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x092A9F08  token=0x6000219  System.Boolean CheckErrorNeedsDisconnect(Proto.CODE errorCode)
END_CLASS

CLASS: Beyond.Network.HGNetSessionConstant
TYPE:  static class
TOKEN: 0x2000057
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    CODE_SUC  // const
  public    static  System.Int32                    CODE_CONN_FAILED  // const
  public    static  System.Int32                    CODE_CONN_WAIT  // const
METHODS:
END_CLASS

CLASS: Beyond.Network.ENetConnectErrorCode
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.ENetConnectErrorCodeInvalid  // const
  public    static  Beyond.Network.ENetConnectErrorCodeNone  // const
  public    static  Beyond.Network.ENetConnectErrorCodeForServerErrorMax  // const
  public    static  Beyond.Network.ENetConnectErrorCodeConnectError  // const
  public    static  Beyond.Network.ENetConnectErrorCodeTimeOut  // const
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetSessionLoginYield
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x38
EXTENDS: UnityEngine.CustomYieldInstruction
FIELDS:
  private           Beyond.Network.HGNetSessionLoginYield.LoginErrorInfom_loginErrorInfo  // 0x10
  private           System.Boolean                  m_bIsFinish  // 0x18
  private           Proto.MSG_A1                    m_request  // 0x20
  private           Proto.MSG_B1                    m_resp  // 0x28
  private           System.Object                   m_locker  // 0x30
PROPERTIES:
  isSucceed  get=0x0229C1D0
  keepWaiting  get=0x03D032E0
METHODS:
  RVA=0x02F0EF20  token=0x600021A  System.Void .ctor()
  RVA=0x02F0E970  token=0x600021B  System.Void .ctor(Proto.MSG_A1 req)
  RVA=0x02F0D660  token=0x600021C  Proto.MSG_A1 GetRequest()
  RVA=0x0229C5A0  token=0x600021D  Proto.MSG_B1 GetResponse()
  RVA=0x092A9B40  token=0x600021E  System.Int32 GetErrorCode()
  RVA=0x092A9B98  token=0x600021F  System.String GetErrorDetails()
  RVA=0x02F0E780  token=0x6000220  System.Void SetSucceed(Proto.MSG_B1 sc)
  RVA=0x092A9CE8  token=0x6000221  System.Void SetNtfError(System.Int32 ntfErrorCode, System.String ntfErrorDetails)
  RVA=0x092A9BF0  token=0x6000222  System.Void SetConnectErrorError()
  RVA=0x092A9E10  token=0x6000223  System.Void SetTimeOutError()
END_CLASS

CLASS: Beyond.Network.HGNetSessionConnectYield
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x20
EXTENDS: UnityEngine.CustomYieldInstruction
FIELDS:
  private           System.Threading.Tasks.Task     m_connectTask  // 0x10
  private           Beyond.Network.ENetConnectErrorCodeconnectErrorCode  // 0x18
PROPERTIES:
  isSucceed  get=0x0229C590
  keepWaiting  get=0x03CB5470
METHODS:
  RVA=0x03D50330  token=0x6000230  System.Void .ctor()
  RVA=0x030840F0  token=0x6000231  System.Void .ctor(System.Threading.Tasks.Task connectTask)
  RVA=0x092A9AF4  token=0x6000232  System.Int32 GetCode()
  RVA=0x038A2420  token=0x6000233  System.Void SetFinish(Beyond.Network.ENetConnectErrorCode code)
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLogBaseSession
TYPE:  abstract class
TOKEN: 0x200005C
SIZE:  0x98
FIELDS:
  private   readonly Beyond.Network.INetIO           m_tcpIO  // 0x10
  public    static  System.Int32                    s_recvBuffLen  // static @ 0x0
  public    static  System.Int32                    s_tcpSendTimeout  // static @ 0x4
  public    static  System.Int32                    s_sessionThreadSleepTimeMS  // static @ 0x8
  public    static  System.Int32                    s_sessionThreadPauseSleepTimeMS  // static @ 0xc
  public    static  System.Int32                    s_maxReconnectTimeout  // static @ 0x10
  public    static  System.Int32                    s_maxReconnectTimes  // static @ 0x14
  protected         System.Int32                    m_sendNumLimit  // 0x18
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse>m_recvQueue  // 0x20
  private   readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_sendQueue  // 0x28
  private   static  System.Int32                    MAX_RECYCLE_QUEUE_COUNT  // const
  protected         Beyond.Network.CircularBuffer<Beyond.Network.NetRequest>m_circularBuffer  // 0x30
  private           System.Int64                    m_csSeqId  // 0x38
  protected         System.Int64                    m_scSeqId  // 0x40
  protected         System.Threading.Tasks.Task     m_threadTask  // 0x48
  protected         System.Int32                    m_threadTaskSignal  // 0x50
  protected         Beyond.ELogChannel              m_logChannel  // 0x54
  private           System.String                   m_lastConnectServerIp  // 0x58
  private           System.Int32                    m_lastConnectServerPort  // 0x60
  protected         System.Int32                    m_tryReconnectTimes  // 0x64
  protected         System.Int64                    m_startReconnectTimestampMS  // 0x68
  protected         System.Boolean                  m_isAutoReconnect  // 0x70
  protected         Beyond.Network.HGNetSessionConnectYieldm_lastAsyncConnectHandle  // 0x78
  protected         Beyond.Network.EHGNetSessionStatem_state  // 0x80
  protected         Beyond.Network.EHGNetSessionReconnectStatem_reconnectState  // 0x81
  protected         System.Int32                    m_closeErrorCode  // 0x84
  public    static  System.Boolean                  s_applicationIsPaused  // static @ 0x18
  private           System.Int64                    m_clientLastReceiveMsgMilliTs  // 0x88
  private           System.Int64                    m_clientLastSendMsgMilliTs  // 0x90
PROPERTIES:
  isRunning  get=0x092A9584
  isConnecting  get=0x092A956C
  isRunningAndConnected  get=0x092A9578
  closeErrorCode  get=0x03D4F370
  isAutoReconnect  get=0x03D4F260
METHODS:
  RVA=0x092A89EC  token=0x600023B  System.Void Start()
  RVA=0x092A7EA4  token=0x600023C  System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect)
  RVA=0x092A7B0C  token=0x600023D  System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle)
  RVA=0x092A8530  token=0x600023E  System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction)
  RVA=-1  // abstract  token=0x600023F  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  RVA=0x092A8B30  token=0x6000240  System.Void _DNSCheck(System.String serverIp)
  RVA=0x092A78A8  token=0x6000241  System.Void Close(Beyond.Network.ENetCloseReason netCloseReason)
  RVA=0x092A790C  token=0x6000242  System.Void Close(System.Int32 netCloseReason)
  RVA=0x092A8188  token=0x6000243  System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg)
  RVA=0x092A82DC  token=0x6000244  System.Int32 GetSendQueueMsgCount()
  RVA=0x092A8358  token=0x6000245  System.Int64 IncrementCSSeqID()
  RVA=0x092A87CC  token=0x6000246  System.Void SetCSSeqID(System.Int64 id)
  RVA=0x092A823C  token=0x6000247  System.Int64 GetCSSeqID()
  RVA=0x092A828C  token=0x6000248  Beyond.Network.INetIO GetIO()
  RVA=0x092A8828  token=0x6000249  System.Void StartTCPMsgLoopThreadTask()
  RVA=0x092A77C8  token=0x600024A  System.Void CloseTCPMsgThreadTask()
  RVA=0x092A8FB0  token=0x600024B  System.Void _SessionThread()
  RVA=-1  // abstract  token=0x600024C  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  RVA=-1  // abstract  token=0x600024D  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m)
  RVA=-1  // abstract  token=0x600024E  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  RVA=0x092A8704  token=0x600024F  System.Void SessionCheckSignalAndSleep()
  RVA=0x092A8668  token=0x6000250  System.Void OpenAutoReconnect()
  RVA=0x092A86B8  token=0x6000251  System.Void RemoveAutoReconnect()
  RVA=0x092A8CEC  token=0x6000252  System.Void _ReconnectCheckerTick()
  RVA=-1  // abstract  token=0x6000253  System.Void OnReconnectTimesOver()
  RVA=-1  // abstract  token=0x6000254  System.Boolean NeedKeepConnect()
  RVA=-1  // abstract  token=0x6000255  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  RVA=-1  // abstract  token=0x6000256  System.Void InitClientRSAKey()
  RVA=-1  // abstract  token=0x6000257  System.Void ClearRSAKey()
  RVA=0x092A83B0  token=0x6000258  System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount)
  RVA=0x092A8464  token=0x6000259  System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount)
  RVA=-1  // abstract  token=0x600025A  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  RVA=-1  // abstract  token=0x600025B  System.Void ClearPingWDG()
  RVA=-1  // abstract  token=0x600025C  System.Boolean IsPingOut()
  RVA=-1  // abstract  token=0x600025D  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  RVA=0x092A9424  token=0x600025E  System.Void .ctor()
  RVA=0x092A9370  token=0x600025F  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLogger
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x38
IMPLEMENTS: Beyond.Log.ILogger
FIELDS:
  private           Beyond.Log.BitArray256          m_enabledLogChannel  // 0x10
  private           System.Collections.Concurrent.ConcurrentQueue<Beyond.Log.FLogMessage>m_logMessagesQueue  // 0x30
  public    static  System.Int32                    s_maxLogQueueSize  // static @ 0x0
  public    static  System.Int32                    s_maxRepeatedMsgMs  // static @ 0x4
  public    static  System.Int32                    s_maxRepeatedMsgCount  // static @ 0x8
METHODS:
  RVA=0x0261BA80  token=0x6000260  System.Void Log(Beyond.Log.FLogMessage& msg)
  RVA=0x032F5020  token=0x6000261  Beyond.Network.HGNetLogger.LogLevel ConvertFromDLogger(Beyond.ELogLevel level)
  RVA=0x032F5080  token=0x6000262  Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLoggerV2(Beyond.ELogLevel level)
  RVA=0x03283950  token=0x6000263  System.Boolean CheckLog(Beyond.Log.FLogMessage& msg)
  RVA=0x0388DD60  token=0x6000264  System.Void Clear()
  RVA=0x092A9A3C  token=0x6000265  System.Void SetLogChannel(System.UInt64 channel1, System.UInt64 channel2, System.UInt64 channel3, System.UInt64 channel4)
  RVA=0x0335D9A0  token=0x6000266  System.Int32 ConvertFromDLogger(Beyond.ELogChannel channel)
  RVA=0x03B2C9E0  token=0x6000267  System.Void .ctor()
  RVA=0x03D20A30  token=0x6000268  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerClient
TYPE:  class
TOKEN: 0x200005E
SIZE:  0x30
FIELDS:
  private   static  Beyond.Network.HGNetLogger.HGNetLoggerClients_instance  // static @ 0x0
  private   static  System.Int64                    <s_roleID>k__BackingField  // static @ 0x8
  public            Beyond.Network.HGNetLogger.HGNetLoggerSessionm_logsession  // 0x10
  private           Beyond.Network.HGNetLogger.HGNetLoggerm_netLogger  // 0x18
  public    static readonly System.Int32                    MAX_LOG_SEND_QUEUE_SIZE  // static @ 0x10
  private   static  System.Int32                    MAX_LOCAL_LOG_QUEUE_SIZE  // const
  private   readonly System.Collections.Generic.Queue<Beyond.Log.FLogMessage>m_localLogQueue  // 0x20
  private   readonly System.Object                   m_queueLock  // 0x28
  public    static  Beyond.Network.HGNetLogger.Versions_usedVersion  // static @ 0x14
PROPERTIES:
  instance  get=0x029456A0
  s_roleID  get=0x092A9658  set=0x092A96A8
METHODS:
  RVA=0x03CABDF0  token=0x6000269  System.Void .ctor()
  RVA=0x02C3FB70  token=0x600026D  System.Void Init(System.String uid, System.String token, System.String env, System.String roleId)
  RVA=0x0367C070  token=0x600026E  System.Void AddLog(System.String message, System.String stacktrace, UnityEngine.LogType type)
  RVA=0x0367C840  token=0x600026F  System.Void _FlushLocalLogQueue()
  RVA=0x092A9590  token=0x6000270  System.Void OnApplicationPause(System.Boolean pauseStatus)
  RVA=0x02C35120  token=0x6000271  System.Void ShutDown()
  RVA=0x0267B150  token=0x6000272  System.Void _CloseAndClear(Beyond.Network.ENetCloseReason reason)
  RVA=0x02946870  token=0x6000273  System.Void WriteNetLog(Beyond.Network.HGNetLogger.LogMessage& log)
  RVA=0x037601E0  token=0x6000274  System.Void SetRoleID(System.UInt64 roleID)
  RVA=0x03D48E90  token=0x6000275  System.Void SetNetLogMaskFromServer(Google.Protobuf.Collections.RepeatedField<System.UInt64> masks)
  RVA=0x03D2C2B0  token=0x6000276  System.Void .cctor()
  RVA=0x0388DD40  token=0x6000277  System.Void <Init>b__15_0()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerCloudSettings
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x30
FIELDS:
  public    static readonly Beyond.Network.HGNetLogger.HGNetLoggerCloudSettingsinstance  // static @ 0x0
  private           Beyond.Network.HGNetLogger.LogControlm_cloudLogControl  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_cloudChannelLevelMaskTables  // 0x18
  private           Beyond.Network.HGNetLogger.LogControlm_localLogControl  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_localChannelLevelMaskTables  // 0x28
  private   static  System.Collections.Generic.List<Beyond.Network.HGNetLogger.NativeLogLevel>s_allLevels  // static @ 0x8
METHODS:
  RVA=0x029474D0  token=0x6000278  System.Void SetCloudLogControl(Beyond.Network.HGNetLogger.AuthResponse control, Beyond.Network.HGNetBaseSession session)
  RVA=0x0367CF20  token=0x6000279  System.Boolean IsNetLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel)
  RVA=0x02947300  token=0x600027A  System.Boolean IsNetLogLevelEnabled(Beyond.Network.HGNetLogger.NativeLogLevel level, System.Int32 channel)
  RVA=0x092A9700  token=0x600027B  System.Boolean IsLocalLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel)
  RVA=0x0367CFA0  token=0x600027C  Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLogger(Beyond.ELogLevel level)
  RVA=0x039C0490  token=0x600027D  System.Void .ctor()
  RVA=0x039C0330  token=0x600027E  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerSession
TYPE:  class
TOKEN: 0x2000060
SIZE:  0xF8
EXTENDS: Beyond.Network.HGNetBaseSession
FIELDS:
  private           System.Byte[]                   m_keyBytes  // 0xc0
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>m_templeCRCDict  // 0xc8
  private           System.Action                   m_onReconnectSuccess  // 0xd0
  private           System.String                   m_uid  // 0xd8
  private           System.String                   m_roleId  // 0xe0
  private           System.String                   m_token  // 0xe8
  private           System.String                   m_env  // 0xf0
  private   static  System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType>s_m_messageType2Id  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type>s_m_messageId2Type  // static @ 0x8
PROPERTIES:
  uid  get=0x03D4E7B0
  roleId  get=0x03D51140
  s_messageType2Id  get=0x024D26A0
  s_messageId2Type  get=0x03828370
METHODS:
  RVA=0x024D2620  token=0x6000283  System.Boolean TryGetMsgTypeByID(System.Type msgType, Beyond.Network.HGNetLogger.MessageType& type)
  RVA=0x03CFE560  token=0x6000284  System.Void Start()
  RVA=0x03D1C320  token=0x6000285  System.Void SetReconnectSuccessCallback(System.Action onReconnectSuccess)
  RVA=0x092A9880  token=0x6000286  System.Void OnApplicationPause(System.Boolean pause)
  RVA=0x02D75B10  token=0x6000287  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  RVA=0x024CC990  token=0x6000288  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  RVA=0x02944A00  token=0x6000289  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  RVA=0x024D28E0  token=0x600028A  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  RVA=0x024D1AD0  token=0x600028B  System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest request)
  RVA=0x029469C0  token=0x600028C  System.UInt64 SendMessage(Google.Protobuf.IMessage msg)
  RVA=0x03CA8270  token=0x600028D  System.Void SetAutoReconnectToken(System.String uid, System.String token, System.String env, System.String roleId)
  RVA=0x024CD0D0  token=0x600028E  System.Boolean NeedKeepConnect()
  RVA=0x02944910  token=0x600028F  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  RVA=0x024CDC10  token=0x6000290  System.Int32 _GetConnectTimeoutTime()
  RVA=0x024CD980  token=0x6000291  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  RVA=0x03B6CCC0  token=0x6000292  System.Void ClearPingWDG()
  RVA=0x02945E40  token=0x6000293  System.Void SendLogin(Beyond.Network.INetIO netIO)
  RVA=0x034A9C90  token=0x6000294  System.Boolean IsPingOut()
  RVA=0x03091F30  token=0x6000295  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  RVA=0x03D45040  token=0x6000296  System.Void InitClientRSAKey()
  RVA=0x092A983C  token=0x6000297  System.Void ClearRSAKey()
  RVA=0x03D450A0  token=0x6000298  System.Void ClearRecvQueue()
  RVA=0x03D45070  token=0x6000299  System.Void ClearSendQueue()
  RVA=0x092A9980  token=0x600029A  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  RVA=0x02F0EA30  token=0x600029B  System.Void .ctor()
  RVA=0x092A11FC  token=0x600029C  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000003  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000005  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000061
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x600029D  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x05163BA0  token=0x600029E  System.Void __Gen_Wrap_0(System.Object P0, System.Object P1)
  RVA=0x054A1028  token=0x600029F  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x092AB3E4  token=0x60002A0  System.IAsyncResult __Gen_Wrap_2(System.Object P0, System.Object P1, System.Int32 P2, System.Object P3, System.Object P4)
  RVA=0x092ABC30  token=0x60002A1  System.Threading.Tasks.Task __Gen_Wrap_3(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x092AC94C  token=0x60002A2  System.Net.Sockets.NetworkStream __Gen_Wrap_4(System.Object P0)
  RVA=0x04274234  token=0x60002A3  System.Void __Gen_Wrap_5(System.Object P0)
  RVA=0x05477860  token=0x60002A4  System.Void __Gen_Wrap_6(System.Object P0, System.Boolean P1)
  RVA=0x092AE2D4  token=0x60002A5  System.Net.Sockets.LingerOption __Gen_Wrap_7(System.Object P0)
  RVA=0x0561B0C4  token=0x60002A6  System.Int32 __Gen_Wrap_8(System.Object P0, System.Net.Sockets.SocketOptionLevel P1, System.Net.Sockets.SocketOptionName P2)
  RVA=0x050EF614  token=0x60002A7  System.Int32 __Gen_Wrap_9(System.Object P0)
  RVA=0x0514EF5C  token=0x60002A8  System.Boolean __Gen_Wrap_10(System.Object P0)
  RVA=0x0516CA20  token=0x60002A9  System.Int64 __Gen_Wrap_11(System.Object P0)
  RVA=0x092AA6A0  token=0x60002AA  System.UInt64 __Gen_Wrap_12(System.Object P0, System.Object P1)
  RVA=0x092AA78C  token=0x60002AB  System.Type __Gen_Wrap_13(System.Int32 P0)
  RVA=0x0514F720  token=0x60002AC  System.Void __Gen_Wrap_14(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x0549D548  token=0x60002AD  System.Void __Gen_Wrap_15(System.Object P0, System.Int32 P1)
  RVA=0x092AA878  token=0x60002AE  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_16(System.Object P0, System.Object P1)
  RVA=0x092AA984  token=0x60002AF  System.Void __Gen_Wrap_17(System.Object P0, Beyond.Network.NetResponse& P1)
  RVA=0x092AAAB0  token=0x60002B0  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_18(System.Object P0, Proto.SCMessageID P1, System.Object P2)
  RVA=0x0560138C  token=0x60002B1  System.Void __Gen_Wrap_19(System.Object P0, Proto.SCMessageID P1, System.Object P2)
  RVA=0x092AABD4  token=0x60002B2  System.Int32 __Gen_Wrap_20(System.Object P0, System.Object P1, System.Single P2, System.Single P3)
  RVA=0x092AACEC  token=0x60002B3  System.Int32 __Gen_Wrap_21(System.Object P0, Proto.CSMessageID P1, System.Single P2)
  RVA=0x092AADE0  token=0x60002B4  System.Void __Gen_Wrap_22(Beyond.Network.NetResponse& P0)
  RVA=0x092AAEDC  token=0x60002B5  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_23(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4)
  RVA=0x092AB024  token=0x60002B6  System.Boolean __Gen_Wrap_24(System.Object P0, System.Object P1)
  RVA=0x05161B54  token=0x60002B7  System.Void __Gen_Wrap_25(System.Int32 P0, System.Object P1)
  RVA=0x050F3444  token=0x60002B8  System.Void __Gen_Wrap_26()
  RVA=0x092AB0FC  token=0x60002B9  System.Boolean __Gen_Wrap_27(System.Span<System.Byte> P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Object P4, Beyond.Network.NetResponse& P5)
  RVA=0x092AB2B0  token=0x60002BA  System.Int32 __Gen_Wrap_28(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Object P4, System.Int32 P5)
  RVA=0x050EF54C  token=0x60002BB  System.Void __Gen_Wrap_29(System.Type P0, System.Reflection.MethodInfo P1)
  RVA=0x050F0008  token=0x60002BC  System.Void __Gen_Wrap_30(System.Object P0, System.Single P1)
  RVA=0x092AB528  token=0x60002BD  System.String __Gen_Wrap_31()
  RVA=0x092AB5F4  token=0x60002BE  System.String __Gen_Wrap_32(System.Object P0)
  RVA=0x092AB6E4  token=0x60002BF  System.String __Gen_Wrap_33(Beyond.Network.NetworkUrls.EUrlType P0)
  RVA=0x092AB7D0  token=0x60002C0  System.String __Gen_Wrap_34(System.Object P0, Beyond.Network.NetworkUrls.EUrlType P1)
  RVA=0x092AB8DC  token=0x60002C1  System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  RVA=0x092ABA00  token=0x60002C2  System.Threading.Tasks.Task __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  RVA=0x05150B1C  token=0x60002C3  System.Void __Gen_Wrap_37(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x092ABB54  token=0x60002C4  System.Net.EndPoint __Gen_Wrap_38(System.Object P0)
  RVA=0x05646F78  token=0x60002C5  System.Void __Gen_Wrap_39(System.Object P0, System.Boolean P1, System.Boolean P2)
  RVA=0x092ABD54  token=0x60002C6  System.Void __Gen_Wrap_40(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  RVA=0x092ABE5C  token=0x60002C7  System.Byte[] __Gen_Wrap_41(System.Object P0)
  RVA=0x056275C8  token=0x60002C8  System.Int32 __Gen_Wrap_42(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  RVA=0x092ABF4C  token=0x60002C9  Beyond.Network.HttpSender.Cancellation __Gen_Wrap_43(Beyond.Network.HttpSender.FSendFunc& P0)
  RVA=0x092AC0FC  token=0x60002CA  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_44(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1)
  RVA=0x092AC234  token=0x60002CB  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_45(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1)
  RVA=0x092AC36C  token=0x60002CC  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_46(Beyond.Network.HttpSender.FSendFunc& P0)
  RVA=0x092AC51C  token=0x60002CD  System.Collections.IEnumerator __Gen_Wrap_47(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1)
  RVA=0x092AC678  token=0x60002CE  System.Collections.IEnumerator __Gen_Wrap_48(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1, System.Object P2)
  RVA=0x092AC7EC  token=0x60002CF  System.Collections.IEnumerator __Gen_Wrap_49(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2, System.Object P3)
  RVA=0x092ACA3C  token=0x60002D0  System.Collections.IEnumerator __Gen_Wrap_50(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2)
  RVA=0x092ACB8C  token=0x60002D1  System.Collections.IEnumerator __Gen_Wrap_51(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2, System.Object P3)
  RVA=0x092ACCEC  token=0x60002D2  System.Collections.IEnumerator __Gen_Wrap_52(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2)
  RVA=0x092ACE2C  token=0x60002D3  System.Void __Gen_Wrap_53(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1)
  RVA=0x092ACF68  token=0x60002D4  Beyond.Network.HttpSender.Result __Gen_Wrap_54()
  RVA=0x092AD020  token=0x60002D5  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_55(Beyond.Network.HttpSender.FSendFunc P0)
  RVA=0x092AD150  token=0x60002D6  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_56(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1)
  RVA=0x092AD278  token=0x60002D7  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_57(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1)
  RVA=0x092AD3A0  token=0x60002D8  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_58(System.Object P0)
  RVA=0x092AD47C  token=0x60002D9  System.Int32 __Gen_Wrap_59(System.Object P0, System.Boolean& P1)
  RVA=0x092AD588  token=0x60002DA  System.String __Gen_Wrap_60(Beyond.Network.HttpSender.FSendFunc& P0)
  RVA=0x0563E0E0  token=0x60002DB  System.Void __Gen_Wrap_61(System.Object P0, Beyond.Network.EHGNetSessionReconnectState P1)
  RVA=0x054A1028  token=0x60002DC  System.Void __Gen_Wrap_62(System.Object P0, System.Object P1, Beyond.Network.ENetCloseReason P2)
  RVA=0x092AD728  token=0x60002DD  System.Boolean __Gen_Wrap_63(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3)
  RVA=0x0549D548  token=0x60002DE  System.Void __Gen_Wrap_64(System.Object P0, Beyond.Network.ENetConnectErrorCode P1)
  RVA=0x0549D548  token=0x60002DF  System.Void __Gen_Wrap_65(System.Object P0, Beyond.Network.ENetCloseReason P1)
  RVA=0x050EE850  token=0x60002E0  System.Void __Gen_Wrap_66(System.Threading.Tasks.Task<System.Threading.Tasks.Task> P0)
  RVA=0x092AD830  token=0x60002E1  System.Boolean __Gen_Wrap_67(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3, Beyond.Network.HGNetSessionConnectYield& P4)
  RVA=0x092AD9A0  token=0x60002E2  System.Void __Gen_Wrap_68(System.Object P0, Beyond.Network.NetRequest P1)
  RVA=0x05606CE4  token=0x60002E3  System.Void __Gen_Wrap_69(System.Object P0, System.Int64 P1)
  RVA=0x092ADABC  token=0x60002E4  Beyond.Network.INetIO __Gen_Wrap_70(System.Object P0)
  RVA=0x092ADBAC  token=0x60002E5  System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_71(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x092ADCD0  token=0x60002E6  System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_72(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6)
  RVA=0x092ADE34  token=0x60002E7  System.Threading.Tasks.Task __Gen_Wrap_73(System.Object P0, System.Object P1)
  RVA=0x092ADF40  token=0x60002E8  System.Void __Gen_Wrap_74(System.Object P0, System.Object P1, System.Int64 P2, System.Int32 P3)
  RVA=0x05E685F4  token=0x60002E9  System.Boolean __Gen_Wrap_75(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x092AE048  token=0x60002EA  System.Threading.Tasks.Task __Gen_Wrap_76()
  RVA=0x05E3E6A8  token=0x60002EB  System.Void __Gen_Wrap_77(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  RVA=0x092AE100  token=0x60002EC  System.Void __Gen_Wrap_78(System.Object P0, System.Object P1, System.Int64 P2, System.Int64 P3)
  RVA=0x092AE208  token=0x60002ED  System.Byte[] __Gen_Wrap_79()
  RVA=0x050EF068  token=0x60002EE  Proto.CLIENT_PLATFORM_TYPE __Gen_Wrap_80()
  RVA=0x050EF068  token=0x60002EF  Proto.ENV_TYPE __Gen_Wrap_81()
  RVA=0x050EF068  token=0x60002F0  System.Int32 __Gen_Wrap_82()
  RVA=0x092AE3C4  token=0x60002F1  System.Void __Gen_Wrap_83(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2, System.Boolean P3)
  RVA=0x092AE558  token=0x60002F2  System.Boolean __Gen_Wrap_84(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2, System.Boolean P3)
  RVA=0x092AE6C8  token=0x60002F3  System.Void __Gen_Wrap_85(System.Object P0, System.Int64 P1, System.Int32 P2)
  RVA=0x092AE7C0  token=0x60002F4  System.Byte[] __Gen_Wrap_86(System.Object P0, System.Object P1)
  RVA=0x092AE8CC  token=0x60002F5  Proto.MSG_A1 __Gen_Wrap_87(System.Object P0)
  RVA=0x092AE9BC  token=0x60002F6  Beyond.Network.HGNetSessionLoginYield __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  RVA=0x092AEAF0  token=0x60002F7  System.Void __Gen_Wrap_89(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2)
  RVA=0x092AEC74  token=0x60002F8  System.Boolean __Gen_Wrap_90(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2)
  RVA=0x092AEDD8  token=0x60002F9  System.Boolean __Gen_Wrap_91(System.Object P0, Beyond.Network.NetResponse P1)
  RVA=0x08706E14  token=0x60002FA  System.Void __Gen_Wrap_92(System.Object P0, System.Object P1, System.Int64 P2)
  RVA=0x0514DE88  token=0x60002FB  System.Boolean __Gen_Wrap_93(Proto.CODE P0)
  RVA=0x092AEF00  token=0x60002FC  System.Boolean __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.Network.NetResponse P2)
  RVA=0x092AF040  token=0x60002FD  System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2)
  RVA=0x092AF1C0  token=0x60002FE  Proto.MSG_B1 __Gen_Wrap_96(System.Object P0)
  RVA=0x092AF2B0  token=0x60002FF  System.Boolean __Gen_Wrap_97(System.Object P0, Beyond.Log.FLogMessage& P1)
  RVA=0x0562802C  token=0x6000300  Beyond.Network.HGNetLogger.LogLevel __Gen_Wrap_98(Beyond.ELogLevel P0)
  RVA=0x056280E8  token=0x6000301  Beyond.Network.HGNetLogger.NativeLogLevel __Gen_Wrap_99(Beyond.ELogLevel P0)
  RVA=0x0562802C  token=0x6000302  System.Int32 __Gen_Wrap_100(Beyond.ELogChannel P0)
  RVA=0x0560DC74  token=0x6000303  System.Boolean __Gen_Wrap_101(Beyond.Network.HGNetLogger.NativeLogLevel P0, System.Int32 P1)
  RVA=0x05164540  token=0x6000304  System.Boolean __Gen_Wrap_102(Beyond.ELogLevel P0, Beyond.ELogChannel P1)
  RVA=0x056479C0  token=0x6000305  System.Void __Gen_Wrap_103(System.Object P0, System.Object P1, System.Object P2, UnityEngine.LogType P3)
  RVA=0x092A9F70  token=0x6000306  Beyond.Network.HGNetLogger.HGNetLoggerClient __Gen_Wrap_104()
  RVA=0x092AA03C  token=0x6000307  System.Void __Gen_Wrap_105(System.Object P0, Beyond.Network.HGNetLogger.LogMessage& P1)
  RVA=0x092AA150  token=0x6000308  System.Void __Gen_Wrap_106(System.Object P0, Beyond.Log.FLogMessage& P1)
  RVA=0x092AA2C4  token=0x6000309  System.Void __Gen_Wrap_107(System.Object P0, System.UInt64 P1, System.UInt64 P2, System.UInt64 P3, System.UInt64 P4)
  RVA=0x05476DB4  token=0x600030A  System.Void __Gen_Wrap_108(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  RVA=0x050F0C14  token=0x600030B  System.Void __Gen_Wrap_109(System.Boolean P0)
  RVA=0x0514E6A4  token=0x600030C  System.Void __Gen_Wrap_110(System.UInt64 P0)
  RVA=0x092AA3D4  token=0x600030D  System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_111()
  RVA=0x092AA4A0  token=0x600030E  System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> __Gen_Wrap_112()
  RVA=0x05786028  token=0x600030F  System.Boolean __Gen_Wrap_113(System.Object P0, Beyond.Network.HGNetLogger.MessageType& P1)
  RVA=0x092AA56C  token=0x6000310  System.Void __Gen_Wrap_114(System.Object P0, System.Object P1, Beyond.Network.NetRequest P2)
  RVA=0x03D05C60  token=0x6000311  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000062
SIZE:  0x60
EXTENDS: IFix.Core.AnonymousStorey
IMPLEMENTS: System.IDisposable System.Collections.IEnumerator System.Collections.Generic.IEnumerator`1 System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4c
  private           System.Int32                    methodId_4  // 0x50
  private           System.Int32                    methodId_5  // 0x54
  private           System.Int32                    methodId_6  // 0x58
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x092AF744
  System.Collections.IEnumerator.Current  get=0x092AF7F0
METHODS:
  RVA=0x05152EA8  token=0x6000312  System.Void System.IDisposable.Dispose()
  RVA=0x05152C48  token=0x6000313  System.Boolean MoveNext()
  RVA=0x05152D80  token=0x6000315  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x092AF434  token=0x6000317  System.Void MoveNext()
  RVA=0x092AF694  token=0x6000318  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0)
  RVA=0x092AF89C  token=0x6000319  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x092AF558  token=0x600031A  System.Void RefAwaitUnsafeOnCompleteMethod()
  RVA=0x092AF4C4  token=0x600031B  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x600031C  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x092AFD08  token=0x600031D  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x024CB460  token=0x600031E  System.Boolean IsPatched(System.Int32 id)
  RVA=0x092AFBC4  token=0x600031F  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x092AFC90  token=0x6000320  System.Object CreateWrapper(System.Int32 id)
  RVA=0x092AFD6C  token=0x6000321  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x092AFB20  token=0x6000322  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x2000064
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect2  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect3  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect2  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-EndConnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync2  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-GetStream0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Close0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Dispose1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-get_LingerState0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-_Initialize0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-_NumericOption0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-get_currentSessionID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Setup0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_ValidateSession0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-IncrementCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SendMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetSCMsgTypeById0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-RegisterMessageHandler0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-UnRegisterMessageHandler0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-OnNetClientShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_SendWithResult0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_Listen0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_UnListen0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_UnListenWithSeqNum0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-_HandleMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-OnResponse0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoSend0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoListen0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoUnListen0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-_Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-OnNetShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-_ClearSendTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-OnNetShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMaskConfigHolder-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMaskConfigHolder-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_UpdateMaskState0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-RemoveMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetCSMsgIdByType0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_GetKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-AddMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-AddMask1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-OnNetShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TeleportMaskSender-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TeleportMaskSender-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TeleportMaskSender-OnNetShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Send0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Send1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-ServerConfig-IsSame0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-RegisterSCMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-RegisterCSMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetSCMsgIdByType0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-FastRegisterMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetNetMessageFromDataBytes0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-SerializeHeadMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-AutoRegisterMessageHandlers0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-_ForeachMessageHandlers0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-PreTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_CreateTickFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_OnSwitchLanguage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_ClearTickFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-OnUnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-Release0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-ListenOnNetMaskChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-RemoteConfigUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-ResourceRootUrlDev0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-_GetUrlFromLocal0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-ServerListUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-_SelectUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-AgeTipsUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-GovUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-LauncherUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-IsConnected0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Close0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Connect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ConnectAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-IsAuthed0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-MarkAuthed0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-EnableCryptStream0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetEndPoint0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-TestCloseNetIO0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-TestDropNetIO0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-WriteData0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-WriteCryptoData0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetSendHeadBuffer0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetSendBuffer0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetReceiveBuffer0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ClearReceiveBufferOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetReceiveBufferOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-SkipReceiveBufferOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ReadData0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ReadCryptoData0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Available0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-GetCancellation0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_CreateWebRequestGET0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_CreateWebRequestPOST0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-Invoke0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-Cancellation-IsCanceled0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_SetHttpResult0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_MarkResultAsException0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_YieldSendHttpRequest0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_DeserializeTypedResult0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_YieldSendHttpRequest1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendGet0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendGet1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendPost0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendPost1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_WaitForServiceDone0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_StartWebRequestTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_WaitForSendHttpRequest0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendPost0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendGet0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendGet1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-GetGeneralErrorCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_DebugOnlyProfileResult0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-Cancellation-Cancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-GetOptMethod0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-set_reconnectState0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_DNSCheck0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-InternalClose0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-InternalClose1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Connect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-SetFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Close0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-ConnectAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-EnqueueSendMsg0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-SetCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetIO0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_SessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-OpenAutoReconnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SetAutoReconnectToken0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-GetClientPublicKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetOnlineResVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetPlatformID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetSDKEnv0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetPayPlatform0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_WriteMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_ReadMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_ApproximateLoginServerTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_RSADecrypt0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleLoginEncryp0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-DoReconnectLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnApplicationPause0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetRequest0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetSucceed0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetNtfError0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_SessionLoginThreadTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-LoginAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-StartMsgLoop0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnConnectedSucceed0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnReconnectTimesOver0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-NeedKeepConnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-CheckAndWriteReqMsg0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ReadMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearRecvQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearSendQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-GetPingPassedTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-GetPing0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-IsPingInProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearPingWDG0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessagePing0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-IsPingOut0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-PingSenderTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-InitClientRSAKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearRSAKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-CheckAndDealRespMessages0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetResponse0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetErrorCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-GetCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-Log0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0  // const
METHODS:
END_CLASS

