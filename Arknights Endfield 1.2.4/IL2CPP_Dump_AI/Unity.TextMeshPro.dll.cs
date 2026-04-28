// ========================================================
// Dumped by @desirepro
// Assembly: Unity.TextMeshPro.dll
// Classes:  185
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

CLASS: <DelayedGraphicRebuild>d__18
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            TMPro.TextMeshProUGUI           <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000E7  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000E8  System.Void System.IDisposable.Dispose()
  RVA=0x09CEE810  token=0x60000E9  System.Boolean MoveNext()
  RVA=0x09CEE8BC  token=0x60000EB  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <DelayedMaterialRebuild>d__19
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            TMPro.TextMeshProUGUI           <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000ED  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000EE  System.Void System.IDisposable.Dispose()
  RVA=0x09CEE908  token=0x60000EF  System.Boolean MoveNext()
  RVA=0x09CEE9BC  token=0x60000F1  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: PoolOptions
TYPE:  sealed struct
TOKEN: 0x2000023
FIELDS:
  public    static readonly TMPro.TMP_ArrayObjectPool.PoolOptions<T>Default  // static @ 0x0
  public    readonly System.Boolean                  restrictArraySize  // 0x0
  public    readonly System.Collections.Generic.IReadOnlyList<System.Int32>allowedSizes  // 0x0
  public    readonly System.Int32                    maxTotalCachedCount  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600012D  System.Void .ctor(System.Boolean restrictArraySize, System.Collections.Generic.IReadOnlyList<System.Int32> allowedSizes, System.Int32 maxTotalCachedCount)
  RVA=-1  // not resolved  token=0x600012E  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000025
FIELDS:
  public    static readonly TMPro.TMP_ArrayPool.<>c<T>      <>9  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000135  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000136  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000137  System.Void <.cctor>b__2_0(T[] arr)
END_CLASS

CLASS: AnchorPositions
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTopLeft  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTop  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTopRight  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsLeft  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsCenter  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsRight  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottomLeft  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottom  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottomRight  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBaseLine  // const
  public    static  TMPro.TMP_Compatibility.AnchorPositionsNone  // const
METHODS:
END_CLASS

CLASS: ColorTweenMode
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.ColorTween.ColorTweenMode All  // const
  public    static  TMPro.ColorTween.ColorTweenMode RGB  // const
  public    static  TMPro.ColorTween.ColorTweenMode Alpha  // const
METHODS:
END_CLASS

CLASS: ColorTweenCallback
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09CEEA58  token=0x600017C  System.Void .ctor()
END_CLASS

CLASS: FloatTweenCallback
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09CEEF00  token=0x600018A  System.Void .ctor()
END_CLASS

CLASS: <Start>d__2
TYPE:  sealed class
TOKEN: 0x200003B
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            T                               tweenInfo  // 0x0
  private           System.Single                   <elapsedTime>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000190  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000191  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000192  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000194  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Resources
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x48
FIELDS:
  public            UnityEngine.Sprite              standard  // 0x10
  public            UnityEngine.Sprite              background  // 0x18
  public            UnityEngine.Sprite              inputField  // 0x20
  public            UnityEngine.Sprite              knob  // 0x28
  public            UnityEngine.Sprite              checkmark  // 0x30
  public            UnityEngine.Sprite              dropdown  // 0x38
  public            UnityEngine.Sprite              mask  // 0x40
METHODS:
END_CLASS

CLASS: DropdownItem
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ICancelHandler
FIELDS:
  private           TMPro.TMP_Text                  m_Text  // 0x18
  private           UnityEngine.UI.Image            m_Image  // 0x20
  private           UnityEngine.RectTransform       m_RectTransform  // 0x28
  private           UnityEngine.UI.Toggle           m_Toggle  // 0x30
PROPERTIES:
  text  get=0x01041090  set=0x022C3A90
  image  get=0x03D4EB40  set=0x04271930
  rectTransform  get=0x03D4EAC0  set=0x02C92F10
  toggle  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x09CEECB8  token=0x60001DF  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CEEC40  token=0x60001E0  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0426FE60  token=0x60001E1  System.Void .ctor()
END_CLASS

CLASS: OptionData
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x20
FIELDS:
  private           System.String                   m_Text  // 0x10
  private           UnityEngine.Sprite              m_Image  // 0x18
PROPERTIES:
  text  get=0x020B7B20  set=0x0426FEE0
  image  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x60001E6  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60001E7  System.Void .ctor(System.String text)
  RVA=0x022C3A90  token=0x60001E8  System.Void .ctor(UnityEngine.Sprite image)
  RVA=0x02676770  token=0x60001E9  System.Void .ctor(System.String text, UnityEngine.Sprite image)
END_CLASS

CLASS: OptionDataList
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>m_Options  // 0x10
PROPERTIES:
  options  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x09CEFC64  token=0x60001EC  System.Void .ctor()
END_CLASS

CLASS: DropdownEvent
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09CEEC04  token=0x60001ED  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass69_0
TYPE:  sealed class
TOKEN: 0x2000043
SIZE:  0x20
FIELDS:
  public            TMPro.TMP_Dropdown.DropdownItem item  // 0x10
  public            TMPro.TMP_Dropdown              <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001EE  System.Void .ctor()
  RVA=0x09CFC25C  token=0x60001EF  System.Void <Show>b__0(System.Boolean x)
END_CLASS

CLASS: <DelayedDestroyDropdownList>d__81
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Single                   delay  // 0x20
  public            TMPro.TMP_Dropdown              <>4__this  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001F0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001F1  System.Void System.IDisposable.Dispose()
  RVA=0x09CFC0E4  token=0x60001F2  System.Boolean MoveNext()
  RVA=0x09CFC180  token=0x60001F4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000047
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.TMP_FontAsset.<>c         <>9  // static @ 0x0
  public    static  System.Func<TMPro.TMP_Character,System.UInt32><>9__133_0  // static @ 0x8
  public    static  System.Func<UnityEngine.TextCore.Glyph,System.UInt32><>9__134_0  // static @ 0x10
METHODS:
  RVA=0x09CFC28C  token=0x600025D  System.Void .cctor()
  RVA=0x0350B670  token=0x600025E  System.Void .ctor()
  RVA=0x09CFC1CC  token=0x600025F  System.UInt32 <SortCharacterTable>b__133_0(TMPro.TMP_Character c)
  RVA=0x0945DFE0  token=0x6000260  System.UInt32 <SortGlyphTable>b__134_0(UnityEngine.TextCore.Glyph c)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x18
FIELDS:
  public            System.UInt32                   first  // 0x10
  public            System.UInt32                   second  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600027B  System.Void .ctor()
  RVA=0x09CFC1FC  token=0x600027C  System.Boolean <AddKerningPair>b__0(TMPro.KerningPair item)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x18
FIELDS:
  public            System.UInt32                   first  // 0x10
  public            System.UInt32                   second  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600027D  System.Void .ctor()
  RVA=0x09CFC1FC  token=0x600027E  System.Boolean <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item)
END_CLASS

CLASS: <>c__DisplayClass5_0
TYPE:  sealed class
TOKEN: 0x2000052
SIZE:  0x18
FIELDS:
  public            System.Int32                    left  // 0x10
  public            System.Int32                    right  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600027F  System.Void .ctor()
  RVA=0x09CFC228  token=0x6000280  System.Boolean <RemoveKerningPair>b__0(TMPro.KerningPair item)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.KerningTable.<>c          <>9  // static @ 0x0
  public    static  System.Func<TMPro.KerningPair,System.UInt32><>9__7_0  // static @ 0x8
  public    static  System.Func<TMPro.KerningPair,System.UInt32><>9__7_1  // static @ 0x10
METHODS:
  RVA=0x09CFC2F0  token=0x6000281  System.Void .cctor()
  RVA=0x0350B670  token=0x6000282  System.Void .ctor()
  RVA=0x0945DFE0  token=0x6000283  System.UInt32 <SortKerningPairs>b__7_0(TMPro.KerningPair s)
  RVA=0x09CFC1E4  token=0x6000284  System.UInt32 <SortKerningPairs>b__7_1(TMPro.KerningPair s)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.TMP_FontFeatureTable.<>c  <>9  // static @ 0x0
  public    static  System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32><>9__6_0  // static @ 0x8
  public    static  System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32><>9__6_1  // static @ 0x10
METHODS:
  RVA=0x09D03618  token=0x60002B1  System.Void .cctor()
  RVA=0x0350B670  token=0x60002B2  System.Void .ctor()
  RVA=0x09D035E8  token=0x60002B3  System.UInt32 <SortGlyphPairAdjustmentRecords>b__6_0(TMPro.TMP_GlyphPairAdjustmentRecord s)
  RVA=0x09D03600  token=0x60002B4  System.UInt32 <SortGlyphPairAdjustmentRecords>b__6_1(TMPro.TMP_GlyphPairAdjustmentRecord s)
END_CLASS

CLASS: ContentType
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.ContentTypeStandard  // const
  public    static  TMPro.TMP_InputField.ContentTypeAutocorrected  // const
  public    static  TMPro.TMP_InputField.ContentTypeIntegerNumber  // const
  public    static  TMPro.TMP_InputField.ContentTypeDecimalNumber  // const
  public    static  TMPro.TMP_InputField.ContentTypeAlphanumeric  // const
  public    static  TMPro.TMP_InputField.ContentTypeName  // const
  public    static  TMPro.TMP_InputField.ContentTypeEmailAddress  // const
  public    static  TMPro.TMP_InputField.ContentTypePassword  // const
  public    static  TMPro.TMP_InputField.ContentTypePin  // const
  public    static  TMPro.TMP_InputField.ContentTypeCustom  // const
METHODS:
END_CLASS

CLASS: InputType
TYPE:  sealed struct
TOKEN: 0x200005F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.InputType  Standard  // const
  public    static  TMPro.TMP_InputField.InputType  AutoCorrect  // const
  public    static  TMPro.TMP_InputField.InputType  Password  // const
METHODS:
END_CLASS

CLASS: CharacterValidation
TYPE:  sealed struct
TOKEN: 0x2000060
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.CharacterValidationNone  // const
  public    static  TMPro.TMP_InputField.CharacterValidationDigit  // const
  public    static  TMPro.TMP_InputField.CharacterValidationInteger  // const
  public    static  TMPro.TMP_InputField.CharacterValidationDecimal  // const
  public    static  TMPro.TMP_InputField.CharacterValidationAlphanumeric  // const
  public    static  TMPro.TMP_InputField.CharacterValidationName  // const
  public    static  TMPro.TMP_InputField.CharacterValidationRegex  // const
  public    static  TMPro.TMP_InputField.CharacterValidationEmailAddress  // const
  public    static  TMPro.TMP_InputField.CharacterValidationCustomValidator  // const
METHODS:
END_CLASS

CLASS: LineType
TYPE:  sealed struct
TOKEN: 0x2000061
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.LineType   SingleLine  // const
  public    static  TMPro.TMP_InputField.LineType   MultiLineSubmit  // const
  public    static  TMPro.TMP_InputField.LineType   MultiLineNewline  // const
METHODS:
END_CLASS

CLASS: OnValidateInput
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09CFC420  token=0x600039C  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x600039D  System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar)
  RVA=0x09CFC384  token=0x600039E  System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object)
  RVA=0x080658B0  token=0x600039F  System.Char EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SubmitEvent
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02849CF0  token=0x60003A0  System.Void .ctor()
END_CLASS

CLASS: OnChangeEvent
TYPE:  class
TOKEN: 0x2000064
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x028498E0  token=0x60003A1  System.Void .ctor()
END_CLASS

CLASS: SelectionEvent
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02849D30  token=0x60003A2  System.Void .ctor()
END_CLASS

CLASS: TextSelectionEvent
TYPE:  class
TOKEN: 0x2000066
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`3
FIELDS:
METHODS:
  RVA=0x02849D70  token=0x60003A3  System.Void .ctor()
END_CLASS

CLASS: TouchScreenKeyboardEvent
TYPE:  class
TOKEN: 0x2000067
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02849E10  token=0x60003A4  System.Void .ctor()
END_CLASS

CLASS: EditState
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.EditState  Continue  // const
  public    static  TMPro.TMP_InputField.EditState  Finish  // const
METHODS:
END_CLASS

CLASS: <CaretBlink>d__291
TYPE:  sealed class
TOKEN: 0x2000069
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            TMPro.TMP_InputField            <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003A5  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003A6  System.Void System.IDisposable.Dispose()
  RVA=0x02CD9C00  token=0x60003A7  System.Boolean MoveNext()
  RVA=0x09D032F4  token=0x60003A9  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <MouseDragOutsideRect>d__309
TYPE:  sealed class
TOKEN: 0x200006A
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            TMPro.TMP_InputField            <>4__this  // 0x20
  public            UnityEngine.EventSystems.PointerEventDataeventData  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003AB  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003AC  System.Void System.IDisposable.Dispose()
  RVA=0x09D03340  token=0x60003AD  System.Boolean MoveNext()
  RVA=0x09D0359C  token=0x60003AF  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200006F
FIELDS:
  public    static readonly TMPro.TMP_ListPool.<>c<T>       <>9  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60003BA  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60003BB  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60003BC  System.Void <.cctor>b__3_0(System.Collections.Generic.List<T> l)
END_CLASS

CLASS: FallbackMaterial
TYPE:  class
TOKEN: 0x2000071
SIZE:  0x38
FIELDS:
  public            System.Int64                    fallbackID  // 0x10
  public            UnityEngine.Material            sourceMaterial  // 0x18
  private           System.Int32                    sourceMaterialCRC  // 0x20
  public            UnityEngine.Material            fallbackMaterial  // 0x28
  public            System.Int32                    count  // 0x30
METHODS:
  RVA=0x0350B670  token=0x60003D3  System.Void .ctor()
END_CLASS

CLASS: MaskingMaterial
TYPE:  class
TOKEN: 0x2000072
SIZE:  0x28
FIELDS:
  public            UnityEngine.Material            baseMaterial  // 0x10
  public            UnityEngine.Material            stencilMaterial  // 0x18
  public            System.Int32                    count  // 0x20
  public            System.Int32                    stencilID  // 0x24
METHODS:
  RVA=0x0350B670  token=0x60003D4  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x2000073
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            stencilMaterial  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003D5  System.Void .ctor()
  RVA=0x09D1B08C  token=0x60003D6  System.Boolean <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item)
END_CLASS

CLASS: <>c__DisplayClass15_0
TYPE:  sealed class
TOKEN: 0x2000074
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            stencilMaterial  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003D7  System.Void .ctor()
  RVA=0x09D1B0F0  token=0x60003D8  System.Boolean <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item)
END_CLASS

CLASS: <>c__DisplayClass16_0
TYPE:  sealed class
TOKEN: 0x2000075
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            stencilMaterial  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003D9  System.Void .ctor()
  RVA=0x09D1B154  token=0x60003DA  System.Boolean <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item)
END_CLASS

CLASS: <>c__DisplayClass17_0
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            baseMaterial  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003DB  System.Void .ctor()
  RVA=0x09D1B1B8  token=0x60003DC  System.Boolean <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item)
END_CLASS

CLASS: LineBreakingTable
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x20
FIELDS:
  public            System.Collections.Generic.Dictionary<System.Int32,System.Char>leadingCharacters  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,System.Char>followingCharacters  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600042F  System.Void .ctor()
END_CLASS

CLASS: <DoSpriteAnimationInternal>d__7
TYPE:  sealed class
TOKEN: 0x2000086
SIZE:  0x228
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            TMPro.TMP_SpriteAnimator        <>4__this  // 0x20
  public            System.Int32                    start  // 0x28
  public            System.Int32                    end  // 0x2c
  public            TMPro.TMP_SpriteAsset           spriteAsset  // 0x30
  public            System.Int32                    currentCharacter  // 0x38
  public            System.Int32                    framerate  // 0x3c
  private           System.Int32                    <currentFrame>5__2  // 0x40
  private           TMPro.TMP_CharacterInfo         <charInfo>5__3  // 0x48
  private           System.Int32                    <materialIndex>5__4  // 0x1c0
  private           System.Int32                    <vertexIndex>5__5  // 0x1c4
  private           TMPro.TMP_MeshInfo              <meshInfo>5__6  // 0x1c8
  private           System.Single                   <baseSpriteScale>5__7  // 0x218
  private           System.Single                   <elapsedTime>5__8  // 0x21c
  private           System.Single                   <targetTime>5__9  // 0x220
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000441  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000442  System.Void System.IDisposable.Dispose()
  RVA=0x09D1A734  token=0x6000443  System.Boolean MoveNext()
  RVA=0x09D1B040  token=0x6000445  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000088
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.TMP_SpriteAsset.<>c       <>9  // static @ 0x0
  public    static  System.Func<TMPro.TMP_SpriteGlyph,System.UInt32><>9__40_0  // static @ 0x8
  public    static  System.Func<TMPro.TMP_SpriteCharacter,System.UInt32><>9__41_0  // static @ 0x10
METHODS:
  RVA=0x09D1B21C  token=0x6000462  System.Void .cctor()
  RVA=0x0350B670  token=0x6000463  System.Void .ctor()
  RVA=0x0945DFE0  token=0x6000464  System.UInt32 <SortGlyphTable>b__40_0(TMPro.TMP_SpriteGlyph item)
  RVA=0x09CFC1CC  token=0x6000465  System.UInt32 <SortCharacterTable>b__41_0(TMPro.TMP_SpriteCharacter c)
END_CLASS

CLASS: CharacterSubstitution
TYPE:  sealed struct
TOKEN: 0x200009D
SIZE:  0x18
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.UInt32                   unicode  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x600061F  System.Void .ctor(System.Int32 index, System.UInt32 unicode)
END_CLASS

CLASS: TextInputSources
TYPE:  sealed struct
TOKEN: 0x200009E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_Text.TextInputSources TextInputBox  // const
  public    static  TMPro.TMP_Text.TextInputSources SetText  // const
  public    static  TMPro.TMP_Text.TextInputSources SetTextArray  // const
  public    static  TMPro.TMP_Text.TextInputSources TextString  // const
METHODS:
END_CLASS

CLASS: UnicodeChar
TYPE:  sealed struct
TOKEN: 0x200009F
SIZE:  0x1C
FIELDS:
  public            System.Int32                    unicode  // 0x10
  public            System.Int32                    stringIndex  // 0x14
  public            System.Int32                    length  // 0x18
METHODS:
END_CLASS

CLASS: SpecialCharacter
TYPE:  sealed struct
TOKEN: 0x20000A0
SIZE:  0x30
FIELDS:
  public            TMPro.TMP_Character             character  // 0x10
  public            TMPro.TMP_FontAsset             fontAsset  // 0x18
  public            UnityEngine.Material            material  // 0x20
  public            System.Int32                    materialIndex  // 0x28
METHODS:
  RVA=0x0296AA20  token=0x6000620  System.Void .ctor(TMPro.TMP_Character character, System.Int32 materialIndex)
END_CLASS

CLASS: TextBackingContainer
TYPE:  sealed struct
TOKEN: 0x20000A1
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.UInt32[]                 m_Array  // 0x10
  private           System.Int32                    m_Count  // 0x18
PROPERTIES:
  Capacity  get=0x04271BF0
  Count  get=0x03D516F0  set=0x03D51710
  Item  get=0x025716A0  set=0x028179D0
METHODS:
  RVA=0x0285F330  token=0x6000626  System.Void .ctor(System.Int32 size)
  RVA=0x0337F9E0  token=0x6000627  System.Void Resize(System.Int32 size)
  RVA=0x0285EC40  token=0x6000628  System.Void Dispose()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.TMP_Text.<>c              <>9  // static @ 0x0
  public    static  System.Action<TMPro.TMP_TextInfo><>9__686_0  // static @ 0x8
METHODS:
  RVA=0x03D172D0  token=0x6000629  System.Void .cctor()
  RVA=0x0350B670  token=0x600062A  System.Void .ctor()
  RVA=0x0350B670  token=0x600062B  System.Void <.ctor>b__686_0(TMPro.TMP_TextInfo <p0>)
END_CLASS

CLASS: LineSegment
TYPE:  sealed struct
TOKEN: 0x20000AE
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector3             Point1  // 0x10
  public            UnityEngine.Vector3             Point2  // 0x1c
METHODS:
  RVA=0x03D4FF30  token=0x6000696  System.Void .ctor(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
END_CLASS

CLASS: SpriteFrame
TYPE:  sealed struct
TOKEN: 0x20000B3
SIZE:  0x20
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   w  // 0x18
  public            System.Single                   h  // 0x1c
METHODS:
  RVA=0x09D1B280  token=0x60006B5  System.String ToString()
END_CLASS

CLASS: SpriteSize
TYPE:  sealed struct
TOKEN: 0x20000B4
SIZE:  0x18
FIELDS:
  public            System.Single                   w  // 0x10
  public            System.Single                   h  // 0x14
METHODS:
  RVA=0x09D1B3F0  token=0x60006B6  System.String ToString()
END_CLASS

CLASS: Frame
TYPE:  sealed struct
TOKEN: 0x20000B5
SIZE:  0x50
FIELDS:
  public            System.String                   filename  // 0x10
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrameframe  // 0x18
  public            System.Boolean                  rotated  // 0x28
  public            System.Boolean                  trimmed  // 0x29
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFramespriteSourceSize  // 0x2c
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSizesourceSize  // 0x3c
  public            UnityEngine.Vector2             pivot  // 0x44
METHODS:
END_CLASS

CLASS: Meta
TYPE:  sealed struct
TOKEN: 0x20000B6
SIZE:  0x48
FIELDS:
  public            System.String                   app  // 0x10
  public            System.String                   version  // 0x18
  public            System.String                   image  // 0x20
  public            System.String                   format  // 0x28
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSizesize  // 0x30
  public            System.Single                   scale  // 0x38
  public            System.String                   smartupdate  // 0x40
METHODS:
END_CLASS

CLASS: SpriteDataObject
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x50
FIELDS:
  public            System.Collections.Generic.List<TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Frame>frames  // 0x10
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Metameta  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60006B7  System.Void .ctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x1C
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x20000B8
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=121C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB  // static @ 0x0
METHODS:
END_CLASS

CLASS: TMPro.FastAction
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action>delegates  // 0x10
  private           System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>>lookup  // 0x18
METHODS:
  RVA=0x09CE3BCC  token=0x6000001  System.Void Add(System.Action rhs)
  RVA=0x09CE3D00  token=0x6000002  System.Void Remove(System.Action rhs)
  RVA=0x09CE3C80  token=0x6000003  System.Void Call()
  RVA=0x037F5CE0  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`1
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>>lookup  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000005  System.Void Add(System.Action<A> rhs)
  RVA=-1  // not resolved  token=0x6000006  System.Void Remove(System.Action<A> rhs)
  RVA=-1  // not resolved  token=0x6000007  System.Void Call(A a)
  RVA=-1  // not resolved  token=0x6000008  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`2
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A,B>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>>lookup  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000009  System.Void Add(System.Action<A,B> rhs)
  RVA=-1  // not resolved  token=0x600000A  System.Void Remove(System.Action<A,B> rhs)
  RVA=-1  // not resolved  token=0x600000B  System.Void Call(A a, B b)
  RVA=-1  // not resolved  token=0x600000C  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`3
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A,B,C>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>>lookup  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600000D  System.Void Add(System.Action<A,B,C> rhs)
  RVA=-1  // not resolved  token=0x600000E  System.Void Remove(System.Action<A,B,C> rhs)
  RVA=-1  // not resolved  token=0x600000F  System.Void Call(A a, B b, C c)
  RVA=-1  // not resolved  token=0x6000010  System.Void .ctor()
END_CLASS

CLASS: TMPro.IFontAssetLoader
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000011  System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset)
  RVA=-1  // abstract  token=0x6000012  System.Void TryRemoveRefText(TMPro.TMP_Text refText)
END_CLASS

CLASS: TMPro.ITextPreprocessor
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000013  System.String PreprocessText(System.String text)
END_CLASS

CLASS: TMPro.MaterialReferenceManager
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x30
FIELDS:
  private   static  TMPro.MaterialReferenceManager  s_Instance  // static @ 0x0
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material>m_FontMaterialReferenceLookup  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset>m_FontAssetReferenceLookup  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_SpriteAsset>m_SpriteAssetReferenceLookup  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_ColorGradient>m_ColorGradientReferenceLookup  // 0x28
PROPERTIES:
  instance  get=0x09CE4694
METHODS:
  RVA=0x09CE3F28  token=0x6000015  System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09CE3E78  token=0x6000016  System.Void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09CE4168  token=0x6000017  System.Void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset)
  RVA=0x09CE3FF8  token=0x6000018  System.Void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset)
  RVA=0x09CE4198  token=0x6000019  System.Void AddSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset)
  RVA=0x09CE40A8  token=0x600001A  System.Void AddSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset)
  RVA=0x09CE3FBC  token=0x600001B  System.Void AddFontMaterial(System.Int32 hashCode, UnityEngine.Material material)
  RVA=0x09CE3F58  token=0x600001C  System.Void AddFontMaterialInternal(System.Int32 hashCode, UnityEngine.Material material)
  RVA=0x09CE3E3C  token=0x600001D  System.Void AddColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset)
  RVA=0x09CE3DB0  token=0x600001E  System.Void AddColorGradientPreset_Internal(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset)
  RVA=0x09CE41D4  token=0x600001F  System.Boolean Contains(TMPro.TMP_FontAsset font)
  RVA=0x09CE4230  token=0x6000020  System.Boolean Contains(TMPro.TMP_SpriteAsset sprite)
  RVA=0x09CE43A8  token=0x6000021  System.Boolean TryGetFontAsset(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset)
  RVA=0x09CE4338  token=0x6000022  System.Boolean TryGetFontAssetInternal(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset)
  RVA=0x09CE4500  token=0x6000023  System.Boolean TryGetSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset)
  RVA=0x09CE4490  token=0x6000024  System.Boolean TryGetSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset)
  RVA=0x09CE42FC  token=0x6000025  System.Boolean TryGetColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset)
  RVA=0x09CE428C  token=0x6000026  System.Boolean TryGetColorGradientPresetInternal(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset)
  RVA=0x09CE4454  token=0x6000027  System.Boolean TryGetMaterial(System.Int32 hashCode, UnityEngine.Material& material)
  RVA=0x09CE43E4  token=0x6000028  System.Boolean TryGetMaterialInternal(System.Int32 hashCode, UnityEngine.Material& material)
  RVA=0x09CE453C  token=0x6000029  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_MaterialReference
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x20
FIELDS:
  public            UnityEngine.Material            material  // 0x10
  public            System.Int32                    referenceCount  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.MaterialReference
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x48
FIELDS:
  public            System.Int32                    index  // 0x10
  public            TMPro.TMP_FontAsset             fontAsset  // 0x18
  public            TMPro.TMP_SpriteAsset           spriteAsset  // 0x20
  public            UnityEngine.Material            material  // 0x28
  public            System.Boolean                  isDefaultMaterial  // 0x30
  public            System.Boolean                  isFallbackMaterial  // 0x31
  public            UnityEngine.Material            fallbackMaterial  // 0x38
  public            System.Single                   padding  // 0x40
  public            System.Int32                    referenceCount  // 0x44
METHODS:
  RVA=0x02F5C690  token=0x600002A  System.Void .ctor(System.Int32 index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, System.Single padding)
  RVA=0x09CE4910  token=0x600002B  System.Boolean Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset)
  RVA=0x02948900  token=0x600002C  System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
  RVA=0x09CE4724  token=0x600002D  System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
END_CLASS

CLASS: TMPro.TextContainerAnchors
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextContainerAnchors      TopLeft  // const
  public    static  TMPro.TextContainerAnchors      Top  // const
  public    static  TMPro.TextContainerAnchors      TopRight  // const
  public    static  TMPro.TextContainerAnchors      Left  // const
  public    static  TMPro.TextContainerAnchors      Middle  // const
  public    static  TMPro.TextContainerAnchors      Right  // const
  public    static  TMPro.TextContainerAnchors      BottomLeft  // const
  public    static  TMPro.TextContainerAnchors      Bottom  // const
  public    static  TMPro.TextContainerAnchors      BottomRight  // const
  public    static  TMPro.TextContainerAnchors      Custom  // const
METHODS:
END_CLASS

CLASS: TMPro.TextContainer
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x70
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           System.Boolean                  m_hasChanged  // 0x18
  private           UnityEngine.Vector2             m_pivot  // 0x1c
  private           TMPro.TextContainerAnchors      m_anchorPosition  // 0x24
  private           UnityEngine.Rect                m_rect  // 0x28
  private           System.Boolean                  m_isDefaultWidth  // 0x38
  private           System.Boolean                  m_isDefaultHeight  // 0x39
  private           System.Boolean                  m_isAutoFitting  // 0x3a
  private           UnityEngine.Vector3[]           m_corners  // 0x40
  private           UnityEngine.Vector3[]           m_worldCorners  // 0x48
  private           UnityEngine.Vector4             m_margins  // 0x50
  private           UnityEngine.RectTransform       m_rectTransform  // 0x60
  private   static  UnityEngine.Vector2             k_defaultSize  // static @ 0x0
  private           TMPro.TextMeshPro               m_textMeshPro  // 0x68
PROPERTIES:
  hasChanged  get=0x01002A50  set=0x01002B40
  pivot  get=0x03D84B60  set=0x09CE530C
  anchorPosition  get=0x03D4E2E0  set=0x09CE522C
  rect  get=0x03D59E20  set=0x09CE537C
  size  get=0x03D84B80  set=0x09CE53D4
  width  get=0x03D84BA0  set=0x09CE5434
  height  get=0x042743D0  set=0x09CE5274
  isDefaultWidth  get=0x03D4F190
  isDefaultHeight  get=0x03D4F300
  isAutoFitting  get=0x03D4F500  set=0x03D4F530
  corners  get=0x03D4E2B0
  worldCorners  get=0x03D4EA70
  margins  get=0x03D55950  set=0x09CE52BC
  rectTransform  get=0x09CE5124
  textMeshPro  get=0x09CE51A8
METHODS:
  RVA=0x09CE49D8  token=0x6000046  System.Void Awake()
  RVA=0x09CE4D4C  token=0x6000047  System.Void OnEnable()
  RVA=0x0350B670  token=0x6000048  System.Void OnDisable()
  RVA=0x09CE4C50  token=0x6000049  System.Void OnContainerChanged()
  RVA=0x09CE4D54  token=0x600004A  System.Void OnRectTransformDimensionsChange()
  RVA=0x03D84B10  token=0x600004B  System.Void SetRect(UnityEngine.Vector2 size)
  RVA=0x09CE4EAC  token=0x600004C  System.Void UpdateCorners()
  RVA=0x09CE4BC4  token=0x600004D  UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor)
  RVA=0x09CE4A78  token=0x600004E  TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot)
  RVA=0x09CE50AC  token=0x600004F  System.Void .ctor()
  RVA=0x09CE506C  token=0x6000050  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextMeshPro
TYPE:  class
TOKEN: 0x200000D
SIZE:  0xB98
EXTENDS: TMPro.TMP_Text
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  private           System.Int32                    _SortingLayer  // 0xaf8
  private           System.Int32                    _SortingLayerID  // 0xafc
  private           System.Int32                    _SortingOrder  // 0xb00
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xb08
  private           System.Boolean                  m_currentAutoSizeMode  // 0xb10
  private           System.Boolean                  m_hasFontAssetChanged  // 0xb11
  private           System.Single                   m_previousLossyScaleY  // 0xb14
  private           UnityEngine.Renderer            m_renderer  // 0xb18
  private           UnityEngine.MeshFilter          m_meshFilter  // 0xb20
  private           System.Boolean                  m_isFirstAllocation  // 0xb28
  private           System.Int32                    m_max_characters  // 0xb2c
  private           System.Int32                    m_max_numberOfLines  // 0xb30
  private           TMPro.TMP_SubMesh[]             m_subTextObjects  // 0xb38
  private           TMPro.MaskingTypes              m_maskType  // 0xb40
  private           UnityEngine.Matrix4x4           m_EnvMapMatrix  // 0xb44
  private           UnityEngine.Vector3[]           m_RectTransformCorners  // 0xb88
  private           System.Boolean                  m_isRegisteredForEvents  // 0xb90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextMarker  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_SetArraySizesMarker  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIMarker  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_ParseMarkupTextMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_CharacterLookupMarker  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_HandleGPOSFeaturesMarker  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_CalculateVerticesPositionMarker  // static @ 0x30
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeTextMetricsMarker  // static @ 0x38
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVisibleCharacterMarker  // static @ 0x40
  private   static  Unity.Profiling.ProfilerMarker  k_HandleWhiteSpacesMarker  // static @ 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_HandleHorizontalLineBreakingMarker  // static @ 0x50
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVerticalLineBreakingMarker  // static @ 0x58
  private   static  Unity.Profiling.ProfilerMarker  k_SaveGlyphVertexDataMarker  // static @ 0x60
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeCharacterAdvanceMarker  // static @ 0x68
  private   static  Unity.Profiling.ProfilerMarker  k_HandleCarriageReturnMarker  // static @ 0x70
  private   static  Unity.Profiling.ProfilerMarker  k_HandleLineTerminationMarker  // static @ 0x78
  private   static  Unity.Profiling.ProfilerMarker  k_SavePageInfoMarker  // static @ 0x80
  private   static  Unity.Profiling.ProfilerMarker  k_SaveProcessingStatesMarker  // static @ 0x88
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIMarker  // static @ 0x90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIIMarker  // static @ 0x98
PROPERTIES:
  sortingLayerID  get=0x09CEE3F0  set=0x09CEE688
  sortingOrder  get=0x09CEE46C  set=0x09CEE724
  autoSizeTextContainer  get=0x03D84BB0  set=0x09CEE608
  textContainer  get=0x01002730
  transform  get=0x09CEE4E8
  renderer  get=0x09CEE360
  mesh  get=0x09CEE2A4
  meshFilter  get=0x09CEE194
  maskType  get=0x03D84BE0  set=0x09CEE678
EVENTS:
  OnPreRenderText  add=add_OnPreRenderText  remove=remove_OnPreRenderText
METHODS:
  RVA=0x09CEC2D0  token=0x600005E  System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords)
  RVA=0x09CEC494  token=0x600005F  System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, System.Single softnessX, System.Single softnessY)
  RVA=0x09CECF34  token=0x6000060  System.Void SetVerticesDirty()
  RVA=0x09CEC0A4  token=0x6000061  System.Void SetLayoutDirty()
  RVA=0x09381C74  token=0x6000062  System.Void SetMaterialDirty()
  RVA=0x03219AC0  token=0x6000063  System.Void SetAllDirty()
  RVA=0x09CE980C  token=0x6000064  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x09CED27C  token=0x6000065  System.Void UpdateMaterial()
  RVA=0x09CED39C  token=0x6000066  System.Void UpdateMeshPadding()
  RVA=0x09CE82A8  token=0x6000067  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  RVA=0x09CE8AE4  token=0x6000068  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  RVA=0x09CE7CA8  token=0x6000069  System.Void ClearMesh(System.Boolean updateMesh)
  RVA=0x09CED1EC  token=0x600006C  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  RVA=0x09CED838  token=0x600006D  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  RVA=0x09CED9FC  token=0x600006E  System.Void UpdateVertexData()
  RVA=0x09CE6DC4  token=0x600006F  System.Void UpdateFontAsset()
  RVA=0x0350B670  token=0x6000070  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x6000071  System.Void CalculateLayoutInputVertical()
  RVA=0x09CE7880  token=0x6000072  System.Void Awake()
  RVA=0x09CE9358  token=0x6000073  System.Void OnEnable()
  RVA=0x09CE92C8  token=0x6000074  System.Void OnDisable()
  RVA=0x09CE9204  token=0x6000075  System.Void OnDestroy()
  RVA=0x09CE8BF4  token=0x6000076  System.Void LoadFontAsset()
  RVA=0x09CECFB0  token=0x6000077  System.Void UpdateEnvMapMatrix()
  RVA=0x09CEC30C  token=0x6000078  System.Void SetMask(TMPro.MaskingTypes maskType)
  RVA=0x09CEC24C  token=0x6000079  System.Void SetMaskCoordinates(UnityEngine.Vector4 coords)
  RVA=0x09CEC14C  token=0x600007A  System.Void SetMaskCoordinates(UnityEngine.Vector4 coords, System.Single softX, System.Single softY)
  RVA=0x09CE818C  token=0x600007B  System.Void EnableMasking()
  RVA=0x09CE8070  token=0x600007C  System.Void DisableMasking()
  RVA=0x09CED210  token=0x600007D  System.Void UpdateMask()
  RVA=0x09CE866C  token=0x600007E  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  RVA=0x09CE8778  token=0x600007F  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  RVA=0x09CE6704  token=0x6000080  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x09CE88F4  token=0x6000081  UnityEngine.Material[] GetSharedMaterials()
  RVA=0x09CECBB8  token=0x6000082  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  RVA=0x09CEC828  token=0x6000083  System.Void SetOutlineThickness(System.Single thickness)
  RVA=0x09CEBF5C  token=0x6000084  System.Void SetFaceColor(UnityEngine.Color32 color)
  RVA=0x09CEC6E0  token=0x6000085  System.Void SetOutlineColor(UnityEngine.Color32 color)
  RVA=0x09CE7ED8  token=0x6000086  System.Void CreateMaterialInstance()
  RVA=0x09CECA38  token=0x6000087  System.Void SetShaderDepth()
  RVA=0x09CEBC08  token=0x6000088  System.Void SetCulling()
  RVA=0x09CEC998  token=0x6000089  System.Void SetPerspectiveCorrection()
  RVA=0x09CE9AE0  token=0x600008A  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  RVA=0x09CE7D90  token=0x600008B  System.Void ComputeMarginSize()
  RVA=0x09CE92AC  token=0x600008C  System.Void OnDidApplyAnimationProperties()
  RVA=0x09CE97E4  token=0x600008D  System.Void OnTransformParentChanged()
  RVA=0x09CE9664  token=0x600008E  System.Void OnRectTransformDimensionsChange()
  RVA=0x09CE8B3C  token=0x600008F  System.Void InternalUpdate()
  RVA=0x09CE9420  token=0x6000090  System.Void OnPreRenderObject()
  RVA=0x09CD827C  token=0x6000091  System.Void GenerateTextMesh()
  RVA=0x09CE8A44  token=0x6000092  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  RVA=0x09CEC4F0  token=0x6000093  System.Void SetMeshFilters(System.Boolean state)
  RVA=0x09CE98D0  token=0x6000094  System.Void SetActiveSubMeshes(System.Boolean state)
  RVA=0x09CE99CC  token=0x6000095  System.Void SetActiveSubTextObjectRenderers(System.Boolean state)
  RVA=0x09CE7FB0  token=0x6000096  System.Void DestroySubMeshObjects()
  RVA=0x09CED638  token=0x6000097  System.Void UpdateSubMeshSortingLayerID(System.Int32 id)
  RVA=0x09CED738  token=0x6000098  System.Void UpdateSubMeshSortingOrder(System.Int32 order)
  RVA=0x09CE82BC  token=0x6000099  UnityEngine.Bounds GetCompoundBounds()
  RVA=0x09CED4A4  token=0x600009A  System.Void UpdateSDFScale(System.Single scaleDelta)
  RVA=0x09CEE048  token=0x600009B  System.Void .ctor()
  RVA=0x09CEDBCC  token=0x600009C  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextMeshProUGUI
TYPE:  class
TOKEN: 0x200000E
SIZE:  0xBC8
EXTENDS: TMPro.TMP_Text
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  private           System.Boolean                  m_isRebuildingLayout  // 0xaf8
  private           UnityEngine.Coroutine           m_DelayedGraphicRebuild  // 0xb00
  private           UnityEngine.Coroutine           m_DelayedMaterialRebuild  // 0xb08
  private           UnityEngine.Rect                m_ClipRect  // 0xb10
  private           System.Boolean                  m_ValidRect  // 0xb20
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xb28
  private           System.Boolean                  m_hasFontAssetChanged  // 0xb30
  protected         TMPro.TMP_SubMeshUI[]           m_subTextObjects  // 0xb38
  protected         UnityEngine.Vector3[]           m_RectTransformCorners  // 0xb40
  protected         UnityEngine.CanvasRenderer      m_canvasRenderer  // 0xb48
  protected         UnityEngine.Canvas              m_canvas  // 0xb50
  protected         System.Single                   m_CanvasScaleFactor  // 0xb58
  protected         System.Single                   m_previousLossyScaleY  // 0xb5c
  private           System.Boolean                  m_isFirstAllocation  // 0xb60
  private           System.Int32                    m_max_characters  // 0xb64
  private           UnityEngine.Material            m_baseMaterial  // 0xb68
  private           System.Boolean                  m_isScrollRegionSet  // 0xb70
  private           UnityEngine.Vector4             m_maskOffset  // 0xb74
  private           UnityEngine.Matrix4x4           m_EnvMapMatrix  // 0xb84
  private           System.Boolean                  m_isRegisteredForEvents  // 0xbc4
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextMarker  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_SetArraySizesMarker  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIMarker  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_ParseMarkupTextMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_CharacterLookupMarker  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_HandleGPOSFeaturesMarker  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_CalculateVerticesPositionMarker  // static @ 0x30
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeTextMetricsMarker  // static @ 0x38
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVisibleCharacterMarker  // static @ 0x40
  private   static  Unity.Profiling.ProfilerMarker  k_HandleWhiteSpacesMarker  // static @ 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_HandleHorizontalLineBreakingMarker  // static @ 0x50
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVerticalLineBreakingMarker  // static @ 0x58
  private   static  Unity.Profiling.ProfilerMarker  k_SaveGlyphVertexDataMarker  // static @ 0x60
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeCharacterAdvanceMarker  // static @ 0x68
  private   static  Unity.Profiling.ProfilerMarker  k_HandleCarriageReturnMarker  // static @ 0x70
  private   static  Unity.Profiling.ProfilerMarker  k_HandleLineTerminationMarker  // static @ 0x78
  private   static  Unity.Profiling.ProfilerMarker  k_SavePageInfoMarker  // static @ 0x80
  private   static  Unity.Profiling.ProfilerMarker  k_SaveProcessingStatesMarker  // static @ 0x88
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIMarker  // static @ 0x90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIIMarker  // static @ 0x98
PROPERTIES:
  materialForRendering  get=0x0303D6D0
  autoSizeTextContainer  get=0x03D84BB0  set=0x09CE77E8
  mesh  get=0x03D84BD0
  canvasRenderer  get=0x03069D40
  maskOffset  get=0x03D84BC0  set=0x09CE7858
EVENTS:
  OnPreRenderText  add=add_OnPreRenderText  remove=remove_OnPreRenderText
METHODS:
  RVA=0x0350B670  token=0x60000A2  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x60000A3  System.Void CalculateLayoutInputVertical()
  RVA=0x0239E1A0  token=0x60000A4  System.Void SetVerticesDirty()
  RVA=0x024A58A0  token=0x60000A5  System.Void SetLayoutDirty()
  RVA=0x0239B220  token=0x60000A6  System.Void SetMaterialDirty()
  RVA=0x03219AC0  token=0x60000A7  System.Void SetAllDirty()
  RVA=0x09CE54C0  token=0x60000A8  System.Collections.IEnumerator DelayedGraphicRebuild()
  RVA=0x09CE551C  token=0x60000A9  System.Collections.IEnumerator DelayedMaterialRebuild()
  RVA=0x0296B1E0  token=0x60000AA  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x024A4AE0  token=0x60000AB  System.Void UpdateSubObjectPivot()
  RVA=0x025172C0  token=0x60000AC  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  RVA=0x03069B00  token=0x60000AD  System.Void UpdateMaterial()
  RVA=0x02515D70  token=0x60000B0  System.Void RecalculateClipping()
  RVA=0x02342750  token=0x60000B1  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=0x02C6F270  token=0x60000B2  System.Void UpdateCulling()
  RVA=0x09CE72A0  token=0x60000B3  System.Void UpdateMeshPadding()
  RVA=0x039DE190  token=0x60000B4  System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  RVA=0x09CE5D0C  token=0x60000B5  System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x02969C30  token=0x60000B6  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  RVA=0x09CE5C40  token=0x60000B7  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  RVA=0x03536010  token=0x60000B8  System.Void ClearMesh()
  RVA=0x09CE6DD4  token=0x60000BB  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  RVA=0x09CE73A8  token=0x60000BC  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  RVA=0x09CE75C0  token=0x60000BD  System.Void UpdateVertexData()
  RVA=0x09CE6DC4  token=0x60000BE  System.Void UpdateFontAsset()
  RVA=0x02813FB0  token=0x60000BF  System.Void Awake()
  RVA=0x0239F800  token=0x60000C0  System.Void OnEnable()
  RVA=0x0239E310  token=0x60000C1  System.Void OnDisable()
  RVA=0x0285F3B0  token=0x60000C2  System.Void OnDestroy()
  RVA=0x0296C170  token=0x60000C3  System.Void LoadFontAsset()
  RVA=0x0239F9A0  token=0x60000C4  UnityEngine.Canvas GetCanvas()
  RVA=0x09CE6B88  token=0x60000C5  System.Void UpdateEnvMapMatrix()
  RVA=0x09CE5638  token=0x60000C6  System.Void EnableMasking()
  RVA=0x0350B670  token=0x60000C7  System.Void DisableMasking()
  RVA=0x09CE6E60  token=0x60000C8  System.Void UpdateMask()
  RVA=0x09CE583C  token=0x60000C9  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  RVA=0x09CE596C  token=0x60000CA  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  RVA=0x09CE6704  token=0x60000CB  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x09CE5AEC  token=0x60000CC  UnityEngine.Material[] GetSharedMaterials()
  RVA=0x09CE6744  token=0x60000CD  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  RVA=0x09CE6368  token=0x60000CE  System.Void SetOutlineThickness(System.Single thickness)
  RVA=0x09CE607C  token=0x60000CF  System.Void SetFaceColor(UnityEngine.Color32 color)
  RVA=0x09CE624C  token=0x60000D0  System.Void SetOutlineColor(UnityEngine.Color32 color)
  RVA=0x09CE65E0  token=0x60000D1  System.Void SetShaderDepth()
  RVA=0x09CE5DB8  token=0x60000D2  System.Void SetCulling()
  RVA=0x09CE6540  token=0x60000D3  System.Void SetPerspectiveCorrection()
  RVA=0x09CE6198  token=0x60000D4  System.Void SetMeshArrays(System.Int32 size)
  RVA=0x02572210  token=0x60000D5  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  RVA=0x024A5690  token=0x60000D6  System.Void ComputeMarginSize()
  RVA=0x034D36F0  token=0x60000D7  System.Void OnDidApplyAnimationProperties()
  RVA=0x025A1A60  token=0x60000D8  System.Void OnCanvasHierarchyChanged()
  RVA=0x03163500  token=0x60000D9  System.Void OnTransformParentChanged()
  RVA=0x024A4840  token=0x60000DA  System.Void OnRectTransformDimensionsChange()
  RVA=0x023432D0  token=0x60000DB  System.Void InternalUpdate()
  RVA=0x0296B310  token=0x60000DC  System.Void OnPreRenderCanvas()
  RVA=0x09CE547C  token=0x60000DD  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  RVA=0x02575510  token=0x60000DE  System.Void GenerateTextMesh()
  RVA=0x030D8960  token=0x60000DF  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  RVA=0x030924F0  token=0x60000E0  System.Void SetActiveSubMeshes(System.Boolean state)
  RVA=0x09CE5578  token=0x60000E1  System.Void DestroySubMeshObjects()
  RVA=0x023F1700  token=0x60000E2  UnityEngine.Bounds GetCompoundBounds()
  RVA=0x023433D0  token=0x60000E3  UnityEngine.Rect GetCanvasSpaceClippingRect()
  RVA=0x0285D480  token=0x60000E4  System.Void UpdateSDFScale(System.Single scaleDelta)
  RVA=0x02845660  token=0x60000E5  System.Void .ctor()
  RVA=0x03822750  token=0x60000E6  System.Void .cctor()
END_CLASS

CLASS: TMPro.ThaiTextPreprocessor
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x10
IMPLEMENTS: TMPro.ITextPreprocessor
FIELDS:
  private   static  TMPro.ThaiTextPreprocessor      _instance  // static @ 0x0
PROPERTIES:
  Instance  get=0x09CEE7C0
METHODS:
  RVA=0x02815E90  token=0x60000F3  System.String PreprocessText(System.String text)
  RVA=0x0350B670  token=0x60000F5  System.Void .ctor()
  RVA=0x03D1ABD0  token=0x60000F6  System.Void .cctor()
END_CLASS

CLASS: TMPro.Compute_DistanceTransform_EventTypes
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.Compute_DistanceTransform_EventTypesProcessing  // const
  public    static  TMPro.Compute_DistanceTransform_EventTypesCompleted  // const
METHODS:
END_CLASS

CLASS: TMPro.TMPro_EventManager
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
  public    static readonly TMPro.FastAction<System.Object,TMPro.Compute_DT_EventArgs>COMPUTE_DT_EVENT  // static @ 0x0
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Material>MATERIAL_PROPERTY_EVENT  // static @ 0x8
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>FONT_PROPERTY_EVENT  // static @ 0x10
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>SPRITE_ASSET_PROPERTY_EVENT  // static @ 0x18
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>TEXTMESHPRO_PROPERTY_EVENT  // static @ 0x20
  public    static readonly TMPro.FastAction<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>DRAG_AND_DROP_MATERIAL_EVENT  // static @ 0x28
  public    static readonly TMPro.FastAction<System.Boolean>TEXT_STYLE_PROPERTY_EVENT  // static @ 0x30
  public    static readonly TMPro.FastAction<UnityEngine.Object>COLOR_GRADIENT_PROPERTY_EVENT  // static @ 0x38
  public    static readonly TMPro.FastAction                TMP_SETTINGS_PROPERTY_EVENT  // static @ 0x40
  public    static readonly TMPro.FastAction                RESOURCE_LOAD_EVENT  // static @ 0x48
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>TEXTMESHPRO_UGUI_PROPERTY_EVENT  // static @ 0x50
  public    static readonly TMPro.FastAction<UnityEngine.Object>TEXT_CHANGED_EVENT  // static @ 0x58
METHODS:
  RVA=0x09CFB6E0  token=0x60000F7  System.Void ON_MATERIAL_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Material mat)
  RVA=0x09CFB660  token=0x60000F8  System.Void ON_FONT_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  RVA=0x09CFB7B4  token=0x60000F9  System.Void ON_SPRITE_ASSET_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  RVA=0x09CFB834  token=0x60000FA  System.Void ON_TEXTMESHPRO_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  RVA=0x09CFB5CC  token=0x60000FB  System.Void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial)
  RVA=0x09CFB934  token=0x60000FC  System.Void ON_TEXT_STYLE_PROPERTY_CHANGED(System.Boolean isChanged)
  RVA=0x09CFB4E0  token=0x60000FD  System.Void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj)
  RVA=0x031DD5F0  token=0x60000FE  System.Void ON_TEXT_CHANGED(UnityEngine.Object obj)
  RVA=0x09CFB9A0  token=0x60000FF  System.Void ON_TMP_SETTINGS_CHANGED()
  RVA=0x09CFB760  token=0x6000100  System.Void ON_RESOURCES_LOADED()
  RVA=0x09CFB8B4  token=0x6000101  System.Void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  RVA=0x09CFB550  token=0x6000102  System.Void ON_COMPUTE_DT_EVENT(System.Object Sender, TMPro.Compute_DT_EventArgs e)
  RVA=0x037F5860  token=0x6000103  System.Void .cctor()
END_CLASS

CLASS: TMPro.Compute_DT_EventArgs
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x20
FIELDS:
  public            TMPro.Compute_DistanceTransform_EventTypesEventType  // 0x10
  public            System.Single                   ProgressPercentage  // 0x14
  public            UnityEngine.Color[]             Colors  // 0x18
METHODS:
  RVA=0x03D84BF0  token=0x6000104  System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, System.Single progress)
  RVA=0x04270E40  token=0x6000105  System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors)
END_CLASS

CLASS: TMPro.TMPro_ExtensionMethods
TYPE:  static class
TOKEN: 0x2000015
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09CFBFA4  token=0x6000106  System.Int32[] ToIntArray(System.String text)
  RVA=0x09CFB9F4  token=0x6000107  System.String ArrayToString(System.Char[] chars)
  RVA=0x09CFBC68  token=0x6000108  System.String IntToString(System.Int32[] unicodes)
  RVA=0x09CFC034  token=0x6000109  System.String UintToString(System.Collections.Generic.List<System.UInt32> unicodes)
  RVA=0x09CFBCE8  token=0x600010A  System.String IntToString(System.Int32[] unicodes, System.Int32 start, System.Int32 length)
  RVA=-1  // generic def  token=0x600010B  System.Int32 FindInstanceID(System.Collections.Generic.List<T> list, T target)
  RVA=0x09CFBADC  token=0x600010C  System.Boolean Compare(UnityEngine.Color32 a, UnityEngine.Color32 b)
  RVA=0x09CFBAB8  token=0x600010D  System.Boolean CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b)
  RVA=0x022CDA10  token=0x600010E  System.Boolean Compare(UnityEngine.Color a, UnityEngine.Color b)
  RVA=0x02799940  token=0x600010F  System.Boolean CompareRGB(UnityEngine.Color a, UnityEngine.Color b)
  RVA=0x09CFBDE4  token=0x6000110  UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2)
  RVA=0x09CFBDE4  token=0x6000111  UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2)
  RVA=0x09CFBEC4  token=0x6000112  UnityEngine.Color32 Tint(UnityEngine.Color32 c1, System.Single tint)
  RVA=0x09CFBDBC  token=0x6000113  UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2)
  RVA=0x09CFBBD8  token=0x6000114  System.Boolean Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Int32 accuracy)
  RVA=0x09CFBB14  token=0x6000115  System.Boolean Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, System.Int32 accuracy)
END_CLASS

CLASS: TMPro.TMP_Math
TYPE:  static class
TOKEN: 0x2000016
SIZE:  0x10
FIELDS:
  public    static  System.Single                   FLOAT_MAX  // const
  public    static  System.Single                   FLOAT_MIN  // const
  public    static  System.Int32                    INT_MAX  // const
  public    static  System.Int32                    INT_MIN  // const
  public    static  System.Single                   FLOAT_UNSET  // const
  public    static  System.Int32                    INT_UNSET  // const
  public    static  UnityEngine.Vector2             MAX_16BIT  // static @ 0x0
  public    static  UnityEngine.Vector2             MIN_16BIT  // static @ 0x8
METHODS:
  RVA=0x09CFB110  token=0x6000116  System.Boolean Approximately(System.Single a, System.Single b)
  RVA=0x09CFB134  token=0x6000117  System.Int32 Mod(System.Int32 a, System.Int32 b)
  RVA=0x09CFB14C  token=0x6000118  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_VertexDataUpdateFlags
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_VertexDataUpdateFlags None  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags Vertices  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv0  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv2  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv4  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags Colors32  // const
  public    static  TMPro.TMP_VertexDataUpdateFlags All  // const
METHODS:
END_CLASS

CLASS: TMPro.VertexGradient
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x50
FIELDS:
  public            UnityEngine.Color               topLeft  // 0x10
  public            UnityEngine.Color               topRight  // 0x20
  public            UnityEngine.Color               bottomLeft  // 0x30
  public            UnityEngine.Color               bottomRight  // 0x40
METHODS:
  RVA=0x03D84DC0  token=0x6000119  System.Void .ctor(UnityEngine.Color color)
  RVA=0x03D7E4A0  token=0x600011A  System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)
END_CLASS

CLASS: TMPro.TMP_PageInfo
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x24
FIELDS:
  public            System.Int32                    firstCharacterIndex  // 0x10
  public            System.Int32                    lastCharacterIndex  // 0x14
  public            System.Single                   ascender  // 0x18
  public            System.Single                   baseLine  // 0x1c
  public            System.Single                   descender  // 0x20
METHODS:
END_CLASS

CLASS: TMPro.TMP_LinkInfo
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x38
FIELDS:
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    hashCode  // 0x18
  public            System.Int32                    linkIdFirstCharacterIndex  // 0x1c
  public            System.Int32                    linkIdLength  // 0x20
  public            System.Int32                    linkTextfirstCharacterIndex  // 0x24
  public            System.Int32                    linkTextLength  // 0x28
  private           System.Char[]                   linkID  // 0x30
METHODS:
  RVA=0x09CFB04C  token=0x600011B  System.Void SetLinkID(System.Char[] text, System.Int32 startIndex, System.Int32 length)
  RVA=0x09CFAF6C  token=0x600011C  System.String GetLinkText()
  RVA=0x09CFAEE0  token=0x600011D  System.String GetLinkID()
END_CLASS

CLASS: TMPro.TMP_WordInfo
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x28
FIELDS:
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    firstCharacterIndex  // 0x18
  public            System.Int32                    lastCharacterIndex  // 0x1c
  public            System.Int32                    characterCount  // 0x20
METHODS:
  RVA=0x09CFB3FC  token=0x600011E  System.String GetWord()
END_CLASS

CLASS: TMPro.TMP_SpriteInfo
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x1C
FIELDS:
  public            System.Int32                    spriteIndex  // 0x10
  public            System.Int32                    characterIndex  // 0x14
  public            System.Int32                    vertexIndex  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.Extents
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x20
FIELDS:
  private   static  TMPro.Extents                   zero  // static @ 0x0
  private   static  TMPro.Extents                   uninitialized  // static @ 0x10
  public            UnityEngine.Vector2             min  // 0x10
  public            UnityEngine.Vector2             max  // 0x18
METHODS:
  RVA=0x03D4EA10  token=0x600011F  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  RVA=0x09CEED24  token=0x6000120  System.String ToString()
  RVA=0x09CEEEA8  token=0x6000121  System.Void .cctor()
END_CLASS

CLASS: TMPro.Mesh_Extents
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2             min  // 0x10
  public            UnityEngine.Vector2             max  // 0x18
METHODS:
  RVA=0x03D4EA10  token=0x6000122  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  RVA=0x09CEFAE0  token=0x6000123  System.String ToString()
END_CLASS

CLASS: TMPro.WordWrapState
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x3A8
FIELDS:
  public            System.Int32                    previous_WordBreak  // 0x10
  public            System.Int32                    total_CharacterCount  // 0x14
  public            System.Int32                    visible_CharacterCount  // 0x18
  public            System.Int32                    visible_SpriteCount  // 0x1c
  public            System.Int32                    visible_LinkCount  // 0x20
  public            System.Int32                    firstCharacterIndex  // 0x24
  public            System.Int32                    firstVisibleCharacterIndex  // 0x28
  public            System.Int32                    lastCharacterIndex  // 0x2c
  public            System.Int32                    lastVisibleCharIndex  // 0x30
  public            System.Int32                    lineNumber  // 0x34
  public            System.Single                   maxCapHeight  // 0x38
  public            System.Single                   maxAscender  // 0x3c
  public            System.Single                   maxLineAscenderWithOutImage  // 0x40
  public            System.Single                   maxDescender  // 0x44
  public            System.Single                   startOfLineAscender  // 0x48
  public            System.Single                   maxLineAscender  // 0x4c
  public            System.Single                   maxLineDescender  // 0x50
  public            System.Single                   pageAscender  // 0x54
  public            TMPro.HorizontalAlignmentOptionshorizontalAlignment  // 0x58
  public            System.Single                   marginLeft  // 0x5c
  public            System.Single                   marginRight  // 0x60
  public            System.Single                   xAdvance  // 0x64
  public            System.Single                   preferredWidth  // 0x68
  public            System.Single                   preferredHeight  // 0x6c
  public            System.Single                   previousLineScale  // 0x70
  public            System.Int32                    wordCount  // 0x74
  public            TMPro.FontStyles                fontStyle  // 0x78
  public            System.Int32                    italicAngle  // 0x7c
  public            System.Single                   fontScaleMultiplier  // 0x80
  public            System.Single                   currentFontSize  // 0x84
  public            System.Single                   baselineOffset  // 0x88
  public            System.Single                   lineOffset  // 0x8c
  public            System.Boolean                  isDrivenLineSpacing  // 0x90
  public            System.Single                   glyphHorizontalAdvanceAdjustment  // 0x94
  public            System.Single                   cSpace  // 0x98
  public            System.Single                   mSpace  // 0x9c
  public            TMPro.TMP_TextInfo              textInfo  // 0xa0
  public            TMPro.TMP_LineInfo              lineInfo  // 0xa8
  public            UnityEngine.Color32             vertexColor  // 0x104
  public            UnityEngine.Color32             underlineColor  // 0x108
  public            UnityEngine.Color32             strikethroughColor  // 0x10c
  public            UnityEngine.Color32             highlightColor  // 0x110
  public            TMPro.TMP_FontStyleStack        basicStyleStack  // 0x114
  public            TMPro.TMP_TextProcessingStack<System.Int32>italicAngleStack  // 0x120
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>colorStack  // 0x140
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>underlineColorStack  // 0x160
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>strikethroughColorStack  // 0x180
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>highlightColorStack  // 0x1a0
  public            TMPro.TMP_TextProcessingStack<TMPro.HighlightState>highlightStateStack  // 0x1c0
  public            TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient>colorGradientStack  // 0x1f0
  public            TMPro.TMP_TextProcessingStack<System.Single>sizeStack  // 0x218
  public            TMPro.TMP_TextProcessingStack<System.Single>indentStack  // 0x238
  public            TMPro.TMP_TextProcessingStack<TMPro.FontWeight>fontWeightStack  // 0x258
  public            TMPro.TMP_TextProcessingStack<System.Int32>styleStack  // 0x278
  public            TMPro.TMP_TextProcessingStack<System.Single>baselineStack  // 0x298
  public            TMPro.TMP_TextProcessingStack<System.Int32>actionStack  // 0x2b8
  public            TMPro.TMP_TextProcessingStack<TMPro.MaterialReference>materialReferenceStack  // 0x2d8
  public            TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions>lineJustificationStack  // 0x330
  public            TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData>phoneticQueue  // 0x350
  public            System.Int32                    spriteAnimationID  // 0x370
  public            TMPro.TMP_FontAsset             currentFontAsset  // 0x378
  public            TMPro.TMP_SpriteAsset           currentSpriteAsset  // 0x380
  public            UnityEngine.Material            currentMaterial  // 0x388
  public            System.Int32                    currentMaterialIndex  // 0x390
  public            TMPro.Extents                   meshExtents  // 0x394
  public            System.Boolean                  tagNoParsing  // 0x3a4
  public            System.Boolean                  isNonBreakingSpace  // 0x3a5
METHODS:
END_CLASS

CLASS: TMPro.TagAttribute
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x1C
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    length  // 0x14
  public            System.Int32                    hashCode  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.RichTextTagAttribute
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x28
FIELDS:
  public            System.Int32                    nameHashCode  // 0x10
  public            System.Int32                    valueHashCode  // 0x14
  public            TMPro.TagValueType              valueType  // 0x18
  public            System.Int32                    valueStartIndex  // 0x1c
  public            System.Int32                    valueLength  // 0x20
  public            TMPro.TagUnitType               unitType  // 0x24
METHODS:
END_CLASS

CLASS: TMPro.TMP_ArrayObjectPool`1
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Stack<T[]>>m_StackDic  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T[]>m_ActionOnGet  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T[]>m_ActionOnRelease  // 0x0
  private   readonly TMPro.TMP_ArrayObjectPool.PoolOptions<T>m_Options  // 0x0
  private           System.Int32                    m_TotalCachedCount  // 0x0
  private           System.Int32                    <countAll>k__BackingField  // 0x0
PROPERTIES:
  countAll  get=-1  // not resolved  set=-1  // not resolved
  countActive  get=-1  // not resolved
  countInactive  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000128  System.Void .ctor(UnityEngine.Events.UnityAction<T[]> actionOnGet, UnityEngine.Events.UnityAction<T[]> actionOnRelease, TMPro.TMP_ArrayObjectPool.PoolOptions<T> options)
  RVA=-1  // not resolved  token=0x6000129  T[] Get(System.Int32 count)
  RVA=-1  // not resolved  token=0x600012A  System.Void Release(System.Int32 count, T[] element)
  RVA=-1  // not resolved  token=0x600012B  System.Void Shrink()
  RVA=-1  // not resolved  token=0x600012C  System.Boolean _CanUsePool(System.Int32 count)
END_CLASS

CLASS: TMPro.TMP_ArrayPool`1
TYPE:  static class
TOKEN: 0x2000024
FIELDS:
  private   static readonly TMPro.TMP_ArrayObjectPool<T>    s_ArrayPool  // static @ 0x0
  private   static readonly TMPro.TMP_ArrayPoolWrapper<T>   s_ArrayPoolWrapper  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600012F  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000130  TMPro.TMP_ArrayObjectPool.PoolOptions<T> _CreateOptions()
  RVA=-1  // not resolved  token=0x6000131  T[] Get(System.Int32 count)
  RVA=-1  // not resolved  token=0x6000132  System.Void Release(T[] toRelease)
  RVA=-1  // not resolved  token=0x6000133  System.Void Resize(T[]& array, System.Int32 newCount)
  RVA=-1  // not resolved  token=0x6000134  System.Void Shrink()
END_CLASS

CLASS: TMPro.IPoolClearable
TYPE:  interface
TOKEN: 0x2000026
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000138  System.Void Clear()
END_CLASS

CLASS: TMPro.ITMPArrayPoolRegistryItem
TYPE:  interface
TOKEN: 0x2000027
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000139  System.Void Shrink()
END_CLASS

CLASS: TMPro.TMP_ArrayPoolRegistry
TYPE:  static class
TOKEN: 0x2000028
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.List<TMPro.ITMPArrayPoolRegistryItem>registeredPools  // static @ 0x0
METHODS:
  RVA=0x02294F90  token=0x600013A  System.Void Register(TMPro.ITMPArrayPoolRegistryItem pool)
  RVA=0x02295860  token=0x600013B  System.Void ShrinkAll()
  RVA=0x02296140  token=0x600013C  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_ArrayPoolWrapper`1
TYPE:  class
TOKEN: 0x2000029
IMPLEMENTS: TMPro.ITMPArrayPoolRegistryItem
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x600013D  System.Void Shrink()
  RVA=-1  // not resolved  token=0x600013E  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Asset
TYPE:  abstract class
TOKEN: 0x200002A
SIZE:  0x30
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           System.Int32                    m_InstanceID  // 0x18
  public            System.Int32                    hashCode  // 0x1c
  public            UnityEngine.Material            material  // 0x20
  public            System.Int32                    materialHashCode  // 0x28
PROPERTIES:
  instanceID  get=0x02573C20
METHODS:
  RVA=0x0286F540  token=0x6000140  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Character
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x30
EXTENDS: TMPro.TMP_TextElement
FIELDS:
METHODS:
  RVA=0x03D84CA0  token=0x6000141  System.Void .ctor()
  RVA=0x09CEFD1C  token=0x6000142  System.Void .ctor(System.UInt32 unicode, UnityEngine.TextCore.Glyph glyph)
  RVA=0x02EE8F00  token=0x6000143  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph)
  RVA=0x09CEFCDC  token=0x6000144  System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex)
END_CLASS

CLASS: TMPro.TMP_Vertex
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector2             uv  // 0x1c
  public            UnityEngine.Vector2             uv2  // 0x24
  public            UnityEngine.Vector2             uv4  // 0x2c
  public            UnityEngine.Color32             color  // 0x34
  private   static readonly TMPro.TMP_Vertex                k_Zero  // static @ 0x0
PROPERTIES:
  zero  get=0x09CFB39C
METHODS:
  RVA=0x0350B670  token=0x6000146  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Offset
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x20
FIELDS:
  private           System.Single                   m_Left  // 0x10
  private           System.Single                   m_Right  // 0x14
  private           System.Single                   m_Top  // 0x18
  private           System.Single                   m_Bottom  // 0x1c
  private   static readonly TMPro.TMP_Offset                k_ZeroOffset  // static @ 0x0
PROPERTIES:
  left  get=0x03D4FA00  set=0x03D58BD0
  right  get=0x03D58BC0  set=0x03D58BF0
  top  get=0x03D58BB0  set=0x03D58BE0
  bottom  get=0x03D5E120  set=0x03D5E130
  horizontal  get=0x03D4FA00  set=0x03D7F8C0
  vertical  get=0x03D58BB0  set=0x03D84DB0
  zero  get=0x09CFB2D4
METHODS:
  RVA=0x03D516B0  token=0x6000154  System.Void .ctor(System.Single left, System.Single right, System.Single top, System.Single bottom)
  RVA=0x03D84D90  token=0x6000155  System.Void .ctor(System.Single horizontal, System.Single vertical)
  RVA=0x022CDA10  token=0x6000156  System.Boolean op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs)
  RVA=0x09CFB330  token=0x6000157  System.Boolean op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs)
  RVA=0x02E260C0  token=0x6000158  TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, System.Single b)
  RVA=0x09CFB284  token=0x6000159  System.Int32 GetHashCode()
  RVA=0x09CFB224  token=0x600015A  System.Boolean Equals(System.Object obj)
  RVA=0x09CFB1A8  token=0x600015B  System.Boolean Equals(TMPro.TMP_Offset other)
  RVA=0x03D3B6A0  token=0x600015C  System.Void .cctor()
END_CLASS

CLASS: TMPro.HighlightState
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x24
FIELDS:
  public            UnityEngine.Color32             color  // 0x10
  public            TMPro.TMP_Offset                padding  // 0x14
METHODS:
  RVA=0x03D675C0  token=0x600015D  System.Void .ctor(UnityEngine.Color32 color, TMPro.TMP_Offset padding)
  RVA=0x09CEF284  token=0x600015E  System.Boolean op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs)
  RVA=0x09CEF348  token=0x600015F  System.Boolean op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs)
  RVA=0x09CEF230  token=0x6000160  System.Int32 GetHashCode()
  RVA=0x09CEF144  token=0x6000161  System.Boolean Equals(System.Object obj)
  RVA=0x09CEF1A8  token=0x6000162  System.Boolean Equals(TMPro.HighlightState other)
END_CLASS

CLASS: TMPro.TMP_CharacterInfo
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x188
IMPLEMENTS: TMPro.IPoolClearable
FIELDS:
  public            System.Char                     character  // 0x10
  public            System.Int32                    index  // 0x14
  public            System.Int32                    stringLength  // 0x18
  public            TMPro.TMP_TextElementType       elementType  // 0x1c
  public            TMPro.TMP_TextElement           textElement  // 0x20
  public            TMPro.TMP_FontAsset             fontAsset  // 0x28
  public            TMPro.TMP_SpriteAsset           spriteAsset  // 0x30
  public            System.Int32                    spriteIndex  // 0x38
  public            UnityEngine.Material            material  // 0x40
  public            System.Int32                    materialReferenceIndex  // 0x48
  public            System.Boolean                  isUsingAlternateTypeface  // 0x4c
  public            System.Single                   pointSize  // 0x50
  public            System.Int32                    lineNumber  // 0x54
  public            System.Int32                    pageNumber  // 0x58
  public            System.Int32                    vertexIndex  // 0x5c
  public            TMPro.TMP_Vertex                vertex_BL  // 0x60
  public            TMPro.TMP_Vertex                vertex_TL  // 0x88
  public            TMPro.TMP_Vertex                vertex_TR  // 0xb0
  public            TMPro.TMP_Vertex                vertex_BR  // 0xd8
  public            UnityEngine.Vector3             topLeft  // 0x100
  public            UnityEngine.Vector3             bottomLeft  // 0x10c
  public            UnityEngine.Vector3             topRight  // 0x118
  public            UnityEngine.Vector3             bottomRight  // 0x124
  public            System.Single                   origin  // 0x130
  public            System.Single                   xAdvance  // 0x134
  public            System.Single                   ascender  // 0x138
  public            System.Single                   baseLine  // 0x13c
  public            System.Single                   descender  // 0x140
  public            System.Single                   adjustedAscender  // 0x144
  public            System.Single                   adjustedDescender  // 0x148
  public            System.Single                   aspectRatio  // 0x14c
  public            System.Single                   scale  // 0x150
  public            UnityEngine.Color32             color  // 0x154
  public            UnityEngine.Color32             underlineColor  // 0x158
  public            System.Int32                    underlineVertexIndex  // 0x15c
  public            UnityEngine.Color32             strikethroughColor  // 0x160
  public            System.Int32                    strikethroughVertexIndex  // 0x164
  public            UnityEngine.Color32             highlightColor  // 0x168
  public            TMPro.HighlightState            highlightState  // 0x16c
  public            TMPro.FontStyles                style  // 0x180
  public            System.Boolean                  isVisible  // 0x184
METHODS:
  RVA=0x0285E6A0  token=0x6000163  System.Void Clear()
END_CLASS

CLASS: TMPro.ColorMode
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.ColorMode                 Single  // const
  public    static  TMPro.ColorMode                 HorizontalGradient  // const
  public    static  TMPro.ColorMode                 VerticalGradient  // const
  public    static  TMPro.ColorMode                 FourCornersGradient  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_ColorGradient
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x60
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            TMPro.ColorMode                 colorMode  // 0x18
  public            UnityEngine.Color               topLeft  // 0x1c
  public            UnityEngine.Color               topRight  // 0x2c
  public            UnityEngine.Color               bottomLeft  // 0x3c
  public            UnityEngine.Color               bottomRight  // 0x4c
  private   static  TMPro.ColorMode                 k_DefaultColorMode  // const
  private   static readonly UnityEngine.Color               k_DefaultColor  // static @ 0x0
METHODS:
  RVA=0x09CEFDAC  token=0x6000164  System.Void .ctor()
  RVA=0x09CEFE58  token=0x6000165  System.Void .ctor(UnityEngine.Color color)
  RVA=0x09CEFE9C  token=0x6000166  System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)
  RVA=0x09CEFD68  token=0x6000167  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Compatibility
TYPE:  static class
TOKEN: 0x2000032
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09CEFF0C  token=0x6000168  TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue)
END_CLASS

CLASS: TMPro.ITweenValue
TYPE:  interface
TOKEN: 0x2000034
FIELDS:
PROPERTIES:
  ignoreTimeScale  get=-1  // abstract
  duration  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000169  System.Void TweenValue(System.Single floatPercentage)
  RVA=-1  // abstract  token=0x600016C  System.Boolean ValidTarget()
END_CLASS

CLASS: TMPro.ColorTween
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x48
IMPLEMENTS: TMPro.ITweenValue
FIELDS:
  private           TMPro.ColorTween.ColorTweenCallbackm_Target  // 0x10
  private           UnityEngine.Color               m_StartColor  // 0x18
  private           UnityEngine.Color               m_TargetColor  // 0x28
  private           TMPro.ColorTween.ColorTweenMode m_TweenMode  // 0x38
  private           System.Single                   m_Duration  // 0x3c
  private           System.Boolean                  m_IgnoreTimeScale  // 0x40
PROPERTIES:
  startColor  get=0x020C61C0  set=0x03D707A0
  targetColor  get=0x03D51D80  set=0x03D51D90
  tweenMode  get=0x03D4EB90  set=0x03D4EBA0
  duration  get=0x03D4F3A0  set=0x03D4F3B0
  ignoreTimeScale  get=0x03D4EF60  set=0x03D4EF70
METHODS:
  RVA=0x09CEEB2C  token=0x6000177  System.Void TweenValue(System.Single floatPercentage)
  RVA=0x09CEEA94  token=0x6000178  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback)
  RVA=0x03D4EF60  token=0x6000179  System.Boolean GetIgnoreTimescale()
  RVA=0x03D4F3A0  token=0x600017A  System.Single GetDuration()
  RVA=0x022B4F90  token=0x600017B  System.Boolean ValidTarget()
END_CLASS

CLASS: TMPro.FloatTween
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x28
IMPLEMENTS: TMPro.ITweenValue
FIELDS:
  private           TMPro.FloatTween.FloatTweenCallbackm_Target  // 0x10
  private           System.Single                   m_StartValue  // 0x18
  private           System.Single                   m_TargetValue  // 0x1c
  private           System.Single                   m_Duration  // 0x20
  private           System.Boolean                  m_IgnoreTimeScale  // 0x24
PROPERTIES:
  startValue  get=0x03D58BB0  set=0x03D58BE0
  targetValue  get=0x03D5E120  set=0x03D5E130
  duration  get=0x03D4E7A0  set=0x03D50CA0
  ignoreTimeScale  get=0x03D58C00  set=0x03D58C20
METHODS:
  RVA=0x09CEEFD4  token=0x6000185  System.Void TweenValue(System.Single floatPercentage)
  RVA=0x09CEEF3C  token=0x6000186  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback)
  RVA=0x03D58C00  token=0x6000187  System.Boolean GetIgnoreTimescale()
  RVA=0x03D4E7A0  token=0x6000188  System.Single GetDuration()
  RVA=0x022B4F90  token=0x6000189  System.Boolean ValidTarget()
END_CLASS

CLASS: TMPro.TweenRunner`1
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  protected         UnityEngine.MonoBehaviour       m_CoroutineContainer  // 0x0
  protected         System.Collections.IEnumerator  m_Tween  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600018B  System.Collections.IEnumerator Start(T tweenInfo)
  RVA=-1  // not resolved  token=0x600018C  System.Void Init(UnityEngine.MonoBehaviour coroutineContainer)
  RVA=-1  // not resolved  token=0x600018D  System.Void StartTween(T info)
  RVA=-1  // not resolved  token=0x600018E  System.Void StopTween()
  RVA=-1  // not resolved  token=0x600018F  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_DefaultControls
TYPE:  static class
TOKEN: 0x200003C
SIZE:  0x10
FIELDS:
  private   static  System.Single                   kWidth  // const
  private   static  System.Single                   kThickHeight  // const
  private   static  System.Single                   kThinHeight  // const
  private   static  UnityEngine.Vector2             s_TextElementSize  // static @ 0x0
  private   static  UnityEngine.Vector2             s_ThickElementSize  // static @ 0x8
  private   static  UnityEngine.Vector2             s_ThinElementSize  // static @ 0x10
  private   static  UnityEngine.Color               s_DefaultSelectableColor  // static @ 0x18
  private   static  UnityEngine.Color               s_TextColor  // static @ 0x28
METHODS:
  RVA=0x09CF196C  token=0x6000196  UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size)
  RVA=0x09CF1A0C  token=0x6000197  UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent)
  RVA=0x09CF1B0C  token=0x6000198  System.Void SetDefaultTextValues(TMPro.TMP_Text lbl)
  RVA=0x09CF1ABC  token=0x6000199  System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider)
  RVA=0x09CF1C4C  token=0x600019A  System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent)
  RVA=0x09CF1B8C  token=0x600019B  System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer)
  RVA=0x09CF15F4  token=0x600019C  UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources)
  RVA=0x09CF0028  token=0x600019D  UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources)
  RVA=0x09CF18D0  token=0x600019E  UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources)
  RVA=0x09CF104C  token=0x600019F  UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources)
  RVA=0x09CF02A4  token=0x60001A0  UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources)
  RVA=0x09CF1D18  token=0x60001A1  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Dropdown
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x200
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.EventSystems.ICancelHandler
FIELDS:
  private           UnityEngine.RectTransform       m_Template  // 0x180
  private           TMPro.TMP_Text                  m_CaptionText  // 0x188
  private           UnityEngine.UI.Image            m_CaptionImage  // 0x190
  private           UnityEngine.UI.Graphic          m_Placeholder  // 0x198
  private           TMPro.TMP_Text                  m_ItemText  // 0x1a0
  private           UnityEngine.UI.Image            m_ItemImage  // 0x1a8
  private           System.Int32                    m_Value  // 0x1b0
  private           TMPro.TMP_Dropdown.OptionDataListm_Options  // 0x1b8
  private           TMPro.TMP_Dropdown.DropdownEventm_OnValueChanged  // 0x1c0
  private           System.Single                   m_AlphaFadeSpeed  // 0x1c8
  private           UnityEngine.GameObject          m_Dropdown  // 0x1d0
  private           UnityEngine.GameObject          m_Blocker  // 0x1d8
  private           System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem>m_Items  // 0x1e0
  private           TMPro.TweenRunner<TMPro.FloatTween>m_AlphaTweenRunner  // 0x1e8
  private           System.Boolean                  validTemplate  // 0x1f0
  private           UnityEngine.Coroutine           m_Coroutine  // 0x1f8
  private   static  TMPro.TMP_Dropdown.OptionData   s_NoOptionData  // static @ 0x0
PROPERTIES:
  template  get=0x03D56B50  set=0x09CF4BE0
  captionText  get=0x03D56AF0  set=0x09CF4B0C
  captionImage  get=0x03D56B70  set=0x09CF4AE4
  placeholder  get=0x03D56AE0  set=0x09CF4BB8
  itemText  get=0x03D56AD0  set=0x09CF4B5C
  itemImage  get=0x03D57170  set=0x09CF4B34
  options  get=0x09CF4AC4  set=0x09CF4B84
  onValueChanged  get=0x03D571E0  set=0x04275C68
  alphaFadeSpeed  get=0x03D59880  set=0x03D5BAC0
  value  get=0x03D84CB0  set=0x09CF4C08
  IsExpanded  get=0x09CF4A70
METHODS:
  RVA=0x09CF3328  token=0x60001B6  System.Void SetValueWithoutNotify(System.Int32 input)
  RVA=0x09CF3334  token=0x60001B7  System.Void SetValue(System.Int32 value, System.Boolean sendCallback)
  RVA=0x09CF4948  token=0x60001B9  System.Void .ctor()
  RVA=0x09CF249C  token=0x60001BA  System.Void Awake()
  RVA=0x09CF4848  token=0x60001BB  System.Void Start()
  RVA=0x09CF2E80  token=0x60001BC  System.Void OnDisable()
  RVA=0x09CF3024  token=0x60001BD  System.Void RefreshShownValue()
  RVA=0x09CF204C  token=0x60001BE  System.Void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options)
  RVA=0x09CF20B4  token=0x60001BF  System.Void AddOptions(System.Collections.Generic.List<System.String> options)
  RVA=0x09CF21A4  token=0x60001C0  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options)
  RVA=0x09CF2584  token=0x60001C1  System.Void ClearOptions()
  RVA=0x09CF346C  token=0x60001C2  System.Void SetupTemplate()
  RVA=-1  // generic def  token=0x60001C3  T GetOrAddComponent(UnityEngine.GameObject go)
  RVA=0x09CF2F14  token=0x60001C4  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CF2F14  token=0x60001C5  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09CF2E78  token=0x60001C6  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09CF3A70  token=0x60001C7  System.Void Show()
  RVA=0x09CF261C  token=0x60001C8  UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas)
  RVA=0x09CF2B64  token=0x60001C9  System.Void DestroyBlocker(UnityEngine.GameObject blocker)
  RVA=0x09CF2A50  token=0x60001CA  UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template)
  RVA=0x09CF2BB0  token=0x60001CB  System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList)
  RVA=0x09CF2AA4  token=0x60001CC  TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate)
  RVA=0x0350B670  token=0x60001CD  System.Void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item)
  RVA=0x09CF1DC0  token=0x60001CE  TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, System.Boolean selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items)
  RVA=0x09CF2410  token=0x60001CF  System.Void AlphaFadeList(System.Single duration, System.Single alpha)
  RVA=0x09CF2294  token=0x60001D0  System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end)
  RVA=0x09CF3288  token=0x60001D1  System.Void SetAlpha(System.Single alpha)
  RVA=0x09CF2BFC  token=0x60001D2  System.Void Hide()
  RVA=0x09CF2AF8  token=0x60001D3  System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay)
  RVA=0x09CF2D14  token=0x60001D4  System.Void ImmediateDestroyDropdownList()
  RVA=0x09CF2F1C  token=0x60001D5  System.Void OnSelectItem(UnityEngine.UI.Toggle toggle)
  RVA=0x09CF48D8  token=0x60001D6  System.Void .cctor()
END_CLASS

CLASS: TMPro.AtlasPopulationMode
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.AtlasPopulationMode       Static  // const
  public    static  TMPro.AtlasPopulationMode       Dynamic  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_FontAsset
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x230
EXTENDS: TMPro.TMP_Asset
FIELDS:
  private           System.String                   m_Version  // 0x30
  private           System.String                   m_SourceFontFileGUID  // 0x38
  private           UnityEngine.Font                m_SourceFontFile  // 0x40
  private           System.Single                   m_ThaiBiasConsonantsValue  // 0x48
  private           System.String                   m_prefixMaterialSearchPatternValue  // 0x50
  private           TMPro.AtlasPopulationMode       m_AtlasPopulationMode  // 0x58
  public            UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x60
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphTable  // 0xc0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph>m_GlyphLookupDictionary  // 0xc8
  private           System.Collections.Generic.List<TMPro.TMP_Character>m_CharacterTable  // 0xd0
  public            System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_Character>m_CharacterLookupDictionary  // 0xd8
  private           UnityEngine.Texture2D           m_AtlasTexture  // 0xe0
  private           UnityEngine.Texture2D[]         m_AtlasTextures  // 0xe8
  private           System.Int32                    m_AtlasTextureIndex  // 0xf0
  private           System.Boolean                  m_IsMultiAtlasTexturesEnabled  // 0xf4
  private           System.Boolean                  m_ClearDynamicDataOnBuild  // 0xf5
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_UsedGlyphRects  // 0xf8
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_FreeGlyphRects  // 0x100
  private           TMPro.FaceInfo_Legacy           m_fontInfo  // 0x108
  public            UnityEngine.Texture2D           atlas  // 0x110
  private           System.Int32                    m_AtlasWidth  // 0x118
  private           System.Int32                    m_AtlasHeight  // 0x11c
  private           System.Int32                    m_AtlasPadding  // 0x120
  private           UnityEngine.TextCore.LowLevel.GlyphRenderModem_AtlasRenderMode  // 0x124
  private           System.Collections.Generic.List<TMPro.TMP_Glyph>m_glyphInfoList  // 0x128
  private           TMPro.KerningTable              m_KerningTable  // 0x130
  public            TMPro.TMP_FontFeatureTable      m_FontFeatureTable  // 0x138
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>fallbackFontAssets  // 0x140
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>m_FallbackFontAssetTable  // 0x148
  private           TMPro.FontAssetCreationSettings m_CreationSettings  // 0x150
  private           TMPro.TMP_FontWeightPair[]      m_FontWeightTable  // 0x1a8
  private           TMPro.TMP_FontWeightPair[]      fontWeights  // 0x1b0
  public            System.Single                   normalStyle  // 0x1b8
  public            System.Single                   normalSpacingOffset  // 0x1bc
  public            System.Single                   boldStyle  // 0x1c0
  public            System.Single                   boldSpacing  // 0x1c4
  public            System.Byte                     italicStyle  // 0x1c8
  public            System.Byte                     tabSize  // 0x1c9
  public            System.Boolean                  isUsedBySoftLink  // 0x1ca
  private           System.Boolean                  IsFontAssetLookupTablesDirty  // 0x1cb
  private   static  Unity.Profiling.ProfilerMarker  k_ReadFontAssetDefinitionMarker  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_AddSynthesizedCharactersMarker  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker<System.UInt32>k_TryAddCharacterMarker  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_TryAddCharactersMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateGlyphAdjustmentRecordsMarker  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_ClearFontAssetDataMarker  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateFontAssetDataMarker  // static @ 0x30
  private   static  System.String                   s_DefaultMaterialSuffix  // static @ 0x38
  private           System.Collections.Generic.HashSet<System.Int32>FallbackSearchQueryLookup  // 0x1d0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedFontAssetLookup  // static @ 0x40
  private   static  System.Collections.Generic.List<TMPro.TMP_FontAsset>k_FontAssets_FontFeaturesUpdateQueue  // static @ 0x48
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_FontFeaturesUpdateQueueLookup  // static @ 0x50
  private   static  System.Collections.Generic.List<TMPro.TMP_FontAsset>k_FontAssets_AtlasTexturesUpdateQueue  // static @ 0x58
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_AtlasTexturesUpdateQueueLookup  // static @ 0x60
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsToRender  // 0x1d8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsRendered  // 0x1e0
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexList  // 0x1e8
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexListNewlyAdded  // 0x1f0
  private           System.Collections.Generic.List<System.UInt32>m_GlyphsToAdd  // 0x1f8
  private           System.Collections.Generic.HashSet<System.UInt32>m_GlyphsToAddLookup  // 0x200
  private           System.Collections.Generic.List<TMPro.TMP_Character>m_CharactersToAdd  // 0x208
  private           System.Collections.Generic.HashSet<System.UInt32>m_CharactersToAddLookup  // 0x210
  private           System.Collections.Generic.List<System.UInt32>s_MissingCharacterList  // 0x218
  private           System.Collections.Generic.HashSet<System.UInt32>m_MissingUnicodesFromFontFile  // 0x220
  private   static  System.UInt32[]                 k_GlyphIndexArray  // static @ 0x68
  private           UnityEngine.RenderTexture[]     m_DynamicRenderTextures  // 0x228
PROPERTIES:
  version  get=0x01003830  set=0x04270470
  sourceFontFile  get=0x03D4E2B0  set=0x03CB2D80
  thaiBiasConsonantsValue  get=0x03D58370  set=0x03D5BE60
  prefixMaterialSearchPatternValue  get=0x03D4EAF0  set=0x02C926C0
  atlasPopulationMode  get=0x03D4EF00  set=0x03D4EF50
  faceInfo  get=0x03D84D20  set=0x09CFA9EC
  glyphTable  get=0x03D50E60  set=0x058B426C
  glyphLookupTable  get=0x09CFA96C
  characterTable  get=0x03D50050  set=0x0554A7E0
  characterLookupTable  get=0x02571660
  atlasTexture  get=0x02860E30
  atlasTextures  get=0x03D50EA0  set=0x056A2B64
  atlasTextureCount  get=0x03D84CC0
  isMultiAtlasTexturesEnabled  get=0x03D72B20  set=0x03D72B30
  clearDynamicDataOnBuild  get=0x03D72B40  set=0x03D72B50
  usedGlyphRects  get=0x03D50160  set=0x0554D2E0
  freeGlyphRects  get=0x03D50770  set=0x055631FC
  fontInfo  get=0x03D56D30
  atlasWidth  get=0x03D50A10  set=0x03D50A20
  atlasHeight  get=0x03D5D760  set=0x03D5D770
  atlasPadding  get=0x03D5D890  set=0x03D84D60
  atlasRenderMode  get=0x03D6DED0  set=0x03D742C0
  fontFeatureTable  get=0x03D56EF0  set=0x04275CE0
  fallbackFontAssetTable  get=0x03D571B0  set=0x058B3DA8
  creationSettings  get=0x03D84CD0  set=0x09CFA99C
  fontWeightTable  get=0x03D57170  set=0x04275BE8
  dynamicRenderTextures  get=0x03D57480
METHODS:
  RVA=0x09CF5ADC  token=0x6000225  TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font)
  RVA=0x09CF5B4C  token=0x6000226  TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  RVA=0x03A91970  token=0x6000227  System.Void Awake()
  RVA=0x02EE81F0  token=0x6000228  System.Void ReadFontAssetDefinition()
  RVA=0x02EE8C30  token=0x6000229  System.Void InitializeDictionaryLookupTables()
  RVA=0x02EE9600  token=0x600022A  System.Void InitializeGlyphLookupDictionary()
  RVA=0x02EE9340  token=0x600022B  System.Void InitializeCharacterLookupDictionary()
  RVA=0x02EE8DD0  token=0x600022C  System.Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
  RVA=0x02EE8F50  token=0x600022D  System.Void AddSynthesizedCharactersAndFaceMetrics()
  RVA=0x02EE9170  token=0x600022E  System.Void AddSynthesizedCharacter(System.UInt32 unicode, System.Boolean isFontFaceLoaded, System.Boolean addImmediately)
  RVA=0x09CF5108  token=0x600022F  System.Void AddCharacterToLookupCache(System.UInt32 unicode, TMPro.TMP_Character character)
  RVA=0x09CF771C  token=0x6000230  System.Void SortCharacterTable()
  RVA=0x09CF78AC  token=0x6000231  System.Void SortGlyphTable()
  RVA=0x09CF7888  token=0x6000232  System.Void SortFontFeatureTable()
  RVA=0x09CF76F0  token=0x6000233  System.Void SortAllTables()
  RVA=0x09CF6544  token=0x6000234  System.Boolean HasCharacter(System.Int32 character)
  RVA=0x09CF65A0  token=0x6000235  System.Boolean HasCharacter(System.Char character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  RVA=0x09CF632C  token=0x6000236  System.Boolean HasCharacter_Internal(System.UInt32 character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  RVA=0x09CF6A80  token=0x6000237  System.Boolean HasCharacters(System.String text, System.Collections.Generic.List<System.Char>& missingCharacters)
  RVA=0x09CF6BD4  token=0x6000238  System.Boolean HasCharacters(System.String text, System.UInt32[]& missingCharacters, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  RVA=0x09CF71A0  token=0x6000239  System.Boolean HasCharacters(System.String text)
  RVA=0x09CF6168  token=0x600023A  System.String GetCharacters(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09CF609C  token=0x600023B  System.Int32[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09CF6248  token=0x600023C  System.UInt32 GetGlyphIndex(System.UInt32 unicode)
  RVA=0x02EE7B10  token=0x600023D  System.Void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset)
  RVA=0x0296B070  token=0x600023E  System.Void UpdateFontFeaturesForFontAssetsInQueue()
  RVA=0x09CF7290  token=0x600023F  System.Void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09CF9774  token=0x6000240  System.Void UpdateAtlasTexturesForFontAssetsInQueue()
  RVA=0x09CF8E44  token=0x6000241  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.Boolean includeFontFeatures)
  RVA=0x09CF7A18  token=0x6000242  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.UInt32[]& missingUnicodes, System.Boolean includeFontFeatures)
  RVA=0x09CF8430  token=0x6000243  System.Boolean TryAddCharacters(System.String characters, System.Boolean includeFontFeatures)
  RVA=0x09CF8454  token=0x6000244  System.Boolean TryAddCharacters(System.String characters, System.String& missingCharacters, System.Boolean includeFontFeatures)
  RVA=0x09CF51AC  token=0x6000245  System.Void AddCharacters(System.String characters)
  RVA=0x02EE7DF0  token=0x6000246  System.Boolean TryAddCharacterInternal(System.UInt32 unicode, TMPro.TMP_Character& character)
  RVA=0x09CF91E0  token=0x6000247  System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 unicode, TMPro.TMP_Character& character)
  RVA=0x0350B670  token=0x6000248  System.Void TryAddGlyphsToAtlasTextures()
  RVA=0x09CF8E68  token=0x6000249  System.Boolean TryAddGlyphsToNewAtlasTexture()
  RVA=0x09CF735C  token=0x600024A  System.Void SetupNewAtlasTexture()
  RVA=0x09CF95F0  token=0x600024B  System.Void UpdateAtlasTexture()
  RVA=0x03A1F2E0  token=0x600024C  System.Void UpdateGlyphAdjustmentRecords()
  RVA=0x09CF99A0  token=0x600024D  System.Void UpdateGlyphAdjustmentRecords(System.UInt32[] glyphIndexes)
  RVA=0x0350B670  token=0x600024E  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes)
  RVA=0x0350B670  token=0x600024F  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes)
  RVA=-1  // generic def  token=0x6000250  System.Void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[]& dstArray)
  RVA=0x09CF5918  token=0x6000251  System.Void ClearFontAssetData(System.Boolean setAtlasSizeToZero)
  RVA=0x09CF5910  token=0x6000252  System.Void ClearFontAssetData()
  RVA=0x09CF58EC  token=0x6000253  System.Void ClearFontAssetDataInternal()
  RVA=0x09CF9898  token=0x6000254  System.Void UpdateFontAssetData()
  RVA=0x09CF5954  token=0x6000255  System.Void ClearFontAssetTables()
  RVA=0x09CF525C  token=0x6000256  System.Void ClearAtlasTextures(System.Boolean setAtlasSizeToZero)
  RVA=0x09CF9BCC  token=0x6000257  System.Void UpgradeFontAsset()
  RVA=0x09CFA5D4  token=0x6000258  System.Void UpgradeGlyphAdjustmentTableToFontFeatureTable()
  RVA=0x09CF7240  token=0x600025A  System.Void OnDestroy()
  RVA=0x0363C8D0  token=0x600025B  System.Void .ctor()
  RVA=0x038BED90  token=0x600025C  System.Void .cctor()
END_CLASS

CLASS: TMPro.FaceInfo_Legacy
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x68
FIELDS:
  public            System.String                   Name  // 0x10
  public            System.Single                   PointSize  // 0x18
  public            System.Single                   Scale  // 0x1c
  public            System.Int32                    CharacterCount  // 0x20
  public            System.Single                   LineHeight  // 0x24
  public            System.Single                   Baseline  // 0x28
  public            System.Single                   Ascender  // 0x2c
  public            System.Single                   CapHeight  // 0x30
  public            System.Single                   Descender  // 0x34
  public            System.Single                   CenterLine  // 0x38
  public            System.Single                   SuperscriptOffset  // 0x3c
  public            System.Single                   SubscriptOffset  // 0x40
  public            System.Single                   SubSize  // 0x44
  public            System.Single                   Underline  // 0x48
  public            System.Single                   UnderlineThickness  // 0x4c
  public            System.Single                   strikethrough  // 0x50
  public            System.Single                   strikethroughThickness  // 0x54
  public            System.Single                   TabWidth  // 0x58
  public            System.Single                   Padding  // 0x5c
  public            System.Single                   AtlasWidth  // 0x60
  public            System.Single                   AtlasHeight  // 0x64
METHODS:
  RVA=0x0350B670  token=0x6000261  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Glyph
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x38
EXTENDS: TMPro.TMP_TextElement_Legacy
FIELDS:
METHODS:
  RVA=0x09CFAE40  token=0x6000262  TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source)
  RVA=0x0350B670  token=0x6000263  System.Void .ctor()
END_CLASS

CLASS: TMPro.FontAssetCreationSettings
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x68
FIELDS:
  public            System.String                   sourceFontFileName  // 0x10
  public            System.String                   sourceFontFileGUID  // 0x18
  public            System.Int32                    pointSizeSamplingMode  // 0x20
  public            System.Int32                    pointSize  // 0x24
  public            System.Int32                    padding  // 0x28
  public            System.Int32                    packingMode  // 0x2c
  public            System.Int32                    atlasWidth  // 0x30
  public            System.Int32                    atlasHeight  // 0x34
  public            System.Int32                    characterSetSelectionMode  // 0x38
  public            System.String                   characterSequence  // 0x40
  public            System.String                   referencedFontAssetGUID  // 0x48
  public            System.String                   referencedTextAssetGUID  // 0x50
  public            System.Int32                    fontStyle  // 0x58
  public            System.Single                   fontStyleModifier  // 0x5c
  public            System.Int32                    renderMode  // 0x60
  public            System.Boolean                  includeFontFeatures  // 0x64
METHODS:
  RVA=0x09CEF038  token=0x6000264  System.Void .ctor(System.String sourceFontFileGUID, System.Int32 pointSize, System.Int32 pointSizeSamplingMode, System.Int32 padding, System.Int32 packingMode, System.Int32 atlasWidth, System.Int32 atlasHeight, System.Int32 characterSelectionMode, System.String characterSet, System.Int32 renderMode)
END_CLASS

CLASS: TMPro.TMP_FontWeightPair
TYPE:  sealed struct
TOKEN: 0x200004B
SIZE:  0x20
FIELDS:
  public            TMPro.TMP_FontAsset             regularTypeface  // 0x10
  public            TMPro.TMP_FontAsset             italicTypeface  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.KerningPairKey
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x1C
FIELDS:
  public            System.UInt32                   ascii_Left  // 0x10
  public            System.UInt32                   ascii_Right  // 0x14
  public            System.UInt32                   key  // 0x18
METHODS:
  RVA=0x03D84C20  token=0x6000265  System.Void .ctor(System.UInt32 ascii_left, System.UInt32 ascii_right)
END_CLASS

CLASS: TMPro.GlyphValueRecord_Legacy
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x20
FIELDS:
  public            System.Single                   xPlacement  // 0x10
  public            System.Single                   yPlacement  // 0x14
  public            System.Single                   xAdvance  // 0x18
  public            System.Single                   yAdvance  // 0x1c
METHODS:
  RVA=0x03D84C00  token=0x6000266  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
  RVA=0x028B5D60  token=0x6000267  TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b)
END_CLASS

CLASS: TMPro.KerningPair
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x40
FIELDS:
  private           System.UInt32                   m_FirstGlyph  // 0x10
  private           TMPro.GlyphValueRecord_Legacy   m_FirstGlyphAdjustments  // 0x14
  private           System.UInt32                   m_SecondGlyph  // 0x24
  private           TMPro.GlyphValueRecord_Legacy   m_SecondGlyphAdjustments  // 0x28
  public            System.Single                   xOffset  // 0x38
  private   static  TMPro.KerningPair               empty  // static @ 0x0
  private           System.Boolean                  m_IgnoreSpacingAdjustments  // 0x3c
PROPERTIES:
  firstGlyph  get=0x03D4E340  set=0x010410F0
  firstGlyphAdjustments  get=0x03D60DB0
  secondGlyph  get=0x03D4E2E0  set=0x03D4E2F0
  secondGlyphAdjustments  get=0x03D59E20
  ignoreSpacingAdjustments  get=0x03D4F460
METHODS:
  RVA=0x03D84C80  token=0x600026F  System.Void .ctor()
  RVA=0x03D84C50  token=0x6000270  System.Void .ctor(System.UInt32 left, System.UInt32 right, System.Single offset)
  RVA=0x03D84C60  token=0x6000271  System.Void .ctor(System.UInt32 firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, System.UInt32 secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments)
  RVA=0x03D84C40  token=0x6000272  System.Void ConvertLegacyKerningData()
  RVA=0x03CF26E0  token=0x6000273  System.Void .cctor()
END_CLASS

CLASS: TMPro.KerningTable
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<TMPro.KerningPair>kerningPairs  // 0x10
METHODS:
  RVA=0x0363CD50  token=0x6000274  System.Void .ctor()
  RVA=0x09CEF634  token=0x6000275  System.Void AddKerningPair()
  RVA=0x09CEF4E8  token=0x6000276  System.Int32 AddKerningPair(System.UInt32 first, System.UInt32 second, System.Single offset)
  RVA=0x09CEF384  token=0x6000277  System.Int32 AddGlyphPairAdjustmentRecord(System.UInt32 first, TMPro.GlyphValueRecord_Legacy firstAdjustments, System.UInt32 second, TMPro.GlyphValueRecord_Legacy secondAdjustments)
  RVA=0x09CEF76C  token=0x6000278  System.Void RemoveKerningPair(System.Int32 left, System.Int32 right)
  RVA=0x09CEF86C  token=0x6000279  System.Void RemoveKerningPair(System.Int32 index)
  RVA=0x09CEF8C0  token=0x600027A  System.Void SortKerningPairs()
END_CLASS

CLASS: TMPro.TMP_FontUtilities
TYPE:  static class
TOKEN: 0x2000054
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<System.Int32>k_searchedFontAssets  // static @ 0x0
METHODS:
  RVA=0x09CFAD40  token=0x6000285  TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character)
  RVA=0x09CFAD38  token=0x6000286  TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character)
  RVA=0x09CFAA30  token=0x6000287  TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character)
  RVA=0x09CFAC5C  token=0x6000288  TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character)
END_CLASS

CLASS: TMPro.TMP_FontAssetUtilities
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x10
FIELDS:
  private   static readonly TMPro.TMP_FontAssetUtilities    s_Instance  // static @ 0x0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedAssets  // static @ 0x8
  private   static  System.Boolean                  k_IsFontEngineInitialized  // static @ 0x10
PROPERTIES:
  instance  get=0x09CF50B8
METHODS:
  RVA=0x03D1ACF0  token=0x6000289  System.Void .cctor()
  RVA=0x02570D10  token=0x600028B  TMPro.TMP_Character GetCharacterFromFontAsset(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  RVA=0x02570DD0  token=0x600028C  TMPro.TMP_Character GetCharacterFromFontAsset_Internal(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  RVA=0x029696B0  token=0x600028D  TMPro.TMP_Character GetCharacterFromFontAssets(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  RVA=0x09CF4DCC  token=0x600028E  TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks)
  RVA=0x09CF4C14  token=0x600028F  TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks)
  RVA=0x0350B670  token=0x6000290  System.Void .ctor()
END_CLASS

CLASS: TMPro.FontFeatureLookupFlags
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontFeatureLookupFlags    None  // const
  public    static  TMPro.FontFeatureLookupFlags    IgnoreLigatures  // const
  public    static  TMPro.FontFeatureLookupFlags    IgnoreSpacingAdjustments  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_GlyphValueRecord
TYPE:  sealed struct
TOKEN: 0x2000057
SIZE:  0x20
FIELDS:
  private           System.Single                   m_XPlacement  // 0x10
  private           System.Single                   m_YPlacement  // 0x14
  private           System.Single                   m_XAdvance  // 0x18
  private           System.Single                   m_YAdvance  // 0x1c
PROPERTIES:
  xPlacement  get=0x03D4FA00  set=0x03D58BD0
  yPlacement  get=0x03D58BC0  set=0x03D58BF0
  xAdvance  get=0x03D58BB0  set=0x03D58BE0
  yAdvance  get=0x03D5E120  set=0x03D5E130
METHODS:
  RVA=0x03D516B0  token=0x6000299  System.Void .ctor(System.Single xPlacement, System.Single yPlacement, System.Single xAdvance, System.Single yAdvance)
  RVA=0x03D5DBB0  token=0x600029A  System.Void .ctor(TMPro.GlyphValueRecord_Legacy valueRecord)
  RVA=0x03D84C00  token=0x600029B  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
  RVA=0x03D84D70  token=0x600029C  TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b)
END_CLASS

CLASS: TMPro.TMP_GlyphAdjustmentRecord
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x24
FIELDS:
  private           System.UInt32                   m_GlyphIndex  // 0x10
  private           TMPro.TMP_GlyphValueRecord      m_GlyphValueRecord  // 0x14
PROPERTIES:
  glyphIndex  get=0x03D4E980  set=0x03D4E970
  glyphValueRecord  get=0x03D67710  set=0x03D84E00
METHODS:
  RVA=0x03D675C0  token=0x60002A1  System.Void .ctor(System.UInt32 glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord)
  RVA=0x09CFC754  token=0x60002A2  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord)
END_CLASS

CLASS: TMPro.TMP_GlyphPairAdjustmentRecord
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x40
FIELDS:
  public            TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord  // 0x10
  public            TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord  // 0x24
  public            TMPro.FontFeatureLookupFlags    m_FeatureLookupFlags  // 0x38
PROPERTIES:
  firstAdjustmentRecord  get=0x03D60A90  set=0x03D6E5B0
  secondAdjustmentRecord  get=0x03D84E40  set=0x03D84E60
  featureLookupFlags  get=0x03D4EC30  set=0x03D4ECB0
METHODS:
  RVA=0x03D84E10  token=0x60002A9  System.Void .ctor(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
  RVA=0x09CFC79C  token=0x60002AA  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
END_CLASS

CLASS: TMPro.GlyphPairKey
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x1C
FIELDS:
  public            System.UInt32                   firstGlyphIndex  // 0x10
  public            System.UInt32                   secondGlyphIndex  // 0x14
  public            System.UInt32                   key  // 0x18
METHODS:
  RVA=0x03D84DE0  token=0x60002AB  System.Void .ctor(System.UInt32 firstGlyphIndex, System.UInt32 secondGlyphIndex)
  RVA=0x09CFC354  token=0x60002AC  System.Void .ctor(TMPro.TMP_GlyphPairAdjustmentRecord record)
END_CLASS

CLASS: TMPro.TMP_FontFeatureTable
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecords  // 0x10
  public            System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecordLookupDictionary  // 0x18
PROPERTIES:
  glyphPairAdjustmentRecords  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0363CDD0  token=0x60002AF  System.Void .ctor()
  RVA=0x09CFC534  token=0x60002B0  System.Void SortGlyphPairAdjustmentRecords()
END_CLASS

CLASS: TMPro.TMP_InputField
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x388
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IUpdateSelectedHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.UI.ICanvasElement UnityEngine.UI.ILayoutElement UnityEngine.EventSystems.IScrollHandler
FIELDS:
  protected         UnityEngine.TouchScreenKeyboard m_SoftKeyboard  // 0x180
  private   static readonly System.Char[]                   kSeparators  // static @ 0x0
  protected         UnityEngine.RectTransform       m_RectTransform  // 0x188
  protected         UnityEngine.RectTransform       m_TextViewport  // 0x190
  protected         UnityEngine.UI.RectMask2D       m_TextComponentRectMask  // 0x198
  protected         UnityEngine.UI.RectMask2D       m_TextViewportRectMask  // 0x1a0
  private           UnityEngine.Rect                m_CachedViewportRect  // 0x1a8
  protected         TMPro.TMP_Text                  m_TextComponent  // 0x1b8
  protected         UnityEngine.RectTransform       m_TextComponentRectTransform  // 0x1c0
  protected         UnityEngine.UI.Graphic          m_Placeholder  // 0x1c8
  protected         UnityEngine.UI.Scrollbar        m_VerticalScrollbar  // 0x1d0
  protected         TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler  // 0x1d8
  private           System.Boolean                  m_IsDrivenByLayoutComponents  // 0x1e0
  private           UnityEngine.UI.LayoutGroup      m_LayoutGroup  // 0x1e8
  private           UnityEngine.EventSystems.IScrollHandlerm_IScrollHandlerParent  // 0x1f0
  private           System.Single                   m_ScrollPosition  // 0x1f8
  protected         System.Single                   m_ScrollSensitivity  // 0x1fc
  private           TMPro.TMP_InputField.ContentTypem_ContentType  // 0x200
  private           TMPro.TMP_InputField.InputType  m_InputType  // 0x204
  private           System.Char                     m_AsteriskChar  // 0x208
  private           UnityEngine.TouchScreenKeyboardTypem_KeyboardType  // 0x20c
  private           TMPro.TMP_InputField.LineType   m_LineType  // 0x210
  private           System.Boolean                  m_HideMobileInput  // 0x214
  private           System.Boolean                  m_HideSoftKeyboard  // 0x215
  private           TMPro.TMP_InputField.CharacterValidationm_CharacterValidation  // 0x218
  private           System.String                   m_RegexValue  // 0x220
  private           System.Single                   m_GlobalPointSize  // 0x228
  private           System.Int32                    m_CharacterLimit  // 0x22c
  private           TMPro.TMP_InputField.SubmitEventm_OnEndEdit  // 0x230
  private           TMPro.TMP_InputField.SubmitEventm_OnSubmit  // 0x238
  private           TMPro.TMP_InputField.SelectionEventm_OnSelect  // 0x240
  private           TMPro.TMP_InputField.SelectionEventm_OnDeselect  // 0x248
  private           TMPro.TMP_InputField.TextSelectionEventm_OnTextSelection  // 0x250
  private           TMPro.TMP_InputField.TextSelectionEventm_OnEndTextSelection  // 0x258
  private           TMPro.TMP_InputField.OnChangeEventm_OnValueChanged  // 0x260
  private           TMPro.TMP_InputField.TouchScreenKeyboardEventm_OnTouchScreenKeyboardStatusChanged  // 0x268
  private           TMPro.TMP_InputField.OnValidateInputm_OnValidateInput  // 0x270
  private           UnityEngine.Events.UnityEvent   m_OnFocused  // 0x278
  private           UnityEngine.Color               m_CaretColor  // 0x280
  private           System.Boolean                  m_CustomCaretColor  // 0x290
  private           UnityEngine.Color               m_SelectionColor  // 0x294
  protected         System.String                   m_Text  // 0x2a8
  private           System.Single                   m_CaretBlinkRate  // 0x2b0
  private           System.Int32                    m_CaretWidth  // 0x2b4
  private           System.Boolean                  m_ReadOnly  // 0x2b8
  private           System.Boolean                  m_RichText  // 0x2b9
  private           System.Boolean                  m_disableUpDownArrowKeyMovingCaret  // 0x2ba
  private           System.Boolean                  m_disableLeftRightArrowKeyMovingCaret  // 0x2bb
  protected         System.Int32                    m_StringPosition  // 0x2bc
  protected         System.Int32                    m_StringSelectPosition  // 0x2c0
  protected         System.Int32                    m_CaretPosition  // 0x2c4
  protected         System.Int32                    m_CaretSelectPosition  // 0x2c8
  private           UnityEngine.RectTransform       caretRectTrans  // 0x2d0
  protected         UnityEngine.UIVertex[]          m_CursorVerts  // 0x2d8
  private           UnityEngine.CanvasRenderer      m_CachedInputRenderer  // 0x2e0
  private           UnityEngine.Vector2             m_LastPosition  // 0x2e8
  protected         UnityEngine.Mesh                m_Mesh  // 0x2f0
  private           System.Boolean                  m_AllowInput  // 0x2f8
  private           System.Boolean                  m_ShouldActivateNextUpdate  // 0x2f9
  private           System.Boolean                  m_UpdateDrag  // 0x2fa
  private           System.Boolean                  m_DragPositionOutOfBounds  // 0x2fb
  private   static  System.Single                   kHScrollSpeed  // const
  private   static  System.Single                   kVScrollSpeed  // const
  protected         System.Boolean                  m_CaretVisible  // 0x2fc
  private           UnityEngine.Coroutine           m_BlinkCoroutine  // 0x300
  private           System.Single                   m_BlinkStartTime  // 0x308
  private           UnityEngine.Coroutine           m_DragCoroutine  // 0x310
  private           System.String                   m_OriginalText  // 0x318
  private           System.Boolean                  m_WasCanceled  // 0x320
  private           System.Boolean                  m_HasDoneFocusTransition  // 0x321
  private           UnityEngine.WaitForSecondsRealtimem_WaitForSecondsRealtime  // 0x328
  private           System.Boolean                  m_PreventCallback  // 0x330
  private           System.Boolean                  m_TouchKeyboardAllowsInPlaceEditing  // 0x331
  private           System.Boolean                  m_IsTextComponentUpdateRequired  // 0x332
  private           System.Boolean                  m_isLastKeyBackspace  // 0x333
  private           System.Single                   m_PointerDownClickStartTime  // 0x334
  private           System.Single                   m_KeyDownStartTime  // 0x338
  private           System.Single                   m_DoubleClickDelay  // 0x33c
  private   static  System.String                   kEmailSpecialCharacters  // const
  private           System.Boolean                  m_IsCompositionActive  // 0x340
  private           System.Boolean                  m_ShouldUpdateIMEWindowPosition  // 0x341
  private           System.Int32                    m_PreviousIMEInsertionLine  // 0x344
  public            System.Func<System.String,System.Int32,System.String>onValidateCharacterLimit  // 0x348
  public            System.Func<System.String,System.Int32>onGetTextLength  // 0x350
  protected         System.Boolean                  m_OnFocusSelectAll  // 0x358
  protected         System.Boolean                  m_isSelectAll  // 0x359
  protected         System.Boolean                  m_ResetOnDeActivation  // 0x35a
  private           System.Boolean                  m_SelectionStillActive  // 0x35b
  private           System.Boolean                  m_ReleaseSelection  // 0x35c
  private           UnityEngine.GameObject          m_PreviouslySelectedObject  // 0x360
  private           System.Boolean                  m_RestoreOriginalTextOnEscape  // 0x368
  private           System.Boolean                  m_WontReleaseSelectionOnEscape  // 0x369
  private           System.Boolean                  m_tempClearCompositionString  // 0x36a
  protected         System.Boolean                  m_isRichTextEditingAllowed  // 0x36b
  protected         System.Int32                    m_LineLimit  // 0x36c
  protected         TMPro.TMP_InputValidator        m_InputValidator  // 0x370
  private           System.Boolean                  m_isSelected  // 0x378
  private           System.Boolean                  m_IsStringPositionDirty  // 0x379
  private           System.Boolean                  m_IsCaretPositionDirty  // 0x37a
  private           System.Boolean                  m_forceRectTransformAdjustment  // 0x37b
  private           UnityEngine.Event               m_ProcessingEvent  // 0x380
PROPERTIES:
  isLastKeyBackspace  get=0x03D84EE0  set=0x03D84FA0
  inputSystem  get=0x022B3890
  compositionString  get=0x022B42A0
  compositionLength  get=0x022B4C50
  mesh  get=0x02CDA930
  shouldHideMobileInput  get=0x09D00840  set=0x09D0127C
  shouldHideSoftKeyboard  get=0x09D00870  set=0x09D012E8
  text  get=0x03D57460  set=0x042759BC
  isFocused  get=0x03D84ED0
  caretBlinkRate  get=0x03D84E80  set=0x09D00920
  caretWidth  get=0x03D84E90  set=0x09D00A00
  textViewport  get=0x03D56B70  set=0x09D01490
  textComponent  get=0x03D57130  set=0x09D01434
  placeholder  get=0x03D571D0  set=0x09D00FFC
  verticalScrollbar  get=0x03D57000  set=0x09D014DC
  scrollSensitivity  get=0x03D59A20  set=0x09D010F0
  caretColor  get=0x02CDBED0  set=0x09D00988
  customCaretColor  get=0x03D5A4E0  set=0x09D00B1C
  selectionColor  get=0x03D84F60  set=0x09D01188
  onEndEdit  get=0x03D57210  set=0x09D00D9C
  onSubmit  get=0x03D57220  set=0x09D00ECC
  onSelect  get=0x03D56B10  set=0x09D00E80
  onDeselect  get=0x03D56D60  set=0x09D00D50
  onTextSelection  get=0x03D57350  set=0x09D00F18
  onEndTextSelection  get=0x03D57440  set=0x09D00DE8
  onValueChanged  get=0x03D57050  set=0x09D00FB0
  onTouchScreenKeyboardStatusChanged  get=0x03D57450  set=0x09D00F64
  onValidateInput  get=0x03D574B0  set=0x03CDDA60
  onFocused  get=0x03D57270  set=0x09D00E34
  characterLimit  get=0x03D84EA0  set=0x02CD9220
  pointSize  get=0x03D76010  set=0x09D01048
  onFocusSelectAll  get=0x03D84F30  set=0x03D84FC0
  resetOnDeActivation  get=0x03D84F40  set=0x03D84FE0
  restoreOriginalTextOnEscape  get=0x03D5B950  set=0x03D5BA80
  wontReleaseSelectionOnEscape  get=0x03D84F80  set=0x03D84FF0
  disableArrowKeyMoveCaret  get=0x03D84EB0  set=0x03D84F90
  isRichTextEditingAllowed  get=0x03D84EF0  set=0x03D84FB0
  contentType  get=0x03D5A250  set=0x09D00AC0
  lineType  get=0x03D84F20  set=0x09D00CAC
  lineLimit  get=0x03D84F10  set=0x09D00C4C
  inputType  get=0x03D84EC0  set=0x09D00B34
  keyboardType  get=0x03D84F00  set=0x09D00BF0
  characterValidation  get=0x03D5A730  set=0x09D00A5C
  inputValidator  get=0x03D55E50  set=0x09D00B90
  readOnly  get=0x03D57A10  set=0x03D84FD0
  richText  get=0x03D84F50  set=0x09D010E0
  multiLine  get=0x02CD9BA0
  asteriskChar  get=0x03D84E70  set=0x09D008C4
  wasCanceled  get=0x03D84F70
  caretPositionInternal  get=0x02CDBEB0  set=0x042731E8
  stringPositionInternal  get=0x02CDB350  set=0x042768E4
  caretSelectPositionInternal  get=0x03D42AB0  set=0x042731D0
  stringSelectPositionInternal  get=0x02CDB330  set=0x042768CC
  hasSelection  get=0x02CDB150
  caretPosition  get=0x04273150  set=0x09D009C8
  selectionAnchorPosition  get=0x04273148  set=0x09D0114C
  selectionFocusPosition  get=0x04273150  set=0x09D011C8
  stringPosition  get=0x09D00838  set=0x09D013FC
  selectionStringAnchorPosition  get=0x09D00830  set=0x09D01204
  selectionStringFocusPosition  get=0x09D00838  set=0x09D01240
  clipboard  get=0x09D005B0  set=0x09D00AB8
  minWidth  get=0x03D503F0
  preferredWidth  get=0x09D006F4
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x03D503F0
  preferredHeight  get=0x09D005B8
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x01168950
METHODS:
  RVA=0x02849920  token=0x60002BA  System.Void .ctor()
  RVA=0x02CDAC90  token=0x60002C0  System.Boolean isKeyboardUsingEvents()
  RVA=0x09CFFC44  token=0x60002C3  System.Void SetTextWithoutNotify(System.String input)
  RVA=0x03B22830  token=0x60002C4  System.Void SetText(System.String value, System.Boolean sendCallback)
  RVA=0x03D3B6E0  token=0x6000314  System.Void ClampStringPos(System.Int32& pos)
  RVA=0x038549D0  token=0x6000315  System.Void ClampCaretPos(System.Int32& pos)
  RVA=0x02CD8830  token=0x600032B  System.Void OnEnable()
  RVA=0x02CD8300  token=0x600032C  System.Void OnDisable()
  RVA=0x02CDB180  token=0x600032D  System.Void ON_TEXT_CHANGED(UnityEngine.Object obj)
  RVA=0x03D42DE0  token=0x600032E  System.Collections.IEnumerator CaretBlink()
  RVA=0x02CD9850  token=0x600032F  System.Void SetCaretVisible()
  RVA=0x02CD9890  token=0x6000330  System.Void SetCaretActive()
  RVA=0x036841C0  token=0x6000331  System.Void OnFocus()
  RVA=0x03684200  token=0x6000332  System.Void SelectAll()
  RVA=0x09CFE814  token=0x6000333  System.Void MoveTextEnd(System.Boolean shift)
  RVA=0x09CFE8E4  token=0x6000334  System.Void MoveTextStart(System.Boolean shift)
  RVA=0x09CFE988  token=0x6000335  System.Void MoveToEndOfLine(System.Boolean shift, System.Boolean ctrl)
  RVA=0x09CFEAE0  token=0x6000336  System.Void MoveToStartOfLine(System.Boolean shift, System.Boolean ctrl)
  RVA=0x02CDACF0  token=0x6000339  System.Boolean InPlaceEditing()
  RVA=0x09CFFD94  token=0x600033A  System.Void UpdateStringPositionFromKeyboard()
  RVA=0x02CDAB80  token=0x600033B  System.Void LateUpdate()
  RVA=0x022C5150  token=0x600033C  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CFED94  token=0x600033D  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CFEDB8  token=0x600033E  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CFDAF8  token=0x600033F  System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CFF110  token=0x6000340  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x022C4F80  token=0x6000341  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x02CD9900  token=0x6000342  TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt)
  RVA=0x02CD9B80  token=0x6000343  System.Boolean IsValidChar(System.Char c)
  RVA=0x09CFF984  token=0x6000344  System.Void ProcessEvent(UnityEngine.Event e)
  RVA=0x02CD9330  token=0x6000345  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09CFF134  token=0x6000346  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09CFD444  token=0x6000347  System.Single GetScrollPositionRelativeToViewport()
  RVA=0x09CFD54C  token=0x6000348  System.String GetSelectedString()
  RVA=0x09CFD168  token=0x6000349  System.Int32 FindNextWordBegin()
  RVA=0x09CFE508  token=0x600034A  System.Void MoveRight(System.Boolean shift, System.Boolean ctrl)
  RVA=0x09CFD224  token=0x600034B  System.Int32 FindPrevWordBegin()
  RVA=0x09CFDCC4  token=0x600034C  System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl)
  RVA=0x09CFD8A4  token=0x600034D  System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  RVA=0x09CFD62C  token=0x600034E  System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  RVA=0x09CFF67C  token=0x600034F  System.Int32 PageUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  RVA=0x09CFF33C  token=0x6000350  System.Int32 PageDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  RVA=0x09CFDCB8  token=0x6000351  System.Void MoveDown(System.Boolean shift)
  RVA=0x09CFDB6C  token=0x6000352  System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar)
  RVA=0x09CFEC64  token=0x6000353  System.Void MoveUp(System.Boolean shift)
  RVA=0x09CFEC70  token=0x6000354  System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar)
  RVA=0x09CFE4FC  token=0x6000355  System.Void MovePageUp(System.Boolean shift)
  RVA=0x09CFE244  token=0x6000356  System.Void MovePageUp(System.Boolean shift, System.Boolean goToFirstChar)
  RVA=0x09CFE238  token=0x6000357  System.Void MovePageDown(System.Boolean shift)
  RVA=0x09CFDF68  token=0x6000358  System.Void MovePageDown(System.Boolean shift, System.Boolean goToLastChar)
  RVA=0x030822F0  token=0x6000359  System.Void Delete()
  RVA=0x09CFCE10  token=0x600035A  System.Void DeleteKey()
  RVA=0x09CFCB1C  token=0x600035B  System.Void Backspace()
  RVA=0x09CFCA94  token=0x600035C  System.Void Append(System.String input)
  RVA=0x02CD9E30  token=0x600035D  System.Void Append(System.Char input)
  RVA=0x03081F90  token=0x600035E  System.Void Insert(System.Char c)
  RVA=0x03082270  token=0x600035F  System.Void UpdateTouchKeyboardFromEditChanges()
  RVA=0x09CFF9DC  token=0x6000360  System.Void SendOnValueChangedAndUpdateLabel()
  RVA=0x03082290  token=0x6000361  System.Void SendOnValueChanged()
  RVA=0x036842A0  token=0x6000362  System.Void SendOnEndEdit()
  RVA=0x09CFF98C  token=0x6000363  System.Void SendOnSubmit()
  RVA=0x03CC4B60  token=0x6000364  System.Void SendOnFocus()
  RVA=0x03CFB570  token=0x6000365  System.Void SendOnFocusLost()
  RVA=0x03D23970  token=0x6000366  System.Void SendOnTextSelection()
  RVA=0x02CDB370  token=0x6000367  System.Void SendOnEndTextSelection()
  RVA=0x09CFF9FC  token=0x6000368  System.Void SendTouchScreenKeyboardStatusChanged()
  RVA=0x02CD94C0  token=0x6000369  System.Void UpdateLabel()
  RVA=0x09CFFCB8  token=0x600036A  System.Void UpdateScrollbar()
  RVA=0x09CFF2B4  token=0x600036B  System.Void OnScrollbarValueChange(System.Single value)
  RVA=0x0350B670  token=0x600036C  System.Void UpdateMaskRegions()
  RVA=0x09CFC86C  token=0x600036D  System.Void AdjustTextPositionRelativeToViewport(System.Single relativePosition)
  RVA=0x02CDB2A0  token=0x600036E  System.Int32 GetCaretPositionFromStringIndex(System.Int32 stringIndex)
  RVA=0x09CFD370  token=0x600036F  System.Int32 GetMinCaretPositionFromStringIndex(System.Int32 stringIndex)
  RVA=0x09CFD2E0  token=0x6000370  System.Int32 GetMaxCaretPositionFromStringIndex(System.Int32 stringIndex)
  RVA=0x09CFD5D8  token=0x6000371  System.Int32 GetStringIndexFromCaretPosition(System.Int32 caretPosition)
  RVA=0x09CFD2D8  token=0x6000372  System.Void ForceLabelUpdate()
  RVA=0x02CD9800  token=0x6000373  System.Void MarkGeometryAsDirty()
  RVA=0x02CDA860  token=0x6000374  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x0350B670  token=0x6000375  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x6000376  System.Void GraphicUpdateComplete()
  RVA=0x02CDA870  token=0x6000377  System.Void UpdateGeometry()
  RVA=0x02CD6AE0  token=0x6000378  System.Void AssignPositioningIfNeeded()
  RVA=0x02CDAD90  token=0x6000379  System.Void OnFillVBO(UnityEngine.Mesh vbo)
  RVA=0x02CDB420  token=0x600037A  System.Void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  RVA=0x02CDD600  token=0x600037B  System.Void CreateCursorVerts()
  RVA=0x036A46D0  token=0x600037C  System.Void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  RVA=0x036A4E20  token=0x600037D  System.Void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, System.Single height, System.Boolean isCharVisible)
  RVA=0x09CFFE8C  token=0x600037E  System.Char Validate(System.String text, System.Int32 pos, System.Char ch)
  RVA=0x03683F00  token=0x600037F  System.Void ActivateInputField()
  RVA=0x03683FF0  token=0x6000380  System.Void ActivateInputFieldInternal()
  RVA=0x03CDD120  token=0x6000381  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03D4C560  token=0x6000382  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0350B670  token=0x6000383  System.Void OnControlClick()
  RVA=0x03684250  token=0x6000384  System.Void ReleaseSelection()
  RVA=0x03683C00  token=0x6000385  System.Void DeactivateInputField(System.Boolean clearSelection)
  RVA=0x03CBAB60  token=0x6000386  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09CFF2F4  token=0x6000387  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09CFD034  token=0x6000388  System.Void EnforceContentType()
  RVA=0x02849E50  token=0x6000389  System.Void SetTextComponentWrapMode()
  RVA=0x09CFFBCC  token=0x600038A  System.Void SetTextComponentRichTextMode()
  RVA=0x09CFFC50  token=0x600038B  System.Void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes)
  RVA=0x09CFFCA0  token=0x600038C  System.Void SetToCustom()
  RVA=0x09CFFCA0  token=0x600038D  System.Void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation)
  RVA=0x03C84A00  token=0x600038E  System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant)
  RVA=0x0350B670  token=0x600038F  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x6000390  System.Void CalculateLayoutInputVertical()
  RVA=0x09CFFB1C  token=0x6000398  System.Void SetGlobalPointSize(System.Single pointSize)
  RVA=0x09CFFA6C  token=0x6000399  System.Void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset)
  RVA=0x03CE2E00  token=0x600039A  System.Void .cctor()
  RVA=0x04273A88  token=0x600039B  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: TMPro.SetPropertyUtility
TYPE:  static class
TOKEN: 0x200006B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09CFC4F4  token=0x60003B1  System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue)
  RVA=-1  // generic def  token=0x60003B2  System.Boolean SetEquatableStruct(T& currentValue, T newValue)
  RVA=-1  // generic def  token=0x60003B3  System.Boolean SetStruct(T& currentValue, T newValue)
  RVA=-1  // generic def  token=0x60003B4  System.Boolean SetClass(T& currentValue, T newValue)
END_CLASS

CLASS: TMPro.TMP_InputValidator
TYPE:  abstract class
TOKEN: 0x200006C
SIZE:  0x18
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60003B5  System.Char Validate(System.String& text, System.Int32& pos, System.Char ch)
  RVA=0x0286F540  token=0x60003B6  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_LineInfo
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x6C
FIELDS:
  public            System.Int32                    controlCharacterCount  // 0x10
  public            System.Int32                    characterCount  // 0x14
  public            System.Int32                    visibleCharacterCount  // 0x18
  public            System.Int32                    spaceCount  // 0x1c
  public            System.Int32                    wordCount  // 0x20
  public            System.Int32                    firstCharacterIndex  // 0x24
  public            System.Int32                    firstVisibleCharacterIndex  // 0x28
  public            System.Int32                    lastCharacterIndex  // 0x2c
  public            System.Int32                    lastVisibleCharacterIndex  // 0x30
  public            System.Single                   length  // 0x34
  public            System.Single                   lineHeight  // 0x38
  public            System.Single                   ascender  // 0x3c
  public            System.Single                   baseline  // 0x40
  public            System.Single                   descender  // 0x44
  public            System.Single                   maxAdvance  // 0x48
  public            System.Single                   width  // 0x4c
  public            System.Single                   marginLeft  // 0x50
  public            System.Single                   marginRight  // 0x54
  public            TMPro.HorizontalAlignmentOptionsalignment  // 0x58
  public            TMPro.Extents                   lineExtents  // 0x5c
METHODS:
END_CLASS

CLASS: TMPro.TMP_ListPool`1
TYPE:  static class
TOKEN: 0x200006E
FIELDS:
  private   static readonly TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>>s_ListPool  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60003B7  System.Collections.Generic.List<T> Get()
  RVA=-1  // not resolved  token=0x60003B8  System.Void Release(System.Collections.Generic.List<T> toRelease)
  RVA=-1  // not resolved  token=0x60003B9  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_MaterialManager
TYPE:  static class
TOKEN: 0x2000070
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial>m_materialList  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int64,TMPro.TMP_MaterialManager.FallbackMaterial>m_fallbackMaterials  // static @ 0x8
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Int64>m_fallbackMaterialLookup  // static @ 0x10
  private   static  System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial>m_fallbackCleanupList  // static @ 0x18
  private   static  System.Boolean                  isFallbackListDirty  // static @ 0x20
  private   static  System.String                   s_overlayShaderKeyword  // static @ 0x28
PROPERTIES:
  overlayShaderKeyword  get=0x09D03244  set=0x09D03294
METHODS:
  RVA=0x02CCFFC0  token=0x60003BD  System.Void .cctor()
  RVA=0x031EB540  token=0x60003BE  System.Void OnPreRender()
  RVA=0x09D024C8  token=0x60003C1  UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, System.Int32 stencilID)
  RVA=0x09D02CE4  token=0x60003C2  System.Void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial)
  RVA=0x09D01E08  token=0x60003C3  UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial)
  RVA=0x09D0318C  token=0x60003C4  UnityEngine.Material SetStencil(UnityEngine.Material material, System.Int32 stencilID)
  RVA=0x09D01678  token=0x60003C5  System.Void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, System.Int32 stencilID)
  RVA=0x09D03050  token=0x60003C6  System.Void RemoveStencilMaterial(UnityEngine.Material stencilMaterial)
  RVA=0x09D02840  token=0x60003C7  System.Void ReleaseBaseMaterial(UnityEngine.Material baseMaterial)
  RVA=0x09D018B4  token=0x60003C8  System.Void ClearMaterials()
  RVA=0x09D02274  token=0x60003C9  System.Int32 GetStencilID(UnityEngine.GameObject obj)
  RVA=0x0303D740  token=0x60003CA  UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial)
  RVA=0x09D01CBC  token=0x60003CB  UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start)
  RVA=0x09D01F54  token=0x60003CC  UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, System.Int32 atlasIndex)
  RVA=0x02515160  token=0x60003CD  UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial)
  RVA=0x02514E40  token=0x60003CE  System.Void AddFallbackMaterialReference(UnityEngine.Material targetMaterial)
  RVA=0x09D02ED8  token=0x60003CF  System.Void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial)
  RVA=0x031EB5C0  token=0x60003D0  System.Void CleanupFallbackMaterials()
  RVA=0x02514F80  token=0x60003D1  System.Void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial)
  RVA=0x09D01A24  token=0x60003D2  System.Void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination)
END_CLASS

CLASS: TMPro.VertexSortingOrder
TYPE:  sealed struct
TOKEN: 0x2000077
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.VertexSortingOrder        Normal  // const
  public    static  TMPro.VertexSortingOrder        Reverse  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_MeshInfo
TYPE:  sealed struct
TOKEN: 0x2000078
SIZE:  0x60
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly UnityEngine.Color32             s_DefaultColor  // static @ 0x0
  private   static readonly UnityEngine.Vector3             s_DefaultNormal  // static @ 0x4
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // static @ 0x10
  private   static readonly UnityEngine.Bounds              s_DefaultBounds  // static @ 0x20
  public            UnityEngine.Mesh                mesh  // 0x10
  public            System.Int32                    vertexCount  // 0x18
  public            UnityEngine.Vector3[]           vertices  // 0x20
  public            UnityEngine.Vector3[]           normals  // 0x28
  public            UnityEngine.Vector4[]           tangents  // 0x30
  public            UnityEngine.Vector2[]           uvs0  // 0x38
  public            UnityEngine.Vector2[]           uvs2  // 0x40
  public            UnityEngine.Color32[]           colors32  // 0x48
  public            System.Int32[]                  triangles  // 0x50
  public            UnityEngine.Material            material  // 0x58
METHODS:
  RVA=0x02573C50  token=0x60003DD  System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size)
  RVA=0x09D10A74  token=0x60003DE  System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size, System.Boolean isVolumetric)
  RVA=0x0285BE00  token=0x60003DF  System.Void ResizeMeshInfo(System.Int32 size)
  RVA=0x09D0F520  token=0x60003E0  System.Void ResizeMeshInfo(System.Int32 size, System.Boolean isVolumetric)
  RVA=0x09D0F490  token=0x60003E1  System.Void Clear()
  RVA=0x022D4100  token=0x60003E2  System.Void Clear(System.Boolean uploadChanges)
  RVA=0x03B22710  token=0x60003E3  System.Void ClearUnusedVertices()
  RVA=0x09D0F3B4  token=0x60003E4  System.Void ClearUnusedVertices(System.Int32 startIndex)
  RVA=0x09D0F3E8  token=0x60003E5  System.Void ClearUnusedVertices(System.Int32 startIndex, System.Boolean updateMesh)
  RVA=0x09D10084  token=0x60003E6  System.Void SortGeometry(TMPro.VertexSortingOrder order)
  RVA=0x09D10128  token=0x60003E7  System.Void SortGeometry(System.Collections.Generic.IList<System.Int32> sortingOrder)
  RVA=0x09D10224  token=0x60003E8  System.Void SwapVertexData(System.Int32 src, System.Int32 dst)
  RVA=0x0285E6F0  token=0x60003E9  System.Void Dispose()
  RVA=0x03CA9010  token=0x60003EA  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_ObjectPool`1
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>m_Stack  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnGet  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnRelease  // 0x0
  private           System.Int32                    <countAll>k__BackingField  // 0x0
PROPERTIES:
  countAll  get=-1  // not resolved  set=-1  // not resolved
  countActive  get=-1  // not resolved
  countInactive  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60003EF  System.Void .ctor(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease)
  RVA=-1  // not resolved  token=0x60003F0  T Get()
  RVA=-1  // not resolved  token=0x60003F1  System.Void Release(T element)
END_CLASS

CLASS: TMPro.TMP_ResourceManager
TYPE:  class
TOKEN: 0x200007A
SIZE:  0x10
FIELDS:
  private   static readonly TMPro.TMP_ResourceManager       s_instance  // static @ 0x0
  private   static  TMPro.TMP_Settings              s_TextSettings  // static @ 0x8
  private   static readonly System.Collections.Generic.List<TMPro.TMP_FontAsset>s_FontAssetReferences  // static @ 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset>s_FontAssetReferenceLookup  // static @ 0x18
METHODS:
  RVA=0x09D117A4  token=0x60003F2  System.Void .cctor()
  RVA=0x09D11538  token=0x60003F3  TMPro.TMP_Settings GetTextSettings()
  RVA=0x09D1143C  token=0x60003F4  System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09D1171C  token=0x60003F5  System.Boolean TryGetFontAsset(System.Int32 hashcode, TMPro.TMP_FontAsset& fontAsset)
  RVA=0x09D11628  token=0x60003F6  System.Void RebuildFontAssetCache(System.Int32 instanceID)
  RVA=0x0350B670  token=0x60003F7  System.Void .ctor()
END_CLASS

CLASS: TMPro.MarkupTag
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MarkupTag                 BOLD  // const
  public    static  TMPro.MarkupTag                 SLASH_BOLD  // const
  public    static  TMPro.MarkupTag                 ITALIC  // const
  public    static  TMPro.MarkupTag                 SLASH_ITALIC  // const
  public    static  TMPro.MarkupTag                 UNDERLINE  // const
  public    static  TMPro.MarkupTag                 SLASH_UNDERLINE  // const
  public    static  TMPro.MarkupTag                 STRIKETHROUGH  // const
  public    static  TMPro.MarkupTag                 SLASH_STRIKETHROUGH  // const
  public    static  TMPro.MarkupTag                 MARK  // const
  public    static  TMPro.MarkupTag                 SLASH_MARK  // const
  public    static  TMPro.MarkupTag                 SUBSCRIPT  // const
  public    static  TMPro.MarkupTag                 SLASH_SUBSCRIPT  // const
  public    static  TMPro.MarkupTag                 SUPERSCRIPT  // const
  public    static  TMPro.MarkupTag                 SLASH_SUPERSCRIPT  // const
  public    static  TMPro.MarkupTag                 COLOR  // const
  public    static  TMPro.MarkupTag                 SLASH_COLOR  // const
  public    static  TMPro.MarkupTag                 ALPHA  // const
  public    static  TMPro.MarkupTag                 A  // const
  public    static  TMPro.MarkupTag                 SLASH_A  // const
  public    static  TMPro.MarkupTag                 SIZE  // const
  public    static  TMPro.MarkupTag                 SLASH_SIZE  // const
  public    static  TMPro.MarkupTag                 SPRITE  // const
  public    static  TMPro.MarkupTag                 NO_BREAK  // const
  public    static  TMPro.MarkupTag                 SLASH_NO_BREAK  // const
  public    static  TMPro.MarkupTag                 STYLE  // const
  public    static  TMPro.MarkupTag                 SLASH_STYLE  // const
  public    static  TMPro.MarkupTag                 FONT  // const
  public    static  TMPro.MarkupTag                 SLASH_FONT  // const
  public    static  TMPro.MarkupTag                 SLASH_MATERIAL  // const
  public    static  TMPro.MarkupTag                 LINK  // const
  public    static  TMPro.MarkupTag                 SLASH_LINK  // const
  public    static  TMPro.MarkupTag                 FONT_WEIGHT  // const
  public    static  TMPro.MarkupTag                 SLASH_FONT_WEIGHT  // const
  public    static  TMPro.MarkupTag                 NO_PARSE  // const
  public    static  TMPro.MarkupTag                 SLASH_NO_PARSE  // const
  public    static  TMPro.MarkupTag                 POSITION  // const
  public    static  TMPro.MarkupTag                 SLASH_POSITION  // const
  public    static  TMPro.MarkupTag                 VERTICAL_OFFSET  // const
  public    static  TMPro.MarkupTag                 SLASH_VERTICAL_OFFSET  // const
  public    static  TMPro.MarkupTag                 SPACE  // const
  public    static  TMPro.MarkupTag                 SLASH_SPACE  // const
  public    static  TMPro.MarkupTag                 PAGE  // const
  public    static  TMPro.MarkupTag                 SLASH_PAGE  // const
  public    static  TMPro.MarkupTag                 ALIGN  // const
  public    static  TMPro.MarkupTag                 SLASH_ALIGN  // const
  public    static  TMPro.MarkupTag                 WIDTH  // const
  public    static  TMPro.MarkupTag                 SLASH_WIDTH  // const
  public    static  TMPro.MarkupTag                 GRADIENT  // const
  public    static  TMPro.MarkupTag                 SLASH_GRADIENT  // const
  public    static  TMPro.MarkupTag                 CHARACTER_SPACE  // const
  public    static  TMPro.MarkupTag                 SLASH_CHARACTER_SPACE  // const
  public    static  TMPro.MarkupTag                 MONOSPACE  // const
  public    static  TMPro.MarkupTag                 SLASH_MONOSPACE  // const
  public    static  TMPro.MarkupTag                 CLASS  // const
  public    static  TMPro.MarkupTag                 INDENT  // const
  public    static  TMPro.MarkupTag                 SLASH_INDENT  // const
  public    static  TMPro.MarkupTag                 LINE_INDENT  // const
  public    static  TMPro.MarkupTag                 SLASH_LINE_INDENT  // const
  public    static  TMPro.MarkupTag                 MARGIN  // const
  public    static  TMPro.MarkupTag                 SLASH_MARGIN  // const
  public    static  TMPro.MarkupTag                 MARGIN_LEFT  // const
  public    static  TMPro.MarkupTag                 MARGIN_RIGHT  // const
  public    static  TMPro.MarkupTag                 LINE_HEIGHT  // const
  public    static  TMPro.MarkupTag                 SLASH_LINE_HEIGHT  // const
  public    static  TMPro.MarkupTag                 ACTION  // const
  public    static  TMPro.MarkupTag                 SLASH_ACTION  // const
  public    static  TMPro.MarkupTag                 SCALE  // const
  public    static  TMPro.MarkupTag                 SLASH_SCALE  // const
  public    static  TMPro.MarkupTag                 ROTATE  // const
  public    static  TMPro.MarkupTag                 SLASH_ROTATE  // const
  public    static  TMPro.MarkupTag                 LOWERCASE  // const
  public    static  TMPro.MarkupTag                 SLASH_LOWERCASE  // const
  public    static  TMPro.MarkupTag                 ALLCAPS  // const
  public    static  TMPro.MarkupTag                 SLASH_ALLCAPS  // const
  public    static  TMPro.MarkupTag                 UPPERCASE  // const
  public    static  TMPro.MarkupTag                 SLASH_UPPERCASE  // const
  public    static  TMPro.MarkupTag                 SMALLCAPS  // const
  public    static  TMPro.MarkupTag                 SLASH_SMALLCAPS  // const
  public    static  TMPro.MarkupTag                 LIGA  // const
  public    static  TMPro.MarkupTag                 SLASH_LIGA  // const
  public    static  TMPro.MarkupTag                 FRAC  // const
  public    static  TMPro.MarkupTag                 SLASH_FRAC  // const
  public    static  TMPro.MarkupTag                 NAME  // const
  public    static  TMPro.MarkupTag                 INDEX  // const
  public    static  TMPro.MarkupTag                 TINT  // const
  public    static  TMPro.MarkupTag                 ANIM  // const
  public    static  TMPro.MarkupTag                 MATERIAL  // const
  public    static  TMPro.MarkupTag                 HREF  // const
  public    static  TMPro.MarkupTag                 ANGLE  // const
  public    static  TMPro.MarkupTag                 RED  // const
  public    static  TMPro.MarkupTag                 GREEN  // const
  public    static  TMPro.MarkupTag                 BLUE  // const
  public    static  TMPro.MarkupTag                 YELLOW  // const
  public    static  TMPro.MarkupTag                 ORANGE  // const
  public    static  TMPro.MarkupTag                 BLACK  // const
  public    static  TMPro.MarkupTag                 WHITE  // const
  public    static  TMPro.MarkupTag                 PURPLE  // const
  public    static  TMPro.MarkupTag                 BR  // const
  public    static  TMPro.MarkupTag                 ZWSP  // const
  public    static  TMPro.MarkupTag                 NBSP  // const
  public    static  TMPro.MarkupTag                 SHY  // const
  public    static  TMPro.MarkupTag                 LEFT  // const
  public    static  TMPro.MarkupTag                 RIGHT  // const
  public    static  TMPro.MarkupTag                 CENTER  // const
  public    static  TMPro.MarkupTag                 JUSTIFIED  // const
  public    static  TMPro.MarkupTag                 FLUSH  // const
  public    static  TMPro.MarkupTag                 NONE  // const
  public    static  TMPro.MarkupTag                 PLUS  // const
  public    static  TMPro.MarkupTag                 MINUS  // const
  public    static  TMPro.MarkupTag                 PX  // const
  public    static  TMPro.MarkupTag                 PLUS_PX  // const
  public    static  TMPro.MarkupTag                 MINUS_PX  // const
  public    static  TMPro.MarkupTag                 EM  // const
  public    static  TMPro.MarkupTag                 PLUS_EM  // const
  public    static  TMPro.MarkupTag                 MINUS_EM  // const
  public    static  TMPro.MarkupTag                 PCT  // const
  public    static  TMPro.MarkupTag                 PLUS_PCT  // const
  public    static  TMPro.MarkupTag                 MINUS_PCT  // const
  public    static  TMPro.MarkupTag                 PERCENTAGE  // const
  public    static  TMPro.MarkupTag                 PLUS_PERCENTAGE  // const
  public    static  TMPro.MarkupTag                 MINUS_PERCENTAGE  // const
  public    static  TMPro.MarkupTag                 TRUE  // const
  public    static  TMPro.MarkupTag                 FALSE  // const
  public    static  TMPro.MarkupTag                 INVALID  // const
  public    static  TMPro.MarkupTag                 NORMAL  // const
  public    static  TMPro.MarkupTag                 DEFAULT  // const
METHODS:
END_CLASS

CLASS: TMPro.TagValueType
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TagValueType              None  // const
  public    static  TMPro.TagValueType              NumericalValue  // const
  public    static  TMPro.TagValueType              StringValue  // const
  public    static  TMPro.TagValueType              ColorValue  // const
METHODS:
END_CLASS

CLASS: TMPro.TagUnitType
TYPE:  sealed struct
TOKEN: 0x200007D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TagUnitType               Pixels  // const
  public    static  TMPro.TagUnitType               FontUnits  // const
  public    static  TMPro.TagUnitType               Percentage  // const
METHODS:
END_CLASS

CLASS: TMPro.CodePoint
TYPE:  static class
TOKEN: 0x200007E
SIZE:  0x10
FIELDS:
  public    static  System.UInt32                   SPACE  // const
  public    static  System.UInt32                   DOUBLE_QUOTE  // const
  public    static  System.UInt32                   NUMBER_SIGN  // const
  public    static  System.UInt32                   PERCENTAGE  // const
  public    static  System.UInt32                   PLUS  // const
  public    static  System.UInt32                   MINUS  // const
  public    static  System.UInt32                   PERIOD  // const
  public    static  System.UInt32                   HYPHEN_MINUS  // const
  public    static  System.UInt32                   SOFT_HYPHEN  // const
  public    static  System.UInt32                   HYPHEN  // const
  public    static  System.UInt32                   NON_BREAKING_HYPHEN  // const
  public    static  System.UInt32                   ZERO_WIDTH_SPACE  // const
  public    static  System.UInt32                   RIGHT_SINGLE_QUOTATION  // const
  public    static  System.UInt32                   APOSTROPHE  // const
  public    static  System.UInt32                   WORD_JOINER  // const
  public    static  System.UInt32                   HIGH_SURROGATE_START  // const
  public    static  System.UInt32                   HIGH_SURROGATE_END  // const
  public    static  System.UInt32                   LOW_SURROGATE_START  // const
  public    static  System.UInt32                   LOW_SURROGATE_END  // const
  public    static  System.UInt32                   UNICODE_PLANE01_START  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_ScrollbarEventHandler
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ISelectHandler UnityEngine.EventSystems.IDeselectHandler
FIELDS:
  public            System.Boolean                  isSelected  // 0x18
METHODS:
  RVA=0x09D11930  token=0x60003F8  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09D11984  token=0x60003F9  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09D118D8  token=0x60003FA  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0426FE60  token=0x60003FB  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SelectionCaret
TYPE:  class
TOKEN: 0x2000080
SIZE:  0xE8
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
METHODS:
  RVA=0x02C6F1D0  token=0x60003FC  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=0x0350B670  token=0x60003FD  System.Void UpdateGeometry()
  RVA=0x03D4C420  token=0x60003FE  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Settings
TYPE:  class
TOKEN: 0x2000081
SIZE:  0xC0
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private   static  TMPro.TMP_Settings              s_Instance  // static @ 0x0
  private           System.Boolean                  m_enableWordWrapping  // 0x18
  private           System.Boolean                  m_enableKerning  // 0x19
  private           System.Boolean                  m_enableExtraPadding  // 0x1a
  private           System.Boolean                  m_enableTintAllSprites  // 0x1b
  private           System.Boolean                  m_enableParseEscapeCharacters  // 0x1c
  private           System.Boolean                  m_EnableRaycastTarget  // 0x1d
  private           System.Boolean                  m_GetFontFeaturesAtRuntime  // 0x1e
  private           System.Int32                    m_missingGlyphCharacter  // 0x20
  private           System.Boolean                  m_warningsDisabled  // 0x24
  private           TMPro.TMP_FontAsset             m_defaultFontAsset  // 0x28
  private           System.String                   m_defaultFontAssetPath  // 0x30
  private           System.Single                   m_defaultFontSize  // 0x38
  private           System.Single                   m_defaultAutoSizeMinRatio  // 0x3c
  private           System.Single                   m_defaultAutoSizeMaxRatio  // 0x40
  private           UnityEngine.Vector2             m_defaultTextMeshProTextContainerSize  // 0x44
  private           UnityEngine.Vector2             m_defaultTextMeshProUITextContainerSize  // 0x4c
  private           System.Boolean                  m_autoSizeTextContainer  // 0x54
  private           System.Boolean                  m_IsTextObjectScaleStatic  // 0x55
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>m_fallbackFontAssets  // 0x58
  private           System.Boolean                  m_matchMaterialPreset  // 0x60
  private           TMPro.TMP_SpriteAsset           m_defaultSpriteAsset  // 0x68
  private           System.String                   m_defaultSpriteAssetPath  // 0x70
  private           System.Boolean                  m_enableEmojiSupport  // 0x78
  private           System.UInt32                   m_MissingCharacterSpriteUnicode  // 0x7c
  private           System.String                   m_defaultColorGradientPresetsPath  // 0x80
  private           TMPro.TMP_StyleSheet            m_defaultStyleSheet  // 0x88
  private           System.String                   m_StyleSheetsResourcePath  // 0x90
  private           UnityEngine.TextAsset           m_leadingCharacters  // 0x98
  private           UnityEngine.TextAsset           m_followingCharacters  // 0xa0
  private           TMPro.TMP_Settings.LineBreakingTablem_linebreakingRules  // 0xa8
  private           System.Boolean                  m_UseModernHangulLineBreakingRules  // 0xb0
  public            TMPro.IFontAssetLoader          dynamicFontAssetLoader  // 0xb8
PROPERTIES:
  version  get=0x09D120E0
  enableWordWrapping  get=0x09D11FB0
  enableKerning  get=0x09D11F30
  enableExtraPadding  get=0x09D11F10
  enableTintAllSprites  get=0x09D11F90
  enableParseEscapeCharacters  get=0x09D11F50
  enableRaycastTarget  get=0x09D11F70
  getFontFeaturesAtRuntime  get=0x02EE7BF0
  missingGlyphCharacter  get=0x09D12078  set=0x09D12198
  warningsDisabled  get=0x09D1210C
  defaultFontAsset  get=0x09D11DD0
  defaultFontAssetPath  get=0x09D11DB0
  defaultFontSize  get=0x09D11DF0
  defaultTextAutoSizingMinRatio  get=0x09D11E70
  defaultTextAutoSizingMaxRatio  get=0x09D11E50
  defaultTextMeshProTextContainerSize  get=0x09D11E90
  defaultTextMeshProUITextContainerSize  get=0x09D11EC0
  autoSizeTextContainer  get=0x09D11D6C
  isTextObjectScaleStatic  get=0x09D12014  set=0x09D12150
  fallbackFontAssets  get=0x09D11FD0
  matchMaterialPreset  get=0x039CD010
  defaultSpriteAsset  get=0x09D11E30
  defaultSpriteAssetPath  get=0x09D11E10
  enableEmojiSupport  get=0x09D11EF0  set=0x09D1212C
  missingCharacterSpriteUnicode  get=0x09D12058  set=0x09D12174
  defaultColorGradientPresetsPath  get=0x09D11D8C
  defaultStyleSheet  get=0x0296C8B0
  styleSheetsResourcePath  get=0x09D12098
  leadingCharacters  get=0x09D12034
  followingCharacters  get=0x09D11FF0
  linebreakingRules  get=0x0296C8E0
  useModernHangulLineBreakingRules  get=0x09D120BC  set=0x09D121BC
  instance  get=0x0296C930
METHODS:
  RVA=0x09D11C88  token=0x6000425  TMPro.TMP_Settings LoadDefaultSettings()
  RVA=0x09D11B50  token=0x6000426  TMPro.TMP_Settings GetSettings()
  RVA=0x09D11AE4  token=0x6000427  TMPro.TMP_FontAsset GetFontAsset()
  RVA=0x09D119DC  token=0x6000428  System.Void ClearDefaultFontAsset()
  RVA=0x09D11BB0  token=0x6000429  TMPro.TMP_SpriteAsset GetSpriteAsset()
  RVA=0x09D11C1C  token=0x600042A  TMPro.TMP_StyleSheet GetStyleSheet()
  RVA=0x034A2F60  token=0x600042B  System.Void LoadLinebreakingRules()
  RVA=0x09D11A78  token=0x600042C  TMPro.IFontAssetLoader GetDynamicFallbackFontAssetLoader()
  RVA=0x034A30B0  token=0x600042D  System.Collections.Generic.Dictionary<System.Int32,System.Char> GetCharacters(UnityEngine.TextAsset file)
  RVA=0x03D4CDA0  token=0x600042E  System.Void .ctor()
END_CLASS

CLASS: TMPro.ShaderUtilities
TYPE:  static class
TOKEN: 0x2000083
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    ID_MainTex  // static @ 0x0
  public    static  System.Int32                    ID_FaceTex  // static @ 0x4
  public    static  System.Int32                    ID_FaceColor  // static @ 0x8
  public    static  System.Int32                    ID_FaceDilate  // static @ 0xc
  public    static  System.Int32                    ID_Shininess  // static @ 0x10
  public    static  System.Int32                    ID_UnderlayColor  // static @ 0x14
  public    static  System.Int32                    ID_UnderlayOffsetX  // static @ 0x18
  public    static  System.Int32                    ID_UnderlayOffsetY  // static @ 0x1c
  public    static  System.Int32                    ID_UnderlayDilate  // static @ 0x20
  public    static  System.Int32                    ID_UnderlaySoftness  // static @ 0x24
  public    static  System.Int32                    ID_UnderlayOffset  // static @ 0x28
  public    static  System.Int32                    ID_UnderlayIsoPerimeter  // static @ 0x2c
  public    static  System.Int32                    ID_WeightNormal  // static @ 0x30
  public    static  System.Int32                    ID_WeightBold  // static @ 0x34
  public    static  System.Int32                    ID_OutlineTex  // static @ 0x38
  public    static  System.Int32                    ID_OutlineWidth  // static @ 0x3c
  public    static  System.Int32                    ID_OutlineSoftness  // static @ 0x40
  public    static  System.Int32                    ID_OutlineColor  // static @ 0x44
  public    static  System.Int32                    ID_Outline2Color  // static @ 0x48
  public    static  System.Int32                    ID_Outline2Width  // static @ 0x4c
  public    static  System.Int32                    ID_Padding  // static @ 0x50
  public    static  System.Int32                    ID_GradientScale  // static @ 0x54
  public    static  System.Int32                    ID_ScaleX  // static @ 0x58
  public    static  System.Int32                    ID_ScaleY  // static @ 0x5c
  public    static  System.Int32                    ID_PerspectiveFilter  // static @ 0x60
  public    static  System.Int32                    ID_Sharpness  // static @ 0x64
  public    static  System.Int32                    ID_TextureWidth  // static @ 0x68
  public    static  System.Int32                    ID_TextureHeight  // static @ 0x6c
  public    static  System.Int32                    ID_BevelAmount  // static @ 0x70
  public    static  System.Int32                    ID_GlowColor  // static @ 0x74
  public    static  System.Int32                    ID_GlowOffset  // static @ 0x78
  public    static  System.Int32                    ID_GlowPower  // static @ 0x7c
  public    static  System.Int32                    ID_GlowOuter  // static @ 0x80
  public    static  System.Int32                    ID_GlowInner  // static @ 0x84
  public    static  System.Int32                    ID_LightAngle  // static @ 0x88
  public    static  System.Int32                    ID_EnvMap  // static @ 0x8c
  public    static  System.Int32                    ID_EnvMatrix  // static @ 0x90
  public    static  System.Int32                    ID_EnvMatrixRotation  // static @ 0x94
  public    static  System.Int32                    ID_MaskCoord  // static @ 0x98
  public    static  System.Int32                    ID_ClipRect  // static @ 0x9c
  public    static  System.Int32                    ID_MaskSoftnessX  // static @ 0xa0
  public    static  System.Int32                    ID_MaskSoftnessY  // static @ 0xa4
  public    static  System.Int32                    ID_VertexOffsetX  // static @ 0xa8
  public    static  System.Int32                    ID_VertexOffsetY  // static @ 0xac
  public    static  System.Int32                    ID_UseClipRect  // static @ 0xb0
  public    static  System.Int32                    ID_StencilID  // static @ 0xb4
  public    static  System.Int32                    ID_StencilOp  // static @ 0xb8
  public    static  System.Int32                    ID_StencilComp  // static @ 0xbc
  public    static  System.Int32                    ID_StencilReadMask  // static @ 0xc0
  public    static  System.Int32                    ID_StencilWriteMask  // static @ 0xc4
  public    static  System.Int32                    ID_ShaderFlags  // static @ 0xc8
  public    static  System.Int32                    ID_ScaleRatio_A  // static @ 0xcc
  public    static  System.Int32                    ID_ScaleRatio_B  // static @ 0xd0
  public    static  System.Int32                    ID_ScaleRatio_C  // static @ 0xd4
  public    static  System.Int32                    ID_UseClipSceneDepth  // static @ 0xd8
  public    static  System.Int32                    ID_UsedForWorldUI  // static @ 0xdc
  public    static  System.String                   Keyword_ClipSceneDepth  // static @ 0xe0
  public    static  System.String                   Keyword_UsedForWorldUI  // static @ 0xe8
  public    static  System.String                   Keyword_Bevel  // static @ 0xf0
  public    static  System.String                   Keyword_Glow  // static @ 0xf8
  public    static  System.String                   Keyword_Underlay  // static @ 0x100
  public    static  System.String                   Keyword_Ratios  // static @ 0x108
  public    static  System.String                   Keyword_MASK_SOFT  // static @ 0x110
  public    static  System.String                   Keyword_MASK_HARD  // static @ 0x118
  public    static  System.String                   Keyword_MASK_TEX  // static @ 0x120
  public    static  System.String                   Keyword_Outline  // static @ 0x128
  public    static  System.String                   ShaderTag_ZTestMode  // static @ 0x130
  public    static  System.String                   ShaderTag_CullMode  // static @ 0x138
  private   static  System.Single                   m_clamp  // static @ 0x140
  public    static  System.Boolean                  isInitialized  // static @ 0x144
  private   static  UnityEngine.Shader              k_ShaderRef_MobileSDF  // static @ 0x148
  private   static  UnityEngine.Shader              k_ShaderRef_MobileBitmap  // static @ 0x150
PROPERTIES:
  ShaderRef_MobileSDF  get=0x09D0F12C
  ShaderRef_MobileBitmap  get=0x09D0F040
METHODS:
  RVA=0x029687E0  token=0x6000432  System.Void .cctor()
  RVA=0x02969CE0  token=0x6000433  System.Void GetShaderPropertyIDs()
  RVA=0x028024F0  token=0x6000434  System.Void UpdateShaderRatios(UnityEngine.Material mat)
  RVA=0x09D0E594  token=0x6000435  UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material)
  RVA=0x02800F50  token=0x6000436  System.Boolean IsMaskingEnabled(UnityEngine.Material material)
  RVA=0x02801820  token=0x6000437  System.Single GetPadding(UnityEngine.Material material, System.Boolean enableExtraPadding, System.Boolean isBold)
  RVA=0x09D0E5B4  token=0x6000438  System.Single GetPadding(UnityEngine.Material[] materials, System.Boolean enableExtraPadding, System.Boolean isBold)
END_CLASS

CLASS: TMPro.TMP_Sprite
TYPE:  class
TOKEN: 0x2000084
SIZE:  0x58
EXTENDS: TMPro.TMP_TextElement_Legacy
FIELDS:
  public            System.String                   name  // 0x38
  public            System.Int32                    hashCode  // 0x40
  public            System.Int32                    unicode  // 0x44
  public            UnityEngine.Vector2             pivot  // 0x48
  public            UnityEngine.Sprite              sprite  // 0x50
METHODS:
  RVA=0x0350B670  token=0x6000439  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteAnimator
TYPE:  class
TOKEN: 0x2000085
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_animations  // 0x18
  private           TMPro.TMP_Text                  m_TextComponent  // 0x20
METHODS:
  RVA=0x09D121E4  token=0x600043A  System.Void Awake()
  RVA=0x0350B670  token=0x600043B  System.Void OnEnable()
  RVA=0x0350B670  token=0x600043C  System.Void OnDisable()
  RVA=0x09D123A8  token=0x600043D  System.Void StopAllAnimations()
  RVA=0x09D122D0  token=0x600043E  System.Void DoSpriteAnimation(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate)
  RVA=0x09D1222C  token=0x600043F  System.Collections.IEnumerator DoSpriteAnimationInternal(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate)
  RVA=0x09D123F8  token=0x6000440  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteAsset
TYPE:  class
TOKEN: 0x2000087
SIZE:  0xE8
EXTENDS: TMPro.TMP_Asset
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_NameLookup  // 0x30
  private           System.Collections.Generic.Dictionary<System.UInt32,System.Int32>m_GlyphIndexLookup  // 0x38
  private           System.String                   m_Version  // 0x40
  private           UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x48
  public            UnityEngine.Texture             spriteSheet  // 0xa8
  private           System.Collections.Generic.List<TMPro.TMP_SpriteCharacter>m_SpriteCharacterTable  // 0xb0
  private           System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter>m_SpriteCharacterLookup  // 0xb8
  private           System.Collections.Generic.List<TMPro.TMP_SpriteGlyph>m_SpriteGlyphTable  // 0xc0
  private           System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteGlyph>m_SpriteGlyphLookup  // 0xc8
  public            System.Collections.Generic.List<TMPro.TMP_Sprite>spriteInfoList  // 0xd0
  public            System.Collections.Generic.List<TMPro.TMP_SpriteAsset>fallbackSpriteAssets  // 0xd8
  private           System.Boolean                  m_IsSpriteAssetLookupTablesDirty  // 0xe0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_searchedSpriteAssets  // static @ 0x0
PROPERTIES:
  version  get=0x03D4E2B0  set=0x03CB2D80
  faceInfo  get=0x03D85440  set=0x09D13D0C
  spriteCharacterTable  get=0x09D13CDC  set=0x02B47080
  spriteCharacterLookupTable  get=0x09D13CAC  set=0x058AAF64
  spriteGlyphTable  get=0x03D50E60  set=0x058B426C
METHODS:
  RVA=0x09D1247C  token=0x6000451  System.Void Awake()
  RVA=0x09D124EC  token=0x6000452  UnityEngine.Material GetDefaultSpriteMaterial()
  RVA=0x09D1336C  token=0x6000453  System.Void UpdateLookupTables()
  RVA=0x09D125C4  token=0x6000454  System.Int32 GetSpriteIndexFromHashcode(System.Int32 hashCode)
  RVA=0x09D126AC  token=0x6000455  System.Int32 GetSpriteIndexFromUnicode(System.UInt32 unicode)
  RVA=0x09D12640  token=0x6000456  System.Int32 GetSpriteIndexFromName(System.String name)
  RVA=0x09D12E5C  token=0x6000457  TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  RVA=0x09D12C54  token=0x6000458  TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  RVA=0x09D12DAC  token=0x6000459  TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  RVA=0x09D12940  token=0x600045A  TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  RVA=0x09D127E8  token=0x600045B  TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  RVA=0x09D12738  token=0x600045C  TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  RVA=0x09D13200  token=0x600045D  System.Void SortGlyphTable()
  RVA=0x09D13074  token=0x600045E  System.Void SortCharacterTable()
  RVA=0x09D131E0  token=0x600045F  System.Void SortGlyphAndCharacterTables()
  RVA=0x09D138A8  token=0x6000460  System.Void UpgradeSpriteAsset()
  RVA=0x09D13BD8  token=0x6000461  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteCharacter
TYPE:  class
TOKEN: 0x2000089
SIZE:  0x40
EXTENDS: TMPro.TMP_TextElement
FIELDS:
  private           System.String                   m_Name  // 0x30
  private           System.Int32                    m_HashCode  // 0x38
PROPERTIES:
  name  get=0x01003830  set=0x09D13E10
  hashCode  get=0x03D4EC30
METHODS:
  RVA=0x03D85480  token=0x6000469  System.Void .ctor()
  RVA=0x09D13D8C  token=0x600046A  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteGlyph glyph)
  RVA=0x09D13DC8  token=0x600046B  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph)
  RVA=0x09D13D4C  token=0x600046C  System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex)
END_CLASS

CLASS: TMPro.TMP_SpriteGlyph
TYPE:  class
TOKEN: 0x200008A
SIZE:  0x50
EXTENDS: UnityEngine.TextCore.Glyph
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x48
METHODS:
  RVA=0x09D13F64  token=0x600046D  System.Void .ctor()
  RVA=0x09D13EFC  token=0x600046E  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex)
  RVA=0x09D13E84  token=0x600046F  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex, UnityEngine.Sprite sprite)
END_CLASS

CLASS: TMPro.TMP_Style
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x50
FIELDS:
  private   static  TMPro.TMP_Style                 k_NormalStyle  // static @ 0x0
  private           System.String                   m_Name  // 0x10
  private           System.Int32                    m_HashCode  // 0x18
  private           System.String                   m_OpeningDefinition  // 0x20
  private           System.String                   m_ClosingDefinition  // 0x28
  private           System.Int32[]                  m_OpeningTagArray  // 0x30
  private           System.Int32[]                  m_ClosingTagArray  // 0x38
  private           System.UInt32[]                 m_OpeningTagUnicodeArray  // 0x40
  private           System.UInt32[]                 m_ClosingTagUnicodeArray  // 0x48
PROPERTIES:
  NormalStyle  get=0x09D14010
  name  get=0x020B7B20  set=0x09D140F8
  hashCode  get=0x020D1AC0  set=0x09D140EC
  styleOpeningDefinition  get=0x03D4EB40
  styleClosingDefinition  get=0x03D4EAC0
  styleOpeningTagArray  get=0x01003830
  styleClosingTagArray  get=0x03D4E2A0
METHODS:
  RVA=0x03302030  token=0x6000479  System.Void .ctor(System.String styleName, System.String styleOpeningDefinition, System.String styleClosingDefinition)
  RVA=0x033023B0  token=0x600047A  System.Void RefreshStyle()
END_CLASS

CLASS: TMPro.TMP_StyleSheet
TYPE:  class
TOKEN: 0x200008C
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_Style>m_StyleList  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Style>m_StyleLookupDictionary  // 0x20
PROPERTIES:
  styles  get=0x01041090
METHODS:
  RVA=0x09D14008  token=0x600047C  System.Void Reset()
  RVA=0x0296CAA0  token=0x600047D  TMPro.TMP_Style GetStyle(System.Int32 hashCode)
  RVA=0x09D13F6C  token=0x600047E  TMPro.TMP_Style GetStyle(System.String name)
  RVA=0x09D14008  token=0x600047F  System.Void RefreshStyles()
  RVA=0x033020E0  token=0x6000480  System.Void LoadStyleDictionaryInternal()
  RVA=0x03CEEF90  token=0x6000481  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SubMesh
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x78
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x18
  private           TMPro.TMP_SpriteAsset           m_spriteAsset  // 0x20
  private           UnityEngine.Material            m_material  // 0x28
  private           UnityEngine.Material            m_sharedMaterial  // 0x30
  private           UnityEngine.Material            m_fallbackMaterial  // 0x38
  private           UnityEngine.Material            m_fallbackSourceMaterial  // 0x40
  private           System.Boolean                  m_isDefaultMaterial  // 0x48
  private           System.Single                   m_padding  // 0x4c
  private           UnityEngine.Renderer            m_renderer  // 0x50
  private           UnityEngine.MeshFilter          m_meshFilter  // 0x58
  private           UnityEngine.Mesh                m_mesh  // 0x60
  private           TMPro.TextMeshPro               m_TextComponent  // 0x68
  private           System.Boolean                  m_isRegisteredForEvents  // 0x70
PROPERTIES:
  fontAsset  get=0x01041090  set=0x022C3A90
  spriteAsset  get=0x03D4EB40  set=0x04271930
  material  get=0x09D152F4  set=0x09D156B0
  sharedMaterial  get=0x01003830  set=0x09D15740
  fallbackMaterial  get=0x03D4E2A0  set=0x09D155A8
  fallbackSourceMaterial  get=0x03D4E2B0  set=0x03CB2D80
  isDefaultMaterial  get=0x03D4EFE0  set=0x03D4F010
  padding  get=0x03D50200  set=0x03D5E680
  renderer  get=0x09D154A0
  meshFilter  get=0x09D15300
  mesh  get=0x09D153F4  set=0x039274B0
  textComponent  get=0x09D15524
METHODS:
  RVA=0x09D146E0  token=0x6000497  TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference)
  RVA=0x09D14F48  token=0x6000498  System.Void OnEnable()
  RVA=0x09D14EA4  token=0x6000499  System.Void OnDisable()
  RVA=0x09D14D8C  token=0x600049A  System.Void OnDestroy()
  RVA=0x09D14AF4  token=0x600049B  System.Void DestroySelf()
  RVA=0x09D14B4C  token=0x600049C  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  RVA=0x09D14A40  token=0x600049D  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  RVA=0x09D14CF8  token=0x600049E  UnityEngine.Material GetSharedMaterial()
  RVA=0x09D15054  token=0x600049F  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x09D14C78  token=0x60004A0  System.Single GetPaddingForMaterial()
  RVA=0x09D15280  token=0x60004A1  System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold)
  RVA=0x09D15088  token=0x60004A2  System.Void SetVerticesDirty()
  RVA=0x09D1504C  token=0x60004A3  System.Void SetMaterialDirty()
  RVA=0x09D15118  token=0x60004A4  System.Void UpdateMaterial()
  RVA=0x0426FE60  token=0x60004A5  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SubMeshUI
TYPE:  class
TOKEN: 0x200008E
SIZE:  0x140
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0xe8
  private           TMPro.TMP_SpriteAsset           m_spriteAsset  // 0xf0
  private           UnityEngine.Material            m_material  // 0xf8
  private           UnityEngine.Material            m_sharedMaterial  // 0x100
  private           UnityEngine.Material            m_fallbackMaterial  // 0x108
  private           UnityEngine.Material            m_fallbackSourceMaterial  // 0x110
  private           System.Boolean                  m_isDefaultMaterial  // 0x118
  private           System.Single                   m_padding  // 0x11c
  private           UnityEngine.Mesh                m_mesh  // 0x120
  private           TMPro.TextMeshProUGUI           m_TextComponent  // 0x128
  private           System.Boolean                  m_isRegisteredForEvents  // 0x130
  private           System.Boolean                  m_materialDirty  // 0x131
  private           System.Int32                    m_materialReferenceIndex  // 0x134
  private           UnityEngine.Transform           m_RootCanvasTransform  // 0x138
PROPERTIES:
  fontAsset  get=0x03D50EA0  set=0x056A2B64
  spriteAsset  get=0x03D51950  set=0x058B408C
  mainTexture  get=0x09D1453C
  material  get=0x09D145E0  set=0x09D145F0
  sharedMaterial  get=0x03D50770  set=0x09D146D8
  fallbackMaterial  get=0x03D56D30  set=0x025156D0
  fallbackSourceMaterial  get=0x03D56CF0  set=0x04275CF4
  materialForRendering  get=0x0303D660
  isDefaultMaterial  get=0x03D57B90  set=0x03D5E110
  padding  get=0x03D4FAF0  set=0x03D85490
  mesh  get=0x03441F50  set=0x04275CA4
  textComponent  get=0x0379BE00
METHODS:
  RVA=0x025159C0  token=0x60004BB  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  RVA=0x03D22CB0  token=0x60004BC  System.Void OnEnable()
  RVA=0x02514D80  token=0x60004BD  System.Void OnDisable()
  RVA=0x03771110  token=0x60004BE  System.Void OnDestroy()
  RVA=0x09D1444C  token=0x60004BF  System.Void OnTransformParentChanged()
  RVA=0x02515D80  token=0x60004C0  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  RVA=0x02515840  token=0x60004C1  System.Single GetPaddingForMaterial()
  RVA=0x09D142F4  token=0x60004C2  System.Single GetPaddingForMaterial(UnityEngine.Material mat)
  RVA=0x09D144C0  token=0x60004C3  System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold)
  RVA=0x0350B670  token=0x60004C4  System.Void SetAllDirty()
  RVA=0x03771280  token=0x60004C5  System.Void SetVerticesDirty()
  RVA=0x0350B670  token=0x60004C6  System.Void SetLayoutDirty()
  RVA=0x03CDDF00  token=0x60004C7  System.Void SetMaterialDirty()
  RVA=0x038015A0  token=0x60004C8  System.Void SetPivotDirty()
  RVA=0x09D14378  token=0x60004C9  UnityEngine.Transform GetRootCanvasTransform()
  RVA=0x0350B670  token=0x60004CA  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=0x0350B670  token=0x60004CB  System.Void UpdateGeometry()
  RVA=0x09D14490  token=0x60004CC  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x09381C74  token=0x60004CD  System.Void RefreshMaterial()
  RVA=0x0379BC30  token=0x60004CE  System.Void UpdateMaterial()
  RVA=0x02515D70  token=0x60004CF  System.Void RecalculateClipping()
  RVA=0x03D50770  token=0x60004D0  UnityEngine.Material GetMaterial()
  RVA=0x09D141E8  token=0x60004D1  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  RVA=0x09D14134  token=0x60004D2  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  RVA=0x09D14424  token=0x60004D3  UnityEngine.Material GetSharedMaterial()
  RVA=0x025157E0  token=0x60004D4  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x03D4C420  token=0x60004D5  System.Void .ctor()
END_CLASS

CLASS: TMPro.ITextElement
TYPE:  interface
TOKEN: 0x200008F
FIELDS:
PROPERTIES:
  sharedMaterial  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60004D7  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=-1  // abstract  token=0x60004D8  System.Int32 GetInstanceID()
END_CLASS

CLASS: TMPro.TextAlignmentOptions
TYPE:  sealed struct
TOKEN: 0x2000090
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextAlignmentOptions      TopLeft  // const
  public    static  TMPro.TextAlignmentOptions      Top  // const
  public    static  TMPro.TextAlignmentOptions      TopRight  // const
  public    static  TMPro.TextAlignmentOptions      TopJustified  // const
  public    static  TMPro.TextAlignmentOptions      TopFlush  // const
  public    static  TMPro.TextAlignmentOptions      TopGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      Left  // const
  public    static  TMPro.TextAlignmentOptions      Center  // const
  public    static  TMPro.TextAlignmentOptions      Right  // const
  public    static  TMPro.TextAlignmentOptions      Justified  // const
  public    static  TMPro.TextAlignmentOptions      Flush  // const
  public    static  TMPro.TextAlignmentOptions      CenterGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      BottomLeft  // const
  public    static  TMPro.TextAlignmentOptions      Bottom  // const
  public    static  TMPro.TextAlignmentOptions      BottomRight  // const
  public    static  TMPro.TextAlignmentOptions      BottomJustified  // const
  public    static  TMPro.TextAlignmentOptions      BottomFlush  // const
  public    static  TMPro.TextAlignmentOptions      BottomGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      BaselineLeft  // const
  public    static  TMPro.TextAlignmentOptions      Baseline  // const
  public    static  TMPro.TextAlignmentOptions      BaselineRight  // const
  public    static  TMPro.TextAlignmentOptions      BaselineJustified  // const
  public    static  TMPro.TextAlignmentOptions      BaselineFlush  // const
  public    static  TMPro.TextAlignmentOptions      BaselineGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      MidlineLeft  // const
  public    static  TMPro.TextAlignmentOptions      Midline  // const
  public    static  TMPro.TextAlignmentOptions      MidlineRight  // const
  public    static  TMPro.TextAlignmentOptions      MidlineJustified  // const
  public    static  TMPro.TextAlignmentOptions      MidlineFlush  // const
  public    static  TMPro.TextAlignmentOptions      MidlineGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      CaplineLeft  // const
  public    static  TMPro.TextAlignmentOptions      Capline  // const
  public    static  TMPro.TextAlignmentOptions      CaplineRight  // const
  public    static  TMPro.TextAlignmentOptions      CaplineJustified  // const
  public    static  TMPro.TextAlignmentOptions      CaplineFlush  // const
  public    static  TMPro.TextAlignmentOptions      CaplineGeoAligned  // const
  public    static  TMPro.TextAlignmentOptions      Converted  // const
METHODS:
END_CLASS

CLASS: TMPro.HorizontalAlignmentOptions
TYPE:  sealed struct
TOKEN: 0x2000091
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.HorizontalAlignmentOptionsLeft  // const
  public    static  TMPro.HorizontalAlignmentOptionsCenter  // const
  public    static  TMPro.HorizontalAlignmentOptionsRight  // const
  public    static  TMPro.HorizontalAlignmentOptionsJustified  // const
  public    static  TMPro.HorizontalAlignmentOptionsFlush  // const
  public    static  TMPro.HorizontalAlignmentOptionsGeometry  // const
METHODS:
END_CLASS

CLASS: TMPro.VerticalAlignmentOptions
TYPE:  sealed struct
TOKEN: 0x2000092
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.VerticalAlignmentOptions  Top  // const
  public    static  TMPro.VerticalAlignmentOptions  Middle  // const
  public    static  TMPro.VerticalAlignmentOptions  Bottom  // const
  public    static  TMPro.VerticalAlignmentOptions  Baseline  // const
  public    static  TMPro.VerticalAlignmentOptions  Geometry  // const
  public    static  TMPro.VerticalAlignmentOptions  Capline  // const
METHODS:
END_CLASS

CLASS: TMPro.TextRenderFlags
TYPE:  sealed struct
TOKEN: 0x2000093
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextRenderFlags           DontRender  // const
  public    static  TMPro.TextRenderFlags           Render  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_TextElementType
TYPE:  sealed struct
TOKEN: 0x2000094
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_TextElementType       Character  // const
  public    static  TMPro.TMP_TextElementType       Sprite  // const
  public    static  TMPro.TMP_TextElementType       Image  // const
METHODS:
END_CLASS

CLASS: TMPro.MaskingTypes
TYPE:  sealed struct
TOKEN: 0x2000095
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MaskingTypes              MaskOff  // const
  public    static  TMPro.MaskingTypes              MaskHard  // const
  public    static  TMPro.MaskingTypes              MaskSoft  // const
METHODS:
END_CLASS

CLASS: TMPro.TextOverflowModes
TYPE:  sealed struct
TOKEN: 0x2000096
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextOverflowModes         Overflow  // const
  public    static  TMPro.TextOverflowModes         Ellipsis  // const
  public    static  TMPro.TextOverflowModes         Masking  // const
  public    static  TMPro.TextOverflowModes         Truncate  // const
  public    static  TMPro.TextOverflowModes         ScrollRect  // const
  public    static  TMPro.TextOverflowModes         Page  // const
  public    static  TMPro.TextOverflowModes         Linked  // const
METHODS:
END_CLASS

CLASS: TMPro.MaskingOffsetMode
TYPE:  sealed struct
TOKEN: 0x2000097
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MaskingOffsetMode         Percentage  // const
  public    static  TMPro.MaskingOffsetMode         Pixel  // const
METHODS:
END_CLASS

CLASS: TMPro.TextureMappingOptions
TYPE:  sealed struct
TOKEN: 0x2000098
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextureMappingOptions     Character  // const
  public    static  TMPro.TextureMappingOptions     Line  // const
  public    static  TMPro.TextureMappingOptions     Paragraph  // const
  public    static  TMPro.TextureMappingOptions     MatchAspect  // const
METHODS:
END_CLASS

CLASS: TMPro.FontStyles
TYPE:  sealed struct
TOKEN: 0x2000099
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontStyles                Normal  // const
  public    static  TMPro.FontStyles                Bold  // const
  public    static  TMPro.FontStyles                Italic  // const
  public    static  TMPro.FontStyles                Underline  // const
  public    static  TMPro.FontStyles                LowerCase  // const
  public    static  TMPro.FontStyles                UpperCase  // const
  public    static  TMPro.FontStyles                SmallCaps  // const
  public    static  TMPro.FontStyles                Strikethrough  // const
  public    static  TMPro.FontStyles                Superscript  // const
  public    static  TMPro.FontStyles                Subscript  // const
  public    static  TMPro.FontStyles                Highlight  // const
  public    static  TMPro.FontStyles                Phonetic  // const
METHODS:
END_CLASS

CLASS: TMPro.FontWeight
TYPE:  sealed struct
TOKEN: 0x200009A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontWeight                Thin  // const
  public    static  TMPro.FontWeight                ExtraLight  // const
  public    static  TMPro.FontWeight                Light  // const
  public    static  TMPro.FontWeight                Regular  // const
  public    static  TMPro.FontWeight                Medium  // const
  public    static  TMPro.FontWeight                SemiBold  // const
  public    static  TMPro.FontWeight                Bold  // const
  public    static  TMPro.FontWeight                Heavy  // const
  public    static  TMPro.FontWeight                Black  // const
METHODS:
END_CLASS

CLASS: TMPro.PhoneticData
TYPE:  class
TOKEN: 0x200009B
SIZE:  0x28
FIELDS:
  public    static  TMPro.PhoneticData              Default  // static @ 0x0
  public            System.String                   m_phonetic  // 0x10
  public            System.Boolean                  m_autoSize  // 0x18
  public            System.Boolean                  m_padding  // 0x19
  public            System.Boolean                  m_justify  // 0x1a
  public            System.Int32                    m_length  // 0x1c
  public            System.Int32                    m_startIndex  // 0x20
  public            System.Int32                    m_startCharCount  // 0x24
METHODS:
  RVA=0x03C9C260  token=0x60004D9  System.Void .ctor()
  RVA=0x03C9C1F0  token=0x60004DA  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Text
TYPE:  abstract class
TOKEN: 0x200009C
SIZE:  0xAF8
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
  protected         System.String                   m_textForPopulate  // 0xe8
  protected         System.String                   m_text  // 0xf0
  private           System.Boolean                  m_IsTextBackingStringDirty  // 0xf8
  protected         TMPro.ITextPreprocessor         m_TextPreprocessor  // 0x100
  protected         System.Boolean                  m_isRightToLeft  // 0x108
  protected         TMPro.TMP_FontAsset             m_serializedFontAsset  // 0x110
  protected         TMPro.TMP_FontAsset             m_currentFontAsset  // 0x118
  protected         System.Boolean                  m_isSDFShader  // 0x120
  protected         UnityEngine.Material            m_serializedSharedMaterial  // 0x128
  protected         UnityEngine.Material            m_currentMaterial  // 0x130
  protected static  TMPro.MaterialReference[]       m_materialReferences  // static @ 0x0
  protected static  System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_materialReferenceIndexLookup  // static @ 0x8
  protected static  TMPro.TMP_TextProcessingStack<TMPro.MaterialReference>m_materialReferenceStack  // static @ 0x10
  protected         System.Int32                    m_currentMaterialIndex  // 0x138
  protected         UnityEngine.Material[]          m_fontSharedMaterials  // 0x140
  protected         UnityEngine.Material            m_fontMaterial  // 0x148
  protected         UnityEngine.Material[]          m_fontMaterials  // 0x150
  protected         System.Boolean                  m_isMaterialDirty  // 0x158
  protected         UnityEngine.Color32             m_fontColor32  // 0x15c
  protected         UnityEngine.Color               m_fontColor  // 0x160
  protected static  UnityEngine.Color32             s_colorWhite  // static @ 0x68
  protected         UnityEngine.Color32             m_underlineColor  // 0x170
  protected         UnityEngine.Color32             m_strikethroughColor  // 0x174
  protected         System.Boolean                  m_enableVertexGradient  // 0x178
  protected         TMPro.ColorMode                 m_colorMode  // 0x17c
  protected         TMPro.VertexGradient            m_fontColorGradient  // 0x180
  protected         TMPro.TMP_ColorGradient         m_fontColorGradientPreset  // 0x1c0
  protected         TMPro.TMP_SpriteAsset           m_spriteAsset  // 0x1c8
  protected         System.Boolean                  m_tintAllSprites  // 0x1d0
  protected         System.Boolean                  m_tintSprite  // 0x1d1
  protected         UnityEngine.Color32             m_spriteColor  // 0x1d4
  protected         TMPro.TMP_StyleSheet            m_StyleSheet  // 0x1d8
  private           TMPro.TMP_Style                 m_TextStyle  // 0x1e0
  protected         System.Int32                    m_TextStyleHashCode  // 0x1e8
  protected         System.Boolean                  m_overrideHtmlColors  // 0x1ec
  protected         UnityEngine.Color32             m_faceColor  // 0x1f0
  protected         UnityEngine.Color32             m_outlineColor  // 0x1f4
  protected         System.Single                   m_outlineWidth  // 0x1f8
  protected         System.Single                   m_fontSize  // 0x1fc
  protected         System.Single                   m_currentFontSize  // 0x200
  protected         System.Single                   m_fontSizeBase  // 0x204
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_sizeStack  // 0x208
  protected         System.Single                   m_imageWidth  // 0x228
  protected         System.Single                   m_imageHeight  // 0x22c
  protected         System.Single                   m_maxLineAscenderWithImage  // 0x230
  protected static  System.Single                   m_basePhoneticElementScale  // const
  protected         TMPro.FontStyles                m_phoneticFontStyle  // 0x234
  protected         TMPro.FontWeight                m_phoneticFontWeight  // 0x238
  protected         TMPro.WordWrapState             m_phoneticWordWarpState  // 0x240
  protected         System.Int32                    m_phoneticStartCharIndex  // 0x5d8
  protected         System.Int32                    m_phoneticStartIndex  // 0x5dc
  protected         System.Int32                    m_phoneticEndIndex  // 0x5e0
  protected         System.Boolean                  m_isPhoneticOverLength  // 0x5e4
  protected         System.Collections.Generic.List<System.Single>m_phoneticSizeList  // 0x5e8
  protected         TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData>m_phoneticDataQueue  // 0x5f0
  protected         TMPro.PhoneticData              m_currentPhoneticData  // 0x610
  protected         System.Int32                    m_phoneticCount  // 0x618
  protected         System.Single                   m_phoneticFontSize  // 0x61c
  protected         System.Boolean                  m_showPhonetic  // 0x620
  protected         System.Int32                    m_phoneticIndex  // 0x624
  protected         System.Boolean                  m_needParseActionId  // 0x628
  protected         TMPro.FontWeight                m_fontWeight  // 0x62c
  protected         TMPro.FontWeight                m_FontWeightInternal  // 0x630
  protected         TMPro.TMP_TextProcessingStack<TMPro.FontWeight>m_FontWeightStack  // 0x638
  protected         System.Boolean                  m_enableAutoSizing  // 0x658
  protected         System.Single                   m_maxFontSize  // 0x65c
  protected         System.Single                   m_minFontSize  // 0x660
  protected         System.Int32                    m_AutoSizeIterationCount  // 0x664
  protected         System.Int32                    m_AutoSizeMaxIterationCount  // 0x668
  protected         System.Boolean                  m_IsAutoSizePointSizeSet  // 0x66c
  protected         System.Single                   m_fontSizeMin  // 0x670
  protected         System.Single                   m_fontSizeMax  // 0x674
  protected         TMPro.FontStyles                m_fontStyle  // 0x678
  protected         TMPro.FontStyles                m_FontStyleInternal  // 0x67c
  protected         TMPro.TMP_FontStyleStack        m_fontStyleStack  // 0x680
  protected         System.Boolean                  m_isUsingBold  // 0x68a
  protected         TMPro.HorizontalAlignmentOptionsm_HorizontalAlignment  // 0x68c
  protected         TMPro.VerticalAlignmentOptions  m_VerticalAlignment  // 0x690
  protected         TMPro.TextAlignmentOptions      m_textAlignment  // 0x694
  protected         TMPro.HorizontalAlignmentOptionsm_lineJustification  // 0x698
  protected         TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions>m_lineJustificationStack  // 0x6a0
  protected         UnityEngine.Vector3[]           m_textContainerLocalCorners  // 0x6c0
  protected         System.Single                   m_characterSpacing  // 0x6c8
  protected         System.Single                   m_cSpacing  // 0x6cc
  protected         System.Single                   m_monoSpacing  // 0x6d0
  protected         System.Single                   m_wordSpacing  // 0x6d4
  protected         System.Single                   m_lineSpacing  // 0x6d8
  protected         System.Single                   m_lineSpacingDelta  // 0x6dc
  protected         System.Single                   m_lineHeight  // 0x6e0
  protected         System.Boolean                  m_IsDrivenLineSpacing  // 0x6e4
  protected         System.Single                   m_lineSpacingMax  // 0x6e8
  protected         System.Single                   m_paragraphSpacing  // 0x6ec
  protected         System.Single                   m_charWidthMaxAdj  // 0x6f0
  protected         System.Single                   m_charWidthAdjDelta  // 0x6f4
  protected         System.Boolean                  m_enableWordWrapping  // 0x6f8
  protected         System.Boolean                  m_isCharacterWrappingEnabled  // 0x6f9
  protected         System.Boolean                  m_isNonBreakingSpace  // 0x6fa
  protected         System.Boolean                  m_isIgnoringAlignment  // 0x6fb
  protected         System.Single                   m_wordWrappingRatios  // 0x6fc
  protected         TMPro.TextOverflowModes         m_overflowMode  // 0x700
  protected         System.Int32                    m_firstOverflowCharacterIndex  // 0x704
  protected         TMPro.TMP_Text                  m_linkedTextComponent  // 0x708
  private           TMPro.TMP_Text                  parentLinkedComponent  // 0x710
  protected         System.Boolean                  m_isTextTruncated  // 0x718
  protected         System.Boolean                  m_enableKerning  // 0x719
  protected         System.Single                   m_GlyphHorizontalAdvanceAdjustment  // 0x71c
  protected         System.Boolean                  m_enableExtraPadding  // 0x720
  protected         System.Boolean                  checkPaddingRequired  // 0x721
  protected         System.Boolean                  m_isRichText  // 0x722
  protected         System.Boolean                  m_enableHyperlink  // 0x723
  protected         System.Single                   m_richTextColorBlend  // 0x724
  protected         System.Boolean                  m_parseCtrlCharacters  // 0x728
  protected         System.Boolean                  m_isOverlay  // 0x729
  protected         System.Boolean                  m_isOrthographic  // 0x72a
  protected         System.Boolean                  m_isCullingEnabled  // 0x72b
  protected         System.Boolean                  m_isMaskingEnabled  // 0x72c
  protected         System.Boolean                  isMaskUpdateRequired  // 0x72d
  protected         System.Boolean                  m_ignoreCulling  // 0x72e
  protected         TMPro.TextureMappingOptions     m_horizontalMapping  // 0x730
  protected         TMPro.TextureMappingOptions     m_verticalMapping  // 0x734
  protected         System.Single                   m_uvLineOffset  // 0x738
  protected         TMPro.TextRenderFlags           m_renderMode  // 0x73c
  protected         TMPro.VertexSortingOrder        m_geometrySortingOrder  // 0x740
  protected         System.Boolean                  m_IsTextObjectScaleStatic  // 0x744
  protected         System.Boolean                  m_VertexBufferAutoSizeReduction  // 0x745
  protected         System.Int32                    m_firstVisibleCharacter  // 0x748
  protected         System.Int32                    m_maxVisibleCharacters  // 0x74c
  protected         System.Int32                    m_maxVisibleWords  // 0x750
  protected         System.Int32                    m_maxVisibleLines  // 0x754
  protected         System.Boolean                  m_useMaxVisibleDescender  // 0x758
  protected         System.Int32                    m_pageToDisplay  // 0x75c
  protected         System.Boolean                  m_isNewPage  // 0x760
  protected         UnityEngine.Vector4             m_margin  // 0x764
  protected         System.Single                   m_marginLeft  // 0x774
  protected         System.Single                   m_marginRight  // 0x778
  protected         System.Single                   m_marginWidth  // 0x77c
  protected         System.Single                   m_marginHeight  // 0x780
  protected         System.Single                   m_width  // 0x784
  protected         TMPro.TMP_TextInfo              m_textInfo  // 0x788
  protected         System.Boolean                  m_havePropertiesChanged  // 0x790
  protected         System.Boolean                  m_isUsingLegacyAnimationComponent  // 0x791
  protected         UnityEngine.Transform           m_transform  // 0x798
  protected         UnityEngine.RectTransform       m_rectTransform  // 0x7a0
  protected         UnityEngine.Vector2             m_PreviousRectTransformSize  // 0x7a8
  protected         UnityEngine.Vector2             m_PreviousPivotPosition  // 0x7b0
  private           System.Boolean                  <autoSizeTextContainer>k__BackingField  // 0x7b8
  protected         System.Boolean                  m_autoSizeTextContainer  // 0x7b9
  protected         UnityEngine.Mesh                m_mesh  // 0x7c0
  protected         System.Boolean                  m_isVolumetricText  // 0x7c8
  private   static  System.Func<System.Int32,System.String,TMPro.TMP_FontAsset>OnFontAssetRequest  // static @ 0x70
  private   static  System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset>OnSpriteAssetRequest  // static @ 0x78
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0x7d0
  protected         TMPro.TMP_SpriteAnimator        m_spriteAnimator  // 0x7d8
  protected         System.Single                   m_flexibleHeight  // 0x7e0
  protected         System.Single                   m_flexibleWidth  // 0x7e4
  protected         System.Single                   m_minWidth  // 0x7e8
  protected         System.Single                   m_minHeight  // 0x7ec
  protected         System.Single                   m_maxWidth  // 0x7f0
  protected         System.Single                   m_maxHeight  // 0x7f4
  protected         UnityEngine.UI.LayoutElement    m_LayoutElement  // 0x7f8
  protected         System.Single                   m_preferredWidth  // 0x800
  protected         System.Single                   m_renderedWidth  // 0x804
  protected         System.Boolean                  m_isPreferredWidthDirty  // 0x808
  protected         System.Single                   m_preferredHeight  // 0x80c
  protected         System.Single                   m_renderedHeight  // 0x810
  protected         System.Boolean                  m_isPreferredHeightDirty  // 0x814
  protected         System.Boolean                  m_isCalculatingPreferredValues  // 0x815
  protected         System.Int32                    m_layoutPriority  // 0x818
  protected         System.Boolean                  m_isLayoutDirty  // 0x81c
  protected         System.Boolean                  m_isAwake  // 0x81d
  private           System.Boolean                  m_isWaitingOnResourceLoad  // 0x81e
  protected         System.Boolean                  m_isInit  // 0x81f
  private           TMPro.TMP_Text.TextInputSources m_inputSource  // 0x820
  protected         System.Single                   m_fontScaleMultiplier  // 0x824
  private   static  System.Char[]                   m_htmlTag  // static @ 0x80
  protected static  TMPro.RichTextTagAttribute[]    m_xmlAttribute  // static @ 0x88
  private   static  System.Single[]                 m_attributeParameterValues  // static @ 0x90
  protected         System.Single                   tag_LineIndent  // 0x828
  protected         System.Single                   tag_Indent  // 0x82c
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_indentStack  // 0x830
  protected         System.Boolean                  tag_NoParsing  // 0x850
  protected         System.Boolean                  m_isParsingText  // 0x851
  protected         UnityEngine.Matrix4x4           m_FXMatrix  // 0x854
  protected         System.Boolean                  m_isFXMatrixSet  // 0x894
  protected         TMPro.TMP_Text.UnicodeChar[]    m_TextProcessingArray  // 0x898
  private           System.Int32                    m_InternalTextProcessingArraySize  // 0x8a0
  private           TMPro.TMP_CharacterInfo[]       m_internalCharacterInfo  // 0x8a8
  protected         System.Int32                    m_totalCharacterCount  // 0x8b0
  protected static  TMPro.WordWrapState             m_SavedWordWrapState  // static @ 0x98
  protected static  TMPro.WordWrapState             m_SavedLineState  // static @ 0x430
  protected static  TMPro.WordWrapState             m_SavedEllipsisState  // static @ 0x7c8
  protected static  TMPro.WordWrapState             m_SavedLastValidState  // static @ 0xb60
  protected static  TMPro.WordWrapState             m_SavedSoftLineBreakState  // static @ 0xef8
  protected static  TMPro.TMP_TextProcessingStack<TMPro.WordWrapState>m_EllipsisInsertionCandidateStack  // static @ 0x1290
  protected         System.Int32                    m_characterCount  // 0x8b4
  protected         System.Int32                    m_firstCharacterOfLine  // 0x8b8
  protected         System.Int32                    m_firstVisibleCharacterOfLine  // 0x8bc
  protected         System.Int32                    m_lastCharacterOfLine  // 0x8c0
  protected         System.Int32                    m_lastVisibleCharacterOfLine  // 0x8c4
  protected         System.Int32                    m_lineNumber  // 0x8c8
  protected         System.Int32                    m_lineVisibleCharacterCount  // 0x8cc
  protected         System.Int32                    m_pageNumber  // 0x8d0
  protected         System.Single                   m_PageAscender  // 0x8d4
  protected         System.Single                   m_maxTextAscender  // 0x8d8
  protected         System.Single                   m_maxCapHeight  // 0x8dc
  protected         System.Single                   m_ElementAscender  // 0x8e0
  protected         System.Single                   m_ElementDescender  // 0x8e4
  protected         System.Single                   m_maxLineAscender  // 0x8e8
  protected         System.Single                   m_maxLineDescender  // 0x8ec
  protected         System.Single                   m_startOfLineAscender  // 0x8f0
  protected         System.Single                   m_startOfLineDescender  // 0x8f4
  protected         System.Single                   m_lineOffset  // 0x8f8
  protected         TMPro.Extents                   m_meshExtents  // 0x8fc
  protected         UnityEngine.Color32             m_htmlColor  // 0x90c
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_colorStack  // 0x910
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_underlineColorStack  // 0x930
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_strikethroughColorStack  // 0x950
  protected         TMPro.TMP_TextProcessingStack<TMPro.HighlightState>m_HighlightStateStack  // 0x970
  protected         TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient>m_colorGradientStack  // 0x9a0
  protected         TMPro.TMP_ColorGradient         m_colorGradientPreset  // 0x9c8
  protected         System.Boolean                  m_colorGradientPresetIsTinted  // 0x9d0
  protected         System.Single                   m_tabSpacing  // 0x9d4
  protected         System.Single                   m_spacing  // 0x9d8
  protected         TMPro.TMP_TextProcessingStack<System.Int32>[]m_TextStyleStacks  // 0x9e0
  protected         TMPro.TMP_TextProcessingStack<System.Int32>m_ItalicAngleStack  // 0x9e8
  protected         TMPro.TMP_TextProcessingStack<System.Int32>m_actionStack  // 0xa08
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_baselineOffsetStack  // 0xa28
  protected         System.Int32                    m_TextStyleStackDepth  // 0xa48
  protected         System.Int32                    m_ItalicAngle  // 0xa4c
  protected         System.Single                   m_padding  // 0xa50
  protected         System.Single                   m_baselineOffset  // 0xa54
  protected         System.Single                   m_xAdvance  // 0xa58
  protected         System.Single                   m_lastCharAdvance  // 0xa5c
  protected         System.Boolean                  m_lastIsUpVowels  // 0xa60
  protected         System.Boolean                  m_lastIsAscender  // 0xa61
  protected         System.Boolean                  m_lastIsDescender  // 0xa62
  protected         System.Single                   m_lastHeight  // 0xa64
  protected static  System.Boolean                  s_forceLeftAlign  // static @ 0x1648
  protected         TMPro.TMP_TextElementType       m_textElementType  // 0xa68
  protected         TMPro.TMP_TextElement           m_cached_TextElement  // 0xa70
  protected         TMPro.TMP_Text.SpecialCharacter m_Ellipsis  // 0xa78
  protected         TMPro.TMP_Text.SpecialCharacter m_Underline  // 0xa98
  protected         TMPro.TMP_SpriteAsset           m_defaultSpriteAsset  // 0xab8
  protected         TMPro.TMP_SpriteAsset           m_currentSpriteAsset  // 0xac0
  protected         System.Int32                    m_spriteCount  // 0xac8
  protected         System.Int32                    m_spriteIndex  // 0xacc
  protected         System.Int32                    m_spriteAnimationID  // 0xad0
  private   static  Unity.Profiling.ProfilerMarker  k_ParseTextMarker  // static @ 0x1650
  private   static  Unity.Profiling.ProfilerMarker  k_InsertNewLineMarker  // static @ 0x1658
  protected         System.Boolean                  m_ignoreActiveState  // 0xad4
  private           TMPro.TMP_Text.TextBackingContainerm_TextBackingArray  // 0xad8
  private   readonly System.Decimal[]                k_Power  // 0xae8
  protected static  UnityEngine.Vector2             k_LargePositiveVector2  // static @ 0x1660
  protected static  UnityEngine.Vector2             k_LargeNegativeVector2  // static @ 0x1668
  protected static  System.Single                   k_LargePositiveFloat  // static @ 0x1670
  protected static  System.Single                   k_LargeNegativeFloat  // static @ 0x1674
  protected static  System.Int32                    k_LargePositiveInt  // static @ 0x1678
  protected static  System.Int32                    k_LargeNegativeInt  // static @ 0x167c
  private           System.Boolean                  m_dynamicFontAssetUsed  // 0xaf0
PROPERTIES:
  text  get=0x031E7010  set=0x030CAB10
  textForPopulate  get=0x02815E50
  textPreprocessor  get=0x03D50770  set=0x055631FC
  isRightToLeftText  get=0x03D57BA0  set=0x09D0DD5C
  font  get=0x04273118  set=0x09D0DBC4
  m_fontAsset  get=0x03D56CF0  set=0x04275CF4
  fontSharedMaterial  get=0x03D56F00  set=0x09D0DA5C
  m_sharedMaterial  get=0x03D56F00  set=0x04275CB8
  fontSharedMaterials  get=0x09D0CDCC  set=0x09D0DA20
  fontMaterial  get=0x09D0CD78  set=0x09D0D944
  fontMaterials  get=0x09D0CD8C  set=0x09D0DA20
  color  get=0x03CA4A40  set=0x038DF5F0
  alpha  get=0x03D582A0  set=0x09D0D600
  enableVertexGradient  get=0x03D57C50  set=0x09D0D808
  colorGradient  get=0x03D850C0  set=0x09D0D6F8
  colorGradientPreset  get=0x03D571E0  set=0x09D0D6C4
  spriteAsset  get=0x03D571D0  set=0x09D0E354
  tintAllSprites  get=0x03D57AF0  set=0x09D0E43C
  styleSheet  get=0x03D50210  set=0x09D0E398
  textStyle  get=0x0296C560  set=0x09D0E3DC
  overrideColorTags  get=0x03D6DF30  set=0x09D0E1F8
  faceColor  get=0x09D0CCB0  set=0x09D0D8B8
  outlineColor  get=0x09D0CFC4  set=0x09D0E104
  outlineWidth  get=0x09D0D08C  set=0x09D0E15C
  fontSize  get=0x03D59A20  set=0x02CD08B0
  PhoneticElementScale  get=0x09D0CBEC
  m_currentPhonetic  get=0x09D0CF60
  m_currentEnablePhoneticAutoPadding  get=0x03B1EB90
  m_currentEnablePhoneticAutoSize  get=0x09D0CEFC
  m_currentEnablePhoneticAutoJustify  get=0x09D0CE98
  fontWeight  get=0x03D851C0  set=0x09D0DB80
  pixelsPerUnit  get=0x09D0D13C
  enableAutoSizing  get=0x03D850F0  set=0x09D0D73C
  fontSizeMin  get=0x03D851A0  set=0x09D0DAF4
  fontSizeMax  get=0x03D85190  set=0x02CD15B0
  fontStyle  get=0x03D851B0  set=0x09D0DB3C
  isUsingBold  get=0x03D85260
  horizontalAlignment  get=0x03D851F0  set=0x09D0DC88
  verticalAlignment  get=0x03D853E0  set=0x09D0E4AC
  alignment  get=0x03D85080  set=0x09D0D5C4
  characterSpacing  get=0x03D850A0  set=0x09D0D62C
  wordSpacing  get=0x03D85400  set=0x09D0E4FC
  lineSpacing  get=0x03D852B0  set=0x09D0DEA0
  lineSpacingAdjustment  get=0x03D852A0  set=0x09D0DE54
  paragraphSpacing  get=0x03D85360  set=0x09D0E248
  characterWidthAdjustment  get=0x03D850B0  set=0x09D0D678
  enableWordWrapping  get=0x03D85130  set=0x09D0D830
  wordWrappingRatios  get=0x03D85410  set=0x09D0E548
  overflowMode  get=0x03D65E10  set=0x09D0E1B4
  isTextOverflowing  get=0x09D0CDFC
  firstOverflowCharacterIndex  get=0x03D85150
  linkedTextComponent  get=0x03D6C480  set=0x09D0DEEC
  isTextTruncated  get=0x03D85250
  enableKerning  get=0x03D85120  set=0x09D0D7C4
  extraPadding  get=0x03D85140  set=0x09D0D874
  richText  get=0x03D853A0  set=0x09D0E310
  enableHyperlink  get=0x03D85110  set=0x09D0D7AC
  richTextColorBlend  get=0x03D85390  set=0x09D0E2F0
  parseCtrlCharacters  get=0x03D85370  set=0x09D0E294
  isOverlay  get=0x03D85230  set=0x09D0DD18
  isOrthographic  get=0x03D85220  set=0x09D0DCF0
  enableCulling  get=0x03D85100  set=0x09D0D778
  ignoreVisibility  get=0x03D85210  set=0x09D0DCD8
  horizontalMapping  get=0x03D85200  set=0x09D0DCB0
  verticalMapping  get=0x03D853F0  set=0x09D0E4D4
  mappingUvLineOffset  get=0x03D852C0  set=0x09D0DFE0
  renderMode  get=0x03D85380  set=0x09D0E2D8
  geometrySortingOrder  get=0x03D851D0  set=0x09D0DC68
  isTextObjectScaleStatic  get=0x03D85240  set=0x09D0DDA0
  vertexBufferAutoSizeReduction  get=0x03D853D0  set=0x09D0E48C
  firstVisibleCharacter  get=0x03D85160  set=0x09D0D91C
  maxVisibleCharacters  get=0x03D852F0  set=0x03B3CE20
  maxVisibleWords  get=0x03D85310  set=0x09D0E0DC
  maxVisibleLines  get=0x03D85300  set=0x09D0E0B4
  useMaxVisibleDescender  get=0x03D853C0  set=0x09D0E464
  pageToDisplay  get=0x03D85350  set=0x09D0E220
  margin  get=0x03D852D0  set=0x09D0E00C
  textInfo  get=0x03D853B0
  havePropertiesChanged  get=0x03D851E0  set=0x03771340
  isUsingLegacyAnimationComponent  get=0x03D85270  set=0x03D85430
  transform  get=0x02517370
  rectTransform  get=0x024A5A00
  autoSizeTextContainer  get=0x03D85090  set=0x03D85420
  mesh  get=0x03D84BD0
  isVolumetricText  get=0x03D85280  set=0x09D0DE00
  bounds  get=0x09D0CC0C
  textBounds  get=0x09D0D350
  spriteAnimator  get=0x09D0D25C
  flexibleHeight  get=0x03D85170
  flexibleWidth  get=0x03D85180
  minWidth  get=0x03D85340
  minHeight  get=0x03D85330
  maxWidth  get=0x03D85320
  maxHeight  get=0x03D852E0
  layoutElement  get=0x09D0CE08
  preferredWidth  get=0x04270798
  preferredHeight  get=0x04270768
  renderedWidth  get=0x09D085D8
  renderedHeight  get=0x09D084E8
  layoutPriority  get=0x03D85290
EVENTS:
  OnFontAssetRequest  add=add_OnFontAssetRequest  remove=remove_OnFontAssetRequest
  OnSpriteAssetRequest  add=add_OnSpriteAssetRequest  remove=remove_OnSpriteAssetRequest
  OnPreRenderText  add=add_OnPreRenderText  remove=remove_OnPreRenderText
METHODS:
  RVA=0x09D0B84C  token=0x60004DE  System.Void ResetTextForPopulate()
  RVA=0x09D0A85C  token=0x60004DF  System.Void RefreshPopulateText()
  RVA=0x01002730  token=0x60004E6  UnityEngine.Material LoadMaterial(System.String path)
  RVA=0x04271BC8  token=0x600058E  System.Void Awake()
  RVA=0x0285ED80  token=0x600058F  System.Void InitDataFromPool()
  RVA=0x0285E910  token=0x6000590  System.Void OnDestroy()
  RVA=0x0350B670  token=0x6000591  System.Void LoadFontAsset()
  RVA=0x0350B670  token=0x6000592  System.Void SetSharedMaterial(UnityEngine.Material mat)
  RVA=0x01002730  token=0x6000593  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  RVA=0x0350B670  token=0x6000594  System.Void SetFontBaseMaterial(UnityEngine.Material mat)
  RVA=0x01002730  token=0x6000595  UnityEngine.Material[] GetSharedMaterials()
  RVA=0x0350B670  token=0x6000596  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  RVA=0x01002730  token=0x6000597  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  RVA=0x09D0423C  token=0x6000598  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  RVA=0x09D0C92C  token=0x6000599  System.Void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient)
  RVA=0x0350B670  token=0x600059A  System.Void SetTextSortingOrder(TMPro.VertexSortingOrder order)
  RVA=0x0350B670  token=0x600059B  System.Void SetTextSortingOrder(System.Int32[] order)
  RVA=0x0350B670  token=0x600059C  System.Void SetFaceColor(UnityEngine.Color32 color)
  RVA=0x0350B670  token=0x600059D  System.Void SetOutlineColor(UnityEngine.Color32 color)
  RVA=0x0350B670  token=0x600059E  System.Void SetOutlineThickness(System.Single thickness)
  RVA=0x0350B670  token=0x600059F  System.Void SetShaderDepth()
  RVA=0x0350B670  token=0x60005A0  System.Void SetCulling()
  RVA=0x0350B670  token=0x60005A1  System.Void UpdateCulling()
  RVA=0x0296AD80  token=0x60005A2  System.Single GetPaddingForMaterial()
  RVA=0x09D07FC8  token=0x60005A3  System.Single GetPaddingForMaterial(UnityEngine.Material mat)
  RVA=0x01002730  token=0x60005A4  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  RVA=0x0350B670  token=0x60005A5  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  RVA=0x0350B670  token=0x60005A6  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  RVA=0x0350B670  token=0x60005A7  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  RVA=0x0350B670  token=0x60005A8  System.Void UpdateVertexData()
  RVA=0x0350B670  token=0x60005A9  System.Void SetVertices(UnityEngine.Vector3[] vertices)
  RVA=0x0350B670  token=0x60005AA  System.Void UpdateMeshPadding()
  RVA=0x038711D0  token=0x60005AB  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  RVA=0x09D042F0  token=0x60005AC  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x0350B670  token=0x60005AD  System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  RVA=0x0350B670  token=0x60005AE  System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x02815D20  token=0x60005AF  System.Void ParseInputText()
  RVA=0x02815F10  token=0x60005B0  System.Void PopulateTextBackingArray(System.String sourceText)
  RVA=0x02817820  token=0x60005B1  System.Void PopulateTextBackingArray(System.String sourceText, System.Int32 start, System.Int32 length)
  RVA=0x09D0A660  token=0x60005B2  System.Void PopulateTextBackingArray(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length)
  RVA=0x09D0A760  token=0x60005B3  System.Void PopulateTextBackingArray(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  RVA=0x02571E80  token=0x60005B4  System.Void PopulateTextProcessingArray()
  RVA=0x09D0C3D0  token=0x60005B5  System.Void SetTextInternal(System.String sourceText)
  RVA=0x02CB5860  token=0x60005B6  System.Void SetText(System.String sourceText, System.Boolean syncTextInputBox)
  RVA=0x09D0C888  token=0x60005B7  System.Void SetText(System.String sourceText, System.Single arg0)
  RVA=0x09D0C424  token=0x60005B8  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1)
  RVA=0x09D0C7F8  token=0x60005B9  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2)
  RVA=0x09D0C83C  token=0x60005BA  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3)
  RVA=0x09D0C7A0  token=0x60005BB  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4)
  RVA=0x09D0C6D8  token=0x60005BC  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5)
  RVA=0x09D0C738  token=0x60005BD  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6)
  RVA=0x09D0C48C  token=0x60005BE  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6, System.Single arg7)
  RVA=0x09D0C460  token=0x60005BF  System.Void SetText(System.Text.StringBuilder sourceText)
  RVA=0x09D0C8D4  token=0x60005C0  System.Void SetText(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length)
  RVA=0x09D0C3A8  token=0x60005C1  System.Void SetText(System.Char[] sourceText)
  RVA=0x09D0C8C4  token=0x60005C2  System.Void SetText(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  RVA=0x09D0C3A8  token=0x60005C3  System.Void SetCharArray(System.Char[] sourceText)
  RVA=0x09D0C350  token=0x60005C4  System.Void SetCharArray(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  RVA=0x0296C5B0  token=0x60005C5  TMPro.TMP_Style GetStyle(System.Int32 hashCode)
  RVA=0x09D0B084  token=0x60005C6  System.Boolean ReplaceOpeningStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D0B44C  token=0x60005C7  System.Boolean ReplaceOpeningStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D0A984  token=0x60005C8  System.Void ReplaceClosingStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D0AD0C  token=0x60005C9  System.Void ReplaceClosingStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D09F68  token=0x60005CA  System.Boolean InsertOpeningStyleTag(TMPro.TMP_Style style, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D09BEC  token=0x60005CB  System.Void InsertClosingStyleTag(TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  RVA=0x09D07F14  token=0x60005CC  System.Int32 GetMarkupTagHashCode(System.Int32[] tagDefinition, System.Int32 readIndex)
  RVA=0x034B63C0  token=0x60005CD  System.Int32 GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, System.Int32 readIndex)
  RVA=0x09D085F4  token=0x60005CE  System.Int32 GetStyleHashCode(System.Int32[]& text, System.Int32 index, System.Int32& closeIndex)
  RVA=0x09D086B4  token=0x60005CF  System.Int32 GetStyleHashCode(TMPro.TMP_Text.TextBackingContainer& text, System.Int32 index, System.Int32& closeIndex)
  RVA=-1  // generic def  token=0x60005D0  System.Void ResizeInternalArray(T[]& array)
  RVA=-1  // generic def  token=0x60005D1  System.Void ResizeInternalArray(T[]& array, System.Int32 size)
  RVA=0x09D03770  token=0x60005D2  System.Void AddFloatToInternalTextBackingArray(System.Single value, System.Int32 padding, System.Int32 precision, System.Int32& writeIndex)
  RVA=0x09D03A54  token=0x60005D3  System.Void AddIntegerToInternalTextBackingArray(System.Double number, System.Int32 padding, System.Int32& writeIndex)
  RVA=0x09D0A2E4  token=0x60005D4  System.String InternalTextBackingArrayToString()
  RVA=0x01002730  token=0x60005D5  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  RVA=0x09D083FC  token=0x60005D6  UnityEngine.Vector2 GetPreferredValues()
  RVA=0x09D08254  token=0x60005D7  UnityEngine.Vector2 GetPreferredValues(System.Single width, System.Single height)
  RVA=0x09D082BC  token=0x60005D8  UnityEngine.Vector2 GetPreferredValues(System.String text)
  RVA=0x09D08384  token=0x60005D9  UnityEngine.Vector2 GetPreferredValues(System.String text, System.Single width, System.Single height)
  RVA=0x0296AEE0  token=0x60005DA  System.Single GetPreferredWidth()
  RVA=0x09D08450  token=0x60005DB  System.Single GetPreferredWidth(UnityEngine.Vector2 margin)
  RVA=0x031BE5C0  token=0x60005DC  System.Single GetPreferredHeight()
  RVA=0x09D081A4  token=0x60005DD  System.Single GetPreferredHeight(UnityEngine.Vector2 margin)
  RVA=0x09D08560  token=0x60005DE  UnityEngine.Vector2 GetRenderedValues()
  RVA=0x09D08504  token=0x60005DF  UnityEngine.Vector2 GetRenderedValues(System.Boolean onlyVisibleCharacters)
  RVA=0x09D085D8  token=0x60005E0  System.Single GetRenderedWidth()
  RVA=0x09D085BC  token=0x60005E1  System.Single GetRenderedWidth(System.Boolean onlyVisibleCharacters)
  RVA=0x09D084E8  token=0x60005E2  System.Single GetRenderedHeight()
  RVA=0x09D084CC  token=0x60005E3  System.Single GetRenderedHeight(System.Boolean onlyVisibleCharacters)
  RVA=0x0296CBA0  token=0x60005E4  UnityEngine.Vector2 CalculatePreferredValues(System.Single& fontSize, UnityEngine.Vector2 marginSize, System.Boolean isTextAutoSizingEnabled, System.Boolean isWordWrappingEnabled)
  RVA=0x03D595C0  token=0x60005E5  UnityEngine.Bounds GetCompoundBounds()
  RVA=0x03D605F0  token=0x60005E6  UnityEngine.Rect GetCanvasSpaceClippingRect()
  RVA=0x09D08AB4  token=0x60005E7  UnityEngine.Bounds GetTextBounds()
  RVA=0x09D0877C  token=0x60005E8  UnityEngine.Bounds GetTextBounds(System.Boolean onlyVisibleCharacters)
  RVA=0x09D03B6C  token=0x60005E9  System.Void AdjustLineOffset(System.Int32 startIndex, System.Int32 endIndex, System.Single offset)
  RVA=0x09D0B85C  token=0x60005EA  System.Void ResizeLineExtents(System.Int32 size)
  RVA=0x01002730  token=0x60005EB  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  RVA=0x0350B670  token=0x60005EC  System.Void ComputeMarginSize()
  RVA=0x0285D8F0  token=0x60005ED  System.Void InsertNewLine(System.Int32 i, System.Single baseScale, System.Single currentElementScale, System.Single currentEmScale, System.Single glyphAdjustment, System.Single boldSpacingAdjustment, System.Single characterSpacingAdjustment, System.Single width, System.Single lineGap, System.Boolean& isMaxVisibleDescenderSet, System.Single& maxVisibleDescender)
  RVA=0x0296B720  token=0x60005EE  System.Void SaveWordWrappingState(TMPro.WordWrapState& state, System.Int32 index, System.Int32 count)
  RVA=0x0314E6F0  token=0x60005EF  System.Int32 RestoreWordWrappingState(TMPro.WordWrapState& state)
  RVA=0x025745E0  token=0x60005F0  System.Void SaveGlyphVertexInfo(System.Single padding, System.Single style_padding, UnityEngine.Color32 vertexColor)
  RVA=0x09D0BAE4  token=0x60005F1  System.Void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor)
  RVA=0x02574C70  token=0x60005F2  System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4)
  RVA=0x09D06A48  token=0x60005F3  System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4, System.Boolean isVolumetric)
  RVA=0x09D07634  token=0x60005F4  System.Void FillSpriteVertexBuffers(System.Int32 i, System.Int32 index_X4)
  RVA=0x09D05B58  token=0x60005F5  System.Void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, System.Single startScale, System.Single endScale, System.Single maxScale, System.Single sdfScale, UnityEngine.Color32 underlineColor)
  RVA=0x09D0A484  token=0x60005F6  System.Single PhoneticWidth(System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding)
  RVA=0x09D04350  token=0x60005F7  System.Boolean DrawPhoneticMesh(UnityEngine.Rect rect, System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding, System.Boolean autoSize, System.Int32 phoneticIndex, System.Boolean justify, System.Single lossyScale)
  RVA=0x09D0567C  token=0x60005F8  System.Void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, UnityEngine.Color32 highlightColor)
  RVA=0x02814400  token=0x60005F9  System.Void LoadDefaultSettings()
  RVA=0x0296AD50  token=0x60005FA  System.Void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset)
  RVA=0x0296A890  token=0x60005FB  System.Void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset)
  RVA=0x0296ABE0  token=0x60005FC  System.Void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset)
  RVA=0x09D0B7F4  token=0x60005FD  System.Void ReplaceTagWithCharacter(System.Int32[] chars, System.Int32 insertionIndex, System.Int32 tagLength, System.Char c)
  RVA=0x09D07E90  token=0x60005FE  TMPro.TMP_FontAsset GetFontAssetForWeight(System.Int32 fontWeight)
  RVA=0x02570B30  token=0x60005FF  TMPro.TMP_TextElement GetTextElement(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isUsingAlternativeTypeface)
  RVA=0x0239E5F0  token=0x6000600  System.Void TryRemoveDynamicFallbackFontAssetTextRef()
  RVA=0x0350B670  token=0x6000601  System.Void SetActiveSubMeshes(System.Boolean state)
  RVA=0x0350B670  token=0x6000602  System.Void DestroySubMeshObjects()
  RVA=0x0350B670  token=0x6000603  System.Void ClearMesh()
  RVA=0x0350B670  token=0x6000604  System.Void ClearMesh(System.Boolean uploadGeometry)
  RVA=0x09D080BC  token=0x6000605  System.String GetParsedText()
  RVA=0x09D0A3BC  token=0x6000606  System.Boolean IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent)
  RVA=0x09D0A88C  token=0x6000607  System.Void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent)
  RVA=0x03D85040  token=0x6000608  UnityEngine.Vector2 PackUV(System.Single x, System.Single y, System.Single scale)
  RVA=0x03D85000  token=0x6000609  System.Single PackUV(System.Single x, System.Single y)
  RVA=0x0350B670  token=0x600060A  System.Void InternalUpdate()
  RVA=0x030DCFB0  token=0x600060B  System.Int32 HexToInt(System.Char hex)
  RVA=0x09D08F8C  token=0x600060C  System.Int32 GetUTF16(System.String text, System.Int32 i)
  RVA=0x09D08EAC  token=0x600060D  System.Int32 GetUTF16(System.Int32[] text, System.Int32 i)
  RVA=0x09D0914C  token=0x600060E  System.Int32 GetUTF16(System.UInt32[] text, System.Int32 i)
  RVA=0x09D08DC4  token=0x600060F  System.Int32 GetUTF16(System.Text.StringBuilder text, System.Int32 i)
  RVA=0x09D09074  token=0x6000610  System.Int32 GetUTF16(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i)
  RVA=0x09D0922C  token=0x6000611  System.Int32 GetUTF32(System.String text, System.Int32 i)
  RVA=0x09D09518  token=0x6000612  System.Int32 GetUTF32(System.Int32[] text, System.Int32 i)
  RVA=0x09D093A4  token=0x6000613  System.Int32 GetUTF32(System.UInt32[] text, System.Int32 i)
  RVA=0x09D097EC  token=0x6000614  System.Int32 GetUTF32(System.Text.StringBuilder text, System.Int32 i)
  RVA=0x09D0968C  token=0x6000615  System.Int32 GetUTF32(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i)
  RVA=0x030DCDA0  token=0x6000616  UnityEngine.Color32 HexCharsToColor(System.ReadOnlySpan<System.Char> hexChars, System.Int32 tagCount)
  RVA=0x09D09964  token=0x6000617  UnityEngine.Color32 HexCharsToColor(System.ReadOnlySpan<System.Char> hexChars, System.Int32 startIndex, System.Int32 length)
  RVA=0x09D07DE4  token=0x6000618  System.Int32 GetAttributeParameters(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Single[]& parameters)
  RVA=0x09D04218  token=0x6000619  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length)
  RVA=0x09D040D8  token=0x600061A  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Int32& lastIndex)
  RVA=0x09D04050  token=0x600061B  System.Boolean CheckIfEndPhonetic(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex)
  RVA=0x030DC0C0  token=0x600061C  System.Boolean ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex, System.Int32& endIndex)
  RVA=0x02845730  token=0x600061D  System.Void .ctor()
  RVA=0x037F5270  token=0x600061E  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextElementType
TYPE:  sealed struct
TOKEN: 0x20000A3
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  TMPro.TextElementType           Character  // const
  public    static  TMPro.TextElementType           Sprite  // const
METHODS:
END_CLASS

CLASS: TMPro.TMP_TextElement
TYPE:  class
TOKEN: 0x20000A4
SIZE:  0x30
FIELDS:
  protected         TMPro.TextElementType           m_ElementType  // 0x10
  private           System.UInt32                   m_Unicode  // 0x14
  private           TMPro.TMP_Asset                 m_TextAsset  // 0x18
  private           UnityEngine.TextCore.Glyph      m_Glyph  // 0x20
  private           System.UInt32                   m_GlyphIndex  // 0x28
  private           System.Single                   m_Scale  // 0x2c
PROPERTIES:
  elementType  get=0x011797F0
  unicode  get=0x03D50CC0  set=0x03D595B0
  textAsset  get=0x01041090  set=0x022C3A90
  glyph  get=0x03D4EB40  set=0x04271930
  glyphIndex  get=0x03D4EB90  set=0x03D4EBA0
  scale  get=0x03D4F3A0  set=0x03D4F3B0
METHODS:
  RVA=0x0350B670  token=0x6000637  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_TextElement_Legacy
TYPE:  class
TOKEN: 0x20000A5
SIZE:  0x38
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Single                   x  // 0x14
  public            System.Single                   y  // 0x18
  public            System.Single                   width  // 0x1c
  public            System.Single                   height  // 0x20
  public            System.Single                   xOffset  // 0x24
  public            System.Single                   yOffset  // 0x28
  public            System.Single                   xAdvance  // 0x2c
  public            System.Single                   scale  // 0x30
METHODS:
  RVA=0x0350B670  token=0x6000638  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_TextInfo
TYPE:  class
TOKEN: 0x20000A6
SIZE:  0x78
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  UnityEngine.Vector2             k_InfinityVectorPositive  // static @ 0x0
  private   static  UnityEngine.Vector2             k_InfinityVectorNegative  // static @ 0x8
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    characterCount  // 0x18
  public            System.Int32                    spriteCount  // 0x1c
  public            System.Int32                    spaceCount  // 0x20
  public            System.Int32                    wordCount  // 0x24
  public            System.Int32                    linkCount  // 0x28
  public            System.Int32                    lineCount  // 0x2c
  public            System.Int32                    pageCount  // 0x30
  public            System.Int32                    materialCount  // 0x34
  public            System.Int32                    characterToSubstituteIndex  // 0x38
  public            TMPro.TMP_CharacterInfo[]       characterInfo  // 0x40
  public            TMPro.TMP_WordInfo[]            wordInfo  // 0x48
  public            TMPro.TMP_LinkInfo[]            linkInfo  // 0x50
  public            TMPro.TMP_LineInfo[]            lineInfo  // 0x58
  public            TMPro.TMP_PageInfo[]            pageInfo  // 0x60
  public            TMPro.TMP_MeshInfo[]            meshInfo  // 0x68
  private           TMPro.TMP_MeshInfo[]            m_CachedMeshInfo  // 0x70
METHODS:
  RVA=0x09D15F90  token=0x6000639  System.Void .ctor()
  RVA=0x09D16140  token=0x600063A  System.Void .ctor(System.Int32 characterCount)
  RVA=0x02813D20  token=0x600063B  System.Void .ctor(TMPro.TMP_Text textComponent)
  RVA=0x030D1390  token=0x600063C  System.Void Clear()
  RVA=0x09D15748  token=0x600063D  System.Void ClearAllData()
  RVA=0x09D15908  token=0x600063E  System.Void ClearMeshInfo(System.Boolean updateMesh)
  RVA=0x09D15888  token=0x600063F  System.Void ClearAllMeshInfo()
  RVA=0x09D15F00  token=0x6000640  System.Void ResetVertexLayout(System.Boolean isVolumetric)
  RVA=0x09D15998  token=0x6000641  System.Void ClearUnusedVertices(TMPro.MaterialReference[] materials)
  RVA=0x02574280  token=0x6000642  System.Void ClearLineInfo()
  RVA=0x02DF80F0  token=0x6000643  System.Void ClearPageInfo()
  RVA=0x09D15A18  token=0x6000644  TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData()
  RVA=-1  // generic def  token=0x6000645  System.Void Resize(T[]& array, System.Int32 size)
  RVA=-1  // generic def  token=0x6000646  System.Void Resize(T[]& array, System.Int32 size, System.Boolean isBlockAllocated)
  RVA=0x0285E2C0  token=0x6000647  System.Void Dispose()
  RVA=0x03D26950  token=0x6000648  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_TextParsingUtilities
TYPE:  class
TOKEN: 0x20000A7
SIZE:  0x10
FIELDS:
  private   static readonly TMPro.TMP_TextParsingUtilities  s_Instance  // static @ 0x0
  private   static  System.String                   k_LookupStringL  // const
  private   static  System.String                   k_LookupStringU  // const
PROPERTIES:
  instance  get=0x09D1648C
METHODS:
  RVA=0x03D1AC90  token=0x6000649  System.Void .cctor()
  RVA=0x033025E0  token=0x600064B  System.Int32 GetHashCode(System.String s)
  RVA=0x09D162F8  token=0x600064C  System.Int32 GetHashCodeCaseSensitive(System.String s)
  RVA=0x09D1637C  token=0x600064D  System.Char ToLowerASCIIFast(System.Char c)
  RVA=0x03302690  token=0x600064E  System.Char ToUpperASCIIFast(System.Char c)
  RVA=0x09D16430  token=0x600064F  System.UInt32 ToUpperASCIIFast(System.UInt32 c)
  RVA=0x09D163D4  token=0x6000650  System.UInt32 ToLowerASCIIFast(System.UInt32 c)
  RVA=0x09D1634C  token=0x6000651  System.Boolean IsHighSurrogate(System.UInt32 c)
  RVA=0x09D16364  token=0x6000652  System.Boolean IsLowSurrogate(System.UInt32 c)
  RVA=0x03D854A0  token=0x6000653  System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate)
  RVA=0x0350B670  token=0x6000654  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_FontStyleStack
TYPE:  sealed struct
TOKEN: 0x20000A8
SIZE:  0x1A
FIELDS:
  public            System.Byte                     bold  // 0x10
  public            System.Byte                     italic  // 0x11
  public            System.Byte                     underline  // 0x12
  public            System.Byte                     strikethrough  // 0x13
  public            System.Byte                     highlight  // 0x14
  public            System.Byte                     superscript  // 0x15
  public            System.Byte                     subscript  // 0x16
  public            System.Byte                     uppercase  // 0x17
  public            System.Byte                     lowercase  // 0x18
  public            System.Byte                     smallcaps  // 0x19
METHODS:
  RVA=0x0311E3C0  token=0x6000655  System.Void Clear()
  RVA=0x09D0F218  token=0x6000656  System.Byte Add(TMPro.FontStyles style)
  RVA=0x09D0F2B8  token=0x6000657  System.Byte Remove(TMPro.FontStyles style)
END_CLASS

CLASS: TMPro.TMP_TextProcessingStack`1
TYPE:  sealed struct
TOKEN: 0x20000A9
IMPLEMENTS: System.IDisposable
FIELDS:
  public            T[]                             itemStack  // 0x0
  public            System.Int32                    index  // 0x0
  private           T                               m_DefaultItem  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32                    m_RolloverSize  // 0x0
  private           System.Int32                    m_Count  // 0x0
  private   static  System.Int32                    k_DefaultCapacity  // const
PROPERTIES:
  Count  get=-1  // not resolved
  current  get=-1  // not resolved
  rolloverSize  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000658  System.Void .ctor(T[] stack)
  RVA=-1  // not resolved  token=0x6000659  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600065A  System.Void .ctor(System.Int32 capacity, System.Int32 rolloverSize)
  RVA=-1  // not resolved  token=0x600065F  System.Void SetDefault(TMPro.TMP_TextProcessingStack<T>[] stack, T item)
  RVA=-1  // not resolved  token=0x6000660  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000661  System.Void SetDefault(T item)
  RVA=-1  // not resolved  token=0x6000662  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000663  T Remove()
  RVA=-1  // not resolved  token=0x6000664  System.Void Push(T item)
  RVA=-1  // not resolved  token=0x6000665  T Pop()
  RVA=-1  // not resolved  token=0x6000666  T Peek()
  RVA=-1  // not resolved  token=0x6000667  T CurrentItem()
  RVA=-1  // not resolved  token=0x6000668  T PreviousItem()
  RVA=-1  // not resolved  token=0x6000669  System.Void RestoreFrom(TMPro.TMP_TextProcessingStack<T> other)
  RVA=-1  // not resolved  token=0x600066A  System.Void Dispose()
END_CLASS

CLASS: TMPro.TMP_TextProcessingQueue`1
TYPE:  sealed struct
TOKEN: 0x20000AA
IMPLEMENTS: System.IDisposable
FIELDS:
  public            T[]                             itemQueue  // 0x0
  private           System.Int32                    m_Head  // 0x0
  private           System.Int32                    m_Tail  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32                    m_Count  // 0x0
  private           T                               m_DefaultItem  // 0x0
  private   static  System.Int32                    k_DefaultCapacity  // const
PROPERTIES:
  Count  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600066B  System.Void .ctor(T[] queue)
  RVA=-1  // not resolved  token=0x600066C  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600066E  System.Void Clear()
  RVA=-1  // not resolved  token=0x600066F  System.Void SetDefault(T item)
  RVA=-1  // not resolved  token=0x6000670  System.Void Enqueue(T item)
  RVA=-1  // not resolved  token=0x6000671  T Dequeue()
  RVA=-1  // not resolved  token=0x6000672  T Peek()
  RVA=-1  // not resolved  token=0x6000673  System.Void Resize(System.Int32 newCapacity)
  RVA=-1  // not resolved  token=0x6000674  System.Void RestoreFrom(TMPro.TMP_TextProcessingQueue<T> other)
  RVA=-1  // not resolved  token=0x6000675  System.Void Dispose()
END_CLASS

CLASS: TMPro.CaretPosition
TYPE:  sealed struct
TOKEN: 0x20000AB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.CaretPosition             None  // const
  public    static  TMPro.CaretPosition             Left  // const
  public    static  TMPro.CaretPosition             Right  // const
METHODS:
END_CLASS

CLASS: TMPro.CaretInfo
TYPE:  sealed struct
TOKEN: 0x20000AC
SIZE:  0x18
FIELDS:
  public            System.Int32                    index  // 0x10
  public            TMPro.CaretPosition             position  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x6000676  System.Void .ctor(System.Int32 index, TMPro.CaretPosition position)
END_CLASS

CLASS: TMPro.TMP_TextUtilities
TYPE:  static class
TOKEN: 0x20000AD
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.Vector3[]           m_rectWorldCorners  // static @ 0x0
  private   static  System.String                   k_lookupStringL  // const
  private   static  System.String                   k_lookupStringU  // const
METHODS:
  RVA=0x09D1982C  token=0x6000677  System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D199E0  token=0x6000678  System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, TMPro.CaretPosition& cursor)
  RVA=0x09D180E0  token=0x6000679  System.Int32 FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D177F8  token=0x600067A  System.Int32 FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, System.Int32 line, UnityEngine.Camera camera, System.Boolean visibleOnly)
  RVA=0x09D1A05C  token=0x600067B  System.Boolean IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D166B4  token=0x600067C  System.Int32 FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly)
  RVA=0x09D17C94  token=0x600067D  System.Int32 FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly)
  RVA=0x09D170D4  token=0x600067E  System.Int32 FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D18D80  token=0x600067F  System.Int32 FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D16984  token=0x6000680  System.Int32 FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D16B14  token=0x6000681  System.Int32 FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D182DC  token=0x6000682  System.Int32 FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  RVA=0x09D1A244  token=0x6000683  System.Boolean PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d)
  RVA=0x09D1A410  token=0x6000684  System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint)
  RVA=0x09D19E38  token=0x6000685  System.Boolean IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Vector3& intersectingPoint)
  RVA=0x09D164DC  token=0x6000686  System.Single DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point)
  RVA=0x09D1A684  token=0x6000687  System.Char ToLowerFast(System.Char c)
  RVA=0x09D1A6DC  token=0x6000688  System.Char ToUpperFast(System.Char c)
  RVA=0x034B6480  token=0x6000689  System.UInt32 ToUpperASCIIFast(System.UInt32 c)
  RVA=0x09D19C20  token=0x600068A  System.Int32 GetHashCode(System.String s)
  RVA=0x02EE8BD0  token=0x600068B  System.Int32 GetSimpleHashCode(System.String s)
  RVA=0x09D19CB0  token=0x600068C  System.UInt32 GetSimpleHashCodeLowercase(System.String s)
  RVA=0x09D19D44  token=0x600068D  System.Int32 HexToInt(System.Char hex)
  RVA=0x09D1A5D4  token=0x600068E  System.Int32 StringHexToInt(System.String s)
  RVA=0x02C9DF30  token=0x600068F  System.Boolean IsThaiZeroWidthCharacter(System.Char c)
  RVA=0x02C9E040  token=0x6000690  System.Boolean IsUpVowel(System.Char c)
  RVA=0x02C9DFE0  token=0x6000691  System.Boolean IsLowVowel(System.Char c)
  RVA=0x02C9E010  token=0x6000692  System.Boolean IsToneMark(System.Char c)
  RVA=0x02EE9BD0  token=0x6000693  System.Boolean IsAscenderThai(System.Char c)
  RVA=0x03009330  token=0x6000694  System.Boolean IsDescenderThai(System.Char c)
  RVA=0x03D04E80  token=0x6000695  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_UpdateManager
TYPE:  class
TOKEN: 0x20000AF
SIZE:  0x50
FIELDS:
  private   static  TMPro.TMP_UpdateManager         s_Instance  // static @ 0x0
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_LayoutQueueLookup  // 0x10
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_LayoutRebuildQueue  // 0x18
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_GraphicQueueLookup  // 0x20
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_GraphicRebuildQueue  // 0x28
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_InternalUpdateLookup  // 0x30
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_InternalUpdateQueue  // 0x38
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_CullingUpdateLookup  // 0x40
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_CullingUpdateQueue  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextObjectForUpdateMarker  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextElementForGraphicRebuildMarker  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextElementForCullingUpdateMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_UnregisterTextObjectForUpdateMarker  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_UnregisterTextElementForGraphicRebuildMarker  // static @ 0x28
PROPERTIES:
  instance  get=0x023A0100
METHODS:
  RVA=0x02CD0370  token=0x6000698  System.Void .ctor()
  RVA=0x0239FC70  token=0x6000699  System.Void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  RVA=0x0239FB50  token=0x600069A  System.Void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  RVA=0x09D1B784  token=0x600069B  System.Void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  RVA=0x09D1B540  token=0x600069C  System.Void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  RVA=0x09D1B72C  token=0x600069D  System.Void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  RVA=0x09D1B484  token=0x600069E  System.Void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  RVA=0x030D1570  token=0x600069F  System.Void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element)
  RVA=0x030D15E0  token=0x60006A0  System.Void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element)
  RVA=0x09D1B724  token=0x60006A1  System.Void OnCameraPreCull()
  RVA=0x02343120  token=0x60006A2  System.Void DoRebuilds()
  RVA=0x023A0090  token=0x60006A3  System.Void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  RVA=0x09D1B7DC  token=0x60006A4  System.Void UnRegisterTextElementForRebuild(TMPro.TMP_Text element)
  RVA=0x09D1B5FC  token=0x60006A5  System.Void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  RVA=0x09D1B690  token=0x60006A6  System.Void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  RVA=0x023A0200  token=0x60006A7  System.Void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  RVA=0x03B1D820  token=0x60006A8  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_UpdateRegistry
TYPE:  class
TOKEN: 0x20000B0
SIZE:  0x30
FIELDS:
  private   static  TMPro.TMP_UpdateRegistry        s_Instance  // static @ 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>m_LayoutRebuildQueue  // 0x10
  private           System.Collections.Generic.HashSet<System.Int32>m_LayoutQueueLookup  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>m_GraphicRebuildQueue  // 0x20
  private           System.Collections.Generic.HashSet<System.Int32>m_GraphicQueueLookup  // 0x28
PROPERTIES:
  instance  get=0x09D1BFA4
METHODS:
  RVA=0x09D1BE30  token=0x60006AA  System.Void .ctor()
  RVA=0x09D1BDB8  token=0x60006AB  System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1B954  token=0x60006AC  System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1BD88  token=0x60006AD  System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1B868  token=0x60006AE  System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1BBD0  token=0x60006AF  System.Void PerformUpdateForCanvasRendererObjects()
  RVA=0x09D1BD34  token=0x60006B0  System.Void PerformUpdateForMeshRendererObjects()
  RVA=0x09D1BDE8  token=0x60006B1  System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1BB08  token=0x60006B2  System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09D1BA40  token=0x60006B3  System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
END_CLASS

CLASS: TMPro.SpriteAssetUtilities.SpriteAssetImportFormats
TYPE:  sealed struct
TOKEN: 0x20000B1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.SpriteAssetUtilities.SpriteAssetImportFormatsNone  // const
  public    static  TMPro.SpriteAssetUtilities.SpriteAssetImportFormatsTexturePackerJsonArray  // const
METHODS:
END_CLASS

CLASS: TMPro.SpriteAssetUtilities.TexturePacker_JsonArray
TYPE:  class
TOKEN: 0x20000B2
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60006B4  System.Void .ctor()
END_CLASS

