// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.DownloadSDK.dll
// Classes:  4
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public interface IHGDownloadSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000001
        public virtual System.Int32 init(System.String config) { }
        // RVA: -1  // abstract  token: 0x6000002
        public virtual System.Int64 download(System.String versionId, System.String downloadFiles, System.String decompressPath, System.Boolean useMobileData, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath) { }
        // RVA: -1  // abstract  token: 0x6000003
        public virtual System.Int64 updateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType) { }
        // RVA: -1  // abstract  token: 0x6000004
        public virtual System.Int32 clearUselessFiles(System.String rootPath, System.String allFiles) { }
        // RVA: -1  // abstract  token: 0x6000005
        public virtual System.Int32 enableMobileData(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000006
        public virtual System.Int32 resume(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000007
        public virtual System.Int32 cancel(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000008
        public virtual System.Int32 clearAllTasks() { }
        // RVA: -1  // abstract  token: 0x6000009
        public virtual System.Int32 finish(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000A
        public virtual System.Int32 getSDKState() { }
        // RVA: -1  // abstract  token: 0x600000B
        public virtual System.Int32 getTaskState(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000C
        public virtual System.String getTaskInfo(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000D
        public virtual System.Int64 getDownloadSpeed(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000E
        public virtual System.Int64 getDownloadedSize(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000F
        public virtual System.Int64 getTotalDownloadSize(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000010
        public virtual System.Int32 getDecompressedProgress(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000011
        public virtual System.Int32 setLanguageType(System.Int32 type) { }
        // RVA: -1  // abstract  token: 0x6000012
        public virtual System.Int32 setNotificationTitle(System.String title) { }
        // RVA: -1  // abstract  token: 0x6000013
        public virtual System.Int64 getEstimatedDownloadSize(System.String versionId, System.String downloadFiles) { }
        // RVA: -1  // abstract  token: 0x6000014
        public virtual System.Int64 getEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo) { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public static class HGDownloadSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGDownloadSDK s_dl;  // static @ 0x0

        // Properties
        Hypergryph.SDK.IHGDownloadSDK downloadSDK { get; /* RVA: 0x02954810 */ }

        // Methods
        // RVA: 0x029547A0  token: 0x6000016
        public static System.Int32 Init(System.String config) { }
        // RVA: 0x088696D8  token: 0x6000017
        public static System.Int64 Download(System.String versionId, System.String downloadFiles, System.Boolean useMobileData, System.String decompressPath, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath) { }
        // RVA: 0x08869E08  token: 0x6000018
        public static System.Int64 UpdateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType) { }
        // RVA: 0x08869650  token: 0x6000019
        public static System.Int32 ClearUselessFiles(System.String rootPath, System.String allFiles) { }
        // RVA: 0x08869758  token: 0x600001A
        public static System.Int32 EnableMobileData(System.Int64 taskId) { }
        // RVA: 0x08869CA4  token: 0x600001B
        public static System.Int32 Resume(System.Int64 taskId) { }
        // RVA: 0x08869564  token: 0x600001C
        public static System.Int32 Cancel(System.Int64 taskId) { }
        // RVA: 0x088695E0  token: 0x600001D
        public static System.Int32 ClearAllTasks() { }
        // RVA: 0x088697CC  token: 0x600001E
        public static System.Int32 Finish(System.Int64 taskId) { }
        // RVA: 0x08869AC8  token: 0x600001F
        public static System.Int32 GetSDKState() { }
        // RVA: 0x08869BAC  token: 0x6000020
        public static System.Int32 GetTaskState(System.Int64 taskId) { }
        // RVA: 0x08869B38  token: 0x6000021
        public static System.String GetTaskInfo(System.Int64 taskId) { }
        // RVA: 0x088698C4  token: 0x6000022
        public static System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        // RVA: 0x08869940  token: 0x6000023
        public static System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        // RVA: 0x08869C28  token: 0x6000024
        public static System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        // RVA: 0x08869848  token: 0x6000025
        public static System.Int32 GetDecompressedProgress(System.Int64 taskId) { }
        // RVA: 0x08869D20  token: 0x6000026
        public static System.Int32 SetLanguageType(System.Int32 type) { }
        // RVA: 0x08869D94  token: 0x6000027
        public static System.Int32 SetNotificationTitle(System.String title) { }
        // RVA: 0x088699BC  token: 0x6000028
        public static System.Int64 GetEstimatedDownloadSize(System.String versionId, System.String downloadFiles) { }
        // RVA: 0x08869A44  token: 0x6000029
        public static System.Int64 GetEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo) { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class HGDownloadSDKPluginWindows : Hypergryph.SDK.IHGDownloadSDK
    {
        // Methods
        // RVA: 0x022C7730  token: 0x600002A
        public static System.Int32 HGDLSDKInit(System.String config) { }
        // RVA: 0x08868BC0  token: 0x600002B
        public static System.Int64 HGDLSDKDownloadWithPatch(System.String version_id, System.String download_files, System.String decompress_path, System.Boolean need_decompress, System.Boolean use_patch, System.String root_path) { }
        // RVA: 0x08868B08  token: 0x600002C
        public static System.Int32 HGDLSDKClearAllTasks() { }
        // RVA: 0x08869090  token: 0x600002D
        public static System.Int32 HGDLSDKGetSDKState() { }
        // RVA: 0x08869100  token: 0x600002E
        public static System.Int32 HGDLSDKGetTaskState(System.Int64 task_id) { }
        // RVA: 0x088691B4  token: 0x600002F
        public static System.Int32 HGDLSDKResume(System.Int64 task_id) { }
        // RVA: 0x08868AD4  token: 0x6000030
        public static System.Int32 HGDLSDKCancel(System.Int64 task_id) { }
        // RVA: 0x08868CD8  token: 0x6000031
        public static System.Int32 HGDLSDKFinish(System.Int64 task_id) { }
        // RVA: 0x088690C4  token: 0x6000032
        public static System.IntPtr HGDLSDKGetTaskInfo(System.Int64 task_id) { }
        // RVA: 0x08868DFC  token: 0x6000033
        public static System.Int64 HGDLSDKGetDownloadSpeed(System.Int64 task_id) { }
        // RVA: 0x08868E38  token: 0x6000034
        public static System.Int64 HGDLSDKGetDownloadedSize(System.Int64 task_id) { }
        // RVA: 0x08869178  token: 0x6000035
        public static System.Int64 HGDLSDKGetTotalDownloadSize(System.Int64 task_id) { }
        // RVA: 0x08868D84  token: 0x6000036
        public static System.Int32 HGDLSDKGetDecompressedProgress(System.Int64 task_id) { }
        // RVA: 0x08868E74  token: 0x6000037
        public static System.Int64 HGDLSDKGetEstimatedDownloadSize(System.String version_id, System.String download_files) { }
        // RVA: 0x08868D0C  token: 0x6000038
        public static System.Void HGDLSDKFree(System.IntPtr pointer) { }
        // RVA: 0x08868B3C  token: 0x6000039
        public static System.Int32 HGDLSDKClearUselessFiles(System.String root_path, System.String all_files) { }
        // RVA: 0x08868F30  token: 0x600003A
        public static System.Int64 HGDLSDKGetEstimatedUpdateSizeV2(System.String version_id, System.String base_paths, System.String root_path, System.String file_url_prefix, System.String patch_url_prefixm, System.String total_files, System.String patch_info) { }
        // RVA: 0x088691E8  token: 0x600003B
        public static System.Int64 HGDLSDKUpdateV3(System.String version_id, System.String base_paths, System.String root_path, System.String file_url_prefix, System.String patch_url_prefix, System.String total_files, System.String patch_info, System.Int32 check_type) { }
        // RVA: 0x0350B670  token: 0x600003C
        public System.Void .ctor() { }
        // RVA: 0x04272098  token: 0x600003D
        public virtual System.Int32 init(System.String config) { }
        // RVA: 0x0886937C  token: 0x600003E
        public virtual System.Int64 download(System.String versionId, System.String downloadFiles, System.String decompressPath, System.Boolean useMobileData, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath) { }
        // RVA: 0x01002730  token: 0x600003F
        public virtual System.Int32 enableMobileData(System.Int64 taskId) { }
        // RVA: 0x088694F8  token: 0x6000040
        public virtual System.Int32 resume(System.Int64 taskId) { }
        // RVA: 0x08869354  token: 0x6000041
        public virtual System.Int32 cancel(System.Int64 taskId) { }
        // RVA: 0x08869360  token: 0x6000042
        public virtual System.Int32 clearAllTasks() { }
        // RVA: 0x088693C4  token: 0x6000043
        public virtual System.Int32 finish(System.Int64 taskId) { }
        // RVA: 0x08869458  token: 0x6000044
        public virtual System.Int32 getSDKState() { }
        // RVA: 0x088694E0  token: 0x6000045
        public virtual System.Int32 getTaskState(System.Int64 taskId) { }
        // RVA: 0x08869460  token: 0x6000046
        public virtual System.String getTaskInfo(System.Int64 taskId) { }
        // RVA: 0x088693DC  token: 0x6000047
        public virtual System.Int64 getDownloadSpeed(System.Int64 taskId) { }
        // RVA: 0x088693E8  token: 0x6000048
        public virtual System.Int64 getDownloadedSize(System.Int64 taskId) { }
        // RVA: 0x088694EC  token: 0x6000049
        public virtual System.Int64 getTotalDownloadSize(System.Int64 taskId) { }
        // RVA: 0x088693D0  token: 0x600004A
        public virtual System.Int32 getDecompressedProgress(System.Int64 taskId) { }
        // RVA: 0x01002730  token: 0x600004B
        public virtual System.Int32 setLanguageType(System.Int32 type) { }
        // RVA: 0x01002730  token: 0x600004C
        public virtual System.Int32 setNotificationTitle(System.String title) { }
        // RVA: 0x088693F4  token: 0x600004D
        public virtual System.Int64 getEstimatedDownloadSize(System.String versionId, System.String downloadFiles) { }
        // RVA: 0x08869368  token: 0x600004E
        public virtual System.Int32 clearUselessFiles(System.String rootPath, System.String allFiles) { }
        // RVA: 0x08869408  token: 0x600004F
        public virtual System.Int64 getEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo) { }
        // RVA: 0x08869504  token: 0x6000050
        public virtual System.Int64 updateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType) { }

    }

}

