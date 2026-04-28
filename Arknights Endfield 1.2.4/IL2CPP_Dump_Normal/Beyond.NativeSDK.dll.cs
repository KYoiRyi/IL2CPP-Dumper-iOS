// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.NativeSDK.dll
// Classes:  16
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x58
    public sealed struct PROCESS_MEMORY_COUNTERS
    {
        // Fields
        public System.UInt32 cb;  // 0x10
        public System.UInt32 PageFaultCount;  // 0x14
        public System.UInt64 PeakWorkingSetSize;  // 0x18
        public System.UInt64 WorkingSetSize;  // 0x20
        public System.UInt64 QuotaPeakPagedPoolUsage;  // 0x28
        public System.UInt64 QuotaPagedPoolUsage;  // 0x30
        public System.UInt64 QuotaPeakNonPagedPoolUsage;  // 0x38
        public System.UInt64 QuotaNonPagedPoolUsage;  // 0x40
        public System.UInt64 PagefileUsage;  // 0x48
        public System.UInt64 PeakPagefileUsage;  // 0x50

    }

    // TypeToken: 0x2000004  // size: 0x20
    public sealed struct PDH_FMT_COUNTERVALUE
    {
        // Fields
        public System.Int32 CStatus;  // 0x10
        public System.Int64 largeValue;  // 0x18

    }

    // TypeToken: 0x2000006  // size: 0x1C
    public sealed struct STORAGE_PROPERTY_QUERY
    {
        // Fields
        public System.UInt32 PropertyId;  // 0x10
        public System.UInt32 QueryType;  // 0x14
        public System.Byte AdditionalParameters;  // 0x18

    }

    // TypeToken: 0x2000007  // size: 0x1C
    public sealed struct DEVICE_SEEK_PENALTY_DESCRIPTOR
    {
        // Fields
        public System.UInt32 Version;  // 0x10
        public System.UInt32 Size;  // 0x14
        public System.Boolean IncursSeekPenalty;  // 0x18

    }

    // TypeToken: 0x2000008  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.NativeSDK.NativeWindowsDiskChecker.<>c <>9;  // static @ 0x0
        public static System.Func<System.String,System.Boolean> <>9__22_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D12890  token: 0x6000027
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000028
        public System.Void .ctor() { }
        // RVA: 0x03B2C400  token: 0x6000029
        private System.Boolean <StandaloneWinHaveSSd>b__22_0(System.String s) { }

    }

    // TypeToken: 0x200000A  // size: 0x1C
    public sealed struct SYSTEM_POWER_STATUS
    {
        // Fields
        public System.Byte ACLineStatus;  // 0x10
        public System.Byte BatteryFlag;  // 0x11
        public System.Byte BatteryLifePercent;  // 0x12
        public System.Byte Reserved1;  // 0x13
        public System.UInt32 BatteryLifeTime;  // 0x14
        public System.UInt32 BatteryFullLifeTime;  // 0x18

    }

    // TypeToken: 0x200000C  // size: 0x58
    public sealed struct PROCESS_MEMORY_COUNTERS
    {
        // Fields
        public System.UInt32 cb;  // 0x10
        public System.UInt32 PageFaultCount;  // 0x14
        public System.UInt64 PeakWorkingSetSize;  // 0x18
        public System.UInt64 WorkingSetSize;  // 0x20
        public System.UInt64 QuotaPeakPagedPoolUsage;  // 0x28
        public System.UInt64 QuotaPagedPoolUsage;  // 0x30
        public System.UInt64 QuotaPeakNonPagedPoolUsage;  // 0x38
        public System.UInt64 QuotaNonPagedPoolUsage;  // 0x40
        public System.UInt64 PagefileUsage;  // 0x48
        public System.UInt64 PeakPagefileUsage;  // 0x50

    }

    // TypeToken: 0x200000D  // size: 0x20
    public sealed struct PDH_FMT_COUNTERVALUE
    {
        // Fields
        public System.Int32 CStatus;  // 0x10
        public System.Int64 largeValue;  // 0x18

    }

    // TypeToken: 0x200000E  // size: 0x28
    public sealed struct PDH_FMT_COUNTERVALUE_ITEM
    {
        // Fields
        public System.IntPtr szName;  // 0x10
        public Beyond.NativeSDK.VideoMemoryStatus.PDH_FMT_COUNTERVALUE FmtValue;  // 0x18

    }

namespace Beyond.NativeSDK
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class NativeUtil
    {
        // Fields
        private static System.Int32 s_procId;  // static @ 0x0
        public static System.ValueTuple<System.Int64,System.Int64> s_DedicatedGpuMem;  // static @ 0x8
        public static System.ValueTuple<System.Int64,System.Int64> s_SharedMemoryGpuMem;  // static @ 0x18
        public static System.ValueTuple<System.Int64,System.Int64> s_CommittedMemoryGpuMem;  // static @ 0x28
        public static System.String s_gpuMemQuery;  // static @ 0x38
        public static System.Int32 s_frequencyCalcTimes;  // static @ 0x40
        private static System.Int64 _calcResult;  // static @ 0x48
        private static readonly System.Diagnostics.Stopwatch SW;  // static @ 0x50

        // Methods
        // RVA: 0x03D4C360  token: 0x6000001
        private static System.Void _Clear() { }
        // RVA: 0x0516CD3C  token: 0x6000002
        public static System.Boolean IsPromotionSupport() { }
        // RVA: 0x0516CAF0  token: 0x6000003
        public static System.Int64 GetAvailableMemory() { }
        // RVA: 0x03D44F80  token: 0x6000004
        public static System.Int64 GetOOMMemory() { }
        // RVA: 0x02C9C1F0  token: 0x6000005
        private static System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.NativeUtil.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size) { }
        // RVA: 0x0516CF7C  token: 0x6000006
        private static System.Int32 PdhOpenQueryA(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery) { }
        // RVA: 0x0516CD78  token: 0x6000007
        private static System.Int32 PdhAddEnglishCounterA(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter) { }
        // RVA: 0x0516CE68  token: 0x6000008
        private static System.Int32 PdhCollectQueryData(System.IntPtr hQuery) { }
        // RVA: 0x0516CEDC  token: 0x6000009
        private static System.Int32 PdhGetFormattedCounterValue(System.IntPtr hQuery, System.Int32 dwFormat, System.Int32* lpdwType, Beyond.NativeSDK.NativeUtil.PDH_FMT_COUNTERVALUE& pValue) { }
        // RVA: 0x0516CE30  token: 0x600000A
        private static System.Int32 PdhCloseQuery(System.IntPtr hQuery) { }
        // RVA: 0x0516CBAC  token: 0x600000B
        public static System.Int32 GetProcId() { }
        // RVA: 0x0516D04C  token: 0x600000C
        public static System.Int64 getRSSMemoryByte() { }
        // RVA: 0x02C9A780  token: 0x600000D
        public static System.Int64 GetTotalMemory() { }
        // RVA: 0x0516CD00  token: 0x600000E
        public static System.Int64 GetVirtualMemory() { }
        // RVA: 0x02C9A0E0  token: 0x600000F
        public static System.Int64 GetGpuMemory() { }
        // RVA: 0x02C9A3A0  token: 0x6000010
        public static System.Single GetCpuTemperature() { }
        // RVA: 0x02C9A3C0  token: 0x6000011
        public static System.Single GetGpuTemperature() { }
        // RVA: 0x0516CB70  token: 0x6000012
        public static System.Int64 GetCpuFrequency() { }
        // RVA: 0x0516CB30  token: 0x6000013
        public static System.Single GetBatteryLevel() { }
        // RVA: 0x03CF0140  token: 0x6000014
        public static System.Boolean IsLapTop() { }
        // RVA: 0x02C9A090  token: 0x6000015
        public static System.Boolean IsCharge() { }
        // RVA: 0x02C9A0C0  token: 0x6000016
        public static System.Int32 GetThermalState() { }
        // RVA: 0x03D47680  token: 0x6000017
        public static System.Boolean IsInSsd() { }
        // RVA: 0x03D476B0  token: 0x6000018
        public static System.Boolean HasSsd() { }
        // RVA: 0x02C9A560  token: 0x6000019
        public static System.Double GetFrequencyCalculateTime() { }
        // RVA: 0x0516D010  token: 0x600001A
        private static System.Int64 RunCpuFrequencyCalculate(System.Int32 times) { }
        // RVA: 0x03B5B510  token: 0x600001B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public static class NativeWindowsDiskChecker
    {
        // Fields
        private static System.UInt32 STORAGEDEVICESEEKPENALTYPROPERTY;  // const
        private static System.UInt32 PROPERTYSTANDARDQUERY;  // const
        private static System.Int32 MAX_PATH;  // const
        private static System.UInt32 FILE_SHARE_READ;  // const
        private static System.UInt32 FILE_SHARE_WRITE;  // const
        private static System.UInt32 FILE_SHARE_DELETE;  // const
        private static System.UInt32 OPEN_EXISTING;  // const
        private static System.UInt32 FILE_FLAG_BACKUP_SEMANTICS;  // const
        private static System.UInt32 IOCTL_STORAGE_QUERY_PROPERTY;  // const
        private static System.Object initOnceIsRunningInSSD;  // static @ 0x0
        private static System.Object initOnceStandaloneWinHaveSSd;  // static @ 0x8

        // Methods
        // RVA: 0x02C999B0  token: 0x600001C
        private static System.Boolean GetVolumePathName(System.String lpszFileName, System.IntPtr lpszVolumePathName, System.UInt32 cchBufferLength) { }
        // RVA: 0x02C99A30  token: 0x600001D
        private static System.Boolean GetVolumeNameForVolumeMountPoint(System.String lpszVolumeMountPoint, System.IntPtr lpszVolumeName, System.UInt32 cchBufferLength) { }
        // RVA: 0x02C99FF0  token: 0x600001E
        private static System.IntPtr CreateFile(System.String lpFileName, System.UInt32 dwDesiredAccess, System.UInt32 dwShareMode, System.IntPtr lpSecurityAttributes, System.UInt32 dwCreationDisposition, System.UInt32 dwFlagsAndAttributes, System.IntPtr hTemplateFile) { }
        // RVA: 0x02C99850  token: 0x600001F
        private static System.Boolean CloseHandle(System.IntPtr hObject) { }
        // RVA: 0x022C6A80  token: 0x6000020
        public static System.Int32 GetLogicalDriveStrings(System.UInt32 nBufferLength, System.Char[] lpBuffer) { }
        // RVA: 0x02C99900  token: 0x6000021
        private static System.Boolean DeviceIoControl(System.IntPtr hDevice, System.UInt32 dwIoControlCode, Beyond.NativeSDK.NativeWindowsDiskChecker.STORAGE_PROPERTY_QUERY& lpInBuffer, System.UInt32 nInBufferSize, Beyond.NativeSDK.NativeWindowsDiskChecker.DEVICE_SEEK_PENALTY_DESCRIPTOR& lpOutBuffer, System.UInt32 nOutBufferSize, System.UInt32& lpBytesReturned, System.IntPtr lpOverlapped) { }
        // RVA: 0x02C99C70  token: 0x6000022
        private static System.IntPtr GetVolumeHandleForFile(System.String filePath) { }
        // RVA: 0x02C99AB0  token: 0x6000023
        public static System.Boolean IsFileOnSsd(System.String filePath) { }
        // RVA: 0x0315AA70  token: 0x6000024
        public static System.Boolean IsRunningInSSD() { }
        // RVA: 0x022C5860  token: 0x6000025
        public static System.Boolean StandaloneWinHaveSSd() { }
        // RVA: 0x0516D394  token: 0x6000026
        public static System.Void Test() { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public static class NativePower
    {
        // Methods
        // RVA: 0x022C6B30  token: 0x600002A
        private static System.Boolean GetSystemPowerStatus(Beyond.NativeSDK.NativePower.SYSTEM_POWER_STATUS& sps) { }
        // RVA: 0x03CF0170  token: 0x600002B
        public static System.Boolean laptop() { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public static class VideoMemoryStatus
    {
        // Fields
        private static System.Int32 PDH_FMT_LARGE;  // static @ 0x0
        private static System.Int64 PDH_MORE_DATA;  // static @ 0x8
        private static System.String Command;  // const

        // Methods
        // RVA: 0x0516D3D4  token: 0x600002C
        private static System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.VideoMemoryStatus.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size) { }
        // RVA: 0x036A0C10  token: 0x600002D
        private static System.Int64 PdhOpenQuery(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery) { }
        // RVA: 0x036A0C80  token: 0x600002E
        private static System.Int64 PdhAddCounter(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter) { }
        // RVA: 0x036A0D00  token: 0x600002F
        private static System.Int64 PdhCollectQueryData(System.IntPtr hQuery) { }
        // RVA: 0x036A0D60  token: 0x6000030
        private static System.Int64 PdhGetFormattedCounterArray(System.IntPtr hQuery, System.Int32 dwFormat, System.UInt32& dwBufferSize, System.UInt32& dwItemCount, System.IntPtr itemBuffer) { }
        // RVA: 0x036A0DE0  token: 0x6000031
        private static System.Int32 PdhCloseQuery(System.IntPtr hQuery) { }
        // RVA: 0x02C9A310  token: 0x6000032
        public static System.ValueTuple<System.Int64,System.Int64> GetDedicatedMemoryStatus() { }
        // RVA: 0x02C9A280  token: 0x6000033
        public static System.ValueTuple<System.Int64,System.Int64> GetSharedMemoryStatus() { }
        // RVA: 0x02C9A1F0  token: 0x6000034
        public static System.ValueTuple<System.Int64,System.Int64> GetCommittedMemoryStatus() { }
        // RVA: 0x025FB2E0  token: 0x6000035
        private static System.ValueTuple<System.Int64,System.Int64> GetMemoryStatus(System.String type) { }
        // RVA: 0x03D49110  token: 0x6000036
        private static System.Void .cctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200000F  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x051624BC  token: 0x6000037
        public System.Void __Gen_Wrap_0() { }
        // RVA: 0x0514F380  token: 0x6000038
        public System.Boolean __Gen_Wrap_1() { }
        // RVA: 0x0516C778  token: 0x6000039
        public System.Int64 __Gen_Wrap_2() { }
        // RVA: 0x050EF068  token: 0x600003A
        public System.Int32 __Gen_Wrap_3() { }
        // RVA: 0x0516C824  token: 0x600003B
        public System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_4(System.Object P0) { }
        // RVA: 0x0516C930  token: 0x600003C
        public System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_5() { }
        // RVA: 0x050F18D0  token: 0x600003D
        public System.Single __Gen_Wrap_6() { }
        // RVA: 0x0516CA20  token: 0x600003E
        public System.IntPtr __Gen_Wrap_7(System.Object P0) { }
        // RVA: 0x0514EF5C  token: 0x600003F
        public System.Boolean __Gen_Wrap_8(System.Object P0) { }
        // RVA: 0x0516C6E0  token: 0x6000040
        public System.Double __Gen_Wrap_10() { }
        // RVA: 0x03D05FE0  token: 0x6000041
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public class WrappersManagerImpl
    {
        // Methods
        // RVA: 0x0516D470  token: 0x6000042
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x02C9A710  token: 0x6000043
        public static System.Boolean IsPatched(System.Int32 id) { }

    }

}

