// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIModule.dll
// Classes:  12
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

CLASS: InstanceRange
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x14
FIELDS:
  public            System.UInt16                   start  // 0x10
  public            System.UInt16                   end  // 0x12
METHODS:
END_CLASS

CLASS: WillRenderCanvases
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x02473720  token=0x6000095  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x6000096  System.Void Invoke()
END_CLASS

CLASS: SampleType
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UISystemProfilerApi.SampleTypeLayout  // const
  public    static  UnityEngine.UISystemProfilerApi.SampleTypeRender  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ICanvasRaycastFilter
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000001  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
END_CLASS

CLASS: UnityEngine.CanvasGroup
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
IMPLEMENTS: UnityEngine.ICanvasRaycastFilter
FIELDS:
PROPERTIES:
  color  get=0x0251B040  set=0x04270390
  alpha  get=0x028BE250  set=0x02A1F570
  interactable  get=0x0251E290  set=0x02BDC690
  blocksRaycasts  get=0x02515D30  set=0x02BDC800
  ignoreParentGroups  get=0x0251E2D0  set=0x09F63DE8
METHODS:
  RVA=0x04270384  token=0x600000C  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x0426FE60  token=0x600000D  System.Void .ctor()
  RVA=0x0251B0A0  token=0x600000E  System.Void get_color_Injected(UnityEngine.Color& ret)
  RVA=0x02E553D0  token=0x600000F  System.Void set_color_Injected(UnityEngine.Color& value)
END_CLASS

CLASS: UnityEngine.CanvasRenderer
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x20
EXTENDS: UnityEngine.Component
FIELDS:
  private           System.Boolean                  <isMask>k__BackingField  // 0x18
PROPERTIES:
  hasPopInstruction  set=0x02515F80
  materialCount  get=0x02CD90B0  set=0x025C7800
  popMaterialCount  set=0x025161E0
  absoluteDepth  get=0x02341DB0
  hasMoved  get=0x032F1840
  cullTransparentMesh  get=0x03325530  set=0x03C79B80
  cull  get=0x0233FDD0  set=0x02C6F4A0
  clippingSoftness  set=0x0426F8CC
  clippingHGSoftness  set=0x0426F8E8
METHODS:
  RVA=0x034DC2C0  token=0x600001A  System.Void SetColor(UnityEngine.Color color)
  RVA=0x024A3D40  token=0x600001B  UnityEngine.Color GetColor()
  RVA=0x04274528  token=0x600001C  System.Void EnableRectClipping(UnityEngine.Rect rect)
  RVA=0x02EC4360  token=0x600001F  System.Void DisableRectClipping()
  RVA=0x025C7850  token=0x6000020  System.Void SetMaterial(UnityEngine.Material material, System.Int32 index)
  RVA=0x09F63F94  token=0x6000021  UnityEngine.Material GetMaterial(System.Int32 index)
  RVA=0x02516180  token=0x6000022  System.Void SetPopMaterial(UnityEngine.Material material, System.Int32 index)
  RVA=0x025C77B0  token=0x6000023  System.Void SetTexture(UnityEngine.Texture texture)
  RVA=0x025C3980  token=0x6000024  System.Void SetAlphaTexture(UnityEngine.Texture texture)
  RVA=0x0233E5E0  token=0x6000025  System.Void SetMesh(UnityEngine.Mesh mesh)
  RVA=0x0239B1E0  token=0x6000026  System.Void Clear()
  RVA=0x09F63FD4  token=0x6000027  System.Void SetAlpha(System.Single alpha)
  RVA=0x02803320  token=0x6000028  System.Single GetInheritedAlpha()
  RVA=0x02CD9000  token=0x6000029  System.Void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture)
  RVA=0x09F63F88  token=0x600002A  UnityEngine.Material GetMaterial()
  RVA=0x09F640D4  token=0x600002B  System.Void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices)
  RVA=0x09F63EF0  token=0x600002C  System.Void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices)
  RVA=0x09F63E2C  token=0x600002D  System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents)
  RVA=0x09F6402C  token=0x600002E  System.Void SplitIndicesStreamsInternal(System.Object verts, System.Object indices)
  RVA=0x09F64070  token=0x600002F  System.Void SplitUIVertexStreamsInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents)
  RVA=0x09F63E8C  token=0x6000030  System.Void CreateUIVertexStreamInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents, System.Object indices)
  RVA=0x03CDD830  token=0x6000031  System.Void UpdateInstanceRange(System.UInt32 rangeCount, System.Void* ranges)
  RVA=0x03CDD7D0  token=0x6000032  System.Void UpdateInstanceRange(System.UInt32 rangeCount, Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> rangers)
  RVA=0x09F63E3C  token=0x6000033  System.Void* BeginInstanceBufferWrite(System.UInt32 count, System.UInt32 stride)
  RVA=0x03B446F0  token=0x6000034  System.Void* BeginPrefabBufferWrite(System.UInt32 count, System.UInt32 stride)
  RVA=0x09F63F54  token=0x6000035  System.Void EndInstanceBufferWrite()
  RVA=0x03CF4F50  token=0x6000036  System.Void EndPrefabBufferWrite()
  RVA=-1  // generic def  token=0x6000037  Unity.Collections.NativeArray<T> BeginInstanceDataWrite(System.Int32 count)
  RVA=-1  // generic def  token=0x6000038  Unity.Collections.NativeArray<T> BeginPrefabBufferWrite(System.Int32 count)
  RVA=0x03613C90  token=0x6000039  System.Void EnableInstance()
  RVA=0x034DC2E0  token=0x600003A  System.Void SetColor_Injected(UnityEngine.Color& color)
  RVA=0x024A3DA0  token=0x600003B  System.Void GetColor_Injected(UnityEngine.Color& ret)
  RVA=0x02EC43A0  token=0x600003C  System.Void EnableRectClipping_Injected(UnityEngine.Rect& rect)
  RVA=0x02D02670  token=0x600003D  System.Void set_clippingSoftness_Injected(UnityEngine.Vector2& value)
  RVA=0x02D026C0  token=0x600003E  System.Void set_clippingHGSoftness_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.RectTransformUtility
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
  private   static readonly UnityEngine.Vector3[]           s_Corners  // static @ 0x0
METHODS:
  RVA=0x09F65328  token=0x600003F  UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas)
  RVA=0x09F653EC  token=0x6000040  UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas)
  RVA=0x0233FC60  token=0x6000041  System.Boolean PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
  RVA=0x0350B670  token=0x6000042  System.Void .ctor()
  RVA=0x09F65458  token=0x6000043  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint)
  RVA=0x02515FE0  token=0x6000044  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam)
  RVA=0x0233FB70  token=0x6000045  System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
  RVA=0x028AF870  token=0x6000046  System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint)
  RVA=0x028AF750  token=0x6000047  System.Boolean ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector2& localPoint)
  RVA=0x028AFD30  token=0x6000048  UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos)
  RVA=0x02CD9D50  token=0x6000049  UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint)
  RVA=0x09F64A74  token=0x600004A  UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child)
  RVA=0x09F64DF4  token=0x600004B  UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans)
  RVA=0x09F65084  token=0x600004C  System.Void FlipLayoutOnAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Boolean keepPositioning, System.Boolean recursive)
  RVA=0x09F64E6C  token=0x600004D  System.Void FlipLayoutAxes(UnityEngine.RectTransform rect, System.Boolean keepPositioning, System.Boolean recursive)
  RVA=0x03D89B20  token=0x600004E  UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input)
  RVA=0x03D050B0  token=0x600004F  System.Void .cctor()
  RVA=0x09F652C4  token=0x6000050  System.Void PixelAdjustPoint_Injected(UnityEngine.Vector2& point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, UnityEngine.Vector2& ret)
  RVA=0x09F65398  token=0x6000051  System.Void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, UnityEngine.Rect& ret)
  RVA=0x0233FD00  token=0x6000052  System.Boolean PointInRectangle_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4& offset)
END_CLASS

CLASS: UnityEngine.RenderMode
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderMode          ScreenSpaceOverlay  // const
  public    static  UnityEngine.RenderMode          ScreenSpaceCamera  // const
  public    static  UnityEngine.RenderMode          WorldSpace  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AdditionalCanvasShaderChannels
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AdditionalCanvasShaderChannelsNone  // const
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord1  // const
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord2  // const
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTexCoord3  // const
  public    static  UnityEngine.AdditionalCanvasShaderChannelsNormal  // const
  public    static  UnityEngine.AdditionalCanvasShaderChannelsTangent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Canvas
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
  private   static  UnityEngine.Canvas.WillRenderCanvasespreWillRenderCanvases  // static @ 0x0
  private   static  UnityEngine.Canvas.WillRenderCanvaseswillRenderCanvases  // static @ 0x8
  private   static  System.Action<System.Int32>     <externBeginRenderOverlays>k__BackingField  // static @ 0x10
  private   static  System.Action<System.Int32,System.Int32><externRenderOverlaysBefore>k__BackingField  // static @ 0x18
  private   static  System.Action<System.Int32>     <externEndRenderOverlays>k__BackingField  // static @ 0x20
PROPERTIES:
  renderMode  get=0x02373A00  set=0x03493060
  isRootCanvas  get=0x023739C0
  pixelRect  get=0x09F64528
  scaleFactor  get=0x0233E210  set=0x03681350
  referencePixelsPerUnit  get=0x025A2C60  set=0x09F648E8
  overridePixelPerfect  get=0x09F644B0  set=0x09F64860
  vertexColorAlwaysGammaSpace  get=0x09F64624  set=0x09F64A30
  pixelPerfect  get=0x0233E1D0  set=0x09F648A4
  planeDistance  get=0x09F64554  set=0x0348DC30
  renderOrder  get=0x09F64588
  overrideSorting  get=0x025179F0  set=0x02A734A0
  sortingOrder  get=0x02A73200  set=0x02A73610
  targetDisplay  get=0x02373B60  set=0x09F649F0
  sortingLayerID  get=0x0311BC80  set=0x09F6496C
  cachedSortingLayerValue  get=0x09F64338
  additionalShaderChannels  get=0x033254F0  set=0x09F64658
  sortingLayerName  get=0x09F645F0  set=0x09F649AC
  rootCanvas  get=0x02343990
  renderingDisplaySize  get=0x02373B10
  doCPUFrameInterpolation  get=0x09F6436C  set=0x09F64698
  joinGPUFrameInterpolation  get=0x09F64448  set=0x09F647D8
  externBeginRenderOverlays  get=0x09F643A0  set=0x09F646DC
  externRenderOverlaysBefore  get=0x09F64410  set=0x09F64784
  externEndRenderOverlays  get=0x09F643D8  set=0x09F64730
  worldCamera  get=0x02398D30  set=0x02B7EBB0
  normalizedSortingGridSize  get=0x09F6447C  set=0x09F6481C
  sortingGridNormalizedSize  get=0x09F645BC  set=0x09F6492C
EVENTS:
  preWillRenderCanvases  add=add_preWillRenderCanvases  remove=remove_preWillRenderCanvases
  willRenderCanvases  add=add_willRenderCanvases  remove=remove_willRenderCanvases
METHODS:
  RVA=0x09F642C0  token=0x6000081  System.Void SetExternalCanvasEnabled(System.Boolean enabled)
  RVA=0x09F6420C  token=0x6000088  UnityEngine.Material GetDefaultCanvasTextMaterial()
  RVA=0x09F641E0  token=0x6000089  UnityEngine.Material GetDefaultCanvasMaterial()
  RVA=0x09F64238  token=0x600008A  UnityEngine.Material GetETC1SupportedCanvasMaterial()
  RVA=0x09F642F4  token=0x600008B  System.Void UpdateCanvasRectTransform(System.Boolean alignWithCamera)
  RVA=0x02E3BEC0  token=0x600008C  System.Void ForceUpdateCanvases()
  RVA=0x02A585C0  token=0x600008D  System.Void SendPreWillRenderCanvases()
  RVA=0x02A58610  token=0x600008E  System.Void SendWillRenderCanvases()
  RVA=0x09F64140  token=0x600008F  System.Void BeginRenderExtraOverlays(System.Int32 displayIndex)
  RVA=0x09F64264  token=0x6000090  System.Void RenderExtraOverlaysBefore(System.Int32 displayIndex, System.Int32 sortingOrder)
  RVA=0x09F64190  token=0x6000091  System.Void EndRenderExtraOverlays(System.Int32 displayIndex)
  RVA=0x0426FE60  token=0x6000092  System.Void .ctor()
  RVA=0x09F644E4  token=0x6000093  System.Void get_pixelRect_Injected(UnityEngine.Rect& ret)
  RVA=0x02373A40  token=0x6000094  System.Void get_renderingDisplaySize_Injected(UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.UISystemProfilerApi
TYPE:  static class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0239C900  token=0x6000097  System.Void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type)
  RVA=0x0239C940  token=0x6000098  System.Void EndSample(UnityEngine.UISystemProfilerApi.SampleType type)
  RVA=0x02C6D1A0  token=0x6000099  System.Void AddMarker(System.String name, UnityEngine.Object obj)
END_CLASS

