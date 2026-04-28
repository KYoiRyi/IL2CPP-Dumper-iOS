// ========================================================
// Dumped by @desirepro
// Assembly: HGSDKInterfaces.dll
// Classes:  34
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

CLASS: CSLogSeverity
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CSLogSeverity                   LogSilent  // const
  public    static  CSLogSeverity                   LogError  // const
  public    static  CSLogSeverity                   LogWarning  // const
  public    static  CSLogSeverity                   LogInfo  // const
  public    static  CSLogSeverity                   LogDebug  // const
  public    static  CSLogSeverity                   LogVerbose  // const
METHODS:
END_CLASS

CLASS: CSReportType
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CSReportType                    InterfaceReport  // const
  public    static  CSReportType                    LogCallback  // const
  public    static  CSReportType                    LogCallbackThreaded  // const
METHODS:
END_CLASS

CLASS: JankReportInfoOption
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  JankReportInfoOption            JankOnlyBasicInfo  // const
  public    static  JankReportInfoOption            JankSystemLog  // const
  public    static  JankReportInfoOption            JankCustomLog  // const
  public    static  JankReportInfoOption            JankCustomKv  // const
  public    static  JankReportInfoOption            JankCallbackInfo  // const
  public    static  JankReportInfoOption            JankAutoDumpStack  // const
  public    static  JankReportInfoOption            JankAndroidAllJavaStack  // const
METHODS:
END_CLASS

CLASS: HGCrashSightCallback
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x10
EXTENDS: CrashSightCallback
FIELDS:
METHODS:
  RVA=0x02D7B150  token=0x6000065  System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType)
  RVA=0x0350B670  token=0x6000066  System.Void .ctor()
END_CLASS

CLASS: HGCrashSightLogCallback
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
EXTENDS: CrashSightLogCallback
FIELDS:
METHODS:
  RVA=0x087C813C  token=0x6000067  System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType)
  RVA=0x087C7FDC  token=0x6000068  System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  RVA=0x0350B670  token=0x6000069  System.Void .ctor()
END_CLASS

CLASS: LogCallbackDelegate
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x054E1E0C  token=0x600006A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x011360D0  token=0x600006B  System.Void Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  RVA=0x087C8210  token=0x600006C  System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600006D  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LogFilterDelegate
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x03CC1F40  token=0x600006E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x600006F  System.Boolean Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  RVA=0x087C8298  token=0x6000070  System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD8EC  token=0x6000071  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CrashSightAgent
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
  private   static  CrashSightAgent.HGCrashSightCallback_crashSightCallback  // static @ 0x0
  private   static  CrashSightAgent.HGCrashSightLogCallback_crashSightLogCallback  // static @ 0x8
  private   static  System.String                   crashUploadUrl  // static @ 0x10
  public    static  System.Collections.Generic.List<System.Int32>callbackThreads  // static @ 0x18
  public    static  System.Object                   callbackThreadsLock  // static @ 0x20
  private   static  CrashSightAgent.LogCallbackDelegate_LogCallbackEventHandler  // static @ 0x28
  private   static  CrashSightAgent.LogFilterDelegates_logFilter  // static @ 0x30
  private   static  System.Boolean                  _isInitialized  // static @ 0x38
  private   static  UnityEngine.LogType             _autoReportLogLevel  // static @ 0x3c
  private   static  System.Boolean                  _debugMode  // static @ 0x40
  private   static  System.Boolean                  _autoQuitApplicationAfterReport  // static @ 0x41
  private   static  System.Func<System.Collections.Generic.Dictionary<System.String,System.String>>_LogCallbackExtrasHandler  // static @ 0x48
  private   static  System.Boolean                  _uncaughtAutoReportOnce  // static @ 0x50
  public    static readonly System.String                   s_UnityBuildVersion  // static @ 0x58
  public    static readonly System.String                   s_CommandLine  // static @ 0x60
  public    static readonly System.String                   s_UserName  // static @ 0x68
  public    static readonly System.String                   s_UserDomainName  // static @ 0x70
  public    static readonly System.String                   s_DeviceModel  // static @ 0x78
  public    static readonly System.String                   s_DeviceName  // static @ 0x80
  public    static readonly System.String                   s_DeviceUniqueIdentifier  // static @ 0x88
  public    static readonly System.String                   s_DeviceType  // static @ 0x90
  public    static readonly System.String                   s_GraphicsDeviceName  // static @ 0x98
  public    static readonly System.String                   s_GraphicsDeviceType  // static @ 0xa0
  public    static readonly System.String                   s_GraphicsDeviceVersion  // static @ 0xa8
  public    static readonly System.String                   s_GraphicsDeviceVendor  // static @ 0xb0
  public    static readonly System.Int32                    s_GraphicsMemorySize  // static @ 0xb8
  public    static readonly System.String                   s_NvidiaDriverVersion  // static @ 0xc0
  public    static readonly System.String[]                 s_BootParams  // static @ 0xc8
PROPERTIES:
  AutoQuitApplicationAfterReport  get=0x087C6D00
  IsInitialized  get=0x087C6D50
EVENTS:
  _LogCallbackEventHandler  add=add__LogCallbackEventHandler  remove=remove__LogCallbackEventHandler
METHODS:
  RVA=0x087C5918  token=0x6000003  System.Void SetLogFilter(CrashSightAgent.LogFilterDelegate filter)
  RVA=0x02CD63A0  token=0x6000004  System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread)
  RVA=0x087C51B8  token=0x6000005  System.Void ReportException(System.Exception e, System.String message)
  RVA=0x087C4F9C  token=0x6000006  System.Void ReportException(System.String name, System.String message, System.String stackTrace)
  RVA=0x087C5104  token=0x6000007  System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath)
  RVA=0x02D7BCB0  token=0x6000008  System.Void SetUserId(System.String userId)
  RVA=0x02D7C940  token=0x6000009  System.Void AddSceneData(System.String key, System.String value)
  RVA=0x02D7B0A0  token=0x600000A  System.Void SetUserValue(System.String key, System.Int32 value)
  RVA=0x02D7C8C0  token=0x600000B  System.Void SetUserValue(System.String key, System.String value)
  RVA=0x02D7AF10  token=0x600000C  System.Void SetUserValue(System.String key, System.String[] value)
  RVA=0x03A24A00  token=0x600000D  System.Void SetAppVersion(System.String appVersion)
  RVA=0x03B12E30  token=0x600000E  System.Void ConfigCrashServerUrl(System.String crashServerUrl)
  RVA=0x087C5978  token=0x600000F  System.Void SetLogPath(System.String logPath)
  RVA=0x03A06CF0  token=0x6000010  System.Void ConfigDebugMode(System.Boolean enable)
  RVA=0x087C55D8  token=0x6000011  System.Void SetDeviceId(System.String deviceId)
  RVA=0x087C4468  token=0x6000012  System.Void ConfigCrashReporter(System.Int32 logLevel)
  RVA=0x087C4420  token=0x6000013  System.Void ConfigCrashReporter(CSLogSeverity logLevel)
  RVA=0x02D7C3B0  token=0x6000014  System.Void PrintLog(CSLogSeverity level, System.String format, System.Object[] args)
  RVA=0x087C5F20  token=0x6000015  System.Void TestNativeCrash()
  RVA=0x087C56B8  token=0x6000016  System.Void SetEnvironmentName(System.String serverEnv)
  RVA=0x087C468C  token=0x6000017  System.Void EnableAnrMonitor(System.Int32 timeoutMs)
  RVA=0x087C464C  token=0x6000018  System.Void DisableAnrMonitor()
  RVA=0x02CD65D0  token=0x6000019  System.Void RegisterCrashCallback(CrashSightCallback callback)
  RVA=0x087C6130  token=0x600001A  System.Void UnregisterCrashCallback()
  RVA=0x02CD6690  token=0x600001B  System.Void RegisterCrashLogCallback(CrashSightLogCallback callback)
  RVA=0x087C46D4  token=0x600001C  System.Void EnableExceptionHandler()
  RVA=0x087C4E1C  token=0x600001D  System.Void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
  RVA=0x087C6170  token=0x600001E  System.Void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
  RVA=0x087C5860  token=0x600001F  System.Void SetLogCallbackExtrasHandler(System.Func<System.Collections.Generic.Dictionary<System.String,System.String>> handler)
  RVA=0x087C4384  token=0x6000020  System.Void ConfigAutoQuitApplication(System.Boolean autoQuit)
  RVA=0x02D7CB40  token=0x6000022  System.Void DebugLog(System.String tag, System.String format)
  RVA=0x0267B420  token=0x6000024  System.Void _RegisterExceptionHandler()
  RVA=0x087C6938  token=0x6000025  System.Void _UnregisterExceptionHandler()
  RVA=0x0350B670  token=0x6000026  System.Void SetCrashSightStackTraceEnable(System.Boolean enable)
  RVA=0x087C43D8  token=0x6000027  System.Void ConfigCallbackType(System.Int32 callbackType)
  RVA=0x087C5624  token=0x6000028  System.Void SetDeviceModel(System.String deviceModel)
  RVA=0x087C53A8  token=0x6000029  System.Void ReportLogInfo(System.String msgType, System.String msg)
  RVA=0x087C5AD0  token=0x600002A  System.Void SetScene(System.String sceneId, System.Boolean upload)
  RVA=0x087C5BC8  token=0x600002B  System.Void SetScene(System.Int32 sceneId, System.Boolean upload)
  RVA=0x087C4764  token=0x600002C  System.Int64 GetCrashThreadId()
  RVA=0x087C5540  token=0x600002D  System.Void SetCustomizedDeviceID(System.String deviceId)
  RVA=0x087C48CC  token=0x600002E  System.String GetSDKDefinedDeviceID()
  RVA=0x087C558C  token=0x600002F  System.Void SetCustomizedMatchID(System.String matchId)
  RVA=0x087C490C  token=0x6000030  System.String GetSDKSessionID()
  RVA=0x087C6028  token=0x6000031  System.Void TestOomCrash()
  RVA=0x087C5E9C  token=0x6000032  System.Void TestJavaCrash()
  RVA=0x087C5E18  token=0x6000033  System.Void TestANR()
  RVA=0x087C47F0  token=0x6000034  System.String GetCrashUuid()
  RVA=0x087C59C4  token=0x6000035  System.Void SetLogcatBufferSize(System.Int32 size)
  RVA=0x087C5FA4  token=0x6000036  System.Void TestOcCrash()
  RVA=0x087C5CE8  token=0x6000037  System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath)
  RVA=0x087C5D98  token=0x6000038  System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType)
  RVA=0x087C6C94  token=0x6000039  System.Int32 getExceptionType(System.String name)
  RVA=0x087C60AC  token=0x600003A  System.Void TestUseAfterFree()
  RVA=0x087C4D9C  token=0x600003B  System.Void ReRegistAllMonitors()
  RVA=0x087C4318  token=0x600003C  System.Void CloseAllMonitors()
  RVA=0x087C6F2C  token=0x600003D  System.Void setEnableGetPackageInfo(System.Boolean enable)
  RVA=0x087C6E74  token=0x600003E  System.Void setCatchMultiSignal(System.Boolean enable)
  RVA=0x087C6BDC  token=0x600003F  System.Void enableDetailedPageTracing(System.Boolean enable)
  RVA=0x087C4D14  token=0x6000040  System.Boolean IsLastSessionCrash()
  RVA=0x087C4830  token=0x6000041  System.String GetLastSessionUserId()
  RVA=0x087C4294  token=0x6000042  System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload)
  RVA=0x087C5A0C  token=0x6000043  System.Void SetOomLogPath(System.String logPath)
  RVA=0x087C5314  token=0x6000044  System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath)
  RVA=0x087C5404  token=0x6000045  System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath)
  RVA=0x087C5C28  token=0x6000046  System.Void SetVehEnable(System.Boolean enable)
  RVA=0x087C4EAC  token=0x6000047  System.Void ReportCrash()
  RVA=0x087C4F18  token=0x6000048  System.Void ReportDump(System.String dump_path, System.Boolean is_async)
  RVA=0x087C57EC  token=0x6000049  System.Void SetExtraHandler(System.Boolean extra_handle_enable)
  RVA=0x087C6220  token=0x600004A  System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  RVA=0x087C5670  token=0x600004B  System.Void SetDumpType(System.Int32 dump_type)
  RVA=0x087C4248  token=0x600004C  System.Void AddValidExpCode(System.UInt64 exp_code)
  RVA=0x087C61D4  token=0x600004D  System.Void UploadCrashWithGuid(System.String guid)
  RVA=0x087C54A8  token=0x600004E  System.Void SetCrashUploadEnable(System.Boolean enable)
  RVA=0x087C5C9C  token=0x600004F  System.Void SetWorkSpace(System.String workspace)
  RVA=0x087C54F4  token=0x6000050  System.Void SetCustomAttachDir(System.String path)
  RVA=0x087C5778  token=0x6000051  System.Void SetErrorUploadInterval(System.Int32 interval)
  RVA=0x087C5704  token=0x6000052  System.Void SetErrorUploadEnable(System.Boolean enable)
  RVA=0x087C5A58  token=0x6000053  System.Void SetRecordFileDir(System.String record_dir)
  RVA=0x087C494C  token=0x6000054  System.Void InitContext(System.String userId, System.String version, System.String key)
  RVA=0x087C4B2C  token=0x6000055  System.Void Init(System.String app_id, System.String app_key, System.String app_version)
  RVA=0x087C44B0  token=0x6000056  System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay)
  RVA=0x03CF2D60  token=0x6000057  System.Void _OnLogCallbackHandlerMain(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  RVA=0x02D7ACC0  token=0x6000058  System.Void _OnLogCallbackHandlerThreaded(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  RVA=0x02D7BD90  token=0x6000059  System.Void _OnLogCallbackHandler(System.String condition, System.String stackTrace, UnityEngine.LogType type, CSReportType rType)
  RVA=0x087C677C  token=0x600005A  System.Void _OnUncaughtExceptionHandler(System.Object sender, System.UnhandledExceptionEventArgs args)
  RVA=0x087C62A4  token=0x600005B  System.Void _HandleException(System.Exception e, System.String message, System.Boolean uncaught)
  RVA=0x032D9C00  token=0x600005C  System.Boolean ShouldSkipFrame(System.String frame)
  RVA=0x032D8460  token=0x600005D  System.Void _reportException(System.Boolean uncaught, System.String name, System.String reason, System.String stackTrace)
  RVA=0x02D7C570  token=0x600005E  System.Void AddTrackCustomData()
  RVA=0x0350B670  token=0x600005F  System.Void AddLocalLogFile()
  RVA=0x02D7CEF0  token=0x6000060  System.Int32 valueOf(UnityEngine.LogType logLevel)
  RVA=0x02D7CE60  token=0x6000061  System.Boolean isEnableAutoReport(UnityEngine.LogType logLevel)
  RVA=0x02D7C000  token=0x6000062  System.Void _HandleException(UnityEngine.LogType logLevel, System.String name, System.String message, System.String stackTrace, System.Boolean uncaught, CSReportType rType)
  RVA=0x0350B670  token=0x6000063  System.Void .ctor()
  RVA=0x0315CA60  token=0x6000064  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
  public    static readonly CrashSightAnrMonitor.<>c        <>9  // static @ 0x0
  public    static  System.Action                   <>9__11_0  // static @ 0x8
  public    static  System.Action                   <>9__11_1  // static @ 0x10
  public    static  System.Action                   <>9__11_2  // static @ 0x18
METHODS:
  RVA=0x087C9E44  token=0x600007B  System.Void .cctor()
  RVA=0x0350B670  token=0x600007C  System.Void .ctor()
  RVA=0x087C9D84  token=0x600007D  System.Void <Start>b__11_0()
  RVA=0x087C9DC4  token=0x600007E  System.Void <Start>b__11_1()
  RVA=0x087C9E04  token=0x600007F  System.Void <Start>b__11_2()
END_CLASS

CLASS: <UpdateUiStatus>d__13
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           UnityEngine.WaitForSecondsRealtime<waitForSeconds>5__2  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000080  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000081  System.Void System.IDisposable.Dispose()
  RVA=0x087C9EA8  token=0x6000082  System.Boolean MoveNext()
  RVA=0x087CA004  token=0x6000084  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: CrashSightAnrMonitor
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x10
FIELDS:
  private   static  CrashSightMonoBehaviour         monoBehaviour  // static @ 0x0
  private   static  System.Int32                    anrTimeoutMs  // static @ 0x8
  private   static  System.Int32                    detectionTimeoutMs  // static @ 0xc
  private   static  System.Boolean                  <Paused>k__BackingField  // static @ 0x10
  private   static  System.Int32                    ticksSinceUiUpdate  // static @ 0x14
  private   static  System.Boolean                  reported  // static @ 0x18
  private   static  System.Boolean                  running  // static @ 0x19
  private   static  System.Threading.Thread         thread  // static @ 0x20
PROPERTIES:
  Paused  get=0x087C78F4  set=0x087C7944
METHODS:
  RVA=0x087C730C  token=0x6000074  System.Void Start(System.Int32 timeoutMs)
  RVA=0x087C77A4  token=0x6000075  System.Void Stop()
  RVA=0x087C77F4  token=0x6000076  System.Collections.IEnumerator UpdateUiStatus()
  RVA=0x087C70B0  token=0x6000077  System.Void Run()
  RVA=0x087C6FE4  token=0x6000078  System.Void Report()
  RVA=0x0350B670  token=0x6000079  System.Void .ctor()
  RVA=0x087C7838  token=0x600007A  System.Void .cctor()
END_CLASS

CLASS: UnityAnrException
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x087D1B08  token=0x6000086  System.Void .ctor()
  RVA=0x087D1AAC  token=0x6000087  System.Void .ctor(System.String message)
  RVA=0x087D1B54  token=0x6000088  System.Void .ctor(System.String message, System.Exception innerException)
END_CLASS

CLASS: CrashSightCallback
TYPE:  abstract class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000089  System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType)
  RVA=0x0350B670  token=0x600008A  System.Void .ctor()
END_CLASS

CLASS: CrashSightLogCallback
TYPE:  abstract class
TOKEN: 0x200000F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600008B  System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType)
  RVA=-1  // abstract  token=0x600008C  System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  RVA=0x0350B670  token=0x600008D  System.Void .ctor()
END_CLASS

CLASS: CrashSightMonoBehaviour
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  CrashSightMonoBehaviour         _instance  // static @ 0x0
  private           System.Action                   ApplicationResuming  // 0x18
  private           System.Action                   ApplicationPausing  // 0x20
  private           System.Action                   ApplicationQuitting  // 0x28
  private           System.Boolean                  _isRunning  // 0x30
PROPERTIES:
  Instance  get=0x087C7C54
EVENTS:
  ApplicationResuming  add=add_ApplicationResuming  remove=remove_ApplicationResuming
  ApplicationPausing  add=add_ApplicationPausing  remove=remove_ApplicationPausing
  ApplicationQuitting  add=add_ApplicationQuitting  remove=remove_ApplicationQuitting
METHODS:
  RVA=0x087C7A58  token=0x6000095  System.Void UpdatePauseStatus(System.Boolean paused)
  RVA=0x087C79F4  token=0x6000096  System.Void OnApplicationPause(System.Boolean pauseStatus)
  RVA=0x087C79E8  token=0x6000097  System.Void OnApplicationFocus(System.Boolean hasFocus)
  RVA=0x087C79FC  token=0x6000098  System.Void OnApplicationQuit()
  RVA=0x087C7998  token=0x6000099  System.Void Awake()
  RVA=0x087C7A8C  token=0x600009A  System.Void .ctor()
END_CLASS

CLASS: CrashSightStackTrace
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x10
FIELDS:
  public    static  System.Boolean                  enable  // static @ 0x0
  private   static  System.String                   stackTrace  // static @ 0x8
METHODS:
  RVA=0x0350B670  token=0x600009B  System.Void setEnable(System.Boolean enable)
  RVA=0x087C7F30  token=0x600009C  System.String ExtractStackTrace()
  RVA=0x0350B670  token=0x600009D  System.Void .ctor()
END_CLASS

CLASS: Level
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMLog.Level         None  // const
  public    static  GCloud.UQM.UQMLog.Level         Log  // const
  public    static  GCloud.UQM.UQMLog.Level         Warning  // const
  public    static  GCloud.UQM.UQMLog.Level         Error  // const
METHODS:
END_CLASS

CLASS: UQMRetJsonEventHandler
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x02CD6070  token=0x6000137  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x6000138  System.String Invoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult)
  RVA=0x087D1918  token=0x6000139  System.IAsyncResult BeginInvoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult, System.AsyncCallback callback, System.Object object)
  RVA=0x04276D7C  token=0x600013A  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TOKEN
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNONE  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCURLY_OPEN  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCURLY_CLOSE  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSQUARED_OPEN  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSQUARED_CLOSE  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCOLON  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCOMMA  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSTRING  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNUMBER  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENTRUE  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENFALSE  // const
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNULL  // const
METHODS:
END_CLASS

CLASS: Parser
TYPE:  sealed class
TOKEN: 0x2000020
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.String                   WORD_BREAK  // const
  private           System.IO.StringReader          json  // 0x10
PROPERTIES:
  PeekChar  get=0x087C8E9C
  NextChar  get=0x087C8B6C
  NextWord  get=0x087C8DEC
  NextToken  get=0x087C8BC8
METHODS:
  RVA=0x087C83E8  token=0x600013D  System.Boolean IsWordBreak(System.Char c)
  RVA=0x087C8AF4  token=0x600013E  System.Void .ctor(System.String jsonString)
  RVA=0x087C89FC  token=0x600013F  System.Object Parse(System.String jsonString)
  RVA=0x087C8320  token=0x6000140  System.Void Dispose()
  RVA=0x087C86A0  token=0x6000141  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  RVA=0x087C8460  token=0x6000142  System.Collections.Generic.List<System.Object> ParseArray()
  RVA=0x087C89D8  token=0x6000143  System.Object ParseValue()
  RVA=0x087C8528  token=0x6000144  System.Object ParseByToken(GCloud.UQM.MiniJSON.Json.Parser.TOKEN token)
  RVA=0x087C87AC  token=0x6000145  System.String ParseString()
  RVA=0x087C85DC  token=0x6000146  System.Object ParseNumber()
  RVA=0x087C8358  token=0x6000147  System.Void EatWhitespace()
END_CLASS

CLASS: Serializer
TYPE:  sealed class
TOKEN: 0x2000022
SIZE:  0x18
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  RVA=0x087C9D20  token=0x600014C  System.Void .ctor()
  RVA=0x087C9CA8  token=0x600014D  System.String Serialize(System.Object obj)
  RVA=0x087C9B24  token=0x600014E  System.Void SerializeValue(System.Object value)
  RVA=0x087C927C  token=0x600014F  System.Void SerializeObject(System.Collections.IDictionary obj)
  RVA=0x087C8EF8  token=0x6000150  System.Void SerializeArray(System.Collections.IList anArray)
  RVA=0x087C98AC  token=0x6000151  System.Void SerializeString(System.String str)
  RVA=0x087C9684  token=0x6000152  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: GCloud.UQM.OnUQMRetEventHandler`1
TYPE:  sealed class
TOKEN: 0x2000012
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600009E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600009F  System.Void Invoke(T ret)
  RVA=-1  // runtime  token=0x60000A0  System.IAsyncResult BeginInvoke(T ret, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60000A1  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMStringRetEventHandler`1
TYPE:  sealed class
TOKEN: 0x2000013
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60000A2  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60000A3  System.String Invoke(T ret, T crashType)
  RVA=-1  // runtime  token=0x60000A4  System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60000A5  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMStringRetSetLogPathEventHandler`1
TYPE:  sealed class
TOKEN: 0x2000014
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60000A6  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60000A7  System.String Invoke(T ret, T crashType)
  RVA=-1  // runtime  token=0x60000A8  System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60000A9  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMRetLogUploadEventHandler`1
TYPE:  sealed class
TOKEN: 0x2000015
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60000AA  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60000AB  System.Void Invoke(T ret, T crashType, T result)
  RVA=-1  // runtime  token=0x60000AC  System.IAsyncResult BeginInvoke(T ret, T crashType, T result, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60000AD  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.UQM
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x10
FIELDS:
  public    static  System.String                   LibName  // const
  private   static  System.Boolean                  initialized  // static @ 0x0
  public    static  System.Boolean                  isDebug  // static @ 0x1
METHODS:
  RVA=0x087D19B0  token=0x60000AE  System.Void Init()
  RVA=0x0350B670  token=0x60000AF  System.Void .ctor()
  RVA=0x087D1A74  token=0x60000B0  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.UQMCrashLevel
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelSilent  // const
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelError  // const
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelWarn  // const
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelInfo  // const
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelDebug  // const
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelVerbose  // const
METHODS:
END_CLASS

CLASS: GCloud.UQM.UQMCrash
TYPE:  static class
TOKEN: 0x2000018
SIZE:  0x10
FIELDS:
  private   static  GCloud.UQM.OnUQMStringRetEventHandler<System.Int32>CrashBaseRetEvent  // static @ 0x0
  private   static  GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32>CrashSetLogPathRetEvent  // static @ 0x8
  private   static  GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32>CrashLogUploadRetEvent  // static @ 0x10
  private   static  UnityEngine.AndroidJavaClass    _gameAgentClass  // static @ 0x18
  private   static  System.Boolean                  _isLoadedSo  // static @ 0x20
  private   static  System.Int32                    _gameType  // static @ 0x24
  private   static readonly System.String                   GAME_AGENT_CLASS  // static @ 0x28
PROPERTIES:
  CrashSightPlatform  get=0x087D0DB0
EVENTS:
  CrashBaseRetEvent  add=add_CrashBaseRetEvent  remove=remove_CrashBaseRetEvent
  CrashSetLogPathRetEvent  add=add_CrashSetLogPathRetEvent  remove=remove_CrashSetLogPathRetEvent
  CrashLogUploadRetEvent  add=add_CrashLogUploadRetEvent  remove=remove_CrashLogUploadRetEvent
METHODS:
  RVA=0x087CA2D8  token=0x60000B1  System.Void CS_InitContext(System.String id, System.String version, System.String key)
  RVA=0x022C8670  token=0x60000B2  System.Void CS_ReportExceptionW(System.Int32 type, System.String name, System.String message, System.String stack_trace, System.String extras, System.Boolean is_async, System.String attachmentPath)
  RVA=0x02D7CD30  token=0x60000B3  System.Void CS_SetUserValue(System.String key, System.String value)
  RVA=0x087CA984  token=0x60000B4  System.Void CS_SetVehEnable(System.Boolean enable)
  RVA=0x087CA950  token=0x60000B5  System.Void CS_SetExtraHandler(System.Boolean extra_handle_enable)
  RVA=0x087CA740  token=0x60000B6  System.Void CS_SetCustomLogDirW(System.String log_path)
  RVA=0x02D7B2D0  token=0x60000B7  System.Void CS_SetUserId(System.String user_id)
  RVA=0x087CA3A8  token=0x60000B8  System.Void CS_MonitorEnable(System.Boolean enable)
  RVA=0x02D7CDB0  token=0x60000B9  System.Void CS_PrintLog(System.Int32 level, System.String tag, System.String format, System.String arg)
  RVA=0x087CAB70  token=0x60000BA  System.Void CS_UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  RVA=0x087CA420  token=0x60000BB  System.Void CS_ReportCrash()
  RVA=0x087CA488  token=0x60000BC  System.Void CS_ReportDump(System.String dump_dir, System.Boolean is_async)
  RVA=0x087CA8C4  token=0x60000BD  System.Void CS_SetEnvironmentName(System.String name)
  RVA=0x02CD5E50  token=0x60000BE  System.Void CS_InitWithAppId(System.String app_id)
  RVA=0x03A24B60  token=0x60000BF  System.Void CS_SetAppVersion(System.String app_version)
  RVA=0x022C7F80  token=0x60000C0  System.Void CS_ConfigCrashServerUrl(System.String crash_server_url)
  RVA=0x022C8630  token=0x60000C1  System.Void CS_ConfigDebugMode(System.Boolean enable)
  RVA=0x087CA7C0  token=0x60000C2  System.Void CS_SetDeviceId(System.String device_id)
  RVA=0x087CA260  token=0x60000C3  System.Void CS_ConfigCrashReporter(System.Int32 log_level)
  RVA=0x087CAA7C  token=0x60000C4  System.Void CS_TestNativeCrash()
  RVA=0x087CA84C  token=0x60000C5  System.Void CS_SetDumpType(System.Int32 dump_type)
  RVA=0x087CA1E8  token=0x60000C6  System.Void CS_AddValidExpCode(System.UInt64 exp_code)
  RVA=0x087CAAE4  token=0x60000C7  System.Void CS_UploadCrashWithGuid(System.String guid)
  RVA=0x087CA648  token=0x60000C8  System.Void CS_SetCrashUploadEnable(System.Boolean enable)
  RVA=0x087CA9FC  token=0x60000C9  System.Void CS_SetWorkSpaceW(System.String workspace)
  RVA=0x022C7BE0  token=0x60000CA  System.Void CS_SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale)
  RVA=0x087CA6C0  token=0x60000CB  System.Void CS_SetCustomAttachDirW(System.String log_path)
  RVA=0x087CAC04  token=0x60000CC  System.Void CS_UseSavedUserId(System.Boolean enable)
  RVA=0x087CA51C  token=0x60000CD  System.Void CS_ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int32 checkInterval, System.String name, System.String message, System.String extraInfo, System.Int32 dumpNativeType, System.String attachPath)
  RVA=0x0350B670  token=0x60000D5  System.Void LoadCrashSightCoreSo()
  RVA=0x087CB1D4  token=0x60000D6  System.Void ConfigCallbackType(System.Int32 callbackType)
  RVA=0x02CD5EB0  token=0x60000D7  System.Void ConfigGameType(System.Int32 gameType)
  RVA=0x087CB040  token=0x60000D8  System.Void ConfigAutoReportLogLevel(System.Int32 level)
  RVA=0x03B12EE0  token=0x60000D9  System.Void ConfigCrashServerUrl(System.String serverUrl)
  RVA=0x03A06DE0  token=0x60000DA  System.Void ConfigDebugMode(System.Boolean enable)
  RVA=0x087CB35C  token=0x60000DB  System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay)
  RVA=0x02CD5D60  token=0x60000DC  System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread)
  RVA=0x087CBD10  token=0x60000DD  System.Void InitContext(System.String userId, System.String version, System.String key)
  RVA=0x02D7C440  token=0x60000DE  System.Void LogRecord(System.Int32 level, System.String message)
  RVA=0x02D7CBD0  token=0x60000DF  System.Void AddSceneData(System.String k, System.String v)
  RVA=0x02D7EAC0  token=0x60000E0  System.Void ReportException(System.Int32 type, System.String name, System.String message, System.String stackTrace, System.String extras, System.Boolean quitProgram)
  RVA=0x087CCFE8  token=0x60000E1  System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath)
  RVA=0x02D7B210  token=0x60000E2  System.Void SetUserId(System.String userId)
  RVA=0x087CF114  token=0x60000E3  System.Void SetScene(System.String sceneId, System.Boolean upload)
  RVA=0x087CCB44  token=0x60000E4  System.Void ReRegistAllMonitors()
  RVA=0x087CAED8  token=0x60000E5  System.Void CloseAllMonitors()
  RVA=0x087CD504  token=0x60000E6  System.Void ReportLogInfo(System.String msgType, System.String msg)
  RVA=0x03A24AB0  token=0x60000E7  System.Void SetAppVersion(System.String appVersion)
  RVA=0x087CE098  token=0x60000E8  System.Void SetDeviceId(System.String deviceId)
  RVA=0x087CDDA0  token=0x60000E9  System.Void SetCustomizedDeviceID(System.String deviceId)
  RVA=0x087CBA18  token=0x60000EA  System.String GetSDKDefinedDeviceID()
  RVA=0x087CDF1C  token=0x60000EB  System.Void SetCustomizedMatchID(System.String matchId)
  RVA=0x087CBB94  token=0x60000EC  System.String GetSDKSessionID()
  RVA=0x087CB720  token=0x60000ED  System.String GetCrashUuid()
  RVA=0x087CE220  token=0x60000EE  System.Void SetDeviceModel(System.String deviceModel)
  RVA=0x087CEB3C  token=0x60000EF  System.Void SetLogPath(System.String logPath)
  RVA=0x02CD64F0  token=0x60000F0  System.Void SetCrashCallback()
  RVA=0x087D05EC  token=0x60000F1  System.Void UnsetCrashCallback()
  RVA=0x02CD6560  token=0x60000F2  System.Void SetCrashLogCallback()
  RVA=0x02D7BB40  token=0x60000F3  System.String OnCrashCallbackMessage(System.Int32 methodId, System.Int32 crashType)
  RVA=0x087CC224  token=0x60000F4  System.String OnCrashCallbackData(System.Int32 methodId, System.Int32 crashType)
  RVA=0x087CC7D8  token=0x60000F5  System.String OnCrashSetLogPathMessage(System.Int32 methodId, System.Int32 crashType)
  RVA=0x087CC5DC  token=0x60000F6  System.String OnCrashLogUploadMessage(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  RVA=0x087CC400  token=0x60000F7  System.String OnCrashCallbackNoRet(System.Int32 methodId, System.Int32 crashType)
  RVA=0x02CD67A0  token=0x60000F8  System.Void ConfigCallBack()
  RVA=0x087D0598  token=0x60000F9  System.Void UnregisterCallBack()
  RVA=0x02CD6800  token=0x60000FA  System.Void ConfigLogCallBack()
  RVA=0x087D02C8  token=0x60000FB  System.Void TestOomCrash()
  RVA=0x087CFE88  token=0x60000FC  System.Void TestJavaCrash()
  RVA=0x087D0160  token=0x60000FD  System.Void TestOcCrash()
  RVA=0x087CFFF0  token=0x60000FE  System.Void TestNativeCrash()
  RVA=0x087CFD20  token=0x60000FF  System.Void TestANR()
  RVA=0x087CB5CC  token=0x6000100  System.Int64 GetCrashThreadId()
  RVA=0x087CECC4  token=0x6000101  System.Void SetLogcatBufferSize(System.Int32 size)
  RVA=0x087CDA2C  token=0x6000102  System.Void SetCallbackMsg(System.String data)
  RVA=0x087CF78C  token=0x6000103  System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath)
  RVA=0x087CFAE0  token=0x6000104  System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType)
  RVA=0x087D0C30  token=0x6000105  System.Int32 getExceptionType(System.String name)
  RVA=0x087D0430  token=0x6000106  System.Void TestUseAfterFree()
  RVA=0x087CF2D0  token=0x6000107  System.Void SetServerEnv(System.String serverEnv)
  RVA=0x087CF458  token=0x6000108  System.Void SetVehEnable(System.Boolean enable)
  RVA=0x087CCCAC  token=0x6000109  System.Void ReportCrash()
  RVA=0x087CCE1C  token=0x600010A  System.Void ReportDump(System.String dump_path, System.Boolean is_async)
  RVA=0x087CE990  token=0x600010B  System.Void SetExtraHandler(System.Boolean extra_handle_enable)
  RVA=0x087D08C4  token=0x600010C  System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  RVA=0x087CE820  token=0x600010D  System.Void SetErrorUploadInterval(System.Int32 interval)
  RVA=0x087CE698  token=0x600010E  System.Void SetErrorUploadEnable(System.Boolean enable)
  RVA=0x087CEFB0  token=0x600010F  System.Void SetRecordFileDir(System.String record_dir)
  RVA=0x087CBEB8  token=0x6000110  System.Void Init(System.String app_id, System.String app_key, System.String app_version)
  RVA=0x087D1288  token=0x6000111  System.Void setEnableGetPackageInfo(System.Boolean enable)
  RVA=0x087CE39C  token=0x6000112  System.Void SetDumpType(System.Int32 dump_type)
  RVA=0x087CA050  token=0x6000113  System.Void AddValidExpCode(System.UInt64 exp_code)
  RVA=0x087D073C  token=0x6000114  System.Void UploadCrashWithGuid(System.String guid)
  RVA=0x087CDBA8  token=0x6000115  System.Void SetCrashUploadEnable(System.Boolean enable)
  RVA=0x087CF604  token=0x6000116  System.Void SetWorkSpace(System.String workspace)
  RVA=0x0399E800  token=0x6000117  System.Void SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale)
  RVA=0x087D10E8  token=0x6000118  System.Void setCatchMultiSignal(System.Boolean enable)
  RVA=0x087D0A90  token=0x6000119  System.Void enableDetailedPageTracing(System.Boolean enable)
  RVA=0x087D1428  token=0x600011A  System.Void useSavedUserId(System.Boolean enable)
  RVA=0x087CDD54  token=0x600011B  System.Void SetCustomAttachDir(System.String path)
  RVA=0x087CC0D0  token=0x600011C  System.Boolean IsLastSessionCrash()
  RVA=0x087CB89C  token=0x600011D  System.String GetLastSessionUserId()
  RVA=0x087CAC7C  token=0x600011E  System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload)
  RVA=0x087CEE34  token=0x600011F  System.Void SetOomLogPath(System.String logPath)
  RVA=0x087CD1EC  token=0x6000120  System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath)
  RVA=0x087CC9BC  token=0x6000121  System.Void ProcessEngineAnr(System.Int32 type)
  RVA=0x087CE530  token=0x6000122  System.Void SetEngineMainThread()
  RVA=0x087CD66C  token=0x6000123  System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath)
  RVA=0x03CB9980  token=0x6000124  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.UQMMethodNameID
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_EXTRA_DATA  // const
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_EXTRA_MESSAGE  // const
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_SET_LOG_PATH  // const
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT  // const
METHODS:
END_CLASS

CLASS: GCloud.UQM.UQMLog
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x10
FIELDS:
  private   static  GCloud.UQM.UQMLog.Level         level  // static @ 0x0
  private   static  System.String                   header  // const
METHODS:
  RVA=0x087D1870  token=0x6000125  System.Void SetLevel(GCloud.UQM.UQMLog.Level l)
  RVA=0x02D7CCB0  token=0x6000126  System.Void Log(System.String message)
  RVA=0x087D17E0  token=0x6000127  System.Void LogWarning(System.String message)
  RVA=0x087D1750  token=0x6000128  System.Void LogError(System.String message)
  RVA=0x087D15D4  token=0x6000129  System.Void FullLog(System.String message)
  RVA=0x0350B670  token=0x600012A  System.Void .ctor()
  RVA=0x03D438A0  token=0x600012B  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.RetArgsWrapper
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x20
FIELDS:
  private   readonly System.Int32                    methodId  // 0x10
  private   readonly System.Int32                    crashType  // 0x14
  private   readonly System.Int32                    logUploadResult  // 0x18
PROPERTIES:
  MethodId  get=0x03D4E340
  CrashType  get=0x03D50CC0
  LogUploadResult  get=0x020D1AC0
METHODS:
  RVA=0x03D51130  token=0x600012F  System.Void .ctor(System.Int32 _methodId, System.Int32 _crashType, System.Int32 _logUploadResult)
END_CLASS

CLASS: GCloud.UQM.UQMMessageCenter
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.Boolean                  initialzed  // static @ 0x0
  private   static  GCloud.UQM.UQMMessageCenter     instance  // static @ 0x8
PROPERTIES:
  Instance  get=0x02CD68B0
METHODS:
  RVA=0x02D7B320  token=0x6000130  System.String OnUQMRet(System.Int32 methodId, System.Int32 crashType, System.Int32 logUploadResult)
  RVA=0x022C6F10  token=0x6000131  System.Void cs_setUnityCallback(GCloud.UQM.UQMMessageCenter.UQMRetJsonEventHandler eventHandler)
  RVA=0x02CD5F80  token=0x6000133  System.Void Init()
  RVA=0x087D18C4  token=0x6000134  System.Void Uninit()
  RVA=0x02D7B9E0  token=0x6000135  System.String SynchronousDelegate(System.Object arg)
  RVA=0x0426FE60  token=0x6000136  System.Void .ctor()
END_CLASS

CLASS: GCloud.UQM.MiniJSON.Json
TYPE:  static class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x087C81EC  token=0x600013B  System.Object Deserialize(System.String json)
  RVA=0x087C8208  token=0x600013C  System.String Serialize(System.Object obj)
END_CLASS

