// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.IMGUIModule.dll
// Classes:  45
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000A  // size: 0x80
    public sealed class WindowFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056ECA08  token: 0x6000097
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000098
        public virtual System.Void Invoke(System.Int32 id) { }

    }

    // TypeToken: 0x200000C  // size: 0x11
    public sealed struct ParentClipScope : System.IDisposable
    {
        // Fields
        private System.Boolean m_Disposed;  // 0x10

        // Methods
        // RVA: 0x09E0BAA8  token: 0x60000B2
        public System.Void .ctor(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect) { }
        // RVA: 0x09E0BA98  token: 0x60000B3
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.GUILayoutOption.Type fixedWidth;  // const
        public static UnityEngine.GUILayoutOption.Type fixedHeight;  // const
        public static UnityEngine.GUILayoutOption.Type minWidth;  // const
        public static UnityEngine.GUILayoutOption.Type maxWidth;  // const
        public static UnityEngine.GUILayoutOption.Type minHeight;  // const
        public static UnityEngine.GUILayoutOption.Type maxHeight;  // const
        public static UnityEngine.GUILayoutOption.Type stretchWidth;  // const
        public static UnityEngine.GUILayoutOption.Type stretchHeight;  // const
        public static UnityEngine.GUILayoutOption.Type alignStart;  // const
        public static UnityEngine.GUILayoutOption.Type alignMiddle;  // const
        public static UnityEngine.GUILayoutOption.Type alignEnd;  // const
        public static UnityEngine.GUILayoutOption.Type alignJustify;  // const
        public static UnityEngine.GUILayoutOption.Type equalSize;  // const
        public static UnityEngine.GUILayoutOption.Type spacing;  // const

    }

    // TypeToken: 0x2000014  // size: 0x30
    public sealed class LayoutCache
    {
        // Fields
        private System.Int32 <id>k__BackingField;  // 0x10
        private UnityEngine.GUILayoutGroup topLevel;  // 0x18
        private UnityEngineInternal.GenericStack layoutGroups;  // 0x20
        private UnityEngine.GUILayoutGroup windows;  // 0x28

        // Properties
        System.Int32 id { set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x09E0B9A8  token: 0x60000F9
        private System.Void .ctor(System.Int32 instanceID) { }
        // RVA: 0x09E0B70C  token: 0x60000FA
        public System.Void ResetCursor() { }

    }

    // TypeToken: 0x2000017  // size: 0x80
    public sealed class SkinChangedDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x600013F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000140
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x2000029  // size: 0x11
    public sealed struct DblClickSnapping
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static UnityEngine.TextEditor.DblClickSnapping WORDS;  // const
        public static UnityEngine.TextEditor.DblClickSnapping PARAGRAPHS;  // const

    }

    // TypeToken: 0x200002A  // size: 0x14
    public sealed struct CharacterType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TextEditor.CharacterType LetterLike;  // const
        public static UnityEngine.TextEditor.CharacterType Symbol;  // const
        public static UnityEngine.TextEditor.CharacterType Symbol2;  // const
        public static UnityEngine.TextEditor.CharacterType WhiteSpace;  // const

    }

    // TypeToken: 0x200002B  // size: 0x14
    public sealed struct Direction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TextEditor.Direction Forward;  // const
        public static UnityEngine.TextEditor.Direction Backward;  // const

    }

    // TypeToken: 0x200002C  // size: 0x14
    public sealed struct TextEditOp
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TextEditor.TextEditOp MoveLeft;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveRight;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveUp;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveDown;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveLineStart;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveLineEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveTextStart;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveTextEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp MovePageUp;  // const
        public static UnityEngine.TextEditor.TextEditOp MovePageDown;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveGraphicalLineStart;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveGraphicalLineEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveWordLeft;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveWordRight;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveParagraphForward;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveParagraphBackward;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveToStartOfNextWord;  // const
        public static UnityEngine.TextEditor.TextEditOp MoveToEndOfPreviousWord;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectLeft;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectRight;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectUp;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectDown;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectTextStart;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectTextEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectPageUp;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectPageDown;  // const
        public static UnityEngine.TextEditor.TextEditOp ExpandSelectGraphicalLineStart;  // const
        public static UnityEngine.TextEditor.TextEditOp ExpandSelectGraphicalLineEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectGraphicalLineStart;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectGraphicalLineEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectWordLeft;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectWordRight;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectToEndOfPreviousWord;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectToStartOfNextWord;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectParagraphBackward;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectParagraphForward;  // const
        public static UnityEngine.TextEditor.TextEditOp Delete;  // const
        public static UnityEngine.TextEditor.TextEditOp Backspace;  // const
        public static UnityEngine.TextEditor.TextEditOp DeleteWordBack;  // const
        public static UnityEngine.TextEditor.TextEditOp DeleteWordForward;  // const
        public static UnityEngine.TextEditor.TextEditOp DeleteLineBack;  // const
        public static UnityEngine.TextEditor.TextEditOp Cut;  // const
        public static UnityEngine.TextEditor.TextEditOp Copy;  // const
        public static UnityEngine.TextEditor.TextEditOp Paste;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectAll;  // const
        public static UnityEngine.TextEditor.TextEditOp SelectNone;  // const
        public static UnityEngine.TextEditor.TextEditOp ScrollStart;  // const
        public static UnityEngine.TextEditor.TextEditOp ScrollEnd;  // const
        public static UnityEngine.TextEditor.TextEditOp ScrollPageUp;  // const
        public static UnityEngine.TextEditor.TextEditOp ScrollPageDown;  // const

    }

    // TypeToken: 0x200002D  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Methods
        // RVA: 0x056516CC  token: 0x60002DA
        private static System.UInt32 ComputeStringHash(System.String s) { }

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class EmbeddedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsReadOnlyAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class Event
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10
        private static UnityEngine.Event s_Current;  // static @ 0x0
        private static UnityEngine.Event s_MasterEvent;  // static @ 0x8

        // Properties
        UnityEngine.EventType rawType { get; /* RVA: 0x02CD9480 */ }
        UnityEngine.Vector2 mousePosition { get; /* RVA: 0x09DFAF2C */ set; /* RVA: 0x09DFB238 */ }
        UnityEngine.Vector2 delta { get; /* RVA: 0x09DFAE0C */ set; /* RVA: 0x09DFB158 */ }
        UnityEngine.PointerType pointerType { get; /* RVA: 0x09DFAF50 */ }
        System.Int32 button { get; /* RVA: 0x09DFACC4 */ }
        UnityEngine.EventModifiers modifiers { get; /* RVA: 0x02CD9AC0 */ set; /* RVA: 0x09DFB1B4 */ }
        System.Single pressure { get; /* RVA: 0x09DFAF84 */ }
        System.Int32 clickCount { get; /* RVA: 0x09DFACF8 */ }
        System.Char character { get; /* RVA: 0x02CD9B40 */ set; /* RVA: 0x09DFB004 */ }
        UnityEngine.KeyCode keyCode { get; /* RVA: 0x02CD9B00 */ set; /* RVA: 0x09DFB174 */ }
        System.Int32 displayIndex { get; /* RVA: 0x09DFAE30 */ set; /* RVA: 0x02EEA700 */ }
        UnityEngine.EventType type { get; /* RVA: 0x09DFAFD0 */ set; /* RVA: 0x09DFB254 */ }
        System.String commandName { get; /* RVA: 0x09DFAD2C */ set; /* RVA: 0x09DFB048 */ }
        System.Boolean shift { get; /* RVA: 0x09DFAFB8 */ }
        System.Boolean control { get; /* RVA: 0x09DFAD78 */ }
        System.Boolean alt { get; /* RVA: 0x09DFACAC */ }
        System.Boolean command { get; /* RVA: 0x09DFAD60 */ }
        UnityEngine.Event current { get; /* RVA: 0x09DFAD90 */ set; /* RVA: 0x09DFB08C */ }
        System.Boolean isKey { get; /* RVA: 0x09DFAE9C */ }
        System.Boolean isMouse { get; /* RVA: 0x09DFAEBC */ }
        System.Boolean isDirectManipulationDevice { get; /* RVA: 0x09DFAE64 */ }

        // Methods
        // RVA: 0x09DF96AC  token: 0x6000018
        private System.Void Internal_Use() { }
        // RVA: 0x02849DD0  token: 0x6000019
        private static System.IntPtr Internal_Create(System.Int32 displayIndex) { }
        // RVA: 0x038E8A20  token: 0x600001A
        private static System.Void Internal_Destroy(System.IntPtr ptr) { }
        // RVA: 0x09DF966C  token: 0x600001B
        public UnityEngine.EventType GetTypeForControl(System.Int32 controlID) { }
        // RVA: 0x09DF941C  token: 0x600001C
        private System.Void CopyFromPtr(System.IntPtr ptr) { }
        // RVA: 0x02CD9440  token: 0x600001D
        public static System.Boolean PopEvent(UnityEngine.Event outEvent) { }
        // RVA: 0x02EEA6C0  token: 0x600001E
        private static System.Void Internal_SetNativeEvent(System.IntPtr ptr) { }
        // RVA: 0x02EEA550  token: 0x600001F
        private static System.Void Internal_MakeMasterEventCurrent(System.Int32 displayIndex) { }
        // RVA: 0x09DF95D0  token: 0x6000020
        private static System.Int32 GetDoubleClickTime() { }
        // RVA: 0x02849DB0  token: 0x6000021
        public System.Void .ctor() { }
        // RVA: 0x0284ABF0  token: 0x6000022
        public System.Void .ctor(System.Int32 displayIndex) { }
        // RVA: 0x038E8980  token: 0x6000023
        protected virtual System.Void Finalize() { }
        // RVA: 0x09DF9460  token: 0x6000024
        private System.Void CopyFrom(UnityEngine.Event e) { }
        // RVA: 0x09DF96E0  token: 0x600002E
        public static UnityEngine.Event KeyboardEvent(System.String key) { }
        // RVA: 0x09DF95FC  token: 0x600002F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09DF948C  token: 0x6000030
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09DFA68C  token: 0x6000031
        public virtual System.String ToString() { }
        // RVA: 0x09DFAB98  token: 0x6000032
        public System.Void Use() { }
        // RVA: 0x09DFAEE8  token: 0x6000033
        private System.Void get_mousePosition_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09DFB1F4  token: 0x6000034
        private System.Void set_mousePosition_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09DFADC8  token: 0x6000035
        private System.Void get_delta_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09DFB114  token: 0x6000036
        private System.Void set_delta_Injected(UnityEngine.Vector2& value) { }

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct EventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventType MouseDown;  // const
        public static UnityEngine.EventType MouseUp;  // const
        public static UnityEngine.EventType MouseMove;  // const
        public static UnityEngine.EventType MouseDrag;  // const
        public static UnityEngine.EventType KeyDown;  // const
        public static UnityEngine.EventType KeyUp;  // const
        public static UnityEngine.EventType ScrollWheel;  // const
        public static UnityEngine.EventType Repaint;  // const
        public static UnityEngine.EventType Layout;  // const
        public static UnityEngine.EventType DragUpdated;  // const
        public static UnityEngine.EventType DragPerform;  // const
        public static UnityEngine.EventType DragExited;  // const
        public static UnityEngine.EventType Ignore;  // const
        public static UnityEngine.EventType Used;  // const
        public static UnityEngine.EventType ValidateCommand;  // const
        public static UnityEngine.EventType ExecuteCommand;  // const
        public static UnityEngine.EventType ContextClick;  // const
        public static UnityEngine.EventType MouseEnterWindow;  // const
        public static UnityEngine.EventType MouseLeaveWindow;  // const
        public static UnityEngine.EventType TouchDown;  // const
        public static UnityEngine.EventType TouchUp;  // const
        public static UnityEngine.EventType TouchMove;  // const
        public static UnityEngine.EventType TouchEnter;  // const
        public static UnityEngine.EventType TouchLeave;  // const
        public static UnityEngine.EventType TouchStationary;  // const
        public static UnityEngine.EventType mouseDown;  // const
        public static UnityEngine.EventType mouseUp;  // const
        public static UnityEngine.EventType mouseMove;  // const
        public static UnityEngine.EventType mouseDrag;  // const
        public static UnityEngine.EventType keyDown;  // const
        public static UnityEngine.EventType keyUp;  // const
        public static UnityEngine.EventType scrollWheel;  // const
        public static UnityEngine.EventType repaint;  // const
        public static UnityEngine.EventType layout;  // const
        public static UnityEngine.EventType dragUpdated;  // const
        public static UnityEngine.EventType dragPerform;  // const
        public static UnityEngine.EventType ignore;  // const
        public static UnityEngine.EventType used;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct EventModifiers
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventModifiers None;  // const
        public static UnityEngine.EventModifiers Shift;  // const
        public static UnityEngine.EventModifiers Control;  // const
        public static UnityEngine.EventModifiers Alt;  // const
        public static UnityEngine.EventModifiers Command;  // const
        public static UnityEngine.EventModifiers Numeric;  // const
        public static UnityEngine.EventModifiers CapsLock;  // const
        public static UnityEngine.EventModifiers FunctionKey;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct PointerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.PointerType Mouse;  // const
        public static UnityEngine.PointerType Touch;  // const
        public static UnityEngine.PointerType Pen;  // const

    }

    // TypeToken: 0x2000008  // size: 0x13
    public sealed struct EventInterests
    {
        // Fields
        private System.Boolean <wantsMouseMove>k__BackingField;  // 0x10
        private System.Boolean <wantsMouseEnterLeaveWindow>k__BackingField;  // 0x11
        private System.Boolean <wantsLessLayoutEvents>k__BackingField;  // 0x12

        // Properties
        System.Boolean wantsMouseMove { get; /* RVA: 0x03D51020 */ set; /* RVA: 0x03D4F9D0 */ }
        System.Boolean wantsMouseEnterLeaveWindow { get; /* RVA: 0x03D559E0 */ set; /* RVA: 0x03D5BC30 */ }
        System.Boolean wantsLessLayoutEvents { get; /* RVA: 0x03D559C0 */ }

        // Methods
        // RVA: 0x09DF938C  token: 0x600003C
        public System.Boolean WantsEvent(UnityEngine.EventType type) { }
        // RVA: 0x09DF93A8  token: 0x600003D
        public System.Boolean WantsLayoutPass(UnityEngine.EventType type) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class GUI
    {
        // Fields
        private static System.Int32 s_ScrollControlId;  // static @ 0x0
        private static System.Int32 s_HotTextField;  // static @ 0x4
        private static readonly System.Int32 s_BoxHash;  // static @ 0x8
        private static readonly System.Int32 s_ButonHash;  // static @ 0xc
        private static readonly System.Int32 s_RepeatButtonHash;  // static @ 0x10
        private static readonly System.Int32 s_ToggleHash;  // static @ 0x14
        private static readonly System.Int32 s_ButtonGridHash;  // static @ 0x18
        private static readonly System.Int32 s_SliderHash;  // static @ 0x1c
        private static readonly System.Int32 s_BeginGroupHash;  // static @ 0x20
        private static readonly System.Int32 s_ScrollviewHash;  // static @ 0x24
        private static System.Int32 <scrollTroughSide>k__BackingField;  // static @ 0x28
        private static System.DateTime <nextScrollStepTime>k__BackingField;  // static @ 0x30
        private static UnityEngine.GUISkin s_Skin;  // static @ 0x38
        private static UnityEngine.Rect s_ToolTipRect;  // static @ 0x40
        private static UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField;  // static @ 0x50

        // Properties
        UnityEngine.Color color { get; /* RVA: 0x09E0B0E4 */ set; /* RVA: 0x09E0B4D8 */ }
        UnityEngine.Color backgroundColor { get; /* RVA: 0x09E0AFE0 */ set; /* RVA: 0x09E0B424 */ }
        UnityEngine.Color contentColor { get; /* RVA: 0x09E0B164 */ set; /* RVA: 0x09E0B558 */ }
        System.Boolean changed { get; /* RVA: 0x09E0B084 */ set; /* RVA: 0x09E0B470 */ }
        System.Boolean enabled { get; /* RVA: 0x09E0B1B0 */ set; /* RVA: 0x09E0B5A4 */ }
        System.Boolean usePageScrollbars { get; /* RVA: 0x09E0B3C4 */ }
        UnityEngine.Material blendMaterial { get; /* RVA: 0x09E0B02C */ }
        UnityEngine.Material blitMaterial { get; /* RVA: 0x09E0B058 */ }
        UnityEngine.Material roundedRectMaterial { get; /* RVA: 0x09E0B274 */ }
        UnityEngine.Material roundedRectWithColorPerBorderMaterial { get; /* RVA: 0x09E0B2A0 */ }
        System.Int32 scrollTroughSide { get; /* RVA: 0x09E0B2CC */ set; /* RVA: 0x09E0B668 */ }
        System.DateTime nextScrollStepTime { get; /* RVA: 0x09E0B224 */ set; /* RVA: 0x09E0B610 */ }
        UnityEngine.GUISkin skin { get; /* RVA: 0x09E0B36C */ set; /* RVA: 0x09E0B6BC */ }
        UnityEngine.Matrix4x4 matrix { get; /* RVA: 0x09E0B1DC */ set; /* RVA: 0x09E0B5D8 */ }
        UnityEngineInternal.GenericStack scrollViewStates { get; /* RVA: 0x09E0B31C */ }

        // Methods
        // RVA: 0x09E09008  token: 0x600004D
        public static System.Void GrabMouseControl(System.Int32 id) { }
        // RVA: 0x09E09B78  token: 0x600004E
        public static System.Boolean HasMouseControl(System.Int32 id) { }
        // RVA: 0x09E0A104  token: 0x600004F
        public static System.Void ReleaseMouseControl() { }
        // RVA: 0x09E09D7C  token: 0x6000050
        private static System.Void InternalRepaintEditorWindow() { }
        // RVA: 0x09E09E08  token: 0x6000051
        private static UnityEngine.Rect Internal_DoWindow(System.Int32 id, System.Int32 instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, System.Object skin, System.Boolean forceRectOnLayout) { }
        // RVA: 0x09E07D70  token: 0x6000052
        public static System.Void DragWindow(UnityEngine.Rect position) { }
        // RVA: 0x09E0AD4C  token: 0x6000053
        private static System.Void .cctor() { }
        // RVA: 0x09E076E8  token: 0x600005A
        private static System.Void DoSetSkin(UnityEngine.GUISkin newSkin) { }
        // RVA: 0x09E09F54  token: 0x600005D
        public static System.Void Label(UnityEngine.Rect position, System.String text) { }
        // RVA: 0x09E09EC0  token: 0x600005E
        public static System.Void Label(UnityEngine.Rect position, System.String text, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E09FF8  token: 0x600005F
        public static System.Void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0877C  token: 0x6000060
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image) { }
        // RVA: 0x09E08708  token: 0x6000061
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode) { }
        // RVA: 0x09E07DBC  token: 0x6000062
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend) { }
        // RVA: 0x09E08540  token: 0x6000063
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect) { }
        // RVA: 0x09E08600  token: 0x6000064
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, System.Single borderWidth, System.Single borderRadius) { }
        // RVA: 0x09E07E48  token: 0x6000065
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, System.Single borderRadius) { }
        // RVA: 0x09E0844C  token: 0x6000066
        public static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses) { }
        // RVA: 0x09E08340  token: 0x6000067
        private static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners) { }
        // RVA: 0x09E07F4C  token: 0x6000068
        private static System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners) { }
        // RVA: 0x09E06C44  token: 0x6000069
        private static System.Boolean CalculateScaledTextureRects(UnityEngine.Rect position, UnityEngine.ScaleMode scaleMode, System.Single imageAspect, UnityEngine.Rect& outScreenRect, UnityEngine.Rect& outSourceRect) { }
        // RVA: 0x09E06944  token: 0x600006A
        public static System.Void Box(UnityEngine.Rect position, System.String text) { }
        // RVA: 0x09E0684C  token: 0x600006B
        public static System.Void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E069E8  token: 0x600006C
        public static System.Boolean Button(UnityEngine.Rect position, System.String text) { }
        // RVA: 0x09E06A8C  token: 0x600006D
        public static System.Boolean Button(UnityEngine.Rect position, System.String text, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E06B20  token: 0x600006E
        public static System.Boolean Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E06BBC  token: 0x600006F
        private static System.Boolean Button(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E074FC  token: 0x6000070
        private static System.Boolean DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType) { }
        // RVA: 0x09E0A834  token: 0x6000071
        public static System.String TextField(UnityEngine.Rect position, System.String text) { }
        // RVA: 0x09E0A06C  token: 0x6000072
        private static System.String PasswordFieldGetStrToShow(System.String password, System.Char maskChar) { }
        // RVA: 0x09E0778C  token: 0x6000073
        private static System.Void DoTextField(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E07AC4  token: 0x6000074
        private static System.Void DoTextField(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style, System.String secureText) { }
        // RVA: 0x09E07828  token: 0x6000075
        private static System.Void DoTextField(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style, System.String secureText, System.Char maskChar) { }
        // RVA: 0x09E09824  token: 0x6000076
        private static System.Void HandleTextFieldEventForTouchscreen(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style, System.String secureText, System.Char maskChar, UnityEngine.TextEditor editor) { }
        // RVA: 0x09E092BC  token: 0x6000077
        private static System.Void HandleTextFieldEventForDesktop(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style, UnityEngine.TextEditor editor) { }
        // RVA: 0x09E0903C  token: 0x6000078
        private static System.Void HandleTextFieldEventForDesktopWithForcedKeyboard(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, System.Boolean multiline, System.Int32 maxLength, UnityEngine.GUIStyle style, System.String secureText, UnityEngine.TextEditor editor) { }
        // RVA: 0x09E0A90C  token: 0x6000079
        public static System.Boolean Toggle(UnityEngine.Rect position, System.Boolean value, System.String text) { }
        // RVA: 0x09E0A9C4  token: 0x600007A
        public static System.Boolean Toggle(UnityEngine.Rect position, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E07088  token: 0x600007B
        private static System.Boolean DoControl(UnityEngine.Rect position, System.Int32 id, System.Boolean on, System.Boolean hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E072F8  token: 0x600007C
        private static System.Void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E07B7C  token: 0x600007D
        private static System.Boolean DoToggle(UnityEngine.Rect position, System.Int32 id, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E06FC4  token: 0x600007E
        private static System.Boolean DoButton(UnityEngine.Rect position, System.Int32 id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0A6E4  token: 0x600007F
        public static System.Single Slider(UnityEngine.Rect position, System.Single value, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent) { }
        // RVA: 0x09E09BAC  token: 0x6000080
        public static System.Single HorizontalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0A130  token: 0x6000081
        private static System.Boolean ScrollerRepeatButton(System.Int32 scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0AA7C  token: 0x6000082
        public static System.Single VerticalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single topValue, System.Single bottomValue, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0A2E4  token: 0x6000083
        private static System.Single Scroller(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, System.Boolean horiz) { }
        // RVA: 0x09E05DA8  token: 0x6000084
        public static System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E05C18  token: 0x6000085
        private static System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset) { }
        // RVA: 0x09E087DC  token: 0x6000086
        public static System.Void EndGroup() { }
        // RVA: 0x09E06758  token: 0x6000088
        public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect) { }
        // RVA: 0x09E05E30  token: 0x6000089
        private static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background) { }
        // RVA: 0x09E087F4  token: 0x600008A
        public static System.Void EndScrollView() { }
        // RVA: 0x09E08838  token: 0x600008B
        public static System.Void EndScrollView(System.Boolean handleScrollWheel) { }
        // RVA: 0x09E0AC4C  token: 0x600008C
        public static UnityEngine.Rect Window(System.Int32 id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, System.String text) { }
        // RVA: 0x09E07C48  token: 0x600008D
        private static UnityEngine.Rect DoWindow(System.Int32 id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, System.Boolean forceRectOnLayout) { }
        // RVA: 0x09E06DD8  token: 0x600008E
        private static System.Void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, System.Int32 id, System.Int32 instanceID, UnityEngine.GUISkin _skin, System.Int32 forceRect, System.Single width, System.Single height, UnityEngine.GUIStyle style) { }
        // RVA: 0x09E0B0B0  token: 0x600008F
        private static System.Void get_color_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x09E0B4A4  token: 0x6000090
        private static System.Void set_color_Injected(UnityEngine.Color& value) { }
        // RVA: 0x09E0AFAC  token: 0x6000091
        private static System.Void get_backgroundColor_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x09E0B3F0  token: 0x6000092
        private static System.Void set_backgroundColor_Injected(UnityEngine.Color& value) { }
        // RVA: 0x09E0B130  token: 0x6000093
        private static System.Void get_contentColor_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x09E0B524  token: 0x6000094
        private static System.Void set_contentColor_Injected(UnityEngine.Color& value) { }
        // RVA: 0x09E09DA8  token: 0x6000095
        private static System.Void Internal_DoWindow_Injected(System.Int32 id, System.Int32 instanceID, UnityEngine.Rect& clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, System.Object skin, System.Boolean forceRectOnLayout, UnityEngine.Rect& ret) { }
        // RVA: 0x09E07D3C  token: 0x6000096
        private static System.Void DragWindow_Injected(UnityEngine.Rect& position) { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public sealed class GUIClip
    {
        // Properties
        UnityEngine.Rect visibleRect { get; /* RVA: 0x09DFB7B0 */ }

        // Methods
        // RVA: 0x09DFB5E0  token: 0x600009A
        private static System.Void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset) { }
        // RVA: 0x09DFB474  token: 0x600009B
        private static System.Void Internal_Pop() { }
        // RVA: 0x09DFB41C  token: 0x600009C
        private static System.Int32 Internal_GetCount() { }
        // RVA: 0x09DFB740  token: 0x600009D
        private static UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos) { }
        // RVA: 0x09DFB6C0  token: 0x600009E
        private static UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos) { }
        // RVA: 0x09DFB380  token: 0x600009F
        private static UnityEngine.Vector2 ClipToWindow_Vector2(UnityEngine.Vector2 absolutePos) { }
        // RVA: 0x09DFB3F0  token: 0x60000A0
        private static UnityEngine.Matrix4x4 GetMatrix() { }
        // RVA: 0x09DFB66C  token: 0x60000A1
        private static System.Void SetMatrix(UnityEngine.Matrix4x4 m) { }
        // RVA: 0x09DFB4F4  token: 0x60000A2
        private static System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect) { }
        // RVA: 0x09DFB568  token: 0x60000A3
        private static System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect) { }
        // RVA: 0x09DFB448  token: 0x60000A4
        private static System.Void Internal_PopParentClip() { }
        // RVA: 0x09DFB614  token: 0x60000A5
        private static System.Void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset) { }
        // RVA: 0x09DFB60C  token: 0x60000A6
        private static System.Void Pop() { }
        // RVA: 0x09DFB76C  token: 0x60000A7
        public static UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos) { }
        // RVA: 0x09DFB6EC  token: 0x60000A8
        public static UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos) { }
        // RVA: 0x09DFB3AC  token: 0x60000A9
        public static UnityEngine.Vector2 ClipToWindow(UnityEngine.Vector2 absolutePos) { }
        // RVA: 0x09DFB77C  token: 0x60000AA
        private static System.Void get_visibleRect_Injected(UnityEngine.Rect& ret) { }
        // RVA: 0x09DFB57C  token: 0x60000AB
        private static System.Void Internal_Push_Injected(UnityEngine.Rect& screenRect, UnityEngine.Vector2& scrollOffset, UnityEngine.Vector2& renderOffset, System.Boolean resetOffset) { }
        // RVA: 0x09DFB6FC  token: 0x60000AC
        private static System.Void Unclip_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret) { }
        // RVA: 0x09DFB67C  token: 0x60000AD
        private static System.Void UnclipToWindow_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret) { }
        // RVA: 0x09DFB33C  token: 0x60000AE
        private static System.Void ClipToWindow_Vector2_Injected(UnityEngine.Vector2& absolutePos, UnityEngine.Vector2& ret) { }
        // RVA: 0x09DFB3BC  token: 0x60000AF
        private static System.Void GetMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        // RVA: 0x09DFB638  token: 0x60000B0
        private static System.Void SetMatrix_Injected(UnityEngine.Matrix4x4& m) { }
        // RVA: 0x09DFB4A0  token: 0x60000B1
        private static System.Void Internal_PushParentClip_Injected(UnityEngine.Matrix4x4& renderTransform, UnityEngine.Matrix4x4& inputTransform, UnityEngine.Rect& clipRect) { }

    }

    // TypeToken: 0x200000D  // size: 0x28
    public class GUIContent
    {
        // Fields
        private System.String m_Text;  // 0x10
        private UnityEngine.Texture m_Image;  // 0x18
        private System.String m_Tooltip;  // 0x20
        private static readonly UnityEngine.GUIContent s_Text;  // static @ 0x0
        private static readonly UnityEngine.GUIContent s_Image;  // static @ 0x8
        private static readonly UnityEngine.GUIContent s_TextImage;  // static @ 0x10
        public static UnityEngine.GUIContent none;  // static @ 0x18

        // Properties
        System.String text { get; /* RVA: 0x03D66B80 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Texture image { set; /* RVA: 0x022C3A90 */ }
        System.String tooltip { get; /* RVA: 0x03D85A20 */ set; /* RVA: 0x04271930 */ }
        System.Int32 hash { get; /* RVA: 0x09DFBDA0 */ }

        // Methods
        // RVA: 0x09DFBCDC  token: 0x60000B9
        public System.Void .ctor() { }
        // RVA: 0x09DFBD44  token: 0x60000BA
        public System.Void .ctor(System.String text) { }
        // RVA: 0x09DFBC10  token: 0x60000BB
        public System.Void .ctor(System.String text, System.String tooltip) { }
        // RVA: 0x09DFBB58  token: 0x60000BC
        public System.Void .ctor(System.String text, UnityEngine.Texture image, System.String tooltip) { }
        // RVA: 0x09DFBC30  token: 0x60000BD
        public System.Void .ctor(UnityEngine.GUIContent src) { }
        // RVA: 0x09DFB91C  token: 0x60000BF
        private static UnityEngine.GUIContent Temp(System.String t) { }
        // RVA: 0x09DFB7D0  token: 0x60000C0
        private static System.Void ClearStaticCache() { }
        // RVA: 0x09DFB9D0  token: 0x60000C1
        public virtual System.String ToString() { }
        // RVA: 0x09DFB9F4  token: 0x60000C2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct ScaleMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.ScaleMode StretchToFill;  // const
        public static UnityEngine.ScaleMode ScaleAndCrop;  // const
        public static UnityEngine.ScaleMode ScaleToFit;  // const

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct FocusType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.FocusType Native;  // const
        public static UnityEngine.FocusType Keyboard;  // const
        public static UnityEngine.FocusType Passive;  // const

    }

    // TypeToken: 0x2000010  // size: 0x10
    public class GUILayout
    {
        // Methods
        // RVA: 0x09DFFA3C  token: 0x60000C3
        public static System.Void Label(System.String text, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFFAC8  token: 0x60000C4
        public static System.Void Label(System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF34C  token: 0x60000C5
        private static System.Void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFFD0C  token: 0x60000C6
        public static System.Boolean Toggle(System.Boolean value, System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFFD8C  token: 0x60000C7
        public static System.Boolean Toggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF3F4  token: 0x60000C8
        private static System.Boolean DoToggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFFB34  token: 0x60000C9
        public static System.Void Space(System.Single pixels) { }
        // RVA: 0x09DFF7B4  token: 0x60000CA
        public static System.Void FlexibleSpace() { }
        // RVA: 0x09DFEC74  token: 0x60000CB
        public static System.Void BeginHorizontal(UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFECF8  token: 0x60000CC
        public static System.Void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF5C8  token: 0x60000CD
        public static System.Void EndHorizontal() { }
        // RVA: 0x09DFF264  token: 0x60000CE
        public static System.Void BeginVertical(UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF2E8  token: 0x60000CF
        public static System.Void BeginVertical(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF120  token: 0x60000D0
        public static System.Void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF674  token: 0x60000D1
        public static System.Void EndVertical() { }
        // RVA: 0x09DFEA68  token: 0x60000D2
        public static System.Void BeginArea(UnityEngine.Rect screenRect) { }
        // RVA: 0x09DFEAF8  token: 0x60000D3
        public static System.Void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        // RVA: 0x09DFF4B0  token: 0x60000D4
        public static System.Void EndArea() { }
        // RVA: 0x09DFEE3C  token: 0x60000D5
        public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFEEFC  token: 0x60000D6
        public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFF608  token: 0x60000D7
        public static System.Void EndScrollView() { }
        // RVA: 0x09DFF614  token: 0x60000D8
        private static System.Void EndScrollView(System.Boolean handleScrollWheel) { }
        // RVA: 0x09DFFD9C  token: 0x60000D9
        public static UnityEngine.GUILayoutOption Width(System.Single width) { }
        // RVA: 0x09DFF9B0  token: 0x60000DA
        public static UnityEngine.GUILayoutOption Height(System.Single height) { }
        // RVA: 0x09DFF734  token: 0x60000DB
        public static UnityEngine.GUILayoutOption ExpandWidth(System.Boolean expand) { }
        // RVA: 0x09DFF6B4  token: 0x60000DC
        public static UnityEngine.GUILayoutOption ExpandHeight(System.Boolean expand) { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed class GUILayoutOption
    {
        // Fields
        private UnityEngine.GUILayoutOption.Type type;  // 0x10
        private System.Object value;  // 0x18

        // Methods
        // RVA: 0x04270E40  token: 0x60000DD
        private System.Void .ctor(UnityEngine.GUILayoutOption.Type type, System.Object value) { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public class GUILayoutUtility
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows;  // static @ 0x8
        private static UnityEngine.GUILayoutUtility.LayoutCache current;  // static @ 0x10
        private static readonly UnityEngine.Rect kDummyRect;  // static @ 0x18
        private static System.Int32 <unbalancedgroupscount>k__BackingField;  // static @ 0x28
        private static UnityEngine.GUIStyle s_SpaceStyle;  // static @ 0x30

        // Properties
        System.Int32 unbalancedgroupscount { get; /* RVA: 0x09DFE9C4 */ set; /* RVA: 0x09DFEA14 */ }
        UnityEngine.GUIStyle spaceStyle { get; /* RVA: 0x09DFE8D4 */ }

        // Methods
        // RVA: 0x09DFDC6C  token: 0x60000DE
        private static UnityEngine.Rect Internal_GetWindowRect(System.Int32 windowID) { }
        // RVA: 0x09DFDD04  token: 0x60000DF
        private static System.Void Internal_MoveWindow(System.Int32 windowID, UnityEngine.Rect r) { }
        // RVA: 0x09DFE5DC  token: 0x60000E2
        private static UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(System.Int32 instanceID, System.Boolean isWindow) { }
        // RVA: 0x09DFD0D8  token: 0x60000E3
        private static System.Void Begin(System.Int32 instanceID) { }
        // RVA: 0x09DFC7AC  token: 0x60000E4
        private static System.Void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache) { }
        // RVA: 0x09DFCDD8  token: 0x60000E5
        private static System.Void BeginWindow(System.Int32 windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFE3C0  token: 0x60000E6
        private static System.Void Layout() { }
        // RVA: 0x09DFE068  token: 0x60000E7
        private static System.Void LayoutFromEditorWindow() { }
        // RVA: 0x09DFDED0  token: 0x60000E8
        private static System.Void LayoutFromContainer(System.Single w, System.Single h) { }
        // RVA: 0x09DFDD5C  token: 0x60000E9
        private static System.Void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel) { }
        // RVA: 0x09DFE22C  token: 0x60000EA
        private static System.Void LayoutSingleGroup(UnityEngine.GUILayoutGroup i) { }
        // RVA: 0x09DFD314  token: 0x60000EB
        private static UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType) { }
        // RVA: 0x09DFCB64  token: 0x60000EC
        private static UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType) { }
        // RVA: 0x09DFD880  token: 0x60000ED
        private static System.Void EndLayoutGroup() { }
        // RVA: 0x09DFC934  token: 0x60000EE
        private static UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType) { }
        // RVA: 0x09DFDBA4  token: 0x60000EF
        public static UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFD5B4  token: 0x60000F0
        private static UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFDB00  token: 0x60000F1
        public static UnityEngine.Rect GetRect(System.Single width, System.Single height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFD418  token: 0x60000F2
        private static UnityEngine.Rect DoGetRect(System.Single minWidth, System.Single maxWidth, System.Single minHeight, System.Single maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFDA4C  token: 0x60000F3
        public static UnityEngine.Rect GetLastRect() { }
        // RVA: 0x09DFE780  token: 0x60000F5
        private static System.Void .cctor() { }
        // RVA: 0x09DFDC2C  token: 0x60000F6
        private static System.Void Internal_GetWindowRect_Injected(System.Int32 windowID, UnityEngine.Rect& ret) { }
        // RVA: 0x09DFDCC4  token: 0x60000F7
        private static System.Void Internal_MoveWindow_Injected(System.Int32 windowID, UnityEngine.Rect& r) { }

    }

    // TypeToken: 0x2000015  // size: 0x38
    public sealed class GUISettings
    {
        // Fields
        private System.Boolean m_DoubleClickSelectsWord;  // 0x10
        private System.Boolean m_TripleClickSelectsLine;  // 0x11
        private UnityEngine.Color m_CursorColor;  // 0x14
        private System.Single m_CursorFlashSpeed;  // 0x24
        private UnityEngine.Color m_SelectionColor;  // 0x28

        // Properties
        System.Boolean doubleClickSelectsWord { get; /* RVA: 0x03D87CD0 */ }
        System.Boolean tripleClickSelectsLine { get; /* RVA: 0x03D87CF0 */ }
        UnityEngine.Color cursorColor { get; /* RVA: 0x03D60DE0 */ }
        System.Single cursorFlashSpeed { get; /* RVA: 0x09DFFE8C */ }
        UnityEngine.Color selectionColor { get; /* RVA: 0x03D87CE0 */ }

        // Methods
        // RVA: 0x09DFFE28  token: 0x60000FB
        private static System.Single Internal_GetCursorFlashSpeed() { }
        // RVA: 0x09DFFE54  token: 0x6000101
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0xF0
    public sealed class GUISkin : UnityEngine.ScriptableObject
    {
        // Fields
        private UnityEngine.Font m_Font;  // 0x18
        private UnityEngine.GUIStyle m_box;  // 0x20
        private UnityEngine.GUIStyle m_button;  // 0x28
        private UnityEngine.GUIStyle m_toggle;  // 0x30
        private UnityEngine.GUIStyle m_label;  // 0x38
        private UnityEngine.GUIStyle m_textField;  // 0x40
        private UnityEngine.GUIStyle m_textArea;  // 0x48
        private UnityEngine.GUIStyle m_window;  // 0x50
        private UnityEngine.GUIStyle m_horizontalSlider;  // 0x58
        private UnityEngine.GUIStyle m_horizontalSliderThumb;  // 0x60
        private UnityEngine.GUIStyle m_horizontalSliderThumbExtent;  // 0x68
        private UnityEngine.GUIStyle m_verticalSlider;  // 0x70
        private UnityEngine.GUIStyle m_verticalSliderThumb;  // 0x78
        private UnityEngine.GUIStyle m_verticalSliderThumbExtent;  // 0x80
        private UnityEngine.GUIStyle m_SliderMixed;  // 0x88
        private UnityEngine.GUIStyle m_horizontalScrollbar;  // 0x90
        private UnityEngine.GUIStyle m_horizontalScrollbarThumb;  // 0x98
        private UnityEngine.GUIStyle m_horizontalScrollbarLeftButton;  // 0xa0
        private UnityEngine.GUIStyle m_horizontalScrollbarRightButton;  // 0xa8
        private UnityEngine.GUIStyle m_verticalScrollbar;  // 0xb0
        private UnityEngine.GUIStyle m_verticalScrollbarThumb;  // 0xb8
        private UnityEngine.GUIStyle m_verticalScrollbarUpButton;  // 0xc0
        private UnityEngine.GUIStyle m_verticalScrollbarDownButton;  // 0xc8
        private UnityEngine.GUIStyle m_ScrollView;  // 0xd0
        private UnityEngine.GUIStyle[] m_CustomStyles;  // 0xd8
        private UnityEngine.GUISettings m_Settings;  // 0xe0
        private static UnityEngine.GUIStyle ms_Error;  // static @ 0x0
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.GUIStyle> m_Styles;  // 0xe8
        private static UnityEngine.GUISkin.SkinChangedDelegate m_SkinChanged;  // static @ 0x8
        private static UnityEngine.GUISkin current;  // static @ 0x10

        // Properties
        UnityEngine.Font font { get; /* RVA: 0x03D61D00 */ set; /* RVA: 0x09E013E8 */ }
        UnityEngine.GUIStyle box { get; /* RVA: 0x03D85A20 */ set; /* RVA: 0x09E01378 */ }
        UnityEngine.GUIStyle label { get; /* RVA: 0x03D86EB0 */ set; /* RVA: 0x09E015A4 */ }
        UnityEngine.GUIStyle textField { get; /* RVA: 0x03D87CC0 */ set; /* RVA: 0x09E0163C */ }
        UnityEngine.GUIStyle textArea { get; /* RVA: 0x03D87DB0 */ set; /* RVA: 0x09E01618 */ }
        UnityEngine.GUIStyle button { get; /* RVA: 0x03D86CD0 */ set; /* RVA: 0x09E0139C */ }
        UnityEngine.GUIStyle toggle { get; /* RVA: 0x03D86D10 */ set; /* RVA: 0x09E01660 */ }
        UnityEngine.GUIStyle window { get; /* RVA: 0x03D87E30 */ set; /* RVA: 0x09E01794 */ }
        UnityEngine.GUIStyle horizontalSlider { get; /* RVA: 0x03D87D70 */ set; /* RVA: 0x09E01580 */ }
        UnityEngine.GUIStyle horizontalSliderThumb { get; /* RVA: 0x03D87D60 */ set; /* RVA: 0x09E0155C */ }
        UnityEngine.GUIStyle horizontalSliderThumbExtent { get; /* RVA: 0x03D87D50 */ set; /* RVA: 0x09E01538 */ }
        UnityEngine.GUIStyle sliderMixed { get; /* RVA: 0x03D87DA0 */ set; /* RVA: 0x09E015F0 */ }
        UnityEngine.GUIStyle verticalSlider { get; /* RVA: 0x03D87E20 */ set; /* RVA: 0x09E01770 */ }
        UnityEngine.GUIStyle verticalSliderThumb { get; /* RVA: 0x03D87E10 */ set; /* RVA: 0x09E0174C */ }
        UnityEngine.GUIStyle verticalSliderThumbExtent { get; /* RVA: 0x03D87E00 */ set; /* RVA: 0x09E01724 */ }
        UnityEngine.GUIStyle horizontalScrollbar { get; /* RVA: 0x03D87D40 */ set; /* RVA: 0x09E01510 */ }
        UnityEngine.GUIStyle horizontalScrollbarThumb { get; /* RVA: 0x03D87D30 */ set; /* RVA: 0x09E014E8 */ }
        UnityEngine.GUIStyle horizontalScrollbarLeftButton { get; /* RVA: 0x03D87D10 */ set; /* RVA: 0x09E01498 */ }
        UnityEngine.GUIStyle horizontalScrollbarRightButton { get; /* RVA: 0x03D87D20 */ set; /* RVA: 0x09E014C0 */ }
        UnityEngine.GUIStyle verticalScrollbar { get; /* RVA: 0x03D87DF0 */ set; /* RVA: 0x09E016FC */ }
        UnityEngine.GUIStyle verticalScrollbarThumb { get; /* RVA: 0x03D87DD0 */ set; /* RVA: 0x09E016AC */ }
        UnityEngine.GUIStyle verticalScrollbarUpButton { get; /* RVA: 0x03D87DE0 */ set; /* RVA: 0x09E016D4 */ }
        UnityEngine.GUIStyle verticalScrollbarDownButton { get; /* RVA: 0x03D87DC0 */ set; /* RVA: 0x09E01684 */ }
        UnityEngine.GUIStyle scrollView { get; /* RVA: 0x03D87D80 */ set; /* RVA: 0x09E015C8 */ }
        UnityEngine.GUIStyle[] customStyles { get; /* RVA: 0x03D87D00 */ set; /* RVA: 0x09E013C0 */ }
        UnityEngine.GUISettings settings { get; /* RVA: 0x03D87D90 */ }
        UnityEngine.GUIStyle error { get; /* RVA: 0x09E012A4 */ }

        // Methods
        // RVA: 0x09E011EC  token: 0x6000102
        public System.Void .ctor() { }
        // RVA: 0x09E011E4  token: 0x6000103
        private System.Void OnEnable() { }
        // RVA: 0x09E00DE8  token: 0x6000104
        private static System.Void CleanupRoots() { }
        // RVA: 0x09DFFEAC  token: 0x6000139
        private System.Void Apply() { }
        // RVA: 0x09DFFF10  token: 0x600013A
        private System.Void BuildStyleCache() { }
        // RVA: 0x09E00F98  token: 0x600013B
        public UnityEngine.GUIStyle GetStyle(System.String styleName) { }
        // RVA: 0x09E00E5C  token: 0x600013C
        public UnityEngine.GUIStyle FindStyle(System.String styleName) { }
        // RVA: 0x09E01144  token: 0x600013D
        private System.Void MakeCurrent() { }
        // RVA: 0x09E00EE0  token: 0x600013E
        public System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000018  // size: 0x10
    public class GUIStateObjects
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache;  // static @ 0x0

        // Methods
        // RVA: 0x09E017B8  token: 0x6000141
        private static System.Object GetStateObject(System.Type t, System.Int32 controlID) { }
        // RVA: 0x09E018B0  token: 0x6000142
        private static System.Object QueryStateObject(System.Type t, System.Int32 controlID) { }
        // RVA: 0x09E01948  token: 0x6000143
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x20
    public sealed class GUIStyleState
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10
        private readonly UnityEngine.GUIStyle m_SourceStyle;  // 0x18

        // Properties
        UnityEngine.Texture2D background { get; /* RVA: 0x09E01B44 */ set; /* RVA: 0x09E01BE8 */ }
        UnityEngine.Color textColor { get; /* RVA: 0x09E01BBC */ set; /* RVA: 0x09E01C70 */ }

        // Methods
        // RVA: 0x09E01AFC  token: 0x6000148
        private static System.IntPtr Init() { }
        // RVA: 0x09E019D4  token: 0x6000149
        private System.Void Cleanup() { }
        // RVA: 0x09E01B28  token: 0x600014A
        public System.Void .ctor() { }
        // RVA: 0x09DAF220  token: 0x600014B
        private System.Void .ctor(UnityEngine.GUIStyle sourceStyle, System.IntPtr source) { }
        // RVA: 0x09E01A8C  token: 0x600014C
        private static UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, System.IntPtr source) { }
        // RVA: 0x09E01A08  token: 0x600014D
        protected virtual System.Void Finalize() { }
        // RVA: 0x09E01B78  token: 0x600014E
        private System.Void get_textColor_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x09E01C2C  token: 0x600014F
        private System.Void set_textColor_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x200001A  // size: 0x80
    public sealed class GUIStyle
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10
        private UnityEngine.GUIStyleState m_Normal;  // 0x18
        private UnityEngine.GUIStyleState m_Hover;  // 0x20
        private UnityEngine.GUIStyleState m_Active;  // 0x28
        private UnityEngine.GUIStyleState m_Focused;  // 0x30
        private UnityEngine.GUIStyleState m_OnNormal;  // 0x38
        private UnityEngine.GUIStyleState m_OnHover;  // 0x40
        private UnityEngine.GUIStyleState m_OnActive;  // 0x48
        private UnityEngine.GUIStyleState m_OnFocused;  // 0x50
        private UnityEngine.RectOffset m_Border;  // 0x58
        private UnityEngine.RectOffset m_Padding;  // 0x60
        private UnityEngine.RectOffset m_Margin;  // 0x68
        private UnityEngine.RectOffset m_Overflow;  // 0x70
        private System.String m_Name;  // 0x78
        private static System.Boolean showKeyboardFocus;  // static @ 0x0
        private static UnityEngine.GUIStyle s_None;  // static @ 0x8

        // Properties
        System.String rawName { get; /* RVA: 0x09E038A0 */ set; /* RVA: 0x09E03E4C */ }
        UnityEngine.Font font { get; /* RVA: 0x09E03358 */ set; /* RVA: 0x09E03C58 */ }
        UnityEngine.ImagePosition imagePosition { get; /* RVA: 0x09E033D4 */ set; /* RVA: 0x09E03CC0 */ }
        UnityEngine.TextAnchor alignment { get; /* RVA: 0x09E030DC */ set; /* RVA: 0x09E03A28 */ }
        System.Boolean wordWrap { get; /* RVA: 0x09E03970 */ set; /* RVA: 0x09E03F5C */ }
        UnityEngine.TextClipping clipping { get; /* RVA: 0x09E031A4 */ set; /* RVA: 0x09E03A8C */ }
        UnityEngine.Vector2 contentOffset { get; /* RVA: 0x09E0321C */ set; /* RVA: 0x09E03B10 */ }
        System.Single fixedWidth { get; /* RVA: 0x09E03274 */ set; /* RVA: 0x09E03B70 */ }
        System.Single fixedHeight { get; /* RVA: 0x09E03240 */ set; /* RVA: 0x09E03B2C */ }
        System.Boolean stretchWidth { get; /* RVA: 0x09E0393C */ set; /* RVA: 0x09E03F18 */ }
        System.Boolean stretchHeight { get; /* RVA: 0x09E03908 */ set; /* RVA: 0x09E03ED4 */ }
        System.Int32 fontSize { get; /* RVA: 0x09E032F0 */ set; /* RVA: 0x09E03BD8 */ }
        UnityEngine.FontStyle fontStyle { get; /* RVA: 0x09E03324 */ set; /* RVA: 0x09E03C18 */ }
        System.Boolean richText { get; /* RVA: 0x09E038D4 */ set; /* RVA: 0x09E03E90 */ }
        UnityEngine.Vector2 Internal_clipOffset { set; /* RVA: 0x09E039E8 */ }
        System.String name { get; /* RVA: 0x09E03540 */ set; /* RVA: 0x09E03D24 */ }
        UnityEngine.GUIStyleState normal { get; /* RVA: 0x09E03614 */ set; /* RVA: 0x09E03D50 */ }
        UnityEngine.GUIStyleState hover { get; /* RVA: 0x09E0338C */ set; /* RVA: 0x09E03C9C */ }
        UnityEngine.GUIStyleState active { get; /* RVA: 0x09E03094 */ set; /* RVA: 0x09E03A04 */ }
        UnityEngine.GUIStyleState onNormal { get; /* RVA: 0x09E03730 */ set; /* RVA: 0x09E03DE0 */ }
        UnityEngine.GUIStyleState onHover { get; /* RVA: 0x09E036E8 */ set; /* RVA: 0x09E03DBC */ }
        UnityEngine.GUIStyleState onActive { get; /* RVA: 0x09E03658 */ set; /* RVA: 0x09E03D74 */ }
        UnityEngine.GUIStyleState focused { get; /* RVA: 0x09E032A8 */ set; /* RVA: 0x09E03BB4 */ }
        UnityEngine.GUIStyleState onFocused { get; /* RVA: 0x09E036A0 */ set; /* RVA: 0x09E03D98 */ }
        UnityEngine.RectOffset border { get; /* RVA: 0x09E03110 */ set; /* RVA: 0x09E03A68 */ }
        UnityEngine.RectOffset margin { get; /* RVA: 0x09E034AC */ set; /* RVA: 0x09E03D00 */ }
        UnityEngine.RectOffset padding { get; /* RVA: 0x09E0380C */ set; /* RVA: 0x09E03E28 */ }
        UnityEngine.RectOffset overflow { get; /* RVA: 0x09E03778 */ set; /* RVA: 0x09E03E04 */ }
        System.Single lineHeight { get; /* RVA: 0x09E03458 */ }
        UnityEngine.GUIStyle none { get; /* RVA: 0x09E03574 */ }
        System.Boolean isHeightDependantOnWidth { get; /* RVA: 0x09E03408 */ }

        // Methods
        // RVA: 0x09E028F0  token: 0x600016D
        private static System.IntPtr Internal_Create(UnityEngine.GUIStyle self) { }
        // RVA: 0x09E028AC  token: 0x600016E
        private static System.IntPtr Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other) { }
        // RVA: 0x09E02924  token: 0x600016F
        private static System.Void Internal_Destroy(System.IntPtr self) { }
        // RVA: 0x09E02694  token: 0x6000170
        private System.IntPtr GetStyleStatePtr(System.Int32 idx) { }
        // RVA: 0x09E01CD4  token: 0x6000171
        private System.Void AssignStyleState(System.Int32 idx, System.IntPtr srcStyleState) { }
        // RVA: 0x09E02654  token: 0x6000172
        private System.IntPtr GetRectOffsetPtr(System.Int32 idx) { }
        // RVA: 0x09E01C84  token: 0x6000173
        private System.Void AssignRectOffset(System.Int32 idx, System.IntPtr srcRectOffset) { }
        // RVA: 0x09E02D1C  token: 0x6000174
        private static System.Single Internal_GetLineHeight(System.IntPtr target) { }
        // RVA: 0x09E02BA0  token: 0x6000175
        private System.Void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        // RVA: 0x09E029BC  token: 0x6000176
        private System.Void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on) { }
        // RVA: 0x09E02A40  token: 0x6000177
        private System.Void Internal_DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 pos, UnityEngine.Color cursorColor) { }
        // RVA: 0x09E02ACC  token: 0x6000178
        private System.Void Internal_DrawWithTextSelection(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus, System.Boolean drawSelectionAsComposition, System.Int32 cursorFirst, System.Int32 cursorLast, UnityEngine.Color cursorColor, UnityEngine.Color selectionColor) { }
        // RVA: 0x09E02C68  token: 0x6000179
        private UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex) { }
        // RVA: 0x09E02CF8  token: 0x600017A
        private System.Int32 Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition) { }
        // RVA: 0x09E02DB4  token: 0x600017B
        private System.String Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex) { }
        // RVA: 0x09E02888  token: 0x600017C
        private UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content) { }
        // RVA: 0x09E02804  token: 0x600017D
        private UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize) { }
        // RVA: 0x09E026D4  token: 0x600017E
        private System.Single Internal_CalcHeight(UnityEngine.GUIContent content, System.Single width) { }
        // RVA: 0x09E0277C  token: 0x600017F
        private UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content) { }
        // RVA: 0x09E02E80  token: 0x6000180
        private static System.Void SetMouseTooltip(System.String tooltip, UnityEngine.Rect screenRect) { }
        // RVA: 0x09E02DD4  token: 0x6000181
        private static System.Boolean IsTooltipActive(System.String tooltip) { }
        // RVA: 0x09E02BD8  token: 0x6000182
        private static System.Single Internal_GetCursorFlashOffset() { }
        // RVA: 0x09E02E08  token: 0x6000183
        private static System.Void SetDefaultFont(UnityEngine.Font font) { }
        // RVA: 0x09E03044  token: 0x6000184
        public System.Void .ctor() { }
        // RVA: 0x09E02FAC  token: 0x6000185
        public System.Void .ctor(UnityEngine.GUIStyle other) { }
        // RVA: 0x09E02554  token: 0x6000186
        protected virtual System.Void Finalize() { }
        // RVA: 0x09E023E0  token: 0x60001A2
        public System.Void Draw(UnityEngine.Rect position, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        // RVA: 0x09E02398  token: 0x60001A3
        public System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        // RVA: 0x09E02488  token: 0x60001A4
        public System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID) { }
        // RVA: 0x09E022EC  token: 0x60001A5
        public System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on) { }
        // RVA: 0x09E024BC  token: 0x60001A6
        public System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on, System.Boolean hover) { }
        // RVA: 0x09E0232C  token: 0x60001A7
        private System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlId, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        // RVA: 0x09E01D94  token: 0x60001A8
        public System.Void DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Int32 character) { }
        // RVA: 0x09E01F54  token: 0x60001A9
        private System.Void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Boolean isActive, System.Boolean hasKeyboardFocus, System.Int32 firstSelectedCharacter, System.Int32 lastSelectedCharacter, System.Boolean drawSelectionAsComposition, UnityEngine.Color selectionColor) { }
        // RVA: 0x09E021A0  token: 0x60001AA
        private System.Void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Int32 firstSelectedCharacter, System.Int32 lastSelectedCharacter, System.Boolean drawSelectionAsComposition) { }
        // RVA: 0x09E02160  token: 0x60001AB
        public System.Void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Int32 firstSelectedCharacter, System.Int32 lastSelectedCharacter) { }
        // RVA: 0x09E0260C  token: 0x60001AD
        public UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex) { }
        // RVA: 0x09E02630  token: 0x60001AE
        public System.Int32 GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition) { }
        // RVA: 0x09E01D80  token: 0x60001AF
        public UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content) { }
        // RVA: 0x09E01D6C  token: 0x60001B0
        private UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints) { }
        // RVA: 0x09E01D24  token: 0x60001B1
        public System.Single CalcHeight(UnityEngine.GUIContent content, System.Single width) { }
        // RVA: 0x09E01D30  token: 0x60001B3
        public System.Void CalcMinMaxWidth(UnityEngine.GUIContent content, System.Single& minWidth, System.Single& maxWidth) { }
        // RVA: 0x09E02EDC  token: 0x60001B4
        public virtual System.String ToString() { }
        // RVA: 0x09E02F74  token: 0x60001B5
        private static System.Void .cctor() { }
        // RVA: 0x09E031D8  token: 0x60001B6
        private System.Void get_contentOffset_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E03ACC  token: 0x60001B7
        private System.Void set_contentOffset_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E039A4  token: 0x60001B8
        private System.Void set_Internal_clipOffset_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E02B3C  token: 0x60001B9
        private System.Void Internal_Draw_Injected(UnityEngine.Rect& screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        // RVA: 0x09E02958  token: 0x60001BA
        private System.Void Internal_Draw2_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on) { }
        // RVA: 0x09E029DC  token: 0x60001BB
        private System.Void Internal_DrawCursor_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 pos, UnityEngine.Color& cursorColor) { }
        // RVA: 0x09E02A64  token: 0x60001BC
        private System.Void Internal_DrawWithTextSelection_Injected(UnityEngine.Rect& screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus, System.Boolean drawSelectionAsComposition, System.Int32 cursorFirst, System.Int32 cursorLast, UnityEngine.Color& cursorColor, UnityEngine.Color& selectionColor) { }
        // RVA: 0x09E02C04  token: 0x60001BD
        private System.Void Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex, UnityEngine.Vector2& ret) { }
        // RVA: 0x09E02C94  token: 0x60001BE
        private System.Int32 Internal_GetCursorStringIndex_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, UnityEngine.Vector2& cursorPixelPosition) { }
        // RVA: 0x09E02D50  token: 0x60001BF
        private System.String Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect& localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex) { }
        // RVA: 0x09E02834  token: 0x60001C0
        private System.Void Internal_CalcSize_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret) { }
        // RVA: 0x09E027A0  token: 0x60001C1
        private System.Void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& maxSize, UnityEngine.Vector2& ret) { }
        // RVA: 0x09E02728  token: 0x60001C2
        private System.Void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret) { }
        // RVA: 0x09E02E3C  token: 0x60001C3
        private static System.Void SetMouseTooltip_Injected(System.String tooltip, UnityEngine.Rect& screenRect) { }

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct ImagePosition
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.ImagePosition ImageLeft;  // const
        public static UnityEngine.ImagePosition ImageAbove;  // const
        public static UnityEngine.ImagePosition ImageOnly;  // const
        public static UnityEngine.ImagePosition TextOnly;  // const

    }

    // TypeToken: 0x200001C  // size: 0x14
    public sealed struct TextClipping
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TextClipping Overflow;  // const
        public static UnityEngine.TextClipping Clip;  // const

    }

    // TypeToken: 0x200001D  // size: 0x18
    public class GUITargetAttribute : System.Attribute
    {
        // Fields
        private System.Int32 displayMask;  // 0x10

        // Methods
        // RVA: 0x09E03FA0  token: 0x60001C4
        private static System.Int32 GetGUITargetAttrValue(System.Type klass, System.String methodName) { }

    }

    // TypeToken: 0x200001E  // size: 0x10
    public class GUIUtility
    {
        // Fields
        private static System.Int32 s_ControlCount;  // static @ 0x0
        private static System.Int32 s_SkinMode;  // static @ 0x4
        private static System.Int32 s_OriginalID;  // static @ 0x8
        private static System.Action takeCapture;  // static @ 0x10
        private static System.Action releaseCapture;  // static @ 0x18
        private static System.Func<System.Int32,System.IntPtr,System.Boolean> processEvent;  // static @ 0x20
        private static System.Action cleanupRoots;  // static @ 0x28
        private static System.Func<System.Exception,System.Boolean> endContainerGUIFromException;  // static @ 0x30
        private static System.Action guiChanged;  // static @ 0x38
        private static System.Boolean <guiIsExiting>k__BackingField;  // static @ 0x40
        private static System.Func<System.Boolean> s_HasCurrentWindowKeyFocusFunc;  // static @ 0x48

        // Properties
        System.Boolean hasModalWindow { get; /* RVA: 0x09E05884 */ }
        System.Single pixelsPerPoint { get; /* RVA: 0x09E0594C */ }
        System.Int32 guiDepth { get; /* RVA: 0x09E05820 */ }
        UnityEngine.Vector2 s_EditorScreenPointOffset { get; /* RVA: 0x09E059AC */ set; /* RVA: 0x09E05B94 */ }
        System.Boolean mouseUsed { get; /* RVA: 0x09E05920 */ set; /* RVA: 0x09E05B2C */ }
        System.Boolean textFieldInput { get; /* RVA: 0x09E059FC */ set; /* RVA: 0x09E05BE4 */ }
        System.Boolean manualTex2SRGBEnabled { get; /* RVA: 0x09E058F4 */ set; /* RVA: 0x09E05AF8 */ }
        System.String systemCopyBuffer { get; /* RVA: 0x09E059D0 */ set; /* RVA: 0x09E05BB0 */ }
        System.String compositionString { get; /* RVA: 0x09E057F4 */ }
        UnityEngine.IMECompositionMode imeCompositionMode { get; /* RVA: 0x09E058BC */ set; /* RVA: 0x09E05ABC */ }
        UnityEngine.Vector2 compositionCursorPos { get; /* RVA: 0x09E057D0 */ set; /* RVA: 0x09E05A5C */ }
        System.Boolean guiIsExiting { get; /* RVA: 0x09E0584C */ set; /* RVA: 0x09E05A78 */ }
        System.Int32 hotControl { get; /* RVA: 0x09E058B0 */ set; /* RVA: 0x09E05AB4 */ }
        System.Int32 keyboardControl { get; /* RVA: 0x09E058E8 */ set; /* RVA: 0x09E05AF0 */ }

        // Methods
        // RVA: 0x09E04C5C  token: 0x60001D2
        private static System.Int32 Internal_GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect) { }
        // RVA: 0x09E046CC  token: 0x60001D3
        public static System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect) { }
        // RVA: 0x09E041A8  token: 0x60001D4
        private static System.Void BeginContainerFromOwner(UnityEngine.ScriptableObject owner) { }
        // RVA: 0x09E041DC  token: 0x60001D5
        private static System.Void BeginContainer(UnityEngine.ObjectGUIState objectGUIState) { }
        // RVA: 0x09E04B80  token: 0x60001D6
        private static System.Void Internal_EndContainer() { }
        // RVA: 0x09E04878  token: 0x60001D7
        private static System.Int32 GetPermanentControlID() { }
        // RVA: 0x09E042A0  token: 0x60001D8
        private static System.Int32 CheckForTabEvent(UnityEngine.Event evt) { }
        // RVA: 0x09E056F4  token: 0x60001D9
        private static System.Void SetKeyboardControlToFirstControlId() { }
        // RVA: 0x09E05720  token: 0x60001DA
        private static System.Void SetKeyboardControlToLastControlId() { }
        // RVA: 0x09E048FC  token: 0x60001DB
        private static System.Boolean HasFocusableControls() { }
        // RVA: 0x09E04EA4  token: 0x60001DC
        private static System.Boolean OwnsId(System.Int32 id) { }
        // RVA: 0x09E0411C  token: 0x60001DD
        public static UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, System.Int32& widthInPixels, System.Int32& heightInPixels) { }
        // RVA: 0x09E04D50  token: 0x60001E3
        private static UnityEngine.Vector3 Internal_MultiplyPoint(UnityEngine.Vector3 point, UnityEngine.Matrix4x4 transform) { }
        // RVA: 0x09E0465C  token: 0x60001E4
        private static System.Boolean GetChanged() { }
        // RVA: 0x09E0568C  token: 0x60001E5
        private static System.Void SetChanged(System.Boolean changed) { }
        // RVA: 0x09E056C0  token: 0x60001E6
        private static System.Void SetDidGUIWindowsEatLastEvent(System.Boolean value) { }
        // RVA: 0x09E04CA4  token: 0x60001E7
        private static System.Int32 Internal_GetHotControl() { }
        // RVA: 0x09E04CD0  token: 0x60001E8
        private static System.Int32 Internal_GetKeyboardControl() { }
        // RVA: 0x09E04D84  token: 0x60001E9
        private static System.Void Internal_SetHotControl(System.Int32 value) { }
        // RVA: 0x09E04DB8  token: 0x60001EA
        private static System.Void Internal_SetKeyboardControl(System.Int32 value) { }
        // RVA: 0x09E04C70  token: 0x60001EB
        private static System.Object Internal_GetDefaultSkin(System.Int32 skinMode) { }
        // RVA: 0x09E04BD8  token: 0x60001EC
        private static UnityEngine.Object Internal_GetBuiltinSkin(System.Int32 skin) { }
        // RVA: 0x09E04BAC  token: 0x60001ED
        private static System.Void Internal_ExitGUI() { }
        // RVA: 0x09E04B54  token: 0x60001EE
        private static UnityEngine.Vector2 InternalWindowToScreenPoint(UnityEngine.Vector2 windowPoint) { }
        // RVA: 0x09E04AE4  token: 0x60001EF
        private static UnityEngine.Vector2 InternalScreenToWindowPoint(UnityEngine.Vector2 screenPoint) { }
        // RVA: 0x09E04E60  token: 0x60001F0
        private static System.Void MarkGUIChanged() { }
        // RVA: 0x09E04740  token: 0x60001F1
        public static System.Int32 GetControlID(UnityEngine.FocusType focus) { }
        // RVA: 0x09E04750  token: 0x60001F2
        public static System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus) { }
        // RVA: 0x09E04688  token: 0x60001F3
        public static System.Int32 GetControlID(UnityEngine.FocusType focus, UnityEngine.Rect position) { }
        // RVA: 0x09E0477C  token: 0x60001F4
        public static System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus, UnityEngine.Rect position) { }
        // RVA: 0x09E046AC  token: 0x60001F5
        public static System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focus) { }
        // RVA: 0x09E048A4  token: 0x60001F6
        public static System.Object GetStateObject(System.Type t, System.Int32 controlID) { }
        // RVA: 0x09E04F4C  token: 0x60001F7
        public static System.Object QueryStateObject(System.Type t, System.Int32 controlID) { }
        // RVA: 0x09E05758  token: 0x60001FC
        private static System.Void TakeCapture() { }
        // RVA: 0x09E04FA4  token: 0x60001FD
        private static System.Void RemoveCapture() { }
        // RVA: 0x09E04928  token: 0x6000200
        private static System.Boolean HasKeyFocus(System.Int32 controlID) { }
        // RVA: 0x09E04544  token: 0x6000201
        public static System.Void ExitGUI() { }
        // RVA: 0x09E047C4  token: 0x6000202
        private static UnityEngine.GUISkin GetDefaultSkin(System.Int32 skinMode) { }
        // RVA: 0x09E04814  token: 0x6000203
        private static UnityEngine.GUISkin GetDefaultSkin() { }
        // RVA: 0x09E0460C  token: 0x6000204
        private static UnityEngine.GUISkin GetBuiltinSkin(System.Int32 skin) { }
        // RVA: 0x09E04ED8  token: 0x6000205
        private static System.Void ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& result) { }
        // RVA: 0x09E043E0  token: 0x6000206
        private static System.Void EndContainer() { }
        // RVA: 0x09E04340  token: 0x6000207
        private static System.Void CleanupRoots() { }
        // RVA: 0x09E04210  token: 0x6000208
        private static System.Void BeginGUI(System.Int32 skinMode, System.Int32 instanceID, System.Int32 useGUILayout) { }
        // RVA: 0x09E04418  token: 0x6000209
        private static System.Void EndGUI(System.Int32 layoutType) { }
        // RVA: 0x09E043F8  token: 0x600020A
        private static System.Boolean EndGUIFromException(System.Exception exception) { }
        // RVA: 0x09E04384  token: 0x600020B
        private static System.Boolean EndContainerGUIFromException(System.Exception exception) { }
        // RVA: 0x09E04FE8  token: 0x600020C
        private static System.Void ResetGlobalState() { }
        // RVA: 0x09E04DEC  token: 0x600020D
        private static System.Boolean IsExitGUIException(System.Exception exception) { }
        // RVA: 0x09E0574C  token: 0x600020E
        private static System.Boolean ShouldRethrowException(System.Exception exception) { }
        // RVA: 0x09E042D4  token: 0x600020F
        private static System.Void CheckOnGUI() { }
        // RVA: 0x09E0532C  token: 0x6000210
        private static System.Single RoundToPixelGrid(System.Single v) { }
        // RVA: 0x09E04590  token: 0x6000211
        public static UnityEngine.Vector2 GUIToScreenPoint(UnityEngine.Vector2 guiPoint) { }
        // RVA: 0x09E045AC  token: 0x6000212
        public static UnityEngine.Rect GUIToScreenRect(UnityEngine.Rect guiRect) { }
        // RVA: 0x09E05610  token: 0x6000213
        public static UnityEngine.Vector2 ScreenToGUIPoint(UnityEngine.Vector2 screenPoint) { }
        // RVA: 0x09E0562C  token: 0x6000214
        public static UnityEngine.Rect ScreenToGUIRect(UnityEngine.Rect screenRect) { }
        // RVA: 0x09E0504C  token: 0x6000215
        public static System.Void RotateAroundPivot(System.Single angle, UnityEngine.Vector2 pivotPoint) { }
        // RVA: 0x09E0536C  token: 0x6000216
        public static System.Void ScaleAroundPivot(UnityEngine.Vector2 scale, UnityEngine.Vector2 pivotPoint) { }
        // RVA: 0x09E04158  token: 0x6000217
        public static UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect) { }
        // RVA: 0x09E04A04  token: 0x6000218
        public static System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Int32 offset) { }
        // RVA: 0x09E04A7C  token: 0x6000219
        public static System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Boolean isDirectManipulationDevice) { }
        // RVA: 0x09E0499C  token: 0x600021A
        public static System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Event evt) { }
        // RVA: 0x0350B670  token: 0x600021B
        public System.Void .ctor() { }
        // RVA: 0x09E05978  token: 0x600021C
        private static System.Void get_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E05B60  token: 0x600021D
        private static System.Void set_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E04C0C  token: 0x600021E
        private static System.Int32 Internal_GetControlID_Injected(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect& rect) { }
        // RVA: 0x09E040B8  token: 0x600021F
        private static System.Void AlignRectToDevice_Injected(UnityEngine.Rect& rect, System.Int32& widthInPixels, System.Int32& heightInPixels, UnityEngine.Rect& ret) { }
        // RVA: 0x09E0579C  token: 0x6000220
        private static System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E05A28  token: 0x6000221
        private static System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E04CFC  token: 0x6000222
        private static System.Void Internal_MultiplyPoint_Injected(UnityEngine.Vector3& point, UnityEngine.Matrix4x4& transform, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E04B10  token: 0x6000223
        private static System.Void InternalWindowToScreenPoint_Injected(UnityEngine.Vector2& windowPoint, UnityEngine.Vector2& ret) { }
        // RVA: 0x09E04AA0  token: 0x6000224
        private static System.Void InternalScreenToWindowPoint_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200001F  // size: 0x90
    public sealed class ExitGUIException : System.Exception
    {
        // Methods
        // RVA: 0x09DFB294  token: 0x6000225
        public System.Void .ctor() { }
        // RVA: 0x09DFB2E4  token: 0x6000226
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000020  // size: 0x48
    public class GUILayoutEntry
    {
        // Fields
        public System.Single minWidth;  // 0x10
        public System.Single maxWidth;  // 0x14
        public System.Single minHeight;  // 0x18
        public System.Single maxHeight;  // 0x1c
        public UnityEngine.Rect rect;  // 0x20
        public System.Int32 stretchWidth;  // 0x30
        public System.Int32 stretchHeight;  // 0x34
        public System.Boolean consideredForMargin;  // 0x38
        private UnityEngine.GUIStyle m_Style;  // 0x40
        private static UnityEngine.Rect kDummyRect;  // static @ 0x0
        protected static System.Int32 indent;  // static @ 0x10

        // Properties
        UnityEngine.GUIStyle style { get; /* RVA: 0x03D87CC0 */ set; /* RVA: 0x09DFC764 */ }
        System.Int32 marginLeft { get; /* RVA: 0x09DFC69C */ }
        System.Int32 marginRight { get; /* RVA: 0x09DFC6CC */ }
        System.Int32 marginTop { get; /* RVA: 0x09DFC6FC */ }
        System.Int32 marginBottom { get; /* RVA: 0x09DFC634 */ }
        System.Int32 marginHorizontal { get; /* RVA: 0x09DFC664 */ }
        System.Int32 marginVertical { get; /* RVA: 0x09DFC72C */ }

        // Methods
        // RVA: 0x09DFC4A4  token: 0x600022F
        public System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style) { }
        // RVA: 0x09DFC570  token: 0x6000230
        public System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x0350B670  token: 0x6000231
        public virtual System.Void CalcWidth() { }
        // RVA: 0x0350B670  token: 0x6000232
        public virtual System.Void CalcHeight() { }
        // RVA: 0x03D87CA0  token: 0x6000233
        public virtual System.Void SetHorizontal(System.Single x, System.Single width) { }
        // RVA: 0x03D87CB0  token: 0x6000234
        public virtual System.Void SetVertical(System.Single y, System.Single height) { }
        // RVA: 0x09DFBFF4  token: 0x6000235
        protected virtual System.Void ApplyStyleSettings(UnityEngine.GUIStyle style) { }
        // RVA: 0x09DFBDC4  token: 0x6000236
        public virtual System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09DFC090  token: 0x6000237
        public virtual System.String ToString() { }
        // RVA: 0x09DFC450  token: 0x6000238
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000021  // size: 0x58
    public sealed class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        // Fields
        private readonly UnityEngine.GUIContent m_Content;  // 0x48
        private readonly System.Single m_ForcedMinHeight;  // 0x50
        private readonly System.Single m_ForcedMaxHeight;  // 0x54

        // Methods
        // RVA: 0x09E0EA5C  token: 0x6000239
        public System.Void .ctor(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09E0E9B0  token: 0x600023A
        public virtual System.Void CalcWidth() { }
        // RVA: 0x09E0E930  token: 0x600023B
        public virtual System.Void CalcHeight() { }

    }

    // TypeToken: 0x2000022  // size: 0x90
    public class GUILayoutGroup : UnityEngine.GUILayoutEntry
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries;  // 0x48
        public System.Boolean isVertical;  // 0x50
        public System.Boolean resetCoords;  // 0x51
        public System.Single spacing;  // 0x54
        public System.Boolean sameSize;  // 0x58
        public System.Boolean isWindow;  // 0x59
        public System.Int32 windowID;  // 0x5c
        private System.Int32 m_Cursor;  // 0x60
        protected System.Int32 m_StretchableCountX;  // 0x64
        protected System.Int32 m_StretchableCountY;  // 0x68
        protected System.Boolean m_UserSpecifiedWidth;  // 0x6c
        protected System.Boolean m_UserSpecifiedHeight;  // 0x6d
        protected System.Single m_ChildMinWidth;  // 0x70
        protected System.Single m_ChildMaxWidth;  // 0x74
        protected System.Single m_ChildMinHeight;  // 0x78
        protected System.Single m_ChildMaxHeight;  // 0x7c
        protected System.Int32 m_MarginLeft;  // 0x80
        protected System.Int32 m_MarginRight;  // 0x84
        protected System.Int32 m_MarginTop;  // 0x88
        protected System.Int32 m_MarginBottom;  // 0x8c
        private static readonly UnityEngine.GUILayoutEntry none;  // static @ 0x0

        // Properties
        System.Int32 marginLeft { get; /* RVA: 0x03D4EC20 */ }
        System.Int32 marginRight { get; /* RVA: 0x03D4F370 */ }
        System.Int32 marginTop { get; /* RVA: 0x03D4F0B0 */ }
        System.Int32 marginBottom { get; /* RVA: 0x03D4F3D0 */ }

        // Methods
        // RVA: 0x09E0E2E0  token: 0x6000240
        public System.Void .ctor() { }
        // RVA: 0x09E0BBE8  token: 0x6000241
        public virtual System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options) { }
        // RVA: 0x09E0BCB8  token: 0x6000242
        protected virtual System.Void ApplyStyleSettings(UnityEngine.GUIStyle style) { }
        // RVA: 0x03D87E40  token: 0x6000243
        public System.Void ResetCursor() { }
        // RVA: 0x09E0CD28  token: 0x6000244
        public UnityEngine.GUILayoutEntry GetNext() { }
        // RVA: 0x09E0CAA0  token: 0x6000245
        public UnityEngine.Rect GetLast() { }
        // RVA: 0x09E0BB94  token: 0x6000246
        public System.Void Add(UnityEngine.GUILayoutEntry e) { }
        // RVA: 0x09E0C3B4  token: 0x6000247
        public virtual System.Void CalcWidth() { }
        // RVA: 0x09E0CF7C  token: 0x6000248
        public virtual System.Void SetHorizontal(System.Single x, System.Single width) { }
        // RVA: 0x09E0BD38  token: 0x6000249
        public virtual System.Void CalcHeight() { }
        // RVA: 0x09E0D6E4  token: 0x600024A
        public virtual System.Void SetVertical(System.Single y, System.Single height) { }
        // RVA: 0x09E0DEC4  token: 0x600024B
        public virtual System.String ToString() { }
        // RVA: 0x09E0E210  token: 0x600024C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000023  // size: 0xC0
    public sealed class GUIScrollGroup : UnityEngine.GUILayoutGroup
    {
        // Fields
        public System.Single calcMinWidth;  // 0x90
        public System.Single calcMaxWidth;  // 0x94
        public System.Single calcMinHeight;  // 0x98
        public System.Single calcMaxHeight;  // 0x9c
        public System.Single clientWidth;  // 0xa0
        public System.Single clientHeight;  // 0xa4
        public System.Boolean allowHorizontalScroll;  // 0xa8
        public System.Boolean allowVerticalScroll;  // 0xa9
        public System.Boolean needsHorizontalScrollbar;  // 0xaa
        public System.Boolean needsVerticalScrollbar;  // 0xab
        public UnityEngine.GUIStyle horizontalScrollbar;  // 0xb0
        public UnityEngine.GUIStyle verticalScrollbar;  // 0xb8

        // Methods
        // RVA: 0x09E0E8DC  token: 0x600024D
        public System.Void .ctor() { }
        // RVA: 0x09E0E504  token: 0x600024E
        public virtual System.Void CalcWidth() { }
        // RVA: 0x09E0E598  token: 0x600024F
        public virtual System.Void SetHorizontal(System.Single x, System.Single width) { }
        // RVA: 0x09E0E3EC  token: 0x6000250
        public virtual System.Void CalcHeight() { }
        // RVA: 0x09E0E6D0  token: 0x6000251
        public virtual System.Void SetVertical(System.Single y, System.Single height) { }

    }

    // TypeToken: 0x2000024  // size: 0x18
    public class ObjectGUIState : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10

        // Methods
        // RVA: 0x09E0EC7C  token: 0x6000252
        public System.Void .ctor() { }
        // RVA: 0x09E0EB60  token: 0x6000253
        public virtual System.Void Dispose() { }
        // RVA: 0x09E0EBAC  token: 0x6000254
        protected virtual System.Void Finalize() { }
        // RVA: 0x09E0EB34  token: 0x6000255
        private System.Void Destroy() { }
        // RVA: 0x09E0EC1C  token: 0x6000256
        private static System.IntPtr Internal_Create() { }
        // RVA: 0x09E0EC48  token: 0x6000257
        private static System.Void Internal_Destroy(System.IntPtr ptr) { }

    }

    // TypeToken: 0x2000025  // size: 0x68
    public class ScrollViewState
    {
        // Fields
        public UnityEngine.Rect position;  // 0x10
        public UnityEngine.Rect visibleRect;  // 0x20
        public UnityEngine.Rect viewRect;  // 0x30
        public UnityEngine.Vector2 scrollPosition;  // 0x40
        public System.Boolean apply;  // 0x48
        public System.Boolean isDuringTouchScroll;  // 0x49
        public UnityEngine.Vector2 touchScrollStartMousePosition;  // 0x4c
        public UnityEngine.Vector2 touchScrollStartPosition;  // 0x54
        public UnityEngine.Vector2 velocity;  // 0x5c
        public System.Single previousTimeSinceStartup;  // 0x64

        // Methods
        // RVA: 0x0350B670  token: 0x6000258
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class SliderState
    {
        // Fields
        public System.Single dragStartPos;  // 0x10
        public System.Single dragStartValue;  // 0x14
        public System.Boolean isDragging;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000259
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x50
    public sealed struct SliderHandler
    {
        // Fields
        private readonly UnityEngine.Rect position;  // 0x10
        private readonly System.Single currentValue;  // 0x20
        private readonly System.Single size;  // 0x24
        private readonly System.Single start;  // 0x28
        private readonly System.Single end;  // 0x2c
        private readonly UnityEngine.GUIStyle slider;  // 0x30
        private readonly UnityEngine.GUIStyle thumb;  // 0x38
        private readonly UnityEngine.GUIStyle thumbExtent;  // 0x40
        private readonly System.Boolean horiz;  // 0x48
        private readonly System.Int32 id;  // 0x4c

        // Methods
        // RVA: 0x09E0FFF8  token: 0x600025A
        public System.Void .ctor(UnityEngine.Rect position, System.Single currentValue, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent) { }
        // RVA: 0x09E0EDB4  token: 0x600025B
        public System.Single Handle() { }
        // RVA: 0x09E0F098  token: 0x600025C
        private System.Single OnMouseDown() { }
        // RVA: 0x09E0F3EC  token: 0x600025D
        private System.Single OnMouseDrag() { }
        // RVA: 0x09E0F4CC  token: 0x600025E
        private System.Single OnMouseUp() { }
        // RVA: 0x09E0F514  token: 0x600025F
        private System.Single OnRepaint() { }
        // RVA: 0x09E0ECD8  token: 0x6000260
        private UnityEngine.EventType CurrentEventType() { }
        // RVA: 0x09E0ED14  token: 0x6000261
        private System.Int32 CurrentScrollTroughSide() { }
        // RVA: 0x09E0EFF0  token: 0x6000262
        private System.Boolean IsEmptySlider() { }
        // RVA: 0x09E0FA5C  token: 0x6000263
        private System.Boolean SupportsPageMovements() { }
        // RVA: 0x09E0F890  token: 0x6000264
        private System.Single PageMovementValue() { }
        // RVA: 0x09E0F920  token: 0x6000265
        private System.Single PageUpMovementBound() { }
        // RVA: 0x09E0ED08  token: 0x6000266
        private UnityEngine.Event CurrentEvent() { }
        // RVA: 0x09E0FCBC  token: 0x6000267
        private System.Single ValueForCurrentMousePosition() { }
        // RVA: 0x09E0EC98  token: 0x6000268
        private System.Single Clamp(System.Single value) { }
        // RVA: 0x09E0FBD4  token: 0x6000269
        private UnityEngine.Rect ThumbSelectionRect() { }
        // RVA: 0x09E0FA08  token: 0x600026A
        private System.Void StartDraggingWithValue(System.Single dragStartValue) { }
        // RVA: 0x09E0F980  token: 0x600026B
        private UnityEngine.SliderState SliderState() { }
        // RVA: 0x09E0FAB8  token: 0x600026C
        private UnityEngine.Rect ThumbExtRect() { }
        // RVA: 0x09E0FB98  token: 0x600026D
        private UnityEngine.Rect ThumbRect() { }
        // RVA: 0x09E0FE44  token: 0x600026E
        private UnityEngine.Rect VerticalThumbRect() { }
        // RVA: 0x09E0EE3C  token: 0x600026F
        private UnityEngine.Rect HorizontalThumbRect() { }
        // RVA: 0x09E0ECC8  token: 0x6000270
        private System.Single ClampedCurrentValue() { }
        // RVA: 0x09E0F028  token: 0x6000271
        private System.Single MousePosition() { }
        // RVA: 0x09E0FD8C  token: 0x6000272
        private System.Single ValuesPerPixel() { }
        // RVA: 0x09E0FC00  token: 0x6000273
        private System.Single ThumbSize() { }
        // RVA: 0x09E0F004  token: 0x6000274
        private System.Single MaxValue() { }
        // RVA: 0x09E0F018  token: 0x6000275
        private System.Single MinValue() { }

    }

    // TypeToken: 0x2000028  // size: 0x90
    public class TextEditor
    {
        // Fields
        public UnityEngine.TouchScreenKeyboard keyboardOnScreen;  // 0x10
        public System.Int32 controlID;  // 0x18
        public UnityEngine.GUIStyle style;  // 0x20
        public System.Boolean multiline;  // 0x28
        public System.Boolean hasHorizontalCursorPos;  // 0x29
        public System.Boolean isPasswordField;  // 0x2a
        private System.Boolean m_HasFocus;  // 0x2b
        public UnityEngine.Vector2 scrollOffset;  // 0x2c
        private UnityEngine.GUIContent m_Content;  // 0x38
        private UnityEngine.Rect m_Position;  // 0x40
        private System.Int32 m_CursorIndex;  // 0x50
        private System.Int32 m_SelectIndex;  // 0x54
        private System.Boolean m_RevealCursor;  // 0x58
        public UnityEngine.Vector2 graphicalCursorPos;  // 0x5c
        public UnityEngine.Vector2 graphicalSelectCursorPos;  // 0x64
        private System.Boolean m_MouseDragSelectsWholeWords;  // 0x6c
        private System.Int32 m_DblClickInitPos;  // 0x70
        private UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap;  // 0x74
        private System.Boolean m_bJustSelected;  // 0x75
        private System.Int32 m_iAltCursorPos;  // 0x78
        private System.String oldText;  // 0x80
        private System.Int32 oldPos;  // 0x88
        private System.Int32 oldSelectPos;  // 0x8c
        private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditor.TextEditOp> s_Keyactions;  // static @ 0x0

        // Properties
        System.String text { get; /* RVA: 0x0938F248 */ set; /* RVA: 0x09E14180 */ }
        UnityEngine.Rect position { get; /* RVA: 0x03D87E90 */ set; /* RVA: 0x09E140E8 */ }
        UnityEngine.Rect localPosition { get; /* RVA: 0x03D87E80 */ }
        System.Int32 cursorIndex { get; /* RVA: 0x03D85870 */ set; /* RVA: 0x09E140A8 */ }
        System.Int32 selectIndex { get; /* RVA: 0x03D87EA0 */ set; /* RVA: 0x09E14144 */ }
        System.Int32 altCursorPosition { get; /* RVA: 0x03D87E70 */ }
        System.Boolean hasSelection { get; /* RVA: 0x09E1409C */ }
        System.String SelectedText { get; /* RVA: 0x09E14014 */ }

        // Methods
        // RVA: 0x03D87E50  token: 0x600027F
        private System.Void ClearCursorPos() { }
        // RVA: 0x09E13F44  token: 0x6000281
        public System.Void .ctor() { }
        // RVA: 0x09E12A88  token: 0x6000282
        public System.Void OnFocus() { }
        // RVA: 0x09E12AC4  token: 0x6000283
        public System.Void OnLostFocus() { }
        // RVA: 0x09E112DC  token: 0x6000284
        private System.Void GrabGraphicalCursorPos() { }
        // RVA: 0x09E114E0  token: 0x6000285
        public System.Boolean HandleKeyEvent(UnityEngine.Event e) { }
        // RVA: 0x09E113C0  token: 0x6000286
        private System.Boolean HandleKeyEvent(UnityEngine.Event e, System.Boolean textIsReadOnly) { }
        // RVA: 0x09E10318  token: 0x6000287
        public System.Boolean DeleteLineBack() { }
        // RVA: 0x09E105A0  token: 0x6000288
        public System.Boolean DeleteWordBack() { }
        // RVA: 0x09E10654  token: 0x6000289
        public System.Boolean DeleteWordForward() { }
        // RVA: 0x09E10700  token: 0x600028A
        public System.Boolean Delete() { }
        // RVA: 0x09E10134  token: 0x600028B
        public System.Boolean CanPaste() { }
        // RVA: 0x09E10078  token: 0x600028C
        public System.Boolean Backspace() { }
        // RVA: 0x09E131F8  token: 0x600028D
        public System.Void SelectAll() { }
        // RVA: 0x09E134CC  token: 0x600028E
        public System.Void SelectNone() { }
        // RVA: 0x09E1040C  token: 0x6000291
        public System.Boolean DeleteSelection() { }
        // RVA: 0x09E13124  token: 0x6000292
        public System.Void ReplaceSelection(System.String replace) { }
        // RVA: 0x09E11E30  token: 0x6000293
        public System.Void Insert(System.Char c) { }
        // RVA: 0x09E125F8  token: 0x6000294
        public System.Void MoveSelectionToAltCursor() { }
        // RVA: 0x09E12598  token: 0x6000295
        public System.Void MoveRight() { }
        // RVA: 0x09E12318  token: 0x6000296
        public System.Void MoveLeft() { }
        // RVA: 0x09E127F8  token: 0x6000297
        public System.Void MoveUp() { }
        // RVA: 0x09E12180  token: 0x6000298
        public System.Void MoveDown() { }
        // RVA: 0x09E12404  token: 0x6000299
        public System.Void MoveLineStart() { }
        // RVA: 0x09E1236C  token: 0x600029A
        public System.Void MoveLineEnd() { }
        // RVA: 0x09E122CC  token: 0x600029B
        public System.Void MoveGraphicalLineStart() { }
        // RVA: 0x09E12280  token: 0x600029C
        public System.Void MoveGraphicalLineEnd() { }
        // RVA: 0x09E12720  token: 0x600029D
        public System.Void MoveTextStart() { }
        // RVA: 0x09E126D8  token: 0x600029E
        public System.Void MoveTextEnd() { }
        // RVA: 0x09E114F0  token: 0x600029F
        private System.Int32 IndexOfEndOfLine(System.Int32 startIndex) { }
        // RVA: 0x09E12520  token: 0x60002A0
        public System.Void MoveParagraphForward() { }
        // RVA: 0x09E12490  token: 0x60002A1
        public System.Void MoveParagraphBackward() { }
        // RVA: 0x09E12134  token: 0x60002A2
        public System.Void MoveCursorToPosition(UnityEngine.Vector2 cursorPosition) { }
        // RVA: 0x09E12074  token: 0x60002A3
        protected internal System.Void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, System.Boolean shift) { }
        // RVA: 0x09E11FC4  token: 0x60002A4
        public System.Void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition) { }
        // RVA: 0x09E136EC  token: 0x60002A5
        public System.Void SelectToPosition(UnityEngine.Vector2 cursorPosition) { }
        // RVA: 0x09E1346C  token: 0x60002A6
        public System.Void SelectLeft() { }
        // RVA: 0x09E1361C  token: 0x60002A7
        public System.Void SelectRight() { }
        // RVA: 0x09E139C4  token: 0x60002A8
        public System.Void SelectUp() { }
        // RVA: 0x09E13350  token: 0x60002A9
        public System.Void SelectDown() { }
        // RVA: 0x09E1367C  token: 0x60002AA
        public System.Void SelectTextEnd() { }
        // RVA: 0x09E136AC  token: 0x60002AB
        public System.Void SelectTextStart() { }
        // RVA: 0x03D87E60  token: 0x60002AC
        public System.Void MouseDragSelectsWholeWords(System.Boolean on) { }
        // RVA: 0x03D5BFE0  token: 0x60002AD
        public System.Void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping) { }
        // RVA: 0x09E11200  token: 0x60002AE
        private System.Int32 GetGraphicalLineStart(System.Int32 p) { }
        // RVA: 0x09E11110  token: 0x60002AF
        private System.Int32 GetGraphicalLineEnd(System.Int32 p) { }
        // RVA: 0x09E10E74  token: 0x60002B0
        private System.Int32 FindNextSeperator(System.Int32 startPos) { }
        // RVA: 0x09E10EFC  token: 0x60002B1
        private System.Int32 FindPrevSeperator(System.Int32 startPos) { }
        // RVA: 0x09E12918  token: 0x60002B2
        public System.Void MoveWordRight() { }
        // RVA: 0x09E127A0  token: 0x60002B3
        public System.Void MoveToStartOfNextWord() { }
        // RVA: 0x09E12748  token: 0x60002B4
        public System.Void MoveToEndOfPreviousWord() { }
        // RVA: 0x09E13990  token: 0x60002B5
        public System.Void SelectToStartOfNextWord() { }
        // RVA: 0x09E136B8  token: 0x60002B6
        public System.Void SelectToEndOfPreviousWord() { }
        // RVA: 0x09E10198  token: 0x60002B7
        private UnityEngine.TextEditor.CharacterType ClassifyChar(System.Int32 index) { }
        // RVA: 0x09E10F9C  token: 0x60002B8
        public System.Int32 FindStartOfNextWord(System.Int32 p) { }
        // RVA: 0x09E10DC0  token: 0x60002B9
        private System.Int32 FindEndOfPreviousWord(System.Int32 p) { }
        // RVA: 0x09E128C8  token: 0x60002BA
        public System.Void MoveWordLeft() { }
        // RVA: 0x09E13AD8  token: 0x60002BB
        public System.Void SelectWordRight() { }
        // RVA: 0x09E13A54  token: 0x60002BC
        public System.Void SelectWordLeft() { }
        // RVA: 0x09E10C28  token: 0x60002BD
        public System.Void ExpandSelectGraphicalLineStart() { }
        // RVA: 0x09E10BC4  token: 0x60002BE
        public System.Void ExpandSelectGraphicalLineEnd() { }
        // RVA: 0x09E13438  token: 0x60002BF
        public System.Void SelectGraphicalLineStart() { }
        // RVA: 0x09E13404  token: 0x60002C0
        public System.Void SelectGraphicalLineEnd() { }
        // RVA: 0x09E13594  token: 0x60002C1
        public System.Void SelectParagraphForward() { }
        // RVA: 0x09E134F4  token: 0x60002C2
        public System.Void SelectParagraphBackward() { }
        // RVA: 0x09E132C4  token: 0x60002C3
        public System.Void SelectCurrentWord() { }
        // RVA: 0x09E10C8C  token: 0x60002C4
        private System.Int32 FindEndOfClassification(System.Int32 p, UnityEngine.TextEditor.Direction dir) { }
        // RVA: 0x09E1323C  token: 0x60002C5
        public System.Void SelectCurrentParagraph() { }
        // RVA: 0x09E13B5C  token: 0x60002C6
        public System.Void UpdateScrollOffsetIfNeeded(UnityEngine.Event evt) { }
        // RVA: 0x09E13BAC  token: 0x60002C7
        private System.Void UpdateScrollOffset() { }
        // RVA: 0x09E107B8  token: 0x60002C8
        public System.Void DrawCursor(System.String newText) { }
        // RVA: 0x09E12B54  token: 0x60002C9
        private System.Boolean PerformOperation(UnityEngine.TextEditor.TextEditOp operation, System.Boolean textIsReadOnly) { }
        // RVA: 0x09E131BC  token: 0x60002CA
        public System.Void SaveBackup() { }
        // RVA: 0x09E102EC  token: 0x60002CB
        public System.Boolean Cut() { }
        // RVA: 0x09E10270  token: 0x60002CC
        public System.Void Copy() { }
        // RVA: 0x09E13098  token: 0x60002CD
        private static System.String ReplaceNewlinesWithSpaces(System.String value) { }
        // RVA: 0x09E12AD0  token: 0x60002CE
        public System.Boolean Paste() { }
        // RVA: 0x09E11F3C  token: 0x60002CF
        private static System.Void MapKey(System.String key, UnityEngine.TextEditor.TextEditOp action) { }
        // RVA: 0x09E11548  token: 0x60002D0
        private System.Void InitKeyActions() { }
        // RVA: 0x095F944C  token: 0x60002D1
        public System.Void DetectFocusChange() { }
        // RVA: 0x09E12A30  token: 0x60002D2
        private virtual System.Void OnDetectFocusChange() { }
        // RVA: 0x0350B670  token: 0x60002D3
        private virtual System.Void OnCursorIndexChange() { }
        // RVA: 0x0350B670  token: 0x60002D4
        private virtual System.Void OnSelectIndexChange() { }
        // RVA: 0x09E10158  token: 0x60002D5
        private System.Void ClampTextIndex(System.Int32& index) { }
        // RVA: 0x09E10B80  token: 0x60002D6
        private System.Void EnsureValidCodePointIndex(System.Int32& index) { }
        // RVA: 0x09E11E84  token: 0x60002D7
        private System.Boolean IsValidCodePointIndex(System.Int32 index) { }
        // RVA: 0x09E13004  token: 0x60002D8
        private System.Int32 PreviousCodePointIndex(System.Int32 index) { }
        // RVA: 0x09E1297C  token: 0x60002D9
        private System.Int32 NextCodePointIndex(System.Int32 index) { }

    }

}

