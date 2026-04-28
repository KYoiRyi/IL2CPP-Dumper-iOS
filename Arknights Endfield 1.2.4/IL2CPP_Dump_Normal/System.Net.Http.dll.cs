// ========================================================
// Dumped by @desirepro
// Assembly: System.Net.Http.dll
// Classes:  84
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.HttpClientHandler.<>c <>9;  // static @ 0x0
        public static System.Net.Security.LocalCertificateSelectionCallback <>9__23_1;  // static @ 0x8

        // Methods
        // RVA: 0x09848644  token: 0x600000C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600000D
        public System.Void .ctor() { }
        // RVA: 0x0984863C  token: 0x600000E
        private System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_1(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.MonoWebRequestHandler.<>c <>9;  // static @ 0x0
        public static System.Func<System.String,System.Boolean> <>9__95_0;  // static @ 0x8
        public static System.Func<System.String,System.Boolean> <>9__96_0;  // static @ 0x10
        public static System.Action<System.Object> <>9__99_0;  // static @ 0x18

        // Methods
        // RVA: 0x098487D4  token: 0x6000021
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000022
        public System.Void .ctor() { }
        // RVA: 0x09848374  token: 0x6000023
        private System.Boolean <GetConnectionKeepAlive>b__95_0(System.String l) { }
        // RVA: 0x09848338  token: 0x6000024
        private System.Boolean <CreateWebRequest>b__96_0(System.String l) { }
        // RVA: 0x098483B8  token: 0x6000025
        private System.Void <SendAsync>b__99_0(System.Object l) { }

    }

    // TypeToken: 0x2000007  // size: 0xB8
    public sealed struct <SendAsync>d__99 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Http.HttpResponseMessage> <>t__builder;  // 0x18
        public System.Net.Http.MonoWebRequestHandler <>4__this;  // 0x30
        public System.Threading.CancellationToken cancellationToken;  // 0x38
        public System.Net.Http.HttpRequestMessage request;  // 0x40
        private System.Net.HttpWebRequest <wrequest>5__2;  // 0x48
        private System.Net.HttpWebResponse <wresponse>5__3;  // 0x50
        private System.Threading.CancellationTokenRegistration <>7__wrap3;  // 0x58
        private System.Net.Http.HttpContent <content>5__5;  // 0x70
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;  // 0x78
        private System.IO.Stream <stream>5__6;  // 0x88
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__2;  // 0x90
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__3;  // 0xa0
        private System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__4;  // 0xb0

        // Methods
        // RVA: 0x09844C84  token: 0x6000026
        private virtual System.Void MoveNext() { }
        // RVA: 0x09846C98  token: 0x6000027
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200000C  // size: 0x80
    public sealed struct <SendAsyncWorker>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Http.HttpResponseMessage> <>t__builder;  // 0x18
        public System.Net.Http.HttpClient <>4__this;  // 0x30
        public System.Threading.CancellationToken cancellationToken;  // 0x38
        public System.Net.Http.HttpRequestMessage request;  // 0x40
        public System.Net.Http.HttpCompletionOption completionOption;  // 0x48
        private System.Threading.CancellationTokenSource <lcts>5__2;  // 0x50
        private System.Net.Http.HttpResponseMessage <response>5__3;  // 0x58
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1;  // 0x60
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;  // 0x70

        // Methods
        // RVA: 0x09846CF8  token: 0x600003A
        private virtual System.Void MoveNext() { }
        // RVA: 0x09847428  token: 0x600003B
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200000F  // size: 0x58
    public sealed class FixedMemoryStream : System.IO.MemoryStream
    {
        // Fields
        private readonly System.Int64 maxSize;  // 0x50

        // Methods
        // RVA: 0x09835BC8  token: 0x600004C
        public System.Void .ctor(System.Int64 maxSize) { }
        // RVA: 0x09835A74  token: 0x600004D
        private System.Void CheckOverflow(System.Int32 count) { }
        // RVA: 0x09835B34  token: 0x600004E
        public virtual System.Void WriteByte(System.Byte value) { }
        // RVA: 0x09835B6C  token: 0x600004F
        public virtual System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }

    }

    // TypeToken: 0x2000010  // size: 0x50
    public sealed struct <LoadIntoBufferAsync>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public System.Net.Http.HttpContent <>4__this;  // 0x30
        public System.Int64 maxBufferSize;  // 0x38
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;  // 0x40

        // Methods
        // RVA: 0x098445EC  token: 0x6000050
        private virtual System.Void MoveNext() { }
        // RVA: 0x09844864  token: 0x6000051
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000011  // size: 0x48
    public sealed struct <ReadAsStringAsync>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.String> <>t__builder;  // 0x18
        public System.Net.Http.HttpContent <>4__this;  // 0x30
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;  // 0x38

        // Methods
        // RVA: 0x098448C0  token: 0x6000052
        private virtual System.Void MoveNext() { }
        // RVA: 0x09844C24  token: 0x6000053
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000019  // size: 0x70
    public sealed struct <SerializeToStreamAsync>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public System.Net.Http.MultipartContent <>4__this;  // 0x30
        public System.IO.Stream stream;  // 0x38
        public System.Net.TransportContext context;  // 0x40
        private System.Text.StringBuilder <sb>5__2;  // 0x48
        private System.Int32 <i>5__3;  // 0x50
        private System.Net.Http.HttpContent <c>5__4;  // 0x58
        private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;  // 0x60

        // Methods
        // RVA: 0x09847488  token: 0x600008D
        private virtual System.Void MoveNext() { }
        // RVA: 0x098482DC  token: 0x600008E
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000029
    public class HeaderTypeInfo`2 : System.Net.Http.Headers.HeaderInfo
    {
        // Fields
        private readonly System.Net.Http.Headers.TryParseDelegate<T> parser;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000110
        public System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        // RVA: -1  // not resolved  token: 0x6000111
        public virtual System.Void AddToCollection(System.Object collection, System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000112
        protected virtual System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        // RVA: -1  // not resolved  token: 0x6000113
        public virtual System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection) { }
        // RVA: -1  // not resolved  token: 0x6000114
        public virtual System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002A
    public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
    {
        // Fields
        private readonly System.Int32 minimalCount;  // 0x0
        private readonly System.String separator;  // 0x0
        private readonly System.Net.Http.Headers.TryParseListDelegate<T> parser;  // 0x0

        // Properties
        System.String Separator { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000115
        public System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator) { }
        // RVA: -1  // not resolved  token: 0x6000117
        public virtual System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002F  // size: 0x28
    public class HeaderBucket
    {
        // Fields
        public System.Object Parsed;  // 0x10
        private System.Collections.Generic.List<System.String> values;  // 0x18
        public readonly System.Func<System.Object,System.String> CustomToString;  // 0x20

        // Properties
        System.Boolean HasStringValues { get; /* RVA: 0x09835C40 */ }
        System.Collections.Generic.List<System.String> Values { get; /* RVA: 0x09835C84 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x02CC1260  token: 0x6000142
        public System.Void .ctor(System.Object parsed, System.Func<System.Object,System.String> converter) { }
        // RVA: 0x09835BF4  token: 0x6000146
        public System.String ParsedToString() { }

    }

    // TypeToken: 0x2000030  // size: 0x58
    public sealed class <GetEnumerator>d__19 : System.Collections.Generic.IEnumerator`1, System.IDisposable, System.Collections.IEnumerator
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>> <>2__current;  // 0x18
        public System.Net.Http.Headers.HttpHeaders <>4__this;  // 0x28
        private System.Collections.Generic.Dictionary.Enumerator<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket> <>7__wrap1;  // 0x30

        // Properties
        System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; /* RVA: 0x03D51D80 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x098444F0 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000147
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09844538  token: 0x6000148
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09844108  token: 0x6000149
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x098445B0  token: 0x600014A
        private System.Void <>m__Finally1() { }
        // RVA: 0x098444A4  token: 0x600014C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000032  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.Headers.HttpRequestHeaders.<>c <>9;  // static @ 0x0
        public static System.Predicate<System.String> <>9__19_0;  // static @ 0x8
        public static System.Predicate<System.Net.Http.Headers.TransferCodingHeaderValue> <>9__29_0;  // static @ 0x10
        public static System.Predicate<System.Net.Http.Headers.TransferCodingHeaderValue> <>9__71_0;  // static @ 0x18

        // Methods
        // RVA: 0x098486A8  token: 0x6000158
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000159
        public System.Void .ctor() { }
        // RVA: 0x09848558  token: 0x600015A
        private System.Boolean <get_ConnectionClose>b__19_0(System.String l) { }
        // RVA: 0x0984859C  token: 0x600015B
        private System.Boolean <get_ExpectContinue>b__29_0(System.Net.Http.Headers.TransferCodingHeaderValue l) { }
        // RVA: 0x098485EC  token: 0x600015C
        private System.Boolean <get_TransferEncodingChunked>b__71_0(System.Net.Http.Headers.TransferCodingHeaderValue l) { }

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Net.Http.Headers.Token.Type Error;  // const
        public static System.Net.Http.Headers.Token.Type End;  // const
        public static System.Net.Http.Headers.Token.Type Token;  // const
        public static System.Net.Http.Headers.Token.Type QuotedString;  // const
        public static System.Net.Http.Headers.Token.Type SeparatorEqual;  // const
        public static System.Net.Http.Headers.Token.Type SeparatorSemicolon;  // const
        public static System.Net.Http.Headers.Token.Type SeparatorSlash;  // const
        public static System.Net.Http.Headers.Token.Type SeparatorDash;  // const
        public static System.Net.Http.Headers.Token.Type SeparatorComma;  // const
        public static System.Net.Http.Headers.Token.Type OpenParens;  // const

    }

    // TypeToken: 0x2000038  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.Headers.MediaTypeHeaderValue.<>c <>9;  // static @ 0x0
        public static System.Predicate<System.Net.Http.Headers.NameValueHeaderValue> <>9__6_0;  // static @ 0x8

        // Methods
        // RVA: 0x09848770  token: 0x6000189
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600018A
        public System.Void .ctor() { }
        // RVA: 0x09848508  token: 0x600018B
        private System.Boolean <get_CharSet>b__6_0(System.Net.Http.Headers.NameValueHeaderValue l) { }

    }

    // TypeToken: 0x200003D  // size: 0x10
    public static class Token
    {
        // Methods
        // RVA: 0x09843770  token: 0x60001A7
        public static System.Void Check(System.String s) { }
        // RVA: 0x098438EC  token: 0x60001A8
        public static System.Boolean TryCheck(System.String s) { }

    }

    // TypeToken: 0x200003F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.Headers.Parser.DateTime.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x09848838  token: 0x60001AB
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001AC
        public System.Void .ctor() { }
        // RVA: 0x09848418  token: 0x60001AD
        private System.String <.cctor>b__2_0(System.Object l) { }

    }

    // TypeToken: 0x200003E  // size: 0x10
    public static class DateTime
    {
        // Fields
        public static readonly System.Func<System.Object,System.String> ToString;  // static @ 0x0

        // Methods
        // RVA: 0x098352EC  token: 0x60001A9
        public static System.Boolean TryParse(System.String input, System.DateTimeOffset& result) { }
        // RVA: 0x09835348  token: 0x60001AA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x10
    public static class EmailAddress
    {
        // Methods
        // RVA: 0x0983540C  token: 0x60001AE
        public static System.Boolean TryParse(System.String input, System.String& result) { }

    }

    // TypeToken: 0x2000041  // size: 0x10
    public static class Host
    {
        // Methods
        // RVA: 0x09835DB4  token: 0x60001AF
        public static System.Boolean TryParse(System.String input, System.String& result) { }

    }

    // TypeToken: 0x2000042  // size: 0x10
    public static class Int
    {
        // Methods
        // RVA: 0x0983BC88  token: 0x60001B0
        public static System.Boolean TryParse(System.String input, System.Int32& result) { }

    }

    // TypeToken: 0x2000043  // size: 0x10
    public static class Long
    {
        // Methods
        // RVA: 0x0983C9C4  token: 0x60001B1
        public static System.Boolean TryParse(System.String input, System.Int64& result) { }

    }

    // TypeToken: 0x2000045  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly System.Net.Http.Headers.Parser.MD5.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x0984870C  token: 0x60001B4
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001B5
        public System.Void .ctor() { }
        // RVA: 0x098484AC  token: 0x60001B6
        private System.String <.cctor>b__2_0(System.Object l) { }

    }

    // TypeToken: 0x2000044  // size: 0x10
    public static class MD5
    {
        // Fields
        public static readonly System.Func<System.Object,System.String> ToString;  // static @ 0x0

        // Methods
        // RVA: 0x0983CA24  token: 0x60001B2
        public static System.Boolean TryParse(System.String input, System.Byte[]& result) { }
        // RVA: 0x0983CB08  token: 0x60001B3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x10
    public static class TimeSpanSeconds
    {
        // Methods
        // RVA: 0x098436DC  token: 0x60001B7
        public static System.Boolean TryParse(System.String input, System.TimeSpan& result) { }

    }

    // TypeToken: 0x2000047  // size: 0x10
    public static class Uri
    {
        // Methods
        // RVA: 0x0984889C  token: 0x60001B8
        public static System.Boolean TryParse(System.String input, System.Uri& result) { }

    }

    // TypeToken: 0x2000054  // size: 0x8F
    public sealed struct __StaticArrayInitTypeSize=127
    {
    }

    // TypeToken: 0x2000053  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729;  // static @ 0x0

        // Methods
        // RVA: 0x056516CC  token: 0x600022F
        private static System.UInt32 ComputeStringHash(System.String s) { }

    }

namespace System.Net.Http
{

    // TypeToken: 0x2000002  // size: 0x20
    public class HttpClientHandler : System.Net.Http.HttpMessageHandler
    {
        // Fields
        private readonly System.Net.Http.IMonoHttpClientHandler _delegatingHandler;  // 0x10
        private System.Net.Http.ClientCertificateOption _clientCertificateOptions;  // 0x18

        // Properties
        System.Net.Http.ClientCertificateOption ClientCertificateOptions { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x098361FC */ }
        System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; /* RVA: 0x098360CC */ }

        // Methods
        // RVA: 0x09835E50  token: 0x6000001
        private static System.Net.Http.IMonoHttpClientHandler CreateDefaultHandler() { }
        // RVA: 0x098360A8  token: 0x6000002
        public System.Void .ctor() { }
        // RVA: 0x09836080  token: 0x6000003
        private System.Void .ctor(System.Net.Http.IMonoHttpClientHandler handler) { }
        // RVA: 0x09835EA0  token: 0x6000004
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x09835FEC  token: 0x6000005
        private System.Void ThrowForModifiedManagedSslOptionsIfStarted() { }
        // RVA: 0x09835F7C  token: 0x6000009
        private System.Void SetWebRequestTimeout(System.TimeSpan timeout) { }
        // RVA: 0x09835EF8  token: 0x600000A
        protected internal virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x09836064  token: 0x600000B
        private System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_0(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x2000004
    public interface IMonoHttpClientHandler : System.IDisposable
    {
        // Properties
        System.Net.Security.SslClientAuthenticationOptions SslOptions { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000011
        public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        // RVA: -1  // abstract  token: 0x6000012
        public virtual System.Void SetWebRequestTimeout(System.TimeSpan timeout) { }

    }

    // TypeToken: 0x2000005  // size: 0xB8
    public class MonoWebRequestHandler : System.Net.Http.IMonoHttpClientHandler, System.IDisposable
    {
        // Fields
        private static System.Int64 groupCounter;  // static @ 0x0
        private System.Boolean allowAutoRedirect;  // 0x10
        private System.Net.DecompressionMethods automaticDecompression;  // 0x14
        private System.Net.CookieContainer cookieContainer;  // 0x18
        private System.Net.ICredentials credentials;  // 0x20
        private System.Int32 maxAutomaticRedirections;  // 0x28
        private System.Int64 maxRequestContentBufferSize;  // 0x30
        private System.Boolean preAuthenticate;  // 0x38
        private System.Net.IWebProxy proxy;  // 0x40
        private System.Boolean useCookies;  // 0x48
        private System.Boolean useProxy;  // 0x49
        private System.Net.Security.SslClientAuthenticationOptions sslOptions;  // 0x50
        private System.Boolean allowPipelining;  // 0x58
        private System.Net.Cache.RequestCachePolicy cachePolicy;  // 0x60
        private System.Net.Security.AuthenticationLevel authenticationLevel;  // 0x68
        private System.TimeSpan continueTimeout;  // 0x70
        private System.Security.Principal.TokenImpersonationLevel impersonationLevel;  // 0x78
        private System.Int32 maxResponseHeadersLength;  // 0x7c
        private System.Int32 readWriteTimeout;  // 0x80
        private System.Net.Security.RemoteCertificateValidationCallback serverCertificateValidationCallback;  // 0x88
        private System.Boolean unsafeAuthenticatedConnectionSharing;  // 0x90
        private System.Boolean sentRequest;  // 0x91
        private System.String connectionGroupName;  // 0x98
        private System.Nullable<System.TimeSpan> timeout;  // 0xa0
        private System.Boolean disposed;  // 0xb0

        // Properties
        System.Net.CookieContainer CookieContainer { get; /* RVA: 0x0983E918 */ }
        System.Int64 MaxRequestContentBufferSize { get; /* RVA: 0x01003830 */ }
        System.Net.Security.SslClientAuthenticationOptions SslOptions { get; /* RVA: 0x0983E98C */ set; /* RVA: 0x0983E9F0 */ }

        // Methods
        // RVA: 0x0983E7C4  token: 0x6000013
        public System.Void .ctor() { }
        // RVA: 0x0983E3F4  token: 0x6000014
        private System.Void EnsureModifiability() { }
        // RVA: 0x0983E3E8  token: 0x6000019
        public virtual System.Void Dispose() { }
        // RVA: 0x0983E378  token: 0x600001A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0983E460  token: 0x600001B
        private System.Boolean GetConnectionKeepAlive(System.Net.Http.Headers.HttpRequestHeaders headers) { }
        // RVA: 0x0983DB58  token: 0x600001C
        private virtual System.Net.HttpWebRequest CreateWebRequest(System.Net.Http.HttpRequestMessage request) { }
        // RVA: 0x0983D9BC  token: 0x600001D
        private System.Net.Http.HttpResponseMessage CreateResponseMessage(System.Net.HttpWebResponse wr, System.Net.Http.HttpRequestMessage requestMessage, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0983E580  token: 0x600001E
        private static System.Boolean MethodHasBody(System.Net.Http.HttpMethod method) { }
        // RVA: 0x0983E660  token: 0x600001F
        public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0983E76C  token: 0x6000020
        private virtual System.Void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(System.TimeSpan timeout) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class PlatformHelper
    {
        // Methods
        // RVA: 0x09840AC8  token: 0x6000028
        private static System.Boolean IsContentHeader(System.String name) { }
        // RVA: 0x09840A6C  token: 0x6000029
        private static System.String GetSingleHeaderString(System.String name, System.Collections.Generic.IEnumerable<System.String> values) { }
        // RVA: 0x098409FC  token: 0x600002A
        private static System.Net.Http.StreamContent CreateStreamContent(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000009  // size: 0x38
    public class ByteArrayContent : System.Net.Http.HttpContent
    {
        // Fields
        private readonly System.Byte[] content;  // 0x28
        private readonly System.Int32 offset;  // 0x30
        private readonly System.Int32 count;  // 0x34

        // Methods
        // RVA: 0x0983215C  token: 0x600002B
        public System.Void .ctor(System.Byte[] content) { }
        // RVA: 0x09832128  token: 0x600002C
        protected virtual System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: 0x03D755A0  token: 0x600002D
        protected internal virtual System.Boolean TryComputeLength(System.Int64& length) { }

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct ClientCertificateOption
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Net.Http.ClientCertificateOption Manual;  // const
        public static System.Net.Http.ClientCertificateOption Automatic;  // const

    }

    // TypeToken: 0x200000B  // size: 0x50
    public class HttpClient : System.Net.Http.HttpMessageInvoker
    {
        // Fields
        private static readonly System.TimeSpan TimeoutDefault;  // static @ 0x0
        private System.Uri base_address;  // 0x20
        private System.Threading.CancellationTokenSource cts;  // 0x28
        private System.Boolean disposed;  // 0x30
        private System.Net.Http.Headers.HttpRequestHeaders headers;  // 0x38
        private System.Int64 buffer_size;  // 0x40
        private System.TimeSpan timeout;  // 0x48

        // Properties
        System.Net.Http.Headers.HttpRequestHeaders DefaultRequestHeaders { get; /* RVA: 0x09836B94 */ }
        System.Int64 MaxResponseContentBufferSize { get; /* RVA: 0x03D4E2B0 */ }

        // Methods
        // RVA: 0x09836B2C  token: 0x600002E
        public System.Void .ctor() { }
        // RVA: 0x09836A68  token: 0x600002F
        public System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler) { }
        // RVA: 0x098363E4  token: 0x6000032
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x09836444  token: 0x6000033
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.String requestUri, System.Net.Http.HttpContent content) { }
        // RVA: 0x0983664C  token: 0x6000034
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request) { }
        // RVA: 0x098369E0  token: 0x6000035
        public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x098366A8  token: 0x6000036
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x09836534  token: 0x6000037
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsyncWorker(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x09836A08  token: 0x6000038
        private static System.Void .cctor() { }
        // RVA: 0x09836A00  token: 0x6000039
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> <>n__0(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct HttpCompletionOption
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Net.Http.HttpCompletionOption ResponseContentRead;  // const
        public static System.Net.Http.HttpCompletionOption ResponseHeadersRead;  // const

    }

    // TypeToken: 0x200000E  // size: 0x28
    public abstract class HttpContent : System.IDisposable
    {
        // Fields
        private System.Net.Http.HttpContent.FixedMemoryStream buffer;  // 0x10
        private System.Boolean disposed;  // 0x18
        private System.Net.Http.Headers.HttpContentHeaders headers;  // 0x20

        // Properties
        System.Net.Http.Headers.HttpContentHeaders Headers { get; /* RVA: 0x098373D0 */ }
        System.Nullable<System.Int64> LoadedBufferLength { get; /* RVA: 0x09837448 */ }

        // Methods
        // RVA: 0x09836F54  token: 0x600003E
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream) { }
        // RVA: 0x09836F60  token: 0x600003F
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: 0x09836FF0  token: 0x6000040
        private static System.Net.Http.HttpContent.FixedMemoryStream CreateFixedMemoryStream(System.Int64 maxBufferSize) { }
        // RVA: 0x09837078  token: 0x6000041
        public virtual System.Void Dispose() { }
        // RVA: 0x09837050  token: 0x6000042
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x09837280  token: 0x6000043
        public System.Threading.Tasks.Task LoadIntoBufferAsync() { }
        // RVA: 0x098371B8  token: 0x6000044
        public System.Threading.Tasks.Task LoadIntoBufferAsync(System.Int64 maxBufferSize) { }
        // RVA: 0x09837290  token: 0x6000045
        public System.Threading.Tasks.Task<System.String> ReadAsStringAsync() { }
        // RVA: 0x09837088  token: 0x6000046
        private static System.Text.Encoding GetEncodingFromBuffer(System.Byte[] buffer, System.Int32 length, System.Int32& preambleLength) { }
        // RVA: 0x09837374  token: 0x6000047
        private static System.Int32 StartsWith(System.Byte[] array, System.Int32 length, System.Byte[] value) { }
        // RVA: 0x09837364  token: 0x6000048
        private System.Threading.Tasks.Task SerializeToStreamAsync_internal(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: -1  // abstract  token: 0x6000049
        protected virtual System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: -1  // abstract  token: 0x600004A
        protected internal virtual System.Boolean TryComputeLength(System.Int64& length) { }
        // RVA: 0x0350B670  token: 0x600004B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public abstract class HttpMessageHandler : System.IDisposable
    {
        // Methods
        // RVA: 0x09837078  token: 0x6000054
        public virtual System.Void Dispose() { }
        // RVA: 0x0350B670  token: 0x6000055
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: -1  // abstract  token: 0x6000056
        protected internal virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0350B670  token: 0x6000057
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x20
    public class HttpMessageInvoker : System.IDisposable
    {
        // Fields
        private System.Net.Http.HttpMessageHandler handler;  // 0x10
        private readonly System.Boolean disposeHandler;  // 0x18

        // Methods
        // RVA: 0x0983A3B4  token: 0x6000058
        public System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler) { }
        // RVA: 0x09837078  token: 0x6000059
        public virtual System.Void Dispose() { }
        // RVA: 0x0983A324  token: 0x600005A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0983A35C  token: 0x600005B
        public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000014  // size: 0x18
    public class HttpMethod : System.IEquatable`1
    {
        // Fields
        private static readonly System.Net.Http.HttpMethod delete_method;  // static @ 0x0
        private static readonly System.Net.Http.HttpMethod get_method;  // static @ 0x8
        private static readonly System.Net.Http.HttpMethod head_method;  // static @ 0x10
        private static readonly System.Net.Http.HttpMethod options_method;  // static @ 0x18
        private static readonly System.Net.Http.HttpMethod post_method;  // static @ 0x20
        private static readonly System.Net.Http.HttpMethod put_method;  // static @ 0x28
        private static readonly System.Net.Http.HttpMethod trace_method;  // static @ 0x30
        private readonly System.String method;  // 0x10

        // Properties
        System.String Method { get; /* RVA: 0x020B7B20 */ }
        System.Net.Http.HttpMethod Post { get; /* RVA: 0x0983A808 */ }

        // Methods
        // RVA: 0x0983A778  token: 0x600005C
        public System.Void .ctor(System.String method) { }
        // RVA: 0x0983A858  token: 0x600005F
        public static System.Boolean op_Equality(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { }
        // RVA: 0x0983A430  token: 0x6000060
        public virtual System.Boolean Equals(System.Net.Http.HttpMethod other) { }
        // RVA: 0x0983A45C  token: 0x6000061
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x06FAB9A8  token: 0x6000062
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x020B7B20  token: 0x6000063
        public virtual System.String ToString() { }
        // RVA: 0x0983A4B8  token: 0x6000064
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x90
    public class HttpRequestException : System.Exception
    {
        // Methods
        // RVA: 0x0983A874  token: 0x6000065
        public System.Void .ctor() { }
        // RVA: 0x0983A8C0  token: 0x6000066
        public System.Void .ctor(System.String message) { }
        // RVA: 0x0983A91C  token: 0x6000067
        public System.Void .ctor(System.String message, System.Exception inner) { }

    }

    // TypeToken: 0x2000016  // size: 0x40
    public class HttpRequestMessage : System.IDisposable
    {
        // Fields
        private System.Net.Http.Headers.HttpRequestHeaders headers;  // 0x10
        private System.Net.Http.HttpMethod method;  // 0x18
        private System.Version version;  // 0x20
        private System.Uri uri;  // 0x28
        private System.Boolean is_used;  // 0x30
        private System.Boolean disposed;  // 0x31
        private System.Net.Http.HttpContent <Content>k__BackingField;  // 0x38

        // Properties
        System.Net.Http.HttpContent Content { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        System.Net.Http.Headers.HttpRequestHeaders Headers { get; /* RVA: 0x0983B67C */ }
        System.Net.Http.HttpMethod Method { get; /* RVA: 0x01041090 */ set; /* RVA: 0x0983B744 */ }
        System.Uri RequestUri { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x0983B7EC */ }
        System.Version Version { get; /* RVA: 0x0983B6F0 */ }

        // Methods
        // RVA: 0x0983B5B4  token: 0x6000068
        public System.Void .ctor(System.Net.Http.HttpMethod method, System.String requestUri) { }
        // RVA: 0x0983B64C  token: 0x6000069
        public System.Void .ctor(System.Net.Http.HttpMethod method, System.Uri requestUri) { }
        // RVA: 0x0983B228  token: 0x6000071
        private static System.Boolean IsAllowedAbsoluteUri(System.Uri uri) { }
        // RVA: 0x0983B1F0  token: 0x6000073
        public virtual System.Void Dispose() { }
        // RVA: 0x0983B1FC  token: 0x6000074
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0983B358  token: 0x6000075
        private System.Boolean SetIsUsed() { }
        // RVA: 0x0983B368  token: 0x6000076
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000017  // size: 0x48
    public class HttpResponseMessage : System.IDisposable
    {
        // Fields
        private System.Net.Http.Headers.HttpResponseHeaders headers;  // 0x10
        private System.String reasonPhrase;  // 0x18
        private System.Net.HttpStatusCode statusCode;  // 0x20
        private System.Version version;  // 0x28
        private System.Boolean disposed;  // 0x30
        private System.Net.Http.HttpContent <Content>k__BackingField;  // 0x38
        private System.Net.Http.HttpRequestMessage <RequestMessage>k__BackingField;  // 0x40

        // Properties
        System.Net.Http.HttpContent Content { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        System.Net.Http.Headers.HttpResponseHeaders Headers { get; /* RVA: 0x0983BB54 */ }
        System.String ReasonPhrase { get; /* RVA: 0x0983BBC8 */ set; /* RVA: 0x022C3A90 */ }
        System.Net.Http.HttpRequestMessage RequestMessage { set; /* RVA: 0x03CB2D80 */ }
        System.Net.HttpStatusCode StatusCode { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x0983BC30 */ }
        System.Version Version { get; /* RVA: 0x0983BBDC */ }

        // Methods
        // RVA: 0x0983BB4C  token: 0x6000077
        public System.Void .ctor(System.Net.HttpStatusCode statusCode) { }
        // RVA: 0x0983B900  token: 0x6000081
        public virtual System.Void Dispose() { }
        // RVA: 0x0983B90C  token: 0x6000082
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0983B938  token: 0x6000083
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000018  // size: 0x38
    public class MultipartContent : System.Net.Http.HttpContent, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.HttpContent> nested_content;  // 0x28
        private readonly System.String boundary;  // 0x30

        // Methods
        // RVA: 0x0983F30C  token: 0x6000084
        public System.Void .ctor(System.String subtype) { }
        // RVA: 0x0983F3A8  token: 0x6000085
        public System.Void .ctor(System.String subtype, System.String boundary) { }
        // RVA: 0x0983ED48  token: 0x6000086
        private static System.Boolean IsValidRFC2049(System.String s) { }
        // RVA: 0x0983EA20  token: 0x6000087
        public virtual System.Void Add(System.Net.Http.HttpContent content) { }
        // RVA: 0x0983EB20  token: 0x6000088
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0983EE00  token: 0x6000089
        protected virtual System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: 0x0983EF6C  token: 0x600008A
        protected internal virtual System.Boolean TryComputeLength(System.Int64& length) { }
        // RVA: 0x0983ECC8  token: 0x600008B
        public virtual System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator() { }
        // RVA: 0x0983EEEC  token: 0x600008C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200001A  // size: 0x38
    public class MultipartFormDataContent : System.Net.Http.MultipartContent
    {
        // Methods
        // RVA: 0x0983F9F8  token: 0x600008F
        public System.Void .ctor() { }
        // RVA: 0x0983F9B8  token: 0x6000090
        public virtual System.Void Add(System.Net.Http.HttpContent content) { }
        // RVA: 0x0983F7F4  token: 0x6000091
        public System.Void Add(System.Net.Http.HttpContent content, System.String name) { }
        // RVA: 0x0983F8A0  token: 0x6000092
        public System.Void Add(System.Net.Http.HttpContent content, System.String name, System.String fileName) { }
        // RVA: 0x0983F708  token: 0x6000093
        private System.Void AddContentDisposition(System.Net.Http.HttpContent content, System.String name, System.String fileName) { }

    }

    // TypeToken: 0x200001B  // size: 0x50
    public class StreamContent : System.Net.Http.HttpContent
    {
        // Fields
        private readonly System.IO.Stream content;  // 0x28
        private readonly System.Int32 bufferSize;  // 0x30
        private readonly System.Threading.CancellationToken cancellationToken;  // 0x38
        private readonly System.Int64 startPosition;  // 0x40
        private System.Boolean contentCopied;  // 0x48

        // Methods
        // RVA: 0x09842FA0  token: 0x6000094
        public System.Void .ctor(System.IO.Stream content) { }
        // RVA: 0x09842E9C  token: 0x6000095
        public System.Void .ctor(System.IO.Stream content, System.Int32 bufferSize) { }
        // RVA: 0x09842FB0  token: 0x6000096
        private System.Void .ctor(System.IO.Stream content, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x09842D24  token: 0x6000097
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x09842D6C  token: 0x6000098
        protected virtual System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        // RVA: 0x09842E40  token: 0x6000099
        protected internal virtual System.Boolean TryComputeLength(System.Int64& length) { }

    }

    // TypeToken: 0x200001C  // size: 0x38
    public class StringContent : System.Net.Http.ByteArrayContent
    {
        // Methods
        // RVA: 0x09843020  token: 0x600009A
        public System.Void .ctor(System.String content) { }
        // RVA: 0x09843040  token: 0x600009B
        public System.Void .ctor(System.String content, System.Text.Encoding encoding, System.String mediaType) { }
        // RVA: 0x09842FE8  token: 0x600009C
        private static System.Byte[] GetByteArray(System.String content, System.Text.Encoding encoding) { }

    }

}

namespace System.Net.Http.Headers
{

    // TypeToken: 0x200001D  // size: 0x20
    public class AuthenticationHeaderValue : System.ICloneable
    {
        // Fields
        private System.String <Parameter>k__BackingField;  // 0x10
        private System.String <Scheme>k__BackingField;  // 0x18

        // Properties
        System.String Parameter { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String Scheme { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x098320DC  token: 0x600009D
        public System.Void .ctor(System.String scheme, System.String parameter) { }
        // RVA: 0x0350B670  token: 0x600009E
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60000A3
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09831C84  token: 0x60000A4
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09831D00  token: 0x60000A5
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09831F70  token: 0x60000A6
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue) { }
        // RVA: 0x0983202C  token: 0x60000A7
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.AuthenticationHeaderValue>& result) { }
        // RVA: 0x09831DC0  token: 0x60000A8
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x09831D74  token: 0x60000A9
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200001E  // size: 0x78
    public class CacheControlHeaderValue : System.ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> extensions;  // 0x10
        private System.Collections.Generic.List<System.String> no_cache_headers;  // 0x18
        private System.Collections.Generic.List<System.String> private_headers;  // 0x20
        private System.Nullable<System.TimeSpan> <MaxAge>k__BackingField;  // 0x28
        private System.Boolean <MaxStale>k__BackingField;  // 0x38
        private System.Nullable<System.TimeSpan> <MaxStaleLimit>k__BackingField;  // 0x40
        private System.Nullable<System.TimeSpan> <MinFresh>k__BackingField;  // 0x50
        private System.Boolean <MustRevalidate>k__BackingField;  // 0x60
        private System.Boolean <NoCache>k__BackingField;  // 0x61
        private System.Boolean <NoStore>k__BackingField;  // 0x62
        private System.Boolean <NoTransform>k__BackingField;  // 0x63
        private System.Boolean <OnlyIfCached>k__BackingField;  // 0x64
        private System.Boolean <Private>k__BackingField;  // 0x65
        private System.Boolean <ProxyRevalidate>k__BackingField;  // 0x66
        private System.Boolean <Public>k__BackingField;  // 0x67
        private System.Nullable<System.TimeSpan> <SharedMaxAge>k__BackingField;  // 0x68

        // Properties
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Extensions { get; /* RVA: 0x098339B4 */ }
        System.Nullable<System.TimeSpan> MaxAge { get; /* RVA: 0x03D59E20 */ set; /* RVA: 0x03D59E30 */ }
        System.Boolean MaxStale { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Nullable<System.TimeSpan> MaxStaleLimit { get; /* RVA: 0x03D5A160 */ set; /* RVA: 0x03D5D610 */ }
        System.Nullable<System.TimeSpan> MinFresh { get; /* RVA: 0x03D55950 */ set; /* RVA: 0x03D5A610 */ }
        System.Boolean MustRevalidate { get; /* RVA: 0x03D519A0 */ set; /* RVA: 0x03D519B0 */ }
        System.Boolean NoCache { get; /* RVA: 0x03D51F90 */ set; /* RVA: 0x03D5B410 */ }
        System.Collections.Generic.ICollection<System.String> NoCacheHeaders { get; /* RVA: 0x09833A38 */ }
        System.Boolean NoStore { get; /* RVA: 0x03D5B400 */ set; /* RVA: 0x03D5B420 */ }
        System.Boolean NoTransform { get; /* RVA: 0x03D5B3F0 */ set; /* RVA: 0x03D755C0 */ }
        System.Boolean OnlyIfCached { get; /* RVA: 0x03D590F0 */ set; /* RVA: 0x03D59100 */ }
        System.Boolean Private { get; /* RVA: 0x03D5CA70 */ set; /* RVA: 0x03D6CF00 */ }
        System.Collections.Generic.ICollection<System.String> PrivateHeaders { get; /* RVA: 0x09833ABC */ }
        System.Boolean ProxyRevalidate { get; /* RVA: 0x03D5CAA0 */ set; /* RVA: 0x03D5CAB0 */ }
        System.Boolean Public { get; /* RVA: 0x03D755B0 */ set; /* RVA: 0x03D755D0 */ }
        System.Nullable<System.TimeSpan> SharedMaxAge { get; /* RVA: 0x03D5D750 */ set; /* RVA: 0x03D71AD0 */ }

        // Methods
        // RVA: 0x09832644  token: 0x60000C7
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x098321DC  token: 0x60000C8
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09832420  token: 0x60000C9
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098331BC  token: 0x60000CA
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.CacheControlHeaderValue& parsedValue) { }
        // RVA: 0x09832B78  token: 0x60000CB
        public virtual System.String ToString() { }
        // RVA: 0x0350B670  token: 0x60000CC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x10
    public static class CollectionExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000CD
        public static System.Boolean SequenceEqual(System.Collections.Generic.List<TSource> first, System.Collections.Generic.List<TSource> second) { }
        // RVA: 0x09833B40  token: 0x60000CE
        public static System.Void SetValue(System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters, System.String key, System.String value) { }
        // RVA: -1  // generic def  token: 0x60000CF
        public static System.String ToString(System.Collections.Generic.List<T> list) { }
        // RVA: -1  // generic def  token: 0x60000D0
        public static System.Void ToStringBuilder(System.Collections.Generic.List<T> list, System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000020
    public sealed class ElementTryParser`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x60000D1
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x60000D2
        public virtual System.Boolean Invoke(System.Net.Http.Headers.Lexer lexer, T& parsedValue, System.Net.Http.Headers.Token& token) { }

    }

    // TypeToken: 0x2000021  // size: 0x10
    public static class CollectionParser
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000D3
        public static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Net.Http.Headers.ElementTryParser<T> parser, System.Collections.Generic.List<T>& result) { }
        // RVA: 0x09833D90  token: 0x60000D4
        public static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.String>& result) { }
        // RVA: 0x09833C88  token: 0x60000D5
        private static System.Boolean TryParseStringElement(System.Net.Http.Headers.Lexer lexer, System.String& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000022  // size: 0x20
    public class ContentDispositionHeaderValue : System.ICloneable
    {
        // Fields
        private System.String dispositionType;  // 0x10
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;  // 0x18

        // Properties
        System.String DispositionType { set; /* RVA: 0x09834944 */ }
        System.String FileName { set; /* RVA: 0x098349D8 */ }
        System.String FileNameStar { set; /* RVA: 0x09834978 */ }
        System.String Name { set; /* RVA: 0x09834A38 */ }
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get; /* RVA: 0x098348C0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000D6
        private System.Void .ctor() { }
        // RVA: 0x098348B8  token: 0x60000D7
        public System.Void .ctor(System.String dispositionType) { }
        // RVA: 0x098345DC  token: 0x60000D8
        protected System.Void .ctor(System.Net.Http.Headers.ContentDispositionHeaderValue source) { }
        // RVA: 0x09834398  token: 0x60000DE
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x098341F4  token: 0x60000DF
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09833E40  token: 0x60000E0
        private static System.String EncodeBase64Value(System.String value) { }
        // RVA: 0x09833FCC  token: 0x60000E1
        private static System.String EncodeRFC5987(System.String value) { }
        // RVA: 0x09834280  token: 0x60000E2
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098342F0  token: 0x60000E3
        private System.Void SetValue(System.String key, System.String value) { }
        // RVA: 0x098343F8  token: 0x60000E4
        public virtual System.String ToString() { }
        // RVA: 0x09834450  token: 0x60000E5
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentDispositionHeaderValue& parsedValue) { }

    }

    // TypeToken: 0x2000023  // size: 0x48
    public class ContentRangeHeaderValue : System.ICloneable
    {
        // Fields
        private System.String unit;  // 0x10
        private System.Nullable<System.Int64> <From>k__BackingField;  // 0x18
        private System.Nullable<System.Int64> <Length>k__BackingField;  // 0x28
        private System.Nullable<System.Int64> <To>k__BackingField;  // 0x38

        // Properties
        System.Nullable<System.Int64> From { get; /* RVA: 0x03D51D80 */ set; /* RVA: 0x03D51D90 */ }
        System.Nullable<System.Int64> Length { get; /* RVA: 0x03D59E20 */ set; /* RVA: 0x03D59E30 */ }
        System.Nullable<System.Int64> To { get; /* RVA: 0x03D5A120 */ set; /* RVA: 0x03D5C3C0 */ }
        System.String Unit { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x098352AC  token: 0x60000E6
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60000EE
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09834A98  token: 0x60000EF
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09834B74  token: 0x60000F0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09834E7C  token: 0x60000F1
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentRangeHeaderValue& parsedValue) { }
        // RVA: 0x09834C6C  token: 0x60000F2
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000024  // size: 0x20
    public class EntityTagHeaderValue : System.ICloneable
    {
        // Fields
        private static readonly System.Net.Http.Headers.EntityTagHeaderValue any;  // static @ 0x0
        private System.Boolean <IsWeak>k__BackingField;  // 0x10
        private System.String <Tag>k__BackingField;  // 0x18

        // Properties
        System.Boolean IsWeak { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.String Tag { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000F3
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60000F8
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x098354FC  token: 0x60000F9
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09835578  token: 0x60000FA
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0983586C  token: 0x60000FB
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue) { }
        // RVA: 0x09835630  token: 0x60000FC
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x09835940  token: 0x60000FD
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.EntityTagHeaderValue>& result) { }
        // RVA: 0x098355E8  token: 0x60000FE
        public virtual System.String ToString() { }
        // RVA: 0x098359F0  token: 0x60000FF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x10
    public static class HashCodeCalculator
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000100
        public static System.Int32 Calculate(System.Collections.Generic.ICollection<T> list) { }

    }

    // TypeToken: 0x2000026
    public sealed class TryParseDelegate`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000101
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000102
        public virtual System.Boolean Invoke(System.String value, T& result) { }

    }

    // TypeToken: 0x2000027
    public sealed class TryParseListDelegate`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000103
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000104
        public virtual System.Boolean Invoke(System.String value, System.Int32 minimalCount, System.Collections.Generic.List<T>& result) { }

    }

    // TypeToken: 0x2000028  // size: 0x28
    public abstract class HeaderInfo
    {
        // Fields
        public System.Boolean AllowsMany;  // 0x10
        public readonly System.Net.Http.Headers.HttpHeaderKind HeaderKind;  // 0x14
        public readonly System.String Name;  // 0x18
        private System.Func<System.Object,System.String> <CustomToString>k__BackingField;  // 0x20

        // Properties
        System.Func<System.Object,System.String> CustomToString { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String Separator { get; /* RVA: 0x09835D68 */ }

        // Methods
        // RVA: 0x09835D48  token: 0x6000105
        protected System.Void .ctor(System.String name, System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        // RVA: -1  // generic def  token: 0x6000106
        public static System.Net.Http.Headers.HeaderInfo CreateSingle(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Func<System.Object,System.String> toString) { }
        // RVA: -1  // generic def  token: 0x6000107
        public static System.Net.Http.Headers.HeaderInfo CreateMulti(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> elementParser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator) { }
        // RVA: 0x09835D08  token: 0x6000108
        public System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers) { }
        // RVA: -1  // abstract  token: 0x600010C
        public virtual System.Void AddToCollection(System.Object collection, System.Object value) { }
        // RVA: -1  // abstract  token: 0x600010D
        protected virtual System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        // RVA: -1  // abstract  token: 0x600010E
        public virtual System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection) { }
        // RVA: -1  // abstract  token: 0x600010F
        public virtual System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002B  // size: 0x28
    public sealed class HttpContentHeaders : System.Net.Http.Headers.HttpHeaders
    {
        // Fields
        private readonly System.Net.Http.HttpContent content;  // 0x20

        // Properties
        System.Net.Http.Headers.ContentDispositionHeaderValue ContentDisposition { get; /* RVA: 0x09836C68 */ set; /* RVA: 0x09836E24 */ }
        System.Nullable<System.Int64> ContentLength { get; /* RVA: 0x09836CB4 */ set; /* RVA: 0x09836E88 */ }
        System.Net.Http.Headers.MediaTypeHeaderValue ContentType { get; /* RVA: 0x09836DD8 */ set; /* RVA: 0x09836EF0 */ }

        // Methods
        // RVA: 0x09836C08  token: 0x6000118
        private System.Void .ctor(System.Net.Http.HttpContent content) { }

    }

    // TypeToken: 0x200002C  // size: 0x14
    public sealed struct HttpHeaderKind
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Net.Http.Headers.HttpHeaderKind None;  // const
        public static System.Net.Http.Headers.HttpHeaderKind Request;  // const
        public static System.Net.Http.Headers.HttpHeaderKind Response;  // const
        public static System.Net.Http.Headers.HttpHeaderKind Content;  // const

    }

    // TypeToken: 0x200002D
    public sealed class HttpHeaderValueCollection`1 : System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<T> list;  // 0x0
        private readonly System.Net.Http.Headers.HttpHeaders headers;  // 0x0
        private readonly System.Net.Http.Headers.HeaderInfo headerInfo;  // 0x0
        private System.Collections.Generic.List<System.String> invalidValues;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.List<System.String> InvalidValues { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600011F
        private System.Void .ctor(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        // RVA: -1  // not resolved  token: 0x6000123
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000124
        private System.Void AddRange(System.Collections.Generic.List<T> values) { }
        // RVA: -1  // not resolved  token: 0x6000125
        private System.Void AddInvalidValue(System.String invalidValue) { }
        // RVA: -1  // not resolved  token: 0x6000126
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000127
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000128
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000129
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x600012A
        public virtual System.String ToString() { }
        // RVA: -1  // not resolved  token: 0x600012B
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600012C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600012D
        private T Find(System.Predicate<T> predicate) { }

    }

    // TypeToken: 0x200002E  // size: 0x20
    public abstract class HttpHeaders : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HeaderInfo> known_headers;  // static @ 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket> headers;  // 0x10
        private readonly System.Net.Http.Headers.HttpHeaderKind HeaderKind;  // 0x18
        private System.Nullable<System.Boolean> connectionclose;  // 0x1c
        private System.Nullable<System.Boolean> transferEncodingChunked;  // 0x1e

        // Methods
        // RVA: 0x09838650  token: 0x600012E
        private static System.Void .cctor() { }
        // RVA: 0x0983A280  token: 0x600012F
        protected System.Void .ctor() { }
        // RVA: 0x0983A25C  token: 0x6000130
        private System.Void .ctor(System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        // RVA: 0x098374C4  token: 0x6000131
        private System.Boolean AddInternal(System.String name, System.Collections.Generic.IEnumerable<System.String> values, System.Net.Http.Headers.HeaderInfo headerInfo, System.Boolean ignoreInvalid) { }
        // RVA: 0x098384BC  token: 0x6000132
        public System.Boolean TryAddWithoutValidation(System.String name, System.Collections.Generic.IEnumerable<System.String> values) { }
        // RVA: 0x09837AAC  token: 0x6000133
        private System.Net.Http.Headers.HeaderInfo CheckName(System.String name) { }
        // RVA: 0x09838578  token: 0x6000134
        private System.Boolean TryCheckName(System.String name, System.Net.Http.Headers.HeaderInfo& headerInfo) { }
        // RVA: 0x09837D74  token: 0x6000135
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>> GetEnumerator() { }
        // RVA: 0x09838288  token: 0x6000136
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x09838224  token: 0x6000137
        public System.Boolean Remove(System.String name) { }
        // RVA: 0x09837EB8  token: 0x6000138
        private static System.String GetSingleHeaderString(System.String key, System.Collections.Generic.IEnumerable<System.String> values) { }
        // RVA: 0x09838290  token: 0x6000139
        public virtual System.String ToString() { }
        // RVA: -1  // generic def  token: 0x600013A
        private System.Void AddOrRemove(System.String name, T value, System.Func<System.Object,System.String> converter) { }
        // RVA: -1  // generic def  token: 0x600013B
        private System.Void AddOrRemove(System.String name, System.Nullable<T> value) { }
        // RVA: -1  // generic def  token: 0x600013C
        private System.Void AddOrRemove(System.String name, System.Nullable<T> value, System.Func<System.Object,System.String> converter) { }
        // RVA: 0x09837C14  token: 0x600013D
        private System.Collections.Generic.List<System.String> GetAllHeaderValues(System.Net.Http.Headers.HttpHeaders.HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        // RVA: 0x09837DD0  token: 0x600013E
        private static System.Net.Http.Headers.HttpHeaderKind GetKnownHeaderKind(System.String name) { }
        // RVA: -1  // generic def  token: 0x600013F
        private T GetValue(System.String name) { }
        // RVA: -1  // generic def  token: 0x6000140
        private System.Net.Http.Headers.HttpHeaderValueCollection<T> GetValues(System.String name) { }
        // RVA: -1  // generic def  token: 0x6000141
        private System.Void SetValue(System.String name, T value, System.Func<System.Object,System.String> toStringConverter) { }

    }

    // TypeToken: 0x2000031  // size: 0x28
    public sealed class HttpRequestHeaders : System.Net.Http.Headers.HttpHeaders
    {
        // Fields
        private System.Nullable<System.Boolean> expectContinue;  // 0x20

        // Properties
        System.Net.Http.Headers.AuthenticationHeaderValue Authorization { set; /* RVA: 0x0983B0A8 */ }
        System.Net.Http.Headers.HttpHeaderValueCollection<System.String> Connection { get; /* RVA: 0x0983ACFC */ }
        System.Nullable<System.Boolean> ConnectionClose { get; /* RVA: 0x0983AB84 */ set; /* RVA: 0x0983B10C */ }
        System.Nullable<System.Boolean> ExpectContinue { get; /* RVA: 0x0983AD48 */ }
        System.String Host { get; /* RVA: 0x0983AEAC */ }
        System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get; /* RVA: 0x0983B05C */ }
        System.Nullable<System.Boolean> TransferEncodingChunked { get; /* RVA: 0x0983AEF8 */ }

        // Methods
        // RVA: 0x0983AB30  token: 0x600014E
        private System.Void .ctor() { }
        // RVA: 0x0983A97C  token: 0x6000157
        private System.Void AddHeaders(System.Net.Http.Headers.HttpRequestHeaders headers) { }

    }

    // TypeToken: 0x2000033  // size: 0x20
    public sealed class HttpResponseHeaders : System.Net.Http.Headers.HttpHeaders
    {
        // Methods
        // RVA: 0x0983B8AC  token: 0x600015D
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x1C
    public sealed struct Token
    {
        // Fields
        public static readonly System.Net.Http.Headers.Token Empty;  // static @ 0x0
        private readonly System.Net.Http.Headers.Token.Type type;  // 0x10
        private System.Int32 <StartPosition>k__BackingField;  // 0x14
        private System.Int32 <EndPosition>k__BackingField;  // 0x18

        // Properties
        System.Int32 StartPosition { get; /* RVA: 0x03D4E990 */ set; /* RVA: 0x03D51720 */ }
        System.Int32 EndPosition { get; /* RVA: 0x03D516F0 */ set; /* RVA: 0x03D51710 */ }
        System.Net.Http.Headers.Token.Type Kind { get; /* RVA: 0x03D4E980 */ }

        // Methods
        // RVA: 0x098439A4  token: 0x600015E
        public System.Void .ctor(System.Net.Http.Headers.Token.Type type, System.Int32 startPosition, System.Int32 endPosition) { }
        // RVA: 0x03D4E980  token: 0x6000164
        public static System.Net.Http.Headers.Token.Type op_Implicit(System.Net.Http.Headers.Token token) { }
        // RVA: 0x0984389C  token: 0x6000165
        public virtual System.String ToString() { }
        // RVA: 0x0984393C  token: 0x6000166
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x20
    public class Lexer
    {
        // Fields
        private static readonly System.Boolean[] token_chars;  // static @ 0x0
        private static readonly System.Int32 last_token_char;  // static @ 0x8
        private static readonly System.String[] dt_formats;  // static @ 0x10
        private readonly System.String s;  // 0x10
        private System.Int32 pos;  // 0x18

        // Properties
        System.Int32 Position { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000167
        public System.Void .ctor(System.String stream) { }
        // RVA: 0x0983BDFC  token: 0x600016A
        public System.String GetStringValue(System.Net.Http.Headers.Token token) { }
        // RVA: 0x0983BD88  token: 0x600016B
        public System.String GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end) { }
        // RVA: 0x0983BCE8  token: 0x600016C
        public System.String GetQuotedStringValue(System.Net.Http.Headers.Token start) { }
        // RVA: 0x0983BD58  token: 0x600016D
        public System.String GetRemainingStringValue(System.Int32 position) { }
        // RVA: 0x0983BE64  token: 0x600016E
        public System.Boolean IsStarStringValue(System.Net.Http.Headers.Token token) { }
        // RVA: 0x0983C630  token: 0x600016F
        public System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int32& value) { }
        // RVA: 0x0983C6C4  token: 0x6000170
        public System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int64& value) { }
        // RVA: 0x0983C758  token: 0x6000171
        public System.Nullable<System.TimeSpan> TryGetTimeSpanValue(System.Net.Http.Headers.Token token) { }
        // RVA: 0x0983C400  token: 0x6000172
        public System.Boolean TryGetDateValue(System.Net.Http.Headers.Token token, System.DateTimeOffset& value) { }
        // RVA: 0x0983C4D8  token: 0x6000173
        public static System.Boolean TryGetDateValue(System.String text, System.DateTimeOffset& value) { }
        // RVA: 0x0983C59C  token: 0x6000174
        public System.Boolean TryGetDoubleValue(System.Net.Http.Headers.Token token, System.Double& value) { }
        // RVA: 0x0983BF6C  token: 0x6000175
        public static System.Boolean IsValidToken(System.String input) { }
        // RVA: 0x0983BEE8  token: 0x6000176
        public static System.Boolean IsValidCharacter(System.Char input) { }
        // RVA: 0x03D68050  token: 0x6000177
        public System.Void EatChar() { }
        // RVA: 0x0983BFF4  token: 0x6000178
        public System.Int32 PeekChar() { }
        // RVA: 0x0983C028  token: 0x6000179
        public System.Boolean ScanCommentOptional(System.String& value, System.Net.Http.Headers.Token& readToken) { }
        // RVA: 0x0983C150  token: 0x600017A
        public System.Net.Http.Headers.Token Scan(System.Boolean recognizeDash) { }
        // RVA: 0x0983C81C  token: 0x600017B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x20
    public class MediaTypeHeaderValue : System.ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;  // 0x10
        private System.String media_type;  // 0x18

        // Properties
        System.String CharSet { get; /* RVA: 0x0983D3B8 */ set; /* RVA: 0x0983D560 */ }
        System.String MediaType { set; /* RVA: 0x0983D60C */ }
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get; /* RVA: 0x0983D4DC */ }

        // Methods
        // RVA: 0x0983D3B0  token: 0x600017C
        public System.Void .ctor(System.String mediaType) { }
        // RVA: 0x0983D0D4  token: 0x600017D
        protected System.Void .ctor(System.Net.Http.Headers.MediaTypeHeaderValue source) { }
        // RVA: 0x0350B670  token: 0x600017E
        private System.Void .ctor() { }
        // RVA: 0x0983CCC8  token: 0x6000183
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x0983CBCC  token: 0x6000184
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0983CC58  token: 0x6000185
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0983CD28  token: 0x6000186
        public virtual System.String ToString() { }
        // RVA: 0x0983CF58  token: 0x6000187
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.MediaTypeHeaderValue& parsedValue) { }
        // RVA: 0x0983CD8C  token: 0x6000188
        private static System.Nullable<System.Net.Http.Headers.Token> TryParseMediaType(System.Net.Http.Headers.Lexer lexer, System.String& media) { }

    }

    // TypeToken: 0x2000039  // size: 0x20
    public sealed class MediaTypeWithQualityHeaderValue : System.Net.Http.Headers.MediaTypeHeaderValue
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600018C
        private System.Void .ctor() { }
        // RVA: 0x0983D798  token: 0x600018D
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x0983D90C  token: 0x600018E
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>& result) { }

    }

    // TypeToken: 0x200003A  // size: 0x20
    public class NameValueHeaderValue : System.ICloneable
    {
        // Fields
        private System.String value;  // 0x10
        private System.String <Name>k__BackingField;  // 0x18

        // Properties
        System.String Name { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String Value { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x098401F0 */ }

        // Methods
        // RVA: 0x098401A4  token: 0x600018F
        public System.Void .ctor(System.String name, System.String value) { }
        // RVA: 0x09840168  token: 0x6000190
        protected internal System.Void .ctor(System.Net.Http.Headers.NameValueHeaderValue source) { }
        // RVA: 0x0350B670  token: 0x6000191
        private System.Void .ctor() { }
        // RVA: 0x0983FA34  token: 0x6000196
        private static System.Net.Http.Headers.NameValueHeaderValue Create(System.String name, System.String value) { }
        // RVA: 0x0983FB50  token: 0x6000197
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09831D00  token: 0x6000198
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0983FAA4  token: 0x6000199
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x098400B8  token: 0x600019A
        private static System.Boolean TryParsePragma(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result) { }
        // RVA: 0x0983FE0C  token: 0x600019B
        private static System.Boolean TryParseParameters(System.Net.Http.Headers.Lexer lexer, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x0983FBB0  token: 0x600019C
        public virtual System.String ToString() { }
        // RVA: 0x0983FC14  token: 0x600019D
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x200003B  // size: 0x28
    public class NameValueWithParametersHeaderValue : System.Net.Http.Headers.NameValueHeaderValue, System.ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;  // 0x20

        // Properties
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get; /* RVA: 0x09840978 */ }

        // Methods
        // RVA: 0x09840828  token: 0x600019E
        protected System.Void .ctor(System.Net.Http.Headers.NameValueWithParametersHeaderValue source) { }
        // RVA: 0x0350B670  token: 0x600019F
        private System.Void .ctor() { }
        // RVA: 0x0984044C  token: 0x60001A1
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09840368  token: 0x60001A2
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x098403F8  token: 0x60001A3
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098404AC  token: 0x60001A4
        public virtual System.String ToString() { }
        // RVA: 0x09840778  token: 0x60001A5
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueWithParametersHeaderValue>& result) { }
        // RVA: 0x09840534  token: 0x60001A6
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueWithParametersHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x200003C  // size: 0x10
    public static class Parser
    {
    }

    // TypeToken: 0x2000048  // size: 0x20
    public class ProductHeaderValue : System.ICloneable
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.String <Version>k__BackingField;  // 0x18

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String Version { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60001B9
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60001BE
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09840B10  token: 0x60001BF
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09840B90  token: 0x60001C0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09840E30  token: 0x60001C1
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductHeaderValue>& result) { }
        // RVA: 0x09840C50  token: 0x60001C2
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x09840BFC  token: 0x60001C3
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000049  // size: 0x20
    public class ProductInfoHeaderValue : System.ICloneable
    {
        // Fields
        private System.String <Comment>k__BackingField;  // 0x10
        private System.Net.Http.Headers.ProductHeaderValue <Product>k__BackingField;  // 0x18

        // Properties
        System.String Comment { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Net.Http.Headers.ProductHeaderValue Product { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x09841318  token: 0x60001C4
        public System.Void .ctor(System.Net.Http.Headers.ProductHeaderValue product) { }
        // RVA: 0x0350B670  token: 0x60001C5
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60001CA
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09840EE0  token: 0x60001CB
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09840F54  token: 0x60001CC
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098411C8  token: 0x60001CD
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductInfoHeaderValue>& result) { }
        // RVA: 0x09840FAC  token: 0x60001CE
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductInfoHeaderValue& parsedValue) { }
        // RVA: 0x09840F84  token: 0x60001CF
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004A  // size: 0x30
    public class RangeConditionHeaderValue : System.ICloneable
    {
        // Fields
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;  // 0x10
        private System.Net.Http.Headers.EntityTagHeaderValue <EntityTag>k__BackingField;  // 0x28

        // Properties
        System.Nullable<System.DateTimeOffset> Date { get; /* RVA: 0x020B6BB0 */ set; /* RVA: 0x03D64DD0 */ }
        System.Net.Http.Headers.EntityTagHeaderValue EntityTag { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x09841864  token: 0x60001D0
        public System.Void .ctor(System.DateTimeOffset date) { }
        // RVA: 0x098418C4  token: 0x60001D1
        public System.Void .ctor(System.Net.Http.Headers.EntityTagHeaderValue entityTag) { }
        // RVA: 0x02A48500  token: 0x60001D6
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x0984137C  token: 0x60001D7
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09841480  token: 0x60001D8
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098415D0  token: 0x60001D9
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeConditionHeaderValue& parsedValue) { }
        // RVA: 0x098414EC  token: 0x60001DA
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004B  // size: 0x20
    public class RangeHeaderValue : System.ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.RangeItemHeaderValue> ranges;  // 0x10
        private System.String unit;  // 0x18

        // Properties
        System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> Ranges { get; /* RVA: 0x09842210 */ }
        System.String Unit { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x098421D0  token: 0x60001DB
        public System.Void .ctor() { }
        // RVA: 0x09842088  token: 0x60001DC
        private System.Void .ctor(System.Net.Http.Headers.RangeHeaderValue source) { }
        // RVA: 0x09841A34  token: 0x60001DF
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09841938  token: 0x60001E0
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x098419C4  token: 0x60001E1
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09841BB8  token: 0x60001E2
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeHeaderValue& parsedValue) { }
        // RVA: 0x09841A94  token: 0x60001E3
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004C  // size: 0x30
    public class RangeItemHeaderValue : System.ICloneable
    {
        // Fields
        private System.Nullable<System.Int64> <From>k__BackingField;  // 0x10
        private System.Nullable<System.Int64> <To>k__BackingField;  // 0x20

        // Properties
        System.Nullable<System.Int64> From { get; /* RVA: 0x020B7B30 */ set; /* RVA: 0x03D55580 */ }
        System.Nullable<System.Int64> To { get; /* RVA: 0x03D54E00 */ set; /* RVA: 0x03D54E10 */ }

        // Methods
        // RVA: 0x098424E0  token: 0x60001E4
        public System.Void .ctor(System.Nullable<System.Int64> from, System.Nullable<System.Int64> to) { }
        // RVA: 0x02A48500  token: 0x60001E9
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09842294  token: 0x60001EA
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0984234C  token: 0x60001EB
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098423BC  token: 0x60001EC
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004D  // size: 0x38
    public class RetryConditionHeaderValue : System.ICloneable
    {
        // Fields
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;  // 0x10
        private System.Nullable<System.TimeSpan> <Delta>k__BackingField;  // 0x28

        // Properties
        System.Nullable<System.DateTimeOffset> Date { get; /* RVA: 0x020B6BB0 */ set; /* RVA: 0x03D64DD0 */ }
        System.Nullable<System.TimeSpan> Delta { get; /* RVA: 0x03D59E20 */ set; /* RVA: 0x03D59E30 */ }

        // Methods
        // RVA: 0x09842CC4  token: 0x60001ED
        public System.Void .ctor(System.DateTimeOffset date) { }
        // RVA: 0x09842BE8  token: 0x60001EE
        public System.Void .ctor(System.TimeSpan delta) { }
        // RVA: 0x02A48500  token: 0x60001F3
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x098426D0  token: 0x60001F4
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09842820  token: 0x60001F5
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098429F0  token: 0x60001F6
        public static System.Boolean TryParse(System.String input, System.Net.Http.Headers.RetryConditionHeaderValue& parsedValue) { }
        // RVA: 0x098428A4  token: 0x60001F7
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004E  // size: 0x28
    public class StringWithQualityHeaderValue : System.ICloneable
    {
        // Fields
        private System.Nullable<System.Double> <Quality>k__BackingField;  // 0x10
        private System.String <Value>k__BackingField;  // 0x20

        // Properties
        System.Nullable<System.Double> Quality { get; /* RVA: 0x020B7B30 */ set; /* RVA: 0x03D55580 */ }
        System.String Value { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60001F8
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x60001FD
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09843140  token: 0x60001FE
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09843210  token: 0x60001FF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0984362C  token: 0x6000200
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.StringWithQualityHeaderValue>& result) { }
        // RVA: 0x09843364  token: 0x6000201
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.StringWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x0984328C  token: 0x6000202
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200004F  // size: 0x20
    public class TransferCodingHeaderValue : System.ICloneable
    {
        // Fields
        private System.String value;  // 0x10
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;  // 0x18

        // Properties
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get; /* RVA: 0x09844084 */ }
        System.String Value { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x09843DF8  token: 0x6000203
        protected System.Void .ctor(System.Net.Http.Headers.TransferCodingHeaderValue source) { }
        // RVA: 0x0350B670  token: 0x6000204
        private System.Void .ctor() { }
        // RVA: 0x09843B18  token: 0x6000207
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09843A10  token: 0x6000208
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09843A9C  token: 0x6000209
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09843B78  token: 0x600020A
        public virtual System.String ToString() { }
        // RVA: 0x09843D48  token: 0x600020B
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingHeaderValue>& result) { }
        // RVA: 0x09843BD0  token: 0x600020C
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000050  // size: 0x20
    public sealed class TransferCodingWithQualityHeaderValue : System.Net.Http.Headers.TransferCodingHeaderValue
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600020D
        private System.Void .ctor() { }
        // RVA: 0x09848A68  token: 0x600020E
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>& result) { }
        // RVA: 0x098488F0  token: 0x600020F
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000051  // size: 0x30
    public class ViaHeaderValue : System.ICloneable
    {
        // Fields
        private System.String <Comment>k__BackingField;  // 0x10
        private System.String <ProtocolName>k__BackingField;  // 0x18
        private System.String <ProtocolVersion>k__BackingField;  // 0x20
        private System.String <ReceivedBy>k__BackingField;  // 0x28

        // Properties
        System.String Comment { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String ProtocolName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String ProtocolVersion { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String ReceivedBy { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000210
        private System.Void .ctor() { }
        // RVA: 0x02A48500  token: 0x6000219
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09848B18  token: 0x600021A
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09848BC8  token: 0x600021B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x098490A0  token: 0x600021C
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ViaHeaderValue>& result) { }
        // RVA: 0x09848DA0  token: 0x600021D
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ViaHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x09848C90  token: 0x600021E
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000052  // size: 0x40
    public class WarningHeaderValue : System.ICloneable
    {
        // Fields
        private System.String <Agent>k__BackingField;  // 0x10
        private System.Int32 <Code>k__BackingField;  // 0x18
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;  // 0x20
        private System.String <Text>k__BackingField;  // 0x38

        // Properties
        System.String Agent { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Int32 Code { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Nullable<System.DateTimeOffset> Date { get; /* RVA: 0x03D50E20 */ set; /* RVA: 0x03D755E0 */ }
        System.String Text { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600021F
        private System.Void .ctor() { }
        // RVA: 0x09849330  token: 0x6000228
        private static System.Boolean IsCodeValid(System.Int32 code) { }
        // RVA: 0x02A48500  token: 0x6000229
        private virtual System.Object System.ICloneable.Clone() { }
        // RVA: 0x09849150  token: 0x600022A
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0984927C  token: 0x600022B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09849834  token: 0x600022C
        private static System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.WarningHeaderValue>& result) { }
        // RVA: 0x09849528  token: 0x600022D
        private static System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.WarningHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        // RVA: 0x09849344  token: 0x600022E
        public virtual System.String ToString() { }

    }

}

