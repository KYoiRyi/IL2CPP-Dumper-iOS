// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIModule.dll
// Classes:  12
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct InstanceRange
    {
        // Fields
        public System.UInt16 start;  // 0x10
        public System.UInt16 end;  // 0x12

    }

    // TypeToken: 0x200000A  // size: 0x80
    public sealed class WillRenderCanvases : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02473720  token: 0x6000095
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000096
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct SampleType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UISystemProfilerApi.SampleType Layout;  // const
        public static UnityEngine.UISystemProfilerApi.SampleType Render;  // const

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public interface ICanvasRaycastFilter
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000001
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }

    }

    // TypeToken: 0x2000003  // size: 0x18
    public sealed class CanvasGroup : UnityEngine.Behaviour, UnityEngine.ICanvasRaycastFilter
    {
        // Properties
        UnityEngine.Color color { get; /* RVA: 0x0251B040 */ set; /* RVA: 0x04270390 */ }
        System.Single alpha { get; /* RVA: 0x028BE250 */ set; /* RVA: 0x02A1F570 */ }
        System.Boolean interactable { get; /* RVA: 0x0251E290 */ set; /* RVA: 0x02BDC690 */ }
        System.Boolean blocksRaycasts { get; /* RVA: 0x02515D30 */ set; /* RVA: 0x02BDC800 */ }
        System.Boolean ignoreParentGroups { get; /* RVA: 0x0251E2D0 */ set; /* RVA: 0x09F63DE8 */ }

        // Methods
        // RVA: 0x04270384  token: 0x600000C
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x0426FE60  token: 0x600000D
        public System.Void .ctor() { }
        // RVA: 0x0251B0A0  token: 0x600000E
        private System.Void get_color_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x02E553D0  token: 0x600000F
        private System.Void set_color_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x2000004  // size: 0x20
    public sealed class CanvasRenderer : UnityEngine.Component
    {
        // Fields
        private System.Boolean <isMask>k__BackingField;  // 0x18

        // Properties
        System.Boolean hasPopInstruction { set; /* RVA: 0x02515F80 */ }
        System.Int32 materialCount { get; /* RVA: 0x02CD90B0 */ set; /* RVA: 0x025C7800 */ }
        System.Int32 popMaterialCount { set; /* RVA: 0x025161E0 */ }
        System.Int32 absoluteDepth { get; /* RVA: 0x02341DB0 */ }
        System.Boolean hasMoved { get; /* RVA: 0x032F1840 */ }
        System.Boolean cullTransparentMesh { get; /* RVA: 0x03325530 */ set; /* RVA: 0x03C79B80 */ }
        System.Boolean cull { get; /* RVA: 0x0233FDD0 */ set; /* RVA: 0x02C6F4A0 */ }
        UnityEngine.Vector2 clippingSoftness { set; /* RVA: 0x0426F8CC */ }
        UnityEngine.Vector4 clippingHGSoftness { set; /* RVA: 0x0426F8E8 */ }

        // Methods
        // RVA: 0x034DC2C0  token: 0x600001A
        public System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x024A3D40  token: 0x600001B
        public UnityEngine.Color GetColor() { }
        // RVA: 0x04274528  token: 0x600001C
        public System.Void EnableRectClipping(UnityEngine.Rect rect) { }
        // RVA: 0x02EC4360  token: 0x600001F
        public System.Void DisableRectClipping() { }
        // RVA: 0x025C7850  token: 0x6000020
        public System.Void SetMaterial(UnityEngine.Material material, System.Int32 index) { }
        // RVA: 0x09F63F94  token: 0x6000021
        public UnityEngine.Material GetMaterial(System.Int32 index) { }
        // RVA: 0x02516180  token: 0x6000022
        public System.Void SetPopMaterial(UnityEngine.Material material, System.Int32 index) { }
        // RVA: 0x025C77B0  token: 0x6000023
        public System.Void SetTexture(UnityEngine.Texture texture) { }
        // RVA: 0x025C3980  token: 0x6000024
        public System.Void SetAlphaTexture(UnityEngine.Texture texture) { }
        // RVA: 0x0233E5E0  token: 0x6000025
        public System.Void SetMesh(UnityEngine.Mesh mesh) { }
        // RVA: 0x0239B1E0  token: 0x6000026
        public System.Void Clear() { }
        // RVA: 0x09F63FD4  token: 0x6000027
        public System.Void SetAlpha(System.Single alpha) { }
        // RVA: 0x02803320  token: 0x6000028
        public System.Single GetInheritedAlpha() { }
        // RVA: 0x02CD9000  token: 0x6000029
        public System.Void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture) { }
        // RVA: 0x09F63F88  token: 0x600002A
        public UnityEngine.Material GetMaterial() { }
        // RVA: 0x09F640D4  token: 0x600002B
        public static System.Void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }
        // RVA: 0x09F63EF0  token: 0x600002C
        public static System.Void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }
        // RVA: 0x09F63E2C  token: 0x600002D
        public static System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }
        // RVA: 0x09F6402C  token: 0x600002E
        private static System.Void SplitIndicesStreamsInternal(System.Object verts, System.Object indices) { }
        // RVA: 0x09F64070  token: 0x600002F
        private static System.Void SplitUIVertexStreamsInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents) { }
        // RVA: 0x09F63E8C  token: 0x6000030
        private static System.Void CreateUIVertexStreamInternal(System.Object verts, System.Object positions, System.Object colors, System.Object uv0S, System.Object uv1S, System.Object uv2S, System.Object uv3S, System.Object normals, System.Object tangents, System.Object indices) { }
        // RVA: 0x03CDD830  token: 0x6000031
        private System.Void UpdateInstanceRange(System.UInt32 rangeCount, System.Void* ranges) { }
        // RVA: 0x03CDD7D0  token: 0x6000032
        public System.Void UpdateInstanceRange(System.UInt32 rangeCount, Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> rangers) { }
        // RVA: 0x09F63E3C  token: 0x6000033
        private System.Void* BeginInstanceBufferWrite(System.UInt32 count, System.UInt32 stride) { }
        // RVA: 0x03B446F0  token: 0x6000034
        private System.Void* BeginPrefabBufferWrite(System.UInt32 count, System.UInt32 stride) { }
        // RVA: 0x09F63F54  token: 0x6000035
        public System.Void EndInstanceBufferWrite() { }
        // RVA: 0x03CF4F50  token: 0x6000036
        public System.Void EndPrefabBufferWrite() { }
        // RVA: -1  // generic def  token: 0x6000037
        public Unity.Collections.NativeArray<T> BeginInstanceDataWrite(System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000038
        public Unity.Collections.NativeArray<T> BeginPrefabBufferWrite(System.Int32 count) { }
        // RVA: 0x03613C90  token: 0x6000039
        public System.Void EnableInstance() { }
        // RVA: 0x034DC2E0  token: 0x600003A
        private System.Void SetColor_Injected(UnityEngine.Color& color) { }
        // RVA: 0x024A3DA0  token: 0x600003B
        private System.Void GetColor_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x02EC43A0  token: 0x600003C
        private System.Void EnableRectClipping_Injected(UnityEngine.Rect& rect) { }
        // RVA: 0x02D02670  token: 0x600003D
        private System.Void set_clippingSoftness_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x02D026C0  token: 0x600003E
        private System.Void set_clippingHGSoftness_Injected(UnityEngine.Vector4& value) { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public sealed class RectTransformUtility
    {
        // Fields
        private static readonly UnityEngine.Vector3[] s_Corners;  // static @ 0x0

        // Methods
        // RVA: 0x09F65328  token: 0x600003F
        public static UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas) { }
        // RVA: 0x09F653EC  token: 0x6000040
        public static UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas) { }
        // RVA: 0x0233FC60  token: 0x6000041
        private static System.Boolean PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset) { }
        // RVA: 0x0350B670  token: 0x6000042
        private System.Void .ctor() { }
        // RVA: 0x09F65458  token: 0x6000043
        public static System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint) { }
        // RVA: 0x02515FE0  token: 0x6000044
        public static System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam) { }
        // RVA: 0x0233FB70  token: 0x6000045
        public static System.Boolean RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset) { }
        // RVA: 0x028AF870  token: 0x6000046
        public static System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint) { }
        // RVA: 0x028AF750  token: 0x6000047
        public static System.Boolean ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector2& localPoint) { }
        // RVA: 0x028AFD30  token: 0x6000048
        public static UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos) { }
        // RVA: 0x02CD9D50  token: 0x6000049
        public static UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint) { }
        // RVA: 0x09F64A74  token: 0x600004A
        public static UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child) { }
        // RVA: 0x09F64DF4  token: 0x600004B
        public static UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans) { }
        // RVA: 0x09F65084  token: 0x600004C
        public static System.Void FlipLayoutOnAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Boolean keepPositioning, System.Boolean recursive) { }
        // RVA: 0x09F64E6C  token: 0x600004D
        public static System.Void FlipLayoutAxes(UnityEngine.RectTransform rect, System.Boolean keepPositioning, System.Boolean recursive) { }
        // RVA: 0x03D89B20  token: 0x600004E
        private static UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input) { }
        // RVA: 0x03D050B0  token: 0x600004F
        private static System.Void .cctor() { }
        // RVA: 0x09F652C4  token: 0x6000050
        private static System.Void PixelAdjustPoint_Injected(UnityEngine.Vector2& point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, UnityEngine.Vector2& ret) { }
        // RVA: 0x09F65398  token: 0x6000051
        private static System.Void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, UnityEngine.Rect& ret) { }
        // RVA: 0x0233FD00  token: 0x6000052
        private static System.Boolean PointInRectangle_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4& offset) { }

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct RenderMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.RenderMode ScreenSpaceOverlay;  // const
        public static UnityEngine.RenderMode ScreenSpaceCamera;  // const
        public static UnityEngine.RenderMode WorldSpace;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct AdditionalCanvasShaderChannels
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AdditionalCanvasShaderChannels None;  // const
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord1;  // const
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord2;  // const
        public static UnityEngine.AdditionalCanvasShaderChannels TexCoord3;  // const
        public static UnityEngine.AdditionalCanvasShaderChannels Normal;  // const
        public static UnityEngine.AdditionalCanvasShaderChannels Tangent;  // const

    }

    // TypeToken: 0x2000009  // size: 0x18
    public sealed class Canvas : UnityEngine.Behaviour
    {
        // Fields
        private static UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases;  // static @ 0x0
        private static UnityEngine.Canvas.WillRenderCanvases willRenderCanvases;  // static @ 0x8
        private static System.Action<System.Int32> <externBeginRenderOverlays>k__BackingField;  // static @ 0x10
        private static System.Action<System.Int32,System.Int32> <externRenderOverlaysBefore>k__BackingField;  // static @ 0x18
        private static System.Action<System.Int32> <externEndRenderOverlays>k__BackingField;  // static @ 0x20

        // Properties
        UnityEngine.RenderMode renderMode { get; /* RVA: 0x02373A00 */ set; /* RVA: 0x03493060 */ }
        System.Boolean isRootCanvas { get; /* RVA: 0x023739C0 */ }
        UnityEngine.Rect pixelRect { get; /* RVA: 0x09F64528 */ }
        System.Single scaleFactor { get; /* RVA: 0x0233E210 */ set; /* RVA: 0x03681350 */ }
        System.Single referencePixelsPerUnit { get; /* RVA: 0x025A2C60 */ set; /* RVA: 0x09F648E8 */ }
        System.Boolean overridePixelPerfect { get; /* RVA: 0x09F644B0 */ set; /* RVA: 0x09F64860 */ }
        System.Boolean vertexColorAlwaysGammaSpace { get; /* RVA: 0x09F64624 */ set; /* RVA: 0x09F64A30 */ }
        System.Boolean pixelPerfect { get; /* RVA: 0x0233E1D0 */ set; /* RVA: 0x09F648A4 */ }
        System.Single planeDistance { get; /* RVA: 0x09F64554 */ set; /* RVA: 0x0348DC30 */ }
        System.Int32 renderOrder { get; /* RVA: 0x09F64588 */ }
        System.Boolean overrideSorting { get; /* RVA: 0x025179F0 */ set; /* RVA: 0x02A734A0 */ }
        System.Int32 sortingOrder { get; /* RVA: 0x02A73200 */ set; /* RVA: 0x02A73610 */ }
        System.Int32 targetDisplay { get; /* RVA: 0x02373B60 */ set; /* RVA: 0x09F649F0 */ }
        System.Int32 sortingLayerID { get; /* RVA: 0x0311BC80 */ set; /* RVA: 0x09F6496C */ }
        System.Int32 cachedSortingLayerValue { get; /* RVA: 0x09F64338 */ }
        UnityEngine.AdditionalCanvasShaderChannels additionalShaderChannels { get; /* RVA: 0x033254F0 */ set; /* RVA: 0x09F64658 */ }
        System.String sortingLayerName { get; /* RVA: 0x09F645F0 */ set; /* RVA: 0x09F649AC */ }
        UnityEngine.Canvas rootCanvas { get; /* RVA: 0x02343990 */ }
        UnityEngine.Vector2 renderingDisplaySize { get; /* RVA: 0x02373B10 */ }
        System.Boolean doCPUFrameInterpolation { get; /* RVA: 0x09F6436C */ set; /* RVA: 0x09F64698 */ }
        System.Boolean joinGPUFrameInterpolation { get; /* RVA: 0x09F64448 */ set; /* RVA: 0x09F647D8 */ }
        System.Action<System.Int32> externBeginRenderOverlays { get; /* RVA: 0x09F643A0 */ set; /* RVA: 0x09F646DC */ }
        System.Action<System.Int32,System.Int32> externRenderOverlaysBefore { get; /* RVA: 0x09F64410 */ set; /* RVA: 0x09F64784 */ }
        System.Action<System.Int32> externEndRenderOverlays { get; /* RVA: 0x09F643D8 */ set; /* RVA: 0x09F64730 */ }
        UnityEngine.Camera worldCamera { get; /* RVA: 0x02398D30 */ set; /* RVA: 0x02B7EBB0 */ }
        System.Single normalizedSortingGridSize { get; /* RVA: 0x09F6447C */ set; /* RVA: 0x09F6481C */ }
        System.Int32 sortingGridNormalizedSize { get; /* RVA: 0x09F645BC */ set; /* RVA: 0x09F6492C */ }

        // Events
        event UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases;
        event UnityEngine.Canvas.WillRenderCanvases willRenderCanvases;

        // Methods
        // RVA: 0x09F642C0  token: 0x6000081
        private static System.Void SetExternalCanvasEnabled(System.Boolean enabled) { }
        // RVA: 0x09F6420C  token: 0x6000088
        public static UnityEngine.Material GetDefaultCanvasTextMaterial() { }
        // RVA: 0x09F641E0  token: 0x6000089
        public static UnityEngine.Material GetDefaultCanvasMaterial() { }
        // RVA: 0x09F64238  token: 0x600008A
        public static UnityEngine.Material GetETC1SupportedCanvasMaterial() { }
        // RVA: 0x09F642F4  token: 0x600008B
        private System.Void UpdateCanvasRectTransform(System.Boolean alignWithCamera) { }
        // RVA: 0x02E3BEC0  token: 0x600008C
        public static System.Void ForceUpdateCanvases() { }
        // RVA: 0x02A585C0  token: 0x600008D
        private static System.Void SendPreWillRenderCanvases() { }
        // RVA: 0x02A58610  token: 0x600008E
        private static System.Void SendWillRenderCanvases() { }
        // RVA: 0x09F64140  token: 0x600008F
        private static System.Void BeginRenderExtraOverlays(System.Int32 displayIndex) { }
        // RVA: 0x09F64264  token: 0x6000090
        private static System.Void RenderExtraOverlaysBefore(System.Int32 displayIndex, System.Int32 sortingOrder) { }
        // RVA: 0x09F64190  token: 0x6000091
        private static System.Void EndRenderExtraOverlays(System.Int32 displayIndex) { }
        // RVA: 0x0426FE60  token: 0x6000092
        public System.Void .ctor() { }
        // RVA: 0x09F644E4  token: 0x6000093
        private System.Void get_pixelRect_Injected(UnityEngine.Rect& ret) { }
        // RVA: 0x02373A40  token: 0x6000094
        private System.Void get_renderingDisplaySize_Injected(UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public static class UISystemProfilerApi
    {
        // Methods
        // RVA: 0x0239C900  token: 0x6000097
        public static System.Void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type) { }
        // RVA: 0x0239C940  token: 0x6000098
        public static System.Void EndSample(UnityEngine.UISystemProfilerApi.SampleType type) { }
        // RVA: 0x02C6D1A0  token: 0x6000099
        public static System.Void AddMarker(System.String name, UnityEngine.Object obj) { }

    }

}

