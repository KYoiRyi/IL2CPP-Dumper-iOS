// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.Browser.dll
// Classes:  24
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

CLASS: OpenCallback
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x039A2590  token=0x6000017  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000018  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: EventCallback
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x02EAAEC0  token=0x6000019  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600001A  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: EventListener
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x039A2590  token=0x600001B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600001C  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: StatusCode
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x18
FIELDS:
  public            Hypergryph.SDK.IHGBrowserSDKCallbackcallback  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000025  System.Void .ctor()
  RVA=0x0886876C  token=0x6000026  System.Void <Open>b__0(System.String data)
END_CLASS

CLASS: ExtraInfoCallback
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x055582DC  token=0x6000030  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000031  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: OpenCallback
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x055582DC  token=0x6000044  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000045  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: EventListener
TYPE:  sealed class
TOKEN: 0x2000018
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x055582DC  token=0x6000046  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000047  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: Hypergryph.SDK.IHGBulletinSDK
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000001  System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener)
  RVA=-1  // abstract  token=0x6000002  System.Void Close()
  RVA=-1  // abstract  token=0x6000003  System.String GetRedDotState(System.String type)
  RVA=-1  // abstract  token=0x6000004  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBulletinSDK
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
  private   static  Hypergryph.SDK.IHGBulletinSDK   s_bulletin  // static @ 0x0
PROPERTIES:
  bulletinSdk  get=0x02EABD60
METHODS:
  RVA=0x039A23D0  token=0x6000006  System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener)
  RVA=0x088682D4  token=0x6000007  System.Void Close()
  RVA=0x02EABCF0  token=0x6000008  System.String GetRedDotState(System.String type)
  RVA=0x02EAB610  token=0x6000009  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBulletinSDKPluginWindows
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
IMPLEMENTS: Hypergryph.SDK.IHGBulletinSDK
FIELDS:
  private   static  System.Action<System.String>    outerOpenCallback  // static @ 0x0
  private   static  System.Action<System.String>    outerEventCallback  // static @ 0x8
  private   static  System.Action<System.String>    outerEventListener  // static @ 0x10
METHODS:
  RVA=0x022C6FA0  token=0x600000A  System.Void BulletinSDK_OpenBulletin(System.String type, Hypergryph.SDK.HGBulletinSDKPluginWindows.OpenCallback callback, Hypergryph.SDK.HGBulletinSDKPluginWindows.EventListener eventListener)
  RVA=0x088681F8  token=0x600000B  System.Void BulletinSDK_CloseBulletin()
  RVA=0x02EABE20  token=0x600000C  System.IntPtr BulletinSDK_GetRedDotState(System.String type)
  RVA=0x022C7070  token=0x600000D  System.Void BulletinSDK_RegisterBulletinEventListener(Hypergryph.SDK.HGBulletinSDKPluginWindows.EventCallback callback)
  RVA=0x03D1F5E0  token=0x600000E  System.Void InnerOpenCallBack(System.String jsonData)
  RVA=0x03D1F640  token=0x600000F  System.Void InnerEventCallBack(System.String jsonData)
  RVA=0x03D1E500  token=0x6000010  System.Void InnerEventListener(System.String jsonData)
  RVA=0x02EAB390  token=0x6000011  System.Void .ctor()
  RVA=0x08867D78  token=0x6000012  System.Void Finalize()
  RVA=0x039A2460  token=0x6000013  System.Void Open(System.String type, System.Action<System.String> onResult, System.Action<System.String> eventListener)
  RVA=0x08868260  token=0x6000014  System.Void Close()
  RVA=0x02EAC1F0  token=0x6000015  System.String GetRedDotState(System.String type)
  RVA=0x02EAAE10  token=0x6000016  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBroserSDKConstants
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Hypergryph.SDK.IHGBrowserSDKCallback
TYPE:  interface
TOKEN: 0x200000A
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600001D  System.Void onBrowserEvent(System.String data)
END_CLASS

CLASS: Hypergryph.SDK.IHGBrowserSDK
TYPE:  interface
TOKEN: 0x200000B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600001E  System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult)
  RVA=-1  // abstract  token=0x600001F  System.Void Close()
  RVA=-1  // abstract  token=0x6000020  System.Void SetAudioConfig(System.String config)
END_CLASS

CLASS: Hypergryph.SDK.HGBrowserSDK
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x10
FIELDS:
  private   static  Hypergryph.SDK.IHGBrowserSDK    s_browser  // static @ 0x0
PROPERTIES:
  browserSDK  get=0x02EAB2E0
METHODS:
  RVA=0x088680D0  token=0x6000022  System.Void Open(System.String url, System.String styleConfig, Hypergryph.SDK.IHGBrowserSDKCallback callback)
  RVA=0x0886805C  token=0x6000023  System.Void Close()
  RVA=0x02EAB270  token=0x6000024  System.Void SetAudioConfig(System.String config)
END_CLASS

CLASS: Hypergryph.SDK.HGBrowserSDKPluginWindows
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x10
IMPLEMENTS: Hypergryph.SDK.IHGBrowserSDK
FIELDS:
  private   static  System.Action<System.String>    outerCallback  // static @ 0x0
METHODS:
  RVA=0x08867E78  token=0x6000027  System.Void MiniWebViewSDKLoad(System.String url, System.String styleConfig, Hypergryph.SDK.HGBrowserSDKPluginWindows.ExtraInfoCallback callback)
  RVA=0x08867E4C  token=0x6000028  System.Void MiniWebViewSDKClose()
  RVA=0x022C80A0  token=0x6000029  System.Void WebViewSDKSetAudioConfig(System.String config)
  RVA=0x08867DFC  token=0x600002A  System.Void InnerCallBack(System.String jsonData)
  RVA=0x02EAB390  token=0x600002B  System.Void .ctor()
  RVA=0x08867D78  token=0x600002C  System.Void Finalize()
  RVA=0x08867F38  token=0x600002D  System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult)
  RVA=0x08867D04  token=0x600002E  System.Void Close()
  RVA=0x02EAB250  token=0x600002F  System.Void SetAudioConfig(System.String config)
END_CLASS

CLASS: Hypergryph.SDK.HGBrowerSDKTickEvent
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x022C84F0  token=0x6000032  System.Void Update()
  RVA=0x022C8500  token=0x6000033  System.Void WebViewSDKTickEvent()
  RVA=0x0426FE60  token=0x6000034  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGBrowerSDKTickEventManager
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x20
FIELDS:
  private           UnityEngine.GameObject          tickGameObject  // 0x10
  private           Hypergryph.SDK.HGBrowerSDKTickEventtickEvent  // 0x18
  private   static  Hypergryph.SDK.HGBrowerSDKTickEventManagerinstanceMangaer  // static @ 0x0
PROPERTIES:
  InstanceMangaer  get=0x02EAB3C0
METHODS:
  RVA=0x02EAAD00  token=0x6000036  System.Void InitTickEvent()
  RVA=0x08867C78  token=0x6000037  System.Void UnInitTickEvent()
  RVA=0x0350B670  token=0x6000038  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalState
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000039  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalMetadata
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600003A  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.IHGWebPortalSDK
TYPE:  interface
TOKEN: 0x2000014
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600003B  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalSDK
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x10
FIELDS:
  private   static  Hypergryph.SDK.IHGWebPortalSDK  s_webportal  // static @ 0x0
PROPERTIES:
  webportalSdk  get=0x088686C8
METHODS:
  RVA=0x08868668  token=0x600003D  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalSDKPluginWindows
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x10
IMPLEMENTS: Hypergryph.SDK.IHGWebPortalSDK
FIELDS:
  private   static  System.Action<System.String>    outerOpenCallback  // static @ 0x0
  private   static  System.Action<System.String>    outerEventListener  // static @ 0x8
METHODS:
  RVA=0x08868590  token=0x600003E  System.Void WebPortalSDK_Open(System.String target, System.String urlParams, Hypergryph.SDK.HGWebPortalSDKPluginWindows.OpenCallback callback, Hypergryph.SDK.HGWebPortalSDKPluginWindows.EventListener eventListener)
  RVA=0x08868398  token=0x600003F  System.Void InnerOpenCallBack(System.String jsonData)
  RVA=0x08868348  token=0x6000040  System.Void InnerEventListener(System.String jsonData)
  RVA=0x02EAB390  token=0x6000041  System.Void .ctor()
  RVA=0x08867D78  token=0x6000042  System.Void Finalize()
  RVA=0x088683E8  token=0x6000043  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult, System.Action<System.String> eventListener)
END_CLASS

