// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.GameUpdate.dll
// Classes:  9
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x18
    public sealed class <>c__DisplayClass6_0
    {
        // Fields
        public System.String data;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000005
        public System.Void .ctor() { }
        // RVA: 0x0886E544  token: 0x6000006
        private System.Void <onLatestGame>b__0() { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public System.Action action;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000007
        public System.Void .ctor() { }
        // RVA: 0x05A93C08  token: 0x6000008
        private System.Void <runInMainTread>b__0(System.Object p) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Hypergryph.SDK.HGGameUpdateSDK.<>c <>9;  // static @ 0x0
        public static System.Action<System.String> <>9__6_0;  // static @ 0x8

        // Methods
        // RVA: 0x0886E594  token: 0x6000027
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000028
        public System.Void .ctor() { }
        // RVA: 0x0886E4A8  token: 0x6000029
        private System.Void <GetLatestGame>b__6_0(System.String result) { }

    }

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002  // size: 0x18
    public class HGGameUpdateCallback : UnityEngine.MonoBehaviour
    {
        // Fields
        private static Hypergryph.SDK.IHGGameUpdateSDKCallback m_callback;  // static @ 0x0
        private static System.String gameObjectName;  // const
        private static System.Threading.SynchronizationContext mainThreadContext;  // static @ 0x8
        public static Hypergryph.SDK.HGGameUpdateCallback s_instance;  // static @ 0x10

        // Methods
        // RVA: 0x0886D504  token: 0x6000001
        public System.Void .ctor() { }
        // RVA: 0x0886D348  token: 0x6000002
        public static System.Void Init(Hypergryph.SDK.IHGGameUpdateSDKCallback callback) { }
        // RVA: 0x0886D568  token: 0x6000003
        public System.Void onLatestGame(System.String data) { }
        // RVA: 0x0886D620  token: 0x6000004
        private System.Void runInMainTread(System.Action action) { }

    }

    // TypeToken: 0x2000005
    public interface IHGGameUpdateSDKCallback
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000009
        public virtual System.Void onLatestGame(System.String data) { }

    }

    // TypeToken: 0x2000006
    public interface IHGGameUpdateSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600000A
        public virtual System.Int32 Init(System.String config) { }
        // RVA: -1  // abstract  token: 0x600000B
        public virtual System.Void GetLatestGame(System.Action<System.String> onResult) { }
        // RVA: -1  // abstract  token: 0x600000C
        public virtual System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        // RVA: -1  // abstract  token: 0x600000D
        public virtual System.Int32 EnableMobileData(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000E
        public virtual System.Int32 GetTaskState(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x600000F
        public virtual System.Int32 Resume(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000010
        public virtual System.Int32 CancelAndClear(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000011
        public virtual System.Int32 Cancel(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000012
        public virtual System.Int32 Install(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000013
        public virtual System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000014
        public virtual System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000015
        public virtual System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        // RVA: -1  // abstract  token: 0x6000016
        public virtual System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        // RVA: -1  // abstract  token: 0x6000017
        public virtual System.Int32 SetNotificationTitle(System.String titleConfig) { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public static class HGGameUpdateSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGGameUpdateSDK s_gu;  // static @ 0x0
        private static Hypergryph.SDK.IHGGameUpdateSDKCallback m_callback;  // static @ 0x8
        private static System.Threading.SynchronizationContext mainThreadContext;  // static @ 0x10

        // Properties
        Hypergryph.SDK.IHGGameUpdateSDK gameUpdateSDK { get; /* RVA: 0x0886E414 */ }

        // Methods
        // RVA: 0x0886E100  token: 0x6000019
        public static System.Int32 Init(System.String config, Hypergryph.SDK.IHGGameUpdateSDKCallback callback) { }
        // RVA: 0x0886DEC0  token: 0x600001A
        public static System.Void GetLatestGame() { }
        // RVA: 0x0886E380  token: 0x600001B
        public static System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        // RVA: 0x0886DCC0  token: 0x600001C
        public static System.Int32 EnableMobileData(System.Int64 taskId) { }
        // RVA: 0x0886E000  token: 0x600001D
        public static System.Int32 GetTaskState(System.Int64 taskId) { }
        // RVA: 0x0886E280  token: 0x600001E
        public static System.Int32 Resume(System.Int64 taskId) { }
        // RVA: 0x0886DBC0  token: 0x600001F
        public static System.Int32 CancelAndClear(System.Int64 taskId) { }
        // RVA: 0x0886DC40  token: 0x6000020
        public static System.Int32 Cancel(System.Int64 taskId) { }
        // RVA: 0x0886E200  token: 0x6000021
        public static System.Int32 Install(System.Int64 taskId) { }
        // RVA: 0x0886DD40  token: 0x6000022
        public static System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        // RVA: 0x0886DDC0  token: 0x6000023
        public static System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        // RVA: 0x0886E080  token: 0x6000024
        public static System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        // RVA: 0x0886DE40  token: 0x6000025
        public static System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        // RVA: 0x0886E300  token: 0x6000026
        public static System.Int32 SetNotificationTitle(System.String titleConfig) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class HGGameUpdateSDKPluginDefault : Hypergryph.SDK.IHGGameUpdateSDK
    {
        // Methods
        // RVA: 0x0886DA28  token: 0x600002A
        public virtual System.Int32 Init(System.String config) { }
        // RVA: 0x0886D8F8  token: 0x600002B
        public virtual System.Void GetLatestGame(System.Action<System.String> onResult) { }
        // RVA: 0x0886DB68  token: 0x600002C
        public virtual System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        // RVA: 0x0886D7B8  token: 0x600002D
        public virtual System.Int32 EnableMobileData(System.Int64 taskId) { }
        // RVA: 0x0886D988  token: 0x600002E
        public virtual System.Int32 GetTaskState(System.Int64 taskId) { }
        // RVA: 0x0886DAC8  token: 0x600002F
        public virtual System.Int32 Resume(System.Int64 taskId) { }
        // RVA: 0x0886D718  token: 0x6000030
        public virtual System.Int32 CancelAndClear(System.Int64 taskId) { }
        // RVA: 0x0886D768  token: 0x6000031
        public virtual System.Int32 Cancel(System.Int64 taskId) { }
        // RVA: 0x0886DA78  token: 0x6000032
        public virtual System.Int32 Install(System.Int64 taskId) { }
        // RVA: 0x0886D808  token: 0x6000033
        public virtual System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        // RVA: 0x0886D858  token: 0x6000034
        public virtual System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        // RVA: 0x0886D9D8  token: 0x6000035
        public virtual System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        // RVA: 0x0886D8A8  token: 0x6000036
        public virtual System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        // RVA: 0x0886DB18  token: 0x6000037
        public virtual System.Int32 SetNotificationTitle(System.String titleConfig) { }
        // RVA: 0x0350B670  token: 0x6000038
        public System.Void .ctor() { }

    }

}

