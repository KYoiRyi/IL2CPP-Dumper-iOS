// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UI.dll
// Classes:  229
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000006  // size: 0x30
    public class ButtonClickedEvent : UnityEngine.Events.UnityEvent
    {
        // Methods
        // RVA: 0x04271C98  token: 0x6000015
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x30
    public sealed class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public UnityEngine.UI.Button <>4__this;  // 0x20
        private System.Single <fadeTime>5__2;  // 0x28
        private System.Single <elapsedTime>5__3;  // 0x2c

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000016
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000017
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09E66A70  token: 0x6000018
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09E66B64  token: 0x600001A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000012
    public interface IFactoryControls
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600006B
        public virtual UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components) { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public class DefaultRuntimeFactory : IFactoryControls
    {
        // Fields
        public static UnityEngine.UI.DefaultControls.IFactoryControls Default;  // static @ 0x0

        // Methods
        // RVA: 0x09E60A84  token: 0x600006C
        public virtual UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components) { }
        // RVA: 0x0350B670  token: 0x600006D
        public System.Void .ctor() { }
        // RVA: 0x09E60AF4  token: 0x600006E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x48
    public sealed struct Resources
    {
        // Fields
        public UnityEngine.Sprite standard;  // 0x10
        public UnityEngine.Sprite background;  // 0x18
        public UnityEngine.Sprite inputField;  // 0x20
        public UnityEngine.Sprite knob;  // 0x28
        public UnityEngine.Sprite checkmark;  // 0x30
        public UnityEngine.Sprite dropdown;  // 0x38
        public UnityEngine.Sprite mask;  // 0x40

    }

    // TypeToken: 0x2000016  // size: 0x38
    public class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
    {
        // Fields
        private UnityEngine.UI.Text m_Text;  // 0x18
        private UnityEngine.UI.Image m_Image;  // 0x20
        private UnityEngine.RectTransform m_RectTransform;  // 0x28
        private UnityEngine.UI.Toggle m_Toggle;  // 0x30

        // Properties
        UnityEngine.UI.Text text { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.UI.Image image { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.UI.Toggle toggle { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x09E60C0C  token: 0x60000A9
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09E60B94  token: 0x60000AA
        public virtual System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x0426FE60  token: 0x60000AB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x20
    public class OptionData
    {
        // Fields
        private System.String m_Text;  // 0x10
        private UnityEngine.Sprite m_Image;  // 0x18

        // Properties
        System.String text { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Sprite image { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000B0
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x60000B1
        public System.Void .ctor(System.String text) { }
        // RVA: 0x022C3A90  token: 0x60000B2
        public System.Void .ctor(UnityEngine.Sprite image) { }
        // RVA: 0x02676770  token: 0x60000B3
        public System.Void .ctor(System.String text, UnityEngine.Sprite image) { }

    }

    // TypeToken: 0x2000018  // size: 0x18
    public class OptionDataList
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;  // 0x10

        // Properties
        System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x09E66910  token: 0x60000B6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x30
    public class DropdownEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09E60B58  token: 0x60000B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x20
    public sealed class <>c__DisplayClass63_0
    {
        // Fields
        public UnityEngine.UI.Dropdown.DropdownItem item;  // 0x10
        public UnityEngine.UI.Dropdown <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000B8
        public System.Void .ctor() { }
        // RVA: 0x09E66BB0  token: 0x60000B9
        private System.Void <Show>b__0(System.Boolean x) { }

    }

    // TypeToken: 0x200001B  // size: 0x30
    public sealed class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Single delay;  // 0x20
        public UnityEngine.UI.Dropdown <>4__this;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000BA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000BB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09E66988  token: 0x60000BC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09E66A24  token: 0x60000BE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000020  // size: 0x14
    public sealed struct BlockingObjects
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects None;  // const
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects TwoD;  // const
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects ThreeD;  // const
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects All;  // const

    }

    // TypeToken: 0x2000021  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.UI.GraphicRaycaster.<>c <>9;  // static @ 0x0
        public static System.Comparison<UnityEngine.UI.Graphic> <>9__27_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D14B10  token: 0x6000133
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000134
        public System.Void .ctor() { }
        // RVA: 0x02319F00  token: 0x6000135
        private System.Int32 <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2) { }

    }

    // TypeToken: 0x2000025  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.Type Simple;  // const
        public static UnityEngine.UI.Image.Type Sliced;  // const
        public static UnityEngine.UI.Image.Type Tiled;  // const
        public static UnityEngine.UI.Image.Type Filled;  // const
        public static UnityEngine.UI.Image.Type Mirror;  // const
        public static UnityEngine.UI.Image.Type Quarter;  // const

    }

    // TypeToken: 0x2000026  // size: 0x14
    public sealed struct FillMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.FillMethod Horizontal;  // const
        public static UnityEngine.UI.Image.FillMethod Vertical;  // const
        public static UnityEngine.UI.Image.FillMethod Radial90;  // const
        public static UnityEngine.UI.Image.FillMethod Radial180;  // const
        public static UnityEngine.UI.Image.FillMethod Radial360;  // const

    }

    // TypeToken: 0x2000027  // size: 0x14
    public sealed struct OriginHorizontal
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.OriginHorizontal Left;  // const
        public static UnityEngine.UI.Image.OriginHorizontal Right;  // const

    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct OriginVertical
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.OriginVertical Bottom;  // const
        public static UnityEngine.UI.Image.OriginVertical Top;  // const

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct Origin90
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.Origin90 BottomLeft;  // const
        public static UnityEngine.UI.Image.Origin90 TopLeft;  // const
        public static UnityEngine.UI.Image.Origin90 TopRight;  // const
        public static UnityEngine.UI.Image.Origin90 BottomRight;  // const

    }

    // TypeToken: 0x200002A  // size: 0x14
    public sealed struct Origin180
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.Origin180 Bottom;  // const
        public static UnityEngine.UI.Image.Origin180 Left;  // const
        public static UnityEngine.UI.Image.Origin180 Top;  // const
        public static UnityEngine.UI.Image.Origin180 Right;  // const

    }

    // TypeToken: 0x200002B  // size: 0x14
    public sealed struct Origin360
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Image.Origin360 Bottom;  // const
        public static UnityEngine.UI.Image.Origin360 Right;  // const
        public static UnityEngine.UI.Image.Origin360 Top;  // const
        public static UnityEngine.UI.Image.Origin360 Left;  // const

    }

    // TypeToken: 0x200002C  // size: 0x34
    public sealed struct SlicedSpriteParams
    {
        // Fields
        public System.Boolean slicedParamNeedUpdate;  // 0x10
        public UnityEngine.Vector2 inner_PosMin;  // 0x14
        public UnityEngine.Vector2 inner_PosMax;  // 0x1c
        public UnityEngine.Vector2 inner_UVMin;  // 0x24
        public UnityEngine.Vector2 inner_UVMax;  // 0x2c

        // Methods
        // RVA: 0x03D89BB0  token: 0x60001A4
        public System.Void .ctor(System.Boolean slicedParamNeedUpdate, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax) { }

    }

    // TypeToken: 0x200002D  // size: 0x11
    public sealed struct EDynamicAtlasActiveMode
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static UnityEngine.UI.Image.EDynamicAtlasActiveMode ActiveOnAwake;  // const
        public static UnityEngine.UI.Image.EDynamicAtlasActiveMode ActiveOnEnable;  // const

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct ContentType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.InputField.ContentType Standard;  // const
        public static UnityEngine.UI.InputField.ContentType Autocorrected;  // const
        public static UnityEngine.UI.InputField.ContentType IntegerNumber;  // const
        public static UnityEngine.UI.InputField.ContentType DecimalNumber;  // const
        public static UnityEngine.UI.InputField.ContentType Alphanumeric;  // const
        public static UnityEngine.UI.InputField.ContentType Name;  // const
        public static UnityEngine.UI.InputField.ContentType EmailAddress;  // const
        public static UnityEngine.UI.InputField.ContentType Password;  // const
        public static UnityEngine.UI.InputField.ContentType Pin;  // const
        public static UnityEngine.UI.InputField.ContentType Custom;  // const

    }

    // TypeToken: 0x2000032  // size: 0x14
    public sealed struct InputType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.InputField.InputType Standard;  // const
        public static UnityEngine.UI.InputField.InputType AutoCorrect;  // const
        public static UnityEngine.UI.InputField.InputType Password;  // const

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct CharacterValidation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.InputField.CharacterValidation None;  // const
        public static UnityEngine.UI.InputField.CharacterValidation Integer;  // const
        public static UnityEngine.UI.InputField.CharacterValidation Decimal;  // const
        public static UnityEngine.UI.InputField.CharacterValidation Alphanumeric;  // const
        public static UnityEngine.UI.InputField.CharacterValidation Name;  // const
        public static UnityEngine.UI.InputField.CharacterValidation EmailAddress;  // const

    }

    // TypeToken: 0x2000034  // size: 0x14
    public sealed struct LineType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.InputField.LineType SingleLine;  // const
        public static UnityEngine.UI.InputField.LineType MultiLineSubmit;  // const
        public static UnityEngine.UI.InputField.LineType MultiLineNewline;  // const

    }

    // TypeToken: 0x2000035  // size: 0x80
    public sealed class OnValidateInput : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09CFC420  token: 0x600024A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x600024B
        public virtual System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar) { }
        // RVA: 0x09F6E848  token: 0x600024C
        public virtual System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x080658B0  token: 0x600024D
        public virtual System.Char EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000036  // size: 0x30
    public class SubmitEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09F6E8E4  token: 0x600024E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x30
    public class EndEditEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09F65708  token: 0x600024F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000038  // size: 0x30
    public class OnChangeEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09F6E80C  token: 0x6000250
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x14
    public sealed struct EditState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.InputField.EditState Continue;  // const
        public static UnityEngine.UI.InputField.EditState Finish;  // const

    }

    // TypeToken: 0x200003A  // size: 0x28
    public sealed class <CaretBlink>d__169 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public UnityEngine.UI.InputField <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000251
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000252
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09F6E920  token: 0x6000253
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09F6EA40  token: 0x6000255
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003B  // size: 0x30
    public sealed class <MouseDragOutsideRect>d__191 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public UnityEngine.EventSystems.PointerEventData eventData;  // 0x20
        public UnityEngine.UI.InputField <>4__this;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000257
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000258
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09F6EAD8  token: 0x6000259
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09F6ED60  token: 0x600025B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003D  // size: 0x14
    public sealed struct AspectMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.AspectRatioFitter.AspectMode None;  // const
        public static UnityEngine.UI.AspectRatioFitter.AspectMode WidthControlsHeight;  // const
        public static UnityEngine.UI.AspectRatioFitter.AspectMode HeightControlsWidth;  // const
        public static UnityEngine.UI.AspectRatioFitter.AspectMode FitInParent;  // const
        public static UnityEngine.UI.AspectRatioFitter.AspectMode EnvelopeParent;  // const

    }

    // TypeToken: 0x200003F  // size: 0x14
    public sealed struct ScaleMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.CanvasScaler.ScaleMode ConstantPixelSize;  // const
        public static UnityEngine.UI.CanvasScaler.ScaleMode ScaleWithScreenSize;  // const
        public static UnityEngine.UI.CanvasScaler.ScaleMode ConstantPhysicalSize;  // const

    }

    // TypeToken: 0x2000040  // size: 0x14
    public sealed struct ScreenMatchMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode MatchWidthOrHeight;  // const
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode Expand;  // const
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode Shrink;  // const

    }

    // TypeToken: 0x2000041  // size: 0x14
    public sealed struct Unit
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.CanvasScaler.Unit Centimeters;  // const
        public static UnityEngine.UI.CanvasScaler.Unit Millimeters;  // const
        public static UnityEngine.UI.CanvasScaler.Unit Inches;  // const
        public static UnityEngine.UI.CanvasScaler.Unit Points;  // const
        public static UnityEngine.UI.CanvasScaler.Unit Picas;  // const

    }

    // TypeToken: 0x2000043  // size: 0x14
    public sealed struct FitMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.ContentSizeFitter.FitMode Unconstrained;  // const
        public static UnityEngine.UI.ContentSizeFitter.FitMode MinSize;  // const
        public static UnityEngine.UI.ContentSizeFitter.FitMode PreferredSize;  // const

    }

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct Corner
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Corner UpperLeft;  // const
        public static UnityEngine.UI.GridLayoutGroup.Corner UpperRight;  // const
        public static UnityEngine.UI.GridLayoutGroup.Corner LowerLeft;  // const
        public static UnityEngine.UI.GridLayoutGroup.Corner LowerRight;  // const

    }

    // TypeToken: 0x2000046  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Axis Horizontal;  // const
        public static UnityEngine.UI.GridLayoutGroup.Axis Vertical;  // const

    }

    // TypeToken: 0x2000047  // size: 0x14
    public sealed struct Constraint
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Constraint Flexible;  // const
        public static UnityEngine.UI.GridLayoutGroup.Constraint FixedColumnCount;  // const
        public static UnityEngine.UI.GridLayoutGroup.Constraint FixedRowCount;  // const

    }

    // TypeToken: 0x2000051  // size: 0x28
    public sealed class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public UnityEngine.RectTransform rectTransform;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000314
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000315
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x033F8E60  token: 0x6000316
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09F6EA8C  token: 0x6000318
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000053  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.UI.LayoutRebuilder.<>c <>9;  // static @ 0x0
        public static System.Predicate<UnityEngine.Component> <>9__10_0;  // static @ 0x8
        public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;  // static @ 0x10
        public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;  // static @ 0x18
        public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;  // static @ 0x20
        public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;  // static @ 0x28

        // Methods
        // RVA: 0x03D19E50  token: 0x600032E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600032F
        public System.Void .ctor() { }
        // RVA: 0x0365AB80  token: 0x6000330
        private UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0() { }
        // RVA: 0x02337A90  token: 0x6000331
        private System.Void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x) { }
        // RVA: 0x02519810  token: 0x6000332
        private System.Boolean <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e) { }
        // RVA: 0x024A53E0  token: 0x6000333
        private System.Void <Rebuild>b__12_0(UnityEngine.Component e) { }
        // RVA: 0x0259FAC0  token: 0x6000334
        private System.Void <Rebuild>b__12_1(UnityEngine.Component e) { }
        // RVA: 0x02EE1550  token: 0x6000335
        private System.Void <Rebuild>b__12_2(UnityEngine.Component e) { }
        // RVA: 0x0259FA10  token: 0x6000336
        private System.Void <Rebuild>b__12_3(UnityEngine.Component e) { }

    }

    // TypeToken: 0x2000055  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.UI.LayoutUtility.<>c <>9;  // static @ 0x0
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__3_0;  // static @ 0x8
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__4_0;  // static @ 0x10
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__4_1;  // static @ 0x18
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__5_0;  // static @ 0x20
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__6_0;  // static @ 0x28
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__7_0;  // static @ 0x30
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__7_1;  // static @ 0x38
        public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__8_0;  // static @ 0x40

        // Methods
        // RVA: 0x03D1A030  token: 0x6000342
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000343
        public System.Void .ctor() { }
        // RVA: 0x02E88B90  token: 0x6000344
        private System.Single <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x02E88BB0  token: 0x6000345
        private System.Single <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A0AE0  token: 0x6000346
        private System.Single <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A0480  token: 0x6000347
        private System.Single <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A0740  token: 0x6000348
        private System.Single <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A0740  token: 0x6000349
        private System.Single <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A05D0  token: 0x600034A
        private System.Single <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e) { }
        // RVA: 0x025A08A0  token: 0x600034B
        private System.Single <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e) { }

    }

    // TypeToken: 0x2000059  // size: 0x30
    public class CullStateChangedEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x02434120  token: 0x6000373
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Navigation.Mode None;  // const
        public static UnityEngine.UI.Navigation.Mode Horizontal;  // const
        public static UnityEngine.UI.Navigation.Mode Vertical;  // const
        public static UnityEngine.UI.Navigation.Mode Automatic;  // const
        public static UnityEngine.UI.Navigation.Mode Explicit;  // const

    }

    // TypeToken: 0x2000063  // size: 0x14
    public sealed struct Direction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Scrollbar.Direction LeftToRight;  // const
        public static UnityEngine.UI.Scrollbar.Direction RightToLeft;  // const
        public static UnityEngine.UI.Scrollbar.Direction BottomToTop;  // const
        public static UnityEngine.UI.Scrollbar.Direction TopToBottom;  // const

    }

    // TypeToken: 0x2000064  // size: 0x30
    public class ScrollEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x02848F50  token: 0x60003D8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Scrollbar.Axis Horizontal;  // const
        public static UnityEngine.UI.Scrollbar.Axis Vertical;  // const

    }

    // TypeToken: 0x2000066  // size: 0x38
    public sealed class <ClickRepeat>d__58 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public UnityEngine.UI.Scrollbar <>4__this;  // 0x20
        public UnityEngine.Vector2 screenPosition;  // 0x28
        public UnityEngine.Camera camera;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003D9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003DA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09F75CA0  token: 0x60003DB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09F75EC8  token: 0x60003DD
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000068  // size: 0x14
    public sealed struct MovementType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.ScrollRect.MovementType Unrestricted;  // const
        public static UnityEngine.UI.ScrollRect.MovementType Elastic;  // const
        public static UnityEngine.UI.ScrollRect.MovementType Clamped;  // const

    }

    // TypeToken: 0x2000069  // size: 0x14
    public sealed struct ScrollbarVisibility
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility Permanent;  // const
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility AutoHide;  // const
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport;  // const

    }

    // TypeToken: 0x200006A  // size: 0x30
    public class ScrollRectEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x0284A5F0  token: 0x600043C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006C  // size: 0x14
    public sealed struct Transition
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Selectable.Transition None;  // const
        public static UnityEngine.UI.Selectable.Transition ColorTint;  // const
        public static UnityEngine.UI.Selectable.Transition SpriteSwap;  // const
        public static UnityEngine.UI.Selectable.Transition Animation;  // const

    }

    // TypeToken: 0x200006D  // size: 0x14
    public sealed struct SelectionState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Selectable.SelectionState Normal;  // const
        public static UnityEngine.UI.Selectable.SelectionState Highlighted;  // const
        public static UnityEngine.UI.Selectable.SelectionState Pressed;  // const
        public static UnityEngine.UI.Selectable.SelectionState Selected;  // const
        public static UnityEngine.UI.Selectable.SelectionState Disabled;  // const

    }

    // TypeToken: 0x2000074  // size: 0x14
    public sealed struct Direction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Slider.Direction LeftToRight;  // const
        public static UnityEngine.UI.Slider.Direction RightToLeft;  // const
        public static UnityEngine.UI.Slider.Direction BottomToTop;  // const
        public static UnityEngine.UI.Slider.Direction TopToBottom;  // const

    }

    // TypeToken: 0x2000075  // size: 0x30
    public class SliderEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x028484B0  token: 0x60004DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Slider.Axis Horizontal;  // const
        public static UnityEngine.UI.Slider.Axis Vertical;  // const

    }

    // TypeToken: 0x2000079  // size: 0x40
    public class MatEntry
    {
        // Fields
        public UnityEngine.Material baseMat;  // 0x10
        public UnityEngine.Material customMat;  // 0x18
        public System.Int32 count;  // 0x20
        public System.Int32 stencilId;  // 0x24
        public UnityEngine.Rendering.StencilOp operation;  // 0x28
        public UnityEngine.Rendering.CompareFunction compareFunction;  // 0x2c
        public System.Int32 readMask;  // 0x30
        public System.Int32 writeMask;  // 0x34
        public System.Boolean useAlphaClip;  // 0x38
        public UnityEngine.Rendering.ColorWriteMask colorMask;  // 0x3c

        // Methods
        // RVA: 0x03D89BE0  token: 0x60004EE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007C  // size: 0x14
    public sealed struct ToggleTransition
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.Toggle.ToggleTransition None;  // const
        public static UnityEngine.UI.Toggle.ToggleTransition Fade;  // const

    }

    // TypeToken: 0x200007D  // size: 0x30
    public class ToggleEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x02848210  token: 0x6000536
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.UI.ToggleGroup.<>c <>9;  // static @ 0x0
        public static System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;  // static @ 0x8
        public static System.Func<UnityEngine.UI.Toggle,System.Boolean> <>9__14_0;  // static @ 0x10

        // Methods
        // RVA: 0x03D13430  token: 0x6000545
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000546
        public System.Void .ctor() { }
        // RVA: 0x03D4D870  token: 0x6000547
        private System.Boolean <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x) { }
        // RVA: 0x03D07B60  token: 0x6000548
        private System.Boolean <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x) { }

    }

    // TypeToken: 0x2000081  // size: 0x80
    public sealed class Raycast3DCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6F978  token: 0x600054B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6F190  token: 0x600054C
        public virtual System.Boolean Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6F890  token: 0x600054D
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0FC0  token: 0x600054E
        public virtual System.Boolean EndInvoke(UnityEngine.RaycastHit& hit, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000082  // size: 0x80
    public sealed class RaycastAllCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6EFF8  token: 0x600054F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6EFC0  token: 0x6000550
        public virtual UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6FA40  token: 0x6000551
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04276D7C  token: 0x6000552
        public virtual UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000083  // size: 0x80
    public sealed class GetRaycastNonAllocCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6F1D0  token: 0x6000553
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6F190  token: 0x6000554
        public virtual System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6F298  token: 0x6000555
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04279B70  token: 0x6000556
        public virtual System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000084  // size: 0x80
    public sealed class Raycast2DCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6F7C8  token: 0x6000557
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6F76C  token: 0x6000558
        public virtual UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6F6A4  token: 0x6000559
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x06F4E714  token: 0x600055A
        public virtual UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000085  // size: 0x80
    public sealed class GetRayIntersectionAllCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6EFF8  token: 0x600055B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6EFC0  token: 0x600055C
        public virtual UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6EF08  token: 0x600055D
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04276D7C  token: 0x600055E
        public virtual UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000086  // size: 0x80
    public sealed class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F6F1D0  token: 0x600055F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09F6F190  token: 0x6000560
        public virtual System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i) { }
        // RVA: 0x09F6F0C0  token: 0x6000561
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04279B70  token: 0x6000562
        public virtual System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000092  // size: 0x14
    public sealed struct ColorTweenMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode All;  // const
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode RGB;  // const
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode Alpha;  // const

    }

    // TypeToken: 0x2000093  // size: 0x30
    public class ColorTweenCallback : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x024A3F40  token: 0x60005B6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000095  // size: 0x30
    public class FloatTweenCallback : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09F78E54  token: 0x60005C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public sealed class <Start>d__2 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public T tweenInfo;  // 0x0
        private System.Single <elapsedTime>5__2;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60005CA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x60005CB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x60005CC
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60005CE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000099  // size: 0x14
    public sealed struct PointerEventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Default;  // const
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Down;  // const
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Up;  // const

    }

    // TypeToken: 0x200009A  // size: 0x80
    public class PointerEvent : UnityEngine.UIElements.IPointerEvent
    {
        // Fields
        private System.Int32 <pointerId>k__BackingField;  // 0x10
        private System.String <pointerType>k__BackingField;  // 0x18
        private System.Boolean <isPrimary>k__BackingField;  // 0x20
        private System.Int32 <button>k__BackingField;  // 0x24
        private System.Int32 <pressedButtons>k__BackingField;  // 0x28
        private UnityEngine.Vector3 <position>k__BackingField;  // 0x2c
        private UnityEngine.Vector3 <localPosition>k__BackingField;  // 0x38
        private UnityEngine.Vector3 <deltaPosition>k__BackingField;  // 0x44
        private System.Single <deltaTime>k__BackingField;  // 0x50
        private System.Int32 <clickCount>k__BackingField;  // 0x54
        private System.Single <pressure>k__BackingField;  // 0x58
        private System.Single <tangentialPressure>k__BackingField;  // 0x5c
        private System.Single <altitudeAngle>k__BackingField;  // 0x60
        private System.Single <azimuthAngle>k__BackingField;  // 0x64
        private System.Single <twist>k__BackingField;  // 0x68
        private UnityEngine.Vector2 <radius>k__BackingField;  // 0x6c
        private UnityEngine.Vector2 <radiusVariance>k__BackingField;  // 0x74
        private UnityEngine.EventModifiers <modifiers>k__BackingField;  // 0x7c

        // Properties
        System.Int32 pointerId { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.String pointerType { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean isPrimary { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        System.Int32 button { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }
        System.Int32 pressedButtons { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x03D5BF30 */ }
        UnityEngine.Vector3 localPosition { get; /* RVA: 0x03D69690 */ set; /* RVA: 0x03D68D90 */ }
        UnityEngine.Vector3 deltaPosition { get; /* RVA: 0x03D5BDA0 */ set; /* RVA: 0x03D5BDC0 */ }
        System.Single deltaTime { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }
        System.Int32 clickCount { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }
        System.Single pressure { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x03D510B0 */ }
        System.Single tangentialPressure { get; /* RVA: 0x03D56C10 */ set; /* RVA: 0x03D5BDF0 */ }
        System.Single altitudeAngle { get; /* RVA: 0x03D50D50 */ set; /* RVA: 0x03D50D80 */ }
        System.Single azimuthAngle { get; /* RVA: 0x03D50D60 */ set; /* RVA: 0x03D50D70 */ }
        System.Single twist { get; /* RVA: 0x03D56A40 */ set; /* RVA: 0x03D59110 */ }
        UnityEngine.Vector2 radius { get; /* RVA: 0x03D5C200 */ set; /* RVA: 0x03D55B80 */ }
        UnityEngine.Vector2 radiusVariance { get; /* RVA: 0x03D89EB0 */ set; /* RVA: 0x03D89ED0 */ }
        UnityEngine.EventModifiers modifiers { get; /* RVA: 0x03D4EC90 */ set; /* RVA: 0x03D4ED10 */ }
        System.Boolean shiftKey { get; /* RVA: 0x09F7D034 */ }
        System.Boolean ctrlKey { get; /* RVA: 0x09F7D02C */ }
        System.Boolean commandKey { get; /* RVA: 0x09F7D024 */ }
        System.Boolean altKey { get; /* RVA: 0x09F7D01C */ }
        System.Boolean actionKey { get; /* RVA: 0x09F7CFE8 */ }

        // Methods
        // RVA: 0x09F7CAC0  token: 0x600061C
        public System.Void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType) { }
        // RVA: 0x03D89E80  token: 0x600061D
        public System.Void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride) { }
        // RVA: 0x0350B670  token: 0x600061E
        public System.Void .ctor() { }
        // RVA: 0x09F7CFD4  token: 0x600061F
        private static System.Boolean <Read>g__InRange|82_0(System.Int32 i, System.Int32 start, System.Int32 count) { }

    }

    // TypeToken: 0x200009C  // size: 0x14
    public sealed struct FloatIntBits
    {
        // Fields
        public System.Single f;  // 0x10
        public System.Int32 i;  // 0x10

    }

    // TypeToken: 0x20000A1  // size: 0x14
    public sealed struct InputButton
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.PointerEventData.InputButton Left;  // const
        public static UnityEngine.EventSystems.PointerEventData.InputButton Right;  // const
        public static UnityEngine.EventSystems.PointerEventData.InputButton Middle;  // const

    }

    // TypeToken: 0x20000A2  // size: 0x14
    public sealed struct FramePressState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.PointerEventData.FramePressState Pressed;  // const
        public static UnityEngine.EventSystems.PointerEventData.FramePressState Released;  // const
        public static UnityEngine.EventSystems.PointerEventData.FramePressState PressedAndReleased;  // const
        public static UnityEngine.EventSystems.PointerEventData.FramePressState NotChanged;  // const

    }

    // TypeToken: 0x20000B8  // size: 0x10
    public static class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Update;  // static @ 0x0
        public static readonly Unity.Profiling.ProfilerMarker TickModules;  // static @ 0x8
        public static readonly Unity.Profiling.ProfilerMarker CurrentModuleProcess;  // static @ 0x10
        public static readonly Unity.Profiling.ProfilerMarker RaycastAll;  // static @ 0x18
        public static readonly Unity.Profiling.ProfilerMarker RaycastAllSort;  // static @ 0x20

        // Methods
        // RVA: 0x03B1D970  token: 0x60006B2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000B9  // size: 0x20
    public sealed struct UIToolkitOverrideConfig
    {
        // Fields
        public UnityEngine.EventSystems.EventSystem activeEventSystem;  // 0x10
        public System.Boolean sendEvents;  // 0x18
        public System.Boolean createPanelGameObjectsOnStart;  // 0x19

    }

    // TypeToken: 0x20000BA  // size: 0x18
    public sealed class <>c__DisplayClass53_0
    {
        // Fields
        public UnityEngine.GameObject go;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60006B3
        public System.Void .ctor() { }
        // RVA: 0x09F84150  token: 0x60006B4
        private System.Void <CreateUIToolkitPanelGameObject>b__0() { }

    }

    // TypeToken: 0x20000BC  // size: 0x30
    public class TriggerEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x09F84114  token: 0x60006CC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD  // size: 0x20
    public class Entry
    {
        // Fields
        public UnityEngine.EventSystems.EventTriggerType eventID;  // 0x10
        public UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;  // 0x18

        // Methods
        // RVA: 0x09F77B28  token: 0x60006CD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public sealed class EventFunction`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x60006FB
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x60006FC
        public virtual System.Void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: -1  // runtime  token: 0x60006FD
        public virtual System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x60006FE
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000C4  // size: 0x20
    public class ButtonState
    {
        // Fields
        private UnityEngine.EventSystems.PointerEventData.InputButton m_Button;  // 0x10
        private UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;  // 0x18

        // Properties
        UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData eventData { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.EventSystems.PointerEventData.InputButton button { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600073A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5  // size: 0x18
    public class MouseState
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;  // 0x10

        // Methods
        // RVA: 0x09F78F8C  token: 0x600073B
        public System.Boolean AnyPressesThisFrame() { }
        // RVA: 0x09F7902C  token: 0x600073C
        public System.Boolean AnyReleasesThisFrame() { }
        // RVA: 0x09F790CC  token: 0x600073D
        public UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button) { }
        // RVA: 0x09F79204  token: 0x600073E
        public System.Void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data) { }
        // RVA: 0x09F79254  token: 0x600073F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6  // size: 0x20
    public class MouseButtonEventData
    {
        // Fields
        public UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;  // 0x10
        public UnityEngine.EventSystems.PointerEventData buttonData;  // 0x18

        // Methods
        // RVA: 0x093E67CC  token: 0x6000740
        public System.Boolean PressedThisFrame() { }
        // RVA: 0x071262D0  token: 0x6000741
        public System.Boolean ReleasedThisFrame() { }
        // RVA: 0x0350B670  token: 0x6000742
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8  // size: 0x10
    public static class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Process;  // static @ 0x0
        public static readonly Unity.Profiling.ProfilerMarker ProcessMouseEvent;  // static @ 0x8
        public static readonly Unity.Profiling.ProfilerMarker ProcessMousePress;  // static @ 0x10
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchEvents;  // static @ 0x18
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchPress;  // static @ 0x20

        // Methods
        // RVA: 0x09F7EAF4  token: 0x6000767
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C9  // size: 0x14
    public sealed struct InputMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.StandaloneInputModule.InputMode Mouse;  // const
        public static UnityEngine.EventSystems.StandaloneInputModule.InputMode Buttons;  // const

    }

    // TypeToken: 0x20000CB  // size: 0x10
    public static class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Process;  // static @ 0x0
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchEvents;  // static @ 0x8
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchPress;  // static @ 0x10

        // Methods
        // RVA: 0x09F7EA20  token: 0x6000777
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D1  // size: 0x10
    public class RaycastHitComparer : System.Collections.Generic.IComparer`1
    {
        // Fields
        public static UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;  // static @ 0x0

        // Methods
        // RVA: 0x09F7ED3C  token: 0x6000794
        public virtual System.Int32 Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y) { }
        // RVA: 0x0350B670  token: 0x6000795
        public System.Void .ctor() { }
        // RVA: 0x09F7ED68  token: 0x6000796
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000D7  // size: 0x11
    public sealed struct AutoScope : System.IDisposable
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007B8
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1> marker, TP1 p1) { }
        // RVA: -1  // not resolved  token: 0x60007B9
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000D9  // size: 0x11
    public sealed struct AutoScope : System.IDisposable
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007BF
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2> marker, TP1 p1, TP2 p2) { }
        // RVA: -1  // not resolved  token: 0x60007C0
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000DB  // size: 0x11
    public sealed struct AutoScope : System.IDisposable
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007C6
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2,TP3> marker, TP1 p1, TP2 p2, TP3 p3) { }
        // RVA: -1  // not resolved  token: 0x60007C7
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000DD  // size: 0x11
    public sealed struct ProfilerMarkerScope : System.IDisposable
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60007DB
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker) { }
        // RVA: 0x0350B670  token: 0x60007DC
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int32 context) { }
        // RVA: 0x0350B670  token: 0x60007DD
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context) { }
        // RVA: 0x0350B670  token: 0x60007DE
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Single context) { }
        // RVA: 0x0350B670  token: 0x60007DF
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context) { }
        // RVA: 0x0350B670  token: 0x60007E0
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context, System.String context2) { }
        // RVA: 0x0350B670  token: 0x60007E1
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.String context2) { }
        // RVA: 0x0350B670  token: 0x60007E2
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.Int64 context2) { }
        // RVA: 0x0350B670  token: 0x60007E3
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Object obj) { }
        // RVA: 0x0350B670  token: 0x60007E4
        public System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Transform transform, System.Boolean path) { }
        // RVA: 0x0350B670  token: 0x60007E5
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000E5  // size: 0x1C
    public sealed struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x20000E4  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;  // static @ 0x0

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
    public sealed class IsUnmanagedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace Unity.Profiling
{

    // TypeToken: 0x20000D4
    public sealed struct ProfilerCounter`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007A9
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        // RVA: -1  // not resolved  token: 0x60007AA
        public System.Void Sample(T value) { }

    }

    // TypeToken: 0x20000D5  // size: 0x11
    public sealed struct ProfilerCounterValue`1
    {
        // Properties
        T Value { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60007AB
        public System.Void .ctor(System.String name) { }
        // RVA: -1  // not resolved  token: 0x60007AC
        public System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        // RVA: -1  // not resolved  token: 0x60007AD
        public System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions) { }
        // RVA: -1  // not resolved  token: 0x60007AE
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        // RVA: -1  // not resolved  token: 0x60007AF
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions) { }
        // RVA: -1  // not resolved  token: 0x60007B2
        public System.Void Sample() { }

    }

    // TypeToken: 0x20000D6  // size: 0x11
    public sealed struct ProfilerMarker`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007B3
        public System.Void .ctor(System.String name, System.String param1Name) { }
        // RVA: -1  // not resolved  token: 0x60007B4
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name) { }
        // RVA: -1  // not resolved  token: 0x60007B5
        public System.Void Begin(TP1 p1) { }
        // RVA: -1  // not resolved  token: 0x60007B6
        public System.Void End() { }
        // RVA: -1  // not resolved  token: 0x60007B7
        public Unity.Profiling.ProfilerMarker.AutoScope<TP1> Auto(TP1 p1) { }

    }

    // TypeToken: 0x20000D8  // size: 0x11
    public sealed struct ProfilerMarker`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007BA
        public System.Void .ctor(System.String name, System.String param1Name, System.String param2Name) { }
        // RVA: -1  // not resolved  token: 0x60007BB
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name) { }
        // RVA: -1  // not resolved  token: 0x60007BC
        public System.Void Begin(TP1 p1, TP2 p2) { }
        // RVA: -1  // not resolved  token: 0x60007BD
        public System.Void End() { }
        // RVA: -1  // not resolved  token: 0x60007BE
        public Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2> Auto(TP1 p1, TP2 p2) { }

    }

    // TypeToken: 0x20000DA  // size: 0x11
    public sealed struct ProfilerMarker`3
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60007C1
        public System.Void .ctor(System.String name, System.String param1Name, System.String param2Name, System.String param3Name) { }
        // RVA: -1  // not resolved  token: 0x60007C2
        public System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name, System.String param3Name) { }
        // RVA: -1  // not resolved  token: 0x60007C3
        public System.Void Begin(TP1 p1, TP2 p2, TP3 p3) { }
        // RVA: -1  // not resolved  token: 0x60007C4
        public System.Void End() { }
        // RVA: -1  // not resolved  token: 0x60007C5
        public Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2,TP3> Auto(TP1 p1, TP2 p2, TP3 p3) { }

    }

    // TypeToken: 0x20000DC  // size: 0x10
    public static class ProfilerMarkerExtension
    {
        // Methods
        // RVA: 0x09F7E4E0  token: 0x60007C8
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int32 metadata) { }
        // RVA: 0x09F7E9AC  token: 0x60007C9
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt32 metadata) { }
        // RVA: 0x09F7E8BC  token: 0x60007CA
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata) { }
        // RVA: 0x09F7E934  token: 0x60007CB
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt64 metadata) { }
        // RVA: 0x09F7E694  token: 0x60007CC
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Single metadata) { }
        // RVA: 0x09F7E554  token: 0x60007CD
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Double metadata) { }
        // RVA: 0x09F7E48C  token: 0x60007CE
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata) { }
        // RVA: 0x09F7E70C  token: 0x60007CF
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata, System.String metadata2) { }
        // RVA: 0x09F7E7E4  token: 0x60007D0
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.String metadata2) { }
        // RVA: 0x09F7E5CC  token: 0x60007D1
        public static System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.Int64 metadata2) { }
        // RVA: 0x0115F4C0  token: 0x60007D2
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker) { }
        // RVA: 0x03D89EF0  token: 0x60007D3
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int32 context) { }
        // RVA: 0x03D89EF0  token: 0x60007D4
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context) { }
        // RVA: 0x03D89EF0  token: 0x60007D5
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Single context) { }
        // RVA: 0x03D89EF0  token: 0x60007D6
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context) { }
        // RVA: 0x03D89EE0  token: 0x60007D7
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context, System.String context2) { }
        // RVA: 0x03D89EE0  token: 0x60007D8
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.String context2) { }
        // RVA: 0x03D89EE0  token: 0x60007D9
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.Int64 context2) { }
        // RVA: 0x03D89EE0  token: 0x60007DA
        public static Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, UnityEngine.Transform transform, System.Boolean path) { }

    }

    // TypeToken: 0x20000DE  // size: 0x20
    public sealed struct MonoObject_64
    {
        // Fields
        public System.Void* p1;  // 0x10
        public System.Void* p2;  // 0x18

    }

    // TypeToken: 0x20000DF  // size: 0x20
    public sealed struct MonoObject_32
    {
        // Fields
        public System.Void* p1;  // 0x10
        public System.Void* p2;  // 0x14

    }

    // TypeToken: 0x20000E0  // size: 0x28
    public sealed struct MonoString_64
    {
        // Fields
        public Unity.Profiling.MonoObject_64 obj;  // 0x10
        public System.Int32 length;  // 0x20
        public System.Char firstChar;  // 0x24

    }

    // TypeToken: 0x20000E1  // size: 0x20
    public sealed struct MonoString_32
    {
        // Fields
        public Unity.Profiling.MonoObject_32 obj;  // 0x10
        public System.Int32 length;  // 0x18
        public System.Char firstChar;  // 0x1c

    }

    // TypeToken: 0x20000E2  // size: 0x30
    public class ProfilerString : System.IDisposable
    {
        // Fields
        private static System.Int32 MAX;  // const
        private System.String m_buffer;  // 0x10
        private System.Int32 m_length;  // 0x18
        private System.Int32* m_strCount;  // 0x20
        private System.UInt64 m_handler;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60007E6
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x0350B670  token: 0x60007E7
        public virtual System.Void Dispose() { }
        // RVA: 0x020B7B20  token: 0x60007E8
        public virtual System.String ToString() { }
        // RVA: 0x09F7ED1C  token: 0x60007E9
        public static System.String op_Implicit(Unity.Profiling.ProfilerString handle) { }
        // RVA: 0x09F7EC34  token: 0x60007EA
        public System.Void Append(System.String value) { }

    }

    // TypeToken: 0x20000E3  // size: 0x11
    public sealed struct ProfilerUtility
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60007EB
        public static System.Byte GetProfilerMarkerDataType() { }

    }

}

namespace UnityEngine.EventSystems
{

    // TypeToken: 0x200009D  // size: 0x30
    public class AxisEventData : UnityEngine.EventSystems.BaseEventData
    {
        // Fields
        private UnityEngine.Vector2 <moveVector>k__BackingField;  // 0x20
        private UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;  // 0x28

        // Properties
        UnityEngine.Vector2 moveVector { get; /* RVA: 0x03D71660 */ set; /* RVA: 0x03D4ED30 */ }
        UnityEngine.EventSystems.MoveDirection moveDir { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }

        // Methods
        // RVA: 0x09F76CEC  token: 0x6000630
        public System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }

    }

    // TypeToken: 0x200009E  // size: 0x18
    public abstract class AbstractEventData
    {
        // Fields
        protected System.Boolean m_Used;  // 0x10

        // Properties
        System.Boolean used { get; /* RVA: 0x011797F0 */ }

        // Methods
        // RVA: 0x03D557C0  token: 0x6000631
        public virtual System.Void Reset() { }
        // RVA: 0x01168960  token: 0x6000632
        public virtual System.Void Use() { }
        // RVA: 0x0350B670  token: 0x6000634
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200009F  // size: 0x20
    public class BaseEventData : UnityEngine.EventSystems.AbstractEventData
    {
        // Fields
        private readonly UnityEngine.EventSystems.EventSystem m_EventSystem;  // 0x18

        // Properties
        UnityEngine.EventSystems.BaseInputModule currentInputModule { get; /* RVA: 0x05F986E4 */ }
        UnityEngine.GameObject selectedObject { get; /* RVA: 0x05F407B4 */ set; /* RVA: 0x09F76D14 */ }

        // Methods
        // RVA: 0x022C3A90  token: 0x6000635
        public System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }

    }

    // TypeToken: 0x20000A0  // size: 0x160
    public class PointerEventData : UnityEngine.EventSystems.BaseEventData
    {
        // Fields
        private UnityEngine.GameObject <pointerEnter>k__BackingField;  // 0x20
        private UnityEngine.GameObject m_PointerPress;  // 0x28
        private UnityEngine.GameObject <lastPress>k__BackingField;  // 0x30
        private UnityEngine.GameObject <rawPointerPress>k__BackingField;  // 0x38
        private UnityEngine.GameObject <pointerDrag>k__BackingField;  // 0x40
        private UnityEngine.GameObject <pointerClick>k__BackingField;  // 0x48
        private UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField;  // 0x50
        private UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField;  // 0x98
        public System.Collections.Generic.List<UnityEngine.GameObject> hovered;  // 0xe0
        private System.Boolean <eligibleForClick>k__BackingField;  // 0xe8
        private System.Int32 <pointerId>k__BackingField;  // 0xec
        private UnityEngine.Vector2 <position>k__BackingField;  // 0xf0
        private UnityEngine.Vector2 <delta>k__BackingField;  // 0xf8
        private UnityEngine.Vector2 <pressPosition>k__BackingField;  // 0x100
        private UnityEngine.Vector3 <worldPosition>k__BackingField;  // 0x108
        private UnityEngine.Vector3 <worldNormal>k__BackingField;  // 0x114
        private System.Single <clickTime>k__BackingField;  // 0x120
        private System.Int32 <clickCount>k__BackingField;  // 0x124
        private UnityEngine.Vector2 <scrollDelta>k__BackingField;  // 0x128
        private System.Boolean <useDragThreshold>k__BackingField;  // 0x130
        private System.Boolean <dragging>k__BackingField;  // 0x131
        private UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField;  // 0x134
        private System.Single <pressure>k__BackingField;  // 0x138
        private System.Single <tangentialPressure>k__BackingField;  // 0x13c
        private System.Single <altitudeAngle>k__BackingField;  // 0x140
        private System.Single <azimuthAngle>k__BackingField;  // 0x144
        private System.Single <twist>k__BackingField;  // 0x148
        private UnityEngine.Vector2 <radius>k__BackingField;  // 0x14c
        private UnityEngine.Vector2 <radiusVariance>k__BackingField;  // 0x154
        private System.Boolean <fullyExited>k__BackingField;  // 0x15c
        private System.Boolean <reentered>k__BackingField;  // 0x15d

        // Properties
        UnityEngine.GameObject pointerEnter { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        UnityEngine.GameObject lastPress { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        UnityEngine.GameObject rawPointerPress { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        UnityEngine.GameObject pointerDrag { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        UnityEngine.GameObject pointerClick { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        UnityEngine.EventSystems.RaycastResult pointerCurrentRaycast { get; /* RVA: 0x03D89D10 */ set; /* RVA: 0x09F7CA44 */ }
        UnityEngine.EventSystems.RaycastResult pointerPressRaycast { get; /* RVA: 0x03D89D50 */ set; /* RVA: 0x09F7CA7C */ }
        System.Boolean eligibleForClick { get; /* RVA: 0x03D554A0 */ set; /* RVA: 0x03D554D0 */ }
        System.Int32 pointerId { get; /* RVA: 0x03D58150 */ set; /* RVA: 0x03D68F50 */ }
        UnityEngine.Vector2 position { get; /* RVA: 0x03D56D10 */ set; /* RVA: 0x03D51970 */ }
        UnityEngine.Vector2 delta { get; /* RVA: 0x03D89CE0 */ set; /* RVA: 0x03D89E20 */ }
        UnityEngine.Vector2 pressPosition { get; /* RVA: 0x03D89D90 */ set; /* RVA: 0x03D89E40 */ }
        UnityEngine.Vector3 worldPosition { get; /* RVA: 0x03D5C360 */ set; /* RVA: 0x03D5C3A0 */ }
        UnityEngine.Vector3 worldNormal { get; /* RVA: 0x03D5B7A0 */ set; /* RVA: 0x03D5B860 */ }
        System.Single clickTime { get; /* RVA: 0x03D583D0 */ set; /* RVA: 0x03D884B0 */ }
        System.Int32 clickCount { get; /* RVA: 0x03D6DED0 */ set; /* RVA: 0x03D742C0 */ }
        UnityEngine.Vector2 scrollDelta { get; /* RVA: 0x03D89DF0 */ set; /* RVA: 0x03D89E70 */ }
        System.Boolean useDragThreshold { get; /* RVA: 0x03D57B50 */ set; /* RVA: 0x03D5A340 */ }
        System.Boolean dragging { get; /* RVA: 0x03D89D00 */ set; /* RVA: 0x03D89E30 */ }
        UnityEngine.EventSystems.PointerEventData.InputButton button { get; /* RVA: 0x03D4FC40 */ set; /* RVA: 0x03D886C0 */ }
        System.Single pressure { get; /* RVA: 0x03D57590 */ set; /* RVA: 0x03D59AB0 */ }
        System.Single tangentialPressure { get; /* RVA: 0x03D57900 */ set; /* RVA: 0x03D86E50 */ }
        System.Single altitudeAngle { get; /* RVA: 0x03D56EB0 */ set; /* RVA: 0x03D56F30 */ }
        System.Single azimuthAngle { get; /* RVA: 0x03D57D40 */ set; /* RVA: 0x03D89E10 */ }
        System.Single twist { get; /* RVA: 0x03D58220 */ set; /* RVA: 0x03D5B6A0 */ }
        UnityEngine.Vector2 radius { get; /* RVA: 0x03D89DD0 */ set; /* RVA: 0x03D89E60 */ }
        UnityEngine.Vector2 radiusVariance { get; /* RVA: 0x03D89DB0 */ set; /* RVA: 0x03D89E50 */ }
        System.Boolean fullyExited { get; /* RVA: 0x03D5BC90 */ set; /* RVA: 0x03D5BCE0 */ }
        System.Boolean reentered { get; /* RVA: 0x03D5BC60 */ set; /* RVA: 0x03D5BCB0 */ }
        UnityEngine.Camera enterEventCamera { get; /* RVA: 0x09F7C938 */ }
        UnityEngine.Camera pressEventCamera { get; /* RVA: 0x09F7C9BC */ }
        UnityEngine.GameObject pointerPress { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x022C1E00 */ }

        // Methods
        // RVA: 0x022C3990  token: 0x6000673
        public System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        // RVA: 0x022C22A0  token: 0x6000674
        public System.Boolean IsPointerMoving() { }
        // RVA: 0x028C1410  token: 0x6000675
        public System.Boolean IsScrolling() { }
        // RVA: 0x09F7C3B8  token: 0x600067A
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x20000A3  // size: 0x14
    public sealed struct EventHandle
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.EventHandle Unused;  // const
        public static UnityEngine.EventSystems.EventHandle Used;  // const

    }

    // TypeToken: 0x20000A4
    public interface IEventSystemHandler
    {
    }

    // TypeToken: 0x20000A5
    public interface IPointerMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600067B
        public virtual System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A6
    public interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600067C
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A7
    public interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600067D
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A8
    public interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600067E
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A9
    public interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600067F
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AA
    public interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000680
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AB
    public interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000681
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AC
    public interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000682
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AD
    public interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000683
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AE
    public interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000684
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AF
    public interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000685
        public virtual System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000B0
    public interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000686
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000B1
    public interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000687
        public virtual System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B2
    public interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000688
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B3
    public interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000689
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B4
    public interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600068A
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }

    }

    // TypeToken: 0x20000B5
    public interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600068B
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B6
    public interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600068C
        public virtual System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B7  // size: 0x50
    public class EventSystem : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;  // 0x18
        private UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;  // 0x20
        private static System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems;  // static @ 0x0
        private UnityEngine.GameObject m_FirstSelected;  // 0x28
        private System.Boolean m_sendNavigationEvents;  // 0x30
        private System.Int32 m_DragThreshold;  // 0x34
        private UnityEngine.GameObject m_CurrentSelected;  // 0x38
        private System.Boolean m_HasFocus;  // 0x40
        private System.Boolean m_SelectionGuard;  // 0x41
        private UnityEngine.EventSystems.BaseEventData m_DummyData;  // 0x48
        private static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;  // static @ 0x8
        private static UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;  // static @ 0x10

        // Properties
        UnityEngine.EventSystems.EventSystem current { get; /* RVA: 0x022B2A60 */ set; /* RVA: 0x09F782F8 */ }
        System.Boolean sendNavigationEvents { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }
        System.Int32 pixelDragThreshold { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x03D4EE40 */ }
        UnityEngine.EventSystems.BaseInputModule currentInputModule { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.GameObject firstSelectedGameObject { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.GameObject currentSelectedGameObject { get; /* RVA: 0x03D4E2A0 */ }
        UnityEngine.GameObject lastSelectedGameObject { get; /* RVA: 0x01002730 */ }
        System.Boolean isFocused { get; /* RVA: 0x03D4EE90 */ }
        System.Boolean alreadySelecting { get; /* RVA: 0x03D4F7B0 */ }
        UnityEngine.EventSystems.BaseEventData baseEventDataCache { get; /* RVA: 0x09F78284 */ }
        System.Boolean isUIToolkitActiveEventSystem { get; /* RVA: 0x036FEAB0 */ }
        System.Boolean sendUIToolkitEvents { get; /* RVA: 0x036FDE90 */ }
        System.Boolean createUIToolkitPanelGameObjectsOnStart { get; /* RVA: 0x036FE960 */ }

        // Methods
        // RVA: 0x03CE10A0  token: 0x6000699
        protected System.Void .ctor() { }
        // RVA: 0x037A0510  token: 0x600069A
        public System.Void UpdateModules() { }
        // RVA: 0x022C3500  token: 0x600069C
        public System.Void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer) { }
        // RVA: 0x09F77FDC  token: 0x600069E
        public System.Void SetSelectedGameObject(UnityEngine.GameObject selected) { }
        // RVA: 0x0231A230  token: 0x600069F
        private static System.Int32 RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs) { }
        // RVA: 0x023964C0  token: 0x60006A0
        public System.Void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }
        // RVA: 0x09F77E54  token: 0x60006A1
        public System.Boolean IsPointerOverGameObject() { }
        // RVA: 0x09F77DD4  token: 0x60006A2
        public System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        // RVA: 0x09F78010  token: 0x60006A6
        public static System.Void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, System.Boolean sendEvents, System.Boolean createPanelGameObjectsOnStart) { }
        // RVA: 0x09F77B94  token: 0x60006A7
        private System.Void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel) { }
        // RVA: 0x036FDF00  token: 0x60006A8
        protected virtual System.Void Start() { }
        // RVA: 0x09F77E64  token: 0x60006A9
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x036FDDD0  token: 0x60006AA
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F77EF4  token: 0x60006AB
        protected virtual System.Void OnDisable() { }
        // RVA: 0x022B22A0  token: 0x60006AC
        private System.Void TickModules() { }
        // RVA: 0x03134980  token: 0x60006AD
        protected virtual System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        // RVA: 0x022B1F30  token: 0x60006AE
        protected virtual System.Void Update() { }
        // RVA: 0x03C850A0  token: 0x60006AF
        private System.Void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module) { }
        // RVA: 0x09F78154  token: 0x60006B0
        public virtual System.String ToString() { }
        // RVA: 0x03B20B10  token: 0x60006B1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB  // size: 0x20
    public class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;  // 0x18

        // Properties
        System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> delegates { get; /* RVA: 0x09F7864C */ set; /* RVA: 0x022C3A90 */ }
        System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> triggers { get; /* RVA: 0x09F78654 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x0426FE60  token: 0x60006B7
        protected System.Void .ctor() { }
        // RVA: 0x09F78454  token: 0x60006BA
        private System.Void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F785DC  token: 0x60006BB
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F785EC  token: 0x60006BC
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7856C  token: 0x60006BD
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7857C  token: 0x60006BE
        public virtual System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F785CC  token: 0x60006BF
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F785FC  token: 0x60006C0
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F785BC  token: 0x60006C1
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7861C  token: 0x60006C2
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F7855C  token: 0x60006C3
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F7860C  token: 0x60006C4
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F785AC  token: 0x60006C5
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        // RVA: 0x09F7863C  token: 0x60006C6
        public virtual System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F7859C  token: 0x60006C7
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7853C  token: 0x60006C8
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7858C  token: 0x60006C9
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7862C  token: 0x60006CA
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F7854C  token: 0x60006CB
        public virtual System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000BE  // size: 0x14
    public sealed struct EventTriggerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.EventTriggerType PointerEnter;  // const
        public static UnityEngine.EventSystems.EventTriggerType PointerExit;  // const
        public static UnityEngine.EventSystems.EventTriggerType PointerDown;  // const
        public static UnityEngine.EventSystems.EventTriggerType PointerUp;  // const
        public static UnityEngine.EventSystems.EventTriggerType PointerClick;  // const
        public static UnityEngine.EventSystems.EventTriggerType Drag;  // const
        public static UnityEngine.EventSystems.EventTriggerType Drop;  // const
        public static UnityEngine.EventSystems.EventTriggerType Scroll;  // const
        public static UnityEngine.EventSystems.EventTriggerType UpdateSelected;  // const
        public static UnityEngine.EventSystems.EventTriggerType Select;  // const
        public static UnityEngine.EventSystems.EventTriggerType Deselect;  // const
        public static UnityEngine.EventSystems.EventTriggerType Move;  // const
        public static UnityEngine.EventSystems.EventTriggerType InitializePotentialDrag;  // const
        public static UnityEngine.EventSystems.EventTriggerType BeginDrag;  // const
        public static UnityEngine.EventSystems.EventTriggerType EndDrag;  // const
        public static UnityEngine.EventSystems.EventTriggerType Submit;  // const
        public static UnityEngine.EventSystems.EventTriggerType Cancel;  // const

    }

    // TypeToken: 0x20000BF  // size: 0x10
    public static class ExecuteEvents
    {
        // Fields
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler;  // static @ 0x0
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;  // static @ 0x8
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;  // static @ 0x10
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;  // static @ 0x18
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;  // static @ 0x20
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;  // static @ 0x28
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;  // static @ 0x30
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;  // static @ 0x38
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler;  // static @ 0x40
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;  // static @ 0x48
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler;  // static @ 0x50
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;  // static @ 0x58
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;  // static @ 0x60
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;  // static @ 0x68
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;  // static @ 0x70
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;  // static @ 0x78
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;  // static @ 0x80
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;  // static @ 0x88
        private static readonly System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList;  // static @ 0x90

        // Properties
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> pointerMoveHandler { get; /* RVA: 0x09F78C70 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> pointerEnterHandler { get; /* RVA: 0x09F78BD0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> pointerExitHandler { get; /* RVA: 0x09F78C20 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> pointerDownHandler { get; /* RVA: 0x09F78B80 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> pointerUpHandler { get; /* RVA: 0x09F78CC0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> pointerClickHandler { get; /* RVA: 0x09F78B30 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> initializePotentialDrag { get; /* RVA: 0x09F78A90 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> beginDragHandler { get; /* RVA: 0x09F788AC */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> dragHandler { get; /* RVA: 0x09F789A0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> endDragHandler { get; /* RVA: 0x09F78A40 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> dropHandler { get; /* RVA: 0x09F789F0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; /* RVA: 0x09F78D10 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> updateSelectedHandler { get; /* RVA: 0x09F78E04 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> selectHandler { get; /* RVA: 0x09F78D60 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> deselectHandler { get; /* RVA: 0x09F78950 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> moveHandler { get; /* RVA: 0x09F78AE0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> submitHandler { get; /* RVA: 0x09F78DB0 */ }
        UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> cancelHandler { get; /* RVA: 0x09F788FC */ }

        // Methods
        // RVA: -1  // generic def  token: 0x60006CE
        public static T ValidateEventData(UnityEngine.EventSystems.BaseEventData data) { }
        // RVA: 0x09F786F0  token: 0x60006CF
        private static System.Void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x022B4880  token: 0x60006D0
        private static System.Void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x022B4800  token: 0x60006D1
        private static System.Void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x0284C450  token: 0x60006D2
        private static System.Void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x0284C630  token: 0x60006D3
        private static System.Void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x0284C290  token: 0x60006D4
        private static System.Void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03B41430  token: 0x60006D5
        private static System.Void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03976620  token: 0x60006D6
        private static System.Void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x02911820  token: 0x60006D7
        private static System.Void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03126290  token: 0x60006D8
        private static System.Void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F787C4  token: 0x60006D9
        private static System.Void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x028C1330  token: 0x60006DA
        private static System.Void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x02CD92C0  token: 0x60006DB
        private static System.Void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03CDD030  token: 0x60006DC
        private static System.Void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03CBAA70  token: 0x60006DD
        private static System.Void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F78838  token: 0x60006DE
        private static System.Void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F787AC  token: 0x60006DF
        private static System.Void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F786D8  token: 0x60006E0
        private static System.Void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x02704D50  token: 0x60006F3
        private static System.Void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }
        // RVA: -1  // generic def  token: 0x60006F4
        public static System.Boolean Execute(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }
        // RVA: -1  // generic def  token: 0x60006F5
        public static UnityEngine.GameObject ExecuteHierarchy(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }
        // RVA: -1  // generic def  token: 0x60006F6
        private static System.Boolean ShouldSendToComponent(UnityEngine.Component component) { }
        // RVA: -1  // generic def  token: 0x60006F7
        private static System.Void GetEventList(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }
        // RVA: -1  // generic def  token: 0x60006F8
        public static System.Boolean CanHandleEvent(UnityEngine.GameObject go) { }
        // RVA: -1  // generic def  token: 0x60006F9
        public static UnityEngine.GameObject GetEventHandler(UnityEngine.GameObject root) { }
        // RVA: 0x02E20360  token: 0x60006FA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000C1  // size: 0x18
    public class BaseInput : UnityEngine.EventSystems.UIBehaviour
    {
        // Properties
        System.String compositionString { get; /* RVA: 0x036E6FE0 */ }
        UnityEngine.IMECompositionMode imeCompositionMode { get; /* RVA: 0x09F77644 */ set; /* RVA: 0x042768C0 */ }
        UnityEngine.Vector2 compositionCursorPos { get; /* RVA: 0x09F7763C */ set; /* RVA: 0x0427312C */ }
        System.Boolean mousePresent { get; /* RVA: 0x09E75CCC */ }
        UnityEngine.Vector2 mousePosition { get; /* RVA: 0x09F7764C */ }
        UnityEngine.Vector2 mouseScrollDelta { get; /* RVA: 0x09F77674 */ }
        System.Boolean touchSupported { get; /* RVA: 0x09F7767C */ }
        System.Int32 touchCount { get; /* RVA: 0x089CEE70 */ }

        // Methods
        // RVA: 0x09F77618  token: 0x6000705
        public virtual System.Boolean GetMouseButtonDown(System.Int32 button) { }
        // RVA: 0x09F77624  token: 0x6000706
        public virtual System.Boolean GetMouseButtonUp(System.Int32 button) { }
        // RVA: 0x09F77630  token: 0x6000707
        public virtual System.Boolean GetMouseButton(System.Int32 button) { }
        // RVA: 0x0943BB00  token: 0x600070C
        public virtual UnityEngine.Touch GetTouch(System.Int32 index) { }
        // RVA: 0x09F7760C  token: 0x600070D
        public virtual System.Single GetAxisRaw(System.String axisName) { }
        // RVA: 0x09E75CC0  token: 0x600070E
        public virtual System.Boolean GetButtonDown(System.String buttonName) { }
        // RVA: 0x0426FE60  token: 0x600070F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2  // size: 0x48
    public abstract class BaseInputModule : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        protected System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;  // 0x18
        private UnityEngine.EventSystems.AxisEventData m_AxisEventData;  // 0x20
        private UnityEngine.EventSystems.EventSystem m_EventSystem;  // 0x28
        private UnityEngine.EventSystems.BaseEventData m_BaseEventData;  // 0x30
        protected UnityEngine.EventSystems.BaseInput m_InputOverride;  // 0x38
        private UnityEngine.EventSystems.BaseInput m_DefaultInput;  // 0x40

        // Properties
        UnityEngine.EventSystems.BaseInput input { get; /* RVA: 0x022B4110 */ }
        UnityEngine.EventSystems.BaseInput inputOverride { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        UnityEngine.EventSystems.EventSystem eventSystem { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x037A0440  token: 0x6000714
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F775EC  token: 0x6000715
        protected virtual System.Void OnDisable() { }
        // RVA: -1  // abstract  token: 0x6000716
        public virtual System.Void Process() { }
        // RVA: 0x022C2F90  token: 0x6000717
        protected static UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }
        // RVA: 0x09F76E28  token: 0x6000718
        protected static UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y) { }
        // RVA: 0x09F76DB8  token: 0x6000719
        protected static UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone) { }
        // RVA: 0x030FB710  token: 0x600071A
        protected static UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2) { }
        // RVA: 0x09F76F20  token: 0x600071B
        protected System.Void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget) { }
        // RVA: 0x09F76E38  token: 0x600071C
        protected virtual UnityEngine.EventSystems.AxisEventData GetAxisEventData(System.Single x, System.Single y, System.Single moveDeadZone) { }
        // RVA: 0x022C3900  token: 0x600071D
        protected virtual UnityEngine.EventSystems.BaseEventData GetBaseEventData() { }
        // RVA: 0x0115F4C0  token: 0x600071E
        public virtual System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        // RVA: 0x030DD5E0  token: 0x600071F
        public virtual System.Boolean ShouldActivateModule() { }
        // RVA: 0x0350B670  token: 0x6000720
        public virtual System.Void DeactivateModule() { }
        // RVA: 0x0350B670  token: 0x6000721
        public virtual System.Void ActivateModule() { }
        // RVA: 0x0350B670  token: 0x6000722
        public virtual System.Void UpdateModule() { }
        // RVA: 0x0232EB60  token: 0x6000723
        public virtual System.Boolean IsModuleSupported() { }
        // RVA: 0x09F76D3C  token: 0x6000724
        public virtual System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData) { }
        // RVA: 0x0284AC10  token: 0x6000725
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3  // size: 0x58
    public abstract class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
    {
        // Fields
        public static System.Int32 kMouseLeftId;  // const
        public static System.Int32 kMouseRightId;  // const
        public static System.Int32 kMouseMiddleId;  // const
        public static System.Int32 kFakeTouchesId;  // const
        protected System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData> m_PointerData;  // 0x48
        private readonly UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;  // 0x50

        // Methods
        // RVA: 0x09F7D854  token: 0x6000726
        protected System.Boolean GetPointerData(System.Int32 id, UnityEngine.EventSystems.PointerEventData& data, System.Boolean create) { }
        // RVA: 0x09F7DF70  token: 0x6000727
        protected System.Void RemovePointerData(UnityEngine.EventSystems.PointerEventData data) { }
        // RVA: 0x09F7D948  token: 0x6000728
        protected UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released) { }
        // RVA: 0x09F7D1EC  token: 0x6000729
        protected System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to) { }
        // RVA: 0x09F7DFCC  token: 0x600072A
        protected UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 buttonId) { }
        // RVA: 0x09F7D460  token: 0x600072B
        protected virtual UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData() { }
        // RVA: 0x09F7D46C  token: 0x600072C
        protected virtual UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(System.Int32 id) { }
        // RVA: 0x09F7D438  token: 0x600072D
        protected UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(System.Int32 id) { }
        // RVA: 0x093E9C98  token: 0x600072E
        private static System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold) { }
        // RVA: 0x09F7DF24  token: 0x600072F
        protected virtual System.Void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent) { }
        // RVA: 0x09F7DD04  token: 0x6000730
        protected virtual System.Void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent) { }
        // RVA: 0x09F7DC9C  token: 0x6000731
        public virtual System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        // RVA: 0x09F7D03C  token: 0x6000732
        protected System.Void ClearSelection() { }
        // RVA: 0x09F7E044  token: 0x6000733
        public virtual System.String ToString() { }
        // RVA: 0x09F7D36C  token: 0x6000734
        protected System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        // RVA: 0x09F7E2D8  token: 0x6000735
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7  // size: 0xB8
    public class StandaloneInputModule : UnityEngine.EventSystems.PointerInputModule
    {
        // Fields
        private System.Single m_PrevActionTime;  // 0x58
        private UnityEngine.Vector2 m_LastMoveVector;  // 0x5c
        private System.Int32 m_ConsecutiveMoveCount;  // 0x64
        private UnityEngine.Vector2 m_LastMousePosition;  // 0x68
        private UnityEngine.Vector2 m_MousePosition;  // 0x70
        private UnityEngine.GameObject m_CurrentFocusedGameObject;  // 0x78
        private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;  // 0x80
        private System.String m_HorizontalAxis;  // 0x88
        private System.String m_VerticalAxis;  // 0x90
        private System.String m_SubmitButton;  // 0x98
        private System.String m_CancelButton;  // 0xa0
        private System.Single m_InputActionsPerSecond;  // 0xa8
        private System.Single m_RepeatDelay;  // 0xac
        private System.Boolean m_ForceModuleActive;  // 0xb0

        // Properties
        UnityEngine.EventSystems.StandaloneInputModule.InputMode inputMode { get; /* RVA: 0x01002730 */ }
        System.Boolean allowActivationOnMobileDevice { get; /* RVA: 0x01151530 */ set; /* RVA: 0x01151540 */ }
        System.Boolean forceModuleActive { get; /* RVA: 0x01151530 */ set; /* RVA: 0x01151540 */ }
        System.Single inputActionsPerSecond { get; /* RVA: 0x03D58510 */ set; /* RVA: 0x03D6DF40 */ }
        System.Single repeatDelay { get; /* RVA: 0x03D58380 */ set; /* RVA: 0x03D6DF50 */ }
        System.String horizontalAxis { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }
        System.String verticalAxis { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }
        System.String submitButton { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }
        System.String cancelButton { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x04270264 */ }

        // Methods
        // RVA: 0x09F8239C  token: 0x6000743
        protected System.Void .ctor() { }
        // RVA: 0x0232EB60  token: 0x6000755
        private System.Boolean ShouldIgnoreEventsOnNoFocus() { }
        // RVA: 0x09F82288  token: 0x6000756
        public virtual System.Void UpdateModule() { }
        // RVA: 0x09F81A98  token: 0x6000757
        private System.Void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo) { }
        // RVA: 0x09F820F0  token: 0x6000758
        public virtual System.Boolean ShouldActivateModule() { }
        // RVA: 0x09F7F8D4  token: 0x6000759
        public virtual System.Void ActivateModule() { }
        // RVA: 0x09F7F9FC  token: 0x600075A
        public virtual System.Void DeactivateModule() { }
        // RVA: 0x09F81940  token: 0x600075B
        public virtual System.Void Process() { }
        // RVA: 0x09F802EC  token: 0x600075C
        private System.Boolean ProcessTouchEvents() { }
        // RVA: 0x09F80528  token: 0x600075D
        protected System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        // RVA: 0x09F81EB8  token: 0x600075E
        protected System.Boolean SendSubmitEventToSelectedObject() { }
        // RVA: 0x09F7FA04  token: 0x600075F
        private UnityEngine.Vector2 GetRawMoveVector() { }
        // RVA: 0x09F81D14  token: 0x6000760
        protected System.Boolean SendMoveEventToSelectedObject() { }
        // RVA: 0x09F7FD38  token: 0x6000761
        protected System.Void ProcessMouseEvent() { }
        // RVA: 0x0115F4C0  token: 0x6000762
        protected virtual System.Boolean ForceAutoSelect() { }
        // RVA: 0x09F7FB08  token: 0x6000763
        protected System.Void ProcessMouseEvent(System.Int32 id) { }
        // RVA: 0x09F8201C  token: 0x6000764
        protected System.Boolean SendUpdateEventToSelectedObject() { }
        // RVA: 0x09F7FE00  token: 0x6000765
        protected System.Void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data) { }
        // RVA: 0x03D4EB20  token: 0x6000766
        protected UnityEngine.GameObject GetCurrentFocusedGameObject() { }

    }

    // TypeToken: 0x20000CA  // size: 0x78
    public class TouchInputModule : UnityEngine.EventSystems.PointerInputModule
    {
        // Fields
        private UnityEngine.Vector2 m_LastMousePosition;  // 0x58
        private UnityEngine.Vector2 m_MousePosition;  // 0x60
        private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;  // 0x68
        private System.Boolean m_ForceModuleActive;  // 0x70

        // Properties
        System.Boolean allowActivationOnStandalone { get; /* RVA: 0x03D4F260 */ set; /* RVA: 0x03D4F290 */ }
        System.Boolean forceModuleActive { get; /* RVA: 0x03D4F260 */ set; /* RVA: 0x03D4F290 */ }

        // Methods
        // RVA: 0x09F8410C  token: 0x6000768
        protected System.Void .ctor() { }
        // RVA: 0x09F83FB4  token: 0x600076D
        public virtual System.Void UpdateModule() { }
        // RVA: 0x09F82560  token: 0x600076E
        public virtual System.Boolean IsModuleSupported() { }
        // RVA: 0x09F83C60  token: 0x600076F
        public virtual System.Boolean ShouldActivateModule() { }
        // RVA: 0x09F840E8  token: 0x6000770
        private System.Boolean UseFakeInput() { }
        // RVA: 0x09F83B7C  token: 0x6000771
        public virtual System.Void Process() { }
        // RVA: 0x09F82470  token: 0x6000772
        private System.Void FakeTouches() { }
        // RVA: 0x09F82590  token: 0x6000773
        private System.Void ProcessTouchEvents() { }
        // RVA: 0x09F827A4  token: 0x6000774
        protected System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        // RVA: 0x09F7F9FC  token: 0x6000775
        public virtual System.Void DeactivateModule() { }
        // RVA: 0x09F83D38  token: 0x6000776
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x20000CC  // size: 0x14
    public sealed struct MoveDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.EventSystems.MoveDirection Left;  // const
        public static UnityEngine.EventSystems.MoveDirection Up;  // const
        public static UnityEngine.EventSystems.MoveDirection Right;  // const
        public static UnityEngine.EventSystems.MoveDirection Down;  // const
        public static UnityEngine.EventSystems.MoveDirection None;  // const

    }

    // TypeToken: 0x20000CD  // size: 0x10
    public static class RaycasterManager
    {
        // Fields
        private static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;  // static @ 0x0

        // Methods
        // RVA: 0x03327490  token: 0x6000778
        public static System.Void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster) { }
        // RVA: 0x09F7F2B8  token: 0x6000779
        public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }
        // RVA: 0x03327360  token: 0x600077A
        public static System.Void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster) { }
        // RVA: 0x03CE3430  token: 0x600077B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000CE  // size: 0x20
    public abstract class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;  // 0x18

        // Properties
        UnityEngine.Camera eventCamera { get; /* RVA: -1  // abstract */ }
        System.Int32 priority { get; /* RVA: 0x01002730 */ }
        System.Int32 sortOrderPriority { get; /* RVA: 0x03D89CD0 */ }
        System.Int32 renderOrderPriority { get; /* RVA: 0x03D89CD0 */ }
        UnityEngine.EventSystems.BaseRaycaster rootRaycaster { get; /* RVA: 0x02319F60 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600077C
        public virtual System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        // RVA: 0x09F7798C  token: 0x6000782
        public virtual System.String ToString() { }
        // RVA: 0x03327440  token: 0x6000783
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03327310  token: 0x6000784
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0364B0F0  token: 0x6000785
        protected virtual System.Void OnCanvasHierarchyChanged() { }
        // RVA: 0x0364B0F0  token: 0x6000786
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x0426FE60  token: 0x6000787
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF  // size: 0x48
    public class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
    {
        // Fields
        private UnityEngine.RaycastHit2D[] m_Hits;  // 0x40

        // Methods
        // RVA: 0x09F7BBA0  token: 0x6000788
        protected System.Void .ctor() { }
        // RVA: 0x09F7B604  token: 0x6000789
        public virtual System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

    }

    // TypeToken: 0x20000D0  // size: 0x40
    public class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
    {
        // Fields
        protected static System.Int32 kNoEventMaskSet;  // const
        protected UnityEngine.Camera m_EventCamera;  // 0x20
        protected UnityEngine.LayerMask m_EventMask;  // 0x28
        protected System.Int32 m_MaxRayIntersections;  // 0x2c
        protected System.Int32 m_LastMaxRayIntersections;  // 0x30
        private UnityEngine.RaycastHit[] m_Hits;  // 0x38

        // Properties
        UnityEngine.Camera eventCamera { get; /* RVA: 0x09F7C2A0 */ }
        System.Int32 depth { get; /* RVA: 0x09F7C21C */ }
        System.Int32 finalEventMask { get; /* RVA: 0x09F7C330 */ }
        UnityEngine.LayerMask eventMask { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Int32 maxRayIntersections { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }

        // Methods
        // RVA: 0x09F7BBA0  token: 0x600078A
        protected System.Void .ctor() { }
        // RVA: 0x09F7BBB0  token: 0x6000792
        protected System.Boolean ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Ray& ray, System.Int32& eventDisplayIndex, System.Single& distanceToClipPlane) { }
        // RVA: 0x09F7BE30  token: 0x6000793
        public virtual System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

    }

    // TypeToken: 0x20000D2  // size: 0x58
    public sealed struct RaycastResult
    {
        // Fields
        private UnityEngine.GameObject m_GameObject;  // 0x10
        public UnityEngine.EventSystems.BaseRaycaster module;  // 0x18
        public System.Single distance;  // 0x20
        public System.Single index;  // 0x24
        public System.Int32 depth;  // 0x28
        public System.Int32 sortingLayer;  // 0x2c
        public System.Int32 sortingOrder;  // 0x30
        public UnityEngine.Vector3 worldPosition;  // 0x34
        public UnityEngine.Vector3 worldNormal;  // 0x40
        public UnityEngine.Vector2 screenPosition;  // 0x4c
        public System.Int32 displayIndex;  // 0x54

        // Properties
        UnityEngine.GameObject gameObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        System.Boolean isValid { get; /* RVA: 0x09F7F244 */ }

        // Methods
        // RVA: 0x09F7EDCC  token: 0x600079A
        public System.Void Clear() { }
        // RVA: 0x09F7EE74  token: 0x600079B
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x20000D3  // size: 0x18
    public abstract class UIBehaviour : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600079C
        protected virtual System.Void Awake() { }
        // RVA: 0x0350B670  token: 0x600079D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0350B670  token: 0x600079E
        protected virtual System.Void Start() { }
        // RVA: 0x0350B670  token: 0x600079F
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0350B670  token: 0x60007A0
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x025198D0  token: 0x60007A1
        public virtual System.Boolean IsActive() { }
        // RVA: 0x0350B670  token: 0x60007A2
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x0350B670  token: 0x60007A3
        protected virtual System.Void OnBeforeTransformParentChanged() { }
        // RVA: 0x0350B670  token: 0x60007A4
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x0350B670  token: 0x60007A5
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x0350B670  token: 0x60007A6
        protected virtual System.Void OnCanvasHierarchyChanged() { }
        // RVA: 0x0239C840  token: 0x60007A7
        public virtual System.Boolean IsDestroyed() { }
        // RVA: 0x0426FE60  token: 0x60007A8
        protected System.Void .ctor() { }

    }

}

namespace UnityEngine.UI
{

    // TypeToken: 0x2000004  // size: 0x38
    public class AnimationTriggers
    {
        // Fields
        private static System.String kDefaultNormalAnimName;  // const
        private static System.String kDefaultHighlightedAnimName;  // const
        private static System.String kDefaultPressedAnimName;  // const
        private static System.String kDefaultSelectedAnimName;  // const
        private static System.String kDefaultDisabledAnimName;  // const
        private System.String m_NormalTrigger;  // 0x10
        private System.String m_HighlightedTrigger;  // 0x18
        private System.String m_PressedTrigger;  // 0x20
        private System.String m_SelectedTrigger;  // 0x28
        private System.String m_DisabledTrigger;  // 0x30

        // Properties
        System.String normalTrigger { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String highlightedTrigger { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String pressedTrigger { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String selectedTrigger { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        System.String disabledTrigger { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x02848B40  token: 0x600000D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x188
    public class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
    {
        // Fields
        private UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;  // 0x180

        // Properties
        UnityEngine.UI.Button.ButtonClickedEvent onClick { get; /* RVA: 0x03D56B50 */ set; /* RVA: 0x04275C40 */ }

        // Methods
        // RVA: 0x09E5C808  token: 0x600000E
        protected System.Void .ctor() { }
        // RVA: 0x09E5C790  token: 0x6000011
        private System.Void Press() { }
        // RVA: 0x09E5C704  token: 0x6000012
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09E5C72C  token: 0x6000013
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09E5C6A8  token: 0x6000014
        private System.Collections.IEnumerator OnFinishSubmit() { }

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct CanvasUpdate
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.CanvasUpdate Prelayout;  // const
        public static UnityEngine.UI.CanvasUpdate Layout;  // const
        public static UnityEngine.UI.CanvasUpdate PostLayout;  // const
        public static UnityEngine.UI.CanvasUpdate PreRender;  // const
        public static UnityEngine.UI.CanvasUpdate LatePreRender;  // const
        public static UnityEngine.UI.CanvasUpdate MaxUpdateValue;  // const

    }

    // TypeToken: 0x2000009
    public interface ICanvasElement
    {
        // Properties
        UnityEngine.Transform transform { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600001C
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: -1  // abstract  token: 0x600001E
        public virtual System.Void LayoutComplete() { }
        // RVA: -1  // abstract  token: 0x600001F
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: -1  // abstract  token: 0x6000020
        public virtual System.Boolean IsDestroyed() { }

    }

    // TypeToken: 0x200000A  // size: 0x30
    public class CanvasUpdateRegistry
    {
        // Fields
        private static UnityEngine.UI.CanvasUpdateRegistry s_Instance;  // static @ 0x0
        private System.Boolean m_PerformingLayoutUpdate;  // 0x10
        private System.Boolean m_PerformingGraphicUpdate;  // 0x11
        private Unity.Profiling.ProfilerMarker[] m_CanvasUpdateProfilerStrings;  // 0x18
        private static System.String m_CullingUpdateProfilerString;  // const
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;  // 0x20
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;  // 0x28
        private static readonly System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction;  // static @ 0x8

        // Properties
        UnityEngine.UI.CanvasUpdateRegistry instance { get; /* RVA: 0x0239DCC0 */ }

        // Methods
        // RVA: 0x02CD05B0  token: 0x6000021
        protected System.Void .ctor() { }
        // RVA: 0x0239C000  token: 0x6000023
        private System.Boolean ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239B3A0  token: 0x6000024
        private System.Void CleanInvalidItems() { }
        // RVA: 0x0239B5A0  token: 0x6000025
        private System.Void PerformUpdate() { }
        // RVA: 0x02DA8E30  token: 0x6000026
        private static System.Int32 ParentCount(UnityEngine.Transform child) { }
        // RVA: 0x02DA8CC0  token: 0x6000027
        private static System.Int32 SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y) { }
        // RVA: 0x034CFE10  token: 0x6000028
        public static System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239D100  token: 0x6000029
        public static System.Boolean TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239DFD0  token: 0x600002A
        private System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239D980  token: 0x600002B
        public static System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x09E5C894  token: 0x600002C
        public static System.Boolean TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239DDC0  token: 0x600002D
        private System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239CDC0  token: 0x600002E
        public static System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239C980  token: 0x600002F
        private System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239CB40  token: 0x6000030
        private System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        // RVA: 0x0239CD00  token: 0x6000031
        public static System.Boolean IsRebuildingLayout() { }
        // RVA: 0x0239CD60  token: 0x6000032
        public static System.Boolean IsRebuildingGraphics() { }
        // RVA: 0x03CBD3B0  token: 0x6000033
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x68
    public sealed struct ColorBlock : System.IEquatable`1
    {
        // Fields
        private UnityEngine.Color m_NormalColor;  // 0x10
        private UnityEngine.Color m_HighlightedColor;  // 0x20
        private UnityEngine.Color m_PressedColor;  // 0x30
        private UnityEngine.Color m_SelectedColor;  // 0x40
        private UnityEngine.Color m_DisabledColor;  // 0x50
        private System.Single m_ColorMultiplier;  // 0x60
        private System.Single m_FadeDuration;  // 0x64
        public static UnityEngine.UI.ColorBlock defaultColorBlock;  // static @ 0x0

        // Properties
        UnityEngine.Color normalColor { get; /* RVA: 0x03D5B250 */ set; /* RVA: 0x03D5E620 */ }
        UnityEngine.Color highlightedColor { get; /* RVA: 0x020B7B30 */ set; /* RVA: 0x03D55580 */ }
        UnityEngine.Color pressedColor { get; /* RVA: 0x03D54E00 */ set; /* RVA: 0x03D54E10 */ }
        UnityEngine.Color selectedColor { get; /* RVA: 0x03D4FD30 */ set; /* RVA: 0x03D4FD40 */ }
        UnityEngine.Color disabledColor { get; /* RVA: 0x03D5A160 */ set; /* RVA: 0x03D5D610 */ }
        System.Single colorMultiplier { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }
        System.Single fadeDuration { get; /* RVA: 0x03D4F670 */ set; /* RVA: 0x03D4F680 */ }

        // Methods
        // RVA: 0x02561F60  token: 0x6000042
        private static System.Void .cctor() { }
        // RVA: 0x09E5C8EC  token: 0x6000043
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09E5C99C  token: 0x6000044
        public virtual System.Boolean Equals(UnityEngine.UI.ColorBlock other) { }
        // RVA: 0x09E5CBA4  token: 0x6000045
        public static System.Boolean op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2) { }
        // RVA: 0x09E5CC38  token: 0x6000046
        public static System.Boolean op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2) { }
        // RVA: 0x09E5CB20  token: 0x6000047
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000C  // size: 0x20
    public class ClipperRegistry
    {
        // Fields
        private static UnityEngine.UI.ClipperRegistry s_Instance;  // static @ 0x0
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;  // 0x10
        private readonly Unity.Profiling.ProfilerMarker clippersMarker;  // 0x18

        // Properties
        UnityEngine.UI.ClipperRegistry instance { get; /* RVA: 0x02516E40 */ }

        // Methods
        // RVA: 0x02515620  token: 0x6000048
        protected System.Void .ctor() { }
        // RVA: 0x02DF7F90  token: 0x600004A
        public System.Void Cull() { }
        // RVA: 0x02516DD0  token: 0x600004B
        public static System.Void Register(UnityEngine.UI.IClipper c) { }
        // RVA: 0x02516D40  token: 0x600004C
        public static System.Void Unregister(UnityEngine.UI.IClipper c) { }

    }

    // TypeToken: 0x200000D  // size: 0x10
    public static class Clipping
    {
        // Methods
        // RVA: 0x0233E630  token: 0x600004D
        public static UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, System.Boolean& validRect) { }

    }

    // TypeToken: 0x200000E
    public interface IClipper
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600004E
        public virtual System.Void PerformClipping() { }

    }

    // TypeToken: 0x200000F
    public interface IClippable
    {
        // Properties
        UnityEngine.GameObject gameObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000050
        public virtual System.Void RecalculateClipping() { }
        // RVA: -1  // abstract  token: 0x6000052
        public virtual System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        // RVA: -1  // abstract  token: 0x6000053
        public virtual System.Void SetClipRect(UnityEngine.Rect value, System.Boolean validRect) { }
        // RVA: -1  // abstract  token: 0x6000054
        public virtual System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness) { }
        // RVA: -1  // abstract  token: 0x6000055
        public virtual System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness) { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public class RectangularVertexClipper
    {
        // Fields
        private readonly UnityEngine.Vector3[] m_WorldCorners;  // 0x10
        private readonly UnityEngine.Vector3[] m_CanvasCorners;  // 0x18

        // Methods
        // RVA: 0x023443C0  token: 0x6000056
        public UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c) { }
        // RVA: 0x03294BB0  token: 0x6000057
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public static class DefaultControls
    {
        // Fields
        private static UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory;  // static @ 0x0
        private static System.Single kWidth;  // const
        private static System.Single kThickHeight;  // const
        private static System.Single kThinHeight;  // const
        private static UnityEngine.Vector2 s_ThickElementSize;  // static @ 0x8
        private static UnityEngine.Vector2 s_ThinElementSize;  // static @ 0x10
        private static UnityEngine.Vector2 s_ImageElementSize;  // static @ 0x18
        private static UnityEngine.Color s_DefaultSelectableColor;  // static @ 0x20
        private static UnityEngine.Color s_PanelColor;  // static @ 0x30
        private static UnityEngine.Color s_TextColor;  // static @ 0x40

        // Properties
        UnityEngine.UI.DefaultControls.IFactoryControls factory { get; /* RVA: 0x09E60A34 */ }

        // Methods
        // RVA: 0x09E6055C  token: 0x6000059
        private static UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size, System.Type[] components) { }
        // RVA: 0x09E60608  token: 0x600005A
        private static UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent, System.Type[] components) { }
        // RVA: 0x09E606DC  token: 0x600005B
        private static System.Void SetDefaultTextValues(UnityEngine.UI.Text lbl) { }
        // RVA: 0x09E6068C  token: 0x600005C
        private static System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider) { }
        // RVA: 0x09E60854  token: 0x600005D
        private static System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent) { }
        // RVA: 0x09E60794  token: 0x600005E
        private static System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer) { }
        // RVA: 0x09E5E800  token: 0x600005F
        public static UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5CCD0  token: 0x6000060
        public static UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5FE38  token: 0x6000061
        public static UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5E164  token: 0x6000062
        public static UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5EA30  token: 0x6000063
        public static UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5F6EC  token: 0x6000064
        public static UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5F298  token: 0x6000065
        public static UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5FF9C  token: 0x6000066
        public static UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5E270  token: 0x6000067
        public static UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5D02C  token: 0x6000068
        public static UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E5EB3C  token: 0x6000069
        public static UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources) { }
        // RVA: 0x09E60920  token: 0x600006A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x1F0
    public class Dropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
    {
        // Fields
        private UnityEngine.RectTransform m_Template;  // 0x180
        private UnityEngine.UI.Text m_CaptionText;  // 0x188
        private UnityEngine.UI.Image m_CaptionImage;  // 0x190
        private UnityEngine.UI.Text m_ItemText;  // 0x198
        private UnityEngine.UI.Image m_ItemImage;  // 0x1a0
        private System.Int32 m_Value;  // 0x1a8
        private UnityEngine.UI.Dropdown.OptionDataList m_Options;  // 0x1b0
        private UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;  // 0x1b8
        private System.Single m_AlphaFadeSpeed;  // 0x1c0
        private UnityEngine.GameObject m_Dropdown;  // 0x1c8
        private UnityEngine.GameObject m_Blocker;  // 0x1d0
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items;  // 0x1d8
        private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;  // 0x1e0
        private System.Boolean validTemplate;  // 0x1e8
        private static System.Int32 kHighSortingLayer;  // const
        private static UnityEngine.UI.Dropdown.OptionData s_NoOptionData;  // static @ 0x0

        // Properties
        UnityEngine.RectTransform template { get; /* RVA: 0x03D56B50 */ set; /* RVA: 0x09E63924 */ }
        UnityEngine.UI.Text captionText { get; /* RVA: 0x03D56AF0 */ set; /* RVA: 0x09E63878 */ }
        UnityEngine.UI.Image captionImage { get; /* RVA: 0x03D56B70 */ set; /* RVA: 0x09E63850 */ }
        UnityEngine.UI.Text itemText { get; /* RVA: 0x03D56AE0 */ set; /* RVA: 0x09E638C8 */ }
        UnityEngine.UI.Image itemImage { get; /* RVA: 0x03D56AD0 */ set; /* RVA: 0x09E638A0 */ }
        System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options { get; /* RVA: 0x09E63830 */ set; /* RVA: 0x09E638F0 */ }
        UnityEngine.UI.Dropdown.DropdownEvent onValueChanged { get; /* RVA: 0x03D57130 */ set; /* RVA: 0x04275B98 */ }
        System.Single alphaFadeSpeed { get; /* RVA: 0x03D584D0 */ set; /* RVA: 0x03D58600 */ }
        System.Int32 value { get; /* RVA: 0x03D583A0 */ set; /* RVA: 0x09E6394C */ }

        // Methods
        // RVA: 0x09E62118  token: 0x6000081
        public System.Void SetValueWithoutNotify(System.Int32 input) { }
        // RVA: 0x09E62124  token: 0x6000082
        private System.Void Set(System.Int32 value, System.Boolean sendCallback) { }
        // RVA: 0x09E63708  token: 0x6000083
        protected System.Void .ctor() { }
        // RVA: 0x09E6137C  token: 0x6000084
        protected virtual System.Void Awake() { }
        // RVA: 0x09E63608  token: 0x6000085
        protected virtual System.Void Start() { }
        // RVA: 0x09E61CF0  token: 0x6000086
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09E61E94  token: 0x6000087
        public System.Void RefreshShownValue() { }
        // RVA: 0x09E6110C  token: 0x6000088
        public System.Void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }
        // RVA: 0x09E60F04  token: 0x6000089
        public System.Void AddOptions(System.Collections.Generic.List<System.String> options) { }
        // RVA: 0x09E61008  token: 0x600008A
        public System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }
        // RVA: 0x09E61464  token: 0x600008B
        public System.Void ClearOptions() { }
        // RVA: 0x09E62214  token: 0x600008C
        private System.Void SetupTemplate(UnityEngine.Canvas rootCanvas) { }
        // RVA: -1  // generic def  token: 0x600008D
        private static T GetOrAddComponent(UnityEngine.GameObject go) { }
        // RVA: 0x09E61D84  token: 0x600008E
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09E61D84  token: 0x600008F
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09E61CE8  token: 0x6000090
        public virtual System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09E6285C  token: 0x6000091
        public System.Void Show() { }
        // RVA: 0x09E614C4  token: 0x6000092
        protected virtual UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas) { }
        // RVA: 0x09E61A0C  token: 0x6000093
        protected virtual System.Void DestroyBlocker(UnityEngine.GameObject blocker) { }
        // RVA: 0x09E618F8  token: 0x6000094
        protected virtual UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template) { }
        // RVA: 0x09E61A58  token: 0x6000095
        protected virtual System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList) { }
        // RVA: 0x09E6194C  token: 0x6000096
        protected virtual UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate) { }
        // RVA: 0x0350B670  token: 0x6000097
        protected virtual System.Void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item) { }
        // RVA: 0x09E60C78  token: 0x6000098
        private UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, System.Boolean selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }
        // RVA: 0x09E612F0  token: 0x6000099
        private System.Void AlphaFadeList(System.Single duration, System.Single alpha) { }
        // RVA: 0x09E61174  token: 0x600009A
        private System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end) { }
        // RVA: 0x09E62078  token: 0x600009B
        private System.Void SetAlpha(System.Single alpha) { }
        // RVA: 0x09E61AA4  token: 0x600009C
        public System.Void Hide() { }
        // RVA: 0x09E619A0  token: 0x600009D
        private System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay) { }
        // RVA: 0x09E61B98  token: 0x600009E
        private System.Void ImmediateDestroyDropdownList() { }
        // RVA: 0x09E61D8C  token: 0x600009F
        private System.Void OnSelectItem(UnityEngine.UI.Toggle toggle) { }
        // RVA: 0x09E63698  token: 0x60000A0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x40
    public class FontData : UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.Font m_Font;  // 0x10
        private System.Int32 m_FontSize;  // 0x18
        private UnityEngine.FontStyle m_FontStyle;  // 0x1c
        private System.Boolean m_BestFit;  // 0x20
        private System.Int32 m_MinSize;  // 0x24
        private System.Int32 m_MaxSize;  // 0x28
        private UnityEngine.TextAnchor m_Alignment;  // 0x2c
        private System.Boolean m_AlignByGeometry;  // 0x30
        private System.Boolean m_RichText;  // 0x31
        private UnityEngine.HorizontalWrapMode m_HorizontalOverflow;  // 0x34
        private UnityEngine.VerticalWrapMode m_VerticalOverflow;  // 0x38
        private System.Single m_LineSpacing;  // 0x3c

        // Properties
        UnityEngine.UI.FontData defaultFontData { get; /* RVA: 0x09E639A4 */ }
        UnityEngine.Font font { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Int32 fontSize { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        UnityEngine.FontStyle fontStyle { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        System.Boolean bestFit { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        System.Int32 minSize { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }
        System.Int32 maxSize { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        UnityEngine.TextAnchor alignment { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }
        System.Boolean alignByGeometry { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }
        System.Boolean richText { get; /* RVA: 0x03D4F2C0 */ set; /* RVA: 0x03D4F2D0 */ }
        UnityEngine.HorizontalWrapMode horizontalOverflow { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x03D4EE40 */ }
        UnityEngine.VerticalWrapMode verticalOverflow { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.Single lineSpacing { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x03D4ECE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000D9
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x09E63958  token: 0x60000DA
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x0350B670  token: 0x60000DB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x10
    public static class FontUpdateTracker
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;  // static @ 0x0

        // Methods
        // RVA: 0x09E63B88  token: 0x60000DC
        public static System.Void TrackText(UnityEngine.UI.Text t) { }
        // RVA: 0x09E63A18  token: 0x60000DD
        private static System.Void RebuildForFont(UnityEngine.Font f) { }
        // RVA: 0x09E63DA8  token: 0x60000DE
        public static System.Void UntrackText(UnityEngine.UI.Text t) { }
        // RVA: 0x09E63F8C  token: 0x60000DF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001E  // size: 0xB0
    public abstract class Graphic : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ICanvasElement
    {
        // Fields
        protected static UnityEngine.Material s_DefaultUI;  // static @ 0x0
        protected static UnityEngine.Texture2D s_WhiteTexture;  // static @ 0x8
        private static System.String s_DefaultMaterialName;  // static @ 0x10
        private static System.String s_OverlayShaderKeyword;  // static @ 0x18
        protected UnityEngine.Material m_Material;  // 0x18
        private UnityEngine.Color m_Color;  // 0x20
        protected System.Boolean m_SkipLayoutUpdate;  // 0x30
        protected System.Boolean m_SkipMaterialUpdate;  // 0x31
        private System.Boolean m_RaycastTarget;  // 0x32
        private UnityEngine.Vector4 m_RaycastPadding;  // 0x34
        private System.Boolean m_RaycastIgnoreMask;  // 0x44
        private UnityEngine.RectTransform m_RectTransform;  // 0x48
        private UnityEngine.CanvasRenderer m_CanvasRenderer;  // 0x50
        private UnityEngine.Canvas m_Canvas;  // 0x58
        private System.Boolean m_VertsDirty;  // 0x60
        private System.Boolean m_MaterialDirty;  // 0x61
        protected UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;  // 0x68
        protected UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;  // 0x70
        protected UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;  // 0x78
        protected static UnityEngine.Mesh s_Mesh;  // static @ 0x20
        private static readonly UnityEngine.UI.VertexHelper s_VertexHelper;  // static @ 0x28
        protected UnityEngine.Mesh m_CachedMesh;  // 0x80
        protected UnityEngine.Vector2[] m_CachedUvs;  // 0x88
        private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunnerLazy;  // 0x90
        protected System.Boolean m_EnableRuntimeAtlas;  // 0x98
        protected UnityEngine.Texture m_RuntimeAtlasTexture;  // 0xa0
        private System.Boolean <useLegacyMeshGeneration>k__BackingField;  // 0xa8

        // Properties
        System.String defaultMaterialName { get; /* RVA: 0x09E64430 */ set; /* RVA: 0x09E644D0 */ }
        UnityEngine.Material defaultGraphicMaterial { get; /* RVA: 0x025C3E70 */ }
        System.String overlayShaderKeyword { get; /* RVA: 0x09E64480 */ set; /* RVA: 0x09E64560 */ }
        UnityEngine.Color color { get; /* RVA: 0x03D54E00 */ set; /* RVA: 0x025C1E20 */ }
        System.Boolean raycastTarget { get; /* RVA: 0x03D4F630 */ set; /* RVA: 0x03567B30 */ }
        UnityEngine.Vector4 raycastPadding { get; /* RVA: 0x03D51E40 */ set; /* RVA: 0x03D51E50 */ }
        UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner { get; /* RVA: 0x024A3DF0 */ }
        System.Boolean enableRuntimeAtlas { get; /* RVA: 0x03D58690 */ set; /* RVA: 0x09E64530 */ }
        UnityEngine.Texture runtimeAtlasTexture { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x09E645C0 */ }
        System.Boolean useLegacyMeshGeneration { get; /* RVA: 0x011B9C10 */ set; /* RVA: 0x011B9C20 */ }
        System.Int32 depth { get; /* RVA: 0x02341D00 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x0233FD70 */ }
        UnityEngine.Canvas canvas { get; /* RVA: 0x02345AD0 */ }
        UnityEngine.CanvasRenderer canvasRenderer { get; /* RVA: 0x02341C90 */ }
        UnityEngine.Material defaultMaterial { get; /* RVA: 0x025C3E20 */ }
        UnityEngine.Material material { get; /* RVA: 0x030A8360 */ set; /* RVA: 0x034D2AC0 */ }
        UnityEngine.Material materialForRendering { get; /* RVA: 0x025C6F00 */ }
        UnityEngine.Texture mainTexture { get; /* RVA: 0x03CFAFA0 */ }
        UnityEngine.Mesh workerMesh { get; /* RVA: 0x0233EFA0 */ }

        // Methods
        // RVA: 0x024340C0  token: 0x60000F2
        protected System.Void .ctor() { }
        // RVA: 0x03009260  token: 0x60000F3
        public virtual System.Void SetAllDirty() { }
        // RVA: 0x0233E250  token: 0x60000F4
        public virtual System.Void SetLayoutDirty() { }
        // RVA: 0x0239D5F0  token: 0x60000F5
        public virtual System.Void SetVerticesDirty() { }
        // RVA: 0x0239D260  token: 0x60000F6
        public virtual System.Void SetMaterialDirty() { }
        // RVA: 0x02394070  token: 0x60000F7
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x031ED950  token: 0x60000F8
        protected virtual System.Void OnBeforeTransformParentChanged() { }
        // RVA: 0x031635B0  token: 0x60000F9
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x0251D250  token: 0x60000FD
        private System.Void CacheCanvas() { }
        // RVA: 0x02399F40  token: 0x6000104
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0239AE50  token: 0x6000105
        protected virtual System.Void OnDisable() { }
        // RVA: 0x025CAEC0  token: 0x6000106
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x025A2510  token: 0x6000107
        protected virtual System.Void OnCanvasHierarchyChanged() { }
        // RVA: 0x02C6F700  token: 0x6000108
        public virtual System.Void OnCullingChanged() { }
        // RVA: 0x02342510  token: 0x6000109
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        // RVA: 0x0350B670  token: 0x600010A
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x600010B
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x025C6C70  token: 0x600010C
        protected virtual System.Void UpdateMaterial() { }
        // RVA: 0x0233E5B0  token: 0x600010D
        protected virtual System.Void UpdateGeometry() { }
        // RVA: 0x0233F3F0  token: 0x600010E
        private System.Void DoMeshGeneration() { }
        // RVA: 0x0398B650  token: 0x600010F
        private System.Void DoLegacyMeshGeneration() { }
        // RVA: 0x0350B670  token: 0x6000111
        protected virtual System.Void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }
        // RVA: 0x03CF0F00  token: 0x6000112
        protected virtual System.Void OnPopulateMesh(UnityEngine.Mesh m) { }
        // RVA: 0x025A3710  token: 0x6000113
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x09E640BC  token: 0x6000114
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x0350B670  token: 0x6000115
        public virtual System.Void SetNativeSize() { }
        // RVA: 0x02519020  token: 0x6000116
        public virtual System.Boolean Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x09E640CC  token: 0x6000117
        public UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point) { }
        // RVA: 0x0233E320  token: 0x6000118
        public UnityEngine.Rect GetPixelAdjustedRect() { }
        // RVA: 0x024A3780  token: 0x6000119
        public virtual System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        // RVA: 0x024A3800  token: 0x600011A
        public virtual System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB) { }
        // RVA: 0x03C95E10  token: 0x600011B
        private static UnityEngine.Color CreateColorFromAlpha(System.Single alpha) { }
        // RVA: 0x03C95D40  token: 0x600011C
        public virtual System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        // RVA: 0x09E64200  token: 0x600011D
        public System.Void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x09E64318  token: 0x600011E
        public System.Void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x02CD8F30  token: 0x600011F
        public System.Void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x02CD8670  token: 0x6000120
        public System.Void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x09E6428C  token: 0x6000121
        public System.Void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x09E643A4  token: 0x6000122
        public System.Void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x03B39A40  token: 0x6000123
        private static System.Void .cctor() { }
        // RVA: 0x04273A88  token: 0x6000124
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200001F  // size: 0x40
    public class GraphicRaycaster : UnityEngine.EventSystems.BaseRaycaster
    {
        // Fields
        protected static System.Int32 kNoEventMaskSet;  // const
        private System.Boolean m_IgnoreReversedGraphics;  // 0x20
        private UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;  // 0x24
        protected UnityEngine.LayerMask m_BlockingMask;  // 0x28
        private UnityEngine.Canvas m_Canvas;  // 0x30
        private System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults;  // 0x38
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics;  // static @ 0x0

        // Properties
        System.Int32 sortOrderPriority { get; /* RVA: 0x02398D70 */ }
        System.Int32 renderOrderPriority { get; /* RVA: 0x02398EF0 */ }
        System.Boolean ignoreReversedGraphics { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        UnityEngine.UI.GraphicRaycaster.BlockingObjects blockingObjects { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }
        UnityEngine.LayerMask blockingMask { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        UnityEngine.Canvas canvas { get; /* RVA: 0x02398350 */ }
        UnityEngine.Camera eventCamera { get; /* RVA: 0x02398A50 */ }

        // Methods
        // RVA: 0x034CF540  token: 0x600012D
        protected System.Void .ctor() { }
        // RVA: 0x023968C0  token: 0x600012F
        public virtual System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        // RVA: 0x0233FE10  token: 0x6000131
        private static System.Void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }
        // RVA: 0x034CF410  token: 0x6000132
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x20
    public class GraphicRegistry
    {
        // Fields
        private static UnityEngine.UI.GraphicRegistry s_Instance;  // static @ 0x0
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;  // 0x10
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;  // 0x18
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;  // static @ 0x8

        // Properties
        UnityEngine.UI.GraphicRegistry instance { get; /* RVA: 0x02398950 */ }

        // Methods
        // RVA: 0x03A20290  token: 0x6000136
        protected System.Void .ctor() { }
        // RVA: 0x02399060  token: 0x6000138
        public static System.Void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        // RVA: 0x023998B0  token: 0x6000139
        public static System.Void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        // RVA: 0x023994F0  token: 0x600013A
        public static System.Void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        // RVA: 0x02399C60  token: 0x600013B
        public static System.Void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        // RVA: 0x09E64018  token: 0x600013C
        public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas) { }
        // RVA: 0x02398470  token: 0x600013D
        public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas) { }
        // RVA: 0x034CF4A0  token: 0x600013E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public interface IGraphicEnabledDisabled
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600013F
        public virtual System.Void OnSiblingGraphicEnabledDisabled() { }

    }

    // TypeToken: 0x2000024  // size: 0x190
    public class Image : UnityEngine.UI.MaskableGraphic, UnityEngine.ISerializationCallbackReceiver, UnityEngine.UI.ILayoutElement, UnityEngine.ICanvasRaycastFilter
    {
        // Fields
        protected static UnityEngine.Material s_ETC1DefaultUI;  // static @ 0x0
        private UnityEngine.Sprite m_Sprite;  // 0xe8
        protected UnityEngine.Rect m_RuntimeAtlasRect;  // 0xf0
        protected UnityEngine.Rect m_RuntimeAtlasTextureRect;  // 0x100
        protected UnityEngine.Vector4 m_RuntimeAtlasBorder;  // 0x110
        protected System.Single m_RuntimeAtlasPixelsPerUnit;  // 0x120
        private UnityEngine.Sprite m_OverrideSprite;  // 0x128
        private UnityEngine.UI.Image.Type m_Type;  // 0x130
        private System.Boolean m_PreserveAspect;  // 0x134
        private System.Boolean m_FillCenter;  // 0x135
        private UnityEngine.UI.Image.FillMethod m_FillMethod;  // 0x138
        private System.Single m_FillAmount;  // 0x13c
        private System.Boolean m_FillClockwise;  // 0x140
        private System.Int32 m_FillOrigin;  // 0x144
        private System.Single m_AlphaHitTestMinimumThreshold;  // 0x148
        private System.Boolean m_Tracked;  // 0x14c
        private System.Boolean m_UseSpriteMesh;  // 0x14d
        private System.Single m_PixelsPerUnitMultiplier;  // 0x150
        private System.Single m_CachedReferencePixelsPerUnit;  // 0x154
        public UnityEngine.UI.Image.SlicedSpriteParams slicedSpriteParams;  // 0x158
        private System.Boolean bAwakeOnce;  // 0x17c
        private static readonly UnityEngine.Vector2[] s_VertScratch;  // static @ 0x8
        private static readonly UnityEngine.Vector2[] s_UVScratch;  // static @ 0x10
        private static System.Int32 QuadCount;  // const
        private static readonly UnityEngine.Vector3[] s_Xy;  // static @ 0x18
        private static readonly UnityEngine.Vector3[] s_Uv;  // static @ 0x20
        private static System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages;  // static @ 0x28
        private static System.Boolean s_Initialized;  // static @ 0x30
        protected static System.Int32 VALIDATE_MAX_VERT_COUNT;  // const
        private UnityEngine.UI.Image.EDynamicAtlasActiveMode m_DynamicAtlasActiveMode;  // 0x17d
        protected System.Boolean _packIntoRuntimeAtlas;  // 0x17e
        protected System.Int32 m_panelLevel;  // 0x180
        public System.Boolean keepOriginUV;  // 0x184
        private System.Action dynamicAtlasCallBack;  // 0x188
        private static System.Boolean _sDynamicAtlasInitialized;  // static @ 0x31
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Image> s_FreeList;  // static @ 0x38
        private static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image> s_TrackedDynamicAtlasImages;  // static @ 0x40
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Image> s_FreeListRevert;  // static @ 0x48
        private static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image> s_TrackedDynamicAtlasSpriteRevert;  // static @ 0x50
        public static System.Boolean s_AtlasV2;  // static @ 0x58

        // Properties
        UnityEngine.Rect runtimeAtlasRect { get; /* RVA: 0x03D6C080 */ set; /* RVA: 0x03D6C110 */ }
        UnityEngine.Rect runtimeAtlasTextureRect { get; /* RVA: 0x03D6C060 */ set; /* RVA: 0x03D6C0E0 */ }
        UnityEngine.Vector4 runtimeAtlasBorder { get; /* RVA: 0x03D6C050 */ set; /* RVA: 0x03D6C0D0 */ }
        System.Single runtimeAtlasPixelsPerUnit { get; /* RVA: 0x03D583D0 */ set; /* RVA: 0x03D884B0 */ }
        UnityEngine.Sprite sprite { get; /* RVA: 0x03D50EA0 */ set; /* RVA: 0x025C39D0 */ }
        System.Boolean enableRuntimeAtlasRaw { get; /* RVA: 0x03D58690 */ }
        System.Boolean enableRuntimeAtlas { get; /* RVA: 0x02E55420 */ set; /* RVA: 0x09E64530 */ }
        UnityEngine.Sprite overrideSprite { get; /* RVA: 0x09E665E0 */ set; /* RVA: 0x09E66768 */ }
        UnityEngine.Sprite activeSprite { get; /* RVA: 0x025C6650 */ }
        UnityEngine.UI.Image.Type type { get; /* RVA: 0x03D5CE60 */ set; /* RVA: 0x09E66854 */ }
        System.Boolean preserveAspect { get; /* RVA: 0x03D5AED0 */ set; /* RVA: 0x09E667F4 */ }
        System.Boolean fillCenter { get; /* RVA: 0x03D5AF00 */ set; /* RVA: 0x09E665E8 */ }
        UnityEngine.UI.Image.FillMethod fillMethod { get; /* RVA: 0x03D59CD0 */ set; /* RVA: 0x09E666A8 */ }
        System.Single fillAmount { get; /* RVA: 0x03D57900 */ set; /* RVA: 0x02409C90 */ }
        System.Boolean fillClockwise { get; /* RVA: 0x03D576E0 */ set; /* RVA: 0x09E66648 */ }
        System.Int32 fillOrigin { get; /* RVA: 0x03D76300 */ set; /* RVA: 0x09E6670C */ }
        System.Single eventAlphaThreshold { get; /* RVA: 0x03D88460 */ set; /* RVA: 0x03D88490 */ }
        System.Single alphaHitTestMinimumThreshold { get; /* RVA: 0x03D58220 */ set; /* RVA: 0x03D5B6A0 */ }
        System.Boolean useSpriteMesh { get; /* RVA: 0x03D88480 */ set; /* RVA: 0x09E668B0 */ }
        UnityEngine.Material defaultETC1GraphicMaterial { get; /* RVA: 0x09E66518 */ }
        UnityEngine.Texture mainTexture { get; /* RVA: 0x025C57E0 */ }
        System.Boolean hasBorder { get; /* RVA: 0x025A12F0 */ }
        System.Single pixelsPerUnitMultiplier { get; /* RVA: 0x03D581F0 */ set; /* RVA: 0x09E667D0 */ }
        System.Single pixelsPerUnit { get; /* RVA: 0x025A1790 */ }
        System.Single multipliedPixelsPerUnit { get; /* RVA: 0x025A1770 */ }
        UnityEngine.Material material { get; /* RVA: 0x025C4BA0 */ set; /* RVA: 0x034D2AB0 */ }
        System.Single minWidth { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredWidth { get; /* RVA: 0x025A0C40 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single minHeight { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredHeight { get; /* RVA: 0x025A0990 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01002730 */ }
        UnityEngine.UI.Image.EDynamicAtlasActiveMode DynamicAtlasActiveMode { get; /* RVA: 0x03D88450 */ }

        // Methods
        // RVA: 0x03C84750  token: 0x600014D
        public virtual System.Void ReleaseSprite() { }
        // RVA: 0x025CA680  token: 0x600014E
        protected virtual System.Void _OnSpriteChanged(UnityEngine.Sprite oldOne) { }
        // RVA: 0x03D88440  token: 0x600014F
        public System.Void DisableSpriteOptimizations() { }
        // RVA: 0x02432BB0  token: 0x6000167
        protected System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000171
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x023938D0  token: 0x6000172
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x033285D0  token: 0x6000173
        private System.Void PreserveSpriteAspectRatio(UnityEngine.Rect& rect, UnityEngine.Vector2 spriteSize) { }
        // RVA: 0x025C5D40  token: 0x6000174
        private UnityEngine.Vector4 GetDrawingDimensions(System.Boolean shouldPreserveAspect) { }
        // RVA: 0x025A0EF0  token: 0x6000175
        public virtual System.Void SetNativeSize() { }
        // RVA: 0x025C4680  token: 0x6000176
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x025C6880  token: 0x6000177
        private System.Void TrackSprite() { }
        // RVA: 0x0239AD90  token: 0x6000178
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0239F370  token: 0x6000179
        protected virtual System.Void OnDisable() { }
        // RVA: 0x025CA950  token: 0x600017A
        protected virtual System.Void Awake() { }
        // RVA: 0x025CAE30  token: 0x600017B
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x025C50D0  token: 0x600017C
        protected virtual System.Void UpdateMaterial() { }
        // RVA: 0x025A1BD0  token: 0x600017D
        protected virtual System.Void OnCanvasHierarchyChanged() { }
        // RVA: 0x025A6ED0  token: 0x600017E
        private System.Void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect) { }
        // RVA: 0x09E654E8  token: 0x600017F
        private System.Void GenerateSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect) { }
        // RVA: 0x025A2CF0  token: 0x6000180
        private System.Void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x02F93F50  token: 0x6000181
        private System.Void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x09E64F80  token: 0x6000182
        private System.Void GenerateMirrorSprite(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x09E645EC  token: 0x6000183
        private System.Void GenerateMirrorQuarter(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x025A4330  token: 0x6000184
        private static System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs) { }
        // RVA: 0x025A3A10  token: 0x6000185
        private static System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax) { }
        // RVA: 0x02636AC0  token: 0x6000186
        private UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect) { }
        // RVA: 0x02349130  token: 0x6000187
        private System.Void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, System.Boolean preserveAspect) { }
        // RVA: 0x02770A50  token: 0x6000188
        private static System.Boolean RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, System.Single fill, System.Boolean invert, System.Int32 corner) { }
        // RVA: 0x02770BD0  token: 0x6000189
        private static System.Void RadialCut(UnityEngine.Vector3[] xy, System.Single cos, System.Single sin, System.Boolean invert, System.Int32 corner) { }
        // RVA: 0x0350B670  token: 0x600018A
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x600018B
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x02517520  token: 0x6000193
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera) { }
        // RVA: 0x09E65E74  token: 0x6000194
        private UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect) { }
        // RVA: 0x09E66220  token: 0x6000195
        private static System.Void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas) { }
        // RVA: 0x09E663A8  token: 0x6000196
        private static System.Void TrackImage(UnityEngine.UI.Image g) { }
        // RVA: 0x09E664A8  token: 0x6000197
        private static System.Void UnTrackImage(UnityEngine.UI.Image g) { }
        // RVA: 0x030FB950  token: 0x6000198
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x09E65DCC  token: 0x6000199
        private UnityEngine.Vector4 GetRuntimeAtlasSpritePadding() { }
        // RVA: 0x09E65CC0  token: 0x600019A
        private UnityEngine.Vector4 GetRuntimeAtlasSpriteOuterUV() { }
        // RVA: 0x09E65A94  token: 0x600019B
        private UnityEngine.Vector4 GetRuntimeAtlasSpriteInnerUV() { }
        // RVA: 0x09E65968  token: 0x600019C
        public System.String GetParticlePath() { }
        // RVA: 0x025CA9D0  token: 0x600019E
        public System.Void RegisterDynamicAtlas() { }
        // RVA: 0x025CA340  token: 0x600019F
        public System.Void UnRegisterDynamicAtlas(UnityEngine.Sprite _sprite) { }
        // RVA: 0x02529DA0  token: 0x60001A0
        public System.Void RegisterDynamicAtlasCallBack(System.Action cb) { }
        // RVA: 0x0252A230  token: 0x60001A1
        public System.Void UnRegisterDynamicAtlasCallBack(System.Action cb) { }
        // RVA: 0x025C9090  token: 0x60001A2
        private static System.Void _CanvasRreWillRenderCanvases() { }
        // RVA: 0x038E2ED0  token: 0x60001A3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002E
    public interface IMask
    {
        // Properties
        UnityEngine.RectTransform rectTransform { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60001A5
        public virtual System.Boolean Enabled() { }

    }

    // TypeToken: 0x200002F
    public interface IMaskable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001A7
        public virtual System.Void RecalculateMasking() { }

    }

    // TypeToken: 0x2000030  // size: 0x2A0
    public class InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement
    {
        // Fields
        protected UnityEngine.TouchScreenKeyboard m_Keyboard;  // 0x180
        private static readonly System.Char[] kSeparators;  // static @ 0x0
        private static System.Boolean s_IsQuestDevice;  // static @ 0x8
        protected UnityEngine.UI.Text m_TextComponent;  // 0x188
        protected UnityEngine.UI.Graphic m_Placeholder;  // 0x190
        private UnityEngine.UI.InputField.ContentType m_ContentType;  // 0x198
        private UnityEngine.UI.InputField.InputType m_InputType;  // 0x19c
        private System.Char m_AsteriskChar;  // 0x1a0
        private UnityEngine.TouchScreenKeyboardType m_KeyboardType;  // 0x1a4
        private UnityEngine.UI.InputField.LineType m_LineType;  // 0x1a8
        private System.Boolean m_HideMobileInput;  // 0x1ac
        private UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;  // 0x1b0
        private System.Int32 m_CharacterLimit;  // 0x1b4
        private UnityEngine.UI.InputField.SubmitEvent m_OnSubmit;  // 0x1b8
        private UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit;  // 0x1c0
        private UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;  // 0x1c8
        private UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;  // 0x1d0
        private UnityEngine.Color m_CaretColor;  // 0x1d8
        private System.Boolean m_CustomCaretColor;  // 0x1e8
        private UnityEngine.Color m_SelectionColor;  // 0x1ec
        protected System.String m_Text;  // 0x200
        private System.Single m_CaretBlinkRate;  // 0x208
        private System.Int32 m_CaretWidth;  // 0x20c
        private System.Boolean m_ReadOnly;  // 0x210
        private System.Boolean m_ShouldActivateOnSelect;  // 0x211
        protected System.Int32 m_CaretPosition;  // 0x214
        protected System.Int32 m_CaretSelectPosition;  // 0x218
        private UnityEngine.RectTransform caretRectTrans;  // 0x220
        protected UnityEngine.UIVertex[] m_CursorVerts;  // 0x228
        private UnityEngine.TextGenerator m_InputTextCache;  // 0x230
        private UnityEngine.CanvasRenderer m_CachedInputRenderer;  // 0x238
        private System.Boolean m_PreventFontCallback;  // 0x240
        protected UnityEngine.Mesh m_Mesh;  // 0x248
        private System.Boolean m_AllowInput;  // 0x250
        private System.Boolean m_ShouldActivateNextUpdate;  // 0x251
        private System.Boolean m_UpdateDrag;  // 0x252
        private System.Boolean m_DragPositionOutOfBounds;  // 0x253
        private static System.Single kHScrollSpeed;  // const
        private static System.Single kVScrollSpeed;  // const
        protected System.Boolean m_CaretVisible;  // 0x254
        private UnityEngine.Coroutine m_BlinkCoroutine;  // 0x258
        private System.Single m_BlinkStartTime;  // 0x260
        protected System.Int32 m_DrawStart;  // 0x264
        protected System.Int32 m_DrawEnd;  // 0x268
        private UnityEngine.Coroutine m_DragCoroutine;  // 0x270
        private System.String m_OriginalText;  // 0x278
        private System.Boolean m_WasCanceled;  // 0x280
        private System.Boolean m_HasDoneFocusTransition;  // 0x281
        private UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;  // 0x288
        private System.Boolean m_TouchKeyboardAllowsInPlaceEditing;  // 0x290
        private System.Boolean m_IsCompositionActive;  // 0x291
        private static System.String kEmailSpecialCharacters;  // const
        private static System.String kOculusQuestDeviceModel;  // const
        private UnityEngine.Event m_ProcessingEvent;  // 0x298
        private static System.Int32 k_MaxTextLength;  // const

        // Properties
        UnityEngine.EventSystems.BaseInput input { get; /* RVA: 0x09F6D5C4 */ }
        System.String compositionString { get; /* RVA: 0x09F6D508 */ }
        UnityEngine.Mesh mesh { get; /* RVA: 0x09F6D694 */ }
        UnityEngine.TextGenerator cachedInputTextGenerator { get; /* RVA: 0x09F6D3E4 */ }
        System.Boolean shouldHideMobileInput { get; /* RVA: 0x09F6DA80 */ set; /* RVA: 0x09F6E18C */ }
        System.Boolean shouldActivateOnSelect { get; /* RVA: 0x09F6DA5C */ set; /* RVA: 0x03D89BA0 */ }
        System.String text { get; /* RVA: 0x03D56BB0 */ set; /* RVA: 0x09F6E494 */ }
        System.Boolean isFocused { get; /* RVA: 0x03D57B70 */ }
        System.Single caretBlinkRate { get; /* RVA: 0x03D59A50 */ set; /* RVA: 0x09F6DB0C */ }
        System.Int32 caretWidth { get; /* RVA: 0x03D84F00 */ set; /* RVA: 0x09F6DC14 */ }
        UnityEngine.UI.Text textComponent { get; /* RVA: 0x03D56AF0 */ set; /* RVA: 0x09F6E1D8 */ }
        UnityEngine.UI.Graphic placeholder { get; /* RVA: 0x03D56B70 */ set; /* RVA: 0x09F6E068 */ }
        UnityEngine.Color caretColor { get; /* RVA: 0x09F6D460 */ set; /* RVA: 0x09F6DB74 */ }
        System.Boolean customCaretColor { get; /* RVA: 0x03D57B80 */ set; /* RVA: 0x09F6DDBC */ }
        UnityEngine.Color selectionColor { get; /* RVA: 0x03D89B90 */ set; /* RVA: 0x09F6E100 */ }
        UnityEngine.UI.InputField.EndEditEvent onEndEdit { get; /* RVA: 0x03D571E0 */ set; /* RVA: 0x09F6DF30 */ }
        UnityEngine.UI.InputField.SubmitEvent onSubmit { get; /* RVA: 0x03D57130 */ set; /* RVA: 0x09F6DF7C */ }
        UnityEngine.UI.InputField.OnChangeEvent onValueChange { get; /* RVA: 0x03D571D0 */ set; /* RVA: 0x09F6E014 */ }
        UnityEngine.UI.InputField.OnChangeEvent onValueChanged { get; /* RVA: 0x03D571D0 */ set; /* RVA: 0x09F6E01C */ }
        UnityEngine.UI.InputField.OnValidateInput onValidateInput { get; /* RVA: 0x03D57000 */ set; /* RVA: 0x09F6DFC8 */ }
        System.Int32 characterLimit { get; /* RVA: 0x03D75FD0 */ set; /* RVA: 0x09F6DC70 */ }
        UnityEngine.UI.InputField.ContentType contentType { get; /* RVA: 0x03D59CC0 */ set; /* RVA: 0x09F6DD60 */ }
        UnityEngine.UI.InputField.LineType lineType { get; /* RVA: 0x03D583A0 */ set; /* RVA: 0x09F6DE8C */ }
        UnityEngine.UI.InputField.InputType inputType { get; /* RVA: 0x03D59CB0 */ set; /* RVA: 0x09F6DDD4 */ }
        UnityEngine.TouchScreenKeyboard touchScreenKeyboard { get; /* RVA: 0x03D56B50 */ }
        UnityEngine.TouchScreenKeyboardType keyboardType { get; /* RVA: 0x03D730A0 */ set; /* RVA: 0x09F6DE30 */ }
        UnityEngine.UI.InputField.CharacterValidation characterValidation { get; /* RVA: 0x03D84CB0 */ set; /* RVA: 0x09F6DD04 */ }
        System.Boolean readOnly { get; /* RVA: 0x03D58AD0 */ set; /* RVA: 0x03D58AE0 */ }
        System.Boolean multiLine { get; /* RVA: 0x09F6D738 */ }
        System.Char asteriskChar { get; /* RVA: 0x03D89B80 */ set; /* RVA: 0x09F6DAB0 */ }
        System.Boolean wasCanceled { get; /* RVA: 0x03D57C70 */ }
        System.Int32 caretPositionInternal { get; /* RVA: 0x09F6D4B0 */ set; /* RVA: 0x09F6DBB4 */ }
        System.Int32 caretSelectPositionInternal { get; /* RVA: 0x09F6D4DC */ set; /* RVA: 0x09F6DBFC */ }
        System.Boolean hasSelection { get; /* RVA: 0x09F6D594 */ }
        System.Int32 caretPosition { get; /* RVA: 0x09F6D4DC */ set; /* RVA: 0x09F6DBCC */ }
        System.Int32 selectionAnchorPosition { get; /* RVA: 0x09F6D4B0 */ set; /* RVA: 0x09F6E0B4 */ }
        System.Int32 selectionFocusPosition { get; /* RVA: 0x09F6D4DC */ set; /* RVA: 0x09F6E140 */ }
        System.String clipboard { get; /* RVA: 0x09D005B0 */ set; /* RVA: 0x09D00AB8 */ }
        System.Single minWidth { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredWidth { get; /* RVA: 0x09F6D8FC */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single minHeight { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredHeight { get; /* RVA: 0x09F6D750 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x09F6D1F0  token: 0x60001AA
        protected System.Void .ctor() { }
        // RVA: 0x09F6BCCC  token: 0x60001B3
        public System.Void SetTextWithoutNotify(System.String input) { }
        // RVA: 0x09F6BCD8  token: 0x60001B4
        private System.Void SetText(System.String value, System.Boolean sendCallback) { }
        // RVA: 0x09F66AB4  token: 0x60001E1
        protected System.Void ClampPos(System.Int32& pos) { }
        // RVA: 0x09F6A958  token: 0x60001ED
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F6A554  token: 0x60001EE
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F66A58  token: 0x60001EF
        private System.Collections.IEnumerator CaretBlink() { }
        // RVA: 0x09F6B6B8  token: 0x60001F0
        private System.Void SetCaretVisible() { }
        // RVA: 0x09F6B650  token: 0x60001F1
        private System.Void SetCaretActive() { }
        // RVA: 0x09F6C1CC  token: 0x60001F2
        private System.Void UpdateCaretMaterial() { }
        // RVA: 0x09F6AD68  token: 0x60001F3
        protected System.Void OnFocus() { }
        // RVA: 0x09F6B4A8  token: 0x60001F4
        protected System.Void SelectAll() { }
        // RVA: 0x09F6A398  token: 0x60001F5
        public System.Void MoveTextEnd(System.Boolean shift) { }
        // RVA: 0x09F6A3EC  token: 0x60001F6
        public System.Void MoveTextStart(System.Boolean shift) { }
        // RVA: 0x09F6C0B4  token: 0x60001F9
        private System.Boolean TouchScreenKeyboardShouldBeUsed() { }
        // RVA: 0x09F68874  token: 0x60001FA
        private System.Boolean InPlaceEditing() { }
        // RVA: 0x09F68810  token: 0x60001FB
        private System.Boolean InPlaceEditingChanged() { }
        // RVA: 0x09F6C11C  token: 0x60001FC
        private System.Void UpdateCaretFromKeyboard() { }
        // RVA: 0x09F68E40  token: 0x60001FD
        protected virtual System.Void LateUpdate() { }
        // RVA: 0x09F6B1D8  token: 0x60001FE
        public UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen) { }
        // RVA: 0x09F686AC  token: 0x60001FF
        private System.Int32 GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator) { }
        // RVA: 0x09F682C4  token: 0x6000200
        protected System.Int32 GetCharacterIndexFromPosition(UnityEngine.Vector2 pos) { }
        // RVA: 0x09F6A030  token: 0x6000201
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F6A508  token: 0x6000202
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F6A7A0  token: 0x6000203
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F6A0DC  token: 0x6000204
        private System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F6ABC8  token: 0x6000205
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F6AD98  token: 0x6000206
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F68A6C  token: 0x6000207
        protected UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt) { }
        // RVA: 0x09F68A0C  token: 0x6000208
        private System.Boolean IsValidChar(System.Char c) { }
        // RVA: 0x09F6B1C0  token: 0x6000209
        public System.Void ProcessEvent(UnityEngine.Event e) { }
        // RVA: 0x09F6B008  token: 0x600020A
        public virtual System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F68620  token: 0x600020B
        private System.String GetSelectedString() { }
        // RVA: 0x09F67240  token: 0x600020C
        private System.Int32 FindtNextWordBegin() { }
        // RVA: 0x09F6A2EC  token: 0x600020D
        private System.Void MoveRight(System.Boolean shift, System.Boolean ctrl) { }
        // RVA: 0x09F672FC  token: 0x600020E
        private System.Int32 FindtPrevWordBegin() { }
        // RVA: 0x09F6A240  token: 0x600020F
        private System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl) { }
        // RVA: 0x09F66FBC  token: 0x6000210
        private System.Int32 DetermineCharacterLine(System.Int32 charPos, UnityEngine.TextGenerator generator) { }
        // RVA: 0x09F69DDC  token: 0x6000211
        private System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar) { }
        // RVA: 0x09F69BEC  token: 0x6000212
        private System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar) { }
        // RVA: 0x09F6A234  token: 0x6000213
        private System.Void MoveDown(System.Boolean shift) { }
        // RVA: 0x09F6A150  token: 0x6000214
        private System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar) { }
        // RVA: 0x09F6A42C  token: 0x6000215
        private System.Void MoveUp(System.Boolean shift) { }
        // RVA: 0x09F6A438  token: 0x6000216
        private System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar) { }
        // RVA: 0x09F66DE4  token: 0x6000217
        private System.Void Delete() { }
        // RVA: 0x09F673B8  token: 0x6000218
        private System.Void ForwardSpace() { }
        // RVA: 0x09F66978  token: 0x6000219
        private System.Void Backspace() { }
        // RVA: 0x09F68898  token: 0x600021A
        private System.Void Insert(System.Char c) { }
        // RVA: 0x09F6CAD0  token: 0x600021B
        private System.Void UpdateTouchKeyboardFromEditChanges() { }
        // RVA: 0x09F6B5C0  token: 0x600021C
        private System.Void SendOnValueChangedAndUpdateLabel() { }
        // RVA: 0x09F6B5E0  token: 0x600021D
        private System.Void SendOnValueChanged() { }
        // RVA: 0x09F6B4E0  token: 0x600021E
        protected System.Void SendOnEndEdit() { }
        // RVA: 0x09F6B550  token: 0x600021F
        protected System.Void SendOnSubmit() { }
        // RVA: 0x09F661E0  token: 0x6000220
        protected virtual System.Void Append(System.String input) { }
        // RVA: 0x09F65F60  token: 0x6000221
        protected virtual System.Void Append(System.Char input) { }
        // RVA: 0x09F6C69C  token: 0x6000222
        protected System.Void UpdateLabel() { }
        // RVA: 0x09F689A0  token: 0x6000223
        private System.Boolean IsSelectionVisible() { }
        // RVA: 0x09F68578  token: 0x6000224
        private static System.Int32 GetLineStartPosition(UnityEngine.TextGenerator gen, System.Int32 line) { }
        // RVA: 0x09F684BC  token: 0x6000225
        private static System.Int32 GetLineEndPosition(UnityEngine.TextGenerator gen, System.Int32 line) { }
        // RVA: 0x09F6B6F8  token: 0x6000226
        private System.Void SetDrawRangeToContainCaretPosition(System.Int32 caretPos) { }
        // RVA: 0x09F673B0  token: 0x6000227
        public System.Void ForceLabelUpdate() { }
        // RVA: 0x09F69FE4  token: 0x6000228
        private System.Void MarkGeometryAsDirty() { }
        // RVA: 0x09F6B1C8  token: 0x6000229
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        // RVA: 0x0350B670  token: 0x600022A
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x600022B
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x09F6C2B0  token: 0x600022C
        private System.Void UpdateGeometry() { }
        // RVA: 0x09F66268  token: 0x600022D
        private System.Void AssignPositioningIfNeeded() { }
        // RVA: 0x09F6ABEC  token: 0x600022E
        private System.Void OnFillVBO(UnityEngine.Mesh vbo) { }
        // RVA: 0x09F67454  token: 0x600022F
        private System.Void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) { }
        // RVA: 0x09F66AE8  token: 0x6000230
        private System.Void CreateCursorVerts() { }
        // RVA: 0x09F67B14  token: 0x6000231
        private System.Void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) { }
        // RVA: 0x09F6CB18  token: 0x6000232
        protected System.Char Validate(System.String text, System.Int32 pos, System.Char ch) { }
        // RVA: 0x09F65E48  token: 0x6000233
        public System.Void ActivateInputField() { }
        // RVA: 0x09F65B2C  token: 0x6000234
        private System.Void ActivateInputFieldInternal() { }
        // RVA: 0x09F6AF88  token: 0x6000235
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F6AD70  token: 0x6000236
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F66C50  token: 0x6000237
        public System.Void DeactivateInputField() { }
        // RVA: 0x09F6A52C  token: 0x6000238
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F6AFC4  token: 0x6000239
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F6707C  token: 0x600023A
        private System.Void EnforceContentType() { }
        // RVA: 0x09F671AC  token: 0x600023B
        private System.Void EnforceTextHOverflow() { }
        // RVA: 0x09F6C04C  token: 0x600023C
        private System.Void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes) { }
        // RVA: 0x09F6C09C  token: 0x600023D
        private System.Void SetToCustom() { }
        // RVA: 0x09F67058  token: 0x600023E
        protected virtual System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant) { }
        // RVA: 0x0350B670  token: 0x600023F
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x6000240
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x09F6D154  token: 0x6000248
        private static System.Void .cctor() { }
        // RVA: 0x04273A88  token: 0x6000249
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200003C  // size: 0x30
    public class AspectRatioFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
    {
        // Fields
        private UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;  // 0x18
        private System.Single m_AspectRatio;  // 0x1c
        private UnityEngine.RectTransform m_Rect;  // 0x20
        private System.Boolean m_DelayedSetDirty;  // 0x28
        private System.Boolean m_DoesParentExist;  // 0x29
        private UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x2a

        // Properties
        UnityEngine.UI.AspectRatioFitter.AspectMode aspectMode { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x09F65530 */ }
        System.Single aspectRatio { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x09F65588 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x033BCC80 */ }

        // Methods
        // RVA: 0x03B45ED0  token: 0x6000262
        protected System.Void .ctor() { }
        // RVA: 0x033BC860  token: 0x6000263
        protected virtual System.Void OnEnable() { }
        // RVA: 0x033BC650  token: 0x6000264
        protected virtual System.Void Start() { }
        // RVA: 0x033BC910  token: 0x6000265
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F654B0  token: 0x6000266
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x036515F0  token: 0x6000267
        protected virtual System.Void Update() { }
        // RVA: 0x033BC970  token: 0x6000268
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x033BC980  token: 0x6000269
        private System.Void UpdateRect() { }
        // RVA: 0x033BC690  token: 0x600026A
        private System.Single GetSizeDeltaToProduceSize(System.Single size, System.Int32 axis) { }
        // RVA: 0x033BC790  token: 0x600026B
        private UnityEngine.Vector2 GetParentSize() { }
        // RVA: 0x0350B670  token: 0x600026C
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x0350B670  token: 0x600026D
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x033BC970  token: 0x600026E
        protected System.Void SetDirty() { }
        // RVA: 0x033BCD10  token: 0x600026F
        public System.Boolean IsComponentValidOnObject() { }
        // RVA: 0x033BC680  token: 0x6000270
        public System.Boolean IsAspectModeValid() { }
        // RVA: 0x03D4F2A0  token: 0x6000271
        private System.Boolean DoesParentExists() { }

    }

    // TypeToken: 0x200003E  // size: 0x60
    public class CanvasScaler : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;  // 0x18
        protected System.Single m_ReferencePixelsPerUnit;  // 0x1c
        protected System.Single m_ScaleFactor;  // 0x20
        protected UnityEngine.Vector2 m_ReferenceResolution;  // 0x24
        protected UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;  // 0x2c
        protected System.Single m_MatchWidthOrHeight;  // 0x30
        private static System.Single kLogBase;  // const
        protected UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;  // 0x34
        protected System.Single m_FallbackScreenDPI;  // 0x38
        protected System.Single m_DefaultSpriteDPI;  // 0x3c
        protected System.Single m_DynamicPixelsPerUnit;  // 0x40
        private UnityEngine.Canvas m_Canvas;  // 0x48
        private System.Single m_PrevScaleFactor;  // 0x50
        private System.Single m_PrevReferencePixelsPerUnit;  // 0x54
        protected System.Boolean m_PresetInfoIsWorld;  // 0x58

        // Properties
        UnityEngine.UI.CanvasScaler.ScaleMode uiScaleMode { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Single referencePixelsPerUnit { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        System.Single scaleFactor { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x09F6569C */ }
        UnityEngine.Vector2 referenceResolution { get; /* RVA: 0x03D50A80 */ set; /* RVA: 0x027FF6C0 */ }
        UnityEngine.UI.CanvasScaler.ScreenMatchMode screenMatchMode { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }
        System.Single matchWidthOrHeight { get; /* RVA: 0x03D4F5D0 */ set; /* RVA: 0x03D4F5E0 */ }
        UnityEngine.UI.CanvasScaler.Unit physicalUnit { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x03D4EE40 */ }
        System.Single fallbackScreenDPI { get; /* RVA: 0x03D51000 */ set; /* RVA: 0x03D51010 */ }
        System.Single defaultSpriteDPI { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x09F65688 */ }
        System.Single dynamicPixelsPerUnit { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x03D4ECF0 */ }

        // Methods
        // RVA: 0x0352E5B0  token: 0x6000286
        protected System.Void .ctor() { }
        // RVA: 0x02473670  token: 0x6000287
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02373580  token: 0x6000288
        private System.Void Canvas_preWillRenderCanvases() { }
        // RVA: 0x02472550  token: 0x6000289
        protected virtual System.Void OnDisable() { }
        // RVA: 0x027FE790  token: 0x600028A
        public System.Void HandleManually() { }
        // RVA: 0x023737A0  token: 0x600028B
        protected virtual System.Void Handle() { }
        // RVA: 0x02FEC020  token: 0x600028C
        protected virtual System.Void HandleWorldCanvas() { }
        // RVA: 0x03D47B30  token: 0x600028D
        protected virtual System.Void HandleConstantPixelSize() { }
        // RVA: 0x02375490  token: 0x600028E
        protected virtual System.Void HandleScaleWithScreenSize() { }
        // RVA: 0x09F655E4  token: 0x600028F
        protected virtual System.Void HandleConstantPhysicalSize() { }
        // RVA: 0x02373A90  token: 0x6000290
        protected System.Void SetScaleFactor(System.Single scaleFactor) { }
        // RVA: 0x02373AE0  token: 0x6000291
        protected System.Void SetReferencePixelsPerUnit(System.Single referencePixelsPerUnit) { }

    }

    // TypeToken: 0x2000042  // size: 0x30
    public class ContentSizeFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
    {
        // Fields
        protected UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;  // 0x18
        protected UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;  // 0x1c
        private UnityEngine.RectTransform m_Rect;  // 0x20
        private UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x28

        // Properties
        UnityEngine.UI.ContentSizeFitter.FitMode horizontalFit { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x0259D3B0 */ }
        UnityEngine.UI.ContentSizeFitter.FitMode verticalFit { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x09F656B0 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x0259FEA0 */ }

        // Methods
        // RVA: 0x0426FE60  token: 0x6000297
        protected System.Void .ctor() { }
        // RVA: 0x0259E3B0  token: 0x6000298
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0259E350  token: 0x6000299
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0259E3B0  token: 0x600029A
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x0259FE10  token: 0x600029B
        private System.Void HandleSelfFittingAlongAxis(System.Int32 axis) { }
        // RVA: 0x0259FDA0  token: 0x600029C
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x0427071C  token: 0x600029D
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x0259E560  token: 0x600029E
        protected System.Void SetDirty() { }

    }

    // TypeToken: 0x2000044  // size: 0x78
    public class GridLayoutGroup : UnityEngine.UI.LayoutGroup
    {
        // Fields
        protected UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;  // 0x58
        protected UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;  // 0x5c
        protected UnityEngine.Vector2 m_CellSize;  // 0x60
        protected UnityEngine.Vector2 m_Spacing;  // 0x68
        protected UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;  // 0x70
        protected System.Int32 m_ConstraintCount;  // 0x74

        // Properties
        UnityEngine.UI.GridLayoutGroup.Corner startCorner { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x09F65900 */ }
        UnityEngine.UI.GridLayoutGroup.Axis startAxis { get; /* RVA: 0x03D4EEF0 */ set; /* RVA: 0x09F658B4 */ }
        UnityEngine.Vector2 cellSize { get; /* RVA: 0x03D89B40 */ set; /* RVA: 0x09F65760 */ }
        UnityEngine.Vector2 spacing { get; /* RVA: 0x03D89B60 */ set; /* RVA: 0x09F65860 */ }
        UnityEngine.UI.GridLayoutGroup.Constraint constraint { get; /* RVA: 0x03D4F0C0 */ set; /* RVA: 0x09F65814 */ }
        System.Int32 constraintCount { get; /* RVA: 0x03D4F0D0 */ set; /* RVA: 0x09F657B4 */ }

        // Methods
        // RVA: 0x02849F60  token: 0x60002AB
        protected System.Void .ctor() { }
        // RVA: 0x036BE620  token: 0x60002AC
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x02EE1740  token: 0x60002AD
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x09F65744  token: 0x60002AE
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x09F65750  token: 0x60002AF
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x03497880  token: 0x60002B0
        private System.Void SetCellsAlongAxis(System.Int32 axis) { }

    }

    // TypeToken: 0x2000048  // size: 0x68
    public class HorizontalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        // Methods
        // RVA: 0x0335B640  token: 0x60002B1
        protected System.Void .ctor() { }
        // RVA: 0x024A55E0  token: 0x60002B2
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x042745E0  token: 0x60002B3
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x042706EC  token: 0x60002B4
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x042706DC  token: 0x60002B5
        public virtual System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x2000049  // size: 0x68
    public abstract class HorizontalOrVerticalLayoutGroup : UnityEngine.UI.LayoutGroup
    {
        // Fields
        protected System.Single m_Spacing;  // 0x58
        protected System.Boolean m_ChildForceExpandWidth;  // 0x5c
        protected System.Boolean m_ChildForceExpandHeight;  // 0x5d
        protected System.Boolean m_ChildControlWidth;  // 0x5e
        protected System.Boolean m_ChildControlHeight;  // 0x5f
        protected System.Boolean m_ChildScaleWidth;  // 0x60
        protected System.Boolean m_ChildScaleHeight;  // 0x61
        protected System.Boolean m_ReverseArrangement;  // 0x62

        // Properties
        System.Single spacing { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x03C7DF90 */ }
        System.Boolean childForceExpandWidth { get; /* RVA: 0x03D4F600 */ set; /* RVA: 0x03641ED0 */ }
        System.Boolean childForceExpandHeight { get; /* RVA: 0x03D71350 */ set; /* RVA: 0x09F659EC */ }
        System.Boolean childControlWidth { get; /* RVA: 0x03D71370 */ set; /* RVA: 0x09F6599C */ }
        System.Boolean childControlHeight { get; /* RVA: 0x03D57680 */ set; /* RVA: 0x09F6594C */ }
        System.Boolean childScaleWidth { get; /* RVA: 0x03D519A0 */ set; /* RVA: 0x09F65A8C */ }
        System.Boolean childScaleHeight { get; /* RVA: 0x03D51F90 */ set; /* RVA: 0x09F65A3C */ }
        System.Boolean reverseArrangement { get; /* RVA: 0x03D5B400 */ set; /* RVA: 0x09F65ADC */ }

        // Methods
        // RVA: 0x024A8150  token: 0x60002C6
        protected System.Void CalcAlongAxis(System.Int32 axis, System.Boolean isVertical) { }
        // RVA: 0x024A7280  token: 0x60002C7
        protected System.Void SetChildrenAlongAxis(System.Int32 axis, System.Boolean isVertical) { }
        // RVA: 0x024A87E0  token: 0x60002C8
        private System.Void GetChildSizes(UnityEngine.RectTransform child, System.Int32 axis, System.Boolean controlSize, System.Boolean childForceExpand, System.Single& min, System.Single& preferred, System.Single& flexible) { }
        // RVA: 0x0335B640  token: 0x60002C9
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public interface ILayoutElement
    {
        // Properties
        System.Single minWidth { get; /* RVA: -1  // abstract */ }
        System.Single preferredWidth { get; /* RVA: -1  // abstract */ }
        System.Single flexibleWidth { get; /* RVA: -1  // abstract */ }
        System.Single minHeight { get; /* RVA: -1  // abstract */ }
        System.Single preferredHeight { get; /* RVA: -1  // abstract */ }
        System.Single flexibleHeight { get; /* RVA: -1  // abstract */ }
        System.Int32 layoutPriority { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60002CA
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: -1  // abstract  token: 0x60002CB
        public virtual System.Void CalculateLayoutInputVertical() { }

    }

    // TypeToken: 0x200004B
    public interface ILayoutController
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60002D3
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: -1  // abstract  token: 0x60002D4
        public virtual System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x200004C
    public interface ILayoutGroup : UnityEngine.UI.ILayoutController
    {
    }

    // TypeToken: 0x200004D
    public interface ILayoutSelfController : UnityEngine.UI.ILayoutController
    {
    }

    // TypeToken: 0x200004E
    public interface ILayoutIgnorer
    {
        // Properties
        System.Boolean ignoreLayout { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200004F  // size: 0x38
    public class LayoutElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutIgnorer
    {
        // Fields
        private System.Boolean m_IgnoreLayout;  // 0x18
        private System.Single m_MinWidth;  // 0x1c
        private System.Single m_MinHeight;  // 0x20
        private System.Single m_PreferredWidth;  // 0x24
        private System.Single m_PreferredHeight;  // 0x28
        private System.Single m_FlexibleWidth;  // 0x2c
        private System.Single m_FlexibleHeight;  // 0x30
        private System.Int32 m_LayoutPriority;  // 0x34

        // Properties
        System.Boolean ignoreLayout { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x022BF6C0 */ }
        System.Single minWidth { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x09F6E5B0 */ }
        System.Single minHeight { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x09F6E554 */ }
        System.Single preferredWidth { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x02CD0CC0 */ }
        System.Single preferredHeight { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x02CD1420 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D4F3A0 */ set; /* RVA: 0x03197A10 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D4F5D0 */ set; /* RVA: 0x09F6E4A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x09F6E4FC */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60002D8
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x60002D9
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x031659C0  token: 0x60002E8
        protected System.Void .ctor() { }
        // RVA: 0x02CD1270  token: 0x60002E9
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02CD1270  token: 0x60002EA
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x02CD1270  token: 0x60002EB
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02CD1270  token: 0x60002EC
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x02CD1270  token: 0x60002ED
        protected virtual System.Void OnBeforeTransformParentChanged() { }
        // RVA: 0x02CD1280  token: 0x60002EE
        protected System.Void SetDirty() { }

    }

    // TypeToken: 0x2000050  // size: 0x58
    public abstract class LayoutGroup : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
    {
        // Fields
        protected UnityEngine.RectOffset m_Padding;  // 0x18
        protected UnityEngine.TextAnchor m_ChildAlignment;  // 0x20
        private UnityEngine.RectTransform m_Rect;  // 0x28
        protected UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x30
        private UnityEngine.Vector2 m_TotalMinSize;  // 0x34
        private UnityEngine.Vector2 m_TotalPreferredSize;  // 0x3c
        private UnityEngine.Vector2 m_TotalFlexibleSize;  // 0x44
        private System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren;  // 0x50

        // Properties
        UnityEngine.RectOffset padding { get; /* RVA: 0x01041090 */ set; /* RVA: 0x02CD1220 */ }
        UnityEngine.TextAnchor childAlignment { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x09F6E6AC */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x024A68A0 */ }
        System.Collections.Generic.List<UnityEngine.RectTransform> rectChildren { get; /* RVA: 0x03D4EAF0 */ }
        System.Single minWidth { get; /* RVA: 0x042743D0 */ }
        System.Single preferredWidth { get; /* RVA: 0x04270790 */ }
        System.Single flexibleWidth { get; /* RVA: 0x04270750 */ }
        System.Single minHeight { get; /* RVA: 0x04270730 */ }
        System.Single preferredHeight { get; /* RVA: 0x04270740 */ }
        System.Single flexibleHeight { get; /* RVA: 0x04270760 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01002730 */ }
        System.Boolean isRootLayoutGroup { get; /* RVA: 0x024A4C20 */ }

        // Methods
        // RVA: 0x024A61E0  token: 0x60002F5
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: -1  // abstract  token: 0x60002F6
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: -1  // abstract  token: 0x60002FE
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: -1  // abstract  token: 0x60002FF
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x028495F0  token: 0x6000300
        protected System.Void .ctor() { }
        // RVA: 0x024A3500  token: 0x6000301
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0338BEE0  token: 0x6000302
        protected virtual System.Void OnDisable() { }
        // RVA: 0x024A3500  token: 0x6000303
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x042700B8  token: 0x6000304
        protected System.Single GetTotalMinSize(System.Int32 axis) { }
        // RVA: 0x042700C4  token: 0x6000305
        protected System.Single GetTotalPreferredSize(System.Int32 axis) { }
        // RVA: 0x09F6E60C  token: 0x6000306
        protected System.Single GetTotalFlexibleSize(System.Int32 axis) { }
        // RVA: 0x024A6000  token: 0x6000307
        protected System.Single GetStartOffset(System.Int32 axis, System.Single requiredSpaceWithoutPadding) { }
        // RVA: 0x024A69D0  token: 0x6000308
        protected System.Single GetAlignmentOnAxis(System.Int32 axis) { }
        // RVA: 0x024A6E90  token: 0x6000309
        protected System.Void SetLayoutInputForAxis(System.Single totalMin, System.Single totalPreferred, System.Single totalFlexible, System.Int32 axis) { }
        // RVA: 0x09F6E618  token: 0x600030A
        protected System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos) { }
        // RVA: 0x024A5CB0  token: 0x600030B
        protected System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single scaleFactor) { }
        // RVA: 0x03497DD0  token: 0x600030C
        protected System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size) { }
        // RVA: 0x024A6AC0  token: 0x600030D
        protected System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size, System.Single scaleFactor) { }
        // RVA: 0x024A4BF0  token: 0x600030F
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x024A3500  token: 0x6000310
        protected virtual System.Void OnTransformChildrenChanged() { }
        // RVA: -1  // generic def  token: 0x6000311
        protected System.Void SetProperty(T& currentValue, T newValue) { }
        // RVA: 0x024A52C0  token: 0x6000312
        protected System.Void SetDirty() { }
        // RVA: 0x024A4550  token: 0x6000313
        private System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform) { }

    }

    // TypeToken: 0x2000052  // size: 0x20
    public class LayoutRebuilder : UnityEngine.UI.ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_ToRebuild;  // 0x10
        private System.Int32 m_CachedHashFromTransform;  // 0x18
        private static UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;  // static @ 0x0

        // Properties
        UnityEngine.Transform transform { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x0239D060  token: 0x600031A
        private System.Void Initialize(UnityEngine.RectTransform controller) { }
        // RVA: 0x0426F864  token: 0x600031B
        private System.Void Clear() { }
        // RVA: 0x038E4060  token: 0x600031C
        private static System.Void .cctor() { }
        // RVA: 0x0304E030  token: 0x600031D
        private static System.Void ReapplyDrivenProperties(UnityEngine.RectTransform driven) { }
        // RVA: 0x03322AC0  token: 0x600031F
        public virtual System.Boolean IsDestroyed() { }
        // RVA: 0x0251E100  token: 0x6000320
        private static System.Void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }
        // RVA: 0x02B7C240  token: 0x6000321
        public static System.Void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot) { }
        // RVA: 0x02B7C330  token: 0x6000322
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x02B7C6F0  token: 0x6000323
        private System.Void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }
        // RVA: 0x0251D780  token: 0x6000324
        private System.Void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }
        // RVA: 0x0251B890  token: 0x6000325
        public static System.Void MarkLayoutForRebuild(UnityEngine.RectTransform rect) { }
        // RVA: 0x0251E350  token: 0x6000326
        private static System.Boolean ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }
        // RVA: 0x0239CE40  token: 0x6000327
        private static System.Void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller) { }
        // RVA: 0x0329DBF0  token: 0x6000328
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x6000329
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x020D1AC0  token: 0x600032A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x02F82620  token: 0x600032B
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F6E6F8  token: 0x600032C
        public virtual System.String ToString() { }
        // RVA: 0x0350B670  token: 0x600032D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x10
    public static class LayoutUtility
    {
        // Methods
        // RVA: 0x024A8C80  token: 0x6000337
        public static System.Single GetMinSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        // RVA: 0x024A8B20  token: 0x6000338
        public static System.Single GetPreferredSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        // RVA: 0x024A8B50  token: 0x6000339
        public static System.Single GetFlexibleSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        // RVA: 0x024A7160  token: 0x600033A
        public static System.Single GetMinWidth(UnityEngine.RectTransform rect) { }
        // RVA: 0x024A8DB0  token: 0x600033B
        public static System.Single GetPreferredWidth(UnityEngine.RectTransform rect) { }
        // RVA: 0x024A7040  token: 0x600033C
        public static System.Single GetFlexibleWidth(UnityEngine.RectTransform rect) { }
        // RVA: 0x02F5C880  token: 0x600033D
        public static System.Single GetMinHeight(UnityEngine.RectTransform rect) { }
        // RVA: 0x02F5CAC0  token: 0x600033E
        public static System.Single GetPreferredHeight(UnityEngine.RectTransform rect) { }
        // RVA: 0x02F5C9A0  token: 0x600033F
        public static System.Single GetFlexibleHeight(UnityEngine.RectTransform rect) { }
        // RVA: 0x04270124  token: 0x6000340
        public static System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue) { }
        // RVA: 0x02517DC0  token: 0x6000341
        public static System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue, UnityEngine.UI.ILayoutElement& source) { }

    }

    // TypeToken: 0x2000056  // size: 0x68
    public class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        // Methods
        // RVA: 0x0335B640  token: 0x600034C
        protected System.Void .ctor() { }
        // RVA: 0x024A4BC0  token: 0x600034D
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x042745F0  token: 0x600034E
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x0427070C  token: 0x600034F
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x042706FC  token: 0x6000350
        public virtual System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x2000057  // size: 0x40
    public class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
    {
        // Fields
        private UnityEngine.RectTransform m_RectTransform;  // 0x18
        private System.Boolean m_ShowMaskGraphic;  // 0x20
        private UnityEngine.UI.Graphic m_Graphic;  // 0x28
        private UnityEngine.Material m_MaskMaterial;  // 0x30
        private UnityEngine.Material m_UnmaskMaterial;  // 0x38

        // Properties
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x02516120 */ }
        System.Boolean showMaskGraphic { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x09F6E758 */ }
        UnityEngine.UI.Graphic graphic { get; /* RVA: 0x025167D0 */ }

        // Methods
        // RVA: 0x03A1E660  token: 0x6000355
        protected System.Void .ctor() { }
        // RVA: 0x02516230  token: 0x6000356
        public virtual System.Boolean MaskEnabled() { }
        // RVA: 0x0350B670  token: 0x6000357
        public virtual System.Void OnSiblingGraphicEnabledDisabled() { }
        // RVA: 0x02516680  token: 0x6000358
        protected virtual System.Void OnEnable() { }
        // RVA: 0x025162B0  token: 0x6000359
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02516080  token: 0x600035A
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x02516490  token: 0x600035B
        public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }

    }

    // TypeToken: 0x2000058  // size: 0xE8
    public abstract class MaskableGraphic : UnityEngine.UI.Graphic, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier
    {
        // Fields
        protected System.Boolean m_ShouldRecalculateStencil;  // 0xb0
        protected UnityEngine.Material m_MaskMaterial;  // 0xb8
        private UnityEngine.UI.RectMask2D m_ParentMask;  // 0xc0
        private System.Boolean m_Maskable;  // 0xc8
        private System.Boolean m_IsMaskingGraphic;  // 0xc9
        protected System.Boolean m_IncludeForMasking;  // 0xca
        private UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;  // 0xd0
        protected System.Boolean m_ShouldRecalculate;  // 0xd8
        protected System.Int32 m_StencilValue;  // 0xdc
        private readonly UnityEngine.Vector3[] m_Corners;  // 0xe0

        // Properties
        UnityEngine.UI.MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        System.Boolean maskable { get; /* RVA: 0x03D519D0 */ set; /* RVA: 0x09F6E7E4 */ }
        System.Boolean isMaskingGraphic { get; /* RVA: 0x03D58400 */ set; /* RVA: 0x02515FD0 */ }
        UnityEngine.Rect rootCanvasRect { get; /* RVA: 0x02347550 */ }

        // Methods
        // RVA: 0x025C75E0  token: 0x6000362
        public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        // RVA: 0x02342020  token: 0x6000363
        public virtual System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        // RVA: 0x02341DF0  token: 0x6000364
        private System.Void UpdateCull(System.Boolean cull) { }
        // RVA: 0x02EC41E0  token: 0x6000365
        public virtual System.Void SetClipRect(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        // RVA: 0x02341BC0  token: 0x6000366
        public virtual System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness) { }
        // RVA: 0x02341AF0  token: 0x6000367
        public virtual System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness) { }
        // RVA: 0x0239A120  token: 0x6000368
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0239F4B0  token: 0x6000369
        protected virtual System.Void OnDisable() { }
        // RVA: 0x03163550  token: 0x600036A
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x0350B670  token: 0x600036B
        public virtual System.Void ParentMaskStateChanged() { }
        // RVA: 0x025A1D50  token: 0x600036C
        protected virtual System.Void OnCanvasHierarchyChanged() { }
        // RVA: 0x0239A170  token: 0x600036E
        private System.Void UpdateClipParent() { }
        // RVA: 0x02515D70  token: 0x600036F
        public virtual System.Void RecalculateClipping() { }
        // RVA: 0x0239F2E0  token: 0x6000370
        public virtual System.Void RecalculateMasking() { }
        // RVA: 0x02433960  token: 0x6000371
        protected System.Void .ctor() { }
        // RVA: 0x0426FB4C  token: 0x6000372
        private virtual UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject() { }

    }

    // TypeToken: 0x200005A  // size: 0x10
    public class MaskUtilities
    {
        // Methods
        // RVA: 0x02518C70  token: 0x6000374
        public static System.Void Notify2DMaskStateChanged(UnityEngine.Component mask) { }
        // RVA: 0x025168D0  token: 0x6000375
        public static System.Void NotifyStencilStateChanged(UnityEngine.Component mask) { }
        // RVA: 0x02517670  token: 0x6000376
        public static UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start) { }
        // RVA: 0x0251E990  token: 0x6000377
        public static System.Int32 GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter) { }
        // RVA: 0x0251CDF0  token: 0x6000378
        public static System.Boolean IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child) { }
        // RVA: 0x0239A3E0  token: 0x6000379
        public static UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable) { }
        // RVA: 0x02516EE0  token: 0x600037A
        public static System.Void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }
        // RVA: 0x0350B670  token: 0x600037B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public interface IMaterialModifier
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600037C
        public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }

    }

    // TypeToken: 0x200005C  // size: 0x10
    public static class Misc
    {
        // Methods
        // RVA: 0x09F6F368  token: 0x600037D
        public static System.Void Destroy(UnityEngine.Object obj) { }
        // RVA: 0x039B53E0  token: 0x600037E
        public static System.Void DestroyImmediate(UnityEngine.Object obj) { }

    }

    // TypeToken: 0x200005D  // size: 0x10
    public static class MultipleDisplayUtilities
    {
        // Methods
        // RVA: 0x09F6F434  token: 0x600037F
        public static System.Boolean GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Vector2& position) { }
        // RVA: 0x0256C470  token: 0x6000380
        public static UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position) { }

    }

    // TypeToken: 0x200005E  // size: 0x38
    public sealed struct Navigation : System.IEquatable`1
    {
        // Fields
        private UnityEngine.UI.Navigation.Mode m_Mode;  // 0x10
        private System.Boolean m_WrapAround;  // 0x14
        private UnityEngine.UI.Selectable m_SelectOnUp;  // 0x18
        private UnityEngine.UI.Selectable m_SelectOnDown;  // 0x20
        private UnityEngine.UI.Selectable m_SelectOnLeft;  // 0x28
        private UnityEngine.UI.Selectable m_SelectOnRight;  // 0x30

        // Properties
        UnityEngine.UI.Navigation.Mode mode { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Boolean wrapAround { get; /* RVA: 0x03D55A00 */ set; /* RVA: 0x03D5DDF0 */ }
        UnityEngine.UI.Selectable selectOnUp { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.UI.Selectable selectOnDown { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.UI.Selectable selectOnLeft { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.UI.Selectable selectOnRight { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        UnityEngine.UI.Navigation defaultNavigation { get; /* RVA: 0x03D89BF0 */ }

        // Methods
        // RVA: 0x0314FF60  token: 0x600038E
        public virtual System.Boolean Equals(UnityEngine.UI.Navigation other) { }

    }

    // TypeToken: 0x2000060  // size: 0x100
    public class RawImage : UnityEngine.UI.MaskableGraphic
    {
        // Fields
        private UnityEngine.Texture m_Texture;  // 0xe8
        private UnityEngine.Rect m_UVRect;  // 0xf0

        // Properties
        UnityEngine.Texture mainTexture { get; /* RVA: 0x033F9BE0 */ }
        UnityEngine.Texture texture { get; /* RVA: 0x03D50EA0 */ set; /* RVA: 0x035ED400 */ }
        UnityEngine.Rect uvRect { get; /* RVA: 0x03D6C080 */ set; /* RVA: 0x09F6F644 */ }

        // Methods
        // RVA: 0x02700780  token: 0x600038F
        protected System.Void .ctor() { }
        // RVA: 0x09F6F50C  token: 0x6000395
        public virtual System.Void SetNativeSize() { }
        // RVA: 0x031EA390  token: 0x6000396
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x030FB950  token: 0x6000397
        protected virtual System.Void OnDidApplyAnimationProperties() { }

    }

    // TypeToken: 0x2000061  // size: 0x98
    public class RectMask2D : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IClipper, UnityEngine.ICanvasRaycastFilter
    {
        // Fields
        private readonly UnityEngine.UI.RectangularVertexClipper m_VertexClipper;  // 0x18
        private UnityEngine.RectTransform m_RectTransform;  // 0x20
        private System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets;  // 0x28
        private System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets;  // 0x30
        private System.Boolean m_ShouldRecalculateClipRects;  // 0x38
        private System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers;  // 0x40
        private UnityEngine.Rect m_LastClipRectCanvasSpace;  // 0x48
        private System.Boolean m_ForceClip;  // 0x58
        private UnityEngine.Vector4 m_Padding;  // 0x5c
        private UnityEngine.Vector2Int m_Softness;  // 0x6c
        private UnityEngine.Vector4 m_HGSoftness;  // 0x74
        private UnityEngine.Canvas m_Canvas;  // 0x88
        private UnityEngine.Vector3[] m_Corners;  // 0x90

        // Properties
        UnityEngine.Vector4 padding { get; /* RVA: 0x03D73B30 */ set; /* RVA: 0x09F6FB38 */ }
        UnityEngine.Vector2Int softness { get; /* RVA: 0x03D55B60 */ set; /* RVA: 0x09F6FB48 */ }
        UnityEngine.Vector4 hgSoftness { get; /* RVA: 0x03D5D5D0 */ set; /* RVA: 0x09F6FAF8 */ }
        UnityEngine.Canvas Canvas { get; /* RVA: 0x0233F1D0 */ }
        UnityEngine.Rect canvasRect { get; /* RVA: 0x0233EBC0 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x0233EE90 */ }
        UnityEngine.Rect rootCanvasRect { get; /* RVA: 0x02343A80 */ }

        // Methods
        // RVA: 0x03294A20  token: 0x60003A1
        protected System.Void .ctor() { }
        // RVA: 0x02516DA0  token: 0x60003A2
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02516CA0  token: 0x60003A3
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02517200  token: 0x60003A4
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x023408B0  token: 0x60003A6
        public virtual System.Void PerformClipping() { }
        // RVA: 0x02341600  token: 0x60003A7
        public virtual System.Void UpdateClipSoftness() { }
        // RVA: 0x0308CBA0  token: 0x60003A8
        public System.Void AddClippable(UnityEngine.UI.IClippable clippable) { }
        // RVA: 0x02EC3E40  token: 0x60003A9
        public System.Void RemoveClippable(UnityEngine.UI.IClippable clippable) { }
        // RVA: 0x03D5C330  token: 0x60003AA
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x0352D200  token: 0x60003AB
        protected virtual System.Void OnCanvasHierarchyChanged() { }

    }

    // TypeToken: 0x2000062  // size: 0x1C8
    public class Scrollbar : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_HandleRect;  // 0x180
        private UnityEngine.UI.Scrollbar.Direction m_Direction;  // 0x188
        private System.Single m_Value;  // 0x18c
        private System.Single m_Size;  // 0x190
        private System.Int32 m_NumberOfSteps;  // 0x194
        private UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;  // 0x198
        private UnityEngine.RectTransform m_ContainerRect;  // 0x1a0
        private UnityEngine.Vector2 m_Offset;  // 0x1a8
        private UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x1b0
        private UnityEngine.Coroutine m_PointerDownRepeat;  // 0x1b8
        private System.Boolean isPointerDownAndNotDragging;  // 0x1c0
        private System.Boolean m_DelayedUpdateVisuals;  // 0x1c1

        // Properties
        UnityEngine.RectTransform handleRect { get; /* RVA: 0x03D56B50 */ set; /* RVA: 0x09F71C2C */ }
        UnityEngine.UI.Scrollbar.Direction direction { get; /* RVA: 0x03D4FC10 */ set; /* RVA: 0x09F71BD0 */ }
        System.Single value { get; /* RVA: 0x02C6D150 */ set; /* RVA: 0x04271E08 */ }
        System.Single size { get; /* RVA: 0x03D58260 */ set; /* RVA: 0x028C2090 */ }
        System.Int32 numberOfSteps { get; /* RVA: 0x03D89C40 */ set; /* RVA: 0x09F71C94 */ }
        UnityEngine.UI.Scrollbar.ScrollEvent onValueChanged { get; /* RVA: 0x03D56AE0 */ set; /* RVA: 0x04275BC0 */ }
        System.Single stepSize { get; /* RVA: 0x09F71BA0 */ }
        UnityEngine.UI.Scrollbar.Axis axis { get; /* RVA: 0x02C6D060 */ }
        System.Boolean reverseValue { get; /* RVA: 0x02C6D180 */ }

        // Methods
        // RVA: 0x02848F90  token: 0x60003B0
        protected System.Void .ctor() { }
        // RVA: 0x09F71910  token: 0x60003B3
        public virtual System.Void SetValueWithoutNotify(System.Single input) { }
        // RVA: 0x0350B670  token: 0x60003BB
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x0350B670  token: 0x60003BC
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x60003BD
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x03916020  token: 0x60003BE
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0361D5F0  token: 0x60003BF
        protected virtual System.Void OnDisable() { }
        // RVA: 0x038DDF60  token: 0x60003C0
        protected virtual System.Void Update() { }
        // RVA: 0x03916060  token: 0x60003C1
        private System.Void UpdateCachedReferences() { }
        // RVA: 0x02C6D080  token: 0x60003C2
        private System.Void Set(System.Single input, System.Boolean sendCallback) { }
        // RVA: 0x03B0D650  token: 0x60003C3
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x02C6CED0  token: 0x60003C6
        private System.Void UpdateVisuals() { }
        // RVA: 0x09F7191C  token: 0x60003C7
        private System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F710B8  token: 0x60003C8
        private System.Void DoUpdateDrag(UnityEngine.Vector2 handleCorner, System.Single remainingSize) { }
        // RVA: 0x09F711F4  token: 0x60003C9
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F71248  token: 0x60003CA
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F71458  token: 0x60003CB
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F716EC  token: 0x60003CC
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F71040  token: 0x60003CD
        protected System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F70FB0  token: 0x60003CE
        protected System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera) { }
        // RVA: 0x09F717B4  token: 0x60003CF
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F714FC  token: 0x60003D0
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        // RVA: 0x09F71158  token: 0x60003D1
        public virtual UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        // RVA: 0x09F7118C  token: 0x60003D2
        public virtual UnityEngine.UI.Selectable FindSelectableOnRight() { }
        // RVA: 0x09F711C0  token: 0x60003D3
        public virtual UnityEngine.UI.Selectable FindSelectableOnUp() { }
        // RVA: 0x09F71124  token: 0x60003D4
        public virtual UnityEngine.UI.Selectable FindSelectableOnDown() { }
        // RVA: 0x09F714E0  token: 0x60003D5
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F717D4  token: 0x60003D6
        public System.Void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts) { }
        // RVA: 0x04273A88  token: 0x60003D7
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x2000067  // size: 0x150
    public class ScrollRect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
    {
        // Fields
        private UnityEngine.RectTransform m_Content;  // 0x18
        private System.Boolean m_Horizontal;  // 0x20
        private System.Boolean m_Vertical;  // 0x21
        protected UnityEngine.GameObject m_scrollEnableNode;  // 0x28
        private UnityEngine.UI.ScrollRect.MovementType m_MovementType;  // 0x30
        private System.Single m_Elasticity;  // 0x34
        private System.Boolean m_Inertia;  // 0x38
        private System.Single m_DecelerationRate;  // 0x3c
        private System.Single m_ScrollSensitivity;  // 0x40
        private UnityEngine.RectTransform m_Viewport;  // 0x48
        private UnityEngine.UI.Scrollbar m_HorizontalScrollbar;  // 0x50
        private UnityEngine.UI.Scrollbar m_VerticalScrollbar;  // 0x58
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;  // 0x60
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;  // 0x64
        private System.Single m_HorizontalScrollbarSpacing;  // 0x68
        private System.Single m_VerticalScrollbarSpacing;  // 0x6c
        private UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged;  // 0x70
        public System.Boolean disableScroll;  // 0x78
        public UnityEngine.UI.ScrollRect.ScrollRectEvent OnScrollStart;  // 0x80
        public UnityEngine.UI.ScrollRect.ScrollRectEvent OnScrollEnd;  // 0x88
        private UnityEngine.Vector2 m_PointerStartLocalCursor;  // 0x90
        protected UnityEngine.Vector2 m_ContentStartPosition;  // 0x98
        private UnityEngine.RectTransform m_ViewRect;  // 0xa0
        protected UnityEngine.Bounds m_ContentBounds;  // 0xa8
        private UnityEngine.Bounds m_ViewBounds;  // 0xc0
        private UnityEngine.Vector2 m_Velocity;  // 0xd8
        protected System.Boolean m_Dragging;  // 0xe0
        protected System.Boolean m_onScrollEndCbFlag;  // 0xe1
        protected System.Boolean m_Scrolling;  // 0xe2
        private UnityEngine.Vector2 m_PrevPosition;  // 0xe4
        private UnityEngine.Bounds m_PrevContentBounds;  // 0xec
        private UnityEngine.Bounds m_PrevViewBounds;  // 0x104
        private System.Boolean m_HasRebuiltLayout;  // 0x11c
        private System.Boolean m_HSliderExpand;  // 0x11d
        private System.Boolean m_VSliderExpand;  // 0x11e
        private System.Single m_HSliderHeight;  // 0x120
        private System.Single m_VSliderWidth;  // 0x124
        private UnityEngine.RectTransform m_Rect;  // 0x128
        private UnityEngine.RectTransform m_HorizontalScrollbarRect;  // 0x130
        private UnityEngine.RectTransform m_VerticalScrollbarRect;  // 0x138
        private UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x140
        private readonly UnityEngine.Vector3[] m_Corners;  // 0x148

        // Properties
        UnityEngine.RectTransform content { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean horizontal { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        System.Boolean vertical { get; /* RVA: 0x03D4F070 */ set; /* RVA: 0x03D4F080 */ }
        UnityEngine.UI.ScrollRect.MovementType movementType { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        System.Single elasticity { get; /* RVA: 0x03D56CA0 */ set; /* RVA: 0x03D56CB0 */ }
        System.Boolean inertia { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Single decelerationRate { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x03D4ECE0 */ }
        System.Single scrollSensitivity { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x03D4ECF0 */ }
        UnityEngine.RectTransform viewport { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x09F70F8C */ }
        UnityEngine.UI.Scrollbar horizontalScrollbar { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x09F70C28 */ }
        UnityEngine.UI.Scrollbar verticalScrollbar { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x09F70E04 */ }
        UnityEngine.UI.ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; /* RVA: 0x03D4F050 */ set; /* RVA: 0x09F70C1C */ }
        UnityEngine.UI.ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; /* RVA: 0x03D50B30 */ set; /* RVA: 0x09F70DF8 */ }
        System.Single horizontalScrollbarSpacing { get; /* RVA: 0x03D56A40 */ set; /* RVA: 0x09F70C10 */ }
        System.Single verticalScrollbarSpacing { get; /* RVA: 0x03D56C50 */ set; /* RVA: 0x09F70DEC */ }
        UnityEngine.UI.ScrollRect.ScrollRectEvent onValueChanged { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        UnityEngine.RectTransform viewRect { get; /* RVA: 0x0233DFC0 */ }
        UnityEngine.Vector2 velocity { get; /* RVA: 0x03D89C10 */ set; /* RVA: 0x03D89C30 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x034CFD70 */ }
        UnityEngine.Vector2 normalizedPosition { get; /* RVA: 0x028C2610 */ set; /* RVA: 0x09F70DB0 */ }
        System.Single horizontalNormalizedPosition { get; /* RVA: 0x028C2650 */ set; /* RVA: 0x04274DE0 */ }
        System.Single verticalNormalizedPosition { get; /* RVA: 0x028C27F0 */ set; /* RVA: 0x04274DEC */ }
        System.Boolean hScrollingNeeded { get; /* RVA: 0x0233D230 */ }
        System.Boolean vScrollingNeeded { get; /* RVA: 0x0233D2D0 */ }
        System.Single minWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single preferredWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single minHeight { get; /* RVA: 0x03D751A0 */ }
        System.Single preferredHeight { get; /* RVA: 0x03D751A0 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x03D5CD90 */ }

        // Methods
        // RVA: 0x0284A4A0  token: 0x6000403
        protected System.Void .ctor() { }
        // RVA: 0x0337CC00  token: 0x6000404
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x0350B670  token: 0x6000405
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x6000406
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x0337CE20  token: 0x6000407
        private System.Void UpdateCachedData() { }
        // RVA: 0x034CFB80  token: 0x6000408
        protected virtual System.Void OnEnable() { }
        // RVA: 0x034CF820  token: 0x6000409
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0363A500  token: 0x600040A
        public virtual System.Boolean IsActive() { }
        // RVA: 0x0233D1C0  token: 0x600040B
        public System.Void EnsureLayoutHasRebuilt() { }
        // RVA: 0x09F70BE4  token: 0x600040C
        public virtual System.Void StopMovement() { }
        // RVA: 0x028C1440  token: 0x600040D
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData data) { }
        // RVA: 0x09F70BF0  token: 0x600040E
        protected virtual System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position) { }
        // RVA: 0x03B414F0  token: 0x600040F
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F706BC  token: 0x6000410
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F70AD8  token: 0x6000411
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F707E8  token: 0x6000412
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x034E5060  token: 0x6000413
        protected virtual System.Void SetContentAnchoredPosition(UnityEngine.Vector2 position) { }
        // RVA: 0x0233C2A0  token: 0x6000414
        protected virtual System.Void LateUpdate() { }
        // RVA: 0x0337CC60  token: 0x6000415
        protected System.Void UpdatePrevData() { }
        // RVA: 0x028C2220  token: 0x6000416
        protected virtual System.Void UpdateScrollbars(UnityEngine.Vector2 offset) { }
        // RVA: 0x04274DE0  token: 0x600041D
        protected virtual System.Void SetHorizontalNormalizedPosition(System.Single value) { }
        // RVA: 0x034556D0  token: 0x600041E
        protected virtual System.Void SetVerticalNormalizedPosition(System.Single value) { }
        // RVA: 0x034556E0  token: 0x600041F
        protected virtual System.Void SetNormalizedPosition(System.Single value, System.Int32 axis) { }
        // RVA: 0x09F70AFC  token: 0x6000420
        private static System.Single RubberDelta(System.Single overStretching, System.Single viewSize) { }
        // RVA: 0x034CFCF0  token: 0x6000421
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x0350B670  token: 0x6000424
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x6000425
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x0337CD50  token: 0x600042D
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x034DE930  token: 0x600042E
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x0233D010  token: 0x600042F
        private System.Void UpdateScrollbarVisibility() { }
        // RVA: 0x0233D070  token: 0x6000430
        private static System.Void UpdateOneScrollbarVisibility(System.Boolean xScrollingNeeded, System.Boolean xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar) { }
        // RVA: 0x034DEA90  token: 0x6000431
        private System.Void UpdateScrollbarLayout() { }
        // RVA: 0x030C1010  token: 0x6000432
        protected virtual System.Void UpdateScrollEnableNode() { }
        // RVA: 0x0233D790  token: 0x6000433
        protected System.Void UpdateBounds() { }
        // RVA: 0x0233D380  token: 0x6000434
        private static System.Void AdjustBounds(UnityEngine.Bounds& viewBounds, UnityEngine.Vector2& contentPivot, UnityEngine.Vector3& contentSize, UnityEngine.Vector3& contentPos) { }
        // RVA: 0x0233D580  token: 0x6000435
        private UnityEngine.Bounds GetBounds() { }
        // RVA: 0x0238C980  token: 0x6000436
        private static UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, UnityEngine.Matrix4x4& viewWorldToLocalMatrix) { }
        // RVA: 0x0233CD20  token: 0x6000437
        protected UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta) { }
        // RVA: 0x0233CD70  token: 0x6000438
        private static UnityEngine.Vector2 InternalCalculateOffset(UnityEngine.Bounds& viewBounds, UnityEngine.Bounds& contentBounds, System.Boolean horizontal, System.Boolean vertical, UnityEngine.UI.ScrollRect.MovementType movementType, UnityEngine.Vector2& delta) { }
        // RVA: 0x034CFD00  token: 0x6000439
        protected System.Void SetDirty() { }
        // RVA: 0x09F70B44  token: 0x600043A
        protected System.Void SetDirtyCaching() { }
        // RVA: 0x04273A88  token: 0x600043B
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200006B  // size: 0x180
    public class Selectable : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
    {
        // Fields
        protected static UnityEngine.UI.Selectable[] s_Selectables;  // static @ 0x0
        protected static System.Int32 s_SelectableCount;  // static @ 0x8
        private System.Boolean m_EnableCalled;  // 0x18
        private UnityEngine.UI.Navigation m_Navigation;  // 0x20
        private UnityEngine.UI.Selectable.Transition m_Transition;  // 0x48
        private UnityEngine.UI.ColorBlock m_Colors;  // 0x4c
        private UnityEngine.UI.SpriteState m_SpriteState;  // 0xa8
        private UnityEngine.UI.AnimationTriggers m_AnimationTriggers;  // 0xc8
        private System.Boolean m_Interactable;  // 0xd0
        private UnityEngine.UI.Graphic m_TargetGraphic;  // 0xd8
        protected System.Boolean m_NotifyHover;  // 0xe0
        protected UnityEngine.GameObject m_HoverEnableNode;  // 0xe8
        protected System.String m_HoverAudioKey;  // 0xf0
        protected System.Boolean _enableUnityNavi;  // 0xf8
        private System.Boolean m_GroupsAllowInteraction;  // 0xf9
        protected System.Int32 m_CurrentIndex;  // 0xfc
        private System.Boolean <isPointerInside>k__BackingField;  // 0x100
        private System.Boolean <isPointerDown>k__BackingField;  // 0x101
        private System.Boolean <hasSelection>k__BackingField;  // 0x102
        private readonly System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache;  // 0x108
        public static UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable,System.Boolean> onAnyHoverChange;  // static @ 0x10
        private readonly UnityEngine.Events.UnityEvent<System.Boolean> <onHoverChange>k__BackingField;  // 0x110
        public System.Boolean enableControllerNavi;  // 0x118
        public UnityEngine.Transform overrideNaviHintRectTransform;  // 0x120
        public System.Single overrideNaviHintRectScale;  // 0x128
        public System.Boolean changeNaviHintParent;  // 0x12c
        public System.Boolean hideNaviHint;  // 0x12d
        public System.Boolean needNaviConfirmKeyHint;  // 0x12e
        public System.Boolean useExplicitNaviSelect;  // 0x12f
        public System.Boolean banExplicitOnLeft;  // 0x130
        public System.Boolean banExplicitOnRight;  // 0x131
        public System.Boolean banExplicitOnUp;  // 0x132
        public System.Boolean banExplicitOnDown;  // 0x133
        private UnityEngine.UI.Selectable m_ExplicitSelectOnLeft;  // 0x138
        private UnityEngine.UI.Selectable m_ExplicitSelectOnRight;  // 0x140
        private UnityEngine.UI.Selectable m_ExplicitSelectOnUp;  // 0x148
        private UnityEngine.UI.Selectable m_ExplicitSelectOnDown;  // 0x150
        private System.Boolean <isNaviTarget>k__BackingField;  // 0x158
        public System.Action<System.Boolean,System.Boolean,System.Boolean> onIsNaviTargetChanged;  // 0x160
        private System.Boolean <isNavigationSilent>k__BackingField;  // 0x168
        public UnityEngine.UI.SelectableNaviGroup naviGroup;  // 0x170
        private System.Boolean m_naviInited;  // 0x178

        // Properties
        UnityEngine.UI.Selectable[] allSelectablesArray { get; /* RVA: 0x09F72F38 */ }
        System.Int32 allSelectableCount { get; /* RVA: 0x09F72EE8 */ }
        System.Collections.Generic.List<UnityEngine.UI.Selectable> allSelectables { get; /* RVA: 0x09F72FBC */ }
        System.String hoverAudioKey { get; /* RVA: 0x03D51950 */ }
        UnityEngine.UI.Navigation navigation { get; /* RVA: 0x03D581B0 */ set; /* RVA: 0x02C70710 */ }
        UnityEngine.UI.Selectable.Transition transition { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x09F73250 */ }
        UnityEngine.UI.ColorBlock colors { get; /* RVA: 0x03D89C50 */ set; /* RVA: 0x09F730E8 */ }
        UnityEngine.UI.SpriteState spriteState { get; /* RVA: 0x03D89C90 */ set; /* RVA: 0x09F73184 */ }
        UnityEngine.UI.AnimationTriggers animationTriggers { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x09F7308C */ }
        UnityEngine.UI.Graphic targetGraphic { get; /* RVA: 0x03D4E7B0 */ set; /* RVA: 0x09F731F4 */ }
        System.Boolean interactable { get; /* RVA: 0x03D58E40 */ set; /* RVA: 0x02C3BC20 */ }
        System.Boolean isPointerInside { get; /* RVA: 0x03D56750 */ set; /* RVA: 0x03D89CC0 */ }
        System.Boolean isPointerDown { get; /* RVA: 0x03D75780 */ set; /* RVA: 0x03D89CB0 */ }
        System.Boolean hasSelection { get; /* RVA: 0x03D554B0 */ set; /* RVA: 0x03D554E0 */ }
        UnityEngine.UI.Image image { get; /* RVA: 0x09F7304C */ set; /* RVA: 0x05142FC4 */ }
        UnityEngine.Animator animator { get; /* RVA: 0x022B3BD0 */ }
        UnityEngine.UI.Selectable.SelectionState currentSelectionState { get; /* RVA: 0x022B2B40 */ }
        UnityEngine.Events.UnityEvent<System.Boolean> onHoverChange { get; /* RVA: 0x03D56CF0 */ }
        System.Boolean isNaviTarget { get; /* RVA: 0x03D5AC60 */ set; /* RVA: 0x03D5AC70 */ }
        System.Boolean isNavigationSilent { get; /* RVA: 0x03D5BC50 */ set; /* RVA: 0x03D5BCA0 */ }

        // Methods
        // RVA: 0x09F71D24  token: 0x6000440
        public static System.Int32 AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables) { }
        // RVA: 0x028488B0  token: 0x6000456
        protected System.Void .ctor() { }
        // RVA: 0x02C705D0  token: 0x600045A
        protected virtual System.Void Awake() { }
        // RVA: 0x0251CA00  token: 0x600045B
        protected System.Void OnCanvasGroupChanged() { }
        // RVA: 0x022B2B90  token: 0x600045C
        public virtual System.Boolean IsInteractable() { }
        // RVA: 0x09F72930  token: 0x600045D
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x022B1BA0  token: 0x600045E
        protected virtual System.Void OnEnable() { }
        // RVA: 0x039DD000  token: 0x600045F
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x036E62D0  token: 0x6000460
        private System.Void OnSetProperty() { }
        // RVA: 0x022B2BB0  token: 0x6000461
        protected virtual System.Void OnDisable() { }
        // RVA: 0x022B3C50  token: 0x6000462
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        // RVA: 0x022B30D0  token: 0x6000464
        protected virtual System.Void InstantClearState() { }
        // RVA: 0x022B2E50  token: 0x6000465
        protected virtual System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant) { }
        // RVA: 0x09F7211C  token: 0x6000466
        public UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir) { }
        // RVA: 0x09F7267C  token: 0x6000467
        private static UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir) { }
        // RVA: 0x09F728A0  token: 0x6000468
        private System.Void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel) { }
        // RVA: 0x09F71F0C  token: 0x6000469
        public virtual UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        // RVA: 0x09F71FBC  token: 0x600046A
        public virtual UnityEngine.UI.Selectable FindSelectableOnRight() { }
        // RVA: 0x09F7206C  token: 0x600046B
        public virtual UnityEngine.UI.Selectable FindSelectableOnUp() { }
        // RVA: 0x09F71E5C  token: 0x600046C
        public virtual UnityEngine.UI.Selectable FindSelectableOnDown() { }
        // RVA: 0x09F72938  token: 0x600046D
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        // RVA: 0x022B31B0  token: 0x600046E
        private System.Void StartColorTween(UnityEngine.Color targetColor, System.Boolean instant) { }
        // RVA: 0x09F71DCC  token: 0x600046F
        private System.Void DoSpriteSwap(UnityEngine.Sprite newSprite) { }
        // RVA: 0x022B39D0  token: 0x6000470
        private System.Void TriggerAnimation(System.String triggername) { }
        // RVA: 0x09F72850  token: 0x6000471
        protected System.Boolean IsHighlighted() { }
        // RVA: 0x022B3C80  token: 0x6000472
        protected System.Boolean IsPressed() { }
        // RVA: 0x022B4090  token: 0x6000473
        private System.Void EvaluateAndTransitionToSelectionState() { }
        // RVA: 0x0284C830  token: 0x6000474
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284C800  token: 0x6000475
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x022B4B20  token: 0x6000476
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x022B4C20  token: 0x6000477
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03CDD160  token: 0x6000478
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03CBABA0  token: 0x6000479
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F72A14  token: 0x600047A
        public virtual System.Void Select() { }
        // RVA: 0x024B2200  token: 0x600047B
        protected virtual System.Void _RefreshHoverEnableNode(System.Boolean active) { }
        // RVA: 0x0350B670  token: 0x600047C
        public virtual System.Void OnInteractableChanged() { }
        // RVA: 0x02C6F620  token: 0x600047E
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x02C71AF0  token: 0x600047F
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09F72654  token: 0x6000480
        public virtual System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        // RVA: 0x09F72AE0  token: 0x6000485
        public System.Void SetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode, System.Boolean isGroupChanged) { }
        // RVA: 0x09F729A8  token: 0x6000486
        public virtual System.Void OnNaviTargetEnabledAgain() { }
        // RVA: 0x0350B670  token: 0x6000487
        protected virtual System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        // RVA: 0x02C70790  token: 0x6000488
        public System.Void TryFindNaviGroup() { }
        // RVA: 0x09F725DC  token: 0x6000489
        public UnityEngine.UI.SelectableNaviGroup GetLayerGroup() { }
        // RVA: 0x09F72C88  token: 0x600048A
        public System.Boolean TryFindExplicitNaviTarget(UnityEngine.UI.NaviDirection dir, UnityEngine.UI.Selectable& target) { }
        // RVA: 0x09F72E10  token: 0x600048B
        public System.Boolean banExplicitNavi(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x022B2D90  token: 0x600048C
        private System.Void _TryRegisterOnNaviGroup() { }
        // RVA: 0x02C71B30  token: 0x600048D
        private System.Void _TryUnRegisterOnNaviGroup() { }
        // RVA: 0x04275CE0  token: 0x600048E
        public System.Void SetExplicitSelectOnLeft(UnityEngine.UI.Selectable selectable) { }
        // RVA: 0x058B3FD8  token: 0x600048F
        public System.Void SetExplicitSelectOnRight(UnityEngine.UI.Selectable selectable) { }
        // RVA: 0x058B3DA8  token: 0x6000490
        public System.Void SetExplicitSelectOnUp(UnityEngine.UI.Selectable selectable) { }
        // RVA: 0x058B3DD0  token: 0x6000491
        public System.Void SetExplicitSelectOnDown(UnityEngine.UI.Selectable selectable) { }
        // RVA: 0x09F72C28  token: 0x6000492
        public System.Void SetExplicitSelect(UnityEngine.UI.Selectable left, UnityEngine.UI.Selectable right, UnityEngine.UI.Selectable up, UnityEngine.UI.Selectable down) { }
        // RVA: 0x03C84DD0  token: 0x6000493
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x14
    public sealed struct NaviDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.NaviDirection None;  // const
        public static UnityEngine.UI.NaviDirection Up;  // const
        public static UnityEngine.UI.NaviDirection Down;  // const
        public static UnityEngine.UI.NaviDirection Left;  // const
        public static UnityEngine.UI.NaviDirection Right;  // const

    }

    // TypeToken: 0x200006F  // size: 0x14
    public sealed struct NaviStrategy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.NaviStrategy Normal;  // const
        public static UnityEngine.UI.NaviStrategy Strict;  // const
        public static UnityEngine.UI.NaviStrategy NotInternalFirst;  // const
        public static UnityEngine.UI.NaviStrategy VerticalOnlyWithInternalWrap;  // const
        public static UnityEngine.UI.NaviStrategy HorizontalOnlyWithInternalWrap;  // const

    }

    // TypeToken: 0x2000070  // size: 0x14
    public sealed struct NavigationBindingType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.UI.NavigationBindingType InValid;  // const
        public static UnityEngine.UI.NavigationBindingType AllDirections;  // const
        public static UnityEngine.UI.NavigationBindingType HorizontalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType VerticalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType ArrowAllDirections;  // const
        public static UnityEngine.UI.NavigationBindingType ArrowHorizontalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType ArrowVerticalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsAllDirections;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsHorizontalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsVerticalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyAllDirections;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyHorizontalOnly;  // const
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyVerticalOnly;  // const

    }

    // TypeToken: 0x2000071  // size: 0xA0
    public abstract class SelectableNaviGroup : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean isIsolate;  // 0x18
        public System.Boolean isLayer;  // 0x19
        public System.Boolean removeLayerOnDisable;  // 0x1a
        public UnityEngine.UI.SelectableNaviGroup parentNaviGroup;  // 0x20
        public UnityEngine.UI.NaviStrategy internalNaviStrategy;  // 0x28
        public UnityEngine.UI.NavigationBindingType navigationBindingType;  // 0x2c
        public System.Boolean enablePartner;  // 0x30
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnUp;  // 0x38
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnDown;  // 0x40
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnLeft;  // 0x48
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnRight;  // 0x50
        protected System.Boolean m_inited;  // 0x58
        protected UnityEngine.UI.Selectable m_layerSelectedTarget;  // 0x60
        public System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> targets;  // 0x68
        public System.Collections.Generic.HashSet<UnityEngine.UI.SelectableNaviGroup> subGroups;  // 0x70
        public UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable> onSetLayerSelectedTarget;  // 0x78
        public UnityEngine.Events.UnityEvent<System.Boolean> onIsTopLayerChanged;  // 0x80
        public UnityEngine.Events.UnityEvent<UnityEngine.UI.NaviDirection> onDefaultNaviFailed;  // 0x88
        public UnityEngine.Events.UnityEvent onRemoveFromLayerStack;  // 0x90
        protected System.Boolean m_isTopLayer;  // 0x98

        // Properties
        UnityEngine.UI.Selectable LayerSelectedTarget { get; /* RVA: 0x02C707E0 */ }
        System.Boolean IsTopLayer { get; /* RVA: 0x03D58690 */ set; /* RVA: 0x09F71D0C */ }

        // Methods
        // RVA: 0x09F71D04  token: 0x6000495
        protected virtual System.Void Reset() { }
        // RVA: 0x02C6F9C0  token: 0x6000496
        protected virtual System.Void OnEnable() { }
        // RVA: 0x04272FC0  token: 0x6000497
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0304D760  token: 0x6000498
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02C6FB50  token: 0x6000499
        protected virtual System.Void _Init() { }
        // RVA: 0x02C70280  token: 0x600049A
        public System.Void TryFindParentNaviGroup() { }
        // RVA: 0x02C700D0  token: 0x600049B
        public UnityEngine.UI.SelectableNaviGroup GetLayerGroup() { }
        // RVA: 0x02C6FF20  token: 0x600049E
        public System.Void SetLayerSelectedTarget(UnityEngine.UI.Selectable value, System.Boolean silentMode) { }
        // RVA: 0x02C70250  token: 0x600049F
        public System.Void OnRemoveFromLayerStack() { }
        // RVA: 0x02C6F090  token: 0x60004A0
        protected virtual System.Void _OnIsTopLayerChanged() { }
        // RVA: 0x0350B670  token: 0x60004A1
        protected virtual System.Void _OnSelectableNaviGroupInited() { }
        // RVA: 0x0350B670  token: 0x60004A2
        protected virtual System.Void _BeforeSelectableNaviGroupDestroy() { }
        // RVA: 0x0350B670  token: 0x60004A3
        protected virtual System.Void _OnSelectableNaviGroupDisabled() { }
        // RVA: 0x0350B670  token: 0x60004A4
        protected virtual System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value) { }
        // RVA: 0x0350B670  token: 0x60004A5
        protected virtual System.Void _OnRemoveFromLayerStack() { }
        // RVA: 0x0283A100  token: 0x60004A6
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000072  // size: 0x10
    public static class SetPropertyUtility
    {
        // Methods
        // RVA: 0x025C1E90  token: 0x60004A7
        public static System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue) { }
        // RVA: -1  // generic def  token: 0x60004A8
        public static System.Boolean SetStruct(T& currentValue, T newValue) { }
        // RVA: -1  // generic def  token: 0x60004A9
        public static System.Boolean SetClass(T& currentValue, T newValue) { }

    }

    // TypeToken: 0x2000073  // size: 0x1E8
    public class Slider : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_FillRect;  // 0x180
        private UnityEngine.RectTransform m_HandleRect;  // 0x188
        private UnityEngine.UI.Slider.Direction m_Direction;  // 0x190
        private System.Single m_MinValue;  // 0x194
        private System.Single m_MaxValue;  // 0x198
        private System.Boolean m_WholeNumbers;  // 0x19c
        protected System.Single m_Value;  // 0x1a0
        private UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;  // 0x1a8
        private UnityEngine.UI.Image m_FillImage;  // 0x1b0
        private UnityEngine.Transform m_FillTransform;  // 0x1b8
        private UnityEngine.RectTransform m_FillContainerRect;  // 0x1c0
        private UnityEngine.Transform m_HandleTransform;  // 0x1c8
        private UnityEngine.RectTransform m_HandleContainerRect;  // 0x1d0
        private UnityEngine.Vector2 m_Offset;  // 0x1d8
        private UnityEngine.DrivenRectTransformTracker m_Tracker;  // 0x1e0
        private System.Boolean m_DelayedUpdateVisuals;  // 0x1e1

        // Properties
        UnityEngine.RectTransform fillRect { get; /* RVA: 0x03D56B50 */ set; /* RVA: 0x09F73DDC */ }
        UnityEngine.RectTransform handleRect { get; /* RVA: 0x03D56AF0 */ set; /* RVA: 0x09F73E44 */ }
        UnityEngine.UI.Slider.Direction direction { get; /* RVA: 0x03D760B0 */ set; /* RVA: 0x09F73D80 */ }
        System.Single minValue { get; /* RVA: 0x03D58B50 */ set; /* RVA: 0x03B72620 */ }
        System.Single maxValue { get; /* RVA: 0x03D583C0 */ set; /* RVA: 0x03B727B0 */ }
        System.Boolean wholeNumbers { get; /* RVA: 0x03D5B0C0 */ set; /* RVA: 0x09F73EDC */ }
        System.Single value { get; /* RVA: 0x027E8BB0 */ set; /* RVA: 0x042725E4 */ }
        System.Single normalizedValue { get; /* RVA: 0x027E8B40 */ set; /* RVA: 0x09F73EAC */ }
        UnityEngine.UI.Slider.SliderEvent onValueChanged { get; /* RVA: 0x03D57170 */ set; /* RVA: 0x04275BE8 */ }
        System.Single stepSize { get; /* RVA: 0x09F73D54 */ }
        UnityEngine.UI.Slider.Axis axis { get; /* RVA: 0x027E87F0 */ }
        System.Boolean reverseValue { get; /* RVA: 0x027E7CA0 */ }

        // Methods
        // RVA: 0x09F73B18  token: 0x60004B8
        public virtual System.Void SetValueWithoutNotify(System.Single input) { }
        // RVA: 0x02848250  token: 0x60004BE
        protected System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60004BF
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x0350B670  token: 0x60004C0
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x60004C1
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x02529580  token: 0x60004C2
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0361D5F0  token: 0x60004C3
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02394050  token: 0x60004C4
        protected virtual System.Void Update() { }
        // RVA: 0x09F733AC  token: 0x60004C5
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x025295C0  token: 0x60004C6
        private System.Void UpdateCachedReferences() { }
        // RVA: 0x09F732A8  token: 0x60004C7
        protected virtual System.Single ClampValue(System.Single input) { }
        // RVA: 0x0272C470  token: 0x60004C8
        protected virtual System.Void Set(System.Single input, System.Boolean sendCallback) { }
        // RVA: 0x0350B670  token: 0x60004C9
        protected virtual System.Void OnValueChanged() { }
        // RVA: 0x0350B670  token: 0x60004CA
        protected virtual System.Void OnClickSliderBar() { }
        // RVA: 0x0350B670  token: 0x60004CB
        protected virtual System.Void OnClickSliderHandle() { }
        // RVA: 0x036ABA40  token: 0x60004CC
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x027E8810  token: 0x60004CF
        private System.Void UpdateVisuals() { }
        // RVA: 0x09F73B24  token: 0x60004D0
        private System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam) { }
        // RVA: 0x03D65EB0  token: 0x60004D1
        protected virtual System.Single CustomProcessNormalizedValue(System.Single val) { }
        // RVA: 0x09F711F4  token: 0x60004D2
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F73800  token: 0x60004D3
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F735C8  token: 0x60004D4
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F73618  token: 0x60004D5
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        // RVA: 0x09F73310  token: 0x60004D6
        public virtual UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        // RVA: 0x09F73344  token: 0x60004D7
        public virtual UnityEngine.UI.Selectable FindSelectableOnRight() { }
        // RVA: 0x09F73378  token: 0x60004D8
        public virtual UnityEngine.UI.Selectable FindSelectableOnUp() { }
        // RVA: 0x09F732DC  token: 0x60004D9
        public virtual UnityEngine.UI.Selectable FindSelectableOnDown() { }
        // RVA: 0x09F714E0  token: 0x60004DA
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F739DC  token: 0x60004DB
        public System.Void SetDirection(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts) { }
        // RVA: 0x04273A88  token: 0x60004DC
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x2000077  // size: 0x30
    public sealed struct SpriteState : System.IEquatable`1
    {
        // Fields
        private UnityEngine.Sprite m_HighlightedSprite;  // 0x10
        private UnityEngine.Sprite m_PressedSprite;  // 0x18
        private UnityEngine.Sprite m_SelectedSprite;  // 0x20
        private UnityEngine.Sprite m_DisabledSprite;  // 0x28

        // Properties
        UnityEngine.Sprite highlightedSprite { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Sprite pressedSprite { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Sprite selectedSprite { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Sprite disabledSprite { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x09F73F50  token: 0x60004E6
        public virtual System.Boolean Equals(UnityEngine.UI.SpriteState other) { }

    }

    // TypeToken: 0x2000078  // size: 0x10
    public static class StencilMaterial
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;  // static @ 0x0
        private static System.Boolean s_EnableStencilMaterialWarning;  // static @ 0x8

        // Methods
        // RVA: 0x01002730  token: 0x60004E7
        public static UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID) { }
        // RVA: 0x02516830  token: 0x60004E8
        public static UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask) { }
        // RVA: 0x09F74130  token: 0x60004E9
        private static System.Void LogWarningWhenNotInBatchmode(System.String warning, UnityEngine.Object context) { }
        // RVA: 0x028006E0  token: 0x60004EA
        public static UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, System.Int32 readMask, System.Int32 writeMask) { }
        // RVA: 0x0239F570  token: 0x60004EB
        public static System.Void Remove(UnityEngine.Material customMat) { }
        // RVA: 0x09F7401C  token: 0x60004EC
        public static System.Void ClearAll() { }
        // RVA: 0x03CBCE10  token: 0x60004ED
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007A  // size: 0x118
    public class Text : UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement
    {
        // Fields
        private UnityEngine.UI.FontData m_FontData;  // 0xe8
        protected System.String m_Text;  // 0xf0
        private UnityEngine.TextGenerator m_TextCache;  // 0xf8
        private UnityEngine.TextGenerator m_TextCacheForLayout;  // 0x100
        protected static UnityEngine.Material s_DefaultText;  // static @ 0x0
        protected System.Boolean m_DisableFontTextureRebuiltCallback;  // 0x108
        private readonly UnityEngine.UIVertex[] m_TempVerts;  // 0x110

        // Properties
        UnityEngine.TextGenerator cachedTextGenerator { get; /* RVA: 0x09F74E44 */ }
        UnityEngine.TextGenerator cachedTextGeneratorForLayout { get; /* RVA: 0x09F74DC8 */ }
        UnityEngine.Texture mainTexture { get; /* RVA: 0x09F74F98 */ }
        UnityEngine.Font font { get; /* RVA: 0x09F74F38 */ set; /* RVA: 0x09F7561C */ }
        System.String text { get; /* RVA: 0x03D51950 */ set; /* RVA: 0x09F758B0 */ }
        System.Boolean supportRichText { get; /* RVA: 0x09F754D4 */ set; /* RVA: 0x09F7586C */ }
        System.Boolean resizeTextForBestFit { get; /* RVA: 0x09F75474 */ set; /* RVA: 0x09F757A0 */ }
        System.Int32 resizeTextMinSize { get; /* RVA: 0x09F754B4 */ set; /* RVA: 0x09F75828 */ }
        System.Int32 resizeTextMaxSize { get; /* RVA: 0x09F75494 */ set; /* RVA: 0x09F757E4 */ }
        UnityEngine.TextAnchor alignment { get; /* RVA: 0x09F74DA8 */ set; /* RVA: 0x09F75550 */ }
        System.Boolean alignByGeometry { get; /* RVA: 0x09F74D88 */ set; /* RVA: 0x09F75514 */ }
        System.Int32 fontSize { get; /* RVA: 0x09F74EF8 */ set; /* RVA: 0x09F75594 */ }
        UnityEngine.HorizontalWrapMode horizontalOverflow { get; /* RVA: 0x09F74F58 */ set; /* RVA: 0x09F75710 */ }
        UnityEngine.VerticalWrapMode verticalOverflow { get; /* RVA: 0x09F754F4 */ set; /* RVA: 0x09F7597C */ }
        System.Single lineSpacing { get; /* RVA: 0x09F74F78 */ set; /* RVA: 0x09F75754 */ }
        UnityEngine.FontStyle fontStyle { get; /* RVA: 0x09F74F18 */ set; /* RVA: 0x09F755D8 */ }
        System.Single pixelsPerUnit { get; /* RVA: 0x09F75120 */ }
        System.Single minWidth { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredWidth { get; /* RVA: 0x09F75384 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single minHeight { get; /* RVA: 0x03D503F0 */ }
        System.Single preferredHeight { get; /* RVA: 0x09F7525C */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09F74CDC  token: 0x60004EF
        protected System.Void .ctor() { }
        // RVA: 0x09F742A8  token: 0x60004F3
        public System.Void FontTextureChanged() { }
        // RVA: 0x09F74654  token: 0x600050F
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F74608  token: 0x6000510
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F74C74  token: 0x6000511
        protected virtual System.Void UpdateGeometry() { }
        // RVA: 0x09F74250  token: 0x6000512
        public System.Void AssignDefaultFont() { }
        // RVA: 0x09F741B8  token: 0x6000513
        private System.Void AssignDefaultFontIfNecessary() { }
        // RVA: 0x09F74370  token: 0x6000514
        public UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents) { }
        // RVA: 0x09F7457C  token: 0x6000515
        public static UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor) { }
        // RVA: 0x09F746BC  token: 0x6000516
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x0350B670  token: 0x6000517
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x6000518
        public virtual System.Void CalculateLayoutInputVertical() { }

    }

    // TypeToken: 0x200007B  // size: 0x1A8
    public class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
    {
        // Fields
        public UnityEngine.UI.Toggle.ToggleTransition toggleTransition;  // 0x180
        public UnityEngine.UI.Graphic graphic;  // 0x188
        private UnityEngine.UI.ToggleGroup m_Group;  // 0x190
        public UnityEngine.UI.Toggle.ToggleEvent onValueChanged;  // 0x198
        private System.Boolean m_IsOn;  // 0x1a0

        // Properties
        UnityEngine.UI.ToggleGroup group { get; /* RVA: 0x03D56B70 */ set; /* RVA: 0x09F75C78 */ }
        System.Boolean isOn { get; /* RVA: 0x03D57C40 */ set; /* RVA: 0x02C6BE20 */ }

        // Methods
        // RVA: 0x02848160  token: 0x6000522
        protected System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000523
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x0350B670  token: 0x6000524
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x0350B670  token: 0x6000525
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x09F75B08  token: 0x6000526
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02C6C100  token: 0x6000527
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C6C070  token: 0x6000528
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F75B84  token: 0x6000529
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x02C6C2F0  token: 0x600052A
        private System.Void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, System.Boolean setMemberValue) { }
        // RVA: 0x04276904  token: 0x600052D
        public System.Void SetIsOnWithoutNotify(System.Boolean value) { }
        // RVA: 0x02C6BE30  token: 0x600052E
        private System.Void Set(System.Boolean value, System.Boolean sendCallback) { }
        // RVA: 0x02C6C140  token: 0x600052F
        private System.Void PlayEffect(System.Boolean instant) { }
        // RVA: 0x04272FA8  token: 0x6000530
        protected virtual System.Void Start() { }
        // RVA: 0x02C6ACA0  token: 0x6000531
        protected virtual System.Void InternalToggle() { }
        // RVA: 0x09F75C44  token: 0x6000532
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0968FA40  token: 0x6000533
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x0350B670  token: 0x6000534
        protected virtual System.Void OnValueChange() { }
        // RVA: 0x04273A88  token: 0x6000535
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200007E  // size: 0x28
    public class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private System.Boolean m_AllowSwitchOff;  // 0x18
        protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;  // 0x20

        // Properties
        System.Boolean allowSwitchOff { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x03726C20  token: 0x6000539
        protected System.Void .ctor() { }
        // RVA: 0x02C6AE20  token: 0x600053A
        protected virtual System.Void Start() { }
        // RVA: 0x02C6AE20  token: 0x600053B
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C6AF20  token: 0x600053C
        private System.Void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle) { }
        // RVA: 0x02C6AE30  token: 0x600053D
        public System.Void NotifyToggleOn(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback) { }
        // RVA: 0x02C6C460  token: 0x600053E
        public System.Void UnregisterToggle(UnityEngine.UI.Toggle toggle) { }
        // RVA: 0x02C6BFB0  token: 0x600053F
        public System.Void RegisterToggle(UnityEngine.UI.Toggle toggle) { }
        // RVA: 0x02C6AFD0  token: 0x6000540
        public System.Void EnsureValidState() { }
        // RVA: 0x02C6B420  token: 0x6000541
        public System.Boolean AnyTogglesOn() { }
        // RVA: 0x02C6B2E0  token: 0x6000542
        public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }
        // RVA: 0x09F759C0  token: 0x6000543
        public UnityEngine.UI.Toggle GetFirstActiveToggle() { }
        // RVA: 0x09F75A30  token: 0x6000544
        public System.Void SetAllTogglesOff(System.Boolean sendCallback) { }

    }

    // TypeToken: 0x2000080  // size: 0x40
    public class ReflectionMethodsCache
    {
        // Fields
        public UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D;  // 0x10
        public UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll;  // 0x18
        public UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;  // 0x20
        public UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D;  // 0x28
        public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;  // 0x30
        public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;  // 0x38
        private static UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;  // static @ 0x0

        // Properties
        UnityEngine.UI.ReflectionMethodsCache Singleton { get; /* RVA: 0x09F7062C */ }

        // Methods
        // RVA: 0x09F6FB70  token: 0x6000549
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000087  // size: 0x60
    public class VertexHelper : System.IDisposable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Vector3> m_Positions;  // 0x10
        private System.Collections.Generic.List<UnityEngine.Color32> m_Colors;  // 0x18
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S;  // 0x20
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S;  // 0x28
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S;  // 0x30
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S;  // 0x38
        private System.Collections.Generic.List<UnityEngine.Vector3> m_Normals;  // 0x40
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents;  // 0x48
        private System.Collections.Generic.List<System.Int32> m_Indices;  // 0x50
        private static readonly UnityEngine.Vector4 s_DefaultTangent;  // static @ 0x0
        private static readonly UnityEngine.Vector3 s_DefaultNormal;  // static @ 0x10
        private System.Boolean m_ListsInitalized;  // 0x58

        // Properties
        System.Int32 currentVertCount { get; /* RVA: 0x025A39D0 */ }
        System.Int32 currentIndexCount { get; /* RVA: 0x09F76800 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000563
        public System.Void .ctor() { }
        // RVA: 0x09F765C8  token: 0x6000564
        public System.Void .ctor(UnityEngine.Mesh m) { }
        // RVA: 0x025A6CE0  token: 0x6000565
        private System.Void InitializeListIfRequired() { }
        // RVA: 0x036D4C20  token: 0x6000566
        public virtual System.Void Dispose() { }
        // RVA: 0x02337B50  token: 0x6000567
        public System.Void Clear() { }
        // RVA: 0x09F760C4  token: 0x600056A
        public System.Void PopulateUIVertex(UnityEngine.UIVertex& vertex, System.Int32 i) { }
        // RVA: 0x09F76280  token: 0x600056B
        public System.Void SetUIVertex(UnityEngine.UIVertex vertex, System.Int32 i) { }
        // RVA: 0x025A84D0  token: 0x600056C
        public System.Void FillMesh(UnityEngine.Mesh mesh) { }
        // RVA: 0x025A6590  token: 0x600056D
        public System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent) { }
        // RVA: 0x025A5E30  token: 0x600056E
        public System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent) { }
        // RVA: 0x025A5670  token: 0x600056F
        public System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0) { }
        // RVA: 0x036A4D70  token: 0x6000570
        public System.Void AddVert(UnityEngine.UIVertex v) { }
        // RVA: 0x025A52A0  token: 0x6000571
        public System.Void AddTriangle(System.Int32 idx0, System.Int32 idx1, System.Int32 idx2) { }
        // RVA: 0x02CDBCF0  token: 0x6000572
        public System.Void AddUIVertexQuad(UnityEngine.UIVertex[] verts) { }
        // RVA: 0x09F75F14  token: 0x6000573
        public System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }
        // RVA: 0x09F75FD4  token: 0x6000574
        public System.Void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }
        // RVA: 0x09F7604C  token: 0x6000575
        public System.Void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }
        // RVA: 0x0398BF50  token: 0x6000576
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x10
    public abstract class BaseVertexEffect
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000577
        public virtual System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }
        // RVA: 0x0350B670  token: 0x6000578
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000089  // size: 0x20
    public abstract class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
    {
        // Fields
        private UnityEngine.UI.Graphic m_Graphic;  // 0x18

        // Properties
        UnityEngine.UI.Graphic graphic { get; /* RVA: 0x09F77908 */ }

        // Methods
        // RVA: 0x09F77888  token: 0x600057A
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F77808  token: 0x600057B
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F77788  token: 0x600057C
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x09F77684  token: 0x600057D
        public virtual System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        // RVA: -1  // abstract  token: 0x600057E
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x0426FE60  token: 0x600057F
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public interface IVertexModifier
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000580
        public virtual System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

    }

    // TypeToken: 0x200008B
    public interface IMeshModifier
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000581
        public virtual System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        // RVA: -1  // abstract  token: 0x6000582
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper verts) { }

    }

    // TypeToken: 0x200008C  // size: 0x40
    public class Outline : UnityEngine.UI.Shadow
    {
        // Methods
        // RVA: 0x09F79564  token: 0x6000583
        protected System.Void .ctor() { }
        // RVA: 0x09F792CC  token: 0x6000584
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

    // TypeToken: 0x200008D  // size: 0x20
    public class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x6000585
        protected System.Void .ctor() { }
        // RVA: 0x09F7E390  token: 0x6000586
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

    // TypeToken: 0x200008E  // size: 0x40
    public class Shadow : UnityEngine.UI.BaseMeshEffect
    {
        // Fields
        private UnityEngine.Color m_EffectColor;  // 0x20
        private UnityEngine.Vector2 m_EffectDistance;  // 0x30
        private System.Boolean m_UseGraphicAlpha;  // 0x38
        private static System.Single kMaxEffectDistance;  // const

        // Properties
        UnityEngine.Color effectColor { get; /* RVA: 0x03D54E00 */ set; /* RVA: 0x09F7F6BC */ }
        UnityEngine.Vector2 effectDistance { get; /* RVA: 0x03D69670 */ set; /* RVA: 0x09F7F748 */ }
        System.Boolean useGraphicAlpha { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x09F7F84C */ }

        // Methods
        // RVA: 0x03D474D0  token: 0x6000587
        protected System.Void .ctor() { }
        // RVA: 0x09F7F308  token: 0x600058E
        protected System.Void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y) { }
        // RVA: 0x09F7F584  token: 0x600058F
        protected System.Void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y) { }
        // RVA: 0x09F7F594  token: 0x6000590
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

}

namespace UnityEngine.UI.Collections
{

    // TypeToken: 0x200008F
    public class IndexedSet`1 : System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<T> m_List;  // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> m_Dictionary;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000591
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000592
        public System.Boolean AddUnique(T item) { }
        // RVA: -1  // not resolved  token: 0x6000593
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x6000594
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000595
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000596
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000597
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000598
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x600059B
        public virtual System.Int32 IndexOf(T item) { }
        // RVA: -1  // not resolved  token: 0x600059C
        public virtual System.Void Insert(System.Int32 index, T item) { }
        // RVA: -1  // not resolved  token: 0x600059D
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60005A0
        public System.Void RemoveAll(System.Predicate<T> match) { }
        // RVA: -1  // not resolved  token: 0x60005A1
        public System.Void Sort(System.Comparison<T> sortLayoutFunction) { }
        // RVA: -1  // not resolved  token: 0x60005A2
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.UI.CoroutineTween
{

    // TypeToken: 0x2000090
    public interface ITweenValue
    {
        // Properties
        System.Boolean ignoreTimeScale { get; /* RVA: -1  // abstract */ }
        System.Single duration { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60005A3
        public virtual System.Void TweenValue(System.Single floatPercentage) { }
        // RVA: -1  // abstract  token: 0x60005A6
        public virtual System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000091  // size: 0x48
    public sealed struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
    {
        // Fields
        private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;  // 0x10
        private UnityEngine.Color m_StartColor;  // 0x18
        private UnityEngine.Color m_TargetColor;  // 0x28
        private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;  // 0x38
        private System.Single m_Duration;  // 0x3c
        private System.Boolean m_IgnoreTimeScale;  // 0x40

        // Properties
        UnityEngine.Color startColor { get; /* RVA: 0x020C61C0 */ set; /* RVA: 0x03D707A0 */ }
        UnityEngine.Color targetColor { get; /* RVA: 0x03D51D80 */ set; /* RVA: 0x03D51D90 */ }
        UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode tweenMode { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Single duration { get; /* RVA: 0x03D4F3A0 */ set; /* RVA: 0x03D4F3B0 */ }
        System.Boolean ignoreTimeScale { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }

        // Methods
        // RVA: 0x0317A040  token: 0x60005B1
        public virtual System.Void TweenValue(System.Single floatPercentage) { }
        // RVA: 0x024A3EA0  token: 0x60005B2
        public System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }
        // RVA: 0x03D4EF60  token: 0x60005B3
        public System.Boolean GetIgnoreTimescale() { }
        // RVA: 0x03D4F3A0  token: 0x60005B4
        public System.Single GetDuration() { }
        // RVA: 0x0317A1F0  token: 0x60005B5
        public virtual System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000094  // size: 0x28
    public sealed struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
    {
        // Fields
        private UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;  // 0x10
        private System.Single m_StartValue;  // 0x18
        private System.Single m_TargetValue;  // 0x1c
        private System.Single m_Duration;  // 0x20
        private System.Boolean m_IgnoreTimeScale;  // 0x24

        // Properties
        System.Single startValue { get; /* RVA: 0x03D58BB0 */ set; /* RVA: 0x03D58BE0 */ }
        System.Single targetValue { get; /* RVA: 0x03D5E120 */ set; /* RVA: 0x03D5E130 */ }
        System.Single duration { get; /* RVA: 0x03D4E7A0 */ set; /* RVA: 0x03D50CA0 */ }
        System.Boolean ignoreTimeScale { get; /* RVA: 0x03D58C00 */ set; /* RVA: 0x03D58C20 */ }

        // Methods
        // RVA: 0x09F78F28  token: 0x60005BF
        public virtual System.Void TweenValue(System.Single floatPercentage) { }
        // RVA: 0x09F78E90  token: 0x60005C0
        public System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }
        // RVA: 0x03D58C00  token: 0x60005C1
        public System.Boolean GetIgnoreTimescale() { }
        // RVA: 0x03D4E7A0  token: 0x60005C2
        public System.Single GetDuration() { }
        // RVA: 0x022B4F90  token: 0x60005C3
        public virtual System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000096
    public class TweenRunner`1
    {
        // Fields
        protected UnityEngine.MonoBehaviour m_CoroutineContainer;  // 0x0
        protected System.Collections.IEnumerator m_Tween;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60005C5
        private static System.Collections.IEnumerator Start(T tweenInfo) { }
        // RVA: -1  // not resolved  token: 0x60005C6
        public System.Void Init(UnityEngine.MonoBehaviour coroutineContainer) { }
        // RVA: -1  // not resolved  token: 0x60005C7
        public System.Void StartTween(T info) { }
        // RVA: -1  // not resolved  token: 0x60005C8
        public System.Void StopTween() { }
        // RVA: -1  // not resolved  token: 0x60005C9
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.UIElements
{

    // TypeToken: 0x2000098  // size: 0x38
    public class PanelEventHandler : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent
    {
        // Fields
        private UnityEngine.UIElements.BaseRuntimePanel m_Panel;  // 0x18
        private readonly UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent;  // 0x20
        private System.Boolean m_Selecting;  // 0x28
        private UnityEngine.Event m_Event;  // 0x30
        private static UnityEngine.EventModifiers s_Modifiers;  // static @ 0x0

        // Properties
        UnityEngine.UIElements.IPanel panel { get; /* RVA: 0x01041090 */ set; /* RVA: 0x09F7AED0 */ }
        UnityEngine.GameObject selectableGameObject { get; /* RVA: 0x09F7AEBC */ }
        UnityEngine.EventSystems.EventSystem eventSystem { get; /* RVA: 0x09F7AE6C */ }

        // Methods
        // RVA: 0x09F796F4  token: 0x60005D4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09F79658  token: 0x60005D5
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09F7A5A8  token: 0x60005D6
        private System.Void RegisterCallbacks() { }
        // RVA: 0x09F7AB6C  token: 0x60005D7
        private System.Void UnregisterCallbacks() { }
        // RVA: 0x09F797D8  token: 0x60005D8
        private System.Void OnPanelDestroyed() { }
        // RVA: 0x09F79660  token: 0x60005D9
        private System.Void OnElementFocus(UnityEngine.UIElements.FocusEvent e) { }
        // RVA: 0x0350B670  token: 0x60005DA
        private System.Void OnElementBlur(UnityEngine.UIElements.BlurEvent e) { }
        // RVA: 0x09F79FD8  token: 0x60005DB
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F79644  token: 0x60005DC
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F79C58  token: 0x60005DD
        public virtual System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F79D44  token: 0x60005DE
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F797E4  token: 0x60005DF
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F79A1C  token: 0x60005E0
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F799A8  token: 0x60005E1
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7A070  token: 0x60005E2
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F79578  token: 0x60005E3
        public virtual System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x09F796FC  token: 0x60005E4
        public virtual System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        // RVA: 0x09F79E98  token: 0x60005E5
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09F7A750  token: 0x60005E6
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData) { }
        // RVA: 0x09F7A79C  token: 0x60005E7
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent) { }
        // RVA: 0x09F7AD14  token: 0x60005E8
        private System.Void Update() { }
        // RVA: 0x09F7956C  token: 0x60005E9
        private System.Void LateUpdate() { }
        // RVA: 0x09F7A13C  token: 0x60005EA
        private System.Void ProcessImguiEvents(System.Boolean isSelected) { }
        // RVA: 0x09F7A288  token: 0x60005EB
        private System.Void ProcessKeyboardEvent(UnityEngine.Event e) { }
        // RVA: 0x09F7A384  token: 0x60005EC
        private System.Void ProcessTabEvent(UnityEngine.Event e) { }
        // RVA: 0x09F7A9BC  token: 0x60005ED
        private System.Void SendTabEvent(UnityEngine.Event e, System.Int32 direction) { }
        // RVA: 0x09F7A8D4  token: 0x60005EE
        private System.Void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers) { }
        // RVA: 0x09F7A7EC  token: 0x60005EF
        private System.Void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers) { }
        // RVA: 0x09F7AA80  token: 0x60005F0
        private System.Void SendTextEvent(UnityEngine.Event e, System.Char c, UnityEngine.EventModifiers modifiers) { }
        // RVA: 0x09F7A3F8  token: 0x60005F1
        private System.Boolean ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType) { }
        // RVA: 0x09F7ADD4  token: 0x60005F2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009B  // size: 0x28
    public class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
    {
        // Fields
        private UnityEngine.UIElements.BaseRuntimePanel m_Panel;  // 0x20

        // Properties
        UnityEngine.UIElements.IPanel panel { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x09F7B594 */ }
        UnityEngine.GameObject selectableGameObject { get; /* RVA: 0x09F7B564 */ }
        System.Int32 sortOrderPriority { get; /* RVA: 0x09F7B578 */ }
        System.Int32 renderOrderPriority { get; /* RVA: 0x09F7B54C */ }
        UnityEngine.Camera eventCamera { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09F7B424  token: 0x6000622
        private System.Void RegisterCallbacks() { }
        // RVA: 0x09F7B4B8  token: 0x6000623
        private System.Void UnregisterCallbacks() { }
        // RVA: 0x09F7AF40  token: 0x6000624
        private System.Void OnPanelDestroyed() { }
        // RVA: 0x09F7AF4C  token: 0x6000628
        public virtual System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        // RVA: 0x03D70290  token: 0x600062A
        private static System.Int32 ConvertFloatBitsToInt(System.Single f) { }
        // RVA: 0x0426FE60  token: 0x600062B
        public System.Void .ctor() { }

    }

}

