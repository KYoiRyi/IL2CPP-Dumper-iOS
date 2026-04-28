// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.OneChannel.dll
// Classes:  123
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct Status
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.SDKCaptchaHandler.Status SUC;  // const
        public static U8.SDK.SDKCaptchaHandler.Status SYS_BUSY;  // const
        public static U8.SDK.SDKCaptchaHandler.Status USER_CANCEL;  // const
        public static U8.SDK.SDKCaptchaHandler.Status NOT_SUPPORT;  // const
        public static U8.SDK.SDKCaptchaHandler.Status INVALID_PARAM;  // const
        public static U8.SDK.SDKCaptchaHandler.Status UNKNOWN;  // const

    }

    // TypeToken: 0x2000008  // size: 0x20
    public class Result
    {
        // Fields
        private U8.SDK.SDKCaptchaHandler.Status <status>k__BackingField;  // 0x10
        private System.Int32 <errorCode>k__BackingField;  // 0x14
        private System.String <captcha>k__BackingField;  // 0x18

        // Properties
        U8.SDK.SDKCaptchaHandler.Status status { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.Int32 errorCode { set; /* RVA: 0x03D595B0 */ }
        System.String captcha { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000010
        private System.Void .ctor() { }
        // RVA: 0x08870FBC  token: 0x6000011
        public static U8.SDK.SDKCaptchaHandler.Result CreateForOutput() { }
        // RVA: 0x08871054  token: 0x6000012
        public System.Void MarkSucceed(System.String captcha) { }
        // RVA: 0x08871028  token: 0x6000013
        public System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status, System.Int32 errorCode) { }
        // RVA: 0x08871000  token: 0x6000014
        public System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status) { }

    }

    // TypeToken: 0x200000A
    public interface IFromJSON
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000058
        public virtual System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct POSTStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.SDKExternalTools.POSTStatus NONE;  // const
        public static U8.SDK.SDKExternalTools.POSTStatus SUC;  // const
        public static U8.SDK.SDKExternalTools.POSTStatus TIMEOUT;  // const
        public static U8.SDK.SDKExternalTools.POSTStatus ERROR;  // const

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct BusType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.SDKExternalTools.BusType NONE;  // const
        public static U8.SDK.SDKExternalTools.BusType GET_TOKEN;  // const
        public static U8.SDK.SDKExternalTools.BusType GET_CAPTCHA;  // const
        public static U8.SDK.SDKExternalTools.BusType CREATE_ORDER;  // const
        public static U8.SDK.SDKExternalTools.BusType CONFIRM_ORDER;  // const
        public static U8.SDK.SDKExternalTools.BusType VERIFY_ACCOUNT;  // const
        public static U8.SDK.SDKExternalTools.BusType GET_PRODUCT_LIST;  // const
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_SESSION_TOKEN;  // const
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2CODE;  // const
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2TOKEN;  // const
        public static U8.SDK.SDKExternalTools.BusType SERVER_LIST;  // const
        public static U8.SDK.SDKExternalTools.BusType CONFIRM_SERVER;  // const

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct ErrorType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.SDKExternalTools.ErrorType NONE;  // const
        public static U8.SDK.SDKExternalTools.ErrorType TIMEOUT;  // const
        public static U8.SDK.SDKExternalTools.ErrorType NETWORK_ERROR;  // const
        public static U8.SDK.SDKExternalTools.ErrorType DESERIALIZE_FAILED;  // const
        public static U8.SDK.SDKExternalTools.ErrorType BUSINESS_ERROR;  // const

    }

    // TypeToken: 0x200000E  // size: 0x30
    public sealed struct POSTRequest
    {
        // Fields
        public System.String url;  // 0x10
        public System.String body;  // 0x18
        public System.String contentType;  // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> nullableHeaders;  // 0x28

    }

    // TypeToken: 0x200000F  // size: 0x28
    public sealed struct POSTResult
    {
        // Fields
        public U8.SDK.SDKExternalTools.POSTStatus status;  // 0x10
        public System.Int32 httpCode;  // 0x14
        public System.String response;  // 0x18
        public System.String error;  // 0x20

        // Methods
        // RVA: 0x08870E90  token: 0x6000059
        public System.Boolean ServiceFailed() { }

    }

    // TypeToken: 0x2000010  // size: 0x30
    public sealed struct ErrMsgMeta
    {
        // Fields
        public static readonly U8.SDK.SDKExternalTools.ErrMsgMeta EMPTY;  // static @ 0x0
        public U8.SDK.SDKExternalTools.BusType busType;  // 0x10
        public U8.SDK.SDKExternalTools.ErrorType errorType;  // 0x14
        public System.Int32 errorCode;  // 0x18
        public System.String alertFromServer;  // 0x20
        public System.Object meta;  // 0x28

        // Methods
        // RVA: 0x022FBAA0  token: 0x600005A
        public System.Boolean IsEmpty() { }
        // RVA: 0x0886F124  token: 0x600005B
        public static U8.SDK.SDKExternalTools.ErrMsgMeta FromPOSTResult(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet) { }

    }

    // TypeToken: 0x2000012  // size: 0x38
    public sealed class <FetchCaptchaCoroutine>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools.CaptchaMgr <>4__this;  // 0x20
        public U8.SDK.SDKCaptchaHandler.Result outResult;  // 0x28
        public System.Collections.Generic.Dictionary<System.String,System.Object> captchaParams;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000060
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x088751EC  token: 0x6000061
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08874E04  token: 0x6000062
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08875264  token: 0x6000063
        private System.Void <>m__Finally1() { }
        // RVA: 0x088751A0  token: 0x6000065
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public class CaptchaMgr
    {
        // Fields
        private U8.SDK.SDKExternalTools m_host;  // 0x10
        private U8.SDK.SDKCaptchaHandler <activeHandler>k__BackingField;  // 0x18

        // Properties
        U8.SDK.SDKCaptchaHandler activeHandler { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600005E
        public System.Void .ctor(U8.SDK.SDKExternalTools host) { }
        // RVA: 0x0886EB7C  token: 0x600005F
        public System.Collections.IEnumerator FetchCaptchaCoroutine(System.Collections.Generic.Dictionary<System.String,System.Object> captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }

    }

    // TypeToken: 0x2000014  // size: 0x38
    public sealed struct Builder
    {
        // Fields
        public U8.SDK.SDKExternalTools.POSTRequest request;  // 0x10
        public U8.SDK.SDKExternalTools.BusType busType;  // 0x30

        // Methods
        // RVA: 0x0886EB08  token: 0x6000073
        public U8.SDK.SDKExternalTools.POSTProcedure Build() { }
        // RVA: -1  // generic def  token: 0x6000074
        public U8.SDK.SDKExternalTools.POSTProcedure<TResp> TypedBuild() { }

    }

    // TypeToken: 0x2000015  // size: 0x30
    public sealed class <POST>d__18 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools host;  // 0x20
        public U8.SDK.SDKExternalTools.POSTProcedure <>4__this;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000075
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000076
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08875294  token: 0x6000077
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x088753B8  token: 0x6000079
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000013  // size: 0x68
    public class POSTProcedure
    {
        // Fields
        private U8.SDK.SDKExternalTools.POSTProcedure.Builder <builder>k__BackingField;  // 0x10
        private System.Boolean <isServiceFinished>k__BackingField;  // 0x38
        private U8.SDK.SDKExternalTools.ErrMsgMeta <serviceError>k__BackingField;  // 0x40
        private System.String <rawResponse>k__BackingField;  // 0x60

        // Properties
        U8.SDK.SDKExternalTools.POSTProcedure.Builder builder { get; /* RVA: 0x020B6ED0 */ set; /* RVA: 0x08861778 */ }
        System.Boolean isServiceFinished { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        U8.SDK.SDKExternalTools.ErrMsgMeta serviceError { get; /* RVA: 0x03D6DAD0 */ set; /* RVA: 0x08870E78 */ }
        System.String rawResponse { set; /* RVA: 0x039274B0 */ }

        // Methods
        // RVA: 0x03D6DA90  token: 0x600006E
        public U8.SDK.SDKExternalTools.ErrMsgMeta MakeBusinessError(System.Int32 errorCode) { }
        // RVA: 0x08870CF4  token: 0x600006F
        public System.Collections.IEnumerator POST(U8.SDK.SDKExternalTools host) { }
        // RVA: 0x08870D68  token: 0x6000070
        private System.Void _OnServiceFinished(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        // RVA: 0x0350B670  token: 0x6000071
        protected virtual System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        // RVA: 0x0350B670  token: 0x6000072
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class POSTProcedure`1 : POSTProcedure
    {
        // Fields
        private TResp <response>k__BackingField;  // 0x0

        // Properties
        TResp response { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600007D
        protected virtual System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        // RVA: -1  // not resolved  token: 0x600007E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x40
    public class AuthV2SessionTokenResp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String msg;  // 0x18
        public System.String type;  // 0x20
        public System.String token;  // 0x28
        public System.String uid;  // 0x30
        public System.Boolean isNew;  // 0x38

        // Methods
        // RVA: 0x0886E914  token: 0x600007F
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0350B670  token: 0x6000080
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x20
    public class GetProductLsitResp : IFromJSON
    {
        // Fields
        public System.Int32 flag;  // 0x10
        public System.Collections.Generic.Dictionary<System.String,System.Object> desc;  // 0x18

        // Methods
        // RVA: 0x0886F164  token: 0x6000081
        public System.Boolean LoadFromDictionary(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }
        // RVA: 0x0886F3C8  token: 0x6000082
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0350B670  token: 0x6000083
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x68
    public class AuthV2GrantResp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String msg;  // 0x18
        public System.String type;  // 0x20
        public System.String uid;  // 0x28
        public System.String code;  // 0x30
        public System.String token;  // 0x38
        public System.Int64 banStartTs;  // 0x40
        public System.Int64 banEndTs;  // 0x48
        public System.Int64 maintainStartTs;  // 0x50
        public System.Int64 maintainEndTs;  // 0x58
        public System.Collections.Generic.Dictionary<System.String,System.Object> captcha;  // 0x60

        // Methods
        // RVA: 0x0886E648  token: 0x6000084
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0350B670  token: 0x6000085
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x50
    public sealed struct ServerData
    {
        // Fields
        public System.String serverId;  // 0x10
        public System.String serverName;  // 0x18
        public System.String serverDomain;  // 0x20
        public System.Boolean defaultChoose;  // 0x28
        public System.String roleId;  // 0x30
        public System.String nickName;  // 0x38
        public System.Int64 level;  // 0x40
        public System.String extension;  // 0x48

    }

    // TypeToken: 0x200001A  // size: 0x28
    public class ServerListResp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String msg;  // 0x18
        public System.Collections.Generic.List<U8.SDK.SDKExternalTools.ServerListResp.ServerData> data;  // 0x20

        // Methods
        // RVA: 0x08874694  token: 0x6000086
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x08874B8C  token: 0x6000087
        public System.Collections.Generic.List<U8.SDK.U8ServerInfo> ToServerInfo() { }
        // RVA: 0x0350B670  token: 0x6000088
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x20
    public class ConfirmServerResp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String msg;  // 0x18

        // Methods
        // RVA: 0x0886ECA4  token: 0x6000089
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0350B670  token: 0x600008A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x18
    public class ConfirmOrderU1Resp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10

        // Methods
        // RVA: 0x0886EC08  token: 0x600008B
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0350B670  token: 0x600008C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x40
    public sealed struct Data
    {
        // Fields
        public System.String orderId;  // 0x10
        public System.String channelProductCode;  // 0x18
        public System.String productName;  // 0x20
        public System.String productDesc;  // 0x28
        public System.Int64 amount;  // 0x30
        public System.Collections.Generic.Dictionary<System.String,System.Object> extension;  // 0x38

    }

    // TypeToken: 0x200001E  // size: 0x58
    public class CreateOrderU1Resp : IFromJSON
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String msg;  // 0x18
        public System.String type;  // 0x20
        public U8.SDK.SDKExternalTools.CreateOrderU1Resp.Data data;  // 0x28

        // Methods
        // RVA: 0x0886ED80  token: 0x600008D
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0886F00C  token: 0x600008E
        public U8.SDK.U8OrderInfo ToOrderInfo() { }
        // RVA: 0x0350B670  token: 0x600008F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly U8.SDK.SDKExternalTools.<>c <>9;  // static @ 0x0
        public static System.Action<System.String> <>9__43_0;  // static @ 0x8
        public static System.Action<System.String> <>9__43_1;  // static @ 0x10
        public static System.Action <>9__44_0;  // static @ 0x18
        public static System.Action <>9__44_1;  // static @ 0x20

        // Methods
        // RVA: 0x03D0E270  token: 0x6000090
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000091
        public System.Void .ctor() { }
        // RVA: 0x03CF6470  token: 0x6000092
        private System.Void <LoginWithPlugin>b__43_0(System.String extension) { }
        // RVA: 0x08876188  token: 0x6000093
        private System.Void <LoginWithPlugin>b__43_1(System.String message) { }
        // RVA: 0x088761F4  token: 0x6000094
        private System.Void <LogoutWithPlugin>b__44_0() { }
        // RVA: 0x08876274  token: 0x6000095
        private System.Void <LogoutWithPlugin>b__44_1() { }

    }

    // TypeToken: 0x2000021  // size: 0x28
    public sealed class <_NextFrameCoroutine>d__61 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Action action;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000096
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000097
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08878F2C  token: 0x6000098
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878F7C  token: 0x600009A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000022  // size: 0x48
    public sealed class <SDKInterfaceAuthV2SessionToken>d__113 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> promise;  // 0x20
        public U8.SDK.SDKMeta meta;  // 0x28
        public System.String channelToken;  // 0x30
        public U8.SDK.SDKExternalTools <>4__this;  // 0x38
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.AuthV2SessionTokenResp> <postImpl>5__2;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600009C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600009D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088754B4  token: 0x600009E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08875998  token: 0x60000A0
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000023  // size: 0x40
    public sealed class <SDKInterfaceAuthV2OAuth2Code>d__114 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String sessionToken;  // 0x28
        public U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise;  // 0x30
        public System.Action onSessionInvalid;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000A2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000A3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08875404  token: 0x60000A4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08875468  token: 0x60000A6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000024  // size: 0x60
    public sealed class <_AuthV2GrantImpl>d__120 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise;  // 0x20
        public U8.SDK.SDKExternalTools <>4__this;  // 0x28
        public System.String sessionToken;  // 0x30
        public System.Action onSessionInvalid;  // 0x38
        private System.String <captcha>5__2;  // 0x40
        private System.Boolean <needCaptcha>5__3;  // 0x48
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.AuthV2GrantResp> <postImpl>5__4;  // 0x50
        private U8.SDK.SDKCaptchaHandler.Result <captchaRet>5__5;  // 0x58

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000A8
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000A9
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08877DB0  token: 0x60000AA
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878504  token: 0x60000AC
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000025  // size: 0x40
    public sealed class <_ConfirmOrderU1Coroutine>d__123 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String orderId;  // 0x28
        public System.String extension;  // 0x30
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000AE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000AF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08878550  token: 0x60000B0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878754  token: 0x60000B2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000026  // size: 0x70
    public sealed class <_PollOrderStatusCoroutine>d__124 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String orderId;  // 0x28
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise;  // 0x30
        private System.Int32 <tryCnt>5__2;  // 0x38
        private System.Int32 <maxTryCnt>5__3;  // 0x3c
        private U8.SDK.SDKExternalTools.POSTProcedure.Builder <postBuilder>5__4;  // 0x40
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ConfirmOrderU1Resp> <postImpl>5__5;  // 0x68

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000B4
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000B5
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08878FC8  token: 0x60000B6
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0887948C  token: 0x60000B8
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000027  // size: 0x40
    public sealed class <_GetServerListCoroutine>d__125 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String paramStr;  // 0x28
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> promise;  // 0x30
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ServerListResp> <postImpl>5__2;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000BA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000BB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08878BA0  token: 0x60000BC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878E48  token: 0x60000BE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000028  // size: 0x48
    public sealed class <_ConfirmServerListCoroutine>d__127 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String paramStr;  // 0x28
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> promise;  // 0x30
        public System.String serverId;  // 0x38
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ConfirmServerResp> <postImpl>5__2;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000C0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000C1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088787A0  token: 0x60000C2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878B54  token: 0x60000C4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000029  // size: 0x40
    public sealed class <_SendCreateOrderU1Coroutine>d__128 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.SDKExternalTools <>4__this;  // 0x20
        public System.String paramStr;  // 0x28
        public U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> promise;  // 0x30
        private U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.CreateOrderU1Resp> <postImpl>5__2;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000C6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000C7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088794D8  token: 0x60000C8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08879770  token: 0x60000CA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200002C  // size: 0x18
    public sealed struct U8ProductListDataV2 : IFromJSON
    {
        // Fields
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList;  // 0x10

        // Methods
        // RVA: 0x0887A26C  token: 0x60000D4
        public virtual System.Boolean LoadFromJSON(System.String json) { }
        // RVA: 0x0887A514  token: 0x60000D5
        private static System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct RequestConnPolicy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy DEFAULT;  // const
        public static U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy CLOSE_EACH_CON;  // const

    }

    // TypeToken: 0x200002E  // size: 0x14
    public sealed struct RequestHeaderInjectOptions
    {
        // Fields
        public U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy policy;  // 0x10

    }

    // TypeToken: 0x200002F  // size: 0x48
    public sealed class <>c__DisplayClass10_0
    {
        // Fields
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> promise;  // 0x10
        public U8.SDK.SDKExternalToolsShortcut <>4__this;  // 0x18
        public U8.SDK.SDKExternalTools.POSTRequest request;  // 0x20
        public System.Action<U8.SDK.SDKExternalTools.POSTResult> callback;  // 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x60000D6
        public System.Void .ctor() { }
        // RVA: 0x088763CC  token: 0x60000D7
        private System.Void <SendGetProductListRequestV2>b__0(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        // RVA: 0x08876510  token: 0x60000D8
        private System.Void <SendGetProductListRequestV2>b__1() { }

    }

    // TypeToken: 0x2000031  // size: 0x30
    public sealed struct AuthStatus
    {
        // Fields
        public static readonly U8.SDK.U8SDKInterface.AuthStatus EMPTY;  // static @ 0x0
        public System.String uid;  // 0x10
        public System.String oauth2code;  // 0x18
        public System.String oauth2token;  // 0x20
        public System.String sessionToken;  // 0x28

    }

    // TypeToken: 0x2000032  // size: 0x18
    public sealed struct V2LoginStatus
    {
        // Fields
        public System.String sessionToken;  // 0x10

    }

    // TypeToken: 0x2000033  // size: 0x80
    public sealed class ReceiverProductListResult : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056E13A4  token: 0x6000123
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000124
        public virtual System.Void Invoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg) { }

    }

    // TypeToken: 0x2000034  // size: 0x28
    public sealed struct GameServerTimeCache
    {
        // Fields
        public System.Int64 cacheTime;  // 0x10
        public System.Int64 maintainEndTs;  // 0x18
        public System.Int64 maintainStartTs;  // 0x20

    }

    // TypeToken: 0x2000035
    public sealed class <>c__DisplayClass51_0`1
    {
        // Fields
        public U8.SDK.SDKPromise<System.String> delegatePromise;  // 0x0
        public U8.SDK.U8SDKInterface <>4__this;  // 0x0
        public System.String env;  // 0x0
        public System.Action <>9__3;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000125
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000126
        private System.Void <V2PublicInit>b__0(System.String obj) { }
        // RVA: -1  // not resolved  token: 0x6000127
        private System.Void <V2PublicInit>b__3() { }
        // RVA: -1  // not resolved  token: 0x6000128
        private System.Void <V2PublicInit>b__1(System.Object info) { }
        // RVA: -1  // not resolved  token: 0x6000129
        private System.Void <V2PublicInit>b__2() { }

    }

    // TypeToken: 0x2000036  // size: 0x28
    public sealed class <>c__DisplayClass55_0
    {
        // Fields
        public U8.SDK.U8SDKInterface <>4__this;  // 0x10
        public System.String uid;  // 0x18
        public System.Boolean isNew;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600012A
        public System.Void .ctor() { }
        // RVA: 0x02E97D90  token: 0x600012B
        private System.Void <_onLoginSuc>b__0() { }

    }

    // TypeToken: 0x2000037  // size: 0x38
    public sealed class <>c__DisplayClass57_0
    {
        // Fields
        public U8.SDK.SDKExternalTools externalTools;  // 0x10
        public U8.SDK.U8SDKInterface <>4__this;  // 0x18
        public U8.SDK.SDKPromise<U8.SDK.U8ProductsResult> delegatePromise;  // 0x20
        public System.Action<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> <>9__1;  // 0x28
        public System.Action<System.Object> <>9__2;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x600012C
        public System.Void .ctor() { }
        // RVA: 0x0887677C  token: 0x600012D
        private System.Void <PublicGetProductListV2>b__0() { }
        // RVA: 0x0887689C  token: 0x600012E
        private System.Void <PublicGetProductListV2>b__1(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        // RVA: 0x08876B70  token: 0x600012F
        private System.Void <PublicGetProductListV2>b__2(System.Object rejectObj) { }

    }

    // TypeToken: 0x2000038  // size: 0x28
    public sealed class <>c__DisplayClass57_1
    {
        // Fields
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList;  // 0x10
        public U8.SDK.U8SDKInterface.ReceiverProductListResult receiver;  // 0x18
        public U8.SDK.U8SDKInterface.<>c__DisplayClass57_0 CS$<>8__locals1;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000130
        public System.Void .ctor() { }
        // RVA: 0x08876B94  token: 0x6000131
        private System.Void <PublicGetProductListV2>b__3(System.Collections.Generic.Dictionary<System.String,System.Object> msg) { }

    }

    // TypeToken: 0x2000039  // size: 0x40
    public sealed class <>c__DisplayClass69_0
    {
        // Fields
        public U8.SDK.U8PayParams payParams;  // 0x10
        public U8.SDK.U8SDKInterface <>4__this;  // 0x18
        public U8.SDK.SDKPromise<U8.SDK.U8PayResult> wrappedPromise;  // 0x20
        public U8.SDK.U8ProductInfo productInfo;  // 0x28
        public System.Action<U8.SDK.U8PayResult> <>9__1;  // 0x30
        public System.Action<System.Object> <>9__2;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000132
        public System.Void .ctor() { }
        // RVA: 0x088776A8  token: 0x6000133
        private System.Void <PublicPay>b__0() { }
        // RVA: 0x08877834  token: 0x6000134
        private System.Void <PublicPay>b__1(U8.SDK.U8PayResult payResult) { }
        // RVA: 0x08876B70  token: 0x6000135
        private System.Void <PublicPay>b__2(System.Object payFailMsg) { }
        // RVA: 0x088778D8  token: 0x6000136
        private System.Void <PublicPay>b__3(U8.SDK.U8PayResult payResult) { }
        // RVA: 0x08876B70  token: 0x6000137
        private System.Void <PublicPay>b__4(System.Object payFailMsg) { }

    }

    // TypeToken: 0x200003A  // size: 0x20
    public sealed class <>c__DisplayClass70_0
    {
        // Fields
        public U8.SDK.U8SDKInterface <>4__this;  // 0x10
        public System.Int64 revenue;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000138
        public System.Void .ctor() { }
        // RVA: 0x0887797C  token: 0x6000139
        private System.Void <_OnNativePayFulfilled>b__0() { }

    }

    // TypeToken: 0x200003B  // size: 0x20
    public sealed class <>c__DisplayClass78_0
    {
        // Fields
        public U8.SDK.U8SDKInterface <>4__this;  // 0x10
        public U8.SDK.U8PayParams payParams;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600013A
        public System.Void .ctor() { }
        // RVA: 0x088779EC  token: 0x600013B
        private System.Void <_NativePay>b__0() { }

    }

    // TypeToken: 0x200003C  // size: 0x28
    public sealed class <_NextFrameCoroutine>d__105 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Action call;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600013C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600013D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0399F0C0  token: 0x600013E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878EE0  token: 0x6000140
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003D  // size: 0x20
    public sealed class <>c__DisplayClass131_0
    {
        // Fields
        public U8.SDK.U8SDKInterface <>4__this;  // 0x10
        public U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000142
        public System.Void .ctor() { }
        // RVA: 0x03777080  token: 0x6000143
        private System.Void <_DoMockAuthV2>b__0() { }

    }

    // TypeToken: 0x200003E  // size: 0x40
    public sealed class <_LoginV2Coroutine>d__132 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.U8SDKInterface <>4__this;  // 0x20
        public U8.SDK.SDKPromise<System.String> promise;  // 0x28
        private U8.SDK.SDKPromiseEnumerator<System.String> <loginEnumerator>5__2;  // 0x30
        private U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> <sessionTokenPromise>5__3;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000144
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000145
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02E98060  token: 0x6000146
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08878E94  token: 0x6000148
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003F  // size: 0x38
    public sealed class <_AuthV2Coroutine>d__134 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public U8.SDK.U8SDKInterface <>4__this;  // 0x20
        public U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise;  // 0x28
        private U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> <oauth2codePromise>5__2;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600014A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600014B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08877A98  token: 0x600014C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08877D64  token: 0x600014E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000053  // size: 0x80
    public sealed class DataCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02D78970  token: 0x60001BD
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x60001BE
        public virtual System.Void Invoke(System.Int32 index, System.String paramValue) { }

    }

    // TypeToken: 0x2000054  // size: 0x80
    public sealed class U8SDKSendMessageCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02D77350  token: 0x60001BF
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x60001C0
        public virtual System.Void Invoke(System.String methodName, System.String paramValue) { }

    }

    // TypeToken: 0x2000055  // size: 0x18
    public sealed class <>c__DisplayClass34_0
    {
        // Fields
        public System.String defaultValue;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001C1
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x60001C2
        private System.Void <LoadExtraConfig>b__0(System.String data) { }

    }

    // TypeToken: 0x2000056  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly U8.SDK.SDKInterfaceWIN.<>c <>9;  // static @ 0x0
        public static System.Action<System.Threading.Tasks.Task> <>9__42_0;  // static @ 0x8

        // Methods
        // RVA: 0x08877A34  token: 0x60001C3
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001C4
        public System.Void .ctor() { }
        // RVA: 0x088762F4  token: 0x60001C5
        private System.Void <SetData>b__42_0(System.Threading.Tasks.Task task) { }

    }

    // TypeToken: 0x2000057  // size: 0x18
    public sealed class <>c__DisplayClass43_0
    {
        // Fields
        public System.String defaultValue;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001C6
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x60001C7
        private System.Void <GetData>b__0(System.String data) { }

    }

    // TypeToken: 0x2000058  // size: 0x18
    public sealed class <>c__DisplayClass51_0
    {
        // Fields
        public System.String json;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001C8
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x60001C9
        private System.Void <LoadSDKMeta>b__0(System.String data) { }

    }

    // TypeToken: 0x200005A  // size: 0x14
    public sealed struct FolderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.ImageSaver.FolderType UserPicturesFolder;  // const
        public static U8.SDK.ImageSaver.FolderType GameInstalledFolder;  // const

    }

    // TypeToken: 0x200005B  // size: 0x14
    public sealed struct ErrorCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.ImageSaver.ErrorCode NotInited;  // const
        public static U8.SDK.ImageSaver.ErrorCode ParamsError;  // const
        public static U8.SDK.ImageSaver.ErrorCode ImageNotFound;  // const
        public static U8.SDK.ImageSaver.ErrorCode ShareChannelError;  // const
        public static U8.SDK.ImageSaver.ErrorCode SaveFailed;  // const
        public static U8.SDK.ImageSaver.ErrorCode UnknowError;  // const

    }

    // TypeToken: 0x200005C  // size: 0x11
    public sealed struct CallbackResult
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static U8.SDK.ImageSaver.CallbackResult Success;  // const
        public static U8.SDK.ImageSaver.CallbackResult Cancelled;  // const
        public static U8.SDK.ImageSaver.CallbackResult Failed;  // const

    }

    // TypeToken: 0x200005D  // size: 0x30
    public class ImageShareInfo
    {
        // Fields
        public System.String shareChannel;  // 0x10
        public System.String imgPath;  // 0x18
        public System.String relativePath;  // 0x20
        public System.Int32 folderType;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60001DE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005E  // size: 0x50
    public sealed struct <SaveImage>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public U8.SDK.ImageSaver <>4__this;  // 0x30
        public System.String paramJson;  // 0x38
        private System.String <targetPath>5__2;  // 0x40
        private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1;  // 0x48

        // Methods
        // RVA: 0x08875D0C  token: 0x60001DF
        private virtual System.Void MoveNext() { }
        // RVA: 0x0887612C  token: 0x60001E0
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200005F  // size: 0x30
    public sealed class <>c__DisplayClass12_0
    {
        // Fields
        public U8.SDK.ImageSaver <>4__this;  // 0x10
        public System.String sourcePath;  // 0x18
        public System.String targetPath;  // 0x20
        public System.String imgFolder;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60001E1
        public System.Void .ctor() { }
        // RVA: 0x08876548  token: 0x60001E2
        private System.Boolean <SaveImageToPathAsync>b__0() { }

    }

    // TypeToken: 0x2000060  // size: 0x58
    public sealed struct <SaveImageToPathAsync>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder;  // 0x18
        public U8.SDK.ImageSaver <>4__this;  // 0x30
        public System.String sourcePath;  // 0x38
        public System.String targetPath;  // 0x40
        public System.String imgFolder;  // 0x48
        private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1;  // 0x50

        // Methods
        // RVA: 0x088759E4  token: 0x60001E3
        private virtual System.Void MoveNext() { }
        // RVA: 0x08875CAC  token: 0x60001E4
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000061  // size: 0x20
    public sealed class <>c__DisplayClass23_0
    {
        // Fields
        public System.String methodName;  // 0x10
        public System.String paramValue;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001E5
        public System.Void .ctor() { }
        // RVA: 0x08876720  token: 0x60001E6
        private System.Void <SendMessageInMain>b__0() { }

    }

    // TypeToken: 0x2000068
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x0
        public static U8.SDK.SDKPromiseEnumerator.State<T> NONE;  // const
        public static U8.SDK.SDKPromiseEnumerator.State<T> FULFILL;  // const
        public static U8.SDK.SDKPromiseEnumerator.State<T> REJECT;  // const

    }

    // TypeToken: 0x2000069
    public sealed class <Yield>d__12 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public U8.SDK.SDKPromiseEnumerator<T> <>4__this;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000204
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x6000205
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000206
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000208
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000072  // size: 0x20
    public sealed class <_onLogoutNextFrameCoroutine>d__13 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600022B
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600022C
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088797BC  token: 0x600022D
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08879894  token: 0x600022F
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000075  // size: 0x14
    public sealed struct TOKEN
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NONE;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN CURLY_OPEN;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN CURLY_CLOSE;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN SQUARED_OPEN;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN SQUARED_CLOSE;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN COLON;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN COMMA;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN STRING;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NUMBER;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN TRUE;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN FALSE;  // const
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NULL;  // const

    }

    // TypeToken: 0x2000074  // size: 0x18
    public sealed class Parser : System.IDisposable
    {
        // Fields
        private System.IO.StringReader json;  // 0x10

        // Properties
        System.Char PeekChar { get; /* RVA: 0x026950A0 */ }
        System.Char NextChar { get; /* RVA: 0x02695280 */ }
        System.String NextWord { get; /* RVA: 0x02694C60 */ }
        U8.SDK.MiniJSON.Json.Parser.TOKEN NextToken { get; /* RVA: 0x02694EE0 */ }

        // Methods
        // RVA: 0x02695330  token: 0x6000233
        public static System.Boolean IsWordBreak(System.Char c) { }
        // RVA: 0x02695910  token: 0x6000234
        private System.Void .ctor(System.String jsonString) { }
        // RVA: 0x02694A40  token: 0x6000235
        public static System.Object Parse(System.String jsonString) { }
        // RVA: 0x03823730  token: 0x6000236
        public virtual System.Void Dispose() { }
        // RVA: 0x02694D20  token: 0x6000237
        private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }
        // RVA: 0x08870E98  token: 0x6000238
        private System.Collections.Generic.List<System.Object> ParseArray() { }
        // RVA: 0x02694B40  token: 0x6000239
        private System.Object ParseValue() { }
        // RVA: 0x02694B70  token: 0x600023A
        private System.Object ParseByToken(U8.SDK.MiniJSON.Json.Parser.TOKEN token) { }
        // RVA: 0x02695110  token: 0x600023B
        private System.String ParseString() { }
        // RVA: 0x026953C0  token: 0x600023C
        private System.Object ParseNumber() { }
        // RVA: 0x02694E50  token: 0x600023D
        private System.Void EatWhitespace() { }

    }

    // TypeToken: 0x2000076  // size: 0x18
    public sealed class Serializer
    {
        // Fields
        private System.Text.StringBuilder builder;  // 0x10

        // Methods
        // RVA: 0x031EDCB0  token: 0x6000242
        private System.Void .ctor() { }
        // RVA: 0x031EDC30  token: 0x6000243
        public static System.String Serialize(System.Object obj) { }
        // RVA: 0x031EDEC0  token: 0x6000244
        private System.Void SerializeValue(System.Object value) { }
        // RVA: 0x031EE2C0  token: 0x6000245
        private System.Void SerializeObject(System.Collections.IDictionary obj) { }
        // RVA: 0x0887421C  token: 0x6000246
        private System.Void SerializeArray(System.Collections.IList anArray) { }
        // RVA: 0x031EE080  token: 0x6000247
        private System.Void SerializeString(System.String str) { }
        // RVA: 0x031EDD20  token: 0x6000248
        private System.Void SerializeOther(System.Object value) { }

    }

    // TypeToken: 0x200007A  // size: 0x28
    public sealed struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x200007B  // size: 0x58
    public sealed struct __StaticArrayInitTypeSize=72
    {
    }

    // TypeToken: 0x2000079  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 C8939CFEA086350CA0F084D5A8FFA18BE802D605B6111130EB5143B5882250C4;  // static @ 0x0
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 C9A1311D05AB372579F6B92A220603EAB8191E15071784A11774A076DC45320B;  // static @ 0x48

    }

namespace Hypergryph.PlatformFacade
{

    // TypeToken: 0x2000077  // size: 0x10
    public class PlatformFacade
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000249
        public static System.Void SetupPlatformFont(Hypergryph.PlatformFacade.IPlatformFont iFont) { }

    }

    // TypeToken: 0x2000078
    public interface IPlatformFont
    {
    }

}

namespace U8.SDK
{

    // TypeToken: 0x2000002  // size: 0x38
    public sealed struct ExternalPluginLoginParams
    {
        // Fields
        public System.Action nativeLogin;  // 0x10
        public System.Action<System.String> nativeLoginCustom;  // 0x18
        public System.Action<System.String> nativeOnLoginSuc;  // 0x20
        public System.Action<System.String> nativeOnLoginFail;  // 0x28
        public System.Action<U8.SDK.U8MockLogin> markMockLogin;  // 0x30

    }

    // TypeToken: 0x2000003  // size: 0x28
    public sealed struct ExternalPluginLogoutParams
    {
        // Fields
        public System.Action nativeLogout;  // 0x10
        public System.Action nativeOnLogoutSuc;  // 0x18
        public System.Action nativeOnLogoutFail;  // 0x20

    }

    // TypeToken: 0x2000004  // size: 0x30
    public sealed struct ExternalPluginPayParams
    {
        // Fields
        public U8.SDK.U8PayParams payParams;  // 0x10
        public System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay;  // 0x18
        public System.Action<U8.SDK.U8PayResult> onPaySuc;  // 0x20
        public System.Action<System.Object> onPayFail;  // 0x28

    }

    // TypeToken: 0x2000005
    public interface IExternalPlugin
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000001
        public virtual System.Void Init() { }
        // RVA: -1  // abstract  token: 0x6000002
        public virtual System.Void Login(U8.SDK.ExternalPluginLoginParams args) { }
        // RVA: -1  // abstract  token: 0x6000003
        public virtual System.Void Pay(U8.SDK.ExternalPluginPayParams args) { }
        // RVA: -1  // abstract  token: 0x6000004
        public virtual System.Void Logout(U8.SDK.ExternalPluginLogoutParams args) { }
        // RVA: -1  // abstract  token: 0x6000005
        public virtual System.String GetSDKToken() { }
        // RVA: -1  // abstract  token: 0x6000006
        public virtual System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta) { }
        // RVA: -1  // abstract  token: 0x6000007
        public virtual System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        // RVA: -1  // abstract  token: 0x6000008
        public virtual System.String GetPayAddition() { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public abstract class SDKCaptchaHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000009
        public virtual System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }
        // RVA: 0x0350B670  token: 0x600000A
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x28
    public abstract class SDKExternalTools
    {
        // Fields
        private static readonly System.Char[] RANDOM_CHAR_MAP;  // static @ 0x0
        protected static readonly System.Int32[] PAY_CONFIRM_RETRY_INTERVALS;  // static @ 0x8
        private static U8.SDK.SDKExternalTools s_instance;  // static @ 0x10
        private static U8.SDK.IExternalPlugin s_plugin;  // static @ 0x18
        private System.Boolean <inited>k__BackingField;  // 0x10
        private U8.SDK.SDKExternalTools.CaptchaMgr <captchaMgr>k__BackingField;  // 0x18
        private System.String <subChannel>k__BackingField;  // 0x20
        private static System.Int32 U8_SDK_SET_DATA_SET_SERVER;  // static @ 0x20

        // Properties
        System.Boolean inited { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        U8.SDK.IExternalPlugin plugin { get; /* RVA: 0x08873468 */ }
        U8.SDK.SDKExternalTools.CaptchaMgr captchaMgr { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String subChannel { set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x600001B
        public static System.Boolean SDKInterfaceInitExternalTools() { }
        // RVA: 0x02692650  token: 0x600001C
        public static U8.SDK.SDKExternalTools GetInstance() { }
        // RVA: 0x08871870  token: 0x600001D
        public static System.Boolean HasInstance() { }
        // RVA: 0x08871DD0  token: 0x600001E
        public System.String PublicServiceSignKey() { }
        // RVA: 0x088726EC  token: 0x600001F
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceProductListV2() { }
        // RVA: 0x08871D54  token: 0x6000020
        public System.Void NotifyProductListUpdated(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        // RVA: 0x08872794  token: 0x6000021
        public System.String SDKInterfaceSDKToken() { }
        // RVA: 0x042743D8  token: 0x6000022
        public static System.String MakeHttpPostParam(System.Collections.Generic.Dictionary<System.String,System.Object> param) { }
        // RVA: 0x02E992F0  token: 0x6000023
        public System.Void LoginWithPlugin(System.Action nativeLogin, System.Action<System.String> nativeLoginCustom, System.Action<U8.SDK.U8MockLogin> markMockLogin) { }
        // RVA: 0x08871AC8  token: 0x6000024
        public System.Void LogoutWithPlugin(System.Action nativeLogout) { }
        // RVA: 0x08872590  token: 0x6000025
        public System.Void SDKInterfacePayWithPlugin(U8.SDK.U8PayParams payParams, System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay, System.Action<U8.SDK.U8PayResult> onSuc, System.Action<System.Object> onFail) { }
        // RVA: 0x088724BC  token: 0x6000026
        public System.String SDKInterfaceGetPayAddition() { }
        // RVA: 0x08872970  token: 0x6000027
        public static System.Void StaticLog(System.String content) { }
        // RVA: 0x088728D8  token: 0x6000028
        public static System.Void StaticLogWarning(System.String content) { }
        // RVA: 0x08872840  token: 0x6000029
        public static System.Void StaticLogError(System.String content) { }
        // RVA: 0x039CAC00  token: 0x600002A
        public static System.Void RegisterPlugin(U8.SDK.IExternalPlugin plugin) { }
        // RVA: -1  // generic def  token: 0x600002B
        protected static T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        // RVA: 0x08872A08  token: 0x600002C
        protected System.String U8Url(System.String routeUrl) { }
        // RVA: 0x08872AAC  token: 0x600002D
        protected System.String U8urlWithoutU8(System.String routeUrl) { }
        // RVA: -1  // generic def  token: 0x600002E
        protected static U8.SDK.SDKExternalTools.ErrMsgMeta HandleResponseFromU8(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet, TResp& resp) { }
        // RVA: 0x088717AC  token: 0x600002F
        protected static System.Collections.Generic.Dictionary<System.String,System.Object> FromMiniJSON(System.String json) { }
        // RVA: 0x088718B8  token: 0x6000030
        protected static System.Void InternalInvokeCoroutine(System.Collections.IEnumerator coroutine) { }
        // RVA: 0x08871914  token: 0x6000031
        protected static System.Void InternalInvokeNextFrame(System.Action action) { }
        // RVA: 0x088732F4  token: 0x6000032
        private static System.Collections.IEnumerator _NextFrameCoroutine(System.Action action) { }
        // RVA: 0x03B36670  token: 0x6000033
        public System.Void InitIfNot() { }
        // RVA: 0x0350B670  token: 0x6000034
        protected virtual System.Void Init() { }
        // RVA: 0x0350B670  token: 0x6000035
        public virtual System.Void SwitchAccount() { }
        // RVA: 0x0350B670  token: 0x6000036
        public virtual System.Void OnSDKError(U8.SDK.SDKError error) { }
        // RVA: 0x0350B670  token: 0x6000037
        public virtual System.Void OnInvalidProduct(System.Int32 storeId) { }
        // RVA: 0x0350B670  token: 0x6000038
        public virtual System.Void OnSDKExtraInfo(System.String jsonData) { }
        // RVA: 0x088719A0  token: 0x6000039
        public virtual U8.SDK.SDKMeta LoadSDKMetaFromPlugin(System.Func<U8.SDK.SDKMeta> nativeLoadMeta) { }
        // RVA: -1  // abstract  token: 0x600003A
        protected virtual U8.SDK.SDKCaptchaHandler CreateCaptchaHandler() { }
        // RVA: 0x01002730  token: 0x600003B
        protected virtual System.String GetSignKey() { }
        // RVA: -1  // abstract  token: 0x600003C
        public virtual System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        // RVA: -1  // abstract  token: 0x600003D
        protected virtual U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr) { }
        // RVA: -1  // abstract  token: 0x600003E
        protected virtual System.Int32 GetPlatformKey() { }
        // RVA: -1  // abstract  token: 0x600003F
        protected virtual System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback) { }
        // RVA: -1  // abstract  token: 0x6000040
        protected virtual System.String U8RootUrl() { }
        // RVA: -1  // abstract  token: 0x6000041
        protected virtual System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta) { }
        // RVA: -1  // abstract  token: 0x6000042
        protected virtual System.Void Log(System.String content) { }
        // RVA: -1  // abstract  token: 0x6000043
        protected virtual System.Void LogWarning(System.String content) { }
        // RVA: -1  // abstract  token: 0x6000044
        protected virtual System.Void LogError(System.String content) { }
        // RVA: 0x02E97CC0  token: 0x6000045
        private System.Boolean _ValidatePlugin() { }
        // RVA: 0x08872FDC  token: 0x6000046
        private static System.String _MakeGetProductListV2Param(U8.SDK.SDKMeta meta) { }
        // RVA: 0x08872134  token: 0x6000047
        public System.Collections.IEnumerator SDKInterfaceAuthV2SessionToken(U8.SDK.SDKMeta meta, System.String channelToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> promise) { }
        // RVA: 0x0887208C  token: 0x6000048
        public System.Collections.IEnumerator SDKInterfaceAuthV2OAuth2Code(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid) { }
        // RVA: 0x088721DC  token: 0x6000049
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(System.String orderId, System.String extension) { }
        // RVA: 0x08871F70  token: 0x600004A
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> SDKInterFaceGetServerList(System.String sessionToken) { }
        // RVA: 0x08871E1C  token: 0x600004B
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> SDKInterFaceConfirmServer(System.String sessionToken, System.String serverId) { }
        // RVA: 0x08872290  token: 0x600004C
        public U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> SDKInterfaceCreateOrderU1(System.String sessionToken, System.String productId, System.String signParams) { }
        // RVA: 0x08873140  token: 0x600004D
        private static System.String _MakeGrantParam(System.String sessionToken, System.Int32 type, System.String captcha) { }
        // RVA: 0x08872BA4  token: 0x600004E
        private System.Collections.IEnumerator _AuthV2GrantImpl(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid) { }
        // RVA: 0x08872E28  token: 0x600004F
        private static System.String _MakeCheckOrderV1Param(System.String orderId, System.String extension) { }
        // RVA: 0x08872F20  token: 0x6000050
        private static System.String _MakeConfirmOrderV1Param(System.String orderId) { }
        // RVA: 0x08872C4C  token: 0x6000051
        private System.Collections.IEnumerator _ConfirmOrderU1Coroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise) { }
        // RVA: 0x08873350  token: 0x6000052
        private System.Collections.IEnumerator _PollOrderStatusCoroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise) { }
        // RVA: 0x08872D9C  token: 0x6000053
        private System.Collections.IEnumerator _GetServerListCoroutine(System.String paramStr, U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> promise) { }
        // RVA: 0x08872CF4  token: 0x6000054
        private System.Collections.IEnumerator _ConfirmServerListCoroutine(System.String paramStr, System.String serverId, U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> promise) { }
        // RVA: 0x088733DC  token: 0x6000055
        private System.Collections.IEnumerator _SendCreateOrderU1Coroutine(System.String paramStr, U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> promise) { }
        // RVA: 0x0350B670  token: 0x6000056
        protected System.Void .ctor() { }
        // RVA: 0x03B39900  token: 0x6000057
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002A  // size: 0x20
    public sealed struct SDKExtraData
    {
        // Fields
        public static readonly U8.SDK.SDKExtraData EMPTY;  // static @ 0x0
        public System.Int32 code;  // 0x10
        public System.Collections.Generic.Dictionary<System.String,System.Object> msg;  // 0x18

        // Methods
        // RVA: 0x02692BF0  token: 0x60000CC
        public static U8.SDK.SDKExtraData FromJson(System.String jsonStr) { }
        // RVA: 0x03D1BA30  token: 0x60000CD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x28
    public abstract class SDKExternalToolsShortcut : U8.SDK.SDKExternalTools
    {
        // Methods
        // RVA: 0x088715A0  token: 0x60000CE
        protected virtual U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr) { }
        // RVA: 0x0887129C  token: 0x60000CF
        public virtual System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        // RVA: 0x088713A8  token: 0x60000D0
        public static System.String GetU8DeviceID() { }
        // RVA: 0x088714C8  token: 0x60000D1
        public static System.Void InjectRequestHeaders(System.Collections.Generic.Dictionary<System.String,System.String>& headers, U8.SDK.SDKExternalToolsShortcut.RequestHeaderInjectOptions policy) { }
        // RVA: 0x08871770  token: 0x60000D2
        private System.String _GetProductListV1Url() { }
        // RVA: 0x03D42B80  token: 0x60000D3
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0xD0
    public abstract class U8SDKInterface
    {
        // Fields
        private static U8.SDK.U8SDKInterface m_instance;  // static @ 0x0
        protected U8.SDK.SDKPromiseWrapper m_initPromise;  // 0x10
        protected U8.SDK.SDKPromiseWrapper m_loginPromise;  // 0x18
        protected U8.SDK.SDKPromiseWrapper m_logoutPromise;  // 0x20
        protected U8.SDK.SDKPromiseWrapper m_payPromise;  // 0x28
        private U8.SDK.U8LoginResult m_loginResult;  // 0x30
        private U8.SDK.U8SDKInterface.AuthStatus m_authStatus;  // 0x68
        private System.String m_loginExtV1;  // 0x88
        private U8.SDK.U8MockLogin m_mockLogin;  // 0x90
        private System.Collections.Generic.List<U8.SDK.U8ProductInfo> m_productList;  // 0xa0
        private System.Nullable<System.Boolean> m_isNativePlugin;  // 0xa8
        private U8.SDK.U8SDKInterface.V2LoginStatus m_loginStatusV2;  // 0xb0
        private static System.Int32 U8_SDK_SET_DATA_SET_SESSION_TOKEN;  // static @ 0x8
        private static System.Int32 U8_SDK_SET_DATA_GET_PRODUCT_LIST;  // static @ 0xc
        private static U8.SDK.U8SDKInterface.ReceiverProductListResult onReceiverProductlist;  // static @ 0x10
        private U8.SDK.U8SDKInterface.GameServerTimeCache m_gameServerTimeCache;  // 0xb8

        // Properties
        U8.SDK.U8SDKInterface Instance { get; /* RVA: 0x02D7A390 */ }
        System.Boolean isNativePlugin { get; /* RVA: 0x02E97C40 */ }
        System.String uid { get; /* RVA: 0x03D4EAB0 */ }
        System.String cachedUid { get; /* RVA: 0x02D780F0 */ set; /* RVA: 0x03777270 */ }
        System.String oauth2token { get; /* RVA: 0x03D4EB20 */ }
        System.String oauth2code { get; /* RVA: 0x03D4EB30 */ }
        System.Boolean isInterfaceDisabled { get; /* RVA: 0x0115F4C0 */ }
        System.String sessionToken { get; /* RVA: 0x03D4EAD0 */ }
        U8.SDK.U8SDKInterface.GameServerTimeCache serverCacheTime { get; /* RVA: 0x03D6DAF0 */ set; /* RVA: 0x03D6DB10 */ }

        // Events
        event U8.SDK.U8SDKInterface.ReceiverProductListResult onReceiverProductlist;

        // Methods
        // RVA: 0x039C3170  token: 0x60000DB
        public System.Void CallbackInitSuc(System.String extConfigs) { }
        // RVA: 0x0887A988  token: 0x60000DC
        public System.Void CallbackInitFail(System.String info) { }
        // RVA: 0x039C31F0  token: 0x60000DD
        public System.Void CallbackLoginSuc(System.String extension) { }
        // RVA: 0x0887A9A8  token: 0x60000DE
        public System.Void CallbackLoginFail(System.String info) { }
        // RVA: 0x0887A9C8  token: 0x60000DF
        public System.Void CallbackLogout() { }
        // RVA: 0x0887AB14  token: 0x60000E0
        public System.Void CallbackSwitchAccount() { }
        // RVA: 0x0887AA80  token: 0x60000E1
        public System.Void CallbackPaySuc(System.String jsonData) { }
        // RVA: 0x0887A9EC  token: 0x60000E2
        public System.Void CallbackPayFail(System.String failMsg) { }
        // RVA: 0x04273A44  token: 0x60000E9
        public System.String PublicLoadExtraConfig() { }
        // RVA: 0x042770BC  token: 0x60000EA
        public System.Void PublicSetGameVersion(System.String version) { }
        // RVA: 0x0887BD44  token: 0x60000EB
        public U8.SDK.U8SDKInterface.ReceiverProductListResult getOnReceiverProductlist() { }
        // RVA: -1  // generic def  token: 0x60000EC
        public U8.SDK.SDKPromise<System.String> V2PublicInit(System.String env) { }
        // RVA: 0x03D4D850  token: 0x60000ED
        private System.Void _MarkMockLogin(U8.SDK.U8MockLogin mockLogin) { }
        // RVA: 0x02E97B60  token: 0x60000EE
        private System.Void _onLoginSuc(System.String uid, System.Boolean isNew) { }
        // RVA: 0x0887AFA4  token: 0x60000EF
        public U8.SDK.SDKPromise<U8.SDK.U8ProductsResult> PublicGetProductListV2() { }
        // RVA: 0x0887AB60  token: 0x60000F0
        public System.Void ClearAuthStatus() { }
        // RVA: 0x0887ABBC  token: 0x60000F1
        public System.Void ClearLoginStatus() { }
        // RVA: 0x03777230  token: 0x60000F2
        private System.Void _ConfirmAuthResult(U8.SDK.U8SDKInterface.AuthStatus result) { }
        // RVA: 0x0887B1A8  token: 0x60000F3
        public U8.SDK.SDKPromise<System.Object> PublicLogout() { }
        // RVA: 0x0887B0C4  token: 0x60000F4
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> PublicGetServerList() { }
        // RVA: 0x0887B490  token: 0x60000F5
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> PubliceConfirmServer(System.String serverId) { }
        // RVA: 0x0887B248  token: 0x60000F6
        public U8.SDK.SDKPromise<U8.SDK.U8PayResult> PublicPay(System.Int32 storeId, U8.SDK.U8OrderInfo orderInfo) { }
        // RVA: 0x0887BAC4  token: 0x60000F7
        private System.Void _OnNativePayFulfilled(System.Int64 revenue) { }
        // RVA: 0x0887BBA0  token: 0x60000F8
        private System.Boolean _TryGetProduct(System.Int32 storeId, U8.SDK.U8ProductInfo& productInfo) { }
        // RVA: 0x0887B844  token: 0x60000F9
        private U8.SDK.U8PayParams _GeneratePayParams(U8.SDK.U8ProductInfo productInfo, U8.SDK.U8OrderInfo orderInfo) { }
        // RVA: 0x0887B9E0  token: 0x60000FA
        private U8.SDK.SDKPromise<U8.SDK.U8PayResult> _NativePay(U8.SDK.U8PayParams payParams) { }
        // RVA: -1  // generic def  token: 0x60000FB
        private static T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        // RVA: 0x0887B0CC  token: 0x60000FC
        public U8.SDK.SDKMeta PublicLoadSDKMeta() { }
        // RVA: -1  // abstract  token: 0x60000FD
        protected virtual System.String LoadExtraConfig() { }
        // RVA: -1  // abstract  token: 0x60000FE
        protected virtual System.Void V2Init(System.String env) { }
        // RVA: -1  // abstract  token: 0x60000FF
        protected virtual System.Void Login() { }
        // RVA: -1  // abstract  token: 0x6000100
        protected virtual System.Void LoginCustom(System.String customData) { }
        // RVA: -1  // abstract  token: 0x6000101
        protected virtual System.Boolean Logout() { }
        // RVA: -1  // abstract  token: 0x6000102
        public virtual System.Boolean ShowAccountCenter() { }
        // RVA: -1  // abstract  token: 0x6000103
        public virtual System.Void SubmitGameData(U8.SDK.U8ExtraGameData data) { }
        // RVA: -1  // abstract  token: 0x6000104
        protected virtual System.Void Pay(U8.SDK.U8PayParams data) { }
        // RVA: -1  // abstract  token: 0x6000105
        public virtual System.Void SetData(System.Int32 type, System.String paramJson) { }
        // RVA: -1  // abstract  token: 0x6000106
        public virtual System.String GetData(System.Int32 type, System.String paramJson) { }
        // RVA: -1  // abstract  token: 0x6000107
        protected virtual U8.SDK.SDKMeta LoadSDKMeta() { }
        // RVA: -1  // abstract  token: 0x6000108
        protected virtual System.Boolean IsNativePlugin() { }
        // RVA: -1  // abstract  token: 0x6000109
        public virtual System.Void SetGameVersion(System.String version) { }
        // RVA: 0x02690B40  token: 0x600010A
        private System.Collections.IEnumerator _NextFrameCoroutine(System.Action call) { }
        // RVA: 0x02690AB0  token: 0x600010B
        protected System.Void InvokeNextFrame(System.Action action) { }
        // RVA: 0x03D06B90  token: 0x600010C
        protected System.Void InvokeCoroutine(System.Collections.IEnumerator coroutine) { }
        // RVA: 0x02E985D0  token: 0x600010D
        protected System.String EncodeGameData(U8.SDK.U8ExtraGameData data) { }
        // RVA: 0x0887ABE8  token: 0x600010E
        protected System.String EncodePayParams(U8.SDK.U8PayParams data) { }
        // RVA: 0x02C36FB0  token: 0x6000114
        public U8.SDK.SDKPromise<System.String> V2PublicLogin() { }
        // RVA: 0x02690560  token: 0x6000115
        public U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> V2PublicAuth() { }
        // RVA: 0x0887B56C  token: 0x6000116
        public U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> U1PublicCreateOrder(System.String productId, System.String signParams) { }
        // RVA: 0x0887B5EC  token: 0x6000117
        public U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> U1PublicGetServerList() { }
        // RVA: 0x0887B500  token: 0x6000118
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> U1PublicConfirmServer(System.String serverId) { }
        // RVA: 0x0887B498  token: 0x6000119
        public U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> U1PublicConfirmOrder(System.String orderId, System.String extension) { }
        // RVA: 0x026905C0  token: 0x600011A
        private U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> _DoMockAuthV2() { }
        // RVA: 0x02C37030  token: 0x600011B
        private System.Collections.IEnumerator _LoginV2Coroutine(U8.SDK.SDKPromise<System.String> promise) { }
        // RVA: 0x0887BB80  token: 0x600011C
        private System.Void _OnSessionTokenInvalid() { }
        // RVA: 0x0887B7D0  token: 0x600011D
        private System.Collections.IEnumerator _AuthV2Coroutine(U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise) { }
        // RVA: 0x03A597D0  token: 0x600011E
        protected System.Void .ctor() { }
        // RVA: 0x03D2B9A0  token: 0x600011F
        private static System.Void .cctor() { }
        // RVA: 0x0887B648  token: 0x6000120
        private System.Void <PublicLogout>b__65_0() { }
        // RVA: 0x0887B76C  token: 0x6000121
        private System.Void <PublicLogout>b__65_1() { }
        // RVA: 0x0887B77C  token: 0x6000122
        private System.Void <PublicLogout>b__65_2() { }

    }

    // TypeToken: 0x2000040  // size: 0x20
    public sealed struct SDKError
    {
        // Fields
        private System.String <code>k__BackingField;  // 0x10
        private System.String <msg>k__BackingField;  // 0x18

        // Properties
        System.String code { set; /* RVA: 0x042715A0 */ }
        System.String msg { set; /* RVA: 0x0558FF08 */ }

        // Methods
        // RVA: 0x08871074  token: 0x6000152
        public System.Void .ctor(System.String content) { }

    }

    // TypeToken: 0x2000041  // size: 0x20
    public sealed struct U8MockLogin
    {
        // Fields
        public static readonly U8.SDK.U8MockLogin EMPTY;  // static @ 0x0
        public System.String uid;  // 0x10
        public System.String token;  // 0x18

        // Methods
        // RVA: 0x042710A8  token: 0x6000153
        public System.Boolean IsEmpty() { }

    }

    // TypeToken: 0x2000042  // size: 0x48
    public class U8ProductInfo
    {
        // Fields
        public System.Int32 store_id;  // 0x10
        public System.String product_id;  // 0x18
        public System.String desc;  // 0x20
        public System.String name;  // 0x28
        public System.Int64 price;  // 0x30
        public System.String channel_product_id;  // 0x38
        public System.String display_price;  // 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x6000154
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x20
    public class U8ProductsResult
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> u8Products;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000155
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x50
    public class U8ServerInfo
    {
        // Fields
        public System.String serverId;  // 0x10
        public System.String serverName;  // 0x18
        public System.String serverDomain;  // 0x20
        public System.Boolean defaultChoose;  // 0x28
        public System.String roleId;  // 0x30
        public System.String nickName;  // 0x38
        public System.Int64 level;  // 0x40
        public System.String extension;  // 0x48

        // Methods
        // RVA: 0x0350B670  token: 0x6000156
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x18
    public class U8ServerErrorInfo
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.Int32 errorCode;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000157
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x40
    public class U8OrderInfo
    {
        // Fields
        public System.String orderId;  // 0x10
        public System.String channelProductCode;  // 0x18
        public System.String productName;  // 0x20
        public System.String productDesc;  // 0x28
        public System.Int64 amount;  // 0x30
        public System.String extension;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000158
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x98
    public class U8PayParams
    {
        // Fields
        private System.String <productId>k__BackingField;  // 0x10
        private System.String <productName>k__BackingField;  // 0x18
        private System.String <productDesc>k__BackingField;  // 0x20
        private System.Int64 <price>k__BackingField;  // 0x28
        private System.Int32 <buyNum>k__BackingField;  // 0x30
        private System.Int32 <coinNum>k__BackingField;  // 0x34
        private System.String <serverId>k__BackingField;  // 0x38
        private System.String <serverName>k__BackingField;  // 0x40
        private System.String <roleId>k__BackingField;  // 0x48
        private System.String <roleName>k__BackingField;  // 0x50
        private System.Int32 <roleLevel>k__BackingField;  // 0x58
        private System.String <vip>k__BackingField;  // 0x60
        private System.String <orderID>k__BackingField;  // 0x68
        private System.String <worldID>k__BackingField;  // 0x70
        private System.String <token>k__BackingField;  // 0x78
        private System.String <appKey>k__BackingField;  // 0x80
        private System.String <extension>k__BackingField;  // 0x88
        private System.String <addition>k__BackingField;  // 0x90

        // Properties
        System.String productId { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String productName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String productDesc { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Int64 price { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x03D4ED70 */ }
        System.Int32 buyNum { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        System.Int32 coinNum { get; /* RVA: 0x03D4EE00 */ }
        System.String serverId { get; /* RVA: 0x03D4E2A0 */ }
        System.String serverName { get; /* RVA: 0x03D4E2B0 */ }
        System.String roleId { get; /* RVA: 0x03D4EA70 */ }
        System.String roleName { get; /* RVA: 0x03D4EAF0 */ }
        System.Int32 roleLevel { get; /* RVA: 0x03D4EF00 */ }
        System.String vip { get; /* RVA: 0x03D4EB00 */ }
        System.String orderID { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        System.String worldID { get; /* RVA: 0x03D4EB30 */ }
        System.String token { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }
        System.String appKey { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }
        System.String extension { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }
        System.String addition { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000175
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000048  // size: 0x78
    public class U8ExtraGameData
    {
        // Fields
        private System.Int32 <dataType>k__BackingField;  // 0x10
        private System.String <uid>k__BackingField;  // 0x18
        private System.String <roleID>k__BackingField;  // 0x20
        private System.String <roleName>k__BackingField;  // 0x28
        private System.String <roleLevel>k__BackingField;  // 0x30
        private System.Int32 <serverID>k__BackingField;  // 0x38
        private System.String <serverName>k__BackingField;  // 0x40
        private System.String <channel>k__BackingField;  // 0x48
        private System.String <subChannel>k__BackingField;  // 0x50
        private System.Boolean <isNewUser>k__BackingField;  // 0x58
        private System.Int64 <revenue>k__BackingField;  // 0x60
        private System.String <customEventName>k__BackingField;  // 0x68
        private System.String <customEventParams>k__BackingField;  // 0x70

        // Properties
        System.Int32 dataType { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.String uid { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String roleID { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String roleName { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        System.String roleLevel { get; /* RVA: 0x01003830 */ }
        System.Int32 serverID { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.String serverName { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        System.String channel { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.String subChannel { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Boolean isNewUser { get; /* RVA: 0x03D4F7E0 */ set; /* RVA: 0x03D4F7F0 */ }
        System.Int64 revenue { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x03D4EE20 */ }
        System.String customEventName { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        System.String customEventParams { get; /* RVA: 0x03D4EB30 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600018E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x48
    public sealed struct U8LoginResult
    {
        // Fields
        public static readonly U8.SDK.U8LoginResult EMPTY;  // static @ 0x0
        public System.Int32 result;  // 0x10
        public System.String uid;  // 0x18
        public System.String channelUid;  // 0x20
        public System.String token;  // 0x28
        public System.String extension;  // 0x30
        public System.Boolean isGuest;  // 0x38
        public System.Boolean isNew;  // 0x39
        public System.String error;  // 0x40

        // Methods
        // RVA: 0x088798E0  token: 0x600018F
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004A  // size: 0x18
    public sealed struct U8ProductError
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.Int32 errorCode;  // 0x14

    }

    // TypeToken: 0x200004B  // size: 0x14
    public sealed struct PayResultStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.PayResultStatus SUCCEED;  // const
        public static U8.SDK.PayResultStatus PENDING;  // const

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct PayFailStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.PayFailStatus UNKNOWN;  // const
        public static U8.SDK.PayFailStatus CANCELED;  // const
        public static U8.SDK.PayFailStatus ERROR;  // const
        public static U8.SDK.PayFailStatus HALT;  // const

    }

    // TypeToken: 0x200004D  // size: 0x20
    public class U8ConfirmServerResult
    {
        // Fields
        public System.Int32 status;  // 0x10
        public System.String message;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000190
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x14
    public sealed struct U8ConfirmOrderStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static U8.SDK.U8ConfirmOrderStatus NONE;  // const
        public static U8.SDK.U8ConfirmOrderStatus INTERNAL_ERROR;  // const
        public static U8.SDK.U8ConfirmOrderStatus TIMEOUT;  // const
        public static U8.SDK.U8ConfirmOrderStatus INVALID_ORDER;  // const
        public static U8.SDK.U8ConfirmOrderStatus SUCCEED;  // const

    }

    // TypeToken: 0x200004F  // size: 0x20
    public class U8ConfirmOrderResult
    {
        // Fields
        public U8.SDK.U8ConfirmOrderStatus status;  // 0x10
        public System.String message;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000191
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000050  // size: 0x28
    public sealed struct U8PayFailMsg
    {
        // Fields
        public static U8.SDK.U8PayFailMsg EMPTY;  // static @ 0x0
        public U8.SDK.PayFailStatus status;  // 0x10
        public System.String message;  // 0x18
        public System.String extension;  // 0x20

        // Methods
        // RVA: 0x08879B28  token: 0x6000192
        public static U8.SDK.U8PayFailMsg FromJson(System.String jsonStr) { }
        // RVA: 0x08879E28  token: 0x6000193
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000051  // size: 0x28
    public sealed struct U8PayResult
    {
        // Fields
        public static readonly U8.SDK.U8PayResult EMPTY;  // static @ 0x0
        public U8.SDK.PayResultStatus status;  // 0x10
        public System.String outTradeNo;  // 0x18
        public System.String extension;  // 0x20

        // Methods
        // RVA: 0x08879E8C  token: 0x6000194
        public static U8.SDK.U8PayResult FromJson(System.String jsonData) { }
        // RVA: 0x0887A10C  token: 0x6000195
        public virtual System.String ToString() { }
        // RVA: 0x0887A1F8  token: 0x6000196
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000052  // size: 0xD8
    public class SDKInterfaceWIN : U8.SDK.U8SDKInterface
    {
        // Fields
        private System.Int32 actionIndex;  // 0xd0
        private static System.Collections.Generic.Dictionary<System.Int32,System.Action<System.String>> dictAction;  // static @ 0x0

        // Methods
        // RVA: 0x02D787D0  token: 0x6000197
        public System.Void .ctor() { }
        // RVA: 0x088736A4  token: 0x6000198
        protected virtual System.Void Finalize() { }
        // RVA: 0x02E99B30  token: 0x6000199
        public System.Int32 AddAction(System.Action<System.String> action) { }
        // RVA: 0x026906B0  token: 0x600019A
        public static System.Void DataActionCallback(System.Int32 index, System.String paramValue) { }
        // RVA: 0x088734B8  token: 0x600019B
        public static System.Void ASyncDataActionCallback(System.Int32 index, System.String paramValue) { }
        // RVA: 0x02690A30  token: 0x600019C
        public static System.Void U8SDKSendMessage(System.String methodName, System.String paramValue) { }
        // RVA: 0x022C71F0  token: 0x600019D
        public static System.Void HGU8SDKInitLibrary(System.String windowText, System.Int64 windowHandle) { }
        // RVA: 0x022C72A0  token: 0x600019E
        public static System.Int32 HGU8SDKSetUserDataPath(System.String path) { }
        // RVA: 0x08873A30  token: 0x600019F
        public static System.Void HGU8SDKUnInitLibrary() { }
        // RVA: 0x022C7350  token: 0x60001A0
        public static System.Void HGU8SDKInitDatacallback(U8.SDK.SDKInterfaceWIN.DataCallback Callback, U8.SDK.SDKInterfaceWIN.DataCallback asyncCallback) { }
        // RVA: 0x022C73F0  token: 0x60001A1
        public static System.Void HGU8SDKInitSendMessage(U8.SDK.SDKInterfaceWIN.U8SDKSendMessageCallback callback) { }
        // RVA: 0x022C7480  token: 0x60001A2
        public static System.Void HGU8SDKV2Init(System.String env) { }
        // RVA: 0x08873870  token: 0x60001A3
        public static System.Void HGU8SDKLogin() { }
        // RVA: 0x088737E8  token: 0x60001A4
        public static System.Void HGU8SDKLoginCustom(System.String json) { }
        // RVA: 0x088738D8  token: 0x60001A5
        public static System.Int32 HGU8SDKLogout() { }
        // RVA: 0x088739C8  token: 0x60001A6
        public static System.Int32 HGU8SDKShowAccountCenter() { }
        // RVA: 0x08873940  token: 0x60001A7
        public static System.Void HGU8SDKPay(System.String json) { }
        // RVA: 0x02E988E0  token: 0x60001A8
        public static System.Void HGU8SDKSubmitGameData(System.String json) { }
        // RVA: 0x08873770  token: 0x60001A9
        public static System.Void HGU8SDKGetSDKMeta(System.Int32 index) { }
        // RVA: 0x02E5B410  token: 0x60001AA
        public static System.Void HGU8SDKSetData(System.Int32 code, System.String paramJson) { }
        // RVA: 0x02E99D40  token: 0x60001AB
        public static System.Void HGU8SDKGetData(System.Int32 code, System.String paramJson, System.Int32 index) { }
        // RVA: 0x022C7520  token: 0x60001AC
        public static System.Int32 HGU8SDKIsNativePlugin() { }
        // RVA: 0x02E99DB0  token: 0x60001AD
        public static System.Void HGU8SDKLoadExtraConfig(System.Int32 index) { }
        // RVA: 0x03C94670  token: 0x60001AE
        public static System.Void HGU8SDKSetGameVersion(System.String version) { }
        // RVA: 0x02E99620  token: 0x60001AF
        protected virtual System.String LoadExtraConfig() { }
        // RVA: 0x038E8A60  token: 0x60001B0
        protected virtual System.Void V2Init(System.String env) { }
        // RVA: 0x08873C14  token: 0x60001B1
        protected virtual System.Void Login() { }
        // RVA: 0x08873C54  token: 0x60001B2
        protected virtual System.Boolean Logout() { }
        // RVA: 0x08873BC8  token: 0x60001B3
        protected virtual System.Void LoginCustom(System.String customData) { }
        // RVA: 0x02E98560  token: 0x60001B4
        public virtual System.Void SubmitGameData(U8.SDK.U8ExtraGameData data) { }
        // RVA: 0x02E5B360  token: 0x60001B5
        public virtual System.Void SetData(System.Int32 type, System.String paramJson) { }
        // RVA: 0x02E999F0  token: 0x60001B6
        public virtual System.String GetData(System.Int32 type, System.String paramJson) { }
        // RVA: 0x08873CFC  token: 0x60001B7
        public virtual System.Boolean ShowAccountCenter() { }
        // RVA: 0x08873C9C  token: 0x60001B8
        protected virtual System.Void Pay(U8.SDK.U8PayParams data) { }
        // RVA: 0x08873A98  token: 0x60001B9
        protected virtual U8.SDK.SDKMeta LoadSDKMeta() { }
        // RVA: 0x03D2A480  token: 0x60001BA
        protected virtual System.Boolean IsNativePlugin() { }
        // RVA: 0x03C94620  token: 0x60001BB
        public virtual System.Void SetGameVersion(System.String version) { }
        // RVA: 0x03CE30D0  token: 0x60001BC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x10
    public class ImageSaver
    {
        // Methods
        // RVA: 0x08870258  token: 0x60001CA
        public System.Threading.Tasks.Task SaveImage(System.String paramJson) { }
        // RVA: 0x08870A40  token: 0x60001CB
        private System.Boolean ValidateInput(System.String paramJson, U8.SDK.ImageSaver.ImageShareInfo& shareInfo) { }
        // RVA: 0x0886FF08  token: 0x60001CC
        private System.String NormalizeSourcePath(System.String imgPath) { }
        // RVA: 0x0887007C  token: 0x60001CD
        private U8.SDK.ImageSaver.FolderType ParseFolderType(System.Int32 folderType) { }
        // RVA: 0x0886F5D4  token: 0x60001CE
        private System.String BuildTargetPath(System.String sourcePath, System.String relativePath, System.String baseFolder) { }
        // RVA: 0x0886FB28  token: 0x60001CF
        private System.Boolean IsDirectoryPath(System.String path) { }
        // RVA: 0x0886F4A8  token: 0x60001D0
        private System.String BuildPathForDirectory(System.String sourcePath, System.String relativeDirPath, System.String baseFolder) { }
        // RVA: 0x08870138  token: 0x60001D1
        private System.Threading.Tasks.Task<System.Boolean> SaveImageToPathAsync(System.String sourcePath, System.String targetPath, System.String imgFolder) { }
        // RVA: 0x0886FBDC  token: 0x60001D2
        private System.Boolean IsSamePath(System.String sourcePath, System.String targetPath) { }
        // RVA: 0x08870B1C  token: 0x60001D3
        private System.Boolean ValidateMove(System.String sourcePath, System.String targetPath, System.String rootDir, System.String& error) { }
        // RVA: 0x0886F700  token: 0x60001D4
        private System.Void EnsureDirectoryExists(System.String filePath) { }
        // RVA: 0x0886FCB0  token: 0x60001D5
        private System.Boolean MoveFile(System.String sourcePath, System.String targetPath) { }
        // RVA: 0x0886F914  token: 0x60001D6
        private System.String GetImageSaveFolder(U8.SDK.ImageSaver.FolderType folderType) { }
        // RVA: 0x0886F9C8  token: 0x60001D7
        private System.String GetWindowsPicturePath() { }
        // RVA: 0x0886F768  token: 0x60001D8
        private System.String GetGameInstalledFolder() { }
        // RVA: 0x0887094C  token: 0x60001D9
        private System.Void SendSuccessResponse(System.String targetPath) { }
        // RVA: 0x08870328  token: 0x60001DA
        private System.Void SendErrorResponse(U8.SDK.ImageSaver.ErrorCode errorCode) { }
        // RVA: 0x088704D8  token: 0x60001DB
        private System.Void SendResponse(U8.SDK.ImageSaver.CallbackResult code, System.Collections.Generic.Dictionary<System.String,System.Object> extraMsg) { }
        // RVA: 0x08870400  token: 0x60001DC
        private System.Void SendMessageInMain(System.String methodName, System.String paramValue) { }
        // RVA: 0x0350B670  token: 0x60001DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x18
    public class U8MainThreadDispatcher : UnityEngine.MonoBehaviour
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentQueue<System.Action> _queue;  // static @ 0x0
        private static U8.SDK.U8MainThreadDispatcher _instance;  // static @ 0x8
        private static System.Int32 _initialized;  // static @ 0x10

        // Methods
        // RVA: 0x03B392E0  token: 0x60001E7
        private static System.Void Initialize() { }
        // RVA: 0x08879AB4  token: 0x60001E8
        public static System.Void RunOnMainThread(System.Action action) { }
        // RVA: 0x02339FE0  token: 0x60001E9
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x60001EA
        public System.Void .ctor() { }
        // RVA: 0x03A1DEE0  token: 0x60001EB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x40
    public class SDKMeta
    {
        // Fields
        public System.String appID;  // 0x10
        public System.String appKey;  // 0x18
        public System.String channel;  // 0x20
        public System.String worldId;  // 0x28
        public System.String extension;  // 0x30
        public System.String appCode;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x60001EC
        public System.Void .ctor() { }
        // RVA: 0x08873EA8  token: 0x60001ED
        public System.Void .ctor(System.String jsonData) { }
        // RVA: 0x08873D44  token: 0x60001EE
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000064
    public interface ISDKPromise
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001EF
        public virtual System.Void Fulfill(System.Object param) { }
        // RVA: -1  // abstract  token: 0x60001F0
        public virtual System.Void Reject(System.Object reason) { }

    }

    // TypeToken: 0x2000065
    public class SDKPromise`1 : U8.SDK.ISDKPromise
    {
        // Fields
        public System.Action<Param> onFulfilled;  // 0x0
        public System.Action<System.Object> onRejected;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001F1
        public virtual System.Void Fulfill(System.Object param) { }
        // RVA: -1  // not resolved  token: 0x60001F2
        public virtual System.Void Reject(System.Object reason) { }
        // RVA: -1  // not resolved  token: 0x60001F3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public class SDKPromiseWithResult`1 : U8.SDK.SDKPromise`1
    {
        // Fields
        private Param <result>k__BackingField;  // 0x0
        private System.Object <rejectInfo>k__BackingField;  // 0x0

        // Properties
        Param result { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Object rejectInfo { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001F8
        public virtual System.Void Fulfill(System.Object param) { }
        // RVA: -1  // not resolved  token: 0x60001F9
        public virtual System.Void Reject(System.Object reason) { }
        // RVA: -1  // not resolved  token: 0x60001FA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class SDKPromiseEnumerator`1
    {
        // Fields
        private U8.SDK.SDKPromiseEnumerator.State<T> m_state;  // 0x0
        private T <result>k__BackingField;  // 0x0
        private System.Object <reject>k__BackingField;  // 0x0

        // Properties
        System.Boolean isFulfilled { get; /* RVA: -1  // not resolved */ }
        T result { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Object reject { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000200
        public System.Collections.IEnumerator Yield() { }
        // RVA: -1  // not resolved  token: 0x6000201
        public System.Void .ctor(U8.SDK.SDKPromise<T> promise) { }
        // RVA: -1  // not resolved  token: 0x6000202
        private System.Void _OnFulfilled(T result) { }
        // RVA: -1  // not resolved  token: 0x6000203
        private System.Void _OnRejected(System.Object rejectInfo) { }

    }

    // TypeToken: 0x200006A  // size: 0x18
    public class SDKPromiseWrapper
    {
        // Fields
        private U8.SDK.ISDKPromise m_promise;  // 0x10

        // Methods
        // RVA: -1  // generic def  token: 0x600020A
        public T EnsurePromise() { }
        // RVA: 0x039C3210  token: 0x600020B
        public System.Void Fulfill(System.Object param) { }
        // RVA: 0x088741EC  token: 0x600020C
        public System.Void Reject(System.Object reason) { }
        // RVA: 0x035ACAA0  token: 0x600020D
        private System.Void _Clear() { }
        // RVA: 0x0350B670  token: 0x600020E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x10
    public static class SDKPromiseExtensions
    {
        // Methods
        // RVA: 0x088741D4  token: 0x600020F
        public static System.Void RejectWithString(U8.SDK.ISDKPromise promise, System.String errorInfo) { }
        // RVA: -1  // generic def  token: 0x6000210
        public static System.Void FulfillWithType(U8.SDK.SDKPromise<T> promise, T param) { }

    }

    // TypeToken: 0x200006C  // size: 0x18
    public class U8SDKTickEvent : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x031B4EF0  token: 0x6000211
        private System.Void Update() { }
        // RVA: 0x031B4F00  token: 0x6000212
        public static System.Void HGU8SDKTickEvent() { }
        // RVA: 0x0426FE60  token: 0x6000213
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x20
    public class U8TickEventManager
    {
        // Fields
        private UnityEngine.GameObject tickGameObject;  // 0x10
        private U8.SDK.U8SDKTickEvent tickEvent;  // 0x18
        private static U8.SDK.U8TickEventManager instanceManager;  // static @ 0x0
        private static readonly System.Object lockObject;  // static @ 0x8

        // Properties
        U8.SDK.U8TickEventManager InstanceManager { get; /* RVA: 0x038E8AF0 */ }

        // Methods
        // RVA: 0x038E8BD0  token: 0x6000215
        public System.Void InitTickEvent() { }
        // RVA: 0x0887BE68  token: 0x6000216
        public System.Void UnInitTickEvent() { }
        // RVA: 0x0350B670  token: 0x6000217
        public System.Void .ctor() { }
        // RVA: 0x03CFDD60  token: 0x6000218
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x28
    public class U8LoginV2Result
    {
        // Fields
        public System.String token;  // 0x10
        public System.String uid;  // 0x18
        public System.Boolean isNew;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000219
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006F  // size: 0x28
    public class U8AuthV2Result
    {
        // Fields
        public System.String uid;  // 0x10
        public System.String oauth2Code;  // 0x18
        public System.String oauth2Token;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600021A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x28
    public class U8GrantResult
    {
        // Fields
        public System.String uid;  // 0x10
        public System.String code;  // 0x18
        public System.String token;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600021B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000071  // size: 0x18
    public class U8SDKCallback : UnityEngine.MonoBehaviour
    {
        // Fields
        private static U8.SDK.U8SDKCallback m_instance;  // static @ 0x0
        private static System.Object m_lock;  // static @ 0x8

        // Methods
        // RVA: 0x02690BA0  token: 0x600021C
        public static U8.SDK.U8SDKCallback InitCallback() { }
        // RVA: 0x039C3110  token: 0x600021D
        public System.Void OnInitSuc(System.String extConfigs) { }
        // RVA: 0x0887A6DC  token: 0x600021E
        public System.Void OnInitFail(System.String info) { }
        // RVA: 0x039C3190  token: 0x600021F
        public System.Void OnLoginSuc(System.String extension) { }
        // RVA: 0x0887A734  token: 0x6000220
        public System.Void OnLoginFail(System.String info) { }
        // RVA: 0x0887A78C  token: 0x6000221
        public System.Void OnLogout(System.String info) { }
        // RVA: 0x0887A8F8  token: 0x6000222
        public System.Void OnSwitchAccount() { }
        // RVA: 0x0887A830  token: 0x6000223
        public System.Void OnPaySuc(System.String jsonData) { }
        // RVA: 0x0887A7D8  token: 0x6000224
        public System.Void OnPayFail(System.String failMsg) { }
        // RVA: 0x0887A888  token: 0x6000225
        public System.Void OnSDKError(System.String jsonData) { }
        // RVA: 0x02692D60  token: 0x6000226
        public System.Void OnExtraInfo(System.String jsonData) { }
        // RVA: 0x0887A944  token: 0x6000227
        private System.Collections.IEnumerator _onLogoutNextFrameCoroutine() { }
        // RVA: -1  // generic def  token: 0x6000228
        protected static T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        // RVA: 0x0426FE60  token: 0x6000229
        public System.Void .ctor() { }
        // RVA: 0x03CFDDD0  token: 0x600022A
        private static System.Void .cctor() { }

    }

}

namespace U8.SDK.MiniJSON
{

    // TypeToken: 0x2000073  // size: 0x10
    public static class Json
    {
        // Methods
        // RVA: 0x02694A20  token: 0x6000231
        public static System.Object Deserialize(System.String json) { }
        // RVA: 0x042743D8  token: 0x6000232
        public static System.String Serialize(System.Object obj) { }

    }

}

