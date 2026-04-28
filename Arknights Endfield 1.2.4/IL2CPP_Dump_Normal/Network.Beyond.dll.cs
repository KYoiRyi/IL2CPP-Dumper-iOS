// ========================================================
// Dumped by @desirepro
// Assembly: Network.Beyond.dll
// Classes:  100
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000014  // size: 0x18
    public class HandlerEntry
    {
        // Fields
        public Beyond.Network.NetResponseHandler handler;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600007A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x40
    public class ResultHandler : System.IDisposable
    {
        // Fields
        private System.Boolean m_ignoreSeq;  // 0x10
        private Beyond.ListDict<Proto.SCMessageID,System.Object> m_responseTokens;  // 0x18
        private Beyond.ListDict<Proto.SCMessageID,Beyond.Network.NetResponseHandler> m_responseHandlers;  // 0x20
        private System.Boolean <isDisposed>k__BackingField;  // 0x28
        private System.UInt64 <cachedSeqNum>k__BackingField;  // 0x30
        private System.Int32 <sessionID>k__BackingField;  // 0x38

        // Properties
        System.Boolean isDisposed { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.UInt64 cachedSeqNum { get; /* RVA: 0x01003830 */ set; /* RVA: 0x01003840 */ }
        System.Int32 sessionID { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }

        // Methods
        // RVA: 0x092A6330  token: 0x6000081
        public System.Void SetIgnoreSeq(System.Boolean ignoreSeq) { }
        // RVA: 0x02F113B0  token: 0x6000082
        public Beyond.Network.NetBus.ResultHandler OnResponse(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        // RVA: 0x02F10A10  token: 0x6000083
        public virtual System.Void Dispose() { }
        // RVA: 0x02F106E0  token: 0x6000084
        private System.Void _HandleMessage(Beyond.Network.NetResponse& msg) { }
        // RVA: 0x0350B670  token: 0x6000085
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x10
    public abstract class Sender
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000086
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: -1  // abstract  token: 0x6000087
        public virtual System.Void OnNetShutDown() { }
        // RVA: 0x02946310  token: 0x6000088
        protected Beyond.Network.NetBus.ResultHandler DoSend(Google.Protobuf.IMessage message) { }
        // RVA: 0x092A6384  token: 0x6000089
        protected System.Void DoListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        // RVA: 0x092A6424  token: 0x600008A
        protected System.Void DoUnListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        // RVA: 0x0350B670  token: 0x600008B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x20
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public System.Int32 key;  // 0x10
        public Beyond.Network.UIBusSender <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000AC
        public System.Void .ctor() { }
        // RVA: 0x092A6CB4  token: 0x60000AD
        private System.Void <Send>b__0(Beyond.Network.NetResponse& resp) { }
        // RVA: 0x092A6DA0  token: 0x60000AE
        private System.Void <Send>b__1(Beyond.Network.NetResponse& resp) { }
        // RVA: 0x092A6EFC  token: 0x60000AF
        private System.Void <Send>b__2(Beyond.Network.NetResponse& resp) { }

    }

    // TypeToken: 0x200001E  // size: 0x20
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public System.Int32 key;  // 0x10
        public Beyond.Network.TeleportMaskSender <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000B7
        public System.Void .ctor() { }
        // RVA: 0x092A6B20  token: 0x60000B8
        private System.Void <Send>b__0(Beyond.Network.NetResponse& resp) { }
        // RVA: 0x030171F0  token: 0x60000B9
        private System.Void <Send>b__1(Beyond.Network.NetResponse& resp) { }
        // RVA: 0x092A6B9C  token: 0x60000BA
        private System.Void <Send>b__2(Beyond.Network.NetResponse& resp) { }
        // RVA: 0x092A6C18  token: 0x60000BB
        private System.Void <Send>b__3(Beyond.Network.NetResponse& resp) { }

    }

    // TypeToken: 0x2000020  // size: 0x18
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public System.Action<System.Int32> onError;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000C3
        public System.Void .ctor() { }
        // RVA: 0x092A6D30  token: 0x60000C4
        private System.Void <Send>b__0(Beyond.Network.NetResponse& errorMsg) { }
        // RVA: 0x092A6E1C  token: 0x60000C5
        private System.Void <Send>b__1(Beyond.Network.NetResponse& errorMsg) { }
        // RVA: 0x092A6E8C  token: 0x60000C6
        private System.Void <Send>b__2(Beyond.Network.NetResponse& errorMsg) { }

    }

    // TypeToken: 0x2000029  // size: 0x18
    public sealed class <>c__DisplayClass18_0
    {
        // Fields
        public System.Object target;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000DF
        public System.Void .ctor() { }
        // RVA: 0x026AD8D0  token: 0x60000E0
        private System.Void <AutoRegisterMessageHandlers>b__0(System.Type msgType, System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x200002A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Network.NetUtil.<>c <>9;  // static @ 0x0
        public static System.Action<System.Type,System.Reflection.MethodInfo> <>9__19_0;  // static @ 0x8

        // Methods
        // RVA: 0x092A6F78  token: 0x60000E1
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60000E2
        public System.Void .ctor() { }
        // RVA: 0x092A6AAC  token: 0x60000E3
        private System.Void <AutoUnRegisterMessageHandlers>b__19_0(System.Type msgType, System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x200002C  // size: 0x20
    public class NetworkFrequency
    {
        // Fields
        public System.Type type;  // 0x10
        public System.Single second;  // 0x18
        public System.Int32 maxCount;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x60000E5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x30
    public class MaskInfo
    {
        // Fields
        public System.Int32 key;  // 0x10
        public System.String name;  // 0x18
        public System.Single startTime;  // 0x20
        public System.Single delayTime;  // 0x24
        public System.Single timeoutTime;  // 0x28

        // Properties
        System.Single endTime { get; /* RVA: 0x03D713D0 */ }
        System.Single showDecoTime { get; /* RVA: 0x03D713E0 */ }

        // Methods
        // RVA: 0x03D713C0  token: 0x60000FC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x20
    public class Config
    {
        // Fields
        public System.String key;  // 0x10
        public Beyond.SerializeFieldDictionaryPaired<Proto.CSMessageID,Proto.SCMessageID> messages;  // 0x18

        // Methods
        // RVA: 0x03CA7600  token: 0x60000FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x14
    public sealed struct EUrlType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Network.NetworkUrls.EUrlType ServerList;  // const
        public static Beyond.Network.NetworkUrls.EUrlType GameLicense;  // const
        public static Beyond.Network.NetworkUrls.EUrlType AgeTips;  // const
        public static Beyond.Network.NetworkUrls.EUrlType GateBulletin;  // const
        public static Beyond.Network.NetworkUrls.EUrlType GameBulletin;  // const
        public static Beyond.Network.NetworkUrls.EUrlType Launcher;  // const
        public static Beyond.Network.NetworkUrls.EUrlType Gov;  // const

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct ErrorType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Network.HttpSender.ErrorType NONE;  // const
        public static Beyond.Network.HttpSender.ErrorType TIMEOUT;  // const
        public static Beyond.Network.HttpSender.ErrorType DNS_FAILED;  // const
        public static Beyond.Network.HttpSender.ErrorType CANCELED;  // const
        public static Beyond.Network.HttpSender.ErrorType INTERNAL;  // const

    }

    // TypeToken: 0x2000036  // size: 0x20
    public class Cancellation
    {
        // Fields
        private System.Boolean m_isCancelled;  // 0x10
        private System.Action OnCancelInvoked;  // 0x18

        // Events
        event System.Action OnCancelInvoked;

        // Methods
        // RVA: 0x0929F414  token: 0x600013A
        public System.Void Cancel() { }
        // RVA: 0x0929F474  token: 0x600013B
        public System.Boolean IsCanceled() { }
        // RVA: 0x0350B670  token: 0x600013C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x30
    public sealed struct FGetOptions
    {
        // Fields
        public static readonly Beyond.Network.HttpSender.FGetOptions DEFAULT;  // static @ 0x0
        public System.Collections.Generic.Dictionary<System.String,System.String> headers;  // 0x10
        public System.String contentType;  // 0x18
        public System.Boolean headOnly;  // 0x20
        public Beyond.Network.HttpSender.Cancellation cancellation;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600013D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000038  // size: 0x30
    public sealed struct FPostOptions
    {
        // Fields
        public static readonly Beyond.Network.HttpSender.FPostOptions DEFAULT;  // static @ 0x0
        public System.Collections.Generic.Dictionary<System.String,System.String> headers;  // 0x10
        public System.String textBody;  // 0x18
        public System.String contentType;  // 0x20
        public Beyond.Network.HttpSender.Cancellation cancellation;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600013E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x68
    public sealed struct FSendFunc
    {
        // Fields
        public System.String url;  // 0x10
        public System.Int32 opt;  // 0x18
        public Beyond.Network.HttpSender.FGetOptions optionsGET;  // 0x20
        public Beyond.Network.HttpSender.FPostOptions optionsPOST;  // 0x40
        public System.Boolean editorOnly;  // 0x60

        // Methods
        // RVA: 0x02C47510  token: 0x600013F
        public UnityEngine.Networking.UnityWebRequest Invoke() { }
        // RVA: 0x02C474C0  token: 0x6000140
        public Beyond.Network.HttpSender.Cancellation GetCancellation() { }
        // RVA: 0x0929F644  token: 0x6000141
        public System.String GetOptMethod() { }

    }

    // TypeToken: 0x200003A  // size: 0x48
    public class Result
    {
        // Fields
        public System.Int32 respCode;  // 0x10
        public Beyond.Network.HttpSender.ErrorType errorType;  // 0x14
        public System.Boolean isError;  // 0x18
        public System.Exception exception;  // 0x20
        public System.String respText;  // 0x28
        public System.Byte[] respData;  // 0x30
        public System.String respError;  // 0x38
        public System.Boolean isServiceDone;  // 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x6000142
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x60
    public class TypedResult : Result
    {
        // Fields
        private System.Type <respType>k__BackingField;  // 0x48
        public System.Object respObject;  // 0x50
        public System.Boolean isDeserializeFailed;  // 0x58

        // Properties
        System.Type respType { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }

        // Methods
        // RVA: 0x02692290  token: 0x6000145
        public System.Void .ctor(System.Type respType) { }

    }

    // TypeToken: 0x200003C
    public class Result`1 : TypedResult
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000146
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000147
        public TResp GetRespObject() { }

    }

    // TypeToken: 0x200003D  // size: 0x50
    public sealed class <YieldSendGet>d__16 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String url;  // 0x20
        public Beyond.Network.HttpSender.FGetOptions options;  // 0x28
        public Beyond.Misc.ObjectRef resultRef;  // 0x48

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000148
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000149
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02F42B20  token: 0x600014A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092A6FDC  token: 0x600014C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003E
    public sealed class <YieldSendGet>d__17`1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public System.String url;  // 0x0
        public Beyond.Network.HttpSender.FGetOptions options;  // 0x0
        public Beyond.Misc.ObjectRef resultRef;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600014E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x600014F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000150
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000152
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003F  // size: 0x58
    public sealed class <YieldSendGet>d__18 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Network.HttpSender.FGetOptions options;  // 0x20
        public System.String url;  // 0x40
        public Beyond.Misc.ObjectRef resultRef;  // 0x48
        public System.Type respType;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000154
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000155
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03765580  token: 0x6000156
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092A7028  token: 0x6000158
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000040  // size: 0x50
    public sealed class <YieldSendPost>d__19 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String url;  // 0x20
        public Beyond.Network.HttpSender.FPostOptions options;  // 0x28
        public Beyond.Misc.ObjectRef resultRef;  // 0x48

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600015A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600015B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x092A7074  token: 0x600015C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092A70DC  token: 0x600015E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000041
    public sealed class <YieldSendPost>d__20`1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public System.String url;  // 0x0
        public Beyond.Network.HttpSender.FPostOptions options;  // 0x0
        public Beyond.Misc.ObjectRef resultRef;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000160
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x6000161
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000162
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000164
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000042  // size: 0x58
    public sealed class <YieldSendPost>d__21 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Network.HttpSender.FPostOptions options;  // 0x20
        public System.String url;  // 0x40
        public Beyond.Misc.ObjectRef resultRef;  // 0x48
        public System.Type respType;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000166
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000167
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03765490  token: 0x6000168
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092A7128  token: 0x600016A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000043  // size: 0xA0
    public sealed class <_YieldSendHttpRequest>d__28 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Network.HttpSender.FSendFunc sendFunc;  // 0x20
        public Beyond.Network.HttpSender.Result result;  // 0x78
        private Beyond.Network.HttpSender.Cancellation <cancelation>5__2;  // 0x80
        private System.Boolean <isCanceled>5__3;  // 0x88
        private UnityEngine.Networking.UnityWebRequest <request>5__4;  // 0x90
        private UnityEngine.Networking.UnityWebRequestAsyncOperation <sendOpt>5__5;  // 0x98

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600016C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x092A71C0  token: 0x600016D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C46410  token: 0x600016E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x02C47590  token: 0x600016F
        private System.Void <>m__Finally1() { }
        // RVA: 0x092A7174  token: 0x6000171
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000044  // size: 0x90
    public sealed class <_YieldSendHttpRequest>d__29 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Misc.ObjectRef resultRef;  // 0x20
        public System.Type respType;  // 0x28
        public Beyond.Network.HttpSender.FSendFunc sendFunc;  // 0x30
        private Beyond.Network.HttpSender.Result <result>5__2;  // 0x88

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000173
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000174
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02691FE0  token: 0x6000175
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x092A7238  token: 0x6000177
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000045  // size: 0x18
    public sealed class <>c__DisplayClass30_0
    {
        // Fields
        public Beyond.Network.HttpSender.Result result;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000179
        public System.Void .ctor() { }
        // RVA: 0x092A6C94  token: 0x600017A
        private Beyond.Network.HttpSender.Result <_WaitForSendHttpRequest>b__0() { }

    }

    // TypeToken: 0x2000046
    public sealed class <>c__DisplayClass31_0`1
    {
        // Fields
        public Beyond.Network.HttpSender.Result<TResp> result;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600017B
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600017C
        private Beyond.Network.HttpSender.Result<TResp> <_WaitForSendHttpRequest>b__0() { }

    }

    // TypeToken: 0x2000048
    public sealed class <GetEnumerator>d__18 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private T <>2__current;  // 0x0
        public Beyond.Network.CircularBuffer<T> <>4__this;  // 0x0
        private System.ArraySegment<T>[] <>7__wrap1;  // 0x0
        private System.Int32 <>7__wrap2;  // 0x0
        private System.ArraySegment<T> <segment>5__4;  // 0x0
        private System.Int32 <i>5__5;  // 0x0

        // Properties
        T System.Collections.Generic.IEnumerator<T>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000199
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x600019A
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x600019B
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600019D
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200004A  // size: 0x20
    public sealed class <>c__DisplayClass56_0
    {
        // Fields
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x10
        public Beyond.Network.INetIO tcpIO;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001D6
        public System.Void .ctor() { }
        // RVA: 0x038A22A0  token: 0x60001D7
        private System.Void <ConnectAsync>b__0(System.Threading.Tasks.Task<System.Threading.Tasks.Task> task) { }

    }

    // TypeToken: 0x200004B  // size: 0x28
    public sealed class <>c__DisplayClass69_0
    {
        // Fields
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x10
        public Beyond.Network.INetIO tcp;  // 0x18
        public System.Int32 nextid;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60001D8
        public System.Void .ctor() { }
        // RVA: 0x0397CEF0  token: 0x60001D9
        private System.Threading.Tasks.Task <StartTCPMsgLoopThreadTask>b__0() { }

    }

    // TypeToken: 0x200004C  // size: 0x50
    public sealed struct <_SessionThread>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x30
        public Beyond.Network.INetIO tcp;  // 0x38
        public System.Int32 threadID;  // 0x40
        private System.Runtime.CompilerServices.TaskAwaiter <>u__1;  // 0x48

        // Methods
        // RVA: 0x024C92A0  token: 0x60001DA
        private virtual System.Void MoveNext() { }
        // RVA: 0x036BB140  token: 0x60001DB
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200004D  // size: 0x48
    public sealed struct <_ReconnectCheckerTick>d__80 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x30
        public Beyond.Network.INetIO tcpIO;  // 0x38
        private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1;  // 0x40

        // Methods
        // RVA: 0x02939C90  token: 0x60001DC
        private virtual System.Void MoveNext() { }
        // RVA: 0x036BB200  token: 0x60001DD
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200004E  // size: 0x30
    public sealed class <>c__DisplayClass81_0
    {
        // Fields
        public Beyond.Network.INetIO tcpIO;  // 0x10
        public System.String ip;  // 0x18
        public System.Int32 port;  // 0x20
        public System.Int32 sendTimeout;  // 0x24
        public System.Int32 receiveBufferLen;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60001DE
        public System.Void .ctor() { }
        // RVA: 0x0293E4A0  token: 0x60001DF
        private System.Void <TryConnectWithTimeout>b__0() { }

    }

    // TypeToken: 0x200004F  // size: 0x68
    public sealed struct <TryConnectWithTimeout>d__81 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder;  // 0x18
        public Beyond.Network.INetIO tcpIO;  // 0x30
        public System.String ip;  // 0x38
        public System.Int32 port;  // 0x40
        public System.Int32 sendTimeout;  // 0x44
        public System.Int32 receiveBufferLen;  // 0x48
        public System.Int32 timeoutMilliseconds;  // 0x4c
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x50
        private System.Threading.Tasks.Task <connectTask>5__2;  // 0x58
        private System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task> <>u__1;  // 0x60

        // Methods
        // RVA: 0x0293C4A0  token: 0x60001E0
        private virtual System.Void MoveNext() { }
        // RVA: 0x03891570  token: 0x60001E1
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000050  // size: 0x18
    public sealed class <>c__DisplayClass82_0
    {
        // Fields
        public Beyond.Network.INetIO tcpIO;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001E2
        public System.Void .ctor() { }
        // RVA: 0x02943650  token: 0x60001E3
        private System.Void <TryCloseTcpIOWithTimeout>b__0() { }

    }

    // TypeToken: 0x2000051  // size: 0x58
    public sealed struct <TryCloseTcpIOWithTimeout>d__82 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder;  // 0x18
        public Beyond.Network.INetIO tcpIO;  // 0x30
        public System.Int32 timeoutMilliseconds;  // 0x38
        public Beyond.Network.HGNetBaseSession <>4__this;  // 0x40
        private System.Threading.Tasks.Task <closeTask>5__2;  // 0x48
        private System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task> <>u__1;  // 0x50

        // Methods
        // RVA: 0x0293C7D0  token: 0x60001E4
        private virtual System.Void MoveNext() { }
        // RVA: 0x03891500  token: 0x60001E5
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200005A  // size: 0x20
    public class LoginErrorInfo
    {
        // Fields
        private System.Int32 <code>k__BackingField;  // 0x10
        private System.String <details>k__BackingField;  // 0x18

        // Properties
        System.Int32 code { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.String details { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x02F0F020  token: 0x600022A
        public System.Void SetErrorInvaild() { }
        // RVA: 0x092AF990  token: 0x600022B
        public System.Void SetErrorConnectError() { }
        // RVA: 0x092AFA1C  token: 0x600022C
        public System.Void SetErrorConnectTimeOut() { }
        // RVA: 0x02F0EAE0  token: 0x600022D
        public System.Void Clear() { }
        // RVA: 0x092AFAA8  token: 0x600022E
        public System.Void Set(System.Int32 code, System.String details) { }
        // RVA: 0x02F0EFD0  token: 0x600022F
        public System.Void .ctor() { }

    }

namespace Beyond.Network
{

    // TypeToken: 0x2000008
    public class DoubleQueue`1
    {
        // Fields
        private System.Collections.Generic.Queue<T> m_readQueue;  // 0x0
        private System.Collections.Generic.Queue<T> m_writeQueue;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000007
        public System.Void LockingSwap() { }
        // RVA: -1  // not resolved  token: 0x6000008
        public System.Void TryLockingSwap() { }
        // RVA: -1  // not resolved  token: 0x6000009
        public System.Void Enqueue(T item) { }
        // RVA: -1  // not resolved  token: 0x600000A
        public System.Boolean TryDequeue(T& item) { }
        // RVA: -1  // not resolved  token: 0x600000B
        public System.Void EnqueueRange(System.Collections.Generic.List<T> list) { }
        // RVA: -1  // not resolved  token: 0x600000C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x30
    public class HGTcpClient : System.IDisposable
    {
        // Fields
        private System.Net.Sockets.Socket m_ClientSocket;  // 0x10
        private System.Boolean m_Active;  // 0x18
        private System.Net.Sockets.NetworkStream m_DataStream;  // 0x20
        private System.Net.Sockets.AddressFamily m_Family;  // 0x28
        private System.Boolean m_CleanedUp;  // 0x2c

        // Properties
        System.Net.Sockets.Socket Client { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean Active { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Int32 Available { get; /* RVA: 0x024CB8A0 */ }
        System.Boolean Connected { get; /* RVA: 0x024CB510 */ }
        System.Boolean ExclusiveAddressUse { get; /* RVA: 0x092A28D0 */ set; /* RVA: 0x092A2964 */ }
        System.Int32 ReceiveBufferSize { get; /* RVA: 0x092A2914 */ set; /* RVA: 0x0293FA20 */ }
        System.Int32 SendBufferSize { get; /* RVA: 0x092A293C */ set; /* RVA: 0x0293FA60 */ }
        System.Int32 ReceiveTimeout { get; /* RVA: 0x092A2928 */ set; /* RVA: 0x092A29B8 */ }
        System.Int32 SendTimeout { get; /* RVA: 0x092A2950 */ set; /* RVA: 0x0293FAA0 */ }
        System.Net.Sockets.LingerOption LingerState { get; /* RVA: 0x0293E810 */ set; /* RVA: 0x092A2984 */ }
        System.Boolean NoDelay { get; /* RVA: 0x092A28F0 */ set; /* RVA: 0x0293FAE0 */ }

        // Methods
        // RVA: 0x0293F960  token: 0x600000D
        public System.Void .ctor() { }
        // RVA: 0x092A273C  token: 0x600000E
        public System.Void .ctor(System.String hostname, System.Int32 port) { }
        // RVA: 0x092A28A8  token: 0x600000F
        private System.Void .ctor(System.Net.Sockets.Socket acceptedSocket) { }
        // RVA: 0x0293F080  token: 0x6000018
        public System.Void Connect(System.String hostname, System.Int32 port) { }
        // RVA: 0x092A2494  token: 0x6000019
        public System.Void Connect(System.Net.IPAddress address, System.Int32 port) { }
        // RVA: 0x0293E570  token: 0x600001A
        public System.Void Connect(System.Net.IPEndPoint remoteEP) { }
        // RVA: 0x092A2414  token: 0x600001B
        public System.Void Connect(System.Net.IPAddress[] ipAddresses, System.Int32 port) { }
        // RVA: 0x0295A810  token: 0x600001C
        public System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        // RVA: 0x092A209C  token: 0x600001D
        public System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        // RVA: 0x092A1FF4  token: 0x600001E
        public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        // RVA: 0x038A6D30  token: 0x600001F
        public System.Void EndConnect(System.IAsyncResult asyncResult) { }
        // RVA: 0x092A2144  token: 0x6000020
        public System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port) { }
        // RVA: 0x0293DA80  token: 0x6000021
        public System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port) { }
        // RVA: 0x092A22AC  token: 0x6000022
        public System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, System.Int32 port) { }
        // RVA: 0x024D1590  token: 0x6000023
        public System.Net.Sockets.NetworkStream GetStream() { }
        // RVA: 0x02944150  token: 0x6000024
        public System.Void Close() { }
        // RVA: 0x02943BC0  token: 0x6000025
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x02943B80  token: 0x6000026
        public virtual System.Void Dispose() { }
        // RVA: 0x092A2620  token: 0x6000027
        protected virtual System.Void Finalize() { }
        // RVA: 0x0293F970  token: 0x6000034
        private System.Void _Initialize() { }
        // RVA: 0x092A2694  token: 0x6000035
        private System.Int32 _NumericOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName) { }

    }

    // TypeToken: 0x200000A
    public interface INetIO : System.IDisposable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000036
        public virtual System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        // RVA: -1  // abstract  token: 0x6000037
        public virtual System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        // RVA: -1  // abstract  token: 0x6000038
        public virtual System.Void Close() { }
        // RVA: -1  // abstract  token: 0x6000039
        public virtual System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed) { }
        // RVA: -1  // abstract  token: 0x600003A
        public virtual System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS) { }
        // RVA: -1  // abstract  token: 0x600003B
        public virtual System.Boolean IsConnected() { }
        // RVA: -1  // abstract  token: 0x600003C
        public virtual System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        // RVA: -1  // abstract  token: 0x600003D
        public virtual System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        // RVA: -1  // abstract  token: 0x600003E
        public virtual System.Boolean IsAuthed() { }
        // RVA: -1  // abstract  token: 0x600003F
        public virtual System.Void MarkAuthed() { }
        // RVA: -1  // abstract  token: 0x6000040
        public virtual System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv) { }
        // RVA: -1  // abstract  token: 0x6000041
        public virtual System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        // RVA: -1  // abstract  token: 0x6000042
        public virtual System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        // RVA: -1  // abstract  token: 0x6000043
        public virtual System.Byte[] GetSendHeadBuffer() { }
        // RVA: -1  // abstract  token: 0x6000044
        public virtual System.Byte[] GetSendBuffer() { }
        // RVA: -1  // abstract  token: 0x6000045
        public virtual System.Byte[] GetReceiveBuffer() { }
        // RVA: -1  // abstract  token: 0x6000046
        public virtual System.Int32 GetReceiveBufferOffset() { }
        // RVA: -1  // abstract  token: 0x6000047
        public virtual System.Void ClearReceiveBufferOffset() { }
        // RVA: -1  // abstract  token: 0x6000048
        public virtual System.Void SkipReceiveBufferOffset(System.Int32 len) { }
        // RVA: -1  // abstract  token: 0x6000049
        public virtual System.Net.EndPoint GetEndPoint() { }
        // RVA: -1  // abstract  token: 0x600004A
        public virtual System.Int32 Available() { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class NetMsgHandlerAttribute : System.Attribute
    {
        // Fields
        public readonly System.Type msgType;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600004B
        public System.Void .ctor(System.Type t) { }
        // RVA: 0x035ACAA0  token: 0x600004C
        public System.Void .ctor() { }
        // RVA: 0x02D5B4A0  token: 0x600004D
        public System.Type GetMsgType(System.Reflection.MethodInfo annotatedMethod) { }

    }

    // TypeToken: 0x200000C  // size: 0x80
    public sealed class NetResponseHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x022B0690  token: 0x600004E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600004F
        public virtual System.Void Invoke(Beyond.Network.NetResponse& msg) { }
        // RVA: 0x092A3904  token: 0x6000050
        public virtual System.IAsyncResult BeginInvoke(Beyond.Network.NetResponse& msg, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x05B74E40  token: 0x6000051
        public virtual System.Void EndInvoke(Beyond.Network.NetResponse& msg, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000D
    public sealed class NetMessageHandle`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000052
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000053
        public virtual System.Void Invoke(T message) { }
        // RVA: -1  // runtime  token: 0x6000054
        public virtual System.IAsyncResult BeginInvoke(T message, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000055
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000E
    public interface INetBusResponseListener
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000056
        public virtual System.Void UpdateMsgTime(Beyond.Network.NetResponse resp) { }

    }

    // TypeToken: 0x200000F  // size: 0x28
    public sealed struct NetRequest
    {
        // Fields
        public System.UInt64 csSeqID;  // 0x10
        public System.Int32 mergeNum;  // 0x18
        public Google.Protobuf.IMessage msg;  // 0x20

    }

    // TypeToken: 0x2000010  // size: 0x30
    public sealed struct NetResponse
    {
        // Fields
        public static Beyond.Network.NetResponse EMPTY;  // static @ 0x0
        public Google.Protobuf.IMessage headMsg;  // 0x10
        public Google.Protobuf.IMessage msgBody;  // 0x18
        public System.Boolean isPacked;  // 0x20
        public System.Int64 recvTimestamp;  // 0x28

        // Properties
        Beyond.Network.HGNetLogger.Header logHead { get; /* RVA: 0x02944C20 */ set; /* RVA: 0x042715A0 */ }
        Proto.CSHead csHead { get; /* RVA: 0x024C8040 */ set; /* RVA: 0x042715A0 */ }
        System.Int32 msgId { get; /* RVA: 0x024C7FC0 */ }
        System.UInt64 csSeqId { get; /* RVA: 0x024C7260 */ }
        System.UInt64 scSeqId { get; /* RVA: 0x024C71E0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600005E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public abstract class MessageHandleWrapper
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600005F
        public virtual System.Void HandleMessage(Google.Protobuf.IMessage msg) { }
        // RVA: 0x0350B670  token: 0x6000060
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class MessageHandleWrapper`1 : Beyond.Network.MessageHandleWrapper
    {
        // Fields
        private readonly Beyond.Network.NetMessageHandle<T> m_handle;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000061
        public System.Void .ctor(Beyond.Network.NetMessageHandle<T> handle) { }
        // RVA: -1  // not resolved  token: 0x6000062
        public virtual System.Void HandleMessage(Google.Protobuf.IMessage msg) { }

    }

    // TypeToken: 0x2000013  // size: 0x60
    public class NetBus : Beyond.ExplicitSingleton`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.NetResponseHandler> m_msgHandlers;  // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Beyond.Network.NetBus.HandlerEntry>> m_msgWithSeqNumHandlers;  // 0x18
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.MessageHandleWrapper> m_msgHdlWrappers;  // 0x20
        private Beyond.Network.HGNetSession m_netSession;  // 0x28
        private static System.Collections.Generic.List<Beyond.Network.NetResponseHandler> s_handlersToCall;  // static @ 0x0
        private readonly Beyond.Network.UIBusSender <uiSender>k__BackingField;  // 0x30
        private readonly Beyond.Network.TeleportMaskSender <teleportMaskSender>k__BackingField;  // 0x38
        private readonly Beyond.Network.DisposableBusSender <defaultSender>k__BackingField;  // 0x40
        private readonly Beyond.Network.Special2BusSender <s2Sender>k__BackingField;  // 0x48
        private readonly Beyond.Network.InteractiveBusSender <interactiveSender>k__BackingField;  // 0x50
        private readonly Beyond.Network.FrequencyControlBusSender <frequencyControlSender>k__BackingField;  // 0x58

        // Properties
        Beyond.Network.UIBusSender uiSender { get; /* RVA: 0x01003830 */ }
        Beyond.Network.TeleportMaskSender teleportMaskSender { get; /* RVA: 0x03D4E2A0 */ }
        Beyond.Network.DisposableBusSender defaultSender { get; /* RVA: 0x03D4E2B0 */ }
        Beyond.Network.Special2BusSender s2Sender { get; /* RVA: 0x03D4EA70 */ }
        Beyond.Network.InteractiveBusSender interactiveSender { get; /* RVA: 0x03D4EAF0 */ }
        Beyond.Network.FrequencyControlBusSender frequencyControlSender { get; /* RVA: 0x03D4EAA0 */ }
        System.Int32 currentSessionID { get; /* RVA: 0x092A3868 */ }

        // Methods
        // RVA: 0x0345E390  token: 0x600006A
        public System.Void .ctor() { }
        // RVA: 0x092A3408  token: 0x600006B
        public System.Boolean IsBusBusy() { }
        // RVA: 0x02F0F3C0  token: 0x600006C
        public System.Void Setup(Beyond.Network.HGNetSession session) { }
        // RVA: 0x029464A0  token: 0x600006D
        public System.Void Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x026AD5F0  token: 0x600006E
        public System.Void RegisterMessageHandler(System.Int32 msgId, Beyond.Network.MessageHandleWrapper handler) { }
        // RVA: 0x092A3450  token: 0x600006F
        public System.Void UnRegisterMessageHandler(System.Int32 msgId) { }
        // RVA: 0x092A30A0  token: 0x6000070
        public System.Void HandleMessageTime(Beyond.Network.NetResponse response) { }
        // RVA: 0x092A3118  token: 0x6000071
        public System.Void HandleMessage(Beyond.Network.NetResponse response) { }
        // RVA: 0x02946460  token: 0x6000072
        private System.Boolean _ValidateSession() { }
        // RVA: 0x02F0F090  token: 0x6000073
        public System.Void OnNetClientShutDown() { }
        // RVA: 0x029463A0  token: 0x6000074
        private Beyond.Network.NetBus.ResultHandler _SendWithResult(Google.Protobuf.IMessage msg) { }
        // RVA: 0x092A3608  token: 0x6000075
        private System.Void _Listen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler) { }
        // RVA: 0x092A373C  token: 0x6000076
        private System.Void _UnListen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler) { }
        // RVA: 0x092A34D4  token: 0x6000077
        private System.Object _ListenWithSeqNum(System.Int32 msgId, Beyond.Network.NetResponseHandler callback) { }
        // RVA: 0x02F11730  token: 0x6000078
        private System.Void _UnListenWithSeqNum(System.Int32 msgId, System.Object token) { }
        // RVA: 0x03CE3790  token: 0x6000079
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x38
    public class Special2BusSender : Beyond.Network.DisposableBusSender, Beyond.Network.INetBusResponseListener
    {
        // Fields
        public System.Collections.Generic.Dictionary<System.UInt64,System.Double> sendedMsgWithTime;  // 0x20
        public System.Double minSendTime;  // 0x28
        private System.Single m_maxWaitTime;  // 0x30

        // Properties
        System.Boolean isBusBusy { get; /* RVA: 0x02998950 */ }

        // Methods
        // RVA: 0x03924E20  token: 0x600008D
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x092A6650  token: 0x600008E
        public System.Void UpdateStartBlockTime() { }
        // RVA: 0x02F0FC70  token: 0x600008F
        public virtual System.Void OnNetShutDown() { }
        // RVA: 0x092A6544  token: 0x6000090
        public virtual System.Void Dispose() { }
        // RVA: 0x02F11860  token: 0x6000091
        private System.Void _ClearSendTime() { }
        // RVA: 0x092A65A4  token: 0x6000092
        public virtual System.Void UpdateMsgTime(Beyond.Network.NetResponse resp) { }
        // RVA: 0x02DF5160  token: 0x6000093
        public System.Void .ctor() { }
        // RVA: 0x0929FD28  token: 0x6000094
        public Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        // RVA: 0x092A659C  token: 0x6000095
        public System.Void <>iFixBaseProxy_OnNetShutDown() { }
        // RVA: 0x0929FD20  token: 0x6000096
        public System.Void <>iFixBaseProxy_Dispose() { }

    }

    // TypeToken: 0x2000018  // size: 0x40
    public class InteractiveBusSender : Beyond.Network.Special2BusSender
    {
        // Fields
        private System.Single m_maxWaitTime;  // 0x38

        // Properties
        System.Boolean isBusBusy { get; /* RVA: 0x02998920 */ }

        // Methods
        // RVA: 0x04276358  token: 0x6000098
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x20
    public class DisposableBusSender : Sender, System.IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<Beyond.Network.NetBus.ResultHandler> m_resultHandlers;  // 0x10
        private System.Boolean <isDisposed>k__BackingField;  // 0x18

        // Properties
        System.Boolean isDisposed { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x02946270  token: 0x600009B
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x02F10830  token: 0x600009C
        public virtual System.Void OnNetShutDown() { }
        // RVA: 0x0929F5F0  token: 0x600009D
        public virtual System.Void Dispose() { }
        // RVA: 0x02F10870  token: 0x600009E
        private System.Void _Clear() { }
        // RVA: 0x02DF53B0  token: 0x600009F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x18
    public class NetworkMaskConfigHolder
    {
        // Fields
        public System.Collections.Generic.Dictionary<Proto.CSMessageID,Proto.SCMessageID> msgs;  // 0x10

        // Methods
        // RVA: 0x0345E7E0  token: 0x60000A0
        public System.Void Init() { }
        // RVA: 0x092A5A90  token: 0x60000A1
        public System.Void Dispose() { }
        // RVA: 0x0345E760  token: 0x60000A2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x30
    public class UIBusSender : Beyond.Network.DisposableBusSender
    {
        // Fields
        private Beyond.Network.NetworkMaskConfigHolder <config>k__BackingField;  // 0x20
        private System.Collections.Generic.HashSet<System.Int32> m_maskKeys;  // 0x28

        // Properties
        Beyond.Network.NetworkMaskConfigHolder config { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0345E690  token: 0x60000A5
        public System.Void .ctor() { }
        // RVA: 0x092A7284  token: 0x60000A6
        public virtual System.Void Dispose() { }
        // RVA: 0x092A7478  token: 0x60000A7
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x02F0F540  token: 0x60000A8
        public virtual System.Void OnNetShutDown() { }
        // RVA: 0x0929FD20  token: 0x60000A9
        public System.Void <>iFixBaseProxy_Dispose() { }
        // RVA: 0x0929FD28  token: 0x60000AA
        public Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        // RVA: 0x092A659C  token: 0x60000AB
        public System.Void <>iFixBaseProxy_OnNetShutDown() { }

    }

    // TypeToken: 0x200001D  // size: 0x28
    public class TeleportMaskSender : Beyond.Network.DisposableBusSender
    {
        // Fields
        private System.Collections.Generic.HashSet<System.Int32> m_maskKeys;  // 0x20

        // Methods
        // RVA: 0x092A68D4  token: 0x60000B0
        public virtual System.Void Dispose() { }
        // RVA: 0x02F0FF40  token: 0x60000B1
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x02F0F820  token: 0x60000B2
        public virtual System.Void OnNetShutDown() { }
        // RVA: 0x0345E610  token: 0x60000B3
        public System.Void .ctor() { }
        // RVA: 0x0929FD20  token: 0x60000B4
        public System.Void <>iFixBaseProxy_Dispose() { }
        // RVA: 0x0929FD28  token: 0x60000B5
        public Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        // RVA: 0x092A659C  token: 0x60000B6
        public System.Void <>iFixBaseProxy_OnNetShutDown() { }

    }

    // TypeToken: 0x200001F  // size: 0x40
    public class FrequencyControlBusSender : Beyond.Network.DisposableBusSender
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Proto.CSMessageID,System.Collections.Generic.Queue<System.Double>> m_lastSendTime;  // 0x20
        private System.Collections.Generic.List<Google.Protobuf.IMessage> m_waitingSendMsgs;  // 0x28
        private System.Collections.Generic.List<System.Action<System.Int32>> m_onError;  // 0x30
        private System.Int32 m_loopId;  // 0x38

        // Methods
        // RVA: 0x03238050  token: 0x60000BC
        public System.Void .ctor() { }
        // RVA: 0x03456440  token: 0x60000BD
        private System.Void _TrySendWaitingMsg() { }
        // RVA: 0x0929F7B0  token: 0x60000BE
        public virtual Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        // RVA: 0x0929F820  token: 0x60000BF
        public Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg, System.Boolean needAddToWaitingList, System.Action<System.Int32> onError, System.Action onWait) { }
        // RVA: 0x0929F6F8  token: 0x60000C0
        public virtual System.Void Dispose() { }
        // RVA: 0x0929FD28  token: 0x60000C1
        public Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        // RVA: 0x0929FD20  token: 0x60000C2
        public System.Void <>iFixBaseProxy_Dispose() { }

    }

    // TypeToken: 0x2000021  // size: 0x28
    public class ServerDesc
    {
        // Fields
        public System.String name;  // 0x10
        public System.String addr;  // 0x18
        public System.Int32 port;  // 0x20

        // Methods
        // RVA: 0x0333BE60  token: 0x60000C7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x18
    public class ServerList
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Network.ServerDesc> servers;  // 0x10

        // Methods
        // RVA: 0x03CFC3F0  token: 0x60000C8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x28
    public class ServerConfig
    {
        // Fields
        public System.String serverName;  // 0x10
        public System.String uid;  // 0x18
        public System.Boolean checkDev;  // 0x20

        // Methods
        // RVA: 0x092A64C4  token: 0x60000C9
        public System.Boolean IsSame(Beyond.Network.ServerConfig other) { }
        // RVA: 0x03D21020  token: 0x60000CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x28
    public class HostData
    {
        // Fields
        public System.String host;  // 0x10
        public System.Int32 port;  // 0x18
        public System.Double delay;  // 0x20

        // Methods
        // RVA: 0x0315C2B0  token: 0x60000CB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x18
    public class NetConfig
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Network.HostData> hosts;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60000CC
        public System.Void .ctor(System.Collections.Generic.List<Beyond.Network.HostData> hosts) { }

    }

    // TypeToken: 0x2000026  // size: 0x10
    public static class NetConsts
    {
        // Fields
        public static readonly System.String NETMASK_CONFIG_PATH;  // static @ 0x0
        public static readonly System.String NETMASK_PREFAB_PATH;  // static @ 0x8

        // Methods
        // RVA: 0x03CDF500  token: 0x60000CD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000027
    public interface INetworkSystem : Beyond.ILuaCallCSharp
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60000CE
        public virtual System.Void OnReConnect() { }
        // RVA: -1  // abstract  token: 0x60000CF
        public virtual System.Void SendMsg(Google.Protobuf.IMessage msg, System.Action<System.Int32> onError) { }

    }

    // TypeToken: 0x2000028  // size: 0x10
    public class NetUtil
    {
        // Fields
        private static System.Boolean s_isRegistedAllMessages;  // static @ 0x0
        public static readonly System.Int32 MAX_RECEIVE_PACK_BODY_SIZE;  // static @ 0x4
        public static readonly System.Int32 MAX_MERGE_PACK_BODY_SIZE;  // static @ 0x8
        public static readonly System.Int32 MAX_SEND_PACK_BODY_SIZE;  // static @ 0xc
        private static System.Collections.Generic.Dictionary<System.Int32,System.Type> s_sc_id2MessageType;  // static @ 0x10
        private static System.Collections.Generic.Dictionary<System.Type,System.Int32> s_sc_messageType2Id;  // static @ 0x18
        private static System.Collections.Generic.Dictionary<System.Type,System.Int32> s_cs_messageType2Id;  // static @ 0x20
        private static System.Byte[] s_decompressedBuffer;  // static @ 0x28

        // Methods
        // RVA: 0x02C34270  token: 0x60000D0
        public static System.Void RegisterSCMessage(System.Int32 msgId, System.Type msgType) { }
        // RVA: 0x02C33D50  token: 0x60000D1
        public static System.Void RegisterCSMessage(System.Int32 msgId, System.Type msgType) { }
        // RVA: 0x026AD6D0  token: 0x60000D2
        public static System.Int32 GetSCMsgIdByType(System.Type msgType) { }
        // RVA: 0x092A3AC4  token: 0x60000D3
        public static System.Type GetSCMsgTypeById(System.Int32 msgId) { }
        // RVA: 0x032BA2C0  token: 0x60000D4
        public static System.Int32 GetCSMsgIdByType(System.Type msgType) { }
        // RVA: -1  // generic def  token: 0x60000D5
        private static System.Void _GenMessageName2ValuePair(System.Collections.Generic.Dictionary<System.String,System.Int32> dic) { }
        // RVA: 0x02C33E80  token: 0x60000D6
        public static System.Void FastRegisterMessage() { }
        // RVA: 0x029D2940  token: 0x60000D7
        public static System.Boolean GetNetMessageFromDataBytes(System.Span<System.Byte> headBytes, System.Byte[] bodyBuffer, System.Int32 offset, System.Int32 bodyLen, System.Byte[] packedbuffer, Beyond.Network.NetResponse& response) { }
        // RVA: 0x024D2BE0  token: 0x60000D8
        public static System.Int32 SerializeHeadMessage(Google.Protobuf.IMessage msg, System.UInt64 upSeqid, System.Int32 bodyLen, System.Int32 crc32, System.Byte[] buffer, System.Int32 offset) { }
        // RVA: 0x092A3B74  token: 0x60000D9
        public static System.Int32 SerializeBodyMessage(Google.Protobuf.IMessage msg, System.Byte[] buffer, System.Int32& crc32, System.Int32 offset) { }
        // RVA: 0x02D5B260  token: 0x60000DA
        public static System.Void AutoRegisterMessageHandlers(System.Object target) { }
        // RVA: 0x092A3984  token: 0x60000DB
        public static System.Void AutoUnRegisterMessageHandlers(System.Object target) { }
        // RVA: 0x02D5B360  token: 0x60000DC
        private static System.Void _ForeachMessageHandlers(System.Object target, System.Action<System.Type,System.Reflection.MethodInfo> doFunc) { }
        // RVA: 0x0350B670  token: 0x60000DD
        public System.Void .ctor() { }
        // RVA: 0x037063D0  token: 0x60000DE
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x10
    public static class NetworkFrequencyConfig
    {
        // Fields
        public static Beyond.SerializeFieldDictionary<System.Int32,Beyond.Network.NetworkFrequencyConfig.NetworkFrequency> msgs;  // static @ 0x0

        // Methods
        // RVA: 0x092A3D64  token: 0x60000E4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x60
    public class NetworkMask : Beyond.Singleton`1
    {
        // Fields
        private Beyond.TickFunction m_preTickFunction;  // 0x10
        private System.Int32 m_nextKey;  // 0x18
        public UnityEngine.GameObject maskObj;  // 0x20
        public UnityEngine.GameObject decoObj;  // 0x28
        private Beyond.Resource.FAssetProxyHandle m_handle;  // 0x30
        private System.Action<System.Boolean> m_onNetMaskChanged;  // 0x48
        private System.Boolean <showingMask>k__BackingField;  // 0x50
        private System.Boolean <showingDeco>k__BackingField;  // 0x51
        private System.Boolean m_isNetReconnecting;  // 0x52
        private static System.String DECO_NAME;  // const
        private System.Collections.Generic.List<Beyond.Network.NetworkMask.MaskInfo> m_masks;  // 0x58

        // Properties
        System.Boolean showingMask { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }
        System.Boolean showingDeco { get; /* RVA: 0x03D518F0 */ set; /* RVA: 0x03D51900 */ }

        // Methods
        // RVA: 0x03807DC0  token: 0x60000EA
        private System.Void .ctor() { }
        // RVA: 0x03807E60  token: 0x60000EB
        protected System.Void OnInit() { }
        // RVA: 0x092A5BC8  token: 0x60000EC
        protected System.Void OnUnInit() { }
        // RVA: 0x092A5C60  token: 0x60000ED
        public System.Void Release() { }
        // RVA: 0x092A5E88  token: 0x60000EE
        private System.Void _OnSwitchLanguage() { }
        // RVA: 0x038081A0  token: 0x60000EF
        private System.Void _CreateTickFunction() { }
        // RVA: 0x092A5E24  token: 0x60000F0
        private System.Void _ClearTickFunction() { }
        // RVA: 0x03017340  token: 0x60000F1
        public System.Void PreTick(System.Single deltaTime) { }
        // RVA: 0x030171C0  token: 0x60000F2
        private System.Int32 _GetKey() { }
        // RVA: 0x092A5B08  token: 0x60000F3
        public System.Int32 AddMask(Proto.CSMessageID msgId, System.Single timeoutTime) { }
        // RVA: 0x030170C0  token: 0x60000F4
        public System.Int32 AddMask(System.String name, System.Single timeoutTime, System.Single delayTime) { }
        // RVA: 0x03017270  token: 0x60000F5
        public System.Void RemoveMask(System.Int32 key) { }
        // RVA: 0x03D713F0  token: 0x60000F6
        public System.Void SetIsNetReconnecting(System.Boolean isReconnecting) { }
        // RVA: 0x03017410  token: 0x60000F7
        private System.Void _UpdateMaskState() { }
        // RVA: 0x03A2FE20  token: 0x60000F8
        public System.Void ListenOnNetMaskChanged(System.Action<System.Boolean> action) { }
        // RVA: 0x092A5D70  token: 0x60000F9
        public System.Void UnListenOnNetMaskChanged(System.Action<System.Boolean> action) { }

    }

    // TypeToken: 0x200002F  // size: 0x28
    public class NetworkMaskConfig : UnityEngine.ScriptableObject
    {
        // Fields
        public Beyond.SerializeFieldDictionary<Proto.CSMessageID,Proto.SCMessageID> msgs;  // 0x18
        public System.Collections.Generic.List<Beyond.Network.NetworkMaskConfig.Config> configs;  // 0x20

        // Methods
        // RVA: 0x03C8A0F0  token: 0x60000FD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x10
    public static class NetworkUrls
    {
        // Fields
        public static System.String URL_GET_SPLIT;  // const

        // Methods
        // RVA: 0x02C37520  token: 0x60000FF
        public static System.String RemoteConfigUrl() { }
        // RVA: 0x092A6288  token: 0x6000100
        public static System.String ResourceRootUrlDev(System.String version) { }
        // RVA: 0x02F42910  token: 0x6000101
        public static System.String ServerListUrl() { }
        // RVA: 0x092A6160  token: 0x6000102
        public static System.String AgeTipsUrl() { }
        // RVA: 0x092A61F4  token: 0x6000103
        public static System.String GovUrl() { }
        // RVA: 0x02C3DFE0  token: 0x6000104
        public static System.String LauncherUrl() { }
        // RVA: 0x02C3F990  token: 0x6000105
        private static System.String _SelectUrl(System.String urlInConfig, Beyond.Network.NetworkUrls.EUrlType urlType) { }
        // RVA: 0x02F42940  token: 0x6000106
        private static System.String _GetUrlFromLocal(Beyond.Network.NetworkUrls.EUrlType type) { }

    }

    // TypeToken: 0x2000033  // size: 0x50
    public class TcpIO : Beyond.Network.INetIO, System.IDisposable
    {
        // Fields
        private Beyond.Network.HGTcpClient m_tcpClient;  // 0x10
        protected System.Byte[] m_recvBuffer;  // 0x18
        protected System.Byte[] m_sendHeadBuffer;  // 0x20
        protected System.Byte[] m_sendBuffer;  // 0x28
        protected System.Int32 m_recvBufferOffset;  // 0x30
        private Beyond.XXEnc.XXE1 m_encryptor;  // 0x38
        private Beyond.XXEnc.XXE1 m_decryptor;  // 0x40
        protected System.Boolean m_isAuthed;  // 0x48
        private System.Boolean m_bIsTestDropSC;  // 0x49
        private System.Boolean m_bIsTestDropCS;  // 0x4a
        private System.Boolean m_bIsTestReconnectFailed;  // 0x4b
        public static System.Int32 SEND_HEAD_BUFFER_LENGTH;  // const
        public static System.Int32 s_MAX_SEND_SIZE;  // static @ 0x0

        // Methods
        // RVA: 0x0293E650  token: 0x6000107
        public virtual System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        // RVA: 0x0293DC50  token: 0x6000108
        public virtual System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        // RVA: 0x024CC140  token: 0x6000109
        public virtual System.Boolean IsAuthed() { }
        // RVA: 0x02944CC0  token: 0x600010A
        public virtual System.Void MarkAuthed() { }
        // RVA: 0x039B3E60  token: 0x600010B
        public virtual System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv) { }
        // RVA: 0x092A6788  token: 0x600010C
        public virtual System.Net.EndPoint GetEndPoint() { }
        // RVA: 0x029436C0  token: 0x600010D
        public virtual System.Void Close() { }
        // RVA: 0x092A67F8  token: 0x600010E
        public virtual System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed) { }
        // RVA: 0x092A6864  token: 0x600010F
        public virtual System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS) { }
        // RVA: 0x024CB1A0  token: 0x6000110
        public virtual System.Boolean IsConnected() { }
        // RVA: 0x024D1080  token: 0x6000111
        public virtual System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        // RVA: 0x024D3190  token: 0x6000112
        public virtual System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        // RVA: 0x024D3160  token: 0x6000113
        public virtual System.Byte[] GetSendHeadBuffer() { }
        // RVA: 0x024D2290  token: 0x6000114
        public virtual System.Byte[] GetSendBuffer() { }
        // RVA: 0x024CBF80  token: 0x6000115
        public virtual System.Byte[] GetReceiveBuffer() { }
        // RVA: 0x03199FF0  token: 0x6000116
        public virtual System.Void ClearReceiveBufferOffset() { }
        // RVA: 0x024CB3A0  token: 0x6000117
        public virtual System.Int32 GetReceiveBufferOffset() { }
        // RVA: 0x031681D0  token: 0x6000118
        public virtual System.Void SkipReceiveBufferOffset(System.Int32 len) { }
        // RVA: 0x024D1450  token: 0x6000119
        public virtual System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        // RVA: 0x024D1320  token: 0x600011A
        public virtual System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        // RVA: 0x024CB700  token: 0x600011B
        public virtual System.Int32 Available() { }
        // RVA: 0x02943610  token: 0x600011C
        public virtual System.Void Dispose() { }
        // RVA: 0x02943480  token: 0x600011D
        protected virtual System.Void Finalize() { }
        // RVA: 0x0350B670  token: 0x600011E
        public System.Void .ctor() { }
        // RVA: 0x03D43AA0  token: 0x600011F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x10
    public static class HttpSender
    {
        // Fields
        public static System.String CONTENT_TYPE_JSON;  // const
        public static System.String CONTENT_ENCODING_GZIP;  // const
        public static System.Int32 ERROR_CODE_TIMEOUT;  // const
        public static System.Int32 ERROR_CODE_DNS_FAILED;  // const
        public static System.Int32 ERROR_CODE_DESERIALIZE;  // const
        public static System.Single TIMEOUT_DEFAULT;  // const
        private static System.Int32 OPT_GET;  // const
        private static System.Int32 OPT_POST;  // const

        // Methods
        // RVA: 0x02C36C00  token: 0x6000120
        public static System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: -1  // generic def  token: 0x6000121
        public static System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: 0x02F42BA0  token: 0x6000122
        public static System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: 0x092A2C84  token: 0x6000123
        public static System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: -1  // generic def  token: 0x6000124
        public static System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: 0x039DC990  token: 0x6000125
        public static System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: 0x092A2B88  token: 0x6000126
        public static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        // RVA: 0x092A29EC  token: 0x6000127
        public static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url) { }
        // RVA: 0x092A2A8C  token: 0x6000128
        public static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        // RVA: -1  // generic def  token: 0x6000129
        public static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        // RVA: -1  // generic def  token: 0x600012A
        public static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        // RVA: 0x02F429F0  token: 0x600012B
        public static System.Int32 GetGeneralErrorCode(Beyond.Network.HttpSender.Result result, System.Boolean& hasError) { }
        // RVA: 0x026921B0  token: 0x600012C
        private static System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        // RVA: 0x03765670  token: 0x600012D
        private static System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Misc.ObjectRef resultRef, Beyond.Network.HttpSender.FSendFunc sendFunc, System.Type respType) { }
        // RVA: 0x092A2ED8  token: 0x600012E
        private static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        // RVA: -1  // generic def  token: 0x600012F
        private static Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        // RVA: 0x038CEAA0  token: 0x6000130
        private static System.Void _StartWebRequestTask(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        // RVA: 0x03C90670  token: 0x6000131
        private static System.Void _WaitForServiceDone(Beyond.Network.HttpSender.Result result) { }
        // RVA: 0x02C47800  token: 0x6000132
        private static UnityEngine.Networking.UnityWebRequest _CreateWebRequestGET(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        // RVA: 0x02C47F30  token: 0x6000133
        private static UnityEngine.Networking.UnityWebRequest _CreateWebRequestPOST(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        // RVA: 0x02C47610  token: 0x6000134
        private static System.Void _SetHttpResult(Beyond.Network.HttpSender.Result result, UnityEngine.Networking.UnityWebRequest request) { }
        // RVA: 0x02692ED0  token: 0x6000135
        private static System.Void _DeserializeTypedResult(Beyond.Network.HttpSender.TypedResult result) { }
        // RVA: 0x092A2D6C  token: 0x6000136
        private static System.Void _DebugOnlyProfileResult(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        // RVA: 0x092A2E04  token: 0x6000137
        private static System.Void _MarkResultAsException(Beyond.Network.HttpSender.Result result, System.Exception ex) { }

    }

    // TypeToken: 0x2000047
    public class CircularBuffer`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private readonly T[] m_buffer;  // 0x0
        private System.Int32 m_end;  // 0x0
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_start;  // 0x0

        // Properties
        System.Int32 Capacity { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsFull { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsEmpty { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600017D
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x600017E
        public System.Void .ctor(System.Int32 capacity, T[] items) { }
        // RVA: -1  // not resolved  token: 0x6000185
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000186
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000187
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000188
        public T Front() { }
        // RVA: -1  // not resolved  token: 0x6000189
        public System.Boolean TryFront(T& result) { }
        // RVA: -1  // not resolved  token: 0x600018A
        public T Back() { }
        // RVA: -1  // not resolved  token: 0x600018B
        public System.Boolean TryBack(T& result) { }
        // RVA: -1  // not resolved  token: 0x600018C
        public System.Void PushBack(T item) { }
        // RVA: -1  // not resolved  token: 0x600018D
        public System.Void PushFront(T item) { }
        // RVA: -1  // not resolved  token: 0x600018E
        public System.Void PopBack() { }
        // RVA: -1  // not resolved  token: 0x600018F
        public System.Void PopFront() { }
        // RVA: -1  // not resolved  token: 0x6000190
        public System.Boolean TryPopFront(T& result) { }
        // RVA: -1  // not resolved  token: 0x6000191
        public System.Boolean TryPopBack(T& result) { }
        // RVA: -1  // not resolved  token: 0x6000192
        public T[] ToArray() { }
        // RVA: -1  // not resolved  token: 0x6000193
        private System.Void _ThrowIfEmpty(System.String message) { }
        // RVA: -1  // not resolved  token: 0x6000194
        private System.Void _Increment(System.Int32& index) { }
        // RVA: -1  // not resolved  token: 0x6000195
        private System.Void _Decrement(System.Int32& index) { }
        // RVA: -1  // not resolved  token: 0x6000196
        private System.Int32 _InternalIndex(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000197
        private System.ArraySegment<T> _ArrayOne() { }
        // RVA: -1  // not resolved  token: 0x6000198
        private System.ArraySegment<T> _ArrayTwo() { }

    }

    // TypeToken: 0x2000049  // size: 0xC0
    public abstract class HGNetBaseSession
    {
        // Fields
        private Beyond.Network.INetIO m_tcpIO;  // 0x10
        public static System.Int32 s_recvBuffLen;  // static @ 0x0
        public static System.Int32 s_tcpSendTimeout;  // static @ 0x4
        public static System.Int32 s_sessionThreadSleepTimeMS;  // static @ 0x8
        public static System.Int32 s_sessionThreadPauseSleepTimeMS;  // static @ 0xc
        public System.Int32 m_maxReconnectTimeout;  // 0x18
        public System.Int32 m_maxReconnectTimes;  // 0x1c
        public System.Int32 sendNumLimit;  // 0x20
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse> m_recvQueue;  // 0x28
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_sendQueue;  // 0x30
        private static System.Int32 MAX_RECYCLE_QUEUE_COUNT;  // const
        protected Beyond.Network.CircularBuffer<Beyond.Network.NetRequest> m_circularBuffer;  // 0x38
        private System.Int64 m_csSeqId;  // 0x40
        protected System.Int64 m_scSeqId;  // 0x48
        protected System.Threading.Tasks.Task m_threadTask;  // 0x50
        protected System.Int32 m_threadTaskSignalID;  // 0x58
        protected Beyond.ELogChannel m_logChannel;  // 0x5c
        protected System.Boolean m_isSyncFullDataEnd;  // 0x5d
        protected Google.Protobuf.IMessage m_lastLoginMsg;  // 0x60
        private System.String m_lastConnectServerIp;  // 0x68
        private System.Int32 m_lastConnectServerPort;  // 0x70
        protected System.Int32 m_tryReconnectTimes;  // 0x74
        protected System.Boolean m_isAutoReconnect;  // 0x78
        protected System.Int64 m_startReconnectTimestampMS;  // 0x80
        protected System.Int32 m_closeNetMsgID;  // 0x88
        public static System.Int32 INVALID_SESSION_ID;  // static @ 0x10
        protected static System.Int32 s_sessionIDGenerator;  // static @ 0x14
        private System.Int32 <sessionID>k__BackingField;  // 0x8c
        protected Beyond.Network.HGNetSessionConnectYield m_lastAsyncConnectHandle;  // 0x90
        protected Beyond.Network.EHGNetSessionState m_state;  // 0x98
        private Beyond.Network.EHGNetSessionReconnectState m_reconnectState;  // 0x99
        protected System.Double m_startReconnectTimeMS;  // 0xa0
        protected System.Int32 m_closeErrorCode;  // 0xa8
        public static System.Boolean s_applicationIsPaused;  // static @ 0x18
        private System.Int64 m_clientLastReceiveMsgMilliTs;  // 0xb0
        private System.Int64 m_clientLastSendMsgMilliTs;  // 0xb8

        // Properties
        System.Int32 sessionID { get; /* RVA: 0x03D4F3D0 */ set; /* RVA: 0x03D4F420 */ }
        Beyond.Network.EHGNetSessionReconnectState reconnectState { get; /* RVA: 0x03D6E080 */ set; /* RVA: 0x02944CF0 */ }
        System.Boolean isRunning { get; /* RVA: 0x024C6600 */ }
        System.Boolean isConnecting { get; /* RVA: 0x092A0130 */ }
        System.Boolean isRunningAndConnected { get; /* RVA: 0x024C6690 */ }
        System.Boolean isReconnecting { get; /* RVA: 0x024C6FA0 */ }
        System.Int32 closeErrorCode { get; /* RVA: 0x03D51860 */ }
        System.Boolean isAutoReconnect { get; /* RVA: 0x03D4F800 */ }
        System.Int32 maxRecycleQueueCount { get; /* RVA: 0x03D5A950 */ }

        // Methods
        // RVA: 0x029430F0  token: 0x60001AA
        public virtual System.Void Start() { }
        // RVA: 0x0929FD30  token: 0x60001AB
        public virtual System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect) { }
        // RVA: 0x0293D1B0  token: 0x60001AC
        public virtual System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle) { }
        // RVA: 0x038A22D0  token: 0x60001AD
        public System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, Beyond.Network.INetIO tcpIO) { }
        // RVA: -1  // abstract  token: 0x60001AE
        protected virtual System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x0293DFE0  token: 0x60001AF
        private System.Void _DNSCheck(System.String serverIp) { }
        // RVA: 0x0267B3E0  token: 0x60001B0
        public virtual System.Void Close(Beyond.Network.ENetCloseReason netCloseReason) { }
        // RVA: 0x092A00B4  token: 0x60001B1
        protected System.Void InternalClose(Beyond.Network.INetIO tcpIO, Beyond.Network.ENetCloseReason netCloseReason) { }
        // RVA: 0x029432A0  token: 0x60001B2
        protected System.Void InternalClose(Beyond.Network.INetIO tcpIO, System.Int32 netCloseReason) { }
        // RVA: 0x02947280  token: 0x60001B3
        protected System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg) { }
        // RVA: 0x024CCFD0  token: 0x60001B4
        public System.Int32 GetSendQueueMsgCount() { }
        // RVA: 0x02947240  token: 0x60001B5
        protected System.Int64 IncrementCSSeqID() { }
        // RVA: 0x02F0D690  token: 0x60001B6
        protected System.Void SetCSSeqID(System.Int64 id) { }
        // RVA: 0x092A0064  token: 0x60001B7
        protected System.Int64 GetCSSeqID() { }
        // RVA: 0x02F0D630  token: 0x60001B8
        protected Beyond.Network.INetIO GetIO() { }
        // RVA: 0x0293D780  token: 0x60001B9
        protected System.Void StartTCPMsgLoopThreadTask() { }
        // RVA: 0x029441B0  token: 0x60001BA
        protected System.Void CloseTCPMsgThreadTask() { }
        // RVA: 0x0397CF20  token: 0x60001BB
        private System.Threading.Tasks.Task _SessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        // RVA: 0x024CC200  token: 0x60001BC
        private System.Boolean _SendAndCheckMessage(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        // RVA: 0x024C8290  token: 0x60001BD
        private System.Boolean _ReadAndCheckMessageInSessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        // RVA: -1  // abstract  token: 0x60001BE
        protected virtual System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        // RVA: -1  // abstract  token: 0x60001BF
        protected virtual System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m) { }
        // RVA: -1  // abstract  token: 0x60001C0
        protected virtual System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        // RVA: 0x024CAD30  token: 0x60001C1
        protected System.Void SessionCheckSignalAndSleep(System.Int32 threadID) { }
        // RVA: 0x02D75B70  token: 0x60001C2
        protected System.Void OpenAutoReconnect() { }
        // RVA: 0x02943450  token: 0x60001C3
        protected System.Void RemoveAutoReconnect() { }
        // RVA: 0x024C8FA0  token: 0x60001C4
        private System.Threading.Tasks.Task _ReconnectCheckerTick(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x032F8460  token: 0x60001C5
        protected System.Threading.Tasks.Task<System.Boolean> TryConnectWithTimeout(Beyond.Network.INetIO tcpIO, System.String ip, System.Int32 port, System.Int32 sendTimeout, System.Int32 receiveBufferLen, System.Int32 timeoutMilliseconds) { }
        // RVA: 0x032F85D0  token: 0x60001C6
        protected System.Threading.Tasks.Task<System.Boolean> TryCloseTcpIOWithTimeout(Beyond.Network.INetIO tcpIO, System.Int32 timeoutMilliseconds) { }
        // RVA: -1  // abstract  token: 0x60001C7
        protected virtual System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        // RVA: -1  // abstract  token: 0x60001C8
        protected virtual System.Boolean NeedKeepConnect() { }
        // RVA: -1  // abstract  token: 0x60001C9
        protected virtual System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        // RVA: -1  // abstract  token: 0x60001CA
        protected virtual System.Void InitClientRSAKey() { }
        // RVA: -1  // abstract  token: 0x60001CB
        protected virtual System.Void ClearRSAKey() { }
        // RVA: -1  // abstract  token: 0x60001CC
        public virtual System.Void ClearRecvQueue() { }
        // RVA: -1  // abstract  token: 0x60001CD
        public virtual System.Void ClearSendQueue() { }
        // RVA: 0x024C8D50  token: 0x60001CE
        protected System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount) { }
        // RVA: 0x024CC720  token: 0x60001CF
        protected System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount) { }
        // RVA: -1  // abstract  token: 0x60001D0
        protected virtual System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        // RVA: -1  // abstract  token: 0x60001D1
        protected virtual System.Void ClearPingWDG() { }
        // RVA: -1  // abstract  token: 0x60001D2
        protected virtual System.Boolean IsPingOut() { }
        // RVA: -1  // abstract  token: 0x60001D3
        protected virtual System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        // RVA: 0x02F0EDC0  token: 0x60001D4
        protected System.Void .ctor() { }
        // RVA: 0x03CC52F0  token: 0x60001D5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x168
    public class HGNetSession : Beyond.Network.HGNetBaseSession
    {
        // Fields
        private System.String m_uid;  // 0xc0
        private System.String m_token;  // 0xc8
        private System.Int32 m_channel;  // 0xd0
        public static System.Int32 LOGIN_TIMEOUT;  // static @ 0x0
        public static System.Int32 MAX_CLIENT_RESEND_NUM;  // static @ 0x4
        public static System.Single PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS;  // static @ 0x8
        public static System.Single PER_FRAME_RECEIVED_MESSAGES_TIME;  // static @ 0xc
        public static System.Single MESSAGE_MAX_DELAY_TIME;  // static @ 0x10
        protected System.Int32 m_messageDelayCount;  // 0xd4
        protected System.Int64 m_logCDTimestamp;  // 0xd8
        private static System.Boolean s_HGNetSessionBurst;  // static @ 0x14
        private readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_frameSendQueue;  // 0xe0
        private System.Collections.Generic.Queue<Beyond.Network.NetRequest> m_mergeQueueCache;  // 0xe8
        private System.Object m_frameSendQueueLocker;  // 0xf0
        private System.Byte[] m_frameSendPacketBuffer;  // 0xf8
        private System.Byte[] m_frameSendPacketHeadBuffer;  // 0x100
        private System.Byte[] m_frameSendPacketTempBuffer;  // 0x108
        private System.Byte[] m_frameSendCryptoBuffer;  // 0x110
        private System.Byte[] m_frameReceivePacketBuffer;  // 0x118
        public static System.Int64 s_maxframeSendPacketBuffer;  // static @ 0x18
        public static System.Int64 s_maxPackedMessageNum;  // static @ 0x20
        protected readonly System.Collections.Generic.Queue<Beyond.Network.NetResponse> m_callbackQueue;  // 0x120
        private Beyond.Network.HGNetSessionLoginYield m_currLoginHandle;  // 0x128
        private static System.Int32 SEND_PING_DELTA_TICK_TIME_MS;  // const
        private static System.Int32 s_pingWdgOutTimes;  // static @ 0x28
        private static System.Int32 s_pingSyncFullEndBeforeTimes;  // static @ 0x2c
        private System.Int64 m_needSendPingTimer;  // 0x130
        private System.Int32 m_pingWDG;  // 0x138
        private System.Int64 m_clientTsDelayms;  // 0x140
        private System.Int32 m_pingValue;  // 0x148
        private System.Boolean m_isPingInProgress;  // 0x14c
        private System.Int64 m_isPingInProgressStartTime;  // 0x150
        private static readonly System.String CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT;  // static @ 0x30
        private static readonly System.String CLIENT_NET_RSA_PUBLIC_KEY;  // static @ 0x38
        private static readonly System.String CLIENT_NET_RSA_PRIVATE_KEY;  // static @ 0x40
        private static System.Byte[] s_clientPublicKeyBytes;  // static @ 0x48
        private System.Security.Cryptography.RSA m_rsaClientPrivateProvider;  // 0x158
        private static readonly System.Byte[] EMPTY_BYTES;  // static @ 0x50
        private static System.Int32 s_CacheLogLength;  // static @ 0x58
        private System.Text.StringBuilder m_sbCache;  // 0x160

        // Methods
        // RVA: 0x0229B650  token: 0x60001E6
        public System.Void SetAutoReconnectToken(System.String uid, System.String token, System.Int32 channel) { }
        // RVA: 0x02FCABF0  token: 0x60001E7
        protected virtual System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        // RVA: 0x092A0204  token: 0x60001E8
        protected virtual System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        // RVA: 0x03A614C0  token: 0x60001E9
        public virtual System.Void Start() { }
        // RVA: 0x092A0938  token: 0x60001EA
        public System.Void OnApplicationPause(System.Boolean pause) { }
        // RVA: 0x02946500  token: 0x60001EB
        public System.UInt64 SendMessage(Google.Protobuf.IMessage msg) { }
        // RVA: 0x092A0A8C  token: 0x60001EC
        protected System.Void PackMessageToSendQueue() { }
        // RVA: 0x092A1204  token: 0x60001ED
        public System.Void UpdateInGameThread() { }
        // RVA: 0x092A11E4  token: 0x60001EE
        public System.Void TailLateUpdateInGameThread() { }
        // RVA: 0x092A1268  token: 0x60001EF
        private System.Single _GetMessageTimeLimit() { }
        // RVA: 0x092A1C64  token: 0x60001F0
        private System.Void _ProcessReceivedMessagesInGameThread(System.Boolean flushAll) { }
        // RVA: 0x0229CE50  token: 0x60001F1
        public Beyond.Network.HGNetSessionLoginYield LoginAsync(System.String uid, System.String token, System.Int32 channel) { }
        // RVA: 0x02F42E90  token: 0x60001F2
        private static System.Void _CSLoginHelper_UpdateAppInfo(Proto.MSG_A1 msg) { }
        // RVA: 0x02F432D0  token: 0x60001F3
        private static System.String _GetOnlineResVersion() { }
        // RVA: 0x02F42650  token: 0x60001F4
        private static Proto.ENV_TYPE _GetSDKEnv() { }
        // RVA: 0x02F42AF0  token: 0x60001F5
        private static Proto.CLIENT_PLATFORM_TYPE _GetPlatformID() { }
        // RVA: 0x02F42A60  token: 0x60001F6
        private static System.Int32 _GetPayPlatform() { }
        // RVA: 0x02F0D2B0  token: 0x60001F7
        private System.Void _SessionLoginThreadTask(System.Object handle) { }
        // RVA: 0x02D75AC0  token: 0x60001F8
        public System.Void StartMsgLoop() { }
        // RVA: 0x03D48E60  token: 0x60001F9
        protected virtual System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x092A0A20  token: 0x60001FA
        protected virtual System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x02FCACE0  token: 0x60001FB
        protected virtual System.Boolean NeedKeepConnect() { }
        // RVA: 0x032BA150  token: 0x60001FC
        protected virtual System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& req) { }
        // RVA: 0x024D2DD0  token: 0x60001FD
        private System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& request, System.Boolean useSRSA) { }
        // RVA: 0x024CD2A0  token: 0x60001FE
        protected virtual System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        // RVA: 0x024CA720  token: 0x60001FF
        private System.Boolean _ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp, System.Boolean useSRSA) { }
        // RVA: 0x024C6FB0  token: 0x6000200
        public virtual System.Void ClearRecvQueue() { }
        // RVA: 0x03D00680  token: 0x6000201
        public virtual System.Void ClearSendQueue() { }
        // RVA: 0x092A1190  token: 0x6000202
        public static System.Void SetBurstMode(System.Boolean val) { }
        // RVA: 0x03CFA670  token: 0x6000203
        protected virtual System.Void Finalize() { }
        // RVA: 0x024C64F0  token: 0x6000204
        public System.Int32 GetPing() { }
        // RVA: 0x092A08E8  token: 0x6000205
        public System.Boolean IsPingInProgress() { }
        // RVA: 0x03559D50  token: 0x6000206
        public System.Int64 GetPingPassedTime() { }
        // RVA: 0x034564F0  token: 0x6000207
        protected virtual System.Void ClearPingWDG() { }
        // RVA: 0x02F0D6D0  token: 0x6000208
        private System.Void _ApproximateLoginServerTime(System.Int64 serverTimeMS, System.Int32 serverZone) { }
        // RVA: 0x031DA430  token: 0x6000209
        private System.Boolean _HandleSpecialMessagePing(Beyond.Network.NetResponse m) { }
        // RVA: 0x024CCE60  token: 0x600020A
        protected virtual System.Boolean IsPingOut() { }
        // RVA: 0x024CD3A0  token: 0x600020B
        protected virtual System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        // RVA: 0x0229D780  token: 0x600020C
        public static System.Byte[] GetClientPublicKey() { }
        // RVA: 0x031854A0  token: 0x600020D
        protected virtual System.Void InitClientRSAKey() { }
        // RVA: 0x03187930  token: 0x600020E
        private System.Byte[] _RSADecrypt(System.Byte[] data) { }
        // RVA: 0x092A013C  token: 0x600020F
        protected virtual System.Void ClearRSAKey() { }
        // RVA: 0x024C7660  token: 0x6000210
        protected virtual System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& msg) { }
        // RVA: 0x092A1570  token: 0x6000211
        private System.Boolean _HandleSpecialMessageReconnectIncr(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        // RVA: 0x092A13C8  token: 0x6000212
        private System.Boolean _HandleSpecialMessageReconnectFull(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        // RVA: 0x092A12E8  token: 0x6000213
        private System.Boolean _HandleSpecialMessageErrorCode(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        // RVA: 0x092A1AC8  token: 0x6000214
        private System.Boolean _HandleSpecialMessageReconnectLogin(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        // RVA: 0x03187610  token: 0x6000215
        private System.Void _HandleLoginEncryp(Beyond.Network.INetIO netIO, Proto.MSG_B1 msg) { }
        // RVA: 0x02F0EB50  token: 0x6000216
        public System.Void .ctor() { }
        // RVA: 0x03A27930  token: 0x6000217
        private static System.Void .cctor() { }
        // RVA: 0x092A11FC  token: 0x6000218
        public System.Void <>iFixBaseProxy_Start() { }

    }

    // TypeToken: 0x2000053  // size: 0x11
    public sealed struct EHGNetSessionState
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Network.EHGNetSessionState Closed;  // const
        public static Beyond.Network.EHGNetSessionState Opened;  // const
        public static Beyond.Network.EHGNetSessionState Connecting;  // const
        public static Beyond.Network.EHGNetSessionState SessionRunning;  // const

    }

    // TypeToken: 0x2000054  // size: 0x11
    public sealed struct EHGNetSessionReconnectState
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Network.EHGNetSessionReconnectState None;  // const
        public static Beyond.Network.EHGNetSessionReconnectState ReconnectingTcp;  // const
        public static Beyond.Network.EHGNetSessionReconnectState SendLogin;  // const
        public static Beyond.Network.EHGNetSessionReconnectState ResendPack;  // const

    }

    // TypeToken: 0x2000055  // size: 0x14
    public sealed struct ENetCloseReason
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Network.ENetCloseReason Invalid;  // const
        public static Beyond.Network.ENetCloseReason None;  // const
        public static Beyond.Network.ENetCloseReason ForServerErrorMax;  // const
        public static Beyond.Network.ENetCloseReason ConnectFailed;  // const
        public static Beyond.Network.ENetCloseReason ServerReconnectFailed;  // const
        public static Beyond.Network.ENetCloseReason TooMuchClientReconnectPack;  // const
        public static Beyond.Network.ENetCloseReason ServerReconnectFullPack;  // const
        public static Beyond.Network.ENetCloseReason ClientShutDown;  // const
        public static Beyond.Network.ENetCloseReason ClientLaunch;  // const
        public static Beyond.Network.ENetCloseReason ClientReconnectTooMuchTimes;  // const

    }

    // TypeToken: 0x2000056  // size: 0x10
    public static class HGNetSessionUtils
    {
        // Methods
        // RVA: 0x092A9F08  token: 0x6000219
        public static System.Boolean CheckErrorNeedsDisconnect(Proto.CODE errorCode) { }

    }

    // TypeToken: 0x2000057  // size: 0x10
    public static class HGNetSessionConstant
    {
        // Fields
        public static System.Int32 CODE_SUC;  // const
        public static System.Int32 CODE_CONN_FAILED;  // const
        public static System.Int32 CODE_CONN_WAIT;  // const

    }

    // TypeToken: 0x2000058  // size: 0x14
    public sealed struct ENetConnectErrorCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Network.ENetConnectErrorCode Invalid;  // const
        public static Beyond.Network.ENetConnectErrorCode None;  // const
        public static Beyond.Network.ENetConnectErrorCode ForServerErrorMax;  // const
        public static Beyond.Network.ENetConnectErrorCode ConnectError;  // const
        public static Beyond.Network.ENetConnectErrorCode TimeOut;  // const

    }

    // TypeToken: 0x2000059  // size: 0x38
    public class HGNetSessionLoginYield : UnityEngine.CustomYieldInstruction
    {
        // Fields
        private Beyond.Network.HGNetSessionLoginYield.LoginErrorInfo m_loginErrorInfo;  // 0x10
        private System.Boolean m_bIsFinish;  // 0x18
        private Proto.MSG_A1 m_request;  // 0x20
        private Proto.MSG_B1 m_resp;  // 0x28
        private System.Object m_locker;  // 0x30

        // Properties
        System.Boolean isSucceed { get; /* RVA: 0x0229C1D0 */ }
        System.Boolean keepWaiting { get; /* RVA: 0x03D032E0 */ }

        // Methods
        // RVA: 0x02F0EF20  token: 0x600021A
        public System.Void .ctor() { }
        // RVA: 0x02F0E970  token: 0x600021B
        public System.Void .ctor(Proto.MSG_A1 req) { }
        // RVA: 0x02F0D660  token: 0x600021C
        public Proto.MSG_A1 GetRequest() { }
        // RVA: 0x0229C5A0  token: 0x600021D
        public Proto.MSG_B1 GetResponse() { }
        // RVA: 0x092A9B40  token: 0x600021E
        public System.Int32 GetErrorCode() { }
        // RVA: 0x092A9B98  token: 0x600021F
        public System.String GetErrorDetails() { }
        // RVA: 0x02F0E780  token: 0x6000220
        public System.Void SetSucceed(Proto.MSG_B1 sc) { }
        // RVA: 0x092A9CE8  token: 0x6000221
        public System.Void SetNtfError(System.Int32 ntfErrorCode, System.String ntfErrorDetails) { }
        // RVA: 0x092A9BF0  token: 0x6000222
        public System.Void SetConnectErrorError() { }
        // RVA: 0x092A9E10  token: 0x6000223
        public System.Void SetTimeOutError() { }

    }

    // TypeToken: 0x200005B  // size: 0x20
    public class HGNetSessionConnectYield : UnityEngine.CustomYieldInstruction
    {
        // Fields
        private System.Threading.Tasks.Task m_connectTask;  // 0x10
        private Beyond.Network.ENetConnectErrorCode connectErrorCode;  // 0x18

        // Properties
        System.Boolean isSucceed { get; /* RVA: 0x0229C590 */ }
        System.Boolean keepWaiting { get; /* RVA: 0x03CB5470 */ }

        // Methods
        // RVA: 0x03D50330  token: 0x6000230
        public System.Void .ctor() { }
        // RVA: 0x030840F0  token: 0x6000231
        public System.Void .ctor(System.Threading.Tasks.Task connectTask) { }
        // RVA: 0x092A9AF4  token: 0x6000232
        public System.Int32 GetCode() { }
        // RVA: 0x038A2420  token: 0x6000233
        public System.Void SetFinish(Beyond.Network.ENetConnectErrorCode code) { }

    }

}

namespace Beyond.Network.HGNetLogger
{

    // TypeToken: 0x200005C  // size: 0x98
    public abstract class HGNetLogBaseSession
    {
        // Fields
        private readonly Beyond.Network.INetIO m_tcpIO;  // 0x10
        public static System.Int32 s_recvBuffLen;  // static @ 0x0
        public static System.Int32 s_tcpSendTimeout;  // static @ 0x4
        public static System.Int32 s_sessionThreadSleepTimeMS;  // static @ 0x8
        public static System.Int32 s_sessionThreadPauseSleepTimeMS;  // static @ 0xc
        public static System.Int32 s_maxReconnectTimeout;  // static @ 0x10
        public static System.Int32 s_maxReconnectTimes;  // static @ 0x14
        protected System.Int32 m_sendNumLimit;  // 0x18
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse> m_recvQueue;  // 0x20
        private readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_sendQueue;  // 0x28
        private static System.Int32 MAX_RECYCLE_QUEUE_COUNT;  // const
        protected Beyond.Network.CircularBuffer<Beyond.Network.NetRequest> m_circularBuffer;  // 0x30
        private System.Int64 m_csSeqId;  // 0x38
        protected System.Int64 m_scSeqId;  // 0x40
        protected System.Threading.Tasks.Task m_threadTask;  // 0x48
        protected System.Int32 m_threadTaskSignal;  // 0x50
        protected Beyond.ELogChannel m_logChannel;  // 0x54
        private System.String m_lastConnectServerIp;  // 0x58
        private System.Int32 m_lastConnectServerPort;  // 0x60
        protected System.Int32 m_tryReconnectTimes;  // 0x64
        protected System.Int64 m_startReconnectTimestampMS;  // 0x68
        protected System.Boolean m_isAutoReconnect;  // 0x70
        protected Beyond.Network.HGNetSessionConnectYield m_lastAsyncConnectHandle;  // 0x78
        protected Beyond.Network.EHGNetSessionState m_state;  // 0x80
        protected Beyond.Network.EHGNetSessionReconnectState m_reconnectState;  // 0x81
        protected System.Int32 m_closeErrorCode;  // 0x84
        public static System.Boolean s_applicationIsPaused;  // static @ 0x18
        private System.Int64 m_clientLastReceiveMsgMilliTs;  // 0x88
        private System.Int64 m_clientLastSendMsgMilliTs;  // 0x90

        // Properties
        System.Boolean isRunning { get; /* RVA: 0x092A9584 */ }
        System.Boolean isConnecting { get; /* RVA: 0x092A956C */ }
        System.Boolean isRunningAndConnected { get; /* RVA: 0x092A9578 */ }
        System.Int32 closeErrorCode { get; /* RVA: 0x03D4F370 */ }
        System.Boolean isAutoReconnect { get; /* RVA: 0x03D4F260 */ }

        // Methods
        // RVA: 0x092A89EC  token: 0x600023B
        public virtual System.Void Start() { }
        // RVA: 0x092A7EA4  token: 0x600023C
        public virtual System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect) { }
        // RVA: 0x092A7B0C  token: 0x600023D
        public virtual System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle) { }
        // RVA: 0x092A8530  token: 0x600023E
        public System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction) { }
        // RVA: -1  // abstract  token: 0x600023F
        protected virtual System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x092A8B30  token: 0x6000240
        private System.Void _DNSCheck(System.String serverIp) { }
        // RVA: 0x092A78A8  token: 0x6000241
        public virtual System.Void Close(Beyond.Network.ENetCloseReason netCloseReason) { }
        // RVA: 0x092A790C  token: 0x6000242
        public virtual System.Void Close(System.Int32 netCloseReason) { }
        // RVA: 0x092A8188  token: 0x6000243
        protected System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg) { }
        // RVA: 0x092A82DC  token: 0x6000244
        public System.Int32 GetSendQueueMsgCount() { }
        // RVA: 0x092A8358  token: 0x6000245
        protected System.Int64 IncrementCSSeqID() { }
        // RVA: 0x092A87CC  token: 0x6000246
        protected System.Void SetCSSeqID(System.Int64 id) { }
        // RVA: 0x092A823C  token: 0x6000247
        protected System.Int64 GetCSSeqID() { }
        // RVA: 0x092A828C  token: 0x6000248
        protected Beyond.Network.INetIO GetIO() { }
        // RVA: 0x092A8828  token: 0x6000249
        protected System.Void StartTCPMsgLoopThreadTask() { }
        // RVA: 0x092A77C8  token: 0x600024A
        protected System.Void CloseTCPMsgThreadTask() { }
        // RVA: 0x092A8FB0  token: 0x600024B
        private System.Void _SessionThread() { }
        // RVA: -1  // abstract  token: 0x600024C
        protected virtual System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        // RVA: -1  // abstract  token: 0x600024D
        protected virtual System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m) { }
        // RVA: -1  // abstract  token: 0x600024E
        protected virtual System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        // RVA: 0x092A8704  token: 0x600024F
        protected System.Void SessionCheckSignalAndSleep() { }
        // RVA: 0x092A8668  token: 0x6000250
        protected System.Void OpenAutoReconnect() { }
        // RVA: 0x092A86B8  token: 0x6000251
        protected System.Void RemoveAutoReconnect() { }
        // RVA: 0x092A8CEC  token: 0x6000252
        private System.Void _ReconnectCheckerTick() { }
        // RVA: -1  // abstract  token: 0x6000253
        protected virtual System.Void OnReconnectTimesOver() { }
        // RVA: -1  // abstract  token: 0x6000254
        protected virtual System.Boolean NeedKeepConnect() { }
        // RVA: -1  // abstract  token: 0x6000255
        protected virtual System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        // RVA: -1  // abstract  token: 0x6000256
        protected virtual System.Void InitClientRSAKey() { }
        // RVA: -1  // abstract  token: 0x6000257
        protected virtual System.Void ClearRSAKey() { }
        // RVA: 0x092A83B0  token: 0x6000258
        protected System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount) { }
        // RVA: 0x092A8464  token: 0x6000259
        protected System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount) { }
        // RVA: -1  // abstract  token: 0x600025A
        protected virtual System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        // RVA: -1  // abstract  token: 0x600025B
        protected virtual System.Void ClearPingWDG() { }
        // RVA: -1  // abstract  token: 0x600025C
        protected virtual System.Boolean IsPingOut() { }
        // RVA: -1  // abstract  token: 0x600025D
        protected virtual System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        // RVA: 0x092A9424  token: 0x600025E
        protected System.Void .ctor() { }
        // RVA: 0x092A9370  token: 0x600025F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005D  // size: 0x38
    public class HGNetLogger : Beyond.Log.ILogger
    {
        // Fields
        private Beyond.Log.BitArray256 m_enabledLogChannel;  // 0x10
        private System.Collections.Concurrent.ConcurrentQueue<Beyond.Log.FLogMessage> m_logMessagesQueue;  // 0x30
        public static System.Int32 s_maxLogQueueSize;  // static @ 0x0
        public static System.Int32 s_maxRepeatedMsgMs;  // static @ 0x4
        public static System.Int32 s_maxRepeatedMsgCount;  // static @ 0x8

        // Methods
        // RVA: 0x0261BA80  token: 0x6000260
        public virtual System.Void Log(Beyond.Log.FLogMessage& msg) { }
        // RVA: 0x032F5020  token: 0x6000261
        public static Beyond.Network.HGNetLogger.LogLevel ConvertFromDLogger(Beyond.ELogLevel level) { }
        // RVA: 0x032F5080  token: 0x6000262
        public static Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLoggerV2(Beyond.ELogLevel level) { }
        // RVA: 0x03283950  token: 0x6000263
        public System.Boolean CheckLog(Beyond.Log.FLogMessage& msg) { }
        // RVA: 0x0388DD60  token: 0x6000264
        public System.Void Clear() { }
        // RVA: 0x092A9A3C  token: 0x6000265
        public System.Void SetLogChannel(System.UInt64 channel1, System.UInt64 channel2, System.UInt64 channel3, System.UInt64 channel4) { }
        // RVA: 0x0335D9A0  token: 0x6000266
        public static System.Int32 ConvertFromDLogger(Beyond.ELogChannel channel) { }
        // RVA: 0x03B2C9E0  token: 0x6000267
        public System.Void .ctor() { }
        // RVA: 0x03D20A30  token: 0x6000268
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005E  // size: 0x30
    public class HGNetLoggerClient
    {
        // Fields
        private static Beyond.Network.HGNetLogger.HGNetLoggerClient s_instance;  // static @ 0x0
        private static System.Int64 <s_roleID>k__BackingField;  // static @ 0x8
        public Beyond.Network.HGNetLogger.HGNetLoggerSession m_logsession;  // 0x10
        private Beyond.Network.HGNetLogger.HGNetLogger m_netLogger;  // 0x18
        public static readonly System.Int32 MAX_LOG_SEND_QUEUE_SIZE;  // static @ 0x10
        private static System.Int32 MAX_LOCAL_LOG_QUEUE_SIZE;  // const
        private readonly System.Collections.Generic.Queue<Beyond.Log.FLogMessage> m_localLogQueue;  // 0x20
        private readonly System.Object m_queueLock;  // 0x28
        public static Beyond.Network.HGNetLogger.Version s_usedVersion;  // static @ 0x14

        // Properties
        Beyond.Network.HGNetLogger.HGNetLoggerClient instance { get; /* RVA: 0x029456A0 */ }
        System.Int64 s_roleID { get; /* RVA: 0x092A9658 */ set; /* RVA: 0x092A96A8 */ }

        // Methods
        // RVA: 0x03CABDF0  token: 0x6000269
        protected System.Void .ctor() { }
        // RVA: 0x02C3FB70  token: 0x600026D
        public System.Void Init(System.String uid, System.String token, System.String env, System.String roleId) { }
        // RVA: 0x0367C070  token: 0x600026E
        public System.Void AddLog(System.String message, System.String stacktrace, UnityEngine.LogType type) { }
        // RVA: 0x0367C840  token: 0x600026F
        private System.Void _FlushLocalLogQueue() { }
        // RVA: 0x092A9590  token: 0x6000270
        public static System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        // RVA: 0x02C35120  token: 0x6000271
        public System.Void ShutDown() { }
        // RVA: 0x0267B150  token: 0x6000272
        private System.Void _CloseAndClear(Beyond.Network.ENetCloseReason reason) { }
        // RVA: 0x02946870  token: 0x6000273
        public System.Void WriteNetLog(Beyond.Network.HGNetLogger.LogMessage& log) { }
        // RVA: 0x037601E0  token: 0x6000274
        public static System.Void SetRoleID(System.UInt64 roleID) { }
        // RVA: 0x03D48E90  token: 0x6000275
        public System.Void SetNetLogMaskFromServer(Google.Protobuf.Collections.RepeatedField<System.UInt64> masks) { }
        // RVA: 0x03D2C2B0  token: 0x6000276
        private static System.Void .cctor() { }
        // RVA: 0x0388DD40  token: 0x6000277
        private System.Void <Init>b__15_0() { }

    }

    // TypeToken: 0x200005F  // size: 0x30
    public class HGNetLoggerCloudSettings
    {
        // Fields
        public static readonly Beyond.Network.HGNetLogger.HGNetLoggerCloudSettings instance;  // static @ 0x0
        private Beyond.Network.HGNetLogger.LogControl m_cloudLogControl;  // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_cloudChannelLevelMaskTables;  // 0x18
        private Beyond.Network.HGNetLogger.LogControl m_localLogControl;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_localChannelLevelMaskTables;  // 0x28
        private static System.Collections.Generic.List<Beyond.Network.HGNetLogger.NativeLogLevel> s_allLevels;  // static @ 0x8

        // Methods
        // RVA: 0x029474D0  token: 0x6000278
        public static System.Void SetCloudLogControl(Beyond.Network.HGNetLogger.AuthResponse control, Beyond.Network.HGNetBaseSession session) { }
        // RVA: 0x0367CF20  token: 0x6000279
        public static System.Boolean IsNetLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel) { }
        // RVA: 0x02947300  token: 0x600027A
        public static System.Boolean IsNetLogLevelEnabled(Beyond.Network.HGNetLogger.NativeLogLevel level, System.Int32 channel) { }
        // RVA: 0x092A9700  token: 0x600027B
        public static System.Boolean IsLocalLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel) { }
        // RVA: 0x0367CFA0  token: 0x600027C
        public static Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLogger(Beyond.ELogLevel level) { }
        // RVA: 0x039C0490  token: 0x600027D
        public System.Void .ctor() { }
        // RVA: 0x039C0330  token: 0x600027E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000060  // size: 0xF8
    public class HGNetLoggerSession : Beyond.Network.HGNetBaseSession
    {
        // Fields
        private System.Byte[] m_keyBytes;  // 0xc0
        private System.Collections.Generic.Dictionary<System.String,System.Int32> m_templeCRCDict;  // 0xc8
        private System.Action m_onReconnectSuccess;  // 0xd0
        private System.String m_uid;  // 0xd8
        private System.String m_roleId;  // 0xe0
        private System.String m_token;  // 0xe8
        private System.String m_env;  // 0xf0
        private static System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> s_m_messageType2Id;  // static @ 0x0
        private static System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> s_m_messageId2Type;  // static @ 0x8

        // Properties
        System.String uid { get; /* RVA: 0x03D4E7B0 */ }
        System.String roleId { get; /* RVA: 0x03D51140 */ }
        System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> s_messageType2Id { get; /* RVA: 0x024D26A0 */ }
        System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> s_messageId2Type { get; /* RVA: 0x03828370 */ }

        // Methods
        // RVA: 0x024D2620  token: 0x6000283
        public static System.Boolean TryGetMsgTypeByID(System.Type msgType, Beyond.Network.HGNetLogger.MessageType& type) { }
        // RVA: 0x03CFE560  token: 0x6000284
        public virtual System.Void Start() { }
        // RVA: 0x03D1C320  token: 0x6000285
        public System.Void SetReconnectSuccessCallback(System.Action onReconnectSuccess) { }
        // RVA: 0x092A9880  token: 0x6000286
        public System.Void OnApplicationPause(System.Boolean pause) { }
        // RVA: 0x02D75B10  token: 0x6000287
        protected virtual System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x024CC990  token: 0x6000288
        protected virtual System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        // RVA: 0x02944A00  token: 0x6000289
        protected virtual System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        // RVA: 0x024D28E0  token: 0x600028A
        protected virtual System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        // RVA: 0x024D1AD0  token: 0x600028B
        private System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest request) { }
        // RVA: 0x029469C0  token: 0x600028C
        public System.UInt64 SendMessage(Google.Protobuf.IMessage msg) { }
        // RVA: 0x03CA8270  token: 0x600028D
        public System.Void SetAutoReconnectToken(System.String uid, System.String token, System.String env, System.String roleId) { }
        // RVA: 0x024CD0D0  token: 0x600028E
        protected virtual System.Boolean NeedKeepConnect() { }
        // RVA: 0x02944910  token: 0x600028F
        protected virtual System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        // RVA: 0x024CDC10  token: 0x6000290
        private System.Int32 _GetConnectTimeoutTime() { }
        // RVA: 0x024CD980  token: 0x6000291
        protected virtual System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        // RVA: 0x03B6CCC0  token: 0x6000292
        protected virtual System.Void ClearPingWDG() { }
        // RVA: 0x02945E40  token: 0x6000293
        public System.Void SendLogin(Beyond.Network.INetIO netIO) { }
        // RVA: 0x034A9C90  token: 0x6000294
        protected virtual System.Boolean IsPingOut() { }
        // RVA: 0x03091F30  token: 0x6000295
        protected virtual System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        // RVA: 0x03D45040  token: 0x6000296
        protected virtual System.Void InitClientRSAKey() { }
        // RVA: 0x092A983C  token: 0x6000297
        protected virtual System.Void ClearRSAKey() { }
        // RVA: 0x03D450A0  token: 0x6000298
        public virtual System.Void ClearRecvQueue() { }
        // RVA: 0x03D45070  token: 0x6000299
        public virtual System.Void ClearSendQueue() { }
        // RVA: 0x092A9980  token: 0x600029A
        protected virtual System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        // RVA: 0x02F0EA30  token: 0x600029B
        public System.Void .ctor() { }
        // RVA: 0x092A11FC  token: 0x600029C
        public System.Void <>iFixBaseProxy_Start() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000003
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000005
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000061  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x600029D
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x05163BA0  token: 0x600029E
        public System.Void __Gen_Wrap_0(System.Object P0, System.Object P1) { }
        // RVA: 0x054A1028  token: 0x600029F
        public System.Void __Gen_Wrap_1(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x092AB3E4  token: 0x60002A0
        public System.IAsyncResult __Gen_Wrap_2(System.Object P0, System.Object P1, System.Int32 P2, System.Object P3, System.Object P4) { }
        // RVA: 0x092ABC30  token: 0x60002A1
        public System.Threading.Tasks.Task __Gen_Wrap_3(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x092AC94C  token: 0x60002A2
        public System.Net.Sockets.NetworkStream __Gen_Wrap_4(System.Object P0) { }
        // RVA: 0x04274234  token: 0x60002A3
        public System.Void __Gen_Wrap_5(System.Object P0) { }
        // RVA: 0x05477860  token: 0x60002A4
        public System.Void __Gen_Wrap_6(System.Object P0, System.Boolean P1) { }
        // RVA: 0x092AE2D4  token: 0x60002A5
        public System.Net.Sockets.LingerOption __Gen_Wrap_7(System.Object P0) { }
        // RVA: 0x0561B0C4  token: 0x60002A6
        public System.Int32 __Gen_Wrap_8(System.Object P0, System.Net.Sockets.SocketOptionLevel P1, System.Net.Sockets.SocketOptionName P2) { }
        // RVA: 0x050EF614  token: 0x60002A7
        public System.Int32 __Gen_Wrap_9(System.Object P0) { }
        // RVA: 0x0514EF5C  token: 0x60002A8
        public System.Boolean __Gen_Wrap_10(System.Object P0) { }
        // RVA: 0x0516CA20  token: 0x60002A9
        public System.Int64 __Gen_Wrap_11(System.Object P0) { }
        // RVA: 0x092AA6A0  token: 0x60002AA
        public System.UInt64 __Gen_Wrap_12(System.Object P0, System.Object P1) { }
        // RVA: 0x092AA78C  token: 0x60002AB
        public System.Type __Gen_Wrap_13(System.Int32 P0) { }
        // RVA: 0x0514F720  token: 0x60002AC
        public System.Void __Gen_Wrap_14(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x0549D548  token: 0x60002AD
        public System.Void __Gen_Wrap_15(System.Object P0, System.Int32 P1) { }
        // RVA: 0x092AA878  token: 0x60002AE
        public Beyond.Network.NetBus.ResultHandler __Gen_Wrap_16(System.Object P0, System.Object P1) { }
        // RVA: 0x092AA984  token: 0x60002AF
        public System.Void __Gen_Wrap_17(System.Object P0, Beyond.Network.NetResponse& P1) { }
        // RVA: 0x092AAAB0  token: 0x60002B0
        public Beyond.Network.NetBus.ResultHandler __Gen_Wrap_18(System.Object P0, Proto.SCMessageID P1, System.Object P2) { }
        // RVA: 0x0560138C  token: 0x60002B1
        public System.Void __Gen_Wrap_19(System.Object P0, Proto.SCMessageID P1, System.Object P2) { }
        // RVA: 0x092AABD4  token: 0x60002B2
        public System.Int32 __Gen_Wrap_20(System.Object P0, System.Object P1, System.Single P2, System.Single P3) { }
        // RVA: 0x092AACEC  token: 0x60002B3
        public System.Int32 __Gen_Wrap_21(System.Object P0, Proto.CSMessageID P1, System.Single P2) { }
        // RVA: 0x092AADE0  token: 0x60002B4
        public System.Void __Gen_Wrap_22(Beyond.Network.NetResponse& P0) { }
        // RVA: 0x092AAEDC  token: 0x60002B5
        public Beyond.Network.NetBus.ResultHandler __Gen_Wrap_23(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4) { }
        // RVA: 0x092AB024  token: 0x60002B6
        public System.Boolean __Gen_Wrap_24(System.Object P0, System.Object P1) { }
        // RVA: 0x05161B54  token: 0x60002B7
        public System.Void __Gen_Wrap_25(System.Int32 P0, System.Object P1) { }
        // RVA: 0x050F3444  token: 0x60002B8
        public System.Void __Gen_Wrap_26() { }
        // RVA: 0x092AB0FC  token: 0x60002B9
        public System.Boolean __Gen_Wrap_27(System.Span<System.Byte> P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Object P4, Beyond.Network.NetResponse& P5) { }
        // RVA: 0x092AB2B0  token: 0x60002BA
        public System.Int32 __Gen_Wrap_28(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Object P4, System.Int32 P5) { }
        // RVA: 0x050EF54C  token: 0x60002BB
        public System.Void __Gen_Wrap_29(System.Type P0, System.Reflection.MethodInfo P1) { }
        // RVA: 0x050F0008  token: 0x60002BC
        public System.Void __Gen_Wrap_30(System.Object P0, System.Single P1) { }
        // RVA: 0x092AB528  token: 0x60002BD
        public System.String __Gen_Wrap_31() { }
        // RVA: 0x092AB5F4  token: 0x60002BE
        public System.String __Gen_Wrap_32(System.Object P0) { }
        // RVA: 0x092AB6E4  token: 0x60002BF
        public System.String __Gen_Wrap_33(Beyond.Network.NetworkUrls.EUrlType P0) { }
        // RVA: 0x092AB7D0  token: 0x60002C0
        public System.String __Gen_Wrap_34(System.Object P0, Beyond.Network.NetworkUrls.EUrlType P1) { }
        // RVA: 0x092AB8DC  token: 0x60002C1
        public System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5) { }
        // RVA: 0x092ABA00  token: 0x60002C2
        public System.Threading.Tasks.Task __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5) { }
        // RVA: 0x05150B1C  token: 0x60002C3
        public System.Void __Gen_Wrap_37(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x092ABB54  token: 0x60002C4
        public System.Net.EndPoint __Gen_Wrap_38(System.Object P0) { }
        // RVA: 0x05646F78  token: 0x60002C5
        public System.Void __Gen_Wrap_39(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x092ABD54  token: 0x60002C6
        public System.Void __Gen_Wrap_40(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x092ABE5C  token: 0x60002C7
        public System.Byte[] __Gen_Wrap_41(System.Object P0) { }
        // RVA: 0x056275C8  token: 0x60002C8
        public System.Int32 __Gen_Wrap_42(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x092ABF4C  token: 0x60002C9
        public Beyond.Network.HttpSender.Cancellation __Gen_Wrap_43(Beyond.Network.HttpSender.FSendFunc& P0) { }
        // RVA: 0x092AC0FC  token: 0x60002CA
        public UnityEngine.Networking.UnityWebRequest __Gen_Wrap_44(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1) { }
        // RVA: 0x092AC234  token: 0x60002CB
        public UnityEngine.Networking.UnityWebRequest __Gen_Wrap_45(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1) { }
        // RVA: 0x092AC36C  token: 0x60002CC
        public UnityEngine.Networking.UnityWebRequest __Gen_Wrap_46(Beyond.Network.HttpSender.FSendFunc& P0) { }
        // RVA: 0x092AC51C  token: 0x60002CD
        public System.Collections.IEnumerator __Gen_Wrap_47(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1) { }
        // RVA: 0x092AC678  token: 0x60002CE
        public System.Collections.IEnumerator __Gen_Wrap_48(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1, System.Object P2) { }
        // RVA: 0x092AC7EC  token: 0x60002CF
        public System.Collections.IEnumerator __Gen_Wrap_49(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2, System.Object P3) { }
        // RVA: 0x092ACA3C  token: 0x60002D0
        public System.Collections.IEnumerator __Gen_Wrap_50(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2) { }
        // RVA: 0x092ACB8C  token: 0x60002D1
        public System.Collections.IEnumerator __Gen_Wrap_51(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2, System.Object P3) { }
        // RVA: 0x092ACCEC  token: 0x60002D2
        public System.Collections.IEnumerator __Gen_Wrap_52(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2) { }
        // RVA: 0x092ACE2C  token: 0x60002D3
        public System.Void __Gen_Wrap_53(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1) { }
        // RVA: 0x092ACF68  token: 0x60002D4
        public Beyond.Network.HttpSender.Result __Gen_Wrap_54() { }
        // RVA: 0x092AD020  token: 0x60002D5
        public Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_55(Beyond.Network.HttpSender.FSendFunc P0) { }
        // RVA: 0x092AD150  token: 0x60002D6
        public Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_56(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1) { }
        // RVA: 0x092AD278  token: 0x60002D7
        public Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_57(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1) { }
        // RVA: 0x092AD3A0  token: 0x60002D8
        public Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_58(System.Object P0) { }
        // RVA: 0x092AD47C  token: 0x60002D9
        public System.Int32 __Gen_Wrap_59(System.Object P0, System.Boolean& P1) { }
        // RVA: 0x092AD588  token: 0x60002DA
        public System.String __Gen_Wrap_60(Beyond.Network.HttpSender.FSendFunc& P0) { }
        // RVA: 0x0563E0E0  token: 0x60002DB
        public System.Void __Gen_Wrap_61(System.Object P0, Beyond.Network.EHGNetSessionReconnectState P1) { }
        // RVA: 0x054A1028  token: 0x60002DC
        public System.Void __Gen_Wrap_62(System.Object P0, System.Object P1, Beyond.Network.ENetCloseReason P2) { }
        // RVA: 0x092AD728  token: 0x60002DD
        public System.Boolean __Gen_Wrap_63(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3) { }
        // RVA: 0x0549D548  token: 0x60002DE
        public System.Void __Gen_Wrap_64(System.Object P0, Beyond.Network.ENetConnectErrorCode P1) { }
        // RVA: 0x0549D548  token: 0x60002DF
        public System.Void __Gen_Wrap_65(System.Object P0, Beyond.Network.ENetCloseReason P1) { }
        // RVA: 0x050EE850  token: 0x60002E0
        public System.Void __Gen_Wrap_66(System.Threading.Tasks.Task<System.Threading.Tasks.Task> P0) { }
        // RVA: 0x092AD830  token: 0x60002E1
        public System.Boolean __Gen_Wrap_67(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3, Beyond.Network.HGNetSessionConnectYield& P4) { }
        // RVA: 0x092AD9A0  token: 0x60002E2
        public System.Void __Gen_Wrap_68(System.Object P0, Beyond.Network.NetRequest P1) { }
        // RVA: 0x05606CE4  token: 0x60002E3
        public System.Void __Gen_Wrap_69(System.Object P0, System.Int64 P1) { }
        // RVA: 0x092ADABC  token: 0x60002E4
        public Beyond.Network.INetIO __Gen_Wrap_70(System.Object P0) { }
        // RVA: 0x092ADBAC  token: 0x60002E5
        public System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_71(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x092ADCD0  token: 0x60002E6
        public System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_72(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6) { }
        // RVA: 0x092ADE34  token: 0x60002E7
        public System.Threading.Tasks.Task __Gen_Wrap_73(System.Object P0, System.Object P1) { }
        // RVA: 0x092ADF40  token: 0x60002E8
        public System.Void __Gen_Wrap_74(System.Object P0, System.Object P1, System.Int64 P2, System.Int32 P3) { }
        // RVA: 0x05E685F4  token: 0x60002E9
        public System.Boolean __Gen_Wrap_75(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x092AE048  token: 0x60002EA
        public System.Threading.Tasks.Task __Gen_Wrap_76() { }
        // RVA: 0x05E3E6A8  token: 0x60002EB
        public System.Void __Gen_Wrap_77(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        // RVA: 0x092AE100  token: 0x60002EC
        public System.Void __Gen_Wrap_78(System.Object P0, System.Object P1, System.Int64 P2, System.Int64 P3) { }
        // RVA: 0x092AE208  token: 0x60002ED
        public System.Byte[] __Gen_Wrap_79() { }
        // RVA: 0x050EF068  token: 0x60002EE
        public Proto.CLIENT_PLATFORM_TYPE __Gen_Wrap_80() { }
        // RVA: 0x050EF068  token: 0x60002EF
        public Proto.ENV_TYPE __Gen_Wrap_81() { }
        // RVA: 0x050EF068  token: 0x60002F0
        public System.Int32 __Gen_Wrap_82() { }
        // RVA: 0x092AE3C4  token: 0x60002F1
        public System.Void __Gen_Wrap_83(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2, System.Boolean P3) { }
        // RVA: 0x092AE558  token: 0x60002F2
        public System.Boolean __Gen_Wrap_84(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2, System.Boolean P3) { }
        // RVA: 0x092AE6C8  token: 0x60002F3
        public System.Void __Gen_Wrap_85(System.Object P0, System.Int64 P1, System.Int32 P2) { }
        // RVA: 0x092AE7C0  token: 0x60002F4
        public System.Byte[] __Gen_Wrap_86(System.Object P0, System.Object P1) { }
        // RVA: 0x092AE8CC  token: 0x60002F5
        public Proto.MSG_A1 __Gen_Wrap_87(System.Object P0) { }
        // RVA: 0x092AE9BC  token: 0x60002F6
        public Beyond.Network.HGNetSessionLoginYield __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        // RVA: 0x092AEAF0  token: 0x60002F7
        public System.Void __Gen_Wrap_89(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2) { }
        // RVA: 0x092AEC74  token: 0x60002F8
        public System.Boolean __Gen_Wrap_90(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2) { }
        // RVA: 0x092AEDD8  token: 0x60002F9
        public System.Boolean __Gen_Wrap_91(System.Object P0, Beyond.Network.NetResponse P1) { }
        // RVA: 0x08706E14  token: 0x60002FA
        public System.Void __Gen_Wrap_92(System.Object P0, System.Object P1, System.Int64 P2) { }
        // RVA: 0x0514DE88  token: 0x60002FB
        public System.Boolean __Gen_Wrap_93(Proto.CODE P0) { }
        // RVA: 0x092AEF00  token: 0x60002FC
        public System.Boolean __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.Network.NetResponse P2) { }
        // RVA: 0x092AF040  token: 0x60002FD
        public System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2) { }
        // RVA: 0x092AF1C0  token: 0x60002FE
        public Proto.MSG_B1 __Gen_Wrap_96(System.Object P0) { }
        // RVA: 0x092AF2B0  token: 0x60002FF
        public System.Boolean __Gen_Wrap_97(System.Object P0, Beyond.Log.FLogMessage& P1) { }
        // RVA: 0x0562802C  token: 0x6000300
        public Beyond.Network.HGNetLogger.LogLevel __Gen_Wrap_98(Beyond.ELogLevel P0) { }
        // RVA: 0x056280E8  token: 0x6000301
        public Beyond.Network.HGNetLogger.NativeLogLevel __Gen_Wrap_99(Beyond.ELogLevel P0) { }
        // RVA: 0x0562802C  token: 0x6000302
        public System.Int32 __Gen_Wrap_100(Beyond.ELogChannel P0) { }
        // RVA: 0x0560DC74  token: 0x6000303
        public System.Boolean __Gen_Wrap_101(Beyond.Network.HGNetLogger.NativeLogLevel P0, System.Int32 P1) { }
        // RVA: 0x05164540  token: 0x6000304
        public System.Boolean __Gen_Wrap_102(Beyond.ELogLevel P0, Beyond.ELogChannel P1) { }
        // RVA: 0x056479C0  token: 0x6000305
        public System.Void __Gen_Wrap_103(System.Object P0, System.Object P1, System.Object P2, UnityEngine.LogType P3) { }
        // RVA: 0x092A9F70  token: 0x6000306
        public Beyond.Network.HGNetLogger.HGNetLoggerClient __Gen_Wrap_104() { }
        // RVA: 0x092AA03C  token: 0x6000307
        public System.Void __Gen_Wrap_105(System.Object P0, Beyond.Network.HGNetLogger.LogMessage& P1) { }
        // RVA: 0x092AA150  token: 0x6000308
        public System.Void __Gen_Wrap_106(System.Object P0, Beyond.Log.FLogMessage& P1) { }
        // RVA: 0x092AA2C4  token: 0x6000309
        public System.Void __Gen_Wrap_107(System.Object P0, System.UInt64 P1, System.UInt64 P2, System.UInt64 P3, System.UInt64 P4) { }
        // RVA: 0x05476DB4  token: 0x600030A
        public System.Void __Gen_Wrap_108(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        // RVA: 0x050F0C14  token: 0x600030B
        public System.Void __Gen_Wrap_109(System.Boolean P0) { }
        // RVA: 0x0514E6A4  token: 0x600030C
        public System.Void __Gen_Wrap_110(System.UInt64 P0) { }
        // RVA: 0x092AA3D4  token: 0x600030D
        public System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_111() { }
        // RVA: 0x092AA4A0  token: 0x600030E
        public System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> __Gen_Wrap_112() { }
        // RVA: 0x05786028  token: 0x600030F
        public System.Boolean __Gen_Wrap_113(System.Object P0, Beyond.Network.HGNetLogger.MessageType& P1) { }
        // RVA: 0x092AA56C  token: 0x6000310
        public System.Void __Gen_Wrap_114(System.Object P0, System.Object P1, Beyond.Network.NetRequest P2) { }
        // RVA: 0x03D05C60  token: 0x6000311
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x60
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerator`1, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        private System.Int32 methodId_0;  // 0x40
        private System.Int32 methodId_1;  // 0x44
        private System.Int32 methodId_2;  // 0x48
        private System.Int32 methodId_3;  // 0x4c
        private System.Int32 methodId_4;  // 0x50
        private System.Int32 methodId_5;  // 0x54
        private System.Int32 methodId_6;  // 0x58

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x092AF744 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x092AF7F0 */ }

        // Methods
        // RVA: 0x05152EA8  token: 0x6000312
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05152C48  token: 0x6000313
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05152D80  token: 0x6000315
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x092AF434  token: 0x6000317
        private virtual System.Void MoveNext() { }
        // RVA: 0x092AF694  token: 0x6000318
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0) { }
        // RVA: 0x092AF89C  token: 0x6000319
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x092AF558  token: 0x600031A
        public System.Void RefAwaitUnsafeOnCompleteMethod() { }
        // RVA: 0x092AF4C4  token: 0x600031B
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000063  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600031C
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x092AFD08  token: 0x600031D
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x024CB460  token: 0x600031E
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x092AFBC4  token: 0x600031F
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x092AFC90  token: 0x6000320
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x092AFD6C  token: 0x6000321
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x092AFB20  token: 0x6000322
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000064  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect2;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect3;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect2;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-EndConnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync2;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-GetStream0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Close0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Dispose1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-get_LingerState0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-_Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-_NumericOption0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-get_currentSessionID0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-Setup0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-_ValidateSession0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-IncrementCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SendMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetSCMsgTypeById0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-RegisterMessageHandler0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-UnRegisterMessageHandler0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-OnNetClientShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-_SendWithResult0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-_Listen0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-_UnListen0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-_UnListenWithSeqNum0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-_HandleMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-OnResponse0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoSend0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoListen0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoUnListen0;  // const
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-OnNetShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-_ClearSendTime0;  // const
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-OnNetShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMaskConfigHolder-Init0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMaskConfigHolder-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_UpdateMaskState0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-RemoveMask0;  // const
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetCSMsgIdByType0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_GetKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-AddMask0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-AddMask1;  // const
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-OnNetShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-TeleportMaskSender-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-TeleportMaskSender-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-TeleportMaskSender-OnNetShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Send0;  // const
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0;  // const
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Send1;  // const
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-ServerConfig-IsSame0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-RegisterSCMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-RegisterCSMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetSCMsgIdByType0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-FastRegisterMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetNetMessageFromDataBytes0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-SerializeHeadMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-AutoRegisterMessageHandlers0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-_ForeachMessageHandlers0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-PreTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_CreateTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_OnSwitchLanguage0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_ClearTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-OnUnInit0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-Release0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-ListenOnNetMaskChanged0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-RemoteConfigUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-ResourceRootUrlDev0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-_GetUrlFromLocal0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-ServerListUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-_SelectUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-AgeTipsUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-GovUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-LauncherUrl0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-IsConnected0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Close0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Connect0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ConnectAsync0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-IsAuthed0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-MarkAuthed0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-EnableCryptStream0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetEndPoint0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-TestCloseNetIO0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-TestDropNetIO0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-WriteData0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-WriteCryptoData0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetSendHeadBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetSendBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetReceiveBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ClearReceiveBufferOffset0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetReceiveBufferOffset0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-SkipReceiveBufferOffset0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ReadData0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ReadCryptoData0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Available0;  // const
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-GetCancellation0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_CreateWebRequestGET0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_CreateWebRequestPOST0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-Invoke0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-Cancellation-IsCanceled0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_SetHttpResult0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_MarkResultAsException0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_YieldSendHttpRequest0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_DeserializeTypedResult0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_YieldSendHttpRequest1;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendGet0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendGet1;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendPost0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendPost1;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_WaitForServiceDone0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_StartWebRequestTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_WaitForSendHttpRequest0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendPost0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendGet0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendGet1;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-GetGeneralErrorCode0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_DebugOnlyProfileResult0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-Cancellation-Cancel0;  // const
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-GetOptMethod0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-set_reconnectState0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Start0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_DNSCheck0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-InternalClose0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-InternalClose1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Connect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-SetFinish0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Close0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-ConnectAsync0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-EnqueueSendMsg0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-SetCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetIO0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_SessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-OpenAutoReconnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SetAutoReconnectToken0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-GetClientPublicKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetOnlineResVersion0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetPlatformID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetSDKEnv0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetPayPlatform0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_WriteMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_ReadMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_ApproximateLoginServerTime0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_RSADecrypt0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleLoginEncryp0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-DoReconnectLogin0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-Start0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnApplicationPause0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetRequest0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetSucceed0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetNtfError0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_SessionLoginThreadTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-LoginAsync0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-StartMsgLoop0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnConnectedSucceed0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnReconnectTimesOver0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-NeedKeepConnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-CheckAndWriteReqMsg0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ReadMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearRecvQueue0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearSendQueue0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-GetPingPassedTime0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-GetPing0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-IsPingInProgress0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearPingWDG0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessagePing0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-IsPingOut0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-PingSenderTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-InitClientRSAKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearRSAKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-CheckAndDealRespMessages0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetResponse0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetErrorCode0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-GetCode0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-Log0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-Clear0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0;  // const
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0;  // const

    }

}

