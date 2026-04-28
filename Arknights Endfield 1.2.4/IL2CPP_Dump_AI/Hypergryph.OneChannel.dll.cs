// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.OneChannel.dll
// Classes:  123
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

CLASS: Status
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKCaptchaHandler.Status SUC  // const
  public    static  U8.SDK.SDKCaptchaHandler.Status SYS_BUSY  // const
  public    static  U8.SDK.SDKCaptchaHandler.Status USER_CANCEL  // const
  public    static  U8.SDK.SDKCaptchaHandler.Status NOT_SUPPORT  // const
  public    static  U8.SDK.SDKCaptchaHandler.Status INVALID_PARAM  // const
  public    static  U8.SDK.SDKCaptchaHandler.Status UNKNOWN  // const
METHODS:
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x20
FIELDS:
  private           U8.SDK.SDKCaptchaHandler.Status <status>k__BackingField  // 0x10
  private           System.Int32                    <errorCode>k__BackingField  // 0x14
  private           System.String                   <captcha>k__BackingField  // 0x18
PROPERTIES:
  status  get=0x03D4E340  set=0x010410F0
  errorCode  set=0x03D595B0
  captcha  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x6000010  System.Void .ctor()
  RVA=0x08870FBC  token=0x6000011  U8.SDK.SDKCaptchaHandler.Result CreateForOutput()
  RVA=0x08871054  token=0x6000012  System.Void MarkSucceed(System.String captcha)
  RVA=0x08871028  token=0x6000013  System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status, System.Int32 errorCode)
  RVA=0x08871000  token=0x6000014  System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status)
END_CLASS

CLASS: IFromJSON
TYPE:  interface
TOKEN: 0x200000A
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000058  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: POSTStatus
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.POSTStatusNONE  // const
  public    static  U8.SDK.SDKExternalTools.POSTStatusSUC  // const
  public    static  U8.SDK.SDKExternalTools.POSTStatusTIMEOUT  // const
  public    static  U8.SDK.SDKExternalTools.POSTStatusERROR  // const
METHODS:
END_CLASS

CLASS: BusType
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.BusType NONE  // const
  public    static  U8.SDK.SDKExternalTools.BusType GET_TOKEN  // const
  public    static  U8.SDK.SDKExternalTools.BusType GET_CAPTCHA  // const
  public    static  U8.SDK.SDKExternalTools.BusType CREATE_ORDER  // const
  public    static  U8.SDK.SDKExternalTools.BusType CONFIRM_ORDER  // const
  public    static  U8.SDK.SDKExternalTools.BusType VERIFY_ACCOUNT  // const
  public    static  U8.SDK.SDKExternalTools.BusType GET_PRODUCT_LIST  // const
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_SESSION_TOKEN  // const
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2CODE  // const
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2TOKEN  // const
  public    static  U8.SDK.SDKExternalTools.BusType SERVER_LIST  // const
  public    static  U8.SDK.SDKExternalTools.BusType CONFIRM_SERVER  // const
METHODS:
END_CLASS

CLASS: ErrorType
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.ErrorTypeNONE  // const
  public    static  U8.SDK.SDKExternalTools.ErrorTypeTIMEOUT  // const
  public    static  U8.SDK.SDKExternalTools.ErrorTypeNETWORK_ERROR  // const
  public    static  U8.SDK.SDKExternalTools.ErrorTypeDESERIALIZE_FAILED  // const
  public    static  U8.SDK.SDKExternalTools.ErrorTypeBUSINESS_ERROR  // const
METHODS:
END_CLASS

CLASS: POSTRequest
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x30
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   body  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>nullableHeaders  // 0x28
METHODS:
END_CLASS

CLASS: POSTResult
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x28
FIELDS:
  public            U8.SDK.SDKExternalTools.POSTStatusstatus  // 0x10
  public            System.Int32                    httpCode  // 0x14
  public            System.String                   response  // 0x18
  public            System.String                   error  // 0x20
METHODS:
  RVA=0x08870E90  token=0x6000059  System.Boolean ServiceFailed()
END_CLASS

CLASS: ErrMsgMeta
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x30
FIELDS:
  public    static readonly U8.SDK.SDKExternalTools.ErrMsgMetaEMPTY  // static @ 0x0
  public            U8.SDK.SDKExternalTools.BusType busType  // 0x10
  public            U8.SDK.SDKExternalTools.ErrorTypeerrorType  // 0x14
  public            System.Int32                    errorCode  // 0x18
  public            System.String                   alertFromServer  // 0x20
  public            System.Object                   meta  // 0x28
METHODS:
  RVA=0x022FBAA0  token=0x600005A  System.Boolean IsEmpty()
  RVA=0x0886F124  token=0x600005B  U8.SDK.SDKExternalTools.ErrMsgMeta FromPOSTResult(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet)
END_CLASS

CLASS: <FetchCaptchaCoroutine>d__6
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools.CaptchaMgr<>4__this  // 0x20
  public            U8.SDK.SDKCaptchaHandler.Result outResult  // 0x28
  public            System.Collections.Generic.Dictionary<System.String,System.Object>captchaParams  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000060  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x088751EC  token=0x6000061  System.Void System.IDisposable.Dispose()
  RVA=0x08874E04  token=0x6000062  System.Boolean MoveNext()
  RVA=0x08875264  token=0x6000063  System.Void <>m__Finally1()
  RVA=0x088751A0  token=0x6000065  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: CaptchaMgr
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x20
FIELDS:
  private           U8.SDK.SDKExternalTools         m_host  // 0x10
  private           U8.SDK.SDKCaptchaHandler        <activeHandler>k__BackingField  // 0x18
PROPERTIES:
  activeHandler  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0426FEE0  token=0x600005E  System.Void .ctor(U8.SDK.SDKExternalTools host)
  RVA=0x0886EB7C  token=0x600005F  System.Collections.IEnumerator FetchCaptchaCoroutine(System.Collections.Generic.Dictionary<System.String,System.Object> captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
END_CLASS

CLASS: Builder
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x38
FIELDS:
  public            U8.SDK.SDKExternalTools.POSTRequestrequest  // 0x10
  public            U8.SDK.SDKExternalTools.BusType busType  // 0x30
METHODS:
  RVA=0x0886EB08  token=0x6000073  U8.SDK.SDKExternalTools.POSTProcedure Build()
  RVA=-1  // generic def  token=0x6000074  U8.SDK.SDKExternalTools.POSTProcedure<TResp> TypedBuild()
END_CLASS

CLASS: <POST>d__18
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         host  // 0x20
  public            U8.SDK.SDKExternalTools.POSTProcedure<>4__this  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000075  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000076  System.Void System.IDisposable.Dispose()
  RVA=0x08875294  token=0x6000077  System.Boolean MoveNext()
  RVA=0x088753B8  token=0x6000079  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: POSTProcedure
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x68
FIELDS:
  private           U8.SDK.SDKExternalTools.POSTProcedure.Builder<builder>k__BackingField  // 0x10
  private           System.Boolean                  <isServiceFinished>k__BackingField  // 0x38
  private           U8.SDK.SDKExternalTools.ErrMsgMeta<serviceError>k__BackingField  // 0x40
  private           System.String                   <rawResponse>k__BackingField  // 0x60
PROPERTIES:
  builder  get=0x020B6ED0  set=0x08861778
  isServiceFinished  get=0x03D4F190  set=0x03D4E280
  serviceError  get=0x03D6DAD0  set=0x08870E78
  rawResponse  set=0x039274B0
METHODS:
  RVA=0x03D6DA90  token=0x600006E  U8.SDK.SDKExternalTools.ErrMsgMeta MakeBusinessError(System.Int32 errorCode)
  RVA=0x08870CF4  token=0x600006F  System.Collections.IEnumerator POST(U8.SDK.SDKExternalTools host)
  RVA=0x08870D68  token=0x6000070  System.Void _OnServiceFinished(U8.SDK.SDKExternalTools.POSTResult postRet)
  RVA=0x0350B670  token=0x6000071  System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet)
  RVA=0x0350B670  token=0x6000072  System.Void .ctor()
END_CLASS

CLASS: POSTProcedure`1
TYPE:  class
TOKEN: 0x2000016
EXTENDS: POSTProcedure
FIELDS:
  private           TResp                           <response>k__BackingField  // 0x0
PROPERTIES:
  response  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600007D  System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet)
  RVA=-1  // not resolved  token=0x600007E  System.Void .ctor()
END_CLASS

CLASS: AuthV2SessionTokenResp
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x40
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   uid  // 0x30
  public            System.Boolean                  isNew  // 0x38
METHODS:
  RVA=0x0886E914  token=0x600007F  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0350B670  token=0x6000080  System.Void .ctor()
END_CLASS

CLASS: GetProductLsitResp
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x20
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    flag  // 0x10
  public            System.Collections.Generic.Dictionary<System.String,System.Object>desc  // 0x18
METHODS:
  RVA=0x0886F164  token=0x6000081  System.Boolean LoadFromDictionary(System.Collections.Generic.Dictionary<System.String,System.Object> dict)
  RVA=0x0886F3C8  token=0x6000082  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0350B670  token=0x6000083  System.Void .ctor()
END_CLASS

CLASS: AuthV2GrantResp
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x68
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            System.String                   uid  // 0x28
  public            System.String                   code  // 0x30
  public            System.String                   token  // 0x38
  public            System.Int64                    banStartTs  // 0x40
  public            System.Int64                    banEndTs  // 0x48
  public            System.Int64                    maintainStartTs  // 0x50
  public            System.Int64                    maintainEndTs  // 0x58
  public            System.Collections.Generic.Dictionary<System.String,System.Object>captcha  // 0x60
METHODS:
  RVA=0x0886E648  token=0x6000084  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0350B670  token=0x6000085  System.Void .ctor()
END_CLASS

CLASS: ServerData
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x50
FIELDS:
  public            System.String                   serverId  // 0x10
  public            System.String                   serverName  // 0x18
  public            System.String                   serverDomain  // 0x20
  public            System.Boolean                  defaultChoose  // 0x28
  public            System.String                   roleId  // 0x30
  public            System.String                   nickName  // 0x38
  public            System.Int64                    level  // 0x40
  public            System.String                   extension  // 0x48
METHODS:
END_CLASS

CLASS: ServerListResp
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x28
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.Collections.Generic.List<U8.SDK.SDKExternalTools.ServerListResp.ServerData>data  // 0x20
METHODS:
  RVA=0x08874694  token=0x6000086  System.Boolean LoadFromJSON(System.String json)
  RVA=0x08874B8C  token=0x6000087  System.Collections.Generic.List<U8.SDK.U8ServerInfo> ToServerInfo()
  RVA=0x0350B670  token=0x6000088  System.Void .ctor()
END_CLASS

CLASS: ConfirmServerResp
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x20
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
METHODS:
  RVA=0x0886ECA4  token=0x6000089  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0350B670  token=0x600008A  System.Void .ctor()
END_CLASS

CLASS: ConfirmOrderU1Resp
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x18
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
METHODS:
  RVA=0x0886EC08  token=0x600008B  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0350B670  token=0x600008C  System.Void .ctor()
END_CLASS

CLASS: Data
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x40
FIELDS:
  public            System.String                   orderId  // 0x10
  public            System.String                   channelProductCode  // 0x18
  public            System.String                   productName  // 0x20
  public            System.String                   productDesc  // 0x28
  public            System.Int64                    amount  // 0x30
  public            System.Collections.Generic.Dictionary<System.String,System.Object>extension  // 0x38
METHODS:
END_CLASS

CLASS: CreateOrderU1Resp
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x58
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            U8.SDK.SDKExternalTools.CreateOrderU1Resp.Datadata  // 0x28
METHODS:
  RVA=0x0886ED80  token=0x600008D  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0886F00C  token=0x600008E  U8.SDK.U8OrderInfo ToOrderInfo()
  RVA=0x0350B670  token=0x600008F  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
  public    static readonly U8.SDK.SDKExternalTools.<>c     <>9  // static @ 0x0
  public    static  System.Action<System.String>    <>9__43_0  // static @ 0x8
  public    static  System.Action<System.String>    <>9__43_1  // static @ 0x10
  public    static  System.Action                   <>9__44_0  // static @ 0x18
  public    static  System.Action                   <>9__44_1  // static @ 0x20
METHODS:
  RVA=0x03D0E270  token=0x6000090  System.Void .cctor()
  RVA=0x0350B670  token=0x6000091  System.Void .ctor()
  RVA=0x03CF6470  token=0x6000092  System.Void <LoginWithPlugin>b__43_0(System.String extension)
  RVA=0x08876188  token=0x6000093  System.Void <LoginWithPlugin>b__43_1(System.String message)
  RVA=0x088761F4  token=0x6000094  System.Void <LogoutWithPlugin>b__44_0()
  RVA=0x08876274  token=0x6000095  System.Void <LogoutWithPlugin>b__44_1()
END_CLASS

CLASS: <_NextFrameCoroutine>d__61
TYPE:  sealed class
TOKEN: 0x2000021
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Action                   action  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000096  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000097  System.Void System.IDisposable.Dispose()
  RVA=0x08878F2C  token=0x6000098  System.Boolean MoveNext()
  RVA=0x08878F7C  token=0x600009A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <SDKInterfaceAuthV2SessionToken>d__113
TYPE:  sealed class
TOKEN: 0x2000022
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result>promise  // 0x20
  public            U8.SDK.SDKMeta                  meta  // 0x28
  public            System.String                   channelToken  // 0x30
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x38
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.AuthV2SessionTokenResp><postImpl>5__2  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600009C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600009D  System.Void System.IDisposable.Dispose()
  RVA=0x088754B4  token=0x600009E  System.Boolean MoveNext()
  RVA=0x08875998  token=0x60000A0  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <SDKInterfaceAuthV2OAuth2Code>d__114
TYPE:  sealed class
TOKEN: 0x2000023
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   sessionToken  // 0x28
  public            U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult>promise  // 0x30
  public            System.Action                   onSessionInvalid  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000A2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000A3  System.Void System.IDisposable.Dispose()
  RVA=0x08875404  token=0x60000A4  System.Boolean MoveNext()
  RVA=0x08875468  token=0x60000A6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_AuthV2GrantImpl>d__120
TYPE:  sealed class
TOKEN: 0x2000024
SIZE:  0x60
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult>promise  // 0x20
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x28
  public            System.String                   sessionToken  // 0x30
  public            System.Action                   onSessionInvalid  // 0x38
  private           System.String                   <captcha>5__2  // 0x40
  private           System.Boolean                  <needCaptcha>5__3  // 0x48
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.AuthV2GrantResp><postImpl>5__4  // 0x50
  private           U8.SDK.SDKCaptchaHandler.Result <captchaRet>5__5  // 0x58
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000A8  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000A9  System.Void System.IDisposable.Dispose()
  RVA=0x08877DB0  token=0x60000AA  System.Boolean MoveNext()
  RVA=0x08878504  token=0x60000AC  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_ConfirmOrderU1Coroutine>d__123
TYPE:  sealed class
TOKEN: 0x2000025
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   orderId  // 0x28
  public            System.String                   extension  // 0x30
  public            U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult>promise  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000AE  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000AF  System.Void System.IDisposable.Dispose()
  RVA=0x08878550  token=0x60000B0  System.Boolean MoveNext()
  RVA=0x08878754  token=0x60000B2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_PollOrderStatusCoroutine>d__124
TYPE:  sealed class
TOKEN: 0x2000026
SIZE:  0x70
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   orderId  // 0x28
  public            U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult>promise  // 0x30
  private           System.Int32                    <tryCnt>5__2  // 0x38
  private           System.Int32                    <maxTryCnt>5__3  // 0x3c
  private           U8.SDK.SDKExternalTools.POSTProcedure.Builder<postBuilder>5__4  // 0x40
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ConfirmOrderU1Resp><postImpl>5__5  // 0x68
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000B4  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000B5  System.Void System.IDisposable.Dispose()
  RVA=0x08878FC8  token=0x60000B6  System.Boolean MoveNext()
  RVA=0x0887948C  token=0x60000B8  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetServerListCoroutine>d__125
TYPE:  sealed class
TOKEN: 0x2000027
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   paramStr  // 0x28
  public            U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>>promise  // 0x30
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ServerListResp><postImpl>5__2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000BA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000BB  System.Void System.IDisposable.Dispose()
  RVA=0x08878BA0  token=0x60000BC  System.Boolean MoveNext()
  RVA=0x08878E48  token=0x60000BE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_ConfirmServerListCoroutine>d__127
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   paramStr  // 0x28
  public            U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult>promise  // 0x30
  public            System.String                   serverId  // 0x38
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.ConfirmServerResp><postImpl>5__2  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000C0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000C1  System.Void System.IDisposable.Dispose()
  RVA=0x088787A0  token=0x60000C2  System.Boolean MoveNext()
  RVA=0x08878B54  token=0x60000C4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_SendCreateOrderU1Coroutine>d__128
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.SDKExternalTools         <>4__this  // 0x20
  public            System.String                   paramStr  // 0x28
  public            U8.SDK.SDKPromise<U8.SDK.U8OrderInfo>promise  // 0x30
  private           U8.SDK.SDKExternalTools.POSTProcedure<U8.SDK.SDKExternalTools.CreateOrderU1Resp><postImpl>5__2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000C6  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000C7  System.Void System.IDisposable.Dispose()
  RVA=0x088794D8  token=0x60000C8  System.Boolean MoveNext()
  RVA=0x08879770  token=0x60000CA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: U8ProductListDataV2
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x18
IMPLEMENTS: IFromJSON
FIELDS:
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>productList  // 0x10
METHODS:
  RVA=0x0887A26C  token=0x60000D4  System.Boolean LoadFromJSON(System.String json)
  RVA=0x0887A514  token=0x60000D5  System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict)
END_CLASS

CLASS: RequestConnPolicy
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalToolsShortcut.RequestConnPolicyDEFAULT  // const
  public    static  U8.SDK.SDKExternalToolsShortcut.RequestConnPolicyCLOSE_EACH_CON  // const
METHODS:
END_CLASS

CLASS: RequestHeaderInjectOptions
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x14
FIELDS:
  public            U8.SDK.SDKExternalToolsShortcut.RequestConnPolicypolicy  // 0x10
METHODS:
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x48
FIELDS:
  public            U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>>promise  // 0x10
  public            U8.SDK.SDKExternalToolsShortcut <>4__this  // 0x18
  public            U8.SDK.SDKExternalTools.POSTRequestrequest  // 0x20
  public            System.Action<U8.SDK.SDKExternalTools.POSTResult>callback  // 0x40
METHODS:
  RVA=0x0350B670  token=0x60000D6  System.Void .ctor()
  RVA=0x088763CC  token=0x60000D7  System.Void <SendGetProductListRequestV2>b__0(U8.SDK.SDKExternalTools.POSTResult postRet)
  RVA=0x08876510  token=0x60000D8  System.Void <SendGetProductListRequestV2>b__1()
END_CLASS

CLASS: AuthStatus
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x30
FIELDS:
  public    static readonly U8.SDK.U8SDKInterface.AuthStatusEMPTY  // static @ 0x0
  public            System.String                   uid  // 0x10
  public            System.String                   oauth2code  // 0x18
  public            System.String                   oauth2token  // 0x20
  public            System.String                   sessionToken  // 0x28
METHODS:
END_CLASS

CLASS: V2LoginStatus
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x18
FIELDS:
  public            System.String                   sessionToken  // 0x10
METHODS:
END_CLASS

CLASS: ReceiverProductListResult
TYPE:  sealed class
TOKEN: 0x2000033
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x056E13A4  token=0x6000123  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000124  System.Void Invoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg)
END_CLASS

CLASS: GameServerTimeCache
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x28
FIELDS:
  public            System.Int64                    cacheTime  // 0x10
  public            System.Int64                    maintainEndTs  // 0x18
  public            System.Int64                    maintainStartTs  // 0x20
METHODS:
END_CLASS

CLASS: <>c__DisplayClass51_0`1
TYPE:  sealed class
TOKEN: 0x2000035
FIELDS:
  public            U8.SDK.SDKPromise<System.String>delegatePromise  // 0x0
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x0
  public            System.String                   env  // 0x0
  public            System.Action                   <>9__3  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000125  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000126  System.Void <V2PublicInit>b__0(System.String obj)
  RVA=-1  // not resolved  token=0x6000127  System.Void <V2PublicInit>b__3()
  RVA=-1  // not resolved  token=0x6000128  System.Void <V2PublicInit>b__1(System.Object info)
  RVA=-1  // not resolved  token=0x6000129  System.Void <V2PublicInit>b__2()
END_CLASS

CLASS: <>c__DisplayClass55_0
TYPE:  sealed class
TOKEN: 0x2000036
SIZE:  0x28
FIELDS:
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x10
  public            System.String                   uid  // 0x18
  public            System.Boolean                  isNew  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600012A  System.Void .ctor()
  RVA=0x02E97D90  token=0x600012B  System.Void <_onLoginSuc>b__0()
END_CLASS

CLASS: <>c__DisplayClass57_0
TYPE:  sealed class
TOKEN: 0x2000037
SIZE:  0x38
FIELDS:
  public            U8.SDK.SDKExternalTools         externalTools  // 0x10
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x18
  public            U8.SDK.SDKPromise<U8.SDK.U8ProductsResult>delegatePromise  // 0x20
  public            System.Action<System.Collections.Generic.List<U8.SDK.U8ProductInfo>><>9__1  // 0x28
  public            System.Action<System.Object>    <>9__2  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600012C  System.Void .ctor()
  RVA=0x0887677C  token=0x600012D  System.Void <PublicGetProductListV2>b__0()
  RVA=0x0887689C  token=0x600012E  System.Void <PublicGetProductListV2>b__1(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  RVA=0x08876B70  token=0x600012F  System.Void <PublicGetProductListV2>b__2(System.Object rejectObj)
END_CLASS

CLASS: <>c__DisplayClass57_1
TYPE:  sealed class
TOKEN: 0x2000038
SIZE:  0x28
FIELDS:
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>productList  // 0x10
  public            U8.SDK.U8SDKInterface.ReceiverProductListResultreceiver  // 0x18
  public            U8.SDK.U8SDKInterface.<>c__DisplayClass57_0CS$<>8__locals1  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000130  System.Void .ctor()
  RVA=0x08876B94  token=0x6000131  System.Void <PublicGetProductListV2>b__3(System.Collections.Generic.Dictionary<System.String,System.Object> msg)
END_CLASS

CLASS: <>c__DisplayClass69_0
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x40
FIELDS:
  public            U8.SDK.U8PayParams              payParams  // 0x10
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x18
  public            U8.SDK.SDKPromise<U8.SDK.U8PayResult>wrappedPromise  // 0x20
  public            U8.SDK.U8ProductInfo            productInfo  // 0x28
  public            System.Action<U8.SDK.U8PayResult><>9__1  // 0x30
  public            System.Action<System.Object>    <>9__2  // 0x38
METHODS:
  RVA=0x0350B670  token=0x6000132  System.Void .ctor()
  RVA=0x088776A8  token=0x6000133  System.Void <PublicPay>b__0()
  RVA=0x08877834  token=0x6000134  System.Void <PublicPay>b__1(U8.SDK.U8PayResult payResult)
  RVA=0x08876B70  token=0x6000135  System.Void <PublicPay>b__2(System.Object payFailMsg)
  RVA=0x088778D8  token=0x6000136  System.Void <PublicPay>b__3(U8.SDK.U8PayResult payResult)
  RVA=0x08876B70  token=0x6000137  System.Void <PublicPay>b__4(System.Object payFailMsg)
END_CLASS

CLASS: <>c__DisplayClass70_0
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x20
FIELDS:
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x10
  public            System.Int64                    revenue  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000138  System.Void .ctor()
  RVA=0x0887797C  token=0x6000139  System.Void <_OnNativePayFulfilled>b__0()
END_CLASS

CLASS: <>c__DisplayClass78_0
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x20
FIELDS:
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x10
  public            U8.SDK.U8PayParams              payParams  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600013A  System.Void .ctor()
  RVA=0x088779EC  token=0x600013B  System.Void <_NativePay>b__0()
END_CLASS

CLASS: <_NextFrameCoroutine>d__105
TYPE:  sealed class
TOKEN: 0x200003C
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Action                   call  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600013C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600013D  System.Void System.IDisposable.Dispose()
  RVA=0x0399F0C0  token=0x600013E  System.Boolean MoveNext()
  RVA=0x08878EE0  token=0x6000140  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass131_0
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x20
FIELDS:
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x10
  public            U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result>promise  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000142  System.Void .ctor()
  RVA=0x03777080  token=0x6000143  System.Void <_DoMockAuthV2>b__0()
END_CLASS

CLASS: <_LoginV2Coroutine>d__132
TYPE:  sealed class
TOKEN: 0x200003E
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x20
  public            U8.SDK.SDKPromise<System.String>promise  // 0x28
  private           U8.SDK.SDKPromiseEnumerator<System.String><loginEnumerator>5__2  // 0x30
  private           U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result><sessionTokenPromise>5__3  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000144  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000145  System.Void System.IDisposable.Dispose()
  RVA=0x02E98060  token=0x6000146  System.Boolean MoveNext()
  RVA=0x08878E94  token=0x6000148  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_AuthV2Coroutine>d__134
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            U8.SDK.U8SDKInterface           <>4__this  // 0x20
  public            U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result>promise  // 0x28
  private           U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult><oauth2codePromise>5__2  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600014A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600014B  System.Void System.IDisposable.Dispose()
  RVA=0x08877A98  token=0x600014C  System.Boolean MoveNext()
  RVA=0x08877D64  token=0x600014E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: DataCallback
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x02D78970  token=0x60001BD  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x60001BE  System.Void Invoke(System.Int32 index, System.String paramValue)
END_CLASS

CLASS: U8SDKSendMessageCallback
TYPE:  sealed class
TOKEN: 0x2000054
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x02D77350  token=0x60001BF  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x60001C0  System.Void Invoke(System.String methodName, System.String paramValue)
END_CLASS

CLASS: <>c__DisplayClass34_0
TYPE:  sealed class
TOKEN: 0x2000055
SIZE:  0x18
FIELDS:
  public            System.String                   defaultValue  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001C1  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60001C2  System.Void <LoadExtraConfig>b__0(System.String data)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000056
SIZE:  0x10
FIELDS:
  public    static readonly U8.SDK.SDKInterfaceWIN.<>c      <>9  // static @ 0x0
  public    static  System.Action<System.Threading.Tasks.Task><>9__42_0  // static @ 0x8
METHODS:
  RVA=0x08877A34  token=0x60001C3  System.Void .cctor()
  RVA=0x0350B670  token=0x60001C4  System.Void .ctor()
  RVA=0x088762F4  token=0x60001C5  System.Void <SetData>b__42_0(System.Threading.Tasks.Task task)
END_CLASS

CLASS: <>c__DisplayClass43_0
TYPE:  sealed class
TOKEN: 0x2000057
SIZE:  0x18
FIELDS:
  public            System.String                   defaultValue  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001C6  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60001C7  System.Void <GetData>b__0(System.String data)
END_CLASS

CLASS: <>c__DisplayClass51_0
TYPE:  sealed class
TOKEN: 0x2000058
SIZE:  0x18
FIELDS:
  public            System.String                   json  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001C8  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60001C9  System.Void <LoadSDKMeta>b__0(System.String data)
END_CLASS

CLASS: FolderType
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.ImageSaver.FolderType    UserPicturesFolder  // const
  public    static  U8.SDK.ImageSaver.FolderType    GameInstalledFolder  // const
METHODS:
END_CLASS

CLASS: ErrorCode
TYPE:  sealed struct
TOKEN: 0x200005B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.ImageSaver.ErrorCode     NotInited  // const
  public    static  U8.SDK.ImageSaver.ErrorCode     ParamsError  // const
  public    static  U8.SDK.ImageSaver.ErrorCode     ImageNotFound  // const
  public    static  U8.SDK.ImageSaver.ErrorCode     ShareChannelError  // const
  public    static  U8.SDK.ImageSaver.ErrorCode     SaveFailed  // const
  public    static  U8.SDK.ImageSaver.ErrorCode     UnknowError  // const
METHODS:
END_CLASS

CLASS: CallbackResult
TYPE:  sealed struct
TOKEN: 0x200005C
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  U8.SDK.ImageSaver.CallbackResultSuccess  // const
  public    static  U8.SDK.ImageSaver.CallbackResultCancelled  // const
  public    static  U8.SDK.ImageSaver.CallbackResultFailed  // const
METHODS:
END_CLASS

CLASS: ImageShareInfo
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x30
FIELDS:
  public            System.String                   shareChannel  // 0x10
  public            System.String                   imgPath  // 0x18
  public            System.String                   relativePath  // 0x20
  public            System.Int32                    folderType  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001DE  System.Void .ctor()
END_CLASS

CLASS: <SaveImage>d__5
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x50
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            U8.SDK.ImageSaver               <>4__this  // 0x30
  public            System.String                   paramJson  // 0x38
  private           System.String                   <targetPath>5__2  // 0x40
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x48
METHODS:
  RVA=0x08875D0C  token=0x60001DF  System.Void MoveNext()
  RVA=0x0887612C  token=0x60001E0  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x200005F
SIZE:  0x30
FIELDS:
  public            U8.SDK.ImageSaver               <>4__this  // 0x10
  public            System.String                   sourcePath  // 0x18
  public            System.String                   targetPath  // 0x20
  public            System.String                   imgFolder  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001E1  System.Void .ctor()
  RVA=0x08876548  token=0x60001E2  System.Boolean <SaveImageToPathAsync>b__0()
END_CLASS

CLASS: <SaveImageToPathAsync>d__12
TYPE:  sealed struct
TOKEN: 0x2000060
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean><>t__builder  // 0x18
  public            U8.SDK.ImageSaver               <>4__this  // 0x30
  public            System.String                   sourcePath  // 0x38
  public            System.String                   targetPath  // 0x40
  public            System.String                   imgFolder  // 0x48
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Boolean><>u__1  // 0x50
METHODS:
  RVA=0x088759E4  token=0x60001E3  System.Void MoveNext()
  RVA=0x08875CAC  token=0x60001E4  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass23_0
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x20
FIELDS:
  public            System.String                   methodName  // 0x10
  public            System.String                   paramValue  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001E5  System.Void .ctor()
  RVA=0x08876720  token=0x60001E6  System.Void <SendMessageInMain>b__0()
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>NONE  // const
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>FULFILL  // const
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>REJECT  // const
METHODS:
END_CLASS

CLASS: <Yield>d__12
TYPE:  sealed class
TOKEN: 0x2000069
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            U8.SDK.SDKPromiseEnumerator<T>  <>4__this  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000204  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000205  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000206  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000208  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_onLogoutNextFrameCoroutine>d__13
TYPE:  sealed class
TOKEN: 0x2000072
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600022B  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600022C  System.Void System.IDisposable.Dispose()
  RVA=0x088797BC  token=0x600022D  System.Boolean MoveNext()
  RVA=0x08879894  token=0x600022F  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: TOKEN
TYPE:  sealed struct
TOKEN: 0x2000075
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNONE  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCURLY_OPEN  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCURLY_CLOSE  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSQUARED_OPEN  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSQUARED_CLOSE  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCOLON  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCOMMA  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSTRING  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNUMBER  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENTRUE  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENFALSE  // const
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNULL  // const
METHODS:
END_CLASS

CLASS: Parser
TYPE:  sealed class
TOKEN: 0x2000074
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.IO.StringReader          json  // 0x10
PROPERTIES:
  PeekChar  get=0x026950A0
  NextChar  get=0x02695280
  NextWord  get=0x02694C60
  NextToken  get=0x02694EE0
METHODS:
  RVA=0x02695330  token=0x6000233  System.Boolean IsWordBreak(System.Char c)
  RVA=0x02695910  token=0x6000234  System.Void .ctor(System.String jsonString)
  RVA=0x02694A40  token=0x6000235  System.Object Parse(System.String jsonString)
  RVA=0x03823730  token=0x6000236  System.Void Dispose()
  RVA=0x02694D20  token=0x6000237  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  RVA=0x08870E98  token=0x6000238  System.Collections.Generic.List<System.Object> ParseArray()
  RVA=0x02694B40  token=0x6000239  System.Object ParseValue()
  RVA=0x02694B70  token=0x600023A  System.Object ParseByToken(U8.SDK.MiniJSON.Json.Parser.TOKEN token)
  RVA=0x02695110  token=0x600023B  System.String ParseString()
  RVA=0x026953C0  token=0x600023C  System.Object ParseNumber()
  RVA=0x02694E50  token=0x600023D  System.Void EatWhitespace()
END_CLASS

CLASS: Serializer
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x18
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  RVA=0x031EDCB0  token=0x6000242  System.Void .ctor()
  RVA=0x031EDC30  token=0x6000243  System.String Serialize(System.Object obj)
  RVA=0x031EDEC0  token=0x6000244  System.Void SerializeValue(System.Object value)
  RVA=0x031EE2C0  token=0x6000245  System.Void SerializeObject(System.Collections.IDictionary obj)
  RVA=0x0887421C  token=0x6000246  System.Void SerializeArray(System.Collections.IList anArray)
  RVA=0x031EE080  token=0x6000247  System.Void SerializeString(System.String str)
  RVA=0x031EDD20  token=0x6000248  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x28
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=72
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x58
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000079
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72C8939CFEA086350CA0F084D5A8FFA18BE802D605B6111130EB5143B5882250C4  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24C9A1311D05AB372579F6B92A220603EAB8191E15071784A11774A076DC45320B  // static @ 0x48
METHODS:
END_CLASS

CLASS: Hypergryph.PlatformFacade.PlatformFacade
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000249  System.Void SetupPlatformFont(Hypergryph.PlatformFacade.IPlatformFont iFont)
END_CLASS

CLASS: Hypergryph.PlatformFacade.IPlatformFont
TYPE:  interface
TOKEN: 0x2000078
FIELDS:
METHODS:
END_CLASS

CLASS: U8.SDK.ExternalPluginLoginParams
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x38
FIELDS:
  public            System.Action                   nativeLogin  // 0x10
  public            System.Action<System.String>    nativeLoginCustom  // 0x18
  public            System.Action<System.String>    nativeOnLoginSuc  // 0x20
  public            System.Action<System.String>    nativeOnLoginFail  // 0x28
  public            System.Action<U8.SDK.U8MockLogin>markMockLogin  // 0x30
METHODS:
END_CLASS

CLASS: U8.SDK.ExternalPluginLogoutParams
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x28
FIELDS:
  public            System.Action                   nativeLogout  // 0x10
  public            System.Action                   nativeOnLogoutSuc  // 0x18
  public            System.Action                   nativeOnLogoutFail  // 0x20
METHODS:
END_CLASS

CLASS: U8.SDK.ExternalPluginPayParams
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x30
FIELDS:
  public            U8.SDK.U8PayParams              payParams  // 0x10
  public            System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>>nativePay  // 0x18
  public            System.Action<U8.SDK.U8PayResult>onPaySuc  // 0x20
  public            System.Action<System.Object>    onPayFail  // 0x28
METHODS:
END_CLASS

CLASS: U8.SDK.IExternalPlugin
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000001  System.Void Init()
  RVA=-1  // abstract  token=0x6000002  System.Void Login(U8.SDK.ExternalPluginLoginParams args)
  RVA=-1  // abstract  token=0x6000003  System.Void Pay(U8.SDK.ExternalPluginPayParams args)
  RVA=-1  // abstract  token=0x6000004  System.Void Logout(U8.SDK.ExternalPluginLogoutParams args)
  RVA=-1  // abstract  token=0x6000005  System.String GetSDKToken()
  RVA=-1  // abstract  token=0x6000006  System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta)
  RVA=-1  // abstract  token=0x6000007  System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  RVA=-1  // abstract  token=0x6000008  System.String GetPayAddition()
END_CLASS

CLASS: U8.SDK.SDKCaptchaHandler
TYPE:  abstract class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000009  System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
  RVA=0x0350B670  token=0x600000A  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKExternalTools
TYPE:  abstract class
TOKEN: 0x2000009
SIZE:  0x28
FIELDS:
  private   static readonly System.Char[]                   RANDOM_CHAR_MAP  // static @ 0x0
  protected static readonly System.Int32[]                  PAY_CONFIRM_RETRY_INTERVALS  // static @ 0x8
  private   static  U8.SDK.SDKExternalTools         s_instance  // static @ 0x10
  private   static  U8.SDK.IExternalPlugin          s_plugin  // static @ 0x18
  private           System.Boolean                  <inited>k__BackingField  // 0x10
  private           U8.SDK.SDKExternalTools.CaptchaMgr<captchaMgr>k__BackingField  // 0x18
  private           System.String                   <subChannel>k__BackingField  // 0x20
  private   static  System.Int32                    U8_SDK_SET_DATA_SET_SERVER  // static @ 0x20
PROPERTIES:
  inited  get=0x011797F0  set=0x03D4E960
  plugin  get=0x08873468
  captchaMgr  get=0x01041090  set=0x022C3A90
  subChannel  set=0x04271930
METHODS:
  RVA=-1  // generic def  token=0x600001B  System.Boolean SDKInterfaceInitExternalTools()
  RVA=0x02692650  token=0x600001C  U8.SDK.SDKExternalTools GetInstance()
  RVA=0x08871870  token=0x600001D  System.Boolean HasInstance()
  RVA=0x08871DD0  token=0x600001E  System.String PublicServiceSignKey()
  RVA=0x088726EC  token=0x600001F  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceProductListV2()
  RVA=0x08871D54  token=0x6000020  System.Void NotifyProductListUpdated(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  RVA=0x08872794  token=0x6000021  System.String SDKInterfaceSDKToken()
  RVA=0x042743D8  token=0x6000022  System.String MakeHttpPostParam(System.Collections.Generic.Dictionary<System.String,System.Object> param)
  RVA=0x02E992F0  token=0x6000023  System.Void LoginWithPlugin(System.Action nativeLogin, System.Action<System.String> nativeLoginCustom, System.Action<U8.SDK.U8MockLogin> markMockLogin)
  RVA=0x08871AC8  token=0x6000024  System.Void LogoutWithPlugin(System.Action nativeLogout)
  RVA=0x08872590  token=0x6000025  System.Void SDKInterfacePayWithPlugin(U8.SDK.U8PayParams payParams, System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay, System.Action<U8.SDK.U8PayResult> onSuc, System.Action<System.Object> onFail)
  RVA=0x088724BC  token=0x6000026  System.String SDKInterfaceGetPayAddition()
  RVA=0x08872970  token=0x6000027  System.Void StaticLog(System.String content)
  RVA=0x088728D8  token=0x6000028  System.Void StaticLogWarning(System.String content)
  RVA=0x08872840  token=0x6000029  System.Void StaticLogError(System.String content)
  RVA=0x039CAC00  token=0x600002A  System.Void RegisterPlugin(U8.SDK.IExternalPlugin plugin)
  RVA=-1  // generic def  token=0x600002B  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  RVA=0x08872A08  token=0x600002C  System.String U8Url(System.String routeUrl)
  RVA=0x08872AAC  token=0x600002D  System.String U8urlWithoutU8(System.String routeUrl)
  RVA=-1  // generic def  token=0x600002E  U8.SDK.SDKExternalTools.ErrMsgMeta HandleResponseFromU8(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet, TResp& resp)
  RVA=0x088717AC  token=0x600002F  System.Collections.Generic.Dictionary<System.String,System.Object> FromMiniJSON(System.String json)
  RVA=0x088718B8  token=0x6000030  System.Void InternalInvokeCoroutine(System.Collections.IEnumerator coroutine)
  RVA=0x08871914  token=0x6000031  System.Void InternalInvokeNextFrame(System.Action action)
  RVA=0x088732F4  token=0x6000032  System.Collections.IEnumerator _NextFrameCoroutine(System.Action action)
  RVA=0x03B36670  token=0x6000033  System.Void InitIfNot()
  RVA=0x0350B670  token=0x6000034  System.Void Init()
  RVA=0x0350B670  token=0x6000035  System.Void SwitchAccount()
  RVA=0x0350B670  token=0x6000036  System.Void OnSDKError(U8.SDK.SDKError error)
  RVA=0x0350B670  token=0x6000037  System.Void OnInvalidProduct(System.Int32 storeId)
  RVA=0x0350B670  token=0x6000038  System.Void OnSDKExtraInfo(System.String jsonData)
  RVA=0x088719A0  token=0x6000039  U8.SDK.SDKMeta LoadSDKMetaFromPlugin(System.Func<U8.SDK.SDKMeta> nativeLoadMeta)
  RVA=-1  // abstract  token=0x600003A  U8.SDK.SDKCaptchaHandler CreateCaptchaHandler()
  RVA=0x01002730  token=0x600003B  System.String GetSignKey()
  RVA=-1  // abstract  token=0x600003C  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  RVA=-1  // abstract  token=0x600003D  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr)
  RVA=-1  // abstract  token=0x600003E  System.Int32 GetPlatformKey()
  RVA=-1  // abstract  token=0x600003F  System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback)
  RVA=-1  // abstract  token=0x6000040  System.String U8RootUrl()
  RVA=-1  // abstract  token=0x6000041  System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta)
  RVA=-1  // abstract  token=0x6000042  System.Void Log(System.String content)
  RVA=-1  // abstract  token=0x6000043  System.Void LogWarning(System.String content)
  RVA=-1  // abstract  token=0x6000044  System.Void LogError(System.String content)
  RVA=0x02E97CC0  token=0x6000045  System.Boolean _ValidatePlugin()
  RVA=0x08872FDC  token=0x6000046  System.String _MakeGetProductListV2Param(U8.SDK.SDKMeta meta)
  RVA=0x08872134  token=0x6000047  System.Collections.IEnumerator SDKInterfaceAuthV2SessionToken(U8.SDK.SDKMeta meta, System.String channelToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> promise)
  RVA=0x0887208C  token=0x6000048  System.Collections.IEnumerator SDKInterfaceAuthV2OAuth2Code(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid)
  RVA=0x088721DC  token=0x6000049  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(System.String orderId, System.String extension)
  RVA=0x08871F70  token=0x600004A  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> SDKInterFaceGetServerList(System.String sessionToken)
  RVA=0x08871E1C  token=0x600004B  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> SDKInterFaceConfirmServer(System.String sessionToken, System.String serverId)
  RVA=0x08872290  token=0x600004C  U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> SDKInterfaceCreateOrderU1(System.String sessionToken, System.String productId, System.String signParams)
  RVA=0x08873140  token=0x600004D  System.String _MakeGrantParam(System.String sessionToken, System.Int32 type, System.String captcha)
  RVA=0x08872BA4  token=0x600004E  System.Collections.IEnumerator _AuthV2GrantImpl(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid)
  RVA=0x08872E28  token=0x600004F  System.String _MakeCheckOrderV1Param(System.String orderId, System.String extension)
  RVA=0x08872F20  token=0x6000050  System.String _MakeConfirmOrderV1Param(System.String orderId)
  RVA=0x08872C4C  token=0x6000051  System.Collections.IEnumerator _ConfirmOrderU1Coroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise)
  RVA=0x08873350  token=0x6000052  System.Collections.IEnumerator _PollOrderStatusCoroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise)
  RVA=0x08872D9C  token=0x6000053  System.Collections.IEnumerator _GetServerListCoroutine(System.String paramStr, U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> promise)
  RVA=0x08872CF4  token=0x6000054  System.Collections.IEnumerator _ConfirmServerListCoroutine(System.String paramStr, System.String serverId, U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> promise)
  RVA=0x088733DC  token=0x6000055  System.Collections.IEnumerator _SendCreateOrderU1Coroutine(System.String paramStr, U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> promise)
  RVA=0x0350B670  token=0x6000056  System.Void .ctor()
  RVA=0x03B39900  token=0x6000057  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKExtraData
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x20
FIELDS:
  public    static readonly U8.SDK.SDKExtraData             EMPTY  // static @ 0x0
  public            System.Int32                    code  // 0x10
  public            System.Collections.Generic.Dictionary<System.String,System.Object>msg  // 0x18
METHODS:
  RVA=0x02692BF0  token=0x60000CC  U8.SDK.SDKExtraData FromJson(System.String jsonStr)
  RVA=0x03D1BA30  token=0x60000CD  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKExternalToolsShortcut
TYPE:  abstract class
TOKEN: 0x200002B
SIZE:  0x28
EXTENDS: U8.SDK.SDKExternalTools
FIELDS:
METHODS:
  RVA=0x088715A0  token=0x60000CE  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr)
  RVA=0x0887129C  token=0x60000CF  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  RVA=0x088713A8  token=0x60000D0  System.String GetU8DeviceID()
  RVA=0x088714C8  token=0x60000D1  System.Void InjectRequestHeaders(System.Collections.Generic.Dictionary<System.String,System.String>& headers, U8.SDK.SDKExternalToolsShortcut.RequestHeaderInjectOptions policy)
  RVA=0x08871770  token=0x60000D2  System.String _GetProductListV1Url()
  RVA=0x03D42B80  token=0x60000D3  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8SDKInterface
TYPE:  abstract class
TOKEN: 0x2000030
SIZE:  0xD0
FIELDS:
  private   static  U8.SDK.U8SDKInterface           m_instance  // static @ 0x0
  protected         U8.SDK.SDKPromiseWrapper        m_initPromise  // 0x10
  protected         U8.SDK.SDKPromiseWrapper        m_loginPromise  // 0x18
  protected         U8.SDK.SDKPromiseWrapper        m_logoutPromise  // 0x20
  protected         U8.SDK.SDKPromiseWrapper        m_payPromise  // 0x28
  private           U8.SDK.U8LoginResult            m_loginResult  // 0x30
  private           U8.SDK.U8SDKInterface.AuthStatusm_authStatus  // 0x68
  private           System.String                   m_loginExtV1  // 0x88
  private           U8.SDK.U8MockLogin              m_mockLogin  // 0x90
  private           System.Collections.Generic.List<U8.SDK.U8ProductInfo>m_productList  // 0xa0
  private           System.Nullable<System.Boolean> m_isNativePlugin  // 0xa8
  private           U8.SDK.U8SDKInterface.V2LoginStatusm_loginStatusV2  // 0xb0
  private   static  System.Int32                    U8_SDK_SET_DATA_SET_SESSION_TOKEN  // static @ 0x8
  private   static  System.Int32                    U8_SDK_SET_DATA_GET_PRODUCT_LIST  // static @ 0xc
  private   static  U8.SDK.U8SDKInterface.ReceiverProductListResultonReceiverProductlist  // static @ 0x10
  private           U8.SDK.U8SDKInterface.GameServerTimeCachem_gameServerTimeCache  // 0xb8
PROPERTIES:
  Instance  get=0x02D7A390
  isNativePlugin  get=0x02E97C40
  uid  get=0x03D4EAB0
  cachedUid  get=0x02D780F0  set=0x03777270
  oauth2token  get=0x03D4EB20
  oauth2code  get=0x03D4EB30
  isInterfaceDisabled  get=0x0115F4C0
  sessionToken  get=0x03D4EAD0
  serverCacheTime  get=0x03D6DAF0  set=0x03D6DB10
EVENTS:
  onReceiverProductlist  add=add_onReceiverProductlist  remove=remove_onReceiverProductlist
METHODS:
  RVA=0x039C3170  token=0x60000DB  System.Void CallbackInitSuc(System.String extConfigs)
  RVA=0x0887A988  token=0x60000DC  System.Void CallbackInitFail(System.String info)
  RVA=0x039C31F0  token=0x60000DD  System.Void CallbackLoginSuc(System.String extension)
  RVA=0x0887A9A8  token=0x60000DE  System.Void CallbackLoginFail(System.String info)
  RVA=0x0887A9C8  token=0x60000DF  System.Void CallbackLogout()
  RVA=0x0887AB14  token=0x60000E0  System.Void CallbackSwitchAccount()
  RVA=0x0887AA80  token=0x60000E1  System.Void CallbackPaySuc(System.String jsonData)
  RVA=0x0887A9EC  token=0x60000E2  System.Void CallbackPayFail(System.String failMsg)
  RVA=0x04273A44  token=0x60000E9  System.String PublicLoadExtraConfig()
  RVA=0x042770BC  token=0x60000EA  System.Void PublicSetGameVersion(System.String version)
  RVA=0x0887BD44  token=0x60000EB  U8.SDK.U8SDKInterface.ReceiverProductListResult getOnReceiverProductlist()
  RVA=-1  // generic def  token=0x60000EC  U8.SDK.SDKPromise<System.String> V2PublicInit(System.String env)
  RVA=0x03D4D850  token=0x60000ED  System.Void _MarkMockLogin(U8.SDK.U8MockLogin mockLogin)
  RVA=0x02E97B60  token=0x60000EE  System.Void _onLoginSuc(System.String uid, System.Boolean isNew)
  RVA=0x0887AFA4  token=0x60000EF  U8.SDK.SDKPromise<U8.SDK.U8ProductsResult> PublicGetProductListV2()
  RVA=0x0887AB60  token=0x60000F0  System.Void ClearAuthStatus()
  RVA=0x0887ABBC  token=0x60000F1  System.Void ClearLoginStatus()
  RVA=0x03777230  token=0x60000F2  System.Void _ConfirmAuthResult(U8.SDK.U8SDKInterface.AuthStatus result)
  RVA=0x0887B1A8  token=0x60000F3  U8.SDK.SDKPromise<System.Object> PublicLogout()
  RVA=0x0887B0C4  token=0x60000F4  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> PublicGetServerList()
  RVA=0x0887B490  token=0x60000F5  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> PubliceConfirmServer(System.String serverId)
  RVA=0x0887B248  token=0x60000F6  U8.SDK.SDKPromise<U8.SDK.U8PayResult> PublicPay(System.Int32 storeId, U8.SDK.U8OrderInfo orderInfo)
  RVA=0x0887BAC4  token=0x60000F7  System.Void _OnNativePayFulfilled(System.Int64 revenue)
  RVA=0x0887BBA0  token=0x60000F8  System.Boolean _TryGetProduct(System.Int32 storeId, U8.SDK.U8ProductInfo& productInfo)
  RVA=0x0887B844  token=0x60000F9  U8.SDK.U8PayParams _GeneratePayParams(U8.SDK.U8ProductInfo productInfo, U8.SDK.U8OrderInfo orderInfo)
  RVA=0x0887B9E0  token=0x60000FA  U8.SDK.SDKPromise<U8.SDK.U8PayResult> _NativePay(U8.SDK.U8PayParams payParams)
  RVA=-1  // generic def  token=0x60000FB  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  RVA=0x0887B0CC  token=0x60000FC  U8.SDK.SDKMeta PublicLoadSDKMeta()
  RVA=-1  // abstract  token=0x60000FD  System.String LoadExtraConfig()
  RVA=-1  // abstract  token=0x60000FE  System.Void V2Init(System.String env)
  RVA=-1  // abstract  token=0x60000FF  System.Void Login()
  RVA=-1  // abstract  token=0x6000100  System.Void LoginCustom(System.String customData)
  RVA=-1  // abstract  token=0x6000101  System.Boolean Logout()
  RVA=-1  // abstract  token=0x6000102  System.Boolean ShowAccountCenter()
  RVA=-1  // abstract  token=0x6000103  System.Void SubmitGameData(U8.SDK.U8ExtraGameData data)
  RVA=-1  // abstract  token=0x6000104  System.Void Pay(U8.SDK.U8PayParams data)
  RVA=-1  // abstract  token=0x6000105  System.Void SetData(System.Int32 type, System.String paramJson)
  RVA=-1  // abstract  token=0x6000106  System.String GetData(System.Int32 type, System.String paramJson)
  RVA=-1  // abstract  token=0x6000107  U8.SDK.SDKMeta LoadSDKMeta()
  RVA=-1  // abstract  token=0x6000108  System.Boolean IsNativePlugin()
  RVA=-1  // abstract  token=0x6000109  System.Void SetGameVersion(System.String version)
  RVA=0x02690B40  token=0x600010A  System.Collections.IEnumerator _NextFrameCoroutine(System.Action call)
  RVA=0x02690AB0  token=0x600010B  System.Void InvokeNextFrame(System.Action action)
  RVA=0x03D06B90  token=0x600010C  System.Void InvokeCoroutine(System.Collections.IEnumerator coroutine)
  RVA=0x02E985D0  token=0x600010D  System.String EncodeGameData(U8.SDK.U8ExtraGameData data)
  RVA=0x0887ABE8  token=0x600010E  System.String EncodePayParams(U8.SDK.U8PayParams data)
  RVA=0x02C36FB0  token=0x6000114  U8.SDK.SDKPromise<System.String> V2PublicLogin()
  RVA=0x02690560  token=0x6000115  U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> V2PublicAuth()
  RVA=0x0887B56C  token=0x6000116  U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> U1PublicCreateOrder(System.String productId, System.String signParams)
  RVA=0x0887B5EC  token=0x6000117  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> U1PublicGetServerList()
  RVA=0x0887B500  token=0x6000118  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> U1PublicConfirmServer(System.String serverId)
  RVA=0x0887B498  token=0x6000119  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> U1PublicConfirmOrder(System.String orderId, System.String extension)
  RVA=0x026905C0  token=0x600011A  U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> _DoMockAuthV2()
  RVA=0x02C37030  token=0x600011B  System.Collections.IEnumerator _LoginV2Coroutine(U8.SDK.SDKPromise<System.String> promise)
  RVA=0x0887BB80  token=0x600011C  System.Void _OnSessionTokenInvalid()
  RVA=0x0887B7D0  token=0x600011D  System.Collections.IEnumerator _AuthV2Coroutine(U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise)
  RVA=0x03A597D0  token=0x600011E  System.Void .ctor()
  RVA=0x03D2B9A0  token=0x600011F  System.Void .cctor()
  RVA=0x0887B648  token=0x6000120  System.Void <PublicLogout>b__65_0()
  RVA=0x0887B76C  token=0x6000121  System.Void <PublicLogout>b__65_1()
  RVA=0x0887B77C  token=0x6000122  System.Void <PublicLogout>b__65_2()
END_CLASS

CLASS: U8.SDK.SDKError
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x20
FIELDS:
  private           System.String                   <code>k__BackingField  // 0x10
  private           System.String                   <msg>k__BackingField  // 0x18
PROPERTIES:
  code  set=0x042715A0
  msg  set=0x0558FF08
METHODS:
  RVA=0x08871074  token=0x6000152  System.Void .ctor(System.String content)
END_CLASS

CLASS: U8.SDK.U8MockLogin
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x20
FIELDS:
  public    static readonly U8.SDK.U8MockLogin              EMPTY  // static @ 0x0
  public            System.String                   uid  // 0x10
  public            System.String                   token  // 0x18
METHODS:
  RVA=0x042710A8  token=0x6000153  System.Boolean IsEmpty()
END_CLASS

CLASS: U8.SDK.U8ProductInfo
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x48
FIELDS:
  public            System.Int32                    store_id  // 0x10
  public            System.String                   product_id  // 0x18
  public            System.String                   desc  // 0x20
  public            System.String                   name  // 0x28
  public            System.Int64                    price  // 0x30
  public            System.String                   channel_product_id  // 0x38
  public            System.String                   display_price  // 0x40
METHODS:
  RVA=0x0350B670  token=0x6000154  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ProductsResult
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x20
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>u8Products  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000155  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ServerInfo
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x50
FIELDS:
  public            System.String                   serverId  // 0x10
  public            System.String                   serverName  // 0x18
  public            System.String                   serverDomain  // 0x20
  public            System.Boolean                  defaultChoose  // 0x28
  public            System.String                   roleId  // 0x30
  public            System.String                   nickName  // 0x38
  public            System.Int64                    level  // 0x40
  public            System.String                   extension  // 0x48
METHODS:
  RVA=0x0350B670  token=0x6000156  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ServerErrorInfo
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x18
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Int32                    errorCode  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000157  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8OrderInfo
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x40
FIELDS:
  public            System.String                   orderId  // 0x10
  public            System.String                   channelProductCode  // 0x18
  public            System.String                   productName  // 0x20
  public            System.String                   productDesc  // 0x28
  public            System.Int64                    amount  // 0x30
  public            System.String                   extension  // 0x38
METHODS:
  RVA=0x0350B670  token=0x6000158  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8PayParams
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x98
FIELDS:
  private           System.String                   <productId>k__BackingField  // 0x10
  private           System.String                   <productName>k__BackingField  // 0x18
  private           System.String                   <productDesc>k__BackingField  // 0x20
  private           System.Int64                    <price>k__BackingField  // 0x28
  private           System.Int32                    <buyNum>k__BackingField  // 0x30
  private           System.Int32                    <coinNum>k__BackingField  // 0x34
  private           System.String                   <serverId>k__BackingField  // 0x38
  private           System.String                   <serverName>k__BackingField  // 0x40
  private           System.String                   <roleId>k__BackingField  // 0x48
  private           System.String                   <roleName>k__BackingField  // 0x50
  private           System.Int32                    <roleLevel>k__BackingField  // 0x58
  private           System.String                   <vip>k__BackingField  // 0x60
  private           System.String                   <orderID>k__BackingField  // 0x68
  private           System.String                   <worldID>k__BackingField  // 0x70
  private           System.String                   <token>k__BackingField  // 0x78
  private           System.String                   <appKey>k__BackingField  // 0x80
  private           System.String                   <extension>k__BackingField  // 0x88
  private           System.String                   <addition>k__BackingField  // 0x90
PROPERTIES:
  productId  get=0x020B7B20  set=0x0426FEE0
  productName  get=0x01041090  set=0x022C3A90
  productDesc  get=0x03D4EB40  set=0x04271930
  price  get=0x03D4EAC0  set=0x03D4ED70
  buyNum  get=0x03D4ED20  set=0x03D4EE10
  coinNum  get=0x03D4EE00
  serverId  get=0x03D4E2A0
  serverName  get=0x03D4E2B0
  roleId  get=0x03D4EA70
  roleName  get=0x03D4EAF0
  roleLevel  get=0x03D4EF00
  vip  get=0x03D4EB00
  orderID  get=0x03D4EAB0  set=0x038C5570
  worldID  get=0x03D4EB30
  token  get=0x03D4EB20  set=0x051DFCA4
  appKey  get=0x03D4EAE0  set=0x051DFC94
  extension  get=0x03D4EA60  set=0x04274DA0
  addition  get=0x03D4EA90  set=0x051DFCB4
METHODS:
  RVA=0x0350B670  token=0x6000175  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ExtraGameData
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x78
FIELDS:
  private           System.Int32                    <dataType>k__BackingField  // 0x10
  private           System.String                   <uid>k__BackingField  // 0x18
  private           System.String                   <roleID>k__BackingField  // 0x20
  private           System.String                   <roleName>k__BackingField  // 0x28
  private           System.String                   <roleLevel>k__BackingField  // 0x30
  private           System.Int32                    <serverID>k__BackingField  // 0x38
  private           System.String                   <serverName>k__BackingField  // 0x40
  private           System.String                   <channel>k__BackingField  // 0x48
  private           System.String                   <subChannel>k__BackingField  // 0x50
  private           System.Boolean                  <isNewUser>k__BackingField  // 0x58
  private           System.Int64                    <revenue>k__BackingField  // 0x60
  private           System.String                   <customEventName>k__BackingField  // 0x68
  private           System.String                   <customEventParams>k__BackingField  // 0x70
PROPERTIES:
  dataType  get=0x03D4E340  set=0x010410F0
  uid  get=0x01041090  set=0x022C3A90
  roleID  get=0x03D4EB40  set=0x04271930
  roleName  get=0x03D4EAC0  set=0x02C92F10
  roleLevel  get=0x01003830
  serverID  get=0x03D4EC30  set=0x03D4ECB0
  serverName  get=0x03D4E2B0  set=0x03CB2D80
  channel  get=0x03D4EA70  set=0x02692290
  subChannel  get=0x03D4EAF0  set=0x02C926C0
  isNewUser  get=0x03D4F7E0  set=0x03D4F7F0
  revenue  get=0x03D4EB00  set=0x03D4EE20
  customEventName  get=0x03D4EAB0  set=0x038C5570
  customEventParams  get=0x03D4EB30
METHODS:
  RVA=0x0350B670  token=0x600018E  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8LoginResult
TYPE:  sealed struct
TOKEN: 0x2000049
SIZE:  0x48
FIELDS:
  public    static readonly U8.SDK.U8LoginResult            EMPTY  // static @ 0x0
  public            System.Int32                    result  // 0x10
  public            System.String                   uid  // 0x18
  public            System.String                   channelUid  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   extension  // 0x30
  public            System.Boolean                  isGuest  // 0x38
  public            System.Boolean                  isNew  // 0x39
  public            System.String                   error  // 0x40
METHODS:
  RVA=0x088798E0  token=0x600018F  System.String ToString()
END_CLASS

CLASS: U8.SDK.U8ProductError
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x18
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Int32                    errorCode  // 0x14
METHODS:
END_CLASS

CLASS: U8.SDK.PayResultStatus
TYPE:  sealed struct
TOKEN: 0x200004B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.PayResultStatus          SUCCEED  // const
  public    static  U8.SDK.PayResultStatus          PENDING  // const
METHODS:
END_CLASS

CLASS: U8.SDK.PayFailStatus
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.PayFailStatus            UNKNOWN  // const
  public    static  U8.SDK.PayFailStatus            CANCELED  // const
  public    static  U8.SDK.PayFailStatus            ERROR  // const
  public    static  U8.SDK.PayFailStatus            HALT  // const
METHODS:
END_CLASS

CLASS: U8.SDK.U8ConfirmServerResult
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x20
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000190  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ConfirmOrderStatus
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.U8ConfirmOrderStatus     NONE  // const
  public    static  U8.SDK.U8ConfirmOrderStatus     INTERNAL_ERROR  // const
  public    static  U8.SDK.U8ConfirmOrderStatus     TIMEOUT  // const
  public    static  U8.SDK.U8ConfirmOrderStatus     INVALID_ORDER  // const
  public    static  U8.SDK.U8ConfirmOrderStatus     SUCCEED  // const
METHODS:
END_CLASS

CLASS: U8.SDK.U8ConfirmOrderResult
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x20
FIELDS:
  public            U8.SDK.U8ConfirmOrderStatus     status  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000191  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8PayFailMsg
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x28
FIELDS:
  public    static  U8.SDK.U8PayFailMsg             EMPTY  // static @ 0x0
  public            U8.SDK.PayFailStatus            status  // 0x10
  public            System.String                   message  // 0x18
  public            System.String                   extension  // 0x20
METHODS:
  RVA=0x08879B28  token=0x6000192  U8.SDK.U8PayFailMsg FromJson(System.String jsonStr)
  RVA=0x08879E28  token=0x6000193  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8PayResult
TYPE:  sealed struct
TOKEN: 0x2000051
SIZE:  0x28
FIELDS:
  public    static readonly U8.SDK.U8PayResult              EMPTY  // static @ 0x0
  public            U8.SDK.PayResultStatus          status  // 0x10
  public            System.String                   outTradeNo  // 0x18
  public            System.String                   extension  // 0x20
METHODS:
  RVA=0x08879E8C  token=0x6000194  U8.SDK.U8PayResult FromJson(System.String jsonData)
  RVA=0x0887A10C  token=0x6000195  System.String ToString()
  RVA=0x0887A1F8  token=0x6000196  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKInterfaceWIN
TYPE:  class
TOKEN: 0x2000052
SIZE:  0xD8
EXTENDS: U8.SDK.U8SDKInterface
FIELDS:
  private           System.Int32                    actionIndex  // 0xd0
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Action<System.String>>dictAction  // static @ 0x0
METHODS:
  RVA=0x02D787D0  token=0x6000197  System.Void .ctor()
  RVA=0x088736A4  token=0x6000198  System.Void Finalize()
  RVA=0x02E99B30  token=0x6000199  System.Int32 AddAction(System.Action<System.String> action)
  RVA=0x026906B0  token=0x600019A  System.Void DataActionCallback(System.Int32 index, System.String paramValue)
  RVA=0x088734B8  token=0x600019B  System.Void ASyncDataActionCallback(System.Int32 index, System.String paramValue)
  RVA=0x02690A30  token=0x600019C  System.Void U8SDKSendMessage(System.String methodName, System.String paramValue)
  RVA=0x022C71F0  token=0x600019D  System.Void HGU8SDKInitLibrary(System.String windowText, System.Int64 windowHandle)
  RVA=0x022C72A0  token=0x600019E  System.Int32 HGU8SDKSetUserDataPath(System.String path)
  RVA=0x08873A30  token=0x600019F  System.Void HGU8SDKUnInitLibrary()
  RVA=0x022C7350  token=0x60001A0  System.Void HGU8SDKInitDatacallback(U8.SDK.SDKInterfaceWIN.DataCallback Callback, U8.SDK.SDKInterfaceWIN.DataCallback asyncCallback)
  RVA=0x022C73F0  token=0x60001A1  System.Void HGU8SDKInitSendMessage(U8.SDK.SDKInterfaceWIN.U8SDKSendMessageCallback callback)
  RVA=0x022C7480  token=0x60001A2  System.Void HGU8SDKV2Init(System.String env)
  RVA=0x08873870  token=0x60001A3  System.Void HGU8SDKLogin()
  RVA=0x088737E8  token=0x60001A4  System.Void HGU8SDKLoginCustom(System.String json)
  RVA=0x088738D8  token=0x60001A5  System.Int32 HGU8SDKLogout()
  RVA=0x088739C8  token=0x60001A6  System.Int32 HGU8SDKShowAccountCenter()
  RVA=0x08873940  token=0x60001A7  System.Void HGU8SDKPay(System.String json)
  RVA=0x02E988E0  token=0x60001A8  System.Void HGU8SDKSubmitGameData(System.String json)
  RVA=0x08873770  token=0x60001A9  System.Void HGU8SDKGetSDKMeta(System.Int32 index)
  RVA=0x02E5B410  token=0x60001AA  System.Void HGU8SDKSetData(System.Int32 code, System.String paramJson)
  RVA=0x02E99D40  token=0x60001AB  System.Void HGU8SDKGetData(System.Int32 code, System.String paramJson, System.Int32 index)
  RVA=0x022C7520  token=0x60001AC  System.Int32 HGU8SDKIsNativePlugin()
  RVA=0x02E99DB0  token=0x60001AD  System.Void HGU8SDKLoadExtraConfig(System.Int32 index)
  RVA=0x03C94670  token=0x60001AE  System.Void HGU8SDKSetGameVersion(System.String version)
  RVA=0x02E99620  token=0x60001AF  System.String LoadExtraConfig()
  RVA=0x038E8A60  token=0x60001B0  System.Void V2Init(System.String env)
  RVA=0x08873C14  token=0x60001B1  System.Void Login()
  RVA=0x08873C54  token=0x60001B2  System.Boolean Logout()
  RVA=0x08873BC8  token=0x60001B3  System.Void LoginCustom(System.String customData)
  RVA=0x02E98560  token=0x60001B4  System.Void SubmitGameData(U8.SDK.U8ExtraGameData data)
  RVA=0x02E5B360  token=0x60001B5  System.Void SetData(System.Int32 type, System.String paramJson)
  RVA=0x02E999F0  token=0x60001B6  System.String GetData(System.Int32 type, System.String paramJson)
  RVA=0x08873CFC  token=0x60001B7  System.Boolean ShowAccountCenter()
  RVA=0x08873C9C  token=0x60001B8  System.Void Pay(U8.SDK.U8PayParams data)
  RVA=0x08873A98  token=0x60001B9  U8.SDK.SDKMeta LoadSDKMeta()
  RVA=0x03D2A480  token=0x60001BA  System.Boolean IsNativePlugin()
  RVA=0x03C94620  token=0x60001BB  System.Void SetGameVersion(System.String version)
  RVA=0x03CE30D0  token=0x60001BC  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.ImageSaver
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08870258  token=0x60001CA  System.Threading.Tasks.Task SaveImage(System.String paramJson)
  RVA=0x08870A40  token=0x60001CB  System.Boolean ValidateInput(System.String paramJson, U8.SDK.ImageSaver.ImageShareInfo& shareInfo)
  RVA=0x0886FF08  token=0x60001CC  System.String NormalizeSourcePath(System.String imgPath)
  RVA=0x0887007C  token=0x60001CD  U8.SDK.ImageSaver.FolderType ParseFolderType(System.Int32 folderType)
  RVA=0x0886F5D4  token=0x60001CE  System.String BuildTargetPath(System.String sourcePath, System.String relativePath, System.String baseFolder)
  RVA=0x0886FB28  token=0x60001CF  System.Boolean IsDirectoryPath(System.String path)
  RVA=0x0886F4A8  token=0x60001D0  System.String BuildPathForDirectory(System.String sourcePath, System.String relativeDirPath, System.String baseFolder)
  RVA=0x08870138  token=0x60001D1  System.Threading.Tasks.Task<System.Boolean> SaveImageToPathAsync(System.String sourcePath, System.String targetPath, System.String imgFolder)
  RVA=0x0886FBDC  token=0x60001D2  System.Boolean IsSamePath(System.String sourcePath, System.String targetPath)
  RVA=0x08870B1C  token=0x60001D3  System.Boolean ValidateMove(System.String sourcePath, System.String targetPath, System.String rootDir, System.String& error)
  RVA=0x0886F700  token=0x60001D4  System.Void EnsureDirectoryExists(System.String filePath)
  RVA=0x0886FCB0  token=0x60001D5  System.Boolean MoveFile(System.String sourcePath, System.String targetPath)
  RVA=0x0886F914  token=0x60001D6  System.String GetImageSaveFolder(U8.SDK.ImageSaver.FolderType folderType)
  RVA=0x0886F9C8  token=0x60001D7  System.String GetWindowsPicturePath()
  RVA=0x0886F768  token=0x60001D8  System.String GetGameInstalledFolder()
  RVA=0x0887094C  token=0x60001D9  System.Void SendSuccessResponse(System.String targetPath)
  RVA=0x08870328  token=0x60001DA  System.Void SendErrorResponse(U8.SDK.ImageSaver.ErrorCode errorCode)
  RVA=0x088704D8  token=0x60001DB  System.Void SendResponse(U8.SDK.ImageSaver.CallbackResult code, System.Collections.Generic.Dictionary<System.String,System.Object> extraMsg)
  RVA=0x08870400  token=0x60001DC  System.Void SendMessageInMain(System.String methodName, System.String paramValue)
  RVA=0x0350B670  token=0x60001DD  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8MainThreadDispatcher
TYPE:  class
TOKEN: 0x2000062
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentQueue<System.Action>_queue  // static @ 0x0
  private   static  U8.SDK.U8MainThreadDispatcher   _instance  // static @ 0x8
  private   static  System.Int32                    _initialized  // static @ 0x10
METHODS:
  RVA=0x03B392E0  token=0x60001E7  System.Void Initialize()
  RVA=0x08879AB4  token=0x60001E8  System.Void RunOnMainThread(System.Action action)
  RVA=0x02339FE0  token=0x60001E9  System.Void Update()
  RVA=0x0426FE60  token=0x60001EA  System.Void .ctor()
  RVA=0x03A1DEE0  token=0x60001EB  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKMeta
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x40
FIELDS:
  public            System.String                   appID  // 0x10
  public            System.String                   appKey  // 0x18
  public            System.String                   channel  // 0x20
  public            System.String                   worldId  // 0x28
  public            System.String                   extension  // 0x30
  public            System.String                   appCode  // 0x38
METHODS:
  RVA=0x0350B670  token=0x60001EC  System.Void .ctor()
  RVA=0x08873EA8  token=0x60001ED  System.Void .ctor(System.String jsonData)
  RVA=0x08873D44  token=0x60001EE  System.String ToString()
END_CLASS

CLASS: U8.SDK.ISDKPromise
TYPE:  interface
TOKEN: 0x2000064
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001EF  System.Void Fulfill(System.Object param)
  RVA=-1  // abstract  token=0x60001F0  System.Void Reject(System.Object reason)
END_CLASS

CLASS: U8.SDK.SDKPromise`1
TYPE:  class
TOKEN: 0x2000065
IMPLEMENTS: U8.SDK.ISDKPromise
FIELDS:
  public            System.Action<Param>            onFulfilled  // 0x0
  public            System.Action<System.Object>    onRejected  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001F1  System.Void Fulfill(System.Object param)
  RVA=-1  // not resolved  token=0x60001F2  System.Void Reject(System.Object reason)
  RVA=-1  // not resolved  token=0x60001F3  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseWithResult`1
TYPE:  class
TOKEN: 0x2000066
EXTENDS: U8.SDK.SDKPromise`1
FIELDS:
  private           Param                           <result>k__BackingField  // 0x0
  private           System.Object                   <rejectInfo>k__BackingField  // 0x0
PROPERTIES:
  result  get=-1  // not resolved  set=-1  // not resolved
  rejectInfo  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60001F8  System.Void Fulfill(System.Object param)
  RVA=-1  // not resolved  token=0x60001F9  System.Void Reject(System.Object reason)
  RVA=-1  // not resolved  token=0x60001FA  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseEnumerator`1
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  private           U8.SDK.SDKPromiseEnumerator.State<T>m_state  // 0x0
  private           T                               <result>k__BackingField  // 0x0
  private           System.Object                   <reject>k__BackingField  // 0x0
PROPERTIES:
  isFulfilled  get=-1  // not resolved
  result  get=-1  // not resolved  set=-1  // not resolved
  reject  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000200  System.Collections.IEnumerator Yield()
  RVA=-1  // not resolved  token=0x6000201  System.Void .ctor(U8.SDK.SDKPromise<T> promise)
  RVA=-1  // not resolved  token=0x6000202  System.Void _OnFulfilled(T result)
  RVA=-1  // not resolved  token=0x6000203  System.Void _OnRejected(System.Object rejectInfo)
END_CLASS

CLASS: U8.SDK.SDKPromiseWrapper
TYPE:  class
TOKEN: 0x200006A
SIZE:  0x18
FIELDS:
  private           U8.SDK.ISDKPromise              m_promise  // 0x10
METHODS:
  RVA=-1  // generic def  token=0x600020A  T EnsurePromise()
  RVA=0x039C3210  token=0x600020B  System.Void Fulfill(System.Object param)
  RVA=0x088741EC  token=0x600020C  System.Void Reject(System.Object reason)
  RVA=0x035ACAA0  token=0x600020D  System.Void _Clear()
  RVA=0x0350B670  token=0x600020E  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseExtensions
TYPE:  static class
TOKEN: 0x200006B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088741D4  token=0x600020F  System.Void RejectWithString(U8.SDK.ISDKPromise promise, System.String errorInfo)
  RVA=-1  // generic def  token=0x6000210  System.Void FulfillWithType(U8.SDK.SDKPromise<T> promise, T param)
END_CLASS

CLASS: U8.SDK.U8SDKTickEvent
TYPE:  class
TOKEN: 0x200006C
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x031B4EF0  token=0x6000211  System.Void Update()
  RVA=0x031B4F00  token=0x6000212  System.Void HGU8SDKTickEvent()
  RVA=0x0426FE60  token=0x6000213  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8TickEventManager
TYPE:  class
TOKEN: 0x200006D
SIZE:  0x20
FIELDS:
  private           UnityEngine.GameObject          tickGameObject  // 0x10
  private           U8.SDK.U8SDKTickEvent           tickEvent  // 0x18
  private   static  U8.SDK.U8TickEventManager       instanceManager  // static @ 0x0
  private   static readonly System.Object                   lockObject  // static @ 0x8
PROPERTIES:
  InstanceManager  get=0x038E8AF0
METHODS:
  RVA=0x038E8BD0  token=0x6000215  System.Void InitTickEvent()
  RVA=0x0887BE68  token=0x6000216  System.Void UnInitTickEvent()
  RVA=0x0350B670  token=0x6000217  System.Void .ctor()
  RVA=0x03CFDD60  token=0x6000218  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8LoginV2Result
TYPE:  class
TOKEN: 0x200006E
SIZE:  0x28
FIELDS:
  public            System.String                   token  // 0x10
  public            System.String                   uid  // 0x18
  public            System.Boolean                  isNew  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000219  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8AuthV2Result
TYPE:  class
TOKEN: 0x200006F
SIZE:  0x28
FIELDS:
  public            System.String                   uid  // 0x10
  public            System.String                   oauth2Code  // 0x18
  public            System.String                   oauth2Token  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600021A  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8GrantResult
TYPE:  class
TOKEN: 0x2000070
SIZE:  0x28
FIELDS:
  public            System.String                   uid  // 0x10
  public            System.String                   code  // 0x18
  public            System.String                   token  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600021B  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8SDKCallback
TYPE:  class
TOKEN: 0x2000071
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  U8.SDK.U8SDKCallback            m_instance  // static @ 0x0
  private   static  System.Object                   m_lock  // static @ 0x8
METHODS:
  RVA=0x02690BA0  token=0x600021C  U8.SDK.U8SDKCallback InitCallback()
  RVA=0x039C3110  token=0x600021D  System.Void OnInitSuc(System.String extConfigs)
  RVA=0x0887A6DC  token=0x600021E  System.Void OnInitFail(System.String info)
  RVA=0x039C3190  token=0x600021F  System.Void OnLoginSuc(System.String extension)
  RVA=0x0887A734  token=0x6000220  System.Void OnLoginFail(System.String info)
  RVA=0x0887A78C  token=0x6000221  System.Void OnLogout(System.String info)
  RVA=0x0887A8F8  token=0x6000222  System.Void OnSwitchAccount()
  RVA=0x0887A830  token=0x6000223  System.Void OnPaySuc(System.String jsonData)
  RVA=0x0887A7D8  token=0x6000224  System.Void OnPayFail(System.String failMsg)
  RVA=0x0887A888  token=0x6000225  System.Void OnSDKError(System.String jsonData)
  RVA=0x02692D60  token=0x6000226  System.Void OnExtraInfo(System.String jsonData)
  RVA=0x0887A944  token=0x6000227  System.Collections.IEnumerator _onLogoutNextFrameCoroutine()
  RVA=-1  // generic def  token=0x6000228  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  RVA=0x0426FE60  token=0x6000229  System.Void .ctor()
  RVA=0x03CFDDD0  token=0x600022A  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.MiniJSON.Json
TYPE:  static class
TOKEN: 0x2000073
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02694A20  token=0x6000231  System.Object Deserialize(System.String json)
  RVA=0x042743D8  token=0x6000232  System.String Serialize(System.Object obj)
END_CLASS

