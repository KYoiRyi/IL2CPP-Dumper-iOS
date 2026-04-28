// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.Browser.dll
// Classes:  24
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000005  // size: 0x80
    public sealed class OpenCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x039A2590  token: 0x6000017
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000018
        public virtual System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000006  // size: 0x80
    public sealed class EventCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02EAAEC0  token: 0x6000019
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600001A
        public virtual System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000007  // size: 0x80
    public sealed class EventListener : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x039A2590  token: 0x600001B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600001C
        public virtual System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public static class StatusCode
    {
    }

    // TypeToken: 0x200000D  // size: 0x18
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public Hypergryph.SDK.IHGBrowserSDKCallback callback;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000025
        public System.Void .ctor() { }
        // RVA: 0x0886876C  token: 0x6000026
        private System.Void <Open>b__0(System.String data) { }

    }

    // TypeToken: 0x200000F  // size: 0x80
    public sealed class ExtraInfoCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x6000030
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000031
        public virtual System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000017  // size: 0x80
    public sealed class OpenCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x6000044
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000045
        public virtual System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000018  // size: 0x80
    public sealed class EventListener : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x6000046
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000047
        public virtual System.Void Invoke(System.String jsonData) { }

    }

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public interface IHGBulletinSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000001
        public virtual System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }
        // RVA: -1  // abstract  token: 0x6000002
        public virtual System.Void Close() { }
        // RVA: -1  // abstract  token: 0x6000003
        public virtual System.String GetRedDotState(System.String type) { }
        // RVA: -1  // abstract  token: 0x6000004
        public virtual System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public class HGBulletinSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGBulletinSDK s_bulletin;  // static @ 0x0

        // Properties
        Hypergryph.SDK.IHGBulletinSDK bulletinSdk { get; /* RVA: 0x02EABD60 */ }

        // Methods
        // RVA: 0x039A23D0  token: 0x6000006
        public static System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }
        // RVA: 0x088682D4  token: 0x6000007
        public static System.Void Close() { }
        // RVA: 0x02EABCF0  token: 0x6000008
        public static System.String GetRedDotState(System.String type) { }
        // RVA: 0x02EAB610  token: 0x6000009
        public static System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class HGBulletinSDKPluginWindows : Hypergryph.SDK.IHGBulletinSDK
    {
        // Fields
        private static System.Action<System.String> outerOpenCallback;  // static @ 0x0
        private static System.Action<System.String> outerEventCallback;  // static @ 0x8
        private static System.Action<System.String> outerEventListener;  // static @ 0x10

        // Methods
        // RVA: 0x022C6FA0  token: 0x600000A
        private static System.Void BulletinSDK_OpenBulletin(System.String type, Hypergryph.SDK.HGBulletinSDKPluginWindows.OpenCallback callback, Hypergryph.SDK.HGBulletinSDKPluginWindows.EventListener eventListener) { }
        // RVA: 0x088681F8  token: 0x600000B
        private static System.Void BulletinSDK_CloseBulletin() { }
        // RVA: 0x02EABE20  token: 0x600000C
        private static System.IntPtr BulletinSDK_GetRedDotState(System.String type) { }
        // RVA: 0x022C7070  token: 0x600000D
        private static System.Void BulletinSDK_RegisterBulletinEventListener(Hypergryph.SDK.HGBulletinSDKPluginWindows.EventCallback callback) { }
        // RVA: 0x03D1F5E0  token: 0x600000E
        public static System.Void InnerOpenCallBack(System.String jsonData) { }
        // RVA: 0x03D1F640  token: 0x600000F
        public static System.Void InnerEventCallBack(System.String jsonData) { }
        // RVA: 0x03D1E500  token: 0x6000010
        public static System.Void InnerEventListener(System.String jsonData) { }
        // RVA: 0x02EAB390  token: 0x6000011
        public System.Void .ctor() { }
        // RVA: 0x08867D78  token: 0x6000012
        protected virtual System.Void Finalize() { }
        // RVA: 0x039A2460  token: 0x6000013
        public virtual System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }
        // RVA: 0x08868260  token: 0x6000014
        public virtual System.Void Close() { }
        // RVA: 0x02EAC1F0  token: 0x6000015
        public virtual System.String GetRedDotState(System.String type) { }
        // RVA: 0x02EAAE10  token: 0x6000016
        public virtual System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class HGBroserSDKConstants
    {
    }

    // TypeToken: 0x200000A
    public interface IHGBrowserSDKCallback
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600001D
        public virtual System.Void onBrowserEvent(System.String data) { }

    }

    // TypeToken: 0x200000B
    public interface IHGBrowserSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600001E
        public virtual System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult) { }
        // RVA: -1  // abstract  token: 0x600001F
        public virtual System.Void Close() { }
        // RVA: -1  // abstract  token: 0x6000020
        public virtual System.Void SetAudioConfig(System.String config) { }

    }

    // TypeToken: 0x200000C  // size: 0x10
    public class HGBrowserSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGBrowserSDK s_browser;  // static @ 0x0

        // Properties
        Hypergryph.SDK.IHGBrowserSDK browserSDK { get; /* RVA: 0x02EAB2E0 */ }

        // Methods
        // RVA: 0x088680D0  token: 0x6000022
        public static System.Void Open(System.String url, System.String styleConfig, Hypergryph.SDK.IHGBrowserSDKCallback callback) { }
        // RVA: 0x0886805C  token: 0x6000023
        public static System.Void Close() { }
        // RVA: 0x02EAB270  token: 0x6000024
        public static System.Void SetAudioConfig(System.String config) { }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public class HGBrowserSDKPluginWindows : Hypergryph.SDK.IHGBrowserSDK
    {
        // Fields
        private static System.Action<System.String> outerCallback;  // static @ 0x0

        // Methods
        // RVA: 0x08867E78  token: 0x6000027
        private static System.Void MiniWebViewSDKLoad(System.String url, System.String styleConfig, Hypergryph.SDK.HGBrowserSDKPluginWindows.ExtraInfoCallback callback) { }
        // RVA: 0x08867E4C  token: 0x6000028
        private static System.Void MiniWebViewSDKClose() { }
        // RVA: 0x022C80A0  token: 0x6000029
        private static System.Void WebViewSDKSetAudioConfig(System.String config) { }
        // RVA: 0x08867DFC  token: 0x600002A
        public static System.Void InnerCallBack(System.String jsonData) { }
        // RVA: 0x02EAB390  token: 0x600002B
        public System.Void .ctor() { }
        // RVA: 0x08867D78  token: 0x600002C
        protected virtual System.Void Finalize() { }
        // RVA: 0x08867F38  token: 0x600002D
        public virtual System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult) { }
        // RVA: 0x08867D04  token: 0x600002E
        public virtual System.Void Close() { }
        // RVA: 0x02EAB250  token: 0x600002F
        public virtual System.Void SetAudioConfig(System.String config) { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public class HGBrowerSDKTickEvent : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x022C84F0  token: 0x6000032
        private System.Void Update() { }
        // RVA: 0x022C8500  token: 0x6000033
        private static System.Void WebViewSDKTickEvent() { }
        // RVA: 0x0426FE60  token: 0x6000034
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public class HGBrowerSDKTickEventManager
    {
        // Fields
        private UnityEngine.GameObject tickGameObject;  // 0x10
        private Hypergryph.SDK.HGBrowerSDKTickEvent tickEvent;  // 0x18
        private static Hypergryph.SDK.HGBrowerSDKTickEventManager instanceMangaer;  // static @ 0x0

        // Properties
        Hypergryph.SDK.HGBrowerSDKTickEventManager InstanceMangaer { get; /* RVA: 0x02EAB3C0 */ }

        // Methods
        // RVA: 0x02EAAD00  token: 0x6000036
        public System.Void InitTickEvent() { }
        // RVA: 0x08867C78  token: 0x6000037
        public System.Void UnInitTickEvent() { }
        // RVA: 0x0350B670  token: 0x6000038
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public class HGWebPortalState
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000039
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public class HGWebPortalMetadata
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600003A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public interface IHGWebPortalSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600003B
        public virtual System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public class HGWebPortalSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGWebPortalSDK s_webportal;  // static @ 0x0

        // Properties
        Hypergryph.SDK.IHGWebPortalSDK webportalSdk { get; /* RVA: 0x088686C8 */ }

        // Methods
        // RVA: 0x08868668  token: 0x600003D
        public static System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000016  // size: 0x10
    public class HGWebPortalSDKPluginWindows : Hypergryph.SDK.IHGWebPortalSDK
    {
        // Fields
        private static System.Action<System.String> outerOpenCallback;  // static @ 0x0
        private static System.Action<System.String> outerEventListener;  // static @ 0x8

        // Methods
        // RVA: 0x08868590  token: 0x600003E
        private static System.Void WebPortalSDK_Open(System.String target, System.String urlParams, Hypergryph.SDK.HGWebPortalSDKPluginWindows.OpenCallback callback, Hypergryph.SDK.HGWebPortalSDKPluginWindows.EventListener eventListener) { }
        // RVA: 0x08868398  token: 0x600003F
        public static System.Void InnerOpenCallBack(System.String jsonData) { }
        // RVA: 0x08868348  token: 0x6000040
        public static System.Void InnerEventListener(System.String jsonData) { }
        // RVA: 0x02EAB390  token: 0x6000041
        public System.Void .ctor() { }
        // RVA: 0x08867D78  token: 0x6000042
        protected virtual System.Void Finalize() { }
        // RVA: 0x088683E8  token: 0x6000043
        public virtual System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener) { }

    }

}

