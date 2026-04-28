// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.GameUpdate.dll
// Classes:  9
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

CLASS: <>c__DisplayClass6_0
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x18
FIELDS:
  public            System.String                   data  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000005  System.Void .ctor()
  RVA=0x0886E544  token=0x6000006  System.Void <onLatestGame>b__0()
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x18
FIELDS:
  public            System.Action                   action  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000007  System.Void .ctor()
  RVA=0x05A93C08  token=0x6000008  System.Void <runInMainTread>b__0(System.Object p)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
  public    static readonly Hypergryph.SDK.HGGameUpdateSDK.<>c<>9  // static @ 0x0
  public    static  System.Action<System.String>    <>9__6_0  // static @ 0x8
METHODS:
  RVA=0x0886E594  token=0x6000027  System.Void .cctor()
  RVA=0x0350B670  token=0x6000028  System.Void .ctor()
  RVA=0x0886E4A8  token=0x6000029  System.Void <GetLatestGame>b__6_0(System.String result)
END_CLASS

CLASS: Hypergryph.SDK.HGGameUpdateCallback
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  Hypergryph.SDK.IHGGameUpdateSDKCallbackm_callback  // static @ 0x0
  private   static  System.String                   gameObjectName  // const
  private   static  System.Threading.SynchronizationContextmainThreadContext  // static @ 0x8
  public    static  Hypergryph.SDK.HGGameUpdateCallbacks_instance  // static @ 0x10
METHODS:
  RVA=0x0886D504  token=0x6000001  System.Void .ctor()
  RVA=0x0886D348  token=0x6000002  System.Void Init(Hypergryph.SDK.IHGGameUpdateSDKCallback callback)
  RVA=0x0886D568  token=0x6000003  System.Void onLatestGame(System.String data)
  RVA=0x0886D620  token=0x6000004  System.Void runInMainTread(System.Action action)
END_CLASS

CLASS: Hypergryph.SDK.IHGGameUpdateSDKCallback
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000009  System.Void onLatestGame(System.String data)
END_CLASS

CLASS: Hypergryph.SDK.IHGGameUpdateSDK
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600000A  System.Int32 Init(System.String config)
  RVA=-1  // abstract  token=0x600000B  System.Void GetLatestGame(System.Action<System.String> onResult)
  RVA=-1  // abstract  token=0x600000C  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  RVA=-1  // abstract  token=0x600000D  System.Int32 EnableMobileData(System.Int64 taskId)
  RVA=-1  // abstract  token=0x600000E  System.Int32 GetTaskState(System.Int64 taskId)
  RVA=-1  // abstract  token=0x600000F  System.Int32 Resume(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000010  System.Int32 CancelAndClear(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000011  System.Int32 Cancel(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000012  System.Int32 Install(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000013  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000014  System.Int64 GetDownloadedSize(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000015  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  RVA=-1  // abstract  token=0x6000016  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  RVA=-1  // abstract  token=0x6000017  System.Int32 SetNotificationTitle(System.String titleConfig)
END_CLASS

CLASS: Hypergryph.SDK.HGGameUpdateSDK
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
  private   static  Hypergryph.SDK.IHGGameUpdateSDK s_gu  // static @ 0x0
  private   static  Hypergryph.SDK.IHGGameUpdateSDKCallbackm_callback  // static @ 0x8
  private   static  System.Threading.SynchronizationContextmainThreadContext  // static @ 0x10
PROPERTIES:
  gameUpdateSDK  get=0x0886E414
METHODS:
  RVA=0x0886E100  token=0x6000019  System.Int32 Init(System.String config, Hypergryph.SDK.IHGGameUpdateSDKCallback callback)
  RVA=0x0886DEC0  token=0x600001A  System.Void GetLatestGame()
  RVA=0x0886E380  token=0x600001B  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  RVA=0x0886DCC0  token=0x600001C  System.Int32 EnableMobileData(System.Int64 taskId)
  RVA=0x0886E000  token=0x600001D  System.Int32 GetTaskState(System.Int64 taskId)
  RVA=0x0886E280  token=0x600001E  System.Int32 Resume(System.Int64 taskId)
  RVA=0x0886DBC0  token=0x600001F  System.Int32 CancelAndClear(System.Int64 taskId)
  RVA=0x0886DC40  token=0x6000020  System.Int32 Cancel(System.Int64 taskId)
  RVA=0x0886E200  token=0x6000021  System.Int32 Install(System.Int64 taskId)
  RVA=0x0886DD40  token=0x6000022  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  RVA=0x0886DDC0  token=0x6000023  System.Int64 GetDownloadedSize(System.Int64 taskId)
  RVA=0x0886E080  token=0x6000024  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  RVA=0x0886DE40  token=0x6000025  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  RVA=0x0886E300  token=0x6000026  System.Int32 SetNotificationTitle(System.String titleConfig)
END_CLASS

CLASS: Hypergryph.SDK.HGGameUpdateSDKPluginDefault
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x10
IMPLEMENTS: Hypergryph.SDK.IHGGameUpdateSDK
FIELDS:
METHODS:
  RVA=0x0886DA28  token=0x600002A  System.Int32 Init(System.String config)
  RVA=0x0886D8F8  token=0x600002B  System.Void GetLatestGame(System.Action<System.String> onResult)
  RVA=0x0886DB68  token=0x600002C  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  RVA=0x0886D7B8  token=0x600002D  System.Int32 EnableMobileData(System.Int64 taskId)
  RVA=0x0886D988  token=0x600002E  System.Int32 GetTaskState(System.Int64 taskId)
  RVA=0x0886DAC8  token=0x600002F  System.Int32 Resume(System.Int64 taskId)
  RVA=0x0886D718  token=0x6000030  System.Int32 CancelAndClear(System.Int64 taskId)
  RVA=0x0886D768  token=0x6000031  System.Int32 Cancel(System.Int64 taskId)
  RVA=0x0886DA78  token=0x6000032  System.Int32 Install(System.Int64 taskId)
  RVA=0x0886D808  token=0x6000033  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  RVA=0x0886D858  token=0x6000034  System.Int64 GetDownloadedSize(System.Int64 taskId)
  RVA=0x0886D9D8  token=0x6000035  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  RVA=0x0886D8A8  token=0x6000036  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  RVA=0x0886DB18  token=0x6000037  System.Int32 SetNotificationTitle(System.String titleConfig)
  RVA=0x0350B670  token=0x6000038  System.Void .ctor()
END_CLASS

