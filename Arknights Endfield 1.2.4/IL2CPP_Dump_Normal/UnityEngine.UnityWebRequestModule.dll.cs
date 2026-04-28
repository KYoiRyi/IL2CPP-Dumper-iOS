// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UnityWebRequestModule.dll
// Classes:  15
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct UnityWebRequestMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Get;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Post;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Put;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Head;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Custom;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct UnityWebRequestError
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError OK;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Unknown;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SDKError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError UnsupportedProtocol;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError MalformattedUrl;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotResolveProxy;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotResolveHost;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotConnectToHost;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError AccessDenied;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GenericHttpError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError WriteError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError ReadError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError OutOfMemory;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Timeout;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError HTTPPostError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCannotConnect;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Aborted;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError TooManyRedirects;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError ReceivedNoData;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLNotSupported;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError FailedToSendData;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError FailedToReceiveData;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCertificateError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCACertError;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError LoginFailed;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLShutdownFailed;  // const
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError NoInternetConnection;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct Result
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Networking.UnityWebRequest.Result InProgress;  // const
        public static UnityEngine.Networking.UnityWebRequest.Result Success;  // const
        public static UnityEngine.Networking.UnityWebRequest.Result ConnectionError;  // const
        public static UnityEngine.Networking.UnityWebRequest.Result ProtocolError;  // const
        public static UnityEngine.Networking.UnityWebRequest.Result DataProcessingError;  // const

    }

namespace UnityEngine
{

    // TypeToken: 0x2000003  // size: 0x40
    public class WWWForm
    {
        // Fields
        private System.Collections.Generic.List<System.Byte[]> formData;  // 0x10
        private System.Collections.Generic.List<System.String> fieldNames;  // 0x18
        private System.Collections.Generic.List<System.String> fileNames;  // 0x20
        private System.Collections.Generic.List<System.String> types;  // 0x28
        private System.Byte[] boundary;  // 0x30
        private System.Boolean containsFiles;  // 0x38
        private static System.Byte[] dDash;  // static @ 0x0
        private static System.Byte[] crlf;  // static @ 0x8
        private static System.Byte[] contentTypeHeader;  // static @ 0x10
        private static System.Byte[] dispositionHeader;  // static @ 0x18
        private static System.Byte[] endQuote;  // static @ 0x20
        private static System.Byte[] fileNameField;  // static @ 0x28
        private static System.Byte[] ampersand;  // static @ 0x30
        private static System.Byte[] equal;  // static @ 0x38

        // Properties
        System.Text.Encoding DefaultEncoding { get; /* RVA: 0x09F8733C */ }
        System.Collections.Generic.Dictionary<System.String,System.String> headers { get; /* RVA: 0x09F88040 */ }
        System.Byte[] data { get; /* RVA: 0x09F87348 */ }

        // Methods
        // RVA: 0x09F87060  token: 0x6000009
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class WWWTranscoder
    {
        // Fields
        private static System.Byte[] ucHexChars;  // static @ 0x0
        private static System.Byte[] lcHexChars;  // static @ 0x8
        private static System.Byte urlEscapeChar;  // static @ 0x10
        private static System.Byte[] urlSpace;  // static @ 0x18
        private static System.Byte[] dataSpace;  // static @ 0x20
        private static System.Byte[] urlForbidden;  // static @ 0x28
        private static System.Byte qpEscapeChar;  // static @ 0x30
        private static System.Byte[] qpSpace;  // static @ 0x38
        private static System.Byte[] qpForbidden;  // static @ 0x40

        // Methods
        // RVA: 0x09F88958  token: 0x600000A
        private static System.Byte Hex2Byte(System.Byte[] b, System.Int32 offset) { }
        // RVA: 0x09F88158  token: 0x600000B
        private static System.Void Byte2Hex(System.Byte b, System.Byte[] hexChars, System.Byte& byte0, System.Byte& byte1) { }
        // RVA: 0x09F88C18  token: 0x600000C
        public static System.Byte[] URLEncode(System.Byte[] toEncode) { }
        // RVA: 0x09F8824C  token: 0x600000D
        public static System.String DataEncode(System.String toEncode) { }
        // RVA: 0x09F88308  token: 0x600000E
        public static System.String DataEncode(System.String toEncode, System.Text.Encoding e) { }
        // RVA: 0x09F882A4  token: 0x600000F
        public static System.Byte[] DataEncode(System.Byte[] toEncode) { }
        // RVA: 0x09F889D4  token: 0x6000010
        public static System.String QPEncode(System.String toEncode, System.Text.Encoding e) { }
        // RVA: 0x09F88620  token: 0x6000011
        public static System.Byte[] Encode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space, System.Byte[] forbidden, System.Boolean uppercase) { }
        // RVA: 0x09F88198  token: 0x6000012
        private static System.Boolean ByteArrayContains(System.Byte[] array, System.Byte b) { }
        // RVA: 0x09F88BC0  token: 0x6000013
        public static System.Byte[] URLDecode(System.Byte[] toEncode) { }
        // RVA: 0x09F881D8  token: 0x6000014
        private static System.Boolean ByteSubArrayEquals(System.Byte[] array, System.Int32 index, System.Byte[] comperand) { }
        // RVA: 0x09F883DC  token: 0x6000015
        public static System.Byte[] Decode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space) { }
        // RVA: 0x09F88AD8  token: 0x6000016
        public static System.Boolean SevenBitClean(System.String s, System.Text.Encoding e) { }
        // RVA: 0x09F88AA8  token: 0x6000017
        public static System.Boolean SevenBitClean(System.Byte* input, System.Int32 inputLength) { }
        // RVA: 0x09F88C7C  token: 0x6000018
        private static System.Void .cctor() { }

    }

}

namespace UnityEngine.Networking
{

    // TypeToken: 0x2000005
    public interface IMultipartFormSection
    {
        // Properties
        System.String sectionName { get; /* RVA: -1  // abstract */ }
        System.Byte[] sectionData { get; /* RVA: -1  // abstract */ }
        System.String fileName { get; /* RVA: -1  // abstract */ }
        System.String contentType { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000006  // size: 0x28
    public class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
    {
        // Fields
        private UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;  // 0x20

        // Properties
        UnityEngine.Networking.UnityWebRequest webRequest { set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600001E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x40
    public class UnityWebRequest : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10
        private UnityEngine.Networking.DownloadHandler m_DownloadHandler;  // 0x18
        private UnityEngine.Networking.UploadHandler m_UploadHandler;  // 0x20
        private UnityEngine.Networking.CertificateHandler m_CertificateHandler;  // 0x28
        private System.Uri m_Uri;  // 0x30
        public static System.String kHttpVerbGET;  // const
        public static System.String kHttpVerbHEAD;  // const
        public static System.String kHttpVerbPOST;  // const
        public static System.String kHttpVerbPUT;  // const
        public static System.String kHttpVerbCREATE;  // const
        public static System.String kHttpVerbDELETE;  // const
        private System.Boolean <disposeCertificateHandlerOnDispose>k__BackingField;  // 0x38
        private System.Boolean <disposeDownloadHandlerOnDispose>k__BackingField;  // 0x39
        private System.Boolean <disposeUploadHandlerOnDispose>k__BackingField;  // 0x3a

        // Properties
        System.Boolean disposeCertificateHandlerOnDispose { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Boolean disposeDownloadHandlerOnDispose { get; /* RVA: 0x03D4F300 */ set; /* RVA: 0x03D4F330 */ }
        System.Boolean disposeUploadHandlerOnDispose { get; /* RVA: 0x03D4F500 */ set; /* RVA: 0x03D4F530 */ }
        System.String method { get; /* RVA: 0x09F86990 */ set; /* RVA: 0x02C45E20 */ }
        System.String error { get; /* RVA: 0x02C47770 */ }
        System.Boolean use100Continue { get; /* RVA: 0x09F86BB8 */ set; /* RVA: 0x09F86F94 */ }
        System.Boolean useHttpContinue { get; /* RVA: 0x09F86BEC */ set; /* RVA: 0x09F86FD8 */ }
        System.String url { get; /* RVA: 0x09F86BAC */ set; /* RVA: 0x02C45D90 */ }
        System.Uri uri { get; /* RVA: 0x09F86AE0 */ set; /* RVA: 0x09F86EA8 */ }
        System.Int64 responseCode { get; /* RVA: 0x02C47730 */ }
        System.Single uploadProgress { get; /* RVA: 0x09F86A6C */ }
        System.Boolean isModifiable { get; /* RVA: 0x02C460E0 */ }
        System.Boolean isDone { get; /* RVA: 0x02C475F0 */ }
        System.Boolean isNetworkError { get; /* RVA: 0x09F86978 */ }
        System.Boolean isHttpError { get; /* RVA: 0x09F86960 */ }
        UnityEngine.Networking.UnityWebRequest.Result result { get; /* RVA: 0x02C477C0 */ }
        System.Single downloadProgress { get; /* RVA: 0x09F868EC */ }
        System.UInt64 uploadedBytes { get; /* RVA: 0x09F86AAC */ }
        System.UInt64 downloadedBytes { get; /* RVA: 0x09F8692C */ }
        System.Int32 redirectLimit { get; /* RVA: 0x09F86A30 */ set; /* RVA: 0x09F86DC0 */ }
        System.Boolean chunkedTransfer { get; /* RVA: 0x09F868E0 */ set; /* RVA: 0x09F86CE0 */ }
        UnityEngine.Networking.UploadHandler uploadHandler { get; /* RVA: 0x03D85A20 */ set; /* RVA: 0x02C46120 */ }
        UnityEngine.Networking.DownloadHandler downloadHandler { get; /* RVA: 0x03D61D00 */ set; /* RVA: 0x02C461C0 */ }
        UnityEngine.Networking.CertificateHandler certificateHandler { get; /* RVA: 0x03D86CD0 */ set; /* RVA: 0x09F86BF8 */ }
        System.Int32 timeout { get; /* RVA: 0x09F86A48 */ set; /* RVA: 0x02C46260 */ }
        System.Boolean suppressErrorsToConsole { get; /* RVA: 0x09F86A3C */ set; /* RVA: 0x09F86DC8 */ }

        // Methods
        // RVA: 0x09F84CF4  token: 0x600001F
        private static System.String GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err) { }
        // RVA: 0x09F848F0  token: 0x6000020
        private static System.String GetHTTPStatusString(System.Int64 responseCode) { }
        // RVA: 0x09F84484  token: 0x6000027
        public static System.Void ClearCookieCache() { }
        // RVA: 0x09F84490  token: 0x6000028
        public static System.Void ClearCookieCache(System.Uri uri) { }
        // RVA: 0x09F84440  token: 0x6000029
        private static System.Void ClearCookieCache(System.String domain, System.String path) { }
        // RVA: 0x02C463D0  token: 0x600002A
        private static System.IntPtr Create() { }
        // RVA: 0x037798B0  token: 0x600002B
        private System.Void Release() { }
        // RVA: 0x03779880  token: 0x600002C
        private System.Void InternalDestroy() { }
        // RVA: 0x03D89F00  token: 0x600002D
        private System.Void InternalSetDefaults() { }
        // RVA: 0x09F8683C  token: 0x600002E
        public System.Void .ctor() { }
        // RVA: 0x09F86860  token: 0x600002F
        public System.Void .ctor(System.String url) { }
        // RVA: 0x09F868A0  token: 0x6000030
        public System.Void .ctor(System.Uri uri) { }
        // RVA: 0x02C47ED0  token: 0x6000031
        public System.Void .ctor(System.String url, System.String method) { }
        // RVA: 0x09F86760  token: 0x6000032
        public System.Void .ctor(System.Uri uri, System.String method) { }
        // RVA: 0x02C46340  token: 0x6000033
        public System.Void .ctor(System.String url, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler) { }
        // RVA: 0x09F867B8  token: 0x6000034
        public System.Void .ctor(System.Uri uri, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler) { }
        // RVA: 0x09F8470C  token: 0x6000035
        protected virtual System.Void Finalize() { }
        // RVA: 0x03779810  token: 0x6000036
        public virtual System.Void Dispose() { }
        // RVA: 0x03779930  token: 0x6000037
        private System.Void DisposeHandlers() { }
        // RVA: 0x02C47480  token: 0x6000038
        private UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest() { }
        // RVA: 0x09F85850  token: 0x6000039
        public UnityEngine.AsyncOperation Send() { }
        // RVA: 0x02C47450  token: 0x600003A
        public UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest() { }
        // RVA: 0x037798F0  token: 0x600003B
        public System.Void Abort() { }
        // RVA: 0x02C46000  token: 0x600003C
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType) { }
        // RVA: 0x02C45FC0  token: 0x600003D
        private System.Void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType) { }
        // RVA: 0x09F86124  token: 0x600003E
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(System.String customMethodName) { }
        // RVA: 0x09F84EC4  token: 0x600003F
        private System.Void InternalSetCustomMethod(System.String customMethodName) { }
        // RVA: 0x09F84924  token: 0x6000040
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod() { }
        // RVA: 0x09F84854  token: 0x6000041
        private System.String GetCustomMethod() { }
        // RVA: 0x09F848BC  token: 0x6000044
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError() { }
        // RVA: 0x09F84CC0  token: 0x600004E
        private System.String GetUrl() { }
        // RVA: 0x02C46090  token: 0x600004F
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(System.String url) { }
        // RVA: 0x02C46050  token: 0x6000050
        private System.Void InternalSetUrl(System.String url) { }
        // RVA: 0x09F84C8C  token: 0x6000052
        private System.Single GetUploadProgress() { }
        // RVA: 0x09F84FA4  token: 0x6000053
        private System.Boolean IsExecuting() { }
        // RVA: 0x09F84888  token: 0x600005A
        private System.Single GetDownloadProgress() { }
        // RVA: 0x09F84958  token: 0x600005E
        private System.Int32 GetRedirectLimit() { }
        // RVA: 0x09F86168  token: 0x600005F
        private System.Void SetRedirectLimitFromScripting(System.Int32 limit) { }
        // RVA: 0x09F84820  token: 0x6000062
        private System.Boolean GetChunked() { }
        // RVA: 0x09F860E0  token: 0x6000063
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(System.Boolean chunked) { }
        // RVA: 0x09F8498C  token: 0x6000066
        public System.String GetRequestHeader(System.String name) { }
        // RVA: 0x02C45F60  token: 0x6000067
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(System.String name, System.String value) { }
        // RVA: 0x02C45EF0  token: 0x6000068
        public System.Void SetRequestHeader(System.String name, System.String value) { }
        // RVA: 0x09F84A04  token: 0x6000069
        public System.String GetResponseHeader(System.String name) { }
        // RVA: 0x09F849D0  token: 0x600006A
        private System.String[] GetResponseHeaderKeys() { }
        // RVA: 0x09F84A48  token: 0x600006B
        public System.Collections.Generic.Dictionary<System.String,System.String> GetResponseHeaders() { }
        // RVA: 0x02C46170  token: 0x600006C
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh) { }
        // RVA: 0x02C46210  token: 0x600006F
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh) { }
        // RVA: 0x09F8609C  token: 0x6000072
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch) { }
        // RVA: 0x09F84C58  token: 0x6000075
        private System.Int32 GetTimeoutMsec() { }
        // RVA: 0x02C462F0  token: 0x6000076
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(System.Int32 timeout) { }
        // RVA: 0x09F84B6C  token: 0x6000079
        private System.Boolean GetSuppressErrorsToConsole() { }
        // RVA: 0x09F861A8  token: 0x600007A
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(System.Boolean suppress) { }
        // RVA: 0x02C47DF0  token: 0x600007D
        public static UnityEngine.Networking.UnityWebRequest Get(System.String uri) { }
        // RVA: 0x09F84D28  token: 0x600007E
        public static UnityEngine.Networking.UnityWebRequest Get(System.Uri uri) { }
        // RVA: 0x09F845C0  token: 0x600007F
        public static UnityEngine.Networking.UnityWebRequest Delete(System.String uri) { }
        // RVA: 0x09F8454C  token: 0x6000080
        public static UnityEngine.Networking.UnityWebRequest Delete(System.Uri uri) { }
        // RVA: 0x09F84DDC  token: 0x6000081
        public static UnityEngine.Networking.UnityWebRequest Head(System.String uri) { }
        // RVA: 0x09F84E50  token: 0x6000082
        public static UnityEngine.Networking.UnityWebRequest Head(System.Uri uri) { }
        // RVA: 0x09F84BFC  token: 0x6000083
        public static UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri) { }
        // RVA: 0x09F84BA0  token: 0x6000084
        public static UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri, System.Boolean nonReadable) { }
        // RVA: 0x03D85B20  token: 0x6000085
        public static UnityEngine.Networking.UnityWebRequest GetAudioClip(System.String uri, UnityEngine.AudioType audioType) { }
        // RVA: 0x03D85B20  token: 0x6000086
        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri) { }
        // RVA: 0x03D85B20  token: 0x6000087
        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 crc) { }
        // RVA: 0x03D85B20  token: 0x6000088
        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 version, System.UInt32 crc) { }
        // RVA: 0x03D85B20  token: 0x6000089
        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.Hash128 hash, System.UInt32 crc) { }
        // RVA: 0x03D85B20  token: 0x600008A
        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.CachedAssetBundle cachedAssetBundle, System.UInt32 crc) { }
        // RVA: 0x09F85650  token: 0x600008B
        public static UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.Byte[] bodyData) { }
        // RVA: 0x09F85564  token: 0x600008C
        public static UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.Byte[] bodyData) { }
        // RVA: 0x09F8573C  token: 0x600008D
        public static UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.String bodyData) { }
        // RVA: 0x09F85450  token: 0x600008E
        public static UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.String bodyData) { }
        // RVA: 0x02C48630  token: 0x600008F
        public static UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.String postData) { }
        // RVA: 0x09F8500C  token: 0x6000090
        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.String postData) { }
        // RVA: 0x02C486C0  token: 0x6000091
        private static System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.String postData) { }
        // RVA: 0x09F85160  token: 0x6000092
        public static UnityEngine.Networking.UnityWebRequest Post(System.String uri, UnityEngine.WWWForm formData) { }
        // RVA: 0x09F8509C  token: 0x6000093
        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, UnityEngine.WWWForm formData) { }
        // RVA: 0x09F862F0  token: 0x6000094
        private static System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData) { }
        // RVA: 0x09F84FD8  token: 0x6000095
        public static UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections) { }
        // RVA: 0x09F8512C  token: 0x6000096
        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections) { }
        // RVA: 0x09F85290  token: 0x6000097
        public static UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        // RVA: 0x09F851F0  token: 0x6000098
        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        // RVA: 0x09F8653C  token: 0x6000099
        private static System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        // RVA: 0x09F853C0  token: 0x600009A
        public static UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        // RVA: 0x09F85330  token: 0x600009B
        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        // RVA: 0x09F861EC  token: 0x600009C
        private static System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        // RVA: 0x09F84634  token: 0x600009D
        public static System.String EscapeURL(System.String s) { }
        // RVA: 0x09F84658  token: 0x600009E
        public static System.String EscapeURL(System.String s, System.Text.Encoding e) { }
        // RVA: 0x09F8673C  token: 0x600009F
        public static System.String UnEscapeURL(System.String s) { }
        // RVA: 0x09F8668C  token: 0x60000A0
        public static System.String UnEscapeURL(System.String s, System.Text.Encoding e) { }
        // RVA: 0x09F8585C  token: 0x60000A1
        public static System.Byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        // RVA: 0x09F84788  token: 0x60000A2
        public static System.Byte[] GenerateBoundary() { }
        // RVA: 0x09F85E64  token: 0x60000A3
        public static System.Byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class CertificateHandler : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10

        // Methods
        // RVA: 0x09F8440C  token: 0x60000A4
        private System.Void Release() { }
        // RVA: 0x03D4E3A0  token: 0x60000A5
        protected virtual System.Boolean ValidateCertificate(System.Byte[] certificateData) { }
        // RVA: 0x03D4E3A0  token: 0x60000A6
        private System.Boolean ValidateCertificateNative(System.Byte[] certificateData) { }
        // RVA: 0x09F843E4  token: 0x60000A7
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public class DownloadHandler : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10

        // Properties
        System.Byte[] data { get; /* RVA: 0x02C47720 */ }
        System.String text { get; /* RVA: 0x04272EA0 */ }

        // Methods
        // RVA: 0x037B7BE0  token: 0x60000A8
        private System.Void Release() { }
        // RVA: 0x0350B670  token: 0x60000A9
        private System.Void .ctor() { }
        // RVA: 0x039C4380  token: 0x60000AA
        protected virtual System.Void Finalize() { }
        // RVA: 0x037B7B70  token: 0x60000AB
        public virtual System.Void Dispose() { }
        // RVA: 0x03D86200  token: 0x60000AE
        protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }
        // RVA: 0x02C47720  token: 0x60000AF
        protected virtual System.Byte[] GetData() { }
        // RVA: 0x0339A940  token: 0x60000B0
        protected virtual System.String GetText() { }
        // RVA: 0x0339ABC0  token: 0x60000B1
        private System.Text.Encoding GetTextEncoder() { }
        // RVA: 0x0339AD20  token: 0x60000B2
        private System.String GetContentType() { }
        // RVA: 0x03D663A0  token: 0x60000B3
        protected virtual System.Boolean ReceiveData(System.Byte[] data, System.Int32 dataLength) { }
        // RVA: 0x0350B670  token: 0x60000B4
        protected virtual System.Void ReceiveContentLengthHeader(System.UInt64 contentLength) { }
        // RVA: 0x0350B670  token: 0x60000B5
        protected virtual System.Void ReceiveContentLength(System.Int32 contentLength) { }
        // RVA: 0x0350B670  token: 0x60000B6
        protected virtual System.Void CompleteContent() { }
        // RVA: 0x03D85FA0  token: 0x60000B7
        protected virtual System.Single GetProgress() { }
        // RVA: 0x0339AB70  token: 0x60000B8
        private static System.Byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, System.Int32& length) { }
        // RVA: 0x0339AA00  token: 0x60000B9
        private static System.Byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh) { }
        // RVA: 0x0339AAB0  token: 0x60000BA
        private static Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }
        // RVA: 0x037B7BA0  token: 0x60000BB
        private static System.Void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }
        // RVA: 0x0339AD60  token: 0x60000BC
        private static System.Void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, System.Byte* bytes, System.Int32 length) { }

    }

    // TypeToken: 0x200000D  // size: 0x28
    public sealed class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> m_NativeData;  // 0x18

        // Methods
        // RVA: 0x03CAB560  token: 0x60000BD
        private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerBuffer obj) { }
        // RVA: 0x02C47EB0  token: 0x60000BE
        private System.Void InternalCreateBuffer() { }
        // RVA: 0x02C47EB0  token: 0x60000BF
        public System.Void .ctor() { }
        // RVA: 0x0339AA80  token: 0x60000C0
        protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }
        // RVA: 0x037B7B40  token: 0x60000C1
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x200000E  // size: 0x18
    public class UploadHandler : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10

        // Properties
        System.String contentType { set; /* RVA: 0x04272EAC */ }

        // Methods
        // RVA: 0x03B3A750  token: 0x60000C2
        private System.Void Release() { }
        // RVA: 0x0350B670  token: 0x60000C3
        private System.Void .ctor() { }
        // RVA: 0x039C4380  token: 0x60000C4
        protected virtual System.Void Finalize() { }
        // RVA: 0x03B3A720  token: 0x60000C5
        public virtual System.Void Dispose() { }
        // RVA: 0x04272EAC  token: 0x60000C7
        private virtual System.Void SetContentType(System.String newContentType) { }
        // RVA: 0x03D2B950  token: 0x60000C8
        private System.Void InternalSetContentType(System.String newContentType) { }

    }

    // TypeToken: 0x200000F  // size: 0x28
    public sealed class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> m_Payload;  // 0x18

        // Methods
        // RVA: 0x02C48880  token: 0x60000C9
        private static System.IntPtr Create(UnityEngine.Networking.UploadHandlerRaw self, System.Byte* data, System.Int32 dataLength) { }
        // RVA: 0x02C48770  token: 0x60000CA
        public System.Void .ctor(System.Byte[] data) { }
        // RVA: 0x02C48810  token: 0x60000CB
        public System.Void .ctor(Unity.Collections.NativeArray<System.Byte> data, System.Boolean transferOwnership) { }
        // RVA: 0x03B3A6C0  token: 0x60000CC
        public virtual System.Void Dispose() { }

    }

}

namespace UnityEngineInternal
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class WebRequestUtils
    {
        // Fields
        private static System.Text.RegularExpressions.Regex domainRegex;  // static @ 0x0

        // Methods
        // RVA: 0x09F88F3C  token: 0x6000001
        private static System.String RedirectTo(System.String baseUri, System.String redirectUri) { }
        // RVA: 0x02C44C00  token: 0x6000002
        private static System.String MakeInitialUrl(System.String targetUrl, System.String localUrl) { }
        // RVA: 0x02C40150  token: 0x6000003
        private static System.String MakeUriString(System.Uri targetUri, System.String targetUrl, System.Boolean prependProtocol) { }
        // RVA: 0x09F8904C  token: 0x6000004
        private static System.String URLDecode(System.String encoded) { }
        // RVA: 0x034965C0  token: 0x6000005
        private static System.Void .cctor() { }

    }

}

