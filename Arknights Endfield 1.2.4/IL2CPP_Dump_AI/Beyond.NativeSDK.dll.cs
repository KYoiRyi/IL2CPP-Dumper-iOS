// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.NativeSDK.dll
// Classes:  16
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

CLASS: PROCESS_MEMORY_COUNTERS
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x58
FIELDS:
  public            System.UInt32                   cb  // 0x10
  public            System.UInt32                   PageFaultCount  // 0x14
  public            System.UInt64                   PeakWorkingSetSize  // 0x18
  public            System.UInt64                   WorkingSetSize  // 0x20
  public            System.UInt64                   QuotaPeakPagedPoolUsage  // 0x28
  public            System.UInt64                   QuotaPagedPoolUsage  // 0x30
  public            System.UInt64                   QuotaPeakNonPagedPoolUsage  // 0x38
  public            System.UInt64                   QuotaNonPagedPoolUsage  // 0x40
  public            System.UInt64                   PagefileUsage  // 0x48
  public            System.UInt64                   PeakPagefileUsage  // 0x50
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x20
FIELDS:
  public            System.Int32                    CStatus  // 0x10
  public            System.Int64                    largeValue  // 0x18
METHODS:
END_CLASS

CLASS: STORAGE_PROPERTY_QUERY
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x1C
FIELDS:
  public            System.UInt32                   PropertyId  // 0x10
  public            System.UInt32                   QueryType  // 0x14
  public            System.Byte                     AdditionalParameters  // 0x18
METHODS:
END_CLASS

CLASS: DEVICE_SEEK_PENALTY_DESCRIPTOR
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x1C
FIELDS:
  public            System.UInt32                   Version  // 0x10
  public            System.UInt32                   Size  // 0x14
  public            System.Boolean                  IncursSeekPenalty  // 0x18
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.NativeSDK.NativeWindowsDiskChecker.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Boolean><>9__22_0  // static @ 0x8
METHODS:
  RVA=0x03D12890  token=0x6000027  System.Void .cctor()
  RVA=0x0350B670  token=0x6000028  System.Void .ctor()
  RVA=0x03B2C400  token=0x6000029  System.Boolean <StandaloneWinHaveSSd>b__22_0(System.String s)
END_CLASS

CLASS: SYSTEM_POWER_STATUS
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x1C
FIELDS:
  public            System.Byte                     ACLineStatus  // 0x10
  public            System.Byte                     BatteryFlag  // 0x11
  public            System.Byte                     BatteryLifePercent  // 0x12
  public            System.Byte                     Reserved1  // 0x13
  public            System.UInt32                   BatteryLifeTime  // 0x14
  public            System.UInt32                   BatteryFullLifeTime  // 0x18
METHODS:
END_CLASS

CLASS: PROCESS_MEMORY_COUNTERS
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x58
FIELDS:
  public            System.UInt32                   cb  // 0x10
  public            System.UInt32                   PageFaultCount  // 0x14
  public            System.UInt64                   PeakWorkingSetSize  // 0x18
  public            System.UInt64                   WorkingSetSize  // 0x20
  public            System.UInt64                   QuotaPeakPagedPoolUsage  // 0x28
  public            System.UInt64                   QuotaPagedPoolUsage  // 0x30
  public            System.UInt64                   QuotaPeakNonPagedPoolUsage  // 0x38
  public            System.UInt64                   QuotaNonPagedPoolUsage  // 0x40
  public            System.UInt64                   PagefileUsage  // 0x48
  public            System.UInt64                   PeakPagefileUsage  // 0x50
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x20
FIELDS:
  public            System.Int32                    CStatus  // 0x10
  public            System.Int64                    largeValue  // 0x18
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE_ITEM
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x28
FIELDS:
  public            System.IntPtr                   szName  // 0x10
  public            Beyond.NativeSDK.VideoMemoryStatus.PDH_FMT_COUNTERVALUEFmtValue  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.NativeSDK.NativeUtil
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    s_procId  // static @ 0x0
  public    static  System.ValueTuple<System.Int64,System.Int64>s_DedicatedGpuMem  // static @ 0x8
  public    static  System.ValueTuple<System.Int64,System.Int64>s_SharedMemoryGpuMem  // static @ 0x18
  public    static  System.ValueTuple<System.Int64,System.Int64>s_CommittedMemoryGpuMem  // static @ 0x28
  public    static  System.String                   s_gpuMemQuery  // static @ 0x38
  public    static  System.Int32                    s_frequencyCalcTimes  // static @ 0x40
  private   static  System.Int64                    _calcResult  // static @ 0x48
  private   static readonly System.Diagnostics.Stopwatch    SW  // static @ 0x50
METHODS:
  RVA=0x03D4C360  token=0x6000001  System.Void _Clear()
  RVA=0x0516CD3C  token=0x6000002  System.Boolean IsPromotionSupport()
  RVA=0x0516CAF0  token=0x6000003  System.Int64 GetAvailableMemory()
  RVA=0x03D44F80  token=0x6000004  System.Int64 GetOOMMemory()
  RVA=0x02C9C1F0  token=0x6000005  System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.NativeUtil.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size)
  RVA=0x0516CF7C  token=0x6000006  System.Int32 PdhOpenQueryA(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery)
  RVA=0x0516CD78  token=0x6000007  System.Int32 PdhAddEnglishCounterA(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter)
  RVA=0x0516CE68  token=0x6000008  System.Int32 PdhCollectQueryData(System.IntPtr hQuery)
  RVA=0x0516CEDC  token=0x6000009  System.Int32 PdhGetFormattedCounterValue(System.IntPtr hQuery, System.Int32 dwFormat, System.Int32* lpdwType, Beyond.NativeSDK.NativeUtil.PDH_FMT_COUNTERVALUE& pValue)
  RVA=0x0516CE30  token=0x600000A  System.Int32 PdhCloseQuery(System.IntPtr hQuery)
  RVA=0x0516CBAC  token=0x600000B  System.Int32 GetProcId()
  RVA=0x0516D04C  token=0x600000C  System.Int64 getRSSMemoryByte()
  RVA=0x02C9A780  token=0x600000D  System.Int64 GetTotalMemory()
  RVA=0x0516CD00  token=0x600000E  System.Int64 GetVirtualMemory()
  RVA=0x02C9A0E0  token=0x600000F  System.Int64 GetGpuMemory()
  RVA=0x02C9A3A0  token=0x6000010  System.Single GetCpuTemperature()
  RVA=0x02C9A3C0  token=0x6000011  System.Single GetGpuTemperature()
  RVA=0x0516CB70  token=0x6000012  System.Int64 GetCpuFrequency()
  RVA=0x0516CB30  token=0x6000013  System.Single GetBatteryLevel()
  RVA=0x03CF0140  token=0x6000014  System.Boolean IsLapTop()
  RVA=0x02C9A090  token=0x6000015  System.Boolean IsCharge()
  RVA=0x02C9A0C0  token=0x6000016  System.Int32 GetThermalState()
  RVA=0x03D47680  token=0x6000017  System.Boolean IsInSsd()
  RVA=0x03D476B0  token=0x6000018  System.Boolean HasSsd()
  RVA=0x02C9A560  token=0x6000019  System.Double GetFrequencyCalculateTime()
  RVA=0x0516D010  token=0x600001A  System.Int64 RunCpuFrequencyCalculate(System.Int32 times)
  RVA=0x03B5B510  token=0x600001B  System.Void .cctor()
END_CLASS

CLASS: Beyond.NativeSDK.NativeWindowsDiskChecker
TYPE:  static class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
  private   static  System.UInt32                   STORAGEDEVICESEEKPENALTYPROPERTY  // const
  private   static  System.UInt32                   PROPERTYSTANDARDQUERY  // const
  private   static  System.Int32                    MAX_PATH  // const
  private   static  System.UInt32                   FILE_SHARE_READ  // const
  private   static  System.UInt32                   FILE_SHARE_WRITE  // const
  private   static  System.UInt32                   FILE_SHARE_DELETE  // const
  private   static  System.UInt32                   OPEN_EXISTING  // const
  private   static  System.UInt32                   FILE_FLAG_BACKUP_SEMANTICS  // const
  private   static  System.UInt32                   IOCTL_STORAGE_QUERY_PROPERTY  // const
  private   static  System.Object                   initOnceIsRunningInSSD  // static @ 0x0
  private   static  System.Object                   initOnceStandaloneWinHaveSSd  // static @ 0x8
METHODS:
  RVA=0x02C999B0  token=0x600001C  System.Boolean GetVolumePathName(System.String lpszFileName, System.IntPtr lpszVolumePathName, System.UInt32 cchBufferLength)
  RVA=0x02C99A30  token=0x600001D  System.Boolean GetVolumeNameForVolumeMountPoint(System.String lpszVolumeMountPoint, System.IntPtr lpszVolumeName, System.UInt32 cchBufferLength)
  RVA=0x02C99FF0  token=0x600001E  System.IntPtr CreateFile(System.String lpFileName, System.UInt32 dwDesiredAccess, System.UInt32 dwShareMode, System.IntPtr lpSecurityAttributes, System.UInt32 dwCreationDisposition, System.UInt32 dwFlagsAndAttributes, System.IntPtr hTemplateFile)
  RVA=0x02C99850  token=0x600001F  System.Boolean CloseHandle(System.IntPtr hObject)
  RVA=0x022C6A80  token=0x6000020  System.Int32 GetLogicalDriveStrings(System.UInt32 nBufferLength, System.Char[] lpBuffer)
  RVA=0x02C99900  token=0x6000021  System.Boolean DeviceIoControl(System.IntPtr hDevice, System.UInt32 dwIoControlCode, Beyond.NativeSDK.NativeWindowsDiskChecker.STORAGE_PROPERTY_QUERY& lpInBuffer, System.UInt32 nInBufferSize, Beyond.NativeSDK.NativeWindowsDiskChecker.DEVICE_SEEK_PENALTY_DESCRIPTOR& lpOutBuffer, System.UInt32 nOutBufferSize, System.UInt32& lpBytesReturned, System.IntPtr lpOverlapped)
  RVA=0x02C99C70  token=0x6000022  System.IntPtr GetVolumeHandleForFile(System.String filePath)
  RVA=0x02C99AB0  token=0x6000023  System.Boolean IsFileOnSsd(System.String filePath)
  RVA=0x0315AA70  token=0x6000024  System.Boolean IsRunningInSSD()
  RVA=0x022C5860  token=0x6000025  System.Boolean StandaloneWinHaveSSd()
  RVA=0x0516D394  token=0x6000026  System.Void Test()
END_CLASS

CLASS: Beyond.NativeSDK.NativePower
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x022C6B30  token=0x600002A  System.Boolean GetSystemPowerStatus(Beyond.NativeSDK.NativePower.SYSTEM_POWER_STATUS& sps)
  RVA=0x03CF0170  token=0x600002B  System.Boolean laptop()
END_CLASS

CLASS: Beyond.NativeSDK.VideoMemoryStatus
TYPE:  static class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    PDH_FMT_LARGE  // static @ 0x0
  private   static  System.Int64                    PDH_MORE_DATA  // static @ 0x8
  private   static  System.String                   Command  // const
METHODS:
  RVA=0x0516D3D4  token=0x600002C  System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.VideoMemoryStatus.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size)
  RVA=0x036A0C10  token=0x600002D  System.Int64 PdhOpenQuery(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery)
  RVA=0x036A0C80  token=0x600002E  System.Int64 PdhAddCounter(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter)
  RVA=0x036A0D00  token=0x600002F  System.Int64 PdhCollectQueryData(System.IntPtr hQuery)
  RVA=0x036A0D60  token=0x6000030  System.Int64 PdhGetFormattedCounterArray(System.IntPtr hQuery, System.Int32 dwFormat, System.UInt32& dwBufferSize, System.UInt32& dwItemCount, System.IntPtr itemBuffer)
  RVA=0x036A0DE0  token=0x6000031  System.Int32 PdhCloseQuery(System.IntPtr hQuery)
  RVA=0x02C9A310  token=0x6000032  System.ValueTuple<System.Int64,System.Int64> GetDedicatedMemoryStatus()
  RVA=0x02C9A280  token=0x6000033  System.ValueTuple<System.Int64,System.Int64> GetSharedMemoryStatus()
  RVA=0x02C9A1F0  token=0x6000034  System.ValueTuple<System.Int64,System.Int64> GetCommittedMemoryStatus()
  RVA=0x025FB2E0  token=0x6000035  System.ValueTuple<System.Int64,System.Int64> GetMemoryStatus(System.String type)
  RVA=0x03D49110  token=0x6000036  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x051624BC  token=0x6000037  System.Void __Gen_Wrap_0()
  RVA=0x0514F380  token=0x6000038  System.Boolean __Gen_Wrap_1()
  RVA=0x0516C778  token=0x6000039  System.Int64 __Gen_Wrap_2()
  RVA=0x050EF068  token=0x600003A  System.Int32 __Gen_Wrap_3()
  RVA=0x0516C824  token=0x600003B  System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_4(System.Object P0)
  RVA=0x0516C930  token=0x600003C  System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_5()
  RVA=0x050F18D0  token=0x600003D  System.Single __Gen_Wrap_6()
  RVA=0x0516CA20  token=0x600003E  System.IntPtr __Gen_Wrap_7(System.Object P0)
  RVA=0x0514EF5C  token=0x600003F  System.Boolean __Gen_Wrap_8(System.Object P0)
  RVA=0x0516C6E0  token=0x6000040  System.Double __Gen_Wrap_10()
  RVA=0x03D05FE0  token=0x6000041  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0516D470  token=0x6000042  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x02C9A710  token=0x6000043  System.Boolean IsPatched(System.Int32 id)
END_CLASS

