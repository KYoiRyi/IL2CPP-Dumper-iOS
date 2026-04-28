// ========================================================
// Dumped by @desirepro
// Assembly: UI.Beyond.dll
// Classes:  357
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

CLASS: UIMinSizeAdjust
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _panelRect  // 0x18
METHODS:
  RVA=0x09AB04D4  token=0x6000001  System.Void Start()
  RVA=0x09AB04DC  token=0x6000002  System.Void _SetTextureScaleByWidth()
  RVA=0x0426FE60  token=0x6000003  System.Void .ctor()
END_CLASS

CLASS: RichTextInfo
TYPE:  abstract class
TOKEN: 0x200000F
SIZE:  0x18
FIELDS:
  public            System.Int32                    index  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600008B  System.Void .ctor()
END_CLASS

CLASS: InlineImageInfo
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x38
EXTENDS: RichTextInfo
FIELDS:
  public            System.String                   path  // 0x18
  public            System.Single                   width  // 0x20
  public            System.Single                   height  // 0x24
  public            UnityEngine.Color               color  // 0x28
METHODS:
  RVA=0x0350B670  token=0x600008C  System.Void .ctor()
END_CLASS

CLASS: RichTextTagType
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextTagTypeImage  // const
  public    static  Beyond.UI.UIText.RichTextTagTypeWidth  // const
  public    static  Beyond.UI.UIText.RichTextTagTypeHeight  // const
  public    static  Beyond.UI.UIText.RichTextTagTypeScale  // const
  public    static  Beyond.UI.UIText.RichTextTagTypeColor  // const
METHODS:
END_CLASS

CLASS: RichTextStyleSeq
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextStyleSeqNORMAL  // const
  public    static  Beyond.UI.UIText.RichTextStyleSeqDARK_BACKGROUND  // const
  public    static  Beyond.UI.UIText.RichTextStyleSeqLIGHT_BACKGROUND  // const
METHODS:
END_CLASS

CLASS: ParamValueType
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeNone  // const
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeString  // const
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeInt  // const
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeFloat  // const
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeColor  // const
METHODS:
END_CLASS

CLASS: RichTextTag
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x18
FIELDS:
  public            Beyond.UI.UIText.RichTextTagTyperichTextTagType  // 0x10
  public            Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeparamValueType  // 0x14
METHODS:
END_CLASS

CLASS: RichTextParam
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x28
FIELDS:
  public            Beyond.UI.UIText.RichTextTagTyperichTextTagType  // 0x10
  public            Beyond.UI.UIText.RichTextAnalyzer.AnyTypeStructvalue  // 0x18
METHODS:
END_CLASS

CLASS: AnyTypeStruct
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x20
FIELDS:
  public            System.Int32                    intValue  // 0x10
  public            System.Single                   floatValue  // 0x10
  public            System.String                   stringValue  // 0x10
  public            UnityEngine.Color               colorValue  // 0x10
METHODS:
END_CLASS

CLASS: ProcessRichTextEntryFunc
TYPE:  sealed class
TOKEN: 0x2000018
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x022B3460  token=0x6000095  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0500C9D0  token=0x6000096  Beyond.UI.UIText.RichTextInfo Invoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  RVA=0x09AAF33C  token=0x6000097  System.IAsyncResult BeginInvoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.AsyncCallback callback, System.Object object)
  RVA=0x050C1584  token=0x6000098  Beyond.UI.UIText.RichTextInfo EndInvoke(Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.IAsyncResult result)
END_CLASS

CLASS: RichTextAnalyzer
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
  private   static  System.Char                     CUSTOM_RICH_TEXT_LEFT_BRACKET  // const
  private   static  System.Char                     CUSTOM_RICH_TEXT_RIGHT_BRACKET  // const
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag>s_tagToTypeDic  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag>s_tagAttributeToTypeDic  // static @ 0x8
  public    static  System.String                   FONT_SHADOW_OPENING_TAG  // const
  public    static  System.String                   FONT_SHADOW_CLOSING_TAG  // const
  public    static  System.String                   FONT_MAT_OPENING_TAG  // const
  public    static  System.String                   FONT_MAT_CLOSING_TAG  // const
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam>s_subParams  // static @ 0x10
METHODS:
  RVA=0x025DEA10  token=0x600008D  System.String PreAnalyzeRichText(System.String text, System.Boolean needParseActionId)
  RVA=0x025E01F0  token=0x600008E  System.String AnalyzeRichText(System.String text, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& infos)
  RVA=0x02EB7ED0  token=0x600008F  System.Boolean _TryParseRichTextEntry(System.ReadOnlySpan<System.Char> span, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, Beyond.UI.UIText.RichTextInfo& richTextInfo)
  RVA=0x02EB9AC0  token=0x6000090  System.Boolean _TryParseParam(System.ReadOnlySpan<System.Char> span, System.Boolean& isMain, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& param)
  RVA=0x09AAF650  token=0x6000091  Beyond.UI.UIText.RichTextInfo ProcessRichTextEntryFallback(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  RVA=0x09AAF3E4  token=0x6000092  System.Int32 GetCharacterCountWithoutRichText(System.ReadOnlySpan<System.Char> str)
  RVA=0x02EB9A40  token=0x6000093  System.Int32 _GetHashCode(System.ReadOnlySpan<System.Char> str)
  RVA=0x02EB7BD0  token=0x6000094  System.Void .cctor()
END_CLASS

CLASS: HyperlinkUITextWrap
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x28
FIELDS:
  public            Beyond.UI.UIText                uiText  // 0x10
  public            System.String                   hyperlinkUITextGroupId  // 0x18
  public            System.Int32                    order  // 0x20
  public            System.Boolean                  isDisplayable  // 0x24
METHODS:
  RVA=0x09AAE844  token=0x6000099  System.Void Clear()
  RVA=0x0350B670  token=0x600009A  System.Void .ctor()
END_CLASS

CLASS: HyperlinkUITextGroup
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x28
FIELDS:
  public            System.Collections.Generic.HashSet<Beyond.UI.UIText.HyperlinkUITextWrap>wrapSet  // 0x10
  public            System.String                   groupId  // 0x18
  public            System.Int32                    displayableCount  // 0x20
METHODS:
  RVA=0x09AADC60  token=0x600009B  System.Void Add(Beyond.UI.UIText.HyperlinkUITextWrap wrap)
  RVA=0x09AADD80  token=0x600009C  System.Void Remove(Beyond.UI.UIText.HyperlinkUITextWrap wrap)
  RVA=0x09AADCFC  token=0x600009D  System.Void ChangeDisplayable(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Boolean displayable)
  RVA=0x09AADE1C  token=0x600009E  System.Void _AddDisplayableCount()
  RVA=0x09AADF44  token=0x600009F  System.Void _SubDisplayableCount()
  RVA=0x09AADE78  token=0x60000A0  System.Void _NotifyDisplayableChanged()
  RVA=0x09AADF9C  token=0x60000A1  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.UI.UIText.HyperlinkUITextManager.<>c<>9  // static @ 0x0
  public    static  System.Comparison<Beyond.UI.UIText.HyperlinkUITextWrap><>9__13_0  // static @ 0x8
  public    static  System.Action<Beyond.UI.UIText.HyperlinkUITextGroup><>9__16_0  // static @ 0x10
  public    static  System.Action<Beyond.UI.UIText.HyperlinkUITextWrap><>9__16_1  // static @ 0x18
METHODS:
  RVA=0x03D14B70  token=0x60000AE  System.Void .cctor()
  RVA=0x0350B670  token=0x60000AF  System.Void .ctor()
  RVA=0x09AAF7A4  token=0x60000B0  System.Int32 <GetGroupDisplayableUIText>b__13_0(Beyond.UI.UIText.HyperlinkUITextWrap a, Beyond.UI.UIText.HyperlinkUITextWrap b)
  RVA=0x09AAF8C4  token=0x60000B1  System.Void <.ctor>b__16_0(Beyond.UI.UIText.HyperlinkUITextGroup group)
  RVA=0x09AAF918  token=0x60000B2  System.Void <.ctor>b__16_1(Beyond.UI.UIText.HyperlinkUITextWrap wrap)
END_CLASS

CLASS: HyperlinkUITextManager
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x28
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIText.HyperlinkUITextGroup>m_hyperlinkUITextGroupMap  // 0x10
  private           Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextGroup>m_hyperlinkUITextGroupPool  // 0x18
  private           Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextWrap>m_hyperlinkUITextWrapPool  // 0x20
  private   static  Beyond.UI.UIText.HyperlinkUITextManagers_instance  // static @ 0x0
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIText.HyperlinkUITextWrap>SORT_WRAP_TEMP_LIST  // static @ 0x8
PROPERTIES:
  instance  get=0x0239EF30
METHODS:
  RVA=0x09AAE03C  token=0x60000A3  System.Void AddWrap(Beyond.UI.UIText uiText, System.String groupId, System.Int32 order)
  RVA=0x0285F940  token=0x60000A4  System.Void RemoveWrap(Beyond.UI.UIText uiText)
  RVA=0x09AAE188  token=0x60000A5  System.Void ChangeWrapGroup(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.String newGroupId, System.Int32 newOrder)
  RVA=0x09AAE2EC  token=0x60000A6  System.Void ChangeWrapOrder(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Int32 newOrder)
  RVA=0x0239F030  token=0x60000A7  System.Void UpdateWrapDisplayable(Beyond.UI.UIText uiText)
  RVA=0x03A4E270  token=0x60000A8  System.Boolean IsGroupDisplayable(System.String groupId)
  RVA=0x09AAE358  token=0x60000A9  System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableUIText(System.String groupId)
  RVA=0x03A4E2C0  token=0x60000AA  Beyond.UI.UIText.HyperlinkUITextGroup _GetGroup(System.String groupId, System.Boolean autoCreate)
  RVA=0x0239F180  token=0x60000AB  System.Boolean _IsUITextDisplayable(Beyond.UI.UIText uiText)
  RVA=0x039281D0  token=0x60000AC  System.Void .ctor()
  RVA=0x03CDF6E0  token=0x60000AD  System.Void .cctor()
END_CLASS

CLASS: ImageGOInfo
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x28
FIELDS:
  public            UnityEngine.GameObject          go  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.UI.Image            image  // 0x20
METHODS:
END_CLASS

CLASS: <_DelayedChangeActiveImageGo>d__110
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIText                <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000B3  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000B4  System.Void System.IDisposable.Dispose()
  RVA=0x0228B0F0  token=0x60000B5  System.Boolean MoveNext()
  RVA=0x0228C6A0  token=0x60000B7  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: AnimationState
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIConst.AnimationStateStop  // const
  public    static  Beyond.UI.UIConst.AnimationStateIn  // const
  public    static  Beyond.UI.UIConst.AnimationStateLoop  // const
  public    static  Beyond.UI.UIConst.AnimationStateOut  // const
  public    static  Beyond.UI.UIConst.AnimationStateInEasing  // const
  public    static  Beyond.UI.UIConst.AnimationStateOthers  // const
METHODS:
END_CLASS

CLASS: CommonUISegment
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIConst.CommonUISegmentInteractiveEntity  // const
  public    static  Beyond.UI.UIConst.CommonUISegmentLevelScriptModule  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000023
SIZE:  0x48
FIELDS:
  public            Beyond.UI.UIModelLoader         <>4__this  // 0x10
  public            System.Int32                    requestId  // 0x18
  public            Beyond.Resource.FAssetProxyHandlehandle  // 0x1c
  public            System.String                   modelPath  // 0x30
  public            UnityEngine.Transform           parent  // 0x38
  public            System.Action<UnityEngine.GameObject>callback  // 0x40
METHODS:
  RVA=0x0350B670  token=0x60000C9  System.Void .ctor()
  RVA=0x09AAF938  token=0x60000CA  System.Void <LoadModelAsync>b__0(Beyond.Resource.FAssetProxyUntrackedHandle proxy)
END_CLASS

CLASS: MeunItemInfo
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x50
FIELDS:
  public            Beyond.UI.UIButton              button  // 0x10
  public            Beyond.UI.UIToggle              toggle  // 0x18
  public            System.Boolean                  showIcon  // 0x20
  public            UnityEngine.Sprite              sprite  // 0x28
  public            Beyond.UI.UIText                text  // 0x30
  public            System.String                   textId  // 0x38
  public            System.String                   textIdForToggleOff  // 0x40
  public            System.Int32                    priority  // 0x48
PROPERTIES:
  isForceValid  get=0x09AAEFD4
METHODS:
  RVA=0x09AAEEB8  token=0x60000F3  System.Boolean IsValid()
  RVA=0x09AAED88  token=0x60000F4  System.String GetText()
  RVA=0x09AAEC78  token=0x60000F5  UnityEngine.Sprite GetSprite()
  RVA=0x09AAE9D4  token=0x60000F6  System.Void Execute()
  RVA=0x09AAEB50  token=0x60000F7  System.String GetItemName()
  RVA=0x03D59690  token=0x60000F8  System.Void .ctor()
END_CLASS

CLASS: OverrideValidState
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateNone  // const
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateForceValid  // const
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateForceNotValid  // const
METHODS:
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnEnable  // const
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnDisable  // const
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnDestroy  // const
METHODS:
END_CLASS

CLASS: <_AutoAnimationInFinish>d__61
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.LuaPanel              <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600015E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600015F  System.Void System.IDisposable.Dispose()
  RVA=0x02872520  token=0x6000160  System.Boolean MoveNext()
  RVA=0x09AAFD78  token=0x6000162  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ShapeType
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.NonDrawingGraphic.ShapeTypeRectangle  // const
  public    static  Beyond.UI.NonDrawingGraphic.ShapeTypeCircle  // const
METHODS:
END_CLASS

CLASS: <>c__19`1
TYPE:  sealed class
TOKEN: 0x2000041
FIELDS:
  public    static readonly Beyond.UI.NotchAdapter.<>c__19<T><>9  // static @ 0x0
  public    static  System.Predicate<T>             <>9__19_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600018B  System.Void .cctor()
  RVA=-1  // not resolved  token=0x600018C  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600018D  System.Boolean <_RemoveNullRef>b__19_0(T x)
END_CLASS

CLASS: ParallaxConfig
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x28
FIELDS:
  public            UnityEngine.RectTransform       target  // 0x10
  public            System.Single                   ratio  // 0x18
  public            UnityEngine.Vector2             oriPosition  // 0x1c
METHODS:
  RVA=0x0350B670  token=0x6000194  System.Void .ctor()
END_CLASS

CLASS: ICustomViewType
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
PROPERTIES:
  viewType  get=-1  // abstract
METHODS:
END_CLASS

CLASS: ICustomSpacing
TYPE:  interface
TOKEN: 0x2000047
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001A3  System.Single GetCustomSpacing()
END_CLASS

CLASS: IVirtualView
TYPE:  interface
TOKEN: 0x2000048
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001A4  System.Void AttachView(UnityEngine.GameObject view)
  RVA=-1  // abstract  token=0x60001A5  System.Void DetachView()
  RVA=-1  // abstract  token=0x60001A6  UnityEngine.GameObject GetAttachedView()
  RVA=-1  // abstract  token=0x60001A7  System.Int32 GetViewID()
  RVA=-1  // abstract  token=0x60001A8  UnityEngine.GameObject GetPrefab()
  RVA=-1  // abstract  token=0x60001A9  System.Single GetPreferSize()
END_CLASS

CLASS: VirtualView
TYPE:  abstract class
TOKEN: 0x2000049
SIZE:  0x18
IMPLEMENTS: IVirtualView Beyond.IHotfixable
FIELDS:
  protected         UnityEngine.GameObject          m_gameObj  // 0x10
PROPERTIES:
  isAttached  get=0x09ACA6F8
METHODS:
  RVA=0x09ACA540  token=0x60001AB  System.Void AttachView(UnityEngine.GameObject gameObj)
  RVA=0x09ACA5EC  token=0x60001AC  System.Void DetachView()
  RVA=0x09ACA650  token=0x60001AD  UnityEngine.GameObject GetAttachedView()
  RVA=0x09ACA6A0  token=0x60001AE  System.Int32 GetViewID()
  RVA=-1  // abstract  token=0x60001AF  System.Void OnViewAttached()
  RVA=-1  // abstract  token=0x60001B0  System.Void OnViewDetached()
  RVA=-1  // abstract  token=0x60001B1  UnityEngine.GameObject GetPrefab()
  RVA=-1  // abstract  token=0x60001B2  System.Single GetPreferSize()
  RVA=0x0350B670  token=0x60001B3  System.Void .ctor()
END_CLASS

CLASS: SimpleAdapter
TYPE:  class
TOKEN: 0x200004B
EXTENDS: Beyond.UI.UIRecycleLayoutAdapter
FIELDS:
  private           Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView>m_holder  // 0x0
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView>m_virtualViews  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001C3  System.Void .ctor(Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> holder)
  RVA=-1  // not resolved  token=0x60001C4  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  RVA=-1  // not resolved  token=0x60001C5  System.Void NotifyRebuild()
  RVA=-1  // not resolved  token=0x60001C6  System.Void InsertView(System.Int32 index, TVirtualView virtualView)
  RVA=-1  // not resolved  token=0x60001C7  System.Void AppendView(TVirtualView virtualView)
  RVA=-1  // not resolved  token=0x60001C8  System.Void AddView(TVirtualView virtualView)
  RVA=-1  // not resolved  token=0x60001C9  System.Void RemoveView(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001CA  System.Void RemoveAllViews(System.Boolean dontRebuild)
  RVA=-1  // not resolved  token=0x60001CB  System.Int32 GetCount()
  RVA=-1  // not resolved  token=0x60001CC  TVirtualView GetVirtualView(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001CD  UnityEngine.GameObject GetView(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001CE  System.Void NotifySizeChanged(TVirtualView virtualView)
  RVA=-1  // not resolved  token=0x60001CF  System.Void NotifyAllSizeChanged()
  RVA=-1  // not resolved  token=0x60001D0  System.Void NotifySizeChanged(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001D1  System.Void OnInit()
  RVA=-1  // not resolved  token=0x60001D2  System.Void OnDisposed()
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x200004C
FIELDS:
  public            Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView><>4__this  // 0x0
  public            System.Int32                    naviIndex  // 0x0
  public            System.Boolean                  isBefore  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001D3  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001D4  System.Void <_WrapNavigation>b__0()
END_CLASS

CLASS: Direction
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIRecycleLayoutGroup.DirectionVertical  // const
  public    static  Beyond.UI.UIRecycleLayoutGroup.DirectionHorizontal  // const
METHODS:
END_CLASS

CLASS: AdaptMode
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIRecycleLayoutGroup.AdaptModeNormal  // const
  public    static  Beyond.UI.UIRecycleLayoutGroup.AdaptModeMultiPrefab  // const
METHODS:
END_CLASS

CLASS: IViewHandler
TYPE:  interface
TOKEN: 0x2000050
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001FA  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index)
  RVA=-1  // abstract  token=0x60001FB  System.Int32 GetViewCount()
  RVA=-1  // abstract  token=0x60001FC  System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=-1  // abstract  token=0x60001FD  System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=-1  // abstract  token=0x60001FE  System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=-1  // abstract  token=0x60001FF  System.Void NotifyAllViewSizeChanged()
  RVA=-1  // abstract  token=0x6000200  System.Void NotifyRebuild()
  RVA=-1  // abstract  token=0x6000201  System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=-1  // abstract  token=0x6000202  System.Single GetElementPosByIndex(System.Int32 index)
  RVA=-1  // abstract  token=0x6000203  UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index)
  RVA=-1  // abstract  token=0x6000204  Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection()
  RVA=-1  // abstract  token=0x6000205  System.Single GetSizeOnAxis()
  RVA=-1  // abstract  token=0x6000206  System.Single GetViewportSizeOnAxis()
  RVA=-1  // abstract  token=0x6000207  System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
END_CLASS

CLASS: LayoutMeta
TYPE:  sealed struct
TOKEN: 0x2000051
SIZE:  0x20
FIELDS:
  public            System.Single                   pos  // 0x10
  public            System.Single                   size  // 0x14
  public            System.Int32                    index  // 0x18
  public            System.Single                   curTotalSize  // 0x1c
METHODS:
END_CLASS

CLASS: ViewPool
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x38
FIELDS:
  private           UnityEngine.GameObject          m_prefab  // 0x10
  private           UnityEngine.Transform           m_container  // 0x18
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_activeObjs  // 0x20
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_pooledObjs  // 0x28
  private           System.Int32                    <viewType>k__BackingField  // 0x30
PROPERTIES:
  viewType  get=0x03D4ED20  set=0x03D4EE10
METHODS:
  RVA=0x09ACA450  token=0x600020A  System.Void .ctor(System.Int32 viewType, UnityEngine.GameObject prefab, UnityEngine.Transform container)
  RVA=0x09AC9FD8  token=0x600020B  UnityEngine.GameObject Alloc(System.Boolean& isNewlyCreated)
  RVA=0x09ACA2A4  token=0x600020C  System.Boolean Recycle(UnityEngine.GameObject obj)
  RVA=0x09ACA168  token=0x600020D  System.Void RecycleAll()
END_CLASS

CLASS: ViewMgr
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x28
IMPLEMENTS: Beyond.IHotfixable IViewHandler
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup  m_closure  // 0x10
  private           Beyond.ListDict<System.Int32,Beyond.UI.UIRecycleLayoutGroup.ViewPool>m_viewPools  // 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView>m_views  // 0x20
METHODS:
  RVA=0x09AC9F00  token=0x600020E  System.Void .ctor(Beyond.UI.UIRecycleLayoutGroup closure)
  RVA=0x09AC9A24  token=0x600020F  System.Void RebuildAll(Beyond.UI.UIRecycleLayoutAdapter adapter)
  RVA=0x09AC9828  token=0x6000210  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GetViews()
  RVA=0x09AC93DC  token=0x6000211  System.Void DetachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, UnityEngine.GameObject curView)
  RVA=0x09AC92F0  token=0x6000212  System.Void AttachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9708  token=0x6000213  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index)
  RVA=0x09AC9694  token=0x6000214  System.Int32 GetViewCount()
  RVA=0x09AC9878  token=0x6000215  System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9254  token=0x6000216  System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9C78  token=0x6000217  System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC99B4  token=0x6000218  System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9900  token=0x6000219  System.Void NotifyAllViewSizeChanged()
  RVA=0x09AC995C  token=0x600021A  System.Void NotifyRebuild()
  RVA=0x09AC95D0  token=0x600021B  System.Single GetElementPosByIndex(System.Int32 index)
  RVA=0x09AC94CC  token=0x600021C  UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index)
  RVA=0x09AC9474  token=0x600021D  Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection()
  RVA=0x09AC9638  token=0x600021E  System.Single GetSizeOnAxis()
  RVA=0x09AC9790  token=0x600021F  System.Single GetViewportSizeOnAxis()
  RVA=0x09AC9564  token=0x6000220  System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9CEC  token=0x6000221  Beyond.UI.UIRecycleLayoutGroup.ViewPool _EnsureViewPool(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC9E6C  token=0x6000222  System.Void _NotifyLayoutChanged(System.Int32 fromIndex)
END_CLASS

CLASS: Padding
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x20
FIELDS:
  public            System.Int32                    top  // 0x10
  public            System.Int32                    left  // 0x14
  public            System.Int32                    bottom  // 0x18
  public            System.Int32                    right  // 0x1c
METHODS:
END_CLASS

CLASS: EmptyAdapter
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x18
EXTENDS: Beyond.UI.UIRecycleLayoutAdapter
FIELDS:
METHODS:
  RVA=0x09ABFF90  token=0x6000223  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  RVA=0x09ABFFDC  token=0x6000224  System.Void OnInit()
  RVA=0x0350B670  token=0x6000225  System.Void .ctor()
  RVA=0x09AC0020  token=0x6000226  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> <>iFixBaseProxy_GenerateViewsForRebuild()
END_CLASS

CLASS: MultiVirtualView
TYPE:  class
TOKEN: 0x2000057
SIZE:  0x30
EXTENDS: VirtualView
FIELDS:
  private           Beyond.UI.UIRecycleMultiHolder  m_closure  // 0x18
  public            System.Single                   preferSize  // 0x20
  public            System.String                   prefabKey  // 0x28
METHODS:
  RVA=0x09AC0028  token=0x600022F  System.Int32 GetIndex()
  RVA=0x09AC0300  token=0x6000230  System.Void .ctor(System.Single initSize, System.String key, Beyond.UI.UIRecycleMultiHolder closure)
  RVA=0x09AC00F4  token=0x6000231  UnityEngine.GameObject GetPrefab()
  RVA=0x09AC0178  token=0x6000232  System.Single GetPreferSize()
  RVA=0x09AC0264  token=0x6000233  System.Void OnViewDetached()
  RVA=0x09AC01C8  token=0x6000234  System.Void OnViewAttached()
END_CLASS

CLASS: Config
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x20
FIELDS:
  public            System.String                   key  // 0x10
  public            UnityEngine.GameObject          cellTemplate  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000235  System.Void .ctor()
END_CLASS

CLASS: SimpleVirtualView
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x28
EXTENDS: VirtualView
FIELDS:
  private           Beyond.UI.UIRecycleSingleHolder m_holder  // 0x18
  public            System.Single                   preferSize  // 0x20
METHODS:
  RVA=0x09AC0FA4  token=0x600023E  System.Int32 GetIndex()
  RVA=0x09AC1278  token=0x600023F  System.Void .ctor(System.Single initSize, Beyond.UI.UIRecycleSingleHolder holder)
  RVA=0x09AC105C  token=0x6000240  UnityEngine.GameObject GetPrefab()
  RVA=0x09AC10B8  token=0x6000241  System.Single GetPreferSize()
  RVA=0x09AC11C0  token=0x6000242  System.Void OnViewDetached()
  RVA=0x09AC1108  token=0x6000243  System.Void OnViewAttached()
END_CLASS

CLASS: CellInfo
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x30
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.GameObject          obj  // 0x18
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x20
  public            UnityEngine.Coroutine           cor  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000258  System.Void .ctor()
END_CLASS

CLASS: <_ShowCell>d__23
TYPE:  sealed class
TOKEN: 0x200005E
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Int32                    delayIndex  // 0x20
  public            Beyond.UI.ToastList.CellInfo    cell  // 0x28
  public            Beyond.UI.ToastList             <>4__this  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000259  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600025A  System.Void System.IDisposable.Dispose()
  RVA=0x09AC23A4  token=0x600025B  System.Boolean MoveNext()
  RVA=0x09AC25F8  token=0x600025D  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ClipHolder
TYPE:  class
TOKEN: 0x2000062
SIZE:  0x20
FIELDS:
  public            UnityEngine.AnimationClip       clip  // 0x10
  public            System.String                   alias  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600028F  System.Void .ctor()
END_CLASS

CLASS: AnimationRuntime
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x28
FIELDS:
  public            Beyond.UI.UIAnimationTween.Optionsoption  // 0x10
  public            UnityEngine.AnimationState      state  // 0x18
  public            System.Boolean                  isPlaying  // 0x20
METHODS:
  RVA=0x025CF420  token=0x60002C7  System.Single GetClipLength()
  RVA=0x0350B670  token=0x60002C8  System.Void .ctor()
END_CLASS

CLASS: FOptions
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x14
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
  public            DG.Tweening.Ease                animEase  // 0x10
METHODS:
  RVA=0x028159A0  token=0x60002C9  Beyond.UI.UIAnimationWrapper.FOptions GetDefault()
END_CLASS

CLASS: CachedSampleClipInfo
TYPE:  sealed struct
TOKEN: 0x2000067
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIAnimationWrapper.AnimationRuntimeruntime  // 0x10
  public            System.Single                   position  // 0x18
  public            System.Boolean                  isDirty  // 0x1c
METHODS:
  RVA=0x04271BD0  token=0x60002CA  System.Void .ctor(System.Boolean isDirty)
END_CLASS

CLASS: <>c__DisplayClass35_0
TYPE:  sealed class
TOKEN: 0x2000068
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    <>4__this  // 0x10
  public            DG.Tweening.TweenCallback       callback  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60002CB  System.Void .ctor()
  RVA=0x036B95E0  token=0x60002CC  System.Void <PlayOutAnimation>b__0()
END_CLASS

CLASS: <>c__DisplayClass44_0
TYPE:  sealed class
TOKEN: 0x2000069
SIZE:  0x28
FIELDS:
  public            DG.Tweening.TweenCallback       callback  // 0x10
  public            Beyond.UI.UIAnimationWrapper    <>4__this  // 0x18
  public            System.Boolean                  autoPlayLoop  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60002CD  System.Void .ctor()
  RVA=0x0228CD50  token=0x60002CE  System.Void <PlayInAnimation>b__0()
END_CLASS

CLASS: <>c__DisplayClass51_0
TYPE:  sealed class
TOKEN: 0x200006A
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    <>4__this  // 0x10
  public            System.Boolean                  autoPlayLoop  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60002CF  System.Void .ctor()
  RVA=0x0228CD90  token=0x60002D0  System.Void <_OnInAnimationFinished>b__0()
END_CLASS

CLASS: <>c__DisplayClass72_0
TYPE:  sealed class
TOKEN: 0x200006B
SIZE:  0x28
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    <>4__this  // 0x10
  public            DG.Tweening.TweenCallback       onComplete  // 0x18
  public            Beyond.UI.UIAnimationTween      animTween  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60002D1  System.Void .ctor()
  RVA=0x0228CDC0  token=0x60002D2  System.Void <PlayWithTween>b__0()
END_CLASS

CLASS: Options
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x18
FIELDS:
  public            System.Boolean                  isInverse  // 0x10
  public            System.Single                   startPosition  // 0x14
METHODS:
END_CLASS

CLASS: <>c__DisplayClass14_0
TYPE:  sealed class
TOKEN: 0x200006E
SIZE:  0x28
FIELDS:
  public            Beyond.UI.UIAnimationTween      <>4__this  // 0x10
  public            Beyond.UI.UIAnimationWrapper    wrapper  // 0x18
  public            System.String                   name  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60002DC  System.Void .ctor()
  RVA=0x025CD4D0  token=0x60002DD  System.Void <.ctor>b__0(System.Single value)
  RVA=0x025CD510  token=0x60002DE  System.Void <.ctor>b__2(System.Single value)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200006F
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.UI.UIAnimationTween.<>c  <>9  // static @ 0x0
  public    static  DG.Tweening.Core.DOGetter<System.Single><>9__14_1  // static @ 0x8
METHODS:
  RVA=0x03D10C10  token=0x60002DF  System.Void .cctor()
  RVA=0x0350B670  token=0x60002E0  System.Void .ctor()
  RVA=0x03D503F0  token=0x60002E1  System.Single <.ctor>b__14_1()
END_CLASS

CLASS: TweenHandler
TYPE:  class
TOKEN: 0x2000071
SIZE:  0x30
IMPLEMENTS: ITweenHandler Beyond.IHotfixable
FIELDS:
  private           Beyond.UI.UIAnimationSwitchTweenm_closure  // 0x10
  private           System.Boolean                  m_isIn  // 0x18
  private           System.Boolean                  m_pendingClear  // 0x19
  private           DG.Tweening.TweenCallback       m_pendingCallback  // 0x20
  private           System.Boolean                  m_isComplete  // 0x28
METHODS:
  RVA=0x09AC22B4  token=0x60002EC  System.Void .ctor(Beyond.UI.UIAnimationSwitchTween closure, System.Boolean isIn)
  RVA=0x09AC1FF0  token=0x60002ED  System.Boolean IsPlaying()
  RVA=0x09AC20B8  token=0x60002EE  System.Void KillIfNecessary()
  RVA=0x09AC2178  token=0x60002EF  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  RVA=0x09AC21F4  token=0x60002F0  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
  RVA=0x09AC224C  token=0x60002F1  System.Void _OnComplete()
END_CLASS

CLASS: Builder
TYPE:  sealed struct
TOKEN: 0x2000072
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    animWrapper  // 0x10
  public            System.Boolean                  dontDisableGameObject  // 0x18
METHODS:
  RVA=0x09ABFEEC  token=0x60002F2  Beyond.UI.UIAnimationSwitchTween Build()
END_CLASS

CLASS: <>c__DisplayClass81_0
TYPE:  sealed class
TOKEN: 0x2000078
SIZE:  0x18
FIELDS:
  public            DG.Tweening.TweenCallback       onComplete  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600036E  System.Void .ctor()
  RVA=0x03D4CF30  token=0x600036F  System.Void <FocusNode>b__0()
END_CLASS

CLASS: <_DoClickAnimation>d__30
TYPE:  sealed class
TOKEN: 0x200007D
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIButton              <>4__this  // 0x20
  private           System.Single                   <currentTime>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003E0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003E1  System.Void System.IDisposable.Dispose()
  RVA=0x09ACABAC  token=0x60003E2  System.Boolean MoveNext()
  RVA=0x09ACACEC  token=0x60003E4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_OnPress>d__59
TYPE:  sealed class
TOKEN: 0x200007E
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIButton              <>4__this  // 0x20
  public            UnityEngine.EventSystems.PointerEventDataeventData  // 0x28
  private           System.Single                   <finishTime>5__2  // 0x30
  private           UnityEngine.Vector2             <pressPos>5__3  // 0x34
  private           System.Single                   <_longPressMaxDragDistSq>5__4  // 0x3c
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003E6  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003E7  System.Void System.IDisposable.Dispose()
  RVA=0x02CACAB0  token=0x60003E8  System.Boolean MoveNext()
  RVA=0x09ACAD38  token=0x60003EA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FWorldCanvasParams
TYPE:  sealed struct
TOKEN: 0x2000081
SIZE:  0x30
FIELDS:
  public            System.Single                   screenRatio  // 0x10
  public            UnityEngine.Vector2             screenSize  // 0x14
  public            UnityEngine.Vector2             uiRootSize  // 0x1c
  public            UnityEngine.Vector3             uiRootScale  // 0x24
METHODS:
END_CLASS

CLASS: FScreenCanvasParams
TYPE:  sealed struct
TOKEN: 0x2000082
SIZE:  0x24
FIELDS:
  public            System.Single                   screenRatio  // 0x10
  public            UnityEngine.Vector2             screenSize  // 0x14
  public            Beyond.UI.CanvasMatchMode       matchMode  // 0x1c
  public            System.Single                   matchWidthOrHeight  // 0x20
METHODS:
END_CLASS

CLASS: CommonParams
TYPE:  sealed struct
TOKEN: 0x2000084
SIZE:  0x30
FIELDS:
  public            System.Single                   alpha  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Boolean                  ignoreTimeScale  // 0x18
  public            UnityEngine.Color               targetColor  // 0x1c
  public            System.Boolean                  useAlpha  // 0x2c
  public            System.Boolean                  useRGB  // 0x2d
  public            System.Boolean                  isStaticColorOpt  // 0x2e
METHODS:
END_CLASS

CLASS: GraphicOpt
TYPE:  sealed class
TOKEN: 0x2000085
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x036F88F0  token=0x6000412  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x05015A50  token=0x6000413  System.Void Invoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x09ACA748  token=0x6000414  System.IAsyncResult BeginInvoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000415  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DynEle
TYPE:  sealed struct
TOKEN: 0x2000086
SIZE:  0x28
FIELDS:
  public            System.String                   groupId  // 0x10
  public            UnityEngine.UI.Graphic          graphic  // 0x18
  public            System.Boolean                  useStaticColor  // 0x20
METHODS:
END_CLASS

CLASS: LayoutType
TYPE:  sealed struct
TOKEN: 0x200008A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UICustomLayoutElement.LayoutTypeNone  // const
  public    static  Beyond.UI.UICustomLayoutElement.LayoutTypeLeftToRight  // const
METHODS:
END_CLASS

CLASS: LayoutData
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x28
FIELDS:
  public            System.Int32                    verNum  // 0x10
  public            System.Single                   scale  // 0x14
  public            System.Single                   alpha  // 0x18
  public            UnityEngine.Vector2             position  // 0x1c
  public            System.Int32                    layoutType  // 0x24
METHODS:
  RVA=0x0350B670  token=0x6000446  System.Void .ctor()
END_CLASS

CLASS: UpdateMode
TYPE:  sealed struct
TOKEN: 0x200008E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIDialogText.UpdateModeAuto  // const
  public    static  Beyond.UI.UIDialogText.UpdateModeManual  // const
METHODS:
END_CLASS

CLASS: <_ContinueDragOnDisable>d__40
TYPE:  sealed class
TOKEN: 0x2000096
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIDragItem            <>4__this  // 0x20
  private           UnityEngine.EventSystems.PointerEventData<eData>5__2  // 0x28
  private           Beyond.PoolCore.PooledList<UnityEngine.EventSystems.RaycastResult><raycastResults>5__3  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60004C1  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60004C2  System.Void System.IDisposable.Dispose()
  RVA=0x09ACA7D0  token=0x60004C3  System.Boolean MoveNext()
  RVA=0x09ACAB60  token=0x60004C5  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass44_0
TYPE:  sealed class
TOKEN: 0x2000098
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIDropdown            <>4__this  // 0x10
  public            System.Boolean                  activeList  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60004F5  System.Void .ctor()
  RVA=0x09AD4B8C  token=0x60004F6  System.Void <_ToggleOptions>b__0()
END_CLASS

CLASS: <>c__DisplayClass48_0
TYPE:  sealed class
TOKEN: 0x2000099
SIZE:  0x20
FIELDS:
  public            System.Int32                    index  // 0x10
  public            Beyond.UI.UIDropdown            <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60004F7  System.Void .ctor()
  RVA=0x02D99980  token=0x60004F8  System.Void <Refresh>b__0(UnityEngine.EventSystems.PointerEventData evt)
END_CLASS

CLASS: <>c__DisplayClass11_0
TYPE:  sealed class
TOKEN: 0x20000A1
SIZE:  0x20
FIELDS:
  public            System.Single                   startSize  // 0x10
  public            Beyond.UI.UIFoldoutComponent    <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600052C  System.Void .ctor()
  RVA=0x03D4E7A0  token=0x600052D  System.Single <OnFoldOut>b__0()
  RVA=0x09AD4B58  token=0x600052E  System.Void <OnFoldOut>b__1(System.Single value)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x20
FIELDS:
  public            System.Single                   startSize  // 0x10
  public            Beyond.UI.UIFoldoutComponent    <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600052F  System.Void .ctor()
  RVA=0x03D4E7A0  token=0x6000530  System.Single <OnFoldIn>b__0()
  RVA=0x09AD4B58  token=0x6000531  System.Void <OnFoldIn>b__1(System.Single value)
END_CLASS

CLASS: WrapMode
TYPE:  sealed struct
TOKEN: 0x20000A6
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeNaviGroup  // const
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeScrollRect  // const
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeScrollList  // const
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeLayoutNaviWrapper  // const
METHODS:
END_CLASS

CLASS: Param
TYPE:  class
TOKEN: 0x20000A8
SIZE:  0x20
FIELDS:
  public            System.Single                   maxAngle  // 0x10
  public            UnityEngine.AnimationCurve      valueCurve  // 0x18
METHODS:
  RVA=0x03D47CC0  token=0x6000554  System.Void .ctor()
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x20000B1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.StateIDLE  // const
  public    static  Beyond.UI.UIInertiaViewPager.StateDRAGING  // const
  public    static  Beyond.UI.UIInertiaViewPager.StateINERTIA  // const
  public    static  Beyond.UI.UIInertiaViewPager.StateALIGNING  // const
METHODS:
END_CLASS

CLASS: IScrollHandler
TYPE:  interface
TOKEN: 0x20000B2
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
PROPERTIES:
  velocity  get=-1  // abstract
  isDragging  get=-1  // abstract
  scrollProgress  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60005C9  System.Void OnClear()
  RVA=-1  // abstract  token=0x60005CE  System.Void StopMoving()
END_CLASS

CLASS: CustomScrollHandler
TYPE:  class
TOKEN: 0x20000B3
SIZE:  0x20
IMPLEMENTS: IScrollHandler Beyond.IHotfixable
FIELDS:
  private           System.Boolean                  m_isScrolling  // 0x10
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x18
PROPERTIES:
  velocity  get=0x09AD442C
  scrollProgress  get=0x09AD43A0  set=0x09AD44AC
  isDragging  get=0x09AD4378
METHODS:
  RVA=0x09AD4258  token=0x60005CF  System.Void .ctor(Beyond.UI.UIScrollRect scrollRect)
  RVA=0x09AD3FF4  token=0x60005D0  System.Void OnClear()
  RVA=0x09AD4138  token=0x60005D5  System.Void StopMoving()
  RVA=0x09AD4198  token=0x60005D6  System.Void _OnScrollBegin(UnityEngine.Vector2 delta)
  RVA=0x09AD41F8  token=0x60005D7  System.Void _OnScrollEnd(UnityEngine.Vector2 delta)
END_CLASS

CLASS: EmptyScrollHandler
TYPE:  sealed struct
TOKEN: 0x20000B4
SIZE:  0x11
IMPLEMENTS: IScrollHandler Beyond.IHotfixable
FIELDS:
PROPERTIES:
  velocity  get=0x03D503F0
  isDragging  get=0x0115F4C0
  scrollProgress  get=0x03D503F0  set=0x0350B670
METHODS:
  RVA=0x09AD47C4  token=0x60005DC  System.Void StopMoving()
  RVA=0x09AD4780  token=0x60005DD  System.Void OnClear()
END_CLASS

CLASS: FlingToNext
TYPE:  sealed struct
TOKEN: 0x20000B5
SIZE:  0x1C
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   minSpd  // 0x14
  public            System.Single                   maxSpd  // 0x18
METHODS:
END_CLASS

CLASS: ScrollOptions
TYPE:  sealed struct
TOKEN: 0x20000B6
SIZE:  0x1C
FIELDS:
  public            Beyond.UI.UIInertiaViewPager.FlingToNextflingToNext  // 0x10
METHODS:
END_CLASS

CLASS: DragContext
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x18
FIELDS:
  public            System.Single                   startPos  // 0x10
METHODS:
  RVA=0x09AD4540  token=0x60005DE  System.Void BeginDrag(Beyond.UI.UIInertiaViewPager pager)
  RVA=0x09AD45B0  token=0x60005DF  Beyond.UI.UIInertiaViewPager.State EndDrag(Beyond.UI.UIInertiaViewPager pager)
  RVA=0x09AD461C  token=0x60005E0  System.Boolean _TryFlingToNext(Beyond.UI.UIInertiaViewPager pager)
  RVA=0x0350B670  token=0x60005E1  System.Void .ctor()
END_CLASS

CLASS: BlockerDir
TYPE:  sealed struct
TOKEN: 0x20000B8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirUPWARD  // const
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirDOWNNWARD  // const
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirBOTH  // const
METHODS:
END_CLASS

CLASS: InertiaBlocker
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x18
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
  public            Beyond.UI.UIInertiaViewPager.BlockerDirdir  // 0x10
  public            System.Int32                    index  // 0x14
METHODS:
  RVA=0x09AD4808  token=0x60005E2  System.Boolean IsDirMatch(System.Single vec)
END_CLASS

CLASS: BlockerManager
TYPE:  class
TOKEN: 0x20000BA
SIZE:  0x20
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
  private   static  System.Single                   INERTIA_BIAS  // const
  private           System.Collections.Generic.List<Beyond.UI.UIInertiaViewPager.InertiaBlocker>m_inertiaBlockers  // 0x10
  private           System.Single                   m_lastIndex  // 0x18
  private           System.Boolean                  <isInertiaing>k__BackingField  // 0x1c
PROPERTIES:
  isInertiaing  get=0x03D4E9A0  set=0x03D4E9B0
METHODS:
  RVA=0x09AD3D84  token=0x60005E5  System.Void Init(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> blockFrames)
  RVA=0x09AD3F1C  token=0x60005E6  System.Void StartInertia(System.Single fromIndex)
  RVA=0x09AD3B88  token=0x60005E7  System.Boolean HitInertiaBlock(System.Single curIndex, System.Single& preferTo)
  RVA=0x09AD3F7C  token=0x60005E8  System.Void .ctor()
END_CLASS

CLASS: Timing
TYPE:  sealed struct
TOKEN: 0x20000BC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.TimingHALF_VALUE  // const
  public    static  Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.TimingFULL_VALUE  // const
METHODS:
END_CLASS

CLASS: ScrollEffectConfig
TYPE:  sealed struct
TOKEN: 0x20000BB
SIZE:  0x28
FIELDS:
  public            System.Action                   onScrollToItem  // 0x10
  public            System.Action                   onAlignedToItem  // 0x18
  public            System.Single                   minScrollInterval  // 0x20
  public            Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timingtiming  // 0x24
METHODS:
  RVA=0x09AD4890  token=0x60005E9  System.Boolean IsEmpty()
END_CLASS

CLASS: ScrollEffectTrigger
TYPE:  class
TOKEN: 0x20000BD
SIZE:  0x40
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
  private   static  System.Single                   DFT_MIN_INTERVAL  // const
  private           System.Boolean                  m_isValid  // 0x10
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectConfigm_config  // 0x18
  private           System.Int32                    m_lastFocusIndex  // 0x30
  private           System.Single                   m_curTime  // 0x34
  private           System.Single                   m_lastScrollTime  // 0x38
  private           System.Boolean                  m_hasScrolled  // 0x3c
METHODS:
  RVA=0x09AD4B08  token=0x60005EA  System.Void .ctor(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig config)
  RVA=0x09AD49A8  token=0x60005EB  System.Void NotifyScrolling(System.Single curIndex, System.Single deltaTime)
  RVA=0x09AD48F0  token=0x60005EC  System.Void MarkHasScrolled()
  RVA=0x09AD4944  token=0x60005ED  System.Void NotifyAlignFinish()
  RVA=0x09AD4A98  token=0x60005EE  System.Void Reset(System.Int32 curIndex)
END_CLASS

CLASS: <_KeyboardHeightChange>d__59
TYPE:  sealed class
TOKEN: 0x20000BF
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIInputField          <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600061C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600061D  System.Void System.IDisposable.Dispose()
  RVA=0x09AD4BD0  token=0x600061E  System.Boolean MoveNext()
  RVA=0x09AD4C28  token=0x6000620  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: IAction
TYPE:  interface
TOKEN: 0x20000C2
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600065F  System.Void DoAction()
END_CLASS

CLASS: <_NextFrameCoroutine>d__6
TYPE:  sealed class
TOKEN: 0x20000C3
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UILayoutDimensionListener<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000660  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000661  System.Void System.IDisposable.Dispose()
  RVA=0x09AD4C74  token=0x6000662  System.Boolean MoveNext()
  RVA=0x09AD4CCC  token=0x6000664  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: GetCellSizeMode
TYPE:  sealed struct
TOKEN: 0x20000C7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeByGetCellSizeFunc  // const
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeByLayoutGroup  // const
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeGetAfterCellCreated  // const
METHODS:
END_CLASS

CLASS: Cell
TYPE:  class
TOKEN: 0x20000D1
SIZE:  0x28
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.GameObject          realGameObject  // 0x20
METHODS:
  RVA=0x09ADDA78  token=0x6000719  System.Void SetSelect(System.Boolean select)
  RVA=0x0350B670  token=0x600071A  System.Void .ctor()
END_CLASS

CLASS: AutoLayoutWhenFewType
TYPE:  sealed struct
TOKEN: 0x20000D5
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeCenter  // const
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeLeftOrTop  // const
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeRightOrBottom  // const
METHODS:
END_CLASS

CLASS: Cell
TYPE:  class
TOKEN: 0x20000D6
SIZE:  0x40
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x20
  public            Beyond.UI.IUIFoldoutComp        UIFoldoutComp  // 0x28
  public            System.Boolean                  canCache  // 0x30
  public            UnityEngine.GameObject          realGameObject  // 0x38
METHODS:
  RVA=0x03D56870  token=0x60007A7  System.Void .ctor()
END_CLASS

CLASS: MoveTipsType
TYPE:  sealed struct
TOKEN: 0x20000D7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeNone  // const
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeHigher  // const
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeLower  // const
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeBoth  // const
METHODS:
END_CLASS

CLASS: Padding
TYPE:  sealed struct
TOKEN: 0x20000D8
SIZE:  0x20
FIELDS:
  public            System.Single                   top  // 0x10
  public            System.Single                   left  // 0x14
  public            System.Single                   right  // 0x18
  public            System.Single                   bottom  // 0x1c
METHODS:
END_CLASS

CLASS: ScrollAlignType
TYPE:  sealed struct
TOKEN: 0x20000D9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeCenter  // const
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeTop  // const
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeBottom  // const
METHODS:
END_CLASS

CLASS: IScrollListNaviWrapper
TYPE:  interface
TOKEN: 0x20000DA
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60007A8  System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir)
END_CLASS

CLASS: MoveTipsType
TYPE:  sealed struct
TOKEN: 0x20000DD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeNone  // const
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeHigher  // const
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeLower  // const
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeBoth  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass14_0
TYPE:  sealed class
TOKEN: 0x20000DE
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2             contentPos  // 0x10
  public            Beyond.UI.UIScrollRect          <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60007D2  System.Void .ctor()
  RVA=0x03D5CC00  token=0x60007D3  UnityEngine.Vector2 <_CustomSetPosOnScroll>b__0()
  RVA=0x034E5020  token=0x60007D4  System.Void <_CustomSetPosOnScroll>b__1(UnityEngine.Vector2 pos)
END_CLASS

CLASS: ERedDotState
TYPE:  sealed struct
TOKEN: 0x20000E0
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateDISABLED  // const
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateNEW  // const
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateNORMAL  // const
METHODS:
END_CLASS

CLASS: ERedDotDir
TYPE:  sealed struct
TOKEN: 0x20000E1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirUP  // const
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirRIGHT  // const
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirDOWN  // const
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirLEFT  // const
METHODS:
END_CLASS

CLASS: RedDotInfo
TYPE:  class
TOKEN: 0x20000E2
SIZE:  0x28
FIELDS:
  public    readonly UnityEngine.GameObject          redDotRoot  // 0x10
  public    readonly UnityEngine.GameObject          redDotNormal  // 0x18
  public    readonly UnityEngine.GameObject          redDotNew  // 0x20
PROPERTIES:
  state  get=0x09AE6334
  normalPos  get=0x09AE615C
  newPos  get=0x09AE5F84
  normalRect  get=0x09AE6238
  newRect  get=0x09AE6060
METHODS:
  RVA=0x09AE5F4C  token=0x60007F0  System.Void .ctor(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew)
END_CLASS

CLASS: ScrollMode
TYPE:  sealed struct
TOKEN: 0x20000E4
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollText.ScrollModeMesh  // const
  public    static  Beyond.UI.UIScrollText.ScrollModeAnchoredPosition  // const
METHODS:
END_CLASS

CLASS: ScrollState
TYPE:  sealed struct
TOKEN: 0x20000E5
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollText.ScrollStateScrolling  // const
  public    static  Beyond.UI.UIScrollText.ScrollStateIdle  // const
  public    static  Beyond.UI.UIScrollText.ScrollStateFadingOut  // const
  public    static  Beyond.UI.UIScrollText.ScrollStateFadingIn  // const
METHODS:
END_CLASS

CLASS: IAlphaHandler
TYPE:  interface
TOKEN: 0x20000E6
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60007FE  System.Void HandleAlpha(System.Single alpha)
END_CLASS

CLASS: CanvasGroupHandler
TYPE:  class
TOKEN: 0x20000E7
SIZE:  0x18
IMPLEMENTS: IAlphaHandler
FIELDS:
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60007FF  System.Void .ctor(UnityEngine.CanvasGroup canvasGroup)
  RVA=0x09AE50D8  token=0x6000800  System.Void HandleAlpha(System.Single alpha)
END_CLASS

CLASS: IScrollHandler
TYPE:  interface
TOKEN: 0x20000E8
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000801  System.Void ApplyScroll(System.Single scrollOffset)
  RVA=-1  // abstract  token=0x6000802  System.Void ResetScroll()
  RVA=-1  // abstract  token=0x6000803  System.Void UpdateScrollStatus(System.Boolean isScroll)
END_CLASS

CLASS: PositionScrollHandler
TYPE:  class
TOKEN: 0x20000E9
SIZE:  0x18
IMPLEMENTS: IScrollHandler
FIELDS:
  private           Beyond.UI.UIScrollText          m_closure  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000804  System.Void .ctor(Beyond.UI.UIScrollText scrollText)
  RVA=0x09AE5D48  token=0x6000805  System.Void ApplyScroll(System.Single scrollOffset)
  RVA=0x09AE5DF4  token=0x6000806  System.Void ResetScroll()
  RVA=0x09AE5E68  token=0x6000807  System.Void UpdateScrollStatus(System.Boolean isScroll)
END_CLASS

CLASS: MeshScrollHandler
TYPE:  class
TOKEN: 0x20000EA
SIZE:  0x18
IMPLEMENTS: IScrollHandler
FIELDS:
  private           Beyond.UI.UIScrollText          m_closure  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000808  System.Void .ctor(Beyond.UI.UIScrollText uiScrollText)
  RVA=0x09AE5144  token=0x6000809  System.Void ApplyScroll(System.Single scrollOffset)
  RVA=0x09AE51A8  token=0x600080A  System.Void ResetScroll()
  RVA=0x09AE5200  token=0x600080B  System.Void UpdateScrollStatus(System.Boolean isScroll)
  RVA=0x09AE52BC  token=0x600080C  System.Void _ApplyScroll(System.Single scrollOffset)
  RVA=0x09AE5538  token=0x600080D  System.Void _UpdateMeshClipping(TMPro.TMP_TextInfo textInfo)
END_CLASS

CLASS: FocusBlockMessageData
TYPE:  sealed struct
TOKEN: 0x20000EC
SIZE:  0x30
FIELDS:
  public            System.Int32                    panelId  // 0x10
  public            System.Boolean                  isGroup  // 0x14
  public            System.Int32                    id  // 0x18
  public            UnityEngine.RectTransform       rectTransform  // 0x20
  public            System.Boolean                  noHighlight  // 0x28
  public            System.Boolean                  useNormalFrame  // 0x29
  public            System.Boolean                  useDarkFrame  // 0x2a
  public            System.Int32                    panelSortingOrder  // 0x2c
METHODS:
END_CLASS

CLASS: <_ApplyDamping>d__44
TYPE:  sealed class
TOKEN: 0x20000EE
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UISemiCircleScrollList<>4__this  // 0x20
  private           System.Single                   <targetOffset>5__2  // 0x28
  private           System.Single                   <elapsed>5__3  // 0x2c
  private           System.Single                   <initialOffset>5__4  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600084C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600084D  System.Void System.IDisposable.Dispose()
  RVA=0x09AE6474  token=0x600084E  System.Boolean MoveNext()
  RVA=0x09AE67A4  token=0x6000850  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: StateInfo
TYPE:  class
TOKEN: 0x20000F3
SIZE:  0x20
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Collections.Generic.List<UnityEngine.GameObject>activeObjects  // 0x18
METHODS:
  RVA=0x09AE6424  token=0x6000873  System.String ToString()
  RVA=0x028480E0  token=0x6000874  System.Void .ctor()
  RVA=0x05459F38  token=0x6000875  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: SlicedSpriteParams
TYPE:  sealed struct
TOKEN: 0x20000F7
SIZE:  0x34
FIELDS:
  public            System.Int32                    slicedEnabled  // 0x10
  public            UnityEngine.Vector2             inner_PosMin  // 0x14
  public            UnityEngine.Vector2             inner_PosMax  // 0x1c
  public            UnityEngine.Vector2             inner_UVMin  // 0x24
  public            UnityEngine.Vector2             inner_UVMax  // 0x2c
METHODS:
  RVA=0x03D76150  token=0x60008BC  System.Void .ctor(System.Int32 slicedEnabled, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax)
END_CLASS

CLASS: UIType
TYPE:  sealed struct
TOKEN: 0x20000F9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UISoftMaskable.UIType Default  // const
  public    static  Beyond.UI.UISoftMaskable.UIType Text  // const
  public    static  Beyond.UI.UISoftMaskable.UIType UIVFX  // const
METHODS:
END_CLASS

CLASS: TestLine
TYPE:  sealed struct
TOKEN: 0x20000FA
SIZE:  0x118
FIELDS:
  public            UnityEngine.UIVertex            v0  // 0x10
  public            UnityEngine.UIVertex            v1  // 0x7c
  public            UnityEngine.Vector2             p0  // 0xe8
  public            UnityEngine.Vector2             p1  // 0xf0
  public            UnityEngine.Vector2             t0  // 0xf8
  public            UnityEngine.Vector2             t1  // 0x100
  public            UnityEngine.Vector2             dir  // 0x108
  public            UnityEngine.Vector2             normal  // 0x110
METHODS:
END_CLASS

CLASS: RenderType
TYPE:  sealed struct
TOKEN: 0x20000FC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UISortingOrder.RenderTypeEffect  // const
  public    static  Beyond.UI.UISortingOrder.RenderTypeUI  // const
METHODS:
END_CLASS

CLASS: StateConfig
TYPE:  class
TOKEN: 0x20000FF
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0x10
  public            System.String                   stateName  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60008FA  System.Void .ctor()
END_CLASS

CLASS: StyleConfig
TYPE:  class
TOKEN: 0x2000100
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UIStyleInputValidTypeMaskinputValidType  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.UIStyleByState.StateConfig>stateConfigs  // 0x18
METHODS:
  RVA=0x03595760  token=0x60008FB  System.Void .ctor()
END_CLASS

CLASS: ScrollListLayoutInfo
TYPE:  class
TOKEN: 0x2000109
SIZE:  0x28
FIELDS:
  public            UnityEngine.UI.VerticalLayoutGrouplayoutGroup  // 0x10
  public            UnityEngine.RectTransform       layoutRectTransform  // 0x18
  public            UnityEngine.UI.LayoutElement    cell  // 0x20
PROPERTIES:
  cellHeight  get=0x09AF023C
METHODS:
  RVA=0x0350B670  token=0x6000992  System.Void .ctor()
END_CLASS

CLASS: <_ScrollLayouts>d__12
TYPE:  sealed class
TOKEN: 0x200010A
SIZE:  0x68
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl<>4__this  // 0x20
  public            System.Boolean                  isUp  // 0x28
  public            System.Int32                    count  // 0x2c
  private           System.Single                   <elapsedTime>5__2  // 0x30
  private           System.Single                   <duration>5__3  // 0x34
  private           UnityEngine.Vector2             <upStartPos>5__4  // 0x38
  private           UnityEngine.Vector2             <downStartPos>5__5  // 0x40
  private           UnityEngine.Vector2             <middleStartPos>5__6  // 0x48
  private           UnityEngine.Vector2             <upEndPos>5__7  // 0x50
  private           UnityEngine.Vector2             <downEndPos>5__8  // 0x58
  private           UnityEngine.Vector2             <middleEndPos>5__9  // 0x60
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000993  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000994  System.Void System.IDisposable.Dispose()
  RVA=0x09AF3A0C  token=0x6000995  System.Boolean MoveNext()
  RVA=0x09AF4140  token=0x6000997  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: MotionLevel
TYPE:  sealed struct
TOKEN: 0x2000110
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.MobileMotionManager.MotionLevelNONE  // const
  public    static  Beyond.UI.MobileMotionManager.MotionLevelLOW  // const
  public    static  Beyond.UI.MobileMotionManager.MotionLevelMEDIUM  // const
  public    static  Beyond.UI.MobileMotionManager.MotionLevelHIGH  // const
METHODS:
END_CLASS

CLASS: FontAssetRef
TYPE:  class
TOKEN: 0x2000113
SIZE:  0x40
FIELDS:
  public            Beyond.I18n.I18nFontSearchData.FontAssetInfofontAssetInfo  // 0x10
  private           System.Collections.Generic.HashSet<TMPro.TMP_Text>m_refTexts  // 0x18
  private           Beyond.Resource.FAssetProxyHandlem_assetHandle  // 0x20
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x38
METHODS:
  RVA=0x09AEF9D0  token=0x60009BD  TMPro.TMP_FontAsset GetFontAsset(TMPro.TMP_Text refText)
  RVA=0x09AEFB68  token=0x60009BE  System.Void RemoveRefText(TMPro.TMP_Text refText)
  RVA=0x09AEF920  token=0x60009BF  System.Void Dispose()
  RVA=0x0370AB20  token=0x60009C0  System.Void .ctor()
END_CLASS

CLASS: FLerpByTime
TYPE:  sealed struct
TOKEN: 0x2000115
SIZE:  0x40
FIELDS:
  public    static  Beyond.UI.TweenUtils.FLerpByTimeEMPTY  // static @ 0x0
  private           System.Boolean                  <isEmpty>k__BackingField  // 0x10
  private           Beyond.FScaledStopwatch         m_timer  // 0x18
  public            System.Single                   startValue  // 0x30
  public            System.Single                   endValue  // 0x34
  public            System.Single                   duration  // 0x38
PROPERTIES:
  isEmpty  get=0x03D51020  set=0x03D4F9D0
METHODS:
  RVA=0x09AEF16C  token=0x60009C4  System.Void Start(Beyond.ITickOwner timeScaleProvider)
  RVA=0x09AEF084  token=0x60009C5  System.Single GetValue(System.Boolean& isTweenFinished)
  RVA=0x09AEF1D0  token=0x60009C6  System.Void .cctor()
END_CLASS

CLASS: FOptions
TYPE:  sealed struct
TOKEN: 0x2000119
FIELDS:
  public            TComp                           cellTemplate  // 0x0
  public            UnityEngine.Transform           parent  // 0x0
  public            System.Action<TComp>            onItemCreated  // 0x0
METHODS:
END_CLASS

CLASS: ItemWrapper
TYPE:  class
TOKEN: 0x200011A
FIELDS:
  public            TComp                           comp  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60009D7  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass9_0
TYPE:  sealed class
TOKEN: 0x200011C
SIZE:  0x20
FIELDS:
  public            Beyond.UI.UILoadImageSprite     <>4__this  // 0x10
  public            System.String                   path  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60009DD  System.Void .ctor()
  RVA=0x09AF37F4  token=0x60009DE  System.Void <_LoadSprite>b__0(System.Boolean isOk, Beyond.Resource.FAssetProxyHandle handle)
END_CLASS

CLASS: Options
TYPE:  sealed struct
TOKEN: 0x200011F
SIZE:  0x20
FIELDS:
  private           System.Action                   <onShown>k__BackingField  // 0x10
  private           System.Action                   <onHiden>k__BackingField  // 0x18
PROPERTIES:
  onShown  get=0x020C61B0  set=0x042715A0
  onHiden  get=0x03D50DE0  set=0x0558FF08
METHODS:
END_CLASS

CLASS: TweenContext
TYPE:  sealed struct
TOKEN: 0x2000120
SIZE:  0x14
FIELDS:
  public            System.Single                   lastStopPos  // 0x10
METHODS:
  RVA=0x09AF3420  token=0x60009FB  System.Boolean IsInterapted()
  RVA=0x02C3C3C0  token=0x60009FC  System.Void OnReset()
  RVA=0x02C3C360  token=0x60009FD  System.Void OnTweenStop(Beyond.UI.UISwitchTween.ITweenProgress tweenProgress)
END_CLASS

CLASS: ITweenHandler
TYPE:  interface
TOKEN: 0x2000121
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60009FE  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
  RVA=-1  // abstract  token=0x60009FF  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  RVA=-1  // abstract  token=0x6000A00  System.Boolean IsPlaying()
  RVA=-1  // abstract  token=0x6000A01  System.Void KillIfNecessary()
END_CLASS

CLASS: ITweenProgress
TYPE:  interface
TOKEN: 0x2000122
IMPLEMENTS: Beyond.IHotfixable
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000A02  System.Single GetCurrPos()
END_CLASS

CLASS: TweenWrapper
TYPE:  class
TOKEN: 0x2000123
SIZE:  0x18
IMPLEMENTS: ITweenHandler Beyond.IHotfixable
FIELDS:
  private           DG.Tweening.Tween               m_tween  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000A03  System.Void .ctor(DG.Tweening.Tween tween)
  RVA=0x09AF3698  token=0x6000A04  System.Boolean IsActive()
  RVA=0x02C3C7D0  token=0x6000A05  System.Boolean IsPlaying()
  RVA=0x02C3C450  token=0x6000A06  System.Void KillIfNecessary()
  RVA=0x02C3C0A0  token=0x6000A07  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  RVA=0x02C3C170  token=0x6000A08  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
END_CLASS

CLASS: <WaitForTweening>d__19
TYPE:  sealed class
TOKEN: 0x2000124
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.UISwitchTween         <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000A09  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000A0A  System.Void System.IDisposable.Dispose()
  RVA=0x09AF3970  token=0x6000A0B  System.Boolean MoveNext()
  RVA=0x09AF39C0  token=0x6000A0D  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Durations
TYPE:  sealed struct
TOKEN: 0x2000126
SIZE:  0x20
FIELDS:
  public            System.Single                   show  // 0x10
  public            System.Single                   showDelay  // 0x14
  public            System.Single                   hide  // 0x18
  public            System.Single                   hideDelay  // 0x1c
METHODS:
  RVA=0x036765D0  token=0x6000A26  System.Single GetShowDuration(System.Single defaultDuration)
  RVA=0x03676610  token=0x6000A27  System.Single GetHideDuration(System.Single defaultDuration)
END_CLASS

CLASS: Builder
TYPE:  sealed struct
TOKEN: 0x2000127
SIZE:  0x30
FIELDS:
  public            UnityEngine.CanvasGroup         alphaHandler  // 0x10
  public            System.Boolean                  useTimeScale  // 0x18
  public            System.Boolean                  dontDisableGameObject  // 0x19
  public            System.Boolean                  controlBlockRaycast  // 0x1a
  public            System.Single                   duration  // 0x1c
  public            Beyond.UI.FadeSwitchTween.DurationscomplexDuration  // 0x20
METHODS:
  RVA=0x03653270  token=0x6000A28  Beyond.UI.FadeSwitchTween Build()
END_CLASS

CLASS: TweenHandler
TYPE:  class
TOKEN: 0x2000129
SIZE:  0x20
IMPLEMENTS: ITweenHandler Beyond.IHotfixable
FIELDS:
  private           DG.Tweening.Tween               m_alphaTweener  // 0x10
  private           DG.Tweening.Tween               m_posTweener  // 0x18
METHODS:
  RVA=0x02676770  token=0x6000A34  System.Void .ctor(DG.Tweening.Tween alpha, DG.Tweening.Tween pos)
  RVA=0x09AF3484  token=0x6000A35  System.Boolean IsPlaying()
  RVA=0x09AF34EC  token=0x6000A36  System.Void KillIfNecessary()
  RVA=0x09AF3574  token=0x6000A37  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  RVA=0x09AF35FC  token=0x6000A38  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
END_CLASS

CLASS: UIAtlasProcessStatus
TYPE:  sealed struct
TOKEN: 0x200012B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInvalid  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInsertWaiting  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInsertDone  // const
METHODS:
END_CLASS

CLASS: UIAtlasProcessFailureCause
TYPE:  sealed struct
TOKEN: 0x200012C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseNoFailure  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseImageHasNullMainTexture  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseImageHasNullSprite  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureWidthExceedLimit  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureHeightExceedLimit  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureASTCNotSupportedUnderEditor  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelInfo  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteHasNonQuadMesh  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteHasAssociatedAlphaSplitTexture  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelWarning  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseAtlasTextureHasNoSpaceLeft  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteRectHasNoPadding  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelError  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureFormatNotCompatible  // const
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureSizeNotAlignedForCopyTexture  // const
METHODS:
END_CLASS

CLASS: UIAtlasHandle
TYPE:  sealed struct
TOKEN: 0x200012D
SIZE:  0x34
FIELDS:
  public            Beyond.UI.UIAtlasManager.UIAtlasProcessStatusstatus  // 0x10
  public            Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCausefailureCause  // 0x14
  public            System.Int32                    panelLevel  // 0x18
  public            System.Int32                    atlasIndex  // 0x1c
  public            UnityEngine.RectInt             atlasRect  // 0x20
  public            System.Int32                    textureId  // 0x30
METHODS:
  RVA=0x03D761B0  token=0x6000A50  System.Void .ctor(Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause, System.Int32 panelLevel, System.Int32 atlasIndex, UnityEngine.RectInt atlasRect, System.Int32 textureId)
  RVA=0x09AF418C  token=0x6000A51  System.Boolean IsValid()
  RVA=0x024347C0  token=0x6000A52  Beyond.UI.UIAtlasManager.UIAtlasHandle CreateInvalidHandle(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause cause)
END_CLASS

CLASS: TextureRefHandle
TYPE:  sealed struct
TOKEN: 0x200012F
SIZE:  0x24
FIELDS:
  public            System.Int32                    refCount  // 0x10
  public            UnityEngine.RectInt             rect  // 0x14
METHODS:
  RVA=0x03D675C0  token=0x6000A5E  System.Void .ctor(System.Int32 refCount, UnityEngine.RectInt rect)
END_CLASS

CLASS: UIAtlasPage
TYPE:  class
TOKEN: 0x200012E
SIZE:  0x28
FIELDS:
  private   readonly UnityEngine.Texture2D           <pageTexture>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle><textureRefDict>k__BackingField  // 0x18
  private   readonly HG.Rendering.Runtime.AtlasMaxRect<rectBinPack>k__BackingField  // 0x20
PROPERTIES:
  maxFreeRectWidth  get=0x09AF618C
  maxFreeRectHeight  get=0x0943FA1C
  pageTexture  get=0x020B7B20
  textureRefDict  get=0x01041090
  rectBinPack  get=0x03D4EB40
METHODS:
  RVA=0x09AF5FFC  token=0x6000A53  System.Void .ctor(System.Int32 panelDepth, System.Int32 index, UnityEngine.Experimental.Rendering.GraphicsFormat atlasFormat)
  RVA=0x09AF5ED0  token=0x6000A59  UnityEngine.RectInt InsertRect(System.Int32 width, System.Int32 height)
  RVA=0x09AF5C4C  token=0x6000A5A  System.Void CopyIntoAtlas(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.RectInt& rect)
  RVA=0x09AF5F74  token=0x6000A5B  System.Void InsertRects(System.Collections.Generic.List<UnityEngine.RectInt> rects, System.Collections.Generic.List<UnityEngine.RectInt> dst)
  RVA=0x09AF5DF8  token=0x6000A5C  System.Void FreeRect(UnityEngine.RectInt& rect)
  RVA=0x09AF5E64  token=0x6000A5D  System.Void FreeRects(System.Collections.Generic.List<UnityEngine.RectInt>& rects)
END_CLASS

CLASS: <>c__DisplayClass0_0
TYPE:  sealed class
TOKEN: 0x2000133
SIZE:  0x20
FIELDS:
  public            System.String                   url  // 0x10
  public            System.Action                   onClose  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000A6A  System.Void .ctor()
  RVA=0x09AF36FC  token=0x6000A6B  System.Void <Start>b__0(System.Int32 i, System.String s)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000144
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.UI.UIState.UIStateController.<>c<>9  // static @ 0x0
  public    static  System.Predicate<Beyond.UI.UIState.StateAnimationInfo><>9__10_0  // static @ 0x8
METHODS:
  RVA=0x03D19A90  token=0x6000ABC  System.Void .cctor()
  RVA=0x0350B670  token=0x6000ABD  System.Void .ctor()
  RVA=0x09B0C928  token=0x6000ABE  System.Boolean <Tick>b__10_0(Beyond.UI.UIState.StateAnimationInfo info)
END_CLASS

CLASS: ShaderIDs
TYPE:  static class
TOKEN: 0x2000156
SIZE:  0x10
FIELDS:
  private   static readonly System.Int32                    CANVAS_OBJECT_TO_WORLD_MATRIX  // static @ 0x0
  private   static readonly System.Int32                    VAT_TEX  // static @ 0x4
  private   static readonly System.Int32                    MAIN_TEX  // static @ 0x8
  private   static readonly System.Int32                    SPRITE_TEX  // static @ 0xc
METHODS:
  RVA=0x03C85500  token=0x6000B06  System.Void .cctor()
END_CLASS

CLASS: BufferInternalNode
TYPE:  sealed struct
TOKEN: 0x2000159
SIZE:  0x24
FIELDS:
  public            Beyond.UI.GPUI.GPUIHandle       handle  // 0x10
  public            System.Int32                    startIndex  // 0x18
  public            System.Int32                    previousLength  // 0x1c
  public            System.Int32                    sortingOrder  // 0x20
METHODS:
END_CLASS

CLASS: CharOffsetData
TYPE:  sealed struct
TOKEN: 0x200015F
FIELDS:
  public            System.Single                   scale  // 0x0
  public            System.Single                   xAdvance  // 0x0
  public            System.Single                   xOffset  // 0x0
  public            System.Single                   yOffset  // 0x0
  public            System.Int32                    prefabIndex  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  sealed struct
TOKEN: 0x2000161
SIZE:  0x28
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000160
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE  // static @ 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.UI.UIScrollCellCircleEffect
TYPE:  class
TOKEN: 0x200000C
SIZE:  0xA8
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.Transform           _target  // 0x68
  private           System.Single                   _radius  // 0x70
  private           UnityEngine.Transform           _effectNode  // 0x78
  private           System.Boolean                  _faceToUICamera  // 0x80
  private           System.Boolean                  _alwaysFaceToCamera  // 0x81
  private           UnityEngine.Vector3             m_lastPosition  // 0x84
  private           Beyond.UI.LuaPanel              m_panel  // 0x90
  private           UnityEngine.Transform           <lookAtCamera>k__BackingField  // 0x98
  private           System.Boolean                  m_left  // 0xa0
PROPERTIES:
  tickOption  get=0x03D55740
  panel  get=0x09AB13F0
  lookAtCamera  get=0x011AC510  set=0x051417AC
METHODS:
  RVA=0x09AB0F44  token=0x600002D  System.Void _InitState()
  RVA=0x09AB1220  token=0x600002E  System.Void _UpdatePos()
  RVA=0x09AB1008  token=0x600002F  System.Void _UpdateLookAtCamera()
  RVA=0x09AB0DA4  token=0x6000030  System.Void SetLookAtCamera(UnityEngine.Transform faceCamera, System.Boolean update)
  RVA=0x09AB0D4C  token=0x6000031  System.Void OnEnable()
  RVA=0x09AB0E40  token=0x6000032  System.Void Start()
  RVA=0x09AB0EE8  token=0x6000033  System.Void Tick(System.Single deltaTime)
  RVA=0x09AB0CA0  token=0x6000034  System.Void ForceUpdate()
  RVA=0x09AB0CF0  token=0x6000035  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AB13E0  token=0x6000036  System.Void .ctor()
  RVA=0x058DD8AC  token=0x6000037  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x6000038  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0589E548  token=0x6000039  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.Gameplay.UI.UIScrollCellSlantEffect
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x88
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           System.Single                   _topY  // 0x68
  private           System.Single                   _bottomY  // 0x6c
  private           System.Single                   _leftX  // 0x70
  private           System.Single                   _maxWidth  // 0x74
  private           UnityEngine.AnimationCurve      _curve  // 0x78
  private           UnityEngine.Transform[]         _cells  // 0x80
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x032B98D0  token=0x600003B  System.Void Tick(System.Single deltaTime)
  RVA=0x02846010  token=0x600003C  System.Void .ctor()
  RVA=0x0577D7BC  token=0x600003D  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_UI_Beyond
TYPE:  static class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_initialized  // static @ 0x0
METHODS:
  RVA=0x03C8B2A0  token=0x6000017  System.Void InitializeAtRuntime()
  RVA=0x03C8B2D0  token=0x6000018  System.Void Initialize()
END_CLASS

CLASS: Beyond.Scripts.UI.Tools.UIGridLayoutElement
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  private           UnityEngine.UI.GridLayoutGroup  m_gridLayoutGroup  // 0x18
PROPERTIES:
  minWidth  get=0x09AB02C4
  preferredWidth  get=0x09AB0424
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x09AB0214
  preferredHeight  get=0x09AB0374
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x01168950
METHODS:
  RVA=0x09AAFF78  token=0x600001E  System.Void CalculateLayoutInputHorizontal()
  RVA=0x09AAFFB8  token=0x600001F  System.Void CalculateLayoutInputVertical()
  RVA=0x09AAFFF8  token=0x6000027  System.Single _GetPreferredSize(System.Boolean widthOrHeight)
  RVA=0x0426FE60  token=0x6000028  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000019  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x600001A  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600001B  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600001C  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600001D  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIText
TYPE:  class
TOKEN: 0x200000E
SIZE:  0xC80
EXTENDS: TMPro.TextMeshProUGUI
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp UnityEngine.ISerializationCallbackReceiver UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IPointerExitHandler
FIELDS:
  public            Beyond.UI.UIText.RichTextStyleSeqrichTextStyleSeq  // 0xbc8
  private           System.Boolean                  m_textHasHyperlink  // 0xbcc
  private   static readonly System.Text.RegularExpressions.RegexRICH_TEXT_INNERMOST_REGEX  // static @ 0x0
  private   static  System.Int32                    RICH_TEXT_RESOLVE_MAX_ITERATIONS  // const
  private   static readonly System.Text.RegularExpressions.RegexHYPERLINK_TEXT_REGEX  // static @ 0x8
  private   static readonly System.Text.RegularExpressions.RegexPHONETIC_REGEX  // static @ 0x10
  private           System.Boolean                  _loadByCode  // 0xbcd
  private           System.String                   _textId  // 0xbd0
  private           System.Boolean                  _devOnly  // 0xbd8
  private           System.Int32                    _externalStaticWidth  // 0xbdc
  private           System.Int32                    _externalStaticHeight  // 0xbe0
  private           System.Boolean                  m_firstSetByCode  // 0xbe4
  private   static readonly System.Collections.Generic.HashSet<Beyond.GEnums.EnvLang>s_forceLeftAlignLanguage  // static @ 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>m_richTextInfos  // 0xbe8
  private           Beyond.TickFunction             m_updateFunction  // 0xbf0
  private           Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFuncm_processRichTextEntryFunc  // 0xbf8
  public            UnityEngine.Events.UnityEvent<System.String>onClickLink  // 0xc00
  public            UnityEngine.Events.UnityEvent<System.String,System.Boolean>onHoverLinkChange  // 0xc08
  private           System.Boolean                  m_isPointerInside  // 0xc10
  private           System.String                   m_curHoverLinkId  // 0xc18
  private           System.Collections.Generic.List<System.String>m_linkList  // 0xc20
  private           System.Boolean                  m_linkShrunk  // 0xc28
  private           System.String                   _hyperlinkUITextGroupId  // 0xc30
  private           System.Int32                    _hyperlinkUITextOrder  // 0xc38
  private           Beyond.UI.UIText.HyperlinkUITextWrapm_hyperlinkUITextWrap  // 0xc40
  private           Beyond.UI.LuaPanel              m_panel  // 0xc48
  public            System.Int32                    sourceCNFontId  // 0xc50
  private           TMPro.TMP_FontAsset             m_i18nFontAsset  // 0xc58
  private   static  System.Text.StringBuilder       s_stringBuilder  // static @ 0x20
  private   readonly System.Collections.Generic.Queue<UnityEngine.GameObject>m_inlineImagePool  // 0xc60
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.ImageGOInfo>m_indexToImageGo  // 0xc68
  private   static  System.String                   INLINE_IMAGE_FOLDER_PATH  // const
  private   static  System.String                   KEY_HINT_ICON_COMMON_FOLDER  // const
  private   readonly System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>m_imageCache  // 0xc70
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_delayedActiveChangeImageGOIndexes  // 0xc78
PROPERTIES:
  textId  get=0x03D75FC0
  text  get=0x031E6FF0  set=0x030CAAC0
  processRichTextEntryFunc  get=0x025E0100
  panel  get=0x09AB4130
  m_fontAsset  get=0x0285FD90  set=0x09AB42A8
  fontSharedMaterial  get=0x03D56F00  set=0x09AB41F0
METHODS:
  RVA=0x030823B0  token=0x600003E  System.Void SetAndResolveTextStyle(System.String targetText)
  RVA=0x02CDF860  token=0x600003F  System.String GetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  RVA=0x02CDF7D0  token=0x6000040  System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  RVA=0x030824B0  token=0x6000041  System.String _ResolveTextStyle(System.String text, System.Int32 richSeqIndex, System.Boolean& hasLink)
  RVA=0x02954240  token=0x6000043  System.Void OnEnvLangChanged(Beyond.GEnums.EnvLang lang)
  RVA=0x0348A3B0  token=0x6000046  System.Void _CreateUpdateFunction()
  RVA=0x0239E610  token=0x6000047  System.Void _ReleaseUpdateFunction()
  RVA=0x03535D10  token=0x6000048  System.Void ClearMesh()
  RVA=0x025DF9D0  token=0x6000049  System.Void RefreshPopulateText()
  RVA=0x09AB185C  token=0x600004A  UnityEngine.Material LoadMaterial(System.String materialName)
  RVA=0x0285F5C0  token=0x600004B  System.Void OnDestroy()
  RVA=0x0285FB00  token=0x600004C  System.Void Awake()
  RVA=0x0285FF80  token=0x600004D  TMPro.TMP_FontAsset GetFontAsset()
  RVA=0x0285FC60  token=0x600004E  System.Void _GenerateRuntimeText()
  RVA=0x025DFB30  token=0x600004F  System.Void _ProcessRichTextInfo()
  RVA=0x03191780  token=0x6000050  System.Void _OnPreRenderText(TMPro.TMP_TextInfo textInfo)
  RVA=0x09AB355C  token=0x6000052  Beyond.UI.UIText.RichTextInfo _ProcessRichTextEntry(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  RVA=0x09AB1B4C  token=0x6000053  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AB1FE4  token=0x6000054  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AB20D0  token=0x6000055  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x033B7E00  token=0x6000056  System.Void Start()
  RVA=0x0239EE90  token=0x6000057  System.Void OnEnable()
  RVA=0x0239E670  token=0x6000058  System.Void OnDisable()
  RVA=0x09AB3D90  token=0x6000059  System.Void _UpdateTick(System.Single deltaTime)
  RVA=0x09AB2520  token=0x600005A  System.Void ShrinkLinkTags()
  RVA=0x09AB2BD8  token=0x600005B  System.Boolean TryGetLinkId(UnityEngine.Vector3 position, System.String& linkId)
  RVA=0x09AB2D98  token=0x600005C  System.Boolean TryGetLinkId(System.Int32 linkIndex, System.String& linkId)
  RVA=0x09AB2EF4  token=0x600005D  System.Boolean TryGetOriginalLinkId(System.String linkId, System.String& originalLinkId)
  RVA=0x09AB2A38  token=0x600005E  System.Boolean TryGetCharacterStartPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight)
  RVA=0x09AB2898  token=0x600005F  System.Boolean TryGetCharacterEndPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight)
  RVA=-1  // generic def  token=0x6000060  System.Void CombineStringWithLanguageSpilt(T1 t1, T2 t2)
  RVA=0x09AB14B0  token=0x6000061  System.Void CombineStringWithLanguageSpilt(System.String t1, System.String t2)
  RVA=-1  // generic def  token=0x6000062  System.Void CombineStringReverseForIndonesianAndVietnamese(T1 t1, T2 t2)
  RVA=0x0228C6F0  token=0x6000063  System.Void CombineStringReverseForIndonesianAndVietnamese(System.String t1, System.String t2)
  RVA=0x09AB2210  token=0x6000064  System.Void SetHyperlinkUITextGroup(System.String groupId, System.Int32 order)
  RVA=0x03A4E1F0  token=0x6000065  System.Boolean IsHyperlinkUITextGroupDisplayable(System.String groupId)
  RVA=0x09AB155C  token=0x6000066  System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableHyperlinkUIText(System.String groupId)
  RVA=0x0285F9F0  token=0x6000068  System.Void ClearComponent()
  RVA=0x09AB305C  token=0x6000069  System.Void UpdateI18NFontAsset()
  RVA=0x02860B20  token=0x600006E  System.Void _RefreshMatTexture()
  RVA=0x09AB236C  token=0x600006F  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x03172370  token=0x6000070  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x03242FD0  token=0x6000071  System.Void OnAfterDeserialize()
  RVA=0x025158D0  token=0x6000072  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  RVA=0x09AB1968  token=0x6000073  System.String LocalStringCombineFormat(System.Int32 count)
  RVA=0x09AB15E4  token=0x6000074  UnityEngine.Sprite GetOrLoadSprite(System.String path)
  RVA=0x0285F610  token=0x6000075  System.Void DisposeInlineImageCache()
  RVA=0x025DFE30  token=0x6000076  System.Void _ClearInlineImage()
  RVA=0x09AB317C  token=0x6000077  Beyond.UI.UIText.ImageGOInfo _GetImageGoByIndex(System.Int32 index)
  RVA=0x09AB3354  token=0x6000078  UnityEngine.GameObject _GetOrCreateImageGO()
  RVA=0x09AB3CD4  token=0x6000079  System.Void _ReturnImageGO(UnityEngine.GameObject go)
  RVA=0x09AB30F0  token=0x600007A  System.Collections.IEnumerator _DelayedChangeActiveImageGo()
  RVA=0x02845350  token=0x600007B  System.Void .ctor()
  RVA=0x03496650  token=0x600007C  System.Void .cctor()
  RVA=0x09AB3054  token=0x600007D  System.Void <>iFixBaseProxy_set_text(System.String P0)
  RVA=0x09AB301C  token=0x600007E  System.Void <>iFixBaseProxy_ClearMesh()
  RVA=0x09AB303C  token=0x600007F  System.Void <>iFixBaseProxy_RefreshPopulateText()
  RVA=0x01002730  token=0x6000080  UnityEngine.Material <>iFixBaseProxy_LoadMaterial(System.String P0)
  RVA=0x09AB3024  token=0x6000081  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09AB3014  token=0x6000082  System.Void <>iFixBaseProxy_Awake()
  RVA=0x0350B670  token=0x6000083  System.Void <>iFixBaseProxy_Start()
  RVA=0x09AB3034  token=0x6000084  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09AB302C  token=0x6000085  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x03D56CF0  token=0x6000086  TMPro.TMP_FontAsset <>iFixBaseProxy_get_m_fontAsset()
  RVA=0x04275CF4  token=0x6000087  System.Void <>iFixBaseProxy_set_m_fontAsset(TMPro.TMP_FontAsset P0)
  RVA=0x09AB304C  token=0x6000088  System.Void <>iFixBaseProxy_set_fontSharedMaterial(UnityEngine.Material P0)
  RVA=0x09AB3044  token=0x6000089  System.Void <>iFixBaseProxy_SetSharedMaterial(UnityEngine.Material P0)
  RVA=0x09AB2FD4  token=0x600008A  TMPro.TMP_SubMeshUI <>iFixBaseProxy_AddSubTextObject(TMPro.TextMeshProUGUI P0, TMPro.MaterialReference P1)
END_CLASS

CLASS: Beyond.UI.UIConst
TYPE:  static class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
  public    static  System.Boolean                  IS_PC_OR_CONSOLE  // static @ 0x0
  public    static  System.Single                   PC_REFERENCE_RESOLUTION_SCALE  // const
  public    static  System.Single                   MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE  // const
  public    static readonly UnityEngine.Vector3             OUT_OF_SCREEN_POS  // static @ 0x4
  public    static  System.Single                   STANDARD_HORIZONTAL_RESOLUTION  // const
  public    static  System.Single                   STANDARD_VERTICAL_RESOLUTION  // const
  public    static  System.Int32                    INVALID_FINGER_ID  // const
  public    static  System.Single                   STANDARD_RATIO  // static @ 0x10
  public    static  System.Single                   SCREEN_SPACE_CAMERA_PANEL_DISTANCE  // const
  public    static  System.String                   UI_BLUR_MATERIAL  // const
  public    static  System.String                   CS_POPUP_PANEL_PATH  // const
  public    static  System.String                   NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID  // const
  public    static  System.String                   NAVIGATION_TARGET_CLICK_ACTION_ID  // const
  public    static  System.String                   UI_SPRITE_CHAR_HEAD_RECTANGLE  // const
  public    static  System.String                   UI_SPRITE_DIALOG_OPTION_ICON  // const
  public    static  System.String                   SLIDER_STICK_SCROLL_HORI_ACTION_ID  // const
PROPERTIES:
  STANDARD_HORIZONTAL_RESOLUTION_INT  get=0x09AAFF08
  STANDARD_VERTICAL_RESOLUTION_INT  get=0x09AAFF18
  CUR_STANDARD_HORIZONTAL_RESOLUTION  get=0x028AADA0
  CUR_STANDARD_VERTICAL_RESOLUTION  get=0x028AAD50
  dragThreshold  get=0x09AAFF28
METHODS:
  RVA=0x02800340  token=0x60000BE  System.Single GetResolutionScale()
  RVA=0x09AAFDC4  token=0x60000BF  System.Boolean IsPadDevice()
  RVA=0x03A38140  token=0x60000C0  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIModelLoader
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.Resource.FAssetProxyHandle>m_instance2AssetHandle  // 0x10
  private           System.Int32                    m_requestCounter  // 0x18
  private           System.Collections.Generic.HashSet<System.Int32>m_requestIds  // 0x20
  private           System.Boolean                  m_disposed  // 0x28
  private   static  System.Collections.Generic.List<MagicaCloth.MagicaBoneCloth>s_magicaBoneCloths  // static @ 0x0
METHODS:
  RVA=0x02F2F1B0  token=0x60000C1  System.Void .ctor()
  RVA=0x09AB094C  token=0x60000C2  UnityEngine.GameObject LoadModel(System.String modelPath, UnityEngine.Transform parent)
  RVA=0x09AB0768  token=0x60000C3  System.Int32 LoadModelAsync(System.String modelPath, UnityEngine.Transform parent, System.Action<UnityEngine.GameObject> callback)
  RVA=0x09AB06E4  token=0x60000C4  System.Void Cancel(System.Int32 requestId)
  RVA=0x09AB0B2C  token=0x60000C5  System.Void UnloadModel(UnityEngine.GameObject modelGo)
  RVA=0x03219C50  token=0x60000C6  System.Void _Clear()
  RVA=0x03219C10  token=0x60000C7  System.Void Dispose()
  RVA=0x03CE2BC0  token=0x60000C8  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIUtils
TYPE:  static class
TOKEN: 0x2000024
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    MAX_SHARED_INT_STRING  // const
  private   static readonly System.String[]                 s_sharedIntStringPool  // static @ 0x0
  private   static  UnityEngine.Vector3[]           s_worldCorners  // static @ 0x8
METHODS:
  RVA=0x02B79EA0  token=0x60000CB  System.String GetSharedIntString(System.Int32 value)
  RVA=0x0284E8F0  token=0x60000CC  System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector3 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  RVA=0x02F63750  token=0x60000CD  System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector2 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  RVA=0x09AB4454  token=0x60000CE  UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local)
  RVA=0x09AB4BD0  token=0x60000CF  System.Boolean TryGetTouch(System.Int32 touchId, UnityEngine.InputSystem.EnhancedTouch.Touch& touch)
  RVA=0x025C1550  token=0x60000D0  System.Void SetAlpha(UnityEngine.UI.Graphic image, System.Single alpha)
  RVA=0x09AB4A64  token=0x60000D1  System.Void SetColorWithoutAlpha(UnityEngine.UI.Graphic image, UnityEngine.Color color)
  RVA=0x02C71370  token=0x60000D2  System.Void ClearUIComponents(UnityEngine.GameObject gameObject)
  RVA=0x027FEEC0  token=0x60000D3  UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  RVA=0x03989560  token=0x60000D4  UnityEngine.Vector3 GetNodeScaleOffset(UnityEngine.RectTransform referenceTransform, UnityEngine.RectTransform selfTransform)
  RVA=0x09AB47A0  token=0x60000D5  UnityEngine.Color GetColorByString(System.String strColor)
  RVA=0x09AB4AFC  token=0x60000D6  System.Void SetMaskRatio(UnityEngine.UI.RectMask2D mask, System.Single r)
  RVA=0x09AB49BC  token=0x60000D7  System.Single GetCursorTipOffsetX(System.Single defaultOffset)
  RVA=0x027FF690  token=0x60000D8  System.Single GetCursorTipOffsetInScreen(System.Single defaultOffsetInScreen)
  RVA=0x03CB67A0  token=0x60000D9  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.ActiveSyncHelper
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.GameObject>_objs  // 0x18
  private           System.Boolean                  _isInverse  // 0x20
METHODS:
  RVA=0x03633CA0  token=0x60000DA  System.Void Awake()
  RVA=0x03633D20  token=0x60000DB  System.Void OnEnable()
  RVA=0x03633CE0  token=0x60000DC  System.Void OnDisable()
  RVA=0x03633D60  token=0x60000DD  System.Void Sync()
  RVA=0x0426FE60  token=0x60000DE  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.Billboard
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x70
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            UnityEngine.Camera              sceneCamera  // 0x68
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AACA3C  token=0x60000E0  System.Void OnEnable()
  RVA=0x09AACAE8  token=0x60000E1  System.Void Tick(System.Single deltaTime)
  RVA=0x02846010  token=0x60000E2  System.Void .ctor()
  RVA=0x058DD8AC  token=0x60000E3  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x60000E4  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.CinemachineGyroscopeEffect
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x30
EXTENDS: Cinemachine.CinemachineExtension
FIELDS:
  public            System.Single                   offsetX  // 0x28
  public            System.Single                   offsetY  // 0x2c
METHODS:
  RVA=0x09AACBC8  token=0x60000E5  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  RVA=0x0426FE60  token=0x60000E6  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonItemToastList
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x278
EXTENDS: Beyond.UI.UIScrollList
FIELDS:
METHODS:
  RVA=0x09AAD098  token=0x60000E7  System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode)
  RVA=0x09AACEDC  token=0x60000E8  System.Void AdjustContainerPos(System.Int32 index, System.Boolean fastMode)
  RVA=0x09AAD1B4  token=0x60000E9  UnityEngine.Vector2 _GetUnConstraintTargetPos(System.Int32 index)
  RVA=0x03D00A30  token=0x60000EA  System.Void .ctor()
  RVA=0x09AAD160  token=0x60000EB  UnityEngine.Vector2 <AdjustContainerPos>b__1_0()
  RVA=0x09AAD184  token=0x60000EC  System.Void <AdjustContainerPos>b__1_1(UnityEngine.Vector2 x)
END_CLASS

CLASS: Beyond.UI.ControllerSideMenuItemList
TYPE:  class
TOKEN: 0x2000029
SIZE:  0x40
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.ControllerSideMenuItemList.MeunItemInfo>menuItems  // 0x18
  public            UnityEngine.Sprite              icon  // 0x20
  public            System.String                   title  // 0x28
  public            UnityEngine.RectTransform       contentPosTrans  // 0x30
  public            System.Boolean                  isFullScreen  // 0x38
  private   static readonly System.Collections.Generic.HashSet<System.String>s_forceValidItemList  // static @ 0x0
METHODS:
  RVA=0x09AAD3D8  token=0x60000ED  System.Void ToggleItemForceValid(System.String itemName, System.Boolean forceValid)
  RVA=0x09AAD334  token=0x60000EE  System.Boolean IsItemForceValid(System.String itemName)
  RVA=0x09AAD2A0  token=0x60000EF  System.Void ClearForceValidItemList()
  RVA=0x03B319A0  token=0x60000F0  System.Void .ctor()
  RVA=0x03CE4D80  token=0x60000F1  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.CustomNotchAdapt
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  isLeft  // 0x18
  public            System.Boolean                  isRight  // 0x19
  public            System.Boolean                  isBottom  // 0x1a
  public            System.Boolean                  isFullHorizontalStretch  // 0x1b
METHODS:
  RVA=0x0426FE60  token=0x60000F9  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIStyleInputValidType
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIStyleInputValidType All  // const
  public    static  Beyond.UI.UIStyleInputValidType Keyboard  // const
  public    static  Beyond.UI.UIStyleInputValidType Touch  // const
  public    static  Beyond.UI.UIStyleInputValidType Controller  // const
  public    static  Beyond.UI.UIStyleInputValidType KeyboardAndTouch  // const
  public    static  Beyond.UI.UIStyleInputValidType KeyboardAndController  // const
  public    static  Beyond.UI.UIStyleInputValidType TouchAndController  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIStyleInputValidTypeMask
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIStyleInputValidTypeMaskKeyboard  // const
  public    static  Beyond.UI.UIStyleInputValidTypeMaskTouch  // const
  public    static  Beyond.UI.UIStyleInputValidTypeMaskController  // const
  public    static  Beyond.UI.UIStyleInputValidTypeMaskAll  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.ActiveType
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.ActiveType            UseGameObjectActive  // const
  public    static  Beyond.UI.ActiveType            UseScale  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.CustomUIStyle
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.UI.UIStyleInputValidType inputValidType  // 0x18
  public            Beyond.UI.ActiveType            activeType  // 0x1c
  private           UnityEngine.UI.LayoutElement    _layoutElement  // 0x20
  private           UnityEngine.Animator            _animator  // 0x28
  private           Beyond.UI.CustomUIStyle.OverrideValidStatem_overrideValidState  // 0x30
PROPERTIES:
  inputValidTypeMask  get=0x09AAD5F8  set=0x09AAD6AC
  overrideValidState  get=0x03D4ED20  set=0x09AAD760
  isValid  get=0x03271250
METHODS:
  RVA=0x09AAD4F4  token=0x60000FE  System.Void _OnActiveTypeChanged()
  RVA=0x02CD0EE0  token=0x6000100  System.Void OnDestroy()
  RVA=0x03271180  token=0x6000101  System.Void OnEnable()
  RVA=0x02CD2060  token=0x6000102  System.Void Awake()
  RVA=0x032711C0  token=0x6000103  System.Void CheckState()
  RVA=0x03271360  token=0x6000104  System.Void ToggleActiveState(System.Boolean isActive)
  RVA=0x03271290  token=0x6000105  System.Boolean IsShowTypeValid(Beyond.UI.UIStyleInputValidType inputValidType)
  RVA=0x02CD2C80  token=0x6000106  System.Boolean IsValidInput(Beyond.UI.UIStyleInputValidTypeMask inputValidTypeMask)
  RVA=0x0426FE60  token=0x6000107  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DeactivateNaviOnEnable
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.String                   key  // 0x18
METHODS:
  RVA=0x09AAD7FC  token=0x6000108  System.Void OnEnable()
  RVA=0x09AAD76C  token=0x6000109  System.Void OnDisable()
  RVA=0x0426FE60  token=0x600010A  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DecoLineActiveHelper
TYPE:  class
TOKEN: 0x2000032
SIZE:  0x80
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>checkTargets  // 0x68
  public            System.Collections.Generic.List<UnityEngine.GameObject>secondCheckTargets  // 0x70
  private           UnityEngine.UI.LayoutElement    _layoutElement  // 0x78
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x09AAD88C  token=0x600010C  System.Void Reset()
  RVA=0x0380EC70  token=0x600010D  System.Void OnEnable()
  RVA=0x022BF720  token=0x600010E  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AAD904  token=0x600010F  System.Void Sync()
  RVA=0x09AAD938  token=0x6000110  System.Boolean _HasActiveTarget(System.Collections.Generic.List<UnityEngine.GameObject> targets)
  RVA=0x09AADA04  token=0x6000111  System.Void _ToggleVisible(System.Boolean isVisible)
  RVA=0x02846010  token=0x6000112  System.Void .ctor()
  RVA=0x058DD8AC  token=0x6000113  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x6000114  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.Empty4Raycast
TYPE:  class
TOKEN: 0x2000033
SIZE:  0xE8
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
METHODS:
  RVA=0x09AADB3C  token=0x6000115  System.Void .ctor()
  RVA=0x09AADAD0  token=0x6000116  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x09AADB34  token=0x6000117  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
END_CLASS

CLASS: Beyond.UI.FitAspectRatioByFOV
TYPE:  class
TOKEN: 0x2000034
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: IScreenSizeListener
FIELDS:
  public            System.Single                   referenceAspect  // 0x18
  private           System.Single                   m_referenceVerticalFOV  // 0x1c
  private           Cinemachine.CinemachineVirtualCameram_virtualCamera  // 0x20
  private           System.Single                   m_currentAspect  // 0x28
  private           System.Single                   _maxFov  // 0x2c
  private           System.Single                   m_overrideMaxFov  // 0x30
PROPERTIES:
  maxFov  get=0x09AADBF4  set=0x09AADC54
METHODS:
  RVA=0x09AADB5C  token=0x600011A  System.Void Start()
  RVA=0x02CD14D0  token=0x600011B  System.Void OnEnable()
  RVA=0x02CD1540  token=0x600011C  System.Void OnDisable()
  RVA=0x02CD1480  token=0x600011D  System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height)
  RVA=0x02CD1320  token=0x600011E  System.Void _AdjustFOV()
  RVA=0x03D07BC0  token=0x600011F  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.FixRotation
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x78
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            UnityEngine.Vector3             rotation  // 0x68
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x03414F90  token=0x6000121  System.Void LateTick(System.Single deltaTime)
  RVA=0x03CB5C50  token=0x6000122  System.Void .ctor()
  RVA=0x0589E548  token=0x6000123  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.FullScreenSceneBlurMarker
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.Int32                    s_nextId  // static @ 0x0
  public    static  System.Action<System.Int32,Beyond.UI.FullScreenSceneBlurMarker.State,System.Boolean,System.Boolean>s_onFullScreenSceneBlurMarkerStateChanged  // static @ 0x8
  private           System.Int32                    <id>k__BackingField  // 0x18
  public            System.Boolean                  useWhiteBlur  // 0x1c
  public            System.Boolean                  useSceneColorPS  // 0x1d
PROPERTIES:
  id  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x03B13460  token=0x6000124  System.Int32 _GetNextId()
  RVA=0x03B13400  token=0x6000127  System.Void Awake()
  RVA=0x038A4F30  token=0x6000128  System.Void OnEnable()
  RVA=0x038A4E90  token=0x6000129  System.Void OnDisable()
  RVA=0x038A4DF0  token=0x600012A  System.Void OnDestroy()
  RVA=0x03CFE7E0  token=0x600012B  System.Void .ctor()
  RVA=0x03D44720  token=0x600012C  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.InputBindingGroupNaviDecorator
TYPE:  class
TOKEN: 0x2000038
SIZE:  0x190
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           Beyond.Input.InputBindingGroupMonoTargetm_inputBindingGroup  // 0x180
  public            UnityEngine.Events.UnityEvent<System.Boolean>onGroupSetAsNaviTarget  // 0x188
METHODS:
  RVA=0x0384BAC0  token=0x600012D  System.Void _SetSelfEnabledStateIfNecessary()
  RVA=0x02A72990  token=0x600012E  System.Void Awake()
  RVA=0x0384BA40  token=0x600012F  System.Void OnEnable()
  RVA=0x03B137E0  token=0x6000130  System.Void OnDestroy()
  RVA=0x09AAE8F4  token=0x6000131  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  RVA=0x03B13820  token=0x6000132  System.Void ClearComponent()
  RVA=0x02849830  token=0x6000133  System.Void .ctor()
  RVA=0x09AAE8DC  token=0x6000134  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AAE8EC  token=0x6000135  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09AAE8E4  token=0x6000136  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x0350B670  token=0x6000137  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.IUIClearable
TYPE:  interface
TOKEN: 0x2000039
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000138  System.Void ClearComponent()
END_CLASS

CLASS: Beyond.UI.LuaPanel
TYPE:  class
TOKEN: 0x200003A
SIZE:  0xB8
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public    static  System.Collections.Generic.Dictionary<System.String,Beyond.UI.LuaPanel>s_openedLuaPanels  // static @ 0x0
  private           System.Boolean                  _isPCOnlyPanel  // 0x18
  private           System.Boolean                  _isControllerPanel  // 0x19
  public            System.Boolean                  inited  // 0x1a
  private           System.Boolean                  _isWorldUI  // 0x1b
  private           UnityEngine.Vector3             _uiRot  // 0x1c
  private           System.Boolean                  _blockWhileAnim  // 0x28
  private           System.Int32                    <panelLevel>k__BackingField  // 0x2c
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x30
  private           Beyond.Audio.AudioUIUtil.UIAudioType_uiAudioType  // 0x38
  private           UnityEngine.RectTransform       <rectTransform>k__BackingField  // 0x40
  private           UnityEngine.Canvas              <canvas>k__BackingField  // 0x48
  public            System.Collections.Generic.HashSet<Beyond.UI.UISortingOrder>sortingOrderComps  // 0x50
  private           UnityEngine.Camera              <uiCamera>k__BackingField  // 0x58
  private           System.Single                   <planeDistance>k__BackingField  // 0x60
  private           System.Int32                    <panelId>k__BackingField  // 0x64
  private           System.String                   <panelName>k__BackingField  // 0x68
  private           System.Boolean                  m_showRot  // 0x70
  private           Beyond.Input.InputBindingGroupMonoTargetm_inputBindingGroupMonoTarget  // 0x78
  private           UnityEngine.UI.GraphicRaycaster[]m_graphicRaycasters  // 0x80
  private           System.Boolean                  m_started  // 0x88
  private           UnityEngine.Coroutine           m_animationInCoroutine  // 0x90
  private           System.Boolean                  m_waitAutoAnimInFinished  // 0x98
  public            Beyond.DisposedUnityEvent       onAnimationInFinished  // 0xa0
  private           System.Boolean                  m_animationInFinished  // 0xa8
  private           System.Collections.Generic.HashSet<UnityEngine.GameObject>m_animationInWaitTargets  // 0xb0
PROPERTIES:
  blockWhileAnim  get=0x03D4ED50
  panelLevel  get=0x03D4EDD0  set=0x03D4EDE0
  rectTransform  get=0x03D4E2B0  set=0x03CB2D80
  canvas  get=0x03D4EA70  set=0x02692290
  uiCamera  get=0x03D4EAA0  set=0x03081D30
  planeDistance  get=0x03D50D50  set=0x03D50D80
  panelId  get=0x03D50B30  set=0x03D50B40
  panelName  get=0x03D4EAB0  set=0x038C5570
  IsWorldUI  get=0x03D52270  set=0x03D522A0
  isPCOnlyPanel  get=0x01002A50
  isControllerPanel  get=0x03D4EF80
  animationInFinished  get=0x011B9C10
METHODS:
  RVA=0x02A72C50  token=0x600014C  System.Void Awake()
  RVA=0x02A72D50  token=0x600014D  System.Void _TrySetRot()
  RVA=0x02A73240  token=0x600014E  System.Void AddSortingOrderComp(Beyond.UI.UISortingOrder comp)
  RVA=0x03A41290  token=0x600014F  System.Void RemoveSortingOrderComp(Beyond.UI.UISortingOrder comp)
  RVA=0x036CDB20  token=0x6000150  System.Void Start()
  RVA=0x02EA2AF0  token=0x6000151  System.Void OnEnable()
  RVA=0x02EA28C0  token=0x6000152  System.Void OnDisable()
  RVA=0x03858BE0  token=0x6000153  System.Void OnDestroy()
  RVA=0x02EA2BD0  token=0x6000154  System.Collections.IEnumerator _AutoAnimationInFinish()
  RVA=0x025CB810  token=0x6000156  System.Boolean InformAnimationInStart(UnityEngine.GameObject target)
  RVA=0x028725D0  token=0x6000157  System.Void InformAnimationInEnd(UnityEngine.GameObject target, System.Boolean forceEnd)
  RVA=0x02872670  token=0x6000158  System.Void _TryCallAnimationInFinished(System.Boolean forceFinished)
  RVA=0x02BA02F0  token=0x6000159  System.Void BlockAllInput()
  RVA=0x02BA03E0  token=0x600015A  System.Void RecoverAllInput()
  RVA=0x03858C20  token=0x600015B  System.Void ClearComponent()
  RVA=0x028484F0  token=0x600015C  System.Void .ctor()
  RVA=0x03CE3A60  token=0x600015D  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.MouseHoverTipsPosHelper
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x80
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.RectOffset          _padding  // 0x68
  private           Beyond.UI.LuaPanel              m_panel  // 0x70
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
PROPERTIES:
  tickOption  get=0x03D55B70
  panel  get=0x027FF5E0
METHODS:
  RVA=0x03B2E880  token=0x6000166  System.Void OnAwake()
  RVA=0x03B26EF0  token=0x6000167  System.Void OnEnable()
  RVA=0x037E9A20  token=0x6000168  System.Void LateTick(System.Single deltaTime)
  RVA=0x027FF1B0  token=0x6000169  System.Void UpdatePosition()
  RVA=0x02846010  token=0x600016A  System.Void .ctor()
  RVA=0x058E2A30  token=0x600016B  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x600016C  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x600016D  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.NaviToThisGroupOnEnable
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.UI.UISelectableNaviGroup target  // 0x18
METHODS:
  RVA=0x09AAF170  token=0x600016E  System.Void Reset()
  RVA=0x09AAF024  token=0x600016F  System.Void Awake()
  RVA=0x09AAF0D4  token=0x6000170  System.Void OnEnable()
  RVA=0x0426FE60  token=0x6000171  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.NonDrawingGraphic
TYPE:  class
TOKEN: 0x200003E
SIZE:  0xB8
EXTENDS: UnityEngine.UI.Graphic
IMPLEMENTS: UnityEngine.ICanvasRaycastFilter
FIELDS:
  public            Beyond.UI.NonDrawingGraphic.ShapeTypeshapeType  // 0xb0
PROPERTIES:
  Radius  get=0x02516C10
METHODS:
  RVA=0x03577A50  token=0x6000173  System.Void SetMaterialDirty()
  RVA=0x034D64F0  token=0x6000174  System.Void SetVerticesDirty()
  RVA=0x09AAF1F0  token=0x6000175  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x025174B0  token=0x6000176  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x02516B00  token=0x6000177  System.Boolean _IsRaycastLocationValidCircle(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x02700690  token=0x6000178  System.Void .ctor()
  RVA=0x09AAF254  token=0x6000179  System.Void <>iFixBaseProxy_SetMaterialDirty()
  RVA=0x09AAF25C  token=0x600017A  System.Void <>iFixBaseProxy_SetVerticesDirty()
  RVA=0x09AADB34  token=0x600017B  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
END_CLASS

CLASS: Beyond.UI.NotchAdapter
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x58
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            UnityEngine.Vector2             selfMarginSize  // 0x18
  public            System.Collections.Generic.List<UnityEngine.RectTransform>leftSideUIList  // 0x20
  public            System.Collections.Generic.List<UnityEngine.RectTransform>rightSideUIList  // 0x28
  public            System.Collections.Generic.List<UnityEngine.RectTransform>bottomSideUIList  // 0x30
  public            System.Collections.Generic.List<UnityEngine.RectTransform>fullHorizontalStretchUIList  // 0x38
  public            System.Boolean                  alwaysFindSideUI  // 0x40
  private           UnityEngine.UI.CanvasScaler     m_canvasScaler  // 0x48
  private           Beyond.UI.UICanvasScaleHelper   m_notchHost  // 0x50
METHODS:
  RVA=0x027FCE40  token=0x600017C  System.Void Awake()
  RVA=0x0381BA00  token=0x600017D  System.Void OnDestroy()
  RVA=0x027FCD00  token=0x600017E  System.Void FindAllSideUI(System.Boolean needClear)
  RVA=0x09AAF264  token=0x600017F  System.Void ApplyNotch()
  RVA=0x027FE830  token=0x6000180  System.Void ApplyNotch(UnityEngine.Vector2 curMarginSize)
  RVA=0x027FCC60  token=0x6000181  System.Void ClearList()
  RVA=0x027FEE20  token=0x6000182  System.Void ClearNullRef()
  RVA=0x09AAF2CC  token=0x6000183  System.Void UnApplyNotch()
  RVA=0x027FCDC0  token=0x6000184  System.Void ApplyNewNotch()
  RVA=0x027FCEF0  token=0x6000185  System.Void _UpdateMargeSizeFromNotchInfo(System.Boolean forceUpdate)
  RVA=0x027FCD80  token=0x6000186  System.Void _OnCanvasChanged()
  RVA=-1  // generic def  token=0x6000187  System.Void _RemoveNullRef(System.Collections.Generic.List<T> list)
  RVA=0x027FC420  token=0x6000188  System.Void _TraverseUI(UnityEngine.RectTransform root)
  RVA=0x027FC7D0  token=0x6000189  System.Void _TryAddToSideUI(UnityEngine.RectTransform rect, Beyond.UI.CustomNotchAdapt custom)
  RVA=0x028494C0  token=0x600018A  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.ParallaxHelper
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.ParallaxHelper.ParallaxConfig>_configs  // 0x18
  private           System.Single                   _maxOffset  // 0x20
  private           System.Single                   m_curValue  // 0x24
PROPERTIES:
  curValue  get=0x03D524F0  set=0x09AC06E8
METHODS:
  RVA=0x09AC0330  token=0x6000190  System.Void InitConfigs()
  RVA=0x09AC0690  token=0x6000191  System.Void ResetValue()
  RVA=0x09AC04B8  token=0x6000192  System.Void RefreshPos()
  RVA=0x0426FE60  token=0x6000193  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.PercentNumberTweener
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x88
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIText                _text  // 0x68
  private           System.String                   _format  // 0x70
  private           Beyond.UI.UIImage               _progressImg  // 0x78
  private           System.Int32                    m_cacheValue  // 0x80
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x09AC086C  token=0x6000196  System.Void Reset()
  RVA=0x09AC080C  token=0x6000197  System.Void OnEnable()
  RVA=0x09AC06F4  token=0x6000198  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AC08EC  token=0x6000199  System.Void .ctor()
  RVA=0x058DD8AC  token=0x600019A  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x600019B  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutAdapter
TYPE:  abstract class
TOKEN: 0x2000045
SIZE:  0x18
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup.IViewHandler<viewHandler>k__BackingField  // 0x10
PROPERTIES:
  viewHandler  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x09AC6794  token=0x600019C  System.Void Init(Beyond.UI.UIRecycleLayoutGroup.IViewHandler handler)
  RVA=0x09AC6748  token=0x600019F  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  RVA=-1  // abstract  token=0x60001A0  System.Void OnInit()
  RVA=0x0350B670  token=0x60001A1  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutSimpleHolder`1
TYPE:  abstract class
TOKEN: 0x200004A
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x0
  protected         System.Single                   _scrollDuration  // 0x0
  protected         DG.Tweening.Ease                _scrollEase  // 0x0
  protected         System.Boolean                  _enableLoopWrappedNavigation  // 0x0
  private           System.Boolean                  m_isInited  // 0x0
  protected         Beyond.UI.UIRecycleLayoutSimpleHolder.SimpleAdapter<TVirtualView>m_simpleAdapter  // 0x0
  protected         Beyond.UI.UIRecycleLayoutGroup  m_layoutGroup  // 0x0
  public            Beyond.DisposedUnityEvent       doOnceAfterLayout  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x0
  protected         DG.Tweening.Tween               m_scrollTween  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001B4  System.Void _InitIfNot()
  RVA=-1  // not resolved  token=0x60001B5  System.Void OnAwake()
  RVA=-1  // not resolved  token=0x60001B6  System.Void _AfterLayout()
  RVA=-1  // not resolved  token=0x60001B7  System.Void _WrapNavigation(UnityEngine.UI.NaviDirection dir)
  RVA=-1  // abstract  token=0x60001B8  System.Void OnAdapterInit()
  RVA=-1  // not resolved  token=0x60001B9  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode)
  RVA=-1  // not resolved  token=0x60001BA  System.Void ClearScrollTweenIfNeeded()
  RVA=-1  // not resolved  token=0x60001BB  System.Void ScrollToInternal(System.Single normalizedPosition, System.Boolean fastMode)
  RVA=-1  // not resolved  token=0x60001BC  UnityEngine.GameObject GetView(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001BD  System.Void NotifyAllSizeChanged()
  RVA=-1  // not resolved  token=0x60001BE  System.Void NotifySizeChanged(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001BF  System.Void NotifySizeChanged(TVirtualView virtualView)
  RVA=-1  // not resolved  token=0x60001C0  System.Void RemoveView(System.Int32 index)
  RVA=-1  // not resolved  token=0x60001C1  System.Void RemoveAllViews()
  RVA=-1  // not resolved  token=0x60001C2  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutGroup
TYPE:  class
TOKEN: 0x200004D
SIZE:  0xC8
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.UI.ILayoutElement Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup.Direction_direction  // 0x68
  private           UnityEngine.RectTransform       _viewport  // 0x70
  private           UnityEngine.RectTransform       _content  // 0x78
  private           System.Single                   _notCachedBufferSize  // 0x80
  private           System.Int32                    _layoutPriority  // 0x84
  private           Beyond.UI.UIRecycleLayoutGroup.Padding_padding  // 0x88
  private           System.Single                   _spacing  // 0x98
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIRecycleLayoutGroup.LayoutMeta>m_layoutMetaMap  // 0xa0
  private           Beyond.UI.UIRecycleLayoutAdapterm_adapter  // 0xa8
  private           Beyond.UI.UIRecycleLayoutGroup.ViewMgrm_viewMgr  // 0xb0
  private           System.Single                   <sizeOnAxis>k__BackingField  // 0xb8
  public            Beyond.DisposedUnityEvent       onLayoutUpdated  // 0xc0
PROPERTIES:
  tickOption  get=0x03D55B70
  adapter  get=0x09AC7F3C
  viewMgr  get=0x09AC80D8
  sizeOnAxis  get=0x03D599C0  set=0x03D50850
  spacing  get=0x03D57D90
  padding  get=0x03D5C7E0
  minWidth  get=0x03D503F0
  minHeight  get=0x03D503F0
  flexibleWidth  get=0x03D503F0
  flexibleHeight  get=0x03D503F0
  layoutPriority  get=0x03D4F370
  preferredWidth  get=0x09AC80C4
  preferredHeight  get=0x09AC80B0
  paddingFront  get=0x09AC8044
  paddingBack  get=0x09AC7FD8
  content  get=0x03D4EB20
METHODS:
  RVA=0x09AC6804  token=0x60001E1  System.Void CalculateLayoutInputHorizontal()
  RVA=0x09AC6848  token=0x60001E2  System.Void CalculateLayoutInputVertical()
  RVA=0x09AC6D64  token=0x60001E7  System.Void _ApplyLayoutMeta(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta)
  RVA=0x09AC7580  token=0x60001E8  UnityEngine.Vector2 _GetVisibleRange(UnityEngine.Bounds viewBound)
  RVA=0x09AC7224  token=0x60001E9  UnityEngine.Bounds _GetElementBoundsFromMeta(Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta)
  RVA=0x09AC6CB4  token=0x60001EA  Beyond.UI.UIRecycleLayoutAdapter SetAdapter(Beyond.UI.UIRecycleLayoutAdapter adapter)
  RVA=0x09AC688C  token=0x60001EB  System.Void ClearComponent()
  RVA=0x09AC691C  token=0x60001EC  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AC697C  token=0x60001ED  System.Void OnLateTick()
  RVA=0x09AC7818  token=0x60001EE  System.Void _RebuildAllViews()
  RVA=0x09AC7B90  token=0x60001EF  System.Void _UpdateViews(System.Int32 fromIndex)
  RVA=0x09AC7690  token=0x60001F0  System.Boolean _InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC7928  token=0x60001F1  System.Boolean _RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC7ACC  token=0x60001F2  System.Void _UpdateViewsFrom(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC74B0  token=0x60001F3  System.Single _GetElementPosByIndex(System.Int32 index)
  RVA=0x09AC70F0  token=0x60001F4  UnityEngine.Bounds _GetElementBoundsByIndex(System.Int32 index)
  RVA=0x09AC73FC  token=0x60001F5  System.Int32 _GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  RVA=0x09AC78D0  token=0x60001F7  System.Void _RefreshLayout()
  RVA=0x09AC7E70  token=0x60001F8  System.Void .ctor()
  RVA=0x0589E548  token=0x60001F9  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIRecycleMultiHolder
TYPE:  class
TOKEN: 0x2000056
SIZE:  0xD8
EXTENDS: Beyond.UI.UIRecycleLayoutSimpleHolder`1
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleMultiHolder.Config>_configs  // 0xa8
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xb0
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onDetachCell  // 0xb8
  public            System.Func<System.Int32,System.Single>getCellDefaultSize  // 0xc0
  public            System.Func<System.Int32,System.String>getCellPrefabKey  // 0xc8
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject>m_prefabMap  // 0xd0
METHODS:
  RVA=0x09AC8368  token=0x6000227  Beyond.UI.UIRecycleMultiHolder.MultiVirtualView GetVirtualView(System.Int32 index)
  RVA=0x09AC8818  token=0x6000228  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  RVA=0x09AC8898  token=0x6000229  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex)
  RVA=0x09AC83F4  token=0x600022A  System.Void InsertView(System.Int32 index, System.String key, System.Single initSize)
  RVA=0x09AC8188  token=0x600022B  System.Void AddView(System.String key, System.Single initSize)
  RVA=0x09AC84E8  token=0x600022C  System.Void OnAdapterInit()
  RVA=0x09AC8268  token=0x600022D  System.Void ClearComponent()
  RVA=0x09AC8A7C  token=0x600022E  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleSingleHolder
TYPE:  class
TOKEN: 0x2000059
SIZE:  0xD0
EXTENDS: Beyond.UI.UIRecycleLayoutSimpleHolder`1
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Int32                    m_count  // 0xa8
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xb0
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onDetachCell  // 0xb8
  public            System.Func<System.Int32,System.Single>getCellDefaultSize  // 0xc0
  private           UnityEngine.GameObject          _cellTemplate  // 0xc8
METHODS:
  RVA=0x09AC8DA4  token=0x6000236  Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView GetVirtualView(System.Int32 index)
  RVA=0x09AC8F74  token=0x6000237  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  RVA=0x09AC8FF4  token=0x6000238  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex)
  RVA=0x09AC8E30  token=0x6000239  System.Void InsertView(System.Int32 index, System.String key, System.Single initSize)
  RVA=0x09AC8BEC  token=0x600023A  System.Void AddView(System.String key, System.Single initSize)
  RVA=0x09AC8F14  token=0x600023B  System.Void OnAdapterInit()
  RVA=0x09AC8CBC  token=0x600023C  System.Void ClearComponent()
  RVA=0x09AC9188  token=0x600023D  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.SimpleUITextSingleLine
TYPE:  class
TOKEN: 0x200005B
SIZE:  0xC90
EXTENDS: Beyond.UI.UIText
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextMarker  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIMarker  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_CharacterLookupMarker  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_HandleGPOSFeaturesMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_CalculateVerticesPositionMarker  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_ComputeTextMetricsMarker  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker  // static @ 0x30
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_1  // static @ 0x38
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_2  // static @ 0x40
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_3  // static @ 0x48
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_4  // static @ 0x50
  private   static  Unity.Profiling.ProfilerMarker  s_HandleWhiteSpacesMarker  // static @ 0x58
  private   static  Unity.Profiling.ProfilerMarker  s_HandleHorizontalLineBreakingMarker  // static @ 0x60
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVerticalLineBreakingMarker  // static @ 0x68
  private   static  Unity.Profiling.ProfilerMarker  s_SaveGlyphVertexDataMarker  // static @ 0x70
  private   static  Unity.Profiling.ProfilerMarker  s_ComputeCharacterAdvanceMarker  // static @ 0x78
  private   static  Unity.Profiling.ProfilerMarker  s_HandleCarriageReturnMarker  // static @ 0x80
  private   static  Unity.Profiling.ProfilerMarker  s_HandleLineTerminationMarker  // static @ 0x88
  private   static  Unity.Profiling.ProfilerMarker  s_SavePageInfoMarker  // static @ 0x90
  private   static  Unity.Profiling.ProfilerMarker  s_SaveProcessingStatesMarker  // static @ 0x98
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIIMarker  // static @ 0xa0
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIIIMarker  // static @ 0xa8
  public            System.Boolean                  m_b  // 0xc80
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xc88
EVENTS:
  OnPreRenderText  add=add_OnPreRenderText  remove=remove_OnPreRenderText
METHODS:
  RVA=0x09AB4DEC  token=0x6000244  System.Void GenerateTextMesh()
  RVA=0x09AC0E34  token=0x6000247  System.Void .ctor()
  RVA=0x09AC0944  token=0x6000248  System.Void .cctor()
  RVA=0x09AC093C  token=0x6000249  System.Void <>iFixBaseProxy_GenerateTextMesh()
END_CLASS

CLASS: Beyond.UI.ToastList
TYPE:  class
TOKEN: 0x200005C
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           UnityEngine.GameObject          _cellTemplate  // 0x18
  private           System.Single                   _showDuration  // 0x20
  private           System.Single                   _delay  // 0x24
  private           System.Int32                    _maxShowingCount  // 0x28
  private           System.Boolean                  <inAnimation>k__BackingField  // 0x2c
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0x30
  public            Beyond.DisposedUnityEvent       onAllToastFinished  // 0x38
  private           System.Int32                    m_totalCount  // 0x40
  private           System.Int32                    m_maxFinishedIndex  // 0x44
  private           System.Int32                    m_maxShowingIndex  // 0x48
  private           System.Int32                    m_waitingCount  // 0x4c
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.ToastList.CellInfo>m_showingCells  // 0x50
  private           System.Collections.Generic.List<Beyond.UI.ToastList.CellInfo>m_cachedCells  // 0x58
PROPERTIES:
  inAnimation  get=0x03D4F1A0  set=0x03D4F1B0
METHODS:
  RVA=0x09AC13EC  token=0x600024C  System.Void Awake()
  RVA=0x09AC1684  token=0x600024D  System.Void OnDisable()
  RVA=0x09AC17A0  token=0x600024E  Beyond.UI.ToastList.CellInfo _GetCell()
  RVA=0x09AC16D4  token=0x600024F  System.Void _CacheCell(Beyond.UI.ToastList.CellInfo cell)
  RVA=0x09AC1298  token=0x6000250  System.Void AddToast(System.Int32 count, System.Int32 startIndex)
  RVA=0x09AC1B88  token=0x6000251  System.Void _StartBatch(System.Int32 batchCount)
  RVA=0x09AC1ACC  token=0x6000252  System.Collections.IEnumerator _ShowCell(System.Int32 delayIndex, Beyond.UI.ToastList.CellInfo cell)
  RVA=0x09AC1C90  token=0x6000253  System.Void _TryShowNewCell()
  RVA=0x09AC1914  token=0x6000254  System.Void _OnCellFinished(Beyond.UI.ToastList.CellInfo cell)
  RVA=0x09AC144C  token=0x6000255  System.Void ClearAllToast()
  RVA=0x09AC1614  token=0x6000256  System.Void ClearComponent()
  RVA=0x09AC1E8C  token=0x6000257  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UI3DScrollList
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x278
EXTENDS: Beyond.UI.UIScrollList
FIELDS:
METHODS:
  RVA=0x09AC2644  token=0x600025F  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  RVA=0x09AC2704  token=0x6000260  System.Void .ctor()
  RVA=0x09AC26FC  token=0x6000261  System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
END_CLASS

CLASS: Beyond.UI.UIActionKeyHint
TYPE:  class
TOKEN: 0x2000060
SIZE:  0xB8
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private   static readonly UnityEngine.Color               NORMAL_COLOR  // static @ 0x0
  private   static readonly UnityEngine.Color               HIDE_COLOR  // static @ 0x10
  private   static readonly UnityEngine.Color               DISABLED_COLOR  // static @ 0x20
  private   static  System.Collections.Generic.List<Beyond.UI.UIActionKeyHint>s_keyHintCache  // static @ 0x30
  private   static  System.Boolean                  s_inited  // static @ 0x38
  public    static  System.Boolean                  s_stopCheckBindingEnabledForGuide  // static @ 0x39
  private   static  System.String                   INVALID_KEY_STR  // const
  private           Beyond.Input.IBindingView       m_target  // 0x18
  public            System.String                   actionId  // 0x20
  public            UnityEngine.Component           btnTarget  // 0x28
  public            Beyond.Input.BindingViewActionTypebindingViewActionType  // 0x30
  private           System.Boolean                  _useCustomText  // 0x34
  private           System.Boolean                  _showSecondAction  // 0x35
  private           System.Boolean                  _onlyShowOnLongPress  // 0x36
  private           System.Boolean                  _adaptForceGrayState  // 0x37
  private           UnityEngine.Transform           _content  // 0x38
  private           UnityEngine.CanvasGroup         _contentCanvasGroup  // 0x40
  private           Beyond.UI.UIImage               _icon  // 0x48
  private           Beyond.UI.UIImage               _longPressIcon  // 0x50
  private           UnityEngine.RectTransform       _pressHintNode  // 0x58
  private           Beyond.UI.UIImage               _pressHintProgressImg  // 0x60
  private           Beyond.UI.UIText                _text  // 0x68
  private           Beyond.UI.UIImage               _secondIcon  // 0x70
  private           UnityEngine.RectTransform       _secondNode  // 0x78
  private           Beyond.UI.UIImage               _modifyIcon  // 0x80
  private           UnityEngine.GameObject          _mutexGameObject  // 0x88
  private           System.Boolean                  _changeScaleOnHide  // 0x90
  public            System.Int32                    bindingId  // 0x94
  public            System.Func<System.Boolean>     checkVirtualMouseClickHintFunc  // 0x98
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0xa0
  public            System.Boolean                  autoUpdate  // 0xa8
  private           System.Boolean                  <hintHidden>k__BackingField  // 0xa9
  private           System.Int32                    m_cachedBindingId  // 0xac
  private           System.Boolean                  m_isLongPressAction  // 0xb0
  private           System.Single                   m_lastPressStartTime  // 0xb4
  private   static  System.Single                   LONG_PRESS_HINT_HIDE_TIME  // const
  private   static  System.Single                   LONG_PRESS_HINT_SHOW_MIN_VALUE  // const
PROPERTIES:
  target  get=0x0251A320
  showCanvasGroup  get=0x09AC3160
  hintHidden  get=0x03D5AB90  set=0x03D5ABB0
METHODS:
  RVA=0x0270CB90  token=0x6000262  System.Void _TryInit()
  RVA=0x09AC2E68  token=0x6000263  System.Void _RefreshAllKeyHints()
  RVA=0x02517BA0  token=0x6000264  System.Void _OnInputLateTickAll()
  RVA=0x09AC2D48  token=0x6000265  System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType)
  RVA=0x0270CA20  token=0x600026A  System.Void Awake()
  RVA=0x02C72990  token=0x600026B  System.Void OnEnable()
  RVA=0x02C726C0  token=0x600026C  System.Void OnDisable()
  RVA=0x03988E50  token=0x600026D  System.Void OnDestroy()
  RVA=0x09AC2750  token=0x600026E  System.Void Reset()
  RVA=0x09AC2E40  token=0x600026F  System.Void _OnInputLateTick()
  RVA=0x02C72B10  token=0x6000270  System.Void UpdateKeyHint()
  RVA=0x02BDE5C0  token=0x6000271  System.Void SetActionId(System.String id, System.Boolean forceUpdate)
  RVA=0x02BDE620  token=0x6000272  System.Void SetKeyHint(System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate)
  RVA=0x02BDE6C0  token=0x6000273  System.Void SetBindingId(System.Int32 bId, System.Boolean forceUpdate)
  RVA=0x09AC2868  token=0x6000274  System.Void SetBindingId(System.Int32 bId, System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate)
  RVA=0x02BDE780  token=0x6000275  System.Void _OnChangeTarget()
  RVA=0x09AC2DC4  token=0x6000276  System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& data)
  RVA=0x02C72F80  token=0x6000277  System.Void SetSecondActionId(System.String id, System.Boolean isPrimary)
  RVA=0x02C73040  token=0x6000278  System.Void _SetSecondIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean isPrimary)
  RVA=0x02519A10  token=0x6000279  System.Void _CheckInteractable(System.Boolean isInit)
  RVA=0x029E3020  token=0x600027A  System.Boolean _IsInputEnabled()
  RVA=0x09AC2AF8  token=0x600027B  System.Boolean _IsInputGray()
  RVA=0x02BDF930  token=0x600027C  System.String GetTextStr()
  RVA=0x09AC292C  token=0x600027D  System.Void SetText(System.String text)
  RVA=0x02C731B0  token=0x600027E  System.Boolean GetAndSetActionIcon(Beyond.UI.UIImage iconImage, Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean& isLongPressAction, System.Boolean isPrimary)
  RVA=0x02C728B0  token=0x600027F  System.Boolean GetAndSetActionModifyIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean isPrimary)
  RVA=0x02C73610  token=0x6000280  System.Boolean _SetKeyCodeSprite(Beyond.UI.UIImage iconImage, System.String iconPath)
  RVA=0x09AC2998  token=0x6000281  System.Void _CheckVirtualMouseClickHint()
  RVA=0x09AC2F74  token=0x6000282  System.Void _UpdatePressHint()
  RVA=0x09AC2A48  token=0x6000283  System.Void _GetLongPressInfo(System.Single& startTime, System.Single& longPressTime)
  RVA=0x029E2C00  token=0x6000284  System.String GetActionId()
  RVA=0x02C72EE0  token=0x6000285  Beyond.Input.PlayerActionInfo GetActionInfo()
  RVA=0x02C72570  token=0x6000286  System.Void ClearComponent()
  RVA=0x02C72E50  token=0x6000287  System.Void SetContentState(System.Boolean contentState)
  RVA=0x03539A60  token=0x6000288  System.Void .ctor()
  RVA=0x03B5DE90  token=0x6000289  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationHolder
TYPE:  class
TOKEN: 0x2000061
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.IAnimationClipSource
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UIAnimationHolder.ClipHolder>_clips  // 0x18
METHODS:
  RVA=0x09AC321C  token=0x600028A  UnityEngine.AnimationClip FindByName(System.String name)
  RVA=0x09AC31B4  token=0x600028B  UnityEngine.AnimationClip FindByNameOrAlias(System.String nameOrAlias)
  RVA=0x09AC32D8  token=0x600028C  UnityEngine.AnimationClip _FindByString(System.String id, System.Boolean useAlias)
  RVA=0x09AC3284  token=0x600028D  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results)
  RVA=0x03C8AFC0  token=0x600028E  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationLoopSynchronizer
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.String                   syncLoopAnimKey  // 0x18
  private   readonly System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper>m_children  // 0x20
METHODS:
  RVA=0x03726CB0  token=0x6000290  System.Void RegisterChild(Beyond.UI.UIAnimationWrapper child)
  RVA=0x09AC34EC  token=0x6000291  System.Void UnregisterChild(Beyond.UI.UIAnimationWrapper child)
  RVA=0x032886A0  token=0x6000292  System.Single GetLoopStartPosition()
  RVA=0x03C8AF40  token=0x6000293  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationWrapper
TYPE:  class
TOKEN: 0x2000064
SIZE:  0xC0
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           UnityEngine.AnimationClip       _animationIn  // 0x18
  private           UnityEngine.AnimationClip       _animationInEasing  // 0x20
  private           UnityEngine.AnimationClip       _animationLoop  // 0x28
  private           UnityEngine.AnimationClip       _animationOut  // 0x30
  public            System.Boolean                  autoPlay  // 0x38
  private           System.Boolean                  _onlyOnce  // 0x39
  private           System.Boolean                  _needSyncLoopAnim  // 0x3a
  private           System.String                   _syncLoopAnimKey  // 0x40
  private           Beyond.UI.UIAnimationWrapper.FOptions_options  // 0x48
  private           UnityEngine.Animation           m_animation  // 0x50
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIAnimationWrapper.AnimationRuntime>m_animPool  // 0x58
  private           Beyond.UI.UIAnimationTween      m_curTween  // 0x60
  private           System.Boolean                  m_isInAutoPlayed  // 0x68
  private           Beyond.UI.UIAnimationLoopSynchronizerm_loopSynchronizer  // 0x70
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIAnimationLoopSynchronizer>s_tempSyncList  // static @ 0x0
  public            System.String                   curStateName  // 0x78
  public            Beyond.UI.UIConst.AnimationStatecurState  // 0x80
  private           System.Single                   m_lastPlayAnimationInStartTime  // 0x84
  private           System.Boolean                  m_started  // 0x88
  private           Beyond.UI.UIAnimationWrapper.CachedSampleClipInfom_cachedSampleClipInfo  // 0x90
  private           System.Boolean                  m_needInformAnimationInEnd  // 0xa0
  private           Beyond.UI.LuaPanel              m_panel  // 0xa8
  private           System.String                   _audioOnOpen  // 0xb0
  private           System.String                   _audioOnClose  // 0xb8
PROPERTIES:
  animationIn  get=0x01041090
  animationInEasing  get=0x03D4EB40
  animationLoop  get=0x03D4EAC0
  animationOut  get=0x01003830
  curTween  get=0x03D4EB00
  panel  get=0x025CBD80
METHODS:
  RVA=0x03D43920  token=0x6000298  System.Void SetOptions(Beyond.UI.UIAnimationWrapper.FOptions options)
  RVA=0x025CCEC0  token=0x600029A  System.Void _InitAnimation()
  RVA=0x09AC3EF8  token=0x600029B  System.Void _AnimationInLoopCheck()
  RVA=0x09AC3E20  token=0x600029C  System.Void _AnimationAutomaticallyCheck()
  RVA=0x025CC7C0  token=0x600029D  System.Void Awake()
  RVA=0x09AC3AA0  token=0x600029E  System.Boolean IsStarted()
  RVA=0x0260AE30  token=0x600029F  System.Void PlayOutAnimation(DG.Tweening.TweenCallback callback)
  RVA=0x0228D240  token=0x60002A0  System.Void SetAnimationInClip(System.String clipName)
  RVA=0x0228D6B0  token=0x60002A1  System.Void SetAnimationInEasingClip(System.String clipName)
  RVA=0x0228DB20  token=0x60002A2  System.Void SetAnimationLoopClip(System.String clipName)
  RVA=0x09AC3C64  token=0x60002A3  System.Void SetAnimationOutClip(System.String clipName)
  RVA=0x09AC38C0  token=0x60002A4  System.Single GetInClipLength()
  RVA=0x09AC3A00  token=0x60002A5  System.Single GetOutClipLength()
  RVA=0x09AC3960  token=0x60002A6  System.Single GetLoopClipLength()
  RVA=0x03288580  token=0x60002A7  System.Void PlayLoopAnimation()
  RVA=0x025CBA80  token=0x60002A8  System.Void PlayInAnimation(DG.Tweening.TweenCallback callback, System.Boolean autoPlayLoop)
  RVA=0x09AC3CDC  token=0x60002A9  System.Void SkipInAnimation()
  RVA=0x0309A180  token=0x60002AA  System.Void SampleToInAnimationBegin()
  RVA=0x02B771E0  token=0x60002AB  System.Void SampleToInAnimationEnd()
  RVA=0x09AC3BA8  token=0x60002AC  System.Void SampleToOutAnimationBegin()
  RVA=0x02B797F0  token=0x60002AD  System.Void SampleToOutAnimationEnd()
  RVA=0x032882F0  token=0x60002AE  System.Void _OnInAnimationFinished(System.Boolean autoPlayLoop)
  RVA=0x032884D0  token=0x60002AF  System.Void _OnInEasingAnimationFinished(System.Boolean autoPlayLoop)
  RVA=0x025CCE20  token=0x60002B0  UnityEngine.AnimationState GetClip(System.String aniName)
  RVA=0x02B78A90  token=0x60002B1  System.Single GetClipLength(System.String aniName)
  RVA=0x025CDE10  token=0x60002B2  System.Void _SampleClipAtLength(Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime, System.Single position)
  RVA=0x02B78A10  token=0x60002B3  System.Void SampleClipAtPercent(System.String clipName, System.Single percent, System.Boolean clearTween)
  RVA=0x025CD8C0  token=0x60002B4  System.Void SampleClip(System.String clipName, System.Single position, System.Boolean clearTween)
  RVA=0x025CE410  token=0x60002B5  System.Void ClearTween(System.Boolean executeOnComplete)
  RVA=0x025CB9F0  token=0x60002B6  System.Boolean _CheckShouldAutoPlayAnimationIn()
  RVA=0x0341C330  token=0x60002B7  System.Void Start()
  RVA=0x025CB8D0  token=0x60002B8  System.Void OnEnable()
  RVA=0x025CCD80  token=0x60002B9  System.Void OnDisable()
  RVA=0x034A9200  token=0x60002BA  System.Void OnDestroy()
  RVA=0x09AC37F4  token=0x60002BB  System.Boolean CheckStopped()
  RVA=0x09AC3AF0  token=0x60002BC  System.Void Play(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  RVA=0x03D08600  token=0x60002BD  System.Void Play(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  RVA=0x025CBCF0  token=0x60002BE  System.Void PlayWithTween(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  RVA=0x025CC330  token=0x60002BF  System.Void PlayWithTween(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  RVA=0x09AC3848  token=0x60002C0  System.Single GetCurPlayingTime()
  RVA=0x025CBC90  token=0x60002C2  System.Void PlayOpenAudio()
  RVA=0x0260AFB0  token=0x60002C3  System.Void PlayCloseAudio()
  RVA=0x025CE620  token=0x60002C4  System.Void ClearComponent()
  RVA=0x02815830  token=0x60002C5  System.Void .ctor()
  RVA=0x03CE2CE0  token=0x60002C6  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationTween
TYPE:  class
TOKEN: 0x200006C
SIZE:  0x30
FIELDS:
  public    static readonly Beyond.UI.UIAnimationTween.OptionsDEFAULT_OPTION  // static @ 0x0
  private           DG.Tweening.Tween               m_handler  // 0x10
  private           System.Single                   m_tweenValue  // 0x18
  private           UnityEngine.GameObject          m_animTarget  // 0x20
  private           System.Single                   <clipLength>k__BackingField  // 0x28
PROPERTIES:
  handler  get=0x020B7B20
  tweenValue  get=0x03D4EBF0
  clipLength  get=0x03D4F480  set=0x03D4F490
METHODS:
  RVA=0x09AC3768  token=0x60002D7  System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name)
  RVA=0x025CBF90  token=0x60002D8  System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name, Beyond.UI.UIAnimationTween.Options options)
  RVA=0x034E6250  token=0x60002D9  System.Single GetValue()
  RVA=0x025CD6F0  token=0x60002DA  System.Void _SetValue(Beyond.UI.UIAnimationWrapper wrapper, System.String name, System.Single value)
  RVA=0x03D2C800  token=0x60002DB  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationSwitchTween
TYPE:  class
TOKEN: 0x2000070
SIZE:  0x40
EXTENDS: Beyond.UI.UISwitchTween
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    m_animWrapper  // 0x30
  private           System.Boolean                  m_dontDisableGameObject  // 0x38
METHODS:
  RVA=0x04270470  token=0x60002E2  System.Void .ctor(Beyond.UI.UIAnimationWrapper animWrapper)
  RVA=0x09AC3628  token=0x60002E3  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  RVA=0x09AC36BC  token=0x60002E4  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  RVA=0x09AC35D0  token=0x60002E5  System.Void BeforeShowEffect()
  RVA=0x09AC3578  token=0x60002E6  System.Void AfterHideEffect()
  RVA=0x03B2B4C0  token=0x60002E7  System.Void ResetToState(System.Boolean isShow)
  RVA=0x03B2B580  token=0x60002E8  System.Void _SetGameObjectActive(System.Boolean isActive)
  RVA=0x09AC3758  token=0x60002E9  System.Void <>iFixBaseProxy_BeforeShowEffect()
  RVA=0x09AC3750  token=0x60002EA  System.Void <>iFixBaseProxy_AfterHideEffect()
  RVA=0x09AC3760  token=0x60002EB  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.UIArea
TYPE:  class
TOKEN: 0x2000073
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerExitHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerEnter  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerExit  // 0x20
  private           System.Boolean                  m_pointerInArea  // 0x28
  public            UnityEngine.GameObject          _highlightNode  // 0x30
PROPERTIES:
  pointerInArea  get=0x03D4ED50
METHODS:
  RVA=0x09AC43CC  token=0x60002F4  System.Void _SetHighlightNodeActive(System.Boolean active)
  RVA=0x09AC4294  token=0x60002F5  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC4330  token=0x60002F6  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC423C  token=0x60002F7  System.Void OnEnable()
  RVA=0x09AC41E0  token=0x60002F8  System.Void OnDisable()
  RVA=0x09AC4184  token=0x60002F9  System.Void OnDestroy()
  RVA=0x09AC4118  token=0x60002FA  System.Void ClearComponent()
  RVA=0x0426FE60  token=0x60002FB  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAutoCloseArea
TYPE:  class
TOKEN: 0x2000074
SIZE:  0xD0
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp Beyond.Input.IBindingGroupTarget
FIELDS:
  public    static  System.Boolean                  s_stopCheckShouldClose  // static @ 0x0
  public            System.Collections.Generic.List<UnityEngine.RectTransform>fixedSafeAreas  // 0x68
  public            UnityEngine.RectTransform       tmpSafeArea  // 0x70
  public            System.Boolean                  alsoBlockKeyBoardInput  // 0x78
  private           System.Boolean                  _includeInAutoCloseLayer  // 0x79
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x80
  public            UnityEngine.GameObject          toggleObj  // 0x88
  public            Beyond.DisposedUnityEvent       onTriggerAutoClose  // 0x90
  private           System.String                   _closeActionId  // 0x98
  private           System.Boolean                  _enableCloseActionOnController  // 0xa0
  private           Beyond.UI.UIAnimationWrapper    m_animationWrapper  // 0xa8
  private   static  System.Collections.Generic.LinkedList<UnityEngine.GameObject>s_autoCloseLayerList  // static @ 0x8
  private           Beyond.UI.LuaPanel              m_panel  // 0xb0
  private           System.Int32                    <groupId>k__BackingField  // 0xb8
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0xc0
  private           System.Boolean                  m_bindingInit  // 0xc8
PROPERTIES:
  tickOption  get=0x03D55B70
  includeInAutoCloseLayer  get=0x03D51AE0  set=0x09AC48E0
  panel  get=0x0284E730
  groupId  get=0x03D57DA0  set=0x03D57DC0
  parentTarget  get=0x03D50E60  set=0x058B426C
  groupEnabled  get=0x09AC488C
METHODS:
  RVA=0x0398AF20  token=0x6000300  System.Void Start()
  RVA=0x09AC4680  token=0x6000301  System.Void Reset()
  RVA=0x0284F680  token=0x6000302  System.Void LateTick(System.Single deltaTime)
  RVA=0x036B97A0  token=0x6000303  System.Void OnEnable()
  RVA=0x036B9650  token=0x6000304  System.Void OnDisable()
  RVA=0x09AC447C  token=0x6000305  System.Void ChangeEnableCloseActionOnController(System.Boolean enabled)
  RVA=0x0284E7F0  token=0x6000306  System.Void CloseSelf()
  RVA=0x09AC473C  token=0x6000307  System.Void TryCloseSelf()
  RVA=0x09AC4590  token=0x6000308  System.Void OpenSelf(System.Boolean executeOnComplete)
  RVA=0x02850340  token=0x6000309  System.Boolean ShouldClose()
  RVA=0x03D4BEA0  token=0x600030A  System.Void ClearComponent()
  RVA=0x09AC47E8  token=0x600030B  System.Void _AutoCloseToggleObjWhenOut()
  RVA=0x036B9840  token=0x600030C  System.Void AddToAutoCloseLayer(UnityEngine.GameObject go)
  RVA=0x036B9700  token=0x600030D  System.Void RemoveFromAutoCloseLayer(UnityEngine.GameObject go)
  RVA=0x0284E520  token=0x600030E  System.Boolean IsTopAutoCloseLayer(UnityEngine.GameObject go)
  RVA=0x0284E660  token=0x600030F  UnityEngine.Camera _GetUICamera()
  RVA=0x0398AFC0  token=0x6000315  System.Void InitBinding()
  RVA=0x036B9920  token=0x6000316  System.Void _UpdateState()
  RVA=0x09AC44EC  token=0x6000317  System.Void OnDestroy()
  RVA=0x028493C0  token=0x6000318  System.Void .ctor()
  RVA=0x03CE07A0  token=0x6000319  System.Void .cctor()
  RVA=0x0589E548  token=0x600031A  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x058DD8AC  token=0x600031B  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x600031C  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x05F2CFD8  token=0x600031D  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIBigLogo
TYPE:  class
TOKEN: 0x2000075
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          _rootNode  // 0x18
  public            Beyond.UI.UIImage               _bigLogoImage  // 0x20
  private           UnityEngine.GameObject          _stretchNode  // 0x28
  public            Beyond.UI.UIImage               _stretchImageTop  // 0x30
  public            Beyond.UI.UIImage               _stretchImageBottom  // 0x38
  public            Beyond.UI.UIImage               _bg  // 0x40
  public            Beyond.UI.UIImage               _originalImage  // 0x48
  public            Beyond.UI.UIImage               _backgroundMask  // 0x50
  public            UnityEngine.CanvasGroup         _originalImageMain  // 0x58
METHODS:
  RVA=0x09AC4D4C  token=0x600031E  System.Void SetBigLogoEditor(System.String bigLogoPath, System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean hideBackground, System.Boolean useOriginalImage)
  RVA=0x09AC4FB0  token=0x600031F  System.Void ShowBigLogo(System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean useOriginalImage, System.Single originalImageScale)
  RVA=0x09AC4DD4  token=0x6000320  System.Void SetBigLogoMask(UnityEngine.Color maskColor)
  RVA=0x09AC4990  token=0x6000321  System.Void ClearBigLogoMask()
  RVA=0x09AC4A40  token=0x6000322  System.Void ClearBigLogo(System.Boolean showOnTop)
  RVA=0x09AC4B88  token=0x6000323  System.Void SetAlpha(System.Single alpha, System.Boolean showOnTop)
  RVA=0x09AC4EE8  token=0x6000324  System.Void SetMaskAlpha(System.Single alpha)
  RVA=0x0426FE60  token=0x6000325  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIBigRectButton
TYPE:  class
TOKEN: 0x2000076
SIZE:  0x2E0
EXTENDS: Beyond.UI.UIButton
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IScrollHandler
FIELDS:
  private           Beyond.UI.UIBigRectHelper       _bigRectHelper  // 0x2d8
METHODS:
  RVA=-1  // generic def  token=0x6000326  System.Void _TryThroughEventDataToBigRectTouchPanelRaycast(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> eventFunction)
  RVA=0x022C3B40  token=0x6000327  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x022C3AA0  token=0x6000328  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC5214  token=0x6000329  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC5170  token=0x600032A  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC52B8  token=0x600032B  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC535C  token=0x600032C  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02848630  token=0x600032D  System.Void .ctor()
  RVA=0x09AC5400  token=0x600032E  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AC5408  token=0x600032F  System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0)
END_CLASS

CLASS: Beyond.UI.UIBigRectHelper
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x1E8
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Boolean                  m_inited  // 0x68
  private           System.Boolean                  m_openTweenFinished  // 0x69
  private           Beyond.DisposedUnityEvent       m_onOpenTweenFinished  // 0x70
  private           System.Single                   m_zoom  // 0x78
  private           System.Single                   m_zoomValue  // 0x7c
  private           UnityEngine.Vector2             m_oriSize  // 0x80
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>m_zoomTween  // 0x88
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>m_focusTween  // 0x90
  private           UnityEngine.Vector2             m_anchoredPosOffset  // 0x98
  private           System.Single                   m_horizontalOffset  // 0xa0
  private           System.Single                   m_verticalOffset  // 0xa4
  private           UnityEngine.Vector2             m_lastScale  // 0xa8
  private           UnityEngine.Vector2             m_nodesOffsetWithContainerNode  // 0xb0
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0xb8
  private           UnityEngine.RectTransform       m_rootRectTransform  // 0xc0
  private           System.Single                   m_zoomRangeMin  // 0xc8
  private           System.Boolean                  m_useOverrideMinZoomRange  // 0xcc
  private           System.Single                   m_zoomRangeOverrideMin  // 0xd0
  private           Beyond.UI.UITouchPanel          _touchPanel  // 0xd8
  private           UnityEngine.RectTransform       _containerBigRectTransform  // 0xe0
  private           UnityEngine.RectTransform       _nodes  // 0xe8
  private           System.Single                   _moveSpeed  // 0xf0
  private           System.Single                   _zoomSpeed  // 0xf4
  private           System.Single                   _zoomRangeMax  // 0xf8
  private           System.Boolean                  _needResetPositionAndScale  // 0xfc
  private           System.Boolean                  _needCenterZoomMobile  // 0xfd
  private           System.Collections.Generic.List<System.Single>_zoomThresholds  // 0x100
  private           Beyond.DisposedUnityEvent<System.Int32,System.Boolean>m_zoomEvent  // 0x108
  private           System.Single                   _zoomTweenTime  // 0x110
  private           System.Single                   _moveNodeXOffset  // 0x114
  private           System.Single                   _moveNodeYOffset  // 0x118
  private           System.Single                   _openZoomTweenTime  // 0x11c
  private           UnityEngine.AnimationCurve      _openZoomCurve  // 0x120
  private           System.Single                   _focusNodeTime  // 0x128
  private           UnityEngine.AnimationCurve      _focusNodeCurve  // 0x130
  private           System.Boolean                  _containerEdgeAlignLeft  // 0x138
  private           UnityEngine.RectOffset          _padding  // 0x140
  private           System.Single                   _paddingBottomIncludeControllerHintBar  // 0x148
  private           System.Single                   _controllerContainerHorizontalMoveSpeed  // 0x14c
  private           System.Single                   _controllerContainerVerticalMoveSpeed  // 0x150
  private           System.Single                   _controllerZoomRate  // 0x154
  private           UnityEngine.GameObject          _controllerZoomKeyHint  // 0x158
  private           System.Boolean                  _useFocusRect  // 0x160
  private           System.Boolean                  _useClickKeyHint  // 0x161
  private           UnityEngine.Transform           _raycastRoot  // 0x168
  private           UnityEngine.RectTransform       _controllerFocusRect  // 0x170
  private           System.Single                   _controllerFocusRectHorizontalMoveSpeed  // 0x178
  private           System.Single                   _controllerFocusRectVerticalMoveSpeed  // 0x17c
  private           System.Single                   _controllerFocusLeftBoundPadding  // 0x180
  private           System.Single                   _controllerFocusRightBoundPadding  // 0x184
  private           System.Single                   _controllerFocusBottomBoundPadding  // 0x188
  private           System.Single                   _controllerFocusTopBoundPadding  // 0x18c
  private           UnityEngine.Vector2             m_lastStickValue  // 0x190
  private           UnityEngine.EventSystems.PointerEventDatam_controllerFocusEventData  // 0x198
  private   readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_raycastResults  // 0x1a0
  private           UnityEngine.UI.Selectable       m_lastHitSelectable  // 0x1a8
  private           System.Int32                    m_bindingGroupId  // 0x1b0
  private   static  System.String                   CLICK_ACTION_ID  // const
  private   static  System.String                   CLICK_NO_HINT_ACTION_ID  // const
  private   static  System.Single                   DELTA_TIME_TO_STICK_VALUE_RATIO  // const
  private           System.Int32                    <clickBindingId>k__BackingField  // 0x1b4
  private           System.Boolean                  <controllerMoveEnabled>k__BackingField  // 0x1b8
  private           System.Boolean                  <controllerZoomEnabled>k__BackingField  // 0x1b9
  public    readonly Beyond.DisposedUnityEvent       onControllerMoveStart  // 0x1c0
  public    readonly Beyond.DisposedUnityEvent       onControllerMoveStop  // 0x1c8
  public    readonly Beyond.DisposedUnityEvent       onControllerZoom  // 0x1d0
  public    readonly Beyond.DisposedUnityEvent       onControllerFocusEnterSelectable  // 0x1d8
  public    readonly Beyond.DisposedUnityEvent       onControllerFocusExitSelectable  // 0x1e0
PROPERTIES:
  tickOption  get=0x03D55740
  OnOpenTweenFinished  get=0x03D4EB30
  zoomRangeMin  get=0x022C4DD0
  zoomEvent  get=0x09AC66F8
  touchPanel  get=0x03D4E7B0
  clickBindingId  get=0x03D75FD0  set=0x03D75FE0
  controllerMoveEnabled  get=0x03D58E30  set=0x03D5B920
  controllerZoomEnabled  get=0x03D5DB70  set=0x03D75FF0
METHODS:
  RVA=0x02BDBF00  token=0x6000335  System.Void OnAwake()
  RVA=0x031EB0C0  token=0x6000336  System.Void Tick(System.Single deltaTime)
  RVA=0x022C4770  token=0x6000337  System.Void LateTick(System.Single deltaTime)
  RVA=0x03D46240  token=0x6000338  System.Void OnRelease()
  RVA=0x022C3DB0  token=0x6000339  System.Void _OnDrag(UnityEngine.Vector2 value)
  RVA=0x09AC5814  token=0x600033A  System.Void ManuallyZoom(System.Single value, System.Boolean needTween)
  RVA=0x09AC6478  token=0x600033B  System.Void _RefreshPivotPosition()
  RVA=0x09AC5CAC  token=0x600033C  System.Void _OnZoom(System.Single value, System.Boolean needTween)
  RVA=0x022C4A00  token=0x600033D  System.Void _SetZoomValueAndScale(System.Single value, System.Boolean needTween)
  RVA=0x022C4DF0  token=0x600033E  System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish)
  RVA=0x022C4470  token=0x600033F  System.Void _GetContainerRectBounds(UnityEngine.Vector2& leftBottom, UnityEngine.Vector2& rightTop)
  RVA=0x022C42A0  token=0x6000340  UnityEngine.Vector2 _GetAdjustedPosition(UnityEngine.Vector2 position)
  RVA=0x022C3E60  token=0x6000341  System.Void _PosAdjust()
  RVA=0x09AC6278  token=0x6000342  System.Void _RefreshPivotPositionToMousePosition()
  RVA=0x02F63400  token=0x6000343  System.Void _RefreshPivotPosition(UnityEngine.Vector3 targetScreenPosition)
  RVA=0x022C48F0  token=0x6000344  System.Void _UpdatePositionOffsetAfterZoomed()
  RVA=0x09AC6520  token=0x6000345  System.Void _TryAlignWhenInit()
  RVA=0x022C4B40  token=0x6000346  System.Void Init()
  RVA=0x09AC5598  token=0x6000347  System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete)
  RVA=0x022C3ED0  token=0x6000348  System.Void FocusNode(UnityEngine.RectTransform nodeRect, System.Boolean needTween, DG.Tweening.TweenCallback onComplete)
  RVA=0x09AC5A58  token=0x6000349  System.Void ZoomToFullRect(DG.Tweening.TweenCallback onComplete)
  RVA=0x09AC5410  token=0x600034A  System.Void ChangePaddingRight(System.Int32 right)
  RVA=0x03D4CE60  token=0x600034B  System.Void SetZoomRangeMax(System.Single maxValue)
  RVA=0x03D4CAC0  token=0x600034C  System.Void OverrideZoomRangeMin(System.Single minValue)
  RVA=0x022C4890  token=0x600034D  System.Void SyncZoomValue(System.Single zoomValue, System.Boolean needTween)
  RVA=0x09AC5798  token=0x600034E  System.Void GetZoomRange(System.Single& rangeMin, System.Single& rangeMax)
  RVA=0x09AC5748  token=0x600034F  System.Single GetCurrentZoomValue()
  RVA=0x09AC5484  token=0x6000350  System.Void ChangePivotPositionToTarget(UnityEngine.RectTransform target)
  RVA=0x02F63370  token=0x6000351  System.Void ResetPivotPositionToScreenCenter()
  RVA=0x03C79D70  token=0x6000352  System.Void ClearComponent()
  RVA=0x03C79E50  token=0x6000353  System.Void ClearAllTween()
  RVA=0x02BDBD60  token=0x600035A  System.Void _InitControllerBindings()
  RVA=0x031EB420  token=0x600035B  System.Boolean _GetIsControllerMoveEnabled()
  RVA=0x031EB280  token=0x600035C  System.Boolean _GetIsControllerZoomEnabled()
  RVA=0x022C3C70  token=0x600035D  System.Void _ResetControllerState()
  RVA=0x031EB110  token=0x600035E  System.Void _TickRefreshController(System.Single deltaTime)
  RVA=0x031EB300  token=0x600035F  System.Void _TickRefreshControllerStickMove(System.Single deltaTime)
  RVA=0x09AC5D38  token=0x6000360  System.Void _RefreshControllerFocusRaycastResults(System.Boolean ignoreTouchPanel, UnityEngine.UI.Selectable& hitSelectable, Beyond.UI.UITouchPanel& hitTouchPanel)
  RVA=0x022C47C0  token=0x6000361  System.Void _TickCheckControllerFocusRaycastTargets()
  RVA=0x09AC5AE0  token=0x6000362  System.Void _OnControllerClick()
  RVA=0x031EB170  token=0x6000363  System.Void _TickRefreshControllerStickZoom(System.Single deltaTime)
  RVA=0x031EB1D0  token=0x6000364  System.Void _TickRefreshControllerZoomKeyHint()
  RVA=0x02849F90  token=0x6000365  System.Void .ctor()
  RVA=0x022C3BE0  token=0x6000366  System.Void <OnAwake>b__62_0(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AC59B8  token=0x6000367  System.Void <OnAwake>b__62_1(System.Single zoomValue)
  RVA=0x09AC5A38  token=0x6000368  System.Void <_SetScale>b__71_0()
  RVA=0x09AC5890  token=0x6000369  System.Void <Init>b__79_0()
  RVA=0x058E2A30  token=0x600036A  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x600036B  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0589E548  token=0x600036C  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x0577D7B4  token=0x600036D  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIBlendImage
TYPE:  class
TOKEN: 0x2000079
SIZE:  0x238
EXTENDS: Beyond.UI.UIImage
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Material>s_materials  // static @ 0x0
  private           UnityEngine.Material            m_originalMaterial  // 0x228
  private           System.Boolean                  m_initialized  // 0x230
METHODS:
  RVA=0x09ACAE28  token=0x6000370  System.Void SetMaterialKey(System.String key)
  RVA=0x09ACAD84  token=0x6000371  System.Void SetColor(System.String materialId, UnityEngine.Color c)
  RVA=0x09ACB0B8  token=0x6000372  System.Void SetTexture(System.String materialId, UnityEngine.Texture t)
  RVA=0x03CE0710  token=0x6000373  System.Void ClearMaterialCache()
  RVA=0x09ACB144  token=0x6000374  System.Void .ctor()
  RVA=0x03CE2C50  token=0x6000375  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIBlurMono
TYPE:  class
TOKEN: 0x200007A
SIZE:  0x88
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.Canvas              m_canvas  // 0x68
  private           Beyond.UI.LuaPanel              m_panel  // 0x70
  private           System.Int32                    m_sortingOrder  // 0x78
  private           HG.Rendering.Runtime.HGCamera   m_camera  // 0x80
PROPERTIES:
  tickOption  get=0x03D55800
  canvas  get=0x02A728E0
  panel  get=0x02A727C0
METHODS:
  RVA=0x02A726C0  token=0x6000379  System.Void OnEnable()
  RVA=0x02A724F0  token=0x600037A  System.Void OnDisable()
  RVA=0x09ACB14C  token=0x600037B  System.Void Tick(System.Single deltaTime)
  RVA=0x09ACB258  token=0x600037C  System.Void UpdateSortingOrder(System.Int32 order)
  RVA=0x02A72550  token=0x600037D  HG.Rendering.Runtime.HGCamera _GetCamera()
  RVA=0x02846010  token=0x600037E  System.Void .ctor()
  RVA=0x058DD8AC  token=0x600037F  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x6000380  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0577D7BC  token=0x6000381  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIBlurRT
TYPE:  class
TOKEN: 0x200007B
SIZE:  0x58
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.UI.RawImage         _rawImage  // 0x18
  private           System.Boolean                  _autoUpdate  // 0x20
  private           HG.Rendering.Runtime.RTExtractionType_rtExtractionType  // 0x24
  private           HG.Rendering.Runtime.RTExtractionDuration_rtExtractionDuration  // 0x28
  private           UnityEngine.Rendering.RTHandle  m_rtHandle  // 0x30
  private           System.Boolean                  _needUseSceneColorPS  // 0x38
  private           UnityEngine.Rendering.RTHandle  m_useSceneColorPsRtHandle  // 0x40
  private           System.Boolean                  m_curIsUseSceneColorPS  // 0x48
  private           UnityEngine.Texture             <customBlurTexture>k__BackingField  // 0x50
PROPERTIES:
  rawImage  get=0x01041090
  customBlurTexture  get=0x03D4EAF0  set=0x02C926C0
METHODS:
  RVA=0x09ACB334  token=0x6000383  System.Void Reset()
  RVA=0x035ED100  token=0x6000384  System.Void InitRT()
  RVA=0x035ED4A0  token=0x6000385  System.Void Register()
  RVA=0x09ACB4DC  token=0x6000386  System.Void UnRegister()
  RVA=0x09ACB5BC  token=0x6000387  System.Void UpdateRT()
  RVA=0x035ECF30  token=0x6000388  System.Void OnEnable()
  RVA=0x035ECC10  token=0x6000389  System.Void OnDisable()
  RVA=0x09ACB2E4  token=0x600038A  System.Void OnDestroy()
  RVA=0x035ECC50  token=0x600038B  System.Void _Clear()
  RVA=0x0228DF90  token=0x600038C  System.Void SetUseSceneColorPS(System.Boolean useSceneColorPS, System.Boolean forceUpdate)
  RVA=0x09ACB3B4  token=0x600038F  System.Void SetCustomBlurImg(UnityEngine.Texture texture)
  RVA=0x03D1F3A0  token=0x6000390  System.Void .ctor()
  RVA=0x03CFE6D0  token=0x6000391  System.Void <Register>b__12_0()
END_CLASS

CLASS: Beyond.UI.UIButton
TYPE:  class
TOKEN: 0x200007C
SIZE:  0x2D8
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler Beyond.Input.IBindingGroupTarget Beyond.Input.IBindingView Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.String                   _audioPressStart  // 0x180
  private           System.String                   _audioOnClick  // 0x188
  private           System.String                   _audioRelease  // 0x190
  private           System.String                   _audioLongPress  // 0x198
  private           System.String                   _audioInvalid  // 0x1a0
  private           System.Boolean                  _noAudioWhenAutoTriggerOnClick  // 0x1a8
  private   static  System.Single                   MIN_DRAG_DIST  // const
  private   static  System.Single                   DOUBLE_CLICK_MAX_INTERVAL  // const
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onClick  // 0x1b0
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onDoubleClick  // 0x1b8
  public            System.Boolean                  _ignoreClickOnDrag  // 0x1c0
  public            System.Boolean                  _clickThrough  // 0x1c1
  private           System.Single                   _clickCd  // 0x1c4
  private           Beyond.LangKey                  _invalidClickLangKey  // 0x1c8
  private           System.Single                   m_lastValidClickTime  // 0x1d8
  private           System.Single                   m_lastClickTime  // 0x1dc
  private           System.Boolean                  _useClickAnimation  // 0x1e0
  private           UnityEngine.AnimationCurve      _clickAnimationCurve  // 0x1e8
  private           System.Single                   _clickAnimationDuration  // 0x1f0
  private           UnityEngine.Vector3             m_oriScale  // 0x1f4
  private           UnityEngine.Coroutine           m_clickCor  // 0x200
  private           System.Boolean                  m_scaled  // 0x208
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onLongPress  // 0x210
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onPressStart  // 0x218
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onPressEnd  // 0x220
  private           System.Single                   _longPressTime  // 0x228
  public            System.Boolean                  _ignoreClickOnLongPress  // 0x22c
  public            Beyond.UI.UIImage               longPressImg  // 0x230
  private           System.Single                   _longPressImgShowDelay  // 0x238
  private           System.Single                   _longPressMaxDragDist  // 0x23c
  private           System.Boolean                  _forceEnableButtonPressAudio  // 0x240
  private           System.Boolean                  m_pressDownWaitClick  // 0x241
  private           UnityEngine.Vector2             <startPressPos>k__BackingField  // 0x244
  private           System.Int32                    <pressTouchId>k__BackingField  // 0x24c
  private           UnityEngine.Coroutine           m_longPressCor  // 0x250
  private           System.Boolean                  m_triggeredLongPress  // 0x258
  public            System.Boolean                  noTextBtn  // 0x259
  private           Beyond.UI.UIText                m_autoFindLabel  // 0x260
  private           Beyond.UI.UIText                _label  // 0x268
  private           System.Int32                    m_groupId  // 0x270
  private           System.Boolean                  m_bindingInit  // 0x274
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x278
  private           System.String                   m_customBindingViewLabelText  // 0x280
  public            System.String                   hintTextId  // 0x288
  private   readonly Beyond.DisposedUnityEvent       <bindingViewUpdateEvent>k__BackingField  // 0x290
  private           UnityEngine.RectTransform       _redDotTrans  // 0x298
  private           System.String                   _audioGamePadLongPress  // 0x2a0
  private           Beyond.UI.LuaPanel              m_panel  // 0x2a8
  private           System.Int32                    m_hoverBindingGroupId  // 0x2b0
  public            System.String                   clickHintTextId  // 0x2b8
  public            System.String                   longPressHintTextId  // 0x2c0
  private           Beyond.Input.ActionOnSetNaviTarget_actionOnSetNaviTarget  // 0x2c8
  private           System.Boolean                  _useNoHintAction  // 0x2cc
  private           System.Int32                    <hoverConfirmBindingId>k__BackingField  // 0x2d0
PROPERTIES:
  startPressPos  get=0x03D76030  set=0x03D76070
  pressTouchId  get=0x03D76020  set=0x03D76060
  longPressTime  get=0x03D76010
  curPressPos  get=0x09ACBC8C
  triggeredLongPress  get=0x03D59820
  text  get=0x09ACBCE4  set=0x03822480
  label  get=0x03822590
  groupEnabled  get=0x033BE090
  groupId  get=0x022B0E50
  parentTarget  get=0x03D57270
  parent  get=0x03D57270  set=0x058B3EC0
  bindingViewActionId  get=0x03342280
  customBindingViewLabelText  get=0x03D573B0  set=0x03C8A840
  bindingViewLabelText  get=0x04272C90
  hintText  get=0x036AFB90
  bindingViewUpdateEvent  get=0x03D57040
  redDotTrans  get=0x03D57180
  bindingEnabled  get=0x09ACBC84
  bindingViewState  get=0x0251B0F0
  panel  get=0x0284D6C0
  hoverBindingGroupId  get=0x024B2330
  actionOnSetNaviTarget  get=0x03D76000
  hoverConfirmBindingId  get=0x02A18C40  set=0x03D76050
METHODS:
  RVA=0x02C70580  token=0x6000392  System.Void Awake()
  RVA=0x022B08B0  token=0x6000393  System.Void OnEnable()
  RVA=0x022B0780  token=0x6000394  System.Void OnDisable()
  RVA=0x02C71A00  token=0x6000395  System.Void OnDestroy()
  RVA=0x02C6F4F0  token=0x6000396  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x0284C860  token=0x6000397  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284D3E0  token=0x6000398  System.Void _Press(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284E470  token=0x6000399  System.Void _PlayClickAnimation(System.Boolean reverse)
  RVA=0x09ACB9D0  token=0x600039A  System.Collections.IEnumerator _DoClickAnimation()
  RVA=0x0284E1A0  token=0x60003A2  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284E0B0  token=0x60003A3  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284E3E0  token=0x60003A4  System.Collections.IEnumerator _OnPress(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x022B07F0  token=0x60003A5  System.Void _StopLongPressCor()
  RVA=0x02C71C50  token=0x60003A9  System.Void ClearComponent()
  RVA=0x022B0F30  token=0x60003AF  System.Void InitBinding()
  RVA=0x03CF0040  token=0x60003B0  System.Void OnInteractableChanged()
  RVA=0x022B0C40  token=0x60003B1  System.Void _UpdateState()
  RVA=0x03342200  token=0x60003BB  System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType)
  RVA=0x039D5E80  token=0x60003BC  System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger)
  RVA=0x03973430  token=0x60003BD  System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger)
  RVA=0x03544090  token=0x60003BE  System.Void _OnUpdateKey()
  RVA=0x03342360  token=0x60003BF  System.String _GetUIButtonKeyHintActionId(Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> buttonEvent)
  RVA=0x024B1F30  token=0x60003C2  System.Void _RefreshHoverEnableNode(System.Boolean active)
  RVA=0x09ACB79C  token=0x60003C3  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  RVA=0x09ACB82C  token=0x60003C4  System.Void OnNaviTargetEnabledAgain()
  RVA=0x09ACBA60  token=0x60003C6  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  RVA=0x02C6D420  token=0x60003C9  System.Void _InitActionOnSetNaviTarget()
  RVA=0x09ACBBEC  token=0x60003CA  System.Void _ToggleNaviInputBinding(System.Boolean active)
  RVA=0x09ACB6E0  token=0x60003CB  System.Void ChangeActionOnSetNaviTarget(Beyond.Input.ActionOnSetNaviTarget action)
  RVA=0x02848640  token=0x60003CC  System.Void .ctor()
  RVA=0x09ACB690  token=0x60003CD  System.Boolean Beyond.Input.IBindingView.get_interactable()
  RVA=0x0284B340  token=0x60003CE  System.Void <InitBinding>b__82_0()
  RVA=0x09ACB8BC  token=0x60003CF  System.Void <InitBinding>b__82_1()
  RVA=0x09ACB908  token=0x60003D0  System.Void <InitBinding>b__82_2()
  RVA=0x0284C7F0  token=0x60003D1  System.Void <InitBinding>b__82_3()
  RVA=0x0284C280  token=0x60003D2  System.Void <InitBinding>b__82_4()
  RVA=0x09ACB984  token=0x60003D3  System.Void <_InitActionOnSetNaviTarget>b__132_0()
  RVA=0x09ACB964  token=0x60003D4  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09ACB96C  token=0x60003D5  System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AAE8DC  token=0x60003D6  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AAE8EC  token=0x60003D7  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0361D5F0  token=0x60003D8  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AAE8E4  token=0x60003D9  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09ACB974  token=0x60003DA  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  RVA=0x0350B670  token=0x60003DB  System.Void <>iFixBaseProxy_OnInteractableChanged()
  RVA=0x09ACB97C  token=0x60003DC  System.Void <>iFixBaseProxy__RefreshHoverEnableNode(System.Boolean P0)
  RVA=0x09ACB954  token=0x60003DD  System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1)
  RVA=0x09ACB95C  token=0x60003DE  System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain()
  RVA=0x0350B670  token=0x60003DF  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.CanvasMatchMode
TYPE:  sealed struct
TOKEN: 0x200007F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CanvasMatchMode       Width  // const
  public    static  Beyond.UI.CanvasMatchMode       Height  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UICanvasScaleHelper
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x58
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: IScreenSizeListener Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Boolean                  _useCustomStandardResolution  // 0x18
  private           UnityEngine.Vector2             _customStandardResolution  // 0x1c
  private           System.Single                   _customPCReferenceResolutionScale  // 0x24
  private           System.Collections.Generic.HashSet<UnityEngine.Canvas>m_canvasList  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler>m_canvasScalerList  // 0x30
  private           System.Boolean                  m_isCanvasChanged  // 0x38
  public            System.Boolean                  isSingleCanvas  // 0x39
  public            UnityEngine.Camera              uiCamera  // 0x40
  public            Beyond.DisposedUnityEvent       onScreenSizeChanged  // 0x48
  public            Beyond.DisposedUnityEvent       onCanvasChanged  // 0x50
PROPERTIES:
  standardHorizontalResolution  get=0x027FF8D0
  standardVerticalResolution  get=0x027FF890
  standardResolutionScale  get=0x027FF910
  canvasScalerList  get=0x09ACBFCC
METHODS:
  RVA=0x0380FB70  token=0x60003F0  System.Void Awake()
  RVA=0x0380FBB0  token=0x60003F1  System.Void _OnInit()
  RVA=0x02CD1A00  token=0x60003F2  System.Void Start()
  RVA=0x02CD0FE0  token=0x60003F3  System.Void OnDestroy()
  RVA=0x028A9E10  token=0x60003F4  System.Void UpdateCanvas()
  RVA=0x02CD18F0  token=0x60003F5  System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height)
  RVA=0x027FF710  token=0x60003F6  System.Void AddCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s)
  RVA=0x0397EA50  token=0x60003F7  System.Void RemoveCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s)
  RVA=0x09ACBE18  token=0x60003F8  System.Void _OnInputTypeChanged()
  RVA=0x03079A10  token=0x60003F9  System.Void _CanvasOnWillRenderCanvases()
  RVA=0x028AAB40  token=0x60003FA  Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams CalcWorldCanvasParams(UnityEngine.Camera camera, UnityEngine.Transform uiRoot, System.Boolean useLocalPos)
  RVA=0x028AC370  token=0x60003FB  Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams CalcScreenCanvasParams()
  RVA=0x028AC5A0  token=0x60003FC  System.Single CalcCurrentScreenRatio(UnityEngine.Vector2& screenSize)
  RVA=0x027FF820  token=0x60003FD  UnityEngine.Vector2 GetProperCanvasResolution()
  RVA=0x09ACBDBC  token=0x60003FE  System.Void ForceCanvasUpdate()
  RVA=0x02CD0D20  token=0x60003FF  System.Void ClearComponent()
  RVA=0x02847080  token=0x6000400  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIColorGroup
TYPE:  class
TOKEN: 0x2000083
SIZE:  0xE0
EXTENDS: Beyond.UI.NonDrawingGraphic
FIELDS:
  private           UnityEngine.UI.Graphic[]        _colorElements  // 0xb8
  private           UnityEngine.Color               _color  // 0xc0
  private           System.Boolean                  m_isOperating  // 0xd0
  private           System.Collections.Generic.List<Beyond.UI.UIColorGroup.DynEle>m_dynList  // 0xd8
PROPERTIES:
  color  get=0x03D6C030  set=0x09ACCA9C
METHODS:
  RVA=0x09ACC01C  token=0x6000403  System.Void AttachGraphic(UnityEngine.UI.Graphic graphic, System.Boolean useStaticColor)
  RVA=0x09ACC27C  token=0x6000404  System.Void AttachGraphicsWithGroup(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphic, System.String groupId)
  RVA=0x09ACC598  token=0x6000405  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x09ACC6B4  token=0x6000406  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB)
  RVA=0x036F87F0  token=0x6000407  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  RVA=0x036F8980  token=0x6000408  System.Void _ApplyOptToGraphics(Beyond.UI.UIColorGroup.GraphicOpt opt, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x09ACC890  token=0x6000409  System.Void _CrossFadeAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x09ACC924  token=0x600040A  System.Void _CrossFadeColorRGB(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x038C6D30  token=0x600040B  System.Void _CrossFadeColorAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x09ACCA00  token=0x600040C  System.Void _SetColor(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  RVA=0x027006E0  token=0x600040D  System.Void .ctor()
  RVA=0x09ACC870  token=0x600040E  System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0)
  RVA=0x09ACC7F4  token=0x600040F  System.Void <>iFixBaseProxy_CrossFadeAlpha(System.Single P0, System.Single P1, System.Boolean P2)
  RVA=0x09ACC834  token=0x6000410  System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  RVA=0x09ACC804  token=0x6000411  System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3)
END_CLASS

CLASS: Beyond.UI.UIControllerKeyIcon
TYPE:  class
TOKEN: 0x2000087
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.String                   _keyIconName  // 0x18
  private           Beyond.UI.UIImage               m_image  // 0x20
  private   static  System.Collections.Generic.List<Beyond.UI.UIControllerKeyIcon>s_iconCache  // static @ 0x0
  private   static  System.Boolean                  s_initialized  // static @ 0x8
METHODS:
  RVA=0x09ACD0B4  token=0x6000416  System.Void _TryStaticInit()
  RVA=0x09ACCF18  token=0x6000417  System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType)
  RVA=0x09ACCBA4  token=0x6000418  System.Void Awake()
  RVA=0x09ACCCF4  token=0x6000419  System.Void OnEnable()
  RVA=0x09ACCC50  token=0x600041A  System.Void OnDisable()
  RVA=0x09ACCE7C  token=0x600041B  System.Void SetKeyIconName(Beyond.Input.GamepadKeyCode keyCode)
  RVA=0x09ACCDA0  token=0x600041C  System.Void RefreshKeyIcon()
  RVA=0x0426FE60  token=0x600041D  System.Void .ctor()
  RVA=0x03CBCD70  token=0x600041E  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UICustomLayout
TYPE:  class
TOKEN: 0x2000088
SIZE:  0x30
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _dragArea  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.UICustomLayoutHandle>layoutHandles  // 0x20
  private           ZSimpleJSON.JSONArray           m_eventLog  // 0x28
PROPERTIES:
  dragArea  get=0x01041090
METHODS:
  RVA=0x09ACF448  token=0x6000420  System.Void Awake()
  RVA=0x09ACF590  token=0x6000421  System.Boolean IsDirty()
  RVA=0x09ACF6EC  token=0x6000422  System.Void ResetToDefault(System.Boolean saveChanges)
  RVA=0x09ACF878  token=0x6000423  System.Void Save(System.Int32 ratio)
  RVA=0x09ACFB28  token=0x6000424  System.Void _LogEvent(System.Collections.Generic.Dictionary<Beyond.UI.UICustomLayoutElement,Beyond.UI.UICustomLayoutElement.LayoutData> layoutDataMap)
  RVA=0x09AD0058  token=0x6000425  System.Void .ctor()
  RVA=0x0350B670  token=0x6000426  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UICustomLayoutElement
TYPE:  class
TOKEN: 0x2000089
SIZE:  0x80
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Int32                    _verNum  // 0x18
  private           System.String                   _elementKey  // 0x20
  private           UnityEngine.Transform           _overrideScaleTransform  // 0x28
  private           UnityEngine.CanvasGroup         _overrideCanvasGroup  // 0x30
  private           UnityEngine.RectTransform       _overrideHighlightRect  // 0x38
  public            Beyond.DisposedUnityEvent       onLayoutDataLoaded  // 0x40
  private           Beyond.UI.LuaPanel              m_panel  // 0x48
  private           System.Single                   m_scale  // 0x50
  private           System.Single                   m_alpha  // 0x54
  private           UnityEngine.Vector2             m_position  // 0x58
  private           Beyond.UI.UICustomLayoutElement.LayoutTypem_layoutType  // 0x60
  private           System.Single                   m_defaultScale  // 0x64
  private           System.Single                   m_defaultAlpha  // 0x68
  private           UnityEngine.Vector2             m_defaultPosition  // 0x6c
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
PROPERTIES:
  elementKey  get=0x03D4EB40
  highlightRect  get=0x09ACDD68
  scale  get=0x03D51C90  set=0x09ACDE18
  alpha  get=0x03D4F670  set=0x09ACDE00
  position  get=0x03D72FD0  set=0x09ACDE0C
  layoutType  get=0x03D4F050  set=0x03D4F5A0
  panel  get=0x027FCBB0
METHODS:
  RVA=0x027FC130  token=0x6000432  System.Void Awake()
  RVA=0x03A21200  token=0x6000433  System.Void Start()
  RVA=0x09ACD5C0  token=0x6000434  System.Void OnDestroy()
  RVA=0x09ACD748  token=0x6000435  System.Void ResetToDefault()
  RVA=0x09ACDAD4  token=0x6000436  System.Void _ApplyPosition()
  RVA=0x09ACD9F0  token=0x6000437  System.Void _ApplyAlpha()
  RVA=0x09ACDB40  token=0x6000438  System.Void _ApplyScale()
  RVA=0x027FC260  token=0x6000439  System.Void _SetDefaultValues()
  RVA=0x09ACD294  token=0x600043A  System.String GetElementKeyWithRatio(System.Int32 ratio)
  RVA=0x09ACDC14  token=0x600043B  System.Boolean _CheckElementKeyIsValid()
  RVA=0x09ACD810  token=0x600043C  System.Boolean SaveData(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Boolean isResetToDefault, System.Int32 ratio)
  RVA=0x09ACD370  token=0x600043D  System.Void LoadData()
  RVA=0x09ACDD18  token=0x600043E  System.Void _OnHudLayoutSaved()
  RVA=0x027FCA90  token=0x600043F  UnityEngine.Vector2 _GetMarginSize()
  RVA=0x09ACD23C  token=0x6000440  System.Void ClearComponent()
  RVA=0x09ACD6B4  token=0x6000441  System.Void RefreshAll()
  RVA=0x02849790  token=0x6000442  System.Void .ctor()
  RVA=0x0350B670  token=0x6000443  System.Void <>iFixBaseProxy_Awake()
  RVA=0x0350B670  token=0x6000444  System.Void <>iFixBaseProxy_Start()
  RVA=0x0350B670  token=0x6000445  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UICustomLayoutHandle
TYPE:  class
TOKEN: 0x200008C
SIZE:  0xB8
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public            Beyond.DisposedUnityEvent       onClick  // 0x18
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x28
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x30
  public            System.String                   hintTextId  // 0x38
  private           Beyond.UI.LuaPanel              m_panel  // 0x40
  private           System.Single                   m_scale  // 0x48
  private           System.Single                   m_alpha  // 0x4c
  private           UnityEngine.Vector2             m_position  // 0x50
  private           Beyond.UI.UICustomLayoutElement.LayoutTypem_layoutType  // 0x58
  private           UnityEngine.Vector2             m_defaultPosition  // 0x5c
  private           System.Boolean                  m_isChanged  // 0x64
  private           System.Boolean                  m_isResetToDefault  // 0x65
  private           UnityEngine.RectTransform       m_rectTransform  // 0x68
  private           UnityEngine.RectTransform       m_parentRectTransform  // 0x70
  private           Beyond.UI.UICustomLayoutElement m_element  // 0x78
  private           Beyond.UI.UICustomLayout        m_layout  // 0x80
  private           UnityEngine.Vector2             m_dragPosMin  // 0x88
  private           UnityEngine.Vector2             m_dragPosMax  // 0x90
  private           UnityEngine.Vector3[]           m_dragAreaCorners  // 0x98
  private           UnityEngine.Vector3[]           m_highlightCorners  // 0xa0
  private           System.Boolean                  m_isPosRangeDirty  // 0xa8
  private           UnityEngine.Vector2             m_dragOffset  // 0xac
PROPERTIES:
  scale  get=0x03D58370  set=0x09ACF3B4
  alpha  get=0x03D50200  set=0x09ACF1D0
  position  get=0x03D76080  set=0x09ACF2D4
  layoutType  get=0x03D4EF00  set=0x09ACF244
  panel  get=0x09ACF118
  Element  get=0x09ACF064
METHODS:
  RVA=0x09ACDE24  token=0x6000451  System.Void Awake()
  RVA=0x09ACE288  token=0x6000452  System.Void OnDestroy()
  RVA=0x09ACED28  token=0x6000453  System.Void _OnElementDataLoaded()
  RVA=0x09ACE98C  token=0x6000454  System.Void _CalculatePositionRange()
  RVA=0x09ACE8A8  token=0x6000455  System.Void _ApplyPosition()
  RVA=0x09ACE7DC  token=0x6000456  System.Void _ApplyAlpha()
  RVA=0x09ACE91C  token=0x6000457  System.Void _ApplyScale()
  RVA=0x09ACE844  token=0x6000458  System.Void _ApplyLayoutType()
  RVA=0x09ACE130  token=0x6000459  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ACE3EC  token=0x600045A  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ACE538  token=0x600045B  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ACE70C  token=0x600045C  System.Boolean Save(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Int32 ratio)
  RVA=0x09ACE62C  token=0x600045D  System.Void ResetToDefault()
  RVA=0x09ACE0E4  token=0x600045E  System.Boolean IsDirty()
  RVA=0x09ACEE24  token=0x600045F  System.Void _SetChanged(System.Boolean changed)
  RVA=0x09ACE5C4  token=0x6000460  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ACEDD4  token=0x6000461  System.Void _OnSystemDisplaySizeChanged()
  RVA=0x09ACE030  token=0x6000462  System.Void ClearComponent()
  RVA=0x09ACEED4  token=0x6000463  System.Void .ctor()
  RVA=0x0350B670  token=0x6000464  System.Void <>iFixBaseProxy_Awake()
  RVA=0x0350B670  token=0x6000465  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIDialogText
TYPE:  class
TOKEN: 0x200008D
SIZE:  0xE8
EXTENDS: Beyond.TickableUIMono
FIELDS:
  protected         Beyond.UI.UIText                _uiText  // 0x68
  private           System.Single                   _textRevealSpeed  // 0x70
  private           System.Boolean                  _autoPlay  // 0x74
  private           Beyond.UI.UIDialogText.UpdateMode_updateMode  // 0x78
  private           System.Boolean                  _useAutoScroll  // 0x7c
  private           System.Single                   _originalHeight  // 0x80
  private           System.Boolean                  _useAspectRatio  // 0x84
  private           System.Single                   _autoScrollSpeed  // 0x88
  private           System.Single                   _autoWaitTime  // 0x8c
  private           System.Single                   _maxAspectRatio  // 0x90
  private           System.Single                   _minAspectRatio  // 0x94
  private           System.Single                   _maxAspectRatioScrollSpeed  // 0x98
  private           System.Single                   _minAspectRatioScrollSpeed  // 0x9c
  private           System.Single                   _maxAspectRatioWaitTime  // 0xa0
  private           System.Single                   _minAspectRatioWaitTime  // 0xa4
  private           System.Boolean                  m_playing  // 0xa8
  private           System.Int32                    m_revealedCharNum  // 0xac
  private           System.Int32                    m_totalCharNum  // 0xb0
  private           System.Single                   m_timeToNextCharacter  // 0xb4
  protected         System.String                   m_curText  // 0xb8
  private           System.Boolean                  m_hasScrolled  // 0xc0
  private           System.Single                   m_startTime  // 0xc4
  private           System.Boolean                  m_scrollHasEnd  // 0xc8
  private           System.Boolean                  m_needAutoScroll  // 0xc9
  private           UnityEngine.Vector2             m_targetPos  // 0xcc
  private           UnityEngine.Vector2             m_originalPos  // 0xd4
  private           System.Single                   m_percent  // 0xdc
  private           System.Boolean                  m_locked  // 0xe0
PROPERTIES:
  tickOption  get=0x03D55800
  useAspectRatio  get=0x09AD0D48
  notUseAspectRatio  get=0x09AD0CC4
  playing  get=0x09AD0CD8
  uiText  get=0x03D4EAB0
  totalCharacterNum  get=0x03D59C80
  textRevealSpeed  get=0x03D56C00  set=0x03D5BD20
METHODS:
  RVA=0x03D2AB30  token=0x600046E  System.Void OnAwake()
  RVA=0x0398ECD0  token=0x600046F  System.Void Start()
  RVA=0x09AD0AD0  token=0x6000470  System.Void OnDisable()
  RVA=0x03CF4E80  token=0x6000471  System.Void OnEnable()
  RVA=0x02A35AA0  token=0x6000472  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD0B28  token=0x6000473  System.Void OnVisibleCharactersChanged(System.Int32 count)
  RVA=0x09AD06B0  token=0x6000474  System.Single GetScrollSpeed()
  RVA=0x09AD051C  token=0x6000475  System.Single GetAutoWaitTime()
  RVA=0x02A35B00  token=0x6000476  System.Void _UpdateTextAuto()
  RVA=0x02A35C10  token=0x6000477  System.Void _TryAutoScroll()
  RVA=0x0398EED0  token=0x6000478  System.Void RefreshAutoScrollData()
  RVA=0x0398EDF0  token=0x6000479  System.Void SetText(System.String text, System.Boolean resetPlay)
  RVA=0x09AD0C18  token=0x600047A  System.Void _RefreshPosY()
  RVA=0x09AD0B7C  token=0x600047B  System.Void SeekToEnd()
  RVA=0x03CF4EC0  token=0x600047C  System.Void RefreshText()
  RVA=0x0398ED80  token=0x600047D  System.Void Play()
  RVA=0x03B3CDB0  token=0x600047E  System.Void ResetPlay()
  RVA=0x02A35C80  token=0x600047F  System.Void StopPlay()
  RVA=0x09AD0794  token=0x6000480  System.Void ManualUpdateByPercent(System.Single percent)
  RVA=0x09AD08E0  token=0x6000481  System.Void ManualUpdateByTime(System.Single time)
  RVA=0x09AD0600  token=0x6000482  System.Single GetDisplayAllCharactersTime()
  RVA=0x03A20AC0  token=0x6000483  System.Void .ctor()
  RVA=0x058E2A30  token=0x6000484  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8A4  token=0x6000485  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x058DD8AC  token=0x6000486  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x6000487  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIDialogTextWithCursor
TYPE:  class
TOKEN: 0x200008F
SIZE:  0x118
EXTENDS: Beyond.UI.UIDialogText
FIELDS:
  private           System.Single                   _textGapTime  // 0xe8
  private           Beyond.UI.UIAnimationWrapper    _cursorAnimation  // 0xf0
  private           UnityEngine.RectTransform       _cursorLoopHide  // 0xf8
  private           UnityEngine.RectTransform       _cursorGroup  // 0x100
  private           Beyond.UI.UIImage               _background  // 0x108
  public            System.Boolean                  isLastTextLine  // 0x110
  private           System.Int32                    m_lastCount  // 0x114
METHODS:
  RVA=0x09AD0490  token=0x6000488  System.Void ResetPlay()
  RVA=0x09AD016C  token=0x6000489  System.Void OnVisibleCharactersChanged(System.Int32 count)
  RVA=0x09AD0110  token=0x600048A  System.Single GetDisplayAllCharactersTime()
  RVA=0x09AD0500  token=0x600048B  System.Void .ctor()
  RVA=0x09AD04F8  token=0x600048C  System.Void <>iFixBaseProxy_ResetPlay()
  RVA=0x09AD04F0  token=0x600048D  System.Void <>iFixBaseProxy_OnVisibleCharactersChanged(System.Int32 P0)
  RVA=0x09AD04E8  token=0x600048E  System.Single <>iFixBaseProxy_GetDisplayAllCharactersTime()
END_CLASS

CLASS: Beyond.UI.EasyUIOptionData
TYPE:  class
TOKEN: 0x2000090
SIZE:  0x28
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.String                   optionIcon  // 0x18
  public            System.String                   optionText  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600048F  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDialogTimelineOptionCell
TYPE:  class
TOKEN: 0x2000091
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIImage               _optionIcon  // 0x18
  private           Beyond.UI.UIText                _optionText  // 0x20
METHODS:
  RVA=0x0426FE60  token=0x6000490  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDialogTimelineText
TYPE:  class
TOKEN: 0x2000092
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIDialogText          _dialogText  // 0x18
  private           Beyond.UI.UIText                _actorName  // 0x20
  private           UnityEngine.GameObject          _waitNode  // 0x28
  private           Beyond.UI.UIAnimationWrapper    _radioNode  // 0x30
  private           Beyond.UI.UIImage               _iconImage  // 0x38
  private           Beyond.UI.UIImage               _iconBlueMask  // 0x40
  public            Beyond.UI.UIText                centerText  // 0x48
  private           System.String                   m_currentRadioIcon  // 0x50
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x58
PROPERTIES:
  canvasGroup  get=0x09AD10A0
  dialogText  get=0x01041090
  actorName  get=0x03D4EB40
  waitNode  get=0x03D4EAC0
METHODS:
  RVA=0x09AD0ED4  token=0x6000495  System.Void UpdateAlpha(System.Single alpha)
  RVA=0x09AD0D5C  token=0x6000496  System.Void SetRadioIcon(System.Boolean useRadio, System.String radioIcon)
  RVA=0x09AD0F94  token=0x6000497  System.Void _ClearRadioIcon()
  RVA=0x0426FE60  token=0x6000498  System.Void .ctor()
  RVA=0x09AD0E90  token=0x6000499  System.Void <_ClearRadioIcon>b__19_0()
END_CLASS

CLASS: Beyond.UI.UIDrag
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x70
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           UnityEngine.RectTransform       _dragArea  // 0x18
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x28
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x30
  private           UnityEngine.RectTransform       m_rectTransform  // 0x38
  private           UnityEngine.RectTransform       m_parentRectTransform  // 0x40
  private           UnityEngine.Vector2             m_dragOffset  // 0x48
  private           UnityEngine.Vector2             m_dragPosMin  // 0x50
  private           UnityEngine.Vector2             m_dragPosMax  // 0x58
  private           UnityEngine.Vector3[]           m_dragAreaCorners  // 0x60
  private           UnityEngine.Canvas              m_canvas  // 0x68
METHODS:
  RVA=0x09AD26C4  token=0x600049A  System.Void Awake()
  RVA=0x09AD2CFC  token=0x600049B  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD2860  token=0x600049C  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD2F00  token=0x600049D  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD2284  token=0x600049E  System.Void ApplyDragArea()
  RVA=0x09AD27BC  token=0x600049F  System.Void ClearComponent()
  RVA=0x09AD2F8C  token=0x60004A0  System.Void .ctor()
  RVA=0x0350B670  token=0x60004A1  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UIDragHandler
TYPE:  class
TOKEN: 0x2000094
SIZE:  0x50
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Int32                    _dragThreshold  // 0x18
  private           UnityEngine.Vector2             m_startPressPos  // 0x1c
  private           System.Boolean                  m_isDragThresholdMet  // 0x24
  private           System.Boolean                  m_isDragging  // 0x25
  public            Beyond.UI.UIButton              button  // 0x28
  public            System.Boolean                  ignoreDragOnLongPress  // 0x30
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x38
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x40
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x48
PROPERTIES:
  dragThreshold  get=0x09AD14D8
METHODS:
  RVA=0x09AD1130  token=0x60004A3  System.Void ClearComponent()
  RVA=0x09AD1464  token=0x60004A4  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD11D4  token=0x60004A5  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD1268  token=0x60004A6  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD13D0  token=0x60004A7  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x028472A0  token=0x60004A8  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDragItem
TYPE:  class
TOKEN: 0x2000095
SIZE:  0xC8
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public    static  UnityEngine.RectTransform       s_commonDragObjectParent  // static @ 0x0
  private           XLua.LuaTable                   <luaTable>k__BackingField  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDragEvent  // 0x20
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDragEvent  // 0x28
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDragEventWhenCantStartDrag  // 0x30
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDragEvent  // 0x38
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,UnityEngine.GameObject>onUpdateDragObject  // 0x40
  public            System.Boolean                  canStartDrag  // 0x48
  private           System.Boolean                  _endDragOnDisable  // 0x49
  public            System.Boolean                  disableDrag  // 0x4a
  private           System.Boolean                  _isInScrollList  // 0x4b
  private           System.Boolean                  _hideDragObjectInScrollList  // 0x4c
  private           UnityEngine.GameObject          _dragPrefab  // 0x50
  private           UnityEngine.RectTransform       _dragObjectParent  // 0x58
  public            UnityEngine.Vector2             dragPivot  // 0x60
  private           UnityEngine.UI.Image            _draggingHintImage  // 0x68
  private           UnityEngine.CanvasGroup         _draggingHintCanvasGroup  // 0x70
  private           UnityEngine.GameObject          _draggingHintObject  // 0x78
  private           Beyond.UI.LuaPanel              m_panel  // 0x80
  private           UnityEngine.RectTransform       m_rect  // 0x88
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x90
  private           System.Boolean                  m_isInScroll  // 0x98
  private           UnityEngine.GameObject          m_curDragObj  // 0xa0
  private           System.Boolean                  m_inDragging  // 0xa8
  private           UnityEngine.Color               m_draggingHintImageOriColor  // 0xac
  private           UnityEngine.Coroutine           m_dragOnDisableCoroutine  // 0xc0
PROPERTIES:
  luaTable  get=0x01041090  set=0x022C3A90
  inDragging  get=0x011B9C10
  panel  get=0x09AD21C0
  m_dragParentRect  get=0x09AD2110
  curDragObj  get=0x03D4EA80
METHODS:
  RVA=0x0388F250  token=0x60004AF  System.Void Awake()
  RVA=0x037B10F0  token=0x60004B0  System.Void Start()
  RVA=0x036EE670  token=0x60004B1  System.Void OnDisable()
  RVA=0x09AD1ED8  token=0x60004B2  System.Collections.IEnumerator _ContinueDragOnDisable()
  RVA=0x09AD1B20  token=0x60004B3  System.Void OnDestroy()
  RVA=0x0388DA70  token=0x60004B4  System.Void OnEnable()
  RVA=0x09AD15C0  token=0x60004B5  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD1B80  token=0x60004B6  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x036EE6E0  token=0x60004B7  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD1F68  token=0x60004B8  System.Void _StopDragView()
  RVA=0x09AD1520  token=0x60004B9  System.Void ClearComponent()
  RVA=0x02C712E0  token=0x60004BA  System.Void ClearEvents()
  RVA=0x02848DD0  token=0x60004BB  System.Void .ctor()
  RVA=0x0350B670  token=0x60004BC  System.Void <>iFixBaseProxy_Awake()
  RVA=0x0350B670  token=0x60004BD  System.Void <>iFixBaseProxy_Start()
  RVA=0x0350B670  token=0x60004BE  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0350B670  token=0x60004BF  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x0350B670  token=0x60004C0  System.Void <>iFixBaseProxy_OnEnable()
END_CLASS

CLASS: Beyond.UI.UIDropdown
TYPE:  class
TOKEN: 0x2000097
SIZE:  0x288
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp Beyond.Input.IBindingGroupTarget Beyond.Input.IBindingView
FIELDS:
  public            UnityEngine.Events.UnityEvent<System.Int32>onSelectCell  // 0x180
  public            UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean>onUpdateCell  // 0x188
  public            UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdown>onUpdateCaption  // 0x190
  public            UnityEngine.Events.UnityEvent<System.Boolean>onToggleOptList  // 0x198
  public            System.Func<System.Int32,System.Int32,System.Boolean>onValidateSelectCell  // 0x1a0
  public            Beyond.UI.UIText                captionText  // 0x1a8
  public            Beyond.UI.UIImage               captionIcon  // 0x1b0
  private           System.Int32                    <selectedIndex>k__BackingField  // 0x1b8
  private           System.Int32                    <optionCount>k__BackingField  // 0x1bc
  private           System.Boolean                  <isListActive>k__BackingField  // 0x1c0
  private           Beyond.UI.UIDropdownOption      _optionTemplate  // 0x1c8
  private           UnityEngine.Transform           _arrowImageTrans  // 0x1d0
  private           UnityEngine.RectTransform       _listContainer  // 0x1d8
  private           System.Single                   _listContainerMaxHeight  // 0x1e0
  private           System.Single                   _animationTime  // 0x1e4
  private           UnityEngine.RectTransform       _selfArea  // 0x1e8
  private           UnityEngine.RectTransform       _maskRect  // 0x1f0
  private           System.Boolean                  _autoCloseOnSelect  // 0x1f8
  private           System.String                   _audioToggleOn  // 0x200
  private           System.String                   _audioToggleOff  // 0x208
  private           System.String                   _audioInvalid  // 0x210
  private           System.String                   _audioNavigation  // 0x218
  private           System.Collections.Generic.List<Beyond.UI.UIDropdownOption>m_options  // 0x220
  private           Beyond.UI.LuaPanel              m_panel  // 0x228
  private           UnityEngine.UI.LayoutGroup      m_content  // 0x230
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x238
  private           Beyond.UI.UIScrollRect          m_listScrollRect  // 0x240
  private           UnityEngine.CanvasGroup         m_listContainerCanvasGroup  // 0x248
  public            System.String                   openDropDownActionId  // 0x250
  public            System.String                   openDropDownBindingTextId  // 0x258
  private           System.Int32                    m_bindingGroupId  // 0x260
  private           System.Int32                    m_naviBindingGroupId  // 0x264
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0x268
  private           Beyond.UI.UISelectableNaviGroup m_listNaviGroup  // 0x270
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0x278
  private   readonly Beyond.DisposedUnityEvent       <bindingViewUpdateEvent>k__BackingField  // 0x280
PROPERTIES:
  selectedIndex  get=0x03D58520  set=0x03D58620
  optionCount  get=0x03D58580  set=0x03D58630
  isListActive  get=0x03D57BF0  set=0x03D760A0
  panel  get=0x0284ECA0
  groupId  get=0x03D5ADD0
  parentTarget  get=0x03D57270  set=0x058B3EC0
  groupEnabled  get=0x09AD36D0
  bindingViewActionId  get=0x03D57350
  bindingViewLabelText  get=0x09AD3554
  bindingViewUpdateEvent  get=0x03D573B0
  redDotTrans  get=0x01002730
  bindingEnabled  get=0x09AD354C
  bindingViewState  get=0x09AD35EC
METHODS:
  RVA=0x02A71E60  token=0x60004CE  System.Void Awake()
  RVA=0x03989990  token=0x60004CF  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x02D99F90  token=0x60004D0  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03C9B180  token=0x60004D1  System.Void Init(UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell, UnityEngine.Events.UnityAction<System.Int32> onSelectCell, UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption)
  RVA=0x02D9A040  token=0x60004D2  System.Void ToggleOptions(System.Boolean activeList)
  RVA=0x02D9A090  token=0x60004D3  System.Void _ToggleOptions(System.Boolean activeList, System.Boolean isInit)
  RVA=0x0284F410  token=0x60004D4  System.Void Update()
  RVA=0x02D9A5A0  token=0x60004D5  System.Void SetSelected(System.Int32 index, System.Boolean forceUpdate, System.Boolean needNotifySelect, System.Boolean validateSelect)
  RVA=0x09AD3250  token=0x60004D6  System.Void ScrollToSelected()
  RVA=0x0270F0C0  token=0x60004D7  System.Void Refresh(System.Int32 count, System.Int32 newSelectedIndex, System.Boolean needNotifySelect)
  RVA=0x03A46E40  token=0x60004D8  System.Void ClearComponent()
  RVA=0x0284EB10  token=0x60004D9  UnityEngine.Camera _GetUICamera()
  RVA=0x09AD3194  token=0x60004E4  System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType)
  RVA=0x09AD309C  token=0x60004E5  System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger)
  RVA=0x09AD30F0  token=0x60004E6  System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger)
  RVA=0x02A73B40  token=0x60004E7  System.Void _InitBinding()
  RVA=0x09AD33F8  token=0x60004E8  System.Void _ControllerToggle()
  RVA=0x09AD338C  token=0x60004E9  System.Void _ControllerCancel()
  RVA=0x09AD3470  token=0x60004EA  UnityEngine.UI.Selectable _GetDefaultNaviTarget()
  RVA=0x03B38150  token=0x60004EB  System.Void OnEnable()
  RVA=0x03B381E0  token=0x60004EC  System.Void OnDisable()
  RVA=0x03A46DA0  token=0x60004ED  System.Void OnDestroy()
  RVA=0x0284A270  token=0x60004EE  System.Void .ctor()
  RVA=0x09AD3144  token=0x60004EF  System.Boolean Beyond.Input.IBindingView.get_interactable()
  RVA=0x09AAE8DC  token=0x60004F0  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09ACB974  token=0x60004F1  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  RVA=0x09AAE8EC  token=0x60004F2  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0361D5F0  token=0x60004F3  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AAE8E4  token=0x60004F4  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIDropdownOption
TYPE:  class
TOKEN: 0x200009A
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.UI.UIButton              button  // 0x18
  public            Beyond.UI.UIText                label  // 0x20
  public            Beyond.UI.UIText                secondLabel  // 0x28
  public            Beyond.UI.UIImage               icon  // 0x30
  public            UnityEngine.GameObject          selectedNode  // 0x38
  public            UnityEngine.GameObject          notSelectedNode  // 0x40
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0x48
  public            UnityEngine.GameObject          stripeNode  // 0x50
  public            System.Boolean                  stripeIsTop  // 0x58
METHODS:
  RVA=0x028E1380  token=0x60004F9  System.Void SetText(System.String text)
  RVA=0x09AD4F6C  token=0x60004FA  System.Void SetState(System.String stateName)
  RVA=0x02813CB0  token=0x60004FB  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonDropHintType
TYPE:  sealed struct
TOKEN: 0x200009B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CommonDropHintType    None  // const
  public    static  Beyond.UI.CommonDropHintType    Square  // const
  public    static  Beyond.UI.CommonDropHintType    Circle  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIDropItem
TYPE:  class
TOKEN: 0x200009C
SIZE:  0x80
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IDropHandler UnityEngine.EventSystems.IEventSystemHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           XLua.LuaTable                   <luaTable>k__BackingField  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDropEvent  // 0x20
  public            UnityEngine.Events.UnityEvent<System.Boolean>onToggleHighlight  // 0x28
  public            System.Action                   onDestroy  // 0x30
  public            Beyond.UI.CommonDropHintType    commonDropHintType  // 0x38
  private           UnityEngine.GameObject          _highlightHint  // 0x40
  private           System.Boolean                  _scaleWhenHighlight  // 0x48
  private           System.Single                   _scaleWhenActive  // 0x4c
  private           System.Boolean                  _useUIState  // 0x50
  private           Beyond.UI.UIStyleByState.StateConfig_stateConfigNormal  // 0x58
  private           Beyond.UI.UIStyleByState.StateConfig_stateConfigHilight  // 0x60
  private           UnityEngine.UI.Selectable       m_selectable  // 0x68
  private           UnityEngine.RectTransform       m_rectTransform  // 0x70
  private           System.Single                   m_oriScale  // 0x78
  private           System.Boolean                  m_isInHighlight  // 0x7c
PROPERTIES:
  luaTable  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x02C71290  token=0x60004FE  System.Void ClearEvents()
  RVA=0x037E73A0  token=0x60004FF  System.Void Awake()
  RVA=0x0364BBF0  token=0x6000500  System.Void OnEnable()
  RVA=0x0364BBB0  token=0x6000501  System.Void OnDisable()
  RVA=0x09AD4DB0  token=0x6000502  System.Void OnDestroy()
  RVA=0x0364BC50  token=0x6000503  System.Void ToggleHighlight(System.Boolean active, System.Boolean forceToggle)
  RVA=0x09AD4E50  token=0x6000504  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD4D18  token=0x6000505  System.Void ClearComponent()
  RVA=0x02848CA0  token=0x6000506  System.Void .ctor()
  RVA=0x0350B670  token=0x6000507  System.Void <>iFixBaseProxy_Awake()
  RVA=0x0350B670  token=0x6000508  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0350B670  token=0x6000509  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0350B670  token=0x600050A  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIElementFollower
TYPE:  class
TOKEN: 0x200009D
SIZE:  0xD0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           System.Boolean                  _followMouse  // 0x68
  public            System.Boolean                  followFixedPos  // 0x69
  private           UnityEngine.Transform           _targetTransform  // 0x70
  private           UnityEngine.Vector3             _followPosition  // 0x78
  private           System.Boolean                  _changeScale  // 0x84
  private           UnityEngine.AnimationCurve      _scaleCurve  // 0x88
  public            UnityEngine.Vector3             displayOffset  // 0x90
  public            UnityEngine.Vector3             displayUIOffset  // 0x9c
  private   static readonly Unity.Profiling.ProfilerMarker  UPDATE_POSITION_MARKER  // static @ 0x0
  public            Beyond.DisposedUnityEvent       onExitScreen  // 0xa8
  public            Beyond.DisposedUnityEvent       onEnterScreen  // 0xb0
  private           System.Boolean                  <inScreen>k__BackingField  // 0xb8
  private           Beyond.UI.LuaPanel              m_panel  // 0xc0
  private           UnityEngine.RectTransform       m_rectTransform  // 0xc8
PROPERTIES:
  tickOption  get=0x03D55B70
  followPosition  get=0x03D5E3C0  set=0x0398F430
  targetTransform  get=0x03D4EB30  set=0x09AD5020
  inScreen  get=0x03D51F80  set=0x03D51FD0
  panel  get=0x028AEF10
METHODS:
  RVA=0x037B3D10  token=0x6000513  System.Void OnAwake()
  RVA=0x03700750  token=0x6000514  System.Void OnEnable()
  RVA=0x028AE9D0  token=0x6000515  System.Void LateTick(System.Single deltaTime)
  RVA=0x028AEA10  token=0x6000516  System.Void UpdatePosition()
  RVA=0x028AEC00  token=0x6000517  System.Void UpdatePosition(UnityEngine.Vector3 worldPos)
  RVA=0x02847EA0  token=0x6000518  System.Void .ctor()
  RVA=0x03D06B30  token=0x6000519  System.Void .cctor()
  RVA=0x058E2A30  token=0x600051A  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x600051B  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x600051C  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIExtendScrollRect
TYPE:  class
TOKEN: 0x200009E
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IScrollHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler
FIELDS:
  public            Beyond.UI.UIScrollRect          baseScrollRect  // 0x18
  private           System.Boolean                  _enableDrag  // 0x20
  private           Beyond.UI.UIScrollList          _extendScrollList  // 0x28
METHODS:
  RVA=0x09AD5308  token=0x600051D  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD5044  token=0x600051E  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD5130  token=0x600051F  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AD521C  token=0x6000520  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0426FE60  token=0x6000521  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.IUIFoldoutComp
TYPE:  interface
TOKEN: 0x200009F
FIELDS:
PROPERTIES:
  defaultFoldOut  get=0x0232EB60
METHODS:
  RVA=-1  // abstract  token=0x6000523  System.Void Refresh(System.Int32 index)
  RVA=-1  // abstract  token=0x6000524  System.Void OnFoldOut(System.Boolean fastMode)
  RVA=-1  // abstract  token=0x6000525  System.Void OnFoldIn(System.Boolean fastMode)
END_CLASS

CLASS: Beyond.UI.UIFoldoutComponent
TYPE:  class
TOKEN: 0x20000A0
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.UI.IUIFoldoutComp
FIELDS:
  protected         UnityEngine.GameObject          _foldContent  // 0x18
  protected         Beyond.UI.UINonUnifiedScrollList_nonUnifiedScrollList  // 0x20
  public            System.Single                   foldInSize  // 0x28
  public            System.Single                   duration  // 0x2c
  public            DG.Tweening.Ease                easeType  // 0x30
  protected         System.Boolean                  m_isFoldOut  // 0x34
  private           DG.Tweening.Tweener             m_tween  // 0x38
  protected         System.Int32                    m_index  // 0x40
PROPERTIES:
  defaultFoldOut  get=0x0232EB60
METHODS:
  RVA=0x09AD5988  token=0x6000526  System.Void Refresh(System.Int32 index)
  RVA=0x09AD56D0  token=0x6000528  System.Void OnFoldOut(System.Boolean fastMode)
  RVA=0x09AD5420  token=0x6000529  System.Void OnFoldIn(System.Boolean fastMode)
  RVA=0x09AD53B4  token=0x600052A  System.Void OnDestroy()
  RVA=0x09AD5A04  token=0x600052B  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIGraphicAnimation
TYPE:  class
TOKEN: 0x20000A3
SIZE:  0x90
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private   static  System.Int32                    s_vfxMainTextSTId  // static @ 0x0
  private   static  System.Int32                    s_tintColorAlpha  // static @ 0x4
  private           UnityEngine.UI.MaskableGraphic  _graphic  // 0x68
  private           UnityEngine.Material            _material  // 0x70
  private           System.Single                   _alpha  // 0x78
  private           UnityEngine.Vector2             _scale  // 0x7c
  private           UnityEngine.Material            m_materialInstance  // 0x88
PROPERTIES:
  tickOption  get=0x03D55B70
  MaterialInstance  get=0x03D4EA60
METHODS:
  RVA=0x02E80910  token=0x6000534  System.Void OnAwake()
  RVA=0x09AD5A24  token=0x6000535  System.Void OnRelease()
  RVA=0x02802DD0  token=0x6000536  System.Void LateTick(System.Single deltaTime)
  RVA=0x02E80950  token=0x6000537  System.Void _Init()
  RVA=0x02845FF0  token=0x6000538  System.Void .ctor()
  RVA=0x03CF2060  token=0x6000539  System.Void .cctor()
  RVA=0x058E2A30  token=0x600053A  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7B4  token=0x600053B  System.Void <>iFixBaseProxy_OnRelease()
  RVA=0x0589E548  token=0x600053C  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIGridLayoutGroup
TYPE:  class
TOKEN: 0x20000A4
SIZE:  0x78
EXTENDS: UnityEngine.UI.GridLayoutGroup
FIELDS:
METHODS:
  RVA=0x09AD5B44  token=0x600053D  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIGridLayoutNaviWrapper
TYPE:  class
TOKEN: 0x20000A5
SIZE:  0x58
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: IScrollListNaviWrapper
FIELDS:
  private           UnityEngine.UI.GridLayoutGroup  _gridLayoutGroup  // 0x18
  private           UnityEngine.UI.LayoutGroup      _layoutGroup  // 0x20
  private           Beyond.UI.UIGridLayoutNaviWrapper.WrapMode_wrapMode  // 0x28
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x30
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x38
  private           System.Boolean                  _enableCircleWrapNavigation  // 0x40
  private           System.Boolean                  m_isInited  // 0x41
  private           System.Boolean                  m_isVertical  // 0x42
  private           UnityEngine.UI.LayoutGroup      m_layoutGroup  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x50
METHODS:
  RVA=0x02D99B50  token=0x600053E  System.Void _InitIfNot()
  RVA=0x02D99C20  token=0x600053F  System.Void Start()
  RVA=0x09AD5B4C  token=0x6000540  System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir)
  RVA=0x02D99D40  token=0x6000541  System.Void _InitWrapNavigation()
  RVA=0x09AD635C  token=0x6000542  System.Void _NaviGridLayout(UnityEngine.UI.NaviDirection dir)
  RVA=0x09AD5FA0  token=0x6000543  System.Boolean _NaviGridLayoutImpl(UnityEngine.UI.NaviDirection dir, System.Boolean enableCircleWrapNavigation)
  RVA=0x09AD622C  token=0x6000544  System.Boolean _NaviGridLayoutInit(System.Boolean isBefore, System.Boolean enableCircleWrapNavigation)
  RVA=0x09AD5D18  token=0x6000545  System.Boolean _NaviChildren(System.Int32 curIndex, System.Int32 childCount, System.Boolean isBefore, System.Boolean enableCircleWrapNavigation)
  RVA=0x09AD5BB0  token=0x6000546  UnityEngine.UI.Selectable _FindValidSelectable(System.Boolean isBefore)
  RVA=0x09AD63C4  token=0x6000547  System.Void _SetCircleWrapScroll(System.Boolean isBefore)
  RVA=0x03CFEDB0  token=0x6000548  System.Void .ctor()
  RVA=0x0350B670  token=0x6000549  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.UI.UIGyroscopeEffect
TYPE:  class
TOKEN: 0x20000A7
SIZE:  0xE0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Boolean                  enableDetect  // 0x68
  public            System.Single                   mobileGravityScaler  // 0x6c
  public            System.Single                   controllerGravityScaler  // 0x70
  public            System.Single                   controllerAccSmoothFactor  // 0x74
  public            Beyond.UI.UIGyroscopeEffect.Paramx  // 0x78
  public            Beyond.UI.UIGyroscopeEffect.Paramy  // 0x80
  public            DG.Tweening.Ease                ease  // 0x88
  public            System.Single                   time  // 0x8c
  private           UnityEngine.Vector3             m_lastValue  // 0x90
  private           Cinemachine.CinemachineVirtualCameram_vcam  // 0xa0
  private           Beyond.UI.CinemachineGyroscopeEffectm_vcamGyroscopeEffect  // 0xa8
  private           System.Boolean                  m_isVcamMode  // 0xb0
  private           System.Single                   m_baseGravityY  // 0xb4
  private           System.Single                   m_baseGravityYAccumulatedTime  // 0xb8
  private           System.Single                   m_lastGravityY  // 0xbc
  private           UnityEngine.Vector3             m_smoothedControllerAccValue  // 0xc0
  public            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions>handler  // 0xd0
  public            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>tween  // 0xd8
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x03C8AEC0  token=0x600054B  System.Void OnAwake()
  RVA=0x0284EE00  token=0x600054C  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD64C4  token=0x600054D  System.Void OnRelease()
  RVA=0x03988FA0  token=0x600054E  System.Void .ctor()
  RVA=0x09AD656C  token=0x600054F  UnityEngine.Vector3 <Tick>b__22_0()
  RVA=0x09AD65A0  token=0x6000550  System.Void <Tick>b__22_1(UnityEngine.Vector3 value)
  RVA=0x058E2A30  token=0x6000551  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x6000552  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0577D7B4  token=0x6000553  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIHighlightMask
TYPE:  class
TOKEN: 0x20000A9
SIZE:  0x98
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.RectTransform       _up  // 0x68
  private           UnityEngine.RectTransform       _down  // 0x70
  private           UnityEngine.RectTransform       _left  // 0x78
  private           UnityEngine.RectTransform       _right  // 0x80
  private           UnityEngine.RectTransform       m_rect  // 0x88
  private           Beyond.UI.LuaPanel              m_panel  // 0x90
PROPERTIES:
  tickOption  get=0x03D55800
  panel  get=0x09AD6A60
METHODS:
  RVA=0x09AD65C8  token=0x6000557  System.Void OnAwake()
  RVA=0x09AD6658  token=0x6000558  System.Void OnEnable()
  RVA=0x09AD66B4  token=0x6000559  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD6714  token=0x600055A  System.Void TrySyncRect()
  RVA=0x02846010  token=0x600055B  System.Void .ctor()
  RVA=0x058E2A30  token=0x600055C  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x600055D  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x600055E  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImage
TYPE:  class
TOKEN: 0x20000AA
SIZE:  0x228
EXTENDS: UnityEngine.UI.Image
FIELDS:
  private           System.Int32                    _atlasHandleId  // 0x190
  private           System.Collections.Generic.List<Beyond.UI.UIImage>_referencedImages  // 0x198
  private           Beyond.UI.UIAtlasManager.UIAtlasHandlem_atlasHandle  // 0x1a0
  private           System.Action                   m_onEnableRuntimeAtlas  // 0x1c8
  private           Beyond.UI.LuaPanel              m_panel  // 0x1d0
  private           System.Boolean                  m_hasBeenEnabled  // 0x1d8
  private           System.String                   m_cachedSpritePath  // 0x1e0
  protected         Beyond.Resource.FAssetProxyHandlem_spriteResHandle  // 0x1e8
  protected         Beyond.Resource.FAssetProxyHandlem_matResHandle  // 0x1fc
  public    static  System.String                   SPRITE_PATH_FORMAT  // const
  public    static  System.String                   SPRITE_ROOT_PATH_FORMAT  // const
  public            System.Boolean                  enableAutoImgUsePathReference  // 0x210
  public            System.Boolean                  imgUsePathReference  // 0x211
  public            System.String                   imgRefPath  // 0x218
  private           System.Boolean                  m_imgIsPathReference  // 0x220
PROPERTIES:
  packIntoRuntimeAtlas  get=0x03D760D0  set=0x03D760F0
  atlasHandleId  get=0x03D760B0  set=0x03D760E0
  panel  get=0x025CB310
  atlasHandle  get=0x03D760C0
  panelLevel  get=0x03D59F30
  color  get=0x03D54E00  set=0x025C1BE0
  mainTexture  get=0x025C4980
METHODS:
  RVA=0x02529CE0  token=0x6000566  System.Void RegisterOnEnableRuntimeAtlas(System.Action callBack)
  RVA=0x0252A2D0  token=0x6000567  System.Void UnregisterOnEnableRuntimeAtlas(System.Action callBack)
  RVA=0x09AD7DB0  token=0x6000568  System.Void OnEnableRuntimeAtlas()
  RVA=0x025CA510  token=0x600056B  System.Void _OnSpriteChanged(UnityEngine.Sprite lastOne)
  RVA=0x025C42F0  token=0x600056C  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  RVA=0x025CA830  token=0x600056D  System.Void Awake()
  RVA=0x025CAF40  token=0x600056E  System.Void OnEnable()
  RVA=0x0239F230  token=0x600056F  System.Void OnDisable()
  RVA=0x025CB590  token=0x6000570  System.Void OnDestroy()
  RVA=0x025CB690  token=0x6000571  System.Void SetNativeSize()
  RVA=0x09AD7E0C  token=0x6000572  System.Void SetNativeSizeIgnoreRefScale()
  RVA=0x029FA2B0  token=0x6000573  System.Void LoadSprite(System.String folder, System.String spriteName)
  RVA=0x02BE0080  token=0x6000574  System.Void LoadSprite(System.String path)
  RVA=0x02C73750  token=0x6000575  System.Void LoadSpriteWithOutFormat(System.String path, System.Boolean ignoreEnable)
  RVA=0x025C1ED0  token=0x6000576  System.Void _LoadSprite(System.String path, System.Boolean ignoreEnable)
  RVA=0x09AD7B74  token=0x6000577  System.Void LoadMaterial(System.String path, System.Boolean newInstance)
  RVA=0x03C84710  token=0x6000578  System.Void ReleaseSprite()
  RVA=0x025CB5E0  token=0x6000579  System.Void DisposeSpriteHandle()
  RVA=0x030F0910  token=0x600057B  System.Void _V2AtlasInitialize()
  RVA=0x024342B0  token=0x600057C  System.Void .ctor()
  RVA=0x09ACC870  token=0x600057D  System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0)
  RVA=0x09AD7E94  token=0x600057E  System.Void <>iFixBaseProxy__OnSpriteChanged(UnityEngine.Sprite P0)
  RVA=0x09AD7E7C  token=0x600057F  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
  RVA=0x09AD7E5C  token=0x6000580  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AD7E74  token=0x6000581  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09AD7E6C  token=0x6000582  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AD7E64  token=0x6000583  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09AD7E8C  token=0x6000584  System.Void <>iFixBaseProxy_SetNativeSize()
  RVA=0x09AD7E84  token=0x6000585  System.Void <>iFixBaseProxy_ReleaseSprite()
  RVA=0x09AD7E9C  token=0x6000586  UnityEngine.Texture <>iFixBaseProxy_get_mainTexture()
END_CLASS

CLASS: Beyond.UI.UIImageBlur
TYPE:  class
TOKEN: 0x20000AB
SIZE:  0xB8
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Single                   scale  // 0x68
  private           UnityEngine.RectTransform       m_rect  // 0x70
  private           System.Single                   m_lastScale  // 0x78
  private           Beyond.UI.UIImage               m_image  // 0x80
  private           UnityEngine.Texture2D           m_srcTex  // 0x88
  private           UnityEngine.RenderTexture       m_tarTex  // 0x90
  private           System.Int32                    m_uiImageBlurTexId  // 0x98
  private           UnityEngine.Rect                m_atlasRect  // 0x9c
  private           System.Action                   m_dynamicCallback  // 0xb0
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x02529040  token=0x6000588  System.Void OnAwake()
  RVA=0x02528830  token=0x6000589  System.Void OnChangeSprite()
  RVA=0x09AD6BA8  token=0x600058A  System.Void Tick(System.Single deltaTime)
  RVA=0x032FA1A0  token=0x600058B  System.Void OnDisable()
  RVA=0x09AD6B24  token=0x600058C  System.Void OnRelease()
  RVA=0x02846010  token=0x600058D  System.Void .ctor()
  RVA=0x058E2A30  token=0x600058E  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x600058F  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x058DD8A4  token=0x6000590  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0577D7B4  token=0x6000591  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIImageFillAmountOffset
TYPE:  class
TOKEN: 0x20000AC
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIImage               m_followImage  // 0x18
  public            System.Single                   fillOffset  // 0x20
  private           System.Single                   m_fillAmount  // 0x24
PROPERTIES:
  fillAmount  get=0x03D524F0  set=0x09AD6E90
METHODS:
  RVA=0x09AD6D04  token=0x6000594  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(System.Single endValue, System.Single duration)
  RVA=0x0426FE60  token=0x6000595  System.Void .ctor()
  RVA=0x03D524F0  token=0x6000596  System.Single <DOFillAmount>b__6_0()
  RVA=0x09AD6E88  token=0x6000597  System.Void <DOFillAmount>b__6_1(System.Single x)
END_CLASS

CLASS: Beyond.UI.UIImageFillFollower
TYPE:  class
TOKEN: 0x20000AD
SIZE:  0x80
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private   static  System.Single                   BACK_FOLLOW_THRESHOLD  // const
  private           Beyond.UI.UIImage               _frontFill  // 0x68
  private           System.Single                   _followSpeed  // 0x70
  private           Beyond.UI.UIImage               m_image  // 0x78
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AD6FC8  token=0x6000599  System.Void OnAwake()
  RVA=0x09AD706C  token=0x600059A  System.Void OnEnable()
  RVA=0x09AD714C  token=0x600059B  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD70E0  token=0x600059C  System.Void RefreshFillAmount()
  RVA=0x09AD7250  token=0x600059D  System.Void .ctor()
  RVA=0x058E2A30  token=0x600059E  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x600059F  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x60005A0  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImageFillTailFollower
TYPE:  class
TOKEN: 0x20000AE
SIZE:  0x88
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIImage               _followImage  // 0x68
  public            System.Single                   followOffset  // 0x70
  private           UnityEngine.RectTransform       m_selfRectTransform  // 0x78
  private           UnityEngine.RectTransform       m_followImageRectTransform  // 0x80
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AD7260  token=0x60005A2  System.Void OnAwake()
  RVA=0x09AD7324  token=0x60005A3  System.Void OnEnable()
  RVA=0x09AD763C  token=0x60005A4  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD738C  token=0x60005A5  System.Void RefreshFollower()
  RVA=0x02846010  token=0x60005A6  System.Void .ctor()
  RVA=0x058E2A30  token=0x60005A7  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x60005A8  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x60005A9  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImagePair
TYPE:  class
TOKEN: 0x20000AF
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIImage>referencedImages  // 0x18
PROPERTIES:
  color  set=0x09AD79E4
  first  get=0x09AD794C
METHODS:
  RVA=0x09AD7814  token=0x60005AA  System.Void LoadSprite(System.String folder, System.String spriteName)
  RVA=0x09AD76A8  token=0x60005AB  System.Void LoadSprite(System.String path)
  RVA=0x09AD78CC  token=0x60005AE  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIInertiaViewPager
TYPE:  class
TOKEN: 0x20000B0
SIZE:  0xF0
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x68
  private           System.Single                   _animationDuration  // 0x70
  private           System.Single                   _endScrollSpd  // 0x74
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing_timing  // 0x78
  private           System.Single                   _minScrollInterval  // 0x7c
  private           System.String                   _audioGear  // 0x80
  private           System.String                   _audioGearLock  // 0x88
  public            System.Boolean                  flingToNextEnable  // 0x90
  public            System.Single                   flingToNextMinSpd  // 0x94
  public            System.Single                   flingToNextMaxSpd  // 0x98
  private           System.Int32                    m_currentPage  // 0x9c
  private           Beyond.UI.UIInertiaViewPager.Statem_state  // 0xa0
  private           Beyond.UI.UIInertiaViewPager.IScrollHandlerm_scrollHandler  // 0xa8
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectTriggerm_effectTrigger  // 0xb0
  private           Beyond.UI.UIInertiaViewPager.BlockerManagerm_blockers  // 0xb8
  private           Beyond.UI.UIInertiaViewPager.DragContextm_dragContext  // 0xc0
  private           System.Int32                    m_fromPage  // 0xc8
  private           System.Int32                    m_toPage  // 0xcc
  private           System.Single                   m_tweenStartTime  // 0xd0
  private           System.Single                   m_tweenStartValue  // 0xd4
  private           System.Single                   m_tweenTargetValue  // 0xd8
  private           System.Boolean                  m_isInited  // 0xdc
  private           System.Int32                    <pageCount>k__BackingField  // 0xe0
  public            Beyond.DisposedUnityEvent<System.Int32>onStateChanged  // 0xe8
PROPERTIES:
  tickOption  get=0x03D55800
  isUpdating  get=0x09AD8DA0
  pageCount  get=0x03D50ED0  set=0x03D50FB0
  currentPage  get=0x03D51960  set=0x09AD8DAC
  currentScrollIndex  get=0x09AD8D6C
METHODS:
  RVA=0x09AD8924  token=0x60005B0  System.Void _PlayAudioGear()
  RVA=0x09AD88A8  token=0x60005B1  System.Void _PlayAudioGearLock()
  RVA=0x09AD854C  token=0x60005B2  System.Void _InitIfNot()
  RVA=0x09AD7EA4  token=0x60005B9  System.Void ClearComponent()
  RVA=0x09AD817C  token=0x60005BA  System.Void Tick(System.Single deltaTime)
  RVA=0x09AD80F4  token=0x60005BB  System.Void SetPageCount(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> segmentFrames)
  RVA=0x09AD7F98  token=0x60005BC  System.Void MoveToPage(System.Int32 pageIndex)
  RVA=0x09AD8028  token=0x60005BD  System.Void OnAwake()
  RVA=0x09AD8084  token=0x60005BE  System.Void OnEnable()
  RVA=0x09AD89A0  token=0x60005BF  System.Single _ScrollValue2PageIndex(System.Single value)
  RVA=0x09AD882C  token=0x60005C0  System.Single _PageIndex2ScrollValue(System.Single index)
  RVA=0x09AD8A18  token=0x60005C1  System.Int32 _ScrollValueAlignToPage(System.Single value)
  RVA=0x09AD8A9C  token=0x60005C2  System.Void _SwitchToPage(System.Int32 targetIndex, System.Boolean useTween)
  RVA=0x09AD84D4  token=0x60005C3  System.Void _AutoAlign()
  RVA=0x09AD875C  token=0x60005C4  System.Void _OnStateChanged(Beyond.UI.UIInertiaViewPager.State from, Beyond.UI.UIInertiaViewPager.State to)
  RVA=0x09AD8C30  token=0x60005C5  System.Void .ctor()
  RVA=0x0577D7BC  token=0x60005C6  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x058E2A30  token=0x60005C7  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x60005C8  System.Void <>iFixBaseProxy_OnEnable()
END_CLASS

CLASS: Beyond.UI.UIInputField
TYPE:  class
TOKEN: 0x20000BE
SIZE:  0x440
EXTENDS: TMPro.TMP_InputField
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public            System.String                   activeInputActionId  // 0x388
  public            System.String                   deactivateInputActionId  // 0x390
  private           System.Int32                    <activeInputBindingId>k__BackingField  // 0x398
  private           System.Int32                    <deactivateInputBindingId>k__BackingField  // 0x39c
  private           Beyond.UI.LuaPanel              m_panel  // 0x3a0
  public            System.Boolean                  isDebugInputField  // 0x3a8
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x3b0
  private           UnityEngine.GameObject          m_fallbackUIRoot  // 0x3b8
  private           UnityEngine.RectTransform       m_fallbackRectTransform  // 0x3c0
  private           System.Int32                    m_activateBindingGroupId  // 0x3c8
  private           System.Boolean                  m_isNaviFocused  // 0x3cc
  private           Beyond.UI.UIState.UIStateController_uiStateController  // 0x3d0
  private           System.String                   _onFocusStateName  // 0x3d8
  private           System.String                   _onFocusLostStateName  // 0x3e0
  private           System.String                   _audioPressStart  // 0x3e8
  public            UnityEngine.RectTransform       m_keyboardOffsetTarget  // 0x3f0
  public            UnityEngine.RectTransform       m_offsetTargetParent  // 0x3f8
  public            UnityEngine.RectTransform       m_inputFieldRect  // 0x400
  public            System.Int32                    m_pcDebug  // 0x408
  public            System.Single                   m_keyboardExtraOffsetY  // 0x40c
  private           UnityEngine.Vector2             m_baseKeyboardOffsetTarget  // 0x410
  private           UnityEngine.Vector2             m_baseKeyboardLocalPos  // 0x418
  private           System.Single                   m_inputFieldOffsetY  // 0x420
  private           System.Boolean                  m_enableKeyboardOffsetCal  // 0x424
  private           UnityEngine.Coroutine           m_heightChangeCoroutine  // 0x428
  private           System.Int32                    m_lastHeight  // 0x430
  private           System.Int32                    m_nowHeight  // 0x434
  public            System.String                   audioOnActive  // 0x438
  private   static  Beyond.UI.UIInputField          s_mFocusedInputField  // static @ 0x0
PROPERTIES:
  activeInputBindingId  get=0x03D76100  set=0x03D76120
  deactivateInputBindingId  get=0x03D76110  set=0x03D76130
  panel  get=0x09AD91CC
  isControllerInputValid  get=0x03683B80
  s_focusedInputField  get=0x09AD9290  set=0x02B56B00
METHODS:
  RVA=0x03CC4AA0  token=0x60005F5  System.Void SendOnFocus()
  RVA=0x03CFB4E0  token=0x60005F6  System.Void SendOnFocusLost()
  RVA=0x03779290  token=0x60005F7  System.Void Awake()
  RVA=0x03CDD0A0  token=0x60005F8  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03CBAAE0  token=0x60005F9  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03683900  token=0x60005FA  System.Void ActivateInputField()
  RVA=0x03683A00  token=0x60005FB  System.Void DeactivateInputField(System.Boolean clearSelection)
  RVA=0x0304D600  token=0x60005FC  System.Void OnDestroy()
  RVA=0x02CD8110  token=0x60005FD  System.Void OnEnable()
  RVA=0x02CD8150  token=0x60005FE  System.Void OnDisable()
  RVA=0x0386D1D0  token=0x60005FF  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x09AD8DB8  token=0x6000600  System.Void OnInteractableChanged()
  RVA=0x02CD8190  token=0x6000601  System.Void _UpdateBindingEnable()
  RVA=0x02C70800  token=0x6000602  System.Void ClearComponent()
  RVA=0x09AD8E9C  token=0x6000603  UnityEngine.Camera _GetCamera()
  RVA=0x03D07970  token=0x6000604  System.Void _VirtualKeyboardOnDestroy()
  RVA=0x03CDD0F0  token=0x6000605  System.Void _VirtualKeyboardSelect()
  RVA=0x03CBAB30  token=0x6000606  System.Void _VirtualKeyboardDeselect()
  RVA=0x037795C0  token=0x6000607  System.Void _VirtualKeyboardAwake()
  RVA=0x09AD9178  token=0x6000608  System.Void _UpdateKeyboardOffset(System.Int32 offsetHeight)
  RVA=0x09AD8E58  token=0x6000609  System.Void _CleanupAndroidObjects()
  RVA=0x03779600  token=0x600060A  System.Void _VirtualKeyboardInitJavaObj()
  RVA=0x09AD90DC  token=0x600060B  System.Collections.IEnumerator _KeyboardHeightChange(System.Action<System.Int32> onHeightChanged)
  RVA=0x02849EC0  token=0x600060E  System.Void .ctor()
  RVA=0x09AD8E08  token=0x600060F  System.Void <Awake>b__27_0()
  RVA=0x09AD8E50  token=0x6000610  System.Void <>iFixBaseProxy_SendOnFocus()
  RVA=0x09AD8E48  token=0x6000611  System.Void <>iFixBaseProxy_SendOnFocusLost()
  RVA=0x09AAE8DC  token=0x6000612  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AD8E40  token=0x6000613  System.Void <>iFixBaseProxy_OnSelect(UnityEngine.EventSystems.BaseEventData P0)
  RVA=0x09AD8E28  token=0x6000614  System.Void <>iFixBaseProxy_OnDeselect(UnityEngine.EventSystems.BaseEventData P0)
  RVA=0x09AD8E18  token=0x6000615  System.Void <>iFixBaseProxy_ActivateInputField()
  RVA=0x09AD8E20  token=0x6000616  System.Void <>iFixBaseProxy_DeactivateInputField(System.Boolean P0)
  RVA=0x09AAE8E4  token=0x6000617  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09AD8E38  token=0x6000618  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09AD8E30  token=0x6000619  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09ACB974  token=0x600061A  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  RVA=0x0350B670  token=0x600061B  System.Void <>iFixBaseProxy_OnInteractableChanged()
END_CLASS

CLASS: Beyond.UI.UIJoystick
TYPE:  class
TOKEN: 0x20000C0
SIZE:  0x188
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IPointerUpHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp Beyond.Input.IBindingGroupTarget
FIELDS:
  private           UnityEngine.RectTransform       _runBg  // 0x18
  private           UnityEngine.RectTransform       _walkBg  // 0x20
  private           UnityEngine.RectTransform       _thumb  // 0x28
  private           UnityEngine.RectTransform       _directionIndicate  // 0x30
  private           UnityEngine.RectTransform       _walkDirectionIndicate  // 0x38
  private           UnityEngine.RectTransform       _rootCanvas  // 0x40
  private           UnityEngine.RectTransform       _triggerArea  // 0x48
  private           UnityEngine.UI.GraphicRaycaster _raycaster  // 0x50
  private           System.Single                   _walkRation  // 0x58
  private           System.Single                   _autoSprintStartLength  // 0x5c
  private           System.Single                   _autoSprintStopLength  // 0x60
  private           System.Single                   _autoSprintStartAngle  // 0x64
  private           System.Single                   _autoSprintStopAngle  // 0x68
  public            System.Single                   margin  // 0x6c
  public            System.Single                   bgVisibleTimeWhenEnable  // 0x70
  private           System.Single                   m_bgHideTime  // 0x74
  private           System.Boolean                  _isDynamic  // 0x78
  private           Beyond.UI.LuaPanel              m_panel  // 0x80
  private           UnityEngine.Vector2             <jsValue>k__BackingField  // 0x88
  private           Beyond.UI.UITouchPanel          _dynamicArea  // 0x90
  private           System.Boolean                  _dynamicButDontMove  // 0x98
  private           System.Boolean                  _useRewiredPlayerInput  // 0x99
  private           System.String                   _controllerRewiredActionX  // 0xa0
  private           System.String                   _controllerRewiredActionY  // 0xa8
  private           System.String                   _keyboardRewiredActionX  // 0xb0
  private           System.String                   _keyboardRewiredActionY  // 0xb8
  private           System.Boolean                  m_active  // 0xc0
  private           System.Boolean                  m_activatedByTouch  // 0xc1
  public            Beyond.DisposedUnityEvent       onTouchStart  // 0xc8
  public            Beyond.DisposedUnityEvent       onTouchEnd  // 0xd0
  public            Beyond.DisposedUnityEvent       onMoveStart  // 0xd8
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onMove  // 0xe0
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0xe8
  public            Beyond.DisposedUnityEvent<System.Boolean>onToggleAutoSprint  // 0xf0
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xf8
  private           UnityEngine.RectTransform       m_rect  // 0x100
  private           UnityEngine.Vector2             m_oriAnchorMin  // 0x108
  private           UnityEngine.Vector2             m_oriAnchorMax  // 0x110
  private           UnityEngine.Vector2             m_oriAnchorPos  // 0x118
  private           UnityEngine.Vector2             m_oriPivot  // 0x120
  private           System.Boolean                  m_isWalking  // 0x128
  private           System.Boolean                  m_isRunning  // 0x129
  private           System.Boolean                  m_isSprinting  // 0x12a
  private           Beyond.UI.UIAnimationWrapper    m_walkBgAnim  // 0x130
  private           Beyond.UI.UIAnimationWrapper    m_runBgAnim  // 0x138
  private           System.Boolean                  m_isWalkBgVisible  // 0x140
  private           System.Boolean                  m_isRunBgVisible  // 0x141
  private           System.Collections.Generic.List<UnityEngine.InputSystem.UI.ExtendedPointerEventData>m_exPointers  // 0x148
  private           UnityEngine.InputSystem.UI.ExtendedPointerEventDatam_fakePointerEventData  // 0x150
  private           UnityEngine.InputSystem.UI.ExtendedPointerEventDatam_activePointerEventData  // 0x158
  private           Beyond.UI.UICustomLayoutElement m_customLayoutElement  // 0x160
  private           UnityEngine.Vector2             m_lastFrameActiveStickVal  // 0x168
  private           UnityEngine.EventSystems.PointerEventData<curDragEventData>k__BackingField  // 0x170
  private           System.Int32                    m_groupId  // 0x178
  private           System.Boolean                  m_bindingInit  // 0x17c
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x180
PROPERTIES:
  panel  get=0x09AD9990
  isDynamic  get=0x03D4F800  set=0x09AD9A54
  walkRation  get=0x03D51080  set=0x02BDC0D0
  active  get=0x03D583F0
  activeTouchId  get=0x09AD9958
  jsValue  get=0x03D696E0  set=0x03D4E740
  m_thumbPosMaxLength  get=0x029130A0
  curDragEventData  get=0x03D574A0  set=0x04275C18
  groupEnabled  get=0x02913170
  shouldCheckInput  get=0x02913100
  groupId  get=0x09AD9974
  parentTarget  get=0x03D56B50
  parent  get=0x03D56B50  set=0x04275C40
METHODS:
  RVA=0x09AD9788  token=0x600062E  System.Void Reset()
  RVA=0x02BDCE00  token=0x600062F  System.Void Awake()
  RVA=0x03B3E800  token=0x6000630  System.Void OnEnable()
  RVA=0x03CB4140  token=0x6000631  System.Void Start()
  RVA=0x09AD93D0  token=0x6000632  System.Void OnDestroy()
  RVA=0x029131D0  token=0x6000633  System.Void _Tick()
  RVA=0x09AD9600  token=0x6000634  System.Void OnDisable()
  RVA=0x02BDC8B0  token=0x6000635  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x038DEC00  token=0x6000636  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03CA3FA0  token=0x6000637  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02912E20  token=0x6000638  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02CAD100  token=0x6000639  System.Void CheckShouldActive()
  RVA=0x02BDC850  token=0x600063A  System.Void _SetVisible(System.Boolean visible)
  RVA=0x02BDC540  token=0x600063B  System.Void _ChangeDynamic(System.Boolean dynamic, System.Boolean force)
  RVA=0x02BDCAC0  token=0x600063C  System.Void _SetRectTransform(System.Boolean toOri)
  RVA=0x02BDC130  token=0x600063D  System.Void _UpdateWalkBgScale()
  RVA=0x02BDC9F0  token=0x600063E  System.Void _Activate(System.Boolean fromTouch, UnityEngine.Vector2 showPos, UnityEngine.Vector2 initJsValue)
  RVA=0x02912D50  token=0x600063F  System.Void _UpdateGait()
  RVA=0x02912970  token=0x6000640  System.Void _UpdateIndicator()
  RVA=0x02912B40  token=0x6000641  System.Void _UpdateBg()
  RVA=0x02912C20  token=0x6000642  System.Void _SetWalkBgVisible(System.Boolean visible, System.Boolean ignoreAnim)
  RVA=0x02912CA0  token=0x6000643  System.Void _SetRunBgVisible(System.Boolean visible, System.Boolean ignoreAnim)
  RVA=0x09AD9864  token=0x6000644  System.Void _OnHudLayoutLoaded(Beyond.EventData<System.String>& eventData)
  RVA=0x09AD92C8  token=0x6000645  System.Void ClearComponent()
  RVA=0x02BDC300  token=0x600064C  System.Void InitBinding()
  RVA=0x02BDC460  token=0x600064D  System.Void _UpdateState()
  RVA=0x028490A0  token=0x600064E  System.Void .ctor()
  RVA=0x09AD9858  token=0x600064F  System.Void <Awake>b__74_0(UnityEngine.Vector2 _)
END_CLASS

CLASS: Beyond.UI.UILayoutDimensionListener
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: Beyond.IHotfixable UnityEngine.UI.ICanvasElement
FIELDS:
  private           Beyond.ListSet<Beyond.UI.UILayoutDimensionListener.IAction>m_actionsWhenLayoutReady  // 0x18
  public            Beyond.DisposedUnityEvent       eventOnPostLayout  // 0x20
METHODS:
  RVA=0x09AD9AF0  token=0x6000650  System.Void GraphicUpdateComplete()
  RVA=0x09AD9B34  token=0x6000651  System.Void LayoutComplete()
  RVA=0x09AD9CB0  token=0x6000652  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x09AD9F94  token=0x6000653  System.Collections.IEnumerator _NextFrameCoroutine()
  RVA=0x09AD9A60  token=0x6000654  System.Void DoOnceOnPostLayout(Beyond.UI.UILayoutDimensionListener.IAction action)
  RVA=0x09AD9C10  token=0x6000655  System.Void OnEnable()
  RVA=0x09AD9C60  token=0x6000656  System.Void OnRectTransformDimensionsChange()
  RVA=0x09AD9B78  token=0x6000657  System.Void OnDestroy()
  RVA=0x09ADA024  token=0x6000658  System.Void _SetDirty()
  RVA=0x09AD9D80  token=0x6000659  System.Void _InvokePostLayoutCallback()
  RVA=0x03D018C0  token=0x600065A  System.Void .ctor()
  RVA=0x09AD9D30  token=0x600065B  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
  RVA=0x0350B670  token=0x600065C  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0350B670  token=0x600065D  System.Void <>iFixBaseProxy_OnRectTransformDimensionsChange()
  RVA=0x0350B670  token=0x600065E  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UILeftSubtitle
TYPE:  class
TOKEN: 0x20000C4
SIZE:  0xB0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIDialogTextWithCursor_dialogText1  // 0x68
  private           Beyond.UI.UIDialogTextWithCursor_dialogText2  // 0x70
  private           Beyond.UI.UIDialogTextWithCursor_dialogText3  // 0x78
  private           Beyond.UI.UIDialogTextWithCursor_dialogText4  // 0x80
  private           Beyond.UI.UIAnimationWrapper    _panelAnimation  // 0x88
  private           System.Int32                    m_maxDisplayIndex  // 0x90
  private   readonly System.Collections.Generic.List<Beyond.UI.UIDialogTextWithCursor>m_dialogTextList  // 0x98
  private           System.Boolean                  m_isDisplaying  // 0xa0
  private           System.Single                   m_currTime  // 0xa4
  private           System.Single                   m_textStayTime  // 0xa8
  private           System.Boolean                  m_isAutoPlay  // 0xac
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09ADA6F8  token=0x6000667  System.Void Tick(System.Single deltaTime)
  RVA=0x09ADA688  token=0x6000668  System.Void StartAutoPlay(System.Single textStayTime)
  RVA=0x09ADA1A8  token=0x6000669  System.Void SetLeftSubTitle(System.String text1, System.String text2, System.String text3, System.String text4)
  RVA=0x09ADA7BC  token=0x600066A  System.Single UpdateByPlayTime(System.Single currTime)
  RVA=0x09ADA0B0  token=0x600066B  System.Void Exit()
  RVA=0x09ADA618  token=0x600066C  System.Void SetVisible(System.Boolean visible)
  RVA=0x09ADA8BC  token=0x600066D  System.Void .ctor()
  RVA=0x09ADA7B0  token=0x600066E  System.Void <Exit>b__17_0()
  RVA=0x0577D7BC  token=0x600066F  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIMaterialAnimation
TYPE:  class
TOKEN: 0x20000C5
SIZE:  0x1E0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.UI.MaskableGraphic  _maskableGraphic  // 0x68
  private           UnityEngine.Material            _material  // 0x70
  private           System.String                   _propertiesName1  // 0x78
  private           System.Single                   _propertiesSet1  // 0x80
  private           System.String                   _propertiesName2  // 0x88
  private           System.Single                   _propertiesSet2  // 0x90
  private           System.String                   _propertiesName3  // 0x98
  private           System.Single                   _propertiesSet3  // 0xa0
  private           System.String                   _propertiesName4  // 0xa8
  private           System.Single                   _propertiesSet4  // 0xb0
  private           System.String                   _propertiesName5  // 0xb8
  private           System.Single                   _propertiesSet5  // 0xc0
  private           System.String                   _propertiesName6  // 0xc8
  private           System.Single                   _propertiesSet6  // 0xd0
  private           System.String                   _propertiesName7  // 0xd8
  private           System.Single                   _propertiesSet7  // 0xe0
  private           System.String                   _propertiesName8  // 0xe8
  private           System.Single                   _propertiesSet8  // 0xf0
  private           System.String                   _propertiesName9  // 0xf8
  private           System.Single                   _propertiesSet9  // 0x100
  private           System.String                   _propertiesName10  // 0x108
  private           System.Single                   _propertiesSet10  // 0x110
  private           System.String                   _propertiesVectorName1  // 0x118
  private           UnityEngine.Vector4             _propertiesVector1  // 0x120
  private           System.String                   _propertiesVectorName2  // 0x130
  private           UnityEngine.Vector4             _propertiesVector2  // 0x138
  private           System.String                   _propertiesVectorName3  // 0x148
  private           UnityEngine.Vector4             _propertiesVector3  // 0x150
  private           System.String                   _propertiesVectorName4  // 0x160
  private           UnityEngine.Vector4             _propertiesVector4  // 0x168
  private           System.String                   _propertiesVectorName5  // 0x178
  private           UnityEngine.Vector4             _propertiesVector5  // 0x180
  private           System.String                   _propertiesColorName1  // 0x190
  private           UnityEngine.Color               _propertiesColor1  // 0x198
  private           System.String                   _propertiesColorName2  // 0x1a8
  private           UnityEngine.Color               _propertiesColor2  // 0x1b0
  private           System.String                   _propertiesColorName3  // 0x1c0
  private           UnityEngine.Color               _propertiesColor3  // 0x1c8
  private           UnityEngine.Material            m_matIns  // 0x1d8
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x02861160  token=0x6000671  System.Void LateTick(System.Single deltaTime)
  RVA=0x037D3C20  token=0x6000672  System.Void OnAwake()
  RVA=0x03A28FF0  token=0x6000673  System.Void OnRelease()
  RVA=0x02861200  token=0x6000674  System.Void _TryUpdate()
  RVA=0x09ADA950  token=0x6000675  System.Void ForceUpdate()
  RVA=0x02846010  token=0x6000676  System.Void .ctor()
  RVA=0x0589E548  token=0x6000677  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x058E2A30  token=0x6000678  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7B4  token=0x6000679  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UINonUnifiedScrollList
TYPE:  class
TOKEN: 0x20000C6
SIZE:  0x2D8
EXTENDS: Beyond.UI.UIScrollList
FIELDS:
  public            Beyond.UI.UINonUnifiedScrollList.GetCellSizeModegetCellSizeMode  // 0x278
  private           System.Boolean                  _recalculateAfterSizeChange  // 0x27c
  private           System.Boolean                  _forceUpdateCellSizeCache  // 0x27d
  public            System.Func<System.Int32,System.Int32>getSubCellCount  // 0x280
  public            System.Func<System.Int32,System.Single>getCellSize  // 0x288
  public            System.Single                   overrideContainSize  // 0x290
  private           UnityEngine.UI.GridLayoutGroup  m_templateCellGridLayoutGroup  // 0x298
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>m_cellSizeCache  // 0x2a0
  private           System.Int32                    m_containerTopIndex  // 0x2a8
  private   static  System.Single                   CONTAINER_SIZE_BUFFER  // const
  public            System.Single                   additiveContainerSizeBuffer  // 0x2ac
  private           System.Single                   m_lastScrollStep  // 0x2b0
  private           System.Boolean                  m_isRecalculatingSize  // 0x2b4
  private           System.Boolean                  m_isCalculatingContainerSize  // 0x2b5
  private           System.Int32                    m_averageCount  // 0x2b8
  private           System.Single                   m_averageCellSize  // 0x2bc
  private           System.Boolean                  m_needRecalculateAverage  // 0x2c0
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_cellFoldStateDic  // 0x2c8
  private           Beyond.UI.IUIFoldoutComp        m_cellTemplateFoldoutComp  // 0x2d0
PROPERTIES:
  currentStep  get=0x09ADD894  set=0x09ADDA4C
METHODS:
  RVA=0x09ADBEA4  token=0x600067A  System.Void InitBasicInfo()
  RVA=0x09ADA9A0  token=0x600067B  System.Void CalcSomeCountNum()
  RVA=0x09ADB6A0  token=0x600067C  System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount)
  RVA=0x09ADD388  token=0x600067D  System.Void UpdateCount(System.Int32 newCount)
  RVA=0x09ADD0A8  token=0x600067E  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow)
  RVA=0x09ADD168  token=0x600067F  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x09ADBF6C  token=0x6000680  System.Void LateTick(System.Single deltaTime)
  RVA=0x09ADC180  token=0x6000681  System.Void OnScroll(UnityEngine.Vector2 v)
  RVA=0x09ADB340  token=0x6000682  UnityEngine.Vector2 GetGridLayoutSize(UnityEngine.UI.GridLayoutGroup grid, System.Int32 count)
  RVA=0x09ADD458  token=0x6000683  System.Single _GetCellSize(System.Int32 index)
  RVA=0x09ADAED0  token=0x6000684  System.Single GetContainerSize(System.Boolean ignoreAutoLayout)
  RVA=0x09ADACE4  token=0x6000685  System.Single GetCenterIndex()
  RVA=0x09ADBA20  token=0x6000686  UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow)
  RVA=0x09ADB7E4  token=0x6000687  UnityEngine.Vector2Int GetNotCacheRange()
  RVA=0x09ADBFE8  token=0x6000688  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  RVA=0x09ADC208  token=0x6000689  System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  RVA=0x09ADBC9C  token=0x600068A  System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x09ADD7C4  token=0x600068B  System.Single _GetCellsSizeTo(System.Int32 index)
  RVA=0x09ADC484  token=0x600068C  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x09ADAA08  token=0x600068D  System.Void ClearComponent()
  RVA=0x09ADC994  token=0x6000690  System.Void SetStepTo(System.Single step)
  RVA=0x09ADC714  token=0x6000691  System.Void SetCurrentStep(System.Single currentStep)
  RVA=0x09ADB8BC  token=0x6000692  System.Single GetScrollBarSize()
  RVA=0x09ADB520  token=0x6000693  System.Single GetLastScrollStep()
  RVA=0x09ADD3FC  token=0x6000694  System.Void UpdateLastScrollStep()
  RVA=0x09ADB758  token=0x6000695  System.Single GetNormalizedPosition()
  RVA=0x09ADC8FC  token=0x6000696  System.Void SetNormalizedPosition(System.Single normalizedPosition)
  RVA=0x09ADCA08  token=0x6000697  System.Void ToggleByState(System.Int32 index, System.Boolean isFoldOut, System.Boolean fastMode)
  RVA=0x09ADCBEC  token=0x6000698  System.Void Toggle(System.Int32 index, System.Boolean fastMode)
  RVA=0x09ADAAB4  token=0x6000699  System.Void FoldAll(System.Boolean isFoldOut)
  RVA=0x09ADC0B4  token=0x600069A  System.Void NotifyCellSizeChange(System.Int32 index, System.Single size)
  RVA=0x03B73140  token=0x600069B  System.Void .ctor()
  RVA=0x09ADCE14  token=0x600069C  System.Void <GetScrollBarSize>g__RecalculateAverageCellSize|43_0()
  RVA=0x09ADD020  token=0x600069D  System.Void <>iFixBaseProxy_InitBasicInfo()
  RVA=0x09ADCFE0  token=0x600069E  System.Void <>iFixBaseProxy_CalcSomeCountNum()
  RVA=0x09ADD000  token=0x600069F  System.Single <>iFixBaseProxy_GetLeftLength(System.Boolean P0, System.Int32 P1)
  RVA=0x09ADD098  token=0x60006A0  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0)
  RVA=0x09ADD078  token=0x60006A1  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  RVA=0x09ADD058  token=0x60006A2  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, Beyond.UI.UIScrollList.ScrollAlignType P5)
  RVA=0x09ADD028  token=0x60006A3  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x09ADD030  token=0x60006A4  System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0)
  RVA=0x09ADCFF8  token=0x60006A5  System.Single <>iFixBaseProxy_GetContainerSize(System.Boolean P0)
  RVA=0x09ADCFF0  token=0x60006A6  System.Single <>iFixBaseProxy_GetCenterIndex()
  RVA=0x09ADD010  token=0x60006A7  UnityEngine.Vector2Int <>iFixBaseProxy_GetShowRange(System.Single P0, System.Boolean P1)
  RVA=0x09ADD008  token=0x60006A8  UnityEngine.Vector2Int <>iFixBaseProxy_GetNotCacheRange()
  RVA=0x09AC26FC  token=0x60006A9  System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
  RVA=0x09ADD038  token=0x60006AA  System.Void <>iFixBaseProxy_OnUpdateCell(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
  RVA=0x09ADD018  token=0x60006AB  System.Single <>iFixBaseProxy_GetTargetPosByIndex(System.Int32 P0, Beyond.UI.UIScrollList.ScrollAlignType P1)
  RVA=0x09ADD040  token=0x60006AC  System.Void <>iFixBaseProxy_ScrollTo(System.Int32 P0, System.Boolean P1, Beyond.UI.UIScrollList.ScrollAlignType P2)
  RVA=0x09ADCFE8  token=0x60006AD  System.Void <>iFixBaseProxy_ClearComponent()
  RVA=0x09ADD0A0  token=0x60006AE  System.Single <>iFixBaseProxy_get_currentStep()
  RVA=0x09ADD050  token=0x60006AF  System.Void <>iFixBaseProxy_SetStepTo(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UINonUnifiedScrollRect
TYPE:  class
TOKEN: 0x20000C8
SIZE:  0x1F0
EXTENDS: Beyond.UI.UIScrollRect
FIELDS:
  private           System.Boolean                  m_isInited  // 0x1d8
  private           System.Boolean                  m_isRebuilding  // 0x1d9
  private           Beyond.UI.UINonUnifiedScrollListm_scrollList  // 0x1e0
  private           Beyond.UI.UILayoutDimensionListenerm_dimensionListener  // 0x1e8
METHODS:
  RVA=0x09ADDEB0  token=0x60006B0  System.Void _InitIfNot()
  RVA=0x09ADDDCC  token=0x60006B1  System.Void UpdateScrollbars(UnityEngine.Vector2 offset)
  RVA=0x09ADDACC  token=0x60006B2  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x09ADE0B0  token=0x60006B3  System.Void _UpdateNonUnifiedScrollbars()
  RVA=0x09ADDB3C  token=0x60006B4  System.Void SetHorizontalNormalizedPosition(System.Single value)
  RVA=0x09ADDC7C  token=0x60006B5  System.Void SetVerticalNormalizedPosition(System.Single value)
  RVA=0x09ADDFF8  token=0x60006B6  System.Void _OnPostLayout()
  RVA=0x03D4D8F0  token=0x60006B7  System.Void .ctor()
  RVA=0x09ADDDC4  token=0x60006B8  System.Void <>iFixBaseProxy_UpdateScrollbars(UnityEngine.Vector2 P0)
  RVA=0x09ADDDBC  token=0x60006B9  System.Void <>iFixBaseProxy_Rebuild(UnityEngine.UI.CanvasUpdate P0)
  RVA=0x04274DE0  token=0x60006BA  System.Void <>iFixBaseProxy_SetHorizontalNormalizedPosition(System.Single P0)
  RVA=0x04274DEC  token=0x60006BB  System.Void <>iFixBaseProxy_SetVerticalNormalizedPosition(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UINumberScrollTween
TYPE:  class
TOKEN: 0x20000C9
SIZE:  0xA0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            Beyond.UI.UIText                bindingUIText  // 0x68
  public            System.Single                   tweenDuration  // 0x70
  public            System.Boolean                  useCustomNumberTweenCurve  // 0x74
  public            UnityEngine.AnimationCurve      numberTweenCurve  // 0x78
  private           System.String                   m_tweenToText  // 0x80
  private           System.Single                   m_tweenStartTime  // 0x88
  private           System.Single                   m_curTime  // 0x8c
  private           System.Boolean                  m_inTransition  // 0x90
  private           System.Single                   m_fromNumber  // 0x94
  private           System.Single                   m_toNumber  // 0x98
PROPERTIES:
  tickOption  get=0x03D55800
  tweenToText  get=0x03D4EAE0  set=0x09ADE788
  text  get=0x09ADE620  set=0x09ADE6D4
METHODS:
  RVA=0x09ADE228  token=0x60006C1  System.Void Start()
  RVA=0x09ADE2B8  token=0x60006C2  System.Void Tick(System.Single deltaTime)
  RVA=0x09ADE4D0  token=0x60006C3  System.Void _TweenToTarget(System.String targetText)
  RVA=0x09ADE388  token=0x60006C4  System.Void _CleanupBeforeTween()
  RVA=0x09ADE3D8  token=0x60006C5  System.Void _HandleNumberScrollTween(System.Single fromNumber, System.Single toNumber, System.Single curTime)
  RVA=0x09ADE5D4  token=0x60006C6  System.Void .ctor()
  RVA=0x0577D7BC  token=0x60006C7  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIPCScaleHelper
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            UnityEngine.Vector3             baseScale  // 0x18
METHODS:
  RVA=0x037E5E00  token=0x60006C8  System.Void OnEnable()
  RVA=0x038567F0  token=0x60006C9  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRawImage
TYPE:  class
TOKEN: 0x20000CB
SIZE:  0x100
EXTENDS: UnityEngine.UI.RawImage
FIELDS:
METHODS:
  RVA=0x02700700  token=0x60006CA  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRegionBuildingTexManager
TYPE:  class
TOKEN: 0x20000CC
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.Shader              _regionMapShader  // 0x18
  public            UnityEngine.Texture2D           minimapOutlineTex  // 0x20
  private   static  System.Int32                    s_buildingOutlineTex  // static @ 0x0
  private           UnityEngine.Renderer            m_meshRenderer  // 0x28
  private   static  UnityEngine.MaterialPropertyBlocks_materialPropertyBlock  // static @ 0x8
PROPERTIES:
  materialPropertyBlock  get=0x02D14AF0
METHODS:
  RVA=0x02D147A0  token=0x60006CC  System.Void OnEnable()
  RVA=0x09ADE790  token=0x60006CD  System.Void OnValidate()
  RVA=0x02D146C0  token=0x60006CE  System.Void OnDisable()
  RVA=0x02D14920  token=0x60006CF  System.Void _UpdateTexture(UnityEngine.Renderer meshRenderer, UnityEngine.Shader minimapTerrainShader, UnityEngine.Texture2D buildingTex)
  RVA=0x0426FE60  token=0x60006D0  System.Void .ctor()
  RVA=0x03D22A30  token=0x60006D1  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIScaleHolder
TYPE:  class
TOKEN: 0x20000CD
SIZE:  0xA0
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.RectTransform       m_rectTransform  // 0x68
  private           UnityEngine.RectTransform       m_parentTransform  // 0x70
  private           System.Boolean                  m_holdValid  // 0x78
  private           UnityEngine.Vector3             _extraScale  // 0x7c
  private           System.Boolean                  _onlyHoldOnEnable  // 0x88
  public            UnityEngine.RectTransform       referenceTransform  // 0x90
  public            System.Single                   animationExtraScale  // 0x98
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x024A45B0  token=0x60006D3  System.Void OnAwake()
  RVA=0x03476030  token=0x60006D4  System.Void OnEnable()
  RVA=0x02E53340  token=0x60006D5  System.Void LateTick(System.Single deltaTime)
  RVA=0x02342F90  token=0x60006D6  System.Boolean _IsValidScale(UnityEngine.Vector3 scale)
  RVA=0x02342A70  token=0x60006D7  System.Void _HoldScale()
  RVA=0x09ADE880  token=0x60006D8  System.Void SetExtraScale(UnityEngine.Vector3 extraScale)
  RVA=0x0338E990  token=0x60006D9  UnityEngine.Vector3 GetExtraScale()
  RVA=0x028461E0  token=0x60006DA  System.Void .ctor()
  RVA=0x058E2A30  token=0x60006DB  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x60006DC  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x60006DD  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollbar
TYPE:  class
TOKEN: 0x20000CE
SIZE:  0x1C8
EXTENDS: UnityEngine.UI.Scrollbar
FIELDS:
METHODS:
  RVA=0x03D1C370  token=0x60006DE  System.Void Awake()
  RVA=0x02849090  token=0x60006DF  System.Void .ctor()
  RVA=0x09AAE8DC  token=0x60006E0  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UIScrollbarKeyHint
TYPE:  class
TOKEN: 0x20000CF
SIZE:  0x78
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x68
  private           Beyond.UI.UIImage               m_image  // 0x70
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AE4DA0  token=0x60006E2  System.Void OnAwake()
  RVA=0x09AE4E50  token=0x60006E3  System.Void Tick(System.Single deltaTime)
  RVA=0x02846010  token=0x60006E4  System.Void .ctor()
  RVA=0x058E2A30  token=0x60006E5  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x60006E6  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollCircle
TYPE:  class
TOKEN: 0x20000D0
SIZE:  0xF8
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.EventSystems.IInitializePotentialDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IScrollHandler UnityEngine.UI.ICanvasElement Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           UnityEngine.GameObject          _cellTemplate  // 0x68
  private           System.Int32                    _totalNum  // 0x70
  private           System.Single                   _tweenTime  // 0x74
  private           UnityEngine.RectTransform       m_Viewport  // 0x78
  private           System.Single                   m_Elasticity  // 0x80
  private           System.Single                   _speedFactor  // 0x84
  private           System.Int32                    <count>k__BackingField  // 0x88
  public            UnityEngine.Events.UnityEvent<System.Int32,System.Int32,System.Boolean>onCenterIndexChanged  // 0x90
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0x98
  private           UnityEngine.Vector2             m_PointerStartLocalCursor  // 0xa0
  private           UnityEngine.Vector2             m_tmpDragPosition  // 0xa8
  private           System.Boolean                  m_Dragging  // 0xb0
  private           System.Boolean                  m_inited  // 0xb1
  private           System.Single                   m_Velocity  // 0xb4
  private           UnityEngine.Vector2             m_curScreenPos  // 0xb8
  private           UnityEngine.RectTransform       m_ViewRect  // 0xc0
  private           Beyond.UI.LuaPanel              m_panel  // 0xc8
  private           System.Single                   m_radius  // 0xd0
  private           System.Single                   m_cellAngle  // 0xd4
  private           System.Collections.Generic.List<Beyond.UI.UIScrollCircle.Cell>m_showingCells  // 0xd8
  private           System.Single                   m_rangeMax  // 0xe0
  private           System.Single                   m_curAngle  // 0xe4
  private           System.Single                   m_lastAngle  // 0xe8
  private           System.Int32                    m_curCenterIndex  // 0xec
  private           DG.Tweening.Tween               m_tween  // 0xf0
PROPERTIES:
  tickOption  get=0x03D55B70
  elasticity  get=0x03D51B00  set=0x03D56E80
  count  get=0x03D4F0B0  set=0x03D4F0E0
  velocity  get=0x03D57F30  set=0x03D57FB0
  panel  get=0x09AE0618
  viewRect  get=0x09AE06DC
METHODS:
  RVA=0x09ADF150  token=0x60006F0  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ADEA64  token=0x60006F1  System.Boolean IsActive()
  RVA=0x09ADEC48  token=0x60006F2  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ADF0E4  token=0x60006F3  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ADEE00  token=0x60006F4  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE03E8  token=0x60006F5  System.Void _UpdateSpeed()
  RVA=0x09ADF514  token=0x60006F6  System.Boolean _CheckCanMove(System.Single deltaAngle)
  RVA=0x09ADFE6C  token=0x60006F7  System.Void _TryUpdateCells()
  RVA=0x09ADFEF0  token=0x60006F8  System.Void _UpdateAuto()
  RVA=0x09ADF1BC  token=0x60006F9  System.Void OnRelease()
  RVA=0x09ADF77C  token=0x60006FA  System.Single _GetDeltaAngle(UnityEngine.Vector2 position)
  RVA=0x09ADF9B8  token=0x60006FB  System.Void _InitCells()
  RVA=0x09ADFC64  token=0x60006FC  System.Void _Init()
  RVA=0x09ADFD58  token=0x60006FD  System.Void _OnAwakeInit()
  RVA=0x09AE01A0  token=0x60006FE  System.Void _UpdateScrollRange()
  RVA=0x09ADF944  token=0x60006FF  System.Int32 _GetRealIndex(System.Int32 index)
  RVA=0x09AE0208  token=0x6000700  System.Void _UpdateShowingCells()
  RVA=0x09AE0064  token=0x6000701  System.Void _UpdateCenterIndex(System.Boolean forceUpdate)
  RVA=0x09ADF598  token=0x6000702  System.Void _DoScroll(System.Single tmpAngle, System.Boolean direct)
  RVA=0x09ADF22C  token=0x6000703  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09ADF280  token=0x6000704  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x09ADEBA8  token=0x6000705  System.Void LayoutComplete()
  RVA=0x09ADEA20  token=0x6000706  System.Void GraphicUpdateComplete()
  RVA=0x09ADEAB4  token=0x6000707  System.Boolean IsDestroyed()
  RVA=0x09ADF060  token=0x6000708  System.Void OnEnable()
  RVA=0x09ADEDA8  token=0x6000709  System.Void OnDisable()
  RVA=0x09ADF3A0  token=0x600070A  System.Void Start()
  RVA=0x09ADEBEC  token=0x600070B  System.Void OnAwake()
  RVA=0x09ADEB34  token=0x600070C  System.Void LateTick(System.Single deltaTime)
  RVA=0x09ADF458  token=0x600070D  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  RVA=0x09ADF2D4  token=0x600070E  System.Void ScrollToIndex(System.Int32 index, System.Boolean direct)
  RVA=0x09ADE974  token=0x600070F  UnityEngine.GameObject Get(System.Int32 index)
  RVA=0x09ADE904  token=0x6000710  System.Void ClearComponent()
  RVA=0x09AE04A0  token=0x6000711  System.Void .ctor()
  RVA=0x09ADF408  token=0x6000712  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
  RVA=0x09ADF3F0  token=0x6000713  System.Void <_DoScroll>b__59_0()
  RVA=0x0577D7B4  token=0x6000714  System.Void <>iFixBaseProxy_OnRelease()
  RVA=0x058DD8AC  token=0x6000715  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x6000716  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x058E2A30  token=0x6000717  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0589E548  token=0x6000718  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollContainerFollower
TYPE:  class
TOKEN: 0x20000D2
SIZE:  0x98
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollList          _followTargetList  // 0x68
  private           Beyond.UI.UIScrollRect          _followTargetRect  // 0x70
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
  private           System.Single                   m_currentSize  // 0x80
  private           System.Boolean                  m_targetSizeChanged  // 0x84
  private           UnityEngine.Vector2             m_currentPos  // 0x88
  private           System.Boolean                  m_targetPosChanged  // 0x90
  private           System.Boolean                  m_setValid  // 0x91
  private           System.Boolean                  m_isFollowContent  // 0x92
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x09AE0A80  token=0x600071C  System.Void OnAwake()
  RVA=0x09AE0814  token=0x600071D  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AE0B68  token=0x600071E  System.Void _RefreshSizeAndPositionToTargetContainer()
  RVA=0x03CF5340  token=0x600071F  System.Void .ctor()
  RVA=0x058E2A30  token=0x6000720  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0589E548  token=0x6000721  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.ScrollDirection
TYPE:  sealed struct
TOKEN: 0x20000D3
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.ScrollDirection       Vertical  // const
  public    static  Beyond.UI.ScrollDirection       Horizontal  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIScrollList
TYPE:  class
TOKEN: 0x20000D4
SIZE:  0x278
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  protected         UnityEngine.GameObject          _cellTemplate  // 0x68
  private           Beyond.UI.ScrollDirection       _scrollDirection  // 0x70
  private           System.Boolean                  _expandCellSize  // 0x74
  private           System.Boolean                  _alsoExpandCellSizeInAnotherDirection  // 0x75
  protected         UnityEngine.Vector2             _space  // 0x78
  protected         Beyond.UI.UIScrollList.Padding  _padding  // 0x80
  protected         System.Boolean                  _ignorePaddingWhenScroll  // 0x90
  protected         System.Single                   _notCacheBufferSize  // 0x94
  protected         System.Single                   _extraCacheBufferSize  // 0x98
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xa0
  public            Beyond.DisposedUnityEvent       onGraduallyShowFinish  // 0xa8
  public            Beyond.DisposedUnityEvent       onScrollEnd  // 0xb0
  public            Beyond.DisposedUnityEvent<System.Int32>onUpdateCount  // 0xb8
  public            System.Func<System.Int32,System.String>getCellName  // 0xc0
  public    static  Beyond.DisposedUnityEvent<System.String>s_onGraduallyShowFinish  // static @ 0x0
  protected         System.Boolean                  _inverse  // 0xc8
  protected         System.Boolean                  _autoLayoutWhenFew  // 0xc9
  protected         Beyond.UI.UIScrollList.AutoLayoutWhenFewType_autoLayoutWhenFewType  // 0xcc
  protected         System.Boolean                  _autoCenterInOtherDir  // 0xd0
  private           UnityEngine.Transform           _centerNode  // 0xd8
  private           System.Boolean                  _hideRayCastWhenLessThanOnePage  // 0xe0
  private           System.Boolean                  _clampWhenLessThanOnePage  // 0xe1
  private           UnityEngine.UI.ScrollRect.MovementTypem_lastScrollRectMovementType  // 0xe4
  protected         UnityEngine.RectTransform       _container  // 0xe8
  protected         Beyond.UI.UIScrollRect          _scrollRect  // 0xf0
  private           System.Int32                    <count>k__BackingField  // 0xf8
  private           System.Single                   <containerSizeWithoutAutoLayout>k__BackingField  // 0xfc
  protected         UnityEngine.RectTransform       m_rect  // 0x100
  protected         System.Int32                    m_countPerLine  // 0x108
  protected         System.Int32                    m_maxShowingLine  // 0x10c
  protected         System.Int32                    m_maxShowingCellCount  // 0x110
  protected         System.Int32                    m_maxCellCountWhenNoScroll  // 0x114
  protected         System.Single                   m_viewWidth  // 0x118
  protected         System.Single                   m_viewHeight  // 0x11c
  protected         System.Single                   m_cellWidth  // 0x120
  protected         System.Single                   m_cellHeight  // 0x124
  protected         UnityEngine.UI.Graphic          m_graphic  // 0x128
  protected         Beyond.UI.UIScrollList.Padding  m_realPadding  // 0x130
  private           UnityEngine.Vector3[]           m_cellCorners  // 0x140
  protected         System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollList.Cell>m_showingCells  // 0x148
  private           System.Collections.Generic.Stack<Beyond.UI.UIScrollList.Cell>m_cellCache  // 0x150
  private   static  System.String                   CACHED_CELL_GAME_OBJECT_NAME  // const
  public            UnityEngine.Events.UnityEvent   onBeginDrag  // 0x158
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x160
  public            UnityEngine.Events.UnityEvent   onEndDrag  // 0x168
  private           UnityEngine.GameObject          _moveTipsLeftOrTop  // 0x170
  private           UnityEngine.GameObject          _moveTipsRightOrBottom  // 0x178
  private           System.Single                   m_moveTipsIgnoredRange  // 0x180
  private           System.Boolean                  _useViewEffect  // 0x184
  private           System.Boolean                  _symmetricViewEffect  // 0x185
  private           System.Boolean                  _needDummyParent  // 0x186
  private           UnityEngine.AnimationCurve      _viewEffectAnimation  // 0x188
  private           UnityEngine.Vector2             _effectAnchorPoint  // 0x190
  private           System.Boolean                  _useDefaultScaleEffect  // 0x198
  private           UnityEngine.AnimationCurve      _scaleEffectAnimation  // 0x1a0
  private           System.Boolean                  _useDefaultArcEffect  // 0x1a8
  private           UnityEngine.AnimationCurve      _arcEffectAnimation  // 0x1b0
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Single>onChangeView  // 0x1b8
  protected         System.Single                   _tweenDuration  // 0x1c0
  protected         DG.Tweening.Ease                _tweenEase  // 0x1c4
  protected         System.Single                   _changeStepRatio  // 0x1c8
  protected         DG.Tweening.Tween               m_adjustTween  // 0x1d0
  protected         System.Single                   m_totalLength  // 0x1d8
  protected         System.Single                   m_cellLength  // 0x1dc
  protected         UnityEngine.Vector2             m_centerPos  // 0x1e0
  public            System.Boolean                  enableAutoScroll  // 0x1e8
  private           System.Single                   _startAutoScrollTime  // 0x1ec
  private           System.Single                   _autoScrollSpeed  // 0x1f0
  public            Beyond.UI.UIArea                autoScrollUpArea  // 0x1f8
  public            Beyond.UI.UIArea                autoScrollDownArea  // 0x200
  private           System.Single                   m_curAutoScrollSpd  // 0x208
  private           System.Int32                    m_autoScrollTimerKey  // 0x20c
  private           System.Boolean                  _enableGraduallyShow  // 0x210
  private           System.Single                   _graduallyShowTime  // 0x214
  private           System.Single                   _graduallyShowDelayTime  // 0x218
  protected         System.Boolean                  m_inGraduallyShow  // 0x21c
  private           System.Single                   m_graduallyShowedMaxIndex  // 0x220
  protected         System.Single                   m_curGraduallyCanShowMaxIndex  // 0x224
  private           System.Boolean                  m_needInformAnimationInEnd  // 0x228
  private   static  System.Single                   GRADUALLY_SHOW_UPDATE_MAX_INTERVAL  // const
  public    static  System.Int32                    s_maxGraduallyShowAddCountPerFrame  // static @ 0x8
  private           System.Boolean                  _enableSelectedNavigation  // 0x229
  private           System.Boolean                  _noNavigationKeyHint  // 0x22a
  private           System.Boolean                  _enableNavigationLoop  // 0x22b
  private           System.Boolean                  _customNavigationActionId  // 0x22c
  private           System.String                   _customNavigationPreviousActionId  // 0x230
  private           System.String                   _customNavigationNextActionId  // 0x238
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32>onSelectedCell  // 0x240
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Boolean>onCellSelectedChanged  // 0x248
  public            System.Func<System.Int32>       getCurSelectedIndex  // 0x250
  private           System.Int32                    m_curSelectedIndex  // 0x258
  private           System.Int32                    m_bindingGroupId  // 0x25c
  private           System.Int32                    m_naviBindingGroupId  // 0x260
  protected         System.Boolean                  _enableWrapNavigation  // 0x264
  protected         System.Boolean                  _enableCircleWrapNavigation  // 0x265
  private           System.Boolean                  _clearNaviGroupOnUpdateCount  // 0x266
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x268
  private           Beyond.UI.LuaPanel              m_panel  // 0x270
PROPERTIES:
  tickOption  get=0x03D55740
  space  get=0x03D588C0
  autoLayoutWhenFew  get=0x03D58400
  isHorizontal  get=0x028C2600
  isVertical  get=0x028C30B0
  count  get=0x03D6C5F0  set=0x03D6C600
  containerSizeWithoutAutoLayout  get=0x03D56ED0  set=0x03D56F50
  isMultiPage  get=0x028C29B0
  maxShowingCellCount  get=0x03D5D640
  countPerLine  get=0x03D5CB40
  cellWidth  get=0x03D583D0
  cellHeight  get=0x03D578F0
  currentStep  get=0x028C2520  set=0x09AE4098
  moveTips  get=0x028C2CC0
  curSelectedIndex  get=0x09AE3F60  set=0x09AE3FF0
  curSelectedObj  get=0x09AE3FCC
  enableSelectedNavigation  get=0x03D76140
  naviBindingGroupId  get=0x03D5ADD0
  panel  get=0x03080C00
METHODS:
  RVA=0x03B33DB0  token=0x6000730  System.Void OnAwake()
  RVA=0x0307F5E0  token=0x6000731  System.Void Tick(System.Single deltaTime)
  RVA=0x030FE560  token=0x6000732  System.Void LateTick(System.Single deltaTime)
  RVA=0x0307F540  token=0x6000733  System.Void OnEnable()
  RVA=0x030807B0  token=0x6000734  System.Void OnDisable()
  RVA=0x030FE5B0  token=0x6000735  System.Void TryRecalculateSize()
  RVA=0x02D9D090  token=0x6000736  System.Void _InGameAwake()
  RVA=0x09AE3448  token=0x6000737  System.Void _EditorAwake()
  RVA=0x02D9B5B0  token=0x6000738  System.Void Init(System.Boolean isPreview)
  RVA=0x038014A0  token=0x6000739  System.Void InitConfig()
  RVA=0x02D9AC60  token=0x600073A  System.Void InitBasicInfo()
  RVA=0x02D9ACA0  token=0x600073B  System.Void SyncViewSize()
  RVA=0x036D16A0  token=0x600073C  System.Void CalcSomeCountNum()
  RVA=0x036D1720  token=0x600073D  System.Int32 _GetLineCount(System.Boolean calcVertical)
  RVA=0x028C1F00  token=0x600073E  System.Void OnScroll(UnityEngine.Vector2 v)
  RVA=0x09AE3138  token=0x600073F  System.Void SetTop(System.Boolean needUpdate)
  RVA=0x02D9AB80  token=0x6000740  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow)
  RVA=0x02D9AF40  token=0x6000741  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x02D99C60  token=0x6000742  System.Void UpdateCount(System.Int32 newCount)
  RVA=0x038C0380  token=0x6000743  System.Void UpdateShowingCells(System.Action<System.Int32,UnityEngine.GameObject> updateFunc)
  RVA=0x02D9B4F0  token=0x6000744  System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount)
  RVA=0x02D9B380  token=0x6000745  System.Void _SetRealPadding(System.Boolean isVerticalPadding, System.Single firstAddedLength, System.Single secondAddedLength)
  RVA=0x02D9B1A0  token=0x6000746  System.Void UpdateContainerSize()
  RVA=0x02D9B410  token=0x6000747  System.Single GetContainerSize(System.Boolean ignoreAutoLayout)
  RVA=0x02D9B7C0  token=0x6000748  System.Void SetContainerSize(System.Single size)
  RVA=0x02D999C0  token=0x6000749  System.Void ClearShowingCells()
  RVA=0x028C30C0  token=0x600074A  System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive)
  RVA=0x028C29C0  token=0x600074B  System.Void UpdateCell(System.Int32 index, System.Boolean forceUpdateContent, System.Boolean ignoreListActive)
  RVA=0x028C2EC0  token=0x600074C  UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow)
  RVA=0x09AE1424  token=0x600074D  UnityEngine.Vector2Int GetRangeInView()
  RVA=0x028C2050  token=0x600074E  UnityEngine.Vector2Int GetNotCacheRange()
  RVA=0x028C2DD0  token=0x600074F  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  RVA=0x09AE27D0  token=0x6000750  System.Void SetCellCanCache(System.Int32 index, System.Boolean canCache)
  RVA=0x0382FBE0  token=0x6000751  System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  RVA=0x02BDD480  token=0x6000752  Beyond.UI.UIScrollList.Cell GetCell()
  RVA=0x09AE0F74  token=0x6000753  System.Void CacheShowingCell(System.Int32 index)
  RVA=0x09AE0EAC  token=0x6000754  System.Void CacheCell(Beyond.UI.UIScrollList.Cell cell)
  RVA=0x09AE2F0C  token=0x6000757  System.Void SetStepTo(System.Single step)
  RVA=0x09AE2370  token=0x6000758  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE23D8  token=0x6000759  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE2464  token=0x600075A  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x028C1F70  token=0x600075C  System.Void _UpdateMoveTips()
  RVA=0x028C18D0  token=0x600075D  System.Void UpdateViewEffect()
  RVA=0x09AE1A14  token=0x600075E  UnityEngine.GameObject Get(System.Int32 index)
  RVA=0x09AE1044  token=0x600075F  Beyond.UI.UIScrollList.Cell GetCell(System.Int32 index)
  RVA=0x02D9AC20  token=0x6000760  System.Int32 GetRealIndex(System.Int32 index)
  RVA=0x03D07E00  token=0x6000761  System.Void OnRelease()
  RVA=0x039C0540  token=0x6000762  System.Void ClearComponent()
  RVA=0x09AE28FC  token=0x6000763  System.Void SetPaddingBottom(System.Single value)
  RVA=0x09AE2A64  token=0x6000764  System.Void SetPaddingTop(System.Single value)
  RVA=0x09AE29EC  token=0x6000765  System.Void SetPaddingRight(System.Single value)
  RVA=0x09AE2974  token=0x6000766  System.Void SetPaddingLeft(System.Single value)
  RVA=0x09AE2ADC  token=0x6000767  System.Void SetPadding(UnityEngine.Rect value)
  RVA=0x03A1A490  token=0x6000768  Beyond.UI.UIScrollList.Padding GetPadding()
  RVA=0x09AE18D8  token=0x6000769  System.Void GetShowingCellsIndexRange(System.Int32& firstIndex, System.Int32& lastIndex)
  RVA=0x09AE2E54  token=0x600076A  System.Void SetSpace(UnityEngine.Vector2 newSpace)
  RVA=0x09AE26DC  token=0x600076B  System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode)
  RVA=0x03080420  token=0x600076C  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x03080640  token=0x600076D  System.Void _ScrollToPos(System.Single targetPos, System.Boolean fastMode)
  RVA=0x030808E0  token=0x600076E  System.Void TryClearAdjustTween()
  RVA=0x028C17A0  token=0x600076F  System.Single GetCenterIndex()
  RVA=0x03080490  token=0x6000770  System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  RVA=0x02D9B8A0  token=0x6000771  System.Void _InitAutoScroll()
  RVA=0x09AE3C88  token=0x6000772  System.Void _OnEnterAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE3E54  token=0x6000773  System.Void _OnExitAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE3B60  token=0x6000774  System.Void _OnEnterAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE3DB0  token=0x6000775  System.Void _OnExitAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE3EF8  token=0x6000776  System.Void _SetAutoScrollSpd(System.Single spd)
  RVA=0x0307F640  token=0x6000777  System.Void _UpdateAutoScroll(System.Single deltaTime)
  RVA=0x02D99CC0  token=0x6000778  System.Void RestartGraduallyShow()
  RVA=0x03080AF0  token=0x6000779  System.Void _StartGraduallyShow()
  RVA=0x0307F6A0  token=0x600077A  System.Void _UpdateGraduallyShow(System.Single deltaTime)
  RVA=0x09AE31F8  token=0x600077B  System.Void SkipGraduallyShow()
  RVA=0x03080920  token=0x600077C  System.Void StopGraduallyShow()
  RVA=0x039D1210  token=0x6000782  System.Void _InitNavigation()
  RVA=0x09AE22D8  token=0x6000783  System.Void NavigateSelected(UnityEngine.UI.NaviDirection dir)
  RVA=0x09AE12D4  token=0x6000784  System.Int32 GetNaviOffset(UnityEngine.UI.NaviDirection dir)
  RVA=0x09AE1230  token=0x6000785  System.Int32 GetNaviNewIndex(System.Int32 oldIndex, UnityEngine.UI.NaviDirection dir)
  RVA=0x09AE2BD0  token=0x6000786  System.Void SetSelectedIndex(System.Int32 index, System.Boolean needNotify, System.Boolean forceUpdate, System.Boolean needScroll)
  RVA=0x09AE1AD8  token=0x6000787  System.Void ListWrapNavigate(UnityEngine.UI.NaviDirection dir)
  RVA=0x02D9B9D0  token=0x6000788  System.Void _InitControllerNavi()
  RVA=0x09AE3390  token=0x6000789  System.Void _ClearRelatedNaviGroup()
  RVA=0x09AE117C  token=0x600078B  System.Int32 GetMousePosIndex(UnityEngine.UI.NaviDirection dir)
  RVA=0x09AE24CC  token=0x600078C  System.Int32 ScreenPos2Index(UnityEngine.Vector2 targetScreenPos, UnityEngine.UI.NaviDirection dir)
  RVA=0x09AE3968  token=0x600078D  System.Void _GetScreenPosLineColumnInfo(UnityEngine.Vector2 targetScreenPos, System.Int32& line, System.Int32& column)
  RVA=0x09AE10FC  token=0x600078E  System.Int32 GetIndexOf(System.Int32 column, System.Int32 line)
  RVA=0x02847980  token=0x600078F  System.Void .ctor()
  RVA=0x03CBC740  token=0x6000790  System.Void .cctor()
  RVA=0x09AE32BC  token=0x6000791  System.Single <_ScrollToPos>b__158_0()
  RVA=0x09AE32E0  token=0x6000792  System.Void <_ScrollToPos>b__158_1(System.Single x)
  RVA=0x09AE3308  token=0x6000793  System.Void <_ScrollToPos>b__158_2()
  RVA=0x09AE3344  token=0x6000794  System.Single <_ScrollToPos>b__158_3()
  RVA=0x09AE3368  token=0x6000795  System.Void <_ScrollToPos>b__158_4(System.Single y)
  RVA=0x09AE3308  token=0x6000796  System.Void <_ScrollToPos>b__158_5()
  RVA=0x09AE32A4  token=0x6000797  System.Void <_OnEnterAutoScrollUp>b__171_0()
  RVA=0x09AE3294  token=0x6000798  System.Void <_OnEnterAutoScrollDown>b__173_0()
  RVA=0x09AE3254  token=0x6000799  System.Void <_InitNavigation>b__212_0()
  RVA=0x09AE3264  token=0x600079A  System.Void <_InitNavigation>b__212_1()
  RVA=0x09AE3274  token=0x600079B  System.Void <_InitNavigation>b__212_2()
  RVA=0x09AE3284  token=0x600079C  System.Void <_InitNavigation>b__212_3()
  RVA=0x09AE3274  token=0x600079D  System.Void <_InitNavigation>b__212_4()
  RVA=0x09AE3284  token=0x600079E  System.Void <_InitNavigation>b__212_5()
  RVA=0x09AE3254  token=0x600079F  System.Void <_InitNavigation>b__212_6()
  RVA=0x09AE3264  token=0x60007A0  System.Void <_InitNavigation>b__212_7()
  RVA=0x058E2A30  token=0x60007A1  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x60007A2  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0589E548  token=0x60007A3  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x058DD8AC  token=0x60007A4  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x60007A5  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0577D7B4  token=0x60007A6  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.AutoScrollStrategy
TYPE:  sealed struct
TOKEN: 0x20000DB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.AutoScrollStrategy    None  // const
  public    static  Beyond.UI.AutoScrollStrategy    AlignNearbyBound  // const
  public    static  Beyond.UI.AutoScrollStrategy    AlignCenter  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIScrollRect
TYPE:  class
TOKEN: 0x20000DC
SIZE:  0x1D8
EXTENDS: UnityEngine.UI.ScrollRect
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>m_scrollTween  // 0x150
  public            System.Single                   smoothScrollTweenSpd  // 0x158
  public            DG.Tweening.Ease                smoothScrollTweenEase  // 0x15c
  private           System.Boolean                  m_lastUpdateIsDragging  // 0x160
  private           Beyond.UI.LuaPanel              m_panel  // 0x168
  protected         System.Single                   _stickScrollSpeed  // 0x170
  protected         System.Single                   _stickScrollTolerance  // 0x174
  protected         Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x178
  protected         System.Boolean                  _enableWrapNavigation  // 0x180
  protected         Beyond.Input.InputBindingGroupMonoTarget_scrollBindingGroup  // 0x188
  public            System.Boolean                  controllerScrollEnabled  // 0x190
  private           System.Boolean                  m_controllerInited  // 0x191
  private           System.Boolean                  m_navigationWrapped  // 0x192
  protected         Beyond.UI.AutoScrollStrategy    _autoScrollStrategy  // 0x194
  protected         System.Single                   _alignBoundPaddingX  // 0x198
  protected         System.Single                   _alignBoundPaddingY  // 0x19c
  private           UnityEngine.GameObject          _moveTipsLeftOrTop  // 0x1a0
  private           UnityEngine.GameObject          _moveTipsRightOrBottom  // 0x1a8
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x1b0
  private           System.Boolean                  _enableOverScrollEffect  // 0x1b8
  private           System.Single                   _overScrollTriggerValue  // 0x1bc
  private           UnityEngine.GameObject          _overScrollEffectPrevNode  // 0x1c0
  private           UnityEngine.GameObject          _overScrollEffectNextNode  // 0x1c8
  public            Beyond.DisposedUnityEvent<System.Boolean>onOverScrollEffect  // 0x1d0
PROPERTIES:
  inScrollTween  get=0x09AE4B28
  contentStartPosition  get=0x03D6B170  set=0x03D50F10
  dragging  get=0x03D58140
  controllerStickScrollEnabled  get=0x09AE4A7C
  panel  get=0x09AE4CDC
  naviGroup  get=0x03D56A70
  moveTips  get=0x09AE4B9C
METHODS:
  RVA=0x02D9D3B0  token=0x60007AC  System.Void Awake()
  RVA=0x034CF9E0  token=0x60007AD  System.Void OnEnable()
  RVA=0x03005DA0  token=0x60007AE  System.Void Update()
  RVA=0x034E4FB0  token=0x60007AF  System.Void ScrollTo(UnityEngine.Vector2 position, System.Boolean noTween)
  RVA=0x09AE40D4  token=0x60007B0  System.Boolean IsCellViewed(UnityEngine.RectTransform cell)
  RVA=0x03C8B720  token=0x60007B1  System.Void OnDestroy()
  RVA=0x028C0DB0  token=0x60007B2  System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position)
  RVA=0x030C0F80  token=0x60007B3  System.Void UpdateScrollEnableNode()
  RVA=0x09AE41C0  token=0x60007B4  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE4250  token=0x60007B5  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE42E0  token=0x60007B6  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0397B840  token=0x60007B7  System.Void ClearComponent()
  RVA=0x0284F320  token=0x60007B9  System.Void LateUpdate()
  RVA=0x03005DF0  token=0x60007BD  System.Void _TickRefreshControllerStickScroll()
  RVA=0x034E51B0  token=0x60007BE  System.Void ScrollToNaviTarget(UnityEngine.UI.Selectable target)
  RVA=0x09AE4388  token=0x60007BF  System.Void RectWrapNavigate(UnityEngine.UI.NaviDirection dir)
  RVA=0x034CFA20  token=0x60007C0  System.Void _InitController()
  RVA=0x02D99E10  token=0x60007C1  System.Void WrapNavigation(UnityEngine.Events.UnityAction<UnityEngine.UI.NaviDirection> wrapper)
  RVA=0x034E5280  token=0x60007C2  System.Void AutoScrollToRectTransform(UnityEngine.RectTransform target, System.Boolean noTween)
  RVA=0x03005EB0  token=0x60007C4  System.Void _UpdateMoveTips()
  RVA=0x09AE4838  token=0x60007C5  UnityEngine.Camera _GetUICamera()
  RVA=0x0358C870  token=0x60007C6  System.Void _CheckOverScrollEffect(UnityEngine.Vector2 value)
  RVA=0x09AE465C  token=0x60007C7  System.Void _CheckOverScrollOnEndDrag(UnityEngine.Vector2 value)
  RVA=0x0284A3C0  token=0x60007C8  System.Void .ctor()
  RVA=0x0350B670  token=0x60007C9  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AE463C  token=0x60007CA  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0350B670  token=0x60007CB  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09AE4654  token=0x60007CC  System.Void <>iFixBaseProxy__CustomSetPosOnScroll(UnityEngine.Vector2 P0)
  RVA=0x09AE464C  token=0x60007CD  System.Void <>iFixBaseProxy_UpdateScrollEnableNode()
  RVA=0x09AE462C  token=0x60007CE  System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AE4634  token=0x60007CF  System.Void <>iFixBaseProxy_OnDrag(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AE4644  token=0x60007D0  System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AE4624  token=0x60007D1  System.Void <>iFixBaseProxy_LateUpdate()
END_CLASS

CLASS: Beyond.UI.UIScrollRectEdgeRedDot
TYPE:  class
TOKEN: 0x20000DF
SIZE:  0xE8
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           Beyond.UI.UIScrollRect          m_uiScrollRect  // 0x68
  private           UnityEngine.RectTransform       m_uiScrollRectTransform  // 0x70
  private           Beyond.UI.UIScrollList          m_uiScrollList  // 0x78
  private           UnityEngine.UI.RectMask2D       m_rectMask2D  // 0x80
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo>m_redDotInfoDict  // 0x88
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState>m_redDotStateDict  // 0x90
  private           UnityEngine.Vector2Int          m_scrollListShowRange  // 0x98
  public            System.Func<System.Int32,System.Int32>getRedDotStateAt  // 0xa0
  private           Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStatem_upRedDotState  // 0xa8
  private           Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStatem_downRedDotState  // 0xac
  private           UnityEngine.GameObject          _upNormal  // 0xb0
  private           UnityEngine.GameObject          _upNew  // 0xb8
  private           UnityEngine.GameObject          _downNormal  // 0xc0
  private           UnityEngine.GameObject          _downNew  // 0xc8
  private           UnityEngine.RectTransform       _upParent  // 0xd0
  private           UnityEngine.RectTransform       _downParent  // 0xd8
  private           System.Single                   _upEdgeOffset  // 0xe0
  private           System.Single                   _downEdgeOffset  // 0xe4
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AE6A70  token=0x60007D6  System.Void OnAwake()
  RVA=0x09AE6ACC  token=0x60007D7  System.Void OnEnable()
  RVA=0x09AE6C98  token=0x60007D8  System.Void OnRelease()
  RVA=0x09AE7548  token=0x60007D9  System.Void Tick(System.Single deltaTime)
  RVA=0x09AE738C  token=0x60007DA  System.Void ResetReferences()
  RVA=0x09AE7108  token=0x60007DB  System.Void ResetRedDotPosition()
  RVA=0x09AE8030  token=0x60007DC  System.Void _UpdateCacheDictForRangeChange(UnityEngine.Vector2Int newRange)
  RVA=0x09AE7F98  token=0x60007DD  System.Void _OnScrollListUpdateCount(System.Int32 newCount)
  RVA=0x09AE6F50  token=0x60007DE  System.Void RegisterRedDot(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew)
  RVA=0x09AE76B4  token=0x60007DF  System.Void UnregisterRedDot(UnityEngine.GameObject redDotRoot)
  RVA=0x09AE6DC4  token=0x60007E0  System.Void RegisterRedDotStatesForScrollList()
  RVA=0x09AE7774  token=0x60007E1  System.Void UpdateRedDotStateInDir()
  RVA=0x09AE7840  token=0x60007E2  System.Void _CalculateRedDotStateInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& upState, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& downState)
  RVA=0x09AE8220  token=0x60007E3  System.Void _UpdateRedDotGameObjects(UnityEngine.GameObject normal, UnityEngine.GameObject newer, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state)
  RVA=0x09AE684C  token=0x60007E4  System.Boolean IsRedDotInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir dir, Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo redDotInfo)
  RVA=0x09AE67F0  token=0x60007E5  System.Void ClearComponent()
  RVA=0x09AE83C0  token=0x60007E6  System.Void .ctor()
  RVA=0x058E2A30  token=0x60007E7  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x60007E8  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7B4  token=0x60007E9  System.Void <>iFixBaseProxy_OnRelease()
  RVA=0x0577D7BC  token=0x60007EA  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollText
TYPE:  class
TOKEN: 0x20000E3
SIZE:  0xC8
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           System.Single                   _speed  // 0x68
  private           System.Single                   _stayTime  // 0x6c
  private           System.Single                   _fadeTime  // 0x70
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x78
  private           Beyond.UI.UIScrollText.ScrollMode_scrollMode  // 0x80
  private           System.Boolean                  _disableClipping  // 0x84
  private           System.Boolean                  m_isInited  // 0x85
  private           Beyond.UI.UIText                m_tmp  // 0x88
  private           UnityEngine.RectTransform       m_rect  // 0x90
  private           UnityEngine.RectTransform       m_parentRect  // 0x98
  private           Beyond.UI.UIScrollText.IScrollHandlerm_scrollHandler  // 0xa0
  private           Beyond.UI.UIScrollText.IAlphaHandlerm_alphaHandler  // 0xa8
  private           Beyond.UI.UIScrollText.ScrollStatem_state  // 0xb0
  private           System.Single                   m_scrollOffset  // 0xb4
  private           System.Single                   m_currStateTime  // 0xb8
  private           System.Boolean                  m_needScroll  // 0xbc
  private           System.Single                   m_textDiff  // 0xc0
  private           TMPro.TextAlignmentOptions      m_originalAlignment  // 0xc4
PROPERTIES:
  tickOption  get=0x03D55B70
METHODS:
  RVA=0x09AE88A0  token=0x60007F2  System.Void _InitIfNot()
  RVA=0x09AE8628  token=0x60007F3  System.Void ResetTextScroll()
  RVA=0x09AE8B3C  token=0x60007F4  System.Void _ResetTextScrollInternal(System.Boolean needScroll, System.Single textDiff)
  RVA=0x09AE85CC  token=0x60007F5  System.Void OnAwake()
  RVA=0x09AE83E4  token=0x60007F6  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AE8C58  token=0x60007F7  System.Void _UpdateScrollState(System.Single deltaTime, System.Single textDiff)
  RVA=0x09AE8BF4  token=0x60007F8  System.Void _ResetTextScroll()
  RVA=0x09AE8764  token=0x60007F9  System.Void _ApplyTextAlignment(System.Boolean isScroll)
  RVA=0x09AE8834  token=0x60007FA  System.Void _ApplyTextScroll(System.Single scrollOffset)
  RVA=0x09AE8ED8  token=0x60007FB  System.Void .ctor()
  RVA=0x058E2A30  token=0x60007FC  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0589E548  token=0x60007FD  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISelectableNaviGroup
TYPE:  class
TOKEN: 0x20000EB
SIZE:  0x130
EXTENDS: UnityEngine.UI.SelectableNaviGroup
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  public            System.Collections.Generic.List<Beyond.Input.InputBindingGroupMonoTarget>relatedInputBindingGroups  // 0xa0
  public            System.Func<UnityEngine.UI.Selectable>getDefaultSelectableFunc  // 0xa8
  public            System.Func<System.Boolean>     canFocusFun  // 0xb0
  public            System.String                   focusActionId  // 0xb8
  public            System.String                   stopFocusActionId  // 0xc0
  public            System.Boolean                  hideItemTipsOnUnFocus  // 0xc8
  public            System.Boolean                  useDefaultTargetOnFocus  // 0xc9
  public            System.Boolean                  useFocusHighlight  // 0xca
  public            System.Boolean                  focusHighlightMask  // 0xcb
  public            System.Boolean                  focusHighlightNormalFrame  // 0xcc
  public            System.Boolean                  focusHighlightDarkFrame  // 0xcd
  public            UnityEngine.RectTransform       focusOverrideHighlightRect  // 0xd0
  public            System.Int32                    focusPanelSortingOrder  // 0xd8
  public            Beyond.UI.UIActionKeyHint       focusActionKeyHint  // 0xe0
  public            Beyond.UI.UIActionKeyHint       stopFocusActionKeyHint  // 0xe8
  public            UnityEngine.Events.UnityEvent<System.Boolean>onIsFocusedChange  // 0xf0
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0xf8
  private           Beyond.Input.InputBindingGroupMonoTargetm_bindingMonoGroup  // 0x100
  private           UnityEngine.RectTransform       m_rectTransform  // 0x108
  private           UnityEngine.UI.Selectable       m_lastFocusNaviTarget  // 0x110
  private           System.String                   m_focusBindingText  // 0x118
  private           System.Int32                    m_focusBindingId  // 0x120
  private           System.Int32                    m_stopFocusBindingId  // 0x124
  private           System.Boolean                  m_focusBindingCreated  // 0x128
  private           System.Boolean                  m_isInFocusHighlight  // 0x129
  private   static  System.Int32                    INVALID_BINDING_ID  // const
PROPERTIES:
  FocusBindingId  get=0x03D5D890
  StopFocusBindingId  get=0x03D6DED0
  lastFocusNaviTarget  get=0x03D56CF0
METHODS:
  RVA=0x02A72B70  token=0x600080E  System.Void Awake()
  RVA=0x02C6F970  token=0x600080F  System.Void OnEnable()
  RVA=0x02C6D3E0  token=0x6000810  System.Void OnDisable()
  RVA=0x02C6F040  token=0x6000811  System.Void _OnIsTopLayerChanged()
  RVA=0x036B6330  token=0x6000812  System.Void _OnSelectableNaviGroupDisabled()
  RVA=0x036B6370  token=0x6000813  System.Void _BeforeSelectableNaviGroupDestroy()
  RVA=0x09AE958C  token=0x6000814  System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value)
  RVA=0x02C6FC40  token=0x6000815  System.Void _OnRemoveFromLayerStack()
  RVA=0x036BE780  token=0x6000816  System.Void NaviToThisGroup(System.Boolean forceDefault)
  RVA=0x02C6F800  token=0x6000817  System.Void _RefreshRelatedBindingGroupsState()
  RVA=0x036BE8A0  token=0x6000818  UnityEngine.UI.Selectable _FindDefaultSelectable()
  RVA=0x0304D710  token=0x6000819  System.Void OnDestroy()
  RVA=0x0304D850  token=0x600081A  System.Void ClearComponent()
  RVA=0x09AE91EC  token=0x600081B  System.Void TryChangeNaviPartnerOnUp(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  RVA=0x09AE906C  token=0x600081C  System.Void TryChangeNaviPartnerOnDown(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  RVA=0x09AE90EC  token=0x600081D  System.Void TryChangeNaviPartnerOnLeft(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  RVA=0x09AE916C  token=0x600081E  System.Void TryChangeNaviPartnerOnRight(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  RVA=0x09AE95F4  token=0x600081F  System.Void _TryChangeNaviPartner(System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> list, Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  RVA=0x02A72DD0  token=0x6000823  System.Void _InitFocusBinding()
  RVA=0x02C6EDC0  token=0x6000824  System.Void _RefreshFocusBindings()
  RVA=0x09AE8F64  token=0x6000825  System.Void RefreshFocusBindings()
  RVA=0x09AE92A0  token=0x6000826  System.Void _OnFocus(System.Boolean onlyStartHighlight)
  RVA=0x02C6FFA0  token=0x6000827  System.Void _OnStopFocus(System.Boolean onlyStopHighlight, System.Boolean ignoreTopLayerCheck)
  RVA=0x02C6FA70  token=0x6000828  System.Void _RefreshFocusActionKeyHint()
  RVA=0x02C6F9F0  token=0x6000829  System.Void _RefreshStopFocusActionKeyHint()
  RVA=0x09AE8F00  token=0x600082A  System.Void ManuallyFocus(System.Boolean onlyStartHighlight)
  RVA=0x036B63B0  token=0x600082B  System.Void ManuallyStopFocus(System.Boolean onlyStopHighlight)
  RVA=0x09AE8FB4  token=0x600082C  System.Void SetFocusBindingText(System.String bindingText)
  RVA=0x03D3B220  token=0x600082D  System.Void ClearLastFocusNaviTarget()
  RVA=0x03D00CB0  token=0x600082E  System.Void ManuallyRefreshRelatedBindingGroups()
  RVA=0x0283A400  token=0x600082F  System.Void .ctor()
  RVA=0x09AE9284  token=0x6000830  System.Void <_InitFocusBinding>b__51_0()
  RVA=0x09AE9290  token=0x6000831  System.Void <_InitFocusBinding>b__51_1()
  RVA=0x09AE9274  token=0x6000832  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x04272FC0  token=0x6000833  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AE927C  token=0x6000834  System.Void <>iFixBaseProxy__OnIsTopLayerChanged()
  RVA=0x0350B670  token=0x6000835  System.Void <>iFixBaseProxy__OnSelectableNaviGroupDisabled()
  RVA=0x0350B670  token=0x6000836  System.Void <>iFixBaseProxy__BeforeSelectableNaviGroupDestroy()
  RVA=0x0350B670  token=0x6000837  System.Void <>iFixBaseProxy__OnSetLayerSelectedTarget(UnityEngine.UI.Selectable P0)
  RVA=0x0350B670  token=0x6000838  System.Void <>iFixBaseProxy__OnRemoveFromLayerStack()
  RVA=0x09AE926C  token=0x6000839  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UISemiCircleScrollList
TYPE:  class
TOKEN: 0x20000ED
SIZE:  0x110
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler
FIELDS:
  public            UnityEngine.RectTransform       content  // 0x68
  private           System.Single                   _innerRadius  // 0x70
  private           System.Single                   _outerRadius  // 0x74
  private           System.Single                   _padding  // 0x78
  private           System.Int32                    _cellCount  // 0x7c
  private           UnityEngine.GameObject          _cellPrefab  // 0x80
  private           System.Single                   _startAngle  // 0x88
  private           System.Boolean                  _reverseDirection  // 0x8c
  private           UnityEngine.RectTransform       m_rectTransform  // 0x90
  public            System.Single                   currentAngleOffset  // 0x98
  private           System.Single                   m_targetAngleOffset  // 0x9c
  private           System.Single                   _hideAngel  // 0xa0
  private           System.Single                   _duration  // 0xa4
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_cells  // 0xa8
  private           System.Boolean                  m_inEndDragAnim  // 0xb0
  private           System.Boolean                  m_inDragging  // 0xb1
  protected         Beyond.Input.InputBindingGroupMonoTarget_scrollBindingGroup  // 0xb8
  protected         System.Single                   _stickScrollTolerance  // 0xc0
  protected         System.Single                   _stickScrollSpeed  // 0xc4
  private           System.Int32                    m_lastClosestCellIndex  // 0xc8
  private           System.Int32                    m_currentCellCount  // 0xcc
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onCellShow  // 0xd0
  public            Beyond.DisposedUnityEvent<System.Int32>onClosestCellChanged  // 0xd8
  public            Beyond.DisposedUnityEvent       onDrag  // 0xe0
  public            Beyond.DisposedUnityEvent       onEndDrag  // 0xe8
  private           UnityEngine.Coroutine           m_dampingCoroutine  // 0xf0
  private           System.String                   _audioHoldStart  // 0xf8
  private           System.String                   _audioHoldEnd  // 0x100
  private           System.String                   _audioAlignment  // 0x108
PROPERTIES:
  tickOption  get=0x03D55800
  controllerStickScrollEnabled  get=0x09AEACBC
METHODS:
  RVA=0x09AE9E6C  token=0x600083C  System.Void OnAwake()
  RVA=0x09AE9F94  token=0x600083D  System.Void OnDisable()
  RVA=0x09AEA2D8  token=0x600083E  System.Void Tick(System.Single deltaTime)
  RVA=0x09AEA974  token=0x600083F  System.Void _TickRefreshControllerStickScroll()
  RVA=0x09AEA80C  token=0x6000840  System.Void _InitializeCells()
  RVA=0x09AEA238  token=0x6000841  System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex)
  RVA=0x09AEA344  token=0x6000842  System.Void UpdateLayout()
  RVA=0x09AEA018  token=0x6000843  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AE9D58  token=0x6000844  System.Void ClearComponent()
  RVA=0x09AE9F10  token=0x6000845  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AEA150  token=0x6000846  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AEA77C  token=0x6000847  System.Collections.IEnumerator _ApplyDamping()
  RVA=0x09AEAB70  token=0x6000848  System.Void .ctor()
  RVA=0x058E2A30  token=0x6000849  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8A4  token=0x600084A  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0577D7BC  token=0x600084B  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISemiCircleScrollListPair
TYPE:  class
TOKEN: 0x20000EF
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.UI.UISemiCircleScrollListm_scrollListMaster  // 0x18
  public            Beyond.UI.UISemiCircleScrollList[]m_scrollLists  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onCellShow  // 0x28
  public            Beyond.DisposedUnityEvent<System.Int32>onClosestCellChanged  // 0x30
METHODS:
  RVA=0x09AE96E4  token=0x6000852  System.Void Awake()
  RVA=0x09AE9B14  token=0x6000853  System.Void _OnCellShow(UnityEngine.GameObject go, System.Int32 index)
  RVA=0x09AE9BB4  token=0x6000854  System.Void _OnClosestCellChanged(System.Int32 index)
  RVA=0x09AE9C3C  token=0x6000855  System.Void _OnDrag()
  RVA=0x09AE9CD8  token=0x6000856  System.Void _OnEndDrag()
  RVA=0x09AE9A58  token=0x6000857  System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex)
  RVA=0x0426FE60  token=0x6000858  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISequenceImage
TYPE:  class
TOKEN: 0x20000F0
SIZE:  0x90
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Boolean                  autoPlay  // 0x68
  public            System.Single                   frameRate  // 0x6c
  public            System.Collections.Generic.List<UnityEngine.Sprite>sprites  // 0x70
  private           System.Boolean                  <isPlaying>k__BackingField  // 0x78
  private           Beyond.UI.UIImage               m_image  // 0x80
  private           System.Single                   m_curFrameCount  // 0x88
PROPERTIES:
  tickOption  get=0x03D55800
  isPlaying  get=0x03D4F800  set=0x03D4F810
METHODS:
  RVA=0x03B74360  token=0x600085C  System.Void OnAwake()
  RVA=0x03A53100  token=0x600085D  System.Void OnEnable()
  RVA=0x03C944F0  token=0x600085E  System.Void OnDisable()
  RVA=0x025C36F0  token=0x600085F  System.Void Tick(System.Single deltaTime)
  RVA=0x03A53150  token=0x6000860  System.Void Play()
  RVA=0x03C94540  token=0x6000861  System.Void Stop(System.Boolean resetToFirstFrame)
  RVA=0x025C3780  token=0x6000862  System.Void SetSprite(System.Int32 index)
  RVA=0x037CAF60  token=0x6000863  System.Void .ctor()
  RVA=0x058E2A30  token=0x6000864  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x058DD8AC  token=0x6000865  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x6000866  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0577D7BC  token=0x6000867  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISimpleActiveAnimationHelper
TYPE:  class
TOKEN: 0x20000F1
SIZE:  0x90
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Boolean                  isActive  // 0x68
  public            System.String                   toActiveAnimationName  // 0x70
  private           UnityEngine.Animation           m_animation  // 0x78
  private           UnityEngine.AnimationState      m_animationState  // 0x80
  private           System.Single                   m_animationTime  // 0x88
  private           System.Single                   m_curAnimationTime  // 0x8c
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x09AEAE70  token=0x6000869  System.Void Start()
  RVA=0x09AEAD5C  token=0x600086A  System.Void OnEnable()
  RVA=0x09AEADCC  token=0x600086B  System.Void Skip()
  RVA=0x09AEAF4C  token=0x600086C  System.Void Tick(System.Single deltaTime)
  RVA=0x03CDD650  token=0x600086D  System.Void .ctor()
  RVA=0x058DD8AC  token=0x600086E  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0577D7BC  token=0x600086F  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISimpleStateController
TYPE:  class
TOKEN: 0x20000F2
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UISimpleStateController.StateInfo>_states  // 0x18
  private           System.String                   m_curStateName  // 0x20
PROPERTIES:
  curStateName  get=0x03D4EB40
METHODS:
  RVA=0x033595F0  token=0x6000871  System.Void SetState(System.String stateName)
  RVA=0x03577DE0  token=0x6000872  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISizeFollower
TYPE:  class
TOKEN: 0x20000F4
SIZE:  0x98
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            UnityEngine.RectTransform       target  // 0x68
  public            UnityEngine.Vector2             addedSize  // 0x70
  public            System.Boolean                  isSumSize  // 0x78
  public            System.Boolean                  followWidth  // 0x79
  public            System.Boolean                  followHeight  // 0x7a
  public            System.Boolean                  regulateAnchoredPosition  // 0x7b
  public            UnityEngine.Vector2             minSize  // 0x7c
  public            UnityEngine.Vector2             maxSize  // 0x84
  private           UnityEngine.RectTransform       m_rectTransform  // 0x90
PROPERTIES:
  tickOption  get=0x03D55B70
  rectTransform  get=0x02F7AE60
METHODS:
  RVA=0x02F7AB40  token=0x6000878  System.Void LateTick(System.Single deltaTime)
  RVA=0x02F7AB80  token=0x6000879  System.Void SyncSize()
  RVA=0x02846E00  token=0x600087A  System.Void .ctor()
  RVA=0x0589E548  token=0x600087B  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISlider
TYPE:  class
TOKEN: 0x20000F5
SIZE:  0x268
EXTENDS: UnityEngine.UI.Slider
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IEndDragHandler Beyond.Input.IBindingGroupTarget Beyond.Input.IBindingView
FIELDS:
  public            System.Single                   snapCenterRange  // 0x1e8
  public            System.String                   audioSlide  // 0x1f0
  public            System.String                   audioClickHandle  // 0x1f8
  private           System.Boolean                  m_dragging  // 0x200
  public            UnityEngine.UI.Slider.SliderEventonEndDragSlider  // 0x208
  public            UnityEngine.UI.Slider.SliderEventonClickSlider  // 0x210
  public            UnityEngine.UI.Slider.SliderEventonClickSliderHandle  // 0x218
  public            System.String                   sliderAddActionId  // 0x220
  public            System.String                   sliderReduceActionId  // 0x228
  private   readonly Beyond.DisposedUnityEvent       <bindingViewUpdateEvent>k__BackingField  // 0x230
  private           System.Int32                    m_bindingGroupId  // 0x238
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0x240
  public            System.Boolean                  snapStep  // 0x248
  public            System.Single                   stepValue  // 0x24c
  protected         System.Boolean                  _enableStickScroll  // 0x250
  protected         System.Single                   _stickScrollTolerance  // 0x254
  protected         System.Single                   _stickOverPushThreshold  // 0x258
  protected         System.Int32                    _stickOverPushMultiplier  // 0x25c
  protected         System.Int32                    _stickScrollBatchCount  // 0x260
  private           System.Int32                    m_stickScrollHoriBindingId  // 0x264
PROPERTIES:
  bindingViewActionId  get=0x03D57430
  bindingViewLabelText  get=0x09AEB854
  bindingViewUpdateEvent  get=0x03D57210
  redDotTrans  get=0x01002730
  bindingEnabled  get=0x09AEB84C
  bindingViewState  get=0x09AEB88C
  groupId  get=0x03D76180
  parentTarget  get=0x03D56B10  set=0x0586F120
  groupEnabled  get=0x09AEB988
METHODS:
  RVA=0x0346C960  token=0x600087C  System.Void _TryPostSlideAudioEvent()
  RVA=0x031EB4A0  token=0x600087D  System.Single ClampValue(System.Single input)
  RVA=0x09AEB16C  token=0x600087E  System.Single CustomProcessNormalizedValue(System.Single val)
  RVA=0x0346C920  token=0x600087F  System.Void OnValueChanged()
  RVA=0x09AEB340  token=0x6000880  System.Void OnClickSliderBar()
  RVA=0x09AEB3C4  token=0x6000881  System.Void OnClickSliderHandle()
  RVA=0x02C6F160  token=0x6000882  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x09AEB2E4  token=0x6000883  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AEB47C  token=0x6000884  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02C70370  token=0x6000885  System.Void Awake()
  RVA=0x025294F0  token=0x6000886  System.Void OnEnable()
  RVA=0x0361D540  token=0x6000887  System.Void OnDisable()
  RVA=0x03B721E0  token=0x6000888  System.Void ClearComponent()
  RVA=0x03A07BD0  token=0x6000889  System.Void OnDestroy()
  RVA=0x09AEB1F8  token=0x6000890  System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType)
  RVA=0x09AEB074  token=0x6000891  System.Void Beyond.Input.IBindingView.OnInputKeyDown(System.Boolean isActionTrigger)
  RVA=0x09AEB0C8  token=0x6000892  System.Void Beyond.Input.IBindingView.OnInputKeyUp(System.Boolean isActionTrigger)
  RVA=0x02C703C0  token=0x6000897  System.Void _InitBinding()
  RVA=0x09AEB52C  token=0x6000898  System.Void _AddValue()
  RVA=0x09AEB718  token=0x6000899  System.Void _ReduceValue()
  RVA=0x02C704F0  token=0x600089A  System.Void _InitStickScroll()
  RVA=0x09AEB784  token=0x600089B  System.Void _StickScrollHoriValue()
  RVA=0x09AEB598  token=0x600089C  System.Void _ApplyStickScroll(System.Single deltaConcern)
  RVA=0x02848300  token=0x600089D  System.Void .ctor()
  RVA=0x09AEB11C  token=0x600089E  System.Boolean Beyond.Input.IBindingView.get_interactable()
  RVA=0x09AEB51C  token=0x600089F  System.Single <>iFixBaseProxy_ClampValue(System.Single P0)
  RVA=0x03D65EB0  token=0x60008A0  System.Single <>iFixBaseProxy_CustomProcessNormalizedValue(System.Single P0)
  RVA=0x0350B670  token=0x60008A1  System.Void <>iFixBaseProxy_OnValueChanged()
  RVA=0x0350B670  token=0x60008A2  System.Void <>iFixBaseProxy_OnClickSliderBar()
  RVA=0x0350B670  token=0x60008A3  System.Void <>iFixBaseProxy_OnClickSliderHandle()
  RVA=0x09ACB974  token=0x60008A4  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  RVA=0x09AAE8DC  token=0x60008A5  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AEB524  token=0x60008A6  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0361D5F0  token=0x60008A7  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AAE8E4  token=0x60008A8  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UISoftMask
TYPE:  class
TOKEN: 0x20000F6
SIZE:  0x148
EXTENDS: Beyond.TickableUIMono
FIELDS:
  private           UnityEngine.Vector3[]           m_fourCornersArray  // 0x68
  private           UnityEngine.Vector3[]           m_fourCornersArrayWorld  // 0x70
  private           System.Collections.Generic.List<Beyond.UI.UISoftMaskable>m_cacheSoftMaskables  // 0x78
  private   static  System.Collections.Generic.List<UnityEngine.Canvas>s_cacheCanvas  // static @ 0x0
  private   static  UnityEngine.UI.Image            s_image  // static @ 0x8
  private           UnityEngine.Shader              _maskableDefaultShader  // 0x80
  private           UnityEngine.Shader              _maskableTextShader  // 0x88
  private   static  System.Int32                    s_SoftMaskTexId  // static @ 0x10
  private   static  System.Int32                    s_SoftMaskTexSTId  // static @ 0x14
  private   static  System.Int32                    s_WorldToSoftMaskId  // static @ 0x18
  private   static  System.Int32                    s_InnerSoftMaskId  // static @ 0x1c
  private   static  System.Int32                    s_InnerSoftMaskUVId  // static @ 0x20
  private   static  System.Int32                    s_SpriteSlicedFlag  // static @ 0x24
  private           UnityEngine.Texture             m_mainTexture  // 0x90
  private           UnityEngine.Vector4             m_spriteTillingOffset  // 0x98
  private           UnityEngine.Matrix4x4           m_worldToSoftMask  // 0xa8
  private           UnityEngine.Vector4             m_innerSoftMask  // 0xe8
  private           UnityEngine.Vector4             m_innerSoftMaskUV  // 0xf8
  private           Beyond.UI.UISoftMask.SlicedSpriteParamsm_slicedSpriteParams  // 0x108
  private           UnityEngine.Material            m_softMaskDefaultMaterial  // 0x130
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_softMaskTextMaterials  // 0x138
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_softMaskUIVFXMaterials  // 0x140
PROPERTIES:
  tickOption  get=0x03D567A0
  softMaskDefaultMaterial  get=0x03D56D00
METHODS:
  RVA=0x025B8940  token=0x60008AB  UnityEngine.Material GetTextSoftMaskMaterial(UnityEngine.Material baseMaterial)
  RVA=0x09AEBACC  token=0x60008AC  UnityEngine.Material GetUIVFXSoftMaskMaterial(UnityEngine.Material baseMaterial)
  RVA=0x09AEB9DC  token=0x60008AD  UnityEngine.Vector3 GetCornerCanvas(System.Int32 i)
  RVA=0x09AEBA7C  token=0x60008AE  UnityEngine.Vector3[] GetFourCornnerArrayWorld()
  RVA=0x02529A90  token=0x60008AF  System.Void OnEnable()
  RVA=0x02529940  token=0x60008B0  System.Void OnDisable()
  RVA=0x0262D2D0  token=0x60008B1  System.Void TailLateTick(System.Single deltaTime)
  RVA=0x02529EC0  token=0x60008B2  System.Void _Clear()
  RVA=0x0252A1C0  token=0x60008B3  System.Void _DestroyMaterial(UnityEngine.Material material)
  RVA=0x028033D0  token=0x60008B4  System.Void _UpdateParam()
  RVA=0x028051C0  token=0x60008B5  System.Void _UpdateChildren(System.Boolean markVertices, System.Boolean markMaterial)
  RVA=0x038C4F60  token=0x60008B6  System.Void _OnEnableRuntimeAtlas()
  RVA=0x02846030  token=0x60008B7  System.Void .ctor()
  RVA=0x03A43080  token=0x60008B8  System.Void .cctor()
  RVA=0x058DD8AC  token=0x60008B9  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x60008BA  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x05826E68  token=0x60008BB  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISoftMaskable
TYPE:  class
TOKEN: 0x20000F8
SIZE:  0xB0
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.UI.IMaterialModifier UnityEngine.UI.IMeshModifier
FIELDS:
  public            System.Boolean                  _clipMeshToSaveOverDraw  // 0x68
  private           System.Collections.Generic.List<UnityEngine.UIVertex>m_cacheVertexSteram  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIVertex>m_cacheDstVertexSteram  // 0x78
  protected static readonly System.String                   UI_MINIMAP_MIST_KEYWORD  // static @ 0x0
  protected static readonly System.String                   UI_VFX_PARAM  // static @ 0x8
  private           Beyond.UI.UISoftMaskable.TestLine[]m_testLinesCache  // 0x80
  private           UnityEngine.Material            m_softMaskModefiedMat  // 0x88
  private           UnityEngine.UI.Graphic          m_graphic  // 0x90
  private           Beyond.UI.UISoftMask            m_softMask  // 0x98
  private           Beyond.UI.UIText                m_uiText  // 0xa0
  private           Beyond.UI.UISoftMaskable.UIType m_uiType  // 0xa8
PROPERTIES:
  tickOption  get=0x03D55B70
  softMaskModefiedMat  get=0x03D4EA60
  graphic  get=0x02806650
  softMask  get=0x025B8880
  uiText  get=0x09AED668
METHODS:
  RVA=0x025B8740  token=0x60008C2  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  RVA=0x02806130  token=0x60008C3  System.Void OnEnable()
  RVA=0x02806030  token=0x60008C4  System.Void OnDisable()
  RVA=0x0280A340  token=0x60008C5  System.Void LateTick(System.Single deltaTime)
  RVA=0x02805DE0  token=0x60008C6  System.Void MarkGraphicVerticesDirty()
  RVA=0x02805EF0  token=0x60008C7  System.Void MarkGraphicMaterialDirty()
  RVA=0x09AEBD88  token=0x60008C8  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  RVA=0x09AED528  token=0x60008C9  System.Boolean _Equal(System.Single a, System.Single b)
  RVA=0x09AED168  token=0x60008CA  UnityEngine.Vector2 _ComputeLineCross(UnityEngine.Vector2 line0p0, UnityEngine.Vector2 line0p1, UnityEngine.Vector2 line1p0, UnityEngine.Vector2 line1p1)
  RVA=0x09AED3A8  token=0x60008CB  System.Void _ComputePointAtTriangleUV(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 q, System.Single& u, System.Single& v)
  RVA=0x09AEC0BC  token=0x60008CC  System.Void _ClipTriangleByClampSoftMaskUV(UnityEngine.UIVertex[] vertices, UnityEngine.UIVertex[] resultPoint, System.Boolean& canSkip)
  RVA=0x09AEBDDC  token=0x60008CD  System.Void _ClipRect()
  RVA=0x025B8670  token=0x60008CE  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vertHelper)
  RVA=0x09AED5AC  token=0x60008CF  System.Void _SetUIVertexUV(UnityEngine.UIVertex& uiVertex, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 softMaskUV)
  RVA=0x028463E0  token=0x60008D0  System.Void .ctor()
  RVA=0x03CDF1E0  token=0x60008D1  System.Void .cctor()
  RVA=0x058DD8AC  token=0x60008D2  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x60008D3  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0589E548  token=0x60008D4  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISortingOrder
TYPE:  class
TOKEN: 0x20000FB
SIZE:  0x40
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Int32                    _sortingOrderOffset  // 0x18
  private           Beyond.UI.UISortingOrder.RenderType_renderType  // 0x1c
  private           UnityEngine.Renderer            m_renderer  // 0x20
  private           UnityEngine.Renderer[]          m_childrenRenderers  // 0x28
  private           UnityEngine.Canvas              m_canvas  // 0x30
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0x38
METHODS:
  RVA=0x036E7FB0  token=0x60008D5  System.Void OnEnable()
  RVA=0x02A73870  token=0x60008D6  System.Void _GetRenderer()
  RVA=0x02A73800  token=0x60008D7  System.Void _GetChildrenRenderers()
  RVA=0x02A73660  token=0x60008D8  System.Void _GetCanvas()
  RVA=0x02A732B0  token=0x60008D9  System.Void SetOrder(System.Int32 baseOrder)
  RVA=0x02A72A10  token=0x60008DA  System.Void Awake()
  RVA=0x03A411F0  token=0x60008DB  System.Void OnDestroy()
  RVA=0x038A8970  token=0x60008DC  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIStepScrollList
TYPE:  class
TOKEN: 0x20000FD
SIZE:  0x2A8
EXTENDS: Beyond.UI.UIScrollList
FIELDS:
  public            Beyond.DisposedUnityEvent<System.Int32,System.Int32>onCenterIndexChanged  // 0x278
  public            Beyond.DisposedUnityEvent       onScrollOrDragEnd  // 0x280
  public            Beyond.DisposedUnityEvent       onScrollOrDragStart  // 0x288
  protected         System.Single                   _easyDragSpdThreshold  // 0x290
  protected         System.Single                   _easyDragDistPercentThreshold  // 0x294
  private           System.Int32                    m_startDragCenterIndex  // 0x298
  private           System.Int32                    m_centerIndex  // 0x29c
  private           UnityEngine.Vector2             m_scrollStartNormalizedPos  // 0x2a0
PROPERTIES:
  centerIndex  get=0x02A18F10
METHODS:
  RVA=0x02D9CE80  token=0x60008DE  System.Void Init(System.Boolean isPreview)
  RVA=0x03801380  token=0x60008DF  System.Void InitConfig()
  RVA=0x028C15F0  token=0x60008E0  System.Void OnScroll(UnityEngine.Vector2 v)
  RVA=0x09AED7B4  token=0x60008E1  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AED8B0  token=0x60008E2  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AEDA90  token=0x60008E3  System.Void SetTop(System.Boolean needUpdate)
  RVA=0x028C1660  token=0x60008E4  System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive)
  RVA=0x09AED730  token=0x60008E5  System.Void ClearComponent()
  RVA=0x09AEDC6C  token=0x60008E6  System.Void _OnScrollStart(UnityEngine.Vector2 normalizedPos)
  RVA=0x09AEDB64  token=0x60008E7  System.Void _OnScrollEnd(UnityEngine.Vector2 normalizedPos)
  RVA=0x09AEDCF0  token=0x60008E8  System.Void _TryAutoScroll(System.Boolean isEasyDrag, System.Boolean goNext)
  RVA=0x028C1740  token=0x60008E9  System.Int32 _GetClampedIndex()
  RVA=0x09AED840  token=0x60008EA  System.Void OnDisable()
  RVA=0x0284A630  token=0x60008EB  System.Void .ctor()
  RVA=0x09AEDB2C  token=0x60008EC  System.Void <>iFixBaseProxy_Init(System.Boolean P0)
  RVA=0x09AEDB24  token=0x60008ED  System.Void <>iFixBaseProxy_InitConfig()
  RVA=0x09ADD030  token=0x60008EE  System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0)
  RVA=0x09AEDB34  token=0x60008EF  System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AEDB44  token=0x60008F0  System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AEDB4C  token=0x60008F1  System.Void <>iFixBaseProxy_SetTop(System.Boolean P0)
  RVA=0x09AEDB54  token=0x60008F2  System.Void <>iFixBaseProxy_UpdateShowingCells(System.Boolean P0, System.Boolean P1, System.Boolean P2)
  RVA=0x09ADCFE8  token=0x60008F3  System.Void <>iFixBaseProxy_ClearComponent()
  RVA=0x09AEDB3C  token=0x60008F4  System.Void <>iFixBaseProxy_OnDisable()
END_CLASS

CLASS: Beyond.UI.UIStyleByState
TYPE:  class
TOKEN: 0x20000FE
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIStyleByState.StyleConfig>styleConfigs  // 0x18
METHODS:
  RVA=0x02CD1F50  token=0x60008F5  System.Void Awake()
  RVA=0x02CD0D70  token=0x60008F6  System.Void OnDestroy()
  RVA=0x02CD2160  token=0x60008F7  System.Void UpdateStyle()
  RVA=0x02CD2C30  token=0x60008F8  System.Boolean _IsValidStyle(Beyond.UI.UIStyleByState.StyleConfig styleConfig)
  RVA=0x0367EB10  token=0x60008F9  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISubtitle
TYPE:  class
TOKEN: 0x2000101
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _topText  // 0x18
  private           Beyond.UI.UIText                _bottomText  // 0x20
METHODS:
  RVA=0x09AF691C  token=0x60008FC  System.Void Start()
  RVA=0x09AF6A4C  token=0x60008FD  System.Void _SetAsDefault()
  RVA=0x09AF6818  token=0x60008FE  System.Void SetSubtitle(System.String subtitle, System.Boolean showOnTop)
  RVA=0x09AF696C  token=0x60008FF  System.Void UpdateAlpha(System.Single alpha, System.Boolean isTop)
  RVA=0x0426FE60  token=0x6000900  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UITextPair
TYPE:  class
TOKEN: 0x2000102
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIText>referencedTexts  // 0x18
PROPERTIES:
  text  get=0x09AF7130  set=0x09AF737C
  color  set=0x09AF71EC
  first  get=0x09AF7098
METHODS:
  RVA=0x09AF6DA8  token=0x6000905  System.Void SetAndResolveTextStyle(System.String targetText)
  RVA=0x09AF6F14  token=0x6000906  System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  RVA=0x0397CDE0  token=0x6000907  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIToggle
TYPE:  class
TOKEN: 0x2000103
SIZE:  0x270
EXTENDS: UnityEngine.UI.Toggle
IMPLEMENTS: Beyond.UI.IUIClearable Beyond.ILuaCallCSharp
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.GameObject>_onObjects  // 0x1a8
  private           System.Collections.Generic.List<UnityEngine.GameObject>_offObjects  // 0x1b0
  private           Beyond.UI.UIState.UIStateController_uiStateController  // 0x1b8
  private           System.String                   _onStateName  // 0x1c0
  private           System.String                   _offStateName  // 0x1c8
  private           System.String                   _onAnimation  // 0x1d0
  private           System.String                   _offAnimation  // 0x1d8
  private           System.String                   _audioToggleOn  // 0x1e0
  private           System.String                   _audioToggleOff  // 0x1e8
  private           System.String                   _audioInvalid  // 0x1f0
  public            System.Boolean                  _ignoreClickOnDrag  // 0x1f8
  private           UnityEngine.Vector2             <startPressPos>k__BackingField  // 0x1fc
  private           Beyond.LangKey                  _invalidClickLangKey  // 0x208
  public            System.Func<System.Boolean,System.Boolean>checkIsValueValid  // 0x218
  private           UnityEngine.Animation           m_animation  // 0x220
  private           System.Int32                    m_groupId  // 0x228
  public            System.String                   toggleActionId  // 0x230
  private           System.Int32                    <toggleBindingId>k__BackingField  // 0x238
  private           System.Boolean                  m_started  // 0x23c
  public            System.String                   clickOnHintTextId  // 0x240
  public            System.String                   clickOffHintTextId  // 0x248
  private           Beyond.Input.ActionOnSetNaviTarget_actionOnSetNaviTarget  // 0x250
  private           System.Boolean                  _useNoHintAction  // 0x254
  public            System.String                   onHintTextId  // 0x258
  public            System.String                   offHintTextId  // 0x260
  private           System.Int32                    <hoverConfirmBindingId>k__BackingField  // 0x268
PROPERTIES:
  startPressPos  get=0x03D761F0  set=0x03D76220
  toggleBindingId  get=0x03D76180  set=0x03D76230
  hoverConfirmBindingId  get=0x03D761E0  set=0x03D76210
METHODS:
  RVA=0x02C6B820  token=0x600090C  System.Void Awake()
  RVA=0x02C6C0A0  token=0x600090D  System.Void OnEnable()
  RVA=0x02C6C030  token=0x600090E  System.Void OnDisable()
  RVA=0x02C6C200  token=0x600090F  System.Void _UpdateBindingEnable()
  RVA=0x09AF7AEC  token=0x6000910  System.Void OnDestroy()
  RVA=0x02C6BF60  token=0x6000911  System.Void Start()
  RVA=0x02C6AC20  token=0x6000912  System.Void InternalToggle()
  RVA=0x02C6B8B0  token=0x6000913  System.Void _InitToggleBinding()
  RVA=0x09AF7FE0  token=0x6000914  System.Boolean _OnToggleFail()
  RVA=0x02C6AB90  token=0x6000915  System.Void PlayAudio()
  RVA=0x02C6B770  token=0x6000916  System.Void OnValueChange()
  RVA=0x02C6F0F0  token=0x6000917  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x02C6C4E0  token=0x6000918  System.Void _UpdateObjects()
  RVA=0x02C6CCA0  token=0x6000919  System.Void _PlayAnimation(System.Boolean skipToEnd)
  RVA=0x03CE5950  token=0x600091A  System.Void ClearComponent()
  RVA=0x09AF7BAC  token=0x600091B  System.Void OnInteractableChanged()
  RVA=0x09AF7A50  token=0x600091C  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  RVA=0x09AF7D80  token=0x600091D  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AF7C68  token=0x600091E  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AF7E14  token=0x600091F  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03D2AFD0  token=0x6000920  System.Void TryInternalToggle()
  RVA=0x09AF7BFC  token=0x6000923  System.Void OnNaviTargetEnabledAgain()
  RVA=0x09AF7E9C  token=0x6000924  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  RVA=0x02C6BBA0  token=0x6000925  System.Void _InitActionOnSetNaviTarget()
  RVA=0x09AF8130  token=0x6000926  System.Void _ToggleNaviInputBinding(System.Boolean active)
  RVA=0x02C6BA50  token=0x6000927  System.Void _TryRefreshToggleBindingText()
  RVA=0x02C6B7D0  token=0x6000928  System.Void _TryRefreshHoverConfirmBindingText()
  RVA=0x02C6BA90  token=0x6000929  System.Void _TryRefreshBindingText(System.Int32 bindingId)
  RVA=0x02847F80  token=0x600092A  System.Void .ctor()
  RVA=0x09AAE8DC  token=0x600092B  System.Void <>iFixBaseProxy_Awake()
  RVA=0x09AF7E8C  token=0x600092C  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09AF7E84  token=0x600092D  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AF7E7C  token=0x600092E  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x04272FA8  token=0x600092F  System.Void <>iFixBaseProxy_Start()
  RVA=0x09AF7E74  token=0x6000930  System.Void <>iFixBaseProxy_InternalToggle()
  RVA=0x0350B670  token=0x6000931  System.Void <>iFixBaseProxy_OnValueChange()
  RVA=0x09ACB974  token=0x6000932  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  RVA=0x0350B670  token=0x6000933  System.Void <>iFixBaseProxy_OnInteractableChanged()
  RVA=0x09ACB954  token=0x6000934  System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1)
  RVA=0x09ACB964  token=0x6000935  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AF7E94  token=0x6000936  System.Void <>iFixBaseProxy_OnPointerClick(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x0968FA40  token=0x6000937  System.Void <>iFixBaseProxy_OnSubmit(UnityEngine.EventSystems.BaseEventData P0)
  RVA=0x09ACB95C  token=0x6000938  System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain()
  RVA=0x0350B670  token=0x6000939  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.UIToggleGroup
TYPE:  class
TOKEN: 0x2000104
SIZE:  0x48
EXTENDS: UnityEngine.UI.ToggleGroup
FIELDS:
  private           System.String                   _moveToNextActionId  // 0x28
  private           System.String                   _moveToPreviousActionId  // 0x30
  private           System.Boolean                  _inverse  // 0x38
  private           System.Int32                    <moveToNextBindingId>k__BackingField  // 0x3c
  private           System.Int32                    <moveToPreviousBindingId>k__BackingField  // 0x40
PROPERTIES:
  moveToNextBindingId  get=0x03D4ED90  set=0x03D4EDC0
  moveToPreviousBindingId  get=0x03D4ED80  set=0x03D4EDB0
METHODS:
  RVA=0x038EA450  token=0x600093E  System.Void Awake()
  RVA=0x02C6D2E0  token=0x600093F  System.Void OnEnable()
  RVA=0x02C6D1F0  token=0x6000940  System.Void OnDisable()
  RVA=0x09AF7598  token=0x6000941  System.Void OnDestroy()
  RVA=0x09AF74E8  token=0x6000942  System.Void MoveToNext()
  RVA=0x09AF7540  token=0x6000943  System.Void MoveToPrevious()
  RVA=0x09AF7674  token=0x6000944  System.Void _MoveTo(System.Boolean isNext)
  RVA=0x03726B80  token=0x6000945  System.Void .ctor()
  RVA=0x0350B670  token=0x6000946  System.Void <>iFixBaseProxy_Awake()
  RVA=0x02C6AE20  token=0x6000947  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0350B670  token=0x6000948  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x0350B670  token=0x6000949  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.FingerMoveDirection
TYPE:  sealed struct
TOKEN: 0x2000105
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.FingerMoveDirection   None  // const
  public    static  Beyond.UI.FingerMoveDirection   Anisotropy  // const
  public    static  Beyond.UI.FingerMoveDirection   Same  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UITouchPanel
TYPE:  class
TOKEN: 0x2000106
SIZE:  0x1E8
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IPointerUpHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IScrollHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IPointerExitHandler Beyond.UI.IUIClearable Beyond.ILuaCallCSharp Beyond.Input.IBindingGroupTarget
FIELDS:
  private           System.Single                   _gestureZoomSensitivity  // 0x68
  private           System.Single                   _dragThreshold  // 0x6c
  private           System.Single                   _longPressTime  // 0x70
  private           System.Single                   _longPressMaxDist  // 0x74
  private           System.Single                   _mouseZoomSensitivity  // 0x78
  private           System.Single                   _scrollZoomSensitivity  // 0x7c
  private           System.Boolean                  _useGesturePixelSizeAdjustment  // 0x80
  private           System.Single                   _multiClickInterval  // 0x84
  private           System.Int32                    _multiClickPixelOffset  // 0x88
  private           System.Boolean                  _ignoreClickOnLongPress  // 0x8c
  private           System.Boolean                  _clickThrough  // 0x8d
  private           System.Boolean                  _preventPressWhenClickThrough  // 0x8e
  private           System.Boolean                  m_triggeredLongPress  // 0x8f
  private           System.Int32                    m_clickCount  // 0x90
  private           System.Single                   m_lastClickTime  // 0x94
  private           UnityEngine.Vector2             m_lastClickPos  // 0x98
  private           System.Boolean                  m_isPress  // 0xa0
  private           System.Boolean                  m_isInGestureZoom  // 0xa1
  private           System.Boolean                  m_isActionLongPress  // 0xa2
  private           System.Boolean                  m_dragStarted  // 0xa3
  private           UnityEngine.Vector2             m_dragPosition  // 0xa4
  private           UnityEngine.RectTransform       m_rect  // 0xb0
  private           System.Single                   m_deltaX  // 0xb8
  private           System.Single                   m_deltaY  // 0xbc
  private           UnityEngine.Vector2             m_lastFrameTouchPos  // 0xc0
  private           UnityEngine.EventSystems.PointerEventDatam_touch  // 0xc8
  private           System.Int32                    m_touchId  // 0xd0
  private           System.Int32                    m_touchId1  // 0xd4
  private           System.Int32                    m_touchId2  // 0xd8
  private           System.Single                   m_actionLongPressStartTime  // 0xdc
  private           UnityEngine.Vector2             m_actionLongPressStartPos  // 0xe0
  private           System.Single                   m_pixelSizeAdjustment  // 0xe8
  private           UnityEngine.Vector2             m_touch1Pos  // 0xec
  private           UnityEngine.Vector2             m_touch1LastPos  // 0xf4
  private           UnityEngine.Vector2             m_touch2Pos  // 0xfc
  private           UnityEngine.Vector2             m_touch2LastPos  // 0x104
  private           UnityEngine.Vector3             m_lastMousePos  // 0x10c
  private           System.Boolean                  m_lastFrameIsRightMouseButtonPress  // 0x118
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onClick  // 0x120
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onRightClick  // 0x128
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onPress  // 0x130
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onLongPress  // 0x138
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDoubleClick  // 0x140
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onRelease  // 0x148
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x150
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onDragBegin  // 0x158
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onDragEnd  // 0x160
  public            Beyond.DisposedUnityEvent<System.Single>onZoom  // 0x168
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2,Beyond.UI.FingerMoveDirection>onHorizonAndVerticalZoom  // 0x170
  public            Beyond.DisposedUnityEvent       onDragToLeft  // 0x178
  public            Beyond.DisposedUnityEvent       onDragToRight  // 0x180
  public            Beyond.DisposedUnityEvent       onPointerEnter  // 0x188
  public            Beyond.DisposedUnityEvent       onPointerExit  // 0x190
  public            Beyond.DisposedUnityEvent       onDragToUp  // 0x198
  public            Beyond.DisposedUnityEvent       onDragToDown  // 0x1a0
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onRightMouseButtonPress  // 0x1a8
  public            Beyond.DisposedUnityEvent<System.Single>onScroll  // 0x1b0
  private           UnityEngine.Vector2             <curPressPos>k__BackingField  // 0x1b8
  private           System.Boolean                  <isPointerEntered>k__BackingField  // 0x1c0
  public            System.Boolean                  enableZoom  // 0x1c1
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>rawOnDrag  // 0x1c8
  private           System.Single                   m_leftMousePressDownTimeWithNoCursor  // 0x1d0
  private           System.Single                   m_rightMousePressDownTimeWithNoCursor  // 0x1d4
  private           System.Int32                    m_groupId  // 0x1d8
  private           System.Boolean                  m_bindingInit  // 0x1dc
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x1e0
PROPERTIES:
  tickOption  get=0x03D55740
  touchPos  get=0x09AF8438
  curPressPos  get=0x03D76240  set=0x03D76260
  isPointerEntered  get=0x03D57BF0  set=0x03D760A0
  isDragging  get=0x03D5B380
  groupEnabled  get=0x033BE100
  groupId  get=0x042760E8
  parentTarget  get=0x03D56B80
  parent  get=0x03D56B80  set=0x05871130
METHODS:
  RVA=0x039766E0  token=0x6000951  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03126350  token=0x6000952  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x031263D0  token=0x6000953  System.Void DoEndDrag(UnityEngine.Vector2 dragPos)
  RVA=0x02912830  token=0x6000954  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284C110  token=0x6000955  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284BF70  token=0x6000956  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284BB10  token=0x6000957  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03743670  token=0x6000958  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03743620  token=0x6000959  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284B350  token=0x600095A  System.Void _OnActionPress(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284BA00  token=0x600095B  System.Void _OnActionRelease(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02911FB0  token=0x600095C  System.Boolean _IsSameTouchFromPress(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03125E30  token=0x600095D  System.Void ClearTouchInfo()
  RVA=0x09AF827C  token=0x600095E  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AF833C  token=0x600095F  System.Void SimulateClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09AF81C8  token=0x6000960  System.Void DeActiveTouch(System.Int32 touchId)
  RVA=0x03125EA0  token=0x6000961  System.Void OnAwake()
  RVA=0x0284F730  token=0x6000962  System.Void Tick(System.Single deltaTime)
  RVA=0x024B0D70  token=0x6000963  System.Void LateTick(System.Single deltaTime)
  RVA=0x03125F20  token=0x6000964  System.Void OnEnable()
  RVA=0x03125DC0  token=0x6000965  System.Void OnDisable()
  RVA=0x0331B6F0  token=0x6000966  System.Void OnDestroy()
  RVA=0x03927ED0  token=0x6000967  System.Void OnRelease()
  RVA=0x03125F60  token=0x600096D  System.Void InitBinding()
  RVA=0x031261B0  token=0x600096E  System.Void _UpdateState()
  RVA=0x03927F10  token=0x600096F  System.Void ClearComponent()
  RVA=0x028473A0  token=0x6000970  System.Void .ctor()
  RVA=0x09AF83A0  token=0x6000971  System.Void <InitBinding>b__110_0()
  RVA=0x09AF83EC  token=0x6000972  System.Void <InitBinding>b__110_1()
  RVA=0x058E2A30  token=0x6000973  System.Void <>iFixBaseProxy_OnAwake()
  RVA=0x0577D7BC  token=0x6000974  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0589E548  token=0x6000975  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x058DD8AC  token=0x6000976  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x058DD8A4  token=0x6000977  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x05F2CFD8  token=0x6000978  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x0577D7B4  token=0x6000979  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIVFXManager
TYPE:  class
TOKEN: 0x2000107
SIZE:  0xA0
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: UnityEngine.UI.IMaterialModifier
FIELDS:
  private   static  System.Int32                    s_vfxMainTexSTId  // static @ 0x0
  private           UnityEngine.Vector4             m_spriteTillingOffset  // 0x68
  private           UnityEngine.Material            m_uiDefaultVFXMaterial  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_UIVfxMaterials  // 0x80
  private           UnityEngine.Shader              m_uiDefaultShader  // 0x88
  private           UnityEngine.UI.Graphic          m_graphic  // 0x90
  private           Beyond.UI.UISoftMaskable        m_softMaskable  // 0x98
PROPERTIES:
  tickOption  get=0x03D55B70
  graphic  get=0x09AF8CC4
  softMaskable  get=0x09AF8D8C
METHODS:
  RVA=0x09AF8664  token=0x600097D  System.Void OnEnable()
  RVA=0x09AF8470  token=0x600097E  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AF8A24  token=0x600097F  System.Void _OnEnableRuntimeAtlas()
  RVA=0x09AF8508  token=0x6000980  System.Void OnDisable()
  RVA=0x09AF87EC  token=0x6000981  System.Void _Clear()
  RVA=0x09AF899C  token=0x6000982  System.Void _DestroyMaterial(UnityEngine.Material material)
  RVA=0x09AF8A74  token=0x6000983  System.Void _UpdateParam()
  RVA=0x03B0E4F0  token=0x6000984  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  RVA=0x039AA090  token=0x6000985  System.Void .ctor()
  RVA=0x03D229E0  token=0x6000986  System.Void .cctor()
  RVA=0x058DD8AC  token=0x6000987  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x0589E548  token=0x6000988  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  RVA=0x058DD8A4  token=0x6000989  System.Void <>iFixBaseProxy_OnDisable()
END_CLASS

CLASS: Beyond.UI.UIWorldLevelScrollListAnimCtrl
TYPE:  class
TOKEN: 0x2000108
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfoupLayoutGroup  // 0x18
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfodownLayoutGroup  // 0x20
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfomiddleLayoutGroup  // 0x28
  public            UnityEngine.AnimationCurve      speedCurve  // 0x30
  private           System.Collections.IEnumerator  m_enumerator  // 0x38
  private           System.String                   _audioEnd  // 0x40
METHODS:
  RVA=0x09AF9094  token=0x600098A  System.Void UpdateUpPos(System.Int32 current)
  RVA=0x09AF8EC4  token=0x600098B  System.Void UpdateDownPos(System.Int32 current)
  RVA=0x09AF8FA8  token=0x600098C  System.Void UpdateMidPos(System.Int32 current)
  RVA=0x09AF9150  token=0x600098D  System.Void UpdateWorldLevelScrollList(System.Boolean isUp, System.Int32 count)
  RVA=0x09AF8E54  token=0x600098E  System.Void OnDisable()
  RVA=0x09AF91FC  token=0x600098F  System.Collections.IEnumerator _ScrollLayouts(System.Boolean isUp, System.Int32 count)
  RVA=0x09AF92B0  token=0x6000990  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.VirtualMouseInitPos
TYPE:  class
TOKEN: 0x200010B
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.LuaPanel              m_panel  // 0x18
PROPERTIES:
  panel  get=0x09AF9474
METHODS:
  RVA=0x09AF92F8  token=0x600099A  System.Void OnEnable()
  RVA=0x0426FE60  token=0x600099B  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CSPopupPanel
TYPE:  class
TOKEN: 0x200010C
SIZE:  0x68
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public    static  System.String                   KEY  // const
  public            Beyond.UI.UIButton              confirmBtn  // 0x18
  public            Beyond.UI.UIButton              cancelBtn  // 0x20
  public            Beyond.UI.UIText                contentTxt  // 0x28
  public            UnityEngine.GameObject          bg1  // 0x30
  public            UnityEngine.GameObject          bg2  // 0x38
  public            UnityEngine.GameObject          warningImg  // 0x40
  public            Beyond.UI.UIScrollRect          scrollRect  // 0x48
  private           System.Action                   m_onConfirm  // 0x50
  private           System.Action                   m_onCancel  // 0x58
  private   static  Beyond.Resource.FAssetProxyHandles_handle  // static @ 0x0
  public    static  System.Collections.Generic.HashSet<Beyond.UI.CSPopupPanel>s_instances  // static @ 0x18
  public            System.Int32                    timeScaleKey  // 0x60
METHODS:
  RVA=0x09AEDDB4  token=0x600099C  System.Void Awake()
  RVA=0x09AEE7E4  token=0x600099D  System.Void _OnConfirm(UnityEngine.EventSystems.PointerEventData p)
  RVA=0x09AEE740  token=0x600099E  System.Void _OnCancel(UnityEngine.EventSystems.PointerEventData p)
  RVA=0x09AEE0EC  token=0x600099F  System.Void OnDestroy()
  RVA=0x09AEE2B0  token=0x60009A0  System.Void Show(System.String content, System.Action onConfirm, System.Boolean showCancel, System.Action onCancel, System.String confirmTxt, System.String cancelTxt, System.Boolean showWarning)
  RVA=0x09AEDEF8  token=0x60009A1  System.Void ClearAllPanels()
  RVA=0x0426FE60  token=0x60009A2  System.Void .ctor()
  RVA=0x09AEE888  token=0x60009A3  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.LuaUIRoot
TYPE:  class
TOKEN: 0x200010D
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
  public            Beyond.SerializeReferenceDictionary<System.String,Beyond.UI.LuaUIRootNode>nodeDic  // 0x18
METHODS:
  RVA=0x09AEFF4C  token=0x60009A4  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.LuaUIRootNode
TYPE:  class
TOKEN: 0x200010E
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
  public            System.String                   panelName  // 0x18
  public            System.String                   panelFolder  // 0x20
METHODS:
  RVA=0x0426FE60  token=0x60009A5  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.MobileMotionManager
TYPE:  class
TOKEN: 0x200010F
SIZE:  0x20
EXTENDS: Beyond.BaseManager
FIELDS:
  private   static  System.String                   COMMON_MOTION_SHORT  // const
  private   static  System.String                   COMMON_MOTION_OPERATE_SUCCESS  // const
  private   static  System.String                   COMMON_MOTION_OPERATE_FAILURE  // const
  private   static  System.String                   MOTION_LEVEL_LOW  // const
  private   static  System.String                   MOTION_LEVEL_MEDIUM  // const
  private   static  System.String                   MOTION_LEVEL_HIGH  // const
  private           Beyond.UI.MobileMotionManager.MotionLevelm_currMotionLevel  // 0x18
METHODS:
  RVA=0x02CD09D0  token=0x60009A6  System.Void OnInit()
  RVA=0x09AEFFCC  token=0x60009A7  System.Void OnRelease()
  RVA=0x03CF76A0  token=0x60009A8  System.UInt32 PostEventCommonShort()
  RVA=0x09AF0150  token=0x60009A9  System.UInt32 PostEventCommonOperateSuccess()
  RVA=0x09AF00DC  token=0x60009AA  System.UInt32 PostEventCommonOperateFailure()
  RVA=0x09AF01C4  token=0x60009AB  System.UInt32 PostEvent(System.String eventName)
  RVA=0x02CD0800  token=0x60009AC  System.Void _CheckMotionLevelAndPostIfChange()
  RVA=0x0350B670  token=0x60009AD  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.I18nFontLoader
TYPE:  static class
TOKEN: 0x2000111
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int32,Beyond.Resource.FAssetProxyHandle>s_id2FontDic  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>s_name2MaterialDic  // static @ 0x8
  private   static  Beyond.Resource.FAssetProxyHandles_fontSearchDataHandle  // static @ 0x10
PROPERTIES:
  fontSearchData  get=0x02860380
METHODS:
  RVA=0x02860540  token=0x60009AF  System.Boolean IsInvalid()
  RVA=0x09AEFD00  token=0x60009B0  UnityEngine.Material GetMaterial(System.String matName)
  RVA=0x02860000  token=0x60009B1  TMPro.TMP_FontAsset GetI18nFont(System.Int32 cnFontId)
  RVA=0x09AEFC60  token=0x60009B2  System.Int32 GetCNFontId(TMPro.TMP_FontAsset font)
  RVA=0x03113EA0  token=0x60009B3  System.Boolean IsFontDefaultMaterial(UnityEngine.Material mat)
  RVA=0x03C7B060  token=0x60009B4  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.DynamicFontAssetLoader
TYPE:  class
TOKEN: 0x2000112
SIZE:  0x18
IMPLEMENTS: TMPro.IFontAssetLoader
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef><fontAssets>k__BackingField  // 0x10
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_notFoundUnicodes  // static @ 0x0
PROPERTIES:
  fontAssets  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0370A950  token=0x60009B7  System.Void .ctor()
  RVA=0x03A14990  token=0x60009B8  System.Void AddNotFoundUnicode(System.UInt32 unicode, System.Boolean forceLog)
  RVA=0x09AEEAC0  token=0x60009B9  System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset)
  RVA=0x09AEEF18  token=0x60009BA  System.Void TryRemoveRefText(TMPro.TMP_Text refText)
  RVA=0x09AEE91C  token=0x60009BB  System.Void Dispose()
  RVA=0x03CE4A20  token=0x60009BC  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.TweenUtils
TYPE:  static class
TOKEN: 0x2000114
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0262E4C0  token=0x60009C1  System.Boolean TickAsCountDown(System.Single& countDown, System.Single timeDelta)
END_CLASS

CLASS: Beyond.UI.UIAnimationLayerMixPlayer
TYPE:  class
TOKEN: 0x2000116
SIZE:  0x70
EXTENDS: Beyond.Playables.SingleMixerAssetPlayer`4
FIELDS:
  private           UnityEngine.Animator            m_target  // 0x60
  private           System.String                   m_outputName  // 0x68
METHODS:
  RVA=0x03099F80  token=0x60009C7  System.Void .ctor(UnityEngine.Animator target, System.String outputName)
  RVA=0x030995A0  token=0x60009C8  System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos)
  RVA=0x02967810  token=0x60009C9  UnityEngine.Playables.PlayableGraph CreateGraph()
  RVA=0x02967990  token=0x60009CA  UnityEngine.Animations.AnimationLayerMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options)
  RVA=0x02967860  token=0x60009CB  UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x02967640  token=0x60009CC  UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta)
END_CLASS

CLASS: Beyond.UI.UIAnimationMixPlayer
TYPE:  class
TOKEN: 0x2000117
SIZE:  0x70
EXTENDS: Beyond.Playables.SingleMixerAssetPlayer`4
FIELDS:
  private           UnityEngine.Animator            m_target  // 0x60
  private           System.String                   m_outputName  // 0x68
METHODS:
  RVA=0x03099CE0  token=0x60009CD  System.Void .ctor(UnityEngine.Animator target, System.String outputName)
  RVA=0x03099D50  token=0x60009CE  System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos)
  RVA=0x02966AF0  token=0x60009CF  UnityEngine.Playables.PlayableGraph CreateGraph()
  RVA=0x02966FD0  token=0x60009D0  UnityEngine.Animations.AnimationMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options)
  RVA=0x02966C20  token=0x60009D1  UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x02966540  token=0x60009D2  UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta)
END_CLASS

CLASS: Beyond.UI.UIListCache`1
TYPE:  class
TOKEN: 0x2000118
FIELDS:
  private           Beyond.UI.UIListCache.FOptions<TComp>m_options  // 0x0
  private           System.Collections.Generic.List<Beyond.UI.UIListCache.ItemWrapper<TComp>>m_items  // 0x0
  private           System.Int32                    m_count  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60009D3  System.Void .ctor(Beyond.UI.UIListCache.FOptions<TComp> options)
  RVA=-1  // not resolved  token=0x60009D4  System.Void Refresh(System.Int32 count, System.Action<TComp,System.Int32> refreshFunc, System.Boolean shouldHide, System.Action<TComp,System.Int32> onDisableFunc)
  RVA=-1  // not resolved  token=0x60009D5  TComp GetItem(System.Int32 index)
  RVA=-1  // not resolved  token=0x60009D6  Beyond.UI.UIListCache.ItemWrapper<TComp> _CreateNewItem()
END_CLASS

CLASS: Beyond.UI.UILoadImageSprite
TYPE:  class
TOKEN: 0x200011B
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  isAsync  // 0x18
  public            System.Boolean                  setNativeSize  // 0x19
  protected         System.String                   m_spritePath  // 0x20
  protected         UnityEngine.UI.Image            m_imageComp  // 0x28
  protected         Beyond.Resource.FAssetProxyHandlem_handle  // 0x30
PROPERTIES:
  spritePath  get=0x03D4EB40  set=0x09AF65DC
METHODS:
  RVA=0x09AF6250  token=0x60009DA  System.Void OnDestroy()
  RVA=0x09AF62B0  token=0x60009DB  System.Void _LoadSprite(System.String path)
  RVA=0x0426FE60  token=0x60009DC  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILoadImageSpriteByName
TYPE:  class
TOKEN: 0x200011D
SIZE:  0x50
EXTENDS: Beyond.UI.UILoadImageSprite
FIELDS:
  private           System.String                   _folderPath  // 0x48
PROPERTIES:
  spriteName  set=0x09AF61A8
METHODS:
  RVA=0x0426FE60  token=0x60009E0  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISwitchTween
TYPE:  abstract class
TOKEN: 0x200011E
SIZE:  0x30
FIELDS:
  private           Beyond.UI.UISwitchTween.Options m_options  // 0x10
  private           Beyond.UI.UISwitchTween.ITweenHandlerm_tween  // 0x20
  private           System.Boolean                  m_isInited  // 0x28
  private           System.Boolean                  m_isShowing  // 0x29
  private           Beyond.UI.UISwitchTween.TweenContextm_context  // 0x2c
PROPERTIES:
  isTweening  get=0x02C3C750
  isShow  get=0x03D4F2A0  set=0x02C3B950
METHODS:
  RVA=-1  // abstract  token=0x60009E1  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  RVA=-1  // abstract  token=0x60009E2  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  RVA=0x09AF6BC0  token=0x60009E3  System.Void BeforeShowEffect()
  RVA=0x02C3C1E0  token=0x60009E4  System.Void BeforeHideEffect()
  RVA=0x03A4EA30  token=0x60009E5  System.Void AfterShowEffect()
  RVA=0x09AF6B7C  token=0x60009E6  System.Void AfterHideEffect()
  RVA=0x09AF6C50  token=0x60009E7  System.Void ResetToState(System.Boolean isShow)
  RVA=0x02C3BC90  token=0x60009E8  System.Void Show()
  RVA=0x02C3B980  token=0x60009E9  System.Void Hide()
  RVA=0x09AF6D18  token=0x60009EA  System.Collections.IEnumerator WaitForTweening()
  RVA=0x09AF6CA4  token=0x60009EB  System.Void SetOptions(Beyond.UI.UISwitchTween.Options options)
  RVA=0x02C3C210  token=0x60009EF  System.Void Reset(System.Boolean isShow)
  RVA=0x02C3DF40  token=0x60009F0  System.Void Clear()
  RVA=0x02C3C270  token=0x60009F1  System.Void _ClearTweenInternal(System.Boolean isReset)
  RVA=0x09AF6C04  token=0x60009F2  Beyond.UI.UISwitchTween.TweenContext GetContext()
  RVA=0x02C3C310  token=0x60009F3  System.Void ClearTween()
  RVA=0x0350B670  token=0x60009F4  System.Void .ctor()
  RVA=0x03A4EA00  token=0x60009F5  System.Void <Show>b__17_0()
  RVA=0x03CA7C40  token=0x60009F6  System.Void <Hide>b__18_0()
END_CLASS

CLASS: Beyond.UI.FadeSwitchTween
TYPE:  class
TOKEN: 0x2000125
SIZE:  0x58
EXTENDS: Beyond.UI.UISwitchTween
FIELDS:
  public    static  System.Single                   DEFAULT_TWEEN_DURATION  // const
  private           UnityEngine.CanvasGroup         m_alphaHandler  // 0x30
  private           System.Boolean                  m_ignoreTimeScale  // 0x38
  private           System.Single                   m_activeAlpha  // 0x3c
  private           System.Boolean                  <dontDisableGameObject>k__BackingField  // 0x40
  private           System.Boolean                  <controlBlockRaycast>k__BackingField  // 0x41
  private           Beyond.UI.FadeSwitchTween.Durations<complexDuration>k__BackingField  // 0x44
  private           System.Single                   <duration>k__BackingField  // 0x54
PROPERTIES:
  dontDisableGameObject  get=0x03D4EE90  set=0x03D4EEB0
  controlBlockRaycast  get=0x03D4F7B0  set=0x03D4F7D0
  complexDuration  get=0x03D76190  set=0x03D761A0
  duration  get=0x03D4F670  set=0x03D4F680
  alphaHandler  get=0x01003830
  activeAlpha  get=0x03D4EC60  set=0x09AEF2AC
METHODS:
  RVA=0x09AEF288  token=0x6000A15  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Boolean ignoreTimeScale)
  RVA=0x03653350  token=0x6000A16  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x03676350  token=0x6000A1C  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  RVA=0x03676490  token=0x6000A1D  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  RVA=0x035FFC60  token=0x6000A1E  System.Void BeforeShowEffect()
  RVA=0x035FFCC0  token=0x6000A1F  System.Void AfterHideEffect()
  RVA=0x035FFD00  token=0x6000A20  System.Void ResetToState(System.Boolean isShow)
  RVA=0x035FFD70  token=0x6000A21  System.Void SetObjectActive(UnityEngine.CanvasGroup alphaHandler, System.Boolean isActive)
  RVA=0x09AEF238  token=0x6000A22  System.Void Release()
  RVA=0x09AC3758  token=0x6000A23  System.Void <>iFixBaseProxy_BeforeShowEffect()
  RVA=0x09AC3750  token=0x6000A24  System.Void <>iFixBaseProxy_AfterHideEffect()
  RVA=0x09AC3760  token=0x6000A25  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.FadeTranslationSwitchTween
TYPE:  class
TOKEN: 0x2000128
SIZE:  0x60
EXTENDS: Beyond.UI.UISwitchTween
FIELDS:
  private   static  System.Single                   DEFAULT_TWEEN_DURATION  // const
  private           UnityEngine.CanvasGroup         m_alphaHandler  // 0x30
  private           UnityEngine.RectTransform       m_posHandler  // 0x38
  private           UnityEngine.Vector2             m_hidePos  // 0x40
  private           UnityEngine.Vector2             m_showPos  // 0x48
  private           System.Single                   m_duration  // 0x50
  private           System.Single                   m_hideDelay  // 0x54
  private           System.Single                   m_showDelay  // 0x58
METHODS:
  RVA=0x09AEF814  token=0x6000A29  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, UnityEngine.RectTransform posHandler, UnityEngine.Vector2 hidePos, UnityEngine.Vector2 showPos, System.Single duration, System.Single hideDelay, System.Single showDelay)
  RVA=0x09AEF3F0  token=0x6000A2A  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  RVA=0x09AEF530  token=0x6000A2B  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  RVA=0x09AEF38C  token=0x6000A2C  System.Void BeforeShowEffect()
  RVA=0x09AEF328  token=0x6000A2D  System.Void AfterHideEffect()
  RVA=0x09AEF670  token=0x6000A2E  System.Void ResetToState(System.Boolean isShow)
  RVA=0x09AEF734  token=0x6000A2F  System.Single _GetTargetAlpha(System.Boolean isShow)
  RVA=0x09AEF79C  token=0x6000A30  UnityEngine.Vector2 _GetTargetPos(System.Boolean isShow)
  RVA=0x09AC3758  token=0x6000A31  System.Void <>iFixBaseProxy_BeforeShowEffect()
  RVA=0x09AC3750  token=0x6000A32  System.Void <>iFixBaseProxy_AfterHideEffect()
  RVA=0x09AC3760  token=0x6000A33  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.UIAtlasManager
TYPE:  class
TOKEN: 0x200012A
SIZE:  0x50
EXTENDS: Beyond.Singleton`1
FIELDS:
  private           Beyond.TickFunction             m_lateTickFunction  // 0x10
  public    static  System.Int32                    ATLAS_PAGE_WIDTH  // const
  public    static  System.Int32                    ATLAS_PAGE_HEIGHT  // const
  public    static  System.Int32                    IMAGE_USING_ATLAS_MAX_SIZE  // const
  public    static  System.Int32                    UI_IMAGE_BLOCK_ALIGNMENT  // const
  public    static  System.Int32                    PANEL_LEVEL_COUNT  // const
  public    static  System.Int32                    MAX_ATLAS_PER_PANEL_LEVEL  // const
  public    static  System.Int32                    PROCESS_COUNT_PER_FRAME  // const
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatATLAS_PAGE_FORMAT  // const
  private           System.Boolean                  m_enableRuntimeAtlas  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIImage>m_imageDict  // 0x20
  private           Beyond.UI.UIAtlasManager.UIAtlasPage[,]m_atlasPagePool  // 0x28
  private           System.Collections.Generic.Queue<Beyond.UI.UIImage>m_insertQueue  // 0x30
  private           System.Collections.Generic.Queue<Beyond.UI.UIAtlasManager.UIAtlasHandle>m_freeQueue  // 0x38
  private           UnityEngine.Rendering.CommandBufferm_commandBuffer  // 0x40
  private           UnityEngine.Experimental.Rendering.GraphicsFormatm_atlasPageFormat  // 0x48
  private   static  System.Boolean                  <enableRuntimeAtlasFromScript>k__BackingField  // static @ 0x0
PROPERTIES:
  enableRuntimeAtlas  get=0x025CB4D0
  enableRuntimeAtlasFromScript  get=0x09AF5BD8  set=0x09AF5C10
  releaseImageSpriteAfterInsert  get=0x0232EB60
METHODS:
  RVA=0x09AF5BA0  token=0x6000A3D  System.Void .ctor()
  RVA=0x09AF438C  token=0x6000A3E  System.Void OnInit()
  RVA=0x09AF458C  token=0x6000A3F  System.Void OnUnInit()
  RVA=0x09AF4660  token=0x6000A40  System.Void Release()
  RVA=0x09AF4AB0  token=0x6000A41  System.Void _CreateTickFunction()
  RVA=0x09AF4A48  token=0x6000A42  System.Void _ClearTickFunction()
  RVA=0x09AF41DC  token=0x6000A43  System.Void AddUIImageToManager(Beyond.UI.UIImage image)
  RVA=0x09AF45DC  token=0x6000A44  System.Void ReProcessInsertForUIImage(Beyond.UI.UIImage image)
  RVA=0x025CB630  token=0x6000A45  System.Void RemoveUIImageFromManager(Beyond.UI.UIImage image)
  RVA=0x025CB7B0  token=0x6000A46  System.Void AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image)
  RVA=0x09AF4260  token=0x6000A47  System.Int32 GetAtlasCount()
  RVA=0x09AF4324  token=0x6000A48  System.Void LateTick(System.Single deltaTime)
  RVA=0x09AF494C  token=0x6000A49  System.Void _AddUIImageToManager(Beyond.UI.UIImage image)
  RVA=0x09AF58D4  token=0x6000A4A  System.Void _ReProcessInsertForUIImage(Beyond.UI.UIImage image)
  RVA=0x09AF5A38  token=0x6000A4B  System.Void _RemoveUIImageFromManager(Beyond.UI.UIImage image)
  RVA=0x09AF46B0  token=0x6000A4C  System.Void _AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image)
  RVA=0x09AF4BD8  token=0x6000A4D  System.Boolean _IsRuntimeAtlasCompatible(Beyond.UI.UIImage image, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& failureCause)
  RVA=0x09AF4EEC  token=0x6000A4E  System.Void _ProcessInsertQueue()
  RVA=0x09AF561C  token=0x6000A4F  System.Void _ProcessRemoveQueue()
END_CLASS

CLASS: Beyond.UI.UIRedDotAnimation
TYPE:  class
TOKEN: 0x2000130
SIZE:  0x30
EXTENDS: Beyond.Singleton`1
FIELDS:
  private           Beyond.UI.UIGraphicAnimation    m_uiGraphicAnimation  // 0x10
  private           UnityEngine.Material            m_materialInstance  // 0x18
  private           System.Collections.Generic.HashSet<Beyond.UI.UIImage>m_redDotImages  // 0x20
  private           UnityEngine.GameObject          m_root  // 0x28
METHODS:
  RVA=0x03CF1170  token=0x6000A5F  System.Void .ctor()
  RVA=0x0399BA90  token=0x6000A60  System.Void Init(UnityEngine.GameObject redDotAnimationRoot)
  RVA=0x09AF6660  token=0x6000A61  System.Void UnInit()
  RVA=0x02E80D30  token=0x6000A62  System.Void AddRedDotImage(Beyond.UI.UIImage img)
  RVA=0x02E80B40  token=0x6000A63  System.Void RemoveRedDotImage(Beyond.UI.UIImage img)
  RVA=0x02E80E10  token=0x6000A64  System.Void _UpdateRedDotAnimation()
END_CLASS

CLASS: Beyond.UI.UIRedDotAnimationNode
TYPE:  class
TOKEN: 0x2000131
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIImage               m_image  // 0x18
METHODS:
  RVA=0x036A3DA0  token=0x6000A65  System.Void Awake()
  RVA=0x02E80C80  token=0x6000A66  System.Void OnEnable()
  RVA=0x02E80BD0  token=0x6000A67  System.Void OnDisable()
  RVA=0x0426FE60  token=0x6000A68  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.WebApplication
TYPE:  static class
TOKEN: 0x2000132
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09AF952C  token=0x6000A69  System.Void Start(System.String url, System.Action onClose)
END_CLASS

CLASS: Beyond.UI.GPUI.ChangeState
TYPE:  sealed struct
TOKEN: 0x2000146
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.ChangeState      Stable  // const
  public    static  Beyond.UI.GPUI.ChangeState      New  // const
  public    static  Beyond.UI.GPUI.ChangeState      ChangeSize  // const
  public    static  Beyond.UI.GPUI.ChangeState      ChangeData  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeNodeInfo
TYPE:  sealed struct
TOKEN: 0x2000147
SIZE:  0x40
FIELDS:
  public            Beyond.UI.GPUI.NodeType         nodeType  // 0x10
  public            Beyond.UI.GPUI.SimpleTextAlignmenttextAlignment  // 0x14
  public            System.Int32                    nodeIndex  // 0x18
  public            System.Int32                    childNodeCount  // 0x1c
  public            System.UInt32                   color  // 0x20
  public            UnityEngine.Vector2             position  // 0x24
  public            System.String                   textOverride  // 0x30
  public            System.Boolean                  changed  // 0x38
  public            System.Boolean                  hide  // 0x39
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeAnimationData
TYPE:  class
TOKEN: 0x2000148
SIZE:  0x28
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Single                   duration  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData>template  // 0x20
METHODS:
  RVA=0x02AD9170  token=0x6000AC6  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimePrefabData
TYPE:  class
TOKEN: 0x2000149
SIZE:  0x30
FIELDS:
  public            System.Int32                    templateNodeCount  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeNodeInfo>nodes  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.Int32>nodesNameMap  // 0x20
  public            System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeAnimationData>animations  // 0x28
METHODS:
  RVA=0x02AD9750  token=0x6000AC7  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUPrefabData
TYPE:  sealed struct
TOKEN: 0x200014A
SIZE:  0x60
FIELDS:
  public            UnityEngine.Vector4             uv  // 0x10
  public            UnityEngine.Vector4             aniPosScaleMinMax  // 0x20
  public            UnityEngine.Vector4             aniPosAddMinMax  // 0x30
  public            UnityEngine.Vector2             aniURange  // 0x40
  public            System.Single                   aniPosScaleV  // 0x48
  public            System.Single                   aniPosAddV  // 0x4c
  public            System.Single                   aniColorV  // 0x50
  public            System.Single                   aniDurationInv  // 0x54
  public            System.Int32                    materialType  // 0x58
  public            System.UInt32                   materialParam1  // 0x5c
METHODS:
  RVA=0x02AD9430  token=0x6000AC8  System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data)
  RVA=0x034F73A0  token=0x6000AC9  System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale)
  RVA=0x034F7300  token=0x6000ACA  Beyond.UI.GPUI.GPUPrefabData CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
END_CLASS

CLASS: Beyond.UI.GPUI.GPUPrefabDataLite
TYPE:  sealed struct
TOKEN: 0x200014B
SIZE:  0x40
FIELDS:
  public            System.Int16                    uvX  // 0x10
  public            System.Int16                    uvY  // 0x12
  public            System.Int16                    uvZ  // 0x14
  public            System.Int16                    uvW  // 0x16
  public            System.UInt16                   aniPosScaleMinX  // 0x18
  public            System.UInt16                   aniPosScaleMinY  // 0x1a
  public            System.UInt16                   aniPosScaleMaxX  // 0x1c
  public            System.UInt16                   aniPosScaleMaxY  // 0x1e
  public            System.UInt16                   aniPosAddMinX  // 0x20
  public            System.UInt16                   aniPosAddMinY  // 0x22
  public            System.UInt16                   aniPosAddMaxX  // 0x24
  public            System.UInt16                   aniPosAddMaxY  // 0x26
  public            System.Int16                    aniURangeX  // 0x28
  public            System.Int16                    aniURangeY  // 0x2a
  public            System.Int16                    aniPosScaleV  // 0x2c
  public            System.Int16                    aniPosAddV  // 0x2e
  public            System.Int16                    aniColorV  // 0x30
  public            System.Int16                    aniDuration  // 0x32
  public            System.UInt16                   materialType  // 0x34
  public            System.UInt16                   materialParam1  // 0x36
  public            System.UInt32                   padding  // 0x38
  public            System.UInt32                   padding2  // 0x3c
METHODS:
  RVA=0x09B0AE8C  token=0x6000ACB  System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data, UnityEngine.Vector2 texelSizeInv, UnityEngine.Vector2 aniTexelSizeInv)
  RVA=0x09B0B0E4  token=0x6000ACC  System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
  RVA=0x09B0AD98  token=0x6000ACD  Beyond.UI.GPUI.GPUPrefabDataLite CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
END_CLASS

CLASS: Beyond.UI.GPUI.GPUInstanceData
TYPE:  sealed struct
TOKEN: 0x200014C
SIZE:  0x30
FIELDS:
  public            System.Single                   animeTime  // 0x10
  public            System.UInt32                   color  // 0x14
  public            UnityEngine.Vector2             pos  // 0x18
  public            System.UInt16                   prefabId  // 0x20
  public            System.UInt16                   parentId  // 0x22
  public            System.UInt16                   grandParentId  // 0x24
  public            System.Byte                     matType  // 0x26
  public            System.Byte                     drawType  // 0x27
  public            System.UInt32                   padding0  // 0x28
  public            System.UInt32                   padding1  // 0x2c
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.NodeType
TYPE:  sealed struct
TOKEN: 0x200014D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.NodeType         Root  // const
  public    static  Beyond.UI.GPUI.NodeType         Image  // const
  public    static  Beyond.UI.GPUI.NodeType         Text  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleTextAlignment
TYPE:  sealed struct
TOKEN: 0x200014E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentLeft  // const
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentCenter  // const
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentRight  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.NodeSerializeData
TYPE:  class
TOKEN: 0x200014F
SIZE:  0x60
FIELDS:
  public            UnityEngine.Vector4             uv  // 0x10
  public            UnityEngine.Vector4             aniPosScaleMinMax  // 0x20
  public            UnityEngine.Vector4             aniPosAddMinMax  // 0x30
  public            UnityEngine.Vector2             aniURange  // 0x40
  public            System.Single                   aniPosScaleV  // 0x48
  public            System.Single                   aniPosAddV  // 0x4c
  public            System.Single                   aniColorV  // 0x50
  public            System.Single                   aniDurationInv  // 0x54
  public            System.Int32                    materialType  // 0x58
  public            System.UInt32                   materialParam1  // 0x5c
METHODS:
  RVA=0x0350B670  token=0x6000ACE  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.NodeMetadata
TYPE:  class
TOKEN: 0x2000150
SIZE:  0x38
FIELDS:
  public            System.String                   nodeName  // 0x10
  public            Beyond.UI.GPUI.NodeType         nodeType  // 0x18
  public            System.String                   nodeTextId  // 0x20
  public            System.String                   nodeText  // 0x28
  public            Beyond.UI.GPUI.SimpleTextAlignmenttextAlignment  // 0x30
  public            System.Single                   nodeTextSize  // 0x34
METHODS:
  RVA=0x0350B670  token=0x6000ACF  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.AnimationSerializeData
TYPE:  class
TOKEN: 0x2000151
SIZE:  0x28
FIELDS:
  public            System.String                   animationName  // 0x10
  public            System.Single                   animationTime  // 0x18
  public            System.Int32                    totalFrames  // 0x1c
  public            UnityEngine.WrapMode            wrapMode  // 0x20
  public            System.Int32                    renderNodesOffset  // 0x24
METHODS:
  RVA=0x0350B670  token=0x6000AD0  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.PrefabSerializeData
TYPE:  class
TOKEN: 0x2000152
SIZE:  0x38
FIELDS:
  public            System.String                   prefabName  // 0x10
  public            System.Int32                    nodeCount  // 0x18
  public            System.Boolean                  animationOnly  // 0x1c
  public            System.Collections.Generic.List<Beyond.UI.GPUI.NodeMetadata>nodeMetas  // 0x20
  public            System.Collections.Generic.List<Beyond.UI.GPUI.NodeSerializeData>renderNodes  // 0x28
  public            System.Collections.Generic.List<Beyond.UI.GPUI.AnimationSerializeData>animations  // 0x30
METHODS:
  RVA=0x0354E040  token=0x6000AD1  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.PrefabGroupSerializeData
TYPE:  class
TOKEN: 0x2000153
SIZE:  0x38
IMPLEMENTS: Beyond.MemoryPack.IMemoryPackSerialize
FIELDS:
  public            Beyond.Resource.StringPathHash  spriteTexturePath  // 0x10
  public            Beyond.Resource.StringPathHash  vatTexturePath  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.GPUI.PrefabSerializeData>prefabs  // 0x20
  public            System.Collections.Generic.List<System.String>textIds  // 0x28
  public            System.String                   importantChars  // 0x30
METHODS:
  RVA=0x039A00F0  token=0x6000AD2  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUIHandle
TYPE:  sealed struct
TOKEN: 0x2000154
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    version  // 0x14
METHODS:
  RVA=0x09B09030  token=0x6000AD3  System.Boolean Equals(Beyond.UI.GPUI.GPUIHandle other)
  RVA=0x09B0909C  token=0x6000AD4  System.Boolean Equals(System.Object obj)
  RVA=0x09B09138  token=0x6000AD5  System.Int32 GetHashCode()
  RVA=0x09B09238  token=0x6000AD6  System.Boolean op_Equality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right)
  RVA=0x09B092A4  token=0x6000AD7  System.Boolean op_Inequality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right)
  RVA=0x09B09188  token=0x6000AD8  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  RVA=0x09B091E8  token=0x6000AD9  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUISystem
TYPE:  class
TOKEN: 0x2000155
SIZE:  0x1E0
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
  public    static readonly System.String                   CONFIG_JSON_PATH_FORMAT  // static @ 0x0
  public    static readonly System.Int32                    RENDER_GROUP_SIZE  // static @ 0x8
  public    static readonly System.Int32                    RENDER_GROUP_SIZE_GL  // static @ 0xc
  public            System.Collections.Generic.List<UnityEngine.Material>materialTemplates  // 0xe8
  public            System.String                   configGroupName  // 0xf0
  public            System.Int32                    sourceCNFontId  // 0xf8
  private           TMPro.TMP_FontAsset             m_i18NFontAsset  // 0x100
  public            System.Boolean                  noSortingOrder  // 0x108
  private           System.Boolean                  m_liteMode  // 0x109
  private           System.Boolean                  m_inited  // 0x10a
  private           System.Boolean                  m_rendererDisabled  // 0x10b
  private           System.Collections.Generic.List<UnityEngine.Material>m_instancedMaterials  // 0x110
  private           UnityEngine.Texture             m_vatTexture  // 0x118
  private           UnityEngine.Texture             m_spriteTexture  // 0x120
  private           Beyond.Resource.FAssetProxyHandlem_vatTextureHandle  // 0x128
  private           Beyond.Resource.FAssetProxyHandlem_spriteTextureHandle  // 0x13c
  private           System.Single                   m_timeForShader  // 0x150
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.GPUI.RuntimePrefabData>m_prefabMap  // 0x158
  private           UnityEngine.Transform           m_targetCanvasTransform  // 0x160
  private           UnityEngine.Matrix4x4           m_canvasObjectToWorldMatrix  // 0x168
  private           System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance>m_instances  // 0x1a8
  private           System.Collections.Generic.Queue<System.Int32>m_recyclePool  // 0x1b0
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single,Beyond.UI.GPUI.GPUIHandle>>m_destroyQueue  // 0x1b8
  private           Beyond.UI.GPUI.ITextSystem      m_simpleTextSystem  // 0x1c0
  private           Beyond.UI.GPUI.InstanceBufferManagerm_instanceBufferManager  // 0x1c8
  private           Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabData>m_prefabBufferManager  // 0x1d0
  private           Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabDataLite>m_litePrefabBufferManager  // 0x1d8
PROPERTIES:
  fontAsset  get=0x03614580  set=0x09B0A774
METHODS:
  RVA=0x09B09310  token=0x6000ADC  System.Boolean CreateInstance(System.String prefabName, UnityEngine.Vector3 initialPosition, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder)
  RVA=0x09B09404  token=0x6000ADD  System.Boolean DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle)
  RVA=0x09B09494  token=0x6000ADE  System.Boolean IsInstanceValid(Beyond.UI.GPUI.GPUIHandle handle)
  RVA=0x09B09764  token=0x6000ADF  System.Boolean SetRootPosition(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector3 position)
  RVA=0x09B09868  token=0x6000AE0  System.Boolean SetRootScale(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector2 scale)
  RVA=0x09B09B80  token=0x6000AE1  System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.String animationName, System.Boolean resetDestroy)
  RVA=0x09B09F84  token=0x6000AE2  System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.Int32 animationIndex, System.Boolean resetDestroy)
  RVA=0x09B09A80  token=0x6000AE3  System.Boolean SetVisibility(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.Boolean visible)
  RVA=0x09B0960C  token=0x6000AE4  System.Boolean SetColor(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, UnityEngine.Color color)
  RVA=0x09B0994C  token=0x6000AE5  System.Boolean SetText(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.String text)
  RVA=0x09B094FC  token=0x6000AE6  System.Void OnDestroy()
  RVA=0x03613B80  token=0x6000AE7  System.Void OnEnable()
  RVA=0x09B09558  token=0x6000AE8  System.Void OnDisable()
  RVA=0x0398A460  token=0x6000AE9  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x037E2240  token=0x6000AEA  System.Void UpdateMaterial()
  RVA=0x0289C290  token=0x6000AEB  System.Void _PreWillRenderCanvases()
  RVA=0x03613CD0  token=0x6000AEC  System.Void _Init(System.String jsonPath)
  RVA=0x03614650  token=0x6000AED  TMPro.TMP_FontAsset GetFontAsset()
  RVA=0x0289C2D0  token=0x6000AEE  System.Void _DoLateUpdate()
  RVA=0x09B0A3DC  token=0x6000AEF  System.Void _DoOnDestroy()
  RVA=0x03614230  token=0x6000AF0  System.Void _RefreshMaterials()
  RVA=0x03614B40  token=0x6000AF1  System.Void _InitMaterials()
  RVA=0x036149B0  token=0x6000AF2  System.Void _CleanMaterials()
  RVA=0x0289C430  token=0x6000AF3  System.Void _RenderNodes()
  RVA=0x0289C390  token=0x6000AF4  System.Void _DestroyAnimatedInstance()
  RVA=0x03614E40  token=0x6000AF5  System.Void _UpdateWorldMat()
  RVA=0x02AD7250  token=0x6000AF6  System.Void _PreloadTextInGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data)
  RVA=0x02AD79D0  token=0x6000AF7  System.Void _LoadGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data)
  RVA=0x02AD82F0  token=0x6000AF8  Beyond.UI.GPUI.RuntimePrefabData _LoadPrefabData(Beyond.UI.GPUI.PrefabSerializeData prefab)
  RVA=0x02AD91F0  token=0x6000AF9  System.Int32 _LoadPrefabNodeBuffer(Beyond.UI.GPUI.PrefabSerializeData prefab, System.Int32 totalNodeCount)
  RVA=0x09B0A1C4  token=0x6000AFA  System.Boolean _CreateInstance(System.String prefabName, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder)
  RVA=0x09B0A300  token=0x6000AFB  System.Boolean _DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle)
  RVA=0x09B0A4E0  token=0x6000AFC  Beyond.UI.GPUI.GPUIHandle _GetOneHandle()
  RVA=0x09B0A62C  token=0x6000AFD  System.Boolean _IsHandleInvalid(Beyond.UI.GPUI.GPUIHandle handle)
  RVA=0x09B0A6E8  token=0x6000AFE  System.Void _RecycleOneHandle(Beyond.UI.GPUI.GPUIHandle handle)
  RVA=0x02E12010  token=0x6000AFF  System.Void .ctor()
  RVA=0x03CF7FA0  token=0x6000B00  System.Void .cctor()
  RVA=0x09B0A1A4  token=0x6000B01  System.Void <>iFixBaseProxy_OnDestroy()
  RVA=0x09B0A1B4  token=0x6000B02  System.Void <>iFixBaseProxy_OnEnable()
  RVA=0x09B0A1AC  token=0x6000B03  System.Void <>iFixBaseProxy_OnDisable()
  RVA=0x09AADB34  token=0x6000B04  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
  RVA=0x09B0A1BC  token=0x6000B05  System.Void <>iFixBaseProxy_UpdateMaterial()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUIUtils
TYPE:  static class
TOKEN: 0x2000157
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Vector3             DEFAULT_NORMAL  // static @ 0x0
  public    static readonly UnityEngine.Vector4             DEFAULT_TANGENT  // static @ 0xc
METHODS:
  RVA=0x09B0A8F8  token=0x6000B07  UnityEngine.Mesh CreateQuadMesh()
  RVA=0x09B0A868  token=0x6000B08  System.UInt32 ColorToRGBAUint32(UnityEngine.Color color)
  RVA=0x09B0AD30  token=0x6000B09  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.GPUI.InstanceBufferManager
TYPE:  class
TOKEN: 0x2000158
SIZE:  0x70
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  MARKER_UPDATE_PERF  // static @ 0x0
  private           Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange>m_gpuGroups  // 0x10
  private           System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance>m_runtimeInstanceView  // 0x20
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_bufferInternalNodes  // 0x28
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_pendingNodes  // 0x30
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_addNodes  // 0x38
  private           System.Collections.Generic.HashSet<Beyond.UI.GPUI.GPUIHandle>m_removeNodes  // 0x40
  private           System.Boolean                  m_hasAnyChanges  // 0x48
  private           System.Boolean                  m_updateBufferOnly  // 0x49
  private           System.Int32                    m_currentStartIndex  // 0x4c
  private           System.Int32                    m_currentLength  // 0x50
  private           System.Int32                    m_capacity  // 0x54
  private           System.Int32                    m_maxCapacity  // 0x58
  private           System.Int32                    m_nodeStride  // 0x5c
  private           System.Int32                    m_gpuGroupCapacity  // 0x60
  private           System.Int32                    m_groupCount  // 0x64
  private           System.Boolean                  m_noSortingOrder  // 0x68
PROPERTIES:
  startIndex  get=0x03D4EDF0
  nodeCount  get=0x03D4EED0
  capacity  get=0x03D4EEC0
  gpuGroups  get=0x03D30AF0
  gpuGroupCount  get=0x03D50B30
METHODS:
  RVA=0x03614710  token=0x6000B0F  System.Void .ctor(System.Int32 initCapacity, System.Int32 maxCapacity, System.Int32 nodeStride, System.Int32 gpuGroupCapacity, System.Boolean noSortingOrder)
  RVA=0x036146D0  token=0x6000B10  System.Void BindInstanceList(System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> runtimeInstanceView)
  RVA=0x09B0B6C0  token=0x6000B11  System.Void MarkNeedUpdate()
  RVA=0x09B0B7A0  token=0x6000B12  System.Void _FillInstanceQueue(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& oldBuffer, System.Int32& newTotalLength, System.Int32& newTotalLengthWithEmptySlot, System.Int32& fullUpdateIndex)
  RVA=0x0289B0D0  token=0x6000B13  System.Void DoUpdate(UnityEngine.CanvasRenderer canvasRenderer)
  RVA=0x09B08FA8  token=0x6000B14  System.Void _NewGpuGroup(System.Int32 start, System.Int32 end)
  RVA=0x09B0B410  token=0x6000B15  System.Void Add(Beyond.UI.GPUI.GPUIHandle instance)
  RVA=0x09B0B710  token=0x6000B16  System.Void Remove(Beyond.UI.GPUI.GPUIHandle instance)
  RVA=0x03614880  token=0x6000B17  System.Void _AllocBuffer(System.Int32 capacity)
  RVA=0x09B0B638  token=0x6000B18  System.Void Dispose()
  RVA=0x03D06F50  token=0x6000B19  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeInstance
TYPE:  class
TOKEN: 0x200015A
SIZE:  0x60
FIELDS:
  public    static  System.Int32                    ROOT_NODE_INDEX  // const
  public            System.Int32                    version  // 0x10
  public            Beyond.UI.GPUI.ChangeState      state  // 0x14
  public            System.Int32                    length  // 0x18
  public            System.Int32                    sortingOrder  // 0x1c
  private           Beyond.UI.GPUI.ITextSystem      m_textSystem  // 0x20
  private           Beyond.UI.GPUI.RuntimePrefabDatam_prefab  // 0x28
  private           Beyond.UI.GPUI.RuntimeAnimationDatam_animationData  // 0x30
  private           System.Int32                    m_prefabNodeOffset  // 0x38
  private           Beyond.UI.GPUI.RuntimeNodeInfo[]m_nodeInfo  // 0x40
  private           System.Int32                    m_nodeInfoCount  // 0x48
  private           System.Single                   m_animationDuration  // 0x4c
  private           System.Single                   m_animationTime  // 0x50
  private           UnityEngine.Vector2             m_rootScale  // 0x54
PROPERTIES:
  Prefab  get=0x03D4EAC0
  AnimationDuration  get=0x03D50200
METHODS:
  RVA=0x09B0BE48  token=0x6000B1C  System.Void Create(Beyond.UI.GPUI.RuntimePrefabData prefab, Beyond.UI.GPUI.ITextSystem textSystem)
  RVA=0x09B0C354  token=0x6000B1D  System.Void Recycle()
  RVA=0x09B0BFF0  token=0x6000B1E  System.Void DoUpdate(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& buffer, System.Int32 startIndexInBuffer, System.Boolean full)
  RVA=0x09B0C548  token=0x6000B1F  System.Void SetRootScale(UnityEngine.Vector2 rootScale)
  RVA=0x09B0C480  token=0x6000B20  System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position)
  RVA=0x09B0C7BC  token=0x6000B21  System.Void StartAnimation(System.Single animationTime, System.Int32 animationIndex)
  RVA=0x09B0C738  token=0x6000B22  System.Void SetVisibility(System.Int32 index, System.Boolean visible)
  RVA=0x09B0C3A8  token=0x6000B23  System.Void SetColor(System.Int32 index, UnityEngine.Color newColor)
  RVA=0x09B0C5AC  token=0x6000B24  System.Void SetText(System.Int32 index, System.String text)
  RVA=0x0350B670  token=0x6000B25  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleBufferManager`1
TYPE:  class
TOKEN: 0x200015B
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Int32                    m_objectSize  // 0x0
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_capacity  // 0x0
  private           System.Boolean                  m_isFrozen  // 0x0
  private           System.Int32                    m_writingRef  // 0x0
  private           UnityEngine.CanvasRenderer      m_canvasRenderer  // 0x0
  private           Unity.Collections.NativeArray<T>m_cpuArray  // 0x0
PROPERTIES:
  cpuArray  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000B27  System.Void .ctor(System.Int32 initCapacity, UnityEngine.CanvasRenderer canvasRenderer)
  RVA=-1  // not resolved  token=0x6000B28  System.Void Dispose()
  RVA=-1  // not resolved  token=0x6000B29  System.Void Reset()
  RVA=-1  // not resolved  token=0x6000B2A  System.Void OpenWrite()
  RVA=-1  // not resolved  token=0x6000B2B  System.Void Freeze()
  RVA=-1  // not resolved  token=0x6000B2C  System.Boolean Allocate(System.Int32 size, System.Int32& index)
  RVA=-1  // not resolved  token=0x6000B2D  System.Void _Resize(System.Int32 desiredCapacity)
END_CLASS

CLASS: Beyond.UI.GPUI.CodePoint
TYPE:  class
TOKEN: 0x200015C
SIZE:  0x10
FIELDS:
  public    static  System.UInt32                   HIGH_SURROGATE_START  // const
  public    static  System.UInt32                   HIGH_SURROGATE_END  // const
  public    static  System.UInt32                   LOW_SURROGATE_START  // const
  public    static  System.UInt32                   LOW_SURROGATE_END  // const
  public    static  System.UInt32                   UNICODE_PLANE01_START  // const
METHODS:
  RVA=0x09B08FD0  token=0x6000B2E  System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate)
  RVA=0x0350B670  token=0x6000B2F  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.ITextSystem
TYPE:  interface
TOKEN: 0x200015D
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000B30  System.Void RegisterCharacterToPrefabBuffer(System.String text)
  RVA=-1  // abstract  token=0x6000B31  System.Void UploadBufferIfNeeded()
  RVA=-1  // abstract  token=0x6000B32  System.Int32 GetNodeCount(System.String text)
  RVA=-1  // abstract  token=0x6000B33  System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  RVA=-1  // abstract  token=0x6000B34  System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleTextSystem`1
TYPE:  class
TOKEN: 0x200015E
IMPLEMENTS: Beyond.UI.GPUI.ITextSystem
FIELDS:
  public    static  System.Single                   DEFAULT_WHITESPACE_SPACING  // const
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x0
  private           UnityEngine.Material            m_tmpMaterial  // 0x0
  private           Beyond.UI.GPUI.SimpleBufferManager<T>m_prefabBufferManager  // 0x0
  private           System.Single                   m_padding  // 0x0
  private           UnityEngine.Vector2             m_texelSizeInv  // 0x0
  private   readonly System.Collections.Generic.List<T>m_dynamicBufferCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,System.Int32>m_charCodeToIndexMap  // 0x0
  private   readonly System.Collections.Generic.List<Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>>m_tempOffsetCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>>m_charaOffsetCache  // 0x0
  private   readonly System.Int32                    m_fontBufferCapacity  // 0x0
  private   readonly System.Boolean                  m_liteMode  // 0x0
  private           System.Boolean                  m_isThaiMode  // 0x0
  private           System.Int32                    m_prefabDestIndex  // 0x0
  private           System.Int32                    m_fontBufferCount  // 0x0
  private   readonly System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T>m_creatorFunc  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000B35  System.Void .ctor(System.Int32 fontBufferCapacity, System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> creatorFunc)
  RVA=-1  // not resolved  token=0x6000B36  System.Void Init(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material tmpMaterial, Beyond.UI.GPUI.SimpleBufferManager<T> simpleBufferManager, System.Boolean isThaiMode)
  RVA=-1  // not resolved  token=0x6000B37  System.Void RegisterCharacterToPrefabBuffer(System.String text)
  RVA=-1  // not resolved  token=0x6000B38  System.Int32 GetNodeCount(System.String text)
  RVA=-1  // not resolved  token=0x6000B39  System.Void UploadBufferIfNeeded()
  RVA=-1  // not resolved  token=0x6000B3A  System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  RVA=-1  // not resolved  token=0x6000B3B  System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  RVA=-1  // not resolved  token=0x6000B3C  System.Void _DoTextAlignAndDynamicBuffer(System.String text, Beyond.UI.GPUI.SimpleTextAlignment alignment, System.Single& currentX)
  RVA=-1  // not resolved  token=0x6000B3D  System.Void _LoadAllCharacterToPrefabBuffer(System.String text)
  RVA=-1  // not resolved  token=0x6000B3E  System.Int32 _PutOneCharacterToPrefabBufferDynamic(System.UInt32 c)
  RVA=-1  // not resolved  token=0x6000B3F  System.Void _UploadBufferIfNeeded()
  RVA=-1  // not resolved  token=0x6000B40  System.Void _InitPrefabDataByTMPCharacter(TMPro.TMP_Character character, T& prefabData)
  RVA=-1  // not resolved  token=0x6000B41  System.Boolean IsUpVowel(System.Char c)
  RVA=-1  // not resolved  token=0x6000B42  System.Boolean IsLowVowel(System.Char c)
  RVA=-1  // not resolved  token=0x6000B43  System.Boolean IsToneMark(System.Char c)
  RVA=-1  // not resolved  token=0x6000B44  System.Boolean IsAscenderThai(System.Char c)
  RVA=-1  // not resolved  token=0x6000B45  System.Boolean IsDescenderThai(System.Char c)
END_CLASS

CLASS: Beyond.UI.UIState.OnValueChangedAttribute
TYPE:  class
TOKEN: 0x2000134
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  private   readonly System.String                   <actionName>k__BackingField  // 0x10
PROPERTIES:
  actionName  get=0x020B7B20
METHODS:
  RVA=0x0426FEE0  token=0x6000A6D  System.Void .ctor(System.String name)
END_CLASS

CLASS: Beyond.UI.UIState.StateAnimationInfo
TYPE:  class
TOKEN: 0x2000135
SIZE:  0x30
FIELDS:
  private           System.Boolean                  <IsFinished>k__BackingField  // 0x10
  private   readonly UnityEngine.AnimationClip       <Clip>k__BackingField  // 0x18
  private   readonly UnityEngine.GameObject          <Target>k__BackingField  // 0x20
  private           System.Single                   <StartTime>k__BackingField  // 0x28
  private   readonly System.Single                   m_duration  // 0x2c
PROPERTIES:
  IsFinished  get=0x011797F0  set=0x03D4E960
  Clip  get=0x01041090
  Target  get=0x03D4EB40
  StartTime  get=0x03D4F480  set=0x03D4F490
METHODS:
  RVA=0x02CD1CB0  token=0x6000A74  System.Void .ctor(UnityEngine.AnimationClip clip, UnityEngine.GameObject target)
  RVA=0x09AF031C  token=0x6000A75  System.Void OnUpdate()
END_CLASS

CLASS: Beyond.UI.UIState.AnimationImpactType
TYPE:  sealed struct
TOKEN: 0x2000136
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.AnimationImpactTypeStartAnimation  // const
  public    static  Beyond.UI.UIState.AnimationImpactTypeStopAnimation  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateDescription
TYPE:  class
TOKEN: 0x2000137
SIZE:  0x270
FIELDS:
  public            Beyond.UI.UIState.AnimationImpactTypeanimationImpactType  // 0x10
  public            UnityEngine.AnimationClip       animationClip  // 0x18
  public            UnityEngine.GameObject          animationTarget  // 0x20
  public            UnityEngine.Animator            animator  // 0x28
  public            Beyond.UI.UIState.AnimatorImpactTypeanimImpact  // 0x30
  public            System.String                   animParamSetBoolTrue  // 0x38
  public            System.String                   animParamSetBoolFalse  // 0x40
  public            System.String                   animParamSetTrigger  // 0x48
  public            System.String                   animParamResetTrigger  // 0x50
  public            System.String                   animParamSetInteger  // 0x58
  public            System.Int32                    animParamSetIntegerValue  // 0x60
  public            System.String                   animParamSetFloat  // 0x68
  public            System.Int32                    animParamSetFloatValue  // 0x70
  public            Beyond.UI.UIButton              button  // 0x78
  public            System.Boolean                  buttonInteractable  // 0x80
  public            UnityEngine.CanvasGroup         canvasGroup  // 0x88
  public            Beyond.UI.UIState.CanvasGroupImpactTypecanvasGroupImpactType  // 0x90
  public            System.Single                   canvasGroupAlpha  // 0x94
  public            System.Boolean                  canvasGroupInteractable  // 0x98
  public            UnityEngine.Color               canvasGroupColor  // 0x9c
  public            UnityEngine.Behaviour           component  // 0xb0
  public            System.Boolean                  componentIsEnabled  // 0xb8
  public            Beyond.UI.UIState.StateDescriptionTargetTypetargetType  // 0xbc
  public            UnityEngine.GameObject          gameObject  // 0xc0
  public            System.Boolean                  gameObjectIsActive  // 0xc8
  public            UnityEngine.UI.Graphic          graphic  // 0xd0
  public            UnityEngine.Material            graphicMaterial  // 0xd8
  public            UnityEngine.UI.GridLayoutGroup  gridLayoutGroup  // 0xe0
  public            Beyond.UI.UIState.GridLayoutGroupImpactTypegridLayoutGroupImpactType  // 0xe8
  public            UnityEngine.RectOffset          gridLayoutGroupPadding  // 0xf0
  public            UnityEngine.Vector2             gridLayoutGroupSpacing  // 0xf8
  public            UnityEngine.Vector2             gridLayoutGroupCellSize  // 0x100
  public            System.Int32                    gridLayoutConstraintCount  // 0x108
  public            Beyond.UI.UIImage               image  // 0x110
  public            Beyond.UI.UIState.ImageImpactTypeimageImpact  // 0x118
  public            System.Boolean                  imageEnabled  // 0x11c
  public            UnityEngine.Sprite              imageSetSprite  // 0x120
  public            UnityEngine.Color               imageSetColor  // 0x128
  public            System.String                   imageSetMaterialFloatParam  // 0x138
  public            System.Single                   imageSetMaterialFloatValue  // 0x140
  private           UnityEngine.Material            <ImageMaterialClone>k__BackingField  // 0x148
  public            UnityEngine.UI.LayoutElement    layoutElement  // 0x150
  public            Beyond.UI.UIState.LayoutElementImpactTypelayoutElementImpactType  // 0x158
  public            System.Single                   layoutElementPreferredWidth  // 0x15c
  public            System.Single                   layoutElementPreferredHeight  // 0x160
  public            System.Single                   layoutElementMinWidth  // 0x164
  public            System.Single                   layoutElementMinHeight  // 0x168
  public            System.Single                   layoutElementFlexibleWidth  // 0x16c
  public            System.Single                   layoutElementFlexibleHeight  // 0x170
  public            UnityEngine.UI.HorizontalOrVerticalLayoutGrouplayoutGroup  // 0x178
  public            Beyond.UI.UIState.LayoutGroupImpactTypelayoutGroupImpactType  // 0x180
  public            UnityEngine.RectOffset          layoutGroupPadding  // 0x188
  public            System.Single                   layoutGroupSpacing  // 0x190
  public            UnityEngine.TextAnchor          layoutGroupChildAlignment  // 0x194
  public            System.Boolean                  layoutGroupReverseArrangement  // 0x198
  public            UnityEngine.RectTransform       rectTransform  // 0x1a0
  public            Beyond.UI.UIState.RectTransformImpactTyperectTransformImpactType  // 0x1a8
  public            UnityEngine.Vector2             rectTransformPosition  // 0x1ac
  public            UnityEngine.Vector2             rectTransformSize  // 0x1b4
  public            UnityEngine.Vector3             rectTransformRotation  // 0x1bc
  public            UnityEngine.Vector3             rectTransformScale  // 0x1c8
  public            System.Single                   rectTransformWidth  // 0x1d4
  public            System.Single                   rectTransformHeight  // 0x1d8
  public            System.Single                   rectTransformTop  // 0x1dc
  public            System.Single                   rectTransformBottom  // 0x1e0
  public            System.Single                   rectTransformLeft  // 0x1e4
  public            System.Single                   rectTransformRight  // 0x1e8
  public            UnityEngine.Vector2             rectTransformAnchorMin  // 0x1ec
  public            UnityEngine.Vector2             rectTransformAnchorMax  // 0x1f4
  public            UnityEngine.Vector2             rectTransformPivot  // 0x1fc
  public            Beyond.UI.UIScrollList          scrollList  // 0x208
  public            Beyond.UI.UIState.ScrollListImpactTypescrollListImpactType  // 0x210
  public            Beyond.UI.UIScrollList.Padding  scrollListPadding  // 0x214
  public            Beyond.UI.UIState.UIStateControlleruiStateController  // 0x228
  public            System.String                   stateName  // 0x230
  public            Beyond.UI.UIText                text  // 0x238
  public            Beyond.UI.UIState.TextImpactTypetextImpact  // 0x240
  public            UnityEngine.Color               textColor  // 0x244
  public            System.String                   textId  // 0x258
  public            System.Single                   textFontSize  // 0x260
  public            System.Single                   textMaxFontSize  // 0x264
  public            TMPro.HorizontalAlignmentOptionstextHorizontalAlignment  // 0x268
PROPERTIES:
  IsEmpty  get=0x02CD47B0
  ReadableDescription  get=0x09AF21D0
  ImageMaterialClone  get=0x03D571B0  set=0x058B3DA8
METHODS:
  RVA=0x09AF08F0  token=0x6000A76  System.Boolean EqualsAnimation(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD1D10  token=0x6000A77  System.Single ApplyAnimation(Beyond.UI.UIState.StateReference state)
  RVA=0x09AF0988  token=0x6000A78  System.Boolean EqualsAnimator(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF03CC  token=0x6000A79  System.Void ApplyAnimator()
  RVA=0x09AF0A20  token=0x6000A7A  System.Boolean EqualsButton(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF04F0  token=0x6000A7B  System.Void ApplyButton()
  RVA=0x09AF0AB8  token=0x6000A7C  System.Boolean EqualsCanvasGroup(Beyond.UI.UIState.StateDescription other)
  RVA=0x03D06C50  token=0x6000A7D  System.Void ApplyCanvasGroup()
  RVA=0x09AF0B58  token=0x6000A7E  System.Boolean EqualsComponent(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF0550  token=0x6000A7F  System.Void ApplyComponent()
  RVA=0x09AF13B8  token=0x6000A82  System.String ToString()
  RVA=0x09AF333C  token=0x6000A83  System.Boolean op_Equality(Beyond.UI.UIState.StateDescription left, Beyond.UI.UIState.StateDescription right)
  RVA=0x09AF33B8  token=0x6000A84  System.Boolean op_Inequality(Beyond.UI.UIState.StateDescription left, Beyond.UI.UIState.StateDescription right)
  RVA=0x09AF12C4  token=0x6000A85  System.Boolean Equals(System.Object obj)
  RVA=0x09AF1354  token=0x6000A86  System.Int32 GetHashCode()
  RVA=0x09AF1238  token=0x6000A87  System.Boolean Equals(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF144C  token=0x6000A88  System.Boolean _EqualsByTargetType(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF1678  token=0x6000A89  System.Int32 _GetTargetHashCode()
  RVA=0x09AF0BF8  token=0x6000A8A  System.Boolean EqualsGameObject(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD49C0  token=0x6000A8B  System.Void ApplyGameObject()
  RVA=0x09AF0C98  token=0x6000A8C  System.Boolean EqualsGraphic(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF05B4  token=0x6000A8D  System.Void ApplyGraphic()
  RVA=0x09AF0D38  token=0x6000A8E  System.Boolean EqualsGridLayoutGroup(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF061C  token=0x6000A8F  System.Void ApplyGridLayoutGroup()
  RVA=0x09AF1758  token=0x6000A90  System.Void _OnGridLayoutGroupChanged()
  RVA=0x09AF0DD8  token=0x6000A93  System.Boolean EqualsImage(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD4D70  token=0x6000A94  System.Void ApplyImage()
  RVA=0x09AF1868  token=0x6000A95  System.Void _OnImageChanged()
  RVA=0x09AF0E78  token=0x6000A96  System.Boolean EqualsLayoutElement(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD1950  token=0x6000A97  System.Void ApplyLayoutElement()
  RVA=0x09AF19BC  token=0x6000A98  System.Void _OnLayoutElementChanged()
  RVA=0x09AF0F18  token=0x6000A99  System.Boolean EqualsLayoutGroup(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD1160  token=0x6000A9A  System.Void ApplyLayoutGroup()
  RVA=0x09AF1A88  token=0x6000A9B  System.Void _OnLayoutGroupChanged()
  RVA=0x09AF0FB8  token=0x6000A9C  System.Boolean EqualsRectTransform(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD4A10  token=0x6000A9D  System.Void ApplyRectTransform()
  RVA=0x09AF1B80  token=0x6000A9E  System.Void _OnRectTransformChanged()
  RVA=0x09AF1058  token=0x6000A9F  System.Boolean EqualsScrollList(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF07D8  token=0x6000AA0  System.Void ApplyScrollList()
  RVA=0x09AF203C  token=0x6000AA1  System.Void _OnScrollListChanged()
  RVA=0x09AF10F8  token=0x6000AA2  System.Boolean EqualsState(Beyond.UI.UIState.StateDescription other)
  RVA=0x09AF0770  token=0x6000AA3  System.Single ApplyInnerState()
  RVA=0x09AF1198  token=0x6000AA4  System.Boolean EqualsText(Beyond.UI.UIState.StateDescription other)
  RVA=0x02CD1E00  token=0x6000AA5  System.Void ApplyText()
  RVA=0x09AF20F0  token=0x6000AA6  System.Void _OnTextChanged()
  RVA=0x03162130  token=0x6000AA7  System.Void .ctor()
  RVA=0x05459F38  token=0x6000AA8  System.String <>iFixBaseProxy_ToString()
  RVA=0x0232CE30  token=0x6000AA9  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  RVA=0x03D4F970  token=0x6000AAA  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.UI.UIState.AnimatorImpactType
TYPE:  sealed struct
TOKEN: 0x2000138
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetBoolTrue  // const
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetBoolFalse  // const
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetTrigger  // const
  public    static  Beyond.UI.UIState.AnimatorImpactTypeResetTrigger  // const
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetInteger  // const
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetFloat  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.CanvasGroupImpactType
TYPE:  sealed struct
TOKEN: 0x2000139
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetAlpha  // const
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetInteractable  // const
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetColor  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateDescriptionTargetType
TYPE:  sealed struct
TOKEN: 0x200013A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGameObject  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeAnimator  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeImage  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeText  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeRectTransform  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeButton  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeCanvasGroup  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeAnimation  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeState  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeLayoutElement  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeComponent  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGraphic  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeLayoutGroup  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeScrollList  // const
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGridLayoutGroup  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.GridLayoutGroupImpactType
TYPE:  sealed struct
TOKEN: 0x200013B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypePadding  // const
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeSpacing  // const
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeCellSize  // const
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeConstraintCount  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.ImageImpactType
TYPE:  sealed struct
TOKEN: 0x200013C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.ImageImpactTypeSetEnabled  // const
  public    static  Beyond.UI.UIState.ImageImpactTypeSetSprite  // const
  public    static  Beyond.UI.UIState.ImageImpactTypeSetColor  // const
  public    static  Beyond.UI.UIState.ImageImpactTypeSetMaterialFloatValue  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.LayoutElementImpactType
TYPE:  sealed struct
TOKEN: 0x200013D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementPreferredWidth  // const
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementPreferredHeight  // const
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementMinWidth  // const
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementMinHeight  // const
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementFlexibleWidth  // const
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementFlexibleHeight  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.LayoutGroupImpactType
TYPE:  sealed struct
TOKEN: 0x200013E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypePadding  // const
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeSpacing  // const
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeChildAlignment  // const
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeReverseArrangement  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.RectTransformImpactType
TYPE:  sealed struct
TOKEN: 0x200013F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.RectTransformImpactTypeUndefined  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetPosition  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetSize  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetRotation  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetScale  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetWidth  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetHeight  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetTop  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetBottom  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetLeft  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetRight  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetAnchors  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetPivot  // const
  public    static  Beyond.UI.UIState.RectTransformImpactTypeForceRebuildLayout  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.ScrollListImpactType
TYPE:  sealed struct
TOKEN: 0x2000140
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.ScrollListImpactTypePadding  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.TextImpactType
TYPE:  sealed struct
TOKEN: 0x2000141
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.TextImpactTypeSetColor  // const
  public    static  Beyond.UI.UIState.TextImpactTypeSetTextById  // const
  public    static  Beyond.UI.UIState.TextImpactTypeSetFontSize  // const
  public    static  Beyond.UI.UIState.TextImpactTypeSetHorizontalAlignment  // const
  public    static  Beyond.UI.UIState.TextImpactTypeSetMaxFontSize  // const
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateReference
TYPE:  class
TOKEN: 0x2000142
SIZE:  0x40
FIELDS:
  public            System.String                   stateName  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.UIState.StateDescription>descriptions  // 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_scheduledForPlaying  // 0x20
  private           System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_scheduledForStopping  // 0x28
  private           Beyond.UI.UIState.UIStateControllerm_controller  // 0x30
  private           System.Boolean                  m_isDirty  // 0x38
METHODS:
  RVA=0x02CD2CF0  token=0x6000AAB  System.Void SetController(Beyond.UI.UIState.UIStateController controller)
  RVA=0x09B0C888  token=0x6000AAC  System.Void ScheduleForPlaying(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo)
  RVA=0x02CD1C00  token=0x6000AAD  System.Void ScheduleForStopping(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo)
  RVA=0x03304130  token=0x6000AAE  System.Void HandleScheduledStates()
  RVA=0x028462E0  token=0x6000AAF  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIState.UIStateController
TYPE:  class
TOKEN: 0x2000143
SIZE:  0x80
EXTENDS: Beyond.TickableUIMono
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIState.StateReference>states  // 0x68
  private           System.String                   <currentStateName>k__BackingField  // 0x70
  private   readonly System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_animations  // 0x78
PROPERTIES:
  tickOption  get=0x03D55800
  currentStateName  get=0x03D4EB30  set=0x0519C3C8
METHODS:
  RVA=0x02CD1C80  token=0x6000AB3  System.Void OnStateReferenceDirty()
  RVA=0x02CD2D30  token=0x6000AB4  System.Single SetState(System.String stateName, System.Boolean forceUpdate)
  RVA=0x02CD2E50  token=0x6000AB5  System.Single _ApplyState(Beyond.UI.UIState.StateReference state)
  RVA=0x033030C0  token=0x6000AB6  System.Void Tick(System.Single deltaTime)
  RVA=0x033040E0  token=0x6000AB7  System.Void _HandleStateAnimations(Beyond.UI.UIState.StateReference stateReference)
  RVA=0x09B0CB38  token=0x6000AB8  System.Void Run(Beyond.UI.UIState.StateAnimationInfo newInfo)
  RVA=0x03302D90  token=0x6000AB9  System.Void Stop(Beyond.UI.UIState.StateAnimationInfo newInfo)
  RVA=0x02846210  token=0x6000ABA  System.Void .ctor()
  RVA=0x0577D7BC  token=0x6000ABB  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIState.UIStateControllerUtils
TYPE:  static class
TOKEN: 0x2000145
SIZE:  0x10
FIELDS:
  private   static  System.Single                   s_updateFinishTime  // static @ 0x0
METHODS:
  RVA=0x09B0C940  token=0x6000ABF  System.Void ForceRebuildLayout(UnityEngine.GameObject gameObject)
  RVA=0x02CD4E60  token=0x6000AC0  System.Void SetLeft(UnityEngine.RectTransform rt, System.Single left)
  RVA=0x02CD5060  token=0x6000AC1  System.Void SetRight(UnityEngine.RectTransform rt, System.Single right)
  RVA=0x02CD5580  token=0x6000AC2  System.Void SetTop(UnityEngine.RectTransform rt, System.Single top)
  RVA=0x02CD5290  token=0x6000AC3  System.Void SetBottom(UnityEngine.RectTransform rt, System.Single bottom)
  RVA=0x09B0CA40  token=0x6000AC4  System.String GetName(UnityEngine.Object obj)
  RVA=0x09B0CAEC  token=0x6000AC5  System.Void StartEditorUpdateLoop(System.Single duration)
END_CLASS

CLASS: Cysharp.Text.TextMeshProExtensions
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000005  System.Void SetText(TMPro.TMP_Text text, T arg0)
  RVA=-1  // generic def  token=0x6000006  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0)
  RVA=-1  // generic def  token=0x6000007  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1)
  RVA=-1  // generic def  token=0x6000008  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2)
  RVA=-1  // generic def  token=0x6000009  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  RVA=-1  // generic def  token=0x600000A  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  RVA=-1  // generic def  token=0x600000B  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  RVA=-1  // generic def  token=0x600000C  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  RVA=-1  // generic def  token=0x600000D  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  RVA=-1  // generic def  token=0x600000E  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  RVA=-1  // generic def  token=0x600000F  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  RVA=-1  // generic def  token=0x6000010  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  RVA=-1  // generic def  token=0x6000011  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  RVA=-1  // generic def  token=0x6000012  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  RVA=-1  // generic def  token=0x6000013  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  RVA=-1  // generic def  token=0x6000014  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  RVA=-1  // generic def  token=0x6000015  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  RVA=0x09AAF6CC  token=0x6000016  System.Void SetText(TMPro.TMP_Text text, Cysharp.Text.Utf16ValueStringBuilder stringBuilder)
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000162
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000B46  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x050F3444  token=0x6000B47  System.Void __Gen_Wrap_0()
  RVA=0x04274234  token=0x6000B48  System.Void __Gen_Wrap_1(System.Object P0)
  RVA=0x088B576C  token=0x6000B49  System.Single __Gen_Wrap_2(System.Object P0, System.Boolean P1)
  RVA=0x054AB08C  token=0x6000B4A  System.Single __Gen_Wrap_3(System.Object P0)
  RVA=0x09B067AC  token=0x6000B4B  Beyond.UI.LuaPanel __Gen_Wrap_4(System.Object P0)
  RVA=0x054790D0  token=0x6000B4C  System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x050F0008  token=0x6000B4D  System.Void __Gen_Wrap_6(System.Object P0, System.Single P1)
  RVA=0x09B08018  token=0x6000B4E  System.String __Gen_Wrap_7(System.Object P0, System.Int32 P1, System.Boolean& P2)
  RVA=0x05153920  token=0x6000B4F  System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1)
  RVA=0x09B08E80  token=0x6000B50  Beyond.UI.UIText.HyperlinkUITextGroup __Gen_Wrap_9(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x05163BA0  token=0x6000B51  System.Void __Gen_Wrap_10(System.Object P0, System.Object P1)
  RVA=0x09AFA534  token=0x6000B52  System.String __Gen_Wrap_11(Beyond.GEnums.PhoneticType P0, System.Object P1)
  RVA=0x0560138C  token=0x6000B53  System.Void __Gen_Wrap_12(System.Object P0, Beyond.GEnums.PhoneticType P1, System.Object P2)
  RVA=0x0514E3FC  token=0x6000B54  System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0)
  RVA=0x09AFBE98  token=0x6000B55  System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1, System.String& P2)
  RVA=0x09AFC9B8  token=0x6000B56  System.Boolean __Gen_Wrap_15(System.Object P0, UnityEngine.Vector3 P1, System.String& P2)
  RVA=0x09AFD430  token=0x6000B57  System.Collections.IEnumerator __Gen_Wrap_16(System.Object P0)
  RVA=0x09AFDA54  token=0x6000B58  System.String __Gen_Wrap_17(System.Object P0, System.Boolean P1)
  RVA=0x09AFE234  token=0x6000B59  UnityEngine.Sprite __Gen_Wrap_18(System.Object P0, System.Object P1)
  RVA=0x09AFE9D0  token=0x6000B5A  System.Int32 __Gen_Wrap_19(System.ReadOnlySpan<System.Char> P0)
  RVA=0x09AFF02C  token=0x6000B5B  Beyond.UI.UIText.RichTextInfo __Gen_Wrap_20(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P0, System.Object P1, Cysharp.Text.Utf16ValueStringBuilder& P2)
  RVA=0x09AFF990  token=0x6000B5C  Beyond.UI.UIText.RichTextInfo __Gen_Wrap_21(System.Object P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P1, System.Object P2, Cysharp.Text.Utf16ValueStringBuilder& P3)
  RVA=0x09B000D0  token=0x6000B5D  Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(System.Object P0)
  RVA=0x09B00A68  token=0x6000B5E  System.Boolean __Gen_Wrap_23(System.ReadOnlySpan<System.Char> P0, System.Boolean& P1, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& P2)
  RVA=0x09B016B8  token=0x6000B5F  System.Boolean __Gen_Wrap_24(System.ReadOnlySpan<System.Char> P0, Cysharp.Text.Utf16ValueStringBuilder& P1, System.Object P2, Beyond.UI.UIText.RichTextInfo& P3)
  RVA=0x09B0264C  token=0x6000B60  System.String __Gen_Wrap_25(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& P2)
  RVA=0x09B031F4  token=0x6000B61  UnityEngine.GameObject __Gen_Wrap_26(System.Object P0)
  RVA=0x09B03D64  token=0x6000B62  Beyond.UI.UIText.ImageGOInfo __Gen_Wrap_27(System.Object P0, System.Int32 P1)
  RVA=0x09B04AC4  token=0x6000B63  UnityEngine.Material __Gen_Wrap_28(System.Object P0)
  RVA=0x09B05754  token=0x6000B64  UnityEngine.Material __Gen_Wrap_29(System.Object P0, System.Object P1)
  RVA=0x0514F380  token=0x6000B65  System.Boolean __Gen_Wrap_30()
  RVA=0x09B05B1C  token=0x6000B66  Beyond.I18n.I18nFontSearchData __Gen_Wrap_31()
  RVA=0x0514EF5C  token=0x6000B67  System.Boolean __Gen_Wrap_32(System.Object P0)
  RVA=0x09B05BE8  token=0x6000B68  TMPro.TMP_FontAsset __Gen_Wrap_33(System.Int32 P0)
  RVA=0x09B05CD4  token=0x6000B69  TMPro.TMP_FontAsset __Gen_Wrap_34(System.Object P0)
  RVA=0x056479C0  token=0x6000B6A  System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  RVA=0x054A1028  token=0x6000B6B  System.Void __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x09B05DC4  token=0x6000B6C  System.Boolean __Gen_Wrap_37(System.Object P0, System.Int32 P1, System.String& P2)
  RVA=0x09B05F04  token=0x6000B6D  System.Boolean __Gen_Wrap_38(System.Object P0, System.Int32 P1, UnityEngine.Vector3& P2, System.Single& P3)
  RVA=0x05150B1C  token=0x6000B6E  System.Void __Gen_Wrap_39(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x050EF354  token=0x6000B6F  System.Int32 __Gen_Wrap_40(Beyond.UI.UIText.HyperlinkUITextWrap P0, Beyond.UI.UIText.HyperlinkUITextWrap P1)
  RVA=0x09B06084  token=0x6000B70  System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_41(System.Object P0, System.Object P1)
  RVA=0x09B0617C  token=0x6000B71  System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_42(System.Object P0)
  RVA=0x050EF614  token=0x6000B72  System.Int32 __Gen_Wrap_43(System.Object P0)
  RVA=0x09B06258  token=0x6000B73  TMPro.TMP_SubMeshUI __Gen_Wrap_44(System.Object P0, System.Object P1, TMPro.MaterialReference P2)
  RVA=0x09B063BC  token=0x6000B74  System.String __Gen_Wrap_45(System.Int32 P0)
  RVA=0x056409AC  token=0x6000B75  System.Single __Gen_Wrap_46()
  RVA=0x09B064A8  token=0x6000B76  UnityEngine.GameObject __Gen_Wrap_47(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x09B065BC  token=0x6000B77  System.Void __Gen_Wrap_48(Beyond.Resource.FAssetProxyUntrackedHandle P0)
  RVA=0x09B066A4  token=0x6000B78  System.Int32 __Gen_Wrap_49(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x0549D548  token=0x6000B79  System.Void __Gen_Wrap_50(System.Object P0, System.Int32 P1)
  RVA=0x09B0689C  token=0x6000B7A  System.Boolean __Gen_Wrap_51(UnityEngine.Vector3 P0, System.Object P1, System.Object P2)
  RVA=0x09B069E0  token=0x6000B7B  System.Boolean __Gen_Wrap_52(UnityEngine.Vector2 P0, System.Object P1, System.Object P2)
  RVA=0x09B06B1C  token=0x6000B7C  UnityEngine.Bounds __Gen_Wrap_53(System.Object P0, System.Object P1)
  RVA=0x09B06C3C  token=0x6000B7D  System.Boolean __Gen_Wrap_54(System.Int32 P0, UnityEngine.InputSystem.EnhancedTouch.Touch& P1)
  RVA=0x09B06D84  token=0x6000B7E  System.Void __Gen_Wrap_55(System.Object P0, UnityEngine.Color P1)
  RVA=0x09B06E98  token=0x6000B7F  UnityEngine.Rect __Gen_Wrap_56(System.Object P0, System.Object P1)
  RVA=0x09B06FC0  token=0x6000B80  UnityEngine.Vector3 __Gen_Wrap_57(System.Object P0, System.Object P1)
  RVA=0x09B070E0  token=0x6000B81  UnityEngine.Color __Gen_Wrap_58(System.Object P0)
  RVA=0x0871ACD8  token=0x6000B82  System.Single __Gen_Wrap_59(System.Single P0)
  RVA=0x09B071D8  token=0x6000B83  System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, Cinemachine.CinemachineCore.Stage P2, Cinemachine.CameraState& P3, System.Single P4)
  RVA=0x054761A8  token=0x6000B84  System.Int32 __Gen_Wrap_61(System.Object P0, System.Int32 P1)
  RVA=0x09B0743C  token=0x6000B85  UnityEngine.Vector2 __Gen_Wrap_62(System.Object P0, System.Int32 P1)
  RVA=0x09B07534  token=0x6000B86  UnityEngine.Vector2 __Gen_Wrap_63()
  RVA=0x09B075EC  token=0x6000B87  System.Void __Gen_Wrap_64(UnityEngine.Vector2 P0)
  RVA=0x05610058  token=0x6000B88  System.Void __Gen_Wrap_65(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x09B076D4  token=0x6000B89  UnityEngine.Vector2Int __Gen_Wrap_66(System.Object P0, System.Single P1, System.Boolean P2)
  RVA=0x09B077FC  token=0x6000B8A  UnityEngine.Vector2Int __Gen_Wrap_67(System.Object P0)
  RVA=0x09B078EC  token=0x6000B8B  Beyond.UI.UIScrollList.Cell __Gen_Wrap_68(System.Object P0)
  RVA=0x05477860  token=0x6000B8C  System.Void __Gen_Wrap_69(System.Object P0, System.Boolean P1)
  RVA=0x09B079DC  token=0x6000B8D  UnityEngine.AnimationState __Gen_Wrap_70(System.Object P0, System.Object P1)
  RVA=0x05E7B3B0  token=0x6000B8E  System.Void __Gen_Wrap_71(System.Object P0, System.Object P1, System.Single P2)
  RVA=0x05E612B8  token=0x6000B8F  System.Void __Gen_Wrap_72(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3)
  RVA=0x09B07AE8  token=0x6000B90  System.Void __Gen_Wrap_73(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIConst.AnimationState P3, System.Single P4)
  RVA=0x09B07C00  token=0x6000B91  System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3)
  RVA=0x05E5ABBC  token=0x6000B92  System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3)
  RVA=0x050EF614  token=0x6000B93  Beyond.UI.UIScrollList.MoveTipsType __Gen_Wrap_76(System.Object P0)
  RVA=0x09B07D08  token=0x6000B94  System.Void __Gen_Wrap_77(System.Object P0, UnityEngine.Vector2 P1)
  RVA=0x09B07E1C  token=0x6000B95  System.Void __Gen_Wrap_78(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3, System.Boolean P4)
  RVA=0x09B07F28  token=0x6000B96  Beyond.UI.UIText __Gen_Wrap_79(System.Object P0)
  RVA=0x09B08160  token=0x6000B97  System.String __Gen_Wrap_80(System.Object P0)
  RVA=0x09B08250  token=0x6000B98  UnityEngine.Sprite __Gen_Wrap_81(System.Object P0)
  RVA=0x05477F10  token=0x6000B99  Beyond.UI.UIStyleInputValidTypeMask __Gen_Wrap_82(System.Object P0)
  RVA=0x055FFD60  token=0x6000B9A  System.Void __Gen_Wrap_83(System.Object P0, Beyond.UI.UIStyleInputValidTypeMask P1)
  RVA=0x0514DE88  token=0x6000B9B  System.Boolean __Gen_Wrap_84(Beyond.UI.UIStyleInputValidType P0)
  RVA=0x05151D64  token=0x6000B9C  System.Boolean __Gen_Wrap_85(Beyond.UI.UIStyleInputValidTypeMask P0)
  RVA=0x054772E8  token=0x6000B9D  System.Void __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x050F1DD4  token=0x6000B9E  System.Int32 __Gen_Wrap_87()
  RVA=0x05E3DBF4  token=0x6000B9F  System.Void __Gen_Wrap_88(System.Object P0, System.Boolean P1, System.Boolean P2)
  RVA=0x09B0832C  token=0x6000BA0  UnityEngine.UI.Selectable __Gen_Wrap_89(System.Object P0)
  RVA=0x09B0841C  token=0x6000BA1  System.Boolean __Gen_Wrap_90(System.Object P0, UnityEngine.Vector2 P1, System.Object P2)
  RVA=0x09B08558  token=0x6000BA2  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(System.Object P0)
  RVA=0x09B08634  token=0x6000BA3  Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_92(System.Object P0)
  RVA=0x09B08710  token=0x6000BA4  Beyond.UI.UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(System.Object P0)
  RVA=0x09B087EC  token=0x6000BA5  System.Void __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P2)
  RVA=0x09B08908  token=0x6000BA6  UnityEngine.Vector2 __Gen_Wrap_95(System.Object P0, UnityEngine.Bounds P1)
  RVA=0x09B08A30  token=0x6000BA7  UnityEngine.Bounds __Gen_Wrap_96(System.Object P0, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P1)
  RVA=0x09B08B74  token=0x6000BA8  Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_97(System.Object P0, System.Object P1)
  RVA=0x09B08C6C  token=0x6000BA9  Beyond.UI.UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(System.Object P0, System.Object P1)
  RVA=0x09B08D64  token=0x6000BAA  UnityEngine.GameObject __Gen_Wrap_99(System.Object P0, System.Boolean& P1)
  RVA=0x09AF96F8  token=0x6000BAB  System.Boolean __Gen_Wrap_100(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x09AF97EC  token=0x6000BAC  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(System.Object P0, System.Int32 P1)
  RVA=0x09AF98E4  token=0x6000BAD  System.Single __Gen_Wrap_102(System.Object P0, System.Int32 P1)
  RVA=0x09AF99BC  token=0x6000BAE  UnityEngine.Bounds __Gen_Wrap_103(System.Object P0, System.Int32 P1)
  RVA=0x050EF354  token=0x6000BAF  System.Int32 __Gen_Wrap_104(System.Object P0, System.Object P1)
  RVA=0x05477F10  token=0x6000BB0  Beyond.UI.UIRecycleLayoutGroup.Direction __Gen_Wrap_105(System.Object P0)
  RVA=0x09AF9ADC  token=0x6000BB1  Beyond.UI.UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(System.Object P0, System.Int32 P1)
  RVA=0x09AF9BD4  token=0x6000BB2  System.Void __Gen_Wrap_107(System.Object P0, System.Int32 P1, System.Object P2, System.Single P3)
  RVA=0x09AF9CCC  token=0x6000BB3  Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(System.Object P0, System.Int32 P1)
  RVA=0x09AF9DC4  token=0x6000BB4  Beyond.UI.ToastList.CellInfo __Gen_Wrap_109(System.Object P0)
  RVA=0x09AF9EA0  token=0x6000BB5  System.Collections.IEnumerator __Gen_Wrap_110(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x0562978C  token=0x6000BB6  System.Boolean __Gen_Wrap_111(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x09AF9FB4  token=0x6000BB7  System.Boolean __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3, System.Boolean& P4, System.Boolean P5)
  RVA=0x09AFA10C  token=0x6000BB8  Beyond.Input.PlayerActionInfo __Gen_Wrap_113(System.Object P0)
  RVA=0x05E7902C  token=0x6000BB9  System.Boolean __Gen_Wrap_114(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3)
  RVA=0x050EE9C4  token=0x6000BBA  System.Void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0)
  RVA=0x09AFA1FC  token=0x6000BBB  System.Void __Gen_Wrap_116(System.Object P0, Beyond.EventData<System.String>& P1)
  RVA=0x05648770  token=0x6000BBC  System.Void __Gen_Wrap_117(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3)
  RVA=0x09AFA314  token=0x6000BBD  System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3, System.Boolean P4)
  RVA=0x09AFA420  token=0x6000BBE  UnityEngine.AnimationClip __Gen_Wrap_119(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x09AFA62C  token=0x6000BBF  UnityEngine.AnimationClip __Gen_Wrap_120(System.Object P0, System.Object P1)
  RVA=0x09AFA724  token=0x6000BC0  System.Void __Gen_Wrap_121(System.Object P0, Beyond.UI.UIAnimationWrapper.FOptions P1)
  RVA=0x054AB15C  token=0x6000BC1  System.Single __Gen_Wrap_122(System.Object P0, System.Object P1)
  RVA=0x09AFA830  token=0x6000BC2  Beyond.UI.UIAnimationWrapper.FOptions __Gen_Wrap_123()
  RVA=0x05E57990  token=0x6000BC3  System.Void __Gen_Wrap_124(System.Object P0, System.Object P1, System.Object P2, System.Single P3)
  RVA=0x09AFA8E8  token=0x6000BC4  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_125(System.Object P0)
  RVA=0x09AFA9D8  token=0x6000BC5  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_126(System.Object P0, System.Object P1)
  RVA=0x09AFAAE4  token=0x6000BC6  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_127(System.Object P0, System.Boolean P1)
  RVA=0x09AFABF0  token=0x6000BC7  Beyond.UI.UIAnimationSwitchTween __Gen_Wrap_128(Beyond.UI.UIAnimationSwitchTween.Builder& P0)
  RVA=0x09AFAD3C  token=0x6000BC8  UnityEngine.Camera __Gen_Wrap_129(System.Object P0)
  RVA=0x09AFAE2C  token=0x6000BC9  System.Void __Gen_Wrap_130(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  RVA=0x09AFAF40  token=0x6000BCA  System.Void __Gen_Wrap_131(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Single P4)
  RVA=0x05E5ED40  token=0x6000BCB  System.Void __Gen_Wrap_132(System.Object P0, System.Single P1, System.Boolean P2)
  RVA=0x09AFB050  token=0x6000BCC  System.Collections.IEnumerator __Gen_Wrap_133(System.Object P0, System.Object P1)
  RVA=0x09AFB15C  token=0x6000BCD  Beyond.DisposedUnityEvent<System.Int32,System.Boolean> __Gen_Wrap_134(System.Object P0)
  RVA=0x09AFB238  token=0x6000BCE  System.Void __Gen_Wrap_135(System.Object P0, UnityEngine.Vector2& P1, UnityEngine.Vector2& P2)
  RVA=0x09AFB398  token=0x6000BCF  UnityEngine.Vector2 __Gen_Wrap_136(System.Object P0, UnityEngine.Vector2 P1)
  RVA=0x050EE850  token=0x6000BD0  System.Void __Gen_Wrap_137(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x09AFB4C8  token=0x6000BD1  System.Void __Gen_Wrap_138(System.Object P0, UnityEngine.Vector3 P1)
  RVA=0x09AFB5E4  token=0x6000BD2  System.Void __Gen_Wrap_139(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4)
  RVA=0x05784998  token=0x6000BD3  System.Void __Gen_Wrap_140(System.Single P0)
  RVA=0x09AFB700  token=0x6000BD4  System.Void __Gen_Wrap_141(System.Object P0, System.Boolean P1, UnityEngine.UI.Selectable& P2, Beyond.UI.UITouchPanel& P3)
  RVA=0x09AFB88C  token=0x6000BD5  System.Void __Gen_Wrap_142(System.Object P0, System.Single P1, System.Single P2, System.Object P3)
  RVA=0x08743618  token=0x6000BD6  System.Void __Gen_Wrap_143(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3)
  RVA=0x09AFB988  token=0x6000BD7  System.Void __Gen_Wrap_144(System.Object P0, System.Single& P1, System.Single& P2)
  RVA=0x09AFBAB8  token=0x6000BD8  System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, UnityEngine.Color P2)
  RVA=0x09AFBBD4  token=0x6000BD9  UnityEngine.Canvas __Gen_Wrap_146(System.Object P0)
  RVA=0x09AFBCB0  token=0x6000BDA  HG.Rendering.Runtime.HGCamera __Gen_Wrap_147(System.Object P0)
  RVA=0x09AFBD8C  token=0x6000BDB  System.String __Gen_Wrap_148(System.Object P0, System.Object P1)
  RVA=0x050EF614  token=0x6000BDC  Beyond.Input.BindingViewState __Gen_Wrap_149(System.Object P0)
  RVA=0x09AFBFE8  token=0x6000BDD  System.String __Gen_Wrap_150(System.Object P0, Beyond.Input.BindingViewActionType P1)
  RVA=0x09AFC0F4  token=0x6000BDE  System.Boolean __Gen_Wrap_151(System.Object P0, System.String& P1, System.String& P2)
  RVA=0x055FFD60  token=0x6000BDF  System.Void __Gen_Wrap_152(System.Object P0, Beyond.Input.ActionOnSetNaviTarget P1)
  RVA=0x09AFC260  token=0x6000BE0  System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> __Gen_Wrap_153(System.Object P0)
  RVA=0x09AFC33C  token=0x6000BE1  UnityEngine.Vector2 __Gen_Wrap_154(System.Object P0)
  RVA=0x09AFC42C  token=0x6000BE2  System.Single __Gen_Wrap_155(UnityEngine.Vector2& P0)
  RVA=0x09AFC540  token=0x6000BE3  Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_156(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x09AFC67C  token=0x6000BE4  Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_157()
  RVA=0x09AFC76C  token=0x6000BE5  System.Void __Gen_Wrap_158(System.Object P0, Beyond.UI.UIColorGroup.CommonParams P1)
  RVA=0x09AFC884  token=0x6000BE6  System.Void __Gen_Wrap_159(System.Object P0, System.Object P1, Beyond.UI.UIColorGroup.CommonParams P2)
  RVA=0x09AFCB34  token=0x6000BE7  System.Void __Gen_Wrap_160(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3)
  RVA=0x09AFCC30  token=0x6000BE8  System.Void __Gen_Wrap_161(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  RVA=0x09AFCD7C  token=0x6000BE9  System.Void __Gen_Wrap_162(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4)
  RVA=0x055FFD60  token=0x6000BEA  System.Void __Gen_Wrap_163(System.Object P0, Beyond.Input.GamepadKeyCode P1)
  RVA=0x09AFCEC8  token=0x6000BEB  Beyond.UI.UICustomLayoutElement __Gen_Wrap_164(System.Object P0)
  RVA=0x09AFCFB8  token=0x6000BEC  System.String __Gen_Wrap_165(System.Object P0, System.Int32 P1)
  RVA=0x09AFD0B0  token=0x6000BED  System.Boolean __Gen_Wrap_166(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Boolean P2, System.Int32 P3)
  RVA=0x09AFD200  token=0x6000BEE  System.Boolean __Gen_Wrap_167(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Int32 P2)
  RVA=0x09AFD340  token=0x6000BEF  UnityEngine.RectTransform __Gen_Wrap_168(System.Object P0)
  RVA=0x055FFD60  token=0x6000BF0  System.Void __Gen_Wrap_169(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutType P1)
  RVA=0x09AFD520  token=0x6000BF1  UnityEngine.CanvasGroup __Gen_Wrap_170(System.Object P0)
  RVA=0x055FE324  token=0x6000BF2  System.Void __Gen_Wrap_171(System.Object P0, System.Boolean P1, System.Object P2)
  RVA=0x05496D84  token=0x6000BF3  System.Void __Gen_Wrap_172(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x09AFD5FC  token=0x6000BF4  System.Void __Gen_Wrap_173(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  RVA=0x09AFD710  token=0x6000BF5  System.Void __Gen_Wrap_174(System.Object P0, UnityEngine.Vector2 P1, System.Boolean P2)
  RVA=0x0871664C  token=0x6000BF6  System.Void __Gen_Wrap_175(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3)
  RVA=0x09AFD83C  token=0x6000BF7  System.Single __Gen_Wrap_176(System.Object P0, System.Boolean P1, System.Int32 P2)
  RVA=0x05E62488  token=0x6000BF8  System.Void __Gen_Wrap_177(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3)
  RVA=0x09AFD940  token=0x6000BF9  System.Void __Gen_Wrap_178(System.Object P0, UnityEngine.Rect P1)
  RVA=0x0871FD10  token=0x6000BFA  System.Single __Gen_Wrap_179(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x05E616F8  token=0x6000BFB  System.Void __Gen_Wrap_180(System.Object P0, System.Int32 P1, System.Single P2)
  RVA=0x09AFDB60  token=0x6000BFC  System.Boolean __Gen_Wrap_181(System.Object P0, System.Boolean P1, System.Boolean P2)
  RVA=0x09AFDC54  token=0x6000BFD  UnityEngine.UI.Selectable __Gen_Wrap_182(System.Object P0, System.Boolean P1)
  RVA=0x09AFDD4C  token=0x6000BFE  System.Boolean __Gen_Wrap_183(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4)
  RVA=0x09AFDE5C  token=0x6000BFF  System.Boolean __Gen_Wrap_184(System.Object P0, UnityEngine.UI.NaviDirection P1, System.Boolean P2)
  RVA=0x055FFD60  token=0x6000C00  System.Void __Gen_Wrap_185(System.Object P0, UnityEngine.UI.NaviDirection P1)
  RVA=0x05E7433C  token=0x6000C01  System.Boolean __Gen_Wrap_186(System.Object P0, UnityEngine.UI.NaviDirection P1)
  RVA=0x09AFDF50  token=0x6000C02  UnityEngine.Vector3 __Gen_Wrap_187()
  RVA=0x09AFE030  token=0x6000C03  System.Void __Gen_Wrap_188(UnityEngine.Vector3 P0)
  RVA=0x09AFE11C  token=0x6000C04  Beyond.UI.UIAtlasManager.UIAtlasHandle __Gen_Wrap_189(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause P0)
  RVA=0x09AFE340  token=0x6000C05  UnityEngine.Texture __Gen_Wrap_190(System.Object P0)
  RVA=0x09AFE430  token=0x6000C06  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> __Gen_Wrap_191(System.Object P0, System.Single P1, System.Single P2)
  RVA=0x09AFE548  token=0x6000C07  Beyond.UI.UIImage __Gen_Wrap_192(System.Object P0)
  RVA=0x09AFE624  token=0x6000C08  System.Boolean __Gen_Wrap_193(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig& P0)
  RVA=0x086F21C8  token=0x6000C09  System.Int32 __Gen_Wrap_194(System.Object P0, System.Single P1)
  RVA=0x05481690  token=0x6000C0A  System.Single __Gen_Wrap_195(System.Object P0, System.Single P1)
  RVA=0x050EF354  token=0x6000C0B  Beyond.UI.UIInertiaViewPager.State __Gen_Wrap_196(System.Object P0, System.Object P1)
  RVA=0x09AFE770  token=0x6000C0C  System.Boolean __Gen_Wrap_197(Beyond.UI.UIInertiaViewPager.InertiaBlocker& P0, System.Single P1)
  RVA=0x09AFE8B4  token=0x6000C0D  System.Boolean __Gen_Wrap_198(System.Object P0, System.Single P1, System.Single& P2)
  RVA=0x054A1120  token=0x6000C0E  System.Void __Gen_Wrap_199(System.Object P0, System.Single P1, System.Single P2)
  RVA=0x087040F0  token=0x6000C0F  System.Void __Gen_Wrap_200(System.Object P0, Beyond.UI.UIInertiaViewPager.State P1, Beyond.UI.UIInertiaViewPager.State P2)
  RVA=0x0514F720  token=0x6000C10  System.Void __Gen_Wrap_201(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x09AFEAD8  token=0x6000C11  System.Void __Gen_Wrap_202(Beyond.UI.UIInertiaViewPager.EmptyScrollHandler& P0)
  RVA=0x09AFEBFC  token=0x6000C12  System.Void __Gen_Wrap_203(System.Object P0, System.Boolean P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3)
  RVA=0x0549D548  token=0x6000C13  System.Void __Gen_Wrap_204(System.Object P0, UnityEngine.UI.CanvasUpdate P1)
  RVA=0x09AFED48  token=0x6000C14  UnityEngine.Transform __Gen_Wrap_205(System.Object P0)
  RVA=0x05160F3C  token=0x6000C15  System.Void __Gen_Wrap_206(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  RVA=0x09AFEE38  token=0x6000C16  System.Int32 __Gen_Wrap_207(System.Object P0, System.Boolean P1)
  RVA=0x05E5EF50  token=0x6000C17  System.Single __Gen_Wrap_208(System.Object P0, System.Int32 P1, Beyond.UI.UIScrollList.ScrollAlignType P2)
  RVA=0x09AFEF24  token=0x6000C18  System.Void __Gen_Wrap_209(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3)
  RVA=0x09AFF1EC  token=0x6000C19  System.Void __Gen_Wrap_210(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, Beyond.UI.UIScrollList.ScrollAlignType P6)
  RVA=0x09AFF320  token=0x6000C1A  System.Void __Gen_Wrap_211(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  RVA=0x09AFF444  token=0x6000C1B  UnityEngine.GameObject __Gen_Wrap_212(System.Object P0, System.Int32 P1)
  RVA=0x09AFF53C  token=0x6000C1C  Beyond.UI.UIScrollList.Cell __Gen_Wrap_213(System.Object P0, System.Int32 P1)
  RVA=0x05613324  token=0x6000C1D  System.Int32 __Gen_Wrap_214(System.Object P0, UnityEngine.UI.NaviDirection P1)
  RVA=0x0561B0C4  token=0x6000C1E  System.Int32 __Gen_Wrap_215(System.Object P0, System.Int32 P1, UnityEngine.UI.NaviDirection P2)
  RVA=0x054792E4  token=0x6000C1F  System.Void __Gen_Wrap_216(System.Object P0, System.Single P1, System.Single P2, System.Single P3)
  RVA=0x09AFF634  token=0x6000C20  System.Boolean __Gen_Wrap_217(System.Object P0, UnityEngine.Vector3 P1)
  RVA=0x09AFF75C  token=0x6000C21  UnityEngine.Vector3 __Gen_Wrap_218(System.Object P0)
  RVA=0x09AFF870  token=0x6000C22  System.Single __Gen_Wrap_219(System.Object P0, UnityEngine.Vector2 P1)
  RVA=0x09AFFB50  token=0x6000C23  System.Boolean __Gen_Wrap_220(System.Object P0, System.Single P1)
  RVA=0x09AFFC40  token=0x6000C24  Beyond.UI.UIScrollList.Padding __Gen_Wrap_221(System.Object P0)
  RVA=0x05637930  token=0x6000C25  System.Void __Gen_Wrap_222(System.Object P0, System.Int32& P1, System.Int32& P2)
  RVA=0x0561B0C4  token=0x6000C26  System.Int32 __Gen_Wrap_223(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x09AFFD38  token=0x6000C27  System.Int32 __Gen_Wrap_224(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.UI.NaviDirection P2)
  RVA=0x09AFFE60  token=0x6000C28  System.Void __Gen_Wrap_225(System.Object P0, UnityEngine.Vector2 P1, System.Int32& P2, System.Int32& P3)
  RVA=0x05477F10  token=0x6000C29  Beyond.UI.UIScrollRect.MoveTipsType __Gen_Wrap_226(System.Object P0)
  RVA=0x056479C0  token=0x6000C2A  System.Void __Gen_Wrap_227(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P3)
  RVA=0x09AFFFD0  token=0x6000C2B  System.Void __Gen_Wrap_228(System.Object P0, UnityEngine.Vector2Int P1)
  RVA=0x05477F10  token=0x6000C2C  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_229(System.Object P0)
  RVA=0x09B001C0  token=0x6000C2D  UnityEngine.Rect __Gen_Wrap_230(System.Object P0)
  RVA=0x09B002B8  token=0x6000C2E  System.Boolean __Gen_Wrap_231(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir P2, System.Object P3)
  RVA=0x05637930  token=0x6000C2F  System.Void __Gen_Wrap_232(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P2)
  RVA=0x05477B68  token=0x6000C30  System.Void __Gen_Wrap_233(System.Object P0, System.Boolean P1, System.Single P2)
  RVA=0x09B003C0  token=0x6000C31  UnityEngine.Vector3 __Gen_Wrap_234(System.Object P0, System.Int32 P1)
  RVA=0x09B004DC  token=0x6000C32  UnityEngine.Vector3[] __Gen_Wrap_235(System.Object P0)
  RVA=0x09B005CC  token=0x6000C33  UnityEngine.UI.Graphic __Gen_Wrap_236(System.Object P0)
  RVA=0x09B006BC  token=0x6000C34  Beyond.UI.UISoftMask __Gen_Wrap_237(System.Object P0)
  RVA=0x09B007AC  token=0x6000C35  System.Boolean __Gen_Wrap_238(System.Object P0, System.Single P1, System.Single P2)
  RVA=0x09B008B4  token=0x6000C36  UnityEngine.Vector2 __Gen_Wrap_239(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4)
  RVA=0x09B00C10  token=0x6000C37  System.Void __Gen_Wrap_240(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4, System.Single& P5, System.Single& P6)
  RVA=0x09B00E14  token=0x6000C38  System.Void __Gen_Wrap_241(UnityEngine.UIVertex& P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3)
  RVA=0x09B01068  token=0x6000C39  System.Void __Gen_Wrap_242(System.Object P0, System.Object P1, System.Object P2, System.Boolean& P3)
  RVA=0x09B01194  token=0x6000C3A  Beyond.UI.UISoftMaskable __Gen_Wrap_243(System.Object P0)
  RVA=0x09B01284  token=0x6000C3B  System.Collections.IEnumerator __Gen_Wrap_244(System.Object P0, System.Boolean P1, System.Int32 P2)
  RVA=0x0872224C  token=0x6000C3C  System.Void __Gen_Wrap_245(System.Object P0, System.Boolean P1, System.Int32 P2)
  RVA=0x09B01398  token=0x6000C3D  System.Void __Gen_Wrap_246(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4, System.Object P5, System.Boolean P6)
  RVA=0x05477F10  token=0x6000C3E  System.UInt32 __Gen_Wrap_247(System.Object P0)
  RVA=0x09B014D0  token=0x6000C3F  System.Void __Gen_Wrap_248(System.UInt32 P0, System.Boolean P1)
  RVA=0x09B015AC  token=0x6000C40  TMPro.TMP_FontAsset __Gen_Wrap_249(System.Object P0, System.Object P1)
  RVA=0x09B018A8  token=0x6000C41  System.Boolean __Gen_Wrap_250(System.Object P0, System.Object P1, System.UInt32 P2, TMPro.TMP_FontAsset& P3)
  RVA=0x09B01A08  token=0x6000C42  System.Boolean __Gen_Wrap_251(System.Single& P0, System.Single P1)
  RVA=0x09B01B1C  token=0x6000C43  System.Void __Gen_Wrap_252(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Object P1)
  RVA=0x09B01C80  token=0x6000C44  System.Single __Gen_Wrap_253(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Boolean& P1)
  RVA=0x09B01E18  token=0x6000C45  UnityEngine.Playables.PlayableGraph __Gen_Wrap_254(System.Object P0)
  RVA=0x09B01F24  token=0x6000C46  UnityEngine.Animations.AnimationLayerMixerPlayable __Gen_Wrap_255(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2)
  RVA=0x09B020B8  token=0x6000C47  UnityEngine.Animations.AnimationPlayableOutput __Gen_Wrap_256(System.Object P0, UnityEngine.Playables.PlayableGraph P1)
  RVA=0x09B02204  token=0x6000C48  UnityEngine.Animations.AnimationClipPlayable __Gen_Wrap_257(System.Object P0, System.Object P1, UnityEngine.Playables.PlayableGraph P2, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& P3)
  RVA=0x09B023B4  token=0x6000C49  UnityEngine.Animations.AnimationMixerPlayable __Gen_Wrap_258(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2)
  RVA=0x09B02548  token=0x6000C4A  System.Void __Gen_Wrap_259(System.Boolean P0, Beyond.Resource.FAssetProxyHandle P1)
  RVA=0x09B027B0  token=0x6000C4B  System.Void __Gen_Wrap_260(Beyond.UI.UISwitchTween.TweenContext& P0)
  RVA=0x09B028D8  token=0x6000C4C  System.Void __Gen_Wrap_261(Beyond.UI.UISwitchTween.TweenContext& P0, System.Object P1)
  RVA=0x09B02A1C  token=0x6000C4D  System.Void __Gen_Wrap_262(System.Object P0, Beyond.UI.UISwitchTween.Options P1)
  RVA=0x09B02B1C  token=0x6000C4E  Beyond.UI.UISwitchTween.TweenContext __Gen_Wrap_263(System.Object P0)
  RVA=0x09B02BF8  token=0x6000C4F  System.Boolean __Gen_Wrap_264(Beyond.UI.UISwitchTween.TweenContext& P0)
  RVA=0x09B02D20  token=0x6000C50  System.Single __Gen_Wrap_265(Beyond.UI.FadeSwitchTween.Durations& P0, System.Single P1)
  RVA=0x09B02E80  token=0x6000C51  Beyond.UI.FadeSwitchTween __Gen_Wrap_266(Beyond.UI.FadeSwitchTween.Builder& P0)
  RVA=0x09B02FEC  token=0x6000C52  UnityEngine.Vector2 __Gen_Wrap_267(System.Object P0, System.Boolean P1)
  RVA=0x09B030E4  token=0x6000C53  System.Void __Gen_Wrap_268(System.Object P0, UnityEngine.RectInt& P1)
  RVA=0x088B5978  token=0x6000C54  System.Boolean __Gen_Wrap_269(System.Object P0, System.Object P1, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& P2)
  RVA=0x09B032E4  token=0x6000C55  UnityEngine.RectInt __Gen_Wrap_270(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x09B03408  token=0x6000C56  System.Void __Gen_Wrap_271(System.Object P0, System.Object P1, System.Object P2, UnityEngine.RectInt& P3)
  RVA=0x09B03548  token=0x6000C57  System.Boolean __Gen_Wrap_272(Beyond.UI.UIAtlasManager.UIAtlasHandle& P0)
  RVA=0x09B03694  token=0x6000C58  System.Void __Gen_Wrap_273(System.Object P0, System.Collections.Generic.List<UnityEngine.RectInt>& P1)
  RVA=0x050F1370  token=0x6000C59  System.Void __Gen_Wrap_274(System.Int32 P0, System.String P1)
  RVA=0x050EF298  token=0x6000C5A  System.Boolean __Gen_Wrap_275(Beyond.UI.UIState.StateAnimationInfo P0)
  RVA=0x09B03770  token=0x6000C5B  Beyond.UI.GPUI.GPUPrefabData __Gen_Wrap_276(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2)
  RVA=0x09B03920  token=0x6000C5C  Beyond.UI.GPUI.GPUPrefabDataLite __Gen_Wrap_277(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2)
  RVA=0x09B03AB8  token=0x6000C5D  System.Boolean __Gen_Wrap_278(Beyond.UI.GPUI.GPUIHandle& P0, Beyond.UI.GPUI.GPUIHandle P1)
  RVA=0x09B03C20  token=0x6000C5E  System.Boolean __Gen_Wrap_279(Beyond.UI.GPUI.GPUIHandle& P0, System.Object P1)
  RVA=0x09B03E94  token=0x6000C5F  System.Int32 __Gen_Wrap_280(Beyond.UI.GPUI.GPUIHandle& P0)
  RVA=0x09B03FBC  token=0x6000C60  System.Boolean __Gen_Wrap_281(Beyond.UI.GPUI.GPUIHandle P0, Beyond.UI.GPUI.GPUIHandle P1)
  RVA=0x09B040E0  token=0x6000C61  Beyond.UI.GPUI.GPUIHandle __Gen_Wrap_282(System.Object P0)
  RVA=0x09B041D0  token=0x6000C62  System.Void __Gen_Wrap_283(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1)
  RVA=0x09B042E0  token=0x6000C63  System.Boolean __Gen_Wrap_284(System.Object P0, System.Object P1, Beyond.UI.GPUI.GPUIHandle& P2, System.Int32 P3)
  RVA=0x09B04438  token=0x6000C64  System.Boolean __Gen_Wrap_285(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1)
  RVA=0x09B04554  token=0x6000C65  System.Void __Gen_Wrap_286(System.Object P0, System.Int32 P1, UnityEngine.Vector3 P2)
  RVA=0x09B04688  token=0x6000C66  System.Boolean __Gen_Wrap_287(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector3 P2)
  RVA=0x09B047E0  token=0x6000C67  System.Boolean __Gen_Wrap_288(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, Beyond.UI.GPUI.GPUIHandle& P3, System.Int32 P4)
  RVA=0x09B04978  token=0x6000C68  System.Boolean __Gen_Wrap_289(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector2 P2)
  RVA=0x05E4DA84  token=0x6000C69  System.Void __Gen_Wrap_290(System.Object P0, System.Single P1, System.Int32 P2)
  RVA=0x09B04BA0  token=0x6000C6A  System.Boolean __Gen_Wrap_291(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Object P3, System.Boolean P4)
  RVA=0x09B04CEC  token=0x6000C6B  System.Boolean __Gen_Wrap_292(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Int32 P3, System.Boolean P4)
  RVA=0x09B04E24  token=0x6000C6C  System.Boolean __Gen_Wrap_293(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Boolean P3)
  RVA=0x09B04F4C  token=0x6000C6D  System.UInt32 __Gen_Wrap_294(UnityEngine.Color P0)
  RVA=0x09B0503C  token=0x6000C6E  System.Void __Gen_Wrap_295(System.Object P0, System.Int32 P1, UnityEngine.Color P2)
  RVA=0x09B05158  token=0x6000C6F  System.Boolean __Gen_Wrap_296(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, UnityEngine.Color P3)
  RVA=0x09B052AC  token=0x6000C70  System.Boolean __Gen_Wrap_297(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Object P3)
  RVA=0x09B053E8  token=0x6000C71  System.Void __Gen_Wrap_298(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32& P2, System.Int32& P3, System.Int32& P4)
  RVA=0x09B055DC  token=0x6000C72  System.Void __Gen_Wrap_299(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32 P2, System.Boolean P3)
  RVA=0x09B05860  token=0x6000C73  Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> __Gen_Wrap_300(System.Object P0)
  RVA=0x050F1FFC  token=0x6000C74  System.Int32 __Gen_Wrap_301(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x09B0596C  token=0x6000C75  Beyond.UI.GPUI.RuntimePrefabData __Gen_Wrap_302(System.Object P0, System.Object P1)
  RVA=0x09B05A64  token=0x6000C76  UnityEngine.Mesh __Gen_Wrap_303()
  RVA=0x0561A558  token=0x6000C77  System.UInt32 __Gen_Wrap_304(System.UInt32 P0, System.UInt32 P1)
  RVA=0x03D06050  token=0x6000C78  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000163
SIZE:  0x58
EXTENDS: IFix.Core.AnonymousStorey
IMPLEMENTS: System.IDisposable System.Collections.IEnumerator System.Collections.Generic.IEnumerator`1
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4c
  private           System.Int32                    methodId_4  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x09B0B1DC
  System.Collections.IEnumerator.Current  get=0x09B0B288
METHODS:
  RVA=0x05152EA8  token=0x6000C79  System.Void System.IDisposable.Dispose()
  RVA=0x05152C48  token=0x6000C7A  System.Boolean MoveNext()
  RVA=0x05152D80  token=0x6000C7C  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09B0B334  token=0x6000C7E  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x6000C7F  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000164
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000C80  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x09B0CF54  token=0x6000C81  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x02343070  token=0x6000C82  System.Boolean IsPatched(System.Int32 id)
  RVA=0x09B0CE10  token=0x6000C83  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x09B0CEDC  token=0x6000C84  System.Object CreateWrapper(System.Int32 id)
  RVA=0x09B0CFB8  token=0x6000C85  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x09B0CD6C  token=0x6000C86  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x2000165
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0  // const
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ResolveTextStyle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetAndResolveTextStyle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetPhoneticText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetPhoneticText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnEnvLangChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ReleaseUpdateFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetOriginalLinkId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetLinkId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_UpdateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_CreateUpdateFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_DelayedChangeActiveImageGo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ClearMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetOrLoadSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ProcessRichTextEntry0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_processRichTextEntryFunc0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ReturnImageGO0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ClearInlineImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GetOrCreateImageGO0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GetImageGoByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ProcessRichTextInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RefreshPopulateText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-LoadMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-Remove0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_OnPreRenderText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-DisposeInlineImageCache0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GenerateRuntimeText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-IsInvalid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-get_fontSearchData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_RefreshMatTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetI18nFont0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetFontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerExit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextWrap-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-Add0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetHyperlinkUITextGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ShrinkLinkTags0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetLinkId1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-CombineStringWithLanguageSpilt0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-UpdateI18NFontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_m_fontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetCNFontId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_m_fontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_fontSharedMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetSharedMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnAfterDeserialize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-AddSubTextObject0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-LocalStringCombineFormat0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIConst-IsPadDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIConst-GetResolutionScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-LoadModel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-LoadModelAsync0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-Cancel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-UnloadModel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-_Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetSharedIntString0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-IsScreenPosInRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-IsScreenPosInRectTransform1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-CalcBoundOfRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-TryGetTouch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetColorWithoutAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-ClearUIComponents0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-RectTransformToScreenRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetNodeScaleOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetColorByString0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetMaskRatio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetCursorTipOffsetX0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-Sync0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-Billboard-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-Billboard-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetRealIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-AdjustContainerPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CacheCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ClearShowingCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetShowRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNotCacheRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-MoveCellTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnUpdateCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-RecoverAllInput0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_TryCallAnimationInFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-InformAnimationInEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-ClearTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_InitAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-InformAnimationInStart0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayWithTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayWithTween1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayOpenAudio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayInAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateShowingCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_moveTips0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateMoveTips0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateViewEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-ScrollToIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_label0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-get_inputValidTypeMask0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-set_inputValidTypeMask0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-IsShowTypeValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-get_isValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-ToggleActiveState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-CheckState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-IsValidInput0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DeactivateNaviOnEnable-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DeactivateNaviOnEnable-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-Empty4Raycast-OnPopulateMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-get_maxFov0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FixRotation-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_TrySetRot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-AddSortingOrderComp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-RemoveSortingOrderComp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-BlockAllInput0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_AutoAnimationInFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-get_Radius0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-SetMaterialDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-SetVerticesDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-OnPopulateMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ClearNullRef0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNotch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNewNotch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_OnCanvasChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ClearList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_TryAddToSideUI0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_TraverseUI0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-FindAllSideUI0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNotch1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-UnApplyNotch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-InitConfigs0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-ResetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-RefreshPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_adapter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-SetAdapter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-OnLateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_InsertView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RemoveView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-GetVirtualView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-UpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-UpdateCount1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-InsertView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-AddView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-GetVirtualView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-UpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-UpdateCount1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-InsertView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-AddView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_CacheCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-ClearAllToast0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_GetCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayCloseAudio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayOutAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_TryShowNewCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetOutClipLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_OnCellFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_ShowCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_StartBatch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-AddToast0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UI3DScrollList-MoveCellTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-DisposeSpriteHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_LoadSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSpriteWithOutFormat0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_SetSecondIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetSecondActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetActionInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetContentState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetTextStr0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_IsInputGray0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_IsInputEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_CheckInteractable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-UpdateKeyHint0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_TryInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnChangeTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetKeyHint0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetBindingId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetBindingId1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-_FindByString0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-FindByName0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-FindByNameOrAlias0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-GetAnimationClips0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetOptions0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-IsStarted0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetAnimationInClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetInClipLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetLoopClipLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SkipInAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetClipLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-CheckStopped0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Play1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationTween-GetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationTween-_SetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-ResetToState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-Builder-Build0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-_SetHighlightNodeActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnPointerEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnPointerExit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-CloseSelf0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-TryCloseSelf0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_UpdateState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_GetUICamera0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ShouldClose0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OpenSelf0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetBigLogoEditor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ShowBigLogo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetBigLogoMask0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ClearBigLogoMask0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ClearBigLogo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetMaskAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_StopLongPressCor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_DoClickAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_PlayClickAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnPress0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnPointerUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-get_zoomEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_PosAdjust0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_SetScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnZoom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnControllerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_InitControllerBindings0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshController0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ManuallyZoom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_ResetControllerState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-FocusNode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-FocusNode1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ZoomToFullRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ChangePaddingRight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-SetZoomRangeMax0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-SyncZoomValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-GetZoomRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ClearAllTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetMaterialKey0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetColor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-ClearMaterialCache0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-get_canvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-_GetCamera0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-UpdateSortingOrder0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-InitRT0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-SetUseSceneColorPS0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-Register0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-UnRegister0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-UpdateRT0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-_Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-SetCustomBlurImg0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_UpdateState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_Press0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnUpdateKey0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_InitActionOnSetNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_NotifyIsHover0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-set_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnInteractableChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_bindingViewActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-set_customBindingViewLabelText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_hintText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_bindingViewState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-GetBindingViewActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_RefreshHoverEnableNode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-GetMouseActionHints0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnNaviTargetEnabledAgain0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_ToggleNaviInputBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnSetAsNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-_OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-UpdateCanvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-AddCanvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-RemoveCanvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_SetColor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_ApplyOptToGraphics0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-set_color0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-AttachGraphic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeColorRGB0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeColor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeColor1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-_TryStaticInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-SetKeyIconName0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-IsDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-IsDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_SetChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-get_Element0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_GetMarginSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-ResetToDefault0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-ResetToDefault0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-SaveData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-Save0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-_LogEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-Save0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-ResetToDefault0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-get_highlightRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_SetDefaultValues0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-LoadData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-RefreshAll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_position0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_scale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_alpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_layoutType0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-get_playing0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ResetPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_RefreshPosY0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-RefreshAutoScrollData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-SetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-RefreshText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnVisibleCharactersChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-StopPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetAutoWaitTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetScrollSpeed0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_TryAutoScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_UpdateTextAuto0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-SeekToEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ManualUpdateByPercent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ManualUpdateByTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-ResetPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-get_canvasGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-UpdateAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-SetRadioIcon0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-ApplyDragArea0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-get_m_dragParentRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-_StopDragView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-_ContinueDragOnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-ClearEvents0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_GetDefaultNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ToggleOptions0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ControllerToggle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnStopFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ToggleOptions0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ControllerCancel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_NotifyIsHover0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_GetUICamera0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-SetSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_GetUICamera0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ScrollTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-AutoScrollToRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ScrollToSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Refresh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-get_bindingViewLabelText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-get_bindingViewState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-GetBindingViewActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdownOption-SetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-SetController0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-get_IsEmpty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGameObject0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGraphic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetTop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetBottom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetLeft0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetRight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyButton0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyAnimator0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyLayoutElement0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyInnerState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-ScheduleForPlaying0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateAnimationInfo-OnUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-ScheduleForStopping0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetLeftLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_SetRealPadding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetContainerSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetContainerSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateContainerSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPadding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyScrollList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-_ApplyState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-SetState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdownOption-SetState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ClearEvents0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ToggleHighlight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDrop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-UpdatePosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-UpdatePosition1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-Refresh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnFoldOut0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnFoldIn0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-RectWrapNavigate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-WrapNavigation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-TrySyncRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnEnableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-set_color0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_OnSpriteChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnPopulateMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_AddUIImageToManager0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-AddUIImageToManager0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-SetNativeSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSprite1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-ReleaseSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-get_mainTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_V2AtlasInitialize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnChangeSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillAmountOffset-set_fillAmount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillAmountOffset-DOFillAmount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-RefreshFillAmount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-RefreshFollower0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-LoadSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-LoadSprite1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-set_color0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-get_first0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PlayAudioGear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_InitIfNot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_SwitchToPage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_AutoAlign0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_OnStateChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-SetPageCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-MoveToPage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-get_isControllerInputValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-SendOnFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-SendOnFocusLost0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardSelect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnSelect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardDeselect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDeselect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-set_s_focusedInputField0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-ActivateInputField0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-DeactivateInputField0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_UpdateBindingEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_NotifyIsHover0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnInteractableChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_GetCamera0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_UpdateKeyboardOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_CleanupAndroidObjects0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_KeyboardHeightChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateWalkBgScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-set_walkRation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateGait0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateIndicator0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetWalkBgVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetRunBgVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateBg0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_Activate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnPointerUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_ChangeDynamic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_OnHudLayoutLoaded0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-CheckShouldActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-LayoutComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-Rebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_SetDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-UpdateByPlayTime0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-SetVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-Exit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-StartAutoPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-SetLeftSubTitle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-_TryUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-ForceUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_GetLineCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CalcSomeCountNum0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SyncViewSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-InitBasicInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetLeftLength0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-InitConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_currentStep0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_StartGraduallyShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-StopGraduallyShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SkipGraduallyShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetTargetPosByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-TryClearAdjustTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_ScrollToPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScrollTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-RestartGraduallyShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount2  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_curSelectedIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-set_curSelectedIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Get0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCell1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScrollToIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetSelectedIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNaviOffset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNaviNewIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-NavigateSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitNavigation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-TryRecalculateSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-_GetCellSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_inScrollTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetContainerSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetShowRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-MoveCellTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-get_rectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-SyncSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ScrollTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-get_currentStep0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetStepTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ToggleByState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-Toggle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-FoldAll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-Rebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-get_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-set_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_TweenToTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIPCScaleHelper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnValidate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-_IsValidScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-_HoldScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-SetExtraScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-GetExtraScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbar-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbarKeyHint-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbarKeyHint-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-get_viewRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-IsActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_GetDeltaAngle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_CheckCanMove0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateSpeed0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_GetRealIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateShowingCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateCenterIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_TryUpdateCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateAuto0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_InitCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_OnAwakeInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateScrollRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_DoScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Rebuild0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-LayoutComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-GraphicUpdateComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-IsDestroyed0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-ScrollToIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-UpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Get0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Cell-SetSelect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_SetAutoScrollSpd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnExitAutoScrollUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnExitAutoScrollDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitAutoScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ListWrapNavigate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitControllerNavi0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InGameAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_EditorAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateGraduallyShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetStepTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateAutoScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetTop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount2  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateShowingCells1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetRangeInView0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetCellCanCache0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CacheShowingCell0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingBottom0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingTop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingRight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingLeft0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetPadding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetShowingCellsIndexRange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetSpace0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCenterIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetIndexOf0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScreenPos2Index0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetMousePosIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CheckOverScrollEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ScrollToNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_InitController0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_moveTips0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_UpdateMoveTips0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-IsCellViewed0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-UpdateScrollEnableNode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-LateUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_InitIfNot0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ApplyTextAlignment0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ResetTextScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ResetTextScrollInternal0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-ResetTextScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_UpdateScrollState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ApplyTextScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_InitializeCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-UpdateLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_ApplyDamping0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-RefreshLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-SetSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Skip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleStateController-SetState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleStateController-StateInfo-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_TryPostSlideAudioEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-ClampValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-CustomProcessNormalizedValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnClickSliderBar0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnClickSliderHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_NotifyIsHover0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_ApplyStickScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_StickScrollHoriValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_InitStickScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_AddValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_ReduceValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-get_bindingViewState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-GetBindingViewActionId0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetCornerCanvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_graphic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_UpdateChildren0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_UpdateParam0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_DestroyMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-TailLateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_softMask0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_uiText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-GetModifiedMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-ModifyMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_Equal0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ComputeLineCross0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_SetUIVertexUV0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ClipRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-ModifyMesh1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetChildrenRenderers0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetCanvas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-SetOrder0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_GetClampedIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_TryAutoScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_OnScrollEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_OnScrollStart0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-InitConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-SetTop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-UpdateShowingCells0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-_IsValidStyle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-UpdateStyle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-_SetAsDefault0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-SetSubtitle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-UpdateAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-get_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-set_text0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-set_color0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-get_first0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-SetAndResolveTextStyle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-SetPhoneticText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_OnToggleFail0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-TryInternalToggle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshBindingText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshToggleBindingText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_InitToggleBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_UpdateObjects0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_PlayAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_UpdateBindingEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-PlayAudio0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-InternalToggle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnValueChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_NotifyIsHover0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnInteractableChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-GetMouseActionHints0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnSubmit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_ToggleNaviInputBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_OnSetAsNaviTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-_MoveTo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-MoveToNext0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-MoveToPrevious0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_IsSameTouchFromPress0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnBeginDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-DoEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnEndDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDrag0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_OnActionPress0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_OnActionRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerUp0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerExit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-ClearTouchInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnScroll0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-SimulateClick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-DeActiveTouch0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_UpdateState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-InitBinding0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-ClearComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-get_graphic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-get_softMaskable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_UpdateParam0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_DestroyMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-GetModifiedMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-VirtualMouseInitPos-get_panel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-VirtualMouseInitPos-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-_OnConfirm0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-_OnCancel0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-Show0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-ClearAllPanels0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonShort0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-TickAsCountDown0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-FLerpByTime-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-FLerpByTime-GetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-LockToClip0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateGraph0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateMixer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateOutput0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-_LoadSprite0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-set_spritePath0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSpriteByName-set_spriteName0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-BeforeShowEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-BeforeHideEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-AfterShowEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-AfterHideEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-ResetToState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-OnReset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-ClearTween0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-_ClearTweenInternal0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Show0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Hide0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-WaitForTweening0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-SetOptions0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-GetContext0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-IsInterapted0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-IsActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-set_activeAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-SetObjectActive0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-BeforeShowEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-AfterHideEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-ResetToState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Release0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Builder-Build0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-ResetToState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ProcessInsertQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_CreateTickFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ClearTickFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-OnUnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-Release0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-GetAtlasCount0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimation-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimation-UnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimation-AddRedDotImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimationNode-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimationNode-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIRedDotAnimationNode-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-WebApplication-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsAnimator0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsButton0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-GetName0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-get_ReadableDescription0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsGameObject0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsState0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsImage0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsRectTransform0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsLayoutElement0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsGraphic0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsScrollList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_EqualsByTargetType0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-op_Equality0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-op_Inequality0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-Equals1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_GetTargetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-GetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnImageChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnScrollListChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnTextChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Run0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-HandleScheduledStates0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-_HandleStateAnimations0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-Equals1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-GetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-op_Equality0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-op_Inequality0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-GetFontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-get_fontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-set_fontAsset0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_GetOneHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-Create0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Add0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_CreateInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetRootPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-CreateInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Remove0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-Recycle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DestroyInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-DestroyInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-IsInstanceValid0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetRootScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetRootScale0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-StartAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-StartAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-StartAnimation1  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetVisibility0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetColor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetColor0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetText0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_CleanMaterials0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-DoUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RenderNodes0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_InitMaterials0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadGroupData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-UpdateMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetVisibility0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-CodePoint-ConvertToUTF320  // const
METHODS:
END_CLASS

