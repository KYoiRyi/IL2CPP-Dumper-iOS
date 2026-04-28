// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VRModule.dll
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

    // TypeToken: 0x2000003  // size: 0x14
    public sealed struct StereoRenderingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.XRSettings.StereoRenderingMode MultiPass;  // const
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePass;  // const
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePassInstanced;  // const
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePassMultiview;  // const

    }

namespace UnityEngine.XR
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class XRSettings
    {
        // Properties
        System.Boolean enabled { get; /* RVA: 0x09F8BD98 */ }
        System.Boolean isDeviceActive { get; /* RVA: 0x09F8BEA8 */ }
        System.Single eyeTextureResolutionScale { get; /* RVA: 0x09F8BE50 */ set; /* RVA: 0x09F8BF90 */ }
        System.Int32 eyeTextureWidth { get; /* RVA: 0x09F8BE7C */ }
        System.Int32 eyeTextureHeight { get; /* RVA: 0x09F8BE24 */ }
        UnityEngine.RenderTextureDescriptor eyeTextureDesc { get; /* RVA: 0x09F8BDF8 */ }
        System.Single renderViewportScale { get; /* RVA: 0x09F8BF2C */ }
        System.Single renderViewportScaleInternal { get; /* RVA: 0x09F8BF00 */ }
        System.String loadedDeviceName { get; /* RVA: 0x09F8BED4 */ }
        System.String[] supportedDevices { get; /* RVA: 0x09F8BF64 */ }
        UnityEngine.XR.XRSettings.StereoRenderingMode stereoRenderingMode { get; /* RVA: 0x09F8BF38 */ }

        // Methods
        // RVA: 0x09F8BDC4  token: 0x600000D
        private static System.Void get_eyeTextureDesc_Injected(UnityEngine.RenderTextureDescriptor& ret) { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class XRDevice
    {
        // Fields
        private static System.Action<System.String> deviceLoaded;  // static @ 0x0

        // Methods
        // RVA: 0x09F8BD04  token: 0x600000E
        public static System.Void DisableAutoXRCameraTracking(UnityEngine.Camera camera, System.Boolean disabled) { }
        // RVA: 0x09F8BD48  token: 0x600000F
        private static System.Void InvokeDeviceLoaded(System.String loadedDeviceName) { }

    }

}

