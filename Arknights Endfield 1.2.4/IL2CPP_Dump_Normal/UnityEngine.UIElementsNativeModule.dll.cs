// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsNativeModule.dll
// Classes:  32
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200001F  // size: 0x14
    public sealed struct GPUBufferType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UIElements.UIR.Utility.GPUBufferType Vertex;  // const
        public static UnityEngine.UIElements.UIR.Utility.GPUBufferType Index;  // const

    }

    // TypeToken: 0x2000020
    public class GPUBuffer`1 : System.IDisposable
    {
        // Fields
        private System.IntPtr buffer;  // 0x0
        private System.Int32 elemCount;  // 0x0
        private System.Int32 elemStride;  // 0x0

        // Properties
        System.Int32 ElementStride { get; /* RVA: -1  // not resolved */ }
        System.IntPtr BufferPointer { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000F1
        public System.Void .ctor(System.Int32 elementCount, UnityEngine.UIElements.UIR.Utility.GPUBufferType type) { }
        // RVA: -1  // not resolved  token: 0x60000F2
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000F3
        public System.Void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, System.Int32 rangesMin, System.Int32 rangesMax) { }

    }

namespace UnityEngine.UIElements
{

    // TypeToken: 0x2000018  // size: 0x50
    public sealed struct TextNativeSettings
    {
        // Fields
        public System.String text;  // 0x10
        public UnityEngine.Font font;  // 0x18
        public System.Int32 size;  // 0x20
        public System.Single scaling;  // 0x24
        public UnityEngine.FontStyle style;  // 0x28
        public UnityEngine.Color color;  // 0x2c
        public UnityEngine.TextAnchor anchor;  // 0x3c
        public System.Boolean wordWrap;  // 0x40
        public System.Single wordWrapWidth;  // 0x44
        public System.Boolean richText;  // 0x48

    }

    // TypeToken: 0x2000019  // size: 0x28
    public sealed struct TextVertex
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Color32 color;  // 0x1c
        public UnityEngine.Vector2 uv0;  // 0x20

    }

    // TypeToken: 0x200001A  // size: 0x10
    public static class TextNative
    {
        // Methods
        // RVA: 0x09F6162C  token: 0x60000AD
        public static UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorIndex) { }
        // RVA: 0x09F613A4  token: 0x60000AE
        public static System.Single ComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings) { }
        // RVA: 0x09F612A4  token: 0x60000AF
        public static System.Single ComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings) { }
        // RVA: 0x09F6191C  token: 0x60000B0
        public static Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.TextNativeSettings settings) { }
        // RVA: 0x09F61748  token: 0x60000B1
        public static UnityEngine.Vector2 GetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect screenRect) { }
        // RVA: 0x09F557AC  token: 0x60000B2
        public static System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint) { }
        // RVA: 0x09F6151C  token: 0x60000B3
        private static System.Single DoComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings) { }
        // RVA: 0x09F614D8  token: 0x60000B4
        private static System.Single DoComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings) { }
        // RVA: 0x09F61590  token: 0x60000B5
        private static UnityEngine.Vector2 DoGetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, System.Int32 cursorPosition) { }
        // RVA: 0x09F61904  token: 0x60000B6
        private static System.Void GetVertices(UnityEngine.UIElements.TextNativeSettings settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount) { }
        // RVA: 0x09F61608  token: 0x60000B7
        private static UnityEngine.Vector2 DoGetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect) { }
        // RVA: 0x09F614E8  token: 0x60000B8
        private static System.Single DoComputeTextWidth_Injected(UnityEngine.UIElements.TextNativeSettings& settings) { }
        // RVA: 0x09F614A4  token: 0x60000B9
        private static System.Single DoComputeTextHeight_Injected(UnityEngine.UIElements.TextNativeSettings& settings) { }
        // RVA: 0x09F6152C  token: 0x60000BA
        private static System.Void DoGetCursorPosition_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, System.Int32 cursorPosition, UnityEngine.Vector2& ret) { }
        // RVA: 0x09F618A0  token: 0x60000BB
        private static System.Void GetVertices_Injected(UnityEngine.UIElements.TextNativeSettings& settings, System.IntPtr buffer, System.Int32 vertexSize, System.Int32& vertexCount) { }
        // RVA: 0x09F615B4  token: 0x60000BC
        private static System.Void DoGetOffset_Injected(UnityEngine.UIElements.TextNativeSettings& settings, UnityEngine.Rect& rect, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public static class UIElementsRuntimeUtilityNative
    {
        // Fields
        private static System.Action RepaintOverlayPanelsCallback;  // static @ 0x0
        private static System.Action UpdateRuntimePanelsCallback;  // static @ 0x8
        private static System.Action RepaintOffscreenPanelsCallback;  // static @ 0x10

        // Methods
        // RVA: 0x09F61AE4  token: 0x60000BD
        public static System.Void RepaintOverlayPanels() { }
        // RVA: 0x09F61B50  token: 0x60000BE
        public static System.Void UpdateRuntimePanels() { }
        // RVA: 0x09F61AA0  token: 0x60000BF
        public static System.Void RepaintOffscreenPanels() { }
        // RVA: 0x09F61A74  token: 0x60000C0
        public static System.Void RegisterPlayerloopCallback() { }
        // RVA: 0x09F61B24  token: 0x60000C1
        public static System.Void UnregisterPlayerloopCallback() { }
        // RVA: 0x09F61B94  token: 0x60000C2
        public static System.Void VisualElementCreation() { }

    }

}

namespace UnityEngine.UIElements.UIR
{

    // TypeToken: 0x200001C  // size: 0x20
    public sealed struct GfxUpdateBufferRange
    {
        // Fields
        public System.UInt32 offsetFromWriteStart;  // 0x10
        public System.UInt32 size;  // 0x14
        public System.UIntPtr source;  // 0x18

    }

    // TypeToken: 0x200001D  // size: 0x20
    public sealed struct DrawBufferRange
    {
        // Fields
        public System.Int32 firstIndex;  // 0x10
        public System.Int32 indexCount;  // 0x14
        public System.Int32 minIndexVal;  // 0x18
        public System.Int32 vertsReferenced;  // 0x1c

    }

    // TypeToken: 0x200001E  // size: 0x10
    public class Utility
    {
        // Fields
        private static System.Action<System.Boolean> GraphicsResourcesRecreate;  // static @ 0x0
        private static System.Action EngineUpdate;  // static @ 0x8
        private static System.Action FlushPendingResources;  // static @ 0x10
        private static System.Action<UnityEngine.Camera> RegisterIntermediateRenderers;  // static @ 0x18
        private static System.Action<System.IntPtr> RenderNodeAdd;  // static @ 0x20
        private static System.Action<System.IntPtr> RenderNodeExecute;  // static @ 0x28
        private static System.Action<System.IntPtr> RenderNodeCleanup;  // static @ 0x30
        private static Unity.Profiling.ProfilerMarker s_MarkerRaiseEngineUpdate;  // static @ 0x38

        // Events
        event System.Action<System.Boolean> GraphicsResourcesRecreate;
        event System.Action EngineUpdate;
        event System.Action FlushPendingResources;
        event System.Action<UnityEngine.Camera> RegisterIntermediateRenderers;
        event System.Action<System.IntPtr> RenderNodeExecute;

        // Methods
        // RVA: -1  // generic def  token: 0x60000C3
        public static System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, Unity.Collections.NativeSlice<T> vector4s) { }
        // RVA: 0x09F62068  token: 0x60000CE
        private static System.Void RaiseGraphicsResourcesRecreate(System.Boolean recreate) { }
        // RVA: 0x09F61FA8  token: 0x60000CF
        private static System.Void RaiseEngineUpdate() { }
        // RVA: 0x09F62018  token: 0x60000D0
        private static System.Void RaiseFlushPendingResources() { }
        // RVA: 0x09F620C0  token: 0x60000D1
        private static System.Void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera) { }
        // RVA: 0x09F6211C  token: 0x60000D2
        private static System.Void RaiseRenderNodeAdd(System.IntPtr userData) { }
        // RVA: 0x09F621D4  token: 0x60000D3
        private static System.Void RaiseRenderNodeExecute(System.IntPtr userData) { }
        // RVA: 0x09F62178  token: 0x60000D4
        private static System.Void RaiseRenderNodeCleanup(System.IntPtr userData) { }
        // RVA: 0x09F61BC0  token: 0x60000D5
        private static System.IntPtr AllocateBuffer(System.Int32 elementCount, System.Int32 elementStride, System.Boolean vertexBuffer) { }
        // RVA: 0x09F61D54  token: 0x60000D6
        private static System.Void FreeBuffer(System.IntPtr buffer) { }
        // RVA: 0x09F624EC  token: 0x60000D7
        private static System.Void UpdateBufferRanges(System.IntPtr buffer, System.IntPtr ranges, System.Int32 rangeCount, System.Int32 writeRangeStart, System.Int32 writeRangeEnd) { }
        // RVA: 0x09F62460  token: 0x60000D8
        private static System.Void SetVectorArray(UnityEngine.MaterialPropertyBlock props, System.Int32 name, System.IntPtr vector4s, System.Int32 count) { }
        // RVA: 0x09F61E90  token: 0x60000D9
        public static System.IntPtr GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[] vertexAttributes) { }
        // RVA: 0x09F62298  token: 0x60000DA
        public static System.Void RegisterIntermediateRenderer(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4 transform, UnityEngine.Bounds aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize) { }
        // RVA: 0x09F61CF0  token: 0x60000DB
        public static System.Void DrawRanges(System.IntPtr ib, System.IntPtr* vertexStreams, System.Int32 streamCount, System.IntPtr ranges, System.Int32 rangeCount, System.IntPtr vertexDecl) { }
        // RVA: 0x09F6236C  token: 0x60000DC
        public static System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock props) { }
        // RVA: 0x09F623D4  token: 0x60000DD
        public static System.Void SetScissorRect(UnityEngine.RectInt scissorRect) { }
        // RVA: 0x09F61CC4  token: 0x60000DE
        public static System.Void DisableScissor() { }
        // RVA: 0x09F61C78  token: 0x60000DF
        public static System.IntPtr CreateStencilState(UnityEngine.Rendering.StencilState stencilState) { }
        // RVA: 0x09F62420  token: 0x60000E0
        public static System.Void SetStencilState(System.IntPtr stencilState, System.Int32 stencilRef) { }
        // RVA: 0x09F61EC4  token: 0x60000E1
        public static System.Boolean HasMappedBufferRange() { }
        // RVA: 0x09F61EF0  token: 0x60000E2
        public static System.UInt32 InsertCPUFence() { }
        // RVA: 0x09F61C10  token: 0x60000E3
        public static System.Boolean CPUFencePassed(System.UInt32 fence) { }
        // RVA: 0x09F62550  token: 0x60000E4
        public static System.Void WaitForCPUFencePassed(System.UInt32 fence) { }
        // RVA: 0x09F624C0  token: 0x60000E5
        public static System.Void SyncRenderThread() { }
        // RVA: 0x09F61DBC  token: 0x60000E6
        public static UnityEngine.RectInt GetActiveViewport() { }
        // RVA: 0x09F61F50  token: 0x60000E7
        public static System.Void ProfileDrawChainBegin() { }
        // RVA: 0x09F61F7C  token: 0x60000E8
        public static System.Void ProfileDrawChainEnd() { }
        // RVA: 0x09F61F1C  token: 0x60000E9
        public static System.Void NotifyOfUIREvents(System.Boolean subscribe) { }
        // RVA: 0x09F61E3C  token: 0x60000EA
        public static UnityEngine.Matrix4x4 GetUnityProjectionMatrix() { }
        // RVA: 0x09F62584  token: 0x60000EB
        private static System.Void .cctor() { }
        // RVA: 0x09F62230  token: 0x60000EC
        private static System.Void RegisterIntermediateRenderer_Injected(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4& transform, UnityEngine.Bounds& aabb, System.Int32 renderLayer, System.Int32 shadowCasting, System.Boolean receiveShadows, System.Int32 sameDistanceSortPriority, System.UInt64 sceneCullingMask, System.Int32 rendererCallbackFlags, System.IntPtr userData, System.Int32 userDataSize) { }
        // RVA: 0x09F623A0  token: 0x60000ED
        private static System.Void SetScissorRect_Injected(UnityEngine.RectInt& scissorRect) { }
        // RVA: 0x09F61C44  token: 0x60000EE
        private static System.IntPtr CreateStencilState_Injected(UnityEngine.Rendering.StencilState& stencilState) { }
        // RVA: 0x09F61D88  token: 0x60000EF
        private static System.Void GetActiveViewport_Injected(UnityEngine.RectInt& ret) { }
        // RVA: 0x09F61E08  token: 0x60000F0
        private static System.Void GetUnityProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret) { }

    }

}

namespace UnityEngine.Yoga
{

    // TypeToken: 0x2000002  // size: 0x80
    public sealed class BaselineFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F5FF2C  token: 0x6000001
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x050C1AA0  token: 0x6000002
        public virtual System.Single Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height) { }

    }

    // TypeToken: 0x2000003  // size: 0x80
    public sealed class Logger : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x08140E34  token: 0x6000003
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02097E50  token: 0x6000004
        public virtual System.Void Invoke(UnityEngine.Yoga.YogaConfig config, UnityEngine.Yoga.YogaNode node, UnityEngine.Yoga.YogaLogLevel level, System.String message) { }

    }

    // TypeToken: 0x2000004  // size: 0x80
    public sealed class MeasureFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F60054  token: 0x6000005
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x06A8C000  token: 0x6000006
        public virtual UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class MeasureOutput
    {
        // Methods
        // RVA: 0x03D89AF0  token: 0x6000007
        public static UnityEngine.Yoga.YogaSize Make(System.Single width, System.Single height) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct YogaAlign
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaAlign Auto;  // const
        public static UnityEngine.Yoga.YogaAlign FlexStart;  // const
        public static UnityEngine.Yoga.YogaAlign Center;  // const
        public static UnityEngine.Yoga.YogaAlign FlexEnd;  // const
        public static UnityEngine.Yoga.YogaAlign Stretch;  // const
        public static UnityEngine.Yoga.YogaAlign Baseline;  // const
        public static UnityEngine.Yoga.YogaAlign SpaceBetween;  // const
        public static UnityEngine.Yoga.YogaAlign SpaceAround;  // const

    }

    // TypeToken: 0x2000007  // size: 0x20
    public class YogaConfig
    {
        // Fields
        private static readonly UnityEngine.Yoga.YogaConfig Default;  // static @ 0x0
        private System.IntPtr _ygConfig;  // 0x10
        private UnityEngine.Yoga.Logger _logger;  // 0x18

        // Properties
        System.IntPtr Handle { get; /* RVA: 0x03D66B80 */ }
        System.Boolean UseWebDefaults { get; /* RVA: 0x09F62FC0 */ set; /* RVA: 0x09F62FDC */ }
        System.Single PointScaleFactor { set; /* RVA: 0x09F62FD0 */ }

        // Methods
        // RVA: 0x09F62F54  token: 0x6000008
        private System.Void .ctor(System.IntPtr ygConfig) { }
        // RVA: 0x09F62F30  token: 0x6000009
        public System.Void .ctor() { }
        // RVA: 0x09F62DDC  token: 0x600000A
        protected virtual System.Void Finalize() { }
        // RVA: 0x09F62EA8  token: 0x600000F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class YogaConstants
    {
        // Methods
        // RVA: 0x09F62FE8  token: 0x6000010
        public static System.Boolean IsUndefined(System.Single value) { }

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct YogaDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaDirection Inherit;  // const
        public static UnityEngine.Yoga.YogaDirection LTR;  // const
        public static UnityEngine.Yoga.YogaDirection RTL;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct YogaDisplay
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaDisplay Flex;  // const
        public static UnityEngine.Yoga.YogaDisplay None;  // const

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct YogaEdge
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaEdge Left;  // const
        public static UnityEngine.Yoga.YogaEdge Top;  // const
        public static UnityEngine.Yoga.YogaEdge Right;  // const
        public static UnityEngine.Yoga.YogaEdge Bottom;  // const
        public static UnityEngine.Yoga.YogaEdge Start;  // const
        public static UnityEngine.Yoga.YogaEdge End;  // const
        public static UnityEngine.Yoga.YogaEdge Horizontal;  // const
        public static UnityEngine.Yoga.YogaEdge Vertical;  // const
        public static UnityEngine.Yoga.YogaEdge All;  // const

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct YogaFlexDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaFlexDirection Column;  // const
        public static UnityEngine.Yoga.YogaFlexDirection ColumnReverse;  // const
        public static UnityEngine.Yoga.YogaFlexDirection Row;  // const
        public static UnityEngine.Yoga.YogaFlexDirection RowReverse;  // const

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct YogaJustify
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaJustify FlexStart;  // const
        public static UnityEngine.Yoga.YogaJustify Center;  // const
        public static UnityEngine.Yoga.YogaJustify FlexEnd;  // const
        public static UnityEngine.Yoga.YogaJustify SpaceBetween;  // const
        public static UnityEngine.Yoga.YogaJustify SpaceAround;  // const

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct YogaLogLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaLogLevel Error;  // const
        public static UnityEngine.Yoga.YogaLogLevel Warn;  // const
        public static UnityEngine.Yoga.YogaLogLevel Info;  // const
        public static UnityEngine.Yoga.YogaLogLevel Debug;  // const
        public static UnityEngine.Yoga.YogaLogLevel Verbose;  // const
        public static UnityEngine.Yoga.YogaLogLevel Fatal;  // const

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct YogaMeasureMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaMeasureMode Undefined;  // const
        public static UnityEngine.Yoga.YogaMeasureMode Exactly;  // const
        public static UnityEngine.Yoga.YogaMeasureMode AtMost;  // const

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class Native
    {
        // Methods
        // RVA: 0x09F606F4  token: 0x6000011
        public static System.IntPtr YGNodeNewWithConfig(System.IntPtr config) { }
        // RVA: 0x09F603CC  token: 0x6000012
        public static System.Void YGNodeFree(System.IntPtr ygNode) { }
        // RVA: 0x09F60398  token: 0x6000013
        private static System.Void YGNodeFreeInternal(System.IntPtr ygNode) { }
        // RVA: 0x09F61260  token: 0x6000014
        public static System.Void YGSetManagedObject(System.IntPtr ygNode, UnityEngine.Yoga.YogaNode node) { }
        // RVA: 0x09F607A0  token: 0x6000015
        public static System.Void YGNodeSetConfig(System.IntPtr ygNode, System.IntPtr config) { }
        // RVA: 0x09F601C0  token: 0x6000016
        public static System.IntPtr YGConfigGetDefault() { }
        // RVA: 0x09F60220  token: 0x6000017
        public static System.IntPtr YGConfigNew() { }
        // RVA: 0x09F601B0  token: 0x6000018
        public static System.Void YGConfigFree(System.IntPtr config) { }
        // RVA: 0x09F6017C  token: 0x6000019
        private static System.Void YGConfigFreeInternal(System.IntPtr config) { }
        // RVA: 0x09F60290  token: 0x600001A
        public static System.Void YGConfigSetUseWebDefaults(System.IntPtr config, System.Boolean useWebDefaults) { }
        // RVA: 0x09F601EC  token: 0x600001B
        public static System.Boolean YGConfigGetUseWebDefaults(System.IntPtr config) { }
        // RVA: 0x09F6024C  token: 0x600001C
        public static System.Void YGConfigSetPointScaleFactor(System.IntPtr config, System.Single pixelsInPoint) { }
        // RVA: 0x09F60410  token: 0x600001D
        public static System.Void YGNodeInsertChild(System.IntPtr node, System.IntPtr child, System.UInt32 index) { }
        // RVA: 0x09F60728  token: 0x600001E
        public static System.Void YGNodeRemoveChild(System.IntPtr node, System.IntPtr child) { }
        // RVA: 0x09F602F0  token: 0x600001F
        public static System.Void YGNodeCalculateLayout(System.IntPtr node, System.Single availableWidth, System.Single availableHeight, UnityEngine.Yoga.YogaDirection parentDirection) { }
        // RVA: 0x09F60690  token: 0x6000020
        public static System.Void YGNodeMarkDirty(System.IntPtr node) { }
        // RVA: 0x09F60464  token: 0x6000021
        public static System.Boolean YGNodeIsDirty(System.IntPtr node) { }
        // RVA: 0x09F60354  token: 0x6000022
        public static System.Void YGNodeCopyStyle(System.IntPtr dstNode, System.IntPtr srcNode) { }
        // RVA: 0x09F60828  token: 0x6000023
        public static System.Void YGNodeSetMeasureFunc(System.IntPtr node) { }
        // RVA: 0x09F6076C  token: 0x6000024
        public static System.Void YGNodeRemoveMeasureFunc(System.IntPtr node) { }
        // RVA: 0x09F606C4  token: 0x6000025
        public static System.Void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode, System.IntPtr returnValueAddress) { }
        // RVA: 0x09F602D4  token: 0x6000026
        public static System.Void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height, System.IntPtr returnValueAddress) { }
        // RVA: 0x09F607E4  token: 0x6000027
        public static System.Void YGNodeSetHasNewLayout(System.IntPtr node, System.Boolean hasNewLayout) { }
        // RVA: 0x09F603DC  token: 0x6000028
        public static System.Boolean YGNodeGetHasNewLayout(System.IntPtr node) { }
        // RVA: 0x09F6085C  token: 0x6000029
        public static UnityEngine.Yoga.YogaDirection YGNodeStyleGetDirection(System.IntPtr node) { }
        // RVA: 0x09F60A9C  token: 0x600002A
        public static System.Void YGNodeStyleSetFlexDirection(System.IntPtr node, UnityEngine.Yoga.YogaFlexDirection flexDirection) { }
        // RVA: 0x09F60CA4  token: 0x600002B
        public static System.Void YGNodeStyleSetJustifyContent(System.IntPtr node, UnityEngine.Yoga.YogaJustify justifyContent) { }
        // RVA: 0x09F60890  token: 0x600002C
        public static System.Void YGNodeStyleSetAlignContent(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignContent) { }
        // RVA: 0x09F608D0  token: 0x600002D
        public static System.Void YGNodeStyleSetAlignItems(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignItems) { }
        // RVA: 0x09F60910  token: 0x600002E
        public static System.Void YGNodeStyleSetAlignSelf(System.IntPtr node, UnityEngine.Yoga.YogaAlign alignSelf) { }
        // RVA: 0x09F61114  token: 0x600002F
        public static System.Void YGNodeStyleSetPositionType(System.IntPtr node, UnityEngine.Yoga.YogaPositionType positionType) { }
        // RVA: 0x09F60B64  token: 0x6000030
        public static System.Void YGNodeStyleSetFlexWrap(System.IntPtr node, UnityEngine.Yoga.YogaWrap flexWrap) { }
        // RVA: 0x09F60FE4  token: 0x6000031
        public static System.Void YGNodeStyleSetOverflow(System.IntPtr node, UnityEngine.Yoga.YogaOverflow flexWrap) { }
        // RVA: 0x09F609A0  token: 0x6000032
        public static System.Void YGNodeStyleSetDisplay(System.IntPtr node, UnityEngine.Yoga.YogaDisplay display) { }
        // RVA: 0x09F60BA4  token: 0x6000033
        public static System.Void YGNodeStyleSetFlex(System.IntPtr node, System.Single flex) { }
        // RVA: 0x09F60ADC  token: 0x6000034
        public static System.Void YGNodeStyleSetFlexGrow(System.IntPtr node, System.Single flexGrow) { }
        // RVA: 0x09F60B20  token: 0x6000035
        public static System.Void YGNodeStyleSetFlexShrink(System.IntPtr node, System.Single flexShrink) { }
        // RVA: 0x09F60A58  token: 0x6000036
        public static System.Void YGNodeStyleSetFlexBasis(System.IntPtr node, System.Single flexBasis) { }
        // RVA: 0x09F60A14  token: 0x6000037
        public static System.Void YGNodeStyleSetFlexBasisPercent(System.IntPtr node, System.Single flexBasis) { }
        // RVA: 0x09F609E0  token: 0x6000038
        public static System.Void YGNodeStyleSetFlexBasisAuto(System.IntPtr node) { }
        // RVA: 0x09F6121C  token: 0x6000039
        public static System.Void YGNodeStyleSetWidth(System.IntPtr node, System.Single width) { }
        // RVA: 0x09F611D8  token: 0x600003A
        public static System.Void YGNodeStyleSetWidthPercent(System.IntPtr node, System.Single width) { }
        // RVA: 0x09F611A4  token: 0x600003B
        public static System.Void YGNodeStyleSetWidthAuto(System.IntPtr node) { }
        // RVA: 0x09F60C60  token: 0x600003C
        public static System.Void YGNodeStyleSetHeight(System.IntPtr node, System.Single height) { }
        // RVA: 0x09F60C1C  token: 0x600003D
        public static System.Void YGNodeStyleSetHeightPercent(System.IntPtr node, System.Single height) { }
        // RVA: 0x09F60BE8  token: 0x600003E
        public static System.Void YGNodeStyleSetHeightAuto(System.IntPtr node) { }
        // RVA: 0x09F60FA0  token: 0x600003F
        public static System.Void YGNodeStyleSetMinWidth(System.IntPtr node, System.Single minWidth) { }
        // RVA: 0x09F60F5C  token: 0x6000040
        public static System.Void YGNodeStyleSetMinWidthPercent(System.IntPtr node, System.Single minWidth) { }
        // RVA: 0x09F60F18  token: 0x6000041
        public static System.Void YGNodeStyleSetMinHeight(System.IntPtr node, System.Single minHeight) { }
        // RVA: 0x09F60ED4  token: 0x6000042
        public static System.Void YGNodeStyleSetMinHeightPercent(System.IntPtr node, System.Single minHeight) { }
        // RVA: 0x09F60E90  token: 0x6000043
        public static System.Void YGNodeStyleSetMaxWidth(System.IntPtr node, System.Single maxWidth) { }
        // RVA: 0x09F60E4C  token: 0x6000044
        public static System.Void YGNodeStyleSetMaxWidthPercent(System.IntPtr node, System.Single maxWidth) { }
        // RVA: 0x09F60E08  token: 0x6000045
        public static System.Void YGNodeStyleSetMaxHeight(System.IntPtr node, System.Single maxHeight) { }
        // RVA: 0x09F60DC4  token: 0x6000046
        public static System.Void YGNodeStyleSetMaxHeightPercent(System.IntPtr node, System.Single maxHeight) { }
        // RVA: 0x09F61154  token: 0x6000047
        public static System.Void YGNodeStyleSetPosition(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position) { }
        // RVA: 0x09F610C4  token: 0x6000048
        public static System.Void YGNodeStyleSetPositionPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single position) { }
        // RVA: 0x09F60D74  token: 0x6000049
        public static System.Void YGNodeStyleSetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin) { }
        // RVA: 0x09F60D24  token: 0x600004A
        public static System.Void YGNodeStyleSetMarginPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single margin) { }
        // RVA: 0x09F60CE4  token: 0x600004B
        public static System.Void YGNodeStyleSetMarginAuto(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        // RVA: 0x09F61074  token: 0x600004C
        public static System.Void YGNodeStyleSetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding) { }
        // RVA: 0x09F61024  token: 0x600004D
        public static System.Void YGNodeStyleSetPaddingPercent(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single padding) { }
        // RVA: 0x09F60950  token: 0x600004E
        public static System.Void YGNodeStyleSetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge, System.Single border) { }
        // RVA: 0x09F60540  token: 0x600004F
        public static System.Single YGNodeLayoutGetLeft(System.IntPtr node) { }
        // RVA: 0x09F60628  token: 0x6000050
        public static System.Single YGNodeLayoutGetTop(System.IntPtr node) { }
        // RVA: 0x09F605F4  token: 0x6000051
        public static System.Single YGNodeLayoutGetRight(System.IntPtr node) { }
        // RVA: 0x09F604D8  token: 0x6000052
        public static System.Single YGNodeLayoutGetBottom(System.IntPtr node) { }
        // RVA: 0x09F6065C  token: 0x6000053
        public static System.Single YGNodeLayoutGetWidth(System.IntPtr node) { }
        // RVA: 0x09F6050C  token: 0x6000054
        public static System.Single YGNodeLayoutGetHeight(System.IntPtr node) { }
        // RVA: 0x09F60574  token: 0x6000055
        public static System.Single YGNodeLayoutGetMargin(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        // RVA: 0x09F605B4  token: 0x6000056
        public static System.Single YGNodeLayoutGetPadding(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }
        // RVA: 0x09F60498  token: 0x6000057
        public static System.Single YGNodeLayoutGetBorder(System.IntPtr node, UnityEngine.Yoga.YogaEdge edge) { }

    }

    // TypeToken: 0x2000011  // size: 0x48
    public class YogaNode : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private System.IntPtr _ygNode;  // 0x10
        private UnityEngine.Yoga.YogaConfig _config;  // 0x18
        private System.WeakReference _parent;  // 0x20
        private System.Collections.Generic.List<UnityEngine.Yoga.YogaNode> _children;  // 0x28
        private UnityEngine.Yoga.MeasureFunction _measureFunction;  // 0x30
        private UnityEngine.Yoga.BaselineFunction _baselineFunction;  // 0x38
        private System.Object _data;  // 0x40

        // Properties
        UnityEngine.Yoga.YogaConfig Config { set; /* RVA: 0x09F6393C */ }
        System.Boolean IsDirty { get; /* RVA: 0x09F63764 */ }
        System.Boolean HasNewLayout { get; /* RVA: 0x09F63754 */ }
        System.Boolean IsMeasureDefined { get; /* RVA: 0x085839D0 */ }
        System.Boolean IsBaselineDefined { get; /* RVA: 0x060DAC58 */ }
        UnityEngine.Yoga.YogaFlexDirection FlexDirection { set; /* RVA: 0x09F63A28 */ }
        UnityEngine.Yoga.YogaJustify JustifyContent { set; /* RVA: 0x09F63AAC */ }
        UnityEngine.Yoga.YogaDisplay Display { set; /* RVA: 0x09F639C8 */ }
        UnityEngine.Yoga.YogaAlign AlignItems { set; /* RVA: 0x09F638C4 */ }
        UnityEngine.Yoga.YogaAlign AlignSelf { set; /* RVA: 0x09F638D0 */ }
        UnityEngine.Yoga.YogaAlign AlignContent { set; /* RVA: 0x09F638B8 */ }
        UnityEngine.Yoga.YogaPositionType PositionType { set; /* RVA: 0x09F63C24 */ }
        UnityEngine.Yoga.YogaWrap Wrap { set; /* RVA: 0x09F63CA4 */ }
        System.Single Flex { set; /* RVA: 0x09F63A4C */ }
        System.Single FlexGrow { set; /* RVA: 0x09F63A34 */ }
        System.Single FlexShrink { set; /* RVA: 0x09F63A40 */ }
        UnityEngine.Yoga.YogaValue FlexBasis { set; /* RVA: 0x09F639D4 */ }
        UnityEngine.Yoga.YogaValue Width { set; /* RVA: 0x09F63C50 */ }
        UnityEngine.Yoga.YogaValue Height { set; /* RVA: 0x09F63A58 */ }
        UnityEngine.Yoga.YogaValue MaxWidth { set; /* RVA: 0x09F63B3C */ }
        UnityEngine.Yoga.YogaValue MaxHeight { set; /* RVA: 0x09F63B08 */ }
        UnityEngine.Yoga.YogaValue MinWidth { set; /* RVA: 0x09F63BA4 */ }
        UnityEngine.Yoga.YogaValue MinHeight { set; /* RVA: 0x09F63B70 */ }
        System.Single LayoutX { get; /* RVA: 0x09F63898 */ }
        System.Single LayoutY { get; /* RVA: 0x09F638A8 */ }
        System.Single LayoutRight { get; /* RVA: 0x09F63878 */ }
        System.Single LayoutBottom { get; /* RVA: 0x09F637C0 */ }
        System.Single LayoutWidth { get; /* RVA: 0x09F63888 */ }
        System.Single LayoutHeight { get; /* RVA: 0x09F637D0 */ }
        UnityEngine.Yoga.YogaOverflow Overflow { set; /* RVA: 0x09F63BD8 */ }
        System.Int32 Count { get; /* RVA: 0x09F63710 */ }
        UnityEngine.Yoga.YogaValue Left { set; /* RVA: 0x09F63AB8 */ }
        UnityEngine.Yoga.YogaValue Top { set; /* RVA: 0x09F63C40 */ }
        UnityEngine.Yoga.YogaValue Right { set; /* RVA: 0x09F63C30 */ }
        UnityEngine.Yoga.YogaValue Bottom { set; /* RVA: 0x09F6392C */ }
        UnityEngine.Yoga.YogaValue MarginLeft { set; /* RVA: 0x09F63AD8 */ }
        UnityEngine.Yoga.YogaValue MarginTop { set; /* RVA: 0x09F63AF8 */ }
        UnityEngine.Yoga.YogaValue MarginRight { set; /* RVA: 0x09F63AE8 */ }
        UnityEngine.Yoga.YogaValue MarginBottom { set; /* RVA: 0x09F63AC8 */ }
        UnityEngine.Yoga.YogaValue PaddingLeft { set; /* RVA: 0x09F63BF4 */ }
        UnityEngine.Yoga.YogaValue PaddingTop { set; /* RVA: 0x09F63C14 */ }
        UnityEngine.Yoga.YogaValue PaddingRight { set; /* RVA: 0x09F63C04 */ }
        UnityEngine.Yoga.YogaValue PaddingBottom { set; /* RVA: 0x09F63BE4 */ }
        System.Single BorderLeftWidth { set; /* RVA: 0x09F638F0 */ }
        System.Single BorderTopWidth { set; /* RVA: 0x09F63918 */ }
        System.Single BorderRightWidth { set; /* RVA: 0x09F63904 */ }
        System.Single BorderBottomWidth { set; /* RVA: 0x09F638DC */ }
        System.Single LayoutMarginLeft { get; /* RVA: 0x09F637F4 */ }
        System.Single LayoutMarginTop { get; /* RVA: 0x09F63818 */ }
        System.Single LayoutMarginRight { get; /* RVA: 0x09F63804 */ }
        System.Single LayoutMarginBottom { get; /* RVA: 0x09F637E0 */ }
        System.Single LayoutPaddingLeft { get; /* RVA: 0x09F63840 */ }
        System.Single LayoutPaddingTop { get; /* RVA: 0x09F63864 */ }
        System.Single LayoutPaddingRight { get; /* RVA: 0x09F63850 */ }
        System.Single LayoutPaddingBottom { get; /* RVA: 0x09F6382C */ }
        System.Single LayoutBorderLeft { get; /* RVA: 0x09F63788 */ }
        System.Single LayoutBorderTop { get; /* RVA: 0x09F637AC */ }
        System.Single LayoutBorderRight { get; /* RVA: 0x09F63798 */ }
        System.Single LayoutBorderBottom { get; /* RVA: 0x09F63774 */ }

        // Methods
        // RVA: 0x09F63634  token: 0x6000058
        public System.Void .ctor(UnityEngine.Yoga.YogaConfig config) { }
        // RVA: 0x09F63150  token: 0x6000059
        protected virtual System.Void Finalize() { }
        // RVA: 0x09F6334C  token: 0x600005C
        public virtual System.Void MarkDirty() { }
        // RVA: 0x09F6312C  token: 0x6000060
        public System.Void CopyStyle(UnityEngine.Yoga.YogaNode srcNode) { }
        // RVA: 0x09F63358  token: 0x600007B
        public System.Void MarkLayoutSeen() { }
        // RVA: 0x09F63230  token: 0x600007C
        public System.Void Insert(System.Int32 index, UnityEngine.Yoga.YogaNode node) { }
        // RVA: 0x09F63400  token: 0x600007D
        public System.Void RemoveAt(System.Int32 index) { }
        // RVA: 0x09F630D0  token: 0x600007E
        public System.Void Clear() { }
        // RVA: 0x09F634A8  token: 0x600007F
        public System.Void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction measureFunction) { }
        // RVA: 0x09F63080  token: 0x6000080
        public System.Void CalculateLayout(System.Single width, System.Single height) { }
        // RVA: 0x09F63368  token: 0x6000081
        public static UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode) { }
        // RVA: 0x09F62FF0  token: 0x6000082
        public static System.Single BaselineInternal(UnityEngine.Yoga.YogaNode node, System.Single width, System.Single height) { }
        // RVA: 0x09F631C4  token: 0x6000083
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator() { }
        // RVA: 0x09F635C8  token: 0x6000084
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x09F63594  token: 0x6000089
        private System.Void SetStylePosition(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }
        // RVA: 0x09F6350C  token: 0x600008E
        private System.Void SetStyleMargin(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }
        // RVA: 0x09F63560  token: 0x6000093
        private System.Void SetStylePadding(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value) { }

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct YogaOverflow
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaOverflow Visible;  // const
        public static UnityEngine.Yoga.YogaOverflow Hidden;  // const
        public static UnityEngine.Yoga.YogaOverflow Scroll;  // const

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct YogaPositionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaPositionType Relative;  // const
        public static UnityEngine.Yoga.YogaPositionType Absolute;  // const

    }

    // TypeToken: 0x2000014  // size: 0x18
    public sealed struct YogaSize
    {
        // Fields
        public System.Single width;  // 0x10
        public System.Single height;  // 0x14

    }

    // TypeToken: 0x2000015  // size: 0x14
    public sealed struct YogaUnit
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaUnit Undefined;  // const
        public static UnityEngine.Yoga.YogaUnit Point;  // const
        public static UnityEngine.Yoga.YogaUnit Percent;  // const
        public static UnityEngine.Yoga.YogaUnit Auto;  // const

    }

    // TypeToken: 0x2000016  // size: 0x18
    public sealed struct YogaValue
    {
        // Fields
        private System.Single value;  // 0x10
        private UnityEngine.Yoga.YogaUnit unit;  // 0x14

        // Properties
        UnityEngine.Yoga.YogaUnit Unit { get; /* RVA: 0x03D698C0 */ }
        System.Single Value { get; /* RVA: 0x03D85AE0 */ }

        // Methods
        // RVA: 0x09F63DC8  token: 0x60000A6
        public static UnityEngine.Yoga.YogaValue Point(System.Single value) { }
        // RVA: 0x09F63CB0  token: 0x60000A7
        public System.Boolean Equals(UnityEngine.Yoga.YogaValue other) { }
        // RVA: 0x09F63D04  token: 0x60000A8
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F63D74  token: 0x60000A9
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x03D89B00  token: 0x60000AA
        public static UnityEngine.Yoga.YogaValue Auto() { }
        // RVA: 0x09F63DA4  token: 0x60000AB
        public static UnityEngine.Yoga.YogaValue Percent(System.Single value) { }
        // RVA: 0x09F63DC8  token: 0x60000AC
        public static UnityEngine.Yoga.YogaValue op_Implicit(System.Single pointValue) { }

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct YogaWrap
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Yoga.YogaWrap NoWrap;  // const
        public static UnityEngine.Yoga.YogaWrap Wrap;  // const
        public static UnityEngine.Yoga.YogaWrap WrapReverse;  // const

    }

}

