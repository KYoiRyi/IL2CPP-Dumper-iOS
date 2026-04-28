// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VRModule.dll
// Classes:  4
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

CLASS: StereoRenderingMode
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeMultiPass  // const
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePass  // const
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePassInstanced  // const
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePassMultiview  // const
METHODS:
END_CLASS

CLASS: UnityEngine.XR.XRSettings
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
PROPERTIES:
  enabled  get=0x09F8BD98
  isDeviceActive  get=0x09F8BEA8
  eyeTextureResolutionScale  get=0x09F8BE50  set=0x09F8BF90
  eyeTextureWidth  get=0x09F8BE7C
  eyeTextureHeight  get=0x09F8BE24
  eyeTextureDesc  get=0x09F8BDF8
  renderViewportScale  get=0x09F8BF2C
  renderViewportScaleInternal  get=0x09F8BF00
  loadedDeviceName  get=0x09F8BED4
  supportedDevices  get=0x09F8BF64
  stereoRenderingMode  get=0x09F8BF38
METHODS:
  RVA=0x09F8BDC4  token=0x600000D  System.Void get_eyeTextureDesc_Injected(UnityEngine.RenderTextureDescriptor& ret)
END_CLASS

CLASS: UnityEngine.XR.XRDevice
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
  private   static  System.Action<System.String>    deviceLoaded  // static @ 0x0
METHODS:
  RVA=0x09F8BD04  token=0x600000E  System.Void DisableAutoXRCameraTracking(UnityEngine.Camera camera, System.Boolean disabled)
  RVA=0x09F8BD48  token=0x600000F  System.Void InvokeDeviceLoaded(System.String loadedDeviceName)
END_CLASS

