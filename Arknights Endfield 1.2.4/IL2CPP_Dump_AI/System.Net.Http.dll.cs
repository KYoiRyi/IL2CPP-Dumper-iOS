// ========================================================
// Dumped by @desirepro
// Assembly: System.Net.Http.dll
// Classes:  84
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

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.HttpClientHandler.<>c<>9  // static @ 0x0
  public    static  System.Net.Security.LocalCertificateSelectionCallback<>9__23_1  // static @ 0x8
METHODS:
  RVA=0x09848644  token=0x600000C  System.Void .cctor()
  RVA=0x0350B670  token=0x600000D  System.Void .ctor()
  RVA=0x0984863C  token=0x600000E  System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_1(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.MonoWebRequestHandler.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Boolean><>9__95_0  // static @ 0x8
  public    static  System.Func<System.String,System.Boolean><>9__96_0  // static @ 0x10
  public    static  System.Action<System.Object>    <>9__99_0  // static @ 0x18
METHODS:
  RVA=0x098487D4  token=0x6000021  System.Void .cctor()
  RVA=0x0350B670  token=0x6000022  System.Void .ctor()
  RVA=0x09848374  token=0x6000023  System.Boolean <GetConnectionKeepAlive>b__95_0(System.String l)
  RVA=0x09848338  token=0x6000024  System.Boolean <CreateWebRequest>b__96_0(System.String l)
  RVA=0x098483B8  token=0x6000025  System.Void <SendAsync>b__99_0(System.Object l)
END_CLASS

CLASS: <SendAsync>d__99
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0xB8
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Http.HttpResponseMessage><>t__builder  // 0x18
  public            System.Net.Http.MonoWebRequestHandler<>4__this  // 0x30
  public            System.Threading.CancellationTokencancellationToken  // 0x38
  public            System.Net.Http.HttpRequestMessagerequest  // 0x40
  private           System.Net.HttpWebRequest       <wrequest>5__2  // 0x48
  private           System.Net.HttpWebResponse      <wresponse>5__3  // 0x50
  private           System.Threading.CancellationTokenRegistration<>7__wrap3  // 0x58
  private           System.Net.Http.HttpContent     <content>5__5  // 0x70
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<>u__1  // 0x78
  private           System.IO.Stream                <stream>5__6  // 0x88
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream><>u__2  // 0x90
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebResponse><>u__3  // 0xa0
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage><>u__4  // 0xb0
METHODS:
  RVA=0x09844C84  token=0x6000026  System.Void MoveNext()
  RVA=0x09846C98  token=0x6000027  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <SendAsyncWorker>d__47
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x80
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Http.HttpResponseMessage><>t__builder  // 0x18
  public            System.Net.Http.HttpClient      <>4__this  // 0x30
  public            System.Threading.CancellationTokencancellationToken  // 0x38
  public            System.Net.Http.HttpRequestMessagerequest  // 0x40
  public            System.Net.Http.HttpCompletionOptioncompletionOption  // 0x48
  private           System.Threading.CancellationTokenSource<lcts>5__2  // 0x50
  private           System.Net.Http.HttpResponseMessage<response>5__3  // 0x58
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage><>u__1  // 0x60
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<>u__2  // 0x70
METHODS:
  RVA=0x09846CF8  token=0x600003A  System.Void MoveNext()
  RVA=0x09847428  token=0x600003B  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: FixedMemoryStream
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x58
EXTENDS: System.IO.MemoryStream
FIELDS:
  private   readonly System.Int64                    maxSize  // 0x50
METHODS:
  RVA=0x09835BC8  token=0x600004C  System.Void .ctor(System.Int64 maxSize)
  RVA=0x09835A74  token=0x600004D  System.Void CheckOverflow(System.Int32 count)
  RVA=0x09835B34  token=0x600004E  System.Void WriteByte(System.Byte value)
  RVA=0x09835B6C  token=0x600004F  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: <LoadIntoBufferAsync>d__17
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x50
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            System.Net.Http.HttpContent     <>4__this  // 0x30
  public            System.Int64                    maxBufferSize  // 0x38
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<>u__1  // 0x40
METHODS:
  RVA=0x098445EC  token=0x6000050  System.Void MoveNext()
  RVA=0x09844864  token=0x6000051  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <ReadAsStringAsync>d__20
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x48
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.String><>t__builder  // 0x18
  public            System.Net.Http.HttpContent     <>4__this  // 0x30
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<>u__1  // 0x38
METHODS:
  RVA=0x098448C0  token=0x6000052  System.Void MoveNext()
  RVA=0x09844C24  token=0x6000053  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <SerializeToStreamAsync>d__8
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x70
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            System.Net.Http.MultipartContent<>4__this  // 0x30
  public            System.IO.Stream                stream  // 0x38
  public            System.Net.TransportContext     context  // 0x40
  private           System.Text.StringBuilder       <sb>5__2  // 0x48
  private           System.Int32                    <i>5__3  // 0x50
  private           System.Net.Http.HttpContent     <c>5__4  // 0x58
  private           System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<>u__1  // 0x60
METHODS:
  RVA=0x09847488  token=0x600008D  System.Void MoveNext()
  RVA=0x098482DC  token=0x600008E  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: HeaderTypeInfo`2
TYPE:  class
TOKEN: 0x2000029
EXTENDS: System.Net.Http.Headers.HeaderInfo
FIELDS:
  private   readonly System.Net.Http.Headers.TryParseDelegate<T>parser  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000110  System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind)
  RVA=-1  // not resolved  token=0x6000111  System.Void AddToCollection(System.Object collection, System.Object value)
  RVA=-1  // not resolved  token=0x6000112  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  RVA=-1  // not resolved  token=0x6000113  System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection)
  RVA=-1  // not resolved  token=0x6000114  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: CollectionHeaderTypeInfo`2
TYPE:  class
TOKEN: 0x200002A
EXTENDS: HeaderTypeInfo`2
FIELDS:
  private   readonly System.Int32                    minimalCount  // 0x0
  private   readonly System.String                   separator  // 0x0
  private   readonly System.Net.Http.Headers.TryParseListDelegate<T>parser  // 0x0
PROPERTIES:
  Separator  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000115  System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator)
  RVA=-1  // not resolved  token=0x6000117  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: HeaderBucket
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x28
FIELDS:
  public            System.Object                   Parsed  // 0x10
  private           System.Collections.Generic.List<System.String>values  // 0x18
  public    readonly System.Func<System.Object,System.String>CustomToString  // 0x20
PROPERTIES:
  HasStringValues  get=0x09835C40
  Values  get=0x09835C84  set=0x022C3A90
METHODS:
  RVA=0x02CC1260  token=0x6000142  System.Void .ctor(System.Object parsed, System.Func<System.Object,System.String> converter)
  RVA=0x09835BF4  token=0x6000146  System.String ParsedToString()
END_CLASS

CLASS: <GetEnumerator>d__19
TYPE:  sealed class
TOKEN: 0x2000030
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.IDisposable System.Collections.IEnumerator
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>><>2__current  // 0x18
  public            System.Net.Http.Headers.HttpHeaders<>4__this  // 0x28
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current  get=0x03D51D80
  System.Collections.IEnumerator.Current  get=0x098444F0
METHODS:
  RVA=0x010410F0  token=0x6000147  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x09844538  token=0x6000148  System.Void System.IDisposable.Dispose()
  RVA=0x09844108  token=0x6000149  System.Boolean MoveNext()
  RVA=0x098445B0  token=0x600014A  System.Void <>m__Finally1()
  RVA=0x098444A4  token=0x600014C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000032
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.Headers.HttpRequestHeaders.<>c<>9  // static @ 0x0
  public    static  System.Predicate<System.String> <>9__19_0  // static @ 0x8
  public    static  System.Predicate<System.Net.Http.Headers.TransferCodingHeaderValue><>9__29_0  // static @ 0x10
  public    static  System.Predicate<System.Net.Http.Headers.TransferCodingHeaderValue><>9__71_0  // static @ 0x18
METHODS:
  RVA=0x098486A8  token=0x6000158  System.Void .cctor()
  RVA=0x0350B670  token=0x6000159  System.Void .ctor()
  RVA=0x09848558  token=0x600015A  System.Boolean <get_ConnectionClose>b__19_0(System.String l)
  RVA=0x0984859C  token=0x600015B  System.Boolean <get_ExpectContinue>b__29_0(System.Net.Http.Headers.TransferCodingHeaderValue l)
  RVA=0x098485EC  token=0x600015C  System.Boolean <get_TransferEncodingChunked>b__71_0(System.Net.Http.Headers.TransferCodingHeaderValue l)
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.Headers.Token.TypeError  // const
  public    static  System.Net.Http.Headers.Token.TypeEnd  // const
  public    static  System.Net.Http.Headers.Token.TypeToken  // const
  public    static  System.Net.Http.Headers.Token.TypeQuotedString  // const
  public    static  System.Net.Http.Headers.Token.TypeSeparatorEqual  // const
  public    static  System.Net.Http.Headers.Token.TypeSeparatorSemicolon  // const
  public    static  System.Net.Http.Headers.Token.TypeSeparatorSlash  // const
  public    static  System.Net.Http.Headers.Token.TypeSeparatorDash  // const
  public    static  System.Net.Http.Headers.Token.TypeSeparatorComma  // const
  public    static  System.Net.Http.Headers.Token.TypeOpenParens  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000038
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.Headers.MediaTypeHeaderValue.<>c<>9  // static @ 0x0
  public    static  System.Predicate<System.Net.Http.Headers.NameValueHeaderValue><>9__6_0  // static @ 0x8
METHODS:
  RVA=0x09848770  token=0x6000189  System.Void .cctor()
  RVA=0x0350B670  token=0x600018A  System.Void .ctor()
  RVA=0x09848508  token=0x600018B  System.Boolean <get_CharSet>b__6_0(System.Net.Http.Headers.NameValueHeaderValue l)
END_CLASS

CLASS: Token
TYPE:  static class
TOKEN: 0x200003D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09843770  token=0x60001A7  System.Void Check(System.String s)
  RVA=0x098438EC  token=0x60001A8  System.Boolean TryCheck(System.String s)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.Headers.Parser.DateTime.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09848838  token=0x60001AB  System.Void .cctor()
  RVA=0x0350B670  token=0x60001AC  System.Void .ctor()
  RVA=0x09848418  token=0x60001AD  System.String <.cctor>b__2_0(System.Object l)
END_CLASS

CLASS: DateTime
TYPE:  static class
TOKEN: 0x200003E
SIZE:  0x10
FIELDS:
  public    static readonly System.Func<System.Object,System.String>ToString  // static @ 0x0
METHODS:
  RVA=0x098352EC  token=0x60001A9  System.Boolean TryParse(System.String input, System.DateTimeOffset& result)
  RVA=0x09835348  token=0x60001AA  System.Void .cctor()
END_CLASS

CLASS: EmailAddress
TYPE:  static class
TOKEN: 0x2000040
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0983540C  token=0x60001AE  System.Boolean TryParse(System.String input, System.String& result)
END_CLASS

CLASS: Host
TYPE:  static class
TOKEN: 0x2000041
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09835DB4  token=0x60001AF  System.Boolean TryParse(System.String input, System.String& result)
END_CLASS

CLASS: Int
TYPE:  static class
TOKEN: 0x2000042
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0983BC88  token=0x60001B0  System.Boolean TryParse(System.String input, System.Int32& result)
END_CLASS

CLASS: Long
TYPE:  static class
TOKEN: 0x2000043
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0983C9C4  token=0x60001B1  System.Boolean TryParse(System.String input, System.Int64& result)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000045
SIZE:  0x10
FIELDS:
  public    static readonly System.Net.Http.Headers.Parser.MD5.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x0984870C  token=0x60001B4  System.Void .cctor()
  RVA=0x0350B670  token=0x60001B5  System.Void .ctor()
  RVA=0x098484AC  token=0x60001B6  System.String <.cctor>b__2_0(System.Object l)
END_CLASS

CLASS: MD5
TYPE:  static class
TOKEN: 0x2000044
SIZE:  0x10
FIELDS:
  public    static readonly System.Func<System.Object,System.String>ToString  // static @ 0x0
METHODS:
  RVA=0x0983CA24  token=0x60001B2  System.Boolean TryParse(System.String input, System.Byte[]& result)
  RVA=0x0983CB08  token=0x60001B3  System.Void .cctor()
END_CLASS

CLASS: TimeSpanSeconds
TYPE:  static class
TOKEN: 0x2000046
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x098436DC  token=0x60001B7  System.Boolean TryParse(System.String input, System.TimeSpan& result)
END_CLASS

CLASS: Uri
TYPE:  static class
TOKEN: 0x2000047
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0984889C  token=0x60001B8  System.Boolean TryParse(System.String input, System.Uri& result)
END_CLASS

CLASS: __StaticArrayInitTypeSize=127
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x8F
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1271D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729  // static @ 0x0
METHODS:
  RVA=0x056516CC  token=0x600022F  System.UInt32 ComputeStringHash(System.String s)
END_CLASS

CLASS: System.Net.Http.HttpClientHandler
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x20
EXTENDS: System.Net.Http.HttpMessageHandler
FIELDS:
  private   readonly System.Net.Http.IMonoHttpClientHandler_delegatingHandler  // 0x10
  private           System.Net.Http.ClientCertificateOption_clientCertificateOptions  // 0x18
PROPERTIES:
  ClientCertificateOptions  get=0x020D1AC0  set=0x098361FC
  ClientCertificates  get=0x098360CC
METHODS:
  RVA=0x09835E50  token=0x6000001  System.Net.Http.IMonoHttpClientHandler CreateDefaultHandler()
  RVA=0x098360A8  token=0x6000002  System.Void .ctor()
  RVA=0x09836080  token=0x6000003  System.Void .ctor(System.Net.Http.IMonoHttpClientHandler handler)
  RVA=0x09835EA0  token=0x6000004  System.Void Dispose(System.Boolean disposing)
  RVA=0x09835FEC  token=0x6000005  System.Void ThrowForModifiedManagedSslOptionsIfStarted()
  RVA=0x09835F7C  token=0x6000009  System.Void SetWebRequestTimeout(System.TimeSpan timeout)
  RVA=0x09835EF8  token=0x600000A  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  RVA=0x09836064  token=0x600000B  System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_0(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: System.Net.Http.IMonoHttpClientHandler
TYPE:  interface
TOKEN: 0x2000004
IMPLEMENTS: System.IDisposable
FIELDS:
PROPERTIES:
  SslOptions  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000011  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  RVA=-1  // abstract  token=0x6000012  System.Void SetWebRequestTimeout(System.TimeSpan timeout)
END_CLASS

CLASS: System.Net.Http.MonoWebRequestHandler
TYPE:  class
TOKEN: 0x2000005
SIZE:  0xB8
IMPLEMENTS: System.Net.Http.IMonoHttpClientHandler System.IDisposable
FIELDS:
  private   static  System.Int64                    groupCounter  // static @ 0x0
  private           System.Boolean                  allowAutoRedirect  // 0x10
  private           System.Net.DecompressionMethods automaticDecompression  // 0x14
  private           System.Net.CookieContainer      cookieContainer  // 0x18
  private           System.Net.ICredentials         credentials  // 0x20
  private           System.Int32                    maxAutomaticRedirections  // 0x28
  private           System.Int64                    maxRequestContentBufferSize  // 0x30
  private           System.Boolean                  preAuthenticate  // 0x38
  private           System.Net.IWebProxy            proxy  // 0x40
  private           System.Boolean                  useCookies  // 0x48
  private           System.Boolean                  useProxy  // 0x49
  private           System.Net.Security.SslClientAuthenticationOptionssslOptions  // 0x50
  private           System.Boolean                  allowPipelining  // 0x58
  private           System.Net.Cache.RequestCachePolicycachePolicy  // 0x60
  private           System.Net.Security.AuthenticationLevelauthenticationLevel  // 0x68
  private           System.TimeSpan                 continueTimeout  // 0x70
  private           System.Security.Principal.TokenImpersonationLevelimpersonationLevel  // 0x78
  private           System.Int32                    maxResponseHeadersLength  // 0x7c
  private           System.Int32                    readWriteTimeout  // 0x80
  private           System.Net.Security.RemoteCertificateValidationCallbackserverCertificateValidationCallback  // 0x88
  private           System.Boolean                  unsafeAuthenticatedConnectionSharing  // 0x90
  private           System.Boolean                  sentRequest  // 0x91
  private           System.String                   connectionGroupName  // 0x98
  private           System.Nullable<System.TimeSpan>timeout  // 0xa0
  private           System.Boolean                  disposed  // 0xb0
PROPERTIES:
  CookieContainer  get=0x0983E918
  MaxRequestContentBufferSize  get=0x01003830
  SslOptions  get=0x0983E98C  set=0x0983E9F0
METHODS:
  RVA=0x0983E7C4  token=0x6000013  System.Void .ctor()
  RVA=0x0983E3F4  token=0x6000014  System.Void EnsureModifiability()
  RVA=0x0983E3E8  token=0x6000019  System.Void Dispose()
  RVA=0x0983E378  token=0x600001A  System.Void Dispose(System.Boolean disposing)
  RVA=0x0983E460  token=0x600001B  System.Boolean GetConnectionKeepAlive(System.Net.Http.Headers.HttpRequestHeaders headers)
  RVA=0x0983DB58  token=0x600001C  System.Net.HttpWebRequest CreateWebRequest(System.Net.Http.HttpRequestMessage request)
  RVA=0x0983D9BC  token=0x600001D  System.Net.Http.HttpResponseMessage CreateResponseMessage(System.Net.HttpWebResponse wr, System.Net.Http.HttpRequestMessage requestMessage, System.Threading.CancellationToken cancellationToken)
  RVA=0x0983E580  token=0x600001E  System.Boolean MethodHasBody(System.Net.Http.HttpMethod method)
  RVA=0x0983E660  token=0x600001F  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  RVA=0x0983E76C  token=0x6000020  System.Void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(System.TimeSpan timeout)
END_CLASS

CLASS: System.Net.Http.PlatformHelper
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09840AC8  token=0x6000028  System.Boolean IsContentHeader(System.String name)
  RVA=0x09840A6C  token=0x6000029  System.String GetSingleHeaderString(System.String name, System.Collections.Generic.IEnumerable<System.String> values)
  RVA=0x098409FC  token=0x600002A  System.Net.Http.StreamContent CreateStreamContent(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.ByteArrayContent
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x38
EXTENDS: System.Net.Http.HttpContent
FIELDS:
  private   readonly System.Byte[]                   content  // 0x28
  private   readonly System.Int32                    offset  // 0x30
  private   readonly System.Int32                    count  // 0x34
METHODS:
  RVA=0x0983215C  token=0x600002B  System.Void .ctor(System.Byte[] content)
  RVA=0x09832128  token=0x600002C  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=0x03D755A0  token=0x600002D  System.Boolean TryComputeLength(System.Int64& length)
END_CLASS

CLASS: System.Net.Http.ClientCertificateOption
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.ClientCertificateOptionManual  // const
  public    static  System.Net.Http.ClientCertificateOptionAutomatic  // const
METHODS:
END_CLASS

CLASS: System.Net.Http.HttpClient
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x50
EXTENDS: System.Net.Http.HttpMessageInvoker
FIELDS:
  private   static readonly System.TimeSpan                 TimeoutDefault  // static @ 0x0
  private           System.Uri                      base_address  // 0x20
  private           System.Threading.CancellationTokenSourcects  // 0x28
  private           System.Boolean                  disposed  // 0x30
  private           System.Net.Http.Headers.HttpRequestHeadersheaders  // 0x38
  private           System.Int64                    buffer_size  // 0x40
  private           System.TimeSpan                 timeout  // 0x48
PROPERTIES:
  DefaultRequestHeaders  get=0x09836B94
  MaxResponseContentBufferSize  get=0x03D4E2B0
METHODS:
  RVA=0x09836B2C  token=0x600002E  System.Void .ctor()
  RVA=0x09836A68  token=0x600002F  System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler)
  RVA=0x098363E4  token=0x6000032  System.Void Dispose(System.Boolean disposing)
  RVA=0x09836444  token=0x6000033  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.String requestUri, System.Net.Http.HttpContent content)
  RVA=0x0983664C  token=0x6000034  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request)
  RVA=0x098369E0  token=0x6000035  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  RVA=0x098366A8  token=0x6000036  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken)
  RVA=0x09836534  token=0x6000037  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsyncWorker(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken)
  RVA=0x09836A08  token=0x6000038  System.Void .cctor()
  RVA=0x09836A00  token=0x6000039  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> <>n__0(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.HttpCompletionOption
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.HttpCompletionOptionResponseContentRead  // const
  public    static  System.Net.Http.HttpCompletionOptionResponseHeadersRead  // const
METHODS:
END_CLASS

CLASS: System.Net.Http.HttpContent
TYPE:  abstract class
TOKEN: 0x200000E
SIZE:  0x28
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Net.Http.HttpContent.FixedMemoryStreambuffer  // 0x10
  private           System.Boolean                  disposed  // 0x18
  private           System.Net.Http.Headers.HttpContentHeadersheaders  // 0x20
PROPERTIES:
  Headers  get=0x098373D0
  LoadedBufferLength  get=0x09837448
METHODS:
  RVA=0x09836F54  token=0x600003E  System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream)
  RVA=0x09836F60  token=0x600003F  System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=0x09836FF0  token=0x6000040  System.Net.Http.HttpContent.FixedMemoryStream CreateFixedMemoryStream(System.Int64 maxBufferSize)
  RVA=0x09837078  token=0x6000041  System.Void Dispose()
  RVA=0x09837050  token=0x6000042  System.Void Dispose(System.Boolean disposing)
  RVA=0x09837280  token=0x6000043  System.Threading.Tasks.Task LoadIntoBufferAsync()
  RVA=0x098371B8  token=0x6000044  System.Threading.Tasks.Task LoadIntoBufferAsync(System.Int64 maxBufferSize)
  RVA=0x09837290  token=0x6000045  System.Threading.Tasks.Task<System.String> ReadAsStringAsync()
  RVA=0x09837088  token=0x6000046  System.Text.Encoding GetEncodingFromBuffer(System.Byte[] buffer, System.Int32 length, System.Int32& preambleLength)
  RVA=0x09837374  token=0x6000047  System.Int32 StartsWith(System.Byte[] array, System.Int32 length, System.Byte[] value)
  RVA=0x09837364  token=0x6000048  System.Threading.Tasks.Task SerializeToStreamAsync_internal(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=-1  // abstract  token=0x6000049  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=-1  // abstract  token=0x600004A  System.Boolean TryComputeLength(System.Int64& length)
  RVA=0x0350B670  token=0x600004B  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.HttpMessageHandler
TYPE:  abstract class
TOKEN: 0x2000012
SIZE:  0x10
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=0x09837078  token=0x6000054  System.Void Dispose()
  RVA=0x0350B670  token=0x6000055  System.Void Dispose(System.Boolean disposing)
  RVA=-1  // abstract  token=0x6000056  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  RVA=0x0350B670  token=0x6000057  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.HttpMessageInvoker
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Net.Http.HttpMessageHandlerhandler  // 0x10
  private   readonly System.Boolean                  disposeHandler  // 0x18
METHODS:
  RVA=0x0983A3B4  token=0x6000058  System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler)
  RVA=0x09837078  token=0x6000059  System.Void Dispose()
  RVA=0x0983A324  token=0x600005A  System.Void Dispose(System.Boolean disposing)
  RVA=0x0983A35C  token=0x600005B  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.HttpMethod
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   static readonly System.Net.Http.HttpMethod      delete_method  // static @ 0x0
  private   static readonly System.Net.Http.HttpMethod      get_method  // static @ 0x8
  private   static readonly System.Net.Http.HttpMethod      head_method  // static @ 0x10
  private   static readonly System.Net.Http.HttpMethod      options_method  // static @ 0x18
  private   static readonly System.Net.Http.HttpMethod      post_method  // static @ 0x20
  private   static readonly System.Net.Http.HttpMethod      put_method  // static @ 0x28
  private   static readonly System.Net.Http.HttpMethod      trace_method  // static @ 0x30
  private   readonly System.String                   method  // 0x10
PROPERTIES:
  Method  get=0x020B7B20
  Post  get=0x0983A808
METHODS:
  RVA=0x0983A778  token=0x600005C  System.Void .ctor(System.String method)
  RVA=0x0983A858  token=0x600005F  System.Boolean op_Equality(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right)
  RVA=0x0983A430  token=0x6000060  System.Boolean Equals(System.Net.Http.HttpMethod other)
  RVA=0x0983A45C  token=0x6000061  System.Boolean Equals(System.Object obj)
  RVA=0x06FAB9A8  token=0x6000062  System.Int32 GetHashCode()
  RVA=0x020B7B20  token=0x6000063  System.String ToString()
  RVA=0x0983A4B8  token=0x6000064  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.HttpRequestException
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x0983A874  token=0x6000065  System.Void .ctor()
  RVA=0x0983A8C0  token=0x6000066  System.Void .ctor(System.String message)
  RVA=0x0983A91C  token=0x6000067  System.Void .ctor(System.String message, System.Exception inner)
END_CLASS

CLASS: System.Net.Http.HttpRequestMessage
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x40
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Net.Http.Headers.HttpRequestHeadersheaders  // 0x10
  private           System.Net.Http.HttpMethod      method  // 0x18
  private           System.Version                  version  // 0x20
  private           System.Uri                      uri  // 0x28
  private           System.Boolean                  is_used  // 0x30
  private           System.Boolean                  disposed  // 0x31
  private           System.Net.Http.HttpContent     <Content>k__BackingField  // 0x38
PROPERTIES:
  Content  get=0x03D4E2A0  set=0x0388FF30
  Headers  get=0x0983B67C
  Method  get=0x01041090  set=0x0983B744
  RequestUri  get=0x03D4EAC0  set=0x0983B7EC
  Version  get=0x0983B6F0
METHODS:
  RVA=0x0983B5B4  token=0x6000068  System.Void .ctor(System.Net.Http.HttpMethod method, System.String requestUri)
  RVA=0x0983B64C  token=0x6000069  System.Void .ctor(System.Net.Http.HttpMethod method, System.Uri requestUri)
  RVA=0x0983B228  token=0x6000071  System.Boolean IsAllowedAbsoluteUri(System.Uri uri)
  RVA=0x0983B1F0  token=0x6000073  System.Void Dispose()
  RVA=0x0983B1FC  token=0x6000074  System.Void Dispose(System.Boolean disposing)
  RVA=0x0983B358  token=0x6000075  System.Boolean SetIsUsed()
  RVA=0x0983B368  token=0x6000076  System.String ToString()
END_CLASS

CLASS: System.Net.Http.HttpResponseMessage
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x48
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Net.Http.Headers.HttpResponseHeadersheaders  // 0x10
  private           System.String                   reasonPhrase  // 0x18
  private           System.Net.HttpStatusCode       statusCode  // 0x20
  private           System.Version                  version  // 0x28
  private           System.Boolean                  disposed  // 0x30
  private           System.Net.Http.HttpContent     <Content>k__BackingField  // 0x38
  private           System.Net.Http.HttpRequestMessage<RequestMessage>k__BackingField  // 0x40
PROPERTIES:
  Content  get=0x03D4E2A0  set=0x0388FF30
  Headers  get=0x0983BB54
  ReasonPhrase  get=0x0983BBC8  set=0x022C3A90
  RequestMessage  set=0x03CB2D80
  StatusCode  get=0x01003B50  set=0x0983BC30
  Version  get=0x0983BBDC
METHODS:
  RVA=0x0983BB4C  token=0x6000077  System.Void .ctor(System.Net.HttpStatusCode statusCode)
  RVA=0x0983B900  token=0x6000081  System.Void Dispose()
  RVA=0x0983B90C  token=0x6000082  System.Void Dispose(System.Boolean disposing)
  RVA=0x0983B938  token=0x6000083  System.String ToString()
END_CLASS

CLASS: System.Net.Http.MultipartContent
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x38
EXTENDS: System.Net.Http.HttpContent
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.HttpContent>nested_content  // 0x28
  private   readonly System.String                   boundary  // 0x30
METHODS:
  RVA=0x0983F30C  token=0x6000084  System.Void .ctor(System.String subtype)
  RVA=0x0983F3A8  token=0x6000085  System.Void .ctor(System.String subtype, System.String boundary)
  RVA=0x0983ED48  token=0x6000086  System.Boolean IsValidRFC2049(System.String s)
  RVA=0x0983EA20  token=0x6000087  System.Void Add(System.Net.Http.HttpContent content)
  RVA=0x0983EB20  token=0x6000088  System.Void Dispose(System.Boolean disposing)
  RVA=0x0983EE00  token=0x6000089  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=0x0983EF6C  token=0x600008A  System.Boolean TryComputeLength(System.Int64& length)
  RVA=0x0983ECC8  token=0x600008B  System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator()
  RVA=0x0983EEEC  token=0x600008C  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Net.Http.MultipartFormDataContent
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x38
EXTENDS: System.Net.Http.MultipartContent
FIELDS:
METHODS:
  RVA=0x0983F9F8  token=0x600008F  System.Void .ctor()
  RVA=0x0983F9B8  token=0x6000090  System.Void Add(System.Net.Http.HttpContent content)
  RVA=0x0983F7F4  token=0x6000091  System.Void Add(System.Net.Http.HttpContent content, System.String name)
  RVA=0x0983F8A0  token=0x6000092  System.Void Add(System.Net.Http.HttpContent content, System.String name, System.String fileName)
  RVA=0x0983F708  token=0x6000093  System.Void AddContentDisposition(System.Net.Http.HttpContent content, System.String name, System.String fileName)
END_CLASS

CLASS: System.Net.Http.StreamContent
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x50
EXTENDS: System.Net.Http.HttpContent
FIELDS:
  private   readonly System.IO.Stream                content  // 0x28
  private   readonly System.Int32                    bufferSize  // 0x30
  private   readonly System.Threading.CancellationTokencancellationToken  // 0x38
  private   readonly System.Int64                    startPosition  // 0x40
  private           System.Boolean                  contentCopied  // 0x48
METHODS:
  RVA=0x09842FA0  token=0x6000094  System.Void .ctor(System.IO.Stream content)
  RVA=0x09842E9C  token=0x6000095  System.Void .ctor(System.IO.Stream content, System.Int32 bufferSize)
  RVA=0x09842FB0  token=0x6000096  System.Void .ctor(System.IO.Stream content, System.Threading.CancellationToken cancellationToken)
  RVA=0x09842D24  token=0x6000097  System.Void Dispose(System.Boolean disposing)
  RVA=0x09842D6C  token=0x6000098  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  RVA=0x09842E40  token=0x6000099  System.Boolean TryComputeLength(System.Int64& length)
END_CLASS

CLASS: System.Net.Http.StringContent
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x38
EXTENDS: System.Net.Http.ByteArrayContent
FIELDS:
METHODS:
  RVA=0x09843020  token=0x600009A  System.Void .ctor(System.String content)
  RVA=0x09843040  token=0x600009B  System.Void .ctor(System.String content, System.Text.Encoding encoding, System.String mediaType)
  RVA=0x09842FE8  token=0x600009C  System.Byte[] GetByteArray(System.String content, System.Text.Encoding encoding)
END_CLASS

CLASS: System.Net.Http.Headers.AuthenticationHeaderValue
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   <Parameter>k__BackingField  // 0x10
  private           System.String                   <Scheme>k__BackingField  // 0x18
PROPERTIES:
  Parameter  get=0x020B7B20  set=0x0426FEE0
  Scheme  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x098320DC  token=0x600009D  System.Void .ctor(System.String scheme, System.String parameter)
  RVA=0x0350B670  token=0x600009E  System.Void .ctor()
  RVA=0x02A48500  token=0x60000A3  System.Object System.ICloneable.Clone()
  RVA=0x09831C84  token=0x60000A4  System.Boolean Equals(System.Object obj)
  RVA=0x09831D00  token=0x60000A5  System.Int32 GetHashCode()
  RVA=0x09831F70  token=0x60000A6  System.Boolean TryParse(System.String input, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue)
  RVA=0x0983202C  token=0x60000A7  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.AuthenticationHeaderValue>& result)
  RVA=0x09831DC0  token=0x60000A8  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x09831D74  token=0x60000A9  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.CacheControlHeaderValue
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x78
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>extensions  // 0x10
  private           System.Collections.Generic.List<System.String>no_cache_headers  // 0x18
  private           System.Collections.Generic.List<System.String>private_headers  // 0x20
  private           System.Nullable<System.TimeSpan><MaxAge>k__BackingField  // 0x28
  private           System.Boolean                  <MaxStale>k__BackingField  // 0x38
  private           System.Nullable<System.TimeSpan><MaxStaleLimit>k__BackingField  // 0x40
  private           System.Nullable<System.TimeSpan><MinFresh>k__BackingField  // 0x50
  private           System.Boolean                  <MustRevalidate>k__BackingField  // 0x60
  private           System.Boolean                  <NoCache>k__BackingField  // 0x61
  private           System.Boolean                  <NoStore>k__BackingField  // 0x62
  private           System.Boolean                  <NoTransform>k__BackingField  // 0x63
  private           System.Boolean                  <OnlyIfCached>k__BackingField  // 0x64
  private           System.Boolean                  <Private>k__BackingField  // 0x65
  private           System.Boolean                  <ProxyRevalidate>k__BackingField  // 0x66
  private           System.Boolean                  <Public>k__BackingField  // 0x67
  private           System.Nullable<System.TimeSpan><SharedMaxAge>k__BackingField  // 0x68
PROPERTIES:
  Extensions  get=0x098339B4
  MaxAge  get=0x03D59E20  set=0x03D59E30
  MaxStale  get=0x03D4F190  set=0x03D4E280
  MaxStaleLimit  get=0x03D5A160  set=0x03D5D610
  MinFresh  get=0x03D55950  set=0x03D5A610
  MustRevalidate  get=0x03D519A0  set=0x03D519B0
  NoCache  get=0x03D51F90  set=0x03D5B410
  NoCacheHeaders  get=0x09833A38
  NoStore  get=0x03D5B400  set=0x03D5B420
  NoTransform  get=0x03D5B3F0  set=0x03D755C0
  OnlyIfCached  get=0x03D590F0  set=0x03D59100
  Private  get=0x03D5CA70  set=0x03D6CF00
  PrivateHeaders  get=0x09833ABC
  ProxyRevalidate  get=0x03D5CAA0  set=0x03D5CAB0
  Public  get=0x03D755B0  set=0x03D755D0
  SharedMaxAge  get=0x03D5D750  set=0x03D71AD0
METHODS:
  RVA=0x09832644  token=0x60000C7  System.Object System.ICloneable.Clone()
  RVA=0x098321DC  token=0x60000C8  System.Boolean Equals(System.Object obj)
  RVA=0x09832420  token=0x60000C9  System.Int32 GetHashCode()
  RVA=0x098331BC  token=0x60000CA  System.Boolean TryParse(System.String input, System.Net.Http.Headers.CacheControlHeaderValue& parsedValue)
  RVA=0x09832B78  token=0x60000CB  System.String ToString()
  RVA=0x0350B670  token=0x60000CC  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.Headers.CollectionExtensions
TYPE:  static class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60000CD  System.Boolean SequenceEqual(System.Collections.Generic.List<TSource> first, System.Collections.Generic.List<TSource> second)
  RVA=0x09833B40  token=0x60000CE  System.Void SetValue(System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters, System.String key, System.String value)
  RVA=-1  // generic def  token=0x60000CF  System.String ToString(System.Collections.Generic.List<T> list)
  RVA=-1  // generic def  token=0x60000D0  System.Void ToStringBuilder(System.Collections.Generic.List<T> list, System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Net.Http.Headers.ElementTryParser`1
TYPE:  sealed class
TOKEN: 0x2000020
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60000D1  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60000D2  System.Boolean Invoke(System.Net.Http.Headers.Lexer lexer, T& parsedValue, System.Net.Http.Headers.Token& token)
END_CLASS

CLASS: System.Net.Http.Headers.CollectionParser
TYPE:  static class
TOKEN: 0x2000021
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60000D3  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Net.Http.Headers.ElementTryParser<T> parser, System.Collections.Generic.List<T>& result)
  RVA=0x09833D90  token=0x60000D4  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.String>& result)
  RVA=0x09833C88  token=0x60000D5  System.Boolean TryParseStringElement(System.Net.Http.Headers.Lexer lexer, System.String& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.ContentDispositionHeaderValue
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   dispositionType  // 0x10
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x18
PROPERTIES:
  DispositionType  set=0x09834944
  FileName  set=0x098349D8
  FileNameStar  set=0x09834978
  Name  set=0x09834A38
  Parameters  get=0x098348C0
METHODS:
  RVA=0x0350B670  token=0x60000D6  System.Void .ctor()
  RVA=0x098348B8  token=0x60000D7  System.Void .ctor(System.String dispositionType)
  RVA=0x098345DC  token=0x60000D8  System.Void .ctor(System.Net.Http.Headers.ContentDispositionHeaderValue source)
  RVA=0x09834398  token=0x60000DE  System.Object System.ICloneable.Clone()
  RVA=0x098341F4  token=0x60000DF  System.Boolean Equals(System.Object obj)
  RVA=0x09833E40  token=0x60000E0  System.String EncodeBase64Value(System.String value)
  RVA=0x09833FCC  token=0x60000E1  System.String EncodeRFC5987(System.String value)
  RVA=0x09834280  token=0x60000E2  System.Int32 GetHashCode()
  RVA=0x098342F0  token=0x60000E3  System.Void SetValue(System.String key, System.String value)
  RVA=0x098343F8  token=0x60000E4  System.String ToString()
  RVA=0x09834450  token=0x60000E5  System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentDispositionHeaderValue& parsedValue)
END_CLASS

CLASS: System.Net.Http.Headers.ContentRangeHeaderValue
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x48
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   unit  // 0x10
  private           System.Nullable<System.Int64>   <From>k__BackingField  // 0x18
  private           System.Nullable<System.Int64>   <Length>k__BackingField  // 0x28
  private           System.Nullable<System.Int64>   <To>k__BackingField  // 0x38
PROPERTIES:
  From  get=0x03D51D80  set=0x03D51D90
  Length  get=0x03D59E20  set=0x03D59E30
  To  get=0x03D5A120  set=0x03D5C3C0
  Unit  get=0x020B7B20
METHODS:
  RVA=0x098352AC  token=0x60000E6  System.Void .ctor()
  RVA=0x02A48500  token=0x60000EE  System.Object System.ICloneable.Clone()
  RVA=0x09834A98  token=0x60000EF  System.Boolean Equals(System.Object obj)
  RVA=0x09834B74  token=0x60000F0  System.Int32 GetHashCode()
  RVA=0x09834E7C  token=0x60000F1  System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentRangeHeaderValue& parsedValue)
  RVA=0x09834C6C  token=0x60000F2  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.EntityTagHeaderValue
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private   static readonly System.Net.Http.Headers.EntityTagHeaderValueany  // static @ 0x0
  private           System.Boolean                  <IsWeak>k__BackingField  // 0x10
  private           System.String                   <Tag>k__BackingField  // 0x18
PROPERTIES:
  IsWeak  get=0x011797F0  set=0x03D4E960
  Tag  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x60000F3  System.Void .ctor()
  RVA=0x02A48500  token=0x60000F8  System.Object System.ICloneable.Clone()
  RVA=0x098354FC  token=0x60000F9  System.Boolean Equals(System.Object obj)
  RVA=0x09835578  token=0x60000FA  System.Int32 GetHashCode()
  RVA=0x0983586C  token=0x60000FB  System.Boolean TryParse(System.String input, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue)
  RVA=0x09835630  token=0x60000FC  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x09835940  token=0x60000FD  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.EntityTagHeaderValue>& result)
  RVA=0x098355E8  token=0x60000FE  System.String ToString()
  RVA=0x098359F0  token=0x60000FF  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.HashCodeCalculator
TYPE:  static class
TOKEN: 0x2000025
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000100  System.Int32 Calculate(System.Collections.Generic.ICollection<T> list)
END_CLASS

CLASS: System.Net.Http.Headers.TryParseDelegate`1
TYPE:  sealed class
TOKEN: 0x2000026
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000101  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000102  System.Boolean Invoke(System.String value, T& result)
END_CLASS

CLASS: System.Net.Http.Headers.TryParseListDelegate`1
TYPE:  sealed class
TOKEN: 0x2000027
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000103  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000104  System.Boolean Invoke(System.String value, System.Int32 minimalCount, System.Collections.Generic.List<T>& result)
END_CLASS

CLASS: System.Net.Http.Headers.HeaderInfo
TYPE:  abstract class
TOKEN: 0x2000028
SIZE:  0x28
FIELDS:
  public            System.Boolean                  AllowsMany  // 0x10
  public    readonly System.Net.Http.Headers.HttpHeaderKindHeaderKind  // 0x14
  public    readonly System.String                   Name  // 0x18
  private           System.Func<System.Object,System.String><CustomToString>k__BackingField  // 0x20
PROPERTIES:
  CustomToString  get=0x03D4EB40  set=0x04271930
  Separator  get=0x09835D68
METHODS:
  RVA=0x09835D48  token=0x6000105  System.Void .ctor(System.String name, System.Net.Http.Headers.HttpHeaderKind headerKind)
  RVA=-1  // generic def  token=0x6000106  System.Net.Http.Headers.HeaderInfo CreateSingle(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Func<System.Object,System.String> toString)
  RVA=-1  // generic def  token=0x6000107  System.Net.Http.Headers.HeaderInfo CreateMulti(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> elementParser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator)
  RVA=0x09835D08  token=0x6000108  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers)
  RVA=-1  // abstract  token=0x600010C  System.Void AddToCollection(System.Object collection, System.Object value)
  RVA=-1  // abstract  token=0x600010D  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  RVA=-1  // abstract  token=0x600010E  System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection)
  RVA=-1  // abstract  token=0x600010F  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: System.Net.Http.Headers.HttpContentHeaders
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x28
EXTENDS: System.Net.Http.Headers.HttpHeaders
FIELDS:
  private   readonly System.Net.Http.HttpContent     content  // 0x20
PROPERTIES:
  ContentDisposition  get=0x09836C68  set=0x09836E24
  ContentLength  get=0x09836CB4  set=0x09836E88
  ContentType  get=0x09836DD8  set=0x09836EF0
METHODS:
  RVA=0x09836C08  token=0x6000118  System.Void .ctor(System.Net.Http.HttpContent content)
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaderKind
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.Headers.HttpHeaderKindNone  // const
  public    static  System.Net.Http.Headers.HttpHeaderKindRequest  // const
  public    static  System.Net.Http.Headers.HttpHeaderKindResponse  // const
  public    static  System.Net.Http.Headers.HttpHeaderKindContent  // const
METHODS:
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaderValueCollection`1
TYPE:  sealed class
TOKEN: 0x200002D
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.List<T>list  // 0x0
  private   readonly System.Net.Http.Headers.HttpHeadersheaders  // 0x0
  private   readonly System.Net.Http.Headers.HeaderInfoheaderInfo  // 0x0
  private           System.Collections.Generic.List<System.String>invalidValues  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
  InvalidValues  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600011F  System.Void .ctor(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  RVA=-1  // not resolved  token=0x6000123  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000124  System.Void AddRange(System.Collections.Generic.List<T> values)
  RVA=-1  // not resolved  token=0x6000125  System.Void AddInvalidValue(System.String invalidValue)
  RVA=-1  // not resolved  token=0x6000126  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000127  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000128  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000129  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x600012A  System.String ToString()
  RVA=-1  // not resolved  token=0x600012B  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x600012C  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x600012D  T Find(System.Predicate<T> predicate)
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaders
TYPE:  abstract class
TOKEN: 0x200002E
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HeaderInfo>known_headers  // static @ 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket>headers  // 0x10
  private   readonly System.Net.Http.Headers.HttpHeaderKindHeaderKind  // 0x18
  private           System.Nullable<System.Boolean> connectionclose  // 0x1c
  private           System.Nullable<System.Boolean> transferEncodingChunked  // 0x1e
METHODS:
  RVA=0x09838650  token=0x600012E  System.Void .cctor()
  RVA=0x0983A280  token=0x600012F  System.Void .ctor()
  RVA=0x0983A25C  token=0x6000130  System.Void .ctor(System.Net.Http.Headers.HttpHeaderKind headerKind)
  RVA=0x098374C4  token=0x6000131  System.Boolean AddInternal(System.String name, System.Collections.Generic.IEnumerable<System.String> values, System.Net.Http.Headers.HeaderInfo headerInfo, System.Boolean ignoreInvalid)
  RVA=0x098384BC  token=0x6000132  System.Boolean TryAddWithoutValidation(System.String name, System.Collections.Generic.IEnumerable<System.String> values)
  RVA=0x09837AAC  token=0x6000133  System.Net.Http.Headers.HeaderInfo CheckName(System.String name)
  RVA=0x09838578  token=0x6000134  System.Boolean TryCheckName(System.String name, System.Net.Http.Headers.HeaderInfo& headerInfo)
  RVA=0x09837D74  token=0x6000135  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>> GetEnumerator()
  RVA=0x09838288  token=0x6000136  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x09838224  token=0x6000137  System.Boolean Remove(System.String name)
  RVA=0x09837EB8  token=0x6000138  System.String GetSingleHeaderString(System.String key, System.Collections.Generic.IEnumerable<System.String> values)
  RVA=0x09838290  token=0x6000139  System.String ToString()
  RVA=-1  // generic def  token=0x600013A  System.Void AddOrRemove(System.String name, T value, System.Func<System.Object,System.String> converter)
  RVA=-1  // generic def  token=0x600013B  System.Void AddOrRemove(System.String name, System.Nullable<T> value)
  RVA=-1  // generic def  token=0x600013C  System.Void AddOrRemove(System.String name, System.Nullable<T> value, System.Func<System.Object,System.String> converter)
  RVA=0x09837C14  token=0x600013D  System.Collections.Generic.List<System.String> GetAllHeaderValues(System.Net.Http.Headers.HttpHeaders.HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo)
  RVA=0x09837DD0  token=0x600013E  System.Net.Http.Headers.HttpHeaderKind GetKnownHeaderKind(System.String name)
  RVA=-1  // generic def  token=0x600013F  T GetValue(System.String name)
  RVA=-1  // generic def  token=0x6000140  System.Net.Http.Headers.HttpHeaderValueCollection<T> GetValues(System.String name)
  RVA=-1  // generic def  token=0x6000141  System.Void SetValue(System.String name, T value, System.Func<System.Object,System.String> toStringConverter)
END_CLASS

CLASS: System.Net.Http.Headers.HttpRequestHeaders
TYPE:  sealed class
TOKEN: 0x2000031
SIZE:  0x28
EXTENDS: System.Net.Http.Headers.HttpHeaders
FIELDS:
  private           System.Nullable<System.Boolean> expectContinue  // 0x20
PROPERTIES:
  Authorization  set=0x0983B0A8
  Connection  get=0x0983ACFC
  ConnectionClose  get=0x0983AB84  set=0x0983B10C
  ExpectContinue  get=0x0983AD48
  Host  get=0x0983AEAC
  TransferEncoding  get=0x0983B05C
  TransferEncodingChunked  get=0x0983AEF8
METHODS:
  RVA=0x0983AB30  token=0x600014E  System.Void .ctor()
  RVA=0x0983A97C  token=0x6000157  System.Void AddHeaders(System.Net.Http.Headers.HttpRequestHeaders headers)
END_CLASS

CLASS: System.Net.Http.Headers.HttpResponseHeaders
TYPE:  sealed class
TOKEN: 0x2000033
SIZE:  0x20
EXTENDS: System.Net.Http.Headers.HttpHeaders
FIELDS:
METHODS:
  RVA=0x0983B8AC  token=0x600015D  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.Headers.Token
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x1C
FIELDS:
  public    static readonly System.Net.Http.Headers.Token   Empty  // static @ 0x0
  private   readonly System.Net.Http.Headers.Token.Typetype  // 0x10
  private           System.Int32                    <StartPosition>k__BackingField  // 0x14
  private           System.Int32                    <EndPosition>k__BackingField  // 0x18
PROPERTIES:
  StartPosition  get=0x03D4E990  set=0x03D51720
  EndPosition  get=0x03D516F0  set=0x03D51710
  Kind  get=0x03D4E980
METHODS:
  RVA=0x098439A4  token=0x600015E  System.Void .ctor(System.Net.Http.Headers.Token.Type type, System.Int32 startPosition, System.Int32 endPosition)
  RVA=0x03D4E980  token=0x6000164  System.Net.Http.Headers.Token.Type op_Implicit(System.Net.Http.Headers.Token token)
  RVA=0x0984389C  token=0x6000165  System.String ToString()
  RVA=0x0984393C  token=0x6000166  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.Lexer
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x20
FIELDS:
  private   static readonly System.Boolean[]                token_chars  // static @ 0x0
  private   static readonly System.Int32                    last_token_char  // static @ 0x8
  private   static readonly System.String[]                 dt_formats  // static @ 0x10
  private   readonly System.String                   s  // 0x10
  private           System.Int32                    pos  // 0x18
PROPERTIES:
  Position  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x0426FEE0  token=0x6000167  System.Void .ctor(System.String stream)
  RVA=0x0983BDFC  token=0x600016A  System.String GetStringValue(System.Net.Http.Headers.Token token)
  RVA=0x0983BD88  token=0x600016B  System.String GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end)
  RVA=0x0983BCE8  token=0x600016C  System.String GetQuotedStringValue(System.Net.Http.Headers.Token start)
  RVA=0x0983BD58  token=0x600016D  System.String GetRemainingStringValue(System.Int32 position)
  RVA=0x0983BE64  token=0x600016E  System.Boolean IsStarStringValue(System.Net.Http.Headers.Token token)
  RVA=0x0983C630  token=0x600016F  System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int32& value)
  RVA=0x0983C6C4  token=0x6000170  System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int64& value)
  RVA=0x0983C758  token=0x6000171  System.Nullable<System.TimeSpan> TryGetTimeSpanValue(System.Net.Http.Headers.Token token)
  RVA=0x0983C400  token=0x6000172  System.Boolean TryGetDateValue(System.Net.Http.Headers.Token token, System.DateTimeOffset& value)
  RVA=0x0983C4D8  token=0x6000173  System.Boolean TryGetDateValue(System.String text, System.DateTimeOffset& value)
  RVA=0x0983C59C  token=0x6000174  System.Boolean TryGetDoubleValue(System.Net.Http.Headers.Token token, System.Double& value)
  RVA=0x0983BF6C  token=0x6000175  System.Boolean IsValidToken(System.String input)
  RVA=0x0983BEE8  token=0x6000176  System.Boolean IsValidCharacter(System.Char input)
  RVA=0x03D68050  token=0x6000177  System.Void EatChar()
  RVA=0x0983BFF4  token=0x6000178  System.Int32 PeekChar()
  RVA=0x0983C028  token=0x6000179  System.Boolean ScanCommentOptional(System.String& value, System.Net.Http.Headers.Token& readToken)
  RVA=0x0983C150  token=0x600017A  System.Net.Http.Headers.Token Scan(System.Boolean recognizeDash)
  RVA=0x0983C81C  token=0x600017B  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.MediaTypeHeaderValue
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x10
  private           System.String                   media_type  // 0x18
PROPERTIES:
  CharSet  get=0x0983D3B8  set=0x0983D560
  MediaType  set=0x0983D60C
  Parameters  get=0x0983D4DC
METHODS:
  RVA=0x0983D3B0  token=0x600017C  System.Void .ctor(System.String mediaType)
  RVA=0x0983D0D4  token=0x600017D  System.Void .ctor(System.Net.Http.Headers.MediaTypeHeaderValue source)
  RVA=0x0350B670  token=0x600017E  System.Void .ctor()
  RVA=0x0983CCC8  token=0x6000183  System.Object System.ICloneable.Clone()
  RVA=0x0983CBCC  token=0x6000184  System.Boolean Equals(System.Object obj)
  RVA=0x0983CC58  token=0x6000185  System.Int32 GetHashCode()
  RVA=0x0983CD28  token=0x6000186  System.String ToString()
  RVA=0x0983CF58  token=0x6000187  System.Boolean TryParse(System.String input, System.Net.Http.Headers.MediaTypeHeaderValue& parsedValue)
  RVA=0x0983CD8C  token=0x6000188  System.Nullable<System.Net.Http.Headers.Token> TryParseMediaType(System.Net.Http.Headers.Lexer lexer, System.String& media)
END_CLASS

CLASS: System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x20
EXTENDS: System.Net.Http.Headers.MediaTypeHeaderValue
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600018C  System.Void .ctor()
  RVA=0x0983D798  token=0x600018D  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x0983D90C  token=0x600018E  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>& result)
END_CLASS

CLASS: System.Net.Http.Headers.NameValueHeaderValue
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   value  // 0x10
  private           System.String                   <Name>k__BackingField  // 0x18
PROPERTIES:
  Name  get=0x01041090  set=0x022C3A90
  Value  get=0x020B7B20  set=0x098401F0
METHODS:
  RVA=0x098401A4  token=0x600018F  System.Void .ctor(System.String name, System.String value)
  RVA=0x09840168  token=0x6000190  System.Void .ctor(System.Net.Http.Headers.NameValueHeaderValue source)
  RVA=0x0350B670  token=0x6000191  System.Void .ctor()
  RVA=0x0983FA34  token=0x6000196  System.Net.Http.Headers.NameValueHeaderValue Create(System.String name, System.String value)
  RVA=0x0983FB50  token=0x6000197  System.Object System.ICloneable.Clone()
  RVA=0x09831D00  token=0x6000198  System.Int32 GetHashCode()
  RVA=0x0983FAA4  token=0x6000199  System.Boolean Equals(System.Object obj)
  RVA=0x098400B8  token=0x600019A  System.Boolean TryParsePragma(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result)
  RVA=0x0983FE0C  token=0x600019B  System.Boolean TryParseParameters(System.Net.Http.Headers.Lexer lexer, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result, System.Net.Http.Headers.Token& t)
  RVA=0x0983FBB0  token=0x600019C  System.String ToString()
  RVA=0x0983FC14  token=0x600019D  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.NameValueWithParametersHeaderValue
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x28
EXTENDS: System.Net.Http.Headers.NameValueHeaderValue
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x20
PROPERTIES:
  Parameters  get=0x09840978
METHODS:
  RVA=0x09840828  token=0x600019E  System.Void .ctor(System.Net.Http.Headers.NameValueWithParametersHeaderValue source)
  RVA=0x0350B670  token=0x600019F  System.Void .ctor()
  RVA=0x0984044C  token=0x60001A1  System.Object System.ICloneable.Clone()
  RVA=0x09840368  token=0x60001A2  System.Boolean Equals(System.Object obj)
  RVA=0x098403F8  token=0x60001A3  System.Int32 GetHashCode()
  RVA=0x098404AC  token=0x60001A4  System.String ToString()
  RVA=0x09840778  token=0x60001A5  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueWithParametersHeaderValue>& result)
  RVA=0x09840534  token=0x60001A6  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueWithParametersHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.Parser
TYPE:  static class
TOKEN: 0x200003C
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Http.Headers.ProductHeaderValue
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.String                   <Version>k__BackingField  // 0x18
PROPERTIES:
  Name  get=0x020B7B20  set=0x0426FEE0
  Version  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x60001B9  System.Void .ctor()
  RVA=0x02A48500  token=0x60001BE  System.Object System.ICloneable.Clone()
  RVA=0x09840B10  token=0x60001BF  System.Boolean Equals(System.Object obj)
  RVA=0x09840B90  token=0x60001C0  System.Int32 GetHashCode()
  RVA=0x09840E30  token=0x60001C1  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductHeaderValue>& result)
  RVA=0x09840C50  token=0x60001C2  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x09840BFC  token=0x60001C3  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.ProductInfoHeaderValue
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   <Comment>k__BackingField  // 0x10
  private           System.Net.Http.Headers.ProductHeaderValue<Product>k__BackingField  // 0x18
PROPERTIES:
  Comment  get=0x020B7B20  set=0x0426FEE0
  Product  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09841318  token=0x60001C4  System.Void .ctor(System.Net.Http.Headers.ProductHeaderValue product)
  RVA=0x0350B670  token=0x60001C5  System.Void .ctor()
  RVA=0x02A48500  token=0x60001CA  System.Object System.ICloneable.Clone()
  RVA=0x09840EE0  token=0x60001CB  System.Boolean Equals(System.Object obj)
  RVA=0x09840F54  token=0x60001CC  System.Int32 GetHashCode()
  RVA=0x098411C8  token=0x60001CD  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductInfoHeaderValue>& result)
  RVA=0x09840FAC  token=0x60001CE  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductInfoHeaderValue& parsedValue)
  RVA=0x09840F84  token=0x60001CF  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeConditionHeaderValue
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x30
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x10
  private           System.Net.Http.Headers.EntityTagHeaderValue<EntityTag>k__BackingField  // 0x28
PROPERTIES:
  Date  get=0x020B6BB0  set=0x03D64DD0
  EntityTag  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x09841864  token=0x60001D0  System.Void .ctor(System.DateTimeOffset date)
  RVA=0x098418C4  token=0x60001D1  System.Void .ctor(System.Net.Http.Headers.EntityTagHeaderValue entityTag)
  RVA=0x02A48500  token=0x60001D6  System.Object System.ICloneable.Clone()
  RVA=0x0984137C  token=0x60001D7  System.Boolean Equals(System.Object obj)
  RVA=0x09841480  token=0x60001D8  System.Int32 GetHashCode()
  RVA=0x098415D0  token=0x60001D9  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeConditionHeaderValue& parsedValue)
  RVA=0x098414EC  token=0x60001DA  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeHeaderValue
TYPE:  class
TOKEN: 0x200004B
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.RangeItemHeaderValue>ranges  // 0x10
  private           System.String                   unit  // 0x18
PROPERTIES:
  Ranges  get=0x09842210
  Unit  get=0x01041090
METHODS:
  RVA=0x098421D0  token=0x60001DB  System.Void .ctor()
  RVA=0x09842088  token=0x60001DC  System.Void .ctor(System.Net.Http.Headers.RangeHeaderValue source)
  RVA=0x09841A34  token=0x60001DF  System.Object System.ICloneable.Clone()
  RVA=0x09841938  token=0x60001E0  System.Boolean Equals(System.Object obj)
  RVA=0x098419C4  token=0x60001E1  System.Int32 GetHashCode()
  RVA=0x09841BB8  token=0x60001E2  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeHeaderValue& parsedValue)
  RVA=0x09841A94  token=0x60001E3  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeItemHeaderValue
TYPE:  class
TOKEN: 0x200004C
SIZE:  0x30
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Nullable<System.Int64>   <From>k__BackingField  // 0x10
  private           System.Nullable<System.Int64>   <To>k__BackingField  // 0x20
PROPERTIES:
  From  get=0x020B7B30  set=0x03D55580
  To  get=0x03D54E00  set=0x03D54E10
METHODS:
  RVA=0x098424E0  token=0x60001E4  System.Void .ctor(System.Nullable<System.Int64> from, System.Nullable<System.Int64> to)
  RVA=0x02A48500  token=0x60001E9  System.Object System.ICloneable.Clone()
  RVA=0x09842294  token=0x60001EA  System.Boolean Equals(System.Object obj)
  RVA=0x0984234C  token=0x60001EB  System.Int32 GetHashCode()
  RVA=0x098423BC  token=0x60001EC  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RetryConditionHeaderValue
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x38
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x10
  private           System.Nullable<System.TimeSpan><Delta>k__BackingField  // 0x28
PROPERTIES:
  Date  get=0x020B6BB0  set=0x03D64DD0
  Delta  get=0x03D59E20  set=0x03D59E30
METHODS:
  RVA=0x09842CC4  token=0x60001ED  System.Void .ctor(System.DateTimeOffset date)
  RVA=0x09842BE8  token=0x60001EE  System.Void .ctor(System.TimeSpan delta)
  RVA=0x02A48500  token=0x60001F3  System.Object System.ICloneable.Clone()
  RVA=0x098426D0  token=0x60001F4  System.Boolean Equals(System.Object obj)
  RVA=0x09842820  token=0x60001F5  System.Int32 GetHashCode()
  RVA=0x098429F0  token=0x60001F6  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RetryConditionHeaderValue& parsedValue)
  RVA=0x098428A4  token=0x60001F7  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.StringWithQualityHeaderValue
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x28
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Nullable<System.Double>  <Quality>k__BackingField  // 0x10
  private           System.String                   <Value>k__BackingField  // 0x20
PROPERTIES:
  Quality  get=0x020B7B30  set=0x03D55580
  Value  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x0350B670  token=0x60001F8  System.Void .ctor()
  RVA=0x02A48500  token=0x60001FD  System.Object System.ICloneable.Clone()
  RVA=0x09843140  token=0x60001FE  System.Boolean Equals(System.Object obj)
  RVA=0x09843210  token=0x60001FF  System.Int32 GetHashCode()
  RVA=0x0984362C  token=0x6000200  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.StringWithQualityHeaderValue>& result)
  RVA=0x09843364  token=0x6000201  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.StringWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x0984328C  token=0x6000202  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.TransferCodingHeaderValue
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x20
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   value  // 0x10
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x18
PROPERTIES:
  Parameters  get=0x09844084
  Value  get=0x020B7B20
METHODS:
  RVA=0x09843DF8  token=0x6000203  System.Void .ctor(System.Net.Http.Headers.TransferCodingHeaderValue source)
  RVA=0x0350B670  token=0x6000204  System.Void .ctor()
  RVA=0x09843B18  token=0x6000207  System.Object System.ICloneable.Clone()
  RVA=0x09843A10  token=0x6000208  System.Boolean Equals(System.Object obj)
  RVA=0x09843A9C  token=0x6000209  System.Int32 GetHashCode()
  RVA=0x09843B78  token=0x600020A  System.String ToString()
  RVA=0x09843D48  token=0x600020B  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingHeaderValue>& result)
  RVA=0x09843BD0  token=0x600020C  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.TransferCodingWithQualityHeaderValue
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x20
EXTENDS: System.Net.Http.Headers.TransferCodingHeaderValue
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600020D  System.Void .ctor()
  RVA=0x09848A68  token=0x600020E  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>& result)
  RVA=0x098488F0  token=0x600020F  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.ViaHeaderValue
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x30
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   <Comment>k__BackingField  // 0x10
  private           System.String                   <ProtocolName>k__BackingField  // 0x18
  private           System.String                   <ProtocolVersion>k__BackingField  // 0x20
  private           System.String                   <ReceivedBy>k__BackingField  // 0x28
PROPERTIES:
  Comment  get=0x020B7B20  set=0x0426FEE0
  ProtocolName  get=0x01041090  set=0x022C3A90
  ProtocolVersion  get=0x03D4EB40  set=0x04271930
  ReceivedBy  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x0350B670  token=0x6000210  System.Void .ctor()
  RVA=0x02A48500  token=0x6000219  System.Object System.ICloneable.Clone()
  RVA=0x09848B18  token=0x600021A  System.Boolean Equals(System.Object obj)
  RVA=0x09848BC8  token=0x600021B  System.Int32 GetHashCode()
  RVA=0x098490A0  token=0x600021C  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ViaHeaderValue>& result)
  RVA=0x09848DA0  token=0x600021D  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ViaHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x09848C90  token=0x600021E  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.WarningHeaderValue
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x40
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.String                   <Agent>k__BackingField  // 0x10
  private           System.Int32                    <Code>k__BackingField  // 0x18
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x20
  private           System.String                   <Text>k__BackingField  // 0x38
PROPERTIES:
  Agent  get=0x020B7B20  set=0x0426FEE0
  Code  get=0x020D1AC0  set=0x03D4E9C0
  Date  get=0x03D50E20  set=0x03D755E0
  Text  get=0x03D4E2A0  set=0x0388FF30
METHODS:
  RVA=0x0350B670  token=0x600021F  System.Void .ctor()
  RVA=0x09849330  token=0x6000228  System.Boolean IsCodeValid(System.Int32 code)
  RVA=0x02A48500  token=0x6000229  System.Object System.ICloneable.Clone()
  RVA=0x09849150  token=0x600022A  System.Boolean Equals(System.Object obj)
  RVA=0x0984927C  token=0x600022B  System.Int32 GetHashCode()
  RVA=0x09849834  token=0x600022C  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.WarningHeaderValue>& result)
  RVA=0x09849528  token=0x600022D  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.WarningHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  RVA=0x09849344  token=0x600022E  System.String ToString()
END_CLASS

