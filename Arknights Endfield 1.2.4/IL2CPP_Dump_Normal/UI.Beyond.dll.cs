// ========================================================
// Dumped by @desirepro
// Assembly: UI.Beyond.dll
// Classes:  357
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x20
    public class UIMinSizeAdjust : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform _panelRect;  // 0x18

        // Methods
        // RVA: 0x09AB04D4  token: 0x6000001
        private System.Void Start() { }
        // RVA: 0x09AB04DC  token: 0x6000002
        private System.Void _SetTextureScaleByWidth() { }
        // RVA: 0x0426FE60  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x18
    public abstract class RichTextInfo
    {
        // Fields
        public System.Int32 index;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600008B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x38
    public class InlineImageInfo : RichTextInfo
    {
        // Fields
        public System.String path;  // 0x18
        public System.Single width;  // 0x20
        public System.Single height;  // 0x24
        public UnityEngine.Color color;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600008C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct RichTextTagType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIText.RichTextTagType Image;  // const
        public static Beyond.UI.UIText.RichTextTagType Width;  // const
        public static Beyond.UI.UIText.RichTextTagType Height;  // const
        public static Beyond.UI.UIText.RichTextTagType Scale;  // const
        public static Beyond.UI.UIText.RichTextTagType Color;  // const

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct RichTextStyleSeq
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIText.RichTextStyleSeq NORMAL;  // const
        public static Beyond.UI.UIText.RichTextStyleSeq DARK_BACKGROUND;  // const
        public static Beyond.UI.UIText.RichTextStyleSeq LIGHT_BACKGROUND;  // const

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct ParamValueType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType None;  // const
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType String;  // const
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType Int;  // const
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType Float;  // const
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType Color;  // const

    }

    // TypeToken: 0x2000015  // size: 0x18
    public sealed struct RichTextTag
    {
        // Fields
        public Beyond.UI.UIText.RichTextTagType richTextTagType;  // 0x10
        public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType;  // 0x14

    }

    // TypeToken: 0x2000016  // size: 0x28
    public sealed struct RichTextParam
    {
        // Fields
        public Beyond.UI.UIText.RichTextTagType richTextTagType;  // 0x10
        public Beyond.UI.UIText.RichTextAnalyzer.AnyTypeStruct value;  // 0x18

    }

    // TypeToken: 0x2000017  // size: 0x20
    public sealed struct AnyTypeStruct
    {
        // Fields
        public System.Int32 intValue;  // 0x10
        public System.Single floatValue;  // 0x10
        public System.String stringValue;  // 0x10
        public UnityEngine.Color colorValue;  // 0x10

    }

    // TypeToken: 0x2000018  // size: 0x80
    public sealed class ProcessRichTextEntryFunc : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x022B3460  token: 0x6000095
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500C9D0  token: 0x6000096
        public virtual Beyond.UI.UIText.RichTextInfo Invoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        // RVA: 0x09AAF33C  token: 0x6000097
        public virtual System.IAsyncResult BeginInvoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C1584  token: 0x6000098
        public virtual Beyond.UI.UIText.RichTextInfo EndInvoke(Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class RichTextAnalyzer
    {
        // Fields
        private static System.Char CUSTOM_RICH_TEXT_LEFT_BRACKET;  // const
        private static System.Char CUSTOM_RICH_TEXT_RIGHT_BRACKET;  // const
        private static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag> s_tagToTypeDic;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag> s_tagAttributeToTypeDic;  // static @ 0x8
        public static System.String FONT_SHADOW_OPENING_TAG;  // const
        public static System.String FONT_SHADOW_CLOSING_TAG;  // const
        public static System.String FONT_MAT_OPENING_TAG;  // const
        public static System.String FONT_MAT_CLOSING_TAG;  // const
        private static readonly System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> s_subParams;  // static @ 0x10

        // Methods
        // RVA: 0x025DEA10  token: 0x600008D
        public static System.String PreAnalyzeRichText(System.String text, System.Boolean needParseActionId) { }
        // RVA: 0x025E01F0  token: 0x600008E
        public static System.String AnalyzeRichText(System.String text, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& infos) { }
        // RVA: 0x02EB7ED0  token: 0x600008F
        private static System.Boolean _TryParseRichTextEntry(System.ReadOnlySpan<System.Char> span, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, Beyond.UI.UIText.RichTextInfo& richTextInfo) { }
        // RVA: 0x02EB9AC0  token: 0x6000090
        private static System.Boolean _TryParseParam(System.ReadOnlySpan<System.Char> span, System.Boolean& isMain, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& param) { }
        // RVA: 0x09AAF650  token: 0x6000091
        public static Beyond.UI.UIText.RichTextInfo ProcessRichTextEntryFallback(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        // RVA: 0x09AAF3E4  token: 0x6000092
        public static System.Int32 GetCharacterCountWithoutRichText(System.ReadOnlySpan<System.Char> str) { }
        // RVA: 0x02EB9A40  token: 0x6000093
        private static System.Int32 _GetHashCode(System.ReadOnlySpan<System.Char> str) { }
        // RVA: 0x02EB7BD0  token: 0x6000094
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x28
    public class HyperlinkUITextWrap
    {
        // Fields
        public Beyond.UI.UIText uiText;  // 0x10
        public System.String hyperlinkUITextGroupId;  // 0x18
        public System.Int32 order;  // 0x20
        public System.Boolean isDisplayable;  // 0x24

        // Methods
        // RVA: 0x09AAE844  token: 0x6000099
        public System.Void Clear() { }
        // RVA: 0x0350B670  token: 0x600009A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x28
    public class HyperlinkUITextGroup
    {
        // Fields
        public System.Collections.Generic.HashSet<Beyond.UI.UIText.HyperlinkUITextWrap> wrapSet;  // 0x10
        public System.String groupId;  // 0x18
        public System.Int32 displayableCount;  // 0x20

        // Methods
        // RVA: 0x09AADC60  token: 0x600009B
        public System.Void Add(Beyond.UI.UIText.HyperlinkUITextWrap wrap) { }
        // RVA: 0x09AADD80  token: 0x600009C
        public System.Void Remove(Beyond.UI.UIText.HyperlinkUITextWrap wrap) { }
        // RVA: 0x09AADCFC  token: 0x600009D
        public System.Void ChangeDisplayable(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Boolean displayable) { }
        // RVA: 0x09AADE1C  token: 0x600009E
        private System.Void _AddDisplayableCount() { }
        // RVA: 0x09AADF44  token: 0x600009F
        private System.Void _SubDisplayableCount() { }
        // RVA: 0x09AADE78  token: 0x60000A0
        private System.Void _NotifyDisplayableChanged() { }
        // RVA: 0x09AADF9C  token: 0x60000A1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.UI.UIText.HyperlinkUITextManager.<>c <>9;  // static @ 0x0
        public static System.Comparison<Beyond.UI.UIText.HyperlinkUITextWrap> <>9__13_0;  // static @ 0x8
        public static System.Action<Beyond.UI.UIText.HyperlinkUITextGroup> <>9__16_0;  // static @ 0x10
        public static System.Action<Beyond.UI.UIText.HyperlinkUITextWrap> <>9__16_1;  // static @ 0x18

        // Methods
        // RVA: 0x03D14B70  token: 0x60000AE
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60000AF
        public System.Void .ctor() { }
        // RVA: 0x09AAF7A4  token: 0x60000B0
        private System.Int32 <GetGroupDisplayableUIText>b__13_0(Beyond.UI.UIText.HyperlinkUITextWrap a, Beyond.UI.UIText.HyperlinkUITextWrap b) { }
        // RVA: 0x09AAF8C4  token: 0x60000B1
        private System.Void <.ctor>b__16_0(Beyond.UI.UIText.HyperlinkUITextGroup group) { }
        // RVA: 0x09AAF918  token: 0x60000B2
        private System.Void <.ctor>b__16_1(Beyond.UI.UIText.HyperlinkUITextWrap wrap) { }

    }

    // TypeToken: 0x200001B  // size: 0x28
    public class HyperlinkUITextManager
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIText.HyperlinkUITextGroup> m_hyperlinkUITextGroupMap;  // 0x10
        private Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextGroup> m_hyperlinkUITextGroupPool;  // 0x18
        private Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextWrap> m_hyperlinkUITextWrapPool;  // 0x20
        private static Beyond.UI.UIText.HyperlinkUITextManager s_instance;  // static @ 0x0
        private static readonly System.Collections.Generic.List<Beyond.UI.UIText.HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST;  // static @ 0x8

        // Properties
        Beyond.UI.UIText.HyperlinkUITextManager instance { get; /* RVA: 0x0239EF30 */ }

        // Methods
        // RVA: 0x09AAE03C  token: 0x60000A3
        public System.Void AddWrap(Beyond.UI.UIText uiText, System.String groupId, System.Int32 order) { }
        // RVA: 0x0285F940  token: 0x60000A4
        public System.Void RemoveWrap(Beyond.UI.UIText uiText) { }
        // RVA: 0x09AAE188  token: 0x60000A5
        public System.Void ChangeWrapGroup(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.String newGroupId, System.Int32 newOrder) { }
        // RVA: 0x09AAE2EC  token: 0x60000A6
        public System.Void ChangeWrapOrder(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Int32 newOrder) { }
        // RVA: 0x0239F030  token: 0x60000A7
        public System.Void UpdateWrapDisplayable(Beyond.UI.UIText uiText) { }
        // RVA: 0x03A4E270  token: 0x60000A8
        public System.Boolean IsGroupDisplayable(System.String groupId) { }
        // RVA: 0x09AAE358  token: 0x60000A9
        public System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableUIText(System.String groupId) { }
        // RVA: 0x03A4E2C0  token: 0x60000AA
        private Beyond.UI.UIText.HyperlinkUITextGroup _GetGroup(System.String groupId, System.Boolean autoCreate) { }
        // RVA: 0x0239F180  token: 0x60000AB
        private System.Boolean _IsUITextDisplayable(Beyond.UI.UIText uiText) { }
        // RVA: 0x039281D0  token: 0x60000AC
        public System.Void .ctor() { }
        // RVA: 0x03CDF6E0  token: 0x60000AD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x28
    public sealed struct ImageGOInfo
    {
        // Fields
        public UnityEngine.GameObject go;  // 0x10
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.UI.Image image;  // 0x20

    }

    // TypeToken: 0x200001E  // size: 0x28
    public sealed class <_DelayedChangeActiveImageGo>d__110 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIText <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000B3
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000B4
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0228B0F0  token: 0x60000B5
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0228C6A0  token: 0x60000B7
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000020  // size: 0x14
    public sealed struct AnimationState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIConst.AnimationState Stop;  // const
        public static Beyond.UI.UIConst.AnimationState In;  // const
        public static Beyond.UI.UIConst.AnimationState Loop;  // const
        public static Beyond.UI.UIConst.AnimationState Out;  // const
        public static Beyond.UI.UIConst.AnimationState InEasing;  // const
        public static Beyond.UI.UIConst.AnimationState Others;  // const

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct CommonUISegment
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIConst.CommonUISegment InteractiveEntity;  // const
        public static Beyond.UI.UIConst.CommonUISegment LevelScriptModule;  // const

    }

    // TypeToken: 0x2000023  // size: 0x48
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public Beyond.UI.UIModelLoader <>4__this;  // 0x10
        public System.Int32 requestId;  // 0x18
        public Beyond.Resource.FAssetProxyHandle handle;  // 0x1c
        public System.String modelPath;  // 0x30
        public UnityEngine.Transform parent;  // 0x38
        public System.Action<UnityEngine.GameObject> callback;  // 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x60000C9
        public System.Void .ctor() { }
        // RVA: 0x09AAF938  token: 0x60000CA
        private System.Void <LoadModelAsync>b__0(Beyond.Resource.FAssetProxyUntrackedHandle proxy) { }

    }

    // TypeToken: 0x200002A  // size: 0x50
    public class MeunItemInfo
    {
        // Fields
        public Beyond.UI.UIButton button;  // 0x10
        public Beyond.UI.UIToggle toggle;  // 0x18
        public System.Boolean showIcon;  // 0x20
        public UnityEngine.Sprite sprite;  // 0x28
        public Beyond.UI.UIText text;  // 0x30
        public System.String textId;  // 0x38
        public System.String textIdForToggleOff;  // 0x40
        public System.Int32 priority;  // 0x48

        // Properties
        System.Boolean isForceValid { get; /* RVA: 0x09AAEFD4 */ }

        // Methods
        // RVA: 0x09AAEEB8  token: 0x60000F3
        public System.Boolean IsValid() { }
        // RVA: 0x09AAED88  token: 0x60000F4
        public System.String GetText() { }
        // RVA: 0x09AAEC78  token: 0x60000F5
        public UnityEngine.Sprite GetSprite() { }
        // RVA: 0x09AAE9D4  token: 0x60000F6
        public System.Void Execute() { }
        // RVA: 0x09AAEB50  token: 0x60000F7
        public System.String GetItemName() { }
        // RVA: 0x03D59690  token: 0x60000F8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x14
    public sealed struct OverrideValidState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CustomUIStyle.OverrideValidState None;  // const
        public static Beyond.UI.CustomUIStyle.OverrideValidState ForceValid;  // const
        public static Beyond.UI.CustomUIStyle.OverrideValidState ForceNotValid;  // const

    }

    // TypeToken: 0x2000037  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnEnable;  // const
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnDisable;  // const
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnDestroy;  // const

    }

    // TypeToken: 0x200003B  // size: 0x28
    public sealed class <_AutoAnimationInFinish>d__61 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.LuaPanel <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600015E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600015F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02872520  token: 0x6000160
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AAFD78  token: 0x6000162
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003F  // size: 0x14
    public sealed struct ShapeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.NonDrawingGraphic.ShapeType Rectangle;  // const
        public static Beyond.UI.NonDrawingGraphic.ShapeType Circle;  // const

    }

    // TypeToken: 0x2000041
    public sealed class <>c__19`1
    {
        // Fields
        public static readonly Beyond.UI.NotchAdapter.<>c__19<T> <>9;  // static @ 0x0
        public static System.Predicate<T> <>9__19_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600018B
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x600018C
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600018D
        private System.Boolean <_RemoveNullRef>b__19_0(T x) { }

    }

    // TypeToken: 0x2000043  // size: 0x28
    public class ParallaxConfig
    {
        // Fields
        public UnityEngine.RectTransform target;  // 0x10
        public System.Single ratio;  // 0x18
        public UnityEngine.Vector2 oriPosition;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x6000194
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public interface ICustomViewType
    {
        // Properties
        System.Int32 viewType { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000047
    public interface ICustomSpacing
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001A3
        public virtual System.Single GetCustomSpacing() { }

    }

    // TypeToken: 0x2000048
    public interface IVirtualView : Beyond.IHotfixable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001A4
        public virtual System.Void AttachView(UnityEngine.GameObject view) { }
        // RVA: -1  // abstract  token: 0x60001A5
        public virtual System.Void DetachView() { }
        // RVA: -1  // abstract  token: 0x60001A6
        public virtual UnityEngine.GameObject GetAttachedView() { }
        // RVA: -1  // abstract  token: 0x60001A7
        public virtual System.Int32 GetViewID() { }
        // RVA: -1  // abstract  token: 0x60001A8
        public virtual UnityEngine.GameObject GetPrefab() { }
        // RVA: -1  // abstract  token: 0x60001A9
        public virtual System.Single GetPreferSize() { }

    }

    // TypeToken: 0x2000049  // size: 0x18
    public abstract class VirtualView : IVirtualView, Beyond.IHotfixable
    {
        // Fields
        protected UnityEngine.GameObject m_gameObj;  // 0x10

        // Properties
        System.Boolean isAttached { get; /* RVA: 0x09ACA6F8 */ }

        // Methods
        // RVA: 0x09ACA540  token: 0x60001AB
        public virtual System.Void AttachView(UnityEngine.GameObject gameObj) { }
        // RVA: 0x09ACA5EC  token: 0x60001AC
        public virtual System.Void DetachView() { }
        // RVA: 0x09ACA650  token: 0x60001AD
        public virtual UnityEngine.GameObject GetAttachedView() { }
        // RVA: 0x09ACA6A0  token: 0x60001AE
        public virtual System.Int32 GetViewID() { }
        // RVA: -1  // abstract  token: 0x60001AF
        protected virtual System.Void OnViewAttached() { }
        // RVA: -1  // abstract  token: 0x60001B0
        protected virtual System.Void OnViewDetached() { }
        // RVA: -1  // abstract  token: 0x60001B1
        public virtual UnityEngine.GameObject GetPrefab() { }
        // RVA: -1  // abstract  token: 0x60001B2
        public virtual System.Single GetPreferSize() { }
        // RVA: 0x0350B670  token: 0x60001B3
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class SimpleAdapter : Beyond.UI.UIRecycleLayoutAdapter
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> m_holder;  // 0x0
        private System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> m_virtualViews;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001C3
        public System.Void .ctor(Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> holder) { }
        // RVA: -1  // not resolved  token: 0x60001C4
        public virtual System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        // RVA: -1  // not resolved  token: 0x60001C5
        public System.Void NotifyRebuild() { }
        // RVA: -1  // not resolved  token: 0x60001C6
        public System.Void InsertView(System.Int32 index, TVirtualView virtualView) { }
        // RVA: -1  // not resolved  token: 0x60001C7
        public System.Void AppendView(TVirtualView virtualView) { }
        // RVA: -1  // not resolved  token: 0x60001C8
        public System.Void AddView(TVirtualView virtualView) { }
        // RVA: -1  // not resolved  token: 0x60001C9
        public System.Void RemoveView(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001CA
        public System.Void RemoveAllViews(System.Boolean dontRebuild) { }
        // RVA: -1  // not resolved  token: 0x60001CB
        public System.Int32 GetCount() { }
        // RVA: -1  // not resolved  token: 0x60001CC
        public TVirtualView GetVirtualView(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001CD
        public UnityEngine.GameObject GetView(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001CE
        public System.Void NotifySizeChanged(TVirtualView virtualView) { }
        // RVA: -1  // not resolved  token: 0x60001CF
        public System.Void NotifyAllSizeChanged() { }
        // RVA: -1  // not resolved  token: 0x60001D0
        public System.Void NotifySizeChanged(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001D1
        public virtual System.Void OnInit() { }
        // RVA: -1  // not resolved  token: 0x60001D2
        public System.Void OnDisposed() { }

    }

    // TypeToken: 0x200004C
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> <>4__this;  // 0x0
        public System.Int32 naviIndex;  // 0x0
        public System.Boolean isBefore;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001D3
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001D4
        private System.Void <_WrapNavigation>b__0() { }

    }

    // TypeToken: 0x200004E  // size: 0x14
    public sealed struct Direction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIRecycleLayoutGroup.Direction Vertical;  // const
        public static Beyond.UI.UIRecycleLayoutGroup.Direction Horizontal;  // const

    }

    // TypeToken: 0x200004F  // size: 0x14
    public sealed struct AdaptMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIRecycleLayoutGroup.AdaptMode Normal;  // const
        public static Beyond.UI.UIRecycleLayoutGroup.AdaptMode MultiPrefab;  // const

    }

    // TypeToken: 0x2000050
    public interface IViewHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001FA
        public virtual Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x60001FB
        public virtual System.Int32 GetViewCount() { }
        // RVA: -1  // abstract  token: 0x60001FC
        public virtual System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: -1  // abstract  token: 0x60001FD
        public virtual System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: -1  // abstract  token: 0x60001FE
        public virtual System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: -1  // abstract  token: 0x60001FF
        public virtual System.Void NotifyAllViewSizeChanged() { }
        // RVA: -1  // abstract  token: 0x6000200
        public virtual System.Void NotifyRebuild() { }
        // RVA: -1  // abstract  token: 0x6000201
        public virtual System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: -1  // abstract  token: 0x6000202
        public virtual System.Single GetElementPosByIndex(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x6000203
        public virtual UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x6000204
        public virtual Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection() { }
        // RVA: -1  // abstract  token: 0x6000205
        public virtual System.Single GetSizeOnAxis() { }
        // RVA: -1  // abstract  token: 0x6000206
        public virtual System.Single GetViewportSizeOnAxis() { }
        // RVA: -1  // abstract  token: 0x6000207
        public virtual System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }

    }

    // TypeToken: 0x2000051  // size: 0x20
    public sealed struct LayoutMeta
    {
        // Fields
        public System.Single pos;  // 0x10
        public System.Single size;  // 0x14
        public System.Int32 index;  // 0x18
        public System.Single curTotalSize;  // 0x1c

    }

    // TypeToken: 0x2000052  // size: 0x38
    public class ViewPool
    {
        // Fields
        private UnityEngine.GameObject m_prefab;  // 0x10
        private UnityEngine.Transform m_container;  // 0x18
        private System.Collections.Generic.List<UnityEngine.GameObject> m_activeObjs;  // 0x20
        private System.Collections.Generic.List<UnityEngine.GameObject> m_pooledObjs;  // 0x28
        private System.Int32 <viewType>k__BackingField;  // 0x30

        // Properties
        System.Int32 viewType { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }

        // Methods
        // RVA: 0x09ACA450  token: 0x600020A
        public System.Void .ctor(System.Int32 viewType, UnityEngine.GameObject prefab, UnityEngine.Transform container) { }
        // RVA: 0x09AC9FD8  token: 0x600020B
        public UnityEngine.GameObject Alloc(System.Boolean& isNewlyCreated) { }
        // RVA: 0x09ACA2A4  token: 0x600020C
        public System.Boolean Recycle(UnityEngine.GameObject obj) { }
        // RVA: 0x09ACA168  token: 0x600020D
        public System.Void RecycleAll() { }

    }

    // TypeToken: 0x2000053  // size: 0x28
    public class ViewMgr : Beyond.IHotfixable, IViewHandler
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup m_closure;  // 0x10
        private Beyond.ListDict<System.Int32,Beyond.UI.UIRecycleLayoutGroup.ViewPool> m_viewPools;  // 0x18
        private System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> m_views;  // 0x20

        // Methods
        // RVA: 0x09AC9F00  token: 0x600020E
        public System.Void .ctor(Beyond.UI.UIRecycleLayoutGroup closure) { }
        // RVA: 0x09AC9A24  token: 0x600020F
        public System.Void RebuildAll(Beyond.UI.UIRecycleLayoutAdapter adapter) { }
        // RVA: 0x09AC9828  token: 0x6000210
        public System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GetViews() { }
        // RVA: 0x09AC93DC  token: 0x6000211
        public System.Void DetachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, UnityEngine.GameObject curView) { }
        // RVA: 0x09AC92F0  token: 0x6000212
        public System.Void AttachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9708  token: 0x6000213
        public virtual Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index) { }
        // RVA: 0x09AC9694  token: 0x6000214
        public virtual System.Int32 GetViewCount() { }
        // RVA: 0x09AC9878  token: 0x6000215
        public virtual System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9254  token: 0x6000216
        public virtual System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9C78  token: 0x6000217
        public virtual System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC99B4  token: 0x6000218
        public virtual System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9900  token: 0x6000219
        public virtual System.Void NotifyAllViewSizeChanged() { }
        // RVA: 0x09AC995C  token: 0x600021A
        public virtual System.Void NotifyRebuild() { }
        // RVA: 0x09AC95D0  token: 0x600021B
        public virtual System.Single GetElementPosByIndex(System.Int32 index) { }
        // RVA: 0x09AC94CC  token: 0x600021C
        public virtual UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index) { }
        // RVA: 0x09AC9474  token: 0x600021D
        public virtual Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection() { }
        // RVA: 0x09AC9638  token: 0x600021E
        public virtual System.Single GetSizeOnAxis() { }
        // RVA: 0x09AC9790  token: 0x600021F
        public virtual System.Single GetViewportSizeOnAxis() { }
        // RVA: 0x09AC9564  token: 0x6000220
        public virtual System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9CEC  token: 0x6000221
        private Beyond.UI.UIRecycleLayoutGroup.ViewPool _EnsureViewPool(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC9E6C  token: 0x6000222
        private System.Void _NotifyLayoutChanged(System.Int32 fromIndex) { }

    }

    // TypeToken: 0x2000054  // size: 0x20
    public sealed struct Padding
    {
        // Fields
        public System.Int32 top;  // 0x10
        public System.Int32 left;  // 0x14
        public System.Int32 bottom;  // 0x18
        public System.Int32 right;  // 0x1c

    }

    // TypeToken: 0x2000055  // size: 0x18
    public class EmptyAdapter : Beyond.UI.UIRecycleLayoutAdapter
    {
        // Methods
        // RVA: 0x09ABFF90  token: 0x6000223
        public virtual System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        // RVA: 0x09ABFFDC  token: 0x6000224
        public virtual System.Void OnInit() { }
        // RVA: 0x0350B670  token: 0x6000225
        public System.Void .ctor() { }
        // RVA: 0x09AC0020  token: 0x6000226
        public System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> <>iFixBaseProxy_GenerateViewsForRebuild() { }

    }

    // TypeToken: 0x2000057  // size: 0x30
    public class MultiVirtualView : VirtualView
    {
        // Fields
        private Beyond.UI.UIRecycleMultiHolder m_closure;  // 0x18
        public System.Single preferSize;  // 0x20
        public System.String prefabKey;  // 0x28

        // Methods
        // RVA: 0x09AC0028  token: 0x600022F
        public System.Int32 GetIndex() { }
        // RVA: 0x09AC0300  token: 0x6000230
        public System.Void .ctor(System.Single initSize, System.String key, Beyond.UI.UIRecycleMultiHolder closure) { }
        // RVA: 0x09AC00F4  token: 0x6000231
        public virtual UnityEngine.GameObject GetPrefab() { }
        // RVA: 0x09AC0178  token: 0x6000232
        public virtual System.Single GetPreferSize() { }
        // RVA: 0x09AC0264  token: 0x6000233
        protected virtual System.Void OnViewDetached() { }
        // RVA: 0x09AC01C8  token: 0x6000234
        protected virtual System.Void OnViewAttached() { }

    }

    // TypeToken: 0x2000058  // size: 0x20
    public class Config
    {
        // Fields
        public System.String key;  // 0x10
        public UnityEngine.GameObject cellTemplate;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000235
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005A  // size: 0x28
    public class SimpleVirtualView : VirtualView
    {
        // Fields
        private Beyond.UI.UIRecycleSingleHolder m_holder;  // 0x18
        public System.Single preferSize;  // 0x20

        // Methods
        // RVA: 0x09AC0FA4  token: 0x600023E
        public System.Int32 GetIndex() { }
        // RVA: 0x09AC1278  token: 0x600023F
        public System.Void .ctor(System.Single initSize, Beyond.UI.UIRecycleSingleHolder holder) { }
        // RVA: 0x09AC105C  token: 0x6000240
        public virtual UnityEngine.GameObject GetPrefab() { }
        // RVA: 0x09AC10B8  token: 0x6000241
        public virtual System.Single GetPreferSize() { }
        // RVA: 0x09AC11C0  token: 0x6000242
        protected virtual System.Void OnViewDetached() { }
        // RVA: 0x09AC1108  token: 0x6000243
        protected virtual System.Void OnViewAttached() { }

    }

    // TypeToken: 0x200005D  // size: 0x30
    public class CellInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public UnityEngine.GameObject obj;  // 0x18
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x20
        public UnityEngine.Coroutine cor;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000258
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005E  // size: 0x38
    public sealed class <_ShowCell>d__23 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Int32 delayIndex;  // 0x20
        public Beyond.UI.ToastList.CellInfo cell;  // 0x28
        public Beyond.UI.ToastList <>4__this;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000259
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600025A
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AC23A4  token: 0x600025B
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AC25F8  token: 0x600025D
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000062  // size: 0x20
    public class ClipHolder
    {
        // Fields
        public UnityEngine.AnimationClip clip;  // 0x10
        public System.String alias;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600028F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x28
    public class AnimationRuntime
    {
        // Fields
        public Beyond.UI.UIAnimationTween.Options option;  // 0x10
        public UnityEngine.AnimationState state;  // 0x18
        public System.Boolean isPlaying;  // 0x20

        // Methods
        // RVA: 0x025CF420  token: 0x60002C7
        public System.Single GetClipLength() { }
        // RVA: 0x0350B670  token: 0x60002C8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct FOptions : Beyond.ILuaCallCSharp
    {
        // Fields
        public DG.Tweening.Ease animEase;  // 0x10

        // Methods
        // RVA: 0x028159A0  token: 0x60002C9
        public static Beyond.UI.UIAnimationWrapper.FOptions GetDefault() { }

    }

    // TypeToken: 0x2000067  // size: 0x20
    public sealed struct CachedSampleClipInfo
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime;  // 0x10
        public System.Single position;  // 0x18
        public System.Boolean isDirty;  // 0x1c

        // Methods
        // RVA: 0x04271BD0  token: 0x60002CA
        public System.Void .ctor(System.Boolean isDirty) { }

    }

    // TypeToken: 0x2000068  // size: 0x20
    public sealed class <>c__DisplayClass35_0
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper <>4__this;  // 0x10
        public DG.Tweening.TweenCallback callback;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60002CB
        public System.Void .ctor() { }
        // RVA: 0x036B95E0  token: 0x60002CC
        private System.Void <PlayOutAnimation>b__0() { }

    }

    // TypeToken: 0x2000069  // size: 0x28
    public sealed class <>c__DisplayClass44_0
    {
        // Fields
        public DG.Tweening.TweenCallback callback;  // 0x10
        public Beyond.UI.UIAnimationWrapper <>4__this;  // 0x18
        public System.Boolean autoPlayLoop;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60002CD
        public System.Void .ctor() { }
        // RVA: 0x0228CD50  token: 0x60002CE
        private System.Void <PlayInAnimation>b__0() { }

    }

    // TypeToken: 0x200006A  // size: 0x20
    public sealed class <>c__DisplayClass51_0
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper <>4__this;  // 0x10
        public System.Boolean autoPlayLoop;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60002CF
        public System.Void .ctor() { }
        // RVA: 0x0228CD90  token: 0x60002D0
        private System.Void <_OnInAnimationFinished>b__0() { }

    }

    // TypeToken: 0x200006B  // size: 0x28
    public sealed class <>c__DisplayClass72_0
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper <>4__this;  // 0x10
        public DG.Tweening.TweenCallback onComplete;  // 0x18
        public Beyond.UI.UIAnimationTween animTween;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60002D1
        public System.Void .ctor() { }
        // RVA: 0x0228CDC0  token: 0x60002D2
        private System.Void <PlayWithTween>b__0() { }

    }

    // TypeToken: 0x200006D  // size: 0x18
    public sealed struct Options
    {
        // Fields
        public System.Boolean isInverse;  // 0x10
        public System.Single startPosition;  // 0x14

    }

    // TypeToken: 0x200006E  // size: 0x28
    public sealed class <>c__DisplayClass14_0
    {
        // Fields
        public Beyond.UI.UIAnimationTween <>4__this;  // 0x10
        public Beyond.UI.UIAnimationWrapper wrapper;  // 0x18
        public System.String name;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60002DC
        public System.Void .ctor() { }
        // RVA: 0x025CD4D0  token: 0x60002DD
        private System.Void <.ctor>b__0(System.Single value) { }
        // RVA: 0x025CD510  token: 0x60002DE
        private System.Void <.ctor>b__2(System.Single value) { }

    }

    // TypeToken: 0x200006F  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.UI.UIAnimationTween.<>c <>9;  // static @ 0x0
        public static DG.Tweening.Core.DOGetter<System.Single> <>9__14_1;  // static @ 0x8

        // Methods
        // RVA: 0x03D10C10  token: 0x60002DF
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60002E0
        public System.Void .ctor() { }
        // RVA: 0x03D503F0  token: 0x60002E1
        private System.Single <.ctor>b__14_1() { }

    }

    // TypeToken: 0x2000071  // size: 0x30
    public class TweenHandler : ITweenHandler, Beyond.IHotfixable
    {
        // Fields
        private Beyond.UI.UIAnimationSwitchTween m_closure;  // 0x10
        private System.Boolean m_isIn;  // 0x18
        private System.Boolean m_pendingClear;  // 0x19
        private DG.Tweening.TweenCallback m_pendingCallback;  // 0x20
        private System.Boolean m_isComplete;  // 0x28

        // Methods
        // RVA: 0x09AC22B4  token: 0x60002EC
        public System.Void .ctor(Beyond.UI.UIAnimationSwitchTween closure, System.Boolean isIn) { }
        // RVA: 0x09AC1FF0  token: 0x60002ED
        public virtual System.Boolean IsPlaying() { }
        // RVA: 0x09AC20B8  token: 0x60002EE
        public virtual System.Void KillIfNecessary() { }
        // RVA: 0x09AC2178  token: 0x60002EF
        public virtual Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09AC21F4  token: 0x60002F0
        public virtual Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }
        // RVA: 0x09AC224C  token: 0x60002F1
        private System.Void _OnComplete() { }

    }

    // TypeToken: 0x2000072  // size: 0x20
    public sealed struct Builder
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper animWrapper;  // 0x10
        public System.Boolean dontDisableGameObject;  // 0x18

        // Methods
        // RVA: 0x09ABFEEC  token: 0x60002F2
        public Beyond.UI.UIAnimationSwitchTween Build() { }

    }

    // TypeToken: 0x2000078  // size: 0x18
    public sealed class <>c__DisplayClass81_0
    {
        // Fields
        public DG.Tweening.TweenCallback onComplete;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600036E
        public System.Void .ctor() { }
        // RVA: 0x03D4CF30  token: 0x600036F
        private System.Void <FocusNode>b__0() { }

    }

    // TypeToken: 0x200007D  // size: 0x30
    public sealed class <_DoClickAnimation>d__30 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIButton <>4__this;  // 0x20
        private System.Single <currentTime>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003E0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003E1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09ACABAC  token: 0x60003E2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09ACACEC  token: 0x60003E4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200007E  // size: 0x40
    public sealed class <_OnPress>d__59 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIButton <>4__this;  // 0x20
        public UnityEngine.EventSystems.PointerEventData eventData;  // 0x28
        private System.Single <finishTime>5__2;  // 0x30
        private UnityEngine.Vector2 <pressPos>5__3;  // 0x34
        private System.Single <_longPressMaxDragDistSq>5__4;  // 0x3c

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003E6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003E7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02CACAB0  token: 0x60003E8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09ACAD38  token: 0x60003EA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000081  // size: 0x30
    public sealed struct FWorldCanvasParams
    {
        // Fields
        public System.Single screenRatio;  // 0x10
        public UnityEngine.Vector2 screenSize;  // 0x14
        public UnityEngine.Vector2 uiRootSize;  // 0x1c
        public UnityEngine.Vector3 uiRootScale;  // 0x24

    }

    // TypeToken: 0x2000082  // size: 0x24
    public sealed struct FScreenCanvasParams
    {
        // Fields
        public System.Single screenRatio;  // 0x10
        public UnityEngine.Vector2 screenSize;  // 0x14
        public Beyond.UI.CanvasMatchMode matchMode;  // 0x1c
        public System.Single matchWidthOrHeight;  // 0x20

    }

    // TypeToken: 0x2000084  // size: 0x30
    public sealed struct CommonParams
    {
        // Fields
        public System.Single alpha;  // 0x10
        public System.Single duration;  // 0x14
        public System.Boolean ignoreTimeScale;  // 0x18
        public UnityEngine.Color targetColor;  // 0x1c
        public System.Boolean useAlpha;  // 0x2c
        public System.Boolean useRGB;  // 0x2d
        public System.Boolean isStaticColorOpt;  // 0x2e

    }

    // TypeToken: 0x2000085  // size: 0x80
    public sealed class GraphicOpt : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x036F88F0  token: 0x6000412
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x05015A50  token: 0x6000413
        public virtual System.Void Invoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x09ACA748  token: 0x6000414
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000415
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000086  // size: 0x28
    public sealed struct DynEle
    {
        // Fields
        public System.String groupId;  // 0x10
        public UnityEngine.UI.Graphic graphic;  // 0x18
        public System.Boolean useStaticColor;  // 0x20

    }

    // TypeToken: 0x200008A  // size: 0x14
    public sealed struct LayoutType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UICustomLayoutElement.LayoutType None;  // const
        public static Beyond.UI.UICustomLayoutElement.LayoutType LeftToRight;  // const

    }

    // TypeToken: 0x200008B  // size: 0x28
    public class LayoutData
    {
        // Fields
        public System.Int32 verNum;  // 0x10
        public System.Single scale;  // 0x14
        public System.Single alpha;  // 0x18
        public UnityEngine.Vector2 position;  // 0x1c
        public System.Int32 layoutType;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x6000446
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008E  // size: 0x14
    public sealed struct UpdateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIDialogText.UpdateMode Auto;  // const
        public static Beyond.UI.UIDialogText.UpdateMode Manual;  // const

    }

    // TypeToken: 0x2000096  // size: 0x38
    public sealed class <_ContinueDragOnDisable>d__40 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIDragItem <>4__this;  // 0x20
        private UnityEngine.EventSystems.PointerEventData <eData>5__2;  // 0x28
        private Beyond.PoolCore.PooledList<UnityEngine.EventSystems.RaycastResult> <raycastResults>5__3;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60004C1
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60004C2
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09ACA7D0  token: 0x60004C3
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09ACAB60  token: 0x60004C5
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000098  // size: 0x20
    public sealed class <>c__DisplayClass44_0
    {
        // Fields
        public Beyond.UI.UIDropdown <>4__this;  // 0x10
        public System.Boolean activeList;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60004F5
        public System.Void .ctor() { }
        // RVA: 0x09AD4B8C  token: 0x60004F6
        private System.Void <_ToggleOptions>b__0() { }

    }

    // TypeToken: 0x2000099  // size: 0x20
    public sealed class <>c__DisplayClass48_0
    {
        // Fields
        public System.Int32 index;  // 0x10
        public Beyond.UI.UIDropdown <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60004F7
        public System.Void .ctor() { }
        // RVA: 0x02D99980  token: 0x60004F8
        private System.Void <Refresh>b__0(UnityEngine.EventSystems.PointerEventData evt) { }

    }

    // TypeToken: 0x20000A1  // size: 0x20
    public sealed class <>c__DisplayClass11_0
    {
        // Fields
        public System.Single startSize;  // 0x10
        public Beyond.UI.UIFoldoutComponent <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600052C
        public System.Void .ctor() { }
        // RVA: 0x03D4E7A0  token: 0x600052D
        private System.Single <OnFoldOut>b__0() { }
        // RVA: 0x09AD4B58  token: 0x600052E
        private System.Void <OnFoldOut>b__1(System.Single value) { }

    }

    // TypeToken: 0x20000A2  // size: 0x20
    public sealed class <>c__DisplayClass12_0
    {
        // Fields
        public System.Single startSize;  // 0x10
        public Beyond.UI.UIFoldoutComponent <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600052F
        public System.Void .ctor() { }
        // RVA: 0x03D4E7A0  token: 0x6000530
        private System.Single <OnFoldIn>b__0() { }
        // RVA: 0x09AD4B58  token: 0x6000531
        private System.Void <OnFoldIn>b__1(System.Single value) { }

    }

    // TypeToken: 0x20000A6  // size: 0x14
    public sealed struct WrapMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode NaviGroup;  // const
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode ScrollRect;  // const
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode ScrollList;  // const
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode LayoutNaviWrapper;  // const

    }

    // TypeToken: 0x20000A8  // size: 0x20
    public class Param
    {
        // Fields
        public System.Single maxAngle;  // 0x10
        public UnityEngine.AnimationCurve valueCurve;  // 0x18

        // Methods
        // RVA: 0x03D47CC0  token: 0x6000554
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIInertiaViewPager.State IDLE;  // const
        public static Beyond.UI.UIInertiaViewPager.State DRAGING;  // const
        public static Beyond.UI.UIInertiaViewPager.State INERTIA;  // const
        public static Beyond.UI.UIInertiaViewPager.State ALIGNING;  // const

    }

    // TypeToken: 0x20000B2
    public interface IScrollHandler : Beyond.IHotfixable
    {
        // Properties
        System.Single velocity { get; /* RVA: -1  // abstract */ }
        System.Boolean isDragging { get; /* RVA: -1  // abstract */ }
        System.Single scrollProgress { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60005C9
        public virtual System.Void OnClear() { }
        // RVA: -1  // abstract  token: 0x60005CE
        public virtual System.Void StopMoving() { }

    }

    // TypeToken: 0x20000B3  // size: 0x20
    public class CustomScrollHandler : IScrollHandler, Beyond.IHotfixable
    {
        // Fields
        private System.Boolean m_isScrolling;  // 0x10
        private Beyond.UI.UIScrollRect m_scrollRect;  // 0x18

        // Properties
        System.Single velocity { get; /* RVA: 0x09AD442C */ }
        System.Single scrollProgress { get; /* RVA: 0x09AD43A0 */ set; /* RVA: 0x09AD44AC */ }
        System.Boolean isDragging { get; /* RVA: 0x09AD4378 */ }

        // Methods
        // RVA: 0x09AD4258  token: 0x60005CF
        public System.Void .ctor(Beyond.UI.UIScrollRect scrollRect) { }
        // RVA: 0x09AD3FF4  token: 0x60005D0
        public virtual System.Void OnClear() { }
        // RVA: 0x09AD4138  token: 0x60005D5
        public virtual System.Void StopMoving() { }
        // RVA: 0x09AD4198  token: 0x60005D6
        private System.Void _OnScrollBegin(UnityEngine.Vector2 delta) { }
        // RVA: 0x09AD41F8  token: 0x60005D7
        private System.Void _OnScrollEnd(UnityEngine.Vector2 delta) { }

    }

    // TypeToken: 0x20000B4  // size: 0x11
    public sealed struct EmptyScrollHandler : IScrollHandler, Beyond.IHotfixable
    {
        // Properties
        System.Single velocity { get; /* RVA: 0x03D503F0 */ }
        System.Boolean isDragging { get; /* RVA: 0x0115F4C0 */ }
        System.Single scrollProgress { get; /* RVA: 0x03D503F0 */ set; /* RVA: 0x0350B670 */ }

        // Methods
        // RVA: 0x09AD47C4  token: 0x60005DC
        public virtual System.Void StopMoving() { }
        // RVA: 0x09AD4780  token: 0x60005DD
        public virtual System.Void OnClear() { }

    }

    // TypeToken: 0x20000B5  // size: 0x1C
    public sealed struct FlingToNext
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Single minSpd;  // 0x14
        public System.Single maxSpd;  // 0x18

    }

    // TypeToken: 0x20000B6  // size: 0x1C
    public sealed struct ScrollOptions
    {
        // Fields
        public Beyond.UI.UIInertiaViewPager.FlingToNext flingToNext;  // 0x10

    }

    // TypeToken: 0x20000B7  // size: 0x18
    public class DragContext
    {
        // Fields
        public System.Single startPos;  // 0x10

        // Methods
        // RVA: 0x09AD4540  token: 0x60005DE
        public System.Void BeginDrag(Beyond.UI.UIInertiaViewPager pager) { }
        // RVA: 0x09AD45B0  token: 0x60005DF
        public Beyond.UI.UIInertiaViewPager.State EndDrag(Beyond.UI.UIInertiaViewPager pager) { }
        // RVA: 0x09AD461C  token: 0x60005E0
        private System.Boolean _TryFlingToNext(Beyond.UI.UIInertiaViewPager pager) { }
        // RVA: 0x0350B670  token: 0x60005E1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8  // size: 0x14
    public sealed struct BlockerDir
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIInertiaViewPager.BlockerDir UPWARD;  // const
        public static Beyond.UI.UIInertiaViewPager.BlockerDir DOWNNWARD;  // const
        public static Beyond.UI.UIInertiaViewPager.BlockerDir BOTH;  // const

    }

    // TypeToken: 0x20000B9  // size: 0x18
    public sealed struct InertiaBlocker : Beyond.IHotfixable
    {
        // Fields
        public Beyond.UI.UIInertiaViewPager.BlockerDir dir;  // 0x10
        public System.Int32 index;  // 0x14

        // Methods
        // RVA: 0x09AD4808  token: 0x60005E2
        public System.Boolean IsDirMatch(System.Single vec) { }

    }

    // TypeToken: 0x20000BA  // size: 0x20
    public class BlockerManager : Beyond.IHotfixable
    {
        // Fields
        private static System.Single INERTIA_BIAS;  // const
        private System.Collections.Generic.List<Beyond.UI.UIInertiaViewPager.InertiaBlocker> m_inertiaBlockers;  // 0x10
        private System.Single m_lastIndex;  // 0x18
        private System.Boolean <isInertiaing>k__BackingField;  // 0x1c

        // Properties
        System.Boolean isInertiaing { get; /* RVA: 0x03D4E9A0 */ set; /* RVA: 0x03D4E9B0 */ }

        // Methods
        // RVA: 0x09AD3D84  token: 0x60005E5
        public System.Void Init(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> blockFrames) { }
        // RVA: 0x09AD3F1C  token: 0x60005E6
        public System.Void StartInertia(System.Single fromIndex) { }
        // RVA: 0x09AD3B88  token: 0x60005E7
        public System.Boolean HitInertiaBlock(System.Single curIndex, System.Single& preferTo) { }
        // RVA: 0x09AD3F7C  token: 0x60005E8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC  // size: 0x14
    public sealed struct Timing
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing HALF_VALUE;  // const
        public static Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing FULL_VALUE;  // const

    }

    // TypeToken: 0x20000BB  // size: 0x28
    public sealed struct ScrollEffectConfig
    {
        // Fields
        public System.Action onScrollToItem;  // 0x10
        public System.Action onAlignedToItem;  // 0x18
        public System.Single minScrollInterval;  // 0x20
        public Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing timing;  // 0x24

        // Methods
        // RVA: 0x09AD4890  token: 0x60005E9
        public System.Boolean IsEmpty() { }

    }

    // TypeToken: 0x20000BD  // size: 0x40
    public class ScrollEffectTrigger : Beyond.IHotfixable
    {
        // Fields
        private static System.Single DFT_MIN_INTERVAL;  // const
        private System.Boolean m_isValid;  // 0x10
        private Beyond.UI.UIInertiaViewPager.ScrollEffectConfig m_config;  // 0x18
        private System.Int32 m_lastFocusIndex;  // 0x30
        private System.Single m_curTime;  // 0x34
        private System.Single m_lastScrollTime;  // 0x38
        private System.Boolean m_hasScrolled;  // 0x3c

        // Methods
        // RVA: 0x09AD4B08  token: 0x60005EA
        public System.Void .ctor(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig config) { }
        // RVA: 0x09AD49A8  token: 0x60005EB
        public System.Void NotifyScrolling(System.Single curIndex, System.Single deltaTime) { }
        // RVA: 0x09AD48F0  token: 0x60005EC
        public System.Void MarkHasScrolled() { }
        // RVA: 0x09AD4944  token: 0x60005ED
        public System.Void NotifyAlignFinish() { }
        // RVA: 0x09AD4A98  token: 0x60005EE
        public System.Void Reset(System.Int32 curIndex) { }

    }

    // TypeToken: 0x20000BF  // size: 0x28
    public sealed class <_KeyboardHeightChange>d__59 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIInputField <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600061C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600061D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AD4BD0  token: 0x600061E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AD4C28  token: 0x6000620
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C2
    public interface IAction
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600065F
        public virtual System.Void DoAction() { }

    }

    // TypeToken: 0x20000C3  // size: 0x28
    public sealed class <_NextFrameCoroutine>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UILayoutDimensionListener <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000660
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000661
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AD4C74  token: 0x6000662
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AD4CCC  token: 0x6000664
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C7  // size: 0x14
    public sealed struct GetCellSizeMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode ByGetCellSizeFunc;  // const
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode ByLayoutGroup;  // const
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode GetAfterCellCreated;  // const

    }

    // TypeToken: 0x20000D1  // size: 0x28
    public class Cell
    {
        // Fields
        public UnityEngine.GameObject gameObject;  // 0x10
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.GameObject realGameObject;  // 0x20

        // Methods
        // RVA: 0x09ADDA78  token: 0x6000719
        public System.Void SetSelect(System.Boolean select) { }
        // RVA: 0x0350B670  token: 0x600071A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5  // size: 0x14
    public sealed struct AutoLayoutWhenFewType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType Center;  // const
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType LeftOrTop;  // const
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType RightOrBottom;  // const

    }

    // TypeToken: 0x20000D6  // size: 0x40
    public class Cell
    {
        // Fields
        public UnityEngine.GameObject gameObject;  // 0x10
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x20
        public Beyond.UI.IUIFoldoutComp UIFoldoutComp;  // 0x28
        public System.Boolean canCache;  // 0x30
        public UnityEngine.GameObject realGameObject;  // 0x38

        // Methods
        // RVA: 0x03D56870  token: 0x60007A7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7  // size: 0x14
    public sealed struct MoveTipsType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollList.MoveTipsType None;  // const
        public static Beyond.UI.UIScrollList.MoveTipsType Higher;  // const
        public static Beyond.UI.UIScrollList.MoveTipsType Lower;  // const
        public static Beyond.UI.UIScrollList.MoveTipsType Both;  // const

    }

    // TypeToken: 0x20000D8  // size: 0x20
    public sealed struct Padding
    {
        // Fields
        public System.Single top;  // 0x10
        public System.Single left;  // 0x14
        public System.Single right;  // 0x18
        public System.Single bottom;  // 0x1c

    }

    // TypeToken: 0x20000D9  // size: 0x14
    public sealed struct ScrollAlignType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollList.ScrollAlignType Center;  // const
        public static Beyond.UI.UIScrollList.ScrollAlignType Top;  // const
        public static Beyond.UI.UIScrollList.ScrollAlignType Bottom;  // const

    }

    // TypeToken: 0x20000DA
    public interface IScrollListNaviWrapper
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007A8
        public virtual System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir) { }

    }

    // TypeToken: 0x20000DD  // size: 0x14
    public sealed struct MoveTipsType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollRect.MoveTipsType None;  // const
        public static Beyond.UI.UIScrollRect.MoveTipsType Higher;  // const
        public static Beyond.UI.UIScrollRect.MoveTipsType Lower;  // const
        public static Beyond.UI.UIScrollRect.MoveTipsType Both;  // const

    }

    // TypeToken: 0x20000DE  // size: 0x20
    public sealed class <>c__DisplayClass14_0
    {
        // Fields
        public UnityEngine.Vector2 contentPos;  // 0x10
        public Beyond.UI.UIScrollRect <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60007D2
        public System.Void .ctor() { }
        // RVA: 0x03D5CC00  token: 0x60007D3
        private UnityEngine.Vector2 <_CustomSetPosOnScroll>b__0() { }
        // RVA: 0x034E5020  token: 0x60007D4
        private System.Void <_CustomSetPosOnScroll>b__1(UnityEngine.Vector2 pos) { }

    }

    // TypeToken: 0x20000E0  // size: 0x14
    public sealed struct ERedDotState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState DISABLED;  // const
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState NEW;  // const
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState NORMAL;  // const

    }

    // TypeToken: 0x20000E1  // size: 0x14
    public sealed struct ERedDotDir
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir UP;  // const
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir RIGHT;  // const
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir DOWN;  // const
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir LEFT;  // const

    }

    // TypeToken: 0x20000E2  // size: 0x28
    public class RedDotInfo
    {
        // Fields
        public readonly UnityEngine.GameObject redDotRoot;  // 0x10
        public readonly UnityEngine.GameObject redDotNormal;  // 0x18
        public readonly UnityEngine.GameObject redDotNew;  // 0x20

        // Properties
        Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state { get; /* RVA: 0x09AE6334 */ }
        UnityEngine.Vector2 normalPos { get; /* RVA: 0x09AE615C */ }
        UnityEngine.Vector2 newPos { get; /* RVA: 0x09AE5F84 */ }
        UnityEngine.Rect normalRect { get; /* RVA: 0x09AE6238 */ }
        UnityEngine.Rect newRect { get; /* RVA: 0x09AE6060 */ }

        // Methods
        // RVA: 0x09AE5F4C  token: 0x60007F0
        public System.Void .ctor(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew) { }

    }

    // TypeToken: 0x20000E4  // size: 0x14
    public sealed struct ScrollMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollText.ScrollMode Mesh;  // const
        public static Beyond.UI.UIScrollText.ScrollMode AnchoredPosition;  // const

    }

    // TypeToken: 0x20000E5  // size: 0x14
    public sealed struct ScrollState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIScrollText.ScrollState Scrolling;  // const
        public static Beyond.UI.UIScrollText.ScrollState Idle;  // const
        public static Beyond.UI.UIScrollText.ScrollState FadingOut;  // const
        public static Beyond.UI.UIScrollText.ScrollState FadingIn;  // const

    }

    // TypeToken: 0x20000E6
    public interface IAlphaHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007FE
        public virtual System.Void HandleAlpha(System.Single alpha) { }

    }

    // TypeToken: 0x20000E7  // size: 0x18
    public class CanvasGroupHandler : IAlphaHandler
    {
        // Fields
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60007FF
        public System.Void .ctor(UnityEngine.CanvasGroup canvasGroup) { }
        // RVA: 0x09AE50D8  token: 0x6000800
        public virtual System.Void HandleAlpha(System.Single alpha) { }

    }

    // TypeToken: 0x20000E8
    public interface IScrollHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000801
        public virtual System.Void ApplyScroll(System.Single scrollOffset) { }
        // RVA: -1  // abstract  token: 0x6000802
        public virtual System.Void ResetScroll() { }
        // RVA: -1  // abstract  token: 0x6000803
        public virtual System.Void UpdateScrollStatus(System.Boolean isScroll) { }

    }

    // TypeToken: 0x20000E9  // size: 0x18
    public class PositionScrollHandler : IScrollHandler
    {
        // Fields
        private Beyond.UI.UIScrollText m_closure;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000804
        public System.Void .ctor(Beyond.UI.UIScrollText scrollText) { }
        // RVA: 0x09AE5D48  token: 0x6000805
        public virtual System.Void ApplyScroll(System.Single scrollOffset) { }
        // RVA: 0x09AE5DF4  token: 0x6000806
        public virtual System.Void ResetScroll() { }
        // RVA: 0x09AE5E68  token: 0x6000807
        public virtual System.Void UpdateScrollStatus(System.Boolean isScroll) { }

    }

    // TypeToken: 0x20000EA  // size: 0x18
    public class MeshScrollHandler : IScrollHandler
    {
        // Fields
        private Beyond.UI.UIScrollText m_closure;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000808
        public System.Void .ctor(Beyond.UI.UIScrollText uiScrollText) { }
        // RVA: 0x09AE5144  token: 0x6000809
        public virtual System.Void ApplyScroll(System.Single scrollOffset) { }
        // RVA: 0x09AE51A8  token: 0x600080A
        public virtual System.Void ResetScroll() { }
        // RVA: 0x09AE5200  token: 0x600080B
        public virtual System.Void UpdateScrollStatus(System.Boolean isScroll) { }
        // RVA: 0x09AE52BC  token: 0x600080C
        private System.Void _ApplyScroll(System.Single scrollOffset) { }
        // RVA: 0x09AE5538  token: 0x600080D
        private System.Void _UpdateMeshClipping(TMPro.TMP_TextInfo textInfo) { }

    }

    // TypeToken: 0x20000EC  // size: 0x30
    public sealed struct FocusBlockMessageData
    {
        // Fields
        public System.Int32 panelId;  // 0x10
        public System.Boolean isGroup;  // 0x14
        public System.Int32 id;  // 0x18
        public UnityEngine.RectTransform rectTransform;  // 0x20
        public System.Boolean noHighlight;  // 0x28
        public System.Boolean useNormalFrame;  // 0x29
        public System.Boolean useDarkFrame;  // 0x2a
        public System.Int32 panelSortingOrder;  // 0x2c

    }

    // TypeToken: 0x20000EE  // size: 0x38
    public sealed class <_ApplyDamping>d__44 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UISemiCircleScrollList <>4__this;  // 0x20
        private System.Single <targetOffset>5__2;  // 0x28
        private System.Single <elapsed>5__3;  // 0x2c
        private System.Single <initialOffset>5__4;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600084C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600084D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AE6474  token: 0x600084E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AE67A4  token: 0x6000850
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000F3  // size: 0x20
    public class StateInfo
    {
        // Fields
        public System.String name;  // 0x10
        public System.Collections.Generic.List<UnityEngine.GameObject> activeObjects;  // 0x18

        // Methods
        // RVA: 0x09AE6424  token: 0x6000873
        public virtual System.String ToString() { }
        // RVA: 0x028480E0  token: 0x6000874
        public System.Void .ctor() { }
        // RVA: 0x05459F38  token: 0x6000875
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20000F7  // size: 0x34
    public sealed struct SlicedSpriteParams
    {
        // Fields
        public System.Int32 slicedEnabled;  // 0x10
        public UnityEngine.Vector2 inner_PosMin;  // 0x14
        public UnityEngine.Vector2 inner_PosMax;  // 0x1c
        public UnityEngine.Vector2 inner_UVMin;  // 0x24
        public UnityEngine.Vector2 inner_UVMax;  // 0x2c

        // Methods
        // RVA: 0x03D76150  token: 0x60008BC
        public System.Void .ctor(System.Int32 slicedEnabled, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax) { }

    }

    // TypeToken: 0x20000F9  // size: 0x14
    public sealed struct UIType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UISoftMaskable.UIType Default;  // const
        public static Beyond.UI.UISoftMaskable.UIType Text;  // const
        public static Beyond.UI.UISoftMaskable.UIType UIVFX;  // const

    }

    // TypeToken: 0x20000FA  // size: 0x118
    public sealed struct TestLine
    {
        // Fields
        public UnityEngine.UIVertex v0;  // 0x10
        public UnityEngine.UIVertex v1;  // 0x7c
        public UnityEngine.Vector2 p0;  // 0xe8
        public UnityEngine.Vector2 p1;  // 0xf0
        public UnityEngine.Vector2 t0;  // 0xf8
        public UnityEngine.Vector2 t1;  // 0x100
        public UnityEngine.Vector2 dir;  // 0x108
        public UnityEngine.Vector2 normal;  // 0x110

    }

    // TypeToken: 0x20000FC  // size: 0x14
    public sealed struct RenderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UISortingOrder.RenderType Effect;  // const
        public static Beyond.UI.UISortingOrder.RenderType UI;  // const

    }

    // TypeToken: 0x20000FF  // size: 0x20
    public class StateConfig
    {
        // Fields
        public Beyond.UI.UIState.UIStateController stateController;  // 0x10
        public System.String stateName;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60008FA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000100  // size: 0x20
    public class StyleConfig
    {
        // Fields
        public Beyond.UI.UIStyleInputValidTypeMask inputValidType;  // 0x10
        public System.Collections.Generic.List<Beyond.UI.UIStyleByState.StateConfig> stateConfigs;  // 0x18

        // Methods
        // RVA: 0x03595760  token: 0x60008FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000109  // size: 0x28
    public class ScrollListLayoutInfo
    {
        // Fields
        public UnityEngine.UI.VerticalLayoutGroup layoutGroup;  // 0x10
        public UnityEngine.RectTransform layoutRectTransform;  // 0x18
        public UnityEngine.UI.LayoutElement cell;  // 0x20

        // Properties
        System.Single cellHeight { get; /* RVA: 0x09AF023C */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000992
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010A  // size: 0x68
    public sealed class <_ScrollLayouts>d__12 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl <>4__this;  // 0x20
        public System.Boolean isUp;  // 0x28
        public System.Int32 count;  // 0x2c
        private System.Single <elapsedTime>5__2;  // 0x30
        private System.Single <duration>5__3;  // 0x34
        private UnityEngine.Vector2 <upStartPos>5__4;  // 0x38
        private UnityEngine.Vector2 <downStartPos>5__5;  // 0x40
        private UnityEngine.Vector2 <middleStartPos>5__6;  // 0x48
        private UnityEngine.Vector2 <upEndPos>5__7;  // 0x50
        private UnityEngine.Vector2 <downEndPos>5__8;  // 0x58
        private UnityEngine.Vector2 <middleEndPos>5__9;  // 0x60

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000993
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000994
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AF3A0C  token: 0x6000995
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AF4140  token: 0x6000997
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000110  // size: 0x14
    public sealed struct MotionLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.MobileMotionManager.MotionLevel NONE;  // const
        public static Beyond.UI.MobileMotionManager.MotionLevel LOW;  // const
        public static Beyond.UI.MobileMotionManager.MotionLevel MEDIUM;  // const
        public static Beyond.UI.MobileMotionManager.MotionLevel HIGH;  // const

    }

    // TypeToken: 0x2000113  // size: 0x40
    public class FontAssetRef
    {
        // Fields
        public Beyond.I18n.I18nFontSearchData.FontAssetInfo fontAssetInfo;  // 0x10
        private System.Collections.Generic.HashSet<TMPro.TMP_Text> m_refTexts;  // 0x18
        private Beyond.Resource.FAssetProxyHandle m_assetHandle;  // 0x20
        private TMPro.TMP_FontAsset m_fontAsset;  // 0x38

        // Methods
        // RVA: 0x09AEF9D0  token: 0x60009BD
        public TMPro.TMP_FontAsset GetFontAsset(TMPro.TMP_Text refText) { }
        // RVA: 0x09AEFB68  token: 0x60009BE
        public System.Void RemoveRefText(TMPro.TMP_Text refText) { }
        // RVA: 0x09AEF920  token: 0x60009BF
        public System.Void Dispose() { }
        // RVA: 0x0370AB20  token: 0x60009C0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000115  // size: 0x40
    public sealed struct FLerpByTime
    {
        // Fields
        public static Beyond.UI.TweenUtils.FLerpByTime EMPTY;  // static @ 0x0
        private System.Boolean <isEmpty>k__BackingField;  // 0x10
        private Beyond.FScaledStopwatch m_timer;  // 0x18
        public System.Single startValue;  // 0x30
        public System.Single endValue;  // 0x34
        public System.Single duration;  // 0x38

        // Properties
        System.Boolean isEmpty { get; /* RVA: 0x03D51020 */ set; /* RVA: 0x03D4F9D0 */ }

        // Methods
        // RVA: 0x09AEF16C  token: 0x60009C4
        public System.Void Start(Beyond.ITickOwner timeScaleProvider) { }
        // RVA: 0x09AEF084  token: 0x60009C5
        public System.Single GetValue(System.Boolean& isTweenFinished) { }
        // RVA: 0x09AEF1D0  token: 0x60009C6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000119
    public sealed struct FOptions
    {
        // Fields
        public TComp cellTemplate;  // 0x0
        public UnityEngine.Transform parent;  // 0x0
        public System.Action<TComp> onItemCreated;  // 0x0

    }

    // TypeToken: 0x200011A
    public class ItemWrapper
    {
        // Fields
        public TComp comp;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60009D7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011C  // size: 0x20
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public Beyond.UI.UILoadImageSprite <>4__this;  // 0x10
        public System.String path;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60009DD
        public System.Void .ctor() { }
        // RVA: 0x09AF37F4  token: 0x60009DE
        private System.Void <_LoadSprite>b__0(System.Boolean isOk, Beyond.Resource.FAssetProxyHandle handle) { }

    }

    // TypeToken: 0x200011F  // size: 0x20
    public sealed struct Options
    {
        // Fields
        private System.Action <onShown>k__BackingField;  // 0x10
        private System.Action <onHiden>k__BackingField;  // 0x18

        // Properties
        System.Action onShown { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        System.Action onHiden { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }

    }

    // TypeToken: 0x2000120  // size: 0x14
    public sealed struct TweenContext
    {
        // Fields
        public System.Single lastStopPos;  // 0x10

        // Methods
        // RVA: 0x09AF3420  token: 0x60009FB
        public System.Boolean IsInterapted() { }
        // RVA: 0x02C3C3C0  token: 0x60009FC
        public System.Void OnReset() { }
        // RVA: 0x02C3C360  token: 0x60009FD
        public System.Void OnTweenStop(Beyond.UI.UISwitchTween.ITweenProgress tweenProgress) { }

    }

    // TypeToken: 0x2000121
    public interface ITweenHandler : Beyond.IHotfixable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60009FE
        public virtual Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }
        // RVA: -1  // abstract  token: 0x60009FF
        public virtual Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        // RVA: -1  // abstract  token: 0x6000A00
        public virtual System.Boolean IsPlaying() { }
        // RVA: -1  // abstract  token: 0x6000A01
        public virtual System.Void KillIfNecessary() { }

    }

    // TypeToken: 0x2000122
    public interface ITweenProgress : Beyond.IHotfixable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000A02
        public virtual System.Single GetCurrPos() { }

    }

    // TypeToken: 0x2000123  // size: 0x18
    public class TweenWrapper : ITweenHandler, Beyond.IHotfixable
    {
        // Fields
        private DG.Tweening.Tween m_tween;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000A03
        public System.Void .ctor(DG.Tweening.Tween tween) { }
        // RVA: 0x09AF3698  token: 0x6000A04
        public System.Boolean IsActive() { }
        // RVA: 0x02C3C7D0  token: 0x6000A05
        public virtual System.Boolean IsPlaying() { }
        // RVA: 0x02C3C450  token: 0x6000A06
        public virtual System.Void KillIfNecessary() { }
        // RVA: 0x02C3C0A0  token: 0x6000A07
        public virtual Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        // RVA: 0x02C3C170  token: 0x6000A08
        public virtual Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }

    }

    // TypeToken: 0x2000124  // size: 0x28
    public sealed class <WaitForTweening>d__19 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.UISwitchTween <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000A09
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000A0A
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09AF3970  token: 0x6000A0B
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09AF39C0  token: 0x6000A0D
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000126  // size: 0x20
    public sealed struct Durations
    {
        // Fields
        public System.Single show;  // 0x10
        public System.Single showDelay;  // 0x14
        public System.Single hide;  // 0x18
        public System.Single hideDelay;  // 0x1c

        // Methods
        // RVA: 0x036765D0  token: 0x6000A26
        public System.Single GetShowDuration(System.Single defaultDuration) { }
        // RVA: 0x03676610  token: 0x6000A27
        public System.Single GetHideDuration(System.Single defaultDuration) { }

    }

    // TypeToken: 0x2000127  // size: 0x30
    public sealed struct Builder
    {
        // Fields
        public UnityEngine.CanvasGroup alphaHandler;  // 0x10
        public System.Boolean useTimeScale;  // 0x18
        public System.Boolean dontDisableGameObject;  // 0x19
        public System.Boolean controlBlockRaycast;  // 0x1a
        public System.Single duration;  // 0x1c
        public Beyond.UI.FadeSwitchTween.Durations complexDuration;  // 0x20

        // Methods
        // RVA: 0x03653270  token: 0x6000A28
        public Beyond.UI.FadeSwitchTween Build() { }

    }

    // TypeToken: 0x2000129  // size: 0x20
    public class TweenHandler : ITweenHandler, Beyond.IHotfixable
    {
        // Fields
        private DG.Tweening.Tween m_alphaTweener;  // 0x10
        private DG.Tweening.Tween m_posTweener;  // 0x18

        // Methods
        // RVA: 0x02676770  token: 0x6000A34
        public System.Void .ctor(DG.Tweening.Tween alpha, DG.Tweening.Tween pos) { }
        // RVA: 0x09AF3484  token: 0x6000A35
        public virtual System.Boolean IsPlaying() { }
        // RVA: 0x09AF34EC  token: 0x6000A36
        public virtual System.Void KillIfNecessary() { }
        // RVA: 0x09AF3574  token: 0x6000A37
        public virtual Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09AF35FC  token: 0x6000A38
        public virtual Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }

    }

    // TypeToken: 0x200012B  // size: 0x14
    public sealed struct UIAtlasProcessStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus Invalid;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus InsertWaiting;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus InsertDone;  // const

    }

    // TypeToken: 0x200012C  // size: 0x14
    public sealed struct UIAtlasProcessFailureCause
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause NoFailure;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseImageHasNullMainTexture;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseImageHasNullSprite;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureWidthExceedLimit;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureHeightExceedLimit;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureASTCNotSupportedUnderEditor;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelInfo;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteHasNonQuadMesh;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteHasAssociatedAlphaSplitTexture;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelWarning;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseAtlasTextureHasNoSpaceLeft;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteRectHasNoPadding;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelError;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureFormatNotCompatible;  // const
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureSizeNotAlignedForCopyTexture;  // const

    }

    // TypeToken: 0x200012D  // size: 0x34
    public sealed struct UIAtlasHandle
    {
        // Fields
        public Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status;  // 0x10
        public Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause;  // 0x14
        public System.Int32 panelLevel;  // 0x18
        public System.Int32 atlasIndex;  // 0x1c
        public UnityEngine.RectInt atlasRect;  // 0x20
        public System.Int32 textureId;  // 0x30

        // Methods
        // RVA: 0x03D761B0  token: 0x6000A50
        public System.Void .ctor(Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause, System.Int32 panelLevel, System.Int32 atlasIndex, UnityEngine.RectInt atlasRect, System.Int32 textureId) { }
        // RVA: 0x09AF418C  token: 0x6000A51
        public System.Boolean IsValid() { }
        // RVA: 0x024347C0  token: 0x6000A52
        public static Beyond.UI.UIAtlasManager.UIAtlasHandle CreateInvalidHandle(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause cause) { }

    }

    // TypeToken: 0x200012F  // size: 0x24
    public sealed struct TextureRefHandle
    {
        // Fields
        public System.Int32 refCount;  // 0x10
        public UnityEngine.RectInt rect;  // 0x14

        // Methods
        // RVA: 0x03D675C0  token: 0x6000A5E
        public System.Void .ctor(System.Int32 refCount, UnityEngine.RectInt rect) { }

    }

    // TypeToken: 0x200012E  // size: 0x28
    public class UIAtlasPage
    {
        // Fields
        private readonly UnityEngine.Texture2D <pageTexture>k__BackingField;  // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle> <textureRefDict>k__BackingField;  // 0x18
        private readonly HG.Rendering.Runtime.AtlasMaxRect <rectBinPack>k__BackingField;  // 0x20

        // Properties
        System.Int32 maxFreeRectWidth { get; /* RVA: 0x09AF618C */ }
        System.Int32 maxFreeRectHeight { get; /* RVA: 0x0943FA1C */ }
        UnityEngine.Texture2D pageTexture { get; /* RVA: 0x020B7B20 */ }
        System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle> textureRefDict { get; /* RVA: 0x01041090 */ }
        HG.Rendering.Runtime.AtlasMaxRect rectBinPack { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x09AF5FFC  token: 0x6000A53
        public System.Void .ctor(System.Int32 panelDepth, System.Int32 index, UnityEngine.Experimental.Rendering.GraphicsFormat atlasFormat) { }
        // RVA: 0x09AF5ED0  token: 0x6000A59
        public UnityEngine.RectInt InsertRect(System.Int32 width, System.Int32 height) { }
        // RVA: 0x09AF5C4C  token: 0x6000A5A
        public System.Void CopyIntoAtlas(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.RectInt& rect) { }
        // RVA: 0x09AF5F74  token: 0x6000A5B
        public System.Void InsertRects(System.Collections.Generic.List<UnityEngine.RectInt> rects, System.Collections.Generic.List<UnityEngine.RectInt> dst) { }
        // RVA: 0x09AF5DF8  token: 0x6000A5C
        public System.Void FreeRect(UnityEngine.RectInt& rect) { }
        // RVA: 0x09AF5E64  token: 0x6000A5D
        public System.Void FreeRects(System.Collections.Generic.List<UnityEngine.RectInt>& rects) { }

    }

    // TypeToken: 0x2000133  // size: 0x20
    public sealed class <>c__DisplayClass0_0
    {
        // Fields
        public System.String url;  // 0x10
        public System.Action onClose;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000A6A
        public System.Void .ctor() { }
        // RVA: 0x09AF36FC  token: 0x6000A6B
        private System.Void <Start>b__0(System.Int32 i, System.String s) { }

    }

    // TypeToken: 0x2000144  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.UI.UIState.UIStateController.<>c <>9;  // static @ 0x0
        public static System.Predicate<Beyond.UI.UIState.StateAnimationInfo> <>9__10_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D19A90  token: 0x6000ABC
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000ABD
        public System.Void .ctor() { }
        // RVA: 0x09B0C928  token: 0x6000ABE
        private System.Boolean <Tick>b__10_0(Beyond.UI.UIState.StateAnimationInfo info) { }

    }

    // TypeToken: 0x2000156  // size: 0x10
    public static class ShaderIDs
    {
        // Fields
        private static readonly System.Int32 CANVAS_OBJECT_TO_WORLD_MATRIX;  // static @ 0x0
        private static readonly System.Int32 VAT_TEX;  // static @ 0x4
        private static readonly System.Int32 MAIN_TEX;  // static @ 0x8
        private static readonly System.Int32 SPRITE_TEX;  // static @ 0xc

        // Methods
        // RVA: 0x03C85500  token: 0x6000B06
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000159  // size: 0x24
    public sealed struct BufferInternalNode
    {
        // Fields
        public Beyond.UI.GPUI.GPUIHandle handle;  // 0x10
        public System.Int32 startIndex;  // 0x18
        public System.Int32 previousLength;  // 0x1c
        public System.Int32 sortingOrder;  // 0x20

    }

    // TypeToken: 0x200015F
    public sealed struct CharOffsetData
    {
        // Fields
        public System.Single scale;  // 0x0
        public System.Single xAdvance;  // 0x0
        public System.Single xOffset;  // 0x0
        public System.Single yOffset;  // 0x0
        public System.Int32 prefabIndex;  // 0x0

    }

    // TypeToken: 0x2000161  // size: 0x28
    public sealed struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x2000160  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE;  // static @ 0x0

    }

namespace Beyond.Gameplay.UI
{

    // TypeToken: 0x200000C  // size: 0xA8
    public class UIScrollCellCircleEffect : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Transform _target;  // 0x68
        private System.Single _radius;  // 0x70
        private UnityEngine.Transform _effectNode;  // 0x78
        private System.Boolean _faceToUICamera;  // 0x80
        private System.Boolean _alwaysFaceToCamera;  // 0x81
        private UnityEngine.Vector3 m_lastPosition;  // 0x84
        private Beyond.UI.LuaPanel m_panel;  // 0x90
        private UnityEngine.Transform <lookAtCamera>k__BackingField;  // 0x98
        private System.Boolean m_left;  // 0xa0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55740 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AB13F0 */ }
        UnityEngine.Transform lookAtCamera { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }

        // Methods
        // RVA: 0x09AB0F44  token: 0x600002D
        private System.Void _InitState() { }
        // RVA: 0x09AB1220  token: 0x600002E
        private System.Void _UpdatePos() { }
        // RVA: 0x09AB1008  token: 0x600002F
        private System.Void _UpdateLookAtCamera() { }
        // RVA: 0x09AB0DA4  token: 0x6000030
        public System.Void SetLookAtCamera(UnityEngine.Transform faceCamera, System.Boolean update) { }
        // RVA: 0x09AB0D4C  token: 0x6000031
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AB0E40  token: 0x6000032
        private System.Void Start() { }
        // RVA: 0x09AB0EE8  token: 0x6000033
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AB0CA0  token: 0x6000034
        public System.Void ForceUpdate() { }
        // RVA: 0x09AB0CF0  token: 0x6000035
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AB13E0  token: 0x6000036
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x6000037
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x6000038
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0589E548  token: 0x6000039
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200000D  // size: 0x88
    public class UIScrollCellSlantEffect : Beyond.TickableUIMono
    {
        // Fields
        private System.Single _topY;  // 0x68
        private System.Single _bottomY;  // 0x6c
        private System.Single _leftX;  // 0x70
        private System.Single _maxWidth;  // 0x74
        private UnityEngine.AnimationCurve _curve;  // 0x78
        private UnityEngine.Transform[] _cells;  // 0x80

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x032B98D0  token: 0x600003B
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x02846010  token: 0x600003C
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x600003D
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

}

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000005  // size: 0x10
    public static class ListPoolInitializer_UI_Beyond
    {
        // Fields
        private static System.Boolean s_initialized;  // static @ 0x0

        // Methods
        // RVA: 0x03C8B2A0  token: 0x6000017
        private static System.Void InitializeAtRuntime() { }
        // RVA: 0x03C8B2D0  token: 0x6000018
        private static System.Void Initialize() { }

    }

}

namespace Beyond.Scripts.UI.Tools
{

    // TypeToken: 0x200000B  // size: 0x20
    public class UIGridLayoutElement : UnityEngine.MonoBehaviour, UnityEngine.UI.ILayoutElement
    {
        // Fields
        private UnityEngine.UI.GridLayoutGroup m_gridLayoutGroup;  // 0x18

        // Properties
        System.Single minWidth { get; /* RVA: 0x09AB02C4 */ }
        System.Single preferredWidth { get; /* RVA: 0x09AB0424 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }
        System.Single minHeight { get; /* RVA: 0x09AB0214 */ }
        System.Single preferredHeight { get; /* RVA: 0x09AB0374 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x09AAFF78  token: 0x600001E
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x09AAFFB8  token: 0x600001F
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x09AAFFF8  token: 0x6000027
        private System.Single _GetPreferredSize(System.Boolean widthOrHeight) { }
        // RVA: 0x0426FE60  token: 0x6000028
        public System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000006  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000019
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x600001A
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600001B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600001C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600001D
        public System.Void .ctor() { }

    }

}

namespace Beyond.UI
{

    // TypeToken: 0x200000E  // size: 0xC80
    public class UIText : TMPro.TextMeshProUGUI, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, UnityEngine.ISerializationCallbackReceiver, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        // Fields
        public Beyond.UI.UIText.RichTextStyleSeq richTextStyleSeq;  // 0xbc8
        private System.Boolean m_textHasHyperlink;  // 0xbcc
        private static readonly System.Text.RegularExpressions.Regex RICH_TEXT_INNERMOST_REGEX;  // static @ 0x0
        private static System.Int32 RICH_TEXT_RESOLVE_MAX_ITERATIONS;  // const
        private static readonly System.Text.RegularExpressions.Regex HYPERLINK_TEXT_REGEX;  // static @ 0x8
        private static readonly System.Text.RegularExpressions.Regex PHONETIC_REGEX;  // static @ 0x10
        private System.Boolean _loadByCode;  // 0xbcd
        private System.String _textId;  // 0xbd0
        private System.Boolean _devOnly;  // 0xbd8
        private System.Int32 _externalStaticWidth;  // 0xbdc
        private System.Int32 _externalStaticHeight;  // 0xbe0
        private System.Boolean m_firstSetByCode;  // 0xbe4
        private static readonly System.Collections.Generic.HashSet<Beyond.GEnums.EnvLang> s_forceLeftAlignLanguage;  // static @ 0x18
        private System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo> m_richTextInfos;  // 0xbe8
        private Beyond.TickFunction m_updateFunction;  // 0xbf0
        private Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc m_processRichTextEntryFunc;  // 0xbf8
        public UnityEngine.Events.UnityEvent<System.String> onClickLink;  // 0xc00
        public UnityEngine.Events.UnityEvent<System.String,System.Boolean> onHoverLinkChange;  // 0xc08
        private System.Boolean m_isPointerInside;  // 0xc10
        private System.String m_curHoverLinkId;  // 0xc18
        private System.Collections.Generic.List<System.String> m_linkList;  // 0xc20
        private System.Boolean m_linkShrunk;  // 0xc28
        private System.String _hyperlinkUITextGroupId;  // 0xc30
        private System.Int32 _hyperlinkUITextOrder;  // 0xc38
        private Beyond.UI.UIText.HyperlinkUITextWrap m_hyperlinkUITextWrap;  // 0xc40
        private Beyond.UI.LuaPanel m_panel;  // 0xc48
        public System.Int32 sourceCNFontId;  // 0xc50
        private TMPro.TMP_FontAsset m_i18nFontAsset;  // 0xc58
        private static System.Text.StringBuilder s_stringBuilder;  // static @ 0x20
        private readonly System.Collections.Generic.Queue<UnityEngine.GameObject> m_inlineImagePool;  // 0xc60
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.ImageGOInfo> m_indexToImageGo;  // 0xc68
        private static System.String INLINE_IMAGE_FOLDER_PATH;  // const
        private static System.String KEY_HINT_ICON_COMMON_FOLDER;  // const
        private readonly System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> m_imageCache;  // 0xc70
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_delayedActiveChangeImageGOIndexes;  // 0xc78

        // Properties
        System.String textId { get; /* RVA: 0x03D75FC0 */ }
        System.String text { get; /* RVA: 0x031E6FF0 */ set; /* RVA: 0x030CAAC0 */ }
        Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processRichTextEntryFunc { get; /* RVA: 0x025E0100 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AB4130 */ }
        TMPro.TMP_FontAsset m_fontAsset { get; /* RVA: 0x0285FD90 */ set; /* RVA: 0x09AB42A8 */ }
        UnityEngine.Material fontSharedMaterial { get; /* RVA: 0x03D56F00 */ set; /* RVA: 0x09AB41F0 */ }

        // Methods
        // RVA: 0x030823B0  token: 0x600003E
        public System.Void SetAndResolveTextStyle(System.String targetText) { }
        // RVA: 0x02CDF860  token: 0x600003F
        public static System.String GetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        // RVA: 0x02CDF7D0  token: 0x6000040
        public System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        // RVA: 0x030824B0  token: 0x6000041
        private static System.String _ResolveTextStyle(System.String text, System.Int32 richSeqIndex, System.Boolean& hasLink) { }
        // RVA: 0x02954240  token: 0x6000043
        public static System.Void OnEnvLangChanged(Beyond.GEnums.EnvLang lang) { }
        // RVA: 0x0348A3B0  token: 0x6000046
        private System.Void _CreateUpdateFunction() { }
        // RVA: 0x0239E610  token: 0x6000047
        private System.Void _ReleaseUpdateFunction() { }
        // RVA: 0x03535D10  token: 0x6000048
        public virtual System.Void ClearMesh() { }
        // RVA: 0x025DF9D0  token: 0x6000049
        public virtual System.Void RefreshPopulateText() { }
        // RVA: 0x09AB185C  token: 0x600004A
        protected virtual UnityEngine.Material LoadMaterial(System.String materialName) { }
        // RVA: 0x0285F5C0  token: 0x600004B
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0285FB00  token: 0x600004C
        protected virtual System.Void Awake() { }
        // RVA: 0x0285FF80  token: 0x600004D
        protected TMPro.TMP_FontAsset GetFontAsset() { }
        // RVA: 0x0285FC60  token: 0x600004E
        private System.Void _GenerateRuntimeText() { }
        // RVA: 0x025DFB30  token: 0x600004F
        private System.Void _ProcessRichTextInfo() { }
        // RVA: 0x03191780  token: 0x6000050
        private System.Void _OnPreRenderText(TMPro.TMP_TextInfo textInfo) { }
        // RVA: 0x09AB355C  token: 0x6000052
        private Beyond.UI.UIText.RichTextInfo _ProcessRichTextEntry(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        // RVA: 0x09AB1B4C  token: 0x6000053
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AB1FE4  token: 0x6000054
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AB20D0  token: 0x6000055
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x033B7E00  token: 0x6000056
        protected virtual System.Void Start() { }
        // RVA: 0x0239EE90  token: 0x6000057
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0239E670  token: 0x6000058
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AB3D90  token: 0x6000059
        private System.Void _UpdateTick(System.Single deltaTime) { }
        // RVA: 0x09AB2520  token: 0x600005A
        public System.Void ShrinkLinkTags() { }
        // RVA: 0x09AB2BD8  token: 0x600005B
        public System.Boolean TryGetLinkId(UnityEngine.Vector3 position, System.String& linkId) { }
        // RVA: 0x09AB2D98  token: 0x600005C
        public System.Boolean TryGetLinkId(System.Int32 linkIndex, System.String& linkId) { }
        // RVA: 0x09AB2EF4  token: 0x600005D
        public System.Boolean TryGetOriginalLinkId(System.String linkId, System.String& originalLinkId) { }
        // RVA: 0x09AB2A38  token: 0x600005E
        public System.Boolean TryGetCharacterStartPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight) { }
        // RVA: 0x09AB2898  token: 0x600005F
        public System.Boolean TryGetCharacterEndPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight) { }
        // RVA: -1  // generic def  token: 0x6000060
        public System.Void CombineStringWithLanguageSpilt(T1 t1, T2 t2) { }
        // RVA: 0x09AB14B0  token: 0x6000061
        public System.Void CombineStringWithLanguageSpilt(System.String t1, System.String t2) { }
        // RVA: -1  // generic def  token: 0x6000062
        public System.Void CombineStringReverseForIndonesianAndVietnamese(T1 t1, T2 t2) { }
        // RVA: 0x0228C6F0  token: 0x6000063
        public System.Void CombineStringReverseForIndonesianAndVietnamese(System.String t1, System.String t2) { }
        // RVA: 0x09AB2210  token: 0x6000064
        public System.Void SetHyperlinkUITextGroup(System.String groupId, System.Int32 order) { }
        // RVA: 0x03A4E1F0  token: 0x6000065
        public static System.Boolean IsHyperlinkUITextGroupDisplayable(System.String groupId) { }
        // RVA: 0x09AB155C  token: 0x6000066
        public static System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableHyperlinkUIText(System.String groupId) { }
        // RVA: 0x0285F9F0  token: 0x6000068
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AB305C  token: 0x6000069
        public System.Void UpdateI18NFontAsset() { }
        // RVA: 0x02860B20  token: 0x600006E
        private System.Void _RefreshMatTexture() { }
        // RVA: 0x09AB236C  token: 0x600006F
        protected virtual System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        // RVA: 0x03172370  token: 0x6000070
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x03242FD0  token: 0x6000071
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x025158D0  token: 0x6000072
        protected virtual TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference) { }
        // RVA: 0x09AB1968  token: 0x6000073
        public static System.String LocalStringCombineFormat(System.Int32 count) { }
        // RVA: 0x09AB15E4  token: 0x6000074
        protected UnityEngine.Sprite GetOrLoadSprite(System.String path) { }
        // RVA: 0x0285F610  token: 0x6000075
        protected System.Void DisposeInlineImageCache() { }
        // RVA: 0x025DFE30  token: 0x6000076
        private System.Void _ClearInlineImage() { }
        // RVA: 0x09AB317C  token: 0x6000077
        private Beyond.UI.UIText.ImageGOInfo _GetImageGoByIndex(System.Int32 index) { }
        // RVA: 0x09AB3354  token: 0x6000078
        private UnityEngine.GameObject _GetOrCreateImageGO() { }
        // RVA: 0x09AB3CD4  token: 0x6000079
        private System.Void _ReturnImageGO(UnityEngine.GameObject go) { }
        // RVA: 0x09AB30F0  token: 0x600007A
        private System.Collections.IEnumerator _DelayedChangeActiveImageGo() { }
        // RVA: 0x02845350  token: 0x600007B
        public System.Void .ctor() { }
        // RVA: 0x03496650  token: 0x600007C
        private static System.Void .cctor() { }
        // RVA: 0x09AB3054  token: 0x600007D
        public System.Void <>iFixBaseProxy_set_text(System.String P0) { }
        // RVA: 0x09AB301C  token: 0x600007E
        public System.Void <>iFixBaseProxy_ClearMesh() { }
        // RVA: 0x09AB303C  token: 0x600007F
        public System.Void <>iFixBaseProxy_RefreshPopulateText() { }
        // RVA: 0x01002730  token: 0x6000080
        public UnityEngine.Material <>iFixBaseProxy_LoadMaterial(System.String P0) { }
        // RVA: 0x09AB3024  token: 0x6000081
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09AB3014  token: 0x6000082
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x6000083
        public System.Void <>iFixBaseProxy_Start() { }
        // RVA: 0x09AB3034  token: 0x6000084
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09AB302C  token: 0x6000085
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x03D56CF0  token: 0x6000086
        public TMPro.TMP_FontAsset <>iFixBaseProxy_get_m_fontAsset() { }
        // RVA: 0x04275CF4  token: 0x6000087
        public System.Void <>iFixBaseProxy_set_m_fontAsset(TMPro.TMP_FontAsset P0) { }
        // RVA: 0x09AB304C  token: 0x6000088
        public System.Void <>iFixBaseProxy_set_fontSharedMaterial(UnityEngine.Material P0) { }
        // RVA: 0x09AB3044  token: 0x6000089
        public System.Void <>iFixBaseProxy_SetSharedMaterial(UnityEngine.Material P0) { }
        // RVA: 0x09AB2FD4  token: 0x600008A
        public TMPro.TMP_SubMeshUI <>iFixBaseProxy_AddSubTextObject(TMPro.TextMeshProUGUI P0, TMPro.MaterialReference P1) { }

    }

    // TypeToken: 0x200001F  // size: 0x10
    public static class UIConst
    {
        // Fields
        public static System.Boolean IS_PC_OR_CONSOLE;  // static @ 0x0
        public static System.Single PC_REFERENCE_RESOLUTION_SCALE;  // const
        public static System.Single MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE;  // const
        public static readonly UnityEngine.Vector3 OUT_OF_SCREEN_POS;  // static @ 0x4
        public static System.Single STANDARD_HORIZONTAL_RESOLUTION;  // const
        public static System.Single STANDARD_VERTICAL_RESOLUTION;  // const
        public static System.Int32 INVALID_FINGER_ID;  // const
        public static System.Single STANDARD_RATIO;  // static @ 0x10
        public static System.Single SCREEN_SPACE_CAMERA_PANEL_DISTANCE;  // const
        public static System.String UI_BLUR_MATERIAL;  // const
        public static System.String CS_POPUP_PANEL_PATH;  // const
        public static System.String NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID;  // const
        public static System.String NAVIGATION_TARGET_CLICK_ACTION_ID;  // const
        public static System.String UI_SPRITE_CHAR_HEAD_RECTANGLE;  // const
        public static System.String UI_SPRITE_DIALOG_OPTION_ICON;  // const
        public static System.String SLIDER_STICK_SCROLL_HORI_ACTION_ID;  // const

        // Properties
        System.Int32 STANDARD_HORIZONTAL_RESOLUTION_INT { get; /* RVA: 0x09AAFF08 */ }
        System.Int32 STANDARD_VERTICAL_RESOLUTION_INT { get; /* RVA: 0x09AAFF18 */ }
        System.Single CUR_STANDARD_HORIZONTAL_RESOLUTION { get; /* RVA: 0x028AADA0 */ }
        System.Single CUR_STANDARD_VERTICAL_RESOLUTION { get; /* RVA: 0x028AAD50 */ }
        System.Int32 dragThreshold { get; /* RVA: 0x09AAFF28 */ }

        // Methods
        // RVA: 0x02800340  token: 0x60000BE
        public static System.Single GetResolutionScale() { }
        // RVA: 0x09AAFDC4  token: 0x60000BF
        public static System.Boolean IsPadDevice() { }
        // RVA: 0x03A38140  token: 0x60000C0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x30
    public class UIModelLoader : System.IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.Resource.FAssetProxyHandle> m_instance2AssetHandle;  // 0x10
        private System.Int32 m_requestCounter;  // 0x18
        private System.Collections.Generic.HashSet<System.Int32> m_requestIds;  // 0x20
        private System.Boolean m_disposed;  // 0x28
        private static System.Collections.Generic.List<MagicaCloth.MagicaBoneCloth> s_magicaBoneCloths;  // static @ 0x0

        // Methods
        // RVA: 0x02F2F1B0  token: 0x60000C1
        public System.Void .ctor() { }
        // RVA: 0x09AB094C  token: 0x60000C2
        public UnityEngine.GameObject LoadModel(System.String modelPath, UnityEngine.Transform parent) { }
        // RVA: 0x09AB0768  token: 0x60000C3
        public System.Int32 LoadModelAsync(System.String modelPath, UnityEngine.Transform parent, System.Action<UnityEngine.GameObject> callback) { }
        // RVA: 0x09AB06E4  token: 0x60000C4
        public System.Void Cancel(System.Int32 requestId) { }
        // RVA: 0x09AB0B2C  token: 0x60000C5
        public System.Void UnloadModel(UnityEngine.GameObject modelGo) { }
        // RVA: 0x03219C50  token: 0x60000C6
        private System.Void _Clear() { }
        // RVA: 0x03219C10  token: 0x60000C7
        public virtual System.Void Dispose() { }
        // RVA: 0x03CE2BC0  token: 0x60000C8
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x10
    public static class UIUtils
    {
        // Fields
        private static System.Int32 MAX_SHARED_INT_STRING;  // const
        private static readonly System.String[] s_sharedIntStringPool;  // static @ 0x0
        private static UnityEngine.Vector3[] s_worldCorners;  // static @ 0x8

        // Methods
        // RVA: 0x02B79EA0  token: 0x60000CB
        public static System.String GetSharedIntString(System.Int32 value) { }
        // RVA: 0x0284E8F0  token: 0x60000CC
        public static System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector3 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        // RVA: 0x02F63750  token: 0x60000CD
        public static System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector2 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        // RVA: 0x09AB4454  token: 0x60000CE
        public static UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local) { }
        // RVA: 0x09AB4BD0  token: 0x60000CF
        public static System.Boolean TryGetTouch(System.Int32 touchId, UnityEngine.InputSystem.EnhancedTouch.Touch& touch) { }
        // RVA: 0x025C1550  token: 0x60000D0
        public static System.Void SetAlpha(UnityEngine.UI.Graphic image, System.Single alpha) { }
        // RVA: 0x09AB4A64  token: 0x60000D1
        public static System.Void SetColorWithoutAlpha(UnityEngine.UI.Graphic image, UnityEngine.Color color) { }
        // RVA: 0x02C71370  token: 0x60000D2
        public static System.Void ClearUIComponents(UnityEngine.GameObject gameObject) { }
        // RVA: 0x027FEEC0  token: 0x60000D3
        public static UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        // RVA: 0x03989560  token: 0x60000D4
        public static UnityEngine.Vector3 GetNodeScaleOffset(UnityEngine.RectTransform referenceTransform, UnityEngine.RectTransform selfTransform) { }
        // RVA: 0x09AB47A0  token: 0x60000D5
        public static UnityEngine.Color GetColorByString(System.String strColor) { }
        // RVA: 0x09AB4AFC  token: 0x60000D6
        public static System.Void SetMaskRatio(UnityEngine.UI.RectMask2D mask, System.Single r) { }
        // RVA: 0x09AB49BC  token: 0x60000D7
        public static System.Single GetCursorTipOffsetX(System.Single defaultOffset) { }
        // RVA: 0x027FF690  token: 0x60000D8
        public static System.Single GetCursorTipOffsetInScreen(System.Single defaultOffsetInScreen) { }
        // RVA: 0x03CB67A0  token: 0x60000D9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x28
    public class ActiveSyncHelper : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _objs;  // 0x18
        private System.Boolean _isInverse;  // 0x20

        // Methods
        // RVA: 0x03633CA0  token: 0x60000DA
        private System.Void Awake() { }
        // RVA: 0x03633D20  token: 0x60000DB
        private System.Void OnEnable() { }
        // RVA: 0x03633CE0  token: 0x60000DC
        private System.Void OnDisable() { }
        // RVA: 0x03633D60  token: 0x60000DD
        public System.Void Sync() { }
        // RVA: 0x0426FE60  token: 0x60000DE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x70
    public class Billboard : Beyond.TickableUIMono
    {
        // Fields
        public UnityEngine.Camera sceneCamera;  // 0x68

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AACA3C  token: 0x60000E0
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AACAE8  token: 0x60000E1
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x02846010  token: 0x60000E2
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x60000E3
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x60000E4
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000027  // size: 0x30
    public class CinemachineGyroscopeEffect : Cinemachine.CinemachineExtension
    {
        // Fields
        public System.Single offsetX;  // 0x28
        public System.Single offsetY;  // 0x2c

        // Methods
        // RVA: 0x09AACBC8  token: 0x60000E5
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0426FE60  token: 0x60000E6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x278
    public class CommonItemToastList : Beyond.UI.UIScrollList
    {
        // Methods
        // RVA: 0x09AAD098  token: 0x60000E7
        public System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode) { }
        // RVA: 0x09AACEDC  token: 0x60000E8
        protected System.Void AdjustContainerPos(System.Int32 index, System.Boolean fastMode) { }
        // RVA: 0x09AAD1B4  token: 0x60000E9
        private UnityEngine.Vector2 _GetUnConstraintTargetPos(System.Int32 index) { }
        // RVA: 0x03D00A30  token: 0x60000EA
        public System.Void .ctor() { }
        // RVA: 0x09AAD160  token: 0x60000EB
        private UnityEngine.Vector2 <AdjustContainerPos>b__1_0() { }
        // RVA: 0x09AAD184  token: 0x60000EC
        private System.Void <AdjustContainerPos>b__1_1(UnityEngine.Vector2 x) { }

    }

    // TypeToken: 0x2000029  // size: 0x40
    public class ControllerSideMenuItemList : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.ControllerSideMenuItemList.MeunItemInfo> menuItems;  // 0x18
        public UnityEngine.Sprite icon;  // 0x20
        public System.String title;  // 0x28
        public UnityEngine.RectTransform contentPosTrans;  // 0x30
        public System.Boolean isFullScreen;  // 0x38
        private static readonly System.Collections.Generic.HashSet<System.String> s_forceValidItemList;  // static @ 0x0

        // Methods
        // RVA: 0x09AAD3D8  token: 0x60000ED
        public static System.Void ToggleItemForceValid(System.String itemName, System.Boolean forceValid) { }
        // RVA: 0x09AAD334  token: 0x60000EE
        public static System.Boolean IsItemForceValid(System.String itemName) { }
        // RVA: 0x09AAD2A0  token: 0x60000EF
        public static System.Void ClearForceValidItemList() { }
        // RVA: 0x03B319A0  token: 0x60000F0
        public System.Void .ctor() { }
        // RVA: 0x03CE4D80  token: 0x60000F1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x20
    public sealed class CustomNotchAdapt : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean isLeft;  // 0x18
        public System.Boolean isRight;  // 0x19
        public System.Boolean isBottom;  // 0x1a
        public System.Boolean isFullHorizontalStretch;  // 0x1b

        // Methods
        // RVA: 0x0426FE60  token: 0x60000F9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x14
    public sealed struct UIStyleInputValidType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIStyleInputValidType All;  // const
        public static Beyond.UI.UIStyleInputValidType Keyboard;  // const
        public static Beyond.UI.UIStyleInputValidType Touch;  // const
        public static Beyond.UI.UIStyleInputValidType Controller;  // const
        public static Beyond.UI.UIStyleInputValidType KeyboardAndTouch;  // const
        public static Beyond.UI.UIStyleInputValidType KeyboardAndController;  // const
        public static Beyond.UI.UIStyleInputValidType TouchAndController;  // const

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct UIStyleInputValidTypeMask
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIStyleInputValidTypeMask Keyboard;  // const
        public static Beyond.UI.UIStyleInputValidTypeMask Touch;  // const
        public static Beyond.UI.UIStyleInputValidTypeMask Controller;  // const
        public static Beyond.UI.UIStyleInputValidTypeMask All;  // const

    }

    // TypeToken: 0x200002E  // size: 0x14
    public sealed struct ActiveType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.ActiveType UseGameObjectActive;  // const
        public static Beyond.UI.ActiveType UseScale;  // const

    }

    // TypeToken: 0x200002F  // size: 0x38
    public class CustomUIStyle : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIStyleInputValidType inputValidType;  // 0x18
        public Beyond.UI.ActiveType activeType;  // 0x1c
        private UnityEngine.UI.LayoutElement _layoutElement;  // 0x20
        private UnityEngine.Animator _animator;  // 0x28
        private Beyond.UI.CustomUIStyle.OverrideValidState m_overrideValidState;  // 0x30

        // Properties
        Beyond.UI.UIStyleInputValidTypeMask inputValidTypeMask { get; /* RVA: 0x09AAD5F8 */ set; /* RVA: 0x09AAD6AC */ }
        Beyond.UI.CustomUIStyle.OverrideValidState overrideValidState { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x09AAD760 */ }
        System.Boolean isValid { get; /* RVA: 0x03271250 */ }

        // Methods
        // RVA: 0x09AAD4F4  token: 0x60000FE
        private System.Void _OnActiveTypeChanged() { }
        // RVA: 0x02CD0EE0  token: 0x6000100
        private System.Void OnDestroy() { }
        // RVA: 0x03271180  token: 0x6000101
        private System.Void OnEnable() { }
        // RVA: 0x02CD2060  token: 0x6000102
        private System.Void Awake() { }
        // RVA: 0x032711C0  token: 0x6000103
        public System.Void CheckState() { }
        // RVA: 0x03271360  token: 0x6000104
        public System.Void ToggleActiveState(System.Boolean isActive) { }
        // RVA: 0x03271290  token: 0x6000105
        public static System.Boolean IsShowTypeValid(Beyond.UI.UIStyleInputValidType inputValidType) { }
        // RVA: 0x02CD2C80  token: 0x6000106
        public static System.Boolean IsValidInput(Beyond.UI.UIStyleInputValidTypeMask inputValidTypeMask) { }
        // RVA: 0x0426FE60  token: 0x6000107
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public class DeactivateNaviOnEnable : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String key;  // 0x18

        // Methods
        // RVA: 0x09AAD7FC  token: 0x6000108
        private System.Void OnEnable() { }
        // RVA: 0x09AAD76C  token: 0x6000109
        private System.Void OnDisable() { }
        // RVA: 0x0426FE60  token: 0x600010A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x80
    public class DecoLineActiveHelper : Beyond.TickableUIMono
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GameObject> checkTargets;  // 0x68
        public System.Collections.Generic.List<UnityEngine.GameObject> secondCheckTargets;  // 0x70
        private UnityEngine.UI.LayoutElement _layoutElement;  // 0x78

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09AAD88C  token: 0x600010C
        private System.Void Reset() { }
        // RVA: 0x0380EC70  token: 0x600010D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x022BF720  token: 0x600010E
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AAD904  token: 0x600010F
        public System.Void Sync() { }
        // RVA: 0x09AAD938  token: 0x6000110
        private System.Boolean _HasActiveTarget(System.Collections.Generic.List<UnityEngine.GameObject> targets) { }
        // RVA: 0x09AADA04  token: 0x6000111
        private System.Void _ToggleVisible(System.Boolean isVisible) { }
        // RVA: 0x02846010  token: 0x6000112
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x6000113
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x6000114
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000033  // size: 0xE8
    public class Empty4Raycast : UnityEngine.UI.MaskableGraphic
    {
        // Methods
        // RVA: 0x09AADB3C  token: 0x6000115
        protected System.Void .ctor() { }
        // RVA: 0x09AADAD0  token: 0x6000116
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x09AADB34  token: 0x6000117
        public System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }

    }

    // TypeToken: 0x2000034  // size: 0x38
    public class FitAspectRatioByFOV : UnityEngine.MonoBehaviour, IScreenSizeListener
    {
        // Fields
        public System.Single referenceAspect;  // 0x18
        private System.Single m_referenceVerticalFOV;  // 0x1c
        private Cinemachine.CinemachineVirtualCamera m_virtualCamera;  // 0x20
        private System.Single m_currentAspect;  // 0x28
        private System.Single _maxFov;  // 0x2c
        private System.Single m_overrideMaxFov;  // 0x30

        // Properties
        System.Single maxFov { get; /* RVA: 0x09AADBF4 */ set; /* RVA: 0x09AADC54 */ }

        // Methods
        // RVA: 0x09AADB5C  token: 0x600011A
        private System.Void Start() { }
        // RVA: 0x02CD14D0  token: 0x600011B
        private System.Void OnEnable() { }
        // RVA: 0x02CD1540  token: 0x600011C
        private System.Void OnDisable() { }
        // RVA: 0x02CD1480  token: 0x600011D
        public virtual System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height) { }
        // RVA: 0x02CD1320  token: 0x600011E
        private System.Void _AdjustFOV() { }
        // RVA: 0x03D07BC0  token: 0x600011F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x78
    public class FixRotation : Beyond.TickableUIMono
    {
        // Fields
        public UnityEngine.Vector3 rotation;  // 0x68

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x03414F90  token: 0x6000121
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x03CB5C50  token: 0x6000122
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x6000123
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000036  // size: 0x20
    public class FullScreenSceneBlurMarker : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Int32 s_nextId;  // static @ 0x0
        public static System.Action<System.Int32,Beyond.UI.FullScreenSceneBlurMarker.State,System.Boolean,System.Boolean> s_onFullScreenSceneBlurMarkerStateChanged;  // static @ 0x8
        private System.Int32 <id>k__BackingField;  // 0x18
        public System.Boolean useWhiteBlur;  // 0x1c
        public System.Boolean useSceneColorPS;  // 0x1d

        // Properties
        System.Int32 id { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x03B13460  token: 0x6000124
        private static System.Int32 _GetNextId() { }
        // RVA: 0x03B13400  token: 0x6000127
        private System.Void Awake() { }
        // RVA: 0x038A4F30  token: 0x6000128
        private System.Void OnEnable() { }
        // RVA: 0x038A4E90  token: 0x6000129
        private System.Void OnDisable() { }
        // RVA: 0x038A4DF0  token: 0x600012A
        private System.Void OnDestroy() { }
        // RVA: 0x03CFE7E0  token: 0x600012B
        public System.Void .ctor() { }
        // RVA: 0x03D44720  token: 0x600012C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000038  // size: 0x190
    public class InputBindingGroupNaviDecorator : UnityEngine.UI.Selectable, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.Input.InputBindingGroupMonoTarget m_inputBindingGroup;  // 0x180
        public UnityEngine.Events.UnityEvent<System.Boolean> onGroupSetAsNaviTarget;  // 0x188

        // Methods
        // RVA: 0x0384BAC0  token: 0x600012D
        private System.Void _SetSelfEnabledStateIfNecessary() { }
        // RVA: 0x02A72990  token: 0x600012E
        protected virtual System.Void Awake() { }
        // RVA: 0x0384BA40  token: 0x600012F
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03B137E0  token: 0x6000130
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09AAE8F4  token: 0x6000131
        protected virtual System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        // RVA: 0x03B13820  token: 0x6000132
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02849830  token: 0x6000133
        public System.Void .ctor() { }
        // RVA: 0x09AAE8DC  token: 0x6000134
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AAE8EC  token: 0x6000135
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09AAE8E4  token: 0x6000136
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x0350B670  token: 0x6000137
        public System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x2000039
    public interface IUIClearable : Beyond.ILuaCallCSharp
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000138
        public virtual System.Void ClearComponent() { }

    }

    // TypeToken: 0x200003A  // size: 0xB8
    public class LuaPanel : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public static System.Collections.Generic.Dictionary<System.String,Beyond.UI.LuaPanel> s_openedLuaPanels;  // static @ 0x0
        private System.Boolean _isPCOnlyPanel;  // 0x18
        private System.Boolean _isControllerPanel;  // 0x19
        public System.Boolean inited;  // 0x1a
        private System.Boolean _isWorldUI;  // 0x1b
        private UnityEngine.Vector3 _uiRot;  // 0x1c
        private System.Boolean _blockWhileAnim;  // 0x28
        private System.Int32 <panelLevel>k__BackingField;  // 0x2c
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x30
        private Beyond.Audio.AudioUIUtil.UIAudioType _uiAudioType;  // 0x38
        private UnityEngine.RectTransform <rectTransform>k__BackingField;  // 0x40
        private UnityEngine.Canvas <canvas>k__BackingField;  // 0x48
        public System.Collections.Generic.HashSet<Beyond.UI.UISortingOrder> sortingOrderComps;  // 0x50
        private UnityEngine.Camera <uiCamera>k__BackingField;  // 0x58
        private System.Single <planeDistance>k__BackingField;  // 0x60
        private System.Int32 <panelId>k__BackingField;  // 0x64
        private System.String <panelName>k__BackingField;  // 0x68
        private System.Boolean m_showRot;  // 0x70
        private Beyond.Input.InputBindingGroupMonoTarget m_inputBindingGroupMonoTarget;  // 0x78
        private UnityEngine.UI.GraphicRaycaster[] m_graphicRaycasters;  // 0x80
        private System.Boolean m_started;  // 0x88
        private UnityEngine.Coroutine m_animationInCoroutine;  // 0x90
        private System.Boolean m_waitAutoAnimInFinished;  // 0x98
        public Beyond.DisposedUnityEvent onAnimationInFinished;  // 0xa0
        private System.Boolean m_animationInFinished;  // 0xa8
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_animationInWaitTargets;  // 0xb0

        // Properties
        System.Boolean blockWhileAnim { get; /* RVA: 0x03D4ED50 */ }
        System.Int32 panelLevel { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        UnityEngine.Canvas canvas { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        UnityEngine.Camera uiCamera { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        System.Single planeDistance { get; /* RVA: 0x03D50D50 */ set; /* RVA: 0x03D50D80 */ }
        System.Int32 panelId { get; /* RVA: 0x03D50B30 */ set; /* RVA: 0x03D50B40 */ }
        System.String panelName { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        System.Boolean IsWorldUI { get; /* RVA: 0x03D52270 */ set; /* RVA: 0x03D522A0 */ }
        System.Boolean isPCOnlyPanel { get; /* RVA: 0x01002A50 */ }
        System.Boolean isControllerPanel { get; /* RVA: 0x03D4EF80 */ }
        System.Boolean animationInFinished { get; /* RVA: 0x011B9C10 */ }

        // Methods
        // RVA: 0x02A72C50  token: 0x600014C
        private System.Void Awake() { }
        // RVA: 0x02A72D50  token: 0x600014D
        private System.Void _TrySetRot() { }
        // RVA: 0x02A73240  token: 0x600014E
        public System.Void AddSortingOrderComp(Beyond.UI.UISortingOrder comp) { }
        // RVA: 0x03A41290  token: 0x600014F
        public System.Void RemoveSortingOrderComp(Beyond.UI.UISortingOrder comp) { }
        // RVA: 0x036CDB20  token: 0x6000150
        private System.Void Start() { }
        // RVA: 0x02EA2AF0  token: 0x6000151
        private System.Void OnEnable() { }
        // RVA: 0x02EA28C0  token: 0x6000152
        private System.Void OnDisable() { }
        // RVA: 0x03858BE0  token: 0x6000153
        private System.Void OnDestroy() { }
        // RVA: 0x02EA2BD0  token: 0x6000154
        private System.Collections.IEnumerator _AutoAnimationInFinish() { }
        // RVA: 0x025CB810  token: 0x6000156
        public System.Boolean InformAnimationInStart(UnityEngine.GameObject target) { }
        // RVA: 0x028725D0  token: 0x6000157
        public System.Void InformAnimationInEnd(UnityEngine.GameObject target, System.Boolean forceEnd) { }
        // RVA: 0x02872670  token: 0x6000158
        private System.Void _TryCallAnimationInFinished(System.Boolean forceFinished) { }
        // RVA: 0x02BA02F0  token: 0x6000159
        public System.Void BlockAllInput() { }
        // RVA: 0x02BA03E0  token: 0x600015A
        public System.Void RecoverAllInput() { }
        // RVA: 0x03858C20  token: 0x600015B
        public virtual System.Void ClearComponent() { }
        // RVA: 0x028484F0  token: 0x600015C
        public System.Void .ctor() { }
        // RVA: 0x03CE3A60  token: 0x600015D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x80
    public class MouseHoverTipsPosHelper : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.RectOffset _padding;  // 0x68
        private Beyond.UI.LuaPanel m_panel;  // 0x70
        private UnityEngine.RectTransform m_rectTransform;  // 0x78

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x027FF5E0 */ }

        // Methods
        // RVA: 0x03B2E880  token: 0x6000166
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03B26EF0  token: 0x6000167
        protected virtual System.Void OnEnable() { }
        // RVA: 0x037E9A20  token: 0x6000168
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x027FF1B0  token: 0x6000169
        public System.Void UpdatePosition() { }
        // RVA: 0x02846010  token: 0x600016A
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x600016B
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x600016C
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x600016D
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200003D  // size: 0x20
    public class NaviToThisGroupOnEnable : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UISelectableNaviGroup target;  // 0x18

        // Methods
        // RVA: 0x09AAF170  token: 0x600016E
        private System.Void Reset() { }
        // RVA: 0x09AAF024  token: 0x600016F
        private System.Void Awake() { }
        // RVA: 0x09AAF0D4  token: 0x6000170
        private System.Void OnEnable() { }
        // RVA: 0x0426FE60  token: 0x6000171
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0xB8
    public class NonDrawingGraphic : UnityEngine.UI.Graphic, UnityEngine.ICanvasRaycastFilter
    {
        // Fields
        public Beyond.UI.NonDrawingGraphic.ShapeType shapeType;  // 0xb0

        // Properties
        System.Single Radius { get; /* RVA: 0x02516C10 */ }

        // Methods
        // RVA: 0x03577A50  token: 0x6000173
        public virtual System.Void SetMaterialDirty() { }
        // RVA: 0x034D64F0  token: 0x6000174
        public virtual System.Void SetVerticesDirty() { }
        // RVA: 0x09AAF1F0  token: 0x6000175
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x025174B0  token: 0x6000176
        public virtual System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x02516B00  token: 0x6000177
        private System.Boolean _IsRaycastLocationValidCircle(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        // RVA: 0x02700690  token: 0x6000178
        public System.Void .ctor() { }
        // RVA: 0x09AAF254  token: 0x6000179
        public System.Void <>iFixBaseProxy_SetMaterialDirty() { }
        // RVA: 0x09AAF25C  token: 0x600017A
        public System.Void <>iFixBaseProxy_SetVerticesDirty() { }
        // RVA: 0x09AADB34  token: 0x600017B
        public System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }

    }

    // TypeToken: 0x2000040  // size: 0x58
    public sealed class NotchAdapter : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector2 selfMarginSize;  // 0x18
        public System.Collections.Generic.List<UnityEngine.RectTransform> leftSideUIList;  // 0x20
        public System.Collections.Generic.List<UnityEngine.RectTransform> rightSideUIList;  // 0x28
        public System.Collections.Generic.List<UnityEngine.RectTransform> bottomSideUIList;  // 0x30
        public System.Collections.Generic.List<UnityEngine.RectTransform> fullHorizontalStretchUIList;  // 0x38
        public System.Boolean alwaysFindSideUI;  // 0x40
        private UnityEngine.UI.CanvasScaler m_canvasScaler;  // 0x48
        private Beyond.UI.UICanvasScaleHelper m_notchHost;  // 0x50

        // Methods
        // RVA: 0x027FCE40  token: 0x600017C
        private System.Void Awake() { }
        // RVA: 0x0381BA00  token: 0x600017D
        private System.Void OnDestroy() { }
        // RVA: 0x027FCD00  token: 0x600017E
        public System.Void FindAllSideUI(System.Boolean needClear) { }
        // RVA: 0x09AAF264  token: 0x600017F
        public System.Void ApplyNotch() { }
        // RVA: 0x027FE830  token: 0x6000180
        public System.Void ApplyNotch(UnityEngine.Vector2 curMarginSize) { }
        // RVA: 0x027FCC60  token: 0x6000181
        public System.Void ClearList() { }
        // RVA: 0x027FEE20  token: 0x6000182
        public System.Void ClearNullRef() { }
        // RVA: 0x09AAF2CC  token: 0x6000183
        public System.Void UnApplyNotch() { }
        // RVA: 0x027FCDC0  token: 0x6000184
        public System.Void ApplyNewNotch() { }
        // RVA: 0x027FCEF0  token: 0x6000185
        private System.Void _UpdateMargeSizeFromNotchInfo(System.Boolean forceUpdate) { }
        // RVA: 0x027FCD80  token: 0x6000186
        private System.Void _OnCanvasChanged() { }
        // RVA: -1  // generic def  token: 0x6000187
        private System.Void _RemoveNullRef(System.Collections.Generic.List<T> list) { }
        // RVA: 0x027FC420  token: 0x6000188
        private System.Void _TraverseUI(UnityEngine.RectTransform root) { }
        // RVA: 0x027FC7D0  token: 0x6000189
        private System.Void _TryAddToSideUI(UnityEngine.RectTransform rect, Beyond.UI.CustomNotchAdapt custom) { }
        // RVA: 0x028494C0  token: 0x600018A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x28
    public class ParallaxHelper : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.ParallaxHelper.ParallaxConfig> _configs;  // 0x18
        private System.Single _maxOffset;  // 0x20
        private System.Single m_curValue;  // 0x24

        // Properties
        System.Single curValue { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x09AC06E8 */ }

        // Methods
        // RVA: 0x09AC0330  token: 0x6000190
        public System.Void InitConfigs() { }
        // RVA: 0x09AC0690  token: 0x6000191
        public System.Void ResetValue() { }
        // RVA: 0x09AC04B8  token: 0x6000192
        public System.Void RefreshPos() { }
        // RVA: 0x0426FE60  token: 0x6000193
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x88
    public class PercentNumberTweener : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIText _text;  // 0x68
        private System.String _format;  // 0x70
        private Beyond.UI.UIImage _progressImg;  // 0x78
        private System.Int32 m_cacheValue;  // 0x80

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09AC086C  token: 0x6000196
        private System.Void Reset() { }
        // RVA: 0x09AC080C  token: 0x6000197
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AC06F4  token: 0x6000198
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AC08EC  token: 0x6000199
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x600019A
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x600019B
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000045  // size: 0x18
    public abstract class UIRecycleLayoutAdapter
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup.IViewHandler <viewHandler>k__BackingField;  // 0x10

        // Properties
        Beyond.UI.UIRecycleLayoutGroup.IViewHandler viewHandler { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x09AC6794  token: 0x600019C
        public System.Void Init(Beyond.UI.UIRecycleLayoutGroup.IViewHandler handler) { }
        // RVA: 0x09AC6748  token: 0x600019F
        public virtual System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        // RVA: -1  // abstract  token: 0x60001A0
        public virtual System.Void OnInit() { }
        // RVA: 0x0350B670  token: 0x60001A1
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public abstract class UIRecycleLayoutSimpleHolder`1 : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollRect _scrollRect;  // 0x0
        protected System.Single _scrollDuration;  // 0x0
        protected DG.Tweening.Ease _scrollEase;  // 0x0
        protected System.Boolean _enableLoopWrappedNavigation;  // 0x0
        private System.Boolean m_isInited;  // 0x0
        protected Beyond.UI.UIRecycleLayoutSimpleHolder.SimpleAdapter<TVirtualView> m_simpleAdapter;  // 0x0
        protected Beyond.UI.UIRecycleLayoutGroup m_layoutGroup;  // 0x0
        public Beyond.DisposedUnityEvent doOnceAfterLayout;  // 0x0
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;  // 0x0
        protected DG.Tweening.Tween m_scrollTween;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001B4
        private System.Void _InitIfNot() { }
        // RVA: -1  // not resolved  token: 0x60001B5
        protected virtual System.Void OnAwake() { }
        // RVA: -1  // not resolved  token: 0x60001B6
        private System.Void _AfterLayout() { }
        // RVA: -1  // not resolved  token: 0x60001B7
        private System.Void _WrapNavigation(UnityEngine.UI.NaviDirection dir) { }
        // RVA: -1  // abstract  token: 0x60001B8
        public virtual System.Void OnAdapterInit() { }
        // RVA: -1  // not resolved  token: 0x60001B9
        public System.Void ScrollTo(System.Int32 index, System.Boolean fastMode) { }
        // RVA: -1  // not resolved  token: 0x60001BA
        protected System.Void ClearScrollTweenIfNeeded() { }
        // RVA: -1  // not resolved  token: 0x60001BB
        protected virtual System.Void ScrollToInternal(System.Single normalizedPosition, System.Boolean fastMode) { }
        // RVA: -1  // not resolved  token: 0x60001BC
        public UnityEngine.GameObject GetView(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001BD
        public System.Void NotifyAllSizeChanged() { }
        // RVA: -1  // not resolved  token: 0x60001BE
        public System.Void NotifySizeChanged(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001BF
        public System.Void NotifySizeChanged(TVirtualView virtualView) { }
        // RVA: -1  // not resolved  token: 0x60001C0
        public System.Void RemoveView(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001C1
        public System.Void RemoveAllViews() { }
        // RVA: -1  // not resolved  token: 0x60001C2
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0xC8
    public class UIRecycleLayoutGroup : Beyond.TickableUIMono, UnityEngine.UI.ILayoutElement, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup.Direction _direction;  // 0x68
        private UnityEngine.RectTransform _viewport;  // 0x70
        private UnityEngine.RectTransform _content;  // 0x78
        private System.Single _notCachedBufferSize;  // 0x80
        private System.Int32 _layoutPriority;  // 0x84
        private Beyond.UI.UIRecycleLayoutGroup.Padding _padding;  // 0x88
        private System.Single _spacing;  // 0x98
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIRecycleLayoutGroup.LayoutMeta> m_layoutMetaMap;  // 0xa0
        private Beyond.UI.UIRecycleLayoutAdapter m_adapter;  // 0xa8
        private Beyond.UI.UIRecycleLayoutGroup.ViewMgr m_viewMgr;  // 0xb0
        private System.Single <sizeOnAxis>k__BackingField;  // 0xb8
        public Beyond.DisposedUnityEvent onLayoutUpdated;  // 0xc0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        Beyond.UI.UIRecycleLayoutAdapter adapter { get; /* RVA: 0x09AC7F3C */ }
        Beyond.UI.UIRecycleLayoutGroup.ViewMgr viewMgr { get; /* RVA: 0x09AC80D8 */ }
        System.Single sizeOnAxis { get; /* RVA: 0x03D599C0 */ set; /* RVA: 0x03D50850 */ }
        System.Single spacing { get; /* RVA: 0x03D57D90 */ }
        Beyond.UI.UIRecycleLayoutGroup.Padding padding { get; /* RVA: 0x03D5C7E0 */ }
        System.Single minWidth { get; /* RVA: 0x03D503F0 */ }
        System.Single minHeight { get; /* RVA: 0x03D503F0 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D503F0 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D503F0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x03D4F370 */ }
        System.Single preferredWidth { get; /* RVA: 0x09AC80C4 */ }
        System.Single preferredHeight { get; /* RVA: 0x09AC80B0 */ }
        System.Single paddingFront { get; /* RVA: 0x09AC8044 */ }
        System.Single paddingBack { get; /* RVA: 0x09AC7FD8 */ }
        UnityEngine.RectTransform content { get; /* RVA: 0x03D4EB20 */ }

        // Methods
        // RVA: 0x09AC6804  token: 0x60001E1
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x09AC6848  token: 0x60001E2
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x09AC6D64  token: 0x60001E7
        private System.Void _ApplyLayoutMeta(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta) { }
        // RVA: 0x09AC7580  token: 0x60001E8
        private UnityEngine.Vector2 _GetVisibleRange(UnityEngine.Bounds viewBound) { }
        // RVA: 0x09AC7224  token: 0x60001E9
        private UnityEngine.Bounds _GetElementBoundsFromMeta(Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta) { }
        // RVA: 0x09AC6CB4  token: 0x60001EA
        public Beyond.UI.UIRecycleLayoutAdapter SetAdapter(Beyond.UI.UIRecycleLayoutAdapter adapter) { }
        // RVA: 0x09AC688C  token: 0x60001EB
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AC691C  token: 0x60001EC
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AC697C  token: 0x60001ED
        protected System.Void OnLateTick() { }
        // RVA: 0x09AC7818  token: 0x60001EE
        private System.Void _RebuildAllViews() { }
        // RVA: 0x09AC7B90  token: 0x60001EF
        private System.Void _UpdateViews(System.Int32 fromIndex) { }
        // RVA: 0x09AC7690  token: 0x60001F0
        private System.Boolean _InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC7928  token: 0x60001F1
        private System.Boolean _RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC7ACC  token: 0x60001F2
        private System.Void _UpdateViewsFrom(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC74B0  token: 0x60001F3
        private System.Single _GetElementPosByIndex(System.Int32 index) { }
        // RVA: 0x09AC70F0  token: 0x60001F4
        private UnityEngine.Bounds _GetElementBoundsByIndex(System.Int32 index) { }
        // RVA: 0x09AC73FC  token: 0x60001F5
        private System.Int32 _GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        // RVA: 0x09AC78D0  token: 0x60001F7
        private System.Void _RefreshLayout() { }
        // RVA: 0x09AC7E70  token: 0x60001F8
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x60001F9
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000056  // size: 0xD8
    public class UIRecycleMultiHolder : Beyond.UI.UIRecycleLayoutSimpleHolder`1, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UIRecycleMultiHolder.Config> _configs;  // 0xa8
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;  // 0xb0
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onDetachCell;  // 0xb8
        public System.Func<System.Int32,System.Single> getCellDefaultSize;  // 0xc0
        public System.Func<System.Int32,System.String> getCellPrefabKey;  // 0xc8
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> m_prefabMap;  // 0xd0

        // Methods
        // RVA: 0x09AC8368  token: 0x6000227
        public Beyond.UI.UIRecycleMultiHolder.MultiVirtualView GetVirtualView(System.Int32 index) { }
        // RVA: 0x09AC8818  token: 0x6000228
        public System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        // RVA: 0x09AC8898  token: 0x6000229
        public System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex) { }
        // RVA: 0x09AC83F4  token: 0x600022A
        public System.Void InsertView(System.Int32 index, System.String key, System.Single initSize) { }
        // RVA: 0x09AC8188  token: 0x600022B
        public System.Void AddView(System.String key, System.Single initSize) { }
        // RVA: 0x09AC84E8  token: 0x600022C
        public virtual System.Void OnAdapterInit() { }
        // RVA: 0x09AC8268  token: 0x600022D
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AC8A7C  token: 0x600022E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000059  // size: 0xD0
    public class UIRecycleSingleHolder : Beyond.UI.UIRecycleLayoutSimpleHolder`1, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Int32 m_count;  // 0xa8
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;  // 0xb0
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onDetachCell;  // 0xb8
        public System.Func<System.Int32,System.Single> getCellDefaultSize;  // 0xc0
        private UnityEngine.GameObject _cellTemplate;  // 0xc8

        // Methods
        // RVA: 0x09AC8DA4  token: 0x6000236
        public Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView GetVirtualView(System.Int32 index) { }
        // RVA: 0x09AC8F74  token: 0x6000237
        public System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        // RVA: 0x09AC8FF4  token: 0x6000238
        public System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex) { }
        // RVA: 0x09AC8E30  token: 0x6000239
        public System.Void InsertView(System.Int32 index, System.String key, System.Single initSize) { }
        // RVA: 0x09AC8BEC  token: 0x600023A
        public System.Void AddView(System.String key, System.Single initSize) { }
        // RVA: 0x09AC8F14  token: 0x600023B
        public virtual System.Void OnAdapterInit() { }
        // RVA: 0x09AC8CBC  token: 0x600023C
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AC9188  token: 0x600023D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0xC90
    public class SimpleUITextSingleLine : Beyond.UI.UIText
    {
        // Fields
        private static Unity.Profiling.ProfilerMarker s_GenerateTextMarker;  // static @ 0x0
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIMarker;  // static @ 0x8
        private static Unity.Profiling.ProfilerMarker s_CharacterLookupMarker;  // static @ 0x10
        private static Unity.Profiling.ProfilerMarker s_HandleGPOSFeaturesMarker;  // static @ 0x18
        private static Unity.Profiling.ProfilerMarker s_CalculateVerticesPositionMarker;  // static @ 0x20
        private static Unity.Profiling.ProfilerMarker s_ComputeTextMetricsMarker;  // static @ 0x28
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker;  // static @ 0x30
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_1;  // static @ 0x38
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_2;  // static @ 0x40
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_3;  // static @ 0x48
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_4;  // static @ 0x50
        private static Unity.Profiling.ProfilerMarker s_HandleWhiteSpacesMarker;  // static @ 0x58
        private static Unity.Profiling.ProfilerMarker s_HandleHorizontalLineBreakingMarker;  // static @ 0x60
        private static Unity.Profiling.ProfilerMarker s_HandleVerticalLineBreakingMarker;  // static @ 0x68
        private static Unity.Profiling.ProfilerMarker s_SaveGlyphVertexDataMarker;  // static @ 0x70
        private static Unity.Profiling.ProfilerMarker s_ComputeCharacterAdvanceMarker;  // static @ 0x78
        private static Unity.Profiling.ProfilerMarker s_HandleCarriageReturnMarker;  // static @ 0x80
        private static Unity.Profiling.ProfilerMarker s_HandleLineTerminationMarker;  // static @ 0x88
        private static Unity.Profiling.ProfilerMarker s_SavePageInfoMarker;  // static @ 0x90
        private static Unity.Profiling.ProfilerMarker s_SaveProcessingStatesMarker;  // static @ 0x98
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIIMarker;  // static @ 0xa0
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIIIMarker;  // static @ 0xa8
        public System.Boolean m_b;  // 0xc80
        private System.Action<TMPro.TMP_TextInfo> OnPreRenderText;  // 0xc88

        // Events
        event System.Action<TMPro.TMP_TextInfo> OnPreRenderText;

        // Methods
        // RVA: 0x09AB4DEC  token: 0x6000244
        protected virtual System.Void GenerateTextMesh() { }
        // RVA: 0x09AC0E34  token: 0x6000247
        public System.Void .ctor() { }
        // RVA: 0x09AC0944  token: 0x6000248
        private static System.Void .cctor() { }
        // RVA: 0x09AC093C  token: 0x6000249
        public System.Void <>iFixBaseProxy_GenerateTextMesh() { }

    }

    // TypeToken: 0x200005C  // size: 0x60
    public class ToastList : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.GameObject _cellTemplate;  // 0x18
        private System.Single _showDuration;  // 0x20
        private System.Single _delay;  // 0x24
        private System.Int32 _maxShowingCount;  // 0x28
        private System.Boolean <inAnimation>k__BackingField;  // 0x2c
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;  // 0x30
        public Beyond.DisposedUnityEvent onAllToastFinished;  // 0x38
        private System.Int32 m_totalCount;  // 0x40
        private System.Int32 m_maxFinishedIndex;  // 0x44
        private System.Int32 m_maxShowingIndex;  // 0x48
        private System.Int32 m_waitingCount;  // 0x4c
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.ToastList.CellInfo> m_showingCells;  // 0x50
        private System.Collections.Generic.List<Beyond.UI.ToastList.CellInfo> m_cachedCells;  // 0x58

        // Properties
        System.Boolean inAnimation { get; /* RVA: 0x03D4F1A0 */ set; /* RVA: 0x03D4F1B0 */ }

        // Methods
        // RVA: 0x09AC13EC  token: 0x600024C
        private System.Void Awake() { }
        // RVA: 0x09AC1684  token: 0x600024D
        private System.Void OnDisable() { }
        // RVA: 0x09AC17A0  token: 0x600024E
        private Beyond.UI.ToastList.CellInfo _GetCell() { }
        // RVA: 0x09AC16D4  token: 0x600024F
        private System.Void _CacheCell(Beyond.UI.ToastList.CellInfo cell) { }
        // RVA: 0x09AC1298  token: 0x6000250
        public System.Void AddToast(System.Int32 count, System.Int32 startIndex) { }
        // RVA: 0x09AC1B88  token: 0x6000251
        private System.Void _StartBatch(System.Int32 batchCount) { }
        // RVA: 0x09AC1ACC  token: 0x6000252
        private System.Collections.IEnumerator _ShowCell(System.Int32 delayIndex, Beyond.UI.ToastList.CellInfo cell) { }
        // RVA: 0x09AC1C90  token: 0x6000253
        private System.Void _TryShowNewCell() { }
        // RVA: 0x09AC1914  token: 0x6000254
        private System.Void _OnCellFinished(Beyond.UI.ToastList.CellInfo cell) { }
        // RVA: 0x09AC144C  token: 0x6000255
        public System.Void ClearAllToast() { }
        // RVA: 0x09AC1614  token: 0x6000256
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AC1E8C  token: 0x6000257
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x278
    public class UI3DScrollList : Beyond.UI.UIScrollList
    {
        // Methods
        // RVA: 0x09AC2644  token: 0x600025F
        protected virtual System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        // RVA: 0x09AC2704  token: 0x6000260
        public System.Void .ctor() { }
        // RVA: 0x09AC26FC  token: 0x6000261
        public System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }

    }

    // TypeToken: 0x2000060  // size: 0xB8
    public class UIActionKeyHint : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private static readonly UnityEngine.Color NORMAL_COLOR;  // static @ 0x0
        private static readonly UnityEngine.Color HIDE_COLOR;  // static @ 0x10
        private static readonly UnityEngine.Color DISABLED_COLOR;  // static @ 0x20
        private static System.Collections.Generic.List<Beyond.UI.UIActionKeyHint> s_keyHintCache;  // static @ 0x30
        private static System.Boolean s_inited;  // static @ 0x38
        public static System.Boolean s_stopCheckBindingEnabledForGuide;  // static @ 0x39
        private static System.String INVALID_KEY_STR;  // const
        private Beyond.Input.IBindingView m_target;  // 0x18
        public System.String actionId;  // 0x20
        public UnityEngine.Component btnTarget;  // 0x28
        public Beyond.Input.BindingViewActionType bindingViewActionType;  // 0x30
        private System.Boolean _useCustomText;  // 0x34
        private System.Boolean _showSecondAction;  // 0x35
        private System.Boolean _onlyShowOnLongPress;  // 0x36
        private System.Boolean _adaptForceGrayState;  // 0x37
        private UnityEngine.Transform _content;  // 0x38
        private UnityEngine.CanvasGroup _contentCanvasGroup;  // 0x40
        private Beyond.UI.UIImage _icon;  // 0x48
        private Beyond.UI.UIImage _longPressIcon;  // 0x50
        private UnityEngine.RectTransform _pressHintNode;  // 0x58
        private Beyond.UI.UIImage _pressHintProgressImg;  // 0x60
        private Beyond.UI.UIText _text;  // 0x68
        private Beyond.UI.UIImage _secondIcon;  // 0x70
        private UnityEngine.RectTransform _secondNode;  // 0x78
        private Beyond.UI.UIImage _modifyIcon;  // 0x80
        private UnityEngine.GameObject _mutexGameObject;  // 0x88
        private System.Boolean _changeScaleOnHide;  // 0x90
        public System.Int32 bindingId;  // 0x94
        public System.Func<System.Boolean> checkVirtualMouseClickHintFunc;  // 0x98
        private UnityEngine.CanvasGroup _canvasGroup;  // 0xa0
        public System.Boolean autoUpdate;  // 0xa8
        private System.Boolean <hintHidden>k__BackingField;  // 0xa9
        private System.Int32 m_cachedBindingId;  // 0xac
        private System.Boolean m_isLongPressAction;  // 0xb0
        private System.Single m_lastPressStartTime;  // 0xb4
        private static System.Single LONG_PRESS_HINT_HIDE_TIME;  // const
        private static System.Single LONG_PRESS_HINT_SHOW_MIN_VALUE;  // const

        // Properties
        Beyond.Input.IBindingView target { get; /* RVA: 0x0251A320 */ }
        System.Boolean showCanvasGroup { get; /* RVA: 0x09AC3160 */ }
        System.Boolean hintHidden { get; /* RVA: 0x03D5AB90 */ set; /* RVA: 0x03D5ABB0 */ }

        // Methods
        // RVA: 0x0270CB90  token: 0x6000262
        private static System.Void _TryInit() { }
        // RVA: 0x09AC2E68  token: 0x6000263
        private static System.Void _RefreshAllKeyHints() { }
        // RVA: 0x02517BA0  token: 0x6000264
        private static System.Void _OnInputLateTickAll() { }
        // RVA: 0x09AC2D48  token: 0x6000265
        private static System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) { }
        // RVA: 0x0270CA20  token: 0x600026A
        private System.Void Awake() { }
        // RVA: 0x02C72990  token: 0x600026B
        private System.Void OnEnable() { }
        // RVA: 0x02C726C0  token: 0x600026C
        private System.Void OnDisable() { }
        // RVA: 0x03988E50  token: 0x600026D
        private System.Void OnDestroy() { }
        // RVA: 0x09AC2750  token: 0x600026E
        private System.Void Reset() { }
        // RVA: 0x09AC2E40  token: 0x600026F
        private System.Void _OnInputLateTick() { }
        // RVA: 0x02C72B10  token: 0x6000270
        public System.Void UpdateKeyHint() { }
        // RVA: 0x02BDE5C0  token: 0x6000271
        public System.Void SetActionId(System.String id, System.Boolean forceUpdate) { }
        // RVA: 0x02BDE620  token: 0x6000272
        public System.Void SetKeyHint(System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate) { }
        // RVA: 0x02BDE6C0  token: 0x6000273
        public System.Void SetBindingId(System.Int32 bId, System.Boolean forceUpdate) { }
        // RVA: 0x09AC2868  token: 0x6000274
        public System.Void SetBindingId(System.Int32 bId, System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate) { }
        // RVA: 0x02BDE780  token: 0x6000275
        private System.Void _OnChangeTarget() { }
        // RVA: 0x09AC2DC4  token: 0x6000276
        private System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& data) { }
        // RVA: 0x02C72F80  token: 0x6000277
        public System.Void SetSecondActionId(System.String id, System.Boolean isPrimary) { }
        // RVA: 0x02C73040  token: 0x6000278
        private System.Void _SetSecondIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean isPrimary) { }
        // RVA: 0x02519A10  token: 0x6000279
        private System.Void _CheckInteractable(System.Boolean isInit) { }
        // RVA: 0x029E3020  token: 0x600027A
        private System.Boolean _IsInputEnabled() { }
        // RVA: 0x09AC2AF8  token: 0x600027B
        private System.Boolean _IsInputGray() { }
        // RVA: 0x02BDF930  token: 0x600027C
        public System.String GetTextStr() { }
        // RVA: 0x09AC292C  token: 0x600027D
        public System.Void SetText(System.String text) { }
        // RVA: 0x02C731B0  token: 0x600027E
        public System.Boolean GetAndSetActionIcon(Beyond.UI.UIImage iconImage, Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean& isLongPressAction, System.Boolean isPrimary) { }
        // RVA: 0x02C728B0  token: 0x600027F
        public System.Boolean GetAndSetActionModifyIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean isPrimary) { }
        // RVA: 0x02C73610  token: 0x6000280
        private System.Boolean _SetKeyCodeSprite(Beyond.UI.UIImage iconImage, System.String iconPath) { }
        // RVA: 0x09AC2998  token: 0x6000281
        private System.Void _CheckVirtualMouseClickHint() { }
        // RVA: 0x09AC2F74  token: 0x6000282
        private System.Void _UpdatePressHint() { }
        // RVA: 0x09AC2A48  token: 0x6000283
        private System.Void _GetLongPressInfo(System.Single& startTime, System.Single& longPressTime) { }
        // RVA: 0x029E2C00  token: 0x6000284
        public System.String GetActionId() { }
        // RVA: 0x02C72EE0  token: 0x6000285
        public Beyond.Input.PlayerActionInfo GetActionInfo() { }
        // RVA: 0x02C72570  token: 0x6000286
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02C72E50  token: 0x6000287
        public System.Void SetContentState(System.Boolean contentState) { }
        // RVA: 0x03539A60  token: 0x6000288
        public System.Void .ctor() { }
        // RVA: 0x03B5DE90  token: 0x6000289
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000061  // size: 0x20
    public class UIAnimationHolder : UnityEngine.MonoBehaviour, UnityEngine.IAnimationClipSource
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UIAnimationHolder.ClipHolder> _clips;  // 0x18

        // Methods
        // RVA: 0x09AC321C  token: 0x600028A
        public UnityEngine.AnimationClip FindByName(System.String name) { }
        // RVA: 0x09AC31B4  token: 0x600028B
        public UnityEngine.AnimationClip FindByNameOrAlias(System.String nameOrAlias) { }
        // RVA: 0x09AC32D8  token: 0x600028C
        private UnityEngine.AnimationClip _FindByString(System.String id, System.Boolean useAlias) { }
        // RVA: 0x09AC3284  token: 0x600028D
        public virtual System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results) { }
        // RVA: 0x03C8AFC0  token: 0x600028E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x28
    public class UIAnimationLoopSynchronizer : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String syncLoopAnimKey;  // 0x18
        private readonly System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper> m_children;  // 0x20

        // Methods
        // RVA: 0x03726CB0  token: 0x6000290
        public System.Void RegisterChild(Beyond.UI.UIAnimationWrapper child) { }
        // RVA: 0x09AC34EC  token: 0x6000291
        public System.Void UnregisterChild(Beyond.UI.UIAnimationWrapper child) { }
        // RVA: 0x032886A0  token: 0x6000292
        public System.Single GetLoopStartPosition() { }
        // RVA: 0x03C8AF40  token: 0x6000293
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0xC0
    public class UIAnimationWrapper : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.AnimationClip _animationIn;  // 0x18
        private UnityEngine.AnimationClip _animationInEasing;  // 0x20
        private UnityEngine.AnimationClip _animationLoop;  // 0x28
        private UnityEngine.AnimationClip _animationOut;  // 0x30
        public System.Boolean autoPlay;  // 0x38
        private System.Boolean _onlyOnce;  // 0x39
        private System.Boolean _needSyncLoopAnim;  // 0x3a
        private System.String _syncLoopAnimKey;  // 0x40
        private Beyond.UI.UIAnimationWrapper.FOptions _options;  // 0x48
        private UnityEngine.Animation m_animation;  // 0x50
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIAnimationWrapper.AnimationRuntime> m_animPool;  // 0x58
        private Beyond.UI.UIAnimationTween m_curTween;  // 0x60
        private System.Boolean m_isInAutoPlayed;  // 0x68
        private Beyond.UI.UIAnimationLoopSynchronizer m_loopSynchronizer;  // 0x70
        private static readonly System.Collections.Generic.List<Beyond.UI.UIAnimationLoopSynchronizer> s_tempSyncList;  // static @ 0x0
        public System.String curStateName;  // 0x78
        public Beyond.UI.UIConst.AnimationState curState;  // 0x80
        private System.Single m_lastPlayAnimationInStartTime;  // 0x84
        private System.Boolean m_started;  // 0x88
        private Beyond.UI.UIAnimationWrapper.CachedSampleClipInfo m_cachedSampleClipInfo;  // 0x90
        private System.Boolean m_needInformAnimationInEnd;  // 0xa0
        private Beyond.UI.LuaPanel m_panel;  // 0xa8
        private System.String _audioOnOpen;  // 0xb0
        private System.String _audioOnClose;  // 0xb8

        // Properties
        UnityEngine.AnimationClip animationIn { get; /* RVA: 0x01041090 */ }
        UnityEngine.AnimationClip animationInEasing { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.AnimationClip animationLoop { get; /* RVA: 0x03D4EAC0 */ }
        UnityEngine.AnimationClip animationOut { get; /* RVA: 0x01003830 */ }
        Beyond.UI.UIAnimationTween curTween { get; /* RVA: 0x03D4EB00 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x025CBD80 */ }

        // Methods
        // RVA: 0x03D43920  token: 0x6000298
        public System.Void SetOptions(Beyond.UI.UIAnimationWrapper.FOptions options) { }
        // RVA: 0x025CCEC0  token: 0x600029A
        private System.Void _InitAnimation() { }
        // RVA: 0x09AC3EF8  token: 0x600029B
        private System.Void _AnimationInLoopCheck() { }
        // RVA: 0x09AC3E20  token: 0x600029C
        private System.Void _AnimationAutomaticallyCheck() { }
        // RVA: 0x025CC7C0  token: 0x600029D
        private System.Void Awake() { }
        // RVA: 0x09AC3AA0  token: 0x600029E
        public System.Boolean IsStarted() { }
        // RVA: 0x0260AE30  token: 0x600029F
        public System.Void PlayOutAnimation(DG.Tweening.TweenCallback callback) { }
        // RVA: 0x0228D240  token: 0x60002A0
        public System.Void SetAnimationInClip(System.String clipName) { }
        // RVA: 0x0228D6B0  token: 0x60002A1
        public System.Void SetAnimationInEasingClip(System.String clipName) { }
        // RVA: 0x0228DB20  token: 0x60002A2
        public System.Void SetAnimationLoopClip(System.String clipName) { }
        // RVA: 0x09AC3C64  token: 0x60002A3
        public System.Void SetAnimationOutClip(System.String clipName) { }
        // RVA: 0x09AC38C0  token: 0x60002A4
        public System.Single GetInClipLength() { }
        // RVA: 0x09AC3A00  token: 0x60002A5
        public System.Single GetOutClipLength() { }
        // RVA: 0x09AC3960  token: 0x60002A6
        public System.Single GetLoopClipLength() { }
        // RVA: 0x03288580  token: 0x60002A7
        public System.Void PlayLoopAnimation() { }
        // RVA: 0x025CBA80  token: 0x60002A8
        public System.Void PlayInAnimation(DG.Tweening.TweenCallback callback, System.Boolean autoPlayLoop) { }
        // RVA: 0x09AC3CDC  token: 0x60002A9
        public System.Void SkipInAnimation() { }
        // RVA: 0x0309A180  token: 0x60002AA
        public System.Void SampleToInAnimationBegin() { }
        // RVA: 0x02B771E0  token: 0x60002AB
        public System.Void SampleToInAnimationEnd() { }
        // RVA: 0x09AC3BA8  token: 0x60002AC
        public System.Void SampleToOutAnimationBegin() { }
        // RVA: 0x02B797F0  token: 0x60002AD
        public System.Void SampleToOutAnimationEnd() { }
        // RVA: 0x032882F0  token: 0x60002AE
        private System.Void _OnInAnimationFinished(System.Boolean autoPlayLoop) { }
        // RVA: 0x032884D0  token: 0x60002AF
        private System.Void _OnInEasingAnimationFinished(System.Boolean autoPlayLoop) { }
        // RVA: 0x025CCE20  token: 0x60002B0
        public UnityEngine.AnimationState GetClip(System.String aniName) { }
        // RVA: 0x02B78A90  token: 0x60002B1
        public System.Single GetClipLength(System.String aniName) { }
        // RVA: 0x025CDE10  token: 0x60002B2
        private System.Void _SampleClipAtLength(Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime, System.Single position) { }
        // RVA: 0x02B78A10  token: 0x60002B3
        public System.Void SampleClipAtPercent(System.String clipName, System.Single percent, System.Boolean clearTween) { }
        // RVA: 0x025CD8C0  token: 0x60002B4
        public System.Void SampleClip(System.String clipName, System.Single position, System.Boolean clearTween) { }
        // RVA: 0x025CE410  token: 0x60002B5
        public System.Void ClearTween(System.Boolean executeOnComplete) { }
        // RVA: 0x025CB9F0  token: 0x60002B6
        private System.Boolean _CheckShouldAutoPlayAnimationIn() { }
        // RVA: 0x0341C330  token: 0x60002B7
        private System.Void Start() { }
        // RVA: 0x025CB8D0  token: 0x60002B8
        private System.Void OnEnable() { }
        // RVA: 0x025CCD80  token: 0x60002B9
        private System.Void OnDisable() { }
        // RVA: 0x034A9200  token: 0x60002BA
        private System.Void OnDestroy() { }
        // RVA: 0x09AC37F4  token: 0x60002BB
        public System.Boolean CheckStopped() { }
        // RVA: 0x09AC3AF0  token: 0x60002BC
        public System.Void Play(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        // RVA: 0x03D08600  token: 0x60002BD
        public System.Void Play(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        // RVA: 0x025CBCF0  token: 0x60002BE
        public System.Void PlayWithTween(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        // RVA: 0x025CC330  token: 0x60002BF
        public System.Void PlayWithTween(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        // RVA: 0x09AC3848  token: 0x60002C0
        public System.Single GetCurPlayingTime() { }
        // RVA: 0x025CBC90  token: 0x60002C2
        public System.Void PlayOpenAudio() { }
        // RVA: 0x0260AFB0  token: 0x60002C3
        public System.Void PlayCloseAudio() { }
        // RVA: 0x025CE620  token: 0x60002C4
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02815830  token: 0x60002C5
        public System.Void .ctor() { }
        // RVA: 0x03CE2CE0  token: 0x60002C6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006C  // size: 0x30
    public class UIAnimationTween
    {
        // Fields
        public static readonly Beyond.UI.UIAnimationTween.Options DEFAULT_OPTION;  // static @ 0x0
        private DG.Tweening.Tween m_handler;  // 0x10
        private System.Single m_tweenValue;  // 0x18
        private UnityEngine.GameObject m_animTarget;  // 0x20
        private System.Single <clipLength>k__BackingField;  // 0x28

        // Properties
        DG.Tweening.Tween handler { get; /* RVA: 0x020B7B20 */ }
        System.Single tweenValue { get; /* RVA: 0x03D4EBF0 */ }
        System.Single clipLength { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }

        // Methods
        // RVA: 0x09AC3768  token: 0x60002D7
        public System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name) { }
        // RVA: 0x025CBF90  token: 0x60002D8
        public System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name, Beyond.UI.UIAnimationTween.Options options) { }
        // RVA: 0x034E6250  token: 0x60002D9
        public System.Single GetValue() { }
        // RVA: 0x025CD6F0  token: 0x60002DA
        private System.Void _SetValue(Beyond.UI.UIAnimationWrapper wrapper, System.String name, System.Single value) { }
        // RVA: 0x03D2C800  token: 0x60002DB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x40
    public class UIAnimationSwitchTween : Beyond.UI.UISwitchTween
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper m_animWrapper;  // 0x30
        private System.Boolean m_dontDisableGameObject;  // 0x38

        // Methods
        // RVA: 0x04270470  token: 0x60002E2
        public System.Void .ctor(Beyond.UI.UIAnimationWrapper animWrapper) { }
        // RVA: 0x09AC3628  token: 0x60002E3
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        // RVA: 0x09AC36BC  token: 0x60002E4
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        // RVA: 0x09AC35D0  token: 0x60002E5
        protected virtual System.Void BeforeShowEffect() { }
        // RVA: 0x09AC3578  token: 0x60002E6
        protected virtual System.Void AfterHideEffect() { }
        // RVA: 0x03B2B4C0  token: 0x60002E7
        protected virtual System.Void ResetToState(System.Boolean isShow) { }
        // RVA: 0x03B2B580  token: 0x60002E8
        private System.Void _SetGameObjectActive(System.Boolean isActive) { }
        // RVA: 0x09AC3758  token: 0x60002E9
        public System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        // RVA: 0x09AC3750  token: 0x60002EA
        public System.Void <>iFixBaseProxy_AfterHideEffect() { }
        // RVA: 0x09AC3760  token: 0x60002EB
        public System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000073  // size: 0x38
    public class UIArea : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerEnter;  // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerExit;  // 0x20
        private System.Boolean m_pointerInArea;  // 0x28
        public UnityEngine.GameObject _highlightNode;  // 0x30

        // Properties
        System.Boolean pointerInArea { get; /* RVA: 0x03D4ED50 */ }

        // Methods
        // RVA: 0x09AC43CC  token: 0x60002F4
        private System.Void _SetHighlightNodeActive(System.Boolean active) { }
        // RVA: 0x09AC4294  token: 0x60002F5
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC4330  token: 0x60002F6
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC423C  token: 0x60002F7
        private System.Void OnEnable() { }
        // RVA: 0x09AC41E0  token: 0x60002F8
        private System.Void OnDisable() { }
        // RVA: 0x09AC4184  token: 0x60002F9
        private System.Void OnDestroy() { }
        // RVA: 0x09AC4118  token: 0x60002FA
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x60002FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000074  // size: 0xD0
    public class UIAutoCloseArea : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, Beyond.Input.IBindingGroupTarget
    {
        // Fields
        public static System.Boolean s_stopCheckShouldClose;  // static @ 0x0
        public System.Collections.Generic.List<UnityEngine.RectTransform> fixedSafeAreas;  // 0x68
        public UnityEngine.RectTransform tmpSafeArea;  // 0x70
        public System.Boolean alsoBlockKeyBoardInput;  // 0x78
        private System.Boolean _includeInAutoCloseLayer;  // 0x79
        private UnityEngine.Camera m_fallbackUICamera;  // 0x80
        public UnityEngine.GameObject toggleObj;  // 0x88
        public Beyond.DisposedUnityEvent onTriggerAutoClose;  // 0x90
        private System.String _closeActionId;  // 0x98
        private System.Boolean _enableCloseActionOnController;  // 0xa0
        private Beyond.UI.UIAnimationWrapper m_animationWrapper;  // 0xa8
        private static System.Collections.Generic.LinkedList<UnityEngine.GameObject> s_autoCloseLayerList;  // static @ 0x8
        private Beyond.UI.LuaPanel m_panel;  // 0xb0
        private System.Int32 <groupId>k__BackingField;  // 0xb8
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0xc0
        private System.Boolean m_bindingInit;  // 0xc8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Boolean includeInAutoCloseLayer { get; /* RVA: 0x03D51AE0 */ set; /* RVA: 0x09AC48E0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x0284E730 */ }
        System.Int32 groupId { get; /* RVA: 0x03D57DA0 */ set; /* RVA: 0x03D57DC0 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }
        System.Boolean groupEnabled { get; /* RVA: 0x09AC488C */ }

        // Methods
        // RVA: 0x0398AF20  token: 0x6000300
        private System.Void Start() { }
        // RVA: 0x09AC4680  token: 0x6000301
        private System.Void Reset() { }
        // RVA: 0x0284F680  token: 0x6000302
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x036B97A0  token: 0x6000303
        protected virtual System.Void OnEnable() { }
        // RVA: 0x036B9650  token: 0x6000304
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AC447C  token: 0x6000305
        public System.Void ChangeEnableCloseActionOnController(System.Boolean enabled) { }
        // RVA: 0x0284E7F0  token: 0x6000306
        public System.Void CloseSelf() { }
        // RVA: 0x09AC473C  token: 0x6000307
        public System.Void TryCloseSelf() { }
        // RVA: 0x09AC4590  token: 0x6000308
        public System.Void OpenSelf(System.Boolean executeOnComplete) { }
        // RVA: 0x02850340  token: 0x6000309
        public System.Boolean ShouldClose() { }
        // RVA: 0x03D4BEA0  token: 0x600030A
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AC47E8  token: 0x600030B
        private System.Void _AutoCloseToggleObjWhenOut() { }
        // RVA: 0x036B9840  token: 0x600030C
        public static System.Void AddToAutoCloseLayer(UnityEngine.GameObject go) { }
        // RVA: 0x036B9700  token: 0x600030D
        public static System.Void RemoveFromAutoCloseLayer(UnityEngine.GameObject go) { }
        // RVA: 0x0284E520  token: 0x600030E
        public static System.Boolean IsTopAutoCloseLayer(UnityEngine.GameObject go) { }
        // RVA: 0x0284E660  token: 0x600030F
        private UnityEngine.Camera _GetUICamera() { }
        // RVA: 0x0398AFC0  token: 0x6000315
        public System.Void InitBinding() { }
        // RVA: 0x036B9920  token: 0x6000316
        private System.Void _UpdateState() { }
        // RVA: 0x09AC44EC  token: 0x6000317
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x028493C0  token: 0x6000318
        public System.Void .ctor() { }
        // RVA: 0x03CE07A0  token: 0x6000319
        private static System.Void .cctor() { }
        // RVA: 0x0589E548  token: 0x600031A
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8AC  token: 0x600031B
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x600031C
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x05F2CFD8  token: 0x600031D
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x2000075  // size: 0x60
    public class UIBigLogo : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _rootNode;  // 0x18
        public Beyond.UI.UIImage _bigLogoImage;  // 0x20
        private UnityEngine.GameObject _stretchNode;  // 0x28
        public Beyond.UI.UIImage _stretchImageTop;  // 0x30
        public Beyond.UI.UIImage _stretchImageBottom;  // 0x38
        public Beyond.UI.UIImage _bg;  // 0x40
        public Beyond.UI.UIImage _originalImage;  // 0x48
        public Beyond.UI.UIImage _backgroundMask;  // 0x50
        public UnityEngine.CanvasGroup _originalImageMain;  // 0x58

        // Methods
        // RVA: 0x09AC4D4C  token: 0x600031E
        public System.Void SetBigLogoEditor(System.String bigLogoPath, System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean hideBackground, System.Boolean useOriginalImage) { }
        // RVA: 0x09AC4FB0  token: 0x600031F
        public System.Void ShowBigLogo(System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean useOriginalImage, System.Single originalImageScale) { }
        // RVA: 0x09AC4DD4  token: 0x6000320
        public System.Void SetBigLogoMask(UnityEngine.Color maskColor) { }
        // RVA: 0x09AC4990  token: 0x6000321
        public System.Void ClearBigLogoMask() { }
        // RVA: 0x09AC4A40  token: 0x6000322
        public System.Void ClearBigLogo(System.Boolean showOnTop) { }
        // RVA: 0x09AC4B88  token: 0x6000323
        public System.Void SetAlpha(System.Single alpha, System.Boolean showOnTop) { }
        // RVA: 0x09AC4EE8  token: 0x6000324
        public System.Void SetMaskAlpha(System.Single alpha) { }
        // RVA: 0x0426FE60  token: 0x6000325
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x2E0
    public class UIBigRectButton : Beyond.UI.UIButton, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IScrollHandler
    {
        // Fields
        private Beyond.UI.UIBigRectHelper _bigRectHelper;  // 0x2d8

        // Methods
        // RVA: -1  // generic def  token: 0x6000326
        private System.Void _TryThroughEventDataToBigRectTouchPanelRaycast(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> eventFunction) { }
        // RVA: 0x022C3B40  token: 0x6000327
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x022C3AA0  token: 0x6000328
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC5214  token: 0x6000329
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC5170  token: 0x600032A
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC52B8  token: 0x600032B
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC535C  token: 0x600032C
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02848630  token: 0x600032D
        public System.Void .ctor() { }
        // RVA: 0x09AC5400  token: 0x600032E
        public System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AC5408  token: 0x600032F
        public System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0) { }

    }

    // TypeToken: 0x2000077  // size: 0x1E8
    public class UIBigRectHelper : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Boolean m_inited;  // 0x68
        private System.Boolean m_openTweenFinished;  // 0x69
        private Beyond.DisposedUnityEvent m_onOpenTweenFinished;  // 0x70
        private System.Single m_zoom;  // 0x78
        private System.Single m_zoomValue;  // 0x7c
        private UnityEngine.Vector2 m_oriSize;  // 0x80
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> m_zoomTween;  // 0x88
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> m_focusTween;  // 0x90
        private UnityEngine.Vector2 m_anchoredPosOffset;  // 0x98
        private System.Single m_horizontalOffset;  // 0xa0
        private System.Single m_verticalOffset;  // 0xa4
        private UnityEngine.Vector2 m_lastScale;  // 0xa8
        private UnityEngine.Vector2 m_nodesOffsetWithContainerNode;  // 0xb0
        private Beyond.UI.LuaPanel m_luaPanel;  // 0xb8
        private UnityEngine.RectTransform m_rootRectTransform;  // 0xc0
        private System.Single m_zoomRangeMin;  // 0xc8
        private System.Boolean m_useOverrideMinZoomRange;  // 0xcc
        private System.Single m_zoomRangeOverrideMin;  // 0xd0
        private Beyond.UI.UITouchPanel _touchPanel;  // 0xd8
        private UnityEngine.RectTransform _containerBigRectTransform;  // 0xe0
        private UnityEngine.RectTransform _nodes;  // 0xe8
        private System.Single _moveSpeed;  // 0xf0
        private System.Single _zoomSpeed;  // 0xf4
        private System.Single _zoomRangeMax;  // 0xf8
        private System.Boolean _needResetPositionAndScale;  // 0xfc
        private System.Boolean _needCenterZoomMobile;  // 0xfd
        private System.Collections.Generic.List<System.Single> _zoomThresholds;  // 0x100
        private Beyond.DisposedUnityEvent<System.Int32,System.Boolean> m_zoomEvent;  // 0x108
        private System.Single _zoomTweenTime;  // 0x110
        private System.Single _moveNodeXOffset;  // 0x114
        private System.Single _moveNodeYOffset;  // 0x118
        private System.Single _openZoomTweenTime;  // 0x11c
        private UnityEngine.AnimationCurve _openZoomCurve;  // 0x120
        private System.Single _focusNodeTime;  // 0x128
        private UnityEngine.AnimationCurve _focusNodeCurve;  // 0x130
        private System.Boolean _containerEdgeAlignLeft;  // 0x138
        private UnityEngine.RectOffset _padding;  // 0x140
        private System.Single _paddingBottomIncludeControllerHintBar;  // 0x148
        private System.Single _controllerContainerHorizontalMoveSpeed;  // 0x14c
        private System.Single _controllerContainerVerticalMoveSpeed;  // 0x150
        private System.Single _controllerZoomRate;  // 0x154
        private UnityEngine.GameObject _controllerZoomKeyHint;  // 0x158
        private System.Boolean _useFocusRect;  // 0x160
        private System.Boolean _useClickKeyHint;  // 0x161
        private UnityEngine.Transform _raycastRoot;  // 0x168
        private UnityEngine.RectTransform _controllerFocusRect;  // 0x170
        private System.Single _controllerFocusRectHorizontalMoveSpeed;  // 0x178
        private System.Single _controllerFocusRectVerticalMoveSpeed;  // 0x17c
        private System.Single _controllerFocusLeftBoundPadding;  // 0x180
        private System.Single _controllerFocusRightBoundPadding;  // 0x184
        private System.Single _controllerFocusBottomBoundPadding;  // 0x188
        private System.Single _controllerFocusTopBoundPadding;  // 0x18c
        private UnityEngine.Vector2 m_lastStickValue;  // 0x190
        private UnityEngine.EventSystems.PointerEventData m_controllerFocusEventData;  // 0x198
        private readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_raycastResults;  // 0x1a0
        private UnityEngine.UI.Selectable m_lastHitSelectable;  // 0x1a8
        private System.Int32 m_bindingGroupId;  // 0x1b0
        private static System.String CLICK_ACTION_ID;  // const
        private static System.String CLICK_NO_HINT_ACTION_ID;  // const
        private static System.Single DELTA_TIME_TO_STICK_VALUE_RATIO;  // const
        private System.Int32 <clickBindingId>k__BackingField;  // 0x1b4
        private System.Boolean <controllerMoveEnabled>k__BackingField;  // 0x1b8
        private System.Boolean <controllerZoomEnabled>k__BackingField;  // 0x1b9
        public readonly Beyond.DisposedUnityEvent onControllerMoveStart;  // 0x1c0
        public readonly Beyond.DisposedUnityEvent onControllerMoveStop;  // 0x1c8
        public readonly Beyond.DisposedUnityEvent onControllerZoom;  // 0x1d0
        public readonly Beyond.DisposedUnityEvent onControllerFocusEnterSelectable;  // 0x1d8
        public readonly Beyond.DisposedUnityEvent onControllerFocusExitSelectable;  // 0x1e0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55740 */ }
        Beyond.DisposedUnityEvent OnOpenTweenFinished { get; /* RVA: 0x03D4EB30 */ }
        System.Single zoomRangeMin { get; /* RVA: 0x022C4DD0 */ }
        Beyond.DisposedUnityEvent<System.Int32,System.Boolean> zoomEvent { get; /* RVA: 0x09AC66F8 */ }
        Beyond.UI.UITouchPanel touchPanel { get; /* RVA: 0x03D4E7B0 */ }
        System.Int32 clickBindingId { get; /* RVA: 0x03D75FD0 */ set; /* RVA: 0x03D75FE0 */ }
        System.Boolean controllerMoveEnabled { get; /* RVA: 0x03D58E30 */ set; /* RVA: 0x03D5B920 */ }
        System.Boolean controllerZoomEnabled { get; /* RVA: 0x03D5DB70 */ set; /* RVA: 0x03D75FF0 */ }

        // Methods
        // RVA: 0x02BDBF00  token: 0x6000335
        protected virtual System.Void OnAwake() { }
        // RVA: 0x031EB0C0  token: 0x6000336
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x022C4770  token: 0x6000337
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x03D46240  token: 0x6000338
        protected virtual System.Void OnRelease() { }
        // RVA: 0x022C3DB0  token: 0x6000339
        private System.Void _OnDrag(UnityEngine.Vector2 value) { }
        // RVA: 0x09AC5814  token: 0x600033A
        public System.Void ManuallyZoom(System.Single value, System.Boolean needTween) { }
        // RVA: 0x09AC6478  token: 0x600033B
        private System.Void _RefreshPivotPosition() { }
        // RVA: 0x09AC5CAC  token: 0x600033C
        private System.Void _OnZoom(System.Single value, System.Boolean needTween) { }
        // RVA: 0x022C4A00  token: 0x600033D
        private System.Void _SetZoomValueAndScale(System.Single value, System.Boolean needTween) { }
        // RVA: 0x022C4DF0  token: 0x600033E
        private System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish) { }
        // RVA: 0x022C4470  token: 0x600033F
        private System.Void _GetContainerRectBounds(UnityEngine.Vector2& leftBottom, UnityEngine.Vector2& rightTop) { }
        // RVA: 0x022C42A0  token: 0x6000340
        private UnityEngine.Vector2 _GetAdjustedPosition(UnityEngine.Vector2 position) { }
        // RVA: 0x022C3E60  token: 0x6000341
        private System.Void _PosAdjust() { }
        // RVA: 0x09AC6278  token: 0x6000342
        private System.Void _RefreshPivotPositionToMousePosition() { }
        // RVA: 0x02F63400  token: 0x6000343
        private System.Void _RefreshPivotPosition(UnityEngine.Vector3 targetScreenPosition) { }
        // RVA: 0x022C48F0  token: 0x6000344
        private System.Void _UpdatePositionOffsetAfterZoomed() { }
        // RVA: 0x09AC6520  token: 0x6000345
        private System.Void _TryAlignWhenInit() { }
        // RVA: 0x022C4B40  token: 0x6000346
        public System.Void Init() { }
        // RVA: 0x09AC5598  token: 0x6000347
        public System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x022C3ED0  token: 0x6000348
        public System.Void FocusNode(UnityEngine.RectTransform nodeRect, System.Boolean needTween, DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x09AC5A58  token: 0x6000349
        public System.Void ZoomToFullRect(DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x09AC5410  token: 0x600034A
        public System.Void ChangePaddingRight(System.Int32 right) { }
        // RVA: 0x03D4CE60  token: 0x600034B
        public System.Void SetZoomRangeMax(System.Single maxValue) { }
        // RVA: 0x03D4CAC0  token: 0x600034C
        public System.Void OverrideZoomRangeMin(System.Single minValue) { }
        // RVA: 0x022C4890  token: 0x600034D
        public System.Void SyncZoomValue(System.Single zoomValue, System.Boolean needTween) { }
        // RVA: 0x09AC5798  token: 0x600034E
        public System.Void GetZoomRange(System.Single& rangeMin, System.Single& rangeMax) { }
        // RVA: 0x09AC5748  token: 0x600034F
        public System.Single GetCurrentZoomValue() { }
        // RVA: 0x09AC5484  token: 0x6000350
        public System.Void ChangePivotPositionToTarget(UnityEngine.RectTransform target) { }
        // RVA: 0x02F63370  token: 0x6000351
        public System.Void ResetPivotPositionToScreenCenter() { }
        // RVA: 0x03C79D70  token: 0x6000352
        public virtual System.Void ClearComponent() { }
        // RVA: 0x03C79E50  token: 0x6000353
        public System.Void ClearAllTween() { }
        // RVA: 0x02BDBD60  token: 0x600035A
        private System.Void _InitControllerBindings() { }
        // RVA: 0x031EB420  token: 0x600035B
        private System.Boolean _GetIsControllerMoveEnabled() { }
        // RVA: 0x031EB280  token: 0x600035C
        private System.Boolean _GetIsControllerZoomEnabled() { }
        // RVA: 0x022C3C70  token: 0x600035D
        private System.Void _ResetControllerState() { }
        // RVA: 0x031EB110  token: 0x600035E
        private System.Void _TickRefreshController(System.Single deltaTime) { }
        // RVA: 0x031EB300  token: 0x600035F
        private System.Void _TickRefreshControllerStickMove(System.Single deltaTime) { }
        // RVA: 0x09AC5D38  token: 0x6000360
        private System.Void _RefreshControllerFocusRaycastResults(System.Boolean ignoreTouchPanel, UnityEngine.UI.Selectable& hitSelectable, Beyond.UI.UITouchPanel& hitTouchPanel) { }
        // RVA: 0x022C47C0  token: 0x6000361
        private System.Void _TickCheckControllerFocusRaycastTargets() { }
        // RVA: 0x09AC5AE0  token: 0x6000362
        private System.Void _OnControllerClick() { }
        // RVA: 0x031EB170  token: 0x6000363
        private System.Void _TickRefreshControllerStickZoom(System.Single deltaTime) { }
        // RVA: 0x031EB1D0  token: 0x6000364
        private System.Void _TickRefreshControllerZoomKeyHint() { }
        // RVA: 0x02849F90  token: 0x6000365
        public System.Void .ctor() { }
        // RVA: 0x022C3BE0  token: 0x6000366
        private System.Void <OnAwake>b__62_0(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AC59B8  token: 0x6000367
        private System.Void <OnAwake>b__62_1(System.Single zoomValue) { }
        // RVA: 0x09AC5A38  token: 0x6000368
        private System.Void <_SetScale>b__71_0() { }
        // RVA: 0x09AC5890  token: 0x6000369
        private System.Void <Init>b__79_0() { }
        // RVA: 0x058E2A30  token: 0x600036A
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x600036B
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0589E548  token: 0x600036C
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x600036D
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000079  // size: 0x238
    public class UIBlendImage : Beyond.UI.UIImage
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> s_materials;  // static @ 0x0
        private UnityEngine.Material m_originalMaterial;  // 0x228
        private System.Boolean m_initialized;  // 0x230

        // Methods
        // RVA: 0x09ACAE28  token: 0x6000370
        public System.Void SetMaterialKey(System.String key) { }
        // RVA: 0x09ACAD84  token: 0x6000371
        public System.Void SetColor(System.String materialId, UnityEngine.Color c) { }
        // RVA: 0x09ACB0B8  token: 0x6000372
        public System.Void SetTexture(System.String materialId, UnityEngine.Texture t) { }
        // RVA: 0x03CE0710  token: 0x6000373
        public static System.Void ClearMaterialCache() { }
        // RVA: 0x09ACB144  token: 0x6000374
        public System.Void .ctor() { }
        // RVA: 0x03CE2C50  token: 0x6000375
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007A  // size: 0x88
    public class UIBlurMono : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Canvas m_canvas;  // 0x68
        private Beyond.UI.LuaPanel m_panel;  // 0x70
        private System.Int32 m_sortingOrder;  // 0x78
        private HG.Rendering.Runtime.HGCamera m_camera;  // 0x80

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        UnityEngine.Canvas canvas { get; /* RVA: 0x02A728E0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x02A727C0 */ }

        // Methods
        // RVA: 0x02A726C0  token: 0x6000379
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02A724F0  token: 0x600037A
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09ACB14C  token: 0x600037B
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09ACB258  token: 0x600037C
        public System.Void UpdateSortingOrder(System.Int32 order) { }
        // RVA: 0x02A72550  token: 0x600037D
        private HG.Rendering.Runtime.HGCamera _GetCamera() { }
        // RVA: 0x02846010  token: 0x600037E
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x600037F
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x6000380
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7BC  token: 0x6000381
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x200007B  // size: 0x58
    public class UIBlurRT : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage _rawImage;  // 0x18
        private System.Boolean _autoUpdate;  // 0x20
        private HG.Rendering.Runtime.RTExtractionType _rtExtractionType;  // 0x24
        private HG.Rendering.Runtime.RTExtractionDuration _rtExtractionDuration;  // 0x28
        private UnityEngine.Rendering.RTHandle m_rtHandle;  // 0x30
        private System.Boolean _needUseSceneColorPS;  // 0x38
        private UnityEngine.Rendering.RTHandle m_useSceneColorPsRtHandle;  // 0x40
        private System.Boolean m_curIsUseSceneColorPS;  // 0x48
        private UnityEngine.Texture <customBlurTexture>k__BackingField;  // 0x50

        // Properties
        UnityEngine.UI.RawImage rawImage { get; /* RVA: 0x01041090 */ }
        UnityEngine.Texture customBlurTexture { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }

        // Methods
        // RVA: 0x09ACB334  token: 0x6000383
        private System.Void Reset() { }
        // RVA: 0x035ED100  token: 0x6000384
        public System.Void InitRT() { }
        // RVA: 0x035ED4A0  token: 0x6000385
        public System.Void Register() { }
        // RVA: 0x09ACB4DC  token: 0x6000386
        public System.Void UnRegister() { }
        // RVA: 0x09ACB5BC  token: 0x6000387
        public System.Void UpdateRT() { }
        // RVA: 0x035ECF30  token: 0x6000388
        private System.Void OnEnable() { }
        // RVA: 0x035ECC10  token: 0x6000389
        private System.Void OnDisable() { }
        // RVA: 0x09ACB2E4  token: 0x600038A
        private System.Void OnDestroy() { }
        // RVA: 0x035ECC50  token: 0x600038B
        private System.Void _Clear() { }
        // RVA: 0x0228DF90  token: 0x600038C
        public System.Void SetUseSceneColorPS(System.Boolean useSceneColorPS, System.Boolean forceUpdate) { }
        // RVA: 0x09ACB3B4  token: 0x600038F
        public System.Void SetCustomBlurImg(UnityEngine.Texture texture) { }
        // RVA: 0x03D1F3A0  token: 0x6000390
        public System.Void .ctor() { }
        // RVA: 0x03CFE6D0  token: 0x6000391
        private System.Void <Register>b__12_0() { }

    }

    // TypeToken: 0x200007C  // size: 0x2D8
    public class UIButton : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.Input.IBindingGroupTarget, Beyond.Input.IBindingView, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.String _audioPressStart;  // 0x180
        private System.String _audioOnClick;  // 0x188
        private System.String _audioRelease;  // 0x190
        private System.String _audioLongPress;  // 0x198
        private System.String _audioInvalid;  // 0x1a0
        private System.Boolean _noAudioWhenAutoTriggerOnClick;  // 0x1a8
        private static System.Single MIN_DRAG_DIST;  // const
        private static System.Single DOUBLE_CLICK_MAX_INTERVAL;  // const
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onClick;  // 0x1b0
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onDoubleClick;  // 0x1b8
        public System.Boolean _ignoreClickOnDrag;  // 0x1c0
        public System.Boolean _clickThrough;  // 0x1c1
        private System.Single _clickCd;  // 0x1c4
        private Beyond.LangKey _invalidClickLangKey;  // 0x1c8
        private System.Single m_lastValidClickTime;  // 0x1d8
        private System.Single m_lastClickTime;  // 0x1dc
        private System.Boolean _useClickAnimation;  // 0x1e0
        private UnityEngine.AnimationCurve _clickAnimationCurve;  // 0x1e8
        private System.Single _clickAnimationDuration;  // 0x1f0
        private UnityEngine.Vector3 m_oriScale;  // 0x1f4
        private UnityEngine.Coroutine m_clickCor;  // 0x200
        private System.Boolean m_scaled;  // 0x208
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onLongPress;  // 0x210
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onPressStart;  // 0x218
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onPressEnd;  // 0x220
        private System.Single _longPressTime;  // 0x228
        public System.Boolean _ignoreClickOnLongPress;  // 0x22c
        public Beyond.UI.UIImage longPressImg;  // 0x230
        private System.Single _longPressImgShowDelay;  // 0x238
        private System.Single _longPressMaxDragDist;  // 0x23c
        private System.Boolean _forceEnableButtonPressAudio;  // 0x240
        private System.Boolean m_pressDownWaitClick;  // 0x241
        private UnityEngine.Vector2 <startPressPos>k__BackingField;  // 0x244
        private System.Int32 <pressTouchId>k__BackingField;  // 0x24c
        private UnityEngine.Coroutine m_longPressCor;  // 0x250
        private System.Boolean m_triggeredLongPress;  // 0x258
        public System.Boolean noTextBtn;  // 0x259
        private Beyond.UI.UIText m_autoFindLabel;  // 0x260
        private Beyond.UI.UIText _label;  // 0x268
        private System.Int32 m_groupId;  // 0x270
        private System.Boolean m_bindingInit;  // 0x274
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;  // 0x278
        private System.String m_customBindingViewLabelText;  // 0x280
        public System.String hintTextId;  // 0x288
        private readonly Beyond.DisposedUnityEvent <bindingViewUpdateEvent>k__BackingField;  // 0x290
        private UnityEngine.RectTransform _redDotTrans;  // 0x298
        private System.String _audioGamePadLongPress;  // 0x2a0
        private Beyond.UI.LuaPanel m_panel;  // 0x2a8
        private System.Int32 m_hoverBindingGroupId;  // 0x2b0
        public System.String clickHintTextId;  // 0x2b8
        public System.String longPressHintTextId;  // 0x2c0
        private Beyond.Input.ActionOnSetNaviTarget _actionOnSetNaviTarget;  // 0x2c8
        private System.Boolean _useNoHintAction;  // 0x2cc
        private System.Int32 <hoverConfirmBindingId>k__BackingField;  // 0x2d0

        // Properties
        UnityEngine.Vector2 startPressPos { get; /* RVA: 0x03D76030 */ set; /* RVA: 0x03D76070 */ }
        System.Int32 pressTouchId { get; /* RVA: 0x03D76020 */ set; /* RVA: 0x03D76060 */ }
        System.Single longPressTime { get; /* RVA: 0x03D76010 */ }
        UnityEngine.Vector2 curPressPos { get; /* RVA: 0x09ACBC8C */ }
        System.Boolean triggeredLongPress { get; /* RVA: 0x03D59820 */ }
        System.String text { get; /* RVA: 0x09ACBCE4 */ set; /* RVA: 0x03822480 */ }
        Beyond.UI.UIText label { get; /* RVA: 0x03822590 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x033BE090 */ }
        System.Int32 groupId { get; /* RVA: 0x022B0E50 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D57270 */ }
        Beyond.Input.InputBindingGroupMonoTarget parent { get; /* RVA: 0x03D57270 */ set; /* RVA: 0x058B3EC0 */ }
        System.String bindingViewActionId { get; /* RVA: 0x03342280 */ }
        System.String customBindingViewLabelText { get; /* RVA: 0x03D573B0 */ set; /* RVA: 0x03C8A840 */ }
        System.String bindingViewLabelText { get; /* RVA: 0x04272C90 */ }
        System.String hintText { get; /* RVA: 0x036AFB90 */ }
        Beyond.DisposedUnityEvent bindingViewUpdateEvent { get; /* RVA: 0x03D57040 */ }
        UnityEngine.RectTransform redDotTrans { get; /* RVA: 0x03D57180 */ }
        System.Boolean bindingEnabled { get; /* RVA: 0x09ACBC84 */ }
        Beyond.Input.BindingViewState bindingViewState { get; /* RVA: 0x0251B0F0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x0284D6C0 */ }
        System.Int32 hoverBindingGroupId { get; /* RVA: 0x024B2330 */ }
        Beyond.Input.ActionOnSetNaviTarget actionOnSetNaviTarget { get; /* RVA: 0x03D76000 */ }
        System.Int32 hoverConfirmBindingId { get; /* RVA: 0x02A18C40 */ set; /* RVA: 0x03D76050 */ }

        // Methods
        // RVA: 0x02C70580  token: 0x6000392
        protected virtual System.Void Awake() { }
        // RVA: 0x022B08B0  token: 0x6000393
        protected virtual System.Void OnEnable() { }
        // RVA: 0x022B0780  token: 0x6000394
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02C71A00  token: 0x6000395
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02C6F4F0  token: 0x6000396
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x0284C860  token: 0x6000397
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284D3E0  token: 0x6000398
        private System.Void _Press(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284E470  token: 0x6000399
        private System.Void _PlayClickAnimation(System.Boolean reverse) { }
        // RVA: 0x09ACB9D0  token: 0x600039A
        private System.Collections.IEnumerator _DoClickAnimation() { }
        // RVA: 0x0284E1A0  token: 0x60003A2
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284E0B0  token: 0x60003A3
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284E3E0  token: 0x60003A4
        private System.Collections.IEnumerator _OnPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x022B07F0  token: 0x60003A5
        private System.Void _StopLongPressCor() { }
        // RVA: 0x02C71C50  token: 0x60003A9
        public virtual System.Void ClearComponent() { }
        // RVA: 0x022B0F30  token: 0x60003AF
        public System.Void InitBinding() { }
        // RVA: 0x03CF0040  token: 0x60003B0
        public virtual System.Void OnInteractableChanged() { }
        // RVA: 0x022B0C40  token: 0x60003B1
        private System.Void _UpdateState() { }
        // RVA: 0x03342200  token: 0x60003BB
        public virtual System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        // RVA: 0x039D5E80  token: 0x60003BC
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger) { }
        // RVA: 0x03973430  token: 0x60003BD
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger) { }
        // RVA: 0x03544090  token: 0x60003BE
        private System.Void _OnUpdateKey() { }
        // RVA: 0x03342360  token: 0x60003BF
        private System.String _GetUIButtonKeyHintActionId(Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> buttonEvent) { }
        // RVA: 0x024B1F30  token: 0x60003C2
        protected virtual System.Void _RefreshHoverEnableNode(System.Boolean active) { }
        // RVA: 0x09ACB79C  token: 0x60003C3
        public virtual System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        // RVA: 0x09ACB82C  token: 0x60003C4
        public virtual System.Void OnNaviTargetEnabledAgain() { }
        // RVA: 0x09ACBA60  token: 0x60003C6
        protected virtual System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        // RVA: 0x02C6D420  token: 0x60003C9
        private System.Void _InitActionOnSetNaviTarget() { }
        // RVA: 0x09ACBBEC  token: 0x60003CA
        private System.Void _ToggleNaviInputBinding(System.Boolean active) { }
        // RVA: 0x09ACB6E0  token: 0x60003CB
        public System.Void ChangeActionOnSetNaviTarget(Beyond.Input.ActionOnSetNaviTarget action) { }
        // RVA: 0x02848640  token: 0x60003CC
        public System.Void .ctor() { }
        // RVA: 0x09ACB690  token: 0x60003CD
        private virtual System.Boolean Beyond.Input.IBindingView.get_interactable() { }
        // RVA: 0x0284B340  token: 0x60003CE
        private System.Void <InitBinding>b__82_0() { }
        // RVA: 0x09ACB8BC  token: 0x60003CF
        private System.Void <InitBinding>b__82_1() { }
        // RVA: 0x09ACB908  token: 0x60003D0
        private System.Void <InitBinding>b__82_2() { }
        // RVA: 0x0284C7F0  token: 0x60003D1
        private System.Void <InitBinding>b__82_3() { }
        // RVA: 0x0284C280  token: 0x60003D2
        private System.Void <InitBinding>b__82_4() { }
        // RVA: 0x09ACB984  token: 0x60003D3
        private System.Void <_InitActionOnSetNaviTarget>b__132_0() { }
        // RVA: 0x09ACB964  token: 0x60003D4
        public System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09ACB96C  token: 0x60003D5
        public System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AAE8DC  token: 0x60003D6
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AAE8EC  token: 0x60003D7
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0361D5F0  token: 0x60003D8
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AAE8E4  token: 0x60003D9
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09ACB974  token: 0x60003DA
        public System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        // RVA: 0x0350B670  token: 0x60003DB
        public System.Void <>iFixBaseProxy_OnInteractableChanged() { }
        // RVA: 0x09ACB97C  token: 0x60003DC
        public System.Void <>iFixBaseProxy__RefreshHoverEnableNode(System.Boolean P0) { }
        // RVA: 0x09ACB954  token: 0x60003DD
        public System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1) { }
        // RVA: 0x09ACB95C  token: 0x60003DE
        public System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain() { }
        // RVA: 0x0350B670  token: 0x60003DF
        public System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x200007F  // size: 0x14
    public sealed struct CanvasMatchMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CanvasMatchMode Width;  // const
        public static Beyond.UI.CanvasMatchMode Height;  // const

    }

    // TypeToken: 0x2000080  // size: 0x58
    public class UICanvasScaleHelper : UnityEngine.MonoBehaviour, IScreenSizeListener, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Boolean _useCustomStandardResolution;  // 0x18
        private UnityEngine.Vector2 _customStandardResolution;  // 0x1c
        private System.Single _customPCReferenceResolutionScale;  // 0x24
        private System.Collections.Generic.HashSet<UnityEngine.Canvas> m_canvasList;  // 0x28
        private System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> m_canvasScalerList;  // 0x30
        private System.Boolean m_isCanvasChanged;  // 0x38
        public System.Boolean isSingleCanvas;  // 0x39
        public UnityEngine.Camera uiCamera;  // 0x40
        public Beyond.DisposedUnityEvent onScreenSizeChanged;  // 0x48
        public Beyond.DisposedUnityEvent onCanvasChanged;  // 0x50

        // Properties
        System.Single standardHorizontalResolution { get; /* RVA: 0x027FF8D0 */ }
        System.Single standardVerticalResolution { get; /* RVA: 0x027FF890 */ }
        System.Single standardResolutionScale { get; /* RVA: 0x027FF910 */ }
        System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> canvasScalerList { get; /* RVA: 0x09ACBFCC */ }

        // Methods
        // RVA: 0x0380FB70  token: 0x60003F0
        private System.Void Awake() { }
        // RVA: 0x0380FBB0  token: 0x60003F1
        private System.Void _OnInit() { }
        // RVA: 0x02CD1A00  token: 0x60003F2
        private System.Void Start() { }
        // RVA: 0x02CD0FE0  token: 0x60003F3
        private System.Void OnDestroy() { }
        // RVA: 0x028A9E10  token: 0x60003F4
        public System.Void UpdateCanvas() { }
        // RVA: 0x02CD18F0  token: 0x60003F5
        public virtual System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height) { }
        // RVA: 0x027FF710  token: 0x60003F6
        public System.Void AddCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s) { }
        // RVA: 0x0397EA50  token: 0x60003F7
        public System.Void RemoveCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s) { }
        // RVA: 0x09ACBE18  token: 0x60003F8
        private System.Void _OnInputTypeChanged() { }
        // RVA: 0x03079A10  token: 0x60003F9
        private System.Void _CanvasOnWillRenderCanvases() { }
        // RVA: 0x028AAB40  token: 0x60003FA
        public static Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams CalcWorldCanvasParams(UnityEngine.Camera camera, UnityEngine.Transform uiRoot, System.Boolean useLocalPos) { }
        // RVA: 0x028AC370  token: 0x60003FB
        public static Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams CalcScreenCanvasParams() { }
        // RVA: 0x028AC5A0  token: 0x60003FC
        public static System.Single CalcCurrentScreenRatio(UnityEngine.Vector2& screenSize) { }
        // RVA: 0x027FF820  token: 0x60003FD
        public UnityEngine.Vector2 GetProperCanvasResolution() { }
        // RVA: 0x09ACBDBC  token: 0x60003FE
        public System.Void ForceCanvasUpdate() { }
        // RVA: 0x02CD0D20  token: 0x60003FF
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02847080  token: 0x6000400
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0xE0
    public class UIColorGroup : Beyond.UI.NonDrawingGraphic
    {
        // Fields
        private UnityEngine.UI.Graphic[] _colorElements;  // 0xb8
        private UnityEngine.Color _color;  // 0xc0
        private System.Boolean m_isOperating;  // 0xd0
        private System.Collections.Generic.List<Beyond.UI.UIColorGroup.DynEle> m_dynList;  // 0xd8

        // Properties
        UnityEngine.Color color { get; /* RVA: 0x03D6C030 */ set; /* RVA: 0x09ACCA9C */ }

        // Methods
        // RVA: 0x09ACC01C  token: 0x6000403
        public System.Void AttachGraphic(UnityEngine.UI.Graphic graphic, System.Boolean useStaticColor) { }
        // RVA: 0x09ACC27C  token: 0x6000404
        public System.Void AttachGraphicsWithGroup(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphic, System.String groupId) { }
        // RVA: 0x09ACC598  token: 0x6000405
        public virtual System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        // RVA: 0x09ACC6B4  token: 0x6000406
        public virtual System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB) { }
        // RVA: 0x036F87F0  token: 0x6000407
        public virtual System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        // RVA: 0x036F8980  token: 0x6000408
        private System.Void _ApplyOptToGraphics(Beyond.UI.UIColorGroup.GraphicOpt opt, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x09ACC890  token: 0x6000409
        private static System.Void _CrossFadeAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x09ACC924  token: 0x600040A
        private static System.Void _CrossFadeColorRGB(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x038C6D30  token: 0x600040B
        private static System.Void _CrossFadeColorAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x09ACCA00  token: 0x600040C
        private static System.Void _SetColor(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        // RVA: 0x027006E0  token: 0x600040D
        public System.Void .ctor() { }
        // RVA: 0x09ACC870  token: 0x600040E
        public System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0) { }
        // RVA: 0x09ACC7F4  token: 0x600040F
        public System.Void <>iFixBaseProxy_CrossFadeAlpha(System.Single P0, System.Single P1, System.Boolean P2) { }
        // RVA: 0x09ACC834  token: 0x6000410
        public System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x09ACC804  token: 0x6000411
        public System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3) { }

    }

    // TypeToken: 0x2000087  // size: 0x28
    public class UIControllerKeyIcon : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.String _keyIconName;  // 0x18
        private Beyond.UI.UIImage m_image;  // 0x20
        private static System.Collections.Generic.List<Beyond.UI.UIControllerKeyIcon> s_iconCache;  // static @ 0x0
        private static System.Boolean s_initialized;  // static @ 0x8

        // Methods
        // RVA: 0x09ACD0B4  token: 0x6000416
        private static System.Void _TryStaticInit() { }
        // RVA: 0x09ACCF18  token: 0x6000417
        private static System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) { }
        // RVA: 0x09ACCBA4  token: 0x6000418
        private System.Void Awake() { }
        // RVA: 0x09ACCCF4  token: 0x6000419
        private System.Void OnEnable() { }
        // RVA: 0x09ACCC50  token: 0x600041A
        private System.Void OnDisable() { }
        // RVA: 0x09ACCE7C  token: 0x600041B
        public System.Void SetKeyIconName(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x09ACCDA0  token: 0x600041C
        public System.Void RefreshKeyIcon() { }
        // RVA: 0x0426FE60  token: 0x600041D
        public System.Void .ctor() { }
        // RVA: 0x03CBCD70  token: 0x600041E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x30
    public class UICustomLayout : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private UnityEngine.RectTransform _dragArea;  // 0x18
        public System.Collections.Generic.List<Beyond.UI.UICustomLayoutHandle> layoutHandles;  // 0x20
        private ZSimpleJSON.JSONArray m_eventLog;  // 0x28

        // Properties
        UnityEngine.RectTransform dragArea { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x09ACF448  token: 0x6000420
        protected virtual System.Void Awake() { }
        // RVA: 0x09ACF590  token: 0x6000421
        public System.Boolean IsDirty() { }
        // RVA: 0x09ACF6EC  token: 0x6000422
        public System.Void ResetToDefault(System.Boolean saveChanges) { }
        // RVA: 0x09ACF878  token: 0x6000423
        public System.Void Save(System.Int32 ratio) { }
        // RVA: 0x09ACFB28  token: 0x6000424
        private System.Void _LogEvent(System.Collections.Generic.Dictionary<Beyond.UI.UICustomLayoutElement,Beyond.UI.UICustomLayoutElement.LayoutData> layoutDataMap) { }
        // RVA: 0x09AD0058  token: 0x6000425
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000426
        public System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x2000089  // size: 0x80
    public class UICustomLayoutElement : UnityEngine.EventSystems.UIBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Int32 _verNum;  // 0x18
        private System.String _elementKey;  // 0x20
        private UnityEngine.Transform _overrideScaleTransform;  // 0x28
        private UnityEngine.CanvasGroup _overrideCanvasGroup;  // 0x30
        private UnityEngine.RectTransform _overrideHighlightRect;  // 0x38
        public Beyond.DisposedUnityEvent onLayoutDataLoaded;  // 0x40
        private Beyond.UI.LuaPanel m_panel;  // 0x48
        private System.Single m_scale;  // 0x50
        private System.Single m_alpha;  // 0x54
        private UnityEngine.Vector2 m_position;  // 0x58
        private Beyond.UI.UICustomLayoutElement.LayoutType m_layoutType;  // 0x60
        private System.Single m_defaultScale;  // 0x64
        private System.Single m_defaultAlpha;  // 0x68
        private UnityEngine.Vector2 m_defaultPosition;  // 0x6c
        private UnityEngine.RectTransform m_rectTransform;  // 0x78

        // Properties
        System.String elementKey { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.RectTransform highlightRect { get; /* RVA: 0x09ACDD68 */ }
        System.Single scale { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x09ACDE18 */ }
        System.Single alpha { get; /* RVA: 0x03D4F670 */ set; /* RVA: 0x09ACDE00 */ }
        UnityEngine.Vector2 position { get; /* RVA: 0x03D72FD0 */ set; /* RVA: 0x09ACDE0C */ }
        Beyond.UI.UICustomLayoutElement.LayoutType layoutType { get; /* RVA: 0x03D4F050 */ set; /* RVA: 0x03D4F5A0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x027FCBB0 */ }

        // Methods
        // RVA: 0x027FC130  token: 0x6000432
        protected virtual System.Void Awake() { }
        // RVA: 0x03A21200  token: 0x6000433
        protected virtual System.Void Start() { }
        // RVA: 0x09ACD5C0  token: 0x6000434
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09ACD748  token: 0x6000435
        public System.Void ResetToDefault() { }
        // RVA: 0x09ACDAD4  token: 0x6000436
        private System.Void _ApplyPosition() { }
        // RVA: 0x09ACD9F0  token: 0x6000437
        private System.Void _ApplyAlpha() { }
        // RVA: 0x09ACDB40  token: 0x6000438
        private System.Void _ApplyScale() { }
        // RVA: 0x027FC260  token: 0x6000439
        private System.Void _SetDefaultValues() { }
        // RVA: 0x09ACD294  token: 0x600043A
        public System.String GetElementKeyWithRatio(System.Int32 ratio) { }
        // RVA: 0x09ACDC14  token: 0x600043B
        private System.Boolean _CheckElementKeyIsValid() { }
        // RVA: 0x09ACD810  token: 0x600043C
        public System.Boolean SaveData(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Boolean isResetToDefault, System.Int32 ratio) { }
        // RVA: 0x09ACD370  token: 0x600043D
        public System.Void LoadData() { }
        // RVA: 0x09ACDD18  token: 0x600043E
        private System.Void _OnHudLayoutSaved() { }
        // RVA: 0x027FCA90  token: 0x600043F
        private UnityEngine.Vector2 _GetMarginSize() { }
        // RVA: 0x09ACD23C  token: 0x6000440
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09ACD6B4  token: 0x6000441
        public static System.Void RefreshAll() { }
        // RVA: 0x02849790  token: 0x6000442
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000443
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x6000444
        public System.Void <>iFixBaseProxy_Start() { }
        // RVA: 0x0350B670  token: 0x6000445
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200008C  // size: 0xB8
    public class UICustomLayoutHandle : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public Beyond.DisposedUnityEvent onClick;  // 0x18
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;  // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0x28
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;  // 0x30
        public System.String hintTextId;  // 0x38
        private Beyond.UI.LuaPanel m_panel;  // 0x40
        private System.Single m_scale;  // 0x48
        private System.Single m_alpha;  // 0x4c
        private UnityEngine.Vector2 m_position;  // 0x50
        private Beyond.UI.UICustomLayoutElement.LayoutType m_layoutType;  // 0x58
        private UnityEngine.Vector2 m_defaultPosition;  // 0x5c
        private System.Boolean m_isChanged;  // 0x64
        private System.Boolean m_isResetToDefault;  // 0x65
        private UnityEngine.RectTransform m_rectTransform;  // 0x68
        private UnityEngine.RectTransform m_parentRectTransform;  // 0x70
        private Beyond.UI.UICustomLayoutElement m_element;  // 0x78
        private Beyond.UI.UICustomLayout m_layout;  // 0x80
        private UnityEngine.Vector2 m_dragPosMin;  // 0x88
        private UnityEngine.Vector2 m_dragPosMax;  // 0x90
        private UnityEngine.Vector3[] m_dragAreaCorners;  // 0x98
        private UnityEngine.Vector3[] m_highlightCorners;  // 0xa0
        private System.Boolean m_isPosRangeDirty;  // 0xa8
        private UnityEngine.Vector2 m_dragOffset;  // 0xac

        // Properties
        System.Single scale { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x09ACF3B4 */ }
        System.Single alpha { get; /* RVA: 0x03D50200 */ set; /* RVA: 0x09ACF1D0 */ }
        UnityEngine.Vector2 position { get; /* RVA: 0x03D76080 */ set; /* RVA: 0x09ACF2D4 */ }
        Beyond.UI.UICustomLayoutElement.LayoutType layoutType { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x09ACF244 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09ACF118 */ }
        Beyond.UI.UICustomLayoutElement Element { get; /* RVA: 0x09ACF064 */ }

        // Methods
        // RVA: 0x09ACDE24  token: 0x6000451
        protected virtual System.Void Awake() { }
        // RVA: 0x09ACE288  token: 0x6000452
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09ACED28  token: 0x6000453
        private System.Void _OnElementDataLoaded() { }
        // RVA: 0x09ACE98C  token: 0x6000454
        private System.Void _CalculatePositionRange() { }
        // RVA: 0x09ACE8A8  token: 0x6000455
        private System.Void _ApplyPosition() { }
        // RVA: 0x09ACE7DC  token: 0x6000456
        private System.Void _ApplyAlpha() { }
        // RVA: 0x09ACE91C  token: 0x6000457
        private System.Void _ApplyScale() { }
        // RVA: 0x09ACE844  token: 0x6000458
        private System.Void _ApplyLayoutType() { }
        // RVA: 0x09ACE130  token: 0x6000459
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ACE3EC  token: 0x600045A
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ACE538  token: 0x600045B
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ACE70C  token: 0x600045C
        public System.Boolean Save(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Int32 ratio) { }
        // RVA: 0x09ACE62C  token: 0x600045D
        public System.Void ResetToDefault() { }
        // RVA: 0x09ACE0E4  token: 0x600045E
        public System.Boolean IsDirty() { }
        // RVA: 0x09ACEE24  token: 0x600045F
        private System.Void _SetChanged(System.Boolean changed) { }
        // RVA: 0x09ACE5C4  token: 0x6000460
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ACEDD4  token: 0x6000461
        private System.Void _OnSystemDisplaySizeChanged() { }
        // RVA: 0x09ACE030  token: 0x6000462
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09ACEED4  token: 0x6000463
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000464
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x6000465
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200008D  // size: 0xE8
    public class UIDialogText : Beyond.TickableUIMono
    {
        // Fields
        protected Beyond.UI.UIText _uiText;  // 0x68
        private System.Single _textRevealSpeed;  // 0x70
        private System.Boolean _autoPlay;  // 0x74
        private Beyond.UI.UIDialogText.UpdateMode _updateMode;  // 0x78
        private System.Boolean _useAutoScroll;  // 0x7c
        private System.Single _originalHeight;  // 0x80
        private System.Boolean _useAspectRatio;  // 0x84
        private System.Single _autoScrollSpeed;  // 0x88
        private System.Single _autoWaitTime;  // 0x8c
        private System.Single _maxAspectRatio;  // 0x90
        private System.Single _minAspectRatio;  // 0x94
        private System.Single _maxAspectRatioScrollSpeed;  // 0x98
        private System.Single _minAspectRatioScrollSpeed;  // 0x9c
        private System.Single _maxAspectRatioWaitTime;  // 0xa0
        private System.Single _minAspectRatioWaitTime;  // 0xa4
        private System.Boolean m_playing;  // 0xa8
        private System.Int32 m_revealedCharNum;  // 0xac
        private System.Int32 m_totalCharNum;  // 0xb0
        private System.Single m_timeToNextCharacter;  // 0xb4
        protected System.String m_curText;  // 0xb8
        private System.Boolean m_hasScrolled;  // 0xc0
        private System.Single m_startTime;  // 0xc4
        private System.Boolean m_scrollHasEnd;  // 0xc8
        private System.Boolean m_needAutoScroll;  // 0xc9
        private UnityEngine.Vector2 m_targetPos;  // 0xcc
        private UnityEngine.Vector2 m_originalPos;  // 0xd4
        private System.Single m_percent;  // 0xdc
        private System.Boolean m_locked;  // 0xe0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean useAspectRatio { get; /* RVA: 0x09AD0D48 */ }
        System.Boolean notUseAspectRatio { get; /* RVA: 0x09AD0CC4 */ }
        System.Boolean playing { get; /* RVA: 0x09AD0CD8 */ }
        Beyond.UI.UIText uiText { get; /* RVA: 0x03D4EAB0 */ }
        System.Int32 totalCharacterNum { get; /* RVA: 0x03D59C80 */ }
        System.Single textRevealSpeed { get; /* RVA: 0x03D56C00 */ set; /* RVA: 0x03D5BD20 */ }

        // Methods
        // RVA: 0x03D2AB30  token: 0x600046E
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0398ECD0  token: 0x600046F
        protected System.Void Start() { }
        // RVA: 0x09AD0AD0  token: 0x6000470
        protected virtual System.Void OnDisable() { }
        // RVA: 0x03CF4E80  token: 0x6000471
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02A35AA0  token: 0x6000472
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD0B28  token: 0x6000473
        protected virtual System.Void OnVisibleCharactersChanged(System.Int32 count) { }
        // RVA: 0x09AD06B0  token: 0x6000474
        protected System.Single GetScrollSpeed() { }
        // RVA: 0x09AD051C  token: 0x6000475
        protected System.Single GetAutoWaitTime() { }
        // RVA: 0x02A35B00  token: 0x6000476
        private System.Void _UpdateTextAuto() { }
        // RVA: 0x02A35C10  token: 0x6000477
        private System.Void _TryAutoScroll() { }
        // RVA: 0x0398EED0  token: 0x6000478
        public System.Void RefreshAutoScrollData() { }
        // RVA: 0x0398EDF0  token: 0x6000479
        public System.Void SetText(System.String text, System.Boolean resetPlay) { }
        // RVA: 0x09AD0C18  token: 0x600047A
        private System.Void _RefreshPosY() { }
        // RVA: 0x09AD0B7C  token: 0x600047B
        public System.Void SeekToEnd() { }
        // RVA: 0x03CF4EC0  token: 0x600047C
        public System.Void RefreshText() { }
        // RVA: 0x0398ED80  token: 0x600047D
        public System.Void Play() { }
        // RVA: 0x03B3CDB0  token: 0x600047E
        public virtual System.Void ResetPlay() { }
        // RVA: 0x02A35C80  token: 0x600047F
        public System.Void StopPlay() { }
        // RVA: 0x09AD0794  token: 0x6000480
        public System.Void ManualUpdateByPercent(System.Single percent) { }
        // RVA: 0x09AD08E0  token: 0x6000481
        public System.Void ManualUpdateByTime(System.Single time) { }
        // RVA: 0x09AD0600  token: 0x6000482
        public virtual System.Single GetDisplayAllCharactersTime() { }
        // RVA: 0x03A20AC0  token: 0x6000483
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000484
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8A4  token: 0x6000485
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x058DD8AC  token: 0x6000486
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x6000487
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x200008F  // size: 0x118
    public class UIDialogTextWithCursor : Beyond.UI.UIDialogText
    {
        // Fields
        private System.Single _textGapTime;  // 0xe8
        private Beyond.UI.UIAnimationWrapper _cursorAnimation;  // 0xf0
        private UnityEngine.RectTransform _cursorLoopHide;  // 0xf8
        private UnityEngine.RectTransform _cursorGroup;  // 0x100
        private Beyond.UI.UIImage _background;  // 0x108
        public System.Boolean isLastTextLine;  // 0x110
        private System.Int32 m_lastCount;  // 0x114

        // Methods
        // RVA: 0x09AD0490  token: 0x6000488
        public virtual System.Void ResetPlay() { }
        // RVA: 0x09AD016C  token: 0x6000489
        protected virtual System.Void OnVisibleCharactersChanged(System.Int32 count) { }
        // RVA: 0x09AD0110  token: 0x600048A
        public virtual System.Single GetDisplayAllCharactersTime() { }
        // RVA: 0x09AD0500  token: 0x600048B
        public System.Void .ctor() { }
        // RVA: 0x09AD04F8  token: 0x600048C
        public System.Void <>iFixBaseProxy_ResetPlay() { }
        // RVA: 0x09AD04F0  token: 0x600048D
        public System.Void <>iFixBaseProxy_OnVisibleCharactersChanged(System.Int32 P0) { }
        // RVA: 0x09AD04E8  token: 0x600048E
        public System.Single <>iFixBaseProxy_GetDisplayAllCharactersTime() { }

    }

    // TypeToken: 0x2000090  // size: 0x28
    public class EasyUIOptionData
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.String optionIcon;  // 0x18
        public System.String optionText;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600048F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000091  // size: 0x28
    public class UIDialogTimelineOptionCell : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIImage _optionIcon;  // 0x18
        private Beyond.UI.UIText _optionText;  // 0x20

        // Methods
        // RVA: 0x0426FE60  token: 0x6000490
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000092  // size: 0x60
    public class UIDialogTimelineText : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIDialogText _dialogText;  // 0x18
        private Beyond.UI.UIText _actorName;  // 0x20
        private UnityEngine.GameObject _waitNode;  // 0x28
        private Beyond.UI.UIAnimationWrapper _radioNode;  // 0x30
        private Beyond.UI.UIImage _iconImage;  // 0x38
        private Beyond.UI.UIImage _iconBlueMask;  // 0x40
        public Beyond.UI.UIText centerText;  // 0x48
        private System.String m_currentRadioIcon;  // 0x50
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x58

        // Properties
        UnityEngine.CanvasGroup canvasGroup { get; /* RVA: 0x09AD10A0 */ }
        Beyond.UI.UIDialogText dialogText { get; /* RVA: 0x01041090 */ }
        Beyond.UI.UIText actorName { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.GameObject waitNode { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x09AD0ED4  token: 0x6000495
        public System.Void UpdateAlpha(System.Single alpha) { }
        // RVA: 0x09AD0D5C  token: 0x6000496
        public System.Void SetRadioIcon(System.Boolean useRadio, System.String radioIcon) { }
        // RVA: 0x09AD0F94  token: 0x6000497
        private System.Void _ClearRadioIcon() { }
        // RVA: 0x0426FE60  token: 0x6000498
        public System.Void .ctor() { }
        // RVA: 0x09AD0E90  token: 0x6000499
        private System.Void <_ClearRadioIcon>b__19_0() { }

    }

    // TypeToken: 0x2000093  // size: 0x70
    public class UIDrag : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.RectTransform _dragArea;  // 0x18
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;  // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;  // 0x28
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0x30
        private UnityEngine.RectTransform m_rectTransform;  // 0x38
        private UnityEngine.RectTransform m_parentRectTransform;  // 0x40
        private UnityEngine.Vector2 m_dragOffset;  // 0x48
        private UnityEngine.Vector2 m_dragPosMin;  // 0x50
        private UnityEngine.Vector2 m_dragPosMax;  // 0x58
        private UnityEngine.Vector3[] m_dragAreaCorners;  // 0x60
        private UnityEngine.Canvas m_canvas;  // 0x68

        // Methods
        // RVA: 0x09AD26C4  token: 0x600049A
        protected virtual System.Void Awake() { }
        // RVA: 0x09AD2CFC  token: 0x600049B
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD2860  token: 0x600049C
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD2F00  token: 0x600049D
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD2284  token: 0x600049E
        public System.Void ApplyDragArea() { }
        // RVA: 0x09AD27BC  token: 0x600049F
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AD2F8C  token: 0x60004A0
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60004A1
        public System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x2000094  // size: 0x50
    public class UIDragHandler : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Int32 _dragThreshold;  // 0x18
        private UnityEngine.Vector2 m_startPressPos;  // 0x1c
        private System.Boolean m_isDragThresholdMet;  // 0x24
        private System.Boolean m_isDragging;  // 0x25
        public Beyond.UI.UIButton button;  // 0x28
        public System.Boolean ignoreDragOnLongPress;  // 0x30
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;  // 0x38
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0x40
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;  // 0x48

        // Properties
        System.Int32 dragThreshold { get; /* RVA: 0x09AD14D8 */ }

        // Methods
        // RVA: 0x09AD1130  token: 0x60004A3
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AD1464  token: 0x60004A4
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD11D4  token: 0x60004A5
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD1268  token: 0x60004A6
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD13D0  token: 0x60004A7
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x028472A0  token: 0x60004A8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000095  // size: 0xC8
    public class UIDragItem : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public static UnityEngine.RectTransform s_commonDragObjectParent;  // static @ 0x0
        private XLua.LuaTable <luaTable>k__BackingField;  // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDragEvent;  // 0x20
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDragEvent;  // 0x28
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDragEventWhenCantStartDrag;  // 0x30
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDragEvent;  // 0x38
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,UnityEngine.GameObject> onUpdateDragObject;  // 0x40
        public System.Boolean canStartDrag;  // 0x48
        private System.Boolean _endDragOnDisable;  // 0x49
        public System.Boolean disableDrag;  // 0x4a
        private System.Boolean _isInScrollList;  // 0x4b
        private System.Boolean _hideDragObjectInScrollList;  // 0x4c
        private UnityEngine.GameObject _dragPrefab;  // 0x50
        private UnityEngine.RectTransform _dragObjectParent;  // 0x58
        public UnityEngine.Vector2 dragPivot;  // 0x60
        private UnityEngine.UI.Image _draggingHintImage;  // 0x68
        private UnityEngine.CanvasGroup _draggingHintCanvasGroup;  // 0x70
        private UnityEngine.GameObject _draggingHintObject;  // 0x78
        private Beyond.UI.LuaPanel m_panel;  // 0x80
        private UnityEngine.RectTransform m_rect;  // 0x88
        private Beyond.UI.UIScrollRect m_scrollRect;  // 0x90
        private System.Boolean m_isInScroll;  // 0x98
        private UnityEngine.GameObject m_curDragObj;  // 0xa0
        private System.Boolean m_inDragging;  // 0xa8
        private UnityEngine.Color m_draggingHintImageOriColor;  // 0xac
        private UnityEngine.Coroutine m_dragOnDisableCoroutine;  // 0xc0

        // Properties
        XLua.LuaTable luaTable { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean inDragging { get; /* RVA: 0x011B9C10 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AD21C0 */ }
        UnityEngine.RectTransform m_dragParentRect { get; /* RVA: 0x09AD2110 */ }
        UnityEngine.GameObject curDragObj { get; /* RVA: 0x03D4EA80 */ }

        // Methods
        // RVA: 0x0388F250  token: 0x60004AF
        protected virtual System.Void Awake() { }
        // RVA: 0x037B10F0  token: 0x60004B0
        protected virtual System.Void Start() { }
        // RVA: 0x036EE670  token: 0x60004B1
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AD1ED8  token: 0x60004B2
        private System.Collections.IEnumerator _ContinueDragOnDisable() { }
        // RVA: 0x09AD1B20  token: 0x60004B3
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0388DA70  token: 0x60004B4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD15C0  token: 0x60004B5
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD1B80  token: 0x60004B6
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x036EE6E0  token: 0x60004B7
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD1F68  token: 0x60004B8
        private System.Void _StopDragView() { }
        // RVA: 0x09AD1520  token: 0x60004B9
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02C712E0  token: 0x60004BA
        public System.Void ClearEvents() { }
        // RVA: 0x02848DD0  token: 0x60004BB
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60004BC
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x60004BD
        public System.Void <>iFixBaseProxy_Start() { }
        // RVA: 0x0350B670  token: 0x60004BE
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0350B670  token: 0x60004BF
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x0350B670  token: 0x60004C0
        public System.Void <>iFixBaseProxy_OnEnable() { }

    }

    // TypeToken: 0x2000097  // size: 0x288
    public class UIDropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, Beyond.Input.IBindingGroupTarget, Beyond.Input.IBindingView
    {
        // Fields
        public UnityEngine.Events.UnityEvent<System.Int32> onSelectCell;  // 0x180
        public UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell;  // 0x188
        public UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption;  // 0x190
        public UnityEngine.Events.UnityEvent<System.Boolean> onToggleOptList;  // 0x198
        public System.Func<System.Int32,System.Int32,System.Boolean> onValidateSelectCell;  // 0x1a0
        public Beyond.UI.UIText captionText;  // 0x1a8
        public Beyond.UI.UIImage captionIcon;  // 0x1b0
        private System.Int32 <selectedIndex>k__BackingField;  // 0x1b8
        private System.Int32 <optionCount>k__BackingField;  // 0x1bc
        private System.Boolean <isListActive>k__BackingField;  // 0x1c0
        private Beyond.UI.UIDropdownOption _optionTemplate;  // 0x1c8
        private UnityEngine.Transform _arrowImageTrans;  // 0x1d0
        private UnityEngine.RectTransform _listContainer;  // 0x1d8
        private System.Single _listContainerMaxHeight;  // 0x1e0
        private System.Single _animationTime;  // 0x1e4
        private UnityEngine.RectTransform _selfArea;  // 0x1e8
        private UnityEngine.RectTransform _maskRect;  // 0x1f0
        private System.Boolean _autoCloseOnSelect;  // 0x1f8
        private System.String _audioToggleOn;  // 0x200
        private System.String _audioToggleOff;  // 0x208
        private System.String _audioInvalid;  // 0x210
        private System.String _audioNavigation;  // 0x218
        private System.Collections.Generic.List<Beyond.UI.UIDropdownOption> m_options;  // 0x220
        private Beyond.UI.LuaPanel m_panel;  // 0x228
        private UnityEngine.UI.LayoutGroup m_content;  // 0x230
        private UnityEngine.Camera m_fallbackUICamera;  // 0x238
        private Beyond.UI.UIScrollRect m_listScrollRect;  // 0x240
        private UnityEngine.CanvasGroup m_listContainerCanvasGroup;  // 0x248
        public System.String openDropDownActionId;  // 0x250
        public System.String openDropDownBindingTextId;  // 0x258
        private System.Int32 m_bindingGroupId;  // 0x260
        private System.Int32 m_naviBindingGroupId;  // 0x264
        private Beyond.UI.LuaPanel m_luaPanel;  // 0x268
        private Beyond.UI.UISelectableNaviGroup m_listNaviGroup;  // 0x270
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0x278
        private readonly Beyond.DisposedUnityEvent <bindingViewUpdateEvent>k__BackingField;  // 0x280

        // Properties
        System.Int32 selectedIndex { get; /* RVA: 0x03D58520 */ set; /* RVA: 0x03D58620 */ }
        System.Int32 optionCount { get; /* RVA: 0x03D58580 */ set; /* RVA: 0x03D58630 */ }
        System.Boolean isListActive { get; /* RVA: 0x03D57BF0 */ set; /* RVA: 0x03D760A0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x0284ECA0 */ }
        System.Int32 groupId { get; /* RVA: 0x03D5ADD0 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D57270 */ set; /* RVA: 0x058B3EC0 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x09AD36D0 */ }
        System.String bindingViewActionId { get; /* RVA: 0x03D57350 */ }
        System.String bindingViewLabelText { get; /* RVA: 0x09AD3554 */ }
        Beyond.DisposedUnityEvent bindingViewUpdateEvent { get; /* RVA: 0x03D573B0 */ }
        UnityEngine.RectTransform redDotTrans { get; /* RVA: 0x01002730 */ }
        System.Boolean bindingEnabled { get; /* RVA: 0x09AD354C */ }
        Beyond.Input.BindingViewState bindingViewState { get; /* RVA: 0x09AD35EC */ }

        // Methods
        // RVA: 0x02A71E60  token: 0x60004CE
        protected virtual System.Void Awake() { }
        // RVA: 0x03989990  token: 0x60004CF
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x02D99F90  token: 0x60004D0
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03C9B180  token: 0x60004D1
        public System.Void Init(UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell, UnityEngine.Events.UnityAction<System.Int32> onSelectCell, UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption) { }
        // RVA: 0x02D9A040  token: 0x60004D2
        public System.Void ToggleOptions(System.Boolean activeList) { }
        // RVA: 0x02D9A090  token: 0x60004D3
        private System.Void _ToggleOptions(System.Boolean activeList, System.Boolean isInit) { }
        // RVA: 0x0284F410  token: 0x60004D4
        private System.Void Update() { }
        // RVA: 0x02D9A5A0  token: 0x60004D5
        public System.Void SetSelected(System.Int32 index, System.Boolean forceUpdate, System.Boolean needNotifySelect, System.Boolean validateSelect) { }
        // RVA: 0x09AD3250  token: 0x60004D6
        public System.Void ScrollToSelected() { }
        // RVA: 0x0270F0C0  token: 0x60004D7
        public System.Void Refresh(System.Int32 count, System.Int32 newSelectedIndex, System.Boolean needNotifySelect) { }
        // RVA: 0x03A46E40  token: 0x60004D8
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0284EB10  token: 0x60004D9
        private UnityEngine.Camera _GetUICamera() { }
        // RVA: 0x09AD3194  token: 0x60004E4
        public virtual System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        // RVA: 0x09AD309C  token: 0x60004E5
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger) { }
        // RVA: 0x09AD30F0  token: 0x60004E6
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger) { }
        // RVA: 0x02A73B40  token: 0x60004E7
        private System.Void _InitBinding() { }
        // RVA: 0x09AD33F8  token: 0x60004E8
        private System.Void _ControllerToggle() { }
        // RVA: 0x09AD338C  token: 0x60004E9
        private System.Void _ControllerCancel() { }
        // RVA: 0x09AD3470  token: 0x60004EA
        private UnityEngine.UI.Selectable _GetDefaultNaviTarget() { }
        // RVA: 0x03B38150  token: 0x60004EB
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03B381E0  token: 0x60004EC
        protected virtual System.Void OnDisable() { }
        // RVA: 0x03A46DA0  token: 0x60004ED
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0284A270  token: 0x60004EE
        public System.Void .ctor() { }
        // RVA: 0x09AD3144  token: 0x60004EF
        private virtual System.Boolean Beyond.Input.IBindingView.get_interactable() { }
        // RVA: 0x09AAE8DC  token: 0x60004F0
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09ACB974  token: 0x60004F1
        public System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        // RVA: 0x09AAE8EC  token: 0x60004F2
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0361D5F0  token: 0x60004F3
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AAE8E4  token: 0x60004F4
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200009A  // size: 0x60
    public class UIDropdownOption : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIButton button;  // 0x18
        public Beyond.UI.UIText label;  // 0x20
        public Beyond.UI.UIText secondLabel;  // 0x28
        public Beyond.UI.UIImage icon;  // 0x30
        public UnityEngine.GameObject selectedNode;  // 0x38
        public UnityEngine.GameObject notSelectedNode;  // 0x40
        public Beyond.UI.UIState.UIStateController stateController;  // 0x48
        public UnityEngine.GameObject stripeNode;  // 0x50
        public System.Boolean stripeIsTop;  // 0x58

        // Methods
        // RVA: 0x028E1380  token: 0x60004F9
        public System.Void SetText(System.String text) { }
        // RVA: 0x09AD4F6C  token: 0x60004FA
        public System.Void SetState(System.String stateName) { }
        // RVA: 0x02813CB0  token: 0x60004FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009B  // size: 0x14
    public sealed struct CommonDropHintType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CommonDropHintType None;  // const
        public static Beyond.UI.CommonDropHintType Square;  // const
        public static Beyond.UI.CommonDropHintType Circle;  // const

    }

    // TypeToken: 0x200009C  // size: 0x80
    public class UIDropItem : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private XLua.LuaTable <luaTable>k__BackingField;  // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDropEvent;  // 0x20
        public UnityEngine.Events.UnityEvent<System.Boolean> onToggleHighlight;  // 0x28
        public System.Action onDestroy;  // 0x30
        public Beyond.UI.CommonDropHintType commonDropHintType;  // 0x38
        private UnityEngine.GameObject _highlightHint;  // 0x40
        private System.Boolean _scaleWhenHighlight;  // 0x48
        private System.Single _scaleWhenActive;  // 0x4c
        private System.Boolean _useUIState;  // 0x50
        private Beyond.UI.UIStyleByState.StateConfig _stateConfigNormal;  // 0x58
        private Beyond.UI.UIStyleByState.StateConfig _stateConfigHilight;  // 0x60
        private UnityEngine.UI.Selectable m_selectable;  // 0x68
        private UnityEngine.RectTransform m_rectTransform;  // 0x70
        private System.Single m_oriScale;  // 0x78
        private System.Boolean m_isInHighlight;  // 0x7c

        // Properties
        XLua.LuaTable luaTable { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x02C71290  token: 0x60004FE
        public System.Void ClearEvents() { }
        // RVA: 0x037E73A0  token: 0x60004FF
        protected virtual System.Void Awake() { }
        // RVA: 0x0364BBF0  token: 0x6000500
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0364BBB0  token: 0x6000501
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AD4DB0  token: 0x6000502
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0364BC50  token: 0x6000503
        public System.Void ToggleHighlight(System.Boolean active, System.Boolean forceToggle) { }
        // RVA: 0x09AD4E50  token: 0x6000504
        public virtual System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD4D18  token: 0x6000505
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02848CA0  token: 0x6000506
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000507
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x6000508
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0350B670  token: 0x6000509
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0350B670  token: 0x600050A
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200009D  // size: 0xD0
    public class UIElementFollower : Beyond.TickableUIMono
    {
        // Fields
        private System.Boolean _followMouse;  // 0x68
        public System.Boolean followFixedPos;  // 0x69
        private UnityEngine.Transform _targetTransform;  // 0x70
        private UnityEngine.Vector3 _followPosition;  // 0x78
        private System.Boolean _changeScale;  // 0x84
        private UnityEngine.AnimationCurve _scaleCurve;  // 0x88
        public UnityEngine.Vector3 displayOffset;  // 0x90
        public UnityEngine.Vector3 displayUIOffset;  // 0x9c
        private static readonly Unity.Profiling.ProfilerMarker UPDATE_POSITION_MARKER;  // static @ 0x0
        public Beyond.DisposedUnityEvent onExitScreen;  // 0xa8
        public Beyond.DisposedUnityEvent onEnterScreen;  // 0xb0
        private System.Boolean <inScreen>k__BackingField;  // 0xb8
        private Beyond.UI.LuaPanel m_panel;  // 0xc0
        private UnityEngine.RectTransform m_rectTransform;  // 0xc8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.Vector3 followPosition { get; /* RVA: 0x03D5E3C0 */ set; /* RVA: 0x0398F430 */ }
        UnityEngine.Transform targetTransform { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x09AD5020 */ }
        System.Boolean inScreen { get; /* RVA: 0x03D51F80 */ set; /* RVA: 0x03D51FD0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x028AEF10 */ }

        // Methods
        // RVA: 0x037B3D10  token: 0x6000513
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03700750  token: 0x6000514
        protected virtual System.Void OnEnable() { }
        // RVA: 0x028AE9D0  token: 0x6000515
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x028AEA10  token: 0x6000516
        public System.Void UpdatePosition() { }
        // RVA: 0x028AEC00  token: 0x6000517
        public System.Void UpdatePosition(UnityEngine.Vector3 worldPos) { }
        // RVA: 0x02847EA0  token: 0x6000518
        public System.Void .ctor() { }
        // RVA: 0x03D06B30  token: 0x6000519
        private static System.Void .cctor() { }
        // RVA: 0x058E2A30  token: 0x600051A
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x600051B
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x600051C
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200009E  // size: 0x30
    public class UIExtendScrollRect : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        // Fields
        public Beyond.UI.UIScrollRect baseScrollRect;  // 0x18
        private System.Boolean _enableDrag;  // 0x20
        private Beyond.UI.UIScrollList _extendScrollList;  // 0x28

        // Methods
        // RVA: 0x09AD5308  token: 0x600051D
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD5044  token: 0x600051E
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD5130  token: 0x600051F
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AD521C  token: 0x6000520
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0426FE60  token: 0x6000521
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009F
    public interface IUIFoldoutComp
    {
        // Properties
        System.Boolean defaultFoldOut { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000523
        public virtual System.Void Refresh(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x6000524
        public virtual System.Void OnFoldOut(System.Boolean fastMode) { }
        // RVA: -1  // abstract  token: 0x6000525
        public virtual System.Void OnFoldIn(System.Boolean fastMode) { }

    }

    // TypeToken: 0x20000A0  // size: 0x48
    public class UIFoldoutComponent : UnityEngine.MonoBehaviour, Beyond.UI.IUIFoldoutComp
    {
        // Fields
        protected UnityEngine.GameObject _foldContent;  // 0x18
        protected Beyond.UI.UINonUnifiedScrollList _nonUnifiedScrollList;  // 0x20
        public System.Single foldInSize;  // 0x28
        public System.Single duration;  // 0x2c
        public DG.Tweening.Ease easeType;  // 0x30
        protected System.Boolean m_isFoldOut;  // 0x34
        private DG.Tweening.Tweener m_tween;  // 0x38
        protected System.Int32 m_index;  // 0x40

        // Properties
        System.Boolean defaultFoldOut { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: 0x09AD5988  token: 0x6000526
        public virtual System.Void Refresh(System.Int32 index) { }
        // RVA: 0x09AD56D0  token: 0x6000528
        public virtual System.Void OnFoldOut(System.Boolean fastMode) { }
        // RVA: 0x09AD5420  token: 0x6000529
        public virtual System.Void OnFoldIn(System.Boolean fastMode) { }
        // RVA: 0x09AD53B4  token: 0x600052A
        private System.Void OnDestroy() { }
        // RVA: 0x09AD5A04  token: 0x600052B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3  // size: 0x90
    public class UIGraphicAnimation : Beyond.TickableUIMono
    {
        // Fields
        private static System.Int32 s_vfxMainTextSTId;  // static @ 0x0
        private static System.Int32 s_tintColorAlpha;  // static @ 0x4
        private UnityEngine.UI.MaskableGraphic _graphic;  // 0x68
        private UnityEngine.Material _material;  // 0x70
        private System.Single _alpha;  // 0x78
        private UnityEngine.Vector2 _scale;  // 0x7c
        private UnityEngine.Material m_materialInstance;  // 0x88

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.Material MaterialInstance { get; /* RVA: 0x03D4EA60 */ }

        // Methods
        // RVA: 0x02E80910  token: 0x6000534
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AD5A24  token: 0x6000535
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02802DD0  token: 0x6000536
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02E80950  token: 0x6000537
        private System.Void _Init() { }
        // RVA: 0x02845FF0  token: 0x6000538
        public System.Void .ctor() { }
        // RVA: 0x03CF2060  token: 0x6000539
        private static System.Void .cctor() { }
        // RVA: 0x058E2A30  token: 0x600053A
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7B4  token: 0x600053B
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0589E548  token: 0x600053C
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000A4  // size: 0x78
    public class UIGridLayoutGroup : UnityEngine.UI.GridLayoutGroup
    {
        // Methods
        // RVA: 0x09AD5B44  token: 0x600053D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A5  // size: 0x58
    public class UIGridLayoutNaviWrapper : UnityEngine.EventSystems.UIBehaviour, IScrollListNaviWrapper
    {
        // Fields
        private UnityEngine.UI.GridLayoutGroup _gridLayoutGroup;  // 0x18
        private UnityEngine.UI.LayoutGroup _layoutGroup;  // 0x20
        private Beyond.UI.UIGridLayoutNaviWrapper.WrapMode _wrapMode;  // 0x28
        private Beyond.UI.UIScrollRect _scrollRect;  // 0x30
        private Beyond.UI.UISelectableNaviGroup _naviGroup;  // 0x38
        private System.Boolean _enableCircleWrapNavigation;  // 0x40
        private System.Boolean m_isInited;  // 0x41
        private System.Boolean m_isVertical;  // 0x42
        private UnityEngine.UI.LayoutGroup m_layoutGroup;  // 0x48
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;  // 0x50

        // Methods
        // RVA: 0x02D99B50  token: 0x600053E
        private System.Void _InitIfNot() { }
        // RVA: 0x02D99C20  token: 0x600053F
        protected virtual System.Void Start() { }
        // RVA: 0x09AD5B4C  token: 0x6000540
        public virtual System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x02D99D40  token: 0x6000541
        private System.Void _InitWrapNavigation() { }
        // RVA: 0x09AD635C  token: 0x6000542
        private System.Void _NaviGridLayout(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AD5FA0  token: 0x6000543
        private System.Boolean _NaviGridLayoutImpl(UnityEngine.UI.NaviDirection dir, System.Boolean enableCircleWrapNavigation) { }
        // RVA: 0x09AD622C  token: 0x6000544
        private System.Boolean _NaviGridLayoutInit(System.Boolean isBefore, System.Boolean enableCircleWrapNavigation) { }
        // RVA: 0x09AD5D18  token: 0x6000545
        private System.Boolean _NaviChildren(System.Int32 curIndex, System.Int32 childCount, System.Boolean isBefore, System.Boolean enableCircleWrapNavigation) { }
        // RVA: 0x09AD5BB0  token: 0x6000546
        private UnityEngine.UI.Selectable _FindValidSelectable(System.Boolean isBefore) { }
        // RVA: 0x09AD63C4  token: 0x6000547
        private System.Void _SetCircleWrapScroll(System.Boolean isBefore) { }
        // RVA: 0x03CFEDB0  token: 0x6000548
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000549
        public System.Void <>iFixBaseProxy_Start() { }

    }

    // TypeToken: 0x20000A7  // size: 0xE0
    public class UIGyroscopeEffect : Beyond.TickableUIMono
    {
        // Fields
        public System.Boolean enableDetect;  // 0x68
        public System.Single mobileGravityScaler;  // 0x6c
        public System.Single controllerGravityScaler;  // 0x70
        public System.Single controllerAccSmoothFactor;  // 0x74
        public Beyond.UI.UIGyroscopeEffect.Param x;  // 0x78
        public Beyond.UI.UIGyroscopeEffect.Param y;  // 0x80
        public DG.Tweening.Ease ease;  // 0x88
        public System.Single time;  // 0x8c
        private UnityEngine.Vector3 m_lastValue;  // 0x90
        private Cinemachine.CinemachineVirtualCamera m_vcam;  // 0xa0
        private Beyond.UI.CinemachineGyroscopeEffect m_vcamGyroscopeEffect;  // 0xa8
        private System.Boolean m_isVcamMode;  // 0xb0
        private System.Single m_baseGravityY;  // 0xb4
        private System.Single m_baseGravityYAccumulatedTime;  // 0xb8
        private System.Single m_lastGravityY;  // 0xbc
        private UnityEngine.Vector3 m_smoothedControllerAccValue;  // 0xc0
        public DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> handler;  // 0xd0
        public DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> tween;  // 0xd8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x03C8AEC0  token: 0x600054B
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0284EE00  token: 0x600054C
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD64C4  token: 0x600054D
        protected virtual System.Void OnRelease() { }
        // RVA: 0x03988FA0  token: 0x600054E
        public System.Void .ctor() { }
        // RVA: 0x09AD656C  token: 0x600054F
        private UnityEngine.Vector3 <Tick>b__22_0() { }
        // RVA: 0x09AD65A0  token: 0x6000550
        private System.Void <Tick>b__22_1(UnityEngine.Vector3 value) { }
        // RVA: 0x058E2A30  token: 0x6000551
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x6000552
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x6000553
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000A9  // size: 0x98
    public class UIHighlightMask : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.RectTransform _up;  // 0x68
        private UnityEngine.RectTransform _down;  // 0x70
        private UnityEngine.RectTransform _left;  // 0x78
        private UnityEngine.RectTransform _right;  // 0x80
        private UnityEngine.RectTransform m_rect;  // 0x88
        private Beyond.UI.LuaPanel m_panel;  // 0x90

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AD6A60 */ }

        // Methods
        // RVA: 0x09AD65C8  token: 0x6000557
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AD6658  token: 0x6000558
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD66B4  token: 0x6000559
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD6714  token: 0x600055A
        public System.Void TrySyncRect() { }
        // RVA: 0x02846010  token: 0x600055B
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x600055C
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x600055D
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x600055E
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AA  // size: 0x228
    public class UIImage : UnityEngine.UI.Image
    {
        // Fields
        private System.Int32 _atlasHandleId;  // 0x190
        private System.Collections.Generic.List<Beyond.UI.UIImage> _referencedImages;  // 0x198
        private Beyond.UI.UIAtlasManager.UIAtlasHandle m_atlasHandle;  // 0x1a0
        private System.Action m_onEnableRuntimeAtlas;  // 0x1c8
        private Beyond.UI.LuaPanel m_panel;  // 0x1d0
        private System.Boolean m_hasBeenEnabled;  // 0x1d8
        private System.String m_cachedSpritePath;  // 0x1e0
        protected Beyond.Resource.FAssetProxyHandle m_spriteResHandle;  // 0x1e8
        protected Beyond.Resource.FAssetProxyHandle m_matResHandle;  // 0x1fc
        public static System.String SPRITE_PATH_FORMAT;  // const
        public static System.String SPRITE_ROOT_PATH_FORMAT;  // const
        public System.Boolean enableAutoImgUsePathReference;  // 0x210
        public System.Boolean imgUsePathReference;  // 0x211
        public System.String imgRefPath;  // 0x218
        private System.Boolean m_imgIsPathReference;  // 0x220

        // Properties
        System.Boolean packIntoRuntimeAtlas { get; /* RVA: 0x03D760D0 */ set; /* RVA: 0x03D760F0 */ }
        System.Int32 atlasHandleId { get; /* RVA: 0x03D760B0 */ set; /* RVA: 0x03D760E0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x025CB310 */ }
        Beyond.UI.UIAtlasManager.UIAtlasHandle& atlasHandle { get; /* RVA: 0x03D760C0 */ }
        System.Int32 panelLevel { get; /* RVA: 0x03D59F30 */ }
        UnityEngine.Color color { get; /* RVA: 0x03D54E00 */ set; /* RVA: 0x025C1BE0 */ }
        UnityEngine.Texture mainTexture { get; /* RVA: 0x025C4980 */ }

        // Methods
        // RVA: 0x02529CE0  token: 0x6000566
        public System.Void RegisterOnEnableRuntimeAtlas(System.Action callBack) { }
        // RVA: 0x0252A2D0  token: 0x6000567
        public System.Void UnregisterOnEnableRuntimeAtlas(System.Action callBack) { }
        // RVA: 0x09AD7DB0  token: 0x6000568
        public System.Void OnEnableRuntimeAtlas() { }
        // RVA: 0x025CA510  token: 0x600056B
        protected virtual System.Void _OnSpriteChanged(UnityEngine.Sprite lastOne) { }
        // RVA: 0x025C42F0  token: 0x600056C
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        // RVA: 0x025CA830  token: 0x600056D
        protected virtual System.Void Awake() { }
        // RVA: 0x025CAF40  token: 0x600056E
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0239F230  token: 0x600056F
        protected virtual System.Void OnDisable() { }
        // RVA: 0x025CB590  token: 0x6000570
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x025CB690  token: 0x6000571
        public virtual System.Void SetNativeSize() { }
        // RVA: 0x09AD7E0C  token: 0x6000572
        public System.Void SetNativeSizeIgnoreRefScale() { }
        // RVA: 0x029FA2B0  token: 0x6000573
        public System.Void LoadSprite(System.String folder, System.String spriteName) { }
        // RVA: 0x02BE0080  token: 0x6000574
        public System.Void LoadSprite(System.String path) { }
        // RVA: 0x02C73750  token: 0x6000575
        public System.Void LoadSpriteWithOutFormat(System.String path, System.Boolean ignoreEnable) { }
        // RVA: 0x025C1ED0  token: 0x6000576
        private System.Void _LoadSprite(System.String path, System.Boolean ignoreEnable) { }
        // RVA: 0x09AD7B74  token: 0x6000577
        public System.Void LoadMaterial(System.String path, System.Boolean newInstance) { }
        // RVA: 0x03C84710  token: 0x6000578
        public virtual System.Void ReleaseSprite() { }
        // RVA: 0x025CB5E0  token: 0x6000579
        public System.Void DisposeSpriteHandle() { }
        // RVA: 0x030F0910  token: 0x600057B
        private static System.Void _V2AtlasInitialize() { }
        // RVA: 0x024342B0  token: 0x600057C
        public System.Void .ctor() { }
        // RVA: 0x09ACC870  token: 0x600057D
        public System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0) { }
        // RVA: 0x09AD7E94  token: 0x600057E
        public System.Void <>iFixBaseProxy__OnSpriteChanged(UnityEngine.Sprite P0) { }
        // RVA: 0x09AD7E7C  token: 0x600057F
        public System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }
        // RVA: 0x09AD7E5C  token: 0x6000580
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AD7E74  token: 0x6000581
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09AD7E6C  token: 0x6000582
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AD7E64  token: 0x6000583
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09AD7E8C  token: 0x6000584
        public System.Void <>iFixBaseProxy_SetNativeSize() { }
        // RVA: 0x09AD7E84  token: 0x6000585
        public System.Void <>iFixBaseProxy_ReleaseSprite() { }
        // RVA: 0x09AD7E9C  token: 0x6000586
        public UnityEngine.Texture <>iFixBaseProxy_get_mainTexture() { }

    }

    // TypeToken: 0x20000AB  // size: 0xB8
    public class UIImageBlur : Beyond.TickableUIMono
    {
        // Fields
        public System.Single scale;  // 0x68
        private UnityEngine.RectTransform m_rect;  // 0x70
        private System.Single m_lastScale;  // 0x78
        private Beyond.UI.UIImage m_image;  // 0x80
        private UnityEngine.Texture2D m_srcTex;  // 0x88
        private UnityEngine.RenderTexture m_tarTex;  // 0x90
        private System.Int32 m_uiImageBlurTexId;  // 0x98
        private UnityEngine.Rect m_atlasRect;  // 0x9c
        private System.Action m_dynamicCallback;  // 0xb0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x02529040  token: 0x6000588
        protected virtual System.Void OnAwake() { }
        // RVA: 0x02528830  token: 0x6000589
        public System.Void OnChangeSprite() { }
        // RVA: 0x09AD6BA8  token: 0x600058A
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x032FA1A0  token: 0x600058B
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AD6B24  token: 0x600058C
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02846010  token: 0x600058D
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x600058E
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x600058F
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x058DD8A4  token: 0x6000590
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7B4  token: 0x6000591
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000AC  // size: 0x28
    public class UIImageFillAmountOffset : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIImage m_followImage;  // 0x18
        public System.Single fillOffset;  // 0x20
        private System.Single m_fillAmount;  // 0x24

        // Properties
        System.Single fillAmount { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x09AD6E90 */ }

        // Methods
        // RVA: 0x09AD6D04  token: 0x6000594
        public DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(System.Single endValue, System.Single duration) { }
        // RVA: 0x0426FE60  token: 0x6000595
        public System.Void .ctor() { }
        // RVA: 0x03D524F0  token: 0x6000596
        private System.Single <DOFillAmount>b__6_0() { }
        // RVA: 0x09AD6E88  token: 0x6000597
        private System.Void <DOFillAmount>b__6_1(System.Single x) { }

    }

    // TypeToken: 0x20000AD  // size: 0x80
    public class UIImageFillFollower : Beyond.TickableUIMono
    {
        // Fields
        private static System.Single BACK_FOLLOW_THRESHOLD;  // const
        private Beyond.UI.UIImage _frontFill;  // 0x68
        private System.Single _followSpeed;  // 0x70
        private Beyond.UI.UIImage m_image;  // 0x78

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AD6FC8  token: 0x6000599
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AD706C  token: 0x600059A
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD714C  token: 0x600059B
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD70E0  token: 0x600059C
        public System.Void RefreshFillAmount() { }
        // RVA: 0x09AD7250  token: 0x600059D
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x600059E
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x600059F
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x60005A0
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AE  // size: 0x88
    public class UIImageFillTailFollower : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIImage _followImage;  // 0x68
        public System.Single followOffset;  // 0x70
        private UnityEngine.RectTransform m_selfRectTransform;  // 0x78
        private UnityEngine.RectTransform m_followImageRectTransform;  // 0x80

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AD7260  token: 0x60005A2
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AD7324  token: 0x60005A3
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD763C  token: 0x60005A4
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD738C  token: 0x60005A5
        public System.Void RefreshFollower() { }
        // RVA: 0x02846010  token: 0x60005A6
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60005A7
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60005A8
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x60005A9
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AF  // size: 0x20
    public class UIImagePair : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIImage> referencedImages;  // 0x18

        // Properties
        UnityEngine.Color color { set; /* RVA: 0x09AD79E4 */ }
        Beyond.UI.UIImage first { get; /* RVA: 0x09AD794C */ }

        // Methods
        // RVA: 0x09AD7814  token: 0x60005AA
        public System.Void LoadSprite(System.String folder, System.String spriteName) { }
        // RVA: 0x09AD76A8  token: 0x60005AB
        public System.Void LoadSprite(System.String path) { }
        // RVA: 0x09AD78CC  token: 0x60005AE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0  // size: 0xF0
    public class UIInertiaViewPager : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIScrollRect _scrollRect;  // 0x68
        private System.Single _animationDuration;  // 0x70
        private System.Single _endScrollSpd;  // 0x74
        private Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing _timing;  // 0x78
        private System.Single _minScrollInterval;  // 0x7c
        private System.String _audioGear;  // 0x80
        private System.String _audioGearLock;  // 0x88
        public System.Boolean flingToNextEnable;  // 0x90
        public System.Single flingToNextMinSpd;  // 0x94
        public System.Single flingToNextMaxSpd;  // 0x98
        private System.Int32 m_currentPage;  // 0x9c
        private Beyond.UI.UIInertiaViewPager.State m_state;  // 0xa0
        private Beyond.UI.UIInertiaViewPager.IScrollHandler m_scrollHandler;  // 0xa8
        private Beyond.UI.UIInertiaViewPager.ScrollEffectTrigger m_effectTrigger;  // 0xb0
        private Beyond.UI.UIInertiaViewPager.BlockerManager m_blockers;  // 0xb8
        private Beyond.UI.UIInertiaViewPager.DragContext m_dragContext;  // 0xc0
        private System.Int32 m_fromPage;  // 0xc8
        private System.Int32 m_toPage;  // 0xcc
        private System.Single m_tweenStartTime;  // 0xd0
        private System.Single m_tweenStartValue;  // 0xd4
        private System.Single m_tweenTargetValue;  // 0xd8
        private System.Boolean m_isInited;  // 0xdc
        private System.Int32 <pageCount>k__BackingField;  // 0xe0
        public Beyond.DisposedUnityEvent<System.Int32> onStateChanged;  // 0xe8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean isUpdating { get; /* RVA: 0x09AD8DA0 */ }
        System.Int32 pageCount { get; /* RVA: 0x03D50ED0 */ set; /* RVA: 0x03D50FB0 */ }
        System.Int32 currentPage { get; /* RVA: 0x03D51960 */ set; /* RVA: 0x09AD8DAC */ }
        System.Single currentScrollIndex { get; /* RVA: 0x09AD8D6C */ }

        // Methods
        // RVA: 0x09AD8924  token: 0x60005B0
        private System.Void _PlayAudioGear() { }
        // RVA: 0x09AD88A8  token: 0x60005B1
        private System.Void _PlayAudioGearLock() { }
        // RVA: 0x09AD854C  token: 0x60005B2
        private System.Void _InitIfNot() { }
        // RVA: 0x09AD7EA4  token: 0x60005B9
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AD817C  token: 0x60005BA
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AD80F4  token: 0x60005BB
        public System.Void SetPageCount(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> segmentFrames) { }
        // RVA: 0x09AD7F98  token: 0x60005BC
        public System.Void MoveToPage(System.Int32 pageIndex) { }
        // RVA: 0x09AD8028  token: 0x60005BD
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AD8084  token: 0x60005BE
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD89A0  token: 0x60005BF
        private System.Single _ScrollValue2PageIndex(System.Single value) { }
        // RVA: 0x09AD882C  token: 0x60005C0
        private System.Single _PageIndex2ScrollValue(System.Single index) { }
        // RVA: 0x09AD8A18  token: 0x60005C1
        private System.Int32 _ScrollValueAlignToPage(System.Single value) { }
        // RVA: 0x09AD8A9C  token: 0x60005C2
        private System.Void _SwitchToPage(System.Int32 targetIndex, System.Boolean useTween) { }
        // RVA: 0x09AD84D4  token: 0x60005C3
        private System.Void _AutoAlign() { }
        // RVA: 0x09AD875C  token: 0x60005C4
        private System.Void _OnStateChanged(Beyond.UI.UIInertiaViewPager.State from, Beyond.UI.UIInertiaViewPager.State to) { }
        // RVA: 0x09AD8C30  token: 0x60005C5
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x60005C6
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x058E2A30  token: 0x60005C7
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60005C8
        public System.Void <>iFixBaseProxy_OnEnable() { }

    }

    // TypeToken: 0x20000BE  // size: 0x440
    public class UIInputField : TMPro.TMP_InputField, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public System.String activeInputActionId;  // 0x388
        public System.String deactivateInputActionId;  // 0x390
        private System.Int32 <activeInputBindingId>k__BackingField;  // 0x398
        private System.Int32 <deactivateInputBindingId>k__BackingField;  // 0x39c
        private Beyond.UI.LuaPanel m_panel;  // 0x3a0
        public System.Boolean isDebugInputField;  // 0x3a8
        private UnityEngine.Camera m_fallbackUICamera;  // 0x3b0
        private UnityEngine.GameObject m_fallbackUIRoot;  // 0x3b8
        private UnityEngine.RectTransform m_fallbackRectTransform;  // 0x3c0
        private System.Int32 m_activateBindingGroupId;  // 0x3c8
        private System.Boolean m_isNaviFocused;  // 0x3cc
        private Beyond.UI.UIState.UIStateController _uiStateController;  // 0x3d0
        private System.String _onFocusStateName;  // 0x3d8
        private System.String _onFocusLostStateName;  // 0x3e0
        private System.String _audioPressStart;  // 0x3e8
        public UnityEngine.RectTransform m_keyboardOffsetTarget;  // 0x3f0
        public UnityEngine.RectTransform m_offsetTargetParent;  // 0x3f8
        public UnityEngine.RectTransform m_inputFieldRect;  // 0x400
        public System.Int32 m_pcDebug;  // 0x408
        public System.Single m_keyboardExtraOffsetY;  // 0x40c
        private UnityEngine.Vector2 m_baseKeyboardOffsetTarget;  // 0x410
        private UnityEngine.Vector2 m_baseKeyboardLocalPos;  // 0x418
        private System.Single m_inputFieldOffsetY;  // 0x420
        private System.Boolean m_enableKeyboardOffsetCal;  // 0x424
        private UnityEngine.Coroutine m_heightChangeCoroutine;  // 0x428
        private System.Int32 m_lastHeight;  // 0x430
        private System.Int32 m_nowHeight;  // 0x434
        public System.String audioOnActive;  // 0x438
        private static Beyond.UI.UIInputField s_mFocusedInputField;  // static @ 0x0

        // Properties
        System.Int32 activeInputBindingId { get; /* RVA: 0x03D76100 */ set; /* RVA: 0x03D76120 */ }
        System.Int32 deactivateInputBindingId { get; /* RVA: 0x03D76110 */ set; /* RVA: 0x03D76130 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AD91CC */ }
        System.Boolean isControllerInputValid { get; /* RVA: 0x03683B80 */ }
        Beyond.UI.UIInputField s_focusedInputField { get; /* RVA: 0x09AD9290 */ set; /* RVA: 0x02B56B00 */ }

        // Methods
        // RVA: 0x03CC4AA0  token: 0x60005F5
        protected virtual System.Void SendOnFocus() { }
        // RVA: 0x03CFB4E0  token: 0x60005F6
        protected virtual System.Void SendOnFocusLost() { }
        // RVA: 0x03779290  token: 0x60005F7
        protected virtual System.Void Awake() { }
        // RVA: 0x03CDD0A0  token: 0x60005F8
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03CBAAE0  token: 0x60005F9
        public virtual System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03683900  token: 0x60005FA
        public virtual System.Void ActivateInputField() { }
        // RVA: 0x03683A00  token: 0x60005FB
        public virtual System.Void DeactivateInputField(System.Boolean clearSelection) { }
        // RVA: 0x0304D600  token: 0x60005FC
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02CD8110  token: 0x60005FD
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02CD8150  token: 0x60005FE
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0386D1D0  token: 0x60005FF
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x09AD8DB8  token: 0x6000600
        public virtual System.Void OnInteractableChanged() { }
        // RVA: 0x02CD8190  token: 0x6000601
        private System.Void _UpdateBindingEnable() { }
        // RVA: 0x02C70800  token: 0x6000602
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AD8E9C  token: 0x6000603
        private UnityEngine.Camera _GetCamera() { }
        // RVA: 0x03D07970  token: 0x6000604
        private System.Void _VirtualKeyboardOnDestroy() { }
        // RVA: 0x03CDD0F0  token: 0x6000605
        private System.Void _VirtualKeyboardSelect() { }
        // RVA: 0x03CBAB30  token: 0x6000606
        private System.Void _VirtualKeyboardDeselect() { }
        // RVA: 0x037795C0  token: 0x6000607
        private System.Void _VirtualKeyboardAwake() { }
        // RVA: 0x09AD9178  token: 0x6000608
        private System.Void _UpdateKeyboardOffset(System.Int32 offsetHeight) { }
        // RVA: 0x09AD8E58  token: 0x6000609
        private System.Void _CleanupAndroidObjects() { }
        // RVA: 0x03779600  token: 0x600060A
        private System.Void _VirtualKeyboardInitJavaObj() { }
        // RVA: 0x09AD90DC  token: 0x600060B
        private System.Collections.IEnumerator _KeyboardHeightChange(System.Action<System.Int32> onHeightChanged) { }
        // RVA: 0x02849EC0  token: 0x600060E
        public System.Void .ctor() { }
        // RVA: 0x09AD8E08  token: 0x600060F
        private System.Void <Awake>b__27_0() { }
        // RVA: 0x09AD8E50  token: 0x6000610
        public System.Void <>iFixBaseProxy_SendOnFocus() { }
        // RVA: 0x09AD8E48  token: 0x6000611
        public System.Void <>iFixBaseProxy_SendOnFocusLost() { }
        // RVA: 0x09AAE8DC  token: 0x6000612
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AD8E40  token: 0x6000613
        public System.Void <>iFixBaseProxy_OnSelect(UnityEngine.EventSystems.BaseEventData P0) { }
        // RVA: 0x09AD8E28  token: 0x6000614
        public System.Void <>iFixBaseProxy_OnDeselect(UnityEngine.EventSystems.BaseEventData P0) { }
        // RVA: 0x09AD8E18  token: 0x6000615
        public System.Void <>iFixBaseProxy_ActivateInputField() { }
        // RVA: 0x09AD8E20  token: 0x6000616
        public System.Void <>iFixBaseProxy_DeactivateInputField(System.Boolean P0) { }
        // RVA: 0x09AAE8E4  token: 0x6000617
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09AD8E38  token: 0x6000618
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09AD8E30  token: 0x6000619
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09ACB974  token: 0x600061A
        public System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        // RVA: 0x0350B670  token: 0x600061B
        public System.Void <>iFixBaseProxy_OnInteractableChanged() { }

    }

    // TypeToken: 0x20000C0  // size: 0x188
    public class UIJoystick : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, Beyond.Input.IBindingGroupTarget
    {
        // Fields
        private UnityEngine.RectTransform _runBg;  // 0x18
        private UnityEngine.RectTransform _walkBg;  // 0x20
        private UnityEngine.RectTransform _thumb;  // 0x28
        private UnityEngine.RectTransform _directionIndicate;  // 0x30
        private UnityEngine.RectTransform _walkDirectionIndicate;  // 0x38
        private UnityEngine.RectTransform _rootCanvas;  // 0x40
        private UnityEngine.RectTransform _triggerArea;  // 0x48
        private UnityEngine.UI.GraphicRaycaster _raycaster;  // 0x50
        private System.Single _walkRation;  // 0x58
        private System.Single _autoSprintStartLength;  // 0x5c
        private System.Single _autoSprintStopLength;  // 0x60
        private System.Single _autoSprintStartAngle;  // 0x64
        private System.Single _autoSprintStopAngle;  // 0x68
        public System.Single margin;  // 0x6c
        public System.Single bgVisibleTimeWhenEnable;  // 0x70
        private System.Single m_bgHideTime;  // 0x74
        private System.Boolean _isDynamic;  // 0x78
        private Beyond.UI.LuaPanel m_panel;  // 0x80
        private UnityEngine.Vector2 <jsValue>k__BackingField;  // 0x88
        private Beyond.UI.UITouchPanel _dynamicArea;  // 0x90
        private System.Boolean _dynamicButDontMove;  // 0x98
        private System.Boolean _useRewiredPlayerInput;  // 0x99
        private System.String _controllerRewiredActionX;  // 0xa0
        private System.String _controllerRewiredActionY;  // 0xa8
        private System.String _keyboardRewiredActionX;  // 0xb0
        private System.String _keyboardRewiredActionY;  // 0xb8
        private System.Boolean m_active;  // 0xc0
        private System.Boolean m_activatedByTouch;  // 0xc1
        public Beyond.DisposedUnityEvent onTouchStart;  // 0xc8
        public Beyond.DisposedUnityEvent onTouchEnd;  // 0xd0
        public Beyond.DisposedUnityEvent onMoveStart;  // 0xd8
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onMove;  // 0xe0
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0xe8
        public Beyond.DisposedUnityEvent<System.Boolean> onToggleAutoSprint;  // 0xf0
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xf8
        private UnityEngine.RectTransform m_rect;  // 0x100
        private UnityEngine.Vector2 m_oriAnchorMin;  // 0x108
        private UnityEngine.Vector2 m_oriAnchorMax;  // 0x110
        private UnityEngine.Vector2 m_oriAnchorPos;  // 0x118
        private UnityEngine.Vector2 m_oriPivot;  // 0x120
        private System.Boolean m_isWalking;  // 0x128
        private System.Boolean m_isRunning;  // 0x129
        private System.Boolean m_isSprinting;  // 0x12a
        private Beyond.UI.UIAnimationWrapper m_walkBgAnim;  // 0x130
        private Beyond.UI.UIAnimationWrapper m_runBgAnim;  // 0x138
        private System.Boolean m_isWalkBgVisible;  // 0x140
        private System.Boolean m_isRunBgVisible;  // 0x141
        private System.Collections.Generic.List<UnityEngine.InputSystem.UI.ExtendedPointerEventData> m_exPointers;  // 0x148
        private UnityEngine.InputSystem.UI.ExtendedPointerEventData m_fakePointerEventData;  // 0x150
        private UnityEngine.InputSystem.UI.ExtendedPointerEventData m_activePointerEventData;  // 0x158
        private Beyond.UI.UICustomLayoutElement m_customLayoutElement;  // 0x160
        private UnityEngine.Vector2 m_lastFrameActiveStickVal;  // 0x168
        private UnityEngine.EventSystems.PointerEventData <curDragEventData>k__BackingField;  // 0x170
        private System.Int32 m_groupId;  // 0x178
        private System.Boolean m_bindingInit;  // 0x17c
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;  // 0x180

        // Properties
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AD9990 */ }
        System.Boolean isDynamic { get; /* RVA: 0x03D4F800 */ set; /* RVA: 0x09AD9A54 */ }
        System.Single walkRation { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x02BDC0D0 */ }
        System.Boolean active { get; /* RVA: 0x03D583F0 */ }
        System.Int32 activeTouchId { get; /* RVA: 0x09AD9958 */ }
        UnityEngine.Vector2 jsValue { get; /* RVA: 0x03D696E0 */ set; /* RVA: 0x03D4E740 */ }
        System.Single m_thumbPosMaxLength { get; /* RVA: 0x029130A0 */ }
        UnityEngine.EventSystems.PointerEventData curDragEventData { get; /* RVA: 0x03D574A0 */ set; /* RVA: 0x04275C18 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x02913170 */ }
        System.Boolean shouldCheckInput { get; /* RVA: 0x02913100 */ }
        System.Int32 groupId { get; /* RVA: 0x09AD9974 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D56B50 */ }
        Beyond.Input.InputBindingGroupMonoTarget parent { get; /* RVA: 0x03D56B50 */ set; /* RVA: 0x04275C40 */ }

        // Methods
        // RVA: 0x09AD9788  token: 0x600062E
        private System.Void Reset() { }
        // RVA: 0x02BDCE00  token: 0x600062F
        private System.Void Awake() { }
        // RVA: 0x03B3E800  token: 0x6000630
        protected System.Void OnEnable() { }
        // RVA: 0x03CB4140  token: 0x6000631
        private System.Void Start() { }
        // RVA: 0x09AD93D0  token: 0x6000632
        protected System.Void OnDestroy() { }
        // RVA: 0x029131D0  token: 0x6000633
        private System.Void _Tick() { }
        // RVA: 0x09AD9600  token: 0x6000634
        protected System.Void OnDisable() { }
        // RVA: 0x02BDC8B0  token: 0x6000635
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x038DEC00  token: 0x6000636
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03CA3FA0  token: 0x6000637
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02912E20  token: 0x6000638
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02CAD100  token: 0x6000639
        public System.Void CheckShouldActive() { }
        // RVA: 0x02BDC850  token: 0x600063A
        private System.Void _SetVisible(System.Boolean visible) { }
        // RVA: 0x02BDC540  token: 0x600063B
        private System.Void _ChangeDynamic(System.Boolean dynamic, System.Boolean force) { }
        // RVA: 0x02BDCAC0  token: 0x600063C
        private System.Void _SetRectTransform(System.Boolean toOri) { }
        // RVA: 0x02BDC130  token: 0x600063D
        private System.Void _UpdateWalkBgScale() { }
        // RVA: 0x02BDC9F0  token: 0x600063E
        private System.Void _Activate(System.Boolean fromTouch, UnityEngine.Vector2 showPos, UnityEngine.Vector2 initJsValue) { }
        // RVA: 0x02912D50  token: 0x600063F
        private System.Void _UpdateGait() { }
        // RVA: 0x02912970  token: 0x6000640
        private System.Void _UpdateIndicator() { }
        // RVA: 0x02912B40  token: 0x6000641
        private System.Void _UpdateBg() { }
        // RVA: 0x02912C20  token: 0x6000642
        private System.Void _SetWalkBgVisible(System.Boolean visible, System.Boolean ignoreAnim) { }
        // RVA: 0x02912CA0  token: 0x6000643
        private System.Void _SetRunBgVisible(System.Boolean visible, System.Boolean ignoreAnim) { }
        // RVA: 0x09AD9864  token: 0x6000644
        private System.Void _OnHudLayoutLoaded(Beyond.EventData<System.String>& eventData) { }
        // RVA: 0x09AD92C8  token: 0x6000645
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02BDC300  token: 0x600064C
        public System.Void InitBinding() { }
        // RVA: 0x02BDC460  token: 0x600064D
        private System.Void _UpdateState() { }
        // RVA: 0x028490A0  token: 0x600064E
        public System.Void .ctor() { }
        // RVA: 0x09AD9858  token: 0x600064F
        private System.Void <Awake>b__74_0(UnityEngine.Vector2 _) { }

    }

    // TypeToken: 0x20000C1  // size: 0x28
    public class UILayoutDimensionListener : UnityEngine.EventSystems.UIBehaviour, Beyond.IHotfixable, UnityEngine.UI.ICanvasElement
    {
        // Fields
        private Beyond.ListSet<Beyond.UI.UILayoutDimensionListener.IAction> m_actionsWhenLayoutReady;  // 0x18
        public Beyond.DisposedUnityEvent eventOnPostLayout;  // 0x20

        // Methods
        // RVA: 0x09AD9AF0  token: 0x6000650
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x09AD9B34  token: 0x6000651
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x09AD9CB0  token: 0x6000652
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x09AD9F94  token: 0x6000653
        private System.Collections.IEnumerator _NextFrameCoroutine() { }
        // RVA: 0x09AD9A60  token: 0x6000654
        public System.Void DoOnceOnPostLayout(Beyond.UI.UILayoutDimensionListener.IAction action) { }
        // RVA: 0x09AD9C10  token: 0x6000655
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AD9C60  token: 0x6000656
        protected virtual System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x09AD9B78  token: 0x6000657
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09ADA024  token: 0x6000658
        private System.Void _SetDirty() { }
        // RVA: 0x09AD9D80  token: 0x6000659
        private System.Void _InvokePostLayoutCallback() { }
        // RVA: 0x03D018C0  token: 0x600065A
        public System.Void .ctor() { }
        // RVA: 0x09AD9D30  token: 0x600065B
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }
        // RVA: 0x0350B670  token: 0x600065C
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0350B670  token: 0x600065D
        public System.Void <>iFixBaseProxy_OnRectTransformDimensionsChange() { }
        // RVA: 0x0350B670  token: 0x600065E
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000C4  // size: 0xB0
    public class UILeftSubtitle : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIDialogTextWithCursor _dialogText1;  // 0x68
        private Beyond.UI.UIDialogTextWithCursor _dialogText2;  // 0x70
        private Beyond.UI.UIDialogTextWithCursor _dialogText3;  // 0x78
        private Beyond.UI.UIDialogTextWithCursor _dialogText4;  // 0x80
        private Beyond.UI.UIAnimationWrapper _panelAnimation;  // 0x88
        private System.Int32 m_maxDisplayIndex;  // 0x90
        private readonly System.Collections.Generic.List<Beyond.UI.UIDialogTextWithCursor> m_dialogTextList;  // 0x98
        private System.Boolean m_isDisplaying;  // 0xa0
        private System.Single m_currTime;  // 0xa4
        private System.Single m_textStayTime;  // 0xa8
        private System.Boolean m_isAutoPlay;  // 0xac

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09ADA6F8  token: 0x6000667
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09ADA688  token: 0x6000668
        public System.Void StartAutoPlay(System.Single textStayTime) { }
        // RVA: 0x09ADA1A8  token: 0x6000669
        public System.Void SetLeftSubTitle(System.String text1, System.String text2, System.String text3, System.String text4) { }
        // RVA: 0x09ADA7BC  token: 0x600066A
        public System.Single UpdateByPlayTime(System.Single currTime) { }
        // RVA: 0x09ADA0B0  token: 0x600066B
        public System.Void Exit() { }
        // RVA: 0x09ADA618  token: 0x600066C
        public System.Void SetVisible(System.Boolean visible) { }
        // RVA: 0x09ADA8BC  token: 0x600066D
        public System.Void .ctor() { }
        // RVA: 0x09ADA7B0  token: 0x600066E
        private System.Void <Exit>b__17_0() { }
        // RVA: 0x0577D7BC  token: 0x600066F
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000C5  // size: 0x1E0
    public class UIMaterialAnimation : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.UI.MaskableGraphic _maskableGraphic;  // 0x68
        private UnityEngine.Material _material;  // 0x70
        private System.String _propertiesName1;  // 0x78
        private System.Single _propertiesSet1;  // 0x80
        private System.String _propertiesName2;  // 0x88
        private System.Single _propertiesSet2;  // 0x90
        private System.String _propertiesName3;  // 0x98
        private System.Single _propertiesSet3;  // 0xa0
        private System.String _propertiesName4;  // 0xa8
        private System.Single _propertiesSet4;  // 0xb0
        private System.String _propertiesName5;  // 0xb8
        private System.Single _propertiesSet5;  // 0xc0
        private System.String _propertiesName6;  // 0xc8
        private System.Single _propertiesSet6;  // 0xd0
        private System.String _propertiesName7;  // 0xd8
        private System.Single _propertiesSet7;  // 0xe0
        private System.String _propertiesName8;  // 0xe8
        private System.Single _propertiesSet8;  // 0xf0
        private System.String _propertiesName9;  // 0xf8
        private System.Single _propertiesSet9;  // 0x100
        private System.String _propertiesName10;  // 0x108
        private System.Single _propertiesSet10;  // 0x110
        private System.String _propertiesVectorName1;  // 0x118
        private UnityEngine.Vector4 _propertiesVector1;  // 0x120
        private System.String _propertiesVectorName2;  // 0x130
        private UnityEngine.Vector4 _propertiesVector2;  // 0x138
        private System.String _propertiesVectorName3;  // 0x148
        private UnityEngine.Vector4 _propertiesVector3;  // 0x150
        private System.String _propertiesVectorName4;  // 0x160
        private UnityEngine.Vector4 _propertiesVector4;  // 0x168
        private System.String _propertiesVectorName5;  // 0x178
        private UnityEngine.Vector4 _propertiesVector5;  // 0x180
        private System.String _propertiesColorName1;  // 0x190
        private UnityEngine.Color _propertiesColor1;  // 0x198
        private System.String _propertiesColorName2;  // 0x1a8
        private UnityEngine.Color _propertiesColor2;  // 0x1b0
        private System.String _propertiesColorName3;  // 0x1c0
        private UnityEngine.Color _propertiesColor3;  // 0x1c8
        private UnityEngine.Material m_matIns;  // 0x1d8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x02861160  token: 0x6000671
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x037D3C20  token: 0x6000672
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03A28FF0  token: 0x6000673
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02861200  token: 0x6000674
        private System.Void _TryUpdate() { }
        // RVA: 0x09ADA950  token: 0x6000675
        public System.Void ForceUpdate() { }
        // RVA: 0x02846010  token: 0x6000676
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x6000677
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058E2A30  token: 0x6000678
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7B4  token: 0x6000679
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000C6  // size: 0x2D8
    public class UINonUnifiedScrollList : Beyond.UI.UIScrollList
    {
        // Fields
        public Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode getCellSizeMode;  // 0x278
        private System.Boolean _recalculateAfterSizeChange;  // 0x27c
        private System.Boolean _forceUpdateCellSizeCache;  // 0x27d
        public System.Func<System.Int32,System.Int32> getSubCellCount;  // 0x280
        public System.Func<System.Int32,System.Single> getCellSize;  // 0x288
        public System.Single overrideContainSize;  // 0x290
        private UnityEngine.UI.GridLayoutGroup m_templateCellGridLayoutGroup;  // 0x298
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> m_cellSizeCache;  // 0x2a0
        private System.Int32 m_containerTopIndex;  // 0x2a8
        private static System.Single CONTAINER_SIZE_BUFFER;  // const
        public System.Single additiveContainerSizeBuffer;  // 0x2ac
        private System.Single m_lastScrollStep;  // 0x2b0
        private System.Boolean m_isRecalculatingSize;  // 0x2b4
        private System.Boolean m_isCalculatingContainerSize;  // 0x2b5
        private System.Int32 m_averageCount;  // 0x2b8
        private System.Single m_averageCellSize;  // 0x2bc
        private System.Boolean m_needRecalculateAverage;  // 0x2c0
        private System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_cellFoldStateDic;  // 0x2c8
        private Beyond.UI.IUIFoldoutComp m_cellTemplateFoldoutComp;  // 0x2d0

        // Properties
        System.Single currentStep { get; /* RVA: 0x09ADD894 */ set; /* RVA: 0x09ADDA4C */ }

        // Methods
        // RVA: 0x09ADBEA4  token: 0x600067A
        protected virtual System.Void InitBasicInfo() { }
        // RVA: 0x09ADA9A0  token: 0x600067B
        protected virtual System.Void CalcSomeCountNum() { }
        // RVA: 0x09ADB6A0  token: 0x600067C
        protected virtual System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount) { }
        // RVA: 0x09ADD388  token: 0x600067D
        public virtual System.Void UpdateCount(System.Int32 newCount) { }
        // RVA: 0x09ADD0A8  token: 0x600067E
        public virtual System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow) { }
        // RVA: 0x09ADD168  token: 0x600067F
        public virtual System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x09ADBF6C  token: 0x6000680
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09ADC180  token: 0x6000681
        protected virtual System.Void OnScroll(UnityEngine.Vector2 v) { }
        // RVA: 0x09ADB340  token: 0x6000682
        public static UnityEngine.Vector2 GetGridLayoutSize(UnityEngine.UI.GridLayoutGroup grid, System.Int32 count) { }
        // RVA: 0x09ADD458  token: 0x6000683
        private System.Single _GetCellSize(System.Int32 index) { }
        // RVA: 0x09ADAED0  token: 0x6000684
        protected virtual System.Single GetContainerSize(System.Boolean ignoreAutoLayout) { }
        // RVA: 0x09ADACE4  token: 0x6000685
        public virtual System.Single GetCenterIndex() { }
        // RVA: 0x09ADBA20  token: 0x6000686
        public virtual UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow) { }
        // RVA: 0x09ADB7E4  token: 0x6000687
        protected virtual UnityEngine.Vector2Int GetNotCacheRange() { }
        // RVA: 0x09ADBFE8  token: 0x6000688
        protected virtual System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        // RVA: 0x09ADC208  token: 0x6000689
        protected virtual System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        // RVA: 0x09ADBC9C  token: 0x600068A
        protected virtual System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x09ADD7C4  token: 0x600068B
        private System.Single _GetCellsSizeTo(System.Int32 index) { }
        // RVA: 0x09ADC484  token: 0x600068C
        protected virtual System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x09ADAA08  token: 0x600068D
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09ADC994  token: 0x6000690
        public virtual System.Void SetStepTo(System.Single step) { }
        // RVA: 0x09ADC714  token: 0x6000691
        public System.Void SetCurrentStep(System.Single currentStep) { }
        // RVA: 0x09ADB8BC  token: 0x6000692
        public System.Single GetScrollBarSize() { }
        // RVA: 0x09ADB520  token: 0x6000693
        public System.Single GetLastScrollStep() { }
        // RVA: 0x09ADD3FC  token: 0x6000694
        public System.Void UpdateLastScrollStep() { }
        // RVA: 0x09ADB758  token: 0x6000695
        public System.Single GetNormalizedPosition() { }
        // RVA: 0x09ADC8FC  token: 0x6000696
        public System.Void SetNormalizedPosition(System.Single normalizedPosition) { }
        // RVA: 0x09ADCA08  token: 0x6000697
        public System.Void ToggleByState(System.Int32 index, System.Boolean isFoldOut, System.Boolean fastMode) { }
        // RVA: 0x09ADCBEC  token: 0x6000698
        public System.Void Toggle(System.Int32 index, System.Boolean fastMode) { }
        // RVA: 0x09ADAAB4  token: 0x6000699
        public System.Void FoldAll(System.Boolean isFoldOut) { }
        // RVA: 0x09ADC0B4  token: 0x600069A
        public System.Void NotifyCellSizeChange(System.Int32 index, System.Single size) { }
        // RVA: 0x03B73140  token: 0x600069B
        public System.Void .ctor() { }
        // RVA: 0x09ADCE14  token: 0x600069C
        private System.Void <GetScrollBarSize>g__RecalculateAverageCellSize|43_0() { }
        // RVA: 0x09ADD020  token: 0x600069D
        public System.Void <>iFixBaseProxy_InitBasicInfo() { }
        // RVA: 0x09ADCFE0  token: 0x600069E
        public System.Void <>iFixBaseProxy_CalcSomeCountNum() { }
        // RVA: 0x09ADD000  token: 0x600069F
        public System.Single <>iFixBaseProxy_GetLeftLength(System.Boolean P0, System.Int32 P1) { }
        // RVA: 0x09ADD098  token: 0x60006A0
        public System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0) { }
        // RVA: 0x09ADD078  token: 0x60006A1
        public System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x09ADD058  token: 0x60006A2
        public System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, Beyond.UI.UIScrollList.ScrollAlignType P5) { }
        // RVA: 0x09ADD028  token: 0x60006A3
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x09ADD030  token: 0x60006A4
        public System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0) { }
        // RVA: 0x09ADCFF8  token: 0x60006A5
        public System.Single <>iFixBaseProxy_GetContainerSize(System.Boolean P0) { }
        // RVA: 0x09ADCFF0  token: 0x60006A6
        public System.Single <>iFixBaseProxy_GetCenterIndex() { }
        // RVA: 0x09ADD010  token: 0x60006A7
        public UnityEngine.Vector2Int <>iFixBaseProxy_GetShowRange(System.Single P0, System.Boolean P1) { }
        // RVA: 0x09ADD008  token: 0x60006A8
        public UnityEngine.Vector2Int <>iFixBaseProxy_GetNotCacheRange() { }
        // RVA: 0x09AC26FC  token: 0x60006A9
        public System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }
        // RVA: 0x09ADD038  token: 0x60006AA
        public System.Void <>iFixBaseProxy_OnUpdateCell(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }
        // RVA: 0x09ADD018  token: 0x60006AB
        public System.Single <>iFixBaseProxy_GetTargetPosByIndex(System.Int32 P0, Beyond.UI.UIScrollList.ScrollAlignType P1) { }
        // RVA: 0x09ADD040  token: 0x60006AC
        public System.Void <>iFixBaseProxy_ScrollTo(System.Int32 P0, System.Boolean P1, Beyond.UI.UIScrollList.ScrollAlignType P2) { }
        // RVA: 0x09ADCFE8  token: 0x60006AD
        public System.Void <>iFixBaseProxy_ClearComponent() { }
        // RVA: 0x09ADD0A0  token: 0x60006AE
        public System.Single <>iFixBaseProxy_get_currentStep() { }
        // RVA: 0x09ADD050  token: 0x60006AF
        public System.Void <>iFixBaseProxy_SetStepTo(System.Single P0) { }

    }

    // TypeToken: 0x20000C8  // size: 0x1F0
    public class UINonUnifiedScrollRect : Beyond.UI.UIScrollRect
    {
        // Fields
        private System.Boolean m_isInited;  // 0x1d8
        private System.Boolean m_isRebuilding;  // 0x1d9
        private Beyond.UI.UINonUnifiedScrollList m_scrollList;  // 0x1e0
        private Beyond.UI.UILayoutDimensionListener m_dimensionListener;  // 0x1e8

        // Methods
        // RVA: 0x09ADDEB0  token: 0x60006B0
        private System.Void _InitIfNot() { }
        // RVA: 0x09ADDDCC  token: 0x60006B1
        protected virtual System.Void UpdateScrollbars(UnityEngine.Vector2 offset) { }
        // RVA: 0x09ADDACC  token: 0x60006B2
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x09ADE0B0  token: 0x60006B3
        private System.Void _UpdateNonUnifiedScrollbars() { }
        // RVA: 0x09ADDB3C  token: 0x60006B4
        protected virtual System.Void SetHorizontalNormalizedPosition(System.Single value) { }
        // RVA: 0x09ADDC7C  token: 0x60006B5
        protected virtual System.Void SetVerticalNormalizedPosition(System.Single value) { }
        // RVA: 0x09ADDFF8  token: 0x60006B6
        private System.Void _OnPostLayout() { }
        // RVA: 0x03D4D8F0  token: 0x60006B7
        public System.Void .ctor() { }
        // RVA: 0x09ADDDC4  token: 0x60006B8
        public System.Void <>iFixBaseProxy_UpdateScrollbars(UnityEngine.Vector2 P0) { }
        // RVA: 0x09ADDDBC  token: 0x60006B9
        public System.Void <>iFixBaseProxy_Rebuild(UnityEngine.UI.CanvasUpdate P0) { }
        // RVA: 0x04274DE0  token: 0x60006BA
        public System.Void <>iFixBaseProxy_SetHorizontalNormalizedPosition(System.Single P0) { }
        // RVA: 0x04274DEC  token: 0x60006BB
        public System.Void <>iFixBaseProxy_SetVerticalNormalizedPosition(System.Single P0) { }

    }

    // TypeToken: 0x20000C9  // size: 0xA0
    public class UINumberScrollTween : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.UI.UIText bindingUIText;  // 0x68
        public System.Single tweenDuration;  // 0x70
        public System.Boolean useCustomNumberTweenCurve;  // 0x74
        public UnityEngine.AnimationCurve numberTweenCurve;  // 0x78
        private System.String m_tweenToText;  // 0x80
        private System.Single m_tweenStartTime;  // 0x88
        private System.Single m_curTime;  // 0x8c
        private System.Boolean m_inTransition;  // 0x90
        private System.Single m_fromNumber;  // 0x94
        private System.Single m_toNumber;  // 0x98

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.String tweenToText { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x09ADE788 */ }
        System.String text { get; /* RVA: 0x09ADE620 */ set; /* RVA: 0x09ADE6D4 */ }

        // Methods
        // RVA: 0x09ADE228  token: 0x60006C1
        private System.Void Start() { }
        // RVA: 0x09ADE2B8  token: 0x60006C2
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09ADE4D0  token: 0x60006C3
        private System.Void _TweenToTarget(System.String targetText) { }
        // RVA: 0x09ADE388  token: 0x60006C4
        private System.Void _CleanupBeforeTween() { }
        // RVA: 0x09ADE3D8  token: 0x60006C5
        private System.Void _HandleNumberScrollTween(System.Single fromNumber, System.Single toNumber, System.Single curTime) { }
        // RVA: 0x09ADE5D4  token: 0x60006C6
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x60006C7
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000CA  // size: 0x28
    public class UIPCScaleHelper : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 baseScale;  // 0x18

        // Methods
        // RVA: 0x037E5E00  token: 0x60006C8
        private System.Void OnEnable() { }
        // RVA: 0x038567F0  token: 0x60006C9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB  // size: 0x100
    public class UIRawImage : UnityEngine.UI.RawImage
    {
        // Methods
        // RVA: 0x02700700  token: 0x60006CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC  // size: 0x30
    public class UIRegionBuildingTexManager : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Shader _regionMapShader;  // 0x18
        public UnityEngine.Texture2D minimapOutlineTex;  // 0x20
        private static System.Int32 s_buildingOutlineTex;  // static @ 0x0
        private UnityEngine.Renderer m_meshRenderer;  // 0x28
        private static UnityEngine.MaterialPropertyBlock s_materialPropertyBlock;  // static @ 0x8

        // Properties
        UnityEngine.MaterialPropertyBlock materialPropertyBlock { get; /* RVA: 0x02D14AF0 */ }

        // Methods
        // RVA: 0x02D147A0  token: 0x60006CC
        private System.Void OnEnable() { }
        // RVA: 0x09ADE790  token: 0x60006CD
        private System.Void OnValidate() { }
        // RVA: 0x02D146C0  token: 0x60006CE
        private System.Void OnDisable() { }
        // RVA: 0x02D14920  token: 0x60006CF
        private System.Void _UpdateTexture(UnityEngine.Renderer meshRenderer, UnityEngine.Shader minimapTerrainShader, UnityEngine.Texture2D buildingTex) { }
        // RVA: 0x0426FE60  token: 0x60006D0
        public System.Void .ctor() { }
        // RVA: 0x03D22A30  token: 0x60006D1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000CD  // size: 0xA0
    public class UIScaleHolder : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.RectTransform m_rectTransform;  // 0x68
        private UnityEngine.RectTransform m_parentTransform;  // 0x70
        private System.Boolean m_holdValid;  // 0x78
        private UnityEngine.Vector3 _extraScale;  // 0x7c
        private System.Boolean _onlyHoldOnEnable;  // 0x88
        public UnityEngine.RectTransform referenceTransform;  // 0x90
        public System.Single animationExtraScale;  // 0x98

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x024A45B0  token: 0x60006D3
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03476030  token: 0x60006D4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02E53340  token: 0x60006D5
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02342F90  token: 0x60006D6
        private System.Boolean _IsValidScale(UnityEngine.Vector3 scale) { }
        // RVA: 0x02342A70  token: 0x60006D7
        private System.Void _HoldScale() { }
        // RVA: 0x09ADE880  token: 0x60006D8
        public System.Void SetExtraScale(UnityEngine.Vector3 extraScale) { }
        // RVA: 0x0338E990  token: 0x60006D9
        public UnityEngine.Vector3 GetExtraScale() { }
        // RVA: 0x028461E0  token: 0x60006DA
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60006DB
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60006DC
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x60006DD
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000CE  // size: 0x1C8
    public class UIScrollbar : UnityEngine.UI.Scrollbar
    {
        // Methods
        // RVA: 0x03D1C370  token: 0x60006DE
        protected virtual System.Void Awake() { }
        // RVA: 0x02849090  token: 0x60006DF
        public System.Void .ctor() { }
        // RVA: 0x09AAE8DC  token: 0x60006E0
        public System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x20000CF  // size: 0x78
    public class UIScrollbarKeyHint : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollRect m_scrollRect;  // 0x68
        private Beyond.UI.UIImage m_image;  // 0x70

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AE4DA0  token: 0x60006E2
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AE4E50  token: 0x60006E3
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x02846010  token: 0x60006E4
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60006E5
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x60006E6
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000D0  // size: 0xF8
    public class UIScrollCircle : Beyond.TickableUIMono, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.GameObject _cellTemplate;  // 0x68
        private System.Int32 _totalNum;  // 0x70
        private System.Single _tweenTime;  // 0x74
        private UnityEngine.RectTransform m_Viewport;  // 0x78
        private System.Single m_Elasticity;  // 0x80
        private System.Single _speedFactor;  // 0x84
        private System.Int32 <count>k__BackingField;  // 0x88
        public UnityEngine.Events.UnityEvent<System.Int32,System.Int32,System.Boolean> onCenterIndexChanged;  // 0x90
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;  // 0x98
        private UnityEngine.Vector2 m_PointerStartLocalCursor;  // 0xa0
        private UnityEngine.Vector2 m_tmpDragPosition;  // 0xa8
        private System.Boolean m_Dragging;  // 0xb0
        private System.Boolean m_inited;  // 0xb1
        private System.Single m_Velocity;  // 0xb4
        private UnityEngine.Vector2 m_curScreenPos;  // 0xb8
        private UnityEngine.RectTransform m_ViewRect;  // 0xc0
        private Beyond.UI.LuaPanel m_panel;  // 0xc8
        private System.Single m_radius;  // 0xd0
        private System.Single m_cellAngle;  // 0xd4
        private System.Collections.Generic.List<Beyond.UI.UIScrollCircle.Cell> m_showingCells;  // 0xd8
        private System.Single m_rangeMax;  // 0xe0
        private System.Single m_curAngle;  // 0xe4
        private System.Single m_lastAngle;  // 0xe8
        private System.Int32 m_curCenterIndex;  // 0xec
        private DG.Tweening.Tween m_tween;  // 0xf0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Single elasticity { get; /* RVA: 0x03D51B00 */ set; /* RVA: 0x03D56E80 */ }
        System.Int32 count { get; /* RVA: 0x03D4F0B0 */ set; /* RVA: 0x03D4F0E0 */ }
        System.Single velocity { get; /* RVA: 0x03D57F30 */ set; /* RVA: 0x03D57FB0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AE0618 */ }
        UnityEngine.RectTransform viewRect { get; /* RVA: 0x09AE06DC */ }

        // Methods
        // RVA: 0x09ADF150  token: 0x60006F0
        public virtual System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ADEA64  token: 0x60006F1
        public virtual System.Boolean IsActive() { }
        // RVA: 0x09ADEC48  token: 0x60006F2
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ADF0E4  token: 0x60006F3
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ADEE00  token: 0x60006F4
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE03E8  token: 0x60006F5
        private System.Void _UpdateSpeed() { }
        // RVA: 0x09ADF514  token: 0x60006F6
        private System.Boolean _CheckCanMove(System.Single deltaAngle) { }
        // RVA: 0x09ADFE6C  token: 0x60006F7
        private System.Void _TryUpdateCells() { }
        // RVA: 0x09ADFEF0  token: 0x60006F8
        private System.Void _UpdateAuto() { }
        // RVA: 0x09ADF1BC  token: 0x60006F9
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09ADF77C  token: 0x60006FA
        private System.Single _GetDeltaAngle(UnityEngine.Vector2 position) { }
        // RVA: 0x09ADF9B8  token: 0x60006FB
        private System.Void _InitCells() { }
        // RVA: 0x09ADFC64  token: 0x60006FC
        private System.Void _Init() { }
        // RVA: 0x09ADFD58  token: 0x60006FD
        private System.Void _OnAwakeInit() { }
        // RVA: 0x09AE01A0  token: 0x60006FE
        private System.Void _UpdateScrollRange() { }
        // RVA: 0x09ADF944  token: 0x60006FF
        private System.Int32 _GetRealIndex(System.Int32 index) { }
        // RVA: 0x09AE0208  token: 0x6000700
        private System.Void _UpdateShowingCells() { }
        // RVA: 0x09AE0064  token: 0x6000701
        private System.Void _UpdateCenterIndex(System.Boolean forceUpdate) { }
        // RVA: 0x09ADF598  token: 0x6000702
        private System.Void _DoScroll(System.Single tmpAngle, System.Boolean direct) { }
        // RVA: 0x09ADF22C  token: 0x6000703
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09ADF280  token: 0x6000704
        public virtual System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        // RVA: 0x09ADEBA8  token: 0x6000705
        public virtual System.Void LayoutComplete() { }
        // RVA: 0x09ADEA20  token: 0x6000706
        public virtual System.Void GraphicUpdateComplete() { }
        // RVA: 0x09ADEAB4  token: 0x6000707
        public virtual System.Boolean IsDestroyed() { }
        // RVA: 0x09ADF060  token: 0x6000708
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09ADEDA8  token: 0x6000709
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09ADF3A0  token: 0x600070A
        protected System.Void Start() { }
        // RVA: 0x09ADEBEC  token: 0x600070B
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09ADEB34  token: 0x600070C
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09ADF458  token: 0x600070D
        public System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        // RVA: 0x09ADF2D4  token: 0x600070E
        public System.Void ScrollToIndex(System.Int32 index, System.Boolean direct) { }
        // RVA: 0x09ADE974  token: 0x600070F
        public UnityEngine.GameObject Get(System.Int32 index) { }
        // RVA: 0x09ADE904  token: 0x6000710
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AE04A0  token: 0x6000711
        public System.Void .ctor() { }
        // RVA: 0x09ADF408  token: 0x6000712
        private virtual UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }
        // RVA: 0x09ADF3F0  token: 0x6000713
        private System.Void <_DoScroll>b__59_0() { }
        // RVA: 0x0577D7B4  token: 0x6000714
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x058DD8AC  token: 0x6000715
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x6000716
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x058E2A30  token: 0x6000717
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0589E548  token: 0x6000718
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000D2  // size: 0x98
    public class UIScrollContainerFollower : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollList _followTargetList;  // 0x68
        private Beyond.UI.UIScrollRect _followTargetRect;  // 0x70
        private UnityEngine.RectTransform m_rectTransform;  // 0x78
        private System.Single m_currentSize;  // 0x80
        private System.Boolean m_targetSizeChanged;  // 0x84
        private UnityEngine.Vector2 m_currentPos;  // 0x88
        private System.Boolean m_targetPosChanged;  // 0x90
        private System.Boolean m_setValid;  // 0x91
        private System.Boolean m_isFollowContent;  // 0x92

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09AE0A80  token: 0x600071C
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AE0814  token: 0x600071D
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AE0B68  token: 0x600071E
        private System.Void _RefreshSizeAndPositionToTargetContainer() { }
        // RVA: 0x03CF5340  token: 0x600071F
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000720
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0589E548  token: 0x6000721
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000D3  // size: 0x14
    public sealed struct ScrollDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.ScrollDirection Vertical;  // const
        public static Beyond.UI.ScrollDirection Horizontal;  // const

    }

    // TypeToken: 0x20000D4  // size: 0x278
    public class UIScrollList : Beyond.TickableUIMono, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        protected UnityEngine.GameObject _cellTemplate;  // 0x68
        private Beyond.UI.ScrollDirection _scrollDirection;  // 0x70
        private System.Boolean _expandCellSize;  // 0x74
        private System.Boolean _alsoExpandCellSizeInAnotherDirection;  // 0x75
        protected UnityEngine.Vector2 _space;  // 0x78
        protected Beyond.UI.UIScrollList.Padding _padding;  // 0x80
        protected System.Boolean _ignorePaddingWhenScroll;  // 0x90
        protected System.Single _notCacheBufferSize;  // 0x94
        protected System.Single _extraCacheBufferSize;  // 0x98
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;  // 0xa0
        public Beyond.DisposedUnityEvent onGraduallyShowFinish;  // 0xa8
        public Beyond.DisposedUnityEvent onScrollEnd;  // 0xb0
        public Beyond.DisposedUnityEvent<System.Int32> onUpdateCount;  // 0xb8
        public System.Func<System.Int32,System.String> getCellName;  // 0xc0
        public static Beyond.DisposedUnityEvent<System.String> s_onGraduallyShowFinish;  // static @ 0x0
        protected System.Boolean _inverse;  // 0xc8
        protected System.Boolean _autoLayoutWhenFew;  // 0xc9
        protected Beyond.UI.UIScrollList.AutoLayoutWhenFewType _autoLayoutWhenFewType;  // 0xcc
        protected System.Boolean _autoCenterInOtherDir;  // 0xd0
        private UnityEngine.Transform _centerNode;  // 0xd8
        private System.Boolean _hideRayCastWhenLessThanOnePage;  // 0xe0
        private System.Boolean _clampWhenLessThanOnePage;  // 0xe1
        private UnityEngine.UI.ScrollRect.MovementType m_lastScrollRectMovementType;  // 0xe4
        protected UnityEngine.RectTransform _container;  // 0xe8
        protected Beyond.UI.UIScrollRect _scrollRect;  // 0xf0
        private System.Int32 <count>k__BackingField;  // 0xf8
        private System.Single <containerSizeWithoutAutoLayout>k__BackingField;  // 0xfc
        protected UnityEngine.RectTransform m_rect;  // 0x100
        protected System.Int32 m_countPerLine;  // 0x108
        protected System.Int32 m_maxShowingLine;  // 0x10c
        protected System.Int32 m_maxShowingCellCount;  // 0x110
        protected System.Int32 m_maxCellCountWhenNoScroll;  // 0x114
        protected System.Single m_viewWidth;  // 0x118
        protected System.Single m_viewHeight;  // 0x11c
        protected System.Single m_cellWidth;  // 0x120
        protected System.Single m_cellHeight;  // 0x124
        protected UnityEngine.UI.Graphic m_graphic;  // 0x128
        protected Beyond.UI.UIScrollList.Padding m_realPadding;  // 0x130
        private UnityEngine.Vector3[] m_cellCorners;  // 0x140
        protected System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollList.Cell> m_showingCells;  // 0x148
        private System.Collections.Generic.Stack<Beyond.UI.UIScrollList.Cell> m_cellCache;  // 0x150
        private static System.String CACHED_CELL_GAME_OBJECT_NAME;  // const
        public UnityEngine.Events.UnityEvent onBeginDrag;  // 0x158
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0x160
        public UnityEngine.Events.UnityEvent onEndDrag;  // 0x168
        private UnityEngine.GameObject _moveTipsLeftOrTop;  // 0x170
        private UnityEngine.GameObject _moveTipsRightOrBottom;  // 0x178
        private System.Single m_moveTipsIgnoredRange;  // 0x180
        private System.Boolean _useViewEffect;  // 0x184
        private System.Boolean _symmetricViewEffect;  // 0x185
        private System.Boolean _needDummyParent;  // 0x186
        private UnityEngine.AnimationCurve _viewEffectAnimation;  // 0x188
        private UnityEngine.Vector2 _effectAnchorPoint;  // 0x190
        private System.Boolean _useDefaultScaleEffect;  // 0x198
        private UnityEngine.AnimationCurve _scaleEffectAnimation;  // 0x1a0
        private System.Boolean _useDefaultArcEffect;  // 0x1a8
        private UnityEngine.AnimationCurve _arcEffectAnimation;  // 0x1b0
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Single> onChangeView;  // 0x1b8
        protected System.Single _tweenDuration;  // 0x1c0
        protected DG.Tweening.Ease _tweenEase;  // 0x1c4
        protected System.Single _changeStepRatio;  // 0x1c8
        protected DG.Tweening.Tween m_adjustTween;  // 0x1d0
        protected System.Single m_totalLength;  // 0x1d8
        protected System.Single m_cellLength;  // 0x1dc
        protected UnityEngine.Vector2 m_centerPos;  // 0x1e0
        public System.Boolean enableAutoScroll;  // 0x1e8
        private System.Single _startAutoScrollTime;  // 0x1ec
        private System.Single _autoScrollSpeed;  // 0x1f0
        public Beyond.UI.UIArea autoScrollUpArea;  // 0x1f8
        public Beyond.UI.UIArea autoScrollDownArea;  // 0x200
        private System.Single m_curAutoScrollSpd;  // 0x208
        private System.Int32 m_autoScrollTimerKey;  // 0x20c
        private System.Boolean _enableGraduallyShow;  // 0x210
        private System.Single _graduallyShowTime;  // 0x214
        private System.Single _graduallyShowDelayTime;  // 0x218
        protected System.Boolean m_inGraduallyShow;  // 0x21c
        private System.Single m_graduallyShowedMaxIndex;  // 0x220
        protected System.Single m_curGraduallyCanShowMaxIndex;  // 0x224
        private System.Boolean m_needInformAnimationInEnd;  // 0x228
        private static System.Single GRADUALLY_SHOW_UPDATE_MAX_INTERVAL;  // const
        public static System.Int32 s_maxGraduallyShowAddCountPerFrame;  // static @ 0x8
        private System.Boolean _enableSelectedNavigation;  // 0x229
        private System.Boolean _noNavigationKeyHint;  // 0x22a
        private System.Boolean _enableNavigationLoop;  // 0x22b
        private System.Boolean _customNavigationActionId;  // 0x22c
        private System.String _customNavigationPreviousActionId;  // 0x230
        private System.String _customNavigationNextActionId;  // 0x238
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32> onSelectedCell;  // 0x240
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Boolean> onCellSelectedChanged;  // 0x248
        public System.Func<System.Int32> getCurSelectedIndex;  // 0x250
        private System.Int32 m_curSelectedIndex;  // 0x258
        private System.Int32 m_bindingGroupId;  // 0x25c
        private System.Int32 m_naviBindingGroupId;  // 0x260
        protected System.Boolean _enableWrapNavigation;  // 0x264
        protected System.Boolean _enableCircleWrapNavigation;  // 0x265
        private System.Boolean _clearNaviGroupOnUpdateCount;  // 0x266
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;  // 0x268
        private Beyond.UI.LuaPanel m_panel;  // 0x270

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55740 */ }
        UnityEngine.Vector2 space { get; /* RVA: 0x03D588C0 */ }
        System.Boolean autoLayoutWhenFew { get; /* RVA: 0x03D58400 */ }
        System.Boolean isHorizontal { get; /* RVA: 0x028C2600 */ }
        System.Boolean isVertical { get; /* RVA: 0x028C30B0 */ }
        System.Int32 count { get; /* RVA: 0x03D6C5F0 */ set; /* RVA: 0x03D6C600 */ }
        System.Single containerSizeWithoutAutoLayout { get; /* RVA: 0x03D56ED0 */ set; /* RVA: 0x03D56F50 */ }
        System.Boolean isMultiPage { get; /* RVA: 0x028C29B0 */ }
        System.Int32 maxShowingCellCount { get; /* RVA: 0x03D5D640 */ }
        System.Int32 countPerLine { get; /* RVA: 0x03D5CB40 */ }
        System.Single cellWidth { get; /* RVA: 0x03D583D0 */ }
        System.Single cellHeight { get; /* RVA: 0x03D578F0 */ }
        System.Single currentStep { get; /* RVA: 0x028C2520 */ set; /* RVA: 0x09AE4098 */ }
        Beyond.UI.UIScrollList.MoveTipsType moveTips { get; /* RVA: 0x028C2CC0 */ }
        System.Int32 curSelectedIndex { get; /* RVA: 0x09AE3F60 */ set; /* RVA: 0x09AE3FF0 */ }
        UnityEngine.GameObject curSelectedObj { get; /* RVA: 0x09AE3FCC */ }
        System.Boolean enableSelectedNavigation { get; /* RVA: 0x03D76140 */ }
        System.Int32 naviBindingGroupId { get; /* RVA: 0x03D5ADD0 */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x03080C00 */ }

        // Methods
        // RVA: 0x03B33DB0  token: 0x6000730
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0307F5E0  token: 0x6000731
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x030FE560  token: 0x6000732
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x0307F540  token: 0x6000733
        protected virtual System.Void OnEnable() { }
        // RVA: 0x030807B0  token: 0x6000734
        protected virtual System.Void OnDisable() { }
        // RVA: 0x030FE5B0  token: 0x6000735
        public System.Void TryRecalculateSize() { }
        // RVA: 0x02D9D090  token: 0x6000736
        private System.Void _InGameAwake() { }
        // RVA: 0x09AE3448  token: 0x6000737
        private System.Void _EditorAwake() { }
        // RVA: 0x02D9B5B0  token: 0x6000738
        protected virtual System.Void Init(System.Boolean isPreview) { }
        // RVA: 0x038014A0  token: 0x6000739
        protected virtual System.Void InitConfig() { }
        // RVA: 0x02D9AC60  token: 0x600073A
        protected virtual System.Void InitBasicInfo() { }
        // RVA: 0x02D9ACA0  token: 0x600073B
        protected System.Void SyncViewSize() { }
        // RVA: 0x036D16A0  token: 0x600073C
        protected virtual System.Void CalcSomeCountNum() { }
        // RVA: 0x036D1720  token: 0x600073D
        private System.Int32 _GetLineCount(System.Boolean calcVertical) { }
        // RVA: 0x028C1F00  token: 0x600073E
        protected virtual System.Void OnScroll(UnityEngine.Vector2 v) { }
        // RVA: 0x09AE3138  token: 0x600073F
        public virtual System.Void SetTop(System.Boolean needUpdate) { }
        // RVA: 0x02D9AB80  token: 0x6000740
        public virtual System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow) { }
        // RVA: 0x02D9AF40  token: 0x6000741
        public virtual System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x02D99C60  token: 0x6000742
        public virtual System.Void UpdateCount(System.Int32 newCount) { }
        // RVA: 0x038C0380  token: 0x6000743
        public System.Void UpdateShowingCells(System.Action<System.Int32,UnityEngine.GameObject> updateFunc) { }
        // RVA: 0x02D9B4F0  token: 0x6000744
        protected virtual System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount) { }
        // RVA: 0x02D9B380  token: 0x6000745
        private System.Void _SetRealPadding(System.Boolean isVerticalPadding, System.Single firstAddedLength, System.Single secondAddedLength) { }
        // RVA: 0x02D9B1A0  token: 0x6000746
        protected System.Void UpdateContainerSize() { }
        // RVA: 0x02D9B410  token: 0x6000747
        protected virtual System.Single GetContainerSize(System.Boolean ignoreAutoLayout) { }
        // RVA: 0x02D9B7C0  token: 0x6000748
        protected System.Void SetContainerSize(System.Single size) { }
        // RVA: 0x02D999C0  token: 0x6000749
        protected System.Void ClearShowingCells() { }
        // RVA: 0x028C30C0  token: 0x600074A
        protected virtual System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive) { }
        // RVA: 0x028C29C0  token: 0x600074B
        protected System.Void UpdateCell(System.Int32 index, System.Boolean forceUpdateContent, System.Boolean ignoreListActive) { }
        // RVA: 0x028C2EC0  token: 0x600074C
        public virtual UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow) { }
        // RVA: 0x09AE1424  token: 0x600074D
        public virtual UnityEngine.Vector2Int GetRangeInView() { }
        // RVA: 0x028C2050  token: 0x600074E
        protected virtual UnityEngine.Vector2Int GetNotCacheRange() { }
        // RVA: 0x028C2DD0  token: 0x600074F
        protected virtual System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        // RVA: 0x09AE27D0  token: 0x6000750
        public System.Void SetCellCanCache(System.Int32 index, System.Boolean canCache) { }
        // RVA: 0x0382FBE0  token: 0x6000751
        protected virtual System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        // RVA: 0x02BDD480  token: 0x6000752
        protected Beyond.UI.UIScrollList.Cell GetCell() { }
        // RVA: 0x09AE0F74  token: 0x6000753
        protected System.Void CacheShowingCell(System.Int32 index) { }
        // RVA: 0x09AE0EAC  token: 0x6000754
        protected System.Void CacheCell(Beyond.UI.UIScrollList.Cell cell) { }
        // RVA: 0x09AE2F0C  token: 0x6000757
        public virtual System.Void SetStepTo(System.Single step) { }
        // RVA: 0x09AE2370  token: 0x6000758
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE23D8  token: 0x6000759
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE2464  token: 0x600075A
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x028C1F70  token: 0x600075C
        private System.Void _UpdateMoveTips() { }
        // RVA: 0x028C18D0  token: 0x600075D
        public System.Void UpdateViewEffect() { }
        // RVA: 0x09AE1A14  token: 0x600075E
        public UnityEngine.GameObject Get(System.Int32 index) { }
        // RVA: 0x09AE1044  token: 0x600075F
        protected Beyond.UI.UIScrollList.Cell GetCell(System.Int32 index) { }
        // RVA: 0x02D9AC20  token: 0x6000760
        protected System.Int32 GetRealIndex(System.Int32 index) { }
        // RVA: 0x03D07E00  token: 0x6000761
        protected virtual System.Void OnRelease() { }
        // RVA: 0x039C0540  token: 0x6000762
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AE28FC  token: 0x6000763
        public System.Void SetPaddingBottom(System.Single value) { }
        // RVA: 0x09AE2A64  token: 0x6000764
        public System.Void SetPaddingTop(System.Single value) { }
        // RVA: 0x09AE29EC  token: 0x6000765
        public System.Void SetPaddingRight(System.Single value) { }
        // RVA: 0x09AE2974  token: 0x6000766
        public System.Void SetPaddingLeft(System.Single value) { }
        // RVA: 0x09AE2ADC  token: 0x6000767
        public System.Void SetPadding(UnityEngine.Rect value) { }
        // RVA: 0x03A1A490  token: 0x6000768
        public Beyond.UI.UIScrollList.Padding GetPadding() { }
        // RVA: 0x09AE18D8  token: 0x6000769
        public System.Void GetShowingCellsIndexRange(System.Int32& firstIndex, System.Int32& lastIndex) { }
        // RVA: 0x09AE2E54  token: 0x600076A
        public System.Void SetSpace(UnityEngine.Vector2 newSpace) { }
        // RVA: 0x09AE26DC  token: 0x600076B
        public virtual System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode) { }
        // RVA: 0x03080420  token: 0x600076C
        protected virtual System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x03080640  token: 0x600076D
        private System.Void _ScrollToPos(System.Single targetPos, System.Boolean fastMode) { }
        // RVA: 0x030808E0  token: 0x600076E
        protected System.Void TryClearAdjustTween() { }
        // RVA: 0x028C17A0  token: 0x600076F
        public virtual System.Single GetCenterIndex() { }
        // RVA: 0x03080490  token: 0x6000770
        protected virtual System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        // RVA: 0x02D9B8A0  token: 0x6000771
        private System.Void _InitAutoScroll() { }
        // RVA: 0x09AE3C88  token: 0x6000772
        private System.Void _OnEnterAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE3E54  token: 0x6000773
        private System.Void _OnExitAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE3B60  token: 0x6000774
        private System.Void _OnEnterAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE3DB0  token: 0x6000775
        private System.Void _OnExitAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE3EF8  token: 0x6000776
        private System.Void _SetAutoScrollSpd(System.Single spd) { }
        // RVA: 0x0307F640  token: 0x6000777
        private System.Void _UpdateAutoScroll(System.Single deltaTime) { }
        // RVA: 0x02D99CC0  token: 0x6000778
        protected System.Void RestartGraduallyShow() { }
        // RVA: 0x03080AF0  token: 0x6000779
        private System.Void _StartGraduallyShow() { }
        // RVA: 0x0307F6A0  token: 0x600077A
        private System.Void _UpdateGraduallyShow(System.Single deltaTime) { }
        // RVA: 0x09AE31F8  token: 0x600077B
        public System.Void SkipGraduallyShow() { }
        // RVA: 0x03080920  token: 0x600077C
        public System.Void StopGraduallyShow() { }
        // RVA: 0x039D1210  token: 0x6000782
        private System.Void _InitNavigation() { }
        // RVA: 0x09AE22D8  token: 0x6000783
        public System.Void NavigateSelected(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AE12D4  token: 0x6000784
        public System.Int32 GetNaviOffset(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AE1230  token: 0x6000785
        public System.Int32 GetNaviNewIndex(System.Int32 oldIndex, UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AE2BD0  token: 0x6000786
        public System.Void SetSelectedIndex(System.Int32 index, System.Boolean needNotify, System.Boolean forceUpdate, System.Boolean needScroll) { }
        // RVA: 0x09AE1AD8  token: 0x6000787
        public System.Void ListWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x02D9B9D0  token: 0x6000788
        private System.Void _InitControllerNavi() { }
        // RVA: 0x09AE3390  token: 0x6000789
        private System.Void _ClearRelatedNaviGroup() { }
        // RVA: 0x09AE117C  token: 0x600078B
        public System.Int32 GetMousePosIndex(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AE24CC  token: 0x600078C
        public System.Int32 ScreenPos2Index(UnityEngine.Vector2 targetScreenPos, UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x09AE3968  token: 0x600078D
        private System.Void _GetScreenPosLineColumnInfo(UnityEngine.Vector2 targetScreenPos, System.Int32& line, System.Int32& column) { }
        // RVA: 0x09AE10FC  token: 0x600078E
        public System.Int32 GetIndexOf(System.Int32 column, System.Int32 line) { }
        // RVA: 0x02847980  token: 0x600078F
        public System.Void .ctor() { }
        // RVA: 0x03CBC740  token: 0x6000790
        private static System.Void .cctor() { }
        // RVA: 0x09AE32BC  token: 0x6000791
        private System.Single <_ScrollToPos>b__158_0() { }
        // RVA: 0x09AE32E0  token: 0x6000792
        private System.Void <_ScrollToPos>b__158_1(System.Single x) { }
        // RVA: 0x09AE3308  token: 0x6000793
        private System.Void <_ScrollToPos>b__158_2() { }
        // RVA: 0x09AE3344  token: 0x6000794
        private System.Single <_ScrollToPos>b__158_3() { }
        // RVA: 0x09AE3368  token: 0x6000795
        private System.Void <_ScrollToPos>b__158_4(System.Single y) { }
        // RVA: 0x09AE3308  token: 0x6000796
        private System.Void <_ScrollToPos>b__158_5() { }
        // RVA: 0x09AE32A4  token: 0x6000797
        private System.Void <_OnEnterAutoScrollUp>b__171_0() { }
        // RVA: 0x09AE3294  token: 0x6000798
        private System.Void <_OnEnterAutoScrollDown>b__173_0() { }
        // RVA: 0x09AE3254  token: 0x6000799
        private System.Void <_InitNavigation>b__212_0() { }
        // RVA: 0x09AE3264  token: 0x600079A
        private System.Void <_InitNavigation>b__212_1() { }
        // RVA: 0x09AE3274  token: 0x600079B
        private System.Void <_InitNavigation>b__212_2() { }
        // RVA: 0x09AE3284  token: 0x600079C
        private System.Void <_InitNavigation>b__212_3() { }
        // RVA: 0x09AE3274  token: 0x600079D
        private System.Void <_InitNavigation>b__212_4() { }
        // RVA: 0x09AE3284  token: 0x600079E
        private System.Void <_InitNavigation>b__212_5() { }
        // RVA: 0x09AE3254  token: 0x600079F
        private System.Void <_InitNavigation>b__212_6() { }
        // RVA: 0x09AE3264  token: 0x60007A0
        private System.Void <_InitNavigation>b__212_7() { }
        // RVA: 0x058E2A30  token: 0x60007A1
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x60007A2
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0589E548  token: 0x60007A3
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8AC  token: 0x60007A4
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x60007A5
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7B4  token: 0x60007A6
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000DB  // size: 0x14
    public sealed struct AutoScrollStrategy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.AutoScrollStrategy None;  // const
        public static Beyond.UI.AutoScrollStrategy AlignNearbyBound;  // const
        public static Beyond.UI.AutoScrollStrategy AlignCenter;  // const

    }

    // TypeToken: 0x20000DC  // size: 0x1D8
    public class UIScrollRect : UnityEngine.UI.ScrollRect, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> m_scrollTween;  // 0x150
        public System.Single smoothScrollTweenSpd;  // 0x158
        public DG.Tweening.Ease smoothScrollTweenEase;  // 0x15c
        private System.Boolean m_lastUpdateIsDragging;  // 0x160
        private Beyond.UI.LuaPanel m_panel;  // 0x168
        protected System.Single _stickScrollSpeed;  // 0x170
        protected System.Single _stickScrollTolerance;  // 0x174
        protected Beyond.UI.UISelectableNaviGroup _naviGroup;  // 0x178
        protected System.Boolean _enableWrapNavigation;  // 0x180
        protected Beyond.Input.InputBindingGroupMonoTarget _scrollBindingGroup;  // 0x188
        public System.Boolean controllerScrollEnabled;  // 0x190
        private System.Boolean m_controllerInited;  // 0x191
        private System.Boolean m_navigationWrapped;  // 0x192
        protected Beyond.UI.AutoScrollStrategy _autoScrollStrategy;  // 0x194
        protected System.Single _alignBoundPaddingX;  // 0x198
        protected System.Single _alignBoundPaddingY;  // 0x19c
        private UnityEngine.GameObject _moveTipsLeftOrTop;  // 0x1a0
        private UnityEngine.GameObject _moveTipsRightOrBottom;  // 0x1a8
        private UnityEngine.Camera m_fallbackUICamera;  // 0x1b0
        private System.Boolean _enableOverScrollEffect;  // 0x1b8
        private System.Single _overScrollTriggerValue;  // 0x1bc
        private UnityEngine.GameObject _overScrollEffectPrevNode;  // 0x1c0
        private UnityEngine.GameObject _overScrollEffectNextNode;  // 0x1c8
        public Beyond.DisposedUnityEvent<System.Boolean> onOverScrollEffect;  // 0x1d0

        // Properties
        System.Boolean inScrollTween { get; /* RVA: 0x09AE4B28 */ }
        UnityEngine.Vector2 contentStartPosition { get; /* RVA: 0x03D6B170 */ set; /* RVA: 0x03D50F10 */ }
        System.Boolean dragging { get; /* RVA: 0x03D58140 */ }
        System.Boolean controllerStickScrollEnabled { get; /* RVA: 0x09AE4A7C */ }
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AE4CDC */ }
        Beyond.UI.UISelectableNaviGroup naviGroup { get; /* RVA: 0x03D56A70 */ }
        Beyond.UI.UIScrollRect.MoveTipsType moveTips { get; /* RVA: 0x09AE4B9C */ }

        // Methods
        // RVA: 0x02D9D3B0  token: 0x60007AC
        protected virtual System.Void Awake() { }
        // RVA: 0x034CF9E0  token: 0x60007AD
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03005DA0  token: 0x60007AE
        private System.Void Update() { }
        // RVA: 0x034E4FB0  token: 0x60007AF
        public System.Void ScrollTo(UnityEngine.Vector2 position, System.Boolean noTween) { }
        // RVA: 0x09AE40D4  token: 0x60007B0
        public System.Boolean IsCellViewed(UnityEngine.RectTransform cell) { }
        // RVA: 0x03C8B720  token: 0x60007B1
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x028C0DB0  token: 0x60007B2
        protected virtual System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position) { }
        // RVA: 0x030C0F80  token: 0x60007B3
        protected virtual System.Void UpdateScrollEnableNode() { }
        // RVA: 0x09AE41C0  token: 0x60007B4
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE4250  token: 0x60007B5
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE42E0  token: 0x60007B6
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0397B840  token: 0x60007B7
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0284F320  token: 0x60007B9
        protected virtual System.Void LateUpdate() { }
        // RVA: 0x03005DF0  token: 0x60007BD
        private System.Void _TickRefreshControllerStickScroll() { }
        // RVA: 0x034E51B0  token: 0x60007BE
        public System.Void ScrollToNaviTarget(UnityEngine.UI.Selectable target) { }
        // RVA: 0x09AE4388  token: 0x60007BF
        public System.Void RectWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x034CFA20  token: 0x60007C0
        private System.Void _InitController() { }
        // RVA: 0x02D99E10  token: 0x60007C1
        public System.Void WrapNavigation(UnityEngine.Events.UnityAction<UnityEngine.UI.NaviDirection> wrapper) { }
        // RVA: 0x034E5280  token: 0x60007C2
        public System.Void AutoScrollToRectTransform(UnityEngine.RectTransform target, System.Boolean noTween) { }
        // RVA: 0x03005EB0  token: 0x60007C4
        private System.Void _UpdateMoveTips() { }
        // RVA: 0x09AE4838  token: 0x60007C5
        private UnityEngine.Camera _GetUICamera() { }
        // RVA: 0x0358C870  token: 0x60007C6
        private System.Void _CheckOverScrollEffect(UnityEngine.Vector2 value) { }
        // RVA: 0x09AE465C  token: 0x60007C7
        private System.Void _CheckOverScrollOnEndDrag(UnityEngine.Vector2 value) { }
        // RVA: 0x0284A3C0  token: 0x60007C8
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60007C9
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AE463C  token: 0x60007CA
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0350B670  token: 0x60007CB
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09AE4654  token: 0x60007CC
        public System.Void <>iFixBaseProxy__CustomSetPosOnScroll(UnityEngine.Vector2 P0) { }
        // RVA: 0x09AE464C  token: 0x60007CD
        public System.Void <>iFixBaseProxy_UpdateScrollEnableNode() { }
        // RVA: 0x09AE462C  token: 0x60007CE
        public System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AE4634  token: 0x60007CF
        public System.Void <>iFixBaseProxy_OnDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AE4644  token: 0x60007D0
        public System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AE4624  token: 0x60007D1
        public System.Void <>iFixBaseProxy_LateUpdate() { }

    }

    // TypeToken: 0x20000DF  // size: 0xE8
    public class UIScrollRectEdgeRedDot : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIScrollRect m_uiScrollRect;  // 0x68
        private UnityEngine.RectTransform m_uiScrollRectTransform;  // 0x70
        private Beyond.UI.UIScrollList m_uiScrollList;  // 0x78
        private UnityEngine.UI.RectMask2D m_rectMask2D;  // 0x80
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo> m_redDotInfoDict;  // 0x88
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState> m_redDotStateDict;  // 0x90
        private UnityEngine.Vector2Int m_scrollListShowRange;  // 0x98
        public System.Func<System.Int32,System.Int32> getRedDotStateAt;  // 0xa0
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState m_upRedDotState;  // 0xa8
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState m_downRedDotState;  // 0xac
        private UnityEngine.GameObject _upNormal;  // 0xb0
        private UnityEngine.GameObject _upNew;  // 0xb8
        private UnityEngine.GameObject _downNormal;  // 0xc0
        private UnityEngine.GameObject _downNew;  // 0xc8
        private UnityEngine.RectTransform _upParent;  // 0xd0
        private UnityEngine.RectTransform _downParent;  // 0xd8
        private System.Single _upEdgeOffset;  // 0xe0
        private System.Single _downEdgeOffset;  // 0xe4

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AE6A70  token: 0x60007D6
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AE6ACC  token: 0x60007D7
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AE6C98  token: 0x60007D8
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09AE7548  token: 0x60007D9
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AE738C  token: 0x60007DA
        public System.Void ResetReferences() { }
        // RVA: 0x09AE7108  token: 0x60007DB
        public System.Void ResetRedDotPosition() { }
        // RVA: 0x09AE8030  token: 0x60007DC
        private System.Void _UpdateCacheDictForRangeChange(UnityEngine.Vector2Int newRange) { }
        // RVA: 0x09AE7F98  token: 0x60007DD
        private System.Void _OnScrollListUpdateCount(System.Int32 newCount) { }
        // RVA: 0x09AE6F50  token: 0x60007DE
        public System.Void RegisterRedDot(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew) { }
        // RVA: 0x09AE76B4  token: 0x60007DF
        public System.Void UnregisterRedDot(UnityEngine.GameObject redDotRoot) { }
        // RVA: 0x09AE6DC4  token: 0x60007E0
        public System.Void RegisterRedDotStatesForScrollList() { }
        // RVA: 0x09AE7774  token: 0x60007E1
        public System.Void UpdateRedDotStateInDir() { }
        // RVA: 0x09AE7840  token: 0x60007E2
        private System.Void _CalculateRedDotStateInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& upState, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& downState) { }
        // RVA: 0x09AE8220  token: 0x60007E3
        private System.Void _UpdateRedDotGameObjects(UnityEngine.GameObject normal, UnityEngine.GameObject newer, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state) { }
        // RVA: 0x09AE684C  token: 0x60007E4
        public System.Boolean IsRedDotInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir dir, Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo redDotInfo) { }
        // RVA: 0x09AE67F0  token: 0x60007E5
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AE83C0  token: 0x60007E6
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60007E7
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60007E8
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x60007E9
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0577D7BC  token: 0x60007EA
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000E3  // size: 0xC8
    public class UIScrollText : Beyond.TickableUIMono
    {
        // Fields
        private System.Single _speed;  // 0x68
        private System.Single _stayTime;  // 0x6c
        private System.Single _fadeTime;  // 0x70
        private UnityEngine.CanvasGroup _canvasGroup;  // 0x78
        private Beyond.UI.UIScrollText.ScrollMode _scrollMode;  // 0x80
        private System.Boolean _disableClipping;  // 0x84
        private System.Boolean m_isInited;  // 0x85
        private Beyond.UI.UIText m_tmp;  // 0x88
        private UnityEngine.RectTransform m_rect;  // 0x90
        private UnityEngine.RectTransform m_parentRect;  // 0x98
        private Beyond.UI.UIScrollText.IScrollHandler m_scrollHandler;  // 0xa0
        private Beyond.UI.UIScrollText.IAlphaHandler m_alphaHandler;  // 0xa8
        private Beyond.UI.UIScrollText.ScrollState m_state;  // 0xb0
        private System.Single m_scrollOffset;  // 0xb4
        private System.Single m_currStateTime;  // 0xb8
        private System.Boolean m_needScroll;  // 0xbc
        private System.Single m_textDiff;  // 0xc0
        private TMPro.TextAlignmentOptions m_originalAlignment;  // 0xc4

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09AE88A0  token: 0x60007F2
        private System.Void _InitIfNot() { }
        // RVA: 0x09AE8628  token: 0x60007F3
        public System.Void ResetTextScroll() { }
        // RVA: 0x09AE8B3C  token: 0x60007F4
        private System.Void _ResetTextScrollInternal(System.Boolean needScroll, System.Single textDiff) { }
        // RVA: 0x09AE85CC  token: 0x60007F5
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AE83E4  token: 0x60007F6
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AE8C58  token: 0x60007F7
        private System.Void _UpdateScrollState(System.Single deltaTime, System.Single textDiff) { }
        // RVA: 0x09AE8BF4  token: 0x60007F8
        private System.Void _ResetTextScroll() { }
        // RVA: 0x09AE8764  token: 0x60007F9
        private System.Void _ApplyTextAlignment(System.Boolean isScroll) { }
        // RVA: 0x09AE8834  token: 0x60007FA
        private System.Void _ApplyTextScroll(System.Single scrollOffset) { }
        // RVA: 0x09AE8ED8  token: 0x60007FB
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60007FC
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0589E548  token: 0x60007FD
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000EB  // size: 0x130
    public class UISelectableNaviGroup : UnityEngine.UI.SelectableNaviGroup, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Input.InputBindingGroupMonoTarget> relatedInputBindingGroups;  // 0xa0
        public System.Func<UnityEngine.UI.Selectable> getDefaultSelectableFunc;  // 0xa8
        public System.Func<System.Boolean> canFocusFun;  // 0xb0
        public System.String focusActionId;  // 0xb8
        public System.String stopFocusActionId;  // 0xc0
        public System.Boolean hideItemTipsOnUnFocus;  // 0xc8
        public System.Boolean useDefaultTargetOnFocus;  // 0xc9
        public System.Boolean useFocusHighlight;  // 0xca
        public System.Boolean focusHighlightMask;  // 0xcb
        public System.Boolean focusHighlightNormalFrame;  // 0xcc
        public System.Boolean focusHighlightDarkFrame;  // 0xcd
        public UnityEngine.RectTransform focusOverrideHighlightRect;  // 0xd0
        public System.Int32 focusPanelSortingOrder;  // 0xd8
        public Beyond.UI.UIActionKeyHint focusActionKeyHint;  // 0xe0
        public Beyond.UI.UIActionKeyHint stopFocusActionKeyHint;  // 0xe8
        public UnityEngine.Events.UnityEvent<System.Boolean> onIsFocusedChange;  // 0xf0
        private Beyond.UI.LuaPanel m_luaPanel;  // 0xf8
        private Beyond.Input.InputBindingGroupMonoTarget m_bindingMonoGroup;  // 0x100
        private UnityEngine.RectTransform m_rectTransform;  // 0x108
        private UnityEngine.UI.Selectable m_lastFocusNaviTarget;  // 0x110
        private System.String m_focusBindingText;  // 0x118
        private System.Int32 m_focusBindingId;  // 0x120
        private System.Int32 m_stopFocusBindingId;  // 0x124
        private System.Boolean m_focusBindingCreated;  // 0x128
        private System.Boolean m_isInFocusHighlight;  // 0x129
        private static System.Int32 INVALID_BINDING_ID;  // const

        // Properties
        System.Int32 FocusBindingId { get; /* RVA: 0x03D5D890 */ }
        System.Int32 StopFocusBindingId { get; /* RVA: 0x03D6DED0 */ }
        UnityEngine.UI.Selectable lastFocusNaviTarget { get; /* RVA: 0x03D56CF0 */ }

        // Methods
        // RVA: 0x02A72B70  token: 0x600080E
        private System.Void Awake() { }
        // RVA: 0x02C6F970  token: 0x600080F
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C6D3E0  token: 0x6000810
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02C6F040  token: 0x6000811
        protected virtual System.Void _OnIsTopLayerChanged() { }
        // RVA: 0x036B6330  token: 0x6000812
        protected virtual System.Void _OnSelectableNaviGroupDisabled() { }
        // RVA: 0x036B6370  token: 0x6000813
        protected virtual System.Void _BeforeSelectableNaviGroupDestroy() { }
        // RVA: 0x09AE958C  token: 0x6000814
        protected virtual System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value) { }
        // RVA: 0x02C6FC40  token: 0x6000815
        protected virtual System.Void _OnRemoveFromLayerStack() { }
        // RVA: 0x036BE780  token: 0x6000816
        public System.Void NaviToThisGroup(System.Boolean forceDefault) { }
        // RVA: 0x02C6F800  token: 0x6000817
        private System.Void _RefreshRelatedBindingGroupsState() { }
        // RVA: 0x036BE8A0  token: 0x6000818
        private UnityEngine.UI.Selectable _FindDefaultSelectable() { }
        // RVA: 0x0304D710  token: 0x6000819
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0304D850  token: 0x600081A
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AE91EC  token: 0x600081B
        public System.Void TryChangeNaviPartnerOnUp(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        // RVA: 0x09AE906C  token: 0x600081C
        public System.Void TryChangeNaviPartnerOnDown(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        // RVA: 0x09AE90EC  token: 0x600081D
        public System.Void TryChangeNaviPartnerOnLeft(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        // RVA: 0x09AE916C  token: 0x600081E
        public System.Void TryChangeNaviPartnerOnRight(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        // RVA: 0x09AE95F4  token: 0x600081F
        private System.Void _TryChangeNaviPartner(System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> list, Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        // RVA: 0x02A72DD0  token: 0x6000823
        private System.Void _InitFocusBinding() { }
        // RVA: 0x02C6EDC0  token: 0x6000824
        private System.Void _RefreshFocusBindings() { }
        // RVA: 0x09AE8F64  token: 0x6000825
        public System.Void RefreshFocusBindings() { }
        // RVA: 0x09AE92A0  token: 0x6000826
        private System.Void _OnFocus(System.Boolean onlyStartHighlight) { }
        // RVA: 0x02C6FFA0  token: 0x6000827
        private System.Void _OnStopFocus(System.Boolean onlyStopHighlight, System.Boolean ignoreTopLayerCheck) { }
        // RVA: 0x02C6FA70  token: 0x6000828
        private System.Void _RefreshFocusActionKeyHint() { }
        // RVA: 0x02C6F9F0  token: 0x6000829
        private System.Void _RefreshStopFocusActionKeyHint() { }
        // RVA: 0x09AE8F00  token: 0x600082A
        public System.Void ManuallyFocus(System.Boolean onlyStartHighlight) { }
        // RVA: 0x036B63B0  token: 0x600082B
        public System.Void ManuallyStopFocus(System.Boolean onlyStopHighlight) { }
        // RVA: 0x09AE8FB4  token: 0x600082C
        public System.Void SetFocusBindingText(System.String bindingText) { }
        // RVA: 0x03D3B220  token: 0x600082D
        public System.Void ClearLastFocusNaviTarget() { }
        // RVA: 0x03D00CB0  token: 0x600082E
        public System.Void ManuallyRefreshRelatedBindingGroups() { }
        // RVA: 0x0283A400  token: 0x600082F
        public System.Void .ctor() { }
        // RVA: 0x09AE9284  token: 0x6000830
        private System.Void <_InitFocusBinding>b__51_0() { }
        // RVA: 0x09AE9290  token: 0x6000831
        private System.Void <_InitFocusBinding>b__51_1() { }
        // RVA: 0x09AE9274  token: 0x6000832
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x04272FC0  token: 0x6000833
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AE927C  token: 0x6000834
        public System.Void <>iFixBaseProxy__OnIsTopLayerChanged() { }
        // RVA: 0x0350B670  token: 0x6000835
        public System.Void <>iFixBaseProxy__OnSelectableNaviGroupDisabled() { }
        // RVA: 0x0350B670  token: 0x6000836
        public System.Void <>iFixBaseProxy__BeforeSelectableNaviGroupDestroy() { }
        // RVA: 0x0350B670  token: 0x6000837
        public System.Void <>iFixBaseProxy__OnSetLayerSelectedTarget(UnityEngine.UI.Selectable P0) { }
        // RVA: 0x0350B670  token: 0x6000838
        public System.Void <>iFixBaseProxy__OnRemoveFromLayerStack() { }
        // RVA: 0x09AE926C  token: 0x6000839
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000ED  // size: 0x110
    public class UISemiCircleScrollList : Beyond.TickableUIMono, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        // Fields
        public UnityEngine.RectTransform content;  // 0x68
        private System.Single _innerRadius;  // 0x70
        private System.Single _outerRadius;  // 0x74
        private System.Single _padding;  // 0x78
        private System.Int32 _cellCount;  // 0x7c
        private UnityEngine.GameObject _cellPrefab;  // 0x80
        private System.Single _startAngle;  // 0x88
        private System.Boolean _reverseDirection;  // 0x8c
        private UnityEngine.RectTransform m_rectTransform;  // 0x90
        public System.Single currentAngleOffset;  // 0x98
        private System.Single m_targetAngleOffset;  // 0x9c
        private System.Single _hideAngel;  // 0xa0
        private System.Single _duration;  // 0xa4
        private System.Collections.Generic.List<UnityEngine.GameObject> m_cells;  // 0xa8
        private System.Boolean m_inEndDragAnim;  // 0xb0
        private System.Boolean m_inDragging;  // 0xb1
        protected Beyond.Input.InputBindingGroupMonoTarget _scrollBindingGroup;  // 0xb8
        protected System.Single _stickScrollTolerance;  // 0xc0
        protected System.Single _stickScrollSpeed;  // 0xc4
        private System.Int32 m_lastClosestCellIndex;  // 0xc8
        private System.Int32 m_currentCellCount;  // 0xcc
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onCellShow;  // 0xd0
        public Beyond.DisposedUnityEvent<System.Int32> onClosestCellChanged;  // 0xd8
        public Beyond.DisposedUnityEvent onDrag;  // 0xe0
        public Beyond.DisposedUnityEvent onEndDrag;  // 0xe8
        private UnityEngine.Coroutine m_dampingCoroutine;  // 0xf0
        private System.String _audioHoldStart;  // 0xf8
        private System.String _audioHoldEnd;  // 0x100
        private System.String _audioAlignment;  // 0x108

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean controllerStickScrollEnabled { get; /* RVA: 0x09AEACBC */ }

        // Methods
        // RVA: 0x09AE9E6C  token: 0x600083C
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09AE9F94  token: 0x600083D
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AEA2D8  token: 0x600083E
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09AEA974  token: 0x600083F
        private System.Void _TickRefreshControllerStickScroll() { }
        // RVA: 0x09AEA80C  token: 0x6000840
        private System.Void _InitializeCells() { }
        // RVA: 0x09AEA238  token: 0x6000841
        public System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex) { }
        // RVA: 0x09AEA344  token: 0x6000842
        public System.Void UpdateLayout() { }
        // RVA: 0x09AEA018  token: 0x6000843
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AE9D58  token: 0x6000844
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AE9F10  token: 0x6000845
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AEA150  token: 0x6000846
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AEA77C  token: 0x6000847
        private System.Collections.IEnumerator _ApplyDamping() { }
        // RVA: 0x09AEAB70  token: 0x6000848
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000849
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8A4  token: 0x600084A
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7BC  token: 0x600084B
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000EF  // size: 0x38
    public class UISemiCircleScrollListPair : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UISemiCircleScrollList m_scrollListMaster;  // 0x18
        public Beyond.UI.UISemiCircleScrollList[] m_scrollLists;  // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onCellShow;  // 0x28
        public Beyond.DisposedUnityEvent<System.Int32> onClosestCellChanged;  // 0x30

        // Methods
        // RVA: 0x09AE96E4  token: 0x6000852
        private System.Void Awake() { }
        // RVA: 0x09AE9B14  token: 0x6000853
        private System.Void _OnCellShow(UnityEngine.GameObject go, System.Int32 index) { }
        // RVA: 0x09AE9BB4  token: 0x6000854
        private System.Void _OnClosestCellChanged(System.Int32 index) { }
        // RVA: 0x09AE9C3C  token: 0x6000855
        private System.Void _OnDrag() { }
        // RVA: 0x09AE9CD8  token: 0x6000856
        private System.Void _OnEndDrag() { }
        // RVA: 0x09AE9A58  token: 0x6000857
        public System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex) { }
        // RVA: 0x0426FE60  token: 0x6000858
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0  // size: 0x90
    public class UISequenceImage : Beyond.TickableUIMono
    {
        // Fields
        public System.Boolean autoPlay;  // 0x68
        public System.Single frameRate;  // 0x6c
        public System.Collections.Generic.List<UnityEngine.Sprite> sprites;  // 0x70
        private System.Boolean <isPlaying>k__BackingField;  // 0x78
        private Beyond.UI.UIImage m_image;  // 0x80
        private System.Single m_curFrameCount;  // 0x88

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean isPlaying { get; /* RVA: 0x03D4F800 */ set; /* RVA: 0x03D4F810 */ }

        // Methods
        // RVA: 0x03B74360  token: 0x600085C
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03A53100  token: 0x600085D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03C944F0  token: 0x600085E
        protected virtual System.Void OnDisable() { }
        // RVA: 0x025C36F0  token: 0x600085F
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x03A53150  token: 0x6000860
        public System.Void Play() { }
        // RVA: 0x03C94540  token: 0x6000861
        public System.Void Stop(System.Boolean resetToFirstFrame) { }
        // RVA: 0x025C3780  token: 0x6000862
        public System.Void SetSprite(System.Int32 index) { }
        // RVA: 0x037CAF60  token: 0x6000863
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000864
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x6000865
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x6000866
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7BC  token: 0x6000867
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000F1  // size: 0x90
    public class UISimpleActiveAnimationHelper : Beyond.TickableUIMono
    {
        // Fields
        public System.Boolean isActive;  // 0x68
        public System.String toActiveAnimationName;  // 0x70
        private UnityEngine.Animation m_animation;  // 0x78
        private UnityEngine.AnimationState m_animationState;  // 0x80
        private System.Single m_animationTime;  // 0x88
        private System.Single m_curAnimationTime;  // 0x8c

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09AEAE70  token: 0x6000869
        private System.Void Start() { }
        // RVA: 0x09AEAD5C  token: 0x600086A
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AEADCC  token: 0x600086B
        public System.Void Skip() { }
        // RVA: 0x09AEAF4C  token: 0x600086C
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x03CDD650  token: 0x600086D
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x600086E
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7BC  token: 0x600086F
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000F2  // size: 0x28
    public class UISimpleStateController : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UISimpleStateController.StateInfo> _states;  // 0x18
        private System.String m_curStateName;  // 0x20

        // Properties
        System.String curStateName { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x033595F0  token: 0x6000871
        public System.Void SetState(System.String stateName) { }
        // RVA: 0x03577DE0  token: 0x6000872
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4  // size: 0x98
    public class UISizeFollower : Beyond.TickableUIMono
    {
        // Fields
        public UnityEngine.RectTransform target;  // 0x68
        public UnityEngine.Vector2 addedSize;  // 0x70
        public System.Boolean isSumSize;  // 0x78
        public System.Boolean followWidth;  // 0x79
        public System.Boolean followHeight;  // 0x7a
        public System.Boolean regulateAnchoredPosition;  // 0x7b
        public UnityEngine.Vector2 minSize;  // 0x7c
        public UnityEngine.Vector2 maxSize;  // 0x84
        private UnityEngine.RectTransform m_rectTransform;  // 0x90

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.RectTransform rectTransform { get; /* RVA: 0x02F7AE60 */ }

        // Methods
        // RVA: 0x02F7AB40  token: 0x6000878
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02F7AB80  token: 0x6000879
        public System.Void SyncSize() { }
        // RVA: 0x02846E00  token: 0x600087A
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x600087B
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000F5  // size: 0x268
    public class UISlider : UnityEngine.UI.Slider, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler, Beyond.Input.IBindingGroupTarget, Beyond.Input.IBindingView
    {
        // Fields
        public System.Single snapCenterRange;  // 0x1e8
        public System.String audioSlide;  // 0x1f0
        public System.String audioClickHandle;  // 0x1f8
        private System.Boolean m_dragging;  // 0x200
        public UnityEngine.UI.Slider.SliderEvent onEndDragSlider;  // 0x208
        public UnityEngine.UI.Slider.SliderEvent onClickSlider;  // 0x210
        public UnityEngine.UI.Slider.SliderEvent onClickSliderHandle;  // 0x218
        public System.String sliderAddActionId;  // 0x220
        public System.String sliderReduceActionId;  // 0x228
        private readonly Beyond.DisposedUnityEvent <bindingViewUpdateEvent>k__BackingField;  // 0x230
        private System.Int32 m_bindingGroupId;  // 0x238
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0x240
        public System.Boolean snapStep;  // 0x248
        public System.Single stepValue;  // 0x24c
        protected System.Boolean _enableStickScroll;  // 0x250
        protected System.Single _stickScrollTolerance;  // 0x254
        protected System.Single _stickOverPushThreshold;  // 0x258
        protected System.Int32 _stickOverPushMultiplier;  // 0x25c
        protected System.Int32 _stickScrollBatchCount;  // 0x260
        private System.Int32 m_stickScrollHoriBindingId;  // 0x264

        // Properties
        System.String bindingViewActionId { get; /* RVA: 0x03D57430 */ }
        System.String bindingViewLabelText { get; /* RVA: 0x09AEB854 */ }
        Beyond.DisposedUnityEvent bindingViewUpdateEvent { get; /* RVA: 0x03D57210 */ }
        UnityEngine.RectTransform redDotTrans { get; /* RVA: 0x01002730 */ }
        System.Boolean bindingEnabled { get; /* RVA: 0x09AEB84C */ }
        Beyond.Input.BindingViewState bindingViewState { get; /* RVA: 0x09AEB88C */ }
        System.Int32 groupId { get; /* RVA: 0x03D76180 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D56B10 */ set; /* RVA: 0x0586F120 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x09AEB988 */ }

        // Methods
        // RVA: 0x0346C960  token: 0x600087C
        private System.Void _TryPostSlideAudioEvent() { }
        // RVA: 0x031EB4A0  token: 0x600087D
        protected virtual System.Single ClampValue(System.Single input) { }
        // RVA: 0x09AEB16C  token: 0x600087E
        protected virtual System.Single CustomProcessNormalizedValue(System.Single val) { }
        // RVA: 0x0346C920  token: 0x600087F
        protected virtual System.Void OnValueChanged() { }
        // RVA: 0x09AEB340  token: 0x6000880
        protected virtual System.Void OnClickSliderBar() { }
        // RVA: 0x09AEB3C4  token: 0x6000881
        protected virtual System.Void OnClickSliderHandle() { }
        // RVA: 0x02C6F160  token: 0x6000882
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x09AEB2E4  token: 0x6000883
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AEB47C  token: 0x6000884
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02C70370  token: 0x6000885
        protected virtual System.Void Awake() { }
        // RVA: 0x025294F0  token: 0x6000886
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0361D540  token: 0x6000887
        protected virtual System.Void OnDisable() { }
        // RVA: 0x03B721E0  token: 0x6000888
        public virtual System.Void ClearComponent() { }
        // RVA: 0x03A07BD0  token: 0x6000889
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09AEB1F8  token: 0x6000890
        public virtual System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        // RVA: 0x09AEB074  token: 0x6000891
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger) { }
        // RVA: 0x09AEB0C8  token: 0x6000892
        private virtual System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger) { }
        // RVA: 0x02C703C0  token: 0x6000897
        private System.Void _InitBinding() { }
        // RVA: 0x09AEB52C  token: 0x6000898
        private System.Void _AddValue() { }
        // RVA: 0x09AEB718  token: 0x6000899
        private System.Void _ReduceValue() { }
        // RVA: 0x02C704F0  token: 0x600089A
        private System.Void _InitStickScroll() { }
        // RVA: 0x09AEB784  token: 0x600089B
        private System.Void _StickScrollHoriValue() { }
        // RVA: 0x09AEB598  token: 0x600089C
        private System.Void _ApplyStickScroll(System.Single deltaConcern) { }
        // RVA: 0x02848300  token: 0x600089D
        public System.Void .ctor() { }
        // RVA: 0x09AEB11C  token: 0x600089E
        private virtual System.Boolean Beyond.Input.IBindingView.get_interactable() { }
        // RVA: 0x09AEB51C  token: 0x600089F
        public System.Single <>iFixBaseProxy_ClampValue(System.Single P0) { }
        // RVA: 0x03D65EB0  token: 0x60008A0
        public System.Single <>iFixBaseProxy_CustomProcessNormalizedValue(System.Single P0) { }
        // RVA: 0x0350B670  token: 0x60008A1
        public System.Void <>iFixBaseProxy_OnValueChanged() { }
        // RVA: 0x0350B670  token: 0x60008A2
        public System.Void <>iFixBaseProxy_OnClickSliderBar() { }
        // RVA: 0x0350B670  token: 0x60008A3
        public System.Void <>iFixBaseProxy_OnClickSliderHandle() { }
        // RVA: 0x09ACB974  token: 0x60008A4
        public System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        // RVA: 0x09AAE8DC  token: 0x60008A5
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AEB524  token: 0x60008A6
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0361D5F0  token: 0x60008A7
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AAE8E4  token: 0x60008A8
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000F6  // size: 0x148
    public class UISoftMask : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Vector3[] m_fourCornersArray;  // 0x68
        private UnityEngine.Vector3[] m_fourCornersArrayWorld;  // 0x70
        private System.Collections.Generic.List<Beyond.UI.UISoftMaskable> m_cacheSoftMaskables;  // 0x78
        private static System.Collections.Generic.List<UnityEngine.Canvas> s_cacheCanvas;  // static @ 0x0
        private static UnityEngine.UI.Image s_image;  // static @ 0x8
        private UnityEngine.Shader _maskableDefaultShader;  // 0x80
        private UnityEngine.Shader _maskableTextShader;  // 0x88
        private static System.Int32 s_SoftMaskTexId;  // static @ 0x10
        private static System.Int32 s_SoftMaskTexSTId;  // static @ 0x14
        private static System.Int32 s_WorldToSoftMaskId;  // static @ 0x18
        private static System.Int32 s_InnerSoftMaskId;  // static @ 0x1c
        private static System.Int32 s_InnerSoftMaskUVId;  // static @ 0x20
        private static System.Int32 s_SpriteSlicedFlag;  // static @ 0x24
        private UnityEngine.Texture m_mainTexture;  // 0x90
        private UnityEngine.Vector4 m_spriteTillingOffset;  // 0x98
        private UnityEngine.Matrix4x4 m_worldToSoftMask;  // 0xa8
        private UnityEngine.Vector4 m_innerSoftMask;  // 0xe8
        private UnityEngine.Vector4 m_innerSoftMaskUV;  // 0xf8
        private Beyond.UI.UISoftMask.SlicedSpriteParams m_slicedSpriteParams;  // 0x108
        private UnityEngine.Material m_softMaskDefaultMaterial;  // 0x130
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_softMaskTextMaterials;  // 0x138
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_softMaskUIVFXMaterials;  // 0x140

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D567A0 */ }
        UnityEngine.Material softMaskDefaultMaterial { get; /* RVA: 0x03D56D00 */ }

        // Methods
        // RVA: 0x025B8940  token: 0x60008AB
        public UnityEngine.Material GetTextSoftMaskMaterial(UnityEngine.Material baseMaterial) { }
        // RVA: 0x09AEBACC  token: 0x60008AC
        public UnityEngine.Material GetUIVFXSoftMaskMaterial(UnityEngine.Material baseMaterial) { }
        // RVA: 0x09AEB9DC  token: 0x60008AD
        public UnityEngine.Vector3 GetCornerCanvas(System.Int32 i) { }
        // RVA: 0x09AEBA7C  token: 0x60008AE
        public UnityEngine.Vector3[] GetFourCornnerArrayWorld() { }
        // RVA: 0x02529A90  token: 0x60008AF
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02529940  token: 0x60008B0
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0262D2D0  token: 0x60008B1
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x02529EC0  token: 0x60008B2
        private System.Void _Clear() { }
        // RVA: 0x0252A1C0  token: 0x60008B3
        private System.Void _DestroyMaterial(UnityEngine.Material material) { }
        // RVA: 0x028033D0  token: 0x60008B4
        private System.Void _UpdateParam() { }
        // RVA: 0x028051C0  token: 0x60008B5
        private System.Void _UpdateChildren(System.Boolean markVertices, System.Boolean markMaterial) { }
        // RVA: 0x038C4F60  token: 0x60008B6
        private System.Void _OnEnableRuntimeAtlas() { }
        // RVA: 0x02846030  token: 0x60008B7
        public System.Void .ctor() { }
        // RVA: 0x03A43080  token: 0x60008B8
        private static System.Void .cctor() { }
        // RVA: 0x058DD8AC  token: 0x60008B9
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x60008BA
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x05826E68  token: 0x60008BB
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000F8  // size: 0xB0
    public class UISoftMaskable : Beyond.TickableUIMono, UnityEngine.UI.IMaterialModifier, UnityEngine.UI.IMeshModifier
    {
        // Fields
        public System.Boolean _clipMeshToSaveOverDraw;  // 0x68
        private System.Collections.Generic.List<UnityEngine.UIVertex> m_cacheVertexSteram;  // 0x70
        private System.Collections.Generic.List<UnityEngine.UIVertex> m_cacheDstVertexSteram;  // 0x78
        protected static readonly System.String UI_MINIMAP_MIST_KEYWORD;  // static @ 0x0
        protected static readonly System.String UI_VFX_PARAM;  // static @ 0x8
        private Beyond.UI.UISoftMaskable.TestLine[] m_testLinesCache;  // 0x80
        private UnityEngine.Material m_softMaskModefiedMat;  // 0x88
        private UnityEngine.UI.Graphic m_graphic;  // 0x90
        private Beyond.UI.UISoftMask m_softMask;  // 0x98
        private Beyond.UI.UIText m_uiText;  // 0xa0
        private Beyond.UI.UISoftMaskable.UIType m_uiType;  // 0xa8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.Material softMaskModefiedMat { get; /* RVA: 0x03D4EA60 */ }
        UnityEngine.UI.Graphic graphic { get; /* RVA: 0x02806650 */ }
        Beyond.UI.UISoftMask softMask { get; /* RVA: 0x025B8880 */ }
        Beyond.UI.UIText uiText { get; /* RVA: 0x09AED668 */ }

        // Methods
        // RVA: 0x025B8740  token: 0x60008C2
        public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        // RVA: 0x02806130  token: 0x60008C3
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02806030  token: 0x60008C4
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0280A340  token: 0x60008C5
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02805DE0  token: 0x60008C6
        public System.Void MarkGraphicVerticesDirty() { }
        // RVA: 0x02805EF0  token: 0x60008C7
        public System.Void MarkGraphicMaterialDirty() { }
        // RVA: 0x09AEBD88  token: 0x60008C8
        public virtual System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        // RVA: 0x09AED528  token: 0x60008C9
        private System.Boolean _Equal(System.Single a, System.Single b) { }
        // RVA: 0x09AED168  token: 0x60008CA
        private UnityEngine.Vector2 _ComputeLineCross(UnityEngine.Vector2 line0p0, UnityEngine.Vector2 line0p1, UnityEngine.Vector2 line1p0, UnityEngine.Vector2 line1p1) { }
        // RVA: 0x09AED3A8  token: 0x60008CB
        private System.Void _ComputePointAtTriangleUV(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 q, System.Single& u, System.Single& v) { }
        // RVA: 0x09AEC0BC  token: 0x60008CC
        private System.Void _ClipTriangleByClampSoftMaskUV(UnityEngine.UIVertex[] vertices, UnityEngine.UIVertex[] resultPoint, System.Boolean& canSkip) { }
        // RVA: 0x09AEBDDC  token: 0x60008CD
        private System.Void _ClipRect() { }
        // RVA: 0x025B8670  token: 0x60008CE
        public virtual System.Void ModifyMesh(UnityEngine.UI.VertexHelper vertHelper) { }
        // RVA: 0x09AED5AC  token: 0x60008CF
        private static System.Void _SetUIVertexUV(UnityEngine.UIVertex& uiVertex, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 softMaskUV) { }
        // RVA: 0x028463E0  token: 0x60008D0
        public System.Void .ctor() { }
        // RVA: 0x03CDF1E0  token: 0x60008D1
        private static System.Void .cctor() { }
        // RVA: 0x058DD8AC  token: 0x60008D2
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x60008D3
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0589E548  token: 0x60008D4
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000FB  // size: 0x40
    public class UISortingOrder : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Int32 _sortingOrderOffset;  // 0x18
        private Beyond.UI.UISortingOrder.RenderType _renderType;  // 0x1c
        private UnityEngine.Renderer m_renderer;  // 0x20
        private UnityEngine.Renderer[] m_childrenRenderers;  // 0x28
        private UnityEngine.Canvas m_canvas;  // 0x30
        private Beyond.UI.LuaPanel m_luaPanel;  // 0x38

        // Methods
        // RVA: 0x036E7FB0  token: 0x60008D5
        private System.Void OnEnable() { }
        // RVA: 0x02A73870  token: 0x60008D6
        private System.Void _GetRenderer() { }
        // RVA: 0x02A73800  token: 0x60008D7
        private System.Void _GetChildrenRenderers() { }
        // RVA: 0x02A73660  token: 0x60008D8
        private System.Void _GetCanvas() { }
        // RVA: 0x02A732B0  token: 0x60008D9
        public System.Void SetOrder(System.Int32 baseOrder) { }
        // RVA: 0x02A72A10  token: 0x60008DA
        private System.Void Awake() { }
        // RVA: 0x03A411F0  token: 0x60008DB
        private System.Void OnDestroy() { }
        // RVA: 0x038A8970  token: 0x60008DC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD  // size: 0x2A8
    public class UIStepScrollList : Beyond.UI.UIScrollList
    {
        // Fields
        public Beyond.DisposedUnityEvent<System.Int32,System.Int32> onCenterIndexChanged;  // 0x278
        public Beyond.DisposedUnityEvent onScrollOrDragEnd;  // 0x280
        public Beyond.DisposedUnityEvent onScrollOrDragStart;  // 0x288
        protected System.Single _easyDragSpdThreshold;  // 0x290
        protected System.Single _easyDragDistPercentThreshold;  // 0x294
        private System.Int32 m_startDragCenterIndex;  // 0x298
        private System.Int32 m_centerIndex;  // 0x29c
        private UnityEngine.Vector2 m_scrollStartNormalizedPos;  // 0x2a0

        // Properties
        System.Int32 centerIndex { get; /* RVA: 0x02A18F10 */ }

        // Methods
        // RVA: 0x02D9CE80  token: 0x60008DE
        protected virtual System.Void Init(System.Boolean isPreview) { }
        // RVA: 0x03801380  token: 0x60008DF
        protected virtual System.Void InitConfig() { }
        // RVA: 0x028C15F0  token: 0x60008E0
        protected virtual System.Void OnScroll(UnityEngine.Vector2 v) { }
        // RVA: 0x09AED7B4  token: 0x60008E1
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AED8B0  token: 0x60008E2
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AEDA90  token: 0x60008E3
        public virtual System.Void SetTop(System.Boolean needUpdate) { }
        // RVA: 0x028C1660  token: 0x60008E4
        protected virtual System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive) { }
        // RVA: 0x09AED730  token: 0x60008E5
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AEDC6C  token: 0x60008E6
        private System.Void _OnScrollStart(UnityEngine.Vector2 normalizedPos) { }
        // RVA: 0x09AEDB64  token: 0x60008E7
        private System.Void _OnScrollEnd(UnityEngine.Vector2 normalizedPos) { }
        // RVA: 0x09AEDCF0  token: 0x60008E8
        private System.Void _TryAutoScroll(System.Boolean isEasyDrag, System.Boolean goNext) { }
        // RVA: 0x028C1740  token: 0x60008E9
        private System.Int32 _GetClampedIndex() { }
        // RVA: 0x09AED840  token: 0x60008EA
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0284A630  token: 0x60008EB
        public System.Void .ctor() { }
        // RVA: 0x09AEDB2C  token: 0x60008EC
        public System.Void <>iFixBaseProxy_Init(System.Boolean P0) { }
        // RVA: 0x09AEDB24  token: 0x60008ED
        public System.Void <>iFixBaseProxy_InitConfig() { }
        // RVA: 0x09ADD030  token: 0x60008EE
        public System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0) { }
        // RVA: 0x09AEDB34  token: 0x60008EF
        public System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AEDB44  token: 0x60008F0
        public System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AEDB4C  token: 0x60008F1
        public System.Void <>iFixBaseProxy_SetTop(System.Boolean P0) { }
        // RVA: 0x09AEDB54  token: 0x60008F2
        public System.Void <>iFixBaseProxy_UpdateShowingCells(System.Boolean P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x09ADCFE8  token: 0x60008F3
        public System.Void <>iFixBaseProxy_ClearComponent() { }
        // RVA: 0x09AEDB3C  token: 0x60008F4
        public System.Void <>iFixBaseProxy_OnDisable() { }

    }

    // TypeToken: 0x20000FE  // size: 0x20
    public class UIStyleByState : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIStyleByState.StyleConfig> styleConfigs;  // 0x18

        // Methods
        // RVA: 0x02CD1F50  token: 0x60008F5
        private System.Void Awake() { }
        // RVA: 0x02CD0D70  token: 0x60008F6
        private System.Void OnDestroy() { }
        // RVA: 0x02CD2160  token: 0x60008F7
        public System.Void UpdateStyle() { }
        // RVA: 0x02CD2C30  token: 0x60008F8
        private System.Boolean _IsValidStyle(Beyond.UI.UIStyleByState.StyleConfig styleConfig) { }
        // RVA: 0x0367EB10  token: 0x60008F9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000101  // size: 0x28
    public class UISubtitle : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _topText;  // 0x18
        private Beyond.UI.UIText _bottomText;  // 0x20

        // Methods
        // RVA: 0x09AF691C  token: 0x60008FC
        public System.Void Start() { }
        // RVA: 0x09AF6A4C  token: 0x60008FD
        private System.Void _SetAsDefault() { }
        // RVA: 0x09AF6818  token: 0x60008FE
        public System.Void SetSubtitle(System.String subtitle, System.Boolean showOnTop) { }
        // RVA: 0x09AF696C  token: 0x60008FF
        public System.Void UpdateAlpha(System.Single alpha, System.Boolean isTop) { }
        // RVA: 0x0426FE60  token: 0x6000900
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000102  // size: 0x20
    public class UITextPair : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIText> referencedTexts;  // 0x18

        // Properties
        System.String text { get; /* RVA: 0x09AF7130 */ set; /* RVA: 0x09AF737C */ }
        UnityEngine.Color color { set; /* RVA: 0x09AF71EC */ }
        Beyond.UI.UIText first { get; /* RVA: 0x09AF7098 */ }

        // Methods
        // RVA: 0x09AF6DA8  token: 0x6000905
        public System.Void SetAndResolveTextStyle(System.String targetText) { }
        // RVA: 0x09AF6F14  token: 0x6000906
        public System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        // RVA: 0x0397CDE0  token: 0x6000907
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000103  // size: 0x270
    public class UIToggle : UnityEngine.UI.Toggle, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _onObjects;  // 0x1a8
        private System.Collections.Generic.List<UnityEngine.GameObject> _offObjects;  // 0x1b0
        private Beyond.UI.UIState.UIStateController _uiStateController;  // 0x1b8
        private System.String _onStateName;  // 0x1c0
        private System.String _offStateName;  // 0x1c8
        private System.String _onAnimation;  // 0x1d0
        private System.String _offAnimation;  // 0x1d8
        private System.String _audioToggleOn;  // 0x1e0
        private System.String _audioToggleOff;  // 0x1e8
        private System.String _audioInvalid;  // 0x1f0
        public System.Boolean _ignoreClickOnDrag;  // 0x1f8
        private UnityEngine.Vector2 <startPressPos>k__BackingField;  // 0x1fc
        private Beyond.LangKey _invalidClickLangKey;  // 0x208
        public System.Func<System.Boolean,System.Boolean> checkIsValueValid;  // 0x218
        private UnityEngine.Animation m_animation;  // 0x220
        private System.Int32 m_groupId;  // 0x228
        public System.String toggleActionId;  // 0x230
        private System.Int32 <toggleBindingId>k__BackingField;  // 0x238
        private System.Boolean m_started;  // 0x23c
        public System.String clickOnHintTextId;  // 0x240
        public System.String clickOffHintTextId;  // 0x248
        private Beyond.Input.ActionOnSetNaviTarget _actionOnSetNaviTarget;  // 0x250
        private System.Boolean _useNoHintAction;  // 0x254
        public System.String onHintTextId;  // 0x258
        public System.String offHintTextId;  // 0x260
        private System.Int32 <hoverConfirmBindingId>k__BackingField;  // 0x268

        // Properties
        UnityEngine.Vector2 startPressPos { get; /* RVA: 0x03D761F0 */ set; /* RVA: 0x03D76220 */ }
        System.Int32 toggleBindingId { get; /* RVA: 0x03D76180 */ set; /* RVA: 0x03D76230 */ }
        System.Int32 hoverConfirmBindingId { get; /* RVA: 0x03D761E0 */ set; /* RVA: 0x03D76210 */ }

        // Methods
        // RVA: 0x02C6B820  token: 0x600090C
        protected virtual System.Void Awake() { }
        // RVA: 0x02C6C0A0  token: 0x600090D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C6C030  token: 0x600090E
        protected virtual System.Void OnDisable() { }
        // RVA: 0x02C6C200  token: 0x600090F
        private System.Void _UpdateBindingEnable() { }
        // RVA: 0x09AF7AEC  token: 0x6000910
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02C6BF60  token: 0x6000911
        protected virtual System.Void Start() { }
        // RVA: 0x02C6AC20  token: 0x6000912
        protected virtual System.Void InternalToggle() { }
        // RVA: 0x02C6B8B0  token: 0x6000913
        private System.Void _InitToggleBinding() { }
        // RVA: 0x09AF7FE0  token: 0x6000914
        private System.Boolean _OnToggleFail() { }
        // RVA: 0x02C6AB90  token: 0x6000915
        public System.Void PlayAudio() { }
        // RVA: 0x02C6B770  token: 0x6000916
        protected virtual System.Void OnValueChange() { }
        // RVA: 0x02C6F0F0  token: 0x6000917
        protected virtual System.Void _NotifyIsHover(System.Boolean isHover) { }
        // RVA: 0x02C6C4E0  token: 0x6000918
        private System.Void _UpdateObjects() { }
        // RVA: 0x02C6CCA0  token: 0x6000919
        private System.Void _PlayAnimation(System.Boolean skipToEnd) { }
        // RVA: 0x03CE5950  token: 0x600091A
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09AF7BAC  token: 0x600091B
        public virtual System.Void OnInteractableChanged() { }
        // RVA: 0x09AF7A50  token: 0x600091C
        public virtual System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        // RVA: 0x09AF7D80  token: 0x600091D
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AF7C68  token: 0x600091E
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AF7E14  token: 0x600091F
        public virtual System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x03D2AFD0  token: 0x6000920
        public System.Void TryInternalToggle() { }
        // RVA: 0x09AF7BFC  token: 0x6000923
        public virtual System.Void OnNaviTargetEnabledAgain() { }
        // RVA: 0x09AF7E9C  token: 0x6000924
        protected virtual System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        // RVA: 0x02C6BBA0  token: 0x6000925
        private System.Void _InitActionOnSetNaviTarget() { }
        // RVA: 0x09AF8130  token: 0x6000926
        private System.Void _ToggleNaviInputBinding(System.Boolean active) { }
        // RVA: 0x02C6BA50  token: 0x6000927
        private System.Void _TryRefreshToggleBindingText() { }
        // RVA: 0x02C6B7D0  token: 0x6000928
        private System.Void _TryRefreshHoverConfirmBindingText() { }
        // RVA: 0x02C6BA90  token: 0x6000929
        private System.Void _TryRefreshBindingText(System.Int32 bindingId) { }
        // RVA: 0x02847F80  token: 0x600092A
        public System.Void .ctor() { }
        // RVA: 0x09AAE8DC  token: 0x600092B
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09AF7E8C  token: 0x600092C
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09AF7E84  token: 0x600092D
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AF7E7C  token: 0x600092E
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x04272FA8  token: 0x600092F
        public System.Void <>iFixBaseProxy_Start() { }
        // RVA: 0x09AF7E74  token: 0x6000930
        public System.Void <>iFixBaseProxy_InternalToggle() { }
        // RVA: 0x0350B670  token: 0x6000931
        public System.Void <>iFixBaseProxy_OnValueChange() { }
        // RVA: 0x09ACB974  token: 0x6000932
        public System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        // RVA: 0x0350B670  token: 0x6000933
        public System.Void <>iFixBaseProxy_OnInteractableChanged() { }
        // RVA: 0x09ACB954  token: 0x6000934
        public System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1) { }
        // RVA: 0x09ACB964  token: 0x6000935
        public System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AF7E94  token: 0x6000936
        public System.Void <>iFixBaseProxy_OnPointerClick(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x0968FA40  token: 0x6000937
        public System.Void <>iFixBaseProxy_OnSubmit(UnityEngine.EventSystems.BaseEventData P0) { }
        // RVA: 0x09ACB95C  token: 0x6000938
        public System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain() { }
        // RVA: 0x0350B670  token: 0x6000939
        public System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x2000104  // size: 0x48
    public class UIToggleGroup : UnityEngine.UI.ToggleGroup
    {
        // Fields
        private System.String _moveToNextActionId;  // 0x28
        private System.String _moveToPreviousActionId;  // 0x30
        private System.Boolean _inverse;  // 0x38
        private System.Int32 <moveToNextBindingId>k__BackingField;  // 0x3c
        private System.Int32 <moveToPreviousBindingId>k__BackingField;  // 0x40

        // Properties
        System.Int32 moveToNextBindingId { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Int32 moveToPreviousBindingId { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x03D4EDB0 */ }

        // Methods
        // RVA: 0x038EA450  token: 0x600093E
        protected virtual System.Void Awake() { }
        // RVA: 0x02C6D2E0  token: 0x600093F
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C6D1F0  token: 0x6000940
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AF7598  token: 0x6000941
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09AF74E8  token: 0x6000942
        public System.Void MoveToNext() { }
        // RVA: 0x09AF7540  token: 0x6000943
        public System.Void MoveToPrevious() { }
        // RVA: 0x09AF7674  token: 0x6000944
        private System.Void _MoveTo(System.Boolean isNext) { }
        // RVA: 0x03726B80  token: 0x6000945
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000946
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x02C6AE20  token: 0x6000947
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0350B670  token: 0x6000948
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0350B670  token: 0x6000949
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x2000105  // size: 0x14
    public sealed struct FingerMoveDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.FingerMoveDirection None;  // const
        public static Beyond.UI.FingerMoveDirection Anisotropy;  // const
        public static Beyond.UI.FingerMoveDirection Same;  // const

    }

    // TypeToken: 0x2000106  // size: 0x1E8
    public class UITouchPanel : Beyond.TickableUIMono, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, Beyond.Input.IBindingGroupTarget
    {
        // Fields
        private System.Single _gestureZoomSensitivity;  // 0x68
        private System.Single _dragThreshold;  // 0x6c
        private System.Single _longPressTime;  // 0x70
        private System.Single _longPressMaxDist;  // 0x74
        private System.Single _mouseZoomSensitivity;  // 0x78
        private System.Single _scrollZoomSensitivity;  // 0x7c
        private System.Boolean _useGesturePixelSizeAdjustment;  // 0x80
        private System.Single _multiClickInterval;  // 0x84
        private System.Int32 _multiClickPixelOffset;  // 0x88
        private System.Boolean _ignoreClickOnLongPress;  // 0x8c
        private System.Boolean _clickThrough;  // 0x8d
        private System.Boolean _preventPressWhenClickThrough;  // 0x8e
        private System.Boolean m_triggeredLongPress;  // 0x8f
        private System.Int32 m_clickCount;  // 0x90
        private System.Single m_lastClickTime;  // 0x94
        private UnityEngine.Vector2 m_lastClickPos;  // 0x98
        private System.Boolean m_isPress;  // 0xa0
        private System.Boolean m_isInGestureZoom;  // 0xa1
        private System.Boolean m_isActionLongPress;  // 0xa2
        private System.Boolean m_dragStarted;  // 0xa3
        private UnityEngine.Vector2 m_dragPosition;  // 0xa4
        private UnityEngine.RectTransform m_rect;  // 0xb0
        private System.Single m_deltaX;  // 0xb8
        private System.Single m_deltaY;  // 0xbc
        private UnityEngine.Vector2 m_lastFrameTouchPos;  // 0xc0
        private UnityEngine.EventSystems.PointerEventData m_touch;  // 0xc8
        private System.Int32 m_touchId;  // 0xd0
        private System.Int32 m_touchId1;  // 0xd4
        private System.Int32 m_touchId2;  // 0xd8
        private System.Single m_actionLongPressStartTime;  // 0xdc
        private UnityEngine.Vector2 m_actionLongPressStartPos;  // 0xe0
        private System.Single m_pixelSizeAdjustment;  // 0xe8
        private UnityEngine.Vector2 m_touch1Pos;  // 0xec
        private UnityEngine.Vector2 m_touch1LastPos;  // 0xf4
        private UnityEngine.Vector2 m_touch2Pos;  // 0xfc
        private UnityEngine.Vector2 m_touch2LastPos;  // 0x104
        private UnityEngine.Vector3 m_lastMousePos;  // 0x10c
        private System.Boolean m_lastFrameIsRightMouseButtonPress;  // 0x118
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onClick;  // 0x120
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onRightClick;  // 0x128
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onPress;  // 0x130
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onLongPress;  // 0x138
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDoubleClick;  // 0x140
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onRelease;  // 0x148
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;  // 0x150
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onDragBegin;  // 0x158
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onDragEnd;  // 0x160
        public Beyond.DisposedUnityEvent<System.Single> onZoom;  // 0x168
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2,Beyond.UI.FingerMoveDirection> onHorizonAndVerticalZoom;  // 0x170
        public Beyond.DisposedUnityEvent onDragToLeft;  // 0x178
        public Beyond.DisposedUnityEvent onDragToRight;  // 0x180
        public Beyond.DisposedUnityEvent onPointerEnter;  // 0x188
        public Beyond.DisposedUnityEvent onPointerExit;  // 0x190
        public Beyond.DisposedUnityEvent onDragToUp;  // 0x198
        public Beyond.DisposedUnityEvent onDragToDown;  // 0x1a0
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onRightMouseButtonPress;  // 0x1a8
        public Beyond.DisposedUnityEvent<System.Single> onScroll;  // 0x1b0
        private UnityEngine.Vector2 <curPressPos>k__BackingField;  // 0x1b8
        private System.Boolean <isPointerEntered>k__BackingField;  // 0x1c0
        public System.Boolean enableZoom;  // 0x1c1
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> rawOnDrag;  // 0x1c8
        private System.Single m_leftMousePressDownTimeWithNoCursor;  // 0x1d0
        private System.Single m_rightMousePressDownTimeWithNoCursor;  // 0x1d4
        private System.Int32 m_groupId;  // 0x1d8
        private System.Boolean m_bindingInit;  // 0x1dc
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;  // 0x1e0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55740 */ }
        UnityEngine.Vector2 touchPos { get; /* RVA: 0x09AF8438 */ }
        UnityEngine.Vector2 curPressPos { get; /* RVA: 0x03D76240 */ set; /* RVA: 0x03D76260 */ }
        System.Boolean isPointerEntered { get; /* RVA: 0x03D57BF0 */ set; /* RVA: 0x03D760A0 */ }
        System.Boolean isDragging { get; /* RVA: 0x03D5B380 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x033BE100 */ }
        System.Int32 groupId { get; /* RVA: 0x042760E8 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D56B80 */ }
        Beyond.Input.InputBindingGroupMonoTarget parent { get; /* RVA: 0x03D56B80 */ set; /* RVA: 0x05871130 */ }

        // Methods
        // RVA: 0x039766E0  token: 0x6000951
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03126350  token: 0x6000952
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x031263D0  token: 0x6000953
        public System.Void DoEndDrag(UnityEngine.Vector2 dragPos) { }
        // RVA: 0x02912830  token: 0x6000954
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284C110  token: 0x6000955
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284BF70  token: 0x6000956
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284BB10  token: 0x6000957
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03743670  token: 0x6000958
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03743620  token: 0x6000959
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284B350  token: 0x600095A
        private System.Void _OnActionPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0284BA00  token: 0x600095B
        private System.Void _OnActionRelease(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02911FB0  token: 0x600095C
        private System.Boolean _IsSameTouchFromPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x03125E30  token: 0x600095D
        public System.Void ClearTouchInfo() { }
        // RVA: 0x09AF827C  token: 0x600095E
        public virtual System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AF833C  token: 0x600095F
        public System.Void SimulateClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09AF81C8  token: 0x6000960
        public System.Void DeActiveTouch(System.Int32 touchId) { }
        // RVA: 0x03125EA0  token: 0x6000961
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0284F730  token: 0x6000962
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x024B0D70  token: 0x6000963
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x03125F20  token: 0x6000964
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03125DC0  token: 0x6000965
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0331B6F0  token: 0x6000966
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x03927ED0  token: 0x6000967
        protected virtual System.Void OnRelease() { }
        // RVA: 0x03125F60  token: 0x600096D
        public System.Void InitBinding() { }
        // RVA: 0x031261B0  token: 0x600096E
        private System.Void _UpdateState() { }
        // RVA: 0x03927F10  token: 0x600096F
        public virtual System.Void ClearComponent() { }
        // RVA: 0x028473A0  token: 0x6000970
        public System.Void .ctor() { }
        // RVA: 0x09AF83A0  token: 0x6000971
        private System.Void <InitBinding>b__110_0() { }
        // RVA: 0x09AF83EC  token: 0x6000972
        private System.Void <InitBinding>b__110_1() { }
        // RVA: 0x058E2A30  token: 0x6000973
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x6000974
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0589E548  token: 0x6000975
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8AC  token: 0x6000976
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x6000977
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x05F2CFD8  token: 0x6000978
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x0577D7B4  token: 0x6000979
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000107  // size: 0xA0
    public class UIVFXManager : Beyond.TickableUIMono, UnityEngine.UI.IMaterialModifier
    {
        // Fields
        private static System.Int32 s_vfxMainTexSTId;  // static @ 0x0
        private UnityEngine.Vector4 m_spriteTillingOffset;  // 0x68
        private UnityEngine.Material m_uiDefaultVFXMaterial;  // 0x78
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_UIVfxMaterials;  // 0x80
        private UnityEngine.Shader m_uiDefaultShader;  // 0x88
        private UnityEngine.UI.Graphic m_graphic;  // 0x90
        private Beyond.UI.UISoftMaskable m_softMaskable;  // 0x98

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.UI.Graphic graphic { get; /* RVA: 0x09AF8CC4 */ }
        Beyond.UI.UISoftMaskable softMaskable { get; /* RVA: 0x09AF8D8C */ }

        // Methods
        // RVA: 0x09AF8664  token: 0x600097D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09AF8470  token: 0x600097E
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AF8A24  token: 0x600097F
        private System.Void _OnEnableRuntimeAtlas() { }
        // RVA: 0x09AF8508  token: 0x6000980
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09AF87EC  token: 0x6000981
        private System.Void _Clear() { }
        // RVA: 0x09AF899C  token: 0x6000982
        private System.Void _DestroyMaterial(UnityEngine.Material material) { }
        // RVA: 0x09AF8A74  token: 0x6000983
        private System.Void _UpdateParam() { }
        // RVA: 0x03B0E4F0  token: 0x6000984
        public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        // RVA: 0x039AA090  token: 0x6000985
        public System.Void .ctor() { }
        // RVA: 0x03D229E0  token: 0x6000986
        private static System.Void .cctor() { }
        // RVA: 0x058DD8AC  token: 0x6000987
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x6000988
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8A4  token: 0x6000989
        public System.Void <>iFixBaseProxy_OnDisable() { }

    }

    // TypeToken: 0x2000108  // size: 0x48
    public class UIWorldLevelScrollListAnimCtrl : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo upLayoutGroup;  // 0x18
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo downLayoutGroup;  // 0x20
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo middleLayoutGroup;  // 0x28
        public UnityEngine.AnimationCurve speedCurve;  // 0x30
        private System.Collections.IEnumerator m_enumerator;  // 0x38
        private System.String _audioEnd;  // 0x40

        // Methods
        // RVA: 0x09AF9094  token: 0x600098A
        public System.Void UpdateUpPos(System.Int32 current) { }
        // RVA: 0x09AF8EC4  token: 0x600098B
        public System.Void UpdateDownPos(System.Int32 current) { }
        // RVA: 0x09AF8FA8  token: 0x600098C
        public System.Void UpdateMidPos(System.Int32 current) { }
        // RVA: 0x09AF9150  token: 0x600098D
        public System.Void UpdateWorldLevelScrollList(System.Boolean isUp, System.Int32 count) { }
        // RVA: 0x09AF8E54  token: 0x600098E
        private System.Void OnDisable() { }
        // RVA: 0x09AF91FC  token: 0x600098F
        private System.Collections.IEnumerator _ScrollLayouts(System.Boolean isUp, System.Int32 count) { }
        // RVA: 0x09AF92B0  token: 0x6000990
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010B  // size: 0x20
    public class VirtualMouseInitPos : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.LuaPanel m_panel;  // 0x18

        // Properties
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09AF9474 */ }

        // Methods
        // RVA: 0x09AF92F8  token: 0x600099A
        private System.Void OnEnable() { }
        // RVA: 0x0426FE60  token: 0x600099B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010C  // size: 0x68
    public class CSPopupPanel : UnityEngine.MonoBehaviour
    {
        // Fields
        public static System.String KEY;  // const
        public Beyond.UI.UIButton confirmBtn;  // 0x18
        public Beyond.UI.UIButton cancelBtn;  // 0x20
        public Beyond.UI.UIText contentTxt;  // 0x28
        public UnityEngine.GameObject bg1;  // 0x30
        public UnityEngine.GameObject bg2;  // 0x38
        public UnityEngine.GameObject warningImg;  // 0x40
        public Beyond.UI.UIScrollRect scrollRect;  // 0x48
        private System.Action m_onConfirm;  // 0x50
        private System.Action m_onCancel;  // 0x58
        private static Beyond.Resource.FAssetProxyHandle s_handle;  // static @ 0x0
        public static System.Collections.Generic.HashSet<Beyond.UI.CSPopupPanel> s_instances;  // static @ 0x18
        public System.Int32 timeScaleKey;  // 0x60

        // Methods
        // RVA: 0x09AEDDB4  token: 0x600099C
        private System.Void Awake() { }
        // RVA: 0x09AEE7E4  token: 0x600099D
        private System.Void _OnConfirm(UnityEngine.EventSystems.PointerEventData p) { }
        // RVA: 0x09AEE740  token: 0x600099E
        private System.Void _OnCancel(UnityEngine.EventSystems.PointerEventData p) { }
        // RVA: 0x09AEE0EC  token: 0x600099F
        private System.Void OnDestroy() { }
        // RVA: 0x09AEE2B0  token: 0x60009A0
        public static System.Void Show(System.String content, System.Action onConfirm, System.Boolean showCancel, System.Action onCancel, System.String confirmTxt, System.String cancelTxt, System.Boolean showWarning) { }
        // RVA: 0x09AEDEF8  token: 0x60009A1
        public static System.Void ClearAllPanels() { }
        // RVA: 0x0426FE60  token: 0x60009A2
        public System.Void .ctor() { }
        // RVA: 0x09AEE888  token: 0x60009A3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200010D  // size: 0x20
    public class LuaUIRoot : UnityEngine.MonoBehaviour, Beyond.ILuaCallCSharp
    {
        // Fields
        public Beyond.SerializeReferenceDictionary<System.String,Beyond.UI.LuaUIRootNode> nodeDic;  // 0x18

        // Methods
        // RVA: 0x09AEFF4C  token: 0x60009A4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010E  // size: 0x28
    public class LuaUIRootNode : UnityEngine.MonoBehaviour, Beyond.ILuaCallCSharp
    {
        // Fields
        public System.String panelName;  // 0x18
        public System.String panelFolder;  // 0x20

        // Methods
        // RVA: 0x0426FE60  token: 0x60009A5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010F  // size: 0x20
    public class MobileMotionManager : Beyond.BaseManager
    {
        // Fields
        private static System.String COMMON_MOTION_SHORT;  // const
        private static System.String COMMON_MOTION_OPERATE_SUCCESS;  // const
        private static System.String COMMON_MOTION_OPERATE_FAILURE;  // const
        private static System.String MOTION_LEVEL_LOW;  // const
        private static System.String MOTION_LEVEL_MEDIUM;  // const
        private static System.String MOTION_LEVEL_HIGH;  // const
        private Beyond.UI.MobileMotionManager.MotionLevel m_currMotionLevel;  // 0x18

        // Methods
        // RVA: 0x02CD09D0  token: 0x60009A6
        protected virtual System.Void OnInit() { }
        // RVA: 0x09AEFFCC  token: 0x60009A7
        protected virtual System.Void OnRelease() { }
        // RVA: 0x03CF76A0  token: 0x60009A8
        public System.UInt32 PostEventCommonShort() { }
        // RVA: 0x09AF0150  token: 0x60009A9
        public System.UInt32 PostEventCommonOperateSuccess() { }
        // RVA: 0x09AF00DC  token: 0x60009AA
        public System.UInt32 PostEventCommonOperateFailure() { }
        // RVA: 0x09AF01C4  token: 0x60009AB
        public System.UInt32 PostEvent(System.String eventName) { }
        // RVA: 0x02CD0800  token: 0x60009AC
        private System.Void _CheckMotionLevelAndPostIfChange() { }
        // RVA: 0x0350B670  token: 0x60009AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000111  // size: 0x10
    public static class I18nFontLoader
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,Beyond.Resource.FAssetProxyHandle> s_id2FontDic;  // static @ 0x0
        private static System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> s_name2MaterialDic;  // static @ 0x8
        private static Beyond.Resource.FAssetProxyHandle s_fontSearchDataHandle;  // static @ 0x10

        // Properties
        Beyond.I18n.I18nFontSearchData fontSearchData { get; /* RVA: 0x02860380 */ }

        // Methods
        // RVA: 0x02860540  token: 0x60009AF
        public static System.Boolean IsInvalid() { }
        // RVA: 0x09AEFD00  token: 0x60009B0
        public static UnityEngine.Material GetMaterial(System.String matName) { }
        // RVA: 0x02860000  token: 0x60009B1
        public static TMPro.TMP_FontAsset GetI18nFont(System.Int32 cnFontId) { }
        // RVA: 0x09AEFC60  token: 0x60009B2
        public static System.Int32 GetCNFontId(TMPro.TMP_FontAsset font) { }
        // RVA: 0x03113EA0  token: 0x60009B3
        public static System.Boolean IsFontDefaultMaterial(UnityEngine.Material mat) { }
        // RVA: 0x03C7B060  token: 0x60009B4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000112  // size: 0x18
    public class DynamicFontAssetLoader : TMPro.IFontAssetLoader
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> <fontAssets>k__BackingField;  // 0x10
        private static System.Collections.Generic.HashSet<System.UInt32> s_notFoundUnicodes;  // static @ 0x0

        // Properties
        System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> fontAssets { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0370A950  token: 0x60009B7
        public System.Void .ctor() { }
        // RVA: 0x03A14990  token: 0x60009B8
        public static System.Void AddNotFoundUnicode(System.UInt32 unicode, System.Boolean forceLog) { }
        // RVA: 0x09AEEAC0  token: 0x60009B9
        public virtual System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset) { }
        // RVA: 0x09AEEF18  token: 0x60009BA
        public virtual System.Void TryRemoveRefText(TMPro.TMP_Text refText) { }
        // RVA: 0x09AEE91C  token: 0x60009BB
        public System.Void Dispose() { }
        // RVA: 0x03CE4A20  token: 0x60009BC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000114  // size: 0x10
    public static class TweenUtils
    {
        // Methods
        // RVA: 0x0262E4C0  token: 0x60009C1
        public static System.Boolean TickAsCountDown(System.Single& countDown, System.Single timeDelta) { }

    }

    // TypeToken: 0x2000116  // size: 0x70
    public class UIAnimationLayerMixPlayer : Beyond.Playables.SingleMixerAssetPlayer`4
    {
        // Fields
        private UnityEngine.Animator m_target;  // 0x60
        private System.String m_outputName;  // 0x68

        // Methods
        // RVA: 0x03099F80  token: 0x60009C7
        public System.Void .ctor(UnityEngine.Animator target, System.String outputName) { }
        // RVA: 0x030995A0  token: 0x60009C8
        public System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos) { }
        // RVA: 0x02967810  token: 0x60009C9
        protected virtual UnityEngine.Playables.PlayableGraph CreateGraph() { }
        // RVA: 0x02967990  token: 0x60009CA
        protected virtual UnityEngine.Animations.AnimationLayerMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options) { }
        // RVA: 0x02967860  token: 0x60009CB
        protected virtual UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x02967640  token: 0x60009CC
        protected virtual UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta) { }

    }

    // TypeToken: 0x2000117  // size: 0x70
    public class UIAnimationMixPlayer : Beyond.Playables.SingleMixerAssetPlayer`4
    {
        // Fields
        private UnityEngine.Animator m_target;  // 0x60
        private System.String m_outputName;  // 0x68

        // Methods
        // RVA: 0x03099CE0  token: 0x60009CD
        public System.Void .ctor(UnityEngine.Animator target, System.String outputName) { }
        // RVA: 0x03099D50  token: 0x60009CE
        public System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos) { }
        // RVA: 0x02966AF0  token: 0x60009CF
        protected virtual UnityEngine.Playables.PlayableGraph CreateGraph() { }
        // RVA: 0x02966FD0  token: 0x60009D0
        protected virtual UnityEngine.Animations.AnimationMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options) { }
        // RVA: 0x02966C20  token: 0x60009D1
        protected virtual UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x02966540  token: 0x60009D2
        protected virtual UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta) { }

    }

    // TypeToken: 0x2000118
    public class UIListCache`1
    {
        // Fields
        private Beyond.UI.UIListCache.FOptions<TComp> m_options;  // 0x0
        private System.Collections.Generic.List<Beyond.UI.UIListCache.ItemWrapper<TComp>> m_items;  // 0x0
        private System.Int32 m_count;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60009D3
        public System.Void .ctor(Beyond.UI.UIListCache.FOptions<TComp> options) { }
        // RVA: -1  // not resolved  token: 0x60009D4
        public System.Void Refresh(System.Int32 count, System.Action<TComp,System.Int32> refreshFunc, System.Boolean shouldHide, System.Action<TComp,System.Int32> onDisableFunc) { }
        // RVA: -1  // not resolved  token: 0x60009D5
        public TComp GetItem(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60009D6
        private Beyond.UI.UIListCache.ItemWrapper<TComp> _CreateNewItem() { }

    }

    // TypeToken: 0x200011B  // size: 0x48
    public class UILoadImageSprite : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean isAsync;  // 0x18
        public System.Boolean setNativeSize;  // 0x19
        protected System.String m_spritePath;  // 0x20
        protected UnityEngine.UI.Image m_imageComp;  // 0x28
        protected Beyond.Resource.FAssetProxyHandle m_handle;  // 0x30

        // Properties
        System.String spritePath { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x09AF65DC */ }

        // Methods
        // RVA: 0x09AF6250  token: 0x60009DA
        private System.Void OnDestroy() { }
        // RVA: 0x09AF62B0  token: 0x60009DB
        private System.Void _LoadSprite(System.String path) { }
        // RVA: 0x0426FE60  token: 0x60009DC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011D  // size: 0x50
    public class UILoadImageSpriteByName : Beyond.UI.UILoadImageSprite
    {
        // Fields
        private System.String _folderPath;  // 0x48

        // Properties
        System.String spriteName { set; /* RVA: 0x09AF61A8 */ }

        // Methods
        // RVA: 0x0426FE60  token: 0x60009E0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011E  // size: 0x30
    public abstract class UISwitchTween
    {
        // Fields
        private Beyond.UI.UISwitchTween.Options m_options;  // 0x10
        private Beyond.UI.UISwitchTween.ITweenHandler m_tween;  // 0x20
        private System.Boolean m_isInited;  // 0x28
        private System.Boolean m_isShowing;  // 0x29
        private Beyond.UI.UISwitchTween.TweenContext m_context;  // 0x2c

        // Properties
        System.Boolean isTweening { get; /* RVA: 0x02C3C750 */ }
        System.Boolean isShow { get; /* RVA: 0x03D4F2A0 */ set; /* RVA: 0x02C3B950 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60009E1
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        // RVA: -1  // abstract  token: 0x60009E2
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        // RVA: 0x09AF6BC0  token: 0x60009E3
        protected virtual System.Void BeforeShowEffect() { }
        // RVA: 0x02C3C1E0  token: 0x60009E4
        protected virtual System.Void BeforeHideEffect() { }
        // RVA: 0x03A4EA30  token: 0x60009E5
        protected virtual System.Void AfterShowEffect() { }
        // RVA: 0x09AF6B7C  token: 0x60009E6
        protected virtual System.Void AfterHideEffect() { }
        // RVA: 0x09AF6C50  token: 0x60009E7
        protected virtual System.Void ResetToState(System.Boolean isShow) { }
        // RVA: 0x02C3BC90  token: 0x60009E8
        public System.Void Show() { }
        // RVA: 0x02C3B980  token: 0x60009E9
        public System.Void Hide() { }
        // RVA: 0x09AF6D18  token: 0x60009EA
        public System.Collections.IEnumerator WaitForTweening() { }
        // RVA: 0x09AF6CA4  token: 0x60009EB
        public System.Void SetOptions(Beyond.UI.UISwitchTween.Options options) { }
        // RVA: 0x02C3C210  token: 0x60009EF
        public System.Void Reset(System.Boolean isShow) { }
        // RVA: 0x02C3DF40  token: 0x60009F0
        public System.Void Clear() { }
        // RVA: 0x02C3C270  token: 0x60009F1
        private System.Void _ClearTweenInternal(System.Boolean isReset) { }
        // RVA: 0x09AF6C04  token: 0x60009F2
        protected Beyond.UI.UISwitchTween.TweenContext GetContext() { }
        // RVA: 0x02C3C310  token: 0x60009F3
        protected System.Void ClearTween() { }
        // RVA: 0x0350B670  token: 0x60009F4
        protected System.Void .ctor() { }
        // RVA: 0x03A4EA00  token: 0x60009F5
        private System.Void <Show>b__17_0() { }
        // RVA: 0x03CA7C40  token: 0x60009F6
        private System.Void <Hide>b__18_0() { }

    }

    // TypeToken: 0x2000125  // size: 0x58
    public class FadeSwitchTween : Beyond.UI.UISwitchTween
    {
        // Fields
        public static System.Single DEFAULT_TWEEN_DURATION;  // const
        private UnityEngine.CanvasGroup m_alphaHandler;  // 0x30
        private System.Boolean m_ignoreTimeScale;  // 0x38
        private System.Single m_activeAlpha;  // 0x3c
        private System.Boolean <dontDisableGameObject>k__BackingField;  // 0x40
        private System.Boolean <controlBlockRaycast>k__BackingField;  // 0x41
        private Beyond.UI.FadeSwitchTween.Durations <complexDuration>k__BackingField;  // 0x44
        private System.Single <duration>k__BackingField;  // 0x54

        // Properties
        System.Boolean dontDisableGameObject { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }
        System.Boolean controlBlockRaycast { get; /* RVA: 0x03D4F7B0 */ set; /* RVA: 0x03D4F7D0 */ }
        Beyond.UI.FadeSwitchTween.Durations complexDuration { get; /* RVA: 0x03D76190 */ set; /* RVA: 0x03D761A0 */ }
        System.Single duration { get; /* RVA: 0x03D4F670 */ set; /* RVA: 0x03D4F680 */ }
        UnityEngine.CanvasGroup alphaHandler { get; /* RVA: 0x01003830 */ }
        System.Single activeAlpha { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x09AEF2AC */ }

        // Methods
        // RVA: 0x09AEF288  token: 0x6000A15
        public System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Boolean ignoreTimeScale) { }
        // RVA: 0x03653350  token: 0x6000A16
        public System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Single duration, System.Boolean ignoreTimeScale) { }
        // RVA: 0x03676350  token: 0x6000A1C
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        // RVA: 0x03676490  token: 0x6000A1D
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        // RVA: 0x035FFC60  token: 0x6000A1E
        protected virtual System.Void BeforeShowEffect() { }
        // RVA: 0x035FFCC0  token: 0x6000A1F
        protected virtual System.Void AfterHideEffect() { }
        // RVA: 0x035FFD00  token: 0x6000A20
        protected virtual System.Void ResetToState(System.Boolean isShow) { }
        // RVA: 0x035FFD70  token: 0x6000A21
        protected virtual System.Void SetObjectActive(UnityEngine.CanvasGroup alphaHandler, System.Boolean isActive) { }
        // RVA: 0x09AEF238  token: 0x6000A22
        public System.Void Release() { }
        // RVA: 0x09AC3758  token: 0x6000A23
        public System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        // RVA: 0x09AC3750  token: 0x6000A24
        public System.Void <>iFixBaseProxy_AfterHideEffect() { }
        // RVA: 0x09AC3760  token: 0x6000A25
        public System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000128  // size: 0x60
    public class FadeTranslationSwitchTween : Beyond.UI.UISwitchTween
    {
        // Fields
        private static System.Single DEFAULT_TWEEN_DURATION;  // const
        private UnityEngine.CanvasGroup m_alphaHandler;  // 0x30
        private UnityEngine.RectTransform m_posHandler;  // 0x38
        private UnityEngine.Vector2 m_hidePos;  // 0x40
        private UnityEngine.Vector2 m_showPos;  // 0x48
        private System.Single m_duration;  // 0x50
        private System.Single m_hideDelay;  // 0x54
        private System.Single m_showDelay;  // 0x58

        // Methods
        // RVA: 0x09AEF814  token: 0x6000A29
        public System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, UnityEngine.RectTransform posHandler, UnityEngine.Vector2 hidePos, UnityEngine.Vector2 showPos, System.Single duration, System.Single hideDelay, System.Single showDelay) { }
        // RVA: 0x09AEF3F0  token: 0x6000A2A
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        // RVA: 0x09AEF530  token: 0x6000A2B
        protected virtual Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        // RVA: 0x09AEF38C  token: 0x6000A2C
        protected virtual System.Void BeforeShowEffect() { }
        // RVA: 0x09AEF328  token: 0x6000A2D
        protected virtual System.Void AfterHideEffect() { }
        // RVA: 0x09AEF670  token: 0x6000A2E
        protected virtual System.Void ResetToState(System.Boolean isShow) { }
        // RVA: 0x09AEF734  token: 0x6000A2F
        private System.Single _GetTargetAlpha(System.Boolean isShow) { }
        // RVA: 0x09AEF79C  token: 0x6000A30
        private UnityEngine.Vector2 _GetTargetPos(System.Boolean isShow) { }
        // RVA: 0x09AC3758  token: 0x6000A31
        public System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        // RVA: 0x09AC3750  token: 0x6000A32
        public System.Void <>iFixBaseProxy_AfterHideEffect() { }
        // RVA: 0x09AC3760  token: 0x6000A33
        public System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x200012A  // size: 0x50
    public class UIAtlasManager : Beyond.Singleton`1
    {
        // Fields
        private Beyond.TickFunction m_lateTickFunction;  // 0x10
        public static System.Int32 ATLAS_PAGE_WIDTH;  // const
        public static System.Int32 ATLAS_PAGE_HEIGHT;  // const
        public static System.Int32 IMAGE_USING_ATLAS_MAX_SIZE;  // const
        public static System.Int32 UI_IMAGE_BLOCK_ALIGNMENT;  // const
        public static System.Int32 PANEL_LEVEL_COUNT;  // const
        public static System.Int32 MAX_ATLAS_PER_PANEL_LEVEL;  // const
        public static System.Int32 PROCESS_COUNT_PER_FRAME;  // const
        public static UnityEngine.Experimental.Rendering.GraphicsFormat ATLAS_PAGE_FORMAT;  // const
        private System.Boolean m_enableRuntimeAtlas;  // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIImage> m_imageDict;  // 0x20
        private Beyond.UI.UIAtlasManager.UIAtlasPage[,] m_atlasPagePool;  // 0x28
        private System.Collections.Generic.Queue<Beyond.UI.UIImage> m_insertQueue;  // 0x30
        private System.Collections.Generic.Queue<Beyond.UI.UIAtlasManager.UIAtlasHandle> m_freeQueue;  // 0x38
        private UnityEngine.Rendering.CommandBuffer m_commandBuffer;  // 0x40
        private UnityEngine.Experimental.Rendering.GraphicsFormat m_atlasPageFormat;  // 0x48
        private static System.Boolean <enableRuntimeAtlasFromScript>k__BackingField;  // static @ 0x0

        // Properties
        System.Boolean enableRuntimeAtlas { get; /* RVA: 0x025CB4D0 */ }
        System.Boolean enableRuntimeAtlasFromScript { get; /* RVA: 0x09AF5BD8 */ set; /* RVA: 0x09AF5C10 */ }
        System.Boolean releaseImageSpriteAfterInsert { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: 0x09AF5BA0  token: 0x6000A3D
        private System.Void .ctor() { }
        // RVA: 0x09AF438C  token: 0x6000A3E
        protected System.Void OnInit() { }
        // RVA: 0x09AF458C  token: 0x6000A3F
        protected System.Void OnUnInit() { }
        // RVA: 0x09AF4660  token: 0x6000A40
        public System.Void Release() { }
        // RVA: 0x09AF4AB0  token: 0x6000A41
        private System.Void _CreateTickFunction() { }
        // RVA: 0x09AF4A48  token: 0x6000A42
        private System.Void _ClearTickFunction() { }
        // RVA: 0x09AF41DC  token: 0x6000A43
        public static System.Void AddUIImageToManager(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF45DC  token: 0x6000A44
        public static System.Void ReProcessInsertForUIImage(Beyond.UI.UIImage image) { }
        // RVA: 0x025CB630  token: 0x6000A45
        public static System.Void RemoveUIImageFromManager(Beyond.UI.UIImage image) { }
        // RVA: 0x025CB7B0  token: 0x6000A46
        public static System.Void AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF4260  token: 0x6000A47
        public System.Int32 GetAtlasCount() { }
        // RVA: 0x09AF4324  token: 0x6000A48
        public System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09AF494C  token: 0x6000A49
        private System.Void _AddUIImageToManager(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF58D4  token: 0x6000A4A
        private System.Void _ReProcessInsertForUIImage(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF5A38  token: 0x6000A4B
        private System.Void _RemoveUIImageFromManager(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF46B0  token: 0x6000A4C
        private System.Void _AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image) { }
        // RVA: 0x09AF4BD8  token: 0x6000A4D
        private System.Boolean _IsRuntimeAtlasCompatible(Beyond.UI.UIImage image, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& failureCause) { }
        // RVA: 0x09AF4EEC  token: 0x6000A4E
        private System.Void _ProcessInsertQueue() { }
        // RVA: 0x09AF561C  token: 0x6000A4F
        private System.Void _ProcessRemoveQueue() { }

    }

    // TypeToken: 0x2000130  // size: 0x30
    public class UIRedDotAnimation : Beyond.Singleton`1
    {
        // Fields
        private Beyond.UI.UIGraphicAnimation m_uiGraphicAnimation;  // 0x10
        private UnityEngine.Material m_materialInstance;  // 0x18
        private System.Collections.Generic.HashSet<Beyond.UI.UIImage> m_redDotImages;  // 0x20
        private UnityEngine.GameObject m_root;  // 0x28

        // Methods
        // RVA: 0x03CF1170  token: 0x6000A5F
        private System.Void .ctor() { }
        // RVA: 0x0399BA90  token: 0x6000A60
        public System.Void Init(UnityEngine.GameObject redDotAnimationRoot) { }
        // RVA: 0x09AF6660  token: 0x6000A61
        public System.Void UnInit() { }
        // RVA: 0x02E80D30  token: 0x6000A62
        public System.Void AddRedDotImage(Beyond.UI.UIImage img) { }
        // RVA: 0x02E80B40  token: 0x6000A63
        public System.Void RemoveRedDotImage(Beyond.UI.UIImage img) { }
        // RVA: 0x02E80E10  token: 0x6000A64
        private System.Void _UpdateRedDotAnimation() { }

    }

    // TypeToken: 0x2000131  // size: 0x20
    public class UIRedDotAnimationNode : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIImage m_image;  // 0x18

        // Methods
        // RVA: 0x036A3DA0  token: 0x6000A65
        private System.Void Awake() { }
        // RVA: 0x02E80C80  token: 0x6000A66
        private System.Void OnEnable() { }
        // RVA: 0x02E80BD0  token: 0x6000A67
        private System.Void OnDisable() { }
        // RVA: 0x0426FE60  token: 0x6000A68
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000132  // size: 0x10
    public static class WebApplication
    {
        // Methods
        // RVA: 0x09AF952C  token: 0x6000A69
        public static System.Void Start(System.String url, System.Action onClose) { }

    }

}

namespace Beyond.UI.GPUI
{

    // TypeToken: 0x2000146  // size: 0x14
    public sealed struct ChangeState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.GPUI.ChangeState Stable;  // const
        public static Beyond.UI.GPUI.ChangeState New;  // const
        public static Beyond.UI.GPUI.ChangeState ChangeSize;  // const
        public static Beyond.UI.GPUI.ChangeState ChangeData;  // const

    }

    // TypeToken: 0x2000147  // size: 0x40
    public sealed struct RuntimeNodeInfo
    {
        // Fields
        public Beyond.UI.GPUI.NodeType nodeType;  // 0x10
        public Beyond.UI.GPUI.SimpleTextAlignment textAlignment;  // 0x14
        public System.Int32 nodeIndex;  // 0x18
        public System.Int32 childNodeCount;  // 0x1c
        public System.UInt32 color;  // 0x20
        public UnityEngine.Vector2 position;  // 0x24
        public System.String textOverride;  // 0x30
        public System.Boolean changed;  // 0x38
        public System.Boolean hide;  // 0x39

    }

    // TypeToken: 0x2000148  // size: 0x28
    public class RuntimeAnimationData
    {
        // Fields
        public System.String name;  // 0x10
        public System.Single duration;  // 0x18
        public System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> template;  // 0x20

        // Methods
        // RVA: 0x02AD9170  token: 0x6000AC6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000149  // size: 0x30
    public class RuntimePrefabData
    {
        // Fields
        public System.Int32 templateNodeCount;  // 0x10
        public System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeNodeInfo> nodes;  // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.Int32> nodesNameMap;  // 0x20
        public System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeAnimationData> animations;  // 0x28

        // Methods
        // RVA: 0x02AD9750  token: 0x6000AC7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200014A  // size: 0x60
    public sealed struct GPUPrefabData
    {
        // Fields
        public UnityEngine.Vector4 uv;  // 0x10
        public UnityEngine.Vector4 aniPosScaleMinMax;  // 0x20
        public UnityEngine.Vector4 aniPosAddMinMax;  // 0x30
        public UnityEngine.Vector2 aniURange;  // 0x40
        public System.Single aniPosScaleV;  // 0x48
        public System.Single aniPosAddV;  // 0x4c
        public System.Single aniColorV;  // 0x50
        public System.Single aniDurationInv;  // 0x54
        public System.Int32 materialType;  // 0x58
        public System.UInt32 materialParam1;  // 0x5c

        // Methods
        // RVA: 0x02AD9430  token: 0x6000AC8
        public System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data) { }
        // RVA: 0x034F73A0  token: 0x6000AC9
        public System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale) { }
        // RVA: 0x034F7300  token: 0x6000ACA
        public static Beyond.UI.GPUI.GPUPrefabData CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }

    }

    // TypeToken: 0x200014B  // size: 0x40
    public sealed struct GPUPrefabDataLite
    {
        // Fields
        public System.Int16 uvX;  // 0x10
        public System.Int16 uvY;  // 0x12
        public System.Int16 uvZ;  // 0x14
        public System.Int16 uvW;  // 0x16
        public System.UInt16 aniPosScaleMinX;  // 0x18
        public System.UInt16 aniPosScaleMinY;  // 0x1a
        public System.UInt16 aniPosScaleMaxX;  // 0x1c
        public System.UInt16 aniPosScaleMaxY;  // 0x1e
        public System.UInt16 aniPosAddMinX;  // 0x20
        public System.UInt16 aniPosAddMinY;  // 0x22
        public System.UInt16 aniPosAddMaxX;  // 0x24
        public System.UInt16 aniPosAddMaxY;  // 0x26
        public System.Int16 aniURangeX;  // 0x28
        public System.Int16 aniURangeY;  // 0x2a
        public System.Int16 aniPosScaleV;  // 0x2c
        public System.Int16 aniPosAddV;  // 0x2e
        public System.Int16 aniColorV;  // 0x30
        public System.Int16 aniDuration;  // 0x32
        public System.UInt16 materialType;  // 0x34
        public System.UInt16 materialParam1;  // 0x36
        public System.UInt32 padding;  // 0x38
        public System.UInt32 padding2;  // 0x3c

        // Methods
        // RVA: 0x09B0AE8C  token: 0x6000ACB
        public System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data, UnityEngine.Vector2 texelSizeInv, UnityEngine.Vector2 aniTexelSizeInv) { }
        // RVA: 0x09B0B0E4  token: 0x6000ACC
        public System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }
        // RVA: 0x09B0AD98  token: 0x6000ACD
        public static Beyond.UI.GPUI.GPUPrefabDataLite CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }

    }

    // TypeToken: 0x200014C  // size: 0x30
    public sealed struct GPUInstanceData
    {
        // Fields
        public System.Single animeTime;  // 0x10
        public System.UInt32 color;  // 0x14
        public UnityEngine.Vector2 pos;  // 0x18
        public System.UInt16 prefabId;  // 0x20
        public System.UInt16 parentId;  // 0x22
        public System.UInt16 grandParentId;  // 0x24
        public System.Byte matType;  // 0x26
        public System.Byte drawType;  // 0x27
        public System.UInt32 padding0;  // 0x28
        public System.UInt32 padding1;  // 0x2c

    }

    // TypeToken: 0x200014D  // size: 0x14
    public sealed struct NodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.GPUI.NodeType Root;  // const
        public static Beyond.UI.GPUI.NodeType Image;  // const
        public static Beyond.UI.GPUI.NodeType Text;  // const

    }

    // TypeToken: 0x200014E  // size: 0x14
    public sealed struct SimpleTextAlignment
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.GPUI.SimpleTextAlignment Left;  // const
        public static Beyond.UI.GPUI.SimpleTextAlignment Center;  // const
        public static Beyond.UI.GPUI.SimpleTextAlignment Right;  // const

    }

    // TypeToken: 0x200014F  // size: 0x60
    public class NodeSerializeData
    {
        // Fields
        public UnityEngine.Vector4 uv;  // 0x10
        public UnityEngine.Vector4 aniPosScaleMinMax;  // 0x20
        public UnityEngine.Vector4 aniPosAddMinMax;  // 0x30
        public UnityEngine.Vector2 aniURange;  // 0x40
        public System.Single aniPosScaleV;  // 0x48
        public System.Single aniPosAddV;  // 0x4c
        public System.Single aniColorV;  // 0x50
        public System.Single aniDurationInv;  // 0x54
        public System.Int32 materialType;  // 0x58
        public System.UInt32 materialParam1;  // 0x5c

        // Methods
        // RVA: 0x0350B670  token: 0x6000ACE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000150  // size: 0x38
    public class NodeMetadata
    {
        // Fields
        public System.String nodeName;  // 0x10
        public Beyond.UI.GPUI.NodeType nodeType;  // 0x18
        public System.String nodeTextId;  // 0x20
        public System.String nodeText;  // 0x28
        public Beyond.UI.GPUI.SimpleTextAlignment textAlignment;  // 0x30
        public System.Single nodeTextSize;  // 0x34

        // Methods
        // RVA: 0x0350B670  token: 0x6000ACF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000151  // size: 0x28
    public class AnimationSerializeData
    {
        // Fields
        public System.String animationName;  // 0x10
        public System.Single animationTime;  // 0x18
        public System.Int32 totalFrames;  // 0x1c
        public UnityEngine.WrapMode wrapMode;  // 0x20
        public System.Int32 renderNodesOffset;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x6000AD0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000152  // size: 0x38
    public class PrefabSerializeData
    {
        // Fields
        public System.String prefabName;  // 0x10
        public System.Int32 nodeCount;  // 0x18
        public System.Boolean animationOnly;  // 0x1c
        public System.Collections.Generic.List<Beyond.UI.GPUI.NodeMetadata> nodeMetas;  // 0x20
        public System.Collections.Generic.List<Beyond.UI.GPUI.NodeSerializeData> renderNodes;  // 0x28
        public System.Collections.Generic.List<Beyond.UI.GPUI.AnimationSerializeData> animations;  // 0x30

        // Methods
        // RVA: 0x0354E040  token: 0x6000AD1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000153  // size: 0x38
    public class PrefabGroupSerializeData : Beyond.MemoryPack.IMemoryPackSerialize
    {
        // Fields
        public Beyond.Resource.StringPathHash spriteTexturePath;  // 0x10
        public Beyond.Resource.StringPathHash vatTexturePath;  // 0x18
        public System.Collections.Generic.List<Beyond.UI.GPUI.PrefabSerializeData> prefabs;  // 0x20
        public System.Collections.Generic.List<System.String> textIds;  // 0x28
        public System.String importantChars;  // 0x30

        // Methods
        // RVA: 0x039A00F0  token: 0x6000AD2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000154  // size: 0x18
    public sealed struct GPUIHandle : System.IEquatable`1
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.Int32 version;  // 0x14

        // Methods
        // RVA: 0x09B09030  token: 0x6000AD3
        public virtual System.Boolean Equals(Beyond.UI.GPUI.GPUIHandle other) { }
        // RVA: 0x09B0909C  token: 0x6000AD4
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09B09138  token: 0x6000AD5
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09B09238  token: 0x6000AD6
        public static System.Boolean op_Equality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right) { }
        // RVA: 0x09B092A4  token: 0x6000AD7
        public static System.Boolean op_Inequality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right) { }
        // RVA: 0x09B09188  token: 0x6000AD8
        public System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        // RVA: 0x09B091E8  token: 0x6000AD9
        public System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x2000155  // size: 0x1E0
    public class GPUISystem : UnityEngine.UI.MaskableGraphic
    {
        // Fields
        public static readonly System.String CONFIG_JSON_PATH_FORMAT;  // static @ 0x0
        public static readonly System.Int32 RENDER_GROUP_SIZE;  // static @ 0x8
        public static readonly System.Int32 RENDER_GROUP_SIZE_GL;  // static @ 0xc
        public System.Collections.Generic.List<UnityEngine.Material> materialTemplates;  // 0xe8
        public System.String configGroupName;  // 0xf0
        public System.Int32 sourceCNFontId;  // 0xf8
        private TMPro.TMP_FontAsset m_i18NFontAsset;  // 0x100
        public System.Boolean noSortingOrder;  // 0x108
        private System.Boolean m_liteMode;  // 0x109
        private System.Boolean m_inited;  // 0x10a
        private System.Boolean m_rendererDisabled;  // 0x10b
        private System.Collections.Generic.List<UnityEngine.Material> m_instancedMaterials;  // 0x110
        private UnityEngine.Texture m_vatTexture;  // 0x118
        private UnityEngine.Texture m_spriteTexture;  // 0x120
        private Beyond.Resource.FAssetProxyHandle m_vatTextureHandle;  // 0x128
        private Beyond.Resource.FAssetProxyHandle m_spriteTextureHandle;  // 0x13c
        private System.Single m_timeForShader;  // 0x150
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.GPUI.RuntimePrefabData> m_prefabMap;  // 0x158
        private UnityEngine.Transform m_targetCanvasTransform;  // 0x160
        private UnityEngine.Matrix4x4 m_canvasObjectToWorldMatrix;  // 0x168
        private System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> m_instances;  // 0x1a8
        private System.Collections.Generic.Queue<System.Int32> m_recyclePool;  // 0x1b0
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single,Beyond.UI.GPUI.GPUIHandle>> m_destroyQueue;  // 0x1b8
        private Beyond.UI.GPUI.ITextSystem m_simpleTextSystem;  // 0x1c0
        private Beyond.UI.GPUI.InstanceBufferManager m_instanceBufferManager;  // 0x1c8
        private Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabData> m_prefabBufferManager;  // 0x1d0
        private Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabDataLite> m_litePrefabBufferManager;  // 0x1d8

        // Properties
        TMPro.TMP_FontAsset fontAsset { get; /* RVA: 0x03614580 */ set; /* RVA: 0x09B0A774 */ }

        // Methods
        // RVA: 0x09B09310  token: 0x6000ADC
        public System.Boolean CreateInstance(System.String prefabName, UnityEngine.Vector3 initialPosition, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder) { }
        // RVA: 0x09B09404  token: 0x6000ADD
        public System.Boolean DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle) { }
        // RVA: 0x09B09494  token: 0x6000ADE
        public System.Boolean IsInstanceValid(Beyond.UI.GPUI.GPUIHandle handle) { }
        // RVA: 0x09B09764  token: 0x6000ADF
        public System.Boolean SetRootPosition(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector3 position) { }
        // RVA: 0x09B09868  token: 0x6000AE0
        public System.Boolean SetRootScale(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector2 scale) { }
        // RVA: 0x09B09B80  token: 0x6000AE1
        public System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.String animationName, System.Boolean resetDestroy) { }
        // RVA: 0x09B09F84  token: 0x6000AE2
        public System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.Int32 animationIndex, System.Boolean resetDestroy) { }
        // RVA: 0x09B09A80  token: 0x6000AE3
        public System.Boolean SetVisibility(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.Boolean visible) { }
        // RVA: 0x09B0960C  token: 0x6000AE4
        public System.Boolean SetColor(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, UnityEngine.Color color) { }
        // RVA: 0x09B0994C  token: 0x6000AE5
        public System.Boolean SetText(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.String text) { }
        // RVA: 0x09B094FC  token: 0x6000AE6
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x03613B80  token: 0x6000AE7
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B09558  token: 0x6000AE8
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0398A460  token: 0x6000AE9
        protected virtual System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        // RVA: 0x037E2240  token: 0x6000AEA
        protected virtual System.Void UpdateMaterial() { }
        // RVA: 0x0289C290  token: 0x6000AEB
        private System.Void _PreWillRenderCanvases() { }
        // RVA: 0x03613CD0  token: 0x6000AEC
        private System.Void _Init(System.String jsonPath) { }
        // RVA: 0x03614650  token: 0x6000AED
        protected TMPro.TMP_FontAsset GetFontAsset() { }
        // RVA: 0x0289C2D0  token: 0x6000AEE
        private System.Void _DoLateUpdate() { }
        // RVA: 0x09B0A3DC  token: 0x6000AEF
        private System.Void _DoOnDestroy() { }
        // RVA: 0x03614230  token: 0x6000AF0
        private System.Void _RefreshMaterials() { }
        // RVA: 0x03614B40  token: 0x6000AF1
        private System.Void _InitMaterials() { }
        // RVA: 0x036149B0  token: 0x6000AF2
        private System.Void _CleanMaterials() { }
        // RVA: 0x0289C430  token: 0x6000AF3
        private System.Void _RenderNodes() { }
        // RVA: 0x0289C390  token: 0x6000AF4
        private System.Void _DestroyAnimatedInstance() { }
        // RVA: 0x03614E40  token: 0x6000AF5
        private System.Void _UpdateWorldMat() { }
        // RVA: 0x02AD7250  token: 0x6000AF6
        private System.Void _PreloadTextInGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data) { }
        // RVA: 0x02AD79D0  token: 0x6000AF7
        private System.Void _LoadGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data) { }
        // RVA: 0x02AD82F0  token: 0x6000AF8
        private Beyond.UI.GPUI.RuntimePrefabData _LoadPrefabData(Beyond.UI.GPUI.PrefabSerializeData prefab) { }
        // RVA: 0x02AD91F0  token: 0x6000AF9
        private System.Int32 _LoadPrefabNodeBuffer(Beyond.UI.GPUI.PrefabSerializeData prefab, System.Int32 totalNodeCount) { }
        // RVA: 0x09B0A1C4  token: 0x6000AFA
        private System.Boolean _CreateInstance(System.String prefabName, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder) { }
        // RVA: 0x09B0A300  token: 0x6000AFB
        private System.Boolean _DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle) { }
        // RVA: 0x09B0A4E0  token: 0x6000AFC
        private Beyond.UI.GPUI.GPUIHandle _GetOneHandle() { }
        // RVA: 0x09B0A62C  token: 0x6000AFD
        private System.Boolean _IsHandleInvalid(Beyond.UI.GPUI.GPUIHandle handle) { }
        // RVA: 0x09B0A6E8  token: 0x6000AFE
        private System.Void _RecycleOneHandle(Beyond.UI.GPUI.GPUIHandle handle) { }
        // RVA: 0x02E12010  token: 0x6000AFF
        public System.Void .ctor() { }
        // RVA: 0x03CF7FA0  token: 0x6000B00
        private static System.Void .cctor() { }
        // RVA: 0x09B0A1A4  token: 0x6000B01
        public System.Void <>iFixBaseProxy_OnDestroy() { }
        // RVA: 0x09B0A1B4  token: 0x6000B02
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x09B0A1AC  token: 0x6000B03
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x09AADB34  token: 0x6000B04
        public System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }
        // RVA: 0x09B0A1BC  token: 0x6000B05
        public System.Void <>iFixBaseProxy_UpdateMaterial() { }

    }

    // TypeToken: 0x2000157  // size: 0x10
    public static class GPUIUtils
    {
        // Fields
        public static readonly UnityEngine.Vector3 DEFAULT_NORMAL;  // static @ 0x0
        public static readonly UnityEngine.Vector4 DEFAULT_TANGENT;  // static @ 0xc

        // Methods
        // RVA: 0x09B0A8F8  token: 0x6000B07
        public static UnityEngine.Mesh CreateQuadMesh() { }
        // RVA: 0x09B0A868  token: 0x6000B08
        public static System.UInt32 ColorToRGBAUint32(UnityEngine.Color color) { }
        // RVA: 0x09B0AD30  token: 0x6000B09
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000158  // size: 0x70
    public class InstanceBufferManager : System.IDisposable
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker MARKER_UPDATE_PERF;  // static @ 0x0
        private Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> m_gpuGroups;  // 0x10
        private System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> m_runtimeInstanceView;  // 0x20
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_bufferInternalNodes;  // 0x28
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_pendingNodes;  // 0x30
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_addNodes;  // 0x38
        private System.Collections.Generic.HashSet<Beyond.UI.GPUI.GPUIHandle> m_removeNodes;  // 0x40
        private System.Boolean m_hasAnyChanges;  // 0x48
        private System.Boolean m_updateBufferOnly;  // 0x49
        private System.Int32 m_currentStartIndex;  // 0x4c
        private System.Int32 m_currentLength;  // 0x50
        private System.Int32 m_capacity;  // 0x54
        private System.Int32 m_maxCapacity;  // 0x58
        private System.Int32 m_nodeStride;  // 0x5c
        private System.Int32 m_gpuGroupCapacity;  // 0x60
        private System.Int32 m_groupCount;  // 0x64
        private System.Boolean m_noSortingOrder;  // 0x68

        // Properties
        System.Int32 startIndex { get; /* RVA: 0x03D4EDF0 */ }
        System.Int32 nodeCount { get; /* RVA: 0x03D4EED0 */ }
        System.Int32 capacity { get; /* RVA: 0x03D4EEC0 */ }
        Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> gpuGroups { get; /* RVA: 0x03D30AF0 */ }
        System.Int32 gpuGroupCount { get; /* RVA: 0x03D50B30 */ }

        // Methods
        // RVA: 0x03614710  token: 0x6000B0F
        public System.Void .ctor(System.Int32 initCapacity, System.Int32 maxCapacity, System.Int32 nodeStride, System.Int32 gpuGroupCapacity, System.Boolean noSortingOrder) { }
        // RVA: 0x036146D0  token: 0x6000B10
        public System.Void BindInstanceList(System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> runtimeInstanceView) { }
        // RVA: 0x09B0B6C0  token: 0x6000B11
        public System.Void MarkNeedUpdate() { }
        // RVA: 0x09B0B7A0  token: 0x6000B12
        private System.Void _FillInstanceQueue(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& oldBuffer, System.Int32& newTotalLength, System.Int32& newTotalLengthWithEmptySlot, System.Int32& fullUpdateIndex) { }
        // RVA: 0x0289B0D0  token: 0x6000B13
        public System.Void DoUpdate(UnityEngine.CanvasRenderer canvasRenderer) { }
        // RVA: 0x09B08FA8  token: 0x6000B14
        private System.Void _NewGpuGroup(System.Int32 start, System.Int32 end) { }
        // RVA: 0x09B0B410  token: 0x6000B15
        public System.Void Add(Beyond.UI.GPUI.GPUIHandle instance) { }
        // RVA: 0x09B0B710  token: 0x6000B16
        public System.Void Remove(Beyond.UI.GPUI.GPUIHandle instance) { }
        // RVA: 0x03614880  token: 0x6000B17
        private System.Void _AllocBuffer(System.Int32 capacity) { }
        // RVA: 0x09B0B638  token: 0x6000B18
        public virtual System.Void Dispose() { }
        // RVA: 0x03D06F50  token: 0x6000B19
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200015A  // size: 0x60
    public class RuntimeInstance
    {
        // Fields
        public static System.Int32 ROOT_NODE_INDEX;  // const
        public System.Int32 version;  // 0x10
        public Beyond.UI.GPUI.ChangeState state;  // 0x14
        public System.Int32 length;  // 0x18
        public System.Int32 sortingOrder;  // 0x1c
        private Beyond.UI.GPUI.ITextSystem m_textSystem;  // 0x20
        private Beyond.UI.GPUI.RuntimePrefabData m_prefab;  // 0x28
        private Beyond.UI.GPUI.RuntimeAnimationData m_animationData;  // 0x30
        private System.Int32 m_prefabNodeOffset;  // 0x38
        private Beyond.UI.GPUI.RuntimeNodeInfo[] m_nodeInfo;  // 0x40
        private System.Int32 m_nodeInfoCount;  // 0x48
        private System.Single m_animationDuration;  // 0x4c
        private System.Single m_animationTime;  // 0x50
        private UnityEngine.Vector2 m_rootScale;  // 0x54

        // Properties
        Beyond.UI.GPUI.RuntimePrefabData Prefab { get; /* RVA: 0x03D4EAC0 */ }
        System.Single AnimationDuration { get; /* RVA: 0x03D50200 */ }

        // Methods
        // RVA: 0x09B0BE48  token: 0x6000B1C
        public System.Void Create(Beyond.UI.GPUI.RuntimePrefabData prefab, Beyond.UI.GPUI.ITextSystem textSystem) { }
        // RVA: 0x09B0C354  token: 0x6000B1D
        public System.Void Recycle() { }
        // RVA: 0x09B0BFF0  token: 0x6000B1E
        public System.Void DoUpdate(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& buffer, System.Int32 startIndexInBuffer, System.Boolean full) { }
        // RVA: 0x09B0C548  token: 0x6000B1F
        public System.Void SetRootScale(UnityEngine.Vector2 rootScale) { }
        // RVA: 0x09B0C480  token: 0x6000B20
        public System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position) { }
        // RVA: 0x09B0C7BC  token: 0x6000B21
        public System.Void StartAnimation(System.Single animationTime, System.Int32 animationIndex) { }
        // RVA: 0x09B0C738  token: 0x6000B22
        public System.Void SetVisibility(System.Int32 index, System.Boolean visible) { }
        // RVA: 0x09B0C3A8  token: 0x6000B23
        public System.Void SetColor(System.Int32 index, UnityEngine.Color newColor) { }
        // RVA: 0x09B0C5AC  token: 0x6000B24
        public System.Void SetText(System.Int32 index, System.String text) { }
        // RVA: 0x0350B670  token: 0x6000B25
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200015B
    public class SimpleBufferManager`1 : System.IDisposable
    {
        // Fields
        private System.Int32 m_objectSize;  // 0x0
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_capacity;  // 0x0
        private System.Boolean m_isFrozen;  // 0x0
        private System.Int32 m_writingRef;  // 0x0
        private UnityEngine.CanvasRenderer m_canvasRenderer;  // 0x0
        private Unity.Collections.NativeArray<T> m_cpuArray;  // 0x0

        // Properties
        Unity.Collections.NativeArray<T> cpuArray { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000B27
        public System.Void .ctor(System.Int32 initCapacity, UnityEngine.CanvasRenderer canvasRenderer) { }
        // RVA: -1  // not resolved  token: 0x6000B28
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000B29
        public System.Void Reset() { }
        // RVA: -1  // not resolved  token: 0x6000B2A
        public System.Void OpenWrite() { }
        // RVA: -1  // not resolved  token: 0x6000B2B
        public System.Void Freeze() { }
        // RVA: -1  // not resolved  token: 0x6000B2C
        public System.Boolean Allocate(System.Int32 size, System.Int32& index) { }
        // RVA: -1  // not resolved  token: 0x6000B2D
        private System.Void _Resize(System.Int32 desiredCapacity) { }

    }

    // TypeToken: 0x200015C  // size: 0x10
    public class CodePoint
    {
        // Fields
        public static System.UInt32 HIGH_SURROGATE_START;  // const
        public static System.UInt32 HIGH_SURROGATE_END;  // const
        public static System.UInt32 LOW_SURROGATE_START;  // const
        public static System.UInt32 LOW_SURROGATE_END;  // const
        public static System.UInt32 UNICODE_PLANE01_START;  // const

        // Methods
        // RVA: 0x09B08FD0  token: 0x6000B2E
        public static System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate) { }
        // RVA: 0x0350B670  token: 0x6000B2F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200015D
    public interface ITextSystem
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000B30
        public virtual System.Void RegisterCharacterToPrefabBuffer(System.String text) { }
        // RVA: -1  // abstract  token: 0x6000B31
        public virtual System.Void UploadBufferIfNeeded() { }
        // RVA: -1  // abstract  token: 0x6000B32
        public virtual System.Int32 GetNodeCount(System.String text) { }
        // RVA: -1  // abstract  token: 0x6000B33
        public virtual System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        // RVA: -1  // abstract  token: 0x6000B34
        public virtual System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }

    }

    // TypeToken: 0x200015E
    public class SimpleTextSystem`1 : Beyond.UI.GPUI.ITextSystem
    {
        // Fields
        public static System.Single DEFAULT_WHITESPACE_SPACING;  // const
        private TMPro.TMP_FontAsset m_fontAsset;  // 0x0
        private UnityEngine.Material m_tmpMaterial;  // 0x0
        private Beyond.UI.GPUI.SimpleBufferManager<T> m_prefabBufferManager;  // 0x0
        private System.Single m_padding;  // 0x0
        private UnityEngine.Vector2 m_texelSizeInv;  // 0x0
        private readonly System.Collections.Generic.List<T> m_dynamicBufferCache;  // 0x0
        private readonly System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_charCodeToIndexMap;  // 0x0
        private readonly System.Collections.Generic.List<Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>> m_tempOffsetCache;  // 0x0
        private readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>> m_charaOffsetCache;  // 0x0
        private readonly System.Int32 m_fontBufferCapacity;  // 0x0
        private readonly System.Boolean m_liteMode;  // 0x0
        private System.Boolean m_isThaiMode;  // 0x0
        private System.Int32 m_prefabDestIndex;  // 0x0
        private System.Int32 m_fontBufferCount;  // 0x0
        private readonly System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> m_creatorFunc;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000B35
        public System.Void .ctor(System.Int32 fontBufferCapacity, System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> creatorFunc) { }
        // RVA: -1  // not resolved  token: 0x6000B36
        public System.Void Init(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material tmpMaterial, Beyond.UI.GPUI.SimpleBufferManager<T> simpleBufferManager, System.Boolean isThaiMode) { }
        // RVA: -1  // not resolved  token: 0x6000B37
        public virtual System.Void RegisterCharacterToPrefabBuffer(System.String text) { }
        // RVA: -1  // not resolved  token: 0x6000B38
        public virtual System.Int32 GetNodeCount(System.String text) { }
        // RVA: -1  // not resolved  token: 0x6000B39
        public virtual System.Void UploadBufferIfNeeded() { }
        // RVA: -1  // not resolved  token: 0x6000B3A
        public virtual System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        // RVA: -1  // not resolved  token: 0x6000B3B
        public virtual System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        // RVA: -1  // not resolved  token: 0x6000B3C
        private System.Void _DoTextAlignAndDynamicBuffer(System.String text, Beyond.UI.GPUI.SimpleTextAlignment alignment, System.Single& currentX) { }
        // RVA: -1  // not resolved  token: 0x6000B3D
        private System.Void _LoadAllCharacterToPrefabBuffer(System.String text) { }
        // RVA: -1  // not resolved  token: 0x6000B3E
        private System.Int32 _PutOneCharacterToPrefabBufferDynamic(System.UInt32 c) { }
        // RVA: -1  // not resolved  token: 0x6000B3F
        private System.Void _UploadBufferIfNeeded() { }
        // RVA: -1  // not resolved  token: 0x6000B40
        private System.Void _InitPrefabDataByTMPCharacter(TMPro.TMP_Character character, T& prefabData) { }
        // RVA: -1  // not resolved  token: 0x6000B41
        protected static System.Boolean IsUpVowel(System.Char c) { }
        // RVA: -1  // not resolved  token: 0x6000B42
        protected static System.Boolean IsLowVowel(System.Char c) { }
        // RVA: -1  // not resolved  token: 0x6000B43
        protected static System.Boolean IsToneMark(System.Char c) { }
        // RVA: -1  // not resolved  token: 0x6000B44
        protected static System.Boolean IsAscenderThai(System.Char c) { }
        // RVA: -1  // not resolved  token: 0x6000B45
        protected static System.Boolean IsDescenderThai(System.Char c) { }

    }

}

namespace Beyond.UI.UIState
{

    // TypeToken: 0x2000134  // size: 0x18
    public class OnValueChangedAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        private readonly System.String <actionName>k__BackingField;  // 0x10

        // Properties
        System.String actionName { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000A6D
        public System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x2000135  // size: 0x30
    public class StateAnimationInfo
    {
        // Fields
        private System.Boolean <IsFinished>k__BackingField;  // 0x10
        private readonly UnityEngine.AnimationClip <Clip>k__BackingField;  // 0x18
        private readonly UnityEngine.GameObject <Target>k__BackingField;  // 0x20
        private System.Single <StartTime>k__BackingField;  // 0x28
        private readonly System.Single m_duration;  // 0x2c

        // Properties
        System.Boolean IsFinished { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        UnityEngine.AnimationClip Clip { get; /* RVA: 0x01041090 */ }
        UnityEngine.GameObject Target { get; /* RVA: 0x03D4EB40 */ }
        System.Single StartTime { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }

        // Methods
        // RVA: 0x02CD1CB0  token: 0x6000A74
        public System.Void .ctor(UnityEngine.AnimationClip clip, UnityEngine.GameObject target) { }
        // RVA: 0x09AF031C  token: 0x6000A75
        public System.Void OnUpdate() { }

    }

    // TypeToken: 0x2000136  // size: 0x14
    public sealed struct AnimationImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.AnimationImpactType StartAnimation;  // const
        public static Beyond.UI.UIState.AnimationImpactType StopAnimation;  // const

    }

    // TypeToken: 0x2000137  // size: 0x270
    public class StateDescription
    {
        // Fields
        public Beyond.UI.UIState.AnimationImpactType animationImpactType;  // 0x10
        public UnityEngine.AnimationClip animationClip;  // 0x18
        public UnityEngine.GameObject animationTarget;  // 0x20
        public UnityEngine.Animator animator;  // 0x28
        public Beyond.UI.UIState.AnimatorImpactType animImpact;  // 0x30
        public System.String animParamSetBoolTrue;  // 0x38
        public System.String animParamSetBoolFalse;  // 0x40
        public System.String animParamSetTrigger;  // 0x48
        public System.String animParamResetTrigger;  // 0x50
        public System.String animParamSetInteger;  // 0x58
        public System.Int32 animParamSetIntegerValue;  // 0x60
        public System.String animParamSetFloat;  // 0x68
        public System.Int32 animParamSetFloatValue;  // 0x70
        public Beyond.UI.UIButton button;  // 0x78
        public System.Boolean buttonInteractable;  // 0x80
        public UnityEngine.CanvasGroup canvasGroup;  // 0x88
        public Beyond.UI.UIState.CanvasGroupImpactType canvasGroupImpactType;  // 0x90
        public System.Single canvasGroupAlpha;  // 0x94
        public System.Boolean canvasGroupInteractable;  // 0x98
        public UnityEngine.Color canvasGroupColor;  // 0x9c
        public UnityEngine.Behaviour component;  // 0xb0
        public System.Boolean componentIsEnabled;  // 0xb8
        public Beyond.UI.UIState.StateDescriptionTargetType targetType;  // 0xbc
        public UnityEngine.GameObject gameObject;  // 0xc0
        public System.Boolean gameObjectIsActive;  // 0xc8
        public UnityEngine.UI.Graphic graphic;  // 0xd0
        public UnityEngine.Material graphicMaterial;  // 0xd8
        public UnityEngine.UI.GridLayoutGroup gridLayoutGroup;  // 0xe0
        public Beyond.UI.UIState.GridLayoutGroupImpactType gridLayoutGroupImpactType;  // 0xe8
        public UnityEngine.RectOffset gridLayoutGroupPadding;  // 0xf0
        public UnityEngine.Vector2 gridLayoutGroupSpacing;  // 0xf8
        public UnityEngine.Vector2 gridLayoutGroupCellSize;  // 0x100
        public System.Int32 gridLayoutConstraintCount;  // 0x108
        public Beyond.UI.UIImage image;  // 0x110
        public Beyond.UI.UIState.ImageImpactType imageImpact;  // 0x118
        public System.Boolean imageEnabled;  // 0x11c
        public UnityEngine.Sprite imageSetSprite;  // 0x120
        public UnityEngine.Color imageSetColor;  // 0x128
        public System.String imageSetMaterialFloatParam;  // 0x138
        public System.Single imageSetMaterialFloatValue;  // 0x140
        private UnityEngine.Material <ImageMaterialClone>k__BackingField;  // 0x148
        public UnityEngine.UI.LayoutElement layoutElement;  // 0x150
        public Beyond.UI.UIState.LayoutElementImpactType layoutElementImpactType;  // 0x158
        public System.Single layoutElementPreferredWidth;  // 0x15c
        public System.Single layoutElementPreferredHeight;  // 0x160
        public System.Single layoutElementMinWidth;  // 0x164
        public System.Single layoutElementMinHeight;  // 0x168
        public System.Single layoutElementFlexibleWidth;  // 0x16c
        public System.Single layoutElementFlexibleHeight;  // 0x170
        public UnityEngine.UI.HorizontalOrVerticalLayoutGroup layoutGroup;  // 0x178
        public Beyond.UI.UIState.LayoutGroupImpactType layoutGroupImpactType;  // 0x180
        public UnityEngine.RectOffset layoutGroupPadding;  // 0x188
        public System.Single layoutGroupSpacing;  // 0x190
        public UnityEngine.TextAnchor layoutGroupChildAlignment;  // 0x194
        public System.Boolean layoutGroupReverseArrangement;  // 0x198
        public UnityEngine.RectTransform rectTransform;  // 0x1a0
        public Beyond.UI.UIState.RectTransformImpactType rectTransformImpactType;  // 0x1a8
        public UnityEngine.Vector2 rectTransformPosition;  // 0x1ac
        public UnityEngine.Vector2 rectTransformSize;  // 0x1b4
        public UnityEngine.Vector3 rectTransformRotation;  // 0x1bc
        public UnityEngine.Vector3 rectTransformScale;  // 0x1c8
        public System.Single rectTransformWidth;  // 0x1d4
        public System.Single rectTransformHeight;  // 0x1d8
        public System.Single rectTransformTop;  // 0x1dc
        public System.Single rectTransformBottom;  // 0x1e0
        public System.Single rectTransformLeft;  // 0x1e4
        public System.Single rectTransformRight;  // 0x1e8
        public UnityEngine.Vector2 rectTransformAnchorMin;  // 0x1ec
        public UnityEngine.Vector2 rectTransformAnchorMax;  // 0x1f4
        public UnityEngine.Vector2 rectTransformPivot;  // 0x1fc
        public Beyond.UI.UIScrollList scrollList;  // 0x208
        public Beyond.UI.UIState.ScrollListImpactType scrollListImpactType;  // 0x210
        public Beyond.UI.UIScrollList.Padding scrollListPadding;  // 0x214
        public Beyond.UI.UIState.UIStateController uiStateController;  // 0x228
        public System.String stateName;  // 0x230
        public Beyond.UI.UIText text;  // 0x238
        public Beyond.UI.UIState.TextImpactType textImpact;  // 0x240
        public UnityEngine.Color textColor;  // 0x244
        public System.String textId;  // 0x258
        public System.Single textFontSize;  // 0x260
        public System.Single textMaxFontSize;  // 0x264
        public TMPro.HorizontalAlignmentOptions textHorizontalAlignment;  // 0x268

        // Properties
        System.Boolean IsEmpty { get; /* RVA: 0x02CD47B0 */ }
        System.String ReadableDescription { get; /* RVA: 0x09AF21D0 */ }
        UnityEngine.Material ImageMaterialClone { get; /* RVA: 0x03D571B0 */ set; /* RVA: 0x058B3DA8 */ }

        // Methods
        // RVA: 0x09AF08F0  token: 0x6000A76
        public System.Boolean EqualsAnimation(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD1D10  token: 0x6000A77
        public System.Single ApplyAnimation(Beyond.UI.UIState.StateReference state) { }
        // RVA: 0x09AF0988  token: 0x6000A78
        public System.Boolean EqualsAnimator(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF03CC  token: 0x6000A79
        public System.Void ApplyAnimator() { }
        // RVA: 0x09AF0A20  token: 0x6000A7A
        public System.Boolean EqualsButton(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF04F0  token: 0x6000A7B
        public System.Void ApplyButton() { }
        // RVA: 0x09AF0AB8  token: 0x6000A7C
        public System.Boolean EqualsCanvasGroup(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x03D06C50  token: 0x6000A7D
        public System.Void ApplyCanvasGroup() { }
        // RVA: 0x09AF0B58  token: 0x6000A7E
        public System.Boolean EqualsComponent(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF0550  token: 0x6000A7F
        public System.Void ApplyComponent() { }
        // RVA: 0x09AF13B8  token: 0x6000A82
        public virtual System.String ToString() { }
        // RVA: 0x09AF333C  token: 0x6000A83
        public static System.Boolean op_Equality(Beyond.UI.UIState.StateDescription left, Beyond.UI.UIState.StateDescription right) { }
        // RVA: 0x09AF33B8  token: 0x6000A84
        public static System.Boolean op_Inequality(Beyond.UI.UIState.StateDescription left, Beyond.UI.UIState.StateDescription right) { }
        // RVA: 0x09AF12C4  token: 0x6000A85
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09AF1354  token: 0x6000A86
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09AF1238  token: 0x6000A87
        public System.Boolean Equals(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF144C  token: 0x6000A88
        private System.Boolean _EqualsByTargetType(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF1678  token: 0x6000A89
        private System.Int32 _GetTargetHashCode() { }
        // RVA: 0x09AF0BF8  token: 0x6000A8A
        public System.Boolean EqualsGameObject(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD49C0  token: 0x6000A8B
        public System.Void ApplyGameObject() { }
        // RVA: 0x09AF0C98  token: 0x6000A8C
        public System.Boolean EqualsGraphic(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF05B4  token: 0x6000A8D
        public System.Void ApplyGraphic() { }
        // RVA: 0x09AF0D38  token: 0x6000A8E
        public System.Boolean EqualsGridLayoutGroup(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF061C  token: 0x6000A8F
        public System.Void ApplyGridLayoutGroup() { }
        // RVA: 0x09AF1758  token: 0x6000A90
        private System.Void _OnGridLayoutGroupChanged() { }
        // RVA: 0x09AF0DD8  token: 0x6000A93
        public System.Boolean EqualsImage(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD4D70  token: 0x6000A94
        public System.Void ApplyImage() { }
        // RVA: 0x09AF1868  token: 0x6000A95
        private System.Void _OnImageChanged() { }
        // RVA: 0x09AF0E78  token: 0x6000A96
        public System.Boolean EqualsLayoutElement(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD1950  token: 0x6000A97
        public System.Void ApplyLayoutElement() { }
        // RVA: 0x09AF19BC  token: 0x6000A98
        private System.Void _OnLayoutElementChanged() { }
        // RVA: 0x09AF0F18  token: 0x6000A99
        public System.Boolean EqualsLayoutGroup(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD1160  token: 0x6000A9A
        public System.Void ApplyLayoutGroup() { }
        // RVA: 0x09AF1A88  token: 0x6000A9B
        private System.Void _OnLayoutGroupChanged() { }
        // RVA: 0x09AF0FB8  token: 0x6000A9C
        public System.Boolean EqualsRectTransform(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD4A10  token: 0x6000A9D
        public System.Void ApplyRectTransform() { }
        // RVA: 0x09AF1B80  token: 0x6000A9E
        private System.Void _OnRectTransformChanged() { }
        // RVA: 0x09AF1058  token: 0x6000A9F
        public System.Boolean EqualsScrollList(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF07D8  token: 0x6000AA0
        public System.Void ApplyScrollList() { }
        // RVA: 0x09AF203C  token: 0x6000AA1
        private System.Void _OnScrollListChanged() { }
        // RVA: 0x09AF10F8  token: 0x6000AA2
        public System.Boolean EqualsState(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x09AF0770  token: 0x6000AA3
        public System.Single ApplyInnerState() { }
        // RVA: 0x09AF1198  token: 0x6000AA4
        public System.Boolean EqualsText(Beyond.UI.UIState.StateDescription other) { }
        // RVA: 0x02CD1E00  token: 0x6000AA5
        public System.Void ApplyText() { }
        // RVA: 0x09AF20F0  token: 0x6000AA6
        private System.Void _OnTextChanged() { }
        // RVA: 0x03162130  token: 0x6000AA7
        public System.Void .ctor() { }
        // RVA: 0x05459F38  token: 0x6000AA8
        public System.String <>iFixBaseProxy_ToString() { }
        // RVA: 0x0232CE30  token: 0x6000AA9
        public System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        // RVA: 0x03D4F970  token: 0x6000AAA
        public System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x2000138  // size: 0x14
    public sealed struct AnimatorImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.AnimatorImpactType SetBoolTrue;  // const
        public static Beyond.UI.UIState.AnimatorImpactType SetBoolFalse;  // const
        public static Beyond.UI.UIState.AnimatorImpactType SetTrigger;  // const
        public static Beyond.UI.UIState.AnimatorImpactType ResetTrigger;  // const
        public static Beyond.UI.UIState.AnimatorImpactType SetInteger;  // const
        public static Beyond.UI.UIState.AnimatorImpactType SetFloat;  // const

    }

    // TypeToken: 0x2000139  // size: 0x14
    public sealed struct CanvasGroupImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.CanvasGroupImpactType SetAlpha;  // const
        public static Beyond.UI.UIState.CanvasGroupImpactType SetInteractable;  // const
        public static Beyond.UI.UIState.CanvasGroupImpactType SetColor;  // const

    }

    // TypeToken: 0x200013A  // size: 0x14
    public sealed struct StateDescriptionTargetType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.StateDescriptionTargetType GameObject;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Animator;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Image;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Text;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType RectTransform;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Button;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType CanvasGroup;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Animation;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType State;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType LayoutElement;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Component;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType Graphic;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType LayoutGroup;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType ScrollList;  // const
        public static Beyond.UI.UIState.StateDescriptionTargetType GridLayoutGroup;  // const

    }

    // TypeToken: 0x200013B  // size: 0x14
    public sealed struct GridLayoutGroupImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.GridLayoutGroupImpactType Padding;  // const
        public static Beyond.UI.UIState.GridLayoutGroupImpactType Spacing;  // const
        public static Beyond.UI.UIState.GridLayoutGroupImpactType CellSize;  // const
        public static Beyond.UI.UIState.GridLayoutGroupImpactType ConstraintCount;  // const

    }

    // TypeToken: 0x200013C  // size: 0x14
    public sealed struct ImageImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.ImageImpactType SetEnabled;  // const
        public static Beyond.UI.UIState.ImageImpactType SetSprite;  // const
        public static Beyond.UI.UIState.ImageImpactType SetColor;  // const
        public static Beyond.UI.UIState.ImageImpactType SetMaterialFloatValue;  // const

    }

    // TypeToken: 0x200013D  // size: 0x14
    public sealed struct LayoutElementImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementPreferredWidth;  // const
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementPreferredHeight;  // const
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementMinWidth;  // const
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementMinHeight;  // const
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementFlexibleWidth;  // const
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementFlexibleHeight;  // const

    }

    // TypeToken: 0x200013E  // size: 0x14
    public sealed struct LayoutGroupImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.LayoutGroupImpactType Padding;  // const
        public static Beyond.UI.UIState.LayoutGroupImpactType Spacing;  // const
        public static Beyond.UI.UIState.LayoutGroupImpactType ChildAlignment;  // const
        public static Beyond.UI.UIState.LayoutGroupImpactType ReverseArrangement;  // const

    }

    // TypeToken: 0x200013F  // size: 0x14
    public sealed struct RectTransformImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.RectTransformImpactType Undefined;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetPosition;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetSize;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetRotation;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetScale;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetWidth;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetHeight;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetTop;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetBottom;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetLeft;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetRight;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetAnchors;  // const
        public static Beyond.UI.UIState.RectTransformImpactType SetPivot;  // const
        public static Beyond.UI.UIState.RectTransformImpactType ForceRebuildLayout;  // const

    }

    // TypeToken: 0x2000140  // size: 0x14
    public sealed struct ScrollListImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.ScrollListImpactType Padding;  // const

    }

    // TypeToken: 0x2000141  // size: 0x14
    public sealed struct TextImpactType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIState.TextImpactType SetColor;  // const
        public static Beyond.UI.UIState.TextImpactType SetTextById;  // const
        public static Beyond.UI.UIState.TextImpactType SetFontSize;  // const
        public static Beyond.UI.UIState.TextImpactType SetHorizontalAlignment;  // const
        public static Beyond.UI.UIState.TextImpactType SetMaxFontSize;  // const

    }

    // TypeToken: 0x2000142  // size: 0x40
    public class StateReference
    {
        // Fields
        public System.String stateName;  // 0x10
        public System.Collections.Generic.List<Beyond.UI.UIState.StateDescription> descriptions;  // 0x18
        private System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_scheduledForPlaying;  // 0x20
        private System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_scheduledForStopping;  // 0x28
        private Beyond.UI.UIState.UIStateController m_controller;  // 0x30
        private System.Boolean m_isDirty;  // 0x38

        // Methods
        // RVA: 0x02CD2CF0  token: 0x6000AAB
        public System.Void SetController(Beyond.UI.UIState.UIStateController controller) { }
        // RVA: 0x09B0C888  token: 0x6000AAC
        public System.Void ScheduleForPlaying(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo) { }
        // RVA: 0x02CD1C00  token: 0x6000AAD
        public System.Void ScheduleForStopping(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo) { }
        // RVA: 0x03304130  token: 0x6000AAE
        public System.Void HandleScheduledStates() { }
        // RVA: 0x028462E0  token: 0x6000AAF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000143  // size: 0x80
    public class UIStateController : Beyond.TickableUIMono
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIState.StateReference> states;  // 0x68
        private System.String <currentStateName>k__BackingField;  // 0x70
        private readonly System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_animations;  // 0x78

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.String currentStateName { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }

        // Methods
        // RVA: 0x02CD1C80  token: 0x6000AB3
        public System.Void OnStateReferenceDirty() { }
        // RVA: 0x02CD2D30  token: 0x6000AB4
        public System.Single SetState(System.String stateName, System.Boolean forceUpdate) { }
        // RVA: 0x02CD2E50  token: 0x6000AB5
        private System.Single _ApplyState(Beyond.UI.UIState.StateReference state) { }
        // RVA: 0x033030C0  token: 0x6000AB6
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x033040E0  token: 0x6000AB7
        private System.Void _HandleStateAnimations(Beyond.UI.UIState.StateReference stateReference) { }
        // RVA: 0x09B0CB38  token: 0x6000AB8
        public System.Void Run(Beyond.UI.UIState.StateAnimationInfo newInfo) { }
        // RVA: 0x03302D90  token: 0x6000AB9
        public System.Void Stop(Beyond.UI.UIState.StateAnimationInfo newInfo) { }
        // RVA: 0x02846210  token: 0x6000ABA
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x6000ABB
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000145  // size: 0x10
    public static class UIStateControllerUtils
    {
        // Fields
        private static System.Single s_updateFinishTime;  // static @ 0x0

        // Methods
        // RVA: 0x09B0C940  token: 0x6000ABF
        public static System.Void ForceRebuildLayout(UnityEngine.GameObject gameObject) { }
        // RVA: 0x02CD4E60  token: 0x6000AC0
        public static System.Void SetLeft(UnityEngine.RectTransform rt, System.Single left) { }
        // RVA: 0x02CD5060  token: 0x6000AC1
        public static System.Void SetRight(UnityEngine.RectTransform rt, System.Single right) { }
        // RVA: 0x02CD5580  token: 0x6000AC2
        public static System.Void SetTop(UnityEngine.RectTransform rt, System.Single top) { }
        // RVA: 0x02CD5290  token: 0x6000AC3
        public static System.Void SetBottom(UnityEngine.RectTransform rt, System.Single bottom) { }
        // RVA: 0x09B0CA40  token: 0x6000AC4
        public static System.String GetName(UnityEngine.Object obj) { }
        // RVA: 0x09B0CAEC  token: 0x6000AC5
        public static System.Void StartEditorUpdateLoop(System.Single duration) { }

    }

}

namespace Cysharp.Text
{

    // TypeToken: 0x2000004  // size: 0x10
    public static class TextMeshProExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000005
        public static System.Void SetText(TMPro.TMP_Text text, T arg0) { }
        // RVA: -1  // generic def  token: 0x6000006
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0) { }
        // RVA: -1  // generic def  token: 0x6000007
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1) { }
        // RVA: -1  // generic def  token: 0x6000008
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x6000009
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x600000A
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: -1  // generic def  token: 0x600000B
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        // RVA: -1  // generic def  token: 0x600000C
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        // RVA: -1  // generic def  token: 0x600000D
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        // RVA: -1  // generic def  token: 0x600000E
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        // RVA: -1  // generic def  token: 0x600000F
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        // RVA: -1  // generic def  token: 0x6000010
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        // RVA: -1  // generic def  token: 0x6000011
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        // RVA: -1  // generic def  token: 0x6000012
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        // RVA: -1  // generic def  token: 0x6000013
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        // RVA: -1  // generic def  token: 0x6000014
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        // RVA: -1  // generic def  token: 0x6000015
        public static System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        // RVA: 0x09AAF6CC  token: 0x6000016
        public static System.Void SetText(TMPro.TMP_Text text, Cysharp.Text.Utf16ValueStringBuilder stringBuilder) { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000162  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000B46
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x050F3444  token: 0x6000B47
        public System.Void __Gen_Wrap_0() { }
        // RVA: 0x04274234  token: 0x6000B48
        public System.Void __Gen_Wrap_1(System.Object P0) { }
        // RVA: 0x088B576C  token: 0x6000B49
        public System.Single __Gen_Wrap_2(System.Object P0, System.Boolean P1) { }
        // RVA: 0x054AB08C  token: 0x6000B4A
        public System.Single __Gen_Wrap_3(System.Object P0) { }
        // RVA: 0x09B067AC  token: 0x6000B4B
        public Beyond.UI.LuaPanel __Gen_Wrap_4(System.Object P0) { }
        // RVA: 0x054790D0  token: 0x6000B4C
        public System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x050F0008  token: 0x6000B4D
        public System.Void __Gen_Wrap_6(System.Object P0, System.Single P1) { }
        // RVA: 0x09B08018  token: 0x6000B4E
        public System.String __Gen_Wrap_7(System.Object P0, System.Int32 P1, System.Boolean& P2) { }
        // RVA: 0x05153920  token: 0x6000B4F
        public System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1) { }
        // RVA: 0x09B08E80  token: 0x6000B50
        public Beyond.UI.UIText.HyperlinkUITextGroup __Gen_Wrap_9(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x05163BA0  token: 0x6000B51
        public System.Void __Gen_Wrap_10(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFA534  token: 0x6000B52
        public System.String __Gen_Wrap_11(Beyond.GEnums.PhoneticType P0, System.Object P1) { }
        // RVA: 0x0560138C  token: 0x6000B53
        public System.Void __Gen_Wrap_12(System.Object P0, Beyond.GEnums.PhoneticType P1, System.Object P2) { }
        // RVA: 0x0514E3FC  token: 0x6000B54
        public System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0) { }
        // RVA: 0x09AFBE98  token: 0x6000B55
        public System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1, System.String& P2) { }
        // RVA: 0x09AFC9B8  token: 0x6000B56
        public System.Boolean __Gen_Wrap_15(System.Object P0, UnityEngine.Vector3 P1, System.String& P2) { }
        // RVA: 0x09AFD430  token: 0x6000B57
        public System.Collections.IEnumerator __Gen_Wrap_16(System.Object P0) { }
        // RVA: 0x09AFDA54  token: 0x6000B58
        public System.String __Gen_Wrap_17(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09AFE234  token: 0x6000B59
        public UnityEngine.Sprite __Gen_Wrap_18(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFE9D0  token: 0x6000B5A
        public System.Int32 __Gen_Wrap_19(System.ReadOnlySpan<System.Char> P0) { }
        // RVA: 0x09AFF02C  token: 0x6000B5B
        public Beyond.UI.UIText.RichTextInfo __Gen_Wrap_20(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P0, System.Object P1, Cysharp.Text.Utf16ValueStringBuilder& P2) { }
        // RVA: 0x09AFF990  token: 0x6000B5C
        public Beyond.UI.UIText.RichTextInfo __Gen_Wrap_21(System.Object P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P1, System.Object P2, Cysharp.Text.Utf16ValueStringBuilder& P3) { }
        // RVA: 0x09B000D0  token: 0x6000B5D
        public Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(System.Object P0) { }
        // RVA: 0x09B00A68  token: 0x6000B5E
        public System.Boolean __Gen_Wrap_23(System.ReadOnlySpan<System.Char> P0, System.Boolean& P1, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& P2) { }
        // RVA: 0x09B016B8  token: 0x6000B5F
        public System.Boolean __Gen_Wrap_24(System.ReadOnlySpan<System.Char> P0, Cysharp.Text.Utf16ValueStringBuilder& P1, System.Object P2, Beyond.UI.UIText.RichTextInfo& P3) { }
        // RVA: 0x09B0264C  token: 0x6000B60
        public System.String __Gen_Wrap_25(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& P2) { }
        // RVA: 0x09B031F4  token: 0x6000B61
        public UnityEngine.GameObject __Gen_Wrap_26(System.Object P0) { }
        // RVA: 0x09B03D64  token: 0x6000B62
        public Beyond.UI.UIText.ImageGOInfo __Gen_Wrap_27(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B04AC4  token: 0x6000B63
        public UnityEngine.Material __Gen_Wrap_28(System.Object P0) { }
        // RVA: 0x09B05754  token: 0x6000B64
        public UnityEngine.Material __Gen_Wrap_29(System.Object P0, System.Object P1) { }
        // RVA: 0x0514F380  token: 0x6000B65
        public System.Boolean __Gen_Wrap_30() { }
        // RVA: 0x09B05B1C  token: 0x6000B66
        public Beyond.I18n.I18nFontSearchData __Gen_Wrap_31() { }
        // RVA: 0x0514EF5C  token: 0x6000B67
        public System.Boolean __Gen_Wrap_32(System.Object P0) { }
        // RVA: 0x09B05BE8  token: 0x6000B68
        public TMPro.TMP_FontAsset __Gen_Wrap_33(System.Int32 P0) { }
        // RVA: 0x09B05CD4  token: 0x6000B69
        public TMPro.TMP_FontAsset __Gen_Wrap_34(System.Object P0) { }
        // RVA: 0x056479C0  token: 0x6000B6A
        public System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        // RVA: 0x054A1028  token: 0x6000B6B
        public System.Void __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x09B05DC4  token: 0x6000B6C
        public System.Boolean __Gen_Wrap_37(System.Object P0, System.Int32 P1, System.String& P2) { }
        // RVA: 0x09B05F04  token: 0x6000B6D
        public System.Boolean __Gen_Wrap_38(System.Object P0, System.Int32 P1, UnityEngine.Vector3& P2, System.Single& P3) { }
        // RVA: 0x05150B1C  token: 0x6000B6E
        public System.Void __Gen_Wrap_39(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x050EF354  token: 0x6000B6F
        public System.Int32 __Gen_Wrap_40(Beyond.UI.UIText.HyperlinkUITextWrap P0, Beyond.UI.UIText.HyperlinkUITextWrap P1) { }
        // RVA: 0x09B06084  token: 0x6000B70
        public System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_41(System.Object P0, System.Object P1) { }
        // RVA: 0x09B0617C  token: 0x6000B71
        public System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_42(System.Object P0) { }
        // RVA: 0x050EF614  token: 0x6000B72
        public System.Int32 __Gen_Wrap_43(System.Object P0) { }
        // RVA: 0x09B06258  token: 0x6000B73
        public TMPro.TMP_SubMeshUI __Gen_Wrap_44(System.Object P0, System.Object P1, TMPro.MaterialReference P2) { }
        // RVA: 0x09B063BC  token: 0x6000B74
        public System.String __Gen_Wrap_45(System.Int32 P0) { }
        // RVA: 0x056409AC  token: 0x6000B75
        public System.Single __Gen_Wrap_46() { }
        // RVA: 0x09B064A8  token: 0x6000B76
        public UnityEngine.GameObject __Gen_Wrap_47(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B065BC  token: 0x6000B77
        public System.Void __Gen_Wrap_48(Beyond.Resource.FAssetProxyUntrackedHandle P0) { }
        // RVA: 0x09B066A4  token: 0x6000B78
        public System.Int32 __Gen_Wrap_49(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x0549D548  token: 0x6000B79
        public System.Void __Gen_Wrap_50(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B0689C  token: 0x6000B7A
        public System.Boolean __Gen_Wrap_51(UnityEngine.Vector3 P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B069E0  token: 0x6000B7B
        public System.Boolean __Gen_Wrap_52(UnityEngine.Vector2 P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B06B1C  token: 0x6000B7C
        public UnityEngine.Bounds __Gen_Wrap_53(System.Object P0, System.Object P1) { }
        // RVA: 0x09B06C3C  token: 0x6000B7D
        public System.Boolean __Gen_Wrap_54(System.Int32 P0, UnityEngine.InputSystem.EnhancedTouch.Touch& P1) { }
        // RVA: 0x09B06D84  token: 0x6000B7E
        public System.Void __Gen_Wrap_55(System.Object P0, UnityEngine.Color P1) { }
        // RVA: 0x09B06E98  token: 0x6000B7F
        public UnityEngine.Rect __Gen_Wrap_56(System.Object P0, System.Object P1) { }
        // RVA: 0x09B06FC0  token: 0x6000B80
        public UnityEngine.Vector3 __Gen_Wrap_57(System.Object P0, System.Object P1) { }
        // RVA: 0x09B070E0  token: 0x6000B81
        public UnityEngine.Color __Gen_Wrap_58(System.Object P0) { }
        // RVA: 0x0871ACD8  token: 0x6000B82
        public System.Single __Gen_Wrap_59(System.Single P0) { }
        // RVA: 0x09B071D8  token: 0x6000B83
        public System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, Cinemachine.CinemachineCore.Stage P2, Cinemachine.CameraState& P3, System.Single P4) { }
        // RVA: 0x054761A8  token: 0x6000B84
        public System.Int32 __Gen_Wrap_61(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B0743C  token: 0x6000B85
        public UnityEngine.Vector2 __Gen_Wrap_62(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B07534  token: 0x6000B86
        public UnityEngine.Vector2 __Gen_Wrap_63() { }
        // RVA: 0x09B075EC  token: 0x6000B87
        public System.Void __Gen_Wrap_64(UnityEngine.Vector2 P0) { }
        // RVA: 0x05610058  token: 0x6000B88
        public System.Void __Gen_Wrap_65(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x09B076D4  token: 0x6000B89
        public UnityEngine.Vector2Int __Gen_Wrap_66(System.Object P0, System.Single P1, System.Boolean P2) { }
        // RVA: 0x09B077FC  token: 0x6000B8A
        public UnityEngine.Vector2Int __Gen_Wrap_67(System.Object P0) { }
        // RVA: 0x09B078EC  token: 0x6000B8B
        public Beyond.UI.UIScrollList.Cell __Gen_Wrap_68(System.Object P0) { }
        // RVA: 0x05477860  token: 0x6000B8C
        public System.Void __Gen_Wrap_69(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09B079DC  token: 0x6000B8D
        public UnityEngine.AnimationState __Gen_Wrap_70(System.Object P0, System.Object P1) { }
        // RVA: 0x05E7B3B0  token: 0x6000B8E
        public System.Void __Gen_Wrap_71(System.Object P0, System.Object P1, System.Single P2) { }
        // RVA: 0x05E612B8  token: 0x6000B8F
        public System.Void __Gen_Wrap_72(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3) { }
        // RVA: 0x09B07AE8  token: 0x6000B90
        public System.Void __Gen_Wrap_73(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIConst.AnimationState P3, System.Single P4) { }
        // RVA: 0x09B07C00  token: 0x6000B91
        public System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x05E5ABBC  token: 0x6000B92
        public System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x050EF614  token: 0x6000B93
        public Beyond.UI.UIScrollList.MoveTipsType __Gen_Wrap_76(System.Object P0) { }
        // RVA: 0x09B07D08  token: 0x6000B94
        public System.Void __Gen_Wrap_77(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x09B07E1C  token: 0x6000B95
        public System.Void __Gen_Wrap_78(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3, System.Boolean P4) { }
        // RVA: 0x09B07F28  token: 0x6000B96
        public Beyond.UI.UIText __Gen_Wrap_79(System.Object P0) { }
        // RVA: 0x09B08160  token: 0x6000B97
        public System.String __Gen_Wrap_80(System.Object P0) { }
        // RVA: 0x09B08250  token: 0x6000B98
        public UnityEngine.Sprite __Gen_Wrap_81(System.Object P0) { }
        // RVA: 0x05477F10  token: 0x6000B99
        public Beyond.UI.UIStyleInputValidTypeMask __Gen_Wrap_82(System.Object P0) { }
        // RVA: 0x055FFD60  token: 0x6000B9A
        public System.Void __Gen_Wrap_83(System.Object P0, Beyond.UI.UIStyleInputValidTypeMask P1) { }
        // RVA: 0x0514DE88  token: 0x6000B9B
        public System.Boolean __Gen_Wrap_84(Beyond.UI.UIStyleInputValidType P0) { }
        // RVA: 0x05151D64  token: 0x6000B9C
        public System.Boolean __Gen_Wrap_85(Beyond.UI.UIStyleInputValidTypeMask P0) { }
        // RVA: 0x054772E8  token: 0x6000B9D
        public System.Void __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x050F1DD4  token: 0x6000B9E
        public System.Int32 __Gen_Wrap_87() { }
        // RVA: 0x05E3DBF4  token: 0x6000B9F
        public System.Void __Gen_Wrap_88(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x09B0832C  token: 0x6000BA0
        public UnityEngine.UI.Selectable __Gen_Wrap_89(System.Object P0) { }
        // RVA: 0x09B0841C  token: 0x6000BA1
        public System.Boolean __Gen_Wrap_90(System.Object P0, UnityEngine.Vector2 P1, System.Object P2) { }
        // RVA: 0x09B08558  token: 0x6000BA2
        public System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(System.Object P0) { }
        // RVA: 0x09B08634  token: 0x6000BA3
        public Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_92(System.Object P0) { }
        // RVA: 0x09B08710  token: 0x6000BA4
        public Beyond.UI.UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(System.Object P0) { }
        // RVA: 0x09B087EC  token: 0x6000BA5
        public System.Void __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P2) { }
        // RVA: 0x09B08908  token: 0x6000BA6
        public UnityEngine.Vector2 __Gen_Wrap_95(System.Object P0, UnityEngine.Bounds P1) { }
        // RVA: 0x09B08A30  token: 0x6000BA7
        public UnityEngine.Bounds __Gen_Wrap_96(System.Object P0, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P1) { }
        // RVA: 0x09B08B74  token: 0x6000BA8
        public Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_97(System.Object P0, System.Object P1) { }
        // RVA: 0x09B08C6C  token: 0x6000BA9
        public Beyond.UI.UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(System.Object P0, System.Object P1) { }
        // RVA: 0x09B08D64  token: 0x6000BAA
        public UnityEngine.GameObject __Gen_Wrap_99(System.Object P0, System.Boolean& P1) { }
        // RVA: 0x09AF96F8  token: 0x6000BAB
        public System.Boolean __Gen_Wrap_100(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x09AF97EC  token: 0x6000BAC
        public Beyond.UI.UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AF98E4  token: 0x6000BAD
        public System.Single __Gen_Wrap_102(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AF99BC  token: 0x6000BAE
        public UnityEngine.Bounds __Gen_Wrap_103(System.Object P0, System.Int32 P1) { }
        // RVA: 0x050EF354  token: 0x6000BAF
        public System.Int32 __Gen_Wrap_104(System.Object P0, System.Object P1) { }
        // RVA: 0x05477F10  token: 0x6000BB0
        public Beyond.UI.UIRecycleLayoutGroup.Direction __Gen_Wrap_105(System.Object P0) { }
        // RVA: 0x09AF9ADC  token: 0x6000BB1
        public Beyond.UI.UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AF9BD4  token: 0x6000BB2
        public System.Void __Gen_Wrap_107(System.Object P0, System.Int32 P1, System.Object P2, System.Single P3) { }
        // RVA: 0x09AF9CCC  token: 0x6000BB3
        public Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AF9DC4  token: 0x6000BB4
        public Beyond.UI.ToastList.CellInfo __Gen_Wrap_109(System.Object P0) { }
        // RVA: 0x09AF9EA0  token: 0x6000BB5
        public System.Collections.IEnumerator __Gen_Wrap_110(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x0562978C  token: 0x6000BB6
        public System.Boolean __Gen_Wrap_111(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09AF9FB4  token: 0x6000BB7
        public System.Boolean __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3, System.Boolean& P4, System.Boolean P5) { }
        // RVA: 0x09AFA10C  token: 0x6000BB8
        public Beyond.Input.PlayerActionInfo __Gen_Wrap_113(System.Object P0) { }
        // RVA: 0x05E7902C  token: 0x6000BB9
        public System.Boolean __Gen_Wrap_114(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x050EE9C4  token: 0x6000BBA
        public System.Void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0) { }
        // RVA: 0x09AFA1FC  token: 0x6000BBB
        public System.Void __Gen_Wrap_116(System.Object P0, Beyond.EventData<System.String>& P1) { }
        // RVA: 0x05648770  token: 0x6000BBC
        public System.Void __Gen_Wrap_117(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x09AFA314  token: 0x6000BBD
        public System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3, System.Boolean P4) { }
        // RVA: 0x09AFA420  token: 0x6000BBE
        public UnityEngine.AnimationClip __Gen_Wrap_119(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x09AFA62C  token: 0x6000BBF
        public UnityEngine.AnimationClip __Gen_Wrap_120(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFA724  token: 0x6000BC0
        public System.Void __Gen_Wrap_121(System.Object P0, Beyond.UI.UIAnimationWrapper.FOptions P1) { }
        // RVA: 0x054AB15C  token: 0x6000BC1
        public System.Single __Gen_Wrap_122(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFA830  token: 0x6000BC2
        public Beyond.UI.UIAnimationWrapper.FOptions __Gen_Wrap_123() { }
        // RVA: 0x05E57990  token: 0x6000BC3
        public System.Void __Gen_Wrap_124(System.Object P0, System.Object P1, System.Object P2, System.Single P3) { }
        // RVA: 0x09AFA8E8  token: 0x6000BC4
        public Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_125(System.Object P0) { }
        // RVA: 0x09AFA9D8  token: 0x6000BC5
        public Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_126(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFAAE4  token: 0x6000BC6
        public Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_127(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09AFABF0  token: 0x6000BC7
        public Beyond.UI.UIAnimationSwitchTween __Gen_Wrap_128(Beyond.UI.UIAnimationSwitchTween.Builder& P0) { }
        // RVA: 0x09AFAD3C  token: 0x6000BC8
        public UnityEngine.Camera __Gen_Wrap_129(System.Object P0) { }
        // RVA: 0x09AFAE2C  token: 0x6000BC9
        public System.Void __Gen_Wrap_130(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        // RVA: 0x09AFAF40  token: 0x6000BCA
        public System.Void __Gen_Wrap_131(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Single P4) { }
        // RVA: 0x05E5ED40  token: 0x6000BCB
        public System.Void __Gen_Wrap_132(System.Object P0, System.Single P1, System.Boolean P2) { }
        // RVA: 0x09AFB050  token: 0x6000BCC
        public System.Collections.IEnumerator __Gen_Wrap_133(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFB15C  token: 0x6000BCD
        public Beyond.DisposedUnityEvent<System.Int32,System.Boolean> __Gen_Wrap_134(System.Object P0) { }
        // RVA: 0x09AFB238  token: 0x6000BCE
        public System.Void __Gen_Wrap_135(System.Object P0, UnityEngine.Vector2& P1, UnityEngine.Vector2& P2) { }
        // RVA: 0x09AFB398  token: 0x6000BCF
        public UnityEngine.Vector2 __Gen_Wrap_136(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x050EE850  token: 0x6000BD0
        public System.Void __Gen_Wrap_137(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09AFB4C8  token: 0x6000BD1
        public System.Void __Gen_Wrap_138(System.Object P0, UnityEngine.Vector3 P1) { }
        // RVA: 0x09AFB5E4  token: 0x6000BD2
        public System.Void __Gen_Wrap_139(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4) { }
        // RVA: 0x05784998  token: 0x6000BD3
        public System.Void __Gen_Wrap_140(System.Single P0) { }
        // RVA: 0x09AFB700  token: 0x6000BD4
        public System.Void __Gen_Wrap_141(System.Object P0, System.Boolean P1, UnityEngine.UI.Selectable& P2, Beyond.UI.UITouchPanel& P3) { }
        // RVA: 0x09AFB88C  token: 0x6000BD5
        public System.Void __Gen_Wrap_142(System.Object P0, System.Single P1, System.Single P2, System.Object P3) { }
        // RVA: 0x08743618  token: 0x6000BD6
        public System.Void __Gen_Wrap_143(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3) { }
        // RVA: 0x09AFB988  token: 0x6000BD7
        public System.Void __Gen_Wrap_144(System.Object P0, System.Single& P1, System.Single& P2) { }
        // RVA: 0x09AFBAB8  token: 0x6000BD8
        public System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, UnityEngine.Color P2) { }
        // RVA: 0x09AFBBD4  token: 0x6000BD9
        public UnityEngine.Canvas __Gen_Wrap_146(System.Object P0) { }
        // RVA: 0x09AFBCB0  token: 0x6000BDA
        public HG.Rendering.Runtime.HGCamera __Gen_Wrap_147(System.Object P0) { }
        // RVA: 0x09AFBD8C  token: 0x6000BDB
        public System.String __Gen_Wrap_148(System.Object P0, System.Object P1) { }
        // RVA: 0x050EF614  token: 0x6000BDC
        public Beyond.Input.BindingViewState __Gen_Wrap_149(System.Object P0) { }
        // RVA: 0x09AFBFE8  token: 0x6000BDD
        public System.String __Gen_Wrap_150(System.Object P0, Beyond.Input.BindingViewActionType P1) { }
        // RVA: 0x09AFC0F4  token: 0x6000BDE
        public System.Boolean __Gen_Wrap_151(System.Object P0, System.String& P1, System.String& P2) { }
        // RVA: 0x055FFD60  token: 0x6000BDF
        public System.Void __Gen_Wrap_152(System.Object P0, Beyond.Input.ActionOnSetNaviTarget P1) { }
        // RVA: 0x09AFC260  token: 0x6000BE0
        public System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> __Gen_Wrap_153(System.Object P0) { }
        // RVA: 0x09AFC33C  token: 0x6000BE1
        public UnityEngine.Vector2 __Gen_Wrap_154(System.Object P0) { }
        // RVA: 0x09AFC42C  token: 0x6000BE2
        public System.Single __Gen_Wrap_155(UnityEngine.Vector2& P0) { }
        // RVA: 0x09AFC540  token: 0x6000BE3
        public Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_156(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x09AFC67C  token: 0x6000BE4
        public Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_157() { }
        // RVA: 0x09AFC76C  token: 0x6000BE5
        public System.Void __Gen_Wrap_158(System.Object P0, Beyond.UI.UIColorGroup.CommonParams P1) { }
        // RVA: 0x09AFC884  token: 0x6000BE6
        public System.Void __Gen_Wrap_159(System.Object P0, System.Object P1, Beyond.UI.UIColorGroup.CommonParams P2) { }
        // RVA: 0x09AFCB34  token: 0x6000BE7
        public System.Void __Gen_Wrap_160(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3) { }
        // RVA: 0x09AFCC30  token: 0x6000BE8
        public System.Void __Gen_Wrap_161(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        // RVA: 0x09AFCD7C  token: 0x6000BE9
        public System.Void __Gen_Wrap_162(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x055FFD60  token: 0x6000BEA
        public System.Void __Gen_Wrap_163(System.Object P0, Beyond.Input.GamepadKeyCode P1) { }
        // RVA: 0x09AFCEC8  token: 0x6000BEB
        public Beyond.UI.UICustomLayoutElement __Gen_Wrap_164(System.Object P0) { }
        // RVA: 0x09AFCFB8  token: 0x6000BEC
        public System.String __Gen_Wrap_165(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AFD0B0  token: 0x6000BED
        public System.Boolean __Gen_Wrap_166(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Boolean P2, System.Int32 P3) { }
        // RVA: 0x09AFD200  token: 0x6000BEE
        public System.Boolean __Gen_Wrap_167(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Int32 P2) { }
        // RVA: 0x09AFD340  token: 0x6000BEF
        public UnityEngine.RectTransform __Gen_Wrap_168(System.Object P0) { }
        // RVA: 0x055FFD60  token: 0x6000BF0
        public System.Void __Gen_Wrap_169(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutType P1) { }
        // RVA: 0x09AFD520  token: 0x6000BF1
        public UnityEngine.CanvasGroup __Gen_Wrap_170(System.Object P0) { }
        // RVA: 0x055FE324  token: 0x6000BF2
        public System.Void __Gen_Wrap_171(System.Object P0, System.Boolean P1, System.Object P2) { }
        // RVA: 0x05496D84  token: 0x6000BF3
        public System.Void __Gen_Wrap_172(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x09AFD5FC  token: 0x6000BF4
        public System.Void __Gen_Wrap_173(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x09AFD710  token: 0x6000BF5
        public System.Void __Gen_Wrap_174(System.Object P0, UnityEngine.Vector2 P1, System.Boolean P2) { }
        // RVA: 0x0871664C  token: 0x6000BF6
        public System.Void __Gen_Wrap_175(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3) { }
        // RVA: 0x09AFD83C  token: 0x6000BF7
        public System.Single __Gen_Wrap_176(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        // RVA: 0x05E62488  token: 0x6000BF8
        public System.Void __Gen_Wrap_177(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3) { }
        // RVA: 0x09AFD940  token: 0x6000BF9
        public System.Void __Gen_Wrap_178(System.Object P0, UnityEngine.Rect P1) { }
        // RVA: 0x0871FD10  token: 0x6000BFA
        public System.Single __Gen_Wrap_179(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x05E616F8  token: 0x6000BFB
        public System.Void __Gen_Wrap_180(System.Object P0, System.Int32 P1, System.Single P2) { }
        // RVA: 0x09AFDB60  token: 0x6000BFC
        public System.Boolean __Gen_Wrap_181(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x09AFDC54  token: 0x6000BFD
        public UnityEngine.UI.Selectable __Gen_Wrap_182(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09AFDD4C  token: 0x6000BFE
        public System.Boolean __Gen_Wrap_183(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x09AFDE5C  token: 0x6000BFF
        public System.Boolean __Gen_Wrap_184(System.Object P0, UnityEngine.UI.NaviDirection P1, System.Boolean P2) { }
        // RVA: 0x055FFD60  token: 0x6000C00
        public System.Void __Gen_Wrap_185(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x05E7433C  token: 0x6000C01
        public System.Boolean __Gen_Wrap_186(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x09AFDF50  token: 0x6000C02
        public UnityEngine.Vector3 __Gen_Wrap_187() { }
        // RVA: 0x09AFE030  token: 0x6000C03
        public System.Void __Gen_Wrap_188(UnityEngine.Vector3 P0) { }
        // RVA: 0x09AFE11C  token: 0x6000C04
        public Beyond.UI.UIAtlasManager.UIAtlasHandle __Gen_Wrap_189(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause P0) { }
        // RVA: 0x09AFE340  token: 0x6000C05
        public UnityEngine.Texture __Gen_Wrap_190(System.Object P0) { }
        // RVA: 0x09AFE430  token: 0x6000C06
        public DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> __Gen_Wrap_191(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x09AFE548  token: 0x6000C07
        public Beyond.UI.UIImage __Gen_Wrap_192(System.Object P0) { }
        // RVA: 0x09AFE624  token: 0x6000C08
        public System.Boolean __Gen_Wrap_193(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig& P0) { }
        // RVA: 0x086F21C8  token: 0x6000C09
        public System.Int32 __Gen_Wrap_194(System.Object P0, System.Single P1) { }
        // RVA: 0x05481690  token: 0x6000C0A
        public System.Single __Gen_Wrap_195(System.Object P0, System.Single P1) { }
        // RVA: 0x050EF354  token: 0x6000C0B
        public Beyond.UI.UIInertiaViewPager.State __Gen_Wrap_196(System.Object P0, System.Object P1) { }
        // RVA: 0x09AFE770  token: 0x6000C0C
        public System.Boolean __Gen_Wrap_197(Beyond.UI.UIInertiaViewPager.InertiaBlocker& P0, System.Single P1) { }
        // RVA: 0x09AFE8B4  token: 0x6000C0D
        public System.Boolean __Gen_Wrap_198(System.Object P0, System.Single P1, System.Single& P2) { }
        // RVA: 0x054A1120  token: 0x6000C0E
        public System.Void __Gen_Wrap_199(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x087040F0  token: 0x6000C0F
        public System.Void __Gen_Wrap_200(System.Object P0, Beyond.UI.UIInertiaViewPager.State P1, Beyond.UI.UIInertiaViewPager.State P2) { }
        // RVA: 0x0514F720  token: 0x6000C10
        public System.Void __Gen_Wrap_201(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x09AFEAD8  token: 0x6000C11
        public System.Void __Gen_Wrap_202(Beyond.UI.UIInertiaViewPager.EmptyScrollHandler& P0) { }
        // RVA: 0x09AFEBFC  token: 0x6000C12
        public System.Void __Gen_Wrap_203(System.Object P0, System.Boolean P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3) { }
        // RVA: 0x0549D548  token: 0x6000C13
        public System.Void __Gen_Wrap_204(System.Object P0, UnityEngine.UI.CanvasUpdate P1) { }
        // RVA: 0x09AFED48  token: 0x6000C14
        public UnityEngine.Transform __Gen_Wrap_205(System.Object P0) { }
        // RVA: 0x05160F3C  token: 0x6000C15
        public System.Void __Gen_Wrap_206(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        // RVA: 0x09AFEE38  token: 0x6000C16
        public System.Int32 __Gen_Wrap_207(System.Object P0, System.Boolean P1) { }
        // RVA: 0x05E5EF50  token: 0x6000C17
        public System.Single __Gen_Wrap_208(System.Object P0, System.Int32 P1, Beyond.UI.UIScrollList.ScrollAlignType P2) { }
        // RVA: 0x09AFEF24  token: 0x6000C18
        public System.Void __Gen_Wrap_209(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3) { }
        // RVA: 0x09AFF1EC  token: 0x6000C19
        public System.Void __Gen_Wrap_210(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, Beyond.UI.UIScrollList.ScrollAlignType P6) { }
        // RVA: 0x09AFF320  token: 0x6000C1A
        public System.Void __Gen_Wrap_211(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        // RVA: 0x09AFF444  token: 0x6000C1B
        public UnityEngine.GameObject __Gen_Wrap_212(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09AFF53C  token: 0x6000C1C
        public Beyond.UI.UIScrollList.Cell __Gen_Wrap_213(System.Object P0, System.Int32 P1) { }
        // RVA: 0x05613324  token: 0x6000C1D
        public System.Int32 __Gen_Wrap_214(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x0561B0C4  token: 0x6000C1E
        public System.Int32 __Gen_Wrap_215(System.Object P0, System.Int32 P1, UnityEngine.UI.NaviDirection P2) { }
        // RVA: 0x054792E4  token: 0x6000C1F
        public System.Void __Gen_Wrap_216(System.Object P0, System.Single P1, System.Single P2, System.Single P3) { }
        // RVA: 0x09AFF634  token: 0x6000C20
        public System.Boolean __Gen_Wrap_217(System.Object P0, UnityEngine.Vector3 P1) { }
        // RVA: 0x09AFF75C  token: 0x6000C21
        public UnityEngine.Vector3 __Gen_Wrap_218(System.Object P0) { }
        // RVA: 0x09AFF870  token: 0x6000C22
        public System.Single __Gen_Wrap_219(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x09AFFB50  token: 0x6000C23
        public System.Boolean __Gen_Wrap_220(System.Object P0, System.Single P1) { }
        // RVA: 0x09AFFC40  token: 0x6000C24
        public Beyond.UI.UIScrollList.Padding __Gen_Wrap_221(System.Object P0) { }
        // RVA: 0x05637930  token: 0x6000C25
        public System.Void __Gen_Wrap_222(System.Object P0, System.Int32& P1, System.Int32& P2) { }
        // RVA: 0x0561B0C4  token: 0x6000C26
        public System.Int32 __Gen_Wrap_223(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x09AFFD38  token: 0x6000C27
        public System.Int32 __Gen_Wrap_224(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.UI.NaviDirection P2) { }
        // RVA: 0x09AFFE60  token: 0x6000C28
        public System.Void __Gen_Wrap_225(System.Object P0, UnityEngine.Vector2 P1, System.Int32& P2, System.Int32& P3) { }
        // RVA: 0x05477F10  token: 0x6000C29
        public Beyond.UI.UIScrollRect.MoveTipsType __Gen_Wrap_226(System.Object P0) { }
        // RVA: 0x056479C0  token: 0x6000C2A
        public System.Void __Gen_Wrap_227(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P3) { }
        // RVA: 0x09AFFFD0  token: 0x6000C2B
        public System.Void __Gen_Wrap_228(System.Object P0, UnityEngine.Vector2Int P1) { }
        // RVA: 0x05477F10  token: 0x6000C2C
        public Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_229(System.Object P0) { }
        // RVA: 0x09B001C0  token: 0x6000C2D
        public UnityEngine.Rect __Gen_Wrap_230(System.Object P0) { }
        // RVA: 0x09B002B8  token: 0x6000C2E
        public System.Boolean __Gen_Wrap_231(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir P2, System.Object P3) { }
        // RVA: 0x05637930  token: 0x6000C2F
        public System.Void __Gen_Wrap_232(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P2) { }
        // RVA: 0x05477B68  token: 0x6000C30
        public System.Void __Gen_Wrap_233(System.Object P0, System.Boolean P1, System.Single P2) { }
        // RVA: 0x09B003C0  token: 0x6000C31
        public UnityEngine.Vector3 __Gen_Wrap_234(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B004DC  token: 0x6000C32
        public UnityEngine.Vector3[] __Gen_Wrap_235(System.Object P0) { }
        // RVA: 0x09B005CC  token: 0x6000C33
        public UnityEngine.UI.Graphic __Gen_Wrap_236(System.Object P0) { }
        // RVA: 0x09B006BC  token: 0x6000C34
        public Beyond.UI.UISoftMask __Gen_Wrap_237(System.Object P0) { }
        // RVA: 0x09B007AC  token: 0x6000C35
        public System.Boolean __Gen_Wrap_238(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x09B008B4  token: 0x6000C36
        public UnityEngine.Vector2 __Gen_Wrap_239(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4) { }
        // RVA: 0x09B00C10  token: 0x6000C37
        public System.Void __Gen_Wrap_240(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4, System.Single& P5, System.Single& P6) { }
        // RVA: 0x09B00E14  token: 0x6000C38
        public System.Void __Gen_Wrap_241(UnityEngine.UIVertex& P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3) { }
        // RVA: 0x09B01068  token: 0x6000C39
        public System.Void __Gen_Wrap_242(System.Object P0, System.Object P1, System.Object P2, System.Boolean& P3) { }
        // RVA: 0x09B01194  token: 0x6000C3A
        public Beyond.UI.UISoftMaskable __Gen_Wrap_243(System.Object P0) { }
        // RVA: 0x09B01284  token: 0x6000C3B
        public System.Collections.IEnumerator __Gen_Wrap_244(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        // RVA: 0x0872224C  token: 0x6000C3C
        public System.Void __Gen_Wrap_245(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        // RVA: 0x09B01398  token: 0x6000C3D
        public System.Void __Gen_Wrap_246(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4, System.Object P5, System.Boolean P6) { }
        // RVA: 0x05477F10  token: 0x6000C3E
        public System.UInt32 __Gen_Wrap_247(System.Object P0) { }
        // RVA: 0x09B014D0  token: 0x6000C3F
        public System.Void __Gen_Wrap_248(System.UInt32 P0, System.Boolean P1) { }
        // RVA: 0x09B015AC  token: 0x6000C40
        public TMPro.TMP_FontAsset __Gen_Wrap_249(System.Object P0, System.Object P1) { }
        // RVA: 0x09B018A8  token: 0x6000C41
        public System.Boolean __Gen_Wrap_250(System.Object P0, System.Object P1, System.UInt32 P2, TMPro.TMP_FontAsset& P3) { }
        // RVA: 0x09B01A08  token: 0x6000C42
        public System.Boolean __Gen_Wrap_251(System.Single& P0, System.Single P1) { }
        // RVA: 0x09B01B1C  token: 0x6000C43
        public System.Void __Gen_Wrap_252(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Object P1) { }
        // RVA: 0x09B01C80  token: 0x6000C44
        public System.Single __Gen_Wrap_253(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Boolean& P1) { }
        // RVA: 0x09B01E18  token: 0x6000C45
        public UnityEngine.Playables.PlayableGraph __Gen_Wrap_254(System.Object P0) { }
        // RVA: 0x09B01F24  token: 0x6000C46
        public UnityEngine.Animations.AnimationLayerMixerPlayable __Gen_Wrap_255(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2) { }
        // RVA: 0x09B020B8  token: 0x6000C47
        public UnityEngine.Animations.AnimationPlayableOutput __Gen_Wrap_256(System.Object P0, UnityEngine.Playables.PlayableGraph P1) { }
        // RVA: 0x09B02204  token: 0x6000C48
        public UnityEngine.Animations.AnimationClipPlayable __Gen_Wrap_257(System.Object P0, System.Object P1, UnityEngine.Playables.PlayableGraph P2, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& P3) { }
        // RVA: 0x09B023B4  token: 0x6000C49
        public UnityEngine.Animations.AnimationMixerPlayable __Gen_Wrap_258(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2) { }
        // RVA: 0x09B02548  token: 0x6000C4A
        public System.Void __Gen_Wrap_259(System.Boolean P0, Beyond.Resource.FAssetProxyHandle P1) { }
        // RVA: 0x09B027B0  token: 0x6000C4B
        public System.Void __Gen_Wrap_260(Beyond.UI.UISwitchTween.TweenContext& P0) { }
        // RVA: 0x09B028D8  token: 0x6000C4C
        public System.Void __Gen_Wrap_261(Beyond.UI.UISwitchTween.TweenContext& P0, System.Object P1) { }
        // RVA: 0x09B02A1C  token: 0x6000C4D
        public System.Void __Gen_Wrap_262(System.Object P0, Beyond.UI.UISwitchTween.Options P1) { }
        // RVA: 0x09B02B1C  token: 0x6000C4E
        public Beyond.UI.UISwitchTween.TweenContext __Gen_Wrap_263(System.Object P0) { }
        // RVA: 0x09B02BF8  token: 0x6000C4F
        public System.Boolean __Gen_Wrap_264(Beyond.UI.UISwitchTween.TweenContext& P0) { }
        // RVA: 0x09B02D20  token: 0x6000C50
        public System.Single __Gen_Wrap_265(Beyond.UI.FadeSwitchTween.Durations& P0, System.Single P1) { }
        // RVA: 0x09B02E80  token: 0x6000C51
        public Beyond.UI.FadeSwitchTween __Gen_Wrap_266(Beyond.UI.FadeSwitchTween.Builder& P0) { }
        // RVA: 0x09B02FEC  token: 0x6000C52
        public UnityEngine.Vector2 __Gen_Wrap_267(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09B030E4  token: 0x6000C53
        public System.Void __Gen_Wrap_268(System.Object P0, UnityEngine.RectInt& P1) { }
        // RVA: 0x088B5978  token: 0x6000C54
        public System.Boolean __Gen_Wrap_269(System.Object P0, System.Object P1, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& P2) { }
        // RVA: 0x09B032E4  token: 0x6000C55
        public UnityEngine.RectInt __Gen_Wrap_270(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x09B03408  token: 0x6000C56
        public System.Void __Gen_Wrap_271(System.Object P0, System.Object P1, System.Object P2, UnityEngine.RectInt& P3) { }
        // RVA: 0x09B03548  token: 0x6000C57
        public System.Boolean __Gen_Wrap_272(Beyond.UI.UIAtlasManager.UIAtlasHandle& P0) { }
        // RVA: 0x09B03694  token: 0x6000C58
        public System.Void __Gen_Wrap_273(System.Object P0, System.Collections.Generic.List<UnityEngine.RectInt>& P1) { }
        // RVA: 0x050F1370  token: 0x6000C59
        public System.Void __Gen_Wrap_274(System.Int32 P0, System.String P1) { }
        // RVA: 0x050EF298  token: 0x6000C5A
        public System.Boolean __Gen_Wrap_275(Beyond.UI.UIState.StateAnimationInfo P0) { }
        // RVA: 0x09B03770  token: 0x6000C5B
        public Beyond.UI.GPUI.GPUPrefabData __Gen_Wrap_276(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2) { }
        // RVA: 0x09B03920  token: 0x6000C5C
        public Beyond.UI.GPUI.GPUPrefabDataLite __Gen_Wrap_277(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2) { }
        // RVA: 0x09B03AB8  token: 0x6000C5D
        public System.Boolean __Gen_Wrap_278(Beyond.UI.GPUI.GPUIHandle& P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        // RVA: 0x09B03C20  token: 0x6000C5E
        public System.Boolean __Gen_Wrap_279(Beyond.UI.GPUI.GPUIHandle& P0, System.Object P1) { }
        // RVA: 0x09B03E94  token: 0x6000C5F
        public System.Int32 __Gen_Wrap_280(Beyond.UI.GPUI.GPUIHandle& P0) { }
        // RVA: 0x09B03FBC  token: 0x6000C60
        public System.Boolean __Gen_Wrap_281(Beyond.UI.GPUI.GPUIHandle P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        // RVA: 0x09B040E0  token: 0x6000C61
        public Beyond.UI.GPUI.GPUIHandle __Gen_Wrap_282(System.Object P0) { }
        // RVA: 0x09B041D0  token: 0x6000C62
        public System.Void __Gen_Wrap_283(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        // RVA: 0x09B042E0  token: 0x6000C63
        public System.Boolean __Gen_Wrap_284(System.Object P0, System.Object P1, Beyond.UI.GPUI.GPUIHandle& P2, System.Int32 P3) { }
        // RVA: 0x09B04438  token: 0x6000C64
        public System.Boolean __Gen_Wrap_285(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        // RVA: 0x09B04554  token: 0x6000C65
        public System.Void __Gen_Wrap_286(System.Object P0, System.Int32 P1, UnityEngine.Vector3 P2) { }
        // RVA: 0x09B04688  token: 0x6000C66
        public System.Boolean __Gen_Wrap_287(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector3 P2) { }
        // RVA: 0x09B047E0  token: 0x6000C67
        public System.Boolean __Gen_Wrap_288(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, Beyond.UI.GPUI.GPUIHandle& P3, System.Int32 P4) { }
        // RVA: 0x09B04978  token: 0x6000C68
        public System.Boolean __Gen_Wrap_289(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector2 P2) { }
        // RVA: 0x05E4DA84  token: 0x6000C69
        public System.Void __Gen_Wrap_290(System.Object P0, System.Single P1, System.Int32 P2) { }
        // RVA: 0x09B04BA0  token: 0x6000C6A
        public System.Boolean __Gen_Wrap_291(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Object P3, System.Boolean P4) { }
        // RVA: 0x09B04CEC  token: 0x6000C6B
        public System.Boolean __Gen_Wrap_292(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Int32 P3, System.Boolean P4) { }
        // RVA: 0x09B04E24  token: 0x6000C6C
        public System.Boolean __Gen_Wrap_293(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x09B04F4C  token: 0x6000C6D
        public System.UInt32 __Gen_Wrap_294(UnityEngine.Color P0) { }
        // RVA: 0x09B0503C  token: 0x6000C6E
        public System.Void __Gen_Wrap_295(System.Object P0, System.Int32 P1, UnityEngine.Color P2) { }
        // RVA: 0x09B05158  token: 0x6000C6F
        public System.Boolean __Gen_Wrap_296(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, UnityEngine.Color P3) { }
        // RVA: 0x09B052AC  token: 0x6000C70
        public System.Boolean __Gen_Wrap_297(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Object P3) { }
        // RVA: 0x09B053E8  token: 0x6000C71
        public System.Void __Gen_Wrap_298(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32& P2, System.Int32& P3, System.Int32& P4) { }
        // RVA: 0x09B055DC  token: 0x6000C72
        public System.Void __Gen_Wrap_299(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32 P2, System.Boolean P3) { }
        // RVA: 0x09B05860  token: 0x6000C73
        public Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> __Gen_Wrap_300(System.Object P0) { }
        // RVA: 0x050F1FFC  token: 0x6000C74
        public System.Int32 __Gen_Wrap_301(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x09B0596C  token: 0x6000C75
        public Beyond.UI.GPUI.RuntimePrefabData __Gen_Wrap_302(System.Object P0, System.Object P1) { }
        // RVA: 0x09B05A64  token: 0x6000C76
        public UnityEngine.Mesh __Gen_Wrap_303() { }
        // RVA: 0x0561A558  token: 0x6000C77
        public System.UInt32 __Gen_Wrap_304(System.UInt32 P0, System.UInt32 P1) { }
        // RVA: 0x03D06050  token: 0x6000C78
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000163  // size: 0x58
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerator`1
    {
        // Fields
        private System.Int32 methodId_0;  // 0x40
        private System.Int32 methodId_1;  // 0x44
        private System.Int32 methodId_2;  // 0x48
        private System.Int32 methodId_3;  // 0x4c
        private System.Int32 methodId_4;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x09B0B1DC */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09B0B288 */ }

        // Methods
        // RVA: 0x05152EA8  token: 0x6000C79
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05152C48  token: 0x6000C7A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05152D80  token: 0x6000C7C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09B0B334  token: 0x6000C7E
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x6000C7F
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000164  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000C80
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x09B0CF54  token: 0x6000C81
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x02343070  token: 0x6000C82
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x09B0CE10  token: 0x6000C83
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x09B0CEDC  token: 0x6000C84
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x09B0CFB8  token: 0x6000C85
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x09B0CD6C  token: 0x6000C86
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000165  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ResolveTextStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-SetAndResolveTextStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-GetPhoneticText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-SetPhoneticText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnEnvLangChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-set_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ReleaseUpdateFunction0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetOriginalLinkId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetLinkId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_UpdateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_CreateUpdateFunction0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_DelayedChangeActiveImageGo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-ClearMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-GetOrLoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ProcessRichTextEntry0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-get_processRichTextEntryFunc0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ReturnImageGO0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ClearInlineImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_GetOrCreateImageGO0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_GetImageGoByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_ProcessRichTextInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-RefreshPopulateText0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-LoadMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-Remove0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_OnPreRenderText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-DisposeInlineImageCache0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_GenerateRuntimeText0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-IsInvalid0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-get_fontSearchData0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-_RefreshMatTexture0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetI18nFont0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-GetFontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextWrap-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-Add0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-SetHyperlinkUITextGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-ShrinkLinkTags0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetLinkId1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-CombineStringWithLanguageSpilt0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-UpdateI18NFontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-get_m_fontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetCNFontId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-set_m_fontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-set_fontSharedMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-SetSharedMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-OnAfterDeserialize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-AddSubTextObject0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIText-LocalStringCombineFormat0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIConst-IsPadDevice0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIConst-GetResolutionScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-LoadModel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-LoadModelAsync0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-Cancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-UnloadModel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetSharedIntString0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-IsScreenPosInRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-IsScreenPosInRectTransform1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-CalcBoundOfRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-TryGetTouch0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetColorWithoutAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-ClearUIComponents0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-RectTransformToScreenRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetNodeScaleOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetColorByString0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetMaskRatio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetCursorTipOffsetX0;  // const
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-Sync0;  // const
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-Billboard-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-Billboard-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetRealIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-AdjustContainerPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CacheCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ClearShowingCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetShowRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNotCacheRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-MoveCellTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnUpdateCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-RecoverAllInput0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_TryCallAnimationInFinished0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-InformAnimationInEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-ClearTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_InitAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-InformAnimationInStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayWithTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayWithTween1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayOpenAudio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayInAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateShowingCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_moveTips0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateMoveTips0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateViewEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-ScrollToIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_label0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0;  // const
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-get_inputValidTypeMask0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-set_inputValidTypeMask0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-IsShowTypeValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-get_isValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-ToggleActiveState0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-CheckState0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-IsValidInput0;  // const
        public static IFix.IDMAP0 Beyond-UI-DeactivateNaviOnEnable-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-DeactivateNaviOnEnable-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-Empty4Raycast-OnPopulateMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-get_maxFov0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-FixRotation-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0;  // const
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_TrySetRot0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-AddSortingOrderComp0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-RemoveSortingOrderComp0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-BlockAllInput0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_AutoAnimationInFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-get_Radius0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-SetMaterialDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-SetVerticesDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-OnPopulateMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0;  // const
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ClearNullRef0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNotch0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNewNotch0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_OnCanvasChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ClearList0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_TryAddToSideUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_TraverseUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-FindAllSideUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNotch1;  // const
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-UnApplyNotch0;  // const
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-InitConfigs0;  // const
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-ResetValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-RefreshPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_adapter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-SetAdapter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-OnLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_InsertView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RemoveView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-GetVirtualView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-UpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-UpdateCount1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-InsertView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-AddView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-GetVirtualView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-UpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-UpdateCount1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-InsertView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-AddView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0;  // const
        public static IFix.IDMAP0 Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_CacheCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-ClearAllToast0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_GetCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayCloseAudio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayOutAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_TryShowNewCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetOutClipLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_OnCellFinished0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_ShowCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-_StartBatch0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-AddToast0;  // const
        public static IFix.IDMAP0 Beyond-UI-ToastList-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UI3DScrollList-MoveCellTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-DisposeSpriteHandle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-_LoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSpriteWithOutFormat0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_SetSecondIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetSecondActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetActionInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetContentState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetTextStr0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_IsInputGray0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_IsInputEnabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_CheckInteractable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-UpdateKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_TryInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnChangeTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetBindingId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetBindingId1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-_FindByString0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-FindByName0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-FindByNameOrAlias0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-GetAnimationClips0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetOptions0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-IsStarted0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetAnimationInClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetInClipLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetLoopClipLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SkipInAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetClipLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-CheckStopped0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Play0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Play1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationTween-GetValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationTween-_SetValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-ResetToState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-Builder-Build0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-_SetHighlightNodeActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIArea-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-CloseSelf0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-TryCloseSelf0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_GetUICamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ShouldClose0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OpenSelf0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetBigLogoEditor0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ShowBigLogo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetBigLogoMask0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ClearBigLogoMask0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ClearBigLogo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetMaskAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_StopLongPressCor0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_DoClickAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_PlayClickAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnPress0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-get_zoomEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_PosAdjust0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_SetScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnZoom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnControllerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_InitControllerBindings0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshController0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ManuallyZoom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_ResetControllerState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-FocusNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-FocusNode1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ZoomToFullRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ChangePaddingRight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-SetZoomRangeMax0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-SyncZoomValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-GetZoomRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ClearAllTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetMaterialKey0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetTexture0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-ClearMaterialCache0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-get_canvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-_GetCamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-UpdateSortingOrder0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-InitRT0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-SetUseSceneColorPS0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-Register0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-UnRegister0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-UpdateRT0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-SetCustomBlurImg0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_Press0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnUpdateKey0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_InitActionOnSetNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_NotifyIsHover0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-set_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnInteractableChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_bindingViewActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-set_customBindingViewLabelText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_hintText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_bindingViewState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-GetBindingViewActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_RefreshHoverEnableNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-GetMouseActionHints0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnNaviTargetEnabledAgain0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_ToggleNaviInputBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnSetAsNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-_OnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-UpdateCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-AddCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-RemoveCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_ApplyOptToGraphics0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-set_color0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-AttachGraphic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeColorRGB0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeColor1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-_TryStaticInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-SetKeyIconName0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-IsDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-IsDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_SetChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-get_Element0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_GetMarginSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-ResetToDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-ResetToDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-SaveData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-Save0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-_LogEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-Save0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-ResetToDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-get_highlightRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_SetDefaultValues0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-LoadData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-RefreshAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_position0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_scale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_alpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_layoutType0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-get_playing0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ResetPlay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_RefreshPosY0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-RefreshAutoScrollData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Play0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-RefreshText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnVisibleCharactersChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-StopPlay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetAutoWaitTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetScrollSpeed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_TryAutoScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_UpdateTextAuto0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-SeekToEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ManualUpdateByPercent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ManualUpdateByTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-ResetPlay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-get_canvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-UpdateAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-SetRadioIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-ApplyDragArea0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDrag-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-get_m_dragParentRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-_StopDragView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-_ContinueDragOnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-ClearEvents0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_GetDefaultNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ToggleOptions0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ControllerToggle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnStopFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ToggleOptions0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ControllerCancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_NotifyIsHover0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_GetUICamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Update0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-SetSelected0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_GetUICamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ScrollTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-AutoScrollToRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ScrollToSelected0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-get_bindingViewLabelText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-get_bindingViewState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-GetBindingViewActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdownOption-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-SetController0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-get_IsEmpty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGameObject0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGraphic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetTop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetBottom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetLeft0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetRight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyButton0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyAnimator0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyLayoutElement0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyInnerState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-ScheduleForPlaying0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateAnimationInfo-OnUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-ScheduleForStopping0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetLeftLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_SetRealPadding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetContainerSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetContainerSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateContainerSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPadding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyScrollList0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-_ApplyState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-SetState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropdownOption-SetState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ClearEvents0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ToggleHighlight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDrop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-UpdatePosition1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnFoldOut0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnFoldIn0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-_Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-RectWrapNavigate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-WrapNavigation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-TrySyncRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnEnableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-set_color0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-_OnSpriteChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnPopulateMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_AddUIImageToManager0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-AddUIImageToManager0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-SetNativeSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSprite1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-ReleaseSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-get_mainTexture0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImage-_V2AtlasInitialize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnChangeSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillAmountOffset-set_fillAmount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillAmountOffset-DOFillAmount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-RefreshFillAmount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-RefreshFollower0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-LoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-LoadSprite1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-set_color0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-get_first0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PlayAudioGear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_InitIfNot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_SwitchToPage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_AutoAlign0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_OnStateChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-SetPageCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-MoveToPage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-get_isControllerInputValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-SendOnFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-SendOnFocusLost0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardSelect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnSelect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardDeselect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDeselect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-set_s_focusedInputField0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-ActivateInputField0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-DeactivateInputField0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_UpdateBindingEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_NotifyIsHover0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnInteractableChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_GetCamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_UpdateKeyboardOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_CleanupAndroidObjects0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_KeyboardHeightChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateWalkBgScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-set_walkRation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateGait0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateIndicator0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetWalkBgVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetRunBgVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateBg0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_Activate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_ChangeDynamic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_OnHudLayoutLoaded0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-CheckShouldActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-LayoutComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-Rebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_SetDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-UpdateByPlayTime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-SetVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-Exit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-StartAutoPlay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-SetLeftSubTitle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-_TryUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-ForceUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_GetLineCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CalcSomeCountNum0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SyncViewSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-InitBasicInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetLeftLength0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-InitConfig0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_currentStep0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_StartGraduallyShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-StopGraduallyShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SkipGraduallyShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetTargetPosByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-TryClearAdjustTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_ScrollToPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScrollTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-RestartGraduallyShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount1;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount1;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount2;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_curSelectedIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-set_curSelectedIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Get0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCell1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScrollToIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetSelectedIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNaviOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNaviNewIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-NavigateSelected0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitNavigation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-TryRecalculateSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-_GetCellSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_inScrollTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetContainerSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetShowRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-MoveCellTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-get_rectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-SyncSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ScrollTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-get_currentStep0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetStepTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ToggleByState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-Toggle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-FoldAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-Rebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-get_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-set_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_TweenToTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPCScaleHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnValidate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-_IsValidScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-_HoldScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-SetExtraScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-GetExtraScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollbar-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollbarKeyHint-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollbarKeyHint-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-get_viewRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-IsActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_GetDeltaAngle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_CheckCanMove0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateSpeed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_GetRealIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateShowingCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateCenterIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_TryUpdateCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateAuto0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_InitCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_OnAwakeInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateScrollRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_DoScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Rebuild0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-LayoutComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-GraphicUpdateComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-IsDestroyed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-ScrollToIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-UpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Get0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Cell-SetSelect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_SetAutoScrollSpd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnExitAutoScrollUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnExitAutoScrollDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitAutoScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ListWrapNavigate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitControllerNavi0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InGameAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_EditorAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateGraduallyShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetStepTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateAutoScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetTop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount2;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateShowingCells1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetRangeInView0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetCellCanCache0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CacheShowingCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingBottom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingTop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingRight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingLeft0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetPadding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetShowingCellsIndexRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetSpace0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCenterIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetIndexOf0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScreenPos2Index0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetMousePosIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CheckOverScrollEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ScrollToNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_InitController0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_moveTips0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_UpdateMoveTips0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-Update0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-IsCellViewed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-UpdateScrollEnableNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-LateUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_InitIfNot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ApplyTextAlignment0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ResetTextScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ResetTextScrollInternal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-ResetTextScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_UpdateScrollState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ApplyTextScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_InitializeCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-UpdateLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_ApplyDamping0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-RefreshLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-SetSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Play0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Stop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Skip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleStateController-SetState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISimpleStateController-StateInfo-ToString0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_TryPostSlideAudioEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-ClampValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-CustomProcessNormalizedValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnClickSliderBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnClickSliderHandle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_NotifyIsHover0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_ApplyStickScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_StickScrollHoriValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_InitStickScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_AddValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_ReduceValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-_InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-get_bindingViewState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-GetBindingViewActionId0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetCornerCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_graphic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_UpdateChildren0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_UpdateParam0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_DestroyMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_softMask0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_uiText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-GetModifiedMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-ModifyMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_Equal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ComputeLineCross0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_SetUIVertexUV0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ClipRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-ModifyMesh1;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetRenderer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetChildrenRenderers0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-SetOrder0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_GetClampedIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_TryAutoScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_OnScrollEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_OnScrollStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-InitConfig0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-SetTop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-UpdateShowingCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-_IsValidStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-UpdateStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-_SetAsDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-SetSubtitle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-UpdateAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-get_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-set_text0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-set_color0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-get_first0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-SetAndResolveTextStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITextPair-SetPhoneticText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_OnToggleFail0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-TryInternalToggle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshBindingText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshToggleBindingText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_InitToggleBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_UpdateObjects0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_UpdateBindingEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-PlayAudio0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-InternalToggle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnValueChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_NotifyIsHover0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnInteractableChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-GetMouseActionHints0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnSubmit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_ToggleNaviInputBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_OnSetAsNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-_MoveTo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-MoveToNext0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-MoveToPrevious0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_IsSameTouchFromPress0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-DoEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_OnActionPress0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_OnActionRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-ClearTouchInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-SimulateClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-DeActiveTouch0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-get_graphic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-get_softMaskable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_UpdateParam0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_DestroyMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-GetModifiedMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-VirtualMouseInitPos-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-VirtualMouseInitPos-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-_OnConfirm0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-_OnCancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-Show0;  // const
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-ClearAllPanels0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonShort0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0;  // const
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-TickAsCountDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-FLerpByTime-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-FLerpByTime-GetValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-LockToClip0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateGraph0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateMixer0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateOutput0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-_LoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-set_spritePath0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSpriteByName-set_spriteName0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-BeforeShowEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-BeforeHideEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-AfterShowEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-AfterHideEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-ResetToState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-OnReset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-ClearTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-_ClearTweenInternal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Show0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Hide0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-WaitForTweening0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-SetOptions0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-GetContext0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-IsInterapted0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-IsActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-set_activeAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-SetObjectActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-BeforeShowEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-AfterHideEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-ResetToState0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Release0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Builder-Build0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-ResetToState0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0;  // const
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ProcessInsertQueue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_CreateTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ClearTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-OnUnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-Release0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-GetAtlasCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimation-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimation-UnInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimation-AddRedDotImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimationNode-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimationNode-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRedDotAnimationNode-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-WebApplication-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsAnimator0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsButton0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-GetName0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-get_ReadableDescription0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ToString0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsGameObject0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsLayoutElement0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsGraphic0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsScrollList0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_EqualsByTargetType0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-Equals0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-op_Equality0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-op_Inequality0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-Equals1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_GetTargetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnImageChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnScrollListChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnTextChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Run0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Stop0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-HandleScheduledStates0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-_HandleStateAnimations0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-Equals0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-Equals1;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-op_Equality0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-op_Inequality0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-GetFontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-get_fontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-set_fontAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_GetOneHandle0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-Create0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Add0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_CreateInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetRootPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-CreateInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Remove0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-Recycle0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DestroyInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-DestroyInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-IsInstanceValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetRootScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetRootScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-StartAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-StartAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-StartAnimation1;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetVisibility0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_CleanMaterials0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-DoUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RenderNodes0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_InitMaterials0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadGroupData0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-UpdateMaterial0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetVisibility0;  // const
        public static IFix.IDMAP0 Beyond-UI-GPUI-CodePoint-ConvertToUTF320;  // const

    }

}

